
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
                                             From_Bool | .NET Core 2.0 | 12.949 ns | 0.0155 ns | 0.0145 ns | 12.948 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.979 ns | 0.0453 ns | 0.0424 ns | 11.994 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  8.173 ns | 0.0676 ns | 0.0632 ns |  8.128 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.024 ns | 0.1180 ns | 0.1104 ns | 13.053 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.813 ns | 0.0128 ns | 0.0119 ns | 12.815 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 21.263 ns | 0.0229 ns | 0.0191 ns | 21.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.219 ns | 0.0167 ns | 0.0156 ns | 15.220 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 15.794 ns | 0.0817 ns | 0.0764 ns | 15.791 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.052 ns | 0.0588 ns | 0.0521 ns | 19.056 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.093 ns | 0.0305 ns | 0.0285 ns | 20.102 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.887 ns | 0.0177 ns | 0.0165 ns | 11.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.341 ns | 0.0175 ns | 0.0146 ns | 10.341 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.119 ns | 0.0125 ns | 0.0117 ns |  7.118 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.529 ns | 0.0996 ns | 0.0931 ns | 12.495 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 13.109 ns | 0.0169 ns | 0.0150 ns | 13.110 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.941 ns | 0.0242 ns | 0.0214 ns | 17.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.286 ns | 0.0558 ns | 0.0522 ns | 16.299 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.757 ns | 0.0363 ns | 0.0322 ns | 15.770 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.878 ns | 0.1397 ns | 0.1238 ns | 18.846 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.220 ns | 0.0261 ns | 0.0218 ns | 20.219 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.742 ns | 0.0068 ns | 0.0057 ns | 13.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 |  9.966 ns | 0.0239 ns | 0.0212 ns |  9.964 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.615 ns | 0.0206 ns | 0.0192 ns |  6.613 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 12.256 ns | 0.2647 ns | 0.2718 ns | 12.093 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.398 ns | 0.0150 ns | 0.0140 ns | 12.400 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.390 ns | 0.0229 ns | 0.0214 ns | 14.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.514 ns | 0.0134 ns | 0.0112 ns | 13.516 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.227 ns | 0.0150 ns | 0.0133 ns | 11.227 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.453 ns | 0.0636 ns | 0.0595 ns | 13.465 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 14.915 ns | 0.0251 ns | 0.0235 ns | 14.916 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.570 ns | 0.0240 ns | 0.0213 ns | 11.574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 |  9.959 ns | 0.0158 ns | 0.0148 ns |  9.956 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  8.839 ns | 0.1974 ns | 0.3299 ns |  8.952 ns |  0.75 |    0.04 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 11.857 ns | 0.1405 ns | 0.1173 ns | 11.804 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 11.901 ns | 0.0141 ns | 0.0132 ns | 11.904 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.404 ns | 0.0405 ns | 0.0379 ns | 18.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.022 ns | 0.0269 ns | 0.0252 ns | 16.023 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.089 ns | 0.1792 ns | 0.1676 ns | 16.090 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.995 ns | 0.0590 ns | 0.0493 ns | 19.006 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.045 ns | 0.0164 ns | 0.0153 ns | 20.041 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.767 ns | 0.0125 ns | 0.0117 ns | 11.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.221 ns | 0.0385 ns | 0.0360 ns | 10.217 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.022 ns | 0.0103 ns | 0.0092 ns |  7.021 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.440 ns | 0.2312 ns | 0.2162 ns | 13.364 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.133 ns | 0.0178 ns | 0.0167 ns | 12.131 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.400 ns | 0.0312 ns | 0.0277 ns | 18.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.988 ns | 0.0240 ns | 0.0213 ns | 14.984 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.289 ns | 0.0311 ns | 0.0291 ns | 15.286 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.955 ns | 0.2047 ns | 0.1709 ns | 18.887 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 20.224 ns | 0.0205 ns | 0.0192 ns | 20.229 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.633 ns | 0.0130 ns | 0.0121 ns | 11.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 |  9.975 ns | 0.0127 ns | 0.0099 ns |  9.975 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.034 ns | 0.1786 ns | 0.2126 ns |  6.919 ns |  0.61 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.640 ns | 0.0462 ns | 0.0432 ns | 12.640 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.691 ns | 0.0138 ns | 0.0123 ns | 11.696 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.158 ns | 0.0330 ns | 0.0293 ns | 14.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.534 ns | 0.0198 ns | 0.0185 ns | 13.532 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.858 ns | 0.0125 ns | 0.0105 ns | 12.856 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 18.479 ns | 0.0652 ns | 0.0578 ns | 18.487 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 16.920 ns | 0.0222 ns | 0.0197 ns | 16.919 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 14.111 ns | 0.0170 ns | 0.0159 ns | 14.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.349 ns | 0.0106 ns | 0.0094 ns | 10.346 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.670 ns | 0.0096 ns | 0.0085 ns |  7.671 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.844 ns | 0.0602 ns | 0.0503 ns | 11.852 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 11.806 ns | 0.0175 ns | 0.0146 ns | 11.804 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.895 ns | 0.0359 ns | 0.0336 ns | 18.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.754 ns | 0.0257 ns | 0.0241 ns | 16.752 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.211 ns | 0.0773 ns | 0.0723 ns | 17.231 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.594 ns | 0.0778 ns | 0.0727 ns | 18.562 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.869 ns | 0.0779 ns | 0.0729 ns | 19.834 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 13.434 ns | 0.0129 ns | 0.0101 ns | 13.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.157 ns | 0.0082 ns | 0.0077 ns | 10.156 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.850 ns | 0.1626 ns | 0.1997 ns |  6.976 ns |  0.50 |    0.02 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.405 ns | 0.0988 ns | 0.0875 ns | 12.379 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.771 ns | 0.0288 ns | 0.0269 ns | 12.766 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.244 ns | 0.0234 ns | 0.0195 ns | 19.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.705 ns | 0.0348 ns | 0.0291 ns | 16.702 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.811 ns | 0.0214 ns | 0.0190 ns | 17.809 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.511 ns | 0.0496 ns | 0.0414 ns | 18.512 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 19.834 ns | 0.0156 ns | 0.0146 ns | 19.835 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.733 ns | 0.0270 ns | 0.0253 ns | 11.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 |  9.981 ns | 0.0089 ns | 0.0079 ns |  9.981 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.858 ns | 0.0159 ns | 0.0141 ns |  6.854 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.093 ns | 0.0955 ns | 0.0847 ns | 12.066 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 11.813 ns | 0.0287 ns | 0.0269 ns | 11.817 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.944 ns | 0.0227 ns | 0.0212 ns | 13.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.853 ns | 0.0154 ns | 0.0144 ns | 11.852 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.960 ns | 0.0169 ns | 0.0141 ns | 11.962 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.354 ns | 0.0783 ns | 0.0694 ns | 13.342 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 14.929 ns | 0.0295 ns | 0.0276 ns | 14.919 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.010 ns | 0.0156 ns | 0.0139 ns | 12.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 10.888 ns | 0.0585 ns | 0.0547 ns | 10.911 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.649 ns | 0.1978 ns | 0.2899 ns |  8.763 ns |  0.70 |    0.03 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.981 ns | 0.1909 ns | 0.1785 ns | 13.004 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.919 ns | 0.0154 ns | 0.0129 ns | 12.919 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.440 ns | 0.0081 ns | 0.0072 ns | 12.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.039 ns | 0.0134 ns | 0.0119 ns | 11.040 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.221 ns | 0.2098 ns | 0.4560 ns |  9.386 ns |  0.70 |    0.06 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 14.077 ns | 0.1319 ns | 0.1170 ns | 14.075 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 12.672 ns | 0.0201 ns | 0.0178 ns | 12.674 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.504 ns | 0.0725 ns | 0.0678 ns | 12.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.434 ns | 0.0111 ns | 0.0104 ns | 11.439 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.801 ns | 0.0109 ns | 0.0097 ns |  7.800 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.509 ns | 0.1455 ns | 0.1290 ns | 13.462 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.314 ns | 0.0180 ns | 0.0169 ns | 13.311 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.069 ns | 0.0239 ns | 0.0224 ns | 14.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.768 ns | 0.0136 ns | 0.0127 ns | 12.770 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.923 ns | 0.0830 ns | 0.0777 ns | 12.960 ns |  0.92 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 15.861 ns | 0.0725 ns | 0.0643 ns | 15.836 ns |  1.13 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.309 ns | 0.0179 ns | 0.0168 ns | 15.310 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.402 ns | 0.0220 ns | 0.0195 ns | 21.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.407 ns | 0.0190 ns | 0.0178 ns | 20.408 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.878 ns | 0.3000 ns | 0.5174 ns | 14.118 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.030 ns | 0.3472 ns | 0.3248 ns | 23.908 ns |  1.12 |    0.02 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 22.623 ns | 0.0205 ns | 0.0181 ns | 22.624 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.706 ns | 0.0213 ns | 0.0189 ns | 26.709 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 25.942 ns | 0.1441 ns | 0.1348 ns | 26.024 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.341 ns | 0.3505 ns | 0.3279 ns | 20.265 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.401 ns | 0.1840 ns | 0.1536 ns | 27.412 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.572 ns | 0.0543 ns | 0.0481 ns | 27.562 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.243 ns | 0.0202 ns | 0.0179 ns | 22.239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 21.170 ns | 0.0206 ns | 0.0192 ns | 21.165 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.688 ns | 0.0553 ns | 0.0490 ns | 15.688 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.579 ns | 0.1166 ns | 0.1034 ns | 26.547 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 24.543 ns | 0.0201 ns | 0.0188 ns | 24.539 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.177 ns | 0.0346 ns | 0.0307 ns | 26.166 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 24.793 ns | 0.0156 ns | 0.0138 ns | 24.794 ns |  0.95 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.531 ns | 0.4691 ns | 0.8216 ns | 22.962 ns |  0.83 |    0.04 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 28.523 ns | 0.2356 ns | 0.2204 ns | 28.475 ns |  1.09 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.592 ns | 0.0441 ns | 0.0391 ns | 27.587 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.524 ns | 0.0115 ns | 0.0108 ns | 12.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.281 ns | 0.0234 ns | 0.0219 ns | 12.285 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.007 ns | 0.0143 ns | 0.0133 ns |  8.008 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 15.114 ns | 0.0716 ns | 0.0598 ns | 15.099 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.356 ns | 0.0516 ns | 0.0457 ns | 14.335 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.059 ns | 0.0105 ns | 0.0093 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.843 ns | 0.0173 ns | 0.0162 ns | 11.843 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.995 ns | 0.0952 ns | 0.0891 ns | 12.057 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 16.693 ns | 0.2246 ns | 0.1991 ns | 16.581 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.331 ns | 0.0349 ns | 0.0327 ns | 15.340 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 14.140 ns | 0.0493 ns | 0.0437 ns | 14.147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 11.680 ns | 0.0732 ns | 0.0685 ns | 11.647 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  9.536 ns | 0.0158 ns | 0.0132 ns |  9.531 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.766 ns | 0.0957 ns | 0.0895 ns | 15.779 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 17.650 ns | 0.0352 ns | 0.0329 ns | 17.646 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.824 ns | 0.0353 ns | 0.0330 ns | 20.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 16.822 ns | 0.0255 ns | 0.0239 ns | 16.826 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 16.405 ns | 0.1006 ns | 0.0941 ns | 16.439 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 24.641 ns | 0.0352 ns | 0.0312 ns | 24.644 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 23.742 ns | 0.0134 ns | 0.0125 ns | 23.742 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.905 ns | 0.0326 ns | 0.0272 ns | 14.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.675 ns | 0.0136 ns | 0.0113 ns | 12.676 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.289 ns | 0.0073 ns | 0.0065 ns | 10.288 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.952 ns | 0.0301 ns | 0.0251 ns | 16.945 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.831 ns | 0.0225 ns | 0.0200 ns | 17.831 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.383 ns | 0.0210 ns | 0.0186 ns | 21.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.408 ns | 0.0296 ns | 0.0277 ns | 17.409 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.230 ns | 0.0676 ns | 0.0632 ns | 16.239 ns |  0.76 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 24.703 ns | 0.1241 ns | 0.1161 ns | 24.621 ns |  1.15 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 24.352 ns | 0.0247 ns | 0.0219 ns | 24.354 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.448 ns | 0.0139 ns | 0.0116 ns | 12.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.367 ns | 0.0151 ns | 0.0133 ns | 11.361 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.226 ns | 0.0245 ns | 0.0217 ns |  8.225 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.102 ns | 0.0674 ns | 0.0630 ns | 14.113 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.480 ns | 0.0090 ns | 0.0080 ns | 13.482 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.043 ns | 0.0156 ns | 0.0145 ns | 15.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.940 ns | 0.0591 ns | 0.0552 ns | 11.979 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.161 ns | 0.2644 ns | 0.4117 ns | 12.331 ns |  0.80 |    0.04 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.278 ns | 0.0210 ns | 0.0186 ns | 13.278 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 14.884 ns | 0.0118 ns | 0.0110 ns | 14.883 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.612 ns | 0.0193 ns | 0.0171 ns | 11.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.175 ns | 0.0132 ns | 0.0117 ns | 10.178 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.655 ns | 0.0145 ns | 0.0136 ns |  7.656 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.248 ns | 0.0281 ns | 0.0263 ns | 13.246 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.515 ns | 0.0108 ns | 0.0091 ns | 12.512 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.284 ns | 0.0340 ns | 0.0318 ns | 18.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.227 ns | 0.0196 ns | 0.0164 ns | 15.230 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.035 ns | 0.0375 ns | 0.0351 ns | 15.025 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.651 ns | 0.0212 ns | 0.0198 ns | 21.654 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.742 ns | 0.0338 ns | 0.0300 ns | 20.738 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.886 ns | 0.0713 ns | 0.0667 ns | 11.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.284 ns | 0.0149 ns | 0.0139 ns | 10.284 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.904 ns | 0.0311 ns | 0.0291 ns |  6.909 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.045 ns | 0.0139 ns | 0.0108 ns | 14.047 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.968 ns | 0.0101 ns | 0.0090 ns | 13.967 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.124 ns | 0.0350 ns | 0.0328 ns | 18.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.269 ns | 0.0194 ns | 0.0181 ns | 16.270 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.269 ns | 0.3585 ns | 0.3521 ns | 17.255 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.478 ns | 0.0332 ns | 0.0294 ns | 19.483 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.970 ns | 0.0189 ns | 0.0177 ns | 20.969 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.630 ns | 0.0060 ns | 0.0053 ns | 11.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.060 ns | 0.0101 ns | 0.0089 ns | 10.059 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.625 ns | 0.0167 ns | 0.0148 ns |  6.623 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.864 ns | 0.0134 ns | 0.0118 ns | 11.866 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 11.690 ns | 0.0176 ns | 0.0156 ns | 11.687 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.932 ns | 0.0261 ns | 0.0203 ns | 14.927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.570 ns | 0.0206 ns | 0.0183 ns | 12.562 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.467 ns | 0.0556 ns | 0.0521 ns | 14.480 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 14.517 ns | 0.0502 ns | 0.0469 ns | 14.501 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.900 ns | 0.0213 ns | 0.0189 ns | 14.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.080 ns | 0.0191 ns | 0.0169 ns | 12.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.570 ns | 0.0580 ns | 0.0543 ns | 10.597 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.886 ns | 0.0154 ns | 0.0144 ns |  7.884 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.061 ns | 0.0196 ns | 0.0174 ns | 13.060 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.498 ns | 0.0285 ns | 0.0253 ns | 12.492 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.349 ns | 0.0529 ns | 0.0495 ns | 18.338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.324 ns | 0.0264 ns | 0.0247 ns | 16.324 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.705 ns | 0.0574 ns | 0.0537 ns | 15.712 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 22.772 ns | 0.0210 ns | 0.0186 ns | 22.775 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.784 ns | 0.0238 ns | 0.0211 ns | 20.780 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.225 ns | 0.0205 ns | 0.0192 ns | 12.225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.310 ns | 0.0196 ns | 0.0174 ns | 10.311 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.083 ns | 0.0106 ns | 0.0094 ns |  7.082 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.152 ns | 0.0134 ns | 0.0119 ns | 13.153 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.175 ns | 0.0590 ns | 0.0552 ns | 13.196 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.538 ns | 0.0425 ns | 0.0397 ns | 18.528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.024 ns | 0.0132 ns | 0.0123 ns | 15.027 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.164 ns | 0.0677 ns | 0.0601 ns | 15.180 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.236 ns | 0.0365 ns | 0.0341 ns | 19.239 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 21.140 ns | 0.0241 ns | 0.0214 ns | 21.141 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.639 ns | 0.0212 ns | 0.0198 ns | 11.636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.046 ns | 0.0266 ns | 0.0236 ns | 10.041 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.136 ns | 0.0458 ns | 0.0383 ns |  7.151 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.841 ns | 0.0103 ns | 0.0097 ns | 11.842 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.684 ns | 0.0205 ns | 0.0192 ns | 11.681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.155 ns | 0.0478 ns | 0.0424 ns | 14.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.864 ns | 0.0101 ns | 0.0089 ns | 11.865 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.951 ns | 0.2133 ns | 0.1995 ns | 12.849 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.310 ns | 0.0286 ns | 0.0254 ns | 13.313 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 14.908 ns | 0.0145 ns | 0.0135 ns | 14.907 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.515 ns | 0.0178 ns | 0.0166 ns | 11.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.161 ns | 0.0163 ns | 0.0145 ns | 10.161 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.906 ns | 0.0423 ns | 0.0396 ns |  7.904 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.231 ns | 0.0106 ns | 0.0094 ns | 12.231 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.479 ns | 0.0186 ns | 0.0165 ns | 12.478 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 18.167 ns | 0.0298 ns | 0.0279 ns | 18.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 15.334 ns | 0.1039 ns | 0.0972 ns | 15.371 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.985 ns | 0.2505 ns | 0.2343 ns | 16.133 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 19.242 ns | 0.0939 ns | 0.0878 ns | 19.204 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.548 ns | 0.0148 ns | 0.0138 ns | 20.547 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.470 ns | 0.0117 ns | 0.0098 ns | 13.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.593 ns | 0.0196 ns | 0.0183 ns | 11.588 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  9.198 ns | 0.2078 ns | 0.3414 ns |  9.330 ns |  0.67 |    0.04 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.463 ns | 0.0092 ns | 0.0072 ns | 14.464 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.156 ns | 0.0247 ns | 0.0219 ns | 15.148 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.350 ns | 0.0453 ns | 0.0378 ns | 18.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.197 ns | 0.0150 ns | 0.0133 ns | 15.200 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.223 ns | 0.0412 ns | 0.0386 ns | 15.232 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 19.554 ns | 0.0302 ns | 0.0282 ns | 19.553 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.958 ns | 0.0352 ns | 0.0312 ns | 20.947 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.077 ns | 0.0723 ns | 0.0676 ns | 13.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.360 ns | 0.0183 ns | 0.0171 ns | 11.356 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.153 ns | 0.0213 ns | 0.0189 ns |  8.157 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.440 ns | 0.0163 ns | 0.0136 ns | 13.439 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.417 ns | 0.0154 ns | 0.0144 ns | 13.414 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.519 ns | 0.0203 ns | 0.0180 ns | 15.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.845 ns | 0.0120 ns | 0.0100 ns | 11.849 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.157 ns | 0.0211 ns | 0.0197 ns | 11.153 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.791 ns | 0.0218 ns | 0.0170 ns | 15.793 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.049 ns | 0.0491 ns | 0.0459 ns | 15.060 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.586 ns | 0.0290 ns | 0.0242 ns | 11.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.664 ns | 0.0587 ns | 0.0549 ns | 10.704 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.858 ns | 0.0140 ns | 0.0131 ns |  7.854 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.251 ns | 0.0163 ns | 0.0152 ns | 12.250 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.474 ns | 0.0737 ns | 0.0654 ns | 13.477 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.107 ns | 0.0218 ns | 0.0204 ns | 18.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 14.995 ns | 0.0140 ns | 0.0124 ns | 14.995 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.862 ns | 0.0455 ns | 0.0426 ns | 16.876 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 19.344 ns | 0.0319 ns | 0.0298 ns | 19.331 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 21.186 ns | 0.0412 ns | 0.0385 ns | 21.176 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.419 ns | 0.0238 ns | 0.0199 ns | 12.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.292 ns | 0.0187 ns | 0.0166 ns | 10.289 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.824 ns | 0.0077 ns | 0.0068 ns |  6.823 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.442 ns | 0.0137 ns | 0.0114 ns | 13.441 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.044 ns | 0.0120 ns | 0.0112 ns | 13.044 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.105 ns | 0.0257 ns | 0.0240 ns | 18.108 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.273 ns | 0.0206 ns | 0.0182 ns | 16.274 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.963 ns | 0.0758 ns | 0.0709 ns | 16.978 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 19.252 ns | 0.1052 ns | 0.0932 ns | 19.203 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 20.520 ns | 0.0258 ns | 0.0229 ns | 20.523 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 14.505 ns | 0.0161 ns | 0.0134 ns | 14.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.661 ns | 0.0127 ns | 0.0106 ns | 10.663 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.020 ns | 0.1669 ns | 0.2789 ns |  6.852 ns |  0.50 |    0.02 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.900 ns | 0.0590 ns | 0.0552 ns | 11.928 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.825 ns | 0.0497 ns | 0.0441 ns | 11.817 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.386 ns | 0.0127 ns | 0.0106 ns | 14.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.174 ns | 0.0125 ns | 0.0111 ns | 13.170 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.872 ns | 0.0616 ns | 0.0546 ns | 12.849 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.228 ns | 0.0492 ns | 0.0411 ns | 13.208 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.889 ns | 0.0199 ns | 0.0187 ns | 14.886 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.083 ns | 0.0200 ns | 0.0177 ns | 15.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.047 ns | 0.0130 ns | 0.0122 ns | 12.045 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.183 ns | 0.1577 ns | 0.1475 ns | 10.270 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.127 ns | 0.0291 ns | 0.0243 ns | 16.123 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 16.269 ns | 0.0181 ns | 0.0160 ns | 16.267 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.695 ns | 0.0496 ns | 0.0439 ns | 21.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 16.857 ns | 0.0199 ns | 0.0186 ns | 16.851 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.067 ns | 0.0302 ns | 0.0283 ns | 18.069 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 22.781 ns | 0.0931 ns | 0.0825 ns | 22.809 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 24.016 ns | 0.0427 ns | 0.0399 ns | 24.010 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.934 ns | 0.0203 ns | 0.0159 ns | 13.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.517 ns | 0.0248 ns | 0.0220 ns | 11.517 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.629 ns | 0.0519 ns | 0.0486 ns |  8.608 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.837 ns | 0.0723 ns | 0.0676 ns | 14.841 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.680 ns | 0.0131 ns | 0.0122 ns | 14.681 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.078 ns | 0.0211 ns | 0.0176 ns | 21.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.951 ns | 0.0589 ns | 0.0551 ns | 16.975 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.134 ns | 0.0736 ns | 0.0688 ns | 16.116 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 24.999 ns | 0.0880 ns | 0.0823 ns | 24.959 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 23.992 ns | 0.0213 ns | 0.0189 ns | 23.988 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.328 ns | 0.0274 ns | 0.0256 ns | 12.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.019 ns | 0.0091 ns | 0.0081 ns | 10.018 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.231 ns | 0.1663 ns | 0.1980 ns |  7.336 ns |  0.58 |    0.02 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.707 ns | 0.0796 ns | 0.0745 ns | 12.664 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 11.776 ns | 0.0161 ns | 0.0143 ns | 11.776 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.090 ns | 0.0163 ns | 0.0152 ns | 14.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.558 ns | 0.0351 ns | 0.0328 ns | 13.543 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.304 ns | 0.0574 ns | 0.0537 ns | 11.318 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.498 ns | 0.0148 ns | 0.0138 ns | 14.499 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.928 ns | 0.0187 ns | 0.0175 ns | 14.926 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.942 ns | 0.4695 ns | 0.4391 ns | 59.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.952 ns | 0.1171 ns | 0.1095 ns | 50.950 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.295 ns | 0.4250 ns | 0.3976 ns | 20.073 ns |  0.34 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.420 ns | 0.3557 ns | 0.3327 ns | 59.435 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 62.677 ns | 0.2471 ns | 0.2311 ns | 62.758 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 62.202 ns | 0.1144 ns | 0.1015 ns | 62.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.703 ns | 0.0818 ns | 0.0725 ns | 58.713 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.059 ns | 0.0638 ns | 0.0597 ns | 25.045 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.775 ns | 0.1508 ns | 0.1410 ns | 63.782 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 66.618 ns | 0.3041 ns | 0.2844 ns | 66.591 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.345 ns | 0.0111 ns | 0.0103 ns | 12.345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 11.500 ns | 0.0375 ns | 0.0333 ns | 11.512 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.902 ns | 0.1247 ns | 0.1167 ns | 11.965 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.721 ns | 0.0167 ns | 0.0156 ns | 12.722 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.150 ns | 0.0727 ns | 0.0680 ns | 15.174 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.977 ns | 0.0210 ns | 0.0175 ns | 14.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 11.841 ns | 0.0080 ns | 0.0071 ns | 11.841 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.759 ns | 0.1418 ns | 0.1326 ns | 13.859 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.326 ns | 0.0178 ns | 0.0166 ns | 13.325 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 15.072 ns | 0.0246 ns | 0.0230 ns | 15.066 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.564 ns | 0.0118 ns | 0.0104 ns | 12.567 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.417 ns | 0.0454 ns | 0.0425 ns | 11.392 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.557 ns | 0.0328 ns | 0.0291 ns | 11.568 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.808 ns | 0.0284 ns | 0.0266 ns | 12.806 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.290 ns | 0.0267 ns | 0.0237 ns | 15.286 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.503 ns | 0.0196 ns | 0.0183 ns | 11.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 |  9.928 ns | 0.0187 ns | 0.0165 ns |  9.929 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.688 ns | 0.0144 ns | 0.0121 ns |  7.685 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 11.629 ns | 0.0139 ns | 0.0123 ns | 11.630 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 11.802 ns | 0.0110 ns | 0.0092 ns | 11.804 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 17.909 ns | 0.0172 ns | 0.0144 ns | 17.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.142 ns | 0.0175 ns | 0.0155 ns | 15.140 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.240 ns | 0.0580 ns | 0.0543 ns | 15.249 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.130 ns | 0.0140 ns | 0.0117 ns | 20.129 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 20.066 ns | 0.0217 ns | 0.0192 ns | 20.064 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.801 ns | 0.0172 ns | 0.0153 ns | 11.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.154 ns | 0.0115 ns | 0.0096 ns | 10.152 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.990 ns | 0.0202 ns | 0.0189 ns |  6.996 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.895 ns | 0.0279 ns | 0.0261 ns | 12.893 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.802 ns | 0.0341 ns | 0.0319 ns | 12.816 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.113 ns | 0.0293 ns | 0.0229 ns | 18.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.102 ns | 0.0384 ns | 0.0359 ns | 16.103 ns |  0.89 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.270 ns | 0.0377 ns | 0.0334 ns | 15.270 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.983 ns | 0.0292 ns | 0.0273 ns | 18.982 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.920 ns | 0.0499 ns | 0.0416 ns | 20.910 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.767 ns | 0.0184 ns | 0.0154 ns | 11.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.035 ns | 0.0111 ns | 0.0104 ns | 10.033 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.630 ns | 0.0094 ns | 0.0088 ns |  6.630 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.929 ns | 0.0628 ns | 0.0587 ns | 11.945 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.691 ns | 0.0234 ns | 0.0207 ns | 11.696 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.203 ns | 0.0149 ns | 0.0132 ns | 14.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.798 ns | 0.0153 ns | 0.0136 ns | 11.801 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.544 ns | 0.1488 ns | 0.1392 ns | 12.491 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.921 ns | 0.0080 ns | 0.0066 ns | 13.921 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 14.904 ns | 0.0194 ns | 0.0172 ns | 14.900 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.982 ns | 0.0106 ns | 0.0094 ns | 11.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 |  9.950 ns | 0.0560 ns | 0.0524 ns |  9.927 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  8.073 ns | 0.0161 ns | 0.0150 ns |  8.072 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 11.708 ns | 0.0166 ns | 0.0155 ns | 11.709 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 11.806 ns | 0.0202 ns | 0.0169 ns | 11.806 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.020 ns | 0.0944 ns | 0.0883 ns | 18.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.431 ns | 0.0219 ns | 0.0205 ns | 15.434 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.084 ns | 0.1110 ns | 0.1038 ns | 15.125 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.755 ns | 0.0225 ns | 0.0211 ns | 18.754 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.753 ns | 0.0186 ns | 0.0174 ns | 20.760 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.124 ns | 0.0111 ns | 0.0098 ns | 12.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.203 ns | 0.0151 ns | 0.0134 ns | 10.203 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.088 ns | 0.0146 ns | 0.0136 ns |  7.088 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.010 ns | 0.0733 ns | 0.0650 ns | 13.036 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.091 ns | 0.0132 ns | 0.0117 ns | 12.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.384 ns | 0.0330 ns | 0.0293 ns | 18.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.000 ns | 0.0186 ns | 0.0165 ns | 14.996 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.924 ns | 0.0309 ns | 0.0289 ns | 14.940 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.923 ns | 0.0887 ns | 0.0830 ns | 18.954 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.094 ns | 0.0454 ns | 0.0425 ns | 20.070 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.252 ns | 0.0165 ns | 0.0154 ns | 12.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 |  9.980 ns | 0.0084 ns | 0.0071 ns |  9.980 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.010 ns | 0.0956 ns | 0.0894 ns |  7.080 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.508 ns | 0.0099 ns | 0.0093 ns | 12.507 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.683 ns | 0.0181 ns | 0.0170 ns | 11.683 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.759 ns | 0.0136 ns | 0.0113 ns | 14.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.809 ns | 0.0112 ns | 0.0105 ns | 13.805 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.928 ns | 0.1070 ns | 0.1000 ns | 12.878 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.231 ns | 0.0196 ns | 0.0173 ns | 13.233 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.058 ns | 0.0172 ns | 0.0161 ns | 15.059 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.488 ns | 0.0157 ns | 0.0140 ns | 11.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.007 ns | 0.0202 ns | 0.0168 ns | 10.003 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.569 ns | 0.2511 ns | 0.2791 ns |  7.416 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 11.664 ns | 0.0126 ns | 0.0105 ns | 11.666 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.747 ns | 0.1014 ns | 0.0949 ns | 10.712 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 14.609 ns | 0.0193 ns | 0.0180 ns | 14.601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 12.936 ns | 0.0420 ns | 0.0392 ns | 12.956 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 12.608 ns | 0.2703 ns | 0.2776 ns | 12.436 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 14.422 ns | 0.0562 ns | 0.0525 ns | 14.414 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 15.724 ns | 0.0301 ns | 0.0281 ns | 15.728 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.579 ns | 0.0233 ns | 0.0218 ns | 12.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.309 ns | 0.0131 ns | 0.0122 ns | 11.309 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  7.947 ns | 0.0093 ns | 0.0078 ns |  7.947 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.063 ns | 0.0664 ns | 0.0589 ns | 13.083 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.041 ns | 0.0149 ns | 0.0124 ns | 13.043 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.593 ns | 0.0128 ns | 0.0107 ns | 14.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 12.750 ns | 0.0167 ns | 0.0148 ns | 12.753 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.799 ns | 0.2772 ns | 0.2457 ns | 11.724 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 14.420 ns | 0.0513 ns | 0.0480 ns | 14.401 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 16.704 ns | 0.0135 ns | 0.0120 ns | 16.707 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.522 ns | 0.0828 ns | 0.0774 ns | 12.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.167 ns | 0.0139 ns | 0.0123 ns | 11.168 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.895 ns | 0.0872 ns | 0.0816 ns |  7.858 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.875 ns | 0.0154 ns | 0.0144 ns | 12.883 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.732 ns | 0.0196 ns | 0.0173 ns | 12.731 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.071 ns | 0.0156 ns | 0.0138 ns | 14.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.844 ns | 0.0089 ns | 0.0079 ns | 11.845 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.087 ns | 0.1241 ns | 0.1036 ns | 12.083 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.835 ns | 0.0159 ns | 0.0149 ns | 13.834 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 16.948 ns | 0.0310 ns | 0.0275 ns | 16.945 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.051 ns | 0.0103 ns | 0.0086 ns | 14.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.589 ns | 0.0665 ns | 0.0622 ns | 13.602 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.477 ns | 0.2828 ns | 0.2904 ns | 14.388 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.537 ns | 0.0244 ns | 0.0217 ns | 13.529 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 14.889 ns | 0.0249 ns | 0.0221 ns | 14.890 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.745 ns | 0.0126 ns | 0.0112 ns | 10.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.022 ns | 0.0168 ns | 0.0157 ns |  9.019 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.739 ns | 0.3253 ns | 0.3995 ns | 11.551 ns |  1.10 |    0.04 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.021 ns | 0.0174 ns | 0.0146 ns | 11.022 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.641 ns | 0.0107 ns | 0.0095 ns | 12.639 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.954 ns | 0.0170 ns | 0.0159 ns | 14.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.656 ns | 0.0110 ns | 0.0103 ns | 14.655 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.560 ns | 0.1335 ns | 0.1183 ns | 14.524 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 14.971 ns | 0.0193 ns | 0.0181 ns | 14.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.804 ns | 0.0234 ns | 0.0219 ns | 15.802 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.241 ns | 0.0832 ns | 0.0778 ns | 16.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.216 ns | 0.0183 ns | 0.0152 ns | 13.217 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.610 ns | 0.2905 ns | 0.2575 ns | 14.556 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.749 ns | 0.0422 ns | 0.0395 ns | 16.754 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.969 ns | 0.0303 ns | 0.0284 ns | 16.968 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.154 ns | 0.0225 ns | 0.0210 ns | 19.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.766 ns | 0.0206 ns | 0.0182 ns | 15.763 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.423 ns | 0.2322 ns | 0.2058 ns | 16.414 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.609 ns | 0.0647 ns | 0.0605 ns | 16.612 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 18.600 ns | 0.0459 ns | 0.0430 ns | 18.593 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.943 ns | 0.0120 ns | 0.0100 ns | 13.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.359 ns | 0.0134 ns | 0.0119 ns | 12.356 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.201 ns | 0.0767 ns | 0.0717 ns | 11.178 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.029 ns | 0.0108 ns | 0.0096 ns | 13.028 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.182 ns | 0.0270 ns | 0.0253 ns | 13.184 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.237 ns | 0.0156 ns | 0.0146 ns | 14.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.543 ns | 0.0525 ns | 0.0491 ns | 13.532 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.737 ns | 0.2791 ns | 0.3629 ns | 12.863 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.812 ns | 0.0233 ns | 0.0207 ns | 15.811 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 15.104 ns | 0.0473 ns | 0.0395 ns | 15.121 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.134 ns | 0.0099 ns | 0.0093 ns | 12.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.232 ns | 0.0163 ns | 0.0153 ns | 11.229 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.103 ns | 0.2426 ns | 0.2888 ns | 10.983 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.303 ns | 0.0205 ns | 0.0191 ns | 12.302 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.524 ns | 0.0138 ns | 0.0129 ns | 12.525 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.017 ns | 0.0247 ns | 0.0219 ns | 15.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 13.283 ns | 0.0299 ns | 0.0250 ns | 13.273 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 14.835 ns | 0.2442 ns | 0.2165 ns | 14.906 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.193 ns | 0.0260 ns | 0.0230 ns | 17.186 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 16.589 ns | 0.0194 ns | 0.0172 ns | 16.594 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.784 ns | 0.0083 ns | 0.0073 ns | 11.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.113 ns | 0.0170 ns | 0.0159 ns | 11.110 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.450 ns | 0.1282 ns | 0.1136 ns | 11.428 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.491 ns | 0.0150 ns | 0.0140 ns | 12.492 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.751 ns | 0.0180 ns | 0.0168 ns | 12.752 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.169 ns | 0.0245 ns | 0.0217 ns | 14.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.095 ns | 0.0151 ns | 0.0141 ns | 12.097 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.299 ns | 0.2933 ns | 0.5508 ns | 13.426 ns |  0.92 |    0.07 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 16.057 ns | 0.0166 ns | 0.0155 ns | 16.054 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.879 ns | 0.0228 ns | 0.0202 ns | 14.875 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.056 ns | 0.0432 ns | 0.0383 ns | 19.062 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.179 ns | 0.0437 ns | 0.0409 ns | 16.189 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 12.653 ns | 0.0855 ns | 0.0714 ns | 12.673 ns |  0.66 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.176 ns | 0.0298 ns | 0.0264 ns | 19.178 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.744 ns | 0.0595 ns | 0.0527 ns | 18.735 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.975 ns | 0.0218 ns | 0.0171 ns | 17.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 14.495 ns | 0.0180 ns | 0.0150 ns | 14.495 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.251 ns | 0.1833 ns | 0.1715 ns | 17.173 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.446 ns | 0.0283 ns | 0.0265 ns | 17.457 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 19.360 ns | 0.0329 ns | 0.0308 ns | 19.361 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.485 ns | 0.1179 ns | 0.1103 ns | 19.497 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.829 ns | 0.0625 ns | 0.0554 ns | 15.829 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.234 ns | 0.2830 ns | 0.2647 ns | 13.203 ns |  0.68 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 19.320 ns | 0.0409 ns | 0.0383 ns | 19.320 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 18.037 ns | 0.0170 ns | 0.0159 ns | 18.041 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.908 ns | 0.0244 ns | 0.0229 ns | 16.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.615 ns | 0.0407 ns | 0.0380 ns | 14.626 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.811 ns | 0.3365 ns | 0.2983 ns | 17.809 ns |  1.05 |    0.02 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.430 ns | 0.0333 ns | 0.0311 ns | 17.421 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 19.356 ns | 0.0398 ns | 0.0372 ns | 19.356 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.114 ns | 0.0148 ns | 0.0116 ns | 13.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.590 ns | 0.0098 ns | 0.0087 ns | 11.588 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.025 ns | 0.1296 ns | 0.1212 ns |  6.981 ns |  0.54 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 12.654 ns | 0.0559 ns | 0.0522 ns | 12.681 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.473 ns | 0.0154 ns | 0.0144 ns | 10.474 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.164 ns | 0.0126 ns | 0.0118 ns | 14.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.864 ns | 0.0123 ns | 0.0115 ns | 11.867 ns |  0.84 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.506 ns | 0.0869 ns | 0.0813 ns | 13.494 ns |  0.95 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.241 ns | 0.0233 ns | 0.0218 ns | 13.250 ns |  0.93 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 15.819 ns | 0.0213 ns | 0.0199 ns | 15.820 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.930 ns | 0.0129 ns | 0.0115 ns | 12.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.005 ns | 0.0105 ns | 0.0098 ns | 10.007 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.855 ns | 0.1428 ns | 0.1336 ns |  6.912 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 11.840 ns | 0.0815 ns | 0.0762 ns | 11.803 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 10.291 ns | 0.0129 ns | 0.0121 ns | 10.289 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 17.498 ns | 0.0851 ns | 0.0796 ns | 17.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 13.263 ns | 0.0167 ns | 0.0131 ns | 13.267 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.450 ns | 0.0922 ns | 0.0818 ns | 15.446 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 15.575 ns | 0.0282 ns | 0.0236 ns | 15.564 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 16.751 ns | 0.0808 ns | 0.0716 ns | 16.766 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 12.948 ns | 0.0130 ns | 0.0109 ns | 12.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.444 ns | 0.0139 ns | 0.0109 ns | 11.445 ns |  0.88 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.587 ns | 0.0177 ns | 0.0148 ns |  6.583 ns |  0.51 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.801 ns | 0.0092 ns | 0.0086 ns | 11.801 ns |  0.91 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 10.293 ns | 0.0124 ns | 0.0110 ns | 10.292 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.955 ns | 0.0407 ns | 0.0361 ns | 14.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.270 ns | 0.0182 ns | 0.0170 ns | 13.263 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.482 ns | 0.2510 ns | 0.2348 ns | 13.541 ns |  0.90 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 15.084 ns | 0.0425 ns | 0.0377 ns | 15.071 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 16.698 ns | 0.0244 ns | 0.0204 ns | 16.701 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 12.932 ns | 0.0517 ns | 0.0484 ns | 12.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.371 ns | 0.0127 ns | 0.0113 ns | 11.370 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.640 ns | 0.0497 ns | 0.0465 ns |  6.636 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.507 ns | 0.0104 ns | 0.0087 ns | 12.507 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 10.364 ns | 0.0229 ns | 0.0203 ns | 10.370 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.049 ns | 0.0132 ns | 0.0117 ns | 14.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.500 ns | 0.0101 ns | 0.0090 ns | 13.500 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.514 ns | 0.0748 ns | 0.0625 ns | 16.536 ns |  1.18 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.405 ns | 0.0183 ns | 0.0171 ns | 13.403 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.872 ns | 0.0162 ns | 0.0151 ns | 14.869 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.011 ns | 0.0179 ns | 0.0150 ns | 13.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.255 ns | 0.0119 ns | 0.0112 ns | 10.255 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.568 ns | 0.0601 ns | 0.0533 ns |  6.552 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.055 ns | 0.0618 ns | 0.0548 ns | 13.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.703 ns | 0.0155 ns | 0.0138 ns | 10.699 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 45.336 ns | 0.0601 ns | 0.0533 ns | 45.319 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 41.565 ns | 0.0617 ns | 0.0547 ns | 41.572 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 39.107 ns | 0.1793 ns | 0.1678 ns | 39.119 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.492 ns | 0.0650 ns | 0.0576 ns | 42.474 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 45.487 ns | 0.1444 ns | 0.1351 ns | 45.430 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.275 ns | 0.0072 ns | 0.0063 ns | 13.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.236 ns | 0.0157 ns | 0.0139 ns | 11.235 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.159 ns | 0.0595 ns | 0.0556 ns |  7.158 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.706 ns | 0.0260 ns | 0.0243 ns | 13.699 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.181 ns | 0.0116 ns | 0.0097 ns | 13.181 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.438 ns | 0.0603 ns | 0.0564 ns | 44.425 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.428 ns | 0.0922 ns | 0.0863 ns | 40.399 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 33.173 ns | 0.2204 ns | 0.2061 ns | 33.113 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.473 ns | 0.0628 ns | 0.0587 ns | 42.462 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.788 ns | 0.0990 ns | 0.0926 ns | 44.784 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 12.957 ns | 0.0182 ns | 0.0161 ns | 12.956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.528 ns | 0.0107 ns | 0.0095 ns | 10.528 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.867 ns | 0.0445 ns | 0.0416 ns |  6.866 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 12.764 ns | 0.0202 ns | 0.0179 ns | 12.762 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.386 ns | 0.0132 ns | 0.0117 ns | 10.384 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.047 ns | 0.0131 ns | 0.0116 ns | 14.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.856 ns | 0.0183 ns | 0.0171 ns | 11.855 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.252 ns | 0.0951 ns | 0.0890 ns | 11.225 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.324 ns | 0.0188 ns | 0.0157 ns | 13.326 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 15.042 ns | 0.0213 ns | 0.0200 ns | 15.042 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.039 ns | 0.0114 ns | 0.0095 ns | 12.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.203 ns | 0.0254 ns | 0.0238 ns | 11.209 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.067 ns | 0.4182 ns | 0.6130 ns | 11.750 ns |  1.04 |    0.06 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.376 ns | 0.0331 ns | 0.0310 ns | 12.383 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.582 ns | 0.0138 ns | 0.0130 ns | 12.583 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.557 ns | 0.0162 ns | 0.0143 ns | 15.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 13.583 ns | 0.0123 ns | 0.0103 ns | 13.581 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.831 ns | 0.3200 ns | 0.5604 ns | 15.076 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.282 ns | 0.0157 ns | 0.0146 ns | 15.281 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.074 ns | 0.0338 ns | 0.0299 ns | 17.073 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 11.906 ns | 0.0106 ns | 0.0099 ns | 11.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.121 ns | 0.0083 ns | 0.0073 ns | 11.120 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.380 ns | 0.0571 ns | 0.0534 ns | 11.403 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.326 ns | 0.0181 ns | 0.0160 ns | 12.327 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.020 ns | 0.0299 ns | 0.0279 ns | 14.011 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.155 ns | 0.0898 ns | 0.0840 ns | 14.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.168 ns | 0.0086 ns | 0.0076 ns | 12.168 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.864 ns | 0.1767 ns | 0.1380 ns | 13.930 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.797 ns | 0.0146 ns | 0.0137 ns | 15.799 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.907 ns | 0.0170 ns | 0.0151 ns | 14.906 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 39.241 ns | 0.0481 ns | 0.0450 ns | 39.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.377 ns | 0.1271 ns | 0.1189 ns | 38.370 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 40.397 ns | 0.8271 ns | 1.5332 ns | 41.162 ns |  0.99 |    0.04 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 39.052 ns | 0.0469 ns | 0.0392 ns | 39.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.721 ns | 0.0590 ns | 0.0552 ns | 40.699 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.214 ns | 0.0187 ns | 0.0165 ns | 16.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 13.604 ns | 0.0430 ns | 0.0402 ns | 13.617 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.804 ns | 0.2908 ns | 0.2720 ns | 13.915 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.496 ns | 0.0229 ns | 0.0214 ns | 15.495 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 16.972 ns | 0.0330 ns | 0.0308 ns | 16.976 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.023 ns | 0.0589 ns | 0.0551 ns | 39.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.446 ns | 0.0541 ns | 0.0506 ns | 36.456 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.336 ns | 0.6744 ns | 0.6308 ns | 35.533 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 46.998 ns | 0.0663 ns | 0.0620 ns | 46.991 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.309 ns | 0.0365 ns | 0.0324 ns | 38.320 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.314 ns | 0.0172 ns | 0.0161 ns | 16.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.809 ns | 0.0231 ns | 0.0216 ns | 16.811 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.206 ns | 0.0598 ns | 0.0559 ns | 16.197 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 17.461 ns | 0.0418 ns | 0.0370 ns | 17.456 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.594 ns | 0.0193 ns | 0.0161 ns | 17.586 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 38.437 ns | 0.0662 ns | 0.0586 ns | 38.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 36.897 ns | 0.0532 ns | 0.0444 ns | 36.900 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.246 ns | 0.2816 ns | 0.2496 ns | 38.281 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.360 ns | 0.0642 ns | 0.0600 ns | 39.344 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 39.677 ns | 0.0360 ns | 0.0319 ns | 39.675 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.940 ns | 0.0209 ns | 0.0185 ns | 14.935 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 11.863 ns | 0.0181 ns | 0.0160 ns | 11.859 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.197 ns | 0.1105 ns | 0.1033 ns | 12.163 ns |  0.82 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.283 ns | 0.0464 ns | 0.0434 ns | 13.277 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.920 ns | 0.0364 ns | 0.0341 ns | 15.923 ns |  1.07 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ULong.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULong.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_ULong.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
