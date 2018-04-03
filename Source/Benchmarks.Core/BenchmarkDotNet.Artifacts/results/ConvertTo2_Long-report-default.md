
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.66 ns | 0.0813 ns | 0.0761 ns |      - |       0 B |
                                    From_Bool_AsObject |  29.59 ns | 0.1410 ns | 0.1319 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.47 ns | 0.1446 ns | 0.1282 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  29.47 ns | 0.1061 ns | 0.0940 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.30 ns | 0.0152 ns | 0.0119 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.05 ns | 0.0414 ns | 0.0367 ns |      - |       0 B |
                                             From_Byte |  13.16 ns | 0.0884 ns | 0.0827 ns |      - |       0 B |
                                    From_Byte_AsObject |  29.49 ns | 0.1256 ns | 0.1049 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.79 ns | 0.0957 ns | 0.0799 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  29.45 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.39 ns | 0.0330 ns | 0.0276 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.12 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                                             From_Char |  13.12 ns | 0.0394 ns | 0.0369 ns |      - |       0 B |
                                    From_Char_AsObject |  30.31 ns | 0.0987 ns | 0.0875 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.76 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  30.26 ns | 0.0804 ns | 0.0752 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.33 ns | 0.0784 ns | 0.0734 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.29 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
                                         From_DateTime |  14.24 ns | 0.0414 ns | 0.0387 ns |      - |       0 B |
                                From_DateTime_AsObject |  21.21 ns | 0.1225 ns | 0.1146 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  18.34 ns | 0.0418 ns | 0.0370 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  21.38 ns | 0.1479 ns | 0.1311 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  15.13 ns | 0.0575 ns | 0.0510 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.52 ns | 0.0796 ns | 0.0744 ns |      - |       0 B |
                                          From_Decimal |  26.30 ns | 0.0320 ns | 0.0284 ns |      - |       0 B |
                                 From_Decimal_AsObject |  39.68 ns | 0.1294 ns | 0.1011 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  32.97 ns | 0.0578 ns | 0.0541 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.71 ns | 0.1452 ns | 0.1213 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.27 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.54 ns | 0.0739 ns | 0.0691 ns |      - |       0 B |
                                           From_Double |  16.80 ns | 0.0233 ns | 0.0168 ns |      - |       0 B |
                                  From_Double_AsObject |  34.09 ns | 0.0901 ns | 0.0798 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.42 ns | 0.0607 ns | 0.0474 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  34.06 ns | 0.0807 ns | 0.0630 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.20 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.82 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
                                            From_Short |  13.10 ns | 0.0289 ns | 0.0256 ns |      - |       0 B |
                                   From_Short_AsObject |  29.47 ns | 0.0853 ns | 0.0798 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.81 ns | 0.0599 ns | 0.0531 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.50 ns | 0.1310 ns | 0.1225 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.53 ns | 0.0314 ns | 0.0294 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.04 ns | 0.0508 ns | 0.0475 ns |      - |       0 B |
                                              From_Int |  13.36 ns | 0.0227 ns | 0.0189 ns |      - |       0 B |
                                     From_Int_AsObject |  29.14 ns | 0.0370 ns | 0.0309 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.60 ns | 0.0417 ns | 0.0390 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.17 ns | 0.0597 ns | 0.0559 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.25 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.07 ns | 0.0373 ns | 0.0312 ns |      - |       0 B |
                                             From_Long |  13.35 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                                    From_Long_AsObject |  16.78 ns | 0.0322 ns | 0.0302 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  14.17 ns | 0.0540 ns | 0.0451 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  17.67 ns | 0.0482 ns | 0.0451 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.67 ns | 0.0387 ns | 0.0324 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.03 ns | 0.0426 ns | 0.0377 ns |      - |       0 B |
                                            From_SByte |  13.09 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                                   From_SByte_AsObject |  29.21 ns | 0.0969 ns | 0.0906 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.63 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  29.19 ns | 0.0677 ns | 0.0600 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.26 ns | 0.0522 ns | 0.0488 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.10 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                                            From_Float |  16.75 ns | 0.0556 ns | 0.0520 ns |      - |       0 B |
                                   From_Float_AsObject |  34.63 ns | 0.0512 ns | 0.0454 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.86 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  34.62 ns | 0.0443 ns | 0.0370 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.23 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.02 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                                           From_String |  98.84 ns | 0.1624 ns | 0.1519 ns |      - |       0 B |
                                  From_String_AsObject | 108.40 ns | 0.1331 ns | 0.1180 ns |      - |       0 B |
                                      From_String_Null |  16.00 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.08 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                                     From_String_Empty |  19.92 ns | 0.0415 ns | 0.0389 ns |      - |       0 B |
                            From_String_Empty_AsObject |  24.14 ns | 0.0507 ns | 0.0474 ns |      - |       0 B |
                                           From_UShort |  13.34 ns | 0.0339 ns | 0.0317 ns |      - |       0 B |
                                  From_UShort_AsObject |  29.15 ns | 0.0705 ns | 0.0625 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  20.77 ns | 0.0397 ns | 0.0371 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  29.21 ns | 0.0951 ns | 0.0890 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.49 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.06 ns | 0.0314 ns | 0.0294 ns |      - |       0 B |
                                             From_UInt |  13.03 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.16 ns | 0.0676 ns | 0.0633 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.26 ns | 0.0427 ns | 0.0378 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.17 ns | 0.0831 ns | 0.0777 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.26 ns | 0.0477 ns | 0.0446 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.03 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                                            From_ULong |  13.77 ns | 0.0371 ns | 0.0329 ns |      - |       0 B |
                                   From_ULong_AsObject |  30.02 ns | 0.0876 ns | 0.0820 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.49 ns | 0.0203 ns | 0.0180 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.96 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.19 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.49 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
                                       From_NullObject |  16.70 ns | 0.0361 ns | 0.0338 ns |      - |       0 B |
                                           From_DBNull |  13.76 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.78 ns | 0.1023 ns | 0.0907 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.71 ns | 0.0266 ns | 0.0236 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.18 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.49 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                              From_NonConvertibleClass |  20.53 ns | 0.0520 ns | 0.0486 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.93 ns | 0.0867 ns | 0.0811 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.69 ns | 0.0373 ns | 0.0331 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.07 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.32 ns | 0.0483 ns | 0.0451 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  28.10 ns | 0.0837 ns | 0.0699 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.25 ns | 0.0530 ns | 0.0496 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.07 ns | 0.0441 ns | 0.0391 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.31 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.04 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.71 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.82 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.97 ns | 0.0270 ns | 0.0252 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.80 ns | 0.0407 ns | 0.0381 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.94 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.25 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                                             From_Enum |  13.80 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.00 ns | 0.0803 ns | 0.0712 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  16.60 ns | 0.0372 ns | 0.0329 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.93 ns | 0.1874 ns | 0.1753 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  13.28 ns | 0.0251 ns | 0.0209 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.02 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |