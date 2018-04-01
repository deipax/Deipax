
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.11 ns | 0.1363 ns | 0.1208 ns |  14.09 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.31 ns | 0.0833 ns | 0.0739 ns |  30.27 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  18.43 ns | 0.0681 ns | 0.0569 ns |  18.43 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.26 ns | 0.0183 ns | 0.0162 ns |  30.26 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.57 ns | 0.0293 ns | 0.0260 ns |  14.56 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.26 ns | 0.0217 ns | 0.0193 ns |  16.26 ns |      - |       0 B |
                                             From_Byte |  13.41 ns | 0.0066 ns | 0.0051 ns |  13.41 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.31 ns | 0.0483 ns | 0.0428 ns |  30.30 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.89 ns | 0.0276 ns | 0.0245 ns |  17.88 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.64 ns | 0.0180 ns | 0.0141 ns |  30.64 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.57 ns | 0.0282 ns | 0.0264 ns |  14.56 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.33 ns | 0.0865 ns | 0.0809 ns |  16.34 ns |      - |       0 B |
                                             From_Char |  13.40 ns | 0.0054 ns | 0.0045 ns |  13.40 ns |      - |       0 B |
                                    From_Char_AsObject |  31.00 ns | 0.0261 ns | 0.0218 ns |  31.00 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.62 ns | 0.0058 ns | 0.0045 ns |  17.62 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  31.05 ns | 0.2118 ns | 0.1981 ns |  30.97 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.28 ns | 0.0037 ns | 0.0029 ns |  14.28 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.20 ns | 0.0108 ns | 0.0090 ns |  16.20 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.14 ns | 0.0506 ns | 0.0473 ns |  16.15 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.23 ns | 0.0317 ns | 0.0265 ns |  16.24 ns |      - |       0 B |
                                          From_Decimal |  24.34 ns | 0.0282 ns | 0.0235 ns |  24.32 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.12 ns | 0.6094 ns | 0.5701 ns |  39.85 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  34.86 ns | 0.0168 ns | 0.0140 ns |  34.86 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.82 ns | 0.0563 ns | 0.0470 ns |  39.82 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.67 ns | 0.0214 ns | 0.0201 ns |  14.67 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.32 ns | 0.0333 ns | 0.0295 ns |  16.32 ns |      - |       0 B |
                                           From_Double |  17.36 ns | 0.0046 ns | 0.0043 ns |  17.36 ns |      - |       0 B |
                                  From_Double_AsObject |  34.50 ns | 0.0604 ns | 0.0535 ns |  34.49 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  23.06 ns | 0.0072 ns | 0.0060 ns |  23.06 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.24 ns | 0.7121 ns | 0.7619 ns |  35.16 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.06 ns | 0.0130 ns | 0.0101 ns |  15.06 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.43 ns | 0.0129 ns | 0.0121 ns |  16.43 ns |      - |       0 B |
                                            From_Short |  15.11 ns | 0.0129 ns | 0.0121 ns |  15.11 ns |      - |       0 B |
                                   From_Short_AsObject |  30.31 ns | 0.1037 ns | 0.0970 ns |  30.36 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  19.14 ns | 0.0436 ns | 0.0387 ns |  19.12 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  30.22 ns | 0.0547 ns | 0.0511 ns |  30.21 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.28 ns | 0.0064 ns | 0.0053 ns |  14.28 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.28 ns | 0.0436 ns | 0.0408 ns |  16.29 ns |      - |       0 B |
                                              From_Int |  13.67 ns | 0.0052 ns | 0.0049 ns |  13.67 ns |      - |       0 B |
                                     From_Int_AsObject |  30.42 ns | 0.0594 ns | 0.0526 ns |  30.42 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.62 ns | 0.0043 ns | 0.0036 ns |  17.62 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.29 ns | 0.1077 ns | 0.1008 ns |  30.34 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.14 ns | 0.0043 ns | 0.0036 ns |  14.14 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.10 ns | 0.0267 ns | 0.0250 ns |  17.10 ns |      - |       0 B |
                                             From_Long |  13.66 ns | 0.0042 ns | 0.0035 ns |  13.66 ns |      - |       0 B |
                                    From_Long_AsObject |  28.54 ns | 0.0614 ns | 0.0574 ns |  28.55 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  14.04 ns | 0.0057 ns | 0.0047 ns |  14.04 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.63 ns | 0.0392 ns | 0.0367 ns |  27.63 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.07 ns | 0.0080 ns | 0.0063 ns |  15.07 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.36 ns | 0.0278 ns | 0.0232 ns |  16.37 ns |      - |       0 B |
                                            From_SByte |  14.33 ns | 0.0341 ns | 0.0319 ns |  14.30 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.56 ns | 0.0482 ns | 0.0403 ns |  30.55 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.87 ns | 0.0079 ns | 0.0066 ns |  17.87 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.59 ns | 0.0505 ns | 0.0473 ns |  30.59 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.55 ns | 0.0076 ns | 0.0059 ns |  14.55 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.31 ns | 0.0310 ns | 0.0275 ns |  16.32 ns |      - |       0 B |
                                            From_Float |  17.50 ns | 0.0272 ns | 0.0241 ns |  17.49 ns |      - |       0 B |
                                   From_Float_AsObject |  35.22 ns | 0.0476 ns | 0.0445 ns |  35.22 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  21.45 ns | 0.0068 ns | 0.0056 ns |  21.45 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  35.36 ns | 0.6720 ns | 0.6286 ns |  34.86 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.32 ns | 0.0512 ns | 0.0478 ns |  14.29 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.32 ns | 0.0248 ns | 0.0194 ns |  16.32 ns |      - |       0 B |
                                           From_String |  95.54 ns | 0.0557 ns | 0.0494 ns |  95.53 ns |      - |       0 B |
                                  From_String_AsObject | 104.45 ns | 0.3559 ns | 0.3329 ns | 104.57 ns |      - |       0 B |
                                      From_String_Null |  16.29 ns | 0.0270 ns | 0.0253 ns |  16.28 ns |      - |       0 B |
                             From_String_Null_AsObject |  16.29 ns | 0.0128 ns | 0.0119 ns |  16.30 ns |      - |       0 B |
                                     From_String_Empty |  20.79 ns | 0.0618 ns | 0.0548 ns |  20.75 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.66 ns | 0.0193 ns | 0.0171 ns |  13.65 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.38 ns | 0.0466 ns | 0.0436 ns |  30.39 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  19.10 ns | 0.0051 ns | 0.0046 ns |  19.10 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.41 ns | 0.0318 ns | 0.0297 ns |  30.41 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.14 ns | 0.0056 ns | 0.0050 ns |  14.13 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.64 ns | 0.0179 ns | 0.0140 ns |  16.64 ns |      - |       0 B |
                                             From_UInt |  14.21 ns | 0.0032 ns | 0.0025 ns |  14.21 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.21 ns | 0.0340 ns | 0.0318 ns |  30.21 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  20.47 ns | 0.0082 ns | 0.0064 ns |  20.48 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.63 ns | 0.0805 ns | 0.0672 ns |  30.61 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.32 ns | 0.0048 ns | 0.0044 ns |  15.32 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  16.23 ns | 0.0285 ns | 0.0266 ns |  16.23 ns |      - |       0 B |
                                            From_ULong |  15.21 ns | 0.0043 ns | 0.0040 ns |  15.21 ns |      - |       0 B |
                                   From_ULong_AsObject |  30.83 ns | 0.1344 ns | 0.1257 ns |  30.82 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.67 ns | 0.0113 ns | 0.0094 ns |  19.66 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  30.80 ns | 0.0335 ns | 0.0297 ns |  30.81 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.09 ns | 0.0026 ns | 0.0021 ns |  16.09 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.29 ns | 0.0412 ns | 0.0385 ns |  16.30 ns |      - |       0 B |
                                       From_NullObject |  16.32 ns | 0.0078 ns | 0.0069 ns |  16.32 ns |      - |       0 B |
                                           From_DBNull |  14.82 ns | 0.0212 ns | 0.0198 ns |  14.81 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.06 ns | 0.0254 ns | 0.0238 ns |  25.06 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.06 ns | 0.0174 ns | 0.0163 ns |  28.05 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  16.26 ns | 0.0123 ns | 0.0115 ns |  16.26 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.60 ns | 0.0176 ns | 0.0165 ns |  16.60 ns |      - |       0 B |
                              From_NonConvertibleClass |  19.48 ns | 0.0295 ns | 0.0262 ns |  19.47 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.35 ns | 0.0169 ns | 0.0158 ns |  23.35 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.32 ns | 0.0186 ns | 0.0174 ns |  16.32 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.20 ns | 0.0112 ns | 0.0093 ns |  16.20 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.09 ns | 0.0242 ns | 0.0227 ns |  25.09 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.00 ns | 0.0234 ns | 0.0195 ns |  28.99 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 101.29 ns | 0.0828 ns | 0.0646 ns | 101.28 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.06 ns | 0.0663 ns | 0.0620 ns |  29.04 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.62 ns | 0.0367 ns | 0.0344 ns |  14.62 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.30 ns | 0.0122 ns | 0.0109 ns |  16.30 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.44 ns | 0.0221 ns | 0.0207 ns |  13.42 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  27.40 ns | 0.0563 ns | 0.0526 ns |  27.42 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  17.88 ns | 0.0034 ns | 0.0029 ns |  17.88 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.54 ns | 0.0273 ns | 0.0242 ns |  25.55 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.01 ns | 0.0177 ns | 0.0157 ns |  15.00 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.58 ns | 0.0331 ns | 0.0310 ns |  16.59 ns |      - |       0 B |
                                             From_Enum |  15.01 ns | 0.0046 ns | 0.0038 ns |  15.01 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.14 ns | 0.1039 ns | 0.0972 ns |  61.16 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.42 ns | 0.0049 ns | 0.0041 ns |  19.42 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.13 ns | 0.0653 ns | 0.0545 ns |  61.14 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.14 ns | 0.0084 ns | 0.0070 ns |  14.14 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.28 ns | 0.0078 ns | 0.0069 ns |  16.28 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
