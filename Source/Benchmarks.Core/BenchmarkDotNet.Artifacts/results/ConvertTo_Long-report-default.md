
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435885 Hz, Resolution=291.0458 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  31.66 ns | 0.6370 ns | 0.6256 ns |  31.55 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  29.56 ns | 0.0682 ns | 0.0605 ns |  29.56 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 103.54 ns | 0.1304 ns | 0.1089 ns | 103.51 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.67 ns | 0.1200 ns | 0.1123 ns |  30.67 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  41.11 ns | 0.1234 ns | 0.1154 ns |  41.10 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  14.46 ns | 0.0308 ns | 0.0273 ns |  14.46 ns |      - |       0 B |
                                             From_Byte |  32.00 ns | 0.0393 ns | 0.0368 ns |  31.99 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  30.60 ns | 0.0873 ns | 0.0817 ns |  30.61 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 101.70 ns | 0.2626 ns | 0.2328 ns | 101.62 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.62 ns | 0.0858 ns | 0.0803 ns |  30.66 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  45.93 ns | 0.0688 ns | 0.0644 ns |  45.91 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  14.74 ns | 0.0343 ns | 0.0304 ns |  14.74 ns |      - |       0 B |
                                             From_Char |  31.72 ns | 0.0247 ns | 0.0219 ns |  31.72 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  30.30 ns | 0.0407 ns | 0.0340 ns |  30.31 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 102.24 ns | 0.1120 ns | 0.1047 ns | 102.23 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  30.20 ns | 0.0298 ns | 0.0249 ns |  30.22 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  42.18 ns | 0.1008 ns | 0.0943 ns |  42.13 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  14.76 ns | 0.0275 ns | 0.0244 ns |  14.76 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  43.15 ns | 0.1340 ns | 0.1188 ns |  43.16 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  15.42 ns | 0.0200 ns | 0.0178 ns |  15.42 ns |      - |       0 B |
                                          From_Decimal |  44.44 ns | 0.0412 ns | 0.0386 ns |  44.44 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  39.30 ns | 0.1539 ns | 0.1440 ns |  39.31 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 118.81 ns | 0.1638 ns | 0.1452 ns | 118.77 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.25 ns | 0.1365 ns | 0.1140 ns |  39.24 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  43.36 ns | 0.1039 ns | 0.0868 ns |  43.34 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  14.49 ns | 0.0702 ns | 0.0623 ns |  14.46 ns |      - |       0 B |
                                           From_Double |  36.13 ns | 0.0950 ns | 0.0842 ns |  36.11 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  34.27 ns | 0.0900 ns | 0.0842 ns |  34.25 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 110.26 ns | 0.4422 ns | 0.4136 ns | 110.08 ns | 0.0056 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  35.30 ns | 0.0687 ns | 0.0573 ns |  35.27 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  47.11 ns | 0.1506 ns | 0.1408 ns |  47.11 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  14.73 ns | 0.0333 ns | 0.0312 ns |  14.71 ns |      - |       0 B |
                                            From_Short |  31.66 ns | 0.6531 ns | 0.8939 ns |  31.34 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  29.41 ns | 0.0745 ns | 0.0661 ns |  29.40 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 102.28 ns | 0.7909 ns | 0.7398 ns | 102.06 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  30.58 ns | 0.0684 ns | 0.0606 ns |  30.57 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  42.68 ns | 0.1227 ns | 0.1148 ns |  42.69 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.56 ns | 0.0233 ns | 0.0195 ns |  15.56 ns |      - |       0 B |
                                              From_Int |  30.96 ns | 0.0421 ns | 0.0394 ns |  30.96 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  29.43 ns | 0.1376 ns | 0.1287 ns |  29.36 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 104.36 ns | 0.4057 ns | 0.3795 ns | 104.21 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  29.41 ns | 0.0801 ns | 0.0749 ns |  29.37 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  42.54 ns | 0.0786 ns | 0.0735 ns |  42.54 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.44 ns | 0.0360 ns | 0.0337 ns |  15.43 ns |      - |       0 B |
                                             From_Long |  17.52 ns | 0.0911 ns | 0.0808 ns |  17.51 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  15.82 ns | 0.0253 ns | 0.0225 ns |  15.82 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  89.10 ns | 0.1478 ns | 0.1154 ns |  89.08 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  16.70 ns | 0.0168 ns | 0.0157 ns |  16.71 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  41.85 ns | 0.0395 ns | 0.0350 ns |  41.84 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  14.43 ns | 0.0161 ns | 0.0142 ns |  14.43 ns |      - |       0 B |
                                            From_SByte |  30.96 ns | 0.0602 ns | 0.0563 ns |  30.93 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  29.66 ns | 0.0784 ns | 0.0655 ns |  29.68 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 104.59 ns | 0.1214 ns | 0.1014 ns | 104.59 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  30.74 ns | 0.0524 ns | 0.0490 ns |  30.73 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  41.20 ns | 0.0441 ns | 0.0344 ns |  41.19 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  14.71 ns | 0.0404 ns | 0.0338 ns |  14.70 ns |      - |       0 B |
                                            From_Float |  37.50 ns | 0.2345 ns | 0.2078 ns |  37.45 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  34.97 ns | 0.3501 ns | 0.3104 ns |  34.89 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 116.10 ns | 2.3460 ns | 4.9994 ns | 115.90 ns | 0.0056 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  34.72 ns | 0.0912 ns | 0.0853 ns |  34.68 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  43.56 ns | 0.2198 ns | 0.1949 ns |  43.56 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  14.88 ns | 0.1701 ns | 0.1591 ns |  14.83 ns |      - |       0 B |
                                           From_String | 106.43 ns | 0.2701 ns | 0.2394 ns | 106.36 ns |      - |       0 B |
                                  From_String_AsObject | 106.58 ns | 0.2001 ns | 0.1872 ns | 106.54 ns |      - |       0 B |
                                      From_String_Null |  14.45 ns | 0.0346 ns | 0.0289 ns |  14.45 ns |      - |       0 B |
                             From_String_Null_AsObject |  14.55 ns | 0.0719 ns | 0.0673 ns |  14.55 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  31.00 ns | 0.0443 ns | 0.0414 ns |  31.00 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  29.60 ns | 0.1990 ns | 0.1662 ns |  29.63 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 102.89 ns | 0.1477 ns | 0.1381 ns | 102.90 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  29.45 ns | 0.0803 ns | 0.0751 ns |  29.41 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  41.56 ns | 0.0363 ns | 0.0303 ns |  41.56 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  14.45 ns | 0.0226 ns | 0.0212 ns |  14.44 ns |      - |       0 B |
                                             From_UInt |  32.02 ns | 0.0225 ns | 0.0188 ns |  32.02 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  29.47 ns | 0.0768 ns | 0.0718 ns |  29.44 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 104.45 ns | 0.0887 ns | 0.0829 ns | 104.42 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.43 ns | 0.0655 ns | 0.0613 ns |  29.43 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  42.23 ns | 0.1291 ns | 0.1207 ns |  42.24 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  14.72 ns | 0.0269 ns | 0.0239 ns |  14.71 ns |      - |       0 B |
                                            From_ULong |  33.00 ns | 0.4594 ns | 0.4073 ns |  32.81 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  30.47 ns | 0.4631 ns | 0.3867 ns |  30.36 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 106.61 ns | 2.0889 ns | 2.5654 ns | 105.59 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  30.25 ns | 0.1256 ns | 0.1049 ns |  30.20 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  43.91 ns | 0.2172 ns | 0.2032 ns |  43.88 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.03 ns | 0.1848 ns | 0.1729 ns |  14.96 ns |      - |       0 B |
                                       From_NullObject |  14.76 ns | 0.0535 ns | 0.0446 ns |  14.76 ns |      - |       0 B |
                                           From_DBNull |  15.27 ns | 0.3252 ns | 0.3615 ns |  15.05 ns |      - |       0 B |
                                 From_ConvertibleClass |  27.56 ns | 0.0513 ns | 0.0455 ns |  27.55 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  27.60 ns | 0.0971 ns | 0.0908 ns |  27.60 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  14.48 ns | 0.0565 ns | 0.0501 ns |  14.47 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.04 ns | 0.1638 ns | 0.1452 ns |  15.99 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  14.75 ns | 0.0290 ns | 0.0272 ns |  14.74 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  14.72 ns | 0.0260 ns | 0.0243 ns |  14.71 ns |      - |       0 B |
                                From_ConvertibleStruct |  30.99 ns | 0.0587 ns | 0.0549 ns |  31.00 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  28.88 ns | 0.1236 ns | 0.0965 ns |  28.83 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 110.36 ns | 0.7263 ns | 0.6065 ns | 110.15 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.83 ns | 0.0397 ns | 0.0352 ns |  28.82 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  41.62 ns | 0.1112 ns | 0.1040 ns |  41.63 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.75 ns | 0.0146 ns | 0.0130 ns |  17.75 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  42.18 ns | 1.1584 ns | 1.6613 ns |  41.29 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  14.46 ns | 0.0717 ns | 0.0560 ns |  14.44 ns |      - |       0 B |
                                             From_Enum |  87.99 ns | 0.0897 ns | 0.0796 ns |  87.99 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  85.86 ns | 0.1879 ns | 0.1758 ns |  85.85 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 194.39 ns | 0.8320 ns | 0.7783 ns | 194.20 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  84.70 ns | 0.2138 ns | 0.2000 ns |  84.70 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  41.57 ns | 0.3350 ns | 0.2970 ns |  41.55 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.47 ns | 0.0485 ns | 0.0454 ns |  15.45 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Long.From_DateTime: DefaultJob
  ConvertTo_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Long.From_String_Empty: DefaultJob
  ConvertTo_Long.From_String_Empty_AsObject: DefaultJob
  ConvertTo_Long.From_NonConvertibleClass: DefaultJob
  ConvertTo_Long.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_Long.From_NonConvertibleStruct: DefaultJob
  ConvertTo_Long.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_Long.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_Long.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
