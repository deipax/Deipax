
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
                                             From_Bool | .NET Core 2.0 | 13.778 ns | 0.0197 ns | 0.0164 ns | 13.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.697 ns | 0.0138 ns | 0.0129 ns | 10.694 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.408 ns | 0.0152 ns | 0.0142 ns |  9.409 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 13.349 ns | 0.0196 ns | 0.0174 ns | 13.346 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.739 ns | 0.0142 ns | 0.0126 ns | 12.737 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.495 ns | 0.0221 ns | 0.0196 ns | 19.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.711 ns | 0.0511 ns | 0.0478 ns | 17.698 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.522 ns | 0.0268 ns | 0.0224 ns | 17.521 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 26.740 ns | 0.0731 ns | 0.0648 ns | 26.714 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 27.441 ns | 0.0848 ns | 0.0793 ns | 27.457 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.040 ns | 0.0148 ns | 0.0139 ns | 12.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.690 ns | 0.0350 ns | 0.0292 ns | 10.687 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.139 ns | 0.0077 ns | 0.0072 ns | 10.140 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.399 ns | 0.0259 ns | 0.0243 ns | 13.390 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.713 ns | 0.0161 ns | 0.0151 ns | 12.710 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.287 ns | 0.0371 ns | 0.0347 ns | 19.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.723 ns | 0.0137 ns | 0.0128 ns | 17.725 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.843 ns | 0.2261 ns | 0.2115 ns | 17.998 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 28.334 ns | 0.0927 ns | 0.0867 ns | 28.312 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.138 ns | 0.0747 ns | 0.0699 ns | 27.138 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.813 ns | 0.0082 ns | 0.0073 ns | 11.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.370 ns | 0.0122 ns | 0.0114 ns | 10.371 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 | 10.184 ns | 0.0148 ns | 0.0131 ns | 10.184 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.003 ns | 0.0224 ns | 0.0209 ns | 13.000 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.874 ns | 0.0138 ns | 0.0123 ns | 12.869 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.791 ns | 0.0510 ns | 0.0452 ns | 14.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.417 ns | 0.0709 ns | 0.0629 ns | 13.387 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.238 ns | 0.2201 ns | 0.1951 ns | 14.131 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 24.164 ns | 0.0352 ns | 0.0312 ns | 24.169 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 22.630 ns | 0.0332 ns | 0.0310 ns | 22.628 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.935 ns | 0.0542 ns | 0.0507 ns | 11.937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.396 ns | 0.0185 ns | 0.0173 ns | 10.390 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.701 ns | 0.0130 ns | 0.0115 ns |  9.698 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.234 ns | 0.0189 ns | 0.0168 ns | 12.233 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.315 ns | 0.0142 ns | 0.0132 ns | 12.316 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 24.413 ns | 0.0999 ns | 0.0885 ns | 24.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 25.621 ns | 0.0541 ns | 0.0451 ns | 25.603 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 29.693 ns | 0.0587 ns | 0.0520 ns | 29.689 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 37.101 ns | 0.0805 ns | 0.0753 ns | 37.096 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 36.975 ns | 0.0783 ns | 0.0732 ns | 36.952 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.364 ns | 0.0087 ns | 0.0068 ns | 11.364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.793 ns | 0.0107 ns | 0.0089 ns | 10.792 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.233 ns | 0.1636 ns | 0.1948 ns |  7.332 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 11.692 ns | 0.0160 ns | 0.0134 ns | 11.690 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.641 ns | 0.1392 ns | 0.1302 ns | 12.608 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.618 ns | 0.1041 ns | 0.0974 ns | 23.632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.601 ns | 0.0331 ns | 0.0309 ns | 25.594 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.990 ns | 0.0794 ns | 0.0743 ns | 28.022 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 34.997 ns | 0.0543 ns | 0.0508 ns | 35.006 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 35.919 ns | 0.1546 ns | 0.1447 ns | 35.935 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.368 ns | 0.0093 ns | 0.0087 ns | 11.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.282 ns | 0.0086 ns | 0.0077 ns | 10.284 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  6.593 ns | 0.0125 ns | 0.0117 ns |  6.593 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 14.809 ns | 0.0621 ns | 0.0581 ns | 14.783 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 11.736 ns | 0.0143 ns | 0.0133 ns | 11.730 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.898 ns | 0.0097 ns | 0.0081 ns | 16.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.387 ns | 0.0239 ns | 0.0200 ns | 13.383 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.208 ns | 0.0255 ns | 0.0226 ns | 13.218 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 22.038 ns | 0.0439 ns | 0.0367 ns | 22.041 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 24.101 ns | 0.0288 ns | 0.0241 ns | 24.111 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.926 ns | 0.0790 ns | 0.0739 ns | 11.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.463 ns | 0.0157 ns | 0.0147 ns | 10.460 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.673 ns | 0.0160 ns | 0.0150 ns |  9.671 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 13.080 ns | 0.0133 ns | 0.0124 ns | 13.078 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.003 ns | 0.0430 ns | 0.0381 ns | 13.009 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.090 ns | 0.0238 ns | 0.0223 ns | 20.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 19.034 ns | 0.0741 ns | 0.0619 ns | 19.004 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 18.748 ns | 0.6354 ns | 1.0790 ns | 18.154 ns |  0.98 |    0.06 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 27.446 ns | 0.1045 ns | 0.0977 ns | 27.411 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 28.021 ns | 0.0213 ns | 0.0199 ns | 28.023 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.252 ns | 0.0138 ns | 0.0115 ns | 12.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.710 ns | 0.0173 ns | 0.0153 ns | 10.712 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.936 ns | 0.2427 ns | 0.3069 ns | 11.050 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.365 ns | 0.0103 ns | 0.0092 ns | 13.365 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.420 ns | 0.0409 ns | 0.0363 ns | 13.409 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.196 ns | 0.0230 ns | 0.0192 ns | 21.196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.627 ns | 0.0221 ns | 0.0173 ns | 18.632 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.351 ns | 0.4134 ns | 0.8256 ns | 19.761 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 29.723 ns | 0.0254 ns | 0.0238 ns | 29.718 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 27.226 ns | 0.0914 ns | 0.0855 ns | 27.192 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.007 ns | 0.0094 ns | 0.0079 ns | 12.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.335 ns | 0.0122 ns | 0.0102 ns | 10.332 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.897 ns | 0.0046 ns | 0.0040 ns |  9.897 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.773 ns | 0.0611 ns | 0.0571 ns | 12.774 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.764 ns | 0.0140 ns | 0.0124 ns | 12.761 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.460 ns | 0.0180 ns | 0.0150 ns | 15.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.379 ns | 0.0186 ns | 0.0174 ns | 13.380 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.407 ns | 0.4526 ns | 0.5388 ns | 13.119 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.607 ns | 0.0269 ns | 0.0252 ns | 22.610 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 24.096 ns | 0.0806 ns | 0.0673 ns | 24.110 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.276 ns | 0.0113 ns | 0.0106 ns | 12.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.127 ns | 0.0149 ns | 0.0139 ns | 11.125 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.883 ns | 0.0107 ns | 0.0100 ns |  9.884 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.189 ns | 0.0158 ns | 0.0132 ns | 13.194 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.590 ns | 0.0502 ns | 0.0419 ns | 13.577 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 14.103 ns | 0.0127 ns | 0.0113 ns | 14.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 13.143 ns | 0.0134 ns | 0.0125 ns | 13.145 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.099 ns | 0.0122 ns | 0.0114 ns | 10.099 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.274 ns | 0.0210 ns | 0.0197 ns | 13.277 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.935 ns | 0.0274 ns | 0.0229 ns | 13.927 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.243 ns | 0.0159 ns | 0.0149 ns | 13.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.559 ns | 0.0198 ns | 0.0165 ns | 12.557 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.108 ns | 0.0126 ns | 0.0112 ns | 10.112 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.371 ns | 0.0581 ns | 0.0515 ns | 13.392 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.880 ns | 0.0142 ns | 0.0133 ns | 13.881 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.772 ns | 0.0186 ns | 0.0174 ns | 14.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.381 ns | 0.0117 ns | 0.0104 ns | 13.381 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.024 ns | 0.3472 ns | 0.6606 ns | 16.301 ns |  1.05 |    0.06 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.654 ns | 0.0251 ns | 0.0235 ns | 22.647 ns |  1.53 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 22.697 ns | 0.0293 ns | 0.0274 ns | 22.694 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 26.493 ns | 0.0332 ns | 0.0294 ns | 26.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 24.678 ns | 0.0453 ns | 0.0379 ns | 24.678 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.423 ns | 0.3256 ns | 0.5165 ns | 15.654 ns |  0.57 |    0.02 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 26.362 ns | 0.0201 ns | 0.0188 ns | 26.364 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.191 ns | 0.0326 ns | 0.0272 ns | 25.188 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.912 ns | 0.1150 ns | 0.1076 ns | 30.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 30.289 ns | 0.0716 ns | 0.0598 ns | 30.271 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.630 ns | 0.0231 ns | 0.0205 ns | 22.630 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 37.387 ns | 0.0351 ns | 0.0311 ns | 37.388 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.202 ns | 0.0388 ns | 0.0363 ns | 36.214 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.878 ns | 0.0574 ns | 0.0509 ns | 25.868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 26.758 ns | 0.0361 ns | 0.0338 ns | 26.755 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.442 ns | 0.0738 ns | 0.0690 ns | 19.420 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.118 ns | 0.0385 ns | 0.0341 ns | 26.110 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.869 ns | 0.0451 ns | 0.0422 ns | 26.863 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 31.047 ns | 0.0436 ns | 0.0408 ns | 31.066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.650 ns | 0.0629 ns | 0.0588 ns | 29.660 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.427 ns | 0.6114 ns | 0.8961 ns | 22.943 ns |  0.77 |    0.03 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 36.876 ns | 0.0423 ns | 0.0396 ns | 36.868 ns |  1.19 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 36.372 ns | 0.0361 ns | 0.0320 ns | 36.372 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.559 ns | 0.0256 ns | 0.0227 ns | 12.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.530 ns | 0.0295 ns | 0.0262 ns | 11.533 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.712 ns | 0.2086 ns | 0.1951 ns | 10.781 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.523 ns | 0.0128 ns | 0.0113 ns | 13.523 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.954 ns | 0.0139 ns | 0.0130 ns | 13.957 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.584 ns | 0.0149 ns | 0.0132 ns | 15.583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.577 ns | 0.0159 ns | 0.0149 ns | 13.571 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.633 ns | 0.0558 ns | 0.0522 ns | 13.605 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 25.156 ns | 0.0223 ns | 0.0186 ns | 25.153 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.894 ns | 0.1645 ns | 0.1538 ns | 22.956 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.043 ns | 0.0223 ns | 0.0198 ns | 15.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.082 ns | 0.0185 ns | 0.0173 ns | 13.077 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 13.004 ns | 0.0435 ns | 0.0407 ns | 12.993 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.356 ns | 0.0279 ns | 0.0261 ns | 15.358 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.692 ns | 0.0107 ns | 0.0095 ns | 15.690 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 22.144 ns | 0.0286 ns | 0.0254 ns | 22.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.248 ns | 0.0626 ns | 0.0555 ns | 20.258 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.320 ns | 0.0391 ns | 0.0365 ns | 20.322 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 30.959 ns | 0.0478 ns | 0.0447 ns | 30.959 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.051 ns | 0.0315 ns | 0.0279 ns | 29.055 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.656 ns | 0.0417 ns | 0.0390 ns | 16.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 15.286 ns | 0.0351 ns | 0.0328 ns | 15.274 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.942 ns | 0.0294 ns | 0.0275 ns | 12.935 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 19.797 ns | 0.0087 ns | 0.0072 ns | 19.796 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 18.357 ns | 0.0759 ns | 0.0710 ns | 18.390 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.124 ns | 0.0189 ns | 0.0177 ns | 22.125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.080 ns | 0.0518 ns | 0.0484 ns | 20.063 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.818 ns | 0.1916 ns | 0.1792 ns | 20.724 ns |  0.94 |    0.01 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 30.986 ns | 0.0654 ns | 0.0579 ns | 30.980 ns |  1.40 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 31.381 ns | 0.0558 ns | 0.0494 ns | 31.385 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.346 ns | 0.0127 ns | 0.0112 ns | 12.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.501 ns | 0.0348 ns | 0.0309 ns | 11.504 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.363 ns | 0.0154 ns | 0.0136 ns | 10.362 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.326 ns | 0.0522 ns | 0.0462 ns | 14.337 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.443 ns | 0.0178 ns | 0.0149 ns | 13.448 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.572 ns | 0.0427 ns | 0.0400 ns | 15.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.383 ns | 0.0144 ns | 0.0120 ns | 13.386 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.728 ns | 0.3168 ns | 0.3890 ns | 14.974 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 22.533 ns | 0.0290 ns | 0.0272 ns | 22.534 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.746 ns | 0.0842 ns | 0.0788 ns | 22.771 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 12.782 ns | 0.0162 ns | 0.0152 ns | 12.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 12.352 ns | 0.0192 ns | 0.0150 ns | 12.354 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.922 ns | 0.0675 ns | 0.0631 ns |  9.942 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.629 ns | 0.0175 ns | 0.0164 ns | 13.627 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.883 ns | 0.0126 ns | 0.0111 ns | 12.884 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.311 ns | 0.0719 ns | 0.0638 ns | 21.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.398 ns | 0.0144 ns | 0.0134 ns | 18.397 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 18.436 ns | 0.0220 ns | 0.0206 ns | 18.431 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 29.654 ns | 0.0430 ns | 0.0402 ns | 29.654 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.788 ns | 0.0395 ns | 0.0350 ns | 27.784 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.123 ns | 0.0126 ns | 0.0118 ns | 13.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.814 ns | 0.0142 ns | 0.0126 ns | 11.816 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.587 ns | 0.0181 ns | 0.0151 ns | 10.591 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.178 ns | 0.0298 ns | 0.0249 ns | 14.188 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.475 ns | 0.0681 ns | 0.0637 ns | 13.510 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.010 ns | 0.0221 ns | 0.0206 ns | 21.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.464 ns | 0.0578 ns | 0.0541 ns | 18.443 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.044 ns | 0.0668 ns | 0.0625 ns | 18.051 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.765 ns | 0.0408 ns | 0.0341 ns | 27.752 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.407 ns | 0.0725 ns | 0.0643 ns | 29.391 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.839 ns | 0.0323 ns | 0.0302 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.407 ns | 0.0086 ns | 0.0077 ns | 10.407 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.453 ns | 0.0152 ns | 0.0142 ns |  9.455 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.706 ns | 0.0132 ns | 0.0117 ns | 12.705 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.726 ns | 0.0237 ns | 0.0210 ns | 12.724 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.746 ns | 0.0198 ns | 0.0165 ns | 14.748 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.233 ns | 0.0149 ns | 0.0140 ns | 15.236 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.117 ns | 0.0289 ns | 0.0270 ns | 13.109 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 21.445 ns | 0.0330 ns | 0.0309 ns | 21.442 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 24.337 ns | 0.0384 ns | 0.0340 ns | 24.331 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.756 ns | 0.0160 ns | 0.0150 ns | 12.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 12.206 ns | 0.0996 ns | 0.0931 ns | 12.143 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.984 ns | 0.0179 ns | 0.0150 ns |  9.984 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.915 ns | 0.0169 ns | 0.0141 ns | 12.920 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.988 ns | 0.0417 ns | 0.0390 ns | 12.999 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.034 ns | 0.0202 ns | 0.0168 ns | 21.032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.196 ns | 0.0238 ns | 0.0223 ns | 18.192 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.437 ns | 0.0291 ns | 0.0258 ns | 18.443 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 29.319 ns | 0.0647 ns | 0.0605 ns | 29.310 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 27.731 ns | 0.0298 ns | 0.0279 ns | 27.736 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.270 ns | 0.0745 ns | 0.0660 ns | 13.266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 12.211 ns | 0.0143 ns | 0.0134 ns | 12.212 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.488 ns | 0.0455 ns | 0.0425 ns | 10.488 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.146 ns | 0.0793 ns | 0.0741 ns | 14.119 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.394 ns | 0.0187 ns | 0.0175 ns | 13.396 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.217 ns | 0.0239 ns | 0.0224 ns | 21.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.306 ns | 0.0574 ns | 0.0537 ns | 18.296 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.649 ns | 0.3929 ns | 0.5880 ns | 19.033 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.509 ns | 0.0377 ns | 0.0334 ns | 27.513 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 29.879 ns | 0.1683 ns | 0.1574 ns | 29.849 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.811 ns | 0.0159 ns | 0.0141 ns | 11.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.407 ns | 0.0134 ns | 0.0118 ns | 11.407 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.699 ns | 0.0295 ns | 0.0262 ns |  9.690 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.708 ns | 0.0249 ns | 0.0233 ns | 12.719 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.872 ns | 0.0233 ns | 0.0206 ns | 12.869 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.832 ns | 0.0145 ns | 0.0128 ns | 14.831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.389 ns | 0.0130 ns | 0.0122 ns | 14.387 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.147 ns | 0.0476 ns | 0.0397 ns | 14.152 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.634 ns | 0.0646 ns | 0.0572 ns | 22.618 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 24.363 ns | 0.0368 ns | 0.0326 ns | 24.365 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.847 ns | 0.0498 ns | 0.0465 ns | 12.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.903 ns | 0.0467 ns | 0.0437 ns | 12.880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.868 ns | 0.0129 ns | 0.0114 ns |  9.869 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.906 ns | 0.0104 ns | 0.0098 ns | 12.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.999 ns | 0.0279 ns | 0.0261 ns | 13.002 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 20.271 ns | 0.0266 ns | 0.0249 ns | 20.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.397 ns | 0.0241 ns | 0.0213 ns | 18.391 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 17.819 ns | 0.0459 ns | 0.0429 ns | 17.823 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.641 ns | 0.0352 ns | 0.0329 ns | 27.637 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 29.944 ns | 0.0358 ns | 0.0317 ns | 29.950 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.529 ns | 0.2055 ns | 0.1923 ns | 14.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.836 ns | 0.0182 ns | 0.0170 ns | 12.831 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.746 ns | 0.0551 ns | 0.0488 ns | 11.754 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.576 ns | 0.0224 ns | 0.0209 ns | 14.576 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 15.417 ns | 0.0292 ns | 0.0273 ns | 15.419 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.128 ns | 0.0259 ns | 0.0242 ns | 20.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.763 ns | 0.0822 ns | 0.0769 ns | 18.735 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.858 ns | 0.2931 ns | 0.2742 ns | 18.992 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.612 ns | 0.0473 ns | 0.0419 ns | 27.605 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.822 ns | 0.0326 ns | 0.0272 ns | 27.828 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.406 ns | 0.0189 ns | 0.0158 ns | 12.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.966 ns | 0.0122 ns | 0.0095 ns | 11.968 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.764 ns | 0.0067 ns | 0.0052 ns |  9.762 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.456 ns | 0.0162 ns | 0.0135 ns | 13.455 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.355 ns | 0.0146 ns | 0.0136 ns | 13.357 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.396 ns | 0.0189 ns | 0.0177 ns | 15.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.487 ns | 0.0594 ns | 0.0555 ns | 13.496 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.367 ns | 0.1275 ns | 0.1130 ns | 13.406 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 25.152 ns | 0.0325 ns | 0.0304 ns | 25.150 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 22.613 ns | 0.0518 ns | 0.0484 ns | 22.606 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.811 ns | 0.0163 ns | 0.0152 ns | 11.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.489 ns | 0.0182 ns | 0.0161 ns | 10.488 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.511 ns | 0.0482 ns | 0.0403 ns |  9.526 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 14.664 ns | 0.0169 ns | 0.0141 ns | 14.666 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.007 ns | 0.0211 ns | 0.0197 ns | 13.003 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.436 ns | 0.0737 ns | 0.0689 ns | 20.423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.008 ns | 0.0201 ns | 0.0188 ns | 18.008 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.816 ns | 0.0250 ns | 0.0221 ns | 17.819 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 29.317 ns | 0.0908 ns | 0.0849 ns | 29.283 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.238 ns | 0.0446 ns | 0.0417 ns | 27.234 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.004 ns | 0.0164 ns | 0.0137 ns | 12.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.731 ns | 0.0689 ns | 0.0644 ns | 10.766 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  9.941 ns | 0.0194 ns | 0.0181 ns |  9.944 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.285 ns | 0.0155 ns | 0.0137 ns | 13.288 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.352 ns | 0.0158 ns | 0.0140 ns | 13.358 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.801 ns | 0.0174 ns | 0.0163 ns | 19.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.999 ns | 0.0206 ns | 0.0192 ns | 17.999 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.390 ns | 0.0526 ns | 0.0466 ns | 17.393 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.600 ns | 0.0621 ns | 0.0581 ns | 27.602 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 29.840 ns | 0.0589 ns | 0.0522 ns | 29.848 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.091 ns | 0.0427 ns | 0.0379 ns | 12.105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.352 ns | 0.0153 ns | 0.0143 ns | 10.353 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.682 ns | 0.0160 ns | 0.0150 ns |  9.680 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.699 ns | 0.0097 ns | 0.0081 ns | 12.695 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.719 ns | 0.0163 ns | 0.0153 ns | 12.722 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.763 ns | 0.0221 ns | 0.0196 ns | 14.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.496 ns | 0.0447 ns | 0.0418 ns | 13.502 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.576 ns | 0.0177 ns | 0.0165 ns | 13.575 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 24.087 ns | 0.0494 ns | 0.0462 ns | 24.087 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.986 ns | 0.0413 ns | 0.0366 ns | 22.981 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.122 ns | 0.0135 ns | 0.0119 ns | 15.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.126 ns | 0.0355 ns | 0.0332 ns | 13.123 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 12.765 ns | 0.0835 ns | 0.0781 ns | 12.789 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.365 ns | 0.0255 ns | 0.0226 ns | 16.357 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.633 ns | 0.0258 ns | 0.0215 ns | 15.631 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 23.050 ns | 0.0976 ns | 0.0913 ns | 23.093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.104 ns | 0.0272 ns | 0.0254 ns | 20.110 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.228 ns | 0.2004 ns | 0.1874 ns | 20.123 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 30.253 ns | 0.0599 ns | 0.0531 ns | 30.240 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 32.275 ns | 0.0666 ns | 0.0623 ns | 32.263 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.981 ns | 0.0259 ns | 0.0242 ns | 14.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 14.520 ns | 0.0164 ns | 0.0146 ns | 14.518 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.911 ns | 0.0237 ns | 0.0221 ns | 12.916 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.291 ns | 0.0328 ns | 0.0274 ns | 15.290 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.431 ns | 0.0314 ns | 0.0263 ns | 15.424 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 23.109 ns | 0.0278 ns | 0.0246 ns | 23.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.280 ns | 0.0395 ns | 0.0330 ns | 20.277 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.671 ns | 0.0837 ns | 0.0699 ns | 20.681 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 30.297 ns | 0.0481 ns | 0.0426 ns | 30.281 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.295 ns | 0.1926 ns | 0.1802 ns | 30.248 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.159 ns | 0.0551 ns | 0.0515 ns | 12.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.496 ns | 0.0150 ns | 0.0133 ns | 10.491 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 | 10.130 ns | 0.0181 ns | 0.0170 ns | 10.127 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.919 ns | 0.0138 ns | 0.0129 ns | 12.918 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.010 ns | 0.0178 ns | 0.0157 ns | 13.014 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.401 ns | 0.0213 ns | 0.0178 ns | 15.397 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.187 ns | 0.0173 ns | 0.0162 ns | 14.186 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.341 ns | 0.3083 ns | 0.4220 ns | 14.538 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.603 ns | 0.0637 ns | 0.0596 ns | 22.591 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.367 ns | 0.0283 ns | 0.0265 ns | 24.363 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 60.578 ns | 0.0687 ns | 0.0609 ns | 60.566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 59.474 ns | 0.2051 ns | 0.1713 ns | 59.545 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 23.767 ns | 0.4956 ns | 0.6947 ns | 24.270 ns |  0.38 |    0.01 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.475 ns | 0.0841 ns | 0.0702 ns | 59.505 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 56.635 ns | 0.0570 ns | 0.0534 ns | 56.633 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 65.064 ns | 0.2851 ns | 0.2667 ns | 65.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 63.756 ns | 0.2826 ns | 0.2644 ns | 63.672 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 25.648 ns | 0.5311 ns | 0.6906 ns | 25.970 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 72.770 ns | 0.1032 ns | 0.0966 ns | 72.789 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 72.758 ns | 0.1635 ns | 0.1529 ns | 72.770 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.037 ns | 0.0134 ns | 0.0119 ns | 14.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.186 ns | 0.0256 ns | 0.0239 ns | 18.185 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.899 ns | 0.1012 ns | 0.0947 ns | 13.861 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.465 ns | 0.0308 ns | 0.0273 ns | 15.461 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.853 ns | 0.0153 ns | 0.0143 ns | 14.855 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.900 ns | 0.0170 ns | 0.0151 ns | 14.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.389 ns | 0.0180 ns | 0.0168 ns | 13.387 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.568 ns | 0.0318 ns | 0.0248 ns | 13.566 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 24.385 ns | 0.1454 ns | 0.1360 ns | 24.337 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 24.317 ns | 0.0308 ns | 0.0288 ns | 24.317 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.279 ns | 0.0119 ns | 0.0099 ns | 14.279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.515 ns | 0.1269 ns | 0.1187 ns | 18.470 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.826 ns | 0.0193 ns | 0.0181 ns | 13.822 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.738 ns | 0.0102 ns | 0.0090 ns | 14.741 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 15.652 ns | 0.0208 ns | 0.0194 ns | 15.652 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.887 ns | 0.0122 ns | 0.0108 ns | 11.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 11.205 ns | 0.0095 ns | 0.0089 ns | 11.206 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.646 ns | 0.0097 ns | 0.0091 ns |  9.648 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.675 ns | 0.0276 ns | 0.0245 ns | 14.668 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.604 ns | 0.0137 ns | 0.0115 ns | 13.603 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 19.822 ns | 0.0243 ns | 0.0228 ns | 19.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 19.531 ns | 0.0736 ns | 0.0652 ns | 19.538 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 18.155 ns | 0.0638 ns | 0.0597 ns | 18.146 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 29.543 ns | 0.0276 ns | 0.0215 ns | 29.540 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.138 ns | 0.0291 ns | 0.0258 ns | 27.141 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.086 ns | 0.0454 ns | 0.0425 ns | 12.067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.704 ns | 0.0133 ns | 0.0118 ns | 10.704 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  9.955 ns | 0.0522 ns | 0.0488 ns |  9.930 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.776 ns | 0.0126 ns | 0.0117 ns | 13.777 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 13.491 ns | 0.0204 ns | 0.0160 ns | 13.495 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.182 ns | 0.0205 ns | 0.0160 ns | 20.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.509 ns | 0.0203 ns | 0.0180 ns | 18.508 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.786 ns | 0.0300 ns | 0.0281 ns | 17.785 ns |  0.88 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 27.607 ns | 0.0471 ns | 0.0441 ns | 27.600 ns |  1.37 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.190 ns | 0.0550 ns | 0.0514 ns | 27.203 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 12.010 ns | 0.0107 ns | 0.0095 ns | 12.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.391 ns | 0.0378 ns | 0.0353 ns | 10.409 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 10.102 ns | 0.2231 ns | 0.2901 ns |  9.907 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.700 ns | 0.0087 ns | 0.0077 ns | 12.698 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.720 ns | 0.0132 ns | 0.0123 ns | 12.718 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.438 ns | 0.0155 ns | 0.0137 ns | 15.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.372 ns | 0.0210 ns | 0.0186 ns | 13.366 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.008 ns | 0.4379 ns | 0.7896 ns | 13.574 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 25.332 ns | 0.0796 ns | 0.0706 ns | 25.345 ns |  1.64 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 24.333 ns | 0.0313 ns | 0.0293 ns | 24.324 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.348 ns | 0.0141 ns | 0.0132 ns | 12.348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.459 ns | 0.0195 ns | 0.0182 ns | 10.454 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 | 10.290 ns | 0.2259 ns | 0.3311 ns | 10.411 ns |  0.82 |    0.04 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.030 ns | 0.0113 ns | 0.0106 ns | 13.032 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.889 ns | 0.0142 ns | 0.0126 ns | 12.890 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.845 ns | 0.0157 ns | 0.0139 ns | 19.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.383 ns | 0.0735 ns | 0.0688 ns | 18.356 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.978 ns | 0.1932 ns | 0.1807 ns | 18.038 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 28.982 ns | 0.0448 ns | 0.0419 ns | 28.991 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.150 ns | 0.0276 ns | 0.0230 ns | 29.153 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.004 ns | 0.0185 ns | 0.0154 ns | 11.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.878 ns | 0.0874 ns | 0.0775 ns | 10.871 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.373 ns | 0.0140 ns | 0.0131 ns | 10.372 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.362 ns | 0.0191 ns | 0.0179 ns | 13.364 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.395 ns | 0.0117 ns | 0.0110 ns | 13.396 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.276 ns | 0.0153 ns | 0.0127 ns | 21.274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.530 ns | 0.0206 ns | 0.0193 ns | 18.534 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.343 ns | 0.0621 ns | 0.0581 ns | 17.335 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.335 ns | 0.0279 ns | 0.0261 ns | 27.335 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.482 ns | 0.0344 ns | 0.0322 ns | 27.478 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.005 ns | 0.0135 ns | 0.0120 ns | 12.006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.383 ns | 0.0416 ns | 0.0389 ns | 10.393 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.444 ns | 0.0134 ns | 0.0119 ns |  9.444 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.844 ns | 0.0474 ns | 0.0420 ns | 12.854 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.737 ns | 0.0244 ns | 0.0191 ns | 12.741 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.244 ns | 0.0511 ns | 0.0478 ns | 16.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.772 ns | 0.0128 ns | 0.0107 ns | 13.771 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.176 ns | 0.0796 ns | 0.0744 ns | 13.209 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.550 ns | 0.0300 ns | 0.0250 ns | 22.548 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 22.550 ns | 0.0192 ns | 0.0171 ns | 22.554 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.538 ns | 0.0127 ns | 0.0119 ns | 13.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.645 ns | 0.0228 ns | 0.0213 ns | 11.643 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.681 ns | 0.0190 ns | 0.0168 ns |  9.681 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.909 ns | 0.0144 ns | 0.0128 ns | 12.908 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.881 ns | 0.0148 ns | 0.0131 ns | 12.884 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.850 ns | 0.0282 ns | 0.0235 ns | 20.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.830 ns | 0.0863 ns | 0.0807 ns | 18.810 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.999 ns | 0.0576 ns | 0.0539 ns | 17.991 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 29.283 ns | 0.0275 ns | 0.0257 ns | 29.283 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 27.913 ns | 0.0281 ns | 0.0249 ns | 27.914 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.862 ns | 0.0294 ns | 0.0261 ns | 13.856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.932 ns | 0.0403 ns | 0.0377 ns | 12.928 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.149 ns | 0.0161 ns | 0.0143 ns | 11.148 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.393 ns | 0.0503 ns | 0.0470 ns | 15.397 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.504 ns | 0.0130 ns | 0.0102 ns | 14.507 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.632 ns | 0.0631 ns | 0.0559 ns | 21.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.317 ns | 0.0396 ns | 0.0371 ns | 18.299 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.614 ns | 0.0400 ns | 0.0374 ns | 18.605 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 29.275 ns | 0.0658 ns | 0.0615 ns | 29.283 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.288 ns | 0.0459 ns | 0.0429 ns | 27.299 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.387 ns | 0.0134 ns | 0.0112 ns | 12.383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.847 ns | 0.0439 ns | 0.0389 ns | 12.835 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 | 10.130 ns | 0.0188 ns | 0.0157 ns | 10.126 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.086 ns | 0.0161 ns | 0.0150 ns | 14.081 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.331 ns | 0.0374 ns | 0.0350 ns | 13.343 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.402 ns | 0.0127 ns | 0.0113 ns | 15.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.409 ns | 0.0107 ns | 0.0100 ns | 14.408 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.368 ns | 0.2942 ns | 0.4312 ns | 13.113 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.721 ns | 0.0217 ns | 0.0203 ns | 22.722 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 22.169 ns | 0.0717 ns | 0.0670 ns | 22.174 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.802 ns | 0.0506 ns | 0.0449 ns | 14.787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.440 ns | 0.0482 ns | 0.0427 ns | 13.430 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 14.079 ns | 0.0497 ns | 0.0440 ns | 14.067 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 24.775 ns | 0.1559 ns | 0.1458 ns | 24.807 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 22.555 ns | 0.0456 ns | 0.0427 ns | 22.560 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.691 ns | 0.0110 ns | 0.0103 ns | 12.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.045 ns | 0.0104 ns | 0.0098 ns | 11.046 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.946 ns | 0.0115 ns | 0.0096 ns | 12.948 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.894 ns | 0.0182 ns | 0.0170 ns | 12.896 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.083 ns | 0.0543 ns | 0.0424 ns | 13.093 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.916 ns | 0.0687 ns | 0.0643 ns | 16.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 16.807 ns | 0.0145 ns | 0.0136 ns | 16.806 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.882 ns | 0.2358 ns | 0.2205 ns | 14.015 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.356 ns | 0.0191 ns | 0.0179 ns | 22.357 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 24.552 ns | 0.0362 ns | 0.0338 ns | 24.558 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.534 ns | 0.0285 ns | 0.0253 ns | 17.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.464 ns | 0.0223 ns | 0.0186 ns | 15.463 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.432 ns | 0.3311 ns | 0.4749 ns | 15.715 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.217 ns | 0.0756 ns | 0.0707 ns | 26.194 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 25.281 ns | 0.0492 ns | 0.0411 ns | 25.292 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.971 ns | 0.0412 ns | 0.0386 ns | 18.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.264 ns | 0.0173 ns | 0.0162 ns | 17.264 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.081 ns | 0.0258 ns | 0.0241 ns | 17.085 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.142 ns | 0.0473 ns | 0.0442 ns | 26.145 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.231 ns | 0.0371 ns | 0.0329 ns | 28.235 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.889 ns | 0.0538 ns | 0.0503 ns | 14.900 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.898 ns | 0.0229 ns | 0.0214 ns | 12.893 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.102 ns | 0.0147 ns | 0.0137 ns | 13.100 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.338 ns | 0.0304 ns | 0.0254 ns | 24.342 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 22.589 ns | 0.0611 ns | 0.0572 ns | 22.608 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.779 ns | 0.0234 ns | 0.0207 ns | 14.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.495 ns | 0.0140 ns | 0.0124 ns | 13.497 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.139 ns | 0.0537 ns | 0.0476 ns | 13.122 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.770 ns | 0.0485 ns | 0.0430 ns | 22.779 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 22.600 ns | 0.0299 ns | 0.0265 ns | 22.594 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.063 ns | 0.0138 ns | 0.0123 ns | 14.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.199 ns | 0.0139 ns | 0.0130 ns | 12.199 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.608 ns | 0.0656 ns | 0.0582 ns | 12.596 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.951 ns | 0.0202 ns | 0.0189 ns | 14.956 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.131 ns | 0.0172 ns | 0.0161 ns | 15.131 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.562 ns | 0.0235 ns | 0.0208 ns | 16.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.237 ns | 0.0133 ns | 0.0124 ns | 15.234 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.390 ns | 0.0149 ns | 0.0139 ns | 15.393 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.326 ns | 0.0444 ns | 0.0416 ns | 24.324 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 23.713 ns | 0.0312 ns | 0.0292 ns | 23.717 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.147 ns | 0.0134 ns | 0.0119 ns | 14.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.342 ns | 0.0288 ns | 0.0256 ns | 12.344 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.527 ns | 0.0659 ns | 0.0617 ns | 12.553 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.416 ns | 0.0527 ns | 0.0493 ns | 14.389 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.005 ns | 0.0489 ns | 0.0434 ns | 14.993 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 16.367 ns | 0.0309 ns | 0.0274 ns | 16.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.377 ns | 0.0140 ns | 0.0131 ns | 13.379 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 16.902 ns | 0.3622 ns | 0.9154 ns | 17.188 ns |  0.95 |    0.10 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 24.421 ns | 0.0318 ns | 0.0297 ns | 24.412 ns |  1.49 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 22.737 ns | 0.0219 ns | 0.0183 ns | 22.738 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.316 ns | 0.0360 ns | 0.0336 ns | 20.310 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.249 ns | 0.0457 ns | 0.0405 ns | 16.234 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.555 ns | 0.2693 ns | 0.2519 ns | 13.710 ns |  0.67 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.490 ns | 0.0608 ns | 0.0539 ns | 19.496 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 20.804 ns | 0.0314 ns | 0.0262 ns | 20.811 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.581 ns | 0.0390 ns | 0.0304 ns | 19.578 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.649 ns | 0.0271 ns | 0.0240 ns | 17.648 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.021 ns | 0.2753 ns | 0.2575 ns | 17.842 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 28.889 ns | 0.1129 ns | 0.1001 ns | 28.913 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 28.505 ns | 0.0273 ns | 0.0228 ns | 28.509 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.945 ns | 0.0308 ns | 0.0257 ns | 19.944 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.267 ns | 0.0236 ns | 0.0221 ns | 16.265 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.156 ns | 0.0679 ns | 0.0635 ns | 14.168 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.266 ns | 0.0205 ns | 0.0182 ns | 24.266 ns |  1.22 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.573 ns | 0.0336 ns | 0.0314 ns | 24.576 ns |  1.23 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.021 ns | 0.0229 ns | 0.0203 ns | 19.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.525 ns | 0.0598 ns | 0.0499 ns | 17.518 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.510 ns | 0.0231 ns | 0.0205 ns | 17.503 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.882 ns | 0.0440 ns | 0.0368 ns | 26.879 ns |  1.41 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.671 ns | 0.0370 ns | 0.0346 ns | 26.680 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.925 ns | 0.0094 ns | 0.0079 ns | 13.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.084 ns | 0.0541 ns | 0.0480 ns | 12.100 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.895 ns | 0.0130 ns | 0.0122 ns |  9.893 ns |  0.71 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 18.330 ns | 0.0206 ns | 0.0183 ns | 18.330 ns |  1.32 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.091 ns | 0.0914 ns | 0.0855 ns | 19.071 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.968 ns | 0.0226 ns | 0.0200 ns | 14.967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.380 ns | 0.0169 ns | 0.0158 ns | 13.377 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.152 ns | 0.0577 ns | 0.0511 ns | 14.167 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.508 ns | 0.0316 ns | 0.0280 ns | 22.504 ns |  1.50 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.374 ns | 0.0781 ns | 0.0692 ns | 24.350 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.147 ns | 0.0389 ns | 0.0364 ns | 13.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.312 ns | 0.0093 ns | 0.0082 ns | 10.310 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.230 ns | 0.0176 ns | 0.0156 ns |  9.226 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.223 ns | 0.0197 ns | 0.0175 ns | 12.225 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.882 ns | 0.0136 ns | 0.0121 ns | 12.882 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 20.238 ns | 0.0185 ns | 0.0173 ns | 20.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.983 ns | 0.0922 ns | 0.0817 ns | 16.024 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.963 ns | 0.0281 ns | 0.0263 ns | 14.954 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 24.305 ns | 0.0294 ns | 0.0275 ns | 24.303 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 26.731 ns | 0.0217 ns | 0.0192 ns | 26.725 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.126 ns | 0.0160 ns | 0.0142 ns | 13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.308 ns | 0.0111 ns | 0.0098 ns | 10.306 ns |  0.79 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.264 ns | 0.0633 ns | 0.0592 ns |  9.228 ns |  0.71 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.316 ns | 0.0325 ns | 0.0288 ns | 12.317 ns |  0.94 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 12.874 ns | 0.0105 ns | 0.0093 ns | 12.874 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.367 ns | 0.1069 ns | 0.1000 ns | 17.307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.878 ns | 0.0137 ns | 0.0128 ns | 16.878 ns |  0.97 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.027 ns | 0.3648 ns | 0.5786 ns | 17.320 ns |  0.96 |    0.04 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 25.816 ns | 0.0370 ns | 0.0346 ns | 25.803 ns |  1.49 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 25.911 ns | 0.0413 ns | 0.0386 ns | 25.914 ns |  1.49 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.119 ns | 0.0118 ns | 0.0105 ns | 13.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.319 ns | 0.0253 ns | 0.0211 ns | 10.313 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.234 ns | 0.0161 ns | 0.0151 ns |  9.235 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.206 ns | 0.0218 ns | 0.0204 ns | 12.199 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.976 ns | 0.0342 ns | 0.0320 ns | 12.985 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.405 ns | 0.0176 ns | 0.0156 ns | 15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.379 ns | 0.0127 ns | 0.0118 ns | 13.375 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.903 ns | 0.2245 ns | 0.2100 ns | 14.010 ns |  0.90 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.488 ns | 0.0298 ns | 0.0279 ns | 22.493 ns |  1.46 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.276 ns | 0.0336 ns | 0.0298 ns | 22.269 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 12.769 ns | 0.0169 ns | 0.0141 ns | 12.775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.767 ns | 0.0172 ns | 0.0161 ns | 11.767 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.701 ns | 0.0393 ns | 0.0368 ns |  9.684 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.896 ns | 0.0119 ns | 0.0112 ns | 12.893 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.909 ns | 0.0103 ns | 0.0086 ns | 12.909 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.407 ns | 0.0686 ns | 0.0573 ns | 49.408 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 45.071 ns | 0.1640 ns | 0.1534 ns | 45.031 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 41.136 ns | 0.5014 ns | 0.4187 ns | 41.243 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 57.609 ns | 0.0798 ns | 0.0708 ns | 57.593 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 51.459 ns | 0.0821 ns | 0.0768 ns | 51.447 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.613 ns | 0.0177 ns | 0.0157 ns | 14.616 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.083 ns | 0.0445 ns | 0.0417 ns | 13.101 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.160 ns | 0.0121 ns | 0.0113 ns | 10.157 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.382 ns | 0.0213 ns | 0.0188 ns | 13.383 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 16.887 ns | 0.0160 ns | 0.0141 ns | 16.889 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 47.546 ns | 0.0499 ns | 0.0443 ns | 47.555 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 43.818 ns | 0.1139 ns | 0.1010 ns | 43.839 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.560 ns | 0.6574 ns | 0.6149 ns | 41.800 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 51.127 ns | 0.1500 ns | 0.1403 ns | 51.110 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 52.388 ns | 0.0708 ns | 0.0662 ns | 52.386 ns |  1.10 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.333 ns | 0.0095 ns | 0.0080 ns | 14.333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.499 ns | 0.0107 ns | 0.0100 ns | 11.500 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.462 ns | 0.0140 ns | 0.0131 ns |  9.459 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.535 ns | 0.0514 ns | 0.0481 ns | 13.552 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.955 ns | 0.0444 ns | 0.0393 ns | 12.961 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.410 ns | 0.0196 ns | 0.0183 ns | 15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.945 ns | 0.0532 ns | 0.0498 ns | 13.923 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.123 ns | 0.0211 ns | 0.0187 ns | 13.123 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.626 ns | 0.0260 ns | 0.0243 ns | 22.620 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 25.945 ns | 0.1000 ns | 0.0935 ns | 26.000 ns |  1.68 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.104 ns | 0.0782 ns | 0.0732 ns | 14.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.201 ns | 0.0123 ns | 0.0115 ns | 12.197 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.592 ns | 0.0406 ns | 0.0380 ns | 12.600 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.988 ns | 0.0156 ns | 0.0138 ns | 14.988 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.267 ns | 0.0198 ns | 0.0176 ns | 14.264 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 18.330 ns | 0.0248 ns | 0.0220 ns | 18.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.767 ns | 0.0151 ns | 0.0141 ns | 15.766 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.174 ns | 0.0162 ns | 0.0151 ns | 15.175 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.706 ns | 0.0601 ns | 0.0533 ns | 24.718 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.892 ns | 0.0793 ns | 0.0741 ns | 24.913 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.051 ns | 0.0169 ns | 0.0159 ns | 14.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.243 ns | 0.0309 ns | 0.0289 ns | 12.235 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.687 ns | 0.2750 ns | 0.2824 ns | 12.478 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.957 ns | 0.0233 ns | 0.0206 ns | 14.960 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 16.569 ns | 0.1002 ns | 0.0938 ns | 16.610 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.402 ns | 0.0195 ns | 0.0173 ns | 15.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.385 ns | 0.0219 ns | 0.0194 ns | 13.378 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.684 ns | 0.0516 ns | 0.0403 ns | 13.674 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.547 ns | 0.0309 ns | 0.0258 ns | 22.548 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.644 ns | 0.0371 ns | 0.0347 ns | 22.643 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 41.131 ns | 0.0377 ns | 0.0315 ns | 41.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.906 ns | 0.0474 ns | 0.0443 ns | 38.917 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 39.039 ns | 0.0540 ns | 0.0506 ns | 39.043 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.989 ns | 0.0355 ns | 0.0314 ns | 40.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 42.007 ns | 0.0484 ns | 0.0452 ns | 41.996 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.128 ns | 0.0342 ns | 0.0286 ns | 17.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 17.713 ns | 0.0267 ns | 0.0209 ns | 17.711 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.201 ns | 0.0311 ns | 0.0276 ns | 15.197 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 23.845 ns | 0.1125 ns | 0.1052 ns | 23.815 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 24.174 ns | 0.0969 ns | 0.0906 ns | 24.200 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 43.044 ns | 0.0734 ns | 0.0650 ns | 43.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.091 ns | 0.0476 ns | 0.0446 ns | 39.082 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 38.359 ns | 0.1038 ns | 0.0920 ns | 38.352 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.008 ns | 0.0416 ns | 0.0347 ns | 41.006 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 41.553 ns | 0.0671 ns | 0.0595 ns | 41.551 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.266 ns | 0.0195 ns | 0.0182 ns | 17.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.261 ns | 0.0176 ns | 0.0165 ns | 16.258 ns |  0.94 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.214 ns | 0.0469 ns | 0.0438 ns | 15.194 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 25.849 ns | 0.0493 ns | 0.0437 ns | 25.852 ns |  1.50 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 26.159 ns | 0.0277 ns | 0.0259 ns | 26.159 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.938 ns | 0.0569 ns | 0.0504 ns | 42.934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.252 ns | 0.0936 ns | 0.0830 ns | 39.234 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 38.356 ns | 0.0424 ns | 0.0396 ns | 38.352 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 41.377 ns | 0.1033 ns | 0.0863 ns | 41.394 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 41.964 ns | 0.1918 ns | 0.1794 ns | 42.047 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.429 ns | 0.0278 ns | 0.0260 ns | 15.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.575 ns | 0.1027 ns | 0.0858 ns | 13.628 ns |  0.88 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.175 ns | 0.0510 ns | 0.0477 ns | 13.196 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 25.068 ns | 0.0423 ns | 0.0375 ns | 25.056 ns |  1.62 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.681 ns | 0.0825 ns | 0.0772 ns | 22.654 ns |  1.47 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ByteNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_ByteNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
