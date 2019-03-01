
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 13.31 ns | 0.1185 ns | 0.1108 ns |      0.0038 |           - |           - |                24 B |
                                    From_Bool_AsObject | 10.91 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 13.60 ns | 0.1033 ns | 0.0966 ns |      0.0038 |           - |           - |                24 B |
                 From_Bool_Nullable_WithValue_AsObject | 10.80 ns | 0.0284 ns | 0.0237 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.11 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 10.80 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                                             From_Byte | 14.65 ns | 0.0602 ns | 0.0563 ns |      0.0038 |           - |           - |                24 B |
                                    From_Byte_AsObject | 10.87 ns | 0.0425 ns | 0.0376 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.55 ns | 0.0622 ns | 0.0582 ns |      0.0038 |           - |           - |                24 B |
                 From_Byte_Nullable_WithValue_AsObject | 10.75 ns | 0.0565 ns | 0.0529 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 11.14 ns | 0.0653 ns | 0.0611 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 10.71 ns | 0.0470 ns | 0.0439 ns |           - |           - |           - |                   - |
                                             From_Char | 13.23 ns | 0.0460 ns | 0.0430 ns |      0.0038 |           - |           - |                24 B |
                                    From_Char_AsObject | 10.85 ns | 0.0423 ns | 0.0375 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 15.06 ns | 0.0989 ns | 0.0925 ns |      0.0038 |           - |           - |                24 B |
                 From_Char_Nullable_WithValue_AsObject | 10.79 ns | 0.0446 ns | 0.0395 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.02 ns | 0.0601 ns | 0.0562 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 10.74 ns | 0.0706 ns | 0.0660 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.80 ns | 0.1150 ns | 0.1076 ns |      0.0038 |           - |           - |                24 B |
                                From_DateTime_AsObject | 11.46 ns | 0.0840 ns | 0.0786 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 14.46 ns | 0.0875 ns | 0.0819 ns |      0.0038 |           - |           - |                24 B |
             From_DateTime_Nullable_WithValue_AsObject | 10.83 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.77 ns | 0.0533 ns | 0.0473 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 10.84 ns | 0.0853 ns | 0.0798 ns |           - |           - |           - |                   - |
                                          From_Decimal | 14.11 ns | 0.0935 ns | 0.0828 ns |      0.0051 |           - |           - |                32 B |
                                 From_Decimal_AsObject | 10.75 ns | 0.0715 ns | 0.0669 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 14.81 ns | 0.0748 ns | 0.0664 ns |      0.0051 |           - |           - |                32 B |
              From_Decimal_Nullable_WithValue_AsObject | 10.83 ns | 0.0712 ns | 0.0666 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.60 ns | 0.0427 ns | 0.0379 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 10.89 ns | 0.0626 ns | 0.0585 ns |           - |           - |           - |                   - |
                                           From_Double | 13.33 ns | 0.0551 ns | 0.0516 ns |      0.0038 |           - |           - |                24 B |
                                  From_Double_AsObject | 10.82 ns | 0.0678 ns | 0.0634 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.73 ns | 0.0941 ns | 0.0881 ns |      0.0038 |           - |           - |                24 B |
               From_Double_Nullable_WithValue_AsObject | 10.92 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.35 ns | 0.0507 ns | 0.0475 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.22 ns | 0.0521 ns | 0.0435 ns |           - |           - |           - |                   - |
                                            From_Short | 13.59 ns | 0.0653 ns | 0.0610 ns |      0.0038 |           - |           - |                24 B |
                                   From_Short_AsObject | 11.27 ns | 0.0241 ns | 0.0201 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.52 ns | 0.0649 ns | 0.0576 ns |      0.0038 |           - |           - |                24 B |
                From_Short_Nullable_WithValue_AsObject | 10.91 ns | 0.0626 ns | 0.0585 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 11.06 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 10.94 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
                                              From_Int | 13.61 ns | 0.0623 ns | 0.0583 ns |      0.0038 |           - |           - |                24 B |
                                     From_Int_AsObject | 10.71 ns | 0.0628 ns | 0.0588 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 14.68 ns | 0.0688 ns | 0.0643 ns |      0.0038 |           - |           - |                24 B |
                  From_Int_Nullable_WithValue_AsObject | 10.81 ns | 0.0585 ns | 0.0547 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.04 ns | 0.0682 ns | 0.0638 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.38 ns | 0.0521 ns | 0.0487 ns |           - |           - |           - |                   - |
                                             From_Long | 13.42 ns | 0.0649 ns | 0.0607 ns |      0.0038 |           - |           - |                24 B |
                                    From_Long_AsObject | 10.72 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.59 ns | 0.0813 ns | 0.0760 ns |      0.0038 |           - |           - |                24 B |
                 From_Long_Nullable_WithValue_AsObject | 11.60 ns | 0.0618 ns | 0.0578 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.50 ns | 0.0651 ns | 0.0609 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 10.84 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
                                            From_SByte | 13.56 ns | 0.0496 ns | 0.0464 ns |      0.0038 |           - |           - |                24 B |
                                   From_SByte_AsObject | 10.96 ns | 0.0300 ns | 0.0280 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 14.63 ns | 0.0762 ns | 0.0713 ns |      0.0038 |           - |           - |                24 B |
                From_SByte_Nullable_WithValue_AsObject | 10.68 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.08 ns | 0.0713 ns | 0.0667 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 10.86 ns | 0.0763 ns | 0.0676 ns |           - |           - |           - |                   - |
                                            From_Float | 13.47 ns | 0.0528 ns | 0.0494 ns |      0.0038 |           - |           - |                24 B |
                                   From_Float_AsObject | 10.96 ns | 0.0718 ns | 0.0672 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.68 ns | 0.0828 ns | 0.0775 ns |      0.0038 |           - |           - |                24 B |
                From_Float_Nullable_WithValue_AsObject | 10.80 ns | 0.0750 ns | 0.0665 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.11 ns | 0.0567 ns | 0.0474 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 10.67 ns | 0.0471 ns | 0.0441 ns |           - |           - |           - |                   - |
                                           From_String | 10.84 ns | 0.0529 ns | 0.0495 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 10.74 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                                      From_String_Null | 10.82 ns | 0.0638 ns | 0.0597 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 10.82 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 11.46 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject | 10.78 ns | 0.0878 ns | 0.0821 ns |           - |           - |           - |                   - |
                                           From_UShort | 13.61 ns | 0.0774 ns | 0.0724 ns |      0.0038 |           - |           - |                24 B |
                                  From_UShort_AsObject | 10.74 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.41 ns | 0.0607 ns | 0.0568 ns |      0.0038 |           - |           - |                24 B |
               From_UShort_Nullable_WithValue_AsObject | 11.58 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.10 ns | 0.0848 ns | 0.0793 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 10.83 ns | 0.0891 ns | 0.0834 ns |           - |           - |           - |                   - |
                                             From_UInt | 13.24 ns | 0.0778 ns | 0.0728 ns |      0.0038 |           - |           - |                24 B |
                                    From_UInt_AsObject | 10.84 ns | 0.0471 ns | 0.0417 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.50 ns | 0.0975 ns | 0.0912 ns |      0.0038 |           - |           - |                24 B |
                 From_UInt_Nullable_WithValue_AsObject | 10.84 ns | 0.0290 ns | 0.0257 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.07 ns | 0.0605 ns | 0.0565 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 10.82 ns | 0.0634 ns | 0.0593 ns |           - |           - |           - |                   - |
                                            From_ULong | 14.33 ns | 0.0602 ns | 0.0563 ns |      0.0038 |           - |           - |                24 B |
                                   From_ULong_AsObject | 10.88 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 15.77 ns | 0.0997 ns | 0.0933 ns |      0.0038 |           - |           - |                24 B |
                From_ULong_Nullable_WithValue_AsObject | 10.83 ns | 0.0773 ns | 0.0723 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.50 ns | 0.0386 ns | 0.0361 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 10.72 ns | 0.0674 ns | 0.0630 ns |           - |           - |           - |                   - |
                                       From_NullObject | 10.75 ns | 0.0666 ns | 0.0591 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.80 ns | 0.0463 ns | 0.0410 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.64 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 10.84 ns | 0.0374 ns | 0.0332 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 10.90 ns | 0.0567 ns | 0.0531 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 10.82 ns | 0.0741 ns | 0.0657 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.10 ns | 0.0532 ns | 0.0498 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.78 ns | 0.0676 ns | 0.0632 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 10.74 ns | 0.0812 ns | 0.0759 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.75 ns | 0.0444 ns | 0.0394 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 10.69 ns | 0.0324 ns | 0.0303 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 13.08 ns | 0.0925 ns | 0.0865 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 10.84 ns | 0.0737 ns | 0.0690 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 13.63 ns | 0.0714 ns | 0.0668 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 10.87 ns | 0.0625 ns | 0.0584 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.12 ns | 0.0628 ns | 0.0588 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 10.68 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 14.35 ns | 0.0463 ns | 0.0433 ns |      0.0038 |           - |           - |                24 B |
                    From_NonConvertibleStruct_AsObject | 10.75 ns | 0.0447 ns | 0.0419 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.53 ns | 0.1099 ns | 0.1028 ns |      0.0038 |           - |           - |                24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 11.30 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.12 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 10.89 ns | 0.0366 ns | 0.0325 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.34 ns | 0.0764 ns | 0.0714 ns |      0.0038 |           - |           - |                24 B |
                                    From_Enum_AsObject | 11.55 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue | 13.53 ns | 0.0682 ns | 0.0638 ns |      0.0038 |           - |           - |                24 B |
                 From_Enum_Nullable_WithValue_AsObject | 10.76 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue | 11.09 ns | 0.0533 ns | 0.0499 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 10.74 ns | 0.0458 ns | 0.0428 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.87 ns | 0.0668 ns | 0.0624 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 10.98 ns | 0.0382 ns | 0.0358 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.39 ns | 0.0453 ns | 0.0379 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 10.71 ns | 0.0335 ns | 0.0280 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 70.37 ns | 0.2542 ns | 0.2378 ns |      0.0851 |           - |           - |               536 B |
                            From_ParentStruct_AsObject | 10.80 ns | 0.0544 ns | 0.0482 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 70.27 ns | 0.3413 ns | 0.3193 ns |      0.0851 |           - |           - |               536 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 11.71 ns | 0.0460 ns | 0.0430 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 38.76 ns | 0.1894 ns | 0.1679 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.00 ns | 0.0831 ns | 0.0777 ns |           - |           - |           - |                   - |
