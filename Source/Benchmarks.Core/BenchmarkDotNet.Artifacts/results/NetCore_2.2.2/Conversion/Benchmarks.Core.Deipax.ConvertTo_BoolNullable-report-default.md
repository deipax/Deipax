
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.573 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 25.225 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.117 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 25.635 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.713 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.860 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.310 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.154 ns | 0.0090 ns | 0.0075 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.570 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.361 ns | 0.0207 ns | 0.0184 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.183 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.846 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
                                             From_Char | 10.060 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.498 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.970 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.057 ns | 0.0068 ns | 0.0056 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.051 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.136 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.751 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.324 ns | 0.0068 ns | 0.0063 ns |           - |           - |           - |                   - |
                                          From_Decimal | 20.010 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 23.236 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.567 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 23.325 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.329 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 13.588 ns | 0.0084 ns | 0.0075 ns |           - |           - |           - |                   - |
                                           From_Double | 10.784 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 17.477 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 11.359 ns | 0.0101 ns | 0.0089 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.299 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.968 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.062 ns | 0.0074 ns | 0.0066 ns |           - |           - |           - |                   - |
                                            From_Short | 10.299 ns | 0.0034 ns | 0.0031 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 18.393 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.037 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.533 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.714 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.045 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
                                              From_Int | 10.295 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.161 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.558 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.178 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.720 ns | 0.0102 ns | 0.0085 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.821 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
                                             From_Long | 11.009 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.658 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.865 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.199 ns | 0.0146 ns | 0.0129 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.172 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.823 ns | 0.0144 ns | 0.0134 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.770 ns | 0.0068 ns | 0.0063 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 17.154 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.053 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.194 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.657 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.816 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                            From_Float | 10.789 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 18.064 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.228 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.337 ns | 0.0163 ns | 0.0152 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.227 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.217 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                                           From_String | 32.298 ns | 0.0270 ns | 0.0252 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 38.024 ns | 0.0813 ns | 0.0761 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.575 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.834 ns | 0.0074 ns | 0.0066 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.150 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.313 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.147 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.554 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.597 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.965 ns | 0.0056 ns | 0.0053 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.241 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.314 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.491 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.070 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.190 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.661 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.836 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.769 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.181 ns | 0.0179 ns | 0.0168 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.461 ns | 0.0072 ns | 0.0068 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.198 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.168 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.805 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.823 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.226 ns | 0.0064 ns | 0.0053 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 13.690 ns | 0.0053 ns | 0.0047 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.411 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.698 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.962 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.807 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.135 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 16.255 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.120 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.844 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.461 ns | 0.0287 ns | 0.0268 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.920 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 16.084 ns | 0.0183 ns | 0.0171 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.931 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.889 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.584 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.161 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.940 ns | 0.0084 ns | 0.0070 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.361 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.650 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.316 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.475 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.785 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 45.383 ns | 0.0507 ns | 0.0449 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.889 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 45.335 ns | 0.0448 ns | 0.0397 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.188 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.808 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.138 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.108 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.144 ns | 0.0059 ns | 0.0056 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.809 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 40.254 ns | 0.0268 ns | 0.0251 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.608 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 41.595 ns | 0.0223 ns | 0.0208 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.101 ns | 0.0072 ns | 0.0068 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.656 ns | 0.0303 ns | 0.0284 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.805 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_String_Empty_AsObject: DefaultJob
