
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  34.99 ns | 0.0153 ns | 0.0119 ns |  34.98 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  33.36 ns | 0.0109 ns | 0.0091 ns |  33.36 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 109.60 ns | 0.1436 ns | 0.1344 ns | 109.60 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  33.36 ns | 0.0168 ns | 0.0141 ns |  33.36 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  42.48 ns | 0.0502 ns | 0.0419 ns |  42.47 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.56 ns | 0.0035 ns | 0.0030 ns |  16.56 ns |      - |       0 B |
                                          From_Byte |  36.25 ns | 0.0207 ns | 0.0173 ns |  36.25 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  34.49 ns | 0.0252 ns | 0.0236 ns |  34.48 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 108.48 ns | 0.0373 ns | 0.0349 ns | 108.48 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  34.21 ns | 0.0210 ns | 0.0186 ns |  34.21 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  43.50 ns | 0.0182 ns | 0.0170 ns |  43.51 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.48 ns | 0.0045 ns | 0.0040 ns |  16.48 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  42.62 ns | 0.0631 ns | 0.0560 ns |  42.62 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.40 ns | 0.0112 ns | 0.0105 ns |  16.39 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  44.52 ns | 0.0465 ns | 0.0412 ns |  44.51 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.65 ns | 0.0123 ns | 0.0115 ns |  16.65 ns |      - |       0 B |
                                       From_Decimal |  19.09 ns | 0.0073 ns | 0.0061 ns |  19.09 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  17.37 ns | 0.0065 ns | 0.0057 ns |  17.37 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  92.55 ns | 0.0714 ns | 0.0633 ns |  92.53 ns | 0.0075 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  17.37 ns | 0.0088 ns | 0.0082 ns |  17.37 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  43.11 ns | 0.0236 ns | 0.0209 ns |  43.11 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.56 ns | 0.0028 ns | 0.0024 ns |  16.56 ns |      - |       0 B |
                                        From_Double |  95.44 ns | 0.0402 ns | 0.0356 ns |  95.43 ns | 0.0056 |      24 B |
                               From_Double_AsObject |  93.87 ns | 0.0397 ns | 0.0352 ns |  93.86 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 172.27 ns | 0.2682 ns | 0.2509 ns | 172.13 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  93.33 ns | 0.0278 ns | 0.0260 ns |  93.32 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.33 ns | 0.0411 ns | 0.0385 ns |  42.33 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.40 ns | 0.0089 ns | 0.0084 ns |  16.39 ns |      - |       0 B |
                                         From_Short |  37.18 ns | 0.0220 ns | 0.0195 ns |  37.17 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  35.69 ns | 0.0062 ns | 0.0049 ns |  35.69 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 107.79 ns | 0.0586 ns | 0.0520 ns | 107.78 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  35.70 ns | 0.0206 ns | 0.0183 ns |  35.69 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.55 ns | 0.0547 ns | 0.0512 ns |  42.54 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.39 ns | 0.0033 ns | 0.0026 ns |  16.39 ns |      - |       0 B |
                                           From_Int |  34.64 ns | 0.0193 ns | 0.0181 ns |  34.63 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  33.98 ns | 0.0101 ns | 0.0084 ns |  33.98 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 108.32 ns | 0.0413 ns | 0.0366 ns | 108.32 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  34.22 ns | 0.0126 ns | 0.0112 ns |  34.21 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  46.09 ns | 0.0368 ns | 0.0344 ns |  46.09 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.56 ns | 0.0009 ns | 0.0007 ns |  16.56 ns |      - |       0 B |
                                          From_Long |  35.12 ns | 0.2150 ns | 0.2011 ns |  35.28 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  34.27 ns | 0.0348 ns | 0.0291 ns |  34.26 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 108.50 ns | 0.0403 ns | 0.0357 ns | 108.50 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  34.28 ns | 0.0406 ns | 0.0380 ns |  34.25 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  45.10 ns | 0.0964 ns | 0.0902 ns |  45.14 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.71 ns | 0.0030 ns | 0.0025 ns |  16.71 ns |      - |       0 B |
                                         From_SByte |  36.24 ns | 0.0126 ns | 0.0117 ns |  36.23 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  34.61 ns | 0.0259 ns | 0.0230 ns |  34.60 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 110.24 ns | 0.0353 ns | 0.0330 ns | 110.23 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  34.36 ns | 0.0602 ns | 0.0470 ns |  34.35 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  45.86 ns | 0.9815 ns | 2.0916 ns |  44.91 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.51 ns | 0.0330 ns | 0.0292 ns |  16.49 ns |      - |       0 B |
                                         From_Float |  56.53 ns | 0.0511 ns | 0.0399 ns |  56.53 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  54.32 ns | 0.1799 ns | 0.1683 ns |  54.25 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 133.10 ns | 1.2034 ns | 1.1257 ns | 133.07 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  62.90 ns | 0.1198 ns | 0.1001 ns |  62.88 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  47.01 ns | 1.0902 ns | 2.5697 ns |  45.95 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.56 ns | 0.1576 ns | 0.1316 ns |  16.51 ns |      - |       0 B |
                                        From_String | 145.64 ns | 0.3264 ns | 0.2360 ns | 145.64 ns |      - |       0 B |
                               From_String_AsObject | 147.34 ns | 2.9303 ns | 2.7410 ns | 146.40 ns |      - |       0 B |
                                   From_String_Null |  16.68 ns | 0.1118 ns | 0.1046 ns |  16.65 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.68 ns | 0.1092 ns | 0.1022 ns |  16.65 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  35.89 ns | 0.0538 ns | 0.0420 ns |  35.88 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  34.14 ns | 0.1050 ns | 0.0982 ns |  34.10 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 114.66 ns | 2.3673 ns | 3.6151 ns | 113.29 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  34.44 ns | 0.1736 ns | 0.1356 ns |  34.45 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  44.13 ns | 0.7346 ns | 0.6872 ns |  43.78 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.67 ns | 0.1039 ns | 0.0921 ns |  16.64 ns |      - |       0 B |
                                          From_UInt |  34.63 ns | 0.4486 ns | 0.3746 ns |  34.45 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  34.03 ns | 0.0650 ns | 0.0543 ns |  34.02 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 111.77 ns | 2.2388 ns | 2.3955 ns | 110.96 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  33.99 ns | 0.3212 ns | 0.3004 ns |  33.88 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  43.16 ns | 0.2751 ns | 0.2297 ns |  43.05 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.45 ns | 0.0401 ns | 0.0356 ns |  16.44 ns |      - |       0 B |
                                         From_ULong |  35.02 ns | 0.5511 ns | 0.5155 ns |  34.76 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  34.09 ns | 0.0915 ns | 0.0811 ns |  34.08 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 109.55 ns | 0.3513 ns | 0.3286 ns | 109.43 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  34.25 ns | 0.3490 ns | 0.3094 ns |  34.11 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  44.79 ns | 0.2042 ns | 0.1706 ns |  44.73 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.49 ns | 0.1189 ns | 0.1054 ns |  16.45 ns |      - |       0 B |
                                    From_NullObject |  16.76 ns | 0.3588 ns | 0.3357 ns |  16.60 ns |      - |       0 B |
                                        From_DBNull |  17.32 ns | 0.2596 ns | 0.2301 ns |  17.20 ns |      - |       0 B |
                              From_ConvertibleClass |  32.65 ns | 0.2474 ns | 0.2065 ns |  32.59 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  32.61 ns | 0.2219 ns | 0.1853 ns |  32.57 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.87 ns | 0.1535 ns | 0.1361 ns |  16.89 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  19.58 ns | 0.0514 ns | 0.0429 ns |  19.56 ns |      - |       0 B |
                             From_ConvertibleStruct |  35.18 ns | 0.6163 ns | 0.5765 ns |  34.82 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  33.49 ns | 0.3209 ns | 0.2845 ns |  33.46 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 118.92 ns | 0.8196 ns | 0.6844 ns | 118.94 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  33.38 ns | 0.3964 ns | 0.3514 ns |  33.22 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  46.63 ns | 0.2002 ns | 0.1774 ns |  46.58 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.85 ns | 0.1265 ns | 0.1121 ns |  16.81 ns |      - |       0 B |
                                          From_Enum |  99.17 ns | 0.4081 ns | 0.3817 ns |  99.17 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  92.08 ns | 0.3379 ns | 0.2995 ns |  92.01 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 201.99 ns | 0.8903 ns | 0.8328 ns | 201.80 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  96.15 ns | 0.9754 ns | 0.8145 ns |  96.06 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  43.55 ns | 0.9019 ns | 0.8858 ns |  43.13 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.44 ns | 0.0236 ns | 0.0220 ns |  16.43 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Decimal.From_Char: DefaultJob
  ConvertTo_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo_Decimal.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime: DefaultJob
  ConvertTo_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Decimal.From_String_Empty: DefaultJob
  ConvertTo_Decimal.From_String_Empty_AsObject: DefaultJob
