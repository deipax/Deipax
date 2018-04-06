
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.12 ns | 0.0587 ns | 0.0520 ns |      - |       0 B |
                                 From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue | 12.84 ns | 0.0376 ns | 0.0352 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue | 14.37 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 16.26 ns | 0.0172 ns | 0.0125 ns |      - |       0 B |
                                          From_Byte | 12.91 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                                 From_Byte_AsObject | 29.39 ns | 0.0344 ns | 0.0305 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 16.26 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 29.55 ns | 0.0417 ns | 0.0348 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 13.17 ns | 0.0101 ns | 0.0084 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 16.19 ns | 0.0031 ns | 0.0025 ns |      - |       0 B |
                                          From_Char | 12.89 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
                                 From_Char_AsObject | 16.89 ns | 0.0348 ns | 0.0326 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 13.17 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 18.76 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 13.30 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 16.19 ns | 0.0370 ns | 0.0347 ns |      - |       0 B |
                                      From_DateTime | 13.42 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                             From_DateTime_AsObject | 21.01 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue | 13.56 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject | 21.25 ns | 0.0639 ns | 0.0598 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue | 13.88 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 16.19 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                       From_Decimal | 14.51 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
                              From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue | 13.69 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue | 13.56 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 16.24 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                                        From_Double | 12.67 ns | 0.0386 ns | 0.0361 ns |      - |       0 B |
                               From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue | 13.64 ns | 0.0315 ns | 0.0280 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue | 13.68 ns | 0.0310 ns | 0.0259 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 16.23 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
                                         From_Short | 13.20 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
                                From_Short_AsObject | 30.08 ns | 0.0361 ns | 0.0301 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.64 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 29.96 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 13.29 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 16.23 ns | 0.0100 ns | 0.0066 ns |      - |       0 B |
                                           From_Int | 14.43 ns | 0.0024 ns | 0.0018 ns |      - |       0 B |
                                  From_Int_AsObject | 30.84 ns | 0.0875 ns | 0.0819 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.92 ns | 0.0434 ns | 0.0406 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 30.76 ns | 0.0135 ns | 0.0113 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.00 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 16.24 ns | 0.0061 ns | 0.0044 ns |      - |       0 B |
                                          From_Long | 14.42 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                                 From_Long_AsObject | 30.71 ns | 0.0382 ns | 0.0319 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.69 ns | 0.0561 ns | 0.0525 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 30.68 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 14.89 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 16.34 ns | 0.0038 ns | 0.0031 ns |      - |       0 B |
                                         From_SByte | 13.23 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
                                From_SByte_AsObject | 29.94 ns | 0.0998 ns | 0.0934 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.72 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 29.88 ns | 0.0077 ns | 0.0060 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 13.25 ns | 0.0212 ns | 0.0177 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 16.18 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                         From_Float | 12.67 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                                From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue | 12.71 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue | 12.84 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 16.15 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                                        From_String | 22.28 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                               From_String_AsObject | 29.68 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                   From_String_Null | 16.85 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.73 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                  From_String_Empty | 20.21 ns | 0.0146 ns | 0.0106 ns |      - |       0 B |
                         From_String_Empty_AsObject | 22.82 ns | 0.0399 ns | 0.0354 ns |      - |       0 B |
                                        From_UShort | 13.11 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                               From_UShort_AsObject | 29.36 ns | 0.0200 ns | 0.0178 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.33 ns | 0.0167 ns | 0.0140 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 29.34 ns | 0.0115 ns | 0.0089 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.03 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 16.16 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                                          From_UInt | 13.68 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                                 From_UInt_AsObject | 29.89 ns | 0.0112 ns | 0.0087 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 16.67 ns | 0.0053 ns | 0.0045 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 29.94 ns | 0.0698 ns | 0.0653 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 13.24 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 16.25 ns | 0.0453 ns | 0.0401 ns |      - |       0 B |
                                         From_ULong | 13.91 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                                From_ULong_AsObject | 30.42 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.42 ns | 0.0124 ns | 0.0097 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 30.42 ns | 0.0168 ns | 0.0131 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 14.04 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.05 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                                    From_NullObject | 16.04 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
                                        From_DBNull | 13.65 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                              From_ConvertibleClass | 23.80 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 26.95 ns | 0.0561 ns | 0.0497 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.35 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 16.49 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.56 ns | 0.0075 ns | 0.0059 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 29.65 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.93 ns | 0.0499 ns | 0.0467 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 28.31 ns | 0.0721 ns | 0.0675 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.00 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.27 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                                          From_Enum | 14.28 ns | 0.0184 ns | 0.0154 ns |      - |       0 B |
                                 From_Enum_AsObject | 64.25 ns | 0.1499 ns | 0.1402 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 18.07 ns | 0.0360 ns | 0.0336 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 64.23 ns | 0.0824 ns | 0.0731 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 13.15 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 16.44 ns | 0.0103 ns | 0.0081 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Char.From_Bool_AsObject: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
