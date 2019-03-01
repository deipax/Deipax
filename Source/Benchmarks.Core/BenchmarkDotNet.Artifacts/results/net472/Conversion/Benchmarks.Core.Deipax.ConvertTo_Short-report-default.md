
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.320 ns | 0.1463 ns | 0.1368 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.931 ns | 0.0805 ns | 0.0753 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.359 ns | 0.1000 ns | 0.0935 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.063 ns | 0.0814 ns | 0.0761 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.105 ns | 0.1188 ns | 0.0992 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.629 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                                             From_Byte | 11.341 ns | 0.0519 ns | 0.0460 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.169 ns | 0.0779 ns | 0.0729 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.152 ns | 0.1108 ns | 0.1037 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.305 ns | 0.1359 ns | 0.1271 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.925 ns | 0.0451 ns | 0.0422 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 15.158 ns | 0.0444 ns | 0.0415 ns |           - |           - |           - |                   - |
                                             From_Char | 11.274 ns | 0.1012 ns | 0.0947 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.549 ns | 0.0835 ns | 0.0781 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.541 ns | 0.1702 ns | 0.1592 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.434 ns | 0.1222 ns | 0.1143 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.907 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.619 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.817 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.346 ns | 0.0577 ns | 0.0539 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.295 ns | 0.0347 ns | 0.0325 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.301 ns | 0.0779 ns | 0.0729 ns |           - |           - |           - |                   - |
                                          From_Decimal | 24.762 ns | 0.0512 ns | 0.0479 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 27.098 ns | 0.1352 ns | 0.1198 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.992 ns | 0.1230 ns | 0.1151 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 26.087 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.317 ns | 0.0846 ns | 0.0791 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.026 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
                                           From_Double | 13.872 ns | 0.0667 ns | 0.0624 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 20.004 ns | 0.1219 ns | 0.1140 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.990 ns | 0.0674 ns | 0.0563 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.082 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.429 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.538 ns | 0.0751 ns | 0.0702 ns |           - |           - |           - |                   - |
                                            From_Short | 10.822 ns | 0.0322 ns | 0.0285 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 14.335 ns | 0.0818 ns | 0.0765 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  9.566 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 12.848 ns | 0.0439 ns | 0.0410 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.524 ns | 0.0553 ns | 0.0517 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.276 ns | 0.0574 ns | 0.0537 ns |           - |           - |           - |                   - |
                                              From_Int | 11.242 ns | 0.0545 ns | 0.0483 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 18.699 ns | 0.1489 ns | 0.1393 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.321 ns | 0.2297 ns | 0.2148 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.956 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.956 ns | 0.0422 ns | 0.0394 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 15.011 ns | 0.0606 ns | 0.0567 ns |           - |           - |           - |                   - |
                                             From_Long | 11.550 ns | 0.0706 ns | 0.0660 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.016 ns | 0.0936 ns | 0.0830 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.356 ns | 0.0948 ns | 0.0887 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 18.800 ns | 0.0777 ns | 0.0727 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.710 ns | 0.0596 ns | 0.0558 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.055 ns | 0.0318 ns | 0.0298 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.864 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 18.950 ns | 0.1638 ns | 0.1532 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.267 ns | 0.1043 ns | 0.0975 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.380 ns | 0.0879 ns | 0.0822 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.927 ns | 0.0665 ns | 0.0589 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.892 ns | 0.0581 ns | 0.0543 ns |           - |           - |           - |                   - |
                                            From_Float | 14.266 ns | 0.0989 ns | 0.0826 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 22.968 ns | 0.1922 ns | 0.1704 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 16.221 ns | 0.0873 ns | 0.0729 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 20.540 ns | 0.2586 ns | 0.2293 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.942 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.618 ns | 0.0443 ns | 0.0392 ns |           - |           - |           - |                   - |
                                           From_String | 71.328 ns | 0.3088 ns | 0.2889 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 70.017 ns | 0.3509 ns | 0.3283 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.049 ns | 0.0548 ns | 0.0486 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 15.752 ns | 0.0566 ns | 0.0530 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.037 ns | 0.0599 ns | 0.0560 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.300 ns | 0.0628 ns | 0.0587 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.842 ns | 0.1312 ns | 0.1227 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.000 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.642 ns | 0.1292 ns | 0.1209 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.953 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.722 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.132 ns | 0.0426 ns | 0.0399 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 18.471 ns | 0.0764 ns | 0.0715 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 14.688 ns | 0.0353 ns | 0.0313 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 16.607 ns | 0.0904 ns | 0.0846 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.949 ns | 0.0562 ns | 0.0526 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.322 ns | 0.0428 ns | 0.0380 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.389 ns | 0.0586 ns | 0.0549 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 16.774 ns | 0.0862 ns | 0.0806 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.137 ns | 0.0583 ns | 0.0546 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.563 ns | 0.0834 ns | 0.0780 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.380 ns | 0.0264 ns | 0.0234 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.896 ns | 0.0483 ns | 0.0452 ns |           - |           - |           - |                   - |
                                       From_NullObject | 13.599 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.544 ns | 0.0430 ns | 0.0402 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.030 ns | 0.0472 ns | 0.0419 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.631 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.485 ns | 0.0777 ns | 0.0727 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 14.850 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.090 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.613 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 16.265 ns | 0.0923 ns | 0.0863 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.474 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.242 ns | 0.0395 ns | 0.0351 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.217 ns | 0.1091 ns | 0.1021 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.301 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.622 ns | 0.1126 ns | 0.1053 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.292 ns | 0.0806 ns | 0.0754 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 10.991 ns | 0.0515 ns | 0.0481 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.650 ns | 0.0554 ns | 0.0491 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.822 ns | 0.0461 ns | 0.0408 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.084 ns | 0.0944 ns | 0.0883 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.824 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.801 ns | 0.1341 ns | 0.1254 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.865 ns | 0.0336 ns | 0.0262 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 14.041 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.136 ns | 0.0656 ns | 0.0614 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.453 ns | 0.1727 ns | 0.1531 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.410 ns | 0.1751 ns | 0.1638 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.963 ns | 0.2711 ns | 0.2535 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.897 ns | 0.0660 ns | 0.0617 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 14.761 ns | 0.0372 ns | 0.0330 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.366 ns | 0.0502 ns | 0.0469 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.886 ns | 0.0895 ns | 0.0838 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.998 ns | 0.0468 ns | 0.0438 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 14.332 ns | 0.0830 ns | 0.0776 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 50.943 ns | 0.1764 ns | 0.1564 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.994 ns | 0.0651 ns | 0.0577 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.507 ns | 0.2391 ns | 0.2236 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 16.558 ns | 0.0927 ns | 0.0867 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.221 ns | 0.1873 ns | 0.1752 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.580 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Short.From_String_Empty_AsObject: DefaultJob
