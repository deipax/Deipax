
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
                                             From_Bool | .NET Core 2.0 | 12.953 ns | 0.0101 ns | 0.0095 ns | 12.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.588 ns | 0.0319 ns | 0.0299 ns | 10.591 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  6.977 ns | 0.0125 ns | 0.0111 ns |  6.978 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.373 ns | 0.0142 ns | 0.0132 ns | 10.377 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.326 ns | 0.0172 ns | 0.0161 ns | 10.322 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.044 ns | 0.0161 ns | 0.0126 ns | 18.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.243 ns | 0.0188 ns | 0.0176 ns | 16.239 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.386 ns | 0.0390 ns | 0.0365 ns | 16.381 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 17.700 ns | 0.0262 ns | 0.0245 ns | 17.696 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.075 ns | 0.0432 ns | 0.0361 ns | 18.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.939 ns | 0.0163 ns | 0.0153 ns | 11.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.461 ns | 0.0162 ns | 0.0151 ns | 10.466 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  6.967 ns | 0.0089 ns | 0.0083 ns |  6.968 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.591 ns | 0.0081 ns | 0.0076 ns | 10.591 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.344 ns | 0.0170 ns | 0.0151 ns | 12.344 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.250 ns | 0.0235 ns | 0.0220 ns | 18.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.196 ns | 0.0402 ns | 0.0357 ns | 16.199 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.712 ns | 0.0324 ns | 0.0303 ns | 15.722 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 19.492 ns | 0.0784 ns | 0.0734 ns | 19.512 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.297 ns | 0.0408 ns | 0.0381 ns | 18.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.531 ns | 0.0166 ns | 0.0155 ns | 11.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.198 ns | 0.0083 ns | 0.0078 ns | 10.199 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.740 ns | 0.0242 ns | 0.0226 ns |  6.726 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.213 ns | 0.0060 ns | 0.0056 ns | 10.211 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.298 ns | 0.0114 ns | 0.0101 ns | 10.299 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.851 ns | 0.0247 ns | 0.0231 ns | 14.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.386 ns | 0.0146 ns | 0.0136 ns | 13.386 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.211 ns | 0.0167 ns | 0.0130 ns | 11.210 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.196 ns | 0.0139 ns | 0.0123 ns | 13.194 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.446 ns | 0.0285 ns | 0.0253 ns | 13.445 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.591 ns | 0.0151 ns | 0.0126 ns | 11.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.192 ns | 0.0197 ns | 0.0164 ns | 10.193 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.984 ns | 0.0110 ns | 0.0102 ns |  6.983 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.277 ns | 0.0489 ns | 0.0457 ns | 10.284 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.209 ns | 0.0180 ns | 0.0159 ns | 10.209 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.190 ns | 0.0402 ns | 0.0376 ns | 18.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.573 ns | 0.0165 ns | 0.0154 ns | 15.574 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 15.079 ns | 0.0445 ns | 0.0416 ns | 15.088 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 18.236 ns | 0.0582 ns | 0.0544 ns | 18.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.349 ns | 0.0424 ns | 0.0397 ns | 18.342 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.698 ns | 0.0056 ns | 0.0049 ns | 11.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.335 ns | 0.0155 ns | 0.0145 ns | 10.337 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.738 ns | 0.0108 ns | 0.0101 ns |  6.740 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 10.529 ns | 0.0055 ns | 0.0049 ns | 10.527 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.518 ns | 0.0075 ns | 0.0071 ns | 10.519 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.266 ns | 0.0382 ns | 0.0319 ns | 18.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.033 ns | 0.0679 ns | 0.0635 ns | 16.022 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.001 ns | 0.0154 ns | 0.0137 ns | 15.002 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 19.316 ns | 0.0362 ns | 0.0339 ns | 19.323 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.064 ns | 0.0280 ns | 0.0262 ns | 18.068 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.501 ns | 0.0137 ns | 0.0121 ns | 11.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.188 ns | 0.0445 ns | 0.0372 ns | 10.178 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.495 ns | 0.0228 ns | 0.0214 ns |  6.497 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.142 ns | 0.0063 ns | 0.0056 ns | 11.143 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.297 ns | 0.0078 ns | 0.0065 ns | 10.299 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.936 ns | 0.0134 ns | 0.0125 ns | 13.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.388 ns | 0.0351 ns | 0.0328 ns | 13.386 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.733 ns | 0.1364 ns | 0.1276 ns | 13.661 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.242 ns | 0.0150 ns | 0.0133 ns | 13.243 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.060 ns | 0.0214 ns | 0.0200 ns | 13.062 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.574 ns | 0.0124 ns | 0.0110 ns | 11.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.180 ns | 0.0144 ns | 0.0128 ns | 10.180 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.982 ns | 0.0040 ns | 0.0033 ns |  6.982 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.257 ns | 0.0217 ns | 0.0203 ns | 10.265 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.162 ns | 0.0146 ns | 0.0137 ns | 10.162 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.117 ns | 0.0168 ns | 0.0149 ns | 19.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 16.996 ns | 0.0607 ns | 0.0567 ns | 16.979 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.991 ns | 0.0151 ns | 0.0141 ns | 15.993 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 17.796 ns | 0.0279 ns | 0.0261 ns | 17.802 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 17.721 ns | 0.0530 ns | 0.0470 ns | 17.722 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.790 ns | 0.0124 ns | 0.0116 ns | 12.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.317 ns | 0.0058 ns | 0.0054 ns | 11.317 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.638 ns | 0.1207 ns | 0.1129 ns |  7.700 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 10.527 ns | 0.0107 ns | 0.0100 ns | 10.529 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.515 ns | 0.0111 ns | 0.0104 ns | 10.516 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.879 ns | 0.0310 ns | 0.0290 ns | 18.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.515 ns | 0.0557 ns | 0.0521 ns | 16.505 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.537 ns | 0.0345 ns | 0.0323 ns | 15.543 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 17.836 ns | 0.0550 ns | 0.0514 ns | 17.840 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 17.882 ns | 0.0297 ns | 0.0277 ns | 17.883 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.496 ns | 0.0122 ns | 0.0114 ns | 11.498 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.204 ns | 0.0078 ns | 0.0072 ns | 10.203 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.939 ns | 0.3940 ns | 0.4046 ns |  6.718 ns |  0.61 |    0.04 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.059 ns | 0.0122 ns | 0.0108 ns | 12.061 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.356 ns | 0.0255 ns | 0.0239 ns | 10.353 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.921 ns | 0.0118 ns | 0.0110 ns | 13.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.543 ns | 0.0098 ns | 0.0087 ns | 12.545 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.686 ns | 0.0411 ns | 0.0343 ns | 13.692 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 12.937 ns | 0.0149 ns | 0.0132 ns | 12.937 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.079 ns | 0.0224 ns | 0.0209 ns | 13.075 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 11.901 ns | 0.0325 ns | 0.0304 ns | 11.906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.208 ns | 0.0203 ns | 0.0190 ns | 11.209 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.266 ns | 0.2107 ns | 0.5247 ns |  9.438 ns |  0.72 |    0.08 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.890 ns | 0.0456 ns | 0.0426 ns | 12.901 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.598 ns | 0.0192 ns | 0.0180 ns | 12.595 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.469 ns | 0.0087 ns | 0.0081 ns | 12.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.089 ns | 0.0156 ns | 0.0146 ns | 11.086 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.327 ns | 0.0866 ns | 0.0810 ns |  8.372 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.769 ns | 0.0328 ns | 0.0306 ns | 12.763 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.601 ns | 0.0083 ns | 0.0073 ns | 13.605 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.465 ns | 0.0120 ns | 0.0107 ns | 12.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.064 ns | 0.0091 ns | 0.0085 ns | 11.064 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.641 ns | 0.0100 ns | 0.0089 ns |  7.642 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.378 ns | 0.0108 ns | 0.0101 ns | 13.377 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.704 ns | 0.0372 ns | 0.0311 ns | 13.701 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.802 ns | 0.0088 ns | 0.0083 ns | 14.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.563 ns | 0.0149 ns | 0.0139 ns | 12.567 ns |  0.85 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.148 ns | 0.1978 ns | 0.1850 ns | 14.034 ns |  0.96 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 12.889 ns | 0.0301 ns | 0.0282 ns | 12.887 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.101 ns | 0.0184 ns | 0.0172 ns | 13.104 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.422 ns | 0.0215 ns | 0.0202 ns | 21.418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 20.199 ns | 0.0182 ns | 0.0170 ns | 20.198 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.763 ns | 0.0660 ns | 0.0617 ns | 13.789 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.938 ns | 0.0280 ns | 0.0262 ns | 21.933 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 21.980 ns | 0.0263 ns | 0.0233 ns | 21.976 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.384 ns | 0.0144 ns | 0.0128 ns | 26.387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 24.718 ns | 0.0140 ns | 0.0131 ns | 24.722 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 20.925 ns | 0.4379 ns | 0.6817 ns | 21.364 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.860 ns | 0.0780 ns | 0.0729 ns | 27.869 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 26.594 ns | 0.1456 ns | 0.1290 ns | 26.559 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.289 ns | 0.0106 ns | 0.0094 ns | 22.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.700 ns | 0.0466 ns | 0.0435 ns | 20.702 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 15.531 ns | 0.0113 ns | 0.0100 ns | 15.529 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 23.144 ns | 0.0339 ns | 0.0317 ns | 23.140 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 22.717 ns | 0.0603 ns | 0.0564 ns | 22.726 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.582 ns | 0.0206 ns | 0.0161 ns | 26.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.744 ns | 0.0151 ns | 0.0141 ns | 25.750 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.434 ns | 0.2332 ns | 0.2181 ns | 19.426 ns |  0.73 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.428 ns | 0.0245 ns | 0.0229 ns | 26.429 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 29.878 ns | 0.0169 ns | 0.0158 ns | 29.881 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.489 ns | 0.0147 ns | 0.0131 ns | 12.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.641 ns | 0.0113 ns | 0.0106 ns | 11.643 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.375 ns | 0.0143 ns | 0.0134 ns |  8.374 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.226 ns | 0.0561 ns | 0.0525 ns | 14.209 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.042 ns | 0.0079 ns | 0.0070 ns | 14.042 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.755 ns | 0.0222 ns | 0.0208 ns | 14.758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.393 ns | 0.0317 ns | 0.0296 ns | 13.401 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.758 ns | 0.0136 ns | 0.0127 ns | 12.756 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 12.953 ns | 0.0186 ns | 0.0174 ns | 12.947 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.676 ns | 0.0338 ns | 0.0317 ns | 13.679 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.932 ns | 0.0235 ns | 0.0220 ns | 13.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.941 ns | 0.0088 ns | 0.0082 ns | 12.941 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  8.279 ns | 0.0122 ns | 0.0114 ns |  8.276 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.591 ns | 0.0161 ns | 0.0142 ns | 13.592 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.597 ns | 0.0171 ns | 0.0152 ns | 13.600 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.416 ns | 0.0536 ns | 0.0502 ns | 21.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.005 ns | 0.0550 ns | 0.0515 ns | 18.020 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 16.461 ns | 0.0493 ns | 0.0461 ns | 16.457 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.296 ns | 0.0412 ns | 0.0322 ns | 21.308 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 21.467 ns | 0.0248 ns | 0.0232 ns | 21.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.144 ns | 0.0316 ns | 0.0295 ns | 15.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.013 ns | 0.0280 ns | 0.0262 ns | 14.024 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.096 ns | 0.0144 ns | 0.0127 ns | 10.099 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.769 ns | 0.0256 ns | 0.0239 ns | 15.769 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.780 ns | 0.0507 ns | 0.0475 ns | 15.789 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.464 ns | 0.0324 ns | 0.0303 ns | 21.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.704 ns | 0.0187 ns | 0.0156 ns | 17.707 ns |  0.82 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.780 ns | 0.3945 ns | 0.8658 ns | 19.025 ns |  0.83 |    0.05 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 22.462 ns | 0.0321 ns | 0.0301 ns | 22.448 ns |  1.05 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 22.845 ns | 0.0166 ns | 0.0156 ns | 22.843 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.402 ns | 0.0330 ns | 0.0309 ns | 12.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.446 ns | 0.0133 ns | 0.0124 ns | 11.444 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.777 ns | 0.0093 ns | 0.0087 ns |  7.776 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.166 ns | 0.0313 ns | 0.0293 ns | 13.164 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.487 ns | 0.0199 ns | 0.0187 ns | 12.489 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.792 ns | 0.0076 ns | 0.0068 ns | 14.794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.524 ns | 0.0346 ns | 0.0324 ns | 12.529 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.371 ns | 0.0426 ns | 0.0398 ns | 13.368 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 12.975 ns | 0.0227 ns | 0.0212 ns | 12.974 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.115 ns | 0.0300 ns | 0.0280 ns | 13.121 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.573 ns | 0.0074 ns | 0.0069 ns | 11.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.181 ns | 0.0170 ns | 0.0159 ns | 10.180 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.983 ns | 0.0092 ns | 0.0077 ns |  6.985 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.235 ns | 0.0101 ns | 0.0085 ns | 10.236 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.166 ns | 0.0109 ns | 0.0102 ns | 10.166 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.691 ns | 0.0235 ns | 0.0220 ns | 19.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.552 ns | 0.0116 ns | 0.0108 ns | 15.552 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 15.616 ns | 0.0206 ns | 0.0193 ns | 15.610 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 18.453 ns | 0.0275 ns | 0.0257 ns | 18.459 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 18.512 ns | 0.0651 ns | 0.0609 ns | 18.526 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.734 ns | 0.0117 ns | 0.0110 ns | 11.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.320 ns | 0.0105 ns | 0.0093 ns | 10.324 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.745 ns | 0.0561 ns | 0.0524 ns |  6.723 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 10.760 ns | 0.0277 ns | 0.0260 ns | 10.763 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.525 ns | 0.0274 ns | 0.0243 ns | 10.532 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.161 ns | 0.0252 ns | 0.0236 ns | 18.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.596 ns | 0.0138 ns | 0.0129 ns | 15.594 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.824 ns | 0.0218 ns | 0.0204 ns | 14.816 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.462 ns | 0.0201 ns | 0.0179 ns | 18.463 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.525 ns | 0.0322 ns | 0.0301 ns | 18.531 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.513 ns | 0.0129 ns | 0.0120 ns | 11.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.201 ns | 0.0120 ns | 0.0112 ns | 10.203 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.310 ns | 0.0220 ns | 0.0206 ns |  7.302 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.283 ns | 0.0115 ns | 0.0108 ns | 10.285 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.271 ns | 0.0094 ns | 0.0088 ns | 10.271 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.920 ns | 0.0125 ns | 0.0111 ns | 13.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.372 ns | 0.0192 ns | 0.0179 ns | 13.369 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.647 ns | 0.0510 ns | 0.0477 ns | 13.638 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 12.949 ns | 0.0203 ns | 0.0180 ns | 12.948 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.434 ns | 0.0296 ns | 0.0276 ns | 13.438 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.567 ns | 0.0092 ns | 0.0086 ns | 11.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.176 ns | 0.0081 ns | 0.0076 ns | 10.176 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.768 ns | 0.0054 ns | 0.0048 ns |  6.768 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 11.198 ns | 0.0047 ns | 0.0042 ns | 11.198 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.165 ns | 0.0201 ns | 0.0188 ns | 10.166 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.402 ns | 0.0329 ns | 0.0308 ns | 18.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 15.334 ns | 0.0201 ns | 0.0188 ns | 15.326 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.301 ns | 0.0245 ns | 0.0191 ns | 15.304 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 19.534 ns | 0.0489 ns | 0.0458 ns | 19.526 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.452 ns | 0.0464 ns | 0.0434 ns | 18.449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.741 ns | 0.0106 ns | 0.0094 ns | 11.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.299 ns | 0.0242 ns | 0.0227 ns | 10.301 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.504 ns | 0.0177 ns | 0.0157 ns |  7.499 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 10.482 ns | 0.0048 ns | 0.0045 ns | 10.481 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.538 ns | 0.0357 ns | 0.0334 ns | 10.543 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.379 ns | 0.0286 ns | 0.0268 ns | 18.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.585 ns | 0.0133 ns | 0.0124 ns | 15.587 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.608 ns | 0.0199 ns | 0.0186 ns | 15.608 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 19.676 ns | 0.0286 ns | 0.0253 ns | 19.682 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.511 ns | 0.0432 ns | 0.0404 ns | 18.512 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.527 ns | 0.0168 ns | 0.0158 ns | 11.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.202 ns | 0.0054 ns | 0.0048 ns | 10.200 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.328 ns | 0.0098 ns | 0.0087 ns |  7.329 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.178 ns | 0.0227 ns | 0.0212 ns | 10.177 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.759 ns | 0.0133 ns | 0.0125 ns | 11.758 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.652 ns | 0.0083 ns | 0.0078 ns | 14.654 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.550 ns | 0.0467 ns | 0.0437 ns | 12.537 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.775 ns | 0.0311 ns | 0.0291 ns | 12.771 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.035 ns | 0.0355 ns | 0.0332 ns | 13.031 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.185 ns | 0.0695 ns | 0.0650 ns | 13.175 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 11.531 ns | 0.0089 ns | 0.0083 ns | 11.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.674 ns | 0.0088 ns | 0.0078 ns | 10.673 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  6.778 ns | 0.0038 ns | 0.0034 ns |  6.778 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.205 ns | 0.0136 ns | 0.0127 ns | 10.206 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.231 ns | 0.0104 ns | 0.0097 ns | 10.232 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 14.491 ns | 0.0151 ns | 0.0118 ns | 14.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 13.037 ns | 0.0057 ns | 0.0048 ns | 13.038 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 13.530 ns | 0.2857 ns | 0.2806 ns | 13.344 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 13.858 ns | 0.0410 ns | 0.0364 ns | 13.852 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 13.940 ns | 0.0330 ns | 0.0308 ns | 13.926 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 12.505 ns | 0.0142 ns | 0.0132 ns | 12.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.254 ns | 0.0065 ns | 0.0060 ns | 11.256 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 |  8.130 ns | 0.0635 ns | 0.0594 ns |  8.144 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 12.788 ns | 0.0083 ns | 0.0078 ns | 12.789 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.835 ns | 0.0258 ns | 0.0242 ns | 13.846 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.370 ns | 0.0142 ns | 0.0133 ns | 15.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.067 ns | 0.0109 ns | 0.0097 ns | 13.069 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.820 ns | 0.3207 ns | 0.4897 ns | 15.167 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 15.453 ns | 0.0317 ns | 0.0296 ns | 15.455 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 14.127 ns | 0.0667 ns | 0.0624 ns | 14.133 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 14.833 ns | 0.0108 ns | 0.0096 ns | 14.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.133 ns | 0.0129 ns | 0.0121 ns | 11.138 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  7.845 ns | 0.0129 ns | 0.0121 ns |  7.844 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.205 ns | 0.0191 ns | 0.0179 ns | 13.203 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.584 ns | 0.0332 ns | 0.0311 ns | 12.587 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.919 ns | 0.0126 ns | 0.0118 ns | 13.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.535 ns | 0.0360 ns | 0.0337 ns | 12.549 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.106 ns | 0.0306 ns | 0.0286 ns | 11.113 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 12.926 ns | 0.0423 ns | 0.0396 ns | 12.934 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 14.558 ns | 0.0148 ns | 0.0138 ns | 14.556 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.573 ns | 0.0111 ns | 0.0104 ns | 11.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.164 ns | 0.0101 ns | 0.0094 ns | 10.165 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.958 ns | 0.1622 ns | 0.1736 ns |  7.089 ns |  0.60 |    0.02 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.293 ns | 0.0097 ns | 0.0091 ns | 10.292 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.145 ns | 0.0137 ns | 0.0114 ns | 10.147 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.194 ns | 0.0359 ns | 0.0336 ns | 18.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.805 ns | 0.0192 ns | 0.0179 ns | 16.811 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 16.512 ns | 0.0358 ns | 0.0335 ns | 16.529 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.264 ns | 0.0672 ns | 0.0629 ns | 18.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.309 ns | 0.0435 ns | 0.0407 ns | 18.319 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.717 ns | 0.0149 ns | 0.0125 ns | 11.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 12.038 ns | 0.0328 ns | 0.0307 ns | 12.041 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.721 ns | 0.0134 ns | 0.0112 ns |  6.723 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.190 ns | 0.0358 ns | 0.0335 ns | 11.197 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.510 ns | 0.0092 ns | 0.0086 ns | 10.511 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.179 ns | 0.0389 ns | 0.0364 ns | 18.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.231 ns | 0.0210 ns | 0.0196 ns | 17.234 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.747 ns | 0.0252 ns | 0.0236 ns | 14.748 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 17.963 ns | 0.0226 ns | 0.0212 ns | 17.965 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 17.950 ns | 0.0348 ns | 0.0291 ns | 17.952 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.498 ns | 0.0120 ns | 0.0112 ns | 11.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.188 ns | 0.0295 ns | 0.0276 ns | 10.190 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.752 ns | 0.0313 ns | 0.0293 ns |  6.760 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.484 ns | 0.0152 ns | 0.0135 ns | 11.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.372 ns | 0.0186 ns | 0.0174 ns | 10.368 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.926 ns | 0.0088 ns | 0.0082 ns | 13.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.547 ns | 0.0113 ns | 0.0106 ns | 12.545 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.642 ns | 0.2537 ns | 0.3638 ns | 11.715 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 12.941 ns | 0.0197 ns | 0.0184 ns | 12.945 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.052 ns | 0.0086 ns | 0.0072 ns | 13.053 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.093 ns | 0.0184 ns | 0.0173 ns | 14.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 11.375 ns | 0.0126 ns | 0.0112 ns | 11.371 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  7.986 ns | 0.0091 ns | 0.0085 ns |  7.986 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.824 ns | 0.0238 ns | 0.0222 ns | 13.822 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 13.768 ns | 0.0478 ns | 0.0447 ns | 13.760 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.676 ns | 0.0481 ns | 0.0450 ns | 21.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.907 ns | 0.0602 ns | 0.0563 ns | 17.891 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.512 ns | 0.0244 ns | 0.0228 ns | 17.515 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.311 ns | 0.0200 ns | 0.0177 ns | 21.318 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 21.697 ns | 0.0252 ns | 0.0236 ns | 21.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.674 ns | 0.0109 ns | 0.0096 ns | 13.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.892 ns | 0.1211 ns | 0.1073 ns | 11.906 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  8.260 ns | 0.1861 ns | 0.1911 ns |  8.115 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.184 ns | 0.0151 ns | 0.0142 ns | 13.186 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.249 ns | 0.0070 ns | 0.0058 ns | 13.250 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.460 ns | 0.0565 ns | 0.0529 ns | 21.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.480 ns | 0.0828 ns | 0.0774 ns | 18.452 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.086 ns | 0.0842 ns | 0.0788 ns | 18.130 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.410 ns | 0.0364 ns | 0.0341 ns | 21.420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 21.593 ns | 0.0416 ns | 0.0389 ns | 21.583 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.513 ns | 0.0136 ns | 0.0127 ns | 11.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.225 ns | 0.0311 ns | 0.0291 ns | 10.223 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.761 ns | 0.0379 ns | 0.0354 ns |  6.763 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.221 ns | 0.0097 ns | 0.0091 ns | 10.223 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.298 ns | 0.0147 ns | 0.0138 ns | 10.296 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.796 ns | 0.0065 ns | 0.0061 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.554 ns | 0.0121 ns | 0.0114 ns | 12.554 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.101 ns | 0.1511 ns | 0.1414 ns | 13.167 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.673 ns | 0.0091 ns | 0.0085 ns | 13.673 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.063 ns | 0.0245 ns | 0.0230 ns | 13.064 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.674 ns | 0.1797 ns | 0.1681 ns | 59.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 50.393 ns | 0.0449 ns | 0.0398 ns | 50.390 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.951 ns | 0.0497 ns | 0.0465 ns | 20.976 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.077 ns | 0.1114 ns | 0.1042 ns | 59.064 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 58.738 ns | 0.1409 ns | 0.1318 ns | 58.774 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.062 ns | 0.0738 ns | 0.0690 ns | 64.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.756 ns | 0.1687 ns | 0.1578 ns | 58.802 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 24.448 ns | 0.0226 ns | 0.0201 ns | 24.455 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.705 ns | 0.1282 ns | 0.1136 ns | 63.680 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 63.730 ns | 0.1518 ns | 0.1420 ns | 63.757 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.973 ns | 0.0114 ns | 0.0107 ns | 12.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.024 ns | 0.0068 ns | 0.0064 ns | 12.024 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.479 ns | 0.0314 ns | 0.0294 ns | 11.480 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.561 ns | 0.0122 ns | 0.0114 ns | 12.562 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.350 ns | 0.0162 ns | 0.0144 ns | 14.352 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.938 ns | 0.0145 ns | 0.0136 ns | 13.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.536 ns | 0.0078 ns | 0.0073 ns | 12.536 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.112 ns | 0.2680 ns | 0.4172 ns | 12.273 ns |  0.85 |    0.04 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.296 ns | 0.0115 ns | 0.0102 ns | 13.294 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.308 ns | 0.0171 ns | 0.0151 ns | 13.310 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.488 ns | 0.0057 ns | 0.0051 ns | 12.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 11.959 ns | 0.0432 ns | 0.0361 ns | 11.946 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 11.471 ns | 0.0355 ns | 0.0332 ns | 11.471 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 11.224 ns | 0.0240 ns | 0.0213 ns | 11.229 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 11.324 ns | 0.0249 ns | 0.0233 ns | 11.327 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.584 ns | 0.0126 ns | 0.0118 ns | 11.586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.192 ns | 0.0092 ns | 0.0086 ns | 10.195 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.788 ns | 0.0258 ns | 0.0241 ns |  6.784 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 11.679 ns | 0.0059 ns | 0.0050 ns | 11.679 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.183 ns | 0.0075 ns | 0.0063 ns | 10.185 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.178 ns | 0.0220 ns | 0.0205 ns | 18.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.349 ns | 0.0233 ns | 0.0218 ns | 15.353 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.718 ns | 0.0256 ns | 0.0240 ns | 15.723 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 17.899 ns | 0.0262 ns | 0.0245 ns | 17.893 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.032 ns | 0.0403 ns | 0.0377 ns | 18.044 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.731 ns | 0.0083 ns | 0.0074 ns | 11.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.337 ns | 0.0273 ns | 0.0256 ns | 10.329 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  6.724 ns | 0.0112 ns | 0.0105 ns |  6.725 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 10.822 ns | 0.1128 ns | 0.1055 ns | 10.812 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 10.507 ns | 0.0129 ns | 0.0114 ns | 10.507 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.374 ns | 0.0275 ns | 0.0257 ns | 18.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.346 ns | 0.0201 ns | 0.0188 ns | 15.344 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.768 ns | 0.0411 ns | 0.0384 ns | 15.777 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.526 ns | 0.0237 ns | 0.0222 ns | 19.530 ns |  1.06 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.209 ns | 0.0387 ns | 0.0362 ns | 18.199 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.530 ns | 0.0368 ns | 0.0344 ns | 11.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 13.051 ns | 0.0111 ns | 0.0093 ns | 13.055 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.673 ns | 0.1730 ns | 0.2187 ns |  7.683 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.482 ns | 0.0198 ns | 0.0185 ns | 11.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.272 ns | 0.0116 ns | 0.0109 ns | 10.272 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.791 ns | 0.0144 ns | 0.0120 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.551 ns | 0.0109 ns | 0.0102 ns | 12.552 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.648 ns | 0.0114 ns | 0.0106 ns | 13.647 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.015 ns | 0.0283 ns | 0.0265 ns | 13.023 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.532 ns | 0.0213 ns | 0.0199 ns | 13.538 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.544 ns | 0.0096 ns | 0.0080 ns | 11.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.174 ns | 0.0101 ns | 0.0090 ns | 10.175 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.525 ns | 0.0222 ns | 0.0208 ns |  6.523 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.679 ns | 0.0195 ns | 0.0173 ns | 10.678 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.164 ns | 0.0114 ns | 0.0107 ns | 10.165 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 18.656 ns | 0.0359 ns | 0.0336 ns | 18.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.541 ns | 0.0489 ns | 0.0458 ns | 15.554 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 14.837 ns | 0.0331 ns | 0.0309 ns | 14.839 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.419 ns | 0.0470 ns | 0.0440 ns | 18.425 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.529 ns | 0.0270 ns | 0.0252 ns | 18.526 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.723 ns | 0.0082 ns | 0.0068 ns | 11.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.320 ns | 0.0089 ns | 0.0084 ns | 10.321 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.879 ns | 0.0085 ns | 0.0071 ns |  6.882 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 10.542 ns | 0.0108 ns | 0.0101 ns | 10.540 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 10.514 ns | 0.0139 ns | 0.0130 ns | 10.514 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.153 ns | 0.0188 ns | 0.0166 ns | 18.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.091 ns | 0.0752 ns | 0.0703 ns | 16.104 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.595 ns | 0.0419 ns | 0.0392 ns | 15.599 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.149 ns | 0.0144 ns | 0.0135 ns | 18.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.230 ns | 0.0279 ns | 0.0261 ns | 18.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.873 ns | 0.0214 ns | 0.0200 ns | 13.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.265 ns | 0.0110 ns | 0.0103 ns | 11.268 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  8.275 ns | 0.1883 ns | 0.4583 ns |  8.450 ns |  0.55 |    0.05 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.160 ns | 0.0129 ns | 0.0120 ns | 10.159 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.275 ns | 0.0105 ns | 0.0093 ns | 10.275 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.924 ns | 0.0106 ns | 0.0094 ns | 13.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.368 ns | 0.0141 ns | 0.0125 ns | 13.365 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.100 ns | 0.2646 ns | 0.3533 ns | 12.276 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 12.959 ns | 0.0215 ns | 0.0201 ns | 12.950 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.104 ns | 0.0251 ns | 0.0235 ns | 13.105 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.643 ns | 0.0120 ns | 0.0112 ns | 11.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.297 ns | 0.0294 ns | 0.0275 ns | 10.289 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.024 ns | 0.0196 ns | 0.0164 ns |  7.028 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.841 ns | 0.0113 ns | 0.0101 ns | 10.840 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.664 ns | 0.0143 ns | 0.0133 ns | 10.664 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.647 ns | 0.0311 ns | 0.0260 ns | 18.644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.808 ns | 0.0173 ns | 0.0153 ns | 15.806 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.772 ns | 0.3557 ns | 0.5325 ns | 17.079 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.026 ns | 0.0410 ns | 0.0364 ns | 19.021 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.164 ns | 0.0286 ns | 0.0254 ns | 19.167 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.658 ns | 0.0124 ns | 0.0116 ns | 12.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.310 ns | 0.0096 ns | 0.0090 ns | 11.312 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.565 ns | 0.0130 ns | 0.0122 ns |  8.563 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.306 ns | 0.0295 ns | 0.0246 ns | 14.309 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.690 ns | 0.0304 ns | 0.0284 ns | 13.689 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.387 ns | 0.0253 ns | 0.0224 ns | 18.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.368 ns | 0.0508 ns | 0.0450 ns | 16.375 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.042 ns | 0.0367 ns | 0.0306 ns | 15.046 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 19.186 ns | 0.0382 ns | 0.0357 ns | 19.188 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.178 ns | 0.0332 ns | 0.0311 ns | 19.170 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.375 ns | 0.0237 ns | 0.0222 ns | 12.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.877 ns | 0.0070 ns | 0.0066 ns | 11.877 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.705 ns | 0.0112 ns | 0.0099 ns |  7.707 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.574 ns | 0.0100 ns | 0.0089 ns | 12.574 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.516 ns | 0.0062 ns | 0.0058 ns | 12.517 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.898 ns | 0.0347 ns | 0.0325 ns | 13.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.569 ns | 0.0223 ns | 0.0208 ns | 12.578 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.204 ns | 0.0082 ns | 0.0077 ns | 11.203 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.210 ns | 0.0194 ns | 0.0172 ns | 13.211 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 19.453 ns | 0.0173 ns | 0.0161 ns | 19.447 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.922 ns | 0.0073 ns | 0.0065 ns | 13.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.547 ns | 0.0075 ns | 0.0066 ns | 12.550 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.686 ns | 0.1967 ns | 0.1840 ns | 11.753 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.556 ns | 0.0184 ns | 0.0172 ns | 13.559 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.084 ns | 0.0231 ns | 0.0216 ns | 13.084 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.638 ns | 0.0123 ns | 0.0115 ns | 10.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  8.916 ns | 0.0067 ns | 0.0062 ns |  8.915 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.719 ns | 0.0134 ns | 0.0119 ns | 10.723 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 10.985 ns | 0.0153 ns | 0.0143 ns | 10.985 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 10.887 ns | 0.0527 ns | 0.0440 ns | 10.881 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.951 ns | 0.0308 ns | 0.0288 ns | 13.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.709 ns | 0.0219 ns | 0.0205 ns | 13.704 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 12.749 ns | 0.0591 ns | 0.0553 ns | 12.714 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.143 ns | 0.0181 ns | 0.0169 ns | 13.141 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.102 ns | 0.0239 ns | 0.0223 ns | 13.103 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 14.761 ns | 0.0142 ns | 0.0126 ns | 14.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.153 ns | 0.0094 ns | 0.0083 ns | 13.152 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.175 ns | 0.0234 ns | 0.0218 ns | 12.182 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 16.768 ns | 0.0645 ns | 0.0603 ns | 16.758 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.799 ns | 0.0541 ns | 0.0506 ns | 16.797 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 16.703 ns | 0.0414 ns | 0.0387 ns | 16.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 14.877 ns | 0.0124 ns | 0.0116 ns | 14.879 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.554 ns | 0.3352 ns | 0.6378 ns | 15.882 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.777 ns | 0.0275 ns | 0.0257 ns | 16.789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 16.948 ns | 0.0292 ns | 0.0259 ns | 16.951 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 12.786 ns | 0.0374 ns | 0.0350 ns | 12.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.565 ns | 0.0207 ns | 0.0194 ns | 11.569 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.223 ns | 0.2704 ns | 0.4129 ns | 12.478 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.775 ns | 0.0363 ns | 0.0321 ns | 14.768 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.112 ns | 0.0177 ns | 0.0166 ns | 13.105 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.921 ns | 0.0070 ns | 0.0062 ns | 13.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.150 ns | 0.0112 ns | 0.0094 ns | 13.151 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.128 ns | 0.6968 ns | 0.8295 ns | 11.744 ns |  0.89 |    0.07 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.039 ns | 0.0362 ns | 0.0338 ns | 13.040 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.167 ns | 0.0395 ns | 0.0370 ns | 13.169 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.087 ns | 0.0206 ns | 0.0172 ns | 13.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.224 ns | 0.0386 ns | 0.0361 ns | 10.211 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.124 ns | 0.0080 ns | 0.0071 ns | 11.124 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.238 ns | 0.0144 ns | 0.0135 ns | 12.241 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.255 ns | 0.0238 ns | 0.0223 ns | 12.255 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.718 ns | 0.0429 ns | 0.0401 ns | 15.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.799 ns | 0.0274 ns | 0.0257 ns | 14.803 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 12.773 ns | 0.0110 ns | 0.0097 ns | 12.775 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 14.978 ns | 0.0214 ns | 0.0200 ns | 14.981 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 14.852 ns | 0.0186 ns | 0.0174 ns | 14.842 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 11.665 ns | 0.0117 ns | 0.0098 ns | 11.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.249 ns | 0.0094 ns | 0.0084 ns | 10.250 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.669 ns | 0.0127 ns | 0.0100 ns | 10.670 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 13.841 ns | 0.0442 ns | 0.0413 ns | 13.838 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.466 ns | 0.0239 ns | 0.0211 ns | 12.472 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.254 ns | 0.0131 ns | 0.0122 ns | 14.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.393 ns | 0.0319 ns | 0.0299 ns | 13.379 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 11.447 ns | 0.1576 ns | 0.1474 ns | 11.390 ns |  0.80 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 15.582 ns | 0.0139 ns | 0.0123 ns | 15.581 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.072 ns | 0.0182 ns | 0.0170 ns | 13.073 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.527 ns | 0.0609 ns | 0.0570 ns | 18.524 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.137 ns | 0.0425 ns | 0.0398 ns | 16.129 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.210 ns | 0.0406 ns | 0.0380 ns | 11.226 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 16.367 ns | 0.0220 ns | 0.0195 ns | 16.366 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.360 ns | 0.0184 ns | 0.0163 ns | 16.359 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.258 ns | 0.0227 ns | 0.0190 ns | 18.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.535 ns | 0.0218 ns | 0.0204 ns | 15.539 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.057 ns | 0.0531 ns | 0.0497 ns | 16.055 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.428 ns | 0.0383 ns | 0.0358 ns | 17.439 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.575 ns | 0.0491 ns | 0.0460 ns | 17.574 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.691 ns | 0.0490 ns | 0.0458 ns | 18.698 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.834 ns | 0.0304 ns | 0.0270 ns | 15.838 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 12.035 ns | 0.1997 ns | 0.1868 ns | 12.149 ns |  0.64 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 16.695 ns | 0.0276 ns | 0.0245 ns | 16.694 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 16.697 ns | 0.0288 ns | 0.0269 ns | 16.691 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.335 ns | 0.0525 ns | 0.0465 ns | 17.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.016 ns | 0.0324 ns | 0.0303 ns | 16.019 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.996 ns | 0.0357 ns | 0.0334 ns | 16.002 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.440 ns | 0.0354 ns | 0.0331 ns | 17.431 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.568 ns | 0.0209 ns | 0.0195 ns | 17.569 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.069 ns | 0.0072 ns | 0.0064 ns | 13.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.812 ns | 0.0189 ns | 0.0176 ns | 11.813 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.943 ns | 0.2390 ns | 0.6857 ns | 10.117 ns |  0.68 |    0.11 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.395 ns | 0.0148 ns | 0.0138 ns | 10.394 ns |  0.80 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.385 ns | 0.0297 ns | 0.0278 ns | 10.393 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.796 ns | 0.0095 ns | 0.0089 ns | 14.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.371 ns | 0.0060 ns | 0.0056 ns | 13.370 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.484 ns | 0.0988 ns | 0.0925 ns | 11.472 ns |  0.78 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 12.923 ns | 0.0198 ns | 0.0176 ns | 12.923 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.093 ns | 0.0178 ns | 0.0167 ns | 13.094 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 12.928 ns | 0.0343 ns | 0.0321 ns | 12.917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.602 ns | 0.0263 ns | 0.0246 ns | 10.600 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.545 ns | 0.1565 ns | 0.1675 ns |  6.650 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.218 ns | 0.0158 ns | 0.0140 ns | 10.221 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.410 ns | 0.0113 ns | 0.0100 ns | 11.409 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.818 ns | 0.0191 ns | 0.0178 ns | 14.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.761 ns | 0.0135 ns | 0.0113 ns | 14.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 12.717 ns | 0.0152 ns | 0.0119 ns | 12.719 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.692 ns | 0.0423 ns | 0.0395 ns | 14.677 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.935 ns | 0.0366 ns | 0.0342 ns | 14.949 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 11.517 ns | 0.0318 ns | 0.0298 ns | 11.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.634 ns | 0.0144 ns | 0.0134 ns | 10.636 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.356 ns | 0.0059 ns | 0.0055 ns |  6.358 ns |  0.55 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.233 ns | 0.0127 ns | 0.0119 ns | 10.236 ns |  0.89 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.406 ns | 0.0179 ns | 0.0167 ns | 11.413 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.806 ns | 0.0132 ns | 0.0124 ns | 14.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.907 ns | 0.0118 ns | 0.0111 ns | 13.907 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 12.761 ns | 0.0239 ns | 0.0212 ns | 12.764 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.201 ns | 0.0455 ns | 0.0426 ns | 16.213 ns |  1.09 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 14.888 ns | 0.0317 ns | 0.0297 ns | 14.893 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 11.552 ns | 0.0089 ns | 0.0083 ns | 11.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.622 ns | 0.0087 ns | 0.0081 ns | 10.619 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.835 ns | 0.0070 ns | 0.0065 ns |  6.836 ns |  0.59 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.228 ns | 0.0172 ns | 0.0143 ns | 10.229 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.426 ns | 0.0198 ns | 0.0186 ns | 11.422 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.150 ns | 0.0231 ns | 0.0217 ns | 15.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.564 ns | 0.0216 ns | 0.0192 ns | 12.562 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.257 ns | 0.2219 ns | 0.2075 ns | 11.128 ns |  0.74 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 12.966 ns | 0.0212 ns | 0.0198 ns | 12.974 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.087 ns | 0.0184 ns | 0.0172 ns | 13.088 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.535 ns | 0.0109 ns | 0.0102 ns | 11.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.170 ns | 0.0046 ns | 0.0043 ns | 10.170 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.878 ns | 0.1343 ns | 0.1256 ns |  6.966 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.146 ns | 0.0350 ns | 0.0327 ns | 10.160 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.193 ns | 0.0120 ns | 0.0112 ns | 10.193 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 45.560 ns | 0.0759 ns | 0.0710 ns | 45.573 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.707 ns | 0.1388 ns | 0.1230 ns | 44.725 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 38.465 ns | 0.0592 ns | 0.0553 ns | 38.476 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 41.707 ns | 0.0676 ns | 0.0632 ns | 41.703 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 42.563 ns | 0.0811 ns | 0.0677 ns | 42.578 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 11.752 ns | 0.0220 ns | 0.0206 ns | 11.743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.826 ns | 0.0092 ns | 0.0086 ns | 10.827 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  6.752 ns | 0.0468 ns | 0.0437 ns |  6.753 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.402 ns | 0.0123 ns | 0.0115 ns | 12.403 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.723 ns | 0.0115 ns | 0.0107 ns | 10.726 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 42.945 ns | 0.1238 ns | 0.1097 ns | 42.922 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 41.959 ns | 0.1003 ns | 0.0939 ns | 41.946 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.953 ns | 0.8491 ns | 1.3220 ns | 42.263 ns |  0.97 |    0.05 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.335 ns | 0.0603 ns | 0.0564 ns | 43.365 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 42.720 ns | 0.0957 ns | 0.0895 ns | 42.692 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 11.673 ns | 0.0116 ns | 0.0108 ns | 11.674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.657 ns | 0.0102 ns | 0.0095 ns | 10.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  6.783 ns | 0.0157 ns | 0.0147 ns |  6.779 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.345 ns | 0.0131 ns | 0.0122 ns | 10.348 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.653 ns | 0.0095 ns | 0.0089 ns | 10.654 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.792 ns | 0.0094 ns | 0.0088 ns | 14.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.543 ns | 0.0065 ns | 0.0061 ns | 12.545 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.606 ns | 0.0352 ns | 0.0330 ns | 13.606 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.026 ns | 0.0357 ns | 0.0316 ns | 13.031 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.071 ns | 0.0215 ns | 0.0202 ns | 13.078 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 11.815 ns | 0.0168 ns | 0.0157 ns | 11.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.241 ns | 0.0078 ns | 0.0069 ns | 10.241 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.219 ns | 0.0221 ns | 0.0207 ns | 11.219 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 13.829 ns | 0.0271 ns | 0.0254 ns | 13.831 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.551 ns | 0.0258 ns | 0.0242 ns | 12.553 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.285 ns | 0.0184 ns | 0.0172 ns | 15.287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.131 ns | 0.0224 ns | 0.0210 ns | 15.131 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.259 ns | 0.0927 ns | 0.0867 ns | 13.283 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.079 ns | 0.0434 ns | 0.0406 ns | 15.082 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.183 ns | 0.0352 ns | 0.0329 ns | 15.183 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.030 ns | 0.0129 ns | 0.0121 ns | 12.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.242 ns | 0.0077 ns | 0.0072 ns | 10.243 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.697 ns | 0.0264 ns | 0.0247 ns | 10.696 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.219 ns | 0.0303 ns | 0.0268 ns | 12.224 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.264 ns | 0.0216 ns | 0.0202 ns | 12.266 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.955 ns | 0.0097 ns | 0.0090 ns | 13.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.549 ns | 0.0097 ns | 0.0091 ns | 12.551 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 12.953 ns | 0.0800 ns | 0.0748 ns | 12.988 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 12.892 ns | 0.0337 ns | 0.0315 ns | 12.892 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.663 ns | 0.0263 ns | 0.0246 ns | 13.664 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 37.041 ns | 0.0446 ns | 0.0417 ns | 37.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.482 ns | 0.0459 ns | 0.0429 ns | 36.495 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 37.687 ns | 0.0658 ns | 0.0615 ns | 37.685 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 37.697 ns | 0.0407 ns | 0.0381 ns | 37.687 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.422 ns | 0.0543 ns | 0.0508 ns | 40.444 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.633 ns | 0.0124 ns | 0.0116 ns | 16.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.201 ns | 0.0136 ns | 0.0114 ns | 14.200 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.197 ns | 0.0256 ns | 0.0239 ns | 15.188 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.014 ns | 0.0282 ns | 0.0264 ns | 15.014 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.183 ns | 0.0566 ns | 0.0529 ns | 15.177 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 38.714 ns | 0.0666 ns | 0.0623 ns | 38.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.451 ns | 0.0494 ns | 0.0462 ns | 36.435 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 35.208 ns | 0.0333 ns | 0.0312 ns | 35.218 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.311 ns | 0.1374 ns | 0.1285 ns | 38.322 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.130 ns | 0.0981 ns | 0.0918 ns | 38.153 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.289 ns | 0.0463 ns | 0.0433 ns | 15.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.233 ns | 0.0321 ns | 0.0300 ns | 14.231 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.536 ns | 0.2829 ns | 0.2646 ns | 13.335 ns |  0.89 |    0.02 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.081 ns | 0.0310 ns | 0.0290 ns | 15.079 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.133 ns | 0.0295 ns | 0.0276 ns | 15.133 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 36.535 ns | 0.0319 ns | 0.0299 ns | 36.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 38.400 ns | 0.0380 ns | 0.0337 ns | 38.408 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 33.707 ns | 0.0567 ns | 0.0531 ns | 33.688 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.659 ns | 0.0345 ns | 0.0322 ns | 39.655 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.088 ns | 0.0902 ns | 0.0844 ns | 38.101 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.946 ns | 0.0124 ns | 0.0116 ns | 13.950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.538 ns | 0.0109 ns | 0.0102 ns | 12.537 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.940 ns | 0.2725 ns | 0.3029 ns | 13.066 ns |  0.92 |    0.02 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 15.056 ns | 0.0136 ns | 0.0127 ns | 15.054 ns |  1.08 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.321 ns | 0.0252 ns | 0.0236 ns | 13.311 ns |  0.96 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Long.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Long.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Long.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Long.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Long.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Long.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Long.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
