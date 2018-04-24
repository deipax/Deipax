
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                    From_Bool_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  44.28 ns | 0.4363 ns | 0.4081 ns |  44.27 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.42 ns | 0.0249 ns | 0.0194 ns |  15.41 ns |      - |       0 B |
                                             From_Byte |  40.53 ns | 0.0948 ns | 0.0887 ns |  40.53 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  38.91 ns | 0.0931 ns | 0.0825 ns |  38.88 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 114.39 ns | 0.3490 ns | 0.3264 ns | 114.41 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  38.97 ns | 0.3143 ns | 0.2625 ns |  38.84 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  42.13 ns | 0.0704 ns | 0.0659 ns |  42.13 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  15.94 ns | 0.0335 ns | 0.0280 ns |  15.93 ns |      - |       0 B |
                                             From_Char |  28.97 ns | 0.0864 ns | 0.0808 ns |  28.93 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  27.87 ns | 0.0765 ns | 0.0678 ns |  27.88 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 101.59 ns | 0.2760 ns | 0.2582 ns | 101.54 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  27.93 ns | 0.1647 ns | 0.1460 ns |  27.87 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  41.41 ns | 0.0376 ns | 0.0314 ns |  41.40 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.65 ns | 0.0413 ns | 0.0366 ns |  15.65 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  41.62 ns | 0.0391 ns | 0.0366 ns |  41.61 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.90 ns | 0.0265 ns | 0.0221 ns |  17.91 ns |      - |       0 B |
                                          From_Decimal |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Decimal_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  41.97 ns | 0.0697 ns | 0.0652 ns |  41.96 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.82 ns | 0.1624 ns | 0.1519 ns |  15.74 ns |      - |       0 B |
                                           From_Double |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                  From_Double_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  41.94 ns | 0.0427 ns | 0.0399 ns |  41.93 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.15 ns | 0.0441 ns | 0.0391 ns |  15.14 ns |      - |       0 B |
                                            From_Short |  40.63 ns | 0.0278 ns | 0.0232 ns |  40.63 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  39.43 ns | 0.4853 ns | 0.4540 ns |  39.21 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 118.68 ns | 0.0899 ns | 0.0797 ns | 118.66 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  39.18 ns | 0.0634 ns | 0.0562 ns |  39.18 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.99 ns | 0.0547 ns | 0.0485 ns |  41.99 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.08 ns | 0.0418 ns | 0.0349 ns |  16.08 ns |      - |       0 B |
                                              From_Int |  43.21 ns | 0.0684 ns | 0.0640 ns |  43.19 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  40.30 ns | 0.0789 ns | 0.0699 ns |  40.27 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 115.99 ns | 0.1307 ns | 0.1223 ns | 115.98 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  40.38 ns | 0.7741 ns | 0.6862 ns |  40.04 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  42.28 ns | 0.0412 ns | 0.0365 ns |  42.27 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.30 ns | 0.0318 ns | 0.0281 ns |  15.28 ns |      - |       0 B |
                                             From_Long |  42.02 ns | 0.0912 ns | 0.0809 ns |  42.03 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  39.91 ns | 0.0227 ns | 0.0212 ns |  39.90 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 116.73 ns | 0.1246 ns | 0.1104 ns | 116.69 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  41.05 ns | 0.1523 ns | 0.1189 ns |  41.01 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  41.80 ns | 0.0225 ns | 0.0176 ns |  41.79 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.32 ns | 0.0193 ns | 0.0161 ns |  15.31 ns |      - |       0 B |
                                            From_SByte |  40.53 ns | 0.0860 ns | 0.0762 ns |  40.50 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  40.46 ns | 0.6048 ns | 0.5050 ns |  40.36 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 117.48 ns | 0.4129 ns | 0.3863 ns | 117.45 ns | 0.0055 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  39.18 ns | 0.1028 ns | 0.0912 ns |  39.13 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  43.38 ns | 0.0571 ns | 0.0506 ns |  43.38 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  15.77 ns | 0.0462 ns | 0.0360 ns |  15.76 ns |      - |       0 B |
                                            From_Float |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                   From_Float_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  44.92 ns | 0.9237 ns | 1.1343 ns |  44.80 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.74 ns | 0.3614 ns | 0.6876 ns |  15.38 ns |      - |       0 B |
                                           From_String |  39.55 ns | 0.8109 ns | 0.7965 ns |  39.23 ns |      - |       0 B |
                                  From_String_AsObject |  39.57 ns | 0.6915 ns | 0.6130 ns |  39.47 ns |      - |       0 B |
                                      From_String_Null |  16.68 ns | 0.3490 ns | 0.3093 ns |  16.65 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.73 ns | 0.3377 ns | 0.3754 ns |  15.59 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  43.93 ns | 0.9672 ns | 1.6684 ns |  43.42 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  41.92 ns | 0.8491 ns | 0.9085 ns |  41.94 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 118.35 ns | 2.1522 ns | 1.9078 ns | 118.37 ns | 0.0055 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  40.32 ns | 0.4344 ns | 0.4064 ns |  40.23 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  44.11 ns | 0.5603 ns | 0.4967 ns |  44.16 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.09 ns | 0.3709 ns | 0.5200 ns |  16.97 ns |      - |       0 B |
                                             From_UInt |  42.83 ns | 0.6345 ns | 0.5298 ns |  42.96 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  41.71 ns | 0.9746 ns | 1.3011 ns |  41.60 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 120.68 ns | 2.3385 ns | 2.5021 ns | 120.10 ns | 0.0055 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  41.69 ns | 0.8634 ns | 1.1526 ns |  41.74 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  45.42 ns | 0.9928 ns | 0.9287 ns |  45.17 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  15.88 ns | 0.3478 ns | 0.4522 ns |  15.90 ns |      - |       0 B |
                                            From_ULong |  43.61 ns | 0.8845 ns | 1.0863 ns |  43.28 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  42.40 ns | 0.8804 ns | 1.4950 ns |  41.98 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 125.58 ns | 2.5280 ns | 2.3647 ns | 125.03 ns | 0.0055 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  40.98 ns | 0.8213 ns | 0.9129 ns |  40.66 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  45.60 ns | 0.9245 ns | 1.5447 ns |  45.46 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.71 ns | 0.3443 ns | 0.4477 ns |  15.49 ns |      - |       0 B |
                                       From_NullObject |  15.49 ns | 0.1144 ns | 0.0955 ns |  15.49 ns |      - |       0 B |
                                           From_DBNull |  15.99 ns | 0.1965 ns | 0.1742 ns |  15.97 ns |      - |       0 B |
                                 From_ConvertibleClass |  38.24 ns | 0.7883 ns | 0.8762 ns |  38.09 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  37.23 ns | 0.3280 ns | 0.2739 ns |  37.16 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.91 ns | 0.3419 ns | 0.3800 ns |  15.77 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.41 ns | 0.3898 ns | 0.4332 ns |  18.21 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  15.63 ns | 0.2118 ns | 0.1769 ns |  15.67 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.51 ns | 0.3367 ns | 0.3150 ns |  15.36 ns |      - |       0 B |
                                From_ConvertibleStruct |  42.13 ns | 0.8486 ns | 0.7938 ns |  41.89 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  39.36 ns | 0.7022 ns | 0.6568 ns |  38.98 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 126.35 ns | 2.5526 ns | 2.5070 ns | 125.34 ns | 0.0055 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  40.32 ns | 0.7929 ns | 1.0028 ns |  40.38 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  44.32 ns | 0.9119 ns | 1.1857 ns |  44.03 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.17 ns | 0.3651 ns | 0.4617 ns |  17.19 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  45.21 ns | 0.9124 ns | 0.8535 ns |  45.05 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.75 ns | 0.2935 ns | 0.2602 ns |  15.67 ns |      - |       0 B |
                                             From_Enum | 107.44 ns | 2.1879 ns | 3.2070 ns | 106.60 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  96.99 ns | 1.0872 ns | 1.0169 ns |  96.65 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 217.25 ns | 4.2530 ns | 5.0629 ns | 214.69 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject | 101.20 ns | 2.0481 ns | 3.7451 ns |  99.07 ns | 0.0055 |      24 B |
                            From_Enum_Nullable_NoValue |  43.38 ns | 0.5173 ns | 0.4586 ns |  43.31 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.23 ns | 0.3561 ns | 0.6421 ns |  15.97 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_CharNullable.From_Bool: DefaultJob
  ConvertTo_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime: DefaultJob
  ConvertTo_CharNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal: DefaultJob
  ConvertTo_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double: DefaultJob
  ConvertTo_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float: DefaultJob
  ConvertTo_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo_CharNullable.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_CharNullable.From_String_Empty: DefaultJob
  ConvertTo_CharNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleClass: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleStruct: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_CharNullable.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
