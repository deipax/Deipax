
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FWPOAF : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-ZZPTUV : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOJUSV : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-KESODJ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PJAXXB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 | 13.66 ns | 0.0245 ns | 0.0229 ns | 13.66 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.92 ns | 0.0206 ns | 0.0182 ns | 12.92 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 12.17 ns | 0.1467 ns | 0.1373 ns | 12.10 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.51 ns | 0.0253 ns | 0.0237 ns | 13.51 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 15.62 ns | 0.0140 ns | 0.0131 ns | 15.62 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 21.53 ns | 0.0442 ns | 0.0345 ns | 21.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 19.66 ns | 0.0297 ns | 0.0278 ns | 19.66 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.32 ns | 0.0393 ns | 0.0348 ns | 18.33 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 21.04 ns | 0.0258 ns | 0.0242 ns | 21.04 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 23.00 ns | 0.0299 ns | 0.0265 ns | 23.00 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 14.02 ns | 0.0234 ns | 0.0219 ns | 14.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 13.35 ns | 0.0347 ns | 0.0290 ns | 13.35 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 12.20 ns | 0.1230 ns | 0.1150 ns | 12.26 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.19 ns | 0.0235 ns | 0.0220 ns | 13.20 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 14.88 ns | 0.0416 ns | 0.0369 ns | 14.88 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.99 ns | 0.1034 ns | 0.0916 ns | 22.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.65 ns | 0.0468 ns | 0.0438 ns | 20.65 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.37 ns | 0.0956 ns | 0.0848 ns | 18.34 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.38 ns | 0.1321 ns | 0.1235 ns | 21.42 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 22.34 ns | 0.1042 ns | 0.0924 ns | 22.36 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 14.01 ns | 0.0148 ns | 0.0124 ns | 14.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 14.72 ns | 0.0236 ns | 0.0209 ns | 14.72 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 12.03 ns | 0.0190 ns | 0.0168 ns | 12.03 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.61 ns | 0.0181 ns | 0.0170 ns | 14.61 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 15.63 ns | 0.0338 ns | 0.0300 ns | 15.63 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.91 ns | 0.0308 ns | 0.0288 ns | 15.91 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.99 ns | 0.0337 ns | 0.0315 ns | 15.00 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.25 ns | 0.3048 ns | 0.3262 ns | 14.01 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 15.40 ns | 0.0260 ns | 0.0230 ns | 15.40 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 19.29 ns | 0.1262 ns | 0.1119 ns | 19.32 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 13.65 ns | 0.0248 ns | 0.0207 ns | 13.65 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 12.75 ns | 0.0145 ns | 0.0121 ns | 12.75 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 12.81 ns | 0.0281 ns | 0.0249 ns | 12.81 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.66 ns | 0.1041 ns | 0.0923 ns | 13.71 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 15.96 ns | 0.0447 ns | 0.0418 ns | 15.97 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 24.06 ns | 0.1246 ns | 0.1105 ns | 24.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 19.34 ns | 0.0469 ns | 0.0392 ns | 19.33 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 19.17 ns | 0.2643 ns | 0.2472 ns | 19.25 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 21.55 ns | 0.1384 ns | 0.1295 ns | 21.50 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 23.35 ns | 0.0291 ns | 0.0258 ns | 23.36 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.75 ns | 0.0221 ns | 0.0196 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 13.51 ns | 0.0261 ns | 0.0244 ns | 13.50 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 12.05 ns | 0.0202 ns | 0.0179 ns | 12.05 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.70 ns | 0.0878 ns | 0.0821 ns | 14.67 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 15.48 ns | 0.0273 ns | 0.0242 ns | 15.48 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.06 ns | 0.0377 ns | 0.0353 ns | 24.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.46 ns | 0.1029 ns | 0.0963 ns | 19.43 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.24 ns | 0.1688 ns | 0.1579 ns | 18.34 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.53 ns | 0.0531 ns | 0.0471 ns | 21.53 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 25.08 ns | 0.0524 ns | 0.0465 ns | 25.08 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.01 ns | 0.0193 ns | 0.0171 ns | 14.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 13.20 ns | 0.0256 ns | 0.0200 ns | 13.20 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 | 12.74 ns | 0.0307 ns | 0.0257 ns | 12.74 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.62 ns | 0.0214 ns | 0.0200 ns | 14.62 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 14.86 ns | 0.0612 ns | 0.0572 ns | 14.85 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.41 ns | 0.0952 ns | 0.0843 ns | 16.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.04 ns | 0.0179 ns | 0.0159 ns | 14.04 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.74 ns | 0.0240 ns | 0.0213 ns | 14.74 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 15.24 ns | 0.0302 ns | 0.0282 ns | 15.23 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.59 ns | 0.0325 ns | 0.0304 ns | 16.58 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.64 ns | 0.0217 ns | 0.0192 ns | 13.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 12.75 ns | 0.0250 ns | 0.0208 ns | 12.75 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 | 12.98 ns | 0.2155 ns | 0.2016 ns | 13.12 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 14.49 ns | 0.1119 ns | 0.1047 ns | 14.44 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 15.03 ns | 0.1773 ns | 0.1658 ns | 15.08 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 21.67 ns | 0.0400 ns | 0.0374 ns | 21.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.71 ns | 0.1176 ns | 0.1100 ns | 18.65 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.32 ns | 0.0239 ns | 0.0199 ns | 18.32 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 21.15 ns | 0.0309 ns | 0.0241 ns | 21.15 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 23.40 ns | 0.0594 ns | 0.0496 ns | 23.38 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 14.98 ns | 0.0188 ns | 0.0176 ns | 14.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 13.20 ns | 0.0244 ns | 0.0217 ns | 13.20 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 12.70 ns | 0.2752 ns | 0.3380 ns | 12.85 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.16 ns | 0.0306 ns | 0.0287 ns | 13.16 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 14.78 ns | 0.0259 ns | 0.0242 ns | 14.79 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.96 ns | 0.0239 ns | 0.0212 ns | 22.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.66 ns | 0.0396 ns | 0.0331 ns | 19.66 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.16 ns | 0.4088 ns | 0.5863 ns | 19.49 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 21.19 ns | 0.0252 ns | 0.0211 ns | 21.19 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 23.18 ns | 0.1382 ns | 0.1293 ns | 23.21 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 13.95 ns | 0.0820 ns | 0.0767 ns | 13.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 13.23 ns | 0.0838 ns | 0.0743 ns | 13.20 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 | 12.06 ns | 0.0274 ns | 0.0243 ns | 12.06 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.17 ns | 0.0196 ns | 0.0174 ns | 13.17 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 14.78 ns | 0.0076 ns | 0.0063 ns | 14.78 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.84 ns | 0.0170 ns | 0.0133 ns | 16.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.13 ns | 0.0262 ns | 0.0245 ns | 14.13 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.41 ns | 0.1133 ns | 0.1060 ns | 14.37 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.43 ns | 0.0287 ns | 0.0254 ns | 15.42 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 16.49 ns | 0.0209 ns | 0.0196 ns | 16.49 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 14.33 ns | 0.0193 ns | 0.0171 ns | 14.34 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 12.94 ns | 0.1090 ns | 0.1020 ns | 12.89 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 13.07 ns | 0.0223 ns | 0.0198 ns | 13.07 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 15.92 ns | 0.1237 ns | 0.1157 ns | 15.88 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 16.06 ns | 0.1465 ns | 0.1370 ns | 16.12 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 22.89 ns | 0.0218 ns | 0.0204 ns | 22.89 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 | 19.99 ns | 0.0374 ns | 0.0312 ns | 19.99 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 | 18.72 ns | 0.0171 ns | 0.0160 ns | 18.72 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 | 25.25 ns | 0.1289 ns | 0.1143 ns | 25.20 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 | 23.13 ns | 0.1837 ns | 0.1718 ns | 23.16 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 14.30 ns | 0.0257 ns | 0.0215 ns | 14.30 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 14.60 ns | 0.0180 ns | 0.0159 ns | 14.61 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 13.62 ns | 0.2526 ns | 0.2363 ns | 13.43 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.64 ns | 0.0244 ns | 0.0229 ns | 14.64 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 17.19 ns | 0.0327 ns | 0.0290 ns | 17.19 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.86 ns | 0.0975 ns | 0.0864 ns | 22.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.36 ns | 0.1069 ns | 0.1000 ns | 21.40 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.23 ns | 0.4115 ns | 0.6527 ns | 18.78 ns |  0.87 |    0.03 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 26.86 ns | 0.0358 ns | 0.0335 ns | 26.86 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 23.52 ns | 0.0284 ns | 0.0266 ns | 23.52 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 15.05 ns | 0.0202 ns | 0.0189 ns | 15.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 13.84 ns | 0.0255 ns | 0.0226 ns | 13.84 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 15.04 ns | 0.0212 ns | 0.0198 ns | 15.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.65 ns | 0.0301 ns | 0.0267 ns | 14.65 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 16.24 ns | 0.1255 ns | 0.1174 ns | 16.19 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.91 ns | 0.0333 ns | 0.0295 ns | 17.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.09 ns | 0.0199 ns | 0.0167 ns | 14.10 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.26 ns | 0.0197 ns | 0.0184 ns | 13.25 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 15.68 ns | 0.1009 ns | 0.0944 ns | 15.66 ns |  0.88 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 17.59 ns | 0.0565 ns | 0.0441 ns | 17.61 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 14.69 ns | 0.0909 ns | 0.0850 ns | 14.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 13.18 ns | 0.0669 ns | 0.0626 ns | 13.15 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.55 ns | 0.3372 ns | 0.7611 ns | 15.86 ns |  0.99 |    0.07 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 16.47 ns | 0.0221 ns | 0.0196 ns | 16.47 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 16.15 ns | 0.0420 ns | 0.0393 ns | 16.14 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 23.35 ns | 0.0301 ns | 0.0281 ns | 23.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 22.07 ns | 0.0509 ns | 0.0425 ns | 22.06 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 18.88 ns | 0.0272 ns | 0.0241 ns | 18.87 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 21.80 ns | 0.1016 ns | 0.0900 ns | 21.79 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 23.01 ns | 0.1425 ns | 0.1333 ns | 22.99 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 14.41 ns | 0.0132 ns | 0.0110 ns | 14.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 14.15 ns | 0.1086 ns | 0.1016 ns | 14.19 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 14.41 ns | 0.1345 ns | 0.1258 ns | 14.40 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 16.31 ns | 0.0244 ns | 0.0216 ns | 16.31 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 16.46 ns | 0.1146 ns | 0.1072 ns | 16.40 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.53 ns | 0.0331 ns | 0.0293 ns | 22.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.52 ns | 0.0446 ns | 0.0372 ns | 21.53 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.90 ns | 0.0197 ns | 0.0174 ns | 18.91 ns |  0.84 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 21.92 ns | 0.0380 ns | 0.0355 ns | 21.92 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 22.94 ns | 0.1029 ns | 0.0962 ns | 22.90 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 14.59 ns | 0.0223 ns | 0.0187 ns | 14.59 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 14.10 ns | 0.0168 ns | 0.0149 ns | 14.10 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 15.23 ns | 0.0404 ns | 0.0337 ns | 15.22 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 16.27 ns | 0.1307 ns | 0.1223 ns | 16.23 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 16.36 ns | 0.0332 ns | 0.0311 ns | 16.35 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.75 ns | 0.0302 ns | 0.0283 ns | 19.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.22 ns | 0.0986 ns | 0.0922 ns | 14.24 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.26 ns | 0.0601 ns | 0.0562 ns | 16.27 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 16.45 ns | 0.0465 ns | 0.0412 ns | 16.44 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.55 ns | 0.0705 ns | 0.0589 ns | 16.53 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.99 ns | 0.0128 ns | 0.0120 ns | 13.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.91 ns | 0.0152 ns | 0.0135 ns | 12.91 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.70 ns | 0.1941 ns | 0.1815 ns | 12.80 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.06 ns | 0.0304 ns | 0.0269 ns | 15.05 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.43 ns | 0.0559 ns | 0.0523 ns | 15.41 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 24.56 ns | 0.0424 ns | 0.0396 ns | 24.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 21.15 ns | 0.0266 ns | 0.0236 ns | 21.15 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.20 ns | 0.1165 ns | 0.1089 ns | 18.14 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.46 ns | 0.0546 ns | 0.0511 ns | 21.45 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 23.36 ns | 0.1196 ns | 0.1119 ns | 23.32 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.33 ns | 0.0270 ns | 0.0253 ns | 14.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 13.97 ns | 0.0123 ns | 0.0115 ns | 13.98 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.30 ns | 0.0191 ns | 0.0169 ns | 13.30 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.67 ns | 0.0284 ns | 0.0252 ns | 14.68 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.14 ns | 0.0221 ns | 0.0207 ns | 16.13 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.09 ns | 0.0168 ns | 0.0141 ns | 22.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.22 ns | 0.0212 ns | 0.0188 ns | 21.22 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.89 ns | 0.0988 ns | 0.0925 ns | 24.92 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 21.41 ns | 0.0361 ns | 0.0338 ns | 21.40 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.50 ns | 0.0424 ns | 0.0376 ns | 22.50 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 14.31 ns | 0.0152 ns | 0.0135 ns | 14.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 14.46 ns | 0.0176 ns | 0.0165 ns | 14.46 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 13.31 ns | 0.1654 ns | 0.1547 ns | 13.40 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 16.22 ns | 0.1349 ns | 0.1262 ns | 16.14 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 16.12 ns | 0.0362 ns | 0.0302 ns | 16.11 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.10 ns | 0.0280 ns | 0.0262 ns | 19.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 16.90 ns | 0.0219 ns | 0.0205 ns | 16.90 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.15 ns | 0.0187 ns | 0.0166 ns | 13.15 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.20 ns | 0.0306 ns | 0.0271 ns | 15.20 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 16.62 ns | 0.0250 ns | 0.0221 ns | 16.61 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.73 ns | 0.0118 ns | 0.0111 ns | 13.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 12.79 ns | 0.0259 ns | 0.0243 ns | 12.80 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 12.20 ns | 0.0461 ns | 0.0431 ns | 12.19 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.51 ns | 0.0206 ns | 0.0193 ns | 13.52 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 14.82 ns | 0.0614 ns | 0.0574 ns | 14.79 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 22.09 ns | 0.0229 ns | 0.0203 ns | 22.09 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 19.54 ns | 0.0184 ns | 0.0163 ns | 19.54 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.13 ns | 0.3266 ns | 0.3055 ns | 17.97 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 22.52 ns | 0.0378 ns | 0.0316 ns | 22.52 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 23.39 ns | 0.0437 ns | 0.0409 ns | 23.39 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.85 ns | 0.0125 ns | 0.0104 ns | 13.85 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 13.27 ns | 0.0246 ns | 0.0218 ns | 13.27 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 13.91 ns | 0.1318 ns | 0.1233 ns | 13.86 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.37 ns | 0.0195 ns | 0.0173 ns | 13.36 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 15.99 ns | 0.0392 ns | 0.0367 ns | 16.00 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.11 ns | 0.0243 ns | 0.0215 ns | 22.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.43 ns | 0.0354 ns | 0.0296 ns | 19.43 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.34 ns | 0.1488 ns | 0.1391 ns | 20.44 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.51 ns | 0.0298 ns | 0.0279 ns | 21.51 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 23.26 ns | 0.0435 ns | 0.0385 ns | 23.25 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 13.81 ns | 0.0277 ns | 0.0259 ns | 13.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 13.30 ns | 0.0083 ns | 0.0074 ns | 13.30 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 12.09 ns | 0.0563 ns | 0.0527 ns | 12.07 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 14.76 ns | 0.1195 ns | 0.1118 ns | 14.72 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 16.03 ns | 0.0370 ns | 0.0328 ns | 16.02 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.97 ns | 0.0228 ns | 0.0191 ns | 15.97 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.11 ns | 0.0260 ns | 0.0243 ns | 14.11 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.13 ns | 0.2344 ns | 0.2192 ns | 13.99 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.27 ns | 0.0816 ns | 0.0681 ns | 15.28 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 17.92 ns | 0.0284 ns | 0.0266 ns | 17.93 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 15.21 ns | 0.0197 ns | 0.0184 ns | 15.21 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.80 ns | 0.0167 ns | 0.0139 ns | 12.80 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 12.87 ns | 0.0267 ns | 0.0250 ns | 12.87 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.87 ns | 0.0255 ns | 0.0213 ns | 14.87 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 14.91 ns | 0.1031 ns | 0.0964 ns | 14.86 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 22.24 ns | 0.1269 ns | 0.1187 ns | 22.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 20.91 ns | 0.0232 ns | 0.0193 ns | 20.91 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 20.09 ns | 0.0598 ns | 0.0530 ns | 20.08 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 22.01 ns | 0.0206 ns | 0.0172 ns | 22.02 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 23.31 ns | 0.0509 ns | 0.0425 ns | 23.32 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.83 ns | 0.0215 ns | 0.0168 ns | 13.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 13.27 ns | 0.0190 ns | 0.0177 ns | 13.27 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 12.35 ns | 0.4093 ns | 0.4872 ns | 12.07 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 15.09 ns | 0.1184 ns | 0.1107 ns | 15.04 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 15.96 ns | 0.0404 ns | 0.0378 ns | 15.97 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.11 ns | 0.0282 ns | 0.0250 ns | 22.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 21.93 ns | 0.0228 ns | 0.0202 ns | 21.93 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.47 ns | 0.2168 ns | 0.2028 ns | 21.56 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.43 ns | 0.0363 ns | 0.0283 ns | 21.43 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 23.53 ns | 0.0457 ns | 0.0405 ns | 23.53 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.95 ns | 0.1165 ns | 0.1090 ns | 14.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 13.28 ns | 0.0186 ns | 0.0174 ns | 13.28 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 12.67 ns | 0.0202 ns | 0.0189 ns | 12.66 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.65 ns | 0.0237 ns | 0.0210 ns | 14.65 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 15.25 ns | 0.0191 ns | 0.0179 ns | 15.25 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.09 ns | 0.0559 ns | 0.0496 ns | 19.07 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.07 ns | 0.0283 ns | 0.0251 ns | 15.08 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.89 ns | 0.1816 ns | 0.1698 ns | 14.97 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 15.41 ns | 0.0522 ns | 0.0436 ns | 15.42 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 17.88 ns | 0.1440 ns | 0.1347 ns | 17.93 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.71 ns | 0.0124 ns | 0.0110 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.91 ns | 0.0921 ns | 0.0861 ns | 12.95 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 11.97 ns | 0.0153 ns | 0.0119 ns | 11.98 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.51 ns | 0.0571 ns | 0.0534 ns | 13.49 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 14.80 ns | 0.0168 ns | 0.0149 ns | 14.80 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 23.95 ns | 0.1002 ns | 0.0937 ns | 23.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 19.46 ns | 0.0367 ns | 0.0306 ns | 19.45 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.33 ns | 0.4037 ns | 0.6403 ns | 18.92 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 21.42 ns | 0.0267 ns | 0.0223 ns | 21.42 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 22.85 ns | 0.1575 ns | 0.1473 ns | 22.91 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.53 ns | 0.0322 ns | 0.0301 ns | 14.51 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.80 ns | 0.0083 ns | 0.0074 ns | 13.80 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 13.26 ns | 0.0223 ns | 0.0186 ns | 13.26 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 16.12 ns | 0.0400 ns | 0.0334 ns | 16.13 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 17.23 ns | 0.0383 ns | 0.0339 ns | 17.22 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.54 ns | 0.0241 ns | 0.0201 ns | 24.54 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.62 ns | 0.1311 ns | 0.1226 ns | 19.69 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.88 ns | 0.0297 ns | 0.0277 ns | 18.89 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 21.43 ns | 0.0547 ns | 0.0485 ns | 21.43 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 23.47 ns | 0.1793 ns | 0.1677 ns | 23.38 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.85 ns | 0.1032 ns | 0.0965 ns | 14.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 14.43 ns | 0.0560 ns | 0.0524 ns | 14.41 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 13.26 ns | 0.0151 ns | 0.0126 ns | 13.26 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.66 ns | 0.0325 ns | 0.0304 ns | 14.66 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 16.27 ns | 0.0267 ns | 0.0223 ns | 16.27 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.00 ns | 0.0362 ns | 0.0302 ns | 16.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.06 ns | 0.0237 ns | 0.0210 ns | 15.06 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.14 ns | 0.1689 ns | 0.1580 ns | 14.06 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.22 ns | 0.0264 ns | 0.0234 ns | 15.22 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 18.44 ns | 0.0144 ns | 0.0135 ns | 18.44 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 13.73 ns | 0.0124 ns | 0.0104 ns | 13.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 12.97 ns | 0.0976 ns | 0.0865 ns | 13.01 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 12.01 ns | 0.0183 ns | 0.0171 ns | 12.02 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.51 ns | 0.0195 ns | 0.0162 ns | 13.51 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 16.46 ns | 0.1078 ns | 0.1009 ns | 16.51 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 22.20 ns | 0.1351 ns | 0.1264 ns | 22.12 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 19.68 ns | 0.0186 ns | 0.0155 ns | 19.68 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.93 ns | 0.1069 ns | 0.0947 ns | 19.00 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 22.69 ns | 0.0233 ns | 0.0207 ns | 22.69 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 22.47 ns | 0.1516 ns | 0.1418 ns | 22.36 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.84 ns | 0.0323 ns | 0.0287 ns | 13.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 13.30 ns | 0.0151 ns | 0.0141 ns | 13.30 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 13.69 ns | 0.1428 ns | 0.1336 ns | 13.59 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.71 ns | 0.1025 ns | 0.0959 ns | 14.66 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.96 ns | 0.0236 ns | 0.0220 ns | 14.96 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.11 ns | 0.0324 ns | 0.0303 ns | 22.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.58 ns | 0.1358 ns | 0.1270 ns | 19.52 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.99 ns | 0.0300 ns | 0.0266 ns | 17.99 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.55 ns | 0.0318 ns | 0.0266 ns | 21.55 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 24.02 ns | 0.0574 ns | 0.0509 ns | 24.03 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 13.94 ns | 0.1052 ns | 0.0984 ns | 14.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 13.27 ns | 0.0294 ns | 0.0245 ns | 13.26 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 12.80 ns | 0.2776 ns | 0.3305 ns | 12.59 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.64 ns | 0.0217 ns | 0.0203 ns | 14.64 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 14.82 ns | 0.0527 ns | 0.0493 ns | 14.80 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.39 ns | 0.0520 ns | 0.0461 ns | 19.39 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.10 ns | 0.0176 ns | 0.0164 ns | 14.11 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.47 ns | 0.2328 ns | 0.2177 ns | 13.59 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 15.53 ns | 0.1367 ns | 0.1279 ns | 15.47 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 17.84 ns | 0.1397 ns | 0.1307 ns | 17.91 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.97 ns | 0.0236 ns | 0.0197 ns | 13.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.75 ns | 0.0825 ns | 0.0732 ns | 12.79 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.07 ns | 0.0396 ns | 0.0351 ns | 12.08 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.35 ns | 0.0516 ns | 0.0483 ns | 13.34 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 16.25 ns | 0.0272 ns | 0.0241 ns | 16.25 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 22.20 ns | 0.1190 ns | 0.1113 ns | 22.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.31 ns | 0.0207 ns | 0.0162 ns | 20.31 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.83 ns | 0.0296 ns | 0.0277 ns | 18.84 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.44 ns | 0.0320 ns | 0.0299 ns | 21.44 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.43 ns | 0.0212 ns | 0.0198 ns | 23.43 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.83 ns | 0.0195 ns | 0.0183 ns | 13.82 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.43 ns | 0.0140 ns | 0.0131 ns | 13.43 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.03 ns | 0.0424 ns | 0.0397 ns | 12.02 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.73 ns | 0.0992 ns | 0.0928 ns | 14.68 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 18.83 ns | 0.0274 ns | 0.0243 ns | 18.83 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.58 ns | 0.0313 ns | 0.0293 ns | 24.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.71 ns | 0.1333 ns | 0.1247 ns | 20.74 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.87 ns | 0.0376 ns | 0.0333 ns | 17.87 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.59 ns | 0.1026 ns | 0.0959 ns | 21.54 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.13 ns | 0.0349 ns | 0.0309 ns | 23.13 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.35 ns | 0.0963 ns | 0.0901 ns | 14.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 13.50 ns | 0.0521 ns | 0.0488 ns | 13.48 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 12.17 ns | 0.2698 ns | 0.3602 ns | 11.98 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.02 ns | 0.0181 ns | 0.0161 ns | 14.02 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 14.91 ns | 0.1110 ns | 0.1038 ns | 14.85 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.00 ns | 0.0398 ns | 0.0352 ns | 15.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.10 ns | 0.0149 ns | 0.0132 ns | 14.10 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.09 ns | 0.0396 ns | 0.0371 ns | 13.09 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.39 ns | 0.0464 ns | 0.0411 ns | 15.39 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 18.47 ns | 0.1129 ns | 0.1001 ns | 18.43 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 13.75 ns | 0.0166 ns | 0.0129 ns | 13.76 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 13.01 ns | 0.0865 ns | 0.0809 ns | 13.05 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 12.71 ns | 0.0172 ns | 0.0153 ns | 12.70 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 13.47 ns | 0.0324 ns | 0.0288 ns | 13.47 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 14.87 ns | 0.0167 ns | 0.0156 ns | 14.86 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 23.37 ns | 0.1807 ns | 0.1690 ns | 23.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 21.06 ns | 0.0225 ns | 0.0200 ns | 21.07 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 21.62 ns | 0.0285 ns | 0.0267 ns | 21.61 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 23.86 ns | 0.0227 ns | 0.0212 ns | 23.86 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 24.09 ns | 0.0508 ns | 0.0450 ns | 24.09 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.71 ns | 0.0163 ns | 0.0127 ns | 13.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.78 ns | 0.0162 ns | 0.0135 ns | 12.78 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.74 ns | 0.0387 ns | 0.0343 ns | 12.72 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 13.59 ns | 0.1001 ns | 0.0937 ns | 13.54 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.85 ns | 0.0370 ns | 0.0346 ns | 14.85 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.96 ns | 0.0221 ns | 0.0207 ns | 15.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.09 ns | 0.0239 ns | 0.0187 ns | 14.09 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.18 ns | 0.1468 ns | 0.1374 ns | 13.10 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 16.83 ns | 0.0517 ns | 0.0458 ns | 16.83 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.65 ns | 0.0434 ns | 0.0385 ns | 16.63 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.71 ns | 0.0147 ns | 0.0130 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.79 ns | 0.0161 ns | 0.0143 ns | 12.79 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.06 ns | 0.0701 ns | 0.0656 ns | 12.03 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.45 ns | 0.0239 ns | 0.0212 ns | 13.45 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.90 ns | 0.0497 ns | 0.0388 ns | 14.91 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 | 22.96 ns | 0.0601 ns | 0.0562 ns | 22.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 | 21.27 ns | 0.0957 ns | 0.0848 ns | 21.30 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 | 18.63 ns | 0.0311 ns | 0.0276 ns | 18.63 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 | 22.23 ns | 0.0365 ns | 0.0285 ns | 22.24 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 | 23.19 ns | 0.1253 ns | 0.1172 ns | 23.15 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 13.70 ns | 0.0137 ns | 0.0128 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 12.80 ns | 0.0241 ns | 0.0225 ns | 12.80 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 11.95 ns | 0.0174 ns | 0.0163 ns | 11.96 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.80 ns | 0.0177 ns | 0.0157 ns | 14.80 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 14.88 ns | 0.0188 ns | 0.0166 ns | 14.87 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 22.03 ns | 0.0304 ns | 0.0284 ns | 22.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 20.43 ns | 0.0199 ns | 0.0177 ns | 20.43 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 19.06 ns | 0.0997 ns | 0.0933 ns | 19.03 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 23.08 ns | 0.0327 ns | 0.0306 ns | 23.06 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 26.37 ns | 0.0449 ns | 0.0420 ns | 26.36 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 13.79 ns | 0.0214 ns | 0.0200 ns | 13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 14.73 ns | 0.1049 ns | 0.0981 ns | 14.66 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 12.00 ns | 0.0245 ns | 0.0217 ns | 12.00 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.59 ns | 0.1051 ns | 0.0983 ns | 13.58 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.01 ns | 0.0446 ns | 0.0372 ns | 15.02 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.05 ns | 0.0305 ns | 0.0286 ns | 22.05 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.49 ns | 0.0868 ns | 0.0812 ns | 19.45 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.92 ns | 0.0844 ns | 0.0705 ns | 18.95 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.50 ns | 0.1243 ns | 0.1163 ns | 21.43 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 22.48 ns | 0.0314 ns | 0.0262 ns | 22.48 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.77 ns | 0.0253 ns | 0.0224 ns | 13.77 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 13.54 ns | 0.0235 ns | 0.0208 ns | 13.54 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 12.86 ns | 0.4852 ns | 0.4983 ns | 12.60 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.20 ns | 0.0145 ns | 0.0128 ns | 13.20 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 15.77 ns | 0.1451 ns | 0.1357 ns | 15.68 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.74 ns | 0.0267 ns | 0.0250 ns | 16.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 16.32 ns | 0.1013 ns | 0.0948 ns | 16.35 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.89 ns | 0.0248 ns | 0.0232 ns | 13.89 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 16.53 ns | 0.1204 ns | 0.1127 ns | 16.48 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 17.59 ns | 0.0232 ns | 0.0194 ns | 17.59 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 13.72 ns | 0.0381 ns | 0.0338 ns | 13.71 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 12.79 ns | 0.0247 ns | 0.0231 ns | 12.79 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 11.93 ns | 0.0150 ns | 0.0140 ns | 11.93 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 14.81 ns | 0.0146 ns | 0.0114 ns | 14.80 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 14.87 ns | 0.0199 ns | 0.0186 ns | 14.87 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 22.06 ns | 0.0069 ns | 0.0054 ns | 22.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 23.66 ns | 0.0343 ns | 0.0321 ns | 23.67 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 19.15 ns | 0.3995 ns | 0.3923 ns | 18.85 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.77 ns | 0.0301 ns | 0.0267 ns | 21.76 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 22.45 ns | 0.1561 ns | 0.1460 ns | 22.39 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 14.75 ns | 0.0141 ns | 0.0118 ns | 14.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 13.37 ns | 0.0951 ns | 0.0889 ns | 13.33 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 13.92 ns | 0.0333 ns | 0.0278 ns | 13.93 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.00 ns | 0.1103 ns | 0.1032 ns | 14.07 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 17.11 ns | 0.0366 ns | 0.0286 ns | 17.10 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.26 ns | 0.0278 ns | 0.0247 ns | 22.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.42 ns | 0.0326 ns | 0.0272 ns | 19.43 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.41 ns | 0.3750 ns | 0.3508 ns | 19.57 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 23.69 ns | 0.0931 ns | 0.0871 ns | 23.67 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 22.46 ns | 0.0440 ns | 0.0412 ns | 22.45 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.75 ns | 0.0144 ns | 0.0135 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 13.28 ns | 0.0203 ns | 0.0190 ns | 13.28 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 12.01 ns | 0.0158 ns | 0.0132 ns | 12.01 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.63 ns | 0.0341 ns | 0.0319 ns | 14.62 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 15.72 ns | 0.1099 ns | 0.1028 ns | 15.67 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.14 ns | 0.0303 ns | 0.0269 ns | 19.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.24 ns | 0.1018 ns | 0.0850 ns | 14.27 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.07 ns | 0.1675 ns | 0.1566 ns | 14.16 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 15.42 ns | 0.0190 ns | 0.0159 ns | 15.42 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 18.38 ns | 0.0403 ns | 0.0358 ns | 18.37 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.70 ns | 0.0148 ns | 0.0139 ns | 13.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.80 ns | 0.0091 ns | 0.0076 ns | 12.80 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 11.93 ns | 0.0158 ns | 0.0140 ns | 11.93 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.90 ns | 0.1014 ns | 0.0949 ns | 14.85 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 14.83 ns | 0.0199 ns | 0.0176 ns | 14.83 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 22.18 ns | 0.0392 ns | 0.0327 ns | 22.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 20.43 ns | 0.0295 ns | 0.0276 ns | 20.44 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 19.99 ns | 0.0747 ns | 0.0663 ns | 19.98 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 22.64 ns | 0.0250 ns | 0.0222 ns | 22.63 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 22.36 ns | 0.0368 ns | 0.0307 ns | 22.36 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.31 ns | 0.0186 ns | 0.0165 ns | 14.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 16.18 ns | 0.0988 ns | 0.0925 ns | 16.24 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 13.95 ns | 0.0235 ns | 0.0209 ns | 13.95 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.22 ns | 0.1115 ns | 0.1043 ns | 16.18 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 17.11 ns | 0.0512 ns | 0.0427 ns | 17.12 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.17 ns | 0.0382 ns | 0.0339 ns | 22.18 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.46 ns | 0.0231 ns | 0.0205 ns | 20.46 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.39 ns | 0.1407 ns | 0.1248 ns | 20.37 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 21.60 ns | 0.0316 ns | 0.0264 ns | 21.60 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 23.53 ns | 0.0414 ns | 0.0367 ns | 23.54 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 14.38 ns | 0.1475 ns | 0.1380 ns | 14.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 13.88 ns | 0.0212 ns | 0.0199 ns | 13.88 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 13.20 ns | 0.0310 ns | 0.0274 ns | 13.20 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 16.28 ns | 0.0377 ns | 0.0295 ns | 16.27 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 17.90 ns | 0.0684 ns | 0.0571 ns | 17.90 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.70 ns | 0.0586 ns | 0.0519 ns | 16.68 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.20 ns | 0.0948 ns | 0.0887 ns | 14.25 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.15 ns | 0.0328 ns | 0.0307 ns | 14.14 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 15.46 ns | 0.0186 ns | 0.0164 ns | 15.46 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.35 ns | 0.0280 ns | 0.0262 ns | 16.35 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 16.46 ns | 0.0376 ns | 0.0351 ns | 16.44 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 15.11 ns | 0.0271 ns | 0.0253 ns | 15.11 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 15.58 ns | 0.3373 ns | 0.4944 ns | 15.76 ns |  0.94 |    0.04 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.37 ns | 0.0139 ns | 0.0123 ns | 15.37 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 17.76 ns | 0.1495 ns | 0.1398 ns | 17.67 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.46 ns | 0.1097 ns | 0.1026 ns | 12.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.82 ns | 0.0357 ns | 0.0298 ns | 11.83 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.21 ns | 0.1092 ns | 0.1021 ns | 12.26 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.10 ns | 0.0197 ns | 0.0175 ns | 12.10 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.54 ns | 0.1236 ns | 0.1156 ns | 13.49 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.19 ns | 0.0365 ns | 0.0323 ns | 16.20 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 15.08 ns | 0.0265 ns | 0.0248 ns | 15.08 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.89 ns | 0.0246 ns | 0.0230 ns | 13.89 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.60 ns | 0.1194 ns | 0.1117 ns | 16.63 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 16.56 ns | 0.0413 ns | 0.0386 ns | 16.56 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 13.87 ns | 0.0402 ns | 0.0376 ns | 13.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.31 ns | 0.0232 ns | 0.0217 ns | 14.32 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.58 ns | 0.2085 ns | 0.1950 ns | 13.48 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 13.46 ns | 0.0274 ns | 0.0243 ns | 13.46 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 15.79 ns | 0.0419 ns | 0.0350 ns | 15.80 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 23.51 ns | 0.0524 ns | 0.0465 ns | 23.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.85 ns | 0.0153 ns | 0.0128 ns | 17.85 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.69 ns | 0.0572 ns | 0.0535 ns | 16.70 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 20.60 ns | 0.0428 ns | 0.0334 ns | 20.61 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 21.55 ns | 0.1146 ns | 0.1072 ns | 21.51 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.48 ns | 0.0224 ns | 0.0187 ns | 14.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.05 ns | 0.0122 ns | 0.0102 ns | 13.06 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.03 ns | 0.0314 ns | 0.0278 ns | 12.03 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.67 ns | 0.0892 ns | 0.0835 ns | 13.70 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.79 ns | 0.0145 ns | 0.0129 ns | 14.79 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.92 ns | 0.0424 ns | 0.0396 ns | 15.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.11 ns | 0.0143 ns | 0.0134 ns | 14.11 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.03 ns | 0.0782 ns | 0.0694 ns | 14.02 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 16.46 ns | 0.0379 ns | 0.0317 ns | 16.45 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 16.40 ns | 0.0418 ns | 0.0349 ns | 16.39 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.71 ns | 0.0552 ns | 0.0489 ns | 13.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.86 ns | 0.0135 ns | 0.0113 ns | 12.86 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.69 ns | 0.1245 ns | 0.1165 ns | 12.70 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.91 ns | 0.0741 ns | 0.0693 ns | 13.89 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.80 ns | 0.0573 ns | 0.0536 ns | 14.79 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 22.64 ns | 0.0327 ns | 0.0273 ns | 22.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 18.07 ns | 0.0221 ns | 0.0196 ns | 18.06 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 17.77 ns | 0.1509 ns | 0.1411 ns | 17.78 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 18.93 ns | 0.1155 ns | 0.1081 ns | 18.89 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 21.09 ns | 0.0351 ns | 0.0311 ns | 21.09 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.70 ns | 0.0193 ns | 0.0180 ns | 13.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.77 ns | 0.0168 ns | 0.0157 ns | 12.76 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 14.20 ns | 0.3086 ns | 0.4713 ns | 14.47 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.79 ns | 0.0237 ns | 0.0210 ns | 14.79 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.85 ns | 0.0370 ns | 0.0309 ns | 14.86 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 19.01 ns | 0.0277 ns | 0.0246 ns | 19.01 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.12 ns | 0.0144 ns | 0.0120 ns | 14.11 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.87 ns | 0.0317 ns | 0.0297 ns | 13.88 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.20 ns | 0.0272 ns | 0.0254 ns | 15.21 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 17.62 ns | 0.0303 ns | 0.0253 ns | 17.61 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 14.56 ns | 0.0145 ns | 0.0113 ns | 14.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct | .NET Core 2.2 | 13.36 ns | 0.0162 ns | 0.0136 ns | 13.36 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.63 ns | 0.1110 ns | 0.1039 ns | 12.66 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                From_ConvertibleStruct |        net461 | 14.36 ns | 0.1073 ns | 0.1004 ns | 14.31 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                From_ConvertibleStruct |        net472 | 14.93 ns | 0.0185 ns | 0.0173 ns | 14.93 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 20.38 ns | 0.0459 ns | 0.0429 ns | 20.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.86 ns | 0.0281 ns | 0.0263 ns | 17.86 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.56 ns | 0.3058 ns | 0.2860 ns | 17.52 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.37 ns | 0.0248 ns | 0.0194 ns | 19.37 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.70 ns | 0.1578 ns | 0.1476 ns | 20.64 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.75 ns | 0.0306 ns | 0.0271 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 14.08 ns | 0.0139 ns | 0.0116 ns | 14.08 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.29 ns | 0.2712 ns | 0.3015 ns | 12.51 ns |  0.89 |    0.02 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 14.67 ns | 0.0296 ns | 0.0277 ns | 14.66 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 14.79 ns | 0.0283 ns | 0.0236 ns | 14.80 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.98 ns | 0.0394 ns | 0.0308 ns | 24.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.65 ns | 0.0276 ns | 0.0258 ns | 19.64 ns |  0.79 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.55 ns | 0.0735 ns | 0.0688 ns | 17.53 ns |  0.70 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 19.38 ns | 0.0501 ns | 0.0468 ns | 19.36 ns |  0.78 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 21.80 ns | 0.0209 ns | 0.0174 ns | 21.81 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.76 ns | 0.0224 ns | 0.0199 ns | 13.75 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.28 ns | 0.0140 ns | 0.0124 ns | 13.28 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 12.12 ns | 0.1418 ns | 0.1107 ns | 12.14 ns |  0.88 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.40 ns | 0.0745 ns | 0.0697 ns | 13.36 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 15.75 ns | 0.1344 ns | 0.1257 ns | 15.67 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.93 ns | 0.0583 ns | 0.0517 ns | 15.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.11 ns | 0.0187 ns | 0.0166 ns | 14.10 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.22 ns | 0.2989 ns | 0.3070 ns | 14.03 ns |  0.90 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 17.28 ns | 0.0404 ns | 0.0358 ns | 17.27 ns |  1.08 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.35 ns | 0.0327 ns | 0.0290 ns | 16.35 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 14.72 ns | 0.0354 ns | 0.0295 ns | 14.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 15.82 ns | 0.0146 ns | 0.0129 ns | 15.82 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 | 13.48 ns | 0.0745 ns | 0.0622 ns | 13.49 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 14.85 ns | 0.0348 ns | 0.0290 ns | 14.84 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 14.81 ns | 0.0174 ns | 0.0163 ns | 14.81 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 21.30 ns | 0.0292 ns | 0.0273 ns | 21.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 17.24 ns | 0.0259 ns | 0.0230 ns | 17.24 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 17.81 ns | 0.2059 ns | 0.1926 ns | 17.83 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 20.55 ns | 0.1314 ns | 0.1097 ns | 20.58 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 21.70 ns | 0.0385 ns | 0.0360 ns | 21.71 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.80 ns | 0.0237 ns | 0.0198 ns | 13.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 13.27 ns | 0.0127 ns | 0.0118 ns | 13.27 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.73 ns | 0.2787 ns | 0.3209 ns | 12.87 ns |  0.92 |    0.03 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.79 ns | 0.0186 ns | 0.0165 ns | 14.80 ns |  1.07 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 14.78 ns | 0.0263 ns | 0.0233 ns | 14.79 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.40 ns | 0.1638 ns | 0.1532 ns | 22.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.30 ns | 0.0279 ns | 0.0261 ns | 19.29 ns |  0.86 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.17 ns | 0.3882 ns | 0.5313 ns | 18.47 ns |  0.80 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 20.93 ns | 0.0270 ns | 0.0239 ns | 20.93 ns |  0.93 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 21.41 ns | 0.0262 ns | 0.0245 ns | 21.41 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.78 ns | 0.0299 ns | 0.0279 ns | 13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 13.27 ns | 0.0141 ns | 0.0131 ns | 13.27 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 13.02 ns | 0.2666 ns | 0.2738 ns | 13.13 ns |  0.94 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 15.25 ns | 0.0225 ns | 0.0199 ns | 15.25 ns |  1.11 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 15.62 ns | 0.0260 ns | 0.0243 ns | 15.61 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 19.00 ns | 0.0277 ns | 0.0246 ns | 19.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.11 ns | 0.0128 ns | 0.0119 ns | 14.11 ns |  0.74 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.47 ns | 0.0682 ns | 0.0638 ns | 14.49 ns |  0.76 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.37 ns | 0.0245 ns | 0.0229 ns | 16.38 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 16.38 ns | 0.0351 ns | 0.0329 ns | 16.37 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.64 ns | 0.0188 ns | 0.0167 ns | 14.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 16.51 ns | 0.0202 ns | 0.0179 ns | 16.51 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 | 12.99 ns | 0.2448 ns | 0.2289 ns | 12.96 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.48 ns | 0.0246 ns | 0.0230 ns | 13.48 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 14.78 ns | 0.0268 ns | 0.0209 ns | 14.78 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 23.66 ns | 0.0379 ns | 0.0317 ns | 23.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 | 18.31 ns | 0.0216 ns | 0.0192 ns | 18.31 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 | 17.16 ns | 0.3541 ns | 0.3139 ns | 17.07 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 21.70 ns | 0.1577 ns | 0.1398 ns | 21.63 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 | 21.78 ns | 0.0270 ns | 0.0240 ns | 21.78 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.78 ns | 0.0313 ns | 0.0293 ns | 13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.27 ns | 0.0153 ns | 0.0135 ns | 13.28 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 12.12 ns | 0.0358 ns | 0.0335 ns | 12.12 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.19 ns | 0.0296 ns | 0.0277 ns | 13.19 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 15.40 ns | 0.0260 ns | 0.0244 ns | 15.41 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.71 ns | 0.0401 ns | 0.0335 ns | 23.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.18 ns | 0.0196 ns | 0.0164 ns | 19.18 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.59 ns | 0.3708 ns | 0.3642 ns | 18.75 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 20.79 ns | 0.0180 ns | 0.0160 ns | 20.79 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 22.48 ns | 0.0476 ns | 0.0372 ns | 22.48 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.55 ns | 0.0221 ns | 0.0207 ns | 14.55 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.27 ns | 0.0584 ns | 0.0488 ns | 13.26 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 12.92 ns | 0.0257 ns | 0.0228 ns | 12.93 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.84 ns | 0.1371 ns | 0.1071 ns | 14.89 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 14.78 ns | 0.0155 ns | 0.0145 ns | 14.78 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.96 ns | 0.0394 ns | 0.0329 ns | 15.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.11 ns | 0.0185 ns | 0.0173 ns | 14.11 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.40 ns | 0.2376 ns | 0.2223 ns | 13.56 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 15.18 ns | 0.0420 ns | 0.0393 ns | 15.19 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 17.53 ns | 0.0397 ns | 0.0371 ns | 17.54 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.48 ns | 0.0338 ns | 0.0264 ns | 13.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.59 ns | 0.0860 ns | 0.0805 ns | 11.54 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.11 ns | 0.1070 ns | 0.1001 ns | 12.11 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.54 ns | 0.1445 ns | 0.1281 ns | 15.48 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.05 ns | 0.0162 ns | 0.0151 ns | 13.05 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 23.77 ns | 0.0350 ns | 0.0310 ns | 23.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 19.05 ns | 0.0344 ns | 0.0268 ns | 19.05 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 17.17 ns | 0.0326 ns | 0.0289 ns | 17.17 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 20.64 ns | 0.0335 ns | 0.0313 ns | 20.64 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 20.13 ns | 0.0234 ns | 0.0183 ns | 20.13 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.25 ns | 0.0177 ns | 0.0156 ns | 13.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.45 ns | 0.0185 ns | 0.0164 ns | 11.45 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.73 ns | 0.0117 ns | 0.0091 ns | 12.73 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 13.45 ns | 0.0215 ns | 0.0191 ns | 13.46 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.61 ns | 0.0226 ns | 0.0211 ns | 12.61 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 16.67 ns | 0.0226 ns | 0.0176 ns | 16.67 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 15.17 ns | 0.1085 ns | 0.1015 ns | 15.11 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.01 ns | 0.1892 ns | 0.1769 ns | 13.90 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.37 ns | 0.0236 ns | 0.0221 ns | 15.37 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 16.52 ns | 0.1463 ns | 0.1369 ns | 16.45 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 83.17 ns | 0.2380 ns | 0.2110 ns | 83.16 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 | 83.26 ns | 0.3425 ns | 0.3036 ns | 83.17 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 | 85.56 ns | 0.7873 ns | 0.7364 ns | 85.35 ns |  1.03 |    0.01 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 | 93.23 ns | 0.0979 ns | 0.0915 ns | 93.23 ns |  1.12 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 89.85 ns | 0.6908 ns | 0.6461 ns | 89.66 ns |  1.08 |    0.01 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 19.73 ns | 0.0442 ns | 0.0391 ns | 19.74 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 19.78 ns | 0.0426 ns | 0.0399 ns | 19.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.74 ns | 0.3421 ns | 0.3513 ns | 16.52 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 21.54 ns | 0.0236 ns | 0.0209 ns | 21.54 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 21.04 ns | 0.0400 ns | 0.0374 ns | 21.04 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 82.19 ns | 0.7024 ns | 0.6570 ns | 81.87 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 84.38 ns | 1.1952 ns | 1.1180 ns | 84.02 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 92.11 ns | 0.6828 ns | 0.6387 ns | 92.13 ns |  1.12 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 87.33 ns | 0.2866 ns | 0.2238 ns | 87.40 ns |  1.06 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 89.32 ns | 0.1953 ns | 0.1525 ns | 89.27 ns |  1.09 |    0.01 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.58 ns | 0.0341 ns | 0.0319 ns | 19.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.27 ns | 0.1016 ns | 0.0951 ns | 18.24 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.48 ns | 0.0277 ns | 0.0246 ns | 16.48 ns |  0.84 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 20.94 ns | 0.0190 ns | 0.0178 ns | 20.94 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 20.13 ns | 0.0352 ns | 0.0312 ns | 20.12 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 45.04 ns | 0.1052 ns | 0.0822 ns | 45.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 41.36 ns | 0.0702 ns | 0.0656 ns | 41.35 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 44.23 ns | 1.1082 ns | 2.3133 ns | 42.96 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 46.35 ns | 0.0830 ns | 0.0736 ns | 46.36 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 44.45 ns | 0.1004 ns | 0.0890 ns | 44.46 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 18.99 ns | 0.0741 ns | 0.0657 ns | 18.96 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.17 ns | 0.0908 ns | 0.0849 ns | 15.21 ns |  0.80 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.31 ns | 0.2808 ns | 0.2627 ns | 14.39 ns |  0.76 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 16.44 ns | 0.0285 ns | 0.0266 ns | 16.44 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 16.60 ns | 0.0889 ns | 0.0743 ns | 16.59 ns |  0.87 |    0.01 |      - |     - |     - |         - |
