
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|---------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.34 ns | 0.0065 ns | 0.0058 ns | 10.34 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 17.15 ns | 0.0095 ns | 0.0089 ns | 17.15 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.20 ns | 0.0119 ns | 0.0111 ns | 11.20 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.15 ns | 0.0092 ns | 0.0082 ns | 17.15 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.14 ns | 0.0066 ns | 0.0062 ns | 10.14 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.86 ns | 0.0074 ns | 0.0065 ns | 12.86 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.75 ns | 0.0096 ns | 0.0081 ns | 10.75 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 24.97 ns | 0.0159 ns | 0.0149 ns | 24.96 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.08 ns | 0.0051 ns | 0.0043 ns | 10.08 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 25.60 ns | 0.0129 ns | 0.0121 ns | 25.60 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.11 ns | 0.0116 ns | 0.0108 ns | 10.11 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.81 ns | 0.0083 ns | 0.0078 ns | 12.80 ns |           - |           - |           - |                   - |
                                             From_Char | 10.36 ns | 0.0046 ns | 0.0041 ns | 10.36 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 17.94 ns | 0.0126 ns | 0.0118 ns | 17.94 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.54 ns | 0.0076 ns | 0.0071 ns | 10.54 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.93 ns | 0.0148 ns | 0.0138 ns | 17.93 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.16 ns | 0.0111 ns | 0.0104 ns | 10.16 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.80 ns | 0.0041 ns | 0.0034 ns | 12.81 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.06 ns | 0.0060 ns | 0.0056 ns | 11.06 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.75 ns | 0.0054 ns | 0.0050 ns | 11.75 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.76 ns | 0.0091 ns | 0.0081 ns | 11.75 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.82 ns | 0.0060 ns | 0.0057 ns | 12.82 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.20 ns | 0.0133 ns | 0.0124 ns | 23.20 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 28.98 ns | 0.0205 ns | 0.0192 ns | 28.97 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.98 ns | 0.0120 ns | 0.0106 ns | 23.98 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 29.61 ns | 0.5913 ns | 0.7688 ns | 30.24 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.39 ns | 0.0056 ns | 0.0052 ns | 11.39 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.27 ns | 0.0055 ns | 0.0051 ns | 14.27 ns |           - |           - |           - |                   - |
                                           From_Double | 13.42 ns | 0.0385 ns | 0.0322 ns | 13.40 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 19.55 ns | 0.0095 ns | 0.0089 ns | 19.55 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.31 ns | 0.0177 ns | 0.0166 ns | 14.31 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 19.47 ns | 0.0093 ns | 0.0087 ns | 19.47 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.28 ns | 0.0055 ns | 0.0051 ns | 11.28 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.81 ns | 0.0082 ns | 0.0077 ns | 12.81 ns |           - |           - |           - |                   - |
                                            From_Short | 12.44 ns | 0.0071 ns | 0.0066 ns | 12.44 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.67 ns | 0.0154 ns | 0.0137 ns | 17.66 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 14.92 ns | 0.0053 ns | 0.0044 ns | 14.92 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.74 ns | 0.0130 ns | 0.0121 ns | 17.74 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.14 ns | 0.0048 ns | 0.0040 ns | 10.14 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.18 ns | 0.0084 ns | 0.0079 ns | 13.18 ns |           - |           - |           - |                   - |
                                              From_Int | 12.09 ns | 0.0110 ns | 0.0092 ns | 12.09 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.64 ns | 0.0102 ns | 0.0096 ns | 17.64 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.47 ns | 0.0056 ns | 0.0049 ns | 11.47 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.04 ns | 0.0165 ns | 0.0154 ns | 18.04 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.14 ns | 0.0062 ns | 0.0055 ns | 10.14 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.82 ns | 0.0118 ns | 0.0110 ns | 12.82 ns |           - |           - |           - |                   - |
                                             From_Long | 11.37 ns | 0.0043 ns | 0.0040 ns | 11.37 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.74 ns | 0.0090 ns | 0.0084 ns | 17.74 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.50 ns | 0.0248 ns | 0.0220 ns | 12.49 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.61 ns | 0.0158 ns | 0.0148 ns | 17.61 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.88 ns | 0.0075 ns | 0.0070 ns | 11.88 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.21 ns | 0.0103 ns | 0.0096 ns | 13.21 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.34 ns | 0.0072 ns | 0.0067 ns | 10.34 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 17.38 ns | 0.0112 ns | 0.0105 ns | 17.38 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.55 ns | 0.0119 ns | 0.0112 ns | 10.54 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.37 ns | 0.0110 ns | 0.0102 ns | 17.37 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.11 ns | 0.0048 ns | 0.0045 ns | 10.11 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.81 ns | 0.0081 ns | 0.0076 ns | 12.81 ns |           - |           - |           - |                   - |
                                            From_Float | 12.84 ns | 0.0088 ns | 0.0082 ns | 12.84 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.44 ns | 0.0136 ns | 0.0127 ns | 19.44 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.43 ns | 0.0087 ns | 0.0077 ns | 13.43 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 20.01 ns | 0.0110 ns | 0.0092 ns | 20.01 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.29 ns | 0.0068 ns | 0.0063 ns | 10.29 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.81 ns | 0.0068 ns | 0.0063 ns | 12.81 ns |           - |           - |           - |                   - |
                                           From_String | 58.61 ns | 0.0525 ns | 0.0491 ns | 58.61 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 62.84 ns | 0.0656 ns | 0.0614 ns | 62.86 ns |           - |           - |           - |                   - |
                                      From_String_Null | 18.71 ns | 0.0579 ns | 0.0541 ns | 18.70 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.83 ns | 0.0090 ns | 0.0084 ns | 12.83 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 18.24 ns | 0.0246 ns | 0.0230 ns | 18.24 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                                           From_UShort | 10.82 ns | 0.0077 ns | 0.0072 ns | 10.82 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.40 ns | 0.0105 ns | 0.0098 ns | 17.39 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.54 ns | 0.0094 ns | 0.0088 ns | 10.54 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.38 ns | 0.0080 ns | 0.0075 ns | 17.38 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.12 ns | 0.0065 ns | 0.0057 ns | 10.12 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.81 ns | 0.0058 ns | 0.0054 ns | 12.81 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.36 ns | 0.0062 ns | 0.0058 ns | 10.36 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.39 ns | 0.0116 ns | 0.0108 ns | 17.39 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.82 ns | 0.0062 ns | 0.0058 ns | 12.82 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.40 ns | 0.0269 ns | 0.0252 ns | 17.39 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.53 ns | 0.0057 ns | 0.0053 ns | 10.52 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.81 ns | 0.0044 ns | 0.0041 ns | 12.80 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.49 ns | 0.0295 ns | 0.0276 ns | 11.49 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.66 ns | 0.0119 ns | 0.0111 ns | 17.66 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.45 ns | 0.0112 ns | 0.0105 ns | 12.45 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.75 ns | 0.0115 ns | 0.0102 ns | 17.75 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.21 ns | 0.0056 ns | 0.0052 ns | 11.21 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.85 ns | 0.0072 ns | 0.0064 ns | 12.85 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.81 ns | 0.0073 ns | 0.0068 ns | 12.81 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.00 ns | 0.0053 ns | 0.0050 ns | 11.00 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.81 ns | 0.0032 ns | 0.0028 ns | 12.81 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.43 ns | 0.0079 ns | 0.0074 ns | 14.43 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.69 ns | 0.0071 ns | 0.0066 ns | 16.69 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.81 ns | 0.0080 ns | 0.0067 ns | 12.81 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.83 ns | 0.0109 ns | 0.0102 ns | 12.83 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.12 ns | 0.0059 ns | 0.0056 ns | 12.12 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.65 ns | 0.0102 ns | 0.0095 ns | 14.65 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.12 ns | 0.0060 ns | 0.0056 ns | 12.12 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.81 ns | 0.0060 ns | 0.0057 ns | 12.81 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.59 ns | 0.0272 ns | 0.0254 ns | 16.60 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.92 ns | 0.0096 ns | 0.0090 ns | 16.92 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.97 ns | 0.0148 ns | 0.0138 ns | 15.96 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.93 ns | 0.0082 ns | 0.0076 ns | 16.93 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.89 ns | 0.0066 ns | 0.0059 ns | 11.89 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.83 ns | 0.0098 ns | 0.0091 ns | 12.82 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.24 ns | 0.0063 ns | 0.0059 ns | 11.24 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.64 ns | 0.0064 ns | 0.0057 ns | 14.64 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.32 ns | 0.0061 ns | 0.0057 ns | 11.32 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.66 ns | 0.0164 ns | 0.0145 ns | 16.66 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.39 ns | 0.0075 ns | 0.0070 ns | 11.39 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.81 ns | 0.0074 ns | 0.0069 ns | 12.81 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.02 ns | 0.0187 ns | 0.0175 ns | 13.02 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 44.07 ns | 0.0857 ns | 0.0802 ns | 44.08 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.49 ns | 0.0128 ns | 0.0113 ns | 13.49 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 47.93 ns | 0.0261 ns | 0.0244 ns | 47.93 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.82 ns | 0.0049 ns | 0.0046 ns | 12.82 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.85 ns | 0.0142 ns | 0.0133 ns | 12.85 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.12 ns | 0.0066 ns | 0.0061 ns | 12.12 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.10 ns | 0.0090 ns | 0.0084 ns | 15.10 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.17 ns | 0.0085 ns | 0.0079 ns | 12.17 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.55 ns | 0.0082 ns | 0.0076 ns | 13.55 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.97 ns | 0.0359 ns | 0.0319 ns | 39.96 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.15 ns | 0.0193 ns | 0.0181 ns | 15.15 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.78 ns | 0.0203 ns | 0.0190 ns | 39.77 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 16.34 ns | 0.0103 ns | 0.0096 ns | 16.34 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.73 ns | 0.0316 ns | 0.0295 ns | 38.73 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.51 ns | 0.0068 ns | 0.0063 ns | 13.51 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_String_Empty_AsObject: DefaultJob
