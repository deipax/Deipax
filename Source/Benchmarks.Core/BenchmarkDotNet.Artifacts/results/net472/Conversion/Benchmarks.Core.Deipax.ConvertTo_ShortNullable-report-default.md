
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 14.48 ns | 0.0754 ns | 0.0669 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.47 ns | 0.1235 ns | 0.1155 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.66 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.18 ns | 0.0875 ns | 0.0818 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.95 ns | 0.0946 ns | 0.0885 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 20.22 ns | 0.1423 ns | 0.1331 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.17 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 24.68 ns | 0.1168 ns | 0.1093 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.57 ns | 0.0950 ns | 0.0888 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 27.12 ns | 0.5270 ns | 0.4930 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.62 ns | 0.0347 ns | 0.0289 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 23.36 ns | 0.1203 ns | 0.1126 ns |           - |           - |           - |                   - |
                                             From_Char | 13.32 ns | 0.0656 ns | 0.0614 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 26.85 ns | 0.1433 ns | 0.1340 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 13.35 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 24.87 ns | 0.0881 ns | 0.0824 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.65 ns | 0.0366 ns | 0.0325 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 22.19 ns | 0.1003 ns | 0.0938 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.98 ns | 0.1156 ns | 0.1025 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.45 ns | 0.0522 ns | 0.0488 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.93 ns | 0.0727 ns | 0.0680 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 20.30 ns | 0.0965 ns | 0.0903 ns |           - |           - |           - |                   - |
                                          From_Decimal | 24.99 ns | 0.0959 ns | 0.0897 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 40.60 ns | 0.3138 ns | 0.2935 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.49 ns | 0.1230 ns | 0.1151 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 35.97 ns | 0.1920 ns | 0.1796 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.08 ns | 0.0980 ns | 0.0917 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 23.64 ns | 0.0953 ns | 0.0892 ns |           - |           - |           - |                   - |
                                           From_Double | 15.07 ns | 0.0779 ns | 0.0729 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 26.97 ns | 0.1211 ns | 0.1133 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.41 ns | 0.0932 ns | 0.0872 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 28.65 ns | 0.0811 ns | 0.0759 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.24 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 22.53 ns | 0.1123 ns | 0.1051 ns |           - |           - |           - |                   - |
                                            From_Short | 12.14 ns | 0.0277 ns | 0.0245 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 35.01 ns | 0.2243 ns | 0.2098 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.27 ns | 0.0838 ns | 0.0784 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 36.16 ns | 0.1608 ns | 0.1425 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.99 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 23.57 ns | 0.0645 ns | 0.0571 ns |           - |           - |           - |                   - |
                                              From_Int | 12.95 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 27.00 ns | 0.1095 ns | 0.0971 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.36 ns | 0.0584 ns | 0.0547 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 27.08 ns | 0.2313 ns | 0.2163 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.66 ns | 0.0504 ns | 0.0472 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 19.57 ns | 0.0960 ns | 0.0898 ns |           - |           - |           - |                   - |
                                             From_Long | 13.36 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 27.38 ns | 0.1045 ns | 0.0978 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.84 ns | 0.0756 ns | 0.0707 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 28.63 ns | 0.2064 ns | 0.1931 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.12 ns | 0.0454 ns | 0.0424 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 24.31 ns | 0.0788 ns | 0.0698 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.19 ns | 0.0606 ns | 0.0566 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 24.10 ns | 0.1012 ns | 0.0947 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.64 ns | 0.0447 ns | 0.0396 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 28.12 ns | 0.0923 ns | 0.0863 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 13.18 ns | 0.0645 ns | 0.0603 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 23.67 ns | 0.0916 ns | 0.0857 ns |           - |           - |           - |                   - |
                                            From_Float | 15.26 ns | 0.1220 ns | 0.1141 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 31.08 ns | 0.1653 ns | 0.1466 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 15.11 ns | 0.0902 ns | 0.0844 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 28.23 ns | 0.0940 ns | 0.0879 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.81 ns | 0.0426 ns | 0.0377 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 20.73 ns | 0.1508 ns | 0.1410 ns |           - |           - |           - |                   - |
                                           From_String | 66.85 ns | 0.3671 ns | 0.3254 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 76.59 ns | 0.4900 ns | 0.4583 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.57 ns | 0.0582 ns | 0.0545 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 22.18 ns | 0.0953 ns | 0.0891 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.63 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 13.02 ns | 0.0394 ns | 0.0368 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 28.86 ns | 0.1248 ns | 0.1106 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.74 ns | 0.0390 ns | 0.0346 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 26.88 ns | 0.0770 ns | 0.0720 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.67 ns | 0.0562 ns | 0.0526 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 22.45 ns | 0.1802 ns | 0.1686 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.96 ns | 0.0305 ns | 0.0285 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 26.87 ns | 0.0783 ns | 0.0695 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.98 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 28.36 ns | 0.1096 ns | 0.0971 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.67 ns | 0.0763 ns | 0.0714 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 22.26 ns | 0.0860 ns | 0.0805 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.97 ns | 0.0585 ns | 0.0518 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 27.55 ns | 0.1262 ns | 0.1181 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.24 ns | 0.0522 ns | 0.0463 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 24.88 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.89 ns | 0.1010 ns | 0.0945 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 20.50 ns | 0.1556 ns | 0.1455 ns |           - |           - |           - |                   - |
                                       From_NullObject | 21.22 ns | 0.1616 ns | 0.1433 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.23 ns | 0.0850 ns | 0.0795 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.17 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.56 ns | 0.1515 ns | 0.1417 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 25.12 ns | 0.0901 ns | 0.0842 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.64 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 23.44 ns | 0.1060 ns | 0.0940 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 14.14 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 24.32 ns | 0.0879 ns | 0.0822 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.48 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 22.32 ns | 0.0878 ns | 0.0821 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 19.12 ns | 0.0395 ns | 0.0350 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 25.90 ns | 0.1196 ns | 0.1119 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.57 ns | 0.1519 ns | 0.1347 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.67 ns | 0.1360 ns | 0.1272 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.95 ns | 0.1463 ns | 0.1369 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 20.76 ns | 0.0986 ns | 0.0923 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.15 ns | 0.0476 ns | 0.0446 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 24.96 ns | 0.1719 ns | 0.1608 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.03 ns | 0.0668 ns | 0.0625 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 24.79 ns | 0.1123 ns | 0.1051 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.56 ns | 0.0786 ns | 0.0735 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 19.51 ns | 0.0827 ns | 0.0773 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.96 ns | 0.0362 ns | 0.0321 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 49.98 ns | 0.1371 ns | 0.1215 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.28 ns | 0.0502 ns | 0.0469 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 55.43 ns | 0.2583 ns | 0.2416 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.70 ns | 0.0791 ns | 0.0701 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 23.52 ns | 0.1419 ns | 0.1327 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.45 ns | 0.0513 ns | 0.0480 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 26.05 ns | 0.2006 ns | 0.1876 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.43 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 20.55 ns | 0.0739 ns | 0.0691 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.55 ns | 0.1729 ns | 0.1533 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 25.16 ns | 0.1255 ns | 0.1174 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.54 ns | 0.2625 ns | 0.2456 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 23.98 ns | 0.0899 ns | 0.0797 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 39.11 ns | 0.2114 ns | 0.1874 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 22.32 ns | 0.0953 ns | 0.0891 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_String_Empty_AsObject: DefaultJob
