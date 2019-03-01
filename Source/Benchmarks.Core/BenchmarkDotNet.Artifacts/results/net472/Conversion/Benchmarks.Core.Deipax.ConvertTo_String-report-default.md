
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |     StdDev |    Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|-----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  12.58 ns | 0.0491 ns |  0.0435 ns |  12.58 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |  17.62 ns | 0.0894 ns |  0.0836 ns |  17.58 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  14.55 ns | 0.0711 ns |  0.0630 ns |  14.55 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |  16.31 ns | 0.1108 ns |  0.1037 ns |  16.25 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  14.17 ns | 0.0272 ns |  0.0254 ns |  14.17 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  12.46 ns | 0.0621 ns |  0.0581 ns |  12.45 ns |           - |           - |           - |                   - |
                                             From_Byte |  45.46 ns | 0.2515 ns |  0.2352 ns |  45.46 ns |      0.0051 |           - |           - |                32 B |
                                    From_Byte_AsObject |  57.53 ns | 0.1636 ns |  0.1530 ns |  57.54 ns |      0.0051 |           - |           - |                32 B |
                          From_Byte_Nullable_WithValue |  44.86 ns | 0.1327 ns |  0.1036 ns |  44.88 ns |      0.0051 |           - |           - |                32 B |
                 From_Byte_Nullable_WithValue_AsObject |  51.44 ns | 0.1733 ns |  0.1621 ns |  51.42 ns |      0.0051 |           - |           - |                32 B |
                            From_Byte_Nullable_NoValue |  12.90 ns | 0.0482 ns |  0.0451 ns |  12.90 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  13.30 ns | 0.0370 ns |  0.0346 ns |  13.29 ns |           - |           - |           - |                   - |
                                             From_Char |  18.32 ns | 0.0853 ns |  0.0798 ns |  18.31 ns |      0.0051 |           - |           - |                32 B |
                                    From_Char_AsObject |  22.91 ns | 0.0865 ns |  0.0809 ns |  22.94 ns |      0.0051 |           - |           - |                32 B |
                          From_Char_Nullable_WithValue |  17.42 ns | 0.1035 ns |  0.0968 ns |  17.38 ns |      0.0051 |           - |           - |                32 B |
                 From_Char_Nullable_WithValue_AsObject |  21.78 ns | 0.1109 ns |  0.1038 ns |  21.78 ns |      0.0051 |           - |           - |                32 B |
                            From_Char_Nullable_NoValue |  13.21 ns | 0.1178 ns |  0.1102 ns |  13.23 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  12.49 ns | 0.0459 ns |  0.0429 ns |  12.50 ns |           - |           - |           - |                   - |
                                         From_DateTime | 318.15 ns | 1.4829 ns |  1.3871 ns | 317.81 ns |      0.0300 |           - |           - |               192 B |
                                From_DateTime_AsObject | 323.90 ns | 1.3616 ns |  1.2070 ns | 323.58 ns |      0.0300 |           - |           - |               192 B |
                      From_DateTime_Nullable_WithValue | 323.36 ns | 1.5099 ns |  1.4124 ns | 323.35 ns |      0.0300 |           - |           - |               192 B |
             From_DateTime_Nullable_WithValue_AsObject | 324.08 ns | 1.1358 ns |  1.0624 ns | 324.09 ns |      0.0300 |           - |           - |               192 B |
                        From_DateTime_Nullable_NoValue |  14.61 ns | 0.0652 ns |  0.0578 ns |  14.60 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  13.46 ns | 0.0764 ns |  0.0715 ns |  13.45 ns |           - |           - |           - |                   - |
                                          From_Decimal |  60.21 ns | 0.1844 ns |  0.1635 ns |  60.26 ns |      0.0050 |           - |           - |                32 B |
                                 From_Decimal_AsObject |  61.96 ns | 0.3908 ns |  0.3655 ns |  61.96 ns |      0.0050 |           - |           - |                32 B |
                       From_Decimal_Nullable_WithValue |  59.71 ns | 0.2209 ns |  0.2066 ns |  59.74 ns |      0.0050 |           - |           - |                32 B |
              From_Decimal_Nullable_WithValue_AsObject |  61.71 ns | 0.5022 ns |  0.4451 ns |  61.63 ns |      0.0050 |           - |           - |                32 B |
                         From_Decimal_Nullable_NoValue |  13.31 ns | 0.0295 ns |  0.0276 ns |  13.31 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  13.39 ns | 0.0672 ns |  0.0561 ns |  13.39 ns |           - |           - |           - |                   - |
                                           From_Double | 299.15 ns | 2.3013 ns |  2.1527 ns | 298.59 ns |      0.0048 |           - |           - |                32 B |
                                  From_Double_AsObject | 299.05 ns | 1.6292 ns |  1.5240 ns | 299.13 ns |      0.0048 |           - |           - |                32 B |
                        From_Double_Nullable_WithValue | 308.29 ns | 6.2528 ns | 13.1893 ns | 302.50 ns |      0.0048 |           - |           - |                32 B |
               From_Double_Nullable_WithValue_AsObject | 301.78 ns | 2.4549 ns |  2.1762 ns | 301.28 ns |      0.0048 |           - |           - |                32 B |
                          From_Double_Nullable_NoValue |  12.83 ns | 0.0634 ns |  0.0593 ns |  12.83 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  12.90 ns | 0.0521 ns |  0.0462 ns |  12.90 ns |           - |           - |           - |                   - |
                                            From_Short |  45.63 ns | 0.1532 ns |  0.1358 ns |  45.60 ns |      0.0051 |           - |           - |                32 B |
                                   From_Short_AsObject |  58.38 ns | 0.2360 ns |  0.2208 ns |  58.32 ns |      0.0050 |           - |           - |                32 B |
                         From_Short_Nullable_WithValue |  50.84 ns | 0.1619 ns |  0.1514 ns |  50.83 ns |      0.0051 |           - |           - |                32 B |
                From_Short_Nullable_WithValue_AsObject |  50.60 ns | 0.3008 ns |  0.2813 ns |  50.55 ns |      0.0051 |           - |           - |                32 B |
                           From_Short_Nullable_NoValue |  12.43 ns | 0.0265 ns |  0.0248 ns |  12.43 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  12.51 ns | 0.0542 ns |  0.0507 ns |  12.49 ns |           - |           - |           - |                   - |
                                              From_Int |  45.14 ns | 0.1437 ns |  0.1200 ns |  45.17 ns |      0.0051 |           - |           - |                32 B |
                                     From_Int_AsObject |  50.18 ns | 0.2093 ns |  0.1958 ns |  50.14 ns |      0.0051 |           - |           - |                32 B |
                           From_Int_Nullable_WithValue |  44.85 ns | 0.2180 ns |  0.2039 ns |  44.72 ns |      0.0051 |           - |           - |                32 B |
                  From_Int_Nullable_WithValue_AsObject |  50.21 ns | 0.1551 ns |  0.1451 ns |  50.19 ns |      0.0051 |           - |           - |                32 B |
                             From_Int_Nullable_NoValue |  12.42 ns | 0.0555 ns |  0.0492 ns |  12.42 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  13.34 ns | 0.0803 ns |  0.0751 ns |  13.33 ns |           - |           - |           - |                   - |
                                             From_Long |  45.16 ns | 0.1962 ns |  0.1835 ns |  45.14 ns |      0.0051 |           - |           - |                32 B |
                                    From_Long_AsObject |  49.71 ns | 0.2276 ns |  0.2129 ns |  49.66 ns |      0.0051 |           - |           - |                32 B |
                          From_Long_Nullable_WithValue |  56.25 ns | 0.1332 ns |  0.1246 ns |  56.22 ns |      0.0051 |           - |           - |                32 B |
                 From_Long_Nullable_WithValue_AsObject |  55.55 ns | 0.2196 ns |  0.2054 ns |  55.61 ns |      0.0051 |           - |           - |                32 B |
                            From_Long_Nullable_NoValue |  13.10 ns | 0.0661 ns |  0.0619 ns |  13.08 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  13.96 ns | 0.0530 ns |  0.0496 ns |  13.95 ns |           - |           - |           - |                   - |
                                            From_SByte |  45.26 ns | 0.1976 ns |  0.1848 ns |  45.24 ns |      0.0051 |           - |           - |                32 B |
                                   From_SByte_AsObject |  50.46 ns | 0.1154 ns |  0.1080 ns |  50.46 ns |      0.0051 |           - |           - |                32 B |
                         From_SByte_Nullable_WithValue |  44.87 ns | 0.1475 ns |  0.1380 ns |  44.82 ns |      0.0051 |           - |           - |                32 B |
                From_SByte_Nullable_WithValue_AsObject |  60.07 ns | 0.4053 ns |  0.3791 ns |  60.03 ns |      0.0050 |           - |           - |                32 B |
                           From_SByte_Nullable_NoValue |  12.37 ns | 0.0182 ns |  0.0161 ns |  12.37 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  13.30 ns | 0.0803 ns |  0.0751 ns |  13.26 ns |           - |           - |           - |                   - |
                                            From_Float | 281.37 ns | 0.8654 ns |  0.7671 ns | 281.22 ns |      0.0048 |           - |           - |                32 B |
                                   From_Float_AsObject | 289.29 ns | 1.3670 ns |  1.2787 ns | 289.48 ns |      0.0048 |           - |           - |                32 B |
                         From_Float_Nullable_WithValue | 276.49 ns | 1.3607 ns |  1.2728 ns | 276.39 ns |      0.0048 |           - |           - |                32 B |
                From_Float_Nullable_WithValue_AsObject | 287.32 ns | 1.5451 ns |  1.2903 ns | 287.43 ns |      0.0048 |           - |           - |                32 B |
                           From_Float_Nullable_NoValue |  14.27 ns | 0.0685 ns |  0.0641 ns |  14.25 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  13.31 ns | 0.0694 ns |  0.0649 ns |  13.28 ns |           - |           - |           - |                   - |
                                           From_String |  13.13 ns | 0.0353 ns |  0.0330 ns |  13.12 ns |           - |           - |           - |                   - |
                                  From_String_AsObject |  13.56 ns | 0.0521 ns |  0.0435 ns |  13.56 ns |           - |           - |           - |                   - |
                                      From_String_Null |  11.20 ns | 0.0503 ns |  0.0470 ns |  11.19 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  14.08 ns | 0.0792 ns |  0.0740 ns |  14.05 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  11.15 ns | 0.0379 ns |  0.0355 ns |  11.14 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |  13.59 ns | 0.0935 ns |  0.0875 ns |  13.56 ns |           - |           - |           - |                   - |
                                           From_UShort |  43.24 ns | 0.1234 ns |  0.1031 ns |  43.23 ns |      0.0051 |           - |           - |                32 B |
                                  From_UShort_AsObject |  48.53 ns | 0.2686 ns |  0.2513 ns |  48.44 ns |      0.0051 |           - |           - |                32 B |
                        From_UShort_Nullable_WithValue |  50.08 ns | 0.2349 ns |  0.2197 ns |  50.01 ns |      0.0051 |           - |           - |                32 B |
               From_UShort_Nullable_WithValue_AsObject |  49.32 ns | 0.1452 ns |  0.1287 ns |  49.32 ns |      0.0051 |           - |           - |                32 B |
                          From_UShort_Nullable_NoValue |  13.88 ns | 0.0437 ns |  0.0387 ns |  13.87 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  13.32 ns | 0.0440 ns |  0.0411 ns |  13.32 ns |           - |           - |           - |                   - |
                                             From_UInt |  43.41 ns | 0.1839 ns |  0.1720 ns |  43.45 ns |      0.0051 |           - |           - |                32 B |
                                    From_UInt_AsObject |  48.94 ns | 0.1253 ns |  0.1047 ns |  48.92 ns |      0.0051 |           - |           - |                32 B |
                          From_UInt_Nullable_WithValue |  44.69 ns | 0.1674 ns |  0.1566 ns |  44.67 ns |      0.0051 |           - |           - |                32 B |
                 From_UInt_Nullable_WithValue_AsObject |  49.77 ns | 0.1192 ns |  0.1115 ns |  49.73 ns |      0.0051 |           - |           - |                32 B |
                            From_UInt_Nullable_NoValue |  12.42 ns | 0.0423 ns |  0.0396 ns |  12.42 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  13.84 ns | 0.0388 ns |  0.0363 ns |  13.84 ns |           - |           - |           - |                   - |
                                            From_ULong |  43.54 ns | 0.1659 ns |  0.1385 ns |  43.51 ns |      0.0051 |           - |           - |                32 B |
                                   From_ULong_AsObject |  49.87 ns | 0.1753 ns |  0.1640 ns |  49.80 ns |      0.0051 |           - |           - |                32 B |
                         From_ULong_Nullable_WithValue |  45.00 ns | 0.1788 ns |  0.1672 ns |  44.96 ns |      0.0051 |           - |           - |                32 B |
                From_ULong_Nullable_WithValue_AsObject |  49.90 ns | 0.1962 ns |  0.1835 ns |  49.82 ns |      0.0051 |           - |           - |                32 B |
                           From_ULong_Nullable_NoValue |  12.89 ns | 0.0289 ns |  0.0256 ns |  12.89 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  13.67 ns | 0.3433 ns |  0.3525 ns |  13.59 ns |           - |           - |           - |                   - |
                                       From_NullObject |  13.28 ns | 0.0284 ns |  0.0221 ns |  13.28 ns |           - |           - |           - |                   - |
                                           From_DBNull |  12.23 ns | 0.0617 ns |  0.0577 ns |  12.21 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  12.51 ns | 0.0569 ns |  0.0532 ns |  12.52 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  17.08 ns | 0.0714 ns |  0.0668 ns |  17.06 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  17.56 ns | 0.0672 ns |  0.0596 ns |  17.57 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  13.75 ns | 0.0641 ns |  0.0600 ns |  13.75 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  12.51 ns | 0.0513 ns |  0.0480 ns |  12.49 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  20.79 ns | 0.0610 ns |  0.0571 ns |  20.79 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  24.50 ns | 0.0884 ns |  0.0827 ns |  24.52 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  13.80 ns | 0.0410 ns |  0.0383 ns |  13.80 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  12.48 ns | 0.0396 ns |  0.0371 ns |  12.47 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  18.17 ns | 0.1110 ns |  0.1039 ns |  18.13 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  17.78 ns | 0.1008 ns |  0.0943 ns |  17.78 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  17.65 ns | 0.0655 ns |  0.0580 ns |  17.67 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  17.69 ns | 0.0733 ns |  0.0686 ns |  17.70 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  13.31 ns | 0.0742 ns |  0.0658 ns |  13.29 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  13.34 ns | 0.0552 ns |  0.0517 ns |  13.32 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  22.49 ns | 0.1106 ns |  0.1034 ns |  22.48 ns |      0.0038 |           - |           - |                24 B |
                    From_NonConvertibleStruct_AsObject |  23.71 ns | 0.0702 ns |  0.0656 ns |  23.72 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  23.68 ns | 0.0972 ns |  0.0910 ns |  23.67 ns |      0.0038 |           - |           - |                24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.46 ns | 0.0948 ns |  0.0840 ns |  24.43 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  12.43 ns | 0.0547 ns |  0.0512 ns |  12.42 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  13.03 ns | 0.0313 ns |  0.0292 ns |  13.03 ns |           - |           - |           - |                   - |
                                             From_Enum | 286.55 ns | 1.3716 ns |  1.2158 ns | 286.29 ns |      0.0114 |           - |           - |                72 B |
                                    From_Enum_AsObject | 287.64 ns | 1.9279 ns |  1.8034 ns | 287.17 ns |      0.0076 |           - |           - |                48 B |
                          From_Enum_Nullable_WithValue | 291.11 ns | 1.4447 ns |  1.3513 ns | 290.95 ns |      0.0114 |           - |           - |                72 B |
                 From_Enum_Nullable_WithValue_AsObject | 289.79 ns | 1.1868 ns |  1.1102 ns | 289.62 ns |      0.0076 |           - |           - |                48 B |
                            From_Enum_Nullable_NoValue |  13.75 ns | 0.0389 ns |  0.0364 ns |  13.75 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  13.28 ns | 0.0510 ns |  0.0477 ns |  13.26 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  19.61 ns | 0.1279 ns |  0.1196 ns |  19.57 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  24.15 ns | 0.0865 ns |  0.0809 ns |  24.12 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  13.59 ns | 0.0410 ns |  0.0342 ns |  13.57 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  13.00 ns | 0.0337 ns |  0.0315 ns |  13.01 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  79.62 ns | 0.2328 ns |  0.2178 ns |  79.63 ns |      0.0851 |           - |           - |               536 B |
                            From_ParentStruct_AsObject |  24.10 ns | 0.0831 ns |  0.0777 ns |  24.06 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 107.89 ns | 0.5148 ns |  0.4815 ns | 107.88 ns |      0.0851 |           - |           - |               536 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.92 ns | 0.0633 ns |  0.0561 ns |  24.92 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  55.45 ns | 0.1425 ns |  0.1333 ns |  55.39 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  13.04 ns | 0.0449 ns |  0.0420 ns |  13.04 ns |           - |           - |           - |                   - |
