
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
                            From_Bool_Nullable_NoValue | 15.04 ns | 0.3094 ns | 0.2894 ns | 15.02 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.77 ns | 0.2091 ns | 0.1956 ns | 17.76 ns |      - |       0 B |
                                             From_Byte | 14.33 ns | 0.2164 ns | 0.1919 ns | 14.34 ns |      - |       0 B |
                                    From_Byte_AsObject | 33.31 ns | 0.6721 ns | 0.7191 ns | 33.15 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 19.50 ns | 0.4809 ns | 0.7901 ns | 19.36 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 32.68 ns | 0.3631 ns | 0.3032 ns | 32.64 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.02 ns | 0.0943 ns | 0.0836 ns | 14.00 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.12 ns | 0.3624 ns | 0.3390 ns | 16.95 ns |      - |       0 B |
                                             From_Char | 15.99 ns | 0.3580 ns | 0.5981 ns | 15.79 ns |      - |       0 B |
                                    From_Char_AsObject | 28.80 ns | 0.2178 ns | 0.2038 ns | 28.74 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.42 ns | 0.3243 ns | 0.3185 ns | 14.30 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 30.07 ns | 0.3092 ns | 0.2582 ns | 30.06 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.26 ns | 0.1623 ns | 0.1518 ns | 14.28 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 20.76 ns | 0.3972 ns | 0.3715 ns | 20.54 ns |      - |       0 B |
                                         From_DateTime | 16.08 ns | 0.0929 ns | 0.0869 ns | 16.07 ns |      - |       0 B |
                                From_DateTime_AsObject | 24.33 ns | 0.2879 ns | 0.2693 ns | 24.21 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue | 19.85 ns | 0.0747 ns | 0.0699 ns | 19.84 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject | 23.15 ns | 0.1626 ns | 0.1441 ns | 23.11 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue | 16.81 ns | 0.3663 ns | 0.7564 ns | 16.62 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.06 ns | 0.2845 ns | 0.2661 ns | 16.98 ns |      - |       0 B |
                                          From_Decimal |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                 From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 15.99 ns | 0.2086 ns | 0.1849 ns | 15.93 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.38 ns | 0.2604 ns | 0.2308 ns | 18.35 ns |      - |       0 B |
                                           From_Double |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                  From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 14.84 ns | 0.2483 ns | 0.2073 ns | 14.83 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.72 ns | 0.2184 ns | 0.1936 ns | 17.73 ns |      - |       0 B |
                                            From_Short | 14.19 ns | 0.1305 ns | 0.1156 ns | 14.16 ns |      - |       0 B |
                                   From_Short_AsObject | 33.89 ns | 0.2165 ns | 0.1808 ns | 33.86 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 23.60 ns | 0.1920 ns | 0.1603 ns | 23.59 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 33.74 ns | 0.7066 ns | 1.1001 ns | 33.46 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.85 ns | 0.1922 ns | 0.1798 ns | 14.81 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.03 ns | 0.2329 ns | 0.2178 ns | 17.01 ns |      - |       0 B |
                                              From_Int | 16.45 ns | 0.3577 ns | 0.3976 ns | 16.29 ns |      - |       0 B |
                                     From_Int_AsObject | 34.37 ns | 0.6901 ns | 0.8728 ns | 34.11 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 19.49 ns | 0.4264 ns | 0.8417 ns | 19.15 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 34.59 ns | 0.7229 ns | 0.7735 ns | 34.43 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.05 ns | 0.2911 ns | 0.2580 ns | 13.94 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.90 ns | 0.1568 ns | 0.1224 ns | 16.85 ns |      - |       0 B |
                                             From_Long | 16.33 ns | 0.2996 ns | 0.2802 ns | 16.29 ns |      - |       0 B |
                                    From_Long_AsObject | 35.83 ns | 0.7408 ns | 1.1313 ns | 35.42 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 20.42 ns | 0.2583 ns | 0.2416 ns | 20.39 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 35.54 ns | 1.1411 ns | 1.4432 ns | 35.31 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 16.06 ns | 0.3495 ns | 0.5742 ns | 15.99 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.25 ns | 0.3977 ns | 0.6073 ns | 18.23 ns |      - |       0 B |
                                            From_SByte | 15.53 ns | 0.3230 ns | 0.3317 ns | 15.40 ns |      - |       0 B |
                                   From_SByte_AsObject | 33.84 ns | 0.8579 ns | 1.1155 ns | 33.45 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 18.98 ns | 0.1940 ns | 0.1620 ns | 18.97 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 34.19 ns | 0.4697 ns | 0.4164 ns | 34.08 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.10 ns | 0.2941 ns | 0.2751 ns | 15.07 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.04 ns | 0.1376 ns | 0.1074 ns | 17.09 ns |      - |       0 B |
                                            From_Float |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                   From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.13 ns | 0.2336 ns | 0.2185 ns | 14.13 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.01 ns | 0.1387 ns | 0.1297 ns | 17.06 ns |      - |       0 B |
                                           From_String | 23.54 ns | 0.1540 ns | 0.1286 ns | 23.55 ns |      - |       0 B |
                                  From_String_AsObject | 35.03 ns | 1.0150 ns | 1.0423 ns | 34.63 ns |      - |       0 B |
                                      From_String_Null | 17.10 ns | 0.2643 ns | 0.2343 ns | 17.03 ns |      - |       0 B |
                             From_String_Null_AsObject | 19.03 ns | 0.6578 ns | 0.5493 ns | 18.94 ns |      - |       0 B |
                                     From_String_Empty | 21.16 ns | 0.2944 ns | 0.2754 ns | 21.11 ns |      - |       0 B |
                            From_String_Empty_AsObject | 25.62 ns | 0.4277 ns | 0.3791 ns | 25.43 ns |      - |       0 B |
                                           From_UShort | 14.04 ns | 0.2675 ns | 0.2502 ns | 13.99 ns |      - |       0 B |
                                  From_UShort_AsObject | 33.41 ns | 0.6905 ns | 1.2627 ns | 33.12 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 17.79 ns | 0.3788 ns | 0.4362 ns | 17.86 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 33.11 ns | 0.7665 ns | 1.2595 ns | 32.69 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.55 ns | 0.1311 ns | 0.1226 ns | 14.53 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.87 ns | 0.3058 ns | 0.2860 ns | 17.84 ns |      - |       0 B |
                                             From_UInt | 14.54 ns | 0.3226 ns | 0.3018 ns | 14.40 ns |      - |       0 B |
                                    From_UInt_AsObject | 34.40 ns | 0.2333 ns | 0.2182 ns | 34.39 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 18.96 ns | 0.1805 ns | 0.1689 ns | 18.91 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 33.78 ns | 0.6987 ns | 0.7766 ns | 33.94 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.78 ns | 0.1340 ns | 0.1188 ns | 14.76 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.86 ns | 0.2139 ns | 0.2000 ns | 17.83 ns |      - |       0 B |
                                            From_ULong | 14.98 ns | 0.1137 ns | 0.1008 ns | 14.95 ns |      - |       0 B |
                                   From_ULong_AsObject | 34.27 ns | 0.6800 ns | 0.6360 ns | 34.47 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 20.89 ns | 0.1302 ns | 0.1154 ns | 20.89 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 33.99 ns | 0.2673 ns | 0.2370 ns | 33.94 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.97 ns | 0.1214 ns | 0.1014 ns | 15.98 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.73 ns | 0.1126 ns | 0.0941 ns | 17.71 ns |      - |       0 B |
                                       From_NullObject | 18.01 ns | 0.2693 ns | 0.2387 ns | 18.07 ns |      - |       0 B |
                                           From_DBNull | 17.25 ns | 0.2547 ns | 0.2383 ns | 17.16 ns |      - |       0 B |
                                 From_ConvertibleClass | 27.54 ns | 0.4600 ns | 0.4078 ns | 27.42 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 31.60 ns | 0.5180 ns | 0.4326 ns | 31.53 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.04 ns | 0.1940 ns | 0.1620 ns | 17.99 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.02 ns | 0.2475 ns | 0.2315 ns | 16.90 ns |      - |       0 B |
                              From_NonConvertibleClass | 24.46 ns | 0.2944 ns | 0.2754 ns | 24.41 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 27.81 ns | 0.3472 ns | 0.3078 ns | 27.71 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 27.03 ns | 0.4186 ns | 0.3710 ns | 26.89 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.77 ns | 0.3786 ns | 0.4507 ns | 17.63 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.94 ns | 0.4702 ns | 0.4169 ns | 23.76 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 31.54 ns | 0.6522 ns | 0.5781 ns | 31.40 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 27.08 ns | 0.2448 ns | 0.2044 ns | 27.05 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 31.38 ns | 0.3227 ns | 0.2695 ns | 31.33 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.78 ns | 0.1366 ns | 0.1211 ns | 14.77 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.53 ns | 0.1496 ns | 0.1326 ns | 17.51 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.39 ns | 0.1190 ns | 0.1055 ns | 14.38 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 26.35 ns | 0.1728 ns | 0.1349 ns | 26.33 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 18.53 ns | 0.4012 ns | 0.6127 ns | 18.34 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 26.43 ns | 0.3987 ns | 0.3535 ns | 26.34 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.86 ns | 0.1643 ns | 0.1456 ns | 14.85 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.96 ns | 0.1102 ns | 0.0920 ns | 16.97 ns |      - |       0 B |
                                             From_Enum | 16.78 ns | 0.3257 ns | 0.3047 ns | 16.68 ns |      - |       0 B |
                                    From_Enum_AsObject | 68.96 ns | 0.4998 ns | 0.4675 ns | 68.88 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 18.59 ns | 0.0880 ns | 0.0780 ns | 18.57 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 69.71 ns | 0.4322 ns | 0.3609 ns | 69.51 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.80 ns | 0.1286 ns | 0.1140 ns | 14.78 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.85 ns | 0.1138 ns | 0.0950 ns | 16.82 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_CharNullable.From_Bool: DefaultJob
  ConvertTo2_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo2_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double: DefaultJob
  ConvertTo2_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo2_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float: DefaultJob
  ConvertTo2_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo2_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
