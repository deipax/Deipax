
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.83 ns | 0.0602 ns | 0.0534 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.36 ns | 0.1481 ns | 0.1156 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.09 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.28 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.18 ns | 0.0082 ns | 0.0072 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  19.26 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                             From_Byte |  15.42 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.28 ns | 0.0170 ns | 0.0150 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.89 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.28 ns | 0.0353 ns | 0.0312 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.60 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.43 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                             From_Char |  14.49 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                    From_Char_AsObject |  29.12 ns | 0.0394 ns | 0.0368 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.98 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.08 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.70 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.07 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
                                         From_DateTime |  15.04 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.22 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.91 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.84 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                          From_Decimal |  27.87 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                                 From_Decimal_AsObject |  38.55 ns | 0.0562 ns | 0.0469 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  30.57 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.52 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.62 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.47 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                                           From_Double |  17.45 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                  From_Double_AsObject |  29.91 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  18.31 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.90 ns | 0.0339 ns | 0.0317 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.42 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.01 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                            From_Short |  14.81 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                   From_Short_AsObject |  28.80 ns | 0.0294 ns | 0.0229 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.22 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.80 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.86 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  19.24 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                              From_Int |  16.41 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                                     From_Int_AsObject |  28.80 ns | 0.0268 ns | 0.0251 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.68 ns | 0.0064 ns | 0.0056 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  28.79 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.05 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.83 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                             From_Long |  16.14 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
                                    From_Long_AsObject |  29.60 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.49 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.62 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.57 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.35 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                                            From_SByte |  14.83 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.83 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.15 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.88 ns | 0.0267 ns | 0.0236 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.10 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.86 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                            From_Float |  18.13 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                   From_Float_AsObject |  30.16 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  17.51 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.14 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.56 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.85 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                                           From_String |  90.35 ns | 0.1075 ns | 0.0953 ns |      - |       0 B |
                                  From_String_AsObject | 102.64 ns | 0.0488 ns | 0.0456 ns |      - |       0 B |
                                      From_String_Null |  16.35 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.17 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                                     From_String_Empty |  16.69 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.45 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.25 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.84 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.26 ns | 0.0152 ns | 0.0119 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.67 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.49 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                             From_UInt |  14.46 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.56 ns | 0.0183 ns | 0.0162 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.20 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.90 ns | 0.0175 ns | 0.0146 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.00 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.35 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                                            From_ULong |  15.51 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.82 ns | 0.0494 ns | 0.0462 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.14 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.79 ns | 0.0111 ns | 0.0092 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.50 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.72 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                       From_NullObject |  18.58 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                           From_DBNull |  15.75 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.42 ns | 0.0243 ns | 0.0228 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.10 ns | 0.0197 ns | 0.0164 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  20.60 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.07 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.99 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.14 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.95 ns | 0.0133 ns | 0.0104 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.36 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.21 ns | 0.0086 ns | 0.0080 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.44 ns | 0.0161 ns | 0.0142 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.63 ns | 0.0308 ns | 0.0288 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.44 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.33 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.83 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.47 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.16 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.44 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.20 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.40 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.71 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                             From_Enum |  14.81 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.98 ns | 0.0487 ns | 0.0432 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.01 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.38 ns | 0.0404 ns | 0.0378 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.09 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.02 ns | 0.0213 ns | 0.0200 ns |      - |       0 B |
                                      From_ParentClass |  17.00 ns | 0.0222 ns | 0.0207 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.50 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.98 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  19.55 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                     From_ParentStruct |  14.55 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.76 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.55 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.22 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.41 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.00 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_String_Empty_AsObject: DefaultJob
