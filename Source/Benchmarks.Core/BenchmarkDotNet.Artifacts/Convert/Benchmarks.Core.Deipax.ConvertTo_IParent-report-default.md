
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
                                             From_Bool | .NET Core 2.0 | 13.57 ns | 0.0175 ns | 0.0155 ns | 13.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.68 ns | 0.0125 ns | 0.0111 ns | 12.68 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 12.62 ns | 0.0102 ns | 0.0095 ns | 12.62 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 15.77 ns | 0.0175 ns | 0.0164 ns | 15.78 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 15.67 ns | 0.0265 ns | 0.0235 ns | 15.67 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.21 ns | 0.0258 ns | 0.0215 ns | 20.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 19.81 ns | 0.0228 ns | 0.0213 ns | 19.81 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.57 ns | 0.0233 ns | 0.0218 ns | 17.58 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 22.14 ns | 0.0166 ns | 0.0155 ns | 22.14 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 23.46 ns | 0.0701 ns | 0.0655 ns | 23.48 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.84 ns | 0.0161 ns | 0.0151 ns | 13.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 13.14 ns | 0.0069 ns | 0.0061 ns | 13.14 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 11.93 ns | 0.0369 ns | 0.0345 ns | 11.94 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.69 ns | 0.0163 ns | 0.0153 ns | 14.69 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 14.89 ns | 0.0181 ns | 0.0169 ns | 14.89 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.22 ns | 0.0155 ns | 0.0145 ns | 20.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.73 ns | 0.0230 ns | 0.0192 ns | 18.73 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.74 ns | 0.4361 ns | 0.7165 ns | 20.95 ns |  1.01 |    0.05 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 22.04 ns | 0.1310 ns | 0.1225 ns | 21.97 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 23.82 ns | 0.0330 ns | 0.0293 ns | 23.83 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.67 ns | 0.0180 ns | 0.0141 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 13.83 ns | 0.0123 ns | 0.0109 ns | 13.83 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 12.38 ns | 0.0156 ns | 0.0139 ns | 12.38 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.95 ns | 0.0201 ns | 0.0188 ns | 14.94 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 14.70 ns | 0.0168 ns | 0.0157 ns | 14.70 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.10 ns | 0.0214 ns | 0.0200 ns | 17.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.95 ns | 0.0115 ns | 0.0096 ns | 14.95 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.82 ns | 0.0265 ns | 0.0235 ns | 13.82 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 16.47 ns | 0.0204 ns | 0.0190 ns | 16.47 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 18.04 ns | 0.3528 ns | 0.5280 ns | 17.93 ns |  1.07 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 13.63 ns | 0.0114 ns | 0.0095 ns | 13.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 12.70 ns | 0.0124 ns | 0.0116 ns | 12.70 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 12.57 ns | 0.0338 ns | 0.0316 ns | 12.58 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 14.80 ns | 0.0218 ns | 0.0194 ns | 14.81 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 15.84 ns | 0.1397 ns | 0.1238 ns | 15.83 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 21.14 ns | 0.0671 ns | 0.0628 ns | 21.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 19.38 ns | 0.0174 ns | 0.0154 ns | 19.38 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.26 ns | 0.4202 ns | 0.6664 ns | 17.89 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 23.42 ns | 0.0280 ns | 0.0249 ns | 23.42 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 24.93 ns | 0.2592 ns | 0.2425 ns | 24.84 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.66 ns | 0.0174 ns | 0.0163 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 13.15 ns | 0.0137 ns | 0.0122 ns | 13.15 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 14.34 ns | 0.0189 ns | 0.0177 ns | 14.34 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.64 ns | 0.0747 ns | 0.0699 ns | 14.61 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 15.14 ns | 0.3845 ns | 0.3776 ns | 15.01 ns |  1.11 |    0.03 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.98 ns | 0.0243 ns | 0.0189 ns | 20.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.36 ns | 0.0264 ns | 0.0247 ns | 19.36 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.94 ns | 0.1395 ns | 0.1305 ns | 19.00 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 22.48 ns | 0.0328 ns | 0.0307 ns | 22.48 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 24.33 ns | 0.0995 ns | 0.0882 ns | 24.29 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 13.79 ns | 0.0122 ns | 0.0114 ns | 13.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 13.96 ns | 0.0688 ns | 0.0643 ns | 14.00 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 | 11.83 ns | 0.0344 ns | 0.0322 ns | 11.83 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.67 ns | 0.0163 ns | 0.0152 ns | 14.67 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 14.66 ns | 0.0105 ns | 0.0088 ns | 14.66 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.91 ns | 0.0957 ns | 0.0895 ns | 15.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.99 ns | 0.0122 ns | 0.0108 ns | 13.99 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.03 ns | 0.0232 ns | 0.0217 ns | 13.02 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 18.13 ns | 0.0801 ns | 0.0749 ns | 18.15 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.79 ns | 0.0530 ns | 0.0469 ns | 16.78 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.56 ns | 0.0126 ns | 0.0118 ns | 13.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 12.68 ns | 0.0108 ns | 0.0095 ns | 12.68 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 | 13.18 ns | 0.0246 ns | 0.0230 ns | 13.18 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.68 ns | 0.0146 ns | 0.0129 ns | 14.68 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 14.70 ns | 0.0115 ns | 0.0107 ns | 14.70 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.51 ns | 0.0247 ns | 0.0231 ns | 20.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 19.68 ns | 0.0157 ns | 0.0139 ns | 19.67 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.46 ns | 0.0852 ns | 0.0797 ns | 18.49 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 21.99 ns | 0.0247 ns | 0.0206 ns | 21.99 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 21.99 ns | 0.0235 ns | 0.0219 ns | 21.99 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.81 ns | 0.0484 ns | 0.0452 ns | 13.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 13.17 ns | 0.0245 ns | 0.0229 ns | 13.17 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 13.79 ns | 0.2977 ns | 0.4456 ns | 13.95 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 14.65 ns | 0.0185 ns | 0.0164 ns | 14.65 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 14.68 ns | 0.0160 ns | 0.0149 ns | 14.68 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.43 ns | 0.0337 ns | 0.0299 ns | 20.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.91 ns | 0.0441 ns | 0.0413 ns | 18.92 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.53 ns | 0.3033 ns | 0.2837 ns | 20.63 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 22.01 ns | 0.0270 ns | 0.0252 ns | 22.01 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 23.73 ns | 0.0282 ns | 0.0263 ns | 23.73 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 13.70 ns | 0.0694 ns | 0.0649 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 13.16 ns | 0.0251 ns | 0.0235 ns | 13.16 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 | 13.57 ns | 0.2942 ns | 0.4219 ns | 13.79 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.59 ns | 0.0192 ns | 0.0179 ns | 14.59 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 15.69 ns | 0.0938 ns | 0.0878 ns | 15.65 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.12 ns | 0.0184 ns | 0.0163 ns | 15.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.06 ns | 0.0428 ns | 0.0400 ns | 15.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.14 ns | 0.2278 ns | 0.2131 ns | 13.02 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 17.51 ns | 0.0979 ns | 0.0916 ns | 17.46 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 20.28 ns | 0.0481 ns | 0.0426 ns | 20.27 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 14.67 ns | 0.0461 ns | 0.0408 ns | 14.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 12.89 ns | 0.0099 ns | 0.0087 ns | 12.90 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 13.60 ns | 0.1073 ns | 0.1004 ns | 13.65 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 16.41 ns | 0.0226 ns | 0.0211 ns | 16.41 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 15.57 ns | 0.0193 ns | 0.0180 ns | 15.56 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 21.58 ns | 0.1161 ns | 0.1086 ns | 21.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 | 19.92 ns | 0.0167 ns | 0.0156 ns | 19.92 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 | 19.17 ns | 0.4081 ns | 0.4700 ns | 19.22 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 | 27.60 ns | 0.0213 ns | 0.0189 ns | 27.60 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 | 23.46 ns | 0.0388 ns | 0.0363 ns | 23.47 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 14.36 ns | 0.0119 ns | 0.0111 ns | 14.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 14.62 ns | 0.0123 ns | 0.0109 ns | 14.62 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 13.11 ns | 0.0220 ns | 0.0206 ns | 13.11 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 16.33 ns | 0.0177 ns | 0.0165 ns | 16.34 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 16.04 ns | 0.0238 ns | 0.0223 ns | 16.04 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.41 ns | 0.0230 ns | 0.0215 ns | 21.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.05 ns | 0.0282 ns | 0.0264 ns | 21.05 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.09 ns | 0.4033 ns | 0.5244 ns | 18.71 ns |  0.90 |    0.03 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 23.48 ns | 0.0234 ns | 0.0207 ns | 23.48 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 23.25 ns | 0.0181 ns | 0.0170 ns | 23.25 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 14.32 ns | 0.0136 ns | 0.0120 ns | 14.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 13.82 ns | 0.0140 ns | 0.0117 ns | 13.82 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 13.59 ns | 0.2966 ns | 0.3297 ns | 13.79 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 16.11 ns | 0.0506 ns | 0.0473 ns | 16.13 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 16.40 ns | 0.0680 ns | 0.0568 ns | 16.40 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.11 ns | 0.0212 ns | 0.0198 ns | 15.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.98 ns | 0.0238 ns | 0.0222 ns | 14.97 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.34 ns | 0.0332 ns | 0.0277 ns | 15.33 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 16.63 ns | 0.0238 ns | 0.0222 ns | 16.63 ns |  1.10 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 17.55 ns | 0.0337 ns | 0.0315 ns | 17.55 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 14.16 ns | 0.0140 ns | 0.0124 ns | 14.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 13.04 ns | 0.0071 ns | 0.0063 ns | 13.04 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.21 ns | 0.1366 ns | 0.1278 ns | 13.22 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 15.96 ns | 0.0188 ns | 0.0167 ns | 15.96 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 16.07 ns | 0.0176 ns | 0.0165 ns | 16.07 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 21.43 ns | 0.0272 ns | 0.0255 ns | 21.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 21.01 ns | 0.0316 ns | 0.0280 ns | 21.01 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 18.02 ns | 0.0432 ns | 0.0383 ns | 18.01 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 23.90 ns | 0.0239 ns | 0.0212 ns | 23.90 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 23.22 ns | 0.0702 ns | 0.0657 ns | 23.22 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 14.21 ns | 0.0190 ns | 0.0177 ns | 14.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 13.94 ns | 0.0180 ns | 0.0168 ns | 13.94 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 13.83 ns | 0.0661 ns | 0.0618 ns | 13.80 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 16.14 ns | 0.0208 ns | 0.0195 ns | 16.15 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 16.17 ns | 0.0424 ns | 0.0396 ns | 16.18 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.55 ns | 0.1222 ns | 0.1143 ns | 21.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.01 ns | 0.0308 ns | 0.0273 ns | 20.00 ns |  0.93 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.98 ns | 0.0320 ns | 0.0300 ns | 17.97 ns |  0.83 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.85 ns | 0.1365 ns | 0.1277 ns | 26.78 ns |  1.25 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 24.02 ns | 0.0206 ns | 0.0192 ns | 24.02 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.19 ns | 0.0157 ns | 0.0139 ns | 14.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 13.93 ns | 0.0198 ns | 0.0185 ns | 13.93 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 13.37 ns | 0.0893 ns | 0.0836 ns | 13.39 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 16.01 ns | 0.0278 ns | 0.0260 ns | 16.00 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 16.17 ns | 0.0692 ns | 0.0647 ns | 16.14 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.96 ns | 0.0125 ns | 0.0104 ns | 15.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.07 ns | 0.0219 ns | 0.0205 ns | 15.07 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.18 ns | 0.1316 ns | 0.1231 ns | 13.27 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 16.58 ns | 0.0136 ns | 0.0120 ns | 16.58 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 18.12 ns | 0.0176 ns | 0.0165 ns | 18.12 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.82 ns | 0.0154 ns | 0.0144 ns | 13.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.53 ns | 0.0138 ns | 0.0129 ns | 12.53 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 13.11 ns | 0.2438 ns | 0.2036 ns | 13.18 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.33 ns | 0.0188 ns | 0.0176 ns | 15.33 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.12 ns | 0.0241 ns | 0.0188 ns | 15.12 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.88 ns | 0.0244 ns | 0.0229 ns | 21.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.28 ns | 0.0160 ns | 0.0150 ns | 19.28 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.00 ns | 0.0729 ns | 0.0682 ns | 18.04 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 22.22 ns | 0.0176 ns | 0.0165 ns | 22.21 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 22.43 ns | 0.0607 ns | 0.0538 ns | 22.44 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.50 ns | 0.0789 ns | 0.0738 ns | 14.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 13.77 ns | 0.0255 ns | 0.0226 ns | 13.77 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 14.05 ns | 0.1884 ns | 0.1763 ns | 14.00 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.04 ns | 0.0173 ns | 0.0153 ns | 16.04 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.06 ns | 0.0286 ns | 0.0268 ns | 17.05 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.34 ns | 0.0359 ns | 0.0318 ns | 23.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.22 ns | 0.0312 ns | 0.0292 ns | 20.22 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.77 ns | 0.0362 ns | 0.0302 ns | 18.76 ns |  0.80 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 22.44 ns | 0.0244 ns | 0.0228 ns | 22.44 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.33 ns | 0.1023 ns | 0.0957 ns | 22.27 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.31 ns | 0.0418 ns | 0.0371 ns | 14.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 13.92 ns | 0.0305 ns | 0.0285 ns | 13.93 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 13.68 ns | 0.0182 ns | 0.0161 ns | 13.68 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 15.99 ns | 0.0173 ns | 0.0144 ns | 15.98 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 16.37 ns | 0.0665 ns | 0.0589 ns | 16.38 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.93 ns | 0.0148 ns | 0.0139 ns | 15.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.88 ns | 0.0368 ns | 0.0344 ns | 15.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.01 ns | 0.1301 ns | 0.1217 ns | 14.09 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 16.38 ns | 0.0217 ns | 0.0192 ns | 16.38 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.26 ns | 0.0411 ns | 0.0365 ns | 16.26 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.57 ns | 0.0064 ns | 0.0056 ns | 13.57 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 12.77 ns | 0.0186 ns | 0.0174 ns | 12.77 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 11.92 ns | 0.0135 ns | 0.0113 ns | 11.92 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 14.74 ns | 0.0825 ns | 0.0771 ns | 14.71 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 14.90 ns | 0.0399 ns | 0.0354 ns | 14.91 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 22.78 ns | 0.1028 ns | 0.0962 ns | 22.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 19.46 ns | 0.0361 ns | 0.0337 ns | 19.46 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 19.35 ns | 0.4080 ns | 0.8241 ns | 19.77 ns |  0.80 |    0.04 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 22.48 ns | 0.0306 ns | 0.0286 ns | 22.47 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 22.32 ns | 0.0814 ns | 0.0680 ns | 22.30 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 14.15 ns | 0.0156 ns | 0.0146 ns | 14.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 13.27 ns | 0.0150 ns | 0.0141 ns | 13.27 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 14.93 ns | 0.3024 ns | 0.2970 ns | 15.01 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.64 ns | 0.1001 ns | 0.0887 ns | 14.60 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 14.68 ns | 0.0172 ns | 0.0152 ns | 14.68 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.93 ns | 0.0321 ns | 0.0300 ns | 20.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.55 ns | 0.0243 ns | 0.0227 ns | 19.55 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.94 ns | 0.1972 ns | 0.1845 ns | 18.99 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 23.15 ns | 0.1204 ns | 0.1126 ns | 23.10 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 24.39 ns | 0.0347 ns | 0.0325 ns | 24.38 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 13.66 ns | 0.0080 ns | 0.0075 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 13.17 ns | 0.0128 ns | 0.0120 ns | 13.17 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 13.19 ns | 0.0528 ns | 0.0468 ns | 13.17 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 15.59 ns | 0.0207 ns | 0.0194 ns | 15.58 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 14.69 ns | 0.0635 ns | 0.0594 ns | 14.66 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.54 ns | 0.0130 ns | 0.0109 ns | 15.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.98 ns | 0.0107 ns | 0.0100 ns | 13.97 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.21 ns | 0.3468 ns | 0.3561 ns | 13.02 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 16.40 ns | 0.0400 ns | 0.0354 ns | 16.39 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 18.33 ns | 0.0136 ns | 0.0121 ns | 18.34 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 16.08 ns | 0.0128 ns | 0.0107 ns | 16.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.76 ns | 0.0071 ns | 0.0059 ns | 12.76 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 11.96 ns | 0.0776 ns | 0.0726 ns | 11.99 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 15.00 ns | 0.0189 ns | 0.0176 ns | 15.00 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 15.66 ns | 0.0201 ns | 0.0178 ns | 15.66 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.20 ns | 0.0132 ns | 0.0123 ns | 21.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 19.33 ns | 0.0387 ns | 0.0362 ns | 19.32 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.92 ns | 0.0183 ns | 0.0163 ns | 17.92 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 22.85 ns | 0.0232 ns | 0.0206 ns | 22.85 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 23.63 ns | 0.0839 ns | 0.0785 ns | 23.59 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.78 ns | 0.0569 ns | 0.0532 ns | 13.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 13.26 ns | 0.0332 ns | 0.0311 ns | 13.26 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 11.97 ns | 0.0705 ns | 0.0659 ns | 12.01 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.70 ns | 0.0988 ns | 0.0925 ns | 14.66 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 15.55 ns | 0.0241 ns | 0.0214 ns | 15.54 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.94 ns | 0.0125 ns | 0.0110 ns | 20.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.36 ns | 0.0223 ns | 0.0209 ns | 19.37 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.07 ns | 0.0730 ns | 0.0647 ns | 19.05 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 23.76 ns | 0.0272 ns | 0.0254 ns | 23.76 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 23.09 ns | 0.0202 ns | 0.0169 ns | 23.09 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.69 ns | 0.0201 ns | 0.0188 ns | 13.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 13.13 ns | 0.0142 ns | 0.0126 ns | 13.13 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 14.08 ns | 0.0231 ns | 0.0193 ns | 14.08 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 15.60 ns | 0.0144 ns | 0.0135 ns | 15.61 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 14.68 ns | 0.0095 ns | 0.0084 ns | 14.68 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.11 ns | 0.0310 ns | 0.0290 ns | 15.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.95 ns | 0.0134 ns | 0.0119 ns | 14.95 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.94 ns | 0.0756 ns | 0.0707 ns | 13.96 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 17.61 ns | 0.0198 ns | 0.0185 ns | 17.61 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 16.64 ns | 0.0218 ns | 0.0193 ns | 16.64 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.64 ns | 0.0256 ns | 0.0240 ns | 13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 14.45 ns | 0.0176 ns | 0.0156 ns | 14.44 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 12.06 ns | 0.2744 ns | 0.3266 ns | 11.88 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                                             From_Long |        net461 | 16.11 ns | 0.0290 ns | 0.0257 ns | 16.10 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 14.88 ns | 0.0648 ns | 0.0606 ns | 14.84 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 21.07 ns | 0.0269 ns | 0.0210 ns | 21.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 19.46 ns | 0.0446 ns | 0.0395 ns | 19.46 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.61 ns | 0.2853 ns | 0.2669 ns | 18.44 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 24.19 ns | 0.1365 ns | 0.1277 ns | 24.13 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 23.29 ns | 0.0439 ns | 0.0389 ns | 23.30 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.32 ns | 0.0112 ns | 0.0105 ns | 14.32 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.77 ns | 0.0243 ns | 0.0215 ns | 13.77 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 13.16 ns | 0.0442 ns | 0.0414 ns | 13.14 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 16.02 ns | 0.0107 ns | 0.0100 ns | 16.02 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 17.03 ns | 0.0301 ns | 0.0235 ns | 17.03 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.10 ns | 0.0147 ns | 0.0130 ns | 22.10 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.56 ns | 0.0245 ns | 0.0229 ns | 19.56 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.04 ns | 0.1013 ns | 0.0947 ns | 19.00 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 22.13 ns | 0.0265 ns | 0.0235 ns | 22.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 24.27 ns | 0.0239 ns | 0.0223 ns | 24.27 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.19 ns | 0.0146 ns | 0.0130 ns | 14.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 13.79 ns | 0.0157 ns | 0.0147 ns | 13.79 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 13.81 ns | 0.0745 ns | 0.0696 ns | 13.79 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 17.09 ns | 0.0176 ns | 0.0165 ns | 17.09 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 16.96 ns | 0.0195 ns | 0.0173 ns | 16.96 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.01 ns | 0.0219 ns | 0.0205 ns | 16.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.10 ns | 0.0260 ns | 0.0230 ns | 15.10 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.25 ns | 0.1177 ns | 0.1101 ns | 14.18 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 16.25 ns | 0.0155 ns | 0.0145 ns | 16.25 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 16.43 ns | 0.0444 ns | 0.0415 ns | 16.42 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 13.92 ns | 0.0172 ns | 0.0144 ns | 13.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 13.57 ns | 0.0069 ns | 0.0062 ns | 13.57 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 12.96 ns | 0.2825 ns | 0.2775 ns | 12.96 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.82 ns | 0.0185 ns | 0.0154 ns | 14.82 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 17.12 ns | 0.0236 ns | 0.0220 ns | 17.12 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.93 ns | 0.0235 ns | 0.0220 ns | 20.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 20.33 ns | 0.0389 ns | 0.0344 ns | 20.34 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.77 ns | 0.0275 ns | 0.0258 ns | 18.77 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 22.22 ns | 0.0303 ns | 0.0284 ns | 22.23 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 23.95 ns | 0.0320 ns | 0.0284 ns | 23.94 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.68 ns | 0.0160 ns | 0.0142 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 13.23 ns | 0.0113 ns | 0.0100 ns | 13.23 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 12.51 ns | 0.0113 ns | 0.0106 ns | 12.51 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.61 ns | 0.0107 ns | 0.0095 ns | 14.61 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.69 ns | 0.0189 ns | 0.0168 ns | 14.69 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.90 ns | 0.0208 ns | 0.0194 ns | 21.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.65 ns | 0.0305 ns | 0.0285 ns | 21.65 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.71 ns | 0.3985 ns | 0.6548 ns | 18.65 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 22.23 ns | 0.0393 ns | 0.0307 ns | 22.23 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 23.14 ns | 0.0264 ns | 0.0234 ns | 23.13 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.14 ns | 0.0130 ns | 0.0101 ns | 14.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 13.14 ns | 0.0159 ns | 0.0149 ns | 13.14 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 14.68 ns | 0.1587 ns | 0.1407 ns | 14.70 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.69 ns | 0.0162 ns | 0.0152 ns | 14.69 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 14.83 ns | 0.0462 ns | 0.0433 ns | 14.80 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.39 ns | 0.0177 ns | 0.0138 ns | 15.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.99 ns | 0.0125 ns | 0.0111 ns | 13.99 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.88 ns | 0.0118 ns | 0.0105 ns | 13.88 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 16.27 ns | 0.0230 ns | 0.0215 ns | 16.26 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 18.62 ns | 0.0227 ns | 0.0202 ns | 18.62 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.08 ns | 0.0356 ns | 0.0333 ns | 14.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.56 ns | 0.0169 ns | 0.0158 ns | 12.56 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.28 ns | 0.2711 ns | 0.3013 ns | 12.09 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.21 ns | 0.0252 ns | 0.0210 ns | 15.20 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.54 ns | 0.0139 ns | 0.0123 ns | 15.53 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.96 ns | 0.0263 ns | 0.0233 ns | 20.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.41 ns | 0.0247 ns | 0.0231 ns | 19.42 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.07 ns | 0.1497 ns | 0.1400 ns | 18.99 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 22.23 ns | 0.0250 ns | 0.0233 ns | 22.23 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.30 ns | 0.1119 ns | 0.1047 ns | 23.34 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.69 ns | 0.0168 ns | 0.0141 ns | 13.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.15 ns | 0.0103 ns | 0.0091 ns | 13.15 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 13.51 ns | 0.0188 ns | 0.0166 ns | 13.51 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.61 ns | 0.0201 ns | 0.0178 ns | 15.61 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.63 ns | 0.0195 ns | 0.0183 ns | 14.63 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.92 ns | 0.0167 ns | 0.0148 ns | 20.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.40 ns | 0.0604 ns | 0.0535 ns | 20.41 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.85 ns | 0.0338 ns | 0.0316 ns | 17.84 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 23.78 ns | 0.1253 ns | 0.1172 ns | 23.84 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.25 ns | 0.0818 ns | 0.0765 ns | 23.28 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 13.66 ns | 0.0078 ns | 0.0073 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 13.15 ns | 0.0135 ns | 0.0120 ns | 13.15 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 11.86 ns | 0.0119 ns | 0.0093 ns | 11.86 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.61 ns | 0.0166 ns | 0.0155 ns | 14.61 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 14.64 ns | 0.0133 ns | 0.0125 ns | 14.64 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.52 ns | 0.0136 ns | 0.0121 ns | 16.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.00 ns | 0.0139 ns | 0.0130 ns | 14.00 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.20 ns | 0.2076 ns | 0.1942 ns | 14.09 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 17.48 ns | 0.0269 ns | 0.0210 ns | 17.49 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 16.28 ns | 0.0121 ns | 0.0107 ns | 16.28 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 13.61 ns | 0.0180 ns | 0.0159 ns | 13.61 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 13.41 ns | 0.0130 ns | 0.0122 ns | 13.40 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 12.59 ns | 0.0403 ns | 0.0377 ns | 12.59 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 14.72 ns | 0.0097 ns | 0.0081 ns | 14.72 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 17.25 ns | 0.0298 ns | 0.0278 ns | 17.25 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 21.78 ns | 0.0264 ns | 0.0234 ns | 21.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 21.07 ns | 0.0235 ns | 0.0220 ns | 21.07 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 18.13 ns | 0.1138 ns | 0.1065 ns | 18.16 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 24.15 ns | 0.0260 ns | 0.0243 ns | 24.15 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 24.25 ns | 0.0159 ns | 0.0148 ns | 24.25 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.93 ns | 0.0157 ns | 0.0147 ns | 14.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.41 ns | 0.0127 ns | 0.0112 ns | 13.41 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.58 ns | 0.0228 ns | 0.0190 ns | 12.57 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.73 ns | 0.0172 ns | 0.0161 ns | 14.73 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.17 ns | 0.0144 ns | 0.0135 ns | 16.17 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.13 ns | 0.0194 ns | 0.0181 ns | 15.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.16 ns | 0.0436 ns | 0.0408 ns | 14.16 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.11 ns | 0.0155 ns | 0.0137 ns | 13.11 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 16.26 ns | 0.0195 ns | 0.0182 ns | 16.26 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.67 ns | 0.0114 ns | 0.0101 ns | 16.68 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.74 ns | 0.0421 ns | 0.0373 ns | 13.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.40 ns | 0.0152 ns | 0.0135 ns | 13.40 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.88 ns | 0.0199 ns | 0.0186 ns | 11.87 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 15.82 ns | 0.0210 ns | 0.0186 ns | 15.82 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.69 ns | 0.0112 ns | 0.0099 ns | 14.69 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 | 21.78 ns | 0.0291 ns | 0.0272 ns | 21.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 | 21.10 ns | 0.0180 ns | 0.0168 ns | 21.10 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 | 19.19 ns | 0.4022 ns | 0.5230 ns | 18.78 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 | 23.56 ns | 0.0193 ns | 0.0180 ns | 23.56 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 | 25.52 ns | 0.1250 ns | 0.1169 ns | 25.58 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.64 ns | 0.0235 ns | 0.0208 ns | 13.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 12.70 ns | 0.0230 ns | 0.0204 ns | 12.71 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 12.57 ns | 0.0165 ns | 0.0154 ns | 12.57 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.69 ns | 0.0234 ns | 0.0219 ns | 14.68 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 15.67 ns | 0.0249 ns | 0.0233 ns | 15.67 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.94 ns | 0.0147 ns | 0.0131 ns | 20.94 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 20.26 ns | 0.0240 ns | 0.0213 ns | 20.26 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.93 ns | 0.1331 ns | 0.1245 ns | 17.83 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 23.10 ns | 0.0299 ns | 0.0265 ns | 23.10 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 22.21 ns | 0.0301 ns | 0.0252 ns | 22.22 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 13.66 ns | 0.0122 ns | 0.0108 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 13.13 ns | 0.0105 ns | 0.0098 ns | 13.13 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 12.39 ns | 0.0526 ns | 0.0492 ns | 12.38 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 14.68 ns | 0.0129 ns | 0.0121 ns | 14.68 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 14.70 ns | 0.0214 ns | 0.0200 ns | 14.71 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.20 ns | 0.0214 ns | 0.0179 ns | 21.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.70 ns | 0.0366 ns | 0.0342 ns | 21.70 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.87 ns | 0.0331 ns | 0.0294 ns | 17.87 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 22.21 ns | 0.0342 ns | 0.0286 ns | 22.21 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.29 ns | 0.0172 ns | 0.0143 ns | 22.28 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.69 ns | 0.0122 ns | 0.0108 ns | 13.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 13.15 ns | 0.0119 ns | 0.0105 ns | 13.15 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 13.73 ns | 0.0409 ns | 0.0362 ns | 13.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 14.81 ns | 0.0127 ns | 0.0119 ns | 14.82 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 14.72 ns | 0.0269 ns | 0.0252 ns | 14.72 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.03 ns | 0.0163 ns | 0.0144 ns | 16.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.08 ns | 0.0536 ns | 0.0475 ns | 14.09 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.15 ns | 0.1274 ns | 0.1192 ns | 13.07 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 17.49 ns | 0.0143 ns | 0.0127 ns | 17.50 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 16.45 ns | 0.0514 ns | 0.0481 ns | 16.47 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 13.62 ns | 0.0159 ns | 0.0149 ns | 13.62 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 13.53 ns | 0.0149 ns | 0.0124 ns | 13.54 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 12.90 ns | 0.1277 ns | 0.1132 ns | 12.88 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.78 ns | 0.0741 ns | 0.0693 ns | 14.78 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 14.70 ns | 0.0113 ns | 0.0105 ns | 14.70 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 20.81 ns | 0.0247 ns | 0.0231 ns | 20.81 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 19.42 ns | 0.0326 ns | 0.0305 ns | 19.42 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 18.95 ns | 0.2512 ns | 0.2349 ns | 18.77 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 22.26 ns | 0.0278 ns | 0.0260 ns | 22.26 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 22.50 ns | 0.0808 ns | 0.0756 ns | 22.55 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.67 ns | 0.0169 ns | 0.0132 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 13.30 ns | 0.0183 ns | 0.0162 ns | 13.30 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 11.88 ns | 0.0179 ns | 0.0168 ns | 11.88 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.62 ns | 0.0114 ns | 0.0095 ns | 14.62 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 15.91 ns | 0.0172 ns | 0.0161 ns | 15.91 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.94 ns | 0.0118 ns | 0.0105 ns | 20.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.62 ns | 0.0197 ns | 0.0184 ns | 19.62 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.80 ns | 0.0355 ns | 0.0332 ns | 18.81 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 22.58 ns | 0.2302 ns | 0.1922 ns | 22.57 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 24.53 ns | 0.0249 ns | 0.0221 ns | 24.53 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.67 ns | 0.0099 ns | 0.0088 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 13.24 ns | 0.0186 ns | 0.0174 ns | 13.23 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 12.13 ns | 0.1708 ns | 0.1598 ns | 12.05 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 16.01 ns | 0.1682 ns | 0.1573 ns | 15.97 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 14.69 ns | 0.0173 ns | 0.0162 ns | 14.69 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.14 ns | 0.0186 ns | 0.0145 ns | 15.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.95 ns | 0.0151 ns | 0.0126 ns | 14.95 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.34 ns | 0.3093 ns | 0.4234 ns | 14.68 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 17.51 ns | 0.0425 ns | 0.0377 ns | 17.49 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 18.58 ns | 0.0719 ns | 0.0672 ns | 18.60 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.64 ns | 0.0144 ns | 0.0127 ns | 13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.78 ns | 0.0084 ns | 0.0074 ns | 12.78 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 11.99 ns | 0.0985 ns | 0.0922 ns | 12.02 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 15.46 ns | 0.0714 ns | 0.0633 ns | 15.44 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 14.84 ns | 0.0818 ns | 0.0765 ns | 14.88 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.89 ns | 0.0182 ns | 0.0170 ns | 20.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 19.43 ns | 0.0282 ns | 0.0236 ns | 19.43 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.74 ns | 0.0176 ns | 0.0156 ns | 18.74 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 23.14 ns | 0.0613 ns | 0.0543 ns | 23.13 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 23.31 ns | 0.0239 ns | 0.0224 ns | 23.31 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.33 ns | 0.0177 ns | 0.0165 ns | 14.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.74 ns | 0.0166 ns | 0.0155 ns | 13.74 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 13.62 ns | 0.0306 ns | 0.0271 ns | 13.62 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.09 ns | 0.1317 ns | 0.1232 ns | 16.01 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 16.11 ns | 0.0157 ns | 0.0139 ns | 16.11 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.26 ns | 0.0152 ns | 0.0143 ns | 22.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.41 ns | 0.0172 ns | 0.0152 ns | 19.41 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.01 ns | 0.0676 ns | 0.0528 ns | 18.00 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 22.19 ns | 0.0188 ns | 0.0176 ns | 22.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 24.56 ns | 0.0215 ns | 0.0201 ns | 24.56 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.28 ns | 0.0227 ns | 0.0201 ns | 14.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 13.75 ns | 0.0265 ns | 0.0248 ns | 13.75 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 14.37 ns | 0.0601 ns | 0.0562 ns | 14.34 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 15.97 ns | 0.0308 ns | 0.0257 ns | 15.98 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 15.97 ns | 0.0138 ns | 0.0123 ns | 15.97 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.48 ns | 0.0218 ns | 0.0193 ns | 16.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.98 ns | 0.0231 ns | 0.0216 ns | 13.98 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.24 ns | 0.0143 ns | 0.0127 ns | 13.23 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 18.16 ns | 0.0695 ns | 0.0580 ns | 18.17 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.34 ns | 0.0452 ns | 0.0401 ns | 16.33 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.82 ns | 0.0207 ns | 0.0173 ns | 15.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 17.45 ns | 0.0116 ns | 0.0103 ns | 17.45 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.93 ns | 0.0421 ns | 0.0394 ns | 13.94 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 17.44 ns | 0.0289 ns | 0.0257 ns | 17.43 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 16.32 ns | 0.0376 ns | 0.0352 ns | 16.31 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.26 ns | 0.0171 ns | 0.0160 ns | 13.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.18 ns | 0.0114 ns | 0.0101 ns | 11.18 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.38 ns | 0.2094 ns | 0.1959 ns | 12.50 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.08 ns | 0.0397 ns | 0.0372 ns | 12.09 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.21 ns | 0.0103 ns | 0.0096 ns | 13.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.69 ns | 0.0186 ns | 0.0155 ns | 16.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.95 ns | 0.0128 ns | 0.0113 ns | 13.95 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.80 ns | 0.0227 ns | 0.0213 ns | 13.79 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.29 ns | 0.0204 ns | 0.0191 ns | 16.29 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.59 ns | 0.0319 ns | 0.0298 ns | 16.58 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 13.67 ns | 0.0178 ns | 0.0166 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.71 ns | 0.0171 ns | 0.0151 ns | 12.71 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 11.84 ns | 0.0102 ns | 0.0096 ns | 11.83 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 15.95 ns | 0.0433 ns | 0.0384 ns | 15.96 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 15.69 ns | 0.0297 ns | 0.0248 ns | 15.68 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.53 ns | 0.0461 ns | 0.0409 ns | 19.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.63 ns | 0.0231 ns | 0.0204 ns | 17.63 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.57 ns | 0.0271 ns | 0.0240 ns | 17.57 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 20.43 ns | 0.0798 ns | 0.0746 ns | 20.38 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 21.37 ns | 0.0503 ns | 0.0446 ns | 21.38 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.60 ns | 0.0205 ns | 0.0182 ns | 13.60 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.44 ns | 0.0147 ns | 0.0137 ns | 13.44 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.97 ns | 0.0472 ns | 0.0442 ns | 11.94 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 15.10 ns | 0.0290 ns | 0.0257 ns | 15.10 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 18.89 ns | 0.0234 ns | 0.0208 ns | 18.88 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.83 ns | 0.0191 ns | 0.0149 ns | 15.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.93 ns | 0.0172 ns | 0.0143 ns | 14.93 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.83 ns | 0.0141 ns | 0.0125 ns | 13.83 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 17.49 ns | 0.0179 ns | 0.0159 ns | 17.49 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 16.69 ns | 0.0540 ns | 0.0506 ns | 16.70 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.59 ns | 0.0134 ns | 0.0125 ns | 13.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.64 ns | 0.0106 ns | 0.0094 ns | 12.64 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.17 ns | 0.2302 ns | 0.2154 ns | 12.29 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 16.06 ns | 0.0394 ns | 0.0369 ns | 16.07 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.75 ns | 0.0245 ns | 0.0229 ns | 14.74 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 19.83 ns | 0.0189 ns | 0.0167 ns | 19.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 18.20 ns | 0.0212 ns | 0.0198 ns | 18.20 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 17.43 ns | 0.0232 ns | 0.0217 ns | 17.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 20.83 ns | 0.0439 ns | 0.0411 ns | 20.82 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 22.00 ns | 0.0231 ns | 0.0180 ns | 22.00 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.60 ns | 0.0150 ns | 0.0140 ns | 13.60 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.85 ns | 0.0161 ns | 0.0151 ns | 12.84 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.18 ns | 0.1677 ns | 0.1569 ns | 12.16 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.75 ns | 0.0345 ns | 0.0306 ns | 14.75 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.67 ns | 0.0149 ns | 0.0139 ns | 15.67 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.18 ns | 0.0121 ns | 0.0107 ns | 15.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 15.98 ns | 0.0376 ns | 0.0352 ns | 15.97 ns |  1.05 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.95 ns | 0.2166 ns | 0.2026 ns | 13.83 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 16.26 ns | 0.0239 ns | 0.0223 ns | 16.26 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 16.34 ns | 0.0277 ns | 0.0231 ns | 16.33 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 13.72 ns | 0.0129 ns | 0.0120 ns | 13.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct | .NET Core 2.2 | 13.12 ns | 0.0179 ns | 0.0158 ns | 13.13 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.52 ns | 0.0420 ns | 0.0392 ns | 12.51 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct |        net461 | 16.01 ns | 0.0510 ns | 0.0453 ns | 16.02 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct |        net472 | 15.75 ns | 0.0365 ns | 0.0341 ns | 15.75 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.41 ns | 0.0188 ns | 0.0157 ns | 19.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 18.64 ns | 0.0649 ns | 0.0607 ns | 18.66 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.01 ns | 0.0266 ns | 0.0235 ns | 17.01 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 21.87 ns | 0.0870 ns | 0.0814 ns | 21.83 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 21.36 ns | 0.0427 ns | 0.0399 ns | 21.37 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 15.31 ns | 0.0669 ns | 0.0626 ns | 15.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 13.77 ns | 0.0087 ns | 0.0072 ns | 13.78 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.23 ns | 0.0262 ns | 0.0233 ns | 14.22 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 14.89 ns | 0.0229 ns | 0.0203 ns | 14.89 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 14.72 ns | 0.0174 ns | 0.0163 ns | 14.72 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.48 ns | 0.0182 ns | 0.0152 ns | 19.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.12 ns | 0.0301 ns | 0.0281 ns | 19.12 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.82 ns | 0.0906 ns | 0.0707 ns | 17.80 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.49 ns | 0.0267 ns | 0.0236 ns | 20.48 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.45 ns | 0.0174 ns | 0.0154 ns | 20.45 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.71 ns | 0.0163 ns | 0.0152 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.13 ns | 0.0178 ns | 0.0157 ns | 13.13 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 13.75 ns | 0.0914 ns | 0.0855 ns | 13.71 ns |  1.00 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 15.84 ns | 0.0406 ns | 0.0379 ns | 15.84 ns |  1.16 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 16.47 ns | 0.0231 ns | 0.0205 ns | 16.48 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.13 ns | 0.0177 ns | 0.0166 ns | 15.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.93 ns | 0.0296 ns | 0.0277 ns | 14.93 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.41 ns | 0.0235 ns | 0.0208 ns | 14.40 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.40 ns | 0.0364 ns | 0.0340 ns | 16.39 ns |  1.08 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.82 ns | 0.0176 ns | 0.0164 ns | 17.81 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.85 ns | 0.0427 ns | 0.0399 ns | 13.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 13.26 ns | 0.0088 ns | 0.0082 ns | 13.26 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 | 12.65 ns | 0.2788 ns | 0.3211 ns | 12.47 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.84 ns | 0.0258 ns | 0.0242 ns | 14.85 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 15.58 ns | 0.0171 ns | 0.0152 ns | 15.57 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 18.44 ns | 0.0239 ns | 0.0223 ns | 18.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 17.15 ns | 0.0137 ns | 0.0122 ns | 17.16 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.92 ns | 0.1201 ns | 0.1124 ns | 16.97 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 20.11 ns | 0.0196 ns | 0.0174 ns | 20.11 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 22.27 ns | 0.0539 ns | 0.0478 ns | 22.28 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.14 ns | 0.0097 ns | 0.0086 ns | 14.15 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 13.53 ns | 0.0143 ns | 0.0127 ns | 13.53 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 11.83 ns | 0.0222 ns | 0.0208 ns | 11.82 ns |  0.84 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.55 ns | 0.0138 ns | 0.0129 ns | 14.55 ns |  1.03 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 14.65 ns | 0.0092 ns | 0.0082 ns | 14.66 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.26 ns | 0.0702 ns | 0.0657 ns | 20.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.08 ns | 0.0156 ns | 0.0138 ns | 18.08 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.22 ns | 0.7846 ns | 1.2444 ns | 17.54 ns |  0.94 |    0.07 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 21.01 ns | 0.0187 ns | 0.0175 ns | 21.01 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 21.10 ns | 0.0286 ns | 0.0268 ns | 21.11 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.67 ns | 0.0098 ns | 0.0092 ns | 13.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.14 ns | 0.0145 ns | 0.0136 ns | 13.14 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 14.24 ns | 0.3054 ns | 0.4282 ns | 14.03 ns |  1.07 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 14.61 ns | 0.0663 ns | 0.0554 ns | 14.59 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 14.66 ns | 0.0121 ns | 0.0113 ns | 14.66 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.09 ns | 0.0124 ns | 0.0116 ns | 15.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.95 ns | 0.0115 ns | 0.0096 ns | 13.95 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.08 ns | 0.0187 ns | 0.0166 ns | 14.08 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 17.22 ns | 0.0359 ns | 0.0318 ns | 17.22 ns |  1.14 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 17.81 ns | 0.0186 ns | 0.0165 ns | 17.82 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.43 ns | 0.0124 ns | 0.0116 ns | 14.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 13.38 ns | 0.0163 ns | 0.0152 ns | 13.38 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 | 12.05 ns | 0.2679 ns | 0.3189 ns | 11.88 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 15.52 ns | 0.0114 ns | 0.0095 ns | 15.52 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.79 ns | 0.0678 ns | 0.0634 ns | 14.76 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 21.23 ns | 0.0191 ns | 0.0178 ns | 21.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 | 40.74 ns | 1.5672 ns | 4.6209 ns | 42.30 ns |  1.84 |    0.25 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 | 18.39 ns | 0.3267 ns | 0.3056 ns | 18.21 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 22.56 ns | 0.0396 ns | 0.0370 ns | 22.55 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 | 24.26 ns | 0.0250 ns | 0.0222 ns | 24.26 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.71 ns | 0.0170 ns | 0.0151 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.11 ns | 0.0150 ns | 0.0133 ns | 13.11 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 12.15 ns | 0.2416 ns | 0.2260 ns | 12.34 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 15.76 ns | 0.0157 ns | 0.0139 ns | 15.76 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.78 ns | 0.0129 ns | 0.0107 ns | 14.78 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.40 ns | 0.0476 ns | 0.0445 ns | 20.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.93 ns | 0.0240 ns | 0.0212 ns | 19.93 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.50 ns | 0.3932 ns | 0.4829 ns | 18.85 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 26.32 ns | 0.0503 ns | 0.0471 ns | 26.32 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 23.05 ns | 0.0755 ns | 0.0706 ns | 23.07 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.74 ns | 0.0464 ns | 0.0411 ns | 13.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.21 ns | 0.0469 ns | 0.0415 ns | 13.23 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 12.31 ns | 0.2721 ns | 0.2912 ns | 12.47 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 15.59 ns | 0.0231 ns | 0.0193 ns | 15.59 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 14.60 ns | 0.0136 ns | 0.0113 ns | 14.60 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.97 ns | 0.0517 ns | 0.0458 ns | 15.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.98 ns | 0.0272 ns | 0.0254 ns | 15.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.08 ns | 0.0783 ns | 0.0732 ns | 14.12 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 16.74 ns | 0.0361 ns | 0.0337 ns | 16.73 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 17.58 ns | 0.0200 ns | 0.0177 ns | 17.58 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.45 ns | 0.0236 ns | 0.0221 ns | 13.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.41 ns | 0.0112 ns | 0.0100 ns | 11.41 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.09 ns | 0.2674 ns | 0.2627 ns | 11.95 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.51 ns | 0.0430 ns | 0.0402 ns | 14.52 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.00 ns | 0.0207 ns | 0.0183 ns | 12.99 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 19.88 ns | 0.0231 ns | 0.0205 ns | 19.88 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 18.08 ns | 0.0208 ns | 0.0185 ns | 18.09 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 17.43 ns | 0.0226 ns | 0.0212 ns | 17.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 20.24 ns | 0.0201 ns | 0.0179 ns | 20.24 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 20.42 ns | 0.0379 ns | 0.0354 ns | 20.41 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.72 ns | 0.0146 ns | 0.0136 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.42 ns | 0.0151 ns | 0.0126 ns | 11.42 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.24 ns | 0.2221 ns | 0.2078 ns | 12.34 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.76 ns | 0.0130 ns | 0.0116 ns | 12.75 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.70 ns | 0.0362 ns | 0.0339 ns | 12.71 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.95 ns | 0.0215 ns | 0.0201 ns | 15.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 15.05 ns | 0.0187 ns | 0.0175 ns | 15.05 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.36 ns | 0.2823 ns | 0.2641 ns | 13.58 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 17.44 ns | 0.0272 ns | 0.0254 ns | 17.44 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.31 ns | 0.0206 ns | 0.0182 ns | 16.30 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 82.21 ns | 0.1464 ns | 0.1369 ns | 82.20 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 | 80.87 ns | 0.2552 ns | 0.2387 ns | 80.92 ns |  0.98 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 | 87.44 ns | 0.8091 ns | 0.7569 ns | 87.30 ns |  1.06 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 | 84.03 ns | 0.2081 ns | 0.1947 ns | 84.11 ns |  1.02 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 82.92 ns | 0.1492 ns | 0.1396 ns | 82.91 ns |  1.01 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 19.46 ns | 0.0342 ns | 0.0320 ns | 19.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 18.44 ns | 0.0232 ns | 0.0206 ns | 18.43 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 17.78 ns | 0.1273 ns | 0.1191 ns | 17.83 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 20.30 ns | 0.0776 ns | 0.0726 ns | 20.30 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 20.42 ns | 0.0296 ns | 0.0262 ns | 20.41 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 80.53 ns | 0.1880 ns | 0.1758 ns | 80.50 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 83.04 ns | 0.1753 ns | 0.1639 ns | 83.03 ns |  1.03 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 84.77 ns | 0.6924 ns | 0.6476 ns | 84.88 ns |  1.05 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 83.14 ns | 0.1633 ns | 0.1528 ns | 83.17 ns |  1.03 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 85.35 ns | 0.2617 ns | 0.2448 ns | 85.33 ns |  1.06 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.11 ns | 0.0294 ns | 0.0275 ns | 20.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.12 ns | 0.0229 ns | 0.0214 ns | 18.12 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.88 ns | 0.3658 ns | 0.3421 ns | 20.17 ns |  0.99 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 20.26 ns | 0.0175 ns | 0.0155 ns | 20.27 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 22.14 ns | 0.0564 ns | 0.0500 ns | 22.14 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.88 ns | 0.2547 ns | 0.2383 ns | 42.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 41.24 ns | 0.0814 ns | 0.0722 ns | 41.22 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 41.36 ns | 0.0558 ns | 0.0522 ns | 41.35 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.31 ns | 0.0892 ns | 0.0834 ns | 42.31 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 44.15 ns | 0.0657 ns | 0.0583 ns | 44.14 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.48 ns | 0.0295 ns | 0.0276 ns | 15.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.96 ns | 0.0093 ns | 0.0078 ns | 13.96 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.56 ns | 0.1214 ns | 0.1136 ns | 14.62 ns |  0.94 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 16.72 ns | 0.0429 ns | 0.0401 ns | 16.72 ns |  1.08 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 17.55 ns | 0.0169 ns | 0.0158 ns | 17.56 ns |  1.13 |    0.00 |      - |     - |     - |         - |
