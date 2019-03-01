
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.86 ns | 0.0622 ns | 0.0582 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 28.10 ns | 0.1182 ns | 0.1048 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 13.04 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 24.54 ns | 0.1523 ns | 0.1424 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.81 ns | 0.0434 ns | 0.0362 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 20.71 ns | 0.0645 ns | 0.0572 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.57 ns | 0.0810 ns | 0.0757 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 27.92 ns | 0.1245 ns | 0.1165 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.81 ns | 0.0455 ns | 0.0425 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 24.66 ns | 0.1649 ns | 0.1542 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.77 ns | 0.0833 ns | 0.0779 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 23.68 ns | 0.0816 ns | 0.0763 ns |           - |           - |           - |                   - |
                                             From_Char | 12.42 ns | 0.0916 ns | 0.0857 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.35 ns | 0.0547 ns | 0.0512 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.35 ns | 0.0483 ns | 0.0377 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 25.28 ns | 0.1280 ns | 0.1197 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.82 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.40 ns | 0.0638 ns | 0.0596 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.92 ns | 0.0731 ns | 0.0684 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 22.52 ns | 0.0592 ns | 0.0524 ns |           - |           - |           - |                   - |
                                          From_Decimal | 22.86 ns | 0.0664 ns | 0.0554 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 32.57 ns | 0.2218 ns | 0.2074 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 26.14 ns | 0.1370 ns | 0.1282 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 33.52 ns | 0.2079 ns | 0.1843 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.69 ns | 0.0963 ns | 0.0900 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 20.99 ns | 0.0999 ns | 0.0885 ns |           - |           - |           - |                   - |
                                           From_Double | 12.81 ns | 0.1017 ns | 0.0951 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 26.97 ns | 0.2087 ns | 0.1952 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.95 ns | 0.0423 ns | 0.0375 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 28.36 ns | 0.1244 ns | 0.1163 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.63 ns | 0.0668 ns | 0.0625 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 22.23 ns | 0.0780 ns | 0.0729 ns |           - |           - |           - |                   - |
                                            From_Short | 12.58 ns | 0.0468 ns | 0.0415 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 26.97 ns | 0.0906 ns | 0.0803 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.79 ns | 0.0428 ns | 0.0379 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 27.88 ns | 0.0802 ns | 0.0750 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.48 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 20.88 ns | 0.1347 ns | 0.1194 ns |           - |           - |           - |                   - |
                                              From_Int | 12.44 ns | 0.0704 ns | 0.0624 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 28.43 ns | 0.1241 ns | 0.1161 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.83 ns | 0.0636 ns | 0.0595 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 28.42 ns | 0.1050 ns | 0.0982 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.80 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 20.76 ns | 0.0961 ns | 0.0899 ns |           - |           - |           - |                   - |
                                             From_Long | 12.65 ns | 0.0627 ns | 0.0523 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 26.95 ns | 0.2303 ns | 0.2154 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.75 ns | 0.1327 ns | 0.1241 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 24.47 ns | 0.1327 ns | 0.1241 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.52 ns | 0.2235 ns | 0.2090 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 21.14 ns | 0.0964 ns | 0.0902 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.73 ns | 0.0668 ns | 0.0624 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 27.18 ns | 0.1759 ns | 0.1646 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.82 ns | 0.0516 ns | 0.0482 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 27.63 ns | 0.1034 ns | 0.0967 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 13.40 ns | 0.0631 ns | 0.0591 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 22.31 ns | 0.0842 ns | 0.0788 ns |           - |           - |           - |                   - |
                                            From_Float | 12.18 ns | 0.0778 ns | 0.0728 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 34.36 ns | 0.1518 ns | 0.1346 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.02 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 35.31 ns | 0.2890 ns | 0.2703 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.44 ns | 0.0567 ns | 0.0530 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 22.26 ns | 0.0917 ns | 0.0813 ns |           - |           - |           - |                   - |
                                           From_String | 71.78 ns | 0.3045 ns | 0.2700 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 83.36 ns | 0.5837 ns | 0.5460 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.76 ns | 0.0990 ns | 0.0926 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 23.73 ns | 0.0934 ns | 0.0874 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.43 ns | 0.0864 ns | 0.0808 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.61 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 26.80 ns | 0.1162 ns | 0.1087 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 14.92 ns | 0.0805 ns | 0.0753 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 26.78 ns | 0.0776 ns | 0.0688 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.81 ns | 0.0435 ns | 0.0407 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 23.69 ns | 0.0703 ns | 0.0657 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.59 ns | 0.0562 ns | 0.0525 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 24.57 ns | 0.0893 ns | 0.0836 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.80 ns | 0.0841 ns | 0.0787 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 25.39 ns | 0.1173 ns | 0.1097 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.88 ns | 0.0624 ns | 0.0584 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 23.58 ns | 0.0816 ns | 0.0723 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.96 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 27.24 ns | 0.1789 ns | 0.1674 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.71 ns | 0.0886 ns | 0.0785 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 27.08 ns | 0.0970 ns | 0.0907 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.46 ns | 0.2013 ns | 0.1882 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 20.61 ns | 0.1161 ns | 0.1086 ns |           - |           - |           - |                   - |
                                       From_NullObject | 23.68 ns | 0.1027 ns | 0.0960 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.38 ns | 0.0513 ns | 0.0480 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.61 ns | 0.1007 ns | 0.0942 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.67 ns | 0.1149 ns | 0.1018 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 27.62 ns | 0.1073 ns | 0.1004 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.84 ns | 0.1320 ns | 0.1235 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 22.20 ns | 0.0952 ns | 0.0891 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.75 ns | 0.0514 ns | 0.0480 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 25.23 ns | 0.1162 ns | 0.1087 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.69 ns | 0.0845 ns | 0.0749 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 22.31 ns | 0.0976 ns | 0.0913 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.04 ns | 0.0838 ns | 0.0743 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 26.68 ns | 0.1101 ns | 0.1030 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.25 ns | 0.1253 ns | 0.1172 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.13 ns | 0.0937 ns | 0.0876 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.79 ns | 0.0718 ns | 0.0671 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 22.50 ns | 0.1725 ns | 0.1613 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.34 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 21.59 ns | 0.0694 ns | 0.0616 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.38 ns | 0.0506 ns | 0.0449 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 24.80 ns | 0.0830 ns | 0.0736 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.37 ns | 0.0697 ns | 0.0618 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 23.88 ns | 0.2004 ns | 0.1875 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.33 ns | 0.0448 ns | 0.0397 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 50.36 ns | 0.1998 ns | 0.1771 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.57 ns | 0.0748 ns | 0.0699 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 48.40 ns | 0.2452 ns | 0.2293 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.80 ns | 0.0555 ns | 0.0520 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 22.61 ns | 0.1233 ns | 0.1153 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.62 ns | 0.0418 ns | 0.0370 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 21.85 ns | 0.1170 ns | 0.1094 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.65 ns | 0.0353 ns | 0.0295 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 23.17 ns | 0.0508 ns | 0.0451 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.22 ns | 0.1560 ns | 0.1383 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 22.39 ns | 0.1366 ns | 0.1278 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 46.63 ns | 0.1359 ns | 0.1271 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 21.77 ns | 0.1123 ns | 0.1050 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 40.22 ns | 0.1457 ns | 0.1292 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 24.40 ns | 0.0933 ns | 0.0873 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_String_Empty_AsObject: DefaultJob
