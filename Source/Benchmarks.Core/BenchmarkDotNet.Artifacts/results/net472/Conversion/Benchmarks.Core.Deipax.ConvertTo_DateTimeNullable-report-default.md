
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  13.00 ns | 0.0423 ns | 0.0396 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  13.56 ns | 0.0811 ns | 0.0758 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  12.79 ns | 0.0379 ns | 0.0354 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  27.83 ns | 0.1369 ns | 0.1280 ns |           - |           - |           - |                   - |
                                             From_Byte |  13.55 ns | 0.0511 ns | 0.0426 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  13.61 ns | 0.0857 ns | 0.0760 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  12.64 ns | 0.0474 ns | 0.0444 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  27.82 ns | 0.0782 ns | 0.0732 ns |           - |           - |           - |                   - |
                                             From_Char |  13.63 ns | 0.0297 ns | 0.0263 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  12.52 ns | 0.0452 ns | 0.0422 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  13.25 ns | 0.0389 ns | 0.0363 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  27.97 ns | 0.0724 ns | 0.0641 ns |           - |           - |           - |                   - |
                                         From_DateTime |  13.42 ns | 0.0621 ns | 0.0581 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |  35.95 ns | 0.1198 ns | 0.1121 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  12.89 ns | 0.0492 ns | 0.0461 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |  34.07 ns | 0.1086 ns | 0.0962 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  12.48 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  27.77 ns | 0.1192 ns | 0.0995 ns |           - |           - |           - |                   - |
                                          From_Decimal |  12.73 ns | 0.0450 ns | 0.0399 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  12.68 ns | 0.0147 ns | 0.0131 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  12.85 ns | 0.0496 ns | 0.0464 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  24.48 ns | 0.0660 ns | 0.0618 ns |           - |           - |           - |                   - |
                                           From_Double |  12.93 ns | 0.0739 ns | 0.0691 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  13.36 ns | 0.0511 ns | 0.0453 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  13.26 ns | 0.0485 ns | 0.0453 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  23.40 ns | 0.0636 ns | 0.0595 ns |           - |           - |           - |                   - |
                                            From_Short |  13.57 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  13.89 ns | 0.0688 ns | 0.0610 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  12.59 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  23.39 ns | 0.0937 ns | 0.0876 ns |           - |           - |           - |                   - |
                                              From_Int |  12.60 ns | 0.0454 ns | 0.0425 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  12.58 ns | 0.0785 ns | 0.0734 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  12.55 ns | 0.0307 ns | 0.0287 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  22.05 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
                                             From_Long |  14.65 ns | 0.0989 ns | 0.0926 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  16.03 ns | 0.1156 ns | 0.1081 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  12.78 ns | 0.0787 ns | 0.0698 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  27.61 ns | 0.2463 ns | 0.2304 ns |           - |           - |           - |                   - |
                                            From_SByte |  13.95 ns | 0.0803 ns | 0.0712 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  12.63 ns | 0.0547 ns | 0.0511 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  12.60 ns | 0.0393 ns | 0.0367 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  27.55 ns | 0.2820 ns | 0.2638 ns |           - |           - |           - |                   - |
                                            From_Float |  13.45 ns | 0.0429 ns | 0.0402 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |  12.54 ns | 0.0416 ns | 0.0390 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  13.27 ns | 0.0905 ns | 0.0847 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  27.50 ns | 0.2900 ns | 0.2571 ns |           - |           - |           - |                   - |
                                           From_String | 738.35 ns | 2.9193 ns | 2.7307 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 749.69 ns | 4.1477 ns | 3.8798 ns |           - |           - |           - |                   - |
                                      From_String_Null |  20.42 ns | 0.1264 ns | 0.1182 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  27.89 ns | 0.0998 ns | 0.0834 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  22.97 ns | 0.0909 ns | 0.0850 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  12.95 ns | 0.0406 ns | 0.0360 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  13.61 ns | 0.1335 ns | 0.1249 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  13.72 ns | 0.1407 ns | 0.1316 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  22.13 ns | 0.1281 ns | 0.1199 ns |           - |           - |           - |                   - |
                                             From_UInt |  12.64 ns | 0.0409 ns | 0.0382 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  13.64 ns | 0.1476 ns | 0.1381 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  13.56 ns | 0.0685 ns | 0.0607 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  27.48 ns | 0.1600 ns | 0.1496 ns |           - |           - |           - |                   - |
                                            From_ULong |  12.64 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  14.00 ns | 0.0860 ns | 0.0805 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  13.35 ns | 0.0966 ns | 0.0904 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  21.96 ns | 0.0590 ns | 0.0552 ns |           - |           - |           - |                   - |
                                       From_NullObject |  22.28 ns | 0.0754 ns | 0.0705 ns |           - |           - |           - |                   - |
                                           From_DBNull |  11.35 ns | 0.0433 ns | 0.0405 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  22.08 ns | 0.1020 ns | 0.0954 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  25.73 ns | 0.1129 ns | 0.1056 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  25.06 ns | 0.1515 ns | 0.1417 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  23.54 ns | 0.0541 ns | 0.0507 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  22.14 ns | 0.1136 ns | 0.1063 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  22.16 ns | 0.0554 ns | 0.0491 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  28.74 ns | 0.1055 ns | 0.0987 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  21.97 ns | 0.1138 ns | 0.1064 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  23.47 ns | 0.0859 ns | 0.0804 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  25.27 ns | 0.1223 ns | 0.1144 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  28.30 ns | 0.0885 ns | 0.0828 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  26.70 ns | 0.1417 ns | 0.1326 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  32.28 ns | 0.2374 ns | 0.2221 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  21.25 ns | 0.0988 ns | 0.0925 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  22.33 ns | 0.0613 ns | 0.0573 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  12.65 ns | 0.0791 ns | 0.0740 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  28.71 ns | 0.1488 ns | 0.1392 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  12.58 ns | 0.0444 ns | 0.0370 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.20 ns | 0.0855 ns | 0.0800 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  13.12 ns | 0.0544 ns | 0.0508 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  22.24 ns | 0.1125 ns | 0.1053 ns |           - |           - |           - |                   - |
                                             From_Enum |  12.45 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue |  13.04 ns | 0.1160 ns | 0.1085 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |  13.83 ns | 0.1904 ns | 0.1781 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  24.62 ns | 0.0578 ns | 0.0541 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  15.35 ns | 0.0789 ns | 0.0738 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  25.32 ns | 0.0842 ns | 0.0787 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  22.19 ns | 0.1272 ns | 0.1190 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  22.77 ns | 0.0797 ns | 0.0745 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  37.67 ns | 0.2155 ns | 0.1910 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  23.31 ns | 0.1314 ns | 0.1229 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  39.00 ns | 0.0777 ns | 0.0689 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  29.29 ns | 0.2132 ns | 0.1994 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  37.56 ns | 0.0905 ns | 0.0756 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  21.97 ns | 0.0845 ns | 0.0790 ns |           - |           - |           - |                   - |

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
