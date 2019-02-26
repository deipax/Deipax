
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.135 ns | 0.0932 ns | 0.0872 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 14.383 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  9.865 ns | 0.0520 ns | 0.0486 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 14.373 ns | 0.0440 ns | 0.0367 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.780 ns | 0.1014 ns | 0.0898 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.186 ns | 0.0973 ns | 0.0862 ns |           - |           - |           - |                   - |
                                             From_Byte |  9.917 ns | 0.0434 ns | 0.0406 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 14.333 ns | 0.0492 ns | 0.0411 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.146 ns | 0.0657 ns | 0.0614 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 14.201 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.702 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.164 ns | 0.0735 ns | 0.0651 ns |           - |           - |           - |                   - |
                                             From_Char | 11.148 ns | 0.0475 ns | 0.0445 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 15.102 ns | 0.0610 ns | 0.0571 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.374 ns | 0.0536 ns | 0.0502 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 15.016 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.014 ns | 0.0339 ns | 0.0283 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.157 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.684 ns | 0.0329 ns | 0.0291 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 10.492 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.533 ns | 0.0673 ns | 0.0630 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.310 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.814 ns | 0.1168 ns | 0.1093 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 24.672 ns | 0.2751 ns | 0.2573 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 20.365 ns | 0.1615 ns | 0.1511 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.618 ns | 0.3304 ns | 0.3090 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.751 ns | 0.0652 ns | 0.0578 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.139 ns | 0.0819 ns | 0.0766 ns |           - |           - |           - |                   - |
                                           From_Double | 10.855 ns | 0.0583 ns | 0.0545 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 16.404 ns | 0.0750 ns | 0.0702 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.327 ns | 0.0787 ns | 0.0657 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.198 ns | 0.0699 ns | 0.0584 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.294 ns | 0.0698 ns | 0.0619 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 11.859 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                                            From_Short |  9.580 ns | 0.0483 ns | 0.0429 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 14.426 ns | 0.0716 ns | 0.0670 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  9.784 ns | 0.0629 ns | 0.0588 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 14.318 ns | 0.0445 ns | 0.0417 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.253 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.022 ns | 0.0388 ns | 0.0363 ns |           - |           - |           - |                   - |
                                              From_Int |  9.905 ns | 0.0424 ns | 0.0397 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 14.127 ns | 0.0625 ns | 0.0585 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.144 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 14.305 ns | 0.0249 ns | 0.0233 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.083 ns | 0.0826 ns | 0.0732 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 11.168 ns | 0.0986 ns | 0.0922 ns |           - |           - |           - |                   - |
                                             From_Long |  9.948 ns | 0.0364 ns | 0.0322 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 11.739 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.141 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 11.778 ns | 0.1676 ns | 0.1567 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.447 ns | 0.0656 ns | 0.0614 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 11.163 ns | 0.0570 ns | 0.0505 ns |           - |           - |           - |                   - |
                                            From_SByte |  9.573 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 14.328 ns | 0.0545 ns | 0.0483 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.166 ns | 0.0651 ns | 0.0577 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 14.103 ns | 0.0600 ns | 0.0562 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  9.716 ns | 0.0798 ns | 0.0746 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.065 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                                            From_Float | 10.769 ns | 0.0378 ns | 0.0353 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 16.595 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.008 ns | 0.0436 ns | 0.0386 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 16.569 ns | 0.0693 ns | 0.0648 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  9.668 ns | 0.0380 ns | 0.0356 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.539 ns | 0.0552 ns | 0.0489 ns |           - |           - |           - |                   - |
                                           From_String | 48.688 ns | 0.4395 ns | 0.4111 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 53.830 ns | 0.2028 ns | 0.1798 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.539 ns | 0.0329 ns | 0.0308 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 11.209 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.054 ns | 0.0503 ns | 0.0470 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  9.606 ns | 0.0670 ns | 0.0560 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.078 ns | 0.2854 ns | 0.3397 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.302 ns | 0.0788 ns | 0.0699 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 14.929 ns | 0.0557 ns | 0.0465 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  9.813 ns | 0.0484 ns | 0.0453 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.308 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
                                             From_UInt |  9.685 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 14.542 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.272 ns | 0.0502 ns | 0.0469 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 14.310 ns | 0.0625 ns | 0.0584 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  9.783 ns | 0.0281 ns | 0.0249 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.320 ns | 0.0406 ns | 0.0380 ns |           - |           - |           - |                   - |
                                            From_ULong |  9.852 ns | 0.0450 ns | 0.0399 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 14.904 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.322 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 14.774 ns | 0.0501 ns | 0.0444 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 10.737 ns | 0.0475 ns | 0.0444 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.419 ns | 0.0416 ns | 0.0389 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.193 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
                                           From_DBNull |  8.591 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.319 ns | 0.0556 ns | 0.0493 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 12.024 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 13.535 ns | 0.0513 ns | 0.0455 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.177 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.294 ns | 0.0369 ns | 0.0327 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  9.814 ns | 0.0554 ns | 0.0519 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 12.656 ns | 0.0565 ns | 0.0528 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  9.886 ns | 0.0385 ns | 0.0360 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.319 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 14.969 ns | 0.1756 ns | 0.1466 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.111 ns | 0.0329 ns | 0.0291 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 14.729 ns | 0.0688 ns | 0.0644 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.223 ns | 0.0745 ns | 0.0697 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.249 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.977 ns | 0.0392 ns | 0.0347 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.748 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 12.680 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.808 ns | 0.1615 ns | 0.1510 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 12.646 ns | 0.0478 ns | 0.0424 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.020 ns | 0.0562 ns | 0.0525 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.264 ns | 0.0389 ns | 0.0345 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.069 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 40.181 ns | 0.1644 ns | 0.1537 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  9.904 ns | 0.0458 ns | 0.0429 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 36.804 ns | 0.0979 ns | 0.0915 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.799 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.310 ns | 0.1660 ns | 0.1553 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  9.760 ns | 0.0440 ns | 0.0412 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 12.721 ns | 0.0527 ns | 0.0467 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  9.690 ns | 0.0474 ns | 0.0395 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.709 ns | 0.0847 ns | 0.0792 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 33.835 ns | 0.1433 ns | 0.1341 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 12.704 ns | 0.0705 ns | 0.0660 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 34.233 ns | 0.1662 ns | 0.1554 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 12.720 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 33.934 ns | 0.1426 ns | 0.1334 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 13.001 ns | 0.0454 ns | 0.0425 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Long.From_String_Empty_AsObject: DefaultJob
