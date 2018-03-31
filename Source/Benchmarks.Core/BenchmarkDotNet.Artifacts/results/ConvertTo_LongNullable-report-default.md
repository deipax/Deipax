
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.309)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435885 Hz, Resolution=291.0458 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  43.32 ns | 0.1372 ns | 0.1283 ns |  43.34 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  40.00 ns | 0.1070 ns | 0.0893 ns |  40.01 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 115.61 ns | 0.1210 ns | 0.1073 ns | 115.61 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  39.95 ns | 0.1128 ns | 0.0942 ns |  39.93 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  42.61 ns | 0.0903 ns | 0.0844 ns |  42.60 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.09 ns | 0.0676 ns | 0.0632 ns |  16.08 ns |      - |       0 B |
                                             From_Byte |  42.52 ns | 0.0207 ns | 0.0173 ns |  42.52 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  40.07 ns | 0.1817 ns | 0.1700 ns |  40.10 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 117.83 ns | 0.1244 ns | 0.1163 ns | 117.83 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  40.05 ns | 0.1871 ns | 0.1659 ns |  39.97 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  42.43 ns | 0.0463 ns | 0.0410 ns |  42.42 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.38 ns | 0.0736 ns | 0.0688 ns |  16.35 ns |      - |       0 B |
                                             From_Char |  43.25 ns | 0.0488 ns | 0.0457 ns |  43.24 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  40.74 ns | 0.0927 ns | 0.0867 ns |  40.71 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 117.11 ns | 0.1890 ns | 0.1768 ns | 117.10 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  40.77 ns | 0.1376 ns | 0.1287 ns |  40.77 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  42.15 ns | 0.0829 ns | 0.0647 ns |  42.14 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.35 ns | 0.0454 ns | 0.0402 ns |  16.34 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  42.24 ns | 0.0749 ns | 0.0701 ns |  42.25 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.07 ns | 0.0366 ns | 0.0343 ns |  16.07 ns |      - |       0 B |
                                          From_Decimal |  54.26 ns | 0.0526 ns | 0.0492 ns |  54.27 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  50.08 ns | 0.1492 ns | 0.1396 ns |  50.06 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 131.37 ns | 0.2335 ns | 0.2184 ns | 131.34 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  49.78 ns | 0.1772 ns | 0.1657 ns |  49.80 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  42.53 ns | 0.0984 ns | 0.0768 ns |  42.51 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.52 ns | 0.4200 ns | 0.7245 ns |  16.17 ns |      - |       0 B |
                                           From_Double |  49.58 ns | 0.7342 ns | 0.6868 ns |  49.27 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  48.15 ns | 1.2185 ns | 1.6679 ns |  47.72 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 129.99 ns | 3.6644 ns | 3.4276 ns | 129.31 ns | 0.0055 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  46.85 ns | 0.1686 ns | 0.1408 ns |  46.82 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  42.55 ns | 0.2223 ns | 0.1970 ns |  42.48 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.33 ns | 0.0156 ns | 0.0138 ns |  16.33 ns |      - |       0 B |
                                            From_Short |  42.53 ns | 0.2015 ns | 0.1787 ns |  42.46 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  40.05 ns | 0.1854 ns | 0.1448 ns |  39.97 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 116.61 ns | 0.6547 ns | 0.5804 ns | 116.37 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  39.96 ns | 0.0752 ns | 0.0628 ns |  39.96 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  43.45 ns | 0.0467 ns | 0.0390 ns |  43.46 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.34 ns | 0.0638 ns | 0.0532 ns |  16.32 ns |      - |       0 B |
                                              From_Int |  41.73 ns | 0.0238 ns | 0.0199 ns |  41.73 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  39.93 ns | 0.0855 ns | 0.0800 ns |  39.92 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 116.33 ns | 0.1154 ns | 0.1023 ns | 116.30 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  39.85 ns | 0.0261 ns | 0.0204 ns |  39.85 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  42.27 ns | 0.0742 ns | 0.0694 ns |  42.28 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.04 ns | 0.0146 ns | 0.0122 ns |  16.04 ns |      - |       0 B |
                                             From_Long |  30.68 ns | 0.1318 ns | 0.1233 ns |  30.72 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  28.60 ns | 0.0755 ns | 0.0669 ns |  28.58 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 103.98 ns | 0.1242 ns | 0.1162 ns | 103.96 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  28.56 ns | 0.0352 ns | 0.0294 ns |  28.55 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  44.17 ns | 0.1540 ns | 0.1441 ns |  44.11 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.06 ns | 0.0572 ns | 0.0507 ns |  16.05 ns |      - |       0 B |
                                            From_SByte |  42.79 ns | 0.0519 ns | 0.0460 ns |  42.78 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  39.92 ns | 0.0901 ns | 0.0843 ns |  39.88 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 117.00 ns | 0.5578 ns | 0.5217 ns | 117.06 ns | 0.0055 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  39.95 ns | 0.0692 ns | 0.0648 ns |  39.94 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  42.97 ns | 0.1684 ns | 0.1406 ns |  42.91 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.35 ns | 0.0463 ns | 0.0433 ns |  16.32 ns |      - |       0 B |
                                            From_Float |  47.72 ns | 0.0453 ns | 0.0424 ns |  47.72 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  45.35 ns | 0.1807 ns | 0.1690 ns |  45.30 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 122.86 ns | 0.1973 ns | 0.1845 ns | 122.78 ns | 0.0055 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  45.26 ns | 0.1145 ns | 0.1015 ns |  45.22 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  42.12 ns | 0.0812 ns | 0.0760 ns |  42.12 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.41 ns | 0.0711 ns | 0.0665 ns |  16.43 ns |      - |       0 B |
                                           From_String | 118.91 ns | 0.1706 ns | 0.1596 ns | 118.90 ns |      - |       0 B |
                                  From_String_AsObject | 119.16 ns | 0.2942 ns | 0.2608 ns | 119.09 ns |      - |       0 B |
                                      From_String_Null |  16.08 ns | 0.0441 ns | 0.0412 ns |  16.07 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.68 ns | 0.0366 ns | 0.0343 ns |  16.67 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  42.41 ns | 0.0542 ns | 0.0507 ns |  42.42 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  39.93 ns | 0.1142 ns | 0.1068 ns |  39.87 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 119.99 ns | 0.1264 ns | 0.1182 ns | 119.96 ns | 0.0055 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  39.91 ns | 0.0886 ns | 0.0829 ns |  39.87 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  42.79 ns | 0.0456 ns | 0.0426 ns |  42.78 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.29 ns | 0.0255 ns | 0.0226 ns |  16.29 ns |      - |       0 B |
                                             From_UInt |  41.79 ns | 0.0341 ns | 0.0319 ns |  41.78 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  39.90 ns | 0.0696 ns | 0.0617 ns |  39.88 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 118.50 ns | 0.0918 ns | 0.0859 ns | 118.45 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  39.89 ns | 0.0473 ns | 0.0395 ns |  39.89 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  42.13 ns | 0.0718 ns | 0.0672 ns |  42.15 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.37 ns | 0.0924 ns | 0.0819 ns |  16.34 ns |      - |       0 B |
                                            From_ULong |  42.58 ns | 0.0338 ns | 0.0317 ns |  42.57 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  40.78 ns | 0.0611 ns | 0.0542 ns |  40.79 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 117.33 ns | 0.0802 ns | 0.0711 ns | 117.31 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  40.76 ns | 0.0877 ns | 0.0732 ns |  40.75 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  43.96 ns | 0.0828 ns | 0.0775 ns |  43.96 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.34 ns | 0.0347 ns | 0.0324 ns |  16.31 ns |      - |       0 B |
                                       From_NullObject |  16.34 ns | 0.0377 ns | 0.0353 ns |  16.32 ns |      - |       0 B |
                                           From_DBNull |  16.80 ns | 0.0408 ns | 0.0382 ns |  16.81 ns |      - |       0 B |
                                 From_ConvertibleClass |  38.08 ns | 0.1119 ns | 0.1047 ns |  38.05 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  38.05 ns | 0.0823 ns | 0.0770 ns |  38.02 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.08 ns | 0.0451 ns | 0.0422 ns |  16.07 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.06 ns | 0.0351 ns | 0.0328 ns |  16.05 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  16.74 ns | 0.0307 ns | 0.0287 ns |  16.73 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.38 ns | 0.0507 ns | 0.0474 ns |  16.38 ns |      - |       0 B |
                                From_ConvertibleStruct |  42.56 ns | 0.0420 ns | 0.0350 ns |  42.55 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  39.39 ns | 0.0769 ns | 0.0720 ns |  39.39 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 121.40 ns | 0.2253 ns | 0.2107 ns | 121.39 ns | 0.0055 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  39.44 ns | 0.1186 ns | 0.1109 ns |  39.41 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  44.65 ns | 0.0500 ns | 0.0467 ns |  44.65 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.34 ns | 0.0356 ns | 0.0333 ns |  16.35 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  42.56 ns | 0.0383 ns | 0.0320 ns |  42.56 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.11 ns | 0.0936 ns | 0.0876 ns |  16.06 ns |      - |       0 B |
                                             From_Enum | 100.34 ns | 0.1174 ns | 0.1098 ns | 100.30 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  96.62 ns | 0.0438 ns | 0.0388 ns |  96.62 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 205.96 ns | 0.2025 ns | 0.1894 ns | 205.99 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  94.26 ns | 0.0638 ns | 0.0566 ns |  94.26 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  42.64 ns | 0.0754 ns | 0.0705 ns |  42.66 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.12 ns | 0.1153 ns | 0.0963 ns |  16.07 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime: DefaultJob
  ConvertTo_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_LongNullable.From_String_Empty: DefaultJob
  ConvertTo_LongNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleClass: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
