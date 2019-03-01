
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 13.66 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 19.69 ns | 0.0175 ns | 0.0155 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 14.39 ns | 0.0255 ns | 0.0239 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 19.61 ns | 0.0181 ns | 0.0160 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 13.22 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 16.82 ns | 0.0165 ns | 0.0154 ns |           - |           - |           - |                   - |
                                             From_Byte | 13.42 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 21.73 ns | 0.0308 ns | 0.0257 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.69 ns | 0.0840 ns | 0.0786 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 19.95 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 13.20 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 18.45 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
                                             From_Char | 13.43 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 21.65 ns | 0.0278 ns | 0.0232 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 13.89 ns | 0.1044 ns | 0.0976 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 19.33 ns | 0.0274 ns | 0.0257 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 13.25 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.04 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.41 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.79 ns | 0.0094 ns | 0.0078 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.72 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 16.94 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
                                          From_Decimal | 25.19 ns | 0.0233 ns | 0.0194 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 30.81 ns | 0.0407 ns | 0.0361 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.62 ns | 0.0086 ns | 0.0076 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 30.63 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.72 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.08 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                                           From_Double | 17.00 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 25.43 ns | 0.0701 ns | 0.0655 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 17.46 ns | 0.0151 ns | 0.0134 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 24.03 ns | 0.0149 ns | 0.0132 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 14.10 ns | 0.0158 ns | 0.0147 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 16.38 ns | 0.0241 ns | 0.0225 ns |           - |           - |           - |                   - |
                                            From_Short | 13.39 ns | 0.0119 ns | 0.0099 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 21.99 ns | 0.0339 ns | 0.0317 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 14.33 ns | 0.0253 ns | 0.0236 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 19.94 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.24 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 16.39 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
                                              From_Int | 13.41 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 20.16 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.82 ns | 0.1005 ns | 0.0940 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 22.17 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 13.28 ns | 0.0105 ns | 0.0093 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 15.74 ns | 0.0101 ns | 0.0090 ns |           - |           - |           - |                   - |
                                             From_Long | 13.06 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 31.83 ns | 0.0311 ns | 0.0291 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.55 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 33.65 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 15.76 ns | 0.0126 ns | 0.0112 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 16.54 ns | 0.0165 ns | 0.0155 ns |           - |           - |           - |                   - |
                                            From_SByte | 13.39 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 21.83 ns | 0.0416 ns | 0.0389 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 13.68 ns | 0.0215 ns | 0.0201 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 20.03 ns | 0.0488 ns | 0.0457 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 13.21 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 17.36 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                                            From_Float | 17.08 ns | 0.0354 ns | 0.0332 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 23.10 ns | 0.0315 ns | 0.0295 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 17.15 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 24.60 ns | 0.0688 ns | 0.0610 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.34 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 14.22 ns | 0.0050 ns | 0.0042 ns |           - |           - |           - |                   - |
                                           From_String | 70.23 ns | 0.0694 ns | 0.0650 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 72.97 ns | 0.1061 ns | 0.0993 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.30 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 14.09 ns | 0.0207 ns | 0.0173 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.94 ns | 0.0299 ns | 0.0279 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 13.42 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 21.79 ns | 0.0887 ns | 0.0787 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 14.31 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 21.79 ns | 0.0607 ns | 0.0568 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 13.23 ns | 0.0133 ns | 0.0111 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.82 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                                             From_UInt | 15.72 ns | 0.0095 ns | 0.0074 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 19.99 ns | 0.0182 ns | 0.0152 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.87 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 22.65 ns | 0.0176 ns | 0.0137 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 13.27 ns | 0.0380 ns | 0.0355 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 15.40 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
                                            From_ULong | 17.92 ns | 0.0109 ns | 0.0096 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 23.55 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 15.25 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 23.18 ns | 0.0236 ns | 0.0197 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 14.53 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 15.39 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
                                       From_NullObject | 16.09 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.96 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 16.48 ns | 0.0174 ns | 0.0162 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 17.20 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 20.05 ns | 0.0201 ns | 0.0157 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 14.71 ns | 0.0173 ns | 0.0153 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.11 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.37 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 17.76 ns | 0.0256 ns | 0.0240 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.69 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 16.24 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 20.62 ns | 0.0091 ns | 0.0080 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 20.75 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 20.31 ns | 0.0160 ns | 0.0142 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 20.76 ns | 0.0116 ns | 0.0097 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 13.86 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.03 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 13.24 ns | 0.0333 ns | 0.0311 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 16.25 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.33 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 17.65 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 13.26 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 14.01 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.71 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 47.82 ns | 0.0537 ns | 0.0502 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.94 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 48.70 ns | 0.2538 ns | 0.2374 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 14.15 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 16.37 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 14.88 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.23 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.83 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 17.74 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.40 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 16.98 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 45.37 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.93 ns | 0.0615 ns | 0.0545 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 39.45 ns | 0.0377 ns | 0.0353 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.64 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_LongNullable.From_String_Empty_AsObject: DefaultJob
