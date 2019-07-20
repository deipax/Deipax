
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
                                             From_Bool | .NET Core 2.0 | 14.266 ns | 0.0127 ns | 0.0119 ns | 14.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.122 ns | 0.0110 ns | 0.0103 ns | 12.121 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.004 ns | 0.0162 ns | 0.0144 ns |  8.005 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.514 ns | 0.0189 ns | 0.0168 ns | 14.506 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.130 ns | 0.0100 ns | 0.0089 ns | 13.130 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.370 ns | 0.0329 ns | 0.0275 ns | 19.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.617 ns | 0.0221 ns | 0.0206 ns | 16.609 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.673 ns | 0.0818 ns | 0.0725 ns | 18.697 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 20.223 ns | 0.0128 ns | 0.0120 ns | 20.223 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 21.610 ns | 0.0418 ns | 0.0391 ns | 21.595 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 14.777 ns | 0.0144 ns | 0.0128 ns | 14.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.185 ns | 0.0235 ns | 0.0208 ns | 11.192 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.226 ns | 0.0133 ns | 0.0124 ns |  8.225 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.792 ns | 0.0391 ns | 0.0347 ns | 14.797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.456 ns | 0.0196 ns | 0.0183 ns | 13.453 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.133 ns | 0.0235 ns | 0.0220 ns | 19.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.142 ns | 0.0174 ns | 0.0163 ns | 17.141 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.035 ns | 0.3854 ns | 0.7873 ns | 18.436 ns |  0.89 |    0.05 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 20.310 ns | 0.0311 ns | 0.0276 ns | 20.308 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 21.583 ns | 0.0190 ns | 0.0178 ns | 21.587 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 14.079 ns | 0.0127 ns | 0.0119 ns | 14.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.716 ns | 0.0208 ns | 0.0162 ns | 10.717 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  8.262 ns | 0.0100 ns | 0.0089 ns |  8.263 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.655 ns | 0.0103 ns | 0.0096 ns | 13.652 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.865 ns | 0.0147 ns | 0.0138 ns | 12.867 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.584 ns | 0.0314 ns | 0.0278 ns | 15.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.067 ns | 0.0102 ns | 0.0096 ns | 13.069 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.418 ns | 0.0339 ns | 0.0283 ns | 14.419 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.700 ns | 0.0099 ns | 0.0082 ns | 14.700 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 17.393 ns | 0.0173 ns | 0.0162 ns | 17.398 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.657 ns | 0.0276 ns | 0.0258 ns | 12.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.693 ns | 0.0130 ns | 0.0121 ns | 10.691 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.533 ns | 0.0092 ns | 0.0081 ns |  7.534 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.478 ns | 0.0197 ns | 0.0184 ns | 14.477 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 13.016 ns | 0.0149 ns | 0.0140 ns | 13.010 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.387 ns | 0.0408 ns | 0.0340 ns | 19.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 19.314 ns | 0.0302 ns | 0.0283 ns | 19.315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.027 ns | 0.0318 ns | 0.0248 ns | 16.031 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 22.273 ns | 0.0972 ns | 0.0909 ns | 22.242 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 21.408 ns | 0.0207 ns | 0.0184 ns | 21.408 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 14.600 ns | 0.0134 ns | 0.0119 ns | 14.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.383 ns | 0.0247 ns | 0.0231 ns | 11.380 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.558 ns | 0.0167 ns | 0.0148 ns |  7.557 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 15.154 ns | 0.0217 ns | 0.0203 ns | 15.151 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.317 ns | 0.0257 ns | 0.0201 ns | 14.321 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.376 ns | 0.0245 ns | 0.0218 ns | 19.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.017 ns | 0.0263 ns | 0.0246 ns | 17.013 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.545 ns | 0.0265 ns | 0.0248 ns | 15.546 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 20.356 ns | 0.0184 ns | 0.0172 ns | 20.360 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.583 ns | 0.0244 ns | 0.0203 ns | 21.589 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.111 ns | 0.0140 ns | 0.0124 ns | 14.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.699 ns | 0.0080 ns | 0.0067 ns | 10.698 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.777 ns | 0.0080 ns | 0.0071 ns |  7.774 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.276 ns | 0.0227 ns | 0.0190 ns | 14.273 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 14.589 ns | 0.0241 ns | 0.0225 ns | 14.584 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.636 ns | 0.0232 ns | 0.0181 ns | 15.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.728 ns | 0.0172 ns | 0.0161 ns | 14.733 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.662 ns | 0.2727 ns | 0.3911 ns | 12.940 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.298 ns | 0.0156 ns | 0.0122 ns | 15.298 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.309 ns | 0.0197 ns | 0.0174 ns | 16.309 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.468 ns | 0.0245 ns | 0.0229 ns | 13.467 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.887 ns | 0.0375 ns | 0.0313 ns | 10.894 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.060 ns | 0.0143 ns | 0.0133 ns |  7.064 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.682 ns | 0.0149 ns | 0.0125 ns | 14.684 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.489 ns | 0.0229 ns | 0.0214 ns | 13.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.640 ns | 0.0795 ns | 0.0743 ns | 12.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.929 ns | 0.0148 ns | 0.0138 ns | 10.928 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.561 ns | 0.0147 ns | 0.0131 ns |  7.557 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 15.032 ns | 0.0198 ns | 0.0185 ns | 15.032 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.096 ns | 0.0131 ns | 0.0116 ns | 13.092 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.518 ns | 0.0098 ns | 0.0087 ns | 12.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.575 ns | 0.0103 ns | 0.0092 ns | 10.575 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.557 ns | 0.0131 ns | 0.0122 ns |  7.557 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.749 ns | 0.0219 ns | 0.0194 ns | 14.746 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.988 ns | 0.0154 ns | 0.0128 ns | 12.990 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.592 ns | 0.0615 ns | 0.0575 ns | 15.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.107 ns | 0.0453 ns | 0.0402 ns | 13.089 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.119 ns | 0.0346 ns | 0.0306 ns | 13.128 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.357 ns | 0.0198 ns | 0.0176 ns | 15.366 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.484 ns | 0.0201 ns | 0.0178 ns | 17.484 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.513 ns | 0.0138 ns | 0.0122 ns | 12.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.402 ns | 0.0120 ns | 0.0107 ns | 11.400 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.023 ns | 0.0101 ns | 0.0089 ns |  8.023 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 15.985 ns | 0.0640 ns | 0.0599 ns | 15.995 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.639 ns | 0.0657 ns | 0.0615 ns | 13.616 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.475 ns | 0.0180 ns | 0.0169 ns | 12.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.545 ns | 0.0103 ns | 0.0091 ns | 11.547 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.582 ns | 0.0148 ns | 0.0115 ns |  8.580 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.334 ns | 0.0185 ns | 0.0173 ns | 14.333 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.675 ns | 0.0157 ns | 0.0131 ns | 13.676 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.638 ns | 0.0109 ns | 0.0096 ns | 12.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.428 ns | 0.0125 ns | 0.0117 ns | 11.428 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.459 ns | 0.0135 ns | 0.0126 ns |  8.464 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.695 ns | 0.0155 ns | 0.0145 ns | 14.694 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.393 ns | 0.0440 ns | 0.0411 ns | 13.402 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.495 ns | 0.0195 ns | 0.0183 ns | 15.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.580 ns | 0.0386 ns | 0.0361 ns | 13.587 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.042 ns | 0.0140 ns | 0.0109 ns | 13.044 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 14.678 ns | 0.0160 ns | 0.0150 ns | 14.683 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 17.264 ns | 0.0277 ns | 0.0259 ns | 17.264 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 12.371 ns | 0.0144 ns | 0.0120 ns | 12.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 11.504 ns | 0.0364 ns | 0.0341 ns | 11.496 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |  8.224 ns | 0.0141 ns | 0.0125 ns |  8.226 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 13.043 ns | 0.0114 ns | 0.0106 ns | 13.041 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 12.932 ns | 0.0101 ns | 0.0095 ns | 12.934 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 15.557 ns | 0.0365 ns | 0.0305 ns | 15.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 13.530 ns | 0.0341 ns | 0.0319 ns | 13.539 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 13.770 ns | 0.3029 ns | 0.3241 ns | 13.960 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 15.623 ns | 0.0290 ns | 0.0242 ns | 15.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 16.632 ns | 0.0255 ns | 0.0226 ns | 16.633 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 12.725 ns | 0.0104 ns | 0.0097 ns | 12.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 12.024 ns | 0.0166 ns | 0.0155 ns | 12.023 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  9.119 ns | 0.1259 ns | 0.1178 ns |  9.171 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 13.556 ns | 0.0154 ns | 0.0144 ns | 13.561 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 13.652 ns | 0.0214 ns | 0.0200 ns | 13.654 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.615 ns | 0.0197 ns | 0.0164 ns | 15.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.345 ns | 0.0135 ns | 0.0120 ns | 13.344 ns |  0.85 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.460 ns | 0.1130 ns | 0.1057 ns | 13.502 ns |  0.86 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 15.152 ns | 0.0252 ns | 0.0211 ns | 15.147 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 16.999 ns | 0.0281 ns | 0.0249 ns | 17.001 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.547 ns | 0.0159 ns | 0.0148 ns | 12.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.231 ns | 0.0114 ns | 0.0106 ns | 12.231 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.632 ns | 0.0365 ns | 0.0342 ns |  8.640 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.623 ns | 0.0942 ns | 0.0881 ns | 14.678 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.872 ns | 0.0949 ns | 0.0888 ns | 13.835 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.282 ns | 0.0290 ns | 0.0257 ns | 16.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.562 ns | 0.0165 ns | 0.0147 ns | 14.559 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.591 ns | 0.2930 ns | 0.4108 ns | 13.855 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.246 ns | 0.0156 ns | 0.0146 ns | 15.245 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.700 ns | 0.0468 ns | 0.0415 ns | 16.712 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 64.776 ns | 0.1829 ns | 0.1711 ns | 64.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 60.308 ns | 0.0931 ns | 0.0871 ns | 60.295 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 16.683 ns | 0.0191 ns | 0.0179 ns | 16.679 ns |  0.26 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 63.236 ns | 0.0910 ns | 0.0806 ns | 63.243 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 62.809 ns | 0.0731 ns | 0.0648 ns | 62.809 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 69.764 ns | 0.0410 ns | 0.0364 ns | 69.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 68.186 ns | 0.1053 ns | 0.0879 ns | 68.159 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 25.182 ns | 0.1391 ns | 0.1301 ns | 25.238 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 69.350 ns | 0.0318 ns | 0.0297 ns | 69.343 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 70.861 ns | 0.0951 ns | 0.0843 ns | 70.885 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 64.595 ns | 0.0887 ns | 0.0740 ns | 64.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 60.428 ns | 0.3118 ns | 0.2916 ns | 60.565 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 17.138 ns | 0.0302 ns | 0.0267 ns | 17.131 ns |  0.27 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 63.835 ns | 0.0672 ns | 0.0629 ns | 63.831 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 63.096 ns | 0.0795 ns | 0.0705 ns | 63.087 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 69.798 ns | 0.0905 ns | 0.0802 ns | 69.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 68.392 ns | 0.0880 ns | 0.0823 ns | 68.391 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 26.801 ns | 0.1019 ns | 0.0953 ns | 26.822 ns |  0.38 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 69.281 ns | 0.0608 ns | 0.0475 ns | 69.296 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 70.630 ns | 0.0685 ns | 0.0607 ns | 70.627 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.069 ns | 0.0316 ns | 0.0295 ns | 14.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.505 ns | 0.0187 ns | 0.0175 ns | 11.504 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.162 ns | 0.2098 ns | 0.2728 ns |  9.341 ns |  0.64 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.617 ns | 0.0262 ns | 0.0245 ns | 14.614 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.141 ns | 0.0255 ns | 0.0226 ns | 14.142 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.564 ns | 0.0393 ns | 0.0367 ns | 15.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.240 ns | 0.0608 ns | 0.0568 ns | 13.215 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.155 ns | 0.1991 ns | 0.1863 ns | 13.046 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 18.334 ns | 0.0920 ns | 0.0861 ns | 18.286 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.547 ns | 0.0263 ns | 0.0246 ns | 16.545 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 14.188 ns | 0.0205 ns | 0.0192 ns | 14.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.218 ns | 0.0237 ns | 0.0210 ns | 11.212 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.540 ns | 0.0100 ns | 0.0094 ns |  7.537 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.203 ns | 0.0223 ns | 0.0198 ns | 14.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.939 ns | 0.0703 ns | 0.0657 ns | 13.915 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.414 ns | 0.0083 ns | 0.0074 ns | 19.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.604 ns | 0.0106 ns | 0.0094 ns | 16.605 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.793 ns | 0.0210 ns | 0.0197 ns | 19.797 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 20.888 ns | 0.0381 ns | 0.0356 ns | 20.888 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 22.594 ns | 0.0862 ns | 0.0806 ns | 22.619 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 15.291 ns | 0.0264 ns | 0.0247 ns | 15.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.022 ns | 0.0401 ns | 0.0356 ns | 11.013 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.410 ns | 0.2129 ns | 0.2768 ns |  9.589 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.737 ns | 0.0522 ns | 0.0463 ns | 14.747 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.829 ns | 0.0130 ns | 0.0122 ns | 13.831 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.639 ns | 0.0218 ns | 0.0204 ns | 19.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.598 ns | 0.0161 ns | 0.0150 ns | 16.593 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.508 ns | 0.3421 ns | 0.3513 ns | 16.284 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 20.880 ns | 0.0233 ns | 0.0207 ns | 20.885 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 21.814 ns | 0.0339 ns | 0.0301 ns | 21.810 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 14.061 ns | 0.0132 ns | 0.0123 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.269 ns | 0.0191 ns | 0.0160 ns | 11.266 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.649 ns | 0.2291 ns | 0.2728 ns |  7.506 ns |  0.55 |    0.02 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.711 ns | 0.0214 ns | 0.0190 ns | 13.713 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.149 ns | 0.0141 ns | 0.0132 ns | 13.151 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.558 ns | 0.0723 ns | 0.0676 ns | 15.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.538 ns | 0.0103 ns | 0.0086 ns | 13.537 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.388 ns | 0.2598 ns | 0.2668 ns | 12.237 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.687 ns | 0.0174 ns | 0.0163 ns | 14.687 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.511 ns | 0.0166 ns | 0.0147 ns | 16.516 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 14.288 ns | 0.0367 ns | 0.0326 ns | 14.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.670 ns | 0.0210 ns | 0.0186 ns | 10.678 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.909 ns | 0.2175 ns | 0.2671 ns |  9.991 ns |  0.69 |    0.02 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.817 ns | 0.0138 ns | 0.0129 ns | 13.817 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.906 ns | 0.0267 ns | 0.0250 ns | 13.900 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.729 ns | 0.0291 ns | 0.0243 ns | 19.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.436 ns | 0.0984 ns | 0.0920 ns | 16.392 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.726 ns | 0.1658 ns | 0.1470 ns | 16.754 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 20.474 ns | 0.0345 ns | 0.0323 ns | 20.480 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 22.261 ns | 0.0339 ns | 0.0300 ns | 22.259 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 14.405 ns | 0.0207 ns | 0.0173 ns | 14.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.488 ns | 0.0133 ns | 0.0125 ns | 11.488 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  9.637 ns | 0.2181 ns | 0.2512 ns |  9.712 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.597 ns | 0.0283 ns | 0.0265 ns | 14.592 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.998 ns | 0.2286 ns | 0.2139 ns | 14.961 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.123 ns | 0.0597 ns | 0.0529 ns | 19.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.933 ns | 0.0673 ns | 0.0630 ns | 16.927 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.129 ns | 0.1999 ns | 0.1870 ns | 15.974 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 20.155 ns | 0.0347 ns | 0.0325 ns | 20.154 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 22.122 ns | 0.0336 ns | 0.0314 ns | 22.125 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.046 ns | 0.0118 ns | 0.0098 ns | 14.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.096 ns | 0.0066 ns | 0.0055 ns | 11.095 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.551 ns | 0.0123 ns | 0.0115 ns |  7.553 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.244 ns | 0.0141 ns | 0.0132 ns | 14.246 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.746 ns | 0.0476 ns | 0.0422 ns | 13.736 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.609 ns | 0.0222 ns | 0.0186 ns | 15.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.112 ns | 0.0191 ns | 0.0169 ns | 13.109 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.007 ns | 0.2829 ns | 0.4057 ns | 13.211 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.716 ns | 0.0230 ns | 0.0215 ns | 14.712 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 16.382 ns | 0.0183 ns | 0.0153 ns | 16.384 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 14.081 ns | 0.0119 ns | 0.0106 ns | 14.080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.667 ns | 0.0239 ns | 0.0212 ns | 10.663 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.363 ns | 0.1914 ns | 0.2555 ns |  8.228 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.931 ns | 0.0098 ns | 0.0087 ns | 14.930 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.138 ns | 0.0414 ns | 0.0345 ns | 13.133 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.590 ns | 0.0258 ns | 0.0229 ns | 19.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.506 ns | 0.0449 ns | 0.0420 ns | 17.508 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.384 ns | 0.0906 ns | 0.0847 ns | 16.377 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 20.380 ns | 0.0272 ns | 0.0227 ns | 20.389 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.741 ns | 0.0484 ns | 0.0429 ns | 21.743 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.319 ns | 0.0150 ns | 0.0133 ns | 14.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.825 ns | 0.0142 ns | 0.0133 ns | 11.824 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  9.917 ns | 0.0689 ns | 0.0644 ns |  9.902 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.676 ns | 0.0181 ns | 0.0169 ns | 14.679 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.636 ns | 0.0237 ns | 0.0210 ns | 13.641 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.907 ns | 0.0362 ns | 0.0338 ns | 19.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.601 ns | 0.0286 ns | 0.0268 ns | 16.600 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.592 ns | 0.0288 ns | 0.0255 ns | 18.596 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 20.461 ns | 0.0508 ns | 0.0424 ns | 20.466 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.714 ns | 0.0357 ns | 0.0334 ns | 21.718 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.903 ns | 0.0294 ns | 0.0275 ns | 13.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.433 ns | 0.0125 ns | 0.0111 ns | 11.435 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.887 ns | 0.0473 ns | 0.0442 ns |  8.869 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.363 ns | 0.0251 ns | 0.0196 ns | 14.363 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.714 ns | 0.1406 ns | 0.1315 ns | 14.711 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.526 ns | 0.0225 ns | 0.0199 ns | 15.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.093 ns | 0.0146 ns | 0.0129 ns | 13.094 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.179 ns | 0.2078 ns | 0.1944 ns | 13.049 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.689 ns | 0.0252 ns | 0.0223 ns | 14.689 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 16.300 ns | 0.0198 ns | 0.0176 ns | 16.301 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 14.147 ns | 0.0171 ns | 0.0160 ns | 14.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.714 ns | 0.0205 ns | 0.0192 ns | 10.717 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  8.019 ns | 0.0110 ns | 0.0097 ns |  8.020 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.301 ns | 0.0179 ns | 0.0167 ns | 14.296 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.030 ns | 0.0137 ns | 0.0129 ns | 13.029 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.023 ns | 0.0979 ns | 0.0916 ns | 20.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.922 ns | 0.0395 ns | 0.0370 ns | 16.916 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.559 ns | 0.3485 ns | 0.4886 ns | 16.930 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 20.172 ns | 0.0436 ns | 0.0408 ns | 20.167 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 22.437 ns | 0.0925 ns | 0.0865 ns | 22.456 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 14.515 ns | 0.0757 ns | 0.0671 ns | 14.521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.187 ns | 0.0750 ns | 0.0701 ns | 11.144 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  9.008 ns | 0.2034 ns | 0.2261 ns |  8.854 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.568 ns | 0.0165 ns | 0.0147 ns | 14.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.600 ns | 0.0158 ns | 0.0148 ns | 13.597 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.511 ns | 0.1052 ns | 0.0984 ns | 20.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.609 ns | 0.0152 ns | 0.0142 ns | 17.608 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.177 ns | 0.0344 ns | 0.0322 ns | 16.182 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 20.410 ns | 0.0334 ns | 0.0296 ns | 20.407 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.674 ns | 0.0320 ns | 0.0299 ns | 21.681 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.158 ns | 0.0184 ns | 0.0172 ns | 14.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.746 ns | 0.0166 ns | 0.0155 ns | 10.741 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.848 ns | 0.2242 ns | 0.4372 ns | 10.009 ns |  0.67 |    0.05 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.725 ns | 0.0315 ns | 0.0294 ns | 14.718 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.868 ns | 0.0139 ns | 0.0130 ns | 12.868 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.499 ns | 0.0263 ns | 0.0246 ns | 15.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.247 ns | 0.0081 ns | 0.0072 ns | 13.248 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.736 ns | 0.2467 ns | 0.2308 ns | 13.555 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 18.276 ns | 0.0143 ns | 0.0127 ns | 18.276 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 17.431 ns | 0.0449 ns | 0.0420 ns | 17.420 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 32.382 ns | 0.0646 ns | 0.0605 ns | 32.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 28.936 ns | 0.1045 ns | 0.0977 ns | 28.972 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 15.800 ns | 0.0621 ns | 0.0581 ns | 15.781 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 33.088 ns | 0.0399 ns | 0.0354 ns | 33.077 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 32.981 ns | 0.0419 ns | 0.0392 ns | 32.981 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 39.265 ns | 0.0423 ns | 0.0375 ns | 39.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 37.462 ns | 0.2017 ns | 0.1887 ns | 37.538 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 23.668 ns | 0.0282 ns | 0.0264 ns | 23.666 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 38.981 ns | 0.0413 ns | 0.0386 ns | 38.983 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 39.381 ns | 0.0308 ns | 0.0273 ns | 39.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 33.031 ns | 0.0401 ns | 0.0356 ns | 33.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 28.567 ns | 0.0806 ns | 0.0754 ns | 28.548 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 16.255 ns | 0.0140 ns | 0.0117 ns | 16.258 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 32.789 ns | 0.0352 ns | 0.0329 ns | 32.785 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 33.492 ns | 0.0659 ns | 0.0584 ns | 33.497 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 38.932 ns | 0.0414 ns | 0.0387 ns | 38.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 37.297 ns | 0.0519 ns | 0.0485 ns | 37.291 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.792 ns | 0.0825 ns | 0.0771 ns | 23.828 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 38.794 ns | 0.0621 ns | 0.0551 ns | 38.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 39.755 ns | 0.1246 ns | 0.1105 ns | 39.767 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.256 ns | 0.0636 ns | 0.0595 ns | 14.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.991 ns | 0.0126 ns | 0.0118 ns | 11.998 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  8.704 ns | 0.0290 ns | 0.0226 ns |  8.713 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 15.130 ns | 0.0541 ns | 0.0506 ns | 15.141 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.664 ns | 0.0199 ns | 0.0176 ns | 13.668 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.311 ns | 0.0226 ns | 0.0211 ns | 16.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 16.019 ns | 0.0183 ns | 0.0162 ns | 16.015 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.054 ns | 0.0117 ns | 0.0091 ns | 13.056 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.692 ns | 0.0272 ns | 0.0254 ns | 14.691 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 17.971 ns | 0.0275 ns | 0.0257 ns | 17.969 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 83.391 ns | 0.0703 ns | 0.0623 ns | 83.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 75.392 ns | 0.1382 ns | 0.1154 ns | 75.387 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 57.883 ns | 0.2161 ns | 0.2021 ns | 57.968 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 83.924 ns | 0.1168 ns | 0.0912 ns | 83.936 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 86.459 ns | 0.1428 ns | 0.1335 ns | 86.442 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 89.898 ns | 0.1383 ns | 0.1294 ns | 89.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 82.688 ns | 0.0790 ns | 0.0739 ns | 82.705 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 62.747 ns | 0.0948 ns | 0.0792 ns | 62.772 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 90.700 ns | 0.1878 ns | 0.1757 ns | 90.670 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 91.447 ns | 0.1653 ns | 0.1546 ns | 91.444 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.722 ns | 0.0077 ns | 0.0072 ns | 13.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.130 ns | 0.0093 ns | 0.0087 ns | 13.132 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.947 ns | 0.0175 ns | 0.0164 ns | 11.948 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.242 ns | 0.0881 ns | 0.0781 ns | 14.240 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.098 ns | 0.0278 ns | 0.0246 ns | 16.102 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.597 ns | 0.0495 ns | 0.0439 ns | 15.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.203 ns | 0.0131 ns | 0.0122 ns | 13.202 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.284 ns | 0.0349 ns | 0.0310 ns | 13.287 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.791 ns | 0.0220 ns | 0.0184 ns | 14.792 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 17.921 ns | 0.0204 ns | 0.0191 ns | 17.922 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.768 ns | 0.0081 ns | 0.0072 ns | 14.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.061 ns | 0.0118 ns | 0.0110 ns | 12.060 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.657 ns | 0.0533 ns | 0.0499 ns | 11.634 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.107 ns | 0.0696 ns | 0.0651 ns | 14.091 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.296 ns | 0.0469 ns | 0.0391 ns | 16.291 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 14.152 ns | 0.0097 ns | 0.0091 ns | 14.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.451 ns | 0.0161 ns | 0.0151 ns | 11.451 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.294 ns | 0.0076 ns | 0.0063 ns |  7.295 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.279 ns | 0.0313 ns | 0.0261 ns | 14.281 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.924 ns | 0.0265 ns | 0.0248 ns | 13.921 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 23.226 ns | 0.0223 ns | 0.0186 ns | 23.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 16.954 ns | 0.0375 ns | 0.0350 ns | 16.958 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.871 ns | 0.0271 ns | 0.0253 ns | 15.872 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.747 ns | 0.0349 ns | 0.0309 ns | 20.748 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 22.436 ns | 0.0766 ns | 0.0716 ns | 22.453 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 14.456 ns | 0.0174 ns | 0.0136 ns | 14.452 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.004 ns | 0.0062 ns | 0.0055 ns | 11.005 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.764 ns | 0.0123 ns | 0.0115 ns |  7.764 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 15.093 ns | 0.0213 ns | 0.0189 ns | 15.096 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.599 ns | 0.0248 ns | 0.0232 ns | 15.598 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.118 ns | 0.0185 ns | 0.0154 ns | 20.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.550 ns | 0.0171 ns | 0.0142 ns | 16.551 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.847 ns | 0.0362 ns | 0.0283 ns | 15.849 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 22.666 ns | 0.0375 ns | 0.0351 ns | 22.669 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.754 ns | 0.0311 ns | 0.0291 ns | 21.752 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.099 ns | 0.0213 ns | 0.0199 ns | 14.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.643 ns | 0.0091 ns | 0.0081 ns | 10.644 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  8.538 ns | 0.1926 ns | 0.2999 ns |  8.367 ns |  0.62 |    0.03 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.285 ns | 0.0206 ns | 0.0193 ns | 14.284 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.061 ns | 0.0131 ns | 0.0122 ns | 13.057 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.480 ns | 0.1033 ns | 0.0967 ns | 16.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.084 ns | 0.0214 ns | 0.0179 ns | 13.087 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.504 ns | 0.2384 ns | 0.2230 ns | 12.336 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.686 ns | 0.0250 ns | 0.0234 ns | 14.684 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 16.346 ns | 0.0189 ns | 0.0168 ns | 16.347 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.449 ns | 0.0103 ns | 0.0096 ns | 12.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.496 ns | 0.0122 ns | 0.0108 ns | 10.493 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.391 ns | 0.0302 ns | 0.0268 ns |  7.399 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.249 ns | 0.0746 ns | 0.0698 ns | 14.274 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.023 ns | 0.0191 ns | 0.0169 ns | 13.022 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.403 ns | 0.0169 ns | 0.0150 ns | 19.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.520 ns | 0.0182 ns | 0.0170 ns | 17.519 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.605 ns | 0.0190 ns | 0.0169 ns | 15.607 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 22.135 ns | 0.0891 ns | 0.0790 ns | 22.131 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 22.011 ns | 0.0302 ns | 0.0268 ns | 22.007 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 15.180 ns | 0.0189 ns | 0.0177 ns | 15.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.395 ns | 0.0152 ns | 0.0119 ns | 11.395 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.753 ns | 0.0147 ns | 0.0123 ns |  7.747 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.483 ns | 0.0437 ns | 0.0409 ns | 14.491 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.912 ns | 0.0214 ns | 0.0200 ns | 13.912 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.384 ns | 0.0284 ns | 0.0252 ns | 19.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.312 ns | 0.0161 ns | 0.0150 ns | 16.313 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.859 ns | 0.0380 ns | 0.0356 ns | 15.854 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 22.407 ns | 0.0960 ns | 0.0898 ns | 22.416 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.444 ns | 0.0148 ns | 0.0116 ns | 21.447 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 16.321 ns | 0.3063 ns | 0.2558 ns | 16.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 12.030 ns | 0.0119 ns | 0.0106 ns | 12.028 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.521 ns | 0.0123 ns | 0.0115 ns |  7.519 ns |  0.46 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.239 ns | 0.0273 ns | 0.0242 ns | 14.239 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.094 ns | 0.0398 ns | 0.0373 ns | 13.077 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.285 ns | 0.1685 ns | 0.1576 ns | 16.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.105 ns | 0.0178 ns | 0.0167 ns | 13.109 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.179 ns | 0.0487 ns | 0.0455 ns | 13.195 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 17.444 ns | 0.0813 ns | 0.0760 ns | 17.414 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 16.338 ns | 0.0293 ns | 0.0274 ns | 16.331 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 14.098 ns | 0.1236 ns | 0.1156 ns | 14.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.563 ns | 0.0118 ns | 0.0104 ns | 10.563 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.297 ns | 0.0086 ns | 0.0080 ns |  7.297 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.565 ns | 0.0258 ns | 0.0229 ns | 13.561 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.133 ns | 0.0290 ns | 0.0242 ns | 13.138 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.170 ns | 0.0224 ns | 0.0209 ns | 19.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.707 ns | 0.0274 ns | 0.0243 ns | 16.709 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.003 ns | 0.1220 ns | 0.1141 ns | 15.996 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 20.339 ns | 0.0300 ns | 0.0266 ns | 20.343 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 22.030 ns | 0.0333 ns | 0.0312 ns | 22.040 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.067 ns | 0.0564 ns | 0.0528 ns | 14.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.562 ns | 0.0233 ns | 0.0207 ns | 11.557 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.676 ns | 0.0241 ns | 0.0214 ns |  8.682 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.561 ns | 0.0218 ns | 0.0204 ns | 15.554 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 16.950 ns | 0.0295 ns | 0.0246 ns | 16.945 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.430 ns | 0.0242 ns | 0.0226 ns | 19.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.548 ns | 0.0135 ns | 0.0120 ns | 16.546 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.859 ns | 0.0278 ns | 0.0260 ns | 15.857 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.455 ns | 0.0224 ns | 0.0210 ns | 20.461 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.365 ns | 0.0300 ns | 0.0266 ns | 21.362 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.923 ns | 0.0220 ns | 0.0184 ns | 13.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.443 ns | 0.0172 ns | 0.0161 ns | 11.447 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.086 ns | 0.2017 ns | 0.2892 ns |  9.231 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.718 ns | 0.0551 ns | 0.0460 ns | 14.702 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.320 ns | 0.0079 ns | 0.0070 ns | 13.322 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.516 ns | 0.0273 ns | 0.0256 ns | 15.504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.488 ns | 0.0141 ns | 0.0125 ns | 15.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.355 ns | 0.0460 ns | 0.0431 ns | 16.364 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.762 ns | 0.0147 ns | 0.0138 ns | 14.759 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.465 ns | 0.0144 ns | 0.0134 ns | 16.465 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.617 ns | 0.0424 ns | 0.0376 ns | 15.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.039 ns | 0.0115 ns | 0.0108 ns | 14.037 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.156 ns | 0.0145 ns | 0.0129 ns | 12.157 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.309 ns | 0.0200 ns | 0.0177 ns | 15.308 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.414 ns | 0.0266 ns | 0.0248 ns | 17.415 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.618 ns | 0.0410 ns | 0.0383 ns | 12.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.998 ns | 0.0171 ns | 0.0152 ns | 12.000 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.518 ns | 0.1163 ns | 0.1087 ns | 12.453 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.941 ns | 0.0225 ns | 0.0211 ns | 12.947 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.520 ns | 0.0138 ns | 0.0122 ns | 12.521 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 18.039 ns | 0.0192 ns | 0.0160 ns | 18.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.206 ns | 0.0172 ns | 0.0161 ns | 14.204 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.102 ns | 0.0641 ns | 0.0599 ns | 13.136 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.682 ns | 0.0238 ns | 0.0222 ns | 14.685 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.546 ns | 0.0195 ns | 0.0173 ns | 16.546 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.698 ns | 0.0180 ns | 0.0160 ns | 16.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.658 ns | 0.0113 ns | 0.0100 ns | 14.657 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.827 ns | 0.0793 ns | 0.0742 ns | 13.811 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.001 ns | 0.0191 ns | 0.0169 ns | 18.007 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 19.302 ns | 0.0196 ns | 0.0174 ns | 19.306 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.019 ns | 0.0250 ns | 0.0234 ns | 18.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.669 ns | 0.0221 ns | 0.0184 ns | 15.670 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.178 ns | 0.1093 ns | 0.1022 ns | 17.133 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 18.353 ns | 0.0318 ns | 0.0297 ns | 18.347 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 20.541 ns | 0.0222 ns | 0.0197 ns | 20.542 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.832 ns | 0.0215 ns | 0.0201 ns | 14.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.751 ns | 0.0124 ns | 0.0116 ns | 13.754 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.670 ns | 0.0128 ns | 0.0107 ns | 12.672 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.501 ns | 0.0234 ns | 0.0208 ns | 14.503 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 15.311 ns | 0.0109 ns | 0.0102 ns | 15.315 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.487 ns | 0.0143 ns | 0.0133 ns | 15.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.081 ns | 0.0165 ns | 0.0155 ns | 13.084 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.669 ns | 0.2890 ns | 0.3758 ns | 13.449 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 14.953 ns | 0.0174 ns | 0.0162 ns | 14.947 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 17.415 ns | 0.0307 ns | 0.0287 ns | 17.420 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.232 ns | 0.0125 ns | 0.0110 ns | 13.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.839 ns | 0.0095 ns | 0.0088 ns | 12.837 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.886 ns | 0.0119 ns | 0.0099 ns | 10.889 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.550 ns | 0.0124 ns | 0.0116 ns | 14.553 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.010 ns | 0.0157 ns | 0.0139 ns | 14.011 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.421 ns | 0.0312 ns | 0.0277 ns | 16.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.809 ns | 0.0121 ns | 0.0113 ns | 14.808 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.281 ns | 0.5549 ns | 0.9423 ns | 15.820 ns |  1.05 |    0.06 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.862 ns | 0.0713 ns | 0.0667 ns | 18.832 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.742 ns | 0.0337 ns | 0.0315 ns | 17.738 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.444 ns | 0.0098 ns | 0.0082 ns | 13.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 14.118 ns | 0.0441 ns | 0.0368 ns | 14.128 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.872 ns | 0.0273 ns | 0.0255 ns | 10.868 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.060 ns | 0.0176 ns | 0.0147 ns | 14.060 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 13.934 ns | 0.0155 ns | 0.0137 ns | 13.934 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.606 ns | 0.0399 ns | 0.0373 ns | 15.611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.088 ns | 0.0124 ns | 0.0116 ns | 13.087 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.333 ns | 0.2887 ns | 0.3546 ns | 13.094 ns |  0.86 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.679 ns | 0.0142 ns | 0.0119 ns | 14.679 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 16.341 ns | 0.0271 ns | 0.0240 ns | 16.344 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 21.160 ns | 0.0396 ns | 0.0371 ns | 21.157 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.289 ns | 0.0299 ns | 0.0280 ns | 16.286 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.864 ns | 0.2004 ns | 0.1875 ns | 12.969 ns |  0.61 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 22.280 ns | 0.1449 ns | 0.1355 ns | 22.339 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.678 ns | 0.0205 ns | 0.0182 ns | 19.678 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 21.734 ns | 0.0248 ns | 0.0194 ns | 21.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.566 ns | 0.0247 ns | 0.0231 ns | 17.561 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.370 ns | 0.0288 ns | 0.0255 ns | 17.374 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.044 ns | 0.0262 ns | 0.0245 ns | 19.042 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 21.503 ns | 0.0276 ns | 0.0258 ns | 21.499 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.179 ns | 0.0359 ns | 0.0336 ns | 21.173 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.610 ns | 0.0390 ns | 0.0304 ns | 16.607 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.548 ns | 0.0433 ns | 0.0405 ns | 13.553 ns |  0.64 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 22.571 ns | 0.0377 ns | 0.0334 ns | 22.567 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 20.623 ns | 0.0569 ns | 0.0505 ns | 20.608 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.738 ns | 0.1833 ns | 0.1714 ns | 18.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.837 ns | 0.0206 ns | 0.0192 ns | 16.831 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.047 ns | 0.3511 ns | 0.4180 ns | 17.280 ns |  0.90 |    0.03 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.033 ns | 0.0272 ns | 0.0254 ns | 19.032 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.419 ns | 0.0255 ns | 0.0238 ns | 20.418 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.435 ns | 0.0350 ns | 0.0293 ns | 14.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.048 ns | 0.0129 ns | 0.0121 ns | 12.047 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.211 ns | 0.0112 ns | 0.0094 ns |  8.211 ns |  0.57 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.895 ns | 0.0316 ns | 0.0296 ns | 13.886 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 14.272 ns | 0.0186 ns | 0.0174 ns | 14.269 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.502 ns | 0.0364 ns | 0.0341 ns | 16.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.716 ns | 0.0091 ns | 0.0081 ns | 14.716 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.674 ns | 0.2939 ns | 0.3822 ns | 13.876 ns |  0.82 |    0.03 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.769 ns | 0.0424 ns | 0.0396 ns | 14.776 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.872 ns | 0.0462 ns | 0.0386 ns | 17.878 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.951 ns | 0.0117 ns | 0.0104 ns | 13.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.871 ns | 0.0442 ns | 0.0413 ns | 11.852 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.633 ns | 0.0309 ns | 0.0289 ns |  7.641 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.264 ns | 0.0233 ns | 0.0207 ns | 14.264 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.934 ns | 0.0192 ns | 0.0180 ns | 12.935 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.396 ns | 0.0207 ns | 0.0173 ns | 16.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.306 ns | 0.0181 ns | 0.0169 ns | 15.311 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.583 ns | 0.0490 ns | 0.0383 ns | 14.577 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 18.427 ns | 0.0200 ns | 0.0187 ns | 18.427 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.845 ns | 0.0204 ns | 0.0191 ns | 17.843 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.977 ns | 0.0166 ns | 0.0155 ns | 13.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.629 ns | 0.0121 ns | 0.0113 ns | 10.626 ns |  0.76 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.284 ns | 0.0101 ns | 0.0089 ns |  7.285 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.285 ns | 0.0215 ns | 0.0191 ns | 14.281 ns |  1.02 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.746 ns | 0.0267 ns | 0.0250 ns | 13.735 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.572 ns | 0.0697 ns | 0.0652 ns | 16.540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.122 ns | 0.0145 ns | 0.0136 ns | 14.126 ns |  0.85 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.741 ns | 0.3109 ns | 0.2908 ns | 14.870 ns |  0.89 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.605 ns | 0.0161 ns | 0.0142 ns | 16.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.782 ns | 0.0263 ns | 0.0246 ns | 17.779 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.107 ns | 0.0134 ns | 0.0119 ns | 14.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.249 ns | 0.0191 ns | 0.0169 ns | 13.250 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.041 ns | 0.1799 ns | 0.2339 ns |  8.124 ns |  0.57 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.830 ns | 0.0164 ns | 0.0154 ns | 13.835 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.890 ns | 0.0178 ns | 0.0158 ns | 12.889 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.917 ns | 0.0168 ns | 0.0149 ns | 15.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.867 ns | 0.0083 ns | 0.0069 ns | 13.868 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.178 ns | 0.2239 ns | 0.2094 ns | 14.219 ns |  0.89 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.679 ns | 0.0306 ns | 0.0286 ns | 14.676 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.378 ns | 0.0237 ns | 0.0210 ns | 17.383 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.187 ns | 0.0589 ns | 0.0551 ns | 14.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.593 ns | 0.0149 ns | 0.0140 ns | 10.591 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.505 ns | 0.0215 ns | 0.0201 ns |  7.507 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.365 ns | 0.0106 ns | 0.0094 ns | 14.366 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.192 ns | 0.0129 ns | 0.0121 ns | 13.187 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.400 ns | 0.0731 ns | 0.0610 ns | 48.393 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 45.488 ns | 0.0768 ns | 0.0681 ns | 45.480 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 34.929 ns | 0.2966 ns | 0.2774 ns | 34.970 ns |  0.72 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 45.055 ns | 0.2265 ns | 0.2119 ns | 44.964 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 48.306 ns | 0.0718 ns | 0.0671 ns | 48.308 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.552 ns | 0.0115 ns | 0.0107 ns | 14.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.997 ns | 0.0310 ns | 0.0275 ns | 10.993 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.886 ns | 0.0091 ns | 0.0081 ns |  7.887 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 15.409 ns | 0.0250 ns | 0.0222 ns | 15.403 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.495 ns | 0.0290 ns | 0.0257 ns | 14.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.196 ns | 0.0663 ns | 0.0620 ns | 46.202 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 47.330 ns | 0.0536 ns | 0.0501 ns | 47.315 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.967 ns | 0.7701 ns | 0.7203 ns | 40.344 ns |  0.87 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 45.625 ns | 0.0555 ns | 0.0492 ns | 45.633 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 47.364 ns | 0.0755 ns | 0.0706 ns | 47.370 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.808 ns | 0.0124 ns | 0.0116 ns | 14.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.620 ns | 0.0073 ns | 0.0068 ns | 10.621 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.996 ns | 0.0949 ns | 0.0887 ns |  7.936 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.162 ns | 0.0234 ns | 0.0219 ns | 14.155 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 15.086 ns | 0.0149 ns | 0.0140 ns | 15.086 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.339 ns | 0.0676 ns | 0.0632 ns | 16.305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.629 ns | 0.0227 ns | 0.0201 ns | 13.628 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 17.048 ns | 0.3931 ns | 1.1343 ns | 17.363 ns |  0.94 |    0.14 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.819 ns | 0.0206 ns | 0.0192 ns | 14.820 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.394 ns | 0.0131 ns | 0.0122 ns | 16.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.269 ns | 0.0232 ns | 0.0217 ns | 14.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.693 ns | 0.0086 ns | 0.0080 ns | 12.695 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.374 ns | 0.0426 ns | 0.0398 ns | 12.374 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.905 ns | 0.0326 ns | 0.0305 ns | 13.914 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.803 ns | 0.0247 ns | 0.0231 ns | 13.800 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.900 ns | 0.0252 ns | 0.0224 ns | 18.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.824 ns | 0.0497 ns | 0.0465 ns | 14.833 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.422 ns | 0.0234 ns | 0.0219 ns | 14.417 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.282 ns | 0.0246 ns | 0.0230 ns | 17.284 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.004 ns | 0.0222 ns | 0.0208 ns | 18.003 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.373 ns | 0.0408 ns | 0.0382 ns | 13.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.691 ns | 0.0105 ns | 0.0098 ns | 12.693 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.073 ns | 0.6155 ns | 0.9021 ns | 11.569 ns |  0.94 |    0.08 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.072 ns | 0.0130 ns | 0.0115 ns | 14.072 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 15.473 ns | 0.0209 ns | 0.0175 ns | 15.466 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 16.316 ns | 0.0204 ns | 0.0171 ns | 16.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.902 ns | 0.0166 ns | 0.0147 ns | 13.902 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.351 ns | 0.2902 ns | 0.2980 ns | 13.603 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.652 ns | 0.0188 ns | 0.0176 ns | 14.652 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.775 ns | 0.0299 ns | 0.0280 ns | 16.770 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.818 ns | 0.0751 ns | 0.0627 ns | 39.817 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.230 ns | 0.0355 ns | 0.0332 ns | 38.229 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.868 ns | 0.0405 ns | 0.0379 ns | 36.871 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.203 ns | 0.0846 ns | 0.0791 ns | 39.181 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 39.388 ns | 0.0742 ns | 0.0619 ns | 39.384 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.890 ns | 0.0240 ns | 0.0224 ns | 18.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.556 ns | 0.0130 ns | 0.0108 ns | 14.558 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.553 ns | 0.0398 ns | 0.0373 ns | 14.555 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 18.770 ns | 0.0266 ns | 0.0236 ns | 18.768 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.349 ns | 0.0187 ns | 0.0165 ns | 18.346 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.161 ns | 0.0403 ns | 0.0377 ns | 40.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.817 ns | 0.0648 ns | 0.0574 ns | 38.813 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.046 ns | 0.0367 ns | 0.0306 ns | 35.038 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.363 ns | 0.1266 ns | 0.1184 ns | 39.366 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.550 ns | 0.0425 ns | 0.0377 ns | 38.550 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.823 ns | 0.0236 ns | 0.0221 ns | 16.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.578 ns | 0.0127 ns | 0.0112 ns | 14.578 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.177 ns | 0.3469 ns | 0.7688 ns | 16.519 ns |  0.90 |    0.06 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.678 ns | 0.0623 ns | 0.0583 ns | 16.702 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.900 ns | 0.0151 ns | 0.0141 ns | 17.900 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.151 ns | 0.0352 ns | 0.0294 ns | 40.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.087 ns | 0.0497 ns | 0.0441 ns | 40.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.991 ns | 0.9882 ns | 1.7308 ns | 35.007 ns |  0.95 |    0.04 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.432 ns | 0.0460 ns | 0.0430 ns | 40.415 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.537 ns | 0.0683 ns | 0.0639 ns | 38.517 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.623 ns | 0.0246 ns | 0.0230 ns | 15.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.085 ns | 0.0157 ns | 0.0146 ns | 13.087 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.836 ns | 0.2966 ns | 0.3751 ns | 14.000 ns |  0.88 |    0.03 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 15.282 ns | 0.0203 ns | 0.0180 ns | 15.280 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.293 ns | 0.0190 ns | 0.0169 ns | 16.295 ns |  1.04 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Decimal.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Decimal.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Decimal.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Decimal.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
