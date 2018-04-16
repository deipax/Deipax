
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.69 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.69 ns | 0.1305 ns | 0.1220 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.48 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.64 ns | 0.0684 ns | 0.0606 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.28 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.30 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                                             From_Byte |  14.12 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.75 ns | 0.0361 ns | 0.0320 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.83 ns | 0.0134 ns | 0.0126 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.63 ns | 0.0749 ns | 0.0664 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.93 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.28 ns | 0.0401 ns | 0.0375 ns |      - |       0 B |
                                             From_Char |  14.11 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                                    From_Char_AsObject |  26.40 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.73 ns | 0.0520 ns | 0.0486 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.41 ns | 0.0302 ns | 0.0268 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.93 ns | 0.0060 ns | 0.0043 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.28 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
                                         From_DateTime |  14.77 ns | 0.0150 ns | 0.0117 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.85 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.82 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.29 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                          From_Decimal |  27.39 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                                 From_Decimal_AsObject |  44.73 ns | 0.0519 ns | 0.0406 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  35.37 ns | 0.0898 ns | 0.0796 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.67 ns | 0.0724 ns | 0.0677 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.16 ns | 0.0411 ns | 0.0364 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.14 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                           From_Double |  18.02 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
                                  From_Double_AsObject |  30.45 ns | 0.0437 ns | 0.0408 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.51 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.45 ns | 0.0803 ns | 0.0712 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.75 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  20.09 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                                            From_Short |  14.11 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                   From_Short_AsObject |  25.57 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.65 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.57 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.94 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.41 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
                                              From_Int |  14.38 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                     From_Int_AsObject |  25.57 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.65 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.58 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.68 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.49 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                             From_Long |  14.40 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
                                    From_Long_AsObject |  17.84 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.10 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  17.78 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.07 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.26 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                            From_SByte |  14.12 ns | 0.0148 ns | 0.0123 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.56 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.82 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.56 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.94 ns | 0.0131 ns | 0.0117 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.26 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                                            From_Float |  18.01 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                   From_Float_AsObject |  30.68 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.98 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.70 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.04 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.26 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                                           From_String |  91.01 ns | 0.0581 ns | 0.0543 ns |      - |       0 B |
                                  From_String_AsObject | 103.18 ns | 0.2314 ns | 0.1932 ns |      - |       0 B |
                                      From_String_Null |  15.38 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.88 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                     From_String_Empty |  16.90 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.41 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.56 ns | 0.0095 ns | 0.0074 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.82 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.57 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.67 ns | 0.0087 ns | 0.0078 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.27 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
                                             From_UInt |  14.11 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                                    From_UInt_AsObject |  25.57 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.82 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.71 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.97 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.33 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
                                            From_ULong |  14.67 ns | 0.0100 ns | 0.0078 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.37 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.02 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.37 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.87 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.28 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                                       From_NullObject |  17.25 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
                                           From_DBNull |  15.07 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                 From_ConvertibleClass |  23.96 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.40 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.49 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.87 ns | 0.0430 ns | 0.0402 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.95 ns | 0.0267 ns | 0.0236 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.64 ns | 0.0220 ns | 0.0195 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.87 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.29 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.60 ns | 0.0097 ns | 0.0091 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.76 ns | 0.0067 ns | 0.0052 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.83 ns | 0.0093 ns | 0.0087 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.76 ns | 0.0301 ns | 0.0281 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.96 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.16 ns | 0.0142 ns | 0.0132 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.62 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.89 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.74 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.90 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.28 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                             From_Enum |  14.39 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                                    From_Enum_AsObject |  58.12 ns | 0.0329 ns | 0.0292 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.66 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  58.14 ns | 0.0359 ns | 0.0336 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.68 ns | 0.0086 ns | 0.0077 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.27 ns | 0.0151 ns | 0.0142 ns |      - |       0 B |
                                      From_ParentClass |  15.92 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.04 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.14 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.27 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
                                     From_ParentStruct |  14.80 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.16 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.89 ns | 0.0126 ns | 0.0106 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.48 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.96 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.29 ns | 0.0225 ns | 0.0188 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
