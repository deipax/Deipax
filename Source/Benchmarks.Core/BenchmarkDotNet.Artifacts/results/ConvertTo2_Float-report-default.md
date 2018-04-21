
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.59 ns | 0.1054 ns | 0.0986 ns |      - |       0 B |
                                    From_Bool_AsObject |  22.65 ns | 0.0638 ns | 0.0566 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  14.16 ns | 0.0173 ns | 0.0153 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  22.51 ns | 0.0301 ns | 0.0282 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.67 ns | 0.0048 ns | 0.0038 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.47 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                                             From_Byte |  13.45 ns | 0.0120 ns | 0.0107 ns |      - |       0 B |
                                    From_Byte_AsObject |  22.31 ns | 0.0589 ns | 0.0551 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  13.80 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  22.27 ns | 0.0506 ns | 0.0474 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.42 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.12 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                                             From_Char |  13.40 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  13.44 ns | 0.0317 ns | 0.0297 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.18 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.02 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
                                         From_DateTime |  13.29 ns | 0.0135 ns | 0.0105 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.35 ns | 0.0687 ns | 0.0574 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.32 ns | 0.0130 ns | 0.0109 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.12 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                                          From_Decimal |  21.75 ns | 0.0428 ns | 0.0401 ns |      - |       0 B |
                                 From_Decimal_AsObject |  30.93 ns | 0.0169 ns | 0.0132 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  29.10 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  31.00 ns | 0.0760 ns | 0.0711 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.32 ns | 0.0187 ns | 0.0166 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.13 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                                           From_Double |  13.91 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                                  From_Double_AsObject |  22.81 ns | 0.0675 ns | 0.0631 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.68 ns | 0.0092 ns | 0.0072 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  22.77 ns | 0.0411 ns | 0.0344 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.31 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.27 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                                            From_Short |  13.45 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
                                   From_Short_AsObject |  23.04 ns | 0.0462 ns | 0.0409 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.48 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  23.01 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.42 ns | 0.0109 ns | 0.0085 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.59 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                                              From_Int |  13.19 ns | 0.0287 ns | 0.0255 ns |      - |       0 B |
                                     From_Int_AsObject |  22.75 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  13.81 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  24.28 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.70 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.04 ns | 0.0360 ns | 0.0336 ns |      - |       0 B |
                                             From_Long |  13.22 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
                                    From_Long_AsObject |  23.01 ns | 0.0124 ns | 0.0104 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.34 ns | 0.0084 ns | 0.0066 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  23.02 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.32 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.28 ns | 0.0190 ns | 0.0159 ns |      - |       0 B |
                                            From_SByte |  13.46 ns | 0.0396 ns | 0.0371 ns |      - |       0 B |
                                   From_SByte_AsObject |  22.76 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  13.81 ns | 0.0216 ns | 0.0192 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  22.74 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.43 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  20.67 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                                            From_Float |  13.43 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                   From_Float_AsObject |  17.76 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  13.82 ns | 0.0378 ns | 0.0354 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  16.84 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.45 ns | 0.0286 ns | 0.0254 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.26 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                                           From_String | 107.04 ns | 0.0712 ns | 0.0666 ns |      - |       0 B |
                                  From_String_AsObject | 116.04 ns | 0.0895 ns | 0.0838 ns |      - |       0 B |
                                      From_String_Null |  15.58 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.09 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                                     From_String_Empty |  15.43 ns | 0.0343 ns | 0.0304 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.20 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
                                  From_UShort_AsObject |  22.80 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  13.85 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  22.86 ns | 0.0663 ns | 0.0620 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.67 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.96 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                                             From_UInt |  13.66 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                                    From_UInt_AsObject |  24.67 ns | 0.0345 ns | 0.0306 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  13.96 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  23.06 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.81 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.21 ns | 0.0161 ns | 0.0135 ns |      - |       0 B |
                                            From_ULong |  13.69 ns | 0.0401 ns | 0.0375 ns |      - |       0 B |
                                   From_ULong_AsObject |  24.60 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.59 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  23.60 ns | 0.0532 ns | 0.0497 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.31 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.06 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                                       From_NullObject |  16.01 ns | 0.0059 ns | 0.0050 ns |      - |       0 B |
                                           From_DBNull |  14.37 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                                  From_DBNull_AsObject |  16.10 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                                 From_ConvertibleClass |  19.98 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  20.70 ns | 0.0332 ns | 0.0311 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.20 ns | 0.0143 ns | 0.0103 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.02 ns | 0.0260 ns | 0.0217 ns |      - |       0 B |
                              From_NonConvertibleClass |  14.13 ns | 0.0204 ns | 0.0190 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  17.78 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  14.22 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.55 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.23 ns | 0.0140 ns | 0.0131 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  21.99 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  22.50 ns | 0.0230 ns | 0.0215 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  22.24 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.80 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.02 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.11 ns | 0.0232 ns | 0.0194 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  19.07 ns | 0.0316 ns | 0.0295 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.21 ns | 0.0077 ns | 0.0056 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  20.18 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.25 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.09 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                                             From_Enum |  13.19 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                    From_Enum_AsObject |  52.42 ns | 0.0253 ns | 0.0198 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  13.88 ns | 0.0397 ns | 0.0372 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  52.92 ns | 0.0711 ns | 0.0665 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  13.73 ns | 0.0617 ns | 0.0516 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.15 ns | 0.0083 ns | 0.0065 ns |      - |       0 B |
                                      From_ParentClass |  15.38 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                             From_ParentClass_AsObject |  19.35 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
                              From_ParentClass_NoValue |  14.12 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  16.42 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                                     From_ParentStruct |  14.05 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  18.43 ns | 0.0506 ns | 0.0474 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.19 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  21.12 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.19 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  16.03 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Float.From_Char_AsObject: DefaultJob
  ConvertTo2_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_String_Empty_AsObject: DefaultJob
