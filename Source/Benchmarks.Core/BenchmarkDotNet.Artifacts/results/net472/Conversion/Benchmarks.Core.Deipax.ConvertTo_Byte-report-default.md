
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.331 ns | 0.1257 ns | 0.1176 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.934 ns | 0.0726 ns | 0.0679 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.508 ns | 0.1405 ns | 0.1314 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.996 ns | 0.0794 ns | 0.0704 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.894 ns | 0.0444 ns | 0.0415 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.109 ns | 0.0457 ns | 0.0405 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.567 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 12.895 ns | 0.0783 ns | 0.0733 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  9.537 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.744 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.524 ns | 0.0581 ns | 0.0543 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 15.476 ns | 0.0551 ns | 0.0515 ns |           - |           - |           - |                   - |
                                             From_Char | 11.225 ns | 0.0389 ns | 0.0363 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.584 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.505 ns | 0.1934 ns | 0.1809 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 19.926 ns | 0.0814 ns | 0.0762 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.934 ns | 0.0611 ns | 0.0572 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.768 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.457 ns | 0.0400 ns | 0.0312 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.219 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.316 ns | 0.0585 ns | 0.0547 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.607 ns | 0.0804 ns | 0.0752 ns |           - |           - |           - |                   - |
                                          From_Decimal | 29.884 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 26.867 ns | 0.1130 ns | 0.1057 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.216 ns | 0.1054 ns | 0.0986 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 26.268 ns | 0.1432 ns | 0.1269 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.414 ns | 0.0320 ns | 0.0299 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.615 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                                           From_Double | 14.639 ns | 0.0626 ns | 0.0523 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.473 ns | 0.0786 ns | 0.0735 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.844 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 20.117 ns | 0.0808 ns | 0.0716 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.670 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 14.279 ns | 0.0504 ns | 0.0472 ns |           - |           - |           - |                   - |
                                            From_Short | 11.615 ns | 0.0622 ns | 0.0551 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 18.847 ns | 0.1027 ns | 0.0960 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.267 ns | 0.0694 ns | 0.0650 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 19.421 ns | 0.0920 ns | 0.0860 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.903 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.347 ns | 0.0362 ns | 0.0339 ns |           - |           - |           - |                   - |
                                              From_Int | 11.129 ns | 0.0523 ns | 0.0489 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 19.655 ns | 0.1581 ns | 0.1479 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.382 ns | 0.1134 ns | 0.1061 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.981 ns | 0.1113 ns | 0.1041 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.980 ns | 0.0446 ns | 0.0417 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 13.475 ns | 0.0596 ns | 0.0557 ns |           - |           - |           - |                   - |
                                             From_Long | 11.316 ns | 0.0434 ns | 0.0385 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.517 ns | 0.0696 ns | 0.0651 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.663 ns | 0.0856 ns | 0.0800 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 18.543 ns | 0.0931 ns | 0.0871 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.397 ns | 0.0630 ns | 0.0559 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.991 ns | 0.0598 ns | 0.0559 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.272 ns | 0.0415 ns | 0.0388 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 19.189 ns | 0.1083 ns | 0.0960 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.248 ns | 0.1082 ns | 0.1012 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 18.493 ns | 0.1484 ns | 0.1388 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.962 ns | 0.0426 ns | 0.0355 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.055 ns | 0.0521 ns | 0.0462 ns |           - |           - |           - |                   - |
                                            From_Float | 14.234 ns | 0.0874 ns | 0.0818 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 20.838 ns | 0.1287 ns | 0.1204 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.616 ns | 0.1264 ns | 0.1183 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 21.332 ns | 0.1721 ns | 0.1609 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.075 ns | 0.0919 ns | 0.0859 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 14.287 ns | 0.0767 ns | 0.0718 ns |           - |           - |           - |                   - |
                                           From_String | 65.467 ns | 0.4072 ns | 0.3809 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 68.262 ns | 0.2845 ns | 0.2661 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.543 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 14.847 ns | 0.0994 ns | 0.0929 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.718 ns | 0.1008 ns | 0.0943 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.075 ns | 0.0415 ns | 0.0368 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 18.330 ns | 0.1732 ns | 0.1621 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.290 ns | 0.1632 ns | 0.1527 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.571 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.897 ns | 0.0567 ns | 0.0530 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.233 ns | 0.0458 ns | 0.0428 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.297 ns | 0.0574 ns | 0.0537 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 18.728 ns | 0.1475 ns | 0.1379 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.531 ns | 0.1452 ns | 0.1358 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 18.863 ns | 0.1088 ns | 0.1018 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.101 ns | 0.0411 ns | 0.0385 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.292 ns | 0.0671 ns | 0.0627 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.383 ns | 0.0725 ns | 0.0678 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 18.553 ns | 0.1725 ns | 0.1614 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.678 ns | 0.0883 ns | 0.0826 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.521 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.358 ns | 0.0483 ns | 0.0404 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.565 ns | 0.0350 ns | 0.0310 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.973 ns | 0.0487 ns | 0.0456 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.767 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 13.607 ns | 0.0471 ns | 0.0417 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.666 ns | 0.0891 ns | 0.0833 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.580 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.465 ns | 0.0400 ns | 0.0374 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.524 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.047 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.895 ns | 0.0974 ns | 0.0911 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.986 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.857 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.771 ns | 0.0648 ns | 0.0574 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 15.275 ns | 0.0990 ns | 0.0926 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.626 ns | 0.0574 ns | 0.0509 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.638 ns | 0.0729 ns | 0.0609 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.467 ns | 0.0966 ns | 0.0903 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.319 ns | 0.0786 ns | 0.0736 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.807 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.715 ns | 0.0582 ns | 0.0545 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.878 ns | 0.0520 ns | 0.0461 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.194 ns | 0.0320 ns | 0.0250 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.974 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.975 ns | 0.0411 ns | 0.0385 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.280 ns | 0.0488 ns | 0.0433 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.992 ns | 0.2027 ns | 0.1797 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.006 ns | 0.1057 ns | 0.0937 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 42.629 ns | 0.1771 ns | 0.1656 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.936 ns | 0.0971 ns | 0.0908 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 14.252 ns | 0.0563 ns | 0.0527 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.113 ns | 0.0697 ns | 0.0652 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.308 ns | 0.0955 ns | 0.0893 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.489 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.074 ns | 0.0463 ns | 0.0433 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 38.398 ns | 0.1917 ns | 0.1793 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.384 ns | 0.1186 ns | 0.1109 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.311 ns | 0.1931 ns | 0.1711 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.256 ns | 0.0870 ns | 0.0814 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.934 ns | 0.1767 ns | 0.1653 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 14.325 ns | 0.0414 ns | 0.0388 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Byte.From_String_Empty_AsObject: DefaultJob
