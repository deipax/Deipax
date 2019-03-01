
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.34 ns | 0.1285 ns | 0.1202 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.45 ns | 0.0924 ns | 0.0865 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.63 ns | 0.0506 ns | 0.0474 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 27.94 ns | 0.1443 ns | 0.1350 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 13.43 ns | 0.0737 ns | 0.0689 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 20.57 ns | 0.1704 ns | 0.1510 ns |           - |           - |           - |                   - |
                                             From_Byte | 14.27 ns | 0.0988 ns | 0.0924 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 26.98 ns | 0.1455 ns | 0.1361 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.60 ns | 0.1460 ns | 0.1365 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 28.71 ns | 0.2149 ns | 0.1905 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.63 ns | 0.0517 ns | 0.0458 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 22.30 ns | 0.1466 ns | 0.1300 ns |           - |           - |           - |                   - |
                                             From_Char | 13.43 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 26.73 ns | 0.1373 ns | 0.1285 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 13.36 ns | 0.0722 ns | 0.0675 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 27.84 ns | 0.1235 ns | 0.1155 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.66 ns | 0.0775 ns | 0.0687 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 20.55 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.82 ns | 0.0758 ns | 0.0709 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.47 ns | 0.0719 ns | 0.0672 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 15.19 ns | 0.0824 ns | 0.0770 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 23.64 ns | 0.1207 ns | 0.1129 ns |           - |           - |           - |                   - |
                                          From_Decimal | 25.07 ns | 0.1155 ns | 0.0965 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 34.88 ns | 0.2092 ns | 0.1855 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 26.48 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 35.17 ns | 0.2058 ns | 0.1925 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.48 ns | 0.1244 ns | 0.1164 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 20.46 ns | 0.1142 ns | 0.1068 ns |           - |           - |           - |                   - |
                                           From_Double | 15.18 ns | 0.0970 ns | 0.0907 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 27.71 ns | 0.1620 ns | 0.1515 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.43 ns | 0.0861 ns | 0.0806 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 27.73 ns | 0.0916 ns | 0.0812 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.23 ns | 0.0512 ns | 0.0478 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 21.58 ns | 0.1000 ns | 0.0935 ns |           - |           - |           - |                   - |
                                            From_Short | 13.01 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 29.11 ns | 0.1293 ns | 0.1209 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.35 ns | 0.0497 ns | 0.0415 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 25.71 ns | 0.1074 ns | 0.1005 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.71 ns | 0.0712 ns | 0.0666 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 23.39 ns | 0.1234 ns | 0.1154 ns |           - |           - |           - |                   - |
                                              From_Int | 14.65 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 29.03 ns | 0.1366 ns | 0.1211 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.28 ns | 0.0637 ns | 0.0596 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 28.96 ns | 0.1872 ns | 0.1659 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 13.06 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 22.32 ns | 0.1052 ns | 0.0933 ns |           - |           - |           - |                   - |
                                             From_Long | 12.99 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 25.28 ns | 0.1210 ns | 0.1132 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.29 ns | 0.0797 ns | 0.0707 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 28.67 ns | 0.1099 ns | 0.1028 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 14.13 ns | 0.0938 ns | 0.0783 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 23.42 ns | 0.0881 ns | 0.0824 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.55 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 32.58 ns | 0.1835 ns | 0.1627 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.32 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 32.33 ns | 0.1205 ns | 0.1127 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.05 ns | 0.1049 ns | 0.0876 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 21.47 ns | 0.0860 ns | 0.0718 ns |           - |           - |           - |                   - |
                                            From_Float | 15.96 ns | 0.1004 ns | 0.0939 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 29.90 ns | 0.1159 ns | 0.1028 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 15.61 ns | 0.1174 ns | 0.1098 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 30.25 ns | 0.2452 ns | 0.2294 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.36 ns | 0.0515 ns | 0.0456 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 22.43 ns | 0.0778 ns | 0.0728 ns |           - |           - |           - |                   - |
                                           From_String | 65.78 ns | 0.5497 ns | 0.5142 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 76.72 ns | 0.5552 ns | 0.5193 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.60 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 25.01 ns | 0.1232 ns | 0.1152 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.60 ns | 0.0692 ns | 0.0647 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.94 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 27.61 ns | 0.1196 ns | 0.1119 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.36 ns | 0.0641 ns | 0.0599 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 26.67 ns | 0.0759 ns | 0.0673 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.71 ns | 0.0548 ns | 0.0513 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 20.30 ns | 0.1096 ns | 0.1025 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.93 ns | 0.0433 ns | 0.0405 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 26.81 ns | 0.1333 ns | 0.1247 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 14.13 ns | 0.0828 ns | 0.0774 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 24.93 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.70 ns | 0.0597 ns | 0.0558 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 22.36 ns | 0.1006 ns | 0.0941 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.92 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 25.97 ns | 0.1060 ns | 0.0992 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.32 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 26.96 ns | 0.1083 ns | 0.1013 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.22 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 20.71 ns | 0.0953 ns | 0.0892 ns |           - |           - |           - |                   - |
                                       From_NullObject | 23.43 ns | 0.0623 ns | 0.0552 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.24 ns | 0.0721 ns | 0.0674 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 25.00 ns | 0.1087 ns | 0.1016 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 26.84 ns | 0.0723 ns | 0.0641 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 25.08 ns | 0.1209 ns | 0.1131 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.42 ns | 0.1125 ns | 0.1052 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 23.38 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.46 ns | 0.0407 ns | 0.0380 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 23.61 ns | 0.0786 ns | 0.0735 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 14.15 ns | 0.0456 ns | 0.0404 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 22.07 ns | 0.1048 ns | 0.0981 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.03 ns | 0.1124 ns | 0.0996 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 26.74 ns | 0.1121 ns | 0.0994 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.49 ns | 0.1094 ns | 0.1023 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.55 ns | 0.1238 ns | 0.1158 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.79 ns | 0.0681 ns | 0.0637 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 20.18 ns | 0.0975 ns | 0.0912 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.21 ns | 0.0940 ns | 0.0879 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 21.63 ns | 0.0868 ns | 0.0812 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.16 ns | 0.0375 ns | 0.0351 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.92 ns | 0.0960 ns | 0.0898 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.14 ns | 0.0596 ns | 0.0558 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 23.46 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.97 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 53.50 ns | 0.2455 ns | 0.2297 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.32 ns | 0.0275 ns | 0.0230 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 48.25 ns | 0.2329 ns | 0.2179 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.61 ns | 0.0385 ns | 0.0341 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 22.32 ns | 0.1015 ns | 0.0950 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 14.20 ns | 0.1032 ns | 0.0965 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 23.92 ns | 0.1028 ns | 0.0961 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 14.09 ns | 0.0256 ns | 0.0240 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 19.30 ns | 0.1168 ns | 0.1093 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.29 ns | 0.1463 ns | 0.1369 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 21.82 ns | 0.0922 ns | 0.0863 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 40.21 ns | 0.1844 ns | 0.1725 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 25.37 ns | 0.1724 ns | 0.1612 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 46.41 ns | 0.1722 ns | 0.1610 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 23.41 ns | 0.0689 ns | 0.0611 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_String_Empty_AsObject: DefaultJob
