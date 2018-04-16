
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.75 ns | 0.0456 ns | 0.0356 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.63 ns | 0.1137 ns | 0.1064 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.49 ns | 0.0028 ns | 0.0021 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.58 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.89 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.88 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                                             From_Byte |  14.11 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.58 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.84 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.59 ns | 0.0236 ns | 0.0221 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.95 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.36 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                                             From_Char |  15.40 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
                                    From_Char_AsObject |  26.44 ns | 0.0968 ns | 0.0905 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.67 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.39 ns | 0.0402 ns | 0.0357 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.98 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.54 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                         From_DateTime |  14.67 ns | 0.1076 ns | 0.1006 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.81 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.81 ns | 0.0286 ns | 0.0224 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.55 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                                          From_Decimal |  24.33 ns | 0.0286 ns | 0.0254 ns |      - |       0 B |
                                 From_Decimal_AsObject |  44.57 ns | 0.0315 ns | 0.0279 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.00 ns | 0.0366 ns | 0.0285 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.43 ns | 0.0259 ns | 0.0216 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.80 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.89 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                                           From_Double |  16.57 ns | 0.0104 ns | 0.0081 ns |      - |       0 B |
                                  From_Double_AsObject |  27.47 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.87 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  27.66 ns | 0.0320 ns | 0.0300 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.91 ns | 0.0116 ns | 0.0090 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.43 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                            From_Short |  14.13 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                   From_Short_AsObject |  25.57 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.93 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.57 ns | 0.0126 ns | 0.0106 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.95 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.49 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                              From_Int |  14.39 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                     From_Int_AsObject |  17.77 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.41 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  17.79 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.25 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.44 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                             From_Long |  15.46 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                    From_Long_AsObject |  27.30 ns | 0.0521 ns | 0.0488 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.64 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.30 ns | 0.0653 ns | 0.0610 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.88 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.41 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                                            From_SByte |  14.12 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.57 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.33 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.59 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.96 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.42 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                                            From_Float |  16.53 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
                                   From_Float_AsObject |  27.75 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.46 ns | 0.0136 ns | 0.0128 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  27.71 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.98 ns | 0.0047 ns | 0.0034 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.88 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                           From_String |  93.28 ns | 0.0343 ns | 0.0287 ns |      - |       0 B |
                                  From_String_AsObject | 103.49 ns | 0.0589 ns | 0.0522 ns |      - |       0 B |
                                      From_String_Null |  15.58 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.42 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                     From_String_Empty |  16.01 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.42 ns | 0.0639 ns | 0.0499 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.58 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.85 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.59 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.70 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  19.39 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                             From_UInt |  14.66 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.10 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.18 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.10 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.05 ns | 0.0081 ns | 0.0067 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  20.14 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                            From_ULong |  14.94 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.91 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.39 ns | 0.0209 ns | 0.0185 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.91 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.88 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.43 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                       From_NullObject |  18.26 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                                           From_DBNull |  15.07 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.08 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.51 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  24.91 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.03 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.48 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.58 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.90 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.41 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.58 ns | 0.0045 ns | 0.0040 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.74 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.73 ns | 0.0043 ns | 0.0038 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.74 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.95 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.43 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.14 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.55 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.88 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.56 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.90 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                                             From_Enum |  14.40 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.29 ns | 0.0731 ns | 0.0648 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.91 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.28 ns | 0.0359 ns | 0.0299 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.68 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.42 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                                      From_ParentClass |  15.89 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.18 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.97 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.80 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                     From_ParentStruct |  14.16 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.84 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.89 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.24 ns | 0.0156 ns | 0.0139 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.89 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.43 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Int.From_String_Empty_AsObject: DefaultJob
