
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
                                             From_Bool | .NET Core 2.0 | 13.552 ns | 0.0538 ns | 0.0503 ns | 13.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.187 ns | 0.0178 ns | 0.0167 ns | 10.185 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.270 ns | 0.1566 ns | 0.1465 ns |  7.388 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.666 ns | 0.0165 ns | 0.0146 ns | 12.665 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.414 ns | 0.0129 ns | 0.0120 ns | 10.416 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.743 ns | 0.0340 ns | 0.0301 ns | 17.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.412 ns | 0.1200 ns | 0.1123 ns | 15.358 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.636 ns | 0.0224 ns | 0.0198 ns | 15.639 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.539 ns | 0.0199 ns | 0.0176 ns | 18.539 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.636 ns | 0.0452 ns | 0.0401 ns | 20.633 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.865 ns | 0.0118 ns | 0.0111 ns | 11.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.442 ns | 0.0100 ns | 0.0094 ns | 10.441 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.454 ns | 0.1877 ns | 0.2977 ns |  7.292 ns |  0.64 |    0.03 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.285 ns | 0.0578 ns | 0.0512 ns | 13.297 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.620 ns | 0.0107 ns | 0.0100 ns | 10.616 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.937 ns | 0.0263 ns | 0.0246 ns | 17.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.792 ns | 0.0340 ns | 0.0302 ns | 15.786 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.827 ns | 0.1732 ns | 0.1620 ns | 15.911 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 21.154 ns | 0.0276 ns | 0.0258 ns | 21.154 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.232 ns | 0.0273 ns | 0.0242 ns | 20.228 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.339 ns | 0.0331 ns | 0.0276 ns | 12.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.207 ns | 0.0374 ns | 0.0350 ns | 10.211 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.168 ns | 0.1662 ns | 0.1979 ns |  7.030 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.799 ns | 0.0149 ns | 0.0132 ns | 11.799 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.240 ns | 0.0203 ns | 0.0190 ns | 10.237 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.058 ns | 0.0111 ns | 0.0099 ns | 14.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.850 ns | 0.0131 ns | 0.0122 ns | 11.848 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.191 ns | 0.0132 ns | 0.0123 ns | 14.196 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.315 ns | 0.0291 ns | 0.0273 ns | 13.311 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.211 ns | 0.0852 ns | 0.0797 ns | 15.251 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.756 ns | 0.0180 ns | 0.0160 ns | 12.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.000 ns | 0.0569 ns | 0.0532 ns | 10.034 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.949 ns | 0.0835 ns | 0.0781 ns |  7.003 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.655 ns | 0.0163 ns | 0.0153 ns | 11.651 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.330 ns | 0.0140 ns | 0.0131 ns | 10.327 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.792 ns | 0.0218 ns | 0.0193 ns | 18.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.967 ns | 0.0233 ns | 0.0218 ns | 15.962 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.259 ns | 0.0297 ns | 0.0248 ns | 15.247 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.916 ns | 0.0259 ns | 0.0242 ns | 18.914 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.713 ns | 0.0319 ns | 0.0283 ns | 20.715 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.176 ns | 0.0133 ns | 0.0118 ns | 12.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.385 ns | 0.0156 ns | 0.0146 ns | 11.380 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.101 ns | 0.0125 ns | 0.0111 ns |  7.098 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.199 ns | 0.0143 ns | 0.0134 ns | 12.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.436 ns | 0.0109 ns | 0.0091 ns | 10.436 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.427 ns | 0.0573 ns | 0.0536 ns | 18.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.176 ns | 0.0290 ns | 0.0271 ns | 15.168 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.081 ns | 0.0282 ns | 0.0263 ns | 15.076 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.791 ns | 0.0247 ns | 0.0231 ns | 18.791 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.041 ns | 0.0183 ns | 0.0171 ns | 20.031 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.595 ns | 0.0245 ns | 0.0229 ns | 11.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.083 ns | 0.0082 ns | 0.0073 ns | 10.086 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.839 ns | 0.1812 ns | 0.2712 ns |  7.939 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.499 ns | 0.0104 ns | 0.0092 ns | 12.501 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.235 ns | 0.0168 ns | 0.0141 ns | 10.233 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.857 ns | 0.0122 ns | 0.0102 ns | 14.860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.842 ns | 0.0095 ns | 0.0084 ns | 11.843 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.956 ns | 0.0530 ns | 0.0496 ns | 11.933 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.895 ns | 0.0130 ns | 0.0116 ns | 13.892 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 14.907 ns | 0.0211 ns | 0.0187 ns | 14.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.919 ns | 0.0138 ns | 0.0122 ns | 11.914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.022 ns | 0.0233 ns | 0.0207 ns | 10.026 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.955 ns | 0.0702 ns | 0.0657 ns |  6.970 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.706 ns | 0.0820 ns | 0.0767 ns | 11.654 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.349 ns | 0.0163 ns | 0.0136 ns | 10.346 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.374 ns | 0.2787 ns | 0.2607 ns | 18.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.080 ns | 0.0181 ns | 0.0160 ns | 17.082 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.265 ns | 0.0794 ns | 0.0620 ns | 18.270 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.313 ns | 0.0419 ns | 0.0371 ns | 18.308 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.903 ns | 0.0808 ns | 0.0756 ns | 19.933 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.774 ns | 0.0142 ns | 0.0133 ns | 11.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.310 ns | 0.0192 ns | 0.0150 ns | 10.308 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.101 ns | 0.0194 ns | 0.0162 ns |  7.098 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.163 ns | 0.0147 ns | 0.0137 ns | 12.163 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.423 ns | 0.0235 ns | 0.0220 ns | 10.419 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.660 ns | 0.0278 ns | 0.0260 ns | 18.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.872 ns | 0.0158 ns | 0.0140 ns | 15.876 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.330 ns | 0.0337 ns | 0.0315 ns | 15.328 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.294 ns | 0.0159 ns | 0.0141 ns | 18.293 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 19.774 ns | 0.0340 ns | 0.0301 ns | 19.769 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.590 ns | 0.0142 ns | 0.0133 ns | 11.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.064 ns | 0.0197 ns | 0.0175 ns | 10.061 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.988 ns | 0.0149 ns | 0.0133 ns |  7.984 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.836 ns | 0.0152 ns | 0.0127 ns | 11.837 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.268 ns | 0.0151 ns | 0.0141 ns | 10.269 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.937 ns | 0.0108 ns | 0.0096 ns | 14.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.635 ns | 0.0256 ns | 0.0239 ns | 13.636 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.289 ns | 0.2694 ns | 0.3309 ns | 12.075 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 16.072 ns | 0.0112 ns | 0.0099 ns | 16.071 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.821 ns | 0.0242 ns | 0.0226 ns | 15.822 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.928 ns | 0.0460 ns | 0.0384 ns | 11.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.050 ns | 0.0251 ns | 0.0223 ns | 11.043 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.496 ns | 0.1896 ns | 0.2531 ns |  8.617 ns |  0.70 |    0.03 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.414 ns | 0.0245 ns | 0.0217 ns | 13.410 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.375 ns | 0.1146 ns | 0.1072 ns | 12.387 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.486 ns | 0.0162 ns | 0.0151 ns | 12.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.041 ns | 0.0211 ns | 0.0197 ns | 11.040 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.475 ns | 0.1898 ns | 0.2260 ns |  8.570 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.441 ns | 0.0563 ns | 0.0527 ns | 13.460 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.670 ns | 0.0734 ns | 0.0687 ns | 13.705 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.917 ns | 0.0171 ns | 0.0151 ns | 12.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.038 ns | 0.0100 ns | 0.0078 ns | 11.039 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.249 ns | 0.0123 ns | 0.0115 ns |  8.252 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.693 ns | 0.0304 ns | 0.0269 ns | 14.684 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.624 ns | 0.0161 ns | 0.0143 ns | 12.625 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.085 ns | 0.0256 ns | 0.0214 ns | 14.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.850 ns | 0.0298 ns | 0.0279 ns | 11.843 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.372 ns | 0.5804 ns | 0.8507 ns | 11.906 ns |  0.92 |    0.07 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.192 ns | 0.0195 ns | 0.0182 ns | 13.192 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 17.786 ns | 0.0328 ns | 0.0291 ns | 17.777 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 26.810 ns | 0.1301 ns | 0.1086 ns | 26.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.803 ns | 0.1306 ns | 0.1221 ns | 23.840 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.542 ns | 0.0456 ns | 0.0356 ns | 15.531 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 27.515 ns | 0.0273 ns | 0.0242 ns | 27.511 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.156 ns | 0.0227 ns | 0.0212 ns | 25.151 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.696 ns | 0.0370 ns | 0.0346 ns | 26.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.382 ns | 0.0508 ns | 0.0475 ns | 26.383 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.808 ns | 0.7267 ns | 1.1527 ns | 21.185 ns |  0.85 |    0.05 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.140 ns | 0.0250 ns | 0.0208 ns | 27.149 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 29.923 ns | 0.0264 ns | 0.0234 ns | 29.919 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.743 ns | 0.0255 ns | 0.0238 ns | 25.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.383 ns | 0.0392 ns | 0.0327 ns | 23.368 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 17.027 ns | 0.0626 ns | 0.0585 ns | 17.038 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 27.999 ns | 0.0532 ns | 0.0444 ns | 27.991 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.921 ns | 0.0359 ns | 0.0318 ns | 26.913 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.965 ns | 0.0184 ns | 0.0163 ns | 27.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.581 ns | 0.0505 ns | 0.0448 ns | 25.577 ns |  0.91 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.292 ns | 0.0328 ns | 0.0307 ns | 20.288 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 27.315 ns | 0.1131 ns | 0.1058 ns | 27.364 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 29.231 ns | 0.0209 ns | 0.0175 ns | 29.228 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.594 ns | 0.0292 ns | 0.0259 ns | 12.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.437 ns | 0.0130 ns | 0.0121 ns | 11.436 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.039 ns | 0.0145 ns | 0.0136 ns |  8.037 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.723 ns | 0.0288 ns | 0.0270 ns | 14.719 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.537 ns | 0.0646 ns | 0.0604 ns | 13.551 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.360 ns | 0.0254 ns | 0.0225 ns | 14.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.504 ns | 0.0181 ns | 0.0170 ns | 13.504 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.184 ns | 0.2663 ns | 0.3067 ns | 11.964 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.211 ns | 0.0115 ns | 0.0108 ns | 13.213 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 16.039 ns | 0.0259 ns | 0.0229 ns | 16.043 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.655 ns | 0.0301 ns | 0.0267 ns | 13.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.151 ns | 0.0162 ns | 0.0144 ns | 12.154 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.003 ns | 0.0135 ns | 0.0113 ns | 10.003 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.784 ns | 0.0196 ns | 0.0183 ns | 15.788 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.984 ns | 0.0165 ns | 0.0155 ns | 13.981 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.679 ns | 0.0788 ns | 0.0737 ns | 20.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.475 ns | 0.0422 ns | 0.0374 ns | 17.473 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.270 ns | 0.1564 ns | 0.1463 ns | 18.264 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.457 ns | 0.0331 ns | 0.0310 ns | 20.445 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 23.813 ns | 0.0519 ns | 0.0434 ns | 23.800 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.294 ns | 0.0197 ns | 0.0175 ns | 15.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.004 ns | 0.0162 ns | 0.0151 ns | 14.007 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.679 ns | 0.0255 ns | 0.0213 ns | 12.673 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.120 ns | 0.0980 ns | 0.0916 ns | 17.074 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.936 ns | 0.0141 ns | 0.0125 ns | 15.937 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.175 ns | 0.0239 ns | 0.0224 ns | 24.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.803 ns | 0.0430 ns | 0.0359 ns | 17.793 ns |  0.74 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.650 ns | 0.0324 ns | 0.0303 ns | 18.646 ns |  0.77 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.481 ns | 0.0333 ns | 0.0312 ns | 20.472 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.099 ns | 0.0274 ns | 0.0256 ns | 22.096 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.929 ns | 0.0167 ns | 0.0130 ns | 12.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.447 ns | 0.0123 ns | 0.0109 ns | 11.446 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.202 ns | 0.1945 ns | 0.2597 ns |  8.061 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.887 ns | 0.0183 ns | 0.0171 ns | 14.884 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.646 ns | 0.0133 ns | 0.0118 ns | 12.643 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.042 ns | 0.0100 ns | 0.0089 ns | 14.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.522 ns | 0.0181 ns | 0.0170 ns | 12.514 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.517 ns | 0.0591 ns | 0.0461 ns | 12.502 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.223 ns | 0.0130 ns | 0.0121 ns | 13.220 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.913 ns | 0.0261 ns | 0.0244 ns | 14.914 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.260 ns | 0.0431 ns | 0.0404 ns | 12.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.162 ns | 0.0134 ns | 0.0125 ns | 10.160 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.699 ns | 0.1128 ns | 0.1055 ns |  6.637 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.258 ns | 0.0138 ns | 0.0107 ns | 12.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.879 ns | 0.0133 ns | 0.0118 ns | 10.876 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.337 ns | 0.0295 ns | 0.0276 ns | 18.334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.211 ns | 0.0319 ns | 0.0298 ns | 15.204 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.071 ns | 0.0165 ns | 0.0138 ns | 15.073 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.854 ns | 0.0701 ns | 0.0622 ns | 19.866 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.938 ns | 0.0242 ns | 0.0214 ns | 20.931 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.509 ns | 0.0120 ns | 0.0106 ns | 12.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.385 ns | 0.0126 ns | 0.0111 ns | 10.384 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.396 ns | 0.0141 ns | 0.0118 ns |  7.393 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.225 ns | 0.0125 ns | 0.0117 ns | 13.227 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.936 ns | 0.0161 ns | 0.0142 ns | 11.935 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.105 ns | 0.0334 ns | 0.0313 ns | 18.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.381 ns | 0.0155 ns | 0.0137 ns | 15.380 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.448 ns | 0.0176 ns | 0.0156 ns | 15.453 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.920 ns | 0.0342 ns | 0.0320 ns | 21.911 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.955 ns | 0.0259 ns | 0.0242 ns | 20.956 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.631 ns | 0.0081 ns | 0.0072 ns | 11.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.157 ns | 0.0223 ns | 0.0186 ns | 10.156 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.163 ns | 0.0106 ns | 0.0099 ns |  7.162 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.822 ns | 0.0085 ns | 0.0075 ns | 11.821 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.306 ns | 0.0584 ns | 0.0518 ns | 10.309 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.064 ns | 0.0343 ns | 0.0321 ns | 14.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.989 ns | 0.0175 ns | 0.0155 ns | 13.988 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.179 ns | 0.1179 ns | 0.1103 ns | 12.243 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.939 ns | 0.0186 ns | 0.0156 ns | 14.936 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.346 ns | 0.0135 ns | 0.0120 ns | 15.349 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.517 ns | 0.0198 ns | 0.0185 ns | 12.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.577 ns | 0.0164 ns | 0.0145 ns | 10.577 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.926 ns | 0.0373 ns | 0.0349 ns |  7.929 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.318 ns | 0.0771 ns | 0.0722 ns | 13.355 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.336 ns | 0.0106 ns | 0.0094 ns | 11.336 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.021 ns | 0.0474 ns | 0.0443 ns | 19.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.863 ns | 0.0185 ns | 0.0155 ns | 15.861 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.977 ns | 0.0243 ns | 0.0227 ns | 15.983 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 21.910 ns | 0.0690 ns | 0.0645 ns | 21.885 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 21.634 ns | 0.0261 ns | 0.0245 ns | 21.632 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.532 ns | 0.0153 ns | 0.0143 ns | 12.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.639 ns | 0.0191 ns | 0.0169 ns | 11.640 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.219 ns | 0.1624 ns | 0.1519 ns |  8.321 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.024 ns | 0.0306 ns | 0.0271 ns | 14.022 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.012 ns | 0.0177 ns | 0.0148 ns | 12.006 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.010 ns | 0.0346 ns | 0.0324 ns | 19.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.653 ns | 0.0340 ns | 0.0301 ns | 15.643 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.502 ns | 0.1423 ns | 0.1331 ns | 16.438 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.489 ns | 0.0274 ns | 0.0257 ns | 19.493 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.675 ns | 0.1165 ns | 0.1089 ns | 21.668 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.709 ns | 0.0140 ns | 0.0117 ns | 11.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.063 ns | 0.0180 ns | 0.0151 ns | 10.061 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.246 ns | 0.0111 ns | 0.0098 ns |  7.243 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.514 ns | 0.0182 ns | 0.0170 ns | 12.513 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.672 ns | 0.0144 ns | 0.0128 ns | 11.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.782 ns | 0.0261 ns | 0.0244 ns | 14.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.641 ns | 0.0196 ns | 0.0164 ns | 12.634 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.155 ns | 0.2960 ns | 0.3409 ns | 13.937 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.341 ns | 0.0123 ns | 0.0103 ns | 13.339 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 15.914 ns | 0.0213 ns | 0.0189 ns | 15.919 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.444 ns | 0.0215 ns | 0.0168 ns | 13.445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.254 ns | 0.0072 ns | 0.0056 ns | 10.253 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.568 ns | 0.0238 ns | 0.0223 ns |  7.575 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.109 ns | 0.0110 ns | 0.0098 ns | 13.109 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.983 ns | 0.0229 ns | 0.0214 ns | 10.977 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.600 ns | 0.0310 ns | 0.0275 ns | 18.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.690 ns | 0.0324 ns | 0.0303 ns | 15.682 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.098 ns | 0.0984 ns | 0.0921 ns | 16.095 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.219 ns | 0.0185 ns | 0.0173 ns | 19.213 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.536 ns | 0.0234 ns | 0.0207 ns | 20.531 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.603 ns | 0.0175 ns | 0.0137 ns | 13.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.517 ns | 0.0107 ns | 0.0100 ns | 13.517 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.342 ns | 0.0164 ns | 0.0154 ns | 10.335 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.177 ns | 0.0410 ns | 0.0384 ns | 15.160 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.781 ns | 0.0243 ns | 0.0227 ns | 13.775 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.990 ns | 0.0238 ns | 0.0211 ns | 18.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.817 ns | 0.0876 ns | 0.0819 ns | 16.783 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.044 ns | 0.1094 ns | 0.1024 ns | 15.995 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.426 ns | 0.0255 ns | 0.0226 ns | 19.429 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 21.460 ns | 0.1106 ns | 0.1034 ns | 21.430 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.055 ns | 0.0102 ns | 0.0096 ns | 13.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.306 ns | 0.0622 ns | 0.0582 ns | 11.272 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.044 ns | 0.0161 ns | 0.0135 ns |  8.040 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.035 ns | 0.0789 ns | 0.0738 ns | 13.999 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.261 ns | 0.0144 ns | 0.0121 ns | 13.260 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.162 ns | 0.0176 ns | 0.0156 ns | 14.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.839 ns | 0.0106 ns | 0.0094 ns | 11.836 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.993 ns | 0.0789 ns | 0.0738 ns | 12.006 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.457 ns | 0.0144 ns | 0.0135 ns | 13.457 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.900 ns | 0.0170 ns | 0.0142 ns | 14.898 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.253 ns | 0.0401 ns | 0.0355 ns | 12.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.170 ns | 0.0109 ns | 0.0091 ns | 10.170 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.899 ns | 0.0066 ns | 0.0058 ns |  6.898 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.733 ns | 0.0875 ns | 0.0776 ns | 13.722 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.957 ns | 0.0136 ns | 0.0120 ns | 12.960 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.128 ns | 0.0365 ns | 0.0323 ns | 18.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.035 ns | 0.0435 ns | 0.0340 ns | 15.046 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.089 ns | 0.0650 ns | 0.0577 ns | 15.073 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 21.530 ns | 0.0589 ns | 0.0522 ns | 21.542 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.637 ns | 0.0835 ns | 0.0781 ns | 20.647 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.823 ns | 0.0356 ns | 0.0316 ns | 11.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.381 ns | 0.0205 ns | 0.0181 ns | 10.380 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.623 ns | 0.1949 ns | 0.3465 ns |  8.738 ns |  0.71 |    0.04 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.613 ns | 0.0181 ns | 0.0169 ns | 13.610 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.174 ns | 0.0290 ns | 0.0257 ns | 12.166 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.102 ns | 0.0268 ns | 0.0250 ns | 18.112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.168 ns | 0.0304 ns | 0.0237 ns | 15.170 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.151 ns | 0.1296 ns | 0.1213 ns | 15.093 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.201 ns | 0.0165 ns | 0.0138 ns | 19.202 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.511 ns | 0.0255 ns | 0.0239 ns | 20.514 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.645 ns | 0.0112 ns | 0.0100 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.156 ns | 0.0142 ns | 0.0133 ns | 10.160 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.924 ns | 0.2032 ns | 0.5171 ns |  9.072 ns |  0.71 |    0.08 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.850 ns | 0.0174 ns | 0.0145 ns | 11.848 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.259 ns | 0.0133 ns | 0.0118 ns | 10.260 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.939 ns | 0.0230 ns | 0.0215 ns | 14.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.632 ns | 0.0186 ns | 0.0156 ns | 12.633 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.912 ns | 0.0136 ns | 0.0121 ns | 11.914 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.292 ns | 0.0703 ns | 0.0658 ns | 13.317 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.891 ns | 0.0236 ns | 0.0221 ns | 14.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.695 ns | 0.0250 ns | 0.0222 ns | 13.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.105 ns | 0.0089 ns | 0.0083 ns | 12.108 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.910 ns | 0.0184 ns | 0.0172 ns |  9.910 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.458 ns | 0.0370 ns | 0.0346 ns | 16.462 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.352 ns | 0.0577 ns | 0.0539 ns | 14.363 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.846 ns | 0.0312 ns | 0.0276 ns | 20.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.274 ns | 0.0291 ns | 0.0258 ns | 17.276 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.769 ns | 0.2313 ns | 0.2164 ns | 18.671 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 22.333 ns | 0.0556 ns | 0.0464 ns | 22.316 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.887 ns | 0.0590 ns | 0.0552 ns | 23.874 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.160 ns | 0.0276 ns | 0.0258 ns | 14.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.880 ns | 0.0173 ns | 0.0153 ns | 12.872 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 11.193 ns | 0.0087 ns | 0.0077 ns | 11.192 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.521 ns | 0.0179 ns | 0.0159 ns | 15.521 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.285 ns | 0.0174 ns | 0.0154 ns | 13.282 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.340 ns | 0.0586 ns | 0.0549 ns | 21.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.765 ns | 0.0200 ns | 0.0167 ns | 17.765 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.068 ns | 0.0533 ns | 0.0498 ns | 18.056 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 22.292 ns | 0.0317 ns | 0.0281 ns | 22.288 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.899 ns | 0.0246 ns | 0.0231 ns | 23.888 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.897 ns | 0.0094 ns | 0.0073 ns | 12.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.119 ns | 0.0160 ns | 0.0134 ns | 10.117 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.224 ns | 0.0202 ns | 0.0179 ns |  7.227 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.007 ns | 0.0162 ns | 0.0152 ns | 12.007 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.317 ns | 0.0132 ns | 0.0117 ns | 10.315 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.051 ns | 0.0384 ns | 0.0340 ns | 14.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.846 ns | 0.0127 ns | 0.0119 ns | 11.841 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.946 ns | 0.0345 ns | 0.0305 ns | 11.949 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.202 ns | 0.0171 ns | 0.0160 ns | 13.203 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.671 ns | 0.0175 ns | 0.0146 ns | 15.669 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.625 ns | 0.0511 ns | 0.0453 ns | 58.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.217 ns | 0.0493 ns | 0.0461 ns | 50.212 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.001 ns | 0.2566 ns | 0.2401 ns | 20.104 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.831 ns | 0.2934 ns | 0.2601 ns | 59.939 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 61.231 ns | 0.0774 ns | 0.0686 ns | 61.222 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.069 ns | 0.0791 ns | 0.0740 ns | 64.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.186 ns | 0.0557 ns | 0.0494 ns | 59.195 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 22.423 ns | 0.0885 ns | 0.0785 ns | 22.394 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.719 ns | 0.0915 ns | 0.0764 ns | 63.708 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 67.461 ns | 0.2821 ns | 0.2501 ns | 67.511 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 15.434 ns | 0.0237 ns | 0.0210 ns | 15.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.378 ns | 0.0136 ns | 0.0121 ns | 11.373 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 10.986 ns | 0.0131 ns | 0.0116 ns | 10.986 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.720 ns | 0.0140 ns | 0.0124 ns | 12.720 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.039 ns | 0.0214 ns | 0.0200 ns | 15.033 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 16.326 ns | 0.0197 ns | 0.0164 ns | 16.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.859 ns | 0.0132 ns | 0.0124 ns | 11.859 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.189 ns | 0.1467 ns | 0.1372 ns | 13.248 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.320 ns | 0.0314 ns | 0.0294 ns | 13.323 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 14.903 ns | 0.0207 ns | 0.0173 ns | 14.897 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.675 ns | 0.0136 ns | 0.0127 ns | 13.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.396 ns | 0.0279 ns | 0.0261 ns | 11.389 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.324 ns | 0.1155 ns | 0.1081 ns | 12.254 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.746 ns | 0.0333 ns | 0.0295 ns | 12.751 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.016 ns | 0.0272 ns | 0.0254 ns | 16.004 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.554 ns | 0.0544 ns | 0.0509 ns | 11.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  9.968 ns | 0.0171 ns | 0.0160 ns |  9.963 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.635 ns | 0.0112 ns | 0.0105 ns |  6.635 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.323 ns | 0.0183 ns | 0.0171 ns | 10.323 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.883 ns | 0.0635 ns | 0.0594 ns | 11.871 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 16.512 ns | 0.0184 ns | 0.0163 ns | 16.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 12.464 ns | 0.0210 ns | 0.0197 ns | 12.456 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 12.528 ns | 0.0324 ns | 0.0303 ns | 12.521 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 15.016 ns | 0.0394 ns | 0.0349 ns | 15.013 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 15.752 ns | 0.0337 ns | 0.0316 ns | 15.744 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.747 ns | 0.0162 ns | 0.0144 ns | 11.746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.532 ns | 0.0128 ns | 0.0113 ns | 11.533 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.158 ns | 0.0164 ns | 0.0153 ns |  7.157 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.253 ns | 0.0180 ns | 0.0160 ns | 12.251 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.507 ns | 0.0211 ns | 0.0197 ns | 10.504 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.627 ns | 0.0145 ns | 0.0129 ns | 14.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.488 ns | 0.0262 ns | 0.0232 ns | 12.477 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.920 ns | 0.2800 ns | 0.3833 ns | 13.166 ns |  0.87 |    0.03 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 14.424 ns | 0.0436 ns | 0.0408 ns | 14.429 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 15.738 ns | 0.0422 ns | 0.0395 ns | 15.740 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.580 ns | 0.0121 ns | 0.0107 ns | 11.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  9.969 ns | 0.0106 ns | 0.0099 ns |  9.968 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.943 ns | 0.0178 ns | 0.0167 ns |  6.940 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.386 ns | 0.0093 ns | 0.0087 ns | 10.383 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.904 ns | 0.0792 ns | 0.0740 ns | 11.889 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.899 ns | 0.0175 ns | 0.0164 ns | 14.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.954 ns | 0.0597 ns | 0.0498 ns | 11.972 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.006 ns | 0.0903 ns | 0.0800 ns | 11.970 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 14.158 ns | 0.0186 ns | 0.0174 ns | 14.154 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.485 ns | 0.0211 ns | 0.0187 ns | 15.487 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.524 ns | 0.0134 ns | 0.0105 ns | 12.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.152 ns | 0.0194 ns | 0.0181 ns | 10.152 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.919 ns | 0.0186 ns | 0.0165 ns |  6.918 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.448 ns | 0.0565 ns | 0.0501 ns | 12.465 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.820 ns | 0.0130 ns | 0.0115 ns | 10.822 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.144 ns | 0.0307 ns | 0.0287 ns | 18.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 14.994 ns | 0.0237 ns | 0.0210 ns | 14.999 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.433 ns | 0.1799 ns | 0.1683 ns | 17.514 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.462 ns | 0.0375 ns | 0.0350 ns | 19.457 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.897 ns | 0.0921 ns | 0.0862 ns | 20.920 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.382 ns | 0.0133 ns | 0.0124 ns | 12.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.378 ns | 0.0156 ns | 0.0146 ns | 10.377 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.408 ns | 0.0116 ns | 0.0108 ns |  7.411 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 14.028 ns | 0.0480 ns | 0.0401 ns | 14.021 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.306 ns | 0.0183 ns | 0.0171 ns | 13.304 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.285 ns | 0.1209 ns | 0.1131 ns | 18.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.192 ns | 0.0271 ns | 0.0241 ns | 15.189 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.292 ns | 0.0406 ns | 0.0360 ns | 15.289 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 19.403 ns | 0.0229 ns | 0.0191 ns | 19.406 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.747 ns | 0.0194 ns | 0.0172 ns | 20.745 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.644 ns | 0.0104 ns | 0.0097 ns | 11.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.148 ns | 0.0126 ns | 0.0112 ns | 10.145 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.797 ns | 0.1819 ns | 0.3089 ns |  7.953 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.505 ns | 0.0169 ns | 0.0158 ns | 12.508 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.264 ns | 0.0144 ns | 0.0128 ns | 10.267 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.046 ns | 0.0087 ns | 0.0072 ns | 14.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.773 ns | 0.0192 ns | 0.0179 ns | 13.777 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.054 ns | 0.1004 ns | 0.0939 ns | 12.109 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.308 ns | 0.0603 ns | 0.0564 ns | 13.323 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 14.893 ns | 0.0151 ns | 0.0126 ns | 14.894 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.450 ns | 0.0165 ns | 0.0138 ns | 12.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.328 ns | 0.0112 ns | 0.0099 ns | 10.329 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.768 ns | 0.0088 ns | 0.0082 ns |  7.766 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.940 ns | 0.0124 ns | 0.0116 ns | 12.937 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.769 ns | 0.0139 ns | 0.0108 ns | 10.765 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.630 ns | 0.2678 ns | 0.2505 ns | 18.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.601 ns | 0.0426 ns | 0.0377 ns | 15.612 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.013 ns | 0.0293 ns | 0.0260 ns | 16.010 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 22.176 ns | 0.0240 ns | 0.0224 ns | 22.168 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 20.546 ns | 0.0307 ns | 0.0287 ns | 20.543 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.526 ns | 0.0652 ns | 0.0610 ns | 13.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.608 ns | 0.0162 ns | 0.0151 ns | 12.606 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.381 ns | 0.0142 ns | 0.0126 ns | 10.382 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.492 ns | 0.0190 ns | 0.0169 ns | 14.492 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.783 ns | 0.0196 ns | 0.0164 ns | 13.784 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.239 ns | 0.0154 ns | 0.0144 ns | 19.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.507 ns | 0.0329 ns | 0.0308 ns | 15.507 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.287 ns | 0.0628 ns | 0.0556 ns | 18.291 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.256 ns | 0.0347 ns | 0.0271 ns | 19.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 20.647 ns | 0.0999 ns | 0.0934 ns | 20.611 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.503 ns | 0.0142 ns | 0.0126 ns | 12.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.345 ns | 0.0761 ns | 0.0712 ns | 11.298 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.060 ns | 0.0085 ns | 0.0075 ns |  8.059 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.412 ns | 0.0107 ns | 0.0095 ns | 13.411 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.415 ns | 0.0270 ns | 0.0240 ns | 13.407 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.981 ns | 0.0306 ns | 0.0286 ns | 14.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.654 ns | 0.0112 ns | 0.0099 ns | 12.655 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.562 ns | 0.0823 ns | 0.0770 ns | 13.586 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.935 ns | 0.0181 ns | 0.0161 ns | 13.933 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.830 ns | 0.0191 ns | 0.0169 ns | 15.833 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.770 ns | 0.0175 ns | 0.0155 ns | 14.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.907 ns | 0.0712 ns | 0.0666 ns | 11.870 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.017 ns | 0.1167 ns | 0.1091 ns | 13.075 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.220 ns | 0.0226 ns | 0.0211 ns | 13.213 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 14.884 ns | 0.0150 ns | 0.0133 ns | 14.883 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.774 ns | 0.0084 ns | 0.0066 ns | 11.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.023 ns | 0.0110 ns | 0.0097 ns |  9.023 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.107 ns | 0.2613 ns | 0.3663 ns | 12.160 ns |  1.03 |    0.04 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.091 ns | 0.0137 ns | 0.0128 ns | 11.096 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.689 ns | 0.0122 ns | 0.0114 ns | 12.691 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.902 ns | 0.0143 ns | 0.0134 ns | 14.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.869 ns | 0.0341 ns | 0.0302 ns | 11.858 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.948 ns | 0.0141 ns | 0.0132 ns | 11.944 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.240 ns | 0.0557 ns | 0.0521 ns | 13.224 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.042 ns | 0.0697 ns | 0.0618 ns | 15.069 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 14.896 ns | 0.0222 ns | 0.0208 ns | 14.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.155 ns | 0.0229 ns | 0.0214 ns | 14.153 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.834 ns | 0.0198 ns | 0.0185 ns | 12.838 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.706 ns | 0.0399 ns | 0.0373 ns | 16.701 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.775 ns | 0.0286 ns | 0.0268 ns | 16.775 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.611 ns | 0.0894 ns | 0.0836 ns | 16.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.161 ns | 0.0205 ns | 0.0192 ns | 14.155 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.445 ns | 0.0578 ns | 0.0452 ns | 14.437 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.558 ns | 0.0413 ns | 0.0367 ns | 16.546 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.587 ns | 0.0349 ns | 0.0326 ns | 18.587 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.892 ns | 0.0514 ns | 0.0481 ns | 13.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.581 ns | 0.0760 ns | 0.0711 ns | 13.534 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.633 ns | 0.2595 ns | 0.3090 ns | 11.798 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.108 ns | 0.0171 ns | 0.0151 ns | 13.107 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.158 ns | 0.0311 ns | 0.0291 ns | 13.143 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.929 ns | 0.0172 ns | 0.0161 ns | 14.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.161 ns | 0.0133 ns | 0.0118 ns | 14.162 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.039 ns | 0.0528 ns | 0.0494 ns | 12.025 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.799 ns | 0.0211 ns | 0.0187 ns | 13.798 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.948 ns | 0.0166 ns | 0.0155 ns | 14.949 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 11.917 ns | 0.0162 ns | 0.0143 ns | 11.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.125 ns | 0.0134 ns | 0.0125 ns | 11.127 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.725 ns | 0.2543 ns | 0.2929 ns | 11.908 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.298 ns | 0.0314 ns | 0.0293 ns | 12.286 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.525 ns | 0.0121 ns | 0.0101 ns | 12.521 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 14.976 ns | 0.0441 ns | 0.0391 ns | 14.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.382 ns | 0.0157 ns | 0.0139 ns | 13.384 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.607 ns | 0.0284 ns | 0.0252 ns | 13.607 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.293 ns | 0.0789 ns | 0.0738 ns | 17.310 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.038 ns | 0.0235 ns | 0.0209 ns | 24.037 ns |  1.61 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.888 ns | 0.0659 ns | 0.0616 ns | 11.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.460 ns | 0.0083 ns | 0.0073 ns | 11.460 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.197 ns | 0.2692 ns | 0.4347 ns | 12.389 ns |  1.01 |    0.05 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.498 ns | 0.0101 ns | 0.0085 ns | 12.499 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.745 ns | 0.0153 ns | 0.0136 ns | 12.743 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.108 ns | 0.0232 ns | 0.0217 ns | 14.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.585 ns | 0.0822 ns | 0.0769 ns | 13.544 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.932 ns | 0.0166 ns | 0.0156 ns | 11.931 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.230 ns | 0.0224 ns | 0.0199 ns | 13.228 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.972 ns | 0.0962 ns | 0.0900 ns | 14.946 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.931 ns | 0.0810 ns | 0.0718 ns | 18.910 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.875 ns | 0.0386 ns | 0.0361 ns | 15.866 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.548 ns | 0.0293 ns | 0.0274 ns | 13.541 ns |  0.72 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.531 ns | 0.0440 ns | 0.0390 ns | 18.522 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.345 ns | 0.0234 ns | 0.0219 ns | 17.341 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.966 ns | 0.0260 ns | 0.0230 ns | 17.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.501 ns | 0.0126 ns | 0.0112 ns | 14.499 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.440 ns | 0.1027 ns | 0.0961 ns | 15.484 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.686 ns | 0.0392 ns | 0.0367 ns | 19.692 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.997 ns | 0.0313 ns | 0.0293 ns | 19.990 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.270 ns | 0.1027 ns | 0.0961 ns | 19.278 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.016 ns | 0.0305 ns | 0.0285 ns | 16.018 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.521 ns | 0.0451 ns | 0.0400 ns | 12.518 ns |  0.65 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.642 ns | 0.1173 ns | 0.1097 ns | 19.640 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.779 ns | 0.0531 ns | 0.0496 ns | 17.788 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.013 ns | 0.0398 ns | 0.0372 ns | 17.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.134 ns | 0.0260 ns | 0.0230 ns | 15.127 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.313 ns | 0.0254 ns | 0.0225 ns | 15.319 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.229 ns | 0.0138 ns | 0.0123 ns | 17.228 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.336 ns | 0.0430 ns | 0.0382 ns | 19.337 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.123 ns | 0.0152 ns | 0.0142 ns | 13.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.599 ns | 0.0087 ns | 0.0077 ns | 11.599 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.046 ns | 0.0069 ns | 0.0061 ns |  7.046 ns |  0.54 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.596 ns | 0.0161 ns | 0.0143 ns | 12.594 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.515 ns | 0.0470 ns | 0.0440 ns | 10.495 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.951 ns | 0.0144 ns | 0.0127 ns | 14.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.881 ns | 0.0314 ns | 0.0294 ns | 11.872 ns |  0.79 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.076 ns | 0.0402 ns | 0.0376 ns | 12.056 ns |  0.81 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.246 ns | 0.0319 ns | 0.0299 ns | 13.235 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.876 ns | 0.0227 ns | 0.0212 ns | 15.879 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.931 ns | 0.0131 ns | 0.0122 ns | 12.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.026 ns | 0.0146 ns | 0.0129 ns | 10.029 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.607 ns | 0.0086 ns | 0.0076 ns |  6.604 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.479 ns | 0.0222 ns | 0.0197 ns | 12.471 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.281 ns | 0.0057 ns | 0.0045 ns | 10.281 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 15.249 ns | 0.1012 ns | 0.0897 ns | 15.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.329 ns | 0.0681 ns | 0.0637 ns | 13.297 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.629 ns | 0.0279 ns | 0.0247 ns | 13.634 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.086 ns | 0.0736 ns | 0.0688 ns | 15.106 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.340 ns | 0.0273 ns | 0.0242 ns | 17.344 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 12.933 ns | 0.0131 ns | 0.0116 ns | 12.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.358 ns | 0.0104 ns | 0.0093 ns | 11.357 ns |  0.88 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.312 ns | 0.0096 ns | 0.0080 ns |  6.309 ns |  0.49 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.789 ns | 0.0116 ns | 0.0108 ns | 11.791 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.299 ns | 0.0143 ns | 0.0127 ns | 10.298 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.088 ns | 0.0963 ns | 0.0901 ns | 15.098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.476 ns | 0.0292 ns | 0.0273 ns | 13.467 ns |  0.89 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.720 ns | 0.2112 ns | 0.1976 ns | 13.591 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.991 ns | 0.0309 ns | 0.0289 ns | 14.991 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.794 ns | 0.0773 ns | 0.0723 ns | 16.820 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.840 ns | 0.0139 ns | 0.0130 ns | 12.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.024 ns | 0.0173 ns | 0.0154 ns | 10.022 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.682 ns | 0.1807 ns | 0.2219 ns |  7.761 ns |  0.59 |    0.02 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.791 ns | 0.0133 ns | 0.0118 ns | 11.791 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.286 ns | 0.0052 ns | 0.0046 ns | 10.287 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.049 ns | 0.0136 ns | 0.0120 ns | 14.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.933 ns | 0.0820 ns | 0.0767 ns | 11.876 ns |  0.85 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.333 ns | 0.0844 ns | 0.0789 ns | 11.294 ns |  0.81 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.827 ns | 0.0714 ns | 0.0668 ns | 15.801 ns |  1.13 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.903 ns | 0.0192 ns | 0.0170 ns | 15.901 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.542 ns | 0.0117 ns | 0.0104 ns | 13.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.539 ns | 0.0162 ns | 0.0151 ns | 10.536 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.574 ns | 0.0171 ns | 0.0152 ns |  7.576 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.167 ns | 0.0129 ns | 0.0115 ns | 13.166 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.926 ns | 0.0148 ns | 0.0124 ns | 10.930 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.564 ns | 0.0457 ns | 0.0405 ns | 46.560 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 41.763 ns | 0.0872 ns | 0.0773 ns | 41.758 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.014 ns | 0.8035 ns | 1.2027 ns | 39.795 ns |  0.82 |    0.03 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.431 ns | 0.0682 ns | 0.0638 ns | 43.445 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 45.474 ns | 0.0636 ns | 0.0595 ns | 45.478 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.083 ns | 0.0294 ns | 0.0275 ns | 14.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.084 ns | 0.0157 ns | 0.0131 ns | 13.085 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.861 ns | 0.0139 ns | 0.0123 ns |  8.862 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.457 ns | 0.0139 ns | 0.0130 ns | 13.457 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.185 ns | 0.0378 ns | 0.0353 ns | 12.168 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.847 ns | 0.0754 ns | 0.0705 ns | 45.834 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.019 ns | 0.0796 ns | 0.0706 ns | 42.014 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 35.794 ns | 0.4258 ns | 0.3556 ns | 35.961 ns |  0.78 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 44.951 ns | 0.0826 ns | 0.0732 ns | 44.961 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 47.659 ns | 0.0388 ns | 0.0344 ns | 47.669 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.123 ns | 0.0197 ns | 0.0174 ns | 13.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.737 ns | 0.0161 ns | 0.0151 ns | 11.740 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.843 ns | 0.0094 ns | 0.0083 ns |  6.843 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.558 ns | 0.0860 ns | 0.0805 ns | 12.506 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.393 ns | 0.0113 ns | 0.0106 ns | 10.393 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.890 ns | 0.0128 ns | 0.0107 ns | 14.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.861 ns | 0.0156 ns | 0.0146 ns | 11.856 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.927 ns | 0.0136 ns | 0.0127 ns | 11.925 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.365 ns | 0.0335 ns | 0.0280 ns | 13.366 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 16.011 ns | 0.0251 ns | 0.0210 ns | 16.020 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.019 ns | 0.0212 ns | 0.0198 ns | 12.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.227 ns | 0.0128 ns | 0.0120 ns | 11.228 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.253 ns | 0.0133 ns | 0.0125 ns | 11.254 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.742 ns | 0.0114 ns | 0.0101 ns | 12.742 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.578 ns | 0.0235 ns | 0.0220 ns | 12.576 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.429 ns | 0.0179 ns | 0.0159 ns | 15.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.286 ns | 0.0175 ns | 0.0164 ns | 14.288 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.148 ns | 0.3059 ns | 0.3004 ns | 13.957 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.265 ns | 0.0378 ns | 0.0335 ns | 15.262 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 16.900 ns | 0.0327 ns | 0.0306 ns | 16.913 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.330 ns | 0.0373 ns | 0.0349 ns | 13.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.100 ns | 0.0078 ns | 0.0066 ns | 11.101 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.313 ns | 0.0276 ns | 0.0258 ns | 11.311 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.319 ns | 0.0137 ns | 0.0128 ns | 12.318 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.495 ns | 0.0097 ns | 0.0091 ns | 12.497 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.309 ns | 0.0175 ns | 0.0155 ns | 15.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.637 ns | 0.0177 ns | 0.0157 ns | 12.638 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.940 ns | 0.0157 ns | 0.0140 ns | 11.941 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.194 ns | 0.0145 ns | 0.0128 ns | 13.191 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.899 ns | 0.0155 ns | 0.0129 ns | 14.903 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.505 ns | 0.0580 ns | 0.0543 ns | 38.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.196 ns | 0.0447 ns | 0.0396 ns | 36.203 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.936 ns | 0.0431 ns | 0.0360 ns | 36.936 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.823 ns | 0.1198 ns | 0.1062 ns | 38.813 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 37.825 ns | 0.0373 ns | 0.0349 ns | 37.830 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.445 ns | 0.0164 ns | 0.0137 ns | 15.447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.690 ns | 0.0353 ns | 0.0313 ns | 13.691 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.210 ns | 0.0679 ns | 0.0635 ns | 13.226 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.433 ns | 0.0338 ns | 0.0316 ns | 15.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.132 ns | 0.0279 ns | 0.0261 ns | 17.126 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.221 ns | 0.2029 ns | 0.1897 ns | 39.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.725 ns | 0.0608 ns | 0.0539 ns | 36.714 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.053 ns | 0.1648 ns | 0.1541 ns | 34.042 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.261 ns | 0.1439 ns | 0.1346 ns | 39.223 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.178 ns | 0.1647 ns | 0.1541 ns | 38.221 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.809 ns | 0.0185 ns | 0.0145 ns | 15.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.182 ns | 0.0282 ns | 0.0250 ns | 15.177 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.789 ns | 0.9727 ns | 1.7541 ns | 13.813 ns |  1.09 |    0.10 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.277 ns | 0.0375 ns | 0.0332 ns | 15.289 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.661 ns | 0.0217 ns | 0.0181 ns | 17.660 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.214 ns | 0.0517 ns | 0.0458 ns | 39.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.756 ns | 0.0650 ns | 0.0576 ns | 38.746 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.406 ns | 0.2564 ns | 0.2273 ns | 34.441 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.303 ns | 0.1126 ns | 0.0998 ns | 39.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 37.968 ns | 0.0533 ns | 0.0472 ns | 37.968 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.189 ns | 0.0467 ns | 0.0437 ns | 14.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.848 ns | 0.0113 ns | 0.0100 ns | 11.849 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.461 ns | 0.2160 ns | 0.2020 ns | 11.304 ns |  0.81 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.294 ns | 0.0287 ns | 0.0268 ns | 13.295 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 14.907 ns | 0.0310 ns | 0.0259 ns | 14.905 ns |  1.05 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShort.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UShort.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
