
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.57 ns | 0.1170 ns | 0.1095 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 31.83 ns | 0.2118 ns | 0.1981 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.19 ns | 0.0444 ns | 0.0416 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 35.70 ns | 0.2151 ns | 0.2012 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.61 ns | 0.1200 ns | 0.1064 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 19.95 ns | 0.1034 ns | 0.0916 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.23 ns | 0.0607 ns | 0.0538 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 26.12 ns | 0.0884 ns | 0.0784 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.62 ns | 0.0973 ns | 0.0911 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 26.38 ns | 0.1376 ns | 0.1287 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.63 ns | 0.0791 ns | 0.0740 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 19.67 ns | 0.0896 ns | 0.0838 ns |           - |           - |           - |                   - |
                                             From_Char | 14.92 ns | 0.0606 ns | 0.0567 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.14 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.19 ns | 0.0754 ns | 0.0706 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 23.25 ns | 0.0994 ns | 0.0930 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.63 ns | 0.0410 ns | 0.0342 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.88 ns | 0.0962 ns | 0.0900 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.81 ns | 0.0437 ns | 0.0387 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 21.34 ns | 0.1063 ns | 0.0995 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.26 ns | 0.1088 ns | 0.1017 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 29.19 ns | 0.1146 ns | 0.1072 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.77 ns | 0.1388 ns | 0.1299 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 32.38 ns | 0.2824 ns | 0.2642 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.26 ns | 0.0720 ns | 0.0638 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 23.33 ns | 0.1050 ns | 0.0983 ns |           - |           - |           - |                   - |
                                           From_Double | 13.23 ns | 0.0483 ns | 0.0452 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 26.01 ns | 0.0902 ns | 0.0844 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.76 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 25.61 ns | 0.1119 ns | 0.0992 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.35 ns | 0.1096 ns | 0.0915 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 23.39 ns | 0.1459 ns | 0.1365 ns |           - |           - |           - |                   - |
                                            From_Short | 12.36 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 25.86 ns | 0.1607 ns | 0.1503 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.63 ns | 0.0449 ns | 0.0398 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 25.67 ns | 0.0893 ns | 0.0835 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.70 ns | 0.0722 ns | 0.0640 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 20.42 ns | 0.0799 ns | 0.0747 ns |           - |           - |           - |                   - |
                                              From_Int | 12.16 ns | 0.0551 ns | 0.0515 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 25.71 ns | 0.0645 ns | 0.0603 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.28 ns | 0.0453 ns | 0.0402 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 25.88 ns | 0.1177 ns | 0.1043 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.67 ns | 0.0640 ns | 0.0599 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 23.21 ns | 0.1040 ns | 0.0973 ns |           - |           - |           - |                   - |
                                             From_Long | 12.87 ns | 0.0735 ns | 0.0652 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 25.89 ns | 0.0946 ns | 0.0885 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.43 ns | 0.1085 ns | 0.1015 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 24.26 ns | 0.0902 ns | 0.0843 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 15.05 ns | 0.0927 ns | 0.0867 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 23.16 ns | 0.1185 ns | 0.1109 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.44 ns | 0.0801 ns | 0.0749 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 25.86 ns | 0.1494 ns | 0.1397 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.68 ns | 0.0549 ns | 0.0514 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 27.81 ns | 0.1061 ns | 0.0992 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.59 ns | 0.0287 ns | 0.0240 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 22.27 ns | 0.1287 ns | 0.1204 ns |           - |           - |           - |                   - |
                                            From_Float | 13.20 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 26.12 ns | 0.1391 ns | 0.1301 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.27 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 24.38 ns | 0.1585 ns | 0.1483 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.84 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 19.90 ns | 0.0899 ns | 0.0797 ns |           - |           - |           - |                   - |
                                           From_String | 27.99 ns | 0.0768 ns | 0.0681 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 35.83 ns | 0.3088 ns | 0.2738 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.03 ns | 0.0612 ns | 0.0573 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 22.21 ns | 0.1212 ns | 0.1074 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.30 ns | 0.0472 ns | 0.0441 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.33 ns | 0.0517 ns | 0.0483 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 25.83 ns | 0.1341 ns | 0.1189 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.67 ns | 0.0504 ns | 0.0472 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 24.20 ns | 0.0417 ns | 0.0370 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.91 ns | 0.0643 ns | 0.0602 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 23.39 ns | 0.1088 ns | 0.1017 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.15 ns | 0.0413 ns | 0.0387 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 25.96 ns | 0.1206 ns | 0.1129 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.68 ns | 0.0578 ns | 0.0541 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 24.12 ns | 0.0821 ns | 0.0728 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.62 ns | 0.0564 ns | 0.0500 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 22.25 ns | 0.1209 ns | 0.1131 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.16 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 26.78 ns | 0.1663 ns | 0.1474 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.53 ns | 0.0803 ns | 0.0751 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 25.96 ns | 0.1217 ns | 0.1139 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.44 ns | 0.1181 ns | 0.1104 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 19.96 ns | 0.1640 ns | 0.1454 ns |           - |           - |           - |                   - |
                                       From_NullObject | 20.89 ns | 0.0950 ns | 0.0889 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.26 ns | 0.0686 ns | 0.0608 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 19.74 ns | 0.1123 ns | 0.1050 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.19 ns | 0.1021 ns | 0.0955 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 25.95 ns | 0.1736 ns | 0.1624 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 19.29 ns | 0.1058 ns | 0.0989 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 22.29 ns | 0.1381 ns | 0.1292 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.58 ns | 0.1506 ns | 0.1408 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 21.37 ns | 0.0917 ns | 0.0813 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.49 ns | 0.0536 ns | 0.0502 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 21.17 ns | 0.1113 ns | 0.1041 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.28 ns | 0.0792 ns | 0.0702 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 27.05 ns | 0.1389 ns | 0.1300 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.74 ns | 0.1333 ns | 0.1247 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.27 ns | 0.1224 ns | 0.1145 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.16 ns | 0.1660 ns | 0.1553 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 22.37 ns | 0.1116 ns | 0.1043 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.17 ns | 0.0521 ns | 0.0487 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 23.43 ns | 0.1619 ns | 0.1515 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.22 ns | 0.0883 ns | 0.0826 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.33 ns | 0.1391 ns | 0.1161 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.29 ns | 0.0631 ns | 0.0591 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 24.34 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.14 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 51.27 ns | 0.2411 ns | 0.2255 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.59 ns | 0.0299 ns | 0.0249 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 49.57 ns | 0.2003 ns | 0.1874 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.88 ns | 0.0518 ns | 0.0485 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 22.20 ns | 0.1128 ns | 0.1055 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.44 ns | 0.0513 ns | 0.0455 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 23.78 ns | 0.1506 ns | 0.1409 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.45 ns | 0.0418 ns | 0.0371 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 22.14 ns | 0.1245 ns | 0.1165 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 41.35 ns | 0.2097 ns | 0.1961 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 23.27 ns | 0.0810 ns | 0.0757 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.02 ns | 0.2804 ns | 0.2623 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 23.31 ns | 0.0942 ns | 0.0881 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 45.40 ns | 0.3072 ns | 0.2724 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 20.48 ns | 0.0837 ns | 0.0783 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_String_Empty_AsObject: DefaultJob
