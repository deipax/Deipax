
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  31.70 ns | 0.2758 ns | 0.2580 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.49 ns | 0.1878 ns | 0.1466 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 103.93 ns | 0.1713 ns | 0.1518 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.59 ns | 0.2265 ns | 0.1891 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  44.37 ns | 0.0811 ns | 0.0758 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.43 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                                          From_Byte |  31.16 ns | 0.0706 ns | 0.0626 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.45 ns | 0.1110 ns | 0.1038 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 105.69 ns | 0.1313 ns | 0.1228 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.82 ns | 0.1839 ns | 0.1720 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  42.00 ns | 0.0705 ns | 0.0660 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.72 ns | 0.0252 ns | 0.0210 ns |      - |       0 B |
                                          From_Char |  31.95 ns | 0.0827 ns | 0.0691 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.18 ns | 0.0155 ns | 0.0130 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.90 ns | 0.1468 ns | 0.1374 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.17 ns | 0.0147 ns | 0.0115 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  42.12 ns | 0.0968 ns | 0.0906 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.95 ns | 0.0253 ns | 0.0225 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.45 ns | 0.0717 ns | 0.0670 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.47 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                       From_Decimal |  42.37 ns | 0.0665 ns | 0.0622 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  40.70 ns | 0.2532 ns | 0.2244 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 126.46 ns | 0.1510 ns | 0.1261 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  39.63 ns | 0.0542 ns | 0.0480 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.18 ns | 0.0391 ns | 0.0346 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.52 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                                        From_Double |  35.31 ns | 0.0187 ns | 0.0146 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  33.76 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 112.57 ns | 0.3431 ns | 0.3209 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  33.91 ns | 0.0563 ns | 0.0470 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.35 ns | 0.0818 ns | 0.0725 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.74 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                                         From_Short |  31.58 ns | 0.0419 ns | 0.0372 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  30.02 ns | 0.0923 ns | 0.0864 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 106.03 ns | 0.1259 ns | 0.1116 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  30.04 ns | 0.1304 ns | 0.1220 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.04 ns | 0.0295 ns | 0.0262 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.72 ns | 0.0285 ns | 0.0253 ns |      - |       0 B |
                                           From_Int |  31.55 ns | 0.0088 ns | 0.0069 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  29.94 ns | 0.0645 ns | 0.0572 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 106.15 ns | 0.2590 ns | 0.2423 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  29.97 ns | 0.0932 ns | 0.0872 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  44.45 ns | 0.0650 ns | 0.0608 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.59 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                                          From_Long |  31.57 ns | 0.0424 ns | 0.0376 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  29.97 ns | 0.0189 ns | 0.0158 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 105.93 ns | 0.1998 ns | 0.1869 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  29.90 ns | 0.0181 ns | 0.0141 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  44.01 ns | 0.0347 ns | 0.0325 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.43 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                         From_SByte |  31.68 ns | 0.0304 ns | 0.0237 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  31.02 ns | 0.0251 ns | 0.0209 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 105.03 ns | 0.0856 ns | 0.0715 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.94 ns | 0.0156 ns | 0.0130 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.05 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.72 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                                         From_Float |  35.66 ns | 0.0145 ns | 0.0136 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  33.95 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 110.36 ns | 0.0890 ns | 0.0833 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  33.99 ns | 0.0659 ns | 0.0616 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.23 ns | 0.0345 ns | 0.0269 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.72 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                                        From_String | 107.19 ns | 0.1039 ns | 0.0972 ns |      - |       0 B |
                               From_String_AsObject | 106.21 ns | 0.2319 ns | 0.1937 ns |      - |       0 B |
                                   From_String_Null |  14.46 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.44 ns | 0.0216 ns | 0.0180 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  31.16 ns | 0.0755 ns | 0.0670 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.50 ns | 0.2477 ns | 0.2068 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 107.70 ns | 0.1831 ns | 0.1713 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  29.44 ns | 0.0836 ns | 0.0782 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.67 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.43 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
                                          From_UInt |  32.32 ns | 0.0281 ns | 0.0220 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.45 ns | 0.0168 ns | 0.0141 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 104.50 ns | 0.0635 ns | 0.0531 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.37 ns | 0.0253 ns | 0.0211 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.35 ns | 0.0453 ns | 0.0401 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.71 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                                         From_ULong |  19.00 ns | 0.0595 ns | 0.0527 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  15.67 ns | 0.0761 ns | 0.0674 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  88.89 ns | 0.1072 ns | 0.0950 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  15.60 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.40 ns | 0.0548 ns | 0.0513 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.73 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                    From_NullObject |  14.72 ns | 0.0405 ns | 0.0378 ns |      - |       0 B |
                                        From_DBNull |  16.17 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
                              From_ConvertibleClass |  28.62 ns | 0.0753 ns | 0.0704 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.53 ns | 0.0089 ns | 0.0070 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.43 ns | 0.0162 ns | 0.0135 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  14.49 ns | 0.0179 ns | 0.0149 ns |      - |       0 B |
                             From_ConvertibleStruct |  31.20 ns | 0.0159 ns | 0.0133 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.89 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 109.92 ns | 0.1900 ns | 0.1778 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.08 ns | 0.0354 ns | 0.0276 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.63 ns | 0.0221 ns | 0.0195 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.43 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
                                          From_Enum |  86.67 ns | 0.1355 ns | 0.1267 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  82.78 ns | 0.0449 ns | 0.0350 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 193.11 ns | 0.3461 ns | 0.3238 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  81.52 ns | 0.0854 ns | 0.0757 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.70 ns | 0.0182 ns | 0.0142 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.72 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_ULong.From_DateTime: DefaultJob
  ConvertTo_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULong.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULong.From_String_Empty: DefaultJob
  ConvertTo_ULong.From_String_Empty_AsObject: DefaultJob
