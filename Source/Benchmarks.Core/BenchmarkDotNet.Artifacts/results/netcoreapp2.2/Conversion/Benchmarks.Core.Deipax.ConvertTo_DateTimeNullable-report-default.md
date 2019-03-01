
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  11.251 ns | 0.0380 ns | 0.0337 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |   9.950 ns | 0.0563 ns | 0.0499 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |   9.982 ns | 0.0819 ns | 0.0766 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  12.221 ns | 0.0556 ns | 0.0493 ns |           - |           - |           - |                   - |
                                             From_Byte |   9.913 ns | 0.0363 ns | 0.0303 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |   9.977 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  12.726 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  12.347 ns | 0.0427 ns | 0.0378 ns |           - |           - |           - |                   - |
                                             From_Char |   9.901 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |   9.930 ns | 0.0765 ns | 0.0678 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |   9.952 ns | 0.0589 ns | 0.0551 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  13.505 ns | 0.0550 ns | 0.0515 ns |           - |           - |           - |                   - |
                                         From_DateTime |  11.097 ns | 0.0459 ns | 0.0429 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |  25.729 ns | 0.1252 ns | 0.1171 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  10.713 ns | 0.0581 ns | 0.0544 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |  24.863 ns | 0.1302 ns | 0.1217 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  11.638 ns | 0.0427 ns | 0.0400 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  12.778 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
                                          From_Decimal |  10.813 ns | 0.0429 ns | 0.0402 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  11.059 ns | 0.0483 ns | 0.0451 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  11.886 ns | 0.0335 ns | 0.0313 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  12.276 ns | 0.0505 ns | 0.0473 ns |           - |           - |           - |                   - |
                                           From_Double |   9.950 ns | 0.0595 ns | 0.0556 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  10.770 ns | 0.0551 ns | 0.0516 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  10.795 ns | 0.0743 ns | 0.0659 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  13.526 ns | 0.0629 ns | 0.0589 ns |           - |           - |           - |                   - |
                                            From_Short |   9.900 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |   9.909 ns | 0.0568 ns | 0.0504 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |   9.917 ns | 0.0691 ns | 0.0613 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  12.313 ns | 0.0706 ns | 0.0660 ns |           - |           - |           - |                   - |
                                              From_Int |  10.116 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |   9.934 ns | 0.0549 ns | 0.0514 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |   9.989 ns | 0.1269 ns | 0.1125 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  13.004 ns | 0.0566 ns | 0.0530 ns |           - |           - |           - |                   - |
                                             From_Long |  10.137 ns | 0.0759 ns | 0.0710 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  10.814 ns | 0.0724 ns | 0.0642 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  10.767 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  13.066 ns | 0.0804 ns | 0.0752 ns |           - |           - |           - |                   - |
                                            From_SByte |   9.917 ns | 0.0528 ns | 0.0441 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |   9.951 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |   9.913 ns | 0.0503 ns | 0.0471 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  13.716 ns | 0.0669 ns | 0.0593 ns |           - |           - |           - |                   - |
                                            From_Float |   9.957 ns | 0.0411 ns | 0.0365 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |   9.950 ns | 0.0710 ns | 0.0664 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |   9.889 ns | 0.0668 ns | 0.0624 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  13.790 ns | 0.0471 ns | 0.0418 ns |           - |           - |           - |                   - |
                                           From_String | 422.632 ns | 3.5269 ns | 3.2991 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 427.582 ns | 2.3386 ns | 2.1875 ns |           - |           - |           - |                   - |
                                      From_String_Null |  12.988 ns | 0.0448 ns | 0.0397 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  12.764 ns | 0.0409 ns | 0.0382 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  14.313 ns | 0.0496 ns | 0.0464 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |   9.927 ns | 0.0810 ns | 0.0757 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |   9.935 ns | 0.0547 ns | 0.0512 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |   9.868 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  13.021 ns | 0.0452 ns | 0.0422 ns |           - |           - |           - |                   - |
                                             From_UInt |  10.100 ns | 0.0671 ns | 0.0627 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |   9.963 ns | 0.0567 ns | 0.0502 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |   9.856 ns | 0.0227 ns | 0.0189 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  12.423 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
                                            From_ULong |  10.114 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  10.811 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  10.827 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  13.053 ns | 0.0718 ns | 0.0672 ns |           - |           - |           - |                   - |
                                       From_NullObject |  12.228 ns | 0.0425 ns | 0.0397 ns |           - |           - |           - |                   - |
                                           From_DBNull |  13.422 ns | 0.0321 ns | 0.0285 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  12.273 ns | 0.0394 ns | 0.0349 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  16.393 ns | 0.0792 ns | 0.0741 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  18.198 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  12.879 ns | 0.0629 ns | 0.0588 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  12.321 ns | 0.0630 ns | 0.0590 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  11.515 ns | 0.0384 ns | 0.0359 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  13.880 ns | 0.0763 ns | 0.0714 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  11.618 ns | 0.0568 ns | 0.0532 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  12.750 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  16.844 ns | 0.1055 ns | 0.0987 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  18.686 ns | 0.0686 ns | 0.0642 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  17.178 ns | 0.0928 ns | 0.0868 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  18.847 ns | 0.0783 ns | 0.0732 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.556 ns | 0.0640 ns | 0.0568 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.265 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |   9.943 ns | 0.0573 ns | 0.0536 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  13.786 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  10.006 ns | 0.0535 ns | 0.0501 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  14.437 ns | 0.0487 ns | 0.0407 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  11.711 ns | 0.0402 ns | 0.0376 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  12.390 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                                             From_Enum |  10.162 ns | 0.0890 ns | 0.0832 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue |   9.964 ns | 0.1259 ns | 0.1178 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |  11.201 ns | 0.0624 ns | 0.0584 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  12.252 ns | 0.0500 ns | 0.0443 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  11.011 ns | 0.0462 ns | 0.0433 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  14.242 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  11.474 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  12.327 ns | 0.0555 ns | 0.0520 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  36.555 ns | 0.2314 ns | 0.2051 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  14.808 ns | 0.0662 ns | 0.0619 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  35.346 ns | 0.1850 ns | 0.1731 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  14.253 ns | 0.0885 ns | 0.0828 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.156 ns | 0.1333 ns | 0.1247 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  12.293 ns | 0.0550 ns | 0.0515 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
