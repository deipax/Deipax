
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  25.06 ns | 0.3509 ns | 0.3282 ns |      - |       0 B |
                                    From_Bool_AsObject |  44.27 ns | 0.4409 ns | 0.3909 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  24.91 ns | 0.2120 ns | 0.1983 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  42.78 ns | 0.8643 ns | 0.7662 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.19 ns | 0.1883 ns | 0.1670 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.83 ns | 0.0408 ns | 0.0341 ns |      - |       0 B |
                                             From_Byte |  24.66 ns | 0.1482 ns | 0.1386 ns |      - |       0 B |
                                    From_Byte_AsObject |  42.85 ns | 0.5916 ns | 0.5245 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  24.64 ns | 0.4724 ns | 0.4418 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  42.92 ns | 0.6453 ns | 0.6036 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.20 ns | 0.2364 ns | 0.2095 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  15.92 ns | 0.1252 ns | 0.1110 ns |      - |       0 B |
                                             From_Char |  24.56 ns | 0.1402 ns | 0.1243 ns |      - |       0 B |
                                    From_Char_AsObject |  43.22 ns | 0.4586 ns | 0.3829 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  24.51 ns | 0.0500 ns | 0.0390 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  43.44 ns | 0.7290 ns | 0.6819 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.05 ns | 0.1046 ns | 0.0874 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.68 ns | 0.0609 ns | 0.0508 ns |      - |       0 B |
                                         From_DateTime |  26.08 ns | 0.4144 ns | 0.3673 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  25.31 ns | 0.1048 ns | 0.0875 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.54 ns | 0.1542 ns | 0.1367 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.36 ns | 0.1681 ns | 0.1490 ns |      - |       0 B |
                                          From_Decimal |  35.19 ns | 0.1097 ns | 0.0916 ns |      - |       0 B |
                                 From_Decimal_AsObject |  53.85 ns | 0.8334 ns | 0.7796 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  34.30 ns | 0.3260 ns | 0.2890 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  52.35 ns | 0.2515 ns | 0.2100 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.56 ns | 0.0412 ns | 0.0344 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.79 ns | 0.0463 ns | 0.0411 ns |      - |       0 B |
                                           From_Double |  26.97 ns | 0.4047 ns | 0.3785 ns |      - |       0 B |
                                  From_Double_AsObject |  43.83 ns | 0.1569 ns | 0.1310 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  28.12 ns | 0.0833 ns | 0.0739 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  43.80 ns | 0.1036 ns | 0.0969 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.46 ns | 0.1272 ns | 0.1127 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.95 ns | 0.2006 ns | 0.1877 ns |      - |       0 B |
                                            From_Short |  24.63 ns | 0.1595 ns | 0.1414 ns |      - |       0 B |
                                   From_Short_AsObject |  42.10 ns | 0.2133 ns | 0.1891 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  24.81 ns | 0.2736 ns | 0.2560 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  43.24 ns | 0.6697 ns | 0.6265 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.02 ns | 0.1525 ns | 0.1426 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.92 ns | 0.1559 ns | 0.1458 ns |      - |       0 B |
                                              From_Int |  23.88 ns | 0.1991 ns | 0.1862 ns |      - |       0 B |
                                     From_Int_AsObject |  36.37 ns | 0.1456 ns | 0.1362 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  24.37 ns | 0.2869 ns | 0.2543 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  36.51 ns | 0.4197 ns | 0.3926 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.98 ns | 0.1843 ns | 0.1724 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.18 ns | 0.0476 ns | 0.0398 ns |      - |       0 B |
                                             From_Long |  26.03 ns | 0.1600 ns | 0.1336 ns |      - |       0 B |
                                    From_Long_AsObject |  44.23 ns | 0.1100 ns | 0.1029 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  26.28 ns | 0.0567 ns | 0.0531 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  43.49 ns | 0.1270 ns | 0.1060 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.66 ns | 0.1500 ns | 0.1404 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.71 ns | 0.0520 ns | 0.0486 ns |      - |       0 B |
                                            From_SByte |  24.57 ns | 0.1497 ns | 0.1327 ns |      - |       0 B |
                                   From_SByte_AsObject |  42.35 ns | 0.2892 ns | 0.2705 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  24.23 ns | 0.0979 ns | 0.0868 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  42.33 ns | 0.3360 ns | 0.3143 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.11 ns | 0.0968 ns | 0.0906 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  15.89 ns | 0.0990 ns | 0.0878 ns |      - |       0 B |
                                            From_Float |  27.47 ns | 0.1958 ns | 0.1832 ns |      - |       0 B |
                                   From_Float_AsObject |  44.27 ns | 0.0871 ns | 0.0728 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  27.20 ns | 0.1925 ns | 0.1800 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  44.29 ns | 0.4315 ns | 0.4036 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.83 ns | 0.0683 ns | 0.0639 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.83 ns | 0.0563 ns | 0.0499 ns |      - |       0 B |
                                           From_String |  56.65 ns | 0.1555 ns | 0.1298 ns |      - |       0 B |
                                  From_String_AsObject |  49.90 ns | 0.2228 ns | 0.2084 ns |      - |       0 B |
                                      From_String_Null |  16.29 ns | 0.0887 ns | 0.0830 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.86 ns | 0.1982 ns | 0.1854 ns |      - |       0 B |
                                     From_String_Empty |  14.96 ns | 0.2854 ns | 0.2670 ns |      - |       0 B |
                            From_String_Empty_AsObject |  27.16 ns | 0.2258 ns | 0.2112 ns |      - |       0 B |
                                           From_UShort |  24.71 ns | 0.1348 ns | 0.1195 ns |      - |       0 B |
                                  From_UShort_AsObject |  42.01 ns | 0.2304 ns | 0.2043 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  24.51 ns | 0.0600 ns | 0.0532 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  42.13 ns | 0.1678 ns | 0.1487 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.20 ns | 0.0568 ns | 0.0504 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.81 ns | 0.1353 ns | 0.1266 ns |      - |       0 B |
                                             From_UInt |  25.28 ns | 0.0684 ns | 0.0640 ns |      - |       0 B |
                                    From_UInt_AsObject |  42.58 ns | 0.2115 ns | 0.1979 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  24.90 ns | 0.2175 ns | 0.2034 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  42.32 ns | 0.1455 ns | 0.1290 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.21 ns | 0.1545 ns | 0.1445 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.20 ns | 0.0624 ns | 0.0584 ns |      - |       0 B |
                                            From_ULong |  25.55 ns | 0.0499 ns | 0.0442 ns |      - |       0 B |
                                   From_ULong_AsObject |  43.54 ns | 0.3338 ns | 0.3123 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  26.07 ns | 0.0876 ns | 0.0777 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  43.80 ns | 0.2467 ns | 0.2187 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.54 ns | 0.0636 ns | 0.0595 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.83 ns | 0.0940 ns | 0.0834 ns |      - |       0 B |
                                       From_NullObject |  17.63 ns | 0.0696 ns | 0.0581 ns |      - |       0 B |
                                           From_DBNull |  15.65 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
                                  From_DBNull_AsObject |  15.86 ns | 0.0457 ns | 0.0406 ns |      - |       0 B |
                                 From_ConvertibleClass |  31.70 ns | 0.2659 ns | 0.2487 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  39.88 ns | 0.1208 ns | 0.1071 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.21 ns | 0.0486 ns | 0.0406 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.98 ns | 0.2119 ns | 0.1982 ns |      - |       0 B |
                              From_NonConvertibleClass |  25.05 ns | 0.0263 ns | 0.0206 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  36.66 ns | 0.1374 ns | 0.1285 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.18 ns | 0.0370 ns | 0.0346 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.82 ns | 0.0452 ns | 0.0378 ns |      - |       0 B |
                                From_ConvertibleStruct |  35.14 ns | 0.1826 ns | 0.1619 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  41.11 ns | 0.2938 ns | 0.2748 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  34.36 ns | 0.2077 ns | 0.1734 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  41.08 ns | 0.0891 ns | 0.0834 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.82 ns | 0.0462 ns | 0.0432 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.97 ns | 0.0937 ns | 0.0876 ns |      - |       0 B |
                             From_NonConvertibleStruct |  24.77 ns | 0.0617 ns | 0.0577 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  38.01 ns | 0.0970 ns | 0.0860 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  24.28 ns | 0.1229 ns | 0.1149 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  36.49 ns | 0.1389 ns | 0.1231 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.80 ns | 0.0312 ns | 0.0260 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.86 ns | 0.0812 ns | 0.0759 ns |      - |       0 B |
                                             From_Enum |  14.37 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                                    From_Enum_AsObject |  17.72 ns | 0.1452 ns | 0.1287 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue |  14.17 ns | 0.0344 ns | 0.0287 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  17.00 ns | 0.1534 ns | 0.1359 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue |  14.24 ns | 0.1122 ns | 0.0876 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.44 ns | 0.3564 ns | 0.4243 ns |      - |       0 B |
                                      From_ParentClass |  26.59 ns | 0.2696 ns | 0.2390 ns |      - |       0 B |
                             From_ParentClass_AsObject |  37.22 ns | 0.1380 ns | 0.1224 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.69 ns | 0.0432 ns | 0.0361 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  15.90 ns | 0.0838 ns | 0.0784 ns |      - |       0 B |
                                     From_ParentStruct | 148.80 ns | 0.4039 ns | 0.3581 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  37.05 ns | 0.0851 ns | 0.0710 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 150.39 ns | 0.4850 ns | 0.4537 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  38.93 ns | 0.1490 ns | 0.1394 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  96.60 ns | 0.4646 ns | 0.4346 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  16.69 ns | 0.0648 ns | 0.0575 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
