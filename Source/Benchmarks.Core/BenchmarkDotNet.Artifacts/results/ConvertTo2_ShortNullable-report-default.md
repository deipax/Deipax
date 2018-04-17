
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.88 ns | 0.0799 ns | 0.0748 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.28 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.08 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.29 ns | 0.0333 ns | 0.0296 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.48 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.03 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                             From_Byte |  17.03 ns | 0.0145 ns | 0.0135 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.26 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.82 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.25 ns | 0.0152 ns | 0.0134 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.63 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.85 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                                             From_Char |  15.24 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
                                    From_Char_AsObject |  29.60 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.60 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.61 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.66 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.84 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                         From_DateTime |  14.89 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.11 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.09 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.83 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                          From_Decimal |  29.06 ns | 0.0095 ns | 0.0074 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.51 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  31.79 ns | 0.0045 ns | 0.0027 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.49 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.61 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.02 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                           From_Double |  19.09 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                  From_Double_AsObject |  32.48 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.45 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.40 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.40 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.83 ns | 0.0143 ns | 0.0133 ns |      - |       0 B |
                                            From_Short |  14.56 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                   From_Short_AsObject |  29.44 ns | 0.0207 ns | 0.0184 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.97 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.39 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.99 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.12 ns | 0.0157 ns | 0.0146 ns |      - |       0 B |
                                              From_Int |  16.13 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                                     From_Int_AsObject |  29.59 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.68 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.60 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.81 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.82 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                             From_Long |  16.95 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
                                    From_Long_AsObject |  29.59 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.49 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.59 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.49 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.01 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                            From_SByte |  14.65 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.26 ns | 0.0240 ns | 0.0224 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.86 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.26 ns | 0.0187 ns | 0.0166 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.56 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.37 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                                            From_Float |  19.54 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                   From_Float_AsObject |  32.28 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.64 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.31 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.44 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.63 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                           From_String |  96.17 ns | 0.0631 ns | 0.0560 ns |      - |       0 B |
                                  From_String_AsObject | 106.80 ns | 0.0612 ns | 0.0543 ns |      - |       0 B |
                                      From_String_Null |  17.53 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.02 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                     From_String_Empty |  17.76 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.88 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.80 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.90 ns | 0.0182 ns | 0.0171 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.82 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  17.86 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.83 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                             From_UInt |  16.81 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.61 ns | 0.0288 ns | 0.0270 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.26 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.61 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.37 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.89 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                            From_ULong |  16.14 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.61 ns | 0.0264 ns | 0.0221 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.50 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.61 ns | 0.0222 ns | 0.0207 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.42 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.02 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                       From_NullObject |  18.02 ns | 0.0035 ns | 0.0030 ns |      - |       0 B |
                                           From_DBNull |  15.91 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.30 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.09 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.34 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.88 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.39 ns | 0.0053 ns | 0.0035 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  28.90 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.95 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.84 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.20 ns | 0.0196 ns | 0.0183 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.43 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.58 ns | 0.0156 ns | 0.0146 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.43 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.11 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.25 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.43 ns | 0.0058 ns | 0.0045 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.84 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.41 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.11 ns | 0.0118 ns | 0.0092 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.43 ns | 0.0045 ns | 0.0039 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.35 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                             From_Enum |  16.13 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.87 ns | 0.0551 ns | 0.0516 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.92 ns | 0.0312 ns | 0.0277 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.85 ns | 0.0441 ns | 0.0413 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.07 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.43 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
                                      From_ParentClass |  16.95 ns | 0.0077 ns | 0.0065 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.68 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.76 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.02 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
                                     From_ParentStruct |  14.40 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.92 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.46 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.47 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.41 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.39 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_String_Empty_AsObject: DefaultJob
