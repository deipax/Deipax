
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.61 ns | 0.0425 ns | 0.0377 ns | 14.60 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 14.57 ns | 0.0131 ns | 0.0122 ns | 14.57 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 13.66 ns | 0.0183 ns | 0.0162 ns | 13.66 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 18.59 ns | 0.0114 ns | 0.0101 ns | 18.59 ns |      - |       0 B |
                                             From_Byte | 13.90 ns | 0.0115 ns | 0.0107 ns | 13.89 ns |      - |       0 B |
                                    From_Byte_AsObject | 24.74 ns | 0.0114 ns | 0.0101 ns | 24.74 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.98 ns | 0.0125 ns | 0.0117 ns | 13.99 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 24.69 ns | 0.0163 ns | 0.0144 ns | 24.69 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.84 ns | 0.0107 ns | 0.0100 ns | 13.84 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 18.55 ns | 0.0057 ns | 0.0044 ns | 18.55 ns |      - |       0 B |
                                             From_Char | 13.75 ns | 0.0101 ns | 0.0095 ns | 13.75 ns |      - |       0 B |
                                    From_Char_AsObject | 31.39 ns | 0.0251 ns | 0.0235 ns | 31.38 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.61 ns | 0.0129 ns | 0.0120 ns | 14.60 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 28.24 ns | 0.0097 ns | 0.0086 ns | 28.24 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.14 ns | 0.0043 ns | 0.0036 ns | 13.14 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.69 ns | 0.0101 ns | 0.0095 ns | 17.69 ns |      - |       0 B |
                                         From_DateTime | 14.12 ns | 0.0134 ns | 0.0119 ns | 14.12 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.54 ns | 0.0104 ns | 0.0097 ns | 14.53 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.53 ns | 0.0094 ns | 0.0083 ns | 14.53 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.69 ns | 0.0073 ns | 0.0068 ns | 17.69 ns |      - |       0 B |
                                          From_Decimal | 14.54 ns | 0.0177 ns | 0.0148 ns | 14.53 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 14.39 ns | 0.0120 ns | 0.0112 ns | 14.39 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 14.62 ns | 0.0170 ns | 0.0159 ns | 14.62 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.83 ns | 0.0120 ns | 0.0106 ns | 18.83 ns |      - |       0 B |
                                           From_Double | 14.23 ns | 0.0146 ns | 0.0137 ns | 14.22 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 15.34 ns | 0.0042 ns | 0.0033 ns | 15.34 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 14.55 ns | 0.0157 ns | 0.0147 ns | 14.55 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.70 ns | 0.0095 ns | 0.0089 ns | 17.69 ns |      - |       0 B |
                                            From_Short | 13.96 ns | 0.0125 ns | 0.0111 ns | 13.96 ns |      - |       0 B |
                                   From_Short_AsObject | 25.24 ns | 0.0142 ns | 0.0126 ns | 25.24 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.68 ns | 0.0104 ns | 0.0097 ns | 14.68 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 25.25 ns | 0.0061 ns | 0.0048 ns | 25.25 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.94 ns | 0.0162 ns | 0.0143 ns | 13.94 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.68 ns | 0.0115 ns | 0.0102 ns | 16.68 ns |      - |       0 B |
                                              From_Int | 15.92 ns | 0.0098 ns | 0.0082 ns | 15.92 ns |      - |       0 B |
                                     From_Int_AsObject | 27.03 ns | 0.0145 ns | 0.0136 ns | 27.03 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.40 ns | 0.0128 ns | 0.0113 ns | 15.39 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.00 ns | 0.0061 ns | 0.0048 ns | 26.00 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.82 ns | 0.0092 ns | 0.0082 ns | 13.81 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.72 ns | 0.0055 ns | 0.0048 ns | 16.72 ns |      - |       0 B |
                                             From_Long | 14.80 ns | 0.0118 ns | 0.0104 ns | 14.80 ns |      - |       0 B |
                                    From_Long_AsObject | 25.96 ns | 0.0106 ns | 0.0094 ns | 25.96 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.85 ns | 0.0145 ns | 0.0136 ns | 16.84 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.96 ns | 0.0068 ns | 0.0060 ns | 26.96 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.81 ns | 0.0136 ns | 0.0127 ns | 14.80 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.19 ns | 0.0066 ns | 0.0061 ns | 17.19 ns |      - |       0 B |
                                            From_SByte | 13.96 ns | 0.0079 ns | 0.0070 ns | 13.97 ns |      - |       0 B |
                                   From_SByte_AsObject | 25.23 ns | 0.0049 ns | 0.0041 ns | 25.23 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.44 ns | 0.0097 ns | 0.0086 ns | 14.43 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.19 ns | 0.0123 ns | 0.0115 ns | 25.18 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.94 ns | 0.0086 ns | 0.0076 ns | 13.93 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 18.24 ns | 0.0097 ns | 0.0091 ns | 18.23 ns |      - |       0 B |
                                            From_Float | 15.69 ns | 0.0129 ns | 0.0120 ns | 15.69 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 13.66 ns | 0.0229 ns | 0.0203 ns | 13.65 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 13.65 ns | 0.0079 ns | 0.0070 ns | 13.65 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 21.32 ns | 0.0028 ns | 0.0022 ns | 21.32 ns |      - |       0 B |
                                           From_String | 17.09 ns | 0.0153 ns | 0.0144 ns | 17.09 ns |      - |       0 B |
                                  From_String_AsObject | 24.84 ns | 0.8492 ns | 0.7528 ns | 24.46 ns |      - |       0 B |
                                      From_String_Null | 15.82 ns | 0.0629 ns | 0.0525 ns | 15.79 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.80 ns | 0.1401 ns | 0.1311 ns | 16.74 ns |      - |       0 B |
                                     From_String_Empty | 17.35 ns | 0.6777 ns | 1.9553 ns | 16.28 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.78 ns | 0.0248 ns | 0.0207 ns | 14.77 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.74 ns | 0.0457 ns | 0.0427 ns | 25.73 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.01 ns | 0.0298 ns | 0.0264 ns | 13.99 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 24.73 ns | 0.0359 ns | 0.0336 ns | 24.72 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.84 ns | 0.0212 ns | 0.0188 ns | 13.83 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 21.13 ns | 0.0882 ns | 0.0782 ns | 21.10 ns |      - |       0 B |
                                             From_UInt | 15.53 ns | 0.0143 ns | 0.0127 ns | 15.53 ns |      - |       0 B |
                                    From_UInt_AsObject | 25.29 ns | 0.0482 ns | 0.0427 ns | 25.27 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.58 ns | 0.0642 ns | 0.0569 ns | 14.58 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.22 ns | 0.0123 ns | 0.0103 ns | 25.22 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.98 ns | 0.0672 ns | 0.0629 ns | 13.94 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 19.97 ns | 0.0314 ns | 0.0294 ns | 19.96 ns |      - |       0 B |
                                            From_ULong | 14.58 ns | 0.0279 ns | 0.0248 ns | 14.57 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.79 ns | 0.0243 ns | 0.0216 ns | 26.79 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.65 ns | 0.0416 ns | 0.0389 ns | 16.65 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 25.79 ns | 0.0190 ns | 0.0158 ns | 25.79 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.84 ns | 0.0198 ns | 0.0176 ns | 14.83 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.72 ns | 0.0267 ns | 0.0250 ns | 16.70 ns |      - |       0 B |
                                       From_NullObject | 16.74 ns | 0.0231 ns | 0.0216 ns | 16.75 ns |      - |       0 B |
                                           From_DBNull | 16.22 ns | 0.0332 ns | 0.0311 ns | 16.20 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.70 ns | 0.0108 ns | 0.0090 ns | 16.70 ns |      - |       0 B |
                                 From_ConvertibleClass | 22.62 ns | 0.0254 ns | 0.0225 ns | 22.61 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.58 ns | 0.0150 ns | 0.0133 ns | 22.57 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.77 ns | 0.0088 ns | 0.0069 ns | 16.77 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.62 ns | 0.0174 ns | 0.0154 ns | 17.62 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.00 ns | 0.0137 ns | 0.0115 ns | 14.99 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.19 ns | 0.0367 ns | 0.0306 ns | 19.19 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.04 ns | 0.0232 ns | 0.0217 ns | 15.03 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.73 ns | 0.0342 ns | 0.0304 ns | 16.72 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.77 ns | 0.0120 ns | 0.0106 ns | 22.77 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.52 ns | 0.0059 ns | 0.0049 ns | 23.52 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.95 ns | 0.0162 ns | 0.0135 ns | 22.95 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.56 ns | 0.0318 ns | 0.0282 ns | 24.55 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.50 ns | 0.0172 ns | 0.0161 ns | 14.50 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.75 ns | 0.0361 ns | 0.0338 ns | 16.75 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.97 ns | 0.0096 ns | 0.0069 ns | 14.96 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.94 ns | 0.0348 ns | 0.0326 ns | 20.93 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.61 ns | 0.0125 ns | 0.0111 ns | 14.61 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.63 ns | 0.0311 ns | 0.0291 ns | 19.62 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 15.04 ns | 0.0150 ns | 0.0133 ns | 15.03 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.69 ns | 0.0046 ns | 0.0041 ns | 16.69 ns |      - |       0 B |
                                             From_Enum | 16.14 ns | 0.0177 ns | 0.0166 ns | 16.14 ns |      - |       0 B |
                                    From_Enum_AsObject | 55.99 ns | 0.0654 ns | 0.0612 ns | 55.96 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 16.41 ns | 0.0235 ns | 0.0196 ns | 16.41 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 56.08 ns | 0.1014 ns | 0.0899 ns | 56.04 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.83 ns | 0.0071 ns | 0.0063 ns | 13.83 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.77 ns | 0.0089 ns | 0.0079 ns | 16.77 ns |      - |       0 B |
                                      From_ParentClass | 15.11 ns | 0.0344 ns | 0.0321 ns | 15.09 ns |      - |       0 B |
                             From_ParentClass_AsObject | 20.52 ns | 0.0126 ns | 0.0106 ns | 20.52 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.08 ns | 0.0413 ns | 0.0386 ns | 15.06 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.67 ns | 0.0089 ns | 0.0083 ns | 17.67 ns |      - |       0 B |
                                     From_ParentStruct | 14.54 ns | 0.0047 ns | 0.0037 ns | 14.54 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.51 ns | 0.0137 ns | 0.0122 ns | 20.51 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 20.30 ns | 0.0190 ns | 0.0178 ns | 20.30 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 20.00 ns | 0.0190 ns | 0.0168 ns | 20.00 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.54 ns | 0.0387 ns | 0.0362 ns | 14.52 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 19.80 ns | 0.0145 ns | 0.0135 ns | 19.80 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_String_Empty_AsObject: DefaultJob
