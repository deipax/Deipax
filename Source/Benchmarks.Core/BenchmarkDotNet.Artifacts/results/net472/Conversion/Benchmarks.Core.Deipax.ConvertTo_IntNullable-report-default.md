
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.27 ns | 0.1457 ns | 0.1362 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 24.49 ns | 0.1384 ns | 0.1295 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 15.00 ns | 0.0737 ns | 0.0689 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.51 ns | 0.1024 ns | 0.0957 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.62 ns | 0.0432 ns | 0.0404 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 21.31 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.15 ns | 0.0752 ns | 0.0667 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 24.30 ns | 0.1254 ns | 0.1112 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.90 ns | 0.0578 ns | 0.0513 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 26.36 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.65 ns | 0.0562 ns | 0.0526 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 22.30 ns | 0.1101 ns | 0.1030 ns |           - |           - |           - |                   - |
                                             From_Char | 12.25 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 28.45 ns | 0.1039 ns | 0.0867 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.67 ns | 0.0664 ns | 0.0621 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 26.11 ns | 0.1367 ns | 0.1279 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.63 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 22.31 ns | 0.1262 ns | 0.1180 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.31 ns | 0.0317 ns | 0.0281 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.43 ns | 0.0974 ns | 0.0911 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.48 ns | 0.0421 ns | 0.0373 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 22.50 ns | 0.0920 ns | 0.0860 ns |           - |           - |           - |                   - |
                                          From_Decimal | 18.62 ns | 0.0718 ns | 0.0671 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 32.61 ns | 0.1924 ns | 0.1799 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.49 ns | 0.0841 ns | 0.0786 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 29.22 ns | 0.1455 ns | 0.1361 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.35 ns | 0.0257 ns | 0.0241 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 23.63 ns | 0.0748 ns | 0.0663 ns |           - |           - |           - |                   - |
                                           From_Double | 14.36 ns | 0.0548 ns | 0.0512 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 29.08 ns | 0.1021 ns | 0.0955 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.63 ns | 0.0973 ns | 0.0910 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 28.03 ns | 0.1800 ns | 0.1684 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.30 ns | 0.0769 ns | 0.0720 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 22.44 ns | 0.0535 ns | 0.0447 ns |           - |           - |           - |                   - |
                                            From_Short | 12.39 ns | 0.0685 ns | 0.0641 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 24.29 ns | 0.0862 ns | 0.0806 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.62 ns | 0.0554 ns | 0.0518 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 24.53 ns | 0.0912 ns | 0.0762 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.30 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 21.47 ns | 0.0671 ns | 0.0595 ns |           - |           - |           - |                   - |
                                              From_Int | 11.51 ns | 0.0432 ns | 0.0383 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 32.76 ns | 0.3433 ns | 0.3211 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.02 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 34.49 ns | 0.1387 ns | 0.1297 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.08 ns | 0.0711 ns | 0.0665 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 19.90 ns | 0.1051 ns | 0.0983 ns |           - |           - |           - |                   - |
                                             From_Long | 13.03 ns | 0.0540 ns | 0.0505 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 27.87 ns | 0.1313 ns | 0.1164 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.59 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 27.32 ns | 0.1427 ns | 0.1335 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.24 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 22.18 ns | 0.0657 ns | 0.0549 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.18 ns | 0.0475 ns | 0.0444 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 28.93 ns | 0.0960 ns | 0.0898 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.62 ns | 0.0458 ns | 0.0429 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 26.62 ns | 0.0955 ns | 0.0893 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.62 ns | 0.0505 ns | 0.0473 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 23.60 ns | 0.1172 ns | 0.1097 ns |           - |           - |           - |                   - |
                                            From_Float | 14.41 ns | 0.0848 ns | 0.0793 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 25.70 ns | 0.1077 ns | 0.0954 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 14.45 ns | 0.0789 ns | 0.0738 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 28.82 ns | 0.0977 ns | 0.0914 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.87 ns | 0.0687 ns | 0.0643 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 23.67 ns | 0.0843 ns | 0.0789 ns |           - |           - |           - |                   - |
                                           From_String | 65.92 ns | 0.3785 ns | 0.3540 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 75.15 ns | 0.4900 ns | 0.4583 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.62 ns | 0.0479 ns | 0.0425 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 23.11 ns | 0.0690 ns | 0.0539 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 15.27 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.13 ns | 0.0423 ns | 0.0395 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 26.40 ns | 0.1062 ns | 0.0993 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.19 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 24.68 ns | 0.1197 ns | 0.1120 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.64 ns | 0.0506 ns | 0.0474 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 22.39 ns | 0.1030 ns | 0.0963 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.96 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 27.48 ns | 0.1250 ns | 0.1169 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.74 ns | 0.0219 ns | 0.0171 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 27.24 ns | 0.1021 ns | 0.0955 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.64 ns | 0.0480 ns | 0.0401 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 23.46 ns | 0.1333 ns | 0.1247 ns |           - |           - |           - |                   - |
                                            From_ULong | 13.58 ns | 0.0698 ns | 0.0653 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 26.96 ns | 0.1309 ns | 0.1225 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 15.03 ns | 0.0699 ns | 0.0620 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 25.93 ns | 0.1073 ns | 0.1004 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.24 ns | 0.0752 ns | 0.0704 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 23.68 ns | 0.1911 ns | 0.1787 ns |           - |           - |           - |                   - |
                                       From_NullObject | 22.30 ns | 0.1325 ns | 0.1240 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.19 ns | 0.0592 ns | 0.0524 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 22.47 ns | 0.0620 ns | 0.0580 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 22.84 ns | 0.0662 ns | 0.0587 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 26.42 ns | 0.1055 ns | 0.0986 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 20.94 ns | 0.0809 ns | 0.0756 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 23.83 ns | 0.1309 ns | 0.1224 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 13.51 ns | 0.0512 ns | 0.0478 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 21.72 ns | 0.0925 ns | 0.0866 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.47 ns | 0.0392 ns | 0.0367 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 23.63 ns | 0.0723 ns | 0.0677 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.62 ns | 0.0440 ns | 0.0412 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 26.63 ns | 0.0811 ns | 0.0719 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 24.64 ns | 0.1409 ns | 0.1318 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.61 ns | 0.0769 ns | 0.0642 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 19.87 ns | 0.1529 ns | 0.1430 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 23.39 ns | 0.0945 ns | 0.0884 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.13 ns | 0.0353 ns | 0.0313 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 21.68 ns | 0.0768 ns | 0.0681 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.21 ns | 0.0521 ns | 0.0487 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 24.82 ns | 0.0929 ns | 0.0869 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.19 ns | 0.0473 ns | 0.0443 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 20.96 ns | 0.0863 ns | 0.0808 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.17 ns | 0.0418 ns | 0.0391 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 50.46 ns | 0.2027 ns | 0.1896 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.62 ns | 0.0574 ns | 0.0480 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 49.90 ns | 0.1826 ns | 0.1708 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.66 ns | 0.0792 ns | 0.0741 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 22.55 ns | 0.1391 ns | 0.1301 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.48 ns | 0.0577 ns | 0.0540 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 26.56 ns | 0.0705 ns | 0.0659 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.46 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 22.30 ns | 0.0959 ns | 0.0897 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 39.11 ns | 0.1653 ns | 0.1547 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 25.37 ns | 0.0769 ns | 0.0719 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.49 ns | 0.1544 ns | 0.1444 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 24.56 ns | 0.0847 ns | 0.0792 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.60 ns | 0.1412 ns | 0.1321 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 21.31 ns | 0.1404 ns | 0.1314 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_IntNullable.From_String_Empty_AsObject: DefaultJob
