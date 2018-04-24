
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  42.94 ns | 0.6666 ns | 0.6235 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  40.58 ns | 0.1151 ns | 0.1076 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 117.94 ns | 0.3212 ns | 0.3005 ns | 0.0055 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  40.51 ns | 0.1726 ns | 0.1615 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  42.50 ns | 0.0829 ns | 0.0775 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.31 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
                                          From_Byte |  44.34 ns | 0.3964 ns | 0.3708 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  41.12 ns | 0.1258 ns | 0.1115 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 121.51 ns | 0.2384 ns | 0.1991 ns | 0.0055 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  41.00 ns | 0.1058 ns | 0.0990 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  44.36 ns | 0.0628 ns | 0.0588 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.15 ns | 0.0712 ns | 0.0666 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  42.88 ns | 0.0584 ns | 0.0546 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.37 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  43.71 ns | 0.1081 ns | 0.1011 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.37 ns | 0.0500 ns | 0.0443 ns |      - |       0 B |
                                       From_Decimal |  49.17 ns | 0.1139 ns | 0.1066 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  46.79 ns | 0.0676 ns | 0.0564 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 128.32 ns | 0.3216 ns | 0.3008 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  46.88 ns | 0.0591 ns | 0.0553 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  43.71 ns | 0.0359 ns | 0.0300 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.39 ns | 0.1217 ns | 0.1079 ns |      - |       0 B |
                                        From_Double |  31.43 ns | 0.0896 ns | 0.0838 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  29.49 ns | 0.0232 ns | 0.0194 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 107.00 ns | 0.2296 ns | 0.2148 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  29.42 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.35 ns | 0.0926 ns | 0.0866 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.22 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
                                         From_Short |  42.77 ns | 0.1195 ns | 0.1118 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  40.80 ns | 0.0177 ns | 0.0166 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 118.05 ns | 0.2723 ns | 0.2547 ns | 0.0055 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  40.96 ns | 0.0436 ns | 0.0386 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.74 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.17 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
                                           From_Int |  42.45 ns | 0.0832 ns | 0.0778 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  41.19 ns | 0.0742 ns | 0.0658 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 117.67 ns | 0.0536 ns | 0.0501 ns | 0.0055 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  40.43 ns | 0.0571 ns | 0.0534 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  42.56 ns | 0.0324 ns | 0.0271 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.30 ns | 0.0108 ns | 0.0085 ns |      - |       0 B |
                                          From_Long |  43.28 ns | 0.0319 ns | 0.0298 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  41.13 ns | 0.0426 ns | 0.0399 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 124.41 ns | 0.1659 ns | 0.1385 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  41.10 ns | 0.0214 ns | 0.0167 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  43.65 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.01 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                                         From_SByte |  42.60 ns | 0.0353 ns | 0.0295 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  40.43 ns | 0.0294 ns | 0.0260 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 117.94 ns | 0.0956 ns | 0.0894 ns | 0.0055 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  40.43 ns | 0.0404 ns | 0.0358 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  44.53 ns | 0.1117 ns | 0.0990 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.34 ns | 0.0597 ns | 0.0559 ns |      - |       0 B |
                                         From_Float |  42.77 ns | 0.0595 ns | 0.0557 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  40.45 ns | 0.0628 ns | 0.0587 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 119.93 ns | 0.1866 ns | 0.1746 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  40.40 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  42.35 ns | 0.0271 ns | 0.0253 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.11 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                                        From_String | 141.03 ns | 0.1810 ns | 0.1413 ns |      - |       0 B |
                               From_String_AsObject | 139.87 ns | 0.0624 ns | 0.0487 ns |      - |       0 B |
                                   From_String_Null |  16.32 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.30 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  42.47 ns | 0.0993 ns | 0.0929 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  40.40 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 117.72 ns | 0.3127 ns | 0.2925 ns | 0.0055 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  40.43 ns | 0.0465 ns | 0.0388 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  44.03 ns | 0.0565 ns | 0.0528 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.30 ns | 0.0071 ns | 0.0055 ns |      - |       0 B |
                                          From_UInt |  42.72 ns | 0.1072 ns | 0.1003 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  40.72 ns | 0.1185 ns | 0.0989 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 117.93 ns | 0.0884 ns | 0.0738 ns | 0.0055 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  40.68 ns | 0.0322 ns | 0.0269 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  43.55 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.12 ns | 0.0421 ns | 0.0394 ns |      - |       0 B |
                                         From_ULong |  44.34 ns | 0.0547 ns | 0.0485 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  41.20 ns | 0.0092 ns | 0.0072 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 119.77 ns | 0.0885 ns | 0.0739 ns | 0.0055 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  41.20 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  47.30 ns | 0.0761 ns | 0.0712 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.09 ns | 0.0062 ns | 0.0049 ns |      - |       0 B |
                                    From_NullObject |  16.14 ns | 0.0472 ns | 0.0418 ns |      - |       0 B |
                                        From_DBNull |  16.57 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                              From_ConvertibleClass |  38.58 ns | 0.0486 ns | 0.0431 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  38.61 ns | 0.0155 ns | 0.0121 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.35 ns | 0.0317 ns | 0.0281 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.43 ns | 0.0239 ns | 0.0212 ns |      - |       0 B |
                             From_ConvertibleStruct |  42.11 ns | 0.0238 ns | 0.0223 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  39.88 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 125.08 ns | 0.0711 ns | 0.0630 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  39.92 ns | 0.0572 ns | 0.0535 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  43.40 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.30 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                                          From_Enum | 102.43 ns | 0.2284 ns | 0.2136 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject | 101.03 ns | 0.1333 ns | 0.1247 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 205.52 ns | 0.0960 ns | 0.0898 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject | 102.38 ns | 0.0415 ns | 0.0324 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  43.35 ns | 0.0168 ns | 0.0140 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.11 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_DoubleNullable.From_Char: DefaultJob
  ConvertTo_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DoubleNullable.From_String_Empty: DefaultJob
  ConvertTo_DoubleNullable.From_String_Empty_AsObject: DefaultJob
