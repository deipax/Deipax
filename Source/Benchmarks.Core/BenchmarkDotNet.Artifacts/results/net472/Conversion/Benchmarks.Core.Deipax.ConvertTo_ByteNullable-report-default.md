
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.38 ns | 0.0630 ns | 0.0559 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.25 ns | 0.1181 ns | 0.1047 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 13.34 ns | 0.0389 ns | 0.0363 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.38 ns | 0.1328 ns | 0.1242 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.66 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 23.23 ns | 0.1135 ns | 0.1006 ns |           - |           - |           - |                   - |
                                             From_Byte | 14.13 ns | 0.0351 ns | 0.0311 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 35.68 ns | 0.1623 ns | 0.1438 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.04 ns | 0.0560 ns | 0.0524 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 32.43 ns | 0.1740 ns | 0.1628 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.26 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 19.20 ns | 0.0844 ns | 0.0790 ns |           - |           - |           - |                   - |
                                             From_Char | 12.96 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 25.11 ns | 0.1212 ns | 0.1134 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 14.00 ns | 0.0607 ns | 0.0538 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 28.21 ns | 0.1339 ns | 0.1252 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.61 ns | 0.0581 ns | 0.0515 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 22.22 ns | 0.1116 ns | 0.1044 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.97 ns | 0.0639 ns | 0.0534 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.86 ns | 0.0420 ns | 0.0393 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.87 ns | 0.0500 ns | 0.0468 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 22.29 ns | 0.1161 ns | 0.1086 ns |           - |           - |           - |                   - |
                                          From_Decimal | 24.90 ns | 0.0753 ns | 0.0704 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 34.80 ns | 0.1813 ns | 0.1696 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 26.73 ns | 0.1426 ns | 0.1334 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 34.60 ns | 0.1914 ns | 0.1697 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.72 ns | 0.0401 ns | 0.0356 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 23.56 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                                           From_Double | 15.25 ns | 0.0840 ns | 0.0744 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 26.71 ns | 0.0785 ns | 0.0696 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.33 ns | 0.0690 ns | 0.0646 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 29.93 ns | 0.0912 ns | 0.0853 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.12 ns | 0.0547 ns | 0.0512 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 23.23 ns | 0.0914 ns | 0.0810 ns |           - |           - |           - |                   - |
                                            From_Short | 13.19 ns | 0.0704 ns | 0.0658 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 27.36 ns | 0.1097 ns | 0.1026 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.37 ns | 0.0572 ns | 0.0507 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 27.32 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.86 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 22.33 ns | 0.1200 ns | 0.1122 ns |           - |           - |           - |                   - |
                                              From_Int | 13.84 ns | 0.1380 ns | 0.1291 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 27.41 ns | 0.0994 ns | 0.0929 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.48 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 25.42 ns | 0.1339 ns | 0.1253 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.60 ns | 0.0394 ns | 0.0368 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 20.66 ns | 0.0789 ns | 0.0699 ns |           - |           - |           - |                   - |
                                             From_Long | 13.58 ns | 0.0692 ns | 0.0647 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 25.56 ns | 0.0880 ns | 0.0823 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.25 ns | 0.1027 ns | 0.0961 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 27.02 ns | 0.1071 ns | 0.0950 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.15 ns | 0.0470 ns | 0.0440 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 23.62 ns | 0.1242 ns | 0.1161 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.91 ns | 0.0721 ns | 0.0675 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 27.00 ns | 0.0990 ns | 0.0877 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 15.01 ns | 0.0579 ns | 0.0541 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 27.07 ns | 0.0783 ns | 0.0695 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.63 ns | 0.0417 ns | 0.0370 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 19.37 ns | 0.1564 ns | 0.1387 ns |           - |           - |           - |                   - |
                                            From_Float | 15.20 ns | 0.0557 ns | 0.0465 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 29.02 ns | 0.1919 ns | 0.1795 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 15.06 ns | 0.0910 ns | 0.0851 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 27.50 ns | 0.0876 ns | 0.0777 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.48 ns | 0.0659 ns | 0.0616 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 23.35 ns | 0.0941 ns | 0.0834 ns |           - |           - |           - |                   - |
                                           From_String | 66.49 ns | 0.4246 ns | 0.3972 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 78.23 ns | 0.5364 ns | 0.5017 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.51 ns | 0.0380 ns | 0.0355 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 22.05 ns | 0.1355 ns | 0.1267 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.57 ns | 0.0872 ns | 0.0816 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.99 ns | 0.0751 ns | 0.0703 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 26.87 ns | 0.1394 ns | 0.1304 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.39 ns | 0.0971 ns | 0.0861 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 27.09 ns | 0.0994 ns | 0.0930 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.69 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 22.10 ns | 0.1204 ns | 0.1126 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.92 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 28.75 ns | 0.1001 ns | 0.0936 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.41 ns | 0.0764 ns | 0.0677 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 26.89 ns | 0.1265 ns | 0.1183 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.68 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 23.44 ns | 0.0842 ns | 0.0788 ns |           - |           - |           - |                   - |
                                            From_ULong | 13.19 ns | 0.0657 ns | 0.0615 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 26.90 ns | 0.1294 ns | 0.1147 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.24 ns | 0.0752 ns | 0.0667 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 28.31 ns | 0.1437 ns | 0.1344 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.18 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 25.76 ns | 0.0799 ns | 0.0747 ns |           - |           - |           - |                   - |
                                       From_NullObject | 22.30 ns | 0.0913 ns | 0.0854 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.21 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 20.15 ns | 0.0683 ns | 0.0639 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.85 ns | 0.1231 ns | 0.1151 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 23.22 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.32 ns | 0.0709 ns | 0.0628 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 22.02 ns | 0.0736 ns | 0.0688 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.50 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 24.69 ns | 0.0598 ns | 0.0530 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.52 ns | 0.0928 ns | 0.0868 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 21.16 ns | 0.1263 ns | 0.1181 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.97 ns | 0.0537 ns | 0.0502 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 25.65 ns | 0.0840 ns | 0.0786 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.55 ns | 0.1485 ns | 0.1316 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.25 ns | 0.1642 ns | 0.1536 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.85 ns | 0.1335 ns | 0.1249 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 23.63 ns | 0.1255 ns | 0.1174 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.30 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 24.87 ns | 0.1416 ns | 0.1324 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.18 ns | 0.0429 ns | 0.0402 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 25.50 ns | 0.1082 ns | 0.1012 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.36 ns | 0.0423 ns | 0.0396 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 20.60 ns | 0.1293 ns | 0.1209 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.00 ns | 0.0751 ns | 0.0702 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 49.56 ns | 0.2414 ns | 0.2258 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.71 ns | 0.0887 ns | 0.0830 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 53.17 ns | 0.1711 ns | 0.1600 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.62 ns | 0.0582 ns | 0.0516 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 23.56 ns | 0.1534 ns | 0.1435 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.43 ns | 0.0365 ns | 0.0323 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 23.65 ns | 0.0861 ns | 0.0763 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.50 ns | 0.0666 ns | 0.0590 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 20.45 ns | 0.0938 ns | 0.0878 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.65 ns | 0.1539 ns | 0.1440 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 25.20 ns | 0.1516 ns | 0.1418 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 43.17 ns | 0.1487 ns | 0.1391 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 25.32 ns | 0.1503 ns | 0.1405 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 39.55 ns | 0.1996 ns | 0.1867 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 20.51 ns | 0.1192 ns | 0.1115 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_String_Empty_AsObject: DefaultJob
