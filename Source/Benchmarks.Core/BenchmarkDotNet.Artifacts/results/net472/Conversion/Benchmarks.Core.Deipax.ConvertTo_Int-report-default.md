
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.174 ns | 0.1067 ns | 0.0946 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 18.022 ns | 0.1107 ns | 0.1036 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.492 ns | 0.1219 ns | 0.1140 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.067 ns | 0.1203 ns | 0.1125 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.938 ns | 0.0546 ns | 0.0510 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.664 ns | 0.0575 ns | 0.0537 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.858 ns | 0.0492 ns | 0.0461 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.926 ns | 0.1311 ns | 0.1227 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.334 ns | 0.1046 ns | 0.0978 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.938 ns | 0.1205 ns | 0.1127 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.879 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 15.124 ns | 0.0763 ns | 0.0714 ns |           - |           - |           - |                   - |
                                             From_Char | 10.571 ns | 0.0415 ns | 0.0388 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.084 ns | 0.1125 ns | 0.1053 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.482 ns | 0.1559 ns | 0.1458 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.757 ns | 0.0477 ns | 0.0423 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.977 ns | 0.0422 ns | 0.0374 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 16.464 ns | 0.0459 ns | 0.0406 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.798 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.215 ns | 0.0463 ns | 0.0411 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.375 ns | 0.0219 ns | 0.0205 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.531 ns | 0.0450 ns | 0.0399 ns |           - |           - |           - |                   - |
                                          From_Decimal | 18.666 ns | 0.0999 ns | 0.0934 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 23.261 ns | 0.1237 ns | 0.1097 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.158 ns | 0.0984 ns | 0.0920 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 23.222 ns | 0.0995 ns | 0.0931 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.948 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 15.077 ns | 0.0771 ns | 0.0721 ns |           - |           - |           - |                   - |
                                           From_Double | 11.694 ns | 0.0498 ns | 0.0465 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.983 ns | 0.1473 ns | 0.1378 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.103 ns | 0.0829 ns | 0.0775 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.426 ns | 0.0748 ns | 0.0700 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.401 ns | 0.0708 ns | 0.0663 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.034 ns | 0.0580 ns | 0.0542 ns |           - |           - |           - |                   - |
                                            From_Short | 10.918 ns | 0.0539 ns | 0.0478 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.348 ns | 0.0721 ns | 0.0675 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.578 ns | 0.1424 ns | 0.1332 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 18.776 ns | 0.1551 ns | 0.1450 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.937 ns | 0.0398 ns | 0.0353 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.060 ns | 0.0521 ns | 0.0488 ns |           - |           - |           - |                   - |
                                              From_Int |  9.650 ns | 0.0550 ns | 0.0515 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 14.439 ns | 0.0276 ns | 0.0244 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  9.581 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.414 ns | 0.1364 ns | 0.1276 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  9.451 ns | 0.0364 ns | 0.0323 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 13.583 ns | 0.0465 ns | 0.0412 ns |           - |           - |           - |                   - |
                                             From_Long | 11.533 ns | 0.0608 ns | 0.0569 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.809 ns | 0.0764 ns | 0.0677 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.886 ns | 0.0725 ns | 0.0643 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.023 ns | 0.0714 ns | 0.0596 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.065 ns | 0.0537 ns | 0.0502 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 14.272 ns | 0.0455 ns | 0.0403 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.329 ns | 0.0695 ns | 0.0650 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.471 ns | 0.1178 ns | 0.1102 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.308 ns | 0.1051 ns | 0.0983 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 19.059 ns | 0.1172 ns | 0.1097 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.873 ns | 0.0393 ns | 0.0368 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.035 ns | 0.0439 ns | 0.0389 ns |           - |           - |           - |                   - |
                                            From_Float | 12.131 ns | 0.0416 ns | 0.0389 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.118 ns | 0.1224 ns | 0.1145 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.852 ns | 0.1008 ns | 0.0894 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 18.267 ns | 0.0848 ns | 0.0794 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.934 ns | 0.0521 ns | 0.0461 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.617 ns | 0.0431 ns | 0.0382 ns |           - |           - |           - |                   - |
                                           From_String | 64.425 ns | 0.2324 ns | 0.2060 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 66.655 ns | 0.3501 ns | 0.3104 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.052 ns | 0.0463 ns | 0.0433 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.025 ns | 0.0273 ns | 0.0228 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.767 ns | 0.0371 ns | 0.0347 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.662 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 18.731 ns | 0.1123 ns | 0.1051 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.396 ns | 0.1636 ns | 0.1530 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.750 ns | 0.1250 ns | 0.1169 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.967 ns | 0.0294 ns | 0.0246 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.601 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.065 ns | 0.0446 ns | 0.0418 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 19.339 ns | 0.1207 ns | 0.1129 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.371 ns | 0.1652 ns | 0.1545 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 16.555 ns | 0.0767 ns | 0.0718 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.044 ns | 0.0563 ns | 0.0527 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 13.553 ns | 0.0442 ns | 0.0392 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.488 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.153 ns | 0.1064 ns | 0.0996 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.822 ns | 0.0445 ns | 0.0394 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 18.586 ns | 0.1014 ns | 0.0899 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.453 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.381 ns | 0.0419 ns | 0.0371 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.443 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.755 ns | 0.0407 ns | 0.0381 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.572 ns | 0.0835 ns | 0.0781 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 16.957 ns | 0.0427 ns | 0.0400 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.656 ns | 0.0637 ns | 0.0596 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.999 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.297 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.034 ns | 0.0649 ns | 0.0607 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.663 ns | 0.0595 ns | 0.0527 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.604 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.681 ns | 0.0443 ns | 0.0414 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.848 ns | 0.0536 ns | 0.0475 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 15.412 ns | 0.1176 ns | 0.1100 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.573 ns | 0.0764 ns | 0.0715 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.195 ns | 0.0943 ns | 0.0882 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 10.997 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.464 ns | 0.0340 ns | 0.0302 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.797 ns | 0.0487 ns | 0.0456 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.160 ns | 0.1255 ns | 0.1048 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.808 ns | 0.0338 ns | 0.0316 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.134 ns | 0.1027 ns | 0.0960 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.877 ns | 0.0827 ns | 0.0774 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.050 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.817 ns | 0.1300 ns | 0.1216 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.952 ns | 0.2724 ns | 0.2548 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.501 ns | 0.1164 ns | 0.1032 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 40.704 ns | 0.1829 ns | 0.1711 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.915 ns | 0.0583 ns | 0.0546 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.998 ns | 0.0422 ns | 0.0394 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.695 ns | 0.0683 ns | 0.0639 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.761 ns | 0.0305 ns | 0.0285 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.414 ns | 0.0365 ns | 0.0324 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.186 ns | 0.0462 ns | 0.0432 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.308 ns | 0.1806 ns | 0.1689 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.665 ns | 0.0732 ns | 0.0684 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 45.334 ns | 0.1655 ns | 0.1382 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.786 ns | 0.0577 ns | 0.0539 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.593 ns | 0.1515 ns | 0.1417 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 14.322 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Int.From_String_Empty_AsObject: DefaultJob
