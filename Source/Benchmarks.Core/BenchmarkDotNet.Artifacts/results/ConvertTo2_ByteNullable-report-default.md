
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.48 ns | 0.0554 ns | 0.0491 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.29 ns | 0.0236 ns | 0.0221 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.10 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.32 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.69 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.46 ns | 0.0028 ns | 0.0021 ns |      - |       0 B |
                                             From_Byte |  15.43 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                    From_Byte_AsObject |  29.62 ns | 0.0049 ns | 0.0038 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  13.99 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  29.29 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.99 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.82 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                                             From_Char |  15.03 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
                                    From_Char_AsObject |  29.61 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.61 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.60 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.78 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.45 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                         From_DateTime |  14.88 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.07 ns | 0.0318 ns | 0.0248 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.13 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.43 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                          From_Decimal |  29.12 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.08 ns | 0.0235 ns | 0.0209 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  31.68 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.09 ns | 0.0267 ns | 0.0237 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.61 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.70 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                                           From_Double |  19.35 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                                  From_Double_AsObject |  32.07 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.46 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.12 ns | 0.0729 ns | 0.0682 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.27 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.83 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                            From_Short |  16.13 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
                                   From_Short_AsObject |  29.61 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.69 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.61 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.63 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.07 ns | 0.0089 ns | 0.0084 ns |      - |       0 B |
                                              From_Int |  16.14 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                     From_Int_AsObject |  29.64 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.70 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.65 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.69 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.86 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
                                             From_Long |  16.14 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                    From_Long_AsObject |  29.65 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.50 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.64 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.50 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.43 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                            From_SByte |  15.65 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.82 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.08 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.86 ns | 0.0348 ns | 0.0325 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.69 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.86 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                                            From_Float |  19.87 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                   From_Float_AsObject |  32.60 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.65 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.57 ns | 0.0417 ns | 0.0390 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.48 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  26.49 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                                           From_String |  95.35 ns | 0.0435 ns | 0.0386 ns |      - |       0 B |
                                  From_String_AsObject | 106.64 ns | 0.0525 ns | 0.0491 ns |      - |       0 B |
                                      From_String_Null |  17.99 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.84 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                     From_String_Empty |  18.12 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.89 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.82 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.71 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.81 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.73 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.02 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                                             From_UInt |  14.82 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.83 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.35 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.81 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.83 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.85 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
                                            From_ULong |  16.68 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.61 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.49 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.61 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.41 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.84 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                                       From_NullObject |  21.15 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                                           From_DBNull |  16.35 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.20 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.08 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  22.09 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.89 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.95 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  24.46 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.95 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.86 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.34 ns | 0.0088 ns | 0.0078 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.45 ns | 0.0269 ns | 0.0238 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.59 ns | 0.0142 ns | 0.0126 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.50 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.09 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.91 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.92 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.38 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.46 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.35 ns | 0.0084 ns | 0.0061 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.48 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.87 ns | 0.0058 ns | 0.0055 ns |      - |       0 B |
                                             From_Enum |  16.13 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.72 ns | 0.0423 ns | 0.0375 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.15 ns | 0.1061 ns | 0.0993 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  62.87 ns | 0.0196 ns | 0.0164 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  17.83 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.73 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                      From_ParentClass |  16.97 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.29 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.95 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  21.33 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                     From_ParentStruct |  16.17 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.92 ns | 0.0017 ns | 0.0012 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.42 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.07 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.54 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.85 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_String_Empty_AsObject: DefaultJob
