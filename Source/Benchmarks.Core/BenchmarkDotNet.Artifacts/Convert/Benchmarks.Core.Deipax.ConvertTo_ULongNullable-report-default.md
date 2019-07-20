
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
                                             From_Bool | .NET Core 2.0 | 14.246 ns | 0.0196 ns | 0.0183 ns | 14.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.338 ns | 0.0111 ns | 0.0098 ns | 12.336 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.231 ns | 0.0349 ns | 0.0310 ns |  8.222 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.635 ns | 0.0185 ns | 0.0164 ns | 14.630 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.802 ns | 0.0119 ns | 0.0106 ns | 13.801 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 21.404 ns | 0.0199 ns | 0.0177 ns | 21.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 20.662 ns | 0.0257 ns | 0.0228 ns | 20.665 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.515 ns | 0.0308 ns | 0.0273 ns | 18.515 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 21.072 ns | 0.0231 ns | 0.0205 ns | 21.071 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 22.282 ns | 0.0401 ns | 0.0355 ns | 22.279 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.054 ns | 0.0181 ns | 0.0169 ns | 13.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.111 ns | 0.0204 ns | 0.0191 ns | 11.109 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.885 ns | 0.0118 ns | 0.0110 ns |  7.886 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 16.691 ns | 0.0223 ns | 0.0198 ns | 16.692 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 15.027 ns | 0.0240 ns | 0.0212 ns | 15.019 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.961 ns | 0.0325 ns | 0.0288 ns | 19.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.286 ns | 0.0305 ns | 0.0270 ns | 17.287 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.733 ns | 0.0449 ns | 0.0398 ns | 18.720 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.298 ns | 0.0274 ns | 0.0243 ns | 21.294 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 22.278 ns | 0.0351 ns | 0.0329 ns | 22.274 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.625 ns | 0.0409 ns | 0.0363 ns | 12.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.097 ns | 0.0220 ns | 0.0206 ns | 11.094 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.340 ns | 0.0086 ns | 0.0076 ns |  7.339 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.891 ns | 0.0211 ns | 0.0187 ns | 13.894 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 14.438 ns | 0.0363 ns | 0.0322 ns | 14.439 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.339 ns | 0.0657 ns | 0.0615 ns | 15.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.691 ns | 0.0065 ns | 0.0057 ns | 12.690 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.458 ns | 0.2688 ns | 0.2761 ns | 12.569 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.831 ns | 0.0371 ns | 0.0329 ns | 15.833 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 17.142 ns | 0.0273 ns | 0.0255 ns | 17.142 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.561 ns | 0.0121 ns | 0.0107 ns | 12.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.656 ns | 0.0709 ns | 0.0663 ns | 10.623 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.340 ns | 0.0186 ns | 0.0165 ns |  7.344 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.552 ns | 0.0159 ns | 0.0133 ns | 13.553 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 13.517 ns | 0.0153 ns | 0.0136 ns | 13.517 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.284 ns | 0.0166 ns | 0.0156 ns | 20.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.008 ns | 0.0299 ns | 0.0250 ns | 17.005 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.306 ns | 0.0477 ns | 0.0446 ns | 17.290 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 23.970 ns | 0.2057 ns | 0.1924 ns | 24.076 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 23.052 ns | 0.0266 ns | 0.0236 ns | 23.051 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.739 ns | 0.0098 ns | 0.0087 ns | 12.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.305 ns | 0.0119 ns | 0.0112 ns | 11.306 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.774 ns | 0.0122 ns | 0.0114 ns |  7.772 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.357 ns | 0.0235 ns | 0.0220 ns | 14.353 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.747 ns | 0.0208 ns | 0.0195 ns | 14.746 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.825 ns | 0.0228 ns | 0.0202 ns | 20.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.276 ns | 0.0190 ns | 0.0159 ns | 17.271 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.171 ns | 0.0323 ns | 0.0269 ns | 17.174 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.337 ns | 0.0544 ns | 0.0509 ns | 21.321 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 22.545 ns | 0.0416 ns | 0.0369 ns | 22.538 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.623 ns | 0.0814 ns | 0.0762 ns | 12.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.731 ns | 0.0150 ns | 0.0125 ns | 10.728 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.343 ns | 0.0142 ns | 0.0133 ns |  7.342 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.669 ns | 0.0306 ns | 0.0286 ns | 14.670 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 14.498 ns | 0.0191 ns | 0.0169 ns | 14.492 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.361 ns | 0.0121 ns | 0.0107 ns | 15.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.813 ns | 0.0396 ns | 0.0371 ns | 12.808 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.342 ns | 0.2896 ns | 0.4422 ns | 13.573 ns |  0.85 |    0.04 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.725 ns | 0.0096 ns | 0.0090 ns | 15.722 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.437 ns | 0.0277 ns | 0.0259 ns | 16.438 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.152 ns | 0.0111 ns | 0.0104 ns | 13.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.062 ns | 0.0119 ns | 0.0105 ns | 11.062 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  8.081 ns | 0.0131 ns | 0.0116 ns |  8.080 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.014 ns | 0.1038 ns | 0.0971 ns | 13.957 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.506 ns | 0.0110 ns | 0.0098 ns | 13.506 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 21.109 ns | 0.0283 ns | 0.0236 ns | 21.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.322 ns | 0.0239 ns | 0.0212 ns | 17.320 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 19.472 ns | 0.0837 ns | 0.0783 ns | 19.481 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 21.014 ns | 0.0828 ns | 0.0774 ns | 21.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 22.718 ns | 0.1046 ns | 0.0978 ns | 22.733 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.780 ns | 0.0176 ns | 0.0147 ns | 12.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.714 ns | 0.0197 ns | 0.0175 ns | 10.715 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.732 ns | 0.0081 ns | 0.0075 ns |  7.733 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.747 ns | 0.0220 ns | 0.0195 ns | 14.743 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 14.477 ns | 0.0752 ns | 0.0704 ns | 14.449 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.280 ns | 0.0362 ns | 0.0321 ns | 21.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.331 ns | 0.0265 ns | 0.0247 ns | 17.328 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.012 ns | 0.0498 ns | 0.0466 ns | 19.001 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 22.963 ns | 0.0337 ns | 0.0298 ns | 22.960 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 22.754 ns | 0.0776 ns | 0.0726 ns | 22.737 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.501 ns | 0.0098 ns | 0.0092 ns | 12.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.600 ns | 0.0083 ns | 0.0073 ns | 10.600 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.082 ns | 0.0059 ns | 0.0055 ns |  7.081 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 15.186 ns | 0.0189 ns | 0.0168 ns | 15.187 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.889 ns | 0.0153 ns | 0.0127 ns | 13.890 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.229 ns | 0.0286 ns | 0.0268 ns | 15.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.291 ns | 0.0132 ns | 0.0117 ns | 13.291 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.007 ns | 0.0899 ns | 0.0841 ns | 14.027 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 14.723 ns | 0.0203 ns | 0.0190 ns | 14.726 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 17.305 ns | 0.0195 ns | 0.0173 ns | 17.307 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.516 ns | 0.0101 ns | 0.0089 ns | 12.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.280 ns | 0.0095 ns | 0.0079 ns | 11.280 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.656 ns | 0.0477 ns | 0.0447 ns |  8.670 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.726 ns | 0.0495 ns | 0.0463 ns | 13.707 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.817 ns | 0.0121 ns | 0.0113 ns | 12.818 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.489 ns | 0.0403 ns | 0.0377 ns | 12.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.502 ns | 0.0138 ns | 0.0123 ns | 11.499 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.549 ns | 0.1979 ns | 0.2118 ns |  8.686 ns |  0.68 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.440 ns | 0.0207 ns | 0.0193 ns | 14.434 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.924 ns | 0.0104 ns | 0.0097 ns | 12.923 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 14.620 ns | 0.0206 ns | 0.0172 ns | 14.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.500 ns | 0.0141 ns | 0.0125 ns | 11.502 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.274 ns | 0.0123 ns | 0.0116 ns |  8.272 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.789 ns | 0.0261 ns | 0.0244 ns | 13.782 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.924 ns | 0.0190 ns | 0.0178 ns | 12.923 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.673 ns | 0.0183 ns | 0.0153 ns | 15.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.877 ns | 0.0211 ns | 0.0198 ns | 12.869 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.844 ns | 0.0445 ns | 0.0416 ns | 13.869 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 17.946 ns | 0.1002 ns | 0.0937 ns | 17.898 ns |  1.14 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 16.930 ns | 0.0204 ns | 0.0170 ns | 16.927 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 22.044 ns | 0.0121 ns | 0.0101 ns | 22.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.390 ns | 0.0396 ns | 0.0371 ns | 20.390 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.031 ns | 0.1040 ns | 0.0973 ns | 13.081 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 23.726 ns | 0.0255 ns | 0.0238 ns | 23.729 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.780 ns | 0.0621 ns | 0.0581 ns | 23.793 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.006 ns | 0.0697 ns | 0.0618 ns | 29.991 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 27.335 ns | 0.0346 ns | 0.0270 ns | 27.329 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.533 ns | 0.0157 ns | 0.0131 ns | 23.535 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 31.197 ns | 0.0452 ns | 0.0423 ns | 31.202 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 30.739 ns | 0.0732 ns | 0.0684 ns | 30.729 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.574 ns | 0.0327 ns | 0.0306 ns | 22.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.722 ns | 0.0232 ns | 0.0206 ns | 21.719 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.006 ns | 0.1898 ns | 0.1775 ns | 16.068 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.841 ns | 0.0295 ns | 0.0276 ns | 24.838 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 32.052 ns | 0.0339 ns | 0.0301 ns | 32.058 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 29.197 ns | 0.0369 ns | 0.0345 ns | 29.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 27.055 ns | 0.0296 ns | 0.0262 ns | 27.054 ns |  0.93 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 25.206 ns | 0.1294 ns | 0.1210 ns | 25.124 ns |  0.86 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 29.127 ns | 0.0468 ns | 0.0437 ns | 29.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 30.957 ns | 0.0436 ns | 0.0408 ns | 30.949 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.728 ns | 0.0128 ns | 0.0114 ns | 12.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.432 ns | 0.2609 ns | 0.2440 ns | 12.484 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.784 ns | 0.0129 ns | 0.0121 ns |  8.783 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.266 ns | 0.0285 ns | 0.0253 ns | 15.267 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.063 ns | 0.0334 ns | 0.0296 ns | 15.057 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.943 ns | 0.0664 ns | 0.0621 ns | 16.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.337 ns | 0.0180 ns | 0.0150 ns | 14.333 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.210 ns | 0.0336 ns | 0.0315 ns | 15.205 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.020 ns | 0.0306 ns | 0.0255 ns | 15.013 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 17.073 ns | 0.0254 ns | 0.0238 ns | 17.086 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.479 ns | 0.0152 ns | 0.0142 ns | 15.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.945 ns | 0.0272 ns | 0.0254 ns | 11.941 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.972 ns | 0.5199 ns | 0.8247 ns | 10.542 ns |  0.74 |    0.06 |      - |     - |     - |         - |
                                           From_Double |        net461 | 19.249 ns | 0.0213 ns | 0.0188 ns | 19.252 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 17.768 ns | 0.1035 ns | 0.0968 ns | 17.714 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 23.999 ns | 0.0270 ns | 0.0253 ns | 23.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.979 ns | 0.0166 ns | 0.0155 ns | 19.983 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 19.760 ns | 0.6285 ns | 1.1332 ns | 19.121 ns |  0.87 |    0.05 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 24.574 ns | 0.0298 ns | 0.0264 ns | 24.578 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 26.226 ns | 0.0640 ns | 0.0568 ns | 26.244 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.869 ns | 0.0520 ns | 0.0487 ns | 15.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.990 ns | 0.0100 ns | 0.0088 ns | 12.992 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.382 ns | 0.0117 ns | 0.0104 ns | 10.382 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 18.293 ns | 0.0335 ns | 0.0280 ns | 18.291 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.300 ns | 0.0259 ns | 0.0229 ns | 17.296 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.515 ns | 0.0992 ns | 0.0928 ns | 23.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.056 ns | 0.0423 ns | 0.0375 ns | 19.047 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.652 ns | 0.4050 ns | 0.4333 ns | 19.987 ns |  0.83 |    0.02 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 24.768 ns | 0.0294 ns | 0.0275 ns | 24.764 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 25.554 ns | 0.0532 ns | 0.0472 ns | 25.567 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.561 ns | 0.0124 ns | 0.0110 ns | 12.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.760 ns | 0.0109 ns | 0.0102 ns | 11.761 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.972 ns | 0.2048 ns | 0.3065 ns |  9.145 ns |  0.70 |    0.03 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.977 ns | 0.0248 ns | 0.0232 ns | 14.977 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.410 ns | 0.0130 ns | 0.0109 ns | 14.409 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.518 ns | 0.0267 ns | 0.0223 ns | 15.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.779 ns | 0.0261 ns | 0.0232 ns | 12.774 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.734 ns | 0.1134 ns | 0.1005 ns | 16.736 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.938 ns | 0.0753 ns | 0.0667 ns | 15.903 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 17.186 ns | 0.0252 ns | 0.0223 ns | 17.184 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.005 ns | 0.0145 ns | 0.0128 ns | 13.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.983 ns | 0.0240 ns | 0.0200 ns | 11.989 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.921 ns | 0.1804 ns | 0.2529 ns |  8.072 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                                            From_Short |        net461 | 15.142 ns | 0.0238 ns | 0.0223 ns | 15.138 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 14.525 ns | 0.0145 ns | 0.0121 ns | 14.525 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 22.271 ns | 0.0171 ns | 0.0142 ns | 22.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.140 ns | 0.0162 ns | 0.0135 ns | 17.143 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.884 ns | 0.0538 ns | 0.0503 ns | 17.874 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 24.341 ns | 0.0580 ns | 0.0542 ns | 24.339 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 23.733 ns | 0.0407 ns | 0.0361 ns | 23.730 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.075 ns | 0.0097 ns | 0.0091 ns | 13.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.947 ns | 0.0153 ns | 0.0128 ns | 10.951 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.566 ns | 0.2661 ns | 0.2733 ns |  9.424 ns |  0.73 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 16.312 ns | 0.0220 ns | 0.0206 ns | 16.318 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 15.750 ns | 0.0213 ns | 0.0199 ns | 15.753 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.415 ns | 0.0447 ns | 0.0418 ns | 21.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.644 ns | 0.0151 ns | 0.0126 ns | 17.643 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.592 ns | 0.0381 ns | 0.0356 ns | 18.597 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 24.480 ns | 0.1663 ns | 0.1555 ns | 24.510 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 23.744 ns | 0.0338 ns | 0.0299 ns | 23.745 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.753 ns | 0.0341 ns | 0.0303 ns | 12.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.292 ns | 0.0095 ns | 0.0085 ns | 11.295 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.273 ns | 0.1509 ns | 0.1412 ns |  7.368 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.831 ns | 0.0223 ns | 0.0186 ns | 13.834 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.877 ns | 0.0202 ns | 0.0179 ns | 13.876 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.058 ns | 0.0179 ns | 0.0167 ns | 16.056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.649 ns | 0.0128 ns | 0.0120 ns | 12.650 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.950 ns | 0.0863 ns | 0.0808 ns | 11.983 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 16.280 ns | 0.0169 ns | 0.0150 ns | 16.279 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 16.218 ns | 0.0290 ns | 0.0257 ns | 16.208 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.834 ns | 0.0281 ns | 0.0235 ns | 12.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.747 ns | 0.0658 ns | 0.0616 ns | 10.776 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.709 ns | 0.0425 ns | 0.0398 ns |  7.691 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.274 ns | 0.0164 ns | 0.0137 ns | 15.276 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 14.644 ns | 0.0521 ns | 0.0435 ns | 14.630 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.485 ns | 0.0277 ns | 0.0245 ns | 20.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.508 ns | 0.0201 ns | 0.0157 ns | 18.510 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.591 ns | 0.0402 ns | 0.0376 ns | 18.587 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 24.486 ns | 0.2226 ns | 0.2082 ns | 24.503 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 23.074 ns | 0.0578 ns | 0.0482 ns | 23.067 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.332 ns | 0.0174 ns | 0.0145 ns | 13.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.962 ns | 0.0181 ns | 0.0169 ns | 10.960 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.609 ns | 0.0259 ns | 0.0243 ns |  7.619 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 15.976 ns | 0.0273 ns | 0.0255 ns | 15.977 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 15.338 ns | 0.0626 ns | 0.0555 ns | 15.316 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.199 ns | 0.0669 ns | 0.0593 ns | 21.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.231 ns | 0.0220 ns | 0.0205 ns | 17.227 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.272 ns | 0.0223 ns | 0.0208 ns | 17.271 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.844 ns | 0.0496 ns | 0.0439 ns | 21.855 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 22.792 ns | 0.0257 ns | 0.0240 ns | 22.788 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.626 ns | 0.0146 ns | 0.0137 ns | 12.625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.608 ns | 0.0202 ns | 0.0169 ns | 10.610 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.545 ns | 0.0247 ns | 0.0219 ns |  7.539 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.491 ns | 0.0595 ns | 0.0556 ns | 14.494 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.860 ns | 0.0157 ns | 0.0139 ns | 13.856 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.200 ns | 0.0150 ns | 0.0117 ns | 15.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.569 ns | 0.0700 ns | 0.0655 ns | 13.589 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.317 ns | 0.0234 ns | 0.0219 ns | 15.317 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 17.124 ns | 0.0241 ns | 0.0202 ns | 17.122 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 18.593 ns | 0.0497 ns | 0.0440 ns | 18.604 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.580 ns | 0.0190 ns | 0.0159 ns | 13.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.665 ns | 0.0126 ns | 0.0112 ns | 10.666 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.329 ns | 0.0109 ns | 0.0085 ns |  8.327 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.708 ns | 0.0208 ns | 0.0185 ns | 14.708 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 15.336 ns | 0.0224 ns | 0.0210 ns | 15.338 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.629 ns | 0.0293 ns | 0.0274 ns | 20.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.298 ns | 0.0337 ns | 0.0315 ns | 17.290 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.811 ns | 0.0476 ns | 0.0422 ns | 18.815 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 21.764 ns | 0.0299 ns | 0.0279 ns | 21.764 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 23.732 ns | 0.1364 ns | 0.1276 ns | 23.719 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.819 ns | 0.0085 ns | 0.0079 ns | 12.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.891 ns | 0.0083 ns | 0.0077 ns | 11.891 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.355 ns | 0.0349 ns | 0.0327 ns |  8.342 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.567 ns | 0.0225 ns | 0.0188 ns | 15.566 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.512 ns | 0.0199 ns | 0.0176 ns | 15.511 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.050 ns | 0.0459 ns | 0.0430 ns | 21.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.864 ns | 0.0193 ns | 0.0180 ns | 17.864 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.360 ns | 0.0576 ns | 0.0510 ns | 18.381 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 22.188 ns | 0.0542 ns | 0.0507 ns | 22.197 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 23.778 ns | 0.0256 ns | 0.0240 ns | 23.781 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.504 ns | 0.0138 ns | 0.0123 ns | 12.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.844 ns | 0.0481 ns | 0.0426 ns | 11.853 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.233 ns | 0.0112 ns | 0.0104 ns |  8.231 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.665 ns | 0.0214 ns | 0.0190 ns | 14.663 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.797 ns | 0.0176 ns | 0.0164 ns | 14.801 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.210 ns | 0.0239 ns | 0.0224 ns | 15.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.662 ns | 0.0089 ns | 0.0079 ns | 12.660 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.972 ns | 0.3044 ns | 0.3383 ns | 13.686 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 17.145 ns | 0.0973 ns | 0.0911 ns | 17.098 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 17.162 ns | 0.0261 ns | 0.0245 ns | 17.161 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.803 ns | 0.0116 ns | 0.0108 ns | 12.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.239 ns | 0.0102 ns | 0.0090 ns | 11.236 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.518 ns | 0.0116 ns | 0.0109 ns |  7.518 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 15.018 ns | 0.0177 ns | 0.0157 ns | 15.015 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 14.463 ns | 0.0844 ns | 0.0790 ns | 14.507 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 21.199 ns | 0.0456 ns | 0.0427 ns | 21.200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.023 ns | 0.0180 ns | 0.0160 ns | 17.028 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.437 ns | 0.0532 ns | 0.0498 ns | 17.444 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 21.845 ns | 0.0380 ns | 0.0337 ns | 21.833 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 23.472 ns | 0.0302 ns | 0.0282 ns | 23.469 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.140 ns | 0.0144 ns | 0.0120 ns | 13.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 12.120 ns | 0.1392 ns | 0.1302 ns | 12.092 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.976 ns | 0.2018 ns | 0.3200 ns |  9.053 ns |  0.67 |    0.04 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 15.285 ns | 0.0223 ns | 0.0209 ns | 15.289 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 15.913 ns | 0.0346 ns | 0.0324 ns | 15.911 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.210 ns | 0.0270 ns | 0.0239 ns | 21.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.451 ns | 0.0143 ns | 0.0127 ns | 17.453 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.012 ns | 0.3865 ns | 0.3970 ns | 18.282 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 23.985 ns | 0.0362 ns | 0.0302 ns | 23.982 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 22.971 ns | 0.0696 ns | 0.0617 ns | 22.996 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.753 ns | 0.0182 ns | 0.0152 ns | 12.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.699 ns | 0.0078 ns | 0.0070 ns | 10.699 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.657 ns | 0.0134 ns | 0.0125 ns |  7.660 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.802 ns | 0.0432 ns | 0.0404 ns | 14.799 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 14.482 ns | 0.1955 ns | 0.1829 ns | 14.489 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.054 ns | 0.0158 ns | 0.0148 ns | 16.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.725 ns | 0.0215 ns | 0.0201 ns | 13.726 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.788 ns | 0.0331 ns | 0.0294 ns | 14.797 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 17.094 ns | 0.0192 ns | 0.0170 ns | 17.095 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 17.234 ns | 0.0880 ns | 0.0780 ns | 17.188 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.485 ns | 0.0167 ns | 0.0148 ns | 15.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.170 ns | 0.0117 ns | 0.0103 ns | 13.170 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 11.165 ns | 0.2436 ns | 0.3334 ns | 11.378 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net461 | 18.844 ns | 0.1263 ns | 0.1181 ns | 18.762 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 17.824 ns | 0.0187 ns | 0.0166 ns | 17.828 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.365 ns | 0.0274 ns | 0.0243 ns | 23.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.803 ns | 0.0372 ns | 0.0330 ns | 20.791 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.245 ns | 0.0833 ns | 0.0738 ns | 19.275 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 24.649 ns | 0.0319 ns | 0.0298 ns | 24.655 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 25.867 ns | 0.0276 ns | 0.0245 ns | 25.868 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.615 ns | 0.0171 ns | 0.0152 ns | 15.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.086 ns | 0.0113 ns | 0.0100 ns | 12.083 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  9.814 ns | 0.2191 ns | 0.3721 ns | 10.000 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 17.205 ns | 0.0224 ns | 0.0198 ns | 17.205 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 18.332 ns | 0.0200 ns | 0.0187 ns | 18.333 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.799 ns | 0.0216 ns | 0.0202 ns | 23.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.887 ns | 0.0181 ns | 0.0169 ns | 18.882 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.648 ns | 0.0509 ns | 0.0452 ns | 18.661 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 24.706 ns | 0.1398 ns | 0.1307 ns | 24.662 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 25.575 ns | 0.0327 ns | 0.0290 ns | 25.569 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.786 ns | 0.0327 ns | 0.0306 ns | 12.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.744 ns | 0.0083 ns | 0.0073 ns | 10.744 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.498 ns | 0.0083 ns | 0.0077 ns |  7.498 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.326 ns | 0.0222 ns | 0.0208 ns | 14.322 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.870 ns | 0.0174 ns | 0.0163 ns | 13.872 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.659 ns | 0.0157 ns | 0.0123 ns | 16.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.015 ns | 0.0218 ns | 0.0193 ns | 13.009 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.115 ns | 0.0178 ns | 0.0139 ns | 14.111 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.658 ns | 0.0107 ns | 0.0089 ns | 14.660 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 16.522 ns | 0.0879 ns | 0.0822 ns | 16.546 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.952 ns | 0.0895 ns | 0.0794 ns | 59.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 51.180 ns | 0.2872 ns | 0.2687 ns | 51.278 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 21.721 ns | 0.1251 ns | 0.1170 ns | 21.664 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 60.009 ns | 0.1030 ns | 0.0964 ns | 60.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 62.453 ns | 0.1451 ns | 0.1286 ns | 62.459 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 69.450 ns | 0.1623 ns | 0.1518 ns | 69.398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 60.300 ns | 0.0995 ns | 0.0831 ns | 60.292 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 27.982 ns | 0.0498 ns | 0.0441 ns | 27.970 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 65.507 ns | 0.1113 ns | 0.1041 ns | 65.540 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 67.184 ns | 0.1626 ns | 0.1521 ns | 67.105 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.485 ns | 0.0340 ns | 0.0318 ns | 13.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.050 ns | 0.0198 ns | 0.0185 ns | 12.044 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.376 ns | 0.0473 ns | 0.0420 ns | 12.386 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.740 ns | 0.0771 ns | 0.0722 ns | 14.715 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.760 ns | 0.0581 ns | 0.0543 ns | 16.776 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 16.777 ns | 0.0279 ns | 0.0248 ns | 16.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.441 ns | 0.0097 ns | 0.0091 ns | 13.440 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.995 ns | 0.2464 ns | 0.2305 ns | 13.194 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.945 ns | 0.0224 ns | 0.0210 ns | 14.938 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.315 ns | 0.0198 ns | 0.0176 ns | 16.314 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.482 ns | 0.0120 ns | 0.0112 ns | 14.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.344 ns | 0.0153 ns | 0.0136 ns | 12.345 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.422 ns | 0.2825 ns | 0.3253 ns | 13.574 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.227 ns | 0.0285 ns | 0.0253 ns | 14.216 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.525 ns | 0.0207 ns | 0.0194 ns | 16.525 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.555 ns | 0.0152 ns | 0.0142 ns | 12.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.590 ns | 0.0102 ns | 0.0085 ns | 10.589 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  8.154 ns | 0.0702 ns | 0.0657 ns |  8.194 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.994 ns | 0.0202 ns | 0.0189 ns | 13.994 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.566 ns | 0.0345 ns | 0.0288 ns | 13.553 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.341 ns | 0.0264 ns | 0.0247 ns | 20.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.061 ns | 0.0209 ns | 0.0195 ns | 17.066 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.830 ns | 0.0637 ns | 0.0596 ns | 18.831 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.383 ns | 0.1316 ns | 0.1231 ns | 21.353 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 22.382 ns | 0.0306 ns | 0.0287 ns | 22.384 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.640 ns | 0.0070 ns | 0.0062 ns | 12.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.763 ns | 0.0438 ns | 0.0388 ns | 10.775 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.667 ns | 0.1758 ns | 0.1805 ns |  7.807 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.848 ns | 0.0267 ns | 0.0236 ns | 14.855 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 16.890 ns | 0.0186 ns | 0.0165 ns | 16.891 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.368 ns | 0.0810 ns | 0.0758 ns | 21.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.334 ns | 0.0249 ns | 0.0221 ns | 17.330 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.258 ns | 0.5075 ns | 0.6775 ns | 17.901 ns |  0.87 |    0.04 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.623 ns | 0.1631 ns | 0.1526 ns | 21.518 ns |  1.01 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.758 ns | 0.1088 ns | 0.1017 ns | 22.792 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.787 ns | 0.0111 ns | 0.0092 ns | 12.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.090 ns | 0.0640 ns | 0.0599 ns | 11.120 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.636 ns | 0.1219 ns | 0.1140 ns |  7.557 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.465 ns | 0.0720 ns | 0.0638 ns | 14.493 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 15.068 ns | 0.0120 ns | 0.0112 ns | 15.071 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.040 ns | 0.0143 ns | 0.0127 ns | 16.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.665 ns | 0.0195 ns | 0.0182 ns | 14.668 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.782 ns | 0.0325 ns | 0.0304 ns | 12.777 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.608 ns | 0.0512 ns | 0.0479 ns | 14.588 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 17.963 ns | 0.0229 ns | 0.0203 ns | 17.960 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.615 ns | 0.0226 ns | 0.0211 ns | 12.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 12.832 ns | 0.0193 ns | 0.0180 ns | 12.831 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  8.344 ns | 0.0114 ns | 0.0101 ns |  8.342 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.736 ns | 0.0173 ns | 0.0162 ns | 13.740 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.875 ns | 0.0416 ns | 0.0369 ns | 13.885 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 22.055 ns | 0.0235 ns | 0.0197 ns | 22.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.815 ns | 0.0147 ns | 0.0123 ns | 16.811 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.356 ns | 0.0514 ns | 0.0481 ns | 17.356 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.329 ns | 0.0186 ns | 0.0165 ns | 21.328 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 23.152 ns | 0.0527 ns | 0.0493 ns | 23.142 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.719 ns | 0.0504 ns | 0.0472 ns | 12.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.766 ns | 0.0380 ns | 0.0356 ns | 10.780 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.401 ns | 0.1937 ns | 0.2959 ns |  8.372 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.853 ns | 0.0219 ns | 0.0204 ns | 14.855 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 14.871 ns | 0.0215 ns | 0.0201 ns | 14.868 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.858 ns | 0.0261 ns | 0.0244 ns | 20.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.047 ns | 0.0181 ns | 0.0151 ns | 17.048 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.411 ns | 0.0368 ns | 0.0344 ns | 18.402 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 21.408 ns | 0.1357 ns | 0.1270 ns | 21.485 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 22.377 ns | 0.0336 ns | 0.0315 ns | 22.371 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.503 ns | 0.0118 ns | 0.0098 ns | 12.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.678 ns | 0.0420 ns | 0.0373 ns | 10.694 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.440 ns | 0.2334 ns | 0.3116 ns |  7.272 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.833 ns | 0.0186 ns | 0.0165 ns | 13.828 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.900 ns | 0.0579 ns | 0.0541 ns | 13.875 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.142 ns | 0.0291 ns | 0.0272 ns | 19.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.656 ns | 0.0135 ns | 0.0120 ns | 12.658 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.949 ns | 0.1604 ns | 0.1500 ns | 13.054 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.757 ns | 0.0183 ns | 0.0171 ns | 14.755 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 17.324 ns | 0.0214 ns | 0.0190 ns | 17.327 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.355 ns | 0.0295 ns | 0.0261 ns | 13.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.426 ns | 0.0539 ns | 0.0504 ns | 10.401 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.696 ns | 0.0290 ns | 0.0271 ns |  7.707 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.962 ns | 0.0147 ns | 0.0137 ns | 12.959 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.756 ns | 0.0160 ns | 0.0142 ns | 12.756 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 26.451 ns | 0.1025 ns | 0.0959 ns | 26.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 26.656 ns | 0.0408 ns | 0.0362 ns | 26.646 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 30.040 ns | 0.0396 ns | 0.0351 ns | 30.039 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 32.755 ns | 0.0574 ns | 0.0509 ns | 32.748 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 35.345 ns | 0.1330 ns | 0.1244 ns | 35.385 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.663 ns | 0.0359 ns | 0.0318 ns | 12.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.238 ns | 0.0440 ns | 0.0412 ns | 12.217 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  9.407 ns | 0.0173 ns | 0.0154 ns |  9.404 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.779 ns | 0.0135 ns | 0.0113 ns | 13.782 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.973 ns | 0.0166 ns | 0.0156 ns | 13.975 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.904 ns | 0.0141 ns | 0.0125 ns | 24.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.734 ns | 0.0253 ns | 0.0224 ns | 25.732 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.774 ns | 0.0507 ns | 0.0449 ns | 28.772 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 34.739 ns | 0.0352 ns | 0.0329 ns | 34.745 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 33.823 ns | 0.1742 ns | 0.1629 ns | 33.726 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.568 ns | 0.0137 ns | 0.0121 ns | 12.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.840 ns | 0.0890 ns | 0.0832 ns | 11.790 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.018 ns | 0.0130 ns | 0.0122 ns |  9.014 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.866 ns | 0.0141 ns | 0.0132 ns | 12.868 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.145 ns | 0.0295 ns | 0.0261 ns | 13.138 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.742 ns | 0.0202 ns | 0.0179 ns | 17.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.695 ns | 0.0144 ns | 0.0128 ns | 12.696 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.769 ns | 0.0218 ns | 0.0182 ns | 12.768 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.865 ns | 0.0383 ns | 0.0339 ns | 14.869 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 17.195 ns | 0.0212 ns | 0.0199 ns | 17.198 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.219 ns | 0.0177 ns | 0.0166 ns | 15.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.764 ns | 0.0089 ns | 0.0079 ns | 14.764 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.194 ns | 0.0446 ns | 0.0417 ns | 13.211 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 14.849 ns | 0.0276 ns | 0.0258 ns | 14.846 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.385 ns | 0.0796 ns | 0.0745 ns | 17.345 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.488 ns | 0.0389 ns | 0.0364 ns | 12.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.613 ns | 0.0094 ns | 0.0088 ns |  9.615 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.217 ns | 0.1661 ns | 0.1554 ns | 12.209 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 14.062 ns | 0.0243 ns | 0.0228 ns | 14.056 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.528 ns | 0.0359 ns | 0.0336 ns | 12.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.862 ns | 0.0212 ns | 0.0198 ns | 15.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.700 ns | 0.0132 ns | 0.0123 ns | 12.701 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.454 ns | 0.2917 ns | 0.5758 ns | 13.708 ns |  0.81 |    0.05 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.558 ns | 0.0123 ns | 0.0115 ns | 14.556 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 17.902 ns | 0.0176 ns | 0.0164 ns | 17.901 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.594 ns | 0.0183 ns | 0.0171 ns | 17.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.604 ns | 0.0098 ns | 0.0082 ns | 14.604 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.332 ns | 0.0966 ns | 0.0903 ns | 13.283 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.423 ns | 0.0488 ns | 0.0456 ns | 18.410 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.163 ns | 0.0404 ns | 0.0378 ns | 18.171 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.787 ns | 0.0269 ns | 0.0239 ns | 19.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.673 ns | 0.0177 ns | 0.0157 ns | 15.675 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.102 ns | 0.1043 ns | 0.0975 ns | 16.067 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 19.544 ns | 0.0311 ns | 0.0291 ns | 19.538 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 20.599 ns | 0.0287 ns | 0.0240 ns | 20.606 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.566 ns | 0.0128 ns | 0.0113 ns | 14.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.202 ns | 0.0126 ns | 0.0118 ns | 13.200 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.454 ns | 0.0158 ns | 0.0140 ns | 12.453 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.617 ns | 0.0102 ns | 0.0090 ns | 14.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 16.147 ns | 0.0217 ns | 0.0182 ns | 16.144 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.698 ns | 0.0158 ns | 0.0140 ns | 16.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.738 ns | 0.0209 ns | 0.0196 ns | 12.732 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.022 ns | 0.2685 ns | 0.2512 ns | 13.805 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 17.643 ns | 0.0165 ns | 0.0146 ns | 17.644 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 17.176 ns | 0.0300 ns | 0.0266 ns | 17.180 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.810 ns | 0.0237 ns | 0.0221 ns | 14.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.633 ns | 0.0173 ns | 0.0161 ns | 11.626 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.963 ns | 0.0294 ns | 0.0275 ns | 10.970 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.133 ns | 0.0565 ns | 0.0501 ns | 15.151 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.125 ns | 0.0120 ns | 0.0112 ns | 14.125 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.708 ns | 0.0210 ns | 0.0186 ns | 17.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.078 ns | 0.0070 ns | 0.0065 ns | 14.080 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.470 ns | 0.2440 ns | 0.2282 ns | 14.644 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 19.403 ns | 0.0338 ns | 0.0300 ns | 19.398 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 19.160 ns | 0.0326 ns | 0.0272 ns | 19.164 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.312 ns | 0.0173 ns | 0.0144 ns | 13.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.470 ns | 0.0153 ns | 0.0136 ns | 12.474 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.935 ns | 0.0498 ns | 0.0466 ns | 10.950 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.496 ns | 0.0296 ns | 0.0248 ns | 14.487 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.318 ns | 0.0142 ns | 0.0126 ns | 14.317 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.060 ns | 0.0175 ns | 0.0146 ns | 16.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 15.068 ns | 0.0111 ns | 0.0098 ns | 15.067 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.115 ns | 0.0157 ns | 0.0147 ns | 14.119 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.873 ns | 0.0301 ns | 0.0267 ns | 15.872 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 17.387 ns | 0.0463 ns | 0.0433 ns | 17.399 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 22.218 ns | 0.1812 ns | 0.1695 ns | 22.289 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.264 ns | 0.0402 ns | 0.0357 ns | 16.274 ns |  0.73 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.979 ns | 0.0460 ns | 0.0430 ns | 12.976 ns |  0.58 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 21.959 ns | 0.0487 ns | 0.0431 ns | 21.957 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 21.372 ns | 0.0582 ns | 0.0516 ns | 21.362 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 20.139 ns | 0.0484 ns | 0.0429 ns | 20.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.190 ns | 0.0278 ns | 0.0246 ns | 16.189 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.990 ns | 0.0279 ns | 0.0247 ns | 16.991 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 20.165 ns | 0.0159 ns | 0.0141 ns | 20.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 22.019 ns | 0.0293 ns | 0.0274 ns | 22.021 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 22.050 ns | 0.0516 ns | 0.0483 ns | 22.035 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.987 ns | 0.0868 ns | 0.0812 ns | 17.010 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.878 ns | 0.0411 ns | 0.0364 ns | 12.879 ns |  0.58 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 21.035 ns | 0.0714 ns | 0.0668 ns | 21.026 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 19.857 ns | 0.0407 ns | 0.0380 ns | 19.848 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.639 ns | 0.0208 ns | 0.0185 ns | 21.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.880 ns | 0.0210 ns | 0.0175 ns | 17.877 ns |  0.83 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.551 ns | 0.0376 ns | 0.0352 ns | 16.550 ns |  0.77 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.176 ns | 0.0194 ns | 0.0172 ns | 20.183 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 21.345 ns | 0.0362 ns | 0.0338 ns | 21.352 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.844 ns | 0.0187 ns | 0.0156 ns | 14.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.134 ns | 0.0093 ns | 0.0082 ns | 12.136 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.926 ns | 0.0075 ns | 0.0059 ns |  8.927 ns |  0.60 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 15.351 ns | 0.0217 ns | 0.0203 ns | 15.352 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.235 ns | 0.0113 ns | 0.0095 ns | 13.232 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.212 ns | 0.1325 ns | 0.1240 ns | 16.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.743 ns | 0.0119 ns | 0.0106 ns | 13.743 ns |  0.85 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.791 ns | 0.0204 ns | 0.0181 ns | 13.792 ns |  0.85 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 17.239 ns | 0.1095 ns | 0.1024 ns | 17.286 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.641 ns | 0.0183 ns | 0.0163 ns | 16.643 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.577 ns | 0.0095 ns | 0.0089 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.967 ns | 0.0328 ns | 0.0307 ns | 11.972 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.587 ns | 0.0109 ns | 0.0097 ns |  7.586 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.608 ns | 0.0205 ns | 0.0181 ns | 14.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.906 ns | 0.0132 ns | 0.0117 ns | 12.905 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.925 ns | 0.0642 ns | 0.0601 ns | 16.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.093 ns | 0.0212 ns | 0.0198 ns | 14.089 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.703 ns | 0.3197 ns | 0.4043 ns | 14.984 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 17.175 ns | 0.0150 ns | 0.0126 ns | 17.175 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 19.507 ns | 0.0692 ns | 0.0578 ns | 19.516 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.920 ns | 0.0219 ns | 0.0205 ns | 13.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.973 ns | 0.0085 ns | 0.0079 ns | 11.975 ns |  0.86 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.573 ns | 0.0093 ns | 0.0083 ns |  7.574 ns |  0.54 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.433 ns | 0.0241 ns | 0.0225 ns | 14.434 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.862 ns | 0.0210 ns | 0.0186 ns | 12.863 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.053 ns | 0.0242 ns | 0.0226 ns | 17.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.076 ns | 0.0099 ns | 0.0093 ns | 14.077 ns |  0.83 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.609 ns | 0.3160 ns | 0.3639 ns | 14.497 ns |  0.86 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.977 ns | 0.0308 ns | 0.0288 ns | 16.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.187 ns | 0.0304 ns | 0.0284 ns | 19.189 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.962 ns | 0.0100 ns | 0.0093 ns | 13.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.606 ns | 0.0109 ns | 0.0097 ns | 10.606 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.584 ns | 0.0160 ns | 0.0149 ns |  7.578 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 14.588 ns | 0.0189 ns | 0.0168 ns | 14.589 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.844 ns | 0.0125 ns | 0.0111 ns | 12.846 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.336 ns | 0.0240 ns | 0.0200 ns | 15.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.698 ns | 0.0115 ns | 0.0102 ns | 12.696 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.111 ns | 0.0199 ns | 0.0187 ns | 14.112 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.465 ns | 0.0122 ns | 0.0095 ns | 15.466 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.195 ns | 0.0392 ns | 0.0367 ns | 17.183 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.273 ns | 0.0178 ns | 0.0166 ns | 14.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.656 ns | 0.0074 ns | 0.0066 ns | 10.656 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.526 ns | 0.0089 ns | 0.0074 ns |  7.527 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 15.014 ns | 0.0352 ns | 0.0294 ns | 15.019 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.476 ns | 0.0189 ns | 0.0177 ns | 14.476 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.118 ns | 0.0768 ns | 0.0719 ns | 50.088 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.242 ns | 0.0626 ns | 0.0585 ns | 44.221 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 42.280 ns | 0.8170 ns | 0.9726 ns | 41.598 ns |  0.85 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 48.295 ns | 0.0580 ns | 0.0514 ns | 48.277 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 49.592 ns | 0.0700 ns | 0.0621 ns | 49.591 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.441 ns | 0.0278 ns | 0.0246 ns | 14.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.380 ns | 0.0550 ns | 0.0514 ns | 11.405 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.585 ns | 0.0119 ns | 0.0112 ns |  7.586 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.973 ns | 0.0220 ns | 0.0184 ns | 14.972 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.361 ns | 0.0368 ns | 0.0326 ns | 14.365 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 49.296 ns | 0.0717 ns | 0.0599 ns | 49.280 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 45.023 ns | 0.1506 ns | 0.1409 ns | 44.983 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 42.149 ns | 0.0746 ns | 0.0698 ns | 42.157 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.503 ns | 0.0800 ns | 0.0709 ns | 50.477 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 52.294 ns | 0.0909 ns | 0.0759 ns | 52.275 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.121 ns | 0.0122 ns | 0.0108 ns | 14.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.609 ns | 0.0171 ns | 0.0160 ns | 13.614 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.796 ns | 0.1784 ns | 0.2829 ns |  7.974 ns |  0.53 |    0.02 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.565 ns | 0.0131 ns | 0.0123 ns | 13.568 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.470 ns | 0.0174 ns | 0.0155 ns | 13.470 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.198 ns | 0.0341 ns | 0.0284 ns | 16.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.389 ns | 0.0155 ns | 0.0137 ns | 14.387 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.119 ns | 0.2167 ns | 0.2027 ns | 13.993 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 15.075 ns | 0.0167 ns | 0.0139 ns | 15.076 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 17.287 ns | 0.0352 ns | 0.0312 ns | 17.292 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.241 ns | 0.0166 ns | 0.0155 ns | 13.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.630 ns | 0.0094 ns | 0.0083 ns | 11.630 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.671 ns | 0.0186 ns | 0.0165 ns | 11.678 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.288 ns | 0.0134 ns | 0.0118 ns | 14.286 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.218 ns | 0.0168 ns | 0.0157 ns | 14.217 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.056 ns | 0.0219 ns | 0.0205 ns | 18.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.620 ns | 0.0528 ns | 0.0468 ns | 14.633 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.455 ns | 0.0248 ns | 0.0220 ns | 14.451 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.241 ns | 0.0417 ns | 0.0369 ns | 17.234 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 18.663 ns | 0.0230 ns | 0.0204 ns | 18.656 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.400 ns | 0.0210 ns | 0.0196 ns | 13.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.626 ns | 0.0143 ns | 0.0127 ns | 11.627 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.049 ns | 0.0137 ns | 0.0114 ns | 11.046 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.165 ns | 0.0157 ns | 0.0139 ns | 14.164 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.139 ns | 0.0189 ns | 0.0167 ns | 14.135 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 17.799 ns | 0.0576 ns | 0.0538 ns | 17.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.706 ns | 0.0120 ns | 0.0106 ns | 12.707 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.220 ns | 0.1340 ns | 0.1254 ns | 13.142 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.507 ns | 0.0456 ns | 0.0427 ns | 14.492 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 17.206 ns | 0.0250 ns | 0.0234 ns | 17.206 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 41.869 ns | 0.0483 ns | 0.0428 ns | 41.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 40.142 ns | 0.0281 ns | 0.0249 ns | 40.138 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.337 ns | 0.2174 ns | 0.2033 ns | 38.224 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.528 ns | 0.0948 ns | 0.0887 ns | 39.506 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.842 ns | 0.1115 ns | 0.0931 ns | 38.861 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.167 ns | 0.0190 ns | 0.0168 ns | 17.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.521 ns | 0.0140 ns | 0.0124 ns | 14.522 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.545 ns | 0.1249 ns | 0.1168 ns | 14.462 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 17.526 ns | 0.0272 ns | 0.0255 ns | 17.530 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 20.119 ns | 0.0405 ns | 0.0379 ns | 20.135 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.249 ns | 0.0512 ns | 0.0400 ns | 40.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.626 ns | 0.0954 ns | 0.0893 ns | 38.594 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.303 ns | 0.0532 ns | 0.0471 ns | 35.307 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.822 ns | 0.1639 ns | 0.1533 ns | 39.847 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.952 ns | 0.0945 ns | 0.0884 ns | 39.909 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.873 ns | 0.0185 ns | 0.0173 ns | 18.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.325 ns | 0.0094 ns | 0.0084 ns | 15.325 ns |  0.81 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.407 ns | 0.0222 ns | 0.0197 ns | 17.410 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.244 ns | 0.0311 ns | 0.0275 ns | 17.241 ns |  0.91 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 18.716 ns | 0.0300 ns | 0.0281 ns | 18.713 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.262 ns | 0.0532 ns | 0.0498 ns | 40.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 36.733 ns | 0.0404 ns | 0.0359 ns | 36.737 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.437 ns | 0.2052 ns | 0.1714 ns | 36.486 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.444 ns | 0.0975 ns | 0.0814 ns | 39.430 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 46.153 ns | 0.0434 ns | 0.0406 ns | 46.158 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.530 ns | 0.0342 ns | 0.0267 ns | 15.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.688 ns | 0.0134 ns | 0.0126 ns | 12.684 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.007 ns | 0.0132 ns | 0.0123 ns | 14.010 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.621 ns | 0.0182 ns | 0.0161 ns | 14.619 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 17.644 ns | 0.0303 ns | 0.0253 ns | 17.651 ns |  1.14 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULongNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULongNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
