
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.911 ns | 0.0383 ns | 0.0339 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 17.237 ns | 0.0132 ns | 0.0110 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.370 ns | 0.1072 ns | 0.1002 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 17.830 ns | 0.3337 ns | 0.3122 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 11.386 ns | 0.0211 ns | 0.0176 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 13.022 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.484 ns | 0.0148 ns | 0.0132 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 17.247 ns | 0.0414 ns | 0.0387 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 11.879 ns | 0.0368 ns | 0.0345 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 17.243 ns | 0.0497 ns | 0.0465 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.920 ns | 0.0289 ns | 0.0270 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 13.031 ns | 0.0306 ns | 0.0287 ns |           - |           - |           - |                   - |
                                             From_Char | 10.992 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 17.750 ns | 0.0214 ns | 0.0189 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 11.185 ns | 0.0853 ns | 0.0756 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 17.846 ns | 0.1095 ns | 0.0971 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.878 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 13.043 ns | 0.0204 ns | 0.0181 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.269 ns | 0.0744 ns | 0.0622 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.345 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.182 ns | 0.0219 ns | 0.0183 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.980 ns | 0.0939 ns | 0.0878 ns |           - |           - |           - |                   - |
                                          From_Decimal | 21.274 ns | 0.1040 ns | 0.0973 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 29.111 ns | 0.2244 ns | 0.2099 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 24.772 ns | 0.1752 ns | 0.1639 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 28.748 ns | 0.1755 ns | 0.1642 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 12.154 ns | 0.1450 ns | 0.1356 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 12.986 ns | 0.0928 ns | 0.0822 ns |           - |           - |           - |                   - |
                                           From_Double | 12.311 ns | 0.0953 ns | 0.0892 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.715 ns | 0.0642 ns | 0.0569 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.331 ns | 0.0479 ns | 0.0425 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 18.550 ns | 0.0592 ns | 0.0553 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.270 ns | 0.0409 ns | 0.0341 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.979 ns | 0.0352 ns | 0.0330 ns |           - |           - |           - |                   - |
                                            From_Short | 10.869 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 17.255 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 11.111 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 17.278 ns | 0.0357 ns | 0.0316 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.768 ns | 0.0258 ns | 0.0216 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.908 ns | 0.0383 ns | 0.0359 ns |           - |           - |           - |                   - |
                                              From_Int | 10.854 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 25.416 ns | 0.1490 ns | 0.1393 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.158 ns | 0.0342 ns | 0.0303 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 25.234 ns | 0.0815 ns | 0.0722 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.166 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.958 ns | 0.0339 ns | 0.0317 ns |           - |           - |           - |                   - |
                                             From_Long | 12.058 ns | 0.0515 ns | 0.0457 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 17.828 ns | 0.0617 ns | 0.0547 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.211 ns | 0.0376 ns | 0.0351 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 17.899 ns | 0.0910 ns | 0.0851 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 14.267 ns | 0.1079 ns | 0.0901 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 13.069 ns | 0.0622 ns | 0.0551 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.481 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 17.052 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.439 ns | 0.0124 ns | 0.0110 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 17.045 ns | 0.0220 ns | 0.0205 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.801 ns | 0.0356 ns | 0.0315 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.998 ns | 0.0941 ns | 0.0834 ns |           - |           - |           - |                   - |
                                            From_Float | 12.214 ns | 0.0666 ns | 0.0556 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 18.976 ns | 0.0163 ns | 0.0145 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.728 ns | 0.0197 ns | 0.0175 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 18.658 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.843 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.872 ns | 0.0130 ns | 0.0109 ns |           - |           - |           - |                   - |
                                           From_String | 89.951 ns | 0.0866 ns | 0.0768 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 92.825 ns | 0.1876 ns | 0.1755 ns |           - |           - |           - |                   - |
                                      From_String_Null | 18.599 ns | 0.0333 ns | 0.0278 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.894 ns | 0.0135 ns | 0.0119 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 18.607 ns | 0.0172 ns | 0.0152 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.449 ns | 0.0776 ns | 0.0726 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 17.176 ns | 0.1603 ns | 0.1421 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 11.309 ns | 0.0778 ns | 0.0650 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 17.202 ns | 0.1615 ns | 0.1511 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 11.304 ns | 0.0338 ns | 0.0299 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 13.028 ns | 0.1085 ns | 0.1015 ns |           - |           - |           - |                   - |
                                             From_UInt | 11.053 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 17.368 ns | 0.0252 ns | 0.0197 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.656 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 17.264 ns | 0.0218 ns | 0.0194 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 11.287 ns | 0.0121 ns | 0.0107 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.963 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
                                            From_ULong | 11.484 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 18.191 ns | 0.0189 ns | 0.0167 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.146 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 17.733 ns | 0.0213 ns | 0.0178 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 14.058 ns | 0.0403 ns | 0.0336 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 12.867 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
                                       From_NullObject | 14.222 ns | 0.0383 ns | 0.0340 ns |           - |           - |           - |                   - |
                                           From_DBNull | 11.056 ns | 0.0223 ns | 0.0197 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.895 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 14.494 ns | 0.0177 ns | 0.0157 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 16.879 ns | 0.1204 ns | 0.1067 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.990 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.933 ns | 0.0907 ns | 0.0849 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 12.337 ns | 0.1370 ns | 0.1282 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 14.917 ns | 0.0389 ns | 0.0345 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.205 ns | 0.0247 ns | 0.0231 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 13.487 ns | 0.0858 ns | 0.0802 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.639 ns | 0.4541 ns | 0.4663 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 17.317 ns | 0.0241 ns | 0.0188 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.119 ns | 0.2927 ns | 0.2594 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.532 ns | 0.2785 ns | 0.2605 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.462 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.204 ns | 0.0298 ns | 0.0248 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  9.636 ns | 0.0580 ns | 0.0542 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 15.766 ns | 0.0417 ns | 0.0390 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  9.529 ns | 0.0466 ns | 0.0413 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 14.525 ns | 0.0605 ns | 0.0537 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  9.606 ns | 0.0414 ns | 0.0387 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 12.246 ns | 0.0331 ns | 0.0294 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.362 ns | 0.0441 ns | 0.0413 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 39.412 ns | 0.2055 ns | 0.1822 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.925 ns | 0.0297 ns | 0.0263 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 42.824 ns | 0.1642 ns | 0.1536 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue |  9.764 ns | 0.0337 ns | 0.0316 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 12.379 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 11.673 ns | 0.0496 ns | 0.0440 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 14.553 ns | 0.0769 ns | 0.0719 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 11.681 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 12.351 ns | 0.0421 ns | 0.0394 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 43.249 ns | 0.1505 ns | 0.1408 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 14.577 ns | 0.0607 ns | 0.0568 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 38.339 ns | 0.1409 ns | 0.1318 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 14.546 ns | 0.0533 ns | 0.0473 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.020 ns | 0.0799 ns | 0.0667 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 12.363 ns | 0.0405 ns | 0.0359 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_IntNullable.From_String_Empty_AsObject: DefaultJob
