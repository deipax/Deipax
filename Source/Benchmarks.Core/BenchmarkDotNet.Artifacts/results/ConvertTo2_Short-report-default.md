
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.85 ns | 0.1191 ns | 0.1056 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.58 ns | 0.0272 ns | 0.0213 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.48 ns | 0.0136 ns | 0.0114 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.58 ns | 0.0101 ns | 0.0085 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.69 ns | 0.0506 ns | 0.0473 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.28 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                                             From_Byte |  14.13 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.57 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.85 ns | 0.0480 ns | 0.0449 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.69 ns | 0.0627 ns | 0.0586 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.95 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.31 ns | 0.0136 ns | 0.0106 ns |      - |       0 B |
                                             From_Char |  14.43 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                                    From_Char_AsObject |  27.06 ns | 0.0700 ns | 0.0655 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.05 ns | 0.0467 ns | 0.0437 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.00 ns | 0.0162 ns | 0.0143 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.97 ns | 0.0683 ns | 0.0605 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.27 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                         From_DateTime |  14.62 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.83 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.83 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.34 ns | 0.0564 ns | 0.0527 ns |      - |       0 B |
                                          From_Decimal |  26.11 ns | 0.0519 ns | 0.0485 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.93 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  36.27 ns | 0.0433 ns | 0.0405 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.25 ns | 0.1278 ns | 0.1196 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.15 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.09 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                                           From_Double |  18.33 ns | 0.0293 ns | 0.0260 ns |      - |       0 B |
                                  From_Double_AsObject |  29.76 ns | 0.0414 ns | 0.0345 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.34 ns | 0.0175 ns | 0.0137 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.69 ns | 0.0537 ns | 0.0449 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.89 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.37 ns | 0.0612 ns | 0.0572 ns |      - |       0 B |
                                            From_Short |  14.17 ns | 0.0315 ns | 0.0294 ns |      - |       0 B |
                                   From_Short_AsObject |  17.91 ns | 0.0118 ns | 0.0078 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.44 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  17.97 ns | 0.0237 ns | 0.0198 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.45 ns | 0.0465 ns | 0.0435 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.39 ns | 0.0096 ns | 0.0081 ns |      - |       0 B |
                                              From_Int |  15.32 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
                                     From_Int_AsObject |  27.02 ns | 0.0815 ns | 0.0762 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.58 ns | 0.0342 ns | 0.0319 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.99 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.70 ns | 0.0100 ns | 0.0072 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.37 ns | 0.0408 ns | 0.0362 ns |      - |       0 B |
                                             From_Long |  15.51 ns | 0.0251 ns | 0.0234 ns |      - |       0 B |
                                    From_Long_AsObject |  26.99 ns | 0.0478 ns | 0.0447 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.39 ns | 0.0228 ns | 0.0214 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.07 ns | 0.0518 ns | 0.0459 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.88 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.80 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                                            From_SByte |  14.15 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.69 ns | 0.0660 ns | 0.0617 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.85 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.64 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.93 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.25 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                            From_Float |  18.30 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
                                   From_Float_AsObject |  29.99 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.05 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.60 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.93 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.27 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                           From_String |  94.13 ns | 0.0473 ns | 0.0442 ns |      - |       0 B |
                                  From_String_AsObject | 104.07 ns | 0.0730 ns | 0.0610 ns |      - |       0 B |
                                      From_String_Null |  15.40 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.85 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                     From_String_Empty |  16.26 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.79 ns | 0.0387 ns | 0.0362 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.16 ns | 0.0549 ns | 0.0514 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.20 ns | 0.0323 ns | 0.0302 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.21 ns | 0.0210 ns | 0.0164 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.76 ns | 0.0133 ns | 0.0104 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.30 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                             From_UInt |  14.84 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.96 ns | 0.0384 ns | 0.0341 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.63 ns | 0.0560 ns | 0.0524 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.96 ns | 0.0247 ns | 0.0206 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.96 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.34 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                            From_ULong |  14.90 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.96 ns | 0.0332 ns | 0.0295 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.41 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.94 ns | 0.0255 ns | 0.0213 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.97 ns | 0.0237 ns | 0.0185 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.27 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                                       From_NullObject |  17.32 ns | 0.0185 ns | 0.0155 ns |      - |       0 B |
                                           From_DBNull |  15.15 ns | 0.0219 ns | 0.0195 ns |      - |       0 B |
                                 From_ConvertibleClass |  23.98 ns | 0.0314 ns | 0.0294 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.48 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.88 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.39 ns | 0.0531 ns | 0.0497 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.91 ns | 0.0242 ns | 0.0202 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.65 ns | 0.0106 ns | 0.0083 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.91 ns | 0.0199 ns | 0.0176 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.15 ns | 0.0172 ns | 0.0134 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.63 ns | 0.0159 ns | 0.0141 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.76 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.90 ns | 0.0180 ns | 0.0159 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.75 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.97 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.25 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.15 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.25 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.88 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.57 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.88 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.81 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                                             From_Enum |  15.28 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.33 ns | 0.0129 ns | 0.0121 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.09 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.49 ns | 0.0084 ns | 0.0074 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.66 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.26 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
                                      From_ParentClass |  15.90 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.12 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.93 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.27 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                     From_ParentStruct |  14.53 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.13 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.87 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.09 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.87 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Short.From_String_Empty_AsObject: DefaultJob
