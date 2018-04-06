
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 14.07 ns | 0.1038 ns | 0.0920 ns |      - |       0 B |
                                 From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue | 13.24 ns | 0.0058 ns | 0.0055 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue | 13.38 ns | 0.0442 ns | 0.0392 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 16.71 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                                          From_Byte | 13.67 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                 From_Byte_AsObject | 31.77 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 17.00 ns | 0.0521 ns | 0.0488 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 31.76 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 13.62 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 16.66 ns | 0.0080 ns | 0.0063 ns |      - |       0 B |
                                          From_Char | 16.42 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                                 From_Char_AsObject | 28.10 ns | 0.0089 ns | 0.0069 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 12.82 ns | 0.0321 ns | 0.0301 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 28.10 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 12.66 ns | 0.0418 ns | 0.0391 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 16.88 ns | 0.0209 ns | 0.0185 ns |      - |       0 B |
                                      From_DateTime | 13.88 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
                             From_DateTime_AsObject | 23.75 ns | 0.0415 ns | 0.0368 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue | 14.21 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject | 25.65 ns | 0.0391 ns | 0.0366 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue | 14.28 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 19.37 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
                                       From_Decimal | 16.02 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                              From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue | 14.53 ns | 0.0433 ns | 0.0405 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue | 14.94 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.21 ns | 0.0182 ns | 0.0162 ns |      - |       0 B |
                                        From_Double | 13.35 ns | 0.0396 ns | 0.0371 ns |      - |       0 B |
                               From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue | 14.09 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue | 14.16 ns | 0.0683 ns | 0.0605 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 16.71 ns | 0.0323 ns | 0.0269 ns |      - |       0 B |
                                         From_Short | 14.01 ns | 0.0374 ns | 0.0350 ns |      - |       0 B |
                                From_Short_AsObject | 32.33 ns | 0.0516 ns | 0.0483 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 17.53 ns | 0.0336 ns | 0.0298 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 32.50 ns | 0.0155 ns | 0.0112 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 13.57 ns | 0.0133 ns | 0.0111 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.38 ns | 0.0274 ns | 0.0256 ns |      - |       0 B |
                                           From_Int | 15.04 ns | 0.0820 ns | 0.0767 ns |      - |       0 B |
                                  From_Int_AsObject | 33.64 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 18.35 ns | 0.0145 ns | 0.0121 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 33.74 ns | 0.0353 ns | 0.0313 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.74 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.32 ns | 0.0364 ns | 0.0340 ns |      - |       0 B |
                                          From_Long | 15.81 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                                 From_Long_AsObject | 33.15 ns | 0.0566 ns | 0.0529 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 19.93 ns | 0.0093 ns | 0.0077 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 33.18 ns | 0.0859 ns | 0.0803 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.67 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.55 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                                         From_SByte | 14.02 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                                From_SByte_AsObject | 32.33 ns | 0.0456 ns | 0.0426 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 17.58 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 32.31 ns | 0.0368 ns | 0.0307 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 13.62 ns | 0.0178 ns | 0.0149 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.55 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
                                         From_Float | 13.41 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                                From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue | 14.38 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue | 13.22 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 16.63 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                                        From_String | 24.34 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
                               From_String_AsObject | 32.38 ns | 0.0970 ns | 0.0908 ns |      - |       0 B |
                                   From_String_Null | 16.71 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
                          From_String_Null_AsObject | 16.98 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                                  From_String_Empty | 20.52 ns | 0.0335 ns | 0.0314 ns |      - |       0 B |
                         From_String_Empty_AsObject | 24.86 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                                        From_UShort | 15.07 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                               From_UShort_AsObject | 31.83 ns | 0.0423 ns | 0.0396 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 17.01 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 31.93 ns | 0.1165 ns | 0.1090 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.71 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.94 ns | 0.0249 ns | 0.0208 ns |      - |       0 B |
                                          From_UInt | 14.01 ns | 0.0231 ns | 0.0193 ns |      - |       0 B |
                                 From_UInt_AsObject | 32.49 ns | 0.0339 ns | 0.0301 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 17.50 ns | 0.0076 ns | 0.0060 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 32.33 ns | 0.0406 ns | 0.0360 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 13.61 ns | 0.0490 ns | 0.0434 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.14 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
                                         From_ULong | 14.54 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                                From_ULong_AsObject | 32.86 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 19.50 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 32.93 ns | 0.0671 ns | 0.0628 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.06 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 16.69 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                                    From_NullObject | 16.69 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                        From_DBNull | 16.88 ns | 0.0399 ns | 0.0354 ns |      - |       0 B |
                              From_ConvertibleClass | 26.44 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 29.40 ns | 0.0873 ns | 0.0774 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.44 ns | 0.0107 ns | 0.0083 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 16.66 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.90 ns | 0.0076 ns | 0.0068 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 30.69 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 26.62 ns | 0.0292 ns | 0.0228 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 30.73 ns | 0.0633 ns | 0.0561 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.73 ns | 0.0100 ns | 0.0083 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.04 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                                          From_Enum | 14.96 ns | 0.0609 ns | 0.0570 ns |      - |       0 B |
                                 From_Enum_AsObject | 69.93 ns | 0.1402 ns | 0.1243 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 18.57 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 69.42 ns | 0.0561 ns | 0.0468 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 13.56 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 16.74 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
