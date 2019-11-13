
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
                                             From_Bool | .NET Core 2.0 | 14.486 ns | 0.0746 ns | 0.0698 ns | 14.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.395 ns | 0.1361 ns | 0.1273 ns | 12.352 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.795 ns | 0.0148 ns | 0.0138 ns |  7.792 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.908 ns | 0.0347 ns | 0.0308 ns | 12.902 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.622 ns | 0.0191 ns | 0.0159 ns | 13.624 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 24.493 ns | 0.1071 ns | 0.1002 ns | 24.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 20.810 ns | 0.1027 ns | 0.0960 ns | 20.784 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.874 ns | 0.0397 ns | 0.0371 ns | 18.878 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 22.548 ns | 0.0375 ns | 0.0351 ns | 22.563 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.876 ns | 0.0412 ns | 0.0365 ns | 20.888 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.453 ns | 0.1397 ns | 0.1167 ns | 13.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.459 ns | 0.2047 ns | 0.1914 ns | 11.346 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.008 ns | 0.0481 ns | 0.0450 ns |  8.001 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.539 ns | 0.0087 ns | 0.0077 ns | 13.540 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 14.238 ns | 0.0451 ns | 0.0377 ns | 14.233 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.656 ns | 0.1255 ns | 0.1113 ns | 20.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.047 ns | 0.3530 ns | 0.3625 ns | 19.080 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.520 ns | 0.0452 ns | 0.0378 ns | 18.515 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.067 ns | 0.0323 ns | 0.0286 ns | 21.066 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.962 ns | 0.0420 ns | 0.0351 ns | 20.957 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 15.386 ns | 0.3318 ns | 0.3407 ns | 15.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.583 ns | 0.2396 ns | 0.2241 ns | 11.579 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.269 ns | 0.0231 ns | 0.0205 ns |  7.269 ns |  0.47 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.955 ns | 0.0265 ns | 0.0235 ns | 12.951 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.983 ns | 0.0266 ns | 0.0249 ns | 12.983 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.485 ns | 0.0687 ns | 0.0643 ns | 15.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.826 ns | 0.2281 ns | 0.2134 ns | 14.892 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.360 ns | 0.0651 ns | 0.0544 ns | 14.343 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.995 ns | 0.0159 ns | 0.0141 ns | 14.995 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 14.833 ns | 0.0228 ns | 0.0213 ns | 14.833 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.807 ns | 0.0289 ns | 0.0270 ns | 12.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.828 ns | 0.0454 ns | 0.0424 ns | 10.821 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.683 ns | 0.4119 ns | 0.4230 ns |  7.479 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.565 ns | 0.0297 ns | 0.0277 ns | 13.572 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.860 ns | 0.0190 ns | 0.0168 ns | 12.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.966 ns | 0.1751 ns | 0.1638 ns | 20.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.951 ns | 0.0994 ns | 0.0930 ns | 17.964 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 20.862 ns | 0.0970 ns | 0.0907 ns | 20.851 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 21.899 ns | 0.0270 ns | 0.0239 ns | 21.899 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 21.257 ns | 0.0435 ns | 0.0407 ns | 21.254 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.183 ns | 0.0973 ns | 0.0910 ns | 13.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.930 ns | 0.0877 ns | 0.0820 ns | 10.912 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.340 ns | 0.0186 ns | 0.0165 ns |  7.339 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 15.874 ns | 0.0172 ns | 0.0153 ns | 15.876 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.084 ns | 0.0727 ns | 0.0607 ns | 14.082 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.827 ns | 0.0678 ns | 0.0566 ns | 20.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.085 ns | 0.1286 ns | 0.1074 ns | 18.053 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.332 ns | 0.0771 ns | 0.0721 ns | 18.324 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 22.989 ns | 0.1594 ns | 0.1413 ns | 22.937 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.100 ns | 0.0385 ns | 0.0360 ns | 21.114 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.582 ns | 0.0924 ns | 0.0864 ns | 14.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 12.308 ns | 0.1094 ns | 0.0969 ns | 12.286 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.546 ns | 0.0211 ns | 0.0198 ns |  7.540 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.034 ns | 0.0162 ns | 0.0126 ns | 13.034 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.987 ns | 0.0236 ns | 0.0221 ns | 12.988 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 18.104 ns | 0.1132 ns | 0.1059 ns | 18.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.875 ns | 0.0264 ns | 0.0234 ns | 14.865 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.230 ns | 0.0139 ns | 0.0116 ns | 14.232 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.821 ns | 0.0187 ns | 0.0175 ns | 14.813 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 14.743 ns | 0.0264 ns | 0.0234 ns | 14.752 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.915 ns | 0.0816 ns | 0.0763 ns | 12.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.770 ns | 0.0591 ns | 0.0553 ns | 10.754 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.347 ns | 0.0163 ns | 0.0144 ns |  7.349 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.951 ns | 0.1197 ns | 0.1120 ns | 13.013 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.850 ns | 0.0261 ns | 0.0218 ns | 12.850 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 21.229 ns | 0.1874 ns | 0.1753 ns | 21.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.613 ns | 0.0692 ns | 0.0578 ns | 18.608 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 20.711 ns | 0.0385 ns | 0.0342 ns | 20.707 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 22.626 ns | 0.0535 ns | 0.0475 ns | 22.635 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 21.044 ns | 0.0964 ns | 0.0805 ns | 21.069 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.132 ns | 0.1811 ns | 0.1512 ns | 13.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.025 ns | 0.0851 ns | 0.0796 ns | 10.994 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  8.224 ns | 0.1095 ns | 0.1024 ns |  8.272 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.604 ns | 0.0222 ns | 0.0197 ns | 13.602 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 16.387 ns | 0.0417 ns | 0.0370 ns | 16.375 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.423 ns | 0.1571 ns | 0.1469 ns | 21.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.861 ns | 0.0889 ns | 0.0788 ns | 18.836 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.428 ns | 0.0351 ns | 0.0293 ns | 17.434 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 21.281 ns | 0.1231 ns | 0.1151 ns | 21.332 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 20.804 ns | 0.0287 ns | 0.0255 ns | 20.802 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.928 ns | 0.1687 ns | 0.1409 ns | 12.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.947 ns | 0.0553 ns | 0.0518 ns | 10.957 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.548 ns | 0.0173 ns | 0.0162 ns |  7.546 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.811 ns | 0.0440 ns | 0.0390 ns | 13.790 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.784 ns | 0.0714 ns | 0.0668 ns | 13.787 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.504 ns | 0.0475 ns | 0.0397 ns | 15.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 19.268 ns | 0.0874 ns | 0.0818 ns | 19.254 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.423 ns | 0.1270 ns | 0.1188 ns | 15.491 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 16.513 ns | 0.0294 ns | 0.0275 ns | 16.505 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.923 ns | 0.2214 ns | 0.2071 ns | 15.889 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 13.605 ns | 0.1278 ns | 0.1196 ns | 13.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 13.449 ns | 0.0419 ns | 0.0350 ns | 13.437 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.850 ns | 0.2020 ns | 0.3430 ns |  8.976 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.165 ns | 0.1165 ns | 0.1090 ns | 13.237 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 14.160 ns | 0.1637 ns | 0.1532 ns | 14.112 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.104 ns | 0.0902 ns | 0.0844 ns | 13.096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 12.471 ns | 0.0925 ns | 0.0772 ns | 12.465 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.412 ns | 0.1026 ns | 0.0960 ns |  8.467 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.846 ns | 0.0250 ns | 0.0234 ns | 15.835 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.149 ns | 0.1578 ns | 0.1398 ns | 14.186 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.828 ns | 0.1733 ns | 0.1621 ns | 13.811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 13.413 ns | 0.2544 ns | 0.2827 ns | 13.361 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.599 ns | 0.0319 ns | 0.0249 ns |  8.592 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.146 ns | 0.0123 ns | 0.0115 ns | 13.146 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.884 ns | 0.0414 ns | 0.0367 ns | 13.881 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.486 ns | 0.1117 ns | 0.1044 ns | 15.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.023 ns | 0.2778 ns | 0.2853 ns | 14.086 ns |  0.90 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.789 ns | 0.0188 ns | 0.0157 ns | 13.785 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 14.799 ns | 0.0972 ns | 0.0909 ns | 14.832 ns |  0.96 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.734 ns | 0.0299 ns | 0.0280 ns | 14.736 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.162 ns | 0.2694 ns | 0.2520 ns | 24.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.667 ns | 0.1993 ns | 0.1864 ns | 21.651 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.843 ns | 0.1836 ns | 0.1717 ns | 13.775 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 22.606 ns | 0.0739 ns | 0.0691 ns | 22.581 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.573 ns | 0.0560 ns | 0.0496 ns | 22.558 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 29.962 ns | 0.4837 ns | 0.4288 ns | 29.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 28.743 ns | 0.1707 ns | 0.1597 ns | 28.734 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.757 ns | 0.3683 ns | 0.3075 ns | 21.879 ns |  0.73 |    0.02 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 30.617 ns | 0.0703 ns | 0.0657 ns | 30.597 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 29.324 ns | 0.0788 ns | 0.0658 ns | 29.310 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.570 ns | 0.0461 ns | 0.0409 ns | 23.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.202 ns | 0.1136 ns | 0.1063 ns | 21.229 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.705 ns | 0.2025 ns | 0.1894 ns | 15.601 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.281 ns | 0.2425 ns | 0.2269 ns | 23.154 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.403 ns | 0.0777 ns | 0.0689 ns | 23.402 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.573 ns | 0.0592 ns | 0.0525 ns | 30.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.179 ns | 0.2280 ns | 0.2133 ns | 28.263 ns |  0.92 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.969 ns | 0.2142 ns | 0.2003 ns | 25.065 ns |  0.82 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 29.755 ns | 0.0332 ns | 0.0295 ns | 29.757 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 29.905 ns | 0.1383 ns | 0.1293 ns | 29.938 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.421 ns | 0.0983 ns | 0.0919 ns | 14.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.109 ns | 0.2109 ns | 0.1973 ns | 12.174 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.485 ns | 0.0256 ns | 0.0227 ns |  8.483 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.407 ns | 0.1225 ns | 0.1146 ns | 14.450 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.155 ns | 0.0372 ns | 0.0348 ns | 15.158 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.179 ns | 0.2586 ns | 0.2292 ns | 16.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.738 ns | 0.1222 ns | 0.1143 ns | 14.743 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.996 ns | 0.0147 ns | 0.0130 ns | 12.000 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 16.279 ns | 0.0286 ns | 0.0239 ns | 16.274 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 14.886 ns | 0.0725 ns | 0.0679 ns | 14.850 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 16.108 ns | 0.2387 ns | 0.2233 ns | 16.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.093 ns | 0.0562 ns | 0.0498 ns | 12.108 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.039 ns | 0.0958 ns | 0.0896 ns |  9.097 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.880 ns | 0.0435 ns | 0.0340 ns | 16.871 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net472 | 16.803 ns | 0.0329 ns | 0.0292 ns | 16.804 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 24.150 ns | 0.1406 ns | 0.1315 ns | 24.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.834 ns | 0.1537 ns | 0.1363 ns | 20.787 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.351 ns | 0.2637 ns | 0.2466 ns | 18.472 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 25.174 ns | 0.1889 ns | 0.1767 ns | 25.289 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 24.276 ns | 0.0685 ns | 0.0641 ns | 24.229 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.299 ns | 0.1676 ns | 0.1567 ns | 16.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.922 ns | 0.0614 ns | 0.0544 ns | 14.916 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.457 ns | 0.0361 ns | 0.0338 ns | 10.443 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.991 ns | 0.0209 ns | 0.0185 ns | 16.992 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.235 ns | 0.0561 ns | 0.0468 ns | 16.220 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.086 ns | 0.0686 ns | 0.0535 ns | 24.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 22.182 ns | 0.3926 ns | 0.3673 ns | 22.199 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.317 ns | 0.1335 ns | 0.1248 ns | 21.351 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 25.188 ns | 0.0208 ns | 0.0174 ns | 25.192 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 24.198 ns | 0.0316 ns | 0.0296 ns | 24.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.977 ns | 0.0685 ns | 0.0641 ns | 12.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.005 ns | 0.3944 ns | 0.4384 ns | 11.769 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.594 ns | 0.0236 ns | 0.0209 ns |  8.589 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.918 ns | 0.0203 ns | 0.0190 ns | 13.925 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.420 ns | 0.0243 ns | 0.0215 ns | 13.426 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.194 ns | 0.1041 ns | 0.0974 ns | 17.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.104 ns | 0.2712 ns | 0.3713 ns | 13.935 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.764 ns | 0.3187 ns | 0.4031 ns | 14.455 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.694 ns | 0.0134 ns | 0.0126 ns | 14.691 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.728 ns | 0.0231 ns | 0.0193 ns | 14.725 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.326 ns | 0.1059 ns | 0.0990 ns | 13.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.936 ns | 0.0325 ns | 0.0304 ns | 10.936 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.466 ns | 0.0797 ns | 0.0746 ns |  7.493 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.054 ns | 0.0219 ns | 0.0183 ns | 14.059 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.822 ns | 0.0435 ns | 0.0407 ns | 13.816 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.277 ns | 0.1730 ns | 0.1534 ns | 21.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.375 ns | 0.3398 ns | 0.3012 ns | 18.253 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.323 ns | 0.0506 ns | 0.0448 ns | 17.332 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 23.793 ns | 0.0287 ns | 0.0269 ns | 23.799 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 22.095 ns | 0.0393 ns | 0.0367 ns | 22.099 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.382 ns | 0.0977 ns | 0.0914 ns | 13.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.697 ns | 0.2012 ns | 0.1882 ns | 11.613 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.946 ns | 0.0269 ns | 0.0238 ns |  7.943 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.559 ns | 0.0266 ns | 0.0208 ns | 14.554 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 14.439 ns | 0.0318 ns | 0.0248 ns | 14.432 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.278 ns | 0.1598 ns | 0.1495 ns | 21.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.003 ns | 0.3784 ns | 0.3885 ns | 18.873 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.186 ns | 0.0646 ns | 0.0604 ns | 21.162 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 23.827 ns | 0.0173 ns | 0.0154 ns | 23.829 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 22.059 ns | 0.0283 ns | 0.0264 ns | 22.060 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 13.203 ns | 0.1198 ns | 0.1121 ns | 13.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.872 ns | 0.0999 ns | 0.0886 ns | 10.848 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.553 ns | 0.0202 ns | 0.0169 ns |  7.550 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.290 ns | 0.0619 ns | 0.0549 ns | 13.303 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.594 ns | 0.0239 ns | 0.0212 ns | 13.594 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.484 ns | 0.1016 ns | 0.0950 ns | 15.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.691 ns | 0.0365 ns | 0.0323 ns | 13.692 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.872 ns | 0.1361 ns | 0.1273 ns | 14.808 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 16.326 ns | 0.0163 ns | 0.0145 ns | 16.325 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.659 ns | 0.0219 ns | 0.0194 ns | 14.657 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 14.783 ns | 0.0934 ns | 0.0874 ns | 14.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.070 ns | 0.0628 ns | 0.0557 ns | 11.052 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.678 ns | 0.0745 ns | 0.0661 ns |  7.702 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.100 ns | 0.0198 ns | 0.0185 ns | 14.106 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.906 ns | 0.0289 ns | 0.0270 ns | 13.905 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.073 ns | 0.0405 ns | 0.0338 ns | 21.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.342 ns | 0.2035 ns | 0.1804 ns | 18.329 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 21.276 ns | 0.0394 ns | 0.0329 ns | 21.278 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 23.965 ns | 0.1171 ns | 0.1095 ns | 23.985 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.822 ns | 0.0459 ns | 0.0383 ns | 21.817 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.420 ns | 0.0743 ns | 0.0621 ns | 13.419 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.257 ns | 0.0924 ns | 0.0771 ns | 11.285 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.927 ns | 0.0632 ns | 0.0591 ns |  7.958 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 16.022 ns | 0.0222 ns | 0.0208 ns | 16.022 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.388 ns | 0.0293 ns | 0.0229 ns | 14.394 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.489 ns | 0.1438 ns | 0.1345 ns | 22.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.691 ns | 0.0586 ns | 0.0490 ns | 18.672 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.017 ns | 0.0261 ns | 0.0244 ns | 17.014 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 22.397 ns | 0.0442 ns | 0.0392 ns | 22.391 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.843 ns | 0.0522 ns | 0.0488 ns | 21.851 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.461 ns | 0.0489 ns | 0.0408 ns | 14.470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.859 ns | 0.0562 ns | 0.0526 ns | 10.859 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.533 ns | 0.0316 ns | 0.0296 ns |  7.537 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 15.712 ns | 0.0799 ns | 0.0747 ns | 15.727 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.975 ns | 0.0351 ns | 0.0329 ns | 12.978 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.264 ns | 0.0718 ns | 0.0636 ns | 17.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.734 ns | 0.1955 ns | 0.1733 ns | 14.676 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.440 ns | 0.3507 ns | 0.6672 ns | 16.605 ns |  0.91 |    0.05 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 16.803 ns | 0.0399 ns | 0.0373 ns | 16.791 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 14.850 ns | 0.0425 ns | 0.0355 ns | 14.848 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 14.784 ns | 0.1315 ns | 0.1230 ns | 14.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.217 ns | 0.1098 ns | 0.0973 ns | 12.223 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.554 ns | 0.0142 ns | 0.0133 ns |  7.551 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.777 ns | 0.0183 ns | 0.0162 ns | 14.776 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 14.231 ns | 0.0409 ns | 0.0383 ns | 14.229 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 21.607 ns | 0.3080 ns | 0.2572 ns | 21.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.835 ns | 0.2699 ns | 0.2525 ns | 18.735 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 21.086 ns | 0.0300 ns | 0.0281 ns | 21.074 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 22.244 ns | 0.0302 ns | 0.0283 ns | 22.238 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.618 ns | 0.0325 ns | 0.0304 ns | 21.622 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.210 ns | 0.1184 ns | 0.1107 ns | 13.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.107 ns | 0.1119 ns | 0.0934 ns | 12.057 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  9.082 ns | 0.0836 ns | 0.0782 ns |  9.064 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.605 ns | 0.0228 ns | 0.0213 ns | 15.605 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.556 ns | 0.2414 ns | 0.2258 ns | 14.446 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.967 ns | 0.1194 ns | 0.1059 ns | 20.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.043 ns | 0.0898 ns | 0.0796 ns | 18.037 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.603 ns | 0.1216 ns | 0.1138 ns | 20.547 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 22.113 ns | 0.0291 ns | 0.0258 ns | 22.103 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.912 ns | 0.1487 ns | 0.1391 ns | 21.861 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.063 ns | 0.1399 ns | 0.1308 ns | 13.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.774 ns | 0.0606 ns | 0.0537 ns | 11.782 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.007 ns | 0.1929 ns | 0.1981 ns |  9.094 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.172 ns | 0.0225 ns | 0.0176 ns | 13.175 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.085 ns | 0.0245 ns | 0.0229 ns | 13.084 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.483 ns | 0.0832 ns | 0.0738 ns | 15.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.258 ns | 0.0401 ns | 0.0376 ns | 15.262 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.588 ns | 0.1063 ns | 0.0995 ns | 14.647 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.875 ns | 0.0865 ns | 0.0809 ns | 14.842 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.503 ns | 0.0561 ns | 0.0497 ns | 15.516 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 14.480 ns | 0.1024 ns | 0.0958 ns | 14.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.149 ns | 0.1019 ns | 0.0953 ns | 11.147 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.828 ns | 0.1790 ns | 0.2264 ns |  7.997 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.844 ns | 0.0195 ns | 0.0173 ns | 13.845 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 14.510 ns | 0.0190 ns | 0.0178 ns | 14.506 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 22.752 ns | 0.1244 ns | 0.1164 ns | 22.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.713 ns | 0.1187 ns | 0.1052 ns | 18.709 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 19.918 ns | 0.0207 ns | 0.0194 ns | 19.918 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 23.565 ns | 0.0195 ns | 0.0182 ns | 23.564 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.839 ns | 0.0277 ns | 0.0245 ns | 21.837 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 14.880 ns | 0.0921 ns | 0.0861 ns | 14.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.582 ns | 0.2504 ns | 0.2572 ns | 11.634 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.636 ns | 0.0171 ns | 0.0152 ns |  7.638 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 15.470 ns | 0.0952 ns | 0.0890 ns | 15.491 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.613 ns | 0.1176 ns | 0.1043 ns | 14.662 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.788 ns | 0.1433 ns | 0.1340 ns | 22.758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.219 ns | 0.1030 ns | 0.0964 ns | 18.249 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.240 ns | 0.2122 ns | 0.1985 ns | 17.106 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.914 ns | 0.0186 ns | 0.0164 ns | 21.914 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.518 ns | 0.0296 ns | 0.0277 ns | 21.522 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.738 ns | 0.0931 ns | 0.0826 ns | 14.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.892 ns | 0.0902 ns | 0.0800 ns | 10.915 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.342 ns | 0.0636 ns | 0.0595 ns |  7.321 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.935 ns | 0.0174 ns | 0.0136 ns | 12.938 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 14.129 ns | 0.0238 ns | 0.0223 ns | 14.126 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.549 ns | 0.1221 ns | 0.1082 ns | 15.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.883 ns | 0.1986 ns | 0.1760 ns | 13.791 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.164 ns | 0.2674 ns | 0.2501 ns | 15.056 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 15.810 ns | 0.0513 ns | 0.0455 ns | 15.823 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 16.328 ns | 0.0885 ns | 0.0828 ns | 16.355 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 16.158 ns | 0.1133 ns | 0.1060 ns | 16.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 15.543 ns | 0.2039 ns | 0.1908 ns | 15.462 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.927 ns | 0.0228 ns | 0.0202 ns |  9.927 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.860 ns | 0.0365 ns | 0.0342 ns | 16.849 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 17.516 ns | 0.0215 ns | 0.0190 ns | 17.520 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 25.867 ns | 0.1256 ns | 0.1174 ns | 25.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 21.376 ns | 0.0916 ns | 0.0857 ns | 21.383 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.482 ns | 0.1392 ns | 0.1302 ns | 18.398 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 26.346 ns | 0.0227 ns | 0.0212 ns | 26.342 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 24.460 ns | 0.0327 ns | 0.0290 ns | 24.461 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.849 ns | 0.0803 ns | 0.0712 ns | 15.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.471 ns | 0.1776 ns | 0.1661 ns | 12.465 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.363 ns | 0.0178 ns | 0.0158 ns |  9.363 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 17.526 ns | 0.1498 ns | 0.1402 ns | 17.588 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 16.632 ns | 0.0220 ns | 0.0206 ns | 16.625 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.114 ns | 0.1702 ns | 0.1509 ns | 26.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.643 ns | 0.3074 ns | 0.2876 ns | 21.708 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.296 ns | 0.0327 ns | 0.0273 ns | 19.297 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 25.089 ns | 0.0248 ns | 0.0207 ns | 25.089 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 25.055 ns | 0.0391 ns | 0.0327 ns | 25.055 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.015 ns | 0.0927 ns | 0.0867 ns | 14.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 12.083 ns | 0.0345 ns | 0.0323 ns | 12.093 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  8.099 ns | 0.1862 ns | 0.2286 ns |  8.247 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.146 ns | 0.0149 ns | 0.0139 ns | 13.150 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.177 ns | 0.0149 ns | 0.0132 ns | 13.179 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.658 ns | 0.0336 ns | 0.0262 ns | 15.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.194 ns | 0.3271 ns | 0.3060 ns | 14.041 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.223 ns | 0.0937 ns | 0.0877 ns | 13.232 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.826 ns | 0.0948 ns | 0.0840 ns | 14.842 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.661 ns | 0.0322 ns | 0.0285 ns | 14.650 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 63.364 ns | 0.4679 ns | 0.3907 ns | 63.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 52.572 ns | 0.3667 ns | 0.3430 ns | 52.486 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.868 ns | 0.0973 ns | 0.0911 ns | 22.824 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 61.416 ns | 0.1005 ns | 0.0940 ns | 61.416 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.018 ns | 0.1012 ns | 0.0897 ns | 60.011 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 67.214 ns | 0.2837 ns | 0.2654 ns | 67.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 62.368 ns | 0.8244 ns | 0.7308 ns | 62.101 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 29.978 ns | 0.0449 ns | 0.0420 ns | 29.967 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 66.051 ns | 0.0702 ns | 0.0548 ns | 66.065 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 66.143 ns | 0.2305 ns | 0.2043 ns | 66.163 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.098 ns | 0.1047 ns | 0.0979 ns | 14.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.864 ns | 0.1657 ns | 0.1550 ns | 13.876 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.091 ns | 0.2882 ns | 0.4402 ns | 13.334 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.601 ns | 0.0906 ns | 0.0848 ns | 14.632 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.306 ns | 0.0153 ns | 0.0143 ns | 14.307 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.976 ns | 0.0660 ns | 0.0585 ns | 15.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.865 ns | 0.1295 ns | 0.1211 ns | 13.805 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 18.125 ns | 0.4113 ns | 1.1119 ns | 18.525 ns |  1.01 |    0.10 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.643 ns | 0.0192 ns | 0.0180 ns | 14.639 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.463 ns | 0.0861 ns | 0.0805 ns | 15.477 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.467 ns | 0.1291 ns | 0.1144 ns | 14.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 14.000 ns | 0.1553 ns | 0.1377 ns | 13.949 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.355 ns | 0.2875 ns | 0.3738 ns | 13.536 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.182 ns | 0.0187 ns | 0.0175 ns | 14.179 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.351 ns | 0.0275 ns | 0.0257 ns | 14.354 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 14.677 ns | 0.4706 ns | 0.4172 ns | 14.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.835 ns | 0.0993 ns | 0.0929 ns | 10.809 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.342 ns | 0.0147 ns | 0.0131 ns |  7.345 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.763 ns | 0.0078 ns | 0.0069 ns | 12.762 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.030 ns | 0.0171 ns | 0.0143 ns | 13.031 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 22.758 ns | 0.0981 ns | 0.0819 ns | 22.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 18.021 ns | 0.1888 ns | 0.1673 ns | 17.994 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.729 ns | 0.3437 ns | 0.3215 ns | 18.889 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.420 ns | 0.0253 ns | 0.0224 ns | 21.416 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.059 ns | 0.0375 ns | 0.0332 ns | 21.057 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 13.101 ns | 0.1051 ns | 0.0983 ns | 13.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.059 ns | 0.0616 ns | 0.0546 ns | 11.056 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.921 ns | 0.0622 ns | 0.0582 ns |  7.948 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.519 ns | 0.1360 ns | 0.1272 ns | 14.582 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.324 ns | 0.0235 ns | 0.0184 ns | 13.326 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.601 ns | 0.0839 ns | 0.0785 ns | 21.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.586 ns | 0.1559 ns | 0.1382 ns | 18.554 ns |  0.86 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.390 ns | 0.1043 ns | 0.0976 ns | 18.342 ns |  0.85 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 23.117 ns | 0.0313 ns | 0.0261 ns | 23.124 ns |  1.07 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.504 ns | 0.1135 ns | 0.1006 ns | 21.539 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.486 ns | 0.1794 ns | 0.1678 ns | 13.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.966 ns | 0.0994 ns | 0.0881 ns | 10.982 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.579 ns | 0.0132 ns | 0.0124 ns |  7.583 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.091 ns | 0.0166 ns | 0.0156 ns | 13.089 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.962 ns | 0.0237 ns | 0.0222 ns | 12.973 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.016 ns | 0.0908 ns | 0.0849 ns | 16.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.706 ns | 0.0410 ns | 0.0364 ns | 13.708 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 18.079 ns | 0.1377 ns | 0.1288 ns | 18.148 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 16.494 ns | 0.0813 ns | 0.0721 ns | 16.508 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.344 ns | 0.0313 ns | 0.0277 ns | 15.337 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 13.078 ns | 0.0771 ns | 0.0721 ns | 13.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.797 ns | 0.1284 ns | 0.1201 ns | 10.765 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.583 ns | 0.0231 ns | 0.0193 ns |  7.583 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.066 ns | 0.0323 ns | 0.0270 ns | 13.063 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.908 ns | 0.0592 ns | 0.0525 ns | 12.916 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 22.004 ns | 0.0862 ns | 0.0807 ns | 22.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.755 ns | 0.1346 ns | 0.1193 ns | 17.733 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 20.971 ns | 0.0910 ns | 0.0851 ns | 20.977 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 23.088 ns | 0.0228 ns | 0.0213 ns | 23.094 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.268 ns | 0.0352 ns | 0.0329 ns | 21.269 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.099 ns | 0.0842 ns | 0.0788 ns | 13.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.048 ns | 0.1345 ns | 0.1258 ns | 11.000 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.834 ns | 0.0304 ns | 0.0270 ns |  7.831 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.732 ns | 0.1262 ns | 0.1180 ns | 13.787 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.381 ns | 0.0481 ns | 0.0401 ns | 13.388 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.454 ns | 0.1389 ns | 0.1160 ns | 22.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.295 ns | 0.1766 ns | 0.1652 ns | 18.327 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.435 ns | 0.0464 ns | 0.0362 ns | 18.442 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 21.412 ns | 0.0240 ns | 0.0213 ns | 21.409 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.099 ns | 0.0308 ns | 0.0257 ns | 21.095 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 14.599 ns | 0.0528 ns | 0.0494 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.307 ns | 0.1917 ns | 0.1794 ns | 11.355 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.585 ns | 0.0495 ns | 0.0463 ns |  7.596 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.799 ns | 0.0119 ns | 0.0099 ns | 13.799 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 14.363 ns | 0.0138 ns | 0.0129 ns | 14.363 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.731 ns | 0.0649 ns | 0.0576 ns | 15.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.759 ns | 0.0990 ns | 0.0926 ns | 13.732 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.425 ns | 0.0502 ns | 0.0445 ns | 14.435 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.782 ns | 0.0799 ns | 0.0748 ns | 14.831 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.291 ns | 0.0200 ns | 0.0187 ns | 15.293 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.907 ns | 0.1108 ns | 0.1036 ns | 12.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.546 ns | 0.2484 ns | 0.2658 ns | 11.555 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.354 ns | 0.0149 ns | 0.0125 ns |  7.354 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.391 ns | 0.0434 ns | 0.0362 ns | 13.367 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.764 ns | 0.0238 ns | 0.0222 ns | 12.758 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 26.767 ns | 0.1414 ns | 0.1254 ns | 26.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 27.032 ns | 0.2603 ns | 0.2435 ns | 26.920 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 32.862 ns | 0.0602 ns | 0.0534 ns | 32.862 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 33.251 ns | 0.2753 ns | 0.2441 ns | 33.142 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 32.787 ns | 0.0918 ns | 0.0814 ns | 32.785 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.912 ns | 0.0708 ns | 0.0662 ns | 12.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.222 ns | 0.0405 ns | 0.0359 ns | 12.209 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.770 ns | 0.0179 ns | 0.0167 ns |  8.770 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.117 ns | 0.0688 ns | 0.0643 ns | 13.090 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.128 ns | 0.0166 ns | 0.0155 ns | 13.124 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.078 ns | 0.0791 ns | 0.0740 ns | 26.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.067 ns | 0.2074 ns | 0.1940 ns | 28.055 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 30.530 ns | 0.0430 ns | 0.0359 ns | 30.531 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 36.250 ns | 0.0716 ns | 0.0670 ns | 36.267 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 35.533 ns | 0.2592 ns | 0.2424 ns | 35.615 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.801 ns | 0.0799 ns | 0.0747 ns | 12.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.318 ns | 0.0841 ns | 0.0787 ns | 12.318 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.395 ns | 0.0111 ns | 0.0099 ns |  8.397 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.917 ns | 0.0278 ns | 0.0247 ns | 13.920 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.186 ns | 0.0102 ns | 0.0085 ns | 13.184 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.644 ns | 0.0354 ns | 0.0296 ns | 15.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.991 ns | 0.2774 ns | 0.2725 ns | 13.949 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.319 ns | 0.0827 ns | 0.0773 ns | 14.344 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 15.269 ns | 0.0691 ns | 0.0647 ns | 15.235 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.669 ns | 0.0240 ns | 0.0225 ns | 14.670 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.378 ns | 0.0490 ns | 0.0459 ns | 15.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.767 ns | 0.2871 ns | 0.3526 ns | 14.857 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.996 ns | 0.0199 ns | 0.0166 ns | 11.989 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 14.681 ns | 0.0093 ns | 0.0078 ns | 14.682 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.605 ns | 0.1022 ns | 0.0956 ns | 15.645 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.336 ns | 0.0646 ns | 0.0604 ns | 13.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 10.133 ns | 0.2160 ns | 0.2218 ns | 10.064 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.068 ns | 0.4601 ns | 0.6744 ns | 12.699 ns |  1.01 |    0.06 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.643 ns | 0.0958 ns | 0.0896 ns | 12.600 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.711 ns | 0.0207 ns | 0.0193 ns | 12.709 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.714 ns | 0.1863 ns | 0.1742 ns | 15.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.567 ns | 0.3120 ns | 0.5546 ns | 14.307 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.645 ns | 0.0766 ns | 0.0717 ns | 14.673 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.335 ns | 0.0293 ns | 0.0228 ns | 16.332 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.764 ns | 0.0144 ns | 0.0135 ns | 14.757 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 20.110 ns | 0.3574 ns | 0.3169 ns | 20.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.149 ns | 0.0633 ns | 0.0561 ns | 14.138 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.434 ns | 0.1983 ns | 0.1758 ns | 15.477 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.648 ns | 0.0172 ns | 0.0153 ns | 18.647 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.539 ns | 0.1045 ns | 0.0978 ns | 18.569 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.120 ns | 0.0961 ns | 0.0899 ns | 19.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.872 ns | 0.1462 ns | 0.1367 ns | 16.890 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.777 ns | 0.1040 ns | 0.0972 ns | 17.818 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 21.572 ns | 0.0266 ns | 0.0249 ns | 21.580 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 20.244 ns | 0.0191 ns | 0.0169 ns | 20.244 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 16.499 ns | 0.0259 ns | 0.0229 ns | 16.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.876 ns | 0.1225 ns | 0.1146 ns | 12.871 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.718 ns | 0.1618 ns | 0.1513 ns | 12.700 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 16.290 ns | 0.1138 ns | 0.1065 ns | 16.235 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 15.879 ns | 0.0315 ns | 0.0294 ns | 15.878 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 19.200 ns | 0.1492 ns | 0.1396 ns | 19.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.826 ns | 0.1105 ns | 0.1033 ns | 13.794 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.857 ns | 0.0390 ns | 0.0345 ns | 14.852 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 16.252 ns | 0.0250 ns | 0.0222 ns | 16.249 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.674 ns | 0.0185 ns | 0.0173 ns | 14.673 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.423 ns | 0.0616 ns | 0.0576 ns | 13.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.976 ns | 0.0907 ns | 0.0757 ns | 11.975 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 13.074 ns | 0.2356 ns | 0.2203 ns | 13.118 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 16.044 ns | 0.1313 ns | 0.1228 ns | 15.986 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 13.995 ns | 0.0797 ns | 0.0746 ns | 13.968 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 20.687 ns | 0.1012 ns | 0.0946 ns | 20.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.183 ns | 0.1086 ns | 0.0907 ns | 15.196 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 21.192 ns | 0.0296 ns | 0.0247 ns | 21.199 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.506 ns | 0.0251 ns | 0.0196 ns | 18.504 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.005 ns | 0.0188 ns | 0.0176 ns | 17.006 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.289 ns | 0.0185 ns | 0.0164 ns | 13.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.076 ns | 0.0509 ns | 0.0451 ns | 11.072 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.281 ns | 0.2640 ns | 0.2825 ns | 12.396 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 13.986 ns | 0.0157 ns | 0.0140 ns | 13.983 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.258 ns | 0.1116 ns | 0.1044 ns | 14.200 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 17.072 ns | 0.0925 ns | 0.0865 ns | 17.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.272 ns | 0.2831 ns | 0.5033 ns | 14.216 ns |  0.84 |    0.03 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.878 ns | 0.0560 ns | 0.0524 ns | 14.885 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 16.376 ns | 0.0364 ns | 0.0340 ns | 16.392 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.755 ns | 0.0300 ns | 0.0234 ns | 15.754 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 22.823 ns | 0.2284 ns | 0.2136 ns | 22.738 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.954 ns | 0.1910 ns | 0.1787 ns | 16.906 ns |  0.74 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.855 ns | 0.2939 ns | 0.2749 ns | 13.727 ns |  0.61 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.910 ns | 0.1121 ns | 0.1048 ns | 20.853 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 21.832 ns | 0.0270 ns | 0.0252 ns | 21.821 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 22.589 ns | 0.1072 ns | 0.0950 ns | 22.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.261 ns | 0.1704 ns | 0.1594 ns | 17.310 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.227 ns | 0.0273 ns | 0.0228 ns | 18.218 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 22.267 ns | 0.0234 ns | 0.0207 ns | 22.264 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 21.062 ns | 0.0793 ns | 0.0662 ns | 21.052 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 23.009 ns | 0.2261 ns | 0.2115 ns | 23.047 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.024 ns | 0.1389 ns | 0.1231 ns | 17.056 ns |  0.74 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.335 ns | 0.0480 ns | 0.0425 ns | 13.333 ns |  0.58 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.154 ns | 0.1498 ns | 0.1401 ns | 20.228 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 20.008 ns | 0.0323 ns | 0.0286 ns | 20.017 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.121 ns | 0.2167 ns | 0.2027 ns | 21.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.035 ns | 0.1488 ns | 0.1392 ns | 18.039 ns |  0.85 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.394 ns | 0.0666 ns | 0.0623 ns | 17.390 ns |  0.82 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 22.216 ns | 0.0120 ns | 0.0106 ns | 22.216 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 21.049 ns | 0.0219 ns | 0.0205 ns | 21.055 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.742 ns | 0.0760 ns | 0.0711 ns | 14.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.187 ns | 0.1574 ns | 0.1314 ns | 12.207 ns |  0.83 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.530 ns | 0.1962 ns | 0.3537 ns |  8.708 ns |  0.56 |    0.03 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.419 ns | 0.0164 ns | 0.0153 ns | 13.419 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.307 ns | 0.0530 ns | 0.0443 ns | 13.300 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.971 ns | 0.0966 ns | 0.0856 ns | 16.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.750 ns | 0.0994 ns | 0.0882 ns | 14.752 ns |  0.87 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.994 ns | 0.1402 ns | 0.1312 ns | 14.902 ns |  0.88 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.078 ns | 0.0321 ns | 0.0300 ns | 15.080 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.676 ns | 0.0213 ns | 0.0199 ns | 14.669 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.798 ns | 0.0811 ns | 0.0758 ns | 14.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.105 ns | 0.0382 ns | 0.0339 ns | 12.102 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.415 ns | 0.0110 ns | 0.0092 ns |  7.417 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.135 ns | 0.0260 ns | 0.0243 ns | 14.129 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.584 ns | 0.1217 ns | 0.1139 ns | 13.658 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 18.217 ns | 0.1197 ns | 0.1120 ns | 18.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.947 ns | 0.0350 ns | 0.0292 ns | 14.936 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.235 ns | 0.3429 ns | 0.4459 ns | 15.929 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.076 ns | 0.0262 ns | 0.0233 ns | 17.077 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.267 ns | 0.0325 ns | 0.0254 ns | 17.263 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.968 ns | 0.1684 ns | 0.1406 ns | 14.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.095 ns | 0.0724 ns | 0.0642 ns | 12.087 ns |  0.81 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.404 ns | 0.0116 ns | 0.0103 ns |  7.404 ns |  0.49 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.762 ns | 0.0249 ns | 0.0208 ns | 12.761 ns |  0.85 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.467 ns | 0.0142 ns | 0.0133 ns | 13.467 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.928 ns | 0.0941 ns | 0.0786 ns | 17.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.064 ns | 0.0773 ns | 0.0723 ns | 15.041 ns |  0.84 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.854 ns | 0.1990 ns | 0.1861 ns | 14.926 ns |  0.83 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.036 ns | 0.0818 ns | 0.0765 ns | 19.040 ns |  1.06 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.419 ns | 0.1079 ns | 0.1009 ns | 17.372 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.944 ns | 0.0705 ns | 0.0660 ns | 14.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.635 ns | 0.1388 ns | 0.1230 ns | 12.613 ns |  0.85 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.470 ns | 0.0884 ns | 0.0827 ns |  7.525 ns |  0.50 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.769 ns | 0.0165 ns | 0.0154 ns | 12.770 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.473 ns | 0.0323 ns | 0.0302 ns | 13.468 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.422 ns | 0.1643 ns | 0.1537 ns | 17.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.760 ns | 0.0560 ns | 0.0496 ns | 13.756 ns |  0.79 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.885 ns | 0.0218 ns | 0.0204 ns | 12.880 ns |  0.74 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.227 ns | 0.0255 ns | 0.0226 ns | 16.232 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.631 ns | 0.0197 ns | 0.0185 ns | 14.629 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 16.043 ns | 0.0518 ns | 0.0485 ns | 16.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 14.592 ns | 0.1023 ns | 0.0957 ns | 14.550 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.205 ns | 0.1173 ns | 0.1097 ns |  7.280 ns |  0.45 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.147 ns | 0.0236 ns | 0.0221 ns | 14.146 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.013 ns | 0.1400 ns | 0.1310 ns | 13.946 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.394 ns | 0.4086 ns | 0.3412 ns | 50.336 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 50.498 ns | 0.2767 ns | 0.2588 ns | 50.440 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 45.480 ns | 0.3600 ns | 0.3368 ns | 45.583 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.123 ns | 0.0770 ns | 0.0643 ns | 50.118 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 47.905 ns | 0.0383 ns | 0.0299 ns | 47.912 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.064 ns | 0.1231 ns | 0.1152 ns | 15.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.782 ns | 0.0199 ns | 0.0176 ns | 13.780 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.012 ns | 0.2018 ns | 0.4757 ns |  9.185 ns |  0.56 |    0.05 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.751 ns | 0.0267 ns | 0.0250 ns | 14.749 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.601 ns | 0.0343 ns | 0.0304 ns | 14.596 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 51.057 ns | 0.3425 ns | 0.3204 ns | 51.012 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 46.178 ns | 0.1142 ns | 0.0891 ns | 46.188 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 43.104 ns | 0.2819 ns | 0.2637 ns | 43.170 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 48.951 ns | 0.1187 ns | 0.1052 ns | 48.972 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 48.916 ns | 0.2096 ns | 0.1961 ns | 48.846 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.576 ns | 0.0735 ns | 0.0687 ns | 14.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.496 ns | 0.0345 ns | 0.0323 ns | 13.489 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.708 ns | 0.0665 ns | 0.0622 ns |  7.729 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 15.932 ns | 0.0351 ns | 0.0293 ns | 15.942 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.180 ns | 0.0322 ns | 0.0285 ns | 13.170 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.620 ns | 0.3623 ns | 0.3559 ns | 15.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.689 ns | 0.0886 ns | 0.0829 ns | 13.660 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.106 ns | 0.3183 ns | 0.3126 ns | 15.136 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.841 ns | 0.0219 ns | 0.0205 ns | 14.838 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.902 ns | 0.0998 ns | 0.0933 ns | 14.876 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.517 ns | 0.1127 ns | 0.0999 ns | 13.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.500 ns | 0.2277 ns | 0.2436 ns | 11.454 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.267 ns | 0.0889 ns | 0.0832 ns | 11.286 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.695 ns | 0.0285 ns | 0.0267 ns | 14.699 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.193 ns | 0.0166 ns | 0.0139 ns | 14.195 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 19.363 ns | 0.1768 ns | 0.1476 ns | 19.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.572 ns | 0.2592 ns | 0.2425 ns | 15.449 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.296 ns | 0.1192 ns | 0.1115 ns | 16.362 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.867 ns | 0.0437 ns | 0.0387 ns | 17.865 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.881 ns | 0.0249 ns | 0.0233 ns | 17.879 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.223 ns | 0.0776 ns | 0.0688 ns | 14.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.159 ns | 0.0554 ns | 0.0463 ns | 11.169 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.974 ns | 0.2612 ns | 0.2794 ns | 12.156 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.835 ns | 0.0228 ns | 0.0202 ns | 13.834 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.626 ns | 0.0984 ns | 0.0921 ns | 14.579 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.656 ns | 0.1274 ns | 0.1129 ns | 15.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.632 ns | 0.0120 ns | 0.0106 ns | 13.630 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.885 ns | 0.3015 ns | 0.4513 ns | 14.102 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.685 ns | 0.0299 ns | 0.0265 ns | 14.686 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.184 ns | 0.0665 ns | 0.0622 ns | 16.149 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 41.046 ns | 0.2736 ns | 0.2560 ns | 40.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.066 ns | 0.0464 ns | 0.0434 ns | 39.053 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.975 ns | 0.1051 ns | 0.0878 ns | 35.982 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.222 ns | 0.2188 ns | 0.2047 ns | 40.139 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 54.272 ns | 0.0780 ns | 0.0692 ns | 54.276 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 21.168 ns | 0.0929 ns | 0.0823 ns | 21.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.439 ns | 0.0877 ns | 0.0820 ns | 15.432 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.014 ns | 0.0383 ns | 0.0340 ns | 16.009 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 18.160 ns | 0.0228 ns | 0.0202 ns | 18.162 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.870 ns | 0.0395 ns | 0.0369 ns | 17.862 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.627 ns | 0.1005 ns | 0.0941 ns | 40.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.801 ns | 0.1142 ns | 0.1013 ns | 38.774 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.884 ns | 0.0524 ns | 0.0438 ns | 34.884 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.683 ns | 0.0807 ns | 0.0716 ns | 40.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.564 ns | 0.1443 ns | 0.1280 ns | 41.534 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.398 ns | 0.0801 ns | 0.0749 ns | 17.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.279 ns | 0.0135 ns | 0.0119 ns | 15.280 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.671 ns | 0.0213 ns | 0.0199 ns | 14.661 ns |  0.84 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.884 ns | 0.0448 ns | 0.0374 ns | 17.871 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.881 ns | 0.0217 ns | 0.0203 ns | 17.883 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 41.639 ns | 0.1438 ns | 0.1275 ns | 41.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.192 ns | 0.2164 ns | 0.2025 ns | 38.134 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.908 ns | 0.0404 ns | 0.0358 ns | 34.917 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.774 ns | 0.0494 ns | 0.0462 ns | 39.769 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.879 ns | 0.1342 ns | 0.1190 ns | 39.862 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.503 ns | 0.0929 ns | 0.0823 ns | 15.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.758 ns | 0.0760 ns | 0.0711 ns | 13.732 ns |  0.89 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.975 ns | 0.1238 ns | 0.1158 ns | 12.899 ns |  0.84 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.881 ns | 0.0365 ns | 0.0342 ns | 14.872 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 14.705 ns | 0.0127 ns | 0.0113 ns | 14.705 ns |  0.95 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
