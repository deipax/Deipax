
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.84 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 24.36 ns | 0.1379 ns | 0.1290 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.65 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 27.78 ns | 0.1173 ns | 0.1097 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.70 ns | 0.0518 ns | 0.0485 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 24.40 ns | 0.1169 ns | 0.1093 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.16 ns | 0.0401 ns | 0.0355 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 24.62 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.63 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 27.71 ns | 0.1075 ns | 0.1006 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.66 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 22.29 ns | 0.1426 ns | 0.1334 ns |           - |           - |           - |                   - |
                                             From_Char | 12.15 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 26.28 ns | 0.0729 ns | 0.0682 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.61 ns | 0.0412 ns | 0.0386 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 26.85 ns | 0.1129 ns | 0.1000 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.68 ns | 0.0646 ns | 0.0604 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 20.32 ns | 0.1271 ns | 0.1189 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.87 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.93 ns | 0.0685 ns | 0.0640 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.87 ns | 0.0581 ns | 0.0485 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 20.29 ns | 0.1177 ns | 0.1101 ns |           - |           - |           - |                   - |
                                          From_Decimal | 25.03 ns | 0.1276 ns | 0.1194 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 35.12 ns | 0.1908 ns | 0.1691 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 26.58 ns | 0.0789 ns | 0.0659 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 34.56 ns | 0.3031 ns | 0.2835 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.06 ns | 0.0521 ns | 0.0488 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 22.19 ns | 0.1316 ns | 0.1231 ns |           - |           - |           - |                   - |
                                           From_Double | 15.20 ns | 0.0777 ns | 0.0727 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 29.69 ns | 0.0613 ns | 0.0543 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 17.07 ns | 0.1227 ns | 0.1148 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 29.86 ns | 0.1631 ns | 0.1526 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.17 ns | 0.0379 ns | 0.0336 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 20.23 ns | 0.0928 ns | 0.0868 ns |           - |           - |           - |                   - |
                                            From_Short | 12.88 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 28.45 ns | 0.1261 ns | 0.1118 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.39 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 26.72 ns | 0.0848 ns | 0.0793 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.63 ns | 0.0717 ns | 0.0635 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 22.31 ns | 0.0664 ns | 0.0589 ns |           - |           - |           - |                   - |
                                              From_Int | 12.92 ns | 0.0316 ns | 0.0296 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 27.16 ns | 0.1594 ns | 0.1491 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.60 ns | 0.0693 ns | 0.0648 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 28.73 ns | 0.0758 ns | 0.0672 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.65 ns | 0.0651 ns | 0.0577 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 23.55 ns | 0.1170 ns | 0.1094 ns |           - |           - |           - |                   - |
                                             From_Long | 13.00 ns | 0.0363 ns | 0.0340 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 28.84 ns | 0.1356 ns | 0.1202 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 15.53 ns | 0.1167 ns | 0.1091 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 26.07 ns | 0.1154 ns | 0.1080 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.92 ns | 0.0710 ns | 0.0629 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 23.32 ns | 0.1105 ns | 0.1034 ns |           - |           - |           - |                   - |
                                            From_SByte | 14.00 ns | 0.0971 ns | 0.0908 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 24.75 ns | 0.1380 ns | 0.1291 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 14.02 ns | 0.0973 ns | 0.0910 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 24.84 ns | 0.0759 ns | 0.0710 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.64 ns | 0.0505 ns | 0.0472 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 23.61 ns | 0.1000 ns | 0.0936 ns |           - |           - |           - |                   - |
                                            From_Float | 15.29 ns | 0.0933 ns | 0.0873 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 29.95 ns | 0.1642 ns | 0.1536 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 16.43 ns | 0.1194 ns | 0.1117 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 26.93 ns | 0.1500 ns | 0.1403 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.08 ns | 0.0511 ns | 0.0453 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 20.35 ns | 0.0867 ns | 0.0768 ns |           - |           - |           - |                   - |
                                           From_String | 65.21 ns | 0.2312 ns | 0.2050 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 74.37 ns | 0.5362 ns | 0.5015 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.20 ns | 0.0516 ns | 0.0430 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 21.41 ns | 0.1087 ns | 0.0963 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.97 ns | 0.0584 ns | 0.0546 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.49 ns | 0.0249 ns | 0.0208 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 34.85 ns | 0.1526 ns | 0.1353 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.02 ns | 0.0401 ns | 0.0375 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 34.78 ns | 0.1563 ns | 0.1462 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.07 ns | 0.0412 ns | 0.0365 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 20.28 ns | 0.1063 ns | 0.0995 ns |           - |           - |           - |                   - |
                                             From_UInt | 13.56 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 25.48 ns | 0.1185 ns | 0.1050 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 14.09 ns | 0.0615 ns | 0.0545 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 26.99 ns | 0.0872 ns | 0.0773 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.67 ns | 0.0807 ns | 0.0755 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 20.20 ns | 0.0961 ns | 0.0899 ns |           - |           - |           - |                   - |
                                            From_ULong | 13.03 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 24.92 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.32 ns | 0.0733 ns | 0.0686 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 28.50 ns | 0.1251 ns | 0.1170 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.21 ns | 0.0622 ns | 0.0551 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 22.15 ns | 0.0708 ns | 0.0662 ns |           - |           - |           - |                   - |
                                       From_NullObject | 19.27 ns | 0.0813 ns | 0.0760 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.22 ns | 0.0413 ns | 0.0387 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.09 ns | 0.1330 ns | 0.1244 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.68 ns | 0.1214 ns | 0.1135 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 27.29 ns | 0.0948 ns | 0.0887 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 22.19 ns | 0.0993 ns | 0.0929 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 23.46 ns | 0.1284 ns | 0.1201 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.50 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 23.68 ns | 0.0907 ns | 0.0848 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 14.37 ns | 0.0314 ns | 0.0278 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 19.80 ns | 0.0788 ns | 0.0698 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.10 ns | 0.0860 ns | 0.0804 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 25.65 ns | 0.0690 ns | 0.0645 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.32 ns | 0.0642 ns | 0.0601 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.82 ns | 0.0688 ns | 0.0610 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.52 ns | 0.0883 ns | 0.0826 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 23.75 ns | 0.1096 ns | 0.0971 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.18 ns | 0.0705 ns | 0.0660 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 25.15 ns | 0.0673 ns | 0.0596 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.42 ns | 0.0338 ns | 0.0282 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.60 ns | 0.0739 ns | 0.0691 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.87 ns | 0.0770 ns | 0.0720 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 23.53 ns | 0.0998 ns | 0.0934 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.03 ns | 0.1033 ns | 0.0966 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 49.80 ns | 0.3246 ns | 0.3036 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 14.07 ns | 0.0506 ns | 0.0448 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 52.15 ns | 0.1682 ns | 0.1573 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.63 ns | 0.0474 ns | 0.0443 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 20.44 ns | 0.0662 ns | 0.0619 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.47 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 24.72 ns | 0.1397 ns | 0.1239 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 14.12 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 20.45 ns | 0.0600 ns | 0.0562 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.41 ns | 0.1818 ns | 0.1701 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 24.14 ns | 0.0718 ns | 0.0637 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 38.13 ns | 0.1765 ns | 0.1651 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.16 ns | 0.0940 ns | 0.0879 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 40.23 ns | 0.2364 ns | 0.2211 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 20.41 ns | 0.1126 ns | 0.1053 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_String_Empty_AsObject: DefaultJob
