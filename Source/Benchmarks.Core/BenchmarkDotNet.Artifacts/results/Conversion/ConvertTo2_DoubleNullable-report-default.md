
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.58 ns | 0.1923 ns | 0.1705 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.19 ns | 0.1914 ns | 0.1598 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  16.66 ns | 0.0441 ns | 0.0368 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  27.11 ns | 0.1658 ns | 0.1469 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.98 ns | 0.1422 ns | 0.1111 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.83 ns | 0.1442 ns | 0.1204 ns |      - |       0 B |
                                             From_Byte |  15.81 ns | 0.3448 ns | 0.3386 ns |      - |       0 B |
                                    From_Byte_AsObject |  27.13 ns | 0.2288 ns | 0.2028 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.21 ns | 0.1415 ns | 0.1254 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  27.31 ns | 0.4001 ns | 0.3547 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.14 ns | 0.3295 ns | 0.3083 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.12 ns | 0.4798 ns | 0.4712 ns |      - |       0 B |
                                             From_Char |  16.03 ns | 0.3437 ns | 0.4221 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.38 ns | 0.3308 ns | 0.3397 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.57 ns | 0.3113 ns | 0.2760 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.63 ns | 0.0371 ns | 0.0329 ns |      - |       0 B |
                                         From_DateTime |  15.54 ns | 0.0304 ns | 0.0237 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.13 ns | 0.0138 ns | 0.0123 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.21 ns | 0.0340 ns | 0.0284 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.66 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                                          From_Decimal |  21.25 ns | 0.0357 ns | 0.0279 ns |      - |       0 B |
                                 From_Decimal_AsObject |  32.94 ns | 0.0964 ns | 0.0805 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  25.27 ns | 0.2364 ns | 0.1974 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  32.99 ns | 0.1300 ns | 0.1085 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.10 ns | 0.0123 ns | 0.0102 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.95 ns | 0.1247 ns | 0.1166 ns |      - |       0 B |
                                           From_Double |  14.83 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                                  From_Double_AsObject |  32.28 ns | 0.6710 ns | 0.6277 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.92 ns | 0.1822 ns | 0.1704 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.79 ns | 0.3634 ns | 0.3399 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.86 ns | 0.0709 ns | 0.0663 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.75 ns | 0.0534 ns | 0.0474 ns |      - |       0 B |
                                            From_Short |  15.86 ns | 0.2687 ns | 0.2513 ns |      - |       0 B |
                                   From_Short_AsObject |  27.34 ns | 0.0409 ns | 0.0363 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.17 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.30 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.98 ns | 0.0228 ns | 0.0203 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.82 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                                              From_Int |  15.39 ns | 0.0176 ns | 0.0147 ns |      - |       0 B |
                                     From_Int_AsObject |  27.88 ns | 0.0419 ns | 0.0350 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.12 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.83 ns | 0.0103 ns | 0.0081 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.85 ns | 0.0220 ns | 0.0184 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.66 ns | 0.0091 ns | 0.0071 ns |      - |       0 B |
                                             From_Long |  15.43 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
                                    From_Long_AsObject |  28.14 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.61 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.08 ns | 0.0206 ns | 0.0172 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.65 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.78 ns | 0.0418 ns | 0.0391 ns |      - |       0 B |
                                            From_SByte |  15.66 ns | 0.0198 ns | 0.0165 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.82 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.15 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.82 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.84 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.63 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                                            From_Float |  15.05 ns | 0.0206 ns | 0.0172 ns |      - |       0 B |
                                   From_Float_AsObject |  27.48 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  16.10 ns | 0.0175 ns | 0.0146 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  28.22 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.85 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.59 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                                           From_String | 108.46 ns | 0.0368 ns | 0.0326 ns |      - |       0 B |
                                  From_String_AsObject | 120.77 ns | 0.6104 ns | 0.5710 ns |      - |       0 B |
                                      From_String_Null |  17.66 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.17 ns | 0.0097 ns | 0.0075 ns |      - |       0 B |
                                     From_String_Empty |  18.37 ns | 0.0552 ns | 0.0517 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  15.38 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                                  From_UShort_AsObject |  27.92 ns | 0.0471 ns | 0.0441 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.10 ns | 0.0069 ns | 0.0054 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  27.07 ns | 0.0349 ns | 0.0326 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.85 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.83 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
                                             From_UInt |  15.52 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                    From_UInt_AsObject |  27.11 ns | 0.0529 ns | 0.0442 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.18 ns | 0.0380 ns | 0.0337 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  27.08 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.97 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.62 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                                            From_ULong |  16.13 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.59 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.27 ns | 0.0165 ns | 0.0147 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.58 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.65 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.66 ns | 0.0376 ns | 0.0352 ns |      - |       0 B |
                                       From_NullObject |  17.73 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                                           From_DBNull |  16.34 ns | 0.0154 ns | 0.0129 ns |      - |       0 B |
                                  From_DBNull_AsObject |  17.70 ns | 0.0379 ns | 0.0354 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.24 ns | 0.0408 ns | 0.0381 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.72 ns | 0.0229 ns | 0.0191 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.49 ns | 0.0453 ns | 0.0424 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.67 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.83 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.40 ns | 0.0242 ns | 0.0215 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.83 ns | 0.0214 ns | 0.0179 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.73 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.46 ns | 0.0418 ns | 0.0349 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.99 ns | 0.0188 ns | 0.0167 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  25.04 ns | 0.0204 ns | 0.0171 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.88 ns | 0.0155 ns | 0.0121 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.95 ns | 0.0382 ns | 0.0358 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.38 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.89 ns | 0.0114 ns | 0.0089 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.38 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.86 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.28 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.53 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.61 ns | 0.0414 ns | 0.0367 ns |      - |       0 B |
                                             From_Enum |  15.41 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.07 ns | 0.1861 ns | 0.1741 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  16.02 ns | 0.0112 ns | 0.0094 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.98 ns | 0.0242 ns | 0.0189 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.40 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.83 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                                      From_ParentClass |  15.83 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.31 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
                              From_ParentClass_NoValue |  18.64 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  20.30 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                                     From_ParentStruct |  16.00 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.76 ns | 0.0246 ns | 0.0218 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.86 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  21.94 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.86 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.67 ns | 0.0375 ns | 0.0333 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_String_Empty_AsObject: DefaultJob
