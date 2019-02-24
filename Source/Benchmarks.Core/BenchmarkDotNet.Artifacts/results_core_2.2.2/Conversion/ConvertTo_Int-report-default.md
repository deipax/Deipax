
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.56 ns | 0.0697 ns | 0.0652 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.79 ns | 0.0775 ns | 0.0687 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.30 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.76 ns | 0.0206 ns | 0.0192 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.21 ns | 0.0372 ns | 0.0348 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.03 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                                             From_Byte | 13.04 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.77 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.79 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.80 ns | 0.0653 ns | 0.0579 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.66 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.16 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                                             From_Char | 13.02 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                                    From_Char_AsObject | 23.55 ns | 0.0650 ns | 0.0576 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.79 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 23.53 ns | 0.0383 ns | 0.0359 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.67 ns | 0.0259 ns | 0.0216 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.63 ns | 0.0119 ns | 0.0100 ns |      - |       0 B |
                                         From_DateTime | 13.44 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.30 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.34 ns | 0.0449 ns | 0.0420 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.16 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                                          From_Decimal | 25.00 ns | 0.0252 ns | 0.0224 ns |      - |       0 B |
                                 From_Decimal_AsObject | 32.02 ns | 0.0446 ns | 0.0417 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 25.37 ns | 0.0800 ns | 0.0748 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 32.38 ns | 0.2127 ns | 0.1989 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.31 ns | 0.0328 ns | 0.0307 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.01 ns | 0.0290 ns | 0.0272 ns |      - |       0 B |
                                           From_Double | 15.46 ns | 0.0041 ns | 0.0039 ns |      - |       0 B |
                                  From_Double_AsObject | 24.83 ns | 0.0481 ns | 0.0426 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.36 ns | 0.0052 ns | 0.0047 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 24.82 ns | 0.0421 ns | 0.0373 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.31 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 15.96 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                                            From_Short | 13.21 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                                   From_Short_AsObject | 24.06 ns | 0.0410 ns | 0.0383 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 13.79 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 23.00 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.66 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.17 ns | 0.0170 ns | 0.0151 ns |      - |       0 B |
                                              From_Int | 13.18 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
                                     From_Int_AsObject | 16.84 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.73 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 17.24 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.44 ns | 0.0252 ns | 0.0235 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.93 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                                             From_Long | 14.60 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
                                    From_Long_AsObject | 25.82 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.86 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 24.89 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.30 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.00 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                                            From_SByte | 13.04 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.00 ns | 0.0192 ns | 0.0160 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.73 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.02 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.66 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.84 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                            From_Float | 15.48 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                                   From_Float_AsObject | 26.09 ns | 0.0268 ns | 0.0237 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.62 ns | 0.0332 ns | 0.0310 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 25.07 ns | 0.0464 ns | 0.0411 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.93 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 15.96 ns | 0.0382 ns | 0.0357 ns |      - |       0 B |
                                           From_String | 87.43 ns | 0.0775 ns | 0.0725 ns |      - |       0 B |
                                  From_String_AsObject | 94.47 ns | 0.2346 ns | 0.2080 ns |      - |       0 B |
                                      From_String_Null | 18.17 ns | 0.0192 ns | 0.0171 ns |      - |       0 B |
                             From_String_Null_AsObject | 15.95 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
                                     From_String_Empty | 15.13 ns | 0.0070 ns | 0.0059 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.20 ns | 0.0239 ns | 0.0212 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.00 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 15.63 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.01 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.41 ns | 0.0040 ns | 0.0032 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 18.05 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
                                             From_UInt | 13.69 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.52 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.46 ns | 0.0377 ns | 0.0353 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 23.54 ns | 0.0386 ns | 0.0322 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.70 ns | 0.0378 ns | 0.0354 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.06 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
                                            From_ULong | 14.05 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                                   From_ULong_AsObject | 25.33 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.87 ns | 0.0339 ns | 0.0317 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.27 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.30 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.96 ns | 0.0285 ns | 0.0253 ns |      - |       0 B |
                                       From_NullObject | 17.17 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
                                           From_DBNull | 14.55 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.95 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.93 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.94 ns | 0.0058 ns | 0.0045 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.61 ns | 0.0101 ns | 0.0085 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.94 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.96 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.17 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.03 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.41 ns | 0.0424 ns | 0.0397 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.18 ns | 0.0136 ns | 0.0114 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.22 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.40 ns | 0.0147 ns | 0.0131 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.24 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.17 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.27 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.04 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.82 ns | 0.0094 ns | 0.0073 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.91 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.15 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.92 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.04 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                                             From_Enum | 13.18 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                    From_Enum_AsObject | 52.87 ns | 0.0602 ns | 0.0563 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 13.80 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 52.87 ns | 0.0788 ns | 0.0737 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.43 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.96 ns | 0.0429 ns | 0.0358 ns |      - |       0 B |
                                      From_ParentClass | 14.30 ns | 0.0069 ns | 0.0054 ns |      - |       0 B |
                             From_ParentClass_AsObject | 18.70 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.30 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.05 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                                     From_ParentStruct | 14.05 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 18.68 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.93 ns | 0.0301 ns | 0.0281 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.73 ns | 0.0062 ns | 0.0051 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.92 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.18 ns | 0.0078 ns | 0.0061 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Int.From_String_Empty_AsObject: DefaultJob
