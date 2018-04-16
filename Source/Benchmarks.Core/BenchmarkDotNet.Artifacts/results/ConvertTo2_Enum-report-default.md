
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 39.74 ns | 0.4151 ns | 0.3883 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject | 52.85 ns | 0.1008 ns | 0.0841 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 42.76 ns | 0.0491 ns | 0.0435 ns | 0.0057 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject | 53.10 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.68 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.35 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                             From_Byte | 38.29 ns | 0.0205 ns | 0.0192 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject | 52.40 ns | 0.0570 ns | 0.0476 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 42.46 ns | 0.0159 ns | 0.0141 ns | 0.0057 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject | 52.65 ns | 0.0748 ns | 0.0700 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.95 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.34 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                             From_Char | 36.40 ns | 0.0267 ns | 0.0250 ns | 0.0057 |      24 B |
                                    From_Char_AsObject | 52.00 ns | 0.0412 ns | 0.0365 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 41.01 ns | 0.0223 ns | 0.0209 ns | 0.0057 |      24 B |
                 From_Char_Nullable_WithValue_AsObject | 51.81 ns | 0.0337 ns | 0.0299 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.94 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.36 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                                         From_DateTime | 38.59 ns | 0.0062 ns | 0.0055 ns | 0.0057 |      24 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 40.90 ns | 0.0425 ns | 0.0397 ns | 0.0057 |      24 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 16.74 ns | 0.0067 ns | 0.0060 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.38 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                          From_Decimal | 52.44 ns | 0.0254 ns | 0.0237 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject | 66.08 ns | 0.0928 ns | 0.0868 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 57.93 ns | 0.0446 ns | 0.0417 ns | 0.0075 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | 67.79 ns | 0.0677 ns | 0.0633 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 16.13 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.33 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                                           From_Double | 41.67 ns | 0.0320 ns | 0.0283 ns | 0.0057 |      24 B |
                                  From_Double_AsObject | 54.55 ns | 0.0855 ns | 0.0799 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 45.09 ns | 0.0105 ns | 0.0088 ns | 0.0057 |      24 B |
               From_Double_Nullable_WithValue_AsObject | 54.51 ns | 0.0914 ns | 0.0855 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.88 ns | 0.0120 ns | 0.0101 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.35 ns | 0.0177 ns | 0.0165 ns |      - |       0 B |
                                            From_Short | 38.56 ns | 0.0184 ns | 0.0172 ns | 0.0057 |      24 B |
                                   From_Short_AsObject | 53.44 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 42.34 ns | 0.0594 ns | 0.0555 ns | 0.0057 |      24 B |
                From_Short_Nullable_WithValue_AsObject | 53.96 ns | 0.0916 ns | 0.0715 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.94 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.40 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
                                              From_Int | 38.89 ns | 0.0045 ns | 0.0038 ns | 0.0057 |      24 B |
                                     From_Int_AsObject | 43.77 ns | 0.0544 ns | 0.0509 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 41.71 ns | 0.0300 ns | 0.0266 ns | 0.0057 |      24 B |
                  From_Int_Nullable_WithValue_AsObject | 44.11 ns | 0.0173 ns | 0.0145 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.67 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.12 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                             From_Long | 40.18 ns | 0.0220 ns | 0.0205 ns | 0.0057 |      24 B |
                                    From_Long_AsObject | 56.17 ns | 0.0270 ns | 0.0226 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 45.12 ns | 0.0319 ns | 0.0298 ns | 0.0057 |      24 B |
                 From_Long_Nullable_WithValue_AsObject | 55.59 ns | 0.0390 ns | 0.0364 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.86 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.33 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                                            From_SByte | 38.53 ns | 0.0163 ns | 0.0153 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject | 53.89 ns | 0.0362 ns | 0.0339 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 43.21 ns | 0.0262 ns | 0.0232 ns | 0.0057 |      24 B |
                From_SByte_Nullable_WithValue_AsObject | 52.96 ns | 0.0689 ns | 0.0644 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.94 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.33 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                            From_Float | 41.66 ns | 0.0202 ns | 0.0179 ns | 0.0057 |      24 B |
                                   From_Float_AsObject | 57.22 ns | 0.0416 ns | 0.0369 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 44.56 ns | 0.0181 ns | 0.0160 ns | 0.0057 |      24 B |
                From_Float_Nullable_WithValue_AsObject | 54.76 ns | 0.0567 ns | 0.0531 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.94 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.31 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                                           From_String | 49.35 ns | 0.0286 ns | 0.0223 ns |      - |       0 B |
                                  From_String_AsObject | 50.21 ns | 0.0255 ns | 0.0226 ns |      - |       0 B |
                                      From_String_Null | 17.24 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.33 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                     From_String_Empty | 24.89 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                            From_String_Empty_AsObject | 25.42 ns | 0.0073 ns | 0.0064 ns |      - |       0 B |
                                           From_UShort | 38.82 ns | 0.0189 ns | 0.0176 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject | 52.53 ns | 0.0606 ns | 0.0567 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 42.46 ns | 0.0036 ns | 0.0026 ns | 0.0057 |      24 B |
               From_UShort_Nullable_WithValue_AsObject | 52.58 ns | 0.0582 ns | 0.0545 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.66 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.33 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                                             From_UInt | 38.82 ns | 0.0075 ns | 0.0066 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject | 53.17 ns | 0.0412 ns | 0.0386 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 43.05 ns | 0.0099 ns | 0.0083 ns | 0.0057 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject | 53.41 ns | 0.0565 ns | 0.0529 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.95 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.88 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                            From_ULong | 39.70 ns | 0.0147 ns | 0.0130 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject | 55.52 ns | 0.0377 ns | 0.0334 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 44.75 ns | 0.0408 ns | 0.0362 ns | 0.0057 |      24 B |
                From_ULong_Nullable_WithValue_AsObject | 55.98 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.88 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.35 ns | 0.0110 ns | 0.0102 ns |      - |       0 B |
                                       From_NullObject | 18.04 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                                           From_DBNull | 17.61 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                 From_ConvertibleClass | 49.71 ns | 0.0365 ns | 0.0341 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 49.97 ns | 0.0476 ns | 0.0422 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.29 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 20.15 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                              From_NonConvertibleClass | 40.95 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 48.51 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 17.27 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.34 ns | 0.0129 ns | 0.0107 ns |      - |       0 B |
                                From_ConvertibleStruct | 49.99 ns | 0.0159 ns | 0.0149 ns | 0.0114 |      48 B |
                       From_ConvertibleStruct_AsObject | 51.14 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 51.61 ns | 0.4805 ns | 0.4012 ns | 0.0114 |      48 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 51.60 ns | 0.1252 ns | 0.1110 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 16.88 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.03 ns | 0.0686 ns | 0.0573 ns |      - |       0 B |
                             From_NonConvertibleStruct | 36.60 ns | 0.0510 ns | 0.0477 ns | 0.0057 |      24 B |
                    From_NonConvertibleStruct_AsObject | 46.85 ns | 0.9687 ns | 0.8587 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 39.85 ns | 0.0744 ns | 0.0622 ns | 0.0057 |      24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 49.08 ns | 0.2384 ns | 0.2113 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.75 ns | 0.0611 ns | 0.0542 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.76 ns | 0.3809 ns | 0.3563 ns |      - |       0 B |
                                             From_Enum | 14.90 ns | 0.2747 ns | 0.2570 ns |      - |       0 B |
                                    From_Enum_AsObject | 18.02 ns | 0.2229 ns | 0.1976 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue | 14.82 ns | 0.1259 ns | 0.1178 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 18.81 ns | 0.0700 ns | 0.0584 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue | 14.40 ns | 0.2384 ns | 0.1991 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.70 ns | 0.2544 ns | 0.2380 ns |      - |       0 B |
                                      From_ParentClass | 40.92 ns | 0.0385 ns | 0.0341 ns |      - |       0 B |
                             From_ParentClass_AsObject | 47.42 ns | 0.4460 ns | 0.4172 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.95 ns | 0.1049 ns | 0.0876 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.63 ns | 0.3809 ns | 0.3377 ns |      - |       0 B |
                                     From_ParentStruct | 37.03 ns | 0.1287 ns | 0.1074 ns | 0.0057 |      24 B |
                            From_ParentStruct_AsObject | 47.11 ns | 0.3088 ns | 0.2579 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 41.22 ns | 1.0895 ns | 1.1188 ns | 0.0057 |      24 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 48.06 ns | 0.5223 ns | 0.4630 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.13 ns | 0.3306 ns | 0.3935 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.42 ns | 0.0444 ns | 0.0394 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
