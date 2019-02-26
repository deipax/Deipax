
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.202 ns | 0.0081 ns | 0.0076 ns | 10.203 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.095 ns | 0.0175 ns | 0.0146 ns | 15.098 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.425 ns | 0.0056 ns | 0.0044 ns | 10.425 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.090 ns | 0.0112 ns | 0.0093 ns | 15.091 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.239 ns | 0.0063 ns | 0.0059 ns | 10.241 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.932 ns | 0.0095 ns | 0.0080 ns | 11.931 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.072 ns | 0.0039 ns | 0.0037 ns | 10.072 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.089 ns | 0.0098 ns | 0.0092 ns | 15.088 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.293 ns | 0.0109 ns | 0.0102 ns | 10.290 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.999 ns | 0.0164 ns | 0.0153 ns | 14.993 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.285 ns | 0.0041 ns | 0.0038 ns | 10.286 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.960 ns | 0.0057 ns | 0.0053 ns | 11.959 ns |           - |           - |           - |                   - |
                                             From_Char | 10.075 ns | 0.0070 ns | 0.0058 ns | 10.076 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 15.964 ns | 0.0717 ns | 0.0635 ns | 15.980 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.315 ns | 0.0106 ns | 0.0099 ns | 10.316 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 15.801 ns | 0.0125 ns | 0.0111 ns | 15.801 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.201 ns | 0.0053 ns | 0.0044 ns | 10.202 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.879 ns | 0.0072 ns | 0.0068 ns | 11.876 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.923 ns | 0.0077 ns | 0.0072 ns | 10.921 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.763 ns | 0.0070 ns | 0.0065 ns | 12.764 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.107 ns | 0.0079 ns | 0.0070 ns | 11.107 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.778 ns | 0.0064 ns | 0.0057 ns | 11.778 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.271 ns | 0.0125 ns | 0.0111 ns | 23.271 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.027 ns | 0.0177 ns | 0.0157 ns | 25.025 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 22.994 ns | 0.0162 ns | 0.0151 ns | 22.998 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.936 ns | 0.0202 ns | 0.0189 ns | 24.938 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.255 ns | 0.0100 ns | 0.0094 ns | 11.254 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.757 ns | 0.0077 ns | 0.0072 ns | 11.757 ns |           - |           - |           - |                   - |
                                           From_Double | 12.598 ns | 0.0106 ns | 0.0099 ns | 12.602 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 17.431 ns | 0.0215 ns | 0.0201 ns | 17.432 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.772 ns | 0.0161 ns | 0.0151 ns | 13.777 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.203 ns | 0.0269 ns | 0.0239 ns | 17.205 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.252 ns | 0.0063 ns | 0.0059 ns | 11.251 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.762 ns | 0.0064 ns | 0.0060 ns | 11.759 ns |           - |           - |           - |                   - |
                                            From_Short | 10.718 ns | 0.0108 ns | 0.0101 ns | 10.719 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.387 ns | 0.0217 ns | 0.0203 ns | 15.385 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.465 ns | 0.0110 ns | 0.0103 ns | 10.464 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.372 ns | 0.0131 ns | 0.0123 ns | 15.374 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.206 ns | 0.0051 ns | 0.0048 ns | 10.205 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.813 ns | 0.0048 ns | 0.0045 ns | 12.813 ns |           - |           - |           - |                   - |
                                              From_Int | 10.530 ns | 0.0116 ns | 0.0109 ns | 10.531 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.772 ns | 0.0074 ns | 0.0066 ns | 15.773 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.412 ns | 0.0080 ns | 0.0075 ns | 11.410 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.002 ns | 0.0086 ns | 0.0080 ns | 16.002 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.194 ns | 0.0092 ns | 0.0077 ns | 10.192 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.800 ns | 0.0654 ns | 0.0580 ns | 11.778 ns |           - |           - |           - |                   - |
                                             From_Long | 10.396 ns | 0.0397 ns | 0.0372 ns | 10.385 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.552 ns | 0.0129 ns | 0.0101 ns | 15.553 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.292 ns | 0.0089 ns | 0.0074 ns | 12.292 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.656 ns | 0.0708 ns | 0.0591 ns | 15.643 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.176 ns | 0.0083 ns | 0.0078 ns | 11.175 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.926 ns | 0.0103 ns | 0.0080 ns | 11.925 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.721 ns | 0.0140 ns | 0.0117 ns | 10.718 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.389 ns | 0.0647 ns | 0.0573 ns | 15.379 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.553 ns | 0.0660 ns | 0.0617 ns | 10.546 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.161 ns | 0.0434 ns | 0.0406 ns | 15.163 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.232 ns | 0.0135 ns | 0.0126 ns | 10.233 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.980 ns | 0.0067 ns | 0.0056 ns | 12.981 ns |           - |           - |           - |                   - |
                                            From_Float | 11.968 ns | 0.0126 ns | 0.0112 ns | 11.966 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 17.570 ns | 0.0190 ns | 0.0178 ns | 17.569 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.728 ns | 0.0112 ns | 0.0099 ns | 12.728 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.607 ns | 0.0481 ns | 0.0450 ns | 17.628 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.210 ns | 0.0110 ns | 0.0102 ns | 10.212 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.832 ns | 0.0111 ns | 0.0099 ns | 11.833 ns |           - |           - |           - |                   - |
                                           From_String | 50.897 ns | 0.0735 ns | 0.0652 ns | 50.894 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 93.546 ns | 0.8620 ns | 0.8063 ns | 93.325 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.778 ns | 0.0073 ns | 0.0064 ns | 12.779 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.083 ns | 0.0322 ns | 0.0302 ns | 12.091 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.690 ns | 0.0317 ns | 0.0281 ns | 12.678 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.081 ns | 0.0110 ns | 0.0102 ns | 10.077 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 12.443 ns | 0.0211 ns | 0.0197 ns | 12.442 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.337 ns | 0.0251 ns | 0.0222 ns | 10.337 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.174 ns | 0.0060 ns | 0.0050 ns | 14.175 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.219 ns | 0.0048 ns | 0.0043 ns | 10.220 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.776 ns | 0.0039 ns | 0.0034 ns | 11.776 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.247 ns | 0.0462 ns | 0.0432 ns | 10.233 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.448 ns | 0.1310 ns | 0.1161 ns | 15.389 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.451 ns | 0.0125 ns | 0.0117 ns | 10.454 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.076 ns | 0.0223 ns | 0.0198 ns | 15.079 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.225 ns | 0.0169 ns | 0.0141 ns | 10.221 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.233 ns | 0.1394 ns | 0.1304 ns | 12.178 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.011 ns | 0.0378 ns | 0.0353 ns | 10.991 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.827 ns | 0.0174 ns | 0.0162 ns | 15.832 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.313 ns | 0.0392 ns | 0.0367 ns | 12.307 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.815 ns | 0.0182 ns | 0.0170 ns | 15.813 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.201 ns | 0.0411 ns | 0.0384 ns | 11.199 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.797 ns | 0.0072 ns | 0.0068 ns | 11.796 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.768 ns | 0.0098 ns | 0.0087 ns | 11.768 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.090 ns | 0.0165 ns | 0.0146 ns |  9.088 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.007 ns | 0.1421 ns | 0.1329 ns | 11.974 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.236 ns | 0.0562 ns | 0.0526 ns | 13.239 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.379 ns | 0.0109 ns | 0.0091 ns | 14.377 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.263 ns | 0.0088 ns | 0.0083 ns | 12.260 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.782 ns | 0.0113 ns | 0.0094 ns | 11.782 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.437 ns | 0.0796 ns | 0.0744 ns | 10.411 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.206 ns | 0.0669 ns | 0.0626 ns | 13.179 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.281 ns | 0.0181 ns | 0.0161 ns | 10.280 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.836 ns | 0.0263 ns | 0.0246 ns | 11.843 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.878 ns | 0.0201 ns | 0.0178 ns | 15.871 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.735 ns | 0.0560 ns | 0.0497 ns | 14.723 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 16.003 ns | 0.2560 ns | 0.2395 ns | 16.017 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.705 ns | 0.0612 ns | 0.0573 ns | 14.673 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.047 ns | 0.0178 ns | 0.0157 ns | 12.046 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.306 ns | 0.2445 ns | 0.5666 ns | 12.056 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.515 ns | 0.0288 ns | 0.0256 ns | 11.508 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.192 ns | 0.1076 ns | 0.0954 ns | 14.151 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.617 ns | 0.0118 ns | 0.0105 ns | 11.614 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.602 ns | 0.0331 ns | 0.0277 ns | 13.593 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.672 ns | 0.0744 ns | 0.0696 ns | 11.656 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.971 ns | 0.0248 ns | 0.0219 ns | 11.964 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.519 ns | 0.0326 ns | 0.0305 ns | 12.517 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 43.965 ns | 0.0903 ns | 0.0845 ns | 44.001 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.664 ns | 0.0796 ns | 0.0745 ns | 12.634 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 40.538 ns | 0.5635 ns | 0.5271 ns | 40.321 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.750 ns | 0.0610 ns | 0.0571 ns | 11.762 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.101 ns | 0.0326 ns | 0.0272 ns | 13.102 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.419 ns | 0.0689 ns | 0.0644 ns | 10.429 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.127 ns | 0.0956 ns | 0.0847 ns | 15.103 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.463 ns | 0.0242 ns | 0.0226 ns | 10.457 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.939 ns | 0.0276 ns | 0.0244 ns | 11.940 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.968 ns | 0.0941 ns | 0.0786 ns | 37.949 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.535 ns | 0.0323 ns | 0.0286 ns | 13.531 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.922 ns | 0.0584 ns | 0.0456 ns | 36.923 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.494 ns | 0.0210 ns | 0.0175 ns | 13.492 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.133 ns | 0.1896 ns | 0.1681 ns | 37.159 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.944 ns | 0.0665 ns | 0.0589 ns | 11.956 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShort.From_String_Empty_AsObject: DefaultJob
