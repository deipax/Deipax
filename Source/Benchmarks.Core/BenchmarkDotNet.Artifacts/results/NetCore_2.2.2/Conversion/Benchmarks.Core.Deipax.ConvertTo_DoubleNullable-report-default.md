
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  11.623 ns | 0.0642 ns | 0.0600 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |  16.895 ns | 0.0581 ns | 0.0544 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  10.705 ns | 0.0551 ns | 0.0516 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |  16.786 ns | 0.0738 ns | 0.0616 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  10.414 ns | 0.0406 ns | 0.0339 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  13.330 ns | 0.0323 ns | 0.0302 ns |           - |           - |           - |                   - |
                                             From_Byte |  10.243 ns | 0.0621 ns | 0.0581 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |  16.438 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  10.697 ns | 0.0483 ns | 0.0452 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |  16.594 ns | 0.0929 ns | 0.0824 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  10.369 ns | 0.0652 ns | 0.0610 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  12.298 ns | 0.0360 ns | 0.0319 ns |           - |           - |           - |                   - |
                                             From_Char |  10.254 ns | 0.0673 ns | 0.0630 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  10.755 ns | 0.0394 ns | 0.0329 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  10.271 ns | 0.0422 ns | 0.0395 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  12.232 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                         From_DateTime |  12.454 ns | 0.0899 ns | 0.0841 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  11.345 ns | 0.0903 ns | 0.0845 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  11.369 ns | 0.0516 ns | 0.0482 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  13.391 ns | 0.0668 ns | 0.0625 ns |           - |           - |           - |                   - |
                                          From_Decimal |  16.661 ns | 0.1781 ns | 0.1666 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |  21.944 ns | 0.4277 ns | 0.4392 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  19.844 ns | 0.0649 ns | 0.0542 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |  22.595 ns | 0.3232 ns | 0.3023 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  12.096 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  12.259 ns | 0.0553 ns | 0.0517 ns |           - |           - |           - |                   - |
                                           From_Double |  10.609 ns | 0.0673 ns | 0.0629 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |  24.507 ns | 0.0542 ns | 0.0507 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  10.737 ns | 0.0245 ns | 0.0191 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |  24.624 ns | 0.1233 ns | 0.1153 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  10.779 ns | 0.0503 ns | 0.0470 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  12.240 ns | 0.0693 ns | 0.0648 ns |           - |           - |           - |                   - |
                                            From_Short |  10.832 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |  16.399 ns | 0.0709 ns | 0.0629 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  10.637 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |  18.658 ns | 0.0990 ns | 0.0926 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  11.197 ns | 0.0610 ns | 0.0570 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  12.328 ns | 0.0414 ns | 0.0367 ns |           - |           - |           - |                   - |
                                              From_Int |  10.250 ns | 0.0631 ns | 0.0560 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |  16.622 ns | 0.0949 ns | 0.0887 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  11.074 ns | 0.0467 ns | 0.0414 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |  16.463 ns | 0.1139 ns | 0.1065 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  10.401 ns | 0.0576 ns | 0.0511 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  13.192 ns | 0.0687 ns | 0.0642 ns |           - |           - |           - |                   - |
                                             From_Long |  10.240 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |  16.841 ns | 0.0725 ns | 0.0678 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  12.210 ns | 0.0361 ns | 0.0320 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |  16.918 ns | 0.0411 ns | 0.0384 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  11.486 ns | 0.0350 ns | 0.0328 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  12.543 ns | 0.1009 ns | 0.0944 ns |           - |           - |           - |                   - |
                                            From_SByte |  12.000 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |  16.480 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  10.903 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |  16.682 ns | 0.0718 ns | 0.0600 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  10.846 ns | 0.0353 ns | 0.0331 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  12.292 ns | 0.0398 ns | 0.0372 ns |           - |           - |           - |                   - |
                                            From_Float |  11.180 ns | 0.0829 ns | 0.0775 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |  16.615 ns | 0.0869 ns | 0.0812 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |  10.528 ns | 0.0529 ns | 0.0469 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |  16.956 ns | 0.1717 ns | 0.1434 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  10.500 ns | 0.0251 ns | 0.0235 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  12.441 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                           From_String |  69.456 ns | 0.5155 ns | 0.4822 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 114.654 ns | 0.8620 ns | 0.8063 ns |           - |           - |           - |                   - |
                                      From_String_Null |  13.009 ns | 0.0707 ns | 0.0661 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  13.633 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  12.423 ns | 0.0500 ns | 0.0468 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |         NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  10.303 ns | 0.0595 ns | 0.0528 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |  16.858 ns | 0.0681 ns | 0.0637 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  10.748 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |  17.111 ns | 0.1168 ns | 0.1092 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  10.353 ns | 0.0363 ns | 0.0340 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  13.017 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
                                             From_UInt |  10.287 ns | 0.0360 ns | 0.0336 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |  16.742 ns | 0.0875 ns | 0.0776 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  10.710 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |  16.740 ns | 0.1092 ns | 0.1021 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  10.352 ns | 0.0360 ns | 0.0300 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  12.364 ns | 0.0439 ns | 0.0390 ns |           - |           - |           - |                   - |
                                            From_ULong |  10.322 ns | 0.0312 ns | 0.0277 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |  16.846 ns | 0.0952 ns | 0.0891 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  11.506 ns | 0.0502 ns | 0.0419 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |  16.936 ns | 0.1204 ns | 0.1067 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  11.944 ns | 0.0662 ns | 0.0620 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  12.388 ns | 0.0749 ns | 0.0701 ns |           - |           - |           - |                   - |
                                       From_NullObject |  12.227 ns | 0.0516 ns | 0.0483 ns |           - |           - |           - |                   - |
                                           From_DBNull |   9.316 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  12.382 ns | 0.0578 ns | 0.0541 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  13.528 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  15.571 ns | 0.0805 ns | 0.0713 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  11.960 ns | 0.0525 ns | 0.0491 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  13.115 ns | 0.0793 ns | 0.0742 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  10.585 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  13.807 ns | 0.0466 ns | 0.0436 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  10.542 ns | 0.0517 ns | 0.0459 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  12.324 ns | 0.0610 ns | 0.0570 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  15.090 ns | 0.0810 ns | 0.0758 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  16.125 ns | 0.0672 ns | 0.0628 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  15.513 ns | 0.1296 ns | 0.1212 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  15.985 ns | 0.0581 ns | 0.0515 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  11.513 ns | 0.0581 ns | 0.0543 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.286 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |   9.996 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  13.679 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  10.076 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  13.668 ns | 0.0514 ns | 0.0481 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |   9.967 ns | 0.0511 ns | 0.0478 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  12.327 ns | 0.0632 ns | 0.0591 ns |           - |           - |           - |                   - |
                                             From_Enum |  10.253 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |  42.402 ns | 0.2576 ns | 0.2409 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue |  10.295 ns | 0.0514 ns | 0.0481 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |  44.113 ns | 0.1255 ns | 0.1174 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  10.023 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  12.284 ns | 0.0437 ns | 0.0409 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  10.565 ns | 0.0550 ns | 0.0488 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  14.286 ns | 0.0440 ns | 0.0390 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  10.794 ns | 0.0451 ns | 0.0421 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  12.299 ns | 0.1259 ns | 0.1051 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  36.167 ns | 0.2136 ns | 0.1998 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  14.102 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  36.163 ns | 0.2151 ns | 0.2012 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  14.076 ns | 0.1041 ns | 0.0974 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.534 ns | 0.2404 ns | 0.2249 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  13.354 ns | 0.0953 ns | 0.0892 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: DefaultJob
