
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XBZJXS : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-RPHYXP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-WPBXUQ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-EJFWSE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-ZVTGBZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 16.12 ns | 0.1499 ns | 0.1329 ns | 16.10 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Bool | .NET Core 2.2 | 14.96 ns | 0.1737 ns | 0.1625 ns | 15.00 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Bool | .NET Core 3.0 | 15.58 ns | 0.3309 ns | 0.3939 ns | 15.86 ns |  0.96 |    0.03 | 0.0038 |     - |     - |      24 B |
                                             From_Bool |        net461 | 14.88 ns | 0.0268 ns | 0.0238 ns | 14.88 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Bool |        net472 | 14.85 ns | 0.0219 ns | 0.0194 ns | 14.85 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 13.87 ns | 0.2786 ns | 0.2606 ns | 13.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 11.77 ns | 0.1176 ns | 0.1100 ns | 11.79 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 11.97 ns | 0.0700 ns | 0.0655 ns | 12.00 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 14.33 ns | 0.0155 ns | 0.0145 ns | 14.33 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 12.00 ns | 0.0100 ns | 0.0093 ns | 12.00 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 16.48 ns | 0.2350 ns | 0.1834 ns | 16.55 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 15.22 ns | 0.0320 ns | 0.0299 ns | 15.22 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 16.06 ns | 0.0359 ns | 0.0336 ns | 16.05 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue |        net461 | 14.49 ns | 0.0944 ns | 0.0883 ns | 14.47 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue |        net472 | 14.99 ns | 0.0900 ns | 0.0842 ns | 15.04 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.98 ns | 0.0405 ns | 0.0338 ns | 12.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.41 ns | 0.0132 ns | 0.0117 ns | 11.41 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.57 ns | 0.0165 ns | 0.0155 ns | 12.57 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 12.00 ns | 0.0164 ns | 0.0137 ns | 12.00 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 14.81 ns | 0.0218 ns | 0.0182 ns | 14.81 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.13 ns | 0.0377 ns | 0.0353 ns | 13.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.72 ns | 0.0106 ns | 0.0094 ns | 11.72 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 12.78 ns | 0.2763 ns | 0.3689 ns | 12.98 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.08 ns | 0.0123 ns | 0.0103 ns | 13.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.24 ns | 0.0841 ns | 0.0787 ns | 13.19 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.12 ns | 0.0172 ns | 0.0153 ns | 13.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.41 ns | 0.0476 ns | 0.0422 ns | 11.42 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.87 ns | 0.0614 ns | 0.0480 ns | 11.85 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 12.01 ns | 0.0157 ns | 0.0147 ns | 12.01 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.45 ns | 0.0157 ns | 0.0147 ns | 13.45 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 14.94 ns | 0.0359 ns | 0.0336 ns | 14.93 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte | .NET Core 2.2 | 14.36 ns | 0.0313 ns | 0.0293 ns | 14.36 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte | .NET Core 3.0 | 15.10 ns | 0.0652 ns | 0.0610 ns | 15.09 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte |        net461 | 15.45 ns | 0.0763 ns | 0.0713 ns | 15.45 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte |        net472 | 16.20 ns | 0.1299 ns | 0.1215 ns | 16.26 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 14.22 ns | 0.0244 ns | 0.0228 ns | 14.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 11.33 ns | 0.0189 ns | 0.0176 ns | 11.33 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 11.87 ns | 0.0159 ns | 0.0149 ns | 11.87 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 12.05 ns | 0.0721 ns | 0.0674 ns | 12.03 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 13.84 ns | 0.0228 ns | 0.0213 ns | 13.84 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 14.96 ns | 0.0252 ns | 0.0235 ns | 14.95 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 15.51 ns | 0.0445 ns | 0.0416 ns | 15.49 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 16.22 ns | 0.0950 ns | 0.0889 ns | 16.20 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue |        net461 | 15.99 ns | 0.0284 ns | 0.0252 ns | 15.99 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue |        net472 | 14.44 ns | 0.0355 ns | 0.0332 ns | 14.43 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.75 ns | 0.0344 ns | 0.0321 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.60 ns | 0.0111 ns | 0.0098 ns | 11.60 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.15 ns | 0.2637 ns | 0.2467 ns | 12.30 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 12.19 ns | 0.0377 ns | 0.0334 ns | 12.17 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 11.93 ns | 0.0248 ns | 0.0207 ns | 11.92 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 13.26 ns | 0.0136 ns | 0.0127 ns | 13.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.74 ns | 0.0222 ns | 0.0207 ns | 11.74 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 | 13.66 ns | 0.2914 ns | 0.2993 ns | 13.61 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.18 ns | 0.0119 ns | 0.0111 ns | 13.18 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.58 ns | 0.0151 ns | 0.0134 ns | 12.58 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.49 ns | 0.2058 ns | 0.1925 ns | 13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0135 ns | 0.0120 ns | 11.43 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.13 ns | 0.1028 ns | 0.0962 ns | 12.12 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 12.02 ns | 0.0485 ns | 0.0454 ns | 12.00 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 11.94 ns | 0.0123 ns | 0.0115 ns | 11.94 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 14.80 ns | 0.0728 ns | 0.0681 ns | 14.77 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 2.2 | 14.39 ns | 0.0276 ns | 0.0258 ns | 14.39 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 3.0 | 16.58 ns | 0.0338 ns | 0.0300 ns | 16.58 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net461 | 14.93 ns | 0.0326 ns | 0.0289 ns | 14.93 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net472 | 15.18 ns | 0.0263 ns | 0.0246 ns | 15.18 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 13.71 ns | 0.0198 ns | 0.0176 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 11.92 ns | 0.2296 ns | 0.2147 ns | 11.97 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 12.94 ns | 0.2178 ns | 0.2038 ns | 13.01 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 12.94 ns | 0.0474 ns | 0.0444 ns | 12.94 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 13.17 ns | 0.0065 ns | 0.0054 ns | 13.17 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 16.16 ns | 0.0527 ns | 0.0467 ns | 16.15 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 14.73 ns | 0.0380 ns | 0.0355 ns | 14.73 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 15.43 ns | 0.0432 ns | 0.0404 ns | 15.44 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net461 | 15.03 ns | 0.0237 ns | 0.0198 ns | 15.03 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net472 | 14.76 ns | 0.0336 ns | 0.0263 ns | 14.75 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.42 ns | 0.0147 ns | 0.0137 ns | 13.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.31 ns | 0.0064 ns | 0.0057 ns | 11.31 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.57 ns | 0.2600 ns | 0.2432 ns | 14.38 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 12.36 ns | 0.0096 ns | 0.0090 ns | 12.37 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 14.10 ns | 0.1816 ns | 0.1698 ns | 14.04 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 13.64 ns | 0.0498 ns | 0.0416 ns | 13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.72 ns | 0.0196 ns | 0.0164 ns | 11.72 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 | 15.13 ns | 0.3238 ns | 0.5135 ns | 15.38 ns |  1.08 |    0.05 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.93 ns | 0.0135 ns | 0.0126 ns | 12.94 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.61 ns | 0.0779 ns | 0.0691 ns | 12.65 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.07 ns | 0.0135 ns | 0.0126 ns | 13.07 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.43 ns | 0.0208 ns | 0.0194 ns | 11.44 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.87 ns | 0.0231 ns | 0.0193 ns | 11.87 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 12.36 ns | 0.0139 ns | 0.0116 ns | 12.36 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.52 ns | 0.1008 ns | 0.0943 ns | 13.47 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 16.23 ns | 0.0217 ns | 0.0181 ns | 16.23 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime | .NET Core 2.2 | 14.67 ns | 0.0268 ns | 0.0238 ns | 14.67 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime | .NET Core 3.0 | 18.63 ns | 0.0649 ns | 0.0607 ns | 18.65 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime |        net461 | 15.74 ns | 0.0291 ns | 0.0258 ns | 15.74 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime |        net472 | 15.27 ns | 0.0234 ns | 0.0196 ns | 15.27 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 14.44 ns | 0.0554 ns | 0.0518 ns | 14.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 | 11.61 ns | 0.0665 ns | 0.0622 ns | 11.64 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 | 12.99 ns | 0.2798 ns | 0.3223 ns | 13.20 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 | 11.99 ns | 0.0132 ns | 0.0124 ns | 11.99 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 | 14.27 ns | 0.1105 ns | 0.1034 ns | 14.30 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 16.64 ns | 0.0373 ns | 0.0349 ns | 16.64 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 15.61 ns | 0.0227 ns | 0.0212 ns | 15.62 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 17.28 ns | 0.1174 ns | 0.1098 ns | 17.26 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue |        net461 | 17.17 ns | 0.1050 ns | 0.0983 ns | 17.12 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue |        net472 | 16.70 ns | 0.0219 ns | 0.0205 ns | 16.70 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.96 ns | 0.0168 ns | 0.0149 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.32 ns | 0.0101 ns | 0.0085 ns | 11.32 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.41 ns | 0.2643 ns | 0.3437 ns | 12.61 ns |  0.95 |    0.03 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 12.10 ns | 0.0516 ns | 0.0431 ns | 12.11 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 12.04 ns | 0.0884 ns | 0.0827 ns | 12.08 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 14.35 ns | 0.0246 ns | 0.0218 ns | 14.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 13.12 ns | 0.0129 ns | 0.0115 ns | 13.12 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 14.11 ns | 0.0263 ns | 0.0233 ns | 14.10 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 16.60 ns | 0.1105 ns | 0.1034 ns | 16.54 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.71 ns | 0.0205 ns | 0.0192 ns | 13.71 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.11 ns | 0.0216 ns | 0.0202 ns | 13.10 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.32 ns | 0.0096 ns | 0.0085 ns | 11.32 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.04 ns | 0.0806 ns | 0.0754 ns | 12.02 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 12.01 ns | 0.0148 ns | 0.0138 ns | 12.01 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.55 ns | 0.0822 ns | 0.0769 ns | 13.59 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 17.82 ns | 0.0846 ns | 0.0791 ns | 17.80 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 2.2 | 15.49 ns | 0.0958 ns | 0.0896 ns | 15.50 ns |  0.87 |    0.01 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 3.0 | 17.40 ns | 0.0630 ns | 0.0559 ns | 17.38 ns |  0.98 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal |        net461 | 16.54 ns | 0.0263 ns | 0.0246 ns | 16.53 ns |  0.93 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal |        net472 | 16.72 ns | 0.0519 ns | 0.0460 ns | 16.72 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 12.96 ns | 0.0099 ns | 0.0077 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 11.71 ns | 0.0108 ns | 0.0096 ns | 11.71 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 12.01 ns | 0.0601 ns | 0.0502 ns | 12.02 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 12.70 ns | 0.0506 ns | 0.0448 ns | 12.71 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 14.01 ns | 0.1232 ns | 0.1152 ns | 14.05 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 17.01 ns | 0.0247 ns | 0.0207 ns | 17.00 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 16.50 ns | 0.0381 ns | 0.0338 ns | 16.50 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.28 ns | 0.3904 ns | 0.6078 ns | 18.63 ns |  1.04 |    0.04 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net461 | 18.11 ns | 0.0231 ns | 0.0216 ns | 18.11 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net472 | 18.17 ns | 0.1314 ns | 0.1229 ns | 18.09 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.07 ns | 0.0516 ns | 0.0482 ns | 13.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0104 ns | 0.0092 ns | 11.42 ns |  0.87 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.62 ns | 0.0473 ns | 0.0442 ns | 12.64 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 13.23 ns | 0.0140 ns | 0.0109 ns | 13.23 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 13.46 ns | 0.0160 ns | 0.0150 ns | 13.46 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.11 ns | 0.0188 ns | 0.0176 ns | 14.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.27 ns | 0.0121 ns | 0.0113 ns | 12.27 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 13.35 ns | 0.0171 ns | 0.0152 ns | 13.35 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.60 ns | 0.0280 ns | 0.0262 ns | 15.61 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.49 ns | 0.0166 ns | 0.0155 ns | 13.49 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.04 ns | 0.0101 ns | 0.0089 ns | 14.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.40 ns | 0.0785 ns | 0.0734 ns | 11.37 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.36 ns | 0.1108 ns | 0.1037 ns | 12.29 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 12.04 ns | 0.0795 ns | 0.0744 ns | 12.00 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 11.99 ns | 0.0088 ns | 0.0083 ns | 11.98 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.97 ns | 0.0400 ns | 0.0355 ns | 15.96 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 2.2 | 14.37 ns | 0.0268 ns | 0.0251 ns | 14.36 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 3.0 | 15.20 ns | 0.0733 ns | 0.0686 ns | 15.17 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net461 | 15.49 ns | 0.0350 ns | 0.0311 ns | 15.49 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net472 | 14.46 ns | 0.0298 ns | 0.0279 ns | 14.46 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 13.20 ns | 0.0773 ns | 0.0723 ns | 13.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 11.39 ns | 0.0508 ns | 0.0475 ns | 11.42 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 11.86 ns | 0.0164 ns | 0.0137 ns | 11.86 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 12.02 ns | 0.0111 ns | 0.0098 ns | 12.02 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 12.48 ns | 0.0131 ns | 0.0116 ns | 12.48 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 17.55 ns | 0.0253 ns | 0.0224 ns | 17.54 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.89 ns | 0.0411 ns | 0.0384 ns | 14.88 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 17.84 ns | 0.0605 ns | 0.0473 ns | 17.85 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net461 | 19.47 ns | 0.0402 ns | 0.0376 ns | 19.46 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net472 | 17.76 ns | 0.1200 ns | 0.1122 ns | 17.72 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.97 ns | 0.0100 ns | 0.0089 ns | 12.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.48 ns | 0.0141 ns | 0.0132 ns | 11.48 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.35 ns | 0.2698 ns | 0.2650 ns | 12.36 ns |  0.95 |    0.02 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 11.99 ns | 0.0151 ns | 0.0141 ns | 11.99 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 12.11 ns | 0.0227 ns | 0.0213 ns | 12.11 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.21 ns | 0.0147 ns | 0.0137 ns | 14.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 13.57 ns | 0.0774 ns | 0.0724 ns | 13.61 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 13.87 ns | 0.2724 ns | 0.2548 ns | 14.01 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.78 ns | 0.0312 ns | 0.0292 ns | 14.77 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.39 ns | 0.0931 ns | 0.0871 ns | 14.33 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.96 ns | 0.0178 ns | 0.0149 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.05 ns | 0.0122 ns | 0.0108 ns | 12.05 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.20 ns | 0.1333 ns | 0.1247 ns | 12.29 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 11.96 ns | 0.0132 ns | 0.0124 ns | 11.96 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.63 ns | 0.0071 ns | 0.0066 ns | 14.63 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 15.68 ns | 0.0874 ns | 0.0818 ns | 15.69 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Short | .NET Core 2.2 | 14.38 ns | 0.0186 ns | 0.0165 ns | 14.38 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Short | .NET Core 3.0 | 17.82 ns | 0.1496 ns | 0.1399 ns | 17.75 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Short |        net461 | 14.96 ns | 0.1132 ns | 0.1059 ns | 14.93 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Short |        net472 | 14.92 ns | 0.0796 ns | 0.0744 ns | 14.89 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 13.13 ns | 0.0126 ns | 0.0112 ns | 13.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 11.44 ns | 0.0139 ns | 0.0124 ns | 11.44 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 12.64 ns | 0.2155 ns | 0.2016 ns | 12.62 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 12.06 ns | 0.0176 ns | 0.0164 ns | 12.05 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 12.72 ns | 0.0152 ns | 0.0135 ns | 12.71 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 16.37 ns | 0.0204 ns | 0.0181 ns | 16.37 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 15.32 ns | 0.0407 ns | 0.0381 ns | 15.33 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 16.36 ns | 0.1525 ns | 0.1426 ns | 16.42 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue |        net461 | 15.18 ns | 0.1655 ns | 0.1548 ns | 15.17 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue |        net472 | 14.76 ns | 0.0235 ns | 0.0220 ns | 14.76 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.01 ns | 0.0177 ns | 0.0166 ns | 13.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.35 ns | 0.0175 ns | 0.0155 ns | 11.36 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.92 ns | 0.1844 ns | 0.1724 ns | 12.97 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 12.03 ns | 0.0104 ns | 0.0097 ns | 12.03 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 12.00 ns | 0.0824 ns | 0.0771 ns | 12.05 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 14.32 ns | 0.0188 ns | 0.0166 ns | 14.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.73 ns | 0.0156 ns | 0.0138 ns | 11.73 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 13.35 ns | 0.2801 ns | 0.2620 ns | 13.19 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.14 ns | 0.0118 ns | 0.0111 ns | 13.14 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.57 ns | 0.0239 ns | 0.0212 ns | 12.57 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.37 ns | 0.2907 ns | 0.2577 ns | 13.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.44 ns | 0.0161 ns | 0.0142 ns | 11.44 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.57 ns | 0.0758 ns | 0.0709 ns | 12.57 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 11.94 ns | 0.0120 ns | 0.0113 ns | 11.94 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.43 ns | 0.0147 ns | 0.0122 ns | 14.43 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 15.84 ns | 0.1187 ns | 0.1110 ns | 15.89 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int | .NET Core 2.2 | 14.71 ns | 0.0207 ns | 0.0193 ns | 14.71 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                              From_Int | .NET Core 3.0 | 15.02 ns | 0.0328 ns | 0.0307 ns | 15.01 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                              From_Int |        net461 | 15.48 ns | 0.0289 ns | 0.0270 ns | 15.48 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                              From_Int |        net472 | 15.85 ns | 0.0602 ns | 0.0563 ns | 15.86 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 13.97 ns | 0.1762 ns | 0.1648 ns | 14.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 11.45 ns | 0.0316 ns | 0.0280 ns | 11.44 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 11.91 ns | 0.0555 ns | 0.0519 ns | 11.90 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 11.94 ns | 0.0136 ns | 0.0121 ns | 11.94 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 13.27 ns | 0.0141 ns | 0.0125 ns | 13.27 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 16.52 ns | 0.1053 ns | 0.0985 ns | 16.52 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 15.61 ns | 0.0468 ns | 0.0415 ns | 15.61 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 15.72 ns | 0.3016 ns | 0.2821 ns | 15.93 ns |  0.95 |    0.02 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue |        net461 | 14.46 ns | 0.0819 ns | 0.0766 ns | 14.44 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue |        net472 | 14.33 ns | 0.0349 ns | 0.0291 ns | 14.32 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.96 ns | 0.2558 ns | 0.2393 ns | 14.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.39 ns | 0.0077 ns | 0.0068 ns | 11.39 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.52 ns | 0.1937 ns | 0.1812 ns | 12.62 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 11.96 ns | 0.0183 ns | 0.0163 ns | 11.95 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 14.79 ns | 0.0157 ns | 0.0147 ns | 14.79 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 14.99 ns | 0.1432 ns | 0.1118 ns | 14.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.75 ns | 0.0152 ns | 0.0135 ns | 11.74 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 13.70 ns | 0.0766 ns | 0.0640 ns | 13.71 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.49 ns | 0.0191 ns | 0.0178 ns | 12.49 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.15 ns | 0.0200 ns | 0.0177 ns | 13.14 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.30 ns | 0.0620 ns | 0.0580 ns | 14.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.45 ns | 0.0140 ns | 0.0124 ns | 11.45 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.97 ns | 0.4188 ns | 0.4301 ns | 12.74 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 11.99 ns | 0.0204 ns | 0.0191 ns | 11.99 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.39 ns | 0.0707 ns | 0.0591 ns | 13.36 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 15.69 ns | 0.0449 ns | 0.0375 ns | 15.69 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long | .NET Core 2.2 | 14.39 ns | 0.0319 ns | 0.0299 ns | 14.39 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long | .NET Core 3.0 | 16.74 ns | 0.1292 ns | 0.1208 ns | 16.71 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Long |        net461 | 17.51 ns | 0.0277 ns | 0.0245 ns | 17.51 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long |        net472 | 14.82 ns | 0.0344 ns | 0.0322 ns | 14.83 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 15.04 ns | 0.3000 ns | 0.2807 ns | 14.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 11.45 ns | 0.0175 ns | 0.0164 ns | 11.46 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 12.53 ns | 0.0120 ns | 0.0107 ns | 12.53 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 13.16 ns | 0.0708 ns | 0.0662 ns | 13.21 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 13.27 ns | 0.0140 ns | 0.0131 ns | 13.27 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 16.97 ns | 0.1432 ns | 0.1340 ns | 16.91 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 16.45 ns | 0.0378 ns | 0.0354 ns | 16.45 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 16.91 ns | 0.0486 ns | 0.0454 ns | 16.92 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue |        net461 | 16.46 ns | 0.0196 ns | 0.0184 ns | 16.46 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue |        net472 | 16.64 ns | 0.0947 ns | 0.0886 ns | 16.66 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.15 ns | 0.1428 ns | 0.1335 ns | 13.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.44 ns | 0.0132 ns | 0.0123 ns | 11.44 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.98 ns | 0.0106 ns | 0.0089 ns | 11.98 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 15.25 ns | 0.0195 ns | 0.0182 ns | 15.25 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 13.63 ns | 0.0126 ns | 0.0118 ns | 13.62 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.59 ns | 0.1190 ns | 0.1113 ns | 14.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.33 ns | 0.0072 ns | 0.0068 ns | 12.33 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 15.21 ns | 0.0489 ns | 0.0457 ns | 15.22 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.40 ns | 0.0194 ns | 0.0172 ns | 13.40 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.94 ns | 0.0180 ns | 0.0159 ns | 14.94 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.32 ns | 0.1564 ns | 0.1386 ns | 13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.36 ns | 0.0125 ns | 0.0105 ns | 12.36 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.86 ns | 0.0096 ns | 0.0090 ns | 11.86 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 12.76 ns | 0.0121 ns | 0.0108 ns | 12.76 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.35 ns | 0.0204 ns | 0.0181 ns | 13.35 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 15.71 ns | 0.0920 ns | 0.0861 ns | 15.70 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_SByte | .NET Core 2.2 | 14.48 ns | 0.0615 ns | 0.0576 ns | 14.51 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_SByte | .NET Core 3.0 | 17.41 ns | 0.3745 ns | 0.5940 ns | 17.76 ns |  1.08 |    0.04 | 0.0038 |     - |     - |      24 B |
                                            From_SByte |        net461 | 14.99 ns | 0.0659 ns | 0.0616 ns | 15.02 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_SByte |        net472 | 14.82 ns | 0.0253 ns | 0.0237 ns | 14.81 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 13.08 ns | 0.0997 ns | 0.0933 ns | 13.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 11.35 ns | 0.0162 ns | 0.0143 ns | 11.35 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 12.59 ns | 0.0168 ns | 0.0149 ns | 12.59 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 14.32 ns | 0.0308 ns | 0.0288 ns | 14.32 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 13.32 ns | 0.0797 ns | 0.0745 ns | 13.27 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 16.10 ns | 0.0323 ns | 0.0269 ns | 16.10 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 14.64 ns | 0.0271 ns | 0.0240 ns | 14.64 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 16.82 ns | 0.1062 ns | 0.0993 ns | 16.79 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue |        net461 | 14.82 ns | 0.0268 ns | 0.0238 ns | 14.82 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue |        net472 | 14.55 ns | 0.0227 ns | 0.0212 ns | 14.55 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.99 ns | 0.0108 ns | 0.0101 ns | 12.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.59 ns | 0.0126 ns | 0.0118 ns | 11.59 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.28 ns | 0.2617 ns | 0.3115 ns | 12.49 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 14.41 ns | 0.0641 ns | 0.0599 ns | 14.43 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 12.45 ns | 0.0066 ns | 0.0055 ns | 12.45 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.64 ns | 0.0164 ns | 0.0154 ns | 14.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 11.73 ns | 0.0140 ns | 0.0131 ns | 11.73 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 12.07 ns | 0.0687 ns | 0.0643 ns | 12.04 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.69 ns | 0.0096 ns | 0.0090 ns | 12.69 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.83 ns | 0.0138 ns | 0.0122 ns | 12.83 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.01 ns | 0.0649 ns | 0.0607 ns | 14.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.52 ns | 0.0142 ns | 0.0126 ns | 11.52 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.88 ns | 0.0228 ns | 0.0190 ns | 11.88 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 12.98 ns | 0.0119 ns | 0.0112 ns | 12.98 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.27 ns | 0.0127 ns | 0.0119 ns | 13.27 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 16.23 ns | 0.0614 ns | 0.0574 ns | 16.24 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 2.2 | 14.42 ns | 0.0439 ns | 0.0390 ns | 14.43 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 3.0 | 16.25 ns | 0.0667 ns | 0.0624 ns | 16.24 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net461 | 14.34 ns | 0.0359 ns | 0.0336 ns | 14.34 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net472 | 14.36 ns | 0.0819 ns | 0.0766 ns | 14.39 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 12.97 ns | 0.0092 ns | 0.0081 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 11.32 ns | 0.0107 ns | 0.0100 ns | 11.31 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 11.87 ns | 0.0238 ns | 0.0222 ns | 11.87 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 11.99 ns | 0.0114 ns | 0.0101 ns | 11.99 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 13.29 ns | 0.0095 ns | 0.0089 ns | 13.29 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 16.11 ns | 0.0342 ns | 0.0303 ns | 16.11 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 14.54 ns | 0.0236 ns | 0.0221 ns | 14.54 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 16.86 ns | 0.2569 ns | 0.2403 ns | 16.93 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net461 | 14.93 ns | 0.0530 ns | 0.0495 ns | 14.94 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net472 | 14.88 ns | 0.0288 ns | 0.0225 ns | 14.88 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.99 ns | 0.0163 ns | 0.0136 ns | 12.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.34 ns | 0.0114 ns | 0.0106 ns | 11.33 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.78 ns | 0.2992 ns | 0.3072 ns | 14.02 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 14.35 ns | 0.0131 ns | 0.0123 ns | 14.35 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 12.12 ns | 0.0168 ns | 0.0157 ns | 12.12 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 13.99 ns | 0.0708 ns | 0.0662 ns | 14.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 12.53 ns | 0.0119 ns | 0.0093 ns | 12.53 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 12.72 ns | 0.0499 ns | 0.0417 ns | 12.73 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.07 ns | 0.0169 ns | 0.0150 ns | 14.07 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.14 ns | 0.0172 ns | 0.0161 ns | 13.14 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.03 ns | 0.0132 ns | 0.0117 ns | 13.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.42 ns | 0.0130 ns | 0.0122 ns | 12.42 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.94 ns | 0.0285 ns | 0.0253 ns | 11.94 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 11.98 ns | 0.0200 ns | 0.0187 ns | 11.98 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 11.95 ns | 0.0770 ns | 0.0720 ns | 11.99 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 14.00 ns | 0.0247 ns | 0.0231 ns | 13.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 11.42 ns | 0.0133 ns | 0.0118 ns | 11.41 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 11.93 ns | 0.0750 ns | 0.0702 ns | 11.96 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 15.49 ns | 0.0152 ns | 0.0135 ns | 15.48 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 13.93 ns | 0.0153 ns | 0.0143 ns | 13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 13.80 ns | 0.2274 ns | 0.2127 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 11.42 ns | 0.0090 ns | 0.0075 ns | 11.42 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 12.56 ns | 0.0180 ns | 0.0168 ns | 12.55 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 11.95 ns | 0.0139 ns | 0.0130 ns | 11.95 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 11.89 ns | 0.0092 ns | 0.0086 ns | 11.89 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.56 ns | 0.0186 ns | 0.0174 ns | 13.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.37 ns | 0.0115 ns | 0.0102 ns | 12.37 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.86 ns | 0.0203 ns | 0.0189 ns | 11.87 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.22 ns | 0.2760 ns | 0.2582 ns | 15.28 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.11 ns | 0.0141 ns | 0.0132 ns | 12.10 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 12.96 ns | 0.0244 ns | 0.0228 ns | 12.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.45 ns | 0.0129 ns | 0.0114 ns | 11.45 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.97 ns | 0.3034 ns | 0.7151 ns | 14.22 ns |  1.01 |    0.09 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 12.04 ns | 0.0578 ns | 0.0541 ns | 12.05 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.27 ns | 0.0146 ns | 0.0136 ns | 13.26 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.96 ns | 0.0468 ns | 0.0391 ns | 13.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.33 ns | 0.0221 ns | 0.0196 ns | 11.32 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.86 ns | 0.0139 ns | 0.0116 ns | 11.86 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.42 ns | 0.0125 ns | 0.0117 ns | 12.42 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.36 ns | 0.0165 ns | 0.0138 ns | 12.36 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 | 12.95 ns | 0.0160 ns | 0.0125 ns | 12.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 | 12.07 ns | 0.1818 ns | 0.1701 ns | 12.07 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 | 14.37 ns | 0.2956 ns | 0.2765 ns | 14.30 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 | 14.31 ns | 0.0201 ns | 0.0188 ns | 14.31 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 | 11.90 ns | 0.0120 ns | 0.0107 ns | 11.90 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 15.63 ns | 0.0279 ns | 0.0247 ns | 15.63 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort | .NET Core 2.2 | 14.39 ns | 0.0264 ns | 0.0234 ns | 14.39 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort | .NET Core 3.0 | 15.21 ns | 0.0774 ns | 0.0724 ns | 15.17 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort |        net461 | 14.94 ns | 0.0801 ns | 0.0710 ns | 14.97 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort |        net472 | 14.89 ns | 0.0283 ns | 0.0265 ns | 14.89 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 12.96 ns | 0.0103 ns | 0.0092 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 11.50 ns | 0.0607 ns | 0.0568 ns | 11.52 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 12.07 ns | 0.0902 ns | 0.0843 ns | 12.11 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 11.97 ns | 0.0119 ns | 0.0111 ns | 11.97 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 13.30 ns | 0.1509 ns | 0.1412 ns | 13.22 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 16.06 ns | 0.0281 ns | 0.0263 ns | 16.07 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 14.59 ns | 0.0201 ns | 0.0168 ns | 14.58 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 15.25 ns | 0.0566 ns | 0.0502 ns | 15.25 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue |        net461 | 16.29 ns | 0.0433 ns | 0.0405 ns | 16.30 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue |        net472 | 14.75 ns | 0.0326 ns | 0.0289 ns | 14.74 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.99 ns | 0.0116 ns | 0.0091 ns | 12.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.43 ns | 0.0097 ns | 0.0090 ns | 11.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.84 ns | 0.0103 ns | 0.0080 ns | 11.84 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 22.30 ns | 0.0117 ns | 0.0109 ns | 22.30 ns |  1.72 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 13.42 ns | 0.0530 ns | 0.0496 ns | 13.44 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.04 ns | 0.0154 ns | 0.0136 ns | 14.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.72 ns | 0.0086 ns | 0.0080 ns | 11.72 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 12.62 ns | 0.0137 ns | 0.0122 ns | 12.62 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.55 ns | 0.0841 ns | 0.0787 ns | 12.50 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.59 ns | 0.0146 ns | 0.0136 ns | 12.59 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.15 ns | 0.0249 ns | 0.0221 ns | 13.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.33 ns | 0.0170 ns | 0.0159 ns | 11.33 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.47 ns | 0.1975 ns | 0.1848 ns | 12.46 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.41 ns | 0.0213 ns | 0.0189 ns | 14.41 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.56 ns | 0.0879 ns | 0.0822 ns | 14.61 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 15.65 ns | 0.0316 ns | 0.0296 ns | 15.65 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt | .NET Core 2.2 | 16.30 ns | 0.0569 ns | 0.0533 ns | 16.30 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt | .NET Core 3.0 | 18.27 ns | 0.0500 ns | 0.0468 ns | 18.26 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt |        net461 | 14.84 ns | 0.0286 ns | 0.0239 ns | 14.82 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt |        net472 | 14.79 ns | 0.0303 ns | 0.0283 ns | 14.78 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 13.14 ns | 0.0162 ns | 0.0151 ns | 13.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 11.32 ns | 0.0111 ns | 0.0104 ns | 11.32 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 12.60 ns | 0.0184 ns | 0.0172 ns | 12.60 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 12.16 ns | 0.0467 ns | 0.0414 ns | 12.17 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 13.34 ns | 0.1014 ns | 0.0948 ns | 13.29 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 16.46 ns | 0.0290 ns | 0.0257 ns | 16.45 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 15.28 ns | 0.0249 ns | 0.0221 ns | 15.28 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 16.17 ns | 0.0602 ns | 0.0503 ns | 16.17 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue |        net461 | 14.76 ns | 0.0147 ns | 0.0130 ns | 14.76 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue |        net472 | 14.78 ns | 0.0326 ns | 0.0272 ns | 14.77 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.35 ns | 0.1073 ns | 0.1004 ns | 13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.36 ns | 0.0111 ns | 0.0104 ns | 12.36 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.12 ns | 0.3628 ns | 0.4318 ns | 11.88 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 12.07 ns | 0.0712 ns | 0.0666 ns | 12.02 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 14.39 ns | 0.0127 ns | 0.0113 ns | 14.39 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.90 ns | 0.0184 ns | 0.0163 ns | 13.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.74 ns | 0.0105 ns | 0.0098 ns | 11.74 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 13.53 ns | 0.0923 ns | 0.0863 ns | 13.48 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.93 ns | 0.0144 ns | 0.0128 ns | 13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.28 ns | 0.0606 ns | 0.0537 ns | 13.26 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.42 ns | 0.1198 ns | 0.1121 ns | 13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0117 ns | 0.0110 ns | 11.43 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.74 ns | 0.1991 ns | 0.1862 ns | 12.64 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 12.01 ns | 0.0080 ns | 0.0071 ns | 12.02 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 11.99 ns | 0.0266 ns | 0.0249 ns | 11.99 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 15.65 ns | 0.0254 ns | 0.0238 ns | 15.65 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong | .NET Core 2.2 | 14.39 ns | 0.0273 ns | 0.0242 ns | 14.39 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong | .NET Core 3.0 | 18.58 ns | 0.3919 ns | 0.5365 ns | 18.28 ns |  1.20 |    0.04 | 0.0038 |     - |     - |      24 B |
                                            From_ULong |        net461 | 15.04 ns | 0.0295 ns | 0.0261 ns | 15.03 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong |        net472 | 15.42 ns | 0.0210 ns | 0.0197 ns | 15.42 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 13.24 ns | 0.0144 ns | 0.0127 ns | 13.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 11.52 ns | 0.0496 ns | 0.0464 ns | 11.54 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 13.95 ns | 0.0473 ns | 0.0443 ns | 13.96 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 12.00 ns | 0.0134 ns | 0.0125 ns | 12.00 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 13.56 ns | 0.0115 ns | 0.0108 ns | 13.56 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 17.68 ns | 0.0276 ns | 0.0258 ns | 17.68 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 14.91 ns | 0.0280 ns | 0.0218 ns | 14.90 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 18.91 ns | 0.0228 ns | 0.0190 ns | 18.91 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue |        net461 | 17.80 ns | 0.1332 ns | 0.1246 ns | 17.75 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue |        net472 | 16.67 ns | 0.0249 ns | 0.0208 ns | 16.68 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.95 ns | 0.0139 ns | 0.0123 ns | 12.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.39 ns | 0.0169 ns | 0.0150 ns | 11.39 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.04 ns | 0.0888 ns | 0.0830 ns | 12.07 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 11.95 ns | 0.0166 ns | 0.0147 ns | 11.95 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 13.58 ns | 0.0124 ns | 0.0110 ns | 13.58 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.77 ns | 0.0133 ns | 0.0111 ns | 14.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 14.64 ns | 0.1331 ns | 0.1245 ns | 14.64 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 13.35 ns | 0.0816 ns | 0.0764 ns | 13.31 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.59 ns | 0.0138 ns | 0.0129 ns | 13.59 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.67 ns | 0.0948 ns | 0.0840 ns | 13.67 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.96 ns | 0.0139 ns | 0.0130 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.99 ns | 0.0098 ns | 0.0087 ns | 11.99 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.30 ns | 0.0125 ns | 0.0104 ns | 12.30 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 12.07 ns | 0.0117 ns | 0.0109 ns | 12.07 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.38 ns | 0.0104 ns | 0.0098 ns | 13.38 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.98 ns | 0.0235 ns | 0.0219 ns | 13.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.41 ns | 0.0451 ns | 0.0422 ns | 12.42 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.89 ns | 0.0102 ns | 0.0091 ns | 11.88 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 11.96 ns | 0.0097 ns | 0.0091 ns | 11.96 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 12.68 ns | 0.0125 ns | 0.0111 ns | 12.68 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 14.01 ns | 0.0431 ns | 0.0382 ns | 14.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.18 ns | 0.0181 ns | 0.0161 ns | 11.18 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.00 ns | 0.0180 ns | 0.0169 ns | 12.00 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.64 ns | 0.0160 ns | 0.0149 ns | 12.64 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.49 ns | 0.0222 ns | 0.0196 ns | 12.48 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.08 ns | 0.0190 ns | 0.0158 ns | 13.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.43 ns | 0.0116 ns | 0.0108 ns | 11.44 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.95 ns | 0.0243 ns | 0.0190 ns | 11.94 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 11.95 ns | 0.0140 ns | 0.0131 ns | 11.94 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.74 ns | 0.0080 ns | 0.0070 ns | 13.74 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 13.47 ns | 0.1041 ns | 0.0973 ns | 13.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 11.33 ns | 0.0158 ns | 0.0140 ns | 11.33 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.04 ns | 0.0431 ns | 0.0403 ns | 14.05 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 14.01 ns | 0.0212 ns | 0.0198 ns | 14.02 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 13.97 ns | 0.0199 ns | 0.0186 ns | 13.97 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 13.03 ns | 0.0131 ns | 0.0123 ns | 13.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 11.46 ns | 0.0162 ns | 0.0152 ns | 11.45 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 12.22 ns | 0.2472 ns | 0.2313 ns | 12.37 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 11.95 ns | 0.0153 ns | 0.0143 ns | 11.96 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 11.91 ns | 0.0174 ns | 0.0154 ns | 11.91 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.69 ns | 0.0259 ns | 0.0242 ns | 13.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.40 ns | 0.0324 ns | 0.0303 ns | 11.41 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.94 ns | 0.0656 ns | 0.0613 ns | 11.99 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.50 ns | 0.0293 ns | 0.0260 ns | 13.49 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.53 ns | 0.0370 ns | 0.0328 ns | 13.54 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.18 ns | 0.0140 ns | 0.0131 ns | 15.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.33 ns | 0.0137 ns | 0.0121 ns | 11.33 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.97 ns | 0.0238 ns | 0.0223 ns | 11.97 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 12.02 ns | 0.0689 ns | 0.0645 ns | 12.06 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 11.92 ns | 0.0085 ns | 0.0075 ns | 11.92 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 15.55 ns | 0.0273 ns | 0.0256 ns | 15.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.42 ns | 0.0106 ns | 0.0094 ns | 11.42 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.83 ns | 0.0149 ns | 0.0116 ns | 11.84 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.41 ns | 0.0092 ns | 0.0086 ns | 12.41 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.06 ns | 0.2883 ns | 0.3085 ns | 14.08 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 13.70 ns | 0.1502 ns | 0.1405 ns | 13.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 12.17 ns | 0.1510 ns | 0.1412 ns | 12.19 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 11.87 ns | 0.0207 ns | 0.0162 ns | 11.87 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 13.61 ns | 0.0190 ns | 0.0178 ns | 13.61 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 11.98 ns | 0.0130 ns | 0.0121 ns | 11.98 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.55 ns | 0.0102 ns | 0.0095 ns | 12.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.43 ns | 0.0174 ns | 0.0162 ns | 11.43 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.93 ns | 0.0959 ns | 0.0897 ns | 11.88 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 11.98 ns | 0.0225 ns | 0.0210 ns | 11.98 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 11.97 ns | 0.0105 ns | 0.0098 ns | 11.96 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.19 ns | 0.0398 ns | 0.0372 ns | 13.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.49 ns | 0.0434 ns | 0.0406 ns | 11.51 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.86 ns | 0.0155 ns | 0.0121 ns | 11.86 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.26 ns | 0.0238 ns | 0.0211 ns | 14.26 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.45 ns | 0.0422 ns | 0.0352 ns | 13.46 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 16.25 ns | 0.0204 ns | 0.0181 ns | 16.25 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.05 ns | 0.0206 ns | 0.0172 ns | 15.06 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 16.38 ns | 0.3459 ns | 0.5779 ns | 16.73 ns |  0.97 |    0.04 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.04 ns | 0.1086 ns | 0.1016 ns | 15.98 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 14.15 ns | 0.0312 ns | 0.0277 ns | 14.15 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 14.71 ns | 0.0137 ns | 0.0128 ns | 14.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 11.33 ns | 0.0101 ns | 0.0089 ns | 11.33 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 11.86 ns | 0.0171 ns | 0.0160 ns | 11.86 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 12.02 ns | 0.0133 ns | 0.0125 ns | 12.01 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 13.04 ns | 0.0095 ns | 0.0074 ns | 13.03 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 16.37 ns | 0.0237 ns | 0.0221 ns | 16.36 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.33 ns | 0.0258 ns | 0.0241 ns | 15.32 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 17.22 ns | 0.1297 ns | 0.1213 ns | 17.18 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 14.41 ns | 0.0426 ns | 0.0333 ns | 14.41 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 14.44 ns | 0.0219 ns | 0.0194 ns | 14.44 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.98 ns | 0.0327 ns | 0.0306 ns | 12.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.32 ns | 0.0141 ns | 0.0125 ns | 11.32 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.88 ns | 0.0145 ns | 0.0129 ns | 11.87 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 12.07 ns | 0.0373 ns | 0.0349 ns | 12.07 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 13.67 ns | 0.0109 ns | 0.0102 ns | 13.67 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.93 ns | 0.0192 ns | 0.0170 ns | 13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.48 ns | 0.0248 ns | 0.0232 ns | 12.48 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 13.39 ns | 0.0176 ns | 0.0147 ns | 13.39 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.81 ns | 0.0247 ns | 0.0231 ns | 13.81 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 12.62 ns | 0.0365 ns | 0.0323 ns | 12.63 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.90 ns | 0.0196 ns | 0.0164 ns | 13.91 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0125 ns | 0.0111 ns | 11.42 ns |  0.82 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.23 ns | 0.2601 ns | 0.2783 ns | 12.05 ns |  0.89 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.44 ns | 0.0577 ns | 0.0539 ns | 14.46 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 11.92 ns | 0.0086 ns | 0.0076 ns | 11.92 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 15.12 ns | 0.2229 ns | 0.2085 ns | 15.10 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 2.2 | 15.13 ns | 0.0422 ns | 0.0395 ns | 15.11 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 3.0 | 17.04 ns | 0.3273 ns | 0.3062 ns | 17.28 ns |  1.13 |    0.03 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net461 | 14.72 ns | 0.0315 ns | 0.0294 ns | 14.73 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net472 | 15.97 ns | 0.0372 ns | 0.0348 ns | 15.96 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 12.97 ns | 0.0229 ns | 0.0214 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 11.42 ns | 0.0095 ns | 0.0084 ns | 11.42 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 12.65 ns | 0.2733 ns | 0.2684 ns | 12.68 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.51 ns | 0.0225 ns | 0.0199 ns | 14.51 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 13.32 ns | 0.0149 ns | 0.0140 ns | 13.32 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 16.22 ns | 0.0372 ns | 0.0348 ns | 16.22 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.31 ns | 0.0216 ns | 0.0191 ns | 15.31 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 16.31 ns | 0.1062 ns | 0.0993 ns | 16.30 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 16.12 ns | 0.0320 ns | 0.0299 ns | 16.11 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 15.30 ns | 0.0416 ns | 0.0389 ns | 15.30 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.75 ns | 0.0585 ns | 0.0547 ns | 13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.33 ns | 0.0137 ns | 0.0128 ns | 11.32 ns |  0.82 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.87 ns | 0.0129 ns | 0.0121 ns | 11.87 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 11.95 ns | 0.0120 ns | 0.0112 ns | 11.96 ns |  0.87 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 13.29 ns | 0.0179 ns | 0.0159 ns | 13.29 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.07 ns | 0.0131 ns | 0.0116 ns | 13.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.45 ns | 0.0217 ns | 0.0181 ns | 12.45 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 12.78 ns | 0.1062 ns | 0.0993 ns | 12.83 ns |  0.98 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.46 ns | 0.0092 ns | 0.0077 ns | 12.46 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 14.20 ns | 0.0127 ns | 0.0119 ns | 14.20 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.11 ns | 0.0512 ns | 0.0479 ns | 13.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.33 ns | 0.0184 ns | 0.0172 ns | 11.33 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.88 ns | 0.0124 ns | 0.0116 ns | 11.89 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.33 ns | 0.0268 ns | 0.0250 ns | 14.33 ns |  1.09 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.28 ns | 0.0192 ns | 0.0179 ns | 13.27 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.76 ns | 0.0307 ns | 0.0287 ns | 14.77 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 2.2 | 14.39 ns | 0.0260 ns | 0.0243 ns | 14.39 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 3.0 | 16.89 ns | 0.3583 ns | 0.4783 ns | 16.60 ns |  1.16 |    0.04 | 0.0038 |     - |     - |      24 B |
                                             From_Enum |        net461 | 15.89 ns | 0.0982 ns | 0.0918 ns | 15.92 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Enum |        net472 | 14.87 ns | 0.0254 ns | 0.0238 ns | 14.87 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 12.96 ns | 0.0183 ns | 0.0163 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 | 11.43 ns | 0.0198 ns | 0.0175 ns | 11.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 | 11.93 ns | 0.0278 ns | 0.0246 ns | 11.93 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 12.35 ns | 0.0145 ns | 0.0135 ns | 12.35 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 | 11.90 ns | 0.0208 ns | 0.0185 ns | 11.91 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.93 ns | 0.0271 ns | 0.0254 ns | 15.93 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 15.38 ns | 0.0305 ns | 0.0285 ns | 15.39 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 15.41 ns | 0.0569 ns | 0.0532 ns | 15.40 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue |        net461 | 16.07 ns | 0.0260 ns | 0.0231 ns | 16.06 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue |        net472 | 14.43 ns | 0.0218 ns | 0.0204 ns | 14.43 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.99 ns | 0.0113 ns | 0.0106 ns | 12.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0150 ns | 0.0141 ns | 11.42 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.28 ns | 0.0334 ns | 0.0279 ns | 12.28 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 11.94 ns | 0.0103 ns | 0.0096 ns | 11.94 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 13.43 ns | 0.0489 ns | 0.0433 ns | 13.44 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.92 ns | 0.0177 ns | 0.0166 ns | 13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.41 ns | 0.0190 ns | 0.0168 ns | 12.41 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 12.72 ns | 0.0130 ns | 0.0122 ns | 12.72 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.81 ns | 0.0264 ns | 0.0206 ns | 13.81 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.48 ns | 0.0130 ns | 0.0121 ns | 12.48 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.13 ns | 0.0196 ns | 0.0183 ns | 13.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.33 ns | 0.0143 ns | 0.0134 ns | 11.33 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.91 ns | 0.0449 ns | 0.0420 ns | 11.89 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 12.98 ns | 0.0190 ns | 0.0168 ns | 12.98 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 11.89 ns | 0.0176 ns | 0.0164 ns | 11.88 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.93 ns | 0.0468 ns | 0.0438 ns | 13.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.38 ns | 0.0094 ns | 0.0083 ns | 11.38 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.44 ns | 0.2617 ns | 0.2800 ns | 12.58 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.98 ns | 0.0117 ns | 0.0109 ns | 14.98 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.92 ns | 0.0188 ns | 0.0176 ns | 13.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 13.77 ns | 0.0159 ns | 0.0141 ns | 13.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 11.32 ns | 0.0113 ns | 0.0105 ns | 11.32 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 12.51 ns | 0.1577 ns | 0.1476 ns | 12.50 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 11.99 ns | 0.0803 ns | 0.0751 ns | 11.95 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 13.42 ns | 0.0410 ns | 0.0384 ns | 13.43 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.37 ns | 0.0198 ns | 0.0185 ns | 13.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.42 ns | 0.0145 ns | 0.0129 ns | 11.41 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.19 ns | 0.2460 ns | 0.2301 ns | 12.28 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.01 ns | 0.0174 ns | 0.0154 ns | 12.01 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 11.95 ns | 0.0129 ns | 0.0114 ns | 11.96 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.11 ns | 0.0178 ns | 0.0167 ns | 13.10 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 11.42 ns | 0.0109 ns | 0.0102 ns | 11.42 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.89 ns | 0.0145 ns | 0.0121 ns | 11.88 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.35 ns | 0.0916 ns | 0.0857 ns | 14.32 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 11.90 ns | 0.0171 ns | 0.0152 ns | 11.90 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 82.93 ns | 0.4330 ns | 0.3839 ns | 83.04 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 | 82.48 ns | 0.2738 ns | 0.2427 ns | 82.48 ns |  0.99 |    0.01 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 | 89.07 ns | 1.0781 ns | 1.0085 ns | 88.72 ns |  1.07 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 | 80.37 ns | 0.1517 ns | 0.1419 ns | 80.32 ns |  0.97 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 80.12 ns | 0.1460 ns | 0.1365 ns | 80.13 ns |  0.97 |    0.01 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 12.99 ns | 0.0142 ns | 0.0133 ns | 12.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 12.00 ns | 0.0243 ns | 0.0227 ns | 12.00 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 11.87 ns | 0.0111 ns | 0.0098 ns | 11.87 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 12.51 ns | 0.0087 ns | 0.0082 ns | 12.50 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 11.97 ns | 0.0089 ns | 0.0079 ns | 11.97 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 81.35 ns | 0.2836 ns | 0.2368 ns | 81.34 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 81.94 ns | 0.1494 ns | 0.1324 ns | 81.93 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 91.25 ns | 0.8342 ns | 0.7803 ns | 91.55 ns |  1.12 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 83.84 ns | 0.4121 ns | 0.3855 ns | 83.92 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 81.81 ns | 0.1218 ns | 0.1139 ns | 81.77 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.96 ns | 0.0167 ns | 0.0131 ns | 12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.50 ns | 0.0130 ns | 0.0121 ns | 11.50 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.17 ns | 0.2625 ns | 0.2696 ns | 12.33 ns |  0.93 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 11.95 ns | 0.0090 ns | 0.0084 ns | 11.95 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 11.89 ns | 0.0139 ns | 0.0123 ns | 11.89 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 41.75 ns | 0.0335 ns | 0.0313 ns | 41.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 42.05 ns | 0.0452 ns | 0.0401 ns | 42.05 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 44.05 ns | 0.0717 ns | 0.0635 ns | 44.03 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 43.30 ns | 0.2834 ns | 0.2651 ns | 43.20 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 44.33 ns | 0.1121 ns | 0.0993 ns | 44.31 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.15 ns | 0.0120 ns | 0.0106 ns | 13.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.46 ns | 0.0113 ns | 0.0095 ns | 11.46 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.16 ns | 0.3309 ns | 0.5248 ns | 11.87 ns |  0.95 |    0.05 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.31 ns | 0.0181 ns | 0.0170 ns | 14.31 ns |  1.09 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.34 ns | 0.0710 ns | 0.0664 ns | 13.38 ns |  1.01 |    0.01 |      - |     - |     - |         - |
