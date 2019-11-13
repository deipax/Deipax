
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
                                             From_Bool | .NET Core 2.0 | 13.159 ns | 0.0376 ns | 0.0351 ns | 13.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.347 ns | 0.0330 ns | 0.0308 ns | 10.341 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.826 ns | 0.0129 ns | 0.0121 ns |  9.826 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.576 ns | 0.0101 ns | 0.0095 ns | 13.576 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.150 ns | 0.0165 ns | 0.0154 ns | 12.155 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.256 ns | 0.0312 ns | 0.0292 ns | 19.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.091 ns | 0.0199 ns | 0.0186 ns | 18.091 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.601 ns | 0.3306 ns | 0.3092 ns | 17.813 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.040 ns | 0.0420 ns | 0.0373 ns | 27.044 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 27.115 ns | 0.0446 ns | 0.0417 ns | 27.119 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.908 ns | 0.0094 ns | 0.0088 ns | 11.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.501 ns | 0.0215 ns | 0.0190 ns | 11.501 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.030 ns | 0.0063 ns | 0.0059 ns | 10.028 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.609 ns | 0.0175 ns | 0.0155 ns | 12.611 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 16.208 ns | 0.0117 ns | 0.0109 ns | 16.206 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.034 ns | 0.0215 ns | 0.0201 ns | 19.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.103 ns | 0.0437 ns | 0.0409 ns | 18.111 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.073 ns | 0.3709 ns | 0.3469 ns | 18.361 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 27.105 ns | 0.0394 ns | 0.0368 ns | 27.103 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.515 ns | 0.0420 ns | 0.0392 ns | 28.530 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.702 ns | 0.0113 ns | 0.0106 ns | 11.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.359 ns | 0.0043 ns | 0.0036 ns | 10.360 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.583 ns | 0.0116 ns | 0.0109 ns |  9.582 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.068 ns | 0.0112 ns | 0.0105 ns | 14.068 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.574 ns | 0.0246 ns | 0.0230 ns | 12.578 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.314 ns | 0.0120 ns | 0.0112 ns | 15.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.993 ns | 0.0083 ns | 0.0077 ns | 14.993 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.017 ns | 0.0055 ns | 0.0046 ns | 13.017 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 25.085 ns | 0.1066 ns | 0.0997 ns | 25.135 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 23.168 ns | 0.0459 ns | 0.0429 ns | 23.192 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.692 ns | 0.0153 ns | 0.0144 ns | 11.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.305 ns | 0.0278 ns | 0.0260 ns | 10.303 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.826 ns | 0.0171 ns | 0.0160 ns |  9.830 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.097 ns | 0.0133 ns | 0.0125 ns | 12.095 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.136 ns | 0.0116 ns | 0.0102 ns | 12.134 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.922 ns | 0.0266 ns | 0.0236 ns | 19.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.643 ns | 0.0168 ns | 0.0157 ns | 17.641 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.927 ns | 0.0153 ns | 0.0143 ns | 16.922 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 28.737 ns | 0.2295 ns | 0.2147 ns | 28.663 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.327 ns | 0.1447 ns | 0.1353 ns | 27.367 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.084 ns | 0.0268 ns | 0.0250 ns | 13.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.584 ns | 0.0077 ns | 0.0072 ns | 10.583 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  9.816 ns | 0.0075 ns | 0.0071 ns |  9.814 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.601 ns | 0.0074 ns | 0.0069 ns | 12.603 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.688 ns | 0.0485 ns | 0.0453 ns | 12.687 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.925 ns | 0.0155 ns | 0.0145 ns | 19.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.424 ns | 0.0586 ns | 0.0548 ns | 17.440 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.903 ns | 0.0161 ns | 0.0143 ns | 16.902 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.384 ns | 0.0659 ns | 0.0616 ns | 27.374 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 28.174 ns | 0.0629 ns | 0.0558 ns | 28.151 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.244 ns | 0.0111 ns | 0.0098 ns | 12.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 11.336 ns | 0.0150 ns | 0.0140 ns | 11.338 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.577 ns | 0.0058 ns | 0.0054 ns |  9.578 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.803 ns | 0.0146 ns | 0.0137 ns | 12.800 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.586 ns | 0.0151 ns | 0.0141 ns | 12.586 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.311 ns | 0.0117 ns | 0.0109 ns | 15.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.647 ns | 0.0107 ns | 0.0100 ns | 13.650 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.298 ns | 0.2460 ns | 0.2301 ns | 15.177 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.855 ns | 0.0375 ns | 0.0351 ns | 22.856 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 21.800 ns | 0.0457 ns | 0.0428 ns | 21.804 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.687 ns | 0.0070 ns | 0.0065 ns | 11.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.617 ns | 0.0111 ns | 0.0103 ns | 10.613 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.597 ns | 0.0135 ns | 0.0120 ns |  9.601 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.789 ns | 0.0331 ns | 0.0309 ns | 12.794 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 14.154 ns | 0.0133 ns | 0.0118 ns | 14.155 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.563 ns | 0.0190 ns | 0.0169 ns | 19.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.248 ns | 0.0224 ns | 0.0210 ns | 18.245 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.150 ns | 0.0247 ns | 0.0219 ns | 17.148 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 26.548 ns | 0.0288 ns | 0.0270 ns | 26.557 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 26.792 ns | 0.1439 ns | 0.1346 ns | 26.823 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.715 ns | 0.0286 ns | 0.0268 ns | 11.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.557 ns | 0.0210 ns | 0.0187 ns | 10.553 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.832 ns | 0.0153 ns | 0.0143 ns |  9.830 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.036 ns | 0.0058 ns | 0.0051 ns | 13.036 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.587 ns | 0.0082 ns | 0.0077 ns | 12.585 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.672 ns | 0.0581 ns | 0.0544 ns | 20.665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.234 ns | 0.0152 ns | 0.0127 ns | 18.239 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.670 ns | 0.1333 ns | 0.1247 ns | 17.594 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 26.986 ns | 0.0511 ns | 0.0453 ns | 26.978 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 28.070 ns | 0.0285 ns | 0.0266 ns | 28.072 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.709 ns | 0.0115 ns | 0.0102 ns | 11.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 11.830 ns | 0.0231 ns | 0.0204 ns | 11.828 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.578 ns | 0.0102 ns | 0.0096 ns |  9.578 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.607 ns | 0.0262 ns | 0.0245 ns | 12.603 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.585 ns | 0.0143 ns | 0.0134 ns | 12.584 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.731 ns | 0.0106 ns | 0.0099 ns | 14.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.261 ns | 0.0102 ns | 0.0095 ns | 13.261 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.473 ns | 0.0287 ns | 0.0269 ns | 13.478 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.921 ns | 0.0320 ns | 0.0299 ns | 22.925 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.216 ns | 0.0243 ns | 0.0228 ns | 24.215 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 13.761 ns | 0.0109 ns | 0.0096 ns | 13.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.310 ns | 0.0273 ns | 0.0242 ns | 11.299 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.617 ns | 0.0236 ns | 0.0210 ns |  9.617 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.925 ns | 0.0099 ns | 0.0092 ns | 12.923 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 16.292 ns | 0.0434 ns | 0.0406 ns | 16.297 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.213 ns | 0.0097 ns | 0.0090 ns | 12.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.247 ns | 0.0177 ns | 0.0165 ns | 11.248 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.071 ns | 0.0248 ns | 0.0232 ns | 10.082 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.936 ns | 0.0112 ns | 0.0100 ns | 13.931 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.339 ns | 0.0171 ns | 0.0160 ns | 14.338 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.216 ns | 0.0093 ns | 0.0087 ns | 12.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.234 ns | 0.0073 ns | 0.0068 ns | 11.237 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  9.849 ns | 0.0149 ns | 0.0139 ns |  9.847 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.182 ns | 0.0333 ns | 0.0311 ns | 13.172 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 15.722 ns | 0.0180 ns | 0.0168 ns | 15.722 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.294 ns | 0.0393 ns | 0.0367 ns | 15.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.286 ns | 0.0150 ns | 0.0140 ns | 13.290 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.429 ns | 0.2863 ns | 0.2812 ns | 13.599 ns |  0.88 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.738 ns | 0.0300 ns | 0.0281 ns | 22.743 ns |  1.49 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 24.350 ns | 0.0361 ns | 0.0320 ns | 24.351 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 22.991 ns | 0.0231 ns | 0.0216 ns | 22.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.136 ns | 0.0476 ns | 0.0422 ns | 21.125 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.184 ns | 0.4119 ns | 0.8225 ns | 13.725 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.310 ns | 0.0407 ns | 0.0380 ns | 24.304 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 23.611 ns | 0.0596 ns | 0.0557 ns | 23.616 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.572 ns | 0.0206 ns | 0.0192 ns | 30.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.556 ns | 0.0172 ns | 0.0153 ns | 29.551 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.336 ns | 0.2520 ns | 0.2357 ns | 21.474 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 36.162 ns | 0.0190 ns | 0.0177 ns | 36.166 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 35.916 ns | 0.0428 ns | 0.0379 ns | 35.912 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 24.451 ns | 0.0722 ns | 0.0640 ns | 24.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.095 ns | 0.0300 ns | 0.0281 ns | 23.089 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.718 ns | 0.0218 ns | 0.0204 ns | 18.714 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.851 ns | 0.0143 ns | 0.0127 ns | 25.854 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.190 ns | 0.0188 ns | 0.0175 ns | 25.194 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.531 ns | 0.0264 ns | 0.0247 ns | 30.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.023 ns | 0.0621 ns | 0.0581 ns | 29.029 ns |  0.95 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.012 ns | 0.0118 ns | 0.0110 ns | 21.010 ns |  0.69 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 35.427 ns | 0.1013 ns | 0.0948 ns | 35.455 ns |  1.16 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 35.713 ns | 0.0561 ns | 0.0524 ns | 35.730 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.469 ns | 0.0159 ns | 0.0149 ns | 12.466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.414 ns | 0.0064 ns | 0.0060 ns | 11.414 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.845 ns | 0.0174 ns | 0.0154 ns |  9.847 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.412 ns | 0.0091 ns | 0.0085 ns | 13.411 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.349 ns | 0.0046 ns | 0.0039 ns | 13.348 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.827 ns | 0.0190 ns | 0.0178 ns | 14.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.284 ns | 0.0135 ns | 0.0126 ns | 13.286 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.720 ns | 0.2574 ns | 0.2407 ns | 13.928 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 22.769 ns | 0.0224 ns | 0.0199 ns | 22.769 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.740 ns | 0.0236 ns | 0.0221 ns | 22.737 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.906 ns | 0.0172 ns | 0.0153 ns | 13.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.416 ns | 0.0247 ns | 0.0219 ns | 12.415 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.333 ns | 0.0049 ns | 0.0043 ns | 12.334 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.244 ns | 0.0454 ns | 0.0424 ns | 14.242 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.223 ns | 0.0418 ns | 0.0391 ns | 14.237 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.855 ns | 0.0137 ns | 0.0128 ns | 20.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 19.538 ns | 0.0171 ns | 0.0160 ns | 19.539 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.960 ns | 0.0232 ns | 0.0206 ns | 18.958 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 28.187 ns | 0.0295 ns | 0.0276 ns | 28.175 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 28.162 ns | 0.0182 ns | 0.0170 ns | 28.165 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.628 ns | 0.0271 ns | 0.0253 ns | 14.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 13.539 ns | 0.0124 ns | 0.0116 ns | 13.538 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.297 ns | 0.0150 ns | 0.0133 ns | 12.300 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.165 ns | 0.0200 ns | 0.0187 ns | 15.164 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 14.999 ns | 0.0173 ns | 0.0161 ns | 14.997 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.534 ns | 0.0219 ns | 0.0205 ns | 21.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.957 ns | 0.0470 ns | 0.0440 ns | 18.971 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.369 ns | 0.4539 ns | 0.9575 ns | 21.820 ns |  0.94 |    0.06 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 28.240 ns | 0.0304 ns | 0.0284 ns | 28.235 ns |  1.31 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 29.634 ns | 0.0593 ns | 0.0555 ns | 29.642 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.213 ns | 0.0076 ns | 0.0071 ns | 12.213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.292 ns | 0.0082 ns | 0.0077 ns | 11.293 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.023 ns | 0.0279 ns | 0.0261 ns | 10.026 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.328 ns | 0.0100 ns | 0.0093 ns | 13.331 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.360 ns | 0.0066 ns | 0.0059 ns | 13.360 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.752 ns | 0.0156 ns | 0.0146 ns | 15.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.291 ns | 0.0208 ns | 0.0194 ns | 13.283 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.905 ns | 0.0067 ns | 0.0060 ns | 13.905 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.464 ns | 0.0227 ns | 0.0201 ns | 22.470 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.544 ns | 0.0287 ns | 0.0268 ns | 22.544 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.716 ns | 0.0161 ns | 0.0151 ns | 11.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.151 ns | 0.0094 ns | 0.0084 ns | 11.153 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 | 10.209 ns | 0.1402 ns | 0.1312 ns | 10.306 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.851 ns | 0.0194 ns | 0.0182 ns | 12.856 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.817 ns | 0.0283 ns | 0.0265 ns | 12.821 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.954 ns | 0.0150 ns | 0.0141 ns | 19.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.957 ns | 0.0322 ns | 0.0285 ns | 17.959 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.039 ns | 0.0572 ns | 0.0535 ns | 18.034 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.324 ns | 0.0213 ns | 0.0199 ns | 27.326 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.026 ns | 0.0253 ns | 0.0237 ns | 27.025 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.947 ns | 0.0171 ns | 0.0151 ns | 11.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.559 ns | 0.0063 ns | 0.0056 ns | 10.560 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.032 ns | 0.0062 ns | 0.0055 ns | 10.031 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 13.068 ns | 0.0105 ns | 0.0099 ns | 13.067 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.039 ns | 0.0092 ns | 0.0086 ns | 13.041 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.655 ns | 0.0079 ns | 0.0074 ns | 19.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.631 ns | 0.0541 ns | 0.0506 ns | 17.621 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.230 ns | 0.0824 ns | 0.0771 ns | 17.282 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.377 ns | 0.0602 ns | 0.0563 ns | 27.388 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.164 ns | 0.0461 ns | 0.0409 ns | 27.168 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.949 ns | 0.0098 ns | 0.0091 ns | 11.947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.385 ns | 0.0125 ns | 0.0117 ns | 10.384 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.346 ns | 0.0235 ns | 0.0183 ns |  9.347 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.303 ns | 0.0085 ns | 0.0071 ns | 13.301 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.584 ns | 0.0075 ns | 0.0066 ns | 12.584 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.294 ns | 0.0139 ns | 0.0130 ns | 15.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.264 ns | 0.0070 ns | 0.0065 ns | 13.265 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.474 ns | 0.1526 ns | 0.1428 ns | 15.423 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.581 ns | 0.0412 ns | 0.0385 ns | 22.574 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 22.427 ns | 0.0131 ns | 0.0122 ns | 22.431 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.701 ns | 0.0105 ns | 0.0098 ns | 11.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.209 ns | 0.0212 ns | 0.0199 ns | 11.207 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.826 ns | 0.0080 ns | 0.0075 ns |  9.824 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.169 ns | 0.0225 ns | 0.0211 ns | 13.172 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.183 ns | 0.0256 ns | 0.0239 ns | 13.192 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.890 ns | 0.0113 ns | 0.0106 ns | 20.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.216 ns | 0.0166 ns | 0.0155 ns | 18.214 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.139 ns | 0.0158 ns | 0.0148 ns | 17.134 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 28.931 ns | 0.0467 ns | 0.0414 ns | 28.938 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 26.965 ns | 0.0292 ns | 0.0273 ns | 26.968 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.941 ns | 0.0129 ns | 0.0115 ns | 11.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.355 ns | 0.0100 ns | 0.0093 ns | 11.353 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.046 ns | 0.0216 ns | 0.0180 ns | 10.048 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.057 ns | 0.0072 ns | 0.0064 ns | 13.057 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.615 ns | 0.0083 ns | 0.0077 ns | 13.612 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.972 ns | 0.0171 ns | 0.0152 ns | 20.972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.653 ns | 0.0151 ns | 0.0134 ns | 17.653 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.774 ns | 0.0263 ns | 0.0246 ns | 17.772 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 26.787 ns | 0.0620 ns | 0.0580 ns | 26.769 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.468 ns | 0.0172 ns | 0.0152 ns | 29.467 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.931 ns | 0.0079 ns | 0.0070 ns | 11.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.341 ns | 0.0297 ns | 0.0277 ns | 10.330 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.575 ns | 0.0111 ns | 0.0104 ns |  9.577 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.623 ns | 0.0089 ns | 0.0083 ns | 12.620 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.589 ns | 0.0076 ns | 0.0071 ns | 12.588 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.750 ns | 0.0112 ns | 0.0099 ns | 14.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.973 ns | 0.0207 ns | 0.0194 ns | 13.973 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.021 ns | 0.0227 ns | 0.0212 ns | 13.022 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.785 ns | 0.0661 ns | 0.0619 ns | 22.798 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.663 ns | 0.0279 ns | 0.0261 ns | 22.666 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.702 ns | 0.0100 ns | 0.0089 ns | 12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.414 ns | 0.0199 ns | 0.0186 ns | 11.415 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 10.057 ns | 0.0081 ns | 0.0068 ns | 10.058 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.561 ns | 0.0355 ns | 0.0332 ns | 13.575 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.040 ns | 0.0246 ns | 0.0230 ns | 13.041 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.386 ns | 0.0238 ns | 0.0222 ns | 20.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.280 ns | 0.0113 ns | 0.0106 ns | 18.280 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 17.630 ns | 0.0218 ns | 0.0193 ns | 17.631 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.565 ns | 0.0323 ns | 0.0302 ns | 27.566 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.845 ns | 0.0318 ns | 0.0297 ns | 29.852 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.817 ns | 0.0375 ns | 0.0351 ns | 14.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.602 ns | 0.0096 ns | 0.0090 ns | 12.599 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 12.160 ns | 0.2656 ns | 0.4363 ns | 12.320 ns |  0.81 |    0.04 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.670 ns | 0.0179 ns | 0.0168 ns | 15.669 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.438 ns | 0.0242 ns | 0.0226 ns | 14.440 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.467 ns | 0.0186 ns | 0.0174 ns | 20.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.063 ns | 0.0161 ns | 0.0150 ns | 18.065 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.594 ns | 0.0579 ns | 0.0514 ns | 17.604 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 29.367 ns | 0.0607 ns | 0.0568 ns | 29.363 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.250 ns | 0.0502 ns | 0.0445 ns | 27.241 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.271 ns | 0.0134 ns | 0.0125 ns | 12.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.299 ns | 0.0089 ns | 0.0079 ns | 11.300 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 | 10.512 ns | 0.2359 ns | 0.3875 ns | 10.668 ns |  0.84 |    0.04 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.797 ns | 0.0202 ns | 0.0189 ns | 13.804 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.244 ns | 0.0108 ns | 0.0101 ns | 13.244 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.803 ns | 0.0159 ns | 0.0141 ns | 14.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.265 ns | 0.0085 ns | 0.0080 ns | 13.266 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.085 ns | 0.0447 ns | 0.0418 ns | 13.096 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.908 ns | 0.0276 ns | 0.0258 ns | 22.906 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 21.608 ns | 0.0561 ns | 0.0525 ns | 21.605 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.712 ns | 0.0154 ns | 0.0120 ns | 11.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.417 ns | 0.0140 ns | 0.0131 ns | 10.420 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.619 ns | 0.0290 ns | 0.0257 ns |  9.620 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.511 ns | 0.0339 ns | 0.0317 ns | 13.505 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.858 ns | 0.0237 ns | 0.0222 ns | 12.866 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.644 ns | 0.0131 ns | 0.0123 ns | 19.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.672 ns | 0.0188 ns | 0.0175 ns | 17.665 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 18.288 ns | 0.3787 ns | 0.4651 ns | 18.015 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.602 ns | 0.0212 ns | 0.0198 ns | 27.600 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.235 ns | 0.0289 ns | 0.0271 ns | 27.232 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.916 ns | 0.0226 ns | 0.0211 ns | 11.920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.562 ns | 0.0080 ns | 0.0075 ns | 10.562 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  9.814 ns | 0.0133 ns | 0.0118 ns |  9.814 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.071 ns | 0.0070 ns | 0.0055 ns | 13.072 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.654 ns | 0.0122 ns | 0.0108 ns | 13.656 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.644 ns | 0.0160 ns | 0.0142 ns | 19.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.971 ns | 0.0135 ns | 0.0127 ns | 17.969 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.149 ns | 0.0217 ns | 0.0203 ns | 17.150 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.515 ns | 0.0314 ns | 0.0294 ns | 27.511 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.834 ns | 0.0607 ns | 0.0568 ns | 28.824 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.879 ns | 0.0075 ns | 0.0070 ns | 12.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.385 ns | 0.0090 ns | 0.0075 ns | 10.387 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.585 ns | 0.0159 ns | 0.0141 ns |  9.584 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.603 ns | 0.0070 ns | 0.0062 ns | 12.601 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.578 ns | 0.0100 ns | 0.0089 ns | 12.579 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.675 ns | 0.0272 ns | 0.0241 ns | 14.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.987 ns | 0.0074 ns | 0.0070 ns | 13.986 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.034 ns | 0.0297 ns | 0.0278 ns | 13.023 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.771 ns | 0.0865 ns | 0.0809 ns | 22.796 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.550 ns | 0.0289 ns | 0.0270 ns | 22.549 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.983 ns | 0.0097 ns | 0.0081 ns | 13.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.141 ns | 0.0142 ns | 0.0133 ns | 12.143 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.331 ns | 0.0064 ns | 0.0060 ns | 12.332 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.243 ns | 0.0189 ns | 0.0168 ns | 14.238 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.441 ns | 0.0509 ns | 0.0476 ns | 14.445 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.695 ns | 0.0157 ns | 0.0147 ns | 21.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.968 ns | 0.0285 ns | 0.0267 ns | 18.980 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.655 ns | 0.0643 ns | 0.0570 ns | 19.644 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 28.442 ns | 0.0622 ns | 0.0582 ns | 28.459 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 29.928 ns | 0.0384 ns | 0.0340 ns | 29.929 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.753 ns | 0.0170 ns | 0.0159 ns | 13.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.489 ns | 0.0064 ns | 0.0060 ns | 13.489 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.080 ns | 0.0110 ns | 0.0098 ns | 12.083 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.355 ns | 0.0246 ns | 0.0230 ns | 14.352 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.595 ns | 0.0221 ns | 0.0196 ns | 14.598 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.912 ns | 0.0623 ns | 0.0520 ns | 20.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.041 ns | 0.0151 ns | 0.0134 ns | 19.043 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.546 ns | 0.0224 ns | 0.0209 ns | 20.546 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 28.618 ns | 0.0718 ns | 0.0672 ns | 28.613 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 28.518 ns | 0.0769 ns | 0.0720 ns | 28.513 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.931 ns | 0.0094 ns | 0.0083 ns | 11.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.227 ns | 0.0098 ns | 0.0087 ns | 11.226 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.808 ns | 0.0094 ns | 0.0078 ns |  9.805 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.424 ns | 0.0171 ns | 0.0160 ns | 13.425 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.807 ns | 0.0079 ns | 0.0074 ns | 12.808 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.597 ns | 0.0249 ns | 0.0233 ns | 15.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.267 ns | 0.0106 ns | 0.0100 ns | 13.269 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.486 ns | 0.0226 ns | 0.0212 ns | 13.484 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.560 ns | 0.0545 ns | 0.0510 ns | 22.559 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 21.887 ns | 0.0224 ns | 0.0209 ns | 21.888 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 60.647 ns | 0.1780 ns | 0.1665 ns | 60.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 55.305 ns | 0.1000 ns | 0.0936 ns | 55.284 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 23.633 ns | 0.0261 ns | 0.0231 ns | 23.638 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 56.774 ns | 0.0981 ns | 0.0918 ns | 56.764 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 58.168 ns | 0.1530 ns | 0.1356 ns | 58.192 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.716 ns | 0.0642 ns | 0.0601 ns | 64.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.848 ns | 0.1692 ns | 0.1582 ns | 58.814 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 30.741 ns | 0.3012 ns | 0.2818 ns | 30.744 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 70.466 ns | 0.1080 ns | 0.1011 ns | 70.483 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 72.163 ns | 0.0760 ns | 0.0711 ns | 72.138 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.950 ns | 0.0212 ns | 0.0198 ns | 13.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.476 ns | 0.0339 ns | 0.0317 ns | 18.482 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 14.379 ns | 0.2266 ns | 0.2120 ns | 14.353 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 16.861 ns | 0.0343 ns | 0.0304 ns | 16.850 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 13.279 ns | 0.0094 ns | 0.0084 ns | 13.281 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.625 ns | 0.0276 ns | 0.0258 ns | 14.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.262 ns | 0.0069 ns | 0.0064 ns | 13.262 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.483 ns | 0.0322 ns | 0.0285 ns | 13.473 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 24.225 ns | 0.0233 ns | 0.0218 ns | 24.229 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 22.450 ns | 0.0659 ns | 0.0617 ns | 22.448 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.930 ns | 0.0099 ns | 0.0093 ns | 13.932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.611 ns | 0.0534 ns | 0.0499 ns | 18.584 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.498 ns | 0.0235 ns | 0.0220 ns | 13.489 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.616 ns | 0.0058 ns | 0.0054 ns | 14.616 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.280 ns | 0.0118 ns | 0.0111 ns | 13.283 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.710 ns | 0.0277 ns | 0.0259 ns | 11.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.327 ns | 0.0134 ns | 0.0125 ns | 10.325 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.617 ns | 0.0097 ns | 0.0090 ns |  9.617 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.099 ns | 0.0096 ns | 0.0090 ns | 12.097 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.784 ns | 0.0289 ns | 0.0270 ns | 12.786 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.427 ns | 0.0175 ns | 0.0164 ns | 19.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.502 ns | 0.0210 ns | 0.0196 ns | 17.496 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.995 ns | 0.0155 ns | 0.0145 ns | 16.997 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 28.991 ns | 0.0162 ns | 0.0144 ns | 28.993 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 28.422 ns | 0.0234 ns | 0.0219 ns | 28.433 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.760 ns | 0.0289 ns | 0.0241 ns | 11.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.588 ns | 0.0126 ns | 0.0118 ns | 10.591 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  9.816 ns | 0.0063 ns | 0.0059 ns |  9.815 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.593 ns | 0.0270 ns | 0.0253 ns | 12.600 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.606 ns | 0.0071 ns | 0.0059 ns | 12.606 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.277 ns | 0.0254 ns | 0.0237 ns | 19.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.367 ns | 0.0092 ns | 0.0082 ns | 17.367 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.963 ns | 0.0952 ns | 0.0891 ns | 17.963 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 26.597 ns | 0.0254 ns | 0.0238 ns | 26.598 ns |  1.38 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 28.398 ns | 0.0401 ns | 0.0375 ns | 28.397 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.713 ns | 0.0201 ns | 0.0188 ns | 11.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 11.678 ns | 0.0123 ns | 0.0109 ns | 11.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.578 ns | 0.0087 ns | 0.0081 ns |  9.580 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.600 ns | 0.0090 ns | 0.0085 ns | 12.602 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.588 ns | 0.0102 ns | 0.0095 ns | 12.586 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.083 ns | 0.0197 ns | 0.0184 ns | 15.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.991 ns | 0.0089 ns | 0.0084 ns | 14.992 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.471 ns | 0.0143 ns | 0.0134 ns | 13.476 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 22.772 ns | 0.0172 ns | 0.0161 ns | 22.769 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.276 ns | 0.0273 ns | 0.0256 ns | 24.279 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.706 ns | 0.0158 ns | 0.0148 ns | 11.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.336 ns | 0.0086 ns | 0.0081 ns | 10.337 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.603 ns | 0.0119 ns | 0.0112 ns |  9.602 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.123 ns | 0.0151 ns | 0.0126 ns | 12.127 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.116 ns | 0.0124 ns | 0.0097 ns | 12.119 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 23.940 ns | 0.0087 ns | 0.0082 ns | 23.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 25.402 ns | 0.0261 ns | 0.0244 ns | 25.398 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 26.943 ns | 0.0436 ns | 0.0408 ns | 26.941 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 36.958 ns | 0.0862 ns | 0.0764 ns | 36.952 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 35.376 ns | 0.0472 ns | 0.0442 ns | 35.387 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.282 ns | 0.0049 ns | 0.0046 ns | 11.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.206 ns | 0.0087 ns | 0.0082 ns | 10.209 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.218 ns | 0.1703 ns | 0.2274 ns |  7.339 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.266 ns | 0.0046 ns | 0.0041 ns | 12.266 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.634 ns | 0.0073 ns | 0.0068 ns | 11.633 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.345 ns | 0.0147 ns | 0.0137 ns | 24.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.374 ns | 0.0699 ns | 0.0619 ns | 25.374 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 28.754 ns | 0.0338 ns | 0.0316 ns | 28.760 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 35.173 ns | 0.0618 ns | 0.0578 ns | 35.168 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 36.692 ns | 0.0834 ns | 0.0780 ns | 36.695 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.153 ns | 0.0096 ns | 0.0080 ns | 12.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.203 ns | 0.0088 ns | 0.0082 ns | 10.205 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.817 ns | 0.0054 ns | 0.0050 ns |  6.817 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.565 ns | 0.0320 ns | 0.0299 ns | 11.557 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.642 ns | 0.0124 ns | 0.0116 ns | 11.644 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.717 ns | 0.0135 ns | 0.0126 ns | 14.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.022 ns | 0.0359 ns | 0.0336 ns | 14.023 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.090 ns | 0.2290 ns | 0.2142 ns | 14.258 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 25.712 ns | 0.0202 ns | 0.0179 ns | 25.714 ns |  1.75 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 25.520 ns | 0.0506 ns | 0.0449 ns | 25.531 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.722 ns | 0.0068 ns | 0.0060 ns | 11.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.451 ns | 0.0080 ns | 0.0075 ns | 10.450 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.600 ns | 0.0067 ns | 0.0060 ns |  9.601 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.791 ns | 0.0147 ns | 0.0138 ns | 12.789 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.832 ns | 0.0115 ns | 0.0108 ns | 12.831 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.987 ns | 0.0148 ns | 0.0138 ns | 19.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.819 ns | 0.0179 ns | 0.0167 ns | 17.818 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.217 ns | 0.3910 ns | 0.6639 ns | 18.605 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.373 ns | 0.0448 ns | 0.0419 ns | 27.368 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 27.195 ns | 0.0339 ns | 0.0317 ns | 27.190 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.736 ns | 0.0111 ns | 0.0103 ns | 12.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.739 ns | 0.0209 ns | 0.0186 ns | 11.744 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 10.609 ns | 0.1897 ns | 0.1774 ns | 10.497 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.401 ns | 0.0111 ns | 0.0098 ns | 14.403 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 15.158 ns | 0.0185 ns | 0.0173 ns | 15.162 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.142 ns | 0.0182 ns | 0.0170 ns | 20.144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.815 ns | 0.0276 ns | 0.0258 ns | 17.810 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.158 ns | 0.0652 ns | 0.0578 ns | 17.138 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.421 ns | 0.0390 ns | 0.0365 ns | 27.426 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.251 ns | 0.0382 ns | 0.0358 ns | 27.239 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.380 ns | 0.0191 ns | 0.0179 ns | 12.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.327 ns | 0.0083 ns | 0.0074 ns | 11.325 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.799 ns | 0.0084 ns | 0.0070 ns |  9.799 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.685 ns | 0.0401 ns | 0.0356 ns | 14.690 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 20.007 ns | 0.0179 ns | 0.0168 ns | 20.010 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.315 ns | 0.0079 ns | 0.0070 ns | 15.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.007 ns | 0.0246 ns | 0.0218 ns | 14.010 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.984 ns | 0.0334 ns | 0.0312 ns | 13.984 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.561 ns | 0.0367 ns | 0.0325 ns | 22.553 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.364 ns | 0.0387 ns | 0.0362 ns | 24.362 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.654 ns | 0.0094 ns | 0.0088 ns | 14.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.258 ns | 0.0083 ns | 0.0073 ns | 13.258 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.484 ns | 0.0285 ns | 0.0266 ns | 13.484 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.623 ns | 0.0443 ns | 0.0415 ns | 22.615 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 24.343 ns | 0.0415 ns | 0.0388 ns | 24.350 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.388 ns | 0.0134 ns | 0.0125 ns | 12.389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.188 ns | 0.0062 ns | 0.0055 ns | 11.187 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.618 ns | 0.0097 ns | 0.0081 ns | 12.619 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.798 ns | 0.0075 ns | 0.0071 ns | 12.799 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.901 ns | 0.2025 ns | 0.1894 ns | 13.876 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.485 ns | 0.0200 ns | 0.0187 ns | 15.484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.986 ns | 0.0300 ns | 0.0281 ns | 13.986 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.534 ns | 0.0505 ns | 0.0472 ns | 13.516 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.592 ns | 0.0265 ns | 0.0248 ns | 22.595 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 22.551 ns | 0.0198 ns | 0.0175 ns | 22.557 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.024 ns | 0.0187 ns | 0.0156 ns | 18.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.940 ns | 0.0117 ns | 0.0103 ns | 14.938 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.843 ns | 0.0252 ns | 0.0235 ns | 14.841 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.864 ns | 0.0535 ns | 0.0500 ns | 25.854 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 26.887 ns | 0.0261 ns | 0.0244 ns | 26.887 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.278 ns | 0.0138 ns | 0.0129 ns | 18.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.136 ns | 0.0152 ns | 0.0142 ns | 17.138 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.553 ns | 0.3170 ns | 0.2965 ns | 17.778 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 28.553 ns | 0.0128 ns | 0.0114 ns | 28.552 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 25.862 ns | 0.0446 ns | 0.0418 ns | 25.866 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.655 ns | 0.0117 ns | 0.0104 ns | 15.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.964 ns | 0.0278 ns | 0.0260 ns | 12.952 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.793 ns | 0.2388 ns | 0.2234 ns | 13.673 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.536 ns | 0.0336 ns | 0.0298 ns | 24.526 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.821 ns | 0.0486 ns | 0.0455 ns | 24.828 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.332 ns | 0.0197 ns | 0.0175 ns | 16.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.942 ns | 0.0046 ns | 0.0041 ns | 13.942 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 15.368 ns | 0.3316 ns | 0.6308 ns | 15.575 ns |  0.91 |    0.06 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.924 ns | 0.0824 ns | 0.0771 ns | 22.893 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.724 ns | 0.1773 ns | 0.1658 ns | 24.804 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.710 ns | 0.0079 ns | 0.0070 ns | 13.710 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.107 ns | 0.0074 ns | 0.0069 ns | 12.104 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.352 ns | 0.0090 ns | 0.0084 ns | 12.349 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.852 ns | 0.0086 ns | 0.0080 ns | 14.848 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.847 ns | 0.0150 ns | 0.0141 ns | 14.849 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.430 ns | 0.0119 ns | 0.0106 ns | 16.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.150 ns | 0.0418 ns | 0.0391 ns | 15.140 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.265 ns | 0.0207 ns | 0.0194 ns | 15.268 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.043 ns | 0.0318 ns | 0.0297 ns | 24.043 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.083 ns | 0.0374 ns | 0.0349 ns | 24.092 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.716 ns | 0.0261 ns | 0.0244 ns | 13.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.104 ns | 0.0049 ns | 0.0046 ns | 12.104 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.360 ns | 0.0139 ns | 0.0130 ns | 12.361 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.218 ns | 0.0335 ns | 0.0314 ns | 14.215 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.845 ns | 0.0066 ns | 0.0062 ns | 14.845 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.472 ns | 0.0094 ns | 0.0083 ns | 15.471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.265 ns | 0.0092 ns | 0.0082 ns | 13.267 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.035 ns | 0.0207 ns | 0.0194 ns | 13.037 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.702 ns | 0.0321 ns | 0.0300 ns | 22.707 ns |  1.47 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 22.688 ns | 0.0341 ns | 0.0319 ns | 22.688 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.985 ns | 0.0643 ns | 0.0602 ns | 19.973 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.019 ns | 0.0524 ns | 0.0490 ns | 16.029 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.376 ns | 0.0345 ns | 0.0322 ns | 13.372 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.660 ns | 0.0731 ns | 0.0684 ns | 18.662 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.668 ns | 0.0229 ns | 0.0215 ns | 18.664 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.024 ns | 0.0150 ns | 0.0133 ns | 19.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.361 ns | 0.0163 ns | 0.0153 ns | 17.366 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.253 ns | 0.3808 ns | 0.5212 ns | 18.622 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.180 ns | 0.0211 ns | 0.0197 ns | 28.176 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 27.907 ns | 0.0514 ns | 0.0481 ns | 27.916 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.843 ns | 0.0340 ns | 0.0318 ns | 19.843 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.464 ns | 0.0310 ns | 0.0290 ns | 16.471 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.889 ns | 0.0356 ns | 0.0333 ns | 13.889 ns |  0.70 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.522 ns | 0.0209 ns | 0.0185 ns | 24.524 ns |  1.24 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.401 ns | 0.0655 ns | 0.0612 ns | 24.418 ns |  1.23 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.011 ns | 0.0144 ns | 0.0135 ns | 19.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.531 ns | 0.0385 ns | 0.0360 ns | 17.538 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.619 ns | 0.3900 ns | 0.6516 ns | 19.010 ns |  0.95 |    0.04 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.529 ns | 0.1194 ns | 0.1117 ns | 26.569 ns |  1.40 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.181 ns | 0.0361 ns | 0.0338 ns | 26.180 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.705 ns | 0.0088 ns | 0.0083 ns | 13.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.875 ns | 0.0126 ns | 0.0112 ns | 11.875 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.821 ns | 0.0226 ns | 0.0211 ns |  9.825 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 21.396 ns | 0.1434 ns | 0.1341 ns | 21.381 ns |  1.56 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.446 ns | 0.0166 ns | 0.0155 ns | 19.447 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.664 ns | 0.0190 ns | 0.0178 ns | 14.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.457 ns | 0.0156 ns | 0.0146 ns | 14.461 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.1145 ns | 0.1071 ns | 13.021 ns |  0.89 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.595 ns | 0.0240 ns | 0.0225 ns | 22.598 ns |  1.54 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.068 ns | 0.0692 ns | 0.0614 ns | 22.072 ns |  1.50 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.633 ns | 0.0065 ns | 0.0051 ns | 13.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.264 ns | 0.0214 ns | 0.0200 ns | 10.268 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.159 ns | 0.0109 ns | 0.0091 ns |  9.160 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.118 ns | 0.0262 ns | 0.0245 ns | 12.116 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.780 ns | 0.0112 ns | 0.0104 ns | 12.782 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.535 ns | 0.0161 ns | 0.0151 ns | 16.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.144 ns | 0.0163 ns | 0.0153 ns | 15.143 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.282 ns | 0.0169 ns | 0.0158 ns | 15.281 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.675 ns | 0.0269 ns | 0.0239 ns | 25.681 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 23.692 ns | 0.0329 ns | 0.0307 ns | 23.683 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 11.688 ns | 0.0080 ns | 0.0067 ns | 11.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.420 ns | 0.0069 ns | 0.0064 ns | 11.421 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.650 ns | 0.3771 ns | 0.5034 ns |  9.373 ns |  0.85 |    0.05 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.118 ns | 0.0098 ns | 0.0092 ns | 12.119 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.827 ns | 0.0316 ns | 0.0296 ns | 12.822 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.055 ns | 0.0299 ns | 0.0280 ns | 18.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.676 ns | 0.0251 ns | 0.0223 ns | 15.677 ns |  0.87 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.440 ns | 0.2386 ns | 0.2232 ns | 15.301 ns |  0.86 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.281 ns | 0.1303 ns | 0.1219 ns | 24.246 ns |  1.34 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 23.712 ns | 0.0434 ns | 0.0406 ns | 23.709 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 11.999 ns | 0.0050 ns | 0.0042 ns | 11.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.258 ns | 0.0090 ns | 0.0084 ns | 10.260 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.158 ns | 0.0046 ns | 0.0040 ns |  9.158 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.123 ns | 0.0092 ns | 0.0086 ns | 12.121 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.778 ns | 0.0105 ns | 0.0093 ns | 12.778 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.320 ns | 0.0086 ns | 0.0080 ns | 15.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.260 ns | 0.0105 ns | 0.0093 ns | 13.258 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.932 ns | 0.0370 ns | 0.0346 ns | 13.915 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.622 ns | 0.0121 ns | 0.0113 ns | 22.624 ns |  1.48 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.612 ns | 0.0258 ns | 0.0241 ns | 22.617 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.829 ns | 0.0289 ns | 0.0270 ns | 12.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.371 ns | 0.0129 ns | 0.0121 ns | 10.373 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.137 ns | 0.0213 ns | 0.0200 ns |  9.139 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.047 ns | 0.0513 ns | 0.0480 ns | 13.049 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.829 ns | 0.0207 ns | 0.0194 ns | 12.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 48.363 ns | 0.0473 ns | 0.0419 ns | 48.370 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.450 ns | 0.0677 ns | 0.0633 ns | 42.450 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.006 ns | 0.8004 ns | 0.7487 ns | 39.526 ns |  0.81 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.433 ns | 0.0348 ns | 0.0291 ns | 50.434 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.308 ns | 0.0760 ns | 0.0711 ns | 50.328 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 11.930 ns | 0.0073 ns | 0.0069 ns | 11.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.649 ns | 0.0066 ns | 0.0058 ns | 11.648 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.294 ns | 0.0119 ns | 0.0112 ns | 10.297 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.056 ns | 0.0078 ns | 0.0069 ns | 13.057 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.079 ns | 0.0257 ns | 0.0228 ns | 13.076 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 47.951 ns | 0.0651 ns | 0.0577 ns | 47.942 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.385 ns | 0.0963 ns | 0.0900 ns | 42.374 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 44.498 ns | 0.1503 ns | 0.1406 ns | 44.551 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.830 ns | 0.1425 ns | 0.1333 ns | 51.860 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 50.301 ns | 0.0994 ns | 0.0930 ns | 50.307 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 11.928 ns | 0.0102 ns | 0.0095 ns | 11.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 12.854 ns | 0.0070 ns | 0.0059 ns | 12.854 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.604 ns | 0.0194 ns | 0.0181 ns |  9.608 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.601 ns | 0.0081 ns | 0.0076 ns | 12.603 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.604 ns | 0.0086 ns | 0.0081 ns | 12.608 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.650 ns | 0.0100 ns | 0.0089 ns | 14.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.939 ns | 0.0101 ns | 0.0094 ns | 13.942 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.184 ns | 0.1789 ns | 0.1674 ns | 13.327 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.742 ns | 0.0356 ns | 0.0333 ns | 22.739 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 22.659 ns | 0.0263 ns | 0.0246 ns | 22.661 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.725 ns | 0.0257 ns | 0.0241 ns | 13.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.128 ns | 0.0137 ns | 0.0128 ns | 12.129 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.588 ns | 0.0187 ns | 0.0175 ns | 12.590 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.198 ns | 0.0287 ns | 0.0268 ns | 14.201 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.846 ns | 0.0121 ns | 0.0113 ns | 14.845 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.594 ns | 0.0175 ns | 0.0155 ns | 17.593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.648 ns | 0.0183 ns | 0.0163 ns | 15.649 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.225 ns | 0.3122 ns | 0.2920 ns | 16.332 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.401 ns | 0.0726 ns | 0.0679 ns | 24.400 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.911 ns | 0.0819 ns | 0.0726 ns | 24.921 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.705 ns | 0.0077 ns | 0.0072 ns | 13.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.106 ns | 0.0096 ns | 0.0090 ns | 12.106 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.350 ns | 0.0076 ns | 0.0071 ns | 12.348 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.176 ns | 0.0268 ns | 0.0251 ns | 14.168 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.163 ns | 0.0095 ns | 0.0084 ns | 14.162 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.339 ns | 0.0487 ns | 0.0455 ns | 15.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.285 ns | 0.0138 ns | 0.0129 ns | 13.288 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.682 ns | 0.2145 ns | 0.2007 ns | 13.538 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.612 ns | 0.0321 ns | 0.0300 ns | 22.607 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.554 ns | 0.0271 ns | 0.0253 ns | 22.551 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 40.348 ns | 0.0260 ns | 0.0243 ns | 40.344 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.336 ns | 0.0346 ns | 0.0324 ns | 38.340 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.172 ns | 0.1315 ns | 0.1166 ns | 38.186 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.421 ns | 0.0388 ns | 0.0363 ns | 40.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 41.265 ns | 0.0572 ns | 0.0535 ns | 41.260 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.947 ns | 0.0150 ns | 0.0140 ns | 16.944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 17.048 ns | 0.0176 ns | 0.0165 ns | 17.051 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 17.640 ns | 0.0805 ns | 0.0713 ns | 17.644 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 27.185 ns | 0.0189 ns | 0.0177 ns | 27.183 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 23.958 ns | 0.0720 ns | 0.0673 ns | 23.967 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.963 ns | 0.1059 ns | 0.0990 ns | 39.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.723 ns | 0.0589 ns | 0.0551 ns | 38.721 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 37.741 ns | 0.0580 ns | 0.0543 ns | 37.727 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.668 ns | 0.0341 ns | 0.0319 ns | 40.666 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.949 ns | 0.0385 ns | 0.0360 ns | 40.944 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.807 ns | 0.0114 ns | 0.0095 ns | 17.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.702 ns | 0.0228 ns | 0.0202 ns | 17.699 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.357 ns | 0.2547 ns | 0.2382 ns | 15.393 ns |  0.86 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.250 ns | 0.0471 ns | 0.0441 ns | 24.252 ns |  1.36 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 25.864 ns | 0.0269 ns | 0.0252 ns | 25.864 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 41.903 ns | 0.0251 ns | 0.0223 ns | 41.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.672 ns | 0.1515 ns | 0.1417 ns | 38.635 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.120 ns | 0.0906 ns | 0.0848 ns | 38.131 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.589 ns | 0.1050 ns | 0.0983 ns | 40.572 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 45.046 ns | 0.0620 ns | 0.0550 ns | 45.065 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.330 ns | 0.0121 ns | 0.0113 ns | 15.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.266 ns | 0.0105 ns | 0.0099 ns | 13.266 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.090 ns | 0.2804 ns | 0.2623 ns | 13.915 ns |  0.92 |    0.02 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 22.845 ns | 0.0519 ns | 0.0485 ns | 22.831 ns |  1.49 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.895 ns | 0.0710 ns | 0.0664 ns | 22.890 ns |  1.49 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
