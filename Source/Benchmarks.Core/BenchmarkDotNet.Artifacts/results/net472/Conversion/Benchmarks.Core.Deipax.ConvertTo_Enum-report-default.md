
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 21.308 ns | 0.0876 ns | 0.0776 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 33.052 ns | 0.1581 ns | 0.1478 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 24.013 ns | 0.1151 ns | 0.1020 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 31.114 ns | 0.1416 ns | 0.1182 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.635 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.089 ns | 0.0599 ns | 0.0561 ns |           - |           - |           - |                   - |
                                             From_Byte | 21.148 ns | 0.1287 ns | 0.1141 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 33.306 ns | 0.6580 ns | 0.6155 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 24.732 ns | 0.3284 ns | 0.2742 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 32.050 ns | 0.2697 ns | 0.2523 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.680 ns | 0.0518 ns | 0.0459 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 10.597 ns | 0.0380 ns | 0.0337 ns |           - |           - |           - |                   - |
                                             From_Char | 21.079 ns | 0.0615 ns | 0.0576 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 31.820 ns | 0.2654 ns | 0.2483 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 24.758 ns | 0.0637 ns | 0.0532 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 30.843 ns | 0.1688 ns | 0.1497 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.649 ns | 0.0349 ns | 0.0310 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.538 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
                                         From_DateTime | 26.142 ns | 0.0367 ns | 0.0306 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 26.194 ns | 0.1296 ns | 0.1212 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.601 ns | 0.0858 ns | 0.0803 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.154 ns | 0.0296 ns | 0.0262 ns |           - |           - |           - |                   - |
                                          From_Decimal | 33.268 ns | 0.1608 ns | 0.1426 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 38.737 ns | 0.1505 ns | 0.1334 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 32.328 ns | 0.1732 ns | 0.1620 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 37.852 ns | 0.1350 ns | 0.1262 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.079 ns | 0.0644 ns | 0.0538 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.076 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                                           From_Double | 25.896 ns | 0.0801 ns | 0.0749 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 34.959 ns | 0.1779 ns | 0.1664 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 28.896 ns | 0.1130 ns | 0.1057 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 33.562 ns | 0.1537 ns | 0.1438 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 14.610 ns | 0.0298 ns | 0.0279 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.114 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                                            From_Short | 21.113 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 32.352 ns | 0.2280 ns | 0.2133 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 23.791 ns | 0.0763 ns | 0.0714 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 35.430 ns | 0.1501 ns | 0.1404 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.658 ns | 0.0446 ns | 0.0417 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 10.596 ns | 0.0429 ns | 0.0401 ns |           - |           - |           - |                   - |
                                              From_Int | 21.300 ns | 0.1043 ns | 0.0976 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 28.579 ns | 0.1146 ns | 0.1072 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 23.687 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 31.770 ns | 0.1309 ns | 0.1225 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  9.624 ns | 0.0413 ns | 0.0366 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 10.581 ns | 0.0367 ns | 0.0325 ns |           - |           - |           - |                   - |
                                             From_Long | 26.980 ns | 0.1387 ns | 0.1230 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 34.583 ns | 0.1981 ns | 0.1853 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 28.110 ns | 0.1180 ns | 0.1103 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 34.658 ns | 0.1209 ns | 0.1131 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.638 ns | 0.0371 ns | 0.0310 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 10.574 ns | 0.0371 ns | 0.0347 ns |           - |           - |           - |                   - |
                                            From_SByte | 21.369 ns | 0.1537 ns | 0.1437 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 37.804 ns | 0.2191 ns | 0.2049 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 23.703 ns | 0.0685 ns | 0.0607 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 33.531 ns | 0.1450 ns | 0.1356 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.426 ns | 0.0419 ns | 0.0350 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.069 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
                                            From_Float | 23.647 ns | 0.2011 ns | 0.1679 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 35.293 ns | 0.1471 ns | 0.1376 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 25.689 ns | 0.1058 ns | 0.0990 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 35.712 ns | 0.1378 ns | 0.1222 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.615 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.001 ns | 0.0303 ns | 0.0253 ns |           - |           - |           - |                   - |
                                           From_String | 38.070 ns | 0.1877 ns | 0.1756 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 44.789 ns | 0.1236 ns | 0.1096 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.418 ns | 0.0603 ns | 0.0504 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.453 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 10.280 ns | 0.0427 ns | 0.0379 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject | 21.507 ns | 0.1125 ns | 0.1053 ns |           - |           - |           - |                   - |
                                           From_UShort | 21.099 ns | 0.0720 ns | 0.0674 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 32.907 ns | 0.1364 ns | 0.1276 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 24.056 ns | 0.1163 ns | 0.1031 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 32.701 ns | 0.1464 ns | 0.1298 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.626 ns | 0.0253 ns | 0.0224 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.643 ns | 0.0544 ns | 0.0508 ns |           - |           - |           - |                   - |
                                             From_UInt | 23.859 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 32.211 ns | 0.2463 ns | 0.2304 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 25.568 ns | 0.0744 ns | 0.0696 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 33.617 ns | 0.1412 ns | 0.1321 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.944 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.108 ns | 0.0860 ns | 0.0805 ns |           - |           - |           - |                   - |
                                            From_ULong | 24.026 ns | 0.0641 ns | 0.0599 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 33.383 ns | 0.1024 ns | 0.0908 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 30.561 ns | 0.0608 ns | 0.0539 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 34.577 ns | 0.1016 ns | 0.0950 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.004 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.069 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
                                       From_NullObject | 10.583 ns | 0.0452 ns | 0.0400 ns |           - |           - |           - |                   - |
                                           From_DBNull | 12.132 ns | 0.0448 ns | 0.0374 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.027 ns | 0.0373 ns | 0.0331 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 34.390 ns | 0.1763 ns | 0.1649 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 33.335 ns | 0.1643 ns | 0.1536 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 10.598 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.070 ns | 0.0605 ns | 0.0536 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 24.559 ns | 0.0772 ns | 0.0722 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 31.687 ns | 0.0847 ns | 0.0751 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.590 ns | 0.0423 ns | 0.0395 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.330 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 32.745 ns | 0.2130 ns | 0.1992 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 30.336 ns | 0.2144 ns | 0.1790 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 33.658 ns | 0.1969 ns | 0.1842 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 32.140 ns | 0.0803 ns | 0.0712 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  9.537 ns | 0.0421 ns | 0.0394 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 10.596 ns | 0.0458 ns | 0.0429 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 24.917 ns | 0.0966 ns | 0.0904 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 31.770 ns | 0.1784 ns | 0.1582 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 23.424 ns | 0.1004 ns | 0.0890 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 31.246 ns | 0.1329 ns | 0.1244 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.520 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.234 ns | 0.0628 ns | 0.0587 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.538 ns | 0.0459 ns | 0.0429 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 13.892 ns | 0.0300 ns | 0.0266 ns |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue | 11.412 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 10.955 ns | 0.0278 ns | 0.0246 ns |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |  9.482 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 10.575 ns | 0.0313 ns | 0.0278 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 24.248 ns | 0.0660 ns | 0.0617 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 31.223 ns | 0.0927 ns | 0.0868 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.129 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.902 ns | 0.0502 ns | 0.0470 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 92.828 ns | 0.3189 ns | 0.2983 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 29.951 ns | 0.1184 ns | 0.1108 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 88.532 ns | 0.4473 ns | 0.4184 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 30.777 ns | 0.1147 ns | 0.1017 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 52.068 ns | 0.1601 ns | 0.1498 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.616 ns | 0.0748 ns | 0.0700 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
