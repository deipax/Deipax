
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  31.77 ns | 0.6049 ns | 0.5363 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.44 ns | 0.1188 ns | 0.1053 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 104.96 ns | 0.1811 ns | 0.1694 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.46 ns | 0.1020 ns | 0.0954 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.23 ns | 0.0567 ns | 0.0503 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.57 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                                          From_Byte |  31.08 ns | 0.0317 ns | 0.0264 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.46 ns | 0.1053 ns | 0.0985 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 103.92 ns | 0.1896 ns | 0.1774 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.40 ns | 0.0259 ns | 0.0230 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.46 ns | 0.0228 ns | 0.0151 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.70 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  41.27 ns | 0.0716 ns | 0.0598 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.73 ns | 0.0407 ns | 0.0381 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  44.17 ns | 0.0859 ns | 0.0803 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.43 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                       From_Decimal |  38.23 ns | 0.0236 ns | 0.0197 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  35.53 ns | 0.0638 ns | 0.0597 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 115.34 ns | 0.1845 ns | 0.1726 ns | 0.0075 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  35.49 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.13 ns | 0.0771 ns | 0.0644 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.44 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                                        From_Double |  17.37 ns | 0.0157 ns | 0.0139 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  15.62 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  89.02 ns | 0.2109 ns | 0.1973 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  15.78 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.15 ns | 0.0813 ns | 0.0760 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.91 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
                                         From_Short |  31.41 ns | 0.0513 ns | 0.0400 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  29.75 ns | 0.1237 ns | 0.1157 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 105.48 ns | 0.2389 ns | 0.1995 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  29.67 ns | 0.0174 ns | 0.0145 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  44.24 ns | 0.0986 ns | 0.0874 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.72 ns | 0.0315 ns | 0.0294 ns |      - |       0 B |
                                           From_Int |  31.07 ns | 0.0513 ns | 0.0455 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  30.47 ns | 0.0422 ns | 0.0353 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 104.20 ns | 0.2665 ns | 0.2492 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  29.36 ns | 0.0101 ns | 0.0079 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.07 ns | 0.0942 ns | 0.0881 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.43 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                                          From_Long |  31.71 ns | 0.0807 ns | 0.0754 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  30.78 ns | 0.0792 ns | 0.0740 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 106.50 ns | 0.1354 ns | 0.1267 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  29.69 ns | 0.0890 ns | 0.0832 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  41.08 ns | 0.0721 ns | 0.0674 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.47 ns | 0.0386 ns | 0.0361 ns |      - |       0 B |
                                         From_SByte |  30.99 ns | 0.0215 ns | 0.0180 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  29.45 ns | 0.0766 ns | 0.0640 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 104.50 ns | 0.2788 ns | 0.2608 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.40 ns | 0.0214 ns | 0.0178 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.20 ns | 0.0843 ns | 0.0747 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.02 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
                                         From_Float |  31.03 ns | 0.0914 ns | 0.0763 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  29.39 ns | 0.0319 ns | 0.0283 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 106.50 ns | 0.2121 ns | 0.1984 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  29.60 ns | 0.1052 ns | 0.0984 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.20 ns | 0.0601 ns | 0.0563 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.74 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
                                        From_String | 125.27 ns | 0.0677 ns | 0.0600 ns |      - |       0 B |
                               From_String_AsObject | 125.60 ns | 0.3919 ns | 0.3666 ns |      - |       0 B |
                                   From_String_Null |  15.59 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.45 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  31.07 ns | 0.0519 ns | 0.0460 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.44 ns | 0.0390 ns | 0.0304 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 103.99 ns | 0.0705 ns | 0.0551 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  30.52 ns | 0.0575 ns | 0.0480 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.91 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.46 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                                          From_UInt |  31.35 ns | 0.0179 ns | 0.0150 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.65 ns | 0.0298 ns | 0.0249 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 104.45 ns | 0.1928 ns | 0.1709 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.70 ns | 0.0706 ns | 0.0660 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.40 ns | 0.0622 ns | 0.0582 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.14 ns | 0.0194 ns | 0.0162 ns |      - |       0 B |
                                         From_ULong |  31.94 ns | 0.0318 ns | 0.0282 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.21 ns | 0.0512 ns | 0.0454 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 107.22 ns | 0.0548 ns | 0.0428 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.20 ns | 0.0324 ns | 0.0270 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  40.83 ns | 0.0649 ns | 0.0575 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.72 ns | 0.0287 ns | 0.0269 ns |      - |       0 B |
                                    From_NullObject |  14.72 ns | 0.0412 ns | 0.0385 ns |      - |       0 B |
                                        From_DBNull |  15.01 ns | 0.0377 ns | 0.0353 ns |      - |       0 B |
                              From_ConvertibleClass |  27.47 ns | 0.0230 ns | 0.0179 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.51 ns | 0.0473 ns | 0.0443 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.72 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  14.43 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                             From_ConvertibleStruct |  31.05 ns | 0.0205 ns | 0.0182 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.82 ns | 0.0314 ns | 0.0262 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 112.47 ns | 0.2739 ns | 0.2562 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.82 ns | 0.0196 ns | 0.0153 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.76 ns | 0.0134 ns | 0.0105 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.48 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
                                          From_Enum |  87.09 ns | 0.1637 ns | 0.1531 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  84.62 ns | 0.0207 ns | 0.0184 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 189.75 ns | 0.2375 ns | 0.2105 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  87.59 ns | 0.0410 ns | 0.0342 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  43.24 ns | 0.0758 ns | 0.0709 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.11 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Double.From_Char: DefaultJob
  ConvertTo_Double.From_Char_AsObject: DefaultJob
  ConvertTo_Double.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime: DefaultJob
  ConvertTo_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo_Double.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Double.From_String_Empty: DefaultJob
  ConvertTo_Double.From_String_Empty_AsObject: DefaultJob
