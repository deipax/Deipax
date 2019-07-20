
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
                                             From_Bool | .NET Core 2.0 | 14.104 ns | 0.0135 ns | 0.0126 ns | 14.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.918 ns | 0.0087 ns | 0.0073 ns | 11.920 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.916 ns | 1.2347 ns | 1.2679 ns |  8.226 ns |  0.64 |    0.09 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.184 ns | 0.0254 ns | 0.0212 ns | 14.179 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.625 ns | 0.0272 ns | 0.0241 ns | 13.625 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.361 ns | 0.0232 ns | 0.0206 ns | 20.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.483 ns | 0.0155 ns | 0.0145 ns | 17.482 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.290 ns | 0.2364 ns | 0.2211 ns | 18.346 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 22.818 ns | 0.0375 ns | 0.0332 ns | 22.822 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 22.659 ns | 0.1319 ns | 0.1233 ns | 22.594 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 14.717 ns | 0.0314 ns | 0.0245 ns | 14.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.343 ns | 0.0867 ns | 0.0811 ns | 11.344 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.746 ns | 0.1964 ns | 0.2339 ns |  8.866 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 15.249 ns | 0.0515 ns | 0.0482 ns | 15.228 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.427 ns | 0.0096 ns | 0.0085 ns | 13.425 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.148 ns | 0.0283 ns | 0.0265 ns | 20.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.360 ns | 0.0479 ns | 0.0448 ns | 18.366 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.593 ns | 0.0304 ns | 0.0284 ns | 19.594 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.025 ns | 0.0950 ns | 0.0888 ns | 21.064 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 21.897 ns | 0.0204 ns | 0.0181 ns | 21.896 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.705 ns | 0.0085 ns | 0.0075 ns | 12.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.712 ns | 0.0155 ns | 0.0145 ns | 10.711 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.544 ns | 0.0145 ns | 0.0136 ns |  7.543 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.784 ns | 0.0777 ns | 0.0727 ns | 13.751 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.791 ns | 0.0169 ns | 0.0149 ns | 13.789 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.404 ns | 0.0543 ns | 0.0454 ns | 15.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.972 ns | 0.0143 ns | 0.0127 ns | 12.970 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.260 ns | 0.2767 ns | 0.2717 ns | 13.098 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 18.081 ns | 0.0224 ns | 0.0199 ns | 18.083 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 17.372 ns | 0.1183 ns | 0.1106 ns | 17.407 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.610 ns | 0.0145 ns | 0.0135 ns | 12.611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.882 ns | 0.0108 ns | 0.0096 ns | 10.884 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  8.070 ns | 0.1809 ns | 0.1692 ns |  8.039 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.351 ns | 0.0213 ns | 0.0199 ns | 14.354 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 13.458 ns | 0.0172 ns | 0.0161 ns | 13.453 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 21.235 ns | 0.0302 ns | 0.0268 ns | 21.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.065 ns | 0.0187 ns | 0.0156 ns | 17.065 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.194 ns | 0.1374 ns | 0.1218 ns | 18.245 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 20.956 ns | 0.0482 ns | 0.0451 ns | 20.955 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 21.940 ns | 0.0336 ns | 0.0297 ns | 21.929 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.998 ns | 0.0119 ns | 0.0111 ns | 12.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.072 ns | 0.0789 ns | 0.0738 ns | 11.117 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  8.115 ns | 0.0127 ns | 0.0119 ns |  8.113 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.990 ns | 0.0910 ns | 0.0851 ns | 15.030 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.317 ns | 0.0269 ns | 0.0252 ns | 13.305 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.606 ns | 0.0217 ns | 0.0192 ns | 20.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.292 ns | 0.0259 ns | 0.0216 ns | 17.298 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.166 ns | 0.0305 ns | 0.0285 ns | 17.159 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 20.839 ns | 0.0253 ns | 0.0237 ns | 20.836 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 22.377 ns | 0.0986 ns | 0.0922 ns | 22.413 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.184 ns | 0.0155 ns | 0.0145 ns | 14.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.699 ns | 0.0112 ns | 0.0104 ns | 10.701 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.560 ns | 0.0345 ns | 0.0323 ns |  7.553 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 15.059 ns | 0.0345 ns | 0.0306 ns | 15.066 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 15.912 ns | 0.0176 ns | 0.0165 ns | 15.914 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.105 ns | 0.0307 ns | 0.0256 ns | 16.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.965 ns | 0.0113 ns | 0.0100 ns | 12.964 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.122 ns | 0.2545 ns | 0.2381 ns | 11.988 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 17.474 ns | 0.0215 ns | 0.0180 ns | 17.481 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 17.279 ns | 0.0198 ns | 0.0175 ns | 17.278 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.608 ns | 0.0418 ns | 0.0391 ns | 12.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.659 ns | 0.0203 ns | 0.0189 ns | 10.660 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.586 ns | 0.0301 ns | 0.0282 ns |  7.601 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.844 ns | 0.0123 ns | 0.0109 ns | 13.843 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.812 ns | 0.0132 ns | 0.0123 ns | 12.812 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.528 ns | 0.0200 ns | 0.0187 ns | 12.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.377 ns | 0.0162 ns | 0.0144 ns | 10.376 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.707 ns | 0.0738 ns | 0.0690 ns |  7.740 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.440 ns | 0.0181 ns | 0.0161 ns | 14.441 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.058 ns | 0.0094 ns | 0.0084 ns | 13.058 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.522 ns | 0.0113 ns | 0.0106 ns | 12.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.368 ns | 0.0200 ns | 0.0187 ns | 10.364 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.718 ns | 0.0177 ns | 0.0148 ns |  7.718 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 15.056 ns | 0.0263 ns | 0.0246 ns | 15.051 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.807 ns | 0.0224 ns | 0.0199 ns | 13.813 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.657 ns | 0.0183 ns | 0.0153 ns | 15.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.983 ns | 0.0151 ns | 0.0134 ns | 12.981 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.983 ns | 0.0398 ns | 0.0372 ns | 11.969 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 14.691 ns | 0.0280 ns | 0.0262 ns | 14.683 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.043 ns | 0.0484 ns | 0.0452 ns | 17.055 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.579 ns | 0.0125 ns | 0.0104 ns | 12.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.528 ns | 0.0108 ns | 0.0096 ns | 11.526 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.952 ns | 0.0143 ns | 0.0133 ns |  7.950 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.919 ns | 0.0247 ns | 0.0219 ns | 13.917 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.875 ns | 0.0347 ns | 0.0325 ns | 13.870 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.519 ns | 0.0252 ns | 0.0236 ns | 12.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.599 ns | 0.0150 ns | 0.0133 ns | 11.598 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.777 ns | 0.0955 ns | 0.0893 ns |  8.814 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.203 ns | 0.0237 ns | 0.0222 ns | 14.201 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.618 ns | 0.0248 ns | 0.0232 ns | 13.606 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.242 ns | 0.0101 ns | 0.0094 ns | 13.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.423 ns | 0.0261 ns | 0.0231 ns | 12.415 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.352 ns | 0.0110 ns | 0.0103 ns |  8.351 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.505 ns | 0.0172 ns | 0.0153 ns | 14.505 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.065 ns | 0.0124 ns | 0.0116 ns | 13.067 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.291 ns | 0.0143 ns | 0.0134 ns | 15.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.107 ns | 0.0534 ns | 0.0499 ns | 13.123 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.959 ns | 0.0139 ns | 0.0123 ns | 11.958 ns |  0.78 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 14.610 ns | 0.0248 ns | 0.0207 ns | 14.600 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.248 ns | 0.0130 ns | 0.0108 ns | 16.246 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 20.321 ns | 0.0229 ns | 0.0214 ns | 20.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 17.126 ns | 0.0186 ns | 0.0165 ns | 17.127 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.887 ns | 0.0538 ns | 0.0503 ns | 11.862 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.071 ns | 0.0284 ns | 0.0252 ns | 21.070 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 21.803 ns | 0.0300 ns | 0.0266 ns | 21.802 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 24.995 ns | 0.0110 ns | 0.0086 ns | 24.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 23.163 ns | 0.0515 ns | 0.0482 ns | 23.159 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.987 ns | 0.0483 ns | 0.0403 ns | 21.980 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 25.264 ns | 0.1842 ns | 0.1723 ns | 25.157 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.575 ns | 0.0733 ns | 0.0685 ns | 27.585 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.437 ns | 0.0245 ns | 0.0217 ns | 22.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.575 ns | 0.0154 ns | 0.0144 ns | 20.573 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 20.316 ns | 0.0277 ns | 0.0259 ns | 20.316 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.437 ns | 0.0211 ns | 0.0165 ns | 23.436 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.519 ns | 0.0161 ns | 0.0125 ns | 23.519 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.866 ns | 0.0231 ns | 0.0205 ns | 24.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.934 ns | 0.0195 ns | 0.0183 ns | 21.937 ns |  0.88 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.793 ns | 0.7463 ns | 1.2672 ns | 19.111 ns |  0.84 |    0.06 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 25.007 ns | 0.0248 ns | 0.0232 ns | 25.007 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 26.053 ns | 0.0416 ns | 0.0389 ns | 26.061 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.031 ns | 0.0121 ns | 0.0113 ns | 14.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.246 ns | 0.0195 ns | 0.0182 ns | 12.244 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.061 ns | 0.0109 ns | 0.0102 ns |  9.061 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 17.408 ns | 0.0154 ns | 0.0144 ns | 17.407 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.334 ns | 0.0143 ns | 0.0127 ns | 13.330 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.463 ns | 0.0266 ns | 0.0248 ns | 15.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.964 ns | 0.0139 ns | 0.0124 ns | 12.963 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.534 ns | 0.2925 ns | 0.2873 ns | 13.664 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 14.720 ns | 0.0331 ns | 0.0294 ns | 14.717 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 17.048 ns | 0.0231 ns | 0.0216 ns | 17.044 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.861 ns | 0.0256 ns | 0.0240 ns | 12.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.026 ns | 0.0138 ns | 0.0129 ns | 11.025 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.971 ns | 0.7524 ns | 0.7727 ns |  7.584 ns |  0.62 |    0.06 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.217 ns | 0.1015 ns | 0.0950 ns | 14.280 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.394 ns | 0.0194 ns | 0.0172 ns | 13.394 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 24.998 ns | 0.0248 ns | 0.0193 ns | 25.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 26.088 ns | 0.0216 ns | 0.0202 ns | 26.088 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 28.385 ns | 0.0395 ns | 0.0370 ns | 28.395 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 32.110 ns | 0.0319 ns | 0.0283 ns | 32.113 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 34.148 ns | 0.1510 ns | 0.1412 ns | 34.191 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.542 ns | 0.0143 ns | 0.0134 ns | 12.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.075 ns | 0.0147 ns | 0.0130 ns | 12.076 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.771 ns | 0.0145 ns | 0.0129 ns |  8.774 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.793 ns | 0.0301 ns | 0.0282 ns | 13.790 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.045 ns | 0.0121 ns | 0.0113 ns | 13.042 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.726 ns | 0.0289 ns | 0.0271 ns | 25.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 27.250 ns | 0.0455 ns | 0.0426 ns | 27.262 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.420 ns | 0.1141 ns | 0.1012 ns | 29.380 ns |  1.14 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 34.773 ns | 0.0422 ns | 0.0352 ns | 34.763 ns |  1.35 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 33.874 ns | 0.0786 ns | 0.0657 ns | 33.865 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.598 ns | 0.0338 ns | 0.0316 ns | 12.606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.837 ns | 0.0867 ns | 0.0811 ns | 11.780 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.571 ns | 0.0093 ns | 0.0087 ns |  8.571 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.784 ns | 0.0124 ns | 0.0110 ns | 13.783 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.163 ns | 0.0165 ns | 0.0138 ns | 13.163 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.297 ns | 0.0250 ns | 0.0222 ns | 15.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.975 ns | 0.0120 ns | 0.0112 ns | 12.974 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.924 ns | 0.0224 ns | 0.0210 ns | 12.924 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.722 ns | 0.0255 ns | 0.0226 ns | 14.718 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.136 ns | 0.0167 ns | 0.0156 ns | 16.138 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 14.033 ns | 0.0197 ns | 0.0184 ns | 14.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.549 ns | 0.0166 ns | 0.0147 ns | 10.549 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  8.229 ns | 0.0138 ns | 0.0129 ns |  8.230 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 16.483 ns | 0.0189 ns | 0.0148 ns | 16.482 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.831 ns | 0.0506 ns | 0.0473 ns | 12.857 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.672 ns | 0.0178 ns | 0.0149 ns | 20.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.267 ns | 0.0201 ns | 0.0178 ns | 17.262 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.810 ns | 0.0886 ns | 0.0829 ns | 17.769 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 20.999 ns | 0.0296 ns | 0.0277 ns | 20.993 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 21.930 ns | 0.0254 ns | 0.0212 ns | 21.934 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 14.504 ns | 0.0148 ns | 0.0132 ns | 14.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.867 ns | 0.0175 ns | 0.0163 ns | 10.868 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.101 ns | 0.2291 ns | 0.4981 ns | 10.215 ns |  0.67 |    0.07 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.215 ns | 0.0212 ns | 0.0198 ns | 14.212 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.374 ns | 0.0143 ns | 0.0112 ns | 13.377 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.622 ns | 0.0162 ns | 0.0151 ns | 20.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.226 ns | 0.0226 ns | 0.0201 ns | 17.218 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.278 ns | 0.0668 ns | 0.0625 ns | 17.290 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 20.977 ns | 0.0363 ns | 0.0322 ns | 20.984 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 22.020 ns | 0.0246 ns | 0.0205 ns | 22.021 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.603 ns | 0.0106 ns | 0.0094 ns | 12.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.642 ns | 0.0181 ns | 0.0169 ns | 10.637 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.233 ns | 0.0119 ns | 0.0112 ns |  7.233 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.448 ns | 0.0256 ns | 0.0239 ns | 14.447 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.063 ns | 0.0256 ns | 0.0227 ns | 13.063 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.265 ns | 0.0242 ns | 0.0189 ns | 15.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.602 ns | 0.0726 ns | 0.0679 ns | 14.572 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.672 ns | 0.0482 ns | 0.0451 ns | 14.672 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.770 ns | 0.0380 ns | 0.0356 ns | 14.786 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.469 ns | 0.0256 ns | 0.0239 ns | 16.473 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.812 ns | 0.0639 ns | 0.0597 ns | 12.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.429 ns | 0.0134 ns | 0.0119 ns | 10.433 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.765 ns | 0.0087 ns | 0.0068 ns |  7.768 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.914 ns | 0.0307 ns | 0.0272 ns | 15.908 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.802 ns | 0.0149 ns | 0.0132 ns | 13.800 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.368 ns | 0.0207 ns | 0.0173 ns | 20.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.293 ns | 0.0317 ns | 0.0281 ns | 17.293 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.766 ns | 0.0911 ns | 0.0852 ns | 17.730 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.070 ns | 0.0274 ns | 0.0243 ns | 21.070 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 22.406 ns | 0.1446 ns | 0.1352 ns | 22.471 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 15.303 ns | 0.0472 ns | 0.0419 ns | 15.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.987 ns | 0.0114 ns | 0.0101 ns | 10.986 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.013 ns | 0.0121 ns | 0.0107 ns |  8.009 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.752 ns | 0.0239 ns | 0.0199 ns | 14.750 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.055 ns | 0.0299 ns | 0.0280 ns | 14.050 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.342 ns | 0.0285 ns | 0.0252 ns | 20.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.060 ns | 0.0275 ns | 0.0257 ns | 17.063 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.162 ns | 0.0185 ns | 0.0164 ns | 19.164 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 20.948 ns | 0.0231 ns | 0.0205 ns | 20.952 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 22.592 ns | 0.0794 ns | 0.0743 ns | 22.556 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.044 ns | 0.0113 ns | 0.0100 ns | 14.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.167 ns | 0.0156 ns | 0.0146 ns | 11.169 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.843 ns | 0.0081 ns | 0.0071 ns |  7.841 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.011 ns | 0.0273 ns | 0.0242 ns | 14.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.090 ns | 0.0511 ns | 0.0478 ns | 13.100 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.277 ns | 0.0155 ns | 0.0137 ns | 15.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.551 ns | 0.0116 ns | 0.0108 ns | 14.549 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.998 ns | 0.0820 ns | 0.0767 ns | 13.026 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 17.288 ns | 0.0173 ns | 0.0162 ns | 17.291 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 18.256 ns | 0.0201 ns | 0.0178 ns | 18.256 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.691 ns | 0.0191 ns | 0.0160 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.358 ns | 0.0776 ns | 0.0726 ns | 11.391 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.843 ns | 0.0125 ns | 0.0111 ns |  7.844 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.727 ns | 0.0110 ns | 0.0098 ns | 13.729 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.808 ns | 0.0183 ns | 0.0153 ns | 13.808 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 21.026 ns | 0.0715 ns | 0.0669 ns | 21.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.014 ns | 0.0245 ns | 0.0218 ns | 18.017 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 17.066 ns | 0.0324 ns | 0.0303 ns | 17.064 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 20.869 ns | 0.0219 ns | 0.0205 ns | 20.868 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 22.237 ns | 0.0325 ns | 0.0304 ns | 22.236 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.677 ns | 0.0101 ns | 0.0095 ns | 12.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.813 ns | 0.0119 ns | 0.0106 ns | 11.812 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  9.184 ns | 0.1976 ns | 0.1940 ns |  9.265 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.227 ns | 0.0207 ns | 0.0194 ns | 15.222 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.428 ns | 0.0146 ns | 0.0122 ns | 13.428 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.824 ns | 0.0327 ns | 0.0290 ns | 20.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.500 ns | 0.0405 ns | 0.0359 ns | 17.501 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.798 ns | 0.1812 ns | 0.1695 ns | 17.803 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 23.381 ns | 0.0469 ns | 0.0392 ns | 23.373 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 22.215 ns | 0.0406 ns | 0.0360 ns | 22.207 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.819 ns | 0.0128 ns | 0.0113 ns | 14.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.658 ns | 0.0177 ns | 0.0157 ns | 11.661 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.419 ns | 0.0099 ns | 0.0092 ns |  8.421 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.720 ns | 0.0508 ns | 0.0475 ns | 14.733 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.106 ns | 0.0194 ns | 0.0181 ns | 13.108 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.296 ns | 0.0254 ns | 0.0237 ns | 15.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.968 ns | 0.0429 ns | 0.0401 ns | 12.945 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.432 ns | 0.3005 ns | 0.2664 ns | 14.501 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.765 ns | 0.0425 ns | 0.0376 ns | 14.757 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 17.841 ns | 0.0254 ns | 0.0225 ns | 17.845 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 13.512 ns | 0.0107 ns | 0.0100 ns | 13.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.875 ns | 0.0145 ns | 0.0136 ns | 10.871 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  8.611 ns | 0.1938 ns | 0.3544 ns |  8.731 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.770 ns | 0.0373 ns | 0.0331 ns | 14.763 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.775 ns | 0.0323 ns | 0.0302 ns | 12.766 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.587 ns | 0.0235 ns | 0.0208 ns | 20.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.478 ns | 0.1066 ns | 0.0997 ns | 17.483 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.214 ns | 0.0363 ns | 0.0340 ns | 17.218 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 20.991 ns | 0.0317 ns | 0.0296 ns | 20.990 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.943 ns | 0.0235 ns | 0.0220 ns | 21.952 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 14.520 ns | 0.0262 ns | 0.0232 ns | 14.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.458 ns | 0.0087 ns | 0.0073 ns | 11.459 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.112 ns | 0.0161 ns | 0.0135 ns |  8.106 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.958 ns | 0.0364 ns | 0.0341 ns | 14.958 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.156 ns | 0.0166 ns | 0.0147 ns | 14.159 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.575 ns | 0.0213 ns | 0.0200 ns | 20.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.204 ns | 0.0287 ns | 0.0269 ns | 18.204 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.574 ns | 0.0351 ns | 0.0329 ns | 17.563 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 20.828 ns | 0.0210 ns | 0.0186 ns | 20.827 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 22.186 ns | 0.0263 ns | 0.0220 ns | 22.185 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.745 ns | 0.0433 ns | 0.0405 ns | 12.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.703 ns | 0.0092 ns | 0.0081 ns | 10.704 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.774 ns | 0.0099 ns | 0.0093 ns |  7.774 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.925 ns | 0.0185 ns | 0.0164 ns | 14.927 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.876 ns | 0.0496 ns | 0.0440 ns | 13.888 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.300 ns | 0.0103 ns | 0.0096 ns | 15.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.027 ns | 0.0086 ns | 0.0081 ns | 14.027 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.967 ns | 0.0599 ns | 0.0560 ns | 13.945 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.765 ns | 0.0148 ns | 0.0138 ns | 14.760 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 18.742 ns | 0.0275 ns | 0.0258 ns | 18.738 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.561 ns | 0.0241 ns | 0.0214 ns | 12.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.672 ns | 0.0112 ns | 0.0105 ns | 10.672 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  8.462 ns | 0.2097 ns | 0.3562 ns |  8.265 ns |  0.70 |    0.03 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.063 ns | 0.0430 ns | 0.0402 ns | 15.065 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.120 ns | 0.3068 ns | 0.3282 ns | 14.150 ns |  1.13 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.376 ns | 0.0299 ns | 0.0280 ns | 20.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.069 ns | 0.0277 ns | 0.0231 ns | 17.055 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.957 ns | 0.1015 ns | 0.0950 ns | 18.966 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.971 ns | 0.0313 ns | 0.0293 ns | 20.969 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 21.978 ns | 0.0242 ns | 0.0227 ns | 21.980 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.253 ns | 0.0813 ns | 0.0760 ns | 13.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.176 ns | 0.0750 ns | 0.0701 ns | 11.212 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.535 ns | 0.1974 ns | 0.3244 ns |  8.690 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.804 ns | 0.0662 ns | 0.0619 ns | 14.819 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.010 ns | 0.0219 ns | 0.0194 ns | 14.009 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.616 ns | 0.0220 ns | 0.0195 ns | 20.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.045 ns | 0.0166 ns | 0.0155 ns | 17.047 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.702 ns | 0.0881 ns | 0.0824 ns | 17.662 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.955 ns | 0.0298 ns | 0.0264 ns | 20.956 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 22.665 ns | 0.0703 ns | 0.0657 ns | 22.697 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.047 ns | 0.0119 ns | 0.0112 ns | 14.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.920 ns | 0.0124 ns | 0.0104 ns | 10.922 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.546 ns | 0.1743 ns | 0.2140 ns |  7.665 ns |  0.53 |    0.02 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.425 ns | 0.0251 ns | 0.0210 ns | 14.422 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.006 ns | 0.0140 ns | 0.0124 ns | 13.004 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.283 ns | 0.0110 ns | 0.0103 ns | 15.281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.102 ns | 0.0702 ns | 0.0656 ns | 13.129 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.879 ns | 0.0184 ns | 0.0154 ns | 12.874 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 17.305 ns | 0.1136 ns | 0.1062 ns | 17.234 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 17.346 ns | 0.0270 ns | 0.0252 ns | 17.337 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 72.986 ns | 0.1095 ns | 0.1025 ns | 72.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 73.262 ns | 0.1271 ns | 0.1189 ns | 73.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 57.993 ns | 0.1141 ns | 0.1067 ns | 57.954 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 73.896 ns | 0.0535 ns | 0.0475 ns | 73.894 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 74.511 ns | 0.0705 ns | 0.0660 ns | 74.526 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 79.635 ns | 0.3327 ns | 0.3112 ns | 79.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 83.440 ns | 0.3807 ns | 0.3561 ns | 83.240 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 62.892 ns | 0.0620 ns | 0.0550 ns | 62.901 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 81.519 ns | 0.0992 ns | 0.0879 ns | 81.539 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 81.509 ns | 0.0710 ns | 0.0630 ns | 81.518 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.400 ns | 0.0118 ns | 0.0105 ns | 14.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.160 ns | 0.0125 ns | 0.0117 ns | 12.161 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.568 ns | 0.5863 ns | 0.6979 ns | 13.211 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.349 ns | 0.0133 ns | 0.0124 ns | 14.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.360 ns | 0.0179 ns | 0.0167 ns | 16.363 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.284 ns | 0.0178 ns | 0.0158 ns | 15.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.514 ns | 0.0361 ns | 0.0302 ns | 14.517 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.321 ns | 0.0903 ns | 0.0845 ns | 13.301 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 16.297 ns | 0.0151 ns | 0.0134 ns | 16.295 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 17.409 ns | 0.0195 ns | 0.0172 ns | 17.407 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.683 ns | 0.0107 ns | 0.0090 ns | 13.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.524 ns | 0.0714 ns | 0.0633 ns | 12.551 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.671 ns | 0.2663 ns | 0.2734 ns | 12.848 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.310 ns | 0.0443 ns | 0.0414 ns | 14.328 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.886 ns | 0.0448 ns | 0.0419 ns | 16.898 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 14.076 ns | 0.0128 ns | 0.0120 ns | 14.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.554 ns | 0.0139 ns | 0.0124 ns | 10.551 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  8.656 ns | 0.1982 ns | 0.2435 ns |  8.765 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.097 ns | 0.0242 ns | 0.0215 ns | 14.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.795 ns | 0.0129 ns | 0.0108 ns | 12.794 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.589 ns | 0.0463 ns | 0.0411 ns | 20.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.524 ns | 0.0239 ns | 0.0223 ns | 17.519 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.812 ns | 0.0463 ns | 0.0433 ns | 18.819 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.240 ns | 0.0957 ns | 0.0848 ns | 21.272 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 23.093 ns | 0.1097 ns | 0.1026 ns | 23.122 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.904 ns | 0.0089 ns | 0.0079 ns | 12.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.490 ns | 0.0086 ns | 0.0072 ns | 11.489 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.446 ns | 0.0106 ns | 0.0100 ns |  7.446 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 15.470 ns | 0.0157 ns | 0.0139 ns | 15.467 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 14.338 ns | 0.0149 ns | 0.0140 ns | 14.342 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.749 ns | 0.0201 ns | 0.0179 ns | 21.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.529 ns | 0.0542 ns | 0.0453 ns | 17.521 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.760 ns | 0.0276 ns | 0.0231 ns | 18.751 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.091 ns | 0.0224 ns | 0.0175 ns | 21.095 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.166 ns | 0.0206 ns | 0.0193 ns | 22.162 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.282 ns | 0.0776 ns | 0.0687 ns | 14.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.654 ns | 0.0167 ns | 0.0156 ns | 10.660 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.830 ns | 0.0453 ns | 0.0401 ns |  7.844 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.445 ns | 0.0192 ns | 0.0170 ns | 14.444 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.060 ns | 0.0166 ns | 0.0156 ns | 13.053 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.578 ns | 0.0214 ns | 0.0190 ns | 16.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.169 ns | 0.0093 ns | 0.0078 ns | 13.168 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.925 ns | 0.0215 ns | 0.0202 ns | 13.926 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 17.391 ns | 0.0159 ns | 0.0149 ns | 17.394 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 17.269 ns | 0.0309 ns | 0.0289 ns | 17.276 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 14.080 ns | 0.0202 ns | 0.0189 ns | 14.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.516 ns | 0.0305 ns | 0.0254 ns | 10.522 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  8.119 ns | 0.1855 ns | 0.2476 ns |  8.286 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.734 ns | 0.0115 ns | 0.0107 ns | 13.736 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.195 ns | 0.0744 ns | 0.0696 ns | 13.232 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.812 ns | 0.0863 ns | 0.0807 ns | 20.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.301 ns | 0.0284 ns | 0.0252 ns | 17.298 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.483 ns | 0.0542 ns | 0.0507 ns | 17.470 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 23.116 ns | 0.0178 ns | 0.0149 ns | 23.116 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 21.970 ns | 0.0345 ns | 0.0323 ns | 21.955 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 14.438 ns | 0.0090 ns | 0.0075 ns | 14.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.957 ns | 0.0984 ns | 0.0920 ns | 10.907 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.003 ns | 0.0123 ns | 0.0103 ns |  8.005 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.801 ns | 0.0710 ns | 0.0664 ns | 14.829 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.396 ns | 0.0147 ns | 0.0138 ns | 13.397 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.606 ns | 0.0155 ns | 0.0138 ns | 20.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.296 ns | 0.0164 ns | 0.0145 ns | 17.299 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.173 ns | 0.0713 ns | 0.0667 ns | 19.175 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 20.857 ns | 0.0235 ns | 0.0209 ns | 20.859 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 22.196 ns | 0.0316 ns | 0.0280 ns | 22.203 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 14.101 ns | 0.0132 ns | 0.0117 ns | 14.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.760 ns | 0.0377 ns | 0.0352 ns | 10.762 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.750 ns | 0.0160 ns | 0.0134 ns |  7.745 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 17.627 ns | 0.0276 ns | 0.0258 ns | 17.627 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.007 ns | 0.0188 ns | 0.0157 ns | 13.006 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.255 ns | 0.0221 ns | 0.0207 ns | 15.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.951 ns | 0.0153 ns | 0.0136 ns | 12.950 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.200 ns | 0.3450 ns | 0.5473 ns | 11.891 ns |  0.82 |    0.04 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.714 ns | 0.0186 ns | 0.0174 ns | 14.707 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 17.062 ns | 0.0169 ns | 0.0158 ns | 17.056 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 15.089 ns | 0.0102 ns | 0.0090 ns | 15.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.581 ns | 0.0623 ns | 0.0583 ns | 10.611 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  8.562 ns | 0.1911 ns | 0.2417 ns |  8.666 ns |  0.56 |    0.02 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.477 ns | 0.0163 ns | 0.0144 ns | 14.473 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.217 ns | 0.0176 ns | 0.0156 ns | 13.220 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.851 ns | 0.0370 ns | 0.0347 ns | 20.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.718 ns | 0.0287 ns | 0.0268 ns | 17.718 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 19.162 ns | 0.0300 ns | 0.0281 ns | 19.161 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 21.449 ns | 0.0757 ns | 0.0708 ns | 21.462 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 22.924 ns | 0.0654 ns | 0.0612 ns | 22.946 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.923 ns | 0.0140 ns | 0.0131 ns | 13.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.836 ns | 0.0151 ns | 0.0141 ns | 11.831 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  9.183 ns | 0.0185 ns | 0.0155 ns |  9.181 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.280 ns | 0.0169 ns | 0.0158 ns | 16.279 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.609 ns | 0.0274 ns | 0.0243 ns | 13.606 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.042 ns | 0.0208 ns | 0.0195 ns | 21.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.318 ns | 0.0821 ns | 0.0768 ns | 18.296 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.496 ns | 0.0314 ns | 0.0278 ns | 19.505 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 21.415 ns | 0.0467 ns | 0.0437 ns | 21.428 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 22.285 ns | 0.0347 ns | 0.0324 ns | 22.285 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.394 ns | 0.0139 ns | 0.0116 ns | 12.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.614 ns | 0.0165 ns | 0.0146 ns | 11.614 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.013 ns | 0.2066 ns | 0.3216 ns |  8.828 ns |  0.75 |    0.03 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.051 ns | 0.1091 ns | 0.1020 ns | 14.121 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.102 ns | 0.0100 ns | 0.0088 ns | 13.103 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.601 ns | 0.0186 ns | 0.0165 ns | 15.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.970 ns | 0.0176 ns | 0.0137 ns | 12.969 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.243 ns | 0.0139 ns | 0.0130 ns | 15.244 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.624 ns | 0.0202 ns | 0.0158 ns | 14.625 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 17.177 ns | 0.0441 ns | 0.0391 ns | 17.173 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.296 ns | 0.0208 ns | 0.0184 ns | 15.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.956 ns | 0.0101 ns | 0.0095 ns | 12.958 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.901 ns | 0.0168 ns | 0.0131 ns | 11.900 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 16.173 ns | 0.0508 ns | 0.0425 ns | 16.167 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.300 ns | 0.0320 ns | 0.0283 ns | 17.294 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.447 ns | 0.0097 ns | 0.0086 ns | 12.445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 12.512 ns | 0.0285 ns | 0.0252 ns | 12.507 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.665 ns | 0.0708 ns | 0.0662 ns | 11.632 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.180 ns | 0.0304 ns | 0.0270 ns | 13.166 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.629 ns | 0.0427 ns | 0.0357 ns | 12.638 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.597 ns | 0.0141 ns | 0.0132 ns | 15.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.637 ns | 0.0168 ns | 0.0149 ns | 14.638 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.488 ns | 0.0198 ns | 0.0175 ns | 14.485 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.730 ns | 0.0101 ns | 0.0090 ns | 14.728 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.264 ns | 0.0252 ns | 0.0236 ns | 16.259 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.148 ns | 0.0718 ns | 0.0671 ns | 18.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.766 ns | 0.0171 ns | 0.0152 ns | 14.767 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.055 ns | 0.0427 ns | 0.0378 ns | 14.067 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.364 ns | 0.0149 ns | 0.0132 ns | 18.365 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.091 ns | 0.0195 ns | 0.0173 ns | 18.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.141 ns | 0.0196 ns | 0.0173 ns | 19.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.399 ns | 0.1152 ns | 0.1078 ns | 16.341 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.426 ns | 1.1688 ns | 1.9848 ns | 16.324 ns |  1.01 |    0.12 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 19.091 ns | 0.0420 ns | 0.0393 ns | 19.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 21.193 ns | 0.0216 ns | 0.0168 ns | 21.198 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.419 ns | 0.0173 ns | 0.0162 ns | 14.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.350 ns | 0.0198 ns | 0.0185 ns | 13.352 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.337 ns | 0.0625 ns | 0.0584 ns | 12.305 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 16.065 ns | 0.0411 ns | 0.0364 ns | 16.080 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 15.187 ns | 0.0164 ns | 0.0154 ns | 15.187 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.856 ns | 0.0179 ns | 0.0159 ns | 15.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.952 ns | 0.0114 ns | 0.0107 ns | 12.955 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.456 ns | 0.2695 ns | 0.3779 ns | 12.678 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 17.256 ns | 0.0144 ns | 0.0120 ns | 17.255 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 17.467 ns | 0.0733 ns | 0.0650 ns | 17.477 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.543 ns | 0.0060 ns | 0.0053 ns | 13.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.868 ns | 0.0317 ns | 0.0297 ns | 11.876 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.394 ns | 0.1285 ns | 0.1202 ns | 12.404 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.206 ns | 0.0183 ns | 0.0162 ns | 14.201 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 13.919 ns | 0.0282 ns | 0.0264 ns | 13.909 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.184 ns | 0.0363 ns | 0.0339 ns | 17.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.420 ns | 0.0234 ns | 0.0195 ns | 14.420 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.496 ns | 0.2646 ns | 0.2475 ns | 15.628 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.839 ns | 0.0194 ns | 0.0181 ns | 16.840 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 18.311 ns | 0.0271 ns | 0.0226 ns | 18.318 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.915 ns | 0.0110 ns | 0.0098 ns | 13.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.791 ns | 0.0578 ns | 0.0541 ns | 11.760 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 13.379 ns | 0.2896 ns | 0.5850 ns | 13.510 ns |  0.93 |    0.07 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.458 ns | 0.0425 ns | 0.0397 ns | 14.440 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.281 ns | 0.0243 ns | 0.0203 ns | 15.283 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.352 ns | 0.0164 ns | 0.0153 ns | 16.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.725 ns | 0.0095 ns | 0.0079 ns | 13.726 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.698 ns | 0.2999 ns | 0.4301 ns | 13.913 ns |  0.83 |    0.03 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 18.287 ns | 0.0502 ns | 0.0469 ns | 18.300 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 17.953 ns | 0.0273 ns | 0.0242 ns | 17.950 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 21.229 ns | 0.0298 ns | 0.0264 ns | 21.232 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.694 ns | 0.0259 ns | 0.0216 ns | 16.693 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.396 ns | 0.0869 ns | 0.0812 ns | 13.360 ns |  0.63 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 22.031 ns | 0.0276 ns | 0.0258 ns | 22.028 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 22.622 ns | 0.0296 ns | 0.0263 ns | 22.625 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.822 ns | 0.0287 ns | 0.0254 ns | 19.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.969 ns | 0.0596 ns | 0.0528 ns | 16.979 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.951 ns | 0.0432 ns | 0.0404 ns | 16.947 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.773 ns | 0.0674 ns | 0.0631 ns | 19.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 22.236 ns | 0.0285 ns | 0.0266 ns | 22.236 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.809 ns | 0.0432 ns | 0.0383 ns | 21.813 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.876 ns | 0.0277 ns | 0.0246 ns | 16.877 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.641 ns | 0.0366 ns | 0.0325 ns | 13.635 ns |  0.63 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 22.151 ns | 0.0297 ns | 0.0278 ns | 22.142 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 21.194 ns | 0.0360 ns | 0.0337 ns | 21.192 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.026 ns | 0.0217 ns | 0.0203 ns | 20.022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.857 ns | 0.0985 ns | 0.0921 ns | 16.810 ns |  0.84 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.026 ns | 0.0835 ns | 0.0652 ns | 17.014 ns |  0.85 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.757 ns | 0.0374 ns | 0.0292 ns | 19.753 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 22.108 ns | 0.0498 ns | 0.0441 ns | 22.108 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.990 ns | 0.0186 ns | 0.0174 ns | 15.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.145 ns | 0.0144 ns | 0.0113 ns | 12.144 ns |  0.76 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.085 ns | 0.0555 ns | 0.0519 ns |  8.059 ns |  0.51 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 15.830 ns | 0.0232 ns | 0.0217 ns | 15.827 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 12.939 ns | 0.0192 ns | 0.0180 ns | 12.941 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.559 ns | 0.0547 ns | 0.0512 ns | 15.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.169 ns | 0.0708 ns | 0.0663 ns | 13.120 ns |  0.85 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.348 ns | 0.2941 ns | 0.2456 ns | 14.475 ns |  0.92 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.889 ns | 0.0144 ns | 0.0135 ns | 15.890 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.125 ns | 0.0083 ns | 0.0077 ns | 16.124 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.884 ns | 0.0130 ns | 0.0108 ns | 13.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.255 ns | 0.0123 ns | 0.0109 ns | 12.251 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.624 ns | 0.0183 ns | 0.0171 ns |  7.627 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.302 ns | 0.0311 ns | 0.0276 ns | 14.305 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.900 ns | 0.0203 ns | 0.0170 ns | 12.900 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.941 ns | 0.0366 ns | 0.0306 ns | 16.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.455 ns | 0.0518 ns | 0.0485 ns | 14.428 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.668 ns | 0.0217 ns | 0.0203 ns | 16.667 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.114 ns | 0.0236 ns | 0.0209 ns | 17.118 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 18.227 ns | 0.0293 ns | 0.0274 ns | 18.222 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.897 ns | 0.0166 ns | 0.0155 ns | 13.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.791 ns | 0.0274 ns | 0.0256 ns | 12.794 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  8.077 ns | 0.0875 ns | 0.0818 ns |  8.021 ns |  0.58 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.311 ns | 0.0141 ns | 0.0131 ns | 14.313 ns |  1.03 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.040 ns | 0.0386 ns | 0.0342 ns | 13.046 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.932 ns | 0.0294 ns | 0.0246 ns | 19.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.829 ns | 0.0154 ns | 0.0144 ns | 14.828 ns |  0.74 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.897 ns | 0.3176 ns | 0.4453 ns | 15.235 ns |  0.73 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.036 ns | 0.0343 ns | 0.0321 ns | 19.034 ns |  0.95 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.453 ns | 0.0251 ns | 0.0234 ns | 19.445 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.978 ns | 0.0126 ns | 0.0112 ns | 13.978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.958 ns | 0.0587 ns | 0.0549 ns | 11.928 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.592 ns | 0.0164 ns | 0.0128 ns |  7.588 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 14.305 ns | 0.0298 ns | 0.0264 ns | 14.304 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.991 ns | 0.0111 ns | 0.0104 ns | 12.992 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.283 ns | 0.0144 ns | 0.0128 ns | 15.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.947 ns | 0.0187 ns | 0.0166 ns | 12.950 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.324 ns | 0.0208 ns | 0.0163 ns | 14.325 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.699 ns | 0.0194 ns | 0.0172 ns | 14.698 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.255 ns | 0.0206 ns | 0.0183 ns | 17.252 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.107 ns | 0.0259 ns | 0.0230 ns | 14.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.989 ns | 0.0105 ns | 0.0088 ns | 10.987 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.968 ns | 0.0147 ns | 0.0137 ns |  7.967 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.527 ns | 0.0124 ns | 0.0110 ns | 13.525 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.028 ns | 0.0294 ns | 0.0245 ns | 13.025 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.418 ns | 0.0616 ns | 0.0576 ns | 49.420 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.825 ns | 0.1915 ns | 0.1698 ns | 43.869 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.215 ns | 0.7916 ns | 0.8129 ns | 39.783 ns |  0.80 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 47.851 ns | 0.0643 ns | 0.0570 ns | 47.857 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 52.065 ns | 0.1007 ns | 0.0942 ns | 52.031 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.382 ns | 0.0133 ns | 0.0118 ns | 14.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.771 ns | 0.0153 ns | 0.0136 ns | 10.770 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.822 ns | 0.0122 ns | 0.0109 ns |  8.820 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.425 ns | 0.0147 ns | 0.0137 ns | 14.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.908 ns | 0.0287 ns | 0.0254 ns | 13.912 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.477 ns | 0.0649 ns | 0.0607 ns | 46.454 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 47.647 ns | 0.3420 ns | 0.3199 ns | 47.457 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 38.667 ns | 0.7691 ns | 0.7553 ns | 38.151 ns |  0.83 |    0.02 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 48.559 ns | 0.1490 ns | 0.1321 ns | 48.604 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 50.849 ns | 0.1385 ns | 0.1295 ns | 50.826 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.966 ns | 0.0106 ns | 0.0089 ns | 13.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.925 ns | 0.0120 ns | 0.0106 ns | 12.924 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  8.861 ns | 0.0117 ns | 0.0104 ns |  8.864 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.263 ns | 0.0920 ns | 0.0769 ns | 14.271 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.751 ns | 0.0399 ns | 0.0373 ns | 13.751 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.288 ns | 0.0192 ns | 0.0180 ns | 15.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.708 ns | 0.0178 ns | 0.0166 ns | 13.706 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.906 ns | 0.0211 ns | 0.0197 ns | 12.904 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.864 ns | 0.0290 ns | 0.0272 ns | 14.853 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.260 ns | 0.0295 ns | 0.0246 ns | 16.258 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.254 ns | 0.0432 ns | 0.0404 ns | 13.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.874 ns | 0.0369 ns | 0.0345 ns | 11.883 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.410 ns | 0.0911 ns | 0.0761 ns | 11.446 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.635 ns | 0.0147 ns | 0.0138 ns | 15.636 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 15.205 ns | 0.0188 ns | 0.0167 ns | 15.209 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.307 ns | 0.0153 ns | 0.0143 ns | 17.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.818 ns | 0.0155 ns | 0.0137 ns | 14.818 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.922 ns | 0.0416 ns | 0.0389 ns | 15.931 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.404 ns | 0.0335 ns | 0.0297 ns | 17.408 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.683 ns | 0.0375 ns | 0.0351 ns | 18.688 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.099 ns | 0.0208 ns | 0.0195 ns | 14.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.774 ns | 0.0136 ns | 0.0128 ns | 11.773 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.625 ns | 0.0396 ns | 0.0351 ns | 11.635 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.241 ns | 0.0591 ns | 0.0553 ns | 14.271 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.030 ns | 0.0128 ns | 0.0119 ns | 14.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.283 ns | 0.0170 ns | 0.0151 ns | 15.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.958 ns | 0.0164 ns | 0.0146 ns | 12.960 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.166 ns | 0.0138 ns | 0.0108 ns | 14.167 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.180 ns | 0.0252 ns | 0.0210 ns | 15.171 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.171 ns | 0.0670 ns | 0.0627 ns | 16.145 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.705 ns | 0.0492 ns | 0.0436 ns | 39.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.536 ns | 0.1813 ns | 0.1696 ns | 38.441 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.805 ns | 0.0606 ns | 0.0567 ns | 36.820 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 53.767 ns | 0.0398 ns | 0.0353 ns | 53.763 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 39.022 ns | 0.0484 ns | 0.0429 ns | 39.020 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.514 ns | 0.0207 ns | 0.0183 ns | 17.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.220 ns | 0.0163 ns | 0.0152 ns | 16.220 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.490 ns | 0.1517 ns | 0.1419 ns | 14.557 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 19.414 ns | 0.0315 ns | 0.0294 ns | 19.426 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 18.464 ns | 0.0306 ns | 0.0287 ns | 18.465 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.605 ns | 0.0382 ns | 0.0357 ns | 39.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.008 ns | 0.0703 ns | 0.0587 ns | 39.004 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 42.266 ns | 0.5004 ns | 0.4680 ns | 41.921 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.404 ns | 0.1191 ns | 0.1056 ns | 39.405 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.710 ns | 0.1135 ns | 0.0948 ns | 40.731 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.921 ns | 0.0276 ns | 0.0258 ns | 17.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.474 ns | 0.0206 ns | 0.0192 ns | 15.472 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.091 ns | 0.0186 ns | 0.0174 ns | 14.094 ns |  0.79 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.119 ns | 0.0388 ns | 0.0363 ns | 17.115 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.247 ns | 0.0304 ns | 0.0254 ns | 18.249 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.543 ns | 0.1404 ns | 0.1313 ns | 40.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.024 ns | 0.0461 ns | 0.0385 ns | 38.021 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.740 ns | 0.1227 ns | 0.1148 ns | 35.693 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.476 ns | 0.0327 ns | 0.0306 ns | 40.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.015 ns | 0.0330 ns | 0.0308 ns | 39.015 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.862 ns | 0.0210 ns | 0.0196 ns | 15.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.323 ns | 0.0370 ns | 0.0346 ns | 13.311 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.193 ns | 0.0215 ns | 0.0179 ns | 14.196 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 17.288 ns | 0.0261 ns | 0.0244 ns | 17.288 ns |  1.09 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 18.721 ns | 0.0209 ns | 0.0196 ns | 18.724 ns |  1.18 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
