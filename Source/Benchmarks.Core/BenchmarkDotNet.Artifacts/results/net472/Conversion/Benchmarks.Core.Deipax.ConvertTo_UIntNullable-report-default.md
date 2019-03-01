
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.38 ns | 0.0518 ns | 0.0459 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.44 ns | 0.1265 ns | 0.1184 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.65 ns | 0.0645 ns | 0.0603 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.92 ns | 0.0854 ns | 0.0799 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.71 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 22.35 ns | 0.1026 ns | 0.0909 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.19 ns | 0.0378 ns | 0.0354 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 24.74 ns | 0.0637 ns | 0.0565 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.65 ns | 0.0616 ns | 0.0577 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 27.93 ns | 0.1084 ns | 0.0961 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.58 ns | 0.0396 ns | 0.0351 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 23.71 ns | 0.0884 ns | 0.0827 ns |           - |           - |           - |                   - |
                                             From_Char | 12.84 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 26.14 ns | 0.1034 ns | 0.0967 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.65 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 24.68 ns | 0.0780 ns | 0.0730 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.66 ns | 0.0654 ns | 0.0612 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 23.67 ns | 0.1114 ns | 0.1042 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.85 ns | 0.0413 ns | 0.0345 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.41 ns | 0.0344 ns | 0.0288 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.85 ns | 0.0734 ns | 0.0687 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 23.65 ns | 0.1030 ns | 0.0963 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.03 ns | 0.1404 ns | 0.1313 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 33.91 ns | 0.1706 ns | 0.1596 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.50 ns | 0.1013 ns | 0.0948 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 33.68 ns | 0.2180 ns | 0.1932 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.50 ns | 0.0781 ns | 0.0731 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 20.97 ns | 0.1230 ns | 0.1151 ns |           - |           - |           - |                   - |
                                           From_Double | 14.37 ns | 0.0918 ns | 0.0858 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 29.42 ns | 0.1531 ns | 0.1433 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.00 ns | 0.1051 ns | 0.0931 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 29.35 ns | 0.1097 ns | 0.1026 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 15.84 ns | 0.0766 ns | 0.0716 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 21.02 ns | 0.1407 ns | 0.1316 ns |           - |           - |           - |                   - |
                                            From_Short | 12.89 ns | 0.0466 ns | 0.0389 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 27.20 ns | 0.1481 ns | 0.1385 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.61 ns | 0.0475 ns | 0.0445 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 27.55 ns | 0.0914 ns | 0.0855 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.69 ns | 0.0521 ns | 0.0462 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 22.51 ns | 0.0822 ns | 0.0728 ns |           - |           - |           - |                   - |
                                              From_Int | 14.06 ns | 0.0673 ns | 0.0629 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 25.40 ns | 0.1365 ns | 0.1277 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.67 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 28.29 ns | 0.1648 ns | 0.1542 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.62 ns | 0.0497 ns | 0.0415 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 20.79 ns | 0.1111 ns | 0.1039 ns |           - |           - |           - |                   - |
                                             From_Long | 12.97 ns | 0.0327 ns | 0.0255 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 25.30 ns | 0.1076 ns | 0.0954 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.22 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 29.01 ns | 0.0969 ns | 0.0859 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.42 ns | 0.0777 ns | 0.0727 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 21.03 ns | 0.1199 ns | 0.1121 ns |           - |           - |           - |                   - |
                                            From_SByte | 13.84 ns | 0.0675 ns | 0.0631 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 27.08 ns | 0.1287 ns | 0.1204 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 14.11 ns | 0.0255 ns | 0.0238 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 25.37 ns | 0.0611 ns | 0.0541 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.60 ns | 0.0368 ns | 0.0307 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 22.29 ns | 0.1115 ns | 0.1043 ns |           - |           - |           - |                   - |
                                            From_Float | 14.43 ns | 0.1223 ns | 0.1144 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 26.44 ns | 0.1587 ns | 0.1407 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 14.42 ns | 0.1129 ns | 0.1056 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 28.49 ns | 0.1240 ns | 0.1160 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.81 ns | 0.0444 ns | 0.0415 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 20.87 ns | 0.1230 ns | 0.1150 ns |           - |           - |           - |                   - |
                                           From_String | 65.28 ns | 0.3892 ns | 0.3450 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 74.21 ns | 0.7874 ns | 0.7365 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.26 ns | 0.0861 ns | 0.0805 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 21.89 ns | 0.0601 ns | 0.0502 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.52 ns | 0.0608 ns | 0.0568 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.16 ns | 0.0299 ns | 0.0265 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 28.08 ns | 0.1387 ns | 0.1298 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.65 ns | 0.0753 ns | 0.0704 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 28.14 ns | 0.0981 ns | 0.0918 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 13.30 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 22.41 ns | 0.0923 ns | 0.0818 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.49 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 34.64 ns | 0.1636 ns | 0.1450 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.06 ns | 0.0516 ns | 0.0457 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 34.56 ns | 0.2335 ns | 0.2070 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.60 ns | 0.0782 ns | 0.0731 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 22.40 ns | 0.0918 ns | 0.0859 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.95 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 28.44 ns | 0.1538 ns | 0.1438 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.57 ns | 0.0764 ns | 0.0714 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 25.61 ns | 0.1185 ns | 0.1109 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.15 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 20.85 ns | 0.0819 ns | 0.0766 ns |           - |           - |           - |                   - |
                                       From_NullObject | 21.31 ns | 0.0633 ns | 0.0561 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.20 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.19 ns | 0.0644 ns | 0.0602 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 24.51 ns | 0.1443 ns | 0.1279 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 23.35 ns | 0.1455 ns | 0.1361 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.95 ns | 0.1190 ns | 0.1113 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 24.29 ns | 0.0950 ns | 0.0842 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.53 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 23.55 ns | 0.1165 ns | 0.1090 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.49 ns | 0.0473 ns | 0.0419 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 20.00 ns | 0.1077 ns | 0.1007 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.97 ns | 0.1251 ns | 0.1170 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 27.41 ns | 0.1032 ns | 0.0965 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.40 ns | 0.0957 ns | 0.0895 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.65 ns | 0.1456 ns | 0.1216 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.83 ns | 0.1017 ns | 0.0902 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 21.21 ns | 0.1119 ns | 0.0992 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.83 ns | 0.0682 ns | 0.0638 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 23.69 ns | 0.0828 ns | 0.0775 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.18 ns | 0.0546 ns | 0.0484 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.81 ns | 0.1364 ns | 0.1276 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.37 ns | 0.0596 ns | 0.0557 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 23.69 ns | 0.0978 ns | 0.0915 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.57 ns | 0.0484 ns | 0.0453 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 49.27 ns | 0.1796 ns | 0.1680 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.20 ns | 0.0364 ns | 0.0340 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 52.99 ns | 0.1188 ns | 0.1112 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.64 ns | 0.0865 ns | 0.0809 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 21.65 ns | 0.1295 ns | 0.1212 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.48 ns | 0.0474 ns | 0.0444 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 25.09 ns | 0.1218 ns | 0.1139 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.94 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 22.29 ns | 0.0991 ns | 0.0927 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 52.19 ns | 0.3343 ns | 0.3127 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 24.18 ns | 0.1110 ns | 0.1038 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.38 ns | 0.1795 ns | 0.1679 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 25.15 ns | 0.0975 ns | 0.0912 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 42.61 ns | 0.3760 ns | 0.3517 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 23.58 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_String_Empty_AsObject: DefaultJob
