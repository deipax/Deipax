
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  36.10 ns | 0.2980 ns | 0.2787 ns |      - |       0 B |
                                    From_Bool_AsObject |  47.64 ns | 0.1123 ns | 0.1050 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  36.57 ns | 0.1951 ns | 0.1825 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  46.98 ns | 0.1222 ns | 0.1083 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.03 ns | 0.1170 ns | 0.1095 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.77 ns | 0.0774 ns | 0.0724 ns |      - |       0 B |
                                             From_Byte |  36.15 ns | 0.2191 ns | 0.1943 ns |      - |       0 B |
                                    From_Byte_AsObject |  46.71 ns | 0.0953 ns | 0.0796 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  35.68 ns | 0.3730 ns | 0.3307 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  46.68 ns | 0.0543 ns | 0.0481 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.02 ns | 0.0945 ns | 0.0884 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.42 ns | 0.0289 ns | 0.0256 ns |      - |       0 B |
                                             From_Char |  33.26 ns | 0.0373 ns | 0.0291 ns |      - |       0 B |
                                    From_Char_AsObject |  46.79 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  35.17 ns | 0.2034 ns | 0.1903 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  46.52 ns | 0.0272 ns | 0.0227 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.86 ns | 0.0660 ns | 0.0585 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.07 ns | 0.3943 ns | 0.4843 ns |      - |       0 B |
                                         From_DateTime |  34.02 ns | 0.5626 ns | 0.4987 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  35.50 ns | 0.5877 ns | 0.5498 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.44 ns | 0.1019 ns | 0.0953 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.26 ns | 0.0119 ns | 0.0093 ns |      - |       0 B |
                                          From_Decimal |  47.80 ns | 0.4880 ns | 0.4075 ns |      - |       0 B |
                                 From_Decimal_AsObject |  59.25 ns | 0.3663 ns | 0.3059 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  49.29 ns | 0.2633 ns | 0.2463 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  59.40 ns | 0.1914 ns | 0.1790 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.75 ns | 0.0707 ns | 0.0627 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.75 ns | 0.0853 ns | 0.0712 ns |      - |       0 B |
                                           From_Double |  37.75 ns | 0.0583 ns | 0.0517 ns |      - |       0 B |
                                  From_Double_AsObject |  52.57 ns | 0.0289 ns | 0.0226 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  39.29 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  51.85 ns | 0.0279 ns | 0.0233 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.32 ns | 0.0280 ns | 0.0218 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.76 ns | 0.0306 ns | 0.0256 ns |      - |       0 B |
                                            From_Short |  35.63 ns | 0.0281 ns | 0.0219 ns |      - |       0 B |
                                   From_Short_AsObject |  47.02 ns | 0.0176 ns | 0.0138 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  35.97 ns | 0.0109 ns | 0.0085 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  46.77 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.82 ns | 0.0111 ns | 0.0092 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.67 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                                              From_Int |  34.16 ns | 0.0683 ns | 0.0533 ns |      - |       0 B |
                                     From_Int_AsObject |  39.87 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  35.62 ns | 0.1077 ns | 0.1007 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  39.57 ns | 0.0822 ns | 0.0769 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.30 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.71 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
                                             From_Long |  36.32 ns | 0.0233 ns | 0.0194 ns |      - |       0 B |
                                    From_Long_AsObject |  49.10 ns | 0.0955 ns | 0.0894 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  38.02 ns | 0.0169 ns | 0.0141 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  48.47 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.44 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.67 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                                            From_SByte |  35.39 ns | 0.0535 ns | 0.0474 ns |      - |       0 B |
                                   From_SByte_AsObject |  46.75 ns | 0.0501 ns | 0.0419 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  35.49 ns | 0.0208 ns | 0.0162 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  47.63 ns | 0.1459 ns | 0.1364 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.98 ns | 0.0356 ns | 0.0315 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.24 ns | 0.0117 ns | 0.0097 ns |      - |       0 B |
                                            From_Float |  37.77 ns | 0.0615 ns | 0.0514 ns |      - |       0 B |
                                   From_Float_AsObject |  50.26 ns | 0.0810 ns | 0.0718 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  37.62 ns | 0.0227 ns | 0.0178 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  50.72 ns | 0.0227 ns | 0.0202 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.71 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.22 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                                           From_String |  57.63 ns | 0.0384 ns | 0.0321 ns |      - |       0 B |
                                  From_String_AsObject |  45.90 ns | 0.6177 ns | 0.5778 ns |      - |       0 B |
                                      From_String_Null |  14.73 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.72 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                                     From_String_Empty |  16.68 ns | 0.0287 ns | 0.0224 ns |      - |       0 B |
                            From_String_Empty_AsObject |  23.02 ns | 0.0444 ns | 0.0394 ns |      - |       0 B |
                                           From_UShort |  35.40 ns | 0.0218 ns | 0.0182 ns |      - |       0 B |
                                  From_UShort_AsObject |  46.90 ns | 0.3524 ns | 0.3124 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  36.75 ns | 0.1989 ns | 0.1861 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  47.80 ns | 0.0631 ns | 0.0559 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.08 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.77 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
                                             From_UInt |  36.17 ns | 0.0510 ns | 0.0426 ns |      - |       0 B |
                                    From_UInt_AsObject |  48.01 ns | 0.0152 ns | 0.0119 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  36.75 ns | 0.0567 ns | 0.0502 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  47.26 ns | 0.0507 ns | 0.0423 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.96 ns | 0.0250 ns | 0.0208 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.42 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                                            From_ULong |  36.32 ns | 0.0876 ns | 0.0732 ns |      - |       0 B |
                                   From_ULong_AsObject |  48.26 ns | 0.0130 ns | 0.0116 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  37.55 ns | 0.0203 ns | 0.0169 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  48.05 ns | 0.0967 ns | 0.0905 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.38 ns | 0.0698 ns | 0.0653 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.44 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                                       From_NullObject |  15.67 ns | 0.0079 ns | 0.0061 ns |      - |       0 B |
                                           From_DBNull |  16.34 ns | 0.0421 ns | 0.0373 ns |      - |       0 B |
                                  From_DBNull_AsObject |  15.67 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                                 From_ConvertibleClass |  43.26 ns | 0.0527 ns | 0.0493 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  44.41 ns | 0.0863 ns | 0.0808 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.52 ns | 0.0089 ns | 0.0070 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.76 ns | 0.0719 ns | 0.0601 ns |      - |       0 B |
                              From_NonConvertibleClass |  35.54 ns | 0.1325 ns | 0.1239 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  40.24 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.39 ns | 0.0711 ns | 0.0665 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.29 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                                From_ConvertibleStruct |  44.57 ns | 0.0484 ns | 0.0452 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  45.63 ns | 0.0333 ns | 0.0278 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  46.19 ns | 1.0840 ns | 0.9610 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  45.98 ns | 0.2738 ns | 0.2286 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.81 ns | 0.0758 ns | 0.0633 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.67 ns | 0.0145 ns | 0.0121 ns |      - |       0 B |
                             From_NonConvertibleStruct |  34.43 ns | 0.0336 ns | 0.0280 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  39.95 ns | 0.2469 ns | 0.2062 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  33.98 ns | 0.1473 ns | 0.1306 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  41.69 ns | 0.1093 ns | 0.1022 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.88 ns | 0.0351 ns | 0.0274 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.88 ns | 0.1331 ns | 0.1180 ns |      - |       0 B |
                                             From_Enum |  13.50 ns | 0.0381 ns | 0.0337 ns |      - |       0 B |
                                    From_Enum_AsObject |  16.68 ns | 0.0624 ns | 0.0451 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue |  14.10 ns | 0.0323 ns | 0.0302 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  16.70 ns | 0.0982 ns | 0.0919 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue |  14.00 ns | 0.0362 ns | 0.0338 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.88 ns | 0.0972 ns | 0.0910 ns |      - |       0 B |
                                      From_ParentClass |  36.67 ns | 0.0514 ns | 0.0456 ns |      - |       0 B |
                             From_ParentClass_AsObject |  40.93 ns | 0.1993 ns | 0.1865 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.21 ns | 0.0362 ns | 0.0321 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  15.68 ns | 0.0101 ns | 0.0079 ns |      - |       0 B |
                                     From_ParentStruct | 157.69 ns | 0.5982 ns | 0.5303 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  40.05 ns | 0.0862 ns | 0.0719 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 163.61 ns | 0.7501 ns | 0.6649 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  40.29 ns | 0.2263 ns | 0.1889 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  96.35 ns | 1.2540 ns | 1.1116 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  16.01 ns | 0.1804 ns | 0.1687 ns |      - |       0 B |

Benchmarks with issues:
  ConvertToEnum.From_DateTime_AsObject: DefaultJob
  ConvertToEnum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
