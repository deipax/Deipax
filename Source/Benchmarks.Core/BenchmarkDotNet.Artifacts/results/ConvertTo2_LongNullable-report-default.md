
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435885 Hz, Resolution=291.0458 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.86 ns | 0.0539 ns | 0.0478 ns |      - |       0 B |
                                    From_Bool_AsObject |  32.58 ns | 0.0961 ns | 0.0852 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.64 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  32.62 ns | 0.1263 ns | 0.1181 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.15 ns | 0.0886 ns | 0.0829 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.14 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
                                             From_Byte |  14.37 ns | 0.0253 ns | 0.0225 ns |      - |       0 B |
                                    From_Byte_AsObject |  32.74 ns | 0.1450 ns | 0.1285 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  15.15 ns | 0.0432 ns | 0.0404 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  32.74 ns | 0.0627 ns | 0.0555 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.92 ns | 0.0647 ns | 0.0605 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.17 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                                             From_Char |  14.40 ns | 0.0398 ns | 0.0352 ns |      - |       0 B |
                                    From_Char_AsObject |  33.16 ns | 0.1074 ns | 0.0952 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.12 ns | 0.0948 ns | 0.0840 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  33.15 ns | 0.1096 ns | 0.0972 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.99 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.05 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.36 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.10 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                                          From_Decimal |  26.20 ns | 0.0714 ns | 0.0667 ns |      - |       0 B |
                                 From_Decimal_AsObject |  42.33 ns | 0.0955 ns | 0.0893 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.77 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  42.43 ns | 0.1874 ns | 0.1753 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.38 ns | 0.0351 ns | 0.0311 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.16 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                                           From_Double |  18.86 ns | 0.0516 ns | 0.0457 ns |      - |       0 B |
                                  From_Double_AsObject |  36.90 ns | 0.0648 ns | 0.0541 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.68 ns | 0.0419 ns | 0.0392 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  38.07 ns | 0.0843 ns | 0.0747 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.38 ns | 0.0353 ns | 0.0313 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.14 ns | 0.0662 ns | 0.0619 ns |      - |       0 B |
                                            From_Short |  14.39 ns | 0.0359 ns | 0.0319 ns |      - |       0 B |
                                   From_Short_AsObject |  32.32 ns | 0.0475 ns | 0.0396 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.07 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  32.35 ns | 0.0683 ns | 0.0605 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.61 ns | 0.0304 ns | 0.0254 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.14 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                                              From_Int |  14.48 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
                                     From_Int_AsObject |  32.60 ns | 0.1237 ns | 0.1157 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  15.09 ns | 0.0243 ns | 0.0228 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  32.35 ns | 0.0606 ns | 0.0567 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.76 ns | 0.0286 ns | 0.0267 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.47 ns | 0.4033 ns | 0.4953 ns |      - |       0 B |
                                             From_Long |  14.41 ns | 0.0545 ns | 0.0483 ns |      - |       0 B |
                                    From_Long_AsObject |  29.16 ns | 0.0813 ns | 0.0761 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.07 ns | 0.0131 ns | 0.0117 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.85 ns | 0.0452 ns | 0.0401 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.07 ns | 0.0200 ns | 0.0167 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.14 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                                            From_SByte |  14.37 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
                                   From_SByte_AsObject |  32.57 ns | 0.0529 ns | 0.0495 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.11 ns | 0.0482 ns | 0.0451 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.78 ns | 0.0782 ns | 0.0731 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.82 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.65 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
                                            From_Float |  18.97 ns | 0.0441 ns | 0.0391 ns |      - |       0 B |
                                   From_Float_AsObject |  37.24 ns | 0.0519 ns | 0.0433 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.64 ns | 0.0934 ns | 0.0873 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  37.01 ns | 0.0529 ns | 0.0469 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.02 ns | 0.0416 ns | 0.0390 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.09 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                           From_String | 101.71 ns | 0.5289 ns | 0.4417 ns |      - |       0 B |
                                  From_String_AsObject | 109.46 ns | 0.1338 ns | 0.1044 ns |      - |       0 B |
                                      From_String_Null |  17.23 ns | 0.0332 ns | 0.0311 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.21 ns | 0.0664 ns | 0.0589 ns |      - |       0 B |
                                     From_String_Empty |  25.58 ns | 0.2214 ns | 0.1849 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.37 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                                  From_UShort_AsObject |  32.56 ns | 0.0751 ns | 0.0702 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.29 ns | 0.0540 ns | 0.0479 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  32.58 ns | 0.1139 ns | 0.1065 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.81 ns | 0.0298 ns | 0.0264 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.14 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
                                             From_UInt |  14.25 ns | 0.0269 ns | 0.0239 ns |      - |       0 B |
                                    From_UInt_AsObject |  32.36 ns | 0.0952 ns | 0.0744 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.27 ns | 0.0786 ns | 0.0657 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.57 ns | 0.1034 ns | 0.0864 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.98 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.90 ns | 0.4093 ns | 0.5464 ns |      - |       0 B |
                                            From_ULong |  15.55 ns | 0.3396 ns | 0.4761 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.94 ns | 0.1141 ns | 0.0953 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.70 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  33.08 ns | 0.1631 ns | 0.1525 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.62 ns | 0.0156 ns | 0.0130 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.22 ns | 0.0239 ns | 0.0224 ns |      - |       0 B |
                                       From_NullObject |  17.24 ns | 0.0598 ns | 0.0530 ns |      - |       0 B |
                                           From_DBNull |  15.36 ns | 0.0413 ns | 0.0386 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.50 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  30.09 ns | 0.0451 ns | 0.0399 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.33 ns | 0.0963 ns | 0.0901 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.15 ns | 0.0338 ns | 0.0317 ns |      - |       0 B |
                              From_NonConvertibleClass |  20.46 ns | 0.0838 ns | 0.0784 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.07 ns | 0.0622 ns | 0.0582 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.88 ns | 0.0273 ns | 0.0214 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.16 ns | 0.0494 ns | 0.0438 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.19 ns | 0.0339 ns | 0.0317 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  31.16 ns | 0.0927 ns | 0.0867 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 100.58 ns | 0.1968 ns | 0.1536 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  31.15 ns | 0.0910 ns | 0.0852 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  44.40 ns | 0.0688 ns | 0.0537 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.13 ns | 0.0226 ns | 0.0189 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.28 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.07 ns | 0.0452 ns | 0.0423 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.26 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.26 ns | 0.0951 ns | 0.0794 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.29 ns | 0.0468 ns | 0.0415 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.20 ns | 0.0672 ns | 0.0628 ns |      - |       0 B |
                                             From_Enum |  59.87 ns | 0.3810 ns | 0.3378 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  64.82 ns | 0.0517 ns | 0.0459 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 161.18 ns | 0.2127 ns | 0.1886 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.62 ns | 0.0363 ns | 0.0322 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  44.00 ns | 0.1476 ns | 0.1380 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.74 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
