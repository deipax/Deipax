
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.675 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.063 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.407 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 16.635 ns | 0.0162 ns | 0.0152 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.217 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.759 ns | 0.0033 ns | 0.0029 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.316 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.318 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.486 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 15.591 ns | 0.0173 ns | 0.0153 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.204 ns | 0.0065 ns | 0.0058 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.781 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                                             From_Char | 10.302 ns | 0.0193 ns | 0.0180 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.066 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.444 ns | 0.0136 ns | 0.0121 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.047 ns | 0.0189 ns | 0.0176 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.207 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.792 ns | 0.0046 ns | 0.0038 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.883 ns | 0.0057 ns | 0.0048 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.134 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.126 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.892 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.448 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.316 ns | 0.0134 ns | 0.0112 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 22.947 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 26.469 ns | 0.0296 ns | 0.0277 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.241 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.785 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
                                           From_Double | 12.198 ns | 0.0196 ns | 0.0174 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 16.969 ns | 0.0161 ns | 0.0150 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.792 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.772 ns | 0.0285 ns | 0.0267 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.286 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.758 ns | 0.0074 ns | 0.0062 ns |           - |           - |           - |                   - |
                                            From_Short | 10.458 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.045 ns | 0.0351 ns | 0.0311 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.420 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.082 ns | 0.0264 ns | 0.0234 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.194 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.077 ns | 0.0076 ns | 0.0072 ns |           - |           - |           - |                   - |
                                              From_Int | 10.884 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.585 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.409 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.809 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.192 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.742 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
                                             From_Long | 10.914 ns | 0.0158 ns | 0.0147 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.800 ns | 0.0297 ns | 0.0278 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.081 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.847 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.155 ns | 0.0065 ns | 0.0060 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.513 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.498 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 12.375 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.360 ns | 0.0346 ns | 0.0324 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 12.377 ns | 0.0105 ns | 0.0093 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.204 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.977 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                                            From_Float | 11.884 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 17.274 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.824 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.258 ns | 0.0207 ns | 0.0193 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.208 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.971 ns | 0.0078 ns | 0.0065 ns |           - |           - |           - |                   - |
                                           From_String | 89.083 ns | 0.1988 ns | 0.1859 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 58.718 ns | 0.0415 ns | 0.0388 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.032 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.912 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.658 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.776 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.080 ns | 0.0164 ns | 0.0145 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.428 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.119 ns | 0.0135 ns | 0.0127 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.213 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.513 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.272 ns | 0.0265 ns | 0.0221 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.924 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.407 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.378 ns | 0.0342 ns | 0.0320 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.205 ns | 0.0065 ns | 0.0060 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.764 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.271 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.384 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.343 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.316 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.277 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.764 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.759 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.732 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.774 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.162 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.143 ns | 0.0071 ns | 0.0059 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.595 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.760 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.259 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.145 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.259 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.763 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.299 ns | 0.0156 ns | 0.0146 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.623 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.737 ns | 0.0230 ns | 0.0204 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.630 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.663 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.777 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.422 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.954 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.514 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.351 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.492 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.793 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.869 ns | 0.0051 ns | 0.0045 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.357 ns | 0.0506 ns | 0.0473 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.371 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 38.852 ns | 0.0706 ns | 0.0626 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.157 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.790 ns | 0.0085 ns | 0.0075 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.300 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.377 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.260 ns | 0.0082 ns | 0.0069 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.792 ns | 0.0097 ns | 0.0090 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 41.324 ns | 0.0357 ns | 0.0334 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.396 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.561 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.473 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.506 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.760 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByte.From_String_Empty_AsObject: DefaultJob
