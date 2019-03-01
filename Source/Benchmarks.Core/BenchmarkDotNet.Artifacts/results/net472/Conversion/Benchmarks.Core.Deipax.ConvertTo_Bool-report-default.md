
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  9.842 ns | 0.0701 ns | 0.0656 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 14.647 ns | 0.0902 ns | 0.0753 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  9.909 ns | 0.0651 ns | 0.0609 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.247 ns | 0.0779 ns | 0.0728 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.686 ns | 0.1076 ns | 0.1006 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.237 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.978 ns | 0.0762 ns | 0.0713 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 18.010 ns | 0.1340 ns | 0.1253 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.328 ns | 0.0534 ns | 0.0474 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.867 ns | 0.0598 ns | 0.0560 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.573 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.561 ns | 0.0633 ns | 0.0528 ns |           - |           - |           - |                   - |
                                             From_Char | 10.974 ns | 0.0720 ns | 0.0674 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.992 ns | 0.0706 ns | 0.0661 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.573 ns | 0.0392 ns | 0.0366 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.405 ns | 0.0674 ns | 0.0631 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.932 ns | 0.0682 ns | 0.0638 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.430 ns | 0.0425 ns | 0.0397 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.522 ns | 0.0974 ns | 0.0911 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 14.443 ns | 0.0462 ns | 0.0432 ns |           - |           - |           - |                   - |
                                          From_Decimal | 22.822 ns | 0.0877 ns | 0.0820 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 24.691 ns | 0.1071 ns | 0.1002 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 23.487 ns | 0.1004 ns | 0.0939 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 22.140 ns | 0.0774 ns | 0.0724 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.146 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 13.508 ns | 0.0497 ns | 0.0465 ns |           - |           - |           - |                   - |
                                           From_Double | 10.814 ns | 0.1203 ns | 0.1067 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.464 ns | 0.1443 ns | 0.1350 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.002 ns | 0.0617 ns | 0.0578 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.631 ns | 0.0858 ns | 0.0802 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.466 ns | 0.0768 ns | 0.0718 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 14.761 ns | 0.0697 ns | 0.0652 ns |           - |           - |           - |                   - |
                                            From_Short | 10.879 ns | 0.0374 ns | 0.0350 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.605 ns | 0.0897 ns | 0.0839 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.182 ns | 0.0737 ns | 0.0690 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.408 ns | 0.1085 ns | 0.1015 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.402 ns | 0.0764 ns | 0.0714 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.374 ns | 0.0776 ns | 0.0688 ns |           - |           - |           - |                   - |
                                              From_Int | 10.836 ns | 0.0748 ns | 0.0700 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 17.965 ns | 0.0836 ns | 0.0741 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.190 ns | 0.0781 ns | 0.0730 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.005 ns | 0.1476 ns | 0.1308 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.832 ns | 0.0769 ns | 0.0682 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.016 ns | 0.0517 ns | 0.0458 ns |           - |           - |           - |                   - |
                                             From_Long | 10.963 ns | 0.0789 ns | 0.0738 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.943 ns | 0.1376 ns | 0.1287 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.532 ns | 0.0717 ns | 0.0635 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.643 ns | 0.1776 ns | 0.1661 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.546 ns | 0.0727 ns | 0.0680 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.063 ns | 0.0813 ns | 0.0761 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.812 ns | 0.0594 ns | 0.0555 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 18.783 ns | 0.0917 ns | 0.0858 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.263 ns | 0.0751 ns | 0.0702 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 18.103 ns | 0.0627 ns | 0.0556 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.826 ns | 0.0536 ns | 0.0502 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.224 ns | 0.0836 ns | 0.0782 ns |           - |           - |           - |                   - |
                                            From_Float | 10.626 ns | 0.0395 ns | 0.0370 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.487 ns | 0.3738 ns | 0.4590 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.398 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 16.370 ns | 0.0596 ns | 0.0558 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.884 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.445 ns | 0.0816 ns | 0.0764 ns |           - |           - |           - |                   - |
                                           From_String | 24.492 ns | 0.1123 ns | 0.1050 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 28.753 ns | 0.1718 ns | 0.1607 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.704 ns | 0.0377 ns | 0.0353 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.483 ns | 0.0695 ns | 0.0650 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.949 ns | 0.0484 ns | 0.0453 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.810 ns | 0.0482 ns | 0.0427 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.204 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.869 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 16.331 ns | 0.1220 ns | 0.1141 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.880 ns | 0.0870 ns | 0.0813 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.214 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.851 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.716 ns | 0.1385 ns | 0.1295 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.183 ns | 0.0718 ns | 0.0672 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 18.682 ns | 0.2629 ns | 0.2459 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.838 ns | 0.0599 ns | 0.0560 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 13.337 ns | 0.0412 ns | 0.0365 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.836 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.923 ns | 0.1149 ns | 0.1074 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 12.607 ns | 0.0725 ns | 0.0679 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.806 ns | 0.1683 ns | 0.1574 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.325 ns | 0.0571 ns | 0.0534 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 14.881 ns | 0.0661 ns | 0.0618 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.476 ns | 0.0605 ns | 0.0536 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.224 ns | 0.0706 ns | 0.0661 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.018 ns | 0.0362 ns | 0.0338 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.725 ns | 0.0775 ns | 0.0725 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.669 ns | 0.2749 ns | 0.2571 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.044 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.037 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.035 ns | 0.0517 ns | 0.0458 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 18.192 ns | 0.3560 ns | 0.4372 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.031 ns | 0.0703 ns | 0.0658 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.063 ns | 0.0475 ns | 0.0445 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.106 ns | 0.0932 ns | 0.0826 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.523 ns | 0.1257 ns | 0.1114 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 18.709 ns | 0.1198 ns | 0.1062 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 15.616 ns | 0.0712 ns | 0.0631 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.289 ns | 0.0408 ns | 0.0382 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.347 ns | 0.0529 ns | 0.0469 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.429 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.964 ns | 0.0598 ns | 0.0499 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.988 ns | 0.0760 ns | 0.0710 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.540 ns | 0.0735 ns | 0.0688 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.852 ns | 0.0387 ns | 0.0343 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.084 ns | 0.0736 ns | 0.0688 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.862 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 40.930 ns | 0.2198 ns | 0.1948 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.301 ns | 0.0731 ns | 0.0648 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.581 ns | 0.1854 ns | 0.1734 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.863 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.423 ns | 0.0851 ns | 0.0796 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.060 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.883 ns | 0.0816 ns | 0.0763 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.025 ns | 0.0440 ns | 0.0390 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.366 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.546 ns | 0.2449 ns | 0.2291 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.110 ns | 0.1241 ns | 0.1036 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 45.403 ns | 0.1985 ns | 0.1857 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 14.949 ns | 0.0794 ns | 0.0743 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 36.648 ns | 0.2738 ns | 0.2561 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 14.360 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Bool.From_Char_AsObject: DefaultJob
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_String_Empty_AsObject: DefaultJob
