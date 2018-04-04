
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                    From_Bool_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  42.57 ns | 0.7189 ns | 0.6725 ns |  42.58 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.88 ns | 0.3100 ns | 0.2748 ns |  15.90 ns |      - |       0 B |
                                             From_Byte |  32.25 ns | 0.5900 ns | 0.4927 ns |  32.12 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  31.69 ns | 0.7038 ns | 0.6239 ns |  31.43 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 108.58 ns | 1.7938 ns | 1.6779 ns | 108.60 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.38 ns | 0.2079 ns | 0.1945 ns |  30.30 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  42.21 ns | 0.6418 ns | 0.6003 ns |  42.02 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.52 ns | 0.1721 ns | 0.1610 ns |  16.43 ns |      - |       0 B |
                                             From_Char |  18.08 ns | 0.2206 ns | 0.2063 ns |  18.05 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  16.67 ns | 0.1763 ns | 0.1563 ns |  16.63 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  91.25 ns | 1.8083 ns | 1.6030 ns |  91.16 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  17.86 ns | 0.1556 ns | 0.1379 ns |  17.84 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  41.94 ns | 0.5574 ns | 0.4654 ns |  41.79 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.69 ns | 0.3416 ns | 0.4066 ns |  15.59 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  42.55 ns | 0.7287 ns | 0.6460 ns |  42.31 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  15.79 ns | 0.0995 ns | 0.0882 ns |  15.77 ns |      - |       0 B |
                                          From_Decimal |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Decimal_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  43.40 ns | 0.8753 ns | 0.8989 ns |  43.16 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.67 ns | 0.1496 ns | 0.1326 ns |  15.67 ns |      - |       0 B |
                                           From_Double |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                  From_Double_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  42.82 ns | 0.6837 ns | 0.6395 ns |  42.70 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.00 ns | 0.1057 ns | 0.0937 ns |  15.98 ns |      - |       0 B |
                                            From_Short |  32.75 ns | 0.4624 ns | 0.4325 ns |  32.78 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  30.57 ns | 0.2065 ns | 0.1831 ns |  30.52 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 112.58 ns | 1.3949 ns | 1.3048 ns | 112.38 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  31.63 ns | 0.6682 ns | 1.5353 ns |  31.10 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.64 ns | 0.5363 ns | 0.4754 ns |  41.46 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.00 ns | 0.2537 ns | 0.2373 ns |  14.89 ns |      - |       0 B |
                                              From_Int |  34.15 ns | 0.0703 ns | 0.0587 ns |  34.15 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  31.07 ns | 0.1032 ns | 0.0862 ns |  31.04 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 104.99 ns | 0.2281 ns | 0.1905 ns | 104.92 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  31.50 ns | 0.6468 ns | 0.6352 ns |  31.20 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  41.59 ns | 0.4307 ns | 0.4029 ns |  41.43 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.00 ns | 0.0518 ns | 0.0459 ns |  16.00 ns |      - |       0 B |
                                             From_Long |  33.38 ns | 0.0376 ns | 0.0314 ns |  33.38 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  32.24 ns | 0.0919 ns | 0.0860 ns |  32.24 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 108.63 ns | 0.8051 ns | 0.7531 ns | 108.99 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  31.12 ns | 0.1012 ns | 0.0947 ns |  31.09 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  43.08 ns | 0.0445 ns | 0.0395 ns |  43.07 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.04 ns | 0.0421 ns | 0.0373 ns |  15.03 ns |      - |       0 B |
                                            From_SByte |  31.73 ns | 0.0893 ns | 0.0792 ns |  31.69 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  32.37 ns | 0.8045 ns | 2.3083 ns |  31.42 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 105.35 ns | 0.8859 ns | 0.8287 ns | 104.78 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  30.28 ns | 0.0995 ns | 0.0931 ns |  30.23 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  41.41 ns | 0.0688 ns | 0.0610 ns |  41.41 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  14.90 ns | 0.0670 ns | 0.0560 ns |  14.89 ns |      - |       0 B |
                                            From_Float |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                   From_Float_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  44.09 ns | 0.3860 ns | 0.3611 ns |  44.26 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.83 ns | 0.0299 ns | 0.0265 ns |  15.82 ns |      - |       0 B |
                                           From_String |  30.61 ns | 0.1371 ns | 0.1216 ns |  30.63 ns |      - |       0 B |
                                  From_String_AsObject |  29.47 ns | 0.0897 ns | 0.0839 ns |  29.43 ns |      - |       0 B |
                                      From_String_Null |  16.20 ns | 0.0427 ns | 0.0357 ns |  16.20 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.04 ns | 0.0539 ns | 0.0421 ns |  15.02 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  31.23 ns | 0.1452 ns | 0.1134 ns |  31.21 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  29.80 ns | 0.1647 ns | 0.1286 ns |  29.76 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 105.04 ns | 0.2544 ns | 0.2255 ns | 105.02 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  29.71 ns | 0.0413 ns | 0.0322 ns |  29.70 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  42.99 ns | 0.0958 ns | 0.0748 ns |  42.99 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.64 ns | 0.0323 ns | 0.0234 ns |  16.63 ns |      - |       0 B |
                                             From_UInt |  31.99 ns | 0.0528 ns | 0.0468 ns |  31.98 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  30.45 ns | 0.0295 ns | 0.0276 ns |  30.45 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 105.76 ns | 0.1876 ns | 0.1663 ns | 105.78 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.33 ns | 0.1319 ns | 0.1102 ns |  30.32 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  40.73 ns | 0.0703 ns | 0.0587 ns |  40.70 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  14.90 ns | 0.0470 ns | 0.0439 ns |  14.90 ns |      - |       0 B |
                                            From_ULong |  33.63 ns | 0.0673 ns | 0.0562 ns |  33.60 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  31.98 ns | 0.1067 ns | 0.0998 ns |  31.97 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 107.67 ns | 0.3598 ns | 0.3366 ns | 107.63 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  32.02 ns | 0.7137 ns | 1.7640 ns |  31.00 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.57 ns | 0.1023 ns | 0.0799 ns |  41.59 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  14.90 ns | 0.0467 ns | 0.0390 ns |  14.88 ns |      - |       0 B |
                                       From_NullObject |  15.24 ns | 0.0419 ns | 0.0327 ns |  15.23 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0390 ns | 0.0326 ns |  15.31 ns |      - |       0 B |
                                 From_ConvertibleClass |  27.89 ns | 0.1188 ns | 0.0928 ns |  27.85 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.19 ns | 0.0574 ns | 0.0479 ns |  28.19 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.12 ns | 0.1701 ns | 0.1508 ns |  15.07 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.07 ns | 0.0545 ns | 0.0510 ns |  15.05 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  14.88 ns | 0.0470 ns | 0.0367 ns |  14.86 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  14.91 ns | 0.0563 ns | 0.0526 ns |  14.91 ns |      - |       0 B |
                                From_ConvertibleStruct |  32.04 ns | 0.0778 ns | 0.0728 ns |  32.00 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.20 ns | 0.0502 ns | 0.0392 ns |  29.21 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 111.15 ns | 0.8661 ns | 0.8102 ns | 110.75 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.26 ns | 0.1162 ns | 0.1087 ns |  29.24 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  43.06 ns | 0.3446 ns | 0.3223 ns |  42.94 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.89 ns | 0.0445 ns | 0.0394 ns |  14.88 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  44.00 ns | 0.4479 ns | 0.4189 ns |  43.80 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.05 ns | 0.0563 ns | 0.0499 ns |  15.03 ns |      - |       0 B |
                                             From_Enum |  89.85 ns | 0.9719 ns | 0.9091 ns |  89.27 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  85.32 ns | 0.3576 ns | 0.3345 ns |  85.38 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 195.00 ns | 0.6418 ns | 0.6003 ns | 194.87 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  88.39 ns | 0.1969 ns | 0.1842 ns |  88.39 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  41.90 ns | 0.1120 ns | 0.1047 ns |  41.89 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.02 ns | 0.0399 ns | 0.0311 ns |  15.01 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Char.From_Bool: DefaultJob
  ConvertTo_Char.From_Bool_AsObject: DefaultJob
  ConvertTo_Char.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime: DefaultJob
  ConvertTo_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo_Char.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal: DefaultJob
  ConvertTo_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo_Char.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Double: DefaultJob
  ConvertTo_Char.From_Double_AsObject: DefaultJob
  ConvertTo_Char.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_Float: DefaultJob
  ConvertTo_Char.From_Float_AsObject: DefaultJob
  ConvertTo_Char.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Char.From_String_Empty: DefaultJob
  ConvertTo_Char.From_String_Empty_AsObject: DefaultJob
  ConvertTo_Char.From_NonConvertibleClass: DefaultJob
  ConvertTo_Char.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_Char.From_NonConvertibleStruct: DefaultJob
  ConvertTo_Char.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_Char.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_Char.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
