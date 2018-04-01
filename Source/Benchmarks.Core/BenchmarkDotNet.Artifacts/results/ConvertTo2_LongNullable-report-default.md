
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.94 ns | 0.2518 ns | 0.2232 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.01 ns | 0.3734 ns | 0.3310 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  19.65 ns | 0.0226 ns | 0.0201 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.69 ns | 0.0496 ns | 0.0440 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.63 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.70 ns | 0.0433 ns | 0.0405 ns |      - |       0 B |
                                             From_Byte |  15.37 ns | 0.0080 ns | 0.0070 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.47 ns | 0.0471 ns | 0.0417 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  19.13 ns | 0.0314 ns | 0.0279 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.65 ns | 0.0436 ns | 0.0364 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.60 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.20 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                                             From_Char |  15.07 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                                    From_Char_AsObject |  31.70 ns | 0.0317 ns | 0.0248 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  18.84 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  31.60 ns | 0.0229 ns | 0.0203 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.09 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.23 ns | 0.0451 ns | 0.0422 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  17.09 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.17 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |
                                          From_Decimal |  25.74 ns | 0.0510 ns | 0.0477 ns |      - |       0 B |
                                 From_Decimal_AsObject |  43.23 ns | 0.5379 ns | 0.5031 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  36.58 ns | 0.0672 ns | 0.0629 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  43.46 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.75 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.73 ns | 0.0390 ns | 0.0365 ns |      - |       0 B |
                                           From_Double |  19.40 ns | 0.0259 ns | 0.0229 ns |      - |       0 B |
                                  From_Double_AsObject |  35.35 ns | 0.0654 ns | 0.0612 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  24.58 ns | 0.0334 ns | 0.0296 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.30 ns | 0.0250 ns | 0.0209 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.89 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.16 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                            From_Short |  14.13 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                                   From_Short_AsObject |  30.46 ns | 0.0731 ns | 0.0683 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.86 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  30.42 ns | 0.0420 ns | 0.0351 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.09 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.18 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                                              From_Int |  15.25 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                                     From_Int_AsObject |  30.45 ns | 0.0076 ns | 0.0064 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.83 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.47 ns | 0.0486 ns | 0.0431 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.98 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  19.87 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
                                             From_Long |  14.67 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                                    From_Long_AsObject |  30.17 ns | 0.0283 ns | 0.0250 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.09 ns | 0.0417 ns | 0.0390 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.35 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.08 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.17 ns | 0.0225 ns | 0.0200 ns |      - |       0 B |
                                            From_SByte |  14.13 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.43 ns | 0.0472 ns | 0.0441 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  19.13 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.45 ns | 0.0174 ns | 0.0146 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.61 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.17 ns | 0.0148 ns | 0.0115 ns |      - |       0 B |
                                            From_Float |  19.54 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                                   From_Float_AsObject |  35.86 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  24.04 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  35.87 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.09 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.17 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                                           From_String | 101.21 ns | 0.0935 ns | 0.0829 ns |      - |       0 B |
                                  From_String_AsObject | 107.08 ns | 0.0910 ns | 0.0852 ns |      - |       0 B |
                                      From_String_Null |  18.45 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.55 ns | 0.0234 ns | 0.0207 ns |      - |       0 B |
                                     From_String_Empty |  23.09 ns | 0.0107 ns | 0.0083 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.40 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.46 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  18.84 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.52 ns | 0.0252 ns | 0.0211 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  17.42 ns | 0.0053 ns | 0.0041 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.16 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
                                             From_UInt |  14.18 ns | 0.0405 ns | 0.0379 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.46 ns | 0.0487 ns | 0.0455 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.85 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.52 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.97 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.18 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                            From_ULong |  15.28 ns | 0.0748 ns | 0.0699 ns |      - |       0 B |
                                   From_ULong_AsObject |  31.35 ns | 0.2071 ns | 0.1836 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  21.03 ns | 0.0423 ns | 0.0396 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  31.28 ns | 0.0651 ns | 0.0609 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.89 ns | 0.0242 ns | 0.0214 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.20 ns | 0.0415 ns | 0.0368 ns |      - |       0 B |
                                       From_NullObject |  18.39 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                                           From_DBNull |  17.33 ns | 0.0445 ns | 0.0395 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.79 ns | 0.1453 ns | 0.1288 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  27.78 ns | 0.0259 ns | 0.0203 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.80 ns | 0.1011 ns | 0.0844 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.71 ns | 0.4388 ns | 0.6152 ns |      - |       0 B |
                              From_NonConvertibleClass |  20.78 ns | 0.2569 ns | 0.2403 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  24.17 ns | 0.0809 ns | 0.0757 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  19.69 ns | 0.0344 ns | 0.0305 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.24 ns | 0.0536 ns | 0.0502 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.95 ns | 0.9379 ns | 1.0035 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.20 ns | 0.1095 ns | 0.0970 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.17 ns | 0.7640 ns | 1.0199 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.34 ns | 0.3595 ns | 0.2807 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.56 ns | 0.2514 ns | 0.2099 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.45 ns | 0.3702 ns | 0.3092 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.27 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  24.44 ns | 0.0345 ns | 0.0250 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  19.17 ns | 0.0740 ns | 0.0656 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.17 ns | 0.0533 ns | 0.0499 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.66 ns | 0.0820 ns | 0.0767 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.35 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                                             From_Enum |  14.44 ns | 0.0099 ns | 0.0082 ns |      - |       0 B |
                                    From_Enum_AsObject |  63.04 ns | 0.1656 ns | 0.1549 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.85 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  63.82 ns | 0.0586 ns | 0.0489 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.22 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.74 ns | 0.0335 ns | 0.0313 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
