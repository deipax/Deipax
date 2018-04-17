
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  17.32 ns | 0.0954 ns | 0.0845 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.24 ns | 0.0526 ns | 0.0440 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.49 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  31.21 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.47 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.68 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                                             From_Byte |  16.16 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                                    From_Byte_AsObject |  31.21 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.96 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  31.22 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.49 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.67 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                                             From_Char |  16.15 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.61 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.61 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.69 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                         From_DateTime |  15.60 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.89 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.89 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.69 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                          From_Decimal |  23.07 ns | 0.0707 ns | 0.0661 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.92 ns | 0.0483 ns | 0.0452 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  28.39 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.88 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.85 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.74 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                                           From_Double |  16.43 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                  From_Double_AsObject |  31.41 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  16.42 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.06 ns | 0.0431 ns | 0.0382 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.42 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.69 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                                            From_Short |  17.24 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                                   From_Short_AsObject |  31.53 ns | 0.0292 ns | 0.0273 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.42 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.50 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.88 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  19.08 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                                              From_Int |  15.84 ns | 0.0183 ns | 0.0162 ns |      - |       0 B |
                                     From_Int_AsObject |  31.24 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.54 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.27 ns | 0.0218 ns | 0.0182 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.89 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.69 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
                                             From_Long |  16.78 ns | 0.0035 ns | 0.0030 ns |      - |       0 B |
                                    From_Long_AsObject |  31.50 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.22 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.49 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.29 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.68 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                                            From_SByte |  17.76 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                   From_SByte_AsObject |  31.24 ns | 0.0541 ns | 0.0423 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.97 ns | 0.0041 ns | 0.0035 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  31.26 ns | 0.0318 ns | 0.0297 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  16.54 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.68 ns | 0.0071 ns | 0.0055 ns |      - |       0 B |
                                            From_Float |  17.50 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                   From_Float_AsObject |  31.25 ns | 0.0292 ns | 0.0273 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  16.42 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  31.24 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.89 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.70 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                                           From_String | 114.40 ns | 0.0560 ns | 0.0524 ns |      - |       0 B |
                                  From_String_AsObject | 128.00 ns | 0.0807 ns | 0.0755 ns |      - |       0 B |
                                      From_String_Null |  17.76 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.70 ns | 0.0187 ns | 0.0156 ns |      - |       0 B |
                                     From_String_Empty |  17.94 ns | 0.0082 ns | 0.0076 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.19 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
                                  From_UShort_AsObject |  31.24 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.42 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  31.25 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.89 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.69 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                             From_UInt |  16.29 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                    From_UInt_AsObject |  31.52 ns | 0.0294 ns | 0.0261 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.43 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  31.50 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.88 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.78 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                            From_ULong |  17.79 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.05 ns | 0.0347 ns | 0.0325 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.52 ns | 0.0103 ns | 0.0092 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  32.04 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.57 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.68 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                       From_NullObject |  18.69 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                                           From_DBNull |  17.75 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                 From_ConvertibleClass |  29.78 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  29.10 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  21.75 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  19.39 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.83 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.36 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.96 ns | 0.0175 ns | 0.0136 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.69 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.21 ns | 0.0110 ns | 0.0102 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.41 ns | 0.0244 ns | 0.0217 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.87 ns | 0.0046 ns | 0.0036 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.40 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.50 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  19.38 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.13 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.33 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.13 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  26.09 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.13 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.68 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
                                             From_Enum |  15.57 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                    From_Enum_AsObject |  65.49 ns | 0.0145 ns | 0.0121 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.63 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  65.63 ns | 0.0081 ns | 0.0072 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.67 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.68 ns | 0.0133 ns | 0.0104 ns |      - |       0 B |
                                      From_ParentClass |  17.84 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                             From_ParentClass_AsObject |  29.16 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.83 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.68 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                     From_ParentStruct |  16.13 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  26.36 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.13 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.95 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.97 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.68 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_String_Empty_AsObject: DefaultJob
