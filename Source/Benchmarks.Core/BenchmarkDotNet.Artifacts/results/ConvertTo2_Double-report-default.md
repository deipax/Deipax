
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.46 ns | 0.0409 ns | 0.0363 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.86 ns | 0.0264 ns | 0.0220 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.47 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.85 ns | 0.0235 ns | 0.0209 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.95 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.40 ns | 0.0055 ns | 0.0048 ns |      - |       0 B |
                                             From_Byte |  14.40 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.84 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.00 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.85 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.67 ns | 0.0097 ns | 0.0090 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.40 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |
                                             From_Char |  14.14 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.14 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.88 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.41 ns | 0.0191 ns | 0.0170 ns |      - |       0 B |
                                         From_DateTime |  14.46 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.82 ns | 0.0246 ns | 0.0231 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.81 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.42 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                                          From_Decimal |  20.42 ns | 0.0258 ns | 0.0229 ns |      - |       0 B |
                                 From_Decimal_AsObject |  31.51 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  32.93 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  31.49 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.16 ns | 0.0181 ns | 0.0170 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.25 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                           From_Double |  14.15 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                                  From_Double_AsObject |  17.94 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  14.96 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  18.34 ns | 0.0111 ns | 0.0093 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.08 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.40 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                                            From_Short |  14.40 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                   From_Short_AsObject |  26.11 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.15 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.10 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.67 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.47 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                                              From_Int |  14.11 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                     From_Int_AsObject |  25.83 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.82 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.83 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.93 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.40 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                             From_Long |  14.11 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                    From_Long_AsObject |  26.10 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.75 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.10 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.86 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.40 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                            From_SByte |  14.41 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.84 ns | 0.0145 ns | 0.0121 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.02 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.84 ns | 0.0100 ns | 0.0083 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.68 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.41 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
                                            From_Float |  15.29 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                                   From_Float_AsObject |  25.85 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.28 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  25.84 ns | 0.0269 ns | 0.0225 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.73 ns | 0.0894 ns | 0.0836 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.21 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                                           From_String | 112.06 ns | 0.0638 ns | 0.0533 ns |      - |       0 B |
                                  From_String_AsObject | 122.07 ns | 0.0913 ns | 0.0854 ns |      - |       0 B |
                                      From_String_Null |  16.49 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.48 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                                     From_String_Empty |  16.17 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.14 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.84 ns | 0.0179 ns | 0.0158 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.03 ns | 0.0267 ns | 0.0249 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.85 ns | 0.0285 ns | 0.0253 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.95 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.41 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                             From_UInt |  14.40 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.10 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.01 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.75 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.88 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.85 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                            From_ULong |  14.40 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.64 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.01 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.63 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.86 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.39 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                       From_NullObject |  17.40 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.22 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.68 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.28 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.47 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.02 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.81 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.03 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.40 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.62 ns | 0.0016 ns | 0.0013 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.04 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.57 ns | 0.0071 ns | 0.0063 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.04 ns | 0.0171 ns | 0.0152 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.70 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.43 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.89 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.32 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.14 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.67 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.14 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.03 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                             From_Enum |  14.12 ns | 0.0134 ns | 0.0126 ns |      - |       0 B |
                                    From_Enum_AsObject |  57.62 ns | 0.0228 ns | 0.0213 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  17.65 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  57.60 ns | 0.0133 ns | 0.0111 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  14.95 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.99 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                      From_ParentClass |  16.03 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.25 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.01 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.41 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                     From_ParentStruct |  13.88 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.22 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.16 ns | 0.0156 ns | 0.0145 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.21 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.16 ns | 0.0229 ns | 0.0191 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Double.From_Char_AsObject: DefaultJob
  ConvertTo2_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_String_Empty_AsObject: DefaultJob
