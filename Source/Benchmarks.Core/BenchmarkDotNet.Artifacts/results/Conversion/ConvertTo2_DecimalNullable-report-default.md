
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  22.43 ns | 0.0289 ns | 0.0226 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.89 ns | 0.2519 ns | 0.2103 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  22.64 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.74 ns | 0.0644 ns | 0.0602 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.45 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.01 ns | 0.0392 ns | 0.0366 ns |      - |       0 B |
                                             From_Byte |  22.13 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.75 ns | 0.0161 ns | 0.0134 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  22.90 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.63 ns | 0.0433 ns | 0.0384 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.43 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.08 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                                             From_Char |  16.44 ns | 0.0445 ns | 0.0416 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.10 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.14 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.69 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
                                         From_DateTime |  16.47 ns | 0.0243 ns | 0.0216 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.14 ns | 0.0436 ns | 0.0407 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.10 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.63 ns | 0.0071 ns | 0.0055 ns |      - |       0 B |
                                          From_Decimal |  16.27 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                                 From_Decimal_AsObject |  33.00 ns | 0.0939 ns | 0.0878 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  15.88 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  32.95 ns | 0.0076 ns | 0.0059 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.94 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.67 ns | 0.0295 ns | 0.0230 ns |      - |       0 B |
                                           From_Double |  83.26 ns | 0.0895 ns | 0.0793 ns |      - |       0 B |
                                  From_Double_AsObject |  91.62 ns | 0.0973 ns | 0.0862 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  90.66 ns | 0.0465 ns | 0.0412 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  91.73 ns | 0.0704 ns | 0.0624 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.76 ns | 0.0376 ns | 0.0352 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.94 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
                                            From_Short |  22.15 ns | 0.0361 ns | 0.0338 ns |      - |       0 B |
                                   From_Short_AsObject |  28.96 ns | 0.0878 ns | 0.0779 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  22.88 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.07 ns | 0.0263 ns | 0.0233 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.40 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  20.27 ns | 0.0142 ns | 0.0132 ns |      - |       0 B |
                                              From_Int |  22.38 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                                     From_Int_AsObject |  28.82 ns | 0.0348 ns | 0.0326 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  22.61 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  28.89 ns | 0.1808 ns | 0.1691 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.41 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.53 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
                                             From_Long |  22.61 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                                    From_Long_AsObject |  29.61 ns | 0.0501 ns | 0.0468 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  22.88 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.68 ns | 0.0189 ns | 0.0158 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.46 ns | 0.0134 ns | 0.0126 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.72 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                            From_SByte |  22.37 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.74 ns | 0.0434 ns | 0.0406 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  22.63 ns | 0.0328 ns | 0.0306 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.76 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.41 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  20.74 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                            From_Float |  44.52 ns | 0.0474 ns | 0.0444 ns |      - |       0 B |
                                   From_Float_AsObject |  52.92 ns | 0.0373 ns | 0.0312 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  44.88 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  53.22 ns | 0.1720 ns | 0.1609 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  18.55 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.02 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                                           From_String | 123.33 ns | 0.0259 ns | 0.0217 ns |      - |       0 B |
                                  From_String_AsObject | 133.43 ns | 0.3535 ns | 0.3307 ns |      - |       0 B |
                                      From_String_Null |  16.85 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.75 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                                     From_String_Empty |  18.04 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  22.13 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                                  From_UShort_AsObject |  29.47 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  22.61 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.19 ns | 0.1321 ns | 0.1236 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.41 ns | 0.0380 ns | 0.0356 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  19.09 ns | 0.0209 ns | 0.0196 ns |      - |       0 B |
                                             From_UInt |  22.12 ns | 0.0338 ns | 0.0300 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.88 ns | 0.1881 ns | 0.1760 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  22.36 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.16 ns | 0.0495 ns | 0.0463 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.40 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.71 ns | 0.0589 ns | 0.0522 ns |      - |       0 B |
                                            From_ULong |  22.12 ns | 0.0342 ns | 0.0303 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.89 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  22.91 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  33.11 ns | 0.0405 ns | 0.0359 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.56 ns | 0.0235 ns | 0.0209 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.61 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                       From_NullObject |  19.30 ns | 0.0338 ns | 0.0317 ns |      - |       0 B |
                                           From_DBNull |  16.68 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                                  From_DBNull_AsObject |  17.69 ns | 0.0395 ns | 0.0370 ns |      - |       0 B |
                                 From_ConvertibleClass |  23.31 ns | 0.0147 ns | 0.0131 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  25.64 ns | 0.0346 ns | 0.0323 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.80 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.86 ns | 0.0568 ns | 0.0532 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.13 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.21 ns | 0.0236 ns | 0.0197 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.16 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.29 ns | 0.0448 ns | 0.0419 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.26 ns | 0.0328 ns | 0.0307 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  26.89 ns | 0.2228 ns | 0.2084 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  25.66 ns | 0.0333 ns | 0.0311 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.61 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.72 ns | 0.0320 ns | 0.0299 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.08 ns | 0.0086 ns | 0.0057 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.87 ns | 0.0225 ns | 0.0200 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.25 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.87 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.60 ns | 0.2237 ns | 0.2092 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.86 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  19.70 ns | 0.0210 ns | 0.0187 ns |      - |       0 B |
                                             From_Enum |  22.16 ns | 0.0348 ns | 0.0309 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.40 ns | 0.1023 ns | 0.0957 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  25.11 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.15 ns | 0.0410 ns | 0.0363 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.33 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  20.78 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
                                      From_ParentClass |  16.10 ns | 0.0348 ns | 0.0326 ns |      - |       0 B |
                             From_ParentClass_AsObject |  21.75 ns | 0.0088 ns | 0.0069 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.10 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  19.64 ns | 0.0183 ns | 0.0152 ns |      - |       0 B |
                                     From_ParentStruct |  16.61 ns | 0.0376 ns | 0.0351 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  21.76 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.63 ns | 0.0522 ns | 0.0488 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.04 ns | 0.3679 ns | 0.3441 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.87 ns | 0.0283 ns | 0.0251 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.25 ns | 0.0176 ns | 0.0164 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_String_Empty_AsObject: DefaultJob
