
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 10.891 ns | 0.1042 ns | 0.0975 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 15.403 ns | 0.1295 ns | 0.1148 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 11.172 ns | 0.1564 ns | 0.1463 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 16.446 ns | 0.1599 ns | 0.1495 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue | 10.793 ns | 0.0805 ns | 0.0714 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject | 11.924 ns | 0.0230 ns | 0.0192 ns |           - |           - |           - |                   - |
                                             From_Byte | 10.665 ns | 0.0517 ns | 0.0483 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 15.204 ns | 0.0208 ns | 0.0174 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 10.849 ns | 0.0365 ns | 0.0305 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 15.122 ns | 0.0280 ns | 0.0234 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue | 10.928 ns | 0.0300 ns | 0.0281 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject | 11.948 ns | 0.0288 ns | 0.0256 ns |           - |           - |           - |                   - |
                                             From_Char | 10.569 ns | 0.0410 ns | 0.0383 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 16.013 ns | 0.0673 ns | 0.0629 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 10.838 ns | 0.0338 ns | 0.0299 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 16.054 ns | 0.0264 ns | 0.0220 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue | 10.897 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject | 11.893 ns | 0.0445 ns | 0.0395 ns |           - |           - |           - |                   - |
                                         From_DateTime | 11.465 ns | 0.0482 ns | 0.0451 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 11.254 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 11.248 ns | 0.0690 ns | 0.0646 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject | 11.863 ns | 0.0309 ns | 0.0289 ns |           - |           - |           - |                   - |
                                          From_Decimal | 19.641 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 24.625 ns | 0.1153 ns | 0.1078 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 21.168 ns | 0.1086 ns | 0.0963 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 24.860 ns | 0.1187 ns | 0.1110 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 11.888 ns | 0.0487 ns | 0.0456 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject | 11.890 ns | 0.0491 ns | 0.0459 ns |           - |           - |           - |                   - |
                                           From_Double | 11.043 ns | 0.0734 ns | 0.0651 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 18.114 ns | 0.1480 ns | 0.1384 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 13.420 ns | 0.0672 ns | 0.0561 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 16.085 ns | 0.1026 ns | 0.0909 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 12.040 ns | 0.0183 ns | 0.0143 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject | 12.333 ns | 0.0504 ns | 0.0447 ns |           - |           - |           - |                   - |
                                            From_Short | 10.621 ns | 0.0528 ns | 0.0494 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 15.248 ns | 0.0840 ns | 0.0745 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 10.909 ns | 0.0406 ns | 0.0380 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 15.271 ns | 0.0724 ns | 0.0677 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.732 ns | 0.0499 ns | 0.0467 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject | 11.879 ns | 0.0455 ns | 0.0426 ns |           - |           - |           - |                   - |
                                              From_Int | 10.139 ns | 0.0094 ns | 0.0073 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 12.499 ns | 0.0365 ns | 0.0323 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 10.475 ns | 0.0778 ns | 0.0728 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 12.450 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue | 10.265 ns | 0.0243 ns | 0.0203 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject | 12.020 ns | 0.0401 ns | 0.0355 ns |           - |           - |           - |                   - |
                                             From_Long | 10.918 ns | 0.0426 ns | 0.0332 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 16.374 ns | 0.0664 ns | 0.0588 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 13.261 ns | 0.0519 ns | 0.0433 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 16.341 ns | 0.0432 ns | 0.0404 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 12.026 ns | 0.0403 ns | 0.0377 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject | 12.051 ns | 0.0600 ns | 0.0561 ns |           - |           - |           - |                   - |
                                            From_SByte | 10.695 ns | 0.0351 ns | 0.0329 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 15.431 ns | 0.0599 ns | 0.0531 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 11.015 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 15.119 ns | 0.0341 ns | 0.0319 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 11.001 ns | 0.0313 ns | 0.0292 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 12.033 ns | 0.0445 ns | 0.0416 ns |           - |           - |           - |                   - |
                                            From_Float | 11.086 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 16.497 ns | 0.0702 ns | 0.0657 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 12.699 ns | 0.0564 ns | 0.0500 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 16.443 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 11.111 ns | 0.0878 ns | 0.0778 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 11.963 ns | 0.0215 ns | 0.0201 ns |           - |           - |           - |                   - |
                                           From_String | 91.474 ns | 0.5940 ns | 0.5266 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 57.850 ns | 0.1518 ns | 0.1345 ns |           - |           - |           - |                   - |
                                      From_String_Null | 13.047 ns | 0.0343 ns | 0.0321 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 12.831 ns | 0.0299 ns | 0.0279 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 12.231 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject |        NA |        NA |        NA |           - |           - |           - |                   - |
                                           From_UShort | 10.828 ns | 0.0361 ns | 0.0338 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 15.137 ns | 0.0396 ns | 0.0371 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 10.955 ns | 0.0612 ns | 0.0511 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 15.026 ns | 0.0654 ns | 0.0611 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.668 ns | 0.0236 ns | 0.0197 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 11.831 ns | 0.0077 ns | 0.0064 ns |           - |           - |           - |                   - |
                                             From_UInt | 10.324 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 15.477 ns | 0.0970 ns | 0.0907 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 11.043 ns | 0.0775 ns | 0.0687 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 16.223 ns | 0.0635 ns | 0.0594 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.735 ns | 0.0385 ns | 0.0341 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 11.849 ns | 0.0515 ns | 0.0456 ns |           - |           - |           - |                   - |
                                            From_ULong | 10.477 ns | 0.0137 ns | 0.0107 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 15.982 ns | 0.0649 ns | 0.0607 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 13.186 ns | 0.1576 ns | 0.1474 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 16.010 ns | 0.0542 ns | 0.0481 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.797 ns | 0.0472 ns | 0.0419 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 11.932 ns | 0.0101 ns | 0.0084 ns |           - |           - |           - |                   - |
                                       From_NullObject | 11.901 ns | 0.0319 ns | 0.0298 ns |           - |           - |           - |                   - |
                                           From_DBNull |  9.112 ns | 0.0395 ns | 0.0369 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 11.838 ns | 0.0329 ns | 0.0308 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 12.580 ns | 0.0373 ns | 0.0349 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 14.354 ns | 0.0903 ns | 0.0845 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 11.743 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.815 ns | 0.0169 ns | 0.0150 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 10.369 ns | 0.0664 ns | 0.0621 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 13.273 ns | 0.0485 ns | 0.0430 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.360 ns | 0.0462 ns | 0.0432 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 11.873 ns | 0.0476 ns | 0.0445 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 16.168 ns | 0.0456 ns | 0.0404 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 14.798 ns | 0.1010 ns | 0.0895 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 17.791 ns | 0.0580 ns | 0.0514 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 14.697 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 11.694 ns | 0.0093 ns | 0.0078 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 11.813 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 11.478 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 13.207 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 11.538 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 13.212 ns | 0.0193 ns | 0.0162 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 11.562 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 11.802 ns | 0.0088 ns | 0.0073 ns |           - |           - |           - |                   - |
                                             From_Enum | 12.159 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 42.888 ns | 0.0862 ns | 0.0720 ns |      0.0038 |           - |           - |                24 B |
                          From_Enum_Nullable_WithValue | 11.595 ns | 0.0136 ns | 0.0128 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 38.194 ns | 0.0854 ns | 0.0799 ns |      0.0038 |           - |           - |                24 B |
                            From_Enum_Nullable_NoValue | 11.603 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 11.814 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 10.305 ns | 0.0059 ns | 0.0056 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 13.758 ns | 0.0151 ns | 0.0142 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.318 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 11.812 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 37.474 ns | 0.0493 ns | 0.0437 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 13.715 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 37.739 ns | 0.0480 ns | 0.0401 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 13.470 ns | 0.0135 ns | 0.0120 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 37.732 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 11.814 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Int.From_String_Empty_AsObject: DefaultJob
