
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.207 ns | 0.1552 ns | 0.1452 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.991 ns | 0.0879 ns | 0.0822 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.165 ns | 0.0481 ns | 0.0427 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.959 ns | 0.0861 ns | 0.0806 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.923 ns | 0.1254 ns | 0.1173 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.616 ns | 0.0456 ns | 0.0404 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.891 ns | 0.0548 ns | 0.0513 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 18.025 ns | 0.1513 ns | 0.1415 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.163 ns | 0.1565 ns | 0.1464 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 18.103 ns | 0.1303 ns | 0.1155 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.880 ns | 0.0628 ns | 0.0588 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.408 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                                             From_Char | 10.617 ns | 0.0686 ns | 0.0608 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 15.940 ns | 0.0494 ns | 0.0412 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.240 ns | 0.1996 ns | 0.1867 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.877 ns | 0.0782 ns | 0.0732 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.917 ns | 0.0777 ns | 0.0689 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.186 ns | 0.0623 ns | 0.0582 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.843 ns | 0.0799 ns | 0.0709 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.368 ns | 0.0533 ns | 0.0445 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.316 ns | 0.0497 ns | 0.0441 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 14.532 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                                          From_Decimal | 24.106 ns | 0.0984 ns | 0.0920 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 26.532 ns | 0.1674 ns | 0.1566 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 24.902 ns | 0.1115 ns | 0.1043 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 25.635 ns | 0.1287 ns | 0.1204 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.974 ns | 0.0692 ns | 0.0648 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.991 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                                           From_Double | 13.889 ns | 0.0818 ns | 0.0765 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.389 ns | 0.1209 ns | 0.1131 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 16.018 ns | 0.0897 ns | 0.0839 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.403 ns | 0.1654 ns | 0.1547 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.396 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 14.889 ns | 0.0393 ns | 0.0367 ns |           - |           - |           - |                   - |
                                            From_Short | 11.344 ns | 0.0500 ns | 0.0443 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 19.289 ns | 0.0960 ns | 0.0851 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.388 ns | 0.1342 ns | 0.1255 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 18.476 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.371 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.583 ns | 0.0397 ns | 0.0352 ns |           - |           - |           - |                   - |
                                              From_Int | 11.247 ns | 0.0672 ns | 0.0628 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 19.372 ns | 0.1067 ns | 0.0998 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.445 ns | 0.1834 ns | 0.1716 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.974 ns | 0.1255 ns | 0.1174 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.420 ns | 0.0896 ns | 0.0794 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 14.367 ns | 0.1338 ns | 0.1251 ns |           - |           - |           - |                   - |
                                             From_Long | 11.397 ns | 0.0227 ns | 0.0189 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 16.722 ns | 0.1235 ns | 0.1094 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 15.530 ns | 0.1265 ns | 0.1183 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.626 ns | 0.1050 ns | 0.0982 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.434 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.603 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.344 ns | 0.0850 ns | 0.0795 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 18.375 ns | 0.1072 ns | 0.0896 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.217 ns | 0.0889 ns | 0.0832 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.582 ns | 0.0736 ns | 0.0689 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.829 ns | 0.0493 ns | 0.0437 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.391 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
                                            From_Float | 14.317 ns | 0.0905 ns | 0.0756 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 18.404 ns | 0.0821 ns | 0.0728 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.638 ns | 0.1503 ns | 0.1332 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 20.940 ns | 0.1134 ns | 0.1061 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.897 ns | 0.0534 ns | 0.0500 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 14.316 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
                                           From_String | 66.986 ns | 0.3639 ns | 0.3404 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 68.476 ns | 0.6385 ns | 0.5972 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.935 ns | 0.0600 ns | 0.0531 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.602 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 13.232 ns | 0.0931 ns | 0.0871 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.484 ns | 0.0358 ns | 0.0335 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 14.309 ns | 0.0549 ns | 0.0486 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  9.614 ns | 0.0737 ns | 0.0689 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.839 ns | 0.0533 ns | 0.0498 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.535 ns | 0.0612 ns | 0.0572 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.288 ns | 0.0336 ns | 0.0262 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.237 ns | 0.0690 ns | 0.0645 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.078 ns | 0.0868 ns | 0.0812 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.603 ns | 0.1288 ns | 0.1142 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 19.509 ns | 0.1588 ns | 0.1486 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.986 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 13.606 ns | 0.0611 ns | 0.0572 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.359 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 19.061 ns | 0.0500 ns | 0.0443 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.730 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.107 ns | 0.0974 ns | 0.0911 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.442 ns | 0.0827 ns | 0.0774 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.544 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.016 ns | 0.0460 ns | 0.0384 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.832 ns | 0.1317 ns | 0.1167 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.286 ns | 0.0608 ns | 0.0569 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.645 ns | 0.0756 ns | 0.0707 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.470 ns | 0.0667 ns | 0.0591 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.451 ns | 0.0382 ns | 0.0357 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.601 ns | 0.0619 ns | 0.0549 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.449 ns | 0.0329 ns | 0.0292 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.058 ns | 0.0681 ns | 0.0637 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.982 ns | 0.0739 ns | 0.0655 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.709 ns | 0.0643 ns | 0.0602 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 18.354 ns | 0.1086 ns | 0.1016 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.742 ns | 0.1246 ns | 0.1104 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 18.351 ns | 0.1051 ns | 0.0983 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.619 ns | 0.0886 ns | 0.0829 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 10.925 ns | 0.0390 ns | 0.0364 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.575 ns | 0.0635 ns | 0.0594 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.875 ns | 0.0791 ns | 0.0740 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.184 ns | 0.1323 ns | 0.1237 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.849 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.002 ns | 0.0572 ns | 0.0535 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.875 ns | 0.0621 ns | 0.0581 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.131 ns | 0.0588 ns | 0.0522 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.335 ns | 0.0734 ns | 0.0687 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 45.422 ns | 0.2690 ns | 0.2516 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.986 ns | 0.0609 ns | 0.0570 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 42.344 ns | 0.1479 ns | 0.1311 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.099 ns | 0.0691 ns | 0.0647 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.457 ns | 0.0455 ns | 0.0425 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.053 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.907 ns | 0.1435 ns | 0.1342 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.407 ns | 0.0401 ns | 0.0375 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 14.370 ns | 0.0957 ns | 0.0895 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 40.284 ns | 0.1531 ns | 0.1432 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.850 ns | 0.0568 ns | 0.0503 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.310 ns | 0.2388 ns | 0.2234 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.233 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 49.088 ns | 0.1922 ns | 0.1798 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.597 ns | 0.0756 ns | 0.0707 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShort.From_String_Empty_AsObject: DefaultJob
