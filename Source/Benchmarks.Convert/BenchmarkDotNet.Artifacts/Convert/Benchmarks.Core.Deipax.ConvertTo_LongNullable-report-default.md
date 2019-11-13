
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
                                             From_Bool | .NET Core 2.0 | 14.091 ns | 0.0161 ns | 0.0150 ns | 14.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.571 ns | 0.0103 ns | 0.0091 ns | 10.571 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.266 ns | 0.0283 ns | 0.0264 ns |  8.265 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.835 ns | 0.0158 ns | 0.0148 ns | 12.835 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.899 ns | 0.0106 ns | 0.0099 ns | 12.899 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.856 ns | 0.0153 ns | 0.0128 ns | 20.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.645 ns | 0.0524 ns | 0.0490 ns | 17.652 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.546 ns | 0.0487 ns | 0.0455 ns | 17.548 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 20.880 ns | 0.0338 ns | 0.0316 ns | 20.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.476 ns | 0.0318 ns | 0.0298 ns | 20.477 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.118 ns | 0.0081 ns | 0.0076 ns | 13.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.834 ns | 0.0172 ns | 0.0161 ns | 10.833 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.251 ns | 0.0079 ns | 0.0074 ns |  8.252 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.979 ns | 0.0600 ns | 0.0561 ns | 13.956 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.324 ns | 0.0384 ns | 0.0359 ns | 13.344 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.623 ns | 0.0179 ns | 0.0167 ns | 20.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.626 ns | 0.0382 ns | 0.0357 ns | 17.626 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.504 ns | 0.0470 ns | 0.0440 ns | 17.505 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 22.728 ns | 0.0324 ns | 0.0303 ns | 22.734 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.694 ns | 0.0283 ns | 0.0265 ns | 20.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.587 ns | 0.0107 ns | 0.0090 ns | 12.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.442 ns | 0.0257 ns | 0.0240 ns | 10.450 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.480 ns | 0.0241 ns | 0.0226 ns |  7.483 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.797 ns | 0.0141 ns | 0.0125 ns | 12.799 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.275 ns | 0.0147 ns | 0.0137 ns | 13.276 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.435 ns | 0.0168 ns | 0.0158 ns | 16.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.418 ns | 0.0173 ns | 0.0154 ns | 13.420 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.595 ns | 0.0496 ns | 0.0464 ns | 14.619 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 16.010 ns | 0.0400 ns | 0.0375 ns | 16.025 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.080 ns | 0.0436 ns | 0.0408 ns | 15.075 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.528 ns | 0.0394 ns | 0.0369 ns | 12.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.765 ns | 0.0076 ns | 0.0071 ns | 10.767 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.581 ns | 0.0241 ns | 0.0225 ns |  7.573 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.953 ns | 0.0240 ns | 0.0213 ns | 13.943 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.678 ns | 0.0079 ns | 0.0074 ns | 12.678 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 21.040 ns | 0.0313 ns | 0.0293 ns | 21.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.748 ns | 0.0674 ns | 0.0631 ns | 17.755 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.449 ns | 0.0323 ns | 0.0302 ns | 17.455 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 21.599 ns | 0.0585 ns | 0.0547 ns | 21.603 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 21.025 ns | 0.0420 ns | 0.0393 ns | 21.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.815 ns | 0.0131 ns | 0.0123 ns | 12.811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.575 ns | 0.0093 ns | 0.0083 ns | 10.576 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  8.292 ns | 0.1543 ns | 0.1443 ns |  8.193 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.834 ns | 0.0629 ns | 0.0588 ns | 13.843 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.204 ns | 0.0140 ns | 0.0124 ns | 13.203 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.356 ns | 0.0138 ns | 0.0129 ns | 20.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.319 ns | 0.0094 ns | 0.0078 ns | 17.318 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.890 ns | 0.0280 ns | 0.0262 ns | 17.888 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.094 ns | 0.0299 ns | 0.0279 ns | 21.091 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.727 ns | 0.0308 ns | 0.0288 ns | 20.725 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.588 ns | 0.0093 ns | 0.0087 ns | 12.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.444 ns | 0.0191 ns | 0.0179 ns | 10.445 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  8.105 ns | 0.0184 ns | 0.0163 ns |  8.101 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.440 ns | 0.0245 ns | 0.0217 ns | 13.436 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.639 ns | 0.0137 ns | 0.0128 ns | 12.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.106 ns | 0.0236 ns | 0.0221 ns | 19.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.783 ns | 0.0055 ns | 0.0046 ns | 13.783 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.942 ns | 0.2564 ns | 0.2953 ns | 11.779 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.395 ns | 0.0380 ns | 0.0355 ns | 14.393 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 14.678 ns | 0.0394 ns | 0.0368 ns | 14.677 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.495 ns | 0.0151 ns | 0.0142 ns | 12.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.324 ns | 0.0096 ns | 0.0090 ns | 11.328 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.587 ns | 0.0088 ns | 0.0082 ns |  7.588 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.705 ns | 0.0131 ns | 0.0116 ns | 12.707 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.700 ns | 0.0167 ns | 0.0139 ns | 12.704 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.575 ns | 0.0263 ns | 0.0246 ns | 20.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.125 ns | 0.0434 ns | 0.0406 ns | 18.134 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.312 ns | 0.0747 ns | 0.0699 ns | 17.320 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 22.302 ns | 0.0372 ns | 0.0348 ns | 22.304 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 21.715 ns | 0.0205 ns | 0.0182 ns | 21.715 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.675 ns | 0.0111 ns | 0.0104 ns | 12.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.747 ns | 0.0092 ns | 0.0086 ns | 10.744 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.319 ns | 0.0151 ns | 0.0134 ns |  7.320 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.118 ns | 0.0099 ns | 0.0092 ns | 13.119 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.301 ns | 0.0190 ns | 0.0178 ns | 13.296 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.815 ns | 0.0184 ns | 0.0172 ns | 20.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.094 ns | 0.0202 ns | 0.0179 ns | 18.089 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.519 ns | 0.1439 ns | 0.1346 ns | 18.438 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 20.789 ns | 0.0518 ns | 0.0484 ns | 20.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 20.554 ns | 0.0401 ns | 0.0375 ns | 20.559 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.483 ns | 0.0190 ns | 0.0177 ns | 12.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.863 ns | 0.0112 ns | 0.0105 ns | 11.861 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  8.024 ns | 0.0167 ns | 0.0156 ns |  8.026 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.671 ns | 0.0132 ns | 0.0117 ns | 12.674 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.826 ns | 0.0176 ns | 0.0164 ns | 12.832 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.070 ns | 0.0138 ns | 0.0129 ns | 17.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.786 ns | 0.0157 ns | 0.0147 ns | 13.786 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.747 ns | 0.0246 ns | 0.0230 ns | 11.752 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 14.445 ns | 0.0242 ns | 0.0226 ns | 14.448 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.209 ns | 0.0185 ns | 0.0173 ns | 15.208 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.558 ns | 0.0159 ns | 0.0148 ns | 12.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.397 ns | 0.0437 ns | 0.0409 ns | 11.380 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.850 ns | 0.0197 ns | 0.0184 ns |  7.855 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.512 ns | 0.0226 ns | 0.0189 ns | 12.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.482 ns | 0.0124 ns | 0.0110 ns | 13.481 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.342 ns | 0.0172 ns | 0.0160 ns | 12.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.361 ns | 0.0121 ns | 0.0114 ns | 11.365 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.128 ns | 0.2059 ns | 0.2953 ns |  9.279 ns |  0.73 |    0.03 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.288 ns | 0.0195 ns | 0.0173 ns | 15.286 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.328 ns | 0.0193 ns | 0.0181 ns | 14.331 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.341 ns | 0.0200 ns | 0.0187 ns | 12.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.818 ns | 0.0140 ns | 0.0131 ns | 11.817 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.997 ns | 0.0174 ns | 0.0163 ns |  8.000 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 15.214 ns | 0.0214 ns | 0.0190 ns | 15.216 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.323 ns | 0.0164 ns | 0.0153 ns | 14.326 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.902 ns | 0.0282 ns | 0.0263 ns | 15.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.413 ns | 0.0135 ns | 0.0126 ns | 13.416 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.775 ns | 0.0445 ns | 0.0416 ns | 11.779 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 16.050 ns | 0.0580 ns | 0.0542 ns | 16.042 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.836 ns | 0.0193 ns | 0.0172 ns | 14.842 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.872 ns | 0.0212 ns | 0.0198 ns | 21.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.248 ns | 0.1326 ns | 0.1240 ns | 20.238 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.717 ns | 0.0152 ns | 0.0143 ns | 12.717 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.982 ns | 0.0309 ns | 0.0289 ns | 21.984 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.330 ns | 0.0207 ns | 0.0194 ns | 22.326 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 29.282 ns | 0.0214 ns | 0.0200 ns | 29.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 27.489 ns | 0.0272 ns | 0.0254 ns | 27.490 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.018 ns | 0.1248 ns | 0.1168 ns | 21.091 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 30.202 ns | 0.0389 ns | 0.0364 ns | 30.211 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 28.747 ns | 0.0414 ns | 0.0387 ns | 28.759 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.545 ns | 0.0399 ns | 0.0374 ns | 22.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.779 ns | 0.0242 ns | 0.0226 ns | 20.778 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.242 ns | 0.0499 ns | 0.0467 ns | 16.234 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.569 ns | 0.0764 ns | 0.0715 ns | 23.600 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.071 ns | 0.0543 ns | 0.0508 ns | 23.049 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 29.647 ns | 0.0235 ns | 0.0209 ns | 29.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 27.252 ns | 0.0280 ns | 0.0262 ns | 27.254 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.429 ns | 0.1143 ns | 0.1013 ns | 21.471 ns |  0.72 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 29.564 ns | 0.0348 ns | 0.0291 ns | 29.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 29.871 ns | 0.0387 ns | 0.0362 ns | 29.881 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.513 ns | 0.0208 ns | 0.0195 ns | 12.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.677 ns | 0.0137 ns | 0.0128 ns | 11.674 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.384 ns | 0.0112 ns | 0.0100 ns |  8.384 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.786 ns | 0.0161 ns | 0.0151 ns | 13.791 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.972 ns | 0.0167 ns | 0.0156 ns | 13.971 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.158 ns | 0.0273 ns | 0.0255 ns | 16.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.417 ns | 0.0116 ns | 0.0102 ns | 13.415 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.739 ns | 0.0249 ns | 0.0233 ns | 11.735 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 14.473 ns | 0.0512 ns | 0.0479 ns | 14.487 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 14.530 ns | 0.0286 ns | 0.0254 ns | 14.532 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.551 ns | 0.0131 ns | 0.0116 ns | 15.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.820 ns | 0.0208 ns | 0.0194 ns | 11.821 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.442 ns | 0.2562 ns | 0.3050 ns |  9.285 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.277 ns | 0.0252 ns | 0.0210 ns | 16.285 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 16.402 ns | 0.0243 ns | 0.0228 ns | 16.404 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 23.593 ns | 0.0450 ns | 0.0399 ns | 23.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.663 ns | 0.0258 ns | 0.0241 ns | 20.666 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.835 ns | 0.2346 ns | 0.2194 ns | 18.846 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 25.246 ns | 0.0208 ns | 0.0194 ns | 25.241 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 23.431 ns | 0.0266 ns | 0.0249 ns | 23.430 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.912 ns | 0.0862 ns | 0.0807 ns | 15.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.933 ns | 0.0100 ns | 0.0089 ns | 12.937 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.429 ns | 0.2277 ns | 0.3116 ns | 10.236 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.062 ns | 0.0414 ns | 0.0387 ns | 16.065 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.048 ns | 0.0604 ns | 0.0565 ns | 16.044 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.289 ns | 0.0347 ns | 0.0325 ns | 24.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.227 ns | 0.0214 ns | 0.0200 ns | 20.221 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.236 ns | 0.0393 ns | 0.0367 ns | 18.245 ns |  0.75 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 23.717 ns | 0.0212 ns | 0.0198 ns | 23.716 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 23.491 ns | 0.0331 ns | 0.0310 ns | 23.485 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.525 ns | 0.0144 ns | 0.0135 ns | 12.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.532 ns | 0.0180 ns | 0.0168 ns | 11.532 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.469 ns | 0.1956 ns | 0.1830 ns |  9.312 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.047 ns | 0.0187 ns | 0.0165 ns | 14.045 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 15.157 ns | 0.0108 ns | 0.0101 ns | 15.158 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.193 ns | 0.0625 ns | 0.0584 ns | 16.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.422 ns | 0.0167 ns | 0.0156 ns | 13.425 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.764 ns | 0.1029 ns | 0.0962 ns | 13.772 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.529 ns | 0.0229 ns | 0.0214 ns | 14.526 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.174 ns | 0.0165 ns | 0.0146 ns | 16.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.498 ns | 0.0128 ns | 0.0113 ns | 12.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.769 ns | 0.0110 ns | 0.0103 ns | 10.768 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.816 ns | 0.0085 ns | 0.0080 ns |  7.815 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.759 ns | 0.0123 ns | 0.0109 ns | 12.761 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.683 ns | 0.0094 ns | 0.0083 ns | 12.683 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.125 ns | 0.0212 ns | 0.0198 ns | 20.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.557 ns | 0.0451 ns | 0.0422 ns | 17.545 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.039 ns | 0.3825 ns | 0.3578 ns | 17.801 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 22.737 ns | 0.0149 ns | 0.0124 ns | 22.738 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 21.024 ns | 0.0295 ns | 0.0247 ns | 21.024 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.811 ns | 0.0391 ns | 0.0366 ns | 12.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 13.237 ns | 0.0259 ns | 0.0230 ns | 13.231 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  8.289 ns | 0.0214 ns | 0.0200 ns |  8.283 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.254 ns | 0.0139 ns | 0.0116 ns | 13.254 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.687 ns | 0.0099 ns | 0.0093 ns | 13.687 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.356 ns | 0.0179 ns | 0.0159 ns | 20.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.590 ns | 0.0160 ns | 0.0150 ns | 17.591 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.793 ns | 0.0667 ns | 0.0624 ns | 16.801 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.596 ns | 0.0818 ns | 0.0765 ns | 21.616 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.989 ns | 0.0388 ns | 0.0363 ns | 20.984 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.481 ns | 0.0088 ns | 0.0078 ns | 12.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.620 ns | 0.0166 ns | 0.0156 ns | 10.617 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  8.647 ns | 0.1963 ns | 0.3489 ns |  8.829 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.685 ns | 0.0070 ns | 0.0062 ns | 12.685 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.854 ns | 0.0126 ns | 0.0118 ns | 12.854 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.069 ns | 0.0334 ns | 0.0312 ns | 15.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.311 ns | 0.0317 ns | 0.0297 ns | 14.310 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.710 ns | 0.0325 ns | 0.0304 ns | 11.715 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.519 ns | 0.0225 ns | 0.0188 ns | 14.511 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.798 ns | 0.0123 ns | 0.0115 ns | 15.798 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.469 ns | 0.0219 ns | 0.0204 ns | 12.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.413 ns | 0.0097 ns | 0.0086 ns | 10.413 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.587 ns | 0.0173 ns | 0.0162 ns |  7.585 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.821 ns | 0.0377 ns | 0.0353 ns | 12.827 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.913 ns | 0.0131 ns | 0.0116 ns | 12.913 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.594 ns | 0.0140 ns | 0.0131 ns | 21.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.410 ns | 0.0498 ns | 0.0466 ns | 17.414 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.920 ns | 0.5972 ns | 0.8753 ns | 18.438 ns |  0.90 |    0.05 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.323 ns | 0.0408 ns | 0.0381 ns | 21.330 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.931 ns | 0.0270 ns | 0.0253 ns | 20.934 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.700 ns | 0.0141 ns | 0.0132 ns | 12.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.718 ns | 0.0230 ns | 0.0215 ns | 10.726 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  9.005 ns | 0.2042 ns | 0.3298 ns |  9.139 ns |  0.70 |    0.04 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.074 ns | 0.0087 ns | 0.0077 ns | 13.075 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.464 ns | 0.0155 ns | 0.0145 ns | 14.456 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.910 ns | 0.0159 ns | 0.0141 ns | 20.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.559 ns | 0.0411 ns | 0.0385 ns | 17.565 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.744 ns | 0.0678 ns | 0.0601 ns | 17.735 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 22.775 ns | 0.0495 ns | 0.0463 ns | 22.786 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.044 ns | 0.0370 ns | 0.0346 ns | 21.049 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.481 ns | 0.0126 ns | 0.0118 ns | 12.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.596 ns | 0.0109 ns | 0.0102 ns | 10.592 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.604 ns | 0.0070 ns | 0.0066 ns |  7.606 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.673 ns | 0.0134 ns | 0.0125 ns | 12.674 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.837 ns | 0.0091 ns | 0.0086 ns | 12.838 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.897 ns | 0.0225 ns | 0.0210 ns | 15.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.415 ns | 0.0096 ns | 0.0090 ns | 13.415 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.689 ns | 0.1663 ns | 0.1555 ns | 12.574 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 15.039 ns | 0.0228 ns | 0.0213 ns | 15.041 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.068 ns | 0.0346 ns | 0.0323 ns | 15.075 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.501 ns | 0.0105 ns | 0.0093 ns | 12.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.451 ns | 0.0135 ns | 0.0127 ns | 10.456 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.329 ns | 0.1011 ns | 0.0946 ns |  7.388 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.577 ns | 0.0426 ns | 0.0398 ns | 13.590 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.585 ns | 0.0196 ns | 0.0183 ns | 12.581 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 27.307 ns | 0.0278 ns | 0.0260 ns | 27.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 25.834 ns | 0.0620 ns | 0.0580 ns | 25.839 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 27.944 ns | 0.0252 ns | 0.0236 ns | 27.949 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 36.454 ns | 0.1426 ns | 0.1333 ns | 36.443 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 32.209 ns | 0.0418 ns | 0.0370 ns | 32.209 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.713 ns | 0.0210 ns | 0.0196 ns | 12.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.406 ns | 0.0133 ns | 0.0124 ns | 11.411 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.196 ns | 0.0210 ns | 0.0197 ns |  8.199 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 12.849 ns | 0.0108 ns | 0.0096 ns | 12.848 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 12.927 ns | 0.0177 ns | 0.0165 ns | 12.928 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.671 ns | 0.0290 ns | 0.0271 ns | 24.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.781 ns | 0.0231 ns | 0.0216 ns | 25.784 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.289 ns | 0.0292 ns | 0.0273 ns | 27.288 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 35.812 ns | 0.0400 ns | 0.0374 ns | 35.808 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 32.283 ns | 0.0564 ns | 0.0528 ns | 32.289 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.461 ns | 0.0213 ns | 0.0200 ns | 12.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.741 ns | 0.0267 ns | 0.0249 ns | 11.745 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.210 ns | 0.0048 ns | 0.0043 ns |  8.211 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.853 ns | 0.0121 ns | 0.0107 ns | 12.851 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.908 ns | 0.0129 ns | 0.0120 ns | 12.910 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.063 ns | 0.0177 ns | 0.0166 ns | 15.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.125 ns | 0.0103 ns | 0.0080 ns | 14.128 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.491 ns | 0.0188 ns | 0.0157 ns | 12.494 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.831 ns | 0.0570 ns | 0.0505 ns | 15.830 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.582 ns | 0.0262 ns | 0.0245 ns | 14.579 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.690 ns | 0.0202 ns | 0.0189 ns | 12.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.428 ns | 0.0101 ns | 0.0090 ns | 10.430 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.812 ns | 0.0071 ns | 0.0063 ns |  7.814 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.447 ns | 0.0296 ns | 0.0263 ns | 13.451 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.491 ns | 0.0162 ns | 0.0151 ns | 13.490 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 21.083 ns | 0.0204 ns | 0.0190 ns | 21.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.795 ns | 0.0358 ns | 0.0335 ns | 17.806 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.994 ns | 0.0407 ns | 0.0360 ns | 16.999 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 22.726 ns | 0.0184 ns | 0.0172 ns | 22.728 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.030 ns | 0.0652 ns | 0.0610 ns | 21.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.919 ns | 0.0089 ns | 0.0083 ns | 12.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.629 ns | 0.0086 ns | 0.0080 ns | 10.627 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.388 ns | 0.0183 ns | 0.0171 ns |  8.384 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.195 ns | 0.0239 ns | 0.0223 ns | 13.194 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.192 ns | 0.0072 ns | 0.0068 ns | 13.194 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.089 ns | 0.0245 ns | 0.0229 ns | 21.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.358 ns | 0.0154 ns | 0.0144 ns | 17.360 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.478 ns | 0.4317 ns | 1.0509 ns | 20.925 ns |  0.89 |    0.06 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 22.574 ns | 0.0542 ns | 0.0507 ns | 22.569 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.782 ns | 0.0261 ns | 0.0244 ns | 20.784 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 13.421 ns | 0.0125 ns | 0.0117 ns | 13.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.441 ns | 0.0226 ns | 0.0212 ns | 10.440 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.401 ns | 0.1872 ns | 0.1923 ns |  8.252 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.758 ns | 0.0092 ns | 0.0086 ns | 12.757 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.635 ns | 0.0127 ns | 0.0119 ns | 12.635 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.789 ns | 0.0153 ns | 0.0143 ns | 16.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.432 ns | 0.0113 ns | 0.0100 ns | 13.434 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.603 ns | 0.1809 ns | 0.1692 ns | 14.523 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.383 ns | 0.0392 ns | 0.0367 ns | 14.378 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.318 ns | 0.0226 ns | 0.0211 ns | 15.321 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.478 ns | 0.0171 ns | 0.0142 ns | 15.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.529 ns | 0.0378 ns | 0.0335 ns | 12.526 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.113 ns | 0.0627 ns | 0.0556 ns | 10.138 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 17.853 ns | 0.0240 ns | 0.0213 ns | 17.852 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 16.355 ns | 0.0249 ns | 0.0221 ns | 16.358 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.559 ns | 0.0224 ns | 0.0210 ns | 23.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.543 ns | 0.0250 ns | 0.0234 ns | 19.541 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.395 ns | 0.0382 ns | 0.0338 ns | 19.393 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 24.010 ns | 0.0245 ns | 0.0229 ns | 24.007 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.633 ns | 0.0239 ns | 0.0224 ns | 23.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.433 ns | 0.0164 ns | 0.0153 ns | 15.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.018 ns | 0.0343 ns | 0.0321 ns | 12.015 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.943 ns | 0.1988 ns | 0.1860 ns | 10.097 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.939 ns | 0.0490 ns | 0.0434 ns | 15.950 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 16.034 ns | 0.0284 ns | 0.0266 ns | 16.035 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.434 ns | 0.0682 ns | 0.0638 ns | 24.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.549 ns | 0.0235 ns | 0.0219 ns | 19.552 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.225 ns | 0.0711 ns | 0.0665 ns | 18.214 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 25.307 ns | 0.0220 ns | 0.0206 ns | 25.313 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.655 ns | 0.0265 ns | 0.0248 ns | 23.656 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.665 ns | 0.0224 ns | 0.0199 ns | 12.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.615 ns | 0.0099 ns | 0.0093 ns | 10.613 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.250 ns | 0.2104 ns | 0.4203 ns |  9.445 ns |  0.69 |    0.04 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.339 ns | 0.0227 ns | 0.0190 ns | 13.341 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.842 ns | 0.0131 ns | 0.0116 ns | 12.844 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.056 ns | 0.0154 ns | 0.0144 ns | 15.059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.424 ns | 0.0173 ns | 0.0162 ns | 13.425 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.547 ns | 0.0972 ns | 0.0909 ns | 13.509 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 16.011 ns | 0.0399 ns | 0.0374 ns | 15.994 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.477 ns | 0.0234 ns | 0.0219 ns | 14.475 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 63.699 ns | 0.1090 ns | 0.1020 ns | 63.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.640 ns | 0.0607 ns | 0.0568 ns | 50.634 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.069 ns | 0.1399 ns | 0.1308 ns | 22.124 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 61.450 ns | 0.0725 ns | 0.0605 ns | 61.439 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.214 ns | 0.1058 ns | 0.0990 ns | 60.236 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 68.582 ns | 0.1952 ns | 0.1826 ns | 68.581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.309 ns | 0.0363 ns | 0.0303 ns | 59.318 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.830 ns | 0.1024 ns | 0.0958 ns | 26.848 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 67.472 ns | 0.1067 ns | 0.0998 ns | 67.457 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 65.618 ns | 0.0541 ns | 0.0452 ns | 65.608 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.299 ns | 0.0116 ns | 0.0109 ns | 13.297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.383 ns | 0.0192 ns | 0.0180 ns | 13.384 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.911 ns | 0.0088 ns | 0.0082 ns | 12.911 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.437 ns | 0.0357 ns | 0.0334 ns | 15.430 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.071 ns | 0.0288 ns | 0.0270 ns | 14.075 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.055 ns | 0.0247 ns | 0.0231 ns | 15.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.483 ns | 0.0111 ns | 0.0104 ns | 13.487 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.697 ns | 0.0557 ns | 0.0521 ns | 11.720 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.395 ns | 0.0168 ns | 0.0157 ns | 14.397 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 14.556 ns | 0.0255 ns | 0.0239 ns | 14.560 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.762 ns | 0.0233 ns | 0.0218 ns | 14.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.925 ns | 0.0163 ns | 0.0152 ns | 12.928 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.220 ns | 0.0108 ns | 0.0096 ns | 12.219 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.958 ns | 0.0169 ns | 0.0158 ns | 13.957 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.991 ns | 0.0224 ns | 0.0209 ns | 13.999 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.501 ns | 0.0091 ns | 0.0085 ns | 12.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.431 ns | 0.0114 ns | 0.0107 ns | 10.431 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.844 ns | 0.0232 ns | 0.0217 ns |  7.847 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.881 ns | 0.0649 ns | 0.0607 ns | 12.886 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.669 ns | 0.0111 ns | 0.0098 ns | 12.671 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.391 ns | 0.0381 ns | 0.0356 ns | 20.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.376 ns | 0.0150 ns | 0.0140 ns | 17.377 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.992 ns | 0.0286 ns | 0.0267 ns | 16.995 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.082 ns | 0.0349 ns | 0.0326 ns | 21.077 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.722 ns | 0.0306 ns | 0.0287 ns | 20.725 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.659 ns | 0.0133 ns | 0.0125 ns | 12.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.745 ns | 0.0521 ns | 0.0487 ns | 10.754 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  8.177 ns | 0.0153 ns | 0.0136 ns |  8.176 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.587 ns | 0.0437 ns | 0.0409 ns | 13.585 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.041 ns | 0.1806 ns | 0.1689 ns | 15.127 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.127 ns | 0.0297 ns | 0.0277 ns | 20.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.708 ns | 0.0199 ns | 0.0186 ns | 17.715 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.790 ns | 0.0960 ns | 0.0898 ns | 16.789 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.335 ns | 0.0272 ns | 0.0255 ns | 21.344 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.933 ns | 0.0180 ns | 0.0168 ns | 20.929 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.485 ns | 0.0171 ns | 0.0151 ns | 12.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.606 ns | 0.0252 ns | 0.0236 ns | 10.612 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.236 ns | 0.0448 ns | 0.0419 ns |  7.212 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.283 ns | 0.2098 ns | 0.1963 ns | 14.334 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.669 ns | 0.0144 ns | 0.0120 ns | 13.671 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.894 ns | 0.0167 ns | 0.0156 ns | 15.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.413 ns | 0.0161 ns | 0.0150 ns | 13.415 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.974 ns | 0.2904 ns | 0.2717 ns | 14.206 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 15.177 ns | 0.0440 ns | 0.0411 ns | 15.171 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.809 ns | 0.0353 ns | 0.0330 ns | 15.815 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.489 ns | 0.0157 ns | 0.0139 ns | 12.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.414 ns | 0.0069 ns | 0.0062 ns | 10.415 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.594 ns | 0.0182 ns | 0.0170 ns |  7.596 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.564 ns | 0.0143 ns | 0.0134 ns | 12.565 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.910 ns | 0.0069 ns | 0.0061 ns | 12.910 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 21.086 ns | 0.0255 ns | 0.0226 ns | 21.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.438 ns | 0.0610 ns | 0.0541 ns | 17.432 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 16.952 ns | 0.0476 ns | 0.0445 ns | 16.952 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.534 ns | 0.0303 ns | 0.0283 ns | 21.535 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.991 ns | 0.0336 ns | 0.0314 ns | 20.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 14.551 ns | 0.0147 ns | 0.0138 ns | 14.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.751 ns | 0.0259 ns | 0.0242 ns | 10.754 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.750 ns | 0.1988 ns | 0.3210 ns |  8.924 ns |  0.59 |    0.03 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.262 ns | 0.0238 ns | 0.0211 ns | 13.255 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.363 ns | 0.0296 ns | 0.0263 ns | 13.356 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.357 ns | 0.0277 ns | 0.0246 ns | 20.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.637 ns | 0.0207 ns | 0.0194 ns | 17.639 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.011 ns | 0.0757 ns | 0.0709 ns | 17.026 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 21.107 ns | 0.0273 ns | 0.0256 ns | 21.110 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.763 ns | 0.0240 ns | 0.0224 ns | 20.763 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.480 ns | 0.0102 ns | 0.0085 ns | 12.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.594 ns | 0.0112 ns | 0.0105 ns | 10.596 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.202 ns | 0.0081 ns | 0.0072 ns |  7.202 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.669 ns | 0.0118 ns | 0.0111 ns | 12.670 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.831 ns | 0.0365 ns | 0.0341 ns | 12.823 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.905 ns | 0.0140 ns | 0.0124 ns | 15.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.527 ns | 0.0337 ns | 0.0315 ns | 14.538 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.359 ns | 0.2700 ns | 0.2526 ns | 12.454 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.387 ns | 0.0432 ns | 0.0404 ns | 14.396 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.139 ns | 0.0134 ns | 0.0125 ns | 15.138 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.685 ns | 0.0149 ns | 0.0139 ns | 12.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.611 ns | 0.0065 ns | 0.0057 ns | 10.613 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.814 ns | 0.0249 ns | 0.0233 ns |  7.818 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.665 ns | 0.0216 ns | 0.0202 ns | 13.671 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 14.083 ns | 0.0238 ns | 0.0222 ns | 14.087 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.438 ns | 0.0246 ns | 0.0230 ns | 20.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.811 ns | 0.0399 ns | 0.0354 ns | 17.819 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 21.703 ns | 0.4594 ns | 1.1693 ns | 22.073 ns |  0.99 |    0.10 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 22.326 ns | 0.0798 ns | 0.0746 ns | 22.321 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.733 ns | 0.0692 ns | 0.0647 ns | 21.734 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.712 ns | 0.0137 ns | 0.0128 ns | 12.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.686 ns | 0.0167 ns | 0.0156 ns | 11.692 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.009 ns | 0.2441 ns | 0.6214 ns | 11.206 ns |  0.80 |    0.09 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.534 ns | 0.0240 ns | 0.0224 ns | 14.541 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.704 ns | 0.0274 ns | 0.0256 ns | 14.710 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.325 ns | 0.0286 ns | 0.0268 ns | 21.325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.855 ns | 0.0188 ns | 0.0167 ns | 17.856 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.065 ns | 0.0581 ns | 0.0544 ns | 17.069 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 22.312 ns | 0.0489 ns | 0.0458 ns | 22.320 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.713 ns | 0.0370 ns | 0.0346 ns | 21.713 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.434 ns | 0.0080 ns | 0.0075 ns | 12.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.784 ns | 0.0360 ns | 0.0337 ns | 11.782 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.349 ns | 0.1348 ns | 0.1261 ns |  8.447 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.520 ns | 0.0421 ns | 0.0352 ns | 14.522 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.813 ns | 0.0279 ns | 0.0261 ns | 13.819 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.458 ns | 0.0259 ns | 0.0242 ns | 15.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.962 ns | 0.0165 ns | 0.0154 ns | 13.964 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.749 ns | 0.0145 ns | 0.0135 ns | 11.751 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.433 ns | 0.0185 ns | 0.0173 ns | 14.436 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.453 ns | 0.0229 ns | 0.0214 ns | 14.450 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.067 ns | 0.0181 ns | 0.0169 ns | 15.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.423 ns | 0.0098 ns | 0.0092 ns | 13.422 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.122 ns | 0.2371 ns | 0.2218 ns | 12.236 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 16.047 ns | 0.0210 ns | 0.0187 ns | 16.045 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 14.458 ns | 0.0216 ns | 0.0202 ns | 14.457 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.259 ns | 0.0496 ns | 0.0464 ns | 12.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.535 ns | 0.0148 ns | 0.0131 ns |  9.539 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.582 ns | 0.0126 ns | 0.0118 ns | 11.579 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.307 ns | 0.0419 ns | 0.0392 ns | 12.315 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.496 ns | 0.0316 ns | 0.0295 ns | 12.491 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.891 ns | 0.0236 ns | 0.0221 ns | 15.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.421 ns | 0.0082 ns | 0.0073 ns | 13.422 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.752 ns | 0.0094 ns | 0.0083 ns | 11.754 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.759 ns | 0.0181 ns | 0.0170 ns | 16.759 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.511 ns | 0.0153 ns | 0.0143 ns | 14.518 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.351 ns | 0.0339 ns | 0.0301 ns | 18.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.762 ns | 0.0117 ns | 0.0109 ns | 13.762 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.979 ns | 0.0789 ns | 0.0738 ns | 13.946 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.141 ns | 0.0356 ns | 0.0333 ns | 18.141 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.112 ns | 0.0224 ns | 0.0199 ns | 18.115 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.423 ns | 0.0289 ns | 0.0270 ns | 19.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.998 ns | 0.0572 ns | 0.0535 ns | 17.982 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.008 ns | 0.0632 ns | 0.0592 ns | 16.021 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 21.139 ns | 0.0497 ns | 0.0440 ns | 21.143 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.951 ns | 0.0443 ns | 0.0414 ns | 19.962 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.046 ns | 0.0149 ns | 0.0139 ns | 15.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.504 ns | 0.0101 ns | 0.0094 ns | 12.506 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.816 ns | 0.1588 ns | 0.1486 ns | 12.887 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.472 ns | 0.0194 ns | 0.0181 ns | 14.470 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.302 ns | 0.0111 ns | 0.0098 ns | 16.302 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.183 ns | 0.0190 ns | 0.0168 ns | 16.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.526 ns | 0.0141 ns | 0.0132 ns | 14.527 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.887 ns | 0.1589 ns | 0.1486 ns | 11.779 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 16.156 ns | 0.0253 ns | 0.0237 ns | 16.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.584 ns | 0.0359 ns | 0.0336 ns | 14.583 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.690 ns | 0.0261 ns | 0.0231 ns | 13.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.779 ns | 0.0305 ns | 0.0286 ns | 11.778 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.420 ns | 0.0137 ns | 0.0128 ns | 11.422 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.581 ns | 0.0189 ns | 0.0167 ns | 13.582 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.009 ns | 0.0355 ns | 0.0332 ns | 14.007 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.518 ns | 0.0215 ns | 0.0179 ns | 17.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.668 ns | 0.0157 ns | 0.0146 ns | 14.672 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.432 ns | 0.1335 ns | 0.1248 ns | 14.474 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.231 ns | 0.0270 ns | 0.0252 ns | 18.240 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.774 ns | 0.0226 ns | 0.0211 ns | 16.777 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.034 ns | 0.0133 ns | 0.0118 ns | 13.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.158 ns | 0.0034 ns | 0.0030 ns | 11.157 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.868 ns | 0.0152 ns | 0.0142 ns | 10.867 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.486 ns | 0.0125 ns | 0.0117 ns | 14.485 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.046 ns | 0.0107 ns | 0.0100 ns | 14.049 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.073 ns | 0.0270 ns | 0.0253 ns | 15.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.271 ns | 0.0411 ns | 0.0365 ns | 14.275 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.759 ns | 0.0235 ns | 0.0219 ns | 11.763 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.405 ns | 0.0313 ns | 0.0293 ns | 14.408 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.501 ns | 0.0373 ns | 0.0349 ns | 14.515 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 21.416 ns | 0.0402 ns | 0.0356 ns | 21.421 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.302 ns | 0.0417 ns | 0.0390 ns | 16.299 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.513 ns | 0.0474 ns | 0.0443 ns | 12.511 ns |  0.58 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.975 ns | 0.0313 ns | 0.0292 ns | 20.973 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 20.894 ns | 0.0337 ns | 0.0315 ns | 20.893 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 20.990 ns | 0.0245 ns | 0.0229 ns | 20.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.723 ns | 0.0144 ns | 0.0128 ns | 16.722 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.015 ns | 0.0589 ns | 0.0551 ns | 17.020 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 20.425 ns | 0.0317 ns | 0.0281 ns | 20.431 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.684 ns | 0.0328 ns | 0.0307 ns | 20.687 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.488 ns | 0.0465 ns | 0.0435 ns | 21.490 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.105 ns | 0.0285 ns | 0.0253 ns | 16.104 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.020 ns | 0.0415 ns | 0.0389 ns | 13.019 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.159 ns | 0.0296 ns | 0.0277 ns | 20.158 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 19.021 ns | 0.0171 ns | 0.0151 ns | 19.024 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.457 ns | 0.0241 ns | 0.0226 ns | 19.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.750 ns | 0.0290 ns | 0.0271 ns | 16.762 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.893 ns | 0.0221 ns | 0.0207 ns | 17.886 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 21.913 ns | 0.0505 ns | 0.0472 ns | 21.925 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.647 ns | 0.0253 ns | 0.0237 ns | 20.649 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.330 ns | 0.0086 ns | 0.0080 ns | 14.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.823 ns | 0.0107 ns | 0.0100 ns | 11.821 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.347 ns | 0.0367 ns | 0.0344 ns |  8.346 ns |  0.58 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.986 ns | 0.0148 ns | 0.0139 ns | 12.988 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.055 ns | 0.0163 ns | 0.0152 ns | 13.055 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.900 ns | 0.0154 ns | 0.0144 ns | 15.901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.368 ns | 0.0197 ns | 0.0184 ns | 13.368 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.722 ns | 0.0279 ns | 0.0261 ns | 13.725 ns |  0.86 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.921 ns | 0.0141 ns | 0.0132 ns | 14.926 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.335 ns | 0.0104 ns | 0.0098 ns | 14.334 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.541 ns | 0.0380 ns | 0.0356 ns | 14.539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.395 ns | 0.0106 ns | 0.0100 ns | 10.399 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.818 ns | 0.1787 ns | 0.2886 ns |  7.961 ns |  0.53 |    0.03 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.800 ns | 0.0364 ns | 0.0341 ns | 13.803 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.236 ns | 0.0142 ns | 0.0133 ns | 13.241 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 20.255 ns | 0.0211 ns | 0.0198 ns | 20.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.667 ns | 0.0161 ns | 0.0142 ns | 14.670 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.021 ns | 0.1650 ns | 0.1543 ns | 13.943 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.146 ns | 0.0177 ns | 0.0165 ns | 17.144 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.003 ns | 0.0203 ns | 0.0180 ns | 17.002 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.848 ns | 0.0154 ns | 0.0136 ns | 13.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.414 ns | 0.0277 ns | 0.0259 ns | 10.408 ns |  0.75 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.259 ns | 0.0150 ns | 0.0141 ns |  7.258 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.962 ns | 0.0132 ns | 0.0124 ns | 12.962 ns |  0.94 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.244 ns | 0.0126 ns | 0.0118 ns | 13.244 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.864 ns | 0.0253 ns | 0.0237 ns | 17.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.697 ns | 0.0344 ns | 0.0305 ns | 14.701 ns |  0.82 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.026 ns | 0.1135 ns | 0.1062 ns | 13.979 ns |  0.79 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.387 ns | 0.0444 ns | 0.0416 ns | 17.402 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.137 ns | 0.0147 ns | 0.0138 ns | 17.138 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.991 ns | 0.0151 ns | 0.0134 ns | 13.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.394 ns | 0.0137 ns | 0.0128 ns | 10.395 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.473 ns | 0.0255 ns | 0.0238 ns |  7.479 ns |  0.53 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.564 ns | 0.0125 ns | 0.0117 ns | 12.566 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.250 ns | 0.0167 ns | 0.0156 ns | 13.252 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 18.592 ns | 0.0236 ns | 0.0221 ns | 18.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 16.291 ns | 0.0363 ns | 0.0340 ns | 16.291 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.372 ns | 0.2844 ns | 0.3892 ns | 13.606 ns |  0.71 |    0.02 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.458 ns | 0.0212 ns | 0.0177 ns | 14.460 ns |  0.78 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.444 ns | 0.0149 ns | 0.0139 ns | 14.444 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.573 ns | 0.0152 ns | 0.0142 ns | 12.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.332 ns | 0.0154 ns | 0.0144 ns | 11.332 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.967 ns | 0.0126 ns | 0.0118 ns |  6.969 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.528 ns | 0.0333 ns | 0.0311 ns | 13.521 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.746 ns | 0.0327 ns | 0.0306 ns | 12.746 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.974 ns | 0.0644 ns | 0.0603 ns | 48.974 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.853 ns | 0.0518 ns | 0.0459 ns | 43.854 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.118 ns | 0.1218 ns | 0.1017 ns | 37.100 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 48.989 ns | 0.0517 ns | 0.0484 ns | 49.002 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 48.179 ns | 0.1634 ns | 0.1529 ns | 48.148 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.709 ns | 0.0210 ns | 0.0197 ns | 12.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.775 ns | 0.0301 ns | 0.0281 ns | 11.767 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.546 ns | 0.1740 ns | 0.2323 ns |  7.698 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.371 ns | 0.0174 ns | 0.0163 ns | 13.369 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.419 ns | 0.0147 ns | 0.0137 ns | 13.422 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.784 ns | 0.2368 ns | 0.2215 ns | 45.832 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.845 ns | 0.0967 ns | 0.0905 ns | 43.853 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 42.666 ns | 0.4331 ns | 0.4051 ns | 42.476 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.068 ns | 0.1098 ns | 0.1027 ns | 50.082 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 48.230 ns | 0.0655 ns | 0.0612 ns | 48.228 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 12.583 ns | 0.0091 ns | 0.0085 ns | 12.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.616 ns | 0.0101 ns | 0.0095 ns | 11.619 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.716 ns | 0.2964 ns | 0.4344 ns |  7.477 ns |  0.63 |    0.04 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.899 ns | 0.0152 ns | 0.0142 ns | 12.901 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.940 ns | 0.0345 ns | 0.0323 ns | 12.952 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.893 ns | 0.0174 ns | 0.0163 ns | 15.892 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.701 ns | 0.0275 ns | 0.0258 ns | 13.708 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.767 ns | 0.0155 ns | 0.0145 ns | 11.766 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.490 ns | 0.0222 ns | 0.0208 ns | 14.496 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.679 ns | 0.0298 ns | 0.0279 ns | 14.682 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.114 ns | 0.0064 ns | 0.0057 ns | 14.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.047 ns | 0.0178 ns | 0.0167 ns | 11.048 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.419 ns | 0.0107 ns | 0.0095 ns | 11.421 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 16.957 ns | 0.0676 ns | 0.0633 ns | 16.940 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.987 ns | 0.0183 ns | 0.0171 ns | 13.991 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.615 ns | 0.0133 ns | 0.0118 ns | 18.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.066 ns | 0.0189 ns | 0.0168 ns | 15.071 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.626 ns | 0.3153 ns | 0.3753 ns | 14.934 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.614 ns | 0.0307 ns | 0.0287 ns | 17.621 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.621 ns | 0.0577 ns | 0.0539 ns | 17.630 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.123 ns | 0.0134 ns | 0.0125 ns | 13.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.868 ns | 0.0286 ns | 0.0253 ns | 10.867 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.941 ns | 0.1329 ns | 0.1243 ns | 10.869 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.685 ns | 0.0181 ns | 0.0169 ns | 13.683 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 13.740 ns | 0.0138 ns | 0.0129 ns | 13.745 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 16.270 ns | 0.0134 ns | 0.0119 ns | 16.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.726 ns | 0.0286 ns | 0.0239 ns | 14.717 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.751 ns | 0.0076 ns | 0.0067 ns | 11.750 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.925 ns | 0.0323 ns | 0.0302 ns | 14.913 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.007 ns | 0.0154 ns | 0.0144 ns | 15.005 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 44.252 ns | 0.0356 ns | 0.0333 ns | 44.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.080 ns | 0.0621 ns | 0.0581 ns | 36.087 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 34.304 ns | 0.0288 ns | 0.0269 ns | 34.305 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.806 ns | 0.0350 ns | 0.0327 ns | 39.805 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 47.208 ns | 0.0529 ns | 0.0469 ns | 47.200 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.882 ns | 0.0275 ns | 0.0257 ns | 17.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.091 ns | 0.0148 ns | 0.0139 ns | 15.092 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.910 ns | 0.0975 ns | 0.0912 ns | 13.872 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.339 ns | 0.0244 ns | 0.0229 ns | 17.340 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.570 ns | 0.0178 ns | 0.0167 ns | 17.567 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 37.799 ns | 0.0313 ns | 0.0293 ns | 37.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.544 ns | 0.0352 ns | 0.0312 ns | 36.551 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.630 ns | 0.1095 ns | 0.1024 ns | 34.657 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.228 ns | 0.1395 ns | 0.1305 ns | 38.268 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.927 ns | 0.0484 ns | 0.0429 ns | 38.941 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.971 ns | 0.0299 ns | 0.0280 ns | 16.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.031 ns | 0.0386 ns | 0.0361 ns | 15.025 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.781 ns | 0.0275 ns | 0.0229 ns | 15.782 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.643 ns | 0.0260 ns | 0.0243 ns | 17.639 ns |  1.04 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.527 ns | 0.0759 ns | 0.0710 ns | 17.527 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 41.557 ns | 0.0533 ns | 0.0473 ns | 41.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 35.901 ns | 0.0572 ns | 0.0535 ns | 35.910 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.382 ns | 0.0540 ns | 0.0505 ns | 38.382 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.528 ns | 0.0380 ns | 0.0337 ns | 39.536 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 47.142 ns | 0.0378 ns | 0.0353 ns | 47.150 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.067 ns | 0.0210 ns | 0.0196 ns | 15.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.297 ns | 0.0100 ns | 0.0093 ns | 14.295 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.693 ns | 0.0149 ns | 0.0139 ns | 13.695 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 15.726 ns | 0.0729 ns | 0.0682 ns | 15.728 ns |  1.04 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 14.589 ns | 0.0170 ns | 0.0159 ns | 14.593 ns |  0.97 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_LongNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_LongNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
