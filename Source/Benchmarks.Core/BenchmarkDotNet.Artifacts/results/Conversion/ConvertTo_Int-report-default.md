
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  30.89 ns | 0.0158 ns | 0.0132 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.35 ns | 0.0272 ns | 0.0212 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 103.36 ns | 0.0200 ns | 0.0187 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.39 ns | 0.0641 ns | 0.0600 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.14 ns | 0.1009 ns | 0.0944 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.76 ns | 0.0116 ns | 0.0102 ns |      - |       0 B |
                                          From_Byte |  30.89 ns | 0.0111 ns | 0.0099 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.34 ns | 0.0303 ns | 0.0269 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 105.74 ns | 0.0361 ns | 0.0282 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.32 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.93 ns | 0.0477 ns | 0.0446 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.68 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                                          From_Char |  31.68 ns | 0.0072 ns | 0.0060 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.08 ns | 0.0376 ns | 0.0314 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.01 ns | 0.0584 ns | 0.0547 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.17 ns | 0.0743 ns | 0.0620 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.05 ns | 0.1082 ns | 0.1012 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.68 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  43.62 ns | 0.0551 ns | 0.0516 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.40 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                                       From_Decimal |  41.87 ns | 0.0241 ns | 0.0213 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  39.47 ns | 0.1075 ns | 0.0953 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 118.60 ns | 0.0445 ns | 0.0372 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  39.65 ns | 0.1215 ns | 0.1136 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.57 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.03 ns | 0.0089 ns | 0.0075 ns |      - |       0 B |
                                        From_Double |  33.39 ns | 0.0049 ns | 0.0041 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  31.75 ns | 0.0505 ns | 0.0448 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 109.70 ns | 0.0903 ns | 0.0844 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  32.13 ns | 0.0549 ns | 0.0513 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.58 ns | 0.0429 ns | 0.0358 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.69 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                         From_Short |  30.88 ns | 0.0172 ns | 0.0152 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  29.33 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 102.86 ns | 0.0771 ns | 0.0721 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  29.40 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.12 ns | 0.0954 ns | 0.0893 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.70 ns | 0.0317 ns | 0.0297 ns |      - |       0 B |
                                           From_Int |  18.26 ns | 0.0055 ns | 0.0049 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  15.77 ns | 0.0036 ns | 0.0026 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  88.55 ns | 0.0150 ns | 0.0133 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  15.59 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.11 ns | 0.1188 ns | 0.1111 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.43 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                          From_Long |  32.23 ns | 0.0200 ns | 0.0187 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  30.69 ns | 0.0319 ns | 0.0282 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 107.72 ns | 0.0165 ns | 0.0146 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  30.71 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  42.77 ns | 0.0690 ns | 0.0646 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.41 ns | 0.0171 ns | 0.0142 ns |      - |       0 B |
                                         From_SByte |  31.02 ns | 0.0210 ns | 0.0175 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  29.32 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 103.97 ns | 0.0593 ns | 0.0526 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.34 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.31 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.68 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                                         From_Float |  33.53 ns | 0.0205 ns | 0.0191 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  32.96 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 107.94 ns | 0.0357 ns | 0.0279 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  32.01 ns | 0.0285 ns | 0.0252 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.18 ns | 0.1450 ns | 0.1356 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.68 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                        From_String | 107.25 ns | 0.0835 ns | 0.0781 ns |      - |       0 B |
                               From_String_AsObject | 106.89 ns | 0.0460 ns | 0.0431 ns |      - |       0 B |
                                   From_String_Null |  14.41 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.41 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  30.92 ns | 0.0258 ns | 0.0202 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.32 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 103.73 ns | 0.0562 ns | 0.0526 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  29.33 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.62 ns | 0.0643 ns | 0.0601 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.41 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                                          From_UInt |  31.40 ns | 0.0043 ns | 0.0040 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.86 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 104.03 ns | 0.0435 ns | 0.0406 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.87 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.29 ns | 0.1019 ns | 0.0953 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.69 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                                         From_ULong |  32.22 ns | 0.0039 ns | 0.0033 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.66 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 107.29 ns | 0.0210 ns | 0.0175 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.68 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  44.87 ns | 0.0464 ns | 0.0434 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.52 ns | 0.0120 ns | 0.0094 ns |      - |       0 B |
                                    From_NullObject |  14.69 ns | 0.0152 ns | 0.0134 ns |      - |       0 B |
                                        From_DBNull |  15.20 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                              From_ConvertibleClass |  27.44 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.44 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.43 ns | 0.0320 ns | 0.0300 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.39 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                             From_ConvertibleStruct |  30.92 ns | 0.0273 ns | 0.0242 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.78 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 109.94 ns | 0.1326 ns | 0.1240 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.78 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.83 ns | 0.0329 ns | 0.0308 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.42 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                          From_Enum |  85.46 ns | 0.0125 ns | 0.0098 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  83.10 ns | 0.0141 ns | 0.0125 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 190.48 ns | 0.1200 ns | 0.1002 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  80.56 ns | 0.0158 ns | 0.0148 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.38 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.52 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Int.From_DateTime: DefaultJob
  ConvertTo_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo_Int.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Int.From_String_Empty: DefaultJob
  ConvertTo_Int.From_String_Empty_AsObject: DefaultJob
