
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.215 ns | 0.2622 ns | 0.3500 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.777 ns | 0.1081 ns | 0.1011 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.033 ns | 0.0970 ns | 0.0908 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 19.109 ns | 0.1426 ns | 0.1333 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.050 ns | 0.0779 ns | 0.0728 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 14.276 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                             From_Byte | 11.008 ns | 0.0404 ns | 0.0377 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 19.335 ns | 0.0717 ns | 0.0636 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.462 ns | 0.0873 ns | 0.0816 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 18.622 ns | 0.1684 ns | 0.1575 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.519 ns | 0.0782 ns | 0.0732 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.779 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
                                             From_Char | 10.693 ns | 0.0694 ns | 0.0580 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.001 ns | 0.0486 ns | 0.0454 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.006 ns | 0.0618 ns | 0.0578 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.815 ns | 0.0759 ns | 0.0634 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.733 ns | 0.1727 ns | 0.1615 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.246 ns | 0.1490 ns | 0.1244 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.250 ns | 0.1082 ns | 0.0959 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 15.324 ns | 0.1494 ns | 0.1398 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.858 ns | 0.0470 ns | 0.0417 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.418 ns | 0.2319 ns | 0.2056 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 26.258 ns | 0.2002 ns | 0.1872 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 22.894 ns | 0.1318 ns | 0.1169 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.461 ns | 0.2353 ns | 0.2086 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.500 ns | 0.1023 ns | 0.0957 ns |           - |           - |           - |                   - |
                                           From_Double | 11.561 ns | 0.0715 ns | 0.0669 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 17.627 ns | 0.0753 ns | 0.0705 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.801 ns | 0.1042 ns | 0.0974 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 20.576 ns | 0.1583 ns | 0.1481 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.543 ns | 0.1515 ns | 0.1418 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.408 ns | 0.0693 ns | 0.0614 ns |           - |           - |           - |                   - |
                                            From_Short | 13.507 ns | 0.1495 ns | 0.1398 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 19.977 ns | 0.1264 ns | 0.1121 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.419 ns | 0.1255 ns | 0.1174 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.845 ns | 0.1400 ns | 0.1310 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.671 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.602 ns | 0.0925 ns | 0.0865 ns |           - |           - |           - |                   - |
                                              From_Int | 12.795 ns | 0.0874 ns | 0.0818 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 19.592 ns | 0.1117 ns | 0.1045 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.916 ns | 0.2657 ns | 0.3637 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 19.045 ns | 0.1418 ns | 0.1326 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.004 ns | 0.0626 ns | 0.0585 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 13.732 ns | 0.0388 ns | 0.0363 ns |           - |           - |           - |                   - |
                                             From_Long | 11.041 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 19.238 ns | 0.0817 ns | 0.0765 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.009 ns | 0.0572 ns | 0.0535 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.756 ns | 0.0653 ns | 0.0611 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.701 ns | 0.0585 ns | 0.0547 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.736 ns | 0.1084 ns | 0.1014 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.069 ns | 0.0288 ns | 0.0256 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.719 ns | 0.1135 ns | 0.1062 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.562 ns | 0.0641 ns | 0.0600 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.736 ns | 0.0836 ns | 0.0782 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.068 ns | 0.0703 ns | 0.0658 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 13.738 ns | 0.0440 ns | 0.0412 ns |           - |           - |           - |                   - |
                                            From_Float |  9.759 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 12.909 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |  9.635 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 14.309 ns | 0.0551 ns | 0.0515 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.632 ns | 0.0730 ns | 0.0683 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.472 ns | 0.0738 ns | 0.0690 ns |           - |           - |           - |                   - |
                                           From_String | 71.374 ns | 0.3519 ns | 0.3292 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 74.340 ns | 0.3329 ns | 0.3113 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.749 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 14.292 ns | 0.0715 ns | 0.0669 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.306 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.484 ns | 0.0501 ns | 0.0469 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.783 ns | 0.0645 ns | 0.0603 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.615 ns | 0.1013 ns | 0.0898 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.251 ns | 0.1099 ns | 0.0974 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.976 ns | 0.0683 ns | 0.0606 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.265 ns | 0.0249 ns | 0.0233 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.865 ns | 0.0661 ns | 0.0618 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 16.860 ns | 0.1288 ns | 0.1205 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.767 ns | 0.0570 ns | 0.0533 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 18.599 ns | 0.1007 ns | 0.0942 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.823 ns | 0.0972 ns | 0.0909 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.306 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.238 ns | 0.0502 ns | 0.0470 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 19.430 ns | 0.0892 ns | 0.0834 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.888 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 18.861 ns | 0.0780 ns | 0.0730 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.529 ns | 0.0330 ns | 0.0309 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.049 ns | 0.0756 ns | 0.0707 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.283 ns | 0.0506 ns | 0.0422 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.017 ns | 0.0871 ns | 0.0815 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 15.103 ns | 0.0762 ns | 0.0712 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.824 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.963 ns | 0.0947 ns | 0.0886 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.065 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.553 ns | 0.0438 ns | 0.0410 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.010 ns | 0.0458 ns | 0.0428 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 17.257 ns | 0.1414 ns | 0.1323 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.645 ns | 0.0608 ns | 0.0569 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.992 ns | 0.0520 ns | 0.0461 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.656 ns | 0.0991 ns | 0.0927 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 15.714 ns | 0.0763 ns | 0.0714 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.872 ns | 0.0755 ns | 0.0669 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.625 ns | 0.1239 ns | 0.1159 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.021 ns | 0.0459 ns | 0.0429 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.023 ns | 0.0541 ns | 0.0479 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.822 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.741 ns | 0.0348 ns | 0.0272 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.828 ns | 0.0424 ns | 0.0376 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.177 ns | 0.0964 ns | 0.0901 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.865 ns | 0.0869 ns | 0.0813 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.671 ns | 0.1002 ns | 0.0937 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.599 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 39.579 ns | 0.1277 ns | 0.1195 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.329 ns | 0.1771 ns | 0.1657 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 39.785 ns | 0.1747 ns | 0.1549 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.919 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.123 ns | 0.0670 ns | 0.0594 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.264 ns | 0.0936 ns | 0.0876 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.775 ns | 0.0888 ns | 0.0831 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.043 ns | 0.0670 ns | 0.0627 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.620 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 49.633 ns | 0.1523 ns | 0.1424 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 14.141 ns | 0.0659 ns | 0.0584 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.032 ns | 0.1565 ns | 0.1387 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 16.125 ns | 0.1511 ns | 0.1413 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.100 ns | 0.1753 ns | 0.1554 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.797 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Float.From_Char_AsObject: DefaultJob
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_String_Empty_AsObject: DefaultJob
