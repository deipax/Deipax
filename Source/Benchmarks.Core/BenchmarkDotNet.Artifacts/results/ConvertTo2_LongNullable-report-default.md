
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  15.80 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
                                 From_Bool_AsObject |  30.65 ns | 0.0457 ns | 0.0405 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  19.88 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  30.64 ns | 0.0303 ns | 0.0284 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.57 ns | 0.0085 ns | 0.0067 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.67 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                                          From_Byte |  15.31 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                 From_Byte_AsObject |  30.62 ns | 0.0038 ns | 0.0025 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  19.39 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  30.64 ns | 0.0358 ns | 0.0318 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.57 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.92 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                          From_Char |  15.30 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                 From_Char_AsObject |  31.83 ns | 0.0057 ns | 0.0045 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  20.16 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  31.82 ns | 0.0402 ns | 0.0376 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  15.85 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.71 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
                                      From_DateTime |  14.78 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  15.57 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.55 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  20.79 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                                       From_Decimal |  25.14 ns | 0.0438 ns | 0.0366 ns |      - |       0 B |
                              From_Decimal_AsObject |  41.50 ns | 0.0636 ns | 0.0595 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  33.20 ns | 0.0246 ns | 0.0219 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  41.89 ns | 0.0049 ns | 0.0039 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  16.84 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.69 ns | 0.0263 ns | 0.0219 ns |      - |       0 B |
                                        From_Double |  19.13 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
                               From_Double_AsObject |  35.58 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  23.59 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  35.51 ns | 0.0239 ns | 0.0224 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.33 ns | 0.0116 ns | 0.0090 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  18.76 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                         From_Short |  15.31 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
                                From_Short_AsObject |  30.63 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.15 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  30.63 ns | 0.0236 ns | 0.0220 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  16.84 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  20.17 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                           From_Int |  14.93 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                                  From_Int_AsObject |  31.78 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  21.60 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  31.79 ns | 0.0266 ns | 0.0223 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.86 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.67 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                          From_Long |  14.94 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
                                 From_Long_AsObject |  32.06 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  15.08 ns | 0.0222 ns | 0.0185 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  31.10 ns | 0.0424 ns | 0.0396 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.08 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.86 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                                         From_SByte |  15.32 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                                From_SByte_AsObject |  30.64 ns | 0.0236 ns | 0.0210 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  19.40 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  30.64 ns | 0.0218 ns | 0.0193 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.58 ns | 0.0142 ns | 0.0119 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  18.83 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                                         From_Float |  19.42 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
                                From_Float_AsObject |  35.51 ns | 0.0085 ns | 0.0056 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  23.75 ns | 0.0318 ns | 0.0298 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  35.48 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  15.83 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.75 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                        From_String |  90.59 ns | 0.1370 ns | 0.1144 ns |      - |       0 B |
                               From_String_AsObject | 104.29 ns | 0.0607 ns | 0.0538 ns |      - |       0 B |
                                   From_String_Null |  17.87 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.68 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                  From_String_Empty |  17.88 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  15.94 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                               From_UShort_AsObject |  30.67 ns | 0.0437 ns | 0.0408 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  19.14 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  30.64 ns | 0.0253 ns | 0.0224 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.82 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.90 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                          From_UInt |  15.19 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                                 From_UInt_AsObject |  30.65 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  19.14 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  30.66 ns | 0.0094 ns | 0.0062 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  15.82 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.72 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                                         From_ULong |  15.95 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
                                From_ULong_AsObject |  31.39 ns | 0.0173 ns | 0.0145 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  20.31 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  32.42 ns | 0.0358 ns | 0.0334 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  16.34 ns | 0.0463 ns | 0.0387 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.72 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                    From_NullObject |  21.00 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                        From_DBNull |  17.87 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                              From_ConvertibleClass |  26.63 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.33 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.68 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  19.04 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                             From_ConvertibleStruct |  25.22 ns | 0.0143 ns | 0.0134 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.59 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.01 ns | 0.0032 ns | 0.0025 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.61 ns | 0.0403 ns | 0.0358 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.59 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  21.23 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                                          From_Enum |  14.93 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                                 From_Enum_AsObject |  62.40 ns | 0.0394 ns | 0.0369 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.62 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  62.61 ns | 0.0209 ns | 0.0174 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  15.83 ns | 0.0121 ns | 0.0094 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.73 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
