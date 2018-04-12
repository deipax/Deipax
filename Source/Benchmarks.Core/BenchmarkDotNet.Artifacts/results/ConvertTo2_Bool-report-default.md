
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 13.69 ns | 0.1480 ns | 0.1312 ns | 13.67 ns |      - |       0 B |
                                 From_Bool_AsObject | 18.20 ns | 0.0177 ns | 0.0138 ns | 18.20 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 14.67 ns | 0.1243 ns | 0.1163 ns | 14.60 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 17.95 ns | 0.0225 ns | 0.0199 ns | 17.95 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.80 ns | 0.0091 ns | 0.0071 ns | 13.80 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.42 ns | 0.1177 ns | 0.1101 ns | 17.47 ns |      - |       0 B |
                                          From_Byte | 13.32 ns | 0.0511 ns | 0.0453 ns | 13.29 ns |      - |       0 B |
                                 From_Byte_AsObject | 25.75 ns | 0.1172 ns | 0.1096 ns | 25.84 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 16.13 ns | 0.0296 ns | 0.0262 ns | 16.13 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.66 ns | 0.0804 ns | 0.0752 ns | 25.62 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.09 ns | 0.0483 ns | 0.0429 ns | 14.08 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.37 ns | 0.0274 ns | 0.0214 ns | 17.37 ns |      - |       0 B |
                                          From_Char | 13.64 ns | 0.1304 ns | 0.1220 ns | 13.69 ns |      - |       0 B |
                                 From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue | 13.42 ns | 0.0087 ns | 0.0073 ns | 13.41 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue | 13.38 ns | 0.1333 ns | 0.1247 ns | 13.31 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.17 ns | 0.0347 ns | 0.0271 ns | 17.16 ns |      - |       0 B |
                                      From_DateTime | 13.90 ns | 0.1137 ns | 0.1063 ns | 13.85 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.17 ns | 0.0588 ns | 0.0522 ns | 14.14 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.16 ns | 0.0269 ns | 0.0225 ns | 14.17 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 18.26 ns | 0.1344 ns | 0.1257 ns | 18.19 ns |      - |       0 B |
                                       From_Decimal | 23.36 ns | 0.1577 ns | 0.1398 ns | 23.31 ns |      - |       0 B |
                              From_Decimal_AsObject | 36.70 ns | 0.2420 ns | 0.2264 ns | 36.59 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 27.37 ns | 0.0750 ns | 0.0665 ns | 27.34 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 36.30 ns | 0.1536 ns | 0.1361 ns | 36.25 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 16.11 ns | 0.7343 ns | 0.6868 ns | 15.82 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.24 ns | 0.0216 ns | 0.0202 ns | 17.23 ns |      - |       0 B |
                                        From_Double | 13.46 ns | 0.0089 ns | 0.0075 ns | 13.46 ns |      - |       0 B |
                               From_Double_AsObject | 27.27 ns | 0.0414 ns | 0.0346 ns | 27.25 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 17.82 ns | 0.0143 ns | 0.0127 ns | 17.81 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 25.56 ns | 0.0472 ns | 0.0441 ns | 25.53 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.04 ns | 0.0009 ns | 0.0007 ns | 15.04 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.13 ns | 0.0103 ns | 0.0091 ns | 17.12 ns |      - |       0 B |
                                         From_Short | 13.26 ns | 0.0159 ns | 0.0141 ns | 13.26 ns |      - |       0 B |
                                From_Short_AsObject | 25.50 ns | 0.0061 ns | 0.0051 ns | 25.50 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.07 ns | 0.0084 ns | 0.0075 ns | 16.06 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.27 ns | 0.0030 ns | 0.0022 ns | 25.27 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.02 ns | 0.0012 ns | 0.0009 ns | 14.02 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.71 ns | 0.0324 ns | 0.0270 ns | 17.70 ns |      - |       0 B |
                                           From_Int | 13.44 ns | 0.0380 ns | 0.0355 ns | 13.45 ns |      - |       0 B |
                                  From_Int_AsObject | 25.59 ns | 0.0124 ns | 0.0104 ns | 25.60 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 16.11 ns | 0.0040 ns | 0.0031 ns | 16.11 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 25.29 ns | 0.0314 ns | 0.0294 ns | 25.28 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.08 ns | 0.0459 ns | 0.0430 ns | 14.06 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 18.74 ns | 0.0103 ns | 0.0096 ns | 18.74 ns |      - |       0 B |
                                          From_Long | 13.44 ns | 0.0096 ns | 0.0090 ns | 13.44 ns |      - |       0 B |
                                 From_Long_AsObject | 25.29 ns | 0.0187 ns | 0.0175 ns | 25.29 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 17.00 ns | 0.0465 ns | 0.0435 ns | 17.00 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 25.47 ns | 0.3467 ns | 0.3243 ns | 25.29 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.09 ns | 0.0345 ns | 0.0322 ns | 15.08 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 18.25 ns | 0.0091 ns | 0.0081 ns | 18.26 ns |      - |       0 B |
                                         From_SByte | 14.48 ns | 0.0094 ns | 0.0083 ns | 14.48 ns |      - |       0 B |
                                From_SByte_AsObject | 25.29 ns | 0.0206 ns | 0.0183 ns | 25.29 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.13 ns | 0.0506 ns | 0.0449 ns | 16.12 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.37 ns | 0.0160 ns | 0.0142 ns | 25.38 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.02 ns | 0.0015 ns | 0.0013 ns | 14.02 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 19.56 ns | 0.0012 ns | 0.0008 ns | 19.56 ns |      - |       0 B |
                                         From_Float | 13.47 ns | 0.0083 ns | 0.0073 ns | 13.46 ns |      - |       0 B |
                                From_Float_AsObject | 25.32 ns | 0.0148 ns | 0.0123 ns | 25.32 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 16.07 ns | 0.0007 ns | 0.0006 ns | 16.07 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 25.33 ns | 0.0197 ns | 0.0185 ns | 25.33 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.35 ns | 0.0015 ns | 0.0011 ns | 14.35 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.12 ns | 0.0126 ns | 0.0098 ns | 17.12 ns |      - |       0 B |
                                        From_String | 33.58 ns | 0.0713 ns | 0.0667 ns | 33.59 ns |      - |       0 B |
                               From_String_AsObject | 43.55 ns | 0.0330 ns | 0.0293 ns | 43.56 ns |      - |       0 B |
                                   From_String_Null | 15.58 ns | 0.0138 ns | 0.0129 ns | 15.58 ns |      - |       0 B |
                          From_String_Null_AsObject | 18.10 ns | 0.0505 ns | 0.0472 ns | 18.09 ns |      - |       0 B |
                                  From_String_Empty | 15.75 ns | 0.0095 ns | 0.0089 ns | 15.74 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                        From_UShort | 13.42 ns | 0.0040 ns | 0.0031 ns | 13.42 ns |      - |       0 B |
                               From_UShort_AsObject | 25.34 ns | 0.0894 ns | 0.0793 ns | 25.34 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.07 ns | 0.0118 ns | 0.0110 ns | 16.08 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 25.34 ns | 0.0096 ns | 0.0085 ns | 25.34 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 15.88 ns | 0.0057 ns | 0.0053 ns | 15.88 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.13 ns | 0.0388 ns | 0.0363 ns | 17.14 ns |      - |       0 B |
                                          From_UInt | 13.28 ns | 0.0098 ns | 0.0092 ns | 13.29 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.61 ns | 0.2181 ns | 0.2040 ns | 25.59 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 16.07 ns | 0.0105 ns | 0.0098 ns | 16.08 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 26.48 ns | 0.0698 ns | 0.0653 ns | 26.45 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.03 ns | 0.0140 ns | 0.0131 ns | 14.03 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.88 ns | 0.0060 ns | 0.0053 ns | 17.88 ns |      - |       0 B |
                                         From_ULong | 13.26 ns | 0.0071 ns | 0.0067 ns | 13.27 ns |      - |       0 B |
                                From_ULong_AsObject | 25.31 ns | 0.0390 ns | 0.0346 ns | 25.31 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.62 ns | 0.0128 ns | 0.0120 ns | 17.62 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 25.35 ns | 0.0235 ns | 0.0220 ns | 25.35 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.05 ns | 0.0109 ns | 0.0102 ns | 15.05 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 19.62 ns | 0.0391 ns | 0.0366 ns | 19.61 ns |      - |       0 B |
                                    From_NullObject | 17.62 ns | 0.0148 ns | 0.0139 ns | 17.62 ns |      - |       0 B |
                                        From_DBNull | 17.58 ns | 0.0121 ns | 0.0113 ns | 17.59 ns |      - |       0 B |
                              From_ConvertibleClass | 23.55 ns | 0.0245 ns | 0.0230 ns | 23.55 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 23.09 ns | 0.0373 ns | 0.0312 ns | 23.09 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.37 ns | 0.0265 ns | 0.0235 ns | 17.37 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.13 ns | 0.0076 ns | 0.0063 ns | 17.13 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.41 ns | 0.0252 ns | 0.0236 ns | 22.40 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.29 ns | 0.0421 ns | 0.0394 ns | 24.28 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.03 ns | 0.0286 ns | 0.0254 ns | 25.03 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.30 ns | 0.0130 ns | 0.0109 ns | 24.30 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 14.05 ns | 0.0095 ns | 0.0089 ns | 14.05 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.20 ns | 0.0050 ns | 0.0042 ns | 17.20 ns |      - |       0 B |
                                          From_Enum | 13.25 ns | 0.0006 ns | 0.0005 ns | 13.25 ns |      - |       0 B |
                                 From_Enum_AsObject | 57.07 ns | 0.0205 ns | 0.0192 ns | 57.06 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 16.06 ns | 0.0038 ns | 0.0032 ns | 16.06 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 56.63 ns | 0.0165 ns | 0.0154 ns | 56.62 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.02 ns | 0.0027 ns | 0.0021 ns | 14.02 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 19.73 ns | 0.0016 ns | 0.0013 ns | 19.73 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_String_Empty_AsObject: DefaultJob
