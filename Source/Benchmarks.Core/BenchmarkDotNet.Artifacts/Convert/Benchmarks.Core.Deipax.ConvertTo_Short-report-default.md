
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
                                             From_Bool | .NET Core 2.0 | 11.673 ns | 0.1261 ns | 0.1118 ns | 11.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.711 ns | 0.0812 ns | 0.0760 ns | 11.705 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.830 ns | 0.0128 ns | 0.0114 ns |  6.832 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.194 ns | 0.0118 ns | 0.0099 ns | 12.194 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.398 ns | 0.0177 ns | 0.0157 ns | 10.396 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 22.115 ns | 0.0537 ns | 0.0476 ns | 22.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.447 ns | 0.1128 ns | 0.1000 ns | 16.470 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.870 ns | 0.0457 ns | 0.0428 ns | 17.890 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 20.764 ns | 0.0285 ns | 0.0253 ns | 20.766 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.406 ns | 0.0414 ns | 0.0367 ns | 20.420 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.205 ns | 0.2725 ns | 0.2549 ns | 13.281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.631 ns | 0.0724 ns | 0.0642 ns | 10.631 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.602 ns | 0.0210 ns | 0.0196 ns |  7.600 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.517 ns | 0.0579 ns | 0.0542 ns | 12.536 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.746 ns | 0.0175 ns | 0.0164 ns | 10.746 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.255 ns | 0.0637 ns | 0.0596 ns | 18.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.556 ns | 0.1098 ns | 0.0974 ns | 15.559 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.591 ns | 0.0297 ns | 0.0263 ns | 15.590 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.761 ns | 0.0396 ns | 0.0370 ns | 18.761 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.426 ns | 0.0304 ns | 0.0269 ns | 20.431 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.674 ns | 0.1202 ns | 0.1065 ns | 12.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.213 ns | 0.1060 ns | 0.0991 ns | 10.226 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.066 ns | 0.0165 ns | 0.0154 ns |  7.064 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.717 ns | 0.0207 ns | 0.0183 ns | 11.708 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.430 ns | 0.0131 ns | 0.0116 ns | 10.431 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.501 ns | 0.2344 ns | 0.2193 ns | 15.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.873 ns | 0.0185 ns | 0.0173 ns | 11.873 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.507 ns | 0.0294 ns | 0.0275 ns | 12.499 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.315 ns | 0.0227 ns | 0.0202 ns | 13.323 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 16.119 ns | 0.0200 ns | 0.0177 ns | 16.120 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.639 ns | 0.1590 ns | 0.1410 ns | 11.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.034 ns | 0.0048 ns | 0.0040 ns | 10.033 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.372 ns | 0.0114 ns | 0.0101 ns |  6.371 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.512 ns | 0.0094 ns | 0.0083 ns | 12.512 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.767 ns | 0.0189 ns | 0.0168 ns | 10.769 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.210 ns | 0.0713 ns | 0.0667 ns | 18.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.963 ns | 0.0305 ns | 0.0255 ns | 15.956 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.306 ns | 0.0367 ns | 0.0343 ns | 15.305 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.931 ns | 0.0309 ns | 0.0289 ns | 18.926 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.053 ns | 0.0273 ns | 0.0242 ns | 20.052 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.470 ns | 0.2783 ns | 0.2858 ns | 13.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.326 ns | 0.0191 ns | 0.0169 ns | 10.322 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.914 ns | 0.0283 ns | 0.0251 ns |  6.906 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.267 ns | 0.0803 ns | 0.0670 ns | 12.243 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.538 ns | 0.0131 ns | 0.0109 ns | 10.536 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.561 ns | 0.1652 ns | 0.1465 ns | 18.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.982 ns | 0.0205 ns | 0.0171 ns | 14.982 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.180 ns | 0.0538 ns | 0.0504 ns | 15.190 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.761 ns | 0.0319 ns | 0.0283 ns | 18.767 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.154 ns | 0.1054 ns | 0.0986 ns | 20.117 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.351 ns | 0.0637 ns | 0.0596 ns | 12.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.116 ns | 0.0103 ns | 0.0080 ns | 10.113 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.895 ns | 0.0085 ns | 0.0075 ns |  6.895 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.550 ns | 0.1232 ns | 0.1029 ns | 12.525 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.993 ns | 0.0751 ns | 0.0702 ns | 10.946 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.285 ns | 0.2616 ns | 0.2447 ns | 15.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.857 ns | 0.0089 ns | 0.0083 ns | 11.856 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.247 ns | 0.4197 ns | 0.6152 ns | 11.907 ns |  0.82 |    0.06 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.715 ns | 0.2880 ns | 0.3537 ns | 13.582 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 14.887 ns | 0.0225 ns | 0.0200 ns | 14.899 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.081 ns | 0.2552 ns | 0.1992 ns | 13.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.270 ns | 0.0130 ns | 0.0121 ns | 10.272 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.471 ns | 0.0231 ns | 0.0205 ns |  6.472 ns |  0.49 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.526 ns | 0.0599 ns | 0.0501 ns | 13.526 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                             From_Char |        net472 | 11.046 ns | 0.0144 ns | 0.0135 ns | 11.045 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.631 ns | 0.3924 ns | 0.3854 ns | 20.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.080 ns | 0.0497 ns | 0.0465 ns | 16.082 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.582 ns | 0.0496 ns | 0.0464 ns | 15.575 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 21.695 ns | 0.0570 ns | 0.0534 ns | 21.689 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 20.496 ns | 0.0267 ns | 0.0249 ns | 20.499 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.204 ns | 0.0862 ns | 0.0764 ns | 12.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.412 ns | 0.0142 ns | 0.0133 ns | 10.412 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.260 ns | 0.0236 ns | 0.0220 ns |  7.267 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.195 ns | 0.0386 ns | 0.0342 ns | 14.199 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.180 ns | 0.0227 ns | 0.0202 ns | 12.172 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.956 ns | 0.4241 ns | 0.5515 ns | 19.682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.944 ns | 0.0240 ns | 0.0224 ns | 15.936 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.554 ns | 0.0427 ns | 0.0400 ns | 15.563 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 19.324 ns | 0.0741 ns | 0.0693 ns | 19.313 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 22.388 ns | 0.0262 ns | 0.0219 ns | 22.387 ns |  1.11 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.753 ns | 0.1046 ns | 0.0873 ns | 11.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.180 ns | 0.0073 ns | 0.0068 ns | 10.182 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.069 ns | 0.0135 ns | 0.0126 ns |  7.070 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.691 ns | 0.1135 ns | 0.1006 ns | 12.662 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.416 ns | 0.0161 ns | 0.0143 ns | 10.412 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.163 ns | 0.0962 ns | 0.0803 ns | 15.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.689 ns | 0.0146 ns | 0.0122 ns | 13.691 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.440 ns | 0.0167 ns | 0.0156 ns | 13.444 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 16.185 ns | 0.0522 ns | 0.0463 ns | 16.177 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.848 ns | 0.0184 ns | 0.0163 ns | 15.843 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.036 ns | 0.2573 ns | 0.2527 ns | 11.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.931 ns | 0.0335 ns | 0.0314 ns | 10.933 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.383 ns | 0.1932 ns | 0.2147 ns |  8.259 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.349 ns | 0.0633 ns | 0.0592 ns | 14.342 ns |  1.19 |    0.03 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.813 ns | 0.0217 ns | 0.0203 ns | 11.810 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.567 ns | 0.0374 ns | 0.0332 ns | 12.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.069 ns | 0.0183 ns | 0.0172 ns | 11.064 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  7.969 ns | 0.0151 ns | 0.0141 ns |  7.971 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.321 ns | 0.0503 ns | 0.0420 ns | 14.320 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.664 ns | 0.0851 ns | 0.0796 ns | 12.638 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.617 ns | 0.0789 ns | 0.0659 ns | 12.600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.039 ns | 0.0173 ns | 0.0153 ns | 11.034 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.010 ns | 0.0615 ns | 0.0576 ns |  7.979 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.321 ns | 0.1599 ns | 0.1417 ns | 14.299 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.238 ns | 0.0150 ns | 0.0141 ns | 13.236 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.052 ns | 0.0121 ns | 0.0101 ns | 14.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.180 ns | 0.0151 ns | 0.0141 ns | 12.179 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.893 ns | 0.0113 ns | 0.0105 ns | 11.894 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.410 ns | 0.0572 ns | 0.0535 ns | 13.395 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.914 ns | 0.0420 ns | 0.0351 ns | 14.907 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.912 ns | 0.1912 ns | 0.1789 ns | 25.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.990 ns | 0.0245 ns | 0.0229 ns | 23.991 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.743 ns | 0.0816 ns | 0.0763 ns | 13.698 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 27.412 ns | 0.1472 ns | 0.1305 ns | 27.381 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.530 ns | 0.1321 ns | 0.1235 ns | 24.591 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.829 ns | 0.1047 ns | 0.0979 ns | 26.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.454 ns | 0.1483 ns | 0.1388 ns | 25.512 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.897 ns | 0.0181 ns | 0.0141 ns | 22.898 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 29.005 ns | 0.1621 ns | 0.1516 ns | 29.017 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.915 ns | 0.0506 ns | 0.0473 ns | 27.908 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.335 ns | 0.0396 ns | 0.0370 ns | 25.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.683 ns | 0.0317 ns | 0.0281 ns | 23.679 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.120 ns | 0.0518 ns | 0.0485 ns | 18.123 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.923 ns | 0.0923 ns | 0.0771 ns | 26.923 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.201 ns | 0.0173 ns | 0.0162 ns | 25.205 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.779 ns | 0.1113 ns | 0.1041 ns | 27.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.502 ns | 0.0473 ns | 0.0419 ns | 25.486 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.424 ns | 0.2881 ns | 0.2695 ns | 21.411 ns |  0.77 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 31.221 ns | 0.0799 ns | 0.0708 ns | 31.199 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.991 ns | 0.0390 ns | 0.0346 ns | 27.983 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.672 ns | 0.0536 ns | 0.0501 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.388 ns | 0.0138 ns | 0.0115 ns | 11.392 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.144 ns | 0.1734 ns | 0.1622 ns |  8.047 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.629 ns | 0.0812 ns | 0.0760 ns | 14.611 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.373 ns | 0.0145 ns | 0.0121 ns | 15.378 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.082 ns | 0.0250 ns | 0.0234 ns | 14.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.954 ns | 0.0126 ns | 0.0118 ns | 11.950 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.621 ns | 0.0094 ns | 0.0088 ns | 12.621 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.363 ns | 0.0231 ns | 0.0205 ns | 13.364 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 14.898 ns | 0.0133 ns | 0.0124 ns | 14.895 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.209 ns | 0.0902 ns | 0.0704 ns | 13.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.156 ns | 0.0128 ns | 0.0120 ns | 12.153 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.059 ns | 0.1867 ns | 0.1746 ns | 10.193 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.956 ns | 0.1898 ns | 0.1775 ns | 15.984 ns |  1.21 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.037 ns | 0.0604 ns | 0.0565 ns | 14.009 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.384 ns | 0.0890 ns | 0.0832 ns | 21.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 16.801 ns | 0.0375 ns | 0.0351 ns | 16.801 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.027 ns | 0.0341 ns | 0.0319 ns | 18.027 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.923 ns | 0.0633 ns | 0.0529 ns | 20.916 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 22.138 ns | 0.0467 ns | 0.0437 ns | 22.138 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.249 ns | 0.0510 ns | 0.0477 ns | 15.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.558 ns | 0.0411 ns | 0.0364 ns | 14.550 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.467 ns | 0.2954 ns | 0.5251 ns | 13.718 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.158 ns | 0.1040 ns | 0.0921 ns | 17.153 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.867 ns | 0.0340 ns | 0.0318 ns | 16.859 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.625 ns | 0.0708 ns | 0.0663 ns | 20.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.167 ns | 0.0260 ns | 0.0244 ns | 17.155 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.567 ns | 0.0403 ns | 0.0336 ns | 18.562 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.927 ns | 0.0375 ns | 0.0313 ns | 20.924 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.198 ns | 0.0533 ns | 0.0499 ns | 22.185 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.471 ns | 0.0286 ns | 0.0254 ns | 12.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.395 ns | 0.0097 ns | 0.0091 ns | 11.395 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.955 ns | 0.0125 ns | 0.0111 ns |  7.956 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.110 ns | 0.0307 ns | 0.0272 ns | 14.104 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.688 ns | 0.0166 ns | 0.0155 ns | 12.687 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.306 ns | 0.0484 ns | 0.0453 ns | 15.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.869 ns | 0.0100 ns | 0.0088 ns | 11.871 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.322 ns | 0.1697 ns | 0.1587 ns | 12.454 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.855 ns | 0.1008 ns | 0.0894 ns | 14.858 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.978 ns | 0.0630 ns | 0.0589 ns | 15.003 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.488 ns | 0.0138 ns | 0.0129 ns | 11.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.084 ns | 0.0136 ns | 0.0114 ns | 10.083 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.793 ns | 0.0787 ns | 0.0697 ns |  6.805 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 11.888 ns | 0.1066 ns | 0.0998 ns | 11.828 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.337 ns | 0.0136 ns | 0.0127 ns | 10.337 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 14.775 ns | 0.0263 ns | 0.0246 ns | 14.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 12.483 ns | 0.0079 ns | 0.0074 ns | 12.482 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 12.471 ns | 0.2646 ns | 0.3346 ns | 12.616 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 16.730 ns | 0.0542 ns | 0.0507 ns | 16.734 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 16.400 ns | 0.0211 ns | 0.0197 ns | 16.399 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.781 ns | 0.0134 ns | 0.0112 ns | 11.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.210 ns | 0.0163 ns | 0.0145 ns | 10.211 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.604 ns | 0.0119 ns | 0.0112 ns |  6.603 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 11.359 ns | 0.0601 ns | 0.0562 ns | 11.373 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.523 ns | 0.0182 ns | 0.0161 ns | 10.519 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.641 ns | 0.0319 ns | 0.0283 ns | 15.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.522 ns | 0.0136 ns | 0.0127 ns | 12.520 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.154 ns | 0.1378 ns | 0.1289 ns | 13.144 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 14.819 ns | 0.0908 ns | 0.0849 ns | 14.815 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 15.794 ns | 0.0680 ns | 0.0636 ns | 15.763 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.617 ns | 0.0127 ns | 0.0119 ns | 11.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  9.990 ns | 0.0214 ns | 0.0178 ns |  9.986 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.896 ns | 0.0195 ns | 0.0162 ns |  6.903 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.044 ns | 0.1547 ns | 0.1447 ns | 11.972 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.287 ns | 0.0143 ns | 0.0134 ns | 10.290 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.933 ns | 0.0283 ns | 0.0265 ns | 14.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.876 ns | 0.0071 ns | 0.0059 ns | 11.876 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.375 ns | 0.2692 ns | 0.2765 ns | 12.537 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.387 ns | 0.1429 ns | 0.1337 ns | 13.325 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.836 ns | 0.0156 ns | 0.0146 ns | 15.838 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.979 ns | 0.0260 ns | 0.0243 ns | 11.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.473 ns | 0.0127 ns | 0.0106 ns | 10.476 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.533 ns | 0.0140 ns | 0.0124 ns |  7.534 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.021 ns | 0.0443 ns | 0.0414 ns | 13.008 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.776 ns | 0.0173 ns | 0.0162 ns | 10.773 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.341 ns | 0.0664 ns | 0.0588 ns | 19.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.811 ns | 0.0292 ns | 0.0273 ns | 15.801 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.053 ns | 0.0438 ns | 0.0410 ns | 16.059 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.775 ns | 0.1870 ns | 0.1749 ns | 19.690 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.978 ns | 0.0214 ns | 0.0200 ns | 20.982 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.687 ns | 0.0638 ns | 0.0533 ns | 12.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.738 ns | 0.0097 ns | 0.0086 ns | 11.739 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 11.019 ns | 0.2414 ns | 0.2259 ns | 11.101 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.271 ns | 0.0537 ns | 0.0502 ns | 13.269 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.139 ns | 0.0116 ns | 0.0108 ns | 12.142 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.168 ns | 0.1839 ns | 0.1630 ns | 19.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.547 ns | 0.0239 ns | 0.0224 ns | 16.545 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.480 ns | 0.2319 ns | 0.2169 ns | 16.569 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.427 ns | 0.0452 ns | 0.0401 ns | 19.439 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.238 ns | 0.0352 ns | 0.0312 ns | 21.234 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.918 ns | 0.1408 ns | 0.1248 ns | 11.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.499 ns | 0.0149 ns | 0.0139 ns | 10.495 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.093 ns | 0.3323 ns | 0.3956 ns |  6.883 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.285 ns | 0.0366 ns | 0.0342 ns | 12.286 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.976 ns | 0.0563 ns | 0.0527 ns | 11.994 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.027 ns | 0.0650 ns | 0.0576 ns | 15.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.768 ns | 0.0820 ns | 0.0767 ns | 12.817 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.194 ns | 0.2649 ns | 0.4278 ns | 12.365 ns |  0.79 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.434 ns | 0.0478 ns | 0.0424 ns | 13.434 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 14.894 ns | 0.0197 ns | 0.0174 ns | 14.891 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.983 ns | 0.0813 ns | 0.0720 ns | 11.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.608 ns | 0.0377 ns | 0.0352 ns | 10.618 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.305 ns | 0.0096 ns | 0.0085 ns |  7.305 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.468 ns | 0.0376 ns | 0.0314 ns | 13.460 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.896 ns | 0.0163 ns | 0.0152 ns | 10.890 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.498 ns | 0.0302 ns | 0.0252 ns | 18.497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.295 ns | 0.0636 ns | 0.0564 ns | 16.309 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.087 ns | 0.1001 ns | 0.0937 ns | 16.136 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.652 ns | 0.0484 ns | 0.0429 ns | 19.653 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.745 ns | 0.0123 ns | 0.0109 ns | 20.749 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.339 ns | 0.1017 ns | 0.0901 ns | 14.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.040 ns | 0.0136 ns | 0.0121 ns | 13.039 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.186 ns | 0.0098 ns | 0.0092 ns | 10.188 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.623 ns | 0.0577 ns | 0.0539 ns | 15.616 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.929 ns | 0.0295 ns | 0.0246 ns | 13.933 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.847 ns | 0.1393 ns | 0.1235 ns | 18.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.169 ns | 0.0249 ns | 0.0221 ns | 16.167 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.047 ns | 0.0417 ns | 0.0390 ns | 16.029 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 22.331 ns | 0.1152 ns | 0.1021 ns | 22.361 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.144 ns | 0.0344 ns | 0.0322 ns | 21.151 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.518 ns | 0.0613 ns | 0.0544 ns | 12.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.433 ns | 0.0096 ns | 0.0085 ns | 11.435 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.187 ns | 0.2094 ns | 0.4417 ns |  9.338 ns |  0.70 |    0.06 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.324 ns | 0.1235 ns | 0.1155 ns | 14.371 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.719 ns | 0.0146 ns | 0.0129 ns | 12.715 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.061 ns | 0.0963 ns | 0.0804 ns | 14.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.527 ns | 0.0123 ns | 0.0115 ns | 13.527 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.939 ns | 0.0106 ns | 0.0094 ns | 11.936 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.443 ns | 0.0325 ns | 0.0304 ns | 13.448 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.866 ns | 0.0183 ns | 0.0171 ns | 15.866 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.541 ns | 0.0989 ns | 0.0826 ns | 11.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.050 ns | 0.0094 ns | 0.0088 ns | 10.052 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.407 ns | 0.0338 ns | 0.0282 ns |  6.392 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.924 ns | 0.0356 ns | 0.0278 ns | 11.929 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.311 ns | 0.0118 ns | 0.0105 ns | 10.313 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 17.933 ns | 0.0636 ns | 0.0563 ns | 17.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 14.702 ns | 0.0121 ns | 0.0113 ns | 14.703 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.317 ns | 0.0516 ns | 0.0482 ns | 15.316 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.990 ns | 0.0642 ns | 0.0601 ns | 18.992 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.191 ns | 0.0665 ns | 0.0622 ns | 20.207 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.862 ns | 0.0614 ns | 0.0574 ns | 11.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.335 ns | 0.0177 ns | 0.0157 ns | 10.331 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.184 ns | 0.0837 ns | 0.0783 ns |  7.139 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.195 ns | 0.0339 ns | 0.0301 ns | 13.192 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.544 ns | 0.0092 ns | 0.0081 ns | 10.543 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.390 ns | 0.0361 ns | 0.0338 ns | 18.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.119 ns | 0.0263 ns | 0.0246 ns | 15.113 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.308 ns | 0.0233 ns | 0.0206 ns | 15.308 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.242 ns | 0.0910 ns | 0.0760 ns | 19.247 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.047 ns | 0.0182 ns | 0.0171 ns | 20.045 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.800 ns | 0.0770 ns | 0.0683 ns | 11.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.213 ns | 0.0366 ns | 0.0343 ns | 10.219 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.884 ns | 0.0090 ns | 0.0080 ns |  6.882 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.594 ns | 0.0406 ns | 0.0380 ns | 12.597 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.227 ns | 0.0164 ns | 0.0153 ns | 12.223 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.059 ns | 0.0968 ns | 0.0905 ns | 15.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.873 ns | 0.0111 ns | 0.0104 ns | 11.872 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.968 ns | 0.0550 ns | 0.0514 ns | 11.983 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 15.989 ns | 0.0652 ns | 0.0610 ns | 15.978 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.883 ns | 0.0146 ns | 0.0130 ns | 14.886 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.904 ns | 0.0749 ns | 0.0664 ns | 13.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.155 ns | 0.0158 ns | 0.0132 ns | 12.153 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.087 ns | 0.0147 ns | 0.0130 ns | 10.089 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.982 ns | 0.0438 ns | 0.0388 ns | 15.993 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.312 ns | 0.0806 ns | 0.0754 ns | 14.347 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.107 ns | 0.1072 ns | 0.1003 ns | 21.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.432 ns | 0.0364 ns | 0.0304 ns | 17.426 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.452 ns | 0.0403 ns | 0.0357 ns | 18.453 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.203 ns | 0.1632 ns | 0.1446 ns | 21.133 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 22.162 ns | 0.0254 ns | 0.0237 ns | 22.158 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.324 ns | 0.0399 ns | 0.0354 ns | 14.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 14.688 ns | 0.0696 ns | 0.0651 ns | 14.663 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.360 ns | 0.0146 ns | 0.0130 ns | 10.360 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.357 ns | 0.1097 ns | 0.0972 ns | 15.333 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.609 ns | 0.0160 ns | 0.0134 ns | 14.606 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.439 ns | 0.1293 ns | 0.1210 ns | 21.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.466 ns | 0.0211 ns | 0.0198 ns | 17.466 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.574 ns | 0.0994 ns | 0.0930 ns | 18.577 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.196 ns | 0.0346 ns | 0.0323 ns | 21.194 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 22.805 ns | 0.0299 ns | 0.0280 ns | 22.810 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.719 ns | 0.0478 ns | 0.0424 ns | 11.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.169 ns | 0.0092 ns | 0.0086 ns | 10.168 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.097 ns | 0.0085 ns | 0.0080 ns |  7.098 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.663 ns | 0.0286 ns | 0.0254 ns | 12.658 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.422 ns | 0.0163 ns | 0.0136 ns | 10.423 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.047 ns | 0.0551 ns | 0.0489 ns | 15.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.953 ns | 0.0202 ns | 0.0189 ns | 11.955 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.362 ns | 0.2154 ns | 0.2015 ns | 12.503 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.825 ns | 0.2666 ns | 0.2963 ns | 13.716 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.022 ns | 0.0869 ns | 0.0813 ns | 14.971 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.666 ns | 0.1952 ns | 0.1826 ns | 58.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 52.470 ns | 0.0761 ns | 0.0636 ns | 52.464 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 19.288 ns | 0.4111 ns | 0.5048 ns | 19.289 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.259 ns | 0.3429 ns | 0.3207 ns | 58.232 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 58.963 ns | 0.1852 ns | 0.1732 ns | 59.003 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.862 ns | 0.1608 ns | 0.1425 ns | 64.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 60.665 ns | 0.3334 ns | 0.3119 ns | 60.549 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 22.865 ns | 0.4603 ns | 0.4305 ns | 23.136 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.272 ns | 0.1694 ns | 0.1502 ns | 63.239 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 63.866 ns | 0.1072 ns | 0.0951 ns | 63.866 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.367 ns | 0.0413 ns | 0.0387 ns | 13.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.615 ns | 0.0165 ns | 0.0154 ns | 11.611 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.115 ns | 0.2521 ns | 0.2589 ns | 12.247 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 13.057 ns | 0.0912 ns | 0.0761 ns | 13.035 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.566 ns | 0.0482 ns | 0.0451 ns | 14.569 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.019 ns | 0.0873 ns | 0.0816 ns | 15.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.879 ns | 0.0165 ns | 0.0154 ns | 11.879 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.852 ns | 0.2785 ns | 0.4082 ns | 13.066 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 16.031 ns | 0.0607 ns | 0.0538 ns | 16.022 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 14.890 ns | 0.0168 ns | 0.0157 ns | 14.892 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.679 ns | 0.0571 ns | 0.0535 ns | 12.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.472 ns | 0.0308 ns | 0.0288 ns | 11.478 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.747 ns | 0.0197 ns | 0.0184 ns | 11.744 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.131 ns | 0.0729 ns | 0.0646 ns | 13.127 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.099 ns | 0.0295 ns | 0.0261 ns | 16.097 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.953 ns | 0.1314 ns | 0.1164 ns | 12.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.299 ns | 0.0209 ns | 0.0196 ns | 10.294 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.617 ns | 0.0084 ns | 0.0070 ns |  6.616 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.395 ns | 0.0310 ns | 0.0275 ns | 13.396 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.833 ns | 0.0117 ns | 0.0104 ns | 10.832 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.697 ns | 0.0390 ns | 0.0345 ns | 18.702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.370 ns | 0.0530 ns | 0.0496 ns | 15.380 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.265 ns | 0.0382 ns | 0.0357 ns | 15.263 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.031 ns | 0.1455 ns | 0.1215 ns | 19.960 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.627 ns | 0.0747 ns | 0.0624 ns | 21.610 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.012 ns | 0.0451 ns | 0.0399 ns | 11.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.479 ns | 0.0082 ns | 0.0076 ns | 10.481 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.153 ns | 0.0128 ns | 0.0113 ns |  7.151 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.184 ns | 0.0372 ns | 0.0310 ns | 14.189 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.171 ns | 0.0135 ns | 0.0119 ns | 12.171 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.513 ns | 0.1159 ns | 0.1084 ns | 18.545 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.707 ns | 0.0237 ns | 0.0222 ns | 15.702 ns |  0.85 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.252 ns | 0.0254 ns | 0.0226 ns | 15.247 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 22.443 ns | 0.0477 ns | 0.0398 ns | 22.435 ns |  1.21 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.469 ns | 0.0742 ns | 0.0694 ns | 21.482 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.668 ns | 0.0540 ns | 0.0505 ns | 11.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.189 ns | 0.0140 ns | 0.0124 ns | 10.185 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.878 ns | 0.0231 ns | 0.0216 ns |  6.875 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.018 ns | 0.0756 ns | 0.0670 ns | 12.030 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.752 ns | 0.0958 ns | 0.0896 ns | 10.758 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.029 ns | 0.0145 ns | 0.0113 ns | 15.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.880 ns | 0.0220 ns | 0.0195 ns | 11.874 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.224 ns | 0.0166 ns | 0.0147 ns | 11.221 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.874 ns | 0.0353 ns | 0.0313 ns | 14.876 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.889 ns | 0.0157 ns | 0.0139 ns | 14.883 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.868 ns | 0.0532 ns | 0.0498 ns | 11.867 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.860 ns | 0.0186 ns | 0.0174 ns | 10.855 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.075 ns | 0.0129 ns | 0.0115 ns |  7.077 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.338 ns | 0.0674 ns | 0.0598 ns | 13.311 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.713 ns | 0.0173 ns | 0.0153 ns | 10.712 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.558 ns | 0.0417 ns | 0.0390 ns | 18.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.800 ns | 0.0304 ns | 0.0269 ns | 15.803 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.960 ns | 0.0291 ns | 0.0272 ns | 15.956 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.617 ns | 0.0853 ns | 0.0798 ns | 19.627 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.137 ns | 0.0144 ns | 0.0128 ns | 21.135 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.421 ns | 0.0512 ns | 0.0479 ns | 12.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.900 ns | 0.0099 ns | 0.0088 ns | 11.901 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.484 ns | 0.1933 ns | 0.2226 ns |  8.315 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.252 ns | 0.0405 ns | 0.0359 ns | 13.250 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.042 ns | 0.0189 ns | 0.0158 ns | 12.040 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.551 ns | 0.0307 ns | 0.0272 ns | 18.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.874 ns | 0.0340 ns | 0.0301 ns | 15.868 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.158 ns | 0.0437 ns | 0.0409 ns | 16.151 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 22.127 ns | 0.2388 ns | 0.2233 ns | 22.166 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.164 ns | 0.0259 ns | 0.0242 ns | 21.160 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.813 ns | 0.0733 ns | 0.0685 ns | 11.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.155 ns | 0.0613 ns | 0.0573 ns | 10.118 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.702 ns | 0.0232 ns | 0.0217 ns |  6.694 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.981 ns | 0.2239 ns | 0.1985 ns | 11.911 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.814 ns | 0.0059 ns | 0.0052 ns | 11.816 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.067 ns | 0.0228 ns | 0.0213 ns | 14.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.869 ns | 0.0155 ns | 0.0145 ns | 11.865 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.331 ns | 0.1411 ns | 0.1320 ns | 11.233 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.563 ns | 0.2298 ns | 0.2037 ns | 13.606 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.949 ns | 0.0599 ns | 0.0560 ns | 15.964 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.950 ns | 0.0185 ns | 0.0173 ns | 11.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.434 ns | 0.0200 ns | 0.0187 ns | 10.434 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.088 ns | 0.0399 ns | 0.0373 ns |  7.073 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.651 ns | 0.0401 ns | 0.0375 ns | 12.661 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.639 ns | 0.0194 ns | 0.0172 ns | 10.636 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.389 ns | 0.0218 ns | 0.0204 ns | 19.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.617 ns | 0.0191 ns | 0.0170 ns | 15.614 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.959 ns | 0.0352 ns | 0.0312 ns | 15.958 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.483 ns | 0.0433 ns | 0.0405 ns | 19.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 20.802 ns | 0.1025 ns | 0.0908 ns | 20.769 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.586 ns | 0.0336 ns | 0.0298 ns | 13.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.128 ns | 0.0373 ns | 0.0349 ns | 13.121 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.480 ns | 0.2263 ns | 0.2324 ns | 10.642 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.140 ns | 0.0138 ns | 0.0123 ns | 15.138 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.767 ns | 0.0228 ns | 0.0202 ns | 13.762 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.388 ns | 0.0408 ns | 0.0362 ns | 20.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.981 ns | 0.0142 ns | 0.0133 ns | 15.980 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.172 ns | 0.0676 ns | 0.0632 ns | 18.180 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.552 ns | 0.0376 ns | 0.0352 ns | 19.550 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 20.980 ns | 0.0353 ns | 0.0331 ns | 20.984 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.332 ns | 0.0112 ns | 0.0099 ns | 13.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.339 ns | 0.0102 ns | 0.0080 ns | 11.338 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.945 ns | 0.2059 ns | 0.3144 ns |  9.044 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.408 ns | 0.0330 ns | 0.0309 ns | 13.399 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.301 ns | 0.0189 ns | 0.0177 ns | 14.295 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.077 ns | 0.0548 ns | 0.0512 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.536 ns | 0.0129 ns | 0.0121 ns | 13.534 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.470 ns | 0.0922 ns | 0.0862 ns | 13.491 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.247 ns | 0.0129 ns | 0.0121 ns | 13.247 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.912 ns | 0.0519 ns | 0.0486 ns | 14.904 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.977 ns | 0.0671 ns | 0.0627 ns | 14.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.514 ns | 0.0129 ns | 0.0120 ns | 13.511 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.915 ns | 0.0124 ns | 0.0103 ns | 11.915 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.211 ns | 0.0275 ns | 0.0243 ns | 13.215 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.921 ns | 0.0627 ns | 0.0556 ns | 15.930 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.701 ns | 0.0134 ns | 0.0112 ns | 11.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 10.628 ns | 0.0127 ns | 0.0113 ns | 10.627 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.261 ns | 0.6041 ns | 1.0893 ns | 11.656 ns |  1.16 |    0.09 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.008 ns | 0.0239 ns | 0.0212 ns | 11.008 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.696 ns | 0.0157 ns | 0.0146 ns | 12.695 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.107 ns | 0.0219 ns | 0.0194 ns | 14.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.874 ns | 0.0096 ns | 0.0080 ns | 11.875 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.956 ns | 0.0480 ns | 0.0449 ns | 11.942 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 15.857 ns | 0.0377 ns | 0.0353 ns | 15.854 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.066 ns | 0.1000 ns | 0.0935 ns | 16.007 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 14.912 ns | 0.0169 ns | 0.0158 ns | 14.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.258 ns | 0.0068 ns | 0.0061 ns | 13.258 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.804 ns | 0.0130 ns | 0.0122 ns | 12.801 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.766 ns | 0.0307 ns | 0.0272 ns | 16.772 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.784 ns | 0.0434 ns | 0.0406 ns | 16.786 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.527 ns | 0.0778 ns | 0.0728 ns | 16.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.649 ns | 0.0174 ns | 0.0163 ns | 14.644 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.617 ns | 0.0499 ns | 0.0466 ns | 16.631 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.716 ns | 0.0466 ns | 0.0436 ns | 16.714 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.672 ns | 0.1216 ns | 0.1137 ns | 18.603 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.049 ns | 0.0485 ns | 0.0453 ns | 13.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.389 ns | 0.0118 ns | 0.0105 ns | 12.389 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.103 ns | 0.1678 ns | 0.1569 ns | 12.182 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.107 ns | 0.0230 ns | 0.0204 ns | 13.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.093 ns | 0.0217 ns | 0.0203 ns | 13.093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.977 ns | 0.0149 ns | 0.0139 ns | 14.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.890 ns | 0.0084 ns | 0.0075 ns | 11.890 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.204 ns | 0.0088 ns | 0.0078 ns | 11.205 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.234 ns | 0.0194 ns | 0.0182 ns | 13.232 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 16.478 ns | 0.0182 ns | 0.0171 ns | 16.477 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.948 ns | 0.0265 ns | 0.0248 ns | 11.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.120 ns | 0.0098 ns | 0.0082 ns | 11.119 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.249 ns | 0.0158 ns | 0.0148 ns | 11.249 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.414 ns | 0.0382 ns | 0.0338 ns | 12.422 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.571 ns | 0.0772 ns | 0.0722 ns | 12.531 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.154 ns | 0.0657 ns | 0.0614 ns | 15.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.190 ns | 0.0166 ns | 0.0138 ns | 14.191 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.575 ns | 0.0249 ns | 0.0233 ns | 13.569 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.023 ns | 0.0413 ns | 0.0386 ns | 15.034 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.574 ns | 0.0235 ns | 0.0208 ns | 16.573 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.918 ns | 0.0605 ns | 0.0537 ns | 11.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.130 ns | 0.0115 ns | 0.0108 ns | 11.132 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.038 ns | 0.0192 ns | 0.0180 ns | 11.033 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.533 ns | 0.0586 ns | 0.0548 ns | 12.523 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.701 ns | 0.0176 ns | 0.0147 ns | 12.703 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.197 ns | 0.0621 ns | 0.0580 ns | 14.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.286 ns | 0.0349 ns | 0.0291 ns | 14.290 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.490 ns | 0.0621 ns | 0.0581 ns | 13.503 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.311 ns | 0.0215 ns | 0.0179 ns | 13.308 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.175 ns | 0.0388 ns | 0.0324 ns | 15.183 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.636 ns | 0.0625 ns | 0.0584 ns | 19.626 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.044 ns | 0.0381 ns | 0.0338 ns | 16.048 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.518 ns | 0.1108 ns | 0.0865 ns | 12.488 ns |  0.64 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.426 ns | 0.0410 ns | 0.0364 ns | 19.423 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.565 ns | 0.0554 ns | 0.0518 ns | 18.561 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.315 ns | 0.1214 ns | 0.1076 ns | 18.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.537 ns | 0.0111 ns | 0.0093 ns | 14.538 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.262 ns | 0.0720 ns | 0.0673 ns | 17.284 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.440 ns | 0.0360 ns | 0.0337 ns | 17.426 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.446 ns | 0.1112 ns | 0.1040 ns | 19.427 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.435 ns | 0.0826 ns | 0.0732 ns | 19.410 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.165 ns | 0.0389 ns | 0.0345 ns | 16.166 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.203 ns | 0.0461 ns | 0.0431 ns | 13.197 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.994 ns | 0.0362 ns | 0.0282 ns | 19.999 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.116 ns | 0.0292 ns | 0.0274 ns | 18.127 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.506 ns | 0.1357 ns | 0.1270 ns | 18.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.543 ns | 0.0112 ns | 0.0105 ns | 14.541 ns |  0.79 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.683 ns | 0.2500 ns | 0.2339 ns | 15.781 ns |  0.85 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.444 ns | 0.0255 ns | 0.0226 ns | 17.436 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.405 ns | 0.1093 ns | 0.1022 ns | 19.346 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.873 ns | 0.0890 ns | 0.0832 ns | 13.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.682 ns | 0.0230 ns | 0.0204 ns | 11.688 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.858 ns | 0.0097 ns | 0.0091 ns |  6.856 ns |  0.49 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 11.958 ns | 0.0174 ns | 0.0163 ns | 11.955 ns |  0.86 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 11.977 ns | 0.0165 ns | 0.0146 ns | 11.976 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.223 ns | 0.0976 ns | 0.0913 ns | 14.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.882 ns | 0.0177 ns | 0.0157 ns | 11.877 ns |  0.84 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.931 ns | 0.0174 ns | 0.0154 ns | 11.931 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.642 ns | 0.0460 ns | 0.0430 ns | 13.661 ns |  0.96 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.127 ns | 0.0281 ns | 0.0234 ns | 15.123 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.146 ns | 0.0708 ns | 0.0663 ns | 13.182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.467 ns | 0.0085 ns | 0.0076 ns | 11.469 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.864 ns | 0.1842 ns | 0.2329 ns |  7.882 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.789 ns | 0.0112 ns | 0.0099 ns | 11.791 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.385 ns | 0.0161 ns | 0.0151 ns | 10.380 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.127 ns | 0.0881 ns | 0.0781 ns | 15.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.297 ns | 0.0176 ns | 0.0164 ns | 13.295 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.491 ns | 0.1107 ns | 0.1035 ns | 13.550 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.202 ns | 0.0383 ns | 0.0358 ns | 17.203 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.621 ns | 0.0214 ns | 0.0190 ns | 16.615 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.886 ns | 0.0862 ns | 0.0806 ns | 13.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.367 ns | 0.0117 ns | 0.0109 ns | 11.371 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.364 ns | 0.0476 ns | 0.0446 ns |  6.385 ns |  0.46 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.532 ns | 0.0199 ns | 0.0186 ns | 12.527 ns |  0.90 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.286 ns | 0.0133 ns | 0.0104 ns | 10.284 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.295 ns | 0.0922 ns | 0.0862 ns | 15.308 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.297 ns | 0.0206 ns | 0.0172 ns | 13.297 ns |  0.87 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.802 ns | 0.2840 ns | 0.2656 ns | 13.572 ns |  0.90 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.152 ns | 0.0473 ns | 0.0442 ns | 15.159 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.678 ns | 0.0278 ns | 0.0260 ns | 16.681 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.952 ns | 0.0560 ns | 0.0496 ns | 12.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.377 ns | 0.0122 ns | 0.0114 ns | 11.375 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.683 ns | 0.1591 ns | 0.2381 ns |  6.531 ns |  0.53 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.802 ns | 0.0103 ns | 0.0096 ns | 11.800 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.675 ns | 0.0141 ns | 0.0125 ns | 11.675 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.320 ns | 0.1160 ns | 0.1085 ns | 14.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.863 ns | 0.0113 ns | 0.0106 ns | 11.862 ns |  0.83 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.353 ns | 0.0207 ns | 0.0184 ns | 13.353 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.174 ns | 0.0303 ns | 0.0269 ns | 13.177 ns |  0.92 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.059 ns | 0.0230 ns | 0.0215 ns | 15.047 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.467 ns | 0.0284 ns | 0.0252 ns | 13.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.641 ns | 0.0312 ns | 0.0261 ns | 10.649 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.441 ns | 0.1045 ns | 0.0977 ns |  7.493 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.114 ns | 0.0208 ns | 0.0194 ns | 13.110 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.821 ns | 0.0181 ns | 0.0169 ns | 10.817 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.406 ns | 0.2286 ns | 0.2138 ns | 50.347 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.689 ns | 0.1057 ns | 0.0937 ns | 42.650 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.103 ns | 0.1852 ns | 0.1547 ns | 39.146 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.526 ns | 0.1407 ns | 0.1317 ns | 43.555 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 46.264 ns | 0.2107 ns | 0.1971 ns | 46.208 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.259 ns | 0.0533 ns | 0.0498 ns | 14.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.156 ns | 0.0165 ns | 0.0154 ns | 12.160 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.022 ns | 0.0130 ns | 0.0122 ns |  8.023 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.113 ns | 0.0262 ns | 0.0245 ns | 13.103 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.128 ns | 0.0136 ns | 0.0121 ns | 12.129 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.665 ns | 0.1926 ns | 0.1707 ns | 45.674 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.428 ns | 0.0794 ns | 0.0743 ns | 40.449 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.646 ns | 0.6509 ns | 0.6392 ns | 33.306 ns |  0.74 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 46.426 ns | 0.1522 ns | 0.1424 ns | 46.414 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 48.498 ns | 0.1004 ns | 0.0890 ns | 48.464 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.082 ns | 0.0422 ns | 0.0352 ns | 13.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.472 ns | 0.0105 ns | 0.0098 ns | 10.471 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.691 ns | 0.0843 ns | 0.0789 ns |  6.746 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 11.850 ns | 0.0278 ns | 0.0246 ns | 11.842 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 11.988 ns | 0.0547 ns | 0.0457 ns | 11.998 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.035 ns | 0.0843 ns | 0.0788 ns | 15.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.671 ns | 0.0339 ns | 0.0317 ns | 13.663 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.350 ns | 0.2739 ns | 0.3261 ns | 12.562 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.348 ns | 0.0148 ns | 0.0139 ns | 13.346 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.777 ns | 0.0194 ns | 0.0162 ns | 16.776 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.038 ns | 0.0714 ns | 0.0668 ns | 12.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.427 ns | 0.0087 ns | 0.0077 ns | 11.427 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.353 ns | 0.0943 ns | 0.0882 ns | 11.364 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.000 ns | 0.0329 ns | 0.0308 ns | 14.005 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.573 ns | 0.0510 ns | 0.0478 ns | 12.560 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.762 ns | 0.1227 ns | 0.1147 ns | 15.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.606 ns | 0.0095 ns | 0.0079 ns | 13.609 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.120 ns | 0.0438 ns | 0.0410 ns | 13.110 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.378 ns | 0.0523 ns | 0.0489 ns | 15.379 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.884 ns | 0.0219 ns | 0.0205 ns | 16.889 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.153 ns | 0.0473 ns | 0.0420 ns | 14.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.133 ns | 0.0097 ns | 0.0081 ns | 11.133 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.780 ns | 0.2731 ns | 0.4332 ns | 11.602 ns |  0.85 |    0.04 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.322 ns | 0.0218 ns | 0.0204 ns | 12.327 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 13.935 ns | 0.0187 ns | 0.0166 ns | 13.929 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.253 ns | 0.1239 ns | 0.1159 ns | 14.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 11.880 ns | 0.0361 ns | 0.0301 ns | 11.875 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.509 ns | 0.2672 ns | 0.3078 ns | 12.651 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.402 ns | 0.0128 ns | 0.0120 ns | 13.406 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.361 ns | 0.0625 ns | 0.0554 ns | 15.380 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.948 ns | 0.1905 ns | 0.1689 ns | 39.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.504 ns | 0.0464 ns | 0.0434 ns | 38.490 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.918 ns | 0.2517 ns | 0.2354 ns | 37.004 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 46.206 ns | 0.0617 ns | 0.0577 ns | 46.183 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 37.758 ns | 0.1085 ns | 0.1015 ns | 37.712 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.418 ns | 0.0779 ns | 0.0729 ns | 16.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.512 ns | 0.0116 ns | 0.0103 ns | 13.510 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.290 ns | 0.0559 ns | 0.0495 ns | 13.306 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.537 ns | 0.0494 ns | 0.0462 ns | 17.517 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.707 ns | 0.0912 ns | 0.0853 ns | 17.726 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.200 ns | 0.1238 ns | 0.1158 ns | 40.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.054 ns | 0.0527 ns | 0.0467 ns | 38.052 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.126 ns | 0.6211 ns | 0.5810 ns | 35.367 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.678 ns | 0.0704 ns | 0.0658 ns | 38.690 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.711 ns | 0.0625 ns | 0.0585 ns | 40.717 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.347 ns | 0.0718 ns | 0.0600 ns | 16.343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.940 ns | 0.0201 ns | 0.0178 ns | 13.940 ns |  0.85 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.764 ns | 0.0149 ns | 0.0139 ns | 13.765 ns |  0.84 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.641 ns | 0.0542 ns | 0.0507 ns | 17.666 ns |  1.08 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 16.871 ns | 0.0233 ns | 0.0206 ns | 16.873 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.749 ns | 0.4452 ns | 0.4164 ns | 42.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.711 ns | 0.0653 ns | 0.0545 ns | 39.714 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.489 ns | 1.5282 ns | 3.0520 ns | 35.780 ns |  0.97 |    0.07 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 47.734 ns | 0.0563 ns | 0.0499 ns | 47.728 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.632 ns | 0.0645 ns | 0.0572 ns | 38.624 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.203 ns | 0.0745 ns | 0.0697 ns | 14.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.833 ns | 0.0104 ns | 0.0092 ns | 11.832 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.972 ns | 0.0299 ns | 0.0279 ns | 11.980 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.278 ns | 0.0305 ns | 0.0285 ns | 13.275 ns |  0.93 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.088 ns | 0.0193 ns | 0.0171 ns | 16.093 ns |  1.13 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Short.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Short.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Short.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Short.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Short.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Short.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Short.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
