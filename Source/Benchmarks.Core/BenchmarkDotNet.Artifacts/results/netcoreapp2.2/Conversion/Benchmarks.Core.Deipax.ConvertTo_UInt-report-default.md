
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 11.171 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 14.611 ns | 0.0550 ns | 0.0514 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.663 ns | 0.0324 ns | 0.0304 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 14.497 ns | 0.0365 ns | 0.0324 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.843 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.303 ns | 0.0330 ns | 0.0308 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.702 ns | 0.0411 ns | 0.0385 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 14.562 ns | 0.0350 ns | 0.0327 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  9.933 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.298 ns | 0.0752 ns | 0.0703 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.582 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.283 ns | 0.0438 ns | 0.0388 ns |           - |           - |           - |                   - |
                                             From_Char | 10.726 ns | 0.0523 ns | 0.0463 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 15.322 ns | 0.0743 ns | 0.0695 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  9.890 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 15.170 ns | 0.0940 ns | 0.0880 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.814 ns | 0.1474 ns | 0.1379 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.172 ns | 0.0471 ns | 0.0417 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.932 ns | 0.0536 ns | 0.0502 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 10.603 ns | 0.0635 ns | 0.0594 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.539 ns | 0.0335 ns | 0.0313 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.172 ns | 0.0529 ns | 0.0469 ns |           - |           - |           - |                   - |
                                          From_Decimal | 20.631 ns | 0.1106 ns | 0.1035 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 29.196 ns | 0.0688 ns | 0.0644 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.705 ns | 0.1210 ns | 0.1132 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.059 ns | 0.2306 ns | 0.2157 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.681 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.138 ns | 0.0849 ns | 0.0794 ns |           - |           - |           - |                   - |
                                           From_Double | 10.445 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 15.525 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 11.984 ns | 0.0613 ns | 0.0574 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 15.593 ns | 0.1403 ns | 0.1312 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 10.658 ns | 0.0353 ns | 0.0313 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.893 ns | 0.0807 ns | 0.0755 ns |           - |           - |           - |                   - |
                                            From_Short | 10.231 ns | 0.0717 ns | 0.0671 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 14.615 ns | 0.0848 ns | 0.0793 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.302 ns | 0.0370 ns | 0.0328 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 14.664 ns | 0.0934 ns | 0.0828 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.661 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.181 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
                                              From_Int | 11.114 ns | 0.0333 ns | 0.0311 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 14.385 ns | 0.0627 ns | 0.0586 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.351 ns | 0.0581 ns | 0.0543 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 14.619 ns | 0.0747 ns | 0.0698 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.011 ns | 0.0976 ns | 0.0913 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.161 ns | 0.0815 ns | 0.0762 ns |           - |           - |           - |                   - |
                                             From_Long |  9.982 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.571 ns | 0.0972 ns | 0.0909 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.654 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 14.977 ns | 0.0624 ns | 0.0584 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 10.685 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.150 ns | 0.0487 ns | 0.0456 ns |           - |           - |           - |                   - |
                                            From_SByte |  9.712 ns | 0.0319 ns | 0.0298 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 14.607 ns | 0.0623 ns | 0.0552 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  9.909 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.298 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.169 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.550 ns | 0.0606 ns | 0.0566 ns |           - |           - |           - |                   - |
                                            From_Float | 10.338 ns | 0.0491 ns | 0.0460 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 15.577 ns | 0.0634 ns | 0.0562 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.130 ns | 0.0792 ns | 0.0740 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 15.527 ns | 0.0939 ns | 0.0784 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.313 ns | 0.0628 ns | 0.0587 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.145 ns | 0.0373 ns | 0.0349 ns |           - |           - |           - |                   - |
                                           From_String | 47.438 ns | 0.3297 ns | 0.3084 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 89.636 ns | 1.0835 ns | 1.0135 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.606 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.353 ns | 0.0333 ns | 0.0311 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.138 ns | 0.0705 ns | 0.0660 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  9.559 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 14.135 ns | 0.0550 ns | 0.0514 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.218 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.896 ns | 0.0752 ns | 0.0703 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.682 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.130 ns | 0.0351 ns | 0.0328 ns |           - |           - |           - |                   - |
                                             From_UInt |  9.923 ns | 0.0356 ns | 0.0333 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 11.767 ns | 0.0756 ns | 0.0707 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.915 ns | 0.0540 ns | 0.0451 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 11.703 ns | 0.0543 ns | 0.0481 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.828 ns | 0.0452 ns | 0.0422 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.207 ns | 0.0683 ns | 0.0571 ns |           - |           - |           - |                   - |
                                            From_ULong |  9.751 ns | 0.0614 ns | 0.0575 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 14.693 ns | 0.0618 ns | 0.0578 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 10.799 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 14.610 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 10.680 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.336 ns | 0.0512 ns | 0.0479 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.296 ns | 0.0368 ns | 0.0345 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.208 ns | 0.0343 ns | 0.0321 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.286 ns | 0.0989 ns | 0.0925 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 12.031 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 13.364 ns | 0.0221 ns | 0.0184 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.162 ns | 0.0779 ns | 0.0729 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.160 ns | 0.0435 ns | 0.0407 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  9.675 ns | 0.0240 ns | 0.0224 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 12.367 ns | 0.0541 ns | 0.0507 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  9.728 ns | 0.0351 ns | 0.0274 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.474 ns | 0.0378 ns | 0.0354 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 14.890 ns | 0.0933 ns | 0.0873 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.808 ns | 0.0548 ns | 0.0486 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 14.519 ns | 0.0621 ns | 0.0581 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.972 ns | 0.0503 ns | 0.0471 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.114 ns | 0.0426 ns | 0.0399 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.144 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.619 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 12.647 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.602 ns | 0.0608 ns | 0.0568 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 12.492 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.618 ns | 0.0395 ns | 0.0369 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.069 ns | 0.0636 ns | 0.0564 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.174 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 40.350 ns | 0.1825 ns | 0.1707 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  9.862 ns | 0.0505 ns | 0.0473 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 37.873 ns | 0.1404 ns | 0.1314 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.667 ns | 0.0571 ns | 0.0534 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.131 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  9.775 ns | 0.0623 ns | 0.0553 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 12.746 ns | 0.0743 ns | 0.0695 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  9.882 ns | 0.0430 ns | 0.0402 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.218 ns | 0.0851 ns | 0.0796 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 33.976 ns | 0.2430 ns | 0.2154 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 12.734 ns | 0.0512 ns | 0.0454 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.957 ns | 0.0971 ns | 0.0861 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.034 ns | 0.0670 ns | 0.0594 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 33.948 ns | 0.3220 ns | 0.3012 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.180 ns | 0.0609 ns | 0.0569 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UInt.From_String_Empty_AsObject: DefaultJob
