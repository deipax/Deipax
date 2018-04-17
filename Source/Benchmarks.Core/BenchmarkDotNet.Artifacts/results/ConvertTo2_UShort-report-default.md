
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.61 ns | 0.0372 ns | 0.0311 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.86 ns | 0.0527 ns | 0.0440 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.32 ns | 0.0009 ns | 0.0006 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.84 ns | 0.0192 ns | 0.0160 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.38 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.26 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                                             From_Byte |  13.99 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.84 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.78 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.87 ns | 0.0510 ns | 0.0477 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.19 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.27 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                                             From_Char |  13.99 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                    From_Char_AsObject |  26.65 ns | 0.0188 ns | 0.0175 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.79 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.65 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.19 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.75 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                         From_DateTime |  14.53 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.95 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.95 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.32 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                          From_Decimal |  27.24 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.93 ns | 0.0351 ns | 0.0328 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  30.57 ns | 0.0040 ns | 0.0029 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.63 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.33 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.27 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                           From_Double |  18.28 ns | 0.0108 ns | 0.0084 ns |      - |       0 B |
                                  From_Double_AsObject |  29.88 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.17 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.85 ns | 0.0316 ns | 0.0295 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.95 ns | 0.0081 ns | 0.0064 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.28 ns | 0.0046 ns | 0.0027 ns |      - |       0 B |
                                            From_Short |  14.53 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
                                   From_Short_AsObject |  26.37 ns | 0.0125 ns | 0.0110 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.37 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.36 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.20 ns | 0.0082 ns | 0.0072 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.33 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                              From_Int |  15.34 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
                                     From_Int_AsObject |  27.18 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.66 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.17 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.38 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.11 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                                             From_Long |  15.34 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                                    From_Long_AsObject |  27.17 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.47 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.17 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.08 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.81 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                                            From_SByte |  14.53 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.36 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.33 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.37 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.19 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.86 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
                                            From_Float |  18.29 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                                   From_Float_AsObject |  29.88 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.62 ns | 0.0023 ns | 0.0016 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.87 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.19 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.25 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                                           From_String |  90.93 ns | 0.0425 ns | 0.0377 ns |      - |       0 B |
                                  From_String_AsObject | 102.36 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                      From_String_Null |  15.59 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.26 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                                     From_String_Empty |  15.94 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.00 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                  From_UShort_AsObject |  17.78 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.52 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  17.81 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.53 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.34 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                             From_UInt |  14.68 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.38 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.33 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.41 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.21 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.35 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                                            From_ULong |  15.35 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.20 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.74 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.19 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.67 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.28 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                                       From_NullObject |  17.27 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                           From_DBNull |  15.33 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.22 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.68 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.32 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.33 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.05 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  22.09 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.12 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.27 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.14 ns | 0.4119 ns | 0.3853 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.00 ns | 0.0056 ns | 0.0043 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.54 ns | 0.0110 ns | 0.0098 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.01 ns | 0.0173 ns | 0.0153 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  20.50 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.25 ns | 0.0024 ns | 0.0018 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.75 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.58 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.01 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.56 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.00 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                             From_Enum |  15.34 ns | 0.0052 ns | 0.0038 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.55 ns | 0.0329 ns | 0.0308 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.83 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  58.80 ns | 0.0373 ns | 0.0349 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.80 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.27 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
                                      From_ParentClass |  15.99 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.05 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.61 ns | 0.0069 ns | 0.0062 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.36 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                                     From_ParentStruct |  14.00 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.35 ns | 0.0133 ns | 0.0111 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.00 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.89 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.00 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShort.From_String_Empty_AsObject: DefaultJob
