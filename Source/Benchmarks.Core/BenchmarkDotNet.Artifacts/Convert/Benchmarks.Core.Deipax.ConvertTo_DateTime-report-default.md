
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XBZJXS : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-RPHYXP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-WPBXUQ : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-EJFWSE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-ZVTGBZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


                                                Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------------------------------ |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
                                             From_Bool | .NET Core 2.0 |  12.720 ns | 0.0160 ns | 0.0150 ns |  12.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 |  11.579 ns | 0.0138 ns | 0.0130 ns |  11.582 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |   8.469 ns | 0.1920 ns | 0.3653 ns |   8.549 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                                             From_Bool |        net461 |  12.699 ns | 0.0747 ns | 0.0699 ns |  12.732 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 |  11.763 ns | 0.0116 ns | 0.0103 ns |  11.760 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 |  11.264 ns | 0.0159 ns | 0.0149 ns |  11.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 |  10.315 ns | 0.0388 ns | 0.0363 ns |  10.323 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |   7.108 ns | 0.0101 ns | 0.0089 ns |   7.107 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 |  11.825 ns | 0.0146 ns | 0.0129 ns |  11.828 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 |  12.872 ns | 0.0189 ns | 0.0177 ns |  12.868 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 |  11.411 ns | 0.0128 ns | 0.0114 ns |  11.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  10.239 ns | 0.0644 ns | 0.0602 ns |  10.272 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |   7.101 ns | 0.0076 ns | 0.0067 ns |   7.103 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 |  11.844 ns | 0.0083 ns | 0.0078 ns |  11.844 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 |  11.775 ns | 0.0120 ns | 0.0112 ns |  11.776 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.299 ns | 0.0132 ns | 0.0117 ns |  14.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.081 ns | 0.0173 ns | 0.0161 ns |  13.077 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.476 ns | 0.0141 ns | 0.0125 ns |  12.475 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 |  14.951 ns | 0.0172 ns | 0.0161 ns |  14.947 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 |  15.277 ns | 0.0479 ns | 0.0425 ns |  15.269 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 |  12.011 ns | 0.0146 ns | 0.0137 ns |  12.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  10.228 ns | 0.0764 ns | 0.0714 ns |  10.271 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |   6.850 ns | 0.0113 ns | 0.0106 ns |   6.851 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 |  11.821 ns | 0.0141 ns | 0.0125 ns |  11.824 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 |  11.777 ns | 0.0132 ns | 0.0123 ns |  11.774 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 |  11.955 ns | 0.0127 ns | 0.0119 ns |  11.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 |  10.189 ns | 0.0145 ns | 0.0135 ns |  10.193 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |   6.912 ns | 0.0174 ns | 0.0163 ns |   6.914 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 |  12.073 ns | 0.0088 ns | 0.0082 ns |  12.076 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 |  11.867 ns | 0.0672 ns | 0.0595 ns |  11.887 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 |  11.372 ns | 0.0328 ns | 0.0274 ns |  11.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  11.370 ns | 0.0843 ns | 0.0788 ns |  11.383 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |   7.025 ns | 0.1633 ns | 0.2124 ns |   6.897 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 |  12.756 ns | 0.0820 ns | 0.0767 ns |  12.717 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 |  11.776 ns | 0.0113 ns | 0.0101 ns |  11.776 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.388 ns | 0.0196 ns | 0.0183 ns |  13.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.088 ns | 0.0160 ns | 0.0142 ns |  13.087 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.514 ns | 0.0492 ns | 0.0460 ns |  12.496 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 |  16.210 ns | 0.0129 ns | 0.0120 ns |  16.206 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 |  15.237 ns | 0.0160 ns | 0.0141 ns |  15.234 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 |  11.292 ns | 0.0124 ns | 0.0116 ns |  11.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  11.706 ns | 0.0340 ns | 0.0318 ns |  11.714 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |   6.899 ns | 0.0222 ns | 0.0207 ns |   6.900 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 |  11.830 ns | 0.0134 ns | 0.0119 ns |  11.832 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 |  11.862 ns | 0.0150 ns | 0.0140 ns |  11.863 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 |  12.690 ns | 0.0104 ns | 0.0098 ns |  12.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 |  10.189 ns | 0.0122 ns | 0.0114 ns |  10.192 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |   6.611 ns | 0.0127 ns | 0.0112 ns |   6.608 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 |  11.833 ns | 0.0120 ns | 0.0113 ns |  11.835 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 |  11.797 ns | 0.0133 ns | 0.0118 ns |  11.794 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 |  11.287 ns | 0.0129 ns | 0.0121 ns |  11.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  10.198 ns | 0.0108 ns | 0.0101 ns |  10.198 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |   7.107 ns | 0.0181 ns | 0.0151 ns |   7.107 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 |  13.190 ns | 0.0084 ns | 0.0075 ns |  13.190 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 |  12.623 ns | 0.0137 ns | 0.0128 ns |  12.622 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.262 ns | 0.0117 ns | 0.0110 ns |  14.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.357 ns | 0.0582 ns | 0.0545 ns |  12.332 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.553 ns | 0.2856 ns | 0.3507 ns |  13.341 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 |  16.062 ns | 0.0198 ns | 0.0176 ns |  16.060 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 |  15.378 ns | 0.0399 ns | 0.0373 ns |  15.384 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 |  12.920 ns | 0.0186 ns | 0.0174 ns |  12.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 |  10.990 ns | 0.0135 ns | 0.0127 ns |  10.990 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |   8.136 ns | 0.0101 ns | 0.0094 ns |   8.133 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 |  12.831 ns | 0.0157 ns | 0.0147 ns |  12.833 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 |  12.454 ns | 0.0129 ns | 0.0121 ns |  12.451 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |  13.751 ns | 0.0084 ns | 0.0070 ns |  13.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |  13.218 ns | 0.0211 ns | 0.0176 ns |  13.211 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |  14.021 ns | 0.5798 ns | 0.8499 ns |  13.571 ns |  1.06 |    0.07 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |  15.882 ns | 0.0175 ns | 0.0163 ns |  15.879 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |  16.157 ns | 0.0229 ns | 0.0214 ns |  16.150 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 |  12.456 ns | 0.0156 ns | 0.0139 ns |  12.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 |  11.756 ns | 0.0269 ns | 0.0252 ns |  11.758 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |   8.651 ns | 0.0724 ns | 0.0677 ns |   8.608 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 |  15.341 ns | 0.1036 ns | 0.0969 ns |  15.388 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 |  13.732 ns | 0.0150 ns | 0.0140 ns |  13.729 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |  14.952 ns | 0.0131 ns | 0.0122 ns |  14.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |  13.731 ns | 0.0145 ns | 0.0136 ns |  13.728 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |  14.664 ns | 0.3125 ns | 0.3720 ns |  14.741 ns |  0.97 |    0.03 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |  16.585 ns | 0.0332 ns | 0.0310 ns |  16.587 ns |  1.11 |    0.00 |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |  14.089 ns | 0.0222 ns | 0.0185 ns |  14.086 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 |  12.460 ns | 0.0515 ns | 0.0482 ns |  12.474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 |  11.499 ns | 0.0681 ns | 0.0637 ns |  11.536 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |   9.574 ns | 0.2170 ns | 0.4762 ns |   9.773 ns |  0.72 |    0.05 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 |  13.335 ns | 0.0153 ns | 0.0136 ns |  13.337 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 |  14.120 ns | 0.0156 ns | 0.0146 ns |  14.117 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.390 ns | 0.0140 ns | 0.0125 ns |  13.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.096 ns | 0.0113 ns | 0.0100 ns |  13.097 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.452 ns | 0.0183 ns | 0.0172 ns |  13.449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 |  16.053 ns | 0.0210 ns | 0.0197 ns |  16.053 ns |  1.20 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 |  15.298 ns | 0.0137 ns | 0.0128 ns |  15.297 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 |  12.339 ns | 0.0176 ns | 0.0156 ns |  12.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 |  11.152 ns | 0.0416 ns | 0.0389 ns |  11.139 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 |   7.832 ns | 0.0108 ns | 0.0096 ns |   7.830 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 |  13.253 ns | 0.0230 ns | 0.0204 ns |  13.251 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 |  14.465 ns | 0.0168 ns | 0.0158 ns |  14.466 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 |  12.475 ns | 0.0129 ns | 0.0120 ns |  12.470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 |  11.085 ns | 0.0130 ns | 0.0115 ns |  11.085 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 |   8.045 ns | 0.0266 ns | 0.0249 ns |   8.049 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 |  13.135 ns | 0.0226 ns | 0.0211 ns |  13.130 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 |  13.074 ns | 0.0124 ns | 0.0097 ns |  13.075 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 |  12.472 ns | 0.0193 ns | 0.0171 ns |  12.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 |  11.557 ns | 0.0521 ns | 0.0487 ns |  11.573 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |   8.222 ns | 0.1909 ns | 0.2548 ns |   8.106 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 |  13.201 ns | 0.0592 ns | 0.0554 ns |  13.217 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 |  12.766 ns | 0.0194 ns | 0.0181 ns |  12.764 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.284 ns | 0.0170 ns | 0.0151 ns |  14.281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.092 ns | 0.0148 ns | 0.0131 ns |  13.094 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.004 ns | 0.0376 ns | 0.0352 ns |  12.997 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 |  14.899 ns | 0.0185 ns | 0.0173 ns |  14.892 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 |  16.204 ns | 0.1011 ns | 0.0946 ns |  16.243 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 |  11.997 ns | 0.0123 ns | 0.0115 ns |  12.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 |  10.462 ns | 0.1190 ns | 0.1114 ns |  10.385 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |   7.193 ns | 0.0116 ns | 0.0108 ns |   7.191 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 |  11.844 ns | 0.0098 ns | 0.0092 ns |  11.845 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 |  12.436 ns | 0.0104 ns | 0.0092 ns |  12.435 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 |  12.737 ns | 0.0113 ns | 0.0094 ns |  12.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 |  11.023 ns | 0.0115 ns | 0.0096 ns |  11.022 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |   7.836 ns | 0.0111 ns | 0.0098 ns |   7.834 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 |  15.476 ns | 0.0223 ns | 0.0198 ns |  15.480 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 |  12.896 ns | 0.0615 ns | 0.0575 ns |  12.900 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 |  12.326 ns | 0.0186 ns | 0.0165 ns |  12.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 |  11.004 ns | 0.0173 ns | 0.0162 ns |  11.005 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |   7.900 ns | 0.0088 ns | 0.0082 ns |   7.897 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 |  13.691 ns | 0.0080 ns | 0.0075 ns |  13.690 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 |  12.600 ns | 0.0117 ns | 0.0109 ns |  12.599 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.384 ns | 0.0149 ns | 0.0139 ns |  13.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.322 ns | 0.0096 ns | 0.0090 ns |  12.320 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.538 ns | 0.0387 ns | 0.0362 ns |  13.525 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 |  16.072 ns | 0.0273 ns | 0.0255 ns |  16.067 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 |  13.951 ns | 0.0115 ns | 0.0108 ns |  13.951 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 |  12.108 ns | 0.0154 ns | 0.0128 ns |  12.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  10.169 ns | 0.0129 ns | 0.0114 ns |  10.170 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |   7.457 ns | 0.1744 ns | 0.2915 ns |   7.610 ns |  0.59 |    0.03 |      - |     - |     - |         - |
                                            From_Short |        net461 |  11.917 ns | 0.0692 ns | 0.0647 ns |  11.966 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 |  11.776 ns | 0.0082 ns | 0.0076 ns |  11.774 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 |  11.288 ns | 0.0133 ns | 0.0111 ns |  11.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 |  10.272 ns | 0.0563 ns | 0.0527 ns |  10.247 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |   6.605 ns | 0.0078 ns | 0.0069 ns |   6.603 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 |  11.838 ns | 0.0082 ns | 0.0072 ns |  11.838 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 |  11.765 ns | 0.0183 ns | 0.0153 ns |  11.766 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 |  11.372 ns | 0.0098 ns | 0.0087 ns |  11.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 |  10.235 ns | 0.0136 ns | 0.0120 ns |  10.234 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |   6.897 ns | 0.0158 ns | 0.0140 ns |   6.895 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 |  11.863 ns | 0.0167 ns | 0.0148 ns |  11.861 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 |  11.814 ns | 0.0082 ns | 0.0073 ns |  11.814 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.376 ns | 0.0084 ns | 0.0074 ns |  13.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.077 ns | 0.0125 ns | 0.0116 ns |  13.079 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.424 ns | 0.0718 ns | 0.0672 ns |  12.372 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 |  17.242 ns | 0.0249 ns | 0.0221 ns |  17.244 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 |  13.409 ns | 0.0087 ns | 0.0072 ns |  13.411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 |  11.994 ns | 0.0161 ns | 0.0150 ns |  11.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  10.152 ns | 0.0130 ns | 0.0101 ns |  10.151 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |   6.605 ns | 0.0097 ns | 0.0086 ns |   6.604 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 |  11.894 ns | 0.0139 ns | 0.0130 ns |  11.894 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 |  11.897 ns | 0.0511 ns | 0.0478 ns |  11.912 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 |  11.282 ns | 0.0150 ns | 0.0140 ns |  11.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 |  10.186 ns | 0.0204 ns | 0.0191 ns |  10.178 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |   6.894 ns | 0.0229 ns | 0.0203 ns |   6.895 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 |  11.835 ns | 0.0140 ns | 0.0124 ns |  11.834 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 |  11.783 ns | 0.0148 ns | 0.0138 ns |  11.778 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 |  11.333 ns | 0.0210 ns | 0.0196 ns |  11.322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  10.542 ns | 0.0146 ns | 0.0137 ns |  10.540 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |   7.300 ns | 0.0794 ns | 0.0743 ns |   7.266 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 |  12.071 ns | 0.0082 ns | 0.0069 ns |  12.070 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 |  12.532 ns | 0.0165 ns | 0.0138 ns |  12.529 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.256 ns | 0.0235 ns | 0.0209 ns |  13.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.322 ns | 0.0222 ns | 0.0186 ns |  12.316 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.539 ns | 0.0972 ns | 0.0910 ns |  13.548 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 |  16.107 ns | 0.0217 ns | 0.0203 ns |  16.112 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 |  15.540 ns | 0.0691 ns | 0.0612 ns |  15.562 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 |  12.004 ns | 0.0237 ns | 0.0222 ns |  12.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  10.198 ns | 0.0605 ns | 0.0566 ns |  10.176 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |   7.698 ns | 0.1731 ns | 0.1619 ns |   7.702 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 |  11.858 ns | 0.0494 ns | 0.0462 ns |  11.834 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 |  11.799 ns | 0.0095 ns | 0.0089 ns |  11.796 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 |  12.451 ns | 0.0697 ns | 0.0618 ns |  12.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 |  11.007 ns | 0.0117 ns | 0.0097 ns |  11.009 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |   7.845 ns | 0.0148 ns | 0.0139 ns |   7.846 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 |  13.079 ns | 0.0082 ns | 0.0069 ns |  13.077 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 |  12.523 ns | 0.0130 ns | 0.0115 ns |  12.523 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 |  12.336 ns | 0.0226 ns | 0.0176 ns |  12.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 |  11.002 ns | 0.0116 ns | 0.0103 ns |  11.004 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |   7.829 ns | 0.0134 ns | 0.0125 ns |   7.829 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 |  12.942 ns | 0.0128 ns | 0.0113 ns |  12.945 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 |  12.770 ns | 0.0112 ns | 0.0099 ns |  12.770 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.803 ns | 0.0124 ns | 0.0116 ns |  13.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.129 ns | 0.0797 ns | 0.0746 ns |  13.081 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.471 ns | 0.0735 ns | 0.0687 ns |  12.502 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 |  16.103 ns | 0.0202 ns | 0.0179 ns |  16.100 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 |  13.672 ns | 0.0153 ns | 0.0119 ns |  13.669 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 |  12.182 ns | 0.0097 ns | 0.0081 ns |  12.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 |  10.169 ns | 0.0106 ns | 0.0099 ns |  10.170 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |   6.871 ns | 0.0126 ns | 0.0111 ns |   6.870 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 |  11.863 ns | 0.0179 ns | 0.0168 ns |  11.861 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 |  13.317 ns | 0.0105 ns | 0.0093 ns |  13.317 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 |  11.274 ns | 0.0128 ns | 0.0120 ns |  11.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 |  10.260 ns | 0.0595 ns | 0.0557 ns |  10.296 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |   6.906 ns | 0.0161 ns | 0.0150 ns |   6.902 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 |  11.834 ns | 0.0198 ns | 0.0185 ns |  11.831 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 |  11.822 ns | 0.0749 ns | 0.0701 ns |  11.768 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 |  11.280 ns | 0.0147 ns | 0.0137 ns |  11.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  10.201 ns | 0.0088 ns | 0.0073 ns |  10.200 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |   6.896 ns | 0.0093 ns | 0.0087 ns |   6.894 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 |  14.881 ns | 0.0135 ns | 0.0119 ns |  14.878 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 |  11.808 ns | 0.0172 ns | 0.0153 ns |  11.806 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.395 ns | 0.0104 ns | 0.0097 ns |  13.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.464 ns | 0.0102 ns | 0.0095 ns |  12.467 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.157 ns | 0.2981 ns | 0.3313 ns |  13.952 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 |  16.082 ns | 0.0377 ns | 0.0353 ns |  16.071 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 |  15.324 ns | 0.0174 ns | 0.0155 ns |  15.322 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 |  12.126 ns | 0.0145 ns | 0.0121 ns |  12.127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 |  10.369 ns | 0.0151 ns | 0.0126 ns |  10.371 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |   7.019 ns | 0.0209 ns | 0.0195 ns |   7.015 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 |  11.935 ns | 0.0119 ns | 0.0112 ns |  11.936 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 |  11.771 ns | 0.0066 ns | 0.0055 ns |  11.770 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 |  11.361 ns | 0.0083 ns | 0.0077 ns |  11.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 |  10.199 ns | 0.0136 ns | 0.0121 ns |  10.202 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |   6.958 ns | 0.1141 ns | 0.1067 ns |   6.957 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 |  12.615 ns | 0.0182 ns | 0.0170 ns |  12.616 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 |  11.786 ns | 0.0120 ns | 0.0106 ns |  11.785 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 |  11.780 ns | 0.1355 ns | 0.1267 ns |  11.733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 |  10.316 ns | 0.0128 ns | 0.0120 ns |  10.315 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |   6.602 ns | 0.0098 ns | 0.0087 ns |   6.603 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 |  11.824 ns | 0.0146 ns | 0.0137 ns |  11.821 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 |  12.035 ns | 0.0148 ns | 0.0131 ns |  12.034 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.600 ns | 0.0142 ns | 0.0118 ns |  14.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.071 ns | 0.0112 ns | 0.0105 ns |  13.071 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.503 ns | 0.0315 ns | 0.0294 ns |  12.510 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 |  15.005 ns | 0.0216 ns | 0.0202 ns |  15.003 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 |  15.606 ns | 0.0171 ns | 0.0160 ns |  15.606 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 495.710 ns | 0.7064 ns | 0.6262 ns | 495.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 435.642 ns | 0.7521 ns | 0.6667 ns | 435.773 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 397.234 ns | 0.5024 ns | 0.3922 ns | 397.369 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 777.165 ns | 1.1882 ns | 1.1114 ns | 776.557 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 772.671 ns | 1.1194 ns | 0.9923 ns | 772.629 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 502.890 ns | 0.4278 ns | 0.3792 ns | 502.957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 441.460 ns | 0.9853 ns | 0.9217 ns | 441.370 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 423.808 ns | 7.1214 ns | 6.6614 ns | 427.092 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 785.038 ns | 2.8021 ns | 2.6211 ns | 784.769 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 779.398 ns | 0.7631 ns | 0.7138 ns | 779.528 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 |  12.764 ns | 0.0173 ns | 0.0144 ns |  12.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 |  11.493 ns | 0.0074 ns | 0.0069 ns |  11.492 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 |  11.567 ns | 0.0235 ns | 0.0220 ns |  11.573 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 |  15.482 ns | 0.0224 ns | 0.0198 ns |  15.473 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 |  12.688 ns | 0.0192 ns | 0.0170 ns |  12.685 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 |  15.279 ns | 0.0347 ns | 0.0307 ns |  15.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 |  12.371 ns | 0.0149 ns | 0.0132 ns |  12.372 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 |  12.423 ns | 0.0790 ns | 0.0659 ns |  12.391 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 |  16.081 ns | 0.0183 ns | 0.0153 ns |  16.082 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 |  13.452 ns | 0.0117 ns | 0.0103 ns |  13.450 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 |  13.492 ns | 0.0180 ns | 0.0168 ns |  13.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 |  11.405 ns | 0.0079 ns | 0.0070 ns |  11.405 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 |  12.171 ns | 0.2027 ns | 0.1896 ns |  12.052 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 |  16.031 ns | 0.0452 ns | 0.0423 ns |  16.048 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 |  12.646 ns | 0.0168 ns | 0.0149 ns |  12.642 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 |  11.275 ns | 0.0124 ns | 0.0110 ns |  11.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  10.207 ns | 0.0182 ns | 0.0170 ns |  10.206 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |   6.909 ns | 0.0466 ns | 0.0436 ns |   6.928 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 |  11.839 ns | 0.0172 ns | 0.0160 ns |  11.838 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 |  11.891 ns | 0.0338 ns | 0.0317 ns |  11.896 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 |  11.274 ns | 0.0116 ns | 0.0103 ns |  11.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 |  10.286 ns | 0.0360 ns | 0.0337 ns |  10.290 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |   6.642 ns | 0.0353 ns | 0.0330 ns |   6.650 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 |  11.849 ns | 0.0172 ns | 0.0143 ns |  11.850 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 |  11.785 ns | 0.0129 ns | 0.0120 ns |  11.783 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 |  11.266 ns | 0.0156 ns | 0.0145 ns |  11.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  10.216 ns | 0.0077 ns | 0.0072 ns |  10.216 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |   7.936 ns | 0.1811 ns | 0.2013 ns |   7.982 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 |  12.519 ns | 0.0125 ns | 0.0111 ns |  12.519 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 |  11.754 ns | 0.0072 ns | 0.0064 ns |  11.753 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.430 ns | 0.0837 ns | 0.0783 ns |  13.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.377 ns | 0.0162 ns | 0.0151 ns |  12.378 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 |  12.925 ns | 0.2560 ns | 0.2395 ns |  12.783 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 |  16.109 ns | 0.0170 ns | 0.0159 ns |  16.109 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 |  15.985 ns | 0.0317 ns | 0.0297 ns |  15.982 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 |  12.162 ns | 0.0121 ns | 0.0101 ns |  12.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  10.175 ns | 0.0117 ns | 0.0104 ns |  10.178 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |   7.028 ns | 0.0237 ns | 0.0222 ns |   7.026 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 |  11.932 ns | 0.0186 ns | 0.0174 ns |  11.930 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 |  11.808 ns | 0.0100 ns | 0.0088 ns |  11.808 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 |  11.291 ns | 0.0152 ns | 0.0142 ns |  11.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 |  10.222 ns | 0.0168 ns | 0.0149 ns |  10.222 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |   6.725 ns | 0.1925 ns | 0.2292 ns |   6.605 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 |  12.109 ns | 0.0508 ns | 0.0475 ns |  12.083 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 |  11.939 ns | 0.0767 ns | 0.0717 ns |  11.984 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 |  11.397 ns | 0.0416 ns | 0.0389 ns |  11.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  10.304 ns | 0.0300 ns | 0.0281 ns |  10.316 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |   6.626 ns | 0.0417 ns | 0.0390 ns |   6.608 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 |  11.831 ns | 0.0193 ns | 0.0181 ns |  11.826 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 |  11.787 ns | 0.0176 ns | 0.0165 ns |  11.785 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.766 ns | 0.0114 ns | 0.0106 ns |  13.765 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.107 ns | 0.0100 ns | 0.0094 ns |  13.105 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.430 ns | 0.0465 ns | 0.0435 ns |  13.444 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 |  16.767 ns | 0.0310 ns | 0.0290 ns |  16.769 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 |  14.173 ns | 0.0082 ns | 0.0077 ns |  14.172 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 |  11.358 ns | 0.0761 ns | 0.0712 ns |  11.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 |  10.911 ns | 0.0116 ns | 0.0097 ns |  10.912 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |   6.846 ns | 0.0071 ns | 0.0067 ns |   6.845 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 |  12.106 ns | 0.0139 ns | 0.0130 ns |  12.107 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 |  11.896 ns | 0.0659 ns | 0.0617 ns |  11.919 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 |  12.297 ns | 0.0108 ns | 0.0090 ns |  12.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 |  11.041 ns | 0.0087 ns | 0.0081 ns |  11.040 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |   8.542 ns | 0.2538 ns | 0.2607 ns |   8.421 ns |  0.70 |    0.02 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 |  13.062 ns | 0.0121 ns | 0.0107 ns |  13.060 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 |  12.551 ns | 0.0132 ns | 0.0110 ns |  12.550 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 |  13.078 ns | 0.0158 ns | 0.0140 ns |  13.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 |  11.050 ns | 0.0136 ns | 0.0120 ns |  11.052 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |   7.965 ns | 0.0170 ns | 0.0151 ns |   7.961 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 |  13.342 ns | 0.0219 ns | 0.0194 ns |  13.342 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 |  12.751 ns | 0.0163 ns | 0.0153 ns |  12.749 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.228 ns | 0.0693 ns | 0.0648 ns |  13.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.091 ns | 0.0118 ns | 0.0110 ns |  13.089 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.989 ns | 0.0375 ns | 0.0314 ns |  13.976 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 |  16.073 ns | 0.0234 ns | 0.0207 ns |  16.077 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 |  13.468 ns | 0.0167 ns | 0.0156 ns |  13.469 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 |  14.428 ns | 0.0096 ns | 0.0090 ns |  14.428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 |  13.455 ns | 0.0117 ns | 0.0109 ns |  13.456 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 |  12.677 ns | 0.2660 ns | 0.2488 ns |  12.841 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 |  16.088 ns | 0.0304 ns | 0.0270 ns |  16.079 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 |  15.463 ns | 0.0302 ns | 0.0283 ns |  15.466 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 |  10.721 ns | 0.0103 ns | 0.0091 ns |  10.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |   9.567 ns | 0.0142 ns | 0.0133 ns |   9.568 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 |  12.615 ns | 0.0473 ns | 0.0442 ns |  12.629 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 |  11.514 ns | 0.0193 ns | 0.0181 ns |  11.515 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 |  12.620 ns | 0.0163 ns | 0.0153 ns |  12.618 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 |  15.361 ns | 0.0166 ns | 0.0139 ns |  15.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 |  13.089 ns | 0.0235 ns | 0.0209 ns |  13.078 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 |  13.269 ns | 0.2891 ns | 0.3759 ns |  13.038 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 |  16.071 ns | 0.0198 ns | 0.0185 ns |  16.069 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 |  13.472 ns | 0.0155 ns | 0.0145 ns |  13.473 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 |  15.131 ns | 0.0165 ns | 0.0147 ns |  15.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 |  12.797 ns | 0.0262 ns | 0.0246 ns |  12.799 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 |  12.190 ns | 0.0764 ns | 0.0715 ns |  12.200 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 |  17.029 ns | 0.0252 ns | 0.0235 ns |  17.030 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 |  18.681 ns | 0.0337 ns | 0.0315 ns |  18.687 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 |  16.800 ns | 0.0170 ns | 0.0151 ns |  16.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 |  14.341 ns | 0.0122 ns | 0.0102 ns |  14.337 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 |  15.201 ns | 0.1413 ns | 0.1322 ns |  15.279 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 |  19.858 ns | 0.0740 ns | 0.0692 ns |  19.875 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 |  17.498 ns | 0.0266 ns | 0.0249 ns |  17.495 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 |  13.240 ns | 0.0138 ns | 0.0129 ns |  13.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 |  12.028 ns | 0.0117 ns | 0.0110 ns |  12.029 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 |  11.882 ns | 0.0483 ns | 0.0451 ns |  11.886 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 |  13.317 ns | 0.0354 ns | 0.0331 ns |  13.310 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 |  15.206 ns | 0.0593 ns | 0.0526 ns |  15.196 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  14.292 ns | 0.0193 ns | 0.0171 ns |  14.291 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  12.327 ns | 0.0123 ns | 0.0103 ns |  12.328 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  13.603 ns | 0.2700 ns | 0.2525 ns |  13.409 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 |  15.032 ns | 0.0736 ns | 0.0688 ns |  15.007 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 |  14.274 ns | 0.0138 ns | 0.0122 ns |  14.272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 |  11.892 ns | 0.0627 ns | 0.0586 ns |  11.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 |  10.832 ns | 0.0605 ns | 0.0566 ns |  10.860 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 |  10.830 ns | 0.0796 ns | 0.0745 ns |  10.794 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 |  14.119 ns | 0.0141 ns | 0.0125 ns |  14.120 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 |  14.246 ns | 0.0296 ns | 0.0277 ns |  14.240 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 |  14.692 ns | 0.0119 ns | 0.0111 ns |  14.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 |  13.492 ns | 0.0152 ns | 0.0127 ns |  13.490 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 |  13.760 ns | 0.0152 ns | 0.0142 ns |  13.760 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 |  17.299 ns | 0.0220 ns | 0.0184 ns |  17.299 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 |  16.803 ns | 0.0329 ns | 0.0308 ns |  16.807 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 |  11.844 ns | 0.0182 ns | 0.0161 ns |  11.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 |  10.773 ns | 0.0072 ns | 0.0067 ns |  10.776 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 |  10.771 ns | 0.0143 ns | 0.0134 ns |  10.767 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 |  12.859 ns | 0.0131 ns | 0.0116 ns |  12.860 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 |  14.245 ns | 0.0221 ns | 0.0206 ns |  14.245 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 |  13.399 ns | 0.0190 ns | 0.0178 ns |  13.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 |  13.090 ns | 0.0191 ns | 0.0178 ns |  13.091 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 |  15.009 ns | 0.0768 ns | 0.0718 ns |  14.967 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 |  16.409 ns | 0.0178 ns | 0.0149 ns |  16.411 ns |  1.22 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 |  13.437 ns | 0.0209 ns | 0.0186 ns |  13.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 |  19.686 ns | 0.0216 ns | 0.0192 ns |  19.681 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 |  16.883 ns | 0.0487 ns | 0.0455 ns |  16.876 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 |  11.650 ns | 0.0641 ns | 0.0600 ns |  11.639 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 |  18.516 ns | 0.0694 ns | 0.0649 ns |  18.487 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 |  18.924 ns | 0.0778 ns | 0.0728 ns |  18.952 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 |  17.253 ns | 0.1058 ns | 0.0989 ns |  17.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 |  15.671 ns | 0.0182 ns | 0.0161 ns |  15.669 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 |  17.038 ns | 0.0217 ns | 0.0192 ns |  17.039 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 |  20.343 ns | 0.0501 ns | 0.0469 ns |  20.333 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 |  19.745 ns | 0.0419 ns | 0.0392 ns |  19.734 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  18.366 ns | 0.0343 ns | 0.0321 ns |  18.359 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  16.513 ns | 0.0256 ns | 0.0240 ns |  16.519 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  12.374 ns | 0.1001 ns | 0.0936 ns |  12.351 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 |  18.923 ns | 0.0556 ns | 0.0520 ns |  18.910 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 |  18.844 ns | 0.1274 ns | 0.1192 ns |  18.872 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  15.918 ns | 0.0304 ns | 0.0269 ns |  15.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  15.167 ns | 0.0207 ns | 0.0194 ns |  15.168 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  15.549 ns | 0.0434 ns | 0.0406 ns |  15.549 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  19.915 ns | 0.0392 ns | 0.0367 ns |  19.915 ns |  1.25 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  19.727 ns | 0.0409 ns | 0.0382 ns |  19.726 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  13.077 ns | 0.0476 ns | 0.0445 ns |  13.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  12.268 ns | 0.0126 ns | 0.0112 ns |  12.269 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   8.642 ns | 0.0320 ns | 0.0300 ns |   8.650 ns |  0.66 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 |  11.846 ns | 0.0183 ns | 0.0163 ns |  11.846 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 |  11.841 ns | 0.0090 ns | 0.0080 ns |  11.840 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.711 ns | 0.0168 ns | 0.0157 ns |  14.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.491 ns | 0.0749 ns | 0.0701 ns |  13.452 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.406 ns | 0.0145 ns | 0.0136 ns |  13.406 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  16.263 ns | 0.0252 ns | 0.0236 ns |  16.264 ns |  1.11 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  14.871 ns | 0.0198 ns | 0.0176 ns |  14.875 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 |  13.448 ns | 0.0497 ns | 0.0465 ns |  13.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 |  11.946 ns | 0.0218 ns | 0.0193 ns |  11.947 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |   6.606 ns | 0.0072 ns | 0.0068 ns |   6.606 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 |  11.832 ns | 0.0190 ns | 0.0169 ns |  11.828 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 |  11.944 ns | 0.0707 ns | 0.0661 ns |  11.915 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 |  14.426 ns | 0.0135 ns | 0.0120 ns |  14.424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 |  14.303 ns | 0.0113 ns | 0.0106 ns |  14.300 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 |  15.227 ns | 0.0664 ns | 0.0622 ns |  15.256 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 |  17.509 ns | 0.0690 ns | 0.0646 ns |  17.480 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 |  14.940 ns | 0.0207 ns | 0.0193 ns |  14.936 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 |  12.670 ns | 0.0124 ns | 0.0116 ns |  12.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 |  11.946 ns | 0.0161 ns | 0.0150 ns |  11.945 ns |  0.94 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |   7.517 ns | 0.0257 ns | 0.0240 ns |   7.516 ns |  0.59 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 |  12.427 ns | 0.0129 ns | 0.0114 ns |  12.426 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 |  11.924 ns | 0.0383 ns | 0.0340 ns |  11.910 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  15.419 ns | 0.0394 ns | 0.0369 ns |  15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  14.534 ns | 0.0244 ns | 0.0216 ns |  14.530 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  14.516 ns | 0.1134 ns | 0.1061 ns |  14.536 ns |  0.94 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 |  16.305 ns | 0.0233 ns | 0.0207 ns |  16.309 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 |  16.956 ns | 0.0660 ns | 0.0617 ns |  16.966 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 |  12.694 ns | 0.0449 ns | 0.0420 ns |  12.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 |  10.573 ns | 0.0103 ns | 0.0091 ns |  10.572 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |   6.927 ns | 0.0121 ns | 0.0107 ns |   6.928 ns |  0.55 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 |  11.989 ns | 0.0410 ns | 0.0363 ns |  12.000 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 |  11.918 ns | 0.0107 ns | 0.0089 ns |  11.918 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  13.391 ns | 0.0162 ns | 0.0144 ns |  13.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.338 ns | 0.0062 ns | 0.0052 ns |  12.337 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.443 ns | 0.0169 ns | 0.0150 ns |  13.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 |  16.068 ns | 0.0250 ns | 0.0234 ns |  16.065 ns |  1.20 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 |  15.440 ns | 0.1297 ns | 0.1213 ns |  15.393 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 |  12.789 ns | 0.0823 ns | 0.0770 ns |  12.733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 |  10.564 ns | 0.0203 ns | 0.0170 ns |  10.558 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |   6.943 ns | 0.0294 ns | 0.0275 ns |   6.953 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 |  11.821 ns | 0.0252 ns | 0.0224 ns |  11.817 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 |  11.774 ns | 0.0112 ns | 0.0105 ns |  11.772 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Enum_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 |  14.569 ns | 0.0174 ns | 0.0145 ns |  14.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 |  10.635 ns | 0.0118 ns | 0.0111 ns |  10.638 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |   6.907 ns | 0.0064 ns | 0.0060 ns |   6.908 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 |  11.829 ns | 0.0238 ns | 0.0222 ns |  11.833 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 |  12.658 ns | 0.0884 ns | 0.0827 ns |  12.599 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                 From_Enum_Nullable_WithValue_AsObject |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 |  12.684 ns | 0.0125 ns | 0.0117 ns |  12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 |  10.514 ns | 0.0141 ns | 0.0125 ns |  10.513 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |   7.499 ns | 0.1753 ns | 0.1801 ns |   7.512 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 |  11.815 ns | 0.0158 ns | 0.0140 ns |  11.816 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 |  11.763 ns | 0.0105 ns | 0.0093 ns |  11.765 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.334 ns | 0.0796 ns | 0.0745 ns |  14.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 |  12.718 ns | 0.0438 ns | 0.0410 ns |  12.733 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 |  13.316 ns | 0.0135 ns | 0.0126 ns |  13.316 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 |  16.096 ns | 0.0212 ns | 0.0198 ns |  16.094 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 |  16.363 ns | 0.0134 ns | 0.0118 ns |  16.363 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 |  11.847 ns | 0.0164 ns | 0.0153 ns |  11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 |  10.810 ns | 0.0232 ns | 0.0217 ns |  10.812 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 |  10.807 ns | 0.0172 ns | 0.0161 ns |  10.806 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 |  12.595 ns | 0.0183 ns | 0.0171 ns |  12.600 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 |  14.220 ns | 0.0189 ns | 0.0176 ns |  14.225 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 |  15.871 ns | 0.0812 ns | 0.0760 ns |  15.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 |  14.850 ns | 0.0107 ns | 0.0100 ns |  14.850 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 |  14.797 ns | 0.3150 ns | 0.3750 ns |  14.601 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 |  17.272 ns | 0.0469 ns | 0.0392 ns |  17.277 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 |  15.308 ns | 0.0837 ns | 0.0783 ns |  15.275 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 |  11.851 ns | 0.0072 ns | 0.0068 ns |  11.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 |  10.737 ns | 0.0065 ns | 0.0061 ns |  10.737 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 |  13.146 ns | 0.2897 ns | 0.3337 ns |  13.312 ns |  1.10 |    0.03 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 |  14.097 ns | 0.0095 ns | 0.0079 ns |  14.096 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 |  14.226 ns | 0.0212 ns | 0.0166 ns |  14.231 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 |  14.518 ns | 0.0147 ns | 0.0138 ns |  14.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 |  12.362 ns | 0.0121 ns | 0.0107 ns |  12.362 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 |  12.406 ns | 0.0182 ns | 0.0142 ns |  12.403 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 |  16.064 ns | 0.0213 ns | 0.0189 ns |  16.064 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 |  13.444 ns | 0.0140 ns | 0.0131 ns |  13.443 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 |  38.534 ns | 0.2128 ns | 0.1991 ns |  38.420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 |  37.871 ns | 0.0340 ns | 0.0318 ns |  37.870 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 |  34.760 ns | 0.1974 ns | 0.1541 ns |  34.813 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 |  38.182 ns | 0.0372 ns | 0.0348 ns |  38.180 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 |  43.285 ns | 0.1225 ns | 0.1146 ns |  43.297 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 |  15.828 ns | 0.0219 ns | 0.0204 ns |  15.825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 |  14.203 ns | 0.0841 ns | 0.0787 ns |  14.215 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 |  14.492 ns | 0.3113 ns | 0.3937 ns |  14.785 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 |  16.843 ns | 0.0228 ns | 0.0202 ns |  16.841 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 |  15.226 ns | 0.0244 ns | 0.0228 ns |  15.232 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 |  38.903 ns | 0.0473 ns | 0.0395 ns |  38.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 |  37.083 ns | 0.0496 ns | 0.0440 ns |  37.077 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 |  36.443 ns | 0.7548 ns | 1.0581 ns |  35.848 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 |  38.174 ns | 0.0475 ns | 0.0445 ns |  38.174 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 |  40.070 ns | 0.0522 ns | 0.0463 ns |  40.084 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 |  14.853 ns | 0.0196 ns | 0.0183 ns |  14.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 |  14.628 ns | 0.0117 ns | 0.0103 ns |  14.628 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 |  14.966 ns | 0.2845 ns | 0.2661 ns |  14.932 ns |  1.01 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 |  17.572 ns | 0.0299 ns | 0.0280 ns |  17.561 ns |  1.18 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 |  17.079 ns | 0.0265 ns | 0.0248 ns |  17.074 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 |  41.050 ns | 0.0619 ns | 0.0483 ns |  41.054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 |  37.866 ns | 0.0546 ns | 0.0511 ns |  37.862 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 |  33.879 ns | 0.1824 ns | 0.1706 ns |  33.986 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 |  39.773 ns | 0.0402 ns | 0.0357 ns |  39.750 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 |  40.113 ns | 0.0673 ns | 0.0562 ns |  40.111 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |            |           |           |            |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 |  14.429 ns | 0.0138 ns | 0.0129 ns |  14.427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 |  13.258 ns | 0.0120 ns | 0.0113 ns |  13.260 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 |  14.759 ns | 0.0575 ns | 0.0510 ns |  14.778 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 |  16.094 ns | 0.0184 ns | 0.0163 ns |  16.097 ns |  1.12 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 |  15.414 ns | 0.1188 ns | 0.1112 ns |  15.481 ns |  1.07 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Bool_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Bool_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Bool_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Bool_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Byte_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Byte_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Byte_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Byte_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Byte_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Char_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Char_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Char_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Char_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Char_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Decimal_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Double_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Double_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Double_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Double_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Double_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Short_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Short_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Short_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Short_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Short_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Int_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Int_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Int_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Int_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Int_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Long_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Long_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Long_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Long_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Long_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_SByte_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_SByte_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_SByte_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_SByte_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_SByte_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Float_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Float_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Float_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Float_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Float_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_UShort_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UShort_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UShort_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UShort_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_UShort_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_UInt_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UInt_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UInt_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UInt_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_UInt_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_ULong_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_ULong_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_ULong_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_ULong_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_ULong_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Enum_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Enum_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Enum_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Enum_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Enum_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
