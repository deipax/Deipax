
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  16.31 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
                                 From_Bool_AsObject |  30.35 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  20.40 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  30.40 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.34 ns | 0.0110 ns | 0.0092 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.68 ns | 0.0102 ns | 0.0080 ns |      - |       0 B |
                                          From_Byte |  16.08 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                                 From_Byte_AsObject |  30.40 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  19.39 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  30.44 ns | 0.0427 ns | 0.0400 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.33 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.74 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                          From_Char |  15.51 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  15.20 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  14.94 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.72 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                                      From_DateTime |  15.25 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  16.25 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.30 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  18.70 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                                       From_Decimal |  15.56 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                              From_Decimal_AsObject |  19.47 ns | 0.0340 ns | 0.0301 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  25.72 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  19.91 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  25.11 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.91 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |
                                        From_Double |  75.22 ns | 0.0459 ns | 0.0429 ns |      - |       0 B |
                               From_Double_AsObject |  86.07 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  78.62 ns | 0.0666 ns | 0.0623 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  86.15 ns | 0.0968 ns | 0.0858 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.85 ns | 0.0094 ns | 0.0074 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  19.84 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                         From_Short |  16.57 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
                                From_Short_AsObject |  30.95 ns | 0.0267 ns | 0.0223 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.13 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  31.04 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  16.08 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.73 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                           From_Int |  15.55 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                  From_Int_AsObject |  30.61 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  19.13 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  30.69 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.20 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.72 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                          From_Long |  15.55 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                                 From_Long_AsObject |  30.92 ns | 0.0261 ns | 0.0218 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  20.43 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  32.27 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  17.86 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.69 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                                         From_SByte |  16.06 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                                From_SByte_AsObject |  30.69 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  19.39 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  30.59 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  17.35 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  18.75 ns | 0.0338 ns | 0.0299 ns |      - |       0 B |
                                         From_Float |  36.30 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                                From_Float_AsObject |  47.66 ns | 0.0527 ns | 0.0493 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  39.75 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  47.51 ns | 0.0783 ns | 0.0732 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  16.08 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  19.49 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                        From_String | 123.79 ns | 0.0235 ns | 0.0184 ns |      - |       0 B |
                               From_String_AsObject | 136.35 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
                                   From_String_Null |  17.92 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                          From_String_Null_AsObject |  19.79 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                                  From_String_Empty |  21.72 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  16.06 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                               From_UShort_AsObject |  30.59 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  20.16 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  30.64 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  16.21 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.69 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                                          From_UInt |  15.17 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                                 From_UInt_AsObject |  30.25 ns | 0.4008 ns | 0.3346 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.89 ns | 0.0362 ns | 0.0339 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  30.13 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  17.10 ns | 0.0033 ns | 0.0025 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.74 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                         From_ULong |  15.19 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                                From_ULong_AsObject |  30.18 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  19.96 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  30.15 ns | 0.0244 ns | 0.0229 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  17.88 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.75 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
                                    From_NullObject |  18.74 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                                        From_DBNull |  17.63 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                              From_ConvertibleClass |  26.93 ns | 0.0335 ns | 0.0313 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.83 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  19.04 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.71 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.48 ns | 0.0173 ns | 0.0161 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.07 ns | 0.0272 ns | 0.0254 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  29.40 ns | 0.0210 ns | 0.0186 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.48 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  17.25 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.70 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                          From_Enum |  15.58 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                 From_Enum_AsObject |  61.93 ns | 0.0453 ns | 0.0402 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  19.13 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  61.70 ns | 0.0082 ns | 0.0068 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  17.37 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.74 ns | 0.0161 ns | 0.0135 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo2_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_String_Empty_AsObject: DefaultJob
