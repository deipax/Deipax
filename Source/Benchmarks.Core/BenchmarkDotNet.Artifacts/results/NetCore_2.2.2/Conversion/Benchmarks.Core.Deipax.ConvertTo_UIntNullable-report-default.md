
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  9.793 ns | 0.0322 ns | 0.0285 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.337 ns | 0.0932 ns | 0.0872 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.025 ns | 0.0412 ns | 0.0365 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 16.314 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.676 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 14.014 ns | 0.0381 ns | 0.0338 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.772 ns | 0.0395 ns | 0.0370 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.110 ns | 0.0696 ns | 0.0651 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.042 ns | 0.0519 ns | 0.0485 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.182 ns | 0.1247 ns | 0.1166 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.702 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.189 ns | 0.0381 ns | 0.0318 ns |           - |           - |           - |                   - |
                                             From_Char |  9.807 ns | 0.0334 ns | 0.0296 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.740 ns | 0.0640 ns | 0.0598 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.000 ns | 0.0470 ns | 0.0439 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.743 ns | 0.1052 ns | 0.0984 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.630 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.185 ns | 0.0614 ns | 0.0574 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.573 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.162 ns | 0.0302 ns | 0.0282 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.515 ns | 0.0373 ns | 0.0349 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.178 ns | 0.0467 ns | 0.0436 ns |           - |           - |           - |                   - |
                                          From_Decimal | 20.114 ns | 0.0716 ns | 0.0670 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 27.399 ns | 0.1458 ns | 0.1363 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 22.042 ns | 0.0962 ns | 0.0853 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 27.416 ns | 0.2068 ns | 0.1935 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.760 ns | 0.0477 ns | 0.0447 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.204 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                                           From_Double | 11.577 ns | 0.1191 ns | 0.1114 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 17.619 ns | 0.0959 ns | 0.0897 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.154 ns | 0.0795 ns | 0.0744 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 17.664 ns | 0.0849 ns | 0.0794 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.040 ns | 0.0433 ns | 0.0405 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.197 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                            From_Short |  9.798 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.284 ns | 0.0568 ns | 0.0504 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.117 ns | 0.0690 ns | 0.0646 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.518 ns | 0.1559 ns | 0.1382 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.827 ns | 0.0286 ns | 0.0238 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.194 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                                              From_Int |  9.806 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 16.319 ns | 0.0840 ns | 0.0702 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.135 ns | 0.0817 ns | 0.0724 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.296 ns | 0.0769 ns | 0.0642 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  9.642 ns | 0.0672 ns | 0.0629 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.600 ns | 0.0461 ns | 0.0431 ns |           - |           - |           - |                   - |
                                             From_Long | 11.287 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 16.807 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.625 ns | 0.0514 ns | 0.0480 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.191 ns | 0.0591 ns | 0.0493 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 10.642 ns | 0.0733 ns | 0.0612 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.907 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                                            From_SByte |  9.799 ns | 0.0491 ns | 0.0460 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.400 ns | 0.0723 ns | 0.0641 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.455 ns | 0.0437 ns | 0.0409 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 19.230 ns | 0.0684 ns | 0.0606 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.121 ns | 0.0659 ns | 0.0617 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.238 ns | 0.0443 ns | 0.0393 ns |           - |           - |           - |                   - |
                                            From_Float | 11.554 ns | 0.0952 ns | 0.0891 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 17.618 ns | 0.0697 ns | 0.0618 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.726 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 17.645 ns | 0.0851 ns | 0.0796 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.815 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.165 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
                                           From_String | 52.653 ns | 0.2442 ns | 0.2284 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 56.327 ns | 0.2990 ns | 0.2797 ns |           - |           - |           - |                   - |
                                      From_String_Null | 17.177 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.357 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 17.567 ns | 0.1254 ns | 0.1111 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  9.805 ns | 0.0923 ns | 0.0863 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 16.084 ns | 0.0524 ns | 0.0490 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.500 ns | 0.0488 ns | 0.0433 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 16.132 ns | 0.1215 ns | 0.1077 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.706 ns | 0.0549 ns | 0.0487 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.210 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.641 ns | 0.0283 ns | 0.0251 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 23.716 ns | 0.0815 ns | 0.0763 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  9.596 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 23.740 ns | 0.1125 ns | 0.1052 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.585 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.504 ns | 0.0335 ns | 0.0297 ns |           - |           - |           - |                   - |
                                            From_ULong |  9.776 ns | 0.0434 ns | 0.0385 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 16.601 ns | 0.1099 ns | 0.1028 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.273 ns | 0.0242 ns | 0.0214 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.549 ns | 0.1744 ns | 0.1546 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.155 ns | 0.0702 ns | 0.0657 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.181 ns | 0.0409 ns | 0.0382 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.135 ns | 0.0384 ns | 0.0300 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.427 ns | 0.0372 ns | 0.0348 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.174 ns | 0.0412 ns | 0.0386 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.707 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.900 ns | 0.1127 ns | 0.1055 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.308 ns | 0.0741 ns | 0.0693 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.192 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.498 ns | 0.0303 ns | 0.0269 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.338 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 11.535 ns | 0.0519 ns | 0.0486 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.173 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.030 ns | 0.0897 ns | 0.0839 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.096 ns | 0.0590 ns | 0.0523 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.329 ns | 0.0993 ns | 0.0929 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.096 ns | 0.0822 ns | 0.0769 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.314 ns | 0.0471 ns | 0.0418 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.589 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.536 ns | 0.0567 ns | 0.0530 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 14.769 ns | 0.0478 ns | 0.0424 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.465 ns | 0.0489 ns | 0.0433 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.940 ns | 0.0483 ns | 0.0428 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.467 ns | 0.0424 ns | 0.0376 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.155 ns | 0.0423 ns | 0.0396 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.272 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 43.099 ns | 0.2159 ns | 0.2020 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 10.593 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 43.606 ns | 0.1865 ns | 0.1654 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.654 ns | 0.0448 ns | 0.0374 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.184 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.540 ns | 0.0386 ns | 0.0323 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.504 ns | 0.0636 ns | 0.0595 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.532 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.190 ns | 0.0329 ns | 0.0308 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 36.802 ns | 0.3115 ns | 0.2601 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 14.784 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.324 ns | 0.1570 ns | 0.1469 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 14.536 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.352 ns | 0.1620 ns | 0.1436 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.142 ns | 0.0291 ns | 0.0272 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_String_Empty_AsObject: DefaultJob
