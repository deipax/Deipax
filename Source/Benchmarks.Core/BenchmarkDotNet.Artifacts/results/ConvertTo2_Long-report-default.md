
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  12.80 ns | 0.0854 ns | 0.0799 ns |  12.76 ns |      - |       0 B |
                                    From_Bool_AsObject |  24.82 ns | 0.0416 ns | 0.0325 ns |  24.81 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  19.00 ns | 0.0161 ns | 0.0134 ns |  19.00 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  24.83 ns | 0.0544 ns | 0.0454 ns |  24.82 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.59 ns | 0.0096 ns | 0.0070 ns |  13.59 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.49 ns | 0.0036 ns | 0.0030 ns |  15.49 ns |      - |       0 B |
                                             From_Byte |  13.20 ns | 0.0748 ns | 0.0699 ns |  13.24 ns |      - |       0 B |
                                    From_Byte_AsObject |  24.83 ns | 0.0287 ns | 0.0254 ns |  24.82 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  15.94 ns | 0.0138 ns | 0.0115 ns |  15.94 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.09 ns | 0.0235 ns | 0.0208 ns |  25.09 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.67 ns | 0.0089 ns | 0.0070 ns |  13.67 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.39 ns | 0.0084 ns | 0.0075 ns |  16.38 ns |      - |       0 B |
                                             From_Char |  12.28 ns | 0.0245 ns | 0.0229 ns |  12.29 ns |      - |       0 B |
                                    From_Char_AsObject |  25.87 ns | 0.0378 ns | 0.0295 ns |  25.85 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.90 ns | 0.0113 ns | 0.0095 ns |  16.89 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  25.89 ns | 0.0581 ns | 0.0485 ns |  25.87 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  12.50 ns | 0.0120 ns | 0.0107 ns |  12.49 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.44 ns | 0.0611 ns | 0.0572 ns |  15.41 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  13.35 ns | 0.0408 ns | 0.0382 ns |  13.35 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  15.40 ns | 0.0038 ns | 0.0033 ns |  15.40 ns |      - |       0 B |
                                          From_Decimal |  26.45 ns | 0.5609 ns | 1.5729 ns |  25.89 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.65 ns | 0.7434 ns | 1.1791 ns |  36.18 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  34.77 ns | 0.7198 ns | 0.9853 ns |  34.44 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.73 ns | 0.7359 ns | 0.6883 ns |  36.42 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.41 ns | 0.3126 ns | 0.4279 ns |  14.30 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.16 ns | 0.3398 ns | 0.4298 ns |  16.12 ns |      - |       0 B |
                                           From_Double |  16.39 ns | 0.3022 ns | 0.2827 ns |  16.43 ns |      - |       0 B |
                                  From_Double_AsObject |  30.63 ns | 0.6323 ns | 0.7028 ns |  30.67 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.94 ns | 0.4942 ns | 0.4622 ns |  20.82 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.23 ns | 0.6541 ns | 0.9169 ns |  30.88 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  13.92 ns | 0.3077 ns | 0.4212 ns |  13.89 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.97 ns | 0.3420 ns | 0.3199 ns |  15.89 ns |      - |       0 B |
                                            From_Short |  18.62 ns | 0.2309 ns | 0.2160 ns |  18.57 ns |      - |       0 B |
                                   From_Short_AsObject |  25.48 ns | 0.4675 ns | 0.4373 ns |  25.48 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.96 ns | 0.3174 ns | 0.2969 ns |  15.98 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.45 ns | 0.2521 ns | 0.2235 ns |  25.45 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  12.73 ns | 0.1869 ns | 0.1748 ns |  12.67 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.97 ns | 0.3422 ns | 0.3361 ns |  15.86 ns |      - |       0 B |
                                              From_Int |  12.88 ns | 0.2184 ns | 0.2043 ns |  12.91 ns |      - |       0 B |
                                     From_Int_AsObject |  25.58 ns | 0.5141 ns | 0.5500 ns |  25.45 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.01 ns | 0.1369 ns | 0.1069 ns |  16.01 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.51 ns | 0.3746 ns | 0.3321 ns |  25.47 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  12.75 ns | 0.2500 ns | 0.2339 ns |  12.69 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.97 ns | 0.3379 ns | 0.3318 ns |  15.95 ns |      - |       0 B |
                                             From_Long |  12.88 ns | 0.2851 ns | 0.2801 ns |  12.82 ns |      - |       0 B |
                                    From_Long_AsObject |  16.37 ns | 0.4232 ns | 0.4346 ns |  16.25 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  13.53 ns | 0.2108 ns | 0.1869 ns |  13.51 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  16.84 ns | 0.2658 ns | 0.2487 ns |  16.84 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  13.78 ns | 0.2617 ns | 0.2186 ns |  13.70 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.63 ns | 0.1554 ns | 0.1454 ns |  15.66 ns |      - |       0 B |
                                            From_SByte |  12.47 ns | 0.1222 ns | 0.1020 ns |  12.44 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.58 ns | 0.4167 ns | 0.3694 ns |  25.55 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.37 ns | 0.3803 ns | 0.3558 ns |  17.17 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.57 ns | 0.5414 ns | 0.5317 ns |  25.48 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  12.89 ns | 0.2706 ns | 0.2531 ns |  12.88 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  15.85 ns | 0.3396 ns | 0.3177 ns |  15.77 ns |      - |       0 B |
                                            From_Float |  16.30 ns | 0.3482 ns | 0.3257 ns |  16.16 ns |      - |       0 B |
                                   From_Float_AsObject |  29.88 ns | 0.0151 ns | 0.0126 ns |  29.88 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.50 ns | 0.0073 ns | 0.0061 ns |  19.50 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.64 ns | 0.0305 ns | 0.0285 ns |  30.63 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.65 ns | 0.0221 ns | 0.0184 ns |  13.64 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.51 ns | 0.0044 ns | 0.0039 ns |  15.51 ns |      - |       0 B |
                                           From_String |  93.81 ns | 0.0468 ns | 0.0366 ns |  93.80 ns |      - |       0 B |
                                  From_String_AsObject |  97.69 ns | 0.0255 ns | 0.0213 ns |  97.69 ns |      - |       0 B |
                                      From_String_Null |  15.23 ns | 0.0184 ns | 0.0163 ns |  15.23 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.45 ns | 0.0055 ns | 0.0046 ns |  15.45 ns |      - |       0 B |
                                     From_String_Empty |  18.53 ns | 0.0041 ns | 0.0032 ns |  18.53 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  12.42 ns | 0.0227 ns | 0.0213 ns |  12.41 ns |      - |       0 B |
                                  From_UShort_AsObject |  24.80 ns | 0.0122 ns | 0.0108 ns |  24.80 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.92 ns | 0.0332 ns | 0.0294 ns |  16.90 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.00 ns | 0.0238 ns | 0.0199 ns |  25.00 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  12.33 ns | 0.0037 ns | 0.0031 ns |  12.33 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.60 ns | 0.0228 ns | 0.0178 ns |  15.60 ns |      - |       0 B |
                                             From_UInt |  12.24 ns | 0.0101 ns | 0.0084 ns |  12.24 ns |      - |       0 B |
                                    From_UInt_AsObject |  24.80 ns | 0.0110 ns | 0.0092 ns |  24.80 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.68 ns | 0.0379 ns | 0.0354 ns |  15.66 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  24.82 ns | 0.0284 ns | 0.0266 ns |  24.81 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  12.69 ns | 0.0113 ns | 0.0105 ns |  12.68 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  15.52 ns | 0.0251 ns | 0.0235 ns |  15.50 ns |      - |       0 B |
                                            From_ULong |  13.15 ns | 0.0094 ns | 0.0084 ns |  13.15 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.74 ns | 0.0089 ns | 0.0074 ns |  27.74 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.11 ns | 0.0109 ns | 0.0097 ns |  18.10 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  25.74 ns | 0.0201 ns | 0.0188 ns |  25.74 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  13.45 ns | 0.0110 ns | 0.0097 ns |  13.45 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.40 ns | 0.0052 ns | 0.0043 ns |  15.40 ns |      - |       0 B |
                                       From_NullObject |  15.43 ns | 0.0115 ns | 0.0102 ns |  15.43 ns |      - |       0 B |
                                           From_DBNull |  16.37 ns | 0.0273 ns | 0.0255 ns |  16.35 ns |      - |       0 B |
                                 From_ConvertibleClass |  21.40 ns | 0.0086 ns | 0.0067 ns |  21.40 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.93 ns | 0.0075 ns | 0.0063 ns |  24.93 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.26 ns | 0.0296 ns | 0.0277 ns |  15.24 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.43 ns | 0.0076 ns | 0.0067 ns |  15.43 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.75 ns | 0.0014 ns | 0.0012 ns |  17.75 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  20.59 ns | 0.0105 ns | 0.0088 ns |  20.59 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.25 ns | 0.0227 ns | 0.0212 ns |  15.23 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.56 ns | 0.0042 ns | 0.0037 ns |  15.56 ns |      - |       0 B |
                                From_ConvertibleStruct |  21.50 ns | 0.0073 ns | 0.0057 ns |  21.50 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  23.80 ns | 0.0299 ns | 0.0280 ns |  23.80 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 100.86 ns | 0.2103 ns | 0.1967 ns | 100.76 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  23.77 ns | 0.0135 ns | 0.0119 ns |  23.77 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.55 ns | 0.0232 ns | 0.0217 ns |  14.56 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.30 ns | 0.0027 ns | 0.0023 ns |  16.30 ns |      - |       0 B |
                             From_NonConvertibleStruct |  12.16 ns | 0.0169 ns | 0.0150 ns |  12.16 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  20.56 ns | 0.0083 ns | 0.0078 ns |  20.56 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.45 ns | 0.0609 ns | 0.0508 ns |  15.46 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  20.59 ns | 0.0985 ns | 0.0921 ns |  20.59 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  12.35 ns | 0.0201 ns | 0.0188 ns |  12.33 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.48 ns | 0.0402 ns | 0.0376 ns |  15.49 ns |      - |       0 B |
                                             From_Enum |  13.75 ns | 0.0037 ns | 0.0029 ns |  13.75 ns |      - |       0 B |
                                    From_Enum_AsObject |  56.98 ns | 0.0602 ns | 0.0533 ns |  56.97 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  15.66 ns | 0.0245 ns | 0.0217 ns |  15.65 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  56.70 ns | 0.0413 ns | 0.0298 ns |  56.69 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  13.52 ns | 0.0030 ns | 0.0028 ns |  13.52 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.50 ns | 0.0686 ns | 0.0642 ns |  15.54 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
