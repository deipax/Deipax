
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.270 ns | 0.1080 ns | 0.1010 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.866 ns | 0.0829 ns | 0.0775 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.470 ns | 0.0737 ns | 0.0689 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.924 ns | 0.0831 ns | 0.0778 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.883 ns | 0.0534 ns | 0.0500 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.605 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.858 ns | 0.0540 ns | 0.0505 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 18.968 ns | 0.1354 ns | 0.1267 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.291 ns | 0.1456 ns | 0.1362 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 18.881 ns | 0.1496 ns | 0.1399 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.557 ns | 0.0492 ns | 0.0461 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.530 ns | 0.0259 ns | 0.0230 ns |           - |           - |           - |                   - |
                                             From_Char | 10.612 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.079 ns | 0.0917 ns | 0.0858 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.330 ns | 0.1252 ns | 0.1171 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 18.374 ns | 0.1553 ns | 0.1452 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.897 ns | 0.0381 ns | 0.0356 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.750 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.801 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.751 ns | 0.0581 ns | 0.0544 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.391 ns | 0.0661 ns | 0.0618 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 14.298 ns | 0.0489 ns | 0.0458 ns |           - |           - |           - |                   - |
                                          From_Decimal | 20.792 ns | 0.1210 ns | 0.1132 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.498 ns | 0.1063 ns | 0.0995 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 22.121 ns | 0.0891 ns | 0.0790 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 25.274 ns | 0.0979 ns | 0.0916 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.898 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.435 ns | 0.0464 ns | 0.0412 ns |           - |           - |           - |                   - |
                                           From_Double | 11.786 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 19.554 ns | 0.1199 ns | 0.1122 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.258 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.277 ns | 0.0971 ns | 0.0908 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.508 ns | 0.0383 ns | 0.0358 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.044 ns | 0.0409 ns | 0.0382 ns |           - |           - |           - |                   - |
                                            From_Short | 11.470 ns | 0.0296 ns | 0.0262 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.329 ns | 0.1251 ns | 0.1170 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.537 ns | 0.1182 ns | 0.1106 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.958 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.408 ns | 0.0863 ns | 0.0808 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.508 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
                                              From_Int | 11.015 ns | 0.0426 ns | 0.0378 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 16.765 ns | 0.0765 ns | 0.0638 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.245 ns | 0.1705 ns | 0.1595 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.801 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.961 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.982 ns | 0.0507 ns | 0.0424 ns |           - |           - |           - |                   - |
                                             From_Long | 11.313 ns | 0.0310 ns | 0.0290 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.707 ns | 0.1016 ns | 0.0951 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.727 ns | 0.0948 ns | 0.0887 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.794 ns | 0.1090 ns | 0.1020 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.432 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.863 ns | 0.0564 ns | 0.0471 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.325 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.939 ns | 0.1183 ns | 0.1107 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.080 ns | 0.0847 ns | 0.0792 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.623 ns | 0.0881 ns | 0.0824 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.866 ns | 0.0697 ns | 0.0652 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.675 ns | 0.0261 ns | 0.0232 ns |           - |           - |           - |                   - |
                                            From_Float | 12.397 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.559 ns | 0.1362 ns | 0.1274 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.941 ns | 0.1923 ns | 0.1799 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.589 ns | 0.1514 ns | 0.1416 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.933 ns | 0.0704 ns | 0.0659 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.993 ns | 0.0380 ns | 0.0355 ns |           - |           - |           - |                   - |
                                           From_String | 65.327 ns | 0.2521 ns | 0.2358 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 70.229 ns | 0.4127 ns | 0.3860 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.289 ns | 0.0899 ns | 0.0841 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.632 ns | 0.0778 ns | 0.0689 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.038 ns | 0.0615 ns | 0.0576 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.323 ns | 0.0731 ns | 0.0684 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.213 ns | 0.1010 ns | 0.0945 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.468 ns | 0.1402 ns | 0.1311 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.741 ns | 0.0979 ns | 0.0915 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.903 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.626 ns | 0.0359 ns | 0.0335 ns |           - |           - |           - |                   - |
                                             From_UInt |  9.633 ns | 0.0489 ns | 0.0458 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 14.788 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  9.544 ns | 0.0607 ns | 0.0568 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 12.829 ns | 0.0667 ns | 0.0624 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.476 ns | 0.0466 ns | 0.0413 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.698 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.301 ns | 0.0431 ns | 0.0403 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.958 ns | 0.0898 ns | 0.0840 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.705 ns | 0.0620 ns | 0.0580 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.553 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.482 ns | 0.0546 ns | 0.0511 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.969 ns | 0.0304 ns | 0.0270 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.787 ns | 0.0220 ns | 0.0195 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.903 ns | 0.0540 ns | 0.0505 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.279 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.680 ns | 0.0693 ns | 0.0648 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.698 ns | 0.0951 ns | 0.0889 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 14.430 ns | 0.0488 ns | 0.0457 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.601 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.237 ns | 0.0706 ns | 0.0660 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.265 ns | 0.0259 ns | 0.0216 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.099 ns | 0.0571 ns | 0.0534 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.669 ns | 0.0707 ns | 0.0661 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.808 ns | 0.0333 ns | 0.0296 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.206 ns | 0.1129 ns | 0.1056 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.690 ns | 0.0972 ns | 0.0862 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.158 ns | 0.0936 ns | 0.0830 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.002 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.039 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.432 ns | 0.0673 ns | 0.0562 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.833 ns | 0.1182 ns | 0.1106 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.833 ns | 0.0461 ns | 0.0431 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.136 ns | 0.1070 ns | 0.1001 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.880 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 14.296 ns | 0.0584 ns | 0.0518 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.078 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 46.088 ns | 0.2384 ns | 0.2230 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.360 ns | 0.1967 ns | 0.1839 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.975 ns | 0.1364 ns | 0.1210 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.958 ns | 0.0381 ns | 0.0356 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.528 ns | 0.0716 ns | 0.0670 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.017 ns | 0.0593 ns | 0.0554 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.324 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.407 ns | 0.0594 ns | 0.0496 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.562 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 42.108 ns | 0.2245 ns | 0.2100 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.922 ns | 0.1036 ns | 0.0969 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.135 ns | 0.1083 ns | 0.0960 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.881 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 40.903 ns | 0.1547 ns | 0.1447 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 14.240 ns | 0.0648 ns | 0.0606 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UInt.From_String_Empty_AsObject: DefaultJob
