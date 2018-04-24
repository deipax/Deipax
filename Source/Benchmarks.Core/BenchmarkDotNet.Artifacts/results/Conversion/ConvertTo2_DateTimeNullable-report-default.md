
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.08 ns | 0.1163 ns | 0.1088 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  15.33 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  15.34 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  19.96 ns | 0.0227 ns | 0.0201 ns |      - |       0 B |
                                             From_Byte |  15.36 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  15.36 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  16.19 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.10 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                                             From_Char |  15.35 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.33 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.52 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.92 ns | 0.0303 ns | 0.0283 ns |      - |       0 B |
                                         From_DateTime |  15.81 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                                From_DateTime_AsObject |  34.72 ns | 0.4002 ns | 0.3743 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  15.81 ns | 0.1783 ns | 0.1580 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  31.86 ns | 0.0603 ns | 0.0564 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  15.60 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.01 ns | 0.0370 ns | 0.0346 ns |      - |       0 B |
                                          From_Decimal |  15.63 ns | 0.0376 ns | 0.0333 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  16.64 ns | 0.0292 ns | 0.0273 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  16.65 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.53 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                           From_Double |  15.41 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  15.63 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  15.66 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  20.57 ns | 0.0321 ns | 0.0300 ns |      - |       0 B |
                                            From_Short |  15.38 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  15.39 ns | 0.0071 ns | 0.0047 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  15.37 ns | 0.0034 ns | 0.0025 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  19.38 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                                              From_Int |  15.41 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  15.36 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  15.37 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  20.50 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                                             From_Long |  15.38 ns | 0.0056 ns | 0.0037 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  15.66 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  15.60 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  20.93 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                            From_SByte |  15.41 ns | 0.0370 ns | 0.0346 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  15.36 ns | 0.0072 ns | 0.0056 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  15.38 ns | 0.0255 ns | 0.0226 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  20.60 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
                                            From_Float |  17.17 ns | 0.0228 ns | 0.0190 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  15.40 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  16.25 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  19.93 ns | 0.0436 ns | 0.0407 ns |      - |       0 B |
                                           From_String | 822.95 ns | 0.7476 ns | 0.6243 ns |      - |       0 B |
                                  From_String_AsObject | 892.98 ns | 1.1172 ns | 1.0450 ns |      - |       0 B |
                                      From_String_Null |  18.36 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.93 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
                                     From_String_Empty |  18.19 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  15.37 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  15.35 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  15.34 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  19.72 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                                             From_UInt |  15.35 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  15.36 ns | 0.0364 ns | 0.0340 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  15.35 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  21.09 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                                            From_ULong |  15.36 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  15.58 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  15.61 ns | 0.0429 ns | 0.0401 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.81 ns | 0.0105 ns | 0.0087 ns |      - |       0 B |
                                       From_NullObject |  20.23 ns | 0.0381 ns | 0.0338 ns |      - |       0 B |
                                           From_DBNull |  16.89 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                                  From_DBNull_AsObject |  20.52 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                                 From_ConvertibleClass |  23.35 ns | 0.0383 ns | 0.0358 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.42 ns | 0.0328 ns | 0.0307 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.58 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  21.34 ns | 0.0360 ns | 0.0336 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.35 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  22.55 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.38 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  20.50 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.56 ns | 0.0268 ns | 0.0251 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.44 ns | 0.0467 ns | 0.0437 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  25.60 ns | 0.0343 ns | 0.0320 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.42 ns | 0.0212 ns | 0.0177 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.26 ns | 0.0120 ns | 0.0107 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  19.35 ns | 0.0073 ns | 0.0057 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.35 ns | 0.0328 ns | 0.0291 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.55 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.36 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.35 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.34 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  21.65 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                                             From_Enum |  15.62 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  15.35 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  15.36 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.10 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
                                      From_ParentClass |  16.36 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.06 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.46 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  19.41 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
                                     From_ParentStruct |  15.36 ns | 0.0578 ns | 0.0482 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.11 ns | 0.0266 ns | 0.0235 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.27 ns | 0.0220 ns | 0.0205 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.09 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.33 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.37 ns | 0.0304 ns | 0.0285 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
