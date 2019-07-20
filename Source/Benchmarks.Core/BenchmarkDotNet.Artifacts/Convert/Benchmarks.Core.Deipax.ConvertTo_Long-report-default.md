
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
                                             From_Bool | .NET Core 2.0 | 12.960 ns | 0.0153 ns | 0.0143 ns | 12.960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.615 ns | 0.0133 ns | 0.0118 ns | 10.617 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.379 ns | 0.0091 ns | 0.0080 ns |  7.377 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.803 ns | 0.0230 ns | 0.0204 ns | 12.796 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 11.913 ns | 0.0288 ns | 0.0241 ns | 11.909 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.393 ns | 0.0485 ns | 0.0430 ns | 18.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.324 ns | 0.0449 ns | 0.0420 ns | 15.331 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.527 ns | 0.0720 ns | 0.0638 ns | 16.505 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 18.505 ns | 0.0771 ns | 0.0721 ns | 18.538 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.746 ns | 0.0506 ns | 0.0448 ns | 20.752 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.987 ns | 0.0246 ns | 0.0230 ns | 11.982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.317 ns | 0.0179 ns | 0.0168 ns | 10.317 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.278 ns | 0.0064 ns | 0.0056 ns |  7.277 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.591 ns | 0.0260 ns | 0.0243 ns | 12.589 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.771 ns | 0.0177 ns | 0.0148 ns | 12.769 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.965 ns | 0.0263 ns | 0.0219 ns | 17.964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.222 ns | 0.0270 ns | 0.0253 ns | 15.224 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.445 ns | 0.0346 ns | 0.0306 ns | 16.450 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.828 ns | 0.0413 ns | 0.0386 ns | 18.828 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.929 ns | 0.0478 ns | 0.0399 ns | 20.937 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.572 ns | 0.0168 ns | 0.0157 ns | 11.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  9.961 ns | 0.0086 ns | 0.0076 ns |  9.960 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.061 ns | 0.0183 ns | 0.0143 ns |  7.056 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.690 ns | 0.0108 ns | 0.0096 ns | 11.687 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.555 ns | 0.0263 ns | 0.0246 ns | 10.549 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.359 ns | 0.0116 ns | 0.0103 ns | 14.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.856 ns | 0.0117 ns | 0.0098 ns | 11.858 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.796 ns | 0.2784 ns | 0.4416 ns | 12.959 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.324 ns | 0.0677 ns | 0.0633 ns | 13.292 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 16.929 ns | 0.0350 ns | 0.0327 ns | 16.933 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.511 ns | 0.0178 ns | 0.0167 ns | 11.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  9.973 ns | 0.0072 ns | 0.0056 ns |  9.974 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.612 ns | 0.0089 ns | 0.0083 ns |  6.611 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.811 ns | 0.0146 ns | 0.0136 ns | 11.808 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.328 ns | 0.0129 ns | 0.0121 ns | 10.327 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 17.915 ns | 0.0366 ns | 0.0286 ns | 17.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 14.741 ns | 0.0162 ns | 0.0144 ns | 14.741 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.229 ns | 0.1206 ns | 0.1128 ns | 15.262 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 20.981 ns | 0.0374 ns | 0.0350 ns | 20.981 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.749 ns | 0.0352 ns | 0.0329 ns | 20.757 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.754 ns | 0.0172 ns | 0.0161 ns | 11.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.291 ns | 0.0281 ns | 0.0263 ns | 10.295 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.013 ns | 0.0334 ns | 0.0312 ns |  7.020 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.368 ns | 0.0256 ns | 0.0240 ns | 12.358 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.640 ns | 0.0689 ns | 0.0644 ns | 10.680 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.892 ns | 0.0372 ns | 0.0330 ns | 17.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.984 ns | 0.0178 ns | 0.0149 ns | 14.985 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.017 ns | 0.0328 ns | 0.0307 ns | 15.011 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.772 ns | 0.0274 ns | 0.0256 ns | 18.771 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.074 ns | 0.0302 ns | 0.0283 ns | 20.068 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.345 ns | 0.0168 ns | 0.0149 ns | 12.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  9.966 ns | 0.0111 ns | 0.0093 ns |  9.968 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.092 ns | 0.0423 ns | 0.0396 ns |  7.071 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.701 ns | 0.0120 ns | 0.0094 ns | 11.702 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.878 ns | 0.0108 ns | 0.0096 ns | 11.878 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.049 ns | 0.0181 ns | 0.0151 ns | 14.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.933 ns | 0.0123 ns | 0.0115 ns | 11.933 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.851 ns | 0.0196 ns | 0.0174 ns | 12.854 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 14.132 ns | 0.0110 ns | 0.0086 ns | 14.132 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.441 ns | 0.0200 ns | 0.0187 ns | 15.442 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.608 ns | 0.0756 ns | 0.0707 ns | 11.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 |  9.963 ns | 0.0131 ns | 0.0116 ns |  9.963 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.610 ns | 0.0112 ns | 0.0105 ns |  6.609 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.481 ns | 0.0073 ns | 0.0057 ns | 12.482 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.314 ns | 0.0173 ns | 0.0144 ns | 10.310 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.665 ns | 0.3034 ns | 0.2838 ns | 18.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 15.820 ns | 0.0696 ns | 0.0651 ns | 15.852 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.708 ns | 0.0875 ns | 0.0819 ns | 15.738 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.356 ns | 0.0439 ns | 0.0367 ns | 18.358 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.976 ns | 0.0753 ns | 0.0667 ns | 19.985 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.843 ns | 0.0963 ns | 0.0901 ns | 11.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.279 ns | 0.1708 ns | 0.1514 ns | 10.196 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.556 ns | 0.0075 ns | 0.0070 ns |  7.555 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.904 ns | 0.0190 ns | 0.0177 ns | 12.904 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.683 ns | 0.0107 ns | 0.0100 ns | 11.681 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.955 ns | 0.0175 ns | 0.0163 ns | 20.954 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.785 ns | 0.0992 ns | 0.0927 ns | 15.741 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.467 ns | 0.0433 ns | 0.0405 ns | 17.460 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 20.615 ns | 0.0283 ns | 0.0264 ns | 20.617 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 20.337 ns | 0.0361 ns | 0.0320 ns | 20.335 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.566 ns | 0.0178 ns | 0.0158 ns | 11.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  9.965 ns | 0.0176 ns | 0.0164 ns |  9.966 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.118 ns | 0.1295 ns | 0.1211 ns |  7.184 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.740 ns | 0.0628 ns | 0.0588 ns | 11.773 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.474 ns | 0.0653 ns | 0.0611 ns | 10.505 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.179 ns | 0.0594 ns | 0.0556 ns | 14.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.858 ns | 0.0166 ns | 0.0147 ns | 11.859 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.987 ns | 0.0600 ns | 0.0561 ns | 11.970 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.881 ns | 0.0084 ns | 0.0079 ns | 13.881 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 14.894 ns | 0.0196 ns | 0.0183 ns | 14.895 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.845 ns | 0.0113 ns | 0.0106 ns | 11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.944 ns | 0.0556 ns | 0.0520 ns | 10.966 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.589 ns | 0.0138 ns | 0.0122 ns |  7.587 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.992 ns | 0.0213 ns | 0.0199 ns | 12.994 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 11.805 ns | 0.0086 ns | 0.0077 ns | 11.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.569 ns | 0.0139 ns | 0.0123 ns | 12.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.060 ns | 0.0097 ns | 0.0086 ns | 11.062 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.305 ns | 0.1580 ns | 0.1478 ns |  8.380 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.264 ns | 0.0247 ns | 0.0231 ns | 13.272 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.590 ns | 0.0158 ns | 0.0140 ns | 12.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.605 ns | 0.0133 ns | 0.0124 ns | 12.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.631 ns | 0.0167 ns | 0.0148 ns | 12.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.079 ns | 0.0127 ns | 0.0119 ns |  8.077 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.909 ns | 0.0258 ns | 0.0241 ns | 13.904 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 12.752 ns | 0.0636 ns | 0.0595 ns | 12.736 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.389 ns | 0.0132 ns | 0.0117 ns | 14.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.852 ns | 0.0127 ns | 0.0112 ns | 11.855 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.139 ns | 0.2861 ns | 0.3619 ns | 13.246 ns |  0.91 |    0.03 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.299 ns | 0.0450 ns | 0.0421 ns | 13.300 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.908 ns | 0.0172 ns | 0.0153 ns | 14.913 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.175 ns | 0.1260 ns | 0.1179 ns | 24.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.622 ns | 0.0303 ns | 0.0253 ns | 20.618 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.672 ns | 0.2988 ns | 0.2935 ns | 13.852 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 23.661 ns | 0.0466 ns | 0.0413 ns | 23.659 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.906 ns | 0.0227 ns | 0.0202 ns | 22.901 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.845 ns | 0.0212 ns | 0.0199 ns | 26.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.821 ns | 0.0268 ns | 0.0238 ns | 24.825 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 19.504 ns | 0.0819 ns | 0.0766 ns | 19.487 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 28.286 ns | 0.1433 ns | 0.1341 ns | 28.217 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.536 ns | 0.0339 ns | 0.0300 ns | 27.536 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.244 ns | 0.1230 ns | 0.1151 ns | 22.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.246 ns | 0.0290 ns | 0.0257 ns | 21.243 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.778 ns | 0.0921 ns | 0.0861 ns | 15.732 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.567 ns | 0.0296 ns | 0.0263 ns | 23.573 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.687 ns | 0.0167 ns | 0.0156 ns | 23.683 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.658 ns | 0.0292 ns | 0.0259 ns | 26.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.567 ns | 0.0257 ns | 0.0240 ns | 24.571 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.175 ns | 0.0192 ns | 0.0150 ns | 20.171 ns |  0.76 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.875 ns | 0.0281 ns | 0.0262 ns | 26.871 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 28.469 ns | 0.0366 ns | 0.0343 ns | 28.463 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.520 ns | 0.0145 ns | 0.0121 ns | 12.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.365 ns | 0.0110 ns | 0.0098 ns | 11.367 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.132 ns | 0.0905 ns | 0.0847 ns |  8.188 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.807 ns | 0.0176 ns | 0.0156 ns | 14.806 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.568 ns | 0.0968 ns | 0.0906 ns | 13.603 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.448 ns | 0.0218 ns | 0.0204 ns | 14.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.246 ns | 0.0090 ns | 0.0080 ns | 12.244 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.892 ns | 0.0116 ns | 0.0097 ns | 11.893 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.236 ns | 0.0463 ns | 0.0433 ns | 13.223 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.745 ns | 0.0260 ns | 0.0244 ns | 15.749 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.923 ns | 0.0203 ns | 0.0190 ns | 13.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.490 ns | 0.0231 ns | 0.0205 ns | 11.489 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  8.116 ns | 0.0437 ns | 0.0409 ns |  8.137 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.719 ns | 0.0409 ns | 0.0382 ns | 15.727 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.767 ns | 0.0372 ns | 0.0348 ns | 13.766 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.393 ns | 0.0231 ns | 0.0205 ns | 21.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.159 ns | 0.0123 ns | 0.0115 ns | 17.158 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 16.463 ns | 0.0574 ns | 0.0537 ns | 16.457 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.975 ns | 0.0240 ns | 0.0224 ns | 21.979 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 23.358 ns | 0.0886 ns | 0.0829 ns | 23.316 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.991 ns | 0.0211 ns | 0.0187 ns | 14.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.531 ns | 0.0151 ns | 0.0141 ns | 12.536 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.387 ns | 0.0176 ns | 0.0156 ns | 10.386 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.850 ns | 0.0724 ns | 0.0678 ns | 16.828 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.837 ns | 0.0143 ns | 0.0134 ns | 15.836 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.406 ns | 0.0299 ns | 0.0265 ns | 21.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.548 ns | 0.0302 ns | 0.0236 ns | 17.555 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.486 ns | 0.1034 ns | 0.0968 ns | 16.512 ns |  0.77 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 21.966 ns | 0.0333 ns | 0.0312 ns | 21.961 ns |  1.03 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 23.260 ns | 0.0228 ns | 0.0202 ns | 23.259 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.628 ns | 0.0477 ns | 0.0423 ns | 12.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.368 ns | 0.0449 ns | 0.0398 ns | 11.381 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.173 ns | 0.1829 ns | 0.1796 ns |  8.167 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.507 ns | 0.0314 ns | 0.0293 ns | 13.500 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.683 ns | 0.0142 ns | 0.0126 ns | 12.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.045 ns | 0.0186 ns | 0.0165 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.850 ns | 0.0104 ns | 0.0098 ns | 11.847 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.668 ns | 0.1973 ns | 0.1846 ns | 12.704 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.313 ns | 0.0509 ns | 0.0476 ns | 13.327 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 15.002 ns | 0.0679 ns | 0.0635 ns | 15.023 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.589 ns | 0.0738 ns | 0.0690 ns | 11.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 |  9.959 ns | 0.0110 ns | 0.0092 ns |  9.957 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.799 ns | 0.0342 ns | 0.0320 ns |  6.783 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.391 ns | 0.0089 ns | 0.0079 ns | 13.390 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 11.775 ns | 0.0156 ns | 0.0138 ns | 11.775 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.101 ns | 0.0209 ns | 0.0195 ns | 18.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 14.995 ns | 0.0278 ns | 0.0260 ns | 14.991 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.265 ns | 0.0455 ns | 0.0380 ns | 15.266 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.243 ns | 0.0258 ns | 0.0216 ns | 21.236 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.377 ns | 0.0341 ns | 0.0319 ns | 20.382 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.759 ns | 0.0237 ns | 0.0210 ns | 11.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.170 ns | 0.0123 ns | 0.0115 ns | 10.169 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  7.020 ns | 0.0200 ns | 0.0187 ns |  7.025 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.109 ns | 0.0170 ns | 0.0159 ns | 12.106 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.569 ns | 0.0155 ns | 0.0145 ns | 10.571 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.052 ns | 0.0336 ns | 0.0315 ns | 18.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.993 ns | 0.0176 ns | 0.0156 ns | 14.999 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.205 ns | 0.0613 ns | 0.0573 ns | 15.206 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.243 ns | 0.0361 ns | 0.0320 ns | 21.245 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.351 ns | 0.0383 ns | 0.0340 ns | 20.360 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.578 ns | 0.0141 ns | 0.0117 ns | 11.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.043 ns | 0.0338 ns | 0.0316 ns | 10.052 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.507 ns | 0.1776 ns | 0.2372 ns |  7.356 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.690 ns | 0.0151 ns | 0.0134 ns | 11.691 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.434 ns | 0.0184 ns | 0.0163 ns | 10.434 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.061 ns | 0.0138 ns | 0.0130 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.862 ns | 0.0128 ns | 0.0120 ns | 11.859 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.818 ns | 0.0210 ns | 0.0196 ns | 12.821 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.246 ns | 0.0119 ns | 0.0099 ns | 13.249 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 15.992 ns | 0.0292 ns | 0.0273 ns | 15.996 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.554 ns | 0.0118 ns | 0.0105 ns | 11.556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 |  9.965 ns | 0.0109 ns | 0.0091 ns |  9.964 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.607 ns | 0.0106 ns | 0.0094 ns |  6.608 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.523 ns | 0.0175 ns | 0.0146 ns | 12.521 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.837 ns | 0.0150 ns | 0.0125 ns | 10.835 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.967 ns | 0.0623 ns | 0.0552 ns | 18.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 14.973 ns | 0.0246 ns | 0.0218 ns | 14.968 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.480 ns | 0.1957 ns | 0.1831 ns | 15.585 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.015 ns | 0.0153 ns | 0.0135 ns | 19.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.300 ns | 0.0176 ns | 0.0156 ns | 20.297 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.537 ns | 0.0128 ns | 0.0119 ns | 12.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.264 ns | 0.0554 ns | 0.0518 ns | 10.286 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  6.992 ns | 0.0805 ns | 0.0753 ns |  6.938 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.865 ns | 0.0340 ns | 0.0318 ns | 12.867 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.597 ns | 0.0107 ns | 0.0100 ns | 10.597 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.100 ns | 0.0236 ns | 0.0184 ns | 18.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.769 ns | 0.0220 ns | 0.0206 ns | 14.773 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.255 ns | 0.0346 ns | 0.0324 ns | 15.245 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.941 ns | 0.0420 ns | 0.0372 ns | 18.938 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 20.187 ns | 0.0223 ns | 0.0187 ns | 20.190 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.474 ns | 0.0462 ns | 0.0432 ns | 12.483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 |  9.955 ns | 0.0103 ns | 0.0096 ns |  9.956 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.033 ns | 0.1486 ns | 0.1390 ns |  7.133 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.687 ns | 0.0143 ns | 0.0127 ns | 11.683 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.490 ns | 0.0250 ns | 0.0234 ns | 10.483 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.046 ns | 0.0135 ns | 0.0120 ns | 14.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.856 ns | 0.0157 ns | 0.0139 ns | 11.854 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.565 ns | 0.1299 ns | 0.1215 ns | 12.562 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.303 ns | 0.0223 ns | 0.0208 ns | 13.299 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 14.923 ns | 0.0255 ns | 0.0226 ns | 14.928 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.838 ns | 0.1048 ns | 0.0981 ns | 13.769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 |  9.976 ns | 0.0176 ns | 0.0156 ns |  9.977 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.851 ns | 0.0158 ns | 0.0140 ns |  6.846 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.310 ns | 0.0135 ns | 0.0126 ns | 10.309 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.644 ns | 0.1887 ns | 0.1766 ns | 12.708 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 14.621 ns | 0.0240 ns | 0.0224 ns | 14.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 12.471 ns | 0.0119 ns | 0.0105 ns | 12.470 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 13.453 ns | 0.2950 ns | 0.4763 ns | 13.684 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 14.439 ns | 0.0366 ns | 0.0343 ns | 14.438 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 15.754 ns | 0.0423 ns | 0.0396 ns | 15.736 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.541 ns | 0.0203 ns | 0.0190 ns | 12.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.337 ns | 0.0668 ns | 0.0625 ns | 11.299 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.030 ns | 0.1500 ns | 0.1403 ns |  7.929 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 12.969 ns | 0.0238 ns | 0.0211 ns | 12.966 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 12.949 ns | 0.0112 ns | 0.0105 ns | 12.946 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.740 ns | 0.0599 ns | 0.0500 ns | 14.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.490 ns | 0.0177 ns | 0.0166 ns | 12.485 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.913 ns | 0.2556 ns | 0.2625 ns | 11.719 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 14.557 ns | 0.0595 ns | 0.0557 ns | 14.535 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 15.919 ns | 0.0666 ns | 0.0591 ns | 15.935 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.424 ns | 0.0588 ns | 0.0550 ns | 12.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.189 ns | 0.0172 ns | 0.0152 ns | 11.190 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.320 ns | 0.2133 ns | 0.4006 ns |  9.440 ns |  0.73 |    0.05 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.530 ns | 0.0129 ns | 0.0114 ns | 13.531 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.763 ns | 0.0243 ns | 0.0227 ns | 12.759 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.101 ns | 0.0735 ns | 0.0688 ns | 14.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.251 ns | 0.0099 ns | 0.0093 ns | 12.251 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.440 ns | 0.0506 ns | 0.0473 ns | 12.461 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.305 ns | 0.0461 ns | 0.0431 ns | 13.288 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.835 ns | 0.0213 ns | 0.0200 ns | 15.832 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.522 ns | 0.0125 ns | 0.0111 ns | 11.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.447 ns | 0.0530 ns | 0.0496 ns | 10.433 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.567 ns | 0.0105 ns | 0.0093 ns |  6.567 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.495 ns | 0.0080 ns | 0.0075 ns | 12.494 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.323 ns | 0.0173 ns | 0.0153 ns | 10.322 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.116 ns | 0.0441 ns | 0.0413 ns | 18.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.202 ns | 0.0216 ns | 0.0191 ns | 16.201 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.291 ns | 0.3522 ns | 0.5586 ns | 16.651 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.744 ns | 0.0196 ns | 0.0174 ns | 18.747 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.120 ns | 0.0278 ns | 0.0247 ns | 20.116 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.209 ns | 0.0099 ns | 0.0083 ns | 12.207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.166 ns | 0.0115 ns | 0.0108 ns | 10.166 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.965 ns | 0.0063 ns | 0.0052 ns |  6.966 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 12.177 ns | 0.0123 ns | 0.0109 ns | 12.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.300 ns | 0.0183 ns | 0.0153 ns | 12.307 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.856 ns | 0.0489 ns | 0.0382 ns | 17.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.011 ns | 0.0234 ns | 0.0208 ns | 15.015 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.971 ns | 0.3601 ns | 0.7438 ns | 17.279 ns |  0.89 |    0.06 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.764 ns | 0.0298 ns | 0.0278 ns | 18.773 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.112 ns | 0.0339 ns | 0.0300 ns | 20.108 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.570 ns | 0.0117 ns | 0.0109 ns | 11.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 |  9.959 ns | 0.0079 ns | 0.0070 ns |  9.959 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.450 ns | 0.0097 ns | 0.0090 ns |  7.451 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.692 ns | 0.0196 ns | 0.0183 ns | 11.693 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.420 ns | 0.0148 ns | 0.0124 ns | 10.419 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.413 ns | 0.0137 ns | 0.0128 ns | 14.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.852 ns | 0.0079 ns | 0.0066 ns | 11.853 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.035 ns | 0.2848 ns | 0.4263 ns | 13.194 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.515 ns | 0.0597 ns | 0.0558 ns | 13.535 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.934 ns | 0.0255 ns | 0.0239 ns | 14.933 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.068 ns | 0.0283 ns | 0.0251 ns | 14.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.500 ns | 0.0173 ns | 0.0162 ns | 11.504 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.096 ns | 0.2046 ns | 0.4040 ns |  9.259 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.895 ns | 0.0072 ns | 0.0064 ns | 15.893 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.060 ns | 0.0154 ns | 0.0144 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.613 ns | 0.0270 ns | 0.0253 ns | 21.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.711 ns | 0.0830 ns | 0.0776 ns | 17.721 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 16.347 ns | 0.0342 ns | 0.0303 ns | 16.343 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.826 ns | 0.0223 ns | 0.0209 ns | 21.830 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 23.558 ns | 0.0222 ns | 0.0196 ns | 23.559 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.825 ns | 0.1153 ns | 0.1079 ns | 13.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.558 ns | 0.0152 ns | 0.0142 ns | 11.560 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.888 ns | 0.0097 ns | 0.0081 ns |  8.890 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.305 ns | 0.0195 ns | 0.0182 ns | 15.303 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.586 ns | 0.0140 ns | 0.0131 ns | 13.586 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.269 ns | 0.0296 ns | 0.0277 ns | 21.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.156 ns | 0.0212 ns | 0.0177 ns | 17.154 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.569 ns | 0.1179 ns | 0.1103 ns | 16.597 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.900 ns | 0.0337 ns | 0.0315 ns | 21.896 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.568 ns | 0.0204 ns | 0.0181 ns | 23.572 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.592 ns | 0.0105 ns | 0.0093 ns | 11.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.020 ns | 0.0278 ns | 0.0246 ns | 10.022 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.105 ns | 0.0304 ns | 0.0284 ns |  7.095 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.768 ns | 0.0169 ns | 0.0158 ns | 11.768 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.556 ns | 0.0153 ns | 0.0135 ns | 10.557 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.180 ns | 0.0461 ns | 0.0431 ns | 14.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.848 ns | 0.0058 ns | 0.0048 ns | 11.847 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.253 ns | 0.0210 ns | 0.0186 ns | 11.252 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.787 ns | 0.0246 ns | 0.0230 ns | 15.787 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 15.454 ns | 0.0252 ns | 0.0223 ns | 15.451 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.726 ns | 0.0603 ns | 0.0535 ns | 59.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 49.930 ns | 0.0545 ns | 0.0510 ns | 49.930 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.545 ns | 0.3553 ns | 0.3324 ns | 20.425 ns |  0.34 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 60.550 ns | 0.2286 ns | 0.2138 ns | 60.610 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 61.946 ns | 0.1288 ns | 0.1204 ns | 61.976 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 65.099 ns | 0.3778 ns | 0.3534 ns | 64.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 56.620 ns | 0.0646 ns | 0.0604 ns | 56.604 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.385 ns | 0.2150 ns | 0.2011 ns | 25.387 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.954 ns | 0.1659 ns | 0.1552 ns | 63.931 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 66.423 ns | 0.1755 ns | 0.1465 ns | 66.376 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.328 ns | 0.0126 ns | 0.0112 ns | 12.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.390 ns | 0.0125 ns | 0.0098 ns | 11.390 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.548 ns | 0.0111 ns | 0.0087 ns | 11.549 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.727 ns | 0.0218 ns | 0.0194 ns | 12.721 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 16.538 ns | 0.0470 ns | 0.0416 ns | 16.544 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.046 ns | 0.0162 ns | 0.0136 ns | 14.045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.196 ns | 0.0137 ns | 0.0128 ns | 13.195 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.430 ns | 0.0599 ns | 0.0531 ns | 11.446 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.854 ns | 0.0141 ns | 0.0132 ns | 15.855 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.718 ns | 0.0160 ns | 0.0133 ns | 15.719 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.631 ns | 0.0372 ns | 0.0348 ns | 13.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.402 ns | 0.0161 ns | 0.0151 ns | 11.402 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.065 ns | 0.0091 ns | 0.0080 ns | 11.067 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.710 ns | 0.0212 ns | 0.0188 ns | 12.709 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 16.053 ns | 0.0890 ns | 0.0833 ns | 16.009 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.503 ns | 0.0114 ns | 0.0101 ns | 11.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  9.988 ns | 0.0074 ns | 0.0062 ns |  9.989 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.169 ns | 0.1654 ns | 0.2208 ns |  7.240 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.473 ns | 0.0158 ns | 0.0140 ns | 12.469 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.516 ns | 0.1125 ns | 0.1052 ns | 11.538 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 17.856 ns | 0.0330 ns | 0.0293 ns | 17.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 14.977 ns | 0.0188 ns | 0.0176 ns | 14.981 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.306 ns | 0.0806 ns | 0.0754 ns | 15.290 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.014 ns | 0.0186 ns | 0.0155 ns | 21.017 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.050 ns | 0.0315 ns | 0.0295 ns | 20.047 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.750 ns | 0.0181 ns | 0.0170 ns | 11.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.243 ns | 0.0394 ns | 0.0350 ns | 10.254 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.945 ns | 0.0100 ns | 0.0094 ns |  6.943 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.831 ns | 0.0228 ns | 0.0202 ns | 12.823 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.550 ns | 0.0093 ns | 0.0078 ns | 10.550 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.179 ns | 0.1071 ns | 0.0949 ns | 18.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.947 ns | 0.0233 ns | 0.0218 ns | 14.946 ns |  0.82 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.267 ns | 0.0439 ns | 0.0411 ns | 15.278 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.977 ns | 0.0236 ns | 0.0221 ns | 18.975 ns |  1.04 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.283 ns | 0.0245 ns | 0.0229 ns | 20.290 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.571 ns | 0.0122 ns | 0.0101 ns | 11.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 |  9.969 ns | 0.0278 ns | 0.0260 ns |  9.960 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.769 ns | 0.0124 ns | 0.0104 ns |  6.770 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.372 ns | 0.0138 ns | 0.0122 ns | 12.374 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.432 ns | 0.0338 ns | 0.0316 ns | 10.417 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.962 ns | 0.0798 ns | 0.0747 ns | 13.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.864 ns | 0.0109 ns | 0.0102 ns | 11.864 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.718 ns | 0.2750 ns | 0.3056 ns | 12.608 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.295 ns | 0.0192 ns | 0.0179 ns | 13.295 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 15.841 ns | 0.0233 ns | 0.0218 ns | 15.837 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.016 ns | 0.0105 ns | 0.0098 ns | 12.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.059 ns | 0.0137 ns | 0.0122 ns | 10.057 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.844 ns | 0.0167 ns | 0.0156 ns |  6.842 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.830 ns | 0.0126 ns | 0.0112 ns | 11.828 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.452 ns | 0.0159 ns | 0.0133 ns | 10.448 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 17.879 ns | 0.0313 ns | 0.0261 ns | 17.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.005 ns | 0.0188 ns | 0.0157 ns | 16.007 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.687 ns | 0.0594 ns | 0.0526 ns | 15.685 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.114 ns | 0.0582 ns | 0.0544 ns | 19.139 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.358 ns | 0.0324 ns | 0.0303 ns | 20.359 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.343 ns | 0.0406 ns | 0.0360 ns | 12.351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.159 ns | 0.0134 ns | 0.0104 ns | 10.157 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.036 ns | 0.1377 ns | 0.1288 ns |  6.940 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.115 ns | 0.0127 ns | 0.0112 ns | 12.112 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.577 ns | 0.0118 ns | 0.0105 ns | 10.576 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.881 ns | 0.0223 ns | 0.0209 ns | 17.877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.979 ns | 0.0162 ns | 0.0152 ns | 14.980 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.070 ns | 0.0536 ns | 0.0502 ns | 15.081 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.965 ns | 0.0208 ns | 0.0184 ns | 18.966 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.378 ns | 0.0281 ns | 0.0263 ns | 20.383 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.627 ns | 0.0138 ns | 0.0129 ns | 13.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  9.981 ns | 0.0204 ns | 0.0191 ns |  9.978 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.915 ns | 0.0455 ns | 0.0425 ns |  6.925 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.415 ns | 0.0148 ns | 0.0139 ns | 12.416 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.417 ns | 0.0152 ns | 0.0135 ns | 10.414 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.060 ns | 0.0117 ns | 0.0104 ns | 14.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.280 ns | 0.0180 ns | 0.0168 ns | 12.280 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.008 ns | 0.0789 ns | 0.0738 ns | 11.977 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 15.833 ns | 0.0165 ns | 0.0146 ns | 15.836 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 16.162 ns | 0.0938 ns | 0.0877 ns | 16.193 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.594 ns | 0.0204 ns | 0.0181 ns | 11.596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.176 ns | 0.0114 ns | 0.0107 ns | 10.176 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.890 ns | 0.0095 ns | 0.0088 ns |  6.893 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.508 ns | 0.0520 ns | 0.0486 ns | 13.535 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.437 ns | 0.0105 ns | 0.0088 ns | 12.439 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.554 ns | 0.0258 ns | 0.0241 ns | 18.561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.006 ns | 0.0227 ns | 0.0201 ns | 14.999 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 14.950 ns | 0.0480 ns | 0.0375 ns | 14.950 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.670 ns | 0.0320 ns | 0.0283 ns | 19.664 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.004 ns | 0.0232 ns | 0.0217 ns | 20.996 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.730 ns | 0.0348 ns | 0.0291 ns | 12.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.452 ns | 0.0125 ns | 0.0111 ns | 11.452 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.127 ns | 0.0163 ns | 0.0153 ns |  8.126 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.321 ns | 0.0858 ns | 0.0803 ns | 15.356 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.503 ns | 0.0130 ns | 0.0122 ns | 14.504 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.233 ns | 0.0503 ns | 0.0471 ns | 18.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.026 ns | 0.0189 ns | 0.0176 ns | 15.022 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.894 ns | 0.1711 ns | 0.1600 ns | 15.881 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.752 ns | 0.0465 ns | 0.0435 ns | 19.766 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 20.995 ns | 0.0340 ns | 0.0301 ns | 20.998 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.757 ns | 0.0127 ns | 0.0118 ns | 13.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.364 ns | 0.0100 ns | 0.0089 ns | 11.365 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.292 ns | 0.0820 ns | 0.0767 ns |  8.335 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.940 ns | 0.0177 ns | 0.0157 ns | 13.946 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.536 ns | 0.0790 ns | 0.0739 ns | 13.571 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.105 ns | 0.0734 ns | 0.0686 ns | 14.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.037 ns | 0.0116 ns | 0.0097 ns | 13.036 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.387 ns | 0.0720 ns | 0.0674 ns | 13.422 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.341 ns | 0.0466 ns | 0.0413 ns | 13.359 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 14.905 ns | 0.0144 ns | 0.0128 ns | 14.903 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.057 ns | 0.0105 ns | 0.0093 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 11.840 ns | 0.0107 ns | 0.0095 ns | 11.842 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 12.742 ns | 0.2687 ns | 0.2759 ns | 12.541 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.213 ns | 0.0191 ns | 0.0169 ns | 13.217 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 15.008 ns | 0.0695 ns | 0.0650 ns | 15.025 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.536 ns | 0.0139 ns | 0.0123 ns | 11.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.023 ns | 0.0133 ns | 0.0118 ns |  9.025 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.345 ns | 0.1272 ns | 0.1189 ns | 11.270 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.002 ns | 0.0191 ns | 0.0160 ns | 11.006 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 11.182 ns | 0.0150 ns | 0.0140 ns | 11.183 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.196 ns | 0.0695 ns | 0.0616 ns | 14.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 11.841 ns | 0.0145 ns | 0.0128 ns | 11.842 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.597 ns | 0.2288 ns | 0.2140 ns | 12.633 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 15.933 ns | 0.0215 ns | 0.0201 ns | 15.934 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 14.932 ns | 0.0530 ns | 0.0495 ns | 14.919 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 19.618 ns | 0.0199 ns | 0.0186 ns | 19.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.338 ns | 0.0151 ns | 0.0134 ns | 13.336 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.033 ns | 0.2136 ns | 0.1998 ns | 12.976 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.704 ns | 0.0320 ns | 0.0284 ns | 16.703 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.837 ns | 0.0406 ns | 0.0380 ns | 16.839 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.577 ns | 0.0979 ns | 0.0916 ns | 16.550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.735 ns | 0.0237 ns | 0.0211 ns | 15.731 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.399 ns | 0.0457 ns | 0.0427 ns | 14.399 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.690 ns | 0.0538 ns | 0.0503 ns | 16.699 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.574 ns | 0.0275 ns | 0.0244 ns | 18.579 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.375 ns | 0.0124 ns | 0.0110 ns | 13.372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.366 ns | 0.0174 ns | 0.0155 ns | 12.362 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.748 ns | 0.0502 ns | 0.0470 ns | 11.733 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.128 ns | 0.0258 ns | 0.0241 ns | 13.136 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.962 ns | 0.0661 ns | 0.0618 ns | 14.985 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.043 ns | 0.0153 ns | 0.0136 ns | 14.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.584 ns | 0.0118 ns | 0.0099 ns | 13.584 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.977 ns | 0.0184 ns | 0.0172 ns | 11.977 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.292 ns | 0.0243 ns | 0.0215 ns | 13.295 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.906 ns | 0.0234 ns | 0.0208 ns | 14.909 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.191 ns | 0.0277 ns | 0.0259 ns | 12.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.119 ns | 0.0168 ns | 0.0157 ns | 11.113 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.246 ns | 0.0106 ns | 0.0100 ns | 11.248 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.316 ns | 0.0157 ns | 0.0147 ns | 12.318 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.537 ns | 0.0307 ns | 0.0272 ns | 12.532 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.011 ns | 0.0996 ns | 0.0932 ns | 14.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.792 ns | 0.0097 ns | 0.0091 ns | 14.795 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.715 ns | 0.0658 ns | 0.0584 ns | 13.738 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 15.121 ns | 0.0244 ns | 0.0228 ns | 15.116 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.594 ns | 0.0188 ns | 0.0167 ns | 16.589 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.794 ns | 0.0129 ns | 0.0121 ns | 11.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.994 ns | 0.0099 ns | 0.0087 ns | 11.993 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.290 ns | 0.0114 ns | 0.0101 ns | 11.293 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.514 ns | 0.0165 ns | 0.0138 ns | 12.514 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.721 ns | 0.0127 ns | 0.0106 ns | 12.722 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.052 ns | 0.0184 ns | 0.0172 ns | 14.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 11.965 ns | 0.0349 ns | 0.0326 ns | 11.971 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.367 ns | 0.2608 ns | 0.2899 ns | 12.553 ns |  0.88 |    0.02 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.960 ns | 0.0699 ns | 0.0654 ns | 15.938 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.040 ns | 0.0622 ns | 0.0551 ns | 15.065 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.810 ns | 0.0863 ns | 0.0765 ns | 19.819 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.099 ns | 0.0250 ns | 0.0209 ns | 16.101 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.858 ns | 0.0426 ns | 0.0399 ns | 11.847 ns |  0.60 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.493 ns | 0.0433 ns | 0.0384 ns | 18.502 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 17.099 ns | 0.0788 ns | 0.0698 ns | 17.085 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.309 ns | 0.0239 ns | 0.0224 ns | 17.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.520 ns | 0.0506 ns | 0.0473 ns | 14.498 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.149 ns | 0.0511 ns | 0.0478 ns | 15.162 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.256 ns | 0.0279 ns | 0.0248 ns | 17.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.370 ns | 0.0351 ns | 0.0328 ns | 19.365 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.134 ns | 0.0301 ns | 0.0267 ns | 19.135 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.752 ns | 0.0466 ns | 0.0413 ns | 15.745 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.434 ns | 0.2896 ns | 0.3662 ns | 13.575 ns |  0.70 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 20.065 ns | 0.0327 ns | 0.0290 ns | 20.064 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.380 ns | 0.0292 ns | 0.0244 ns | 18.385 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.063 ns | 0.0187 ns | 0.0175 ns | 17.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.477 ns | 0.0147 ns | 0.0123 ns | 14.481 ns |  0.85 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.558 ns | 0.1067 ns | 0.0998 ns | 15.526 ns |  0.91 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.236 ns | 0.0312 ns | 0.0276 ns | 17.239 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.024 ns | 0.0783 ns | 0.0732 ns | 20.054 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.104 ns | 0.0126 ns | 0.0112 ns | 13.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.697 ns | 0.0142 ns | 0.0133 ns | 11.698 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.753 ns | 0.0095 ns | 0.0074 ns |  8.757 ns |  0.67 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 11.969 ns | 0.0189 ns | 0.0177 ns | 11.968 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.452 ns | 0.0105 ns | 0.0098 ns | 10.455 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.103 ns | 0.0807 ns | 0.0755 ns | 14.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.843 ns | 0.0120 ns | 0.0106 ns | 11.840 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.483 ns | 0.2359 ns | 0.2207 ns | 12.568 ns |  0.89 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.238 ns | 0.0229 ns | 0.0191 ns | 13.240 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.906 ns | 0.0226 ns | 0.0189 ns | 14.906 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.500 ns | 0.0104 ns | 0.0098 ns | 13.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.543 ns | 0.0411 ns | 0.0364 ns | 11.555 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.902 ns | 0.0446 ns | 0.0418 ns |  6.880 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.782 ns | 0.0177 ns | 0.0157 ns | 11.779 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.774 ns | 0.0709 ns | 0.0663 ns | 11.816 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.953 ns | 0.0252 ns | 0.0223 ns | 14.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.267 ns | 0.0151 ns | 0.0141 ns | 13.267 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.352 ns | 0.2838 ns | 0.2914 ns | 13.134 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.023 ns | 0.0927 ns | 0.0867 ns | 15.004 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.679 ns | 0.0345 ns | 0.0306 ns | 16.673 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.644 ns | 0.0134 ns | 0.0112 ns | 13.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.345 ns | 0.0080 ns | 0.0071 ns | 11.347 ns |  0.83 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.698 ns | 0.3051 ns | 0.4472 ns |  6.469 ns |  0.51 |    0.04 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.501 ns | 0.0414 ns | 0.0323 ns | 12.493 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.290 ns | 0.0125 ns | 0.0098 ns | 10.290 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.415 ns | 0.0300 ns | 0.0281 ns | 15.411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.124 ns | 0.0249 ns | 0.0233 ns | 15.122 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.652 ns | 0.0342 ns | 0.0320 ns | 13.644 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.400 ns | 0.2106 ns | 0.1759 ns | 15.339 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.543 ns | 0.0163 ns | 0.0153 ns | 18.550 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.468 ns | 0.0705 ns | 0.0659 ns | 13.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.362 ns | 0.0166 ns | 0.0147 ns | 11.357 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.588 ns | 0.0088 ns | 0.0078 ns |  6.590 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.805 ns | 0.0207 ns | 0.0162 ns | 11.805 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.286 ns | 0.0118 ns | 0.0111 ns | 10.285 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.053 ns | 0.0084 ns | 0.0078 ns | 14.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.637 ns | 0.0084 ns | 0.0075 ns | 12.636 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.618 ns | 0.2934 ns | 0.3917 ns | 13.798 ns |  0.96 |    0.03 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.948 ns | 0.0112 ns | 0.0099 ns | 13.950 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.476 ns | 0.1003 ns | 0.0938 ns | 15.527 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.789 ns | 0.0122 ns | 0.0102 ns | 12.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.550 ns | 0.0129 ns | 0.0120 ns | 10.550 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.494 ns | 0.1751 ns | 0.2778 ns |  7.593 ns |  0.57 |    0.03 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 11.709 ns | 0.0294 ns | 0.0275 ns | 11.701 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.329 ns | 0.0155 ns | 0.0129 ns | 10.326 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 45.705 ns | 0.2040 ns | 0.1809 ns | 45.730 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 39.195 ns | 0.2309 ns | 0.2159 ns | 39.204 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 34.865 ns | 0.1730 ns | 0.1619 ns | 34.916 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 43.234 ns | 0.1442 ns | 0.1349 ns | 43.203 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 44.982 ns | 0.0867 ns | 0.0769 ns | 44.982 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.939 ns | 0.0220 ns | 0.0206 ns | 13.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.739 ns | 0.0119 ns | 0.0111 ns | 10.739 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.624 ns | 0.0100 ns | 0.0094 ns |  6.625 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.176 ns | 0.0288 ns | 0.0270 ns | 12.170 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.017 ns | 0.0440 ns | 0.0411 ns | 12.020 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 43.822 ns | 0.2791 ns | 0.2611 ns | 43.701 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 38.968 ns | 0.0701 ns | 0.0621 ns | 38.982 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 31.719 ns | 0.0890 ns | 0.0833 ns | 31.723 ns |  0.72 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 45.028 ns | 0.0596 ns | 0.0528 ns | 45.024 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 45.242 ns | 0.0617 ns | 0.0577 ns | 45.246 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 12.966 ns | 0.0129 ns | 0.0114 ns | 12.970 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.454 ns | 0.0115 ns | 0.0090 ns | 10.455 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.649 ns | 0.0342 ns | 0.0320 ns |  6.660 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 11.865 ns | 0.0319 ns | 0.0298 ns | 11.855 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.003 ns | 0.0120 ns | 0.0112 ns | 12.005 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.079 ns | 0.0247 ns | 0.0206 ns | 14.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.868 ns | 0.0117 ns | 0.0091 ns | 11.869 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.360 ns | 0.2300 ns | 0.2151 ns | 12.219 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.302 ns | 0.0180 ns | 0.0160 ns | 13.300 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.910 ns | 0.0194 ns | 0.0162 ns | 14.907 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 11.950 ns | 0.0151 ns | 0.0134 ns | 11.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.112 ns | 0.0128 ns | 0.0107 ns | 11.112 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.191 ns | 0.2477 ns | 0.2544 ns | 11.361 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.443 ns | 0.0224 ns | 0.0199 ns | 12.446 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.565 ns | 0.0241 ns | 0.0225 ns | 12.567 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.467 ns | 0.0182 ns | 0.0161 ns | 15.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.594 ns | 0.0171 ns | 0.0152 ns | 13.588 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.004 ns | 0.1502 ns | 0.1405 ns | 13.987 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.435 ns | 0.0315 ns | 0.0295 ns | 17.440 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.069 ns | 0.0369 ns | 0.0345 ns | 17.080 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.940 ns | 0.0248 ns | 0.0220 ns | 11.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.120 ns | 0.0077 ns | 0.0064 ns | 11.121 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.322 ns | 0.0169 ns | 0.0158 ns | 11.321 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.316 ns | 0.0136 ns | 0.0121 ns | 12.318 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.519 ns | 0.0191 ns | 0.0179 ns | 12.521 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.165 ns | 0.0205 ns | 0.0182 ns | 14.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 11.928 ns | 0.0259 ns | 0.0242 ns | 11.932 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.305 ns | 0.1074 ns | 0.1004 ns | 12.336 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.934 ns | 0.0249 ns | 0.0232 ns | 15.932 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.913 ns | 0.0165 ns | 0.0129 ns | 14.916 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.891 ns | 0.0800 ns | 0.0709 ns | 39.897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.443 ns | 0.0639 ns | 0.0534 ns | 38.432 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.681 ns | 0.3771 ns | 0.3527 ns | 36.447 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.088 ns | 0.0742 ns | 0.0657 ns | 39.078 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 37.910 ns | 0.0566 ns | 0.0502 ns | 37.917 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.438 ns | 0.0220 ns | 0.0206 ns | 15.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.344 ns | 0.0195 ns | 0.0163 ns | 14.342 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.739 ns | 0.0168 ns | 0.0141 ns | 13.740 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.231 ns | 0.0331 ns | 0.0276 ns | 15.232 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.666 ns | 0.0770 ns | 0.0720 ns | 17.703 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.094 ns | 0.0617 ns | 0.0578 ns | 40.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.346 ns | 0.0297 ns | 0.0278 ns | 36.353 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.205 ns | 0.0819 ns | 0.0766 ns | 35.188 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.745 ns | 0.0706 ns | 0.0660 ns | 38.732 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.035 ns | 0.0779 ns | 0.0691 ns | 41.042 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.703 ns | 0.0177 ns | 0.0165 ns | 15.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.519 ns | 0.0274 ns | 0.0256 ns | 13.514 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.092 ns | 0.2505 ns | 0.2343 ns | 13.958 ns |  0.90 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.273 ns | 0.0277 ns | 0.0245 ns | 15.276 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 16.899 ns | 0.0239 ns | 0.0212 ns | 16.900 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 40.779 ns | 0.0429 ns | 0.0402 ns | 40.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.285 ns | 0.0435 ns | 0.0386 ns | 38.291 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.133 ns | 0.2185 ns | 0.2043 ns | 34.033 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.014 ns | 0.0607 ns | 0.0568 ns | 39.025 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 45.215 ns | 0.2686 ns | 0.2512 ns | 45.278 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.360 ns | 0.0174 ns | 0.0163 ns | 14.355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.849 ns | 0.0155 ns | 0.0121 ns | 11.847 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.391 ns | 0.1484 ns | 0.1388 ns | 11.459 ns |  0.79 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.254 ns | 0.0198 ns | 0.0185 ns | 13.258 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.816 ns | 0.0196 ns | 0.0184 ns | 15.817 ns |  1.10 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Long.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Long.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_Long.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_Long.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
