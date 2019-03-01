
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev |   Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|---------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.28 ns | 0.1470 ns | 0.1375 ns | 11.30 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 18.62 ns | 0.1097 ns | 0.1026 ns | 18.64 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.81 ns | 0.0878 ns | 0.0822 ns | 11.80 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.01 ns | 0.1482 ns | 0.1386 ns | 18.01 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.49 ns | 0.0593 ns | 0.0554 ns | 11.48 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 14.89 ns | 0.0397 ns | 0.0352 ns | 14.88 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.86 ns | 0.0412 ns | 0.0385 ns | 10.87 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.26 ns | 0.1009 ns | 0.0944 ns | 16.26 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.92 ns | 0.0966 ns | 0.0904 ns | 11.91 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.20 ns | 0.0824 ns | 0.0771 ns | 16.18 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.87 ns | 0.0534 ns | 0.0446 ns | 10.87 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.26 ns | 0.0415 ns | 0.0388 ns | 14.26 ns |           - |           - |           - |                   - |
                                             From_Char | 10.57 ns | 0.0623 ns | 0.0552 ns | 10.55 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.77 ns | 0.3377 ns | 0.2820 ns | 18.72 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.75 ns | 0.1143 ns | 0.1013 ns | 11.77 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 18.28 ns | 0.1562 ns | 0.1305 ns | 18.25 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.54 ns | 0.1271 ns | 0.1189 ns | 11.53 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.82 ns | 0.2654 ns | 0.2482 ns | 14.73 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.68 ns | 0.2248 ns | 0.2102 ns | 12.73 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.63 ns | 0.0539 ns | 0.0504 ns | 12.63 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.89 ns | 0.1900 ns | 0.1684 ns | 12.90 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.58 ns | 0.1464 ns | 0.1370 ns | 12.58 ns |           - |           - |           - |                   - |
                                          From_Decimal | 26.29 ns | 0.3696 ns | 0.3458 ns | 26.20 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 27.74 ns | 0.0895 ns | 0.0794 ns | 27.74 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 22.65 ns | 0.1116 ns | 0.1044 ns | 22.62 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 25.56 ns | 0.1097 ns | 0.1026 ns | 25.57 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.36 ns | 0.2842 ns | 0.3159 ns | 13.38 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.37 ns | 0.1770 ns | 0.1656 ns | 12.30 ns |           - |           - |           - |                   - |
                                           From_Double | 14.51 ns | 0.2639 ns | 0.2203 ns | 14.48 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 21.76 ns | 0.2052 ns | 0.1919 ns | 21.76 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 17.13 ns | 0.1002 ns | 0.0837 ns | 17.14 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 21.40 ns | 0.1408 ns | 0.1317 ns | 21.36 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.71 ns | 0.0803 ns | 0.0751 ns | 12.74 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 14.55 ns | 0.0823 ns | 0.0730 ns | 14.56 ns |           - |           - |           - |                   - |
                                            From_Short | 11.08 ns | 0.0841 ns | 0.0787 ns | 11.07 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 18.52 ns | 0.0726 ns | 0.0643 ns | 18.53 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.46 ns | 0.1811 ns | 0.1694 ns | 11.52 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 18.82 ns | 0.2733 ns | 0.2556 ns | 18.80 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.21 ns | 0.0372 ns | 0.0348 ns | 11.20 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.46 ns | 0.0645 ns | 0.0603 ns | 14.46 ns |           - |           - |           - |                   - |
                                              From_Int | 11.49 ns | 0.0664 ns | 0.0621 ns | 11.49 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 18.76 ns | 0.1326 ns | 0.1241 ns | 18.82 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.42 ns | 0.1470 ns | 0.1375 ns | 11.43 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 19.68 ns | 0.2765 ns | 0.2587 ns | 19.59 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.17 ns | 0.0338 ns | 0.0300 ns | 11.17 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 14.77 ns | 0.2907 ns | 0.2427 ns | 14.74 ns |           - |           - |           - |                   - |
                                             From_Long | 10.30 ns | 0.0517 ns | 0.0432 ns | 10.30 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.37 ns | 0.3033 ns | 0.2837 ns | 15.37 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.02 ns | 0.1459 ns | 0.1365 ns | 13.04 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 13.63 ns | 0.1555 ns | 0.1379 ns | 13.64 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.40 ns | 0.1991 ns | 0.1863 ns | 12.33 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.77 ns | 0.1581 ns | 0.1402 ns | 12.73 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.47 ns | 0.1054 ns | 0.0986 ns | 11.50 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 19.08 ns | 0.2166 ns | 0.1920 ns | 19.08 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.02 ns | 0.2224 ns | 0.2080 ns | 11.99 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.35 ns | 0.1854 ns | 0.1734 ns | 17.39 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.81 ns | 0.2713 ns | 0.2665 ns | 12.85 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.74 ns | 0.2816 ns | 0.2892 ns | 14.62 ns |           - |           - |           - |                   - |
                                            From_Float | 18.59 ns | 0.3811 ns | 0.5088 ns | 18.41 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 25.18 ns | 0.5006 ns | 0.9763 ns | 25.31 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 16.21 ns | 0.2626 ns | 0.2456 ns | 16.23 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 22.11 ns | 0.4357 ns | 0.9094 ns | 21.76 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 14.44 ns | 1.0481 ns | 3.0903 ns | 12.54 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.86 ns | 0.1238 ns | 0.1098 ns | 12.84 ns |           - |           - |           - |                   - |
                                           From_String | 69.65 ns | 1.3706 ns | 1.4665 ns | 69.20 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 75.44 ns | 1.3903 ns | 1.3005 ns | 75.49 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.99 ns | 0.1206 ns | 0.1069 ns | 13.97 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.03 ns | 0.1115 ns | 0.1043 ns | 13.03 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.17 ns | 0.1465 ns | 0.1370 ns | 14.19 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |           - |           - |           - |                   - |
                                           From_UShort | 11.38 ns | 0.1513 ns | 0.1416 ns | 11.37 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 20.21 ns | 0.2522 ns | 0.2359 ns | 20.15 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.48 ns | 0.1137 ns | 0.1008 ns | 12.48 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 19.48 ns | 0.3803 ns | 0.3735 ns | 19.40 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.58 ns | 0.2757 ns | 0.4682 ns | 12.42 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.32 ns | 0.2235 ns | 0.1981 ns | 14.30 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.91 ns | 0.1161 ns | 0.1086 ns | 11.90 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.87 ns | 0.4365 ns | 0.3869 ns | 17.72 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.38 ns | 0.1873 ns | 0.1752 ns | 11.31 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 19.00 ns | 0.2032 ns | 0.1802 ns | 19.05 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.63 ns | 0.2289 ns | 0.2141 ns | 11.54 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.35 ns | 0.2590 ns | 0.2423 ns | 14.28 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.30 ns | 0.1510 ns | 0.1412 ns | 12.31 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.69 ns | 0.0373 ns | 0.0331 ns | 17.70 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.48 ns | 0.0324 ns | 0.0253 ns | 14.49 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 20.51 ns | 0.2686 ns | 0.2513 ns | 20.53 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.05 ns | 0.2858 ns | 0.2674 ns | 13.01 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 15.11 ns | 0.2419 ns | 0.2263 ns | 15.12 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.47 ns | 0.1815 ns | 0.1697 ns | 12.44 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.24 ns | 0.1301 ns | 0.1217 ns | 10.30 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.76 ns | 0.1231 ns | 0.1028 ns | 12.73 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 17.20 ns | 0.1974 ns | 0.1847 ns | 17.16 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.40 ns | 0.2072 ns | 0.1837 ns | 17.40 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.15 ns | 0.1774 ns | 0.1573 ns | 13.20 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.85 ns | 0.2593 ns | 0.2426 ns | 14.87 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.78 ns | 0.2325 ns | 0.3104 ns | 11.68 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 16.34 ns | 0.1078 ns | 0.1009 ns | 16.36 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.75 ns | 0.1633 ns | 0.1527 ns | 13.73 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 15.52 ns | 0.3095 ns | 0.4819 ns | 15.35 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.40 ns | 0.2815 ns | 0.2633 ns | 18.32 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.09 ns | 0.1962 ns | 0.1836 ns | 16.06 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 19.68 ns | 0.4746 ns | 1.0217 ns | 19.34 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 18.47 ns | 0.3824 ns | 0.4836 ns | 18.39 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.66 ns | 0.0755 ns | 0.0706 ns | 11.69 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 15.81 ns | 0.0101 ns | 0.0090 ns | 15.81 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.42 ns | 0.0098 ns | 0.0087 ns | 11.42 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 16.00 ns | 0.0155 ns | 0.0145 ns | 16.00 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.42 ns | 0.0065 ns | 0.0054 ns | 11.42 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.76 ns | 0.0394 ns | 0.0329 ns | 15.76 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.50 ns | 0.0749 ns | 0.0701 ns | 11.49 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.72 ns | 0.0964 ns | 0.0855 ns | 13.68 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.31 ns | 0.0552 ns | 0.0461 ns | 11.29 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 48.47 ns | 0.2809 ns | 0.2627 ns | 48.45 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.06 ns | 0.1248 ns | 0.1107 ns | 12.07 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 44.86 ns | 0.0424 ns | 0.0396 ns | 44.85 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.49 ns | 0.0226 ns | 0.0200 ns | 11.48 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.66 ns | 0.0072 ns | 0.0063 ns | 12.65 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.37 ns | 0.0115 ns | 0.0107 ns | 13.37 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.96 ns | 0.0322 ns | 0.0301 ns | 16.96 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.63 ns | 0.0078 ns | 0.0073 ns | 11.63 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.10 ns | 0.0061 ns | 0.0051 ns | 13.10 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.98 ns | 0.0310 ns | 0.0274 ns | 37.98 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 16.72 ns | 0.0485 ns | 0.0430 ns | 16.71 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 44.26 ns | 0.0346 ns | 0.0324 ns | 44.25 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 16.61 ns | 0.0530 ns | 0.0443 ns | 16.60 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.93 ns | 0.0301 ns | 0.0281 ns | 38.92 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.04 ns | 0.0055 ns | 0.0046 ns | 13.04 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Long.From_String_Empty_AsObject: DefaultJob
