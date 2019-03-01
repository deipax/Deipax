
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.554 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.454 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.972 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.298 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.292 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.922 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.054 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.995 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.633 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.805 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                                             From_Char | 10.805 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 24.965 ns | 0.0155 ns | 0.0138 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.676 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 25.043 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.079 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.807 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.075 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.118 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.113 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.827 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
                                          From_Decimal | 11.149 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 11.155 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.721 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.825 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                                           From_Double | 10.319 ns | 0.0052 ns | 0.0048 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.759 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.126 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.807 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
                                            From_Short | 10.776 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.471 ns | 0.0217 ns | 0.0192 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.984 ns | 0.0053 ns | 0.0047 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.451 ns | 0.0208 ns | 0.0195 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.600 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.807 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
                                              From_Int | 11.355 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.681 ns | 0.0233 ns | 0.0207 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.327 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.724 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.649 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.804 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
                                             From_Long | 11.321 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.156 ns | 0.0176 ns | 0.0165 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.463 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.680 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.507 ns | 0.0096 ns | 0.0086 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.846 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.292 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 17.394 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.017 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.971 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.588 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.408 ns | 0.0131 ns | 0.0117 ns |           - |           - |           - |                   - |
                                            From_Float | 10.319 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 10.499 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.786 ns | 0.0057 ns | 0.0050 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.858 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
                                           From_String | 13.971 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 19.460 ns | 0.0760 ns | 0.0674 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.812 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.808 ns | 0.0054 ns | 0.0045 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.507 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.288 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.926 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.784 ns | 0.0126 ns | 0.0117 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.189 ns | 0.0125 ns | 0.0110 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.637 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.807 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                                             From_UInt | 13.769 ns | 0.0109 ns | 0.0097 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.391 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.989 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.418 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.590 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.829 ns | 0.0068 ns | 0.0063 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.560 ns | 0.2392 ns | 0.2349 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 20.116 ns | 0.0252 ns | 0.0235 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.981 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.633 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.092 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.822 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.808 ns | 0.0054 ns | 0.0048 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.019 ns | 0.0111 ns | 0.0093 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.817 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.489 ns | 0.0081 ns | 0.0072 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.799 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.807 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.612 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.133 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.635 ns | 0.0082 ns | 0.0076 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.133 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.843 ns | 0.0114 ns | 0.0101 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.166 ns | 0.0213 ns | 0.0199 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.923 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.966 ns | 0.0147 ns | 0.0130 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.921 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.892 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.847 ns | 0.0153 ns | 0.0144 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.234 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.652 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.507 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.635 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.321 ns | 0.0049 ns | 0.0041 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.421 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.841 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 44.315 ns | 0.0273 ns | 0.0256 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.555 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 48.865 ns | 0.0405 ns | 0.0359 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.496 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.811 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.125 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.109 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.124 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.805 ns | 0.0076 ns | 0.0068 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 43.165 ns | 0.0149 ns | 0.0132 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.157 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 40.702 ns | 0.0261 ns | 0.0244 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.106 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 41.235 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.339 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_String_Empty_AsObject: DefaultJob
