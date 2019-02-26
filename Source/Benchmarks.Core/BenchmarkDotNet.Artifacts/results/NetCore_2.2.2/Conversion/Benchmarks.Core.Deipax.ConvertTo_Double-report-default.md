
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  11.483 ns | 0.0647 ns | 0.0574 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |  14.849 ns | 0.0717 ns | 0.0635 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  10.712 ns | 0.0355 ns | 0.0297 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |  14.911 ns | 0.0688 ns | 0.0644 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  10.346 ns | 0.0435 ns | 0.0385 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  11.445 ns | 0.0778 ns | 0.0728 ns |           - |           - |           - |                   - |
                                             From_Byte |  10.329 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |  14.628 ns | 0.0774 ns | 0.0724 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  10.514 ns | 0.0524 ns | 0.0464 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |  14.482 ns | 0.0668 ns | 0.0625 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  10.344 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  11.400 ns | 0.0706 ns | 0.0660 ns |           - |           - |           - |                   - |
                                             From_Char |  10.609 ns | 0.0937 ns | 0.0731 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  10.611 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  10.573 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  11.473 ns | 0.0607 ns | 0.0567 ns |           - |           - |           - |                   - |
                                         From_DateTime |  11.526 ns | 0.0661 ns | 0.0618 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  12.004 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  12.146 ns | 0.0654 ns | 0.0612 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  12.330 ns | 0.0568 ns | 0.0532 ns |           - |           - |           - |                   - |
                                          From_Decimal |  17.702 ns | 0.2473 ns | 0.2313 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |  20.510 ns | 0.2730 ns | 0.2420 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  19.496 ns | 0.1312 ns | 0.1227 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |  19.519 ns | 0.2604 ns | 0.2436 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  11.325 ns | 0.0341 ns | 0.0303 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  11.460 ns | 0.0642 ns | 0.0601 ns |           - |           - |           - |                   - |
                                           From_Double |   9.772 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |  12.736 ns | 0.0546 ns | 0.0510 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  11.050 ns | 0.0792 ns | 0.0702 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |  11.936 ns | 0.0601 ns | 0.0562 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  11.067 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  11.469 ns | 0.0671 ns | 0.0628 ns |           - |           - |           - |                   - |
                                            From_Short |  10.339 ns | 0.0395 ns | 0.0369 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |  15.182 ns | 0.0590 ns | 0.0523 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  10.539 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |  14.593 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  13.131 ns | 0.0673 ns | 0.0629 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  11.497 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                                              From_Int |  10.677 ns | 0.1313 ns | 0.1228 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |  15.262 ns | 0.0423 ns | 0.0395 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  10.489 ns | 0.0582 ns | 0.0545 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |  15.192 ns | 0.0705 ns | 0.0660 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  10.414 ns | 0.0325 ns | 0.0288 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  12.451 ns | 0.0471 ns | 0.0441 ns |           - |           - |           - |                   - |
                                             From_Long |  10.500 ns | 0.0235 ns | 0.0208 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |  14.678 ns | 0.0392 ns | 0.0347 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  11.781 ns | 0.0378 ns | 0.0354 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |  14.627 ns | 0.0593 ns | 0.0555 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  11.702 ns | 0.0829 ns | 0.0776 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  11.401 ns | 0.0362 ns | 0.0339 ns |           - |           - |           - |                   - |
                                            From_SByte |  10.339 ns | 0.0416 ns | 0.0389 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |  14.934 ns | 0.0805 ns | 0.0753 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  10.501 ns | 0.0519 ns | 0.0485 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |  14.577 ns | 0.0410 ns | 0.0384 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  10.388 ns | 0.0296 ns | 0.0263 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  11.425 ns | 0.0646 ns | 0.0572 ns |           - |           - |           - |                   - |
                                            From_Float |  10.329 ns | 0.0508 ns | 0.0476 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |  14.682 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |  10.496 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |  14.598 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  11.103 ns | 0.0549 ns | 0.0513 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  11.407 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
                                           From_String | 111.309 ns | 0.2787 ns | 0.2607 ns |           - |           - |           - |                   - |
                                  From_String_AsObject |  77.243 ns | 0.5144 ns | 0.4812 ns |           - |           - |           - |                   - |
                                      From_String_Null |  11.704 ns | 0.0583 ns | 0.0517 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  11.395 ns | 0.0610 ns | 0.0570 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  12.395 ns | 0.0546 ns | 0.0510 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  10.305 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |  14.766 ns | 0.0845 ns | 0.0790 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  10.520 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |  14.573 ns | 0.0377 ns | 0.0334 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  10.463 ns | 0.1035 ns | 0.0968 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  11.403 ns | 0.0365 ns | 0.0342 ns |           - |           - |           - |                   - |
                                             From_UInt |  10.358 ns | 0.0499 ns | 0.0467 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |  15.042 ns | 0.1172 ns | 0.0978 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  10.464 ns | 0.0579 ns | 0.0513 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |  14.673 ns | 0.0412 ns | 0.0365 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  10.458 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  11.381 ns | 0.0523 ns | 0.0489 ns |           - |           - |           - |                   - |
                                            From_ULong |  10.451 ns | 0.0412 ns | 0.0365 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |  15.230 ns | 0.1268 ns | 0.1186 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  11.798 ns | 0.0363 ns | 0.0340 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |  15.102 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  11.632 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  11.802 ns | 0.0829 ns | 0.0776 ns |           - |           - |           - |                   - |
                                       From_NullObject |  11.322 ns | 0.0394 ns | 0.0329 ns |           - |           - |           - |                   - |
                                           From_DBNull |   9.883 ns | 0.0425 ns | 0.0397 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  11.430 ns | 0.0950 ns | 0.0888 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  12.901 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  14.033 ns | 0.0413 ns | 0.0386 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  11.240 ns | 0.0438 ns | 0.0410 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  11.353 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  11.072 ns | 0.0751 ns | 0.0703 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  12.673 ns | 0.0925 ns | 0.0866 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |   9.911 ns | 0.0454 ns | 0.0424 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  11.544 ns | 0.0577 ns | 0.0540 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  14.556 ns | 0.0524 ns | 0.0491 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  14.633 ns | 0.0734 ns | 0.0686 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  16.685 ns | 0.0963 ns | 0.0901 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  14.656 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.301 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  11.429 ns | 0.0621 ns | 0.0581 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |   9.778 ns | 0.0513 ns | 0.0479 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  12.596 ns | 0.0454 ns | 0.0403 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |   9.782 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  12.664 ns | 0.0363 ns | 0.0340 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |   9.769 ns | 0.0397 ns | 0.0352 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  11.459 ns | 0.0753 ns | 0.0705 ns |           - |           - |           - |                   - |
                                             From_Enum |  10.356 ns | 0.0449 ns | 0.0420 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |  39.903 ns | 0.1733 ns | 0.1536 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  10.001 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |  36.993 ns | 0.2090 ns | 0.1955 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |   9.824 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  11.417 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                                      From_ParentClass |   9.921 ns | 0.0616 ns | 0.0546 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  12.913 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  10.137 ns | 0.0324 ns | 0.0270 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  11.352 ns | 0.0386 ns | 0.0361 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  36.676 ns | 0.1387 ns | 0.1083 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  12.947 ns | 0.0699 ns | 0.0653 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  35.434 ns | 0.1909 ns | 0.1785 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  12.944 ns | 0.0601 ns | 0.0562 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.017 ns | 0.2387 ns | 0.2233 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  12.361 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Double.From_Char_AsObject: DefaultJob
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_String_Empty_AsObject: DefaultJob
