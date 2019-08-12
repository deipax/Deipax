
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
                                             From_Bool | .NET Core 2.0 | 15.91 ns | 0.0402 ns | 0.0376 ns | 15.92 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Bool | .NET Core 2.2 | 14.74 ns | 0.0527 ns | 0.0493 ns | 14.73 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Bool | .NET Core 3.0 | 15.69 ns | 0.3356 ns | 0.4364 ns | 15.41 ns |  1.00 |    0.03 | 0.0038 |     - |     - |      24 B |
                                             From_Bool |        net461 | 15.62 ns | 0.1751 ns | 0.1638 ns | 15.54 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Bool |        net472 | 15.02 ns | 0.0612 ns | 0.0542 ns | 15.02 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 12.39 ns | 0.1217 ns | 0.1139 ns | 12.41 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 11.40 ns | 0.0206 ns | 0.0182 ns | 11.40 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 12.14 ns | 0.0718 ns | 0.0671 ns | 12.15 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 13.81 ns | 0.0624 ns | 0.0553 ns | 13.79 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 13.46 ns | 0.0249 ns | 0.0233 ns | 13.45 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 15.32 ns | 0.0172 ns | 0.0144 ns | 15.32 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 14.72 ns | 0.0285 ns | 0.0238 ns | 14.72 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 15.78 ns | 0.0497 ns | 0.0441 ns | 15.79 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue |        net461 | 14.72 ns | 0.0697 ns | 0.0618 ns | 14.73 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Bool_Nullable_WithValue |        net472 | 14.47 ns | 0.0240 ns | 0.0213 ns | 14.46 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.87 ns | 0.0162 ns | 0.0144 ns | 13.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.96 ns | 0.1134 ns | 0.1061 ns | 13.99 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.12 ns | 0.0165 ns | 0.0147 ns | 12.12 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 12.24 ns | 0.0532 ns | 0.0498 ns | 12.25 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 12.18 ns | 0.0123 ns | 0.0109 ns | 12.18 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.33 ns | 0.0881 ns | 0.0824 ns | 13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.82 ns | 0.0222 ns | 0.0196 ns | 11.82 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 12.15 ns | 0.0595 ns | 0.0556 ns | 12.11 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.92 ns | 0.0957 ns | 0.0895 ns | 12.96 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 14.20 ns | 0.0379 ns | 0.0354 ns | 14.20 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.80 ns | 0.0165 ns | 0.0146 ns | 12.79 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.48 ns | 0.0487 ns | 0.0456 ns | 12.46 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.73 ns | 0.2788 ns | 0.3722 ns | 12.95 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 12.12 ns | 0.0205 ns | 0.0171 ns | 12.12 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 12.00 ns | 0.0188 ns | 0.0167 ns | 12.00 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 15.74 ns | 0.0243 ns | 0.0228 ns | 15.75 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte | .NET Core 2.2 | 14.71 ns | 0.0461 ns | 0.0385 ns | 14.72 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte | .NET Core 3.0 | 16.76 ns | 0.0420 ns | 0.0372 ns | 16.77 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Byte |        net461 | 15.19 ns | 0.1465 ns | 0.1299 ns | 15.13 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Byte |        net472 | 14.98 ns | 0.0368 ns | 0.0344 ns | 14.98 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 14.09 ns | 0.0420 ns | 0.0393 ns | 14.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 11.50 ns | 0.0223 ns | 0.0208 ns | 11.50 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 12.12 ns | 0.0152 ns | 0.0143 ns | 12.12 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 12.12 ns | 0.0143 ns | 0.0119 ns | 12.12 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 13.48 ns | 0.0252 ns | 0.0223 ns | 13.47 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 15.10 ns | 0.0196 ns | 0.0184 ns | 15.10 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 14.84 ns | 0.1359 ns | 0.1271 ns | 14.78 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 15.74 ns | 0.0656 ns | 0.0582 ns | 15.74 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue |        net461 | 16.25 ns | 0.0372 ns | 0.0330 ns | 16.26 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Byte_Nullable_WithValue |        net472 | 15.84 ns | 0.0378 ns | 0.0335 ns | 15.83 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.83 ns | 0.0828 ns | 0.0774 ns | 12.84 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.70 ns | 0.0743 ns | 0.0659 ns | 11.72 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.79 ns | 0.0235 ns | 0.0208 ns | 12.79 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 12.11 ns | 0.0246 ns | 0.0218 ns | 12.10 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 12.93 ns | 0.0195 ns | 0.0183 ns | 12.94 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 13.35 ns | 0.0597 ns | 0.0559 ns | 13.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.98 ns | 0.0228 ns | 0.0202 ns | 11.98 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 | 12.06 ns | 0.0331 ns | 0.0310 ns | 12.06 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.86 ns | 0.0236 ns | 0.0197 ns | 12.86 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.26 ns | 0.0303 ns | 0.0269 ns | 13.26 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.58 ns | 0.0284 ns | 0.0237 ns | 12.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.59 ns | 0.0169 ns | 0.0141 ns | 11.59 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.86 ns | 0.0651 ns | 0.0609 ns | 12.88 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.59 ns | 0.0225 ns | 0.0200 ns | 13.58 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.46 ns | 0.0324 ns | 0.0287 ns | 13.47 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 15.74 ns | 0.0457 ns | 0.0382 ns | 15.73 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 2.2 | 15.28 ns | 0.0423 ns | 0.0375 ns | 15.27 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char | .NET Core 3.0 | 15.80 ns | 0.3392 ns | 0.4411 ns | 15.53 ns |  1.02 |    0.03 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net461 | 16.52 ns | 0.0298 ns | 0.0264 ns | 16.52 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Char |        net472 | 16.52 ns | 0.0315 ns | 0.0279 ns | 16.53 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 12.23 ns | 0.0237 ns | 0.0185 ns | 12.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 12.91 ns | 0.0189 ns | 0.0158 ns | 12.91 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 12.10 ns | 0.0198 ns | 0.0175 ns | 12.09 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 12.14 ns | 0.0327 ns | 0.0306 ns | 12.15 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 13.64 ns | 0.0308 ns | 0.0241 ns | 13.65 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 16.78 ns | 0.0435 ns | 0.0407 ns | 16.78 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 16.42 ns | 0.0462 ns | 0.0432 ns | 16.42 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 15.65 ns | 0.0821 ns | 0.0768 ns | 15.62 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net461 | 14.58 ns | 0.0349 ns | 0.0326 ns | 14.57 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Char_Nullable_WithValue |        net472 | 14.86 ns | 0.0568 ns | 0.0474 ns | 14.85 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.86 ns | 0.0486 ns | 0.0431 ns | 13.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.48 ns | 0.0162 ns | 0.0143 ns | 11.48 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.70 ns | 0.2754 ns | 0.3279 ns | 12.88 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 12.20 ns | 0.0216 ns | 0.0192 ns | 12.20 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 13.44 ns | 0.0138 ns | 0.0122 ns | 13.43 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 13.37 ns | 0.0836 ns | 0.0782 ns | 13.33 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.81 ns | 0.0142 ns | 0.0133 ns | 11.80 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 | 12.07 ns | 0.0212 ns | 0.0188 ns | 12.06 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.22 ns | 0.0251 ns | 0.0234 ns | 14.21 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 14.43 ns | 0.0218 ns | 0.0193 ns | 14.43 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.69 ns | 0.0269 ns | 0.0251 ns | 14.70 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.11 ns | 0.0290 ns | 0.0257 ns | 12.11 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.16 ns | 0.0857 ns | 0.0802 ns | 12.19 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 12.12 ns | 0.0164 ns | 0.0146 ns | 12.12 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 14.18 ns | 0.0305 ns | 0.0254 ns | 14.18 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 16.34 ns | 0.0395 ns | 0.0350 ns | 16.33 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime | .NET Core 2.2 | 14.87 ns | 0.0386 ns | 0.0361 ns | 14.86 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime | .NET Core 3.0 | 17.06 ns | 0.3622 ns | 0.4026 ns | 17.21 ns |  1.04 |    0.03 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime |        net461 | 16.83 ns | 0.0236 ns | 0.0221 ns | 16.83 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                         From_DateTime |        net472 | 15.35 ns | 0.0432 ns | 0.0404 ns | 15.34 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 | 12.31 ns | 0.1052 ns | 0.0984 ns | 12.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 | 12.11 ns | 0.0192 ns | 0.0170 ns | 12.10 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 | 12.23 ns | 0.1019 ns | 0.0954 ns | 12.29 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 | 12.06 ns | 0.0192 ns | 0.0170 ns | 12.06 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 | 14.05 ns | 0.1560 ns | 0.1460 ns | 14.01 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 16.52 ns | 0.0358 ns | 0.0335 ns | 16.51 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 16.34 ns | 0.0466 ns | 0.0413 ns | 16.35 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 17.04 ns | 0.0447 ns | 0.0418 ns | 17.04 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue |        net461 | 18.71 ns | 0.1240 ns | 0.1160 ns | 18.67 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                      From_DateTime_Nullable_WithValue |        net472 | 17.22 ns | 0.0311 ns | 0.0276 ns | 17.22 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.25 ns | 0.0252 ns | 0.0236 ns | 12.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.49 ns | 0.0154 ns | 0.0129 ns | 11.49 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.35 ns | 0.2039 ns | 0.1907 ns | 12.46 ns |  1.01 |    0.02 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 | 12.12 ns | 0.0634 ns | 0.0593 ns | 12.09 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 | 13.49 ns | 0.0134 ns | 0.0119 ns | 13.49 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.37 ns | 0.0167 ns | 0.0130 ns | 13.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.48 ns | 0.0244 ns | 0.0217 ns | 12.48 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 13.60 ns | 0.0483 ns | 0.0452 ns | 13.61 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 15.43 ns | 0.0275 ns | 0.0257 ns | 15.44 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.65 ns | 0.1379 ns | 0.1290 ns | 14.59 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.99 ns | 0.0242 ns | 0.0227 ns | 12.99 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.43 ns | 0.0175 ns | 0.0163 ns | 12.44 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.08 ns | 0.0188 ns | 0.0157 ns | 12.09 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 12.08 ns | 0.0300 ns | 0.0251 ns | 12.08 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 12.00 ns | 0.0096 ns | 0.0080 ns | 12.00 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 17.13 ns | 0.0437 ns | 0.0365 ns | 17.13 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 2.2 | 16.32 ns | 0.0259 ns | 0.0230 ns | 16.32 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal | .NET Core 3.0 | 16.64 ns | 0.0485 ns | 0.0405 ns | 16.65 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal |        net461 | 17.98 ns | 0.1164 ns | 0.1089 ns | 17.92 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                                          From_Decimal |        net472 | 16.88 ns | 0.0862 ns | 0.0764 ns | 16.89 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 13.04 ns | 0.0745 ns | 0.0697 ns | 13.00 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 11.38 ns | 0.0180 ns | 0.0140 ns | 11.38 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 12.06 ns | 0.0152 ns | 0.0134 ns | 12.06 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 12.09 ns | 0.0124 ns | 0.0110 ns | 12.09 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 12.21 ns | 0.0252 ns | 0.0223 ns | 12.21 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 16.56 ns | 0.0789 ns | 0.0738 ns | 16.53 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 16.03 ns | 0.0252 ns | 0.0223 ns | 16.03 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.04 ns | 0.1428 ns | 0.1336 ns | 18.01 ns |  1.09 |    0.01 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net461 | 17.30 ns | 0.1608 ns | 0.1504 ns | 17.40 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
                       From_Decimal_Nullable_WithValue |        net472 | 17.14 ns | 0.0490 ns | 0.0435 ns | 17.13 ns |  1.04 |    0.01 | 0.0051 |     - |     - |      32 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.41 ns | 0.0318 ns | 0.0298 ns | 14.42 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.92 ns | 0.0098 ns | 0.0077 ns | 12.92 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.90 ns | 0.0376 ns | 0.0334 ns | 12.91 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 12.19 ns | 0.0213 ns | 0.0199 ns | 12.20 ns |  0.85 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 14.05 ns | 0.0370 ns | 0.0309 ns | 14.06 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.56 ns | 0.0297 ns | 0.0263 ns | 13.56 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 13.86 ns | 0.0322 ns | 0.0286 ns | 13.85 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 13.37 ns | 0.0227 ns | 0.0201 ns | 13.37 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.33 ns | 0.0282 ns | 0.0250 ns | 15.32 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.49 ns | 0.0350 ns | 0.0310 ns | 15.49 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.25 ns | 0.0149 ns | 0.0139 ns | 12.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.97 ns | 0.0238 ns | 0.0211 ns | 11.96 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.10 ns | 0.0227 ns | 0.0201 ns | 12.09 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 12.18 ns | 0.1013 ns | 0.0948 ns | 12.21 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 12.01 ns | 0.0213 ns | 0.0200 ns | 12.01 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 16.13 ns | 0.0259 ns | 0.0242 ns | 16.13 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 2.2 | 16.11 ns | 0.0327 ns | 0.0306 ns | 16.11 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double | .NET Core 3.0 | 15.34 ns | 0.0412 ns | 0.0344 ns | 15.34 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net461 | 14.46 ns | 0.0332 ns | 0.0277 ns | 14.45 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_Double |        net472 | 14.39 ns | 0.0287 ns | 0.0255 ns | 14.39 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 12.47 ns | 0.0559 ns | 0.0467 ns | 12.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 12.20 ns | 0.0139 ns | 0.0123 ns | 12.20 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 12.07 ns | 0.0170 ns | 0.0133 ns | 12.06 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 13.04 ns | 0.0170 ns | 0.0142 ns | 13.04 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 11.99 ns | 0.0633 ns | 0.0561 ns | 11.97 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.07 ns | 0.0484 ns | 0.0404 ns | 16.06 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 15.45 ns | 0.0389 ns | 0.0364 ns | 15.44 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 16.71 ns | 0.3599 ns | 0.3695 ns | 16.61 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net461 | 18.63 ns | 0.1754 ns | 0.1640 ns | 18.72 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
                        From_Double_Nullable_WithValue |        net472 | 16.52 ns | 0.0390 ns | 0.0345 ns | 16.52 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.09 ns | 0.0237 ns | 0.0210 ns | 14.08 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.94 ns | 0.0202 ns | 0.0179 ns | 12.94 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.34 ns | 0.2698 ns | 0.3869 ns | 12.09 ns |  0.89 |    0.03 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 13.02 ns | 0.0161 ns | 0.0143 ns | 13.03 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 14.10 ns | 0.0929 ns | 0.0824 ns | 14.07 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.35 ns | 0.0166 ns | 0.0147 ns | 13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 13.00 ns | 0.0152 ns | 0.0127 ns | 13.00 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 13.45 ns | 0.0133 ns | 0.0124 ns | 13.46 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.53 ns | 0.0199 ns | 0.0186 ns | 13.53 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.47 ns | 0.0313 ns | 0.0278 ns | 13.48 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.69 ns | 0.0223 ns | 0.0209 ns | 14.69 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.38 ns | 0.0200 ns | 0.0187 ns | 11.38 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.33 ns | 0.1535 ns | 0.1436 ns | 12.24 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 12.25 ns | 0.0908 ns | 0.0805 ns | 12.28 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 11.97 ns | 0.0212 ns | 0.0166 ns | 11.98 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 16.31 ns | 0.1375 ns | 0.1286 ns | 16.37 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Short | .NET Core 2.2 | 14.52 ns | 0.0234 ns | 0.0208 ns | 14.52 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Short | .NET Core 3.0 | 16.24 ns | 0.1862 ns | 0.1742 ns | 16.34 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Short |        net461 | 15.75 ns | 0.2128 ns | 0.1991 ns | 15.80 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Short |        net472 | 15.17 ns | 0.0732 ns | 0.0611 ns | 15.18 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 12.50 ns | 0.0166 ns | 0.0155 ns | 12.50 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 11.66 ns | 0.0153 ns | 0.0128 ns | 11.65 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 12.06 ns | 0.0218 ns | 0.0194 ns | 12.06 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 12.52 ns | 0.0255 ns | 0.0226 ns | 12.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 13.11 ns | 0.0188 ns | 0.0167 ns | 13.11 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 15.13 ns | 0.0330 ns | 0.0308 ns | 15.12 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 14.82 ns | 0.0260 ns | 0.0231 ns | 14.82 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 16.39 ns | 0.1471 ns | 0.1304 ns | 16.47 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue |        net461 | 15.45 ns | 0.0242 ns | 0.0214 ns | 15.45 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Short_Nullable_WithValue |        net472 | 15.15 ns | 0.0247 ns | 0.0219 ns | 15.15 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.40 ns | 0.0218 ns | 0.0203 ns | 12.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.62 ns | 0.0231 ns | 0.0216 ns | 11.62 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.32 ns | 0.2885 ns | 0.3087 ns | 13.39 ns |  1.07 |    0.03 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 12.70 ns | 0.1402 ns | 0.1311 ns | 12.67 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 13.80 ns | 0.0250 ns | 0.0234 ns | 13.80 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 14.80 ns | 0.0356 ns | 0.0297 ns | 14.80 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 11.80 ns | 0.0086 ns | 0.0077 ns | 11.80 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 | 12.78 ns | 0.0432 ns | 0.0383 ns | 12.79 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.53 ns | 0.0221 ns | 0.0196 ns | 12.53 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.66 ns | 0.0183 ns | 0.0171 ns | 12.66 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.86 ns | 0.0221 ns | 0.0185 ns | 13.86 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.40 ns | 0.0174 ns | 0.0154 ns | 11.40 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.25 ns | 0.0934 ns | 0.0780 ns | 12.28 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 12.21 ns | 0.0730 ns | 0.0647 ns | 12.23 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 12.19 ns | 0.0514 ns | 0.0456 ns | 12.20 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 16.15 ns | 0.0372 ns | 0.0311 ns | 16.14 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int | .NET Core 2.2 | 15.22 ns | 0.0364 ns | 0.0323 ns | 15.22 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int | .NET Core 3.0 | 15.30 ns | 0.0630 ns | 0.0559 ns | 15.31 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int |        net461 | 16.59 ns | 0.0299 ns | 0.0265 ns | 16.60 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                                              From_Int |        net472 | 15.57 ns | 0.1291 ns | 0.1208 ns | 15.53 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 12.38 ns | 0.0286 ns | 0.0267 ns | 12.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 11.39 ns | 0.0202 ns | 0.0189 ns | 11.38 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 12.79 ns | 0.0290 ns | 0.0257 ns | 12.79 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 13.15 ns | 0.0289 ns | 0.0270 ns | 13.15 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 13.36 ns | 0.0192 ns | 0.0160 ns | 13.36 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 15.27 ns | 0.0253 ns | 0.0236 ns | 15.27 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 15.75 ns | 0.0796 ns | 0.0665 ns | 15.75 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 15.91 ns | 0.1098 ns | 0.1027 ns | 15.94 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue |        net461 | 16.46 ns | 0.0589 ns | 0.0492 ns | 16.46 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                           From_Int_Nullable_WithValue |        net472 | 14.57 ns | 0.0554 ns | 0.0491 ns | 14.56 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.52 ns | 0.0129 ns | 0.0114 ns | 12.52 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.49 ns | 0.0257 ns | 0.0215 ns | 11.48 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.07 ns | 0.0247 ns | 0.0219 ns | 12.07 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 12.35 ns | 0.0941 ns | 0.0834 ns | 12.38 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 11.96 ns | 0.0172 ns | 0.0153 ns | 11.96 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.33 ns | 0.0944 ns | 0.0883 ns | 13.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.94 ns | 0.0366 ns | 0.0325 ns | 11.92 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 12.72 ns | 0.0421 ns | 0.0394 ns | 12.73 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.91 ns | 0.0320 ns | 0.0299 ns | 13.91 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.54 ns | 0.0301 ns | 0.0281 ns | 12.55 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.19 ns | 0.0274 ns | 0.0256 ns | 14.19 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.72 ns | 0.0189 ns | 0.0177 ns | 11.73 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.47 ns | 0.2702 ns | 0.2527 ns | 12.51 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 14.72 ns | 0.0208 ns | 0.0195 ns | 14.72 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.43 ns | 0.0556 ns | 0.0493 ns | 13.42 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 17.02 ns | 0.0324 ns | 0.0287 ns | 17.02 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long | .NET Core 2.2 | 14.64 ns | 0.0381 ns | 0.0356 ns | 14.64 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long | .NET Core 3.0 | 17.94 ns | 0.0415 ns | 0.0368 ns | 17.95 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Long |        net461 | 16.80 ns | 0.1258 ns | 0.1116 ns | 16.83 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Long |        net472 | 15.01 ns | 0.0646 ns | 0.0604 ns | 14.99 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 12.44 ns | 0.0859 ns | 0.0762 ns | 12.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 12.11 ns | 0.0706 ns | 0.0660 ns | 12.09 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 12.68 ns | 0.0197 ns | 0.0164 ns | 12.68 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 13.49 ns | 0.0212 ns | 0.0198 ns | 13.50 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 13.38 ns | 0.0323 ns | 0.0287 ns | 13.38 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 15.98 ns | 0.0205 ns | 0.0182 ns | 15.98 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 15.90 ns | 0.0698 ns | 0.0653 ns | 15.89 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 17.48 ns | 0.2832 ns | 0.2649 ns | 17.45 ns |  1.09 |    0.02 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue |        net461 | 16.32 ns | 0.0539 ns | 0.0478 ns | 16.31 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Long_Nullable_WithValue |        net472 | 18.41 ns | 0.0604 ns | 0.0504 ns | 18.43 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.88 ns | 0.0166 ns | 0.0155 ns | 13.87 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.07 ns | 0.0230 ns | 0.0192 ns | 12.08 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.15 ns | 0.0234 ns | 0.0195 ns | 12.14 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 12.17 ns | 0.1054 ns | 0.0986 ns | 12.22 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 11.97 ns | 0.0188 ns | 0.0147 ns | 11.96 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.53 ns | 0.1265 ns | 0.1121 ns | 14.58 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.27 ns | 0.0603 ns | 0.0564 ns | 12.24 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 14.03 ns | 0.0322 ns | 0.0301 ns | 14.03 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 15.20 ns | 0.0232 ns | 0.0217 ns | 15.21 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 15.07 ns | 0.0211 ns | 0.0176 ns | 15.07 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.02 ns | 0.0142 ns | 0.0118 ns | 13.02 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.19 ns | 0.0155 ns | 0.0129 ns | 12.19 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.18 ns | 0.0784 ns | 0.0733 ns | 12.21 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.19 ns | 0.1203 ns | 0.1125 ns | 13.26 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 12.14 ns | 0.0290 ns | 0.0227 ns | 12.13 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 15.75 ns | 0.0730 ns | 0.0648 ns | 15.74 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_SByte | .NET Core 2.2 | 14.68 ns | 0.0789 ns | 0.0738 ns | 14.69 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_SByte | .NET Core 3.0 | 15.43 ns | 0.1377 ns | 0.1288 ns | 15.36 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_SByte |        net461 | 15.03 ns | 0.0248 ns | 0.0207 ns | 15.03 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_SByte |        net472 | 16.81 ns | 0.0904 ns | 0.0846 ns | 16.78 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 12.41 ns | 0.1227 ns | 0.1148 ns | 12.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 11.48 ns | 0.0124 ns | 0.0097 ns | 11.48 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 12.90 ns | 0.0282 ns | 0.0263 ns | 12.91 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 13.15 ns | 0.0227 ns | 0.0212 ns | 13.15 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 14.19 ns | 0.0254 ns | 0.0225 ns | 14.20 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 15.14 ns | 0.1034 ns | 0.0967 ns | 15.10 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 17.09 ns | 0.0471 ns | 0.0393 ns | 17.08 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 16.13 ns | 0.2252 ns | 0.2107 ns | 16.24 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue |        net461 | 15.59 ns | 0.0693 ns | 0.0614 ns | 15.60 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_SByte_Nullable_WithValue |        net472 | 14.91 ns | 0.0453 ns | 0.0424 ns | 14.92 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.34 ns | 0.0434 ns | 0.0339 ns | 14.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.55 ns | 0.0886 ns | 0.0828 ns | 11.58 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.19 ns | 0.0509 ns | 0.0451 ns | 12.19 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 13.69 ns | 0.0384 ns | 0.0359 ns | 13.68 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 11.97 ns | 0.0706 ns | 0.0626 ns | 11.95 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 13.15 ns | 0.0187 ns | 0.0175 ns | 13.14 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 13.52 ns | 0.0638 ns | 0.0597 ns | 13.50 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 12.19 ns | 0.0526 ns | 0.0492 ns | 12.21 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.91 ns | 0.0295 ns | 0.0246 ns | 13.91 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.54 ns | 0.0169 ns | 0.0150 ns | 12.54 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.98 ns | 0.1137 ns | 0.1064 ns | 13.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.73 ns | 0.1263 ns | 0.1120 ns | 11.73 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.42 ns | 0.0911 ns | 0.0852 ns | 12.36 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.62 ns | 0.1310 ns | 0.1225 ns | 13.67 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 11.97 ns | 0.0247 ns | 0.0219 ns | 11.97 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 16.13 ns | 0.0442 ns | 0.0369 ns | 16.13 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 2.2 | 14.70 ns | 0.0984 ns | 0.0921 ns | 14.74 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Float | .NET Core 3.0 | 15.55 ns | 0.0622 ns | 0.0552 ns | 15.55 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net461 | 16.50 ns | 0.1088 ns | 0.0964 ns | 16.45 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_Float |        net472 | 15.23 ns | 0.0715 ns | 0.0668 ns | 15.21 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 12.25 ns | 0.0125 ns | 0.0117 ns | 12.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 11.50 ns | 0.0579 ns | 0.0541 ns | 11.48 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 12.19 ns | 0.0698 ns | 0.0653 ns | 12.22 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 13.44 ns | 0.0188 ns | 0.0157 ns | 13.44 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 12.48 ns | 0.1743 ns | 0.1630 ns | 12.44 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.29 ns | 0.1117 ns | 0.1045 ns | 15.32 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 15.62 ns | 0.0252 ns | 0.0236 ns | 15.62 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 17.10 ns | 0.3638 ns | 0.4601 ns | 17.30 ns |  1.11 |    0.03 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net461 | 16.41 ns | 0.0934 ns | 0.0873 ns | 16.42 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                         From_Float_Nullable_WithValue |        net472 | 15.48 ns | 0.0393 ns | 0.0328 ns | 15.49 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.27 ns | 0.0192 ns | 0.0170 ns | 12.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.49 ns | 0.0204 ns | 0.0191 ns | 11.49 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.30 ns | 0.4466 ns | 0.4587 ns | 12.03 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 12.06 ns | 0.0519 ns | 0.0486 ns | 12.05 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 11.97 ns | 0.0303 ns | 0.0269 ns | 11.96 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 13.13 ns | 0.0127 ns | 0.0113 ns | 13.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 12.27 ns | 0.0784 ns | 0.0655 ns | 12.29 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 12.22 ns | 0.1461 ns | 0.1367 ns | 12.31 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.31 ns | 0.0281 ns | 0.0249 ns | 14.32 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.56 ns | 0.0606 ns | 0.0567 ns | 12.54 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.36 ns | 0.1212 ns | 0.1133 ns | 12.29 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.37 ns | 0.0169 ns | 0.0158 ns | 12.36 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.16 ns | 0.1382 ns | 0.1293 ns | 12.23 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 12.10 ns | 0.0248 ns | 0.0220 ns | 12.10 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.36 ns | 0.0184 ns | 0.0172 ns | 13.36 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 14.04 ns | 0.0550 ns | 0.0459 ns | 14.03 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 11.41 ns | 0.0273 ns | 0.0242 ns | 11.41 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 11.93 ns | 0.0639 ns | 0.0534 ns | 11.92 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 12.74 ns | 0.0196 ns | 0.0183 ns | 12.74 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 12.46 ns | 0.0237 ns | 0.0198 ns | 12.46 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 12.28 ns | 0.0191 ns | 0.0178 ns | 12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 11.43 ns | 0.0714 ns | 0.0668 ns | 11.40 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 12.75 ns | 0.0329 ns | 0.0308 ns | 12.76 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 12.10 ns | 0.0134 ns | 0.0119 ns | 12.10 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 13.52 ns | 0.0693 ns | 0.0615 ns | 13.50 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.60 ns | 0.1171 ns | 0.1095 ns | 13.53 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 13.22 ns | 0.0114 ns | 0.0101 ns | 13.21 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.15 ns | 0.0843 ns | 0.0747 ns | 12.17 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.20 ns | 0.0971 ns | 0.0908 ns | 12.24 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.15 ns | 0.0307 ns | 0.0256 ns | 12.15 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.37 ns | 0.0334 ns | 0.0296 ns | 14.37 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.48 ns | 0.0296 ns | 0.0262 ns | 11.48 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.13 ns | 0.0436 ns | 0.0386 ns | 12.13 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.46 ns | 0.0264 ns | 0.0234 ns | 13.46 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.61 ns | 0.0178 ns | 0.0167 ns | 13.62 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.43 ns | 0.0190 ns | 0.0178 ns | 13.43 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.82 ns | 0.1174 ns | 0.1098 ns | 11.85 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.99 ns | 0.0349 ns | 0.0326 ns | 12.00 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.70 ns | 0.0657 ns | 0.0615 ns | 12.72 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.45 ns | 0.0141 ns | 0.0132 ns | 12.45 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 | 12.28 ns | 0.0322 ns | 0.0302 ns | 12.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 | 11.49 ns | 0.0185 ns | 0.0154 ns | 11.49 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 | 12.33 ns | 0.1197 ns | 0.0999 ns | 12.37 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 | 12.08 ns | 0.0191 ns | 0.0169 ns | 12.08 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 | 13.35 ns | 0.0170 ns | 0.0151 ns | 13.35 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 15.98 ns | 0.1492 ns | 0.1246 ns | 15.92 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                           From_UShort | .NET Core 2.2 | 14.54 ns | 0.0980 ns | 0.0917 ns | 14.49 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                                           From_UShort | .NET Core 3.0 | 15.35 ns | 0.0537 ns | 0.0502 ns | 15.35 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                           From_UShort |        net461 | 15.70 ns | 0.0335 ns | 0.0314 ns | 15.69 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                           From_UShort |        net472 | 15.13 ns | 0.0225 ns | 0.0188 ns | 15.13 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 12.61 ns | 0.1099 ns | 0.1028 ns | 12.60 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 11.37 ns | 0.0160 ns | 0.0133 ns | 11.37 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 12.11 ns | 0.0410 ns | 0.0364 ns | 12.10 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 14.72 ns | 0.1412 ns | 0.1321 ns | 14.66 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 11.97 ns | 0.0216 ns | 0.0202 ns | 11.96 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 15.35 ns | 0.0815 ns | 0.0722 ns | 15.34 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 14.79 ns | 0.0468 ns | 0.0366 ns | 14.79 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 16.78 ns | 0.1015 ns | 0.0949 ns | 16.79 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue |        net461 | 14.87 ns | 0.0326 ns | 0.0305 ns | 14.86 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                        From_UShort_Nullable_WithValue |        net472 | 14.95 ns | 0.0280 ns | 0.0248 ns | 14.95 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.79 ns | 0.0239 ns | 0.0224 ns | 13.78 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.41 ns | 0.0472 ns | 0.0441 ns | 11.39 ns |  0.83 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.10 ns | 0.0426 ns | 0.0356 ns | 12.09 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 12.03 ns | 0.0205 ns | 0.0192 ns | 12.03 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 13.61 ns | 0.0816 ns | 0.0681 ns | 13.64 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 14.13 ns | 0.0204 ns | 0.0181 ns | 14.13 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 12.39 ns | 0.1134 ns | 0.1005 ns | 12.41 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 12.25 ns | 0.2395 ns | 0.2240 ns | 12.36 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.42 ns | 0.1163 ns | 0.1088 ns | 13.46 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.96 ns | 0.0625 ns | 0.0522 ns | 13.94 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.50 ns | 0.0788 ns | 0.0737 ns | 12.46 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.47 ns | 0.0145 ns | 0.0135 ns | 11.47 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.21 ns | 0.1310 ns | 0.1225 ns | 12.25 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 12.07 ns | 0.0172 ns | 0.0153 ns | 12.07 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.75 ns | 0.1423 ns | 0.1188 ns | 13.72 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 15.90 ns | 0.0428 ns | 0.0379 ns | 15.90 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt | .NET Core 2.2 | 15.57 ns | 0.0723 ns | 0.0641 ns | 15.59 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt | .NET Core 3.0 | 15.62 ns | 0.2171 ns | 0.2031 ns | 15.70 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_UInt |        net461 | 16.50 ns | 0.0306 ns | 0.0286 ns | 16.50 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_UInt |        net472 | 15.22 ns | 0.0844 ns | 0.0749 ns | 15.18 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 13.02 ns | 0.1139 ns | 0.1065 ns | 13.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 12.21 ns | 0.0151 ns | 0.0134 ns | 12.21 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 12.06 ns | 0.0396 ns | 0.0351 ns | 12.07 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 12.25 ns | 0.0596 ns | 0.0558 ns | 12.26 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 13.83 ns | 0.1145 ns | 0.1015 ns | 13.86 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 15.09 ns | 0.0204 ns | 0.0191 ns | 15.09 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 15.65 ns | 0.0210 ns | 0.0196 ns | 15.65 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 15.68 ns | 0.1099 ns | 0.1028 ns | 15.66 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue |        net461 | 16.82 ns | 0.0313 ns | 0.0277 ns | 16.82 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_UInt_Nullable_WithValue |        net472 | 15.08 ns | 0.1139 ns | 0.1066 ns | 15.10 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.27 ns | 0.0247 ns | 0.0231 ns | 12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.59 ns | 0.0601 ns | 0.0562 ns | 11.60 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.84 ns | 0.1337 ns | 0.1185 ns | 12.87 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 12.07 ns | 0.0174 ns | 0.0155 ns | 12.07 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 13.36 ns | 0.0426 ns | 0.0356 ns | 13.35 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.40 ns | 0.0146 ns | 0.0122 ns | 13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 13.46 ns | 0.0167 ns | 0.0156 ns | 13.47 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 | 12.00 ns | 0.0236 ns | 0.0209 ns | 12.00 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.14 ns | 0.0903 ns | 0.0801 ns | 14.16 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.76 ns | 0.0176 ns | 0.0156 ns | 12.77 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.27 ns | 0.0155 ns | 0.0129 ns | 12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.06 ns | 0.0107 ns | 0.0084 ns | 12.06 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.02 ns | 0.0184 ns | 0.0172 ns | 12.02 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 12.07 ns | 0.0181 ns | 0.0169 ns | 12.07 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 12.00 ns | 0.1435 ns | 0.1121 ns | 11.96 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 15.79 ns | 0.0425 ns | 0.0397 ns | 15.78 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong | .NET Core 2.2 | 14.68 ns | 0.0809 ns | 0.0676 ns | 14.70 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                            From_ULong | .NET Core 3.0 | 16.66 ns | 0.0780 ns | 0.0730 ns | 16.66 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_ULong |        net461 | 16.66 ns | 0.1260 ns | 0.1179 ns | 16.62 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                            From_ULong |        net472 | 15.27 ns | 0.2404 ns | 0.2131 ns | 15.28 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 15.83 ns | 0.0428 ns | 0.0334 ns | 15.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 11.59 ns | 0.0148 ns | 0.0131 ns | 11.59 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 12.18 ns | 0.2652 ns | 0.2837 ns | 12.01 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 13.63 ns | 0.0928 ns | 0.0823 ns | 13.66 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 12.75 ns | 0.0704 ns | 0.0659 ns | 12.73 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 15.89 ns | 0.0304 ns | 0.0284 ns | 15.89 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 16.00 ns | 0.0407 ns | 0.0360 ns | 16.00 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 16.81 ns | 0.0715 ns | 0.0597 ns | 16.79 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue |        net461 | 16.47 ns | 0.0253 ns | 0.0224 ns | 16.46 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                         From_ULong_Nullable_WithValue |        net472 | 16.74 ns | 0.1541 ns | 0.1441 ns | 16.70 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.83 ns | 0.0279 ns | 0.0261 ns | 15.83 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.68 ns | 0.0716 ns | 0.0634 ns | 11.70 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.69 ns | 0.0159 ns | 0.0149 ns | 12.69 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 12.02 ns | 0.0153 ns | 0.0135 ns | 12.02 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 13.43 ns | 0.0573 ns | 0.0508 ns | 13.43 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.40 ns | 0.0164 ns | 0.0153 ns | 13.40 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.23 ns | 0.0175 ns | 0.0155 ns | 12.24 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 14.01 ns | 0.0381 ns | 0.0356 ns | 14.01 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.69 ns | 0.1129 ns | 0.1001 ns | 13.74 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.36 ns | 0.0406 ns | 0.0360 ns | 14.36 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.26 ns | 0.0195 ns | 0.0182 ns | 12.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.87 ns | 0.0180 ns | 0.0160 ns | 12.87 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.23 ns | 0.2683 ns | 0.3393 ns | 12.03 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 12.05 ns | 0.0502 ns | 0.0470 ns | 12.04 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 12.87 ns | 0.0943 ns | 0.0882 ns | 12.89 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 12.26 ns | 0.0352 ns | 0.0294 ns | 12.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.55 ns | 0.0543 ns | 0.0482 ns | 11.56 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.00 ns | 0.0206 ns | 0.0160 ns | 12.00 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 12.44 ns | 0.0219 ns | 0.0194 ns | 12.43 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.58 ns | 0.1102 ns | 0.1031 ns | 13.57 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 14.06 ns | 0.0172 ns | 0.0161 ns | 14.06 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.88 ns | 0.0162 ns | 0.0143 ns | 11.87 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.12 ns | 0.0266 ns | 0.0208 ns | 13.12 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.73 ns | 0.1166 ns | 0.1090 ns | 12.78 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.61 ns | 0.0675 ns | 0.0563 ns | 12.59 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.03 ns | 0.0180 ns | 0.0150 ns | 13.04 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.97 ns | 0.0100 ns | 0.0094 ns | 12.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.00 ns | 0.0099 ns | 0.0088 ns | 12.00 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.88 ns | 0.0172 ns | 0.0161 ns | 13.88 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.63 ns | 0.0603 ns | 0.0534 ns | 13.62 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 13.22 ns | 0.0350 ns | 0.0310 ns | 13.22 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.03 ns | 0.0197 ns | 0.0175 ns | 13.03 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.71 ns | 0.0168 ns | 0.0148 ns | 12.71 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 14.06 ns | 0.0192 ns | 0.0160 ns | 14.05 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 12.56 ns | 0.0885 ns | 0.0828 ns | 12.54 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 12.38 ns | 0.0278 ns | 0.0247 ns | 12.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 11.54 ns | 0.0776 ns | 0.0725 ns | 11.50 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 12.49 ns | 0.5336 ns | 0.8463 ns | 12.02 ns |  1.06 |    0.08 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 12.16 ns | 0.0831 ns | 0.0777 ns | 12.21 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 13.50 ns | 0.1076 ns | 0.1007 ns | 13.48 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 12.90 ns | 0.0185 ns | 0.0173 ns | 12.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.50 ns | 0.0152 ns | 0.0142 ns | 11.50 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.48 ns | 0.2673 ns | 0.2971 ns | 12.64 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 12.10 ns | 0.0884 ns | 0.0827 ns | 12.06 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.57 ns | 0.0820 ns | 0.0727 ns | 14.55 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 12.25 ns | 0.0296 ns | 0.0277 ns | 12.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.49 ns | 0.0258 ns | 0.0215 ns | 11.49 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.01 ns | 0.0189 ns | 0.0176 ns | 12.01 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 12.02 ns | 0.0153 ns | 0.0135 ns | 12.03 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.70 ns | 0.0867 ns | 0.0811 ns | 13.66 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.54 ns | 0.1251 ns | 0.1170 ns | 13.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.39 ns | 0.0197 ns | 0.0174 ns | 11.39 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.77 ns | 0.0996 ns | 0.0931 ns | 12.72 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.66 ns | 0.1190 ns | 0.1113 ns | 12.60 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.04 ns | 0.0536 ns | 0.0475 ns | 15.05 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 12.36 ns | 0.0306 ns | 0.0286 ns | 12.36 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 12.15 ns | 0.1150 ns | 0.1075 ns | 12.15 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 12.66 ns | 0.2332 ns | 0.2181 ns | 12.82 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 13.78 ns | 0.0221 ns | 0.0172 ns | 13.78 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 13.52 ns | 0.0912 ns | 0.0809 ns | 13.51 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.65 ns | 0.0438 ns | 0.0410 ns | 12.63 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 13.00 ns | 0.0280 ns | 0.0248 ns | 12.99 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.97 ns | 0.0257 ns | 0.0240 ns | 11.97 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.07 ns | 0.0158 ns | 0.0148 ns | 12.07 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.78 ns | 0.1768 ns | 0.1567 ns | 12.82 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.23 ns | 0.0131 ns | 0.0110 ns | 13.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.28 ns | 0.0381 ns | 0.0338 ns | 13.27 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.58 ns | 0.1563 ns | 0.1462 ns | 12.59 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 12.14 ns | 0.1186 ns | 0.1110 ns | 12.20 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.46 ns | 0.0445 ns | 0.0395 ns | 13.45 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 14.78 ns | 0.0420 ns | 0.0393 ns | 14.78 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 14.57 ns | 0.0413 ns | 0.0344 ns | 14.57 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 15.28 ns | 0.2195 ns | 0.2053 ns | 15.18 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.17 ns | 0.0241 ns | 0.0188 ns | 16.16 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.58 ns | 0.1441 ns | 0.1348 ns | 17.54 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 12.26 ns | 0.0166 ns | 0.0147 ns | 12.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 12.24 ns | 0.0136 ns | 0.0113 ns | 12.24 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 12.44 ns | 0.2715 ns | 0.2788 ns | 12.25 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 13.50 ns | 0.0175 ns | 0.0164 ns | 13.50 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 12.08 ns | 0.0863 ns | 0.0807 ns | 12.05 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 15.31 ns | 0.0314 ns | 0.0278 ns | 15.31 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 14.86 ns | 0.0225 ns | 0.0199 ns | 14.86 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 16.58 ns | 0.1858 ns | 0.1738 ns | 16.60 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 16.43 ns | 0.1088 ns | 0.0965 ns | 16.48 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.02 ns | 0.1062 ns | 0.0994 ns | 16.99 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.90 ns | 0.0355 ns | 0.0296 ns | 13.90 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.63 ns | 0.0254 ns | 0.0238 ns | 11.63 ns |  0.84 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.21 ns | 0.1138 ns | 0.0888 ns | 12.25 ns |  0.88 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 12.09 ns | 0.0222 ns | 0.0197 ns | 12.09 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 13.67 ns | 0.1062 ns | 0.0993 ns | 13.67 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.73 ns | 0.0290 ns | 0.0243 ns | 13.72 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.87 ns | 0.0170 ns | 0.0133 ns | 11.87 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 12.24 ns | 0.1286 ns | 0.1203 ns | 12.28 ns |  0.89 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.66 ns | 0.0146 ns | 0.0136 ns | 12.66 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.98 ns | 0.0429 ns | 0.0380 ns | 13.97 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.61 ns | 0.0882 ns | 0.0825 ns | 12.64 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.63 ns | 0.0457 ns | 0.0428 ns | 11.61 ns |  0.92 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.10 ns | 0.0488 ns | 0.0433 ns | 12.08 ns |  0.96 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 12.16 ns | 0.0966 ns | 0.0903 ns | 12.20 ns |  0.96 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.66 ns | 0.0485 ns | 0.0454 ns | 13.66 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 15.15 ns | 0.0352 ns | 0.0330 ns | 15.16 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 2.2 | 15.36 ns | 0.0326 ns | 0.0305 ns | 15.36 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct | .NET Core 3.0 | 15.15 ns | 0.0486 ns | 0.0455 ns | 15.16 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net461 | 17.26 ns | 0.0497 ns | 0.0465 ns | 17.25 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
                             From_NonConvertibleStruct |        net472 | 16.40 ns | 0.1664 ns | 0.1557 ns | 16.38 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.00 ns | 0.1221 ns | 0.1142 ns | 13.95 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 12.17 ns | 0.2262 ns | 0.2116 ns | 12.07 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 12.17 ns | 0.1148 ns | 0.1074 ns | 12.21 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 12.54 ns | 0.0162 ns | 0.0152 ns | 12.54 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 12.04 ns | 0.0955 ns | 0.0893 ns | 12.01 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 15.34 ns | 0.0259 ns | 0.0243 ns | 15.34 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.77 ns | 0.0843 ns | 0.0789 ns | 15.74 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 16.36 ns | 0.0361 ns | 0.0320 ns | 16.37 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 17.34 ns | 0.0979 ns | 0.0916 ns | 17.37 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 16.33 ns | 0.1736 ns | 0.1539 ns | 16.26 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.94 ns | 0.0283 ns | 0.0265 ns | 12.93 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.35 ns | 0.1189 ns | 0.1112 ns | 12.33 ns |  0.95 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.08 ns | 0.0794 ns | 0.0743 ns | 12.12 ns |  0.93 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 12.60 ns | 0.0130 ns | 0.0115 ns | 12.60 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 12.24 ns | 0.1592 ns | 0.1412 ns | 12.22 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.98 ns | 0.0409 ns | 0.0342 ns | 13.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.86 ns | 0.0245 ns | 0.0229 ns | 11.86 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 12.64 ns | 0.2750 ns | 0.3057 ns | 12.83 ns |  0.90 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 14.27 ns | 0.0254 ns | 0.0238 ns | 14.26 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 16.23 ns | 0.2073 ns | 0.1939 ns | 16.16 ns |  1.16 |    0.02 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.97 ns | 0.0668 ns | 0.0624 ns | 14.98 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.56 ns | 0.0170 ns | 0.0159 ns | 11.56 ns |  0.77 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.03 ns | 0.0460 ns | 0.0430 ns | 12.02 ns |  0.80 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 12.10 ns | 0.0233 ns | 0.0206 ns | 12.10 ns |  0.81 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 12.14 ns | 0.0769 ns | 0.0719 ns | 12.13 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.86 ns | 0.0182 ns | 0.0152 ns | 14.86 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 2.2 | 14.63 ns | 0.1038 ns | 0.0971 ns | 14.60 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                                             From_Enum | .NET Core 3.0 | 15.41 ns | 0.0920 ns | 0.0816 ns | 15.44 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum |        net461 | 16.46 ns | 0.0365 ns | 0.0305 ns | 16.46 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                                             From_Enum |        net472 | 16.69 ns | 0.0809 ns | 0.0757 ns | 16.69 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 12.38 ns | 0.0137 ns | 0.0107 ns | 12.38 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 | 11.45 ns | 0.0173 ns | 0.0144 ns | 11.45 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 | 12.15 ns | 0.1132 ns | 0.1059 ns | 12.20 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 | 12.08 ns | 0.0141 ns | 0.0117 ns | 12.08 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 | 13.70 ns | 0.0124 ns | 0.0103 ns | 13.70 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 15.34 ns | 0.1163 ns | 0.1088 ns | 15.38 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 15.96 ns | 0.1009 ns | 0.0944 ns | 15.98 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 16.03 ns | 0.3464 ns | 0.4504 ns | 15.68 ns |  1.06 |    0.03 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue |        net461 | 14.58 ns | 0.0460 ns | 0.0431 ns | 14.57 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                          From_Enum_Nullable_WithValue |        net472 | 16.45 ns | 0.0432 ns | 0.0404 ns | 16.46 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.72 ns | 0.0265 ns | 0.0235 ns | 12.73 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.50 ns | 0.1024 ns | 0.0958 ns | 11.45 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.12 ns | 0.0300 ns | 0.0266 ns | 12.12 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 12.15 ns | 0.0263 ns | 0.0219 ns | 12.15 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 13.36 ns | 0.0176 ns | 0.0165 ns | 13.35 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 15.26 ns | 0.0369 ns | 0.0327 ns | 15.25 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.86 ns | 0.0195 ns | 0.0182 ns | 11.87 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 | 12.06 ns | 0.0321 ns | 0.0284 ns | 12.05 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.98 ns | 0.0324 ns | 0.0270 ns | 13.99 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 15.50 ns | 0.0310 ns | 0.0275 ns | 15.50 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.48 ns | 0.0166 ns | 0.0147 ns | 12.48 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.46 ns | 0.0287 ns | 0.0268 ns | 12.45 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.01 ns | 0.0386 ns | 0.0361 ns | 12.00 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 12.13 ns | 0.0185 ns | 0.0173 ns | 12.14 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.40 ns | 0.0333 ns | 0.0311 ns | 13.40 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.23 ns | 0.0230 ns | 0.0192 ns | 13.23 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.52 ns | 0.0192 ns | 0.0170 ns | 12.52 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.05 ns | 0.2230 ns | 0.2086 ns | 13.03 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.67 ns | 0.0657 ns | 0.0615 ns | 12.69 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.01 ns | 0.0298 ns | 0.0278 ns | 14.00 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 12.32 ns | 0.0889 ns | 0.0831 ns | 12.31 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 12.24 ns | 0.0353 ns | 0.0330 ns | 12.23 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 11.99 ns | 0.0204 ns | 0.0159 ns | 12.00 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 12.08 ns | 0.0156 ns | 0.0121 ns | 12.09 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 12.33 ns | 0.0646 ns | 0.0573 ns | 12.34 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.90 ns | 0.0750 ns | 0.0701 ns | 12.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.42 ns | 0.0127 ns | 0.0113 ns | 11.42 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.00 ns | 0.0421 ns | 0.0394 ns | 12.01 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.20 ns | 0.0230 ns | 0.0203 ns | 12.20 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.21 ns | 0.0783 ns | 0.0694 ns | 12.24 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 12.28 ns | 0.0276 ns | 0.0245 ns | 12.28 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.12 ns | 0.0151 ns | 0.0141 ns | 12.13 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.46 ns | 0.1946 ns | 0.1821 ns | 12.42 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 12.19 ns | 0.1026 ns | 0.0959 ns | 12.24 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.39 ns | 0.0308 ns | 0.0257 ns | 13.39 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 83.92 ns | 0.2863 ns | 0.2678 ns | 83.81 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 2.2 | 86.47 ns | 0.1860 ns | 0.1648 ns | 86.45 ns |  1.03 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct | .NET Core 3.0 | 86.52 ns | 0.3046 ns | 0.2378 ns | 86.47 ns |  1.03 |    0.00 | 0.0854 |     - |     - |     536 B |
                                     From_ParentStruct |        net461 | 84.16 ns | 0.1021 ns | 0.0955 ns | 84.18 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                                     From_ParentStruct |        net472 | 88.53 ns | 0.2358 ns | 0.1969 ns | 88.59 ns |  1.05 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 13.23 ns | 0.0939 ns | 0.0833 ns | 13.26 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 11.53 ns | 0.0962 ns | 0.0900 ns | 11.48 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 12.33 ns | 0.3720 ns | 0.3820 ns | 12.12 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 12.10 ns | 0.0115 ns | 0.0102 ns | 12.10 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 12.15 ns | 0.0657 ns | 0.0615 ns | 12.16 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 84.02 ns | 0.1610 ns | 0.1257 ns | 83.97 ns |  1.00 |    0.00 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 84.50 ns | 0.3874 ns | 0.3623 ns | 84.36 ns |  1.01 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 86.89 ns | 0.8822 ns | 0.8252 ns | 86.72 ns |  1.03 |    0.01 | 0.0854 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net461 | 86.69 ns | 0.5749 ns | 0.4801 ns | 86.81 ns |  1.03 |    0.01 | 0.0851 |     - |     - |     536 B |
                  From_ParentStruct_Nullable_WithValue |        net472 | 88.70 ns | 0.2178 ns | 0.1931 ns | 88.74 ns |  1.06 |    0.00 | 0.0851 |     - |     - |     536 B |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 12.93 ns | 0.0237 ns | 0.0198 ns | 12.92 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 11.54 ns | 0.0142 ns | 0.0126 ns | 11.54 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.00 ns | 0.0246 ns | 0.0218 ns | 11.99 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 12.11 ns | 0.0467 ns | 0.0414 ns | 12.10 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 11.97 ns | 0.0412 ns | 0.0344 ns | 11.97 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.09 ns | 0.0864 ns | 0.0766 ns | 42.11 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 43.88 ns | 0.3899 ns | 0.3647 ns | 43.67 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 43.22 ns | 0.8787 ns | 1.2318 ns | 44.19 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 44.66 ns | 0.0361 ns | 0.0338 ns | 44.67 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 43.94 ns | 0.2066 ns | 0.1932 ns | 43.99 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |          |           |           |          |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 12.36 ns | 0.0246 ns | 0.0205 ns | 12.35 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.55 ns | 0.0572 ns | 0.0535 ns | 11.53 ns |  0.93 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.24 ns | 0.0832 ns | 0.0778 ns | 12.27 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 12.25 ns | 0.1335 ns | 0.1249 ns | 12.31 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 11.98 ns | 0.0191 ns | 0.0179 ns | 11.97 ns |  0.97 |    0.00 |      - |     - |     - |         - |
