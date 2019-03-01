
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 19.69 ns | 0.0709 ns | 0.0629 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.65 ns | 0.0703 ns | 0.0657 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 19.84 ns | 0.1136 ns | 0.1062 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.62 ns | 0.1151 ns | 0.1076 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 14.40 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.73 ns | 0.0618 ns | 0.0578 ns |           - |           - |           - |                   - |
                                             From_Byte | 19.71 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 25.98 ns | 0.0797 ns | 0.0745 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 19.51 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 25.33 ns | 0.0909 ns | 0.0850 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 12.85 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.64 ns | 0.0539 ns | 0.0505 ns |           - |           - |           - |                   - |
                                             From_Char | 12.69 ns | 0.0816 ns | 0.0724 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 14.13 ns | 0.0483 ns | 0.0428 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.58 ns | 0.0377 ns | 0.0353 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.48 ns | 0.0376 ns | 0.0333 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.77 ns | 0.0428 ns | 0.0358 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 15.00 ns | 0.0735 ns | 0.0688 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.03 ns | 0.1070 ns | 0.1001 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 15.29 ns | 0.0477 ns | 0.0423 ns |           - |           - |           - |                   - |
                                          From_Decimal | 13.96 ns | 0.0577 ns | 0.0540 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 32.88 ns | 0.1232 ns | 0.1093 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 12.80 ns | 0.0554 ns | 0.0518 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 33.22 ns | 0.1577 ns | 0.1475 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.86 ns | 0.0570 ns | 0.0505 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.75 ns | 0.0357 ns | 0.0316 ns |           - |           - |           - |                   - |
                                           From_Double | 64.44 ns | 0.1922 ns | 0.1798 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 72.36 ns | 0.3776 ns | 0.3532 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 65.47 ns | 0.2775 ns | 0.2460 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 72.52 ns | 0.2456 ns | 0.2298 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 14.11 ns | 0.0384 ns | 0.0320 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.50 ns | 0.0799 ns | 0.0708 ns |           - |           - |           - |                   - |
                                            From_Short | 18.85 ns | 0.0838 ns | 0.0783 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 25.55 ns | 0.0907 ns | 0.0804 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 19.99 ns | 0.0862 ns | 0.0806 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 25.33 ns | 0.0830 ns | 0.0776 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.70 ns | 0.0704 ns | 0.0658 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.62 ns | 0.0578 ns | 0.0541 ns |           - |           - |           - |                   - |
                                              From_Int | 18.78 ns | 0.0325 ns | 0.0288 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 26.08 ns | 0.1445 ns | 0.1352 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 19.31 ns | 0.0661 ns | 0.0619 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 25.50 ns | 0.0470 ns | 0.0416 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.69 ns | 0.0825 ns | 0.0772 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 13.62 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
                                             From_Long | 19.02 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 26.96 ns | 0.0877 ns | 0.0778 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 20.40 ns | 0.0820 ns | 0.0767 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 26.42 ns | 0.0726 ns | 0.0679 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.11 ns | 0.0751 ns | 0.0627 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 14.60 ns | 0.0356 ns | 0.0316 ns |           - |           - |           - |                   - |
                                            From_SByte | 18.85 ns | 0.0832 ns | 0.0778 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 25.66 ns | 0.1243 ns | 0.1102 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 19.54 ns | 0.0702 ns | 0.0657 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 26.00 ns | 0.0764 ns | 0.0715 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.79 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 15.54 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                                            From_Float | 35.88 ns | 0.1288 ns | 0.1205 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 45.17 ns | 0.2331 ns | 0.2067 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 36.17 ns | 0.1246 ns | 0.1105 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 47.01 ns | 0.2121 ns | 0.1984 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.94 ns | 0.1284 ns | 0.1201 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.48 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
                                           From_String | 88.37 ns | 0.5746 ns | 0.5375 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 93.33 ns | 0.4408 ns | 0.3681 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.70 ns | 0.1297 ns | 0.1213 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 16.31 ns | 0.0930 ns | 0.0825 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.08 ns | 0.0993 ns | 0.0929 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 19.14 ns | 0.0985 ns | 0.0922 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 25.93 ns | 0.0718 ns | 0.0671 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 29.46 ns | 0.0828 ns | 0.0775 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 25.36 ns | 0.0676 ns | 0.0632 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.66 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 15.53 ns | 0.0757 ns | 0.0632 ns |           - |           - |           - |                   - |
                                             From_UInt | 18.82 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 26.16 ns | 0.0840 ns | 0.0786 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 19.54 ns | 0.1052 ns | 0.0984 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 26.70 ns | 0.0662 ns | 0.0587 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.64 ns | 0.0453 ns | 0.0423 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 15.70 ns | 0.3067 ns | 0.2869 ns |           - |           - |           - |                   - |
                                            From_ULong | 18.81 ns | 0.0859 ns | 0.0761 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 26.23 ns | 0.0752 ns | 0.0667 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 20.18 ns | 0.0889 ns | 0.0831 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 26.56 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.71 ns | 0.1089 ns | 0.1018 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 18.14 ns | 0.0751 ns | 0.0702 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.73 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.58 ns | 0.0249 ns | 0.0221 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.64 ns | 0.0486 ns | 0.0455 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 20.61 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 21.25 ns | 0.0914 ns | 0.0855 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 15.31 ns | 0.0702 ns | 0.0657 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 16.25 ns | 0.1265 ns | 0.1183 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.48 ns | 0.0305 ns | 0.0286 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.61 ns | 0.0715 ns | 0.0669 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 14.18 ns | 0.1208 ns | 0.1130 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.65 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 20.76 ns | 0.0481 ns | 0.0450 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 20.81 ns | 0.0647 ns | 0.0540 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 20.95 ns | 0.1075 ns | 0.1006 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 20.78 ns | 0.0834 ns | 0.0780 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 13.36 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.63 ns | 0.0630 ns | 0.0559 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.41 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 18.70 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.44 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.10 ns | 0.0735 ns | 0.0687 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.46 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 14.75 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                                             From_Enum | 18.92 ns | 0.0554 ns | 0.0519 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 48.40 ns | 0.2109 ns | 0.1973 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 19.44 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 51.22 ns | 0.2539 ns | 0.2375 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.65 ns | 0.0475 ns | 0.0445 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 14.57 ns | 0.0393 ns | 0.0368 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.48 ns | 0.0393 ns | 0.0368 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.96 ns | 0.0816 ns | 0.0763 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 13.93 ns | 0.0184 ns | 0.0143 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 14.63 ns | 0.0834 ns | 0.0739 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.15 ns | 0.1804 ns | 0.1688 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.42 ns | 0.0437 ns | 0.0387 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.95 ns | 0.0986 ns | 0.0823 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.89 ns | 0.0772 ns | 0.0722 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.67 ns | 0.1318 ns | 0.1233 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.59 ns | 0.0658 ns | 0.0615 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: DefaultJob
