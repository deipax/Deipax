
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.74 ns | 0.0379 ns | 0.0354 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 18.90 ns | 0.0726 ns | 0.0644 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.99 ns | 0.0247 ns | 0.0219 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.99 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.40 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 14.50 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                                             From_Byte | 11.42 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 18.88 ns | 0.0900 ns | 0.0842 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.83 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 19.55 ns | 0.0366 ns | 0.0342 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.40 ns | 0.0047 ns | 0.0039 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 15.62 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                                             From_Char | 11.12 ns | 0.0036 ns | 0.0030 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.74 ns | 0.0714 ns | 0.0668 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.71 ns | 0.0490 ns | 0.0383 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.54 ns | 0.0443 ns | 0.0414 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.45 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.31 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.95 ns | 0.0178 ns | 0.0166 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.97 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.01 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.63 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
                                          From_Decimal | 29.12 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 27.97 ns | 0.0155 ns | 0.0137 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 24.35 ns | 0.0215 ns | 0.0202 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 30.65 ns | 0.0212 ns | 0.0198 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.15 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.29 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                                           From_Double | 14.51 ns | 0.0216 ns | 0.0192 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 20.47 ns | 0.0378 ns | 0.0354 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.77 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 22.87 ns | 0.0582 ns | 0.0516 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.99 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.01 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
                                            From_Short | 12.12 ns | 0.0208 ns | 0.0194 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 19.83 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.98 ns | 0.0890 ns | 0.0832 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 20.20 ns | 0.0201 ns | 0.0178 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.44 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 15.58 ns | 0.0059 ns | 0.0053 ns |           - |           - |           - |                   - |
                                              From_Int | 11.62 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 19.42 ns | 0.0431 ns | 0.0360 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.71 ns | 0.1674 ns | 0.1566 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.66 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.51 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 15.17 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
                                             From_Long | 11.92 ns | 0.0146 ns | 0.0130 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 20.18 ns | 0.0314 ns | 0.0294 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.34 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 19.63 ns | 0.0928 ns | 0.0868 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.09 ns | 0.0089 ns | 0.0078 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 15.11 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.10 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 20.68 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.79 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 18.26 ns | 0.0211 ns | 0.0197 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.41 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.23 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                                            From_Float | 14.82 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 22.62 ns | 0.0240 ns | 0.0225 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 14.65 ns | 0.0786 ns | 0.0735 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 22.74 ns | 0.0457 ns | 0.0428 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.49 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 15.03 ns | 0.0162 ns | 0.0152 ns |           - |           - |           - |                   - |
                                           From_String | 69.23 ns | 0.1191 ns | 0.1114 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 73.26 ns | 0.1748 ns | 0.1635 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.32 ns | 0.0317 ns | 0.0296 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 14.14 ns | 0.0055 ns | 0.0049 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.67 ns | 0.0205 ns | 0.0191 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.13 ns | 0.0091 ns | 0.0076 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 18.95 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.75 ns | 0.0680 ns | 0.0603 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.97 ns | 0.0440 ns | 0.0390 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.45 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 15.01 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.95 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 19.04 ns | 0.0467 ns | 0.0414 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.93 ns | 0.0050 ns | 0.0044 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.17 ns | 0.2166 ns | 0.2026 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.52 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 13.01 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.11 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 13.49 ns | 0.0110 ns | 0.0102 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.87 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 13.57 ns | 0.0345 ns | 0.0323 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.58 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.63 ns | 0.0076 ns | 0.0072 ns |           - |           - |           - |                   - |
                                       From_NullObject | 15.02 ns | 0.0130 ns | 0.0115 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.76 ns | 0.0321 ns | 0.0301 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.30 ns | 0.0062 ns | 0.0052 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 15.59 ns | 0.0285 ns | 0.0267 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.39 ns | 0.0535 ns | 0.0501 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 14.62 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.65 ns | 0.0095 ns | 0.0088 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.54 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.16 ns | 0.0399 ns | 0.0373 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.80 ns | 0.0078 ns | 0.0070 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.30 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.48 ns | 0.0178 ns | 0.0158 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 18.08 ns | 0.0385 ns | 0.0360 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 18.03 ns | 0.0206 ns | 0.0193 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 18.76 ns | 0.0643 ns | 0.0601 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.54 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.29 ns | 0.0097 ns | 0.0090 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.42 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.12 ns | 0.0678 ns | 0.0634 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.40 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.38 ns | 0.0825 ns | 0.0731 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.60 ns | 0.0128 ns | 0.0119 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.67 ns | 0.0057 ns | 0.0050 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.80 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 41.18 ns | 0.0336 ns | 0.0314 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.93 ns | 0.0526 ns | 0.0467 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 42.78 ns | 0.0547 ns | 0.0457 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.12 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.37 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.75 ns | 0.0065 ns | 0.0057 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.25 ns | 0.0318 ns | 0.0298 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.87 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.64 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 38.18 ns | 0.0276 ns | 0.0258 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 16.03 ns | 0.0453 ns | 0.0402 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 38.36 ns | 0.0380 ns | 0.0355 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.98 ns | 0.0186 ns | 0.0165 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.91 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.67 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULong.From_String_Empty_AsObject: DefaultJob
