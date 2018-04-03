
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  29.41 ns | 0.3143 ns | 0.2940 ns |  29.45 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  28.80 ns | 0.1514 ns | 0.1416 ns |  28.75 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 101.65 ns | 0.0962 ns | 0.0853 ns | 101.61 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  27.42 ns | 0.2364 ns | 0.2211 ns |  27.28 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  44.98 ns | 0.0213 ns | 0.0178 ns |  44.98 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.78 ns | 0.0269 ns | 0.0210 ns |  15.77 ns |      - |       0 B |
                                             From_Byte |  40.62 ns | 0.0105 ns | 0.0087 ns |  40.61 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  39.33 ns | 0.0767 ns | 0.0640 ns |  39.33 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 114.50 ns | 0.0696 ns | 0.0581 ns | 114.49 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  39.77 ns | 0.5355 ns | 0.5009 ns |  39.44 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  41.93 ns | 0.0083 ns | 0.0069 ns |  41.93 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  15.29 ns | 0.1832 ns | 0.1714 ns |  15.15 ns |      - |       0 B |
                                             From_Char |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                    From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  41.98 ns | 0.0239 ns | 0.0187 ns |  41.97 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.58 ns | 0.0332 ns | 0.0259 ns |  15.57 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  42.09 ns | 0.0595 ns | 0.0556 ns |  42.06 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.61 ns | 0.0316 ns | 0.0296 ns |  19.61 ns |      - |       0 B |
                                          From_Decimal |  54.40 ns | 0.0154 ns | 0.0128 ns |  54.40 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  49.97 ns | 0.0485 ns | 0.0430 ns |  49.96 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 129.26 ns | 0.0720 ns | 0.0562 ns | 129.25 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  50.07 ns | 0.1443 ns | 0.1279 ns |  50.01 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  45.23 ns | 0.1230 ns | 0.1151 ns |  45.17 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.40 ns | 0.1440 ns | 0.1347 ns |  15.33 ns |      - |       0 B |
                                           From_Double |  42.48 ns | 0.0137 ns | 0.0114 ns |  42.48 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  38.99 ns | 0.0799 ns | 0.0624 ns |  38.97 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 118.18 ns | 0.0334 ns | 0.0296 ns | 118.18 ns | 0.0056 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  39.49 ns | 0.8017 ns | 0.7499 ns |  39.06 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  41.84 ns | 0.0222 ns | 0.0173 ns |  41.83 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.05 ns | 0.0242 ns | 0.0189 ns |  15.04 ns |      - |       0 B |
                                            From_Short |  40.31 ns | 0.0818 ns | 0.0766 ns |  40.30 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  38.79 ns | 0.0685 ns | 0.0572 ns |  38.77 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 118.88 ns | 0.9397 ns | 0.7337 ns | 118.75 ns | 0.0055 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  38.83 ns | 0.0834 ns | 0.0696 ns |  38.81 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  43.77 ns | 0.0646 ns | 0.0505 ns |  43.75 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.04 ns | 0.0221 ns | 0.0184 ns |  15.04 ns |      - |       0 B |
                                              From_Int |  41.71 ns | 0.0537 ns | 0.0476 ns |  41.69 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  40.21 ns | 0.2754 ns | 0.2300 ns |  40.13 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 115.92 ns | 0.2662 ns | 0.2490 ns | 115.87 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  38.92 ns | 0.1330 ns | 0.1110 ns |  38.90 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  42.30 ns | 0.1574 ns | 0.1395 ns |  42.35 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.94 ns | 0.0282 ns | 0.0250 ns |  15.92 ns |      - |       0 B |
                                             From_Long |  44.74 ns | 0.0465 ns | 0.0363 ns |  44.74 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  39.51 ns | 0.7099 ns | 0.8451 ns |  39.07 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 117.28 ns | 1.5845 ns | 1.3231 ns | 116.66 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  39.08 ns | 0.2077 ns | 0.1735 ns |  39.03 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  42.09 ns | 0.1294 ns | 0.1010 ns |  42.07 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.29 ns | 0.3338 ns | 0.3710 ns |  15.09 ns |      - |       0 B |
                                            From_SByte |  40.65 ns | 0.1702 ns | 0.1422 ns |  40.66 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  40.59 ns | 0.5086 ns | 0.3971 ns |  40.57 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 118.51 ns | 1.7883 ns | 1.4933 ns | 117.74 ns | 0.0055 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  39.06 ns | 0.2038 ns | 0.1906 ns |  38.99 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  43.73 ns | 0.5663 ns | 0.4729 ns |  43.61 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.25 ns | 0.3522 ns | 0.4056 ns |  16.20 ns |      - |       0 B |
                                            From_Float |  42.68 ns | 0.4074 ns | 0.3611 ns |  42.64 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  39.44 ns | 0.6560 ns | 0.6137 ns |  39.08 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 120.90 ns | 2.3011 ns | 1.9215 ns | 120.07 ns | 0.0055 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  39.63 ns | 0.5463 ns | 0.4843 ns |  39.52 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  43.59 ns | 0.7292 ns | 0.6821 ns |  43.61 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.14 ns | 0.1034 ns | 0.0967 ns |  15.12 ns |      - |       0 B |
                                           From_String |  60.50 ns | 1.1478 ns | 0.8961 ns |  60.16 ns |      - |       0 B |
                                  From_String_AsObject |  59.88 ns | 0.7500 ns | 0.6263 ns |  59.74 ns |      - |       0 B |
                                      From_String_Null |  15.46 ns | 0.0674 ns | 0.0487 ns |  15.46 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.19 ns | 0.2111 ns | 0.1974 ns |  15.17 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  41.73 ns | 0.2463 ns | 0.2304 ns |  41.71 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  38.89 ns | 0.0932 ns | 0.0826 ns |  38.84 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 118.01 ns | 1.2625 ns | 1.0542 ns | 118.06 ns | 0.0055 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  39.15 ns | 0.2802 ns | 0.2188 ns |  39.10 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  46.45 ns | 0.1894 ns | 0.1679 ns |  46.45 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.44 ns | 0.0757 ns | 0.0591 ns |  15.43 ns |      - |       0 B |
                                             From_UInt |  41.45 ns | 0.5732 ns | 0.5361 ns |  41.44 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  39.32 ns | 0.2406 ns | 0.2133 ns |  39.27 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 115.53 ns | 0.7961 ns | 0.7058 ns | 115.35 ns | 0.0055 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  40.54 ns | 0.4139 ns | 0.3456 ns |  40.55 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  42.30 ns | 0.1468 ns | 0.1226 ns |  42.33 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  15.32 ns | 0.1606 ns | 0.1423 ns |  15.32 ns |      - |       0 B |
                                            From_ULong |  41.65 ns | 0.9422 ns | 1.3208 ns |  41.17 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  39.74 ns | 0.7730 ns | 0.7592 ns |  39.39 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 121.58 ns | 1.3632 ns | 1.2084 ns | 121.82 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  39.57 ns | 0.0628 ns | 0.0556 ns |  39.56 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.82 ns | 0.0712 ns | 0.0631 ns |  41.80 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.53 ns | 0.0345 ns | 0.0306 ns |  15.53 ns |      - |       0 B |
                                       From_NullObject |  15.05 ns | 0.0083 ns | 0.0065 ns |  15.05 ns |      - |       0 B |
                                           From_DBNull |  16.28 ns | 0.0265 ns | 0.0235 ns |  16.28 ns |      - |       0 B |
                                 From_ConvertibleClass |  37.21 ns | 0.0823 ns | 0.0730 ns |  37.19 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  37.09 ns | 0.0864 ns | 0.0808 ns |  37.05 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.44 ns | 0.0318 ns | 0.0265 ns |  15.43 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  14.95 ns | 0.0067 ns | 0.0059 ns |  14.95 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  15.49 ns | 0.0524 ns | 0.0409 ns |  15.48 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.07 ns | 0.0382 ns | 0.0357 ns |  15.05 ns |      - |       0 B |
                                From_ConvertibleStruct |  42.44 ns | 0.0240 ns | 0.0213 ns |  42.44 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  38.28 ns | 0.0596 ns | 0.0529 ns |  38.26 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 125.87 ns | 0.2130 ns | 0.1888 ns | 125.89 ns | 0.0055 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  38.48 ns | 0.0606 ns | 0.0567 ns |  38.48 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  42.88 ns | 0.0425 ns | 0.0377 ns |  42.87 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.40 ns | 0.2600 ns | 0.2432 ns |  15.53 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  42.48 ns | 0.0766 ns | 0.0679 ns |  42.48 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.10 ns | 0.0189 ns | 0.0168 ns |  15.10 ns |      - |       0 B |
                                             From_Enum | 104.74 ns | 0.1226 ns | 0.0957 ns | 104.70 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  99.80 ns | 0.0670 ns | 0.0594 ns |  99.82 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 202.96 ns | 0.5293 ns | 0.4692 ns | 202.81 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject | 102.41 ns | 0.0944 ns | 0.0837 ns | 102.42 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  42.83 ns | 0.1155 ns | 0.1080 ns |  42.77 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.30 ns | 0.0248 ns | 0.0194 ns |  16.30 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_BoolNullable.From_Char: DefaultJob
  ConvertTo_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_String_Empty: DefaultJob
  ConvertTo_BoolNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleClass: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleStruct: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_BoolNullable.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
