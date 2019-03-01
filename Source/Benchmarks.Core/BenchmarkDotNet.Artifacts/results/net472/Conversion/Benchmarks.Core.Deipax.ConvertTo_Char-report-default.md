
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.365 ns | 0.0869 ns | 0.0812 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.893 ns | 0.0574 ns | 0.0537 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.883 ns | 0.1311 ns | 0.1163 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.643 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.906 ns | 0.0997 ns | 0.0933 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.434 ns | 0.1001 ns | 0.0936 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.370 ns | 0.1397 ns | 0.1307 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 18.008 ns | 0.1573 ns | 0.1472 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.889 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.153 ns | 0.0486 ns | 0.0431 ns |           - |           - |           - |                   - |
                                             From_Char |  9.634 ns | 0.0568 ns | 0.0531 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 12.859 ns | 0.0803 ns | 0.0751 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  9.549 ns | 0.0452 ns | 0.0401 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 14.805 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.564 ns | 0.0559 ns | 0.0522 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.005 ns | 0.0489 ns | 0.0457 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.306 ns | 0.0578 ns | 0.0513 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.311 ns | 0.0516 ns | 0.0457 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.341 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.528 ns | 0.0445 ns | 0.0417 ns |           - |           - |           - |                   - |
                                          From_Decimal | 12.281 ns | 0.0647 ns | 0.0574 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 12.726 ns | 0.0606 ns | 0.0567 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.821 ns | 0.0751 ns | 0.0665 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.181 ns | 0.0561 ns | 0.0497 ns |           - |           - |           - |                   - |
                                           From_Double | 10.881 ns | 0.0616 ns | 0.0546 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.322 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.588 ns | 0.0613 ns | 0.0543 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.551 ns | 0.0308 ns | 0.0258 ns |           - |           - |           - |                   - |
                                            From_Short | 11.359 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.927 ns | 0.1382 ns | 0.1293 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 12.380 ns | 0.0836 ns | 0.0782 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 18.510 ns | 0.0959 ns | 0.0851 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.941 ns | 0.0488 ns | 0.0408 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.406 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                              From_Int | 11.255 ns | 0.0444 ns | 0.0416 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 18.863 ns | 0.1422 ns | 0.1330 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.306 ns | 0.2041 ns | 0.1909 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.866 ns | 0.1170 ns | 0.1095 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 11.019 ns | 0.0748 ns | 0.0699 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.424 ns | 0.0562 ns | 0.0526 ns |           - |           - |           - |                   - |
                                             From_Long | 11.828 ns | 0.0956 ns | 0.0894 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.898 ns | 0.0965 ns | 0.0855 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.261 ns | 0.0678 ns | 0.0601 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 19.814 ns | 0.1019 ns | 0.0953 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.445 ns | 0.1079 ns | 0.0956 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.010 ns | 0.0655 ns | 0.0580 ns |           - |           - |           - |                   - |
                                            From_SByte | 11.361 ns | 0.0812 ns | 0.0759 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.957 ns | 0.0818 ns | 0.0766 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.219 ns | 0.1002 ns | 0.0937 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 18.748 ns | 0.0917 ns | 0.0858 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.854 ns | 0.0407 ns | 0.0381 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.613 ns | 0.0770 ns | 0.0720 ns |           - |           - |           - |                   - |
                                            From_Float | 10.925 ns | 0.0678 ns | 0.0634 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 10.914 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.944 ns | 0.0743 ns | 0.0695 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.442 ns | 0.0584 ns | 0.0518 ns |           - |           - |           - |                   - |
                                           From_String | 14.854 ns | 0.1054 ns | 0.0986 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 18.258 ns | 0.1168 ns | 0.1092 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.149 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.747 ns | 0.0613 ns | 0.0543 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.814 ns | 0.0916 ns | 0.0857 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.674 ns | 0.0717 ns | 0.0670 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 18.947 ns | 0.1605 ns | 0.1501 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.396 ns | 0.1932 ns | 0.1808 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 18.698 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.074 ns | 0.1682 ns | 0.1573 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.397 ns | 0.0988 ns | 0.0924 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.279 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 18.969 ns | 0.1079 ns | 0.1009 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.578 ns | 0.1071 ns | 0.1002 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.023 ns | 0.0661 ns | 0.0618 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.007 ns | 0.0642 ns | 0.0601 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.068 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.335 ns | 0.0394 ns | 0.0350 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 19.389 ns | 0.1131 ns | 0.1058 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 14.345 ns | 0.0916 ns | 0.0812 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 18.334 ns | 0.1057 ns | 0.0989 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 12.525 ns | 0.0783 ns | 0.0733 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.049 ns | 0.0569 ns | 0.0505 ns |           - |           - |           - |                   - |
                                       From_NullObject | 16.464 ns | 0.0462 ns | 0.0432 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.570 ns | 0.0582 ns | 0.0516 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.432 ns | 0.1403 ns | 0.1313 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.588 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.154 ns | 0.1227 ns | 0.1088 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 14.061 ns | 0.0717 ns | 0.0670 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.602 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.718 ns | 0.0503 ns | 0.0471 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.035 ns | 0.0723 ns | 0.0641 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.660 ns | 0.0593 ns | 0.0555 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.673 ns | 0.0552 ns | 0.0489 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.043 ns | 0.0651 ns | 0.0609 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.271 ns | 0.1189 ns | 0.1112 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.747 ns | 0.1259 ns | 0.1177 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.621 ns | 0.0632 ns | 0.0560 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.029 ns | 0.0712 ns | 0.0666 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 14.297 ns | 0.0537 ns | 0.0502 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.431 ns | 0.0593 ns | 0.0555 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.328 ns | 0.0709 ns | 0.0664 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.823 ns | 0.0568 ns | 0.0531 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.331 ns | 0.0766 ns | 0.0717 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.991 ns | 0.0747 ns | 0.0699 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.010 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.202 ns | 0.0686 ns | 0.0642 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.352 ns | 0.1238 ns | 0.1158 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.343 ns | 0.1888 ns | 0.1766 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 42.680 ns | 0.3255 ns | 0.3044 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.930 ns | 0.0330 ns | 0.0292 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.353 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.160 ns | 0.0428 ns | 0.0379 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.853 ns | 0.1041 ns | 0.0974 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.006 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.526 ns | 0.0644 ns | 0.0571 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.249 ns | 0.2191 ns | 0.2049 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 16.345 ns | 0.1400 ns | 0.1309 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 38.015 ns | 0.2558 ns | 0.2393 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.575 ns | 0.0964 ns | 0.0902 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 40.558 ns | 0.3037 ns | 0.2841 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.033 ns | 0.0570 ns | 0.0506 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Char.From_Bool_AsObject: DefaultJob
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Double_AsObject: DefaultJob
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Float_AsObject: DefaultJob
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_String_Empty_AsObject: DefaultJob
