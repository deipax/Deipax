
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.56 ns | 0.0767 ns | 0.0680 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.75 ns | 0.0267 ns | 0.0237 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.83 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 23.83 ns | 0.0549 ns | 0.0513 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.43 ns | 0.0135 ns | 0.0113 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.48 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                             From_Byte | 13.55 ns | 0.0085 ns | 0.0067 ns |      - |       0 B |
                                    From_Byte_AsObject | 23.30 ns | 0.0503 ns | 0.0446 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.47 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 23.28 ns | 0.0336 ns | 0.0315 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.78 ns | 0.0089 ns | 0.0069 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 15.93 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                                             From_Char | 13.52 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                                    From_Char_AsObject | 24.02 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.32 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 24.02 ns | 0.0468 ns | 0.0415 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.72 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.31 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                                         From_DateTime | 13.45 ns | 0.0289 ns | 0.0271 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.32 ns | 0.0320 ns | 0.0299 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.32 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 15.93 ns | 0.0227 ns | 0.0201 ns |      - |       0 B |
                                          From_Decimal | 25.00 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                                 From_Decimal_AsObject | 33.95 ns | 0.0464 ns | 0.0362 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 26.34 ns | 0.0314 ns | 0.0263 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 33.27 ns | 0.0461 ns | 0.0431 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.32 ns | 0.0104 ns | 0.0081 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 15.93 ns | 0.0101 ns | 0.0084 ns |      - |       0 B |
                                           From_Double | 16.63 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                                  From_Double_AsObject | 26.35 ns | 0.0461 ns | 0.0431 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 18.94 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.40 ns | 0.0812 ns | 0.0719 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.35 ns | 0.0504 ns | 0.0471 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 15.95 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
                                            From_Short | 14.07 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                                   From_Short_AsObject | 24.38 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.59 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 25.33 ns | 0.0088 ns | 0.0069 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.69 ns | 0.0183 ns | 0.0153 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.19 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                                              From_Int | 14.21 ns | 0.0099 ns | 0.0077 ns |      - |       0 B |
                                     From_Int_AsObject | 25.08 ns | 0.0275 ns | 0.0244 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.08 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.04 ns | 0.0257 ns | 0.0241 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.47 ns | 0.0445 ns | 0.0416 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.15 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                                             From_Long | 14.49 ns | 0.0375 ns | 0.0332 ns |      - |       0 B |
                                    From_Long_AsObject | 24.28 ns | 0.0268 ns | 0.0238 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.90 ns | 0.0365 ns | 0.0342 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 25.31 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.32 ns | 0.0051 ns | 0.0042 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.17 ns | 0.0215 ns | 0.0190 ns |      - |       0 B |
                                            From_SByte | 13.04 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
                                   From_SByte_AsObject | 17.86 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 13.85 ns | 0.0039 ns | 0.0028 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 17.83 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.69 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.94 ns | 0.0089 ns | 0.0070 ns |      - |       0 B |
                                            From_Float | 16.61 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
                                   From_Float_AsObject | 26.62 ns | 0.0441 ns | 0.0412 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.15 ns | 0.0182 ns | 0.0152 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 26.60 ns | 0.0362 ns | 0.0282 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.67 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.10 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                           From_String | 89.94 ns | 0.0419 ns | 0.0327 ns |      - |       0 B |
                                  From_String_AsObject | 97.89 ns | 0.4440 ns | 0.3708 ns |      - |       0 B |
                                      From_String_Null | 15.06 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.10 ns | 0.0938 ns | 0.0878 ns |      - |       0 B |
                                     From_String_Empty | 16.45 ns | 0.0103 ns | 0.0092 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.67 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.61 ns | 0.0447 ns | 0.0418 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.45 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.56 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.45 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.97 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                                             From_UInt | 13.53 ns | 0.0396 ns | 0.0370 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.57 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.31 ns | 0.0376 ns | 0.0352 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 24.67 ns | 0.0309 ns | 0.0289 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.71 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.08 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                                            From_ULong | 13.51 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                   From_ULong_AsObject | 23.63 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.59 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.58 ns | 0.0378 ns | 0.0353 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.57 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.18 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                                       From_NullObject | 19.19 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
                                           From_DBNull | 14.84 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                                  From_DBNull_AsObject | 15.94 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
                                 From_ConvertibleClass | 21.81 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.97 ns | 0.0315 ns | 0.0294 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.18 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.96 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.63 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.16 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.54 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.17 ns | 0.0361 ns | 0.0337 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.21 ns | 0.0129 ns | 0.0120 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.25 ns | 0.0301 ns | 0.0282 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.43 ns | 0.0159 ns | 0.0133 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.25 ns | 0.0436 ns | 0.0386 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.17 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.19 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.04 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.21 ns | 0.0471 ns | 0.0393 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.91 ns | 0.0124 ns | 0.0109 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.17 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.91 ns | 0.0121 ns | 0.0094 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.17 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                                             From_Enum | 14.21 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                                    From_Enum_AsObject | 55.09 ns | 0.1141 ns | 0.1012 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.08 ns | 0.0107 ns | 0.0089 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 54.98 ns | 0.0590 ns | 0.0552 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.49 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.32 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
                                      From_ParentClass | 14.33 ns | 0.0103 ns | 0.0092 ns |      - |       0 B |
                             From_ParentClass_AsObject | 18.67 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.36 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.92 ns | 0.0320 ns | 0.0299 ns |      - |       0 B |
                                     From_ParentStruct | 14.51 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 19.71 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.98 ns | 0.0287 ns | 0.0268 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.68 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.01 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.81 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByte.From_String_Empty_AsObject: DefaultJob
