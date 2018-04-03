
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  18.45 ns | 0.2166 ns | 0.1920 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  17.26 ns | 0.0463 ns | 0.0387 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  89.43 ns | 0.0515 ns | 0.0430 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  16.07 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  41.76 ns | 0.0696 ns | 0.0543 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  14.71 ns | 0.0304 ns | 0.0237 ns |      - |       0 B |
                                             From_Byte |  32.55 ns | 0.0281 ns | 0.0249 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  29.92 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 103.81 ns | 0.2169 ns | 0.2029 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  29.93 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  42.53 ns | 0.0399 ns | 0.0374 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.02 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                             From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  41.35 ns | 0.3550 ns | 0.3320 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  14.99 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  41.61 ns | 0.0261 ns | 0.0204 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  14.84 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                                          From_Decimal |  43.48 ns | 0.0301 ns | 0.0251 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  41.21 ns | 0.0365 ns | 0.0324 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 118.45 ns | 0.1189 ns | 0.0993 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.18 ns | 0.0397 ns | 0.0331 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  42.18 ns | 0.1045 ns | 0.0977 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  14.74 ns | 0.0439 ns | 0.0389 ns |      - |       0 B |
                                           From_Double |  31.27 ns | 0.0270 ns | 0.0252 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  29.66 ns | 0.0161 ns | 0.0134 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 104.35 ns | 0.0591 ns | 0.0462 ns | 0.0056 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  29.67 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  41.47 ns | 0.0257 ns | 0.0201 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.82 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                                            From_Short |  31.06 ns | 0.0246 ns | 0.0230 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  30.48 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 103.25 ns | 0.0310 ns | 0.0275 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  29.44 ns | 0.0459 ns | 0.0383 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.44 ns | 0.0386 ns | 0.0323 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.13 ns | 0.1854 ns | 0.1734 ns |      - |       0 B |
                                              From_Int |  31.48 ns | 0.0517 ns | 0.0459 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  29.66 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 104.08 ns | 0.1235 ns | 0.1095 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  29.38 ns | 0.0234 ns | 0.0195 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  41.13 ns | 0.1174 ns | 0.1098 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.13 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                                             From_Long |  31.02 ns | 0.0779 ns | 0.0729 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  29.39 ns | 0.0188 ns | 0.0147 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 105.69 ns | 0.0800 ns | 0.0668 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  29.41 ns | 0.0950 ns | 0.0793 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  41.41 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.66 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
                                            From_SByte |  32.00 ns | 0.0123 ns | 0.0096 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  29.41 ns | 0.0496 ns | 0.0440 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 105.34 ns | 0.2201 ns | 0.2059 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  30.82 ns | 0.6202 ns | 0.6091 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  44.37 ns | 0.0709 ns | 0.0592 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  14.98 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                            From_Float |  31.01 ns | 0.0141 ns | 0.0102 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  29.58 ns | 0.0967 ns | 0.0808 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 105.16 ns | 0.1403 ns | 0.1313 ns | 0.0056 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  30.48 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  42.36 ns | 0.0472 ns | 0.0441 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  14.99 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
                                           From_String |  47.23 ns | 0.1421 ns | 0.1260 ns |      - |       0 B |
                                  From_String_AsObject |  47.21 ns | 0.1487 ns | 0.1391 ns |      - |       0 B |
                                      From_String_Null |  15.77 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                             From_String_Null_AsObject |  14.87 ns | 0.0242 ns | 0.0214 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  32.00 ns | 0.0110 ns | 0.0097 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  30.50 ns | 0.0314 ns | 0.0262 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 105.14 ns | 0.2739 ns | 0.2562 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  29.40 ns | 0.0238 ns | 0.0199 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  41.98 ns | 0.0483 ns | 0.0452 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  14.74 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                             From_UInt |  31.26 ns | 0.0744 ns | 0.0696 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  30.50 ns | 0.0245 ns | 0.0191 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 103.51 ns | 0.0460 ns | 0.0359 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.41 ns | 0.0233 ns | 0.0195 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  41.09 ns | 0.0449 ns | 0.0375 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  15.00 ns | 0.0190 ns | 0.0169 ns |      - |       0 B |
                                            From_ULong |  30.93 ns | 0.0589 ns | 0.0551 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  29.41 ns | 0.0298 ns | 0.0249 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 104.77 ns | 0.2436 ns | 0.2278 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  29.45 ns | 0.0525 ns | 0.0491 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.74 ns | 0.2148 ns | 0.2009 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.02 ns | 0.0403 ns | 0.0357 ns |      - |       0 B |
                                       From_NullObject |  15.00 ns | 0.0242 ns | 0.0189 ns |      - |       0 B |
                                           From_DBNull |  15.29 ns | 0.0442 ns | 0.0392 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.60 ns | 0.0559 ns | 0.0436 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  27.54 ns | 0.0315 ns | 0.0246 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.09 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  14.75 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  15.76 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.96 ns | 0.0425 ns | 0.0397 ns |      - |       0 B |
                                From_ConvertibleStruct |  30.67 ns | 0.0143 ns | 0.0112 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.98 ns | 0.0685 ns | 0.0608 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 109.78 ns | 0.2419 ns | 0.2145 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.95 ns | 0.0292 ns | 0.0228 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  41.43 ns | 0.0546 ns | 0.0511 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.00 ns | 0.0162 ns | 0.0135 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  41.44 ns | 0.0111 ns | 0.0087 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  14.76 ns | 0.0223 ns | 0.0198 ns |      - |       0 B |
                                             From_Enum |  91.22 ns | 0.1224 ns | 0.1145 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  82.10 ns | 0.1823 ns | 0.1705 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 195.65 ns | 0.2591 ns | 0.2423 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  87.30 ns | 0.0880 ns | 0.0780 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  43.09 ns | 0.4982 ns | 0.4660 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  14.77 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Bool.From_Char: DefaultJob
  ConvertTo_Bool.From_Char_AsObject: DefaultJob
  ConvertTo_Bool.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime: DefaultJob
  ConvertTo_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo_Bool.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Bool.From_String_Empty: DefaultJob
  ConvertTo_Bool.From_String_Empty_AsObject: DefaultJob
  ConvertTo_Bool.From_NonConvertibleClass: DefaultJob
  ConvertTo_Bool.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_Bool.From_NonConvertibleStruct: DefaultJob
  ConvertTo_Bool.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_Bool.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_Bool.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
