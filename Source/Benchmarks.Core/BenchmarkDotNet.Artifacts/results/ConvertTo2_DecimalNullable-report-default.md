
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  23.67 ns | 0.1371 ns | 0.1215 ns |      - |       0 B |
                                    From_Bool_AsObject |  32.50 ns | 0.0424 ns | 0.0376 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  27.05 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  33.46 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.22 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  21.00 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                             From_Byte |  23.30 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                                    From_Byte_AsObject |  32.48 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  31.62 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  32.40 ns | 0.0347 ns | 0.0290 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.23 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.72 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                             From_Char |  16.39 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  16.17 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.72 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.72 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                         From_DateTime |  15.86 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.86 ns | 0.0099 ns | 0.0087 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.21 ns | 0.0076 ns | 0.0064 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.72 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                                          From_Decimal |  17.49 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                 From_Decimal_AsObject |  32.49 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  16.68 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.99 ns | 0.0286 ns | 0.0268 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.68 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.71 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                           From_Double |  85.86 ns | 0.0620 ns | 0.0580 ns |      - |       0 B |
                                  From_Double_AsObject |  99.75 ns | 0.0452 ns | 0.0401 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  90.94 ns | 0.0468 ns | 0.0415 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  99.96 ns | 0.0926 ns | 0.0866 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  17.20 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.76 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
                                            From_Short |  23.28 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                                   From_Short_AsObject |  32.49 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  26.75 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  32.81 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.82 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.73 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                                              From_Int |  23.28 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
                                     From_Int_AsObject |  33.00 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  26.78 ns | 0.0281 ns | 0.0234 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  32.76 ns | 0.0330 ns | 0.0309 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  17.82 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  19.39 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                             From_Long |  23.54 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                                    From_Long_AsObject |  32.77 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  26.77 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  33.37 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  18.30 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.30 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                            From_SByte |  23.27 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                                   From_SByte_AsObject |  33.09 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  27.58 ns | 0.0270 ns | 0.0239 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.76 ns | 0.0345 ns | 0.0322 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.21 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  21.03 ns | 0.0129 ns | 0.0107 ns |      - |       0 B |
                                            From_Float |  46.88 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                   From_Float_AsObject |  59.37 ns | 0.0768 ns | 0.0641 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  50.21 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  59.66 ns | 0.1000 ns | 0.0935 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.84 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  20.05 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                           From_String | 131.39 ns | 0.0991 ns | 0.0927 ns |      - |       0 B |
                                  From_String_AsObject | 144.87 ns | 0.0530 ns | 0.0469 ns |      - |       0 B |
                                      From_String_Null |  17.49 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.73 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                                     From_String_Empty |  18.09 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  28.12 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                  From_UShort_AsObject |  32.63 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  26.49 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  34.14 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  18.71 ns | 0.0274 ns | 0.0256 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.72 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                                             From_UInt |  23.54 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                                    From_UInt_AsObject |  32.46 ns | 0.0245 ns | 0.0217 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  26.48 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.44 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.82 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.72 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                            From_ULong |  23.81 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.71 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  26.77 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  33.28 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.21 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.75 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                       From_NullObject |  19.20 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                           From_DBNull |  17.47 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                 From_ConvertibleClass |  29.20 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  30.67 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.83 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.68 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.84 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.73 ns | 0.6795 ns | 0.6978 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.80 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.74 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.24 ns | 0.0094 ns | 0.0088 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  31.68 ns | 0.0193 ns | 0.0161 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  30.16 ns | 0.0261 ns | 0.0244 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  31.49 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.23 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  21.05 ns | 0.0214 ns | 0.0179 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.86 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.31 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.25 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.33 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.86 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.72 ns | 0.0069 ns | 0.0062 ns |      - |       0 B |
                                             From_Enum |  23.29 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
                                    From_Enum_AsObject |  66.63 ns | 0.0595 ns | 0.0527 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  26.51 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  66.22 ns | 0.0546 ns | 0.0511 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.93 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.73 ns | 0.0034 ns | 0.0022 ns |      - |       0 B |
                                      From_ParentClass |  17.88 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                             From_ParentClass_AsObject |  26.06 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.81 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.72 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                     From_ParentStruct |  15.88 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.86 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.87 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.72 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.88 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.99 ns | 0.5604 ns | 0.5504 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_String_Empty_AsObject: DefaultJob
