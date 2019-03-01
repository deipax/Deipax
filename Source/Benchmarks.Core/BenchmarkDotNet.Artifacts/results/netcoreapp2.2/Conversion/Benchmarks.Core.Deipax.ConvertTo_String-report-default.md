
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  12.88 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |  16.24 ns | 0.1130 ns | 0.1002 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  12.50 ns | 0.0439 ns | 0.0411 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |  15.50 ns | 0.0993 ns | 0.0929 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  10.88 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  12.43 ns | 0.0501 ns | 0.0418 ns |           - |           - |           - |                   - |
                                             From_Byte |  26.50 ns | 0.1468 ns | 0.1373 ns |      0.0051 |           - |           - |                32 B |
                                    From_Byte_AsObject |  31.72 ns | 0.1517 ns | 0.1419 ns |      0.0051 |           - |           - |                32 B |
                          From_Byte_Nullable_WithValue |  27.15 ns | 0.1206 ns | 0.1128 ns |      0.0051 |           - |           - |                32 B |
                 From_Byte_Nullable_WithValue_AsObject |  31.64 ns | 0.0995 ns | 0.0931 ns |      0.0051 |           - |           - |                32 B |
                            From_Byte_Nullable_NoValue |  11.58 ns | 0.0444 ns | 0.0415 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  12.77 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
                                             From_Char |  15.01 ns | 0.0686 ns | 0.0641 ns |      0.0051 |           - |           - |                32 B |
                                    From_Char_AsObject |  20.44 ns | 0.1327 ns | 0.1241 ns |      0.0051 |           - |           - |                32 B |
                          From_Char_Nullable_WithValue |  14.27 ns | 0.0651 ns | 0.0608 ns |      0.0051 |           - |           - |                32 B |
                 From_Char_Nullable_WithValue_AsObject |  19.19 ns | 0.1523 ns | 0.1424 ns |      0.0051 |           - |           - |                32 B |
                            From_Char_Nullable_NoValue |  13.30 ns | 0.0445 ns | 0.0417 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  11.63 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
                                         From_DateTime | 270.65 ns | 1.7391 ns | 1.6267 ns |      0.0262 |           - |           - |               168 B |
                                From_DateTime_AsObject | 273.84 ns | 1.5185 ns | 1.4204 ns |      0.0262 |           - |           - |               168 B |
                      From_DateTime_Nullable_WithValue | 269.62 ns | 1.5300 ns | 1.4312 ns |      0.0262 |           - |           - |               168 B |
             From_DateTime_Nullable_WithValue_AsObject | 272.98 ns | 1.7080 ns | 1.5977 ns |      0.0262 |           - |           - |               168 B |
                        From_DateTime_Nullable_NoValue |  12.61 ns | 0.0750 ns | 0.0702 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  11.65 ns | 0.0760 ns | 0.0711 ns |           - |           - |           - |                   - |
                                          From_Decimal |  68.60 ns | 0.6595 ns | 0.6169 ns |      0.0050 |           - |           - |                32 B |
                                 From_Decimal_AsObject |  54.44 ns | 0.2029 ns | 0.1898 ns |      0.0051 |           - |           - |                32 B |
                       From_Decimal_Nullable_WithValue |  78.38 ns | 0.7038 ns | 0.6584 ns |      0.0050 |           - |           - |                32 B |
              From_Decimal_Nullable_WithValue_AsObject |  58.64 ns | 0.3841 ns | 0.3208 ns |      0.0050 |           - |           - |                32 B |
                         From_Decimal_Nullable_NoValue |  16.80 ns | 0.1037 ns | 0.0970 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  11.65 ns | 0.0441 ns | 0.0413 ns |           - |           - |           - |                   - |
                                           From_Double | 114.98 ns | 0.7241 ns | 0.6774 ns |      0.0050 |           - |           - |                32 B |
                                  From_Double_AsObject | 122.20 ns | 1.1910 ns | 1.1141 ns |      0.0050 |           - |           - |                32 B |
                        From_Double_Nullable_WithValue | 129.65 ns | 1.3061 ns | 1.2217 ns |      0.0050 |           - |           - |                32 B |
               From_Double_Nullable_WithValue_AsObject | 129.86 ns | 0.9339 ns | 0.8736 ns |      0.0050 |           - |           - |                32 B |
                          From_Double_Nullable_NoValue |  11.83 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  12.51 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                                            From_Short |  26.20 ns | 0.1882 ns | 0.1761 ns |      0.0051 |           - |           - |                32 B |
                                   From_Short_AsObject |  30.46 ns | 0.1964 ns | 0.1837 ns |      0.0051 |           - |           - |                32 B |
                         From_Short_Nullable_WithValue |  27.06 ns | 0.1032 ns | 0.0915 ns |      0.0051 |           - |           - |                32 B |
                From_Short_Nullable_WithValue_AsObject |  31.50 ns | 0.1864 ns | 0.1744 ns |      0.0051 |           - |           - |                32 B |
                           From_Short_Nullable_NoValue |  12.41 ns | 0.0612 ns | 0.0573 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  11.60 ns | 0.0602 ns | 0.0564 ns |           - |           - |           - |                   - |
                                              From_Int |  26.70 ns | 0.1061 ns | 0.0992 ns |      0.0051 |           - |           - |                32 B |
                                     From_Int_AsObject |  30.43 ns | 0.1432 ns | 0.1339 ns |      0.0051 |           - |           - |                32 B |
                           From_Int_Nullable_WithValue |  26.39 ns | 0.1160 ns | 0.1028 ns |      0.0051 |           - |           - |                32 B |
                  From_Int_Nullable_WithValue_AsObject |  30.65 ns | 0.2594 ns | 0.2427 ns |      0.0051 |           - |           - |                32 B |
                             From_Int_Nullable_NoValue |  12.38 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  11.58 ns | 0.0514 ns | 0.0481 ns |           - |           - |           - |                   - |
                                             From_Long |  27.21 ns | 0.1562 ns | 0.1461 ns |      0.0051 |           - |           - |                32 B |
                                    From_Long_AsObject |  31.75 ns | 0.2167 ns | 0.2027 ns |      0.0051 |           - |           - |                32 B |
                          From_Long_Nullable_WithValue |  27.59 ns | 0.1038 ns | 0.0971 ns |      0.0051 |           - |           - |                32 B |
                 From_Long_Nullable_WithValue_AsObject |  31.68 ns | 0.2426 ns | 0.2269 ns |      0.0051 |           - |           - |                32 B |
                            From_Long_Nullable_NoValue |  12.40 ns | 0.0344 ns | 0.0305 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  11.58 ns | 0.0470 ns | 0.0440 ns |           - |           - |           - |                   - |
                                            From_SByte |  26.65 ns | 0.1875 ns | 0.1754 ns |      0.0051 |           - |           - |                32 B |
                                   From_SByte_AsObject |  30.27 ns | 0.1491 ns | 0.1322 ns |      0.0051 |           - |           - |                32 B |
                         From_SByte_Nullable_WithValue |  27.01 ns | 0.1317 ns | 0.1231 ns |      0.0051 |           - |           - |                32 B |
                From_SByte_Nullable_WithValue_AsObject |  34.13 ns | 0.1155 ns | 0.0964 ns |      0.0051 |           - |           - |                32 B |
                           From_SByte_Nullable_NoValue |  12.32 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  12.50 ns | 0.0398 ns | 0.0352 ns |           - |           - |           - |                   - |
                                            From_Float | 110.42 ns | 0.7566 ns | 0.7077 ns |      0.0050 |           - |           - |                32 B |
                                   From_Float_AsObject | 116.65 ns | 0.4054 ns | 0.3594 ns |      0.0050 |           - |           - |                32 B |
                         From_Float_Nullable_WithValue | 111.59 ns | 0.4705 ns | 0.3929 ns |      0.0050 |           - |           - |                32 B |
                From_Float_Nullable_WithValue_AsObject | 115.80 ns | 0.6267 ns | 0.5556 ns |      0.0050 |           - |           - |                32 B |
                           From_Float_Nullable_NoValue |  12.15 ns | 0.0504 ns | 0.0446 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  12.92 ns | 0.0766 ns | 0.0717 ns |           - |           - |           - |                   - |
                                           From_String |  10.80 ns | 0.0706 ns | 0.0661 ns |           - |           - |           - |                   - |
                                  From_String_AsObject |  12.10 ns | 0.0332 ns | 0.0311 ns |           - |           - |           - |                   - |
                                      From_String_Null |  11.55 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  12.64 ns | 0.2162 ns | 0.2022 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  11.75 ns | 0.0451 ns | 0.0422 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |  12.07 ns | 0.0499 ns | 0.0467 ns |           - |           - |           - |                   - |
                                           From_UShort |  25.64 ns | 0.1369 ns | 0.1281 ns |      0.0051 |           - |           - |                32 B |
                                  From_UShort_AsObject |  30.59 ns | 0.2211 ns | 0.2068 ns |      0.0051 |           - |           - |                32 B |
                        From_UShort_Nullable_WithValue |  26.30 ns | 0.1368 ns | 0.1280 ns |      0.0051 |           - |           - |                32 B |
               From_UShort_Nullable_WithValue_AsObject |  34.29 ns | 0.2373 ns | 0.2220 ns |      0.0051 |           - |           - |                32 B |
                          From_UShort_Nullable_NoValue |  11.55 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  11.63 ns | 0.0630 ns | 0.0589 ns |           - |           - |           - |                   - |
                                             From_UInt |  26.04 ns | 0.1548 ns | 0.1448 ns |      0.0051 |           - |           - |                32 B |
                                    From_UInt_AsObject |  31.55 ns | 0.1831 ns | 0.1713 ns |      0.0051 |           - |           - |                32 B |
                          From_UInt_Nullable_WithValue |  26.99 ns | 0.1364 ns | 0.1276 ns |      0.0051 |           - |           - |                32 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.62 ns | 0.1076 ns | 0.1006 ns |      0.0051 |           - |           - |                32 B |
                            From_UInt_Nullable_NoValue |  12.30 ns | 0.0533 ns | 0.0498 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  11.59 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                                            From_ULong |  28.08 ns | 0.1116 ns | 0.1044 ns |      0.0051 |           - |           - |                32 B |
                                   From_ULong_AsObject |  32.74 ns | 0.1720 ns | 0.1609 ns |      0.0051 |           - |           - |                32 B |
                         From_ULong_Nullable_WithValue |  28.21 ns | 0.2203 ns | 0.2061 ns |      0.0051 |           - |           - |                32 B |
                From_ULong_Nullable_WithValue_AsObject |  31.99 ns | 0.2334 ns | 0.2184 ns |      0.0051 |           - |           - |                32 B |
                           From_ULong_Nullable_NoValue |  11.48 ns | 0.0484 ns | 0.0452 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  12.57 ns | 0.0900 ns | 0.0842 ns |           - |           - |           - |                   - |
                                       From_NullObject |  11.63 ns | 0.0744 ns | 0.0696 ns |           - |           - |           - |                   - |
                                           From_DBNull |  10.61 ns | 0.0440 ns | 0.0390 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  12.54 ns | 0.0708 ns | 0.0663 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  12.86 ns | 0.0700 ns | 0.0620 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  16.41 ns | 0.0963 ns | 0.0853 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  12.47 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  12.99 ns | 0.0642 ns | 0.0569 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  17.71 ns | 0.1104 ns | 0.1033 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  22.01 ns | 0.0858 ns | 0.0803 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  11.42 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  11.60 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  15.44 ns | 0.1046 ns | 0.0927 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  16.42 ns | 0.1441 ns | 0.1348 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  17.18 ns | 0.0733 ns | 0.0650 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  16.33 ns | 0.0828 ns | 0.0774 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.60 ns | 0.0688 ns | 0.0610 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.55 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  22.47 ns | 0.1266 ns | 0.1184 ns |      0.0038 |           - |           - |                24 B |
                    From_NonConvertibleStruct_AsObject |  23.46 ns | 0.1332 ns | 0.1246 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  21.37 ns | 0.2124 ns | 0.1773 ns |      0.0038 |           - |           - |                24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  22.01 ns | 0.0904 ns | 0.0845 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  11.23 ns | 0.0844 ns | 0.0789 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  12.82 ns | 0.0575 ns | 0.0510 ns |           - |           - |           - |                   - |
                                             From_Enum |  60.16 ns | 0.4001 ns | 0.3743 ns |      0.0038 |           - |           - |                24 B |
                                    From_Enum_AsObject |  64.89 ns | 0.4405 ns | 0.4121 ns |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue |  60.29 ns | 0.4536 ns | 0.4243 ns |      0.0038 |           - |           - |                24 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.91 ns | 0.3277 ns | 0.3065 ns |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |  11.98 ns | 0.0470 ns | 0.0393 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  13.14 ns | 0.0268 ns | 0.0237 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  17.60 ns | 0.0811 ns | 0.0759 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  22.93 ns | 0.0929 ns | 0.0869 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  11.58 ns | 0.0552 ns | 0.0517 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  12.26 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  80.42 ns | 0.3763 ns | 0.3520 ns |      0.0851 |           - |           - |               536 B |
                            From_ParentStruct_AsObject |  27.28 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 101.18 ns | 0.3867 ns | 0.3618 ns |      0.0851 |           - |           - |               536 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.87 ns | 0.1038 ns | 0.0920 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  53.68 ns | 0.2359 ns | 0.2207 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  11.60 ns | 0.0559 ns | 0.0496 ns |           - |           - |           - |                   - |
