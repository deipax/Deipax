
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.36 ns | 0.0615 ns | 0.0575 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.32 ns | 0.0405 ns | 0.0359 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  18.72 ns | 0.0598 ns | 0.0559 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.31 ns | 0.0222 ns | 0.0185 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.41 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.32 ns | 0.0342 ns | 0.0320 ns |      - |       0 B |
                                             From_Byte |  13.57 ns | 0.0372 ns | 0.0348 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.43 ns | 0.0323 ns | 0.0270 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  18.19 ns | 0.0613 ns | 0.0573 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.61 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.48 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.29 ns | 0.0351 ns | 0.0328 ns |      - |       0 B |
                                             From_Char |  13.56 ns | 0.0361 ns | 0.0337 ns |      - |       0 B |
                                    From_Char_AsObject |  31.00 ns | 0.0775 ns | 0.0725 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  18.18 ns | 0.0376 ns | 0.0334 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  30.96 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.66 ns | 0.0383 ns | 0.0358 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.30 ns | 0.0503 ns | 0.0446 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.62 ns | 0.0304 ns | 0.0270 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.30 ns | 0.0403 ns | 0.0377 ns |      - |       0 B |
                                          From_Decimal |  24.68 ns | 0.0568 ns | 0.0474 ns |      - |       0 B |
                                 From_Decimal_AsObject |  39.21 ns | 0.0750 ns | 0.0665 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.07 ns | 0.0537 ns | 0.0448 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.21 ns | 0.0724 ns | 0.0604 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.67 ns | 0.0192 ns | 0.0150 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.30 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                                           From_Double |  17.41 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                  From_Double_AsObject |  37.03 ns | 0.0499 ns | 0.0467 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  23.64 ns | 0.1566 ns | 0.1465 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  36.65 ns | 0.0430 ns | 0.0402 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.78 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.41 ns | 0.0204 ns | 0.0180 ns |      - |       0 B |
                                            From_Short |  13.70 ns | 0.0211 ns | 0.0177 ns |      - |       0 B |
                                   From_Short_AsObject |  30.50 ns | 0.0318 ns | 0.0248 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.15 ns | 0.0137 ns | 0.0114 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  30.32 ns | 0.0944 ns | 0.0883 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.57 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.38 ns | 0.0851 ns | 0.0796 ns |      - |       0 B |
                                              From_Int |  13.71 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                                     From_Int_AsObject |  30.53 ns | 0.0510 ns | 0.0398 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.17 ns | 0.0306 ns | 0.0272 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.21 ns | 0.0322 ns | 0.0269 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.59 ns | 0.0310 ns | 0.0274 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.45 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                                             From_Long |  13.81 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                                    From_Long_AsObject |  27.97 ns | 0.0257 ns | 0.0215 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  13.99 ns | 0.0346 ns | 0.0324 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.95 ns | 0.0404 ns | 0.0316 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  13.82 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.68 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
                                            From_SByte |  13.56 ns | 0.0260 ns | 0.0231 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.46 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  18.16 ns | 0.0334 ns | 0.0312 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.74 ns | 0.0890 ns | 0.0789 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.47 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.06 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                            From_Float |  17.57 ns | 0.0335 ns | 0.0313 ns |      - |       0 B |
                                   From_Float_AsObject |  34.77 ns | 0.0170 ns | 0.0151 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  21.76 ns | 0.0445 ns | 0.0394 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  34.78 ns | 0.0213 ns | 0.0178 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.59 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.26 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                           From_String |  97.48 ns | 0.1389 ns | 0.1299 ns |      - |       0 B |
                                  From_String_AsObject | 104.56 ns | 0.0253 ns | 0.0212 ns |      - |       0 B |
                                      From_String_Null |  16.27 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.66 ns | 0.0050 ns | 0.0046 ns |      - |       0 B |
                                     From_String_Empty |  20.73 ns | 0.0466 ns | 0.0436 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.74 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.38 ns | 0.0234 ns | 0.0195 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  18.14 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.38 ns | 0.0168 ns | 0.0131 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.57 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.12 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                                             From_UInt |  13.55 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.23 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.18 ns | 0.0238 ns | 0.0223 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.40 ns | 0.0041 ns | 0.0035 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.56 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.28 ns | 0.0063 ns | 0.0052 ns |      - |       0 B |
                                            From_ULong |  14.24 ns | 0.0472 ns | 0.0442 ns |      - |       0 B |
                                   From_ULong_AsObject |  30.79 ns | 0.0151 ns | 0.0118 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.93 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  30.79 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.74 ns | 0.0104 ns | 0.0081 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.26 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                                       From_NullObject |  16.22 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
                                           From_DBNull |  16.13 ns | 0.0240 ns | 0.0224 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.10 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.11 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.38 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.23 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                              From_NonConvertibleClass |  20.43 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.97 ns | 0.0267 ns | 0.0237 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.28 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.23 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.84 ns | 0.0457 ns | 0.0405 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.77 ns | 0.0574 ns | 0.0537 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 101.29 ns | 0.0190 ns | 0.0148 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.52 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.34 ns | 0.0184 ns | 0.0154 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.68 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.45 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.61 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  18.18 ns | 0.0352 ns | 0.0312 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.77 ns | 0.0287 ns | 0.0269 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.42 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.28 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                                             From_Enum |  14.85 ns | 0.0046 ns | 0.0040 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.85 ns | 0.0757 ns | 0.0671 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.71 ns | 0.0349 ns | 0.0309 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.79 ns | 0.1092 ns | 0.1022 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.56 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.35 ns | 0.0155 ns | 0.0130 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
