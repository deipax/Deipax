
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.968 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.082 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.410 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.145 ns | 0.0171 ns | 0.0160 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.665 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.762 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.096 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.105 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.292 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.859 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.178 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.760 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                                             From_Char | 10.271 ns | 0.0222 ns | 0.0196 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.058 ns | 0.0196 ns | 0.0183 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.404 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.033 ns | 0.0247 ns | 0.0231 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.183 ns | 0.0067 ns | 0.0060 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.777 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.653 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.100 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.852 ns | 0.0066 ns | 0.0058 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.760 ns | 0.0050 ns | 0.0045 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.757 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 26.804 ns | 0.0272 ns | 0.0254 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.862 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 25.023 ns | 0.0269 ns | 0.0239 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.585 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.760 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                                           From_Double | 12.581 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 16.985 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.145 ns | 0.0173 ns | 0.0161 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.749 ns | 0.0241 ns | 0.0226 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.241 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.758 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
                                            From_Short | 10.083 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 12.353 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.335 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 12.450 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.206 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.841 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                                              From_Int | 11.882 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.544 ns | 0.0067 ns | 0.0060 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.370 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.786 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.155 ns | 0.0058 ns | 0.0051 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.759 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
                                             From_Long | 11.170 ns | 0.0395 ns | 0.0369 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 16.224 ns | 0.0166 ns | 0.0147 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.260 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.025 ns | 0.0162 ns | 0.0151 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.171 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.762 ns | 0.0067 ns | 0.0059 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.291 ns | 0.0247 ns | 0.0231 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.088 ns | 0.0083 ns | 0.0074 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.264 ns | 0.0194 ns | 0.0182 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.860 ns | 0.0091 ns | 0.0076 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.155 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.966 ns | 0.0050 ns | 0.0044 ns |           - |           - |           - |                   - |
                                            From_Float | 11.903 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 17.690 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.781 ns | 0.0158 ns | 0.0140 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.544 ns | 0.0405 ns | 0.0359 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.166 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.773 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
                                           From_String | 52.640 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 92.981 ns | 0.3201 ns | 0.2994 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.190 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.760 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.001 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.260 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.149 ns | 0.0102 ns | 0.0091 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.409 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.080 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.171 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.759 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.809 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.778 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.396 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.571 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.157 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.765 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.460 ns | 0.0046 ns | 0.0041 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.848 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.257 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.851 ns | 0.0177 ns | 0.0147 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.119 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.763 ns | 0.0073 ns | 0.0064 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.782 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.028 ns | 0.0045 ns | 0.0038 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.788 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 12.713 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.539 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.264 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.785 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.844 ns | 0.0054 ns | 0.0048 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.149 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.008 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.762 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.864 ns | 0.0156 ns | 0.0146 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.621 ns | 0.0092 ns | 0.0077 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.675 ns | 0.0340 ns | 0.0318 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.645 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.019 ns | 0.0101 ns | 0.0090 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.092 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.425 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.166 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.092 ns | 0.0066 ns | 0.0061 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.143 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.976 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.834 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.875 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 38.587 ns | 0.0376 ns | 0.0333 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.350 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 38.580 ns | 0.0424 ns | 0.0396 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.263 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.756 ns | 0.0064 ns | 0.0054 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.267 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.410 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.276 ns | 0.0053 ns | 0.0045 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.767 ns | 0.0062 ns | 0.0049 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.756 ns | 0.0670 ns | 0.0627 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.412 ns | 0.0092 ns | 0.0081 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.560 ns | 0.0230 ns | 0.0215 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 14.139 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 35.095 ns | 0.0280 ns | 0.0261 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.760 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Short.From_String_Empty_AsObject: DefaultJob
