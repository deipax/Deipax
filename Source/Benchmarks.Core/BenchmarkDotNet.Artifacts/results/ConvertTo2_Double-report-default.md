
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.57 ns | 0.0454 ns | 0.0403 ns |      - |       0 B |
                                    From_Bool_AsObject |  23.61 ns | 0.0530 ns | 0.0442 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.29 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  22.75 ns | 0.1553 ns | 0.1297 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.80 ns | 0.1039 ns | 0.0812 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.05 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                                             From_Byte |  13.45 ns | 0.0162 ns | 0.0135 ns |      - |       0 B |
                                    From_Byte_AsObject |  22.27 ns | 0.0520 ns | 0.0461 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  13.81 ns | 0.0198 ns | 0.0175 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  22.32 ns | 0.1346 ns | 0.1259 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.44 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.66 ns | 0.0429 ns | 0.0401 ns |      - |       0 B |
                                             From_Char |  13.46 ns | 0.0743 ns | 0.0658 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.69 ns | 0.0541 ns | 0.0452 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.20 ns | 0.0628 ns | 0.0587 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.03 ns | 0.1136 ns | 0.1007 ns |      - |       0 B |
                                         From_DateTime |  13.34 ns | 0.0419 ns | 0.0371 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.34 ns | 0.0488 ns | 0.0456 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.37 ns | 0.0704 ns | 0.0624 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.04 ns | 0.0648 ns | 0.0541 ns |      - |       0 B |
                                          From_Decimal |  19.70 ns | 0.4083 ns | 0.3820 ns |      - |       0 B |
                                 From_Decimal_AsObject |  29.70 ns | 0.0604 ns | 0.0472 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.05 ns | 0.1160 ns | 0.1029 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  28.14 ns | 0.2955 ns | 0.2620 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.37 ns | 0.0593 ns | 0.0525 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.22 ns | 0.2837 ns | 0.2369 ns |      - |       0 B |
                                           From_Double |  13.46 ns | 0.0320 ns | 0.0267 ns |      - |       0 B |
                                  From_Double_AsObject |  17.72 ns | 0.0933 ns | 0.0729 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.14 ns | 0.0644 ns | 0.0571 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  16.75 ns | 0.2062 ns | 0.1929 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.39 ns | 0.0793 ns | 0.0742 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.09 ns | 0.2376 ns | 0.2106 ns |      - |       0 B |
                                            From_Short |  13.48 ns | 0.0505 ns | 0.0448 ns |      - |       0 B |
                                   From_Short_AsObject |  23.12 ns | 0.1500 ns | 0.1330 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  13.94 ns | 0.1566 ns | 0.1388 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  23.30 ns | 0.4143 ns | 0.3875 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.45 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.22 ns | 0.1627 ns | 0.1358 ns |      - |       0 B |
                                              From_Int |  13.17 ns | 0.0153 ns | 0.0119 ns |      - |       0 B |
                                     From_Int_AsObject |  23.88 ns | 0.0676 ns | 0.0528 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.53 ns | 0.1409 ns | 0.1318 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  22.90 ns | 0.1463 ns | 0.1297 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.71 ns | 0.0491 ns | 0.0410 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.12 ns | 0.0650 ns | 0.0542 ns |      - |       0 B |
                                             From_Long |  13.26 ns | 0.1048 ns | 0.0980 ns |      - |       0 B |
                                    From_Long_AsObject |  23.09 ns | 0.0935 ns | 0.0781 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.56 ns | 0.0503 ns | 0.0446 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  23.26 ns | 0.0560 ns | 0.0468 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.37 ns | 0.0441 ns | 0.0391 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.11 ns | 0.0487 ns | 0.0431 ns |      - |       0 B |
                                            From_SByte |  13.46 ns | 0.0250 ns | 0.0209 ns |      - |       0 B |
                                   From_SByte_AsObject |  22.92 ns | 0.1434 ns | 0.1197 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  13.89 ns | 0.0457 ns | 0.0405 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  23.00 ns | 0.1965 ns | 0.1742 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.67 ns | 0.2696 ns | 0.2390 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.27 ns | 0.0761 ns | 0.0636 ns |      - |       0 B |
                                            From_Float |  13.54 ns | 0.1089 ns | 0.0965 ns |      - |       0 B |
                                   From_Float_AsObject |  23.83 ns | 0.0403 ns | 0.0377 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  13.86 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  22.75 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.55 ns | 0.0286 ns | 0.0238 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.20 ns | 0.0508 ns | 0.0424 ns |      - |       0 B |
                                           From_String | 107.09 ns | 0.4505 ns | 0.3762 ns |      - |       0 B |
                                  From_String_AsObject | 114.01 ns | 0.4145 ns | 0.3675 ns |      - |       0 B |
                                      From_String_Null |  14.85 ns | 0.0472 ns | 0.0394 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.16 ns | 0.1523 ns | 0.1350 ns |      - |       0 B |
                                     From_String_Empty |  15.12 ns | 0.1297 ns | 0.1083 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.27 ns | 0.0986 ns | 0.0824 ns |      - |       0 B |
                                  From_UShort_AsObject |  22.87 ns | 0.0609 ns | 0.0509 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  13.87 ns | 0.0261 ns | 0.0218 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  24.14 ns | 0.3346 ns | 0.2966 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.74 ns | 0.0270 ns | 0.0226 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.24 ns | 0.1528 ns | 0.1276 ns |      - |       0 B |
                                             From_UInt |  13.47 ns | 0.0300 ns | 0.0234 ns |      - |       0 B |
                                    From_UInt_AsObject |  24.28 ns | 0.2823 ns | 0.2641 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  13.96 ns | 0.0548 ns | 0.0458 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  23.03 ns | 0.0090 ns | 0.0071 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.57 ns | 0.1231 ns | 0.1028 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.02 ns | 0.2340 ns | 0.2189 ns |      - |       0 B |
                                            From_ULong |  13.80 ns | 0.0819 ns | 0.0766 ns |      - |       0 B |
                                   From_ULong_AsObject |  23.79 ns | 0.2493 ns | 0.2332 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.76 ns | 0.1229 ns | 0.1090 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  23.60 ns | 0.1280 ns | 0.1069 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.54 ns | 0.2244 ns | 0.1989 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.57 ns | 0.3703 ns | 0.3803 ns |      - |       0 B |
                                       From_NullObject |  16.94 ns | 0.0322 ns | 0.0269 ns |      - |       0 B |
                                           From_DBNull |  14.32 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                                  From_DBNull_AsObject |  16.03 ns | 0.1020 ns | 0.0852 ns |      - |       0 B |
                                 From_ConvertibleClass |  20.08 ns | 0.1764 ns | 0.1564 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  20.71 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.19 ns | 0.0861 ns | 0.0719 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.03 ns | 0.1317 ns | 0.1028 ns |      - |       0 B |
                              From_NonConvertibleClass |  14.24 ns | 0.0339 ns | 0.0300 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  18.86 ns | 0.0458 ns | 0.0428 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  14.04 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.08 ns | 0.0596 ns | 0.0529 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.50 ns | 0.0174 ns | 0.0163 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  22.01 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  22.87 ns | 0.4647 ns | 0.4346 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  23.26 ns | 0.2070 ns | 0.1728 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.09 ns | 0.0632 ns | 0.0591 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.08 ns | 0.1109 ns | 0.1037 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.17 ns | 0.1472 ns | 0.1377 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  17.82 ns | 0.0818 ns | 0.0725 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.32 ns | 0.0149 ns | 0.0125 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  17.81 ns | 0.0362 ns | 0.0338 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.39 ns | 0.2178 ns | 0.1931 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.57 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                                             From_Enum |  13.47 ns | 0.1312 ns | 0.1227 ns |      - |       0 B |
                                    From_Enum_AsObject |  55.99 ns | 0.0641 ns | 0.0600 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  13.95 ns | 0.1403 ns | 0.1313 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  55.54 ns | 0.0660 ns | 0.0515 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  13.82 ns | 0.0316 ns | 0.0264 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.19 ns | 0.1491 ns | 0.1395 ns |      - |       0 B |
                                      From_ParentClass |  14.21 ns | 0.1056 ns | 0.0988 ns |      - |       0 B |
                             From_ParentClass_AsObject |  18.27 ns | 0.0513 ns | 0.0428 ns |      - |       0 B |
                              From_ParentClass_NoValue |  14.20 ns | 0.0275 ns | 0.0230 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  16.15 ns | 0.2398 ns | 0.2243 ns |      - |       0 B |
                                     From_ParentStruct |  14.19 ns | 0.1500 ns | 0.1403 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  19.47 ns | 0.0463 ns | 0.0411 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.42 ns | 0.1629 ns | 0.1444 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  19.50 ns | 0.1863 ns | 0.1652 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.59 ns | 0.2984 ns | 0.2646 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  16.44 ns | 0.3602 ns | 0.4809 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Double.From_Char_AsObject: DefaultJob
  ConvertTo2_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_String_Empty_AsObject: DefaultJob
