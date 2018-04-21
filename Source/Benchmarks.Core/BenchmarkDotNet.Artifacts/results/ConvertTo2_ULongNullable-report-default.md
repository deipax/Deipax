
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 15.67 ns | 0.0817 ns | 0.0764 ns |      - |       0 B |
                                    From_Bool_AsObject | 27.77 ns | 0.0246 ns | 0.0192 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 16.12 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 26.79 ns | 0.0477 ns | 0.0447 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 15.34 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 18.79 ns | 0.0323 ns | 0.0252 ns |      - |       0 B |
                                             From_Byte | 15.32 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
                                    From_Byte_AsObject | 26.83 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 16.43 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 27.79 ns | 0.0427 ns | 0.0379 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.33 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 19.97 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                                             From_Char | 15.32 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                                    From_Char_AsObject | 27.63 ns | 0.0577 ns | 0.0540 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 16.04 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 27.64 ns | 0.0622 ns | 0.0582 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 15.36 ns | 0.0322 ns | 0.0301 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 20.30 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                                         From_DateTime | 15.38 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 15.09 ns | 0.0133 ns | 0.0111 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.82 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 18.14 ns | 0.0323 ns | 0.0303 ns |      - |       0 B |
                                          From_Decimal | 24.73 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.63 ns | 0.0704 ns | 0.0550 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 27.92 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.67 ns | 0.1303 ns | 0.1155 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 16.06 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 20.01 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                                           From_Double | 18.38 ns | 0.0099 ns | 0.0082 ns |      - |       0 B |
                                  From_Double_AsObject | 31.93 ns | 0.0478 ns | 0.0447 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 18.94 ns | 0.0378 ns | 0.0354 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 30.86 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.66 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.68 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
                                            From_Short | 16.10 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                                   From_Short_AsObject | 27.34 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 16.38 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 28.52 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.40 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.50 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                                              From_Int | 16.09 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
                                     From_Int_AsObject | 27.28 ns | 0.0156 ns | 0.0130 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 16.36 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 28.32 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 17.32 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.71 ns | 0.0209 ns | 0.0186 ns |      - |       0 B |
                                             From_Long | 16.11 ns | 0.0454 ns | 0.0424 ns |      - |       0 B |
                                    From_Long_AsObject | 27.34 ns | 0.0196 ns | 0.0184 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.37 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 27.37 ns | 0.0379 ns | 0.0355 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.80 ns | 0.0185 ns | 0.0145 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.85 ns | 0.0230 ns | 0.0192 ns |      - |       0 B |
                                            From_SByte | 16.09 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                                   From_SByte_AsObject | 27.38 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 16.37 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 28.29 ns | 0.0507 ns | 0.0475 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.42 ns | 0.0443 ns | 0.0414 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 21.85 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                                            From_Float | 18.91 ns | 0.0252 ns | 0.0224 ns |      - |       0 B |
                                   From_Float_AsObject | 31.82 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 20.84 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 31.84 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 15.79 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.59 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                                           From_String | 89.52 ns | 0.0324 ns | 0.0253 ns |      - |       0 B |
                                  From_String_AsObject | 98.75 ns | 0.1114 ns | 0.1042 ns |      - |       0 B |
                                      From_String_Null | 17.16 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.63 ns | 0.0089 ns | 0.0070 ns |      - |       0 B |
                                     From_String_Empty | 17.37 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 16.00 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
                                  From_UShort_AsObject | 26.82 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 15.60 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 26.90 ns | 0.0333 ns | 0.0278 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 15.75 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.70 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                                             From_UInt | 15.34 ns | 0.0393 ns | 0.0367 ns |      - |       0 B |
                                    From_UInt_AsObject | 26.91 ns | 0.0304 ns | 0.0237 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.59 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 26.81 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 15.34 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 18.87 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                                            From_ULong | 15.35 ns | 0.0273 ns | 0.0256 ns |      - |       0 B |
                                   From_ULong_AsObject | 30.01 ns | 0.0444 ns | 0.0393 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.60 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 30.98 ns | 0.0552 ns | 0.0431 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.68 ns | 0.0425 ns | 0.0377 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 18.85 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                                       From_NullObject | 18.36 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                                           From_DBNull | 16.40 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                                  From_DBNull_AsObject | 19.03 ns | 0.0269 ns | 0.0252 ns |      - |       0 B |
                                 From_ConvertibleClass | 22.29 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 25.33 ns | 0.0362 ns | 0.0338 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 20.48 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 19.27 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.74 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 20.81 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.91 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.63 ns | 0.0060 ns | 0.0054 ns |      - |       0 B |
                                From_ConvertibleStruct | 24.32 ns | 0.0122 ns | 0.0095 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.60 ns | 0.0391 ns | 0.0366 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 24.76 ns | 0.0428 ns | 0.0400 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.58 ns | 0.0290 ns | 0.0272 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 15.73 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.68 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |
                             From_NonConvertibleStruct | 15.86 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.70 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.87 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.24 ns | 0.0054 ns | 0.0042 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 15.88 ns | 0.0349 ns | 0.0327 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.56 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
                                             From_Enum | 16.11 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                    From_Enum_AsObject | 59.30 ns | 0.1026 ns | 0.0959 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 16.36 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 58.35 ns | 0.0368 ns | 0.0326 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 16.45 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.80 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
                                      From_ParentClass | 15.83 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.24 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.09 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.85 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                                     From_ParentStruct | 15.89 ns | 0.0302 ns | 0.0283 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 21.79 ns | 0.0293 ns | 0.0260 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 15.90 ns | 0.0469 ns | 0.0439 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 21.20 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.86 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.22 ns | 0.0361 ns | 0.0338 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_String_Empty_AsObject: DefaultJob
