
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  31.07 ns | 0.2400 ns | 0.2004 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.36 ns | 0.0376 ns | 0.0352 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 103.35 ns | 0.0476 ns | 0.0422 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.40 ns | 0.0317 ns | 0.0281 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.11 ns | 0.0770 ns | 0.0720 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.48 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                                          From_Byte |  30.92 ns | 0.0198 ns | 0.0185 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.41 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 105.58 ns | 0.1332 ns | 0.1245 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.36 ns | 0.0308 ns | 0.0241 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.47 ns | 0.0378 ns | 0.0353 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.68 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                                          From_Char |  31.71 ns | 0.0100 ns | 0.0089 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.14 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.83 ns | 0.0577 ns | 0.0540 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.13 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  42.01 ns | 0.0763 ns | 0.0714 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.93 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  43.47 ns | 0.0367 ns | 0.0286 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.41 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                                       From_Decimal |  42.45 ns | 0.0261 ns | 0.0231 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  39.60 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 118.28 ns | 0.0582 ns | 0.0516 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  39.58 ns | 0.0248 ns | 0.0193 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.34 ns | 0.0378 ns | 0.0353 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.40 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                        From_Double |  32.52 ns | 0.0069 ns | 0.0061 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  30.93 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 108.41 ns | 0.0471 ns | 0.0417 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  30.94 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.61 ns | 0.0606 ns | 0.0538 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.52 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
                                         From_Short |  31.46 ns | 0.0325 ns | 0.0304 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  29.88 ns | 0.0234 ns | 0.0208 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 103.47 ns | 0.0511 ns | 0.0453 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  29.88 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.04 ns | 0.0908 ns | 0.0850 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.69 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                                           From_Int |  32.53 ns | 0.0233 ns | 0.0207 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  29.86 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 104.49 ns | 0.0674 ns | 0.0597 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  29.87 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.33 ns | 0.0900 ns | 0.0842 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.11 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                          From_Long |  32.32 ns | 0.0246 ns | 0.0205 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  30.66 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 105.09 ns | 0.0552 ns | 0.0516 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  32.44 ns | 0.0084 ns | 0.0065 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  41.77 ns | 0.1407 ns | 0.1316 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.41 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                         From_SByte |  31.48 ns | 0.0360 ns | 0.0337 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  30.95 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 104.52 ns | 0.0492 ns | 0.0436 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  30.94 ns | 0.0161 ns | 0.0142 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.45 ns | 0.0491 ns | 0.0459 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  15.11 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                                         From_Float |  32.84 ns | 0.0126 ns | 0.0118 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  31.20 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 106.96 ns | 0.0435 ns | 0.0407 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  31.21 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.11 ns | 0.0792 ns | 0.0740 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.68 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                                        From_String | 104.24 ns | 0.0588 ns | 0.0550 ns |      - |       0 B |
                               From_String_AsObject | 104.20 ns | 0.0875 ns | 0.0818 ns |      - |       0 B |
                                   From_String_Null |  14.41 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.43 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  30.96 ns | 0.0281 ns | 0.0263 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.37 ns | 0.0263 ns | 0.0219 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 103.29 ns | 0.0375 ns | 0.0313 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  29.33 ns | 0.0048 ns | 0.0037 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.91 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.41 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                          From_UInt |  17.18 ns | 0.0157 ns | 0.0147 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  15.60 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  89.34 ns | 0.0578 ns | 0.0541 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  15.77 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.36 ns | 0.0808 ns | 0.0716 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.06 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                         From_ULong |  31.64 ns | 0.0084 ns | 0.0074 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.12 ns | 0.0504 ns | 0.0471 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 104.58 ns | 0.0123 ns | 0.0109 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.12 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.42 ns | 0.0451 ns | 0.0422 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.69 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                    From_NullObject |  14.68 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                                        From_DBNull |  15.22 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                              From_ConvertibleClass |  27.44 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.55 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.42 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.38 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                             From_ConvertibleStruct |  30.90 ns | 0.0146 ns | 0.0129 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.83 ns | 0.0438 ns | 0.0389 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 109.95 ns | 0.0316 ns | 0.0295 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.82 ns | 0.0101 ns | 0.0079 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.50 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.06 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                                          From_Enum |  88.11 ns | 0.0122 ns | 0.0114 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  85.36 ns | 0.0780 ns | 0.0730 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 190.35 ns | 0.1804 ns | 0.1688 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  83.42 ns | 0.0445 ns | 0.0395 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.40 ns | 0.0482 ns | 0.0427 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.69 ns | 0.0028 ns | 0.0019 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_UInt.From_DateTime: DefaultJob
  ConvertTo_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo_UInt.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UInt.From_String_Empty: DefaultJob
  ConvertTo_UInt.From_String_Empty_AsObject: DefaultJob
