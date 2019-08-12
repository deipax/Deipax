
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
                                             From_Bool | .NET Core 2.0 | 13.076 ns | 0.0212 ns | 0.0198 ns | 13.079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.402 ns | 0.0535 ns | 0.0500 ns | 10.369 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.065 ns | 0.0107 ns | 0.0100 ns |  7.065 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.522 ns | 0.0901 ns | 0.0799 ns | 10.526 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.552 ns | 0.0150 ns | 0.0133 ns | 10.550 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 17.331 ns | 0.0230 ns | 0.0215 ns | 17.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 16.738 ns | 0.0418 ns | 0.0391 ns | 16.751 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.258 ns | 0.0605 ns | 0.0566 ns | 17.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 19.780 ns | 0.3949 ns | 0.3500 ns | 19.610 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.195 ns | 0.0540 ns | 0.0451 ns | 18.182 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 12.013 ns | 0.0067 ns | 0.0052 ns | 12.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.616 ns | 0.0184 ns | 0.0172 ns | 10.613 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.446 ns | 0.0122 ns | 0.0114 ns |  7.448 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.696 ns | 0.0289 ns | 0.0270 ns | 10.694 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 10.568 ns | 0.0117 ns | 0.0109 ns | 10.571 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.776 ns | 0.0346 ns | 0.0323 ns | 16.792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.853 ns | 0.0512 ns | 0.0479 ns | 15.858 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.156 ns | 0.0201 ns | 0.0178 ns | 17.152 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 18.387 ns | 0.0939 ns | 0.0784 ns | 18.401 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.332 ns | 0.0451 ns | 0.0422 ns | 18.331 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.659 ns | 0.0081 ns | 0.0068 ns | 11.661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.341 ns | 0.0089 ns | 0.0074 ns | 10.340 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  6.845 ns | 0.0389 ns | 0.0364 ns |  6.827 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 10.382 ns | 0.0442 ns | 0.0413 ns | 10.394 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.377 ns | 0.0152 ns | 0.0135 ns | 10.380 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.172 ns | 0.0171 ns | 0.0152 ns | 13.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.509 ns | 0.0094 ns | 0.0074 ns | 13.510 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.786 ns | 0.2469 ns | 0.2425 ns | 11.893 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 14.501 ns | 0.0216 ns | 0.0180 ns | 14.497 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.739 ns | 0.0334 ns | 0.0296 ns | 13.737 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.674 ns | 0.0120 ns | 0.0101 ns | 11.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.309 ns | 0.0635 ns | 0.0594 ns | 10.342 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  6.822 ns | 0.0093 ns | 0.0087 ns |  6.823 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.361 ns | 0.0576 ns | 0.0510 ns | 10.353 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 11.609 ns | 0.0104 ns | 0.0092 ns | 11.608 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 16.572 ns | 0.0238 ns | 0.0211 ns | 16.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 15.709 ns | 0.0226 ns | 0.0212 ns | 15.706 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.930 ns | 0.0612 ns | 0.0572 ns | 16.945 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.924 ns | 0.1220 ns | 0.0953 ns | 19.924 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 18.458 ns | 0.0485 ns | 0.0430 ns | 18.464 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.862 ns | 0.0166 ns | 0.0147 ns | 11.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.478 ns | 0.0089 ns | 0.0074 ns | 10.480 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.501 ns | 0.7029 ns | 0.8367 ns |  7.044 ns |  0.65 |    0.08 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.249 ns | 0.1037 ns | 0.0970 ns | 12.235 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 10.619 ns | 0.0152 ns | 0.0143 ns | 10.617 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.437 ns | 0.0328 ns | 0.0306 ns | 18.442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.322 ns | 0.0586 ns | 0.0548 ns | 16.331 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.215 ns | 0.0836 ns | 0.0782 ns | 16.179 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 18.346 ns | 0.0867 ns | 0.0811 ns | 18.326 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.174 ns | 0.0218 ns | 0.0204 ns | 18.177 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 11.656 ns | 0.0112 ns | 0.0105 ns | 11.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.344 ns | 0.0103 ns | 0.0091 ns | 10.342 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  7.028 ns | 0.0493 ns | 0.0462 ns |  7.036 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.582 ns | 0.2362 ns | 0.2210 ns | 10.544 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.376 ns | 0.0131 ns | 0.0102 ns | 10.376 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.047 ns | 0.0086 ns | 0.0076 ns | 13.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.538 ns | 0.0109 ns | 0.0097 ns | 13.538 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.662 ns | 0.2466 ns | 0.2306 ns | 11.800 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.290 ns | 0.0818 ns | 0.0725 ns | 13.274 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.167 ns | 0.0131 ns | 0.0116 ns | 13.166 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.677 ns | 0.0161 ns | 0.0143 ns | 11.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.346 ns | 0.0536 ns | 0.0501 ns | 10.358 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.846 ns | 0.0373 ns | 0.0349 ns |  6.829 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.559 ns | 0.0955 ns | 0.0797 ns | 10.552 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.313 ns | 0.0111 ns | 0.0103 ns | 10.314 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 17.508 ns | 0.0203 ns | 0.0190 ns | 17.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.074 ns | 0.0740 ns | 0.0656 ns | 17.060 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 15.503 ns | 0.0551 ns | 0.0488 ns | 15.494 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.491 ns | 0.3232 ns | 0.3023 ns | 18.412 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 17.959 ns | 0.0299 ns | 0.0249 ns | 17.959 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 14.854 ns | 0.0224 ns | 0.0199 ns | 14.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.486 ns | 0.0093 ns | 0.0077 ns | 10.487 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  6.901 ns | 0.0255 ns | 0.0238 ns |  6.905 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 11.423 ns | 0.1219 ns | 0.1141 ns | 11.400 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 10.604 ns | 0.0112 ns | 0.0099 ns | 10.604 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.325 ns | 0.0218 ns | 0.0204 ns | 17.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.019 ns | 0.0556 ns | 0.0520 ns | 18.036 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.120 ns | 0.0259 ns | 0.0243 ns | 16.121 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 19.755 ns | 0.2553 ns | 0.2264 ns | 19.718 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 17.985 ns | 0.0150 ns | 0.0140 ns | 17.984 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.443 ns | 0.1184 ns | 0.1108 ns | 12.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.338 ns | 0.0147 ns | 0.0137 ns | 10.335 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.629 ns | 0.0821 ns | 0.0768 ns |  7.648 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.538 ns | 0.1281 ns | 0.1070 ns | 10.500 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.359 ns | 0.0131 ns | 0.0109 ns | 10.362 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.161 ns | 0.0092 ns | 0.0077 ns | 13.159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.505 ns | 0.0201 ns | 0.0178 ns | 13.506 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.467 ns | 0.1929 ns | 0.1804 ns | 11.337 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.585 ns | 0.1847 ns | 0.1442 ns | 13.603 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 16.224 ns | 0.0103 ns | 0.0086 ns | 16.225 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.757 ns | 0.0289 ns | 0.0256 ns | 12.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.111 ns | 0.0343 ns | 0.0304 ns | 11.114 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  7.932 ns | 0.0271 ns | 0.0240 ns |  7.923 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 13.258 ns | 0.0857 ns | 0.0669 ns | 13.260 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.836 ns | 0.0160 ns | 0.0142 ns | 12.835 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.566 ns | 0.0167 ns | 0.0148 ns | 12.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.217 ns | 0.0101 ns | 0.0078 ns | 11.217 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.134 ns | 0.0145 ns | 0.0136 ns |  8.137 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.369 ns | 0.1329 ns | 0.1178 ns | 13.322 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.145 ns | 0.0165 ns | 0.0154 ns | 13.146 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 12.867 ns | 0.0507 ns | 0.0475 ns | 12.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 12.296 ns | 0.0082 ns | 0.0068 ns | 12.296 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  8.204 ns | 0.3525 ns | 0.4197 ns |  8.024 ns |  0.64 |    0.04 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 15.223 ns | 0.1384 ns | 0.1227 ns | 15.201 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.158 ns | 0.0136 ns | 0.0107 ns | 13.154 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.152 ns | 0.0138 ns | 0.0122 ns | 14.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.515 ns | 0.0123 ns | 0.0109 ns | 13.513 ns |  0.95 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.843 ns | 0.1381 ns | 0.1292 ns | 11.936 ns |  0.84 |    0.01 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 15.161 ns | 0.0650 ns | 0.0576 ns | 15.175 ns |  1.07 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 13.180 ns | 0.0201 ns | 0.0188 ns | 13.180 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 21.222 ns | 0.0213 ns | 0.0200 ns | 21.220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 19.502 ns | 0.0140 ns | 0.0117 ns | 19.500 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 12.848 ns | 0.0187 ns | 0.0175 ns | 12.848 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 18.748 ns | 0.0331 ns | 0.0294 ns | 18.753 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 19.071 ns | 0.0372 ns | 0.0311 ns | 19.069 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.925 ns | 0.0323 ns | 0.0252 ns | 26.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 27.094 ns | 0.0346 ns | 0.0307 ns | 27.094 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 23.947 ns | 0.5039 ns | 1.3795 ns | 24.454 ns |  0.77 |    0.06 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 23.838 ns | 0.1585 ns | 0.1483 ns | 23.808 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 23.880 ns | 0.0269 ns | 0.0238 ns | 23.884 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 22.504 ns | 0.0252 ns | 0.0236 ns | 22.505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 20.784 ns | 0.0242 ns | 0.0214 ns | 20.782 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.007 ns | 0.2683 ns | 0.2510 ns | 16.183 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 20.053 ns | 0.4705 ns | 0.5229 ns | 19.798 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 23.249 ns | 0.0256 ns | 0.0240 ns | 23.257 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.217 ns | 0.0361 ns | 0.0320 ns | 26.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.501 ns | 0.0385 ns | 0.0321 ns | 25.495 ns |  0.97 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.902 ns | 0.2623 ns | 0.2453 ns | 20.879 ns |  0.80 |    0.01 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 24.263 ns | 0.0870 ns | 0.0679 ns | 24.255 ns |  0.93 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 25.207 ns | 0.0471 ns | 0.0417 ns | 25.204 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 12.600 ns | 0.0150 ns | 0.0133 ns | 12.604 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.375 ns | 0.0192 ns | 0.0170 ns | 11.382 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.206 ns | 0.0137 ns | 0.0121 ns |  8.203 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.618 ns | 0.0681 ns | 0.0604 ns | 13.615 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.429 ns | 0.0219 ns | 0.0194 ns | 13.428 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.006 ns | 0.0133 ns | 0.0118 ns | 14.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.667 ns | 0.0216 ns | 0.0202 ns | 12.665 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.333 ns | 0.0614 ns | 0.0544 ns | 11.351 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 15.096 ns | 0.0680 ns | 0.0603 ns | 15.075 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.187 ns | 0.0180 ns | 0.0169 ns | 13.189 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 12.462 ns | 0.0138 ns | 0.0122 ns | 12.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 10.989 ns | 0.0229 ns | 0.0191 ns | 10.987 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.366 ns | 0.2233 ns | 0.2824 ns | 10.426 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                                           From_Double |        net461 | 11.795 ns | 0.1117 ns | 0.0990 ns | 11.799 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_Double |        net472 | 11.336 ns | 0.0167 ns | 0.0156 ns | 11.332 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 17.838 ns | 0.0256 ns | 0.0239 ns | 17.842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 17.579 ns | 0.0439 ns | 0.0389 ns | 17.577 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 17.145 ns | 0.0495 ns | 0.0439 ns | 17.139 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 19.210 ns | 0.0593 ns | 0.0526 ns | 19.207 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 19.106 ns | 0.0314 ns | 0.0262 ns | 19.112 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 13.910 ns | 0.0318 ns | 0.0298 ns | 13.907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 12.798 ns | 0.0157 ns | 0.0131 ns | 12.799 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 10.509 ns | 0.0169 ns | 0.0150 ns | 10.507 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 14.596 ns | 0.0946 ns | 0.0838 ns | 14.633 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.711 ns | 0.0233 ns | 0.0218 ns | 15.708 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.539 ns | 0.0257 ns | 0.0215 ns | 19.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.494 ns | 0.0257 ns | 0.0240 ns | 16.492 ns |  0.84 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.747 ns | 0.0568 ns | 0.0531 ns | 17.756 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 18.947 ns | 0.0549 ns | 0.0487 ns | 18.946 ns |  0.97 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 19.028 ns | 0.0357 ns | 0.0298 ns | 19.029 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 12.532 ns | 0.0144 ns | 0.0127 ns | 12.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.326 ns | 0.0228 ns | 0.0190 ns | 11.329 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  7.933 ns | 0.0176 ns | 0.0156 ns |  7.929 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.714 ns | 0.0429 ns | 0.0358 ns | 12.720 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.608 ns | 0.0122 ns | 0.0108 ns | 12.608 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.126 ns | 0.0091 ns | 0.0085 ns | 13.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.637 ns | 0.0119 ns | 0.0105 ns | 12.640 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.081 ns | 0.3147 ns | 0.3231 ns | 12.907 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.164 ns | 0.0432 ns | 0.0404 ns | 13.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.210 ns | 0.0182 ns | 0.0170 ns | 13.213 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.657 ns | 0.0105 ns | 0.0093 ns | 11.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.877 ns | 0.1407 ns | 0.1316 ns | 10.884 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  6.634 ns | 0.0345 ns | 0.0323 ns |  6.650 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.668 ns | 0.0596 ns | 0.0529 ns | 10.665 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 10.918 ns | 0.0125 ns | 0.0117 ns | 10.921 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 18.531 ns | 0.0217 ns | 0.0192 ns | 18.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 15.703 ns | 0.0340 ns | 0.0284 ns | 15.710 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 16.171 ns | 0.0683 ns | 0.0639 ns | 16.192 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.993 ns | 0.0932 ns | 0.0872 ns | 19.999 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 18.553 ns | 0.0391 ns | 0.0347 ns | 18.545 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 11.855 ns | 0.0199 ns | 0.0176 ns | 11.858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 10.450 ns | 0.0133 ns | 0.0118 ns | 10.449 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  6.881 ns | 0.0154 ns | 0.0137 ns |  6.885 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 10.766 ns | 0.1010 ns | 0.0945 ns | 10.750 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 10.723 ns | 0.0538 ns | 0.0477 ns | 10.742 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.567 ns | 0.0215 ns | 0.0201 ns | 16.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.670 ns | 0.0255 ns | 0.0239 ns | 15.673 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.954 ns | 0.0753 ns | 0.0705 ns | 14.982 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 18.556 ns | 0.0893 ns | 0.0792 ns | 18.596 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 18.574 ns | 0.0458 ns | 0.0428 ns | 18.577 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 11.623 ns | 0.0220 ns | 0.0205 ns | 11.622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.313 ns | 0.0218 ns | 0.0204 ns | 10.306 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  6.844 ns | 0.1500 ns | 0.1403 ns |  6.778 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 10.962 ns | 0.0450 ns | 0.0399 ns | 10.959 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.471 ns | 0.0163 ns | 0.0136 ns | 10.472 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.413 ns | 0.0155 ns | 0.0121 ns | 13.414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.664 ns | 0.0557 ns | 0.0521 ns | 12.638 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.840 ns | 0.2597 ns | 0.2667 ns | 11.701 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 13.235 ns | 0.1127 ns | 0.1054 ns | 13.249 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.275 ns | 0.0430 ns | 0.0359 ns | 13.290 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.244 ns | 0.0443 ns | 0.0415 ns | 12.252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.768 ns | 0.0125 ns | 0.0110 ns | 10.767 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  6.714 ns | 0.0305 ns | 0.0270 ns |  6.722 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 10.780 ns | 0.0280 ns | 0.0248 ns | 10.785 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.519 ns | 0.0155 ns | 0.0145 ns | 11.521 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 13.771 ns | 0.0110 ns | 0.0097 ns | 13.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 13.122 ns | 0.0194 ns | 0.0181 ns | 13.125 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 12.666 ns | 0.2760 ns | 0.4215 ns | 12.844 ns |  0.90 |    0.04 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 14.253 ns | 0.1326 ns | 0.1107 ns | 14.240 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 13.952 ns | 0.0219 ns | 0.0194 ns | 13.952 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 11.834 ns | 0.0113 ns | 0.0100 ns | 11.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 10.439 ns | 0.0142 ns | 0.0118 ns | 10.440 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  7.089 ns | 0.0220 ns | 0.0206 ns |  7.084 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.059 ns | 0.0949 ns | 0.0888 ns | 12.042 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 10.625 ns | 0.0122 ns | 0.0114 ns | 10.626 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.820 ns | 0.0497 ns | 0.0440 ns | 13.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 13.184 ns | 0.0206 ns | 0.0193 ns | 13.179 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.330 ns | 0.1095 ns | 0.1024 ns | 14.343 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 14.178 ns | 0.0969 ns | 0.0859 ns | 14.157 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 14.153 ns | 0.0275 ns | 0.0257 ns | 14.149 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.711 ns | 0.0098 ns | 0.0082 ns | 11.712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.396 ns | 0.0335 ns | 0.0314 ns | 10.408 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  6.795 ns | 0.0085 ns | 0.0071 ns |  6.795 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.613 ns | 0.0504 ns | 0.0446 ns | 11.613 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.442 ns | 0.0159 ns | 0.0149 ns | 10.433 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.336 ns | 0.0749 ns | 0.0701 ns | 13.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.670 ns | 0.0193 ns | 0.0171 ns | 13.668 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.938 ns | 0.0530 ns | 0.0496 ns | 11.920 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.141 ns | 0.0438 ns | 0.0366 ns | 13.140 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.318 ns | 0.0271 ns | 0.0254 ns | 13.326 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.030 ns | 0.0783 ns | 0.0733 ns | 11.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.678 ns | 0.0251 ns | 0.0209 ns | 10.671 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  8.084 ns | 0.0462 ns | 0.0432 ns |  8.096 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                                             From_Long |        net461 | 11.621 ns | 0.0533 ns | 0.0445 ns | 11.607 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.050 ns | 0.0112 ns | 0.0100 ns | 11.053 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 19.019 ns | 0.0349 ns | 0.0309 ns | 19.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.628 ns | 0.0132 ns | 0.0110 ns | 16.627 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 16.119 ns | 0.0532 ns | 0.0472 ns | 16.116 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.551 ns | 0.0426 ns | 0.0378 ns | 18.546 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.749 ns | 0.0682 ns | 0.0604 ns | 18.769 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.609 ns | 0.0255 ns | 0.0239 ns | 13.618 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.665 ns | 0.0646 ns | 0.0604 ns | 12.695 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 10.198 ns | 0.0164 ns | 0.0137 ns | 10.198 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.745 ns | 0.0156 ns | 0.0146 ns | 13.745 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.755 ns | 0.0180 ns | 0.0169 ns | 13.757 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.716 ns | 0.0295 ns | 0.0276 ns | 17.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.630 ns | 0.0194 ns | 0.0172 ns | 16.628 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.737 ns | 0.0513 ns | 0.0480 ns | 15.735 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 20.226 ns | 0.0529 ns | 0.0469 ns | 20.223 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.930 ns | 0.0721 ns | 0.0674 ns | 18.943 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.512 ns | 0.0198 ns | 0.0165 ns | 12.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.242 ns | 0.0115 ns | 0.0108 ns | 11.244 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  8.103 ns | 0.0107 ns | 0.0100 ns |  8.103 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 12.784 ns | 0.0573 ns | 0.0508 ns | 12.758 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 12.658 ns | 0.0163 ns | 0.0144 ns | 12.658 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.036 ns | 0.0117 ns | 0.0104 ns | 14.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.651 ns | 0.0213 ns | 0.0188 ns | 12.653 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.400 ns | 0.2307 ns | 0.2158 ns | 13.498 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 14.978 ns | 0.0457 ns | 0.0427 ns | 14.970 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.335 ns | 0.0260 ns | 0.0243 ns | 13.332 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.776 ns | 0.0701 ns | 0.0656 ns | 11.805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.206 ns | 0.0140 ns | 0.0131 ns | 10.204 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  7.226 ns | 0.1695 ns | 0.2589 ns |  7.374 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 11.964 ns | 0.2606 ns | 0.2310 ns | 11.857 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.643 ns | 0.0426 ns | 0.0378 ns | 10.628 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 16.526 ns | 0.0198 ns | 0.0165 ns | 16.529 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 15.951 ns | 0.0199 ns | 0.0187 ns | 15.951 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 14.664 ns | 0.0351 ns | 0.0328 ns | 14.667 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 18.384 ns | 0.1035 ns | 0.0918 ns | 18.384 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 18.433 ns | 0.0213 ns | 0.0189 ns | 18.435 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 14.297 ns | 0.0092 ns | 0.0082 ns | 14.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.511 ns | 0.0429 ns | 0.0402 ns | 10.492 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  6.881 ns | 0.0134 ns | 0.0112 ns |  6.882 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 11.565 ns | 0.0092 ns | 0.0077 ns | 11.561 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 10.614 ns | 0.0113 ns | 0.0105 ns | 10.612 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 18.560 ns | 0.0640 ns | 0.0598 ns | 18.572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.174 ns | 0.0304 ns | 0.0269 ns | 16.179 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.806 ns | 0.0392 ns | 0.0347 ns | 14.801 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 18.108 ns | 0.0719 ns | 0.0673 ns | 18.117 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 18.274 ns | 0.0689 ns | 0.0644 ns | 18.258 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.663 ns | 0.0126 ns | 0.0112 ns | 11.662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.304 ns | 0.0166 ns | 0.0155 ns | 10.307 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  7.037 ns | 0.1670 ns | 0.2836 ns |  6.872 ns |  0.63 |    0.03 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 12.259 ns | 0.0252 ns | 0.0236 ns | 12.264 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 11.485 ns | 0.0168 ns | 0.0149 ns | 11.485 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.168 ns | 0.0105 ns | 0.0099 ns | 13.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.350 ns | 0.0243 ns | 0.0227 ns | 14.345 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.893 ns | 0.2779 ns | 0.3515 ns | 12.928 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.013 ns | 0.0157 ns | 0.0131 ns | 13.011 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 13.191 ns | 0.0164 ns | 0.0154 ns | 13.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 12.520 ns | 0.0547 ns | 0.0512 ns | 12.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 10.962 ns | 0.0144 ns | 0.0121 ns | 10.958 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 |  9.113 ns | 0.0132 ns | 0.0117 ns |  9.110 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net461 | 13.730 ns | 0.0586 ns | 0.0520 ns | 13.738 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                            From_Float |        net472 | 11.967 ns | 0.0571 ns | 0.0535 ns | 11.955 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.961 ns | 0.0385 ns | 0.0341 ns | 19.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 18.090 ns | 0.0276 ns | 0.0258 ns | 18.098 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 17.372 ns | 0.0409 ns | 0.0383 ns | 17.382 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.832 ns | 0.0240 ns | 0.0225 ns | 20.829 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 19.687 ns | 0.0379 ns | 0.0355 ns | 19.690 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 12.888 ns | 0.0251 ns | 0.0235 ns | 12.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 11.822 ns | 0.0188 ns | 0.0157 ns | 11.825 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.652 ns | 0.2284 ns | 0.2806 ns | 10.598 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 14.928 ns | 0.0159 ns | 0.0141 ns | 14.926 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 12.537 ns | 0.0125 ns | 0.0117 ns | 12.535 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.006 ns | 0.0805 ns | 0.0753 ns | 20.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.415 ns | 0.0282 ns | 0.0235 ns | 17.411 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.255 ns | 0.0205 ns | 0.0192 ns | 17.256 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 19.513 ns | 0.0461 ns | 0.0431 ns | 19.504 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 19.710 ns | 0.0481 ns | 0.0450 ns | 19.704 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.673 ns | 0.0106 ns | 0.0094 ns | 11.672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.343 ns | 0.0115 ns | 0.0102 ns | 10.344 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  6.584 ns | 0.0116 ns | 0.0109 ns |  6.588 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 11.752 ns | 0.0141 ns | 0.0117 ns | 11.754 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.404 ns | 0.0281 ns | 0.0263 ns | 10.396 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.247 ns | 0.0151 ns | 0.0134 ns | 13.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.662 ns | 0.0207 ns | 0.0162 ns | 12.668 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.573 ns | 0.1762 ns | 0.1648 ns | 11.633 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 13.018 ns | 0.0166 ns | 0.0138 ns | 13.020 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 14.702 ns | 0.0106 ns | 0.0100 ns | 14.700 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 58.553 ns | 0.1946 ns | 0.1820 ns | 58.525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 51.683 ns | 0.1455 ns | 0.1361 ns | 51.634 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 22.162 ns | 0.2449 ns | 0.2290 ns | 22.245 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 55.702 ns | 0.1569 ns | 0.1391 ns | 55.735 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 56.943 ns | 0.1415 ns | 0.1105 ns | 56.948 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 60.785 ns | 0.1028 ns | 0.0911 ns | 60.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 59.068 ns | 0.0631 ns | 0.0560 ns | 59.062 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 24.233 ns | 0.0645 ns | 0.0603 ns | 24.214 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 62.010 ns | 0.1986 ns | 0.1858 ns | 61.997 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 61.852 ns | 0.2146 ns | 0.2007 ns | 61.868 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 12.347 ns | 0.0070 ns | 0.0062 ns | 12.347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.158 ns | 0.0478 ns | 0.0447 ns | 12.144 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.547 ns | 0.0192 ns | 0.0170 ns | 11.547 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 11.070 ns | 0.0346 ns | 0.0289 ns | 11.078 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 12.775 ns | 0.0207 ns | 0.0193 ns | 12.777 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.430 ns | 0.0196 ns | 0.0164 ns | 13.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 13.471 ns | 0.0209 ns | 0.0195 ns | 13.473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 15.159 ns | 0.0973 ns | 0.0910 ns | 15.098 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 15.521 ns | 0.0163 ns | 0.0145 ns | 15.523 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.597 ns | 0.0481 ns | 0.0450 ns | 13.607 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 12.552 ns | 0.0131 ns | 0.0123 ns | 12.553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.680 ns | 0.0125 ns | 0.0116 ns | 12.678 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 13.191 ns | 0.0141 ns | 0.0118 ns | 13.190 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 12.953 ns | 0.0138 ns | 0.0129 ns | 12.955 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 12.884 ns | 0.0299 ns | 0.0280 ns | 12.882 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.672 ns | 0.0113 ns | 0.0100 ns | 11.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.231 ns | 0.0500 ns | 0.0443 ns | 10.215 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.822 ns | 0.0093 ns | 0.0083 ns |  6.820 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.309 ns | 0.0152 ns | 0.0135 ns | 10.305 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.285 ns | 0.0107 ns | 0.0101 ns | 10.286 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 18.522 ns | 0.0268 ns | 0.0237 ns | 18.521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 16.224 ns | 0.0469 ns | 0.0416 ns | 16.233 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 14.784 ns | 0.0174 ns | 0.0154 ns | 14.788 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 19.635 ns | 0.0569 ns | 0.0532 ns | 19.643 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.215 ns | 0.0232 ns | 0.0217 ns | 18.211 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 11.881 ns | 0.0757 ns | 0.0708 ns | 11.841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 10.447 ns | 0.0129 ns | 0.0121 ns | 10.446 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  7.106 ns | 0.2513 ns | 0.3684 ns |  6.915 ns |  0.61 |    0.03 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 11.560 ns | 0.0162 ns | 0.0144 ns | 11.559 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 11.485 ns | 0.0123 ns | 0.0115 ns | 11.481 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.766 ns | 0.0272 ns | 0.0254 ns | 16.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.608 ns | 0.0471 ns | 0.0417 ns | 15.617 ns |  0.93 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.869 ns | 0.1676 ns | 0.1486 ns | 15.907 ns |  0.95 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 18.364 ns | 0.0524 ns | 0.0490 ns | 18.381 ns |  1.10 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 18.421 ns | 0.0204 ns | 0.0191 ns | 18.417 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.629 ns | 0.0221 ns | 0.0184 ns | 11.635 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.309 ns | 0.0094 ns | 0.0088 ns | 10.309 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  6.928 ns | 0.0976 ns | 0.0913 ns |  6.976 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.241 ns | 0.0163 ns | 0.0145 ns | 10.241 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.403 ns | 0.0121 ns | 0.0107 ns | 10.399 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.303 ns | 0.0190 ns | 0.0169 ns | 13.304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.639 ns | 0.0100 ns | 0.0089 ns | 12.635 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.594 ns | 0.2019 ns | 0.1686 ns | 11.678 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.140 ns | 0.0312 ns | 0.0292 ns | 13.143 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.297 ns | 0.0206 ns | 0.0193 ns | 13.294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.793 ns | 0.0445 ns | 0.0416 ns | 11.778 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.441 ns | 0.0702 ns | 0.0656 ns | 10.462 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  7.042 ns | 0.0114 ns | 0.0101 ns |  7.040 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.608 ns | 0.0129 ns | 0.0121 ns | 12.610 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.822 ns | 0.0179 ns | 0.0158 ns | 10.820 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 17.926 ns | 0.0271 ns | 0.0241 ns | 17.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 15.894 ns | 0.0202 ns | 0.0179 ns | 15.888 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.877 ns | 0.0850 ns | 0.0795 ns | 15.863 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 18.815 ns | 0.0326 ns | 0.0305 ns | 18.808 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 18.878 ns | 0.0254 ns | 0.0212 ns | 18.875 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.986 ns | 0.0789 ns | 0.0738 ns | 12.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 10.567 ns | 0.0158 ns | 0.0148 ns | 10.569 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  7.037 ns | 0.0105 ns | 0.0093 ns |  7.037 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.951 ns | 0.0442 ns | 0.0413 ns | 11.955 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.966 ns | 0.0133 ns | 0.0118 ns | 11.966 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.753 ns | 0.0320 ns | 0.0284 ns | 16.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.621 ns | 0.0287 ns | 0.0269 ns | 16.613 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.002 ns | 0.0510 ns | 0.0477 ns | 15.012 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 18.492 ns | 0.0167 ns | 0.0130 ns | 18.494 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 18.655 ns | 0.0299 ns | 0.0265 ns | 18.661 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.737 ns | 0.0086 ns | 0.0076 ns | 11.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.359 ns | 0.0102 ns | 0.0096 ns | 10.359 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.725 ns | 0.1551 ns | 0.1724 ns |  6.586 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 11.568 ns | 0.0094 ns | 0.0088 ns | 11.567 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.846 ns | 0.0128 ns | 0.0120 ns | 10.845 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.154 ns | 0.0639 ns | 0.0597 ns | 14.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.621 ns | 0.0116 ns | 0.0103 ns | 13.622 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 15.233 ns | 0.3291 ns | 0.7224 ns | 15.577 ns |  1.01 |    0.06 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.072 ns | 0.0339 ns | 0.0301 ns | 13.072 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.166 ns | 0.0303 ns | 0.0283 ns | 13.166 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 12.060 ns | 0.0138 ns | 0.0122 ns | 12.058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.601 ns | 0.0124 ns | 0.0116 ns | 10.605 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  7.767 ns | 0.0372 ns | 0.0311 ns |  7.761 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.786 ns | 0.0162 ns | 0.0144 ns | 10.790 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.913 ns | 0.0258 ns | 0.0228 ns | 10.911 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 18.048 ns | 0.0317 ns | 0.0297 ns | 18.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 16.879 ns | 0.0299 ns | 0.0280 ns | 16.892 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 16.737 ns | 0.1482 ns | 0.1314 ns | 16.794 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.367 ns | 0.0409 ns | 0.0383 ns | 19.380 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.368 ns | 0.0305 ns | 0.0285 ns | 19.368 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 13.621 ns | 0.0139 ns | 0.0116 ns | 13.624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 12.630 ns | 0.0146 ns | 0.0129 ns | 12.628 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 | 11.546 ns | 0.2516 ns | 0.3842 ns | 11.748 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 14.164 ns | 0.0190 ns | 0.0177 ns | 14.158 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.746 ns | 0.0187 ns | 0.0156 ns | 13.744 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.931 ns | 0.0282 ns | 0.0264 ns | 17.936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.937 ns | 0.0578 ns | 0.0541 ns | 16.949 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.386 ns | 0.2122 ns | 0.1985 ns | 16.345 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.665 ns | 0.0185 ns | 0.0173 ns | 20.663 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.344 ns | 0.0263 ns | 0.0246 ns | 19.336 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 12.721 ns | 0.0204 ns | 0.0191 ns | 12.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 11.232 ns | 0.0119 ns | 0.0111 ns | 11.234 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.057 ns | 0.1292 ns | 0.1208 ns |  8.110 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.633 ns | 0.0111 ns | 0.0098 ns | 12.633 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 12.927 ns | 0.0399 ns | 0.0333 ns | 12.929 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.139 ns | 0.0150 ns | 0.0141 ns | 13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.766 ns | 0.0473 ns | 0.0395 ns | 12.778 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.447 ns | 0.2934 ns | 0.4391 ns | 13.628 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 13.045 ns | 0.0233 ns | 0.0218 ns | 13.047 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.178 ns | 0.0263 ns | 0.0233 ns | 13.173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.951 ns | 0.0128 ns | 0.0113 ns | 13.946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 12.602 ns | 0.0122 ns | 0.0108 ns | 12.602 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.803 ns | 0.0625 ns | 0.0554 ns | 13.793 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.161 ns | 0.0467 ns | 0.0437 ns | 13.177 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.182 ns | 0.0266 ns | 0.0249 ns | 13.173 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.715 ns | 0.0147 ns | 0.0138 ns | 10.709 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 |  9.762 ns | 0.0130 ns | 0.0121 ns |  9.759 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 11.816 ns | 0.0116 ns | 0.0097 ns | 11.818 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.062 ns | 0.0141 ns | 0.0118 ns | 11.063 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.598 ns | 0.0824 ns | 0.0771 ns | 12.633 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.654 ns | 0.0189 ns | 0.0177 ns | 13.651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.701 ns | 0.0514 ns | 0.0481 ns | 12.730 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 13.758 ns | 0.0211 ns | 0.0197 ns | 13.752 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.370 ns | 0.0660 ns | 0.0617 ns | 13.351 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.196 ns | 0.0143 ns | 0.0127 ns | 13.196 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.855 ns | 0.0179 ns | 0.0167 ns | 16.854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.547 ns | 0.0266 ns | 0.0249 ns | 12.545 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 13.079 ns | 0.0974 ns | 0.0911 ns | 13.115 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.568 ns | 0.1476 ns | 0.1380 ns | 18.601 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 18.627 ns | 0.0451 ns | 0.0399 ns | 18.631 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 15.369 ns | 0.0332 ns | 0.0294 ns | 15.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.007 ns | 0.0208 ns | 0.0194 ns | 15.006 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 15.786 ns | 0.0168 ns | 0.0157 ns | 15.782 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 16.824 ns | 0.0394 ns | 0.0329 ns | 16.824 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.044 ns | 0.0295 ns | 0.0246 ns | 17.043 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.779 ns | 0.0151 ns | 0.0142 ns | 13.779 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 12.451 ns | 0.0719 ns | 0.0672 ns | 12.484 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 12.073 ns | 0.0760 ns | 0.0711 ns | 12.107 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 14.872 ns | 0.0284 ns | 0.0252 ns | 14.864 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.413 ns | 0.0222 ns | 0.0197 ns | 13.410 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.388 ns | 0.0109 ns | 0.0085 ns | 13.388 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.217 ns | 0.0068 ns | 0.0060 ns | 13.217 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.000 ns | 0.0758 ns | 0.0709 ns | 13.018 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 15.169 ns | 0.0182 ns | 0.0161 ns | 15.168 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.367 ns | 0.0770 ns | 0.0721 ns | 13.335 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.733 ns | 0.0106 ns | 0.0088 ns | 12.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.325 ns | 0.0069 ns | 0.0061 ns | 10.327 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.768 ns | 0.0571 ns | 0.0534 ns | 10.785 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 12.332 ns | 0.0130 ns | 0.0115 ns | 12.329 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.336 ns | 0.0140 ns | 0.0131 ns | 12.335 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 15.022 ns | 0.0229 ns | 0.0215 ns | 15.014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 14.086 ns | 0.0603 ns | 0.0564 ns | 14.113 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 12.917 ns | 0.0139 ns | 0.0130 ns | 12.920 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 16.611 ns | 0.0249 ns | 0.0233 ns | 16.610 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.016 ns | 0.0613 ns | 0.0574 ns | 14.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.722 ns | 0.0113 ns | 0.0105 ns | 12.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.318 ns | 0.0088 ns | 0.0073 ns | 10.321 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 10.790 ns | 0.0701 ns | 0.0656 ns | 10.807 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.392 ns | 0.0630 ns | 0.0589 ns | 12.390 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.554 ns | 0.0352 ns | 0.0312 ns | 12.547 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 13.144 ns | 0.0086 ns | 0.0076 ns | 13.146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.638 ns | 0.0082 ns | 0.0072 ns | 12.637 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.884 ns | 0.0991 ns | 0.0927 ns | 13.931 ns |  1.06 |    0.01 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.035 ns | 0.0187 ns | 0.0175 ns | 13.029 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 13.228 ns | 0.0147 ns | 0.0131 ns | 13.230 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.661 ns | 0.0668 ns | 0.0625 ns | 18.641 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 18.013 ns | 0.0772 ns | 0.0722 ns | 18.030 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.033 ns | 0.0295 ns | 0.0261 ns | 11.033 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 17.898 ns | 0.0359 ns | 0.0318 ns | 17.900 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.772 ns | 0.0680 ns | 0.0636 ns | 16.757 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 17.698 ns | 0.0271 ns | 0.0253 ns | 17.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 16.097 ns | 0.0207 ns | 0.0184 ns | 16.093 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 16.176 ns | 0.1456 ns | 0.1362 ns | 16.216 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 19.109 ns | 0.0366 ns | 0.0324 ns | 19.106 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 18.029 ns | 0.0397 ns | 0.0372 ns | 18.018 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 18.789 ns | 0.0404 ns | 0.0358 ns | 18.791 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 15.958 ns | 0.0439 ns | 0.0411 ns | 15.960 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 11.874 ns | 0.0745 ns | 0.0660 ns | 11.893 ns |  0.63 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 16.959 ns | 0.0332 ns | 0.0295 ns | 16.962 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.034 ns | 0.0263 ns | 0.0246 ns | 17.034 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.476 ns | 0.0228 ns | 0.0213 ns | 17.469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.325 ns | 0.0696 ns | 0.0651 ns | 15.350 ns |  0.88 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.209 ns | 0.0263 ns | 0.0246 ns | 16.217 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.523 ns | 0.0340 ns | 0.0284 ns | 17.514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 18.014 ns | 0.0383 ns | 0.0319 ns | 18.005 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.937 ns | 0.0153 ns | 0.0135 ns | 13.938 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 12.778 ns | 0.0083 ns | 0.0070 ns | 12.777 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.506 ns | 0.1756 ns | 0.3341 ns |  7.677 ns |  0.51 |    0.03 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 11.522 ns | 0.1084 ns | 0.1014 ns | 11.555 ns |  0.83 |    0.01 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.465 ns | 0.0139 ns | 0.0130 ns | 10.463 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.048 ns | 0.0183 ns | 0.0153 ns | 14.046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.479 ns | 0.0177 ns | 0.0148 ns | 13.476 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.287 ns | 0.2129 ns | 0.1991 ns | 13.375 ns |  0.94 |    0.02 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.051 ns | 0.0352 ns | 0.0329 ns | 13.048 ns |  0.93 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.185 ns | 0.0124 ns | 0.0116 ns | 13.187 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 11.813 ns | 0.0198 ns | 0.0186 ns | 11.810 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.830 ns | 0.0551 ns | 0.0488 ns | 10.843 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.476 ns | 0.0395 ns | 0.0350 ns |  6.493 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.314 ns | 0.0185 ns | 0.0154 ns | 10.316 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.533 ns | 0.0428 ns | 0.0379 ns | 11.514 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.182 ns | 0.0207 ns | 0.0194 ns | 14.179 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.009 ns | 0.0210 ns | 0.0186 ns | 14.008 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 13.322 ns | 0.2634 ns | 0.2056 ns | 13.347 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.413 ns | 0.0239 ns | 0.0224 ns | 16.407 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.939 ns | 0.0298 ns | 0.0265 ns | 14.927 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 11.670 ns | 0.0356 ns | 0.0333 ns | 11.655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.712 ns | 0.0124 ns | 0.0104 ns | 10.716 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.544 ns | 0.0500 ns | 0.0443 ns |  6.533 ns |  0.56 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 11.900 ns | 0.0261 ns | 0.0245 ns | 11.900 ns |  1.02 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.498 ns | 0.0152 ns | 0.0135 ns | 11.498 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.760 ns | 0.0126 ns | 0.0112 ns | 14.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.060 ns | 0.0455 ns | 0.0425 ns | 15.072 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 13.979 ns | 0.3062 ns | 0.3872 ns | 14.198 ns |  0.93 |    0.02 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 16.402 ns | 0.0381 ns | 0.0357 ns | 16.404 ns |  1.11 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.027 ns | 0.0243 ns | 0.0215 ns | 15.027 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.421 ns | 0.0097 ns | 0.0086 ns | 13.421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.727 ns | 0.0132 ns | 0.0110 ns | 10.729 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.943 ns | 0.1846 ns | 0.3422 ns |  8.021 ns |  0.58 |    0.04 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 10.415 ns | 0.0353 ns | 0.0331 ns | 10.421 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.521 ns | 0.0143 ns | 0.0127 ns | 11.521 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.903 ns | 0.0123 ns | 0.0109 ns | 13.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 14.094 ns | 0.0132 ns | 0.0117 ns | 14.094 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.871 ns | 0.1579 ns | 0.1477 ns | 13.800 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.044 ns | 0.0179 ns | 0.0140 ns | 13.044 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.327 ns | 0.0241 ns | 0.0214 ns | 13.324 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.649 ns | 0.0227 ns | 0.0201 ns | 11.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 10.373 ns | 0.0344 ns | 0.0305 ns | 10.381 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  6.824 ns | 0.0278 ns | 0.0260 ns |  6.816 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 10.261 ns | 0.0121 ns | 0.0113 ns | 10.262 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 11.553 ns | 0.0361 ns | 0.0338 ns | 11.555 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 43.482 ns | 0.1275 ns | 0.1192 ns | 43.435 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 40.788 ns | 0.0910 ns | 0.0851 ns | 40.797 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 37.021 ns | 0.3838 ns | 0.3590 ns | 36.845 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 42.310 ns | 0.1494 ns | 0.1324 ns | 42.269 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 42.450 ns | 0.0432 ns | 0.0383 ns | 42.448 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.294 ns | 0.0181 ns | 0.0169 ns | 12.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 10.906 ns | 0.0109 ns | 0.0102 ns | 10.907 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  7.981 ns | 0.1851 ns | 0.3522 ns |  8.113 ns |  0.63 |    0.04 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 10.680 ns | 0.0240 ns | 0.0200 ns | 10.674 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 10.732 ns | 0.0180 ns | 0.0168 ns | 10.738 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 42.622 ns | 0.1498 ns | 0.1402 ns | 42.586 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.320 ns | 0.1488 ns | 0.1243 ns | 40.360 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 36.951 ns | 0.2439 ns | 0.2162 ns | 36.899 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 42.105 ns | 0.1245 ns | 0.1040 ns | 42.089 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 42.690 ns | 0.0969 ns | 0.0907 ns | 42.702 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.085 ns | 0.0081 ns | 0.0068 ns | 13.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.739 ns | 0.0114 ns | 0.0107 ns | 10.736 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.093 ns | 0.0480 ns | 0.0426 ns |  7.082 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.950 ns | 0.0172 ns | 0.0161 ns | 10.946 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.462 ns | 0.0177 ns | 0.0165 ns | 10.461 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.249 ns | 0.0153 ns | 0.0143 ns | 13.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.662 ns | 0.0128 ns | 0.0120 ns | 12.666 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.113 ns | 0.2392 ns | 0.2237 ns | 12.157 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 13.154 ns | 0.0271 ns | 0.0253 ns | 13.146 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.264 ns | 0.0442 ns | 0.0369 ns | 13.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.726 ns | 0.0156 ns | 0.0139 ns | 12.722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.356 ns | 0.0160 ns | 0.0133 ns | 10.352 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.676 ns | 0.0515 ns | 0.0481 ns | 10.685 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.488 ns | 0.0189 ns | 0.0177 ns | 12.490 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.672 ns | 0.0187 ns | 0.0175 ns | 12.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 14.530 ns | 0.0159 ns | 0.0141 ns | 14.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 15.301 ns | 0.0173 ns | 0.0153 ns | 15.301 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 16.123 ns | 0.3421 ns | 0.4448 ns | 16.091 ns |  1.12 |    0.03 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.202 ns | 0.0361 ns | 0.0301 ns | 15.195 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.274 ns | 0.0213 ns | 0.0199 ns | 15.274 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.717 ns | 0.0210 ns | 0.0175 ns | 12.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.355 ns | 0.0185 ns | 0.0164 ns | 10.353 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 11.876 ns | 0.2595 ns | 0.3465 ns | 11.747 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 14.034 ns | 0.0137 ns | 0.0122 ns | 14.032 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.472 ns | 0.0353 ns | 0.0330 ns | 12.477 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.137 ns | 0.0171 ns | 0.0160 ns | 13.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 12.630 ns | 0.0113 ns | 0.0106 ns | 12.632 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.202 ns | 0.1112 ns | 0.0986 ns | 13.169 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 13.353 ns | 0.0122 ns | 0.0114 ns | 13.352 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.517 ns | 0.0139 ns | 0.0116 ns | 13.519 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.871 ns | 0.0414 ns | 0.0388 ns | 38.871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.251 ns | 0.0437 ns | 0.0365 ns | 36.256 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 36.351 ns | 0.2439 ns | 0.2037 ns | 36.272 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 41.213 ns | 0.2049 ns | 0.1917 ns | 41.114 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 38.574 ns | 0.1156 ns | 0.1025 ns | 38.565 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 14.534 ns | 0.0107 ns | 0.0094 ns | 14.536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 14.361 ns | 0.0129 ns | 0.0101 ns | 14.359 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 15.666 ns | 0.3212 ns | 0.3298 ns | 15.600 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 16.671 ns | 0.0279 ns | 0.0261 ns | 16.671 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.305 ns | 0.0243 ns | 0.0227 ns | 15.301 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.469 ns | 0.0337 ns | 0.0315 ns | 39.465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 36.996 ns | 0.0840 ns | 0.0745 ns | 36.993 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 34.805 ns | 0.4433 ns | 0.3702 ns | 34.578 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 40.081 ns | 0.0412 ns | 0.0365 ns | 40.088 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 40.598 ns | 0.0690 ns | 0.0646 ns | 40.609 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.576 ns | 0.0150 ns | 0.0141 ns | 14.577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.172 ns | 0.0148 ns | 0.0131 ns | 15.177 ns |  1.04 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.592 ns | 0.1644 ns | 0.1458 ns | 15.549 ns |  1.07 |    0.01 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 15.207 ns | 0.0134 ns | 0.0119 ns | 15.206 ns |  1.04 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.283 ns | 0.0237 ns | 0.0222 ns | 15.285 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.655 ns | 0.0547 ns | 0.0457 ns | 39.642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 37.440 ns | 0.1210 ns | 0.1073 ns | 37.399 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 34.248 ns | 0.1954 ns | 0.1732 ns | 34.223 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 39.646 ns | 0.0514 ns | 0.0456 ns | 39.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.423 ns | 0.0867 ns | 0.0769 ns | 38.436 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.232 ns | 0.0166 ns | 0.0147 ns | 13.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.463 ns | 0.0109 ns | 0.0091 ns | 13.463 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.394 ns | 0.2456 ns | 0.2177 ns | 13.443 ns |  1.01 |    0.02 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.126 ns | 0.0159 ns | 0.0148 ns | 13.127 ns |  0.99 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 13.261 ns | 0.0286 ns | 0.0268 ns | 13.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_Int.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Int.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_Int.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_Int.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_Int.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_Int.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_Int.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
