
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
                                             From_Bool | .NET Core 2.0 | 13.166 ns | 0.0138 ns | 0.0122 ns | 13.167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.417 ns | 0.0084 ns | 0.0079 ns | 10.417 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.759 ns | 0.0697 ns | 0.0652 ns |  9.796 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.629 ns | 0.0310 ns | 0.0290 ns | 13.630 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.026 ns | 0.0834 ns | 0.0780 ns | 12.967 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 18.966 ns | 0.0235 ns | 0.0220 ns | 18.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.462 ns | 0.0103 ns | 0.0086 ns | 17.464 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.856 ns | 0.0310 ns | 0.0290 ns | 17.863 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 26.792 ns | 0.0412 ns | 0.0365 ns | 26.789 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 30.265 ns | 0.1494 ns | 0.1325 ns | 30.307 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.152 ns | 0.0407 ns | 0.0381 ns | 12.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.657 ns | 0.0103 ns | 0.0081 ns | 10.659 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.381 ns | 0.0598 ns | 0.0560 ns | 10.344 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 14.290 ns | 0.1060 ns | 0.0991 ns | 14.317 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.718 ns | 0.0180 ns | 0.0160 ns | 12.718 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.487 ns | 0.0251 ns | 0.0223 ns | 19.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.330 ns | 0.0259 ns | 0.0243 ns | 17.327 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.942 ns | 0.0206 ns | 0.0192 ns | 18.937 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 30.783 ns | 0.0503 ns | 0.0446 ns | 30.785 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.718 ns | 0.0370 ns | 0.0328 ns | 28.718 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.870 ns | 0.0805 ns | 0.0753 ns | 11.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.277 ns | 0.0098 ns | 0.0077 ns | 11.274 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.671 ns | 0.0066 ns | 0.0062 ns |  9.669 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 14.388 ns | 0.0182 ns | 0.0170 ns | 14.384 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 14.445 ns | 0.0301 ns | 0.0282 ns | 14.437 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.885 ns | 0.0164 ns | 0.0154 ns | 14.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.137 ns | 0.0147 ns | 0.0130 ns | 13.134 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.764 ns | 0.2909 ns | 0.2721 ns | 13.942 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 23.044 ns | 0.0409 ns | 0.0363 ns | 23.042 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 24.948 ns | 0.0379 ns | 0.0317 ns | 24.934 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.793 ns | 0.0152 ns | 0.0127 ns | 11.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.416 ns | 0.0124 ns | 0.0116 ns | 10.414 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.774 ns | 0.0567 ns | 0.0530 ns |  9.792 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 13.621 ns | 0.0309 ns | 0.0274 ns | 13.611 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.250 ns | 0.0128 ns | 0.0114 ns | 12.243 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 19.606 ns | 0.1174 ns | 0.1040 ns | 19.643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.100 ns | 0.0191 ns | 0.0179 ns | 17.098 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.581 ns | 0.0760 ns | 0.0711 ns | 17.554 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 31.153 ns | 0.0486 ns | 0.0406 ns | 31.153 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 29.664 ns | 0.0497 ns | 0.0440 ns | 29.658 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.087 ns | 0.0146 ns | 0.0130 ns | 12.088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.715 ns | 0.0377 ns | 0.0334 ns | 10.720 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.145 ns | 0.0171 ns | 0.0151 ns | 10.141 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 14.164 ns | 0.0424 ns | 0.0396 ns | 14.149 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.715 ns | 0.0175 ns | 0.0155 ns | 12.714 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.425 ns | 0.0161 ns | 0.0135 ns | 20.425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.102 ns | 0.0263 ns | 0.0220 ns | 17.096 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.846 ns | 0.1323 ns | 0.1173 ns | 17.781 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.578 ns | 0.0423 ns | 0.0395 ns | 27.576 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 29.839 ns | 0.0286 ns | 0.0268 ns | 29.844 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.837 ns | 0.0162 ns | 0.0152 ns | 11.835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.255 ns | 0.0109 ns | 0.0102 ns | 10.252 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.914 ns | 0.0099 ns | 0.0092 ns |  9.914 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.568 ns | 0.0537 ns | 0.0503 ns | 13.587 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.689 ns | 0.0170 ns | 0.0159 ns | 12.687 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.462 ns | 0.0249 ns | 0.0208 ns | 15.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 18.697 ns | 0.4885 ns | 1.4328 ns | 18.801 ns |  1.23 |    0.08 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.960 ns | 0.1421 ns | 0.1329 ns | 14.005 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.974 ns | 0.0278 ns | 0.0260 ns | 22.972 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 25.871 ns | 0.0322 ns | 0.0286 ns | 25.881 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.889 ns | 0.0833 ns | 0.0779 ns | 11.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.409 ns | 0.0148 ns | 0.0123 ns | 10.409 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.480 ns | 0.0138 ns | 0.0129 ns |  9.476 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.947 ns | 0.0245 ns | 0.0217 ns | 12.944 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.244 ns | 0.0150 ns | 0.0133 ns | 12.245 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.603 ns | 0.0428 ns | 0.0379 ns | 20.592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.668 ns | 0.0669 ns | 0.0559 ns | 17.684 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 19.357 ns | 0.1195 ns | 0.1118 ns | 19.415 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.270 ns | 0.0337 ns | 0.0315 ns | 27.269 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 29.830 ns | 0.1696 ns | 0.1586 ns | 29.760 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.897 ns | 0.0834 ns | 0.0780 ns | 11.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.640 ns | 0.0098 ns | 0.0087 ns | 10.642 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  9.906 ns | 0.0091 ns | 0.0081 ns |  9.904 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.814 ns | 0.0297 ns | 0.0278 ns | 13.810 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.690 ns | 0.0146 ns | 0.0130 ns | 12.690 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.712 ns | 0.0278 ns | 0.0260 ns | 19.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.611 ns | 0.0304 ns | 0.0284 ns | 17.600 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.551 ns | 0.0993 ns | 0.0929 ns | 17.579 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 30.772 ns | 0.0348 ns | 0.0309 ns | 30.782 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 28.385 ns | 0.0414 ns | 0.0367 ns | 28.399 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.353 ns | 0.0454 ns | 0.0425 ns | 12.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.239 ns | 0.0126 ns | 0.0118 ns | 10.238 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.455 ns | 0.0100 ns | 0.0083 ns |  9.456 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.445 ns | 0.0160 ns | 0.0142 ns | 13.442 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.535 ns | 0.0473 ns | 0.0420 ns | 13.541 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.053 ns | 0.0197 ns | 0.0185 ns | 16.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.939 ns | 0.0163 ns | 0.0136 ns | 12.937 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.825 ns | 0.0919 ns | 0.0860 ns | 14.871 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 23.164 ns | 0.0673 ns | 0.0597 ns | 23.169 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 25.660 ns | 0.0321 ns | 0.0301 ns | 25.656 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.802 ns | 0.0701 ns | 0.0656 ns | 12.768 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.686 ns | 0.0102 ns | 0.0095 ns | 11.684 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 10.114 ns | 0.0080 ns | 0.0067 ns | 10.115 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.354 ns | 0.0145 ns | 0.0136 ns | 14.358 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.932 ns | 0.0115 ns | 0.0102 ns | 12.933 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.292 ns | 0.0082 ns | 0.0069 ns | 12.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.379 ns | 0.0187 ns | 0.0175 ns | 11.372 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.341 ns | 0.0143 ns | 0.0127 ns | 10.338 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 15.403 ns | 0.0730 ns | 0.0647 ns | 15.423 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.853 ns | 0.0907 ns | 0.0849 ns | 13.819 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.293 ns | 0.0151 ns | 0.0141 ns | 12.295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.358 ns | 0.0212 ns | 0.0199 ns | 11.357 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.354 ns | 0.0088 ns | 0.0073 ns | 10.356 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.521 ns | 0.0204 ns | 0.0181 ns | 14.517 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.255 ns | 0.0123 ns | 0.0109 ns | 13.254 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.910 ns | 0.0105 ns | 0.0082 ns | 14.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.961 ns | 0.0420 ns | 0.0393 ns | 12.938 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.616 ns | 0.0206 ns | 0.0193 ns | 13.611 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 26.773 ns | 0.1670 ns | 0.1562 ns | 26.688 ns |  1.80 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 25.013 ns | 0.0320 ns | 0.0299 ns | 25.015 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.239 ns | 0.0241 ns | 0.0214 ns | 23.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.400 ns | 0.0201 ns | 0.0188 ns | 21.402 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.071 ns | 0.0832 ns | 0.0738 ns | 14.081 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.536 ns | 0.0328 ns | 0.0256 ns | 24.542 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.436 ns | 0.0330 ns | 0.0309 ns | 24.438 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 39.127 ns | 0.1750 ns | 0.1637 ns | 39.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 28.715 ns | 0.0307 ns | 0.0273 ns | 28.708 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.495 ns | 0.4726 ns | 0.4421 ns | 22.662 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 35.580 ns | 0.0366 ns | 0.0342 ns | 35.572 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.468 ns | 0.0546 ns | 0.0484 ns | 36.479 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 24.797 ns | 0.0270 ns | 0.0226 ns | 24.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 25.289 ns | 0.0294 ns | 0.0275 ns | 25.286 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.708 ns | 0.0633 ns | 0.0528 ns | 18.716 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.671 ns | 0.0212 ns | 0.0198 ns | 26.669 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.137 ns | 0.0296 ns | 0.0247 ns | 26.129 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 41.810 ns | 0.7092 ns | 0.6634 ns | 42.047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 28.661 ns | 0.0380 ns | 0.0337 ns | 28.660 ns |  0.68 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.076 ns | 0.0343 ns | 0.0321 ns | 23.074 ns |  0.55 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 37.684 ns | 0.0664 ns | 0.0589 ns | 37.675 ns |  0.90 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 37.108 ns | 0.1135 ns | 0.1062 ns | 37.107 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.595 ns | 0.0162 ns | 0.0126 ns | 12.597 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 14.259 ns | 0.0395 ns | 0.0370 ns | 14.258 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  9.937 ns | 0.0110 ns | 0.0098 ns |  9.935 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.961 ns | 0.0159 ns | 0.0141 ns | 14.964 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.881 ns | 0.0229 ns | 0.0214 ns | 14.884 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.799 ns | 0.0159 ns | 0.0148 ns | 14.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.940 ns | 0.0108 ns | 0.0096 ns | 12.937 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.420 ns | 0.0142 ns | 0.0133 ns | 13.419 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 23.024 ns | 0.0377 ns | 0.0334 ns | 23.018 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 24.652 ns | 0.0245 ns | 0.0217 ns | 24.651 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.972 ns | 0.0238 ns | 0.0211 ns | 13.976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.327 ns | 0.0116 ns | 0.0103 ns | 12.325 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 11.775 ns | 0.0120 ns | 0.0107 ns | 11.775 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 16.041 ns | 0.1025 ns | 0.0959 ns | 16.012 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.508 ns | 0.0254 ns | 0.0212 ns | 14.500 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.059 ns | 0.0158 ns | 0.0140 ns | 21.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.661 ns | 0.0204 ns | 0.0181 ns | 18.664 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.921 ns | 0.0999 ns | 0.0935 ns | 20.895 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 30.936 ns | 0.0773 ns | 0.0723 ns | 30.902 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 30.974 ns | 0.0489 ns | 0.0457 ns | 30.980 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.674 ns | 0.0794 ns | 0.0742 ns | 14.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 16.304 ns | 0.0277 ns | 0.0231 ns | 16.299 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.676 ns | 0.0165 ns | 0.0154 ns | 12.673 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.724 ns | 0.0253 ns | 0.0237 ns | 16.720 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.215 ns | 0.0870 ns | 0.0813 ns | 15.174 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.910 ns | 0.0224 ns | 0.0209 ns | 21.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.220 ns | 0.1188 ns | 0.1111 ns | 19.157 ns |  0.88 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.695 ns | 0.0272 ns | 0.0242 ns | 20.693 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 28.469 ns | 0.0362 ns | 0.0303 ns | 28.467 ns |  1.30 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 31.631 ns | 0.0420 ns | 0.0393 ns | 31.628 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.388 ns | 0.0114 ns | 0.0101 ns | 12.386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.438 ns | 0.0153 ns | 0.0143 ns | 12.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.914 ns | 0.0172 ns | 0.0161 ns |  9.913 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.198 ns | 0.0140 ns | 0.0131 ns | 14.197 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.452 ns | 0.0234 ns | 0.0207 ns | 13.450 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.474 ns | 0.0233 ns | 0.0218 ns | 15.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.189 ns | 0.0758 ns | 0.0709 ns | 14.183 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.499 ns | 0.1069 ns | 0.1000 ns | 13.482 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.872 ns | 0.0396 ns | 0.0370 ns | 22.861 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 24.538 ns | 0.0274 ns | 0.0256 ns | 24.535 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.803 ns | 0.0104 ns | 0.0097 ns | 11.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.408 ns | 0.0165 ns | 0.0147 ns | 10.413 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.474 ns | 0.0200 ns | 0.0177 ns |  9.473 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.722 ns | 0.0228 ns | 0.0202 ns | 13.723 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.555 ns | 0.0172 ns | 0.0161 ns | 13.553 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.647 ns | 0.1337 ns | 0.1251 ns | 19.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.286 ns | 0.0204 ns | 0.0181 ns | 17.284 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.911 ns | 0.0377 ns | 0.0353 ns | 17.919 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 27.693 ns | 0.0506 ns | 0.0474 ns | 27.689 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 28.840 ns | 0.1881 ns | 0.1760 ns | 28.755 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.824 ns | 0.0152 ns | 0.0142 ns | 12.823 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.757 ns | 0.0143 ns | 0.0127 ns | 10.759 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  9.910 ns | 0.0096 ns | 0.0085 ns |  9.908 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 15.007 ns | 0.0371 ns | 0.0347 ns | 14.991 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.222 ns | 0.0201 ns | 0.0178 ns | 13.217 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.591 ns | 0.0818 ns | 0.0765 ns | 19.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.281 ns | 0.0171 ns | 0.0160 ns | 17.283 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.238 ns | 0.2107 ns | 0.1971 ns | 18.288 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 31.005 ns | 0.0405 ns | 0.0379 ns | 31.006 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 30.460 ns | 0.1057 ns | 0.0937 ns | 30.467 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.040 ns | 0.0164 ns | 0.0137 ns | 12.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.307 ns | 0.0362 ns | 0.0321 ns | 10.316 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.940 ns | 0.0616 ns | 0.0576 ns |  9.969 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 13.594 ns | 0.0533 ns | 0.0472 ns | 13.602 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.692 ns | 0.0178 ns | 0.0158 ns | 12.697 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.811 ns | 0.0317 ns | 0.0297 ns | 14.791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.302 ns | 0.0206 ns | 0.0183 ns | 13.301 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.332 ns | 0.0168 ns | 0.0132 ns | 13.334 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.862 ns | 0.0259 ns | 0.0242 ns | 22.865 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 25.551 ns | 0.0296 ns | 0.0277 ns | 25.556 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.853 ns | 0.0160 ns | 0.0150 ns | 11.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.414 ns | 0.0671 ns | 0.0627 ns | 10.385 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.233 ns | 0.0143 ns | 0.0126 ns |  9.232 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.997 ns | 0.0246 ns | 0.0230 ns | 13.991 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 14.124 ns | 0.0803 ns | 0.0712 ns | 14.143 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.684 ns | 0.0591 ns | 0.0553 ns | 19.690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 17.289 ns | 0.0266 ns | 0.0236 ns | 17.289 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.549 ns | 0.0156 ns | 0.0146 ns | 17.547 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 31.006 ns | 0.0453 ns | 0.0423 ns | 31.000 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 30.175 ns | 0.0476 ns | 0.0445 ns | 30.157 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.063 ns | 0.0163 ns | 0.0153 ns | 12.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.161 ns | 0.0157 ns | 0.0139 ns | 11.160 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  9.930 ns | 0.0139 ns | 0.0123 ns |  9.929 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.325 ns | 0.0236 ns | 0.0184 ns | 14.326 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.231 ns | 0.0177 ns | 0.0165 ns | 13.230 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.894 ns | 0.0296 ns | 0.0277 ns | 19.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.310 ns | 0.0308 ns | 0.0273 ns | 17.302 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.858 ns | 0.0175 ns | 0.0163 ns | 18.858 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.716 ns | 0.0350 ns | 0.0328 ns | 27.716 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.063 ns | 0.0256 ns | 0.0239 ns | 29.053 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 12.076 ns | 0.0397 ns | 0.0372 ns | 12.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.366 ns | 0.0679 ns | 0.0635 ns | 10.377 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.465 ns | 0.0112 ns | 0.0105 ns |  9.462 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.207 ns | 0.0325 ns | 0.0304 ns | 14.207 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.689 ns | 0.0102 ns | 0.0091 ns | 12.690 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.852 ns | 0.0134 ns | 0.0119 ns | 14.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.964 ns | 0.0747 ns | 0.0698 ns | 12.932 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.107 ns | 0.0648 ns | 0.0606 ns | 15.125 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.935 ns | 0.0718 ns | 0.0671 ns | 22.906 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 25.538 ns | 0.0214 ns | 0.0179 ns | 25.539 ns |  1.72 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 14.032 ns | 0.0144 ns | 0.0135 ns | 14.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.516 ns | 0.0121 ns | 0.0113 ns | 11.516 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.712 ns | 0.0112 ns | 0.0105 ns |  9.710 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.986 ns | 0.0687 ns | 0.0643 ns | 13.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.036 ns | 0.0243 ns | 0.0227 ns | 13.033 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.158 ns | 0.0250 ns | 0.0222 ns | 20.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.845 ns | 0.1210 ns | 0.1132 ns | 17.776 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.346 ns | 0.1644 ns | 0.1537 ns | 18.225 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 30.002 ns | 0.0444 ns | 0.0393 ns | 29.991 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 31.408 ns | 0.0447 ns | 0.0418 ns | 31.404 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.076 ns | 0.0361 ns | 0.0338 ns | 14.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 16.190 ns | 0.0352 ns | 0.0329 ns | 16.193 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.287 ns | 0.0135 ns | 0.0113 ns | 11.291 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 15.277 ns | 0.0156 ns | 0.0139 ns | 15.279 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.861 ns | 0.0698 ns | 0.0619 ns | 14.892 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.070 ns | 0.0231 ns | 0.0205 ns | 20.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.677 ns | 0.0188 ns | 0.0167 ns | 18.677 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.135 ns | 0.0185 ns | 0.0164 ns | 19.135 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.829 ns | 0.0318 ns | 0.0298 ns | 27.822 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.496 ns | 0.0438 ns | 0.0410 ns | 29.489 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.280 ns | 0.0113 ns | 0.0094 ns | 12.283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.460 ns | 0.0176 ns | 0.0164 ns | 11.464 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.682 ns | 0.0112 ns | 0.0105 ns |  9.682 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.149 ns | 0.0386 ns | 0.0342 ns | 14.145 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.311 ns | 0.0154 ns | 0.0144 ns | 13.305 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.790 ns | 0.0328 ns | 0.0291 ns | 14.785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.553 ns | 0.0159 ns | 0.0149 ns | 14.556 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.511 ns | 0.0689 ns | 0.0644 ns | 13.488 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 23.084 ns | 0.0280 ns | 0.0262 ns | 23.089 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.018 ns | 0.0294 ns | 0.0261 ns | 24.026 ns |  1.62 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.849 ns | 0.0202 ns | 0.0179 ns | 11.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.407 ns | 0.0149 ns | 0.0124 ns | 10.409 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.691 ns | 0.0137 ns | 0.0114 ns |  9.693 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.707 ns | 0.0300 ns | 0.0266 ns | 13.701 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.965 ns | 0.0197 ns | 0.0184 ns | 12.965 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 19.449 ns | 0.0206 ns | 0.0193 ns | 19.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.658 ns | 0.0170 ns | 0.0159 ns | 17.658 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 19.526 ns | 0.4140 ns | 0.6803 ns | 19.758 ns |  0.99 |    0.05 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.641 ns | 0.0828 ns | 0.0734 ns | 27.621 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 30.164 ns | 0.0433 ns | 0.0384 ns | 30.174 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.718 ns | 0.0126 ns | 0.0112 ns | 12.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.624 ns | 0.0097 ns | 0.0091 ns | 10.626 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.401 ns | 0.0673 ns | 0.0630 ns | 10.353 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.086 ns | 0.0249 ns | 0.0208 ns | 14.085 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.139 ns | 0.0089 ns | 0.0079 ns | 13.140 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.055 ns | 0.0703 ns | 0.0657 ns | 20.034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.947 ns | 0.0660 ns | 0.0617 ns | 17.969 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.373 ns | 0.0203 ns | 0.0190 ns | 17.372 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.746 ns | 0.0230 ns | 0.0216 ns | 27.749 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 29.259 ns | 0.1925 ns | 0.1801 ns | 29.144 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.171 ns | 0.0246 ns | 0.0218 ns | 12.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 11.280 ns | 0.0378 ns | 0.0353 ns | 11.266 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.472 ns | 0.0193 ns | 0.0161 ns |  9.468 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 14.104 ns | 0.0495 ns | 0.0463 ns | 14.097 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.211 ns | 0.0098 ns | 0.0087 ns | 13.211 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.803 ns | 0.0188 ns | 0.0157 ns | 14.807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.927 ns | 0.0148 ns | 0.0132 ns | 12.928 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.130 ns | 0.0095 ns | 0.0084 ns | 13.131 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 23.009 ns | 0.0770 ns | 0.0721 ns | 23.031 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 24.589 ns | 0.0290 ns | 0.0271 ns | 24.584 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.496 ns | 0.0691 ns | 0.0613 ns | 14.513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.270 ns | 0.0135 ns | 0.0127 ns | 12.267 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.312 ns | 0.0794 ns | 0.0742 ns | 12.347 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.285 ns | 0.0295 ns | 0.0261 ns | 15.286 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.361 ns | 0.0242 ns | 0.0202 ns | 15.362 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.125 ns | 0.0448 ns | 0.0397 ns | 21.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.736 ns | 0.0551 ns | 0.0488 ns | 18.718 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.994 ns | 0.0527 ns | 0.0493 ns | 20.983 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 28.861 ns | 0.0650 ns | 0.0608 ns | 28.839 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 31.503 ns | 0.0454 ns | 0.0379 ns | 31.504 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.882 ns | 0.0135 ns | 0.0126 ns | 13.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.372 ns | 0.0411 ns | 0.0364 ns | 12.383 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 11.985 ns | 0.0155 ns | 0.0138 ns | 11.982 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 16.046 ns | 0.0353 ns | 0.0313 ns | 16.042 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.583 ns | 0.0190 ns | 0.0168 ns | 14.582 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.621 ns | 0.0183 ns | 0.0171 ns | 20.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.165 ns | 0.0248 ns | 0.0194 ns | 19.160 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.105 ns | 0.1245 ns | 0.1165 ns | 21.167 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 28.857 ns | 0.0501 ns | 0.0469 ns | 28.856 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.367 ns | 0.0434 ns | 0.0384 ns | 30.371 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.064 ns | 0.0185 ns | 0.0173 ns | 12.055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.474 ns | 0.0342 ns | 0.0320 ns | 10.473 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.684 ns | 0.0115 ns | 0.0108 ns |  9.683 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 14.363 ns | 0.0634 ns | 0.0593 ns | 14.356 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.646 ns | 0.0135 ns | 0.0126 ns | 13.646 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.795 ns | 0.0102 ns | 0.0085 ns | 14.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.302 ns | 0.0129 ns | 0.0108 ns | 13.303 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.719 ns | 0.0113 ns | 0.0100 ns | 14.721 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.790 ns | 0.0475 ns | 0.0421 ns | 22.790 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.575 ns | 0.0791 ns | 0.0740 ns | 24.547 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.418 ns | 0.4776 ns | 0.4467 ns | 59.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 56.140 ns | 0.3686 ns | 0.3448 ns | 56.348 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 23.424 ns | 0.0764 ns | 0.0715 ns | 23.423 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.982 ns | 0.2697 ns | 0.2523 ns | 59.877 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 62.173 ns | 0.0837 ns | 0.0783 ns | 62.190 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.626 ns | 0.0524 ns | 0.0464 ns | 63.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 58.411 ns | 0.1566 ns | 0.1465 ns | 58.365 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 28.480 ns | 0.0641 ns | 0.0568 ns | 28.493 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 71.443 ns | 0.1007 ns | 0.0942 ns | 71.451 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 74.368 ns | 0.0826 ns | 0.0689 ns | 74.383 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.065 ns | 0.0128 ns | 0.0100 ns | 14.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 17.899 ns | 0.0283 ns | 0.0265 ns | 17.892 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.758 ns | 0.1764 ns | 0.1650 ns | 13.676 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.760 ns | 0.0177 ns | 0.0166 ns | 14.759 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.639 ns | 0.0215 ns | 0.0191 ns | 15.640 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.880 ns | 0.0170 ns | 0.0159 ns | 14.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.386 ns | 0.0080 ns | 0.0075 ns | 13.387 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.350 ns | 0.0452 ns | 0.0400 ns | 13.333 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 23.066 ns | 0.0371 ns | 0.0347 ns | 23.068 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 25.951 ns | 0.0243 ns | 0.0215 ns | 25.949 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.068 ns | 0.0156 ns | 0.0138 ns | 14.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.095 ns | 0.0438 ns | 0.0388 ns | 18.099 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.446 ns | 0.0161 ns | 0.0142 ns | 13.442 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.759 ns | 0.0146 ns | 0.0136 ns | 14.759 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.518 ns | 0.0324 ns | 0.0287 ns | 15.517 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.637 ns | 0.0134 ns | 0.0125 ns | 12.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.383 ns | 0.0210 ns | 0.0197 ns | 10.378 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.476 ns | 0.0106 ns | 0.0094 ns |  9.472 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.970 ns | 0.0272 ns | 0.0212 ns | 12.966 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.357 ns | 0.0418 ns | 0.0391 ns | 12.362 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 20.706 ns | 0.0193 ns | 0.0181 ns | 20.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.720 ns | 0.0781 ns | 0.0731 ns | 17.742 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.841 ns | 0.0920 ns | 0.0861 ns | 18.881 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.760 ns | 0.0774 ns | 0.0724 ns | 27.736 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 29.409 ns | 0.0314 ns | 0.0263 ns | 29.407 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.808 ns | 0.0156 ns | 0.0146 ns | 11.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.614 ns | 0.0137 ns | 0.0129 ns | 10.614 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.357 ns | 0.0109 ns | 0.0102 ns | 10.357 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.443 ns | 0.0150 ns | 0.0140 ns | 13.444 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.720 ns | 0.0092 ns | 0.0086 ns | 12.719 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.905 ns | 0.0126 ns | 0.0111 ns | 19.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.073 ns | 0.0245 ns | 0.0204 ns | 17.071 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.717 ns | 0.0289 ns | 0.0270 ns | 18.716 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.569 ns | 0.0825 ns | 0.0772 ns | 27.541 ns |  1.39 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 30.672 ns | 0.0327 ns | 0.0306 ns | 30.671 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.827 ns | 0.0134 ns | 0.0119 ns | 11.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.231 ns | 0.0102 ns | 0.0091 ns | 10.232 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  9.460 ns | 0.0164 ns | 0.0128 ns |  9.456 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.438 ns | 0.0126 ns | 0.0112 ns | 13.435 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.968 ns | 0.0117 ns | 0.0104 ns | 12.967 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.798 ns | 0.0098 ns | 0.0091 ns | 14.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.909 ns | 0.0155 ns | 0.0137 ns | 12.911 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.576 ns | 0.0124 ns | 0.0104 ns | 13.575 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 26.446 ns | 0.0362 ns | 0.0339 ns | 26.445 ns |  1.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.589 ns | 0.1272 ns | 0.1190 ns | 24.517 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.860 ns | 0.0134 ns | 0.0119 ns | 12.857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.486 ns | 0.0684 ns | 0.0640 ns | 10.510 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.922 ns | 0.0090 ns | 0.0084 ns |  9.924 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.240 ns | 0.0150 ns | 0.0133 ns | 12.237 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.258 ns | 0.0138 ns | 0.0129 ns | 12.257 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 24.538 ns | 0.0227 ns | 0.0212 ns | 24.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 25.206 ns | 0.0171 ns | 0.0160 ns | 25.210 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 29.500 ns | 0.1342 ns | 0.1190 ns | 29.463 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 35.491 ns | 0.0448 ns | 0.0419 ns | 35.485 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 38.364 ns | 0.0439 ns | 0.0389 ns | 38.365 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.265 ns | 0.0124 ns | 0.0110 ns | 11.264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.085 ns | 0.0092 ns | 0.0086 ns | 10.084 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  6.612 ns | 0.0202 ns | 0.0179 ns |  6.613 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.790 ns | 0.0311 ns | 0.0291 ns | 11.781 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.783 ns | 0.0067 ns | 0.0053 ns | 11.783 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.986 ns | 0.0255 ns | 0.0213 ns | 23.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.606 ns | 0.0281 ns | 0.0263 ns | 25.605 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 30.473 ns | 0.1646 ns | 0.1459 ns | 30.508 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 35.427 ns | 0.0653 ns | 0.0611 ns | 35.420 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 37.082 ns | 0.0901 ns | 0.0842 ns | 37.072 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.291 ns | 0.0335 ns | 0.0313 ns | 11.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.070 ns | 0.0124 ns | 0.0103 ns | 10.073 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.603 ns | 0.0074 ns | 0.0066 ns |  6.605 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.867 ns | 0.0394 ns | 0.0369 ns | 12.875 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 11.779 ns | 0.0120 ns | 0.0107 ns | 11.776 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.199 ns | 0.0189 ns | 0.0177 ns | 15.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.039 ns | 0.0559 ns | 0.0523 ns | 13.063 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.353 ns | 0.0134 ns | 0.0118 ns | 13.355 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.846 ns | 0.0329 ns | 0.0292 ns | 22.844 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 25.548 ns | 0.0306 ns | 0.0271 ns | 25.553 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.301 ns | 0.0136 ns | 0.0127 ns | 12.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.401 ns | 0.0148 ns | 0.0131 ns | 10.400 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.662 ns | 0.1911 ns | 0.1787 ns |  9.794 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.574 ns | 0.0381 ns | 0.0338 ns | 14.569 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 13.985 ns | 0.0178 ns | 0.0166 ns | 13.986 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.499 ns | 0.0195 ns | 0.0183 ns | 19.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 17.525 ns | 0.0274 ns | 0.0243 ns | 17.521 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.503 ns | 0.1552 ns | 0.1451 ns | 17.563 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 30.951 ns | 0.0625 ns | 0.0554 ns | 30.946 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.196 ns | 0.0250 ns | 0.0195 ns | 30.195 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.706 ns | 0.0216 ns | 0.0181 ns | 12.704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.592 ns | 0.0146 ns | 0.0137 ns | 11.590 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.495 ns | 0.2524 ns | 0.4354 ns | 11.664 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.864 ns | 0.0290 ns | 0.0271 ns | 15.851 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 15.363 ns | 0.0511 ns | 0.0478 ns | 15.371 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.074 ns | 0.0376 ns | 0.0352 ns | 20.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.681 ns | 0.1029 ns | 0.0962 ns | 17.732 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.598 ns | 0.3636 ns | 0.3223 ns | 18.719 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.299 ns | 0.0417 ns | 0.0370 ns | 27.294 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 29.074 ns | 0.0413 ns | 0.0386 ns | 29.069 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.589 ns | 0.0162 ns | 0.0144 ns | 12.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.351 ns | 0.0158 ns | 0.0132 ns | 11.347 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.899 ns | 0.0141 ns | 0.0125 ns |  9.896 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.816 ns | 0.0296 ns | 0.0262 ns | 14.816 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.147 ns | 0.0166 ns | 0.0155 ns | 14.149 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 20.052 ns | 0.0209 ns | 0.0185 ns | 20.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.917 ns | 0.0162 ns | 0.0144 ns | 12.917 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.464 ns | 0.0185 ns | 0.0164 ns | 14.459 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.797 ns | 0.0318 ns | 0.0248 ns | 22.801 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 24.484 ns | 0.0161 ns | 0.0150 ns | 24.486 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.813 ns | 0.0285 ns | 0.0253 ns | 14.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.123 ns | 0.0268 ns | 0.0251 ns | 14.125 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.629 ns | 0.0222 ns | 0.0196 ns | 13.628 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.910 ns | 0.1311 ns | 0.1226 ns | 22.900 ns |  1.55 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 25.337 ns | 0.0278 ns | 0.0247 ns | 25.333 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.718 ns | 0.0078 ns | 0.0073 ns | 12.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.770 ns | 0.0098 ns | 0.0087 ns | 11.772 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.603 ns | 0.0180 ns | 0.0168 ns | 12.606 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.920 ns | 0.0275 ns | 0.0244 ns | 12.919 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.062 ns | 0.0220 ns | 0.0206 ns | 13.061 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.912 ns | 0.0391 ns | 0.0366 ns | 14.911 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.239 ns | 0.0755 ns | 0.0706 ns | 14.280 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.559 ns | 0.0263 ns | 0.0219 ns | 13.557 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.867 ns | 0.0354 ns | 0.0331 ns | 22.855 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 25.821 ns | 0.0370 ns | 0.0309 ns | 25.821 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 18.619 ns | 0.0247 ns | 0.0231 ns | 18.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.790 ns | 0.0154 ns | 0.0144 ns | 14.792 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 16.240 ns | 0.0914 ns | 0.0855 ns | 16.285 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 25.927 ns | 0.0313 ns | 0.0293 ns | 25.930 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 27.108 ns | 0.0621 ns | 0.0551 ns | 27.103 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.962 ns | 0.0179 ns | 0.0140 ns | 18.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 18.493 ns | 0.0222 ns | 0.0208 ns | 18.493 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.842 ns | 0.0719 ns | 0.0673 ns | 16.870 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.086 ns | 0.0565 ns | 0.0501 ns | 26.078 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.098 ns | 0.0321 ns | 0.0300 ns | 29.100 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.571 ns | 0.0182 ns | 0.0170 ns | 14.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.564 ns | 0.0135 ns | 0.0119 ns | 13.567 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.951 ns | 0.0304 ns | 0.0284 ns | 12.956 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 22.958 ns | 0.0257 ns | 0.0214 ns | 22.952 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.488 ns | 0.0507 ns | 0.0449 ns | 24.484 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.496 ns | 0.0206 ns | 0.0193 ns | 15.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.912 ns | 0.0118 ns | 0.0111 ns | 12.912 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.556 ns | 0.0226 ns | 0.0211 ns | 13.553 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.979 ns | 0.0501 ns | 0.0469 ns | 22.969 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.626 ns | 0.0336 ns | 0.0314 ns | 24.631 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.925 ns | 0.0334 ns | 0.0313 ns | 13.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.687 ns | 0.0139 ns | 0.0116 ns | 12.688 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 13.490 ns | 0.2951 ns | 0.3030 ns | 13.251 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.327 ns | 0.0251 ns | 0.0235 ns | 14.319 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.273 ns | 0.0160 ns | 0.0150 ns | 14.273 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.675 ns | 0.0594 ns | 0.0526 ns | 16.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.755 ns | 0.0121 ns | 0.0094 ns | 14.756 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 16.160 ns | 0.3493 ns | 0.4158 ns | 16.376 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.465 ns | 0.0260 ns | 0.0243 ns | 24.464 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 27.194 ns | 0.0301 ns | 0.0266 ns | 27.196 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.873 ns | 0.0152 ns | 0.0142 ns | 13.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.760 ns | 0.0546 ns | 0.0511 ns | 12.774 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.803 ns | 0.1745 ns | 0.1632 ns | 12.940 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 18.300 ns | 0.4481 ns | 1.3212 ns | 18.287 ns |  1.31 |    0.12 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.315 ns | 0.0175 ns | 0.0164 ns | 14.315 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.813 ns | 0.0120 ns | 0.0112 ns | 14.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.918 ns | 0.0121 ns | 0.0113 ns | 12.921 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.518 ns | 0.0587 ns | 0.0549 ns | 13.506 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.901 ns | 0.0409 ns | 0.0362 ns | 22.896 ns |  1.55 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 25.963 ns | 0.0828 ns | 0.0774 ns | 25.967 ns |  1.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.138 ns | 0.0519 ns | 0.0486 ns | 20.154 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 15.974 ns | 0.0403 ns | 0.0377 ns | 15.972 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.925 ns | 0.1239 ns | 0.1159 ns | 13.939 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 20.504 ns | 0.0700 ns | 0.0655 ns | 20.473 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.211 ns | 0.0328 ns | 0.0291 ns | 19.219 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.758 ns | 0.0206 ns | 0.0182 ns | 18.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.104 ns | 0.0289 ns | 0.0270 ns | 17.099 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.708 ns | 0.0264 ns | 0.0247 ns | 18.707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 26.971 ns | 0.0377 ns | 0.0353 ns | 26.967 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 29.493 ns | 0.0573 ns | 0.0508 ns | 29.500 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.183 ns | 0.0414 ns | 0.0345 ns | 20.175 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.447 ns | 0.0295 ns | 0.0276 ns | 17.446 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.835 ns | 0.3186 ns | 0.3669 ns | 15.024 ns |  0.73 |    0.02 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 26.809 ns | 0.0588 ns | 0.0550 ns | 26.814 ns |  1.33 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.958 ns | 0.0182 ns | 0.0161 ns | 24.962 ns |  1.24 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.280 ns | 0.0255 ns | 0.0213 ns | 19.282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.519 ns | 0.0172 ns | 0.0153 ns | 17.522 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.545 ns | 0.0269 ns | 0.0224 ns | 17.547 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.860 ns | 0.0246 ns | 0.0230 ns | 26.854 ns |  1.39 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 29.529 ns | 0.0583 ns | 0.0517 ns | 29.522 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.903 ns | 0.0144 ns | 0.0120 ns | 13.899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.478 ns | 0.0563 ns | 0.0526 ns | 12.493 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.959 ns | 0.0079 ns | 0.0074 ns |  9.956 ns |  0.72 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 21.748 ns | 0.0424 ns | 0.0376 ns | 21.752 ns |  1.56 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.654 ns | 0.0377 ns | 0.0353 ns | 18.646 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.935 ns | 0.0637 ns | 0.0595 ns | 14.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.515 ns | 0.0224 ns | 0.0210 ns | 13.512 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.574 ns | 0.0288 ns | 0.0255 ns | 13.566 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.824 ns | 0.0614 ns | 0.0545 ns | 22.823 ns |  1.53 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 25.520 ns | 0.0330 ns | 0.0308 ns | 25.521 ns |  1.71 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.186 ns | 0.0160 ns | 0.0150 ns | 13.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.091 ns | 0.0143 ns | 0.0134 ns | 10.092 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.840 ns | 0.2234 ns | 0.2904 ns | 10.032 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.622 ns | 0.0188 ns | 0.0167 ns | 13.624 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.318 ns | 0.0326 ns | 0.0305 ns | 12.328 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 19.440 ns | 0.0178 ns | 0.0158 ns | 19.443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.536 ns | 0.0239 ns | 0.0223 ns | 15.535 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 19.721 ns | 0.1218 ns | 0.1139 ns | 19.787 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 28.163 ns | 0.0324 ns | 0.0270 ns | 28.157 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 27.039 ns | 0.0450 ns | 0.0421 ns | 27.025 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.212 ns | 0.0859 ns | 0.0804 ns | 13.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.818 ns | 0.0132 ns | 0.0117 ns | 11.819 ns |  0.90 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 10.475 ns | 0.2257 ns | 0.2112 ns | 10.411 ns |  0.79 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.946 ns | 0.0173 ns | 0.0154 ns | 13.942 ns |  1.06 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.672 ns | 0.0486 ns | 0.0455 ns | 13.682 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.559 ns | 0.0211 ns | 0.0197 ns | 16.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.761 ns | 0.0181 ns | 0.0160 ns | 14.763 ns |  0.89 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.342 ns | 0.2988 ns | 0.2795 ns | 15.178 ns |  0.93 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.630 ns | 0.0839 ns | 0.0700 ns | 24.651 ns |  1.49 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 27.177 ns | 0.0368 ns | 0.0345 ns | 27.170 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.150 ns | 0.0155 ns | 0.0138 ns | 13.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.403 ns | 0.0120 ns | 0.0112 ns | 11.403 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.898 ns | 0.0083 ns | 0.0077 ns |  9.898 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.966 ns | 0.0155 ns | 0.0145 ns | 12.967 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.200 ns | 0.0138 ns | 0.0130 ns | 12.201 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.805 ns | 0.0144 ns | 0.0128 ns | 14.803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.515 ns | 0.0130 ns | 0.0122 ns | 13.518 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.857 ns | 0.0184 ns | 0.0163 ns | 15.858 ns |  1.07 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.868 ns | 0.0179 ns | 0.0168 ns | 22.870 ns |  1.54 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.523 ns | 0.0330 ns | 0.0309 ns | 24.515 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.160 ns | 0.0065 ns | 0.0061 ns | 13.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.482 ns | 0.0225 ns | 0.0210 ns | 10.478 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.214 ns | 0.0131 ns | 0.0109 ns |  9.213 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 14.959 ns | 0.0255 ns | 0.0239 ns | 14.956 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.974 ns | 0.0131 ns | 0.0123 ns | 12.973 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.729 ns | 0.2895 ns | 0.2708 ns | 50.610 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 42.620 ns | 0.0631 ns | 0.0560 ns | 42.611 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 45.813 ns | 0.0899 ns | 0.0841 ns | 45.775 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 51.704 ns | 0.0719 ns | 0.0638 ns | 51.721 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 52.734 ns | 0.0986 ns | 0.0922 ns | 52.719 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.399 ns | 0.0161 ns | 0.0135 ns | 13.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.867 ns | 0.0142 ns | 0.0126 ns | 12.864 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.894 ns | 0.0298 ns | 0.0279 ns |  9.882 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 14.416 ns | 0.0610 ns | 0.0571 ns | 14.428 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.284 ns | 0.0323 ns | 0.0286 ns | 13.282 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.112 ns | 0.0694 ns | 0.0615 ns | 45.115 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.043 ns | 0.2207 ns | 0.2064 ns | 43.131 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 39.823 ns | 0.0522 ns | 0.0407 ns | 39.833 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.737 ns | 0.1130 ns | 0.1057 ns | 51.698 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 53.251 ns | 0.1343 ns | 0.1190 ns | 53.278 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.367 ns | 0.0104 ns | 0.0081 ns | 13.367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.235 ns | 0.0376 ns | 0.0351 ns | 10.224 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.447 ns | 0.0556 ns | 0.0520 ns |  9.421 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 14.063 ns | 0.0245 ns | 0.0217 ns | 14.062 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.851 ns | 0.0180 ns | 0.0168 ns | 12.848 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.796 ns | 0.0107 ns | 0.0100 ns | 14.795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.920 ns | 0.0073 ns | 0.0064 ns | 12.921 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.578 ns | 0.0142 ns | 0.0133 ns | 13.578 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.549 ns | 0.0198 ns | 0.0175 ns | 22.547 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.530 ns | 0.0230 ns | 0.0192 ns | 25.535 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.832 ns | 0.0128 ns | 0.0120 ns | 13.830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.734 ns | 0.0118 ns | 0.0111 ns | 12.733 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.957 ns | 0.2373 ns | 0.2220 ns | 13.042 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.333 ns | 0.0332 ns | 0.0311 ns | 14.327 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.420 ns | 0.0894 ns | 0.0837 ns | 14.464 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.742 ns | 0.0306 ns | 0.0271 ns | 17.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.240 ns | 0.0519 ns | 0.0433 ns | 15.222 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 17.510 ns | 0.3735 ns | 0.8656 ns | 17.898 ns |  0.91 |    0.05 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.579 ns | 0.0334 ns | 0.0296 ns | 24.581 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 27.367 ns | 0.0511 ns | 0.0478 ns | 27.354 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.944 ns | 0.0324 ns | 0.0287 ns | 13.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.725 ns | 0.0284 ns | 0.0266 ns | 12.715 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.639 ns | 0.0125 ns | 0.0104 ns | 12.641 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.306 ns | 0.0164 ns | 0.0146 ns | 14.305 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.430 ns | 0.1121 ns | 0.1049 ns | 14.470 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.448 ns | 0.0264 ns | 0.0234 ns | 15.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.430 ns | 0.0126 ns | 0.0112 ns | 13.432 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.599 ns | 0.0753 ns | 0.0628 ns | 14.625 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.950 ns | 0.0927 ns | 0.0867 ns | 22.985 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 24.534 ns | 0.0278 ns | 0.0261 ns | 24.538 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.293 ns | 0.1043 ns | 0.0976 ns | 42.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 40.606 ns | 0.0618 ns | 0.0516 ns | 40.593 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.721 ns | 0.0807 ns | 0.0715 ns | 39.714 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.347 ns | 0.0834 ns | 0.0780 ns | 42.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.967 ns | 0.0437 ns | 0.0365 ns | 40.961 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 18.067 ns | 0.0152 ns | 0.0142 ns | 18.070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 16.361 ns | 0.1021 ns | 0.0955 ns | 16.408 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.799 ns | 0.0177 ns | 0.0157 ns | 16.800 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.392 ns | 0.0424 ns | 0.0396 ns | 24.398 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 27.927 ns | 0.1049 ns | 0.0930 ns | 27.939 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.459 ns | 0.0966 ns | 0.0904 ns | 42.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 40.234 ns | 0.0553 ns | 0.0490 ns | 40.214 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.808 ns | 0.6079 ns | 0.5686 ns | 38.491 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 42.675 ns | 0.0456 ns | 0.0381 ns | 42.676 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 42.518 ns | 0.0411 ns | 0.0343 ns | 42.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.240 ns | 0.0398 ns | 0.0372 ns | 17.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.267 ns | 0.0154 ns | 0.0144 ns | 16.263 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.932 ns | 0.0206 ns | 0.0183 ns | 16.932 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.578 ns | 0.0493 ns | 0.0462 ns | 24.577 ns |  1.43 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 27.279 ns | 0.0309 ns | 0.0289 ns | 27.270 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.188 ns | 0.0469 ns | 0.0366 ns | 42.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 41.458 ns | 0.0504 ns | 0.0472 ns | 41.453 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 39.673 ns | 0.7603 ns | 0.7112 ns | 39.863 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 42.412 ns | 0.0495 ns | 0.0414 ns | 42.403 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.642 ns | 0.0376 ns | 0.0334 ns | 40.639 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.820 ns | 0.0103 ns | 0.0092 ns | 14.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.929 ns | 0.0358 ns | 0.0335 ns | 12.916 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.147 ns | 0.3005 ns | 0.4012 ns | 14.410 ns |  0.94 |    0.03 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 26.455 ns | 0.0385 ns | 0.0360 ns | 26.443 ns |  1.78 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 25.564 ns | 0.0334 ns | 0.0279 ns | 25.565 ns |  1.72 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UIntNullable.From_DateTime_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZVTGBZ(Toolchain=net472)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-XBZJXS(Toolchain=.NET Core 2.0)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-RPHYXP(Toolchain=.NET Core 2.2)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-WPBXUQ(Toolchain=.NET Core 3.0)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-EJFWSE(Toolchain=net461)
  ConvertTo_UIntNullable.From_String_Empty_AsObject: Job-ZVTGBZ(Toolchain=net472)
