
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.99 ns | 0.3473 ns | 0.4000 ns |  15.82 ns |      - |       0 B |
                                    From_Bool_AsObject |  33.10 ns | 0.8056 ns | 0.9277 ns |  32.92 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  20.01 ns | 0.4189 ns | 0.3498 ns |  19.86 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  32.52 ns | 0.6344 ns | 0.5934 ns |  32.11 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.80 ns | 0.1062 ns | 0.0886 ns |  15.78 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.25 ns | 0.0651 ns | 0.0544 ns |  17.23 ns |      - |       0 B |
                                             From_Byte |  14.95 ns | 0.4048 ns | 0.6650 ns |  14.70 ns |      - |       0 B |
                                    From_Byte_AsObject |  32.40 ns | 0.2466 ns | 0.2186 ns |  32.39 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  19.67 ns | 0.4507 ns | 0.4215 ns |  19.51 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  32.72 ns | 0.5722 ns | 0.4778 ns |  32.55 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.81 ns | 0.1864 ns | 0.1744 ns |  15.73 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.31 ns | 0.0420 ns | 0.0372 ns |  17.30 ns |      - |       0 B |
                                             From_Char |  14.36 ns | 0.0327 ns | 0.0273 ns |  14.35 ns |      - |       0 B |
                                    From_Char_AsObject |  32.74 ns | 0.0435 ns | 0.0386 ns |  32.72 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  19.05 ns | 0.1825 ns | 0.1708 ns |  19.05 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  33.52 ns | 0.9212 ns | 1.1978 ns |  32.90 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.29 ns | 0.2313 ns | 0.2050 ns |  15.18 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.11 ns | 0.0842 ns | 0.0787 ns |  18.17 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.94 ns | 0.0632 ns | 0.0592 ns |  15.93 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.24 ns | 0.0146 ns | 0.0122 ns |  17.24 ns |      - |       0 B |
                                          From_Decimal |  25.76 ns | 0.0478 ns | 0.0423 ns |  25.75 ns |      - |       0 B |
                                 From_Decimal_AsObject |  43.68 ns | 1.1593 ns | 1.4661 ns |  43.22 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  35.21 ns | 0.3555 ns | 0.3325 ns |  35.08 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  42.65 ns | 0.5454 ns | 0.4555 ns |  42.51 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.93 ns | 0.0799 ns | 0.0747 ns |  15.92 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.64 ns | 0.5287 ns | 0.4415 ns |  17.57 ns |      - |       0 B |
                                           From_Double |  18.47 ns | 0.1730 ns | 0.1619 ns |  18.38 ns |      - |       0 B |
                                  From_Double_AsObject |  37.43 ns | 0.1305 ns | 0.1019 ns |  37.44 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  24.94 ns | 0.6387 ns | 0.6834 ns |  24.64 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  36.91 ns | 0.3795 ns | 0.3365 ns |  36.88 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.12 ns | 0.1501 ns | 0.1331 ns |  16.07 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.49 ns | 0.4052 ns | 0.3592 ns |  17.31 ns |      - |       0 B |
                                            From_Short |  14.25 ns | 0.0553 ns | 0.0490 ns |  14.23 ns |      - |       0 B |
                                   From_Short_AsObject |  32.37 ns | 0.1999 ns | 0.1670 ns |  32.44 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.89 ns | 0.0302 ns | 0.0252 ns |  18.88 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  32.48 ns | 0.4239 ns | 0.3965 ns |  32.58 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.12 ns | 0.0360 ns | 0.0301 ns |  15.11 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.34 ns | 0.1496 ns | 0.1399 ns |  17.31 ns |      - |       0 B |
                                              From_Int |  14.60 ns | 0.4300 ns | 0.3591 ns |  14.43 ns |      - |       0 B |
                                     From_Int_AsObject |  32.83 ns | 0.6526 ns | 0.6104 ns |  32.50 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.91 ns | 0.0852 ns | 0.0797 ns |  18.88 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.87 ns | 0.1520 ns | 0.1269 ns |  31.83 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.04 ns | 0.0507 ns | 0.0396 ns |  15.03 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.49 ns | 0.3829 ns | 0.4256 ns |  17.26 ns |      - |       0 B |
                                             From_Long |  14.72 ns | 0.0457 ns | 0.0405 ns |  14.70 ns |      - |       0 B |
                                    From_Long_AsObject |  29.48 ns | 0.3885 ns | 0.3444 ns |  29.38 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.66 ns | 0.0605 ns | 0.0536 ns |  16.64 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.84 ns | 0.6298 ns | 0.6186 ns |  29.71 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.14 ns | 0.0943 ns | 0.0788 ns |  15.13 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.23 ns | 0.0439 ns | 0.0410 ns |  17.21 ns |      - |       0 B |
                                            From_SByte |  14.15 ns | 0.0213 ns | 0.0178 ns |  14.14 ns |      - |       0 B |
                                   From_SByte_AsObject |  32.04 ns | 0.0616 ns | 0.0576 ns |  32.01 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  19.12 ns | 0.0197 ns | 0.0165 ns |  19.11 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.22 ns | 0.0443 ns | 0.0370 ns |  32.21 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.62 ns | 0.0156 ns | 0.0138 ns |  15.61 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.20 ns | 0.0314 ns | 0.0293 ns |  17.18 ns |      - |       0 B |
                                            From_Float |  18.46 ns | 0.0278 ns | 0.0246 ns |  18.45 ns |      - |       0 B |
                                   From_Float_AsObject |  36.72 ns | 0.0274 ns | 0.0214 ns |  36.73 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  23.07 ns | 0.0141 ns | 0.0132 ns |  23.06 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.79 ns | 0.0604 ns | 0.0565 ns |  36.81 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.13 ns | 0.0387 ns | 0.0362 ns |  15.13 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  21.60 ns | 0.0066 ns | 0.0055 ns |  21.60 ns |      - |       0 B |
                                           From_String | 100.96 ns | 0.0854 ns | 0.0799 ns | 100.94 ns |      - |       0 B |
                                  From_String_AsObject | 110.46 ns | 0.1083 ns | 0.1013 ns | 110.49 ns |      - |       0 B |
                                      From_String_Null |  18.12 ns | 0.0420 ns | 0.0373 ns |  18.11 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.26 ns | 0.0102 ns | 0.0096 ns |  17.25 ns |      - |       0 B |
                                     From_String_Empty |  22.12 ns | 0.0102 ns | 0.0080 ns |  22.12 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.47 ns | 0.0085 ns | 0.0066 ns |  14.47 ns |      - |       0 B |
                                  From_UShort_AsObject |  32.01 ns | 0.0403 ns | 0.0336 ns |  32.00 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  18.99 ns | 0.0899 ns | 0.0841 ns |  19.03 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  32.01 ns | 0.0431 ns | 0.0360 ns |  32.01 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.05 ns | 0.0469 ns | 0.0439 ns |  15.06 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.32 ns | 0.0259 ns | 0.0229 ns |  17.31 ns |      - |       0 B |
                                             From_UInt |  14.28 ns | 0.0201 ns | 0.0188 ns |  14.29 ns |      - |       0 B |
                                    From_UInt_AsObject |  31.83 ns | 0.0421 ns | 0.0352 ns |  31.82 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.92 ns | 0.0329 ns | 0.0308 ns |  18.92 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.11 ns | 0.0677 ns | 0.0633 ns |  32.13 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.10 ns | 0.0204 ns | 0.0171 ns |  15.10 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.19 ns | 0.0248 ns | 0.0220 ns |  17.18 ns |      - |       0 B |
                                            From_ULong |  15.21 ns | 0.0112 ns | 0.0093 ns |  15.21 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.39 ns | 0.0560 ns | 0.0524 ns |  32.37 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  21.01 ns | 0.0288 ns | 0.0270 ns |  21.00 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  32.42 ns | 0.0444 ns | 0.0394 ns |  32.42 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.89 ns | 0.0118 ns | 0.0099 ns |  15.89 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.14 ns | 0.0287 ns | 0.0268 ns |  17.13 ns |      - |       0 B |
                                       From_NullObject |  17.17 ns | 0.0078 ns | 0.0061 ns |  17.18 ns |      - |       0 B |
                                           From_DBNull |  16.02 ns | 0.0356 ns | 0.0333 ns |  16.02 ns |      - |       0 B |
                                 From_ConvertibleClass |  27.01 ns | 0.0566 ns | 0.0501 ns |  27.00 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  29.70 ns | 0.1399 ns | 0.1308 ns |  29.66 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.17 ns | 0.0089 ns | 0.0069 ns |  17.17 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.93 ns | 0.0282 ns | 0.0264 ns |  18.92 ns |      - |       0 B |
                              From_NonConvertibleClass |  21.92 ns | 0.0370 ns | 0.0346 ns |  21.92 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  24.71 ns | 0.0294 ns | 0.0245 ns |  24.70 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.15 ns | 0.0360 ns | 0.0319 ns |  17.15 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.22 ns | 0.0324 ns | 0.0303 ns |  17.21 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.62 ns | 0.0239 ns | 0.0224 ns |  24.61 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.69 ns | 0.0925 ns | 0.0820 ns |  30.69 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  28.94 ns | 0.0867 ns | 0.0811 ns |  28.90 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.65 ns | 0.0454 ns | 0.0425 ns |  30.64 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.37 ns | 0.0378 ns | 0.0335 ns |  15.36 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.19 ns | 0.0175 ns | 0.0137 ns |  17.19 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.29 ns | 0.0382 ns | 0.0339 ns |  14.28 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.62 ns | 0.0196 ns | 0.0184 ns |  25.61 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  18.62 ns | 0.0441 ns | 0.0391 ns |  18.61 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.76 ns | 0.0467 ns | 0.0390 ns |  24.75 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.36 ns | 0.0217 ns | 0.0203 ns |  15.35 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.20 ns | 0.0323 ns | 0.0302 ns |  17.20 ns |      - |       0 B |
                                             From_Enum |  14.46 ns | 0.0306 ns | 0.0286 ns |  14.45 ns |      - |       0 B |
                                    From_Enum_AsObject |  64.38 ns | 0.0310 ns | 0.0275 ns |  64.38 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.96 ns | 0.0794 ns | 0.0742 ns |  18.94 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.60 ns | 0.3296 ns | 0.3083 ns |  64.44 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.35 ns | 0.3607 ns | 0.6222 ns |  16.02 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.21 ns | 0.0236 ns | 0.0209 ns |  17.20 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
