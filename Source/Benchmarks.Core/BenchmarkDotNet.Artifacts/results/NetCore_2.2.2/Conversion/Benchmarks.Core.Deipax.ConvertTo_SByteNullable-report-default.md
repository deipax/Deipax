
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.34 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 17.18 ns | 0.0224 ns | 0.0210 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.54 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.40 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.16 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.98 ns | 0.0056 ns | 0.0053 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.36 ns | 0.0198 ns | 0.0186 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.38 ns | 0.0074 ns | 0.0065 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.10 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.62 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.12 ns | 0.0060 ns | 0.0057 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.83 ns | 0.0063 ns | 0.0053 ns |           - |           - |           - |                   - |
                                             From_Char | 10.36 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 17.93 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.54 ns | 0.0047 ns | 0.0041 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.92 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.13 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.87 ns | 0.0051 ns | 0.0045 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.10 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.13 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.14 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.80 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.25 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 30.17 ns | 0.0276 ns | 0.0258 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.27 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 28.92 ns | 0.0165 ns | 0.0154 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.35 ns | 0.0059 ns | 0.0053 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.82 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
                                           From_Double | 12.89 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 19.46 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.24 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 19.44 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.33 ns | 0.0205 ns | 0.0192 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.34 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
                                            From_Short | 11.41 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.85 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.65 ns | 0.0252 ns | 0.0223 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.81 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.18 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.81 ns | 0.0063 ns | 0.0056 ns |           - |           - |           - |                   - |
                                              From_Int | 11.34 ns | 0.0074 ns | 0.0070 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.61 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.48 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.61 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.16 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.91 ns | 0.0064 ns | 0.0057 ns |           - |           - |           - |                   - |
                                             From_Long | 11.52 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.97 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.47 ns | 0.0059 ns | 0.0053 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.64 ns | 0.0109 ns | 0.0096 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.21 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.83 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.76 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 25.15 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.08 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 25.10 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.09 ns | 0.0180 ns | 0.0159 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.81 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
                                            From_Float | 12.83 ns | 0.0105 ns | 0.0099 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.98 ns | 0.0075 ns | 0.0066 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.91 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 19.48 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.31 ns | 0.0056 ns | 0.0053 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.83 ns | 0.0077 ns | 0.0069 ns |           - |           - |           - |                   - |
                                           From_String | 90.71 ns | 0.0536 ns | 0.0448 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 61.22 ns | 0.0572 ns | 0.0507 ns |           - |           - |           - |                   - |
                                      From_String_Null | 17.96 ns | 0.0281 ns | 0.0262 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.85 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 18.43 ns | 0.0337 ns | 0.0315 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.34 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.38 ns | 0.0146 ns | 0.0129 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.67 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.44 ns | 0.0170 ns | 0.0151 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.12 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.59 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.83 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.51 ns | 0.0072 ns | 0.0064 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.55 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.43 ns | 0.0142 ns | 0.0126 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.12 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.83 ns | 0.0081 ns | 0.0072 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.34 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.42 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.45 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.38 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.32 ns | 0.0064 ns | 0.0054 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.83 ns | 0.0084 ns | 0.0070 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.80 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.00 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.83 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.41 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.01 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.82 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.81 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.07 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.64 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.12 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.35 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.16 ns | 0.0218 ns | 0.0182 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.92 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.98 ns | 0.0200 ns | 0.0178 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.93 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.90 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.82 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.24 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.66 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.32 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.64 ns | 0.0047 ns | 0.0039 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.31 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.80 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.83 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 47.64 ns | 0.0507 ns | 0.0475 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.59 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 43.31 ns | 0.0585 ns | 0.0547 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.19 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.81 ns | 0.0080 ns | 0.0067 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.12 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.58 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.12 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.48 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 40.32 ns | 0.0217 ns | 0.0203 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.18 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 41.16 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.10 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 43.92 ns | 0.0200 ns | 0.0177 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.94 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_String_Empty_AsObject: DefaultJob
