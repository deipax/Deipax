
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  15.49 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                 From_Bool_AsObject |  31.51 ns | 0.0062 ns | 0.0048 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  17.22 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  31.52 ns | 0.0235 ns | 0.0208 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.79 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.52 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                          From_Byte |  13.94 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                 From_Byte_AsObject |  31.89 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.92 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  31.66 ns | 0.0541 ns | 0.0506 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.78 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.63 ns | 0.0097 ns | 0.0090 ns |      - |       0 B |
                                          From_Char |  14.16 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.34 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  13.22 ns | 0.0387 ns | 0.0362 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.53 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                      From_DateTime |  15.84 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                             From_DateTime_AsObject |  23.19 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  14.19 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  23.23 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  14.14 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.33 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
                                       From_Decimal |  22.71 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                              From_Decimal_AsObject |  40.11 ns | 0.0277 ns | 0.0245 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  38.55 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  40.39 ns | 0.0400 ns | 0.0354 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.03 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.23 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                        From_Double |  13.64 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
                               From_Double_AsObject |  32.41 ns | 0.0321 ns | 0.0284 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  20.15 ns | 0.0160 ns | 0.0134 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  31.74 ns | 0.0490 ns | 0.0458 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.16 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.68 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
                                         From_Short |  14.05 ns | 0.0285 ns | 0.0238 ns |      - |       0 B |
                                From_Short_AsObject |  32.23 ns | 0.0509 ns | 0.0476 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  18.31 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  32.25 ns | 0.0295 ns | 0.0262 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  13.58 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.98 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                                           From_Int |  13.60 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                  From_Int_AsObject |  31.74 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  16.99 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  31.97 ns | 0.0244 ns | 0.0217 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.77 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.22 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
                                          From_Long |  13.97 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                                 From_Long_AsObject |  32.09 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  19.24 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  32.17 ns | 0.0306 ns | 0.0256 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.07 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.25 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
                                         From_SByte |  13.97 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                                From_SByte_AsObject |  31.84 ns | 0.0501 ns | 0.0469 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  18.26 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  31.63 ns | 0.0303 ns | 0.0269 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  13.56 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.47 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
                                         From_Float |  13.43 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                From_Float_AsObject |  28.86 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  13.78 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  28.71 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  12.62 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.71 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                                        From_String | 119.71 ns | 0.0484 ns | 0.0429 ns |      - |       0 B |
                               From_String_AsObject | 131.98 ns | 0.0911 ns | 0.0852 ns |      - |       0 B |
                                   From_String_Null |  16.74 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.17 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                  From_String_Empty |  21.11 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                         From_String_Empty_AsObject |  24.47 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                                        From_UShort |  14.86 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                               From_UShort_AsObject |  31.73 ns | 0.0427 ns | 0.0334 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.98 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  31.78 ns | 0.0164 ns | 0.0146 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  13.77 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.64 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                                          From_UInt |  13.88 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                                 From_UInt_AsObject |  32.33 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  17.26 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  32.10 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.30 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.25 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                                         From_ULong |  14.00 ns | 0.0181 ns | 0.0161 ns |      - |       0 B |
                                From_ULong_AsObject |  32.39 ns | 0.0422 ns | 0.0395 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  19.68 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  32.40 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.05 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.22 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                                    From_NullObject |  17.21 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                                        From_DBNull |  16.82 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                              From_ConvertibleClass |  24.13 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  29.78 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.71 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.80 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.51 ns | 0.0130 ns | 0.0121 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  30.57 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  26.82 ns | 0.0105 ns | 0.0098 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.55 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  13.69 ns | 0.0145 ns | 0.0135 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.23 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
                                          From_Enum |  14.32 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                                 From_Enum_AsObject |  67.88 ns | 0.0115 ns | 0.0096 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  17.19 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  67.40 ns | 0.0445 ns | 0.0417 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  13.55 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.42 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
