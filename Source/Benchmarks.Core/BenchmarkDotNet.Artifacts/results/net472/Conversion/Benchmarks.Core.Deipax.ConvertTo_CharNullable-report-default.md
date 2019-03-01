
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.42 ns | 0.0998 ns | 0.0933 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 13.29 ns | 0.0780 ns | 0.0730 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.26 ns | 0.0643 ns | 0.0602 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 22.37 ns | 0.1391 ns | 0.1301 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.18 ns | 0.0714 ns | 0.0668 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 27.18 ns | 0.1618 ns | 0.1514 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.62 ns | 0.0369 ns | 0.0327 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 27.91 ns | 0.1125 ns | 0.1052 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.94 ns | 0.0873 ns | 0.0817 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 22.14 ns | 0.1248 ns | 0.1167 ns |           - |           - |           - |                   - |
                                             From_Char | 11.55 ns | 0.0629 ns | 0.0588 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 36.18 ns | 0.2952 ns | 0.2617 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.06 ns | 0.0886 ns | 0.0829 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 36.26 ns | 0.2168 ns | 0.2028 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.06 ns | 0.0674 ns | 0.0630 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 20.52 ns | 0.1601 ns | 0.1337 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.83 ns | 0.0803 ns | 0.0751 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.91 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.92 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 19.51 ns | 0.1210 ns | 0.1132 ns |           - |           - |           - |                   - |
                                          From_Decimal | 12.86 ns | 0.0659 ns | 0.0616 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 13.00 ns | 0.0660 ns | 0.0618 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.32 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 20.17 ns | 0.0877 ns | 0.0733 ns |           - |           - |           - |                   - |
                                           From_Double | 13.28 ns | 0.0934 ns | 0.0874 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.87 ns | 0.0519 ns | 0.0486 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.03 ns | 0.0869 ns | 0.0813 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 22.28 ns | 0.0820 ns | 0.0767 ns |           - |           - |           - |                   - |
                                            From_Short | 13.90 ns | 0.0834 ns | 0.0780 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 27.06 ns | 0.1324 ns | 0.1238 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.46 ns | 0.1097 ns | 0.1026 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 28.61 ns | 0.1379 ns | 0.1222 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.74 ns | 0.0864 ns | 0.0766 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 22.04 ns | 0.0862 ns | 0.0807 ns |           - |           - |           - |                   - |
                                              From_Int | 12.98 ns | 0.0858 ns | 0.0802 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 27.39 ns | 0.1553 ns | 0.1453 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.36 ns | 0.0592 ns | 0.0525 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 28.73 ns | 0.1422 ns | 0.1330 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.70 ns | 0.0419 ns | 0.0371 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 22.30 ns | 0.0942 ns | 0.0881 ns |           - |           - |           - |                   - |
                                             From_Long | 13.97 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 26.97 ns | 0.1428 ns | 0.1336 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.29 ns | 0.0830 ns | 0.0777 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 27.16 ns | 0.0872 ns | 0.0728 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.20 ns | 0.0903 ns | 0.0844 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 22.30 ns | 0.1387 ns | 0.1297 ns |           - |           - |           - |                   - |
                                            From_SByte | 14.45 ns | 0.0766 ns | 0.0679 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 26.91 ns | 0.0921 ns | 0.0861 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 13.32 ns | 0.0544 ns | 0.0483 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 28.40 ns | 0.1245 ns | 0.1164 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.71 ns | 0.0621 ns | 0.0519 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 20.35 ns | 0.1191 ns | 0.1055 ns |           - |           - |           - |                   - |
                                            From_Float | 12.59 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.18 ns | 0.0441 ns | 0.0413 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.15 ns | 0.0585 ns | 0.0518 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 23.68 ns | 0.1335 ns | 0.1114 ns |           - |           - |           - |                   - |
                                           From_String | 15.53 ns | 0.1139 ns | 0.1066 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 28.71 ns | 0.2066 ns | 0.1933 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.00 ns | 0.0609 ns | 0.0570 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 23.60 ns | 0.1095 ns | 0.1024 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.13 ns | 0.0849 ns | 0.0794 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.19 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 26.67 ns | 0.1785 ns | 0.1582 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.70 ns | 0.0491 ns | 0.0410 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 26.73 ns | 0.1161 ns | 0.1086 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.65 ns | 0.0591 ns | 0.0524 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 21.74 ns | 0.0998 ns | 0.0885 ns |           - |           - |           - |                   - |
                                             From_UInt | 13.87 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 28.50 ns | 0.1012 ns | 0.0897 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 14.14 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 28.38 ns | 0.1442 ns | 0.1204 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.71 ns | 0.0872 ns | 0.0815 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 25.03 ns | 0.0913 ns | 0.0854 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.92 ns | 0.0660 ns | 0.0618 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 24.99 ns | 0.1178 ns | 0.1045 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.40 ns | 0.1310 ns | 0.1226 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 26.70 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.14 ns | 0.0725 ns | 0.0678 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 20.82 ns | 0.1400 ns | 0.1309 ns |           - |           - |           - |                   - |
                                       From_NullObject | 22.29 ns | 0.0849 ns | 0.0794 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.83 ns | 0.0726 ns | 0.0679 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.35 ns | 0.1462 ns | 0.1296 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 23.07 ns | 0.1287 ns | 0.1203 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 23.46 ns | 0.1053 ns | 0.0985 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.79 ns | 0.1023 ns | 0.0957 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 23.53 ns | 0.0638 ns | 0.0566 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 14.16 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 23.73 ns | 0.0830 ns | 0.0776 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.52 ns | 0.0747 ns | 0.0698 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 22.43 ns | 0.1521 ns | 0.1422 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.27 ns | 0.0920 ns | 0.0860 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 25.99 ns | 0.1428 ns | 0.1336 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.55 ns | 0.1624 ns | 0.1519 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.94 ns | 0.1779 ns | 0.1664 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.86 ns | 0.1084 ns | 0.1014 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 20.68 ns | 0.0954 ns | 0.0892 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 16.54 ns | 0.1101 ns | 0.1030 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 21.71 ns | 0.1115 ns | 0.1043 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.33 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.71 ns | 0.1284 ns | 0.1201 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.24 ns | 0.0701 ns | 0.0622 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 22.10 ns | 0.0947 ns | 0.0886 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.04 ns | 0.0732 ns | 0.0684 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 53.94 ns | 0.2938 ns | 0.2748 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.33 ns | 0.0861 ns | 0.0805 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 49.00 ns | 0.2921 ns | 0.2732 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.68 ns | 0.0892 ns | 0.0834 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 20.28 ns | 0.1301 ns | 0.1217 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 14.19 ns | 0.0860 ns | 0.0805 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 25.25 ns | 0.1213 ns | 0.1135 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 14.06 ns | 0.0800 ns | 0.0748 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 22.35 ns | 0.0990 ns | 0.0926 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 48.44 ns | 0.2363 ns | 0.2210 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 25.15 ns | 0.1765 ns | 0.1651 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.31 ns | 0.1715 ns | 0.1604 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 25.20 ns | 0.1231 ns | 0.1152 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 41.92 ns | 0.1995 ns | 0.1866 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 22.12 ns | 0.0786 ns | 0.0697 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_String_Empty_AsObject: DefaultJob
