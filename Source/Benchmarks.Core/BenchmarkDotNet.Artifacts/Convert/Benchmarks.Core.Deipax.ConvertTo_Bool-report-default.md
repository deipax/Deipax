
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-LRKCAO : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-VAJWLV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-TJIRAH : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-HBFVIR : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-YRWWQX : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 11.799 ns | 0.0292 ns | 0.0273 ns | 11.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.013 ns | 0.0331 ns | 0.0310 ns | 10.003 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.924 ns | 0.1646 ns | 0.2197 ns |  7.074 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.686 ns | 0.1292 ns | 0.1208 ns | 10.756 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.430 ns | 0.0203 ns | 0.0180 ns | 10.433 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 14.947 ns | 0.0380 ns | 0.0355 ns | 14.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 12.541 ns | 0.0250 ns | 0.0221 ns | 12.540 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 13.039 ns | 0.2663 ns | 0.2224 ns | 13.128 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 14.075 ns | 0.0560 ns | 0.0468 ns | 14.081 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 17.506 ns | 0.0260 ns | 0.0230 ns | 17.506 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.906 ns | 0.1242 ns | 0.1162 ns | 11.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 13.354 ns | 0.0269 ns | 0.0238 ns | 13.349 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  6.953 ns | 0.0932 ns | 0.0872 ns |  6.931 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.932 ns | 0.0222 ns | 0.0173 ns | 10.924 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.191 ns | 0.0163 ns | 0.0136 ns | 11.191 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.722 ns | 0.0275 ns | 0.0258 ns | 14.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.673 ns | 0.0283 ns | 0.0265 ns | 13.670 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.616 ns | 0.3311 ns | 0.4641 ns | 15.764 ns |  1.05 |    0.04 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 14.373 ns | 0.0145 ns | 0.0129 ns | 14.372 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 15.803 ns | 0.0354 ns | 0.0314 ns | 15.810 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.379 ns | 0.1277 ns | 0.1195 ns | 12.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.102 ns | 0.0156 ns | 0.0138 ns | 10.101 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.807 ns | 0.1397 ns | 0.1307 ns |  6.878 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.094 ns | 0.0436 ns | 0.0408 ns | 12.073 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.341 ns | 0.0463 ns | 0.0410 ns | 10.329 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.199 ns | 0.1084 ns | 0.1014 ns | 15.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.931 ns | 0.0288 ns | 0.0255 ns | 11.938 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.244 ns | 0.0786 ns | 0.0735 ns | 12.278 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.280 ns | 0.0969 ns | 0.0906 ns | 15.242 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 16.187 ns | 0.0423 ns | 0.0353 ns | 16.178 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.583 ns | 0.0531 ns | 0.0497 ns | 11.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.414 ns | 0.0199 ns | 0.0176 ns | 10.410 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  8.430 ns | 0.8132 ns | 1.2898 ns |  7.710 ns |  0.80 |    0.13 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.048 ns | 0.0191 ns | 0.0159 ns | 12.045 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.419 ns | 0.0163 ns | 0.0136 ns | 10.420 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.272 ns | 0.0632 ns | 0.0560 ns | 18.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.541 ns | 0.0198 ns | 0.0176 ns | 15.538 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.285 ns | 0.0327 ns | 0.0273 ns | 15.287 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.303 ns | 0.0304 ns | 0.0270 ns | 18.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.236 ns | 0.0334 ns | 0.0296 ns | 20.239 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.018 ns | 0.0500 ns | 0.0443 ns | 12.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.718 ns | 0.0201 ns | 0.0188 ns | 10.716 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.107 ns | 0.0190 ns | 0.0158 ns |  7.103 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.134 ns | 0.0191 ns | 0.0159 ns | 13.135 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.616 ns | 0.0177 ns | 0.0148 ns | 10.617 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.789 ns | 0.0533 ns | 0.0498 ns | 18.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.323 ns | 0.0229 ns | 0.0191 ns | 15.319 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.127 ns | 0.0618 ns | 0.0578 ns | 15.117 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.739 ns | 0.0326 ns | 0.0273 ns | 18.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.296 ns | 0.1266 ns | 0.1123 ns | 21.270 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.774 ns | 0.1012 ns | 0.0946 ns | 11.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.565 ns | 0.0952 ns | 0.0890 ns | 10.526 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.120 ns | 0.0422 ns | 0.0374 ns |  7.109 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.458 ns | 0.0146 ns | 0.0136 ns | 12.456 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.212 ns | 0.0194 ns | 0.0162 ns | 12.212 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.082 ns | 0.0332 ns | 0.0311 ns | 15.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.103 ns | 0.0224 ns | 0.0199 ns | 13.094 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.717 ns | 0.1795 ns | 0.1679 ns | 12.706 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.027 ns | 0.0348 ns | 0.0291 ns | 14.017 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.401 ns | 0.0301 ns | 0.0251 ns | 16.406 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.657 ns | 0.0843 ns | 0.0747 ns | 11.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.402 ns | 0.0109 ns | 0.0096 ns | 10.402 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.891 ns | 0.0095 ns | 0.0089 ns |  6.893 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.966 ns | 0.0227 ns | 0.0213 ns | 11.962 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.600 ns | 0.0954 ns | 0.0892 ns | 10.564 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.362 ns | 0.0160 ns | 0.0150 ns | 12.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.484 ns | 0.0215 ns | 0.0179 ns | 10.481 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.666 ns | 0.0165 ns | 0.0154 ns |  6.667 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.952 ns | 0.0216 ns | 0.0180 ns | 11.951 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.359 ns | 0.0147 ns | 0.0130 ns | 10.356 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.716 ns | 0.0709 ns | 0.0592 ns | 11.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.525 ns | 0.0716 ns | 0.0670 ns | 10.508 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.888 ns | 0.0100 ns | 0.0088 ns |  6.886 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.127 ns | 0.0736 ns | 0.0689 ns | 12.152 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.718 ns | 0.0170 ns | 0.0133 ns | 11.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.157 ns | 0.0170 ns | 0.0151 ns | 14.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.931 ns | 0.0155 ns | 0.0138 ns | 11.933 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.969 ns | 0.0144 ns | 0.0121 ns | 13.970 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.163 ns | 0.0128 ns | 0.0107 ns | 13.165 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.924 ns | 0.0358 ns | 0.0318 ns | 15.917 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.983 ns | 0.1040 ns | 0.0973 ns | 11.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.363 ns | 0.0199 ns | 0.0166 ns | 11.364 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.896 ns | 0.2045 ns | 0.3473 ns |  9.053 ns |  0.72 |    0.04 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 15.709 ns | 0.0351 ns | 0.0274 ns | 15.705 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.889 ns | 0.0397 ns | 0.0352 ns | 11.877 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.748 ns | 0.0309 ns | 0.0274 ns | 12.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.760 ns | 0.0259 ns | 0.0229 ns | 11.753 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.837 ns | 0.1992 ns | 0.2856 ns |  8.979 ns |  0.68 |    0.03 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.373 ns | 0.1557 ns | 0.1456 ns | 13.298 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.738 ns | 0.1156 ns | 0.1081 ns | 12.658 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.588 ns | 0.0108 ns | 0.0096 ns | 12.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.776 ns | 0.0388 ns | 0.0344 ns | 11.767 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.038 ns | 0.0176 ns | 0.0147 ns |  8.039 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.775 ns | 0.0232 ns | 0.0206 ns | 13.779 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.871 ns | 0.0610 ns | 0.0541 ns | 12.885 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.290 ns | 0.1425 ns | 0.1113 ns | 14.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.933 ns | 0.0135 ns | 0.0120 ns | 11.933 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.428 ns | 0.2954 ns | 0.2763 ns | 14.412 ns |  1.02 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.153 ns | 0.0298 ns | 0.0249 ns | 13.156 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.701 ns | 0.0349 ns | 0.0291 ns | 16.694 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.459 ns | 0.0836 ns | 0.0782 ns | 23.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.031 ns | 0.0314 ns | 0.0293 ns | 20.029 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.685 ns | 0.0269 ns | 0.0252 ns | 13.683 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.092 ns | 0.0596 ns | 0.0529 ns | 25.109 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.148 ns | 0.0291 ns | 0.0243 ns | 24.147 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 23.730 ns | 0.1001 ns | 0.0936 ns | 23.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 20.949 ns | 0.0503 ns | 0.0470 ns | 20.934 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.008 ns | 0.0214 ns | 0.0190 ns | 20.009 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 24.312 ns | 0.0387 ns | 0.0323 ns | 24.308 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 26.467 ns | 0.0288 ns | 0.0269 ns | 26.463 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.886 ns | 0.2169 ns | 0.2029 ns | 23.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.887 ns | 0.0377 ns | 0.0335 ns | 20.883 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 14.060 ns | 0.2289 ns | 0.2141 ns | 14.202 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.910 ns | 0.0375 ns | 0.0351 ns | 25.907 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.460 ns | 0.0386 ns | 0.0342 ns | 23.452 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.944 ns | 0.0734 ns | 0.0651 ns | 23.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.257 ns | 0.1723 ns | 0.1612 ns | 21.350 ns |  0.89 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.234 ns | 0.4275 ns | 0.5407 ns | 20.529 ns |  0.84 |    0.02 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 24.735 ns | 0.0256 ns | 0.0213 ns | 24.737 ns |  1.03 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 26.176 ns | 0.1182 ns | 0.1106 ns | 26.194 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.628 ns | 0.0461 ns | 0.0431 ns | 12.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.851 ns | 0.0241 ns | 0.0214 ns | 11.848 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.456 ns | 0.1955 ns | 0.2252 ns |  8.375 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.741 ns | 0.0307 ns | 0.0256 ns | 14.738 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.605 ns | 0.0186 ns | 0.0155 ns | 13.603 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.147 ns | 0.0204 ns | 0.0191 ns | 14.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.938 ns | 0.0392 ns | 0.0348 ns | 11.929 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.771 ns | 0.2074 ns | 0.1940 ns | 12.629 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.246 ns | 0.0301 ns | 0.0235 ns | 13.243 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.676 ns | 0.0524 ns | 0.0437 ns | 16.662 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.722 ns | 0.0256 ns | 0.0214 ns | 11.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.621 ns | 0.0118 ns | 0.0104 ns | 10.623 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.401 ns | 0.0304 ns | 0.0284 ns |  7.394 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 12.664 ns | 0.0298 ns | 0.0279 ns | 12.670 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.553 ns | 0.0746 ns | 0.0698 ns | 10.510 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 18.152 ns | 0.1071 ns | 0.1002 ns | 18.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 15.254 ns | 0.1033 ns | 0.0967 ns | 15.291 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 15.677 ns | 0.1187 ns | 0.1110 ns | 15.632 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 18.056 ns | 0.0170 ns | 0.0151 ns | 18.059 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 21.004 ns | 0.1121 ns | 0.1049 ns | 21.035 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.239 ns | 0.2820 ns | 0.2896 ns | 13.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.055 ns | 0.0252 ns | 0.0223 ns | 12.053 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  9.414 ns | 0.2132 ns | 0.4899 ns |  9.610 ns |  0.67 |    0.05 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.677 ns | 0.0340 ns | 0.0318 ns | 14.684 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.167 ns | 0.0259 ns | 0.0242 ns | 14.166 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.643 ns | 0.0428 ns | 0.0357 ns | 18.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.343 ns | 0.0315 ns | 0.0279 ns | 15.337 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.503 ns | 0.2135 ns | 0.1997 ns | 15.598 ns |  0.83 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 18.560 ns | 0.0778 ns | 0.0689 ns | 18.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.251 ns | 0.0366 ns | 0.0325 ns | 20.254 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.670 ns | 0.1077 ns | 0.1007 ns | 12.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.115 ns | 0.0203 ns | 0.0190 ns | 12.116 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.256 ns | 0.0685 ns | 0.0535 ns |  8.275 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.980 ns | 0.0338 ns | 0.0300 ns | 13.973 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.826 ns | 0.0183 ns | 0.0162 ns | 12.826 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.166 ns | 0.0423 ns | 0.0396 ns | 14.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.926 ns | 0.0161 ns | 0.0135 ns | 11.925 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.078 ns | 0.0676 ns | 0.0600 ns | 12.076 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.323 ns | 0.0168 ns | 0.0149 ns | 13.323 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.169 ns | 0.0432 ns | 0.0383 ns | 16.168 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.240 ns | 0.1308 ns | 0.1224 ns | 12.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.432 ns | 0.0131 ns | 0.0116 ns | 10.433 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.927 ns | 0.0783 ns | 0.0733 ns |  6.945 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.574 ns | 0.0317 ns | 0.0264 ns | 12.570 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.351 ns | 0.0175 ns | 0.0155 ns | 10.353 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.418 ns | 0.0540 ns | 0.0505 ns | 18.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.606 ns | 0.1124 ns | 0.1052 ns | 15.558 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.120 ns | 0.0281 ns | 0.0263 ns | 15.118 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 18.117 ns | 0.0326 ns | 0.0273 ns | 18.109 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.292 ns | 0.1329 ns | 0.1243 ns | 20.238 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.841 ns | 0.0208 ns | 0.0184 ns | 11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.715 ns | 0.0172 ns | 0.0153 ns | 10.719 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.351 ns | 0.0152 ns | 0.0135 ns |  7.353 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.830 ns | 0.0477 ns | 0.0446 ns | 12.811 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.731 ns | 0.0434 ns | 0.0406 ns | 10.722 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.113 ns | 0.1592 ns | 0.1489 ns | 18.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.733 ns | 0.0279 ns | 0.0247 ns | 15.737 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.569 ns | 0.1002 ns | 0.0937 ns | 15.568 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.067 ns | 0.0337 ns | 0.0299 ns | 18.057 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.879 ns | 0.0446 ns | 0.0417 ns | 20.862 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.852 ns | 0.0868 ns | 0.0725 ns | 11.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.605 ns | 0.0330 ns | 0.0292 ns | 10.596 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.964 ns | 0.0149 ns | 0.0139 ns |  6.956 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.520 ns | 0.0276 ns | 0.0245 ns | 12.516 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.465 ns | 0.0185 ns | 0.0154 ns | 10.465 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.133 ns | 0.0233 ns | 0.0182 ns | 14.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.933 ns | 0.0171 ns | 0.0152 ns | 11.930 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.091 ns | 0.1001 ns | 0.0937 ns | 12.053 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.157 ns | 0.0586 ns | 0.0548 ns | 13.138 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.079 ns | 0.1137 ns | 0.1063 ns | 15.018 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.750 ns | 0.0169 ns | 0.0141 ns | 11.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.426 ns | 0.0166 ns | 0.0129 ns | 10.426 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  8.118 ns | 0.5816 ns | 0.5973 ns |  7.832 ns |  0.70 |    0.06 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.752 ns | 0.0698 ns | 0.0653 ns | 12.778 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.783 ns | 0.0190 ns | 0.0168 ns | 11.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.402 ns | 0.1790 ns | 0.1674 ns | 18.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.002 ns | 0.0261 ns | 0.0244 ns | 15.999 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.275 ns | 0.0461 ns | 0.0409 ns | 15.268 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.536 ns | 0.0192 ns | 0.0161 ns | 18.532 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.452 ns | 0.0288 ns | 0.0256 ns | 21.450 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.839 ns | 0.0220 ns | 0.0195 ns | 11.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.740 ns | 0.0236 ns | 0.0197 ns | 10.746 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.281 ns | 0.1975 ns | 0.3133 ns |  7.112 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.486 ns | 0.0232 ns | 0.0181 ns | 12.486 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.343 ns | 0.0552 ns | 0.0516 ns | 12.330 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.383 ns | 0.1843 ns | 0.1724 ns | 18.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.745 ns | 0.0794 ns | 0.0703 ns | 15.765 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.270 ns | 0.3915 ns | 1.0383 ns | 18.656 ns |  0.90 |    0.08 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.227 ns | 0.0271 ns | 0.0254 ns | 18.226 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 20.273 ns | 0.0294 ns | 0.0275 ns | 20.261 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.874 ns | 0.0737 ns | 0.0689 ns | 11.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.465 ns | 0.0207 ns | 0.0173 ns | 10.464 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.117 ns | 0.0228 ns | 0.0191 ns |  7.111 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.536 ns | 0.0152 ns | 0.0135 ns | 12.538 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.648 ns | 0.0197 ns | 0.0184 ns | 10.650 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.170 ns | 0.0474 ns | 0.0443 ns | 14.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.937 ns | 0.0288 ns | 0.0240 ns | 11.939 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.027 ns | 0.0379 ns | 0.0316 ns | 12.016 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.204 ns | 0.0262 ns | 0.0218 ns | 13.202 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.398 ns | 0.0341 ns | 0.0319 ns | 15.396 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.705 ns | 0.1138 ns | 0.1064 ns | 13.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.549 ns | 0.0917 ns | 0.0858 ns | 10.595 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.743 ns | 0.0144 ns | 0.0134 ns |  6.741 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.097 ns | 0.0491 ns | 0.0459 ns | 12.074 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.738 ns | 0.0127 ns | 0.0112 ns | 11.736 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.967 ns | 0.0323 ns | 0.0287 ns | 17.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.571 ns | 0.0265 ns | 0.0235 ns | 15.566 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.163 ns | 0.0457 ns | 0.0428 ns | 15.169 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.614 ns | 0.0286 ns | 0.0267 ns | 18.611 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.247 ns | 0.0237 ns | 0.0185 ns | 21.243 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.714 ns | 0.0915 ns | 0.0811 ns | 12.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.257 ns | 0.0698 ns | 0.0653 ns | 12.277 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.218 ns | 0.0731 ns | 0.0648 ns |  8.189 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.269 ns | 0.0199 ns | 0.0166 ns | 14.272 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.048 ns | 0.0200 ns | 0.0187 ns | 13.041 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.126 ns | 0.0488 ns | 0.0407 ns | 19.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.766 ns | 0.1198 ns | 0.1120 ns | 15.805 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.329 ns | 0.0370 ns | 0.0346 ns | 15.332 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.644 ns | 0.0338 ns | 0.0300 ns | 18.644 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.078 ns | 0.0388 ns | 0.0324 ns | 21.075 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.536 ns | 0.0382 ns | 0.0357 ns | 12.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.887 ns | 0.0269 ns | 0.0238 ns | 11.881 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.438 ns | 0.1864 ns | 0.1831 ns |  8.512 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.988 ns | 0.0217 ns | 0.0193 ns | 13.987 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.808 ns | 0.0565 ns | 0.0529 ns | 12.791 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.347 ns | 0.0679 ns | 0.0602 ns | 14.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.889 ns | 0.0244 ns | 0.0228 ns | 11.889 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.008 ns | 0.0172 ns | 0.0161 ns | 12.005 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.218 ns | 0.0204 ns | 0.0159 ns | 13.220 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.054 ns | 0.0284 ns | 0.0252 ns | 15.051 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.614 ns | 0.0247 ns | 0.0231 ns | 11.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.438 ns | 0.0433 ns | 0.0405 ns | 10.419 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.781 ns | 0.0167 ns | 0.0156 ns |  6.782 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.031 ns | 0.0228 ns | 0.0202 ns | 12.029 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.388 ns | 0.0177 ns | 0.0157 ns | 10.389 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.011 ns | 0.1050 ns | 0.0982 ns | 17.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.307 ns | 0.0484 ns | 0.0429 ns | 15.303 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.315 ns | 0.0366 ns | 0.0324 ns | 18.305 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 20.346 ns | 0.0376 ns | 0.0352 ns | 20.350 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.236 ns | 0.0295 ns | 0.0276 ns | 20.241 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.875 ns | 0.0555 ns | 0.0519 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.122 ns | 0.0277 ns | 0.0245 ns | 11.116 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.228 ns | 0.0987 ns | 0.0923 ns |  7.182 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.248 ns | 0.0894 ns | 0.0792 ns | 13.273 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.663 ns | 0.0270 ns | 0.0252 ns | 10.662 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.146 ns | 0.1334 ns | 0.1247 ns | 18.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.520 ns | 0.0283 ns | 0.0236 ns | 15.523 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.503 ns | 0.0475 ns | 0.0421 ns | 15.489 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.668 ns | 0.1154 ns | 0.1080 ns | 18.648 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.241 ns | 0.0365 ns | 0.0305 ns | 21.244 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.787 ns | 0.1271 ns | 0.1189 ns | 11.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.646 ns | 0.0904 ns | 0.0755 ns | 10.670 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.252 ns | 0.0803 ns | 0.0627 ns |  7.234 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.991 ns | 0.0524 ns | 0.0464 ns | 11.975 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.546 ns | 0.0110 ns | 0.0103 ns | 10.546 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.038 ns | 0.0222 ns | 0.0197 ns | 15.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.915 ns | 0.0152 ns | 0.0142 ns | 11.911 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.649 ns | 0.0212 ns | 0.0188 ns | 12.642 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.274 ns | 0.0142 ns | 0.0125 ns | 14.273 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.896 ns | 0.0265 ns | 0.0222 ns | 15.891 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.852 ns | 0.1055 ns | 0.0986 ns | 11.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.875 ns | 0.0080 ns | 0.0075 ns | 10.876 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.413 ns | 0.0390 ns | 0.0365 ns |  7.416 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.150 ns | 0.0165 ns | 0.0129 ns | 12.150 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 10.965 ns | 0.0454 ns | 0.0425 ns | 10.949 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 18.161 ns | 0.0350 ns | 0.0327 ns | 18.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 15.382 ns | 0.1544 ns | 0.1289 ns | 15.428 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 15.386 ns | 0.0688 ns | 0.0644 ns | 15.395 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 18.288 ns | 0.1090 ns | 0.1019 ns | 18.338 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.392 ns | 0.0378 ns | 0.0353 ns | 23.393 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.961 ns | 0.0122 ns | 0.0102 ns | 11.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.755 ns | 0.0187 ns | 0.0175 ns | 10.757 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  7.471 ns | 0.0202 ns | 0.0169 ns |  7.469 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.275 ns | 0.0310 ns | 0.0275 ns | 13.274 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 11.113 ns | 0.0132 ns | 0.0117 ns | 11.114 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.246 ns | 0.0453 ns | 0.0401 ns | 18.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.106 ns | 0.0225 ns | 0.0200 ns | 15.109 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.521 ns | 0.1102 ns | 0.1031 ns | 16.547 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 18.127 ns | 0.0364 ns | 0.0322 ns | 18.128 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 21.301 ns | 0.0391 ns | 0.0347 ns | 21.299 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.728 ns | 0.0534 ns | 0.0500 ns | 11.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.688 ns | 0.0742 ns | 0.0658 ns | 10.711 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.142 ns | 0.0127 ns | 0.0119 ns |  7.143 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.073 ns | 0.0317 ns | 0.0265 ns | 12.069 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.070 ns | 0.0218 ns | 0.0204 ns | 12.067 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.249 ns | 0.1293 ns | 0.1210 ns | 14.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.971 ns | 0.1004 ns | 0.0890 ns | 11.942 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.245 ns | 0.1148 ns | 0.1073 ns | 12.276 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.110 ns | 0.0177 ns | 0.0148 ns | 13.110 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.003 ns | 0.0311 ns | 0.0291 ns | 14.999 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 24.843 ns | 0.0269 ns | 0.0210 ns | 24.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 31.744 ns | 0.0600 ns | 0.0561 ns | 31.732 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 21.910 ns | 0.0306 ns | 0.0271 ns | 21.906 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 25.888 ns | 0.1762 ns | 0.1648 ns | 25.963 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 26.132 ns | 0.0425 ns | 0.0398 ns | 26.126 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 29.070 ns | 0.2358 ns | 0.2206 ns | 28.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 38.853 ns | 0.0550 ns | 0.0488 ns | 38.853 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.620 ns | 0.2417 ns | 0.2261 ns | 25.760 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 29.282 ns | 0.0688 ns | 0.0574 ns | 29.276 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 32.376 ns | 0.0370 ns | 0.0346 ns | 32.373 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.198 ns | 0.0299 ns | 0.0279 ns | 12.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.007 ns | 0.1120 ns | 0.1047 ns | 13.061 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.044 ns | 0.0924 ns | 0.0864 ns | 11.003 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.591 ns | 0.0205 ns | 0.0182 ns | 12.595 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.138 ns | 0.0293 ns | 0.0260 ns | 15.142 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.135 ns | 0.0951 ns | 0.0890 ns | 15.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.940 ns | 0.0377 ns | 0.0353 ns | 11.940 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.191 ns | 0.2910 ns | 0.3235 ns | 12.010 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.165 ns | 0.0380 ns | 0.0318 ns | 13.163 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 17.050 ns | 0.0259 ns | 0.0229 ns | 17.052 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.334 ns | 0.0419 ns | 0.0392 ns | 14.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.529 ns | 0.0212 ns | 0.0188 ns | 11.525 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.525 ns | 0.0541 ns | 0.0452 ns | 11.511 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.322 ns | 0.0506 ns | 0.0474 ns | 12.298 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.497 ns | 0.0950 ns | 0.0889 ns | 14.522 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.612 ns | 0.0292 ns | 0.0259 ns | 11.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.437 ns | 0.0226 ns | 0.0211 ns | 10.429 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.565 ns | 0.2166 ns | 0.5856 ns |  9.749 ns |  0.74 |    0.09 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.598 ns | 0.0518 ns | 0.0485 ns | 12.574 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.526 ns | 0.0746 ns | 0.0698 ns | 10.546 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.196 ns | 0.1333 ns | 0.1247 ns | 18.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.414 ns | 0.0169 ns | 0.0158 ns | 15.416 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.009 ns | 0.2774 ns | 0.2595 ns | 17.118 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.759 ns | 0.0240 ns | 0.0212 ns | 18.760 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.267 ns | 0.0319 ns | 0.0298 ns | 21.275 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.847 ns | 0.0278 ns | 0.0260 ns | 11.840 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.870 ns | 0.0770 ns | 0.0720 ns | 10.888 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.149 ns | 0.0209 ns | 0.0195 ns |  7.145 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.602 ns | 0.0849 ns | 0.0753 ns | 12.624 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.640 ns | 0.0137 ns | 0.0122 ns | 10.640 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.820 ns | 0.1311 ns | 0.1226 ns | 18.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.314 ns | 0.0267 ns | 0.0250 ns | 15.321 ns |  0.81 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.457 ns | 0.0420 ns | 0.0393 ns | 15.456 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.760 ns | 0.0654 ns | 0.0546 ns | 18.741 ns |  1.00 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.724 ns | 0.1990 ns | 0.1862 ns | 20.804 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.695 ns | 0.0319 ns | 0.0249 ns | 11.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.497 ns | 0.0182 ns | 0.0162 ns | 10.493 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.130 ns | 0.0214 ns | 0.0178 ns |  7.126 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.474 ns | 0.0244 ns | 0.0216 ns | 12.472 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.605 ns | 0.0164 ns | 0.0154 ns | 10.604 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.042 ns | 0.0342 ns | 0.0320 ns | 15.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.917 ns | 0.0326 ns | 0.0272 ns | 11.920 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.208 ns | 0.1355 ns | 0.1267 ns | 12.160 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.208 ns | 0.0412 ns | 0.0385 ns | 13.203 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 16.003 ns | 0.0322 ns | 0.0301 ns | 16.001 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.557 ns | 0.0211 ns | 0.0198 ns | 11.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.767 ns | 0.0242 ns | 0.0226 ns | 11.769 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.681 ns | 0.0142 ns | 0.0133 ns |  7.683 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.584 ns | 0.0231 ns | 0.0216 ns | 12.583 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.547 ns | 0.0151 ns | 0.0126 ns | 10.544 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.525 ns | 0.0228 ns | 0.0213 ns | 18.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.277 ns | 0.1175 ns | 0.1099 ns | 15.323 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.622 ns | 0.0579 ns | 0.0484 ns | 15.623 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.291 ns | 0.0666 ns | 0.0623 ns | 18.302 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.263 ns | 0.0276 ns | 0.0245 ns | 21.266 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.850 ns | 0.0279 ns | 0.0261 ns | 11.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.727 ns | 0.0384 ns | 0.0359 ns | 10.718 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.872 ns | 0.0242 ns | 0.0226 ns |  6.869 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.470 ns | 0.0179 ns | 0.0159 ns | 12.469 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.651 ns | 0.0314 ns | 0.0294 ns | 10.640 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.958 ns | 0.0283 ns | 0.0237 ns | 17.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.562 ns | 0.1074 ns | 0.0952 ns | 15.596 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.423 ns | 0.0407 ns | 0.0340 ns | 15.417 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.613 ns | 0.0558 ns | 0.0522 ns | 18.613 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.250 ns | 0.0600 ns | 0.0532 ns | 21.233 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.643 ns | 0.0179 ns | 0.0159 ns | 12.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.049 ns | 0.0825 ns | 0.0731 ns | 11.061 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.098 ns | 0.0200 ns | 0.0167 ns |  7.093 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.162 ns | 0.0649 ns | 0.0607 ns | 13.178 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.924 ns | 0.0209 ns | 0.0196 ns | 11.920 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.235 ns | 0.0653 ns | 0.0611 ns | 16.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.102 ns | 0.0091 ns | 0.0076 ns | 12.101 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.064 ns | 0.0993 ns | 0.0928 ns | 12.017 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.172 ns | 0.0179 ns | 0.0158 ns | 13.173 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.020 ns | 0.0423 ns | 0.0395 ns | 15.015 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.562 ns | 0.0264 ns | 0.0221 ns | 11.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.614 ns | 0.0449 ns | 0.0420 ns | 10.598 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.007 ns | 0.2048 ns | 0.4137 ns |  9.165 ns |  0.75 |    0.06 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.031 ns | 0.0164 ns | 0.0146 ns | 12.026 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.398 ns | 0.0739 ns | 0.0691 ns | 10.368 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.175 ns | 0.0363 ns | 0.0322 ns | 18.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.095 ns | 0.0355 ns | 0.0314 ns | 15.089 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.569 ns | 0.3569 ns | 0.5451 ns | 16.864 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 18.365 ns | 0.0310 ns | 0.0259 ns | 18.361 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.474 ns | 0.0336 ns | 0.0298 ns | 21.470 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.662 ns | 0.0270 ns | 0.0239 ns | 12.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.872 ns | 0.0189 ns | 0.0158 ns | 11.871 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.459 ns | 0.0306 ns | 0.0239 ns |  8.458 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.634 ns | 0.0190 ns | 0.0169 ns | 13.635 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.731 ns | 0.0221 ns | 0.0196 ns | 13.732 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.952 ns | 0.0141 ns | 0.0118 ns | 17.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.092 ns | 0.0253 ns | 0.0224 ns | 15.097 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.640 ns | 0.0211 ns | 0.0187 ns | 15.639 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 18.360 ns | 0.0328 ns | 0.0274 ns | 18.359 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.459 ns | 0.0307 ns | 0.0272 ns | 21.452 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.495 ns | 0.0331 ns | 0.0309 ns | 14.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.637 ns | 0.0203 ns | 0.0159 ns | 11.632 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.497 ns | 0.5728 ns | 0.9085 ns |  7.995 ns |  0.63 |    0.07 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.044 ns | 0.1366 ns | 0.1278 ns | 14.113 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.474 ns | 0.0128 ns | 0.0120 ns | 13.475 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.031 ns | 0.0273 ns | 0.0255 ns | 15.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.094 ns | 0.0099 ns | 0.0083 ns | 12.097 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.030 ns | 0.0199 ns | 0.0166 ns | 12.027 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.181 ns | 0.0243 ns | 0.0227 ns | 13.176 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.707 ns | 0.0994 ns | 0.0929 ns | 16.659 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.197 ns | 0.0333 ns | 0.0260 ns | 14.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.918 ns | 0.0132 ns | 0.0124 ns | 11.919 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.800 ns | 0.0230 ns | 0.0215 ns | 13.804 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.057 ns | 0.0443 ns | 0.0415 ns | 15.051 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.879 ns | 0.1042 ns | 0.0974 ns | 15.919 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.473 ns | 0.0138 ns | 0.0108 ns | 11.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.054 ns | 0.0122 ns | 0.0095 ns |  9.053 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.999 ns | 0.0723 ns | 0.0604 ns | 11.026 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 10.685 ns | 0.0178 ns | 0.0167 ns | 10.684 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.281 ns | 0.0232 ns | 0.0217 ns | 11.281 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.439 ns | 0.0215 ns | 0.0180 ns | 14.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.306 ns | 0.0186 ns | 0.0164 ns | 12.313 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.433 ns | 0.2756 ns | 0.3385 ns | 12.645 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.351 ns | 0.0166 ns | 0.0147 ns | 14.353 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 17.114 ns | 0.0305 ns | 0.0271 ns | 17.106 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.165 ns | 0.1166 ns | 0.1090 ns | 15.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.476 ns | 0.0340 ns | 0.0284 ns | 13.470 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.963 ns | 0.0321 ns | 0.0268 ns | 12.953 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.571 ns | 0.0655 ns | 0.0612 ns | 17.589 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.786 ns | 0.0302 ns | 0.0253 ns | 16.782 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 17.447 ns | 0.0290 ns | 0.0272 ns | 17.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.365 ns | 0.0161 ns | 0.0134 ns | 14.366 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.591 ns | 0.1679 ns | 0.1571 ns | 14.505 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.765 ns | 0.0282 ns | 0.0236 ns | 16.761 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.502 ns | 0.0495 ns | 0.0413 ns | 19.495 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 12.992 ns | 0.0258 ns | 0.0229 ns | 12.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.481 ns | 0.0171 ns | 0.0152 ns | 12.479 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.767 ns | 0.0132 ns | 0.0117 ns | 11.764 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.903 ns | 0.0281 ns | 0.0249 ns | 14.900 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.905 ns | 0.0440 ns | 0.0390 ns | 13.913 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.137 ns | 0.0185 ns | 0.0154 ns | 14.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.913 ns | 0.0151 ns | 0.0134 ns | 11.908 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.483 ns | 0.2543 ns | 0.1985 ns | 12.565 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.283 ns | 0.0118 ns | 0.0110 ns | 13.282 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.941 ns | 0.0261 ns | 0.0244 ns | 15.936 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.033 ns | 0.0386 ns | 0.0361 ns | 13.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.182 ns | 0.0197 ns | 0.0175 ns | 11.181 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.804 ns | 0.1117 ns | 0.1045 ns | 10.751 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.398 ns | 0.0165 ns | 0.0146 ns | 12.399 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.604 ns | 0.0197 ns | 0.0175 ns | 12.602 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.006 ns | 0.0741 ns | 0.0693 ns | 16.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.408 ns | 0.0407 ns | 0.0361 ns | 13.407 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.500 ns | 0.1044 ns | 0.0926 ns | 15.488 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 14.939 ns | 0.0219 ns | 0.0194 ns | 14.933 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.285 ns | 0.0264 ns | 0.0221 ns | 18.281 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.831 ns | 0.0232 ns | 0.0217 ns | 12.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.259 ns | 0.0929 ns | 0.0869 ns | 11.294 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.935 ns | 0.0789 ns | 0.0738 ns | 10.945 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 13.906 ns | 0.0150 ns | 0.0133 ns | 13.910 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.834 ns | 0.0204 ns | 0.0191 ns | 12.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.354 ns | 0.0266 ns | 0.0236 ns | 14.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.923 ns | 0.0201 ns | 0.0178 ns | 11.924 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.055 ns | 0.0280 ns | 0.0248 ns | 12.057 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.310 ns | 0.0171 ns | 0.0160 ns | 13.303 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.940 ns | 0.0330 ns | 0.0293 ns | 15.944 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.982 ns | 0.0892 ns | 0.0791 ns | 21.008 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.343 ns | 0.0354 ns | 0.0331 ns | 16.340 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.038 ns | 0.1006 ns | 0.0786 ns | 12.041 ns |  0.57 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.488 ns | 0.0406 ns | 0.0317 ns | 19.492 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.845 ns | 0.0436 ns | 0.0408 ns | 18.844 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.142 ns | 0.0337 ns | 0.0299 ns | 18.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.778 ns | 0.1873 ns | 0.1752 ns | 14.874 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.459 ns | 0.0400 ns | 0.0374 ns | 15.458 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.179 ns | 0.0209 ns | 0.0185 ns | 17.179 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.762 ns | 0.1400 ns | 0.1310 ns | 20.835 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.313 ns | 0.0621 ns | 0.0581 ns | 19.298 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.961 ns | 0.0433 ns | 0.0383 ns | 15.958 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.033 ns | 0.0699 ns | 0.0619 ns | 13.021 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 21.043 ns | 0.0364 ns | 0.0322 ns | 21.035 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.878 ns | 0.0332 ns | 0.0278 ns | 17.877 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.946 ns | 0.0379 ns | 0.0317 ns | 17.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.660 ns | 0.0461 ns | 0.0431 ns | 14.651 ns |  0.82 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.570 ns | 0.1399 ns | 0.1309 ns | 15.512 ns |  0.87 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.193 ns | 0.0294 ns | 0.0261 ns | 17.189 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.523 ns | 0.0394 ns | 0.0349 ns | 20.520 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.048 ns | 0.0191 ns | 0.0179 ns | 15.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.729 ns | 0.0177 ns | 0.0157 ns | 11.728 ns |  0.78 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.108 ns | 0.0175 ns | 0.0155 ns |  7.105 ns |  0.47 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.344 ns | 0.1088 ns | 0.1018 ns | 12.423 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 12.204 ns | 0.0909 ns | 0.0851 ns | 12.225 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.517 ns | 0.0265 ns | 0.0235 ns | 15.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.635 ns | 0.0162 ns | 0.0135 ns | 12.633 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.124 ns | 0.0945 ns | 0.0884 ns | 12.080 ns |  0.78 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.155 ns | 0.0251 ns | 0.0222 ns | 13.155 ns |  0.85 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.127 ns | 0.0236 ns | 0.0209 ns | 16.129 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.056 ns | 0.0391 ns | 0.0365 ns | 13.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.697 ns | 0.0705 ns | 0.0589 ns | 11.715 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.539 ns | 0.0832 ns | 0.0778 ns |  6.587 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.588 ns | 0.0384 ns | 0.0359 ns | 12.580 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.400 ns | 0.0317 ns | 0.0264 ns | 10.399 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.049 ns | 0.0145 ns | 0.0129 ns | 16.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.338 ns | 0.0121 ns | 0.0113 ns | 13.337 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.677 ns | 0.1380 ns | 0.1291 ns | 13.691 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.999 ns | 0.0233 ns | 0.0218 ns | 15.005 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.773 ns | 0.0302 ns | 0.0282 ns | 16.775 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.601 ns | 0.0171 ns | 0.0143 ns | 13.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.403 ns | 0.0146 ns | 0.0130 ns | 11.404 ns |  0.84 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.785 ns | 0.0567 ns | 0.0531 ns |  6.764 ns |  0.50 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.096 ns | 0.0302 ns | 0.0267 ns | 13.094 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.404 ns | 0.0121 ns | 0.0113 ns | 10.403 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.791 ns | 0.0245 ns | 0.0229 ns | 15.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.877 ns | 0.0409 ns | 0.0383 ns | 13.867 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.065 ns | 0.3080 ns | 0.5230 ns | 13.737 ns |  0.92 |    0.04 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.363 ns | 0.0318 ns | 0.0248 ns | 15.363 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.927 ns | 0.0855 ns | 0.0799 ns | 18.953 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.941 ns | 0.0164 ns | 0.0146 ns | 12.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.407 ns | 0.0172 ns | 0.0153 ns | 11.403 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.105 ns | 0.1611 ns | 0.1978 ns |  7.206 ns |  0.54 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.027 ns | 0.0095 ns | 0.0089 ns | 12.025 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.782 ns | 0.0099 ns | 0.0083 ns | 11.784 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.439 ns | 0.0720 ns | 0.0638 ns | 14.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.926 ns | 0.0172 ns | 0.0153 ns | 11.923 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.029 ns | 0.0306 ns | 0.0271 ns | 12.028 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.325 ns | 0.0237 ns | 0.0210 ns | 15.321 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.414 ns | 0.0956 ns | 0.0848 ns | 17.444 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.707 ns | 0.0297 ns | 0.0278 ns | 13.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.717 ns | 0.0808 ns | 0.0717 ns | 11.739 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.660 ns | 0.0761 ns | 0.0712 ns |  6.630 ns |  0.49 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.452 ns | 0.0302 ns | 0.0283 ns | 12.440 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 11.835 ns | 0.0263 ns | 0.0246 ns | 11.832 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.809 ns | 0.1293 ns | 0.1079 ns | 46.784 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.982 ns | 0.1035 ns | 0.0917 ns | 42.983 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 33.886 ns | 0.1672 ns | 0.1396 ns | 33.930 ns |  0.72 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.137 ns | 0.0562 ns | 0.0469 ns | 42.139 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 45.398 ns | 0.2065 ns | 0.1725 ns | 45.429 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.127 ns | 0.0205 ns | 0.0181 ns | 13.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.282 ns | 0.0147 ns | 0.0130 ns | 10.279 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.120 ns | 0.0143 ns | 0.0127 ns |  7.120 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.194 ns | 0.1278 ns | 0.1195 ns | 13.133 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.679 ns | 0.0263 ns | 0.0246 ns | 10.668 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.167 ns | 0.1744 ns | 0.1632 ns | 44.124 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.871 ns | 0.0714 ns | 0.0633 ns | 42.858 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 35.465 ns | 0.0572 ns | 0.0535 ns | 35.472 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.932 ns | 0.1407 ns | 0.1247 ns | 42.950 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 45.884 ns | 0.3494 ns | 0.3268 ns | 46.099 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.225 ns | 0.0747 ns | 0.0663 ns | 13.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.451 ns | 0.0190 ns | 0.0159 ns | 11.449 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.943 ns | 0.0937 ns | 0.0876 ns |  6.890 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.563 ns | 0.0153 ns | 0.0128 ns | 12.561 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 11.968 ns | 0.0323 ns | 0.0287 ns | 11.961 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.147 ns | 0.0120 ns | 0.0107 ns | 14.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.845 ns | 0.0242 ns | 0.0202 ns | 12.839 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.063 ns | 0.0597 ns | 0.0499 ns | 12.040 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.302 ns | 0.0337 ns | 0.0299 ns | 13.306 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.466 ns | 0.0209 ns | 0.0175 ns | 15.462 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.018 ns | 0.0428 ns | 0.0400 ns | 12.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.181 ns | 0.0163 ns | 0.0153 ns | 11.186 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.230 ns | 0.2481 ns | 0.3478 ns | 11.456 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.028 ns | 0.0179 ns | 0.0149 ns | 12.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.770 ns | 0.0604 ns | 0.0565 ns | 12.793 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.511 ns | 0.0252 ns | 0.0223 ns | 15.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.672 ns | 0.0242 ns | 0.0214 ns | 13.672 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.947 ns | 0.1302 ns | 0.1218 ns | 14.008 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.797 ns | 0.0133 ns | 0.0125 ns | 17.799 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.913 ns | 0.0620 ns | 0.0580 ns | 18.890 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.825 ns | 0.0215 ns | 0.0180 ns | 12.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.176 ns | 0.0136 ns | 0.0106 ns | 11.172 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.568 ns | 0.2495 ns | 0.2670 ns | 11.693 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.851 ns | 0.1060 ns | 0.0992 ns | 13.908 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.652 ns | 0.0508 ns | 0.0475 ns | 12.639 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.348 ns | 0.0139 ns | 0.0130 ns | 14.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 11.937 ns | 0.0140 ns | 0.0131 ns | 11.933 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.006 ns | 0.0225 ns | 0.0188 ns | 12.006 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.145 ns | 0.0246 ns | 0.0218 ns | 13.150 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.272 ns | 0.0613 ns | 0.0574 ns | 15.290 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.421 ns | 0.0492 ns | 0.0437 ns | 39.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.726 ns | 0.0730 ns | 0.0647 ns | 37.714 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.171 ns | 0.7796 ns | 1.5925 ns | 37.255 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.713 ns | 0.1078 ns | 0.1009 ns | 39.704 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.440 ns | 0.1003 ns | 0.0938 ns | 38.418 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.528 ns | 0.0541 ns | 0.0506 ns | 15.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.115 ns | 0.0166 ns | 0.0155 ns | 14.118 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.035 ns | 0.0346 ns | 0.0270 ns | 14.029 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.875 ns | 0.0297 ns | 0.0263 ns | 15.873 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.428 ns | 0.0444 ns | 0.0415 ns | 17.426 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.711 ns | 0.1544 ns | 0.1369 ns | 39.744 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.884 ns | 0.0456 ns | 0.0404 ns | 37.885 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.167 ns | 0.5317 ns | 0.4974 ns | 35.450 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.964 ns | 0.0830 ns | 0.0693 ns | 39.951 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.176 ns | 0.2347 ns | 0.2195 ns | 40.175 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.605 ns | 0.0224 ns | 0.0199 ns | 15.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.783 ns | 0.0834 ns | 0.0780 ns | 13.772 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.878 ns | 0.0543 ns | 0.0454 ns | 13.863 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.445 ns | 0.0291 ns | 0.0227 ns | 15.440 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.681 ns | 0.0314 ns | 0.0293 ns | 17.687 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.239 ns | 0.0931 ns | 0.0871 ns | 39.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.021 ns | 0.0941 ns | 0.0880 ns | 38.030 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.162 ns | 0.7189 ns | 0.7991 ns | 35.695 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.641 ns | 0.0528 ns | 0.0494 ns | 39.637 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.847 ns | 0.1285 ns | 0.1202 ns | 38.876 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.041 ns | 0.0265 ns | 0.0248 ns | 15.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.745 ns | 0.0141 ns | 0.0125 ns | 13.747 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.030 ns | 0.0541 ns | 0.0506 ns | 12.006 ns |  0.80 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.312 ns | 0.0480 ns | 0.0425 ns | 13.321 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.936 ns | 0.0892 ns | 0.0834 ns | 16.973 ns |  1.13 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Bool.From_Char_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_Char_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_Char_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_Char_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Bool.From_Char_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Bool.From_DateTime_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_DateTime_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_DateTime_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_DateTime_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Bool.From_DateTime_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: Job-YRWWQX(Toolchain=net472)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-LRKCAO(Toolchain=.NET Core 2.0)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-VAJWLV(Toolchain=.NET Core 2.2)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-TJIRAH(Toolchain=.NET Core 3.0)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-HBFVIR(Toolchain=net461)
  ConvertTo_Bool.From_String_Empty_AsObject: Job-YRWWQX(Toolchain=net472)
