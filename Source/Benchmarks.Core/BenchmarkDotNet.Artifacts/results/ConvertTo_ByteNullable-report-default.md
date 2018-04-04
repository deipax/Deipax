
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  41.23 ns | 0.3310 ns | 0.3096 ns |  41.28 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  40.22 ns | 0.0439 ns | 0.0343 ns |  40.21 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 114.71 ns | 0.0486 ns | 0.0431 ns | 114.70 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  39.14 ns | 0.0708 ns | 0.0591 ns |  39.11 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  42.03 ns | 0.0539 ns | 0.0450 ns |  42.02 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.34 ns | 0.0147 ns | 0.0115 ns |  16.33 ns |      - |       0 B |
                                             From_Byte |  30.15 ns | 0.0595 ns | 0.0556 ns |  30.13 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  28.66 ns | 0.0238 ns | 0.0186 ns |  28.67 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 104.94 ns | 0.1120 ns | 0.1048 ns | 104.97 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  27.68 ns | 0.0231 ns | 0.0216 ns |  27.67 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  43.43 ns | 0.0918 ns | 0.0859 ns |  43.39 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.20 ns | 0.0102 ns | 0.0090 ns |  16.20 ns |      - |       0 B |
                                             From_Char |  41.66 ns | 0.0297 ns | 0.0248 ns |  41.66 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  43.55 ns | 0.0402 ns | 0.0314 ns |  43.54 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 116.79 ns | 0.1668 ns | 0.1560 ns | 116.82 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  43.57 ns | 0.0544 ns | 0.0509 ns |  43.54 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  43.15 ns | 0.2653 ns | 0.2352 ns |  43.16 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.20 ns | 0.0115 ns | 0.0102 ns |  16.19 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  41.64 ns | 0.0582 ns | 0.0486 ns |  41.66 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.83 ns | 0.0247 ns | 0.0231 ns |  17.82 ns |      - |       0 B |
                                          From_Decimal |  55.90 ns | 0.0937 ns | 0.0876 ns |  55.89 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  52.62 ns | 0.0311 ns | 0.0260 ns |  52.62 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 130.82 ns | 0.2699 ns | 0.2525 ns | 130.82 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  53.42 ns | 0.0882 ns | 0.0825 ns |  53.40 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  42.12 ns | 0.1772 ns | 0.1658 ns |  42.18 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.39 ns | 0.0044 ns | 0.0039 ns |  15.39 ns |      - |       0 B |
                                           From_Double |  45.29 ns | 0.0663 ns | 0.0588 ns |  45.29 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  43.96 ns | 0.0205 ns | 0.0182 ns |  43.97 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 121.78 ns | 0.2165 ns | 0.1919 ns | 121.71 ns | 0.0055 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  43.70 ns | 0.0486 ns | 0.0406 ns |  43.68 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  42.27 ns | 0.1067 ns | 0.0998 ns |  42.26 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.18 ns | 0.0990 ns | 0.0877 ns |  16.14 ns |      - |       0 B |
                                            From_Short |  41.52 ns | 0.0216 ns | 0.0180 ns |  41.52 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  40.23 ns | 0.0199 ns | 0.0166 ns |  40.23 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 116.25 ns | 0.1832 ns | 0.1714 ns | 116.14 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  41.23 ns | 0.6119 ns | 0.5723 ns |  41.51 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.40 ns | 0.0114 ns | 0.0089 ns |  41.40 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.13 ns | 0.0084 ns | 0.0075 ns |  16.13 ns |      - |       0 B |
                                              From_Int |  43.28 ns | 0.0166 ns | 0.0139 ns |  43.28 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  40.53 ns | 0.0457 ns | 0.0405 ns |  40.52 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 115.76 ns | 0.2339 ns | 0.2187 ns | 115.64 ns | 0.0055 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  42.27 ns | 0.0837 ns | 0.0742 ns |  42.26 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  44.85 ns | 0.0164 ns | 0.0145 ns |  44.85 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.31 ns | 0.0106 ns | 0.0094 ns |  15.30 ns |      - |       0 B |
                                             From_Long |  41.51 ns | 0.0430 ns | 0.0382 ns |  41.50 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  41.33 ns | 0.1446 ns | 0.1282 ns |  41.32 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 121.03 ns | 0.1627 ns | 0.1442 ns | 120.98 ns | 0.0055 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  41.12 ns | 0.6334 ns | 0.5925 ns |  41.43 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  41.53 ns | 0.0245 ns | 0.0230 ns |  41.52 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.22 ns | 0.0119 ns | 0.0099 ns |  17.22 ns |      - |       0 B |
                                            From_SByte |  40.71 ns | 0.0144 ns | 0.0120 ns |  40.72 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  40.77 ns | 0.1365 ns | 0.1140 ns |  40.77 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 115.69 ns | 0.1262 ns | 0.1053 ns | 115.66 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  40.59 ns | 0.0551 ns | 0.0488 ns |  40.57 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  43.43 ns | 0.0633 ns | 0.0561 ns |  43.42 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  15.42 ns | 0.0362 ns | 0.0282 ns |  15.42 ns |      - |       0 B |
                                            From_Float |  44.74 ns | 0.0190 ns | 0.0158 ns |  44.74 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  43.22 ns | 0.0191 ns | 0.0160 ns |  43.22 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 121.39 ns | 0.0616 ns | 0.0546 ns | 121.37 ns | 0.0055 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  44.25 ns | 0.1713 ns | 0.1430 ns |  44.28 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  42.27 ns | 0.0159 ns | 0.0124 ns |  42.27 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.13 ns | 0.0213 ns | 0.0199 ns |  15.13 ns |      - |       0 B |
                                           From_String | 133.34 ns | 0.3750 ns | 0.3508 ns | 133.43 ns |      - |       0 B |
                                  From_String_AsObject | 133.20 ns | 0.1661 ns | 0.1553 ns | 133.17 ns |      - |       0 B |
                                      From_String_Null |  15.27 ns | 0.0049 ns | 0.0038 ns |  15.27 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.88 ns | 0.0039 ns | 0.0030 ns |  15.88 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  41.18 ns | 0.0648 ns | 0.0606 ns |  41.16 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  40.90 ns | 0.0186 ns | 0.0134 ns |  40.90 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 115.72 ns | 0.0938 ns | 0.0878 ns | 115.68 ns | 0.0055 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  41.34 ns | 0.0909 ns | 0.0805 ns |  41.33 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  42.25 ns | 0.0120 ns | 0.0094 ns |  42.25 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.30 ns | 0.0063 ns | 0.0056 ns |  15.30 ns |      - |       0 B |
                                             From_UInt |  40.97 ns | 0.0227 ns | 0.0189 ns |  40.97 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  40.35 ns | 0.1236 ns | 0.1156 ns |  40.30 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 114.78 ns | 0.1231 ns | 0.1091 ns | 114.75 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  39.43 ns | 0.0174 ns | 0.0163 ns |  39.42 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  42.64 ns | 0.0237 ns | 0.0198 ns |  42.64 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  15.43 ns | 0.0307 ns | 0.0257 ns |  15.43 ns |      - |       0 B |
                                            From_ULong |  41.98 ns | 0.0375 ns | 0.0313 ns |  41.98 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  41.60 ns | 0.1422 ns | 0.1261 ns |  41.58 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 117.33 ns | 0.1336 ns | 0.1250 ns | 117.26 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  41.56 ns | 0.1058 ns | 0.0884 ns |  41.56 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.57 ns | 0.0362 ns | 0.0321 ns |  41.56 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.14 ns | 0.0084 ns | 0.0079 ns |  16.14 ns |      - |       0 B |
                                       From_NullObject |  15.12 ns | 0.0047 ns | 0.0036 ns |  15.12 ns |      - |       0 B |
                                           From_DBNull |  16.17 ns | 0.3484 ns | 0.5526 ns |  16.13 ns |      - |       0 B |
                                 From_ConvertibleClass |  38.36 ns | 0.6109 ns | 0.5101 ns |  38.13 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  39.02 ns | 0.8039 ns | 1.4495 ns |  38.63 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.55 ns | 0.4068 ns | 0.6334 ns |  17.42 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.71 ns | 0.3730 ns | 0.4850 ns |  16.54 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  15.42 ns | 0.2922 ns | 0.2733 ns |  15.37 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.36 ns | 0.6451 ns | 1.9022 ns |  16.71 ns |      - |       0 B |
                                From_ConvertibleStruct |  42.23 ns | 0.4144 ns | 0.3876 ns |  42.10 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  40.21 ns | 0.7250 ns | 0.6427 ns |  39.95 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 122.77 ns | 1.5015 ns | 1.3310 ns | 122.71 ns | 0.0055 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  38.80 ns | 0.5701 ns | 0.5054 ns |  38.56 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  43.76 ns | 0.3541 ns | 0.2957 ns |  43.63 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.34 ns | 0.1473 ns | 0.1378 ns |  15.29 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  44.13 ns | 0.2939 ns | 0.2749 ns |  44.07 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.58 ns | 0.2010 ns | 0.1782 ns |  15.55 ns |      - |       0 B |
                                             From_Enum | 106.52 ns | 1.0304 ns | 0.9639 ns | 106.29 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject | 100.72 ns | 0.5498 ns | 0.4591 ns | 100.71 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 211.51 ns | 3.4993 ns | 3.2733 ns | 210.86 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  98.47 ns | 0.7533 ns | 0.7046 ns |  98.36 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  44.61 ns | 0.2492 ns | 0.2081 ns |  44.68 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.57 ns | 0.1676 ns | 0.1567 ns |  15.54 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_ByteNullable.From_DateTime: DefaultJob
  ConvertTo_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_String_Empty: DefaultJob
  ConvertTo_ByteNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleClass: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleStruct: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_ByteNullable.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
