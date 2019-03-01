
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.559 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 18.272 ns | 0.0641 ns | 0.0599 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.938 ns | 0.1362 ns | 0.1274 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.469 ns | 0.1770 ns | 0.1655 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.834 ns | 0.0548 ns | 0.0513 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.118 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.863 ns | 0.0440 ns | 0.0390 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 18.263 ns | 0.1618 ns | 0.1513 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.468 ns | 0.1243 ns | 0.1163 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.641 ns | 0.0811 ns | 0.0759 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.164 ns | 0.0502 ns | 0.0470 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.292 ns | 0.0752 ns | 0.0703 ns |           - |           - |           - |                   - |
                                             From_Char | 10.552 ns | 0.0391 ns | 0.0346 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.831 ns | 0.0406 ns | 0.0380 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.849 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.093 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.018 ns | 0.0708 ns | 0.0628 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.612 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.586 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.020 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.087 ns | 0.1011 ns | 0.0946 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 20.666 ns | 0.1349 ns | 0.1196 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 21.879 ns | 0.0923 ns | 0.0863 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 20.359 ns | 0.0746 ns | 0.0623 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.041 ns | 0.0440 ns | 0.0412 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 14.079 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                                           From_Double |  9.636 ns | 0.0303 ns | 0.0284 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 12.754 ns | 0.0592 ns | 0.0553 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.325 ns | 0.0892 ns | 0.0834 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 14.140 ns | 0.0622 ns | 0.0582 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.944 ns | 0.0481 ns | 0.0426 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.716 ns | 0.0381 ns | 0.0356 ns |           - |           - |           - |                   - |
                                            From_Short | 10.881 ns | 0.0512 ns | 0.0479 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 18.790 ns | 0.1537 ns | 0.1437 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.795 ns | 0.0451 ns | 0.0422 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 19.000 ns | 0.0697 ns | 0.0618 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.914 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.628 ns | 0.0379 ns | 0.0316 ns |           - |           - |           - |                   - |
                                              From_Int | 10.635 ns | 0.0822 ns | 0.0769 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 16.532 ns | 0.0604 ns | 0.0536 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.515 ns | 0.1060 ns | 0.0991 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.595 ns | 0.0831 ns | 0.0777 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.872 ns | 0.0389 ns | 0.0345 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 13.058 ns | 0.0583 ns | 0.0517 ns |           - |           - |           - |                   - |
                                             From_Long | 10.856 ns | 0.0511 ns | 0.0453 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 19.230 ns | 0.1522 ns | 0.1423 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.852 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 18.665 ns | 0.0964 ns | 0.0901 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.580 ns | 0.0744 ns | 0.0696 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 14.522 ns | 0.2893 ns | 0.5217 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.853 ns | 0.1155 ns | 0.0964 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 20.870 ns | 0.2405 ns | 0.2250 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.387 ns | 0.1988 ns | 0.1859 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 18.144 ns | 0.1599 ns | 0.1335 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.763 ns | 0.1035 ns | 0.0968 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 15.310 ns | 0.2507 ns | 0.2094 ns |           - |           - |           - |                   - |
                                            From_Float | 12.460 ns | 0.1193 ns | 0.1057 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 18.120 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.950 ns | 0.1342 ns | 0.1255 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 19.995 ns | 0.2412 ns | 0.2138 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.046 ns | 0.1174 ns | 0.1041 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 15.272 ns | 0.0458 ns | 0.0382 ns |           - |           - |           - |                   - |
                                           From_String | 75.300 ns | 0.9721 ns | 0.9093 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 78.746 ns | 0.2264 ns | 0.1890 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.519 ns | 0.1028 ns | 0.0859 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.806 ns | 0.0575 ns | 0.0449 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.808 ns | 0.1876 ns | 0.1663 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.375 ns | 0.1262 ns | 0.1181 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.716 ns | 0.3489 ns | 0.3427 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.158 ns | 0.2823 ns | 0.2641 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.584 ns | 0.2891 ns | 0.2563 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.890 ns | 0.1428 ns | 0.1335 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.958 ns | 0.2116 ns | 0.1875 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.377 ns | 0.2514 ns | 0.2351 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.366 ns | 0.0698 ns | 0.0653 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.128 ns | 0.2464 ns | 0.2184 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 21.320 ns | 0.0963 ns | 0.0804 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.664 ns | 0.0638 ns | 0.0597 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.100 ns | 0.1900 ns | 0.1684 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.463 ns | 0.0916 ns | 0.0812 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 19.963 ns | 0.0946 ns | 0.0885 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.023 ns | 0.0875 ns | 0.0818 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 19.122 ns | 0.1115 ns | 0.0989 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.956 ns | 0.0464 ns | 0.0411 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 14.838 ns | 0.2145 ns | 0.2006 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.015 ns | 0.1590 ns | 0.1487 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.159 ns | 0.0565 ns | 0.0472 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.810 ns | 0.0909 ns | 0.0759 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 15.417 ns | 0.1244 ns | 0.1103 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.838 ns | 0.1267 ns | 0.1123 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.362 ns | 0.0878 ns | 0.0821 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 14.082 ns | 0.1667 ns | 0.1478 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.512 ns | 0.0562 ns | 0.0498 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 16.331 ns | 0.2185 ns | 0.2044 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.219 ns | 0.0859 ns | 0.0762 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 15.071 ns | 0.3007 ns | 0.2813 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.172 ns | 0.0646 ns | 0.0573 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 18.172 ns | 0.8502 ns | 1.8840 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.661 ns | 0.0798 ns | 0.0708 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.585 ns | 0.0842 ns | 0.0788 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 10.969 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.846 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.426 ns | 0.0586 ns | 0.0519 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.112 ns | 0.0986 ns | 0.0922 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.824 ns | 0.0285 ns | 0.0252 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.913 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.877 ns | 0.0690 ns | 0.0645 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.653 ns | 0.0407 ns | 0.0381 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.584 ns | 0.0564 ns | 0.0528 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 41.998 ns | 0.2382 ns | 0.2228 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.864 ns | 0.0607 ns | 0.0538 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.549 ns | 0.1811 ns | 0.1694 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.910 ns | 0.0580 ns | 0.0542 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.978 ns | 0.0367 ns | 0.0343 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.584 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.179 ns | 0.0885 ns | 0.0828 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.988 ns | 0.0346 ns | 0.0307 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.984 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.063 ns | 0.1383 ns | 0.1293 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.432 ns | 0.0490 ns | 0.0459 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 39.234 ns | 0.1551 ns | 0.1451 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 16.100 ns | 0.0668 ns | 0.0558 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.554 ns | 0.1757 ns | 0.1558 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.866 ns | 0.0364 ns | 0.0284 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Double.From_Char_AsObject: DefaultJob
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_String_Empty_AsObject: DefaultJob
