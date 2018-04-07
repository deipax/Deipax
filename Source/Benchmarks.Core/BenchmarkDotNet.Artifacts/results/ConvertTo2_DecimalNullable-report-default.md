
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  22.74 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                 From_Bool_AsObject |  36.12 ns | 0.0727 ns | 0.0680 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  26.48 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  36.51 ns | 0.0618 ns | 0.0548 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  15.95 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.43 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
                                          From_Byte |  22.48 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
                                 From_Byte_AsObject |  36.14 ns | 0.0667 ns | 0.0624 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  25.95 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  36.04 ns | 0.0360 ns | 0.0319 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.33 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.40 ns | 0.0286 ns | 0.0267 ns |      - |       0 B |
                                          From_Char |  15.35 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  15.22 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  15.09 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.77 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                                      From_DateTime |  15.51 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                             From_DateTime_AsObject |  28.80 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  15.85 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  24.27 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  15.88 ns | 0.0442 ns | 0.0413 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.43 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
                                       From_Decimal |  16.90 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                              From_Decimal_AsObject |  30.51 ns | 0.0260 ns | 0.0244 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  15.85 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  31.26 ns | 0.0726 ns | 0.0606 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  17.11 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.53 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                        From_Double |  86.69 ns | 0.0207 ns | 0.0184 ns |      - |       0 B |
                               From_Double_AsObject | 103.63 ns | 0.0514 ns | 0.0481 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  89.35 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 103.45 ns | 0.0340 ns | 0.0302 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.93 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.52 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                                         From_Short |  22.48 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                                From_Short_AsObject |  36.33 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  25.94 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  36.43 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  16.17 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.08 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                           From_Int |  22.75 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                  From_Int_AsObject |  36.40 ns | 0.0163 ns | 0.0145 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  25.94 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  36.37 ns | 0.0304 ns | 0.0270 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.18 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.36 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                          From_Long |  22.74 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                 From_Long_AsObject |  36.58 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  26.76 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  37.10 ns | 0.0168 ns | 0.0140 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  16.95 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.35 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
                                         From_SByte |  22.48 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                From_SByte_AsObject |  36.30 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  25.96 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  36.31 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  17.18 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.50 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                                         From_Float |  44.02 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
                                From_Float_AsObject |  61.01 ns | 0.0799 ns | 0.0747 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  48.20 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  63.47 ns | 0.0535 ns | 0.0447 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  17.28 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.95 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                                        From_String | 129.65 ns | 0.0656 ns | 0.0613 ns |      - |       0 B |
                               From_String_AsObject | 148.10 ns | 0.0109 ns | 0.0085 ns |      - |       0 B |
                                   From_String_Null |  15.87 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.34 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                                  From_String_Empty |  15.86 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
                         From_String_Empty_AsObject |  26.89 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                        From_UShort |  22.48 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                               From_UShort_AsObject |  38.46 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  26.21 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  36.34 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  16.19 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.69 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                                          From_UInt |  22.49 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                 From_UInt_AsObject |  35.84 ns | 0.0765 ns | 0.0715 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  25.93 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  35.83 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  16.17 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.36 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                                         From_ULong |  22.48 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                                From_ULong_AsObject |  38.15 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  26.77 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  35.85 ns | 0.0253 ns | 0.0224 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  16.93 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  20.22 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
                                    From_NullObject |  17.33 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                        From_DBNull |  15.59 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                              From_ConvertibleClass |  30.25 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  33.38 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  19.21 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.35 ns | 0.0229 ns | 0.0215 ns |      - |       0 B |
                             From_ConvertibleStruct |  25.68 ns | 0.0282 ns | 0.0264 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  34.43 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  29.04 ns | 0.0175 ns | 0.0155 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  34.44 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  15.97 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.35 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                          From_Enum |  22.21 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                                 From_Enum_AsObject |  71.46 ns | 0.0853 ns | 0.0798 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  25.94 ns | 0.0019 ns | 0.0014 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  71.23 ns | 0.0502 ns | 0.0469 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.96 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.68 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
