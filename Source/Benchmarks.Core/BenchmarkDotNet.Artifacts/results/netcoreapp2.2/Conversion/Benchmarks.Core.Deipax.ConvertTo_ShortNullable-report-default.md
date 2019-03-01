
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.32 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 17.24 ns | 0.0241 ns | 0.0225 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.40 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.23 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.16 ns | 0.0050 ns | 0.0044 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.83 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.30 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.04 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.57 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.92 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.16 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.30 ns | 0.0095 ns | 0.0088 ns |           - |           - |           - |                   - |
                                             From_Char | 10.53 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.06 ns | 0.0168 ns | 0.0158 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.56 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.98 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.11 ns | 0.0040 ns | 0.0034 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.84 ns | 0.0207 ns | 0.0184 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.55 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.15 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.14 ns | 0.0041 ns | 0.0037 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.16 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
                                          From_Decimal | 24.52 ns | 0.0395 ns | 0.0370 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 28.85 ns | 0.0085 ns | 0.0071 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.91 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 29.17 ns | 0.0208 ns | 0.0194 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.99 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 13.01 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                                           From_Double | 12.92 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 19.44 ns | 0.0145 ns | 0.0128 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.15 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 20.06 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.30 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.82 ns | 0.0080 ns | 0.0074 ns |           - |           - |           - |                   - |
                                            From_Short | 10.75 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 28.09 ns | 0.0207 ns | 0.0193 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.11 ns | 0.0125 ns | 0.0111 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 25.04 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.07 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.80 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
                                              From_Int | 11.34 ns | 0.0089 ns | 0.0079 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.73 ns | 0.0156 ns | 0.0138 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.50 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.61 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.16 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.81 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                                             From_Long | 11.91 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.82 ns | 0.0259 ns | 0.0216 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.52 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.91 ns | 0.0196 ns | 0.0184 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.21 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.80 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.26 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.92 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.61 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.92 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.67 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 13.33 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                                            From_Float | 15.76 ns | 0.0071 ns | 0.0059 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 20.50 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.90 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 19.47 ns | 0.0180 ns | 0.0169 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.30 ns | 0.0061 ns | 0.0058 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.83 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
                                           From_String | 58.37 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 96.17 ns | 0.0787 ns | 0.0658 ns |           - |           - |           - |                   - |
                                      From_String_Null | 18.22 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.82 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 18.31 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.53 ns | 0.0058 ns | 0.0055 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.39 ns | 0.0083 ns | 0.0073 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.55 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.38 ns | 0.0093 ns | 0.0082 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.11 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.85 ns | 0.0109 ns | 0.0091 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.37 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 18.65 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.52 ns | 0.0101 ns | 0.0089 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.71 ns | 0.0126 ns | 0.0117 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.55 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.81 ns | 0.0067 ns | 0.0056 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.32 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.67 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.52 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.76 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.62 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.04 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.81 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.01 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.83 ns | 0.0063 ns | 0.0056 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.41 ns | 0.0099 ns | 0.0092 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.70 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.81 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.49 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.12 ns | 0.0039 ns | 0.0034 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.62 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.14 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.81 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.61 ns | 0.0333 ns | 0.0295 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.92 ns | 0.0084 ns | 0.0074 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.96 ns | 0.0294 ns | 0.0275 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.98 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.89 ns | 0.0049 ns | 0.0041 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.81 ns | 0.0093 ns | 0.0083 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.27 ns | 0.0076 ns | 0.0067 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.26 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.33 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.64 ns | 0.0044 ns | 0.0042 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.32 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.82 ns | 0.0056 ns | 0.0049 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.82 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.88 ns | 0.0655 ns | 0.0613 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.66 ns | 0.0328 ns | 0.0307 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 44.07 ns | 0.0290 ns | 0.0257 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.19 ns | 0.0058 ns | 0.0051 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.82 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.13 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.23 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.14 ns | 0.0064 ns | 0.0057 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.82 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 42.03 ns | 0.0455 ns | 0.0403 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.24 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 40.42 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.11 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 40.21 ns | 0.0183 ns | 0.0162 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.81 ns | 0.0075 ns | 0.0071 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_String_Empty_AsObject: DefaultJob
