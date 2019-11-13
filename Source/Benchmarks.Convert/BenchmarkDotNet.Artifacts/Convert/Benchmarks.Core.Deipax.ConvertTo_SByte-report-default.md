
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
                                             From_Bool | .NET Core 2.0 | 13.237 ns | 0.0189 ns | 0.0167 ns | 13.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 2.2 | 10.375 ns | 0.0104 ns | 0.0097 ns | 10.371 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                             From_Bool | .NET Core 3.0 |  7.097 ns | 0.0162 ns | 0.0127 ns |  7.103 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net461 | 10.611 ns | 0.0113 ns | 0.0106 ns | 10.611 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                             From_Bool |        net472 | 10.591 ns | 0.0318 ns | 0.0297 ns | 10.602 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Bool_AsObject | .NET Core 2.0 | 16.754 ns | 0.0602 ns | 0.0563 ns | 16.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 2.2 | 15.788 ns | 0.0708 ns | 0.0662 ns | 15.762 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                                    From_Bool_AsObject | .NET Core 3.0 | 17.308 ns | 0.0149 ns | 0.0116 ns | 17.308 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net461 | 17.861 ns | 0.0287 ns | 0.0268 ns | 17.856 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                    From_Bool_AsObject |        net472 | 18.007 ns | 0.0280 ns | 0.0249 ns | 18.003 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Bool_Nullable_WithValue | .NET Core 2.0 | 11.912 ns | 0.0133 ns | 0.0125 ns | 11.912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 2.2 | 10.537 ns | 0.0184 ns | 0.0172 ns | 10.540 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue | .NET Core 3.0 |  7.350 ns | 0.0049 ns | 0.0046 ns |  7.352 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net461 | 10.620 ns | 0.0105 ns | 0.0098 ns | 10.620 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                          From_Bool_Nullable_WithValue |        net472 | 11.037 ns | 0.0194 ns | 0.0172 ns | 11.032 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.907 ns | 0.0386 ns | 0.0322 ns | 16.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.715 ns | 0.0173 ns | 0.0162 ns | 15.719 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.523 ns | 0.0297 ns | 0.0278 ns | 16.531 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net461 | 19.783 ns | 0.0965 ns | 0.0903 ns | 19.806 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                 From_Bool_Nullable_WithValue_AsObject |        net472 | 18.219 ns | 0.0201 ns | 0.0188 ns | 18.220 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Bool_Nullable_NoValue | .NET Core 2.0 | 11.689 ns | 0.0453 ns | 0.0424 ns | 11.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 2.2 | 10.342 ns | 0.0457 ns | 0.0427 ns | 10.333 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue | .NET Core 3.0 |  7.752 ns | 0.1753 ns | 0.2399 ns |  7.899 ns |  0.65 |    0.02 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net461 | 11.835 ns | 0.0118 ns | 0.0105 ns | 11.836 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                            From_Bool_Nullable_NoValue |        net472 | 10.258 ns | 0.0200 ns | 0.0187 ns | 10.253 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.025 ns | 0.0130 ns | 0.0122 ns | 14.025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.652 ns | 0.0374 ns | 0.0332 ns | 12.644 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.331 ns | 0.2700 ns | 0.2772 ns | 12.159 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net461 | 13.097 ns | 0.0273 ns | 0.0242 ns | 13.100 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                   From_Bool_Nullable_NoValue_AsObject |        net472 | 13.317 ns | 0.0201 ns | 0.0188 ns | 13.321 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Byte | .NET Core 2.0 | 11.786 ns | 0.0364 ns | 0.0323 ns | 11.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 2.2 | 10.421 ns | 0.0207 ns | 0.0184 ns | 10.419 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                             From_Byte | .NET Core 3.0 |  7.323 ns | 0.4467 ns | 0.7585 ns |  6.903 ns |  0.68 |    0.07 |      - |     - |     - |         - |
                                             From_Byte |        net461 | 10.785 ns | 0.0270 ns | 0.0239 ns | 10.789 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Byte |        net472 | 10.861 ns | 0.0163 ns | 0.0145 ns | 10.859 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Byte_AsObject | .NET Core 2.0 | 16.828 ns | 0.0243 ns | 0.0227 ns | 16.826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 2.2 | 16.699 ns | 0.0907 ns | 0.0848 ns | 16.739 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                                    From_Byte_AsObject | .NET Core 3.0 | 16.082 ns | 0.0230 ns | 0.0215 ns | 16.079 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net461 | 19.025 ns | 0.0179 ns | 0.0168 ns | 19.026 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                    From_Byte_AsObject |        net472 | 19.175 ns | 0.0234 ns | 0.0219 ns | 19.179 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Byte_Nullable_WithValue | .NET Core 2.0 | 11.931 ns | 0.0631 ns | 0.0590 ns | 11.898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 2.2 | 10.516 ns | 0.0131 ns | 0.0116 ns | 10.517 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue | .NET Core 3.0 |  7.190 ns | 0.1161 ns | 0.1086 ns |  7.262 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net461 | 12.051 ns | 0.0151 ns | 0.0134 ns | 12.050 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                          From_Byte_Nullable_WithValue |        net472 | 11.901 ns | 0.0152 ns | 0.0135 ns | 11.902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.818 ns | 0.0218 ns | 0.0193 ns | 16.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.760 ns | 0.0341 ns | 0.0319 ns | 15.759 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.821 ns | 0.0984 ns | 0.0920 ns | 15.790 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net461 | 20.299 ns | 0.1080 ns | 0.1010 ns | 20.355 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                 From_Byte_Nullable_WithValue_AsObject |        net472 | 18.907 ns | 0.0254 ns | 0.0225 ns | 18.907 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Byte_Nullable_NoValue | .NET Core 2.0 | 12.275 ns | 0.0147 ns | 0.0138 ns | 12.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 2.2 | 10.391 ns | 0.0462 ns | 0.0432 ns | 10.406 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue | .NET Core 3.0 |  8.355 ns | 0.1940 ns | 0.5111 ns |  8.531 ns |  0.62 |    0.07 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net461 | 10.366 ns | 0.0450 ns | 0.0399 ns | 10.351 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                            From_Byte_Nullable_NoValue |        net472 | 10.333 ns | 0.0246 ns | 0.0230 ns | 10.340 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.164 ns | 0.0099 ns | 0.0088 ns | 13.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.643 ns | 0.0176 ns | 0.0147 ns | 12.644 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.326 ns | 0.0119 ns | 0.0099 ns | 11.323 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net461 | 13.040 ns | 0.0144 ns | 0.0135 ns | 13.039 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Byte_Nullable_NoValue_AsObject |        net472 | 13.244 ns | 0.0268 ns | 0.0237 ns | 13.243 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Char | .NET Core 2.0 | 11.883 ns | 0.0179 ns | 0.0168 ns | 11.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Char | .NET Core 2.2 | 10.758 ns | 0.2143 ns | 0.2005 ns | 10.822 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                                             From_Char | .NET Core 3.0 |  6.808 ns | 0.0448 ns | 0.0397 ns |  6.790 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net461 | 10.869 ns | 0.0214 ns | 0.0167 ns | 10.867 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                             From_Char |        net472 | 10.918 ns | 0.0163 ns | 0.0153 ns | 10.922 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Char_AsObject | .NET Core 2.0 | 19.565 ns | 0.0168 ns | 0.0149 ns | 19.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 2.2 | 17.038 ns | 0.0375 ns | 0.0351 ns | 17.047 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject | .NET Core 3.0 | 17.126 ns | 0.0327 ns | 0.0290 ns | 17.120 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net461 | 18.700 ns | 0.0991 ns | 0.0927 ns | 18.712 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                    From_Char_AsObject |        net472 | 18.754 ns | 0.0331 ns | 0.0293 ns | 18.746 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Char_Nullable_WithValue | .NET Core 2.0 | 11.949 ns | 0.0202 ns | 0.0169 ns | 11.943 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 2.2 | 10.528 ns | 0.0175 ns | 0.0164 ns | 10.534 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue | .NET Core 3.0 |  7.059 ns | 0.0098 ns | 0.0087 ns |  7.061 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net461 | 12.022 ns | 0.0154 ns | 0.0129 ns | 12.020 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Char_Nullable_WithValue |        net472 | 11.902 ns | 0.0131 ns | 0.0123 ns | 11.903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.640 ns | 0.0975 ns | 0.0912 ns | 17.701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.879 ns | 0.0271 ns | 0.0253 ns | 16.881 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject | .NET Core 3.0 | 17.137 ns | 0.3638 ns | 0.5446 ns | 17.497 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net461 | 20.486 ns | 0.1186 ns | 0.0990 ns | 20.526 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                 From_Char_Nullable_WithValue_AsObject |        net472 | 18.713 ns | 0.0319 ns | 0.0299 ns | 18.708 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Char_Nullable_NoValue | .NET Core 2.0 | 12.266 ns | 0.0123 ns | 0.0115 ns | 12.263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 2.2 | 10.399 ns | 0.0560 ns | 0.0524 ns | 10.416 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue | .NET Core 3.0 |  7.067 ns | 0.0094 ns | 0.0088 ns |  7.070 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net461 | 10.378 ns | 0.0114 ns | 0.0106 ns | 10.378 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                            From_Char_Nullable_NoValue |        net472 | 10.335 ns | 0.0273 ns | 0.0255 ns | 10.343 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.651 ns | 0.0094 ns | 0.0083 ns | 13.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.461 ns | 0.0121 ns | 0.0108 ns | 13.466 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.583 ns | 0.0113 ns | 0.0100 ns | 11.581 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net461 | 13.033 ns | 0.0162 ns | 0.0151 ns | 13.028 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                   From_Char_Nullable_NoValue_AsObject |        net472 | 13.204 ns | 0.0155 ns | 0.0145 ns | 13.204 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                         From_DateTime | .NET Core 2.0 | 12.107 ns | 0.0181 ns | 0.0169 ns | 12.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 2.2 | 11.532 ns | 0.0157 ns | 0.0139 ns | 11.534 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime | .NET Core 3.0 |  8.669 ns | 0.1884 ns | 0.1935 ns |  8.785 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                                         From_DateTime |        net461 | 12.313 ns | 0.0163 ns | 0.0152 ns | 12.310 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                         From_DateTime |        net472 | 12.939 ns | 0.0227 ns | 0.0213 ns | 12.936 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_DateTime_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                From_DateTime_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_DateTime_Nullable_WithValue | .NET Core 2.0 | 12.964 ns | 0.0091 ns | 0.0085 ns | 12.963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 2.2 | 11.187 ns | 0.0188 ns | 0.0175 ns | 11.188 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue | .NET Core 3.0 |  8.065 ns | 0.0146 ns | 0.0129 ns |  8.065 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net461 | 13.209 ns | 0.0178 ns | 0.0158 ns | 13.209 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      From_DateTime_Nullable_WithValue |        net472 | 13.250 ns | 0.0211 ns | 0.0187 ns | 13.249 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
             From_DateTime_Nullable_WithValue_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_DateTime_Nullable_NoValue | .NET Core 2.0 | 13.257 ns | 0.0089 ns | 0.0078 ns | 13.258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 2.2 | 11.240 ns | 0.0583 ns | 0.0546 ns | 11.270 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue | .NET Core 3.0 |  7.976 ns | 0.0133 ns | 0.0125 ns |  7.977 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net461 | 12.615 ns | 0.0154 ns | 0.0137 ns | 12.618 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_DateTime_Nullable_NoValue |        net472 | 13.935 ns | 0.0305 ns | 0.0286 ns | 13.923 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.173 ns | 0.0154 ns | 0.0128 ns | 13.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.471 ns | 0.0157 ns | 0.0139 ns | 13.474 ns |  1.02 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.412 ns | 0.0425 ns | 0.0398 ns | 11.431 ns |  0.87 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net461 | 13.106 ns | 0.0135 ns | 0.0113 ns | 13.109 ns |  0.99 |    0.00 |      - |     - |     - |         - |
               From_DateTime_Nullable_NoValue_AsObject |        net472 | 15.017 ns | 0.0264 ns | 0.0234 ns | 15.010 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                          From_Decimal | .NET Core 2.0 | 24.701 ns | 0.0232 ns | 0.0217 ns | 24.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 2.2 | 23.147 ns | 0.0372 ns | 0.0348 ns | 23.147 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal | .NET Core 3.0 | 13.573 ns | 0.0321 ns | 0.0300 ns | 13.581 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net461 | 24.882 ns | 0.0219 ns | 0.0183 ns | 24.879 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                          From_Decimal |        net472 | 25.237 ns | 0.0711 ns | 0.0665 ns | 25.258 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_Decimal_AsObject | .NET Core 2.0 | 26.894 ns | 0.0997 ns | 0.0884 ns | 26.918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 2.2 | 27.557 ns | 0.0192 ns | 0.0170 ns | 27.553 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject | .NET Core 3.0 | 21.100 ns | 0.0186 ns | 0.0174 ns | 21.098 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net461 | 27.425 ns | 0.0354 ns | 0.0331 ns | 27.424 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                 From_Decimal_AsObject |        net472 | 27.226 ns | 0.0210 ns | 0.0186 ns | 27.223 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_Decimal_Nullable_WithValue | .NET Core 2.0 | 25.673 ns | 0.0409 ns | 0.0363 ns | 25.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 2.2 | 22.808 ns | 0.0278 ns | 0.0260 ns | 22.802 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue | .NET Core 3.0 | 16.518 ns | 0.1230 ns | 0.1150 ns | 16.450 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net461 | 25.523 ns | 0.0133 ns | 0.0124 ns | 25.526 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                       From_Decimal_Nullable_WithValue |        net472 | 25.221 ns | 0.0186 ns | 0.0165 ns | 25.218 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.0 | 26.734 ns | 0.0195 ns | 0.0152 ns | 26.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 2.2 | 25.739 ns | 0.0209 ns | 0.0175 ns | 25.741 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject | .NET Core 3.0 | 21.278 ns | 0.0448 ns | 0.0419 ns | 21.279 ns |  0.80 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net461 | 27.194 ns | 0.0225 ns | 0.0199 ns | 27.196 ns |  1.02 |    0.00 |      - |     - |     - |         - |
              From_Decimal_Nullable_WithValue_AsObject |        net472 | 27.576 ns | 0.0451 ns | 0.0399 ns | 27.579 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Decimal_Nullable_NoValue | .NET Core 2.0 | 13.243 ns | 0.0112 ns | 0.0105 ns | 13.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 2.2 | 11.457 ns | 0.0559 ns | 0.0496 ns | 11.461 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue | .NET Core 3.0 |  8.292 ns | 0.2226 ns | 0.3781 ns |  8.078 ns |  0.65 |    0.03 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net461 | 13.451 ns | 0.0101 ns | 0.0090 ns | 13.453 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                         From_Decimal_Nullable_NoValue |        net472 | 13.470 ns | 0.0172 ns | 0.0152 ns | 13.468 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.159 ns | 0.0124 ns | 0.0110 ns | 13.157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.473 ns | 0.0127 ns | 0.0112 ns | 13.477 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.419 ns | 0.0307 ns | 0.0287 ns | 13.430 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net461 | 13.380 ns | 0.0802 ns | 0.0750 ns | 13.415 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                From_Decimal_Nullable_NoValue_AsObject |        net472 | 13.185 ns | 0.0166 ns | 0.0147 ns | 13.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_Double | .NET Core 2.0 | 13.310 ns | 0.0158 ns | 0.0140 ns | 13.312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_Double | .NET Core 2.2 | 12.321 ns | 0.0926 ns | 0.0866 ns | 12.349 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                                           From_Double | .NET Core 3.0 | 10.444 ns | 0.2340 ns | 0.2785 ns | 10.656 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                                           From_Double |        net461 | 13.990 ns | 0.0387 ns | 0.0343 ns | 13.979 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                           From_Double |        net472 | 14.113 ns | 0.0535 ns | 0.0500 ns | 14.128 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_Double_AsObject | .NET Core 2.0 | 19.877 ns | 0.0269 ns | 0.0252 ns | 19.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 2.2 | 18.866 ns | 0.0492 ns | 0.0460 ns | 18.876 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject | .NET Core 3.0 | 18.338 ns | 0.0312 ns | 0.0277 ns | 18.349 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net461 | 21.868 ns | 0.0416 ns | 0.0389 ns | 21.872 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                  From_Double_AsObject |        net472 | 20.472 ns | 0.0508 ns | 0.0475 ns | 20.480 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_Double_Nullable_WithValue | .NET Core 2.0 | 15.734 ns | 0.0233 ns | 0.0206 ns | 15.730 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 2.2 | 14.370 ns | 0.0213 ns | 0.0188 ns | 14.370 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue | .NET Core 3.0 | 13.207 ns | 0.0166 ns | 0.0147 ns | 13.211 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net461 | 16.016 ns | 0.0675 ns | 0.0631 ns | 16.032 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                        From_Double_Nullable_WithValue |        net472 | 15.874 ns | 0.0172 ns | 0.0153 ns | 15.872 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.0 | 20.396 ns | 0.0153 ns | 0.0143 ns | 20.392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.667 ns | 0.0162 ns | 0.0151 ns | 18.669 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject | .NET Core 3.0 | 20.281 ns | 0.4287 ns | 0.6923 ns | 19.802 ns |  1.03 |    0.03 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net461 | 20.048 ns | 0.0352 ns | 0.0294 ns | 20.046 ns |  0.98 |    0.00 |      - |     - |     - |         - |
               From_Double_Nullable_WithValue_AsObject |        net472 | 20.434 ns | 0.0882 ns | 0.0782 ns | 20.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Double_Nullable_NoValue | .NET Core 2.0 | 13.037 ns | 0.0098 ns | 0.0082 ns | 13.037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 2.2 | 11.362 ns | 0.0504 ns | 0.0447 ns | 11.375 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue | .NET Core 3.0 |  9.837 ns | 0.2228 ns | 0.4937 ns |  9.965 ns |  0.72 |    0.07 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net461 | 12.679 ns | 0.0190 ns | 0.0148 ns | 12.680 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                          From_Double_Nullable_NoValue |        net472 | 12.713 ns | 0.0137 ns | 0.0128 ns | 12.712 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.214 ns | 0.0609 ns | 0.0570 ns | 13.215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.635 ns | 0.0113 ns | 0.0106 ns | 12.635 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.979 ns | 0.1773 ns | 0.1658 ns | 13.933 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net461 | 13.631 ns | 0.0787 ns | 0.0736 ns | 13.684 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                 From_Double_Nullable_NoValue_AsObject |        net472 | 13.186 ns | 0.0296 ns | 0.0277 ns | 13.177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Short | .NET Core 2.0 | 11.994 ns | 0.0133 ns | 0.0118 ns | 11.993 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 2.2 | 10.630 ns | 0.0132 ns | 0.0123 ns | 10.634 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_Short | .NET Core 3.0 |  7.899 ns | 0.0854 ns | 0.0799 ns |  7.886 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                                            From_Short |        net461 | 10.816 ns | 0.0066 ns | 0.0055 ns | 10.816 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_Short |        net472 | 11.035 ns | 0.0124 ns | 0.0116 ns | 11.034 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Short_AsObject | .NET Core 2.0 | 17.632 ns | 0.0604 ns | 0.0565 ns | 17.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 2.2 | 16.710 ns | 0.0394 ns | 0.0369 ns | 16.696 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject | .NET Core 3.0 | 16.901 ns | 0.0280 ns | 0.0248 ns | 16.902 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net461 | 19.100 ns | 0.0255 ns | 0.0238 ns | 19.101 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                   From_Short_AsObject |        net472 | 19.127 ns | 0.0375 ns | 0.0351 ns | 19.134 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Short_Nullable_WithValue | .NET Core 2.0 | 13.063 ns | 0.0186 ns | 0.0174 ns | 13.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 2.2 | 11.582 ns | 0.0153 ns | 0.0143 ns | 11.582 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue | .NET Core 3.0 |  8.439 ns | 0.1801 ns | 0.1685 ns |  8.346 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net461 | 12.106 ns | 0.0568 ns | 0.0531 ns | 12.087 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Short_Nullable_WithValue |        net472 | 12.070 ns | 0.0109 ns | 0.0102 ns | 12.071 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.306 ns | 0.0307 ns | 0.0287 ns | 17.299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.770 ns | 0.0520 ns | 0.0406 ns | 16.784 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.560 ns | 0.0247 ns | 0.0206 ns | 16.558 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net461 | 19.107 ns | 0.0716 ns | 0.0669 ns | 19.081 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                From_Short_Nullable_WithValue_AsObject |        net472 | 19.148 ns | 0.0322 ns | 0.0286 ns | 19.156 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Short_Nullable_NoValue | .NET Core 2.0 | 12.475 ns | 0.0082 ns | 0.0069 ns | 12.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 2.2 | 10.285 ns | 0.0197 ns | 0.0174 ns | 10.281 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue | .NET Core 3.0 |  7.907 ns | 0.7299 ns | 0.9743 ns |  7.376 ns |  0.67 |    0.09 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net461 | 11.925 ns | 0.0144 ns | 0.0127 ns | 11.920 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Short_Nullable_NoValue |        net472 | 10.335 ns | 0.0628 ns | 0.0587 ns | 10.362 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.709 ns | 0.0127 ns | 0.0118 ns | 13.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.649 ns | 0.0099 ns | 0.0088 ns | 12.654 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.679 ns | 0.1971 ns | 0.1843 ns | 11.759 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net461 | 15.299 ns | 0.0205 ns | 0.0181 ns | 15.299 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                  From_Short_Nullable_NoValue_AsObject |        net472 | 13.642 ns | 0.0122 ns | 0.0114 ns | 13.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                              From_Int | .NET Core 2.0 | 12.012 ns | 0.0142 ns | 0.0118 ns | 12.013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                              From_Int | .NET Core 2.2 | 10.648 ns | 0.0660 ns | 0.0618 ns | 10.681 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                                              From_Int | .NET Core 3.0 |  7.848 ns | 0.0295 ns | 0.0261 ns |  7.841 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net461 | 12.613 ns | 0.0160 ns | 0.0149 ns | 12.613 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                              From_Int |        net472 | 11.081 ns | 0.0205 ns | 0.0191 ns | 11.081 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_Int_AsObject | .NET Core 2.0 | 18.308 ns | 0.0514 ns | 0.0481 ns | 18.316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 2.2 | 16.144 ns | 0.0240 ns | 0.0224 ns | 16.150 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject | .NET Core 3.0 | 15.714 ns | 0.0374 ns | 0.0350 ns | 15.707 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net461 | 20.205 ns | 0.0222 ns | 0.0197 ns | 20.203 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                     From_Int_AsObject |        net472 | 18.858 ns | 0.0208 ns | 0.0194 ns | 18.854 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Int_Nullable_WithValue | .NET Core 2.0 | 12.592 ns | 0.0209 ns | 0.0196 ns | 12.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 2.2 | 11.492 ns | 0.0176 ns | 0.0165 ns | 11.500 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue | .NET Core 3.0 |  8.673 ns | 0.0116 ns | 0.0103 ns |  8.675 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net461 | 12.057 ns | 0.0322 ns | 0.0301 ns | 12.047 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                           From_Int_Nullable_WithValue |        net472 | 12.011 ns | 0.0534 ns | 0.0473 ns | 12.026 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.536 ns | 0.0283 ns | 0.0265 ns | 17.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.483 ns | 0.0229 ns | 0.0203 ns | 16.480 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.084 ns | 0.3417 ns | 0.3656 ns | 15.839 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net461 | 18.904 ns | 0.0290 ns | 0.0271 ns | 18.909 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                  From_Int_Nullable_WithValue_AsObject |        net472 | 18.934 ns | 0.0295 ns | 0.0276 ns | 18.941 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_Int_Nullable_NoValue | .NET Core 2.0 | 11.775 ns | 0.0260 ns | 0.0244 ns | 11.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 2.2 | 10.172 ns | 0.0180 ns | 0.0159 ns | 10.171 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue | .NET Core 3.0 |  7.360 ns | 0.0141 ns | 0.0125 ns |  7.360 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net461 | 11.884 ns | 0.0088 ns | 0.0082 ns | 11.882 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                             From_Int_Nullable_NoValue |        net472 | 10.254 ns | 0.0077 ns | 0.0072 ns | 10.252 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.141 ns | 0.0194 ns | 0.0162 ns | 13.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.643 ns | 0.0192 ns | 0.0179 ns | 12.647 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.437 ns | 0.2689 ns | 0.4567 ns | 12.668 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net461 | 13.144 ns | 0.0171 ns | 0.0152 ns | 13.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_Int_Nullable_NoValue_AsObject |        net472 | 13.278 ns | 0.0227 ns | 0.0212 ns | 13.275 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Long | .NET Core 2.0 | 12.432 ns | 0.0126 ns | 0.0112 ns | 12.430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 2.2 | 10.573 ns | 0.0148 ns | 0.0138 ns | 10.576 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                             From_Long | .NET Core 3.0 |  7.638 ns | 0.0549 ns | 0.0487 ns |  7.623 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net461 | 10.840 ns | 0.0151 ns | 0.0141 ns | 10.839 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                             From_Long |        net472 | 11.152 ns | 0.0376 ns | 0.0314 ns | 11.155 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Long_AsObject | .NET Core 2.0 | 17.528 ns | 0.0258 ns | 0.0241 ns | 17.531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 2.2 | 16.376 ns | 0.0166 ns | 0.0148 ns | 16.377 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject | .NET Core 3.0 | 15.730 ns | 0.0239 ns | 0.0212 ns | 15.728 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net461 | 18.634 ns | 0.0724 ns | 0.0677 ns | 18.612 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                    From_Long_AsObject |        net472 | 18.687 ns | 0.0734 ns | 0.0687 ns | 18.693 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Long_Nullable_WithValue | .NET Core 2.0 | 13.601 ns | 0.0184 ns | 0.0172 ns | 13.602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 2.2 | 12.434 ns | 0.0233 ns | 0.0206 ns | 12.430 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue | .NET Core 3.0 | 12.105 ns | 0.2628 ns | 0.4013 ns | 12.209 ns |  0.88 |    0.04 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net461 | 13.798 ns | 0.0132 ns | 0.0123 ns | 13.800 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_Long_Nullable_WithValue |        net472 | 13.806 ns | 0.0227 ns | 0.0201 ns | 13.807 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.853 ns | 0.0532 ns | 0.0471 ns | 17.862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 2.2 | 17.176 ns | 0.0250 ns | 0.0221 ns | 17.174 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.567 ns | 0.1087 ns | 0.1017 ns | 16.529 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net461 | 18.713 ns | 0.0268 ns | 0.0251 ns | 18.714 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                 From_Long_Nullable_WithValue_AsObject |        net472 | 18.843 ns | 0.0277 ns | 0.0260 ns | 18.835 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Long_Nullable_NoValue | .NET Core 2.0 | 12.640 ns | 0.0155 ns | 0.0145 ns | 12.637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 2.2 | 11.217 ns | 0.0085 ns | 0.0071 ns | 11.216 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue | .NET Core 3.0 |  7.987 ns | 0.0115 ns | 0.0107 ns |  7.988 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net461 | 13.488 ns | 0.0145 ns | 0.0136 ns | 13.485 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                            From_Long_Nullable_NoValue |        net472 | 13.710 ns | 0.0610 ns | 0.0571 ns | 13.743 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.128 ns | 0.0186 ns | 0.0174 ns | 13.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.654 ns | 0.0113 ns | 0.0088 ns | 12.654 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.719 ns | 0.0201 ns | 0.0178 ns | 13.726 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net461 | 15.153 ns | 0.0245 ns | 0.0229 ns | 15.155 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                   From_Long_Nullable_NoValue_AsObject |        net472 | 13.233 ns | 0.0221 ns | 0.0207 ns | 13.228 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_SByte | .NET Core 2.0 | 11.637 ns | 0.0114 ns | 0.0101 ns | 11.638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 2.2 | 10.861 ns | 0.0233 ns | 0.0218 ns | 10.868 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                            From_SByte | .NET Core 3.0 |  6.873 ns | 0.0145 ns | 0.0136 ns |  6.872 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net461 | 10.428 ns | 0.0198 ns | 0.0185 ns | 10.430 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                            From_SByte |        net472 | 10.329 ns | 0.0146 ns | 0.0129 ns | 10.328 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_SByte_AsObject | .NET Core 2.0 | 14.223 ns | 0.0173 ns | 0.0161 ns | 14.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 2.2 | 13.257 ns | 0.0305 ns | 0.0255 ns | 13.255 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject | .NET Core 3.0 | 13.535 ns | 0.1061 ns | 0.0992 ns | 13.601 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net461 | 15.580 ns | 0.0254 ns | 0.0225 ns | 15.579 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                                   From_SByte_AsObject |        net472 | 14.185 ns | 0.0465 ns | 0.0435 ns | 14.181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_SByte_Nullable_WithValue | .NET Core 2.0 | 11.839 ns | 0.0121 ns | 0.0107 ns | 11.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 2.2 | 10.464 ns | 0.0159 ns | 0.0133 ns | 10.465 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue | .NET Core 3.0 |  7.175 ns | 0.1147 ns | 0.1073 ns |  7.226 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net461 | 10.712 ns | 0.0056 ns | 0.0047 ns | 10.713 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                         From_SByte_Nullable_WithValue |        net472 | 12.309 ns | 0.0136 ns | 0.0121 ns | 12.310 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.0 | 13.669 ns | 0.0123 ns | 0.0109 ns | 13.667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.422 ns | 0.0429 ns | 0.0401 ns | 14.430 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject | .NET Core 3.0 | 11.900 ns | 0.0646 ns | 0.0573 ns | 11.922 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net461 | 15.563 ns | 0.0346 ns | 0.0307 ns | 15.564 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                From_SByte_Nullable_WithValue_AsObject |        net472 | 14.117 ns | 0.0450 ns | 0.0399 ns | 14.117 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_SByte_Nullable_NoValue | .NET Core 2.0 | 11.794 ns | 0.0265 ns | 0.0248 ns | 11.799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 2.2 | 10.366 ns | 0.0119 ns | 0.0111 ns | 10.368 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue | .NET Core 3.0 |  6.570 ns | 0.0096 ns | 0.0090 ns |  6.571 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net461 | 10.348 ns | 0.0228 ns | 0.0213 ns | 10.348 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                           From_SByte_Nullable_NoValue |        net472 | 10.380 ns | 0.0164 ns | 0.0145 ns | 10.380 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.135 ns | 0.0143 ns | 0.0134 ns | 13.136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.863 ns | 0.0085 ns | 0.0075 ns | 12.863 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject | .NET Core 3.0 | 12.870 ns | 0.0153 ns | 0.0136 ns | 12.874 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net461 | 13.123 ns | 0.0252 ns | 0.0235 ns | 13.121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_SByte_Nullable_NoValue_AsObject |        net472 | 14.148 ns | 0.0192 ns | 0.0170 ns | 14.145 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_Float | .NET Core 2.0 | 13.206 ns | 0.0207 ns | 0.0194 ns | 13.202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 2.2 | 12.194 ns | 0.0085 ns | 0.0075 ns | 12.195 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                            From_Float | .NET Core 3.0 | 10.242 ns | 0.2679 ns | 0.3577 ns | 10.070 ns |  0.79 |    0.03 |      - |     - |     - |         - |
                                            From_Float |        net461 | 14.258 ns | 0.0299 ns | 0.0265 ns | 14.249 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                            From_Float |        net472 | 14.234 ns | 0.0204 ns | 0.0170 ns | 14.237 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_Float_AsObject | .NET Core 2.0 | 19.579 ns | 0.0245 ns | 0.0229 ns | 19.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 2.2 | 17.901 ns | 0.0401 ns | 0.0356 ns | 17.899 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject | .NET Core 3.0 | 18.570 ns | 0.0259 ns | 0.0230 ns | 18.570 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net461 | 20.243 ns | 0.0267 ns | 0.0250 ns | 20.244 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                                   From_Float_AsObject |        net472 | 20.655 ns | 0.0543 ns | 0.0508 ns | 20.652 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_Float_Nullable_WithValue | .NET Core 2.0 | 14.199 ns | 0.0209 ns | 0.0175 ns | 14.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 2.2 | 13.014 ns | 0.0120 ns | 0.0100 ns | 13.014 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue | .NET Core 3.0 | 10.917 ns | 0.0135 ns | 0.0126 ns | 10.916 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net461 | 13.218 ns | 0.0193 ns | 0.0172 ns | 13.214 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                         From_Float_Nullable_WithValue |        net472 | 13.041 ns | 0.0156 ns | 0.0131 ns | 13.046 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.0 | 19.389 ns | 0.0317 ns | 0.0297 ns | 19.393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 2.2 | 18.006 ns | 0.0596 ns | 0.0529 ns | 18.016 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject | .NET Core 3.0 | 19.465 ns | 0.0679 ns | 0.0635 ns | 19.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net461 | 20.246 ns | 0.0696 ns | 0.0651 ns | 20.244 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                From_Float_Nullable_WithValue_AsObject |        net472 | 20.558 ns | 0.0365 ns | 0.0342 ns | 20.548 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_Float_Nullable_NoValue | .NET Core 2.0 | 11.631 ns | 0.0094 ns | 0.0084 ns | 11.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 2.2 | 10.349 ns | 0.0186 ns | 0.0174 ns | 10.353 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue | .NET Core 3.0 |  7.473 ns | 0.0138 ns | 0.0129 ns |  7.471 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net461 | 10.379 ns | 0.0148 ns | 0.0139 ns | 10.378 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                           From_Float_Nullable_NoValue |        net472 | 10.377 ns | 0.0467 ns | 0.0437 ns | 10.355 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.148 ns | 0.0134 ns | 0.0119 ns | 13.149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.694 ns | 0.0531 ns | 0.0497 ns | 12.669 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.354 ns | 0.1824 ns | 0.1706 ns | 11.232 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net461 | 15.092 ns | 0.0280 ns | 0.0234 ns | 15.092 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                  From_Float_Nullable_NoValue_AsObject |        net472 | 13.171 ns | 0.0152 ns | 0.0127 ns | 13.174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_String | .NET Core 2.0 | 59.914 ns | 0.0624 ns | 0.0584 ns | 59.919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 2.2 | 53.973 ns | 0.0905 ns | 0.0847 ns | 53.953 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                           From_String | .NET Core 3.0 | 19.684 ns | 0.0856 ns | 0.0800 ns | 19.662 ns |  0.33 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net461 | 59.028 ns | 0.1256 ns | 0.1175 ns | 59.011 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                           From_String |        net472 | 58.606 ns | 0.0590 ns | 0.0523 ns | 58.608 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_String_AsObject | .NET Core 2.0 | 64.170 ns | 0.1218 ns | 0.1080 ns | 64.187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 2.2 | 60.325 ns | 0.0960 ns | 0.0898 ns | 60.299 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject | .NET Core 3.0 | 23.249 ns | 0.0986 ns | 0.0922 ns | 23.210 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net461 | 64.946 ns | 0.1947 ns | 0.1821 ns | 64.952 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                  From_String_AsObject |        net472 | 65.192 ns | 0.3090 ns | 0.2890 ns | 65.114 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_String_Null | .NET Core 2.0 | 13.242 ns | 0.0138 ns | 0.0108 ns | 13.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 2.2 | 12.136 ns | 0.0128 ns | 0.0113 ns | 12.135 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null | .NET Core 3.0 | 11.655 ns | 0.0136 ns | 0.0127 ns | 11.654 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net461 | 12.654 ns | 0.0346 ns | 0.0324 ns | 12.658 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                      From_String_Null |        net472 | 11.136 ns | 0.0156 ns | 0.0139 ns | 11.136 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_String_Null_AsObject | .NET Core 2.0 | 13.135 ns | 0.0113 ns | 0.0100 ns | 13.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 2.2 | 12.655 ns | 0.0089 ns | 0.0079 ns | 12.656 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject | .NET Core 3.0 | 11.306 ns | 0.0175 ns | 0.0163 ns | 11.306 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net461 | 13.115 ns | 0.0239 ns | 0.0223 ns | 13.110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_String_Null_AsObject |        net472 | 13.273 ns | 0.0283 ns | 0.0265 ns | 13.271 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_String_Empty | .NET Core 2.0 | 13.393 ns | 0.0161 ns | 0.0150 ns | 13.391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 2.2 | 12.121 ns | 0.0314 ns | 0.0293 ns | 12.111 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty | .NET Core 3.0 | 12.168 ns | 0.1300 ns | 0.1216 ns | 12.084 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                     From_String_Empty |        net461 | 11.357 ns | 0.0179 ns | 0.0168 ns | 11.361 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                                     From_String_Empty |        net472 | 13.013 ns | 0.0491 ns | 0.0460 ns | 13.019 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_String_Empty_AsObject | .NET Core 2.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 2.2 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject | .NET Core 3.0 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net461 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                            From_String_Empty_AsObject |        net472 |        NA |        NA |        NA |        NA |     ? |       ? |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_UShort | .NET Core 2.0 | 11.760 ns | 0.0233 ns | 0.0218 ns | 11.756 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 2.2 | 10.430 ns | 0.0239 ns | 0.0223 ns | 10.427 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                           From_UShort | .NET Core 3.0 |  6.857 ns | 0.0260 ns | 0.0231 ns |  6.850 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net461 | 10.662 ns | 0.0152 ns | 0.0135 ns | 10.659 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                           From_UShort |        net472 | 10.854 ns | 0.0282 ns | 0.0264 ns | 10.847 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_UShort_AsObject | .NET Core 2.0 | 16.986 ns | 0.0325 ns | 0.0288 ns | 16.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 2.2 | 15.897 ns | 0.0282 ns | 0.0264 ns | 15.889 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject | .NET Core 3.0 | 16.297 ns | 0.1927 ns | 0.1803 ns | 16.427 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net461 | 20.150 ns | 0.0382 ns | 0.0319 ns | 20.146 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                                  From_UShort_AsObject |        net472 | 18.868 ns | 0.0406 ns | 0.0360 ns | 18.859 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_UShort_Nullable_WithValue | .NET Core 2.0 | 12.730 ns | 0.0664 ns | 0.0621 ns | 12.688 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 2.2 | 11.007 ns | 0.0206 ns | 0.0193 ns | 11.009 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue | .NET Core 3.0 |  8.705 ns | 0.1999 ns | 0.4129 ns |  8.805 ns |  0.66 |    0.06 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net461 | 12.039 ns | 0.0141 ns | 0.0132 ns | 12.037 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                        From_UShort_Nullable_WithValue |        net472 | 11.867 ns | 0.0116 ns | 0.0108 ns | 11.867 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.0 | 17.024 ns | 0.0394 ns | 0.0329 ns | 17.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.733 ns | 0.0221 ns | 0.0185 ns | 15.724 ns |  0.92 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.323 ns | 0.0397 ns | 0.0372 ns | 16.316 ns |  0.96 |    0.00 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net461 | 19.421 ns | 0.1008 ns | 0.0943 ns | 19.474 ns |  1.14 |    0.01 |      - |     - |     - |         - |
               From_UShort_Nullable_WithValue_AsObject |        net472 | 19.174 ns | 0.0357 ns | 0.0279 ns | 19.173 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UShort_Nullable_NoValue | .NET Core 2.0 | 11.780 ns | 0.0164 ns | 0.0137 ns | 11.781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 2.2 | 10.420 ns | 0.0089 ns | 0.0083 ns | 10.416 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue | .NET Core 3.0 |  7.194 ns | 0.0637 ns | 0.0596 ns |  7.226 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net461 | 10.360 ns | 0.0123 ns | 0.0109 ns | 10.360 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                          From_UShort_Nullable_NoValue |        net472 | 10.231 ns | 0.0157 ns | 0.0146 ns | 10.234 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.139 ns | 0.0534 ns | 0.0474 ns | 14.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.628 ns | 0.0057 ns | 0.0044 ns | 12.628 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject | .NET Core 3.0 | 13.480 ns | 0.2890 ns | 0.4829 ns | 13.688 ns |  0.93 |    0.04 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net461 | 13.116 ns | 0.0311 ns | 0.0290 ns | 13.112 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                 From_UShort_Nullable_NoValue_AsObject |        net472 | 13.741 ns | 0.0154 ns | 0.0144 ns | 13.745 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_UInt | .NET Core 2.0 | 11.750 ns | 0.0135 ns | 0.0127 ns | 11.750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 2.2 | 10.405 ns | 0.0177 ns | 0.0157 ns | 10.402 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                             From_UInt | .NET Core 3.0 |  6.883 ns | 0.0128 ns | 0.0113 ns |  6.881 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net461 | 12.257 ns | 0.0112 ns | 0.0104 ns | 12.258 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                             From_UInt |        net472 | 10.980 ns | 0.0278 ns | 0.0260 ns | 10.979 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_UInt_AsObject | .NET Core 2.0 | 16.962 ns | 0.0867 ns | 0.0811 ns | 17.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 2.2 | 16.113 ns | 0.0487 ns | 0.0455 ns | 16.122 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject | .NET Core 3.0 | 15.464 ns | 0.0445 ns | 0.0416 ns | 15.473 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net461 | 20.415 ns | 0.0292 ns | 0.0259 ns | 20.409 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                                    From_UInt_AsObject |        net472 | 19.102 ns | 0.0265 ns | 0.0235 ns | 19.108 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_UInt_Nullable_WithValue | .NET Core 2.0 | 11.873 ns | 0.0106 ns | 0.0089 ns | 11.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 2.2 | 11.012 ns | 0.0101 ns | 0.0094 ns | 11.014 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue | .NET Core 3.0 |  8.364 ns | 0.1894 ns | 0.2717 ns |  8.337 ns |  0.71 |    0.02 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net461 | 11.985 ns | 0.0136 ns | 0.0121 ns | 11.985 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                          From_UInt_Nullable_WithValue |        net472 | 11.905 ns | 0.0705 ns | 0.0660 ns | 11.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.834 ns | 0.0217 ns | 0.0203 ns | 16.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 2.2 | 16.606 ns | 0.0277 ns | 0.0246 ns | 16.616 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.334 ns | 0.0176 ns | 0.0147 ns | 15.335 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net461 | 20.161 ns | 0.0406 ns | 0.0360 ns | 20.160 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                 From_UInt_Nullable_WithValue_AsObject |        net472 | 21.057 ns | 0.1173 ns | 0.1097 ns | 21.129 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_UInt_Nullable_NoValue | .NET Core 2.0 | 11.823 ns | 0.0522 ns | 0.0463 ns | 11.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 2.2 | 10.455 ns | 0.1064 ns | 0.0943 ns | 10.438 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue | .NET Core 3.0 |  6.874 ns | 0.0092 ns | 0.0086 ns |  6.874 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net461 | 10.362 ns | 0.0182 ns | 0.0162 ns | 10.359 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                            From_UInt_Nullable_NoValue |        net472 | 10.871 ns | 0.1181 ns | 0.1105 ns | 10.880 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.0 | 14.038 ns | 0.0181 ns | 0.0161 ns | 14.042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.778 ns | 0.0539 ns | 0.0421 ns | 12.789 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.134 ns | 0.3008 ns | 0.3805 ns | 14.457 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net461 | 13.780 ns | 0.0170 ns | 0.0150 ns | 13.778 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                   From_UInt_Nullable_NoValue_AsObject |        net472 | 13.180 ns | 0.0170 ns | 0.0159 ns | 13.182 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                            From_ULong | .NET Core 2.0 | 11.736 ns | 0.0132 ns | 0.0110 ns | 11.738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 2.2 | 10.407 ns | 0.0128 ns | 0.0120 ns | 10.403 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                                            From_ULong | .NET Core 3.0 |  6.886 ns | 0.0116 ns | 0.0091 ns |  6.885 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net461 | 10.631 ns | 0.0187 ns | 0.0175 ns | 10.639 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                            From_ULong |        net472 | 10.925 ns | 0.0425 ns | 0.0398 ns | 10.931 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                   From_ULong_AsObject | .NET Core 2.0 | 17.257 ns | 0.0219 ns | 0.0205 ns | 17.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 2.2 | 15.941 ns | 0.0363 ns | 0.0339 ns | 15.934 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject | .NET Core 3.0 | 15.627 ns | 0.1742 ns | 0.1629 ns | 15.730 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net461 | 19.109 ns | 0.0282 ns | 0.0250 ns | 19.120 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                   From_ULong_AsObject |        net472 | 19.135 ns | 0.0181 ns | 0.0151 ns | 19.138 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ULong_Nullable_WithValue | .NET Core 2.0 | 12.672 ns | 0.0100 ns | 0.0089 ns | 12.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 2.2 | 11.481 ns | 0.0119 ns | 0.0112 ns | 11.479 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue | .NET Core 3.0 |  8.487 ns | 0.0155 ns | 0.0145 ns |  8.485 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net461 | 15.328 ns | 0.0179 ns | 0.0159 ns | 15.323 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                         From_ULong_Nullable_WithValue |        net472 | 13.803 ns | 0.0232 ns | 0.0217 ns | 13.808 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.0 | 16.814 ns | 0.0273 ns | 0.0256 ns | 16.814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.937 ns | 0.0281 ns | 0.0263 ns | 15.929 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject | .NET Core 3.0 | 16.423 ns | 0.0549 ns | 0.0514 ns | 16.420 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net461 | 20.437 ns | 0.0166 ns | 0.0155 ns | 20.438 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                From_ULong_Nullable_WithValue_AsObject |        net472 | 19.230 ns | 0.0257 ns | 0.0241 ns | 19.227 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                           From_ULong_Nullable_NoValue | .NET Core 2.0 | 13.163 ns | 0.0193 ns | 0.0181 ns | 13.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 2.2 | 12.036 ns | 0.1991 ns | 0.1863 ns | 12.112 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue | .NET Core 3.0 |  8.418 ns | 0.0296 ns | 0.0247 ns |  8.406 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net461 | 12.707 ns | 0.0151 ns | 0.0134 ns | 12.708 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                           From_ULong_Nullable_NoValue |        net472 | 13.023 ns | 0.0184 ns | 0.0172 ns | 13.025 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.134 ns | 0.0147 ns | 0.0130 ns | 13.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.794 ns | 0.0135 ns | 0.0126 ns | 12.793 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.577 ns | 0.0422 ns | 0.0395 ns | 14.575 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net461 | 14.912 ns | 0.0168 ns | 0.0157 ns | 14.911 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                  From_ULong_Nullable_NoValue_AsObject |        net472 | 13.185 ns | 0.0247 ns | 0.0219 ns | 13.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                       From_NullObject | .NET Core 2.0 | 13.130 ns | 0.0115 ns | 0.0107 ns | 13.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 2.2 | 13.159 ns | 0.0119 ns | 0.0112 ns | 13.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject | .NET Core 3.0 | 13.926 ns | 0.1673 ns | 0.1565 ns | 13.802 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                                       From_NullObject |        net461 | 13.643 ns | 0.0103 ns | 0.0086 ns | 13.644 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                                       From_NullObject |        net472 | 13.287 ns | 0.0651 ns | 0.0609 ns | 13.310 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                           From_DBNull | .NET Core 2.0 | 10.814 ns | 0.0727 ns | 0.0680 ns | 10.839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 2.2 | 10.233 ns | 0.0079 ns | 0.0066 ns | 10.234 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull | .NET Core 3.0 | 12.320 ns | 0.2201 ns | 0.2059 ns | 12.186 ns |  1.14 |    0.02 |      - |     - |     - |         - |
                                           From_DBNull |        net461 | 11.100 ns | 0.0313 ns | 0.0293 ns | 11.101 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                                           From_DBNull |        net472 | 12.474 ns | 0.0140 ns | 0.0117 ns | 12.475 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                  From_DBNull_AsObject | .NET Core 2.0 | 13.999 ns | 0.0217 ns | 0.0203 ns | 14.004 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 2.2 | 12.724 ns | 0.0228 ns | 0.0202 ns | 12.730 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject | .NET Core 3.0 | 11.221 ns | 0.0147 ns | 0.0138 ns | 11.215 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net461 | 13.049 ns | 0.0553 ns | 0.0518 ns | 13.028 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                                  From_DBNull_AsObject |        net472 | 13.233 ns | 0.0187 ns | 0.0175 ns | 13.237 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                 From_ConvertibleClass | .NET Core 2.0 | 16.583 ns | 0.0572 ns | 0.0535 ns | 16.599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 2.2 | 12.565 ns | 0.0155 ns | 0.0145 ns | 12.563 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass | .NET Core 3.0 | 12.230 ns | 0.0832 ns | 0.0778 ns | 12.216 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net461 | 18.589 ns | 0.0644 ns | 0.0603 ns | 18.576 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                                 From_ConvertibleClass |        net472 | 16.994 ns | 0.0421 ns | 0.0394 ns | 16.998 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                        From_ConvertibleClass_AsObject | .NET Core 2.0 | 15.995 ns | 0.0255 ns | 0.0238 ns | 16.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 2.2 | 15.861 ns | 0.0330 ns | 0.0293 ns | 15.856 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject | .NET Core 3.0 | 14.824 ns | 0.3216 ns | 0.3008 ns | 14.622 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net461 | 18.678 ns | 0.1125 ns | 0.1052 ns | 18.721 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                        From_ConvertibleClass_AsObject |        net472 | 17.102 ns | 0.0286 ns | 0.0268 ns | 17.101 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                         From_ConvertibleClass_NoValue | .NET Core 2.0 | 13.788 ns | 0.0279 ns | 0.0233 ns | 13.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 2.2 | 11.736 ns | 0.0153 ns | 0.0135 ns | 11.738 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue | .NET Core 3.0 | 11.039 ns | 0.0150 ns | 0.0140 ns | 11.039 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net461 | 13.165 ns | 0.0266 ns | 0.0249 ns | 13.161 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                         From_ConvertibleClass_NoValue |        net472 | 13.191 ns | 0.0238 ns | 0.0223 ns | 13.188 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.760 ns | 0.0337 ns | 0.0299 ns | 14.751 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 13.513 ns | 0.0126 ns | 0.0112 ns | 13.514 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 12.676 ns | 0.2735 ns | 0.5945 ns | 12.927 ns |  0.81 |    0.05 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net461 | 13.133 ns | 0.0377 ns | 0.0353 ns | 13.121 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                From_ConvertibleClass_NoValue_AsObject |        net472 | 13.853 ns | 0.0161 ns | 0.0151 ns | 13.856 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_NonConvertibleClass | .NET Core 2.0 | 12.818 ns | 0.0528 ns | 0.0494 ns | 12.825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 2.2 | 10.317 ns | 0.0117 ns | 0.0110 ns | 10.316 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                              From_NonConvertibleClass | .NET Core 3.0 | 10.850 ns | 0.0922 ns | 0.0862 ns | 10.907 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net461 | 14.101 ns | 0.0582 ns | 0.0544 ns | 14.121 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                              From_NonConvertibleClass |        net472 | 12.372 ns | 0.0202 ns | 0.0189 ns | 12.374 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_NonConvertibleClass_AsObject | .NET Core 2.0 | 16.639 ns | 0.0111 ns | 0.0104 ns | 16.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 2.2 | 15.043 ns | 0.0167 ns | 0.0148 ns | 15.047 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject | .NET Core 3.0 | 13.943 ns | 0.3008 ns | 0.5269 ns | 14.223 ns |  0.81 |    0.04 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net461 | 17.456 ns | 0.0232 ns | 0.0205 ns | 17.460 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                     From_NonConvertibleClass_AsObject |        net472 | 15.001 ns | 0.0187 ns | 0.0175 ns | 15.000 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                      From_NonConvertibleClass_NoValue | .NET Core 2.0 | 12.785 ns | 0.0337 ns | 0.0315 ns | 12.780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 2.2 | 10.321 ns | 0.0084 ns | 0.0075 ns | 10.321 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue | .NET Core 3.0 | 11.834 ns | 0.0936 ns | 0.0876 ns | 11.888 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net461 | 12.326 ns | 0.0206 ns | 0.0182 ns | 12.327 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      From_NonConvertibleClass_NoValue |        net472 | 12.583 ns | 0.0212 ns | 0.0198 ns | 12.579 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.0 | 14.025 ns | 0.0209 ns | 0.0196 ns | 14.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 2.2 | 12.630 ns | 0.0220 ns | 0.0195 ns | 12.632 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject | .NET Core 3.0 | 13.211 ns | 0.2888 ns | 0.6636 ns | 13.437 ns |  0.89 |    0.08 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net461 | 13.125 ns | 0.0412 ns | 0.0386 ns | 13.134 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             From_NonConvertibleClass_NoValue_AsObject |        net472 | 14.168 ns | 0.0111 ns | 0.0099 ns | 14.168 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                From_ConvertibleStruct | .NET Core 2.0 | 18.608 ns | 0.0713 ns | 0.0596 ns | 18.622 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 2.2 | 16.138 ns | 0.0352 ns | 0.0329 ns | 16.136 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct | .NET Core 3.0 | 11.358 ns | 0.0326 ns | 0.0254 ns | 11.366 ns |  0.61 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net461 | 21.710 ns | 0.0159 ns | 0.0141 ns | 21.706 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
                                From_ConvertibleStruct |        net472 | 16.605 ns | 0.0328 ns | 0.0291 ns | 16.608 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                       From_ConvertibleStruct_AsObject | .NET Core 2.0 | 16.010 ns | 0.0547 ns | 0.0512 ns | 15.996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 2.2 | 15.224 ns | 0.0297 ns | 0.0278 ns | 15.208 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject | .NET Core 3.0 | 15.568 ns | 0.0612 ns | 0.0572 ns | 15.561 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net461 | 17.569 ns | 0.0292 ns | 0.0244 ns | 17.571 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                       From_ConvertibleStruct_AsObject |        net472 | 17.784 ns | 0.0300 ns | 0.0280 ns | 17.779 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 19.004 ns | 0.1386 ns | 0.1297 ns | 18.943 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 16.053 ns | 0.0515 ns | 0.0456 ns | 16.043 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue | .NET Core 3.0 | 13.025 ns | 0.1694 ns | 0.1502 ns | 13.049 ns |  0.69 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net461 | 17.086 ns | 0.1022 ns | 0.0956 ns | 17.103 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
             From_ConvertibleStruct_Nullable_WithValue |        net472 | 17.153 ns | 0.0310 ns | 0.0275 ns | 17.153 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.724 ns | 0.0175 ns | 0.0164 ns | 15.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.235 ns | 0.0219 ns | 0.0183 ns | 15.233 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.407 ns | 0.0259 ns | 0.0243 ns | 15.409 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 17.564 ns | 0.0301 ns | 0.0267 ns | 17.573 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 17.771 ns | 0.0435 ns | 0.0407 ns | 17.777 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 13.208 ns | 0.0263 ns | 0.0220 ns | 13.209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 11.967 ns | 0.0156 ns | 0.0146 ns | 11.968 ns |  0.91 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  7.899 ns | 0.0153 ns | 0.0143 ns |  7.897 ns |  0.60 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net461 | 10.473 ns | 0.0132 ns | 0.0117 ns | 10.478 ns |  0.79 |    0.00 |      - |     - |     - |         - |
               From_ConvertibleStruct_Nullable_NoValue |        net472 | 10.488 ns | 0.0149 ns | 0.0132 ns | 10.484 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.128 ns | 0.0225 ns | 0.0211 ns | 13.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 13.522 ns | 0.0174 ns | 0.0154 ns | 13.526 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.414 ns | 0.0561 ns | 0.0525 ns | 11.426 ns |  0.87 |    0.00 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 13.105 ns | 0.0737 ns | 0.0689 ns | 13.063 ns |  1.00 |    0.01 |      - |     - |     - |         - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.207 ns | 0.0131 ns | 0.0116 ns | 13.206 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_NonConvertibleStruct | .NET Core 2.0 | 13.029 ns | 0.0106 ns | 0.0099 ns | 13.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 2.2 | 10.739 ns | 0.0509 ns | 0.0476 ns | 10.718 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct | .NET Core 3.0 |  6.707 ns | 0.0101 ns | 0.0084 ns |  6.707 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net461 | 10.749 ns | 0.0157 ns | 0.0139 ns | 10.751 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                             From_NonConvertibleStruct |        net472 | 11.527 ns | 0.0123 ns | 0.0109 ns | 11.526 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.0 | 14.205 ns | 0.0100 ns | 0.0089 ns | 14.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 2.2 | 14.024 ns | 0.0272 ns | 0.0255 ns | 14.029 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject | .NET Core 3.0 | 14.305 ns | 0.3076 ns | 0.3542 ns | 14.471 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net461 | 16.384 ns | 0.0261 ns | 0.0244 ns | 16.385 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    From_NonConvertibleStruct_AsObject |        net472 | 14.974 ns | 0.0210 ns | 0.0186 ns | 14.973 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.0 | 11.684 ns | 0.0296 ns | 0.0277 ns | 11.684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 2.2 | 10.804 ns | 0.0315 ns | 0.0263 ns | 10.811 ns |  0.92 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue | .NET Core 3.0 |  6.450 ns | 0.0274 ns | 0.0257 ns |  6.461 ns |  0.55 |    0.00 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net461 | 10.814 ns | 0.0562 ns | 0.0526 ns | 10.842 ns |  0.93 |    0.01 |      - |     - |     - |         - |
          From_NonConvertibleStruct_Nullable_WithValue |        net472 | 11.511 ns | 0.0157 ns | 0.0146 ns | 11.510 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 14.176 ns | 0.0091 ns | 0.0071 ns | 14.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 14.043 ns | 0.0161 ns | 0.0151 ns | 14.043 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 14.338 ns | 0.0136 ns | 0.0127 ns | 14.335 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net461 | 14.888 ns | 0.0507 ns | 0.0475 ns | 14.868 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        net472 | 15.238 ns | 0.0314 ns | 0.0294 ns | 15.242 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.0 | 11.666 ns | 0.0274 ns | 0.0243 ns | 11.660 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 2.2 | 10.835 ns | 0.0649 ns | 0.0607 ns | 10.869 ns |  0.93 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue | .NET Core 3.0 |  6.966 ns | 0.1175 ns | 0.1099 ns |  7.039 ns |  0.60 |    0.01 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net461 | 11.283 ns | 0.0194 ns | 0.0172 ns | 11.280 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            From_NonConvertibleStruct_Nullable_NoValue |        net472 | 11.595 ns | 0.0141 ns | 0.0118 ns | 11.590 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.176 ns | 0.0234 ns | 0.0207 ns | 13.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.660 ns | 0.0179 ns | 0.0149 ns | 12.659 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 14.618 ns | 0.2505 ns | 0.2343 ns | 14.658 ns |  1.11 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net461 | 14.468 ns | 0.0897 ns | 0.0839 ns | 14.533 ns |  1.10 |    0.01 |      - |     - |     - |         - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |        net472 | 13.208 ns | 0.0139 ns | 0.0130 ns | 13.210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                             From_Enum | .NET Core 2.0 | 11.977 ns | 0.0133 ns | 0.0111 ns | 11.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 2.2 | 11.922 ns | 0.0112 ns | 0.0099 ns | 11.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                             From_Enum | .NET Core 3.0 |  7.800 ns | 0.0147 ns | 0.0137 ns |  7.799 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net461 | 12.576 ns | 0.0232 ns | 0.0205 ns | 12.572 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                             From_Enum |        net472 | 10.859 ns | 0.0140 ns | 0.0131 ns | 10.858 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                    From_Enum_AsObject | .NET Core 2.0 | 50.118 ns | 0.1667 ns | 0.1560 ns | 50.132 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 2.2 | 43.232 ns | 0.0743 ns | 0.0695 ns | 43.239 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject | .NET Core 3.0 | 36.001 ns | 0.2967 ns | 0.2775 ns | 36.089 ns |  0.72 |    0.01 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net461 | 44.341 ns | 0.1135 ns | 0.1006 ns | 44.355 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
                                    From_Enum_AsObject |        net472 | 43.093 ns | 0.1642 ns | 0.1536 ns | 43.130 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                          From_Enum_Nullable_WithValue | .NET Core 2.0 | 12.559 ns | 0.0198 ns | 0.0185 ns | 12.559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 2.2 | 13.993 ns | 0.0127 ns | 0.0112 ns | 13.993 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue | .NET Core 3.0 |  8.514 ns | 0.1902 ns | 0.2190 ns |  8.522 ns |  0.67 |    0.02 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net461 | 12.060 ns | 0.0677 ns | 0.0633 ns | 12.028 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                          From_Enum_Nullable_WithValue |        net472 | 12.036 ns | 0.0095 ns | 0.0080 ns | 12.035 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.0 | 43.353 ns | 0.0649 ns | 0.0542 ns | 43.350 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 2.2 | 40.166 ns | 0.0686 ns | 0.0642 ns | 40.179 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | .NET Core 3.0 | 36.337 ns | 0.1284 ns | 0.1201 ns | 36.326 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net461 | 43.157 ns | 0.1173 ns | 0.0980 ns | 43.124 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                 From_Enum_Nullable_WithValue_AsObject |        net472 | 44.975 ns | 0.2461 ns | 0.2302 ns | 45.026 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_Enum_Nullable_NoValue | .NET Core 2.0 | 13.101 ns | 0.0260 ns | 0.0203 ns | 13.095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 2.2 | 10.790 ns | 0.0355 ns | 0.0332 ns | 10.776 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue | .NET Core 3.0 |  7.083 ns | 0.0548 ns | 0.0513 ns |  7.060 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net461 | 10.393 ns | 0.0123 ns | 0.0115 ns | 10.391 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                            From_Enum_Nullable_NoValue |        net472 | 10.384 ns | 0.0189 ns | 0.0167 ns | 10.385 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.120 ns | 0.0080 ns | 0.0067 ns | 13.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.658 ns | 0.0146 ns | 0.0122 ns | 12.656 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.372 ns | 0.0447 ns | 0.0418 ns | 11.357 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net461 | 15.010 ns | 0.1044 ns | 0.0976 ns | 14.953 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                   From_Enum_Nullable_NoValue_AsObject |        net472 | 13.287 ns | 0.0289 ns | 0.0270 ns | 13.281 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                      From_ParentClass | .NET Core 2.0 | 12.728 ns | 0.0160 ns | 0.0133 ns | 12.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 2.2 | 10.740 ns | 0.0247 ns | 0.0219 ns | 10.743 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass | .NET Core 3.0 | 10.644 ns | 0.0392 ns | 0.0367 ns | 10.634 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net461 | 12.393 ns | 0.0124 ns | 0.0116 ns | 12.393 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                      From_ParentClass |        net472 | 12.618 ns | 0.0173 ns | 0.0162 ns | 12.620 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                             From_ParentClass_AsObject | .NET Core 2.0 | 15.401 ns | 0.0183 ns | 0.0171 ns | 15.406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 2.2 | 14.431 ns | 0.0534 ns | 0.0499 ns | 14.406 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject | .NET Core 3.0 | 13.320 ns | 0.0649 ns | 0.0607 ns | 13.315 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net461 | 15.305 ns | 0.0457 ns | 0.0428 ns | 15.327 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                             From_ParentClass_AsObject |        net472 | 15.333 ns | 0.0335 ns | 0.0297 ns | 15.331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                              From_ParentClass_NoValue | .NET Core 2.0 | 12.730 ns | 0.0144 ns | 0.0135 ns | 12.728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 2.2 | 10.355 ns | 0.0091 ns | 0.0085 ns | 10.355 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue | .NET Core 3.0 | 12.040 ns | 0.2156 ns | 0.1912 ns | 12.133 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net461 | 12.329 ns | 0.0252 ns | 0.0236 ns | 12.336 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                              From_ParentClass_NoValue |        net472 | 12.372 ns | 0.0166 ns | 0.0147 ns | 12.374 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.0 | 13.140 ns | 0.0144 ns | 0.0128 ns | 13.141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 2.2 | 14.642 ns | 0.0471 ns | 0.0441 ns | 14.638 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject | .NET Core 3.0 | 13.612 ns | 0.0576 ns | 0.0539 ns | 13.635 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net461 | 14.915 ns | 0.0217 ns | 0.0193 ns | 14.918 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                     From_ParentClass_NoValue_AsObject |        net472 | 13.811 ns | 0.0232 ns | 0.0217 ns | 13.813 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                                     From_ParentStruct | .NET Core 2.0 | 38.668 ns | 0.1969 ns | 0.1842 ns | 38.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 2.2 | 36.869 ns | 0.1350 ns | 0.1262 ns | 36.803 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                                     From_ParentStruct | .NET Core 3.0 | 35.995 ns | 0.5601 ns | 0.5239 ns | 36.156 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                                     From_ParentStruct |        net461 | 38.552 ns | 0.1273 ns | 0.1190 ns | 38.582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                                     From_ParentStruct |        net472 | 40.776 ns | 0.0724 ns | 0.0677 ns | 40.773 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                            From_ParentStruct_AsObject | .NET Core 2.0 | 14.524 ns | 0.0125 ns | 0.0117 ns | 14.523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 2.2 | 15.214 ns | 0.0193 ns | 0.0180 ns | 15.210 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject | .NET Core 3.0 | 13.440 ns | 0.2222 ns | 0.2078 ns | 13.587 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net461 | 15.196 ns | 0.0386 ns | 0.0342 ns | 15.190 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                            From_ParentStruct_AsObject |        net472 | 15.330 ns | 0.0309 ns | 0.0274 ns | 15.328 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.0 | 39.035 ns | 0.0417 ns | 0.0390 ns | 39.019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 2.2 | 37.076 ns | 0.0357 ns | 0.0334 ns | 37.066 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue | .NET Core 3.0 | 33.872 ns | 0.0416 ns | 0.0389 ns | 33.878 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net461 | 38.659 ns | 0.1584 ns | 0.1481 ns | 38.683 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                  From_ParentStruct_Nullable_WithValue |        net472 | 38.472 ns | 0.0731 ns | 0.0648 ns | 38.483 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.0 | 15.386 ns | 0.0484 ns | 0.0452 ns | 15.398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 2.2 | 15.288 ns | 0.0273 ns | 0.0242 ns | 15.282 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject | .NET Core 3.0 | 15.684 ns | 0.3357 ns | 0.6626 ns | 15.877 ns |  0.99 |    0.07 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net461 | 16.765 ns | 0.0766 ns | 0.0716 ns | 16.783 ns |  1.09 |    0.00 |      - |     - |     - |         - |
         From_ParentStruct_Nullable_WithValue_AsObject |        net472 | 15.276 ns | 0.0211 ns | 0.0197 ns | 15.280 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.0 | 39.324 ns | 0.1498 ns | 0.1401 ns | 39.278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 2.2 | 44.805 ns | 0.0918 ns | 0.0813 ns | 44.805 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue | .NET Core 3.0 | 35.844 ns | 0.0341 ns | 0.0319 ns | 35.853 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net461 | 38.255 ns | 0.0431 ns | 0.0360 ns | 38.259 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    From_ParentStruct_Nullable_NoValue |        net472 | 38.523 ns | 0.0795 ns | 0.0705 ns | 38.506 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                                                       |               |           |           |           |           |       |         |        |       |       |           |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.0 | 13.166 ns | 0.0229 ns | 0.0191 ns | 13.164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 2.2 | 12.760 ns | 0.0315 ns | 0.0279 ns | 12.768 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject | .NET Core 3.0 | 11.898 ns | 0.1556 ns | 0.1455 ns | 11.938 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net461 | 13.667 ns | 0.0119 ns | 0.0105 ns | 13.666 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           From_ParentStruct_Nullable_NoValue_AsObject |        net472 | 14.158 ns | 0.0306 ns | 0.0271 ns | 14.157 ns |  1.08 |    0.00 |      - |     - |     - |         - |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_DateTime_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_DateTime_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_DateTime_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByte.From_DateTime_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: Job-PJAXXB(Toolchain=net472)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-FWPOAF(Toolchain=.NET Core 2.0)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-ZZPTUV(Toolchain=.NET Core 2.2)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-EOJUSV(Toolchain=.NET Core 3.0)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-KESODJ(Toolchain=net461)
  ConvertTo_SByte.From_String_Empty_AsObject: Job-PJAXXB(Toolchain=net472)
