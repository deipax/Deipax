
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  12.617 ns | 0.0448 ns | 0.0397 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |   9.640 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |   9.673 ns | 0.0508 ns | 0.0475 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  11.655 ns | 0.0593 ns | 0.0495 ns |           - |           - |           - |                   - |
                                             From_Byte |   9.371 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |   9.661 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  10.370 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  11.643 ns | 0.0465 ns | 0.0412 ns |           - |           - |           - |                   - |
                                             From_Char |   9.398 ns | 0.0597 ns | 0.0558 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |   9.486 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |   9.528 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  11.646 ns | 0.0551 ns | 0.0515 ns |           - |           - |           - |                   - |
                                         From_DateTime |  10.246 ns | 0.0431 ns | 0.0403 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |  12.152 ns | 0.0489 ns | 0.0458 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  10.856 ns | 0.0361 ns | 0.0337 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |  11.766 ns | 0.0631 ns | 0.0591 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  10.747 ns | 0.0380 ns | 0.0336 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  11.656 ns | 0.0609 ns | 0.0569 ns |           - |           - |           - |                   - |
                                          From_Decimal |  10.623 ns | 0.0794 ns | 0.0743 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  10.598 ns | 0.0411 ns | 0.0384 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  12.402 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  11.700 ns | 0.0554 ns | 0.0518 ns |           - |           - |           - |                   - |
                                           From_Double |   9.735 ns | 0.0781 ns | 0.0731 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  10.539 ns | 0.0449 ns | 0.0420 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  10.529 ns | 0.0620 ns | 0.0580 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  11.671 ns | 0.0388 ns | 0.0344 ns |           - |           - |           - |                   - |
                                            From_Short |   9.432 ns | 0.0584 ns | 0.0546 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |   9.541 ns | 0.0465 ns | 0.0412 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |   9.486 ns | 0.0537 ns | 0.0502 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  12.014 ns | 0.0349 ns | 0.0292 ns |           - |           - |           - |                   - |
                                              From_Int |   9.566 ns | 0.0666 ns | 0.0590 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |   9.620 ns | 0.0459 ns | 0.0430 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |   9.580 ns | 0.0844 ns | 0.0748 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  11.697 ns | 0.0755 ns | 0.0706 ns |           - |           - |           - |                   - |
                                             From_Long |   9.943 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  10.533 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  10.523 ns | 0.0654 ns | 0.0580 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  12.449 ns | 0.0393 ns | 0.0349 ns |           - |           - |           - |                   - |
                                            From_SByte |   9.423 ns | 0.0549 ns | 0.0514 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |   9.637 ns | 0.0550 ns | 0.0515 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |   9.619 ns | 0.0587 ns | 0.0549 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  11.692 ns | 0.0408 ns | 0.0382 ns |           - |           - |           - |                   - |
                                            From_Float |   9.738 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |   9.625 ns | 0.0528 ns | 0.0468 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |   9.567 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  11.684 ns | 0.0546 ns | 0.0484 ns |           - |           - |           - |                   - |
                                           From_String | 416.628 ns | 2.4382 ns | 2.2807 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 425.205 ns | 2.3886 ns | 2.2343 ns |           - |           - |           - |                   - |
                                      From_String_Null |  11.403 ns | 0.0484 ns | 0.0429 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  11.713 ns | 0.0623 ns | 0.0552 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  11.472 ns | 0.0746 ns | 0.0661 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |   9.406 ns | 0.0474 ns | 0.0444 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |   9.548 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |   9.502 ns | 0.0501 ns | 0.0469 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  12.584 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                                             From_UInt |  10.541 ns | 0.0482 ns | 0.0403 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |   9.604 ns | 0.0534 ns | 0.0500 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |   9.589 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  11.698 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
                                            From_ULong |   9.419 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  10.589 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  10.570 ns | 0.0572 ns | 0.0507 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  11.663 ns | 0.0348 ns | 0.0290 ns |           - |           - |           - |                   - |
                                       From_NullObject |  11.681 ns | 0.0398 ns | 0.0372 ns |           - |           - |           - |                   - |
                                           From_DBNull |   9.052 ns | 0.0524 ns | 0.0490 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  11.663 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  12.874 ns | 0.0560 ns | 0.0496 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  13.594 ns | 0.0456 ns | 0.0427 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  12.567 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  12.416 ns | 0.0688 ns | 0.0643 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  10.873 ns | 0.0395 ns | 0.0350 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  13.016 ns | 0.0361 ns | 0.0320 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  10.195 ns | 0.0232 ns | 0.0206 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  11.737 ns | 0.0966 ns | 0.0856 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  14.957 ns | 0.0613 ns | 0.0544 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  14.070 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  16.043 ns | 0.0923 ns | 0.0863 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  13.933 ns | 0.0385 ns | 0.0360 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.272 ns | 0.0567 ns | 0.0531 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.739 ns | 0.0380 ns | 0.0355 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |   9.582 ns | 0.0407 ns | 0.0381 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  13.371 ns | 0.0610 ns | 0.0570 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |   9.654 ns | 0.0415 ns | 0.0368 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  12.814 ns | 0.0491 ns | 0.0460 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |   9.675 ns | 0.0549 ns | 0.0514 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  11.773 ns | 0.0396 ns | 0.0371 ns |           - |           - |           - |                   - |
                                             From_Enum |   9.492 ns | 0.0492 ns | 0.0461 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue |   9.596 ns | 0.0530 ns | 0.0496 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |   9.652 ns | 0.0413 ns | 0.0387 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  11.682 ns | 0.0708 ns | 0.0662 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  10.076 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  13.160 ns | 0.0476 ns | 0.0446 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  10.901 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  11.650 ns | 0.0621 ns | 0.0580 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  35.313 ns | 0.2308 ns | 0.2159 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  13.229 ns | 0.0707 ns | 0.0662 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  39.823 ns | 0.1400 ns | 0.1241 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  13.758 ns | 0.0705 ns | 0.0659 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.009 ns | 0.1552 ns | 0.1451 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  12.337 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool_AsObject: DefaultJob
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_String_Empty_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: DefaultJob
