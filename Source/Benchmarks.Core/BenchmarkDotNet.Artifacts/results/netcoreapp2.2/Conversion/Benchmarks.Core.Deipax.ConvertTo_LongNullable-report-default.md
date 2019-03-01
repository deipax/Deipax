
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.166 ns | 0.0413 ns | 0.0386 ns | 10.172 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.086 ns | 0.0620 ns | 0.0580 ns | 16.075 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.413 ns | 0.0859 ns | 0.0804 ns | 10.406 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 16.160 ns | 0.0856 ns | 0.0801 ns | 16.141 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.440 ns | 0.0729 ns | 0.0682 ns | 11.439 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.080 ns | 0.0690 ns | 0.0645 ns | 12.066 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.122 ns | 0.0660 ns | 0.0617 ns | 10.139 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.119 ns | 0.0883 ns | 0.0783 ns | 16.123 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.235 ns | 0.0859 ns | 0.0761 ns | 10.213 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 15.995 ns | 0.1206 ns | 0.1069 ns | 15.973 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.077 ns | 0.0879 ns | 0.0779 ns | 10.066 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.083 ns | 0.0393 ns | 0.0348 ns | 12.086 ns |           - |           - |           - |                   - |
                                             From_Char | 11.842 ns | 0.0727 ns | 0.0680 ns | 11.824 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.262 ns | 0.0800 ns | 0.0748 ns | 18.255 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.562 ns | 0.0424 ns | 0.0376 ns | 10.559 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.590 ns | 0.0754 ns | 0.0705 ns | 16.595 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.961 ns | 0.0665 ns | 0.0622 ns |  9.951 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.102 ns | 0.0444 ns | 0.0415 ns | 12.106 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.640 ns | 0.0501 ns | 0.0468 ns | 10.651 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 10.744 ns | 0.0682 ns | 0.0604 ns | 10.741 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.945 ns | 0.0425 ns | 0.0397 ns | 10.930 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.833 ns | 0.0539 ns | 0.0504 ns | 12.818 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.383 ns | 0.1449 ns | 0.1285 ns | 19.389 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 25.921 ns | 0.1477 ns | 0.1382 ns | 25.927 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 20.188 ns | 0.0838 ns | 0.0784 ns | 20.179 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 25.932 ns | 0.2849 ns | 0.2665 ns | 25.887 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.006 ns | 0.2384 ns | 0.2341 ns | 10.877 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.113 ns | 0.0782 ns | 0.0732 ns | 12.110 ns |           - |           - |           - |                   - |
                                           From_Double | 11.161 ns | 0.0629 ns | 0.0525 ns | 11.166 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.377 ns | 0.1743 ns | 0.1631 ns | 18.406 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.167 ns | 0.0589 ns | 0.0551 ns | 12.167 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.512 ns | 0.0733 ns | 0.0685 ns | 18.517 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 10.902 ns | 0.0518 ns | 0.0484 ns | 10.894 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.062 ns | 0.0260 ns | 0.0231 ns | 12.062 ns |           - |           - |           - |                   - |
                                            From_Short | 10.399 ns | 0.0608 ns | 0.0569 ns | 10.401 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.132 ns | 0.0850 ns | 0.0754 ns | 16.136 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.605 ns | 0.0627 ns | 0.0587 ns | 10.613 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.167 ns | 0.1054 ns | 0.0986 ns | 16.144 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.391 ns | 0.0564 ns | 0.0528 ns | 10.368 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.703 ns | 0.0453 ns | 0.0402 ns | 12.708 ns |           - |           - |           - |                   - |
                                              From_Int |  9.863 ns | 0.0378 ns | 0.0353 ns |  9.851 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.954 ns | 0.0756 ns | 0.0707 ns | 15.965 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.018 ns | 0.0218 ns | 0.0170 ns | 10.022 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.216 ns | 0.1069 ns | 0.1000 ns | 16.182 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.033 ns | 0.0506 ns | 0.0474 ns | 10.019 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.066 ns | 0.0273 ns | 0.0255 ns | 12.067 ns |           - |           - |           - |                   - |
                                             From_Long | 10.326 ns | 0.0525 ns | 0.0491 ns | 10.321 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 23.750 ns | 0.0721 ns | 0.0602 ns | 23.717 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.711 ns | 0.0448 ns | 0.0419 ns | 12.701 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 24.201 ns | 0.1486 ns | 0.1390 ns | 24.207 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 10.746 ns | 0.0567 ns | 0.0503 ns | 10.741 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.166 ns | 0.0709 ns | 0.0628 ns | 12.146 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.091 ns | 0.0514 ns | 0.0481 ns | 10.082 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.131 ns | 0.0699 ns | 0.0620 ns | 16.138 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.222 ns | 0.0634 ns | 0.0530 ns | 10.229 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.882 ns | 0.0569 ns | 0.0532 ns | 15.897 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.078 ns | 0.0636 ns | 0.0595 ns | 10.080 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.873 ns | 0.1091 ns | 0.1020 ns | 12.871 ns |           - |           - |           - |                   - |
                                            From_Float | 11.736 ns | 0.0390 ns | 0.0346 ns | 11.730 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 18.110 ns | 0.0825 ns | 0.0771 ns | 18.122 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.354 ns | 0.0435 ns | 0.0407 ns | 11.349 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 18.044 ns | 0.0887 ns | 0.0830 ns | 18.036 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.032 ns | 0.0685 ns | 0.0641 ns | 10.028 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.024 ns | 0.0721 ns | 0.0639 ns | 13.013 ns |           - |           - |           - |                   - |
                                           From_String | 81.992 ns | 1.1052 ns | 1.0338 ns | 81.784 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 55.683 ns | 0.2016 ns | 0.1885 ns | 55.620 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.232 ns | 0.2636 ns | 0.5265 ns | 12.920 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.073 ns | 0.0416 ns | 0.0369 ns | 13.062 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.315 ns | 0.0577 ns | 0.0512 ns | 12.317 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.072 ns | 0.0420 ns | 0.0393 ns | 10.075 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.269 ns | 0.0904 ns | 0.0846 ns | 16.233 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.107 ns | 0.0390 ns | 0.0364 ns | 10.101 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 16.386 ns | 0.0841 ns | 0.0787 ns | 16.360 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.289 ns | 0.0310 ns | 0.0290 ns | 12.282 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.106 ns | 0.0599 ns | 0.0560 ns | 12.123 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.508 ns | 0.0518 ns | 0.0484 ns | 11.514 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 16.855 ns | 0.1059 ns | 0.0991 ns | 16.832 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.225 ns | 0.0632 ns | 0.0591 ns | 11.221 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 16.752 ns | 0.1209 ns | 0.1130 ns | 16.727 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.948 ns | 0.0524 ns | 0.0464 ns |  9.964 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.109 ns | 0.0711 ns | 0.0665 ns | 12.107 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.070 ns | 0.0516 ns | 0.0457 ns | 10.072 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 16.621 ns | 0.0948 ns | 0.0840 ns | 16.603 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.080 ns | 0.0365 ns | 0.0342 ns | 11.076 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.351 ns | 0.1119 ns | 0.1047 ns | 16.313 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.321 ns | 0.0492 ns | 0.0460 ns | 11.311 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.075 ns | 0.0492 ns | 0.0436 ns | 12.081 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.053 ns | 0.0444 ns | 0.0415 ns | 12.042 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.078 ns | 0.0757 ns | 0.0708 ns |  9.070 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 15.057 ns | 0.0447 ns | 0.0373 ns | 15.071 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.090 ns | 0.0400 ns | 0.0354 ns | 13.087 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.911 ns | 0.0417 ns | 0.0370 ns | 14.917 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.884 ns | 0.0467 ns | 0.0390 ns | 11.889 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.042 ns | 0.0516 ns | 0.0483 ns | 12.037 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.299 ns | 0.0358 ns | 0.0299 ns | 10.290 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.331 ns | 0.0650 ns | 0.0608 ns | 13.326 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.312 ns | 0.0778 ns | 0.0727 ns | 10.293 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.065 ns | 0.0572 ns | 0.0507 ns | 12.054 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 14.809 ns | 0.0514 ns | 0.0480 ns | 14.806 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 15.342 ns | 0.0944 ns | 0.0883 ns | 15.340 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.118 ns | 0.0724 ns | 0.0677 ns | 15.106 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 15.419 ns | 0.1041 ns | 0.0974 ns | 15.417 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.290 ns | 0.0462 ns | 0.0410 ns | 11.286 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.045 ns | 0.0293 ns | 0.0274 ns | 12.039 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.880 ns | 0.0434 ns | 0.0406 ns |  9.887 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.816 ns | 0.0525 ns | 0.0491 ns | 13.808 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.799 ns | 0.0338 ns | 0.0300 ns |  9.795 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.971 ns | 0.0833 ns | 0.0779 ns | 13.961 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.903 ns | 0.0741 ns | 0.0693 ns | 10.894 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.069 ns | 0.0449 ns | 0.0420 ns | 12.065 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.341 ns | 0.0431 ns | 0.0382 ns | 10.352 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 45.073 ns | 0.2744 ns | 0.2567 ns | 45.005 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 10.076 ns | 0.0254 ns | 0.0225 ns | 10.074 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.916 ns | 0.3393 ns | 0.3173 ns | 41.760 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.040 ns | 0.0830 ns | 0.0776 ns | 10.027 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.053 ns | 0.0236 ns | 0.0184 ns | 12.052 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.469 ns | 0.1032 ns | 0.0965 ns | 10.476 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.748 ns | 0.0318 ns | 0.0282 ns | 13.745 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.037 ns | 0.0473 ns | 0.0443 ns | 11.032 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.239 ns | 0.0616 ns | 0.0546 ns | 13.226 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.931 ns | 0.1316 ns | 0.1167 ns | 36.940 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.667 ns | 0.0587 ns | 0.0550 ns | 13.661 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 34.304 ns | 0.1553 ns | 0.1377 ns | 34.321 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.844 ns | 0.0620 ns | 0.0580 ns | 13.842 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 34.228 ns | 0.1664 ns | 0.1557 ns | 34.207 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.089 ns | 0.0577 ns | 0.0540 ns | 12.078 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_LongNullable.From_String_Empty_AsObject: DefaultJob
