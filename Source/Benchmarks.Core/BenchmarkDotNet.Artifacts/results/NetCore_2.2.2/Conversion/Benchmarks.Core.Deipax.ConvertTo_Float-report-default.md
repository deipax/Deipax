
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.439 ns | 0.0539 ns | 0.0478 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 14.999 ns | 0.0710 ns | 0.0664 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.101 ns | 0.0437 ns | 0.0388 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 14.899 ns | 0.0876 ns | 0.0820 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.900 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.465 ns | 0.1040 ns | 0.0973 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.765 ns | 0.0711 ns | 0.0631 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 14.915 ns | 0.0580 ns | 0.0542 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  9.963 ns | 0.0865 ns | 0.0809 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.603 ns | 0.0781 ns | 0.0731 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.180 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.390 ns | 0.0755 ns | 0.0706 ns |           - |           - |           - |                   - |
                                             From_Char | 10.418 ns | 0.0520 ns | 0.0487 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  9.743 ns | 0.0439 ns | 0.0411 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.026 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.317 ns | 0.0225 ns | 0.0199 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.003 ns | 0.0535 ns | 0.0501 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.514 ns | 0.0598 ns | 0.0530 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.902 ns | 0.0463 ns | 0.0433 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.355 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.104 ns | 0.1603 ns | 0.1500 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 24.159 ns | 0.4989 ns | 0.4667 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 20.992 ns | 0.1107 ns | 0.0982 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 21.424 ns | 0.2290 ns | 0.2142 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.760 ns | 0.0534 ns | 0.0500 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.396 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
                                           From_Double | 10.345 ns | 0.0430 ns | 0.0381 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 14.632 ns | 0.1195 ns | 0.1118 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.751 ns | 0.0379 ns | 0.0336 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 14.403 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.017 ns | 0.0638 ns | 0.0597 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.420 ns | 0.0405 ns | 0.0338 ns |           - |           - |           - |                   - |
                                            From_Short | 10.345 ns | 0.0454 ns | 0.0402 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 14.648 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.005 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 14.590 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  9.885 ns | 0.0673 ns | 0.0629 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.345 ns | 0.0372 ns | 0.0348 ns |           - |           - |           - |                   - |
                                              From_Int |  9.757 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 14.511 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  9.905 ns | 0.0303 ns | 0.0283 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 14.668 ns | 0.0649 ns | 0.0575 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  9.842 ns | 0.0304 ns | 0.0285 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.513 ns | 0.0328 ns | 0.0307 ns |           - |           - |           - |                   - |
                                             From_Long |  9.796 ns | 0.0446 ns | 0.0417 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 14.640 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.035 ns | 0.0596 ns | 0.0558 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 14.656 ns | 0.0518 ns | 0.0484 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.030 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.368 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.353 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 14.911 ns | 0.0494 ns | 0.0438 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  9.946 ns | 0.0615 ns | 0.0546 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.609 ns | 0.0400 ns | 0.0374 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  9.820 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.434 ns | 0.0519 ns | 0.0486 ns |           - |           - |           - |                   - |
                                            From_Float |  9.731 ns | 0.0301 ns | 0.0251 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 11.879 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 10.025 ns | 0.0867 ns | 0.0811 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 11.868 ns | 0.0644 ns | 0.0602 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.854 ns | 0.0413 ns | 0.0366 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.225 ns | 0.0902 ns | 0.0843 ns |           - |           - |           - |                   - |
                                           From_String | 69.074 ns | 0.4009 ns | 0.3750 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 75.957 ns | 0.4564 ns | 0.4269 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.527 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.417 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 11.528 ns | 0.0342 ns | 0.0320 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  9.780 ns | 0.0509 ns | 0.0477 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 14.382 ns | 0.0560 ns | 0.0524 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  9.954 ns | 0.0660 ns | 0.0585 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.402 ns | 0.0273 ns | 0.0255 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.858 ns | 0.0727 ns | 0.0680 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.427 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.364 ns | 0.0820 ns | 0.0767 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 14.820 ns | 0.0699 ns | 0.0654 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  9.990 ns | 0.0742 ns | 0.0694 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 14.574 ns | 0.0278 ns | 0.0246 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.859 ns | 0.0589 ns | 0.0522 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.393 ns | 0.0686 ns | 0.0642 ns |           - |           - |           - |                   - |
                                            From_ULong |  9.874 ns | 0.0377 ns | 0.0334 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.159 ns | 0.0815 ns | 0.0763 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.785 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.320 ns | 0.0471 ns | 0.0393 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.033 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.419 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.381 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.343 ns | 0.0620 ns | 0.0518 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.379 ns | 0.0503 ns | 0.0470 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 12.867 ns | 0.0454 ns | 0.0402 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.024 ns | 0.0654 ns | 0.0580 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.275 ns | 0.0550 ns | 0.0514 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.402 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  9.870 ns | 0.0368 ns | 0.0326 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 12.643 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.560 ns | 0.0392 ns | 0.0366 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.378 ns | 0.0504 ns | 0.0472 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 14.607 ns | 0.0807 ns | 0.0755 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.609 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.013 ns | 0.1567 ns | 0.1465 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.648 ns | 0.0436 ns | 0.0387 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.764 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.387 ns | 0.0253 ns | 0.0211 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.789 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 12.578 ns | 0.0319 ns | 0.0266 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.811 ns | 0.0622 ns | 0.0582 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 12.716 ns | 0.0810 ns | 0.0758 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.471 ns | 0.0501 ns | 0.0468 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.422 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.343 ns | 0.0359 ns | 0.0336 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 39.632 ns | 0.1975 ns | 0.1848 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.559 ns | 0.0268 ns | 0.0251 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 39.791 ns | 0.2765 ns | 0.2586 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.873 ns | 0.0500 ns | 0.0468 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.353 ns | 0.0705 ns | 0.0660 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  9.910 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.220 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.532 ns | 0.0687 ns | 0.0643 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.719 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 34.509 ns | 0.1670 ns | 0.1562 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 12.869 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.293 ns | 0.1377 ns | 0.1288 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.951 ns | 0.0426 ns | 0.0378 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 33.832 ns | 0.1589 ns | 0.1486 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.393 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Float.From_Char_AsObject: DefaultJob
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_String_Empty_AsObject: DefaultJob
