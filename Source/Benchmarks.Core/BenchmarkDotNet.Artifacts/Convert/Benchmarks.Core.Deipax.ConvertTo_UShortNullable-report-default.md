
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
                                             From_Bool | .NET Core 2.0 | 13.433 ns | 0.0335 ns | 0.0297 ns | 13.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.800 ns | 0.0237 ns | 0.0222 ns | 11.800 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.691 ns | 0.0191 ns | 0.0169 ns |  9.688 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.216 ns | 0.0218 ns | 0.0204 ns | 12.215 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 12.238 ns | 0.0174 ns | 0.0154 ns | 12.243 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 22.238 ns | 0.0195 ns | 0.0182 ns | 22.245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 17.738 ns | 0.0277 ns | 0.0259 ns | 17.731 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 18.126 ns | 0.0412 ns | 0.0386 ns | 18.132 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.235 ns | 0.1158 ns | 0.1083 ns | 27.264 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 28.807 ns | 0.0447 ns | 0.0418 ns | 28.824 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.053 ns | 0.0154 ns | 0.0144 ns | 12.050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.471 ns | 0.0182 ns | 0.0170 ns | 11.471 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.529 ns | 0.2304 ns | 0.2742 ns | 10.382 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.734 ns | 0.0352 ns | 0.0329 ns | 12.743 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.697 ns | 0.0158 ns | 0.0140 ns | 12.694 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.192 ns | 0.1382 ns | 0.1293 ns | 20.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.745 ns | 0.0210 ns | 0.0197 ns | 17.747 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.637 ns | 0.0480 ns | 0.0449 ns | 17.635 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 26.834 ns | 0.0543 ns | 0.0508 ns | 26.825 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 27.944 ns | 0.0495 ns | 0.0463 ns | 27.945 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.853 ns | 0.0099 ns | 0.0088 ns | 11.853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.413 ns | 0.0121 ns | 0.0094 ns | 10.412 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.693 ns | 0.0112 ns | 0.0099 ns |  9.694 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.176 ns | 0.0142 ns | 0.0133 ns | 13.169 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.707 ns | 0.0152 ns | 0.0142 ns | 12.703 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.494 ns | 0.0268 ns | 0.0238 ns | 15.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.809 ns | 0.0174 ns | 0.0162 ns | 14.814 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.172 ns | 0.3243 ns | 0.4329 ns | 14.888 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 22.664 ns | 0.0437 ns | 0.0408 ns | 22.672 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 21.945 ns | 0.0694 ns | 0.0649 ns | 21.943 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.820 ns | 0.0100 ns | 0.0093 ns | 11.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.393 ns | 0.0158 ns | 0.0140 ns | 10.399 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.689 ns | 0.0106 ns | 0.0099 ns |  9.687 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.216 ns | 0.0199 ns | 0.0156 ns | 12.209 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.368 ns | 0.0633 ns | 0.0592 ns | 12.343 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 20.144 ns | 0.0247 ns | 0.0219 ns | 20.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 17.521 ns | 0.0255 ns | 0.0213 ns | 17.528 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.356 ns | 0.0460 ns | 0.0384 ns | 17.366 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 27.665 ns | 0.0327 ns | 0.0290 ns | 27.664 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 30.149 ns | 0.0265 ns | 0.0222 ns | 30.150 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 12.506 ns | 0.0160 ns | 0.0142 ns | 12.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.652 ns | 0.0122 ns | 0.0108 ns | 10.653 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  9.939 ns | 0.0130 ns | 0.0108 ns |  9.940 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.438 ns | 0.0306 ns | 0.0287 ns | 13.428 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 12.703 ns | 0.0116 ns | 0.0097 ns | 12.703 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.138 ns | 0.0272 ns | 0.0241 ns | 20.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.538 ns | 0.0220 ns | 0.0206 ns | 17.540 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.834 ns | 0.0550 ns | 0.0515 ns | 17.843 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.093 ns | 0.1151 ns | 0.1077 ns | 27.050 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 27.769 ns | 0.1149 ns | 0.0959 ns | 27.784 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 14.024 ns | 0.0134 ns | 0.0125 ns | 14.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 12.154 ns | 0.0112 ns | 0.0105 ns | 12.153 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.911 ns | 0.0110 ns | 0.0102 ns |  9.912 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 13.626 ns | 0.0118 ns | 0.0105 ns | 13.624 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.692 ns | 0.0152 ns | 0.0143 ns | 12.690 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.466 ns | 0.0210 ns | 0.0175 ns | 15.462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.392 ns | 0.0166 ns | 0.0155 ns | 13.392 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.402 ns | 0.1277 ns | 0.1195 ns | 13.447 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 24.205 ns | 0.0418 ns | 0.0391 ns | 24.202 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 22.746 ns | 0.0463 ns | 0.0434 ns | 22.734 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.826 ns | 0.0319 ns | 0.0266 ns | 11.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.408 ns | 0.0078 ns | 0.0073 ns | 10.410 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.471 ns | 0.0081 ns | 0.0068 ns |  9.472 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.912 ns | 0.0264 ns | 0.0221 ns | 12.906 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 13.657 ns | 0.0138 ns | 0.0123 ns | 13.657 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 20.743 ns | 0.0166 ns | 0.0147 ns | 20.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.417 ns | 0.0198 ns | 0.0175 ns | 18.421 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.948 ns | 0.0455 ns | 0.0380 ns | 17.952 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 28.572 ns | 0.1261 ns | 0.1118 ns | 28.604 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 28.551 ns | 0.0285 ns | 0.0238 ns | 28.552 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.889 ns | 0.0108 ns | 0.0101 ns | 11.891 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 11.622 ns | 0.0159 ns | 0.0141 ns | 11.617 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.120 ns | 0.0141 ns | 0.0132 ns | 10.118 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.733 ns | 0.0340 ns | 0.0301 ns | 12.728 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.696 ns | 0.0335 ns | 0.0297 ns | 12.693 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.998 ns | 0.0286 ns | 0.0267 ns | 19.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.412 ns | 0.0154 ns | 0.0144 ns | 18.416 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.675 ns | 0.1135 ns | 0.1062 ns | 17.656 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 28.332 ns | 0.0312 ns | 0.0260 ns | 28.337 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 26.833 ns | 0.1655 ns | 0.1548 ns | 26.931 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.867 ns | 0.0126 ns | 0.0112 ns | 11.864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 12.225 ns | 0.0107 ns | 0.0095 ns | 12.226 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.889 ns | 0.0135 ns | 0.0126 ns |  9.890 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.754 ns | 0.0454 ns | 0.0424 ns | 12.738 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.698 ns | 0.0140 ns | 0.0131 ns | 12.697 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.804 ns | 0.0124 ns | 0.0110 ns | 14.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.487 ns | 0.0177 ns | 0.0148 ns | 15.482 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.778 ns | 0.0305 ns | 0.0286 ns | 14.776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 22.853 ns | 0.0301 ns | 0.0281 ns | 22.849 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 22.606 ns | 0.0487 ns | 0.0432 ns | 22.624 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.288 ns | 0.0139 ns | 0.0123 ns | 12.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.210 ns | 0.0557 ns | 0.0521 ns | 11.239 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  9.710 ns | 0.0179 ns | 0.0168 ns |  9.713 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 14.219 ns | 0.0331 ns | 0.0309 ns | 14.214 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.684 ns | 0.0154 ns | 0.0144 ns | 13.686 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.960 ns | 0.0162 ns | 0.0144 ns | 12.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.901 ns | 0.0191 ns | 0.0179 ns | 11.901 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 | 10.150 ns | 0.0129 ns | 0.0115 ns | 10.151 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.360 ns | 0.0401 ns | 0.0335 ns | 13.368 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.875 ns | 0.0402 ns | 0.0376 ns | 13.870 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.685 ns | 0.0216 ns | 0.0202 ns | 12.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.886 ns | 0.0136 ns | 0.0121 ns | 11.886 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.146 ns | 0.0234 ns | 0.0208 ns | 10.145 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.390 ns | 0.0131 ns | 0.0122 ns | 13.390 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.815 ns | 0.0166 ns | 0.0155 ns | 13.822 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.516 ns | 0.0135 ns | 0.0120 ns | 14.512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.382 ns | 0.0142 ns | 0.0126 ns | 13.384 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.849 ns | 0.1350 ns | 0.1263 ns | 14.781 ns |  1.02 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 22.594 ns | 0.0588 ns | 0.0550 ns | 22.604 ns |  1.56 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 25.137 ns | 0.0343 ns | 0.0321 ns | 25.135 ns |  1.73 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 25.382 ns | 0.0143 ns | 0.0127 ns | 25.379 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.581 ns | 0.0863 ns | 0.0765 ns | 23.613 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 15.097 ns | 0.2107 ns | 0.1971 ns | 15.101 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.514 ns | 0.0193 ns | 0.0171 ns | 24.520 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 24.720 ns | 0.1459 ns | 0.1293 ns | 24.761 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.729 ns | 0.0359 ns | 0.0336 ns | 30.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.614 ns | 0.0186 ns | 0.0174 ns | 29.614 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.299 ns | 0.0218 ns | 0.0193 ns | 22.298 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 36.730 ns | 0.0515 ns | 0.0482 ns | 36.716 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 36.623 ns | 0.0532 ns | 0.0498 ns | 36.630 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.675 ns | 0.0277 ns | 0.0245 ns | 25.669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 24.082 ns | 0.0228 ns | 0.0190 ns | 24.091 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 19.170 ns | 0.0411 ns | 0.0343 ns | 19.165 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 26.157 ns | 0.0324 ns | 0.0303 ns | 26.174 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 26.181 ns | 0.0201 ns | 0.0188 ns | 26.178 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.598 ns | 0.0459 ns | 0.0429 ns | 30.591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 30.352 ns | 0.0437 ns | 0.0387 ns | 30.344 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 23.493 ns | 0.4891 ns | 0.7014 ns | 22.944 ns |  0.78 |    0.02 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 37.298 ns | 0.0911 ns | 0.0761 ns | 37.296 ns |  1.22 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 36.503 ns | 0.0709 ns | 0.0628 ns | 36.495 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.572 ns | 0.0130 ns | 0.0122 ns | 12.571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.778 ns | 0.0144 ns | 0.0135 ns | 11.781 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.199 ns | 0.0105 ns | 0.0098 ns | 10.200 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.142 ns | 0.0217 ns | 0.0192 ns | 14.143 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.565 ns | 0.0272 ns | 0.0255 ns | 13.563 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.954 ns | 0.0139 ns | 0.0108 ns | 15.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.421 ns | 0.0127 ns | 0.0113 ns | 13.421 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.116 ns | 0.0194 ns | 0.0162 ns | 13.116 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 24.258 ns | 0.0828 ns | 0.0775 ns | 24.254 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 22.608 ns | 0.0426 ns | 0.0398 ns | 22.611 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 15.829 ns | 0.0217 ns | 0.0203 ns | 15.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 13.720 ns | 0.0205 ns | 0.0182 ns | 13.722 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 12.460 ns | 0.0134 ns | 0.0119 ns | 12.462 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net461 | 15.408 ns | 0.0201 ns | 0.0188 ns | 15.406 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 15.457 ns | 0.0403 ns | 0.0377 ns | 15.468 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 21.239 ns | 0.0279 ns | 0.0261 ns | 21.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 20.175 ns | 0.0258 ns | 0.0241 ns | 20.167 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 20.267 ns | 0.0368 ns | 0.0344 ns | 20.267 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 29.522 ns | 0.0411 ns | 0.0384 ns | 29.529 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 29.844 ns | 0.0513 ns | 0.0480 ns | 29.846 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 16.622 ns | 0.0253 ns | 0.0237 ns | 16.627 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 15.152 ns | 0.2215 ns | 0.2072 ns | 15.162 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.922 ns | 0.0098 ns | 0.0086 ns | 12.922 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 17.015 ns | 0.0257 ns | 0.0240 ns | 17.012 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 17.069 ns | 0.0237 ns | 0.0210 ns | 17.067 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.151 ns | 0.0164 ns | 0.0153 ns | 22.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.495 ns | 0.0231 ns | 0.0205 ns | 20.491 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.401 ns | 0.0945 ns | 0.0884 ns | 21.384 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 30.002 ns | 0.0632 ns | 0.0591 ns | 29.999 ns |  1.35 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 31.976 ns | 0.1003 ns | 0.0889 ns | 31.996 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.468 ns | 0.0084 ns | 0.0079 ns | 13.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.449 ns | 0.0103 ns | 0.0097 ns | 11.449 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.156 ns | 0.0160 ns | 0.0142 ns | 10.157 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 14.324 ns | 0.0090 ns | 0.0084 ns | 14.325 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 14.169 ns | 0.0206 ns | 0.0193 ns | 14.161 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.812 ns | 0.0275 ns | 0.0257 ns | 14.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.184 ns | 0.0218 ns | 0.0193 ns | 14.181 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.343 ns | 0.3300 ns | 0.4052 ns | 15.326 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 24.440 ns | 0.0587 ns | 0.0520 ns | 24.447 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 24.316 ns | 0.1018 ns | 0.0952 ns | 24.360 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 13.168 ns | 0.0120 ns | 0.0112 ns | 13.162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.304 ns | 0.0207 ns | 0.0183 ns | 11.297 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.488 ns | 0.0124 ns | 0.0104 ns |  9.487 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.614 ns | 0.0176 ns | 0.0165 ns | 13.614 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.972 ns | 0.0109 ns | 0.0097 ns | 12.973 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 20.444 ns | 0.0603 ns | 0.0470 ns | 20.455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.033 ns | 0.0215 ns | 0.0201 ns | 18.035 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.588 ns | 0.0382 ns | 0.0319 ns | 17.582 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 29.194 ns | 0.0245 ns | 0.0229 ns | 29.192 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.623 ns | 0.0342 ns | 0.0303 ns | 27.635 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 12.083 ns | 0.0307 ns | 0.0287 ns | 12.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 14.386 ns | 0.0377 ns | 0.0353 ns | 14.396 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.233 ns | 0.0464 ns | 0.0434 ns | 10.229 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 14.943 ns | 0.0351 ns | 0.0312 ns | 14.936 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 13.448 ns | 0.0568 ns | 0.0531 ns | 13.418 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.146 ns | 0.0162 ns | 0.0152 ns | 19.151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.733 ns | 0.0267 ns | 0.0237 ns | 18.733 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.570 ns | 0.0246 ns | 0.0205 ns | 17.576 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.287 ns | 0.0242 ns | 0.0215 ns | 27.287 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 27.665 ns | 0.0321 ns | 0.0268 ns | 27.675 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.076 ns | 0.0144 ns | 0.0135 ns | 12.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.357 ns | 0.0131 ns | 0.0122 ns | 10.353 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.660 ns | 0.0124 ns | 0.0110 ns |  9.661 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.846 ns | 0.0152 ns | 0.0142 ns | 12.844 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.733 ns | 0.0112 ns | 0.0105 ns | 12.736 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.537 ns | 0.0097 ns | 0.0086 ns | 14.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.776 ns | 0.0127 ns | 0.0119 ns | 13.777 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.695 ns | 0.0174 ns | 0.0145 ns | 13.691 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.599 ns | 0.0243 ns | 0.0228 ns | 22.595 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 22.905 ns | 0.2516 ns | 0.2353 ns | 22.878 ns |  1.58 |    0.02 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.839 ns | 0.0132 ns | 0.0123 ns | 12.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.514 ns | 0.0115 ns | 0.0096 ns | 11.512 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 | 10.121 ns | 0.0088 ns | 0.0082 ns | 10.122 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.341 ns | 0.0125 ns | 0.0117 ns | 13.339 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 15.311 ns | 0.0844 ns | 0.0790 ns | 15.341 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 19.415 ns | 0.0303 ns | 0.0283 ns | 19.422 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 18.714 ns | 0.0292 ns | 0.0228 ns | 18.706 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 18.029 ns | 0.0337 ns | 0.0315 ns | 18.023 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 29.335 ns | 0.0618 ns | 0.0548 ns | 29.351 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 29.673 ns | 0.0374 ns | 0.0332 ns | 29.670 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.199 ns | 0.0174 ns | 0.0163 ns | 13.198 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.931 ns | 0.0139 ns | 0.0130 ns | 11.931 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 | 10.164 ns | 0.0159 ns | 0.0149 ns | 10.162 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 14.200 ns | 0.0154 ns | 0.0136 ns | 14.200 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 13.405 ns | 0.0121 ns | 0.0108 ns | 13.408 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.401 ns | 0.0334 ns | 0.0279 ns | 19.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.897 ns | 0.0448 ns | 0.0397 ns | 18.892 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.181 ns | 0.0341 ns | 0.0319 ns | 18.182 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 27.505 ns | 0.0200 ns | 0.0187 ns | 27.509 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 27.498 ns | 0.1129 ns | 0.1056 ns | 27.549 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.884 ns | 0.0161 ns | 0.0151 ns | 11.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.406 ns | 0.0174 ns | 0.0145 ns | 10.407 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  9.695 ns | 0.0105 ns | 0.0093 ns |  9.694 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 13.524 ns | 0.0701 ns | 0.0655 ns | 13.499 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 12.737 ns | 0.0120 ns | 0.0107 ns | 12.740 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.433 ns | 0.0067 ns | 0.0056 ns | 15.433 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.515 ns | 0.0100 ns | 0.0089 ns | 13.516 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.041 ns | 1.0178 ns | 1.0452 ns | 13.464 ns |  0.92 |    0.08 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.679 ns | 0.0228 ns | 0.0191 ns | 22.680 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 22.647 ns | 0.0457 ns | 0.0428 ns | 22.649 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.150 ns | 0.1134 ns | 0.1060 ns | 13.156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 11.961 ns | 0.0142 ns | 0.0133 ns | 11.961 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 | 10.147 ns | 0.0139 ns | 0.0123 ns | 10.144 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 14.117 ns | 0.0256 ns | 0.0227 ns | 14.117 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.021 ns | 0.0576 ns | 0.0539 ns | 13.051 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.414 ns | 0.0276 ns | 0.0245 ns | 19.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.208 ns | 0.0154 ns | 0.0137 ns | 18.209 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 19.264 ns | 0.0384 ns | 0.0359 ns | 19.268 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.561 ns | 0.0375 ns | 0.0351 ns | 27.560 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.585 ns | 0.0320 ns | 0.0299 ns | 27.584 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.163 ns | 0.0138 ns | 0.0129 ns | 14.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.911 ns | 0.0118 ns | 0.0105 ns | 12.911 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.622 ns | 0.0143 ns | 0.0126 ns | 10.624 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.649 ns | 0.0812 ns | 0.0759 ns | 14.602 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.575 ns | 0.0179 ns | 0.0167 ns | 14.579 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.170 ns | 0.0231 ns | 0.0193 ns | 20.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.229 ns | 0.0330 ns | 0.0309 ns | 18.226 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.051 ns | 0.0424 ns | 0.0397 ns | 18.050 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.917 ns | 0.0582 ns | 0.0516 ns | 27.900 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 29.847 ns | 0.1577 ns | 0.1475 ns | 29.896 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 13.382 ns | 0.0282 ns | 0.0235 ns | 13.376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.390 ns | 0.0133 ns | 0.0103 ns | 11.390 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.691 ns | 0.0121 ns | 0.0107 ns |  9.692 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.434 ns | 0.0246 ns | 0.0230 ns | 13.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.828 ns | 0.0163 ns | 0.0145 ns | 14.828 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.286 ns | 0.0188 ns | 0.0157 ns | 15.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.265 ns | 0.0368 ns | 0.0345 ns | 14.271 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.281 ns | 0.3115 ns | 0.4663 ns | 14.544 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.783 ns | 0.0406 ns | 0.0360 ns | 22.790 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 22.627 ns | 0.0311 ns | 0.0275 ns | 22.631 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.843 ns | 0.0175 ns | 0.0155 ns | 11.847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.510 ns | 0.0178 ns | 0.0166 ns | 10.515 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.909 ns | 0.0101 ns | 0.0090 ns |  9.910 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 13.626 ns | 0.0170 ns | 0.0151 ns | 13.624 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.012 ns | 0.0630 ns | 0.0589 ns | 13.042 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 20.049 ns | 0.1023 ns | 0.0907 ns | 20.075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.963 ns | 0.0188 ns | 0.0166 ns | 17.959 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.503 ns | 0.0335 ns | 0.0297 ns | 17.514 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 26.829 ns | 0.0278 ns | 0.0260 ns | 26.839 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.954 ns | 0.0340 ns | 0.0301 ns | 27.950 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 12.075 ns | 0.0145 ns | 0.0136 ns | 12.073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.763 ns | 0.0204 ns | 0.0191 ns | 11.760 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.162 ns | 0.0203 ns | 0.0180 ns | 10.165 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 14.465 ns | 0.0966 ns | 0.0904 ns | 14.408 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 13.638 ns | 0.1362 ns | 0.1207 ns | 13.614 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.796 ns | 0.1247 ns | 0.1105 ns | 19.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.012 ns | 0.0274 ns | 0.0256 ns | 18.009 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.465 ns | 0.2199 ns | 0.2057 ns | 18.544 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.714 ns | 0.0712 ns | 0.0595 ns | 27.710 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 27.576 ns | 0.0524 ns | 0.0437 ns | 27.577 ns |  1.39 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 12.071 ns | 0.0114 ns | 0.0089 ns | 12.072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.346 ns | 0.0144 ns | 0.0120 ns | 10.344 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  9.474 ns | 0.0083 ns | 0.0078 ns |  9.475 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.741 ns | 0.0138 ns | 0.0129 ns | 12.738 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.696 ns | 0.0251 ns | 0.0222 ns | 12.693 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.818 ns | 0.0245 ns | 0.0229 ns | 14.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.506 ns | 0.0396 ns | 0.0351 ns | 13.513 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.0164 ns | 0.0153 ns | 13.108 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 21.676 ns | 0.0815 ns | 0.0763 ns | 21.717 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.528 ns | 0.0234 ns | 0.0219 ns | 22.524 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 15.162 ns | 0.0230 ns | 0.0204 ns | 15.160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 13.772 ns | 0.0715 ns | 0.0669 ns | 13.749 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 13.038 ns | 0.0412 ns | 0.0385 ns | 13.048 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 16.682 ns | 0.0206 ns | 0.0193 ns | 16.687 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 15.511 ns | 0.0338 ns | 0.0282 ns | 15.517 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.518 ns | 0.0790 ns | 0.0739 ns | 21.493 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 20.269 ns | 0.0269 ns | 0.0224 ns | 20.265 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 20.060 ns | 0.0219 ns | 0.0194 ns | 20.057 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 30.331 ns | 0.0510 ns | 0.0477 ns | 30.318 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 33.050 ns | 0.0331 ns | 0.0310 ns | 33.057 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 15.175 ns | 0.0929 ns | 0.0869 ns | 15.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.101 ns | 0.0194 ns | 0.0162 ns | 13.104 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 12.706 ns | 0.0139 ns | 0.0130 ns | 12.711 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.439 ns | 0.0951 ns | 0.0890 ns | 15.382 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 15.423 ns | 0.0274 ns | 0.0228 ns | 15.431 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.469 ns | 0.0186 ns | 0.0165 ns | 21.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.398 ns | 0.0723 ns | 0.0677 ns | 20.410 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.224 ns | 0.1802 ns | 0.1685 ns | 20.108 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 31.833 ns | 0.0370 ns | 0.0309 ns | 31.826 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.852 ns | 0.0571 ns | 0.0534 ns | 30.842 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.113 ns | 0.0143 ns | 0.0127 ns | 12.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.487 ns | 0.0158 ns | 0.0132 ns | 10.482 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.707 ns | 0.0108 ns | 0.0096 ns |  9.705 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.954 ns | 0.0161 ns | 0.0142 ns | 12.957 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.933 ns | 0.0210 ns | 0.0175 ns | 12.927 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.511 ns | 0.0190 ns | 0.0178 ns | 15.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.420 ns | 0.0168 ns | 0.0140 ns | 13.419 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.852 ns | 0.0978 ns | 0.0914 ns | 14.803 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.702 ns | 0.0905 ns | 0.0846 ns | 22.756 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 24.403 ns | 0.0342 ns | 0.0303 ns | 24.397 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.145 ns | 0.0700 ns | 0.0621 ns | 59.150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 56.734 ns | 0.1296 ns | 0.1212 ns | 56.736 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.614 ns | 0.1225 ns | 0.1146 ns | 22.664 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 60.853 ns | 0.2178 ns | 0.2038 ns | 60.771 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 60.717 ns | 0.1414 ns | 0.1323 ns | 60.661 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 65.069 ns | 0.0899 ns | 0.0841 ns | 65.068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 61.333 ns | 0.3461 ns | 0.3237 ns | 61.393 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 26.938 ns | 0.0515 ns | 0.0456 ns | 26.940 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 72.789 ns | 0.1346 ns | 0.1259 ns | 72.780 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 73.695 ns | 0.0848 ns | 0.0708 ns | 73.701 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.157 ns | 0.0393 ns | 0.0348 ns | 14.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.896 ns | 0.0361 ns | 0.0320 ns | 18.898 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.834 ns | 0.0212 ns | 0.0198 ns | 13.834 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 15.458 ns | 0.0303 ns | 0.0283 ns | 15.459 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.476 ns | 0.0310 ns | 0.0275 ns | 15.469 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 15.553 ns | 0.0233 ns | 0.0218 ns | 15.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.429 ns | 0.0188 ns | 0.0176 ns | 13.430 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 13.235 ns | 0.0983 ns | 0.0920 ns | 13.285 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 24.338 ns | 0.0354 ns | 0.0331 ns | 24.328 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 22.509 ns | 0.0333 ns | 0.0295 ns | 22.512 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.051 ns | 0.0130 ns | 0.0116 ns | 14.053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 18.561 ns | 0.1092 ns | 0.1022 ns | 18.591 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.874 ns | 0.0279 ns | 0.0261 ns | 13.865 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 13.363 ns | 0.0241 ns | 0.0201 ns | 13.356 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.749 ns | 0.0251 ns | 0.0235 ns | 14.749 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.817 ns | 0.0108 ns | 0.0096 ns | 11.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.462 ns | 0.0155 ns | 0.0138 ns | 10.461 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.983 ns | 0.0610 ns | 0.0541 ns | 10.017 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 12.288 ns | 0.0156 ns | 0.0131 ns | 12.286 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 12.363 ns | 0.0121 ns | 0.0107 ns | 12.362 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 23.648 ns | 0.0192 ns | 0.0180 ns | 23.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 26.996 ns | 0.1532 ns | 0.1433 ns | 27.061 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 28.228 ns | 0.9614 ns | 2.0899 ns | 27.052 ns |  1.33 |    0.05 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 35.423 ns | 0.0749 ns | 0.0700 ns | 35.420 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 35.452 ns | 0.0568 ns | 0.0503 ns | 35.460 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.363 ns | 0.0143 ns | 0.0120 ns | 11.368 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.415 ns | 0.0120 ns | 0.0106 ns | 11.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.082 ns | 0.0126 ns | 0.0105 ns |  7.085 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.414 ns | 0.0516 ns | 0.0458 ns | 12.397 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 11.745 ns | 0.0203 ns | 0.0169 ns | 11.749 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.572 ns | 0.0177 ns | 0.0166 ns | 22.568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.297 ns | 0.1085 ns | 0.1015 ns | 26.328 ns |  1.16 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 30.873 ns | 0.0307 ns | 0.0272 ns | 30.870 ns |  1.37 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 37.121 ns | 0.0569 ns | 0.0532 ns | 37.125 ns |  1.64 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 36.384 ns | 0.1093 ns | 0.0969 ns | 36.410 ns |  1.61 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.475 ns | 0.0449 ns | 0.0398 ns | 11.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.309 ns | 0.0118 ns | 0.0099 ns | 10.310 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  8.493 ns | 0.1912 ns | 0.4197 ns |  8.604 ns |  0.71 |    0.07 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 11.698 ns | 0.0185 ns | 0.0173 ns | 11.694 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 11.753 ns | 0.0112 ns | 0.0105 ns | 11.752 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.770 ns | 0.0158 ns | 0.0148 ns | 14.772 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.619 ns | 0.0149 ns | 0.0139 ns | 13.622 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.211 ns | 0.1042 ns | 0.0974 ns | 13.270 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 24.327 ns | 0.0384 ns | 0.0340 ns | 24.325 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 22.677 ns | 0.0193 ns | 0.0181 ns | 22.673 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.361 ns | 0.0217 ns | 0.0192 ns | 12.357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.849 ns | 0.0576 ns | 0.0539 ns | 10.871 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.431 ns | 0.0171 ns | 0.0143 ns |  9.429 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.921 ns | 0.0176 ns | 0.0165 ns | 12.922 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.489 ns | 0.0123 ns | 0.0109 ns | 13.491 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.806 ns | 0.0288 ns | 0.0269 ns | 19.811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 18.179 ns | 0.0212 ns | 0.0199 ns | 18.174 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 18.074 ns | 0.0276 ns | 0.0258 ns | 18.075 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 29.320 ns | 0.0329 ns | 0.0308 ns | 29.319 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 29.847 ns | 0.0284 ns | 0.0266 ns | 29.844 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 12.058 ns | 0.0133 ns | 0.0118 ns | 12.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.704 ns | 0.0131 ns | 0.0123 ns | 10.703 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.152 ns | 0.0153 ns | 0.0143 ns | 10.150 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.379 ns | 0.0126 ns | 0.0105 ns | 13.379 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 13.370 ns | 0.0218 ns | 0.0193 ns | 13.374 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.120 ns | 0.0168 ns | 0.0149 ns | 19.119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.128 ns | 0.0715 ns | 0.0669 ns | 18.143 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.663 ns | 0.0326 ns | 0.0289 ns | 17.660 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 29.330 ns | 0.0419 ns | 0.0392 ns | 29.322 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.316 ns | 0.0237 ns | 0.0221 ns | 27.316 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.046 ns | 0.0205 ns | 0.0192 ns | 12.043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.355 ns | 0.0175 ns | 0.0146 ns | 10.349 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.707 ns | 0.1918 ns | 0.1794 ns |  9.840 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 13.335 ns | 0.0149 ns | 0.0140 ns | 13.333 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.744 ns | 0.0116 ns | 0.0108 ns | 12.742 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.794 ns | 0.0150 ns | 0.0140 ns | 14.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.421 ns | 0.0125 ns | 0.0111 ns | 13.422 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.093 ns | 0.0139 ns | 0.0130 ns | 13.094 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.483 ns | 0.0596 ns | 0.0557 ns | 22.495 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 24.565 ns | 0.0293 ns | 0.0260 ns | 24.567 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.892 ns | 0.0129 ns | 0.0114 ns | 12.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 12.061 ns | 0.0708 ns | 0.0662 ns | 12.097 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.916 ns | 0.0108 ns | 0.0095 ns |  9.915 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 13.671 ns | 0.0166 ns | 0.0147 ns | 13.671 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.957 ns | 0.0185 ns | 0.0164 ns | 12.955 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 20.249 ns | 0.0185 ns | 0.0173 ns | 20.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.261 ns | 0.0180 ns | 0.0169 ns | 18.259 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 17.793 ns | 0.0449 ns | 0.0375 ns | 17.779 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 27.360 ns | 0.0569 ns | 0.0532 ns | 27.378 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 30.022 ns | 0.0422 ns | 0.0374 ns | 30.016 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.813 ns | 0.0221 ns | 0.0196 ns | 13.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.706 ns | 0.0132 ns | 0.0117 ns | 12.705 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.122 ns | 0.0150 ns | 0.0140 ns | 11.122 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.525 ns | 0.0133 ns | 0.0124 ns | 14.524 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.620 ns | 0.0244 ns | 0.0228 ns | 14.617 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.534 ns | 0.0341 ns | 0.0319 ns | 20.538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.386 ns | 0.0617 ns | 0.0547 ns | 18.395 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.782 ns | 0.0201 ns | 0.0188 ns | 17.779 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.319 ns | 0.0313 ns | 0.0293 ns | 27.315 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 28.686 ns | 0.0389 ns | 0.0345 ns | 28.696 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.366 ns | 0.0169 ns | 0.0150 ns | 12.363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.456 ns | 0.0289 ns | 0.0256 ns | 11.465 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.834 ns | 0.1594 ns | 0.1491 ns |  9.919 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.297 ns | 0.0211 ns | 0.0198 ns | 13.299 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.944 ns | 0.0726 ns | 0.0679 ns | 14.902 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.839 ns | 0.0198 ns | 0.0175 ns | 14.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.427 ns | 0.0163 ns | 0.0153 ns | 13.424 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.143 ns | 0.0515 ns | 0.0457 ns | 13.128 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 22.442 ns | 0.0264 ns | 0.0221 ns | 22.439 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 22.394 ns | 0.0142 ns | 0.0126 ns | 22.394 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.526 ns | 0.0219 ns | 0.0194 ns | 14.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.517 ns | 0.0383 ns | 0.0358 ns | 13.524 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.217 ns | 0.1038 ns | 0.0971 ns | 13.286 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.714 ns | 0.0949 ns | 0.0888 ns | 22.756 ns |  1.56 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 22.571 ns | 0.0204 ns | 0.0181 ns | 22.576 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.708 ns | 0.0183 ns | 0.0162 ns | 12.711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.089 ns | 0.0269 ns | 0.0224 ns | 11.084 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.831 ns | 0.1184 ns | 0.1108 ns | 12.761 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.913 ns | 0.0243 ns | 0.0203 ns | 12.914 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.075 ns | 0.0491 ns | 0.0435 ns | 13.085 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 15.086 ns | 0.0136 ns | 0.0120 ns | 15.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.421 ns | 0.0147 ns | 0.0131 ns | 13.420 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.110 ns | 0.0112 ns | 0.0105 ns | 13.105 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 22.596 ns | 0.0276 ns | 0.0245 ns | 22.602 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 25.149 ns | 0.0332 ns | 0.0294 ns | 25.139 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.564 ns | 0.0215 ns | 0.0201 ns | 17.563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.664 ns | 0.0836 ns | 0.0782 ns | 14.698 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.741 ns | 0.0802 ns | 0.0750 ns | 14.717 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 27.461 ns | 0.0452 ns | 0.0401 ns | 27.475 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 28.640 ns | 0.0192 ns | 0.0170 ns | 28.636 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 18.981 ns | 0.0129 ns | 0.0115 ns | 18.984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.523 ns | 0.0183 ns | 0.0162 ns | 17.524 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.791 ns | 0.0344 ns | 0.0321 ns | 16.792 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.016 ns | 0.0309 ns | 0.0274 ns | 26.012 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 29.733 ns | 0.1093 ns | 0.1023 ns | 29.759 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.759 ns | 0.0188 ns | 0.0176 ns | 14.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.898 ns | 0.0107 ns | 0.0100 ns | 12.900 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.109 ns | 0.0182 ns | 0.0170 ns | 13.110 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.382 ns | 0.0164 ns | 0.0153 ns | 24.382 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 22.527 ns | 0.0381 ns | 0.0338 ns | 22.528 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.697 ns | 0.0193 ns | 0.0161 ns | 14.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.414 ns | 0.0185 ns | 0.0164 ns | 13.414 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 15.874 ns | 0.3397 ns | 0.4296 ns | 16.107 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 24.535 ns | 0.1394 ns | 0.1304 ns | 24.601 ns |  1.67 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.179 ns | 0.0454 ns | 0.0425 ns | 24.161 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 15.022 ns | 0.0297 ns | 0.0248 ns | 15.023 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.204 ns | 0.0097 ns | 0.0081 ns | 12.205 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.713 ns | 0.0799 ns | 0.0747 ns | 12.705 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.279 ns | 0.0141 ns | 0.0125 ns | 14.277 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 15.172 ns | 0.0656 ns | 0.0614 ns | 15.190 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.489 ns | 0.0281 ns | 0.0249 ns | 16.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 16.705 ns | 0.0157 ns | 0.0146 ns | 16.701 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.368 ns | 0.3242 ns | 0.3982 ns | 15.695 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 25.876 ns | 0.0423 ns | 0.0375 ns | 25.885 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.310 ns | 0.0342 ns | 0.0304 ns | 24.317 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.521 ns | 0.0143 ns | 0.0127 ns | 14.522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.558 ns | 0.0175 ns | 0.0137 ns | 12.557 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.559 ns | 0.0758 ns | 0.0709 ns | 12.585 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.451 ns | 0.0657 ns | 0.0583 ns | 14.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 15.690 ns | 0.0453 ns | 0.0424 ns | 15.697 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.498 ns | 0.0329 ns | 0.0275 ns | 14.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.397 ns | 0.0149 ns | 0.0139 ns | 13.397 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.109 ns | 0.0187 ns | 0.0156 ns | 13.106 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.636 ns | 0.0347 ns | 0.0325 ns | 22.635 ns |  1.56 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 25.192 ns | 0.0705 ns | 0.0660 ns | 25.157 ns |  1.74 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.263 ns | 0.0358 ns | 0.0335 ns | 20.264 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.197 ns | 0.0364 ns | 0.0304 ns | 16.188 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.727 ns | 0.1721 ns | 0.1610 ns | 13.692 ns |  0.68 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 18.207 ns | 0.0255 ns | 0.0226 ns | 18.209 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.028 ns | 0.0268 ns | 0.0251 ns | 19.023 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 19.705 ns | 0.0421 ns | 0.0373 ns | 19.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.522 ns | 0.0156 ns | 0.0146 ns | 17.526 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 18.856 ns | 0.1973 ns | 0.1846 ns | 18.920 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 26.737 ns | 0.1821 ns | 0.1703 ns | 26.809 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 27.049 ns | 0.1587 ns | 0.1485 ns | 27.108 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.185 ns | 0.1216 ns | 0.1138 ns | 20.143 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.343 ns | 0.0189 ns | 0.0177 ns | 16.339 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.292 ns | 0.0594 ns | 0.0555 ns | 14.279 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.570 ns | 0.0295 ns | 0.0246 ns | 24.570 ns |  1.22 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.380 ns | 0.0365 ns | 0.0324 ns | 24.377 ns |  1.21 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.684 ns | 0.0249 ns | 0.0233 ns | 18.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.668 ns | 0.0734 ns | 0.0687 ns | 18.659 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.437 ns | 0.0289 ns | 0.0256 ns | 17.433 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 26.451 ns | 0.0277 ns | 0.0259 ns | 26.454 ns |  1.42 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.522 ns | 0.0433 ns | 0.0405 ns | 28.517 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.846 ns | 0.0137 ns | 0.0121 ns | 13.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.988 ns | 0.0272 ns | 0.0227 ns | 11.989 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.163 ns | 0.0741 ns | 0.0694 ns | 10.122 ns |  0.73 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 21.509 ns | 0.0563 ns | 0.0499 ns | 21.504 ns |  1.55 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 19.186 ns | 0.0588 ns | 0.0550 ns | 19.191 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.675 ns | 0.0195 ns | 0.0173 ns | 14.677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.390 ns | 0.0159 ns | 0.0149 ns | 13.386 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.776 ns | 0.0182 ns | 0.0161 ns | 14.776 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.547 ns | 0.0368 ns | 0.0307 ns | 22.538 ns |  1.54 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.396 ns | 0.0418 ns | 0.0370 ns | 24.396 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.119 ns | 0.0122 ns | 0.0115 ns | 13.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.320 ns | 0.0135 ns | 0.0113 ns | 10.321 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.233 ns | 0.0080 ns | 0.0071 ns |  9.232 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 12.218 ns | 0.0110 ns | 0.0103 ns | 12.217 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.928 ns | 0.0153 ns | 0.0143 ns | 12.922 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.401 ns | 0.0217 ns | 0.0192 ns | 16.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.300 ns | 0.1149 ns | 0.1075 ns | 15.240 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.090 ns | 0.1146 ns | 0.1072 ns | 15.145 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.992 ns | 0.0359 ns | 0.0336 ns | 25.988 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 24.248 ns | 0.0400 ns | 0.0334 ns | 24.251 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.267 ns | 0.0185 ns | 0.0173 ns | 13.261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.312 ns | 0.0121 ns | 0.0094 ns | 10.315 ns |  0.78 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.238 ns | 0.0092 ns | 0.0086 ns |  9.241 ns |  0.70 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 12.223 ns | 0.0152 ns | 0.0142 ns | 12.220 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 16.293 ns | 0.0110 ns | 0.0103 ns | 16.291 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.380 ns | 0.0149 ns | 0.0132 ns | 16.377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.401 ns | 0.0543 ns | 0.0482 ns | 15.418 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.953 ns | 0.0180 ns | 0.0160 ns | 14.952 ns |  0.91 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 24.401 ns | 0.0292 ns | 0.0273 ns | 24.409 ns |  1.49 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 26.058 ns | 0.1589 ns | 0.1486 ns | 25.971 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.160 ns | 0.0120 ns | 0.0112 ns | 13.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.335 ns | 0.0380 ns | 0.0337 ns | 10.318 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.503 ns | 0.0602 ns | 0.0563 ns |  9.470 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.937 ns | 0.0179 ns | 0.0168 ns | 12.939 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.911 ns | 0.0092 ns | 0.0072 ns | 12.913 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.856 ns | 0.0178 ns | 0.0139 ns | 14.852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.420 ns | 0.0192 ns | 0.0150 ns | 13.418 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.790 ns | 0.1290 ns | 0.1207 ns | 13.721 ns |  0.93 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 22.569 ns | 0.0493 ns | 0.0437 ns | 22.569 ns |  1.52 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 22.607 ns | 0.0243 ns | 0.0215 ns | 22.609 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.394 ns | 0.0196 ns | 0.0174 ns | 13.394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.470 ns | 0.0132 ns | 0.0117 ns | 11.469 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.926 ns | 0.0337 ns | 0.0315 ns |  9.936 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 13.324 ns | 0.0491 ns | 0.0459 ns | 13.306 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.103 ns | 0.0871 ns | 0.0815 ns | 13.090 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 47.390 ns | 0.0499 ns | 0.0467 ns | 47.383 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.450 ns | 0.0541 ns | 0.0452 ns | 44.442 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 42.498 ns | 0.1122 ns | 0.1050 ns | 42.510 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.363 ns | 0.0933 ns | 0.0827 ns | 50.358 ns |  1.06 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 51.334 ns | 0.0963 ns | 0.0900 ns | 51.326 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.178 ns | 0.0403 ns | 0.0377 ns | 13.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.005 ns | 0.0283 ns | 0.0236 ns | 13.013 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 | 10.306 ns | 0.0562 ns | 0.0525 ns | 10.280 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 16.647 ns | 0.0226 ns | 0.0212 ns | 16.640 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.464 ns | 0.0509 ns | 0.0476 ns | 13.457 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 44.866 ns | 0.0799 ns | 0.0708 ns | 44.844 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 44.837 ns | 0.1033 ns | 0.0916 ns | 44.855 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 40.795 ns | 0.2027 ns | 0.1896 ns | 40.770 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 50.258 ns | 0.0535 ns | 0.0475 ns | 50.250 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 51.813 ns | 0.0878 ns | 0.0733 ns | 51.806 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.716 ns | 0.0197 ns | 0.0184 ns | 13.718 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.563 ns | 0.0135 ns | 0.0126 ns | 11.567 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.683 ns | 0.0196 ns | 0.0183 ns |  9.681 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 16.282 ns | 0.0162 ns | 0.0151 ns | 16.276 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.742 ns | 0.0087 ns | 0.0077 ns | 12.742 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.893 ns | 0.0399 ns | 0.0354 ns | 14.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.174 ns | 0.0113 ns | 0.0094 ns | 14.176 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.247 ns | 0.0420 ns | 0.0393 ns | 13.224 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.674 ns | 0.0372 ns | 0.0329 ns | 22.682 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 24.694 ns | 0.1299 ns | 0.1215 ns | 24.720 ns |  1.66 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.182 ns | 0.0399 ns | 0.0354 ns | 14.195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.204 ns | 0.0113 ns | 0.0100 ns | 12.204 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 13.076 ns | 0.1653 ns | 0.1546 ns | 13.178 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.280 ns | 0.0144 ns | 0.0134 ns | 14.277 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.333 ns | 0.0428 ns | 0.0400 ns | 14.317 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.841 ns | 0.0303 ns | 0.0284 ns | 16.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.783 ns | 0.0135 ns | 0.0126 ns | 15.782 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 18.357 ns | 0.3853 ns | 0.6222 ns | 18.736 ns |  1.06 |    0.04 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 26.126 ns | 0.0591 ns | 0.0524 ns | 26.134 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 24.878 ns | 0.0542 ns | 0.0507 ns | 24.878 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.042 ns | 0.0135 ns | 0.0120 ns | 14.041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.214 ns | 0.0098 ns | 0.0082 ns | 12.217 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.450 ns | 0.0094 ns | 0.0083 ns | 12.450 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.001 ns | 0.0414 ns | 0.0387 ns | 14.984 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.611 ns | 0.0212 ns | 0.0198 ns | 14.609 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.928 ns | 0.0404 ns | 0.0378 ns | 14.940 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 13.399 ns | 0.0158 ns | 0.0140 ns | 13.402 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 14.820 ns | 0.0597 ns | 0.0529 ns | 14.800 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.455 ns | 0.0321 ns | 0.0284 ns | 22.444 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 24.317 ns | 0.0643 ns | 0.0601 ns | 24.294 ns |  1.63 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.410 ns | 0.0450 ns | 0.0421 ns | 42.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.947 ns | 0.0236 ns | 0.0209 ns | 38.949 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.812 ns | 0.0575 ns | 0.0480 ns | 38.809 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.716 ns | 0.0319 ns | 0.0283 ns | 40.712 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 49.021 ns | 0.0818 ns | 0.0765 ns | 48.995 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.821 ns | 0.0210 ns | 0.0175 ns | 16.816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.724 ns | 0.0391 ns | 0.0347 ns | 15.710 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.390 ns | 0.0208 ns | 0.0173 ns | 15.393 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 27.465 ns | 0.0476 ns | 0.0445 ns | 27.462 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 27.647 ns | 0.1326 ns | 0.1241 ns | 27.725 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.118 ns | 0.1359 ns | 0.1204 ns | 42.135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 41.088 ns | 0.0547 ns | 0.0485 ns | 41.077 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 39.658 ns | 0.8011 ns | 1.0694 ns | 39.024 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 41.713 ns | 0.0520 ns | 0.0461 ns | 41.714 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.119 ns | 0.0846 ns | 0.0750 ns | 40.145 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.281 ns | 0.0496 ns | 0.0439 ns | 18.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.725 ns | 0.0218 ns | 0.0182 ns | 15.723 ns |  0.86 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.425 ns | 0.0922 ns | 0.0862 ns | 15.385 ns |  0.84 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 24.438 ns | 0.0421 ns | 0.0394 ns | 24.455 ns |  1.34 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 24.608 ns | 0.0738 ns | 0.0690 ns | 24.600 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.083 ns | 0.0611 ns | 0.0541 ns | 42.074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.002 ns | 0.0508 ns | 0.0475 ns | 39.002 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 36.829 ns | 0.0514 ns | 0.0429 ns | 36.836 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 44.354 ns | 0.0587 ns | 0.0549 ns | 44.342 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 42.188 ns | 0.1473 ns | 0.1377 ns | 42.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.758 ns | 0.0190 ns | 0.0178 ns | 15.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.389 ns | 0.0133 ns | 0.0118 ns | 13.390 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.117 ns | 0.0154 ns | 0.0144 ns | 13.120 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 25.801 ns | 0.0353 ns | 0.0330 ns | 25.790 ns |  1.64 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.644 ns | 0.0314 ns | 0.0294 ns | 22.637 ns |  1.44 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShortNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_UShortNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
