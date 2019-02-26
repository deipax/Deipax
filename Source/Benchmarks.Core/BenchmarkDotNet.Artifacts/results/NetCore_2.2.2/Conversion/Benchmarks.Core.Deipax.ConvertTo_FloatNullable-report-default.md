
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  11.353 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |  16.760 ns | 0.1439 ns | 0.1346 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  10.679 ns | 0.0249 ns | 0.0208 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |  16.634 ns | 0.0654 ns | 0.0580 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |   9.852 ns | 0.0651 ns | 0.0609 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  12.432 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
                                             From_Byte |   9.815 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |  16.685 ns | 0.1019 ns | 0.0953 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  10.267 ns | 0.0613 ns | 0.0544 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |  16.634 ns | 0.0644 ns | 0.0603 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |   9.878 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  12.435 ns | 0.0406 ns | 0.0360 ns |           - |           - |           - |                   - |
                                             From_Char |  10.060 ns | 0.0660 ns | 0.0617 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |   9.641 ns | 0.0554 ns | 0.0518 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |   9.641 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  12.471 ns | 0.0521 ns | 0.0435 ns |           - |           - |           - |                   - |
                                         From_DateTime |  10.990 ns | 0.0529 ns | 0.0469 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  11.229 ns | 0.0382 ns | 0.0339 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  10.753 ns | 0.0577 ns | 0.0539 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  12.450 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                                          From_Decimal |  18.804 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |  24.411 ns | 0.2337 ns | 0.2186 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  23.659 ns | 0.0931 ns | 0.0871 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |  23.838 ns | 0.2674 ns | 0.2501 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  11.896 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  12.421 ns | 0.0549 ns | 0.0458 ns |           - |           - |           - |                   - |
                                           From_Double |  11.099 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |  16.591 ns | 0.1478 ns | 0.1382 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  11.044 ns | 0.0580 ns | 0.0543 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |  16.392 ns | 0.0682 ns | 0.0638 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  10.713 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  12.773 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                                            From_Short |   9.869 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |  18.547 ns | 0.0828 ns | 0.0774 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  10.317 ns | 0.0678 ns | 0.0634 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |  16.668 ns | 0.1438 ns | 0.1345 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |   9.817 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  12.489 ns | 0.0518 ns | 0.0485 ns |           - |           - |           - |                   - |
                                              From_Int |   9.832 ns | 0.0278 ns | 0.0260 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |  16.597 ns | 0.1144 ns | 0.1070 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  10.289 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |  16.675 ns | 0.1199 ns | 0.1122 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |   9.888 ns | 0.0337 ns | 0.0315 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  12.496 ns | 0.0849 ns | 0.0795 ns |           - |           - |           - |                   - |
                                             From_Long |   9.853 ns | 0.0538 ns | 0.0504 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |  16.580 ns | 0.0900 ns | 0.0842 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  11.737 ns | 0.0636 ns | 0.0595 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |  16.623 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  11.288 ns | 0.0685 ns | 0.0641 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  12.759 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                                            From_SByte |  10.104 ns | 0.0458 ns | 0.0429 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |  16.635 ns | 0.1064 ns | 0.0995 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  10.271 ns | 0.0534 ns | 0.0499 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |  16.637 ns | 0.0844 ns | 0.0748 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  11.100 ns | 0.0509 ns | 0.0451 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  13.695 ns | 0.0770 ns | 0.0643 ns |           - |           - |           - |                   - |
                                            From_Float |  10.688 ns | 0.0812 ns | 0.0759 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |  23.704 ns | 0.1300 ns | 0.1153 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |   9.463 ns | 0.0891 ns | 0.0744 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |  23.553 ns | 0.0794 ns | 0.0743 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |   9.425 ns | 0.0316 ns | 0.0280 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  12.471 ns | 0.0646 ns | 0.0604 ns |           - |           - |           - |                   - |
                                           From_String |  75.332 ns | 0.5250 ns | 0.4911 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 102.391 ns | 0.3989 ns | 0.3731 ns |           - |           - |           - |                   - |
                                      From_String_Null |  17.807 ns | 0.0681 ns | 0.0637 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  12.483 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  18.266 ns | 0.1469 ns | 0.1374 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |   9.858 ns | 0.0582 ns | 0.0545 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |  16.599 ns | 0.0763 ns | 0.0713 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  10.973 ns | 0.0460 ns | 0.0408 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |  16.683 ns | 0.0955 ns | 0.0893 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  10.255 ns | 0.0660 ns | 0.0617 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  12.467 ns | 0.0692 ns | 0.0647 ns |           - |           - |           - |                   - |
                                             From_UInt |  10.117 ns | 0.2161 ns | 0.2021 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |  16.713 ns | 0.0923 ns | 0.0864 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  10.271 ns | 0.0710 ns | 0.0593 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |  16.660 ns | 0.0823 ns | 0.0687 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |   9.868 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  12.435 ns | 0.0323 ns | 0.0302 ns |           - |           - |           - |                   - |
                                            From_ULong |  10.729 ns | 0.0435 ns | 0.0385 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |  16.600 ns | 0.0993 ns | 0.0929 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  12.365 ns | 0.0723 ns | 0.0677 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |  16.652 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  11.242 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  12.451 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                                       From_NullObject |  13.471 ns | 0.0464 ns | 0.0412 ns |           - |           - |           - |                   - |
                                           From_DBNull |  10.655 ns | 0.0620 ns | 0.0580 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  12.469 ns | 0.0394 ns | 0.0369 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  14.195 ns | 0.0532 ns | 0.0471 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  16.534 ns | 0.1242 ns | 0.1162 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  12.585 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  12.635 ns | 0.0553 ns | 0.0517 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  12.149 ns | 0.0520 ns | 0.0487 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  14.185 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  11.765 ns | 0.0467 ns | 0.0414 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  12.489 ns | 0.0626 ns | 0.0586 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  15.403 ns | 0.1304 ns | 0.1220 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  16.625 ns | 0.0958 ns | 0.0896 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  15.956 ns | 0.1076 ns | 0.1006 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  16.616 ns | 0.0841 ns | 0.0786 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.348 ns | 0.0441 ns | 0.0413 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.461 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |   9.648 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  14.204 ns | 0.0628 ns | 0.0588 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |   9.631 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  14.488 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |   9.584 ns | 0.0488 ns | 0.0433 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  12.453 ns | 0.0331 ns | 0.0276 ns |           - |           - |           - |                   - |
                                             From_Enum |  10.242 ns | 0.0455 ns | 0.0425 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |  42.284 ns | 0.1780 ns | 0.1578 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  10.361 ns | 0.0516 ns | 0.0483 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |  42.592 ns | 0.2283 ns | 0.2136 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  10.425 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  12.468 ns | 0.0220 ns | 0.0184 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  11.801 ns | 0.0514 ns | 0.0481 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  14.622 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  11.843 ns | 0.0708 ns | 0.0663 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  12.533 ns | 0.1147 ns | 0.1073 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  41.982 ns | 0.1483 ns | 0.1238 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  14.663 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  39.147 ns | 0.1859 ns | 0.1739 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  14.647 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.946 ns | 0.1541 ns | 0.1287 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  12.867 ns | 0.0830 ns | 0.0776 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_String_Empty_AsObject: DefaultJob
