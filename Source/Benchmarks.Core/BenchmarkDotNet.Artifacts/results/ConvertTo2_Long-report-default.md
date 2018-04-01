
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.87 ns | 0.3000 ns | 0.3455 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.50 ns | 0.2364 ns | 0.2096 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.42 ns | 0.0985 ns | 0.0874 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.51 ns | 0.3090 ns | 0.2891 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.09 ns | 0.0628 ns | 0.0524 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.26 ns | 0.0406 ns | 0.0360 ns |      - |       0 B |
                                             From_Byte |  12.91 ns | 0.0142 ns | 0.0111 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.24 ns | 0.1124 ns | 0.0997 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.64 ns | 0.1316 ns | 0.1231 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  26.20 ns | 0.0603 ns | 0.0564 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.20 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.36 ns | 0.0513 ns | 0.0480 ns |      - |       0 B |
                                             From_Char |  12.92 ns | 0.0296 ns | 0.0248 ns |      - |       0 B |
                                    From_Char_AsObject |  27.43 ns | 0.3612 ns | 0.3202 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.27 ns | 0.0179 ns | 0.0149 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.50 ns | 0.1397 ns | 0.1307 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.18 ns | 0.0216 ns | 0.0181 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.37 ns | 0.1221 ns | 0.1142 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.11 ns | 0.0409 ns | 0.0363 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.22 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                                          From_Decimal |  25.07 ns | 0.3128 ns | 0.2926 ns |      - |       0 B |
                                 From_Decimal_AsObject |  38.45 ns | 0.0803 ns | 0.0712 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  42.04 ns | 0.0229 ns | 0.0192 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.64 ns | 0.0511 ns | 0.0453 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.51 ns | 0.0273 ns | 0.0228 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.34 ns | 0.0332 ns | 0.0259 ns |      - |       0 B |
                                           From_Double |  16.81 ns | 0.0423 ns | 0.0375 ns |      - |       0 B |
                                  From_Double_AsObject |  31.02 ns | 0.0220 ns | 0.0195 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.40 ns | 0.2580 ns | 0.2414 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.04 ns | 0.0377 ns | 0.0315 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.06 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.21 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                                            From_Short |  12.99 ns | 0.1277 ns | 0.1194 ns |      - |       0 B |
                                   From_Short_AsObject |  26.17 ns | 0.0363 ns | 0.0322 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.43 ns | 0.0136 ns | 0.0098 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.16 ns | 0.0343 ns | 0.0304 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.30 ns | 0.1256 ns | 0.1175 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.23 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
                                              From_Int |  13.18 ns | 0.0110 ns | 0.0092 ns |      - |       0 B |
                                     From_Int_AsObject |  26.19 ns | 0.0346 ns | 0.0289 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.49 ns | 0.1283 ns | 0.1200 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.47 ns | 0.1822 ns | 0.1705 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.03 ns | 0.0287 ns | 0.0255 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.85 ns | 0.0514 ns | 0.0402 ns |      - |       0 B |
                                             From_Long |  13.08 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                                    From_Long_AsObject |  17.41 ns | 0.1408 ns | 0.1317 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  14.84 ns | 0.0431 ns | 0.0382 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  16.89 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.00 ns | 0.0202 ns | 0.0169 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.24 ns | 0.0424 ns | 0.0376 ns |      - |       0 B |
                                            From_SByte |  12.92 ns | 0.0200 ns | 0.0177 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.23 ns | 0.0506 ns | 0.0474 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.51 ns | 0.0392 ns | 0.0366 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.20 ns | 0.0485 ns | 0.0453 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.44 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.27 ns | 0.0414 ns | 0.0345 ns |      - |       0 B |
                                            From_Float |  16.94 ns | 0.1967 ns | 0.1840 ns |      - |       0 B |
                                   From_Float_AsObject |  31.83 ns | 0.1176 ns | 0.1043 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.70 ns | 0.0233 ns | 0.0194 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  34.00 ns | 0.0661 ns | 0.0552 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.28 ns | 0.1173 ns | 0.1097 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.23 ns | 0.0317 ns | 0.0297 ns |      - |       0 B |
                                           From_String |  97.39 ns | 0.0720 ns | 0.0562 ns |      - |       0 B |
                                  From_String_AsObject | 102.96 ns | 0.1219 ns | 0.1140 ns |      - |       0 B |
                                      From_String_Null |  16.26 ns | 0.1222 ns | 0.1143 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.34 ns | 0.0305 ns | 0.0270 ns |      - |       0 B |
                                     From_String_Empty |  20.02 ns | 0.0197 ns | 0.0154 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.14 ns | 0.1158 ns | 0.1083 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.17 ns | 0.0261 ns | 0.0231 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.60 ns | 0.0069 ns | 0.0050 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.18 ns | 0.0367 ns | 0.0287 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.42 ns | 0.1088 ns | 0.1018 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.20 ns | 0.0043 ns | 0.0034 ns |      - |       0 B |
                                             From_UInt |  12.90 ns | 0.0169 ns | 0.0141 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.69 ns | 0.0630 ns | 0.0590 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.49 ns | 0.0234 ns | 0.0208 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.58 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.16 ns | 0.0061 ns | 0.0047 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.29 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
                                            From_ULong |  13.85 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.16 ns | 0.0301 ns | 0.0217 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.53 ns | 0.0412 ns | 0.0386 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.19 ns | 0.0779 ns | 0.0728 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.42 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.25 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
                                       From_NullObject |  16.21 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                           From_DBNull |  14.19 ns | 0.0428 ns | 0.0400 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.52 ns | 0.0428 ns | 0.0379 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.82 ns | 0.0400 ns | 0.0374 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.07 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.33 ns | 0.0442 ns | 0.0392 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.67 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.75 ns | 0.0504 ns | 0.0472 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.08 ns | 0.0069 ns | 0.0062 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.26 ns | 0.0400 ns | 0.0374 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.83 ns | 0.0471 ns | 0.0440 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.20 ns | 0.0341 ns | 0.0302 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  25.90 ns | 0.0162 ns | 0.0135 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.14 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.36 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.26 ns | 0.0497 ns | 0.0465 ns |      - |       0 B |
                             From_NonConvertibleStruct |  12.81 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.72 ns | 0.0409 ns | 0.0382 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.17 ns | 0.0119 ns | 0.0093 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.60 ns | 0.0296 ns | 0.0263 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.01 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.91 ns | 0.0048 ns | 0.0038 ns |      - |       0 B |
                                             From_Enum |  14.03 ns | 0.0398 ns | 0.0353 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.77 ns | 0.1624 ns | 0.1440 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.42 ns | 0.0122 ns | 0.0095 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.76 ns | 0.4935 ns | 0.4617 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.27 ns | 0.0289 ns | 0.0256 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.42 ns | 0.0598 ns | 0.0559 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
