
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 37.42 ns | 0.3378 ns | 0.3160 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject | 50.15 ns | 0.1180 ns | 0.1104 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 37.77 ns | 0.0343 ns | 0.0286 ns | 0.0057 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject | 50.10 ns | 0.0583 ns | 0.0545 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.44 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 15.93 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                             From_Byte | 36.74 ns | 0.0206 ns | 0.0161 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject | 49.86 ns | 0.0789 ns | 0.0738 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 37.55 ns | 0.0547 ns | 0.0512 ns | 0.0057 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject | 50.08 ns | 0.0187 ns | 0.0156 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.75 ns | 0.0490 ns | 0.0458 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 15.95 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                                             From_Char | 35.08 ns | 0.0318 ns | 0.0266 ns | 0.0057 |      24 B |
                                    From_Char_AsObject | 49.40 ns | 0.0596 ns | 0.0557 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 35.30 ns | 0.0640 ns | 0.0598 ns | 0.0057 |      24 B |
                 From_Char_Nullable_WithValue_AsObject | 49.37 ns | 0.0278 ns | 0.0232 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.67 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.43 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                                         From_DateTime | 37.16 ns | 0.0305 ns | 0.0286 ns | 0.0057 |      24 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 36.54 ns | 0.0476 ns | 0.0398 ns | 0.0057 |      24 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.55 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.99 ns | 0.0070 ns | 0.0058 ns |      - |       0 B |
                                          From_Decimal | 51.15 ns | 0.0362 ns | 0.0302 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject | 62.14 ns | 0.1411 ns | 0.1320 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 51.07 ns | 0.0375 ns | 0.0332 ns | 0.0076 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | 62.08 ns | 0.0165 ns | 0.0120 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.31 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.43 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                           From_Double | 38.70 ns | 0.0217 ns | 0.0181 ns | 0.0057 |      24 B |
                                  From_Double_AsObject | 51.47 ns | 0.0833 ns | 0.0738 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 40.51 ns | 0.0282 ns | 0.0235 ns | 0.0057 |      24 B |
               From_Double_Nullable_WithValue_AsObject | 51.74 ns | 0.0808 ns | 0.0756 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.30 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.43 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
                                            From_Short | 36.66 ns | 0.0276 ns | 0.0245 ns | 0.0057 |      24 B |
                                   From_Short_AsObject | 49.14 ns | 0.0161 ns | 0.0126 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 37.22 ns | 0.0198 ns | 0.0154 ns | 0.0057 |      24 B |
                From_Short_Nullable_WithValue_AsObject | 49.15 ns | 0.0146 ns | 0.0114 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.67 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 15.91 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                                              From_Int | 37.14 ns | 0.0290 ns | 0.0226 ns | 0.0057 |      24 B |
                                     From_Int_AsObject | 39.66 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 37.69 ns | 0.0258 ns | 0.0215 ns | 0.0057 |      24 B |
                  From_Int_Nullable_WithValue_AsObject | 39.46 ns | 0.0361 ns | 0.0320 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.43 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.09 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                                             From_Long | 38.19 ns | 0.0495 ns | 0.0439 ns | 0.0057 |      24 B |
                                    From_Long_AsObject | 50.48 ns | 0.0562 ns | 0.0469 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 39.61 ns | 0.0188 ns | 0.0176 ns | 0.0057 |      24 B |
                 From_Long_Nullable_WithValue_AsObject | 50.37 ns | 0.0182 ns | 0.0131 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.55 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.11 ns | 0.0243 ns | 0.0228 ns |      - |       0 B |
                                            From_SByte | 36.77 ns | 0.0363 ns | 0.0339 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject | 49.23 ns | 0.0099 ns | 0.0077 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 37.59 ns | 0.0527 ns | 0.0493 ns | 0.0057 |      24 B |
                From_SByte_Nullable_WithValue_AsObject | 49.55 ns | 0.0845 ns | 0.0791 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.90 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.89 ns | 0.0070 ns | 0.0058 ns |      - |       0 B |
                                            From_Float | 38.79 ns | 0.0498 ns | 0.0466 ns | 0.0057 |      24 B |
                                   From_Float_AsObject | 51.74 ns | 0.1055 ns | 0.0987 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 39.78 ns | 0.0189 ns | 0.0157 ns | 0.0057 |      24 B |
                From_Float_Nullable_WithValue_AsObject | 51.70 ns | 0.0754 ns | 0.0705 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.74 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.72 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                                           From_String | 42.95 ns | 0.0200 ns | 0.0156 ns |      - |       0 B |
                                  From_String_AsObject | 43.35 ns | 0.0364 ns | 0.0323 ns |      - |       0 B |
                                      From_String_Null | 14.81 ns | 0.0083 ns | 0.0065 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.58 ns | 0.0086 ns | 0.0067 ns |      - |       0 B |
                                     From_String_Empty | 15.41 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                            From_String_Empty_AsObject | 23.34 ns | 0.0636 ns | 0.0595 ns |      - |       0 B |
                                           From_UShort | 36.92 ns | 0.0496 ns | 0.0439 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject | 49.48 ns | 0.0300 ns | 0.0234 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 37.49 ns | 0.0733 ns | 0.0686 ns | 0.0057 |      24 B |
               From_UShort_Nullable_WithValue_AsObject | 49.54 ns | 0.0261 ns | 0.0218 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.41 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 18.82 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                                             From_UInt | 36.90 ns | 0.0251 ns | 0.0196 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject | 49.78 ns | 0.0910 ns | 0.0851 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 38.02 ns | 0.0165 ns | 0.0138 ns | 0.0057 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject | 50.00 ns | 0.0317 ns | 0.0281 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.70 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 15.92 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                                            From_ULong | 37.73 ns | 0.0118 ns | 0.0098 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject | 51.79 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 39.00 ns | 0.0174 ns | 0.0146 ns | 0.0057 |      24 B |
                From_ULong_Nullable_WithValue_AsObject | 50.06 ns | 0.1025 ns | 0.0959 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.81 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.96 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
                                       From_NullObject | 16.66 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                           From_DBNull | 16.38 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.48 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
                                 From_ConvertibleClass | 44.04 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 44.42 ns | 0.0143 ns | 0.0111 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.60 ns | 0.0118 ns | 0.0085 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.62 ns | 0.0302 ns | 0.0283 ns |      - |       0 B |
                              From_NonConvertibleClass | 34.96 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 41.11 ns | 0.0567 ns | 0.0503 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.68 ns | 0.0142 ns | 0.0118 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.72 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                                From_ConvertibleStruct | 46.30 ns | 0.0298 ns | 0.0249 ns | 0.0114 |      48 B |
                       From_ConvertibleStruct_AsObject | 45.78 ns | 0.0806 ns | 0.0753 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 47.59 ns | 0.0345 ns | 0.0323 ns | 0.0114 |      48 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 46.00 ns | 0.0674 ns | 0.0630 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 13.72 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.02 ns | 0.0199 ns | 0.0177 ns |      - |       0 B |
                             From_NonConvertibleStruct | 35.01 ns | 0.0159 ns | 0.0141 ns | 0.0057 |      24 B |
                    From_NonConvertibleStruct_AsObject | 39.67 ns | 0.0714 ns | 0.0668 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 36.65 ns | 0.0274 ns | 0.0256 ns | 0.0057 |      24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 39.64 ns | 0.0553 ns | 0.0490 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.44 ns | 0.0131 ns | 0.0102 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.89 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                             From_Enum | 14.13 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                                    From_Enum_AsObject | 16.63 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue | 15.67 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 16.64 ns | 0.0299 ns | 0.0279 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue | 13.42 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 15.99 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                                      From_ParentClass | 34.75 ns | 0.0155 ns | 0.0121 ns |      - |       0 B |
                             From_ParentClass_AsObject | 40.72 ns | 0.0667 ns | 0.0591 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.70 ns | 0.0220 ns | 0.0184 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 15.93 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                                     From_ParentStruct | 34.88 ns | 0.0179 ns | 0.0167 ns | 0.0057 |      24 B |
                            From_ParentStruct_AsObject | 41.68 ns | 0.0336 ns | 0.0262 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 36.05 ns | 0.0183 ns | 0.0143 ns | 0.0057 |      24 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 40.20 ns | 0.0375 ns | 0.0292 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.42 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.93 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
