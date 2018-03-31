
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 12.90 ns | 0.0250 ns | 0.0221 ns |      - |       0 B |
                                    From_Bool_AsObject | 25.13 ns | 0.0766 ns | 0.0717 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 16.40 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 25.12 ns | 0.0575 ns | 0.0481 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.48 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 15.65 ns | 0.0260 ns | 0.0203 ns |      - |       0 B |
                                             From_Byte | 12.47 ns | 0.1003 ns | 0.0939 ns |      - |       0 B |
                                    From_Byte_AsObject | 25.44 ns | 0.2066 ns | 0.1832 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 16.38 ns | 0.0432 ns | 0.0404 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.23 ns | 0.0883 ns | 0.0826 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 12.58 ns | 0.0225 ns | 0.0188 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 15.67 ns | 0.1444 ns | 0.1351 ns |      - |       0 B |
                                             From_Char | 12.42 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                                    From_Char_AsObject | 26.03 ns | 0.0193 ns | 0.0140 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 15.91 ns | 0.0132 ns | 0.0095 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 26.18 ns | 0.2579 ns | 0.2413 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.50 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 15.62 ns | 0.0179 ns | 0.0150 ns |      - |       0 B |
                                         From_DateTime |       NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |       NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 13.33 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 15.87 ns | 0.0243 ns | 0.0216 ns |      - |       0 B |
                                          From_Decimal | 23.37 ns | 0.0787 ns | 0.0697 ns |      - |       0 B |
                                 From_Decimal_AsObject | 34.94 ns | 0.0902 ns | 0.0799 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 33.42 ns | 0.0587 ns | 0.0549 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 35.61 ns | 0.0718 ns | 0.0671 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 13.25 ns | 0.0359 ns | 0.0300 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 15.56 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
                                           From_Double | 17.02 ns | 0.0363 ns | 0.0303 ns |      - |       0 B |
                                  From_Double_AsObject | 29.46 ns | 0.0755 ns | 0.0669 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 20.25 ns | 0.0497 ns | 0.0388 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 29.95 ns | 0.0611 ns | 0.0541 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 13.52 ns | 0.1141 ns | 0.1068 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 15.54 ns | 0.0372 ns | 0.0329 ns |      - |       0 B |
                                            From_Short | 12.42 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                                   From_Short_AsObject | 24.86 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.89 ns | 0.0210 ns | 0.0175 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.84 ns | 0.0500 ns | 0.0444 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 12.82 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.41 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                              From_Int | 12.53 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
                                     From_Int_AsObject | 24.84 ns | 0.0534 ns | 0.0499 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 16.04 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.83 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 12.55 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.53 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                             From_Long | 12.66 ns | 0.0196 ns | 0.0173 ns |      - |       0 B |
                                    From_Long_AsObject | 15.99 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 13.57 ns | 0.1148 ns | 0.1074 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 16.00 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 13.43 ns | 0.0994 ns | 0.0830 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 15.56 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                                            From_SByte | 16.22 ns | 0.0927 ns | 0.0867 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.93 ns | 0.1781 ns | 0.1579 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 15.93 ns | 0.0667 ns | 0.0592 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 24.84 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 12.68 ns | 0.0204 ns | 0.0148 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.53 ns | 0.0275 ns | 0.0244 ns |      - |       0 B |
                                            From_Float | 15.92 ns | 0.0330 ns | 0.0293 ns |      - |       0 B |
                                   From_Float_AsObject | 29.73 ns | 0.0676 ns | 0.0632 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 21.08 ns | 0.0442 ns | 0.0369 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 29.73 ns | 0.1060 ns | 0.0939 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 12.60 ns | 0.0051 ns | 0.0034 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 15.77 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                                           From_String | 92.20 ns | 0.5408 ns | 0.5058 ns |      - |       0 B |
                                  From_String_AsObject | 97.67 ns | 0.1278 ns | 0.1195 ns |      - |       0 B |
                                      From_String_Null | 15.33 ns | 0.0330 ns | 0.0258 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.88 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                                     From_String_Empty | 18.73 ns | 0.0880 ns | 0.0823 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 12.70 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                  From_UShort_AsObject | 24.87 ns | 0.0569 ns | 0.0532 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 15.99 ns | 0.0735 ns | 0.0687 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 24.84 ns | 0.0492 ns | 0.0460 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 12.86 ns | 0.0139 ns | 0.0108 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.80 ns | 0.0434 ns | 0.0406 ns |      - |       0 B |
                                             From_UInt | 12.39 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                                    From_UInt_AsObject | 24.85 ns | 0.0429 ns | 0.0401 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.52 ns | 0.0762 ns | 0.0713 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 24.84 ns | 0.0399 ns | 0.0373 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 12.61 ns | 0.0183 ns | 0.0153 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 15.59 ns | 0.0681 ns | 0.0637 ns |      - |       0 B |
                                            From_ULong | 13.05 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                                   From_ULong_AsObject | 25.66 ns | 0.0548 ns | 0.0513 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.65 ns | 0.0186 ns | 0.0155 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 25.79 ns | 0.1440 ns | 0.1276 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 13.64 ns | 0.0314 ns | 0.0279 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.52 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                       From_NullObject | 15.59 ns | 0.0689 ns | 0.0644 ns |      - |       0 B |
                                           From_DBNull | 13.06 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                                 From_ConvertibleClass | 21.86 ns | 0.0338 ns | 0.0283 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.52 ns | 0.0344 ns | 0.0269 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 15.23 ns | 0.0266 ns | 0.0236 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.55 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
                              From_NonConvertibleClass | 17.84 ns | 0.0422 ns | 0.0374 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 20.68 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.23 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 15.57 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                                From_ConvertibleStruct | 21.26 ns | 0.0858 ns | 0.0670 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.11 ns | 0.0076 ns | 0.0055 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 96.99 ns | 0.1221 ns | 0.1142 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.14 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 12.55 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 15.50 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                             From_NonConvertibleStruct | 12.16 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.91 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.61 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 20.78 ns | 0.0374 ns | 0.0350 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 12.55 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.55 ns | 0.0044 ns | 0.0036 ns |      - |       0 B |
                                             From_Enum | 12.55 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                                    From_Enum_AsObject | 55.64 ns | 0.0419 ns | 0.0371 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.68 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 55.76 ns | 0.0221 ns | 0.0185 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 12.53 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.77 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
