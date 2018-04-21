
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.37 ns | 0.0558 ns | 0.0522 ns |  16.34 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.11 ns | 0.0533 ns | 0.0472 ns |  25.10 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  16.94 ns | 0.0220 ns | 0.0183 ns |  16.93 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.06 ns | 0.0256 ns | 0.0214 ns |  25.06 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.38 ns | 0.0181 ns | 0.0169 ns |  15.37 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.93 ns | 0.0481 ns | 0.0426 ns |  17.92 ns |      - |       0 B |
                                             From_Byte |  16.15 ns | 0.0211 ns | 0.0197 ns |  16.15 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.05 ns | 0.0169 ns | 0.0141 ns |  25.05 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.40 ns | 0.0185 ns | 0.0173 ns |  16.40 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.07 ns | 0.0431 ns | 0.0382 ns |  25.05 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.47 ns | 0.0096 ns | 0.0085 ns |  16.47 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.58 ns | 0.0151 ns | 0.0126 ns |  18.58 ns |      - |       0 B |
                                             From_Char |  16.42 ns | 0.0163 ns | 0.0153 ns |  16.42 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.28 ns | 0.0129 ns | 0.0114 ns |  15.27 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.16 ns | 0.0121 ns | 0.0114 ns |  15.16 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.92 ns | 0.0254 ns | 0.0237 ns |  18.90 ns |      - |       0 B |
                                         From_DateTime |  16.94 ns | 0.0132 ns | 0.0123 ns |  16.94 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.48 ns | 0.0210 ns | 0.0196 ns |  15.48 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.53 ns | 0.0376 ns | 0.0352 ns |  15.54 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.52 ns | 0.0452 ns | 0.0423 ns |  18.52 ns |      - |       0 B |
                                          From_Decimal |  15.07 ns | 0.0191 ns | 0.0178 ns |  15.07 ns |      - |       0 B |
                                 From_Decimal_AsObject |  18.34 ns | 0.0446 ns | 0.0417 ns |  18.34 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  16.12 ns | 0.0359 ns | 0.0336 ns |  16.11 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  18.83 ns | 0.0324 ns | 0.0303 ns |  18.81 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.77 ns | 0.0192 ns | 0.0180 ns |  15.77 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.90 ns | 0.0228 ns | 0.0202 ns |  17.89 ns |      - |       0 B |
                                           From_Double |  75.43 ns | 0.0391 ns | 0.0347 ns |  75.42 ns |      - |       0 B |
                                  From_Double_AsObject |  82.43 ns | 0.1053 ns | 0.0985 ns |  82.39 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  75.48 ns | 0.0741 ns | 0.0694 ns |  75.46 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  82.33 ns | 0.1137 ns | 0.1064 ns |  82.29 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.43 ns | 0.0297 ns | 0.0278 ns |  15.44 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  19.02 ns | 0.0326 ns | 0.0289 ns |  19.01 ns |      - |       0 B |
                                            From_Short |  16.11 ns | 0.0075 ns | 0.0063 ns |  16.11 ns |      - |       0 B |
                                   From_Short_AsObject |  25.33 ns | 0.0517 ns | 0.0484 ns |  25.30 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.44 ns | 0.0461 ns | 0.0409 ns |  16.43 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.36 ns | 0.0350 ns | 0.0327 ns |  26.34 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.37 ns | 0.0178 ns | 0.0157 ns |  15.36 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  21.03 ns | 0.0193 ns | 0.0181 ns |  21.02 ns |      - |       0 B |
                                              From_Int |  16.10 ns | 0.0253 ns | 0.0225 ns |  16.09 ns |      - |       0 B |
                                     From_Int_AsObject |  25.36 ns | 0.0093 ns | 0.0082 ns |  25.36 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.37 ns | 0.0238 ns | 0.0222 ns |  16.35 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.41 ns | 0.0386 ns | 0.0361 ns |  25.40 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.34 ns | 0.0087 ns | 0.0077 ns |  15.33 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.59 ns | 0.0196 ns | 0.0174 ns |  18.58 ns |      - |       0 B |
                                             From_Long |  16.08 ns | 0.0035 ns | 0.0033 ns |  16.08 ns |      - |       0 B |
                                    From_Long_AsObject |  25.97 ns | 0.3372 ns | 0.3154 ns |  25.84 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.35 ns | 0.0046 ns | 0.0036 ns |  16.35 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  25.62 ns | 0.0231 ns | 0.0205 ns |  25.61 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.61 ns | 0.0061 ns | 0.0051 ns |  15.61 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.33 ns | 0.0127 ns | 0.0106 ns |  19.33 ns |      - |       0 B |
                                            From_SByte |  16.08 ns | 0.0038 ns | 0.0032 ns |  16.08 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.35 ns | 0.0283 ns | 0.0265 ns |  25.34 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.36 ns | 0.0093 ns | 0.0078 ns |  16.36 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.42 ns | 0.0350 ns | 0.0327 ns |  25.42 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.34 ns | 0.0145 ns | 0.0121 ns |  15.33 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.92 ns | 0.0117 ns | 0.0097 ns |  17.92 ns |      - |       0 B |
                                            From_Float |  36.41 ns | 0.0777 ns | 0.0727 ns |  36.41 ns |      - |       0 B |
                                   From_Float_AsObject |  44.15 ns | 0.0429 ns | 0.0401 ns |  44.16 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  36.75 ns | 0.0885 ns | 0.0828 ns |  36.81 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  43.47 ns | 0.0280 ns | 0.0234 ns |  43.47 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.40 ns | 0.0049 ns | 0.0043 ns |  15.40 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  19.06 ns | 0.0239 ns | 0.0224 ns |  19.04 ns |      - |       0 B |
                                           From_String | 122.13 ns | 0.0362 ns | 0.0303 ns | 122.13 ns |      - |       0 B |
                                  From_String_AsObject | 130.33 ns | 0.1313 ns | 0.1228 ns | 130.36 ns |      - |       0 B |
                                      From_String_Null |  16.63 ns | 0.0342 ns | 0.0320 ns |  16.61 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.37 ns | 0.0178 ns | 0.0166 ns |  18.37 ns |      - |       0 B |
                                     From_String_Empty |  16.49 ns | 0.0056 ns | 0.0050 ns |  16.49 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.09 ns | 0.0157 ns | 0.0146 ns |  16.09 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.45 ns | 0.0264 ns | 0.0247 ns |  26.45 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.38 ns | 0.0361 ns | 0.0320 ns |  16.38 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.33 ns | 0.0414 ns | 0.0387 ns |  25.31 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.33 ns | 0.0051 ns | 0.0042 ns |  15.33 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.92 ns | 0.0150 ns | 0.0140 ns |  17.93 ns |      - |       0 B |
                                             From_UInt |  15.32 ns | 0.0041 ns | 0.0034 ns |  15.32 ns |      - |       0 B |
                                    From_UInt_AsObject |  25.16 ns | 0.0302 ns | 0.0282 ns |  25.16 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.84 ns | 0.0053 ns | 0.0041 ns |  15.84 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.04 ns | 0.0144 ns | 0.0135 ns |  25.04 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.33 ns | 0.0019 ns | 0.0014 ns |  15.33 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.51 ns | 0.0146 ns | 0.0129 ns |  18.50 ns |      - |       0 B |
                                            From_ULong |  16.40 ns | 0.0207 ns | 0.0194 ns |  16.40 ns |      - |       0 B |
                                   From_ULong_AsObject |  24.85 ns | 0.0133 ns | 0.0118 ns |  24.85 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.85 ns | 0.0066 ns | 0.0051 ns |  15.84 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  24.94 ns | 0.0502 ns | 0.0445 ns |  24.94 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.33 ns | 0.0062 ns | 0.0055 ns |  15.33 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.49 ns | 0.0116 ns | 0.0103 ns |  18.49 ns |      - |       0 B |
                                       From_NullObject |  17.94 ns | 0.0291 ns | 0.0258 ns |  17.94 ns |      - |       0 B |
                                           From_DBNull |  16.60 ns | 0.0063 ns | 0.0053 ns |  16.60 ns |      - |       0 B |
                                  From_DBNull_AsObject |  21.33 ns | 0.0074 ns | 0.0058 ns |  21.33 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.24 ns | 0.0352 ns | 0.0329 ns |  22.22 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  22.59 ns | 0.0312 ns | 0.0292 ns |  22.60 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.94 ns | 0.0203 ns | 0.0180 ns |  17.93 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.93 ns | 0.0250 ns | 0.0222 ns |  17.93 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.85 ns | 0.0277 ns | 0.0246 ns |  15.84 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.00 ns | 0.0241 ns | 0.0225 ns |  21.00 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.87 ns | 0.0362 ns | 0.0338 ns |  15.85 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.99 ns | 0.0157 ns | 0.0139 ns |  18.99 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.02 ns | 0.0291 ns | 0.0272 ns |  24.00 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.89 ns | 0.0177 ns | 0.0165 ns |  24.89 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  24.25 ns | 0.0268 ns | 0.0250 ns |  24.24 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  23.84 ns | 0.0187 ns | 0.0156 ns |  23.84 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.36 ns | 0.0280 ns | 0.0262 ns |  16.35 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.93 ns | 0.0105 ns | 0.0093 ns |  17.93 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.39 ns | 0.0051 ns | 0.0043 ns |  16.39 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  19.93 ns | 0.0181 ns | 0.0160 ns |  19.93 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.41 ns | 0.0350 ns | 0.0327 ns |  16.39 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  20.98 ns | 0.0333 ns | 0.0278 ns |  20.98 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.41 ns | 0.0396 ns | 0.0370 ns |  16.39 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  20.34 ns | 0.0171 ns | 0.0134 ns |  20.35 ns |      - |       0 B |
                                             From_Enum |  16.08 ns | 0.0020 ns | 0.0017 ns |  16.08 ns |      - |       0 B |
                                    From_Enum_AsObject |  55.64 ns | 0.0383 ns | 0.0339 ns |  55.64 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  16.44 ns | 0.0281 ns | 0.0263 ns |  16.42 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  55.56 ns | 0.0285 ns | 0.0252 ns |  55.55 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  15.59 ns | 0.0048 ns | 0.0038 ns |  15.59 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  20.76 ns | 0.0124 ns | 0.0104 ns |  20.76 ns |      - |       0 B |
                                      From_ParentClass |  15.85 ns | 0.0058 ns | 0.0045 ns |  15.85 ns |      - |       0 B |
                             From_ParentClass_AsObject |  21.46 ns | 0.0359 ns | 0.0318 ns |  21.46 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.33 ns | 0.4479 ns | 1.2261 ns |  15.72 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.90 ns | 0.0172 ns | 0.0144 ns |  17.90 ns |      - |       0 B |
                                     From_ParentStruct |  16.41 ns | 0.0358 ns | 0.0279 ns |  16.40 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  20.26 ns | 0.0273 ns | 0.0255 ns |  20.26 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.87 ns | 0.0364 ns | 0.0340 ns |  16.85 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  20.30 ns | 0.0526 ns | 0.0492 ns |  20.31 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.40 ns | 0.0250 ns | 0.0221 ns |  16.38 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.44 ns | 0.0334 ns | 0.0313 ns |  19.43 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo2_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_String_Empty_AsObject: DefaultJob
