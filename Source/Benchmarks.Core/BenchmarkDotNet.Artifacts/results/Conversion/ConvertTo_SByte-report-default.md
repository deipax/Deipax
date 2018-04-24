
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  30.99 ns | 0.1233 ns | 0.1093 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.34 ns | 0.0278 ns | 0.0232 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 105.38 ns | 0.0580 ns | 0.0542 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.32 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.46 ns | 0.1431 ns | 0.1338 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.41 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                          From_Byte |  31.52 ns | 0.0189 ns | 0.0158 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.87 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 103.91 ns | 0.1046 ns | 0.0979 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.87 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  42.28 ns | 0.0456 ns | 0.0426 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.92 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
                                          From_Char |  32.27 ns | 0.0327 ns | 0.0306 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.66 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.58 ns | 0.0833 ns | 0.0780 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.68 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.79 ns | 0.0438 ns | 0.0410 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.68 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.49 ns | 0.0399 ns | 0.0353 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.43 ns | 0.0233 ns | 0.0206 ns |      - |       0 B |
                                       From_Decimal |  43.66 ns | 0.0063 ns | 0.0049 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  40.78 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 122.70 ns | 0.0874 ns | 0.0818 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  40.82 ns | 0.1055 ns | 0.0987 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.55 ns | 0.0348 ns | 0.0272 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.43 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                        From_Double |  34.95 ns | 0.1424 ns | 0.1189 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  33.40 ns | 0.0388 ns | 0.0324 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 110.70 ns | 0.0797 ns | 0.0665 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  33.73 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.51 ns | 0.1039 ns | 0.0972 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.70 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                         From_Short |  32.25 ns | 0.0076 ns | 0.0067 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  31.76 ns | 0.0227 ns | 0.0213 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 103.83 ns | 0.0424 ns | 0.0376 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  31.81 ns | 0.0267 ns | 0.0223 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.20 ns | 0.1055 ns | 0.0986 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.69 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                                           From_Int |  32.00 ns | 0.0076 ns | 0.0060 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  30.43 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 104.85 ns | 0.0126 ns | 0.0105 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  30.42 ns | 0.0298 ns | 0.0279 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  42.13 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.41 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                          From_Long |  32.26 ns | 0.0167 ns | 0.0139 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  30.67 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 106.42 ns | 0.1362 ns | 0.1274 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  30.67 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  44.58 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.43 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
                                         From_SByte |  17.19 ns | 0.0036 ns | 0.0030 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  15.59 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  88.78 ns | 0.0526 ns | 0.0467 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  15.75 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  41.85 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.68 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
                                         From_Float |  35.01 ns | 0.0283 ns | 0.0264 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  33.63 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 110.00 ns | 0.0773 ns | 0.0685 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  33.69 ns | 0.0521 ns | 0.0487 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.11 ns | 0.1026 ns | 0.0960 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.97 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                                        From_String | 173.57 ns | 0.0265 ns | 0.0221 ns |      - |       0 B |
                               From_String_AsObject | 110.03 ns | 0.0758 ns | 0.0709 ns |      - |       0 B |
                                   From_String_Null |  14.41 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.37 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  31.47 ns | 0.0232 ns | 0.0205 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.89 ns | 0.0372 ns | 0.0348 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 104.29 ns | 0.0271 ns | 0.0254 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  29.89 ns | 0.0489 ns | 0.0433 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.56 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.41 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
                                          From_UInt |  31.44 ns | 0.0307 ns | 0.0272 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.86 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 105.77 ns | 0.0404 ns | 0.0378 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.86 ns | 0.0170 ns | 0.0133 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.40 ns | 0.0782 ns | 0.0694 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.68 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                         From_ULong |  31.50 ns | 0.0149 ns | 0.0132 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  29.90 ns | 0.0740 ns | 0.0692 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 106.56 ns | 0.0689 ns | 0.0611 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  29.86 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.49 ns | 0.0473 ns | 0.0442 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.68 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                                    From_NullObject |  14.72 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
                                        From_DBNull |  15.21 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                              From_ConvertibleClass |  27.48 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.46 ns | 0.0351 ns | 0.0329 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.81 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  14.41 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                             From_ConvertibleStruct |  30.94 ns | 0.0119 ns | 0.0100 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.78 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 108.75 ns | 0.0720 ns | 0.0638 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.80 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.36 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.41 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                          From_Enum |  91.68 ns | 0.0658 ns | 0.0616 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  86.13 ns | 0.0229 ns | 0.0214 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 194.55 ns | 0.1518 ns | 0.1268 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  84.21 ns | 0.0109 ns | 0.0091 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.40 ns | 0.0319 ns | 0.0299 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.68 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_SByte.From_DateTime: DefaultJob
  ConvertTo_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByte.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByte.From_String_Empty: DefaultJob
  ConvertTo_SByte.From_String_Empty_AsObject: DefaultJob
