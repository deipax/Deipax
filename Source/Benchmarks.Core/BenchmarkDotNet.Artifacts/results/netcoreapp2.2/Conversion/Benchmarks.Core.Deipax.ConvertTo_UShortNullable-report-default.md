
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.43 ns | 0.0794 ns | 0.0742 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 17.53 ns | 0.0754 ns | 0.0705 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.69 ns | 0.0151 ns | 0.0126 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.39 ns | 0.0563 ns | 0.0526 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.29 ns | 0.0468 ns | 0.0415 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.00 ns | 0.0226 ns | 0.0189 ns |           - |           - |           - |                   - |
                                             From_Byte | 11.58 ns | 0.0670 ns | 0.0627 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.53 ns | 0.3368 ns | 0.2986 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.74 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.10 ns | 0.0610 ns | 0.0541 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.40 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.96 ns | 0.0599 ns | 0.0500 ns |           - |           - |           - |                   - |
                                             From_Char | 10.45 ns | 0.0518 ns | 0.0484 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 18.00 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.90 ns | 0.0449 ns | 0.0398 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.97 ns | 0.0618 ns | 0.0548 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.41 ns | 0.0347 ns | 0.0308 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.58 ns | 0.0710 ns | 0.0664 ns |           - |           - |           - |                   - |
                                         From_DateTime | 12.21 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.27 ns | 0.0301 ns | 0.0282 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.34 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.95 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
                                          From_Decimal | 23.55 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 29.55 ns | 0.0985 ns | 0.0921 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 24.10 ns | 0.0837 ns | 0.0699 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 29.82 ns | 0.2501 ns | 0.2217 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.42 ns | 0.0327 ns | 0.0255 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.96 ns | 0.0337 ns | 0.0299 ns |           - |           - |           - |                   - |
                                           From_Double | 13.10 ns | 0.0481 ns | 0.0450 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 19.96 ns | 0.0317 ns | 0.0265 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 14.40 ns | 0.0180 ns | 0.0160 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 19.77 ns | 0.0699 ns | 0.0654 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.90 ns | 0.0945 ns | 0.0884 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.02 ns | 0.0994 ns | 0.0930 ns |           - |           - |           - |                   - |
                                            From_Short | 10.52 ns | 0.1133 ns | 0.1059 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.59 ns | 0.0836 ns | 0.0782 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.71 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.63 ns | 0.0978 ns | 0.0915 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.28 ns | 0.0534 ns | 0.0474 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.98 ns | 0.0609 ns | 0.0569 ns |           - |           - |           - |                   - |
                                              From_Int | 11.49 ns | 0.0709 ns | 0.0664 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 18.19 ns | 0.1292 ns | 0.1208 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 11.86 ns | 0.0110 ns | 0.0086 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 18.91 ns | 0.0378 ns | 0.0315 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.35 ns | 0.0517 ns | 0.0483 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.99 ns | 0.0635 ns | 0.0563 ns |           - |           - |           - |                   - |
                                             From_Long | 12.09 ns | 0.1141 ns | 0.1012 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 18.05 ns | 0.0595 ns | 0.0527 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 12.62 ns | 0.0823 ns | 0.0770 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 18.01 ns | 0.1597 ns | 0.1494 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.30 ns | 0.0466 ns | 0.0436 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.61 ns | 0.0440 ns | 0.0367 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.96 ns | 0.0751 ns | 0.0666 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 17.77 ns | 0.2369 ns | 0.2216 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.79 ns | 0.0980 ns | 0.0917 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.50 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.25 ns | 0.0548 ns | 0.0458 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 13.99 ns | 0.0879 ns | 0.0823 ns |           - |           - |           - |                   - |
                                            From_Float | 13.09 ns | 0.0699 ns | 0.0620 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.84 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 13.03 ns | 0.0366 ns | 0.0324 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 20.28 ns | 0.1105 ns | 0.1034 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.47 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 13.84 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                                           From_String | 56.97 ns | 0.3924 ns | 0.3671 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 61.78 ns | 0.1529 ns | 0.1356 ns |           - |           - |           - |                   - |
                                      From_String_Null | 18.69 ns | 0.1081 ns | 0.1011 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 13.00 ns | 0.0569 ns | 0.0532 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 18.26 ns | 0.0856 ns | 0.0800 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.88 ns | 0.0343 ns | 0.0304 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 25.33 ns | 0.1267 ns | 0.1185 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.72 ns | 0.0739 ns | 0.0617 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 25.37 ns | 0.1117 ns | 0.1045 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.20 ns | 0.0502 ns | 0.0469 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.98 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.46 ns | 0.0699 ns | 0.0653 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.62 ns | 0.0651 ns | 0.0609 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 10.66 ns | 0.0324 ns | 0.0270 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.62 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.84 ns | 0.0614 ns | 0.0544 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 13.52 ns | 0.0545 ns | 0.0510 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.91 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 17.98 ns | 0.0478 ns | 0.0399 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.30 ns | 0.0411 ns | 0.0364 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.82 ns | 0.0844 ns | 0.0790 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.45 ns | 0.2002 ns | 0.1873 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.96 ns | 0.0635 ns | 0.0531 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.94 ns | 0.0308 ns | 0.0273 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.10 ns | 0.0258 ns | 0.0228 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.90 ns | 0.0092 ns | 0.0081 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.58 ns | 0.0784 ns | 0.0733 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 17.43 ns | 0.1100 ns | 0.1029 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.97 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 13.38 ns | 0.0797 ns | 0.0745 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.37 ns | 0.0781 ns | 0.0730 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 15.30 ns | 0.0798 ns | 0.0707 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.29 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.05 ns | 0.0698 ns | 0.0652 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.55 ns | 0.0867 ns | 0.0811 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.16 ns | 0.0870 ns | 0.0814 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 16.42 ns | 0.1145 ns | 0.1071 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 17.15 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.02 ns | 0.0697 ns | 0.0544 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 13.00 ns | 0.0463 ns | 0.0433 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.40 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 19.44 ns | 0.1839 ns | 0.1720 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.42 ns | 0.0218 ns | 0.0182 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.98 ns | 0.0928 ns | 0.0868 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.44 ns | 0.0730 ns | 0.0570 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.93 ns | 0.0328 ns | 0.0256 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.22 ns | 0.0734 ns | 0.0651 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 43.69 ns | 0.1453 ns | 0.1213 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 12.80 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 47.48 ns | 0.5369 ns | 0.4759 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 13.21 ns | 0.0803 ns | 0.0712 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.97 ns | 0.0586 ns | 0.0519 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.30 ns | 0.0508 ns | 0.0450 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 15.28 ns | 0.0277 ns | 0.0216 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.22 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 13.28 ns | 0.1058 ns | 0.0990 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 42.45 ns | 0.0933 ns | 0.0728 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.34 ns | 0.0852 ns | 0.0711 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 42.64 ns | 0.4401 ns | 0.4117 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 15.21 ns | 0.0216 ns | 0.0191 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 42.22 ns | 0.0746 ns | 0.0662 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.95 ns | 0.0319 ns | 0.0283 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_String_Empty_AsObject: DefaultJob
