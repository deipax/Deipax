
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 13.80 ns | 0.1799 ns | 0.1682 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 18.21 ns | 0.0787 ns | 0.0736 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 13.86 ns | 0.0485 ns | 0.0430 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 19.63 ns | 0.0768 ns | 0.0718 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 12.91 ns | 0.0776 ns | 0.0725 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.99 ns | 0.0631 ns | 0.0590 ns |           - |           - |           - |                   - |
                                             From_Byte | 12.82 ns | 0.0430 ns | 0.0403 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 19.78 ns | 0.0369 ns | 0.0327 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 13.53 ns | 0.0957 ns | 0.0848 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 19.52 ns | 0.1130 ns | 0.1057 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 13.46 ns | 0.0871 ns | 0.0815 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 14.76 ns | 0.0548 ns | 0.0513 ns |           - |           - |           - |                   - |
                                             From_Char | 12.60 ns | 0.0563 ns | 0.0526 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 12.59 ns | 0.0410 ns | 0.0383 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.59 ns | 0.0290 ns | 0.0242 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 14.98 ns | 0.0307 ns | 0.0287 ns |           - |           - |           - |                   - |
                                         From_DateTime | 13.78 ns | 0.1218 ns | 0.1139 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 12.86 ns | 0.0335 ns | 0.0297 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 12.97 ns | 0.0499 ns | 0.0467 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 15.28 ns | 0.0337 ns | 0.0315 ns |           - |           - |           - |                   - |
                                          From_Decimal | 13.04 ns | 0.0701 ns | 0.0655 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 16.06 ns | 0.0597 ns | 0.0498 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 14.38 ns | 0.0462 ns | 0.0433 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 14.36 ns | 0.0378 ns | 0.0335 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 13.19 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 13.67 ns | 0.0437 ns | 0.0408 ns |           - |           - |           - |                   - |
                                           From_Double | 59.38 ns | 0.3409 ns | 0.3189 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 65.96 ns | 0.2705 ns | 0.2530 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 60.08 ns | 0.2151 ns | 0.1907 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 66.80 ns | 0.8606 ns | 0.8050 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.29 ns | 0.0565 ns | 0.0528 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 14.40 ns | 0.0473 ns | 0.0443 ns |           - |           - |           - |                   - |
                                            From_Short | 14.63 ns | 0.0566 ns | 0.0501 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 19.65 ns | 0.0653 ns | 0.0611 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 13.51 ns | 0.0801 ns | 0.0749 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 21.34 ns | 0.0897 ns | 0.0795 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 13.21 ns | 0.0538 ns | 0.0477 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 15.43 ns | 0.0563 ns | 0.0526 ns |           - |           - |           - |                   - |
                                              From_Int | 13.23 ns | 0.0468 ns | 0.0438 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 20.34 ns | 0.1164 ns | 0.1089 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 13.52 ns | 0.0570 ns | 0.0534 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 17.56 ns | 0.0718 ns | 0.0672 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 13.17 ns | 0.0562 ns | 0.0525 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 14.82 ns | 0.0666 ns | 0.0590 ns |           - |           - |           - |                   - |
                                             From_Long | 13.23 ns | 0.0800 ns | 0.0668 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.72 ns | 0.0873 ns | 0.0816 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.63 ns | 0.0268 ns | 0.0238 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 20.56 ns | 0.1109 ns | 0.1037 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 14.81 ns | 0.0820 ns | 0.0767 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 15.51 ns | 0.0966 ns | 0.0806 ns |           - |           - |           - |                   - |
                                            From_SByte | 12.94 ns | 0.1295 ns | 0.1211 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 19.52 ns | 0.0600 ns | 0.0562 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 13.47 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 20.60 ns | 0.0954 ns | 0.0892 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.97 ns | 0.0761 ns | 0.0712 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 14.74 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
                                            From_Float | 30.73 ns | 0.1095 ns | 0.0971 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 37.40 ns | 0.2085 ns | 0.1848 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 32.37 ns | 0.1525 ns | 0.1352 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 37.15 ns | 0.1113 ns | 0.1041 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 12.69 ns | 0.0867 ns | 0.0811 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 16.48 ns | 0.0446 ns | 0.0417 ns |           - |           - |           - |                   - |
                                           From_String | 87.27 ns | 0.6669 ns | 0.5912 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 92.08 ns | 0.3179 ns | 0.2974 ns |           - |           - |           - |                   - |
                                      From_String_Null | 15.10 ns | 0.1455 ns | 0.1361 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 16.86 ns | 0.0660 ns | 0.0551 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 14.09 ns | 0.0555 ns | 0.0520 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |       NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 12.84 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 19.45 ns | 0.1358 ns | 0.1271 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 13.62 ns | 0.0450 ns | 0.0421 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 19.62 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 13.13 ns | 0.0363 ns | 0.0339 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 14.08 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                                             From_UInt | 14.69 ns | 0.0583 ns | 0.0545 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.19 ns | 0.1223 ns | 0.1144 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 13.14 ns | 0.0581 ns | 0.0515 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 19.52 ns | 0.0652 ns | 0.0578 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 12.68 ns | 0.0584 ns | 0.0547 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 14.75 ns | 0.0563 ns | 0.0527 ns |           - |           - |           - |                   - |
                                            From_ULong | 12.81 ns | 0.0450 ns | 0.0399 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 19.43 ns | 0.0657 ns | 0.0614 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.88 ns | 0.0699 ns | 0.0654 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 19.24 ns | 0.1118 ns | 0.1046 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 13.31 ns | 0.0299 ns | 0.0250 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 13.71 ns | 0.0437 ns | 0.0388 ns |           - |           - |           - |                   - |
                                       From_NullObject | 13.74 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.35 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 13.73 ns | 0.0560 ns | 0.0524 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 15.88 ns | 0.0741 ns | 0.0693 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 18.80 ns | 0.0590 ns | 0.0551 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 13.34 ns | 0.0466 ns | 0.0436 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 15.44 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 14.01 ns | 0.0453 ns | 0.0378 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.98 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.52 ns | 0.0310 ns | 0.0275 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 15.57 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 19.17 ns | 0.0596 ns | 0.0529 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 19.89 ns | 0.1144 ns | 0.1071 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 20.17 ns | 0.0672 ns | 0.0629 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 18.81 ns | 0.1586 ns | 0.1406 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.63 ns | 0.0424 ns | 0.0396 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 15.26 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.40 ns | 0.0283 ns | 0.0265 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 17.20 ns | 0.1029 ns | 0.0962 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 12.43 ns | 0.0358 ns | 0.0335 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.14 ns | 0.0909 ns | 0.0850 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 12.39 ns | 0.0375 ns | 0.0313 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.44 ns | 0.0474 ns | 0.0444 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.64 ns | 0.0526 ns | 0.0466 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 41.98 ns | 0.1952 ns | 0.1826 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 14.25 ns | 0.0502 ns | 0.0469 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 47.61 ns | 0.2163 ns | 0.2024 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 14.21 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 14.91 ns | 0.0769 ns | 0.0719 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.47 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 17.19 ns | 0.1076 ns | 0.1007 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.41 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 15.45 ns | 0.0347 ns | 0.0324 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.02 ns | 0.1662 ns | 0.1554 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 15.08 ns | 0.0802 ns | 0.0711 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 46.75 ns | 0.1181 ns | 0.1047 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 17.20 ns | 0.0559 ns | 0.0496 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.16 ns | 0.2239 ns | 0.1984 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.70 ns | 0.0734 ns | 0.0687 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_String_Empty_AsObject: DefaultJob
