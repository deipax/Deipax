
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435885 Hz, Resolution=291.0458 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.29 ns | 0.0705 ns | 0.0659 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.16 ns | 0.0540 ns | 0.0479 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  14.00 ns | 0.0364 ns | 0.0340 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.17 ns | 0.0653 ns | 0.0611 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.07 ns | 0.1088 ns | 0.0964 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.82 ns | 0.0203 ns | 0.0180 ns |      - |       0 B |
                                             From_Byte |  12.90 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.26 ns | 0.1218 ns | 0.0951 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.45 ns | 0.0341 ns | 0.0319 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  27.27 ns | 0.0681 ns | 0.0637 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.55 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.03 ns | 0.1335 ns | 0.1115 ns |      - |       0 B |
                                             From_Char |  12.92 ns | 0.0361 ns | 0.0320 ns |      - |       0 B |
                                    From_Char_AsObject |  27.44 ns | 0.1531 ns | 0.1358 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.39 ns | 0.0321 ns | 0.0300 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  28.30 ns | 0.0315 ns | 0.0294 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.55 ns | 0.0510 ns | 0.0452 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.38 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.74 ns | 0.3446 ns | 0.3539 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.27 ns | 0.1473 ns | 0.1306 ns |      - |       0 B |
                                          From_Decimal |  26.43 ns | 0.0621 ns | 0.0580 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.72 ns | 0.7371 ns | 0.6155 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  29.27 ns | 0.1372 ns | 0.1145 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.67 ns | 0.0926 ns | 0.0821 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.01 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.38 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                           From_Double |  16.71 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
                                  From_Double_AsObject |  31.10 ns | 0.1703 ns | 0.1510 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  18.28 ns | 0.0220 ns | 0.0195 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.10 ns | 0.0856 ns | 0.0759 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.58 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.62 ns | 0.0208 ns | 0.0185 ns |      - |       0 B |
                                            From_Short |  12.96 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
                                   From_Short_AsObject |  27.26 ns | 0.0351 ns | 0.0311 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.16 ns | 0.0497 ns | 0.0415 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  27.56 ns | 0.0972 ns | 0.0909 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.35 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.41 ns | 0.0778 ns | 0.0690 ns |      - |       0 B |
                                              From_Int |  13.08 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                                     From_Int_AsObject |  27.55 ns | 0.1644 ns | 0.1538 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  13.43 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.25 ns | 0.0550 ns | 0.0488 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.25 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.44 ns | 0.0582 ns | 0.0516 ns |      - |       0 B |
                                             From_Long |  14.14 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                                    From_Long_AsObject |  16.87 ns | 0.0306 ns | 0.0271 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  13.99 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  17.81 ns | 0.0694 ns | 0.0649 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.45 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.40 ns | 0.0187 ns | 0.0166 ns |      - |       0 B |
                                            From_SByte |  13.00 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.18 ns | 0.0413 ns | 0.0386 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  13.61 ns | 0.0276 ns | 0.0259 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  27.26 ns | 0.0397 ns | 0.0371 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.16 ns | 0.0251 ns | 0.0234 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.47 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                            From_Float |  16.68 ns | 0.0134 ns | 0.0118 ns |      - |       0 B |
                                   From_Float_AsObject |  31.49 ns | 0.0521 ns | 0.0487 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.04 ns | 0.0433 ns | 0.0384 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  31.51 ns | 0.0514 ns | 0.0481 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.26 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.40 ns | 0.0273 ns | 0.0256 ns |      - |       0 B |
                                           From_String |  96.88 ns | 0.1028 ns | 0.0911 ns |      - |       0 B |
                                  From_String_AsObject | 102.85 ns | 0.0933 ns | 0.0873 ns |      - |       0 B |
                                      From_String_Null |  17.76 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.08 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                                     From_String_Empty |  20.69 ns | 0.1093 ns | 0.0913 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.02 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.13 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  13.68 ns | 0.0896 ns | 0.0838 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.15 ns | 0.0482 ns | 0.0427 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.31 ns | 0.0747 ns | 0.0698 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.90 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                             From_UInt |  13.97 ns | 0.0185 ns | 0.0154 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.14 ns | 0.0391 ns | 0.0366 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  13.69 ns | 0.0643 ns | 0.0601 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  27.22 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.42 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.45 ns | 0.0801 ns | 0.0749 ns |      - |       0 B |
                                            From_ULong |  14.80 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.03 ns | 0.0300 ns | 0.0280 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  14.80 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.97 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.11 ns | 0.0400 ns | 0.0374 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.38 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
                                       From_NullObject |  17.18 ns | 0.0212 ns | 0.0199 ns |      - |       0 B |
                                           From_DBNull |  13.61 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.81 ns | 0.0329 ns | 0.0308 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.31 ns | 0.0451 ns | 0.0400 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.91 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.77 ns | 0.0235 ns | 0.0219 ns |      - |       0 B |
                              From_NonConvertibleClass |  19.54 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  24.52 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.17 ns | 0.0200 ns | 0.0177 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.39 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.27 ns | 0.0143 ns | 0.0134 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.08 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  98.88 ns | 0.0542 ns | 0.0507 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.08 ns | 0.0301 ns | 0.0281 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  43.91 ns | 0.0392 ns | 0.0347 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.40 ns | 0.0315 ns | 0.0279 ns |      - |       0 B |
                             From_NonConvertibleStruct |  12.81 ns | 0.0183 ns | 0.0153 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.17 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  12.66 ns | 0.0283 ns | 0.0264 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  22.87 ns | 0.0222 ns | 0.0208 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  12.69 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.44 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
                                             From_Enum |  57.76 ns | 0.0466 ns | 0.0413 ns | 0.0114 |      48 B |
                                    From_Enum_AsObject |  59.44 ns | 0.0820 ns | 0.0727 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 158.67 ns | 0.1459 ns | 0.1293 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.51 ns | 0.1196 ns | 0.1119 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  41.97 ns | 0.0383 ns | 0.0358 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.40 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
