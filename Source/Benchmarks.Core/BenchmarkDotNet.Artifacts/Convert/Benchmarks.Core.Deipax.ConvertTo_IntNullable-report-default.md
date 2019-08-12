
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
                                             From_Bool | .NET Core 2.0 | 13.306 ns | 0.0197 ns | 0.0184 ns | 13.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 11.106 ns | 0.0685 ns | 0.0641 ns | 11.139 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  9.938 ns | 0.1356 ns | 0.1269 ns |  9.981 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 12.236 ns | 0.0231 ns | 0.0192 ns | 12.229 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 13.287 ns | 0.0154 ns | 0.0129 ns | 13.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 19.620 ns | 0.0184 ns | 0.0172 ns | 19.617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 18.203 ns | 0.0160 ns | 0.0149 ns | 18.205 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.887 ns | 0.0786 ns | 0.0736 ns | 17.862 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 27.214 ns | 0.0547 ns | 0.0512 ns | 27.222 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 27.236 ns | 0.0243 ns | 0.0215 ns | 27.235 ns |  1.39 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.085 ns | 0.0169 ns | 0.0158 ns | 12.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 11.523 ns | 0.0222 ns | 0.0197 ns | 11.519 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 | 10.137 ns | 0.0181 ns | 0.0169 ns | 10.142 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 12.689 ns | 0.0138 ns | 0.0115 ns | 12.690 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 12.730 ns | 0.0157 ns | 0.0139 ns | 12.728 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.703 ns | 0.0247 ns | 0.0193 ns | 18.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.867 ns | 0.0775 ns | 0.0725 ns | 17.898 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.575 ns | 0.0985 ns | 0.0921 ns | 18.553 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 29.989 ns | 0.0251 ns | 0.0222 ns | 29.981 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 28.899 ns | 0.2358 ns | 0.2206 ns | 29.018 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 12.380 ns | 0.0114 ns | 0.0101 ns | 12.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.458 ns | 0.0099 ns | 0.0088 ns | 10.460 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  9.689 ns | 0.0106 ns | 0.0099 ns |  9.688 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 13.352 ns | 0.0142 ns | 0.0133 ns | 13.352 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 12.728 ns | 0.0100 ns | 0.0093 ns | 12.729 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.522 ns | 0.0298 ns | 0.0278 ns | 14.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.636 ns | 0.0173 ns | 0.0162 ns | 13.633 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.563 ns | 0.0136 ns | 0.0120 ns | 13.564 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 24.571 ns | 0.0507 ns | 0.0474 ns | 24.581 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 23.194 ns | 0.0924 ns | 0.0865 ns | 23.226 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 12.241 ns | 0.0191 ns | 0.0179 ns | 12.235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.488 ns | 0.0605 ns | 0.0566 ns | 10.504 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  9.444 ns | 0.0122 ns | 0.0114 ns |  9.442 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 12.971 ns | 0.0118 ns | 0.0111 ns | 12.975 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 12.227 ns | 0.0220 ns | 0.0183 ns | 12.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 18.763 ns | 0.0229 ns | 0.0214 ns | 18.757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 18.189 ns | 0.0180 ns | 0.0169 ns | 18.189 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 17.568 ns | 0.0790 ns | 0.0739 ns | 17.529 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 28.820 ns | 0.0410 ns | 0.0342 ns | 28.811 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 27.685 ns | 0.0297 ns | 0.0263 ns | 27.688 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.859 ns | 0.0141 ns | 0.0132 ns | 11.860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.671 ns | 0.0110 ns | 0.0103 ns | 10.671 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 | 10.135 ns | 0.0063 ns | 0.0056 ns | 10.134 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.780 ns | 0.0955 ns | 0.0894 ns | 12.719 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 13.682 ns | 0.0811 ns | 0.0719 ns | 13.713 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.641 ns | 0.0294 ns | 0.0246 ns | 18.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.351 ns | 0.0655 ns | 0.0581 ns | 18.366 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.037 ns | 0.0247 ns | 0.0219 ns | 17.033 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 27.198 ns | 0.0628 ns | 0.0524 ns | 27.203 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 29.363 ns | 0.0186 ns | 0.0174 ns | 29.367 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.825 ns | 0.0175 ns | 0.0164 ns | 11.824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.766 ns | 0.0133 ns | 0.0124 ns | 10.769 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  9.746 ns | 0.0600 ns | 0.0561 ns |  9.764 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 12.714 ns | 0.0199 ns | 0.0186 ns | 12.714 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 12.993 ns | 0.0213 ns | 0.0199 ns | 12.990 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.724 ns | 0.0107 ns | 0.0090 ns | 14.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.498 ns | 0.0077 ns | 0.0068 ns | 13.499 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.448 ns | 0.3348 ns | 0.7825 ns | 15.793 ns |  0.95 |    0.05 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 23.303 ns | 0.0840 ns | 0.0786 ns | 23.331 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 23.158 ns | 0.0647 ns | 0.0606 ns | 23.162 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 13.105 ns | 0.0174 ns | 0.0163 ns | 13.104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 11.897 ns | 0.0756 ns | 0.0631 ns | 11.921 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  9.656 ns | 0.0168 ns | 0.0149 ns |  9.651 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 12.241 ns | 0.0071 ns | 0.0063 ns | 12.239 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 12.208 ns | 0.0122 ns | 0.0114 ns | 12.205 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 18.940 ns | 0.0436 ns | 0.0408 ns | 18.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 18.415 ns | 0.0363 ns | 0.0322 ns | 18.403 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.719 ns | 0.0253 ns | 0.0211 ns | 17.720 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 26.931 ns | 0.0208 ns | 0.0184 ns | 26.929 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 26.975 ns | 0.0398 ns | 0.0353 ns | 26.966 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.861 ns | 0.0127 ns | 0.0113 ns | 11.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.651 ns | 0.0139 ns | 0.0123 ns | 10.651 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 | 10.139 ns | 0.0244 ns | 0.0216 ns | 10.136 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 13.277 ns | 0.0849 ns | 0.0794 ns | 13.243 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 12.861 ns | 0.0512 ns | 0.0453 ns | 12.871 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.904 ns | 0.0168 ns | 0.0158 ns | 18.904 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.493 ns | 0.0970 ns | 0.0907 ns | 18.462 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.380 ns | 0.0747 ns | 0.0662 ns | 17.403 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 27.153 ns | 0.0181 ns | 0.0161 ns | 27.157 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 28.354 ns | 0.0493 ns | 0.0461 ns | 28.359 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 11.900 ns | 0.0521 ns | 0.0487 ns | 11.929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.454 ns | 0.0094 ns | 0.0083 ns | 10.455 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  9.675 ns | 0.0141 ns | 0.0132 ns |  9.677 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 12.704 ns | 0.0117 ns | 0.0110 ns | 12.705 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 12.724 ns | 0.0079 ns | 0.0066 ns | 12.724 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.504 ns | 0.0196 ns | 0.0163 ns | 14.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.090 ns | 0.0128 ns | 0.0120 ns | 14.091 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.344 ns | 0.0213 ns | 0.0189 ns | 13.344 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 24.761 ns | 0.3393 ns | 0.3174 ns | 24.827 ns |  1.71 |    0.02 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 27.329 ns | 0.0678 ns | 0.0634 ns | 27.326 ns |  1.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.337 ns | 0.0114 ns | 0.0106 ns | 12.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.197 ns | 0.0469 ns | 0.0439 ns | 11.181 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 | 10.780 ns | 0.2367 ns | 0.4082 ns | 10.988 ns |  0.85 |    0.04 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.472 ns | 0.0126 ns | 0.0112 ns | 13.467 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 13.551 ns | 0.0226 ns | 0.0211 ns | 13.552 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.285 ns | 0.0535 ns | 0.0500 ns | 12.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.320 ns | 0.0107 ns | 0.0089 ns | 11.319 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  9.921 ns | 0.0167 ns | 0.0140 ns |  9.920 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.505 ns | 0.0490 ns | 0.0434 ns | 13.513 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 14.069 ns | 0.1059 ns | 0.0938 ns | 14.076 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.297 ns | 0.0137 ns | 0.0121 ns | 12.296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.633 ns | 0.0177 ns | 0.0157 ns | 11.634 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 | 10.128 ns | 0.0116 ns | 0.0108 ns | 10.130 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 13.366 ns | 0.0117 ns | 0.0104 ns | 13.366 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.923 ns | 0.0184 ns | 0.0163 ns | 13.923 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.536 ns | 0.0539 ns | 0.0504 ns | 14.517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.372 ns | 0.0110 ns | 0.0103 ns | 13.371 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.726 ns | 0.0295 ns | 0.0262 ns | 14.727 ns |  1.01 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 23.267 ns | 0.1486 ns | 0.1390 ns | 23.297 ns |  1.60 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 23.248 ns | 0.1146 ns | 0.1072 ns | 23.289 ns |  1.60 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 23.395 ns | 0.0251 ns | 0.0235 ns | 23.400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 21.852 ns | 0.0849 ns | 0.0794 ns | 21.833 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.735 ns | 0.0320 ns | 0.0299 ns | 13.737 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 19.616 ns | 0.0967 ns | 0.0905 ns | 19.571 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 19.563 ns | 0.0283 ns | 0.0236 ns | 19.556 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 30.513 ns | 0.0278 ns | 0.0247 ns | 30.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 29.115 ns | 0.0133 ns | 0.0111 ns | 29.115 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 27.051 ns | 0.1106 ns | 0.1034 ns | 27.051 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 32.716 ns | 0.0544 ns | 0.0455 ns | 32.714 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 34.310 ns | 0.1742 ns | 0.1630 ns | 34.219 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 24.897 ns | 0.0251 ns | 0.0210 ns | 24.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 23.872 ns | 0.0318 ns | 0.0282 ns | 23.869 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 18.927 ns | 0.0312 ns | 0.0292 ns | 18.915 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 20.626 ns | 0.0281 ns | 0.0234 ns | 20.622 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 21.613 ns | 0.0183 ns | 0.0162 ns | 21.611 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 30.251 ns | 0.0187 ns | 0.0146 ns | 30.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 29.159 ns | 0.1070 ns | 0.1001 ns | 29.125 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 22.283 ns | 0.4699 ns | 0.6432 ns | 22.702 ns |  0.72 |    0.02 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 32.988 ns | 0.0361 ns | 0.0338 ns | 32.976 ns |  1.09 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 32.750 ns | 0.0289 ns | 0.0241 ns | 32.746 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.561 ns | 0.0074 ns | 0.0065 ns | 12.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.515 ns | 0.0177 ns | 0.0157 ns | 11.514 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 | 10.054 ns | 0.0910 ns | 0.0851 ns | 10.072 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 14.925 ns | 0.0214 ns | 0.0200 ns | 14.921 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.838 ns | 0.0225 ns | 0.0188 ns | 13.834 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.558 ns | 0.0229 ns | 0.0191 ns | 14.555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.380 ns | 0.0113 ns | 0.0106 ns | 13.383 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.278 ns | 0.0376 ns | 0.0333 ns | 13.288 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 21.940 ns | 0.0360 ns | 0.0336 ns | 21.941 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 21.810 ns | 0.0315 ns | 0.0294 ns | 21.802 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.880 ns | 0.0196 ns | 0.0183 ns | 13.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.358 ns | 0.0453 ns | 0.0378 ns | 12.363 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 11.907 ns | 0.2174 ns | 0.2034 ns | 11.744 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net461 | 14.387 ns | 0.0164 ns | 0.0146 ns | 14.390 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.332 ns | 0.0213 ns | 0.0189 ns | 14.334 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 20.338 ns | 0.0208 ns | 0.0162 ns | 20.341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.917 ns | 0.0238 ns | 0.0223 ns | 18.925 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 19.036 ns | 0.0471 ns | 0.0441 ns | 19.042 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 27.901 ns | 0.0278 ns | 0.0247 ns | 27.906 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 27.813 ns | 0.0897 ns | 0.0839 ns | 27.805 ns |  1.37 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 14.746 ns | 0.0171 ns | 0.0160 ns | 14.749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.921 ns | 0.0260 ns | 0.0243 ns | 12.923 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 12.311 ns | 0.1520 ns | 0.1422 ns | 12.224 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 15.231 ns | 0.0176 ns | 0.0156 ns | 15.230 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.806 ns | 0.0338 ns | 0.0299 ns | 15.805 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.768 ns | 0.0248 ns | 0.0220 ns | 20.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.617 ns | 0.0306 ns | 0.0286 ns | 19.612 ns |  0.94 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.917 ns | 0.0297 ns | 0.0248 ns | 18.916 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 30.958 ns | 0.0253 ns | 0.0237 ns | 30.954 ns |  1.49 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 28.102 ns | 0.0743 ns | 0.0695 ns | 28.105 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.317 ns | 0.0139 ns | 0.0123 ns | 12.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.928 ns | 0.0394 ns | 0.0369 ns | 11.931 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 | 10.265 ns | 0.0572 ns | 0.0535 ns | 10.258 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 13.542 ns | 0.0182 ns | 0.0161 ns | 13.540 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 15.990 ns | 0.0196 ns | 0.0174 ns | 15.984 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.503 ns | 0.0137 ns | 0.0128 ns | 14.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.663 ns | 0.0637 ns | 0.0596 ns | 13.690 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.119 ns | 0.0160 ns | 0.0142 ns | 13.123 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 24.777 ns | 0.0688 ns | 0.0574 ns | 24.780 ns |  1.71 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 22.755 ns | 0.0202 ns | 0.0189 ns | 22.759 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.820 ns | 0.0142 ns | 0.0126 ns | 11.820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.935 ns | 0.0178 ns | 0.0166 ns | 10.937 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  9.659 ns | 0.0190 ns | 0.0177 ns |  9.660 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 12.260 ns | 0.0118 ns | 0.0098 ns | 12.262 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 12.265 ns | 0.0664 ns | 0.0621 ns | 12.237 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.713 ns | 0.0236 ns | 0.0209 ns | 18.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 17.517 ns | 0.0336 ns | 0.0298 ns | 17.512 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 17.321 ns | 0.0575 ns | 0.0538 ns | 17.308 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 28.773 ns | 0.0535 ns | 0.0500 ns | 28.772 ns |  1.54 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 27.431 ns | 0.0290 ns | 0.0272 ns | 27.428 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.865 ns | 0.0131 ns | 0.0116 ns | 11.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.787 ns | 0.0099 ns | 0.0088 ns | 10.783 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 | 10.360 ns | 0.0137 ns | 0.0128 ns | 10.354 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.730 ns | 0.0125 ns | 0.0117 ns | 12.728 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.716 ns | 0.0135 ns | 0.0127 ns | 12.714 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.526 ns | 0.0222 ns | 0.0208 ns | 20.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.412 ns | 0.0182 ns | 0.0142 ns | 19.412 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.352 ns | 0.0329 ns | 0.0292 ns | 17.349 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 27.350 ns | 0.0267 ns | 0.0237 ns | 27.352 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 29.140 ns | 0.1120 ns | 0.1047 ns | 29.088 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.855 ns | 0.0334 ns | 0.0312 ns | 11.846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.542 ns | 0.0629 ns | 0.0588 ns | 10.555 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  9.823 ns | 0.0509 ns | 0.0451 ns |  9.803 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 12.724 ns | 0.0118 ns | 0.0110 ns | 12.720 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 12.737 ns | 0.0393 ns | 0.0368 ns | 12.715 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.507 ns | 0.0108 ns | 0.0101 ns | 14.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.362 ns | 0.0114 ns | 0.0101 ns | 13.364 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.338 ns | 0.0217 ns | 0.0203 ns | 13.339 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 22.627 ns | 0.0598 ns | 0.0530 ns | 22.615 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 24.707 ns | 0.0406 ns | 0.0380 ns | 24.707 ns |  1.70 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 11.780 ns | 0.0141 ns | 0.0125 ns | 11.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.444 ns | 0.0193 ns | 0.0171 ns | 10.445 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  9.472 ns | 0.0228 ns | 0.0213 ns |  9.475 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 13.643 ns | 0.0230 ns | 0.0215 ns | 13.633 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 12.376 ns | 0.0535 ns | 0.0501 ns | 12.388 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 22.633 ns | 0.0481 ns | 0.0402 ns | 22.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 26.971 ns | 0.1027 ns | 0.0910 ns | 27.001 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 28.110 ns | 0.0328 ns | 0.0291 ns | 28.108 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 35.395 ns | 0.0412 ns | 0.0385 ns | 35.401 ns |  1.56 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 35.647 ns | 0.0367 ns | 0.0344 ns | 35.650 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.346 ns | 0.0197 ns | 0.0164 ns | 11.356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.284 ns | 0.0136 ns | 0.0121 ns | 10.282 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  6.869 ns | 0.0134 ns | 0.0126 ns |  6.871 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.028 ns | 0.1611 ns | 0.1507 ns | 12.073 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 11.771 ns | 0.0122 ns | 0.0102 ns | 11.772 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 22.590 ns | 0.0214 ns | 0.0200 ns | 22.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 26.003 ns | 0.0454 ns | 0.0402 ns | 25.999 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 27.064 ns | 0.0707 ns | 0.0591 ns | 27.050 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 37.319 ns | 0.0896 ns | 0.0838 ns | 37.298 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 35.411 ns | 0.1694 ns | 0.1585 ns | 35.449 ns |  1.57 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.390 ns | 0.0510 ns | 0.0477 ns | 11.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 11.758 ns | 0.0170 ns | 0.0150 ns | 11.758 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.964 ns | 0.0419 ns | 0.0350 ns |  6.972 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 12.678 ns | 0.0110 ns | 0.0092 ns | 12.677 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 11.754 ns | 0.0108 ns | 0.0090 ns | 11.755 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.504 ns | 0.0291 ns | 0.0243 ns | 14.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.353 ns | 0.0136 ns | 0.0120 ns | 13.351 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.069 ns | 0.3222 ns | 0.6360 ns | 15.303 ns |  0.99 |    0.07 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 22.985 ns | 0.0222 ns | 0.0208 ns | 22.988 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 25.196 ns | 0.0385 ns | 0.0360 ns | 25.188 ns |  1.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.726 ns | 0.0174 ns | 0.0154 ns | 12.726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 12.403 ns | 0.0253 ns | 0.0225 ns | 12.403 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  9.889 ns | 0.0177 ns | 0.0165 ns |  9.885 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 12.956 ns | 0.0139 ns | 0.0130 ns | 12.960 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 12.960 ns | 0.0223 ns | 0.0208 ns | 12.956 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.387 ns | 0.0367 ns | 0.0306 ns | 19.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 18.642 ns | 0.0166 ns | 0.0139 ns | 18.639 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 18.188 ns | 0.0637 ns | 0.0532 ns | 18.211 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 27.971 ns | 0.1531 ns | 0.1432 ns | 27.907 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 27.448 ns | 0.0595 ns | 0.0527 ns | 27.433 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.985 ns | 0.0207 ns | 0.0173 ns | 13.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 13.883 ns | 0.0253 ns | 0.0236 ns | 13.892 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 11.369 ns | 0.0136 ns | 0.0121 ns | 11.369 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 14.592 ns | 0.0213 ns | 0.0189 ns | 14.589 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 14.573 ns | 0.0257 ns | 0.0240 ns | 14.571 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.556 ns | 0.0258 ns | 0.0241 ns | 19.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.763 ns | 0.0701 ns | 0.0621 ns | 18.733 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 18.905 ns | 0.3141 ns | 0.2938 ns | 19.077 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 27.911 ns | 0.0241 ns | 0.0226 ns | 27.915 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 27.514 ns | 0.0485 ns | 0.0430 ns | 27.504 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.424 ns | 0.0471 ns | 0.0418 ns | 12.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.527 ns | 0.0336 ns | 0.0314 ns | 11.517 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  9.814 ns | 0.0095 ns | 0.0089 ns |  9.815 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 14.128 ns | 0.0869 ns | 0.0813 ns | 14.089 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.347 ns | 0.0195 ns | 0.0162 ns | 13.345 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.492 ns | 0.0235 ns | 0.0209 ns | 14.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.361 ns | 0.0162 ns | 0.0144 ns | 13.364 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.107 ns | 0.0190 ns | 0.0168 ns | 13.106 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 22.987 ns | 0.0344 ns | 0.0322 ns | 22.981 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 24.530 ns | 0.0432 ns | 0.0361 ns | 24.528 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.823 ns | 0.0112 ns | 0.0099 ns | 11.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.387 ns | 0.0091 ns | 0.0085 ns | 10.389 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  9.665 ns | 0.0136 ns | 0.0127 ns |  9.667 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 12.264 ns | 0.0128 ns | 0.0120 ns | 12.267 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 12.244 ns | 0.0088 ns | 0.0078 ns | 12.245 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 18.813 ns | 0.0526 ns | 0.0492 ns | 18.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 17.700 ns | 0.0765 ns | 0.0679 ns | 17.719 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 17.357 ns | 0.1723 ns | 0.1612 ns | 17.358 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 27.873 ns | 0.4180 ns | 0.3910 ns | 27.846 ns |  1.48 |    0.02 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 27.354 ns | 0.1381 ns | 0.1153 ns | 27.316 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.869 ns | 0.0122 ns | 0.0114 ns | 11.867 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.711 ns | 0.0219 ns | 0.0205 ns | 10.712 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 | 10.139 ns | 0.0213 ns | 0.0178 ns | 10.134 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 13.608 ns | 0.0313 ns | 0.0261 ns | 13.608 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.762 ns | 0.0213 ns | 0.0199 ns | 12.763 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.841 ns | 0.0951 ns | 0.0890 ns | 18.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.965 ns | 0.0245 ns | 0.0229 ns | 17.967 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.180 ns | 0.1031 ns | 0.0914 ns | 17.160 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 27.404 ns | 0.0329 ns | 0.0292 ns | 27.401 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 28.784 ns | 0.0456 ns | 0.0426 ns | 28.773 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.833 ns | 0.0077 ns | 0.0072 ns | 11.832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.456 ns | 0.0175 ns | 0.0164 ns | 10.450 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 | 10.494 ns | 0.2346 ns | 0.3050 ns | 10.641 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 13.379 ns | 0.0119 ns | 0.0100 ns | 13.377 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 12.759 ns | 0.0103 ns | 0.0097 ns | 12.758 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.528 ns | 0.0335 ns | 0.0313 ns | 14.526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.054 ns | 0.0139 ns | 0.0130 ns | 14.050 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.175 ns | 0.3296 ns | 0.6505 ns | 15.437 ns |  1.00 |    0.06 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 22.804 ns | 0.0384 ns | 0.0359 ns | 22.808 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 22.825 ns | 0.0264 ns | 0.0234 ns | 22.827 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 14.015 ns | 0.0135 ns | 0.0120 ns | 14.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.232 ns | 0.0107 ns | 0.0100 ns | 12.230 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 11.770 ns | 0.0834 ns | 0.0781 ns | 11.735 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.309 ns | 0.0176 ns | 0.0147 ns | 14.316 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.339 ns | 0.0169 ns | 0.0141 ns | 14.336 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 20.314 ns | 0.0561 ns | 0.0497 ns | 20.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 19.124 ns | 0.0306 ns | 0.0271 ns | 19.123 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 19.100 ns | 0.0267 ns | 0.0249 ns | 19.098 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 30.000 ns | 0.0211 ns | 0.0197 ns | 29.993 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 28.420 ns | 0.0314 ns | 0.0278 ns | 28.415 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 13.891 ns | 0.0290 ns | 0.0271 ns | 13.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 12.255 ns | 0.0170 ns | 0.0159 ns | 12.248 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 11.985 ns | 0.0155 ns | 0.0145 ns | 11.990 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 15.248 ns | 0.0235 ns | 0.0209 ns | 15.242 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 14.549 ns | 0.0321 ns | 0.0285 ns | 14.544 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.264 ns | 0.0257 ns | 0.0215 ns | 20.275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 19.123 ns | 0.0267 ns | 0.0249 ns | 19.121 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.711 ns | 0.1973 ns | 0.1845 ns | 20.764 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 30.240 ns | 0.0397 ns | 0.0352 ns | 30.248 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 30.445 ns | 0.0487 ns | 0.0456 ns | 30.444 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 12.144 ns | 0.0521 ns | 0.0487 ns | 12.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.588 ns | 0.0196 ns | 0.0174 ns | 10.587 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  9.945 ns | 0.0161 ns | 0.0126 ns |  9.947 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 12.910 ns | 0.0141 ns | 0.0132 ns | 12.904 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 12.982 ns | 0.0168 ns | 0.0157 ns | 12.982 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.529 ns | 0.0456 ns | 0.0427 ns | 14.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.182 ns | 0.0769 ns | 0.0720 ns | 14.215 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.571 ns | 0.0216 ns | 0.0169 ns | 13.568 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 22.784 ns | 0.0364 ns | 0.0341 ns | 22.784 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 25.174 ns | 0.0272 ns | 0.0254 ns | 25.169 ns |  1.73 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 57.189 ns | 0.0674 ns | 0.0597 ns | 57.186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 56.590 ns | 0.0537 ns | 0.0503 ns | 56.576 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.131 ns | 0.0460 ns | 0.0430 ns | 22.128 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 58.023 ns | 0.1617 ns | 0.1512 ns | 58.035 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 57.775 ns | 0.0731 ns | 0.0648 ns | 57.767 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 62.093 ns | 0.0979 ns | 0.0764 ns | 62.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 60.423 ns | 0.1226 ns | 0.1024 ns | 60.443 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 28.518 ns | 0.5926 ns | 1.0685 ns | 29.045 ns |  0.44 |    0.02 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 72.354 ns | 0.1029 ns | 0.0963 ns | 72.356 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 70.805 ns | 0.1901 ns | 0.1778 ns | 70.832 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 14.040 ns | 0.0123 ns | 0.0102 ns | 14.040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 18.960 ns | 0.0337 ns | 0.0315 ns | 18.965 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 13.604 ns | 0.0255 ns | 0.0213 ns | 13.596 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 14.882 ns | 0.0180 ns | 0.0160 ns | 14.881 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 15.482 ns | 0.0178 ns | 0.0158 ns | 15.487 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 14.519 ns | 0.0181 ns | 0.0169 ns | 14.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 15.298 ns | 0.0211 ns | 0.0187 ns | 15.300 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 14.827 ns | 0.1096 ns | 0.1025 ns | 14.848 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 22.835 ns | 0.0444 ns | 0.0415 ns | 22.824 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 22.904 ns | 0.0298 ns | 0.0264 ns | 22.909 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 14.120 ns | 0.0645 ns | 0.0604 ns | 14.100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 19.084 ns | 0.0534 ns | 0.0473 ns | 19.094 ns |  1.35 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 16.997 ns | 0.2019 ns | 0.1889 ns | 17.086 ns |  1.20 |    0.02 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 14.752 ns | 0.0166 ns | 0.0156 ns | 14.751 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 14.775 ns | 0.0075 ns | 0.0063 ns | 14.776 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.806 ns | 0.0070 ns | 0.0059 ns | 11.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.390 ns | 0.0150 ns | 0.0133 ns | 10.391 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  9.661 ns | 0.0192 ns | 0.0170 ns |  9.665 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 13.104 ns | 0.0160 ns | 0.0150 ns | 13.107 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 13.213 ns | 0.0131 ns | 0.0123 ns | 13.217 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.703 ns | 0.0275 ns | 0.0215 ns | 18.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 17.660 ns | 0.0339 ns | 0.0264 ns | 17.662 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 20.343 ns | 0.1263 ns | 0.1119 ns | 20.298 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 27.421 ns | 0.0533 ns | 0.0498 ns | 27.414 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 27.578 ns | 0.0265 ns | 0.0247 ns | 27.571 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.882 ns | 0.0267 ns | 0.0209 ns | 11.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.653 ns | 0.0200 ns | 0.0177 ns | 10.659 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 | 10.367 ns | 0.0204 ns | 0.0191 ns | 10.365 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 13.394 ns | 0.0104 ns | 0.0097 ns | 13.391 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 12.881 ns | 0.0230 ns | 0.0204 ns | 12.874 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.679 ns | 0.0581 ns | 0.0543 ns | 18.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.364 ns | 0.0236 ns | 0.0209 ns | 18.360 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.182 ns | 0.0540 ns | 0.0478 ns | 17.179 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 28.599 ns | 0.0618 ns | 0.0547 ns | 28.585 ns |  1.53 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 27.488 ns | 0.0480 ns | 0.0426 ns | 27.491 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.836 ns | 0.0152 ns | 0.0142 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.446 ns | 0.0157 ns | 0.0147 ns | 10.446 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 | 10.009 ns | 0.0292 ns | 0.0259 ns | 10.015 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 12.798 ns | 0.0219 ns | 0.0205 ns | 12.797 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 12.807 ns | 0.0499 ns | 0.0442 ns | 12.818 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 15.338 ns | 0.0126 ns | 0.0105 ns | 15.337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.382 ns | 0.0151 ns | 0.0134 ns | 13.382 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.125 ns | 0.0135 ns | 0.0112 ns | 13.128 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 23.289 ns | 0.1011 ns | 0.0946 ns | 23.318 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 22.809 ns | 0.0260 ns | 0.0243 ns | 22.811 ns |  1.49 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.831 ns | 0.0149 ns | 0.0140 ns | 11.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 11.006 ns | 0.0192 ns | 0.0180 ns | 11.006 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  9.415 ns | 0.0120 ns | 0.0106 ns |  9.414 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.928 ns | 0.0138 ns | 0.0129 ns | 12.930 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 12.921 ns | 0.0193 ns | 0.0171 ns | 12.917 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 19.601 ns | 0.0254 ns | 0.0238 ns | 19.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 17.930 ns | 0.0148 ns | 0.0138 ns | 17.932 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 17.809 ns | 0.3802 ns | 0.5805 ns | 17.409 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 29.090 ns | 0.0414 ns | 0.0388 ns | 29.086 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 27.804 ns | 0.1489 ns | 0.1392 ns | 27.728 ns |  1.42 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 13.067 ns | 0.0650 ns | 0.0608 ns | 13.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.727 ns | 0.0131 ns | 0.0123 ns | 10.731 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 | 10.137 ns | 0.0121 ns | 0.0107 ns | 10.137 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 13.162 ns | 0.0105 ns | 0.0093 ns | 13.163 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 14.131 ns | 0.0162 ns | 0.0143 ns | 14.133 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.120 ns | 0.0183 ns | 0.0163 ns | 19.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.797 ns | 0.1035 ns | 0.0969 ns | 17.760 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.462 ns | 0.0212 ns | 0.0188 ns | 17.462 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 27.196 ns | 0.0238 ns | 0.0211 ns | 27.198 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 27.625 ns | 0.0288 ns | 0.0269 ns | 27.627 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 12.810 ns | 0.0163 ns | 0.0152 ns | 12.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.414 ns | 0.0162 ns | 0.0152 ns | 10.419 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  9.905 ns | 0.0151 ns | 0.0134 ns |  9.909 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 14.991 ns | 0.0161 ns | 0.0150 ns | 14.992 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 12.829 ns | 0.0112 ns | 0.0099 ns | 12.829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.509 ns | 0.0186 ns | 0.0155 ns | 14.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.393 ns | 0.0219 ns | 0.0205 ns | 13.400 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.151 ns | 0.0265 ns | 0.0235 ns | 13.143 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 22.750 ns | 0.0387 ns | 0.0323 ns | 22.742 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 22.768 ns | 0.0315 ns | 0.0263 ns | 22.767 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 13.725 ns | 0.0470 ns | 0.0440 ns | 13.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 11.573 ns | 0.0410 ns | 0.0364 ns | 11.558 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  9.873 ns | 0.0126 ns | 0.0112 ns |  9.875 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 12.926 ns | 0.0188 ns | 0.0176 ns | 12.923 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 12.960 ns | 0.0118 ns | 0.0099 ns | 12.958 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 19.357 ns | 0.0308 ns | 0.0288 ns | 19.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 18.204 ns | 0.0345 ns | 0.0306 ns | 18.206 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 18.408 ns | 0.0229 ns | 0.0203 ns | 18.409 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 29.183 ns | 0.0245 ns | 0.0217 ns | 29.190 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 29.149 ns | 0.0307 ns | 0.0287 ns | 29.150 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.801 ns | 0.0170 ns | 0.0159 ns | 13.796 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.939 ns | 0.0187 ns | 0.0175 ns | 12.934 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.178 ns | 0.0485 ns | 0.0454 ns | 11.197 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.466 ns | 0.0167 ns | 0.0157 ns | 14.458 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 14.433 ns | 0.0165 ns | 0.0155 ns | 14.428 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.362 ns | 0.0345 ns | 0.0288 ns | 19.354 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.720 ns | 0.0197 ns | 0.0175 ns | 18.724 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.792 ns | 0.0276 ns | 0.0216 ns | 17.794 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 27.517 ns | 0.0286 ns | 0.0268 ns | 27.515 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 27.515 ns | 0.0261 ns | 0.0232 ns | 27.517 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.503 ns | 0.0182 ns | 0.0152 ns | 12.501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.875 ns | 0.1616 ns | 0.1511 ns | 12.857 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  9.914 ns | 0.0181 ns | 0.0161 ns |  9.908 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 14.097 ns | 0.0127 ns | 0.0112 ns | 14.098 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.249 ns | 0.0150 ns | 0.0140 ns | 13.246 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.516 ns | 0.0094 ns | 0.0088 ns | 14.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.129 ns | 0.0387 ns | 0.0362 ns | 14.121 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.133 ns | 0.0140 ns | 0.0131 ns | 13.128 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 24.515 ns | 0.0392 ns | 0.0328 ns | 24.517 ns |  1.69 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 23.039 ns | 0.0288 ns | 0.0269 ns | 23.029 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 14.541 ns | 0.0158 ns | 0.0140 ns | 14.543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 15.911 ns | 0.0146 ns | 0.0122 ns | 15.911 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.214 ns | 0.0591 ns | 0.0553 ns | 13.242 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 22.788 ns | 0.0285 ns | 0.0266 ns | 22.794 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 23.232 ns | 0.0605 ns | 0.0536 ns | 23.217 ns |  1.60 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 12.475 ns | 0.0153 ns | 0.0143 ns | 12.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 11.281 ns | 0.0121 ns | 0.0107 ns | 11.281 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.716 ns | 0.0137 ns | 0.0115 ns | 12.714 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 12.941 ns | 0.0235 ns | 0.0197 ns | 12.942 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 13.905 ns | 0.0797 ns | 0.0707 ns | 13.904 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 14.910 ns | 0.0151 ns | 0.0141 ns | 14.913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 13.881 ns | 0.0524 ns | 0.0490 ns | 13.856 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.687 ns | 0.0392 ns | 0.0367 ns | 13.696 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 24.668 ns | 0.0339 ns | 0.0300 ns | 24.665 ns |  1.65 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 22.626 ns | 0.0429 ns | 0.0401 ns | 22.617 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 17.682 ns | 0.0207 ns | 0.0194 ns | 17.685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 14.504 ns | 0.0210 ns | 0.0186 ns | 14.504 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 15.031 ns | 0.0618 ns | 0.0578 ns | 15.050 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 26.047 ns | 0.0709 ns | 0.0663 ns | 26.039 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 27.435 ns | 0.0335 ns | 0.0297 ns | 27.432 ns |  1.55 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 19.584 ns | 0.0194 ns | 0.0172 ns | 19.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 17.966 ns | 0.0254 ns | 0.0237 ns | 17.970 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 17.865 ns | 0.0763 ns | 0.0714 ns | 17.888 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 26.007 ns | 0.0221 ns | 0.0207 ns | 26.009 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 28.765 ns | 0.0391 ns | 0.0366 ns | 28.749 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 14.806 ns | 0.0135 ns | 0.0119 ns | 14.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 13.078 ns | 0.0501 ns | 0.0468 ns | 13.053 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 13.695 ns | 0.1693 ns | 0.1584 ns | 13.780 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 24.707 ns | 0.0523 ns | 0.0490 ns | 24.713 ns |  1.67 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 24.505 ns | 0.0322 ns | 0.0285 ns | 24.507 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 17.733 ns | 0.0409 ns | 0.0362 ns | 17.741 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.384 ns | 0.0196 ns | 0.0183 ns | 13.380 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.231 ns | 0.0490 ns | 0.0458 ns | 13.253 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 22.945 ns | 0.0368 ns | 0.0326 ns | 22.938 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 24.778 ns | 0.0790 ns | 0.0739 ns | 24.736 ns |  1.40 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 14.019 ns | 0.0159 ns | 0.0141 ns | 14.017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 12.340 ns | 0.0198 ns | 0.0185 ns | 12.345 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 12.704 ns | 0.1702 ns | 0.1592 ns | 12.602 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.280 ns | 0.0153 ns | 0.0143 ns | 14.279 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 14.973 ns | 0.0254 ns | 0.0238 ns | 14.976 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.377 ns | 0.0107 ns | 0.0084 ns | 16.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.951 ns | 0.0510 ns | 0.0477 ns | 15.939 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 15.015 ns | 0.0887 ns | 0.0830 ns | 15.067 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 24.597 ns | 0.0253 ns | 0.0237 ns | 24.592 ns |  1.50 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 24.292 ns | 0.0589 ns | 0.0491 ns | 24.304 ns |  1.48 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 14.171 ns | 0.0253 ns | 0.0224 ns | 14.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 12.216 ns | 0.0291 ns | 0.0272 ns | 12.209 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 12.902 ns | 0.0097 ns | 0.0086 ns | 12.901 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 14.968 ns | 0.0203 ns | 0.0190 ns | 14.968 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 14.321 ns | 0.0355 ns | 0.0332 ns | 14.324 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.692 ns | 0.0234 ns | 0.0207 ns | 14.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 14.122 ns | 0.0163 ns | 0.0152 ns | 14.119 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.413 ns | 0.1278 ns | 0.1196 ns | 13.455 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 22.907 ns | 0.0390 ns | 0.0365 ns | 22.902 ns |  1.56 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 23.116 ns | 0.0349 ns | 0.0291 ns | 23.123 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 20.067 ns | 0.1068 ns | 0.0999 ns | 20.028 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.124 ns | 0.0314 ns | 0.0294 ns | 16.121 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 13.461 ns | 0.0750 ns | 0.0701 ns | 13.473 ns |  0.67 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 19.023 ns | 0.0362 ns | 0.0339 ns | 19.002 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 18.860 ns | 0.0254 ns | 0.0212 ns | 18.854 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 18.635 ns | 0.0478 ns | 0.0424 ns | 18.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 17.677 ns | 0.1130 ns | 0.0882 ns | 17.711 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 17.194 ns | 0.0477 ns | 0.0446 ns | 17.181 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 26.417 ns | 0.0527 ns | 0.0467 ns | 26.423 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 28.304 ns | 0.0495 ns | 0.0439 ns | 28.299 ns |  1.52 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 20.007 ns | 0.0498 ns | 0.0442 ns | 20.010 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.263 ns | 0.0216 ns | 0.0181 ns | 16.258 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 14.299 ns | 0.0720 ns | 0.0673 ns | 14.285 ns |  0.71 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 24.154 ns | 0.0337 ns | 0.0281 ns | 24.167 ns |  1.21 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 24.900 ns | 0.1091 ns | 0.1021 ns | 24.856 ns |  1.24 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.676 ns | 0.0291 ns | 0.0243 ns | 18.676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.728 ns | 0.0347 ns | 0.0324 ns | 17.714 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.874 ns | 0.0761 ns | 0.0712 ns | 17.871 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.081 ns | 0.0190 ns | 0.0178 ns | 27.083 ns |  1.45 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 28.211 ns | 0.0462 ns | 0.0432 ns | 28.218 ns |  1.51 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.939 ns | 0.0333 ns | 0.0295 ns | 13.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.083 ns | 0.0142 ns | 0.0133 ns | 12.081 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 | 10.427 ns | 0.0601 ns | 0.0563 ns | 10.444 ns |  0.75 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 18.293 ns | 0.0265 ns | 0.0235 ns | 18.297 ns |  1.31 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 18.679 ns | 0.0292 ns | 0.0244 ns | 18.678 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.572 ns | 0.0180 ns | 0.0169 ns | 14.576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.371 ns | 0.0209 ns | 0.0195 ns | 13.371 ns |  0.92 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.132 ns | 0.0269 ns | 0.0238 ns | 13.142 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 24.598 ns | 0.0547 ns | 0.0512 ns | 24.592 ns |  1.69 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 23.026 ns | 0.0968 ns | 0.0858 ns | 23.047 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.117 ns | 0.0081 ns | 0.0071 ns | 13.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.361 ns | 0.0196 ns | 0.0183 ns | 10.366 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  9.446 ns | 0.0137 ns | 0.0121 ns |  9.446 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 13.028 ns | 0.0143 ns | 0.0127 ns | 13.027 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 12.879 ns | 0.0225 ns | 0.0200 ns | 12.875 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 16.507 ns | 0.0152 ns | 0.0127 ns | 16.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 15.438 ns | 0.0221 ns | 0.0184 ns | 15.435 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 16.444 ns | 0.1006 ns | 0.0941 ns | 16.435 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 25.928 ns | 0.0316 ns | 0.0296 ns | 25.929 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 24.302 ns | 0.0384 ns | 0.0359 ns | 24.305 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 13.141 ns | 0.0219 ns | 0.0194 ns | 13.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 11.331 ns | 0.1270 ns | 0.1188 ns | 11.315 ns |  0.86 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  9.228 ns | 0.0183 ns | 0.0163 ns |  9.230 ns |  0.70 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 14.340 ns | 0.0142 ns | 0.0126 ns | 14.340 ns |  1.09 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 13.005 ns | 0.0201 ns | 0.0179 ns | 13.004 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.699 ns | 0.0185 ns | 0.0173 ns | 16.696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.641 ns | 0.0225 ns | 0.0200 ns | 15.644 ns |  0.94 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.142 ns | 0.1562 ns | 0.1461 ns | 15.228 ns |  0.91 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 27.204 ns | 0.0925 ns | 0.0820 ns | 27.226 ns |  1.63 |    0.01 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 24.274 ns | 0.0429 ns | 0.0401 ns | 24.274 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.152 ns | 0.0165 ns | 0.0138 ns | 13.148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.449 ns | 0.0520 ns | 0.0487 ns | 10.427 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  9.283 ns | 0.0450 ns | 0.0420 ns |  9.264 ns |  0.71 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 12.225 ns | 0.0120 ns | 0.0101 ns | 12.225 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 12.907 ns | 0.0166 ns | 0.0148 ns | 12.909 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.616 ns | 0.1078 ns | 0.0955 ns | 14.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.093 ns | 0.0170 ns | 0.0159 ns | 14.094 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.279 ns | 0.1240 ns | 0.1159 ns | 13.350 ns |  0.91 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 23.226 ns | 0.0613 ns | 0.0512 ns | 23.223 ns |  1.59 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 24.678 ns | 0.0258 ns | 0.0216 ns | 24.679 ns |  1.69 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 13.299 ns | 0.1184 ns | 0.1050 ns | 13.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.353 ns | 0.0170 ns | 0.0159 ns | 11.353 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  9.650 ns | 0.0099 ns | 0.0083 ns |  9.650 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.207 ns | 0.0120 ns | 0.0112 ns | 12.206 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 12.423 ns | 0.0254 ns | 0.0225 ns | 12.420 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 49.606 ns | 0.8885 ns | 0.7876 ns | 49.416 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 45.024 ns | 0.3439 ns | 0.3217 ns | 44.998 ns |  0.91 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 40.786 ns | 0.2372 ns | 0.2219 ns | 40.758 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 50.951 ns | 0.0477 ns | 0.0446 ns | 50.959 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 50.264 ns | 0.1374 ns | 0.1286 ns | 50.237 ns |  1.01 |    0.02 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 13.353 ns | 0.0291 ns | 0.0243 ns | 13.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 11.739 ns | 0.0146 ns | 0.0136 ns | 11.740 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  9.950 ns | 0.0451 ns | 0.0422 ns |  9.931 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.872 ns | 0.0113 ns | 0.0100 ns | 12.874 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.811 ns | 0.0350 ns | 0.0292 ns | 12.817 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 45.238 ns | 0.2965 ns | 0.2773 ns | 45.317 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 42.187 ns | 0.0947 ns | 0.0886 ns | 42.185 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 40.645 ns | 0.3169 ns | 0.2809 ns | 40.736 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 49.546 ns | 0.1167 ns | 0.1034 ns | 49.553 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 49.780 ns | 0.0598 ns | 0.0530 ns | 49.787 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 14.213 ns | 0.0122 ns | 0.0114 ns | 14.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 11.552 ns | 0.0277 ns | 0.0260 ns | 11.550 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  9.714 ns | 0.0250 ns | 0.0221 ns |  9.712 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 13.444 ns | 0.0418 ns | 0.0349 ns | 13.452 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 12.782 ns | 0.0668 ns | 0.0625 ns | 12.744 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.509 ns | 0.0157 ns | 0.0139 ns | 14.506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.367 ns | 0.0121 ns | 0.0113 ns | 13.367 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.119 ns | 0.0176 ns | 0.0156 ns | 13.119 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 22.936 ns | 0.0390 ns | 0.0345 ns | 22.947 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 24.404 ns | 0.0306 ns | 0.0286 ns | 24.399 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 14.048 ns | 0.0150 ns | 0.0140 ns | 14.049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 12.201 ns | 0.0195 ns | 0.0173 ns | 12.206 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 12.522 ns | 0.0574 ns | 0.0479 ns | 12.498 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 14.982 ns | 0.0205 ns | 0.0182 ns | 14.985 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 14.968 ns | 0.0121 ns | 0.0113 ns | 14.962 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 16.942 ns | 0.0628 ns | 0.0556 ns | 16.957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.799 ns | 0.0298 ns | 0.0249 ns | 15.793 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 15.431 ns | 0.0306 ns | 0.0239 ns | 15.432 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 24.827 ns | 0.0347 ns | 0.0308 ns | 24.832 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 26.816 ns | 0.0553 ns | 0.0490 ns | 26.816 ns |  1.58 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 14.050 ns | 0.0155 ns | 0.0145 ns | 14.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 12.198 ns | 0.0171 ns | 0.0160 ns | 12.195 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.608 ns | 0.0435 ns | 0.0407 ns | 12.603 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.274 ns | 0.0124 ns | 0.0116 ns | 14.277 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 14.267 ns | 0.0188 ns | 0.0167 ns | 14.266 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 14.520 ns | 0.0144 ns | 0.0135 ns | 14.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.044 ns | 0.0170 ns | 0.0151 ns | 14.049 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.389 ns | 0.0250 ns | 0.0209 ns | 13.386 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 22.934 ns | 0.0430 ns | 0.0381 ns | 22.944 ns |  1.58 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 22.754 ns | 0.0316 ns | 0.0295 ns | 22.751 ns |  1.57 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 42.672 ns | 0.1799 ns | 0.1503 ns | 42.720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 39.167 ns | 0.2005 ns | 0.1876 ns | 39.077 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 38.710 ns | 0.0475 ns | 0.0421 ns | 38.708 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 40.900 ns | 0.0430 ns | 0.0381 ns | 40.912 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 46.139 ns | 0.1182 ns | 0.0987 ns | 46.148 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 16.815 ns | 0.0311 ns | 0.0275 ns | 16.819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.709 ns | 0.0203 ns | 0.0190 ns | 15.706 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 16.176 ns | 0.2778 ns | 0.2599 ns | 16.189 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 24.513 ns | 0.0449 ns | 0.0420 ns | 24.519 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 24.543 ns | 0.1334 ns | 0.1248 ns | 24.562 ns |  1.46 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 42.079 ns | 0.0329 ns | 0.0308 ns | 42.071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 38.650 ns | 0.0387 ns | 0.0362 ns | 38.646 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 37.111 ns | 0.1461 ns | 0.1367 ns | 37.042 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.619 ns | 0.1103 ns | 0.0977 ns | 40.635 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 43.392 ns | 0.0627 ns | 0.0587 ns | 43.394 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.934 ns | 0.0722 ns | 0.0675 ns | 16.961 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.945 ns | 0.0602 ns | 0.0564 ns | 15.956 ns |  0.94 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.184 ns | 0.0272 ns | 0.0241 ns | 15.190 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 26.136 ns | 0.0307 ns | 0.0272 ns | 26.129 ns |  1.54 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 24.597 ns | 0.0945 ns | 0.0884 ns | 24.624 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 42.354 ns | 0.0373 ns | 0.0331 ns | 42.361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 45.900 ns | 0.0659 ns | 0.0550 ns | 45.895 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 37.956 ns | 0.0668 ns | 0.0625 ns | 37.954 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 40.731 ns | 0.0483 ns | 0.0377 ns | 40.738 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 40.532 ns | 0.2703 ns | 0.2529 ns | 40.517 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.985 ns | 0.0141 ns | 0.0132 ns | 14.981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.373 ns | 0.0187 ns | 0.0175 ns | 13.370 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.225 ns | 0.0509 ns | 0.0476 ns | 13.247 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 23.136 ns | 0.0361 ns | 0.0338 ns | 23.129 ns |  1.54 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 22.814 ns | 0.0338 ns | 0.0283 ns | 22.814 ns |  1.52 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_IntNullable.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_IntNullable.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
