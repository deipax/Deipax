
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.72 ns | 0.1469 ns | 0.1302 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.54 ns | 0.0901 ns | 0.0752 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.38 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.50 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.05 ns | 0.0250 ns | 0.0209 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.97 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                             From_Byte |  14.19 ns | 0.0052 ns | 0.0037 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.89 ns | 0.1096 ns | 0.0916 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.84 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.84 ns | 0.0111 ns | 0.0093 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.27 ns | 0.0364 ns | 0.0340 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.41 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                                             From_Char |  14.04 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.06 ns | 0.0116 ns | 0.0091 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.97 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.40 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                                         From_DateTime |  14.53 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.96 ns | 0.0469 ns | 0.0439 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.93 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.05 ns | 0.0405 ns | 0.0359 ns |      - |       0 B |
                                          From_Decimal |  22.61 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
                                 From_Decimal_AsObject |  83.22 ns | 0.1761 ns | 0.1562 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  41.31 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  83.22 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.35 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.50 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
                                           From_Double |  14.02 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
                                  From_Double_AsObject |  26.05 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.62 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  25.90 ns | 0.0809 ns | 0.0757 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.96 ns | 0.0101 ns | 0.0084 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.08 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                                            From_Short |  14.16 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                                   From_Short_AsObject |  26.21 ns | 0.0867 ns | 0.0811 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.81 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.17 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.23 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.54 ns | 0.0447 ns | 0.0418 ns |      - |       0 B |
                                              From_Int |  14.01 ns | 0.0176 ns | 0.0147 ns |      - |       0 B |
                                     From_Int_AsObject |  25.90 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.81 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.95 ns | 0.0751 ns | 0.0703 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.40 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.46 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                                             From_Long |  14.01 ns | 0.0040 ns | 0.0026 ns |      - |       0 B |
                                    From_Long_AsObject |  26.21 ns | 0.0656 ns | 0.0614 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.16 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.10 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.11 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.40 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                            From_SByte |  14.14 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.83 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.80 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.83 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.21 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.93 ns | 0.0091 ns | 0.0071 ns |      - |       0 B |
                                            From_Float |  14.01 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                                   From_Float_AsObject |  18.70 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  15.12 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  17.93 ns | 0.0206 ns | 0.0183 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.55 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.00 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                           From_String | 113.73 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                                  From_String_AsObject | 124.62 ns | 0.0651 ns | 0.0577 ns |      - |       0 B |
                                      From_String_Null |  15.82 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.18 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                     From_String_Empty |  15.97 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.00 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.83 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.81 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.84 ns | 0.0111 ns | 0.0092 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.40 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.40 ns | 0.0057 ns | 0.0044 ns |      - |       0 B |
                                             From_UInt |  14.40 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.10 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  14.81 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.10 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.21 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.47 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                            From_ULong |  14.53 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.64 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.14 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.63 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.48 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.40 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
                                       From_NullObject |  17.40 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.13 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.37 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.15 ns | 0.0070 ns | 0.0059 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.46 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.07 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.75 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.12 ns | 0.0035 ns | 0.0028 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.07 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.91 ns | 0.0298 ns | 0.0279 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.01 ns | 0.0131 ns | 0.0117 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.40 ns | 0.0070 ns | 0.0059 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.03 ns | 0.0301 ns | 0.0281 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.82 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.01 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.84 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.01 ns | 0.0195 ns | 0.0172 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.75 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.01 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.41 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                             From_Enum |  14.00 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
                                    From_Enum_AsObject |  58.38 ns | 0.0506 ns | 0.0474 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  16.95 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  58.21 ns | 0.0579 ns | 0.0542 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.79 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.41 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                                      From_ParentClass |  16.03 ns | 0.0157 ns | 0.0131 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.37 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.99 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.41 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                     From_ParentStruct |  15.73 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.28 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.01 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.42 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.02 ns | 0.0118 ns | 0.0104 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.41 ns | 0.0153 ns | 0.0144 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Float.From_Char_AsObject: DefaultJob
  ConvertTo2_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_String_Empty_AsObject: DefaultJob
