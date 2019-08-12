
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
                                             From_Bool | .NET Core 2.0 | 13.579 ns | 0.0279 ns | 0.0261 ns | 13.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.295 ns | 0.0138 ns | 0.0129 ns | 10.296 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.742 ns | 0.0132 ns | 0.0124 ns |  6.742 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.432 ns | 0.0086 ns | 0.0076 ns | 10.433 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.430 ns | 0.0496 ns | 0.0439 ns | 11.425 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.003 ns | 0.0254 ns | 0.0238 ns | 17.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.599 ns | 0.0141 ns | 0.0110 ns | 15.598 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.542 ns | 0.0473 ns | 0.0443 ns | 15.534 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.423 ns | 0.0225 ns | 0.0210 ns | 19.422 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.500 ns | 0.1170 ns | 0.1094 ns | 18.488 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.803 ns | 0.0357 ns | 0.0316 ns | 11.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.455 ns | 0.0367 ns | 0.0344 ns | 10.444 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.171 ns | 0.0096 ns | 0.0090 ns |  7.171 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.518 ns | 0.0345 ns | 0.0323 ns | 10.511 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.935 ns | 0.0697 ns | 0.0652 ns | 10.939 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.227 ns | 0.0267 ns | 0.0250 ns | 18.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.140 ns | 0.0363 ns | 0.0339 ns | 16.149 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.665 ns | 0.0384 ns | 0.0360 ns | 16.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 17.910 ns | 0.0266 ns | 0.0249 ns | 17.908 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 19.478 ns | 0.1085 ns | 0.1015 ns | 19.481 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.537 ns | 0.0162 ns | 0.0152 ns | 11.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.243 ns | 0.0274 ns | 0.0257 ns | 10.247 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.536 ns | 0.0266 ns | 0.0235 ns |  6.536 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.661 ns | 0.2333 ns | 0.2182 ns | 10.617 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 11.716 ns | 0.0589 ns | 0.0492 ns | 11.707 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.072 ns | 0.0438 ns | 0.0410 ns | 14.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.628 ns | 0.0088 ns | 0.0082 ns | 14.627 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.366 ns | 0.1224 ns | 0.1145 ns | 11.437 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 12.952 ns | 0.0703 ns | 0.0658 ns | 12.924 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 14.048 ns | 0.0549 ns | 0.0513 ns | 14.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.989 ns | 0.0088 ns | 0.0082 ns | 11.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.599 ns | 0.0110 ns | 0.0102 ns | 11.601 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.633 ns | 0.0185 ns | 0.0164 ns |  6.635 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.349 ns | 0.0150 ns | 0.0140 ns | 10.350 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.729 ns | 0.0834 ns | 0.0739 ns | 10.716 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.290 ns | 0.0279 ns | 0.0261 ns | 18.291 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.077 ns | 0.0417 ns | 0.0390 ns | 16.070 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 14.991 ns | 0.0342 ns | 0.0320 ns | 14.982 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.194 ns | 0.0290 ns | 0.0272 ns | 18.198 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 19.042 ns | 0.3637 ns | 0.4042 ns | 18.846 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.736 ns | 0.0285 ns | 0.0253 ns | 11.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.348 ns | 0.0146 ns | 0.0137 ns | 10.350 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.724 ns | 0.0088 ns | 0.0082 ns |  6.723 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.533 ns | 0.0287 ns | 0.0269 ns | 10.528 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.752 ns | 0.0635 ns | 0.0594 ns | 10.750 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.233 ns | 0.0355 ns | 0.0332 ns | 18.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.339 ns | 0.0199 ns | 0.0186 ns | 15.337 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.842 ns | 0.0225 ns | 0.0210 ns | 15.847 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 17.941 ns | 0.0295 ns | 0.0276 ns | 17.938 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.508 ns | 0.1134 ns | 0.1060 ns | 18.500 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.899 ns | 0.2558 ns | 0.2393 ns | 11.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.245 ns | 0.0190 ns | 0.0178 ns | 10.244 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.623 ns | 0.0710 ns | 0.0664 ns |  6.583 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.724 ns | 0.0125 ns | 0.0111 ns | 11.725 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.557 ns | 0.0771 ns | 0.0683 ns | 10.568 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.931 ns | 0.0318 ns | 0.0297 ns | 13.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.373 ns | 0.0106 ns | 0.0100 ns | 13.375 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.775 ns | 0.1961 ns | 0.1835 ns | 13.671 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.851 ns | 0.0527 ns | 0.0493 ns | 14.844 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.507 ns | 0.0368 ns | 0.0344 ns | 13.514 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.013 ns | 0.0153 ns | 0.0144 ns | 12.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.436 ns | 0.1688 ns | 0.1579 ns | 10.412 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.638 ns | 0.0076 ns | 0.0071 ns |  6.640 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.200 ns | 0.0174 ns | 0.0163 ns | 10.204 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.021 ns | 0.0721 ns | 0.0639 ns | 12.009 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.140 ns | 0.0352 ns | 0.0329 ns | 19.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.494 ns | 0.0187 ns | 0.0174 ns | 16.491 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.366 ns | 0.0209 ns | 0.0195 ns | 15.367 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 19.344 ns | 0.0533 ns | 0.0499 ns | 19.340 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 18.310 ns | 0.0575 ns | 0.0510 ns | 18.306 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.748 ns | 0.0336 ns | 0.0314 ns | 11.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.337 ns | 0.0107 ns | 0.0095 ns | 10.336 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.047 ns | 0.0157 ns | 0.0139 ns |  7.046 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.534 ns | 0.0138 ns | 0.0122 ns | 10.535 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.838 ns | 0.0794 ns | 0.0743 ns | 10.849 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.465 ns | 0.0379 ns | 0.0355 ns | 19.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.501 ns | 0.0435 ns | 0.0407 ns | 16.504 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.487 ns | 0.0317 ns | 0.0296 ns | 16.489 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 17.863 ns | 0.0589 ns | 0.0551 ns | 17.851 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 18.490 ns | 0.1389 ns | 0.1300 ns | 18.483 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.528 ns | 0.0227 ns | 0.0190 ns | 11.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.231 ns | 0.0170 ns | 0.0159 ns | 10.233 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.052 ns | 0.1169 ns | 0.1093 ns |  7.119 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.282 ns | 0.0125 ns | 0.0111 ns | 10.281 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.538 ns | 0.0988 ns | 0.0924 ns | 10.540 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.955 ns | 0.0149 ns | 0.0132 ns | 13.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.554 ns | 0.0100 ns | 0.0093 ns | 12.554 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.452 ns | 0.0817 ns | 0.0764 ns | 11.487 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 12.949 ns | 0.0210 ns | 0.0196 ns | 12.953 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 14.484 ns | 0.0980 ns | 0.0917 ns | 14.486 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.915 ns | 0.0435 ns | 0.0363 ns | 11.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.190 ns | 0.0314 ns | 0.0294 ns | 11.190 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.835 ns | 0.0128 ns | 0.0113 ns |  7.836 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 11.665 ns | 0.0176 ns | 0.0165 ns | 11.667 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.188 ns | 0.1164 ns | 0.1089 ns | 13.179 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.899 ns | 0.0164 ns | 0.0153 ns | 12.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.678 ns | 0.0065 ns | 0.0061 ns | 11.677 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.363 ns | 0.1810 ns | 0.1693 ns |  8.421 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.431 ns | 0.0210 ns | 0.0196 ns | 13.430 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.588 ns | 0.0589 ns | 0.0551 ns | 13.603 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.844 ns | 0.0336 ns | 0.0314 ns | 12.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.670 ns | 0.0119 ns | 0.0105 ns | 11.672 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.966 ns | 0.0063 ns | 0.0059 ns |  7.966 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.097 ns | 0.0281 ns | 0.0262 ns | 13.102 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.425 ns | 0.1006 ns | 0.0941 ns | 13.405 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.752 ns | 0.0137 ns | 0.0121 ns | 15.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.363 ns | 0.0071 ns | 0.0067 ns | 13.361 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.026 ns | 0.2438 ns | 0.2281 ns | 12.849 ns |  0.83 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 12.952 ns | 0.0235 ns | 0.0220 ns | 12.949 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.244 ns | 0.0660 ns | 0.0617 ns | 14.257 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 22.174 ns | 0.0196 ns | 0.0174 ns | 22.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.197 ns | 0.0298 ns | 0.0278 ns | 20.199 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.370 ns | 0.0572 ns | 0.0535 ns | 13.399 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.594 ns | 0.0307 ns | 0.0287 ns | 21.595 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.522 ns | 0.1303 ns | 0.1219 ns | 22.545 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.449 ns | 0.0658 ns | 0.0616 ns | 26.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.621 ns | 0.0706 ns | 0.0661 ns | 25.596 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 18.856 ns | 0.1402 ns | 0.1311 ns | 18.792 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 35.996 ns | 0.0663 ns | 0.0620 ns | 35.999 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 26.914 ns | 0.1554 ns | 0.1454 ns | 26.868 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.160 ns | 0.0342 ns | 0.0320 ns | 22.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.590 ns | 0.0343 ns | 0.0320 ns | 20.588 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.592 ns | 0.0195 ns | 0.0173 ns | 15.589 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.628 ns | 0.2162 ns | 0.2022 ns | 23.528 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.309 ns | 0.1432 ns | 0.1339 ns | 23.314 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.614 ns | 0.0200 ns | 0.0187 ns | 26.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.009 ns | 0.0150 ns | 0.0125 ns | 25.011 ns |  0.94 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.789 ns | 0.0344 ns | 0.0322 ns | 18.787 ns |  0.71 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.754 ns | 0.0247 ns | 0.0231 ns | 26.752 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.600 ns | 0.1787 ns | 0.1672 ns | 27.566 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.633 ns | 0.0291 ns | 0.0273 ns | 12.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.241 ns | 0.0100 ns | 0.0094 ns | 11.239 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.382 ns | 0.2115 ns | 0.4985 ns |  9.551 ns |  0.70 |    0.07 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.956 ns | 0.0294 ns | 0.0275 ns | 13.954 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.762 ns | 0.0796 ns | 0.0745 ns | 13.736 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.805 ns | 0.0159 ns | 0.0148 ns | 14.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.529 ns | 0.0141 ns | 0.0132 ns | 12.527 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.228 ns | 0.0236 ns | 0.0221 ns | 11.228 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 14.798 ns | 0.0162 ns | 0.0151 ns | 14.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.576 ns | 0.0629 ns | 0.0589 ns | 13.574 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 14.451 ns | 0.0135 ns | 0.0119 ns | 14.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.074 ns | 0.0143 ns | 0.0134 ns | 12.074 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  8.340 ns | 0.0137 ns | 0.0128 ns |  8.342 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.585 ns | 0.0171 ns | 0.0160 ns | 13.591 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.316 ns | 0.1625 ns | 0.1520 ns | 15.347 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.588 ns | 0.0494 ns | 0.0462 ns | 21.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.863 ns | 0.0329 ns | 0.0292 ns | 17.875 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.523 ns | 0.2545 ns | 0.2380 ns | 17.379 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.776 ns | 0.0685 ns | 0.0641 ns | 21.762 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 22.518 ns | 0.1339 ns | 0.1252 ns | 22.508 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.444 ns | 0.0291 ns | 0.0272 ns | 15.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.422 ns | 0.0137 ns | 0.0128 ns | 12.420 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.207 ns | 0.0097 ns | 0.0091 ns | 10.209 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.549 ns | 0.0245 ns | 0.0229 ns | 16.555 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.373 ns | 0.1603 ns | 0.1499 ns | 16.301 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.439 ns | 0.0397 ns | 0.0371 ns | 21.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.146 ns | 0.0359 ns | 0.0336 ns | 18.158 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.078 ns | 0.0197 ns | 0.0184 ns | 16.070 ns |  0.75 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 22.976 ns | 0.0188 ns | 0.0157 ns | 22.972 ns |  1.07 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.380 ns | 0.1881 ns | 0.1760 ns | 22.474 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.368 ns | 0.0332 ns | 0.0310 ns | 12.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.232 ns | 0.0067 ns | 0.0063 ns | 11.232 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.300 ns | 0.0440 ns | 0.0411 ns |  8.287 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.521 ns | 0.0115 ns | 0.0108 ns | 12.517 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.934 ns | 0.1214 ns | 0.1136 ns | 12.918 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.927 ns | 0.0139 ns | 0.0130 ns | 13.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.365 ns | 0.0111 ns | 0.0104 ns | 13.366 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.908 ns | 0.1897 ns | 0.1774 ns | 14.975 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.818 ns | 0.0147 ns | 0.0137 ns | 14.821 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.416 ns | 0.0666 ns | 0.0590 ns | 13.409 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.222 ns | 0.0178 ns | 0.0166 ns | 12.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.304 ns | 0.0125 ns | 0.0117 ns | 10.310 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.692 ns | 0.0060 ns | 0.0053 ns |  6.692 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.796 ns | 0.0268 ns | 0.0250 ns | 10.789 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 11.072 ns | 0.0637 ns | 0.0532 ns | 11.060 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.027 ns | 0.0498 ns | 0.0441 ns | 19.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.770 ns | 0.0368 ns | 0.0326 ns | 15.762 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.216 ns | 0.0568 ns | 0.0474 ns | 15.238 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 18.895 ns | 0.0206 ns | 0.0193 ns | 18.893 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.562 ns | 0.1679 ns | 0.1488 ns | 19.543 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.866 ns | 0.0201 ns | 0.0188 ns | 11.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.469 ns | 0.0124 ns | 0.0116 ns | 10.470 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.291 ns | 0.0101 ns | 0.0095 ns |  7.292 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 11.868 ns | 0.0130 ns | 0.0122 ns | 11.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.395 ns | 0.0803 ns | 0.0751 ns | 12.394 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.830 ns | 0.0183 ns | 0.0171 ns | 18.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.819 ns | 0.0203 ns | 0.0190 ns | 15.818 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.185 ns | 0.0659 ns | 0.0616 ns | 16.163 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.934 ns | 0.0473 ns | 0.0443 ns | 18.939 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 19.423 ns | 0.1112 ns | 0.0985 ns | 19.418 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.619 ns | 0.0271 ns | 0.0240 ns | 11.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.268 ns | 0.0113 ns | 0.0106 ns | 10.271 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.003 ns | 0.0311 ns | 0.0291 ns |  7.009 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.275 ns | 0.0068 ns | 0.0057 ns | 10.277 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.449 ns | 0.0332 ns | 0.0277 ns | 10.443 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.738 ns | 0.0198 ns | 0.0185 ns | 15.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.499 ns | 0.0258 ns | 0.0242 ns | 12.500 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.190 ns | 0.0120 ns | 0.0112 ns | 11.188 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 12.935 ns | 0.0242 ns | 0.0227 ns | 12.944 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.530 ns | 0.0875 ns | 0.0776 ns | 13.520 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.190 ns | 0.0134 ns | 0.0119 ns | 12.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.299 ns | 0.0201 ns | 0.0188 ns | 10.303 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.015 ns | 0.0338 ns | 0.0316 ns |  6.999 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.779 ns | 0.0288 ns | 0.0269 ns | 10.783 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.088 ns | 0.0951 ns | 0.0743 ns | 11.079 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.677 ns | 0.0584 ns | 0.0546 ns | 18.682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.349 ns | 0.0253 ns | 0.0237 ns | 16.349 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.882 ns | 0.0716 ns | 0.0670 ns | 15.888 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.601 ns | 0.0203 ns | 0.0169 ns | 18.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 19.329 ns | 0.0985 ns | 0.0873 ns | 19.335 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.451 ns | 0.0211 ns | 0.0197 ns | 12.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.499 ns | 0.0328 ns | 0.0307 ns | 10.496 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  6.759 ns | 0.0097 ns | 0.0091 ns |  6.762 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.834 ns | 0.0161 ns | 0.0150 ns | 12.835 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.113 ns | 0.1044 ns | 0.0976 ns | 12.125 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.659 ns | 0.0627 ns | 0.0587 ns | 18.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.392 ns | 0.0787 ns | 0.0698 ns | 16.375 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.295 ns | 0.2788 ns | 0.2608 ns | 16.141 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.739 ns | 0.0453 ns | 0.0402 ns | 18.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 19.220 ns | 0.1131 ns | 0.1058 ns | 19.190 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.643 ns | 0.0175 ns | 0.0164 ns | 11.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.284 ns | 0.0411 ns | 0.0365 ns | 10.294 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.838 ns | 0.1618 ns | 0.1589 ns |  6.905 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.279 ns | 0.0125 ns | 0.0117 ns | 10.280 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.924 ns | 0.0977 ns | 0.0815 ns | 11.911 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.770 ns | 0.0374 ns | 0.0350 ns | 14.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.541 ns | 0.0164 ns | 0.0154 ns | 12.545 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.434 ns | 0.3090 ns | 0.4125 ns | 14.770 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.028 ns | 0.0293 ns | 0.0274 ns | 13.033 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.676 ns | 0.0933 ns | 0.0779 ns | 13.653 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.474 ns | 0.0078 ns | 0.0073 ns | 12.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.444 ns | 0.0096 ns | 0.0090 ns | 11.444 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.654 ns | 0.0083 ns | 0.0078 ns |  6.655 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.430 ns | 0.0187 ns | 0.0175 ns | 12.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.996 ns | 0.0468 ns | 0.0391 ns | 10.986 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.428 ns | 0.0320 ns | 0.0299 ns | 20.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.048 ns | 0.0509 ns | 0.0476 ns | 16.044 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.671 ns | 0.1293 ns | 0.1209 ns | 15.651 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.377 ns | 0.0257 ns | 0.0240 ns | 18.373 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.984 ns | 0.0434 ns | 0.0362 ns | 18.988 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.585 ns | 0.0256 ns | 0.0227 ns | 12.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.307 ns | 0.0185 ns | 0.0173 ns | 11.308 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.064 ns | 0.0078 ns | 0.0069 ns |  8.063 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.660 ns | 0.0135 ns | 0.0126 ns | 13.660 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.892 ns | 0.0336 ns | 0.0298 ns | 13.884 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.615 ns | 0.0351 ns | 0.0329 ns | 18.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.544 ns | 0.0224 ns | 0.0209 ns | 17.550 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.245 ns | 0.1533 ns | 0.1434 ns | 16.320 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.644 ns | 0.0401 ns | 0.0375 ns | 18.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 19.040 ns | 0.0366 ns | 0.0324 ns | 19.050 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.326 ns | 0.0141 ns | 0.0132 ns | 12.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.423 ns | 0.0337 ns | 0.0315 ns | 11.422 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.158 ns | 0.1854 ns | 0.2277 ns |  8.018 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.591 ns | 0.0142 ns | 0.0133 ns | 12.590 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 15.011 ns | 0.1187 ns | 0.0991 ns | 15.011 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.930 ns | 0.0334 ns | 0.0312 ns | 13.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.208 ns | 0.0161 ns | 0.0151 ns | 14.212 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.797 ns | 0.0777 ns | 0.0726 ns | 12.755 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.028 ns | 0.0326 ns | 0.0305 ns | 13.031 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.118 ns | 0.0434 ns | 0.0384 ns | 14.123 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.217 ns | 0.0133 ns | 0.0118 ns | 12.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.299 ns | 0.0124 ns | 0.0116 ns | 10.300 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.706 ns | 0.0197 ns | 0.0184 ns |  6.702 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.410 ns | 0.0237 ns | 0.0222 ns | 12.410 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 11.232 ns | 0.1287 ns | 0.1203 ns | 11.181 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.388 ns | 0.0307 ns | 0.0287 ns | 18.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.850 ns | 0.0340 ns | 0.0318 ns | 15.846 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.065 ns | 0.0265 ns | 0.0248 ns | 15.061 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 20.014 ns | 0.0232 ns | 0.0217 ns | 20.018 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 19.100 ns | 0.0634 ns | 0.0529 ns | 19.104 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.445 ns | 0.0174 ns | 0.0163 ns | 12.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.476 ns | 0.0124 ns | 0.0116 ns | 10.476 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.077 ns | 0.0070 ns | 0.0066 ns |  7.078 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.883 ns | 0.0217 ns | 0.0203 ns | 11.883 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.247 ns | 0.0325 ns | 0.0304 ns | 12.243 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.381 ns | 0.0192 ns | 0.0179 ns | 20.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.570 ns | 0.0200 ns | 0.0187 ns | 15.576 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.868 ns | 0.0614 ns | 0.0574 ns | 15.865 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.383 ns | 0.0334 ns | 0.0312 ns | 18.381 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.933 ns | 0.0649 ns | 0.0607 ns | 18.922 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.158 ns | 0.2776 ns | 0.2597 ns | 12.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.252 ns | 0.0273 ns | 0.0256 ns | 10.246 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.167 ns | 0.1642 ns | 0.2136 ns |  7.309 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.739 ns | 0.0065 ns | 0.0061 ns | 11.741 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.567 ns | 0.0388 ns | 0.0344 ns | 10.562 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.921 ns | 0.0167 ns | 0.0156 ns | 13.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.547 ns | 0.0117 ns | 0.0109 ns | 12.546 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.797 ns | 0.0154 ns | 0.0144 ns | 12.796 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 12.942 ns | 0.0339 ns | 0.0317 ns | 12.936 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.556 ns | 0.1801 ns | 0.1685 ns | 13.537 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.582 ns | 0.0468 ns | 0.0415 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.388 ns | 0.0146 ns | 0.0137 ns | 11.384 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.182 ns | 0.2036 ns | 0.2854 ns |  9.301 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.953 ns | 0.0188 ns | 0.0166 ns | 13.955 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.777 ns | 0.0312 ns | 0.0277 ns | 14.774 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 22.020 ns | 0.0254 ns | 0.0237 ns | 22.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.166 ns | 0.0510 ns | 0.0477 ns | 18.164 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.272 ns | 0.2881 ns | 0.2695 ns | 17.412 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 22.025 ns | 0.0257 ns | 0.0228 ns | 22.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 22.776 ns | 0.0795 ns | 0.0744 ns | 22.756 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.836 ns | 0.0238 ns | 0.0222 ns | 13.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.431 ns | 0.0139 ns | 0.0130 ns | 11.432 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.505 ns | 0.0042 ns | 0.0035 ns |  8.505 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.587 ns | 0.0563 ns | 0.0526 ns | 13.607 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.643 ns | 0.0820 ns | 0.0767 ns | 13.627 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.363 ns | 0.0685 ns | 0.0640 ns | 21.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.182 ns | 0.0295 ns | 0.0276 ns | 18.195 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.498 ns | 0.1046 ns | 0.0978 ns | 17.470 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 22.040 ns | 0.0197 ns | 0.0174 ns | 22.043 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 22.714 ns | 0.0590 ns | 0.0523 ns | 22.716 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.594 ns | 0.0127 ns | 0.0119 ns | 11.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.255 ns | 0.0257 ns | 0.0228 ns | 10.255 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.856 ns | 0.0084 ns | 0.0078 ns |  6.855 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.295 ns | 0.0104 ns | 0.0097 ns | 10.297 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.517 ns | 0.0332 ns | 0.0277 ns | 10.515 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.617 ns | 0.0120 ns | 0.0107 ns | 14.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.551 ns | 0.0082 ns | 0.0077 ns | 12.554 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.281 ns | 0.0701 ns | 0.0656 ns | 14.314 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.040 ns | 0.0236 ns | 0.0209 ns | 15.038 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.481 ns | 0.1238 ns | 0.1158 ns | 13.501 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 56.697 ns | 0.9144 ns | 0.8553 ns | 56.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.455 ns | 0.0762 ns | 0.0713 ns | 50.471 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.206 ns | 0.0450 ns | 0.0421 ns | 22.206 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 56.808 ns | 0.0507 ns | 0.0449 ns | 56.799 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                           From_String |        net472 | 59.731 ns | 0.2360 ns | 0.2208 ns | 59.644 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 62.089 ns | 0.1089 ns | 0.1018 ns | 62.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 57.660 ns | 0.1543 ns | 0.1444 ns | 57.622 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.742 ns | 0.2298 ns | 0.2150 ns | 26.872 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 62.966 ns | 0.0773 ns | 0.0723 ns | 62.990 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 65.215 ns | 0.2914 ns | 0.2583 ns | 65.235 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.975 ns | 0.0124 ns | 0.0116 ns | 12.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.019 ns | 0.0146 ns | 0.0136 ns | 12.023 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.437 ns | 0.0107 ns | 0.0095 ns | 11.434 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 13.995 ns | 0.0329 ns | 0.0308 ns | 14.001 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 13.030 ns | 0.0688 ns | 0.0644 ns | 13.015 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.894 ns | 0.0261 ns | 0.0232 ns | 13.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.060 ns | 0.0177 ns | 0.0165 ns | 14.061 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.282 ns | 0.3085 ns | 0.5718 ns | 14.517 ns |  0.99 |    0.06 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.794 ns | 0.0145 ns | 0.0136 ns | 13.794 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.548 ns | 0.0656 ns | 0.0581 ns | 13.553 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.415 ns | 0.0109 ns | 0.0102 ns | 12.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.612 ns | 0.0306 ns | 0.0286 ns | 12.615 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.075 ns | 0.0100 ns | 0.0089 ns | 13.073 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 11.231 ns | 0.0198 ns | 0.0185 ns | 11.237 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.080 ns | 0.0777 ns | 0.0727 ns | 13.077 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.020 ns | 0.0295 ns | 0.0276 ns | 12.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.174 ns | 0.0212 ns | 0.0188 ns | 10.175 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.640 ns | 0.0127 ns | 0.0119 ns |  6.638 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.380 ns | 0.0064 ns | 0.0060 ns | 10.381 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.054 ns | 0.0958 ns | 0.0896 ns | 11.063 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.170 ns | 0.0530 ns | 0.0470 ns | 18.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.358 ns | 0.0313 ns | 0.0293 ns | 15.355 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 14.867 ns | 0.0166 ns | 0.0139 ns | 14.864 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.236 ns | 0.0308 ns | 0.0288 ns | 18.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 19.008 ns | 0.0923 ns | 0.0818 ns | 18.990 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.766 ns | 0.0139 ns | 0.0130 ns | 11.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.351 ns | 0.0099 ns | 0.0093 ns | 10.349 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.193 ns | 0.0467 ns | 0.0437 ns |  7.211 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 11.871 ns | 0.0269 ns | 0.0252 ns | 11.870 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.948 ns | 0.0694 ns | 0.0649 ns | 10.935 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.363 ns | 0.0268 ns | 0.0251 ns | 18.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.002 ns | 0.0428 ns | 0.0400 ns | 15.991 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.825 ns | 0.0161 ns | 0.0151 ns | 14.824 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.884 ns | 0.0987 ns | 0.0771 ns | 19.862 ns |  1.08 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 19.022 ns | 0.0978 ns | 0.0817 ns | 18.992 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.513 ns | 0.0266 ns | 0.0248 ns | 11.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.680 ns | 0.0109 ns | 0.0102 ns | 10.680 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.814 ns | 0.0259 ns | 0.0242 ns |  6.819 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.910 ns | 0.2435 ns | 0.5345 ns | 10.704 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.465 ns | 0.0873 ns | 0.0817 ns | 12.450 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.917 ns | 0.0143 ns | 0.0127 ns | 13.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.530 ns | 0.0118 ns | 0.0110 ns | 12.533 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.933 ns | 0.2532 ns | 0.2369 ns | 12.751 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.839 ns | 0.3314 ns | 0.8960 ns | 13.451 ns |  1.04 |    0.06 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.684 ns | 0.3326 ns | 0.3415 ns | 14.505 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.155 ns | 0.1571 ns | 0.1392 ns | 12.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.193 ns | 0.0112 ns | 0.0100 ns | 10.189 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.637 ns | 0.0109 ns | 0.0102 ns |  6.637 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.922 ns | 0.0342 ns | 0.0303 ns | 11.909 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.635 ns | 0.1475 ns | 0.1379 ns | 10.591 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.211 ns | 0.0760 ns | 0.0711 ns | 18.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.555 ns | 0.0228 ns | 0.0213 ns | 15.560 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.798 ns | 0.0507 ns | 0.0474 ns | 15.795 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 20.214 ns | 0.0798 ns | 0.0666 ns | 20.229 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.914 ns | 0.0886 ns | 0.0828 ns | 18.905 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.760 ns | 0.0280 ns | 0.0262 ns | 11.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.345 ns | 0.0207 ns | 0.0194 ns | 10.345 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.929 ns | 0.0102 ns | 0.0095 ns |  6.933 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.187 ns | 0.2479 ns | 0.3393 ns | 11.160 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.286 ns | 0.0485 ns | 0.0430 ns | 12.278 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.173 ns | 0.0319 ns | 0.0299 ns | 18.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.461 ns | 0.0276 ns | 0.0258 ns | 16.464 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.590 ns | 0.0270 ns | 0.0253 ns | 15.586 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.825 ns | 0.1233 ns | 0.1030 ns | 19.805 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.447 ns | 0.0731 ns | 0.0610 ns | 18.461 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.506 ns | 0.0088 ns | 0.0083 ns | 11.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.232 ns | 0.0112 ns | 0.0093 ns | 10.234 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.971 ns | 0.1442 ns | 0.1349 ns |  6.886 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.579 ns | 0.0775 ns | 0.0687 ns | 10.561 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.606 ns | 0.0639 ns | 0.0598 ns | 10.616 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.887 ns | 0.0231 ns | 0.0205 ns | 13.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.619 ns | 0.0301 ns | 0.0267 ns | 13.614 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.118 ns | 0.0067 ns | 0.0059 ns | 11.119 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.766 ns | 0.0640 ns | 0.0567 ns | 13.757 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.368 ns | 0.0737 ns | 0.0689 ns | 15.338 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.560 ns | 0.0140 ns | 0.0131 ns | 11.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.686 ns | 0.0166 ns | 0.0156 ns | 10.686 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.528 ns | 0.0061 ns | 0.0057 ns |  6.528 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.527 ns | 0.0717 ns | 0.0635 ns | 10.534 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.940 ns | 0.1175 ns | 0.1041 ns | 13.951 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 15.365 ns | 0.0222 ns | 0.0208 ns | 15.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 13.081 ns | 0.0090 ns | 0.0079 ns | 13.083 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 14.363 ns | 0.0736 ns | 0.0689 ns | 14.377 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 14.805 ns | 0.1026 ns | 0.0909 ns | 14.764 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 15.017 ns | 0.1292 ns | 0.1209 ns | 15.042 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.226 ns | 0.0131 ns | 0.0116 ns | 13.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.236 ns | 0.0308 ns | 0.0288 ns | 11.241 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  9.134 ns | 0.0187 ns | 0.0175 ns |  9.129 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.782 ns | 0.0772 ns | 0.0722 ns | 13.775 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.084 ns | 0.0192 ns | 0.0160 ns | 13.080 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.981 ns | 0.0107 ns | 0.0100 ns | 14.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.087 ns | 0.0243 ns | 0.0227 ns | 13.098 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.206 ns | 0.0793 ns | 0.0741 ns | 13.178 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 15.831 ns | 0.0963 ns | 0.0854 ns | 15.823 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 14.518 ns | 0.0566 ns | 0.0529 ns | 14.532 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.432 ns | 0.0094 ns | 0.0084 ns | 12.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.148 ns | 0.0066 ns | 0.0062 ns | 11.148 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.005 ns | 0.0148 ns | 0.0138 ns |  8.004 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.793 ns | 0.0540 ns | 0.0505 ns | 12.794 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.887 ns | 0.0178 ns | 0.0149 ns | 12.883 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.807 ns | 0.0373 ns | 0.0349 ns | 14.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.547 ns | 0.0073 ns | 0.0068 ns | 12.548 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.797 ns | 0.1184 ns | 0.1108 ns | 12.857 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.448 ns | 0.0775 ns | 0.0725 ns | 13.453 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.329 ns | 0.0516 ns | 0.0482 ns | 13.323 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.783 ns | 0.0147 ns | 0.0138 ns | 14.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.556 ns | 0.0292 ns | 0.0273 ns | 12.559 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.364 ns | 0.0985 ns | 0.0873 ns | 11.343 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.217 ns | 0.0799 ns | 0.0748 ns | 13.193 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.593 ns | 0.0761 ns | 0.0712 ns | 13.577 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.782 ns | 0.0105 ns | 0.0093 ns | 10.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  8.919 ns | 0.0110 ns | 0.0103 ns |  8.921 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.508 ns | 0.0160 ns | 0.0149 ns | 11.511 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.169 ns | 0.0497 ns | 0.0440 ns | 11.163 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.233 ns | 0.1329 ns | 0.1243 ns | 11.250 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.602 ns | 0.0337 ns | 0.0315 ns | 14.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.539 ns | 0.0124 ns | 0.0116 ns | 12.542 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.080 ns | 0.2636 ns | 0.3863 ns | 12.228 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.319 ns | 0.0812 ns | 0.0759 ns | 13.319 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.610 ns | 0.0776 ns | 0.0726 ns | 13.599 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.125 ns | 0.0159 ns | 0.0148 ns | 16.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.462 ns | 0.0157 ns | 0.0147 ns | 12.464 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.705 ns | 0.0106 ns | 0.0099 ns | 12.702 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.097 ns | 0.0889 ns | 0.0788 ns | 17.065 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.911 ns | 0.1124 ns | 0.0996 ns | 18.899 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.588 ns | 0.0212 ns | 0.0198 ns | 17.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.718 ns | 0.0246 ns | 0.0230 ns | 15.714 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.288 ns | 0.3496 ns | 0.4421 ns | 16.596 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 17.301 ns | 0.0622 ns | 0.0552 ns | 17.293 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.450 ns | 0.0580 ns | 0.0514 ns | 17.449 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.683 ns | 0.0270 ns | 0.0253 ns | 13.677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.620 ns | 0.0146 ns | 0.0137 ns | 13.623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.532 ns | 0.0199 ns | 0.0176 ns | 11.527 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 15.117 ns | 0.0931 ns | 0.0825 ns | 15.118 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.340 ns | 0.0754 ns | 0.0706 ns | 14.332 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.910 ns | 0.0135 ns | 0.0127 ns | 13.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.552 ns | 0.0179 ns | 0.0168 ns | 12.555 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.638 ns | 0.0185 ns | 0.0173 ns | 13.637 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.324 ns | 0.0592 ns | 0.0554 ns | 13.317 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.548 ns | 0.0612 ns | 0.0511 ns | 13.548 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.757 ns | 0.0242 ns | 0.0226 ns | 11.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.245 ns | 0.0122 ns | 0.0108 ns | 10.247 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.130 ns | 0.0119 ns | 0.0111 ns | 11.132 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.317 ns | 0.1329 ns | 0.1243 ns | 14.277 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.717 ns | 0.1071 ns | 0.1002 ns | 12.745 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.056 ns | 0.0154 ns | 0.0144 ns | 15.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.908 ns | 0.0092 ns | 0.0086 ns | 13.908 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.160 ns | 0.0453 ns | 0.0424 ns | 14.169 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.520 ns | 0.1404 ns | 0.1245 ns | 15.526 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.386 ns | 0.0717 ns | 0.0670 ns | 15.390 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.646 ns | 0.0103 ns | 0.0086 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.261 ns | 0.0162 ns | 0.0144 ns | 10.264 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.081 ns | 0.2466 ns | 0.3376 ns | 11.333 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.484 ns | 0.0773 ns | 0.0723 ns | 12.457 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.103 ns | 0.0782 ns | 0.0732 ns | 14.113 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.926 ns | 0.0097 ns | 0.0091 ns | 13.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.547 ns | 0.0130 ns | 0.0122 ns | 12.549 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.694 ns | 0.2524 ns | 0.2592 ns | 11.683 ns |  0.84 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.280 ns | 0.0629 ns | 0.0588 ns | 13.298 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.406 ns | 0.0964 ns | 0.0855 ns | 13.368 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.510 ns | 0.0403 ns | 0.0377 ns | 18.508 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.065 ns | 0.0321 ns | 0.0300 ns | 16.063 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.185 ns | 0.0632 ns | 0.0591 ns | 11.189 ns |  0.60 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.520 ns | 0.0429 ns | 0.0380 ns | 18.513 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.916 ns | 0.0923 ns | 0.0863 ns | 17.912 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.490 ns | 0.0426 ns | 0.0398 ns | 17.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.996 ns | 0.0479 ns | 0.0448 ns | 15.998 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.161 ns | 0.0203 ns | 0.0170 ns | 15.165 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.695 ns | 0.0339 ns | 0.0301 ns | 17.698 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.563 ns | 0.1598 ns | 0.1495 ns | 18.557 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.737 ns | 0.0805 ns | 0.0753 ns | 18.755 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.190 ns | 0.0159 ns | 0.0149 ns | 16.190 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 11.891 ns | 0.0749 ns | 0.0701 ns | 11.906 ns |  0.63 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.989 ns | 0.1365 ns | 0.1210 ns | 18.030 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.167 ns | 0.1810 ns | 0.1693 ns | 18.136 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.297 ns | 0.0328 ns | 0.0307 ns | 17.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.102 ns | 0.0160 ns | 0.0149 ns | 15.104 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.178 ns | 0.0381 ns | 0.0356 ns | 15.182 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.978 ns | 0.1486 ns | 0.1318 ns | 17.988 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.348 ns | 0.1121 ns | 0.1049 ns | 18.326 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.237 ns | 0.0074 ns | 0.0065 ns | 13.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.797 ns | 0.0337 ns | 0.0282 ns | 11.800 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.011 ns | 0.0107 ns | 0.0100 ns |  7.013 ns |  0.53 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.827 ns | 0.0705 ns | 0.0659 ns | 10.850 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.848 ns | 0.1191 ns | 0.1114 ns | 10.868 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.945 ns | 0.0162 ns | 0.0151 ns | 13.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.543 ns | 0.0103 ns | 0.0096 ns | 12.545 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.452 ns | 0.0121 ns | 0.0107 ns | 13.453 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.129 ns | 0.0232 ns | 0.0194 ns | 13.125 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.501 ns | 0.0870 ns | 0.0772 ns | 14.504 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.917 ns | 0.0156 ns | 0.0146 ns | 12.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.661 ns | 0.0357 ns | 0.0334 ns | 10.659 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.526 ns | 0.0217 ns | 0.0203 ns |  6.531 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.578 ns | 0.0614 ns | 0.0574 ns | 10.550 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.843 ns | 0.0201 ns | 0.0178 ns | 11.840 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.796 ns | 0.0064 ns | 0.0060 ns | 14.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.826 ns | 0.0132 ns | 0.0124 ns | 14.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.915 ns | 0.0220 ns | 0.0172 ns | 14.916 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.715 ns | 0.0586 ns | 0.0548 ns | 16.710 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 15.307 ns | 0.0514 ns | 0.0481 ns | 15.313 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 12.932 ns | 0.0314 ns | 0.0294 ns | 12.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.914 ns | 0.0099 ns | 0.0092 ns | 10.916 ns |  0.84 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.661 ns | 0.0121 ns | 0.0113 ns |  6.662 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.639 ns | 0.0838 ns | 0.0742 ns | 10.635 ns |  0.82 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.777 ns | 0.0883 ns | 0.0826 ns | 11.752 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.109 ns | 0.0272 ns | 0.0254 ns | 15.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.767 ns | 0.0106 ns | 0.0099 ns | 14.765 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.838 ns | 0.0272 ns | 0.0254 ns | 14.846 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.086 ns | 0.0562 ns | 0.0470 ns | 15.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.412 ns | 0.1441 ns | 0.1348 ns | 15.362 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 11.537 ns | 0.0144 ns | 0.0134 ns | 11.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.886 ns | 0.0186 ns | 0.0165 ns | 10.890 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.522 ns | 0.0104 ns | 0.0097 ns |  6.524 ns |  0.57 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.619 ns | 0.0596 ns | 0.0557 ns | 10.624 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.859 ns | 0.0889 ns | 0.0832 ns | 11.861 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.783 ns | 0.0353 ns | 0.0330 ns | 14.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.366 ns | 0.0120 ns | 0.0107 ns | 13.367 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.996 ns | 0.2587 ns | 0.2540 ns | 11.825 ns |  0.81 |    0.02 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.493 ns | 0.1049 ns | 0.0981 ns | 13.474 ns |  0.91 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.550 ns | 0.0830 ns | 0.0776 ns | 13.528 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.643 ns | 0.0135 ns | 0.0127 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.294 ns | 0.0116 ns | 0.0108 ns | 10.295 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.723 ns | 0.0137 ns | 0.0128 ns |  6.726 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.833 ns | 0.0514 ns | 0.0481 ns | 10.822 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.912 ns | 0.0652 ns | 0.0578 ns | 10.910 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.101 ns | 0.0548 ns | 0.0428 ns | 49.101 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 39.674 ns | 0.0654 ns | 0.0612 ns | 39.655 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 34.823 ns | 0.3547 ns | 0.3318 ns | 34.825 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.445 ns | 0.3520 ns | 0.3120 ns | 43.392 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 44.101 ns | 0.1037 ns | 0.0866 ns | 44.082 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.294 ns | 0.0451 ns | 0.0422 ns | 13.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.952 ns | 0.0146 ns | 0.0137 ns | 10.955 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.816 ns | 0.0364 ns | 0.0340 ns |  6.819 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.217 ns | 0.0834 ns | 0.0781 ns | 12.192 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.170 ns | 0.0433 ns | 0.0384 ns | 12.184 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 43.701 ns | 0.1193 ns | 0.1116 ns | 43.676 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.940 ns | 0.0874 ns | 0.0818 ns | 40.928 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 34.334 ns | 0.2407 ns | 0.2252 ns | 34.371 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.496 ns | 0.1330 ns | 0.1111 ns | 43.514 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 43.713 ns | 0.3384 ns | 0.2642 ns | 43.663 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 11.642 ns | 0.0097 ns | 0.0091 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.798 ns | 0.0144 ns | 0.0128 ns | 10.802 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.803 ns | 0.0306 ns | 0.0286 ns |  6.794 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.577 ns | 0.0883 ns | 0.0783 ns | 10.565 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 11.942 ns | 0.0680 ns | 0.0602 ns | 11.936 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.211 ns | 0.0362 ns | 0.0339 ns | 14.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.551 ns | 0.0127 ns | 0.0119 ns | 12.551 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.631 ns | 0.0398 ns | 0.0372 ns | 13.642 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.966 ns | 0.1324 ns | 0.1238 ns | 14.919 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.467 ns | 0.0206 ns | 0.0183 ns | 13.465 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.069 ns | 0.0175 ns | 0.0163 ns | 12.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.256 ns | 0.0245 ns | 0.0229 ns | 10.261 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.672 ns | 0.0161 ns | 0.0143 ns | 10.670 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.620 ns | 0.0475 ns | 0.0444 ns | 12.613 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.916 ns | 0.0748 ns | 0.0663 ns | 12.895 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.359 ns | 0.0113 ns | 0.0100 ns | 17.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.255 ns | 0.0135 ns | 0.0127 ns | 14.259 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.395 ns | 0.0946 ns | 0.0885 ns | 14.357 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.589 ns | 0.1006 ns | 0.0941 ns | 15.607 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.469 ns | 0.0422 ns | 0.0374 ns | 15.477 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.788 ns | 0.0592 ns | 0.0494 ns | 11.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.250 ns | 0.0180 ns | 0.0160 ns | 10.258 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.218 ns | 0.0251 ns | 0.0235 ns | 11.225 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.518 ns | 0.0440 ns | 0.0412 ns | 12.519 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.670 ns | 0.0570 ns | 0.0534 ns | 12.679 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.919 ns | 0.0083 ns | 0.0078 ns | 13.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.336 ns | 0.0363 ns | 0.0340 ns | 13.331 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.040 ns | 0.2485 ns | 0.2324 ns | 13.229 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.511 ns | 0.1162 ns | 0.1087 ns | 13.587 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.503 ns | 0.1244 ns | 0.1163 ns | 13.482 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 37.306 ns | 0.0494 ns | 0.0462 ns | 37.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.926 ns | 0.0463 ns | 0.0433 ns | 38.930 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.619 ns | 0.1048 ns | 0.0980 ns | 37.653 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.077 ns | 0.0973 ns | 0.0910 ns | 39.038 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 39.306 ns | 0.1339 ns | 0.1187 ns | 39.300 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.068 ns | 0.0124 ns | 0.0116 ns | 16.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.974 ns | 0.0186 ns | 0.0174 ns | 14.976 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.495 ns | 0.0804 ns | 0.0752 ns | 16.522 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.301 ns | 0.0368 ns | 0.0326 ns | 15.307 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.532 ns | 0.1270 ns | 0.1126 ns | 15.492 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 38.907 ns | 0.1134 ns | 0.1061 ns | 38.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.537 ns | 0.1235 ns | 0.1156 ns | 36.511 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 33.580 ns | 0.0673 ns | 0.0630 ns | 33.602 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.210 ns | 0.2058 ns | 0.1925 ns | 41.206 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.203 ns | 0.6017 ns | 0.5025 ns | 38.994 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.286 ns | 0.0210 ns | 0.0196 ns | 15.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.056 ns | 0.0302 ns | 0.0283 ns | 15.062 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.404 ns | 0.3154 ns | 0.6583 ns | 13.040 ns |  0.94 |    0.04 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.848 ns | 0.0303 ns | 0.0269 ns | 16.853 ns |  1.10 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.611 ns | 0.1077 ns | 0.1007 ns | 15.613 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 37.910 ns | 0.0344 ns | 0.0305 ns | 37.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 36.822 ns | 0.0569 ns | 0.0532 ns | 36.814 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.340 ns | 1.2489 ns | 1.4867 ns | 33.542 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.262 ns | 0.1664 ns | 0.1557 ns | 39.287 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.150 ns | 0.2692 ns | 0.2519 ns | 39.099 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.923 ns | 0.0128 ns | 0.0120 ns | 13.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.332 ns | 0.0286 ns | 0.0254 ns | 13.330 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.565 ns | 0.0103 ns | 0.0097 ns | 11.567 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.348 ns | 0.0846 ns | 0.0791 ns | 13.331 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.457 ns | 0.0722 ns | 0.0675 ns | 13.459 ns |  0.97 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ULong.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULong.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
