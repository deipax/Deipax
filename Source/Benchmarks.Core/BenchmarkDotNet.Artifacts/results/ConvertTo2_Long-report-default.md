
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.66 ns | 0.1332 ns | 0.1246 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.24 ns | 0.1049 ns | 0.0930 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.02 ns | 0.0553 ns | 0.0518 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.19 ns | 0.0595 ns | 0.0527 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.02 ns | 0.0634 ns | 0.0593 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.65 ns | 0.0330 ns | 0.0309 ns |      - |       0 B |
                                             From_Byte |  12.93 ns | 0.0310 ns | 0.0259 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.30 ns | 0.1404 ns | 0.1172 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.58 ns | 0.0445 ns | 0.0372 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  26.31 ns | 0.0573 ns | 0.0536 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.21 ns | 0.0665 ns | 0.0590 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.48 ns | 0.0785 ns | 0.0734 ns |      - |       0 B |
                                             From_Char |  12.92 ns | 0.0186 ns | 0.0155 ns |      - |       0 B |
                                    From_Char_AsObject |  27.31 ns | 0.0455 ns | 0.0426 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.33 ns | 0.0790 ns | 0.0700 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.38 ns | 0.1338 ns | 0.1252 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.44 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.15 ns | 0.0244 ns | 0.0217 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.00 ns | 0.0326 ns | 0.0273 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.09 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                                          From_Decimal |  24.90 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                                 From_Decimal_AsObject |  38.97 ns | 0.7325 ns | 0.6493 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  32.99 ns | 0.1215 ns | 0.1137 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.70 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.00 ns | 0.0501 ns | 0.0469 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.87 ns | 0.0593 ns | 0.0555 ns |      - |       0 B |
                                           From_Double |  16.73 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                                  From_Double_AsObject |  32.11 ns | 0.0204 ns | 0.0160 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.05 ns | 0.0287 ns | 0.0269 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.10 ns | 0.0235 ns | 0.0196 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.05 ns | 0.0400 ns | 0.0374 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.16 ns | 0.0427 ns | 0.0400 ns |      - |       0 B |
                                            From_Short |  12.95 ns | 0.0430 ns | 0.0402 ns |      - |       0 B |
                                   From_Short_AsObject |  26.19 ns | 0.0314 ns | 0.0294 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.33 ns | 0.0245 ns | 0.0230 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.21 ns | 0.0465 ns | 0.0413 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.19 ns | 0.0405 ns | 0.0359 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.89 ns | 0.0442 ns | 0.0414 ns |      - |       0 B |
                                              From_Int |  13.77 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
                                     From_Int_AsObject |  26.17 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.33 ns | 0.0124 ns | 0.0097 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.25 ns | 0.0189 ns | 0.0148 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.02 ns | 0.0310 ns | 0.0259 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.15 ns | 0.0319 ns | 0.0299 ns |      - |       0 B |
                                             From_Long |  13.08 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                    From_Long_AsObject |  17.65 ns | 0.0085 ns | 0.0066 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  14.00 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  17.02 ns | 0.0190 ns | 0.0159 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  13.99 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.15 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                                            From_SByte |  12.94 ns | 0.0657 ns | 0.0614 ns |      - |       0 B |
                                   From_SByte_AsObject |  27.42 ns | 0.0409 ns | 0.0342 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.69 ns | 0.0320 ns | 0.0284 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.20 ns | 0.0309 ns | 0.0274 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.17 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.24 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
                                            From_Float |  16.70 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                                   From_Float_AsObject |  32.77 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.55 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.80 ns | 0.0674 ns | 0.0598 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.17 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.10 ns | 0.0076 ns | 0.0063 ns |      - |       0 B |
                                           From_String |  97.55 ns | 0.0196 ns | 0.0153 ns |      - |       0 B |
                                  From_String_AsObject | 102.99 ns | 0.0241 ns | 0.0201 ns |      - |       0 B |
                                      From_String_Null |  16.79 ns | 0.0077 ns | 0.0060 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.86 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                                     From_String_Empty |  20.63 ns | 0.0039 ns | 0.0028 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.09 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.16 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.52 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.16 ns | 0.0303 ns | 0.0284 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.00 ns | 0.0062 ns | 0.0051 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.85 ns | 0.0484 ns | 0.0404 ns |      - |       0 B |
                                             From_UInt |  12.91 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.53 ns | 0.0618 ns | 0.0578 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.48 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  27.35 ns | 0.0698 ns | 0.0653 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.17 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.15 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                                            From_ULong |  13.86 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.12 ns | 0.0359 ns | 0.0318 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.52 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.07 ns | 0.0387 ns | 0.0343 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.02 ns | 0.0398 ns | 0.0332 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.44 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                                       From_NullObject |  16.14 ns | 0.0394 ns | 0.0369 ns |      - |       0 B |
                                           From_DBNull |  13.51 ns | 0.0165 ns | 0.0138 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.70 ns | 0.0774 ns | 0.0724 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.74 ns | 0.0511 ns | 0.0478 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.11 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.12 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
                              From_NonConvertibleClass |  19.58 ns | 0.0246 ns | 0.0231 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.69 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.86 ns | 0.0239 ns | 0.0224 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.90 ns | 0.0888 ns | 0.0831 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.42 ns | 0.0698 ns | 0.0653 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.19 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  25.93 ns | 0.0371 ns | 0.0347 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.35 ns | 0.1192 ns | 0.1115 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.49 ns | 0.0366 ns | 0.0342 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.19 ns | 0.0121 ns | 0.0094 ns |      - |       0 B |
                             From_NonConvertibleStruct |  12.82 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.93 ns | 0.0270 ns | 0.0210 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  17.23 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.65 ns | 0.0449 ns | 0.0420 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.01 ns | 0.0138 ns | 0.0123 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.14 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                                             From_Enum |  13.09 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.55 ns | 0.1133 ns | 0.1060 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  16.50 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.58 ns | 0.1124 ns | 0.1051 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  12.99 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.11 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
