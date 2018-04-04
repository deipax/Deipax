
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                    From_Bool_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 13.69 ns | 0.2906 ns | 0.2984 ns | 13.71 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.28 ns | 0.1126 ns | 0.0940 ns | 16.28 ns |      - |       0 B |
                                             From_Byte | 13.41 ns | 0.2285 ns | 0.2137 ns | 13.36 ns |      - |       0 B |
                                    From_Byte_AsObject | 30.17 ns | 0.3723 ns | 0.3482 ns | 30.04 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 17.06 ns | 0.2995 ns | 0.2501 ns | 17.18 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 29.89 ns | 0.0768 ns | 0.0641 ns | 29.87 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.43 ns | 0.0861 ns | 0.0805 ns | 13.45 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 18.18 ns | 0.0792 ns | 0.0702 ns | 18.15 ns |      - |       0 B |
                                             From_Char | 13.34 ns | 0.2314 ns | 0.2164 ns | 13.24 ns |      - |       0 B |
                                    From_Char_AsObject | 17.52 ns | 0.1667 ns | 0.1478 ns | 17.46 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.68 ns | 0.0833 ns | 0.0696 ns | 13.68 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 17.90 ns | 0.0576 ns | 0.0450 ns | 17.89 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.92 ns | 0.1146 ns | 0.0957 ns | 13.93 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.39 ns | 0.1737 ns | 0.1540 ns | 16.43 ns |      - |       0 B |
                                         From_DateTime | 14.31 ns | 0.3155 ns | 0.2635 ns | 14.18 ns |      - |       0 B |
                                From_DateTime_AsObject | 21.39 ns | 0.1782 ns | 0.1488 ns | 21.33 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue | 17.52 ns | 0.1341 ns | 0.1254 ns | 17.47 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject | 21.83 ns | 0.4563 ns | 0.4268 ns | 21.90 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue | 14.70 ns | 0.1479 ns | 0.1311 ns | 14.67 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.68 ns | 0.2967 ns | 0.2775 ns | 16.68 ns |      - |       0 B |
                                          From_Decimal |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                 From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 14.07 ns | 0.0607 ns | 0.0538 ns | 14.05 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.48 ns | 0.3836 ns | 0.4567 ns | 17.38 ns |      - |       0 B |
                                           From_Double |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                  From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 14.58 ns | 0.3141 ns | 0.2623 ns | 14.52 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.87 ns | 0.3296 ns | 0.3083 ns | 18.92 ns |      - |       0 B |
                                            From_Short | 14.15 ns | 0.3114 ns | 0.5203 ns | 13.90 ns |      - |       0 B |
                                   From_Short_AsObject | 31.03 ns | 0.6297 ns | 0.5890 ns | 31.44 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 18.23 ns | 0.1926 ns | 0.1801 ns | 18.17 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 31.49 ns | 0.2266 ns | 0.2009 ns | 31.43 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.82 ns | 0.1123 ns | 0.1050 ns | 13.82 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.31 ns | 0.0728 ns | 0.0681 ns | 16.29 ns |      - |       0 B |
                                              From_Int | 16.02 ns | 0.3511 ns | 0.4440 ns | 15.88 ns |      - |       0 B |
                                     From_Int_AsObject | 31.22 ns | 0.1549 ns | 0.1373 ns | 31.19 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 18.81 ns | 0.1808 ns | 0.1692 ns | 18.81 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 31.11 ns | 0.1134 ns | 0.0885 ns | 31.11 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.58 ns | 0.3219 ns | 0.3306 ns | 14.80 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.35 ns | 0.1121 ns | 0.0994 ns | 16.32 ns |      - |       0 B |
                                             From_Long | 15.23 ns | 0.1504 ns | 0.1407 ns | 15.20 ns |      - |       0 B |
                                    From_Long_AsObject | 30.82 ns | 0.0661 ns | 0.0586 ns | 30.82 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 19.25 ns | 0.0758 ns | 0.0672 ns | 19.24 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 31.33 ns | 0.6308 ns | 0.7012 ns | 31.03 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.15 ns | 0.1110 ns | 0.1039 ns | 14.16 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.89 ns | 0.0739 ns | 0.0577 ns | 16.88 ns |      - |       0 B |
                                            From_SByte | 14.77 ns | 0.2638 ns | 0.2468 ns | 14.88 ns |      - |       0 B |
                                   From_SByte_AsObject | 30.34 ns | 0.5502 ns | 0.5147 ns | 30.06 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 17.98 ns | 0.0365 ns | 0.0285 ns | 17.99 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 31.54 ns | 0.5012 ns | 0.4688 ns | 31.37 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.52 ns | 0.3447 ns | 0.3225 ns | 13.40 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.32 ns | 0.1565 ns | 0.1387 ns | 17.28 ns |      - |       0 B |
                                            From_Float |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                   From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.22 ns | 0.2628 ns | 0.2330 ns | 14.18 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.48 ns | 0.2368 ns | 0.2215 ns | 16.41 ns |      - |       0 B |
                                           From_String | 22.10 ns | 0.1265 ns | 0.1183 ns | 22.05 ns |      - |       0 B |
                                  From_String_AsObject | 32.47 ns | 0.6853 ns | 1.2702 ns | 32.33 ns |      - |       0 B |
                                      From_String_Null | 16.13 ns | 0.1661 ns | 0.1553 ns | 16.06 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.03 ns | 0.3129 ns | 0.2927 ns | 16.90 ns |      - |       0 B |
                                     From_String_Empty | 20.22 ns | 0.4352 ns | 0.4274 ns | 20.34 ns |      - |       0 B |
                            From_String_Empty_AsObject | 24.51 ns | 0.5032 ns | 0.5384 ns | 24.41 ns |      - |       0 B |
                                           From_UShort | 13.12 ns | 0.1386 ns | 0.1157 ns | 13.12 ns |      - |       0 B |
                                  From_UShort_AsObject | 31.14 ns | 0.7331 ns | 1.2046 ns | 30.88 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 17.89 ns | 0.2218 ns | 0.1852 ns | 17.86 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 31.63 ns | 0.6737 ns | 0.8020 ns | 31.28 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.54 ns | 0.3210 ns | 0.6184 ns | 14.51 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.84 ns | 0.2588 ns | 0.2161 ns | 17.84 ns |      - |       0 B |
                                             From_UInt | 14.19 ns | 0.2023 ns | 0.1892 ns | 14.11 ns |      - |       0 B |
                                    From_UInt_AsObject | 30.81 ns | 0.5860 ns | 0.5195 ns | 30.65 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.95 ns | 0.5832 ns | 0.8364 ns | 17.64 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 30.33 ns | 0.1646 ns | 0.1374 ns | 30.32 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.20 ns | 0.1953 ns | 0.1731 ns | 14.18 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.28 ns | 0.3644 ns | 0.3742 ns | 17.16 ns |      - |       0 B |
                                            From_ULong | 14.79 ns | 0.3289 ns | 0.5217 ns | 14.68 ns |      - |       0 B |
                                   From_ULong_AsObject | 31.43 ns | 0.6347 ns | 0.6518 ns | 31.34 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 19.61 ns | 0.4273 ns | 0.5087 ns | 19.60 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 31.51 ns | 0.6311 ns | 0.5903 ns | 31.32 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.46 ns | 0.1490 ns | 0.1321 ns | 14.44 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.39 ns | 0.1698 ns | 0.1588 ns | 16.39 ns |      - |       0 B |
                                       From_NullObject | 16.44 ns | 0.1753 ns | 0.1554 ns | 16.40 ns |      - |       0 B |
                                           From_DBNull | 14.57 ns | 0.1827 ns | 0.1426 ns | 14.62 ns |      - |       0 B |
                                 From_ConvertibleClass | 26.04 ns | 0.5364 ns | 0.6784 ns | 25.83 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 28.21 ns | 0.5904 ns | 0.7466 ns | 28.04 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.56 ns | 0.3308 ns | 0.2933 ns | 17.60 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.51 ns | 0.2388 ns | 0.2117 ns | 16.51 ns |      - |       0 B |
                              From_NonConvertibleClass | 20.44 ns | 0.4427 ns | 0.5598 ns | 20.20 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 26.18 ns | 0.5577 ns | 0.7818 ns | 25.76 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 17.52 ns | 0.4347 ns | 0.4651 ns | 17.33 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.02 ns | 0.3743 ns | 0.5487 ns | 16.86 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.18 ns | 0.4848 ns | 0.5388 ns | 22.97 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 29.62 ns | 0.6236 ns | 0.8535 ns | 29.47 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 28.20 ns | 0.5020 ns | 0.5781 ns | 28.08 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 29.18 ns | 0.5951 ns | 0.5275 ns | 29.06 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.19 ns | 0.2599 ns | 0.2304 ns | 14.15 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.62 ns | 0.3048 ns | 0.2702 ns | 16.47 ns |      - |       0 B |
                             From_NonConvertibleStruct | 13.25 ns | 0.2915 ns | 0.3240 ns | 13.39 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 24.76 ns | 0.5299 ns | 0.5204 ns | 24.52 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 17.06 ns | 0.3364 ns | 0.2983 ns | 17.03 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 24.45 ns | 0.2296 ns | 0.2035 ns | 24.37 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.92 ns | 0.3123 ns | 0.5789 ns | 13.66 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.08 ns | 0.3683 ns | 0.3782 ns | 17.05 ns |      - |       0 B |
                                             From_Enum | 15.86 ns | 0.2135 ns | 0.1997 ns | 15.79 ns |      - |       0 B |
                                    From_Enum_AsObject | 66.34 ns | 0.8644 ns | 0.7663 ns | 66.29 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 19.13 ns | 0.3041 ns | 0.2844 ns | 19.02 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 67.64 ns | 1.3171 ns | 1.2935 ns | 67.51 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.60 ns | 0.1921 ns | 0.1796 ns | 14.53 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 19.69 ns | 0.1166 ns | 0.1090 ns | 19.70 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Char.From_Bool: DefaultJob
  ConvertTo2_Char.From_Bool_AsObject: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal: DefaultJob
  ConvertTo2_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Double: DefaultJob
  ConvertTo2_Char.From_Double_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Float: DefaultJob
  ConvertTo2_Char.From_Float_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
