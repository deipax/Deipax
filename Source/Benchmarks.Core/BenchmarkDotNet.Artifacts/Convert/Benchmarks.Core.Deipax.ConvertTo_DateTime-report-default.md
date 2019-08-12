
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FWPOAF : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-ZZPTUV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOJUSV : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-KESODJ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PJAXXB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |       Mean |      Error |     StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|-----------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  14.013 ns |  0.1908 ns |  0.1784 ns |  13.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  11.773 ns |  0.1341 ns |  0.1254 ns |  11.798 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |   7.096 ns |  0.1779 ns |  0.1826 ns |   7.065 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  12.642 ns |  0.0162 ns |  0.0144 ns |  12.643 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  12.393 ns |  0.1351 ns |  0.1128 ns |  12.368 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  14.206 ns |  0.1941 ns |  0.1816 ns |  14.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  10.115 ns |  0.0880 ns |  0.0823 ns |  10.094 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |   7.038 ns |  0.0437 ns |  0.0409 ns |   7.053 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  12.610 ns |  0.0101 ns |  0.0089 ns |  12.610 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  11.928 ns |  0.0637 ns |  0.0596 ns |  11.926 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  12.385 ns |  0.0946 ns |  0.0885 ns |  12.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  10.073 ns |  0.0176 ns |  0.0156 ns |  10.075 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   6.618 ns |  0.0212 ns |  0.0166 ns |   6.616 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  12.707 ns |  0.0716 ns |  0.0670 ns |  12.676 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  11.996 ns |  0.0644 ns |  0.0603 ns |  11.965 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.562 ns |  0.0752 ns |  0.0628 ns |  14.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.399 ns |  0.0399 ns |  0.0354 ns |  14.392 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.628 ns |  0.1216 ns |  0.1138 ns |  12.574 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  13.707 ns |  0.0458 ns |  0.0428 ns |  13.713 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  13.625 ns |  0.0252 ns |  0.0223 ns |  13.626 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  12.376 ns |  0.1063 ns |  0.0994 ns |  12.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  10.171 ns |  0.0656 ns |  0.0581 ns |  10.154 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |   7.104 ns |  0.0182 ns |  0.0170 ns |   7.101 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  12.607 ns |  0.0253 ns |  0.0236 ns |  12.604 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  12.662 ns |  0.0948 ns |  0.0792 ns |  12.682 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  12.306 ns |  0.0317 ns |  0.0281 ns |  12.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  10.087 ns |  0.0418 ns |  0.0349 ns |  10.077 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |   7.118 ns |  0.1658 ns |  0.2270 ns |   7.116 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  12.818 ns |  0.0190 ns |  0.0178 ns |  12.810 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  12.154 ns |  0.0525 ns |  0.0465 ns |  12.152 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  13.763 ns |  0.1237 ns |  0.1157 ns |  13.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  10.108 ns |  0.0886 ns |  0.0829 ns |  10.072 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   7.080 ns |  0.0651 ns |  0.0609 ns |   7.100 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  12.575 ns |  0.0230 ns |  0.0204 ns |  12.579 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  12.006 ns |  0.1112 ns |  0.0868 ns |  11.992 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.977 ns |  0.0302 ns |  0.0252 ns |  14.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.317 ns |  0.0143 ns |  0.0120 ns |  14.318 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.899 ns |  0.3117 ns |  0.3201 ns |  11.717 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  13.645 ns |  0.0185 ns |  0.0173 ns |  13.644 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  13.705 ns |  0.0804 ns |  0.0712 ns |  13.677 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  14.610 ns |  0.0303 ns |  0.0283 ns |  14.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  10.690 ns |  0.0286 ns |  0.0253 ns |  10.693 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |   7.247 ns |  0.0274 ns |  0.0257 ns |   7.250 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  12.594 ns |  0.0281 ns |  0.0249 ns |  12.600 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  11.961 ns |  0.1256 ns |  0.1175 ns |  11.914 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  12.320 ns |  0.0484 ns |  0.0404 ns |  12.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  10.205 ns |  0.1482 ns |  0.1386 ns |  10.171 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |   6.734 ns |  0.2460 ns |  0.2526 ns |   6.604 ns |  0.55 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  12.788 ns |  0.0243 ns |  0.0216 ns |  12.785 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  12.071 ns |  0.1704 ns |  0.1510 ns |  12.023 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  13.925 ns |  0.1390 ns |  0.1300 ns |  13.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.168 ns |  0.1261 ns |  0.1179 ns |  10.108 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   6.593 ns |  0.0158 ns |  0.0132 ns |   6.590 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  13.815 ns |  0.0285 ns |  0.0266 ns |  13.821 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  11.870 ns |  0.0418 ns |  0.0371 ns |  11.871 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.889 ns |  0.0481 ns |  0.0402 ns |  14.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.451 ns |  0.0853 ns |  0.0798 ns |  14.423 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.722 ns |  0.0326 ns |  0.0305 ns |  11.711 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  13.653 ns |  0.0232 ns |  0.0217 ns |  13.656 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  17.428 ns |  0.0838 ns |  0.0700 ns |  17.442 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  12.995 ns |  0.0438 ns |  0.0366 ns |  12.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  11.170 ns |  0.0505 ns |  0.0473 ns |  11.161 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |   8.374 ns |  0.1924 ns |  0.1800 ns |   8.504 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  12.954 ns |  0.0617 ns |  0.0577 ns |  12.935 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  12.597 ns |  0.0323 ns |  0.0302 ns |  12.592 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |  14.947 ns |  0.0468 ns |  0.0437 ns |  14.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |  15.215 ns |  0.0914 ns |  0.0855 ns |  15.197 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |  13.103 ns |  0.3002 ns |  0.4761 ns |  12.839 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |  14.289 ns |  0.0217 ns |  0.0181 ns |  14.285 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |  14.192 ns |  0.0535 ns |  0.0500 ns |  14.213 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  12.787 ns |  0.0262 ns |  0.0204 ns |  12.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  11.698 ns |  0.0302 ns |  0.0252 ns |  11.701 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |   8.221 ns |  0.0146 ns |  0.0130 ns |   8.220 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  15.140 ns |  0.0404 ns |  0.0358 ns |  15.139 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  16.174 ns |  0.1007 ns |  0.0786 ns |  16.196 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |  14.908 ns |  0.0600 ns |  0.0501 ns |  14.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |  14.531 ns |  0.0513 ns |  0.0429 ns |  14.528 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |  11.682 ns |  0.0815 ns |  0.0762 ns |  11.649 ns |  0.78 |    0.01 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |  14.419 ns |  0.0329 ns |  0.0275 ns |  14.414 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |  14.090 ns |  0.0230 ns |  0.0204 ns |  14.085 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.855 ns |  0.2103 ns |  0.1864 ns |  12.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.499 ns |  0.0333 ns |  0.0295 ns |  11.496 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   9.148 ns |  0.2071 ns |  0.3627 ns |   9.280 ns |  0.69 |    0.04 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  14.028 ns |  0.0400 ns |  0.0374 ns |  14.031 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  14.255 ns |  0.0392 ns |  0.0367 ns |  14.267 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.783 ns |  0.2376 ns |  0.3005 ns |  14.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.440 ns |  0.1062 ns |  0.0887 ns |  14.420 ns |  0.98 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.724 ns |  0.0790 ns |  0.0617 ns |  11.706 ns |  0.79 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  13.417 ns |  0.0942 ns |  0.0881 ns |  13.363 ns |  0.90 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  13.647 ns |  0.0746 ns |  0.0582 ns |  13.665 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  14.697 ns |  0.1933 ns |  0.1614 ns |  14.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  11.715 ns |  0.0530 ns |  0.0414 ns |  11.716 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |   7.862 ns |  0.0171 ns |  0.0143 ns |   7.857 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  14.529 ns |  0.0333 ns |  0.0312 ns |  14.526 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  12.627 ns |  0.0200 ns |  0.0187 ns |  12.628 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  13.668 ns |  0.3637 ns |  0.4467 ns |  13.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  11.459 ns |  0.0417 ns |  0.0348 ns |  11.449 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |   8.336 ns |  0.0991 ns |  0.0927 ns |   8.336 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  14.041 ns |  0.0268 ns |  0.0224 ns |  14.042 ns |  1.02 |    0.04 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  12.973 ns |  0.0526 ns |  0.0492 ns |  12.989 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  13.195 ns |  0.0588 ns |  0.0491 ns |  13.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  11.527 ns |  0.2435 ns |  0.2158 ns |  11.429 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |   8.104 ns |  0.0202 ns |  0.0179 ns |   8.108 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  14.066 ns |  0.0350 ns |  0.0292 ns |  14.064 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  13.977 ns |  0.0608 ns |  0.0568 ns |  13.989 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.570 ns |  0.1215 ns |  0.1077 ns |  14.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.413 ns |  0.0809 ns |  0.0675 ns |  14.417 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.686 ns |  0.1832 ns |  0.1714 ns |  12.776 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  13.488 ns |  0.0264 ns |  0.0221 ns |  13.490 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  13.730 ns |  0.0488 ns |  0.0433 ns |  13.739 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  12.422 ns |  0.1692 ns |  0.1583 ns |  12.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  10.454 ns |  0.1462 ns |  0.1367 ns |  10.362 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |   7.123 ns |  0.0192 ns |  0.0170 ns |   7.121 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 |  13.731 ns |  0.0455 ns |  0.0425 ns |  13.737 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net472 |  12.002 ns |  0.0636 ns |  0.0595 ns |  11.991 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  15.073 ns |  0.2913 ns |  0.3355 ns |  15.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  11.281 ns |  0.0596 ns |  0.0529 ns |  11.278 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |   7.862 ns |  0.0202 ns |  0.0179 ns |   7.862 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  13.698 ns |  0.0351 ns |  0.0312 ns |  13.695 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  12.690 ns |  0.0394 ns |  0.0368 ns |  12.694 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  14.839 ns |  0.1648 ns |  0.1376 ns |  14.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  11.673 ns |  0.0375 ns |  0.0332 ns |  11.671 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |   7.877 ns |  0.0230 ns |  0.0192 ns |   7.875 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  14.993 ns |  0.0311 ns |  0.0291 ns |  15.001 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.786 ns |  0.0891 ns |  0.0696 ns |  12.817 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.742 ns |  0.2797 ns |  0.2617 ns |  14.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.373 ns |  0.0719 ns |  0.0638 ns |  14.380 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.451 ns |  0.2796 ns |  0.2615 ns |  13.572 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  13.388 ns |  0.0237 ns |  0.0222 ns |  13.387 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  16.786 ns |  0.0600 ns |  0.0561 ns |  16.782 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  13.099 ns |  0.1377 ns |  0.1220 ns |  13.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  10.143 ns |  0.0363 ns |  0.0322 ns |  10.142 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |   7.221 ns |  0.0864 ns |  0.0809 ns |   7.255 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 |  12.638 ns |  0.0513 ns |  0.0480 ns |  12.623 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 |  12.208 ns |  0.0721 ns |  0.0674 ns |  12.177 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  12.284 ns |  0.0753 ns |  0.0704 ns |  12.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  10.195 ns |  0.0989 ns |  0.0925 ns |  10.186 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |   6.948 ns |  0.0323 ns |  0.0270 ns |   6.941 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  12.739 ns |  0.0559 ns |  0.0496 ns |  12.744 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  12.459 ns |  0.0220 ns |  0.0206 ns |  12.459 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  12.892 ns |  0.0414 ns |  0.0367 ns |  12.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.120 ns |  0.0197 ns |  0.0165 ns |  10.117 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   6.663 ns |  0.0791 ns |  0.0740 ns |   6.666 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  12.584 ns |  0.0267 ns |  0.0250 ns |  12.577 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  11.889 ns |  0.0202 ns |  0.0189 ns |  11.897 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.004 ns |  0.0683 ns |  0.0605 ns |  14.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.467 ns |  0.0519 ns |  0.0460 ns |  14.458 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.762 ns |  0.3192 ns |  0.4474 ns |  14.838 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.772 ns |  0.0232 ns |  0.0217 ns |  13.768 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  16.275 ns |  0.1303 ns |  0.1219 ns |  16.220 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  12.834 ns |  0.2184 ns |  0.2043 ns |  12.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  10.114 ns |  0.0465 ns |  0.0388 ns |  10.108 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |   7.747 ns |  0.1122 ns |  0.1049 ns |   7.761 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 |  12.576 ns |  0.0177 ns |  0.0147 ns |  12.574 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                              From_Int |        net472 |  11.817 ns |  0.0166 ns |  0.0147 ns |  11.821 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  13.000 ns |  0.0964 ns |  0.0854 ns |  12.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  10.064 ns |  0.0272 ns |  0.0227 ns |  10.058 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |   6.889 ns |  0.0203 ns |  0.0180 ns |   6.889 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  12.580 ns |  0.0238 ns |  0.0198 ns |  12.577 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  12.553 ns |  0.1500 ns |  0.1403 ns |  12.466 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  14.084 ns |  0.1290 ns |  0.1143 ns |  14.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  10.094 ns |  0.0793 ns |  0.0742 ns |  10.058 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   6.621 ns |  0.0579 ns |  0.0513 ns |   6.603 ns |  0.47 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  12.669 ns |  0.0126 ns |  0.0112 ns |  12.668 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  13.280 ns |  0.0215 ns |  0.0201 ns |  13.284 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.807 ns |  0.3005 ns |  0.4310 ns |  14.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  15.022 ns |  0.0623 ns |  0.0520 ns |  15.009 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.029 ns |  0.0859 ns |  0.0762 ns |  14.055 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  15.756 ns |  0.0271 ns |  0.0253 ns |  15.754 ns |  1.06 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  13.349 ns |  0.1111 ns |  0.1039 ns |  13.302 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  12.392 ns |  0.0763 ns |  0.0637 ns |  12.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  10.167 ns |  0.0348 ns |  0.0309 ns |  10.161 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |   7.644 ns |  0.1798 ns |  0.2851 ns |   7.820 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                                             From_Long |        net461 |  13.229 ns |  0.0624 ns |  0.0583 ns |  13.202 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 |  11.856 ns |  0.0251 ns |  0.0209 ns |  11.855 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  13.651 ns |  0.1087 ns |  0.1017 ns |  13.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  11.346 ns |  0.0483 ns |  0.0428 ns |  11.332 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |   7.860 ns |  0.0273 ns |  0.0242 ns |   7.860 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  14.069 ns |  0.1334 ns |  0.1248 ns |  14.140 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  12.698 ns |  0.1253 ns |  0.1172 ns |  12.634 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  13.157 ns |  0.0861 ns |  0.0806 ns |  13.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.487 ns |  0.2037 ns |  0.1906 ns |  11.416 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   8.721 ns |  0.1853 ns |  0.1734 ns |   8.815 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  14.234 ns |  0.0223 ns |  0.0209 ns |  14.241 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  13.474 ns |  0.0929 ns |  0.0776 ns |  13.493 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.541 ns |  0.0728 ns |  0.0608 ns |  14.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.488 ns |  0.0293 ns |  0.0260 ns |  14.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.274 ns |  0.2637 ns |  0.2467 ns |  12.283 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  15.139 ns |  0.4979 ns |  0.4657 ns |  14.970 ns |  1.04 |    0.04 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  14.235 ns |  0.0507 ns |  0.0423 ns |  14.222 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  13.951 ns |  0.1437 ns |  0.1344 ns |  14.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  10.130 ns |  0.0309 ns |  0.0258 ns |  10.125 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |   7.117 ns |  0.1649 ns |  0.1765 ns |   7.202 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  13.792 ns |  0.1886 ns |  0.1764 ns |  13.685 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  12.678 ns |  0.0336 ns |  0.0314 ns |  12.684 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  12.489 ns |  0.1316 ns |  0.1167 ns |  12.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  10.221 ns |  0.1493 ns |  0.1397 ns |  10.274 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |   6.776 ns |  0.0649 ns |  0.0607 ns |   6.776 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  14.089 ns |  0.1172 ns |  0.0979 ns |  14.119 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  11.860 ns |  0.0307 ns |  0.0272 ns |  11.859 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  12.487 ns |  0.0982 ns |  0.0918 ns |  12.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  10.512 ns |  0.0604 ns |  0.0565 ns |  10.518 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   6.605 ns |  0.0176 ns |  0.0164 ns |   6.604 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  12.796 ns |  0.0381 ns |  0.0356 ns |  12.792 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  12.026 ns |  0.0546 ns |  0.0456 ns |  12.020 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.253 ns |  0.1730 ns |  0.1618 ns |  15.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.556 ns |  0.0181 ns |  0.0169 ns |  14.554 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.890 ns |  0.2688 ns |  0.2761 ns |  12.925 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  14.224 ns |  0.0417 ns |  0.0390 ns |  14.222 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  13.744 ns |  0.0331 ns |  0.0277 ns |  13.747 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  12.417 ns |  0.2207 ns |  0.2064 ns |  12.350 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  12.022 ns |  0.1403 ns |  0.1312 ns |  11.957 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |   7.327 ns |  0.0149 ns |  0.0124 ns |   7.325 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 |  12.818 ns |  0.0377 ns |  0.0334 ns |  12.813 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net472 |  11.915 ns |  0.0282 ns |  0.0250 ns |  11.916 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  12.251 ns |  0.0394 ns |  0.0349 ns |  12.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  10.147 ns |  0.0657 ns |  0.0614 ns |  10.135 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |   6.963 ns |  0.0876 ns |  0.0819 ns |   7.011 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  12.783 ns |  0.0592 ns |  0.0554 ns |  12.770 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  12.050 ns |  0.1121 ns |  0.1049 ns |  12.047 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  13.988 ns |  0.1576 ns |  0.1474 ns |  14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.060 ns |  0.0206 ns |  0.0172 ns |  10.063 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   7.264 ns |  0.0512 ns |  0.0454 ns |   7.271 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  12.778 ns |  0.1211 ns |  0.1074 ns |  12.729 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  11.870 ns |  0.0204 ns |  0.0170 ns |  11.872 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.171 ns |  0.0598 ns |  0.0530 ns |  15.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.424 ns |  0.0657 ns |  0.0583 ns |  14.397 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.746 ns |  0.2642 ns |  0.2471 ns |  12.586 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  13.874 ns |  0.0419 ns |  0.0371 ns |  13.869 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  13.471 ns |  0.0261 ns |  0.0232 ns |  13.472 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 533.481 ns | 10.5007 ns | 20.9711 ns | 547.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 461.054 ns |  9.0075 ns | 11.0620 ns | 464.019 ns |  0.87 |    0.05 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 397.850 ns |  0.6998 ns |  0.6204 ns | 397.814 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 790.053 ns |  5.1764 ns |  4.5888 ns | 788.631 ns |  1.45 |    0.03 |      - |     - |     - |         - |
                                           From_String |        net472 | 778.685 ns |  1.6579 ns |  1.4697 ns | 778.658 ns |  1.43 |    0.03 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 509.634 ns |  1.7099 ns |  1.4278 ns | 510.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 456.848 ns |  3.3396 ns |  2.9605 ns | 456.057 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 405.523 ns |  0.4679 ns |  0.4148 ns | 405.477 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 786.466 ns |  1.9025 ns |  1.6865 ns | 786.645 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 794.818 ns |  8.4158 ns |  7.8721 ns | 790.913 ns |  1.56 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.588 ns |  0.0323 ns |  0.0270 ns |  12.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  11.603 ns |  0.2226 ns |  0.2082 ns |  11.495 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  11.317 ns |  0.1075 ns |  0.1006 ns |  11.347 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  14.766 ns |  0.0317 ns |  0.0264 ns |  14.770 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  12.842 ns |  0.0259 ns |  0.0242 ns |  12.839 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  15.483 ns |  0.1210 ns |  0.1132 ns |  15.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  14.746 ns |  0.1524 ns |  0.1425 ns |  14.690 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  11.773 ns |  0.0417 ns |  0.0326 ns |  11.773 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  17.275 ns |  0.0543 ns |  0.0453 ns |  17.282 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  14.349 ns |  0.0388 ns |  0.0303 ns |  14.347 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  13.595 ns |  0.0233 ns |  0.0207 ns |  13.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  11.637 ns |  0.0546 ns |  0.0456 ns |  11.631 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.812 ns |  0.1717 ns |  0.1606 ns |  12.842 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  12.780 ns |  0.0332 ns |  0.0294 ns |  12.776 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  12.703 ns |  0.0163 ns |  0.0153 ns |  12.705 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  12.301 ns |  0.0238 ns |  0.0211 ns |  12.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  10.186 ns |  0.0755 ns |  0.0670 ns |  10.172 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |   7.218 ns |  0.0890 ns |  0.0833 ns |   7.260 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  12.704 ns |  0.0374 ns |  0.0331 ns |  12.693 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  12.157 ns |  0.0192 ns |  0.0160 ns |  12.159 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  12.290 ns |  0.0198 ns |  0.0166 ns |  12.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  10.124 ns |  0.0733 ns |  0.0686 ns |  10.111 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |   6.888 ns |  0.0232 ns |  0.0194 ns |   6.889 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  12.641 ns |  0.0226 ns |  0.0211 ns |  12.642 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  11.845 ns |  0.0309 ns |  0.0289 ns |  11.849 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  13.093 ns |  0.0544 ns |  0.0483 ns |  13.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  10.120 ns |  0.0595 ns |  0.0497 ns |  10.115 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   8.075 ns |  0.1850 ns |  0.2470 ns |   8.125 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  12.658 ns |  0.0257 ns |  0.0215 ns |  12.653 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  12.072 ns |  0.0730 ns |  0.0683 ns |  12.053 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.553 ns |  0.1733 ns |  0.1621 ns |  15.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  15.406 ns |  0.0691 ns |  0.0647 ns |  15.383 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.512 ns |  0.0295 ns |  0.0276 ns |  12.514 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.605 ns |  0.0321 ns |  0.0300 ns |  13.603 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  13.349 ns |  0.0181 ns |  0.0169 ns |  13.347 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  14.452 ns |  0.2738 ns |  0.3363 ns |  14.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  11.101 ns |  0.0734 ns |  0.0687 ns |  11.106 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |   7.291 ns |  0.0277 ns |  0.0260 ns |   7.290 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  12.654 ns |  0.0362 ns |  0.0302 ns |  12.647 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  11.842 ns |  0.0244 ns |  0.0228 ns |  11.842 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  12.343 ns |  0.0373 ns |  0.0349 ns |  12.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  10.062 ns |  0.0268 ns |  0.0223 ns |  10.064 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |   6.609 ns |  0.0150 ns |  0.0125 ns |   6.613 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  13.227 ns |  0.0285 ns |  0.0252 ns |  13.220 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  11.838 ns |  0.0249 ns |  0.0233 ns |  11.845 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  13.876 ns |  0.0234 ns |  0.0195 ns |  13.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.184 ns |  0.0781 ns |  0.0693 ns |  10.159 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   6.881 ns |  0.0096 ns |  0.0090 ns |   6.878 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  12.645 ns |  0.0175 ns |  0.0163 ns |  12.645 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  11.993 ns |  0.0814 ns |  0.0722 ns |  12.023 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.596 ns |  0.0743 ns |  0.0695 ns |  14.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.970 ns |  0.3333 ns |  0.3423 ns |  14.848 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.779 ns |  0.0622 ns |  0.0582 ns |  11.760 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  14.143 ns |  0.0354 ns |  0.0314 ns |  14.137 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  16.199 ns |  0.0318 ns |  0.0297 ns |  16.200 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  12.335 ns |  0.0369 ns |  0.0308 ns |  12.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  10.123 ns |  0.0762 ns |  0.0675 ns |  10.096 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |   7.095 ns |  0.0177 ns |  0.0165 ns |   7.097 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  12.865 ns |  0.1494 ns |  0.1397 ns |  12.943 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  12.178 ns |  0.0253 ns |  0.0211 ns |  12.171 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  15.840 ns |  0.1014 ns |  0.0948 ns |  15.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  11.251 ns |  0.0242 ns |  0.0215 ns |  11.250 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |   7.857 ns |  0.0103 ns |  0.0092 ns |   7.860 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  13.757 ns |  0.0280 ns |  0.0248 ns |  13.763 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  12.635 ns |  0.0246 ns |  0.0230 ns |  12.630 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.159 ns |  0.0561 ns |  0.0468 ns |  13.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.226 ns |  0.0344 ns |  0.0305 ns |  11.215 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |   8.345 ns |  0.1907 ns |  0.2480 ns |   8.451 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.766 ns |  0.0394 ns |  0.0368 ns |  13.756 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  14.481 ns |  0.0254 ns |  0.0237 ns |  14.473 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.546 ns |  0.0747 ns |  0.0662 ns |  14.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.232 ns |  0.0330 ns |  0.0309 ns |  14.225 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.726 ns |  0.2003 ns |  0.1874 ns |  12.773 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  14.117 ns |  0.0271 ns |  0.0227 ns |  14.122 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  13.428 ns |  0.0224 ns |  0.0199 ns |  13.427 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  18.644 ns |  0.2240 ns |  0.2095 ns |  18.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  14.310 ns |  0.0310 ns |  0.0259 ns |  14.305 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  12.535 ns |  0.0299 ns |  0.0280 ns |  12.532 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  15.256 ns |  0.0333 ns |  0.0311 ns |  15.253 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  14.036 ns |  0.1584 ns |  0.1481 ns |  13.926 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  11.272 ns |  0.0290 ns |  0.0257 ns |  11.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  10.402 ns |  0.0356 ns |  0.0333 ns |  10.395 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  11.211 ns |  0.2201 ns |  0.2059 ns |  11.352 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  11.336 ns |  0.0182 ns |  0.0170 ns |  11.338 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  12.478 ns |  0.0171 ns |  0.0160 ns |  12.479 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  16.550 ns |  0.0455 ns |  0.0403 ns |  16.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  14.212 ns |  0.0143 ns |  0.0120 ns |  14.209 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  11.744 ns |  0.0196 ns |  0.0163 ns |  11.743 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  14.467 ns |  0.0725 ns |  0.0642 ns |  14.441 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  15.368 ns |  0.0313 ns |  0.0278 ns |  15.377 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  17.166 ns |  0.0961 ns |  0.0852 ns |  17.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  13.714 ns |  0.0194 ns |  0.0172 ns |  13.717 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  13.336 ns |  0.1286 ns |  0.1203 ns |  13.396 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  18.859 ns |  0.0213 ns |  0.0178 ns |  18.860 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  18.531 ns |  0.0394 ns |  0.0349 ns |  18.530 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  19.118 ns |  0.2012 ns |  0.1882 ns |  19.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  16.944 ns |  0.0248 ns |  0.0207 ns |  16.946 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  15.540 ns |  0.2253 ns |  0.2108 ns |  15.614 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  17.837 ns |  0.1433 ns |  0.1341 ns |  17.802 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  17.608 ns |  0.0394 ns |  0.0349 ns |  17.600 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  14.582 ns |  0.0635 ns |  0.0563 ns |  14.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  12.822 ns |  0.0327 ns |  0.0306 ns |  12.821 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  11.791 ns |  0.2127 ns |  0.1989 ns |  11.939 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  15.209 ns |  0.0394 ns |  0.0329 ns |  15.201 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  16.490 ns |  0.0152 ns |  0.0118 ns |  16.490 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  14.744 ns |  0.0445 ns |  0.0372 ns |  14.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  14.557 ns |  0.2824 ns |  0.3139 ns |  14.488 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.060 ns |  0.2133 ns |  0.1995 ns |  13.186 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  13.574 ns |  0.0288 ns |  0.0241 ns |  13.572 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  13.465 ns |  0.0300 ns |  0.0281 ns |  13.469 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  14.104 ns |  0.2008 ns |  0.1878 ns |  14.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  11.029 ns |  0.1040 ns |  0.0973 ns |  11.074 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  11.036 ns |  0.0536 ns |  0.0475 ns |  11.028 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  14.033 ns |  0.0177 ns |  0.0165 ns |  14.037 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  14.314 ns |  0.0372 ns |  0.0348 ns |  14.308 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  17.712 ns |  0.1697 ns |  0.1587 ns |  17.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  15.647 ns |  0.0624 ns |  0.0584 ns |  15.629 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  13.255 ns |  0.0235 ns |  0.0208 ns |  13.252 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  15.302 ns |  0.0261 ns |  0.0245 ns |  15.300 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  17.249 ns |  0.0301 ns |  0.0251 ns |  17.254 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  13.154 ns |  0.0783 ns |  0.0732 ns |  13.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  10.806 ns |  0.0204 ns |  0.0181 ns |  10.804 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  12.006 ns |  0.2576 ns |  0.2645 ns |  12.073 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  14.170 ns |  0.0223 ns |  0.0208 ns |  14.171 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  14.398 ns |  0.0179 ns |  0.0158 ns |  14.401 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  14.608 ns |  0.0585 ns |  0.0518 ns |  14.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  15.307 ns |  0.0465 ns |  0.0434 ns |  15.295 ns |  1.05 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  12.127 ns |  0.2579 ns |  0.2649 ns |  12.261 ns |  0.83 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  13.599 ns |  0.0105 ns |  0.0093 ns |  13.598 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.545 ns |  0.0124 ns |  0.0110 ns |  13.545 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  20.598 ns |  0.0699 ns |  0.0583 ns |  20.598 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  16.199 ns |  0.1376 ns |  0.1287 ns |  16.134 ns |  0.79 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  12.006 ns |  0.1445 ns |  0.1351 ns |  11.951 ns |  0.58 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  19.167 ns |  0.0380 ns |  0.0337 ns |  19.173 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  19.789 ns |  0.0442 ns |  0.0414 ns |  19.793 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  17.810 ns |  0.1561 ns |  0.1461 ns |  17.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  16.784 ns |  0.0205 ns |  0.0192 ns |  16.789 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  16.484 ns |  0.1701 ns |  0.1591 ns |  16.575 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  18.621 ns |  0.0369 ns |  0.0346 ns |  18.611 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  18.350 ns |  0.0237 ns |  0.0210 ns |  18.348 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  19.555 ns |  0.2119 ns |  0.1878 ns |  19.552 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  16.757 ns |  0.1567 ns |  0.1466 ns |  16.800 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  12.557 ns |  0.1866 ns |  0.1745 ns |  12.564 ns |  0.64 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  20.283 ns |  0.2678 ns |  0.2505 ns |  20.125 ns |  1.04 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  18.737 ns |  0.0575 ns |  0.0538 ns |  18.742 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  21.055 ns |  0.2894 ns |  0.2707 ns |  21.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.396 ns |  0.0687 ns |  0.0643 ns |  16.376 ns |  0.78 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  16.338 ns |  0.0328 ns |  0.0307 ns |  16.340 ns |  0.78 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  18.349 ns |  0.0389 ns |  0.0304 ns |  18.353 ns |  0.88 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  18.360 ns |  0.0319 ns |  0.0299 ns |  18.356 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.982 ns |  0.0645 ns |  0.0538 ns |  13.969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  11.570 ns |  0.0300 ns |  0.0280 ns |  11.569 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   7.414 ns |  0.0223 ns |  0.0209 ns |   7.408 ns |  0.53 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  12.879 ns |  0.0319 ns |  0.0299 ns |  12.891 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  13.793 ns |  0.0253 ns |  0.0237 ns |  13.794 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.526 ns |  0.0528 ns |  0.0468 ns |  15.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.254 ns |  0.0393 ns |  0.0349 ns |  14.256 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.258 ns |  0.2690 ns |  0.3098 ns |  12.386 ns |  0.79 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  15.340 ns |  0.1087 ns |  0.1017 ns |  15.400 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.369 ns |  0.0237 ns |  0.0210 ns |  14.366 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  13.721 ns |  0.0347 ns |  0.0307 ns |  13.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  12.495 ns |  0.1459 ns |  0.1365 ns |  12.404 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |   7.479 ns |  0.0160 ns |  0.0133 ns |   7.478 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  13.322 ns |  0.0644 ns |  0.0602 ns |  13.308 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  12.110 ns |  0.0106 ns |  0.0099 ns |  12.109 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  15.551 ns |  0.0543 ns |  0.0482 ns |  15.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  16.007 ns |  0.0584 ns |  0.0488 ns |  15.989 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  15.671 ns |  0.1096 ns |  0.1025 ns |  15.702 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  16.702 ns |  0.0393 ns |  0.0368 ns |  16.690 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  15.786 ns |  0.0343 ns |  0.0304 ns |  15.788 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  13.646 ns |  0.0304 ns |  0.0254 ns |  13.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  11.578 ns |  0.1387 ns |  0.1298 ns |  11.501 ns |  0.85 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |   6.885 ns |  0.0244 ns |  0.0216 ns |   6.878 ns |  0.50 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  12.885 ns |  0.0228 ns |  0.0214 ns |  12.894 ns |  0.94 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  12.506 ns |  0.0691 ns |  0.0577 ns |  12.532 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  15.605 ns |  0.0467 ns |  0.0414 ns |  15.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  15.151 ns |  0.0364 ns |  0.0304 ns |  15.145 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  13.243 ns |  0.0261 ns |  0.0231 ns |  13.238 ns |  0.85 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  15.123 ns |  0.0391 ns |  0.0366 ns |  15.118 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  14.910 ns |  0.0425 ns |  0.0398 ns |  14.909 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.843 ns |  0.0382 ns |  0.0357 ns |  13.838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  11.409 ns |  0.0182 ns |  0.0161 ns |  11.411 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   8.093 ns |  0.1853 ns |  0.3044 ns |   8.241 ns |  0.57 |    0.03 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  12.669 ns |  0.0277 ns |  0.0259 ns |  12.679 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  12.110 ns |  0.0130 ns |  0.0122 ns |  12.114 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  16.024 ns |  0.1373 ns |  0.1218 ns |  15.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.229 ns |  0.0160 ns |  0.0150 ns |  14.228 ns |  0.89 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  11.757 ns |  0.0271 ns |  0.0226 ns |  11.756 ns |  0.73 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.842 ns |  0.0908 ns |  0.0849 ns |  13.873 ns |  0.86 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.982 ns |  0.1002 ns |  0.0937 ns |  14.030 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  13.873 ns |  0.1665 ns |  0.1558 ns |  13.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  10.073 ns |  0.0249 ns |  0.0233 ns |  10.071 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   8.100 ns |  0.1695 ns |  0.1586 ns |   8.151 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  12.873 ns |  0.1173 ns |  0.0916 ns |  12.846 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  11.925 ns |  0.0170 ns |  0.0159 ns |  11.927 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  13.834 ns |  0.0457 ns |  0.0405 ns |  13.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.048 ns |  0.0199 ns |  0.0187 ns |  10.049 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   6.871 ns |  0.0121 ns |  0.0113 ns |   6.871 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  13.117 ns |  0.5244 ns |  0.5150 ns |  12.908 ns |  0.95 |    0.04 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  11.957 ns |  0.0184 ns |  0.0172 ns |  11.959 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |         NA |         NA |         NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  13.896 ns |  0.0621 ns |  0.0551 ns |  13.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  10.054 ns |  0.0169 ns |  0.0150 ns |  10.056 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   7.494 ns |  0.0211 ns |  0.0197 ns |   7.501 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  13.006 ns |  0.3502 ns |  0.3276 ns |  12.915 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  11.979 ns |  0.0137 ns |  0.0128 ns |  11.981 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.544 ns |  0.0633 ns |  0.0561 ns |  14.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.232 ns |  0.0448 ns |  0.0397 ns |  14.219 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.641 ns |  0.1146 ns |  0.1072 ns |  12.692 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  13.698 ns |  0.0714 ns |  0.0596 ns |  13.685 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  13.572 ns |  0.0193 ns |  0.0171 ns |  13.574 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  13.080 ns |  0.0339 ns |  0.0317 ns |  13.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  10.804 ns |  0.0233 ns |  0.0218 ns |  10.802 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  11.466 ns |  0.0314 ns |  0.0294 ns |  11.459 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  14.393 ns |  0.0662 ns |  0.0587 ns |  14.382 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  14.309 ns |  0.0273 ns |  0.0242 ns |  14.313 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  17.689 ns |  0.0827 ns |  0.0733 ns |  17.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  16.670 ns |  0.1283 ns |  0.1200 ns |  16.719 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  15.209 ns |  0.0251 ns |  0.0222 ns |  15.208 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  15.738 ns |  0.1137 ns |  0.1063 ns |  15.697 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  15.422 ns |  0.0313 ns |  0.0293 ns |  15.426 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  13.291 ns |  0.1394 ns |  0.1304 ns |  13.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  10.800 ns |  0.0136 ns |  0.0120 ns |  10.799 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  11.749 ns |  0.1299 ns |  0.1215 ns |  11.830 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  14.263 ns |  0.1574 ns |  0.1395 ns |  14.211 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  14.365 ns |  0.0504 ns |  0.0446 ns |  14.355 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  14.657 ns |  0.0547 ns |  0.0427 ns |  14.664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  14.219 ns |  0.0265 ns |  0.0235 ns |  14.218 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  12.528 ns |  0.0196 ns |  0.0184 ns |  12.529 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  13.729 ns |  0.0599 ns |  0.0531 ns |  13.713 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  13.926 ns |  0.0570 ns |  0.0533 ns |  13.939 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  47.511 ns |  0.1007 ns |  0.0942 ns |  47.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  38.222 ns |  0.0704 ns |  0.0588 ns |  38.201 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  35.957 ns |  0.2954 ns |  0.2763 ns |  36.081 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  39.083 ns |  0.1459 ns |  0.1139 ns |  39.098 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 |  38.726 ns |  0.1602 ns |  0.1499 ns |  38.659 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  21.451 ns |  0.2772 ns |  0.2593 ns |  21.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  15.887 ns |  0.0267 ns |  0.0237 ns |  15.885 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  13.526 ns |  0.0187 ns |  0.0156 ns |  13.526 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  16.851 ns |  0.0733 ns |  0.0650 ns |  16.835 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  15.280 ns |  0.0296 ns |  0.0276 ns |  15.288 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 |  39.750 ns |  0.2125 ns |  0.1988 ns |  39.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  38.077 ns |  0.0977 ns |  0.0763 ns |  38.063 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  35.522 ns |  0.7114 ns |  0.6655 ns |  35.822 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  39.087 ns |  0.1642 ns |  0.1536 ns |  39.095 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  40.447 ns |  0.2664 ns |  0.2492 ns |  40.583 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  16.238 ns |  0.1807 ns |  0.1691 ns |  16.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.727 ns |  0.1646 ns |  0.1540 ns |  16.786 ns |  1.03 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  13.720 ns |  0.1472 ns |  0.1377 ns |  13.776 ns |  0.85 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  17.243 ns |  0.0291 ns |  0.0227 ns |  17.242 ns |  1.06 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  15.410 ns |  0.0274 ns |  0.0243 ns |  15.412 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  44.057 ns |  0.1613 ns |  0.1509 ns |  44.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  38.493 ns |  0.0733 ns |  0.0612 ns |  38.491 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  35.336 ns |  0.3799 ns |  0.3554 ns |  35.503 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  41.327 ns |  0.5017 ns |  0.4448 ns |  41.164 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  38.610 ns |  0.0669 ns |  0.0625 ns |  38.622 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |            |            |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.679 ns |  0.0410 ns |  0.0343 ns |  15.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.240 ns |  0.0292 ns |  0.0259 ns |  14.237 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.547 ns |  0.0805 ns |  0.0672 ns |  12.532 ns |  0.80 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  14.628 ns |  0.2418 ns |  0.2020 ns |  14.526 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  13.642 ns |  0.1001 ns |  0.0937 ns |  13.687 ns |  0.87 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Bool_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Bool_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Bool_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Bool_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Byte_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Byte_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Byte_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Byte_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Byte_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Double_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Double_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Double_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Double_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Double_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Short_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Short_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Short_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Short_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Short_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Int_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Int_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Int_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Int_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Int_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Long_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Long_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Long_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Long_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Long_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_SByte_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_SByte_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_SByte_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_SByte_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_SByte_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Float_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Float_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Float_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Float_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Float_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_UShort_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UShort_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UShort_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UShort_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_UShort_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_UInt_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UInt_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UInt_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UInt_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_UInt_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_ULong_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_ULong_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_ULong_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_ULong_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_ULong_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Enum_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Enum_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Enum_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Enum_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Enum_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
