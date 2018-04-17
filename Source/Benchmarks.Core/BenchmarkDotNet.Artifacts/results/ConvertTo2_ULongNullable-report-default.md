
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.66 ns | 0.1346 ns | 0.1259 ns |  16.68 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.09 ns | 0.0409 ns | 0.0341 ns |  31.08 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.83 ns | 0.0460 ns | 0.0384 ns |  17.82 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  31.10 ns | 0.0618 ns | 0.0548 ns |  31.08 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.02 ns | 0.0426 ns | 0.0378 ns |  17.00 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.94 ns | 0.2800 ns | 0.2619 ns |  18.78 ns |      - |       0 B |
                                             From_Byte |  16.41 ns | 0.2267 ns | 0.2010 ns |  16.33 ns |      - |       0 B |
                                    From_Byte_AsObject |  31.33 ns | 0.2066 ns | 0.1933 ns |  31.44 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.02 ns | 0.0472 ns | 0.0418 ns |  17.00 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  31.43 ns | 0.5275 ns | 0.4676 ns |  31.28 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.26 ns | 0.2373 ns | 0.2104 ns |  17.18 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.99 ns | 0.3033 ns | 0.2837 ns |  18.87 ns |      - |       0 B |
                                             From_Char |  16.55 ns | 0.4210 ns | 0.4323 ns |  16.29 ns |      - |       0 B |
                                    From_Char_AsObject |  32.39 ns | 0.4749 ns | 0.4210 ns |  32.36 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.92 ns | 0.1700 ns | 0.1419 ns |  17.86 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  32.21 ns | 0.3910 ns | 0.3658 ns |  32.15 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  16.52 ns | 0.0652 ns | 0.0578 ns |  16.51 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.87 ns | 0.2629 ns | 0.2460 ns |  18.74 ns |      - |       0 B |
                                         From_DateTime |  16.84 ns | 0.1520 ns | 0.1270 ns |  16.77 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.47 ns | 0.0302 ns | 0.0236 ns |  16.47 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.51 ns | 0.0313 ns | 0.0244 ns |  16.51 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.07 ns | 0.3776 ns | 0.3532 ns |  18.89 ns |      - |       0 B |
                                          From_Decimal |  26.70 ns | 0.5431 ns | 0.5811 ns |  26.47 ns |      - |       0 B |
                                 From_Decimal_AsObject |  43.24 ns | 0.8712 ns | 0.8556 ns |  43.39 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  29.88 ns | 0.6069 ns | 0.5068 ns |  29.70 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  42.81 ns | 0.1595 ns | 0.1245 ns |  42.81 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.56 ns | 0.3781 ns | 0.4045 ns |  17.54 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.25 ns | 0.3439 ns | 0.3532 ns |  19.26 ns |      - |       0 B |
                                           From_Double |  19.96 ns | 0.0359 ns | 0.0319 ns |  19.95 ns |      - |       0 B |
                                  From_Double_AsObject |  36.03 ns | 0.3027 ns | 0.2684 ns |  35.90 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.99 ns | 0.0891 ns | 0.0790 ns |  20.96 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.50 ns | 0.1441 ns | 0.1277 ns |  35.52 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  20.79 ns | 0.0071 ns | 0.0059 ns |  20.79 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.69 ns | 0.0092 ns | 0.0082 ns |  18.68 ns |      - |       0 B |
                                            From_Short |  16.97 ns | 0.0665 ns | 0.0622 ns |  16.94 ns |      - |       0 B |
                                   From_Short_AsObject |  31.50 ns | 0.0264 ns | 0.0247 ns |  31.49 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.51 ns | 0.0207 ns | 0.0183 ns |  17.51 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.67 ns | 0.1136 ns | 0.1062 ns |  31.71 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.43 ns | 0.0036 ns | 0.0028 ns |  16.43 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  20.71 ns | 0.0328 ns | 0.0307 ns |  20.72 ns |      - |       0 B |
                                              From_Int |  16.41 ns | 0.0042 ns | 0.0035 ns |  16.41 ns |      - |       0 B |
                                     From_Int_AsObject |  31.61 ns | 0.1206 ns | 0.1128 ns |  31.66 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.51 ns | 0.0044 ns | 0.0032 ns |  17.51 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.57 ns | 0.0283 ns | 0.0250 ns |  31.56 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.95 ns | 0.0140 ns | 0.0117 ns |  16.95 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.81 ns | 0.0188 ns | 0.0147 ns |  18.81 ns |      - |       0 B |
                                             From_Long |  16.42 ns | 0.0084 ns | 0.0075 ns |  16.42 ns |      - |       0 B |
                                    From_Long_AsObject |  31.48 ns | 0.0059 ns | 0.0046 ns |  31.48 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.49 ns | 0.0034 ns | 0.0028 ns |  17.49 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.49 ns | 0.0245 ns | 0.0217 ns |  31.48 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.22 ns | 0.0031 ns | 0.0026 ns |  17.22 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.20 ns | 0.0022 ns | 0.0018 ns |  19.19 ns |      - |       0 B |
                                            From_SByte |  18.39 ns | 0.0163 ns | 0.0144 ns |  18.39 ns |      - |       0 B |
                                   From_SByte_AsObject |  32.25 ns | 0.6735 ns | 1.0682 ns |  31.67 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.85 ns | 0.1192 ns | 0.1056 ns |  17.79 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.53 ns | 1.0348 ns | 0.9173 ns |  32.20 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.37 ns | 0.1581 ns | 0.1402 ns |  17.32 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.26 ns | 0.0473 ns | 0.0369 ns |  19.24 ns |      - |       0 B |
                                            From_Float |  20.35 ns | 0.0656 ns | 0.0614 ns |  20.32 ns |      - |       0 B |
                                   From_Float_AsObject |  36.43 ns | 0.5711 ns | 0.5063 ns |  36.13 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  21.07 ns | 0.2985 ns | 0.2792 ns |  20.99 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.18 ns | 0.0540 ns | 0.0451 ns |  36.17 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.61 ns | 0.3308 ns | 0.2932 ns |  16.48 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.84 ns | 0.1626 ns | 0.1442 ns |  18.79 ns |      - |       0 B |
                                           From_String |  94.29 ns | 0.4935 ns | 0.4121 ns |  94.07 ns |      - |       0 B |
                                  From_String_AsObject | 108.37 ns | 0.2341 ns | 0.2190 ns | 108.31 ns |      - |       0 B |
                                      From_String_Null |  17.79 ns | 0.1131 ns | 0.0945 ns |  17.75 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.84 ns | 0.1373 ns | 0.1284 ns |  18.79 ns |      - |       0 B |
                                     From_String_Empty |  18.47 ns | 0.1141 ns | 0.1012 ns |  18.44 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.71 ns | 0.0271 ns | 0.0240 ns |  16.70 ns |      - |       0 B |
                                  From_UShort_AsObject |  31.03 ns | 0.0809 ns | 0.0757 ns |  30.98 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.75 ns | 0.0839 ns | 0.0701 ns |  16.72 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  31.20 ns | 0.2185 ns | 0.1937 ns |  31.14 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.47 ns | 0.0227 ns | 0.0177 ns |  16.46 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.76 ns | 0.0187 ns | 0.0156 ns |  18.76 ns |      - |       0 B |
                                             From_UInt |  16.03 ns | 0.2273 ns | 0.1898 ns |  15.95 ns |      - |       0 B |
                                    From_UInt_AsObject |  31.21 ns | 0.1566 ns | 0.1389 ns |  31.15 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.91 ns | 0.0220 ns | 0.0184 ns |  16.90 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  31.15 ns | 0.0856 ns | 0.0758 ns |  31.12 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.56 ns | 0.1736 ns | 0.1539 ns |  16.49 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.73 ns | 0.0323 ns | 0.0286 ns |  18.72 ns |      - |       0 B |
                                            From_ULong |  16.10 ns | 0.1527 ns | 0.1275 ns |  16.06 ns |      - |       0 B |
                                   From_ULong_AsObject |  31.65 ns | 0.5045 ns | 0.4213 ns |  31.45 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.44 ns | 0.0154 ns | 0.0144 ns |  16.43 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  32.17 ns | 0.6661 ns | 0.7404 ns |  31.91 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.51 ns | 0.1037 ns | 0.0866 ns |  16.47 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.71 ns | 0.0250 ns | 0.0209 ns |  18.70 ns |      - |       0 B |
                                       From_NullObject |  18.86 ns | 0.0302 ns | 0.0268 ns |  18.85 ns |      - |       0 B |
                                           From_DBNull |  17.80 ns | 0.0619 ns | 0.0517 ns |  17.77 ns |      - |       0 B |
                                 From_ConvertibleClass |  30.56 ns | 0.7231 ns | 0.8038 ns |  30.20 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  29.11 ns | 0.0576 ns | 0.0510 ns |  29.10 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  21.64 ns | 0.1478 ns | 0.1310 ns |  21.58 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.98 ns | 0.1427 ns | 0.1335 ns |  19.01 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.89 ns | 0.0243 ns | 0.0215 ns |  17.89 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.63 ns | 0.0653 ns | 0.0578 ns |  25.62 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.94 ns | 0.0835 ns | 0.0697 ns |  17.94 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.92 ns | 0.2477 ns | 0.2068 ns |  18.91 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.68 ns | 0.1138 ns | 0.0889 ns |  26.64 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.12 ns | 0.0031 ns | 0.0025 ns |  30.12 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.78 ns | 0.0153 ns | 0.0128 ns |  29.77 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.13 ns | 0.0226 ns | 0.0211 ns |  30.12 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.50 ns | 0.0196 ns | 0.0163 ns |  17.49 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.68 ns | 0.0022 ns | 0.0020 ns |  18.68 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.13 ns | 0.0030 ns | 0.0027 ns |  16.13 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.42 ns | 0.0030 ns | 0.0023 ns |  25.42 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.13 ns | 0.0033 ns | 0.0029 ns |  16.13 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.38 ns | 0.0109 ns | 0.0102 ns |  25.37 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.13 ns | 0.0086 ns | 0.0076 ns |  16.13 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.69 ns | 0.0038 ns | 0.0030 ns |  18.69 ns |      - |       0 B |
                                             From_Enum |  16.40 ns | 0.0140 ns | 0.0131 ns |  16.40 ns |      - |       0 B |
                                    From_Enum_AsObject |  65.62 ns | 0.0317 ns | 0.0247 ns |  65.62 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.26 ns | 0.0565 ns | 0.0528 ns |  20.28 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  65.77 ns | 0.0348 ns | 0.0308 ns |  65.78 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.72 ns | 0.0123 ns | 0.0103 ns |  16.73 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.70 ns | 0.0135 ns | 0.0126 ns |  18.70 ns |      - |       0 B |
                                      From_ParentClass |  18.06 ns | 0.0377 ns | 0.0334 ns |  18.07 ns |      - |       0 B |
                             From_ParentClass_AsObject |  26.42 ns | 0.0047 ns | 0.0039 ns |  26.42 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.92 ns | 0.0614 ns | 0.0574 ns |  17.94 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.70 ns | 0.0051 ns | 0.0030 ns |  18.70 ns |      - |       0 B |
                                     From_ParentStruct |  16.18 ns | 0.0225 ns | 0.0211 ns |  16.18 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.87 ns | 0.0110 ns | 0.0097 ns |  25.87 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  17.04 ns | 0.0619 ns | 0.0548 ns |  17.07 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.87 ns | 0.0138 ns | 0.0123 ns |  25.87 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  17.02 ns | 0.0120 ns | 0.0112 ns |  17.02 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.37 ns | 0.0155 ns | 0.0129 ns |  19.37 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_String_Empty_AsObject: DefaultJob
