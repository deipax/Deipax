
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 12.165 ns | 0.0555 ns | 0.0492 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.795 ns | 0.1195 ns | 0.1118 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.776 ns | 0.0786 ns | 0.0735 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 15.831 ns | 0.1455 ns | 0.1361 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.379 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.504 ns | 0.0439 ns | 0.0410 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.389 ns | 0.0834 ns | 0.0780 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.517 ns | 0.0606 ns | 0.0537 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.772 ns | 0.0461 ns | 0.0409 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 15.642 ns | 0.1145 ns | 0.1071 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.789 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.492 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                                             From_Char | 10.265 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.286 ns | 0.1819 ns | 0.1701 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.506 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.510 ns | 0.0628 ns | 0.0587 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.196 ns | 0.0435 ns | 0.0407 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.505 ns | 0.0443 ns | 0.0414 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.569 ns | 0.1014 ns | 0.0948 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.422 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
                                          From_Decimal | 10.814 ns | 0.0467 ns | 0.0414 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 12.500 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 11.572 ns | 0.0385 ns | 0.0321 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 12.622 ns | 0.0715 ns | 0.0668 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.963 ns | 0.0482 ns | 0.0427 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.515 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
                                           From_Double | 58.156 ns | 0.1826 ns | 0.1619 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 65.560 ns | 0.4316 ns | 0.4038 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 57.670 ns | 0.1731 ns | 0.1619 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 64.725 ns | 0.3433 ns | 0.3044 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.476 ns | 0.0592 ns | 0.0524 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.706 ns | 0.0618 ns | 0.0578 ns |           - |           - |           - |                   - |
                                            From_Short | 10.365 ns | 0.0308 ns | 0.0273 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.532 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.187 ns | 0.2370 ns | 0.2434 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.947 ns | 0.0742 ns | 0.0694 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.356 ns | 0.0547 ns | 0.0511 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.921 ns | 0.0845 ns | 0.0791 ns |           - |           - |           - |                   - |
                                              From_Int | 10.453 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 15.518 ns | 0.1264 ns | 0.1056 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.756 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 15.500 ns | 0.0932 ns | 0.0872 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.393 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.576 ns | 0.0566 ns | 0.0473 ns |           - |           - |           - |                   - |
                                             From_Long | 10.976 ns | 0.0517 ns | 0.0459 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 15.790 ns | 0.0927 ns | 0.0867 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.750 ns | 0.0500 ns | 0.0417 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 15.741 ns | 0.0832 ns | 0.0779 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.473 ns | 0.0537 ns | 0.0502 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.450 ns | 0.0396 ns | 0.0371 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.365 ns | 0.0576 ns | 0.0539 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.663 ns | 0.1087 ns | 0.1017 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.740 ns | 0.0627 ns | 0.0586 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.728 ns | 0.0819 ns | 0.0766 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.348 ns | 0.0367 ns | 0.0343 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 13.157 ns | 0.0714 ns | 0.0668 ns |           - |           - |           - |                   - |
                                            From_Float | 28.618 ns | 0.2547 ns | 0.2382 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 36.608 ns | 0.3901 ns | 0.3649 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 27.912 ns | 0.1370 ns | 0.1282 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 36.289 ns | 0.2732 ns | 0.2422 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.493 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.434 ns | 0.0715 ns | 0.0669 ns |           - |           - |           - |                   - |
                                           From_String | 72.134 ns | 0.3494 ns | 0.3268 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 79.766 ns | 0.3567 ns | 0.3336 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.267 ns | 0.0474 ns | 0.0420 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.429 ns | 0.0568 ns | 0.0532 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.855 ns | 0.0832 ns | 0.0737 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.051 ns | 0.0633 ns | 0.0561 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.532 ns | 0.0994 ns | 0.0930 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 12.127 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.571 ns | 0.0844 ns | 0.0790 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.358 ns | 0.0779 ns | 0.0728 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.564 ns | 0.0599 ns | 0.0560 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.948 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.275 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.790 ns | 0.0516 ns | 0.0483 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.508 ns | 0.0418 ns | 0.0391 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.329 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.507 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.925 ns | 0.0513 ns | 0.0479 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 16.229 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 11.572 ns | 0.0564 ns | 0.0528 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 15.361 ns | 0.0655 ns | 0.0580 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.481 ns | 0.0832 ns | 0.0779 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.403 ns | 0.0485 ns | 0.0430 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.476 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.488 ns | 0.0504 ns | 0.0472 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.555 ns | 0.0516 ns | 0.0457 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.880 ns | 0.0606 ns | 0.0537 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 15.373 ns | 0.1474 ns | 0.1379 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.064 ns | 0.0553 ns | 0.0517 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.460 ns | 0.0829 ns | 0.0776 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.728 ns | 0.0369 ns | 0.0327 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.883 ns | 0.0727 ns | 0.0680 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.658 ns | 0.0521 ns | 0.0462 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.426 ns | 0.0523 ns | 0.0489 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.798 ns | 0.1254 ns | 0.1111 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 16.375 ns | 0.0962 ns | 0.0853 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 16.821 ns | 0.1192 ns | 0.1115 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 15.129 ns | 0.1433 ns | 0.1341 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.575 ns | 0.0839 ns | 0.0785 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.670 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 10.058 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.373 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 10.015 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.501 ns | 0.0562 ns | 0.0525 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.990 ns | 0.0371 ns | 0.0310 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 13.281 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                                             From_Enum | 10.331 ns | 0.0614 ns | 0.0544 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.066 ns | 0.2106 ns | 0.1970 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 10.255 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 38.250 ns | 0.2077 ns | 0.1841 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.347 ns | 0.0838 ns | 0.0784 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 13.233 ns | 0.0512 ns | 0.0479 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.656 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.009 ns | 0.1000 ns | 0.0936 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.709 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.387 ns | 0.0408 ns | 0.0382 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 40.913 ns | 0.1923 ns | 0.1799 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.631 ns | 0.0580 ns | 0.0542 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 41.895 ns | 0.2701 ns | 0.2527 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.814 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 34.558 ns | 0.1095 ns | 0.1024 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.501 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_String_Empty_AsObject: DefaultJob
