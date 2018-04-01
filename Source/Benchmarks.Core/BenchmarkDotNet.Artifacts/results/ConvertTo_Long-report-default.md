
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  30.97 ns | 0.4287 ns | 0.4010 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  28.19 ns | 0.5518 ns | 0.4891 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  99.45 ns | 0.0915 ns | 0.0764 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.25 ns | 0.4506 ns | 0.4215 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  38.90 ns | 0.0738 ns | 0.0691 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  13.69 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
                                             From_Byte |  29.37 ns | 0.0396 ns | 0.0331 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  27.93 ns | 0.0497 ns | 0.0465 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  97.93 ns | 0.0831 ns | 0.0736 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.17 ns | 0.4494 ns | 0.4204 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  40.13 ns | 0.0671 ns | 0.0627 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  13.97 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
                                             From_Char |  30.14 ns | 0.0393 ns | 0.0349 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  28.64 ns | 0.0120 ns | 0.0094 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  99.08 ns | 0.0900 ns | 0.0798 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  28.63 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  38.95 ns | 0.0782 ns | 0.0731 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  13.99 ns | 0.0079 ns | 0.0061 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  40.80 ns | 0.0440 ns | 0.0368 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  13.69 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                          From_Decimal |  41.10 ns | 0.0780 ns | 0.0730 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  37.22 ns | 0.0857 ns | 0.0760 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 112.61 ns | 0.0536 ns | 0.0476 ns | 0.0075 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.21 ns | 0.0735 ns | 0.0652 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  39.19 ns | 0.0309 ns | 0.0258 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  13.70 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
                                           From_Double |  33.94 ns | 0.0120 ns | 0.0106 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  32.47 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 104.16 ns | 0.0967 ns | 0.0905 ns | 0.0056 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  32.51 ns | 0.0859 ns | 0.0804 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  39.44 ns | 0.0808 ns | 0.0756 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  13.97 ns | 0.0413 ns | 0.0366 ns |      - |       0 B |
                                            From_Short |  29.51 ns | 0.0553 ns | 0.0490 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  27.90 ns | 0.0319 ns | 0.0282 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  97.03 ns | 0.0761 ns | 0.0635 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  27.89 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  39.42 ns | 0.0479 ns | 0.0425 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  14.41 ns | 0.0054 ns | 0.0042 ns |      - |       0 B |
                                              From_Int |  29.43 ns | 0.0574 ns | 0.0509 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  28.60 ns | 0.5972 ns | 0.6133 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  97.08 ns | 0.0214 ns | 0.0167 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  27.92 ns | 0.0130 ns | 0.0101 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  39.95 ns | 0.0505 ns | 0.0472 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  13.87 ns | 0.0164 ns | 0.0137 ns |      - |       0 B |
                                             From_Long |  17.45 ns | 0.0097 ns | 0.0086 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  15.00 ns | 0.0242 ns | 0.0214 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  83.61 ns | 0.0255 ns | 0.0213 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  15.07 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  39.31 ns | 0.0503 ns | 0.0471 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  13.73 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                                            From_SByte |  30.42 ns | 0.0279 ns | 0.0233 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  28.34 ns | 0.5206 ns | 0.4870 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  98.99 ns | 0.0260 ns | 0.0243 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  27.96 ns | 0.0329 ns | 0.0291 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  39.09 ns | 0.0156 ns | 0.0122 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  14.02 ns | 0.0536 ns | 0.0501 ns |      - |       0 B |
                                            From_Float |  34.39 ns | 0.0182 ns | 0.0161 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  32.99 ns | 0.0502 ns | 0.0470 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 105.68 ns | 0.0401 ns | 0.0355 ns | 0.0056 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  33.46 ns | 0.5307 ns | 0.4964 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  41.31 ns | 0.0795 ns | 0.0744 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  13.95 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
                                           From_String | 101.14 ns | 0.1956 ns | 0.1634 ns |      - |       0 B |
                                  From_String_AsObject | 101.04 ns | 0.1600 ns | 0.1496 ns |      - |       0 B |
                                      From_String_Null |  13.69 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                             From_String_Null_AsObject |  13.78 ns | 0.0206 ns | 0.0161 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  29.48 ns | 0.1461 ns | 0.1366 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  28.34 ns | 0.4677 ns | 0.4375 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  98.64 ns | 0.2450 ns | 0.2046 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  27.97 ns | 0.0500 ns | 0.0443 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  41.46 ns | 0.0184 ns | 0.0143 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  13.73 ns | 0.0501 ns | 0.0469 ns |      - |       0 B |
                                             From_UInt |  29.60 ns | 0.0253 ns | 0.0212 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  27.95 ns | 0.0457 ns | 0.0427 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  99.81 ns | 0.0583 ns | 0.0487 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.47 ns | 0.5521 ns | 0.5165 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  38.96 ns | 0.0418 ns | 0.0391 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  13.97 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
                                            From_ULong |  31.14 ns | 0.0192 ns | 0.0160 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  28.68 ns | 0.0535 ns | 0.0501 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  99.36 ns | 0.0438 ns | 0.0410 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  28.67 ns | 0.0490 ns | 0.0458 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  40.89 ns | 0.0513 ns | 0.0480 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  13.97 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                                       From_NullObject |  13.96 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
                                           From_DBNull |  14.24 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.10 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.40 ns | 0.4570 ns | 0.4275 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  13.69 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  13.71 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  13.97 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  13.95 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                                From_ConvertibleStruct |  29.49 ns | 0.0324 ns | 0.0303 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.37 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 104.20 ns | 0.0807 ns | 0.0630 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.36 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  41.98 ns | 0.0803 ns | 0.0752 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  13.96 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  39.09 ns | 0.0159 ns | 0.0124 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  13.75 ns | 0.0370 ns | 0.0346 ns |      - |       0 B |
                                             From_Enum |  83.23 ns | 0.1167 ns | 0.1092 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  81.47 ns | 0.0690 ns | 0.0645 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 181.26 ns | 0.0570 ns | 0.0505 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  77.67 ns | 0.0993 ns | 0.0929 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  39.13 ns | 0.0906 ns | 0.0848 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  13.72 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |

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
