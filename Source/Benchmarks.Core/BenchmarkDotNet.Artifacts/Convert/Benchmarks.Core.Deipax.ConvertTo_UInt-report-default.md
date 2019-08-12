
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
                                             From_Bool | .NET Core 2.0 | 13.170 ns | 0.0164 ns | 0.0153 ns | 13.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.408 ns | 0.0115 ns | 0.0102 ns | 10.405 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.060 ns | 0.0100 ns | 0.0093 ns |  7.057 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.372 ns | 0.0109 ns | 0.0096 ns | 10.374 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.384 ns | 0.0209 ns | 0.0196 ns | 10.385 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.213 ns | 0.0384 ns | 0.0341 ns | 18.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.355 ns | 0.0323 ns | 0.0302 ns | 16.356 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.294 ns | 0.0508 ns | 0.0475 ns | 17.285 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.022 ns | 0.0268 ns | 0.0238 ns | 18.026 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.193 ns | 0.0404 ns | 0.0378 ns | 18.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.932 ns | 0.0183 ns | 0.0171 ns | 12.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.602 ns | 0.0087 ns | 0.0081 ns | 10.600 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.383 ns | 0.1686 ns | 0.1874 ns |  7.443 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.670 ns | 0.0753 ns | 0.0704 ns | 10.628 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.468 ns | 0.0093 ns | 0.0082 ns | 10.469 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.239 ns | 0.1958 ns | 0.1832 ns | 18.280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.356 ns | 0.0467 ns | 0.0414 ns | 16.365 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.362 ns | 0.1202 ns | 0.1124 ns | 16.361 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 19.907 ns | 0.1226 ns | 0.1147 ns | 19.837 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.294 ns | 0.0312 ns | 0.0292 ns | 18.286 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.690 ns | 0.0101 ns | 0.0090 ns | 11.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.356 ns | 0.0112 ns | 0.0099 ns | 10.358 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.582 ns | 0.0109 ns | 0.0096 ns |  6.579 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.589 ns | 0.0171 ns | 0.0151 ns | 10.588 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.156 ns | 0.0206 ns | 0.0172 ns | 10.156 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.049 ns | 0.0141 ns | 0.0125 ns | 14.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.466 ns | 0.0153 ns | 0.0135 ns | 13.463 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.069 ns | 0.0699 ns | 0.0654 ns | 13.094 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.545 ns | 0.0666 ns | 0.0623 ns | 13.531 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.143 ns | 0.0344 ns | 0.0322 ns | 13.148 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.660 ns | 0.0160 ns | 0.0150 ns | 11.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.306 ns | 0.0130 ns | 0.0122 ns | 10.305 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.069 ns | 0.0146 ns | 0.0136 ns |  7.068 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.228 ns | 0.0140 ns | 0.0124 ns | 10.227 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.247 ns | 0.0056 ns | 0.0052 ns | 10.245 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.354 ns | 0.0216 ns | 0.0191 ns | 18.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.715 ns | 0.0293 ns | 0.0245 ns | 15.710 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.765 ns | 0.0269 ns | 0.0239 ns | 15.768 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.344 ns | 0.0243 ns | 0.0216 ns | 18.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.360 ns | 0.0368 ns | 0.0344 ns | 18.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.849 ns | 0.0120 ns | 0.0106 ns | 11.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.480 ns | 0.0121 ns | 0.0108 ns | 10.482 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.848 ns | 0.0177 ns | 0.0157 ns |  6.852 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.410 ns | 0.0866 ns | 0.0810 ns | 12.367 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 11.300 ns | 0.0065 ns | 0.0060 ns | 11.300 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.655 ns | 0.0292 ns | 0.0273 ns | 16.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.495 ns | 0.0212 ns | 0.0198 ns | 15.494 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.766 ns | 0.0305 ns | 0.0285 ns | 15.762 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 19.504 ns | 0.0904 ns | 0.0801 ns | 19.481 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.035 ns | 0.0150 ns | 0.0133 ns | 18.035 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.783 ns | 0.0339 ns | 0.0317 ns | 11.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.429 ns | 0.0201 ns | 0.0168 ns | 10.431 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.583 ns | 0.0189 ns | 0.0158 ns |  6.585 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.372 ns | 0.0114 ns | 0.0106 ns | 10.371 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.282 ns | 0.1359 ns | 0.1272 ns | 10.193 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.150 ns | 0.0129 ns | 0.0115 ns | 13.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.654 ns | 0.0155 ns | 0.0145 ns | 12.656 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.905 ns | 0.0665 ns | 0.0555 ns | 13.917 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.957 ns | 0.0145 ns | 0.0128 ns | 14.956 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.102 ns | 0.0186 ns | 0.0174 ns | 13.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.778 ns | 0.0146 ns | 0.0130 ns | 11.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.110 ns | 0.0187 ns | 0.0175 ns | 11.111 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.589 ns | 0.0120 ns | 0.0107 ns |  6.590 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.223 ns | 0.0153 ns | 0.0119 ns | 10.224 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.630 ns | 0.0100 ns | 0.0088 ns | 10.631 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.282 ns | 0.0387 ns | 0.0343 ns | 19.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.643 ns | 0.0171 ns | 0.0160 ns | 16.642 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 16.108 ns | 0.0554 ns | 0.0462 ns | 16.105 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 17.910 ns | 0.0314 ns | 0.0294 ns | 17.908 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 17.772 ns | 0.0873 ns | 0.0816 ns | 17.768 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.868 ns | 0.0103 ns | 0.0091 ns | 11.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.482 ns | 0.0129 ns | 0.0120 ns | 10.484 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.052 ns | 0.0139 ns | 0.0116 ns |  7.052 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.768 ns | 0.0091 ns | 0.0081 ns | 10.767 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.572 ns | 0.0081 ns | 0.0076 ns | 10.571 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.428 ns | 0.0363 ns | 0.0322 ns | 17.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.213 ns | 0.1034 ns | 0.0967 ns | 17.170 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.467 ns | 0.2638 ns | 0.2467 ns | 16.603 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.842 ns | 0.0261 ns | 0.0244 ns | 18.840 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 17.853 ns | 0.0221 ns | 0.0207 ns | 17.860 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.712 ns | 0.0229 ns | 0.0215 ns | 11.710 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.337 ns | 0.0092 ns | 0.0086 ns | 10.337 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.889 ns | 0.0150 ns | 0.0141 ns |  6.891 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.837 ns | 0.0092 ns | 0.0081 ns | 11.837 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.215 ns | 0.0325 ns | 0.0288 ns | 10.207 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.144 ns | 0.0137 ns | 0.0129 ns | 13.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.662 ns | 0.0118 ns | 0.0105 ns | 12.660 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.864 ns | 0.0172 ns | 0.0143 ns | 12.868 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.090 ns | 0.0416 ns | 0.0369 ns | 15.100 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.584 ns | 0.0094 ns | 0.0088 ns | 13.584 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.098 ns | 0.0157 ns | 0.0147 ns | 12.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.046 ns | 0.0121 ns | 0.0101 ns | 11.048 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.749 ns | 0.0299 ns | 0.0265 ns |  7.749 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 11.858 ns | 0.0173 ns | 0.0162 ns | 11.862 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 16.232 ns | 0.0164 ns | 0.0154 ns | 16.223 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.599 ns | 0.0133 ns | 0.0118 ns | 12.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.206 ns | 0.0096 ns | 0.0090 ns | 11.206 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  7.864 ns | 0.0135 ns | 0.0112 ns |  7.862 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.587 ns | 0.0147 ns | 0.0137 ns | 12.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.792 ns | 0.0142 ns | 0.0126 ns | 13.790 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.602 ns | 0.0165 ns | 0.0146 ns | 12.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.211 ns | 0.0101 ns | 0.0095 ns | 11.209 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.041 ns | 0.0911 ns | 0.0807 ns |  8.005 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.280 ns | 0.0150 ns | 0.0141 ns | 13.280 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.150 ns | 0.0308 ns | 0.0273 ns | 13.149 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.154 ns | 0.0127 ns | 0.0112 ns | 13.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.507 ns | 0.0133 ns | 0.0111 ns | 13.509 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.732 ns | 0.0258 ns | 0.0228 ns | 13.738 ns |  1.04 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.242 ns | 0.0201 ns | 0.0188 ns | 13.239 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.657 ns | 0.0203 ns | 0.0190 ns | 13.654 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.825 ns | 0.0599 ns | 0.0560 ns | 21.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 19.483 ns | 0.0369 ns | 0.0327 ns | 19.479 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.968 ns | 0.0191 ns | 0.0169 ns | 12.964 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.409 ns | 0.0246 ns | 0.0218 ns | 21.411 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 21.103 ns | 0.0291 ns | 0.0243 ns | 21.110 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 25.861 ns | 0.0215 ns | 0.0201 ns | 25.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.736 ns | 0.0246 ns | 0.0218 ns | 24.735 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.838 ns | 0.0303 ns | 0.0236 ns | 20.846 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.138 ns | 0.0337 ns | 0.0315 ns | 27.138 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 26.112 ns | 0.0258 ns | 0.0229 ns | 26.111 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.633 ns | 0.0270 ns | 0.0253 ns | 22.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.486 ns | 0.0288 ns | 0.0270 ns | 20.491 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.773 ns | 0.1695 ns | 0.1586 ns | 15.656 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 22.744 ns | 0.0479 ns | 0.0425 ns | 22.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 22.328 ns | 0.0179 ns | 0.0159 ns | 22.329 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.116 ns | 0.0232 ns | 0.0217 ns | 26.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.625 ns | 0.0401 ns | 0.0356 ns | 25.618 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.187 ns | 0.0271 ns | 0.0240 ns | 21.182 ns |  0.81 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.123 ns | 0.0484 ns | 0.0452 ns | 26.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.280 ns | 0.0832 ns | 0.0779 ns | 27.272 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.579 ns | 0.0109 ns | 0.0097 ns | 12.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.507 ns | 0.0420 ns | 0.0372 ns | 11.520 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.778 ns | 0.0655 ns | 0.0613 ns |  8.745 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.453 ns | 0.0182 ns | 0.0161 ns | 13.455 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.963 ns | 0.0118 ns | 0.0110 ns | 13.957 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.180 ns | 0.0191 ns | 0.0170 ns | 13.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.631 ns | 0.0100 ns | 0.0084 ns | 12.634 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.293 ns | 0.2664 ns | 0.2492 ns | 12.110 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.011 ns | 0.0206 ns | 0.0193 ns | 13.008 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.268 ns | 0.0154 ns | 0.0144 ns | 13.268 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.267 ns | 0.0111 ns | 0.0104 ns | 12.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.032 ns | 0.0249 ns | 0.0233 ns | 11.033 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  8.987 ns | 0.0177 ns | 0.0166 ns |  8.988 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 11.361 ns | 0.0194 ns | 0.0182 ns | 11.358 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 11.256 ns | 0.0206 ns | 0.0192 ns | 11.252 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 17.518 ns | 0.0369 ns | 0.0327 ns | 17.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.213 ns | 0.0366 ns | 0.0325 ns | 17.220 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.346 ns | 0.1190 ns | 0.1113 ns | 20.386 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 19.370 ns | 0.0667 ns | 0.0624 ns | 19.358 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 19.354 ns | 0.0585 ns | 0.0489 ns | 19.344 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.601 ns | 0.0221 ns | 0.0207 ns | 14.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.952 ns | 0.0183 ns | 0.0171 ns | 12.948 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.434 ns | 0.2730 ns | 0.4992 ns | 12.612 ns |  0.83 |    0.05 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.330 ns | 0.0193 ns | 0.0180 ns | 15.329 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.285 ns | 0.0182 ns | 0.0170 ns | 14.288 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.294 ns | 0.0373 ns | 0.0331 ns | 19.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.815 ns | 0.0381 ns | 0.0356 ns | 16.818 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.589 ns | 0.0204 ns | 0.0191 ns | 17.589 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 19.172 ns | 0.0280 ns | 0.0248 ns | 19.168 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 19.117 ns | 0.0891 ns | 0.0833 ns | 19.117 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.496 ns | 0.0144 ns | 0.0135 ns | 12.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.446 ns | 0.0109 ns | 0.0097 ns | 11.445 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.098 ns | 0.0870 ns | 0.0814 ns |  9.094 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.648 ns | 0.0116 ns | 0.0108 ns | 12.651 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.545 ns | 0.0119 ns | 0.0106 ns | 12.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.181 ns | 0.0202 ns | 0.0189 ns | 14.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.468 ns | 0.0111 ns | 0.0104 ns | 13.464 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.428 ns | 0.1279 ns | 0.1196 ns | 12.419 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.030 ns | 0.0137 ns | 0.0107 ns | 13.028 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.086 ns | 0.0109 ns | 0.0102 ns | 13.087 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.782 ns | 0.0100 ns | 0.0084 ns | 11.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.738 ns | 0.0183 ns | 0.0162 ns | 10.736 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.064 ns | 0.0108 ns | 0.0096 ns |  7.063 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.346 ns | 0.0203 ns | 0.0180 ns | 12.346 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.727 ns | 0.0243 ns | 0.0227 ns | 10.734 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 17.048 ns | 0.0385 ns | 0.0360 ns | 17.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.006 ns | 0.0558 ns | 0.0495 ns | 16.026 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 16.898 ns | 0.0716 ns | 0.0669 ns | 16.864 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.052 ns | 0.0354 ns | 0.0331 ns | 19.057 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.006 ns | 0.0254 ns | 0.0225 ns | 19.007 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.010 ns | 0.0848 ns | 0.0793 ns | 11.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.567 ns | 0.0122 ns | 0.0108 ns | 10.563 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.280 ns | 0.0215 ns | 0.0201 ns |  7.276 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 11.956 ns | 0.0116 ns | 0.0103 ns | 11.959 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.763 ns | 0.0078 ns | 0.0069 ns | 11.765 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.818 ns | 0.0194 ns | 0.0172 ns | 16.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.917 ns | 0.0155 ns | 0.0145 ns | 15.917 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.573 ns | 0.3555 ns | 0.3492 ns | 16.293 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.038 ns | 0.0320 ns | 0.0300 ns | 19.036 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.926 ns | 0.0850 ns | 0.0795 ns | 18.926 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.788 ns | 0.0160 ns | 0.0142 ns | 11.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.474 ns | 0.0111 ns | 0.0099 ns | 10.471 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.159 ns | 0.0102 ns | 0.0090 ns |  7.159 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.733 ns | 0.0136 ns | 0.0113 ns | 12.731 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.161 ns | 0.0131 ns | 0.0123 ns | 10.163 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.045 ns | 0.0358 ns | 0.0299 ns | 14.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.469 ns | 0.0127 ns | 0.0113 ns | 13.470 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.219 ns | 0.0188 ns | 0.0157 ns | 11.222 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.031 ns | 0.0490 ns | 0.0459 ns | 13.014 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.084 ns | 0.0107 ns | 0.0089 ns | 13.083 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.811 ns | 0.0162 ns | 0.0126 ns | 11.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.433 ns | 0.0136 ns | 0.0127 ns | 11.432 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.105 ns | 0.0586 ns | 0.0548 ns |  7.089 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.618 ns | 0.0110 ns | 0.0092 ns | 10.618 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.671 ns | 0.0273 ns | 0.0255 ns | 10.679 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 17.032 ns | 0.0239 ns | 0.0212 ns | 17.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.755 ns | 0.0702 ns | 0.0656 ns | 16.783 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 14.784 ns | 0.0365 ns | 0.0305 ns | 14.778 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.725 ns | 0.0328 ns | 0.0274 ns | 18.729 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.726 ns | 0.0231 ns | 0.0216 ns | 18.732 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.085 ns | 0.0671 ns | 0.0628 ns | 12.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.564 ns | 0.0109 ns | 0.0102 ns | 10.562 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.302 ns | 0.0096 ns | 0.0085 ns |  7.302 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.925 ns | 0.0143 ns | 0.0127 ns | 12.923 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 11.732 ns | 0.0096 ns | 0.0085 ns | 11.730 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.892 ns | 0.0764 ns | 0.0715 ns | 18.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.541 ns | 0.1203 ns | 0.1125 ns | 17.591 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.391 ns | 0.0273 ns | 0.0255 ns | 16.383 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 20.223 ns | 0.0276 ns | 0.0258 ns | 20.232 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.670 ns | 0.0946 ns | 0.0885 ns | 18.661 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.786 ns | 0.0193 ns | 0.0171 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.471 ns | 0.0374 ns | 0.0331 ns | 10.477 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.078 ns | 0.0144 ns | 0.0128 ns |  7.076 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.873 ns | 0.0200 ns | 0.0187 ns | 11.864 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.190 ns | 0.0094 ns | 0.0083 ns | 10.191 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.033 ns | 0.0088 ns | 0.0073 ns | 14.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.700 ns | 0.0471 ns | 0.0440 ns | 12.704 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.285 ns | 0.3110 ns | 0.3193 ns | 14.500 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.879 ns | 0.0168 ns | 0.0149 ns | 14.881 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.354 ns | 0.0372 ns | 0.0348 ns | 13.352 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.314 ns | 0.0194 ns | 0.0182 ns | 12.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.696 ns | 0.0132 ns | 0.0117 ns | 10.699 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.468 ns | 0.1792 ns | 0.1589 ns |  8.484 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.920 ns | 0.0666 ns | 0.0590 ns | 10.914 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.858 ns | 0.0115 ns | 0.0107 ns | 10.858 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.385 ns | 0.1427 ns | 0.1335 ns | 19.460 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.968 ns | 0.0482 ns | 0.0451 ns | 16.980 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.486 ns | 0.0246 ns | 0.0230 ns | 15.484 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.531 ns | 0.0317 ns | 0.0281 ns | 18.530 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.507 ns | 0.0180 ns | 0.0168 ns | 18.509 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.608 ns | 0.0094 ns | 0.0084 ns | 13.610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.626 ns | 0.0727 ns | 0.0680 ns | 12.592 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.436 ns | 0.0992 ns | 0.0928 ns | 10.469 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.948 ns | 0.0220 ns | 0.0205 ns | 13.951 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.715 ns | 0.0177 ns | 0.0166 ns | 13.715 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.460 ns | 0.0314 ns | 0.0294 ns | 19.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.401 ns | 0.0162 ns | 0.0151 ns | 16.401 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.692 ns | 0.0562 ns | 0.0525 ns | 16.694 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.713 ns | 0.0208 ns | 0.0195 ns | 18.714 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.698 ns | 0.0179 ns | 0.0168 ns | 18.699 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.607 ns | 0.0526 ns | 0.0466 ns | 12.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.777 ns | 0.0215 ns | 0.0190 ns | 12.778 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.702 ns | 0.0117 ns | 0.0103 ns |  8.704 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.674 ns | 0.0104 ns | 0.0092 ns | 12.676 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.523 ns | 0.0050 ns | 0.0045 ns | 12.524 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.124 ns | 0.0121 ns | 0.0101 ns | 13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.584 ns | 0.0388 ns | 0.0363 ns | 13.590 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.292 ns | 0.0143 ns | 0.0134 ns | 11.292 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.267 ns | 0.0178 ns | 0.0158 ns | 13.266 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.861 ns | 0.0209 ns | 0.0174 ns | 13.861 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.764 ns | 0.0143 ns | 0.0134 ns | 11.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.415 ns | 0.0129 ns | 0.0114 ns | 10.418 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.062 ns | 0.0121 ns | 0.0113 ns |  7.061 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.665 ns | 0.0136 ns | 0.0127 ns | 10.669 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.705 ns | 0.0178 ns | 0.0167 ns | 10.702 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 16.962 ns | 0.0238 ns | 0.0223 ns | 16.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.909 ns | 0.0170 ns | 0.0159 ns | 15.907 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.649 ns | 0.3519 ns | 0.3456 ns | 16.645 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 20.432 ns | 0.0194 ns | 0.0172 ns | 20.431 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 19.128 ns | 0.1610 ns | 0.1427 ns | 19.072 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.929 ns | 0.0062 ns | 0.0048 ns | 11.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.698 ns | 0.0387 ns | 0.0343 ns | 10.705 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.332 ns | 0.0180 ns | 0.0150 ns |  7.335 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.044 ns | 0.0497 ns | 0.0441 ns | 13.053 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.031 ns | 0.2317 ns | 0.2054 ns | 12.087 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.563 ns | 0.0259 ns | 0.0230 ns | 18.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.801 ns | 0.0236 ns | 0.0221 ns | 15.802 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.398 ns | 0.1742 ns | 0.1630 ns | 15.301 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.757 ns | 0.0223 ns | 0.0209 ns | 18.750 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.757 ns | 0.0217 ns | 0.0203 ns | 18.755 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.354 ns | 0.0728 ns | 0.0681 ns | 12.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.381 ns | 0.0133 ns | 0.0118 ns | 10.381 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.013 ns | 0.1520 ns | 0.1422 ns |  6.910 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.853 ns | 0.0118 ns | 0.0105 ns | 11.852 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.174 ns | 0.0130 ns | 0.0122 ns | 10.173 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.127 ns | 0.0114 ns | 0.0101 ns | 13.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.511 ns | 0.0164 ns | 0.0145 ns | 13.513 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.091 ns | 0.0783 ns | 0.0733 ns | 12.097 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.120 ns | 0.0152 ns | 0.0142 ns | 13.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.105 ns | 0.0205 ns | 0.0191 ns | 13.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.387 ns | 0.0210 ns | 0.0186 ns | 12.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.222 ns | 0.0158 ns | 0.0132 ns | 11.225 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  8.650 ns | 0.0134 ns | 0.0125 ns |  8.651 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.260 ns | 0.0174 ns | 0.0154 ns | 12.257 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 12.178 ns | 0.0162 ns | 0.0152 ns | 12.179 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.435 ns | 0.0509 ns | 0.0476 ns | 19.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.115 ns | 0.0766 ns | 0.0717 ns | 17.130 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.647 ns | 0.1053 ns | 0.0985 ns | 17.684 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.438 ns | 0.0291 ns | 0.0258 ns | 21.431 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 20.152 ns | 0.0322 ns | 0.0302 ns | 20.151 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.069 ns | 0.2189 ns | 0.2048 ns | 12.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.933 ns | 0.0185 ns | 0.0154 ns | 11.933 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.734 ns | 0.1533 ns | 0.1434 ns |  9.661 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 12.544 ns | 0.0082 ns | 0.0064 ns | 12.542 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.193 ns | 0.0169 ns | 0.0158 ns | 12.190 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.526 ns | 0.0229 ns | 0.0203 ns | 17.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.836 ns | 0.0479 ns | 0.0448 ns | 17.853 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.817 ns | 0.4226 ns | 0.6823 ns | 20.226 ns |  1.10 |    0.04 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.061 ns | 0.0366 ns | 0.0343 ns | 20.062 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 20.185 ns | 0.0331 ns | 0.0309 ns | 20.175 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.710 ns | 0.0200 ns | 0.0187 ns | 11.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.387 ns | 0.0122 ns | 0.0114 ns | 10.388 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.047 ns | 0.0595 ns | 0.0557 ns |  7.077 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.119 ns | 0.0147 ns | 0.0123 ns | 12.121 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.324 ns | 0.0089 ns | 0.0079 ns | 10.325 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.165 ns | 0.0119 ns | 0.0093 ns | 13.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.665 ns | 0.0063 ns | 0.0053 ns | 12.667 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.990 ns | 0.0583 ns | 0.0545 ns | 11.999 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.045 ns | 0.0180 ns | 0.0168 ns | 13.048 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.690 ns | 0.0122 ns | 0.0114 ns | 13.688 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.911 ns | 0.1627 ns | 0.1442 ns | 58.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.877 ns | 0.1600 ns | 0.1418 ns | 50.905 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.504 ns | 0.0482 ns | 0.0376 ns | 20.505 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 56.456 ns | 0.0822 ns | 0.0687 ns | 56.475 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 56.184 ns | 0.0826 ns | 0.0773 ns | 56.204 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 61.124 ns | 0.3517 ns | 0.3290 ns | 61.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.897 ns | 0.0503 ns | 0.0471 ns | 58.883 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.824 ns | 0.4448 ns | 0.4160 ns | 26.710 ns |  0.44 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 62.465 ns | 0.1218 ns | 0.1080 ns | 62.469 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 62.395 ns | 0.0875 ns | 0.0776 ns | 62.419 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.317 ns | 0.0164 ns | 0.0153 ns | 12.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.917 ns | 0.0144 ns | 0.0120 ns | 12.918 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.545 ns | 0.0110 ns | 0.0103 ns | 11.544 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.190 ns | 0.0623 ns | 0.0583 ns | 14.161 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 11.187 ns | 0.0146 ns | 0.0137 ns | 11.185 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.911 ns | 0.0137 ns | 0.0114 ns | 13.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.662 ns | 0.0161 ns | 0.0143 ns | 12.659 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.079 ns | 0.1693 ns | 0.1583 ns | 13.981 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.131 ns | 0.0149 ns | 0.0139 ns | 13.131 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.852 ns | 0.0211 ns | 0.0187 ns | 13.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.671 ns | 0.0148 ns | 0.0139 ns | 12.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.787 ns | 0.0212 ns | 0.0198 ns | 12.785 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.724 ns | 0.1069 ns | 0.1000 ns | 11.774 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.902 ns | 0.0146 ns | 0.0129 ns | 12.901 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.721 ns | 0.0588 ns | 0.0550 ns | 12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.766 ns | 0.0345 ns | 0.0323 ns | 11.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.307 ns | 0.0146 ns | 0.0137 ns | 10.307 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.644 ns | 0.0387 ns | 0.0362 ns |  6.657 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.222 ns | 0.0147 ns | 0.0130 ns | 10.222 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.248 ns | 0.0079 ns | 0.0070 ns | 10.249 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 16.621 ns | 0.0235 ns | 0.0208 ns | 16.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 16.154 ns | 0.0377 ns | 0.0352 ns | 16.168 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.003 ns | 0.0461 ns | 0.0385 ns | 15.005 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 17.990 ns | 0.0239 ns | 0.0212 ns | 17.984 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.045 ns | 0.0309 ns | 0.0289 ns | 18.053 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.898 ns | 0.0425 ns | 0.0397 ns | 11.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.854 ns | 0.0119 ns | 0.0105 ns | 10.854 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.136 ns | 0.0803 ns | 0.0751 ns |  7.189 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 10.672 ns | 0.0588 ns | 0.0550 ns | 10.648 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.523 ns | 0.0636 ns | 0.0595 ns | 10.489 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.751 ns | 0.0242 ns | 0.0226 ns | 16.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.451 ns | 0.0162 ns | 0.0151 ns | 15.448 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.532 ns | 0.3197 ns | 0.3283 ns | 15.633 ns |  0.93 |    0.02 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.256 ns | 0.0209 ns | 0.0196 ns | 18.256 ns |  1.09 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 19.914 ns | 0.0610 ns | 0.0510 ns | 19.899 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.701 ns | 0.0174 ns | 0.0154 ns | 11.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.334 ns | 0.0116 ns | 0.0109 ns | 10.335 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.911 ns | 0.0436 ns | 0.0408 ns |  6.892 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.382 ns | 0.0134 ns | 0.0126 ns | 10.385 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.186 ns | 0.0117 ns | 0.0104 ns | 10.183 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.877 ns | 0.0203 ns | 0.0159 ns | 16.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.188 ns | 0.0135 ns | 0.0119 ns | 13.186 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.727 ns | 0.0216 ns | 0.0202 ns | 13.727 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.030 ns | 0.0907 ns | 0.0848 ns | 15.075 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.170 ns | 0.0160 ns | 0.0150 ns | 13.169 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.442 ns | 0.0122 ns | 0.0101 ns | 12.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.864 ns | 0.0127 ns | 0.0119 ns | 10.861 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.196 ns | 0.0319 ns | 0.0298 ns |  7.210 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.286 ns | 0.0185 ns | 0.0173 ns | 10.284 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.658 ns | 0.0087 ns | 0.0077 ns | 10.658 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 14.610 ns | 0.0281 ns | 0.0263 ns | 14.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 13.209 ns | 0.0103 ns | 0.0086 ns | 13.210 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 11.697 ns | 0.0365 ns | 0.0342 ns | 11.704 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 14.010 ns | 0.0274 ns | 0.0256 ns | 14.009 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 13.994 ns | 0.0410 ns | 0.0384 ns | 13.986 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.852 ns | 0.0191 ns | 0.0169 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.791 ns | 0.0201 ns | 0.0188 ns | 10.786 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.811 ns | 0.0221 ns | 0.0207 ns |  6.811 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 10.685 ns | 0.0590 ns | 0.0552 ns | 10.702 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.588 ns | 0.0106 ns | 0.0099 ns | 10.587 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.593 ns | 0.0180 ns | 0.0160 ns | 14.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.371 ns | 0.0807 ns | 0.0755 ns | 14.388 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.763 ns | 0.1707 ns | 0.1597 ns | 12.845 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 13.953 ns | 0.0233 ns | 0.0206 ns | 13.953 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 13.862 ns | 0.0302 ns | 0.0283 ns | 13.863 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.650 ns | 0.0177 ns | 0.0157 ns | 11.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.355 ns | 0.0128 ns | 0.0120 ns | 10.351 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.064 ns | 0.0096 ns | 0.0085 ns |  7.063 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.882 ns | 0.0096 ns | 0.0090 ns | 10.878 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.285 ns | 0.0206 ns | 0.0193 ns | 10.288 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.053 ns | 0.0134 ns | 0.0119 ns | 14.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.516 ns | 0.0158 ns | 0.0148 ns | 13.520 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.757 ns | 0.0250 ns | 0.0234 ns | 13.744 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.103 ns | 0.0490 ns | 0.0458 ns | 13.114 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.430 ns | 0.0158 ns | 0.0147 ns | 13.428 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.766 ns | 0.0082 ns | 0.0077 ns | 11.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.490 ns | 0.0477 ns | 0.0447 ns | 10.515 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.890 ns | 0.1612 ns | 0.1655 ns |  6.974 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.595 ns | 0.0151 ns | 0.0141 ns | 10.595 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.751 ns | 0.0100 ns | 0.0093 ns | 10.750 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.752 ns | 0.0346 ns | 0.0306 ns | 18.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.305 ns | 0.0206 ns | 0.0172 ns | 16.308 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.110 ns | 0.1265 ns | 0.1183 ns | 15.045 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 18.862 ns | 0.0549 ns | 0.0513 ns | 18.861 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.765 ns | 0.0659 ns | 0.0617 ns | 18.760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.832 ns | 0.0450 ns | 0.0421 ns | 12.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.428 ns | 0.0091 ns | 0.0085 ns | 11.431 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.601 ns | 0.0384 ns | 0.0359 ns |  8.594 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.851 ns | 0.1208 ns | 0.1130 ns | 13.800 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.694 ns | 0.0089 ns | 0.0083 ns | 13.692 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.535 ns | 0.0257 ns | 0.0215 ns | 18.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.620 ns | 0.1056 ns | 0.0988 ns | 16.664 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.315 ns | 0.0689 ns | 0.0611 ns | 15.286 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.199 ns | 0.0213 ns | 0.0200 ns | 20.198 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.756 ns | 0.0182 ns | 0.0170 ns | 18.758 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.440 ns | 0.0411 ns | 0.0385 ns | 12.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.367 ns | 0.0134 ns | 0.0118 ns | 11.368 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.262 ns | 0.0557 ns | 0.0521 ns |  8.254 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.863 ns | 0.0125 ns | 0.0111 ns | 12.863 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.604 ns | 0.0387 ns | 0.0362 ns | 12.614 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.478 ns | 0.0944 ns | 0.0883 ns | 15.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.507 ns | 0.0109 ns | 0.0102 ns | 13.508 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.202 ns | 0.0084 ns | 0.0079 ns | 11.202 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 15.083 ns | 0.0754 ns | 0.0705 ns | 15.107 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.390 ns | 0.0261 ns | 0.0218 ns | 13.385 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.066 ns | 0.0111 ns | 0.0093 ns | 14.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.587 ns | 0.0555 ns | 0.0519 ns | 13.601 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.472 ns | 0.1088 ns | 0.1018 ns | 11.486 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.031 ns | 0.0108 ns | 0.0096 ns | 13.031 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.665 ns | 0.0273 ns | 0.0255 ns | 15.678 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.722 ns | 0.0177 ns | 0.0165 ns | 10.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.594 ns | 0.2136 ns | 0.2193 ns |  9.569 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.005 ns | 0.0584 ns | 0.0546 ns | 11.024 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.072 ns | 0.0361 ns | 0.0320 ns | 11.068 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.040 ns | 0.0456 ns | 0.0404 ns | 11.048 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.561 ns | 0.0480 ns | 0.0449 ns | 13.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.673 ns | 0.0158 ns | 0.0147 ns | 12.669 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.004 ns | 0.0135 ns | 0.0119 ns | 12.001 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.954 ns | 0.0248 ns | 0.0232 ns | 14.948 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.802 ns | 0.0183 ns | 0.0171 ns | 13.800 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.119 ns | 0.0187 ns | 0.0166 ns | 16.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.301 ns | 0.0672 ns | 0.0596 ns | 14.311 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.034 ns | 0.0631 ns | 0.0590 ns | 13.007 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.745 ns | 0.0879 ns | 0.0734 ns | 18.772 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.855 ns | 0.0463 ns | 0.0434 ns | 16.859 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.201 ns | 0.0211 ns | 0.0197 ns | 17.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.347 ns | 0.0181 ns | 0.0169 ns | 15.350 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.671 ns | 0.2294 ns | 0.2146 ns | 14.645 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.856 ns | 0.0468 ns | 0.0438 ns | 16.861 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.329 ns | 0.0219 ns | 0.0205 ns | 17.334 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.006 ns | 0.0678 ns | 0.0601 ns | 15.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.375 ns | 0.0101 ns | 0.0094 ns | 12.375 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.060 ns | 0.0175 ns | 0.0164 ns | 11.056 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.161 ns | 0.0239 ns | 0.0200 ns | 13.158 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.034 ns | 0.0260 ns | 0.0217 ns | 13.034 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.390 ns | 0.0147 ns | 0.0138 ns | 14.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.366 ns | 0.0114 ns | 0.0101 ns | 14.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.588 ns | 0.3141 ns | 0.5419 ns | 14.868 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.272 ns | 0.0586 ns | 0.0549 ns | 14.289 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.761 ns | 0.0555 ns | 0.0519 ns | 13.766 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.718 ns | 0.0148 ns | 0.0132 ns | 12.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.358 ns | 0.0193 ns | 0.0180 ns | 10.352 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.590 ns | 0.0194 ns | 0.0172 ns | 10.589 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.337 ns | 0.0315 ns | 0.0294 ns | 12.330 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.262 ns | 0.0303 ns | 0.0283 ns | 12.251 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.863 ns | 0.0311 ns | 0.0275 ns | 15.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.058 ns | 0.0160 ns | 0.0142 ns | 14.054 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.881 ns | 0.2676 ns | 0.2503 ns | 13.957 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.538 ns | 0.0135 ns | 0.0120 ns | 16.537 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 14.978 ns | 0.0136 ns | 0.0114 ns | 14.983 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.913 ns | 0.0148 ns | 0.0116 ns | 12.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.367 ns | 0.0116 ns | 0.0103 ns | 10.369 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.771 ns | 0.0473 ns | 0.0419 ns | 10.766 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.097 ns | 0.0189 ns | 0.0176 ns | 14.096 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.444 ns | 0.0156 ns | 0.0146 ns | 12.445 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.130 ns | 0.0132 ns | 0.0103 ns | 13.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.513 ns | 0.0122 ns | 0.0108 ns | 13.514 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.355 ns | 0.0274 ns | 0.0214 ns | 11.356 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.042 ns | 0.0184 ns | 0.0173 ns | 13.044 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.213 ns | 0.0093 ns | 0.0087 ns | 14.214 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.808 ns | 0.0432 ns | 0.0404 ns | 18.812 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.316 ns | 0.0255 ns | 0.0238 ns | 16.314 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.720 ns | 0.2483 ns | 0.2956 ns | 11.884 ns |  0.62 |    0.02 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 17.479 ns | 0.0169 ns | 0.0158 ns | 17.479 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.532 ns | 0.0561 ns | 0.0524 ns | 16.542 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.744 ns | 0.0270 ns | 0.0239 ns | 17.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.355 ns | 0.0339 ns | 0.0300 ns | 16.351 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.349 ns | 0.0999 ns | 0.0935 ns | 16.401 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 18.537 ns | 0.0253 ns | 0.0237 ns | 18.525 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.808 ns | 0.0269 ns | 0.0238 ns | 17.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.376 ns | 0.0640 ns | 0.0598 ns | 19.351 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.921 ns | 0.0278 ns | 0.0260 ns | 15.925 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.209 ns | 0.1236 ns | 0.1157 ns | 12.256 ns |  0.63 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.206 ns | 0.0261 ns | 0.0231 ns | 17.209 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 16.875 ns | 0.0449 ns | 0.0420 ns | 16.877 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.269 ns | 0.0440 ns | 0.0390 ns | 17.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.291 ns | 0.0163 ns | 0.0144 ns | 15.288 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.316 ns | 0.0236 ns | 0.0220 ns | 15.310 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.511 ns | 0.0259 ns | 0.0243 ns | 17.508 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.806 ns | 0.0387 ns | 0.0362 ns | 17.806 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.190 ns | 0.0188 ns | 0.0167 ns | 13.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.000 ns | 0.0131 ns | 0.0122 ns | 12.001 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.126 ns | 0.0443 ns | 0.0392 ns |  7.143 ns |  0.54 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.181 ns | 0.0123 ns | 0.0103 ns | 12.181 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.368 ns | 0.0092 ns | 0.0086 ns | 10.368 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.016 ns | 0.0132 ns | 0.0117 ns | 13.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.112 ns | 0.0114 ns | 0.0107 ns | 14.112 ns |  1.08 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.217 ns | 0.0102 ns | 0.0085 ns | 11.216 ns |  0.86 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.113 ns | 0.0351 ns | 0.0293 ns | 13.123 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.088 ns | 0.0173 ns | 0.0162 ns | 13.088 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.037 ns | 0.0137 ns | 0.0129 ns | 13.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.751 ns | 0.0162 ns | 0.0135 ns | 10.751 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.734 ns | 0.1551 ns | 0.1593 ns |  6.644 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.313 ns | 0.0118 ns | 0.0104 ns | 10.315 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.410 ns | 0.0131 ns | 0.0122 ns | 11.412 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.234 ns | 0.0203 ns | 0.0180 ns | 14.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.953 ns | 0.0430 ns | 0.0381 ns | 14.958 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.258 ns | 0.1598 ns | 0.1495 ns | 15.331 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.338 ns | 0.0362 ns | 0.0321 ns | 15.332 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.837 ns | 0.0182 ns | 0.0161 ns | 14.837 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.047 ns | 0.0325 ns | 0.0271 ns | 13.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.830 ns | 0.0124 ns | 0.0110 ns | 10.830 ns |  0.83 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.403 ns | 0.0086 ns | 0.0080 ns |  6.402 ns |  0.49 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.337 ns | 0.0297 ns | 0.0278 ns | 10.338 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.393 ns | 0.0310 ns | 0.0290 ns | 11.404 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.009 ns | 0.0724 ns | 0.0678 ns | 15.997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.227 ns | 0.0092 ns | 0.0077 ns | 16.226 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.563 ns | 0.2125 ns | 0.1988 ns | 13.545 ns |  0.85 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.861 ns | 0.0151 ns | 0.0134 ns | 15.860 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 14.887 ns | 0.0248 ns | 0.0232 ns | 14.877 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.992 ns | 0.0159 ns | 0.0149 ns | 12.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.716 ns | 0.0138 ns | 0.0129 ns | 10.714 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.720 ns | 0.0086 ns | 0.0076 ns |  6.720 ns |  0.52 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.898 ns | 0.0143 ns | 0.0134 ns | 11.901 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.426 ns | 0.0262 ns | 0.0245 ns | 11.434 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.172 ns | 0.0276 ns | 0.0245 ns | 13.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.724 ns | 0.0129 ns | 0.0121 ns | 12.727 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.007 ns | 0.0140 ns | 0.0124 ns | 12.005 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.045 ns | 0.0284 ns | 0.0266 ns | 13.050 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.155 ns | 0.0090 ns | 0.0084 ns | 14.158 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.755 ns | 0.0207 ns | 0.0173 ns | 11.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.387 ns | 0.0173 ns | 0.0162 ns | 10.390 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.447 ns | 0.1739 ns | 0.3391 ns |  7.568 ns |  0.60 |    0.04 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.229 ns | 0.0154 ns | 0.0129 ns | 12.226 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.629 ns | 0.0102 ns | 0.0095 ns | 10.631 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.915 ns | 0.0662 ns | 0.0619 ns | 49.939 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 39.634 ns | 0.0586 ns | 0.0520 ns | 39.630 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.116 ns | 0.0620 ns | 0.0517 ns | 39.110 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 45.303 ns | 0.3310 ns | 0.3096 ns | 45.439 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 42.875 ns | 0.1478 ns | 0.1382 ns | 42.833 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.240 ns | 0.0139 ns | 0.0130 ns | 12.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.509 ns | 0.0229 ns | 0.0214 ns | 12.511 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.812 ns | 0.0287 ns | 0.0269 ns |  6.824 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.072 ns | 0.0462 ns | 0.0432 ns | 12.053 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 11.867 ns | 0.0112 ns | 0.0099 ns | 11.865 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.147 ns | 0.0907 ns | 0.0757 ns | 44.118 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.983 ns | 0.5014 ns | 0.4444 ns | 42.783 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 35.102 ns | 0.1549 ns | 0.1449 ns | 35.034 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.894 ns | 0.3046 ns | 0.2543 ns | 42.997 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.687 ns | 0.0967 ns | 0.0858 ns | 44.674 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 11.777 ns | 0.0098 ns | 0.0082 ns | 11.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.848 ns | 0.0583 ns | 0.0545 ns | 10.838 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.134 ns | 0.0310 ns | 0.0259 ns |  7.137 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.378 ns | 0.0198 ns | 0.0186 ns | 10.383 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.266 ns | 0.0178 ns | 0.0167 ns | 10.272 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.221 ns | 0.0166 ns | 0.0139 ns | 14.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.314 ns | 0.0108 ns | 0.0096 ns | 14.314 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.938 ns | 0.0245 ns | 0.0229 ns | 11.932 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 16.635 ns | 0.0359 ns | 0.0318 ns | 16.644 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.708 ns | 0.0186 ns | 0.0174 ns | 13.706 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.769 ns | 0.0125 ns | 0.0117 ns | 12.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.348 ns | 0.0186 ns | 0.0174 ns | 10.351 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.813 ns | 0.0766 ns | 0.0716 ns | 10.832 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.422 ns | 0.0537 ns | 0.0502 ns | 12.403 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.920 ns | 0.0184 ns | 0.0172 ns | 12.918 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.434 ns | 0.0176 ns | 0.0147 ns | 15.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.260 ns | 0.0639 ns | 0.0566 ns | 15.244 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.196 ns | 0.0210 ns | 0.0176 ns | 13.200 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 16.823 ns | 0.0283 ns | 0.0265 ns | 16.825 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.630 ns | 0.0175 ns | 0.0137 ns | 15.629 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.830 ns | 0.0804 ns | 0.0752 ns | 12.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.344 ns | 0.0148 ns | 0.0139 ns | 10.346 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.783 ns | 0.0644 ns | 0.0602 ns | 10.808 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.356 ns | 0.0184 ns | 0.0144 ns | 12.355 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.286 ns | 0.0264 ns | 0.0247 ns | 12.294 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.746 ns | 0.0130 ns | 0.0115 ns | 13.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.655 ns | 0.0379 ns | 0.0336 ns | 12.643 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.964 ns | 0.0531 ns | 0.0497 ns | 11.946 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.131 ns | 0.0122 ns | 0.0108 ns | 13.134 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.085 ns | 0.0173 ns | 0.0162 ns | 13.088 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.481 ns | 0.0540 ns | 0.0451 ns | 39.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.496 ns | 0.0229 ns | 0.0191 ns | 36.501 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.846 ns | 0.1581 ns | 0.1479 ns | 36.775 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.174 ns | 0.0400 ns | 0.0334 ns | 40.165 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.097 ns | 0.1262 ns | 0.1118 ns | 38.129 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.537 ns | 0.1371 ns | 0.1283 ns | 15.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.333 ns | 0.0114 ns | 0.0107 ns | 14.332 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.872 ns | 0.3421 ns | 0.4906 ns | 16.238 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.170 ns | 0.0326 ns | 0.0305 ns | 15.167 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.171 ns | 0.0588 ns | 0.0521 ns | 15.175 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.027 ns | 0.0388 ns | 0.0344 ns | 39.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.165 ns | 0.0764 ns | 0.0715 ns | 39.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.072 ns | 0.1590 ns | 0.1488 ns | 34.058 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 42.962 ns | 0.1591 ns | 0.1488 ns | 42.904 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 53.474 ns | 0.0393 ns | 0.0349 ns | 53.469 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.558 ns | 0.0121 ns | 0.0094 ns | 14.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.316 ns | 0.0144 ns | 0.0135 ns | 14.316 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.108 ns | 0.3014 ns | 0.4225 ns | 14.302 ns |  0.95 |    0.04 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.266 ns | 0.1058 ns | 0.0989 ns | 15.238 ns |  1.05 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.381 ns | 0.0229 ns | 0.0214 ns | 15.376 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.456 ns | 0.0741 ns | 0.0618 ns | 39.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.385 ns | 0.0554 ns | 0.0491 ns | 37.375 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.021 ns | 0.0443 ns | 0.0393 ns | 35.019 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.459 ns | 0.4455 ns | 0.3949 ns | 38.312 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 41.578 ns | 0.0831 ns | 0.0737 ns | 41.576 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.065 ns | 0.0090 ns | 0.0084 ns | 14.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.838 ns | 0.0561 ns | 0.0498 ns | 12.853 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.485 ns | 0.3114 ns | 0.4564 ns | 14.795 ns |  1.01 |    0.03 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.236 ns | 0.0326 ns | 0.0305 ns | 13.237 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.099 ns | 0.0263 ns | 0.0246 ns | 13.106 ns |  0.93 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UInt.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UInt.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
