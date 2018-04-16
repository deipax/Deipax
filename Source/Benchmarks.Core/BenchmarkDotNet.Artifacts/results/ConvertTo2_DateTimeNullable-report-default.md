
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  17.32 ns | 0.0303 ns | 0.0269 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  17.28 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  17.28 ns | 0.0236 ns | 0.0220 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  20.85 ns | 0.0136 ns | 0.0128 ns |      - |       0 B |
                                             From_Byte |  18.42 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  17.26 ns | 0.0225 ns | 0.0188 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  17.34 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  22.24 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
                                             From_Char |  17.37 ns | 0.0304 ns | 0.0270 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  19.04 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  17.27 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.81 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                         From_DateTime |  17.84 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                From_DateTime_AsObject |  30.83 ns | 0.0763 ns | 0.0714 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  15.90 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  31.12 ns | 0.0279 ns | 0.0248 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  16.41 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.85 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                                          From_Decimal |  17.35 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  18.60 ns | 0.0088 ns | 0.0073 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  18.60 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.83 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                                           From_Double |  17.25 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  17.24 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  17.26 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  21.49 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                            From_Short |  17.36 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  17.26 ns | 0.0348 ns | 0.0308 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  17.27 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.82 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                                              From_Int |  17.53 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  17.25 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  17.27 ns | 0.0205 ns | 0.0172 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.81 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                                             From_Long |  17.52 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  17.26 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  17.62 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.83 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                                            From_SByte |  17.36 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  17.26 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  19.07 ns | 0.0082 ns | 0.0076 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.56 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                                            From_Float |  17.24 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  17.27 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  17.26 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.83 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                                           From_String | 772.54 ns | 0.9785 ns | 0.9153 ns |      - |       0 B |
                                  From_String_AsObject | 816.39 ns | 0.4960 ns | 0.4640 ns |      - |       0 B |
                                      From_String_Null |  17.96 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.34 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                     From_String_Empty |  18.73 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  17.34 ns | 0.0026 ns | 0.0019 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  17.25 ns | 0.0214 ns | 0.0189 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  17.25 ns | 0.0054 ns | 0.0039 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.82 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                                             From_UInt |  17.52 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  17.25 ns | 0.0159 ns | 0.0124 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  17.23 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  19.51 ns | 0.0046 ns | 0.0040 ns |      - |       0 B |
                                            From_ULong |  18.58 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  17.26 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  17.26 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.82 ns | 0.0215 ns | 0.0190 ns |      - |       0 B |
                                       From_NullObject |  18.81 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                           From_DBNull |  20.54 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.36 ns | 0.0481 ns | 0.0449 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.84 ns | 0.0396 ns | 0.0371 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.76 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.83 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.36 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  28.20 ns | 0.0147 ns | 0.0131 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.52 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  19.54 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.88 ns | 0.0291 ns | 0.0272 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.27 ns | 0.0555 ns | 0.0492 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  31.02 ns | 0.0224 ns | 0.0199 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.17 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  18.32 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  23.59 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                             From_NonConvertibleStruct |  17.25 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  26.58 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  18.78 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.23 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  17.25 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.80 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                             From_Enum |  19.13 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  18.85 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  18.86 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.80 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                      From_ParentClass |  21.71 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                             From_ParentClass_AsObject |  27.06 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
                              From_ParentClass_NoValue |  18.91 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  21.11 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                     From_ParentStruct |  17.23 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  26.55 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  17.24 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.68 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  17.22 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.80 ns | 0.0136 ns | 0.0121 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
