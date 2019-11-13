
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
                                             From_Bool | .NET Core 2.0 | 13.985 ns | 0.0140 ns | 0.0131 ns | 13.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.505 ns | 0.0103 ns | 0.0097 ns | 10.503 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 10.963 ns | 0.9424 ns | 1.4948 ns | 10.129 ns |  0.86 |    0.13 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.515 ns | 0.0152 ns | 0.0142 ns | 12.512 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.142 ns | 0.0744 ns | 0.0660 ns | 13.137 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.963 ns | 0.0527 ns | 0.0467 ns | 18.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.774 ns | 0.0241 ns | 0.0226 ns | 17.781 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.642 ns | 0.0446 ns | 0.0396 ns | 17.650 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 26.927 ns | 0.0417 ns | 0.0370 ns | 26.926 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 27.067 ns | 0.0476 ns | 0.0446 ns | 27.068 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.011 ns | 0.0123 ns | 0.0109 ns | 12.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.783 ns | 0.0504 ns | 0.0421 ns | 10.793 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.102 ns | 0.0108 ns | 0.0101 ns | 10.101 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.721 ns | 0.0200 ns | 0.0187 ns | 13.715 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.700 ns | 0.0129 ns | 0.0108 ns | 12.700 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.803 ns | 0.0198 ns | 0.0166 ns | 18.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.771 ns | 0.0320 ns | 0.0299 ns | 17.767 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.621 ns | 0.0406 ns | 0.0380 ns | 17.616 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 26.763 ns | 0.0645 ns | 0.0572 ns | 26.772 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.364 ns | 0.0594 ns | 0.0556 ns | 27.356 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.835 ns | 0.0097 ns | 0.0091 ns | 11.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.993 ns | 0.0150 ns | 0.0125 ns | 10.996 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.457 ns | 0.0115 ns | 0.0102 ns |  9.458 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.866 ns | 0.0181 ns | 0.0151 ns | 12.870 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.748 ns | 0.0123 ns | 0.0115 ns | 12.751 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.535 ns | 0.0113 ns | 0.0100 ns | 14.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.913 ns | 0.0436 ns | 0.0387 ns | 13.917 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.106 ns | 0.0166 ns | 0.0138 ns | 13.103 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.627 ns | 0.0485 ns | 0.0453 ns | 22.615 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 22.854 ns | 0.0773 ns | 0.0723 ns | 22.871 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.860 ns | 0.0129 ns | 0.0114 ns | 11.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 11.292 ns | 0.0152 ns | 0.0142 ns | 11.287 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 | 10.145 ns | 0.0194 ns | 0.0172 ns | 10.148 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.267 ns | 0.0192 ns | 0.0179 ns | 12.264 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.228 ns | 0.0141 ns | 0.0125 ns | 12.224 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.616 ns | 0.0531 ns | 0.0471 ns | 19.610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.923 ns | 0.0223 ns | 0.0209 ns | 17.928 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 18.584 ns | 0.3905 ns | 0.6306 ns | 18.982 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.464 ns | 0.0777 ns | 0.0688 ns | 27.475 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.204 ns | 0.0271 ns | 0.0254 ns | 27.204 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.808 ns | 0.0153 ns | 0.0143 ns | 11.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 11.857 ns | 0.0218 ns | 0.0204 ns | 11.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  9.896 ns | 0.0120 ns | 0.0100 ns |  9.898 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.904 ns | 0.0157 ns | 0.0147 ns | 12.903 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.814 ns | 0.0289 ns | 0.0270 ns | 12.806 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.892 ns | 0.0237 ns | 0.0222 ns | 18.884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.510 ns | 0.0230 ns | 0.0215 ns | 17.510 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.676 ns | 0.0362 ns | 0.0339 ns | 17.674 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.000 ns | 0.0492 ns | 0.0461 ns | 26.990 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.287 ns | 0.0370 ns | 0.0346 ns | 27.279 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.832 ns | 0.0132 ns | 0.0123 ns | 11.828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.450 ns | 0.0126 ns | 0.0112 ns | 10.450 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.451 ns | 0.0128 ns | 0.0120 ns |  9.449 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.875 ns | 0.0629 ns | 0.0589 ns | 12.853 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.575 ns | 0.0119 ns | 0.0093 ns | 13.577 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.866 ns | 0.0668 ns | 0.0625 ns | 14.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.525 ns | 0.0482 ns | 0.0402 ns | 13.536 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.333 ns | 0.3117 ns | 0.4266 ns | 14.015 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.593 ns | 0.0384 ns | 0.0340 ns | 22.585 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 22.632 ns | 0.0464 ns | 0.0434 ns | 22.625 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.840 ns | 0.0146 ns | 0.0137 ns | 11.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.481 ns | 0.0111 ns | 0.0104 ns | 10.482 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.463 ns | 0.0093 ns | 0.0087 ns |  9.464 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.019 ns | 0.0385 ns | 0.0342 ns | 13.032 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.912 ns | 0.0118 ns | 0.0104 ns | 12.908 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.395 ns | 0.0446 ns | 0.0373 ns | 19.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.654 ns | 0.0258 ns | 0.0228 ns | 18.652 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.143 ns | 0.0499 ns | 0.0467 ns | 18.139 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.082 ns | 0.1009 ns | 0.0943 ns | 27.055 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 27.614 ns | 0.0633 ns | 0.0592 ns | 27.627 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.135 ns | 0.0159 ns | 0.0141 ns | 12.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.807 ns | 0.0297 ns | 0.0263 ns | 10.814 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.130 ns | 0.0084 ns | 0.0075 ns | 10.130 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.372 ns | 0.0133 ns | 0.0125 ns | 13.374 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.425 ns | 0.0168 ns | 0.0157 ns | 13.422 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.203 ns | 0.0232 ns | 0.0217 ns | 20.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.760 ns | 0.0223 ns | 0.0209 ns | 18.759 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.687 ns | 0.0348 ns | 0.0325 ns | 17.675 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.409 ns | 0.0488 ns | 0.0456 ns | 27.414 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 27.368 ns | 0.0246 ns | 0.0192 ns | 27.366 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.101 ns | 0.0896 ns | 0.0838 ns | 12.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.406 ns | 0.0128 ns | 0.0113 ns | 10.403 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.702 ns | 0.0143 ns | 0.0127 ns |  9.704 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 14.644 ns | 0.0508 ns | 0.0450 ns | 14.647 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.261 ns | 0.0145 ns | 0.0136 ns | 13.257 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.531 ns | 0.0120 ns | 0.0107 ns | 14.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.547 ns | 0.0362 ns | 0.0320 ns | 13.535 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.107 ns | 0.0273 ns | 0.0242 ns | 13.104 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 24.207 ns | 0.0352 ns | 0.0330 ns | 24.210 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 22.852 ns | 0.0191 ns | 0.0179 ns | 22.853 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.783 ns | 0.0137 ns | 0.0128 ns | 12.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.658 ns | 0.0084 ns | 0.0079 ns | 11.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 10.098 ns | 0.0104 ns | 0.0098 ns | 10.097 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.025 ns | 0.0244 ns | 0.0229 ns | 13.024 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 14.617 ns | 0.2766 ns | 0.2587 ns | 14.718 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.332 ns | 0.0197 ns | 0.0184 ns | 12.328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.914 ns | 0.0119 ns | 0.0111 ns | 11.911 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.106 ns | 0.0180 ns | 0.0150 ns | 10.106 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.290 ns | 0.0157 ns | 0.0147 ns | 13.288 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.092 ns | 0.0211 ns | 0.0187 ns | 14.087 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.336 ns | 0.0141 ns | 0.0110 ns | 12.336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.806 ns | 0.0178 ns | 0.0158 ns | 12.809 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.127 ns | 0.0122 ns | 0.0108 ns | 10.130 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.004 ns | 0.0353 ns | 0.0313 ns | 13.988 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.953 ns | 0.0208 ns | 0.0173 ns | 13.951 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.530 ns | 0.0166 ns | 0.0155 ns | 14.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.389 ns | 0.0150 ns | 0.0125 ns | 13.388 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.911 ns | 0.2985 ns | 0.5068 ns | 13.592 ns |  0.99 |    0.03 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.583 ns | 0.0361 ns | 0.0320 ns | 22.585 ns |  1.55 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 22.859 ns | 0.0648 ns | 0.0606 ns | 22.871 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.698 ns | 0.1113 ns | 0.1041 ns | 24.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.721 ns | 0.0268 ns | 0.0237 ns | 23.713 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.515 ns | 0.0198 ns | 0.0185 ns | 15.515 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 25.502 ns | 0.0358 ns | 0.0335 ns | 25.497 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.554 ns | 0.0147 ns | 0.0122 ns | 24.555 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.726 ns | 0.0389 ns | 0.0344 ns | 30.723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.819 ns | 0.0192 ns | 0.0171 ns | 29.821 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.876 ns | 0.1253 ns | 0.1110 ns | 23.840 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 37.190 ns | 0.0438 ns | 0.0388 ns | 37.199 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 37.212 ns | 0.0355 ns | 0.0315 ns | 37.219 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 27.273 ns | 0.0372 ns | 0.0330 ns | 27.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.975 ns | 0.0295 ns | 0.0231 ns | 23.982 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.168 ns | 0.0349 ns | 0.0326 ns | 19.167 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.297 ns | 0.0400 ns | 0.0375 ns | 26.295 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.924 ns | 0.0384 ns | 0.0340 ns | 26.926 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.962 ns | 0.0864 ns | 0.0808 ns | 30.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.802 ns | 0.0572 ns | 0.0535 ns | 29.794 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.654 ns | 0.0289 ns | 0.0256 ns | 22.651 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 42.519 ns | 0.0505 ns | 0.0394 ns | 42.520 ns |  1.37 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 36.881 ns | 0.0526 ns | 0.0466 ns | 36.888 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.558 ns | 0.0110 ns | 0.0103 ns | 12.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.407 ns | 0.0177 ns | 0.0165 ns | 11.405 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.167 ns | 0.0176 ns | 0.0164 ns | 10.162 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.669 ns | 0.0208 ns | 0.0195 ns | 14.665 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 15.031 ns | 0.0155 ns | 0.0145 ns | 15.033 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.493 ns | 0.0153 ns | 0.0143 ns | 14.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.379 ns | 0.0114 ns | 0.0107 ns | 13.381 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.0096 ns | 0.0085 ns | 13.109 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.605 ns | 0.0479 ns | 0.0448 ns | 22.592 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.887 ns | 0.0351 ns | 0.0311 ns | 22.887 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.196 ns | 0.0495 ns | 0.0463 ns | 15.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.059 ns | 0.0133 ns | 0.0118 ns | 13.057 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.482 ns | 0.0110 ns | 0.0092 ns | 12.480 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.355 ns | 0.0651 ns | 0.0577 ns | 15.332 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.410 ns | 0.0206 ns | 0.0193 ns | 15.408 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 22.075 ns | 0.0254 ns | 0.0238 ns | 22.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.092 ns | 0.0304 ns | 0.0269 ns | 20.086 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.500 ns | 0.0675 ns | 0.0631 ns | 20.478 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 29.229 ns | 0.0364 ns | 0.0341 ns | 29.234 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.401 ns | 0.0392 ns | 0.0347 ns | 29.406 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.591 ns | 0.0224 ns | 0.0198 ns | 16.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 15.197 ns | 0.0208 ns | 0.0174 ns | 15.201 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.218 ns | 0.1336 ns | 0.1249 ns | 13.126 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.877 ns | 0.0332 ns | 0.0295 ns | 16.871 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 16.900 ns | 0.0303 ns | 0.0253 ns | 16.892 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.430 ns | 0.0275 ns | 0.0230 ns | 21.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.416 ns | 0.0218 ns | 0.0204 ns | 20.419 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.091 ns | 0.0387 ns | 0.0323 ns | 20.081 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.316 ns | 0.0519 ns | 0.0433 ns | 29.328 ns |  1.37 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 29.550 ns | 0.1018 ns | 0.0903 ns | 29.517 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.712 ns | 0.0136 ns | 0.0127 ns | 12.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.414 ns | 0.0180 ns | 0.0169 ns | 12.412 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.105 ns | 0.0187 ns | 0.0146 ns | 10.107 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.484 ns | 0.0089 ns | 0.0084 ns | 13.485 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.467 ns | 0.0086 ns | 0.0076 ns | 13.465 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.286 ns | 0.0166 ns | 0.0156 ns | 15.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.376 ns | 0.0156 ns | 0.0122 ns | 13.374 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.025 ns | 0.0843 ns | 0.0788 ns | 15.035 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.551 ns | 0.0277 ns | 0.0246 ns | 22.552 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 24.421 ns | 0.0324 ns | 0.0288 ns | 24.424 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.861 ns | 0.0772 ns | 0.0722 ns | 11.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.402 ns | 0.0127 ns | 0.0112 ns | 10.403 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.914 ns | 0.0173 ns | 0.0162 ns |  9.916 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.226 ns | 0.0088 ns | 0.0078 ns | 12.228 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.243 ns | 0.0107 ns | 0.0100 ns | 12.243 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 23.508 ns | 0.0119 ns | 0.0106 ns | 23.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 25.552 ns | 0.0310 ns | 0.0274 ns | 25.561 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 27.619 ns | 0.0512 ns | 0.0479 ns | 27.631 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 35.442 ns | 0.0410 ns | 0.0384 ns | 35.438 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 37.385 ns | 0.0552 ns | 0.0516 ns | 37.394 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.479 ns | 0.0682 ns | 0.0638 ns | 11.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.280 ns | 0.0126 ns | 0.0105 ns | 10.276 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.640 ns | 0.0324 ns | 0.0303 ns |  6.639 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 11.683 ns | 0.0141 ns | 0.0132 ns | 11.683 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 11.786 ns | 0.0257 ns | 0.0228 ns | 11.780 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.934 ns | 0.0187 ns | 0.0146 ns | 25.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.521 ns | 0.0382 ns | 0.0358 ns | 25.518 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.014 ns | 0.0601 ns | 0.0562 ns | 27.013 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 37.136 ns | 0.0893 ns | 0.0791 ns | 37.107 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 37.223 ns | 0.0739 ns | 0.0691 ns | 37.227 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.459 ns | 0.0344 ns | 0.0305 ns | 11.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.315 ns | 0.0151 ns | 0.0118 ns | 10.318 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.089 ns | 0.0176 ns | 0.0156 ns |  7.092 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.376 ns | 0.0215 ns | 0.0201 ns | 12.367 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.101 ns | 0.0140 ns | 0.0117 ns | 12.102 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.528 ns | 0.0182 ns | 0.0171 ns | 14.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.508 ns | 0.0201 ns | 0.0188 ns | 13.501 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.125 ns | 0.3168 ns | 0.3112 ns | 15.122 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.588 ns | 0.0273 ns | 0.0255 ns | 22.587 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 22.608 ns | 0.0206 ns | 0.0183 ns | 22.606 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.807 ns | 0.0177 ns | 0.0166 ns | 12.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.846 ns | 0.0067 ns | 0.0062 ns | 11.846 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 10.408 ns | 0.0590 ns | 0.0552 ns | 10.443 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.112 ns | 0.0364 ns | 0.0323 ns | 14.099 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.903 ns | 0.0207 ns | 0.0161 ns | 12.907 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.787 ns | 0.0211 ns | 0.0164 ns | 19.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.217 ns | 0.0284 ns | 0.0266 ns | 18.218 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 21.023 ns | 0.0239 ns | 0.0212 ns | 21.019 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 29.926 ns | 0.0325 ns | 0.0304 ns | 29.922 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 29.339 ns | 0.0532 ns | 0.0498 ns | 29.342 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 14.597 ns | 0.0427 ns | 0.0400 ns | 14.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.876 ns | 0.0528 ns | 0.0494 ns | 11.879 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.149 ns | 0.0153 ns | 0.0135 ns | 10.151 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.377 ns | 0.0165 ns | 0.0155 ns | 13.377 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.442 ns | 0.0323 ns | 0.0302 ns | 13.443 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.339 ns | 0.0188 ns | 0.0167 ns | 19.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.613 ns | 0.0247 ns | 0.0231 ns | 18.610 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.016 ns | 0.0518 ns | 0.0459 ns | 18.014 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 29.308 ns | 0.0513 ns | 0.0480 ns | 29.302 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.835 ns | 0.0267 ns | 0.0250 ns | 27.831 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.916 ns | 0.0220 ns | 0.0206 ns | 11.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.004 ns | 0.0105 ns | 0.0098 ns | 11.007 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.661 ns | 0.0095 ns | 0.0089 ns |  9.660 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.236 ns | 0.0154 ns | 0.0137 ns | 13.236 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.757 ns | 0.0117 ns | 0.0098 ns | 12.758 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.779 ns | 0.0127 ns | 0.0119 ns | 14.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.306 ns | 0.0099 ns | 0.0088 ns | 15.306 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.226 ns | 0.0749 ns | 0.0700 ns | 13.256 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.634 ns | 0.0497 ns | 0.0440 ns | 22.628 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.381 ns | 0.0364 ns | 0.0340 ns | 22.382 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.882 ns | 0.0123 ns | 0.0096 ns | 12.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.495 ns | 0.0149 ns | 0.0132 ns | 12.495 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 10.360 ns | 0.0074 ns | 0.0069 ns | 10.358 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.934 ns | 0.0186 ns | 0.0145 ns | 12.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.893 ns | 0.0130 ns | 0.0115 ns | 12.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.492 ns | 0.0334 ns | 0.0312 ns | 20.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.977 ns | 0.0154 ns | 0.0137 ns | 18.978 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.632 ns | 0.4185 ns | 0.3915 ns | 19.398 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 29.273 ns | 0.0283 ns | 0.0251 ns | 29.277 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.788 ns | 0.0430 ns | 0.0359 ns | 27.791 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.674 ns | 0.0252 ns | 0.0236 ns | 14.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.933 ns | 0.0119 ns | 0.0111 ns | 12.932 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.935 ns | 0.0519 ns | 0.0486 ns | 10.946 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.604 ns | 0.0299 ns | 0.0265 ns | 14.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.564 ns | 0.0190 ns | 0.0178 ns | 14.566 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.046 ns | 0.0230 ns | 0.0180 ns | 20.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.426 ns | 0.0182 ns | 0.0171 ns | 18.427 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.374 ns | 0.3921 ns | 0.3851 ns | 18.150 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.468 ns | 0.0420 ns | 0.0351 ns | 27.471 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 28.332 ns | 0.0360 ns | 0.0319 ns | 28.339 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.485 ns | 0.0483 ns | 0.0452 ns | 12.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.946 ns | 0.0148 ns | 0.0139 ns | 11.946 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.662 ns | 0.0094 ns | 0.0088 ns |  9.660 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 15.459 ns | 0.0205 ns | 0.0171 ns | 15.456 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.933 ns | 0.0892 ns | 0.0835 ns | 13.954 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.525 ns | 0.0126 ns | 0.0118 ns | 14.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.344 ns | 0.0123 ns | 0.0115 ns | 14.349 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.142 ns | 0.0726 ns | 0.0679 ns | 13.108 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 25.911 ns | 0.0585 ns | 0.0547 ns | 25.911 ns |  1.78 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.305 ns | 0.0421 ns | 0.0373 ns | 24.306 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.814 ns | 0.0136 ns | 0.0121 ns | 11.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.424 ns | 0.0110 ns | 0.0097 ns | 10.422 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 10.137 ns | 0.0066 ns | 0.0062 ns | 10.138 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.377 ns | 0.0890 ns | 0.0832 ns | 12.409 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.203 ns | 0.0184 ns | 0.0172 ns | 12.199 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.044 ns | 0.0624 ns | 0.0553 ns | 19.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.526 ns | 0.0401 ns | 0.0355 ns | 17.515 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.549 ns | 0.0630 ns | 0.0589 ns | 17.553 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 28.770 ns | 0.0548 ns | 0.0486 ns | 28.778 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 28.911 ns | 0.0334 ns | 0.0312 ns | 28.917 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.555 ns | 0.0112 ns | 0.0100 ns | 13.555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.749 ns | 0.0179 ns | 0.0150 ns | 10.749 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  9.992 ns | 0.0593 ns | 0.0554 ns | 10.017 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.446 ns | 0.0607 ns | 0.0568 ns | 13.420 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.202 ns | 0.0120 ns | 0.0112 ns | 13.205 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.819 ns | 0.0291 ns | 0.0243 ns | 18.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.976 ns | 0.0239 ns | 0.0224 ns | 17.976 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.002 ns | 0.0537 ns | 0.0476 ns | 17.992 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.010 ns | 0.0281 ns | 0.0249 ns | 27.015 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 27.321 ns | 0.0498 ns | 0.0466 ns | 27.327 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.904 ns | 0.0324 ns | 0.0303 ns | 11.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.460 ns | 0.0114 ns | 0.0107 ns | 10.460 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.443 ns | 0.0214 ns | 0.0200 ns |  9.442 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.374 ns | 0.0114 ns | 0.0107 ns | 13.377 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.828 ns | 0.0102 ns | 0.0095 ns | 12.827 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.935 ns | 0.0236 ns | 0.0209 ns | 14.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.375 ns | 0.0121 ns | 0.0107 ns | 13.374 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.633 ns | 0.0995 ns | 0.0931 ns | 13.572 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.741 ns | 0.0955 ns | 0.0894 ns | 22.774 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.786 ns | 0.0909 ns | 0.0850 ns | 22.803 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.087 ns | 0.0257 ns | 0.0201 ns | 15.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.872 ns | 0.0135 ns | 0.0119 ns | 13.870 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.471 ns | 0.0387 ns | 0.0362 ns | 12.454 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.487 ns | 0.0209 ns | 0.0175 ns | 15.490 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.473 ns | 0.0240 ns | 0.0225 ns | 15.480 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.685 ns | 0.0238 ns | 0.0223 ns | 21.694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.565 ns | 0.0160 ns | 0.0133 ns | 20.566 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.537 ns | 0.0231 ns | 0.0193 ns | 20.541 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 29.355 ns | 0.0219 ns | 0.0205 ns | 29.355 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 29.024 ns | 0.0566 ns | 0.0529 ns | 29.029 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.436 ns | 0.0491 ns | 0.0435 ns | 15.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.760 ns | 0.0133 ns | 0.0124 ns | 13.761 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.671 ns | 0.0125 ns | 0.0117 ns | 12.670 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.545 ns | 0.0710 ns | 0.0629 ns | 15.516 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.366 ns | 0.0248 ns | 0.0220 ns | 15.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.420 ns | 0.0211 ns | 0.0187 ns | 21.425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.098 ns | 0.0271 ns | 0.0253 ns | 20.095 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.726 ns | 0.6062 ns | 1.1534 ns | 20.076 ns |  1.03 |    0.05 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 31.386 ns | 0.0462 ns | 0.0409 ns | 31.383 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 29.031 ns | 0.0302 ns | 0.0252 ns | 29.027 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.552 ns | 0.0357 ns | 0.0316 ns | 12.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.321 ns | 0.0107 ns | 0.0090 ns | 11.321 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.688 ns | 0.0280 ns | 0.0262 ns |  9.689 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.958 ns | 0.0145 ns | 0.0136 ns | 12.953 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.936 ns | 0.0129 ns | 0.0121 ns | 12.937 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.701 ns | 0.0212 ns | 0.0165 ns | 15.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.536 ns | 0.0093 ns | 0.0083 ns | 13.536 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.092 ns | 0.0168 ns | 0.0131 ns | 13.096 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.753 ns | 0.0735 ns | 0.0687 ns | 22.764 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 22.529 ns | 0.0318 ns | 0.0282 ns | 22.528 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 60.653 ns | 0.0868 ns | 0.0812 ns | 60.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 57.935 ns | 0.1031 ns | 0.0964 ns | 57.909 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.636 ns | 0.0201 ns | 0.0168 ns | 20.637 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.519 ns | 0.0769 ns | 0.0682 ns | 58.518 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 59.765 ns | 0.0992 ns | 0.0928 ns | 59.763 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.589 ns | 0.1125 ns | 0.0997 ns | 63.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 62.946 ns | 0.0771 ns | 0.0722 ns | 62.950 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 27.614 ns | 0.2092 ns | 0.1957 ns | 27.692 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 71.214 ns | 0.1223 ns | 0.1144 ns | 71.194 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 71.601 ns | 0.2590 ns | 0.2423 ns | 71.633 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.168 ns | 0.0326 ns | 0.0289 ns | 14.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.820 ns | 0.0847 ns | 0.0792 ns | 18.794 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.834 ns | 0.0152 ns | 0.0134 ns | 13.838 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.543 ns | 0.0614 ns | 0.0574 ns | 15.549 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.836 ns | 0.0580 ns | 0.0543 ns | 14.857 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.823 ns | 0.0199 ns | 0.0186 ns | 14.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.409 ns | 0.0219 ns | 0.0194 ns | 13.417 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.111 ns | 0.0266 ns | 0.0248 ns | 13.104 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.218 ns | 0.0369 ns | 0.0345 ns | 22.216 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 25.833 ns | 0.0283 ns | 0.0265 ns | 25.828 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.040 ns | 0.0087 ns | 0.0072 ns | 14.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 19.311 ns | 0.0156 ns | 0.0146 ns | 19.305 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.887 ns | 0.0749 ns | 0.0700 ns | 13.857 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.778 ns | 0.0098 ns | 0.0082 ns | 14.778 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.010 ns | 0.0235 ns | 0.0197 ns | 15.019 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.841 ns | 0.0190 ns | 0.0148 ns | 11.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.476 ns | 0.0126 ns | 0.0112 ns | 10.476 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 | 10.136 ns | 0.0121 ns | 0.0113 ns | 10.140 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.962 ns | 0.0179 ns | 0.0149 ns | 14.959 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.905 ns | 0.0536 ns | 0.0502 ns | 12.900 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.118 ns | 0.0261 ns | 0.0218 ns | 19.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.979 ns | 0.0231 ns | 0.0216 ns | 17.982 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.207 ns | 0.2647 ns | 0.2476 ns | 18.306 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 30.667 ns | 0.0266 ns | 0.0236 ns | 30.668 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.155 ns | 0.0518 ns | 0.0459 ns | 29.145 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.433 ns | 0.0111 ns | 0.0103 ns | 12.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.289 ns | 0.0168 ns | 0.0149 ns | 11.289 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.138 ns | 0.0104 ns | 0.0093 ns | 10.136 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.400 ns | 0.0191 ns | 0.0178 ns | 13.398 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.042 ns | 0.0578 ns | 0.0512 ns | 15.051 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.144 ns | 0.0262 ns | 0.0245 ns | 19.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.965 ns | 0.0187 ns | 0.0175 ns | 17.964 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.111 ns | 0.1086 ns | 0.1016 ns | 18.117 ns |  0.95 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.503 ns | 0.0359 ns | 0.0336 ns | 27.514 ns |  1.44 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.401 ns | 0.1015 ns | 0.0899 ns | 27.444 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.024 ns | 0.0202 ns | 0.0189 ns | 12.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.435 ns | 0.0129 ns | 0.0115 ns | 11.433 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 10.759 ns | 0.2416 ns | 0.4036 ns | 10.957 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.797 ns | 0.0111 ns | 0.0099 ns | 12.799 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.553 ns | 0.1011 ns | 0.0946 ns | 13.563 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.754 ns | 0.0157 ns | 0.0147 ns | 14.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.804 ns | 0.0072 ns | 0.0063 ns | 13.804 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.947 ns | 0.3645 ns | 0.9144 ns | 17.191 ns |  1.08 |    0.12 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.719 ns | 0.0418 ns | 0.0391 ns | 22.716 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 22.741 ns | 0.0340 ns | 0.0284 ns | 22.741 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.814 ns | 0.0684 ns | 0.0640 ns | 12.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.486 ns | 0.0167 ns | 0.0156 ns | 11.487 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 10.327 ns | 0.2284 ns | 0.3816 ns | 10.530 ns |  0.78 |    0.04 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.920 ns | 0.0179 ns | 0.0167 ns | 12.922 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.937 ns | 0.0173 ns | 0.0162 ns | 12.942 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.347 ns | 0.0246 ns | 0.0218 ns | 19.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 19.515 ns | 0.0225 ns | 0.0210 ns | 19.514 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 19.990 ns | 0.4237 ns | 0.8061 ns | 20.411 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.297 ns | 0.0224 ns | 0.0199 ns | 27.296 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.463 ns | 0.0356 ns | 0.0298 ns | 29.469 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.070 ns | 0.0078 ns | 0.0073 ns | 13.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.907 ns | 0.0136 ns | 0.0120 ns | 11.906 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 12.281 ns | 0.2719 ns | 0.6302 ns | 12.482 ns |  0.89 |    0.08 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.530 ns | 0.0624 ns | 0.0583 ns | 13.548 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.539 ns | 0.0174 ns | 0.0163 ns | 13.542 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.536 ns | 0.1217 ns | 0.1138 ns | 19.579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.200 ns | 0.0207 ns | 0.0193 ns | 18.201 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.017 ns | 0.0309 ns | 0.0289 ns | 18.024 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.240 ns | 0.0282 ns | 0.0250 ns | 27.246 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.605 ns | 0.0809 ns | 0.0717 ns | 27.580 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.803 ns | 0.0143 ns | 0.0134 ns | 11.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.922 ns | 0.0319 ns | 0.0299 ns | 10.918 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.514 ns | 0.0571 ns | 0.0535 ns |  9.542 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.720 ns | 0.0092 ns | 0.0086 ns | 12.719 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.434 ns | 0.0220 ns | 0.0206 ns | 13.441 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.508 ns | 0.0167 ns | 0.0148 ns | 14.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.395 ns | 0.0147 ns | 0.0137 ns | 13.395 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.101 ns | 0.0124 ns | 0.0110 ns | 13.101 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 25.256 ns | 0.0208 ns | 0.0174 ns | 25.258 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.561 ns | 0.0218 ns | 0.0182 ns | 24.564 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.810 ns | 0.0127 ns | 0.0119 ns | 12.813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.480 ns | 0.0137 ns | 0.0115 ns | 11.481 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 10.486 ns | 0.2348 ns | 0.4051 ns | 10.690 ns |  0.79 |    0.04 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.801 ns | 0.0171 ns | 0.0160 ns | 13.805 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.110 ns | 0.0178 ns | 0.0166 ns | 13.105 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.254 ns | 0.0211 ns | 0.0197 ns | 20.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.439 ns | 0.0720 ns | 0.0674 ns | 18.450 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.866 ns | 0.0849 ns | 0.0794 ns | 17.897 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.356 ns | 0.0451 ns | 0.0422 ns | 27.349 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.729 ns | 0.0340 ns | 0.0318 ns | 30.734 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 16.941 ns | 0.0258 ns | 0.0242 ns | 16.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.295 ns | 0.0113 ns | 0.0100 ns | 13.297 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.060 ns | 0.2429 ns | 0.2797 ns | 11.214 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.399 ns | 0.0988 ns | 0.0924 ns | 15.374 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.873 ns | 0.1214 ns | 0.1135 ns | 14.839 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.346 ns | 0.0276 ns | 0.0245 ns | 19.341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.219 ns | 0.0251 ns | 0.0235 ns | 18.225 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.976 ns | 0.0210 ns | 0.0197 ns | 17.974 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.258 ns | 0.0403 ns | 0.0314 ns | 27.271 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 28.498 ns | 0.0397 ns | 0.0371 ns | 28.488 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.713 ns | 0.0102 ns | 0.0095 ns | 12.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.478 ns | 0.0889 ns | 0.0831 ns | 12.457 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.769 ns | 0.0496 ns | 0.0464 ns |  9.778 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.334 ns | 0.0130 ns | 0.0122 ns | 13.332 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.265 ns | 0.0132 ns | 0.0110 ns | 13.268 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.214 ns | 0.0141 ns | 0.0131 ns | 15.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.376 ns | 0.0164 ns | 0.0154 ns | 13.375 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.787 ns | 0.1992 ns | 0.1864 ns | 13.911 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 25.505 ns | 0.0219 ns | 0.0194 ns | 25.498 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.419 ns | 0.0266 ns | 0.0249 ns | 24.422 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.542 ns | 0.0260 ns | 0.0244 ns | 14.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.395 ns | 0.0110 ns | 0.0097 ns | 13.395 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.473 ns | 0.2920 ns | 0.2731 ns | 14.324 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.582 ns | 0.0192 ns | 0.0170 ns | 22.578 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 24.452 ns | 0.0305 ns | 0.0286 ns | 24.460 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.455 ns | 0.0162 ns | 0.0144 ns | 12.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.157 ns | 0.0168 ns | 0.0157 ns | 11.158 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.716 ns | 0.0139 ns | 0.0124 ns | 12.718 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.933 ns | 0.0108 ns | 0.0090 ns | 12.935 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.870 ns | 0.0206 ns | 0.0192 ns | 13.869 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.509 ns | 0.0163 ns | 0.0136 ns | 14.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.387 ns | 0.0182 ns | 0.0142 ns | 13.384 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 15.017 ns | 0.3262 ns | 0.3490 ns | 14.766 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 24.440 ns | 0.0513 ns | 0.0455 ns | 24.438 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 22.562 ns | 0.0302 ns | 0.0268 ns | 22.554 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.156 ns | 0.0187 ns | 0.0175 ns | 18.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.510 ns | 0.0182 ns | 0.0161 ns | 14.510 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.352 ns | 0.2940 ns | 0.2751 ns | 15.176 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.979 ns | 0.0374 ns | 0.0350 ns | 25.981 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 27.336 ns | 0.0294 ns | 0.0261 ns | 27.339 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.416 ns | 0.0310 ns | 0.0290 ns | 18.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.460 ns | 0.0899 ns | 0.0841 ns | 17.497 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.555 ns | 0.0945 ns | 0.0884 ns | 17.513 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 27.663 ns | 0.0536 ns | 0.0475 ns | 27.648 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 26.172 ns | 0.0480 ns | 0.0425 ns | 26.168 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.761 ns | 0.0146 ns | 0.0137 ns | 14.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.360 ns | 0.0165 ns | 0.0146 ns | 13.359 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.876 ns | 0.0235 ns | 0.0220 ns | 12.873 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.719 ns | 0.0174 ns | 0.0162 ns | 22.713 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.359 ns | 0.0399 ns | 0.0353 ns | 24.357 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.512 ns | 0.0244 ns | 0.0228 ns | 14.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.778 ns | 0.0148 ns | 0.0124 ns | 13.776 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.110 ns | 0.0297 ns | 0.0248 ns | 13.107 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.693 ns | 0.0239 ns | 0.0223 ns | 22.690 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 22.813 ns | 0.0198 ns | 0.0175 ns | 22.812 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.037 ns | 0.0130 ns | 0.0108 ns | 14.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.319 ns | 0.0341 ns | 0.0302 ns | 12.325 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.475 ns | 0.0235 ns | 0.0196 ns | 12.467 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 15.000 ns | 0.0194 ns | 0.0181 ns | 14.999 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.002 ns | 0.0262 ns | 0.0232 ns | 15.000 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.353 ns | 0.0349 ns | 0.0292 ns | 16.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.224 ns | 0.0181 ns | 0.0161 ns | 15.223 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.531 ns | 0.0506 ns | 0.0448 ns | 15.533 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.562 ns | 0.0740 ns | 0.0692 ns | 24.568 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.416 ns | 0.0429 ns | 0.0401 ns | 24.416 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.047 ns | 0.0123 ns | 0.0109 ns | 14.048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.203 ns | 0.0164 ns | 0.0146 ns | 12.200 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.591 ns | 0.0446 ns | 0.0396 ns | 12.602 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.294 ns | 0.0085 ns | 0.0079 ns | 14.295 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.026 ns | 0.0256 ns | 0.0240 ns | 15.027 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.762 ns | 0.0148 ns | 0.0131 ns | 14.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.980 ns | 0.0773 ns | 0.0723 ns | 14.012 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.145 ns | 0.0605 ns | 0.0566 ns | 13.123 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 24.596 ns | 0.1012 ns | 0.0947 ns | 24.636 ns |  1.67 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 24.486 ns | 0.0198 ns | 0.0166 ns | 24.487 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.193 ns | 0.0304 ns | 0.0284 ns | 20.184 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.177 ns | 0.0271 ns | 0.0212 ns | 16.176 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.684 ns | 0.0499 ns | 0.0467 ns | 13.684 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.019 ns | 0.0449 ns | 0.0375 ns | 19.011 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 20.010 ns | 0.0471 ns | 0.0441 ns | 20.006 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.953 ns | 0.0182 ns | 0.0170 ns | 18.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.507 ns | 0.0206 ns | 0.0193 ns | 17.514 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.519 ns | 0.0456 ns | 0.0427 ns | 17.513 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.445 ns | 0.0355 ns | 0.0332 ns | 28.450 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 26.758 ns | 0.0410 ns | 0.0383 ns | 26.750 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.799 ns | 0.0211 ns | 0.0187 ns | 20.803 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.459 ns | 0.0743 ns | 0.0659 ns | 16.471 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.133 ns | 0.3096 ns | 0.4237 ns | 13.829 ns |  0.69 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.604 ns | 0.1665 ns | 0.1557 ns | 24.613 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.529 ns | 0.1312 ns | 0.1227 ns | 24.506 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.661 ns | 0.0171 ns | 0.0143 ns | 18.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.518 ns | 0.0448 ns | 0.0397 ns | 17.515 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.043 ns | 0.1954 ns | 0.1827 ns | 19.127 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.617 ns | 0.0374 ns | 0.0350 ns | 26.612 ns |  1.43 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.301 ns | 0.0410 ns | 0.0363 ns | 28.302 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.817 ns | 0.0062 ns | 0.0052 ns | 13.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.980 ns | 0.0104 ns | 0.0087 ns | 11.979 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.910 ns | 0.0256 ns | 0.0240 ns |  9.908 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 22.622 ns | 0.0396 ns | 0.0351 ns | 22.625 ns |  1.64 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.974 ns | 0.0245 ns | 0.0217 ns | 18.978 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.840 ns | 0.0155 ns | 0.0137 ns | 14.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.505 ns | 0.0857 ns | 0.0802 ns | 13.547 ns |  0.91 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.596 ns | 0.0227 ns | 0.0212 ns | 13.593 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.928 ns | 0.0592 ns | 0.0525 ns | 22.939 ns |  1.54 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.643 ns | 0.1128 ns | 0.1055 ns | 22.589 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.124 ns | 0.0164 ns | 0.0145 ns | 13.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.301 ns | 0.0144 ns | 0.0135 ns | 10.303 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.491 ns | 0.0287 ns | 0.0268 ns |  9.495 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.942 ns | 0.0100 ns | 0.0083 ns | 12.943 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.883 ns | 0.0163 ns | 0.0153 ns | 12.880 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.920 ns | 0.0316 ns | 0.0296 ns | 16.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.235 ns | 0.0218 ns | 0.0204 ns | 15.241 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.298 ns | 0.1694 ns | 0.1584 ns | 15.351 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.452 ns | 0.0714 ns | 0.0668 ns | 24.452 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 24.634 ns | 0.0328 ns | 0.0307 ns | 24.638 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 11.785 ns | 0.0125 ns | 0.0097 ns | 11.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.868 ns | 0.0587 ns | 0.0549 ns | 10.876 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.529 ns | 0.0414 ns | 0.0387 ns |  9.543 ns |  0.81 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.379 ns | 0.0606 ns | 0.0567 ns | 12.393 ns |  1.05 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.910 ns | 0.0207 ns | 0.0184 ns | 12.910 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.389 ns | 0.0286 ns | 0.0268 ns | 16.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.227 ns | 0.0203 ns | 0.0170 ns | 15.230 ns |  0.93 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.190 ns | 0.0344 ns | 0.0322 ns | 16.198 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.037 ns | 0.0821 ns | 0.0768 ns | 27.006 ns |  1.65 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.055 ns | 0.0681 ns | 0.0604 ns | 26.046 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.139 ns | 0.0082 ns | 0.0064 ns | 13.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.307 ns | 0.0141 ns | 0.0132 ns | 10.304 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.437 ns | 0.0167 ns | 0.0139 ns |  9.433 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.248 ns | 0.0107 ns | 0.0095 ns | 12.246 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.892 ns | 0.0342 ns | 0.0303 ns | 12.893 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.535 ns | 0.0196 ns | 0.0183 ns | 14.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.519 ns | 0.0709 ns | 0.0664 ns | 13.547 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.196 ns | 0.0514 ns | 0.0480 ns | 13.207 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.607 ns | 0.0736 ns | 0.0689 ns | 22.589 ns |  1.56 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.561 ns | 0.1200 ns | 0.1122 ns | 25.610 ns |  1.76 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.911 ns | 0.0681 ns | 0.0637 ns | 12.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.937 ns | 0.0651 ns | 0.0609 ns | 12.938 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.686 ns | 0.0142 ns | 0.0126 ns |  9.685 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.629 ns | 0.0201 ns | 0.0188 ns | 13.624 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.953 ns | 0.0098 ns | 0.0092 ns | 12.955 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.233 ns | 0.0662 ns | 0.0619 ns | 48.221 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.335 ns | 0.1083 ns | 0.1013 ns | 43.321 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.578 ns | 0.8230 ns | 1.1537 ns | 40.874 ns |  0.83 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 51.497 ns | 0.1717 ns | 0.1522 ns | 51.418 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.559 ns | 0.0692 ns | 0.0613 ns | 50.540 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 16.073 ns | 0.0113 ns | 0.0094 ns | 16.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.992 ns | 0.0315 ns | 0.0295 ns | 12.985 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.485 ns | 0.0363 ns | 0.0322 ns | 10.492 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.921 ns | 0.0170 ns | 0.0150 ns | 13.925 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.464 ns | 0.0507 ns | 0.0474 ns | 13.485 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 47.636 ns | 0.0713 ns | 0.0632 ns | 47.635 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.627 ns | 0.0565 ns | 0.0528 ns | 43.632 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.656 ns | 0.7173 ns | 0.6710 ns | 41.825 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 55.927 ns | 0.1838 ns | 0.1535 ns | 55.909 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 51.904 ns | 0.0696 ns | 0.0543 ns | 51.907 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.305 ns | 0.0092 ns | 0.0086 ns | 13.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.498 ns | 0.0130 ns | 0.0122 ns | 11.497 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.690 ns | 0.0126 ns | 0.0111 ns |  9.688 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.865 ns | 0.0292 ns | 0.0273 ns | 12.870 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.734 ns | 0.0183 ns | 0.0171 ns | 12.732 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.507 ns | 0.0104 ns | 0.0093 ns | 14.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.401 ns | 0.0168 ns | 0.0157 ns | 13.400 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.0210 ns | 0.0196 ns | 13.106 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.643 ns | 0.0212 ns | 0.0199 ns | 22.646 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 23.084 ns | 0.0485 ns | 0.0453 ns | 23.087 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.053 ns | 0.0255 ns | 0.0238 ns | 14.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.215 ns | 0.0128 ns | 0.0107 ns | 12.218 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.707 ns | 0.2925 ns | 0.4467 ns | 13.940 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.288 ns | 0.0214 ns | 0.0200 ns | 14.282 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.971 ns | 0.0181 ns | 0.0160 ns | 14.973 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.939 ns | 0.0356 ns | 0.0316 ns | 16.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.764 ns | 0.0216 ns | 0.0202 ns | 15.765 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.700 ns | 0.3308 ns | 0.4301 ns | 16.038 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.589 ns | 0.0291 ns | 0.0243 ns | 24.593 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.726 ns | 0.0737 ns | 0.0689 ns | 24.728 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.053 ns | 0.0172 ns | 0.0161 ns | 14.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.209 ns | 0.0152 ns | 0.0142 ns | 12.211 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 15.298 ns | 0.3320 ns | 0.8017 ns | 15.564 ns |  1.02 |    0.10 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.016 ns | 0.0138 ns | 0.0122 ns | 15.020 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.310 ns | 0.0191 ns | 0.0160 ns | 14.310 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.499 ns | 0.0223 ns | 0.0209 ns | 14.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.745 ns | 0.0121 ns | 0.0107 ns | 14.745 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.132 ns | 0.0095 ns | 0.0089 ns | 13.131 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 23.933 ns | 0.3180 ns | 0.2975 ns | 23.982 ns |  1.65 |    0.02 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.523 ns | 0.0228 ns | 0.0202 ns | 22.520 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.672 ns | 0.0928 ns | 0.0868 ns | 42.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.914 ns | 0.0335 ns | 0.0313 ns | 38.904 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.645 ns | 0.2348 ns | 0.2197 ns | 39.687 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.772 ns | 0.0807 ns | 0.0755 ns | 40.774 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 45.796 ns | 0.0781 ns | 0.0692 ns | 45.786 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.059 ns | 0.0281 ns | 0.0220 ns | 17.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 20.783 ns | 0.0448 ns | 0.0419 ns | 20.774 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.829 ns | 0.2622 ns | 0.2453 ns | 15.679 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.464 ns | 0.0503 ns | 0.0470 ns | 24.458 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 26.413 ns | 0.1434 ns | 0.1341 ns | 26.353 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.636 ns | 0.1680 ns | 0.1571 ns | 42.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.687 ns | 0.0416 ns | 0.0389 ns | 38.685 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.483 ns | 0.1820 ns | 0.1703 ns | 38.433 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.144 ns | 0.0736 ns | 0.0689 ns | 41.120 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.451 ns | 0.0509 ns | 0.0476 ns | 41.425 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.814 ns | 0.0180 ns | 0.0160 ns | 16.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.709 ns | 0.0225 ns | 0.0199 ns | 15.708 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.005 ns | 0.3666 ns | 0.4364 ns | 17.347 ns |  1.00 |    0.03 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.692 ns | 0.0490 ns | 0.0409 ns | 24.688 ns |  1.47 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 24.546 ns | 0.0854 ns | 0.0799 ns | 24.539 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.060 ns | 0.0749 ns | 0.0701 ns | 42.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 40.200 ns | 0.0520 ns | 0.0486 ns | 40.186 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.899 ns | 0.7554 ns | 1.3622 ns | 35.994 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.189 ns | 0.0307 ns | 0.0256 ns | 42.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 41.518 ns | 0.1591 ns | 0.1488 ns | 41.491 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.657 ns | 0.0148 ns | 0.0131 ns | 14.657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.386 ns | 0.0109 ns | 0.0102 ns | 13.387 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.197 ns | 0.0636 ns | 0.0595 ns | 13.217 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 21.495 ns | 0.0531 ns | 0.0497 ns | 21.495 ns |  1.47 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 24.322 ns | 0.0293 ns | 0.0245 ns | 24.322 ns |  1.66 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ShortNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ShortNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
