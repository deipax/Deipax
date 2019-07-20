
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
                                             From_Bool | .NET Core 2.0 | 13.717 ns | 0.0377 ns | 0.0353 ns | 13.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.234 ns | 0.0155 ns | 0.0145 ns | 12.235 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.742 ns | 0.0257 ns | 0.0228 ns |  6.745 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 11.891 ns | 0.0159 ns | 0.0141 ns | 11.892 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.450 ns | 0.0184 ns | 0.0172 ns | 10.447 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.999 ns | 0.0665 ns | 0.0622 ns | 18.989 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.432 ns | 0.0225 ns | 0.0211 ns | 15.436 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.941 ns | 0.0756 ns | 0.0707 ns | 15.919 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.660 ns | 0.0226 ns | 0.0201 ns | 18.657 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.898 ns | 0.0568 ns | 0.0503 ns | 20.892 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.319 ns | 0.0154 ns | 0.0144 ns | 13.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.476 ns | 0.0110 ns | 0.0097 ns | 10.476 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.025 ns | 0.0586 ns | 0.0549 ns |  8.005 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.888 ns | 0.0208 ns | 0.0194 ns | 12.887 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.779 ns | 0.0140 ns | 0.0131 ns | 11.774 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.339 ns | 0.0566 ns | 0.0502 ns | 18.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.317 ns | 0.0591 ns | 0.0553 ns | 16.322 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.719 ns | 0.0223 ns | 0.0209 ns | 15.718 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.862 ns | 0.0271 ns | 0.0254 ns | 18.859 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.599 ns | 0.0291 ns | 0.0258 ns | 20.600 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.134 ns | 0.0261 ns | 0.0232 ns | 13.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.074 ns | 0.0410 ns | 0.0363 ns | 10.061 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.306 ns | 0.0092 ns | 0.0086 ns |  7.306 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.972 ns | 0.0170 ns | 0.0159 ns | 11.972 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.434 ns | 0.0095 ns | 0.0074 ns | 10.435 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.059 ns | 0.0255 ns | 0.0226 ns | 15.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.404 ns | 0.0770 ns | 0.0721 ns | 13.361 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.625 ns | 0.2759 ns | 0.3956 ns | 12.817 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.598 ns | 0.0220 ns | 0.0206 ns | 13.597 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.374 ns | 0.0925 ns | 0.0865 ns | 15.384 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.695 ns | 0.0187 ns | 0.0156 ns | 11.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.031 ns | 0.0134 ns | 0.0126 ns | 10.035 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.679 ns | 0.0200 ns | 0.0178 ns |  6.675 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.452 ns | 0.0219 ns | 0.0194 ns | 12.449 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.362 ns | 0.0158 ns | 0.0148 ns | 10.359 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.965 ns | 0.0234 ns | 0.0219 ns | 17.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 14.976 ns | 0.0195 ns | 0.0152 ns | 14.979 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.207 ns | 0.0330 ns | 0.0309 ns | 15.207 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.013 ns | 0.0387 ns | 0.0362 ns | 19.020 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 21.385 ns | 0.1270 ns | 0.1188 ns | 21.425 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.239 ns | 0.0429 ns | 0.0401 ns | 13.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.334 ns | 0.0434 ns | 0.0406 ns | 10.346 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.791 ns | 0.0535 ns | 0.0500 ns |  7.809 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.275 ns | 0.0704 ns | 0.0658 ns | 13.260 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.425 ns | 0.0156 ns | 0.0122 ns | 12.429 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.924 ns | 0.0260 ns | 0.0217 ns | 17.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.208 ns | 0.0116 ns | 0.0109 ns | 15.206 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.061 ns | 0.2157 ns | 0.2018 ns | 16.039 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.169 ns | 0.0952 ns | 0.0890 ns | 21.116 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.686 ns | 0.0761 ns | 0.0635 ns | 20.667 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.735 ns | 0.0557 ns | 0.0494 ns | 11.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.063 ns | 0.0253 ns | 0.0237 ns | 10.053 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.346 ns | 0.0569 ns | 0.0532 ns |  7.317 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.997 ns | 0.0848 ns | 0.0793 ns | 11.939 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.436 ns | 0.0161 ns | 0.0142 ns | 10.442 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.196 ns | 0.0269 ns | 0.0252 ns | 14.198 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.487 ns | 0.0108 ns | 0.0096 ns | 12.487 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.139 ns | 0.3513 ns | 0.4689 ns | 11.927 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.541 ns | 0.0337 ns | 0.0315 ns | 13.543 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.310 ns | 0.0169 ns | 0.0149 ns | 15.313 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.644 ns | 0.0154 ns | 0.0129 ns | 11.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.015 ns | 0.0114 ns | 0.0107 ns | 10.019 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.714 ns | 0.1544 ns | 0.1445 ns |  6.602 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.814 ns | 0.0430 ns | 0.0402 ns | 11.816 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.410 ns | 0.0224 ns | 0.0199 ns | 10.407 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.644 ns | 0.0110 ns | 0.0098 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.072 ns | 0.0126 ns | 0.0099 ns | 10.071 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.747 ns | 0.0114 ns | 0.0107 ns |  6.750 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.647 ns | 0.0178 ns | 0.0166 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.414 ns | 0.0601 ns | 0.0563 ns | 10.434 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.646 ns | 0.0169 ns | 0.0150 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.169 ns | 0.0133 ns | 0.0124 ns | 10.167 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  8.264 ns | 0.1919 ns | 0.5219 ns |  8.439 ns |  0.63 |    0.07 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.330 ns | 0.0169 ns | 0.0150 ns | 12.330 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.727 ns | 0.0180 ns | 0.0150 ns | 11.724 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.292 ns | 0.0459 ns | 0.0429 ns | 14.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.862 ns | 0.0292 ns | 0.0273 ns | 12.871 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.447 ns | 0.2291 ns | 0.2143 ns | 13.297 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.558 ns | 0.0243 ns | 0.0228 ns | 13.556 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.333 ns | 0.0186 ns | 0.0165 ns | 15.329 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.025 ns | 0.0156 ns | 0.0146 ns | 12.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.949 ns | 0.0084 ns | 0.0070 ns | 10.946 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.872 ns | 0.0205 ns | 0.0181 ns |  7.875 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.135 ns | 0.0332 ns | 0.0311 ns | 14.127 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.589 ns | 0.0108 ns | 0.0085 ns | 12.591 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.752 ns | 0.0448 ns | 0.0419 ns | 12.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.510 ns | 0.0167 ns | 0.0148 ns | 11.510 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.125 ns | 0.1138 ns | 0.1064 ns |  8.057 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.487 ns | 0.0143 ns | 0.0133 ns | 13.487 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.683 ns | 0.0122 ns | 0.0114 ns | 12.681 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.748 ns | 0.0470 ns | 0.0439 ns | 12.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.481 ns | 0.0140 ns | 0.0117 ns | 11.484 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.917 ns | 0.0141 ns | 0.0132 ns |  7.919 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.533 ns | 0.0895 ns | 0.0837 ns | 13.589 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.736 ns | 0.0764 ns | 0.0715 ns | 12.697 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.473 ns | 0.0293 ns | 0.0274 ns | 14.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.356 ns | 0.0186 ns | 0.0165 ns | 12.353 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.000 ns | 0.0325 ns | 0.0288 ns | 12.987 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 15.892 ns | 0.0176 ns | 0.0164 ns | 15.893 ns |  1.10 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.293 ns | 0.0203 ns | 0.0169 ns | 15.295 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 19.297 ns | 0.0179 ns | 0.0168 ns | 19.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 16.377 ns | 0.0296 ns | 0.0262 ns | 16.371 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.478 ns | 0.0652 ns | 0.0610 ns | 11.506 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.121 ns | 0.0243 ns | 0.0227 ns | 21.119 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 19.132 ns | 0.0282 ns | 0.0250 ns | 19.135 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 21.487 ns | 0.0782 ns | 0.0731 ns | 21.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 19.904 ns | 0.0542 ns | 0.0507 ns | 19.914 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 18.031 ns | 0.0365 ns | 0.0324 ns | 18.027 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 24.397 ns | 0.0834 ns | 0.0739 ns | 24.377 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 24.657 ns | 0.0291 ns | 0.0258 ns | 24.651 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 20.770 ns | 0.0646 ns | 0.0573 ns | 20.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.335 ns | 0.0241 ns | 0.0225 ns | 20.333 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.923 ns | 0.3550 ns | 0.3320 ns | 19.702 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 22.711 ns | 0.0307 ns | 0.0287 ns | 22.703 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 21.767 ns | 0.0709 ns | 0.0663 ns | 21.785 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.257 ns | 0.0462 ns | 0.0432 ns | 22.238 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.816 ns | 0.0570 ns | 0.0505 ns | 19.834 ns |  0.89 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.452 ns | 0.3930 ns | 0.6118 ns | 18.055 ns |  0.85 |    0.03 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 25.611 ns | 0.0380 ns | 0.0337 ns | 25.617 ns |  1.15 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 24.277 ns | 0.0307 ns | 0.0272 ns | 24.280 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.063 ns | 0.0288 ns | 0.0270 ns | 13.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.964 ns | 0.0511 ns | 0.0453 ns | 11.967 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  7.980 ns | 0.0133 ns | 0.0118 ns |  7.982 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.460 ns | 0.0298 ns | 0.0279 ns | 15.453 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.704 ns | 0.0173 ns | 0.0153 ns | 14.707 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.202 ns | 0.0356 ns | 0.0333 ns | 14.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.028 ns | 0.0114 ns | 0.0107 ns | 12.025 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.531 ns | 0.2025 ns | 0.1895 ns | 12.680 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.620 ns | 0.0304 ns | 0.0269 ns | 13.624 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.990 ns | 0.0785 ns | 0.0734 ns | 16.012 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.734 ns | 0.0132 ns | 0.0117 ns | 11.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.118 ns | 0.0204 ns | 0.0191 ns | 10.120 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  6.951 ns | 0.0468 ns | 0.0437 ns |  6.974 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 10.348 ns | 0.0107 ns | 0.0095 ns | 10.351 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.755 ns | 0.0131 ns | 0.0116 ns | 10.753 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 14.928 ns | 0.0184 ns | 0.0172 ns | 14.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 14.343 ns | 0.0148 ns | 0.0138 ns | 14.341 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 12.702 ns | 0.0916 ns | 0.0857 ns | 12.737 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 16.575 ns | 0.0301 ns | 0.0282 ns | 16.566 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 16.136 ns | 0.1210 ns | 0.1073 ns | 16.133 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.959 ns | 0.0389 ns | 0.0364 ns | 12.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.578 ns | 0.0113 ns | 0.0100 ns | 11.577 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.127 ns | 0.0354 ns | 0.0331 ns |  8.141 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.254 ns | 0.0402 ns | 0.0376 ns | 13.262 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.235 ns | 0.0154 ns | 0.0144 ns | 13.239 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.697 ns | 0.0480 ns | 0.0449 ns | 14.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.567 ns | 0.0428 ns | 0.0379 ns | 12.556 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.514 ns | 0.0149 ns | 0.0139 ns | 12.511 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 14.205 ns | 0.0371 ns | 0.0347 ns | 14.205 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 16.025 ns | 0.0235 ns | 0.0208 ns | 16.026 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.798 ns | 0.0203 ns | 0.0190 ns | 12.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.545 ns | 0.0148 ns | 0.0139 ns | 11.543 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.093 ns | 0.0128 ns | 0.0120 ns |  8.092 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.854 ns | 0.0218 ns | 0.0194 ns | 12.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.523 ns | 0.0257 ns | 0.0227 ns | 13.522 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.145 ns | 0.0111 ns | 0.0098 ns | 14.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.472 ns | 0.0128 ns | 0.0113 ns | 12.476 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.861 ns | 0.0707 ns | 0.0661 ns | 13.818 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.524 ns | 0.0191 ns | 0.0169 ns | 13.520 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.106 ns | 0.0160 ns | 0.0150 ns | 16.104 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.783 ns | 0.0578 ns | 0.0513 ns | 11.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.511 ns | 0.0160 ns | 0.0142 ns | 10.509 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.680 ns | 0.0163 ns | 0.0152 ns |  6.677 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.448 ns | 0.0103 ns | 0.0092 ns | 12.446 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.362 ns | 0.0101 ns | 0.0090 ns | 10.361 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.241 ns | 0.0822 ns | 0.0769 ns | 18.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.082 ns | 0.0161 ns | 0.0151 ns | 15.082 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.020 ns | 0.0304 ns | 0.0269 ns | 15.022 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.328 ns | 0.0260 ns | 0.0244 ns | 19.325 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.851 ns | 0.0251 ns | 0.0235 ns | 20.847 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.910 ns | 0.0237 ns | 0.0221 ns | 11.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.223 ns | 0.0121 ns | 0.0101 ns | 10.218 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.519 ns | 0.0054 ns | 0.0048 ns |  7.519 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.256 ns | 0.0680 ns | 0.0636 ns | 13.258 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.757 ns | 0.0115 ns | 0.0107 ns | 10.756 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.967 ns | 0.0537 ns | 0.0476 ns | 17.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.994 ns | 0.0222 ns | 0.0208 ns | 14.995 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.257 ns | 0.3108 ns | 0.2907 ns | 15.093 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.333 ns | 0.0460 ns | 0.0431 ns | 21.341 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.956 ns | 0.1093 ns | 0.1023 ns | 21.025 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.726 ns | 0.0132 ns | 0.0117 ns | 11.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.058 ns | 0.0129 ns | 0.0120 ns | 10.055 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  8.995 ns | 0.2056 ns | 0.5417 ns |  9.124 ns |  0.69 |    0.08 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.506 ns | 0.0125 ns | 0.0111 ns | 12.507 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.398 ns | 0.0103 ns | 0.0097 ns | 10.398 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.103 ns | 0.0140 ns | 0.0117 ns | 14.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.023 ns | 0.0131 ns | 0.0116 ns | 12.023 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.118 ns | 0.0187 ns | 0.0175 ns | 12.112 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.506 ns | 0.0214 ns | 0.0190 ns | 13.507 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.876 ns | 0.0351 ns | 0.0293 ns | 15.876 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.724 ns | 0.0426 ns | 0.0378 ns | 11.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.069 ns | 0.0417 ns | 0.0390 ns | 10.066 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.701 ns | 0.0237 ns | 0.0211 ns |  6.705 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 11.874 ns | 0.0815 ns | 0.0763 ns | 11.902 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.478 ns | 0.0047 ns | 0.0042 ns | 10.477 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.290 ns | 0.0306 ns | 0.0271 ns | 18.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.892 ns | 0.0162 ns | 0.0152 ns | 15.894 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.005 ns | 0.0702 ns | 0.0657 ns | 15.027 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.082 ns | 0.0177 ns | 0.0165 ns | 19.085 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.821 ns | 0.0266 ns | 0.0249 ns | 20.820 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.292 ns | 0.0115 ns | 0.0107 ns | 13.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.229 ns | 0.0203 ns | 0.0170 ns | 10.225 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.227 ns | 0.6205 ns | 0.8283 ns |  7.761 ns |  0.64 |    0.07 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.289 ns | 0.0189 ns | 0.0158 ns | 12.292 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.702 ns | 0.0511 ns | 0.0478 ns | 10.718 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.328 ns | 0.0393 ns | 0.0348 ns | 18.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.467 ns | 0.0147 ns | 0.0138 ns | 15.466 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.539 ns | 0.0530 ns | 0.0470 ns | 15.546 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.934 ns | 0.0384 ns | 0.0359 ns | 18.926 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 20.606 ns | 0.0198 ns | 0.0176 ns | 20.604 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.209 ns | 0.0130 ns | 0.0121 ns | 13.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.054 ns | 0.0122 ns | 0.0108 ns | 10.049 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.044 ns | 0.0114 ns | 0.0101 ns |  7.045 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.951 ns | 0.0146 ns | 0.0129 ns | 11.949 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.422 ns | 0.0119 ns | 0.0111 ns | 10.419 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.109 ns | 0.0138 ns | 0.0122 ns | 14.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.020 ns | 0.0279 ns | 0.0261 ns | 12.012 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.378 ns | 0.2566 ns | 0.2401 ns | 12.523 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.735 ns | 0.0226 ns | 0.0211 ns | 13.735 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.322 ns | 0.0221 ns | 0.0207 ns | 15.320 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.666 ns | 0.0069 ns | 0.0058 ns | 11.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.025 ns | 0.0090 ns | 0.0085 ns | 10.026 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.913 ns | 0.0178 ns | 0.0158 ns |  6.910 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.743 ns | 0.0197 ns | 0.0175 ns | 11.742 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.757 ns | 0.0112 ns | 0.0094 ns | 11.758 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.320 ns | 0.0721 ns | 0.0639 ns | 18.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.108 ns | 0.0661 ns | 0.0619 ns | 16.110 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.370 ns | 0.0450 ns | 0.0421 ns | 15.366 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.171 ns | 0.0206 ns | 0.0183 ns | 19.171 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 21.289 ns | 0.0946 ns | 0.0884 ns | 21.342 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.182 ns | 0.0164 ns | 0.0154 ns | 14.183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.165 ns | 0.1073 ns | 0.0951 ns | 12.162 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.264 ns | 0.0493 ns | 0.0461 ns |  8.287 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.470 ns | 0.0152 ns | 0.0134 ns | 14.469 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.487 ns | 0.0211 ns | 0.0197 ns | 14.483 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.344 ns | 0.0376 ns | 0.0333 ns | 18.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.677 ns | 0.0237 ns | 0.0210 ns | 15.670 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.594 ns | 0.1243 ns | 0.1102 ns | 15.625 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.304 ns | 0.1584 ns | 0.1482 ns | 19.371 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.848 ns | 0.0195 ns | 0.0163 ns | 20.848 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.294 ns | 0.0101 ns | 0.0089 ns | 14.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.653 ns | 0.0225 ns | 0.0210 ns | 11.648 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.026 ns | 0.0103 ns | 0.0091 ns |  8.026 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.311 ns | 0.0733 ns | 0.0686 ns | 14.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.176 ns | 0.0831 ns | 0.0777 ns | 13.195 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.135 ns | 0.0238 ns | 0.0211 ns | 14.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.110 ns | 0.0758 ns | 0.0709 ns | 12.144 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.283 ns | 0.2623 ns | 0.3221 ns | 12.057 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.897 ns | 0.0200 ns | 0.0167 ns | 15.889 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.275 ns | 0.0143 ns | 0.0127 ns | 15.273 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.698 ns | 0.0182 ns | 0.0170 ns | 11.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.045 ns | 0.0098 ns | 0.0082 ns | 10.048 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.079 ns | 0.0149 ns | 0.0139 ns |  7.080 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.739 ns | 0.0112 ns | 0.0093 ns | 11.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.400 ns | 0.0156 ns | 0.0146 ns | 10.400 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.103 ns | 0.0598 ns | 0.0560 ns | 18.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.009 ns | 0.0184 ns | 0.0163 ns | 15.006 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.408 ns | 0.0778 ns | 0.0728 ns | 15.456 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.939 ns | 0.0309 ns | 0.0289 ns | 18.933 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.613 ns | 0.0183 ns | 0.0152 ns | 20.608 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.898 ns | 0.0078 ns | 0.0065 ns | 11.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 12.951 ns | 0.0199 ns | 0.0186 ns | 12.949 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.885 ns | 0.1769 ns | 0.1817 ns |  7.756 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.941 ns | 0.1862 ns | 0.1742 ns | 13.948 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.544 ns | 0.0915 ns | 0.0856 ns | 12.575 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.678 ns | 0.0239 ns | 0.0223 ns | 20.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.221 ns | 0.0172 ns | 0.0161 ns | 15.222 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.983 ns | 0.0490 ns | 0.0458 ns | 14.992 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.052 ns | 0.0622 ns | 0.0582 ns | 19.056 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.616 ns | 0.0298 ns | 0.0265 ns | 20.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.690 ns | 0.0115 ns | 0.0107 ns | 11.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.083 ns | 0.0546 ns | 0.0511 ns | 10.055 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.306 ns | 0.0066 ns | 0.0059 ns |  7.306 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.967 ns | 0.0160 ns | 0.0142 ns | 11.967 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.414 ns | 0.0117 ns | 0.0104 ns | 10.412 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.134 ns | 0.0078 ns | 0.0073 ns | 14.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.830 ns | 0.0124 ns | 0.0104 ns | 13.831 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.040 ns | 0.4582 ns | 0.6116 ns | 12.705 ns |  0.94 |    0.05 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.512 ns | 0.0217 ns | 0.0192 ns | 13.508 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 15.898 ns | 0.0223 ns | 0.0209 ns | 15.900 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.284 ns | 0.0207 ns | 0.0194 ns | 12.281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.088 ns | 0.0133 ns | 0.0125 ns | 10.090 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.033 ns | 0.0620 ns | 0.0580 ns |  7.066 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 12.480 ns | 0.0127 ns | 0.0119 ns | 12.482 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 10.800 ns | 0.0101 ns | 0.0089 ns | 10.800 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 18.217 ns | 0.0268 ns | 0.0237 ns | 18.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 15.454 ns | 0.0331 ns | 0.0309 ns | 15.453 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 15.543 ns | 0.0252 ns | 0.0236 ns | 15.543 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.189 ns | 0.1048 ns | 0.0980 ns | 21.177 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 20.594 ns | 0.0249 ns | 0.0221 ns | 20.592 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.866 ns | 0.0084 ns | 0.0079 ns | 11.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.213 ns | 0.0108 ns | 0.0101 ns | 10.216 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  7.749 ns | 0.0106 ns | 0.0089 ns |  7.748 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.028 ns | 0.0158 ns | 0.0140 ns | 13.025 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 10.644 ns | 0.0342 ns | 0.0320 ns | 10.631 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.995 ns | 0.0204 ns | 0.0181 ns | 17.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.984 ns | 0.0203 ns | 0.0190 ns | 14.985 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.535 ns | 0.0251 ns | 0.0223 ns | 15.532 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 19.061 ns | 0.0311 ns | 0.0291 ns | 19.067 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 20.582 ns | 0.0170 ns | 0.0151 ns | 20.581 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.686 ns | 0.0190 ns | 0.0178 ns | 12.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.055 ns | 0.0110 ns | 0.0086 ns | 10.057 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.315 ns | 0.0154 ns | 0.0144 ns |  7.320 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.991 ns | 0.0142 ns | 0.0126 ns | 11.990 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.071 ns | 0.0419 ns | 0.0371 ns | 12.083 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.208 ns | 0.0424 ns | 0.0354 ns | 14.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.045 ns | 0.0197 ns | 0.0184 ns | 12.041 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.946 ns | 0.2829 ns | 0.3258 ns | 14.048 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.822 ns | 0.0850 ns | 0.0795 ns | 13.773 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.294 ns | 0.0207 ns | 0.0193 ns | 15.296 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 71.119 ns | 0.2670 ns | 0.2497 ns | 71.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 72.110 ns | 0.1157 ns | 0.1026 ns | 72.130 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 54.802 ns | 0.0642 ns | 0.0569 ns | 54.819 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 73.415 ns | 0.2977 ns | 0.2785 ns | 73.501 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 74.300 ns | 0.1519 ns | 0.1269 ns | 74.280 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 75.807 ns | 0.0988 ns | 0.0825 ns | 75.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 80.214 ns | 0.0709 ns | 0.0628 ns | 80.209 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 60.927 ns | 0.1078 ns | 0.0956 ns | 60.922 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 78.464 ns | 0.0903 ns | 0.0800 ns | 78.460 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 81.248 ns | 0.1590 ns | 0.1410 ns | 81.213 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.515 ns | 0.0145 ns | 0.0129 ns | 13.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.451 ns | 0.0530 ns | 0.0496 ns | 12.467 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.640 ns | 0.2942 ns | 0.6076 ns | 13.835 ns |  0.97 |    0.08 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.743 ns | 0.0093 ns | 0.0078 ns | 12.746 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.061 ns | 0.0163 ns | 0.0153 ns | 15.060 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.259 ns | 0.0135 ns | 0.0120 ns | 14.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.020 ns | 0.0094 ns | 0.0088 ns | 12.021 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.765 ns | 0.0127 ns | 0.0113 ns | 12.765 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.935 ns | 0.0245 ns | 0.0217 ns | 15.937 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.115 ns | 0.0486 ns | 0.0454 ns | 16.134 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.861 ns | 0.0265 ns | 0.0248 ns | 12.866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.538 ns | 0.0139 ns | 0.0123 ns | 11.534 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.126 ns | 0.0982 ns | 0.0918 ns | 11.189 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.925 ns | 0.0237 ns | 0.0222 ns | 12.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.577 ns | 0.0201 ns | 0.0188 ns | 16.575 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.944 ns | 0.0078 ns | 0.0073 ns | 13.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.045 ns | 0.0126 ns | 0.0112 ns | 10.045 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.083 ns | 0.0673 ns | 0.0597 ns |  7.103 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.475 ns | 0.0118 ns | 0.0105 ns | 12.474 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.755 ns | 0.0116 ns | 0.0103 ns | 11.757 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.779 ns | 0.0236 ns | 0.0184 ns | 18.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.343 ns | 0.1033 ns | 0.0966 ns | 15.383 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.444 ns | 0.1683 ns | 0.1575 ns | 15.488 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.932 ns | 0.0236 ns | 0.0221 ns | 18.937 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.596 ns | 0.0231 ns | 0.0216 ns | 20.593 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.663 ns | 0.0154 ns | 0.0129 ns | 12.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.230 ns | 0.0115 ns | 0.0102 ns | 10.227 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.832 ns | 0.0613 ns | 0.0573 ns |  7.869 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.210 ns | 0.0800 ns | 0.0749 ns | 13.176 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.773 ns | 0.0124 ns | 0.0110 ns | 10.770 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.721 ns | 0.0236 ns | 0.0221 ns | 18.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.167 ns | 0.0301 ns | 0.0281 ns | 16.166 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.571 ns | 0.0973 ns | 0.0910 ns | 17.586 ns |  0.94 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.073 ns | 0.0340 ns | 0.0301 ns | 19.068 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 21.245 ns | 0.0606 ns | 0.0567 ns | 21.235 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.721 ns | 0.0143 ns | 0.0134 ns | 11.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.321 ns | 0.0386 ns | 0.0342 ns | 11.322 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.035 ns | 0.0080 ns | 0.0067 ns |  7.037 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.349 ns | 0.0547 ns | 0.0485 ns | 13.369 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.434 ns | 0.0127 ns | 0.0119 ns | 10.435 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.125 ns | 0.0136 ns | 0.0121 ns | 14.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.456 ns | 0.0142 ns | 0.0111 ns | 12.453 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.124 ns | 0.0104 ns | 0.0092 ns | 12.123 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.638 ns | 0.0121 ns | 0.0101 ns | 13.636 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.292 ns | 0.0253 ns | 0.0225 ns | 15.292 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.910 ns | 0.0620 ns | 0.0580 ns | 11.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.017 ns | 0.0113 ns | 0.0095 ns | 10.016 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.721 ns | 0.0194 ns | 0.0182 ns |  6.722 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.780 ns | 0.0147 ns | 0.0138 ns | 11.779 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.768 ns | 0.0090 ns | 0.0075 ns | 11.769 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.386 ns | 0.0240 ns | 0.0225 ns | 18.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 14.973 ns | 0.0199 ns | 0.0176 ns | 14.975 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.320 ns | 0.0370 ns | 0.0346 ns | 15.321 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.151 ns | 0.0147 ns | 0.0131 ns | 19.151 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.847 ns | 0.0200 ns | 0.0188 ns | 20.847 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 14.387 ns | 0.0196 ns | 0.0173 ns | 14.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.050 ns | 0.0120 ns | 0.0106 ns | 11.048 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.748 ns | 0.0097 ns | 0.0090 ns |  7.749 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.455 ns | 0.0257 ns | 0.0241 ns | 12.451 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.785 ns | 0.0161 ns | 0.0143 ns | 10.784 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.948 ns | 0.0324 ns | 0.0303 ns | 17.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.352 ns | 0.0218 ns | 0.0204 ns | 15.351 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.255 ns | 0.0748 ns | 0.0624 ns | 15.263 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.275 ns | 0.0752 ns | 0.0703 ns | 19.308 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.869 ns | 0.0216 ns | 0.0192 ns | 20.868 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.705 ns | 0.0177 ns | 0.0165 ns | 11.710 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.060 ns | 0.0101 ns | 0.0084 ns | 10.061 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.303 ns | 0.0121 ns | 0.0094 ns |  7.303 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.645 ns | 0.0126 ns | 0.0112 ns | 12.646 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.977 ns | 0.0095 ns | 0.0089 ns | 11.977 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.963 ns | 0.0148 ns | 0.0123 ns | 13.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.630 ns | 0.0133 ns | 0.0125 ns | 13.627 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.041 ns | 0.0181 ns | 0.0160 ns | 12.044 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.608 ns | 0.0157 ns | 0.0147 ns | 13.611 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.552 ns | 0.0567 ns | 0.0530 ns | 15.573 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.226 ns | 0.0290 ns | 0.0257 ns | 13.222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.237 ns | 0.0119 ns | 0.0105 ns | 10.237 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.052 ns | 0.0148 ns | 0.0138 ns |  7.057 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 11.907 ns | 0.0187 ns | 0.0157 ns | 11.905 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.415 ns | 0.0175 ns | 0.0155 ns | 10.417 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.861 ns | 0.0161 ns | 0.0142 ns | 18.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.476 ns | 0.0385 ns | 0.0361 ns | 15.466 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.647 ns | 0.0218 ns | 0.0193 ns | 15.644 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.396 ns | 0.0356 ns | 0.0333 ns | 19.382 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.117 ns | 0.0595 ns | 0.0557 ns | 21.116 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.266 ns | 0.0180 ns | 0.0168 ns | 14.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.833 ns | 0.0470 ns | 0.0440 ns | 11.814 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.617 ns | 0.0594 ns | 0.0496 ns |  8.640 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.298 ns | 0.0164 ns | 0.0154 ns | 14.300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.345 ns | 0.0157 ns | 0.0147 ns | 13.344 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.392 ns | 0.0304 ns | 0.0284 ns | 18.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.475 ns | 0.0400 ns | 0.0354 ns | 15.476 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.262 ns | 0.0168 ns | 0.0157 ns | 15.269 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.369 ns | 0.0260 ns | 0.0244 ns | 19.359 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.337 ns | 0.0346 ns | 0.0306 ns | 21.337 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.943 ns | 0.0122 ns | 0.0108 ns | 12.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.616 ns | 0.0086 ns | 0.0071 ns | 11.615 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.707 ns | 0.1964 ns | 0.2554 ns |  8.795 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.283 ns | 0.0198 ns | 0.0185 ns | 14.285 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.625 ns | 0.0202 ns | 0.0169 ns | 13.628 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.130 ns | 0.0117 ns | 0.0097 ns | 14.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.802 ns | 0.0086 ns | 0.0076 ns | 13.802 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.405 ns | 0.0129 ns | 0.0115 ns | 11.403 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.535 ns | 0.0253 ns | 0.0236 ns | 13.529 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.416 ns | 0.1006 ns | 0.0941 ns | 15.456 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.276 ns | 0.0140 ns | 0.0131 ns | 14.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.622 ns | 0.0125 ns | 0.0116 ns | 13.619 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.135 ns | 0.0219 ns | 0.0204 ns | 12.132 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.518 ns | 0.0134 ns | 0.0112 ns | 13.519 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.318 ns | 0.0174 ns | 0.0163 ns | 15.322 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.418 ns | 0.0106 ns | 0.0099 ns | 11.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.827 ns | 0.0113 ns | 0.0105 ns |  9.826 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.996 ns | 0.2383 ns | 0.2447 ns | 11.188 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.074 ns | 0.0249 ns | 0.0233 ns | 11.081 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.739 ns | 0.0152 ns | 0.0127 ns | 12.741 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.111 ns | 0.0270 ns | 0.0225 ns | 14.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.028 ns | 0.0236 ns | 0.0209 ns | 12.018 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.596 ns | 0.2735 ns | 0.2558 ns | 12.710 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.691 ns | 0.0225 ns | 0.0211 ns | 13.692 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.004 ns | 0.0245 ns | 0.0217 ns | 15.998 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.434 ns | 0.0220 ns | 0.0206 ns | 15.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.656 ns | 0.0595 ns | 0.0556 ns | 13.655 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.156 ns | 0.3172 ns | 0.3653 ns | 15.108 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.829 ns | 0.0313 ns | 0.0292 ns | 16.834 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.198 ns | 0.0188 ns | 0.0176 ns | 18.202 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.351 ns | 0.0169 ns | 0.0141 ns | 18.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.385 ns | 0.0158 ns | 0.0132 ns | 14.380 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.757 ns | 0.0254 ns | 0.0199 ns | 14.763 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 17.273 ns | 0.0333 ns | 0.0312 ns | 17.283 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.976 ns | 0.0135 ns | 0.0120 ns | 18.977 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.158 ns | 0.0457 ns | 0.0405 ns | 14.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.963 ns | 0.0125 ns | 0.0104 ns | 12.963 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.534 ns | 0.1904 ns | 0.1781 ns | 12.521 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.918 ns | 0.0260 ns | 0.0243 ns | 13.921 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.889 ns | 0.0610 ns | 0.0541 ns | 14.903 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.145 ns | 0.0320 ns | 0.0284 ns | 14.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.743 ns | 0.0117 ns | 0.0110 ns | 12.747 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.041 ns | 0.0162 ns | 0.0135 ns | 12.044 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.894 ns | 0.0144 ns | 0.0135 ns | 15.890 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.591 ns | 0.0156 ns | 0.0146 ns | 15.588 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.686 ns | 0.0302 ns | 0.0252 ns | 13.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.831 ns | 0.0117 ns | 0.0104 ns | 11.834 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.691 ns | 0.0103 ns | 0.0086 ns | 11.692 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.294 ns | 0.0125 ns | 0.0117 ns | 12.289 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 13.934 ns | 0.0114 ns | 0.0107 ns | 13.934 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.119 ns | 0.0231 ns | 0.0193 ns | 15.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.711 ns | 0.0159 ns | 0.0149 ns | 13.712 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.632 ns | 0.0409 ns | 0.0341 ns | 13.632 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.757 ns | 0.0194 ns | 0.0172 ns | 18.755 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.929 ns | 0.0349 ns | 0.0309 ns | 16.929 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.877 ns | 0.0136 ns | 0.0121 ns | 12.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.189 ns | 0.0096 ns | 0.0080 ns | 11.185 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.232 ns | 0.0312 ns | 0.0292 ns | 11.224 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.512 ns | 0.0184 ns | 0.0172 ns | 12.510 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.166 ns | 0.0184 ns | 0.0172 ns | 14.161 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.126 ns | 0.0169 ns | 0.0150 ns | 14.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.063 ns | 0.0099 ns | 0.0092 ns | 12.064 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.568 ns | 0.2051 ns | 0.1919 ns | 12.688 ns |  0.89 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.567 ns | 0.0508 ns | 0.0475 ns | 13.557 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.522 ns | 0.0268 ns | 0.0250 ns | 15.519 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.172 ns | 0.0360 ns | 0.0337 ns | 19.162 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.199 ns | 0.0724 ns | 0.0642 ns | 16.180 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.835 ns | 0.0815 ns | 0.0762 ns | 11.818 ns |  0.62 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.415 ns | 0.0214 ns | 0.0179 ns | 19.411 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.271 ns | 0.0783 ns | 0.0732 ns | 17.239 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.381 ns | 0.0311 ns | 0.0276 ns | 17.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.167 ns | 0.0183 ns | 0.0162 ns | 16.164 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.552 ns | 0.3146 ns | 0.2943 ns | 15.368 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.658 ns | 0.0214 ns | 0.0201 ns | 17.661 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.709 ns | 0.0513 ns | 0.0428 ns | 19.695 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.823 ns | 0.0634 ns | 0.0593 ns | 20.802 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.241 ns | 0.0520 ns | 0.0461 ns | 16.252 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.792 ns | 0.0650 ns | 0.0608 ns | 12.781 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.218 ns | 0.0500 ns | 0.0443 ns | 20.213 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.518 ns | 0.3925 ns | 0.4672 ns | 18.539 ns |  0.88 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.722 ns | 0.0254 ns | 0.0238 ns | 17.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.748 ns | 0.0148 ns | 0.0138 ns | 14.745 ns |  0.83 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.381 ns | 0.2365 ns | 0.2212 ns | 15.243 ns |  0.87 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.636 ns | 0.0210 ns | 0.0196 ns | 17.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.900 ns | 0.2457 ns | 0.2298 ns | 19.890 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.410 ns | 0.0205 ns | 0.0192 ns | 13.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.717 ns | 0.0102 ns | 0.0090 ns | 11.716 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.838 ns | 0.2432 ns | 0.7057 ns | 10.031 ns |  0.65 |    0.10 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.101 ns | 0.0629 ns | 0.0589 ns | 13.117 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.506 ns | 0.0127 ns | 0.0119 ns | 10.511 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.126 ns | 0.0175 ns | 0.0155 ns | 14.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.133 ns | 0.0600 ns | 0.0531 ns | 12.152 ns |  0.86 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.007 ns | 0.0180 ns | 0.0160 ns | 14.011 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.564 ns | 0.0282 ns | 0.0264 ns | 13.559 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.301 ns | 0.0288 ns | 0.0225 ns | 15.306 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.104 ns | 0.0108 ns | 0.0095 ns | 13.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.079 ns | 0.0094 ns | 0.0084 ns | 10.079 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.200 ns | 0.3707 ns | 0.6294 ns |  6.844 ns |  0.59 |    0.06 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.802 ns | 0.0222 ns | 0.0208 ns | 11.799 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.701 ns | 0.0157 ns | 0.0147 ns | 11.704 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.142 ns | 0.0429 ns | 0.0401 ns | 15.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.391 ns | 0.0175 ns | 0.0146 ns | 13.392 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.292 ns | 0.0847 ns | 0.0792 ns | 14.344 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.200 ns | 0.0334 ns | 0.0312 ns | 15.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.359 ns | 0.0181 ns | 0.0169 ns | 17.358 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.125 ns | 0.0136 ns | 0.0121 ns | 13.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.083 ns | 0.0157 ns | 0.0147 ns | 10.079 ns |  0.77 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.563 ns | 0.1622 ns | 0.1438 ns |  7.601 ns |  0.58 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.458 ns | 0.0141 ns | 0.0125 ns | 12.455 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.841 ns | 0.0224 ns | 0.0198 ns | 11.846 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.140 ns | 0.0287 ns | 0.0240 ns | 15.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.366 ns | 0.0101 ns | 0.0095 ns | 13.366 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.024 ns | 0.2661 ns | 0.2490 ns | 14.166 ns |  0.93 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.126 ns | 0.0275 ns | 0.0257 ns | 15.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.871 ns | 0.0275 ns | 0.0243 ns | 16.877 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.831 ns | 0.0438 ns | 0.0388 ns | 13.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.082 ns | 0.0114 ns | 0.0107 ns | 10.083 ns |  0.73 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.849 ns | 0.0231 ns | 0.0216 ns |  6.840 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.801 ns | 0.0097 ns | 0.0086 ns | 11.801 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.342 ns | 0.1021 ns | 0.0955 ns | 10.300 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.144 ns | 0.0085 ns | 0.0076 ns | 14.145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.013 ns | 0.0108 ns | 0.0090 ns | 12.011 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.325 ns | 0.2665 ns | 0.2851 ns | 12.164 ns |  0.88 |    0.02 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.526 ns | 0.0310 ns | 0.0275 ns | 13.528 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.917 ns | 0.0249 ns | 0.0233 ns | 15.920 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.147 ns | 0.0109 ns | 0.0102 ns | 13.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.452 ns | 0.0460 ns | 0.0430 ns | 10.469 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.947 ns | 0.0193 ns | 0.0181 ns |  6.951 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 11.977 ns | 0.0294 ns | 0.0275 ns | 11.976 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.385 ns | 0.0114 ns | 0.0101 ns | 10.384 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 51.091 ns | 0.0798 ns | 0.0707 ns | 51.108 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 38.968 ns | 0.0621 ns | 0.0550 ns | 38.972 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 33.765 ns | 0.1881 ns | 0.1668 ns | 33.801 ns |  0.66 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.616 ns | 0.0994 ns | 0.0881 ns | 42.599 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 45.259 ns | 0.0538 ns | 0.0420 ns | 45.251 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.234 ns | 0.0134 ns | 0.0119 ns | 13.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.349 ns | 0.0158 ns | 0.0147 ns | 12.350 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.434 ns | 0.0164 ns | 0.0145 ns |  7.434 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.979 ns | 0.0443 ns | 0.0415 ns | 12.990 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.579 ns | 0.0183 ns | 0.0162 ns | 10.578 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.515 ns | 0.0636 ns | 0.0564 ns | 44.506 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 41.210 ns | 0.0835 ns | 0.0740 ns | 41.222 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.377 ns | 0.0622 ns | 0.0519 ns | 39.379 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.085 ns | 0.0406 ns | 0.0360 ns | 43.100 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.705 ns | 0.0471 ns | 0.0441 ns | 44.702 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.138 ns | 0.0142 ns | 0.0126 ns | 13.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.507 ns | 0.0091 ns | 0.0085 ns | 10.508 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.592 ns | 0.0087 ns | 0.0077 ns |  6.594 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.469 ns | 0.0190 ns | 0.0177 ns | 12.467 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.391 ns | 0.0066 ns | 0.0055 ns | 10.391 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.104 ns | 0.0147 ns | 0.0123 ns | 14.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.702 ns | 0.0565 ns | 0.0529 ns | 13.720 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.236 ns | 0.0123 ns | 0.0116 ns | 12.232 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.575 ns | 0.0413 ns | 0.0366 ns | 13.567 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.937 ns | 0.0163 ns | 0.0153 ns | 15.938 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.704 ns | 0.0156 ns | 0.0146 ns | 12.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.146 ns | 0.0113 ns | 0.0101 ns | 11.146 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.736 ns | 0.0497 ns | 0.0465 ns | 11.712 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.376 ns | 0.0355 ns | 0.0315 ns | 12.374 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.965 ns | 0.0198 ns | 0.0186 ns | 13.965 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.571 ns | 0.0218 ns | 0.0194 ns | 15.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.412 ns | 0.0249 ns | 0.0208 ns | 14.410 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.095 ns | 0.1727 ns | 0.1615 ns | 14.094 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.468 ns | 0.0552 ns | 0.0489 ns | 15.467 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.988 ns | 0.0300 ns | 0.0281 ns | 16.983 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.712 ns | 0.0118 ns | 0.0105 ns | 12.710 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.139 ns | 0.0125 ns | 0.0111 ns | 11.134 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.739 ns | 0.0460 ns | 0.0431 ns | 11.720 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.441 ns | 0.0296 ns | 0.0277 ns | 12.444 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.528 ns | 0.0278 ns | 0.0247 ns | 12.527 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.171 ns | 0.0799 ns | 0.0747 ns | 14.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.019 ns | 0.0109 ns | 0.0096 ns | 12.017 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.144 ns | 0.0183 ns | 0.0143 ns | 12.144 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.559 ns | 0.0215 ns | 0.0201 ns | 13.565 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 15.507 ns | 0.0346 ns | 0.0323 ns | 15.509 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.436 ns | 0.1011 ns | 0.0844 ns | 39.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.104 ns | 0.1257 ns | 0.1049 ns | 38.136 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.291 ns | 0.1274 ns | 0.1064 ns | 35.265 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.909 ns | 0.0448 ns | 0.0419 ns | 39.905 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 43.280 ns | 0.0576 ns | 0.0539 ns | 43.252 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.954 ns | 0.0340 ns | 0.0318 ns | 15.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.616 ns | 0.0151 ns | 0.0126 ns | 13.620 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 14.741 ns | 0.0212 ns | 0.0199 ns | 14.733 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.442 ns | 0.0339 ns | 0.0317 ns | 15.458 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 16.953 ns | 0.0175 ns | 0.0163 ns | 16.955 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 38.867 ns | 0.0438 ns | 0.0409 ns | 38.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.865 ns | 0.0853 ns | 0.0798 ns | 37.846 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.396 ns | 0.0820 ns | 0.0640 ns | 35.378 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 42.440 ns | 0.0547 ns | 0.0511 ns | 42.427 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.729 ns | 0.1497 ns | 0.1400 ns | 41.695 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.631 ns | 0.0937 ns | 0.0876 ns | 15.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.609 ns | 0.0126 ns | 0.0105 ns | 13.613 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.019 ns | 0.0805 ns | 0.0753 ns | 14.005 ns |  0.90 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.573 ns | 0.0181 ns | 0.0170 ns | 15.574 ns |  1.00 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.603 ns | 0.0190 ns | 0.0168 ns | 17.602 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.070 ns | 0.0216 ns | 0.0192 ns | 39.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.837 ns | 0.0373 ns | 0.0349 ns | 38.848 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.585 ns | 0.0370 ns | 0.0346 ns | 34.567 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.049 ns | 0.0554 ns | 0.0518 ns | 40.037 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.076 ns | 0.1180 ns | 0.0986 ns | 39.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.152 ns | 0.0114 ns | 0.0106 ns | 14.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.037 ns | 0.0091 ns | 0.0085 ns | 12.039 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.069 ns | 0.0133 ns | 0.0118 ns | 12.070 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.579 ns | 0.0193 ns | 0.0180 ns | 13.571 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.315 ns | 0.0279 ns | 0.0247 ns | 15.312 ns |  1.08 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Double.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Double.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Double.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Double.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Double.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Double.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Double.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Double.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Double.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
