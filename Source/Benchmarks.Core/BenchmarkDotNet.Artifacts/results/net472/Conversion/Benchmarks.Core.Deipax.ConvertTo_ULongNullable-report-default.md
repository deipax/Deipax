
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 13.58 ns | 0.0273 ns | 0.0255 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 21.63 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 14.54 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 22.50 ns | 0.0764 ns | 0.0715 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 13.39 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 15.80 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
                                             From_Byte | 13.38 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 19.81 ns | 0.0446 ns | 0.0418 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.95 ns | 0.0530 ns | 0.0495 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 22.70 ns | 0.0394 ns | 0.0308 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 15.46 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 16.36 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
                                             From_Char | 14.22 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 19.55 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 14.19 ns | 0.0259 ns | 0.0242 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 19.31 ns | 0.0267 ns | 0.0237 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 13.16 ns | 0.0385 ns | 0.0360 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 17.50 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
                                         From_DateTime | 14.93 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.78 ns | 0.0243 ns | 0.0215 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 15.50 ns | 0.0191 ns | 0.0170 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 16.47 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.07 ns | 0.0136 ns | 0.0121 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 29.03 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.57 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 30.40 ns | 0.0245 ns | 0.0230 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.70 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 15.51 ns | 0.0209 ns | 0.0196 ns |           - |           - |           - |                   - |
                                           From_Double | 17.66 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 24.50 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 17.85 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 25.46 ns | 0.0967 ns | 0.0904 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 14.18 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.40 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
                                            From_Short | 14.60 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 20.86 ns | 0.0344 ns | 0.0322 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 14.95 ns | 0.0399 ns | 0.0374 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 22.30 ns | 0.0218 ns | 0.0193 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.13 ns | 0.0075 ns | 0.0066 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 15.41 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
                                              From_Int | 15.37 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 22.23 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 14.90 ns | 0.0625 ns | 0.0584 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 20.76 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 13.13 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 14.01 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                                             From_Long | 15.85 ns | 0.0050 ns | 0.0042 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 22.36 ns | 0.1237 ns | 0.1157 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 15.19 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 23.40 ns | 0.0682 ns | 0.0605 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.97 ns | 0.0065 ns | 0.0058 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 15.52 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
                                            From_SByte | 14.53 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 21.07 ns | 0.0202 ns | 0.0179 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 15.09 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 22.52 ns | 0.0199 ns | 0.0176 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 14.03 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 16.44 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
                                            From_Float | 17.01 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 26.06 ns | 0.0322 ns | 0.0285 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 17.02 ns | 0.0147 ns | 0.0123 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 28.38 ns | 0.0562 ns | 0.0525 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 15.21 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 16.38 ns | 0.0207 ns | 0.0193 ns |           - |           - |           - |                   - |
                                           From_String | 70.45 ns | 0.1603 ns | 0.1499 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 75.90 ns | 0.1999 ns | 0.1870 ns |           - |           - |           - |                   - |
                                      From_String_Null | 16.28 ns | 0.0268 ns | 0.0250 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 15.54 ns | 0.0285 ns | 0.0253 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.82 ns | 0.0163 ns | 0.0152 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 13.36 ns | 0.0306 ns | 0.0286 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 21.81 ns | 0.0295 ns | 0.0262 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.70 ns | 0.0621 ns | 0.0581 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 21.80 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 13.13 ns | 0.0287 ns | 0.0268 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 15.51 ns | 0.0195 ns | 0.0183 ns |           - |           - |           - |                   - |
                                             From_UInt | 14.25 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 21.77 ns | 0.0301 ns | 0.0281 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.59 ns | 0.0398 ns | 0.0332 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 21.84 ns | 0.0277 ns | 0.0231 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 13.77 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.02 ns | 0.0206 ns | 0.0183 ns |           - |           - |           - |                   - |
                                            From_ULong | 13.04 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 34.15 ns | 0.0200 ns | 0.0156 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.53 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 32.95 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.54 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 16.49 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
                                       From_NullObject | 15.78 ns | 0.0096 ns | 0.0080 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.97 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.06 ns | 0.0061 ns | 0.0051 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 18.85 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 18.30 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.98 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.02 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 15.85 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 17.72 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 14.84 ns | 0.0642 ns | 0.0600 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.05 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 21.67 ns | 0.0350 ns | 0.0328 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 18.97 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 20.35 ns | 0.0248 ns | 0.0220 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 20.94 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 13.43 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.35 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 13.29 ns | 0.0321 ns | 0.0300 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 17.89 ns | 0.0211 ns | 0.0187 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.27 ns | 0.0160 ns | 0.0133 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.49 ns | 0.0387 ns | 0.0323 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 15.00 ns | 0.2867 ns | 0.2816 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.98 ns | 0.0952 ns | 0.0844 ns |           - |           - |           - |                   - |
                                             From_Enum | 16.59 ns | 0.1647 ns | 0.1540 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 49.85 ns | 0.3442 ns | 0.3220 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 15.42 ns | 0.0890 ns | 0.0743 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 51.25 ns | 0.3839 ns | 0.3403 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 16.72 ns | 0.1223 ns | 0.1144 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 16.48 ns | 0.0926 ns | 0.0773 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 14.70 ns | 0.1084 ns | 0.1014 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.62 ns | 0.0321 ns | 0.0268 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.61 ns | 0.1416 ns | 0.1325 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 14.15 ns | 0.1478 ns | 0.1383 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.51 ns | 0.5080 ns | 0.4752 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 18.19 ns | 0.1297 ns | 0.1213 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 40.01 ns | 0.4172 ns | 0.3902 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.13 ns | 0.2518 ns | 0.2232 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 45.36 ns | 0.5425 ns | 0.5074 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.57 ns | 0.1041 ns | 0.0869 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_String_Empty_AsObject: DefaultJob
