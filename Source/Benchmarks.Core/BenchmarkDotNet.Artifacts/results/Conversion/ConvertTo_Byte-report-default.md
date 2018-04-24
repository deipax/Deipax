
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  31.71 ns | 0.1095 ns | 0.0915 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  30.25 ns | 0.0248 ns | 0.0207 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 105.78 ns | 0.1813 ns | 0.1607 ns | 0.0055 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  31.15 ns | 0.1133 ns | 0.1004 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  41.35 ns | 0.2283 ns | 0.1782 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.72 ns | 0.0517 ns | 0.0484 ns |      - |       0 B |
                                             From_Byte |  17.43 ns | 0.0487 ns | 0.0456 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  16.39 ns | 0.0387 ns | 0.0343 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  89.32 ns | 0.1260 ns | 0.1117 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  16.19 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  41.32 ns | 0.0679 ns | 0.0602 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  15.13 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                                             From_Char |  32.59 ns | 0.0261 ns | 0.0231 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  31.57 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 106.49 ns | 0.1303 ns | 0.1155 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  31.56 ns | 0.0343 ns | 0.0286 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  43.00 ns | 0.0515 ns | 0.0456 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.11 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  43.95 ns | 0.0750 ns | 0.0702 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.06 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
                                          From_Decimal |  44.83 ns | 0.0771 ns | 0.0721 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  42.85 ns | 0.0663 ns | 0.0620 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 120.91 ns | 0.0678 ns | 0.0530 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  42.86 ns | 0.0628 ns | 0.0588 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  42.15 ns | 0.0638 ns | 0.0597 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.40 ns | 0.0312 ns | 0.0277 ns |      - |       0 B |
                                           From_Double |  35.29 ns | 0.0126 ns | 0.0112 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  33.74 ns | 0.0661 ns | 0.0586 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 110.61 ns | 0.1213 ns | 0.1075 ns | 0.0056 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  33.77 ns | 0.0920 ns | 0.0768 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  41.23 ns | 0.0497 ns | 0.0415 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  14.86 ns | 0.0376 ns | 0.0333 ns |      - |       0 B |
                                            From_Short |  32.58 ns | 0.0391 ns | 0.0347 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  31.27 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 106.27 ns | 0.0709 ns | 0.0592 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  31.30 ns | 0.0458 ns | 0.0383 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.07 ns | 0.0559 ns | 0.0495 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  14.87 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                                              From_Int |  32.81 ns | 0.0115 ns | 0.0090 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  31.29 ns | 0.0224 ns | 0.0187 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 105.53 ns | 0.2291 ns | 0.2143 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  31.30 ns | 0.0514 ns | 0.0430 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  41.51 ns | 0.0523 ns | 0.0437 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.03 ns | 0.0426 ns | 0.0356 ns |      - |       0 B |
                                             From_Long |  32.60 ns | 0.0731 ns | 0.0648 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  31.27 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 107.55 ns | 0.0504 ns | 0.0364 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  31.27 ns | 0.0206 ns | 0.0183 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  42.06 ns | 0.0754 ns | 0.0706 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.03 ns | 0.0085 ns | 0.0062 ns |      - |       0 B |
                                            From_SByte |  31.75 ns | 0.0096 ns | 0.0080 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  31.42 ns | 0.1086 ns | 0.0963 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 105.16 ns | 0.0521 ns | 0.0487 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  30.51 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  44.31 ns | 0.0349 ns | 0.0292 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  14.87 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                            From_Float |  35.83 ns | 0.0219 ns | 0.0171 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  34.22 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 111.16 ns | 0.1696 ns | 0.1587 ns | 0.0056 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  34.27 ns | 0.0712 ns | 0.0595 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  41.19 ns | 0.0925 ns | 0.0820 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  14.85 ns | 0.0163 ns | 0.0127 ns |      - |       0 B |
                                           From_String | 109.00 ns | 0.1774 ns | 0.1660 ns |      - |       0 B |
                                  From_String_AsObject | 109.18 ns | 0.1685 ns | 0.1494 ns |      - |       0 B |
                                      From_String_Null |  15.01 ns | 0.0273 ns | 0.0228 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.01 ns | 0.0414 ns | 0.0346 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  31.83 ns | 0.0633 ns | 0.0592 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  30.48 ns | 0.0294 ns | 0.0245 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 105.20 ns | 0.1705 ns | 0.1424 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  30.55 ns | 0.0556 ns | 0.0492 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  42.51 ns | 0.0363 ns | 0.0303 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.26 ns | 0.0227 ns | 0.0202 ns |      - |       0 B |
                                             From_UInt |  32.04 ns | 0.0201 ns | 0.0168 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  30.46 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 106.09 ns | 0.1276 ns | 0.1193 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.46 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  41.19 ns | 0.1065 ns | 0.0996 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  14.84 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                                            From_ULong |  32.67 ns | 0.0544 ns | 0.0509 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  31.30 ns | 0.0542 ns | 0.0453 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 105.95 ns | 0.2020 ns | 0.1889 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  31.28 ns | 0.0229 ns | 0.0179 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.43 ns | 0.0188 ns | 0.0157 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  14.83 ns | 0.0035 ns | 0.0030 ns |      - |       0 B |
                                       From_NullObject |  14.85 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
                                           From_DBNull |  15.26 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.04 ns | 0.0363 ns | 0.0303 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.09 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.00 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.26 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  14.84 ns | 0.0191 ns | 0.0159 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.07 ns | 0.0180 ns | 0.0151 ns |      - |       0 B |
                                From_ConvertibleStruct |  30.95 ns | 0.0246 ns | 0.0192 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.42 ns | 0.0453 ns | 0.0378 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 110.08 ns | 0.2147 ns | 0.2008 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.39 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  41.34 ns | 0.1157 ns | 0.0966 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.84 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  41.32 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.03 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                             From_Enum |  89.84 ns | 0.0958 ns | 0.0849 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  87.78 ns | 0.0485 ns | 0.0405 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 190.88 ns | 0.3157 ns | 0.2953 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  86.71 ns | 0.1032 ns | 0.0862 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  43.11 ns | 0.0559 ns | 0.0496 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.24 ns | 0.0313 ns | 0.0292 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Byte.From_DateTime: DefaultJob
  ConvertTo_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo_Byte.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Byte.From_String_Empty: DefaultJob
  ConvertTo_Byte.From_String_Empty_AsObject: DefaultJob
  ConvertTo_Byte.From_NonConvertibleClass: DefaultJob
  ConvertTo_Byte.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_Byte.From_NonConvertibleStruct: DefaultJob
  ConvertTo_Byte.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_Byte.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_Byte.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
