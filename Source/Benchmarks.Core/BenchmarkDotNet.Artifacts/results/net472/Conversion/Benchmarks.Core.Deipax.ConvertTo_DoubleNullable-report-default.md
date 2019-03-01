
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.62 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 20.47 ns | 0.0580 ns | 0.0514 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 12.95 ns | 0.1119 ns | 0.1047 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 18.68 ns | 0.1002 ns | 0.0937 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.62 ns | 0.1072 ns | 0.1003 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 14.91 ns | 0.0457 ns | 0.0406 ns |           - |           - |           - |                   - |
                                             From_Byte | 13.32 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 20.28 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 12.83 ns | 0.0747 ns | 0.0699 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 18.48 ns | 0.0708 ns | 0.0662 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 14.13 ns | 0.0508 ns | 0.0450 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.71 ns | 0.0604 ns | 0.0535 ns |           - |           - |           - |                   - |
                                             From_Char | 12.97 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 13.17 ns | 0.0466 ns | 0.0436 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.65 ns | 0.0484 ns | 0.0453 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.49 ns | 0.0341 ns | 0.0319 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.49 ns | 0.0366 ns | 0.0343 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 13.34 ns | 0.0898 ns | 0.0796 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 13.17 ns | 0.0246 ns | 0.0192 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 14.28 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                                          From_Decimal | 18.85 ns | 0.0782 ns | 0.0732 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.44 ns | 0.0939 ns | 0.0832 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 20.97 ns | 0.0794 ns | 0.0743 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 23.89 ns | 0.1319 ns | 0.1234 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.97 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 15.73 ns | 0.0886 ns | 0.0829 ns |           - |           - |           - |                   - |
                                           From_Double | 12.21 ns | 0.0573 ns | 0.0508 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 31.83 ns | 0.2179 ns | 0.2038 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.79 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 31.93 ns | 0.2024 ns | 0.1894 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.32 ns | 0.0999 ns | 0.0934 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 15.37 ns | 0.0559 ns | 0.0467 ns |           - |           - |           - |                   - |
                                            From_Short | 12.64 ns | 0.0898 ns | 0.0840 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 20.51 ns | 0.0755 ns | 0.0706 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.15 ns | 0.0940 ns | 0.0879 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 21.17 ns | 0.0965 ns | 0.0902 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.37 ns | 0.0454 ns | 0.0424 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 14.97 ns | 0.0779 ns | 0.0728 ns |           - |           - |           - |                   - |
                                              From_Int | 12.77 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 20.32 ns | 0.0828 ns | 0.0734 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.18 ns | 0.0876 ns | 0.0819 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 20.52 ns | 0.0505 ns | 0.0422 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.71 ns | 0.0455 ns | 0.0425 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 15.77 ns | 0.0804 ns | 0.0753 ns |           - |           - |           - |                   - |
                                             From_Long | 13.40 ns | 0.0503 ns | 0.0471 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.65 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 14.00 ns | 0.0915 ns | 0.0856 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 20.59 ns | 0.0703 ns | 0.0657 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 13.34 ns | 0.0308 ns | 0.0257 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.55 ns | 0.0468 ns | 0.0437 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.56 ns | 0.0572 ns | 0.0535 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 21.26 ns | 0.0989 ns | 0.0877 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 12.88 ns | 0.0943 ns | 0.0882 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 21.27 ns | 0.0867 ns | 0.0811 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.62 ns | 0.0672 ns | 0.0628 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 13.54 ns | 0.0470 ns | 0.0440 ns |           - |           - |           - |                   - |
                                            From_Float | 14.24 ns | 0.0361 ns | 0.0320 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 20.60 ns | 0.0738 ns | 0.0690 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 14.99 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 20.43 ns | 0.0963 ns | 0.0901 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 14.34 ns | 0.0467 ns | 0.0437 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 15.93 ns | 0.0677 ns | 0.0633 ns |           - |           - |           - |                   - |
                                           From_String | 71.05 ns | 0.2178 ns | 0.2038 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 76.98 ns | 0.4467 ns | 0.3960 ns |           - |           - |           - |                   - |
                                      From_String_Null | 14.52 ns | 0.0342 ns | 0.0320 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 15.76 ns | 0.0805 ns | 0.0714 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.25 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.56 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 18.50 ns | 0.1232 ns | 0.1153 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.11 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 20.31 ns | 0.0875 ns | 0.0819 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.72 ns | 0.0606 ns | 0.0567 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.53 ns | 0.0737 ns | 0.0690 ns |           - |           - |           - |                   - |
                                             From_UInt | 12.98 ns | 0.0318 ns | 0.0298 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 20.57 ns | 0.0771 ns | 0.0721 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.80 ns | 0.0580 ns | 0.0514 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 18.55 ns | 0.0864 ns | 0.0808 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 13.37 ns | 0.0798 ns | 0.0746 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 17.50 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.98 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 20.88 ns | 0.1123 ns | 0.1051 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.87 ns | 0.1113 ns | 0.1041 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 20.55 ns | 0.0919 ns | 0.0859 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.36 ns | 0.0568 ns | 0.0531 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 15.76 ns | 0.0726 ns | 0.0680 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.76 ns | 0.0537 ns | 0.0503 ns |           - |           - |           - |                   - |
                                           From_DBNull | 13.40 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 14.78 ns | 0.0798 ns | 0.0707 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 16.52 ns | 0.0868 ns | 0.0812 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 19.93 ns | 0.0714 ns | 0.0633 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.50 ns | 0.0323 ns | 0.0302 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.55 ns | 0.0277 ns | 0.0216 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.77 ns | 0.0451 ns | 0.0399 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 19.33 ns | 0.1014 ns | 0.0949 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 13.05 ns | 0.0672 ns | 0.0596 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 14.74 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 19.92 ns | 0.0801 ns | 0.0749 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.56 ns | 0.0744 ns | 0.0696 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 19.41 ns | 0.0654 ns | 0.0612 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 19.58 ns | 0.0845 ns | 0.0791 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.80 ns | 0.0321 ns | 0.0268 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 15.59 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.75 ns | 0.0361 ns | 0.0320 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 17.50 ns | 0.0750 ns | 0.0702 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.08 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 15.09 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.68 ns | 0.0432 ns | 0.0404 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.08 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.19 ns | 0.1123 ns | 0.1050 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 48.89 ns | 0.2403 ns | 0.2247 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.97 ns | 0.0370 ns | 0.0346 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 44.13 ns | 0.2470 ns | 0.2311 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 12.63 ns | 0.0515 ns | 0.0481 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.47 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.63 ns | 0.0540 ns | 0.0505 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 16.45 ns | 0.0885 ns | 0.0828 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 14.01 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.48 ns | 0.0399 ns | 0.0373 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.28 ns | 0.2452 ns | 0.2294 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 16.05 ns | 0.0434 ns | 0.0384 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.77 ns | 0.1763 ns | 0.1649 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 17.77 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.28 ns | 0.1650 ns | 0.1543 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.47 ns | 0.0626 ns | 0.0585 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: DefaultJob
