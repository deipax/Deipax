
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
                                             From_Bool | .NET Core 2.0 | 14.559 ns | 0.1456 ns | 0.1362 ns | 14.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.964 ns | 0.0192 ns | 0.0180 ns | 11.965 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.673 ns | 0.2194 ns | 0.4278 ns |  9.780 ns |  0.65 |    0.05 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.190 ns | 0.0249 ns | 0.0233 ns | 13.193 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.246 ns | 0.0174 ns | 0.0145 ns | 13.247 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.923 ns | 0.0265 ns | 0.0235 ns | 19.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.705 ns | 0.0468 ns | 0.0438 ns | 17.708 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.236 ns | 0.0422 ns | 0.0395 ns | 17.224 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 22.089 ns | 0.1808 ns | 0.1509 ns | 22.141 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.194 ns | 0.0667 ns | 0.0624 ns | 20.210 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 15.427 ns | 0.0332 ns | 0.0295 ns | 15.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.400 ns | 0.0190 ns | 0.0178 ns | 11.399 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  9.056 ns | 0.2047 ns | 0.2102 ns |  9.188 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.905 ns | 0.0429 ns | 0.0402 ns | 14.903 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.701 ns | 0.0260 ns | 0.0243 ns | 13.695 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.735 ns | 0.0249 ns | 0.0233 ns | 19.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.406 ns | 0.0392 ns | 0.0306 ns | 17.416 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.401 ns | 0.0907 ns | 0.0804 ns | 20.423 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 20.315 ns | 0.0561 ns | 0.0498 ns | 20.309 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 19.988 ns | 0.0562 ns | 0.0469 ns | 19.981 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 14.885 ns | 0.0268 ns | 0.0251 ns | 14.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.675 ns | 0.0197 ns | 0.0184 ns | 10.677 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.318 ns | 0.0207 ns | 0.0183 ns |  7.313 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.165 ns | 0.0669 ns | 0.0626 ns | 14.151 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.185 ns | 0.0780 ns | 0.0729 ns | 13.197 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.629 ns | 0.0266 ns | 0.0236 ns | 15.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.746 ns | 0.0387 ns | 0.0362 ns | 14.742 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.198 ns | 0.0804 ns | 0.0752 ns | 13.236 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.716 ns | 0.0288 ns | 0.0255 ns | 15.717 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 16.447 ns | 0.0440 ns | 0.0412 ns | 16.442 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 13.059 ns | 0.0156 ns | 0.0130 ns | 13.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.965 ns | 0.0256 ns | 0.0227 ns | 11.969 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.674 ns | 0.0344 ns | 0.0322 ns |  7.686 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.334 ns | 0.0279 ns | 0.0233 ns | 14.336 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 13.130 ns | 0.0131 ns | 0.0116 ns | 13.132 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.417 ns | 0.0339 ns | 0.0317 ns | 20.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.171 ns | 0.2068 ns | 0.1934 ns | 17.102 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.827 ns | 0.0396 ns | 0.0371 ns | 16.816 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.924 ns | 0.1259 ns | 0.1177 ns | 19.859 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 19.764 ns | 0.0219 ns | 0.0204 ns | 19.762 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 14.755 ns | 0.0274 ns | 0.0256 ns | 14.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.179 ns | 0.0703 ns | 0.0658 ns | 11.167 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.709 ns | 0.0436 ns | 0.0340 ns |  7.706 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.689 ns | 0.0252 ns | 0.0236 ns | 14.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.760 ns | 0.0707 ns | 0.0662 ns | 13.773 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.743 ns | 0.0241 ns | 0.0202 ns | 20.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.207 ns | 0.0318 ns | 0.0298 ns | 17.218 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.001 ns | 0.0354 ns | 0.0295 ns | 18.000 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 20.188 ns | 0.0434 ns | 0.0385 ns | 20.182 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 19.940 ns | 0.0372 ns | 0.0330 ns | 19.948 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 13.386 ns | 0.0241 ns | 0.0214 ns | 13.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.674 ns | 0.0189 ns | 0.0167 ns | 10.673 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.873 ns | 0.0341 ns | 0.0303 ns |  7.875 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.761 ns | 0.0334 ns | 0.0296 ns | 14.757 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.998 ns | 0.0249 ns | 0.0221 ns | 12.998 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.634 ns | 0.0327 ns | 0.0306 ns | 15.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.003 ns | 0.0399 ns | 0.0373 ns | 14.007 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.354 ns | 0.1851 ns | 0.1732 ns | 14.233 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.702 ns | 0.0624 ns | 0.0584 ns | 15.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.654 ns | 0.0274 ns | 0.0243 ns | 15.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.024 ns | 0.1124 ns | 0.1052 ns | 12.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.657 ns | 0.0307 ns | 0.0272 ns | 10.644 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.719 ns | 0.0133 ns | 0.0124 ns |  7.723 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.937 ns | 0.0937 ns | 0.0782 ns | 12.964 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.646 ns | 0.0236 ns | 0.0221 ns | 13.641 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.450 ns | 0.0765 ns | 0.0639 ns | 13.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.736 ns | 0.0460 ns | 0.0430 ns | 10.719 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.484 ns | 0.0208 ns | 0.0194 ns |  7.482 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.104 ns | 0.0202 ns | 0.0179 ns | 13.107 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 16.066 ns | 0.0249 ns | 0.0233 ns | 16.062 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 13.398 ns | 0.0914 ns | 0.0855 ns | 13.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.013 ns | 0.0151 ns | 0.0141 ns | 11.010 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  8.208 ns | 0.2722 ns | 0.2795 ns |  8.113 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.139 ns | 0.0192 ns | 0.0180 ns | 13.136 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.677 ns | 0.0228 ns | 0.0202 ns | 13.671 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.745 ns | 0.1182 ns | 0.1105 ns | 15.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.825 ns | 0.0268 ns | 0.0224 ns | 14.818 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.766 ns | 0.5708 ns | 0.8367 ns | 12.298 ns |  0.84 |    0.06 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 17.917 ns | 0.0389 ns | 0.0303 ns | 17.913 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.073 ns | 0.0260 ns | 0.0217 ns | 15.073 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 14.349 ns | 0.1230 ns | 0.1151 ns | 14.272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.592 ns | 0.0875 ns | 0.0818 ns | 11.545 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.202 ns | 0.2673 ns | 0.2745 ns |  8.055 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.293 ns | 0.0324 ns | 0.0271 ns | 13.287 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.740 ns | 0.0281 ns | 0.0249 ns | 13.736 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.221 ns | 0.0851 ns | 0.0796 ns | 13.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.558 ns | 0.0288 ns | 0.0241 ns | 11.551 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.815 ns | 0.0377 ns | 0.0353 ns |  8.806 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.316 ns | 0.0334 ns | 0.0296 ns | 13.326 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.451 ns | 0.1127 ns | 0.0999 ns | 14.475 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.054 ns | 0.0191 ns | 0.0169 ns | 13.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.553 ns | 0.0201 ns | 0.0178 ns | 11.551 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.466 ns | 0.0269 ns | 0.0210 ns |  8.462 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.252 ns | 0.0255 ns | 0.0238 ns | 13.251 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.213 ns | 0.0400 ns | 0.0355 ns | 14.213 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.971 ns | 0.1438 ns | 0.1345 ns | 16.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.842 ns | 0.0626 ns | 0.0585 ns | 15.845 ns |  0.99 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.063 ns | 0.0467 ns | 0.0414 ns | 15.062 ns |  0.94 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 16.754 ns | 0.0258 ns | 0.0216 ns | 16.748 ns |  1.05 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.909 ns | 0.0273 ns | 0.0242 ns | 16.906 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.477 ns | 0.0153 ns | 0.0128 ns | 12.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.521 ns | 0.0194 ns | 0.0172 ns | 11.517 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  8.264 ns | 0.0240 ns | 0.0201 ns |  8.265 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 12.968 ns | 0.0283 ns | 0.0265 ns | 12.960 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 13.155 ns | 0.0728 ns | 0.0608 ns | 13.170 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 15.676 ns | 0.0335 ns | 0.0314 ns | 15.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 15.036 ns | 0.0299 ns | 0.0250 ns | 15.035 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 15.706 ns | 0.0993 ns | 0.0929 ns | 15.745 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 17.395 ns | 0.0354 ns | 0.0314 ns | 17.382 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 15.737 ns | 0.0287 ns | 0.0268 ns | 15.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.878 ns | 0.0105 ns | 0.0098 ns | 12.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 11.783 ns | 0.0161 ns | 0.0134 ns | 11.783 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 10.061 ns | 0.2624 ns | 0.3022 ns | 10.013 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 14.518 ns | 0.1471 ns | 0.1376 ns | 14.453 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.771 ns | 0.0290 ns | 0.0257 ns | 13.777 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.712 ns | 0.0362 ns | 0.0321 ns | 15.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.143 ns | 0.0423 ns | 0.0396 ns | 14.148 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.369 ns | 0.1212 ns | 0.1134 ns | 14.450 ns |  0.92 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 15.332 ns | 0.0332 ns | 0.0310 ns | 15.337 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 15.588 ns | 0.0453 ns | 0.0354 ns | 15.596 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.174 ns | 0.0937 ns | 0.0877 ns | 13.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.286 ns | 0.0408 ns | 0.0382 ns | 12.282 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.756 ns | 0.0379 ns | 0.0354 ns |  8.766 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.371 ns | 0.0287 ns | 0.0254 ns | 14.366 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.927 ns | 0.0172 ns | 0.0134 ns | 13.927 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.593 ns | 0.0121 ns | 0.0101 ns | 15.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.004 ns | 0.0244 ns | 0.0216 ns | 14.003 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.492 ns | 0.1308 ns | 0.1223 ns | 12.508 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 14.813 ns | 0.0187 ns | 0.0175 ns | 14.811 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.018 ns | 0.0210 ns | 0.0197 ns | 15.017 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 65.788 ns | 0.0969 ns | 0.0809 ns | 65.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 60.146 ns | 0.1246 ns | 0.1104 ns | 60.124 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 16.855 ns | 0.1037 ns | 0.0919 ns | 16.887 ns |  0.26 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 63.416 ns | 0.1153 ns | 0.1078 ns | 63.418 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 64.425 ns | 0.1481 ns | 0.1313 ns | 64.392 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 70.718 ns | 0.1142 ns | 0.1012 ns | 70.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 69.747 ns | 0.0652 ns | 0.0578 ns | 69.740 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 25.076 ns | 0.0470 ns | 0.0392 ns | 25.078 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 70.913 ns | 0.6010 ns | 0.5622 ns | 70.884 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 70.732 ns | 0.5337 ns | 0.4992 ns | 70.975 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 64.952 ns | 0.0941 ns | 0.0834 ns | 64.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 60.633 ns | 0.1287 ns | 0.1141 ns | 60.655 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 17.699 ns | 0.3732 ns | 0.5920 ns | 17.310 ns |  0.28 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 63.526 ns | 0.1301 ns | 0.1217 ns | 63.536 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 63.587 ns | 0.1080 ns | 0.0957 ns | 63.590 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 71.211 ns | 0.0899 ns | 0.0751 ns | 71.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 68.758 ns | 0.1283 ns | 0.1200 ns | 68.775 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.032 ns | 0.1558 ns | 0.1301 ns | 27.077 ns |  0.38 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 69.813 ns | 0.1128 ns | 0.1000 ns | 69.801 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 70.522 ns | 0.5933 ns | 0.5550 ns | 70.854 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.195 ns | 0.0255 ns | 0.0239 ns | 14.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.081 ns | 0.0313 ns | 0.0293 ns | 12.088 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.844 ns | 0.2215 ns | 0.2957 ns |  9.944 ns |  0.69 |    0.03 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.446 ns | 0.0271 ns | 0.0226 ns | 13.442 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.329 ns | 0.0161 ns | 0.0151 ns | 14.329 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.450 ns | 0.0328 ns | 0.0307 ns | 16.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.002 ns | 0.0233 ns | 0.0194 ns | 14.000 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.523 ns | 0.0447 ns | 0.0397 ns | 12.531 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 16.400 ns | 0.0569 ns | 0.0475 ns | 16.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.870 ns | 0.0187 ns | 0.0157 ns | 14.869 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 14.266 ns | 0.0148 ns | 0.0131 ns | 14.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.822 ns | 0.0550 ns | 0.0514 ns | 10.833 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.914 ns | 0.0555 ns | 0.0519 ns |  7.934 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.112 ns | 0.1541 ns | 0.1441 ns | 13.037 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.285 ns | 0.1164 ns | 0.1089 ns | 13.341 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.141 ns | 0.0436 ns | 0.0408 ns | 21.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.591 ns | 0.0234 ns | 0.0219 ns | 17.599 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.248 ns | 0.0424 ns | 0.0376 ns | 17.253 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.803 ns | 0.0435 ns | 0.0407 ns | 21.794 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.176 ns | 0.0283 ns | 0.0265 ns | 20.168 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 15.383 ns | 0.0472 ns | 0.0418 ns | 15.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.580 ns | 0.0274 ns | 0.0229 ns | 11.575 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.855 ns | 0.2416 ns | 0.4936 ns | 10.969 ns |  0.68 |    0.06 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.625 ns | 0.0343 ns | 0.0321 ns | 14.624 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.923 ns | 0.1258 ns | 0.1177 ns | 13.880 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.662 ns | 0.0580 ns | 0.0543 ns | 20.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.999 ns | 0.0627 ns | 0.0556 ns | 18.997 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.850 ns | 0.0459 ns | 0.0383 ns | 18.852 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 20.444 ns | 0.0331 ns | 0.0294 ns | 20.431 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.234 ns | 0.0740 ns | 0.0656 ns | 20.223 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 14.230 ns | 0.0281 ns | 0.0263 ns | 14.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.929 ns | 0.0563 ns | 0.0526 ns | 10.914 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  8.089 ns | 0.1849 ns | 0.2985 ns |  8.225 ns |  0.56 |    0.03 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.257 ns | 0.0204 ns | 0.0181 ns | 13.258 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.141 ns | 0.0301 ns | 0.0252 ns | 13.145 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.747 ns | 0.0501 ns | 0.0391 ns | 15.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.826 ns | 0.0178 ns | 0.0157 ns | 14.829 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.162 ns | 0.3088 ns | 0.4716 ns | 14.354 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.846 ns | 0.0194 ns | 0.0182 ns | 14.845 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.903 ns | 0.1036 ns | 0.0919 ns | 14.868 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 14.645 ns | 0.0516 ns | 0.0483 ns | 14.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.916 ns | 0.0847 ns | 0.0792 ns | 10.946 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.715 ns | 0.0249 ns | 0.0220 ns |  7.710 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.687 ns | 0.1438 ns | 0.1345 ns | 13.759 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.211 ns | 0.0422 ns | 0.0395 ns | 13.205 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.205 ns | 0.0419 ns | 0.0371 ns | 20.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.570 ns | 0.0430 ns | 0.0403 ns | 17.573 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.884 ns | 0.0490 ns | 0.0434 ns | 16.892 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.866 ns | 0.2258 ns | 0.2112 ns | 21.733 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.051 ns | 0.0246 ns | 0.0230 ns | 20.057 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 15.405 ns | 0.0182 ns | 0.0170 ns | 15.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.178 ns | 0.0281 ns | 0.0263 ns | 11.172 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.507 ns | 0.1435 ns | 0.1342 ns |  8.588 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.771 ns | 0.0429 ns | 0.0402 ns | 13.766 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.070 ns | 0.0267 ns | 0.0223 ns | 14.073 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.173 ns | 0.0503 ns | 0.0470 ns | 20.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.315 ns | 0.0184 ns | 0.0173 ns | 17.316 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.030 ns | 0.1399 ns | 0.1308 ns | 18.062 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.917 ns | 0.0461 ns | 0.0431 ns | 19.911 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 19.879 ns | 0.0353 ns | 0.0313 ns | 19.878 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.841 ns | 0.0195 ns | 0.0173 ns | 14.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.182 ns | 0.0184 ns | 0.0163 ns | 11.182 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.151 ns | 0.2062 ns | 0.4612 ns |  9.285 ns |  0.59 |    0.06 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.019 ns | 0.1414 ns | 0.1322 ns | 13.956 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.329 ns | 0.1201 ns | 0.1123 ns | 13.392 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.858 ns | 0.0269 ns | 0.0239 ns | 15.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.005 ns | 0.0273 ns | 0.0255 ns | 15.007 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.605 ns | 0.3877 ns | 0.5175 ns | 12.324 ns |  0.81 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 16.969 ns | 0.0316 ns | 0.0280 ns | 16.962 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.055 ns | 0.0225 ns | 0.0188 ns | 15.061 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.872 ns | 0.0256 ns | 0.0239 ns | 12.870 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.081 ns | 0.0263 ns | 0.0219 ns | 11.081 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.704 ns | 0.0145 ns | 0.0121 ns |  7.700 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.268 ns | 0.1362 ns | 0.1274 ns | 13.198 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.169 ns | 0.0169 ns | 0.0149 ns | 13.165 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.614 ns | 0.0354 ns | 0.0331 ns | 20.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.759 ns | 0.0882 ns | 0.0825 ns | 17.774 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.210 ns | 0.3790 ns | 0.4654 ns | 18.518 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 20.266 ns | 0.0276 ns | 0.0259 ns | 20.264 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.006 ns | 0.0209 ns | 0.0196 ns | 20.004 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.545 ns | 0.0258 ns | 0.0229 ns | 14.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.849 ns | 0.0509 ns | 0.0451 ns | 11.836 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  9.164 ns | 0.0344 ns | 0.0322 ns |  9.173 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.691 ns | 0.0284 ns | 0.0266 ns | 13.690 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.799 ns | 0.1182 ns | 0.1105 ns | 13.864 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.372 ns | 0.0336 ns | 0.0315 ns | 20.360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.871 ns | 0.0416 ns | 0.0368 ns | 18.860 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.159 ns | 0.0376 ns | 0.0333 ns | 17.153 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 20.323 ns | 0.0303 ns | 0.0284 ns | 20.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 22.209 ns | 0.0303 ns | 0.0236 ns | 22.201 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.743 ns | 0.0239 ns | 0.0224 ns | 12.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.818 ns | 0.0120 ns | 0.0106 ns | 11.819 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.645 ns | 0.0141 ns | 0.0118 ns |  9.645 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.085 ns | 0.0234 ns | 0.0196 ns | 13.080 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.346 ns | 0.0240 ns | 0.0212 ns | 13.343 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.052 ns | 0.0378 ns | 0.0354 ns | 16.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.733 ns | 0.0284 ns | 0.0252 ns | 14.727 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.083 ns | 0.0347 ns | 0.0324 ns | 15.081 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 16.462 ns | 0.0430 ns | 0.0402 ns | 16.461 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.799 ns | 0.0206 ns | 0.0193 ns | 15.800 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.901 ns | 0.0502 ns | 0.0469 ns | 12.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.942 ns | 0.0256 ns | 0.0227 ns | 10.946 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.553 ns | 0.0220 ns | 0.0172 ns |  7.556 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.957 ns | 0.1010 ns | 0.0789 ns | 13.978 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 14.377 ns | 0.1479 ns | 0.1383 ns | 14.450 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.823 ns | 0.0452 ns | 0.0423 ns | 20.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.487 ns | 0.0255 ns | 0.0239 ns | 17.486 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.119 ns | 0.0438 ns | 0.0410 ns | 17.112 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 19.703 ns | 0.0324 ns | 0.0287 ns | 19.710 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.196 ns | 0.0300 ns | 0.0234 ns | 20.188 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 14.753 ns | 0.0208 ns | 0.0173 ns | 14.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.133 ns | 0.0181 ns | 0.0169 ns | 11.128 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.187 ns | 0.0175 ns | 0.0155 ns |  8.186 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.899 ns | 0.0345 ns | 0.0323 ns | 13.895 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.530 ns | 0.0169 ns | 0.0141 ns | 13.528 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.926 ns | 0.1552 ns | 0.1451 ns | 20.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.426 ns | 0.0347 ns | 0.0290 ns | 17.432 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.984 ns | 0.0525 ns | 0.0466 ns | 16.977 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 20.420 ns | 0.1009 ns | 0.0788 ns | 20.435 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.169 ns | 0.0271 ns | 0.0253 ns | 20.164 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.322 ns | 0.0197 ns | 0.0154 ns | 14.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.712 ns | 0.0154 ns | 0.0144 ns | 10.711 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.056 ns | 0.1247 ns | 0.1167 ns |  7.996 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.400 ns | 0.0301 ns | 0.0267 ns | 13.397 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.064 ns | 0.0380 ns | 0.0336 ns | 13.065 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.654 ns | 0.0537 ns | 0.0503 ns | 15.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.052 ns | 0.0677 ns | 0.0634 ns | 14.057 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.947 ns | 0.2841 ns | 0.3594 ns | 13.159 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.860 ns | 0.0394 ns | 0.0369 ns | 14.850 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.910 ns | 0.0772 ns | 0.0645 ns | 14.901 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 33.340 ns | 0.1336 ns | 0.1249 ns | 33.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 29.015 ns | 0.1200 ns | 0.1122 ns | 28.985 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 15.660 ns | 0.0267 ns | 0.0237 ns | 15.653 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 33.959 ns | 0.0589 ns | 0.0551 ns | 33.974 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 33.935 ns | 0.1473 ns | 0.1378 ns | 33.950 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 39.662 ns | 0.0811 ns | 0.0719 ns | 39.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 37.476 ns | 0.1028 ns | 0.0859 ns | 37.469 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 25.952 ns | 0.1463 ns | 0.1368 ns | 26.005 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 39.155 ns | 0.0405 ns | 0.0359 ns | 39.150 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 39.741 ns | 0.0809 ns | 0.0757 ns | 39.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 33.231 ns | 0.1366 ns | 0.1211 ns | 33.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 28.879 ns | 0.0788 ns | 0.0658 ns | 28.900 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 16.405 ns | 0.0339 ns | 0.0300 ns | 16.403 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 32.678 ns | 0.1264 ns | 0.1182 ns | 32.706 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 32.717 ns | 0.1081 ns | 0.1011 ns | 32.726 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 39.680 ns | 0.0420 ns | 0.0350 ns | 39.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 37.362 ns | 0.0600 ns | 0.0532 ns | 37.360 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 25.133 ns | 0.0346 ns | 0.0307 ns | 25.124 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 39.704 ns | 0.0726 ns | 0.0679 ns | 39.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 39.731 ns | 0.1810 ns | 0.1693 ns | 39.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.510 ns | 0.0220 ns | 0.0206 ns | 14.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.924 ns | 0.0327 ns | 0.0306 ns | 10.929 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.926 ns | 0.0554 ns | 0.0518 ns |  7.945 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.360 ns | 0.1664 ns | 0.1556 ns | 13.393 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 14.367 ns | 0.0189 ns | 0.0147 ns | 14.368 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.660 ns | 0.1009 ns | 0.0944 ns | 15.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.814 ns | 0.0386 ns | 0.0302 ns | 14.824 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.194 ns | 0.0426 ns | 0.0378 ns | 14.199 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.844 ns | 0.0192 ns | 0.0180 ns | 14.844 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.891 ns | 0.0377 ns | 0.0315 ns | 14.890 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 84.025 ns | 0.1139 ns | 0.1010 ns | 84.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 77.482 ns | 0.1699 ns | 0.1506 ns | 77.427 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 58.968 ns | 0.2781 ns | 0.2601 ns | 59.020 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 85.649 ns | 0.1231 ns | 0.1092 ns | 85.663 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 85.164 ns | 0.4529 ns | 0.4015 ns | 85.233 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 91.350 ns | 0.2175 ns | 0.2035 ns | 91.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 86.341 ns | 0.1986 ns | 0.1857 ns | 86.315 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 66.151 ns | 0.2916 ns | 0.2728 ns | 66.228 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 92.419 ns | 0.8850 ns | 0.8278 ns | 92.739 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 90.744 ns | 0.1516 ns | 0.1418 ns | 90.716 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.549 ns | 0.0106 ns | 0.0094 ns | 13.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.820 ns | 0.0668 ns | 0.0625 ns | 12.798 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.265 ns | 0.0616 ns | 0.0546 ns | 12.267 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 16.195 ns | 0.0380 ns | 0.0355 ns | 16.187 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 13.973 ns | 0.0416 ns | 0.0348 ns | 13.972 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 17.058 ns | 0.0365 ns | 0.0324 ns | 17.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.274 ns | 0.0202 ns | 0.0189 ns | 14.276 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.571 ns | 0.1001 ns | 0.0937 ns | 12.595 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.846 ns | 0.0255 ns | 0.0239 ns | 14.852 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.058 ns | 0.0459 ns | 0.0383 ns | 15.064 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.998 ns | 0.0291 ns | 0.0258 ns | 13.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.916 ns | 0.0377 ns | 0.0352 ns | 12.917 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.360 ns | 0.0585 ns | 0.0547 ns | 12.374 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 15.422 ns | 0.0193 ns | 0.0181 ns | 15.429 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.099 ns | 0.0210 ns | 0.0196 ns | 14.101 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 14.384 ns | 0.0341 ns | 0.0319 ns | 14.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.654 ns | 0.0152 ns | 0.0127 ns | 10.656 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.311 ns | 0.0103 ns | 0.0086 ns |  7.310 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.000 ns | 0.0210 ns | 0.0186 ns | 13.001 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.338 ns | 0.0564 ns | 0.0528 ns | 13.351 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.582 ns | 0.0378 ns | 0.0335 ns | 20.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.568 ns | 0.0313 ns | 0.0293 ns | 17.559 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.934 ns | 0.1935 ns | 0.1810 ns | 17.940 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.309 ns | 0.0732 ns | 0.0612 ns | 20.306 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.148 ns | 0.1651 ns | 0.1544 ns | 20.081 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 15.176 ns | 0.0399 ns | 0.0353 ns | 15.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.229 ns | 0.0286 ns | 0.0267 ns | 11.224 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  8.368 ns | 0.0763 ns | 0.0713 ns |  8.330 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.017 ns | 0.0939 ns | 0.0784 ns | 14.024 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 14.039 ns | 0.0695 ns | 0.0650 ns | 14.050 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.104 ns | 0.0244 ns | 0.0228 ns | 21.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.608 ns | 0.0305 ns | 0.0285 ns | 17.607 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.989 ns | 0.1089 ns | 0.1019 ns | 16.948 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 20.332 ns | 0.0416 ns | 0.0389 ns | 20.333 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.156 ns | 0.0567 ns | 0.0503 ns | 20.175 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.179 ns | 0.0195 ns | 0.0182 ns | 14.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.938 ns | 0.0199 ns | 0.0156 ns | 10.933 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  8.049 ns | 0.0150 ns | 0.0140 ns |  8.047 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.173 ns | 0.1389 ns | 0.1300 ns | 14.119 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.230 ns | 0.0578 ns | 0.0541 ns | 13.224 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.598 ns | 0.0432 ns | 0.0383 ns | 15.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.254 ns | 0.0346 ns | 0.0307 ns | 14.257 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.306 ns | 0.1267 ns | 0.1185 ns | 13.244 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 17.202 ns | 0.0434 ns | 0.0384 ns | 17.198 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.914 ns | 0.0292 ns | 0.0273 ns | 14.911 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.592 ns | 0.0157 ns | 0.0140 ns | 12.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.041 ns | 0.0305 ns | 0.0270 ns | 11.039 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.356 ns | 0.0187 ns | 0.0175 ns |  7.352 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.151 ns | 0.1338 ns | 0.1186 ns | 13.088 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.042 ns | 0.1074 ns | 0.0952 ns | 12.995 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.424 ns | 0.0358 ns | 0.0299 ns | 20.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.254 ns | 0.0181 ns | 0.0160 ns | 17.260 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.626 ns | 0.0468 ns | 0.0415 ns | 17.616 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.159 ns | 0.0458 ns | 0.0428 ns | 21.160 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 19.670 ns | 0.1204 ns | 0.1068 ns | 19.644 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 15.182 ns | 0.1046 ns | 0.0979 ns | 15.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.163 ns | 0.0224 ns | 0.0198 ns | 11.160 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.069 ns | 0.0329 ns | 0.0292 ns |  8.060 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.727 ns | 0.0382 ns | 0.0339 ns | 13.733 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 16.034 ns | 0.0287 ns | 0.0254 ns | 16.034 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.427 ns | 0.0336 ns | 0.0298 ns | 20.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.191 ns | 0.0305 ns | 0.0270 ns | 17.188 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.238 ns | 0.1347 ns | 0.1260 ns | 18.273 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 20.212 ns | 0.0202 ns | 0.0189 ns | 20.211 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 19.715 ns | 0.0344 ns | 0.0305 ns | 19.714 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 14.280 ns | 0.0361 ns | 0.0320 ns | 14.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.042 ns | 0.0153 ns | 0.0143 ns | 11.044 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  8.408 ns | 0.0174 ns | 0.0163 ns |  8.406 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.329 ns | 0.0246 ns | 0.0230 ns | 14.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.999 ns | 0.0994 ns | 0.0930 ns | 14.025 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.511 ns | 0.0291 ns | 0.0258 ns | 16.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.877 ns | 0.0441 ns | 0.0413 ns | 14.890 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.438 ns | 0.1038 ns | 0.0971 ns | 15.492 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.878 ns | 0.0251 ns | 0.0235 ns | 14.879 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 14.927 ns | 0.0249 ns | 0.0221 ns | 14.921 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.840 ns | 0.0212 ns | 0.0188 ns | 12.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.656 ns | 0.0282 ns | 0.0236 ns | 10.654 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.581 ns | 0.0283 ns | 0.0251 ns |  7.578 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.256 ns | 0.1619 ns | 0.1514 ns | 13.326 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.263 ns | 0.0951 ns | 0.0843 ns | 13.291 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 23.507 ns | 0.0353 ns | 0.0295 ns | 23.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.881 ns | 0.0366 ns | 0.0305 ns | 16.872 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.795 ns | 0.0241 ns | 0.0225 ns | 16.797 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.734 ns | 0.0246 ns | 0.0206 ns | 19.731 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.853 ns | 0.0416 ns | 0.0389 ns | 19.847 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.130 ns | 0.0529 ns | 0.0442 ns | 14.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.742 ns | 0.0561 ns | 0.0469 ns | 11.732 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.320 ns | 0.7000 ns | 0.9345 ns |  9.809 ns |  0.76 |    0.08 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.516 ns | 0.0556 ns | 0.0493 ns | 13.498 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.565 ns | 0.0457 ns | 0.0428 ns | 13.556 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.509 ns | 0.1012 ns | 0.0897 ns | 20.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.731 ns | 0.0316 ns | 0.0296 ns | 16.728 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.855 ns | 0.1127 ns | 0.1055 ns | 16.802 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 22.325 ns | 0.0403 ns | 0.0377 ns | 22.329 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.777 ns | 0.0238 ns | 0.0186 ns | 19.771 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.185 ns | 0.0367 ns | 0.0287 ns | 14.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.582 ns | 0.0412 ns | 0.0365 ns | 11.570 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 10.479 ns | 0.5393 ns | 0.7200 ns | 10.088 ns |  0.77 |    0.06 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.105 ns | 0.0258 ns | 0.0228 ns | 13.108 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.877 ns | 0.1034 ns | 0.0967 ns | 14.908 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.620 ns | 0.0265 ns | 0.0235 ns | 15.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.934 ns | 0.0180 ns | 0.0169 ns | 14.934 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.705 ns | 0.0976 ns | 0.0913 ns | 14.746 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.913 ns | 0.0368 ns | 0.0344 ns | 14.920 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.630 ns | 0.0367 ns | 0.0286 ns | 15.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.600 ns | 0.0311 ns | 0.0291 ns | 15.595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.999 ns | 0.0251 ns | 0.0234 ns | 14.003 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.909 ns | 0.6893 ns | 0.8206 ns | 12.471 ns |  0.84 |    0.06 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 16.763 ns | 0.0324 ns | 0.0287 ns | 16.757 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 14.885 ns | 0.0353 ns | 0.0330 ns | 14.895 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.572 ns | 0.0262 ns | 0.0219 ns | 12.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 10.210 ns | 0.0185 ns | 0.0155 ns | 10.203 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.643 ns | 0.0255 ns | 0.0213 ns | 12.642 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 14.297 ns | 0.0384 ns | 0.0359 ns | 14.300 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.383 ns | 0.0268 ns | 0.0251 ns | 12.380 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.612 ns | 0.0322 ns | 0.0286 ns | 15.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.026 ns | 0.0299 ns | 0.0250 ns | 14.020 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.140 ns | 0.2856 ns | 0.4927 ns | 13.411 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 15.380 ns | 0.0357 ns | 0.0334 ns | 15.369 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.039 ns | 0.0432 ns | 0.0383 ns | 16.030 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.486 ns | 0.0352 ns | 0.0329 ns | 17.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.171 ns | 0.0219 ns | 0.0183 ns | 14.171 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.172 ns | 0.3055 ns | 0.3137 ns | 13.961 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.731 ns | 0.1209 ns | 0.1072 ns | 17.685 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.653 ns | 0.0499 ns | 0.0467 ns | 17.638 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.542 ns | 0.0302 ns | 0.0268 ns | 19.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.700 ns | 0.0485 ns | 0.0430 ns | 16.715 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.739 ns | 0.1869 ns | 0.1749 ns | 15.744 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 18.918 ns | 0.0311 ns | 0.0291 ns | 18.918 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.811 ns | 0.0807 ns | 0.0755 ns | 18.822 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.813 ns | 0.0131 ns | 0.0122 ns | 14.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.869 ns | 0.0313 ns | 0.0278 ns | 12.864 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.913 ns | 0.0859 ns | 0.0717 ns | 12.934 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 16.230 ns | 0.0263 ns | 0.0246 ns | 16.225 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.363 ns | 0.0387 ns | 0.0362 ns | 16.356 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.452 ns | 0.0380 ns | 0.0337 ns | 16.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 15.070 ns | 0.0134 ns | 0.0126 ns | 15.072 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.440 ns | 0.0393 ns | 0.0348 ns | 12.444 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 16.797 ns | 0.0347 ns | 0.0271 ns | 16.794 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.853 ns | 0.1302 ns | 0.1218 ns | 14.786 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.378 ns | 0.0503 ns | 0.0446 ns | 13.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.359 ns | 0.0117 ns | 0.0104 ns | 11.360 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.226 ns | 0.1265 ns | 0.1183 ns | 11.146 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.187 ns | 0.0474 ns | 0.0443 ns | 15.175 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.657 ns | 0.0405 ns | 0.0359 ns | 14.669 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.992 ns | 0.0324 ns | 0.0253 ns | 16.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.816 ns | 0.0327 ns | 0.0306 ns | 15.819 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.196 ns | 0.0350 ns | 0.0310 ns | 15.195 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.199 ns | 0.0239 ns | 0.0224 ns | 16.203 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.343 ns | 0.0377 ns | 0.0353 ns | 16.331 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.340 ns | 0.0291 ns | 0.0272 ns | 13.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.574 ns | 0.0128 ns | 0.0113 ns | 11.575 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.115 ns | 0.0944 ns | 0.0883 ns | 11.060 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 16.634 ns | 0.0209 ns | 0.0175 ns | 16.634 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.542 ns | 0.0669 ns | 0.0593 ns | 14.558 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.141 ns | 0.0643 ns | 0.0537 ns | 16.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.961 ns | 0.0225 ns | 0.0211 ns | 14.961 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.295 ns | 0.0948 ns | 0.0887 ns | 13.297 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 16.428 ns | 0.0278 ns | 0.0260 ns | 16.437 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.649 ns | 0.0311 ns | 0.0276 ns | 15.643 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 22.019 ns | 0.0368 ns | 0.0344 ns | 22.012 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.616 ns | 0.0508 ns | 0.0450 ns | 16.610 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.877 ns | 0.3029 ns | 0.3367 ns | 13.645 ns |  0.63 |    0.02 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.901 ns | 0.0732 ns | 0.0649 ns | 19.883 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 20.050 ns | 0.1429 ns | 0.1337 ns | 20.005 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.069 ns | 0.0367 ns | 0.0325 ns | 19.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.765 ns | 0.0219 ns | 0.0183 ns | 16.759 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.037 ns | 0.2264 ns | 0.1890 ns | 16.976 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 21.069 ns | 0.1988 ns | 0.1859 ns | 21.024 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.607 ns | 0.0347 ns | 0.0324 ns | 19.610 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.563 ns | 0.1628 ns | 0.1523 ns | 21.508 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.099 ns | 0.0335 ns | 0.0297 ns | 17.097 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.515 ns | 0.3112 ns | 0.4936 ns | 14.194 ns |  0.70 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.830 ns | 0.0555 ns | 0.0492 ns | 20.817 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 22.590 ns | 0.2151 ns | 0.2012 ns | 22.512 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.247 ns | 0.0398 ns | 0.0332 ns | 19.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.968 ns | 0.0599 ns | 0.0531 ns | 16.954 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.940 ns | 0.0478 ns | 0.0447 ns | 20.936 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.975 ns | 0.0398 ns | 0.0352 ns | 20.978 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.644 ns | 0.0259 ns | 0.0242 ns | 19.634 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.171 ns | 0.0450 ns | 0.0421 ns | 15.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.563 ns | 0.0197 ns | 0.0154 ns | 13.565 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.329 ns | 0.0258 ns | 0.0215 ns |  8.329 ns |  0.55 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.425 ns | 0.0202 ns | 0.0189 ns | 13.420 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.263 ns | 0.0444 ns | 0.0394 ns | 13.251 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.611 ns | 0.0310 ns | 0.0258 ns | 15.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.007 ns | 0.0138 ns | 0.0122 ns | 14.011 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.211 ns | 0.0518 ns | 0.0485 ns | 14.218 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.492 ns | 0.0596 ns | 0.0498 ns | 16.491 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.878 ns | 0.0266 ns | 0.0249 ns | 14.872 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.157 ns | 0.0101 ns | 0.0090 ns | 14.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.004 ns | 0.0182 ns | 0.0171 ns | 12.000 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.597 ns | 0.0899 ns | 0.0702 ns |  7.618 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.518 ns | 0.0349 ns | 0.0326 ns | 13.513 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 13.736 ns | 0.0581 ns | 0.0543 ns | 13.757 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.727 ns | 0.0308 ns | 0.0289 ns | 16.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 17.150 ns | 0.0541 ns | 0.0480 ns | 17.137 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.152 ns | 0.1424 ns | 0.1262 ns | 16.197 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.259 ns | 0.0406 ns | 0.0380 ns | 16.255 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.157 ns | 0.0362 ns | 0.0339 ns | 17.155 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.169 ns | 0.0558 ns | 0.0522 ns | 14.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.259 ns | 0.0164 ns | 0.0137 ns | 12.258 ns |  0.86 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.468 ns | 0.0260 ns | 0.0217 ns |  7.464 ns |  0.53 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.565 ns | 0.0298 ns | 0.0278 ns | 13.561 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.520 ns | 0.0228 ns | 0.0202 ns | 13.518 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.565 ns | 0.0240 ns | 0.0213 ns | 16.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.808 ns | 0.0272 ns | 0.0227 ns | 15.807 ns |  0.95 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.626 ns | 0.3136 ns | 0.4077 ns | 14.966 ns |  0.87 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.231 ns | 0.0315 ns | 0.0294 ns | 16.237 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.476 ns | 0.0599 ns | 0.0531 ns | 16.483 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.135 ns | 0.0298 ns | 0.0279 ns | 15.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.416 ns | 0.0164 ns | 0.0145 ns | 13.415 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.463 ns | 0.0184 ns | 0.0163 ns |  7.466 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.990 ns | 0.0993 ns | 0.0829 ns | 13.025 ns |  0.86 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 14.349 ns | 0.0241 ns | 0.0225 ns | 14.345 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.469 ns | 0.1271 ns | 0.1189 ns | 16.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.841 ns | 0.0189 ns | 0.0158 ns | 14.840 ns |  0.90 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.183 ns | 0.0529 ns | 0.0469 ns | 14.179 ns |  0.86 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.448 ns | 0.0249 ns | 0.0233 ns | 16.447 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.938 ns | 0.0198 ns | 0.0185 ns | 14.934 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.432 ns | 0.0184 ns | 0.0163 ns | 14.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.231 ns | 0.0167 ns | 0.0156 ns | 12.231 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.721 ns | 0.0279 ns | 0.0248 ns |  7.723 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.930 ns | 0.0285 ns | 0.0253 ns | 13.928 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.286 ns | 0.0265 ns | 0.0248 ns | 13.289 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.904 ns | 0.1419 ns | 0.1258 ns | 47.906 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 46.259 ns | 0.1260 ns | 0.1052 ns | 46.221 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.891 ns | 0.4750 ns | 0.4443 ns | 38.038 ns |  0.79 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 47.499 ns | 0.3365 ns | 0.3148 ns | 47.380 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 47.349 ns | 0.1257 ns | 0.1115 ns | 47.317 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.632 ns | 0.0531 ns | 0.0497 ns | 15.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.933 ns | 0.0175 ns | 0.0155 ns | 11.934 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.570 ns | 0.6023 ns | 0.8040 ns |  8.124 ns |  0.57 |    0.06 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.051 ns | 0.0407 ns | 0.0381 ns | 14.042 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.951 ns | 0.0224 ns | 0.0210 ns | 13.951 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 47.120 ns | 0.0845 ns | 0.0706 ns | 47.093 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.656 ns | 0.0899 ns | 0.0797 ns | 42.641 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 42.438 ns | 0.3350 ns | 0.3133 ns | 42.542 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 45.511 ns | 0.2078 ns | 0.1622 ns | 45.555 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 46.023 ns | 0.0915 ns | 0.0811 ns | 46.025 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.363 ns | 0.0486 ns | 0.0455 ns | 14.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.747 ns | 0.0216 ns | 0.0191 ns | 12.753 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.388 ns | 0.0389 ns | 0.0325 ns |  7.393 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 15.257 ns | 0.0297 ns | 0.0277 ns | 15.261 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.321 ns | 0.0107 ns | 0.0090 ns | 13.322 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.036 ns | 0.0367 ns | 0.0306 ns | 16.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.992 ns | 0.0222 ns | 0.0197 ns | 13.992 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.446 ns | 0.0613 ns | 0.0573 ns | 13.421 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 15.467 ns | 0.0323 ns | 0.0302 ns | 15.468 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.914 ns | 0.0270 ns | 0.0253 ns | 14.910 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.375 ns | 0.0203 ns | 0.0169 ns | 13.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.528 ns | 0.0532 ns | 0.0497 ns | 11.540 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.226 ns | 0.0714 ns | 0.0668 ns | 11.247 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.805 ns | 0.0199 ns | 0.0167 ns | 13.802 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.946 ns | 0.0177 ns | 0.0166 ns | 13.951 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.337 ns | 0.0256 ns | 0.0240 ns | 18.333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.313 ns | 0.0266 ns | 0.0236 ns | 15.313 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.349 ns | 0.3133 ns | 0.4784 ns | 14.075 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.285 ns | 0.0131 ns | 0.0109 ns | 17.286 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.681 ns | 0.0277 ns | 0.0259 ns | 16.680 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.558 ns | 0.0601 ns | 0.0562 ns | 13.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.959 ns | 0.0980 ns | 0.0869 ns | 11.989 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.792 ns | 0.0231 ns | 0.0193 ns | 11.789 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.378 ns | 0.0964 ns | 0.0902 ns | 15.331 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.104 ns | 0.0244 ns | 0.0204 ns | 14.096 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.617 ns | 0.0212 ns | 0.0188 ns | 15.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.151 ns | 0.1365 ns | 0.1210 ns | 14.126 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 16.942 ns | 0.1191 ns | 0.1114 ns | 16.979 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.854 ns | 0.0192 ns | 0.0160 ns | 14.851 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.932 ns | 0.0255 ns | 0.0238 ns | 14.924 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 40.074 ns | 0.0876 ns | 0.0820 ns | 40.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.004 ns | 0.2568 ns | 0.2276 ns | 39.005 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.333 ns | 0.0590 ns | 0.0523 ns | 35.353 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.361 ns | 0.0623 ns | 0.0582 ns | 41.362 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 42.126 ns | 0.0765 ns | 0.0715 ns | 42.107 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.735 ns | 0.1097 ns | 0.1026 ns | 18.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.255 ns | 0.0632 ns | 0.0591 ns | 15.248 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.024 ns | 0.0658 ns | 0.0583 ns | 14.023 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 18.221 ns | 0.0284 ns | 0.0222 ns | 18.231 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 16.871 ns | 0.0314 ns | 0.0278 ns | 16.874 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.569 ns | 0.0845 ns | 0.0706 ns | 40.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.821 ns | 0.1073 ns | 0.1004 ns | 38.790 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.637 ns | 0.7781 ns | 1.1405 ns | 39.009 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 43.325 ns | 0.1669 ns | 0.1561 ns | 43.291 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 46.539 ns | 0.0747 ns | 0.0662 ns | 46.533 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.473 ns | 0.0316 ns | 0.0264 ns | 18.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.005 ns | 0.0211 ns | 0.0197 ns | 16.005 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.150 ns | 0.1129 ns | 0.1056 ns | 14.191 ns |  0.77 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.491 ns | 0.0135 ns | 0.0119 ns | 16.493 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 16.574 ns | 0.0270 ns | 0.0225 ns | 16.567 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.313 ns | 0.1190 ns | 0.1113 ns | 40.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.117 ns | 0.1025 ns | 0.0959 ns | 39.128 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.369 ns | 0.1225 ns | 0.1023 ns | 36.375 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.016 ns | 0.3388 ns | 0.3169 ns | 38.839 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 43.205 ns | 0.1058 ns | 0.0990 ns | 43.209 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.519 ns | 0.0423 ns | 0.0353 ns | 16.519 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.832 ns | 0.0263 ns | 0.0246 ns | 14.839 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.605 ns | 0.0908 ns | 0.0805 ns | 16.617 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 16.529 ns | 0.0271 ns | 0.0211 ns | 16.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.332 ns | 0.0222 ns | 0.0208 ns | 15.325 ns |  0.93 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Decimal.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Decimal.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
