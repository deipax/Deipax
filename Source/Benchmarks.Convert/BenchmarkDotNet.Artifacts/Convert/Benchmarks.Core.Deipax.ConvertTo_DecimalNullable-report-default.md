
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
                                             From_Bool | .NET Core 2.0 | 21.365 ns | 0.0283 ns | 0.0236 ns | 21.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 19.200 ns | 0.0467 ns | 0.0414 ns | 19.199 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 16.095 ns | 0.0310 ns | 0.0275 ns | 16.093 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 20.485 ns | 0.0291 ns | 0.0243 ns | 20.480 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 19.765 ns | 0.0344 ns | 0.0322 ns | 19.764 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 27.433 ns | 0.0870 ns | 0.0813 ns | 27.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 25.707 ns | 0.0252 ns | 0.0223 ns | 25.702 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 24.447 ns | 0.0556 ns | 0.0434 ns | 24.454 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.630 ns | 0.1401 ns | 0.1310 ns | 27.657 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 27.167 ns | 0.0429 ns | 0.0358 ns | 27.180 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 21.649 ns | 0.1293 ns | 0.1210 ns | 21.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 17.943 ns | 0.0360 ns | 0.0319 ns | 17.948 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 17.100 ns | 0.1474 ns | 0.1379 ns | 17.070 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 20.930 ns | 0.0215 ns | 0.0168 ns | 20.935 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 20.519 ns | 0.0632 ns | 0.0591 ns | 20.535 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.171 ns | 0.0303 ns | 0.0236 ns | 27.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.336 ns | 0.1078 ns | 0.1008 ns | 25.307 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.557 ns | 0.1437 ns | 0.1344 ns | 24.523 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 27.455 ns | 0.0282 ns | 0.0235 ns | 27.447 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.553 ns | 0.1401 ns | 0.1242 ns | 27.600 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 14.168 ns | 0.0356 ns | 0.0333 ns | 14.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.882 ns | 0.0693 ns | 0.0615 ns | 10.902 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.305 ns | 0.0386 ns | 0.0361 ns |  7.301 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.303 ns | 0.0285 ns | 0.0267 ns | 13.299 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.035 ns | 0.0284 ns | 0.0266 ns | 13.030 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.366 ns | 0.0268 ns | 0.0224 ns | 15.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.771 ns | 0.0320 ns | 0.0299 ns | 13.771 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.732 ns | 0.0284 ns | 0.0265 ns | 14.732 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.800 ns | 0.0116 ns | 0.0102 ns | 14.801 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.069 ns | 0.0287 ns | 0.0269 ns | 15.066 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 21.413 ns | 0.0765 ns | 0.0638 ns | 21.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 17.675 ns | 0.0172 ns | 0.0144 ns | 17.679 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 16.070 ns | 0.0256 ns | 0.0239 ns | 16.075 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 19.544 ns | 0.0339 ns | 0.0317 ns | 19.540 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 20.073 ns | 0.0267 ns | 0.0250 ns | 20.072 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 27.651 ns | 0.2631 ns | 0.2461 ns | 27.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 25.045 ns | 0.0558 ns | 0.0494 ns | 25.045 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 24.700 ns | 0.0443 ns | 0.0370 ns | 24.705 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.860 ns | 0.0440 ns | 0.0368 ns | 27.847 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.156 ns | 0.0370 ns | 0.0346 ns | 27.151 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 21.545 ns | 0.0290 ns | 0.0257 ns | 21.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 17.886 ns | 0.0414 ns | 0.0367 ns | 17.878 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 16.807 ns | 0.0416 ns | 0.0325 ns | 16.812 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 20.065 ns | 0.0598 ns | 0.0530 ns | 20.055 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 20.102 ns | 0.0889 ns | 0.0831 ns | 20.062 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.129 ns | 0.0382 ns | 0.0338 ns | 27.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.674 ns | 0.1450 ns | 0.1356 ns | 25.725 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.700 ns | 0.0522 ns | 0.0463 ns | 24.701 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.920 ns | 0.0412 ns | 0.0365 ns | 27.920 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.162 ns | 0.0510 ns | 0.0477 ns | 27.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.212 ns | 0.1317 ns | 0.1232 ns | 14.280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 12.075 ns | 0.0298 ns | 0.0249 ns | 12.068 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.718 ns | 0.3177 ns | 0.3782 ns |  7.519 ns |  0.55 |    0.03 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.281 ns | 0.0191 ns | 0.0169 ns | 13.280 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.997 ns | 0.0241 ns | 0.0214 ns | 12.997 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.216 ns | 0.0236 ns | 0.0197 ns | 15.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.743 ns | 0.0281 ns | 0.0249 ns | 13.745 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.065 ns | 0.2963 ns | 0.2772 ns | 15.965 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 16.407 ns | 0.0187 ns | 0.0156 ns | 16.408 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.192 ns | 0.0223 ns | 0.0197 ns | 15.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 14.352 ns | 0.0195 ns | 0.0173 ns | 14.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.643 ns | 0.0289 ns | 0.0257 ns | 10.640 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.968 ns | 0.0275 ns | 0.0243 ns |  7.967 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.815 ns | 0.0162 ns | 0.0144 ns | 12.816 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.664 ns | 0.0302 ns | 0.0283 ns | 13.661 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.628 ns | 0.0665 ns | 0.0622 ns | 12.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.683 ns | 0.0188 ns | 0.0167 ns | 10.687 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.653 ns | 0.1708 ns | 0.1827 ns |  7.739 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.112 ns | 0.0124 ns | 0.0110 ns | 13.112 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 14.328 ns | 0.0677 ns | 0.0600 ns | 14.332 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.686 ns | 0.1814 ns | 0.1697 ns | 12.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.186 ns | 0.0164 ns | 0.0146 ns | 11.186 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.226 ns | 0.5919 ns | 0.7902 ns |  8.788 ns |  0.75 |    0.07 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.717 ns | 0.0276 ns | 0.0244 ns | 13.710 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.528 ns | 0.0570 ns | 0.0534 ns | 13.506 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.210 ns | 0.0200 ns | 0.0167 ns | 15.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.728 ns | 0.0181 ns | 0.0170 ns | 13.729 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.120 ns | 0.1268 ns | 0.1186 ns | 15.062 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 16.404 ns | 0.0171 ns | 0.0160 ns | 16.409 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.497 ns | 0.0369 ns | 0.0327 ns | 15.494 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.538 ns | 0.0145 ns | 0.0136 ns | 12.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.454 ns | 0.0203 ns | 0.0190 ns | 11.458 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.401 ns | 0.0206 ns | 0.0193 ns |  8.399 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.249 ns | 0.0221 ns | 0.0207 ns | 14.245 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.763 ns | 0.0176 ns | 0.0147 ns | 13.765 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.958 ns | 0.0243 ns | 0.0203 ns | 12.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.852 ns | 0.0717 ns | 0.0670 ns | 11.841 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.786 ns | 0.0874 ns | 0.0818 ns |  8.830 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.414 ns | 0.0214 ns | 0.0200 ns | 13.408 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.333 ns | 0.0382 ns | 0.0357 ns | 14.330 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.023 ns | 0.1091 ns | 0.1020 ns | 12.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.495 ns | 0.0208 ns | 0.0184 ns | 11.493 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.814 ns | 0.1868 ns | 0.1747 ns |  8.693 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.279 ns | 0.0172 ns | 0.0152 ns | 13.274 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.955 ns | 0.0304 ns | 0.0269 ns | 13.959 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.204 ns | 0.0215 ns | 0.0180 ns | 15.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.730 ns | 0.0360 ns | 0.0320 ns | 13.731 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.549 ns | 0.0251 ns | 0.0234 ns | 13.544 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 17.225 ns | 0.0168 ns | 0.0140 ns | 17.226 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.009 ns | 0.0215 ns | 0.0201 ns | 15.012 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 14.842 ns | 0.1603 ns | 0.1499 ns | 14.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 13.079 ns | 0.0176 ns | 0.0165 ns | 13.080 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.743 ns | 0.1079 ns | 0.1009 ns | 12.699 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 15.416 ns | 0.0199 ns | 0.0177 ns | 15.416 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 14.951 ns | 0.0174 ns | 0.0163 ns | 14.951 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 27.062 ns | 0.1223 ns | 0.1144 ns | 27.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.702 ns | 0.0714 ns | 0.0667 ns | 29.703 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 35.701 ns | 0.1290 ns | 0.1077 ns | 35.693 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 34.136 ns | 0.1572 ns | 0.1227 ns | 34.173 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 34.070 ns | 0.0507 ns | 0.0449 ns | 34.062 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.976 ns | 0.0168 ns | 0.0149 ns | 12.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.992 ns | 0.0563 ns | 0.0527 ns | 11.976 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  8.916 ns | 0.0227 ns | 0.0212 ns |  8.919 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 13.555 ns | 0.0178 ns | 0.0149 ns | 13.554 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.279 ns | 0.0259 ns | 0.0230 ns | 13.279 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.918 ns | 0.0602 ns | 0.0533 ns | 26.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.299 ns | 0.0363 ns | 0.0340 ns | 28.307 ns |  1.05 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 32.616 ns | 0.0751 ns | 0.0627 ns | 32.603 ns |  1.21 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 35.793 ns | 0.0790 ns | 0.0700 ns | 35.787 ns |  1.33 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 33.489 ns | 0.0462 ns | 0.0432 ns | 33.496 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.979 ns | 0.0234 ns | 0.0219 ns | 12.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.685 ns | 0.0159 ns | 0.0149 ns | 11.682 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.294 ns | 0.0203 ns | 0.0170 ns |  8.291 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.327 ns | 0.0609 ns | 0.0540 ns | 14.323 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.912 ns | 0.0306 ns | 0.0255 ns | 14.912 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.225 ns | 0.0262 ns | 0.0245 ns | 15.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.741 ns | 0.0459 ns | 0.0407 ns | 13.729 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.336 ns | 0.2631 ns | 0.2815 ns | 12.227 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 16.529 ns | 0.0447 ns | 0.0418 ns | 16.524 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.192 ns | 0.0589 ns | 0.0551 ns | 15.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 70.344 ns | 0.1094 ns | 0.1023 ns | 70.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 65.985 ns | 0.4567 ns | 0.4272 ns | 65.801 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 21.968 ns | 0.1456 ns | 0.1362 ns | 21.939 ns |  0.31 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 70.585 ns | 0.0799 ns | 0.0747 ns | 70.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 68.172 ns | 0.1004 ns | 0.0890 ns | 68.210 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 77.331 ns | 0.0877 ns | 0.0820 ns | 77.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 78.109 ns | 0.3221 ns | 0.3013 ns | 78.201 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 33.666 ns | 0.0838 ns | 0.0784 ns | 33.662 ns |  0.44 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 77.606 ns | 0.1182 ns | 0.0987 ns | 77.610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 77.499 ns | 0.0668 ns | 0.0558 ns | 77.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 70.148 ns | 0.1193 ns | 0.1116 ns | 70.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 65.694 ns | 0.2683 ns | 0.2378 ns | 65.661 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 22.750 ns | 0.1152 ns | 0.1077 ns | 22.812 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 69.412 ns | 0.1769 ns | 0.1655 ns | 69.363 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 70.664 ns | 0.3987 ns | 0.3534 ns | 70.816 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 77.433 ns | 0.1281 ns | 0.1135 ns | 77.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 75.301 ns | 0.2735 ns | 0.2425 ns | 75.207 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.502 ns | 0.0720 ns | 0.0601 ns | 33.493 ns |  0.43 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 77.828 ns | 0.1465 ns | 0.1370 ns | 77.855 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 77.601 ns | 0.2236 ns | 0.1868 ns | 77.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.328 ns | 0.0630 ns | 0.0559 ns | 14.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.858 ns | 0.0120 ns | 0.0106 ns | 11.860 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.711 ns | 0.2181 ns | 0.4305 ns |  9.857 ns |  0.65 |    0.05 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.362 ns | 0.0170 ns | 0.0159 ns | 13.361 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.203 ns | 0.0213 ns | 0.0177 ns | 13.196 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.881 ns | 0.0253 ns | 0.0237 ns | 15.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.760 ns | 0.0370 ns | 0.0328 ns | 13.750 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.945 ns | 0.4060 ns | 0.7725 ns | 16.507 ns |  1.12 |    0.05 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.385 ns | 0.0249 ns | 0.0208 ns | 15.389 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.520 ns | 0.0374 ns | 0.0312 ns | 16.523 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 21.152 ns | 0.0474 ns | 0.0420 ns | 21.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 17.674 ns | 0.0308 ns | 0.0257 ns | 17.674 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 16.291 ns | 0.2758 ns | 0.2580 ns | 16.134 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 19.552 ns | 0.0225 ns | 0.0210 ns | 19.557 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 19.539 ns | 0.0660 ns | 0.0551 ns | 19.551 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 27.174 ns | 0.0416 ns | 0.0389 ns | 27.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 25.080 ns | 0.0296 ns | 0.0262 ns | 25.087 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 24.253 ns | 0.0672 ns | 0.0628 ns | 24.236 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.548 ns | 0.1818 ns | 0.1701 ns | 27.617 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.164 ns | 0.0356 ns | 0.0298 ns | 27.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 21.637 ns | 0.0216 ns | 0.0202 ns | 21.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 17.907 ns | 0.0860 ns | 0.0718 ns | 17.890 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 16.791 ns | 0.0402 ns | 0.0376 ns | 16.794 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 20.032 ns | 0.0506 ns | 0.0449 ns | 20.019 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 20.508 ns | 0.2006 ns | 0.1876 ns | 20.381 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.440 ns | 0.0657 ns | 0.0614 ns | 27.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.074 ns | 0.0489 ns | 0.0434 ns | 25.064 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.981 ns | 0.1567 ns | 0.1389 ns | 24.919 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.285 ns | 0.0187 ns | 0.0165 ns | 27.284 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.244 ns | 0.1233 ns | 0.1154 ns | 27.196 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 14.667 ns | 0.0184 ns | 0.0172 ns | 14.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.823 ns | 0.0133 ns | 0.0124 ns | 10.821 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  8.505 ns | 0.1169 ns | 0.0976 ns |  8.471 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.504 ns | 0.0292 ns | 0.0273 ns | 13.508 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.954 ns | 0.0128 ns | 0.0114 ns | 12.952 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.225 ns | 0.0288 ns | 0.0240 ns | 15.218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.635 ns | 0.0219 ns | 0.0194 ns | 14.632 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.039 ns | 0.0347 ns | 0.0307 ns | 16.039 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.568 ns | 0.0717 ns | 0.0671 ns | 15.532 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.211 ns | 0.0834 ns | 0.0780 ns | 15.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 21.150 ns | 0.0295 ns | 0.0262 ns | 21.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 17.740 ns | 0.0513 ns | 0.0480 ns | 17.731 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 16.083 ns | 0.0356 ns | 0.0316 ns | 16.091 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 19.778 ns | 0.0238 ns | 0.0222 ns | 19.773 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 19.778 ns | 0.0333 ns | 0.0278 ns | 19.772 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 29.775 ns | 0.1981 ns | 0.1853 ns | 29.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 25.075 ns | 0.0408 ns | 0.0381 ns | 25.084 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 25.008 ns | 0.1584 ns | 0.1404 ns | 24.969 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 28.570 ns | 0.1885 ns | 0.1763 ns | 28.628 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 27.188 ns | 0.0420 ns | 0.0393 ns | 27.189 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 20.259 ns | 0.0400 ns | 0.0334 ns | 20.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 18.123 ns | 0.0391 ns | 0.0366 ns | 18.117 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 16.581 ns | 0.0581 ns | 0.0486 ns | 16.563 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 20.287 ns | 0.0270 ns | 0.0225 ns | 20.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 20.436 ns | 0.1684 ns | 0.1575 ns | 20.526 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.193 ns | 0.0411 ns | 0.0384 ns | 27.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.325 ns | 0.0378 ns | 0.0354 ns | 25.330 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.917 ns | 0.0302 ns | 0.0236 ns | 24.915 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.195 ns | 0.0315 ns | 0.0295 ns | 27.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.182 ns | 0.0580 ns | 0.0485 ns | 27.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.295 ns | 0.0819 ns | 0.0726 ns | 14.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.846 ns | 0.0238 ns | 0.0211 ns | 10.843 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.325 ns | 0.0318 ns | 0.0282 ns |  7.315 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.230 ns | 0.0148 ns | 0.0124 ns | 13.233 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.734 ns | 0.1264 ns | 0.1183 ns | 13.800 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.664 ns | 0.0126 ns | 0.0105 ns | 15.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.650 ns | 0.0239 ns | 0.0200 ns | 14.649 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.569 ns | 0.0546 ns | 0.0484 ns | 13.578 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.699 ns | 0.0280 ns | 0.0249 ns | 14.695 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.032 ns | 0.0204 ns | 0.0171 ns | 15.030 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 21.122 ns | 0.0417 ns | 0.0390 ns | 21.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 17.950 ns | 0.0306 ns | 0.0286 ns | 17.947 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 16.202 ns | 0.1268 ns | 0.1186 ns | 16.262 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 19.808 ns | 0.0229 ns | 0.0203 ns | 19.810 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 19.797 ns | 0.0265 ns | 0.0248 ns | 19.798 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 27.420 ns | 0.0420 ns | 0.0393 ns | 27.419 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 25.609 ns | 0.1335 ns | 0.1183 ns | 25.568 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 25.810 ns | 0.0416 ns | 0.0369 ns | 25.794 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.439 ns | 0.0546 ns | 0.0511 ns | 27.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.765 ns | 0.2011 ns | 0.1881 ns | 27.851 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 21.593 ns | 0.0438 ns | 0.0410 ns | 21.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 18.609 ns | 0.0358 ns | 0.0335 ns | 18.605 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 17.725 ns | 0.0391 ns | 0.0327 ns | 17.710 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 21.161 ns | 0.0404 ns | 0.0338 ns | 21.153 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 21.364 ns | 0.0179 ns | 0.0140 ns | 21.370 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.406 ns | 0.0661 ns | 0.0552 ns | 27.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.298 ns | 0.0288 ns | 0.0269 ns | 25.301 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.209 ns | 0.0207 ns | 0.0193 ns | 27.204 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.628 ns | 0.0345 ns | 0.0288 ns | 27.622 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.675 ns | 0.0696 ns | 0.0651 ns | 27.651 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.906 ns | 0.0461 ns | 0.0385 ns | 14.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.593 ns | 0.0399 ns | 0.0373 ns | 11.583 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.679 ns | 0.0285 ns | 0.0267 ns |  8.692 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 16.115 ns | 0.0301 ns | 0.0282 ns | 16.105 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.430 ns | 0.1518 ns | 0.1420 ns | 13.354 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.383 ns | 0.0292 ns | 0.0259 ns | 14.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.748 ns | 0.0199 ns | 0.0166 ns | 13.748 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.008 ns | 0.0232 ns | 0.0194 ns | 13.002 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.809 ns | 0.0136 ns | 0.0106 ns | 14.808 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.863 ns | 0.0289 ns | 0.0256 ns | 14.856 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 21.389 ns | 0.0303 ns | 0.0284 ns | 21.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 17.679 ns | 0.0292 ns | 0.0243 ns | 17.681 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 16.108 ns | 0.0196 ns | 0.0183 ns | 16.106 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 21.142 ns | 0.0235 ns | 0.0196 ns | 21.148 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 27.346 ns | 0.1688 ns | 0.1579 ns | 27.454 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 28.315 ns | 0.0324 ns | 0.0287 ns | 28.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 25.476 ns | 0.1086 ns | 0.1016 ns | 25.502 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 24.280 ns | 0.1173 ns | 0.1098 ns | 24.227 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.162 ns | 0.0539 ns | 0.0505 ns | 27.148 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.185 ns | 0.0420 ns | 0.0393 ns | 27.200 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 21.621 ns | 0.0390 ns | 0.0326 ns | 21.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 17.944 ns | 0.1277 ns | 0.1132 ns | 17.903 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 16.540 ns | 0.0322 ns | 0.0301 ns | 16.539 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 21.727 ns | 0.0451 ns | 0.0377 ns | 21.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 28.152 ns | 0.0476 ns | 0.0398 ns | 28.150 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.170 ns | 0.0678 ns | 0.0601 ns | 27.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.099 ns | 0.0555 ns | 0.0519 ns | 25.095 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.286 ns | 0.1029 ns | 0.0963 ns | 24.232 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.656 ns | 0.0286 ns | 0.0239 ns | 27.653 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 27.655 ns | 0.1073 ns | 0.1004 ns | 27.622 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.710 ns | 0.0169 ns | 0.0141 ns | 14.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.708 ns | 0.0565 ns | 0.0529 ns | 10.682 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.284 ns | 0.0200 ns | 0.0178 ns |  8.281 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.259 ns | 0.0268 ns | 0.0237 ns | 13.257 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.071 ns | 0.1440 ns | 0.1347 ns | 12.989 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.218 ns | 0.0293 ns | 0.0274 ns | 15.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.091 ns | 0.0584 ns | 0.0546 ns | 14.071 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.961 ns | 0.0644 ns | 0.0602 ns | 14.976 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 16.428 ns | 0.0219 ns | 0.0194 ns | 16.426 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.987 ns | 0.0291 ns | 0.0272 ns | 14.997 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 40.808 ns | 0.0912 ns | 0.0761 ns | 40.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 35.285 ns | 0.0998 ns | 0.0934 ns | 35.291 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 21.063 ns | 0.1839 ns | 0.1720 ns | 21.086 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 38.251 ns | 0.0496 ns | 0.0440 ns | 38.240 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 38.310 ns | 0.0997 ns | 0.0933 ns | 38.288 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 46.445 ns | 0.0831 ns | 0.0737 ns | 46.452 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 44.522 ns | 0.0983 ns | 0.0919 ns | 44.544 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 33.135 ns | 0.1453 ns | 0.1359 ns | 33.162 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 46.273 ns | 0.1390 ns | 0.1232 ns | 46.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 46.786 ns | 0.4194 ns | 0.3923 ns | 46.591 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 39.429 ns | 0.0722 ns | 0.0676 ns | 39.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 34.520 ns | 0.0752 ns | 0.0667 ns | 34.522 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 20.886 ns | 0.1198 ns | 0.1121 ns | 20.943 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 38.319 ns | 0.2475 ns | 0.2315 ns | 38.414 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 37.992 ns | 0.1350 ns | 0.1263 ns | 37.947 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.596 ns | 0.1678 ns | 0.1401 ns | 46.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.728 ns | 0.0536 ns | 0.0501 ns | 44.720 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 30.496 ns | 0.1166 ns | 0.0974 ns | 30.497 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 46.715 ns | 0.2485 ns | 0.2324 ns | 46.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 47.393 ns | 0.6709 ns | 0.6275 ns | 47.055 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.666 ns | 0.0284 ns | 0.0265 ns | 14.668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.974 ns | 0.0312 ns | 0.0291 ns | 10.979 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.618 ns | 0.0347 ns | 0.0325 ns |  7.627 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.405 ns | 0.0176 ns | 0.0164 ns | 14.405 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.576 ns | 0.0338 ns | 0.0316 ns | 13.579 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.407 ns | 0.0260 ns | 0.0231 ns | 14.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.746 ns | 0.0350 ns | 0.0292 ns | 13.746 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.048 ns | 0.0438 ns | 0.0410 ns | 12.034 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 16.456 ns | 0.0503 ns | 0.0470 ns | 16.454 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.028 ns | 0.0392 ns | 0.0347 ns | 15.016 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 86.180 ns | 0.1526 ns | 0.1274 ns | 86.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 80.676 ns | 0.1505 ns | 0.1408 ns | 80.633 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 58.883 ns | 0.1343 ns | 0.1256 ns | 58.838 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 87.571 ns | 0.2601 ns | 0.2306 ns | 87.504 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 86.389 ns | 0.6911 ns | 0.6464 ns | 86.078 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 96.379 ns | 0.1325 ns | 0.1174 ns | 96.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 88.624 ns | 0.2246 ns | 0.1991 ns | 88.564 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 67.524 ns | 0.2478 ns | 0.2197 ns | 67.518 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 95.736 ns | 0.6515 ns | 0.6094 ns | 95.987 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 94.186 ns | 0.1840 ns | 0.1722 ns | 94.150 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.665 ns | 0.0195 ns | 0.0173 ns | 13.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.637 ns | 0.0287 ns | 0.0269 ns | 12.644 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.074 ns | 0.1602 ns | 0.1251 ns | 13.109 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 16.176 ns | 0.1151 ns | 0.1076 ns | 16.208 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.335 ns | 0.0183 ns | 0.0153 ns | 14.341 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.404 ns | 0.0591 ns | 0.0552 ns | 14.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.741 ns | 0.0203 ns | 0.0170 ns | 13.741 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.010 ns | 0.0415 ns | 0.0389 ns | 12.014 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.488 ns | 0.0224 ns | 0.0187 ns | 15.495 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.648 ns | 0.0220 ns | 0.0184 ns | 15.648 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.959 ns | 0.0242 ns | 0.0226 ns | 13.961 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.451 ns | 0.0234 ns | 0.0195 ns | 13.452 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.557 ns | 0.1913 ns | 0.1789 ns | 12.579 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.900 ns | 0.0278 ns | 0.0260 ns | 13.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.426 ns | 0.0260 ns | 0.0243 ns | 14.427 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 21.729 ns | 0.0217 ns | 0.0192 ns | 21.733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 17.934 ns | 0.0390 ns | 0.0326 ns | 17.933 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 15.864 ns | 0.0286 ns | 0.0267 ns | 15.867 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 19.816 ns | 0.0636 ns | 0.0531 ns | 19.799 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 19.574 ns | 0.0571 ns | 0.0477 ns | 19.554 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 26.972 ns | 0.0683 ns | 0.0639 ns | 26.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 25.074 ns | 0.0774 ns | 0.0724 ns | 25.064 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 26.479 ns | 0.0384 ns | 0.0360 ns | 26.479 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.225 ns | 0.0469 ns | 0.0416 ns | 27.213 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.161 ns | 0.0298 ns | 0.0265 ns | 27.158 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 21.704 ns | 0.1464 ns | 0.1369 ns | 21.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 17.906 ns | 0.0351 ns | 0.0311 ns | 17.901 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 17.086 ns | 0.1262 ns | 0.1180 ns | 17.041 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 20.735 ns | 0.0495 ns | 0.0439 ns | 20.722 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 20.237 ns | 0.0491 ns | 0.0459 ns | 20.232 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.352 ns | 0.0887 ns | 0.0786 ns | 27.370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.051 ns | 0.0372 ns | 0.0330 ns | 25.055 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.095 ns | 0.1753 ns | 0.1639 ns | 24.164 ns |  0.88 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.200 ns | 0.0413 ns | 0.0387 ns | 27.204 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.373 ns | 0.2903 ns | 0.2716 ns | 27.225 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.705 ns | 0.0194 ns | 0.0182 ns | 14.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.417 ns | 0.0261 ns | 0.0231 ns | 11.410 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.877 ns | 0.0173 ns | 0.0153 ns |  7.872 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.197 ns | 0.0170 ns | 0.0150 ns | 13.202 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.961 ns | 0.0275 ns | 0.0257 ns | 12.959 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.493 ns | 0.0245 ns | 0.0218 ns | 14.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.977 ns | 0.0340 ns | 0.0302 ns | 14.974 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.089 ns | 0.1234 ns | 0.1154 ns | 12.022 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.811 ns | 0.0274 ns | 0.0256 ns | 14.804 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.978 ns | 0.0333 ns | 0.0312 ns | 14.985 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 21.914 ns | 0.1031 ns | 0.0914 ns | 21.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 17.713 ns | 0.0314 ns | 0.0278 ns | 17.705 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 16.055 ns | 0.0242 ns | 0.0214 ns | 16.055 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 19.554 ns | 0.0273 ns | 0.0242 ns | 19.555 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 19.967 ns | 0.2276 ns | 0.2129 ns | 19.812 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 26.964 ns | 0.0749 ns | 0.0701 ns | 26.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 25.075 ns | 0.0286 ns | 0.0267 ns | 25.080 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 26.317 ns | 0.0397 ns | 0.0352 ns | 26.314 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.194 ns | 0.0386 ns | 0.0323 ns | 27.195 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 27.163 ns | 0.0438 ns | 0.0366 ns | 27.163 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 19.996 ns | 0.0445 ns | 0.0372 ns | 19.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 17.671 ns | 0.0362 ns | 0.0321 ns | 17.672 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 17.197 ns | 0.2076 ns | 0.1942 ns | 17.204 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 20.708 ns | 0.0310 ns | 0.0275 ns | 20.710 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 20.219 ns | 0.0252 ns | 0.0236 ns | 20.219 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.600 ns | 0.1156 ns | 0.1081 ns | 27.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.063 ns | 0.0267 ns | 0.0250 ns | 25.066 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.192 ns | 0.0399 ns | 0.0373 ns | 24.192 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.231 ns | 0.0459 ns | 0.0430 ns | 27.232 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.204 ns | 0.0452 ns | 0.0353 ns | 27.214 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 14.668 ns | 0.0172 ns | 0.0161 ns | 14.665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.853 ns | 0.0253 ns | 0.0237 ns | 10.846 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 10.414 ns | 0.2305 ns | 0.6032 ns | 10.575 ns |  0.66 |    0.08 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.497 ns | 0.0526 ns | 0.0492 ns | 14.478 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.976 ns | 0.0202 ns | 0.0189 ns | 12.969 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.518 ns | 0.0224 ns | 0.0198 ns | 14.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.722 ns | 0.0157 ns | 0.0139 ns | 13.722 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.235 ns | 0.0406 ns | 0.0380 ns | 16.232 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.974 ns | 0.0275 ns | 0.0244 ns | 14.970 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 16.775 ns | 0.0412 ns | 0.0344 ns | 16.772 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 21.386 ns | 0.0398 ns | 0.0372 ns | 21.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 17.699 ns | 0.0339 ns | 0.0317 ns | 17.706 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 16.486 ns | 0.1333 ns | 0.1247 ns | 16.533 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 19.579 ns | 0.0335 ns | 0.0313 ns | 19.578 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 19.550 ns | 0.0443 ns | 0.0414 ns | 19.541 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 27.187 ns | 0.0429 ns | 0.0380 ns | 27.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 25.067 ns | 0.0518 ns | 0.0460 ns | 25.056 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 29.048 ns | 0.5261 ns | 0.4921 ns | 29.347 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.202 ns | 0.0794 ns | 0.0743 ns | 27.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 31.588 ns | 0.0503 ns | 0.0471 ns | 31.597 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 21.732 ns | 0.0207 ns | 0.0194 ns | 21.735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 18.378 ns | 0.0213 ns | 0.0188 ns | 18.375 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 17.735 ns | 0.0398 ns | 0.0372 ns | 17.731 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 20.927 ns | 0.0294 ns | 0.0246 ns | 20.932 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 21.084 ns | 0.1749 ns | 0.1636 ns | 20.995 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.014 ns | 0.1576 ns | 0.1475 ns | 26.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.076 ns | 0.0305 ns | 0.0271 ns | 25.074 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.905 ns | 0.0479 ns | 0.0400 ns | 24.901 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.381 ns | 0.0473 ns | 0.0442 ns | 28.384 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.160 ns | 0.0554 ns | 0.0491 ns | 27.149 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.842 ns | 0.0186 ns | 0.0174 ns | 14.842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.679 ns | 0.0273 ns | 0.0255 ns | 11.687 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.045 ns | 0.0229 ns | 0.0214 ns |  9.041 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.243 ns | 0.0710 ns | 0.0664 ns | 13.222 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.428 ns | 0.1622 ns | 0.1517 ns | 13.343 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.012 ns | 0.0335 ns | 0.0280 ns | 15.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.748 ns | 0.0130 ns | 0.0122 ns | 13.749 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.525 ns | 0.3349 ns | 0.3723 ns | 15.725 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 16.724 ns | 0.0317 ns | 0.0265 ns | 16.725 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.510 ns | 0.0340 ns | 0.0318 ns | 16.524 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.970 ns | 0.0137 ns | 0.0128 ns | 14.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.645 ns | 0.0323 ns | 0.0302 ns | 14.643 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.962 ns | 0.1559 ns | 0.1458 ns | 14.894 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 16.409 ns | 0.0220 ns | 0.0195 ns | 16.408 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.316 ns | 0.0272 ns | 0.0254 ns | 15.321 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.965 ns | 0.0301 ns | 0.0267 ns | 11.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.896 ns | 0.0309 ns | 0.0258 ns |  9.892 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.452 ns | 0.1572 ns | 0.1470 ns | 13.499 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.871 ns | 0.0246 ns | 0.0230 ns | 12.866 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.289 ns | 0.0223 ns | 0.0197 ns | 13.293 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.532 ns | 0.0232 ns | 0.0217 ns | 16.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.676 ns | 0.0205 ns | 0.0192 ns | 14.675 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.835 ns | 0.0324 ns | 0.0270 ns | 14.831 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.826 ns | 0.0332 ns | 0.0295 ns | 16.830 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.965 ns | 0.0252 ns | 0.0236 ns | 14.960 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 21.503 ns | 0.0289 ns | 0.0256 ns | 21.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 18.425 ns | 0.0417 ns | 0.0390 ns | 18.426 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 17.297 ns | 0.0317 ns | 0.0281 ns | 17.299 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 21.179 ns | 0.0218 ns | 0.0182 ns | 21.179 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 21.503 ns | 0.0333 ns | 0.0295 ns | 21.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 23.572 ns | 0.0237 ns | 0.0210 ns | 23.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 20.406 ns | 0.0365 ns | 0.0323 ns | 20.405 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 22.667 ns | 0.0398 ns | 0.0353 ns | 22.672 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 23.078 ns | 0.0785 ns | 0.0696 ns | 23.060 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 22.362 ns | 0.0452 ns | 0.0377 ns | 22.364 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.202 ns | 0.0312 ns | 0.0277 ns | 15.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.692 ns | 0.0152 ns | 0.0135 ns | 12.691 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 14.782 ns | 0.2292 ns | 0.2032 ns | 14.879 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.683 ns | 0.0335 ns | 0.0280 ns | 14.682 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.511 ns | 0.0273 ns | 0.0255 ns | 16.511 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.985 ns | 0.0117 ns | 0.0109 ns | 15.984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.741 ns | 0.0297 ns | 0.0263 ns | 13.744 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.035 ns | 0.0785 ns | 0.0696 ns | 12.005 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.956 ns | 0.0215 ns | 0.0201 ns | 14.949 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.067 ns | 0.0268 ns | 0.0251 ns | 15.062 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.822 ns | 0.0188 ns | 0.0157 ns | 13.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.207 ns | 0.0230 ns | 0.0203 ns | 11.213 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.106 ns | 0.2670 ns | 0.3564 ns | 12.224 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.750 ns | 0.0142 ns | 0.0133 ns | 13.747 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.201 ns | 0.0242 ns | 0.0189 ns | 14.199 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 18.723 ns | 0.0273 ns | 0.0228 ns | 18.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.092 ns | 0.0326 ns | 0.0289 ns | 15.087 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.113 ns | 0.0824 ns | 0.0770 ns | 16.135 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.109 ns | 0.0232 ns | 0.0217 ns | 17.109 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.219 ns | 0.0210 ns | 0.0197 ns | 17.219 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.924 ns | 0.0245 ns | 0.0217 ns | 13.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.237 ns | 0.0248 ns | 0.0219 ns | 11.238 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.857 ns | 0.1486 ns | 0.1390 ns | 11.942 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 13.759 ns | 0.0172 ns | 0.0152 ns | 13.759 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.191 ns | 0.0210 ns | 0.0197 ns | 14.195 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.874 ns | 0.0452 ns | 0.0401 ns | 16.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.730 ns | 0.0357 ns | 0.0334 ns | 13.737 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.976 ns | 0.2040 ns | 0.1909 ns | 12.815 ns |  0.77 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.035 ns | 0.0278 ns | 0.0247 ns | 15.033 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 17.567 ns | 0.0313 ns | 0.0262 ns | 17.562 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 23.765 ns | 0.0681 ns | 0.0637 ns | 23.738 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 18.934 ns | 0.0365 ns | 0.0324 ns | 18.942 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 16.653 ns | 0.1346 ns | 0.1259 ns | 16.624 ns |  0.70 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 22.753 ns | 0.0527 ns | 0.0411 ns | 22.742 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 22.754 ns | 0.0767 ns | 0.0717 ns | 22.729 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 25.795 ns | 0.0229 ns | 0.0191 ns | 25.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 20.844 ns | 0.0243 ns | 0.0215 ns | 20.848 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 24.677 ns | 0.1353 ns | 0.1130 ns | 24.705 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 23.168 ns | 0.1118 ns | 0.0991 ns | 23.193 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 22.945 ns | 0.1559 ns | 0.1302 ns | 22.963 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 23.491 ns | 0.0757 ns | 0.0708 ns | 23.476 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 19.278 ns | 0.0687 ns | 0.0609 ns | 19.272 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 17.401 ns | 0.0944 ns | 0.0883 ns | 17.381 ns |  0.74 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 22.650 ns | 0.0608 ns | 0.0569 ns | 22.653 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 23.403 ns | 0.9387 ns | 1.3159 ns | 22.822 ns |  1.01 |    0.07 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.637 ns | 0.0662 ns | 0.0619 ns | 22.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.664 ns | 0.0393 ns | 0.0367 ns | 20.652 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.413 ns | 0.0295 ns | 0.0246 ns | 21.415 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 23.884 ns | 0.1312 ns | 0.1163 ns | 23.917 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 22.998 ns | 0.1530 ns | 0.1356 ns | 23.013 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.101 ns | 0.0417 ns | 0.0370 ns | 14.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.129 ns | 0.0220 ns | 0.0195 ns | 12.129 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.892 ns | 0.1997 ns | 0.3109 ns |  9.039 ns |  0.62 |    0.03 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.260 ns | 0.0122 ns | 0.0095 ns | 13.260 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.483 ns | 0.0621 ns | 0.0550 ns | 13.483 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.361 ns | 0.0232 ns | 0.0181 ns | 14.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.742 ns | 0.0188 ns | 0.0167 ns | 13.749 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.026 ns | 0.0380 ns | 0.0337 ns | 12.025 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.968 ns | 0.0183 ns | 0.0162 ns | 16.969 ns |  1.18 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.609 ns | 0.0994 ns | 0.0930 ns | 15.598 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.302 ns | 0.0109 ns | 0.0102 ns | 14.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.991 ns | 0.0151 ns | 0.0134 ns | 11.993 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.634 ns | 0.0738 ns | 0.0654 ns |  7.670 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.711 ns | 0.0737 ns | 0.0653 ns | 13.729 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.744 ns | 0.1322 ns | 0.1172 ns | 13.720 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.020 ns | 0.0357 ns | 0.0317 ns | 16.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.079 ns | 0.0206 ns | 0.0183 ns | 15.078 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 17.351 ns | 0.0416 ns | 0.0389 ns | 17.338 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.009 ns | 0.0454 ns | 0.0379 ns | 16.994 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.446 ns | 0.2319 ns | 0.2169 ns | 17.362 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.103 ns | 0.0716 ns | 0.0669 ns | 14.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.841 ns | 0.0173 ns | 0.0162 ns | 12.844 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  8.961 ns | 0.2036 ns | 0.4205 ns |  9.077 ns |  0.61 |    0.05 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.812 ns | 0.0254 ns | 0.0237 ns | 12.813 ns |  0.91 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.740 ns | 0.2355 ns | 0.1967 ns | 13.690 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.303 ns | 0.0463 ns | 0.0410 ns | 16.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.103 ns | 0.0255 ns | 0.0226 ns | 15.100 ns |  0.93 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.270 ns | 0.3683 ns | 0.5282 ns | 16.949 ns |  1.08 |    0.03 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.081 ns | 0.0607 ns | 0.0567 ns | 17.086 ns |  1.05 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.950 ns | 0.1370 ns | 0.1144 ns | 18.934 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.097 ns | 0.0482 ns | 0.0403 ns | 14.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.021 ns | 0.0343 ns | 0.0287 ns | 12.021 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.234 ns | 0.7615 ns | 0.9065 ns |  7.741 ns |  0.61 |    0.07 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.008 ns | 0.0161 ns | 0.0135 ns | 13.010 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.702 ns | 0.1209 ns | 0.1072 ns | 13.687 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.376 ns | 0.0311 ns | 0.0275 ns | 14.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.739 ns | 0.0195 ns | 0.0183 ns | 13.733 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.090 ns | 0.0342 ns | 0.0303 ns | 16.093 ns |  1.12 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.809 ns | 0.0176 ns | 0.0156 ns | 14.809 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.046 ns | 0.0505 ns | 0.0448 ns | 15.032 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 21.582 ns | 0.0424 ns | 0.0354 ns | 21.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 17.663 ns | 0.0349 ns | 0.0309 ns | 17.662 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 | 16.223 ns | 0.1315 ns | 0.1230 ns | 16.147 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 19.560 ns | 0.0624 ns | 0.0487 ns | 19.549 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 19.893 ns | 0.2119 ns | 0.1982 ns | 19.863 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 51.286 ns | 0.1641 ns | 0.1535 ns | 51.260 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 47.621 ns | 0.1983 ns | 0.1656 ns | 47.597 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 43.545 ns | 0.1754 ns | 0.1555 ns | 43.499 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 52.005 ns | 0.0741 ns | 0.0693 ns | 51.999 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.013 ns | 0.0928 ns | 0.0823 ns | 50.005 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 21.128 ns | 0.0253 ns | 0.0224 ns | 21.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 20.560 ns | 0.1163 ns | 0.1088 ns | 20.602 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 16.760 ns | 0.0345 ns | 0.0288 ns | 16.764 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 20.712 ns | 0.0316 ns | 0.0280 ns | 20.714 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 20.292 ns | 0.0453 ns | 0.0423 ns | 20.281 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 48.837 ns | 0.1024 ns | 0.0908 ns | 48.832 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 49.208 ns | 0.1547 ns | 0.1447 ns | 49.179 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.869 ns | 0.2151 ns | 0.1797 ns | 41.806 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 53.451 ns | 0.0740 ns | 0.0656 ns | 53.454 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 50.389 ns | 0.3055 ns | 0.2858 ns | 50.398 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.214 ns | 0.0214 ns | 0.0190 ns | 14.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.406 ns | 0.0217 ns | 0.0170 ns | 13.405 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  8.885 ns | 0.2041 ns | 0.5196 ns |  9.079 ns |  0.57 |    0.06 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.908 ns | 0.0768 ns | 0.0642 ns | 13.924 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.389 ns | 0.1153 ns | 0.1079 ns | 13.365 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.389 ns | 0.0448 ns | 0.0397 ns | 14.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.000 ns | 0.0165 ns | 0.0129 ns | 14.001 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.127 ns | 0.0387 ns | 0.0362 ns | 16.117 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.821 ns | 0.0123 ns | 0.0115 ns | 14.822 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.079 ns | 0.0477 ns | 0.0423 ns | 15.078 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.563 ns | 0.0294 ns | 0.0245 ns | 14.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.408 ns | 0.0138 ns | 0.0123 ns | 11.410 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.760 ns | 0.0595 ns | 0.0527 ns | 11.772 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.747 ns | 0.0231 ns | 0.0216 ns | 13.743 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.384 ns | 0.1155 ns | 0.1080 ns | 14.389 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 19.127 ns | 0.0265 ns | 0.0248 ns | 19.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.528 ns | 0.0340 ns | 0.0318 ns | 15.524 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.771 ns | 0.0603 ns | 0.0503 ns | 14.750 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.371 ns | 0.0727 ns | 0.0680 ns | 17.388 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.075 ns | 0.1656 ns | 0.1549 ns | 18.000 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.830 ns | 0.0192 ns | 0.0160 ns | 13.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.209 ns | 0.0227 ns | 0.0190 ns | 11.211 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.246 ns | 0.1289 ns | 0.1206 ns | 11.201 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.907 ns | 0.0199 ns | 0.0186 ns | 13.906 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.086 ns | 0.0411 ns | 0.0365 ns | 14.094 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.598 ns | 0.1145 ns | 0.1071 ns | 14.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.967 ns | 0.0667 ns | 0.0591 ns | 13.983 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 16.255 ns | 0.0621 ns | 0.0551 ns | 16.240 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 16.420 ns | 0.0460 ns | 0.0384 ns | 16.411 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.116 ns | 0.0476 ns | 0.0398 ns | 15.112 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.490 ns | 0.0922 ns | 0.0863 ns | 39.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.628 ns | 0.0970 ns | 0.0908 ns | 38.634 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.707 ns | 0.0664 ns | 0.0554 ns | 35.711 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 47.494 ns | 0.2529 ns | 0.2366 ns | 47.535 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.318 ns | 0.1432 ns | 0.1196 ns | 40.325 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.674 ns | 0.0363 ns | 0.0284 ns | 17.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.560 ns | 0.1262 ns | 0.1180 ns | 15.496 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.431 ns | 0.1756 ns | 0.1642 ns | 14.391 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 18.966 ns | 0.0571 ns | 0.0506 ns | 18.972 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.112 ns | 0.3128 ns | 0.2926 ns | 17.946 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.883 ns | 0.0434 ns | 0.0406 ns | 40.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.667 ns | 0.0419 ns | 0.0350 ns | 39.667 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.472 ns | 0.3230 ns | 0.2522 ns | 35.339 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.451 ns | 0.1654 ns | 0.1466 ns | 39.397 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.450 ns | 0.4962 ns | 0.4399 ns | 40.390 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.320 ns | 0.0321 ns | 0.0300 ns | 16.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.528 ns | 0.0226 ns | 0.0200 ns | 15.526 ns |  0.95 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.189 ns | 0.0326 ns | 0.0272 ns | 14.195 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 19.362 ns | 0.1772 ns | 0.1658 ns | 19.423 ns |  1.19 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.768 ns | 0.0722 ns | 0.0603 ns | 17.742 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.599 ns | 0.1241 ns | 0.1161 ns | 40.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.370 ns | 0.0794 ns | 0.0620 ns | 38.361 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.758 ns | 0.1989 ns | 0.1861 ns | 35.743 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.304 ns | 0.0830 ns | 0.0777 ns | 39.291 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 45.446 ns | 0.3944 ns | 0.3689 ns | 45.458 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.257 ns | 0.0461 ns | 0.0431 ns | 16.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.320 ns | 0.0136 ns | 0.0127 ns | 14.324 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.577 ns | 0.0218 ns | 0.0204 ns | 16.578 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 16.500 ns | 0.0404 ns | 0.0337 ns | 16.503 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.527 ns | 0.2031 ns | 0.1801 ns | 15.462 ns |  0.96 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DecimalNullable.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DecimalNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
