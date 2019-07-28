
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JAAERG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QUNRTP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YWJRPJ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-VUCMHJ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-EEAFKE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  15.61 ns | 0.0798 ns | 0.0707 ns |  15.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  13.37 ns | 0.0078 ns | 0.0065 ns |  13.37 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  13.60 ns | 0.0212 ns | 0.0198 ns |  13.60 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  14.64 ns | 0.0171 ns | 0.0151 ns |  14.64 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  14.24 ns | 0.0143 ns | 0.0134 ns |  14.24 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |  19.12 ns | 0.0279 ns | 0.0247 ns |  19.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |  15.87 ns | 0.0305 ns | 0.0255 ns |  15.87 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |  17.02 ns | 0.0365 ns | 0.0341 ns |  17.02 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |  17.49 ns | 0.0431 ns | 0.0382 ns |  17.49 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |  19.27 ns | 0.0613 ns | 0.0543 ns |  19.28 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  15.18 ns | 0.0548 ns | 0.0513 ns |  15.16 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  13.23 ns | 0.0120 ns | 0.0112 ns |  13.23 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  14.43 ns | 0.0167 ns | 0.0139 ns |  14.42 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  15.89 ns | 0.0223 ns | 0.0209 ns |  15.89 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  14.91 ns | 0.0146 ns | 0.0122 ns |  14.91 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |  18.00 ns | 0.0215 ns | 0.0191 ns |  18.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.09 ns | 0.0562 ns | 0.0525 ns |  16.07 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |  17.72 ns | 0.0534 ns | 0.0500 ns |  17.71 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |  20.26 ns | 0.0276 ns | 0.0258 ns |  20.26 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |  19.12 ns | 0.0314 ns | 0.0262 ns |  19.11 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  12.95 ns | 0.0114 ns | 0.0107 ns |  12.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  11.42 ns | 0.0110 ns | 0.0098 ns |  11.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  12.26 ns | 0.0267 ns | 0.0237 ns |  12.26 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  13.33 ns | 0.0174 ns | 0.0162 ns |  13.33 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  13.30 ns | 0.0336 ns | 0.0298 ns |  13.28 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.71 ns | 0.0873 ns | 0.0774 ns |  13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.31 ns | 0.0131 ns | 0.0122 ns |  12.31 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.76 ns | 0.1559 ns | 0.1458 ns |  14.66 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  14.13 ns | 0.0065 ns | 0.0057 ns |  14.13 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  13.37 ns | 0.0160 ns | 0.0150 ns |  13.38 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  45.45 ns | 0.1428 ns | 0.1336 ns |  45.45 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 2.2 |  28.06 ns | 0.0316 ns | 0.0295 ns |  28.06 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte | .NET Core 3.0 |  23.75 ns | 0.0362 ns | 0.0338 ns |  23.75 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  49.26 ns | 0.0673 ns | 0.0630 ns |  49.25 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Byte |        net472 |  48.54 ns | 0.0601 ns | 0.0533 ns |  48.52 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |  51.52 ns | 0.0771 ns | 0.0684 ns |  51.51 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 2.2 |  33.42 ns | 0.1044 ns | 0.0977 ns |  33.42 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Byte_AsObject | .NET Core 3.0 |  30.25 ns | 0.0464 ns | 0.0388 ns |  30.24 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |  61.22 ns | 0.1204 ns | 0.1126 ns |  61.20 ns |  1.19 |    0.00 | 0.0050 |     - |     - |      32 B |
                                    From_Byte_AsObject |        net472 |  55.95 ns | 0.0558 ns | 0.0495 ns |  55.95 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  47.36 ns | 0.1787 ns | 0.1672 ns |  47.34 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  28.61 ns | 0.0354 ns | 0.0314 ns |  28.60 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  25.26 ns | 0.0358 ns | 0.0335 ns |  25.26 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  49.80 ns | 0.3615 ns | 0.3382 ns |  49.64 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                          From_Byte_Nullable_WithValue |        net472 |  50.29 ns | 0.0532 ns | 0.0498 ns |  50.27 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.92 ns | 0.1224 ns | 0.1145 ns |  50.89 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.84 ns | 0.0615 ns | 0.0575 ns |  32.84 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.80 ns | 0.0586 ns | 0.0489 ns |  29.81 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |  54.44 ns | 0.0751 ns | 0.0702 ns |  54.42 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |  55.98 ns | 0.0531 ns | 0.0471 ns |  55.96 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  13.65 ns | 0.0102 ns | 0.0085 ns |  13.65 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  14.86 ns | 0.3107 ns | 0.2906 ns |  14.92 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  13.37 ns | 0.1460 ns | 0.1365 ns |  13.42 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  15.47 ns | 0.0167 ns | 0.0156 ns |  15.47 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  13.44 ns | 0.0172 ns | 0.0153 ns |  13.44 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.46 ns | 0.0701 ns | 0.0656 ns |  13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.40 ns | 0.0178 ns | 0.0166 ns |  12.39 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.47 ns | 0.0799 ns | 0.0747 ns |  13.48 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  14.90 ns | 0.0163 ns | 0.0153 ns |  14.90 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  15.72 ns | 0.0115 ns | 0.0102 ns |  15.73 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  16.14 ns | 0.0535 ns | 0.0447 ns |  16.12 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 2.2 |  15.13 ns | 0.0194 ns | 0.0172 ns |  15.12 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Char | .NET Core 3.0 |  16.47 ns | 0.0714 ns | 0.0668 ns |  16.49 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net461 |  18.81 ns | 0.0865 ns | 0.0809 ns |  18.78 ns |  1.16 |    0.01 | 0.0051 |     - |     - |      32 B |
                                             From_Char |        net472 |  17.30 ns | 0.0450 ns | 0.0421 ns |  17.31 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |  23.20 ns | 0.0995 ns | 0.0882 ns |  23.20 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 2.2 |  20.86 ns | 0.0338 ns | 0.0299 ns |  20.86 ns |  0.90 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject | .NET Core 3.0 |  27.06 ns | 0.5676 ns | 1.1721 ns |  27.57 ns |  1.11 |    0.07 | 0.0038 |     - |     - |      24 B |
                                    From_Char_AsObject |        net461 |  21.93 ns | 0.0375 ns | 0.0333 ns |  21.94 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Char_AsObject |        net472 |  23.64 ns | 0.0220 ns | 0.0206 ns |  23.64 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  17.23 ns | 0.0256 ns | 0.0227 ns |  17.23 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  15.65 ns | 0.0173 ns | 0.0135 ns |  15.65 ns |  0.91 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  16.41 ns | 0.2701 ns | 0.2527 ns |  16.41 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net461 |  19.79 ns | 0.0469 ns | 0.0438 ns |  19.78 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Char_Nullable_WithValue |        net472 |  19.01 ns | 0.0209 ns | 0.0196 ns |  19.02 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |  21.99 ns | 0.0686 ns | 0.0608 ns |  21.97 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |  21.01 ns | 0.0792 ns | 0.0740 ns |  21.02 ns |  0.96 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.90 ns | 0.0623 ns | 0.0552 ns |  23.90 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Char_Nullable_WithValue_AsObject |        net461 |  25.25 ns | 0.1032 ns | 0.0966 ns |  25.30 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
                 From_Char_Nullable_WithValue_AsObject |        net472 |  24.22 ns | 0.0403 ns | 0.0337 ns |  24.22 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  13.71 ns | 0.1228 ns | 0.1148 ns |  13.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  12.34 ns | 0.0183 ns | 0.0172 ns |  12.33 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  12.62 ns | 0.2374 ns | 0.2221 ns |  12.76 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  13.30 ns | 0.0207 ns | 0.0194 ns |  13.30 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  14.78 ns | 0.0504 ns | 0.0447 ns |  14.79 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.63 ns | 0.0161 ns | 0.0143 ns |  13.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  14.14 ns | 0.0593 ns | 0.0555 ns |  14.13 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.33 ns | 0.0243 ns | 0.0227 ns |  13.32 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0114 ns | 0.0101 ns |  13.41 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  14.57 ns | 0.0173 ns | 0.0154 ns |  14.57 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 339.73 ns | 1.1973 ns | 1.0614 ns | 339.78 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 2.2 | 286.30 ns | 0.3717 ns | 0.3295 ns | 286.23 ns |  0.84 |    0.00 | 0.0262 |     - |     - |     168 B |
                                         From_DateTime | .NET Core 3.0 | 238.75 ns | 1.3170 ns | 1.2319 ns | 238.25 ns |  0.70 |    0.00 | 0.0100 |     - |     - |      64 B |
                                         From_DateTime |        net461 | 350.14 ns | 3.0752 ns | 2.8765 ns | 348.48 ns |  1.03 |    0.01 | 0.0300 |     - |     - |     192 B |
                                         From_DateTime |        net472 | 346.87 ns | 0.4183 ns | 0.3493 ns | 346.77 ns |  1.02 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 339.43 ns | 0.4654 ns | 0.3633 ns | 339.35 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 2.2 | 291.97 ns | 0.4858 ns | 0.4544 ns | 292.10 ns |  0.86 |    0.00 | 0.0262 |     - |     - |     168 B |
                                From_DateTime_AsObject | .NET Core 3.0 | 244.91 ns | 1.0396 ns | 0.9216 ns | 245.26 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
                                From_DateTime_AsObject |        net461 | 349.55 ns | 0.4013 ns | 0.3557 ns | 349.44 ns |  1.03 |    0.00 | 0.0300 |     - |     - |     192 B |
                                From_DateTime_AsObject |        net472 | 347.26 ns | 0.4522 ns | 0.4009 ns | 347.26 ns |  1.02 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 331.01 ns | 1.0194 ns | 0.9535 ns | 330.86 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 291.14 ns | 0.8818 ns | 0.8248 ns | 290.87 ns |  0.88 |    0.00 | 0.0262 |     - |     - |     168 B |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 235.92 ns | 0.2738 ns | 0.2561 ns | 235.86 ns |  0.71 |    0.00 | 0.0100 |     - |     - |      64 B |
                      From_DateTime_Nullable_WithValue |        net461 | 349.12 ns | 0.6735 ns | 0.5258 ns | 349.07 ns |  1.06 |    0.00 | 0.0300 |     - |     - |     192 B |
                      From_DateTime_Nullable_WithValue |        net472 | 351.56 ns | 0.6957 ns | 0.6168 ns | 351.42 ns |  1.06 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 333.96 ns | 1.5847 ns | 1.4824 ns | 334.40 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 294.92 ns | 0.4210 ns | 0.3938 ns | 294.81 ns |  0.88 |    0.00 | 0.0262 |     - |     - |     168 B |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 240.14 ns | 0.4460 ns | 0.4172 ns | 240.23 ns |  0.72 |    0.00 | 0.0100 |     - |     - |      64 B |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 355.54 ns | 1.5535 ns | 1.4531 ns | 356.08 ns |  1.06 |    0.01 | 0.0300 |     - |     - |     192 B |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 344.94 ns | 0.3682 ns | 0.3264 ns | 344.93 ns |  1.03 |    0.00 | 0.0300 |     - |     - |     192 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  14.19 ns | 0.0216 ns | 0.0202 ns |  14.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  13.22 ns | 0.0129 ns | 0.0120 ns |  13.22 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  15.19 ns | 0.0524 ns | 0.0490 ns |  15.22 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  14.40 ns | 0.0194 ns | 0.0172 ns |  14.40 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  16.08 ns | 0.0988 ns | 0.0925 ns |  16.13 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.37 ns | 0.0240 ns | 0.0225 ns |  13.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.44 ns | 0.0304 ns | 0.0285 ns |  12.42 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.32 ns | 0.0178 ns | 0.0158 ns |  13.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  14.66 ns | 0.0258 ns | 0.0215 ns |  14.66 ns |  1.10 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  13.44 ns | 0.0158 ns | 0.0148 ns |  13.44 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  63.56 ns | 0.1663 ns | 0.1555 ns |  63.53 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 2.2 |  58.75 ns | 0.1177 ns | 0.1101 ns |  58.75 ns |  0.92 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 3.0 |  56.96 ns | 0.0977 ns | 0.0866 ns |  56.97 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                          From_Decimal |        net461 |  63.38 ns | 0.1842 ns | 0.1633 ns |  63.38 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                          From_Decimal |        net472 |  64.99 ns | 0.0989 ns | 0.0925 ns |  64.98 ns |  1.02 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |  67.25 ns | 0.1303 ns | 0.1017 ns |  67.24 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 2.2 |  58.65 ns | 0.2014 ns | 0.1884 ns |  58.64 ns |  0.87 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject | .NET Core 3.0 |  61.02 ns | 0.0859 ns | 0.0803 ns |  61.00 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                 From_Decimal_AsObject |        net461 |  66.85 ns | 0.1029 ns | 0.0912 ns |  66.85 ns |  0.99 |    0.00 | 0.0050 |     - |     - |      32 B |
                                 From_Decimal_AsObject |        net472 |  69.42 ns | 0.2648 ns | 0.2477 ns |  69.50 ns |  1.03 |    0.00 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  65.70 ns | 0.3440 ns | 0.3218 ns |  65.65 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  60.02 ns | 0.0799 ns | 0.0747 ns |  60.03 ns |  0.91 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |  55.14 ns | 0.1341 ns | 0.1120 ns |  55.12 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                       From_Decimal_Nullable_WithValue |        net461 |  63.17 ns | 0.2346 ns | 0.2195 ns |  63.19 ns |  0.96 |    0.00 | 0.0050 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net472 |  63.63 ns | 0.1181 ns | 0.1105 ns |  63.65 ns |  0.97 |    0.01 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |  67.46 ns | 0.1137 ns | 0.1063 ns |  67.48 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |  58.40 ns | 0.1209 ns | 0.1072 ns |  58.40 ns |  0.87 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |  60.92 ns | 0.9556 ns | 0.8939 ns |  60.44 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |  67.14 ns | 0.0949 ns | 0.0888 ns |  67.11 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |  66.80 ns | 0.4335 ns | 0.4055 ns |  67.02 ns |  0.99 |    0.01 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  13.30 ns | 0.0141 ns | 0.0118 ns |  13.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  17.55 ns | 0.0293 ns | 0.0274 ns |  17.55 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  14.51 ns | 0.0972 ns | 0.0910 ns |  14.55 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  15.91 ns | 0.0194 ns | 0.0162 ns |  15.91 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  16.11 ns | 0.0227 ns | 0.0201 ns |  16.11 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.64 ns | 0.0159 ns | 0.0141 ns |  13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0160 ns | 0.0142 ns |  12.32 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.08 ns | 0.0142 ns | 0.0126 ns |  14.09 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  15.70 ns | 0.1618 ns | 0.1513 ns |  15.72 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  14.57 ns | 0.0106 ns | 0.0082 ns |  14.57 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 206.01 ns | 0.1614 ns | 0.1510 ns | 205.97 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 2.2 | 122.39 ns | 0.2361 ns | 0.2208 ns | 122.44 ns |  0.59 |    0.00 | 0.0050 |     - |     - |      32 B |
                                           From_Double | .NET Core 3.0 | 126.84 ns | 0.1597 ns | 0.1494 ns | 126.85 ns |  0.62 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net461 | 311.87 ns | 0.5019 ns | 0.4191 ns | 311.84 ns |  1.51 |    0.00 | 0.0048 |     - |     - |      32 B |
                                           From_Double |        net472 | 309.81 ns | 0.4210 ns | 0.3938 ns | 309.78 ns |  1.50 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 218.34 ns | 3.0233 ns | 2.8280 ns | 216.72 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 2.2 | 127.58 ns | 0.1694 ns | 0.1584 ns | 127.57 ns |  0.58 |    0.01 | 0.0050 |     - |     - |      32 B |
                                  From_Double_AsObject | .NET Core 3.0 | 133.77 ns | 0.1564 ns | 0.1463 ns | 133.75 ns |  0.61 |    0.01 | 0.0038 |     - |     - |      24 B |
                                  From_Double_AsObject |        net461 | 327.31 ns | 1.2497 ns | 1.1690 ns | 327.85 ns |  1.50 |    0.02 | 0.0048 |     - |     - |      32 B |
                                  From_Double_AsObject |        net472 | 319.90 ns | 0.8419 ns | 0.7876 ns | 320.05 ns |  1.47 |    0.02 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 208.35 ns | 0.2313 ns | 0.2050 ns | 208.31 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 122.89 ns | 0.1632 ns | 0.1526 ns | 122.87 ns |  0.59 |    0.00 | 0.0050 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 126.71 ns | 0.2943 ns | 0.2753 ns | 126.72 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net461 | 313.97 ns | 0.3943 ns | 0.3495 ns | 314.01 ns |  1.51 |    0.00 | 0.0048 |     - |     - |      32 B |
                        From_Double_Nullable_WithValue |        net472 | 316.87 ns | 0.5163 ns | 0.4829 ns | 316.78 ns |  1.52 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 214.77 ns | 1.0675 ns | 0.9985 ns | 215.24 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 127.97 ns | 0.1588 ns | 0.1485 ns | 127.99 ns |  0.60 |    0.00 | 0.0050 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 133.10 ns | 0.2822 ns | 0.2501 ns | 133.00 ns |  0.62 |    0.00 | 0.0038 |     - |     - |      24 B |
               From_Double_Nullable_WithValue_AsObject |        net461 | 322.39 ns | 0.4833 ns | 0.4520 ns | 322.19 ns |  1.50 |    0.01 | 0.0048 |     - |     - |      32 B |
               From_Double_Nullable_WithValue_AsObject |        net472 | 321.35 ns | 0.4461 ns | 0.3955 ns | 321.27 ns |  1.50 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  14.04 ns | 0.0568 ns | 0.0532 ns |  14.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  12.10 ns | 0.0160 ns | 0.0150 ns |  12.10 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  13.34 ns | 0.1137 ns | 0.1063 ns |  13.28 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  15.92 ns | 0.0994 ns | 0.0929 ns |  15.97 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  14.14 ns | 0.0334 ns | 0.0312 ns |  14.15 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.24 ns | 0.0240 ns | 0.0225 ns |  14.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.32 ns | 0.0143 ns | 0.0134 ns |  12.32 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.98 ns | 0.3249 ns | 0.4660 ns |  15.21 ns |  1.04 |    0.04 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  13.39 ns | 0.0151 ns | 0.0141 ns |  13.39 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  14.19 ns | 0.0175 ns | 0.0155 ns |  14.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  46.98 ns | 0.4694 ns | 0.4391 ns |  46.71 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 2.2 |  31.13 ns | 0.0589 ns | 0.0522 ns |  31.13 ns |  0.66 |    0.01 | 0.0051 |     - |     - |      32 B |
                                            From_Short | .NET Core 3.0 |  23.71 ns | 0.0421 ns | 0.0394 ns |  23.70 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 |  49.29 ns | 0.0711 ns | 0.0665 ns |  49.25 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                            From_Short |        net472 |  60.53 ns | 0.1234 ns | 0.1154 ns |  60.49 ns |  1.29 |    0.01 | 0.0050 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |  51.17 ns | 0.0444 ns | 0.0371 ns |  51.16 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 2.2 |  34.09 ns | 0.0556 ns | 0.0520 ns |  34.10 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject | .NET Core 3.0 |  28.64 ns | 0.0318 ns | 0.0298 ns |  28.66 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |  55.15 ns | 0.0559 ns | 0.0495 ns |  55.14 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_Short_AsObject |        net472 |  56.10 ns | 0.0666 ns | 0.0623 ns |  56.10 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  46.76 ns | 0.1015 ns | 0.0848 ns |  46.77 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  29.06 ns | 0.0523 ns | 0.0489 ns |  29.04 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  25.94 ns | 0.1775 ns | 0.1660 ns |  26.01 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  52.08 ns | 0.0696 ns | 0.0617 ns |  52.09 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_Short_Nullable_WithValue |        net472 |  49.63 ns | 0.0661 ns | 0.0586 ns |  49.62 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.61 ns | 0.2741 ns | 0.2564 ns |  51.72 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.56 ns | 0.0599 ns | 0.0561 ns |  32.57 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.82 ns | 0.0476 ns | 0.0446 ns |  28.83 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |  55.18 ns | 0.0760 ns | 0.0674 ns |  55.17 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_Short_Nullable_WithValue_AsObject |        net472 |  55.75 ns | 0.0766 ns | 0.0717 ns |  55.76 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  13.65 ns | 0.0224 ns | 0.0198 ns |  13.65 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  12.24 ns | 0.0143 ns | 0.0133 ns |  12.24 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  12.49 ns | 0.0480 ns | 0.0449 ns |  12.50 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  16.51 ns | 0.1122 ns | 0.1050 ns |  16.52 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  15.71 ns | 0.0189 ns | 0.0176 ns |  15.70 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.09 ns | 0.0221 ns | 0.0207 ns |  14.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0125 ns | 0.0117 ns |  12.34 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.26 ns | 0.2029 ns | 0.1898 ns |  14.11 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  13.41 ns | 0.0198 ns | 0.0185 ns |  13.42 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  13.75 ns | 0.0465 ns | 0.0412 ns |  13.77 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  46.80 ns | 0.4393 ns | 0.4109 ns |  47.00 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 2.2 |  28.60 ns | 0.0422 ns | 0.0329 ns |  28.60 ns |  0.61 |    0.01 | 0.0051 |     - |     - |      32 B |
                                              From_Int | .NET Core 3.0 |  24.55 ns | 0.0848 ns | 0.0752 ns |  24.54 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 |  49.86 ns | 0.0688 ns | 0.0643 ns |  49.85 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                                              From_Int |        net472 |  48.21 ns | 0.0586 ns | 0.0548 ns |  48.19 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |  53.22 ns | 0.1242 ns | 0.1162 ns |  53.17 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 2.2 |  32.81 ns | 0.0449 ns | 0.0420 ns |  32.80 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                     From_Int_AsObject | .NET Core 3.0 |  29.31 ns | 0.0519 ns | 0.0460 ns |  29.32 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |  59.42 ns | 0.1751 ns | 0.1638 ns |  59.40 ns |  1.12 |    0.00 | 0.0050 |     - |     - |      32 B |
                                     From_Int_AsObject |        net472 |  54.94 ns | 0.1286 ns | 0.1140 ns |  54.93 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  47.14 ns | 0.0352 ns | 0.0294 ns |  47.14 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  29.00 ns | 0.0894 ns | 0.0836 ns |  29.01 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  25.57 ns | 0.1899 ns | 0.1776 ns |  25.66 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  48.75 ns | 0.0518 ns | 0.0459 ns |  48.75 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                           From_Int_Nullable_WithValue |        net472 |  49.84 ns | 0.1529 ns | 0.1430 ns |  49.88 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.74 ns | 0.1877 ns | 0.1568 ns |  51.73 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.04 ns | 0.1424 ns | 0.1332 ns |  33.06 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.51 ns | 0.1016 ns | 0.0901 ns |  29.52 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |  54.86 ns | 0.0759 ns | 0.0710 ns |  54.86 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                  From_Int_Nullable_WithValue_AsObject |        net472 |  53.60 ns | 0.0389 ns | 0.0364 ns |  53.60 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  13.07 ns | 0.1254 ns | 0.1173 ns |  13.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  12.36 ns | 0.0147 ns | 0.0138 ns |  12.36 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  12.48 ns | 0.0389 ns | 0.0364 ns |  12.49 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  14.64 ns | 0.0557 ns | 0.0494 ns |  14.62 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  14.95 ns | 0.0184 ns | 0.0163 ns |  14.95 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.37 ns | 0.0142 ns | 0.0133 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0183 ns | 0.0162 ns |  12.33 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.84 ns | 0.3236 ns | 0.6157 ns |  15.08 ns |  1.07 |    0.07 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  13.53 ns | 0.0159 ns | 0.0141 ns |  13.53 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  13.61 ns | 0.0176 ns | 0.0164 ns |  13.61 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  48.12 ns | 0.3383 ns | 0.3164 ns |  48.26 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 2.2 |  29.38 ns | 0.0356 ns | 0.0333 ns |  29.38 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_Long | .NET Core 3.0 |  26.63 ns | 0.1909 ns | 0.1786 ns |  26.51 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 |  49.92 ns | 0.1504 ns | 0.1407 ns |  49.89 ns |  1.04 |    0.01 | 0.0051 |     - |     - |      32 B |
                                             From_Long |        net472 |  49.18 ns | 0.2206 ns | 0.1955 ns |  49.11 ns |  1.02 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |  53.28 ns | 0.1178 ns | 0.1102 ns |  53.24 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 2.2 |  34.25 ns | 0.0489 ns | 0.0458 ns |  34.24 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_Long_AsObject | .NET Core 3.0 |  30.09 ns | 0.6259 ns | 0.7687 ns |  30.11 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |  63.20 ns | 0.0971 ns | 0.0861 ns |  63.16 ns |  1.19 |    0.00 | 0.0050 |     - |     - |      32 B |
                                    From_Long_AsObject |        net472 |  54.96 ns | 0.0518 ns | 0.0405 ns |  54.97 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  50.55 ns | 0.0839 ns | 0.0785 ns |  50.56 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  29.30 ns | 0.0943 ns | 0.0882 ns |  29.26 ns |  0.58 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  25.05 ns | 0.0543 ns | 0.0453 ns |  25.03 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  53.10 ns | 0.1242 ns | 0.1101 ns |  53.08 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_Long_Nullable_WithValue |        net472 |  52.89 ns | 0.0705 ns | 0.0660 ns |  52.88 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |  52.77 ns | 0.0670 ns | 0.0627 ns |  52.77 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.33 ns | 0.1084 ns | 0.0905 ns |  34.36 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |  28.87 ns | 0.5658 ns | 0.5292 ns |  29.07 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |  54.47 ns | 0.0567 ns | 0.0503 ns |  54.48 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_Long_Nullable_WithValue_AsObject |        net472 |  55.10 ns | 0.2451 ns | 0.2293 ns |  55.05 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  13.54 ns | 0.0141 ns | 0.0125 ns |  13.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  12.77 ns | 0.1438 ns | 0.1345 ns |  12.73 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  13.34 ns | 0.0171 ns | 0.0151 ns |  13.33 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  15.44 ns | 0.0243 ns | 0.0227 ns |  15.44 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  14.17 ns | 0.0195 ns | 0.0162 ns |  14.17 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0213 ns | 0.0199 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.34 ns | 0.0152 ns | 0.0127 ns |  12.35 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.53 ns | 0.1052 ns | 0.0984 ns |  13.57 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  13.40 ns | 0.0738 ns | 0.0690 ns |  13.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  14.73 ns | 0.0156 ns | 0.0138 ns |  14.73 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  46.57 ns | 0.1146 ns | 0.1072 ns |  46.53 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 2.2 |  28.03 ns | 0.1091 ns | 0.0967 ns |  28.06 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte | .NET Core 3.0 |  24.78 ns | 0.4041 ns | 0.3780 ns |  24.58 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  48.21 ns | 0.1314 ns | 0.1165 ns |  48.18 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_SByte |        net472 |  50.75 ns | 0.2862 ns | 0.2677 ns |  50.60 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |  54.50 ns | 0.0449 ns | 0.0398 ns |  54.51 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 2.2 |  32.90 ns | 0.0453 ns | 0.0423 ns |  32.91 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject | .NET Core 3.0 |  29.56 ns | 0.2613 ns | 0.2317 ns |  29.65 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |  53.85 ns | 0.0842 ns | 0.0746 ns |  53.83 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_SByte_AsObject |        net472 |  53.81 ns | 0.0455 ns | 0.0403 ns |  53.80 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  46.61 ns | 0.1214 ns | 0.1014 ns |  46.62 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  29.06 ns | 0.0781 ns | 0.0692 ns |  29.06 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  25.79 ns | 0.2627 ns | 0.2458 ns |  25.68 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  50.64 ns | 0.2325 ns | 0.2175 ns |  50.56 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                         From_SByte_Nullable_WithValue |        net472 |  57.01 ns | 0.0681 ns | 0.0569 ns |  57.01 ns |  1.22 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |  51.02 ns | 0.0866 ns | 0.0810 ns |  51.02 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |  32.64 ns | 0.0374 ns | 0.0332 ns |  32.64 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.02 ns | 0.1065 ns | 0.0889 ns |  29.02 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |  57.29 ns | 0.0912 ns | 0.0809 ns |  57.26 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_SByte_Nullable_WithValue_AsObject |        net472 |  55.13 ns | 0.2639 ns | 0.2468 ns |  55.20 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  13.04 ns | 0.0144 ns | 0.0134 ns |  13.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  12.31 ns | 0.0192 ns | 0.0180 ns |  12.31 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  13.05 ns | 0.0280 ns | 0.0262 ns |  13.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  13.30 ns | 0.0168 ns | 0.0158 ns |  13.29 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  13.30 ns | 0.0173 ns | 0.0135 ns |  13.30 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.99 ns | 0.0189 ns | 0.0177 ns |  14.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.43 ns | 0.0213 ns | 0.0188 ns |  12.43 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.74 ns | 0.5449 ns | 0.5596 ns |  13.46 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  13.53 ns | 0.0491 ns | 0.0459 ns |  13.54 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  13.38 ns | 0.0751 ns | 0.0703 ns |  13.36 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 179.75 ns | 0.2109 ns | 0.1869 ns | 179.70 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 2.2 | 117.08 ns | 0.1327 ns | 0.1242 ns | 117.10 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
                                            From_Float | .NET Core 3.0 | 125.46 ns | 0.2325 ns | 0.2061 ns | 125.46 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net461 | 295.25 ns | 0.5255 ns | 0.4658 ns | 295.34 ns |  1.64 |    0.00 | 0.0048 |     - |     - |      32 B |
                                            From_Float |        net472 | 294.78 ns | 1.2971 ns | 1.2133 ns | 294.32 ns |  1.64 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 186.38 ns | 0.1360 ns | 0.1272 ns | 186.36 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 2.2 | 121.73 ns | 0.3106 ns | 0.2905 ns | 121.75 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
                                   From_Float_AsObject | .NET Core 3.0 | 131.97 ns | 0.2798 ns | 0.2337 ns | 132.00 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                                   From_Float_AsObject |        net461 | 311.62 ns | 1.7575 ns | 1.6440 ns | 311.86 ns |  1.67 |    0.01 | 0.0048 |     - |     - |      32 B |
                                   From_Float_AsObject |        net472 | 301.79 ns | 0.2276 ns | 0.2018 ns | 301.83 ns |  1.62 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 179.16 ns | 0.2519 ns | 0.2356 ns | 179.13 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 118.21 ns | 0.3605 ns | 0.3011 ns | 118.32 ns |  0.66 |    0.00 | 0.0050 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 127.49 ns | 0.2676 ns | 0.2372 ns | 127.47 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net461 | 301.38 ns | 0.6909 ns | 0.6462 ns | 301.20 ns |  1.68 |    0.00 | 0.0048 |     - |     - |      32 B |
                         From_Float_Nullable_WithValue |        net472 | 297.90 ns | 1.7001 ns | 1.5903 ns | 297.19 ns |  1.66 |    0.01 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 187.70 ns | 0.1990 ns | 0.1862 ns | 187.68 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 122.18 ns | 0.1671 ns | 0.1395 ns | 122.21 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 132.43 ns | 0.2246 ns | 0.2101 ns | 132.37 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                From_Float_Nullable_WithValue_AsObject |        net461 | 304.31 ns | 0.3606 ns | 0.3373 ns | 304.42 ns |  1.62 |    0.00 | 0.0048 |     - |     - |      32 B |
                From_Float_Nullable_WithValue_AsObject |        net472 | 300.90 ns | 0.3764 ns | 0.3337 ns | 300.95 ns |  1.60 |    0.00 | 0.0048 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  13.92 ns | 0.0242 ns | 0.0226 ns |  13.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  12.07 ns | 0.0256 ns | 0.0227 ns |  12.07 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  12.58 ns | 0.0138 ns | 0.0122 ns |  12.59 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  14.42 ns | 0.0979 ns | 0.0915 ns |  14.38 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  13.11 ns | 0.0190 ns | 0.0178 ns |  13.11 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.35 ns | 0.0108 ns | 0.0090 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.45 ns | 0.0498 ns | 0.0466 ns |  12.45 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.44 ns | 0.0536 ns | 0.0447 ns |  13.44 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  13.56 ns | 0.0173 ns | 0.0153 ns |  13.56 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  13.41 ns | 0.0744 ns | 0.0696 ns |  13.45 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 |  12.21 ns | 0.0230 ns | 0.0203 ns |  12.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 |  11.45 ns | 0.0161 ns | 0.0151 ns |  11.45 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 |  12.73 ns | 0.0588 ns | 0.0550 ns |  12.70 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 |  11.97 ns | 0.0170 ns | 0.0159 ns |  11.97 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 |  11.90 ns | 0.0167 ns | 0.0139 ns |  11.90 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 |  13.91 ns | 0.0192 ns | 0.0180 ns |  13.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 |  12.80 ns | 0.0173 ns | 0.0145 ns |  12.81 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 |  16.92 ns | 0.1719 ns | 0.1608 ns |  17.01 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 |  14.14 ns | 0.0783 ns | 0.0732 ns |  14.14 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 |  13.78 ns | 0.0209 ns | 0.0196 ns |  13.78 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.30 ns | 0.0122 ns | 0.0108 ns |  12.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  12.30 ns | 0.0137 ns | 0.0114 ns |  12.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  12.01 ns | 0.0998 ns | 0.0933 ns |  12.07 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  13.10 ns | 0.0331 ns | 0.0310 ns |  13.09 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  12.53 ns | 0.2336 ns | 0.2185 ns |  12.55 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  14.09 ns | 0.0144 ns | 0.0127 ns |  14.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  12.30 ns | 0.0083 ns | 0.0078 ns |  12.30 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  16.08 ns | 0.0147 ns | 0.0130 ns |  16.08 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  14.47 ns | 0.0254 ns | 0.0237 ns |  14.47 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  13.33 ns | 0.0230 ns | 0.0180 ns |  13.33 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  12.98 ns | 0.0124 ns | 0.0116 ns |  12.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  11.38 ns | 0.0101 ns | 0.0085 ns |  11.38 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.07 ns | 0.0099 ns | 0.0093 ns |  12.07 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  12.04 ns | 0.0800 ns | 0.0749 ns |  12.00 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  11.90 ns | 0.0176 ns | 0.0165 ns |  11.90 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |  14.16 ns | 0.0529 ns | 0.0495 ns |  14.17 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |  12.78 ns | 0.0102 ns | 0.0090 ns |  12.78 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |  13.88 ns | 0.0693 ns | 0.0648 ns |  13.91 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |  14.78 ns | 0.0190 ns | 0.0159 ns |  14.78 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |  14.37 ns | 0.0762 ns | 0.0712 ns |  14.34 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  44.24 ns | 0.0727 ns | 0.0680 ns |  44.22 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 2.2 |  27.56 ns | 0.0391 ns | 0.0365 ns |  27.55 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort | .NET Core 3.0 |  24.43 ns | 0.1547 ns | 0.1447 ns |  24.48 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  48.67 ns | 0.0730 ns | 0.0647 ns |  48.65 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                                           From_UShort |        net472 |  47.92 ns | 0.0884 ns | 0.0784 ns |  47.91 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |  49.59 ns | 0.0751 ns | 0.0703 ns |  49.60 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 2.2 |  34.21 ns | 0.1021 ns | 0.0955 ns |  34.18 ns |  0.69 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject | .NET Core 3.0 |  29.20 ns | 0.0851 ns | 0.0755 ns |  29.18 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |  55.86 ns | 0.1506 ns | 0.1335 ns |  55.84 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                                  From_UShort_AsObject |        net472 |  53.14 ns | 0.1055 ns | 0.0987 ns |  53.14 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  45.00 ns | 0.1163 ns | 0.1088 ns |  44.99 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  28.33 ns | 0.0374 ns | 0.0350 ns |  28.35 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  24.93 ns | 0.0807 ns | 0.0755 ns |  24.96 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  51.90 ns | 0.0904 ns | 0.0802 ns |  51.88 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                        From_UShort_Nullable_WithValue |        net472 |  48.66 ns | 0.2142 ns | 0.2003 ns |  48.60 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |  50.24 ns | 0.1935 ns | 0.1810 ns |  50.19 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.68 ns | 0.0616 ns | 0.0576 ns |  33.67 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |  29.61 ns | 0.0457 ns | 0.0405 ns |  29.60 ns |  0.59 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |  55.01 ns | 0.0891 ns | 0.0834 ns |  54.99 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
               From_UShort_Nullable_WithValue_AsObject |        net472 |  58.70 ns | 0.1218 ns | 0.1140 ns |  58.70 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  12.90 ns | 0.0128 ns | 0.0119 ns |  12.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  12.90 ns | 0.0111 ns | 0.0103 ns |  12.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  12.51 ns | 0.1292 ns | 0.1209 ns |  12.60 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  13.35 ns | 0.0762 ns | 0.0713 ns |  13.31 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  16.03 ns | 0.0176 ns | 0.0164 ns |  16.03 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.51 ns | 0.0507 ns | 0.0474 ns |  13.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.05 ns | 0.0747 ns | 0.0699 ns |  13.05 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.44 ns | 0.3036 ns | 0.4053 ns |  14.65 ns |  1.06 |    0.04 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  13.44 ns | 0.0231 ns | 0.0205 ns |  13.44 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  15.34 ns | 0.0841 ns | 0.0786 ns |  15.31 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  44.41 ns | 0.0586 ns | 0.0489 ns |  44.41 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 2.2 |  30.14 ns | 0.0327 ns | 0.0306 ns |  30.15 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt | .NET Core 3.0 |  24.38 ns | 0.0554 ns | 0.0519 ns |  24.38 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  54.95 ns | 0.0956 ns | 0.0894 ns |  54.92 ns |  1.24 |    0.00 | 0.0051 |     - |     - |      32 B |
                                             From_UInt |        net472 |  48.23 ns | 0.0487 ns | 0.0455 ns |  48.23 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |  49.74 ns | 0.1682 ns | 0.1574 ns |  49.72 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 2.2 |  32.53 ns | 0.0454 ns | 0.0402 ns |  32.53 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject | .NET Core 3.0 |  28.75 ns | 0.1166 ns | 0.1034 ns |  28.72 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |  53.38 ns | 0.0883 ns | 0.0826 ns |  53.39 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
                                    From_UInt_AsObject |        net472 |  57.31 ns | 0.0618 ns | 0.0578 ns |  57.33 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  45.61 ns | 0.1488 ns | 0.1392 ns |  45.66 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  28.28 ns | 0.0400 ns | 0.0334 ns |  28.28 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  25.37 ns | 0.1035 ns | 0.0968 ns |  25.40 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  53.20 ns | 0.1715 ns | 0.1604 ns |  53.19 ns |  1.17 |    0.01 | 0.0051 |     - |     - |      32 B |
                          From_UInt_Nullable_WithValue |        net472 |  49.64 ns | 0.1623 ns | 0.1518 ns |  49.61 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |  48.71 ns | 0.0591 ns | 0.0524 ns |  48.70 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |  33.00 ns | 0.1475 ns | 0.1307 ns |  32.97 ns |  0.68 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |  31.31 ns | 0.0837 ns | 0.0783 ns |  31.28 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |  53.36 ns | 0.0705 ns | 0.0660 ns |  53.38 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |  54.79 ns | 0.0374 ns | 0.0350 ns |  54.80 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  13.62 ns | 0.0128 ns | 0.0107 ns |  13.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  12.30 ns | 0.0117 ns | 0.0104 ns |  12.30 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  13.05 ns | 0.0203 ns | 0.0180 ns |  13.04 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  14.60 ns | 0.0246 ns | 0.0218 ns |  14.60 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  15.01 ns | 0.0751 ns | 0.0703 ns |  14.98 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0194 ns | 0.0162 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.85 ns | 0.0111 ns | 0.0104 ns |  12.86 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  18.50 ns | 0.3951 ns | 0.7225 ns |  18.88 ns |  1.32 |    0.06 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  15.28 ns | 0.0664 ns | 0.0621 ns |  15.30 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  14.13 ns | 0.0229 ns | 0.0203 ns |  14.13 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  46.69 ns | 0.1214 ns | 0.1014 ns |  46.65 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 2.2 |  28.83 ns | 0.0385 ns | 0.0341 ns |  28.82 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong | .NET Core 3.0 |  24.16 ns | 0.2974 ns | 0.2782 ns |  23.97 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  49.08 ns | 0.0836 ns | 0.0698 ns |  49.07 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                                            From_ULong |        net472 |  49.42 ns | 0.0491 ns | 0.0459 ns |  49.41 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |  51.95 ns | 0.0628 ns | 0.0556 ns |  51.96 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 2.2 |  33.78 ns | 0.0731 ns | 0.0610 ns |  33.79 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject | .NET Core 3.0 |  29.00 ns | 0.1062 ns | 0.0887 ns |  28.99 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |  56.25 ns | 0.3210 ns | 0.3003 ns |  56.38 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                                   From_ULong_AsObject |        net472 |  53.34 ns | 0.0650 ns | 0.0608 ns |  53.35 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  50.13 ns | 0.0586 ns | 0.0519 ns |  50.13 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  30.34 ns | 0.0452 ns | 0.0423 ns |  30.34 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  25.29 ns | 0.1010 ns | 0.0944 ns |  25.30 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  50.96 ns | 0.0653 ns | 0.0545 ns |  50.94 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                         From_ULong_Nullable_WithValue |        net472 |  51.28 ns | 0.0990 ns | 0.0877 ns |  51.27 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |  52.91 ns | 0.2008 ns | 0.1780 ns |  52.95 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |  34.03 ns | 0.0933 ns | 0.0872 ns |  34.02 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |  30.86 ns | 0.5105 ns | 0.4525 ns |  30.98 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |  55.44 ns | 0.0539 ns | 0.0478 ns |  55.44 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                From_ULong_Nullable_WithValue_AsObject |        net472 |  53.31 ns | 0.0447 ns | 0.0418 ns |  53.30 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.35 ns | 0.0108 ns | 0.0101 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  13.96 ns | 0.0114 ns | 0.0101 ns |  13.96 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  13.35 ns | 0.0211 ns | 0.0176 ns |  13.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  15.56 ns | 0.0671 ns | 0.0628 ns |  15.59 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  13.97 ns | 0.0275 ns | 0.0230 ns |  13.97 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0124 ns | 0.0110 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0157 ns | 0.0139 ns |  12.32 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.40 ns | 0.1901 ns | 0.1778 ns |  13.53 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  13.39 ns | 0.0426 ns | 0.0398 ns |  13.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  14.76 ns | 0.0888 ns | 0.0788 ns |  14.79 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  13.48 ns | 0.0226 ns | 0.0212 ns |  13.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  12.85 ns | 0.0120 ns | 0.0112 ns |  12.84 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  12.83 ns | 0.1061 ns | 0.0992 ns |  12.77 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  13.38 ns | 0.0148 ns | 0.0116 ns |  13.39 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  14.94 ns | 0.0105 ns | 0.0088 ns |  14.94 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  12.27 ns | 0.0147 ns | 0.0137 ns |  12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  11.38 ns | 0.0159 ns | 0.0149 ns |  11.38 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  13.35 ns | 0.9437 ns | 0.9691 ns |  12.83 ns |  1.09 |    0.08 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  11.99 ns | 0.0137 ns | 0.0121 ns |  11.99 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  13.51 ns | 0.0458 ns | 0.0428 ns |  13.51 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  14.33 ns | 0.1666 ns | 0.1558 ns |  14.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  12.32 ns | 0.0114 ns | 0.0107 ns |  12.33 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  13.29 ns | 0.0130 ns | 0.0122 ns |  13.29 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  13.47 ns | 0.0156 ns | 0.0138 ns |  13.46 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  14.88 ns | 0.0152 ns | 0.0142 ns |  14.88 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  16.31 ns | 0.0275 ns | 0.0257 ns |  16.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  15.35 ns | 0.0998 ns | 0.0934 ns |  15.30 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  14.69 ns | 0.2147 ns | 0.2008 ns |  14.77 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  17.38 ns | 0.0179 ns | 0.0159 ns |  17.38 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  17.40 ns | 0.0215 ns | 0.0201 ns |  17.40 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  17.83 ns | 0.0210 ns | 0.0186 ns |  17.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  16.52 ns | 0.0287 ns | 0.0239 ns |  16.52 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  16.12 ns | 0.0266 ns | 0.0248 ns |  16.12 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  17.58 ns | 0.0201 ns | 0.0188 ns |  17.58 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  17.82 ns | 0.1374 ns | 0.1285 ns |  17.77 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  14.38 ns | 0.0260 ns | 0.0230 ns |  14.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  13.12 ns | 0.0101 ns | 0.0094 ns |  13.12 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  12.96 ns | 0.1882 ns | 0.1760 ns |  12.81 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  14.95 ns | 0.0955 ns | 0.0893 ns |  15.00 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  13.73 ns | 0.0275 ns | 0.0215 ns |  13.73 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.45 ns | 0.0484 ns | 0.0429 ns |  13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.59 ns | 0.0152 ns | 0.0135 ns |  12.58 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  14.54 ns | 0.3105 ns | 0.2904 ns |  14.75 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  13.38 ns | 0.0213 ns | 0.0178 ns |  13.38 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  14.90 ns | 0.1139 ns | 0.0951 ns |  14.90 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  20.14 ns | 0.0263 ns | 0.0246 ns |  20.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  18.67 ns | 0.0258 ns | 0.0229 ns |  18.66 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  17.62 ns | 0.1554 ns | 0.1378 ns |  17.59 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  21.89 ns | 0.0254 ns | 0.0237 ns |  21.89 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  22.20 ns | 0.2479 ns | 0.2319 ns |  22.26 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  25.58 ns | 0.0251 ns | 0.0235 ns |  25.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  23.84 ns | 0.0387 ns | 0.0362 ns |  23.83 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  23.04 ns | 0.4232 ns | 0.6588 ns |  23.42 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  26.28 ns | 0.0963 ns | 0.0901 ns |  26.32 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  26.08 ns | 0.5047 ns | 0.4721 ns |  25.93 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  13.35 ns | 0.0217 ns | 0.0181 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  12.32 ns | 0.0150 ns | 0.0141 ns |  12.32 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  13.11 ns | 0.0302 ns | 0.0268 ns |  13.11 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  14.33 ns | 0.0313 ns | 0.0278 ns |  14.32 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  13.12 ns | 0.0124 ns | 0.0110 ns |  13.12 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.51 ns | 0.0341 ns | 0.0319 ns |  13.49 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0126 ns | 0.0111 ns |  12.33 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  16.64 ns | 0.0982 ns | 0.0919 ns |  16.68 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  13.36 ns | 0.0269 ns | 0.0239 ns |  13.36 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.68 ns | 0.0314 ns | 0.0278 ns |  13.67 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  19.95 ns | 0.0505 ns | 0.0473 ns |  19.97 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  16.96 ns | 0.0470 ns | 0.0439 ns |  16.95 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  17.64 ns | 0.3775 ns | 0.6612 ns |  18.00 ns |  0.85 |    0.04 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  18.68 ns | 0.0284 ns | 0.0266 ns |  18.69 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  19.01 ns | 0.0328 ns | 0.0307 ns |  19.00 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  21.14 ns | 0.0219 ns | 0.0205 ns |  21.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  16.68 ns | 0.0233 ns | 0.0206 ns |  16.68 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  17.76 ns | 0.3741 ns | 0.5245 ns |  17.36 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  17.92 ns | 0.0472 ns | 0.0419 ns |  17.90 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  20.34 ns | 0.0200 ns | 0.0187 ns |  20.34 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  19.77 ns | 0.1021 ns | 0.0955 ns |  19.73 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  17.19 ns | 0.0303 ns | 0.0283 ns |  17.19 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  18.20 ns | 0.1089 ns | 0.1018 ns |  18.17 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  20.45 ns | 0.0368 ns | 0.0326 ns |  20.44 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  19.37 ns | 0.0235 ns | 0.0196 ns |  19.37 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  18.66 ns | 0.0732 ns | 0.0649 ns |  18.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  16.52 ns | 0.0184 ns | 0.0173 ns |  16.53 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  17.45 ns | 0.0603 ns | 0.0471 ns |  17.46 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  17.98 ns | 0.0345 ns | 0.0306 ns |  17.99 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  18.01 ns | 0.0986 ns | 0.0922 ns |  18.01 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.78 ns | 0.0082 ns | 0.0077 ns |  13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.28 ns | 0.0147 ns | 0.0123 ns |  12.28 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  12.59 ns | 0.0332 ns | 0.0259 ns |  12.58 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  15.48 ns | 0.0273 ns | 0.0255 ns |  15.47 ns |  1.12 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  13.54 ns | 0.0421 ns | 0.0394 ns |  13.54 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.36 ns | 0.0185 ns | 0.0164 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.33 ns | 0.0169 ns | 0.0158 ns |  12.32 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.40 ns | 0.3136 ns | 0.3080 ns |  14.16 ns |  1.07 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.38 ns | 0.0142 ns | 0.0126 ns |  13.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  13.31 ns | 0.0128 ns | 0.0119 ns |  13.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  27.12 ns | 0.0335 ns | 0.0297 ns |  27.11 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 2.2 |  23.21 ns | 0.0448 ns | 0.0397 ns |  23.21 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 3.0 |  20.45 ns | 0.1066 ns | 0.0945 ns |  20.49 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net461 |  25.30 ns | 0.1668 ns | 0.1560 ns |  25.20 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net472 |  24.58 ns | 0.0385 ns | 0.0360 ns |  24.58 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  27.92 ns | 0.0164 ns | 0.0145 ns |  27.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  27.12 ns | 0.0292 ns | 0.0273 ns |  27.12 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  21.86 ns | 0.0994 ns | 0.0930 ns |  21.83 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  26.72 ns | 0.1433 ns | 0.1341 ns |  26.71 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  27.79 ns | 0.0803 ns | 0.0712 ns |  27.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  27.03 ns | 0.0464 ns | 0.0434 ns |  27.02 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  23.97 ns | 0.0322 ns | 0.0269 ns |  23.96 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  21.54 ns | 0.0558 ns | 0.0522 ns |  21.53 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  26.81 ns | 0.0375 ns | 0.0350 ns |  26.81 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  25.05 ns | 0.0391 ns | 0.0365 ns |  25.04 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  27.11 ns | 0.0252 ns | 0.0223 ns |  27.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.01 ns | 0.0466 ns | 0.0436 ns |  27.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.46 ns | 0.3779 ns | 0.3534 ns |  23.68 ns |  0.86 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  29.25 ns | 0.1154 ns | 0.1079 ns |  29.19 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  26.45 ns | 0.0285 ns | 0.0238 ns |  26.45 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.05 ns | 0.0192 ns | 0.0170 ns |  13.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  11.91 ns | 0.0129 ns | 0.0108 ns |  11.91 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  12.59 ns | 0.0074 ns | 0.0062 ns |  12.59 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  13.83 ns | 0.0227 ns | 0.0177 ns |  13.83 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  12.48 ns | 0.0302 ns | 0.0283 ns |  12.48 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.37 ns | 0.0279 ns | 0.0248 ns |  13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.38 ns | 0.0130 ns | 0.0121 ns |  12.38 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.32 ns | 0.0219 ns | 0.0194 ns |  13.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  13.42 ns | 0.0198 ns | 0.0186 ns |  13.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.51 ns | 0.0210 ns | 0.0196 ns |  14.52 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  27.26 ns | 0.0395 ns | 0.0370 ns |  27.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  23.63 ns | 0.0222 ns | 0.0185 ns |  23.64 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  22.01 ns | 0.0835 ns | 0.0740 ns |  22.04 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  30.86 ns | 0.0585 ns | 0.0547 ns |  30.87 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  28.87 ns | 0.1260 ns | 0.1178 ns |  28.93 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |  66.35 ns | 0.1517 ns | 0.1345 ns |  66.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |  65.68 ns | 0.2535 ns | 0.2371 ns |  65.66 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |  44.90 ns | 0.1037 ns | 0.0919 ns |  44.87 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 307.48 ns | 0.4593 ns | 0.4071 ns | 307.57 ns |  4.63 |    0.01 | 0.0076 |     - |     - |      48 B |
                                    From_Enum_AsObject |        net472 | 309.68 ns | 0.5384 ns | 0.5037 ns | 309.44 ns |  4.67 |    0.01 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  27.44 ns | 0.0220 ns | 0.0195 ns |  27.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  24.77 ns | 0.0223 ns | 0.0187 ns |  24.76 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  22.94 ns | 0.4740 ns | 0.6489 ns |  22.41 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  32.53 ns | 0.0363 ns | 0.0340 ns |  32.53 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  29.83 ns | 0.0398 ns | 0.0373 ns |  29.83 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |  65.19 ns | 0.0748 ns | 0.0663 ns |  65.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |  63.67 ns | 0.0702 ns | 0.0657 ns |  63.68 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |  45.73 ns | 0.9228 ns | 1.6403 ns |  44.64 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 328.45 ns | 4.4203 ns | 4.1348 ns | 330.95 ns |  5.04 |    0.07 | 0.0076 |     - |     - |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 312.96 ns | 1.8397 ns | 1.7208 ns | 313.48 ns |  4.80 |    0.02 | 0.0076 |     - |     - |      48 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  13.00 ns | 0.0147 ns | 0.0131 ns |  13.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  11.93 ns | 0.0117 ns | 0.0104 ns |  11.93 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  13.10 ns | 0.0579 ns | 0.0541 ns |  13.09 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  13.30 ns | 0.0131 ns | 0.0102 ns |  13.30 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  13.77 ns | 0.0262 ns | 0.0232 ns |  13.76 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.35 ns | 0.0097 ns | 0.0081 ns |  13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.67 ns | 0.0109 ns | 0.0096 ns |  12.67 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.24 ns | 0.1627 ns | 0.1522 ns |  14.14 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  13.47 ns | 0.0168 ns | 0.0157 ns |  13.47 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  19.63 ns | 0.0205 ns | 0.0182 ns |  19.63 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  20.15 ns | 0.0314 ns | 0.0294 ns |  20.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  18.68 ns | 0.0311 ns | 0.0276 ns |  18.69 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  17.71 ns | 0.0623 ns | 0.0583 ns |  17.72 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  22.07 ns | 0.1355 ns | 0.1268 ns |  22.15 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  22.17 ns | 0.0226 ns | 0.0188 ns |  22.17 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  25.54 ns | 0.0301 ns | 0.0267 ns |  25.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  24.44 ns | 0.0284 ns | 0.0266 ns |  24.43 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  22.29 ns | 0.0388 ns | 0.0344 ns |  22.28 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  28.59 ns | 0.0380 ns | 0.0337 ns |  28.59 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  26.32 ns | 0.0404 ns | 0.0358 ns |  26.32 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  13.52 ns | 0.0160 ns | 0.0150 ns |  13.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  12.05 ns | 0.0177 ns | 0.0157 ns |  12.05 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  13.16 ns | 0.0152 ns | 0.0135 ns |  13.16 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  14.27 ns | 0.0257 ns | 0.0241 ns |  14.26 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  14.35 ns | 0.0264 ns | 0.0247 ns |  14.35 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  13.41 ns | 0.0111 ns | 0.0104 ns |  13.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  12.35 ns | 0.0173 ns | 0.0162 ns |  12.34 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  16.45 ns | 0.0485 ns | 0.0430 ns |  16.45 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  15.33 ns | 0.0535 ns | 0.0500 ns |  15.34 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  14.47 ns | 0.0186 ns | 0.0174 ns |  14.48 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  92.97 ns | 0.2275 ns | 0.2128 ns |  93.08 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 |  91.19 ns | 0.0885 ns | 0.0828 ns |  91.19 ns |  0.98 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 |  95.01 ns | 0.5732 ns | 0.5361 ns |  95.08 ns |  1.02 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 |  93.57 ns | 0.1394 ns | 0.1236 ns |  93.60 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 |  96.18 ns | 0.6119 ns | 0.5724 ns |  96.27 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  25.83 ns | 0.1312 ns | 0.1095 ns |  25.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  24.45 ns | 0.0335 ns | 0.0314 ns |  24.45 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  22.41 ns | 0.0304 ns | 0.0270 ns |  22.40 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  26.81 ns | 0.0414 ns | 0.0388 ns |  26.79 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  27.79 ns | 0.1436 ns | 0.1273 ns |  27.84 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 116.19 ns | 0.2388 ns | 0.2234 ns | 116.17 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 115.07 ns | 0.1989 ns | 0.1860 ns | 115.06 ns |  0.99 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 122.15 ns | 1.7851 ns | 1.6698 ns | 122.25 ns |  1.05 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 119.46 ns | 0.8672 ns | 0.8112 ns | 119.11 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 117.07 ns | 0.1984 ns | 0.1856 ns | 117.09 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  26.28 ns | 0.2772 ns | 0.2458 ns |  26.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  27.24 ns | 0.0124 ns | 0.0116 ns |  27.24 ns |  1.04 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  23.26 ns | 0.0255 ns | 0.0238 ns |  23.27 ns |  0.89 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  26.77 ns | 0.0248 ns | 0.0207 ns |  26.77 ns |  1.02 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  26.06 ns | 0.0331 ns | 0.0310 ns |  26.05 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  56.67 ns | 0.0733 ns | 0.0686 ns |  56.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  56.14 ns | 0.0488 ns | 0.0456 ns |  56.14 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  56.77 ns | 0.0631 ns | 0.0527 ns |  56.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  59.14 ns | 0.0505 ns | 0.0473 ns |  59.16 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  62.74 ns | 0.3244 ns | 0.3034 ns |  62.61 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.04 ns | 0.0175 ns | 0.0164 ns |  14.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.32 ns | 0.0171 ns | 0.0151 ns |  12.31 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.63 ns | 0.2856 ns | 0.2805 ns |  13.48 ns |  0.97 |    0.02 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  13.49 ns | 0.0156 ns | 0.0138 ns |  13.49 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  13.32 ns | 0.0133 ns | 0.0124 ns |  13.33 ns |  0.95 |    0.00 |      - |     - |     - |         - |
