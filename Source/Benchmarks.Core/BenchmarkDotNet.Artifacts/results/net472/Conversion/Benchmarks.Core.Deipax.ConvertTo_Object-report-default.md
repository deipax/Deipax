
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                                                Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 14.58 ns | 0.0791 ns | 0.0740 ns |      0.0038 |           - |           - |                24 B |
                                    From_Bool_AsObject | 12.33 ns | 0.0498 ns | 0.0441 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 14.40 ns | 0.0453 ns | 0.0401 ns |      0.0038 |           - |           - |                24 B |
                 From_Bool_Nullable_WithValue_AsObject | 12.28 ns | 0.0386 ns | 0.0361 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 13.13 ns | 0.0627 ns | 0.0587 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.13 ns | 0.0263 ns | 0.0246 ns |           - |           - |           - |                   - |
                                             From_Byte | 14.52 ns | 0.0658 ns | 0.0615 ns |      0.0038 |           - |           - |                24 B |
                                    From_Byte_AsObject | 11.18 ns | 0.0746 ns | 0.0698 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 14.36 ns | 0.0472 ns | 0.0441 ns |      0.0038 |           - |           - |                24 B |
                 From_Byte_Nullable_WithValue_AsObject | 11.13 ns | 0.0344 ns | 0.0305 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 13.20 ns | 0.0355 ns | 0.0296 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.16 ns | 0.0390 ns | 0.0365 ns |           - |           - |           - |                   - |
                                             From_Char | 14.56 ns | 0.0442 ns | 0.0391 ns |      0.0038 |           - |           - |                24 B |
                                    From_Char_AsObject | 12.31 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 14.67 ns | 0.0337 ns | 0.0299 ns |      0.0038 |           - |           - |                24 B |
                 From_Char_Nullable_WithValue_AsObject | 12.27 ns | 0.0349 ns | 0.0326 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 12.55 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.14 ns | 0.0235 ns | 0.0184 ns |           - |           - |           - |                   - |
                                         From_DateTime | 16.20 ns | 0.1126 ns | 0.1054 ns |      0.0038 |           - |           - |                24 B |
                                From_DateTime_AsObject | 12.73 ns | 0.0530 ns | 0.0470 ns |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 21.06 ns | 0.0952 ns | 0.0890 ns |      0.0038 |           - |           - |                24 B |
             From_DateTime_Nullable_WithValue_AsObject | 12.29 ns | 0.0468 ns | 0.0437 ns |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 14.70 ns | 0.0426 ns | 0.0398 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 12.30 ns | 0.0723 ns | 0.0677 ns |           - |           - |           - |                   - |
                                          From_Decimal | 16.18 ns | 0.0638 ns | 0.0565 ns |      0.0051 |           - |           - |                32 B |
                                 From_Decimal_AsObject | 11.19 ns | 0.0373 ns | 0.0349 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 16.27 ns | 0.0800 ns | 0.0709 ns |      0.0051 |           - |           - |                32 B |
              From_Decimal_Nullable_WithValue_AsObject | 12.03 ns | 0.0366 ns | 0.0342 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 14.17 ns | 0.0251 ns | 0.0235 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.18 ns | 0.0472 ns | 0.0441 ns |           - |           - |           - |                   - |
                                           From_Double | 14.45 ns | 0.0841 ns | 0.0787 ns |      0.0038 |           - |           - |                24 B |
                                  From_Double_AsObject | 11.14 ns | 0.0400 ns | 0.0354 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 15.94 ns | 0.0930 ns | 0.0870 ns |      0.0038 |           - |           - |                24 B |
               From_Double_Nullable_WithValue_AsObject | 13.06 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 13.95 ns | 0.0337 ns | 0.0281 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 13.03 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
                                            From_Short | 14.69 ns | 0.0900 ns | 0.0842 ns |      0.0038 |           - |           - |                24 B |
                                   From_Short_AsObject | 11.24 ns | 0.0262 ns | 0.0204 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 14.44 ns | 0.0757 ns | 0.0708 ns |      0.0038 |           - |           - |                24 B |
                From_Short_Nullable_WithValue_AsObject | 11.17 ns | 0.0381 ns | 0.0319 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 12.57 ns | 0.0469 ns | 0.0439 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 12.23 ns | 0.0415 ns | 0.0388 ns |           - |           - |           - |                   - |
                                              From_Int | 15.45 ns | 0.0863 ns | 0.0807 ns |      0.0038 |           - |           - |                24 B |
                                     From_Int_AsObject | 11.19 ns | 0.0461 ns | 0.0431 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 14.43 ns | 0.0404 ns | 0.0378 ns |      0.0038 |           - |           - |                24 B |
                  From_Int_Nullable_WithValue_AsObject | 12.32 ns | 0.0804 ns | 0.0752 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 12.53 ns | 0.0340 ns | 0.0302 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.26 ns | 0.0684 ns | 0.0640 ns |           - |           - |           - |                   - |
                                             From_Long | 14.64 ns | 0.0338 ns | 0.0282 ns |      0.0038 |           - |           - |                24 B |
                                    From_Long_AsObject | 11.16 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 15.82 ns | 0.0637 ns | 0.0596 ns |      0.0038 |           - |           - |                24 B |
                 From_Long_Nullable_WithValue_AsObject | 11.19 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 14.22 ns | 0.0467 ns | 0.0414 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.35 ns | 0.0287 ns | 0.0254 ns |           - |           - |           - |                   - |
                                            From_SByte | 14.65 ns | 0.0703 ns | 0.0658 ns |      0.0038 |           - |           - |                24 B |
                                   From_SByte_AsObject | 11.17 ns | 0.0394 ns | 0.0368 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 14.60 ns | 0.1550 ns | 0.1374 ns |      0.0038 |           - |           - |                24 B |
                From_SByte_Nullable_WithValue_AsObject | 12.23 ns | 0.0372 ns | 0.0348 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 12.57 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 11.18 ns | 0.0520 ns | 0.0486 ns |           - |           - |           - |                   - |
                                            From_Float | 14.61 ns | 0.0498 ns | 0.0416 ns |      0.0038 |           - |           - |                24 B |
                                   From_Float_AsObject | 12.25 ns | 0.0755 ns | 0.0706 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 14.48 ns | 0.0716 ns | 0.0635 ns |      0.0038 |           - |           - |                24 B |
                From_Float_Nullable_WithValue_AsObject | 11.18 ns | 0.0500 ns | 0.0467 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 13.46 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 12.65 ns | 0.0499 ns | 0.0442 ns |           - |           - |           - |                   - |
                                           From_String | 11.55 ns | 0.0428 ns | 0.0401 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 12.34 ns | 0.0329 ns | 0.0275 ns |           - |           - |           - |                   - |
                                      From_String_Null | 11.82 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.26 ns | 0.0449 ns | 0.0420 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.90 ns | 0.0672 ns | 0.0629 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject | 11.18 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
                                           From_UShort | 14.58 ns | 0.0759 ns | 0.0710 ns |      0.0038 |           - |           - |                24 B |
                                  From_UShort_AsObject | 12.65 ns | 0.0457 ns | 0.0428 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 14.35 ns | 0.0417 ns | 0.0390 ns |      0.0038 |           - |           - |                24 B |
               From_UShort_Nullable_WithValue_AsObject | 12.56 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 12.56 ns | 0.0545 ns | 0.0483 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.54 ns | 0.0313 ns | 0.0277 ns |           - |           - |           - |                   - |
                                             From_UInt | 14.68 ns | 0.0524 ns | 0.0437 ns |      0.0038 |           - |           - |                24 B |
                                    From_UInt_AsObject | 11.64 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 14.66 ns | 0.0411 ns | 0.0385 ns |      0.0038 |           - |           - |                24 B |
                 From_UInt_Nullable_WithValue_AsObject | 11.20 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 13.32 ns | 0.0226 ns | 0.0200 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 12.10 ns | 0.0643 ns | 0.0601 ns |           - |           - |           - |                   - |
                                            From_ULong | 14.58 ns | 0.0782 ns | 0.0732 ns |      0.0038 |           - |           - |                24 B |
                                   From_ULong_AsObject | 12.27 ns | 0.0335 ns | 0.0314 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 15.84 ns | 0.0412 ns | 0.0386 ns |      0.0038 |           - |           - |                24 B |
                From_ULong_Nullable_WithValue_AsObject | 11.21 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 14.48 ns | 0.0735 ns | 0.0652 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.15 ns | 0.0317 ns | 0.0296 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.15 ns | 0.0367 ns | 0.0307 ns |           - |           - |           - |                   - |
                                           From_DBNull | 14.01 ns | 0.0524 ns | 0.0465 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 12.74 ns | 0.0228 ns | 0.0214 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 13.06 ns | 0.0603 ns | 0.0504 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 12.30 ns | 0.0912 ns | 0.0853 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 12.35 ns | 0.0406 ns | 0.0359 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 12.25 ns | 0.0500 ns | 0.0443 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 11.63 ns | 0.0541 ns | 0.0480 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.04 ns | 0.0449 ns | 0.0398 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 12.36 ns | 0.0243 ns | 0.0203 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 12.29 ns | 0.0451 ns | 0.0422 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 12.76 ns | 0.0233 ns | 0.0218 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 12.25 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 14.64 ns | 0.0583 ns | 0.0545 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 11.16 ns | 0.0296 ns | 0.0276 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.57 ns | 0.0549 ns | 0.0487 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 12.24 ns | 0.0643 ns | 0.0602 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 12.74 ns | 0.0483 ns | 0.0452 ns |      0.0038 |           - |           - |                24 B |
                    From_NonConvertibleStruct_AsObject | 12.27 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 13.06 ns | 0.0372 ns | 0.0311 ns |      0.0038 |           - |           - |                24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 12.27 ns | 0.0408 ns | 0.0382 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 13.37 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.16 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
                                             From_Enum | 13.62 ns | 0.1257 ns | 0.1114 ns |      0.0038 |           - |           - |                24 B |
                                    From_Enum_AsObject | 12.28 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue | 13.12 ns | 0.0576 ns | 0.0510 ns |      0.0038 |           - |           - |                24 B |
                 From_Enum_Nullable_WithValue_AsObject | 12.28 ns | 0.0378 ns | 0.0335 ns |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue | 13.26 ns | 0.0594 ns | 0.0556 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.17 ns | 0.0308 ns | 0.0257 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 13.52 ns | 0.0467 ns | 0.0437 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.42 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 12.25 ns | 0.0889 ns | 0.0832 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.63 ns | 0.0541 ns | 0.0506 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 69.23 ns | 0.3671 ns | 0.3433 ns |      0.0851 |           - |           - |               536 B |
                            From_ParentStruct_AsObject | 11.19 ns | 0.0505 ns | 0.0472 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 71.07 ns | 0.2622 ns | 0.2453 ns |      0.0851 |           - |           - |               536 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 11.16 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 41.37 ns | 0.1231 ns | 0.1091 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.22 ns | 0.0471 ns | 0.0440 ns |           - |           - |           - |                   - |
