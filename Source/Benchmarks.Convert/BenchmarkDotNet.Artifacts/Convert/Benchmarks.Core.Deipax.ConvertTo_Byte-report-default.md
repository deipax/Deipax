
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
                                             From_Bool | .NET Core 2.0 | 12.233 ns | 0.0165 ns | 0.0146 ns | 12.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.798 ns | 0.0908 ns | 0.0805 ns | 11.774 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.072 ns | 0.0218 ns | 0.0170 ns |  7.068 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.489 ns | 0.0190 ns | 0.0178 ns | 10.488 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.459 ns | 0.0277 ns | 0.0245 ns | 10.461 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.001 ns | 0.0182 ns | 0.0161 ns | 20.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.371 ns | 0.0910 ns | 0.0851 ns | 16.395 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 16.616 ns | 0.0862 ns | 0.0764 ns | 16.633 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.785 ns | 0.0882 ns | 0.0825 ns | 19.824 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 23.461 ns | 0.1228 ns | 0.1088 ns | 23.459 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.451 ns | 0.0152 ns | 0.0142 ns | 12.448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.316 ns | 0.0430 ns | 0.0382 ns | 11.323 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.485 ns | 0.0116 ns | 0.0108 ns |  7.489 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.202 ns | 0.0166 ns | 0.0156 ns | 12.207 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.833 ns | 0.0620 ns | 0.0580 ns | 10.812 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.917 ns | 0.2990 ns | 0.2797 ns | 17.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.306 ns | 0.0660 ns | 0.0585 ns | 16.295 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.127 ns | 0.1609 ns | 0.1505 ns | 16.123 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.184 ns | 0.0254 ns | 0.0237 ns | 18.185 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.233 ns | 0.0402 ns | 0.0376 ns | 18.240 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.331 ns | 0.0190 ns | 0.0178 ns | 12.335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 11.085 ns | 0.0389 ns | 0.0324 ns | 11.079 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.657 ns | 0.0082 ns | 0.0064 ns |  6.657 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.675 ns | 0.0417 ns | 0.0370 ns | 11.682 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.525 ns | 0.0339 ns | 0.0301 ns | 10.528 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.884 ns | 0.0149 ns | 0.0139 ns | 17.883 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.586 ns | 0.0846 ns | 0.0792 ns | 13.542 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.896 ns | 0.0159 ns | 0.0141 ns | 12.898 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.098 ns | 0.0342 ns | 0.0303 ns | 13.096 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.392 ns | 0.1009 ns | 0.0944 ns | 13.361 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.713 ns | 0.0708 ns | 0.0662 ns | 11.744 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.815 ns | 0.0443 ns | 0.0370 ns | 10.802 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.126 ns | 0.0159 ns | 0.0124 ns |  7.122 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.599 ns | 0.0100 ns | 0.0088 ns | 10.596 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.427 ns | 0.0692 ns | 0.0647 ns | 10.415 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 16.353 ns | 0.0204 ns | 0.0190 ns | 16.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 13.244 ns | 0.0260 ns | 0.0243 ns | 13.242 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 12.878 ns | 0.2803 ns | 0.4606 ns | 13.109 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 15.642 ns | 0.0924 ns | 0.0864 ns | 15.681 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 14.262 ns | 0.0722 ns | 0.0675 ns | 14.268 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.384 ns | 0.0125 ns | 0.0117 ns | 12.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.643 ns | 0.0333 ns | 0.0312 ns | 10.636 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  6.982 ns | 0.0139 ns | 0.0116 ns |  6.978 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 11.934 ns | 0.0483 ns | 0.0403 ns | 11.922 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.875 ns | 0.0909 ns | 0.0851 ns | 10.833 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.735 ns | 0.0977 ns | 0.0914 ns | 14.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.450 ns | 0.3151 ns | 0.3095 ns | 13.299 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.866 ns | 0.0132 ns | 0.0124 ns | 11.863 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 14.164 ns | 0.1014 ns | 0.0948 ns | 14.211 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 14.586 ns | 0.1317 ns | 0.1232 ns | 14.545 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.650 ns | 0.0138 ns | 0.0129 ns | 11.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.637 ns | 0.1659 ns | 0.1552 ns | 10.634 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.912 ns | 0.0068 ns | 0.0064 ns |  6.910 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 11.560 ns | 0.0244 ns | 0.0216 ns | 11.557 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.396 ns | 0.0504 ns | 0.0472 ns | 10.383 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.074 ns | 0.0117 ns | 0.0097 ns | 14.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.363 ns | 0.0795 ns | 0.0744 ns | 14.332 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.275 ns | 0.0305 ns | 0.0286 ns | 13.272 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.507 ns | 0.0104 ns | 0.0092 ns | 13.508 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.385 ns | 0.1490 ns | 0.1320 ns | 13.396 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.326 ns | 0.0123 ns | 0.0096 ns | 13.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.572 ns | 0.1012 ns | 0.0946 ns | 10.566 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.866 ns | 0.0362 ns | 0.0321 ns |  6.852 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 11.090 ns | 0.0087 ns | 0.0077 ns | 11.091 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.901 ns | 0.0521 ns | 0.0487 ns | 10.883 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.511 ns | 0.0287 ns | 0.0268 ns | 19.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.144 ns | 0.1333 ns | 0.1247 ns | 17.098 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.820 ns | 0.0308 ns | 0.0273 ns | 15.817 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 20.651 ns | 0.1178 ns | 0.1102 ns | 20.710 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 19.064 ns | 0.0657 ns | 0.0615 ns | 19.039 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.062 ns | 0.0785 ns | 0.0734 ns | 12.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.658 ns | 0.0675 ns | 0.0631 ns | 10.668 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.966 ns | 0.0245 ns | 0.0229 ns |  6.971 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.924 ns | 0.0169 ns | 0.0141 ns | 11.924 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.927 ns | 0.0180 ns | 0.0150 ns | 13.927 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.297 ns | 0.0339 ns | 0.0317 ns | 19.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.884 ns | 0.2306 ns | 0.2044 ns | 17.805 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.702 ns | 0.2473 ns | 0.2313 ns | 17.531 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 18.886 ns | 0.0289 ns | 0.0270 ns | 18.876 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 18.951 ns | 0.0277 ns | 0.0259 ns | 18.950 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.884 ns | 0.0121 ns | 0.0107 ns | 11.886 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.554 ns | 0.1391 ns | 0.1233 ns | 10.520 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  6.942 ns | 0.0176 ns | 0.0164 ns |  6.945 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 11.587 ns | 0.0150 ns | 0.0140 ns | 11.589 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.402 ns | 0.0165 ns | 0.0129 ns | 10.400 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.852 ns | 0.0346 ns | 0.0324 ns | 15.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.336 ns | 0.2590 ns | 0.3876 ns | 13.224 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.724 ns | 0.0238 ns | 0.0199 ns | 13.718 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 15.085 ns | 0.0224 ns | 0.0187 ns | 15.085 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.918 ns | 0.0122 ns | 0.0109 ns | 13.918 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.472 ns | 0.0128 ns | 0.0120 ns | 12.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.703 ns | 0.2224 ns | 0.2081 ns | 11.631 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.726 ns | 0.0119 ns | 0.0112 ns |  7.725 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.182 ns | 0.0141 ns | 0.0132 ns | 13.182 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.819 ns | 0.0371 ns | 0.0347 ns | 12.825 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.563 ns | 0.0159 ns | 0.0149 ns | 12.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.509 ns | 0.1273 ns | 0.1190 ns | 11.512 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.069 ns | 0.0397 ns | 0.0371 ns |  8.054 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 12.767 ns | 0.0174 ns | 0.0162 ns | 12.766 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 15.671 ns | 0.0169 ns | 0.0150 ns | 15.668 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.714 ns | 0.0137 ns | 0.0122 ns | 12.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.458 ns | 0.1320 ns | 0.1235 ns | 11.439 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.418 ns | 0.0268 ns | 0.0237 ns |  8.406 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 12.742 ns | 0.0116 ns | 0.0109 ns | 12.744 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.242 ns | 0.1024 ns | 0.0958 ns | 14.278 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.930 ns | 0.0218 ns | 0.0193 ns | 14.928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.654 ns | 0.1162 ns | 0.0971 ns | 13.633 ns |  0.91 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.225 ns | 0.2905 ns | 0.3674 ns | 13.502 ns |  0.90 |    0.02 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.097 ns | 0.0223 ns | 0.0209 ns | 13.095 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.271 ns | 0.0167 ns | 0.0139 ns | 13.272 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 26.009 ns | 0.0407 ns | 0.0360 ns | 26.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 24.098 ns | 0.3670 ns | 0.3433 ns | 24.030 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 14.787 ns | 0.1066 ns | 0.0945 ns | 14.808 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.783 ns | 0.0383 ns | 0.0339 ns | 24.774 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 27.645 ns | 0.0661 ns | 0.0586 ns | 27.637 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.970 ns | 0.0310 ns | 0.0275 ns | 26.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 26.278 ns | 0.5186 ns | 0.4851 ns | 26.027 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.888 ns | 0.0271 ns | 0.0253 ns | 21.890 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.560 ns | 0.0212 ns | 0.0188 ns | 27.565 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.308 ns | 0.0260 ns | 0.0230 ns | 27.313 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 26.081 ns | 0.0236 ns | 0.0209 ns | 26.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.411 ns | 0.1343 ns | 0.1257 ns | 23.368 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.603 ns | 0.0701 ns | 0.0656 ns | 16.583 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.598 ns | 0.0459 ns | 0.0429 ns | 25.589 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.101 ns | 0.0273 ns | 0.0255 ns | 25.100 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.831 ns | 0.0338 ns | 0.0282 ns | 26.836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.726 ns | 0.3076 ns | 0.2877 ns | 26.827 ns |  1.00 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.247 ns | 0.2232 ns | 0.2088 ns | 22.198 ns |  0.83 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.935 ns | 0.0389 ns | 0.0364 ns | 26.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.097 ns | 0.0317 ns | 0.0281 ns | 27.093 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.695 ns | 0.0518 ns | 0.0485 ns | 12.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.704 ns | 0.0219 ns | 0.0171 ns | 12.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.379 ns | 0.0144 ns | 0.0135 ns |  8.385 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.351 ns | 0.0137 ns | 0.0129 ns | 14.350 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.410 ns | 0.0109 ns | 0.0091 ns | 13.414 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.920 ns | 0.0287 ns | 0.0254 ns | 14.916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.912 ns | 0.0444 ns | 0.0393 ns | 12.916 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.520 ns | 0.2498 ns | 0.2453 ns | 11.709 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.298 ns | 0.0215 ns | 0.0191 ns | 13.300 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.804 ns | 0.0253 ns | 0.0212 ns | 15.798 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.244 ns | 0.0212 ns | 0.0188 ns | 13.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.781 ns | 0.1033 ns | 0.0862 ns | 13.782 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.612 ns | 0.2300 ns | 0.2648 ns | 10.746 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.404 ns | 0.0219 ns | 0.0194 ns | 15.401 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.307 ns | 0.0175 ns | 0.0163 ns | 14.311 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.914 ns | 0.0300 ns | 0.0251 ns | 20.910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.976 ns | 0.0875 ns | 0.0818 ns | 17.945 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.930 ns | 0.0306 ns | 0.0287 ns | 17.919 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 20.167 ns | 0.0258 ns | 0.0216 ns | 20.162 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.386 ns | 0.0628 ns | 0.0524 ns | 20.355 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.667 ns | 0.0230 ns | 0.0215 ns | 15.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 13.989 ns | 0.1005 ns | 0.0784 ns | 13.969 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.095 ns | 0.0620 ns | 0.0580 ns | 12.072 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.805 ns | 0.0163 ns | 0.0152 ns | 15.803 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.985 ns | 0.0453 ns | 0.0401 ns | 15.976 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.717 ns | 0.0504 ns | 0.0471 ns | 20.706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.029 ns | 0.1202 ns | 0.1125 ns | 17.983 ns |  0.87 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.046 ns | 0.4192 ns | 0.4827 ns | 20.425 ns |  0.98 |    0.02 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 19.874 ns | 0.0305 ns | 0.0255 ns | 19.880 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.387 ns | 0.0191 ns | 0.0178 ns | 20.380 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.497 ns | 0.0095 ns | 0.0089 ns | 12.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.732 ns | 0.2593 ns | 0.3372 ns | 11.588 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.016 ns | 0.0126 ns | 0.0105 ns |  8.016 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.621 ns | 0.0126 ns | 0.0105 ns | 12.619 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.801 ns | 0.0519 ns | 0.0486 ns | 12.812 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.022 ns | 0.0151 ns | 0.0142 ns | 14.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.085 ns | 0.1420 ns | 0.1328 ns | 15.038 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.899 ns | 0.0174 ns | 0.0136 ns | 12.901 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 15.267 ns | 0.0229 ns | 0.0214 ns | 15.260 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.206 ns | 0.0169 ns | 0.0158 ns | 13.204 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.065 ns | 0.0136 ns | 0.0127 ns | 12.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.292 ns | 0.1306 ns | 0.1158 ns | 11.273 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  8.117 ns | 0.0157 ns | 0.0139 ns |  8.118 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.997 ns | 0.0178 ns | 0.0157 ns | 10.991 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.938 ns | 0.0160 ns | 0.0142 ns | 10.938 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 19.500 ns | 0.0223 ns | 0.0208 ns | 19.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.801 ns | 0.1526 ns | 0.1275 ns | 16.767 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 16.242 ns | 0.0333 ns | 0.0311 ns | 16.238 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.194 ns | 0.0466 ns | 0.0413 ns | 19.200 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.575 ns | 0.3915 ns | 0.4660 ns | 19.569 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.155 ns | 0.0243 ns | 0.0227 ns | 13.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.656 ns | 0.0381 ns | 0.0338 ns | 11.652 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  8.164 ns | 0.0126 ns | 0.0105 ns |  8.163 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.017 ns | 0.0151 ns | 0.0141 ns | 12.013 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.319 ns | 0.1020 ns | 0.0954 ns | 12.279 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 24.718 ns | 0.5206 ns | 1.5351 ns | 24.678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.267 ns | 0.0791 ns | 0.0701 ns | 17.274 ns |  0.70 |    0.03 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.200 ns | 0.0329 ns | 0.0308 ns | 16.187 ns |  0.66 |    0.03 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 20.450 ns | 0.0247 ns | 0.0231 ns | 20.448 ns |  0.83 |    0.04 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 19.331 ns | 0.1557 ns | 0.1380 ns | 19.323 ns |  0.78 |    0.04 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.850 ns | 0.0368 ns | 0.0344 ns | 11.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.328 ns | 0.0199 ns | 0.0186 ns | 10.327 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.714 ns | 0.0218 ns | 0.0193 ns |  6.712 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.280 ns | 0.0156 ns | 0.0138 ns | 10.279 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.542 ns | 0.0271 ns | 0.0254 ns | 10.530 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.925 ns | 0.0125 ns | 0.0117 ns | 14.924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.707 ns | 0.0975 ns | 0.0912 ns | 13.687 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.305 ns | 0.0147 ns | 0.0137 ns | 11.301 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.002 ns | 0.0144 ns | 0.0134 ns | 13.001 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.198 ns | 0.0286 ns | 0.0268 ns | 13.190 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.066 ns | 0.0107 ns | 0.0100 ns | 12.064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.007 ns | 0.1673 ns | 0.1483 ns | 11.928 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  8.366 ns | 0.0089 ns | 0.0079 ns |  8.365 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 11.049 ns | 0.0168 ns | 0.0157 ns | 11.052 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 10.812 ns | 0.0082 ns | 0.0064 ns | 10.814 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 20.340 ns | 0.0608 ns | 0.0569 ns | 20.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.605 ns | 0.1180 ns | 0.1104 ns | 16.558 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.703 ns | 0.0257 ns | 0.0228 ns | 15.701 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 18.685 ns | 0.0253 ns | 0.0211 ns | 18.678 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.885 ns | 0.0319 ns | 0.0266 ns | 18.878 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 15.138 ns | 0.0156 ns | 0.0138 ns | 15.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.763 ns | 0.0750 ns | 0.0701 ns | 11.775 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.224 ns | 0.1155 ns | 0.1080 ns |  8.305 ns |  0.54 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.989 ns | 0.0157 ns | 0.0139 ns | 12.991 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.110 ns | 0.0910 ns | 0.0851 ns | 12.088 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.463 ns | 0.0267 ns | 0.0249 ns | 19.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.520 ns | 0.1137 ns | 0.1064 ns | 16.475 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.499 ns | 0.0317 ns | 0.0296 ns | 16.489 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.800 ns | 0.0311 ns | 0.0291 ns | 18.789 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.995 ns | 0.0430 ns | 0.0359 ns | 18.991 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.785 ns | 0.0151 ns | 0.0141 ns | 11.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.571 ns | 0.0992 ns | 0.0829 ns | 10.549 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.823 ns | 0.0116 ns | 0.0097 ns |  6.821 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 10.408 ns | 0.0058 ns | 0.0054 ns | 10.410 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.444 ns | 0.0762 ns | 0.0675 ns | 10.413 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.038 ns | 0.0176 ns | 0.0156 ns | 14.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.855 ns | 0.3116 ns | 0.2914 ns | 15.842 ns |  1.13 |    0.02 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.453 ns | 0.1220 ns | 0.1141 ns | 11.516 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.174 ns | 0.0300 ns | 0.0280 ns | 13.180 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.271 ns | 0.0400 ns | 0.0375 ns | 13.265 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.001 ns | 0.0183 ns | 0.0162 ns | 12.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.714 ns | 0.0473 ns | 0.0419 ns | 10.713 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.382 ns | 0.0121 ns | 0.0107 ns |  8.385 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.043 ns | 0.0148 ns | 0.0124 ns | 11.042 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 10.962 ns | 0.0260 ns | 0.0243 ns | 10.963 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.025 ns | 0.0503 ns | 0.0446 ns | 19.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 17.043 ns | 0.1135 ns | 0.1006 ns | 17.024 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.775 ns | 0.0377 ns | 0.0352 ns | 15.772 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.491 ns | 0.0255 ns | 0.0213 ns | 18.486 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.912 ns | 0.0704 ns | 0.0658 ns | 18.924 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.695 ns | 0.0656 ns | 0.0512 ns | 13.682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.142 ns | 0.2219 ns | 0.1967 ns | 13.104 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.817 ns | 0.1868 ns | 0.1747 ns | 10.816 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.542 ns | 0.0972 ns | 0.0909 ns | 14.496 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.831 ns | 0.0841 ns | 0.0787 ns | 13.792 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.809 ns | 1.2567 ns | 3.5031 ns | 19.692 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.225 ns | 0.1461 ns | 0.1366 ns | 17.211 ns |  0.76 |    0.13 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.512 ns | 0.3460 ns | 0.3237 ns | 16.559 ns |  0.73 |    0.12 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.738 ns | 0.0265 ns | 0.0248 ns | 18.735 ns |  0.82 |    0.14 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.884 ns | 0.0259 ns | 0.0242 ns | 18.891 ns |  0.83 |    0.14 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.653 ns | 0.0964 ns | 0.0902 ns | 12.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.343 ns | 0.1412 ns | 0.1321 ns | 11.327 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.164 ns | 0.0147 ns | 0.0130 ns |  8.164 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.681 ns | 0.0205 ns | 0.0182 ns | 12.679 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.833 ns | 0.0123 ns | 0.0115 ns | 12.828 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.574 ns | 0.0697 ns | 0.0582 ns | 14.581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.750 ns | 0.0766 ns | 0.0716 ns | 12.731 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.441 ns | 0.1232 ns | 0.1152 ns | 11.491 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 13.185 ns | 0.0426 ns | 0.0398 ns | 13.183 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.353 ns | 0.0481 ns | 0.0450 ns | 13.345 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.846 ns | 0.0501 ns | 0.0469 ns | 11.851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.349 ns | 0.0177 ns | 0.0165 ns | 10.351 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.718 ns | 0.0148 ns | 0.0139 ns |  7.718 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.825 ns | 0.0214 ns | 0.0179 ns | 10.828 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.651 ns | 0.0172 ns | 0.0143 ns | 10.647 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.604 ns | 0.0570 ns | 0.0533 ns | 18.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 16.514 ns | 0.0327 ns | 0.0306 ns | 16.510 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 15.655 ns | 0.0474 ns | 0.0370 ns | 15.654 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.832 ns | 0.0503 ns | 0.0471 ns | 18.841 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 19.088 ns | 0.0227 ns | 0.0201 ns | 19.083 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.049 ns | 0.0697 ns | 0.0652 ns | 12.029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.552 ns | 0.0658 ns | 0.0616 ns | 10.521 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.847 ns | 0.0170 ns | 0.0133 ns |  6.848 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.913 ns | 0.0184 ns | 0.0163 ns | 11.910 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.105 ns | 0.0466 ns | 0.0436 ns | 12.117 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.593 ns | 0.0367 ns | 0.0307 ns | 18.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.698 ns | 0.0333 ns | 0.0295 ns | 15.696 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.342 ns | 0.2175 ns | 0.2034 ns | 15.236 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.500 ns | 0.0246 ns | 0.0218 ns | 18.506 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.751 ns | 0.0210 ns | 0.0186 ns | 18.749 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.839 ns | 0.0716 ns | 0.0598 ns | 11.825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.323 ns | 0.0141 ns | 0.0125 ns | 10.323 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.611 ns | 0.0117 ns | 0.0110 ns |  6.610 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 11.579 ns | 0.0135 ns | 0.0126 ns | 11.577 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.460 ns | 0.0680 ns | 0.0602 ns | 11.462 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.376 ns | 0.1741 ns | 0.1543 ns | 14.341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.789 ns | 0.0259 ns | 0.0243 ns | 12.785 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.219 ns | 0.0197 ns | 0.0185 ns | 11.218 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.528 ns | 0.0205 ns | 0.0171 ns | 13.524 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 16.347 ns | 0.3231 ns | 0.3721 ns | 16.224 ns |  1.15 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.360 ns | 0.0510 ns | 0.0452 ns | 13.352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.475 ns | 0.0277 ns | 0.0232 ns | 12.476 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.116 ns | 0.0209 ns | 0.0196 ns | 10.109 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.033 ns | 0.0528 ns | 0.0468 ns | 16.021 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.360 ns | 0.1868 ns | 0.1656 ns | 14.280 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.865 ns | 0.1122 ns | 0.0995 ns | 21.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.736 ns | 0.0174 ns | 0.0163 ns | 17.734 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.637 ns | 0.1493 ns | 0.1396 ns | 18.720 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.505 ns | 0.0233 ns | 0.0218 ns | 21.501 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 21.753 ns | 0.0615 ns | 0.0575 ns | 21.731 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.056 ns | 0.0197 ns | 0.0174 ns | 14.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.750 ns | 0.0621 ns | 0.0581 ns | 13.739 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.322 ns | 0.1230 ns | 0.1151 ns | 10.247 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.234 ns | 0.0241 ns | 0.0225 ns | 13.232 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.315 ns | 0.0679 ns | 0.0635 ns | 13.292 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.507 ns | 0.1909 ns | 0.1785 ns | 21.573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.571 ns | 0.0270 ns | 0.0239 ns | 18.565 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.473 ns | 0.0163 ns | 0.0152 ns | 18.470 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 21.542 ns | 0.0386 ns | 0.0361 ns | 21.550 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 21.687 ns | 0.0314 ns | 0.0263 ns | 21.682 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.737 ns | 0.0501 ns | 0.0444 ns | 11.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.426 ns | 0.0241 ns | 0.0225 ns | 10.428 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.628 ns | 0.0337 ns | 0.0315 ns |  6.641 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.453 ns | 0.0141 ns | 0.0132 ns | 10.458 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.395 ns | 0.0147 ns | 0.0138 ns | 10.394 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.309 ns | 0.1628 ns | 0.1443 ns | 14.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.635 ns | 0.1245 ns | 0.1165 ns | 13.685 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.301 ns | 0.0125 ns | 0.0104 ns | 11.302 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.045 ns | 0.0295 ns | 0.0276 ns | 13.039 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.295 ns | 0.0350 ns | 0.0327 ns | 13.292 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.715 ns | 0.4068 ns | 0.3805 ns | 58.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 53.215 ns | 0.0853 ns | 0.0798 ns | 53.196 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 20.785 ns | 0.4341 ns | 0.4061 ns | 20.520 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 57.620 ns | 0.0889 ns | 0.0788 ns | 57.621 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net472 | 57.572 ns | 0.0834 ns | 0.0780 ns | 57.568 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 63.376 ns | 0.2342 ns | 0.2191 ns | 63.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 61.732 ns | 0.3479 ns | 0.3254 ns | 61.753 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 28.268 ns | 0.1276 ns | 0.1194 ns | 28.298 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 63.992 ns | 0.0994 ns | 0.0830 ns | 64.006 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 64.020 ns | 0.1729 ns | 0.1532 ns | 63.953 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.374 ns | 0.0242 ns | 0.0202 ns | 12.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.963 ns | 0.0715 ns | 0.0669 ns | 12.943 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.060 ns | 0.1610 ns | 0.1506 ns | 11.971 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 11.334 ns | 0.0509 ns | 0.0425 ns | 11.321 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.854 ns | 0.0551 ns | 0.0515 ns | 12.852 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.255 ns | 0.1528 ns | 0.1429 ns | 14.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 14.427 ns | 0.0576 ns | 0.0481 ns | 14.414 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 12.359 ns | 0.2659 ns | 0.3981 ns | 12.508 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.909 ns | 0.0169 ns | 0.0158 ns | 14.907 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.561 ns | 0.0289 ns | 0.0242 ns | 13.564 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 15.149 ns | 0.0372 ns | 0.0348 ns | 15.137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.118 ns | 0.0200 ns | 0.0167 ns | 12.118 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 15.993 ns | 0.8636 ns | 1.6431 ns | 15.141 ns |  1.18 |    0.11 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.908 ns | 0.0234 ns | 0.0219 ns | 12.919 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.856 ns | 0.0118 ns | 0.0105 ns | 13.856 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.897 ns | 0.0638 ns | 0.0597 ns | 11.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.430 ns | 0.0622 ns | 0.0581 ns | 10.404 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.461 ns | 0.1708 ns | 0.2395 ns |  7.623 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.828 ns | 0.0140 ns | 0.0124 ns | 10.826 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.645 ns | 0.0190 ns | 0.0159 ns | 10.645 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.807 ns | 0.0644 ns | 0.0603 ns | 18.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 16.511 ns | 0.0244 ns | 0.0217 ns | 16.513 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 15.770 ns | 0.1083 ns | 0.1013 ns | 15.763 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 18.646 ns | 0.0684 ns | 0.0640 ns | 18.661 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.614 ns | 0.0344 ns | 0.0305 ns | 18.608 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.996 ns | 0.0219 ns | 0.0205 ns | 11.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.986 ns | 0.0236 ns | 0.0221 ns | 11.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.137 ns | 0.1984 ns | 0.2908 ns |  6.981 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 11.893 ns | 0.0152 ns | 0.0127 ns | 11.891 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 11.999 ns | 0.0193 ns | 0.0181 ns | 11.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.406 ns | 0.0219 ns | 0.0194 ns | 19.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.737 ns | 0.0213 ns | 0.0189 ns | 15.738 ns |  0.81 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.232 ns | 0.0238 ns | 0.0222 ns | 15.233 ns |  0.78 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.784 ns | 0.0477 ns | 0.0446 ns | 18.776 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.857 ns | 0.0337 ns | 0.0299 ns | 18.851 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.897 ns | 0.0653 ns | 0.0610 ns | 11.893 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.356 ns | 0.0277 ns | 0.0246 ns | 10.348 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.238 ns | 0.0185 ns | 0.0164 ns |  7.238 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.347 ns | 0.0656 ns | 0.0613 ns | 10.388 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.443 ns | 0.0337 ns | 0.0299 ns | 10.448 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.210 ns | 0.0193 ns | 0.0171 ns | 14.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.501 ns | 0.0143 ns | 0.0127 ns | 13.503 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.205 ns | 0.0114 ns | 0.0095 ns | 11.206 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.324 ns | 0.0371 ns | 0.0329 ns | 13.312 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.346 ns | 0.0461 ns | 0.0432 ns | 13.355 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.791 ns | 0.0154 ns | 0.0137 ns | 11.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.392 ns | 0.0086 ns | 0.0080 ns | 10.392 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.706 ns | 0.0134 ns | 0.0126 ns |  6.705 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 10.924 ns | 0.0174 ns | 0.0163 ns | 10.925 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.898 ns | 0.0217 ns | 0.0193 ns | 10.897 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.150 ns | 0.0258 ns | 0.0216 ns | 19.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.551 ns | 0.0258 ns | 0.0229 ns | 16.550 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 16.384 ns | 0.2034 ns | 0.1803 ns | 16.420 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 19.156 ns | 0.0654 ns | 0.0612 ns | 19.171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 19.183 ns | 0.0274 ns | 0.0256 ns | 19.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.125 ns | 0.0380 ns | 0.0337 ns | 12.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.609 ns | 0.0719 ns | 0.0672 ns | 10.638 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.057 ns | 0.0146 ns | 0.0136 ns |  7.054 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 12.913 ns | 0.0141 ns | 0.0125 ns | 12.914 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 12.110 ns | 0.0970 ns | 0.0907 ns | 12.073 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.544 ns | 0.0442 ns | 0.0369 ns | 18.547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.527 ns | 0.0176 ns | 0.0156 ns | 16.523 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.368 ns | 0.0336 ns | 0.0298 ns | 15.364 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 22.214 ns | 0.0261 ns | 0.0245 ns | 22.216 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.875 ns | 0.0341 ns | 0.0319 ns | 18.871 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.740 ns | 0.0501 ns | 0.0444 ns | 11.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.358 ns | 0.0180 ns | 0.0169 ns | 10.356 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.068 ns | 0.0114 ns | 0.0101 ns |  7.068 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.363 ns | 0.0674 ns | 0.0631 ns | 10.390 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.395 ns | 0.0075 ns | 0.0062 ns | 10.395 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.136 ns | 0.0753 ns | 0.0704 ns | 14.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0090 ns | 0.0080 ns | 12.650 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.415 ns | 0.2809 ns | 0.3123 ns | 13.589 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 14.156 ns | 0.0113 ns | 0.0106 ns | 14.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.309 ns | 0.0583 ns | 0.0545 ns | 13.324 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.066 ns | 0.0271 ns | 0.0240 ns | 12.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.800 ns | 0.0109 ns | 0.0091 ns | 10.799 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  8.066 ns | 0.1561 ns | 0.1460 ns |  8.169 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.525 ns | 0.0177 ns | 0.0165 ns | 12.526 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.681 ns | 0.0121 ns | 0.0114 ns | 10.681 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.741 ns | 0.0752 ns | 0.0704 ns | 19.753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.519 ns | 0.0286 ns | 0.0253 ns | 16.515 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.945 ns | 0.0204 ns | 0.0191 ns | 15.950 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 18.929 ns | 0.0480 ns | 0.0449 ns | 18.923 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 18.969 ns | 0.0395 ns | 0.0330 ns | 18.965 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.734 ns | 0.0433 ns | 0.0405 ns | 13.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.719 ns | 0.0134 ns | 0.0125 ns | 12.714 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.486 ns | 0.2516 ns | 0.2898 ns | 11.550 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.068 ns | 0.0152 ns | 0.0127 ns | 15.070 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.820 ns | 0.0141 ns | 0.0125 ns | 13.818 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.478 ns | 0.0393 ns | 0.0328 ns | 19.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.532 ns | 0.0244 ns | 0.0228 ns | 16.529 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.009 ns | 0.0296 ns | 0.0277 ns | 15.998 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 18.858 ns | 0.0275 ns | 0.0243 ns | 18.866 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 18.953 ns | 0.0383 ns | 0.0358 ns | 18.954 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.647 ns | 0.0535 ns | 0.0500 ns | 12.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.201 ns | 0.0121 ns | 0.0101 ns | 11.201 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  7.959 ns | 0.0146 ns | 0.0114 ns |  7.958 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.341 ns | 0.0153 ns | 0.0135 ns | 13.340 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.755 ns | 0.0169 ns | 0.0142 ns | 12.762 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.076 ns | 0.0550 ns | 0.0514 ns | 14.078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.679 ns | 0.0487 ns | 0.0432 ns | 12.660 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.312 ns | 0.0136 ns | 0.0128 ns | 11.310 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.993 ns | 0.0149 ns | 0.0140 ns | 14.993 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.214 ns | 0.0194 ns | 0.0182 ns | 13.213 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.283 ns | 0.0474 ns | 0.0443 ns | 15.270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.660 ns | 0.0146 ns | 0.0122 ns | 12.657 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 11.325 ns | 0.0211 ns | 0.0197 ns | 11.327 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.069 ns | 0.0450 ns | 0.0421 ns | 13.055 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.389 ns | 0.0167 ns | 0.0148 ns | 13.391 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 11.696 ns | 0.0360 ns | 0.0319 ns | 11.695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.970 ns | 0.0423 ns | 0.0395 ns |  9.973 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 10.897 ns | 0.0565 ns | 0.0528 ns | 10.928 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.043 ns | 0.0130 ns | 0.0121 ns | 11.041 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 10.961 ns | 0.0152 ns | 0.0142 ns | 10.963 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.954 ns | 0.0260 ns | 0.0217 ns | 14.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.666 ns | 0.0159 ns | 0.0133 ns | 12.664 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.309 ns | 0.2893 ns | 0.3096 ns | 13.539 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.061 ns | 0.0172 ns | 0.0161 ns | 13.054 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.748 ns | 0.0543 ns | 0.0508 ns | 13.723 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 15.002 ns | 0.0412 ns | 0.0321 ns | 14.995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 13.278 ns | 0.0140 ns | 0.0109 ns | 13.278 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.171 ns | 0.2825 ns | 0.3771 ns | 13.347 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 17.612 ns | 0.4250 ns | 0.8188 ns | 17.294 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.001 ns | 0.0237 ns | 0.0222 ns | 16.994 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 20.124 ns | 0.4660 ns | 0.5722 ns | 19.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.624 ns | 0.0151 ns | 0.0141 ns | 17.620 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.300 ns | 0.0206 ns | 0.0182 ns | 14.298 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 17.028 ns | 0.0631 ns | 0.0590 ns | 17.038 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.078 ns | 0.0323 ns | 0.0302 ns | 17.071 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.015 ns | 0.0988 ns | 0.0924 ns | 14.028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.451 ns | 0.0328 ns | 0.0291 ns | 12.460 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.141 ns | 0.1077 ns | 0.1008 ns | 11.213 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.228 ns | 0.0528 ns | 0.0494 ns | 13.226 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.957 ns | 0.0168 ns | 0.0131 ns | 14.953 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.072 ns | 0.0337 ns | 0.0299 ns | 14.061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.654 ns | 0.0190 ns | 0.0168 ns | 12.651 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 14.088 ns | 0.3065 ns | 0.4195 ns | 13.800 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.113 ns | 0.1286 ns | 0.1140 ns | 15.113 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.277 ns | 0.0270 ns | 0.0253 ns | 13.275 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.796 ns | 0.0320 ns | 0.0284 ns | 12.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.340 ns | 0.0068 ns | 0.0064 ns | 10.339 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.646 ns | 0.0228 ns | 0.0190 ns | 10.646 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.370 ns | 0.0250 ns | 0.0222 ns | 12.367 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.311 ns | 0.0238 ns | 0.0222 ns | 12.308 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.293 ns | 0.0747 ns | 0.0662 ns | 15.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.161 ns | 0.0773 ns | 0.0723 ns | 14.193 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.170 ns | 0.1766 ns | 0.1652 ns | 13.278 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.533 ns | 0.0359 ns | 0.0336 ns | 16.527 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.216 ns | 0.0614 ns | 0.0544 ns | 17.196 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.743 ns | 0.0213 ns | 0.0178 ns | 12.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.739 ns | 0.0126 ns | 0.0112 ns | 11.739 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.224 ns | 0.0360 ns | 0.0319 ns | 11.215 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.193 ns | 0.0361 ns | 0.0320 ns | 14.200 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.535 ns | 0.0181 ns | 0.0169 ns | 12.534 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.019 ns | 0.0862 ns | 0.0806 ns | 14.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.663 ns | 0.0160 ns | 0.0133 ns | 12.663 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.950 ns | 0.0470 ns | 0.0393 ns | 12.953 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.449 ns | 0.0591 ns | 0.0494 ns | 14.462 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.164 ns | 0.0361 ns | 0.0338 ns | 13.154 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 19.043 ns | 0.0773 ns | 0.0723 ns | 19.047 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.233 ns | 0.0552 ns | 0.0489 ns | 16.241 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.418 ns | 0.1673 ns | 0.1565 ns | 11.428 ns |  0.60 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.124 ns | 0.1483 ns | 0.1387 ns | 18.101 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.707 ns | 0.0399 ns | 0.0354 ns | 16.703 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.710 ns | 0.0597 ns | 0.0558 ns | 17.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.253 ns | 0.0153 ns | 0.0135 ns | 15.252 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.195 ns | 0.0267 ns | 0.0249 ns | 16.191 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.664 ns | 0.0568 ns | 0.0503 ns | 17.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.684 ns | 0.0468 ns | 0.0438 ns | 17.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.253 ns | 0.0503 ns | 0.0446 ns | 19.253 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.260 ns | 0.0296 ns | 0.0247 ns | 16.255 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.014 ns | 0.0250 ns | 0.0234 ns | 13.018 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 18.610 ns | 0.1196 ns | 0.1119 ns | 18.622 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 16.917 ns | 0.0793 ns | 0.0662 ns | 16.907 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.405 ns | 0.1140 ns | 0.1010 ns | 17.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.247 ns | 0.1036 ns | 0.0969 ns | 16.297 ns |  0.93 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.379 ns | 0.0672 ns | 0.0629 ns | 16.394 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.750 ns | 0.1418 ns | 0.1327 ns | 17.703 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.724 ns | 0.0524 ns | 0.0490 ns | 17.726 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.256 ns | 0.0732 ns | 0.0685 ns | 13.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.982 ns | 0.0146 ns | 0.0122 ns | 11.977 ns |  0.90 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.081 ns | 0.0092 ns | 0.0086 ns |  7.081 ns |  0.53 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.520 ns | 0.0348 ns | 0.0325 ns | 10.509 ns |  0.79 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.461 ns | 0.0095 ns | 0.0084 ns | 10.461 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.243 ns | 0.0164 ns | 0.0145 ns | 14.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.700 ns | 0.0815 ns | 0.0762 ns | 12.660 ns |  0.89 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.797 ns | 0.1059 ns | 0.0991 ns | 13.746 ns |  0.97 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 15.719 ns | 0.0343 ns | 0.0287 ns | 15.722 ns |  1.10 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.145 ns | 0.0183 ns | 0.0171 ns | 13.146 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.119 ns | 0.1142 ns | 0.1068 ns | 13.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.787 ns | 0.0335 ns | 0.0280 ns | 10.795 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.445 ns | 0.0520 ns | 0.0486 ns |  6.418 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.395 ns | 0.0772 ns | 0.0684 ns | 10.371 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.590 ns | 0.0496 ns | 0.0440 ns | 11.579 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.968 ns | 0.0364 ns | 0.0322 ns | 14.968 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.037 ns | 0.0109 ns | 0.0102 ns | 14.038 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.952 ns | 0.3222 ns | 0.4823 ns | 15.278 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 14.906 ns | 0.0350 ns | 0.0310 ns | 14.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.942 ns | 0.0167 ns | 0.0139 ns | 14.945 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.032 ns | 0.0127 ns | 0.0119 ns | 13.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.757 ns | 0.0099 ns | 0.0083 ns | 10.758 ns |  0.83 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.565 ns | 0.0106 ns | 0.0094 ns |  6.567 ns |  0.50 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.928 ns | 0.0562 ns | 0.0526 ns | 11.918 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.512 ns | 0.0240 ns | 0.0224 ns | 11.509 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.015 ns | 0.0306 ns | 0.0239 ns | 15.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.972 ns | 0.0798 ns | 0.0746 ns | 15.013 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.327 ns | 0.1726 ns | 0.1615 ns | 15.364 ns |  1.02 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.993 ns | 0.0825 ns | 0.0771 ns | 14.980 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.646 ns | 0.0995 ns | 0.0930 ns | 15.591 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.171 ns | 0.0322 ns | 0.0301 ns | 13.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.770 ns | 0.0095 ns | 0.0084 ns | 10.768 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.718 ns | 0.0130 ns | 0.0122 ns |  6.716 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.375 ns | 0.0495 ns | 0.0463 ns | 10.379 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.485 ns | 0.0148 ns | 0.0139 ns | 11.485 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.933 ns | 0.0199 ns | 0.0187 ns | 14.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.652 ns | 0.0134 ns | 0.0126 ns | 12.651 ns |  0.85 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.304 ns | 0.0165 ns | 0.0146 ns | 11.300 ns |  0.76 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.113 ns | 0.0401 ns | 0.0335 ns | 13.113 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.456 ns | 0.0148 ns | 0.0124 ns | 13.452 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.514 ns | 0.0414 ns | 0.0387 ns | 13.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.591 ns | 0.0320 ns | 0.0299 ns | 10.574 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.673 ns | 0.0330 ns | 0.0309 ns |  7.665 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.649 ns | 0.0320 ns | 0.0283 ns | 12.642 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.902 ns | 0.0589 ns | 0.0551 ns | 10.893 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 46.605 ns | 0.0814 ns | 0.0721 ns | 46.590 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.986 ns | 0.1085 ns | 0.0961 ns | 43.948 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 35.905 ns | 0.7286 ns | 1.1343 ns | 36.519 ns |  0.75 |    0.03 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 44.039 ns | 0.3104 ns | 0.2903 ns | 44.114 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 42.742 ns | 0.0439 ns | 0.0389 ns | 42.731 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.971 ns | 0.0116 ns | 0.0109 ns | 13.973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 12.159 ns | 0.0119 ns | 0.0111 ns | 12.159 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.246 ns | 0.0096 ns | 0.0089 ns |  8.247 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.098 ns | 0.0462 ns | 0.0432 ns | 12.084 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 11.990 ns | 0.0209 ns | 0.0196 ns | 11.990 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 46.692 ns | 0.2663 ns | 0.2491 ns | 46.609 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.199 ns | 0.1813 ns | 0.1696 ns | 43.231 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 36.031 ns | 0.4457 ns | 0.4169 ns | 35.910 ns |  0.77 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.390 ns | 0.2383 ns | 0.2229 ns | 42.381 ns |  0.91 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 43.162 ns | 0.1346 ns | 0.1193 ns | 43.166 ns |  0.92 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.085 ns | 0.0181 ns | 0.0161 ns | 13.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.765 ns | 0.0176 ns | 0.0147 ns | 10.763 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  8.461 ns | 0.1940 ns | 0.4534 ns |  8.605 ns |  0.61 |    0.06 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.502 ns | 0.0423 ns | 0.0396 ns | 10.493 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.343 ns | 0.0131 ns | 0.0116 ns | 10.347 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.926 ns | 0.0152 ns | 0.0142 ns | 14.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.656 ns | 0.0090 ns | 0.0084 ns | 12.657 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.383 ns | 0.0487 ns | 0.0432 ns | 11.395 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.263 ns | 0.0675 ns | 0.0631 ns | 13.271 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.252 ns | 0.0343 ns | 0.0321 ns | 13.250 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.812 ns | 0.0665 ns | 0.0622 ns | 12.797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.427 ns | 0.0104 ns | 0.0093 ns | 10.429 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.964 ns | 0.3045 ns | 0.6873 ns | 14.119 ns |  1.05 |    0.10 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.465 ns | 0.0435 ns | 0.0407 ns | 12.462 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 13.197 ns | 0.0491 ns | 0.0410 ns | 13.214 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.551 ns | 0.0212 ns | 0.0165 ns | 16.550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.786 ns | 0.0235 ns | 0.0196 ns | 14.792 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 14.494 ns | 0.0219 ns | 0.0205 ns | 14.492 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.302 ns | 0.0661 ns | 0.0586 ns | 15.285 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.429 ns | 0.0247 ns | 0.0231 ns | 15.425 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.784 ns | 0.0624 ns | 0.0583 ns | 12.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.396 ns | 0.0238 ns | 0.0211 ns | 10.392 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 10.719 ns | 0.0171 ns | 0.0160 ns | 10.722 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.527 ns | 0.1079 ns | 0.1009 ns | 12.554 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.356 ns | 0.0234 ns | 0.0207 ns | 12.360 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.352 ns | 0.0191 ns | 0.0169 ns | 14.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.645 ns | 0.0109 ns | 0.0097 ns | 12.642 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 11.362 ns | 0.1031 ns | 0.0964 ns | 11.297 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.105 ns | 0.0638 ns | 0.0566 ns | 13.098 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.266 ns | 0.0181 ns | 0.0151 ns | 13.267 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.647 ns | 0.0716 ns | 0.0635 ns | 38.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 37.579 ns | 0.0430 ns | 0.0402 ns | 37.569 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.923 ns | 0.0520 ns | 0.0487 ns | 36.936 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.977 ns | 0.1708 ns | 0.1514 ns | 39.037 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.621 ns | 0.0595 ns | 0.0527 ns | 38.614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 15.397 ns | 0.0158 ns | 0.0132 ns | 15.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.340 ns | 0.0107 ns | 0.0095 ns | 14.339 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.244 ns | 0.0476 ns | 0.0422 ns | 13.226 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.278 ns | 0.0447 ns | 0.0396 ns | 15.288 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.421 ns | 0.0609 ns | 0.0569 ns | 15.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.606 ns | 0.7423 ns | 0.6580 ns | 39.500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.151 ns | 0.0349 ns | 0.0310 ns | 37.153 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.923 ns | 0.0560 ns | 0.0468 ns | 34.914 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.718 ns | 0.1634 ns | 0.1449 ns | 39.719 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.458 ns | 0.0662 ns | 0.0619 ns | 38.482 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.419 ns | 0.1441 ns | 0.1348 ns | 16.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.463 ns | 0.0729 ns | 0.0682 ns | 14.488 ns |  0.88 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.076 ns | 0.3054 ns | 0.4477 ns | 14.309 ns |  0.84 |    0.03 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.388 ns | 0.0940 ns | 0.0834 ns | 15.396 ns |  0.94 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.396 ns | 0.0202 ns | 0.0189 ns | 15.399 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.353 ns | 0.1845 ns | 0.1726 ns | 39.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.176 ns | 0.0640 ns | 0.0567 ns | 37.161 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 33.915 ns | 0.0487 ns | 0.0456 ns | 33.904 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.723 ns | 0.1846 ns | 0.1637 ns | 38.713 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.806 ns | 0.1812 ns | 0.1695 ns | 40.845 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.868 ns | 0.0920 ns | 0.0768 ns | 14.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.465 ns | 0.0155 ns | 0.0137 ns | 13.465 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.223 ns | 0.2035 ns | 0.1904 ns | 13.313 ns |  0.89 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.521 ns | 0.0521 ns | 0.0488 ns | 13.518 ns |  0.91 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.273 ns | 0.0193 ns | 0.0180 ns | 13.275 ns |  0.89 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Byte.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Byte.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Byte.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
