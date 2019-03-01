
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.395 ns | 0.1431 ns | 0.1338 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.052 ns | 0.1277 ns | 0.1195 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.557 ns | 0.0455 ns | 0.0355 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.412 ns | 0.0955 ns | 0.0894 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.879 ns | 0.0809 ns | 0.0757 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.653 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                                             From_Byte | 11.285 ns | 0.0522 ns | 0.0488 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 19.297 ns | 0.1477 ns | 0.1382 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.224 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 19.278 ns | 0.1459 ns | 0.1365 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.841 ns | 0.0564 ns | 0.0528 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.339 ns | 0.0710 ns | 0.0665 ns |           - |           - |           - |                   - |
                                             From_Char | 11.520 ns | 0.0471 ns | 0.0441 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.794 ns | 0.0873 ns | 0.0817 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.463 ns | 0.2184 ns | 0.2043 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 19.132 ns | 0.1475 ns | 0.1380 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.931 ns | 0.0790 ns | 0.0739 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.814 ns | 0.0826 ns | 0.0773 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.800 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.321 ns | 0.0624 ns | 0.0583 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.444 ns | 0.0921 ns | 0.0861 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.023 ns | 0.0570 ns | 0.0533 ns |           - |           - |           - |                   - |
                                          From_Decimal | 28.276 ns | 0.1424 ns | 0.1332 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.680 ns | 0.1154 ns | 0.1080 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 25.795 ns | 0.1241 ns | 0.1161 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 27.085 ns | 0.1230 ns | 0.1150 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.689 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.008 ns | 0.0283 ns | 0.0236 ns |           - |           - |           - |                   - |
                                           From_Double | 14.845 ns | 0.1299 ns | 0.1215 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 21.014 ns | 0.1229 ns | 0.1149 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.952 ns | 0.0831 ns | 0.0777 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 19.242 ns | 0.1106 ns | 0.1034 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.376 ns | 0.0393 ns | 0.0368 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.455 ns | 0.0936 ns | 0.0875 ns |           - |           - |           - |                   - |
                                            From_Short | 11.595 ns | 0.0713 ns | 0.0632 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 19.241 ns | 0.0906 ns | 0.0803 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.599 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 19.202 ns | 0.1347 ns | 0.1260 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.857 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.060 ns | 0.0579 ns | 0.0541 ns |           - |           - |           - |                   - |
                                              From_Int | 11.155 ns | 0.0703 ns | 0.0658 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 18.733 ns | 0.1806 ns | 0.1689 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 14.007 ns | 0.0503 ns | 0.0445 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.973 ns | 0.1362 ns | 0.1274 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.958 ns | 0.0830 ns | 0.0776 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 14.217 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
                                             From_Long | 11.358 ns | 0.0646 ns | 0.0604 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.852 ns | 0.1206 ns | 0.1128 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.487 ns | 0.1171 ns | 0.1095 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 19.560 ns | 0.1383 ns | 0.1294 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.474 ns | 0.0693 ns | 0.0648 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 14.468 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.152 ns | 0.0707 ns | 0.0661 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 12.975 ns | 0.0750 ns | 0.0702 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.360 ns | 0.0599 ns | 0.0561 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.792 ns | 0.1394 ns | 0.1304 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  9.471 ns | 0.0584 ns | 0.0546 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.318 ns | 0.1033 ns | 0.0915 ns |           - |           - |           - |                   - |
                                            From_Float | 14.236 ns | 0.0833 ns | 0.0695 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 22.515 ns | 0.1575 ns | 0.1473 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.424 ns | 0.0981 ns | 0.0918 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 21.371 ns | 0.0954 ns | 0.0892 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.005 ns | 0.0917 ns | 0.0813 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.016 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                                           From_String | 66.921 ns | 0.3254 ns | 0.3044 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 70.443 ns | 0.3263 ns | 0.3052 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.073 ns | 0.0584 ns | 0.0456 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.592 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.037 ns | 0.0522 ns | 0.0463 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.064 ns | 0.0523 ns | 0.0489 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.919 ns | 0.1247 ns | 0.1166 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.863 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.796 ns | 0.1396 ns | 0.1306 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.501 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.059 ns | 0.0466 ns | 0.0436 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.269 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 19.582 ns | 0.1905 ns | 0.1782 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.497 ns | 0.2086 ns | 0.1951 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 18.670 ns | 0.1089 ns | 0.1019 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.932 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.032 ns | 0.0630 ns | 0.0558 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.371 ns | 0.0828 ns | 0.0775 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 18.513 ns | 0.0963 ns | 0.0901 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.823 ns | 0.1063 ns | 0.0995 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 18.485 ns | 0.1624 ns | 0.1519 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.513 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.638 ns | 0.0721 ns | 0.0674 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.509 ns | 0.0781 ns | 0.0731 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.140 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 13.996 ns | 0.0449 ns | 0.0375 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 16.563 ns | 0.0869 ns | 0.0771 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.409 ns | 0.1077 ns | 0.1007 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.505 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 15.086 ns | 0.0463 ns | 0.0433 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.648 ns | 0.0649 ns | 0.0607 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 16.980 ns | 0.0868 ns | 0.0769 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.019 ns | 0.0595 ns | 0.0527 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.161 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.933 ns | 0.1652 ns | 0.1545 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.259 ns | 0.1117 ns | 0.1045 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.558 ns | 0.1004 ns | 0.0839 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.703 ns | 0.1067 ns | 0.0946 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.029 ns | 0.0940 ns | 0.0880 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.557 ns | 0.0715 ns | 0.0668 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.864 ns | 0.0908 ns | 0.0850 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.189 ns | 0.1130 ns | 0.1057 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.825 ns | 0.0759 ns | 0.0710 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.037 ns | 0.1029 ns | 0.0962 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.831 ns | 0.0373 ns | 0.0331 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.516 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.149 ns | 0.0645 ns | 0.0603 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 44.486 ns | 0.2877 ns | 0.2691 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 13.364 ns | 0.0598 ns | 0.0530 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 39.834 ns | 0.1931 ns | 0.1806 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.952 ns | 0.0627 ns | 0.0586 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.023 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.318 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.351 ns | 0.0677 ns | 0.0634 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.008 ns | 0.0541 ns | 0.0480 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 14.364 ns | 0.0678 ns | 0.0634 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.934 ns | 0.1655 ns | 0.1548 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.740 ns | 0.0998 ns | 0.0885 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.553 ns | 0.1164 ns | 0.1032 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.803 ns | 0.0669 ns | 0.0625 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.262 ns | 0.1834 ns | 0.1716 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 14.285 ns | 0.0460 ns | 0.0407 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByte.From_String_Empty_AsObject: DefaultJob
