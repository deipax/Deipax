
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool |  11.45 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue |  12.02 ns | 0.0765 ns | 0.0716 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  11.99 ns | 0.0646 ns | 0.0604 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  13.71 ns | 0.0546 ns | 0.0510 ns |           - |           - |           - |                   - |
                                             From_Byte |  12.08 ns | 0.0938 ns | 0.0832 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue |  12.41 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  12.13 ns | 0.0828 ns | 0.0734 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  13.70 ns | 0.0611 ns | 0.0572 ns |           - |           - |           - |                   - |
                                             From_Char |  12.10 ns | 0.0303 ns | 0.0269 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue |  12.12 ns | 0.0515 ns | 0.0482 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  11.47 ns | 0.0339 ns | 0.0318 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  32.40 ns | 0.1810 ns | 0.1693 ns |           - |           - |           - |                   - |
                                         From_DateTime |  11.41 ns | 0.0719 ns | 0.0673 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |  14.90 ns | 0.0414 ns | 0.0367 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue |  18.17 ns | 0.1253 ns | 0.1172 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |  12.77 ns | 0.0358 ns | 0.0335 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue |  12.50 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  32.34 ns | 0.1851 ns | 0.1641 ns |           - |           - |           - |                   - |
                                          From_Decimal |  13.52 ns | 0.0428 ns | 0.0401 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue |  13.33 ns | 0.0844 ns | 0.0790 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue |  13.67 ns | 0.0439 ns | 0.0410 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  32.38 ns | 0.1360 ns | 0.1206 ns |           - |           - |           - |                   - |
                                           From_Double |  11.77 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue |  12.50 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue |  12.60 ns | 0.1147 ns | 0.1073 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  12.38 ns | 0.0502 ns | 0.0470 ns |           - |           - |           - |                   - |
                                            From_Short |  11.47 ns | 0.0468 ns | 0.0437 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue |  12.04 ns | 0.0454 ns | 0.0425 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue |  11.49 ns | 0.0934 ns | 0.0874 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  13.69 ns | 0.0352 ns | 0.0312 ns |           - |           - |           - |                   - |
                                              From_Int |  12.19 ns | 0.0610 ns | 0.0570 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue |  11.41 ns | 0.0413 ns | 0.0367 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  11.93 ns | 0.0429 ns | 0.0401 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  12.38 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                             From_Long |  11.50 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue |  12.50 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue |  14.91 ns | 0.1230 ns | 0.1150 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  13.20 ns | 0.0444 ns | 0.0416 ns |           - |           - |           - |                   - |
                                            From_SByte |  11.66 ns | 0.0346 ns | 0.0307 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue |  11.66 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue |  11.76 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject |  12.40 ns | 0.0675 ns | 0.0631 ns |           - |           - |           - |                   - |
                                            From_Float |  12.18 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue |  11.72 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue |  13.20 ns | 0.0385 ns | 0.0360 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject |  12.53 ns | 0.0549 ns | 0.0514 ns |           - |           - |           - |                   - |
                                           From_String | 730.36 ns | 2.3823 ns | 2.2284 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 741.54 ns | 4.7434 ns | 4.4370 ns |           - |           - |           - |                   - |
                                      From_String_Null |  13.73 ns | 0.0826 ns | 0.0773 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject |  13.02 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
                                     From_String_Empty |  11.64 ns | 0.0696 ns | 0.0651 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort |  11.43 ns | 0.0328 ns | 0.0307 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue |  13.37 ns | 0.0518 ns | 0.0460 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue |  11.46 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject |  12.56 ns | 0.0363 ns | 0.0339 ns |           - |           - |           - |                   - |
                                             From_UInt |  11.39 ns | 0.0284 ns | 0.0252 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue |  11.42 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue |  13.20 ns | 0.0648 ns | 0.0574 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject |  14.96 ns | 0.0754 ns | 0.0669 ns |           - |           - |           - |                   - |
                                            From_ULong |  11.72 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue |  13.09 ns | 0.1219 ns | 0.1140 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue |  12.49 ns | 0.0508 ns | 0.0451 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject |  13.71 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
                                       From_NullObject |  12.38 ns | 0.0588 ns | 0.0521 ns |           - |           - |           - |                   - |
                                           From_DBNull |  10.11 ns | 0.0371 ns | 0.0347 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject |  32.33 ns | 0.1946 ns | 0.1821 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass |  17.49 ns | 0.1104 ns | 0.0979 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject |  15.71 ns | 0.1204 ns | 0.1126 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue |  33.61 ns | 0.0996 ns | 0.0932 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject |  13.71 ns | 0.0293 ns | 0.0260 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass |  13.30 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject |  13.57 ns | 0.0313 ns | 0.0278 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue |  13.44 ns | 0.0253 ns | 0.0198 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject |  14.90 ns | 0.1038 ns | 0.0971 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct |  19.13 ns | 0.0589 ns | 0.0522 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject |  16.36 ns | 0.0855 ns | 0.0800 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue |  19.38 ns | 0.0991 ns | 0.0927 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  18.45 ns | 0.0623 ns | 0.0583 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue |  12.21 ns | 0.0533 ns | 0.0498 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  12.69 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct |  11.41 ns | 0.0501 ns | 0.0469 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject |  33.86 ns | 0.3473 ns | 0.3248 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue |  11.44 ns | 0.0382 ns | 0.0357 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  15.28 ns | 0.0448 ns | 0.0420 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue |  11.43 ns | 0.0488 ns | 0.0456 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  14.89 ns | 0.0743 ns | 0.0695 ns |           - |           - |           - |                   - |
                                             From_Enum |  11.72 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue |  11.37 ns | 0.0470 ns | 0.0416 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue |  11.36 ns | 0.0534 ns | 0.0499 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject |  32.14 ns | 0.1058 ns | 0.0938 ns |           - |           - |           - |                   - |
                                      From_ParentClass |  14.02 ns | 0.0593 ns | 0.0555 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject |  14.40 ns | 0.0738 ns | 0.0616 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue |  13.32 ns | 0.0557 ns | 0.0494 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject |  15.85 ns | 0.0501 ns | 0.0468 ns |           - |           - |           - |                   - |
                                     From_ParentStruct |  50.81 ns | 0.3059 ns | 0.2862 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject |  34.24 ns | 0.2309 ns | 0.2047 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue |  36.06 ns | 0.0814 ns | 0.0680 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject |  15.66 ns | 0.1278 ns | 0.1133 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue |  36.21 ns | 0.1776 ns | 0.1662 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject |  32.19 ns | 0.1461 ns | 0.1367 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool_AsObject: DefaultJob
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_String_Empty_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: DefaultJob
