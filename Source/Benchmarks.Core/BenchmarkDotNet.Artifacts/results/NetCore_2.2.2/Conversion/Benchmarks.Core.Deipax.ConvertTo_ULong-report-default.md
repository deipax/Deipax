
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.130 ns | 0.0648 ns | 0.0606 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 14.413 ns | 0.0597 ns | 0.0559 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  9.926 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 14.381 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.695 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.169 ns | 0.0478 ns | 0.0424 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.564 ns | 0.0306 ns | 0.0286 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 14.393 ns | 0.0880 ns | 0.0823 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.183 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.288 ns | 0.0656 ns | 0.0582 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.687 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.443 ns | 0.0292 ns | 0.0259 ns |           - |           - |           - |                   - |
                                             From_Char |  9.550 ns | 0.0378 ns | 0.0335 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 15.121 ns | 0.0910 ns | 0.0851 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  9.764 ns | 0.0296 ns | 0.0262 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 15.102 ns | 0.0916 ns | 0.0857 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.662 ns | 0.0331 ns | 0.0293 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.281 ns | 0.0632 ns | 0.0592 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.339 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 10.570 ns | 0.0590 ns | 0.0523 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.526 ns | 0.0282 ns | 0.0250 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.134 ns | 0.0549 ns | 0.0487 ns |           - |           - |           - |                   - |
                                          From_Decimal | 18.825 ns | 0.1673 ns | 0.1565 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 24.934 ns | 0.2290 ns | 0.2142 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 19.987 ns | 0.1406 ns | 0.1315 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 23.769 ns | 0.4311 ns | 0.4033 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.674 ns | 0.0521 ns | 0.0488 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.220 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
                                           From_Double | 10.923 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 16.566 ns | 0.0785 ns | 0.0656 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.398 ns | 0.0463 ns | 0.0387 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.391 ns | 0.0779 ns | 0.0728 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 10.685 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.205 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
                                            From_Short |  9.762 ns | 0.0294 ns | 0.0261 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 14.582 ns | 0.0613 ns | 0.0574 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.795 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 14.682 ns | 0.0879 ns | 0.0822 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.672 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.199 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
                                              From_Int |  9.796 ns | 0.0431 ns | 0.0403 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 14.348 ns | 0.0516 ns | 0.0483 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.405 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 14.644 ns | 0.0681 ns | 0.0637 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.127 ns | 0.0383 ns | 0.0359 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.195 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
                                             From_Long | 10.232 ns | 0.0827 ns | 0.0774 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 14.381 ns | 0.0458 ns | 0.0428 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.324 ns | 0.0822 ns | 0.0769 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 14.431 ns | 0.0651 ns | 0.0609 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 10.665 ns | 0.0435 ns | 0.0385 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.207 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                                            From_SByte |  9.787 ns | 0.0503 ns | 0.0470 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 14.590 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.380 ns | 0.0365 ns | 0.0342 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.529 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.161 ns | 0.0620 ns | 0.0580 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.195 ns | 0.0513 ns | 0.0480 ns |           - |           - |           - |                   - |
                                            From_Float | 10.882 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 16.754 ns | 0.0600 ns | 0.0532 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.319 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 16.719 ns | 0.0869 ns | 0.0813 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.658 ns | 0.0346 ns | 0.0324 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.951 ns | 0.0662 ns | 0.0620 ns |           - |           - |           - |                   - |
                                           From_String | 49.120 ns | 0.2127 ns | 0.1989 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 55.135 ns | 0.2186 ns | 0.2045 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.512 ns | 0.0738 ns | 0.0690 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.222 ns | 0.0762 ns | 0.0713 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.426 ns | 0.0688 ns | 0.0643 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  9.583 ns | 0.0524 ns | 0.0490 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 14.265 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  9.810 ns | 0.0363 ns | 0.0339 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.155 ns | 0.0614 ns | 0.0574 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.787 ns | 0.0641 ns | 0.0568 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.283 ns | 0.0804 ns | 0.0752 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.886 ns | 0.0410 ns | 0.0363 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 14.405 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.214 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 14.150 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.195 ns | 0.0896 ns | 0.0838 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.153 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.976 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 11.768 ns | 0.0400 ns | 0.0374 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 10.648 ns | 0.0439 ns | 0.0411 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 11.775 ns | 0.0423 ns | 0.0396 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 10.694 ns | 0.1354 ns | 0.1266 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.515 ns | 0.0648 ns | 0.0606 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.336 ns | 0.0571 ns | 0.0534 ns |           - |           - |           - |                   - |
                                           From_DBNull |  8.556 ns | 0.0846 ns | 0.0792 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.153 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 11.909 ns | 0.0638 ns | 0.0565 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.243 ns | 0.0914 ns | 0.0855 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.679 ns | 0.0538 ns | 0.0449 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.571 ns | 0.0569 ns | 0.0533 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  9.736 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 12.526 ns | 0.0633 ns | 0.0528 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.143 ns | 0.1071 ns | 0.1002 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.285 ns | 0.0435 ns | 0.0363 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 14.647 ns | 0.0571 ns | 0.0534 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 13.999 ns | 0.0750 ns | 0.0701 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.677 ns | 0.0464 ns | 0.0434 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 15.019 ns | 0.0552 ns | 0.0517 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.439 ns | 0.0501 ns | 0.0469 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.159 ns | 0.0635 ns | 0.0594 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.622 ns | 0.0437 ns | 0.0409 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 12.547 ns | 0.0448 ns | 0.0420 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.612 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 12.537 ns | 0.0381 ns | 0.0357 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.608 ns | 0.0570 ns | 0.0533 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.146 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.208 ns | 0.0608 ns | 0.0569 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 36.658 ns | 0.1985 ns | 0.1857 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  9.896 ns | 0.0646 ns | 0.0605 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 36.871 ns | 0.1358 ns | 0.1204 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.689 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.729 ns | 0.0611 ns | 0.0571 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  9.760 ns | 0.0416 ns | 0.0389 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 12.873 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.243 ns | 0.0772 ns | 0.0722 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.231 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 34.146 ns | 0.1822 ns | 0.1704 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 12.797 ns | 0.0847 ns | 0.0751 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.159 ns | 0.1569 ns | 0.1468 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 14.374 ns | 0.0359 ns | 0.0336 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 35.787 ns | 0.1411 ns | 0.1251 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.194 ns | 0.0366 ns | 0.0325 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULong.From_String_Empty_AsObject: DefaultJob
