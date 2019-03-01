
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.082 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.066 ns | 0.0079 ns | 0.0062 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.089 ns | 0.0090 ns | 0.0085 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.757 ns | 0.0058 ns | 0.0051 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.070 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.113 ns | 0.0074 ns | 0.0062 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.680 ns | 0.0133 ns | 0.0118 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.863 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.594 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.886 ns | 0.0055 ns | 0.0049 ns |           - |           - |           - |                   - |
                                             From_Char | 10.098 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 12.349 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.342 ns | 0.0183 ns | 0.0162 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 12.334 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.204 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.337 ns | 0.0083 ns | 0.0074 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.324 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.936 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.078 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.760 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
                                          From_Decimal | 11.659 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 11.556 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.388 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.910 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                                           From_Double | 10.859 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 11.076 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.641 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.762 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
                                            From_Short | 11.520 ns | 0.0099 ns | 0.0088 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.317 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.418 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.321 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.660 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.774 ns | 0.0072 ns | 0.0068 ns |           - |           - |           - |                   - |
                                              From_Int | 10.431 ns | 0.0193 ns | 0.0180 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.558 ns | 0.0191 ns | 0.0170 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.072 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.824 ns | 0.0300 ns | 0.0281 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.572 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.821 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
                                             From_Long | 10.837 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.545 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.948 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.542 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.697 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.769 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.255 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.154 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.884 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.116 ns | 0.0236 ns | 0.0221 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.712 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.798 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
                                            From_Float | 10.221 ns | 0.0045 ns | 0.0040 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 10.487 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.495 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.763 ns | 0.0048 ns | 0.0042 ns |           - |           - |           - |                   - |
                                           From_String | 12.405 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 17.414 ns | 0.0253 ns | 0.0237 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.645 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.095 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 11.693 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.501 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.634 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.751 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.877 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.582 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.760 ns | 0.0087 ns | 0.0073 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.294 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.324 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.872 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.082 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.640 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.899 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.436 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.987 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.553 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.987 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.650 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.086 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.763 ns | 0.0072 ns | 0.0068 ns |           - |           - |           - |                   - |
                                           From_DBNull |  8.953 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.999 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.437 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.333 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.849 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.920 ns | 0.0084 ns | 0.0075 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.869 ns | 0.0041 ns | 0.0034 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.360 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.263 ns | 0.0088 ns | 0.0083 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.763 ns | 0.0040 ns | 0.0035 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.874 ns | 0.0215 ns | 0.0191 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.661 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.623 ns | 0.0205 ns | 0.0171 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.624 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.124 ns | 0.0063 ns | 0.0056 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.781 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.452 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.160 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.818 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.170 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.487 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.757 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.277 ns | 0.0836 ns | 0.0782 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.071 ns | 0.0929 ns | 0.0824 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.384 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 43.582 ns | 0.0543 ns | 0.0508 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.187 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.838 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.290 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.632 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.357 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.776 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 41.645 ns | 0.0255 ns | 0.0239 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.639 ns | 0.0096 ns | 0.0089 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.576 ns | 0.0452 ns | 0.0422 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.384 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.596 ns | 0.0410 ns | 0.0383 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.805 ns | 0.0080 ns | 0.0074 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Char.From_Bool_AsObject: DefaultJob
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Double_AsObject: DefaultJob
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Float_AsObject: DefaultJob
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_String_Empty_AsObject: DefaultJob
