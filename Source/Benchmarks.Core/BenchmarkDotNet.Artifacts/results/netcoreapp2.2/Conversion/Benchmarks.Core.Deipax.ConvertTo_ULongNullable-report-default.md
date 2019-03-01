
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.042 ns | 0.0259 ns | 0.0230 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 16.012 ns | 0.0979 ns | 0.0916 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 10.336 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 16.047 ns | 0.1221 ns | 0.1142 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.106 ns | 0.0570 ns | 0.0533 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 12.251 ns | 0.0389 ns | 0.0364 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.322 ns | 0.0567 ns | 0.0530 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 16.241 ns | 0.0625 ns | 0.0554 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.180 ns | 0.0350 ns | 0.0328 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 16.118 ns | 0.3935 ns | 0.3681 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.107 ns | 0.0411 ns | 0.0364 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 12.118 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
                                             From_Char |  9.937 ns | 0.0445 ns | 0.0417 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.725 ns | 0.0638 ns | 0.0566 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.179 ns | 0.0496 ns | 0.0414 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.696 ns | 0.1113 ns | 0.1041 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.992 ns | 0.0501 ns | 0.0469 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 12.318 ns | 0.0802 ns | 0.0751 ns |           - |           - |           - |                   - |
                                         From_DateTime | 10.702 ns | 0.0341 ns | 0.0285 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 10.777 ns | 0.0522 ns | 0.0463 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.993 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.126 ns | 0.0615 ns | 0.0575 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.506 ns | 0.1419 ns | 0.1328 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 26.189 ns | 0.2231 ns | 0.2087 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 20.094 ns | 0.1539 ns | 0.1439 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 27.180 ns | 0.2534 ns | 0.2370 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.004 ns | 0.0619 ns | 0.0579 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.130 ns | 0.0441 ns | 0.0391 ns |           - |           - |           - |                   - |
                                           From_Double | 11.144 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.682 ns | 0.0773 ns | 0.0723 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 12.107 ns | 0.0559 ns | 0.0523 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.750 ns | 0.0962 ns | 0.0900 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 11.360 ns | 0.0565 ns | 0.0528 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.190 ns | 0.0677 ns | 0.0634 ns |           - |           - |           - |                   - |
                                            From_Short | 10.192 ns | 0.0440 ns | 0.0412 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 16.412 ns | 0.0655 ns | 0.0613 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.402 ns | 0.0433 ns | 0.0384 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 16.320 ns | 0.0957 ns | 0.0896 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.441 ns | 0.0530 ns | 0.0470 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 13.411 ns | 0.0640 ns | 0.0598 ns |           - |           - |           - |                   - |
                                              From_Int | 10.028 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 16.209 ns | 0.0772 ns | 0.0722 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 12.151 ns | 0.0555 ns | 0.0519 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 16.323 ns | 0.0979 ns | 0.0915 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.488 ns | 0.0508 ns | 0.0450 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.157 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                                             From_Long | 10.536 ns | 0.0580 ns | 0.0515 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 16.860 ns | 0.0960 ns | 0.0898 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 11.485 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.260 ns | 0.3218 ns | 0.2853 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 11.578 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.335 ns | 0.0634 ns | 0.0593 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.229 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 16.426 ns | 0.0948 ns | 0.0887 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 10.488 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 16.123 ns | 0.1016 ns | 0.0901 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.148 ns | 0.0381 ns | 0.0338 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.125 ns | 0.0568 ns | 0.0531 ns |           - |           - |           - |                   - |
                                            From_Float | 11.829 ns | 0.0598 ns | 0.0500 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 19.280 ns | 0.1357 ns | 0.1269 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 11.356 ns | 0.0551 ns | 0.0515 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 18.913 ns | 0.1161 ns | 0.1029 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.490 ns | 0.0388 ns | 0.0363 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.183 ns | 0.0698 ns | 0.0619 ns |           - |           - |           - |                   - |
                                           From_String | 49.116 ns | 0.2196 ns | 0.1947 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 57.704 ns | 0.1268 ns | 0.1124 ns |           - |           - |           - |                   - |
                                      From_String_Null | 12.218 ns | 0.0425 ns | 0.0398 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.158 ns | 0.0582 ns | 0.0545 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.318 ns | 0.0604 ns | 0.0536 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 11.432 ns | 0.1081 ns | 0.0958 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.952 ns | 0.0950 ns | 0.0889 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.194 ns | 0.0405 ns | 0.0378 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.998 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.024 ns | 0.0546 ns | 0.0484 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 12.279 ns | 0.0402 ns | 0.0356 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.369 ns | 0.0458 ns | 0.0429 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 16.460 ns | 0.1192 ns | 0.1115 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 12.495 ns | 0.0449 ns | 0.0420 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 15.994 ns | 0.0626 ns | 0.0523 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.727 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.237 ns | 0.0373 ns | 0.0311 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.402 ns | 0.0440 ns | 0.0412 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 25.088 ns | 0.1326 ns | 0.1240 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 10.774 ns | 0.0523 ns | 0.0437 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 23.843 ns | 0.1082 ns | 0.1012 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 10.772 ns | 0.0384 ns | 0.0340 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.194 ns | 0.0571 ns | 0.0534 ns |           - |           - |           - |                   - |
                                       From_NullObject | 12.081 ns | 0.0352 ns | 0.0330 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.695 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.985 ns | 0.0417 ns | 0.0370 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.116 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.070 ns | 0.0689 ns | 0.0645 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.944 ns | 0.0574 ns | 0.0536 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.158 ns | 0.0524 ns | 0.0491 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.393 ns | 0.0858 ns | 0.0802 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.532 ns | 0.0708 ns | 0.0662 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.358 ns | 0.0453 ns | 0.0423 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.176 ns | 0.0521 ns | 0.0462 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 15.003 ns | 0.1129 ns | 0.1056 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 15.245 ns | 0.0273 ns | 0.0213 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 15.283 ns | 0.1071 ns | 0.1001 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 15.484 ns | 0.1048 ns | 0.0980 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.293 ns | 0.0694 ns | 0.0542 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.078 ns | 0.0336 ns | 0.0280 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.910 ns | 0.0355 ns | 0.0314 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.468 ns | 0.0966 ns | 0.0904 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.940 ns | 0.0591 ns | 0.0553 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.409 ns | 0.0728 ns | 0.0681 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.824 ns | 0.0303 ns | 0.0253 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.153 ns | 0.0528 ns | 0.0468 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.151 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.065 ns | 0.1231 ns | 0.1151 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 10.426 ns | 0.0512 ns | 0.0479 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 41.278 ns | 0.2444 ns | 0.2286 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 10.011 ns | 0.0241 ns | 0.0214 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.178 ns | 0.0847 ns | 0.0793 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 12.359 ns | 0.0744 ns | 0.0621 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.706 ns | 0.0555 ns | 0.0520 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.457 ns | 0.0625 ns | 0.0584 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.093 ns | 0.0371 ns | 0.0347 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 34.586 ns | 0.2236 ns | 0.2092 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.751 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 36.509 ns | 0.5024 ns | 0.4699 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.727 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 34.416 ns | 0.1277 ns | 0.1195 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.100 ns | 0.0483 ns | 0.0452 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_String_Empty_AsObject: DefaultJob
