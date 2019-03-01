
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 18.362 ns | 0.1370 ns | 0.1281 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 23.699 ns | 0.1185 ns | 0.1109 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 17.052 ns | 0.0984 ns | 0.0920 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 23.558 ns | 0.1286 ns | 0.1203 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.445 ns | 0.0694 ns | 0.0650 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.263 ns | 0.0791 ns | 0.0740 ns |           - |           - |           - |                   - |
                                             From_Byte | 16.785 ns | 0.0837 ns | 0.0742 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 23.819 ns | 0.1919 ns | 0.1701 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 17.176 ns | 0.1133 ns | 0.1060 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 23.386 ns | 0.1338 ns | 0.1186 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.376 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.348 ns | 0.0711 ns | 0.0665 ns |           - |           - |           - |                   - |
                                             From_Char | 10.815 ns | 0.0483 ns | 0.0428 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.893 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 11.218 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.331 ns | 0.0699 ns | 0.0654 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.198 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.266 ns | 0.0408 ns | 0.0362 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.277 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 13.534 ns | 0.0682 ns | 0.0638 ns |           - |           - |           - |                   - |
                                          From_Decimal | 12.230 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 28.422 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 11.311 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.974 ns | 0.0487 ns | 0.0455 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.834 ns | 0.0343 ns | 0.0304 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.264 ns | 0.0424 ns | 0.0397 ns |           - |           - |           - |                   - |
                                           From_Double | 61.880 ns | 0.3169 ns | 0.2964 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 72.067 ns | 0.2475 ns | 0.2315 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 62.759 ns | 0.4355 ns | 0.4074 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 71.793 ns | 0.3616 ns | 0.3206 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.392 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.175 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                                            From_Short | 17.350 ns | 0.0897 ns | 0.0839 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 23.743 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 16.991 ns | 0.1042 ns | 0.0974 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 23.657 ns | 0.0924 ns | 0.0865 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.097 ns | 0.0438 ns | 0.0410 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.170 ns | 0.0441 ns | 0.0413 ns |           - |           - |           - |                   - |
                                              From_Int | 16.924 ns | 0.0683 ns | 0.0639 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 23.351 ns | 0.0955 ns | 0.0893 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 17.120 ns | 0.1022 ns | 0.0956 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 23.635 ns | 0.1217 ns | 0.1138 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.550 ns | 0.0535 ns | 0.0500 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.197 ns | 0.0422 ns | 0.0374 ns |           - |           - |           - |                   - |
                                             From_Long | 17.170 ns | 0.0707 ns | 0.0661 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 23.573 ns | 0.0670 ns | 0.0627 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 17.915 ns | 0.0971 ns | 0.0908 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 23.811 ns | 0.1837 ns | 0.1718 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.936 ns | 0.0718 ns | 0.0672 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.955 ns | 0.0645 ns | 0.0604 ns |           - |           - |           - |                   - |
                                            From_SByte | 16.905 ns | 0.0573 ns | 0.0508 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 23.383 ns | 0.1830 ns | 0.1622 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 17.146 ns | 0.1035 ns | 0.0968 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 23.453 ns | 0.1507 ns | 0.1410 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.946 ns | 0.0553 ns | 0.0490 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.250 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                                            From_Float | 32.920 ns | 0.1811 ns | 0.1694 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 42.884 ns | 0.4360 ns | 0.4078 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 32.837 ns | 0.2031 ns | 0.1900 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 43.840 ns | 0.2070 ns | 0.1835 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.508 ns | 0.1016 ns | 0.0901 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.726 ns | 0.0757 ns | 0.0671 ns |           - |           - |           - |                   - |
                                           From_String | 72.200 ns | 0.3106 ns | 0.2905 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 80.555 ns | 0.4645 ns | 0.4345 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.909 ns | 0.0939 ns | 0.0878 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.125 ns | 0.0353 ns | 0.0330 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.966 ns | 0.0615 ns | 0.0575 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 16.811 ns | 0.0692 ns | 0.0613 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 23.675 ns | 0.1244 ns | 0.1163 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 17.100 ns | 0.0872 ns | 0.0816 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 23.245 ns | 0.0674 ns | 0.0597 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.485 ns | 0.0579 ns | 0.0541 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 15.088 ns | 0.0453 ns | 0.0401 ns |           - |           - |           - |                   - |
                                             From_UInt | 16.828 ns | 0.0839 ns | 0.0744 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 23.415 ns | 0.0730 ns | 0.0647 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 16.910 ns | 0.1028 ns | 0.0961 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 23.260 ns | 0.0411 ns | 0.0343 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.456 ns | 0.0366 ns | 0.0343 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.198 ns | 0.0905 ns | 0.0802 ns |           - |           - |           - |                   - |
                                            From_ULong | 16.798 ns | 0.0775 ns | 0.0725 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 23.405 ns | 0.0861 ns | 0.0806 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 17.498 ns | 0.0668 ns | 0.0558 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 23.347 ns | 0.1113 ns | 0.0987 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.382 ns | 0.0504 ns | 0.0447 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.842 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.019 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.407 ns | 0.0714 ns | 0.0668 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.228 ns | 0.0752 ns | 0.0703 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 16.613 ns | 0.1110 ns | 0.1038 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 18.863 ns | 0.1057 ns | 0.0988 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.094 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.271 ns | 0.0346 ns | 0.0324 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.569 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.560 ns | 0.0452 ns | 0.0401 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.602 ns | 0.0524 ns | 0.0490 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.742 ns | 0.0838 ns | 0.0743 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 17.434 ns | 0.1125 ns | 0.1052 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 19.213 ns | 0.0991 ns | 0.0774 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.715 ns | 0.1555 ns | 0.1454 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 19.323 ns | 0.1796 ns | 0.1680 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.501 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.230 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.283 ns | 0.0712 ns | 0.0666 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.490 ns | 0.0420 ns | 0.0393 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.987 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.686 ns | 0.0675 ns | 0.0631 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.442 ns | 0.0459 ns | 0.0429 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.241 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                                             From_Enum | 17.150 ns | 0.1157 ns | 0.1082 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 46.453 ns | 0.2104 ns | 0.1969 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 16.988 ns | 0.1181 ns | 0.1105 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 44.634 ns | 0.1784 ns | 0.1668 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.069 ns | 0.0606 ns | 0.0537 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.274 ns | 0.0609 ns | 0.0569 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.570 ns | 0.0423 ns | 0.0375 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.853 ns | 0.0327 ns | 0.0290 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.596 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.220 ns | 0.0381 ns | 0.0357 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.345 ns | 0.1860 ns | 0.1740 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.965 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.599 ns | 0.2307 ns | 0.2046 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.965 ns | 0.0679 ns | 0.0635 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 34.841 ns | 0.1783 ns | 0.1668 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.343 ns | 0.1104 ns | 0.1032 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: DefaultJob
