
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
                                             From_Bool | .NET Core 2.0 | 13.298 ns | 0.0202 ns | 0.0189 ns | 13.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.223 ns | 0.0214 ns | 0.0200 ns | 12.226 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.121 ns | 0.0200 ns | 0.0177 ns |  7.119 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.520 ns | 0.0127 ns | 0.0106 ns | 10.524 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.882 ns | 0.0111 ns | 0.0098 ns | 11.881 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 16.955 ns | 0.0233 ns | 0.0218 ns | 16.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.843 ns | 0.0757 ns | 0.0671 ns | 16.825 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.066 ns | 0.1787 ns | 0.1672 ns | 16.959 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.881 ns | 0.0358 ns | 0.0299 ns | 19.886 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.247 ns | 0.0247 ns | 0.0219 ns | 18.252 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.233 ns | 0.0181 ns | 0.0161 ns | 12.230 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.797 ns | 0.0246 ns | 0.0230 ns | 10.790 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.885 ns | 0.0646 ns | 0.0572 ns |  7.859 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.992 ns | 0.0181 ns | 0.0160 ns | 10.990 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.069 ns | 0.0153 ns | 0.0143 ns | 11.074 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.925 ns | 0.0295 ns | 0.0276 ns | 16.922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.396 ns | 0.0440 ns | 0.0412 ns | 17.395 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.466 ns | 0.0413 ns | 0.0386 ns | 16.476 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 19.902 ns | 0.0363 ns | 0.0340 ns | 19.902 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.528 ns | 0.0830 ns | 0.0736 ns | 18.544 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.993 ns | 0.0702 ns | 0.0623 ns | 12.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.506 ns | 0.0139 ns | 0.0130 ns | 10.509 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.535 ns | 0.0453 ns | 0.0379 ns |  7.543 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.390 ns | 0.0197 ns | 0.0175 ns | 10.388 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.576 ns | 0.0336 ns | 0.0314 ns | 10.564 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.258 ns | 0.0152 ns | 0.0142 ns | 13.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.872 ns | 0.0455 ns | 0.0425 ns | 12.854 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.554 ns | 0.0221 ns | 0.0196 ns | 11.553 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.201 ns | 0.0274 ns | 0.0243 ns | 15.203 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.626 ns | 0.0223 ns | 0.0209 ns | 13.633 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.863 ns | 0.0255 ns | 0.0226 ns | 11.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.362 ns | 0.0161 ns | 0.0150 ns | 10.362 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.164 ns | 0.0130 ns | 0.0116 ns |  7.166 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.432 ns | 0.0193 ns | 0.0161 ns | 10.434 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.400 ns | 0.0233 ns | 0.0218 ns | 10.402 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.379 ns | 0.1000 ns | 0.0886 ns | 17.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.269 ns | 0.0404 ns | 0.0378 ns | 16.267 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.787 ns | 0.0332 ns | 0.0295 ns | 17.791 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.852 ns | 0.0398 ns | 0.0353 ns | 19.850 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.732 ns | 0.0616 ns | 0.0577 ns | 18.748 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.029 ns | 0.0178 ns | 0.0158 ns | 12.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.593 ns | 0.0186 ns | 0.0165 ns | 10.597 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.938 ns | 0.2103 ns | 0.2504 ns |  7.799 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 11.036 ns | 0.0164 ns | 0.0137 ns | 11.031 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.377 ns | 0.0149 ns | 0.0132 ns | 12.377 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.199 ns | 0.0323 ns | 0.0287 ns | 17.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.040 ns | 0.0500 ns | 0.0443 ns | 16.026 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.561 ns | 0.1017 ns | 0.0951 ns | 17.514 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.566 ns | 0.0166 ns | 0.0138 ns | 18.566 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.233 ns | 0.0248 ns | 0.0220 ns | 18.236 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.908 ns | 0.0242 ns | 0.0215 ns | 12.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.481 ns | 0.0254 ns | 0.0238 ns | 11.479 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.271 ns | 0.2311 ns | 0.2751 ns |  7.129 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.712 ns | 0.0143 ns | 0.0134 ns | 11.712 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.321 ns | 0.1144 ns | 0.1070 ns | 12.281 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.414 ns | 0.0261 ns | 0.0218 ns | 13.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.823 ns | 0.0209 ns | 0.0175 ns | 12.821 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.547 ns | 0.0216 ns | 0.0192 ns | 11.554 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.495 ns | 0.0811 ns | 0.0759 ns | 13.508 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.636 ns | 0.0459 ns | 0.0429 ns | 13.621 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.310 ns | 0.0132 ns | 0.0110 ns | 12.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.389 ns | 0.0185 ns | 0.0164 ns | 10.390 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.925 ns | 0.0791 ns | 0.0740 ns |  6.934 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.444 ns | 0.0174 ns | 0.0154 ns | 10.437 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.341 ns | 0.0215 ns | 0.0190 ns | 12.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.816 ns | 0.0163 ns | 0.0144 ns | 11.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.348 ns | 0.0122 ns | 0.0102 ns | 10.346 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.226 ns | 0.0516 ns | 0.0483 ns |  7.238 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.413 ns | 0.0508 ns | 0.0475 ns | 10.388 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.550 ns | 0.0196 ns | 0.0174 ns | 11.544 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.955 ns | 0.0516 ns | 0.0458 ns | 11.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.383 ns | 0.0222 ns | 0.0208 ns | 10.384 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.847 ns | 0.0130 ns | 0.0122 ns |  6.848 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.539 ns | 0.0534 ns | 0.0474 ns | 10.544 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.699 ns | 0.0837 ns | 0.0783 ns | 11.726 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.251 ns | 0.0174 ns | 0.0146 ns | 13.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.031 ns | 0.0186 ns | 0.0165 ns | 13.036 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.607 ns | 0.0311 ns | 0.0291 ns | 11.611 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.526 ns | 0.0144 ns | 0.0120 ns | 13.523 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.588 ns | 0.0185 ns | 0.0164 ns | 13.589 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.754 ns | 0.0880 ns | 0.0823 ns | 12.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.144 ns | 0.0273 ns | 0.0242 ns | 11.146 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.217 ns | 0.2361 ns | 0.2810 ns |  8.050 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.034 ns | 0.0124 ns | 0.0116 ns | 13.034 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.789 ns | 0.0136 ns | 0.0114 ns | 13.791 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.928 ns | 0.0468 ns | 0.0438 ns | 12.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.747 ns | 0.0159 ns | 0.0141 ns | 11.747 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  7.972 ns | 0.0214 ns | 0.0201 ns |  7.972 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.837 ns | 0.0425 ns | 0.0397 ns | 12.813 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.462 ns | 0.0260 ns | 0.0243 ns | 13.463 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.791 ns | 0.0218 ns | 0.0204 ns | 12.790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.520 ns | 0.0149 ns | 0.0139 ns | 11.524 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.909 ns | 0.1712 ns | 0.1601 ns |  8.879 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 12.951 ns | 0.1185 ns | 0.1108 ns | 13.033 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.748 ns | 0.1020 ns | 0.0955 ns | 13.793 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.855 ns | 0.0096 ns | 0.0085 ns | 13.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.032 ns | 0.0257 ns | 0.0241 ns | 13.029 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.440 ns | 0.1830 ns | 0.1622 ns | 13.502 ns |  0.97 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.602 ns | 0.0653 ns | 0.0611 ns | 13.580 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.575 ns | 0.0209 ns | 0.0185 ns | 13.573 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.031 ns | 0.0264 ns | 0.0247 ns | 23.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.252 ns | 0.0345 ns | 0.0323 ns | 20.243 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.762 ns | 0.1056 ns | 0.0882 ns | 11.737 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 22.829 ns | 0.1902 ns | 0.1779 ns | 22.739 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.634 ns | 0.0344 ns | 0.0322 ns | 22.633 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 23.956 ns | 0.0331 ns | 0.0294 ns | 23.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 23.046 ns | 0.0253 ns | 0.0225 ns | 23.046 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.938 ns | 0.1554 ns | 0.1453 ns | 20.989 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 24.941 ns | 0.1926 ns | 0.1801 ns | 25.015 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 38.353 ns | 0.2973 ns | 0.2781 ns | 38.492 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 24.436 ns | 0.0483 ns | 0.0429 ns | 24.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.081 ns | 0.0722 ns | 0.0640 ns | 23.094 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 21.314 ns | 0.4347 ns | 0.4066 ns | 21.082 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 24.320 ns | 0.0405 ns | 0.0379 ns | 24.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 24.009 ns | 0.0322 ns | 0.0301 ns | 24.005 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.564 ns | 0.0380 ns | 0.0336 ns | 23.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 22.581 ns | 0.0345 ns | 0.0305 ns | 22.580 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.670 ns | 0.1722 ns | 0.1611 ns | 21.736 ns |  0.92 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 24.916 ns | 0.0230 ns | 0.0215 ns | 24.912 ns |  1.06 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 23.947 ns | 0.0252 ns | 0.0236 ns | 23.943 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.778 ns | 0.0585 ns | 0.0488 ns | 12.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.470 ns | 0.0126 ns | 0.0105 ns | 11.470 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.112 ns | 0.1394 ns | 0.1304 ns |  8.055 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.563 ns | 0.0103 ns | 0.0091 ns | 13.562 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.086 ns | 0.1295 ns | 0.1212 ns | 15.154 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.239 ns | 0.0198 ns | 0.0186 ns | 13.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.900 ns | 0.0137 ns | 0.0121 ns | 13.900 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.871 ns | 0.2477 ns | 0.2317 ns | 12.021 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.409 ns | 0.0232 ns | 0.0194 ns | 13.410 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.769 ns | 0.0229 ns | 0.0214 ns | 13.763 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 11.858 ns | 0.0231 ns | 0.0180 ns | 11.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.389 ns | 0.0150 ns | 0.0140 ns | 10.384 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.585 ns | 0.0970 ns | 0.0908 ns |  7.519 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 10.628 ns | 0.0211 ns | 0.0176 ns | 10.628 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 10.491 ns | 0.0173 ns | 0.0154 ns | 10.494 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.562 ns | 0.1754 ns | 0.1640 ns | 19.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 16.218 ns | 0.0351 ns | 0.0311 ns | 16.215 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.031 ns | 0.3648 ns | 0.4614 ns | 17.362 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 19.867 ns | 0.0271 ns | 0.0227 ns | 19.864 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 18.426 ns | 0.0243 ns | 0.0216 ns | 18.424 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.986 ns | 0.0249 ns | 0.0233 ns | 12.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.947 ns | 0.0525 ns | 0.0491 ns | 11.955 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.890 ns | 0.2014 ns | 0.3528 ns |  9.059 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.240 ns | 0.0167 ns | 0.0157 ns | 13.242 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.350 ns | 0.0340 ns | 0.0301 ns | 13.350 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.193 ns | 0.0346 ns | 0.0289 ns | 17.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.589 ns | 0.0450 ns | 0.0421 ns | 16.604 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.811 ns | 0.0144 ns | 0.0128 ns | 17.813 ns |  1.04 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.285 ns | 0.0551 ns | 0.0489 ns | 20.271 ns |  1.18 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 18.232 ns | 0.0172 ns | 0.0144 ns | 18.233 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.054 ns | 0.0768 ns | 0.0718 ns | 13.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.745 ns | 0.0163 ns | 0.0144 ns | 11.749 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.181 ns | 0.0563 ns | 0.0439 ns |  8.167 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.951 ns | 0.0220 ns | 0.0206 ns | 12.954 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.489 ns | 0.1192 ns | 0.1115 ns | 13.513 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.446 ns | 0.0570 ns | 0.0533 ns | 13.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.379 ns | 0.0589 ns | 0.0551 ns | 14.393 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.280 ns | 0.0294 ns | 0.0246 ns | 12.278 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.592 ns | 0.0180 ns | 0.0168 ns | 13.591 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.043 ns | 0.0193 ns | 0.0171 ns | 14.045 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.822 ns | 0.0116 ns | 0.0108 ns | 11.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.876 ns | 0.0173 ns | 0.0162 ns | 11.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.469 ns | 0.0450 ns | 0.0399 ns |  7.481 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.434 ns | 0.0164 ns | 0.0153 ns | 10.428 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 11.152 ns | 0.0113 ns | 0.0106 ns | 11.153 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 17.642 ns | 0.0414 ns | 0.0346 ns | 17.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.233 ns | 0.0449 ns | 0.0398 ns | 16.223 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.827 ns | 0.0620 ns | 0.0549 ns | 15.823 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 18.614 ns | 0.0372 ns | 0.0348 ns | 18.623 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.162 ns | 0.1417 ns | 0.1325 ns | 19.228 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.042 ns | 0.0160 ns | 0.0150 ns | 12.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.767 ns | 0.0545 ns | 0.0483 ns | 10.779 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.567 ns | 0.0104 ns | 0.0092 ns |  7.566 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 10.701 ns | 0.0456 ns | 0.0427 ns | 10.713 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.954 ns | 0.0101 ns | 0.0094 ns | 10.951 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.644 ns | 0.0343 ns | 0.0286 ns | 17.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.255 ns | 0.0448 ns | 0.0397 ns | 16.238 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.628 ns | 0.0280 ns | 0.0262 ns | 18.627 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.634 ns | 0.0401 ns | 0.0375 ns | 18.640 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.996 ns | 0.0333 ns | 0.0278 ns | 18.995 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.846 ns | 0.0248 ns | 0.0220 ns | 11.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.466 ns | 0.0139 ns | 0.0130 ns | 10.470 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.836 ns | 0.1300 ns | 0.1216 ns |  7.752 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.449 ns | 0.0267 ns | 0.0237 ns | 10.447 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.622 ns | 0.0857 ns | 0.0802 ns | 10.643 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.254 ns | 0.0193 ns | 0.0171 ns | 13.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.886 ns | 0.0823 ns | 0.0770 ns | 13.908 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.500 ns | 0.0256 ns | 0.0240 ns | 11.508 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.187 ns | 0.0395 ns | 0.0330 ns | 15.179 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.599 ns | 0.0166 ns | 0.0156 ns | 13.602 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.799 ns | 0.0143 ns | 0.0127 ns | 11.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.351 ns | 0.0229 ns | 0.0214 ns | 10.352 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.475 ns | 0.0498 ns | 0.0466 ns |  7.489 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.433 ns | 0.0139 ns | 0.0130 ns | 10.435 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.486 ns | 0.0128 ns | 0.0113 ns | 12.483 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 17.722 ns | 0.0265 ns | 0.0248 ns | 17.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.997 ns | 0.0328 ns | 0.0291 ns | 16.002 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 16.528 ns | 0.1249 ns | 0.1168 ns | 16.459 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 20.199 ns | 0.0245 ns | 0.0217 ns | 20.206 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.722 ns | 0.0204 ns | 0.0170 ns | 18.717 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.047 ns | 0.0183 ns | 0.0143 ns | 12.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.761 ns | 0.0490 ns | 0.0458 ns | 10.769 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.045 ns | 0.0117 ns | 0.0110 ns |  8.045 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 11.049 ns | 0.0971 ns | 0.0908 ns | 11.056 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.664 ns | 0.0132 ns | 0.0111 ns | 10.664 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.397 ns | 0.0226 ns | 0.0189 ns | 17.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.858 ns | 0.0396 ns | 0.0371 ns | 16.858 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.366 ns | 0.0203 ns | 0.0190 ns | 18.370 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.208 ns | 0.0250 ns | 0.0234 ns | 18.200 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.602 ns | 0.0377 ns | 0.0353 ns | 18.613 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.812 ns | 0.0215 ns | 0.0191 ns | 11.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.466 ns | 0.0142 ns | 0.0118 ns | 10.465 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.131 ns | 0.0170 ns | 0.0159 ns |  7.135 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.395 ns | 0.0258 ns | 0.0229 ns | 10.395 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.625 ns | 0.1015 ns | 0.0949 ns | 10.674 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.300 ns | 0.0571 ns | 0.0534 ns | 13.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.022 ns | 0.0143 ns | 0.0134 ns | 13.023 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.469 ns | 0.2684 ns | 0.3673 ns | 12.678 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 15.037 ns | 0.0265 ns | 0.0207 ns | 15.039 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.628 ns | 0.0208 ns | 0.0195 ns | 13.630 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.483 ns | 0.0213 ns | 0.0199 ns | 12.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.349 ns | 0.0201 ns | 0.0188 ns | 10.349 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.494 ns | 0.0135 ns | 0.0126 ns |  7.494 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.401 ns | 0.0265 ns | 0.0207 ns | 10.397 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.394 ns | 0.0157 ns | 0.0147 ns | 10.393 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.167 ns | 0.0218 ns | 0.0204 ns | 17.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.519 ns | 0.0493 ns | 0.0411 ns | 16.529 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.361 ns | 0.0172 ns | 0.0144 ns | 16.358 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.542 ns | 0.0270 ns | 0.0239 ns | 18.547 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.716 ns | 0.1202 ns | 0.1124 ns | 18.766 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.291 ns | 0.0130 ns | 0.0115 ns | 13.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.185 ns | 0.0161 ns | 0.0151 ns | 12.185 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.630 ns | 0.1975 ns | 0.2195 ns |  8.753 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.197 ns | 0.0160 ns | 0.0150 ns | 13.195 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.293 ns | 0.0164 ns | 0.0154 ns | 13.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.373 ns | 0.0314 ns | 0.0262 ns | 17.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.254 ns | 0.0282 ns | 0.0263 ns | 16.258 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.840 ns | 0.0184 ns | 0.0163 ns | 17.841 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.822 ns | 0.0524 ns | 0.0490 ns | 18.821 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.737 ns | 0.0246 ns | 0.0230 ns | 18.746 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.900 ns | 0.0177 ns | 0.0147 ns | 12.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.709 ns | 0.0136 ns | 0.0114 ns | 11.713 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.663 ns | 0.1952 ns | 0.2606 ns |  8.782 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.975 ns | 0.0326 ns | 0.0289 ns | 12.987 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.114 ns | 0.1176 ns | 0.1100 ns | 13.133 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.854 ns | 0.0074 ns | 0.0070 ns | 13.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.277 ns | 0.0191 ns | 0.0178 ns | 14.275 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.130 ns | 0.0210 ns | 0.0186 ns | 13.133 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.640 ns | 0.0203 ns | 0.0190 ns | 13.635 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.829 ns | 0.0375 ns | 0.0351 ns | 13.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.851 ns | 0.0254 ns | 0.0225 ns | 11.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.359 ns | 0.0090 ns | 0.0084 ns | 10.358 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.239 ns | 0.0636 ns | 0.0564 ns |  7.266 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.768 ns | 0.0189 ns | 0.0177 ns | 10.771 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.503 ns | 0.1054 ns | 0.0986 ns | 10.555 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 17.197 ns | 0.0459 ns | 0.0407 ns | 17.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.474 ns | 0.0306 ns | 0.0256 ns | 16.484 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.719 ns | 0.0295 ns | 0.0276 ns | 16.711 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.278 ns | 0.0481 ns | 0.0401 ns | 18.280 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.522 ns | 0.0183 ns | 0.0162 ns | 18.522 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.887 ns | 0.0286 ns | 0.0254 ns | 12.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.772 ns | 0.0173 ns | 0.0161 ns | 10.772 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.944 ns | 0.0446 ns | 0.0417 ns |  7.955 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 10.897 ns | 0.0214 ns | 0.0200 ns | 10.896 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.711 ns | 0.0166 ns | 0.0155 ns | 10.714 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.151 ns | 0.0197 ns | 0.0184 ns | 17.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.257 ns | 0.0286 ns | 0.0254 ns | 16.254 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.673 ns | 0.0308 ns | 0.0273 ns | 15.672 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 20.320 ns | 0.0618 ns | 0.0578 ns | 20.324 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.456 ns | 0.0208 ns | 0.0195 ns | 18.455 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.829 ns | 0.0207 ns | 0.0193 ns | 11.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.468 ns | 0.0084 ns | 0.0078 ns | 10.471 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.110 ns | 0.0217 ns | 0.0192 ns |  7.111 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 10.372 ns | 0.0152 ns | 0.0118 ns | 10.367 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.558 ns | 0.0169 ns | 0.0158 ns | 10.554 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.679 ns | 0.0921 ns | 0.0862 ns | 14.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.908 ns | 0.0127 ns | 0.0119 ns | 13.908 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.495 ns | 0.0198 ns | 0.0186 ns | 14.499 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.171 ns | 0.0254 ns | 0.0225 ns | 14.175 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.088 ns | 0.0229 ns | 0.0215 ns | 14.086 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 11.853 ns | 0.0518 ns | 0.0484 ns | 11.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.004 ns | 0.0197 ns | 0.0174 ns | 11.008 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.273 ns | 0.1702 ns | 0.2700 ns |  7.118 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                                            From_Float |        net461 | 10.461 ns | 0.0258 ns | 0.0241 ns | 10.458 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 10.489 ns | 0.0187 ns | 0.0156 ns | 10.488 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 13.769 ns | 0.0219 ns | 0.0194 ns | 13.771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 13.586 ns | 0.0620 ns | 0.0580 ns | 13.595 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 11.997 ns | 0.0249 ns | 0.0233 ns | 11.999 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 14.132 ns | 0.0327 ns | 0.0273 ns | 14.119 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 14.346 ns | 0.0208 ns | 0.0195 ns | 14.340 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.069 ns | 0.0821 ns | 0.0768 ns | 12.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.609 ns | 0.0265 ns | 0.0248 ns | 10.607 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  7.485 ns | 0.0137 ns | 0.0121 ns |  7.485 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 10.653 ns | 0.0151 ns | 0.0126 ns | 10.655 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.379 ns | 0.0936 ns | 0.0876 ns | 12.338 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.807 ns | 0.0281 ns | 0.0263 ns | 13.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.179 ns | 0.0298 ns | 0.0264 ns | 14.175 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.805 ns | 0.5193 ns | 0.7612 ns | 12.377 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 15.337 ns | 0.0211 ns | 0.0176 ns | 15.338 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 14.973 ns | 0.0164 ns | 0.0145 ns | 14.974 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.026 ns | 0.0155 ns | 0.0145 ns | 12.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.497 ns | 0.0133 ns | 0.0103 ns | 10.497 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.236 ns | 0.0122 ns | 0.0114 ns |  7.237 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.400 ns | 0.0203 ns | 0.0158 ns | 10.399 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.487 ns | 0.0221 ns | 0.0206 ns | 10.481 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.447 ns | 0.0082 ns | 0.0073 ns | 13.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.843 ns | 0.0180 ns | 0.0160 ns | 12.845 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.495 ns | 0.0750 ns | 0.0665 ns | 14.508 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.265 ns | 0.0276 ns | 0.0258 ns | 14.266 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.345 ns | 0.0357 ns | 0.0298 ns | 14.348 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 71.199 ns | 0.0812 ns | 0.0760 ns | 71.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 73.777 ns | 0.1622 ns | 0.1438 ns | 73.841 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 58.792 ns | 0.1281 ns | 0.1198 ns | 58.795 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 72.370 ns | 0.1363 ns | 0.1208 ns | 72.331 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 72.635 ns | 0.1041 ns | 0.0923 ns | 72.635 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 75.858 ns | 0.1256 ns | 0.1175 ns | 75.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 82.056 ns | 0.1200 ns | 0.0937 ns | 82.023 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 60.727 ns | 0.0985 ns | 0.0921 ns | 60.745 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 79.403 ns | 0.0635 ns | 0.0496 ns | 79.389 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 77.933 ns | 0.1033 ns | 0.0966 ns | 77.946 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.651 ns | 0.0491 ns | 0.0459 ns | 12.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.027 ns | 0.0217 ns | 0.0193 ns | 13.029 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.119 ns | 0.0550 ns | 0.0515 ns | 12.129 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 13.038 ns | 0.0157 ns | 0.0139 ns | 13.037 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.969 ns | 0.0192 ns | 0.0179 ns | 12.968 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.263 ns | 0.0223 ns | 0.0198 ns | 13.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.848 ns | 0.0244 ns | 0.0228 ns | 12.841 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.241 ns | 0.2690 ns | 0.2879 ns | 12.377 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.131 ns | 0.0237 ns | 0.0222 ns | 15.131 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.616 ns | 0.0184 ns | 0.0172 ns | 13.614 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.753 ns | 0.0199 ns | 0.0176 ns | 12.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.023 ns | 0.0283 ns | 0.0264 ns | 13.012 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.999 ns | 0.2724 ns | 0.3028 ns | 13.154 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.896 ns | 0.1005 ns | 0.0940 ns | 14.853 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.174 ns | 0.0182 ns | 0.0171 ns | 13.169 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.285 ns | 0.0153 ns | 0.0136 ns | 13.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.385 ns | 0.0247 ns | 0.0219 ns | 10.388 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.462 ns | 0.0920 ns | 0.0861 ns |  7.516 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.435 ns | 0.0152 ns | 0.0142 ns | 10.436 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.419 ns | 0.0162 ns | 0.0152 ns | 10.417 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 17.161 ns | 0.0267 ns | 0.0236 ns | 17.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 16.029 ns | 0.0585 ns | 0.0489 ns | 16.028 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.698 ns | 0.0893 ns | 0.0836 ns | 16.671 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.851 ns | 0.0355 ns | 0.0296 ns | 18.850 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.559 ns | 0.0169 ns | 0.0141 ns | 18.559 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.242 ns | 0.0114 ns | 0.0101 ns | 12.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 12.254 ns | 0.0140 ns | 0.0131 ns | 12.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  8.120 ns | 0.0169 ns | 0.0141 ns |  8.120 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 11.266 ns | 0.0189 ns | 0.0168 ns | 11.268 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.760 ns | 0.0982 ns | 0.0918 ns | 10.705 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.415 ns | 0.0281 ns | 0.0263 ns | 17.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.582 ns | 0.0450 ns | 0.0421 ns | 16.596 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.422 ns | 0.0263 ns | 0.0233 ns | 15.426 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.037 ns | 0.0338 ns | 0.0316 ns | 19.027 ns |  1.09 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.812 ns | 0.0663 ns | 0.0588 ns | 18.791 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.814 ns | 0.0381 ns | 0.0337 ns | 11.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.524 ns | 0.0708 ns | 0.0662 ns | 10.498 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.254 ns | 0.0128 ns | 0.0114 ns |  7.255 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.432 ns | 0.1174 ns | 0.1098 ns | 12.508 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.620 ns | 0.0263 ns | 0.0246 ns | 10.617 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.351 ns | 0.0577 ns | 0.0482 ns | 13.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.854 ns | 0.0146 ns | 0.0130 ns | 12.852 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.670 ns | 0.0210 ns | 0.0164 ns | 13.666 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.484 ns | 0.0156 ns | 0.0138 ns | 13.484 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.636 ns | 0.0216 ns | 0.0202 ns | 13.636 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.008 ns | 0.0409 ns | 0.0362 ns | 12.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.698 ns | 0.0443 ns | 0.0393 ns | 10.707 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.337 ns | 0.0133 ns | 0.0118 ns |  7.335 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.451 ns | 0.0158 ns | 0.0140 ns | 10.453 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.444 ns | 0.0166 ns | 0.0155 ns | 10.446 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 17.692 ns | 0.0936 ns | 0.0830 ns | 17.710 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.444 ns | 0.0230 ns | 0.0192 ns | 16.451 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.985 ns | 0.0346 ns | 0.0289 ns | 15.992 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.413 ns | 0.1048 ns | 0.0929 ns | 18.402 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.972 ns | 0.0649 ns | 0.0607 ns | 18.993 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.036 ns | 0.0106 ns | 0.0094 ns | 12.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.676 ns | 0.0191 ns | 0.0170 ns | 10.673 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.589 ns | 0.0123 ns | 0.0109 ns |  7.589 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 10.599 ns | 0.0230 ns | 0.0215 ns | 10.600 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.883 ns | 0.0172 ns | 0.0152 ns | 10.880 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.384 ns | 0.0469 ns | 0.0392 ns | 17.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.263 ns | 0.0242 ns | 0.0226 ns | 16.257 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.210 ns | 0.2486 ns | 0.2326 ns | 16.356 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.662 ns | 0.0272 ns | 0.0254 ns | 18.658 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.598 ns | 0.0188 ns | 0.0176 ns | 18.598 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.970 ns | 0.0643 ns | 0.0537 ns | 11.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.836 ns | 0.0399 ns | 0.0333 ns | 11.826 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.368 ns | 0.0167 ns | 0.0157 ns |  7.368 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.410 ns | 0.0690 ns | 0.0645 ns | 10.380 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.641 ns | 0.0978 ns | 0.0915 ns | 10.656 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.245 ns | 0.0217 ns | 0.0203 ns | 13.240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.430 ns | 0.0188 ns | 0.0157 ns | 13.426 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.102 ns | 0.0844 ns | 0.0789 ns | 13.136 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 15.194 ns | 0.0251 ns | 0.0210 ns | 15.204 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.606 ns | 0.0189 ns | 0.0167 ns | 13.601 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.649 ns | 0.0171 ns | 0.0152 ns | 12.646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.497 ns | 0.0159 ns | 0.0141 ns | 10.496 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.561 ns | 0.0150 ns | 0.0140 ns |  7.560 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.642 ns | 0.0311 ns | 0.0291 ns | 10.631 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 11.000 ns | 0.1127 ns | 0.1054 ns | 11.015 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 17.938 ns | 0.0221 ns | 0.0207 ns | 17.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.561 ns | 0.1056 ns | 0.0936 ns | 16.524 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.574 ns | 0.0393 ns | 0.0368 ns | 16.570 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.004 ns | 0.1198 ns | 0.1062 ns | 18.965 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.057 ns | 0.1558 ns | 0.1381 ns | 18.991 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.228 ns | 0.0145 ns | 0.0136 ns | 13.226 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.959 ns | 0.0130 ns | 0.0122 ns | 11.960 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.600 ns | 0.0560 ns | 0.0496 ns |  8.617 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.181 ns | 0.0211 ns | 0.0187 ns | 14.181 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.468 ns | 0.0234 ns | 0.0207 ns | 13.465 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.410 ns | 0.0354 ns | 0.0296 ns | 17.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.033 ns | 0.0711 ns | 0.0594 ns | 17.020 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.341 ns | 0.4598 ns | 0.7808 ns | 20.918 ns |  1.27 |    0.05 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.628 ns | 0.0349 ns | 0.0292 ns | 20.646 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.019 ns | 0.0310 ns | 0.0274 ns | 19.014 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.079 ns | 0.0557 ns | 0.0521 ns | 13.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.724 ns | 0.0218 ns | 0.0193 ns | 11.719 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.159 ns | 0.0178 ns | 0.0167 ns |  8.156 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.008 ns | 0.0319 ns | 0.0298 ns | 14.005 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.611 ns | 0.0291 ns | 0.0258 ns | 13.608 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.246 ns | 0.0161 ns | 0.0143 ns | 13.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.778 ns | 0.0267 ns | 0.0250 ns | 13.779 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.107 ns | 0.0658 ns | 0.0583 ns | 13.129 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.439 ns | 0.0319 ns | 0.0283 ns | 13.435 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.118 ns | 0.0552 ns | 0.0461 ns | 14.113 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.246 ns | 0.0167 ns | 0.0148 ns | 13.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.826 ns | 0.0251 ns | 0.0210 ns | 12.824 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.781 ns | 0.1369 ns | 0.1281 ns | 11.866 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.136 ns | 0.0206 ns | 0.0193 ns | 15.130 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.613 ns | 0.0168 ns | 0.0149 ns | 13.615 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.921 ns | 0.0109 ns | 0.0102 ns | 10.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.915 ns | 0.0129 ns | 0.0120 ns |  9.914 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.162 ns | 0.2271 ns | 0.2124 ns | 11.068 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.508 ns | 0.2968 ns | 0.2776 ns | 13.390 ns |  1.24 |    0.03 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.623 ns | 0.0105 ns | 0.0093 ns | 12.621 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.528 ns | 0.0124 ns | 0.0110 ns | 13.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.824 ns | 0.0169 ns | 0.0141 ns | 12.823 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.104 ns | 0.0588 ns | 0.0550 ns | 13.117 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.445 ns | 0.0216 ns | 0.0191 ns | 13.445 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.036 ns | 0.0164 ns | 0.0137 ns | 14.033 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.153 ns | 0.0317 ns | 0.0265 ns | 17.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.004 ns | 0.0174 ns | 0.0163 ns | 13.004 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.262 ns | 0.0422 ns | 0.0395 ns | 13.257 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.305 ns | 0.0627 ns | 0.0586 ns | 17.307 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.929 ns | 0.0336 ns | 0.0298 ns | 16.926 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 15.880 ns | 0.0172 ns | 0.0152 ns | 15.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 16.340 ns | 0.0348 ns | 0.0325 ns | 16.337 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.077 ns | 0.0583 ns | 0.0545 ns | 15.081 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 17.191 ns | 0.1479 ns | 0.1384 ns | 17.127 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.388 ns | 0.0468 ns | 0.0415 ns | 17.392 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.170 ns | 0.0343 ns | 0.0321 ns | 15.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.511 ns | 0.0223 ns | 0.0174 ns | 12.517 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.747 ns | 0.0133 ns | 0.0118 ns | 11.746 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.951 ns | 0.0370 ns | 0.0346 ns | 14.946 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.793 ns | 0.0375 ns | 0.0351 ns | 13.784 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.244 ns | 0.0220 ns | 0.0183 ns | 13.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.878 ns | 0.0201 ns | 0.0178 ns | 12.883 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.888 ns | 0.2981 ns | 0.6543 ns | 14.133 ns |  0.98 |    0.07 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.511 ns | 0.0095 ns | 0.0089 ns | 13.511 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.351 ns | 0.0178 ns | 0.0149 ns | 14.353 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.508 ns | 0.1013 ns | 0.0898 ns | 13.548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.544 ns | 0.0193 ns | 0.0181 ns | 10.541 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.529 ns | 0.0115 ns | 0.0089 ns | 11.529 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.415 ns | 0.0174 ns | 0.0145 ns | 12.413 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.475 ns | 0.0438 ns | 0.0366 ns | 12.468 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 14.476 ns | 0.0338 ns | 0.0282 ns | 14.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.912 ns | 0.0191 ns | 0.0160 ns | 14.916 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.312 ns | 0.1717 ns | 0.1607 ns | 15.186 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.091 ns | 0.0297 ns | 0.0263 ns | 15.084 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.416 ns | 0.0299 ns | 0.0280 ns | 15.412 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.799 ns | 0.0271 ns | 0.0240 ns | 12.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.534 ns | 0.0241 ns | 0.0213 ns | 10.534 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.879 ns | 0.0242 ns | 0.0215 ns | 10.876 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.060 ns | 0.0224 ns | 0.0198 ns | 14.063 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.785 ns | 0.0777 ns | 0.0726 ns | 12.833 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.944 ns | 0.0198 ns | 0.0185 ns | 13.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.862 ns | 0.0218 ns | 0.0203 ns | 12.858 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.860 ns | 0.0138 ns | 0.0122 ns | 12.856 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.970 ns | 0.0172 ns | 0.0161 ns | 13.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.622 ns | 0.0308 ns | 0.0240 ns | 13.618 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.907 ns | 0.0392 ns | 0.0327 ns | 20.910 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.934 ns | 0.0453 ns | 0.0378 ns | 16.935 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.437 ns | 0.0868 ns | 0.0812 ns | 12.402 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.678 ns | 0.1197 ns | 0.1061 ns | 18.700 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.266 ns | 0.1924 ns | 0.1800 ns | 17.287 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 16.188 ns | 0.0327 ns | 0.0290 ns | 16.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.040 ns | 0.0254 ns | 0.0225 ns | 16.038 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.977 ns | 0.3566 ns | 0.3336 ns | 16.807 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.850 ns | 0.0344 ns | 0.0322 ns | 17.853 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.030 ns | 0.0274 ns | 0.0214 ns | 18.023 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.479 ns | 0.0854 ns | 0.0799 ns | 19.477 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.629 ns | 0.0327 ns | 0.0306 ns | 16.631 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.506 ns | 0.1207 ns | 0.1129 ns | 13.514 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 18.681 ns | 0.0396 ns | 0.0351 ns | 18.675 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.785 ns | 0.0534 ns | 0.0474 ns | 18.771 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.021 ns | 0.0355 ns | 0.0297 ns | 16.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.529 ns | 0.1713 ns | 0.1602 ns | 16.425 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.543 ns | 0.0306 ns | 0.0287 ns | 16.537 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.934 ns | 0.0327 ns | 0.0306 ns | 19.935 ns |  1.24 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.074 ns | 0.0496 ns | 0.0440 ns | 18.059 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.406 ns | 0.0159 ns | 0.0149 ns | 13.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.069 ns | 0.0287 ns | 0.0254 ns | 12.073 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.515 ns | 0.1384 ns | 0.1227 ns |  8.553 ns |  0.64 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.570 ns | 0.0116 ns | 0.0103 ns | 10.569 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.555 ns | 0.0261 ns | 0.0244 ns | 10.546 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.113 ns | 0.0342 ns | 0.0303 ns | 13.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.049 ns | 0.0193 ns | 0.0181 ns | 13.049 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.544 ns | 0.2711 ns | 0.3525 ns | 12.711 ns |  0.95 |    0.03 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.627 ns | 0.0078 ns | 0.0069 ns | 14.627 ns |  1.12 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.626 ns | 0.0151 ns | 0.0141 ns | 13.621 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.273 ns | 0.0640 ns | 0.0598 ns | 13.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.199 ns | 0.0205 ns | 0.0182 ns | 12.206 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.629 ns | 0.0103 ns | 0.0096 ns |  6.628 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.528 ns | 0.0113 ns | 0.0105 ns | 10.525 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.606 ns | 0.0139 ns | 0.0130 ns | 11.605 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.506 ns | 0.0129 ns | 0.0120 ns | 14.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.307 ns | 0.0365 ns | 0.0305 ns | 15.312 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.953 ns | 0.0122 ns | 0.0114 ns | 16.953 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.005 ns | 0.0332 ns | 0.0311 ns | 14.997 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 15.466 ns | 0.0245 ns | 0.0217 ns | 15.471 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.280 ns | 0.0179 ns | 0.0159 ns | 13.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.076 ns | 0.0289 ns | 0.0256 ns | 12.071 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.127 ns | 0.0134 ns | 0.0105 ns |  7.126 ns |  0.54 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.700 ns | 0.0152 ns | 0.0135 ns | 10.698 ns |  0.81 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.616 ns | 0.0158 ns | 0.0140 ns | 11.615 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.515 ns | 0.0553 ns | 0.0517 ns | 14.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.168 ns | 0.0195 ns | 0.0152 ns | 14.165 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.424 ns | 0.0155 ns | 0.0145 ns | 14.421 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.530 ns | 0.1864 ns | 0.1744 ns | 15.580 ns |  1.07 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.320 ns | 0.0336 ns | 0.0315 ns | 15.319 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.138 ns | 0.0197 ns | 0.0184 ns | 13.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.074 ns | 0.0180 ns | 0.0168 ns | 12.079 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.737 ns | 0.0164 ns | 0.0128 ns |  6.733 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.510 ns | 0.0433 ns | 0.0384 ns | 10.521 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.830 ns | 0.0483 ns | 0.0428 ns | 11.818 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.607 ns | 0.0350 ns | 0.0328 ns | 13.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.385 ns | 0.0305 ns | 0.0271 ns | 13.385 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.899 ns | 0.0838 ns | 0.0784 ns | 13.914 ns |  1.02 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.424 ns | 0.0195 ns | 0.0182 ns | 13.420 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.618 ns | 0.0204 ns | 0.0191 ns | 13.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.746 ns | 0.0567 ns | 0.0531 ns | 13.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.745 ns | 0.0116 ns | 0.0090 ns | 11.746 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.524 ns | 0.0126 ns | 0.0112 ns |  6.521 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 11.818 ns | 0.0114 ns | 0.0101 ns | 11.819 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.478 ns | 0.0676 ns | 0.0633 ns | 10.449 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.326 ns | 0.0864 ns | 0.0808 ns | 46.313 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 41.178 ns | 0.0658 ns | 0.0550 ns | 41.189 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 35.169 ns | 0.3379 ns | 0.3161 ns | 34.964 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.874 ns | 0.1008 ns | 0.0943 ns | 42.887 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 43.291 ns | 0.1816 ns | 0.1610 ns | 43.245 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.087 ns | 0.0479 ns | 0.0425 ns | 14.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.193 ns | 0.0163 ns | 0.0144 ns | 12.194 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.157 ns | 0.0165 ns | 0.0138 ns |  7.156 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 10.622 ns | 0.0400 ns | 0.0334 ns | 10.624 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.612 ns | 0.0244 ns | 0.0228 ns | 10.606 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.833 ns | 0.1167 ns | 0.1091 ns | 44.811 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.407 ns | 0.2263 ns | 0.2117 ns | 42.325 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.701 ns | 0.0834 ns | 0.0697 ns | 33.708 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 44.464 ns | 0.1447 ns | 0.1353 ns | 44.409 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 45.055 ns | 0.2627 ns | 0.2458 ns | 44.983 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.315 ns | 0.0315 ns | 0.0280 ns | 13.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.945 ns | 0.0127 ns | 0.0113 ns | 10.944 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.363 ns | 0.0592 ns | 0.0525 ns |  7.381 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.521 ns | 0.0726 ns | 0.0643 ns | 10.496 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.472 ns | 0.0209 ns | 0.0174 ns | 10.467 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.868 ns | 0.0152 ns | 0.0142 ns | 13.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.719 ns | 0.0389 ns | 0.0364 ns | 13.707 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.137 ns | 0.3201 ns | 0.4888 ns | 14.854 ns |  1.11 |    0.04 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 15.064 ns | 0.0205 ns | 0.0191 ns | 15.068 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.029 ns | 0.0235 ns | 0.0220 ns | 14.029 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.868 ns | 0.0142 ns | 0.0119 ns | 12.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.783 ns | 0.0088 ns | 0.0069 ns | 10.782 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.571 ns | 0.0360 ns | 0.0319 ns | 11.581 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.041 ns | 0.0251 ns | 0.0209 ns | 14.051 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.696 ns | 0.0260 ns | 0.0203 ns | 12.695 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.023 ns | 0.0211 ns | 0.0197 ns | 18.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.611 ns | 0.0193 ns | 0.0171 ns | 15.608 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.640 ns | 0.2969 ns | 0.4622 ns | 13.331 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.374 ns | 0.0324 ns | 0.0303 ns | 15.376 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.208 ns | 0.0211 ns | 0.0197 ns | 16.208 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.024 ns | 0.0179 ns | 0.0168 ns | 13.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.546 ns | 0.0333 ns | 0.0312 ns | 10.543 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.999 ns | 0.1630 ns | 0.1525 ns | 11.979 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.419 ns | 0.0165 ns | 0.0147 ns | 12.420 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.622 ns | 0.0227 ns | 0.0212 ns | 12.615 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.255 ns | 0.0208 ns | 0.0184 ns | 13.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.858 ns | 0.0682 ns | 0.0638 ns | 12.823 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.583 ns | 0.3157 ns | 0.8589 ns | 14.831 ns |  1.00 |    0.12 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.407 ns | 0.0875 ns | 0.0819 ns | 15.419 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.597 ns | 0.0224 ns | 0.0210 ns | 13.597 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.136 ns | 0.0375 ns | 0.0292 ns | 39.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.296 ns | 0.3257 ns | 0.3046 ns | 39.238 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.422 ns | 0.4308 ns | 0.4030 ns | 36.578 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.456 ns | 0.0698 ns | 0.0653 ns | 40.448 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.264 ns | 0.0509 ns | 0.0476 ns | 40.276 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.348 ns | 0.0092 ns | 0.0086 ns | 15.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.549 ns | 0.0204 ns | 0.0190 ns | 14.553 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 17.319 ns | 0.1297 ns | 0.1214 ns | 17.365 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 16.876 ns | 0.0157 ns | 0.0139 ns | 16.872 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.931 ns | 0.0275 ns | 0.0257 ns | 15.945 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.543 ns | 0.0506 ns | 0.0473 ns | 39.544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.314 ns | 0.0620 ns | 0.0549 ns | 39.317 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.373 ns | 0.3340 ns | 0.2961 ns | 35.489 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.789 ns | 0.2733 ns | 0.2556 ns | 39.887 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.269 ns | 0.0477 ns | 0.0446 ns | 39.271 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.044 ns | 0.0205 ns | 0.0192 ns | 15.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.493 ns | 0.0223 ns | 0.0187 ns | 14.489 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.697 ns | 0.0228 ns | 0.0213 ns | 14.694 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.997 ns | 0.0223 ns | 0.0208 ns | 15.992 ns |  1.06 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.624 ns | 0.0456 ns | 0.0426 ns | 15.616 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.091 ns | 0.0692 ns | 0.0648 ns | 40.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.311 ns | 0.0514 ns | 0.0481 ns | 39.296 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.248 ns | 0.2380 ns | 0.2226 ns | 35.337 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.897 ns | 0.3612 ns | 0.3378 ns | 39.727 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.142 ns | 0.3205 ns | 0.2998 ns | 40.305 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.177 ns | 0.0167 ns | 0.0157 ns | 13.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.799 ns | 0.0126 ns | 0.0105 ns | 14.798 ns |  1.12 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.949 ns | 0.0245 ns | 0.0217 ns | 13.946 ns |  1.06 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.503 ns | 0.0154 ns | 0.0145 ns | 13.501 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.715 ns | 0.0209 ns | 0.0196 ns | 13.718 ns |  1.04 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Float.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Float.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Float.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Float.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Float.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Float.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Float.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Float.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Float.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
