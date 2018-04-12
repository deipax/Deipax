
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  13.92 ns | 0.0046 ns | 0.0043 ns |  13.92 ns |      - |       0 B |
                                 From_Bool_AsObject |  25.28 ns | 0.0269 ns | 0.0225 ns |  25.28 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.59 ns | 0.0331 ns | 0.0294 ns |  16.58 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  25.28 ns | 0.0196 ns | 0.0164 ns |  25.29 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  13.92 ns | 0.0041 ns | 0.0032 ns |  13.92 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.15 ns | 0.0144 ns | 0.0134 ns |  17.15 ns |      - |       0 B |
                                          From_Byte |  13.40 ns | 0.0021 ns | 0.0016 ns |  13.40 ns |      - |       0 B |
                                 From_Byte_AsObject |  25.27 ns | 0.0194 ns | 0.0172 ns |  25.27 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.27 ns | 0.0047 ns | 0.0039 ns |  16.27 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  25.28 ns | 0.0158 ns | 0.0148 ns |  25.27 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.16 ns | 0.0022 ns | 0.0018 ns |  14.16 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.15 ns | 0.0078 ns | 0.0069 ns |  17.15 ns |      - |       0 B |
                                          From_Char |  13.40 ns | 0.0006 ns | 0.0005 ns |  13.40 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.16 ns | 0.0152 ns | 0.0135 ns |  13.15 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  13.40 ns | 0.0021 ns | 0.0018 ns |  13.40 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.14 ns | 0.0031 ns | 0.0028 ns |  17.13 ns |      - |       0 B |
                                      From_DateTime |  13.85 ns | 0.0031 ns | 0.0028 ns |  13.84 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.02 ns | 0.0004 ns | 0.0004 ns |  14.02 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.08 ns | 0.0165 ns | 0.0146 ns |  15.08 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.16 ns | 0.0254 ns | 0.0225 ns |  17.16 ns |      - |       0 B |
                                       From_Decimal |  21.44 ns | 0.0102 ns | 0.0090 ns |  21.43 ns |      - |       0 B |
                              From_Decimal_AsObject |  34.19 ns | 0.0156 ns | 0.0138 ns |  34.19 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  35.48 ns | 0.0226 ns | 0.0212 ns |  35.49 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  34.26 ns | 0.0912 ns | 0.0853 ns |  34.27 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.31 ns | 0.0105 ns | 0.0099 ns |  15.31 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.14 ns | 0.0131 ns | 0.0123 ns |  17.14 ns |      - |       0 B |
                                        From_Double |  13.15 ns | 0.0058 ns | 0.0049 ns |  13.15 ns |      - |       0 B |
                               From_Double_AsObject |  25.32 ns | 0.0590 ns | 0.0552 ns |  25.33 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  16.83 ns | 0.0106 ns | 0.0094 ns |  16.83 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  25.33 ns | 0.0107 ns | 0.0095 ns |  25.33 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.05 ns | 0.0163 ns | 0.0152 ns |  15.04 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.14 ns | 0.0316 ns | 0.0296 ns |  17.13 ns |      - |       0 B |
                                         From_Short |  13.41 ns | 0.0136 ns | 0.0128 ns |  13.41 ns |      - |       0 B |
                                From_Short_AsObject |  27.40 ns | 0.0214 ns | 0.0200 ns |  27.40 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  16.14 ns | 0.0096 ns | 0.0090 ns |  16.14 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  26.55 ns | 0.0598 ns | 0.0530 ns |  26.53 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  14.17 ns | 0.0107 ns | 0.0101 ns |  14.17 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.22 ns | 0.0185 ns | 0.0155 ns |  17.22 ns |      - |       0 B |
                                           From_Int |  13.65 ns | 0.0115 ns | 0.0108 ns |  13.65 ns |      - |       0 B |
                                  From_Int_AsObject |  25.31 ns | 0.0514 ns | 0.0481 ns |  25.29 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  15.80 ns | 0.0132 ns | 0.0117 ns |  15.81 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  25.33 ns | 0.0071 ns | 0.0059 ns |  25.33 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  13.92 ns | 0.0143 ns | 0.0126 ns |  13.92 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.13 ns | 0.0103 ns | 0.0086 ns |  17.13 ns |      - |       0 B |
                                          From_Long |  13.69 ns | 0.0037 ns | 0.0035 ns |  13.69 ns |      - |       0 B |
                                 From_Long_AsObject |  25.53 ns | 0.0151 ns | 0.0141 ns |  25.53 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  16.87 ns | 0.0388 ns | 0.0363 ns |  16.86 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  25.54 ns | 0.0110 ns | 0.0079 ns |  25.54 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.05 ns | 0.0109 ns | 0.0102 ns |  15.06 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.17 ns | 0.0284 ns | 0.0266 ns |  17.17 ns |      - |       0 B |
                                         From_SByte |  13.41 ns | 0.0121 ns | 0.0108 ns |  13.41 ns |      - |       0 B |
                                From_SByte_AsObject |  25.33 ns | 0.0095 ns | 0.0084 ns |  25.32 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.28 ns | 0.0102 ns | 0.0096 ns |  16.29 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  25.30 ns | 0.0411 ns | 0.0364 ns |  25.30 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.18 ns | 0.0101 ns | 0.0095 ns |  14.18 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.18 ns | 0.0036 ns | 0.0034 ns |  17.18 ns |      - |       0 B |
                                         From_Float |  13.17 ns | 0.0109 ns | 0.0102 ns |  13.17 ns |      - |       0 B |
                                From_Float_AsObject |  17.81 ns | 0.0323 ns | 0.0302 ns |  17.80 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  15.19 ns | 0.0107 ns | 0.0100 ns |  15.19 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  17.83 ns | 0.0077 ns | 0.0072 ns |  17.83 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.54 ns | 0.0108 ns | 0.0101 ns |  14.54 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.63 ns | 0.0401 ns | 0.0375 ns |  17.61 ns |      - |       0 B |
                                        From_String | 108.68 ns | 0.0668 ns | 0.0625 ns | 108.67 ns |      - |       0 B |
                               From_String_AsObject | 120.16 ns | 0.0323 ns | 0.0286 ns | 120.15 ns |      - |       0 B |
                                   From_String_Null |  15.82 ns | 0.0271 ns | 0.0212 ns |  15.82 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.30 ns | 0.0286 ns | 0.0267 ns |  18.31 ns |      - |       0 B |
                                  From_String_Empty |  16.91 ns | 0.0088 ns | 0.0082 ns |  16.91 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.67 ns | 0.0098 ns | 0.0092 ns |  13.67 ns |      - |       0 B |
                               From_UShort_AsObject |  25.33 ns | 0.0762 ns | 0.0675 ns |  25.34 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.28 ns | 0.0108 ns | 0.0090 ns |  16.29 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  25.33 ns | 0.0088 ns | 0.0069 ns |  25.33 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  13.91 ns | 0.0096 ns | 0.0090 ns |  13.91 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.80 ns | 0.0285 ns | 0.0267 ns |  17.80 ns |      - |       0 B |
                                          From_UInt |  13.65 ns | 0.0135 ns | 0.0127 ns |  13.64 ns |      - |       0 B |
                                 From_UInt_AsObject |  26.66 ns | 0.0056 ns | 0.0052 ns |  26.66 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  16.28 ns | 0.0118 ns | 0.0110 ns |  16.28 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  25.57 ns | 0.0402 ns | 0.0356 ns |  25.57 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.20 ns | 0.0109 ns | 0.0102 ns |  14.20 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.15 ns | 0.0093 ns | 0.0087 ns |  17.15 ns |      - |       0 B |
                                         From_ULong |  13.66 ns | 0.0020 ns | 0.0017 ns |  13.65 ns |      - |       0 B |
                                From_ULong_AsObject |  26.06 ns | 0.0469 ns | 0.0439 ns |  26.04 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  17.10 ns | 0.0127 ns | 0.0100 ns |  17.10 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  26.10 ns | 0.0067 ns | 0.0062 ns |  26.10 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.05 ns | 0.0108 ns | 0.0101 ns |  15.04 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.14 ns | 0.0412 ns | 0.0386 ns |  17.14 ns |      - |       0 B |
                                    From_NullObject |  17.14 ns | 0.0095 ns | 0.0089 ns |  17.15 ns |      - |       0 B |
                                        From_DBNull |  16.03 ns | 0.0037 ns | 0.0029 ns |  16.03 ns |      - |       0 B |
                              From_ConvertibleClass |  22.20 ns | 0.0158 ns | 0.0140 ns |  22.21 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  23.00 ns | 0.0241 ns | 0.0226 ns |  22.99 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.37 ns | 0.0027 ns | 0.0024 ns |  17.37 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.16 ns | 0.0446 ns | 0.0417 ns |  17.16 ns |      - |       0 B |
                             From_ConvertibleStruct |  23.20 ns | 0.0405 ns | 0.0379 ns |  23.19 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  24.31 ns | 0.0072 ns | 0.0064 ns |  24.31 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  26.18 ns | 0.0239 ns | 0.0212 ns |  26.18 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.29 ns | 0.0130 ns | 0.0122 ns |  24.30 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  13.96 ns | 0.0043 ns | 0.0040 ns |  13.96 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.12 ns | 0.0098 ns | 0.0092 ns |  17.13 ns |      - |       0 B |
                                          From_Enum |  13.42 ns | 0.0263 ns | 0.0246 ns |  13.42 ns |      - |       0 B |
                                 From_Enum_AsObject |  56.18 ns | 0.0499 ns | 0.0467 ns |  56.17 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue |  16.27 ns | 0.0007 ns | 0.0006 ns |  16.27 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  56.14 ns | 0.0341 ns | 0.0303 ns |  56.14 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue |  14.17 ns | 0.0119 ns | 0.0106 ns |  14.18 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.16 ns | 0.0439 ns | 0.0390 ns |  17.16 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Float.From_Char_AsObject: DefaultJob
  ConvertTo2_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_String_Empty_AsObject: DefaultJob
