
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.274 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.085 ns | 0.0211 ns | 0.0197 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.396 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.100 ns | 0.0299 ns | 0.0280 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.170 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.773 ns | 0.0212 ns | 0.0188 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.072 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 12.388 ns | 0.0055 ns | 0.0048 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.730 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 12.366 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.837 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.759 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
                                             From_Char | 10.291 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.030 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.429 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.108 ns | 0.0176 ns | 0.0165 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.197 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.775 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.947 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.656 ns | 0.0111 ns | 0.0103 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.670 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.652 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.243 ns | 0.0821 ns | 0.0768 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.044 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.174 ns | 0.0251 ns | 0.0222 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.837 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.262 ns | 0.0068 ns | 0.0061 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.775 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                                           From_Double | 12.599 ns | 0.0098 ns | 0.0091 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 17.241 ns | 0.0240 ns | 0.0212 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.825 ns | 0.0240 ns | 0.0225 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.036 ns | 0.0224 ns | 0.0210 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.221 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.862 ns | 0.0109 ns | 0.0096 ns |           - |           - |           - |                   - |
                                            From_Short | 10.569 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.995 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.541 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.998 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.169 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.009 ns | 0.0064 ns | 0.0057 ns |           - |           - |           - |                   - |
                                              From_Int | 10.450 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.606 ns | 0.0342 ns | 0.0320 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.596 ns | 0.0309 ns | 0.0289 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.861 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.189 ns | 0.0085 ns | 0.0071 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.766 ns | 0.0117 ns | 0.0097 ns |           - |           - |           - |                   - |
                                             From_Long | 10.449 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.545 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.265 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.568 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.134 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.882 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.305 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.314 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.431 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.112 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.176 ns | 0.0043 ns | 0.0041 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.797 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
                                            From_Float | 11.923 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 17.213 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.890 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.204 ns | 0.0176 ns | 0.0165 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.172 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.984 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
                                           From_String | 52.866 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 60.170 ns | 0.0470 ns | 0.0440 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.812 ns | 0.0056 ns | 0.0050 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.731 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 11.998 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.282 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.080 ns | 0.0117 ns | 0.0103 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.414 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.118 ns | 0.0162 ns | 0.0151 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.176 ns | 0.0082 ns | 0.0076 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.781 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.287 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.357 ns | 0.0314 ns | 0.0294 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.422 ns | 0.0138 ns | 0.0123 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.130 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.171 ns | 0.0048 ns | 0.0043 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.840 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.025 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.998 ns | 0.0311 ns | 0.0275 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.156 ns | 0.0175 ns | 0.0146 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.012 ns | 0.0305 ns | 0.0286 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.494 ns | 0.0041 ns | 0.0036 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.786 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.778 ns | 0.0062 ns | 0.0052 ns |           - |           - |           - |                   - |
                                           From_DBNull |  8.976 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.773 ns | 0.0196 ns | 0.0183 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.900 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.599 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.480 ns | 0.0066 ns | 0.0058 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.925 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.310 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.147 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.260 ns | 0.0051 ns | 0.0045 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.123 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.272 ns | 0.0288 ns | 0.0256 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.652 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.604 ns | 0.0319 ns | 0.0298 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.661 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.675 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.650 ns | 0.0042 ns | 0.0038 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.418 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.161 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.486 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.242 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.561 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.757 ns | 0.0035 ns | 0.0032 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.892 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.686 ns | 0.1004 ns | 0.0940 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.563 ns | 0.0154 ns | 0.0128 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 39.258 ns | 0.0413 ns | 0.0386 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.153 ns | 0.0055 ns | 0.0049 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.804 ns | 0.0052 ns | 0.0048 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.262 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.670 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.298 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.763 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.911 ns | 0.0320 ns | 0.0299 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.397 ns | 0.0144 ns | 0.0128 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.488 ns | 0.0261 ns | 0.0244 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.385 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.701 ns | 0.0312 ns | 0.0276 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.847 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Byte.From_String_Empty_AsObject: DefaultJob
