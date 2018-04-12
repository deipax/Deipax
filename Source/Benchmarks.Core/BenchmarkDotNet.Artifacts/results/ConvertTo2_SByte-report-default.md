
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  13.90 ns | 0.0142 ns | 0.0119 ns |  13.90 ns |      - |       0 B |
                                 From_Bool_AsObject |  25.29 ns | 0.0296 ns | 0.0247 ns |  25.28 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.58 ns | 0.0110 ns | 0.0103 ns |  16.59 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  25.30 ns | 0.0298 ns | 0.0279 ns |  25.31 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.43 ns | 0.0123 ns | 0.0115 ns |  14.43 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.05 ns | 0.0181 ns | 0.0169 ns |  18.05 ns |      - |       0 B |
                                          From_Byte |  13.66 ns | 0.0059 ns | 0.0046 ns |  13.66 ns |      - |       0 B |
                                 From_Byte_AsObject |  26.87 ns | 0.0215 ns | 0.0201 ns |  26.87 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.28 ns | 0.0107 ns | 0.0100 ns |  16.29 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  27.12 ns | 0.0306 ns | 0.0286 ns |  27.12 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.17 ns | 0.0119 ns | 0.0111 ns |  14.18 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.11 ns | 0.0119 ns | 0.0111 ns |  17.11 ns |      - |       0 B |
                                          From_Char |  13.65 ns | 0.0102 ns | 0.0096 ns |  13.64 ns |      - |       0 B |
                                 From_Char_AsObject |  26.80 ns | 0.0158 ns | 0.0148 ns |  26.80 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  16.14 ns | 0.0117 ns | 0.0110 ns |  16.14 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  26.81 ns | 0.0199 ns | 0.0186 ns |  26.81 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  14.18 ns | 0.0095 ns | 0.0089 ns |  14.18 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.19 ns | 0.0147 ns | 0.0137 ns |  17.19 ns |      - |       0 B |
                                      From_DateTime |  15.02 ns | 0.0109 ns | 0.0102 ns |  15.02 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  16.32 ns | 0.0095 ns | 0.0088 ns |  16.32 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.05 ns | 0.0112 ns | 0.0104 ns |  14.05 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.10 ns | 0.0098 ns | 0.0082 ns |  17.10 ns |      - |       0 B |
                                       From_Decimal |  25.55 ns | 0.0140 ns | 0.0124 ns |  25.55 ns |      - |       0 B |
                              From_Decimal_AsObject |  35.84 ns | 0.0424 ns | 0.0354 ns |  35.83 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  34.17 ns | 0.0184 ns | 0.0172 ns |  34.18 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  36.20 ns | 0.0316 ns | 0.0246 ns |  36.20 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.31 ns | 0.0171 ns | 0.0160 ns |  15.30 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.79 ns | 0.0147 ns | 0.0130 ns |  18.79 ns |      - |       0 B |
                                        From_Double |  16.83 ns | 0.0105 ns | 0.0098 ns |  16.83 ns |      - |       0 B |
                               From_Double_AsObject |  28.88 ns | 0.0158 ns | 0.0123 ns |  28.88 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  20.92 ns | 0.0158 ns | 0.0148 ns |  20.93 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  28.87 ns | 0.0391 ns | 0.0366 ns |  28.86 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.05 ns | 0.0148 ns | 0.0131 ns |  15.04 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.18 ns | 0.0146 ns | 0.0136 ns |  17.17 ns |      - |       0 B |
                                         From_Short |  14.16 ns | 0.0015 ns | 0.0011 ns |  14.16 ns |      - |       0 B |
                                From_Short_AsObject |  26.74 ns | 0.0250 ns | 0.0234 ns |  26.74 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.10 ns | 0.0036 ns | 0.0030 ns |  19.10 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  26.56 ns | 0.0135 ns | 0.0127 ns |  26.56 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  14.17 ns | 0.0132 ns | 0.0124 ns |  14.16 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.13 ns | 0.0017 ns | 0.0011 ns |  17.13 ns |      - |       0 B |
                                           From_Int |  14.44 ns | 0.0207 ns | 0.0194 ns |  14.43 ns |      - |       0 B |
                                  From_Int_AsObject |  26.32 ns | 0.0195 ns | 0.0173 ns |  26.32 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  17.41 ns | 0.0099 ns | 0.0092 ns |  17.41 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  26.34 ns | 0.0165 ns | 0.0147 ns |  26.34 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  13.94 ns | 0.0396 ns | 0.0371 ns |  13.92 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.09 ns | 0.0185 ns | 0.0173 ns |  17.08 ns |      - |       0 B |
                                          From_Long |  14.49 ns | 0.0041 ns | 0.0038 ns |  14.49 ns |      - |       0 B |
                                 From_Long_AsObject |  27.99 ns | 0.0178 ns | 0.0158 ns |  27.99 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.38 ns | 0.0234 ns | 0.0218 ns |  18.37 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  28.06 ns | 0.0208 ns | 0.0184 ns |  28.06 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.05 ns | 0.0058 ns | 0.0051 ns |  15.05 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.37 ns | 0.0159 ns | 0.0141 ns |  18.37 ns |      - |       0 B |
                                         From_SByte |  13.42 ns | 0.0300 ns | 0.0281 ns |  13.41 ns |      - |       0 B |
                                From_SByte_AsObject |  17.82 ns | 0.0108 ns | 0.0101 ns |  17.81 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  13.92 ns | 0.0073 ns | 0.0068 ns |  13.92 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  17.80 ns | 0.0018 ns | 0.0014 ns |  17.80 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.54 ns | 0.0177 ns | 0.0157 ns |  14.53 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  18.25 ns | 0.0121 ns | 0.0113 ns |  18.25 ns |      - |       0 B |
                                         From_Float |  16.84 ns | 0.0060 ns | 0.0056 ns |  16.84 ns |      - |       0 B |
                                From_Float_AsObject |  29.33 ns | 0.0265 ns | 0.0248 ns |  29.32 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  20.69 ns | 0.0248 ns | 0.0232 ns |  20.69 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  29.15 ns | 0.0222 ns | 0.0208 ns |  29.15 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.17 ns | 0.0052 ns | 0.0046 ns |  14.17 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.64 ns | 0.0143 ns | 0.0134 ns |  17.64 ns |      - |       0 B |
                                        From_String |  91.21 ns | 0.0624 ns | 0.0583 ns |  91.21 ns |      - |       0 B |
                               From_String_AsObject | 101.63 ns | 0.0646 ns | 0.0573 ns | 101.62 ns |      - |       0 B |
                                   From_String_Null |  15.77 ns | 0.0104 ns | 0.0093 ns |  15.77 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.10 ns | 0.0130 ns | 0.0122 ns |  17.10 ns |      - |       0 B |
                                  From_String_Empty |  16.39 ns | 0.0127 ns | 0.0119 ns |  16.39 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.90 ns | 0.0035 ns | 0.0033 ns |  13.90 ns |      - |       0 B |
                               From_UShort_AsObject |  26.64 ns | 0.0186 ns | 0.0174 ns |  26.64 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.28 ns | 0.0120 ns | 0.0100 ns |  16.28 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  26.67 ns | 0.0158 ns | 0.0148 ns |  26.67 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.06 ns | 0.0068 ns | 0.0061 ns |  15.06 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.64 ns | 0.0091 ns | 0.0085 ns |  17.64 ns |      - |       0 B |
                                          From_UInt |  13.68 ns | 0.0315 ns | 0.0294 ns |  13.67 ns |      - |       0 B |
                                 From_UInt_AsObject |  25.82 ns | 0.0144 ns | 0.0134 ns |  25.81 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  16.29 ns | 0.0061 ns | 0.0057 ns |  16.29 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  25.81 ns | 0.0198 ns | 0.0175 ns |  25.81 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.18 ns | 0.0194 ns | 0.0181 ns |  14.18 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.02 ns | 0.0017 ns | 0.0012 ns |  18.02 ns |      - |       0 B |
                                         From_ULong |  13.64 ns | 0.0102 ns | 0.0091 ns |  13.64 ns |      - |       0 B |
                                From_ULong_AsObject |  25.81 ns | 0.0251 ns | 0.0234 ns |  25.80 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  17.34 ns | 0.0010 ns | 0.0009 ns |  17.34 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  25.84 ns | 0.0355 ns | 0.0332 ns |  25.82 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.04 ns | 0.0029 ns | 0.0022 ns |  15.04 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.14 ns | 0.0024 ns | 0.0020 ns |  17.14 ns |      - |       0 B |
                                    From_NullObject |  17.11 ns | 0.0180 ns | 0.0169 ns |  17.11 ns |      - |       0 B |
                                        From_DBNull |  15.33 ns | 0.0021 ns | 0.0016 ns |  15.33 ns |      - |       0 B |
                              From_ConvertibleClass |  22.47 ns | 0.0088 ns | 0.0078 ns |  22.46 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  22.99 ns | 0.0384 ns | 0.0340 ns |  22.97 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.16 ns | 0.0104 ns | 0.0092 ns |  17.15 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.12 ns | 0.0010 ns | 0.0008 ns |  17.12 ns |      - |       0 B |
                             From_ConvertibleStruct |  23.20 ns | 0.0652 ns | 0.0610 ns |  23.23 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  24.30 ns | 0.0647 ns | 0.0605 ns |  24.29 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  25.21 ns | 0.0208 ns | 0.0195 ns |  25.22 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.26 ns | 0.0134 ns | 0.0119 ns |  24.26 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  13.93 ns | 0.0020 ns | 0.0016 ns |  13.93 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.40 ns | 0.0026 ns | 0.0019 ns |  18.40 ns |      - |       0 B |
                                          From_Enum |  14.16 ns | 0.0021 ns | 0.0016 ns |  14.16 ns |      - |       0 B |
                                 From_Enum_AsObject |  57.85 ns | 0.0107 ns | 0.0095 ns |  57.84 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue |  17.59 ns | 0.0007 ns | 0.0006 ns |  17.59 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  58.05 ns | 0.0092 ns | 0.0081 ns |  58.05 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.16 ns | 0.0014 ns | 0.0011 ns |  14.16 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.15 ns | 0.0141 ns | 0.0132 ns |  18.15 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByte.From_String_Empty_AsObject: DefaultJob
