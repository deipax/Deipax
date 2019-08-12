
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
                                             From_Bool | .NET Core 2.0 | 13.718 ns | 0.0257 ns | 0.0240 ns | 13.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.099 ns | 0.0258 ns | 0.0215 ns | 12.099 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 | 10.034 ns | 0.0108 ns | 0.0096 ns | 10.034 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.193 ns | 0.0209 ns | 0.0186 ns | 13.189 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.040 ns | 0.0225 ns | 0.0210 ns | 13.044 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.029 ns | 0.0329 ns | 0.0308 ns | 20.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.336 ns | 0.0688 ns | 0.0643 ns | 18.346 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.945 ns | 0.0419 ns | 0.0371 ns | 17.936 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 28.554 ns | 0.0446 ns | 0.0395 ns | 28.562 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 29.019 ns | 0.0607 ns | 0.0538 ns | 29.034 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.380 ns | 0.0221 ns | 0.0207 ns | 12.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.968 ns | 0.0238 ns | 0.0211 ns | 10.964 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.241 ns | 0.0104 ns | 0.0097 ns | 10.239 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.206 ns | 0.0263 ns | 0.0233 ns | 13.202 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.259 ns | 0.0380 ns | 0.0337 ns | 13.258 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.652 ns | 0.1239 ns | 0.1159 ns | 19.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.720 ns | 0.0603 ns | 0.0535 ns | 18.722 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.337 ns | 0.0233 ns | 0.0207 ns | 20.336 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 27.360 ns | 0.0646 ns | 0.0573 ns | 27.362 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.896 ns | 0.0228 ns | 0.0178 ns | 27.896 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.146 ns | 0.0212 ns | 0.0177 ns | 12.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.935 ns | 0.0102 ns | 0.0085 ns | 10.937 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.928 ns | 0.1122 ns | 0.1050 ns |  9.987 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.000 ns | 0.0190 ns | 0.0158 ns | 12.993 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.700 ns | 0.0262 ns | 0.0245 ns | 13.698 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.065 ns | 0.0313 ns | 0.0261 ns | 15.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.701 ns | 0.0222 ns | 0.0197 ns | 13.701 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.379 ns | 0.1248 ns | 0.1168 ns | 14.330 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 23.227 ns | 0.0350 ns | 0.0310 ns | 23.232 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 23.282 ns | 0.0348 ns | 0.0291 ns | 23.277 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.120 ns | 0.0136 ns | 0.0120 ns | 12.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.638 ns | 0.0184 ns | 0.0172 ns | 10.639 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.586 ns | 0.0127 ns | 0.0106 ns |  9.586 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.791 ns | 0.0217 ns | 0.0203 ns | 12.787 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.992 ns | 0.0844 ns | 0.0748 ns | 13.014 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.844 ns | 0.0441 ns | 0.0412 ns | 19.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.095 ns | 0.0256 ns | 0.0214 ns | 18.099 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.755 ns | 0.1150 ns | 0.1075 ns | 17.694 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.936 ns | 0.0456 ns | 0.0404 ns | 27.933 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.666 ns | 0.1488 ns | 0.1391 ns | 27.614 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.428 ns | 0.0926 ns | 0.0866 ns | 12.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 13.357 ns | 0.0960 ns | 0.0749 ns | 13.389 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.466 ns | 0.0136 ns | 0.0127 ns | 10.465 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.015 ns | 0.0265 ns | 0.0247 ns | 13.024 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 15.112 ns | 0.0297 ns | 0.0278 ns | 15.123 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.785 ns | 0.0298 ns | 0.0279 ns | 19.783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.142 ns | 0.0578 ns | 0.0541 ns | 18.132 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.942 ns | 0.1165 ns | 0.1090 ns | 17.959 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.770 ns | 0.0655 ns | 0.0581 ns | 27.757 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.467 ns | 0.0499 ns | 0.0443 ns | 27.454 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.125 ns | 0.0205 ns | 0.0181 ns | 12.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.639 ns | 0.0216 ns | 0.0191 ns | 10.643 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 | 10.033 ns | 0.0696 ns | 0.0617 ns | 10.004 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.003 ns | 0.0174 ns | 0.0154 ns | 13.004 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.016 ns | 0.0169 ns | 0.0141 ns | 13.020 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.073 ns | 0.0272 ns | 0.0213 ns | 15.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.910 ns | 0.0636 ns | 0.0595 ns | 13.922 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.503 ns | 0.0188 ns | 0.0176 ns | 13.506 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 25.174 ns | 0.1206 ns | 0.1128 ns | 25.203 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 23.295 ns | 0.0342 ns | 0.0303 ns | 23.293 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.105 ns | 0.0192 ns | 0.0170 ns | 12.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.847 ns | 0.0568 ns | 0.0532 ns | 10.851 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.690 ns | 0.0399 ns | 0.0373 ns |  9.690 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.567 ns | 0.0145 ns | 0.0135 ns | 12.571 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.252 ns | 0.0259 ns | 0.0242 ns | 13.245 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.952 ns | 0.0937 ns | 0.0877 ns | 11.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.530 ns | 0.1031 ns | 0.0965 ns | 10.471 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.590 ns | 0.2377 ns | 0.3091 ns | 10.702 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.727 ns | 0.0598 ns | 0.0530 ns | 12.740 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.275 ns | 0.0465 ns | 0.0435 ns | 13.256 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.123 ns | 0.0274 ns | 0.0228 ns | 12.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.557 ns | 0.0684 ns | 0.0640 ns | 10.548 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.779 ns | 0.0132 ns | 0.0117 ns |  9.780 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.534 ns | 0.0141 ns | 0.0125 ns | 12.535 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.327 ns | 0.0876 ns | 0.0819 ns | 13.338 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.143 ns | 0.1315 ns | 0.1230 ns | 15.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.875 ns | 0.0830 ns | 0.0776 ns | 13.898 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.492 ns | 0.0269 ns | 0.0239 ns | 13.489 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 23.644 ns | 0.1506 ns | 0.1335 ns | 23.672 ns |  1.56 |    0.02 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 23.314 ns | 0.0433 ns | 0.0361 ns | 23.318 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.500 ns | 0.0195 ns | 0.0182 ns | 12.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.361 ns | 0.0254 ns | 0.0237 ns | 11.365 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.889 ns | 0.0601 ns | 0.0562 ns |  9.915 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.190 ns | 0.0315 ns | 0.0279 ns | 13.194 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 15.775 ns | 0.0333 ns | 0.0312 ns | 15.778 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.373 ns | 0.0435 ns | 0.0386 ns | 13.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 13.485 ns | 0.0990 ns | 0.0926 ns | 13.523 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.710 ns | 0.3225 ns | 0.3840 ns | 10.495 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.234 ns | 0.0255 ns | 0.0239 ns | 14.237 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.632 ns | 0.1868 ns | 0.1748 ns | 14.541 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.675 ns | 0.0180 ns | 0.0159 ns | 12.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.455 ns | 0.0288 ns | 0.0255 ns | 11.447 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.047 ns | 0.0242 ns | 0.0202 ns | 10.048 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.471 ns | 0.0355 ns | 0.0332 ns | 13.459 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.013 ns | 0.0908 ns | 0.0850 ns | 13.983 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.075 ns | 0.0297 ns | 0.0278 ns | 15.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.897 ns | 0.0120 ns | 0.0107 ns | 13.898 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.402 ns | 0.3069 ns | 0.3284 ns | 14.513 ns |  0.95 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 23.557 ns | 0.0172 ns | 0.0152 ns | 23.555 ns |  1.56 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 22.996 ns | 0.0687 ns | 0.0609 ns | 23.007 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.672 ns | 0.0532 ns | 0.0497 ns | 23.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.174 ns | 0.0547 ns | 0.0511 ns | 20.176 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.436 ns | 0.0816 ns | 0.0724 ns | 13.453 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.692 ns | 0.0522 ns | 0.0488 ns | 24.695 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.492 ns | 0.0386 ns | 0.0322 ns | 23.506 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.848 ns | 0.1172 ns | 0.1096 ns | 26.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.672 ns | 0.0217 ns | 0.0193 ns | 24.672 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.994 ns | 0.1362 ns | 0.1274 ns | 20.967 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 32.398 ns | 0.1044 ns | 0.0976 ns | 32.423 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 34.276 ns | 0.0552 ns | 0.0461 ns | 34.277 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 26.429 ns | 0.0295 ns | 0.0261 ns | 26.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.698 ns | 0.1047 ns | 0.0980 ns | 25.730 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 24.445 ns | 0.1227 ns | 0.1148 ns | 24.485 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 27.249 ns | 0.0381 ns | 0.0357 ns | 27.238 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 28.142 ns | 0.0303 ns | 0.0283 ns | 28.149 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 27.380 ns | 0.0638 ns | 0.0498 ns | 27.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.013 ns | 0.1279 ns | 0.1196 ns | 25.970 ns |  0.95 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.162 ns | 0.1391 ns | 0.1301 ns | 24.224 ns |  0.88 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 32.236 ns | 0.0358 ns | 0.0280 ns | 32.234 ns |  1.18 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 32.128 ns | 0.0511 ns | 0.0453 ns | 32.129 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.657 ns | 0.0778 ns | 0.0690 ns | 12.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.806 ns | 0.0479 ns | 0.0424 ns | 11.819 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.079 ns | 0.0185 ns | 0.0154 ns | 10.075 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.833 ns | 0.0279 ns | 0.0261 ns | 13.833 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.318 ns | 0.0317 ns | 0.0281 ns | 14.314 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.089 ns | 0.0326 ns | 0.0304 ns | 15.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.827 ns | 0.0248 ns | 0.0232 ns | 13.829 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.524 ns | 0.0544 ns | 0.0509 ns | 13.503 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 23.165 ns | 0.0460 ns | 0.0431 ns | 23.145 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 23.595 ns | 0.1956 ns | 0.1734 ns | 23.667 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.359 ns | 0.0228 ns | 0.0213 ns | 12.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.909 ns | 0.0194 ns | 0.0162 ns | 10.906 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.097 ns | 0.0669 ns | 0.0626 ns | 10.085 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 12.995 ns | 0.0189 ns | 0.0168 ns | 12.990 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.018 ns | 0.0556 ns | 0.0520 ns | 12.991 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.936 ns | 0.1764 ns | 0.1650 ns | 19.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.206 ns | 0.0901 ns | 0.0843 ns | 18.231 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.444 ns | 0.0413 ns | 0.0387 ns | 18.440 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 27.734 ns | 0.0857 ns | 0.0802 ns | 27.744 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.760 ns | 0.3033 ns | 0.2368 ns | 29.873 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.368 ns | 0.0179 ns | 0.0159 ns | 13.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.795 ns | 0.0256 ns | 0.0227 ns | 11.794 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.837 ns | 0.0660 ns | 0.0617 ns | 10.866 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.410 ns | 0.1663 ns | 0.1555 ns | 14.396 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.128 ns | 0.0390 ns | 0.0326 ns | 15.120 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.777 ns | 0.0315 ns | 0.0279 ns | 19.784 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.839 ns | 0.0354 ns | 0.0331 ns | 17.845 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 24.121 ns | 0.3253 ns | 0.3043 ns | 24.314 ns |  1.22 |    0.02 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 29.323 ns | 0.0676 ns | 0.0632 ns | 29.321 ns |  1.48 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 29.569 ns | 0.3170 ns | 0.2965 ns | 29.778 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.522 ns | 0.0189 ns | 0.0147 ns | 12.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.654 ns | 0.0619 ns | 0.0579 ns | 11.662 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.008 ns | 0.0133 ns | 0.0118 ns | 10.008 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.831 ns | 0.0281 ns | 0.0263 ns | 13.826 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 15.589 ns | 0.0409 ns | 0.0383 ns | 15.583 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.094 ns | 0.0322 ns | 0.0301 ns | 15.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.676 ns | 0.0202 ns | 0.0189 ns | 13.675 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.903 ns | 0.0761 ns | 0.0712 ns | 14.936 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 24.837 ns | 0.0451 ns | 0.0422 ns | 24.815 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 23.211 ns | 0.0434 ns | 0.0385 ns | 23.210 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.117 ns | 0.0336 ns | 0.0298 ns | 12.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.817 ns | 0.0531 ns | 0.0471 ns | 10.827 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 10.030 ns | 0.0173 ns | 0.0145 ns | 10.032 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.293 ns | 0.0576 ns | 0.0539 ns | 13.304 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.771 ns | 0.0228 ns | 0.0213 ns | 12.773 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.792 ns | 0.0322 ns | 0.0301 ns | 19.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.371 ns | 0.0535 ns | 0.0501 ns | 18.358 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.915 ns | 0.0223 ns | 0.0174 ns | 17.922 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 30.360 ns | 0.0237 ns | 0.0222 ns | 30.356 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.727 ns | 0.0342 ns | 0.0304 ns | 27.728 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.351 ns | 0.0313 ns | 0.0261 ns | 12.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.923 ns | 0.0232 ns | 0.0194 ns | 10.920 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.304 ns | 0.0448 ns | 0.0419 ns | 10.322 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.012 ns | 0.0184 ns | 0.0172 ns | 13.010 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.051 ns | 0.0570 ns | 0.0476 ns | 13.038 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.291 ns | 0.1030 ns | 0.0913 ns | 20.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.165 ns | 0.0824 ns | 0.0688 ns | 18.183 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.830 ns | 0.0474 ns | 0.0420 ns | 19.823 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 28.969 ns | 0.0361 ns | 0.0338 ns | 28.967 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.857 ns | 0.0732 ns | 0.0611 ns | 27.855 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.126 ns | 0.0203 ns | 0.0190 ns | 12.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.663 ns | 0.0238 ns | 0.0222 ns | 10.669 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.791 ns | 0.0150 ns | 0.0140 ns |  9.792 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.235 ns | 0.0110 ns | 0.0103 ns | 13.235 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 13.014 ns | 0.0274 ns | 0.0229 ns | 13.010 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.087 ns | 0.0310 ns | 0.0290 ns | 15.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.707 ns | 0.0764 ns | 0.0677 ns | 13.680 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.640 ns | 0.0995 ns | 0.0831 ns | 13.676 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.926 ns | 0.0474 ns | 0.0420 ns | 22.933 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.136 ns | 0.1778 ns | 0.1663 ns | 25.182 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 13.532 ns | 0.1179 ns | 0.1103 ns | 13.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.741 ns | 0.0115 ns | 0.0108 ns | 10.741 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.573 ns | 0.0099 ns | 0.0088 ns |  9.575 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.544 ns | 0.0120 ns | 0.0100 ns | 12.545 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.958 ns | 0.1051 ns | 0.0931 ns | 13.972 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.345 ns | 0.0245 ns | 0.0229 ns | 21.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.373 ns | 0.0375 ns | 0.0350 ns | 18.374 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 20.995 ns | 0.1309 ns | 0.1224 ns | 21.047 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 27.966 ns | 0.0251 ns | 0.0235 ns | 27.964 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 27.760 ns | 0.0316 ns | 0.0247 ns | 27.761 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.347 ns | 0.0161 ns | 0.0143 ns | 12.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.932 ns | 0.0258 ns | 0.0201 ns | 10.927 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.482 ns | 0.0487 ns | 0.0456 ns | 10.459 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.017 ns | 0.0429 ns | 0.0381 ns | 13.009 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.703 ns | 0.0376 ns | 0.0314 ns | 13.711 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.874 ns | 0.1377 ns | 0.1221 ns | 19.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.140 ns | 0.0265 ns | 0.0248 ns | 18.140 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.159 ns | 0.0233 ns | 0.0218 ns | 18.159 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 29.155 ns | 0.2017 ns | 0.1788 ns | 29.211 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.314 ns | 0.0361 ns | 0.0301 ns | 29.311 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.096 ns | 0.0238 ns | 0.0211 ns | 12.097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.580 ns | 0.0218 ns | 0.0204 ns | 11.578 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 | 10.052 ns | 0.0800 ns | 0.0749 ns | 10.009 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.810 ns | 0.0156 ns | 0.0146 ns | 14.808 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.207 ns | 0.0166 ns | 0.0147 ns | 13.206 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.066 ns | 0.0184 ns | 0.0172 ns | 15.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.683 ns | 0.0293 ns | 0.0260 ns | 13.682 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.310 ns | 0.0265 ns | 0.0235 ns | 14.308 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 23.101 ns | 0.0297 ns | 0.0263 ns | 23.099 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 23.113 ns | 0.0258 ns | 0.0228 ns | 23.113 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.489 ns | 0.0605 ns | 0.0566 ns | 12.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.981 ns | 0.0574 ns | 0.0537 ns | 10.994 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 11.904 ns | 0.2640 ns | 0.5023 ns | 12.033 ns |  0.93 |    0.07 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.499 ns | 0.0284 ns | 0.0252 ns | 13.492 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.797 ns | 0.0169 ns | 0.0158 ns | 12.795 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.222 ns | 0.0208 ns | 0.0195 ns | 20.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.089 ns | 0.0429 ns | 0.0401 ns | 18.080 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.149 ns | 0.1173 ns | 0.1097 ns | 18.170 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 28.845 ns | 0.0279 ns | 0.0218 ns | 28.844 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.976 ns | 0.0374 ns | 0.0332 ns | 29.975 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.066 ns | 0.0185 ns | 0.0173 ns | 13.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.721 ns | 0.0924 ns | 0.0865 ns | 11.683 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.583 ns | 0.0737 ns | 0.0654 ns | 10.589 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.518 ns | 0.2133 ns | 0.1995 ns | 14.553 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.726 ns | 0.0207 ns | 0.0173 ns | 13.728 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.876 ns | 0.0845 ns | 0.0749 ns | 19.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.369 ns | 0.0193 ns | 0.0180 ns | 18.367 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.769 ns | 0.0814 ns | 0.0761 ns | 19.739 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.392 ns | 0.1038 ns | 0.0971 ns | 27.346 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.747 ns | 0.0558 ns | 0.0494 ns | 27.749 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.635 ns | 0.0191 ns | 0.0179 ns | 13.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.509 ns | 0.0156 ns | 0.0139 ns | 11.507 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.254 ns | 0.0203 ns | 0.0190 ns | 10.250 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.352 ns | 0.0303 ns | 0.0268 ns | 14.350 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.065 ns | 0.0272 ns | 0.0254 ns | 14.067 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.043 ns | 0.0286 ns | 0.0239 ns | 16.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.278 ns | 0.0295 ns | 0.0246 ns | 14.288 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.840 ns | 0.1151 ns | 0.1076 ns | 13.881 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 23.686 ns | 0.1396 ns | 0.1237 ns | 23.698 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 25.443 ns | 0.4622 ns | 0.4323 ns | 25.641 ns |  1.58 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.519 ns | 0.0371 ns | 0.0347 ns | 12.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.051 ns | 0.0648 ns | 0.0606 ns | 11.063 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 | 10.044 ns | 0.0191 ns | 0.0160 ns | 10.038 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.970 ns | 0.0965 ns | 0.0855 ns | 13.001 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.891 ns | 0.1340 ns | 0.1253 ns | 12.812 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.773 ns | 0.0392 ns | 0.0347 ns | 19.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.628 ns | 0.0690 ns | 0.0645 ns | 18.638 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.708 ns | 0.0275 ns | 0.0257 ns | 17.708 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.940 ns | 0.0297 ns | 0.0248 ns | 27.944 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.293 ns | 0.0429 ns | 0.0402 ns | 27.297 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.700 ns | 0.0156 ns | 0.0122 ns | 12.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.921 ns | 0.0279 ns | 0.0261 ns | 10.919 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.463 ns | 0.0139 ns | 0.0123 ns | 10.461 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.707 ns | 0.0209 ns | 0.0163 ns | 13.701 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.197 ns | 0.0657 ns | 0.0615 ns | 13.212 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.009 ns | 0.0779 ns | 0.0729 ns | 20.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.491 ns | 0.0764 ns | 0.0715 ns | 18.497 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.696 ns | 0.0184 ns | 0.0163 ns | 20.692 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 30.598 ns | 0.7737 ns | 0.8910 ns | 30.205 ns |  1.54 |    0.05 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 29.227 ns | 0.0265 ns | 0.0248 ns | 29.229 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.109 ns | 0.0231 ns | 0.0216 ns | 12.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.648 ns | 0.0262 ns | 0.0245 ns | 10.655 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 10.018 ns | 0.0286 ns | 0.0254 ns | 10.013 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.668 ns | 0.0646 ns | 0.0604 ns | 13.638 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.009 ns | 0.0238 ns | 0.0186 ns | 13.008 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.806 ns | 0.0282 ns | 0.0250 ns | 15.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.732 ns | 0.0767 ns | 0.0718 ns | 13.706 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.302 ns | 0.3016 ns | 0.3352 ns | 14.585 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 23.244 ns | 0.0348 ns | 0.0309 ns | 23.247 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 23.209 ns | 0.0561 ns | 0.0525 ns | 23.229 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.533 ns | 0.0657 ns | 0.0582 ns | 12.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.108 ns | 0.0117 ns | 0.0104 ns | 11.108 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.257 ns | 0.0143 ns | 0.0120 ns | 10.258 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.013 ns | 0.0233 ns | 0.0207 ns | 13.005 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 13.056 ns | 0.0345 ns | 0.0270 ns | 13.048 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.790 ns | 0.0414 ns | 0.0387 ns | 23.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 25.923 ns | 0.0552 ns | 0.0489 ns | 25.937 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 34.901 ns | 0.0407 ns | 0.0380 ns | 34.905 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 36.836 ns | 0.0961 ns | 0.0852 ns | 36.809 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 34.590 ns | 0.0873 ns | 0.0682 ns | 34.581 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 11.410 ns | 0.0214 ns | 0.0190 ns | 11.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 10.375 ns | 0.0491 ns | 0.0459 ns | 10.356 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  6.949 ns | 0.0112 ns | 0.0105 ns |  6.949 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 12.816 ns | 0.0832 ns | 0.0778 ns | 12.832 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 11.958 ns | 0.0250 ns | 0.0209 ns | 11.959 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.125 ns | 0.0934 ns | 0.0873 ns | 24.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.136 ns | 0.0267 ns | 0.0250 ns | 26.137 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.086 ns | 0.0364 ns | 0.0322 ns | 29.084 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 35.430 ns | 0.1191 ns | 0.1055 ns | 35.388 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 36.479 ns | 0.1701 ns | 0.1507 ns | 36.404 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.457 ns | 0.0177 ns | 0.0166 ns | 11.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.357 ns | 0.0272 ns | 0.0254 ns | 10.356 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.706 ns | 0.0558 ns | 0.0522 ns |  6.727 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.797 ns | 0.0357 ns | 0.0334 ns | 11.788 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 11.985 ns | 0.0254 ns | 0.0225 ns | 11.988 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.089 ns | 0.0258 ns | 0.0229 ns | 15.090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.289 ns | 0.0232 ns | 0.0193 ns | 14.295 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.732 ns | 0.2606 ns | 0.2438 ns | 13.935 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 23.420 ns | 0.0784 ns | 0.0695 ns | 23.434 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.736 ns | 0.0462 ns | 0.0409 ns | 24.741 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 74.978 ns | 0.3689 ns | 0.3270 ns | 75.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 80.684 ns | 0.0651 ns | 0.0609 ns | 80.708 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 55.111 ns | 0.0896 ns | 0.0748 ns | 55.099 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 73.148 ns | 0.1721 ns | 0.1610 ns | 73.093 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 75.067 ns | 0.1539 ns | 0.1364 ns | 75.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 79.331 ns | 0.1050 ns | 0.0983 ns | 79.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 84.410 ns | 0.2138 ns | 0.1999 ns | 84.491 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 63.740 ns | 0.0781 ns | 0.0731 ns | 63.738 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 88.479 ns | 0.6441 ns | 0.6025 ns | 88.801 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 86.208 ns | 0.1041 ns | 0.0974 ns | 86.227 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.394 ns | 0.0371 ns | 0.0329 ns | 14.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 19.153 ns | 0.0507 ns | 0.0474 ns | 19.144 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 14.033 ns | 0.0338 ns | 0.0282 ns | 14.038 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.097 ns | 0.0497 ns | 0.0465 ns | 15.090 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.115 ns | 0.0251 ns | 0.0234 ns | 15.121 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 16.108 ns | 0.0822 ns | 0.0686 ns | 16.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 15.687 ns | 0.0177 ns | 0.0157 ns | 15.682 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.508 ns | 0.0176 ns | 0.0165 ns | 13.503 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 23.049 ns | 0.0361 ns | 0.0301 ns | 23.049 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.806 ns | 0.1586 ns | 0.1483 ns | 24.736 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.380 ns | 0.0213 ns | 0.0199 ns | 14.381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 19.081 ns | 0.0378 ns | 0.0353 ns | 19.093 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 14.008 ns | 0.0291 ns | 0.0243 ns | 14.004 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 16.004 ns | 0.0597 ns | 0.0529 ns | 15.993 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.759 ns | 0.0325 ns | 0.0304 ns | 15.755 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.321 ns | 0.0372 ns | 0.0330 ns | 12.309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.851 ns | 0.0116 ns | 0.0097 ns | 10.851 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.581 ns | 0.0111 ns | 0.0098 ns |  9.581 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.788 ns | 0.0182 ns | 0.0162 ns | 12.784 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.847 ns | 0.0956 ns | 0.0895 ns | 12.813 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.773 ns | 0.0333 ns | 0.0296 ns | 19.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.911 ns | 0.0443 ns | 0.0370 ns | 17.907 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.702 ns | 0.0322 ns | 0.0301 ns | 17.691 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.698 ns | 0.1843 ns | 0.1539 ns | 27.683 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.734 ns | 0.0498 ns | 0.0442 ns | 27.739 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 13.054 ns | 0.0409 ns | 0.0363 ns | 13.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.914 ns | 0.0132 ns | 0.0124 ns | 10.914 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.243 ns | 0.0122 ns | 0.0108 ns | 10.243 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 15.787 ns | 0.1121 ns | 0.0993 ns | 15.779 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.025 ns | 0.0223 ns | 0.0208 ns | 13.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.429 ns | 0.1123 ns | 0.1050 ns | 20.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.848 ns | 0.0281 ns | 0.0249 ns | 17.846 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.226 ns | 0.0295 ns | 0.0261 ns | 20.226 ns |  0.99 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 28.846 ns | 0.0647 ns | 0.0605 ns | 28.847 ns |  1.41 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.904 ns | 0.2032 ns | 0.1900 ns | 27.844 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.117 ns | 0.0220 ns | 0.0206 ns | 12.116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.640 ns | 0.0191 ns | 0.0179 ns | 10.639 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 10.046 ns | 0.0425 ns | 0.0398 ns | 10.030 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.713 ns | 0.0243 ns | 0.0215 ns | 13.715 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.005 ns | 0.0266 ns | 0.0248 ns | 13.012 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.102 ns | 0.0158 ns | 0.0132 ns | 15.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.678 ns | 0.0188 ns | 0.0157 ns | 13.680 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.984 ns | 0.1025 ns | 0.0958 ns | 16.944 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 23.467 ns | 0.1371 ns | 0.1145 ns | 23.491 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 23.059 ns | 0.0436 ns | 0.0408 ns | 23.060 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.744 ns | 0.0917 ns | 0.0813 ns | 12.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.586 ns | 0.0216 ns | 0.0202 ns | 10.589 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.569 ns | 0.0105 ns | 0.0093 ns |  9.569 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.913 ns | 0.1074 ns | 0.1004 ns | 12.880 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.809 ns | 0.0702 ns | 0.0656 ns | 12.784 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.949 ns | 0.0292 ns | 0.0274 ns | 19.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.113 ns | 0.0329 ns | 0.0292 ns | 18.107 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.999 ns | 0.0735 ns | 0.0687 ns | 18.030 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 27.748 ns | 0.2730 ns | 0.2420 ns | 27.691 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.569 ns | 0.0557 ns | 0.0494 ns | 29.576 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.603 ns | 0.0191 ns | 0.0159 ns | 12.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.917 ns | 0.0154 ns | 0.0136 ns | 10.919 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.487 ns | 0.0514 ns | 0.0455 ns | 10.468 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.527 ns | 0.0791 ns | 0.0740 ns | 13.497 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.507 ns | 0.0294 ns | 0.0260 ns | 13.506 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.100 ns | 0.1807 ns | 0.1690 ns | 20.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.062 ns | 0.0368 ns | 0.0326 ns | 18.060 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.447 ns | 0.1294 ns | 0.1210 ns | 18.380 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 29.071 ns | 0.0962 ns | 0.0853 ns | 29.037 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.769 ns | 0.1491 ns | 0.1245 ns | 27.788 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.119 ns | 0.0275 ns | 0.0257 ns | 12.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 12.261 ns | 0.0133 ns | 0.0118 ns | 12.258 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.780 ns | 0.0214 ns | 0.0190 ns |  9.778 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.104 ns | 0.0667 ns | 0.0624 ns | 13.105 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.520 ns | 0.0186 ns | 0.0174 ns | 13.522 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.107 ns | 0.0352 ns | 0.0312 ns | 15.101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.683 ns | 0.0202 ns | 0.0189 ns | 13.682 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.955 ns | 0.0270 ns | 0.0240 ns | 13.956 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 24.739 ns | 0.0444 ns | 0.0415 ns | 24.732 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 23.362 ns | 0.0460 ns | 0.0430 ns | 23.349 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.566 ns | 0.0146 ns | 0.0130 ns | 12.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.949 ns | 0.0271 ns | 0.0253 ns | 10.948 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 | 10.029 ns | 0.0140 ns | 0.0124 ns | 10.033 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.871 ns | 0.1065 ns | 0.0996 ns | 12.825 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.909 ns | 0.0087 ns | 0.0073 ns | 13.909 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.779 ns | 0.0240 ns | 0.0201 ns | 19.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.158 ns | 0.0467 ns | 0.0437 ns | 18.166 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.264 ns | 0.2531 ns | 0.2367 ns | 18.098 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 28.090 ns | 0.0723 ns | 0.0641 ns | 28.079 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 27.891 ns | 0.0422 ns | 0.0394 ns | 27.882 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.033 ns | 0.0368 ns | 0.0327 ns | 13.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.778 ns | 0.0156 ns | 0.0146 ns | 11.776 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.711 ns | 0.0155 ns | 0.0145 ns | 10.712 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 16.151 ns | 0.0990 ns | 0.0926 ns | 16.169 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.904 ns | 0.1249 ns | 0.1107 ns | 14.936 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.507 ns | 0.1142 ns | 0.1012 ns | 21.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.062 ns | 0.0405 ns | 0.0339 ns | 18.054 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.071 ns | 0.4834 ns | 1.2303 ns | 23.428 ns |  1.00 |    0.11 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 28.658 ns | 0.3914 ns | 0.3661 ns | 28.651 ns |  1.33 |    0.02 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.810 ns | 0.0897 ns | 0.0795 ns | 27.790 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.930 ns | 0.0224 ns | 0.0187 ns | 12.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.546 ns | 0.0448 ns | 0.0398 ns | 11.535 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 10.034 ns | 0.0394 ns | 0.0369 ns | 10.018 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.881 ns | 0.1879 ns | 0.1569 ns | 13.867 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.503 ns | 0.0259 ns | 0.0229 ns | 13.501 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.135 ns | 0.1128 ns | 0.1055 ns | 15.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.882 ns | 0.0543 ns | 0.0482 ns | 13.892 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.515 ns | 0.0260 ns | 0.0230 ns | 13.507 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.995 ns | 0.0451 ns | 0.0400 ns | 22.982 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 23.168 ns | 0.0414 ns | 0.0367 ns | 23.170 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.380 ns | 0.0279 ns | 0.0261 ns | 15.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.688 ns | 0.0178 ns | 0.0167 ns | 13.696 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 15.369 ns | 0.0861 ns | 0.0805 ns | 15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 26.229 ns | 0.0362 ns | 0.0321 ns | 26.233 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 23.049 ns | 0.0328 ns | 0.0290 ns | 23.055 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 13.036 ns | 0.0220 ns | 0.0195 ns | 13.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.386 ns | 0.0619 ns | 0.0579 ns | 11.358 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.671 ns | 0.1480 ns | 0.1385 ns | 13.605 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 13.335 ns | 0.1103 ns | 0.1032 ns | 13.278 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.245 ns | 0.0290 ns | 0.0271 ns | 13.254 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.071 ns | 0.0175 ns | 0.0155 ns | 15.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.918 ns | 0.0172 ns | 0.0161 ns | 13.910 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.697 ns | 0.0234 ns | 0.0207 ns | 13.692 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 23.008 ns | 0.0432 ns | 0.0404 ns | 23.015 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.780 ns | 0.1184 ns | 0.1107 ns | 24.731 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.396 ns | 0.0752 ns | 0.0703 ns | 18.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.080 ns | 0.0251 ns | 0.0223 ns | 15.084 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.541 ns | 0.1110 ns | 0.1038 ns | 15.571 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 28.535 ns | 0.0303 ns | 0.0283 ns | 28.541 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 27.350 ns | 0.0310 ns | 0.0274 ns | 27.341 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.042 ns | 0.0253 ns | 0.0236 ns | 19.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.841 ns | 0.0477 ns | 0.0372 ns | 17.841 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.440 ns | 0.2551 ns | 0.2386 ns | 17.284 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.904 ns | 0.1589 ns | 0.1486 ns | 26.954 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.453 ns | 0.0404 ns | 0.0378 ns | 29.457 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.080 ns | 0.0192 ns | 0.0170 ns | 15.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.513 ns | 0.0804 ns | 0.0713 ns | 13.538 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.726 ns | 0.0248 ns | 0.0220 ns | 13.726 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 23.445 ns | 0.2043 ns | 0.1911 ns | 23.467 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 23.109 ns | 0.0433 ns | 0.0405 ns | 23.095 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.377 ns | 0.0258 ns | 0.0228 ns | 15.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.970 ns | 0.0296 ns | 0.0277 ns | 14.966 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.968 ns | 0.0847 ns | 0.0792 ns | 14.996 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 24.678 ns | 0.0571 ns | 0.0506 ns | 24.673 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 23.435 ns | 0.0375 ns | 0.0332 ns | 23.434 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.170 ns | 0.0272 ns | 0.0254 ns | 14.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.545 ns | 0.0489 ns | 0.0433 ns | 12.534 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.843 ns | 0.0358 ns | 0.0317 ns | 12.833 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.902 ns | 0.0331 ns | 0.0310 ns | 14.913 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.330 ns | 0.0283 ns | 0.0251 ns | 15.321 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.002 ns | 0.1174 ns | 0.1098 ns | 16.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 16.215 ns | 0.0987 ns | 0.0923 ns | 16.240 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.445 ns | 0.1005 ns | 0.0891 ns | 15.389 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.347 ns | 0.0675 ns | 0.0632 ns | 24.332 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.166 ns | 0.0664 ns | 0.0621 ns | 24.175 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.397 ns | 0.0154 ns | 0.0136 ns | 14.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.543 ns | 0.0237 ns | 0.0222 ns | 12.542 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.841 ns | 0.0201 ns | 0.0178 ns | 12.841 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.632 ns | 0.0233 ns | 0.0195 ns | 14.632 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.348 ns | 0.0279 ns | 0.0261 ns | 15.350 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.111 ns | 0.0242 ns | 0.0226 ns | 16.109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.655 ns | 0.0219 ns | 0.0183 ns | 13.659 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.549 ns | 0.0494 ns | 0.0462 ns | 13.559 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 23.189 ns | 0.0396 ns | 0.0351 ns | 23.187 ns |  1.44 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 23.034 ns | 0.0817 ns | 0.0682 ns | 23.027 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.297 ns | 0.0519 ns | 0.0460 ns | 20.282 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 17.131 ns | 0.0692 ns | 0.0614 ns | 17.138 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 14.420 ns | 0.0417 ns | 0.0369 ns | 14.420 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.701 ns | 0.0279 ns | 0.0233 ns | 19.699 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.767 ns | 0.0451 ns | 0.0422 ns | 19.776 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 20.613 ns | 0.0242 ns | 0.0226 ns | 20.608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 18.118 ns | 0.0367 ns | 0.0343 ns | 18.109 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 20.001 ns | 0.0471 ns | 0.0418 ns | 19.986 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.986 ns | 0.0864 ns | 0.0808 ns | 28.995 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 26.992 ns | 0.0349 ns | 0.0292 ns | 26.996 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 21.443 ns | 0.0679 ns | 0.0635 ns | 21.461 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.458 ns | 0.0510 ns | 0.0398 ns | 17.463 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 15.037 ns | 0.0577 ns | 0.0540 ns | 15.037 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.723 ns | 0.0458 ns | 0.0406 ns | 24.725 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 25.490 ns | 0.1289 ns | 0.1206 ns | 25.440 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.257 ns | 0.0186 ns | 0.0155 ns | 19.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.842 ns | 0.1514 ns | 0.1264 ns | 18.892 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.451 ns | 0.0256 ns | 0.0239 ns | 20.443 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.371 ns | 0.0720 ns | 0.0674 ns | 27.366 ns |  1.42 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.802 ns | 0.0530 ns | 0.0496 ns | 28.815 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.933 ns | 0.0237 ns | 0.0221 ns | 14.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.136 ns | 0.0271 ns | 0.0240 ns | 12.140 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.232 ns | 0.0135 ns | 0.0126 ns | 10.231 ns |  0.69 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 23.730 ns | 0.1262 ns | 0.1180 ns | 23.676 ns |  1.59 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.064 ns | 0.0274 ns | 0.0256 ns | 19.063 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.066 ns | 0.0249 ns | 0.0221 ns | 15.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.574 ns | 0.1196 ns | 0.1119 ns | 14.545 ns |  0.97 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.495 ns | 0.0281 ns | 0.0249 ns | 13.494 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 23.000 ns | 0.0464 ns | 0.0411 ns | 23.000 ns |  1.53 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 23.567 ns | 0.1654 ns | 0.1547 ns | 23.636 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.901 ns | 0.0202 ns | 0.0179 ns | 13.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 11.943 ns | 0.0413 ns | 0.0386 ns | 11.947 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.796 ns | 0.0123 ns | 0.0115 ns |  9.794 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.738 ns | 0.1060 ns | 0.0992 ns | 12.784 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 14.010 ns | 0.0277 ns | 0.0232 ns | 14.017 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.972 ns | 0.0346 ns | 0.0324 ns | 16.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.645 ns | 0.0392 ns | 0.0327 ns | 15.638 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.378 ns | 0.0379 ns | 0.0336 ns | 15.365 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.248 ns | 0.0313 ns | 0.0261 ns | 24.251 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 24.030 ns | 0.0844 ns | 0.0705 ns | 24.013 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.186 ns | 0.0165 ns | 0.0138 ns | 14.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.642 ns | 0.0171 ns | 0.0133 ns | 11.642 ns |  0.82 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.783 ns | 0.0085 ns | 0.0079 ns |  9.782 ns |  0.69 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.239 ns | 0.0163 ns | 0.0152 ns | 13.238 ns |  0.93 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.254 ns | 0.0152 ns | 0.0135 ns | 13.250 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.203 ns | 0.0999 ns | 0.0835 ns | 17.221 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.835 ns | 0.0223 ns | 0.0208 ns | 15.838 ns |  0.92 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.688 ns | 0.0210 ns | 0.0175 ns | 18.695 ns |  1.09 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.629 ns | 0.1976 ns | 0.1848 ns | 24.736 ns |  1.43 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.827 ns | 0.0237 ns | 0.0198 ns | 25.828 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.733 ns | 0.0147 ns | 0.0122 ns | 13.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.666 ns | 0.0214 ns | 0.0200 ns | 11.668 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.576 ns | 0.0127 ns | 0.0113 ns |  9.577 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.567 ns | 0.0252 ns | 0.0223 ns | 12.563 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.252 ns | 0.0245 ns | 0.0229 ns | 13.249 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.069 ns | 0.0207 ns | 0.0183 ns | 15.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.660 ns | 0.0190 ns | 0.0168 ns | 13.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.484 ns | 0.0182 ns | 0.0161 ns | 13.486 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 23.298 ns | 0.2349 ns | 0.2197 ns | 23.432 ns |  1.55 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.742 ns | 0.0379 ns | 0.0296 ns | 24.740 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.580 ns | 0.1587 ns | 0.1325 ns | 14.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 12.071 ns | 0.0167 ns | 0.0140 ns | 12.071 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.545 ns | 0.0159 ns | 0.0141 ns |  9.547 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.543 ns | 0.0259 ns | 0.0230 ns | 12.538 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.613 ns | 0.0899 ns | 0.0841 ns | 12.581 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.308 ns | 0.2776 ns | 0.2461 ns | 50.350 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.423 ns | 0.1049 ns | 0.0930 ns | 43.417 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 46.210 ns | 0.0915 ns | 0.0811 ns | 46.204 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 51.030 ns | 0.2476 ns | 0.2316 ns | 51.058 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.797 ns | 0.0894 ns | 0.0793 ns | 50.808 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.695 ns | 0.0655 ns | 0.0581 ns | 13.683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.135 ns | 0.1152 ns | 0.1021 ns | 12.093 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.276 ns | 0.0116 ns | 0.0102 ns | 10.278 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.242 ns | 0.1269 ns | 0.1187 ns | 13.280 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 14.047 ns | 0.0345 ns | 0.0288 ns | 14.049 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.563 ns | 0.1963 ns | 0.1836 ns | 46.568 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.579 ns | 0.0647 ns | 0.0605 ns | 43.562 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.219 ns | 0.0951 ns | 0.0843 ns | 39.223 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.627 ns | 0.0809 ns | 0.0757 ns | 50.599 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 52.252 ns | 0.2643 ns | 0.2472 ns | 52.161 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.770 ns | 0.0256 ns | 0.0227 ns | 13.770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.987 ns | 0.0171 ns | 0.0160 ns | 12.985 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.992 ns | 0.0136 ns | 0.0121 ns |  9.990 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.171 ns | 0.1210 ns | 0.1132 ns | 13.251 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.098 ns | 0.0876 ns | 0.0819 ns | 13.064 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.372 ns | 0.0669 ns | 0.0559 ns | 15.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.754 ns | 0.0203 ns | 0.0159 ns | 13.750 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.457 ns | 0.0224 ns | 0.0198 ns | 13.458 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 23.157 ns | 0.0456 ns | 0.0426 ns | 23.159 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 23.114 ns | 0.0455 ns | 0.0425 ns | 23.119 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.386 ns | 0.0153 ns | 0.0143 ns | 14.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.572 ns | 0.0079 ns | 0.0070 ns | 12.571 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.273 ns | 0.1000 ns | 0.0935 ns | 13.249 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.639 ns | 0.0605 ns | 0.0566 ns | 14.619 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 15.919 ns | 0.0385 ns | 0.0342 ns | 15.922 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.467 ns | 0.0860 ns | 0.0805 ns | 17.488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 16.141 ns | 0.0235 ns | 0.0220 ns | 16.135 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.447 ns | 0.3180 ns | 0.2974 ns | 16.635 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 23.918 ns | 0.0504 ns | 0.0447 ns | 23.909 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.229 ns | 0.0350 ns | 0.0310 ns | 24.228 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.136 ns | 0.0224 ns | 0.0199 ns | 14.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.593 ns | 0.0095 ns | 0.0084 ns | 12.593 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.781 ns | 0.0173 ns | 0.0153 ns | 12.776 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.578 ns | 0.0289 ns | 0.0256 ns | 15.578 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.647 ns | 0.0212 ns | 0.0177 ns | 14.643 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.188 ns | 0.0365 ns | 0.0324 ns | 15.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.747 ns | 0.0095 ns | 0.0079 ns | 13.748 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.462 ns | 0.0159 ns | 0.0148 ns | 13.463 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 24.628 ns | 0.0291 ns | 0.0258 ns | 24.633 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 23.206 ns | 0.0305 ns | 0.0285 ns | 23.208 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 43.680 ns | 0.0497 ns | 0.0440 ns | 43.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 40.978 ns | 0.0299 ns | 0.0265 ns | 40.985 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.960 ns | 0.0659 ns | 0.0584 ns | 38.935 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.140 ns | 0.0589 ns | 0.0523 ns | 41.130 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 50.187 ns | 0.0788 ns | 0.0698 ns | 50.189 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.431 ns | 0.0424 ns | 0.0354 ns | 17.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.194 ns | 0.0247 ns | 0.0206 ns | 16.186 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.093 ns | 0.5307 ns | 0.9569 ns | 15.570 ns |  0.99 |    0.05 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.555 ns | 0.0166 ns | 0.0138 ns | 24.556 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 24.171 ns | 0.0761 ns | 0.0635 ns | 24.165 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 45.028 ns | 0.0421 ns | 0.0394 ns | 45.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.736 ns | 0.0422 ns | 0.0374 ns | 40.725 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 40.107 ns | 0.8180 ns | 1.1732 ns | 40.744 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.542 ns | 0.0583 ns | 0.0546 ns | 40.540 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.599 ns | 0.0929 ns | 0.0824 ns | 41.599 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.441 ns | 0.0376 ns | 0.0314 ns | 17.449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.092 ns | 0.0227 ns | 0.0212 ns | 16.092 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.230 ns | 0.0283 ns | 0.0237 ns | 16.233 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.600 ns | 0.0982 ns | 0.0870 ns | 24.614 ns |  1.41 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 24.081 ns | 0.1277 ns | 0.1132 ns | 24.035 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 44.040 ns | 0.0643 ns | 0.0570 ns | 44.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 41.071 ns | 0.0503 ns | 0.0471 ns | 41.054 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 41.302 ns | 0.3391 ns | 0.3006 ns | 41.410 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.021 ns | 0.1481 ns | 0.1313 ns | 41.992 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 41.780 ns | 0.1152 ns | 0.1077 ns | 41.801 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.093 ns | 0.0379 ns | 0.0355 ns | 15.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.727 ns | 0.0222 ns | 0.0197 ns | 13.724 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.896 ns | 0.0238 ns | 0.0211 ns | 13.893 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 23.181 ns | 0.0893 ns | 0.0836 ns | 23.204 ns |  1.54 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 23.170 ns | 0.0264 ns | 0.0247 ns | 23.168 ns |  1.54 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_FloatNullable.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_FloatNullable.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_FloatNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_FloatNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
