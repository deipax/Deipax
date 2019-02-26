
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------------------------------ |----------:|----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
                                             From_Bool | 21.671 ns | 0.1019 ns | 0.0953 ns | 21.664 ns |           - |           - |           - |                   - |
                                    From_Bool_AsObject | 26.885 ns | 0.1417 ns | 0.1326 ns | 26.841 ns |           - |           - |           - |                   - |
                          From_Bool_Nullable_WithValue | 24.671 ns | 0.1168 ns | 0.1093 ns | 24.644 ns |           - |           - |           - |                   - |
                 From_Bool_Nullable_WithValue_AsObject | 26.336 ns | 0.1159 ns | 0.1085 ns | 26.304 ns |           - |           - |           - |                   - |
                            From_Bool_Nullable_NoValue |  9.719 ns | 0.0601 ns | 0.0562 ns |  9.708 ns |           - |           - |           - |                   - |
                   From_Bool_Nullable_NoValue_AsObject |  9.881 ns | 0.0253 ns | 0.0224 ns |  9.871 ns |           - |           - |           - |                   - |
                                             From_Byte | 22.061 ns | 0.0715 ns | 0.0669 ns | 22.062 ns |           - |           - |           - |                   - |
                                    From_Byte_AsObject | 26.073 ns | 0.1229 ns | 0.1089 ns | 26.081 ns |           - |           - |           - |                   - |
                          From_Byte_Nullable_WithValue | 26.686 ns | 0.1088 ns | 0.1018 ns | 26.647 ns |           - |           - |           - |                   - |
                 From_Byte_Nullable_WithValue_AsObject | 26.057 ns | 0.0651 ns | 0.0577 ns | 26.058 ns |           - |           - |           - |                   - |
                            From_Byte_Nullable_NoValue |  9.692 ns | 0.0289 ns | 0.0256 ns |  9.688 ns |           - |           - |           - |                   - |
                   From_Byte_Nullable_NoValue_AsObject |  9.888 ns | 0.0638 ns | 0.0596 ns |  9.882 ns |           - |           - |           - |                   - |
                                             From_Char | 22.189 ns | 0.2147 ns | 0.1903 ns | 22.165 ns |           - |           - |           - |                   - |
                                    From_Char_AsObject | 27.441 ns | 0.1024 ns | 0.0958 ns | 27.442 ns |           - |           - |           - |                   - |
                          From_Char_Nullable_WithValue | 24.549 ns | 0.0740 ns | 0.0692 ns | 24.565 ns |           - |           - |           - |                   - |
                 From_Char_Nullable_WithValue_AsObject | 27.510 ns | 0.1073 ns | 0.1004 ns | 27.499 ns |           - |           - |           - |                   - |
                            From_Char_Nullable_NoValue |  9.724 ns | 0.0586 ns | 0.0548 ns |  9.714 ns |           - |           - |           - |                   - |
                   From_Char_Nullable_NoValue_AsObject |  9.965 ns | 0.0645 ns | 0.0572 ns |  9.985 ns |           - |           - |           - |                   - |
                                         From_DateTime | 24.643 ns | 0.0768 ns | 0.0718 ns | 24.656 ns |           - |           - |           - |                   - |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                      From_DateTime_Nullable_WithValue | 24.708 ns | 0.1101 ns | 0.1030 ns | 24.681 ns |           - |           - |           - |                   - |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |           - |           - |           - |                   - |
                        From_DateTime_Nullable_NoValue | 10.771 ns | 0.0553 ns | 0.0517 ns | 10.758 ns |           - |           - |           - |                   - |
               From_DateTime_Nullable_NoValue_AsObject |  9.967 ns | 0.0476 ns | 0.0422 ns |  9.971 ns |           - |           - |           - |                   - |
                                          From_Decimal | 34.781 ns | 0.3393 ns | 0.3008 ns | 34.877 ns |           - |           - |           - |                   - |
                                 From_Decimal_AsObject | 37.677 ns | 0.2897 ns | 0.2710 ns | 37.688 ns |           - |           - |           - |                   - |
                       From_Decimal_Nullable_WithValue | 34.604 ns | 0.1870 ns | 0.1658 ns | 34.586 ns |           - |           - |           - |                   - |
              From_Decimal_Nullable_WithValue_AsObject | 36.774 ns | 0.1930 ns | 0.1805 ns | 36.770 ns |           - |           - |           - |                   - |
                         From_Decimal_Nullable_NoValue | 10.749 ns | 0.0540 ns | 0.0505 ns | 10.740 ns |           - |           - |           - |                   - |
                From_Decimal_Nullable_NoValue_AsObject |  9.892 ns | 0.0538 ns | 0.0503 ns |  9.901 ns |           - |           - |           - |                   - |
                                           From_Double | 24.425 ns | 0.0473 ns | 0.0419 ns | 24.434 ns |           - |           - |           - |                   - |
                                  From_Double_AsObject | 27.584 ns | 0.0884 ns | 0.0827 ns | 27.580 ns |           - |           - |           - |                   - |
                        From_Double_Nullable_WithValue | 27.191 ns | 0.0962 ns | 0.0853 ns | 27.184 ns |           - |           - |           - |                   - |
               From_Double_Nullable_WithValue_AsObject | 27.525 ns | 0.1381 ns | 0.1292 ns | 27.484 ns |           - |           - |           - |                   - |
                          From_Double_Nullable_NoValue | 10.745 ns | 0.0551 ns | 0.0516 ns | 10.746 ns |           - |           - |           - |                   - |
                 From_Double_Nullable_NoValue_AsObject |  9.876 ns | 0.0701 ns | 0.0656 ns |  9.877 ns |           - |           - |           - |                   - |
                                            From_Short | 21.733 ns | 0.0864 ns | 0.0808 ns | 21.722 ns |           - |           - |           - |                   - |
                                   From_Short_AsObject | 27.815 ns | 0.1450 ns | 0.1286 ns | 27.794 ns |           - |           - |           - |                   - |
                         From_Short_Nullable_WithValue | 24.464 ns | 0.0842 ns | 0.0788 ns | 24.456 ns |           - |           - |           - |                   - |
                From_Short_Nullable_WithValue_AsObject | 26.468 ns | 0.1582 ns | 0.1480 ns | 26.423 ns |           - |           - |           - |                   - |
                           From_Short_Nullable_NoValue | 10.134 ns | 0.0618 ns | 0.0578 ns | 10.134 ns |           - |           - |           - |                   - |
                  From_Short_Nullable_NoValue_AsObject |  9.886 ns | 0.0728 ns | 0.0608 ns |  9.893 ns |           - |           - |           - |                   - |
                                              From_Int | 19.640 ns | 0.1071 ns | 0.1002 ns | 19.623 ns |           - |           - |           - |                   - |
                                     From_Int_AsObject | 24.017 ns | 0.1150 ns | 0.1076 ns | 24.005 ns |           - |           - |           - |                   - |
                           From_Int_Nullable_WithValue | 22.074 ns | 0.1149 ns | 0.1018 ns | 22.091 ns |           - |           - |           - |                   - |
                  From_Int_Nullable_WithValue_AsObject | 24.348 ns | 0.4821 ns | 0.5359 ns | 24.101 ns |           - |           - |           - |                   - |
                             From_Int_Nullable_NoValue |  9.663 ns | 0.0362 ns | 0.0339 ns |  9.671 ns |           - |           - |           - |                   - |
                    From_Int_Nullable_NoValue_AsObject |  9.866 ns | 0.0334 ns | 0.0312 ns |  9.872 ns |           - |           - |           - |                   - |
                                             From_Long | 24.403 ns | 0.0805 ns | 0.0713 ns | 24.409 ns |           - |           - |           - |                   - |
                                    From_Long_AsObject | 26.794 ns | 0.0732 ns | 0.0684 ns | 26.790 ns |           - |           - |           - |                   - |
                          From_Long_Nullable_WithValue | 27.518 ns | 0.1160 ns | 0.1085 ns | 27.524 ns |           - |           - |           - |                   - |
                 From_Long_Nullable_WithValue_AsObject | 27.465 ns | 0.1220 ns | 0.1082 ns | 27.507 ns |           - |           - |           - |                   - |
                            From_Long_Nullable_NoValue | 10.645 ns | 0.0663 ns | 0.0620 ns | 10.632 ns |           - |           - |           - |                   - |
                   From_Long_Nullable_NoValue_AsObject |  9.876 ns | 0.0522 ns | 0.0488 ns |  9.865 ns |           - |           - |           - |                   - |
                                            From_SByte | 21.800 ns | 0.0886 ns | 0.0829 ns | 21.816 ns |           - |           - |           - |                   - |
                                   From_SByte_AsObject | 26.262 ns | 0.0992 ns | 0.0828 ns | 26.267 ns |           - |           - |           - |                   - |
                         From_SByte_Nullable_WithValue | 24.467 ns | 0.0781 ns | 0.0692 ns | 24.453 ns |           - |           - |           - |                   - |
                From_SByte_Nullable_WithValue_AsObject | 26.931 ns | 0.1176 ns | 0.1100 ns | 26.934 ns |           - |           - |           - |                   - |
                           From_SByte_Nullable_NoValue | 10.173 ns | 0.0679 ns | 0.0635 ns | 10.180 ns |           - |           - |           - |                   - |
                  From_SByte_Nullable_NoValue_AsObject | 10.994 ns | 0.0351 ns | 0.0311 ns | 10.999 ns |           - |           - |           - |                   - |
                                            From_Float | 23.998 ns | 0.0762 ns | 0.0713 ns | 23.975 ns |           - |           - |           - |                   - |
                                   From_Float_AsObject | 27.362 ns | 0.0698 ns | 0.0618 ns | 27.367 ns |           - |           - |           - |                   - |
                         From_Float_Nullable_WithValue | 26.561 ns | 0.4378 ns | 0.3881 ns | 26.414 ns |           - |           - |           - |                   - |
                From_Float_Nullable_WithValue_AsObject | 28.929 ns | 0.5319 ns | 0.4153 ns | 28.983 ns |           - |           - |           - |                   - |
                           From_Float_Nullable_NoValue | 10.658 ns | 0.2793 ns | 0.6013 ns | 10.393 ns |           - |           - |           - |                   - |
                  From_Float_Nullable_NoValue_AsObject | 10.594 ns | 0.0931 ns | 0.0871 ns | 10.592 ns |           - |           - |           - |                   - |
                                           From_String | 29.847 ns | 0.1192 ns | 0.1115 ns | 29.794 ns |           - |           - |           - |                   - |
                                  From_String_AsObject | 35.141 ns | 0.4904 ns | 0.4587 ns | 34.880 ns |           - |           - |           - |                   - |
                                      From_String_Null | 10.421 ns | 0.0905 ns | 0.0802 ns | 10.418 ns |           - |           - |           - |                   - |
                             From_String_Null_AsObject | 10.488 ns | 0.0622 ns | 0.0552 ns | 10.503 ns |           - |           - |           - |                   - |
                                     From_String_Empty | 10.599 ns | 0.1327 ns | 0.1241 ns | 10.605 ns |           - |           - |           - |                   - |
                            From_String_Empty_AsObject | 20.211 ns | 0.1587 ns | 0.1407 ns | 20.157 ns |           - |           - |           - |                   - |
                                           From_UShort | 23.042 ns | 0.0451 ns | 0.0376 ns | 23.036 ns |           - |           - |           - |                   - |
                                  From_UShort_AsObject | 27.775 ns | 0.1303 ns | 0.1219 ns | 27.768 ns |           - |           - |           - |                   - |
                        From_UShort_Nullable_WithValue | 27.007 ns | 0.1794 ns | 0.1678 ns | 27.019 ns |           - |           - |           - |                   - |
               From_UShort_Nullable_WithValue_AsObject | 27.694 ns | 0.0894 ns | 0.0836 ns | 27.656 ns |           - |           - |           - |                   - |
                          From_UShort_Nullable_NoValue | 10.420 ns | 0.0191 ns | 0.0178 ns | 10.419 ns |           - |           - |           - |                   - |
                 From_UShort_Nullable_NoValue_AsObject | 10.412 ns | 0.0111 ns | 0.0086 ns | 10.412 ns |           - |           - |           - |                   - |
                                             From_UInt | 25.855 ns | 0.0785 ns | 0.0696 ns | 25.856 ns |           - |           - |           - |                   - |
                                    From_UInt_AsObject | 28.624 ns | 0.0256 ns | 0.0227 ns | 28.624 ns |           - |           - |           - |                   - |
                          From_UInt_Nullable_WithValue | 25.645 ns | 0.0191 ns | 0.0169 ns | 25.640 ns |           - |           - |           - |                   - |
                 From_UInt_Nullable_WithValue_AsObject | 28.156 ns | 0.1551 ns | 0.1375 ns | 28.115 ns |           - |           - |           - |                   - |
                            From_UInt_Nullable_NoValue | 10.198 ns | 0.0120 ns | 0.0112 ns | 10.199 ns |           - |           - |           - |                   - |
                   From_UInt_Nullable_NoValue_AsObject | 10.417 ns | 0.0164 ns | 0.0137 ns | 10.415 ns |           - |           - |           - |                   - |
                                            From_ULong | 25.273 ns | 0.0358 ns | 0.0299 ns | 25.261 ns |           - |           - |           - |                   - |
                                   From_ULong_AsObject | 28.216 ns | 0.1613 ns | 0.1430 ns | 28.178 ns |           - |           - |           - |                   - |
                         From_ULong_Nullable_WithValue | 28.795 ns | 0.0891 ns | 0.0744 ns | 28.810 ns |           - |           - |           - |                   - |
                From_ULong_Nullable_WithValue_AsObject | 28.011 ns | 0.0281 ns | 0.0249 ns | 28.009 ns |           - |           - |           - |                   - |
                           From_ULong_Nullable_NoValue | 11.244 ns | 0.0232 ns | 0.0217 ns | 11.244 ns |           - |           - |           - |                   - |
                  From_ULong_Nullable_NoValue_AsObject | 10.482 ns | 0.0476 ns | 0.0422 ns | 10.469 ns |           - |           - |           - |                   - |
                                       From_NullObject | 10.412 ns | 0.0137 ns | 0.0114 ns | 10.412 ns |           - |           - |           - |                   - |
                                           From_DBNull | 10.362 ns | 0.0092 ns | 0.0081 ns | 10.361 ns |           - |           - |           - |                   - |
                                  From_DBNull_AsObject | 10.444 ns | 0.0649 ns | 0.0607 ns | 10.417 ns |           - |           - |           - |                   - |
                                 From_ConvertibleClass | 24.812 ns | 0.0623 ns | 0.0486 ns | 24.803 ns |           - |           - |           - |                   - |
                        From_ConvertibleClass_AsObject | 27.054 ns | 0.0410 ns | 0.0383 ns | 27.040 ns |           - |           - |           - |                   - |
                         From_ConvertibleClass_NoValue | 10.326 ns | 0.0130 ns | 0.0108 ns | 10.325 ns |           - |           - |           - |                   - |
                From_ConvertibleClass_NoValue_AsObject | 11.288 ns | 0.0177 ns | 0.0157 ns | 11.282 ns |           - |           - |           - |                   - |
                              From_NonConvertibleClass | 20.829 ns | 0.0329 ns | 0.0257 ns | 20.830 ns |           - |           - |           - |                   - |
                     From_NonConvertibleClass_AsObject | 25.979 ns | 0.1344 ns | 0.1122 ns | 25.918 ns |           - |           - |           - |                   - |
                      From_NonConvertibleClass_NoValue | 10.661 ns | 0.0179 ns | 0.0149 ns | 10.658 ns |           - |           - |           - |                   - |
             From_NonConvertibleClass_NoValue_AsObject | 10.496 ns | 0.0077 ns | 0.0065 ns | 10.496 ns |           - |           - |           - |                   - |
                                From_ConvertibleStruct | 30.996 ns | 0.2051 ns | 0.1918 ns | 30.991 ns |      0.0038 |           - |           - |                24 B |
                       From_ConvertibleStruct_AsObject | 30.796 ns | 0.0326 ns | 0.0305 ns | 30.786 ns |           - |           - |           - |                   - |
             From_ConvertibleStruct_Nullable_WithValue | 31.077 ns | 0.1525 ns | 0.1274 ns | 31.050 ns |      0.0038 |           - |           - |                24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.917 ns | 0.5324 ns | 0.4981 ns | 27.780 ns |           - |           - |           - |                   - |
               From_ConvertibleStruct_Nullable_NoValue | 12.983 ns | 0.1759 ns | 0.1646 ns | 12.977 ns |           - |           - |           - |                   - |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 10.513 ns | 0.0862 ns | 0.0720 ns | 10.490 ns |           - |           - |           - |                   - |
                             From_NonConvertibleStruct | 22.899 ns | 0.0963 ns | 0.0901 ns | 22.865 ns |           - |           - |           - |                   - |
                    From_NonConvertibleStruct_AsObject | 26.302 ns | 0.2284 ns | 0.1907 ns | 26.192 ns |           - |           - |           - |                   - |
          From_NonConvertibleStruct_Nullable_WithValue | 23.032 ns | 0.1971 ns | 0.1747 ns | 22.979 ns |           - |           - |           - |                   - |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 26.875 ns | 0.1138 ns | 0.0950 ns | 26.864 ns |           - |           - |           - |                   - |
            From_NonConvertibleStruct_Nullable_NoValue | 10.779 ns | 0.0767 ns | 0.0680 ns | 10.805 ns |           - |           - |           - |                   - |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 10.527 ns | 0.1434 ns | 0.1341 ns | 10.479 ns |           - |           - |           - |                   - |
                                             From_Enum | 11.160 ns | 0.0274 ns | 0.0257 ns | 11.157 ns |           - |           - |           - |                   - |
                                    From_Enum_AsObject | 11.065 ns | 0.0782 ns | 0.0694 ns | 11.040 ns |           - |           - |           - |                   - |
                          From_Enum_Nullable_WithValue | 10.377 ns | 0.0549 ns | 0.0487 ns | 10.364 ns |           - |           - |           - |                   - |
                 From_Enum_Nullable_WithValue_AsObject | 11.007 ns | 0.0104 ns | 0.0097 ns | 11.005 ns |           - |           - |           - |                   - |
                            From_Enum_Nullable_NoValue | 10.343 ns | 0.1540 ns | 0.1365 ns | 10.293 ns |           - |           - |           - |                   - |
                   From_Enum_Nullable_NoValue_AsObject | 10.411 ns | 0.0487 ns | 0.0407 ns | 10.398 ns |           - |           - |           - |                   - |
                                      From_ParentClass | 22.629 ns | 0.0564 ns | 0.0440 ns | 22.645 ns |           - |           - |           - |                   - |
                             From_ParentClass_AsObject | 26.648 ns | 0.1460 ns | 0.1366 ns | 26.602 ns |           - |           - |           - |                   - |
                              From_ParentClass_NoValue | 10.385 ns | 0.0696 ns | 0.0651 ns | 10.351 ns |           - |           - |           - |                   - |
                     From_ParentClass_NoValue_AsObject | 10.639 ns | 0.0270 ns | 0.0225 ns | 10.640 ns |           - |           - |           - |                   - |
                                     From_ParentStruct | 86.005 ns | 0.1352 ns | 0.1264 ns | 85.967 ns |           - |           - |           - |                   - |
                            From_ParentStruct_AsObject | 26.513 ns | 0.1703 ns | 0.1509 ns | 26.505 ns |           - |           - |           - |                   - |
                  From_ParentStruct_Nullable_WithValue | 89.149 ns | 1.9859 ns | 1.8576 ns | 88.183 ns |           - |           - |           - |                   - |
         From_ParentStruct_Nullable_WithValue_AsObject | 26.595 ns | 0.3018 ns | 0.2823 ns | 26.535 ns |           - |           - |           - |                   - |
                    From_ParentStruct_Nullable_NoValue | 52.215 ns | 0.3290 ns | 0.3077 ns | 52.121 ns |           - |           - |           - |                   - |
           From_ParentStruct_Nullable_NoValue_AsObject | 10.508 ns | 0.1082 ns | 0.0903 ns | 10.466 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
