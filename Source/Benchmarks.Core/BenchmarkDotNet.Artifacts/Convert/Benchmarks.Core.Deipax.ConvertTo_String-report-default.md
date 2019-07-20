
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
                                             From_Bool | .NET Core 2.0 |  14.78 ns | 0.0264 ns | 0.0247 ns |  14.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  15.65 ns | 0.0087 ns | 0.0082 ns |  15.65 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  14.16 ns | 0.0803 ns | 0.0751 ns |  14.19 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  13.30 ns | 0.0167 ns | 0.0139 ns |  13.30 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  13.63 ns | 0.0871 ns | 0.0815 ns |  13.68 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  17.33 ns | 0.0147 ns | 0.0130 ns |  17.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  15.89 ns | 0.0227 ns | 0.0212 ns |  15.88 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  17.01 ns | 0.3595 ns | 0.5490 ns |  16.58 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  17.99 ns | 0.0620 ns | 0.0550 ns |  17.98 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  19.81 ns | 0.0178 ns | 0.0166 ns |  19.81 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  13.91 ns | 0.0931 ns | 0.0871 ns |  13.86 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  13.44 ns | 0.0691 ns | 0.0647 ns |  13.47 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  13.90 ns | 0.0814 ns | 0.0762 ns |  13.94 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  15.94 ns | 0.0668 ns | 0.0592 ns |  15.95 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  16.07 ns | 0.0221 ns | 0.0185 ns |  16.08 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  17.74 ns | 0.0500 ns | 0.0467 ns |  17.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  17.84 ns | 0.0243 ns | 0.0227 ns |  17.84 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  16.72 ns | 0.0702 ns | 0.0657 ns |  16.69 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  19.32 ns | 0.0337 ns | 0.0281 ns |  19.31 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  19.91 ns | 0.0565 ns | 0.0528 ns |  19.92 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  12.87 ns | 0.0129 ns | 0.0121 ns |  12.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  11.74 ns | 0.0969 ns | 0.0906 ns |  11.74 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  13.09 ns | 0.2742 ns | 0.2816 ns |  12.91 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  14.55 ns | 0.0155 ns | 0.0145 ns |  14.55 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  13.98 ns | 0.2681 ns | 0.2508 ns |  13.95 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.44 ns | 0.0653 ns | 0.0611 ns |  13.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.33 ns | 0.0172 ns | 0.0161 ns |  14.32 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.64 ns | 0.0609 ns | 0.0540 ns |  13.64 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0187 ns | 0.0175 ns |  13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  13.39 ns | 0.0202 ns | 0.0179 ns |  13.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  46.48 ns | 0.0583 ns | 0.0546 ns |  46.50 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 2.2 |  30.66 ns | 0.0505 ns | 0.0473 ns |  30.66 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 3.0 |  24.33 ns | 0.1337 ns | 0.1250 ns |  24.39 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  48.53 ns | 0.2423 ns | 0.2267 ns |  48.66 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte |        net472 |  48.84 ns | 0.2659 ns | 0.2487 ns |  48.92 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  51.11 ns | 0.3398 ns | 0.3179 ns |  50.94 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 2.2 |  35.48 ns | 0.1895 ns | 0.1772 ns |  35.55 ns |  0.69 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 3.0 |  31.17 ns | 0.1100 ns | 0.0975 ns |  31.16 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  59.47 ns | 0.0920 ns | 0.0816 ns |  59.45 ns |  1.16 |    0.01 | 0.0050 |     - |     - |      32 B |
                                    From_Byte_AsObject |        net472 |  57.33 ns | 0.0407 ns | 0.0381 ns |  57.35 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  48.91 ns | 0.0968 ns | 0.0905 ns |  48.89 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  28.63 ns | 0.0861 ns | 0.0806 ns |  28.62 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  24.46 ns | 0.0584 ns | 0.0518 ns |  24.48 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  49.51 ns | 0.5475 ns | 0.5122 ns |  49.20 ns |  1.01 |    0.01 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue |        net472 |  52.10 ns | 0.0727 ns | 0.0607 ns |  52.10 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.86 ns | 0.0588 ns | 0.0550 ns |  50.87 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.67 ns | 0.0528 ns | 0.0494 ns |  33.66 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.95 ns | 0.1950 ns | 0.1628 ns |  30.99 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  60.08 ns | 0.2750 ns | 0.2437 ns |  60.02 ns |  1.18 |    0.01 | 0.0050 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  56.61 ns | 0.1106 ns | 0.1034 ns |  56.57 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  13.03 ns | 0.0103 ns | 0.0091 ns |  13.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  12.44 ns | 0.0175 ns | 0.0164 ns |  12.44 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  12.47 ns | 0.0584 ns | 0.0546 ns |  12.44 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  14.89 ns | 0.0177 ns | 0.0157 ns |  14.89 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  14.03 ns | 0.0740 ns | 0.0692 ns |  14.06 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.31 ns | 0.0159 ns | 0.0133 ns |  13.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.80 ns | 0.0098 ns | 0.0091 ns |  12.80 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.05 ns | 0.1941 ns | 0.1815 ns |  13.10 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  14.60 ns | 0.0182 ns | 0.0152 ns |  14.60 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  14.61 ns | 0.0168 ns | 0.0140 ns |  14.61 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  15.90 ns | 0.1037 ns | 0.0919 ns |  15.92 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 2.2 |  19.63 ns | 0.5514 ns | 0.5662 ns |  19.35 ns |  1.24 |    0.04 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 3.0 |  16.04 ns | 0.0431 ns | 0.0403 ns |  16.05 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net461 |  17.35 ns | 0.0241 ns | 0.0202 ns |  17.35 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                                             From_Char |        net472 |  17.32 ns | 0.0445 ns | 0.0416 ns |  17.32 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  21.71 ns | 0.0254 ns | 0.0225 ns |  21.70 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 2.2 |  20.73 ns | 0.0253 ns | 0.0237 ns |  20.72 ns |  0.96 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 3.0 |  21.65 ns | 0.3814 ns | 0.3568 ns |  21.75 ns |  1.00 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Char_AsObject |        net461 |  23.91 ns | 0.0984 ns | 0.0921 ns |  23.95 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject |        net472 |  25.11 ns | 0.1613 ns | 0.1429 ns |  25.12 ns |  1.16 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  16.06 ns | 0.0271 ns | 0.0254 ns |  16.07 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  15.55 ns | 0.0271 ns | 0.0254 ns |  15.54 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  16.50 ns | 0.0672 ns | 0.0629 ns |  16.52 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net461 |  19.43 ns | 0.0315 ns | 0.0280 ns |  19.44 ns |  1.21 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue |        net472 |  21.08 ns | 0.0540 ns | 0.0451 ns |  21.07 ns |  1.31 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  21.93 ns | 0.0436 ns | 0.0386 ns |  21.93 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  20.65 ns | 0.0220 ns | 0.0195 ns |  20.64 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  19.85 ns | 0.0536 ns | 0.0501 ns |  19.84 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  24.70 ns | 0.0352 ns | 0.0312 ns |  24.70 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  22.73 ns | 0.0974 ns | 0.0863 ns |  22.70 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  13.10 ns | 0.0756 ns | 0.0707 ns |  13.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  11.72 ns | 0.0115 ns | 0.0107 ns |  11.72 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  12.99 ns | 0.0325 ns | 0.0304 ns |  12.99 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  13.24 ns | 0.0262 ns | 0.0245 ns |  13.23 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  13.24 ns | 0.0074 ns | 0.0070 ns |  13.24 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.96 ns | 0.0089 ns | 0.0083 ns |  13.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.38 ns | 0.0153 ns | 0.0143 ns |  14.38 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.78 ns | 0.0200 ns | 0.0187 ns |  12.78 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  13.46 ns | 0.0128 ns | 0.0120 ns |  13.46 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  14.60 ns | 0.0207 ns | 0.0194 ns |  14.60 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 330.85 ns | 0.6522 ns | 0.6100 ns | 330.91 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 2.2 | 289.38 ns | 0.5543 ns | 0.4629 ns | 289.37 ns |  0.87 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 3.0 | 236.62 ns | 0.2996 ns | 0.2502 ns | 236.65 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
                                         From_DateTime |        net461 | 348.98 ns | 0.7240 ns | 0.6773 ns | 348.87 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                                         From_DateTime |        net472 | 344.38 ns | 0.7346 ns | 0.6512 ns | 344.33 ns |  1.04 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 338.65 ns | 0.3751 ns | 0.3325 ns | 338.58 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 2.2 | 291.99 ns | 0.4272 ns | 0.3996 ns | 292.08 ns |  0.86 |    0.00 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 3.0 | 234.81 ns | 0.6238 ns | 0.5530 ns | 234.69 ns |  0.69 |    0.00 | 0.0100 |     - |     - |      64 B |
                                From_DateTime_AsObject |        net461 | 351.10 ns | 0.4970 ns | 0.4649 ns | 351.16 ns |  1.04 |    0.00 | 0.0300 |     - |     - |     192 B |
                                From_DateTime_AsObject |        net472 | 348.98 ns | 0.3873 ns | 0.3623 ns | 348.96 ns |  1.03 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 330.25 ns | 0.3941 ns | 0.3493 ns | 330.20 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 288.00 ns | 0.5808 ns | 0.5149 ns | 288.01 ns |  0.87 |    0.00 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 240.84 ns | 0.2222 ns | 0.1734 ns | 240.87 ns |  0.73 |    0.00 | 0.0100 |     - |     - |      64 B |
                      From_DateTime_Nullable_WithValue |        net461 | 346.72 ns | 0.5594 ns | 0.5233 ns | 346.44 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                      From_DateTime_Nullable_WithValue |        net472 | 347.73 ns | 0.5623 ns | 0.4985 ns | 347.61 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 327.50 ns | 0.2996 ns | 0.2802 ns | 327.54 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 297.76 ns | 1.9859 ns | 1.8576 ns | 296.97 ns |  0.91 |    0.01 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 235.81 ns | 0.9554 ns | 0.8937 ns | 235.48 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 347.14 ns | 0.6070 ns | 0.4739 ns | 347.06 ns |  1.06 |    0.00 | 0.0300 |     - |     - |     192 B |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 351.58 ns | 3.1721 ns | 2.9672 ns | 353.40 ns |  1.07 |    0.01 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  13.32 ns | 0.0114 ns | 0.0107 ns |  13.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  12.37 ns | 0.0200 ns | 0.0187 ns |  12.36 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  14.21 ns | 0.0530 ns | 0.0470 ns |  14.21 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  14.36 ns | 0.0269 ns | 0.0251 ns |  14.36 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  14.44 ns | 0.0142 ns | 0.0126 ns |  14.44 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.84 ns | 0.0205 ns | 0.0191 ns |  13.85 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.29 ns | 0.0163 ns | 0.0128 ns |  12.29 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.95 ns | 0.2255 ns | 0.2110 ns |  12.81 ns |  0.94 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0191 ns | 0.0178 ns |  13.40 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  14.76 ns | 0.0201 ns | 0.0178 ns |  14.76 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  63.73 ns | 0.1593 ns | 0.1331 ns |  63.73 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 2.2 |  60.45 ns | 0.1072 ns | 0.1003 ns |  60.42 ns |  0.95 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 3.0 |  56.40 ns | 0.2099 ns | 0.1963 ns |  56.35 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                          From_Decimal |        net461 |  64.25 ns | 0.4030 ns | 0.3770 ns |  64.31 ns |  1.01 |    0.01 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal |        net472 |  62.29 ns | 0.1382 ns | 0.1225 ns |  62.26 ns |  0.98 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  67.48 ns | 0.1465 ns | 0.1299 ns |  67.45 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 2.2 |  59.61 ns | 0.1508 ns | 0.1337 ns |  59.63 ns |  0.88 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 3.0 |  60.53 ns | 0.1665 ns | 0.1557 ns |  60.52 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                 From_Decimal_AsObject |        net461 |  66.50 ns | 0.1979 ns | 0.1851 ns |  66.45 ns |  0.99 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject |        net472 |  67.02 ns | 0.0720 ns | 0.0601 ns |  67.03 ns |  0.99 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  65.41 ns | 0.2389 ns | 0.2234 ns |  65.48 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  60.26 ns | 0.2128 ns | 0.1991 ns |  60.27 ns |  0.92 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  55.69 ns | 0.2058 ns | 0.1925 ns |  55.67 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                       From_Decimal_Nullable_WithValue |        net461 |  63.70 ns | 0.2559 ns | 0.2268 ns |  63.63 ns |  0.97 |    0.01 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net472 |  63.40 ns | 0.0974 ns | 0.0911 ns |  63.42 ns |  0.97 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  67.28 ns | 0.1177 ns | 0.0983 ns |  67.26 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  59.76 ns | 0.1187 ns | 0.1110 ns |  59.78 ns |  0.89 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  61.22 ns | 0.2995 ns | 0.2802 ns |  61.28 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  66.22 ns | 0.1064 ns | 0.0889 ns |  66.26 ns |  0.98 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  66.10 ns | 0.2936 ns | 0.2603 ns |  66.16 ns |  0.98 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  13.24 ns | 0.0154 ns | 0.0120 ns |  13.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  18.10 ns | 0.1575 ns | 0.1473 ns |  18.12 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  14.00 ns | 0.2360 ns | 0.2207 ns |  13.94 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  14.29 ns | 0.0205 ns | 0.0160 ns |  14.29 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  14.63 ns | 0.2685 ns | 0.2512 ns |  14.57 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.69 ns | 0.0196 ns | 0.0164 ns |  13.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.99 ns | 0.0348 ns | 0.0325 ns |  14.00 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.78 ns | 0.0113 ns | 0.0100 ns |  12.78 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  13.37 ns | 0.0100 ns | 0.0094 ns |  13.37 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  15.42 ns | 0.0242 ns | 0.0226 ns |  15.42 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 205.81 ns | 0.2925 ns | 0.2593 ns | 205.81 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 2.2 | 124.05 ns | 0.2864 ns | 0.2679 ns | 124.00 ns |  0.60 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 3.0 | 123.58 ns | 0.2972 ns | 0.2780 ns | 123.58 ns |  0.60 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net461 | 319.36 ns | 1.3139 ns | 1.1648 ns | 319.68 ns |  1.55 |    0.01 | 0.0048 |     - |     - |      32 B |
                                           From_Double |        net472 | 313.91 ns | 0.3672 ns | 0.3434 ns | 313.93 ns |  1.53 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 214.25 ns | 0.1991 ns | 0.1862 ns | 214.19 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 2.2 | 130.54 ns | 0.7430 ns | 0.6950 ns | 130.28 ns |  0.61 |    0.00 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 3.0 | 130.93 ns | 0.2462 ns | 0.2303 ns | 130.89 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                  From_Double_AsObject |        net461 | 321.19 ns | 0.5400 ns | 0.5051 ns | 321.15 ns |  1.50 |    0.00 | 0.0048 |     - |     - |      32 B |
                                  From_Double_AsObject |        net472 | 317.25 ns | 0.2839 ns | 0.2517 ns | 317.18 ns |  1.48 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 210.42 ns | 0.3485 ns | 0.3260 ns | 210.38 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 123.04 ns | 0.1999 ns | 0.1870 ns | 123.03 ns |  0.58 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 126.60 ns | 0.5910 ns | 0.5529 ns | 126.93 ns |  0.60 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net461 | 314.10 ns | 2.3853 ns | 2.2312 ns | 312.80 ns |  1.49 |    0.01 | 0.0048 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue |        net472 | 317.72 ns | 0.5970 ns | 0.5292 ns | 317.76 ns |  1.51 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 214.06 ns | 0.3122 ns | 0.2920 ns | 214.04 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 129.19 ns | 0.1089 ns | 0.0909 ns | 129.18 ns |  0.60 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 131.21 ns | 0.6244 ns | 0.5841 ns | 130.97 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
               From_Double_Nullable_WithValue_AsObject |        net461 | 316.35 ns | 0.3519 ns | 0.3292 ns | 316.39 ns |  1.48 |    0.00 | 0.0048 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject |        net472 | 317.06 ns | 0.2957 ns | 0.2766 ns | 317.03 ns |  1.48 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  13.46 ns | 0.0086 ns | 0.0072 ns |  13.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  12.18 ns | 0.0302 ns | 0.0282 ns |  12.18 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  13.84 ns | 0.0421 ns | 0.0394 ns |  13.84 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  14.28 ns | 0.0153 ns | 0.0136 ns |  14.28 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  16.54 ns | 0.3321 ns | 0.3261 ns |  16.57 ns |  1.23 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.33 ns | 0.0148 ns | 0.0139 ns |  13.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.37 ns | 0.0257 ns | 0.0240 ns |  14.37 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.09 ns | 0.0238 ns | 0.0223 ns |  13.09 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  14.63 ns | 0.0301 ns | 0.0282 ns |  14.62 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  13.60 ns | 0.0954 ns | 0.0892 ns |  13.67 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  46.29 ns | 0.1022 ns | 0.0956 ns |  46.28 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 2.2 |  29.28 ns | 0.0484 ns | 0.0404 ns |  29.30 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 3.0 |  24.41 ns | 0.0768 ns | 0.0681 ns |  24.41 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  49.69 ns | 0.0930 ns | 0.0870 ns |  49.72 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short |        net472 |  49.17 ns | 0.0699 ns | 0.0620 ns |  49.16 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  51.12 ns | 0.0809 ns | 0.0757 ns |  51.12 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 2.2 |  33.11 ns | 0.1430 ns | 0.1337 ns |  33.15 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 3.0 |  30.35 ns | 0.0440 ns | 0.0390 ns |  30.35 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  54.94 ns | 0.0859 ns | 0.0803 ns |  54.96 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject |        net472 |  54.05 ns | 0.0674 ns | 0.0598 ns |  54.02 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  46.55 ns | 0.0705 ns | 0.0659 ns |  46.55 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  29.00 ns | 0.0858 ns | 0.0761 ns |  28.97 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  25.27 ns | 0.0892 ns | 0.0834 ns |  25.31 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  53.16 ns | 0.2301 ns | 0.2152 ns |  53.24 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue |        net472 |  49.35 ns | 0.0800 ns | 0.0748 ns |  49.33 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.26 ns | 0.1803 ns | 0.1686 ns |  51.30 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  35.04 ns | 0.2242 ns | 0.2098 ns |  34.99 ns |  0.68 |    0.01 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.33 ns | 0.0883 ns | 0.0826 ns |  30.29 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  53.57 ns | 0.0695 ns | 0.0616 ns |  53.57 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject |        net472 |  56.06 ns | 0.0605 ns | 0.0537 ns |  56.06 ns |  1.09 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  12.92 ns | 0.0548 ns | 0.0513 ns |  12.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  12.25 ns | 0.0278 ns | 0.0247 ns |  12.25 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  12.33 ns | 0.0105 ns | 0.0088 ns |  12.33 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  15.21 ns | 0.0204 ns | 0.0191 ns |  15.20 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  14.81 ns | 0.0142 ns | 0.0132 ns |  14.81 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  15.00 ns | 0.0815 ns | 0.0762 ns |  14.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.41 ns | 0.0776 ns | 0.0726 ns |  12.36 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.46 ns | 0.0183 ns | 0.0171 ns |  13.46 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  14.45 ns | 0.0224 ns | 0.0210 ns |  14.45 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  14.71 ns | 0.0364 ns | 0.0340 ns |  14.70 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  45.71 ns | 0.0452 ns | 0.0378 ns |  45.72 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 2.2 |  29.42 ns | 0.0446 ns | 0.0396 ns |  29.43 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 3.0 |  24.33 ns | 0.1666 ns | 0.1558 ns |  24.24 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  51.21 ns | 0.0629 ns | 0.0558 ns |  51.20 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
                                              From_Int |        net472 |  49.38 ns | 0.0645 ns | 0.0572 ns |  49.40 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  51.79 ns | 0.1430 ns | 0.1338 ns |  51.77 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 2.2 |  35.00 ns | 0.0587 ns | 0.0520 ns |  34.99 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 3.0 |  29.10 ns | 0.0474 ns | 0.0443 ns |  29.10 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  59.20 ns | 0.0818 ns | 0.0765 ns |  59.20 ns |  1.14 |    0.00 | 0.0050 |     - |     - |      32 B |
                                     From_Int_AsObject |        net472 |  53.88 ns | 0.3464 ns | 0.3240 ns |  53.72 ns |  1.04 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  47.36 ns | 0.0471 ns | 0.0418 ns |  47.37 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  29.91 ns | 0.0802 ns | 0.0750 ns |  29.91 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  25.17 ns | 0.1847 ns | 0.1728 ns |  25.18 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  49.51 ns | 0.0901 ns | 0.0799 ns |  49.49 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue |        net472 |  49.16 ns | 0.0560 ns | 0.0467 ns |  49.16 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.76 ns | 0.0775 ns | 0.0725 ns |  50.76 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.57 ns | 0.0515 ns | 0.0481 ns |  32.55 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  31.06 ns | 0.2109 ns | 0.1973 ns |  30.97 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  54.00 ns | 0.2635 ns | 0.2465 ns |  54.07 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  55.44 ns | 0.0835 ns | 0.0781 ns |  55.43 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  14.71 ns | 0.0106 ns | 0.0099 ns |  14.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  12.24 ns | 0.0115 ns | 0.0107 ns |  12.24 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  12.33 ns | 0.0119 ns | 0.0105 ns |  12.33 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  13.24 ns | 0.0158 ns | 0.0132 ns |  13.24 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  15.46 ns | 0.0234 ns | 0.0219 ns |  15.46 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.45 ns | 0.0236 ns | 0.0209 ns |  13.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.36 ns | 0.0093 ns | 0.0087 ns |  12.35 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.05 ns | 0.1625 ns | 0.1520 ns |  13.07 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  13.58 ns | 0.0163 ns | 0.0152 ns |  13.57 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  14.50 ns | 0.0362 ns | 0.0338 ns |  14.49 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  48.00 ns | 0.2428 ns | 0.2271 ns |  47.96 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 2.2 |  30.60 ns | 0.0663 ns | 0.0620 ns |  30.59 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 3.0 |  24.91 ns | 0.6542 ns | 0.6718 ns |  24.55 ns |  0.52 |    0.02 |      - |     - |     - |         - |
                                             From_Long |        net461 |  49.48 ns | 0.0767 ns | 0.0718 ns |  49.48 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long |        net472 |  49.30 ns | 0.3013 ns | 0.2818 ns |  49.44 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  52.12 ns | 0.0931 ns | 0.0871 ns |  52.12 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 2.2 |  35.78 ns | 0.0637 ns | 0.0497 ns |  35.78 ns |  0.69 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 3.0 |  31.81 ns | 0.4139 ns | 0.3871 ns |  32.06 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  63.14 ns | 0.1728 ns | 0.1617 ns |  63.17 ns |  1.21 |    0.00 | 0.0050 |     - |     - |      32 B |
                                    From_Long_AsObject |        net472 |  57.05 ns | 0.0749 ns | 0.0664 ns |  57.04 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  49.04 ns | 0.0494 ns | 0.0438 ns |  49.03 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  29.20 ns | 0.0438 ns | 0.0388 ns |  29.20 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  25.10 ns | 0.1994 ns | 0.1865 ns |  25.20 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  56.03 ns | 0.0975 ns | 0.0912 ns |  56.02 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue |        net472 |  56.11 ns | 0.1081 ns | 0.1011 ns |  56.13 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  52.24 ns | 0.0519 ns | 0.0433 ns |  52.24 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.01 ns | 0.0699 ns | 0.0654 ns |  34.03 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.81 ns | 0.0345 ns | 0.0288 ns |  29.81 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  56.96 ns | 0.0833 ns | 0.0779 ns |  56.94 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  55.90 ns | 0.0711 ns | 0.0665 ns |  55.90 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  13.44 ns | 0.0152 ns | 0.0142 ns |  13.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  12.34 ns | 0.0399 ns | 0.0373 ns |  12.35 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  13.26 ns | 0.0138 ns | 0.0130 ns |  13.26 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  13.85 ns | 0.0268 ns | 0.0251 ns |  13.84 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  13.92 ns | 0.0181 ns | 0.0161 ns |  13.91 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.12 ns | 0.0148 ns | 0.0131 ns |  14.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0083 ns | 0.0078 ns |  12.34 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.05 ns | 0.1401 ns | 0.1310 ns |  13.11 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  14.77 ns | 0.0180 ns | 0.0160 ns |  14.77 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  15.16 ns | 0.0245 ns | 0.0217 ns |  15.16 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  46.64 ns | 0.0679 ns | 0.0567 ns |  46.66 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 2.2 |  29.43 ns | 0.1593 ns | 0.1490 ns |  29.37 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 3.0 |  25.99 ns | 0.4453 ns | 0.4165 ns |  25.84 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  49.23 ns | 0.0510 ns | 0.0477 ns |  49.23 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte |        net472 |  50.10 ns | 0.0848 ns | 0.0708 ns |  50.10 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  51.63 ns | 0.0884 ns | 0.0738 ns |  51.63 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 2.2 |  32.83 ns | 0.0840 ns | 0.0786 ns |  32.83 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 3.0 |  30.26 ns | 0.0447 ns | 0.0373 ns |  30.26 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  59.28 ns | 0.1163 ns | 0.1088 ns |  59.27 ns |  1.15 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_SByte_AsObject |        net472 |  54.31 ns | 0.1015 ns | 0.0950 ns |  54.28 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  46.45 ns | 0.0735 ns | 0.0688 ns |  46.46 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  28.60 ns | 0.0564 ns | 0.0500 ns |  28.59 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  25.42 ns | 0.0247 ns | 0.0193 ns |  25.43 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  50.27 ns | 0.0659 ns | 0.0584 ns |  50.27 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue |        net472 |  49.26 ns | 0.0740 ns | 0.0656 ns |  49.24 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.20 ns | 0.0578 ns | 0.0540 ns |  51.21 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.87 ns | 0.2803 ns | 0.2622 ns |  32.75 ns |  0.64 |    0.01 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.09 ns | 0.0397 ns | 0.0310 ns |  29.10 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  61.83 ns | 0.1008 ns | 0.0893 ns |  61.82 ns |  1.21 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  56.17 ns | 0.0840 ns | 0.0745 ns |  56.15 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  14.15 ns | 0.0931 ns | 0.0870 ns |  14.17 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  12.29 ns | 0.0088 ns | 0.0082 ns |  12.29 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  13.87 ns | 0.8261 ns | 1.3103 ns |  13.14 ns |  1.04 |    0.11 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  15.33 ns | 0.0162 ns | 0.0151 ns |  15.32 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  14.85 ns | 0.0302 ns | 0.0282 ns |  14.84 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.43 ns | 0.0434 ns | 0.0406 ns |  14.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.37 ns | 0.0139 ns | 0.0130 ns |  14.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.98 ns | 0.2759 ns | 0.3588 ns |  12.76 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  15.42 ns | 0.2703 ns | 0.2528 ns |  15.47 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  13.31 ns | 0.0158 ns | 0.0148 ns |  13.30 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 178.97 ns | 0.1816 ns | 0.1610 ns | 178.94 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 2.2 | 120.55 ns | 0.2751 ns | 0.2574 ns | 120.51 ns |  0.67 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 3.0 | 125.99 ns | 0.1477 ns | 0.1382 ns | 125.95 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net461 | 294.04 ns | 0.3358 ns | 0.2804 ns | 294.10 ns |  1.64 |    0.00 | 0.0048 |     - |     - |      32 B |
                                            From_Float |        net472 | 294.16 ns | 0.2593 ns | 0.2426 ns | 294.19 ns |  1.64 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 186.96 ns | 0.2765 ns | 0.2451 ns | 187.03 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 2.2 | 122.27 ns | 0.1035 ns | 0.0968 ns | 122.28 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 3.0 | 130.97 ns | 0.2838 ns | 0.2655 ns | 131.05 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
                                   From_Float_AsObject |        net461 | 306.46 ns | 0.4750 ns | 0.4443 ns | 306.28 ns |  1.64 |    0.00 | 0.0048 |     - |     - |      32 B |
                                   From_Float_AsObject |        net472 | 303.48 ns | 0.3815 ns | 0.3569 ns | 303.37 ns |  1.62 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 179.42 ns | 0.1658 ns | 0.1470 ns | 179.37 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 119.48 ns | 0.8020 ns | 0.7502 ns | 119.13 ns |  0.67 |    0.00 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 123.72 ns | 0.1941 ns | 0.1815 ns | 123.76 ns |  0.69 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net461 | 301.96 ns | 0.3125 ns | 0.2923 ns | 301.90 ns |  1.68 |    0.00 | 0.0048 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue |        net472 | 307.64 ns | 0.2282 ns | 0.1905 ns | 307.64 ns |  1.71 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 190.08 ns | 0.2711 ns | 0.2403 ns | 190.08 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 122.01 ns | 0.2074 ns | 0.1940 ns | 121.95 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 131.72 ns | 0.1865 ns | 0.1745 ns | 131.73 ns |  0.69 |    0.00 | 0.0038 |     - |     - |      24 B |
                From_Float_Nullable_WithValue_AsObject |        net461 | 301.98 ns | 0.3519 ns | 0.3291 ns | 302.05 ns |  1.59 |    0.00 | 0.0048 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject |        net472 | 301.96 ns | 0.2796 ns | 0.2616 ns | 302.03 ns |  1.59 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  13.95 ns | 0.0103 ns | 0.0091 ns |  13.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  12.12 ns | 0.0119 ns | 0.0099 ns |  12.12 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  12.70 ns | 0.0465 ns | 0.0413 ns |  12.70 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  14.30 ns | 0.0268 ns | 0.0251 ns |  14.29 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  14.37 ns | 0.0884 ns | 0.0827 ns |  14.41 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.34 ns | 0.0141 ns | 0.0132 ns |  13.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.39 ns | 0.0683 ns | 0.0639 ns |  12.35 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.22 ns | 0.2853 ns | 0.2669 ns |  13.45 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  13.70 ns | 0.0240 ns | 0.0224 ns |  13.70 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  15.78 ns | 0.0222 ns | 0.0197 ns |  15.77 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  12.98 ns | 0.0261 ns | 0.0244 ns |  12.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  11.43 ns | 0.0093 ns | 0.0083 ns |  11.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  11.83 ns | 0.0157 ns | 0.0131 ns |  11.83 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 |  14.31 ns | 0.0258 ns | 0.0242 ns |  14.31 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 |  12.44 ns | 0.2182 ns | 0.2041 ns |  12.39 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  13.65 ns | 0.0441 ns | 0.0391 ns |  13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  13.59 ns | 0.0227 ns | 0.0202 ns |  13.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  14.02 ns | 0.3403 ns | 0.3919 ns |  13.84 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  14.71 ns | 0.0186 ns | 0.0174 ns |  14.70 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  14.75 ns | 0.0128 ns | 0.0120 ns |  14.75 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.97 ns | 0.0269 ns | 0.0251 ns |  12.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  12.53 ns | 0.0587 ns | 0.0521 ns |  12.53 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  12.00 ns | 0.0563 ns | 0.0526 ns |  12.00 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  12.02 ns | 0.0188 ns | 0.0167 ns |  12.02 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  13.57 ns | 0.0329 ns | 0.0308 ns |  13.56 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  13.36 ns | 0.0377 ns | 0.0334 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  12.45 ns | 0.0461 ns | 0.0431 ns |  12.46 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  13.29 ns | 0.0190 ns | 0.0168 ns |  13.28 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  14.44 ns | 0.0199 ns | 0.0176 ns |  14.44 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  15.42 ns | 0.0227 ns | 0.0201 ns |  15.42 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  13.09 ns | 0.0193 ns | 0.0171 ns |  13.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  11.38 ns | 0.0721 ns | 0.0675 ns |  11.39 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  11.88 ns | 0.0304 ns | 0.0285 ns |  11.86 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  13.72 ns | 0.0248 ns | 0.0220 ns |  13.72 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  13.32 ns | 0.0078 ns | 0.0069 ns |  13.32 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  13.63 ns | 0.0241 ns | 0.0226 ns |  13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  14.55 ns | 0.0162 ns | 0.0152 ns |  14.55 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  13.91 ns | 0.0841 ns | 0.0787 ns |  13.87 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  14.18 ns | 0.0190 ns | 0.0178 ns |  14.18 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  15.14 ns | 0.0189 ns | 0.0177 ns |  15.13 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  44.84 ns | 0.0788 ns | 0.0737 ns |  44.82 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 2.2 |  30.24 ns | 0.0806 ns | 0.0754 ns |  30.24 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 3.0 |  24.31 ns | 0.0293 ns | 0.0245 ns |  24.31 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  47.72 ns | 0.0552 ns | 0.0489 ns |  47.72 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort |        net472 |  53.38 ns | 0.0788 ns | 0.0737 ns |  53.39 ns |  1.19 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  48.86 ns | 0.1650 ns | 0.1543 ns |  48.82 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 2.2 |  35.02 ns | 0.0640 ns | 0.0599 ns |  35.03 ns |  0.72 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 3.0 |  29.36 ns | 0.0583 ns | 0.0487 ns |  29.37 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  53.16 ns | 0.0669 ns | 0.0559 ns |  53.17 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject |        net472 |  56.51 ns | 0.1844 ns | 0.1634 ns |  56.53 ns |  1.16 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  44.53 ns | 0.0853 ns | 0.0756 ns |  44.52 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  29.73 ns | 0.0338 ns | 0.0316 ns |  29.74 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  24.88 ns | 0.0389 ns | 0.0325 ns |  24.87 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  51.72 ns | 0.0733 ns | 0.0685 ns |  51.72 ns |  1.16 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue |        net472 |  48.33 ns | 0.0623 ns | 0.0583 ns |  48.35 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  48.81 ns | 0.1377 ns | 0.1221 ns |  48.82 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.00 ns | 0.0631 ns | 0.0560 ns |  32.99 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.38 ns | 0.0479 ns | 0.0448 ns |  30.37 ns |  0.62 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  53.78 ns | 0.0557 ns | 0.0521 ns |  53.77 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  54.38 ns | 0.3502 ns | 0.3276 ns |  54.54 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  12.87 ns | 0.0147 ns | 0.0137 ns |  12.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  13.20 ns | 0.1118 ns | 0.1046 ns |  13.21 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  19.14 ns | 0.3874 ns | 0.3624 ns |  19.42 ns |  1.49 |    0.03 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  14.58 ns | 0.0179 ns | 0.0167 ns |  14.58 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  13.29 ns | 0.0641 ns | 0.0568 ns |  13.31 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.50 ns | 0.0183 ns | 0.0163 ns |  13.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.43 ns | 0.0897 ns | 0.0839 ns |  12.47 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.09 ns | 0.2694 ns | 0.2520 ns |  13.26 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.35 ns | 0.0138 ns | 0.0129 ns |  13.35 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  15.47 ns | 0.0078 ns | 0.0061 ns |  15.47 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  44.91 ns | 0.0662 ns | 0.0553 ns |  44.90 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 2.2 |  30.86 ns | 0.0449 ns | 0.0420 ns |  30.86 ns |  0.69 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 3.0 |  24.08 ns | 0.2956 ns | 0.2765 ns |  23.88 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  51.02 ns | 0.0789 ns | 0.0700 ns |  51.03 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt |        net472 |  48.03 ns | 0.3093 ns | 0.2893 ns |  47.87 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  48.57 ns | 0.0609 ns | 0.0509 ns |  48.56 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 2.2 |  33.01 ns | 0.1214 ns | 0.1076 ns |  32.98 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 3.0 |  30.19 ns | 0.0553 ns | 0.0517 ns |  30.19 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  55.50 ns | 0.0731 ns | 0.0648 ns |  55.50 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject |        net472 |  56.59 ns | 0.0732 ns | 0.0611 ns |  56.59 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  45.05 ns | 0.0764 ns | 0.0638 ns |  45.04 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  28.93 ns | 0.0883 ns | 0.0826 ns |  28.93 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  25.71 ns | 0.1659 ns | 0.1552 ns |  25.75 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  53.27 ns | 0.2037 ns | 0.1906 ns |  53.34 ns |  1.18 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue |        net472 |  48.25 ns | 0.0722 ns | 0.0640 ns |  48.25 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  48.62 ns | 0.0837 ns | 0.0742 ns |  48.61 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.67 ns | 0.0633 ns | 0.0528 ns |  32.65 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.89 ns | 0.0298 ns | 0.0278 ns |  29.90 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  53.13 ns | 0.1041 ns | 0.0974 ns |  53.12 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  55.97 ns | 0.0501 ns | 0.0444 ns |  55.96 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  14.42 ns | 0.0128 ns | 0.0120 ns |  14.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  13.31 ns | 0.0091 ns | 0.0081 ns |  13.31 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  13.02 ns | 0.0175 ns | 0.0164 ns |  13.02 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  13.35 ns | 0.0075 ns | 0.0066 ns |  13.35 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  13.35 ns | 0.0109 ns | 0.0102 ns |  13.35 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.55 ns | 0.0277 ns | 0.0259 ns |  13.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.39 ns | 0.0184 ns | 0.0163 ns |  12.39 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.88 ns | 0.1028 ns | 0.0962 ns |  12.93 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  13.35 ns | 0.0194 ns | 0.0172 ns |  13.35 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  14.92 ns | 0.0113 ns | 0.0105 ns |  14.92 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  46.25 ns | 0.0625 ns | 0.0554 ns |  46.25 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 2.2 |  30.47 ns | 0.0476 ns | 0.0446 ns |  30.48 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 3.0 |  25.26 ns | 0.0411 ns | 0.0385 ns |  25.26 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  48.52 ns | 0.0679 ns | 0.0602 ns |  48.53 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong |        net472 |  47.60 ns | 0.1328 ns | 0.1242 ns |  47.56 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  52.33 ns | 0.0601 ns | 0.0533 ns |  52.34 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 2.2 |  35.77 ns | 0.1965 ns | 0.1838 ns |  35.71 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 3.0 |  29.27 ns | 0.0521 ns | 0.0462 ns |  29.27 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  55.05 ns | 0.0719 ns | 0.0672 ns |  55.04 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject |        net472 |  53.61 ns | 0.1045 ns | 0.0978 ns |  53.60 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  49.18 ns | 0.0722 ns | 0.0675 ns |  49.20 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  29.33 ns | 0.0649 ns | 0.0607 ns |  29.32 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  25.52 ns | 0.1618 ns | 0.1514 ns |  25.54 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  51.19 ns | 0.0368 ns | 0.0307 ns |  51.19 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue |        net472 |  51.83 ns | 0.0818 ns | 0.0725 ns |  51.83 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.77 ns | 0.0588 ns | 0.0522 ns |  51.76 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.76 ns | 0.0415 ns | 0.0368 ns |  33.76 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.94 ns | 0.1899 ns | 0.1776 ns |  28.96 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  54.34 ns | 0.1008 ns | 0.0893 ns |  54.34 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  53.23 ns | 0.0660 ns | 0.0617 ns |  53.24 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.59 ns | 0.0301 ns | 0.0282 ns |  13.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  12.29 ns | 0.0150 ns | 0.0141 ns |  12.29 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  13.25 ns | 0.0192 ns | 0.0150 ns |  13.26 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  15.51 ns | 0.0823 ns | 0.0770 ns |  15.56 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  14.30 ns | 0.0986 ns | 0.0922 ns |  14.26 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.52 ns | 0.0171 ns | 0.0152 ns |  13.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.36 ns | 0.0165 ns | 0.0147 ns |  12.35 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.02 ns | 0.2113 ns | 0.1977 ns |  13.14 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  13.28 ns | 0.0137 ns | 0.0121 ns |  13.28 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  14.98 ns | 0.0186 ns | 0.0164 ns |  14.98 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  13.89 ns | 0.2483 ns | 0.2323 ns |  13.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  12.62 ns | 0.0156 ns | 0.0130 ns |  12.63 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  13.42 ns | 0.1112 ns | 0.1040 ns |  13.35 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  14.45 ns | 0.0237 ns | 0.0222 ns |  14.44 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  13.31 ns | 0.0124 ns | 0.0116 ns |  13.31 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  12.68 ns | 0.0835 ns | 0.0781 ns |  12.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  11.17 ns | 0.0133 ns | 0.0118 ns |  11.17 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  13.85 ns | 0.3012 ns | 0.7274 ns |  14.12 ns |  1.01 |    0.09 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  12.04 ns | 0.0057 ns | 0.0054 ns |  12.04 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  13.41 ns | 0.0306 ns | 0.0286 ns |  13.41 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  13.33 ns | 0.0106 ns | 0.0099 ns |  13.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  14.54 ns | 0.0515 ns | 0.0481 ns |  14.55 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  12.75 ns | 0.0152 ns | 0.0135 ns |  12.75 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  15.24 ns | 0.0097 ns | 0.0081 ns |  15.24 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  13.30 ns | 0.0129 ns | 0.0115 ns |  13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  15.92 ns | 0.0239 ns | 0.0223 ns |  15.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  15.28 ns | 0.0175 ns | 0.0155 ns |  15.28 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  14.53 ns | 0.1365 ns | 0.1277 ns |  14.53 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  16.86 ns | 0.0185 ns | 0.0164 ns |  16.86 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  17.72 ns | 0.0223 ns | 0.0197 ns |  17.72 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  18.52 ns | 0.0282 ns | 0.0250 ns |  18.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  16.61 ns | 0.0958 ns | 0.0896 ns |  16.65 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  15.58 ns | 0.0451 ns | 0.0421 ns |  15.59 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  17.52 ns | 0.0183 ns | 0.0171 ns |  17.52 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  19.46 ns | 0.0206 ns | 0.0182 ns |  19.46 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  14.02 ns | 0.0124 ns | 0.0110 ns |  14.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  13.98 ns | 0.0118 ns | 0.0111 ns |  13.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  13.45 ns | 0.2207 ns | 0.2064 ns |  13.38 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  13.71 ns | 0.0678 ns | 0.0634 ns |  13.68 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  14.96 ns | 0.0211 ns | 0.0197 ns |  14.95 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.51 ns | 0.0150 ns | 0.0133 ns |  13.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0150 ns | 0.0140 ns |  12.34 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.28 ns | 0.0157 ns | 0.0131 ns |  13.28 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  13.53 ns | 0.0128 ns | 0.0120 ns |  13.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  13.40 ns | 0.0192 ns | 0.0170 ns |  13.40 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  20.12 ns | 0.0252 ns | 0.0236 ns |  20.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  19.15 ns | 0.0789 ns | 0.0738 ns |  19.17 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  18.47 ns | 0.1832 ns | 0.1714 ns |  18.36 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  20.83 ns | 0.0170 ns | 0.0151 ns |  20.83 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  21.74 ns | 0.0243 ns | 0.0215 ns |  21.74 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  25.35 ns | 0.0214 ns | 0.0200 ns |  25.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  25.09 ns | 0.0210 ns | 0.0186 ns |  25.09 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  22.52 ns | 0.1866 ns | 0.1745 ns |  22.65 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  29.33 ns | 0.0413 ns | 0.0366 ns |  29.34 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  25.98 ns | 0.0161 ns | 0.0150 ns |  25.98 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  13.93 ns | 0.0104 ns | 0.0092 ns |  13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  12.07 ns | 0.0131 ns | 0.0116 ns |  12.07 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  14.05 ns | 0.2777 ns | 0.2597 ns |  14.08 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  13.69 ns | 0.0201 ns | 0.0188 ns |  13.69 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  13.99 ns | 0.0146 ns | 0.0129 ns |  13.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.47 ns | 0.0370 ns | 0.0346 ns |  13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.35 ns | 0.0118 ns | 0.0105 ns |  12.35 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.01 ns | 0.2099 ns | 0.1963 ns |  12.90 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  14.66 ns | 0.0591 ns | 0.0552 ns |  14.68 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  14.62 ns | 0.0215 ns | 0.0201 ns |  14.62 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  19.04 ns | 0.0407 ns | 0.0381 ns |  19.04 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  17.98 ns | 0.0762 ns | 0.0713 ns |  18.00 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  18.59 ns | 0.1362 ns | 0.1274 ns |  18.53 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  21.93 ns | 0.0392 ns | 0.0367 ns |  21.94 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  19.98 ns | 0.0680 ns | 0.0636 ns |  19.98 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  18.54 ns | 0.0156 ns | 0.0130 ns |  18.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  18.41 ns | 0.0213 ns | 0.0199 ns |  18.40 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  18.03 ns | 0.3854 ns | 0.4284 ns |  18.30 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  19.55 ns | 0.0221 ns | 0.0196 ns |  19.55 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  20.06 ns | 0.0250 ns | 0.0234 ns |  20.06 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  19.38 ns | 0.0477 ns | 0.0422 ns |  19.38 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  18.09 ns | 0.0342 ns | 0.0320 ns |  18.09 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  21.16 ns | 0.4428 ns | 0.6062 ns |  21.52 ns |  1.07 |    0.03 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  21.19 ns | 0.1314 ns | 0.1229 ns |  21.13 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  19.44 ns | 0.0407 ns | 0.0361 ns |  19.43 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  19.81 ns | 0.0170 ns | 0.0142 ns |  19.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  19.48 ns | 0.0168 ns | 0.0158 ns |  19.48 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  16.00 ns | 0.0296 ns | 0.0277 ns |  16.01 ns |  0.81 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  19.66 ns | 0.0273 ns | 0.0255 ns |  19.65 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  20.03 ns | 0.0334 ns | 0.0296 ns |  20.04 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.18 ns | 0.0125 ns | 0.0117 ns |  13.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  13.27 ns | 0.0243 ns | 0.0227 ns |  13.27 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  13.27 ns | 0.0287 ns | 0.0268 ns |  13.27 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  15.83 ns | 0.0198 ns | 0.0176 ns |  15.84 ns |  1.20 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  13.38 ns | 0.0097 ns | 0.0091 ns |  13.38 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.41 ns | 0.0728 ns | 0.0608 ns |  14.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.55 ns | 0.0223 ns | 0.0186 ns |  14.54 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.03 ns | 0.2705 ns | 0.2778 ns |  12.87 ns |  0.91 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.90 ns | 0.0181 ns | 0.0169 ns |  13.91 ns |  0.97 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.45 ns | 0.0165 ns | 0.0146 ns |  14.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  27.14 ns | 0.0489 ns | 0.0458 ns |  27.14 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 2.2 |  23.59 ns | 0.0580 ns | 0.0543 ns |  23.60 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 3.0 |  20.80 ns | 0.0813 ns | 0.0761 ns |  20.80 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net461 |  27.02 ns | 0.0132 ns | 0.0117 ns |  27.02 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net472 |  27.03 ns | 0.0975 ns | 0.0912 ns |  26.99 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  25.48 ns | 0.0294 ns | 0.0261 ns |  25.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  23.71 ns | 0.0353 ns | 0.0276 ns |  23.71 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  25.76 ns | 0.5339 ns | 1.4065 ns |  26.35 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  26.36 ns | 0.0298 ns | 0.0278 ns |  26.37 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  32.43 ns | 0.1607 ns | 0.1504 ns |  32.44 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  28.29 ns | 0.0307 ns | 0.0272 ns |  28.29 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  26.17 ns | 0.0646 ns | 0.0573 ns |  26.18 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  21.69 ns | 0.4504 ns | 0.5006 ns |  21.32 ns |  0.76 |    0.02 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  28.86 ns | 0.0454 ns | 0.0402 ns |  28.85 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  25.18 ns | 0.1419 ns | 0.1328 ns |  25.11 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  25.41 ns | 0.0269 ns | 0.0224 ns |  25.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  23.99 ns | 0.0528 ns | 0.0494 ns |  23.98 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  22.83 ns | 0.5619 ns | 0.6689 ns |  22.47 ns |  0.91 |    0.03 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  27.20 ns | 0.0853 ns | 0.0798 ns |  27.21 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  28.01 ns | 0.0440 ns | 0.0412 ns |  28.02 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.21 ns | 0.0226 ns | 0.0189 ns |  13.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.64 ns | 0.0828 ns | 0.0774 ns |  12.63 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  12.97 ns | 0.6668 ns | 0.6848 ns |  12.60 ns |  0.99 |    0.06 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  14.71 ns | 0.0268 ns | 0.0224 ns |  14.70 ns |  1.11 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  12.68 ns | 0.0114 ns | 0.0101 ns |  12.68 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.35 ns | 0.0123 ns | 0.0115 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.38 ns | 0.0581 ns | 0.0543 ns |  12.34 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.84 ns | 0.1863 ns | 0.1743 ns |  13.94 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  14.63 ns | 0.0217 ns | 0.0203 ns |  14.63 ns |  1.10 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.31 ns | 0.0382 ns | 0.0339 ns |  13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  65.85 ns | 0.1258 ns | 0.1115 ns |  65.86 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 2.2 |  64.76 ns | 0.0836 ns | 0.0782 ns |  64.73 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 3.0 |  44.00 ns | 0.4833 ns | 0.4521 ns |  43.99 ns |  0.67 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Enum |        net461 | 311.55 ns | 0.2881 ns | 0.2695 ns | 311.55 ns |  4.73 |    0.01 | 0.0114 |     - |     - |      72 B |
                                             From_Enum |        net472 | 311.58 ns | 1.8410 ns | 1.7221 ns | 312.37 ns |  4.73 |    0.03 | 0.0114 |     - |     - |      72 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  65.62 ns | 0.0733 ns | 0.0685 ns |  65.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  66.73 ns | 0.1322 ns | 0.1104 ns |  66.73 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  43.75 ns | 0.2430 ns | 0.2273 ns |  43.64 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 311.30 ns | 1.2762 ns | 1.1938 ns | 310.72 ns |  4.74 |    0.02 | 0.0076 |     - |     - |      48 B |
                                    From_Enum_AsObject |        net472 | 309.97 ns | 1.7367 ns | 1.6245 ns | 309.97 ns |  4.72 |    0.03 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  66.85 ns | 0.1580 ns | 0.1401 ns |  66.81 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  66.85 ns | 0.2309 ns | 0.2160 ns |  66.85 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  48.35 ns | 0.2264 ns | 0.2007 ns |  48.42 ns |  0.72 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue |        net461 | 311.28 ns | 0.5934 ns | 0.5551 ns | 311.09 ns |  4.66 |    0.01 | 0.0114 |     - |     - |      72 B |
                          From_Enum_Nullable_WithValue |        net472 | 309.19 ns | 0.6561 ns | 0.6137 ns | 309.02 ns |  4.63 |    0.02 | 0.0114 |     - |     - |      72 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  64.37 ns | 0.7632 ns | 0.7139 ns |  63.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  65.61 ns | 0.0602 ns | 0.0533 ns |  65.62 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  47.37 ns | 0.0895 ns | 0.0699 ns |  47.37 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 311.30 ns | 0.3850 ns | 0.3601 ns | 311.31 ns |  4.84 |    0.05 | 0.0076 |     - |     - |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 327.08 ns | 6.2548 ns | 6.1431 ns | 326.79 ns |  5.08 |    0.13 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  14.05 ns | 0.0173 ns | 0.0161 ns |  14.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  13.26 ns | 0.0921 ns | 0.0861 ns |  13.22 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  12.58 ns | 0.0549 ns | 0.0459 ns |  12.55 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  16.78 ns | 0.0317 ns | 0.0281 ns |  16.77 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  13.92 ns | 0.2959 ns | 0.3039 ns |  13.77 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.35 ns | 0.0163 ns | 0.0136 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.61 ns | 0.0140 ns | 0.0131 ns |  12.61 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.30 ns | 0.0114 ns | 0.0101 ns |  13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  13.44 ns | 0.0120 ns | 0.0112 ns |  13.44 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  13.93 ns | 0.1687 ns | 0.1495 ns |  13.88 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  20.36 ns | 0.0211 ns | 0.0197 ns |  20.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  19.03 ns | 0.1086 ns | 0.1016 ns |  19.03 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  18.13 ns | 0.0639 ns | 0.0598 ns |  18.13 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  23.58 ns | 0.0305 ns | 0.0285 ns |  23.59 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  22.06 ns | 0.2218 ns | 0.1966 ns |  22.03 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  26.84 ns | 0.0270 ns | 0.0240 ns |  26.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  26.31 ns | 0.1904 ns | 0.1781 ns |  26.22 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  22.55 ns | 0.3867 ns | 0.3617 ns |  22.75 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  26.87 ns | 0.0439 ns | 0.0411 ns |  26.86 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  28.36 ns | 0.5444 ns | 0.5092 ns |  28.19 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  13.44 ns | 0.1050 ns | 0.0982 ns |  13.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  12.22 ns | 0.0225 ns | 0.0176 ns |  12.22 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  12.41 ns | 0.0665 ns | 0.0622 ns |  12.38 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  13.06 ns | 0.0147 ns | 0.0123 ns |  13.06 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  13.37 ns | 0.1001 ns | 0.0836 ns |  13.34 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0094 ns | 0.0088 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  12.48 ns | 0.0766 ns | 0.0679 ns |  12.50 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  12.98 ns | 0.2850 ns | 0.2927 ns |  12.75 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  14.46 ns | 0.0199 ns | 0.0186 ns |  14.46 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  14.57 ns | 0.2544 ns | 0.2380 ns |  14.47 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  91.25 ns | 0.7357 ns | 0.6881 ns |  90.83 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 | 101.12 ns | 0.3394 ns | 0.3175 ns | 101.08 ns |  1.11 |    0.01 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 |  92.16 ns | 0.3242 ns | 0.2874 ns |  92.11 ns |  1.01 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 |  92.72 ns | 0.0973 ns | 0.0813 ns |  92.72 ns |  1.02 |    0.01 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 103.09 ns | 0.9958 ns | 0.7774 ns | 103.15 ns |  1.13 |    0.01 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  26.43 ns | 0.1271 ns | 0.1189 ns |  26.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  24.51 ns | 0.0551 ns | 0.0489 ns |  24.51 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  22.15 ns | 0.0689 ns | 0.0644 ns |  22.19 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  26.58 ns | 0.0541 ns | 0.0506 ns |  26.57 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  27.06 ns | 0.1038 ns | 0.0920 ns |  27.07 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 119.56 ns | 0.2837 ns | 0.2515 ns | 119.51 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 123.71 ns | 0.2961 ns | 0.2312 ns | 123.65 ns |  1.03 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 120.81 ns | 0.7612 ns | 0.7120 ns | 120.74 ns |  1.01 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 121.02 ns | 0.4661 ns | 0.4360 ns | 120.90 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 122.92 ns | 2.4391 ns | 2.2816 ns | 123.10 ns |  1.03 |    0.02 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  27.65 ns | 0.0381 ns | 0.0357 ns |  27.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  26.10 ns | 0.0226 ns | 0.0211 ns |  26.09 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.57 ns | 0.1253 ns | 0.1172 ns |  23.61 ns |  0.85 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  28.57 ns | 0.0363 ns | 0.0340 ns |  28.56 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  29.21 ns | 0.1910 ns | 0.1787 ns |  29.18 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  62.42 ns | 0.2922 ns | 0.2733 ns |  62.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  62.62 ns | 0.2182 ns | 0.2041 ns |  62.54 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  58.78 ns | 0.0725 ns | 0.0605 ns |  58.77 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  58.79 ns | 0.0564 ns | 0.0528 ns |  58.77 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  57.45 ns | 0.1594 ns | 0.1413 ns |  57.49 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0113 ns | 0.0095 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.40 ns | 0.0135 ns | 0.0113 ns |  12.41 ns |  0.93 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.64 ns | 0.1552 ns | 0.1376 ns |  13.69 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  14.82 ns | 0.0244 ns | 0.0204 ns |  14.83 ns |  1.11 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  14.75 ns | 0.0823 ns | 0.0730 ns |  14.77 ns |  1.10 |    0.01 |      - |     - |     - |         - |
