
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.290 ns | 0.0286 ns | 0.0267 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 12.716 ns | 0.0446 ns | 0.0395 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.931 ns | 0.0394 ns | 0.0349 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 12.659 ns | 0.0425 ns | 0.0355 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.350 ns | 0.0920 ns | 0.0718 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.145 ns | 0.0365 ns | 0.0285 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.427 ns | 0.1357 ns | 0.1270 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.544 ns | 0.0352 ns | 0.0294 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.961 ns | 0.0269 ns | 0.0252 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 15.234 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.065 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.434 ns | 0.0489 ns | 0.0457 ns |           - |           - |           - |                   - |
                                             From_Char | 11.735 ns | 0.0438 ns | 0.0388 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.777 ns | 0.0275 ns | 0.0230 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.309 ns | 0.0624 ns | 0.0584 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.076 ns | 0.0335 ns | 0.0297 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.656 ns | 0.1492 ns | 0.1246 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.501 ns | 0.0671 ns | 0.0595 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.905 ns | 0.0110 ns | 0.0092 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.005 ns | 0.0255 ns | 0.0226 ns |           - |           - |           - |                   - |
                                          From_Decimal | 20.793 ns | 0.3284 ns | 0.2743 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 21.414 ns | 0.1824 ns | 0.1617 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.500 ns | 0.0863 ns | 0.0765 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 21.046 ns | 0.0911 ns | 0.0807 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.960 ns | 0.0228 ns | 0.0202 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.121 ns | 0.1355 ns | 0.1201 ns |           - |           - |           - |                   - |
                                           From_Double | 11.148 ns | 0.1251 ns | 0.1045 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 15.409 ns | 0.0316 ns | 0.0296 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.719 ns | 0.0618 ns | 0.0547 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.200 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.465 ns | 0.0237 ns | 0.0198 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.137 ns | 0.0169 ns | 0.0132 ns |           - |           - |           - |                   - |
                                            From_Short | 10.381 ns | 0.1964 ns | 0.1741 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.644 ns | 0.1620 ns | 0.1436 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.438 ns | 0.0341 ns | 0.0285 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.331 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.244 ns | 0.0483 ns | 0.0452 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.547 ns | 0.0311 ns | 0.0276 ns |           - |           - |           - |                   - |
                                              From_Int | 10.142 ns | 0.0169 ns | 0.0141 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.712 ns | 0.0218 ns | 0.0194 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.318 ns | 0.0097 ns | 0.0075 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.184 ns | 0.0880 ns | 0.0823 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.187 ns | 0.0159 ns | 0.0141 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.783 ns | 0.0387 ns | 0.0343 ns |           - |           - |           - |                   - |
                                             From_Long | 10.118 ns | 0.0183 ns | 0.0153 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.118 ns | 0.0241 ns | 0.0201 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.423 ns | 0.0230 ns | 0.0192 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.156 ns | 0.0974 ns | 0.0911 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.265 ns | 0.0293 ns | 0.0260 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.051 ns | 0.0583 ns | 0.0516 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.169 ns | 0.1798 ns | 0.1682 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.358 ns | 0.0734 ns | 0.0613 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.338 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.183 ns | 0.1287 ns | 0.1203 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.295 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.811 ns | 0.0266 ns | 0.0208 ns |           - |           - |           - |                   - |
                                            From_Float | 10.286 ns | 0.0166 ns | 0.0147 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 15.096 ns | 0.0078 ns | 0.0061 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 10.531 ns | 0.0616 ns | 0.0546 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 15.607 ns | 0.0840 ns | 0.0745 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.192 ns | 0.0148 ns | 0.0116 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.823 ns | 0.0470 ns | 0.0416 ns |           - |           - |           - |                   - |
                                           From_String | 31.050 ns | 0.0785 ns | 0.0696 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 37.656 ns | 0.2810 ns | 0.2491 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.502 ns | 0.0190 ns | 0.0177 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.745 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 11.594 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.063 ns | 0.0127 ns | 0.0113 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 14.855 ns | 0.0046 ns | 0.0041 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.328 ns | 0.0249 ns | 0.0220 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 16.250 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.186 ns | 0.0075 ns | 0.0063 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.767 ns | 0.0173 ns | 0.0154 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.705 ns | 0.0114 ns | 0.0101 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.084 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.331 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 14.863 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.242 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.770 ns | 0.0086 ns | 0.0071 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.486 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.201 ns | 0.0083 ns | 0.0074 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.260 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.082 ns | 0.0098 ns | 0.0087 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.162 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.923 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.929 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.059 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.762 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.163 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.146 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.610 ns | 0.0090 ns | 0.0075 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.618 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.560 ns | 0.0051 ns | 0.0042 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.163 ns | 0.0208 ns | 0.0194 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.626 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.760 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.836 ns | 0.2051 ns | 0.1818 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.649 ns | 0.0118 ns | 0.0098 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.633 ns | 0.0312 ns | 0.0292 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.634 ns | 0.0065 ns | 0.0055 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 14.153 ns | 0.0060 ns | 0.0057 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.873 ns | 0.0078 ns | 0.0065 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.470 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.215 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.554 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.446 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.489 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.759 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.537 ns | 0.0105 ns | 0.0093 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 41.630 ns | 0.0656 ns | 0.0613 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 10.298 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 37.845 ns | 0.0421 ns | 0.0394 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.596 ns | 0.0058 ns | 0.0052 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.784 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.281 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.637 ns | 0.0065 ns | 0.0058 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.259 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.765 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 40.124 ns | 0.0196 ns | 0.0173 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.396 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.239 ns | 0.0211 ns | 0.0197 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.521 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.528 ns | 0.0363 ns | 0.0322 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.765 ns | 0.0071 ns | 0.0059 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Bool.From_Char_AsObject: DefaultJob
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_String_Empty_AsObject: DefaultJob
