
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
                                             From_Bool | .NET Core 2.0 | 15.294 ns | 0.1375 ns | 0.1286 ns | 15.228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 12.214 ns | 0.0404 ns | 0.0358 ns | 12.208 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.141 ns | 0.2067 ns | 0.4448 ns |  9.290 ns |  0.57 |    0.05 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 14.944 ns | 0.0982 ns | 0.0918 ns | 14.972 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.774 ns | 0.0133 ns | 0.0124 ns | 13.770 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 20.985 ns | 0.0274 ns | 0.0256 ns | 20.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.226 ns | 0.0695 ns | 0.0650 ns | 18.203 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.929 ns | 0.0560 ns | 0.0497 ns | 17.933 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 22.235 ns | 0.1135 ns | 0.1006 ns | 22.195 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 20.781 ns | 0.0278 ns | 0.0233 ns | 20.781 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 13.790 ns | 0.0253 ns | 0.0237 ns | 13.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.039 ns | 0.0219 ns | 0.0194 ns | 11.036 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  8.725 ns | 0.0798 ns | 0.0623 ns |  8.691 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 13.416 ns | 0.0172 ns | 0.0161 ns | 13.411 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 14.492 ns | 0.0212 ns | 0.0188 ns | 14.491 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.800 ns | 0.0304 ns | 0.0254 ns | 20.809 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.230 ns | 0.1120 ns | 0.1048 ns | 18.171 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.715 ns | 0.0326 ns | 0.0305 ns | 17.714 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 20.750 ns | 0.0357 ns | 0.0298 ns | 20.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 20.844 ns | 0.0397 ns | 0.0371 ns | 20.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 13.433 ns | 0.0196 ns | 0.0164 ns | 13.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.751 ns | 0.0743 ns | 0.0695 ns | 10.729 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.840 ns | 0.0196 ns | 0.0183 ns |  7.839 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.039 ns | 0.0475 ns | 0.0396 ns | 13.029 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 13.915 ns | 0.0470 ns | 0.0440 ns | 13.900 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.433 ns | 0.1011 ns | 0.0896 ns | 15.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.117 ns | 0.0710 ns | 0.0664 ns | 14.093 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.211 ns | 0.1299 ns | 0.1215 ns | 12.144 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 16.374 ns | 0.0249 ns | 0.0233 ns | 16.374 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 15.745 ns | 0.0173 ns | 0.0162 ns | 15.744 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 13.649 ns | 0.0284 ns | 0.0252 ns | 13.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.841 ns | 0.0239 ns | 0.0212 ns | 10.845 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.639 ns | 0.0205 ns | 0.0192 ns |  7.638 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.933 ns | 0.0170 ns | 0.0150 ns | 12.933 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 13.755 ns | 0.1087 ns | 0.1017 ns | 13.796 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 21.298 ns | 0.0313 ns | 0.0292 ns | 21.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.769 ns | 0.0450 ns | 0.0421 ns | 18.777 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 20.161 ns | 0.0402 ns | 0.0376 ns | 20.165 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 22.772 ns | 0.0679 ns | 0.0567 ns | 22.760 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 20.714 ns | 0.0300 ns | 0.0266 ns | 20.710 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 13.697 ns | 0.0365 ns | 0.0342 ns | 13.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.884 ns | 0.0201 ns | 0.0168 ns | 10.881 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  8.108 ns | 0.1356 ns | 0.1268 ns |  8.144 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 13.644 ns | 0.0390 ns | 0.0345 ns | 13.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 14.368 ns | 0.1047 ns | 0.0980 ns | 14.334 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.253 ns | 0.0238 ns | 0.0211 ns | 21.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.963 ns | 0.0799 ns | 0.0747 ns | 17.946 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.926 ns | 0.0371 ns | 0.0347 ns | 17.917 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 21.087 ns | 0.0613 ns | 0.0573 ns | 21.065 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 21.016 ns | 0.0340 ns | 0.0266 ns | 21.006 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 13.337 ns | 0.1257 ns | 0.1175 ns | 13.339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.761 ns | 0.0819 ns | 0.0766 ns | 10.745 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  8.689 ns | 0.1987 ns | 0.3480 ns |  8.849 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.971 ns | 0.0705 ns | 0.0659 ns | 12.954 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 13.939 ns | 0.0821 ns | 0.0768 ns | 13.900 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.416 ns | 0.0215 ns | 0.0190 ns | 15.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.883 ns | 0.0098 ns | 0.0092 ns | 13.882 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.283 ns | 0.1382 ns | 0.1292 ns | 14.238 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 16.483 ns | 0.0197 ns | 0.0164 ns | 16.482 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 15.240 ns | 0.0872 ns | 0.0816 ns | 15.286 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 12.782 ns | 0.0262 ns | 0.0245 ns | 12.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 12.046 ns | 0.0247 ns | 0.0206 ns | 12.042 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  7.371 ns | 0.0224 ns | 0.0199 ns |  7.365 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.767 ns | 0.0251 ns | 0.0235 ns | 12.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 14.322 ns | 0.0188 ns | 0.0176 ns | 14.321 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 12.900 ns | 0.0192 ns | 0.0180 ns | 12.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.798 ns | 0.0148 ns | 0.0131 ns | 10.799 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  8.222 ns | 0.0196 ns | 0.0174 ns |  8.225 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.115 ns | 0.0411 ns | 0.0344 ns | 13.105 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 13.926 ns | 0.0962 ns | 0.0900 ns | 13.960 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.874 ns | 0.0091 ns | 0.0081 ns | 12.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.796 ns | 0.0194 ns | 0.0162 ns | 10.799 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.735 ns | 0.0105 ns | 0.0098 ns |  7.738 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 13.047 ns | 0.0304 ns | 0.0285 ns | 13.040 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 13.755 ns | 0.0157 ns | 0.0139 ns | 13.754 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.050 ns | 0.0341 ns | 0.0302 ns | 17.060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.826 ns | 0.0244 ns | 0.0228 ns | 13.821 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.403 ns | 0.2584 ns | 0.2417 ns | 12.367 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 14.822 ns | 0.0421 ns | 0.0352 ns | 14.810 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 15.077 ns | 0.0209 ns | 0.0196 ns | 15.078 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.611 ns | 0.0177 ns | 0.0157 ns | 12.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.505 ns | 0.0143 ns | 0.0134 ns | 11.504 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.436 ns | 0.0117 ns | 0.0098 ns |  8.433 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.021 ns | 0.0189 ns | 0.0158 ns | 13.023 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.808 ns | 0.0222 ns | 0.0208 ns | 13.814 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 13.561 ns | 0.1384 ns | 0.1295 ns | 13.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.821 ns | 0.1077 ns | 0.1008 ns | 11.879 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.456 ns | 0.1015 ns | 0.0949 ns |  8.509 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.232 ns | 0.0197 ns | 0.0175 ns | 13.237 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.819 ns | 0.0210 ns | 0.0186 ns | 14.815 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.739 ns | 0.0158 ns | 0.0132 ns | 12.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.705 ns | 0.0295 ns | 0.0276 ns | 11.702 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.461 ns | 0.2732 ns | 0.3252 ns |  8.287 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 14.216 ns | 0.0183 ns | 0.0171 ns | 14.223 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 14.297 ns | 0.0397 ns | 0.0372 ns | 14.283 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.660 ns | 0.1117 ns | 0.1045 ns | 15.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 15.141 ns | 0.1191 ns | 0.1114 ns | 15.080 ns |  0.97 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.980 ns | 0.0221 ns | 0.0173 ns | 14.979 ns |  0.96 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 16.373 ns | 0.0276 ns | 0.0258 ns | 16.372 ns |  1.05 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 14.966 ns | 0.0600 ns | 0.0561 ns | 14.989 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 20.618 ns | 0.0497 ns | 0.0441 ns | 20.609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 16.099 ns | 0.0242 ns | 0.0215 ns | 16.099 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 11.710 ns | 0.0125 ns | 0.0104 ns | 11.715 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 21.902 ns | 0.0877 ns | 0.0778 ns | 21.875 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 20.969 ns | 0.0304 ns | 0.0285 ns | 20.965 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 25.444 ns | 0.0547 ns | 0.0457 ns | 25.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 23.562 ns | 0.0524 ns | 0.0409 ns | 23.562 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 22.584 ns | 0.3387 ns | 0.3168 ns | 22.721 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 26.437 ns | 0.0536 ns | 0.0501 ns | 26.427 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 25.000 ns | 0.0511 ns | 0.0478 ns | 24.978 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 23.209 ns | 0.0504 ns | 0.0447 ns | 23.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.479 ns | 0.0986 ns | 0.0923 ns | 20.486 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 20.404 ns | 0.0330 ns | 0.0293 ns | 20.400 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 22.611 ns | 0.0857 ns | 0.0802 ns | 22.626 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 22.967 ns | 0.2145 ns | 0.2007 ns | 23.053 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.348 ns | 0.0412 ns | 0.0365 ns | 25.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 23.457 ns | 0.0427 ns | 0.0378 ns | 23.456 ns |  0.93 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.950 ns | 0.0559 ns | 0.0495 ns | 20.947 ns |  0.83 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 26.975 ns | 0.0415 ns | 0.0388 ns | 26.963 ns |  1.06 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 24.866 ns | 0.0331 ns | 0.0294 ns | 24.859 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.900 ns | 0.0326 ns | 0.0289 ns | 12.888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 12.314 ns | 0.0190 ns | 0.0178 ns | 12.316 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 11.135 ns | 0.2476 ns | 0.5981 ns | 11.330 ns |  0.80 |    0.08 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.503 ns | 0.0390 ns | 0.0365 ns | 13.498 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 14.510 ns | 0.0146 ns | 0.0129 ns | 14.510 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.413 ns | 0.0323 ns | 0.0286 ns | 15.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.018 ns | 0.0890 ns | 0.0789 ns | 14.040 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.064 ns | 0.1745 ns | 0.1547 ns | 14.037 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.148 ns | 0.0626 ns | 0.0586 ns | 15.159 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 15.242 ns | 0.0326 ns | 0.0289 ns | 15.234 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.157 ns | 0.0131 ns | 0.0116 ns | 13.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.748 ns | 0.0260 ns | 0.0244 ns | 10.752 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 |  7.971 ns | 0.1951 ns | 0.2860 ns |  7.818 ns |  0.62 |    0.03 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.493 ns | 0.0456 ns | 0.0426 ns | 13.495 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 13.725 ns | 0.1013 ns | 0.0947 ns | 13.726 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 28.372 ns | 0.0413 ns | 0.0366 ns | 28.358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 27.301 ns | 0.1155 ns | 0.1080 ns | 27.331 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 27.671 ns | 0.5629 ns | 0.5528 ns | 28.108 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 32.173 ns | 0.1047 ns | 0.0874 ns | 32.160 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 31.954 ns | 0.1170 ns | 0.1038 ns | 31.898 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 12.706 ns | 0.0149 ns | 0.0132 ns | 12.705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 11.608 ns | 0.0209 ns | 0.0195 ns | 11.608 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 |  8.736 ns | 0.0543 ns | 0.0454 ns |  8.740 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 13.193 ns | 0.1115 ns | 0.1043 ns | 13.254 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 13.812 ns | 0.0105 ns | 0.0088 ns | 13.811 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 25.113 ns | 0.0355 ns | 0.0314 ns | 25.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 27.188 ns | 0.0504 ns | 0.0447 ns | 27.181 ns |  1.08 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 29.452 ns | 0.0488 ns | 0.0381 ns | 29.452 ns |  1.17 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 32.580 ns | 0.0897 ns | 0.0839 ns | 32.571 ns |  1.30 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 32.729 ns | 0.2762 ns | 0.2584 ns | 32.828 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.714 ns | 0.0185 ns | 0.0173 ns | 12.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 12.114 ns | 0.0146 ns | 0.0130 ns | 12.114 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  8.570 ns | 0.0328 ns | 0.0307 ns |  8.559 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.066 ns | 0.0187 ns | 0.0175 ns | 13.059 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 13.593 ns | 0.0209 ns | 0.0185 ns | 13.590 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.767 ns | 0.0351 ns | 0.0329 ns | 16.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.689 ns | 0.0182 ns | 0.0161 ns | 14.692 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.513 ns | 0.2242 ns | 0.2097 ns | 12.583 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 14.782 ns | 0.0232 ns | 0.0217 ns | 14.784 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 17.032 ns | 0.0144 ns | 0.0135 ns | 17.031 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 14.171 ns | 0.0187 ns | 0.0146 ns | 14.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 11.005 ns | 0.0846 ns | 0.0750 ns | 11.036 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.886 ns | 0.0503 ns | 0.0471 ns |  7.868 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 13.428 ns | 0.0362 ns | 0.0339 ns | 13.419 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 13.826 ns | 0.0878 ns | 0.0821 ns | 13.861 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 21.290 ns | 0.1894 ns | 0.1772 ns | 21.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 18.263 ns | 0.0316 ns | 0.0281 ns | 18.263 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 20.667 ns | 0.0393 ns | 0.0328 ns | 20.662 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 21.767 ns | 0.0557 ns | 0.0521 ns | 21.747 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 20.670 ns | 0.0370 ns | 0.0328 ns | 20.673 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.832 ns | 0.0228 ns | 0.0190 ns | 13.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.618 ns | 0.1071 ns | 0.1002 ns | 11.562 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  8.403 ns | 0.4314 ns | 0.5136 ns |  8.131 ns |  0.62 |    0.04 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 15.025 ns | 0.0619 ns | 0.0579 ns | 15.011 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 14.270 ns | 0.0285 ns | 0.0238 ns | 14.267 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.254 ns | 0.0393 ns | 0.0329 ns | 21.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.121 ns | 0.0819 ns | 0.0726 ns | 19.141 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.182 ns | 0.2018 ns | 0.1887 ns | 20.132 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 21.517 ns | 0.0578 ns | 0.0512 ns | 21.515 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 20.986 ns | 0.1456 ns | 0.1291 ns | 21.031 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 15.135 ns | 0.0232 ns | 0.0217 ns | 15.131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.779 ns | 0.0086 ns | 0.0081 ns | 10.781 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.569 ns | 0.0127 ns | 0.0119 ns |  7.570 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.973 ns | 0.0344 ns | 0.0268 ns | 12.971 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 14.622 ns | 0.0902 ns | 0.0844 ns | 14.627 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.474 ns | 0.0240 ns | 0.0200 ns | 16.476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.827 ns | 0.0322 ns | 0.0286 ns | 13.818 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.874 ns | 0.0266 ns | 0.0236 ns | 14.871 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 16.378 ns | 0.0321 ns | 0.0300 ns | 16.368 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 14.872 ns | 0.0970 ns | 0.0908 ns | 14.829 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.824 ns | 0.0262 ns | 0.0232 ns | 12.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 11.240 ns | 0.0118 ns | 0.0105 ns | 11.240 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.430 ns | 0.0663 ns | 0.0554 ns |  7.453 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                              From_Int |        net461 | 14.309 ns | 0.0157 ns | 0.0131 ns | 14.311 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 13.777 ns | 0.0113 ns | 0.0095 ns | 13.783 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 21.286 ns | 0.1917 ns | 0.1793 ns | 21.385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 20.367 ns | 0.0309 ns | 0.0289 ns | 20.368 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 17.174 ns | 0.0890 ns | 0.0832 ns | 17.132 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 22.989 ns | 0.1296 ns | 0.1082 ns | 23.025 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 20.919 ns | 0.0431 ns | 0.0403 ns | 20.913 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 13.092 ns | 0.0108 ns | 0.0096 ns | 13.091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.019 ns | 0.0138 ns | 0.0129 ns | 11.021 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.938 ns | 0.1787 ns | 0.2937 ns |  8.979 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 13.852 ns | 0.0396 ns | 0.0370 ns | 13.845 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 14.383 ns | 0.1536 ns | 0.1437 ns | 14.296 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.215 ns | 0.1657 ns | 0.1550 ns | 21.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.178 ns | 0.1088 ns | 0.1018 ns | 19.219 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.576 ns | 0.3873 ns | 0.5170 ns | 18.841 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 21.474 ns | 0.0231 ns | 0.0193 ns | 21.474 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 20.636 ns | 0.0342 ns | 0.0320 ns | 20.650 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 13.316 ns | 0.0353 ns | 0.0295 ns | 13.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.223 ns | 0.0198 ns | 0.0175 ns | 11.219 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.717 ns | 0.2311 ns | 0.2752 ns |  7.571 ns |  0.59 |    0.02 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 14.475 ns | 0.0524 ns | 0.0490 ns | 14.484 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 13.975 ns | 0.1097 ns | 0.1026 ns | 13.933 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.410 ns | 0.0227 ns | 0.0213 ns | 15.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.668 ns | 0.0872 ns | 0.0816 ns | 14.629 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.941 ns | 0.2235 ns | 0.2091 ns | 15.021 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 16.416 ns | 0.0119 ns | 0.0105 ns | 16.414 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 14.757 ns | 0.0276 ns | 0.0230 ns | 14.761 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 13.000 ns | 0.0856 ns | 0.0759 ns | 13.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.775 ns | 0.0331 ns | 0.0309 ns | 10.775 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.563 ns | 0.1730 ns | 0.1852 ns |  7.676 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 13.850 ns | 0.0284 ns | 0.0252 ns | 13.850 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net472 | 13.723 ns | 0.0259 ns | 0.0242 ns | 13.718 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 21.523 ns | 0.0673 ns | 0.0562 ns | 21.521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.187 ns | 0.0908 ns | 0.0805 ns | 18.204 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.521 ns | 0.2066 ns | 0.1831 ns | 18.528 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 21.292 ns | 0.0628 ns | 0.0587 ns | 21.305 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 20.908 ns | 0.0461 ns | 0.0360 ns | 20.901 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 14.424 ns | 0.0163 ns | 0.0152 ns | 14.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 11.949 ns | 0.0246 ns | 0.0230 ns | 11.943 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.079 ns | 0.3893 ns | 0.6175 ns |  9.738 ns |  0.73 |    0.05 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.428 ns | 0.0352 ns | 0.0330 ns | 14.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.626 ns | 0.0496 ns | 0.0440 ns | 14.612 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.445 ns | 0.1715 ns | 0.1604 ns | 21.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.936 ns | 0.0613 ns | 0.0543 ns | 17.932 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.910 ns | 0.0326 ns | 0.0305 ns | 16.915 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 21.328 ns | 0.0455 ns | 0.0380 ns | 21.315 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 20.911 ns | 0.0293 ns | 0.0260 ns | 20.905 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.592 ns | 0.0333 ns | 0.0295 ns | 12.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 12.352 ns | 0.0179 ns | 0.0158 ns | 12.356 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.020 ns | 0.0682 ns | 0.0532 ns |  8.999 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.500 ns | 0.0745 ns | 0.0697 ns | 13.524 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 14.240 ns | 0.1222 ns | 0.1143 ns | 14.313 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.411 ns | 0.0261 ns | 0.0218 ns | 15.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.817 ns | 0.0340 ns | 0.0318 ns | 13.816 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.874 ns | 0.0587 ns | 0.0459 ns | 14.869 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.256 ns | 0.0324 ns | 0.0303 ns | 15.264 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 15.256 ns | 0.0288 ns | 0.0241 ns | 15.251 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 12.871 ns | 0.0239 ns | 0.0212 ns | 12.865 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 11.025 ns | 0.0884 ns | 0.0783 ns | 11.063 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.859 ns | 0.0199 ns | 0.0177 ns |  7.856 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.926 ns | 0.0328 ns | 0.0256 ns | 12.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 13.581 ns | 0.0206 ns | 0.0183 ns | 13.582 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 21.310 ns | 0.1019 ns | 0.0953 ns | 21.275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 18.269 ns | 0.1185 ns | 0.1108 ns | 18.221 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.114 ns | 0.0478 ns | 0.0447 ns | 17.117 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 22.969 ns | 0.0386 ns | 0.0361 ns | 22.970 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 20.990 ns | 0.0360 ns | 0.0337 ns | 20.982 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 13.696 ns | 0.0296 ns | 0.0263 ns | 13.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 11.021 ns | 0.0624 ns | 0.0487 ns | 11.035 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  8.992 ns | 0.2731 ns | 0.3646 ns |  8.870 ns |  0.67 |    0.03 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.330 ns | 0.0239 ns | 0.0224 ns | 13.332 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 14.224 ns | 0.0252 ns | 0.0223 ns | 14.222 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.542 ns | 0.2045 ns | 0.1913 ns | 21.613 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.069 ns | 0.0428 ns | 0.0379 ns | 18.067 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.110 ns | 0.0292 ns | 0.0273 ns | 17.109 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 21.519 ns | 0.0367 ns | 0.0325 ns | 21.516 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 21.197 ns | 0.0998 ns | 0.0885 ns | 21.217 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 13.387 ns | 0.0497 ns | 0.0465 ns | 13.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.703 ns | 0.0195 ns | 0.0183 ns | 10.702 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  8.863 ns | 0.2040 ns | 0.2925 ns |  8.996 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.565 ns | 0.0382 ns | 0.0357 ns | 13.568 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 13.840 ns | 0.0182 ns | 0.0152 ns | 13.836 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.419 ns | 0.0429 ns | 0.0380 ns | 15.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.867 ns | 0.0273 ns | 0.0228 ns | 14.871 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.477 ns | 0.0968 ns | 0.0858 ns | 15.451 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 14.900 ns | 0.0594 ns | 0.0496 ns | 14.876 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.619 ns | 0.0126 ns | 0.0118 ns | 14.615 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.673 ns | 0.0155 ns | 0.0137 ns | 12.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.829 ns | 0.0150 ns | 0.0140 ns | 10.829 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  8.863 ns | 0.0344 ns | 0.0322 ns |  8.860 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 15.939 ns | 0.0534 ns | 0.0473 ns | 15.928 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.625 ns | 0.1053 ns | 0.0985 ns | 14.661 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 21.045 ns | 0.0205 ns | 0.0171 ns | 21.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.465 ns | 0.0437 ns | 0.0365 ns | 18.468 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 16.861 ns | 0.0234 ns | 0.0207 ns | 16.861 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 21.547 ns | 0.0612 ns | 0.0543 ns | 21.535 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 20.650 ns | 0.0269 ns | 0.0238 ns | 20.652 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.976 ns | 0.0290 ns | 0.0257 ns | 12.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.155 ns | 0.0166 ns | 0.0147 ns | 11.152 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 |  7.741 ns | 0.0184 ns | 0.0172 ns |  7.739 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.163 ns | 0.0347 ns | 0.0325 ns | 14.158 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.276 ns | 0.0264 ns | 0.0246 ns | 14.272 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.281 ns | 0.0554 ns | 0.0491 ns | 21.273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.446 ns | 0.0381 ns | 0.0357 ns | 18.451 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.403 ns | 0.6706 ns | 1.1388 ns | 17.872 ns |  0.91 |    0.06 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 22.855 ns | 0.1405 ns | 0.1246 ns | 22.839 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 20.744 ns | 0.0630 ns | 0.0589 ns | 20.728 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 14.652 ns | 0.0192 ns | 0.0170 ns | 14.647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 11.222 ns | 0.0188 ns | 0.0166 ns | 11.219 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.417 ns | 0.1674 ns | 0.1860 ns |  7.538 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 13.031 ns | 0.0868 ns | 0.0811 ns | 12.989 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 13.933 ns | 0.0326 ns | 0.0272 ns | 13.936 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 17.261 ns | 0.0295 ns | 0.0247 ns | 17.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.032 ns | 0.0687 ns | 0.0643 ns | 14.042 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.511 ns | 0.1230 ns | 0.1027 ns | 15.530 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 14.824 ns | 0.0245 ns | 0.0218 ns | 14.824 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.722 ns | 0.0220 ns | 0.0205 ns | 14.720 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 72.900 ns | 0.1291 ns | 0.1208 ns | 72.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 73.708 ns | 0.1913 ns | 0.1696 ns | 73.664 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 57.285 ns | 0.2419 ns | 0.2020 ns | 57.197 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 74.256 ns | 0.1179 ns | 0.0984 ns | 74.265 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 74.203 ns | 0.1506 ns | 0.1258 ns | 74.267 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 80.663 ns | 0.8310 ns | 0.7774 ns | 80.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 84.132 ns | 0.3027 ns | 0.2684 ns | 84.045 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 66.180 ns | 0.6796 ns | 0.5675 ns | 66.427 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 81.493 ns | 0.1712 ns | 0.1336 ns | 81.505 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 81.186 ns | 0.4090 ns | 0.3826 ns | 80.976 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.943 ns | 0.0547 ns | 0.0512 ns | 13.925 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.931 ns | 0.0183 ns | 0.0171 ns | 12.928 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 12.591 ns | 0.2681 ns | 0.2508 ns | 12.384 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.420 ns | 0.0203 ns | 0.0190 ns | 14.422 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 14.129 ns | 0.0175 ns | 0.0163 ns | 14.127 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 17.755 ns | 0.0307 ns | 0.0272 ns | 17.754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.827 ns | 0.0332 ns | 0.0259 ns | 13.815 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 16.283 ns | 0.0242 ns | 0.0226 ns | 16.287 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 14.908 ns | 0.0238 ns | 0.0223 ns | 14.899 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 16.873 ns | 0.0493 ns | 0.0412 ns | 16.859 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.754 ns | 0.0242 ns | 0.0226 ns | 13.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 13.528 ns | 0.0211 ns | 0.0164 ns | 13.523 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.203 ns | 0.2419 ns | 0.2263 ns | 13.360 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 15.940 ns | 0.0787 ns | 0.0737 ns | 15.965 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.575 ns | 0.0214 ns | 0.0200 ns | 14.576 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 12.875 ns | 0.0245 ns | 0.0217 ns | 12.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.876 ns | 0.0302 ns | 0.0252 ns | 10.876 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  7.637 ns | 0.0292 ns | 0.0259 ns |  7.627 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 14.196 ns | 0.0336 ns | 0.0314 ns | 14.193 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.643 ns | 0.0345 ns | 0.0323 ns | 13.645 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 21.266 ns | 0.0288 ns | 0.0270 ns | 21.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.980 ns | 0.1200 ns | 0.1123 ns | 17.927 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 17.028 ns | 0.0352 ns | 0.0329 ns | 17.034 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 21.304 ns | 0.0721 ns | 0.0639 ns | 21.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 21.083 ns | 0.0797 ns | 0.0745 ns | 21.057 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 14.444 ns | 0.0176 ns | 0.0147 ns | 14.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.023 ns | 0.0207 ns | 0.0194 ns | 11.019 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.723 ns | 0.0152 ns | 0.0142 ns |  7.724 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.301 ns | 0.0223 ns | 0.0208 ns | 13.307 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 15.086 ns | 0.1319 ns | 0.1234 ns | 15.097 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.066 ns | 0.0346 ns | 0.0324 ns | 21.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 20.385 ns | 0.0472 ns | 0.0418 ns | 20.373 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.758 ns | 0.3525 ns | 0.3297 ns | 18.777 ns |  0.89 |    0.02 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 21.358 ns | 0.0631 ns | 0.0591 ns | 21.341 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 20.958 ns | 0.0358 ns | 0.0317 ns | 20.951 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 13.175 ns | 0.0166 ns | 0.0148 ns | 13.176 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.978 ns | 0.0113 ns | 0.0101 ns | 10.980 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.561 ns | 0.0143 ns | 0.0134 ns |  7.558 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 13.221 ns | 0.0276 ns | 0.0231 ns | 13.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 13.958 ns | 0.0300 ns | 0.0266 ns | 13.963 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.421 ns | 0.0276 ns | 0.0259 ns | 15.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.951 ns | 0.0239 ns | 0.0223 ns | 14.951 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.246 ns | 0.0416 ns | 0.0389 ns | 16.248 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 17.049 ns | 0.0168 ns | 0.0157 ns | 17.050 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 16.543 ns | 0.0646 ns | 0.0604 ns | 16.524 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 12.807 ns | 0.0254 ns | 0.0212 ns | 12.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.682 ns | 0.0536 ns | 0.0502 ns | 11.692 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.432 ns | 0.0877 ns | 0.0820 ns |  7.448 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 13.031 ns | 0.0216 ns | 0.0202 ns | 13.021 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 13.979 ns | 0.0471 ns | 0.0417 ns | 13.990 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 21.325 ns | 0.0695 ns | 0.0651 ns | 21.320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 19.105 ns | 0.0504 ns | 0.0471 ns | 19.096 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.720 ns | 0.3809 ns | 0.4386 ns | 17.981 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 21.459 ns | 0.0430 ns | 0.0403 ns | 21.450 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 20.766 ns | 0.0699 ns | 0.0584 ns | 20.747 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.038 ns | 0.0327 ns | 0.0290 ns | 13.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.104 ns | 0.0169 ns | 0.0150 ns | 11.098 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.306 ns | 0.1920 ns | 0.2358 ns |  8.447 ns |  0.63 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.325 ns | 0.0248 ns | 0.0207 ns | 13.322 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 14.301 ns | 0.0183 ns | 0.0153 ns | 14.301 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 21.252 ns | 0.0248 ns | 0.0220 ns | 21.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.166 ns | 0.1244 ns | 0.1039 ns | 18.194 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.486 ns | 0.3771 ns | 0.7265 ns | 17.148 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 22.797 ns | 0.1700 ns | 0.1507 ns | 22.752 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 20.985 ns | 0.0382 ns | 0.0357 ns | 20.997 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 13.307 ns | 0.0202 ns | 0.0189 ns | 13.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 11.068 ns | 0.0234 ns | 0.0219 ns | 11.057 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  7.976 ns | 0.1269 ns | 0.1187 ns |  7.952 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 12.968 ns | 0.0182 ns | 0.0170 ns | 12.969 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 13.950 ns | 0.0274 ns | 0.0243 ns | 13.948 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.431 ns | 0.0471 ns | 0.0440 ns | 15.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.628 ns | 0.0293 ns | 0.0274 ns | 14.621 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 16.874 ns | 0.3607 ns | 0.5722 ns | 16.650 ns |  1.12 |    0.04 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 17.104 ns | 0.0128 ns | 0.0100 ns | 17.102 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 15.512 ns | 0.0206 ns | 0.0161 ns | 15.516 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.555 ns | 0.0182 ns | 0.0161 ns | 13.549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.860 ns | 0.0258 ns | 0.0242 ns | 10.866 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.553 ns | 0.0217 ns | 0.0181 ns |  7.557 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 14.227 ns | 0.0493 ns | 0.0461 ns | 14.214 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 14.095 ns | 0.0280 ns | 0.0234 ns | 14.089 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 21.568 ns | 0.0407 ns | 0.0380 ns | 21.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 19.258 ns | 0.0547 ns | 0.0512 ns | 19.261 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.117 ns | 0.1823 ns | 0.1705 ns | 18.122 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 23.281 ns | 0.1320 ns | 0.1170 ns | 23.233 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 21.054 ns | 0.0363 ns | 0.0339 ns | 21.055 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 14.196 ns | 0.0364 ns | 0.0340 ns | 14.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 13.817 ns | 0.0217 ns | 0.0193 ns | 13.816 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.798 ns | 0.0122 ns | 0.0102 ns |  8.797 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 13.743 ns | 0.0397 ns | 0.0372 ns | 13.745 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.848 ns | 0.0370 ns | 0.0328 ns | 14.838 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.167 ns | 0.0312 ns | 0.0291 ns | 22.175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.784 ns | 0.1276 ns | 0.1131 ns | 18.742 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.004 ns | 0.0539 ns | 0.0504 ns | 17.999 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 21.930 ns | 0.0643 ns | 0.0570 ns | 21.924 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 21.059 ns | 0.0325 ns | 0.0304 ns | 21.065 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.595 ns | 0.0531 ns | 0.0471 ns | 12.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.183 ns | 0.0214 ns | 0.0200 ns | 12.180 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.199 ns | 0.2016 ns | 0.1886 ns |  9.269 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 13.286 ns | 0.0258 ns | 0.0242 ns | 13.282 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 14.151 ns | 0.0339 ns | 0.0317 ns | 14.151 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.744 ns | 0.0209 ns | 0.0196 ns | 15.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.830 ns | 0.0208 ns | 0.0185 ns | 13.829 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.301 ns | 0.1716 ns | 0.1605 ns | 15.326 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.809 ns | 0.0377 ns | 0.0315 ns | 14.803 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 15.367 ns | 0.0748 ns | 0.0699 ns | 15.342 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 15.503 ns | 0.1379 ns | 0.1290 ns | 15.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 14.667 ns | 0.0153 ns | 0.0135 ns | 14.666 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.469 ns | 0.0258 ns | 0.0229 ns | 13.473 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 15.031 ns | 0.0363 ns | 0.0340 ns | 15.023 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 14.663 ns | 0.0285 ns | 0.0238 ns | 14.658 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.551 ns | 0.0887 ns | 0.0830 ns | 12.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 10.425 ns | 0.0190 ns | 0.0148 ns | 10.425 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 13.733 ns | 0.0281 ns | 0.0219 ns | 13.728 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.550 ns | 0.0234 ns | 0.0207 ns | 12.546 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.659 ns | 0.0100 ns | 0.0093 ns | 12.660 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 16.107 ns | 0.0191 ns | 0.0170 ns | 16.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 14.953 ns | 0.1410 ns | 0.1319 ns | 14.893 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 14.656 ns | 0.3180 ns | 0.4759 ns | 14.907 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 16.440 ns | 0.1106 ns | 0.1035 ns | 16.393 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 15.695 ns | 0.0422 ns | 0.0395 ns | 15.693 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 20.016 ns | 0.1992 ns | 0.1863 ns | 19.894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 15.115 ns | 0.0229 ns | 0.0215 ns | 15.112 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 14.204 ns | 0.0221 ns | 0.0172 ns | 14.207 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.729 ns | 0.1169 ns | 0.1093 ns | 18.683 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 17.846 ns | 0.0221 ns | 0.0207 ns | 17.853 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 20.794 ns | 0.0232 ns | 0.0205 ns | 20.802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 22.097 ns | 0.0841 ns | 0.0745 ns | 22.104 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 16.411 ns | 0.3548 ns | 0.5418 ns | 16.148 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 19.734 ns | 0.1398 ns | 0.1308 ns | 19.665 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 19.484 ns | 0.0542 ns | 0.0480 ns | 19.475 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 15.380 ns | 0.0154 ns | 0.0144 ns | 15.380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.791 ns | 0.0369 ns | 0.0288 ns | 13.802 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 16.790 ns | 0.3531 ns | 0.8794 ns | 16.998 ns |  1.04 |    0.11 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 17.706 ns | 0.0384 ns | 0.0320 ns | 17.710 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 14.779 ns | 0.0320 ns | 0.0299 ns | 14.784 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.605 ns | 0.1480 ns | 0.1385 ns | 15.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.890 ns | 0.0287 ns | 0.0254 ns | 13.889 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 15.404 ns | 0.1598 ns | 0.1495 ns | 15.335 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 16.630 ns | 0.0283 ns | 0.0251 ns | 16.624 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 14.841 ns | 0.0405 ns | 0.0379 ns | 14.834 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 13.499 ns | 0.0141 ns | 0.0125 ns | 13.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 11.402 ns | 0.0109 ns | 0.0097 ns | 11.405 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 11.070 ns | 0.0799 ns | 0.0747 ns | 11.050 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 13.879 ns | 0.0170 ns | 0.0151 ns | 13.876 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 13.805 ns | 0.0223 ns | 0.0198 ns | 13.801 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 17.306 ns | 0.0301 ns | 0.0267 ns | 17.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.309 ns | 0.0242 ns | 0.0215 ns | 15.306 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.930 ns | 0.0392 ns | 0.0348 ns | 13.923 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.935 ns | 0.0241 ns | 0.0188 ns | 16.933 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 17.345 ns | 0.0312 ns | 0.0277 ns | 17.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 13.209 ns | 0.0146 ns | 0.0136 ns | 13.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 11.436 ns | 0.0158 ns | 0.0140 ns | 11.438 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 13.106 ns | 0.2851 ns | 0.5888 ns | 13.329 ns |  0.95 |    0.06 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 16.444 ns | 0.0235 ns | 0.0208 ns | 16.444 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 13.809 ns | 0.0267 ns | 0.0250 ns | 13.820 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 15.410 ns | 0.0319 ns | 0.0282 ns | 15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.556 ns | 0.0245 ns | 0.0217 ns | 14.551 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 15.450 ns | 0.0146 ns | 0.0129 ns | 15.451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 14.853 ns | 0.0270 ns | 0.0252 ns | 14.853 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 15.523 ns | 0.0278 ns | 0.0260 ns | 15.519 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 22.596 ns | 0.0988 ns | 0.0876 ns | 22.593 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.879 ns | 0.0311 ns | 0.0276 ns | 16.881 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.762 ns | 0.0497 ns | 0.0465 ns | 13.765 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.823 ns | 0.0428 ns | 0.0379 ns | 19.832 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 19.827 ns | 0.0612 ns | 0.0572 ns | 19.822 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 20.071 ns | 0.0439 ns | 0.0410 ns | 20.077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 21.447 ns | 0.2345 ns | 0.2193 ns | 21.378 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.234 ns | 0.0471 ns | 0.0368 ns | 17.232 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 20.326 ns | 0.0260 ns | 0.0231 ns | 20.326 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 20.107 ns | 0.0855 ns | 0.0714 ns | 20.089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 22.468 ns | 0.0321 ns | 0.0300 ns | 22.462 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 17.433 ns | 0.0422 ns | 0.0374 ns | 17.432 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.063 ns | 0.0467 ns | 0.0437 ns | 14.069 ns |  0.63 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 22.355 ns | 0.0544 ns | 0.0482 ns | 22.356 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 20.096 ns | 0.0360 ns | 0.0319 ns | 20.096 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.237 ns | 0.0436 ns | 0.0386 ns | 20.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.662 ns | 0.0589 ns | 0.0551 ns | 17.680 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.055 ns | 0.0300 ns | 0.0281 ns | 19.051 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 21.975 ns | 0.1334 ns | 0.1248 ns | 21.931 ns |  1.09 |    0.01 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 20.409 ns | 0.1819 ns | 0.1701 ns | 20.467 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 14.667 ns | 0.0146 ns | 0.0114 ns | 14.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.602 ns | 0.0644 ns | 0.0603 ns | 12.584 ns |  0.86 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  8.128 ns | 0.0197 ns | 0.0165 ns |  8.133 ns |  0.55 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 13.421 ns | 0.0156 ns | 0.0138 ns | 13.420 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 13.298 ns | 0.0214 ns | 0.0167 ns | 13.297 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 16.723 ns | 0.0280 ns | 0.0262 ns | 16.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.774 ns | 0.0146 ns | 0.0122 ns | 14.775 ns |  0.88 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.191 ns | 0.1264 ns | 0.1182 ns | 12.218 ns |  0.73 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 16.600 ns | 0.0912 ns | 0.0853 ns | 16.638 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.791 ns | 0.0209 ns | 0.0185 ns | 14.795 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 15.552 ns | 0.0760 ns | 0.0674 ns | 15.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 12.142 ns | 0.0175 ns | 0.0164 ns | 12.140 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  7.544 ns | 0.0198 ns | 0.0185 ns |  7.539 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.739 ns | 0.0224 ns | 0.0198 ns | 13.744 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 14.076 ns | 0.1607 ns | 0.1503 ns | 14.100 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 18.364 ns | 0.0266 ns | 0.0222 ns | 18.371 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.453 ns | 0.0527 ns | 0.0440 ns | 15.461 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 15.185 ns | 0.1984 ns | 0.1856 ns | 15.091 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 18.664 ns | 0.0566 ns | 0.0529 ns | 18.641 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 17.086 ns | 0.0459 ns | 0.0358 ns | 17.086 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 14.757 ns | 0.0219 ns | 0.0205 ns | 14.755 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 12.398 ns | 0.0159 ns | 0.0149 ns | 12.400 ns |  0.84 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  7.719 ns | 0.0246 ns | 0.0218 ns |  7.714 ns |  0.52 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 13.096 ns | 0.0135 ns | 0.0119 ns | 13.100 ns |  0.89 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 14.541 ns | 0.0208 ns | 0.0184 ns | 14.537 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.275 ns | 0.1523 ns | 0.1424 ns | 17.314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.225 ns | 0.0308 ns | 0.0273 ns | 16.220 ns |  0.94 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.070 ns | 0.0352 ns | 0.0330 ns | 16.073 ns |  0.93 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 18.646 ns | 0.0307 ns | 0.0287 ns | 18.648 ns |  1.08 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.316 ns | 0.1706 ns | 0.1596 ns | 17.344 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 15.360 ns | 0.0130 ns | 0.0101 ns | 15.359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.017 ns | 0.0569 ns | 0.0475 ns | 12.035 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.671 ns | 0.0364 ns | 0.0322 ns |  7.680 ns |  0.50 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 13.788 ns | 0.0232 ns | 0.0193 ns | 13.789 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 13.537 ns | 0.0328 ns | 0.0290 ns | 13.532 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.623 ns | 0.1011 ns | 0.0946 ns | 15.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.873 ns | 0.0156 ns | 0.0138 ns | 13.875 ns |  0.89 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.569 ns | 0.7302 ns | 0.9748 ns | 12.011 ns |  0.83 |    0.07 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.993 ns | 0.0189 ns | 0.0158 ns | 14.995 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 14.758 ns | 0.0293 ns | 0.0260 ns | 14.753 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 14.176 ns | 0.0263 ns | 0.0220 ns | 14.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.800 ns | 0.0845 ns | 0.0791 ns | 10.755 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.096 ns | 0.0201 ns | 0.0178 ns |  7.098 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.976 ns | 0.0176 ns | 0.0147 ns | 12.972 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 13.413 ns | 0.0692 ns | 0.0648 ns | 13.421 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.650 ns | 0.0602 ns | 0.0563 ns | 49.659 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 44.941 ns | 0.0723 ns | 0.0640 ns | 44.955 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 38.392 ns | 0.7856 ns | 0.8068 ns | 37.852 ns |  0.77 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 48.682 ns | 0.1071 ns | 0.0950 ns | 48.679 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 49.944 ns | 0.1029 ns | 0.0859 ns | 49.910 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 14.973 ns | 0.1320 ns | 0.1235 ns | 14.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 14.069 ns | 0.0290 ns | 0.0257 ns | 14.066 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.758 ns | 0.0436 ns | 0.0408 ns |  7.749 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 13.396 ns | 0.0318 ns | 0.0265 ns | 13.395 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 13.986 ns | 0.0313 ns | 0.0261 ns | 13.984 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 47.409 ns | 0.0748 ns | 0.0663 ns | 47.406 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 46.594 ns | 0.1754 ns | 0.1641 ns | 46.595 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 41.537 ns | 0.4494 ns | 0.4204 ns | 41.574 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 49.191 ns | 0.2550 ns | 0.2385 ns | 49.284 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 51.160 ns | 0.0716 ns | 0.0635 ns | 51.168 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.392 ns | 0.0278 ns | 0.0232 ns | 14.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 13.378 ns | 0.0266 ns | 0.0249 ns | 13.376 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.392 ns | 0.0177 ns | 0.0157 ns |  7.388 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.706 ns | 0.0257 ns | 0.0227 ns | 13.706 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 13.429 ns | 0.0769 ns | 0.0720 ns | 13.454 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.972 ns | 0.1519 ns | 0.1421 ns | 15.909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.878 ns | 0.0136 ns | 0.0114 ns | 13.876 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.420 ns | 0.0141 ns | 0.0125 ns | 13.422 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 14.975 ns | 0.0388 ns | 0.0363 ns | 14.973 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 14.793 ns | 0.0477 ns | 0.0398 ns | 14.780 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 13.295 ns | 0.0211 ns | 0.0198 ns | 13.288 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 11.278 ns | 0.0172 ns | 0.0161 ns | 11.272 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 11.773 ns | 0.1392 ns | 0.1302 ns | 11.810 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 15.655 ns | 0.0826 ns | 0.0773 ns | 15.674 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.115 ns | 0.0842 ns | 0.0787 ns | 14.157 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 17.517 ns | 0.1156 ns | 0.1081 ns | 17.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.697 ns | 0.0328 ns | 0.0274 ns | 15.693 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.869 ns | 0.0513 ns | 0.0428 ns | 15.870 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 17.611 ns | 0.0242 ns | 0.0215 ns | 17.608 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 17.456 ns | 0.0195 ns | 0.0173 ns | 17.456 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 13.660 ns | 0.0260 ns | 0.0244 ns | 13.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 11.459 ns | 0.0582 ns | 0.0516 ns | 11.442 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.087 ns | 0.0825 ns | 0.0731 ns | 11.081 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 15.284 ns | 0.0197 ns | 0.0184 ns | 15.279 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.104 ns | 0.0166 ns | 0.0148 ns | 14.105 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 15.440 ns | 0.0378 ns | 0.0316 ns | 15.441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 15.188 ns | 0.0249 ns | 0.0233 ns | 15.191 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.621 ns | 0.0874 ns | 0.0817 ns | 13.654 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 15.028 ns | 0.1100 ns | 0.1029 ns | 15.036 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 14.884 ns | 0.0322 ns | 0.0301 ns | 14.883 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 43.712 ns | 0.0823 ns | 0.0687 ns | 43.687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 38.986 ns | 0.0540 ns | 0.0451 ns | 38.970 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.867 ns | 0.0485 ns | 0.0454 ns | 35.851 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 42.971 ns | 0.0708 ns | 0.0663 ns | 42.982 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.096 ns | 0.0758 ns | 0.0709 ns | 40.107 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 17.441 ns | 0.0261 ns | 0.0231 ns | 17.432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.694 ns | 0.0360 ns | 0.0336 ns | 15.690 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.228 ns | 0.3278 ns | 0.3367 ns | 15.313 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 18.203 ns | 0.0347 ns | 0.0324 ns | 18.200 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 17.494 ns | 0.0599 ns | 0.0531 ns | 17.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 40.485 ns | 0.1333 ns | 0.1113 ns | 40.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 39.726 ns | 0.0463 ns | 0.0434 ns | 39.728 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 36.524 ns | 0.3293 ns | 0.2750 ns | 36.624 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 39.244 ns | 0.0910 ns | 0.0851 ns | 39.219 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 39.998 ns | 0.0601 ns | 0.0533 ns | 39.984 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.416 ns | 0.0196 ns | 0.0174 ns | 17.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.676 ns | 0.0203 ns | 0.0190 ns | 15.673 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.824 ns | 0.3424 ns | 0.6347 ns | 15.476 ns |  0.95 |    0.03 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 18.556 ns | 0.0177 ns | 0.0166 ns | 18.559 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 17.960 ns | 0.0248 ns | 0.0220 ns | 17.954 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.189 ns | 0.0537 ns | 0.0502 ns | 42.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 39.755 ns | 0.0418 ns | 0.0370 ns | 39.745 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.886 ns | 0.7514 ns | 0.6661 ns | 38.225 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 43.706 ns | 0.0658 ns | 0.0583 ns | 43.713 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.025 ns | 0.0801 ns | 0.0749 ns | 40.016 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.615 ns | 0.1224 ns | 0.1144 ns | 15.562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.210 ns | 0.0169 ns | 0.0150 ns | 14.212 ns |  0.91 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.871 ns | 0.0497 ns | 0.0388 ns | 14.864 ns |  0.95 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 14.926 ns | 0.0290 ns | 0.0257 ns | 14.920 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 15.132 ns | 0.0148 ns | 0.0138 ns | 15.133 ns |  0.97 |    0.01 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DoubleNullable.From_Char_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DoubleNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
