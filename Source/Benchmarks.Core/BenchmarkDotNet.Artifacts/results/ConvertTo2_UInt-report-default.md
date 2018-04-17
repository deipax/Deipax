
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.53 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                                    From_Bool_AsObject | 25.96 ns | 0.1450 ns | 0.1286 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 15.34 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 25.85 ns | 0.0217 ns | 0.0170 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.40 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.36 ns | 0.0313 ns | 0.0277 ns |      - |       0 B |
                                             From_Byte | 13.98 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                    From_Byte_AsObject | 25.85 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 15.43 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.87 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.22 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 20.09 ns | 0.0121 ns | 0.0095 ns |      - |       0 B |
                                             From_Char | 13.98 ns | 0.0092 ns | 0.0071 ns |      - |       0 B |
                                    From_Char_AsObject | 26.64 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.81 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 26.65 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.21 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.34 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
                                         From_DateTime | 14.53 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.96 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.96 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.35 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                                          From_Decimal | 25.78 ns | 0.0165 ns | 0.0119 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.34 ns | 0.0842 ns | 0.0746 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 28.72 ns | 0.0390 ns | 0.0326 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.32 ns | 0.0879 ns | 0.0822 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.35 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.39 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                           From_Double | 16.05 ns | 0.0333 ns | 0.0295 ns |      - |       0 B |
                                  From_Double_AsObject | 27.63 ns | 0.0487 ns | 0.0322 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.84 ns | 0.0599 ns | 0.0560 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 27.51 ns | 0.0946 ns | 0.0885 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.00 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.37 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
                                            From_Short | 14.58 ns | 0.0481 ns | 0.0450 ns |      - |       0 B |
                                   From_Short_AsObject | 26.37 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.44 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.38 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.26 ns | 0.0535 ns | 0.0500 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.43 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                                              From_Int | 14.55 ns | 0.0067 ns | 0.0044 ns |      - |       0 B |
                                     From_Int_AsObject | 27.40 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.43 ns | 0.0410 ns | 0.0342 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.37 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.40 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.41 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                             From_Long | 15.34 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                                    From_Long_AsObject | 27.18 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 17.50 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 27.20 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.83 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.34 ns | 0.0061 ns | 0.0048 ns |      - |       0 B |
                                            From_SByte | 14.54 ns | 0.0480 ns | 0.0449 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.37 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 15.35 ns | 0.0098 ns | 0.0081 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.47 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.23 ns | 0.0141 ns | 0.0117 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.35 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
                                            From_Float | 16.30 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                                   From_Float_AsObject | 27.72 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.96 ns | 0.0112 ns | 0.0087 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 27.72 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.23 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.34 ns | 0.0115 ns | 0.0090 ns |      - |       0 B |
                                           From_String | 88.83 ns | 0.0311 ns | 0.0260 ns |      - |       0 B |
                                  From_String_AsObject | 99.34 ns | 0.0440 ns | 0.0390 ns |      - |       0 B |
                                      From_String_Null | 15.65 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.42 ns | 0.0579 ns | 0.0542 ns |      - |       0 B |
                                     From_String_Empty | 16.81 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.99 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.96 ns | 0.0860 ns | 0.0804 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.83 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.90 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.42 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.36 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
                                             From_UInt | 14.68 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                                    From_UInt_AsObject | 18.82 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.52 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 18.56 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.53 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.40 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                            From_ULong | 14.53 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.38 ns | 0.0141 ns | 0.0110 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.19 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 29.78 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.92 ns | 0.1203 ns | 0.1125 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.37 ns | 0.0098 ns | 0.0081 ns |      - |       0 B |
                                       From_NullObject | 17.87 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                                           From_DBNull | 15.34 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                 From_ConvertibleClass | 24.31 ns | 0.0514 ns | 0.0481 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 23.68 ns | 0.0199 ns | 0.0167 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 21.26 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.42 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.22 ns | 0.0098 ns | 0.0077 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 21.56 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.03 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.35 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                From_ConvertibleStruct | 24.03 ns | 0.0525 ns | 0.0466 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.05 ns | 0.0392 ns | 0.0366 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.56 ns | 0.0061 ns | 0.0047 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.08 ns | 0.0661 ns | 0.0618 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.83 ns | 0.0411 ns | 0.0384 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.35 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.02 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 23.96 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.00 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.58 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.02 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.37 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                             From_Enum | 14.54 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
                                    From_Enum_AsObject | 58.52 ns | 0.0434 ns | 0.0406 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 16.96 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 58.78 ns | 0.0398 ns | 0.0373 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.80 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.83 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                      From_ParentClass | 16.01 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.08 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.98 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.22 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                     From_ParentStruct | 14.00 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 22.66 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.00 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.23 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.99 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.34 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UInt.From_String_Empty_AsObject: DefaultJob
