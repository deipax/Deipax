
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  40.95 ns | 0.0170 ns | 0.0142 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  39.05 ns | 0.3077 ns | 0.2569 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 113.39 ns | 0.0637 ns | 0.0565 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.95 ns | 0.0577 ns | 0.0539 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  42.70 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.26 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                                          From_Byte |  41.03 ns | 0.0072 ns | 0.0060 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  39.10 ns | 0.0631 ns | 0.0590 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 114.64 ns | 0.0495 ns | 0.0463 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  38.95 ns | 0.0515 ns | 0.0482 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  42.42 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.99 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                                          From_Char |  41.41 ns | 0.0221 ns | 0.0207 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  40.37 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 116.19 ns | 0.0390 ns | 0.0282 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  40.38 ns | 0.0462 ns | 0.0409 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.68 ns | 0.0426 ns | 0.0399 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.97 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  42.70 ns | 0.0271 ns | 0.0253 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.22 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                                       From_Decimal |  54.68 ns | 0.0080 ns | 0.0071 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  51.59 ns | 0.0379 ns | 0.0336 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 130.83 ns | 0.0270 ns | 0.0239 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  51.59 ns | 0.0566 ns | 0.0529 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.86 ns | 0.0965 ns | 0.0903 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.24 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                                        From_Double |  44.37 ns | 0.0320 ns | 0.0283 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  43.08 ns | 0.0442 ns | 0.0369 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 120.96 ns | 0.0834 ns | 0.0739 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  42.92 ns | 0.0536 ns | 0.0502 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.74 ns | 0.0432 ns | 0.0404 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.01 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                         From_Short |  28.59 ns | 0.1455 ns | 0.1290 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  27.44 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 102.21 ns | 0.0096 ns | 0.0075 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  27.44 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.84 ns | 0.0214 ns | 0.0179 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.98 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                           From_Int |  41.30 ns | 0.0079 ns | 0.0062 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  40.27 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 117.20 ns | 0.1974 ns | 0.1750 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  40.45 ns | 0.0628 ns | 0.0556 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.90 ns | 0.0236 ns | 0.0221 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.24 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                                          From_Long |  42.55 ns | 0.0100 ns | 0.0094 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  40.27 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 118.35 ns | 0.0468 ns | 0.0438 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  40.30 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  41.46 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.77 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                                         From_SByte |  40.25 ns | 0.0117 ns | 0.0104 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  39.10 ns | 0.0384 ns | 0.0360 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 116.90 ns | 0.0257 ns | 0.0240 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  39.54 ns | 0.0682 ns | 0.0638 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  43.09 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  15.93 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                         From_Float |  44.63 ns | 0.0147 ns | 0.0131 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  43.31 ns | 0.0261 ns | 0.0232 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 120.49 ns | 0.1082 ns | 0.0960 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  43.36 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  42.50 ns | 0.0331 ns | 0.0293 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.98 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                                        From_String | 119.51 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                               From_String_AsObject | 119.69 ns | 0.0527 ns | 0.0411 ns |      - |       0 B |
                                   From_String_Null |  15.22 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.99 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  40.53 ns | 0.0460 ns | 0.0408 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  39.49 ns | 0.0505 ns | 0.0472 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 117.06 ns | 0.0566 ns | 0.0530 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  39.54 ns | 0.0406 ns | 0.0360 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.82 ns | 0.0773 ns | 0.0723 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.79 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                          From_UInt |  42.48 ns | 0.0124 ns | 0.0116 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  40.36 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 117.01 ns | 0.0220 ns | 0.0172 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  40.51 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.81 ns | 0.0458 ns | 0.0428 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.78 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
                                         From_ULong |  41.69 ns | 0.0183 ns | 0.0162 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  40.35 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 116.98 ns | 0.0354 ns | 0.0296 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  40.36 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.91 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.83 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                                    From_NullObject |  14.97 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                        From_DBNull |  15.22 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                              From_ConvertibleClass |  37.13 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  37.13 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.22 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.66 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                             From_ConvertibleStruct |  40.10 ns | 0.0259 ns | 0.0230 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  38.42 ns | 0.0890 ns | 0.0833 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 119.44 ns | 0.1237 ns | 0.1157 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  38.41 ns | 0.0800 ns | 0.0709 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  43.09 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.22 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                          From_Enum |  96.65 ns | 0.0350 ns | 0.0327 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  98.84 ns | 0.0416 ns | 0.0389 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 204.63 ns | 0.3079 ns | 0.2880 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  93.99 ns | 0.0115 ns | 0.0107 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.11 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.99 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_ShortNullable.From_DateTime: DefaultJob
  ConvertTo_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ShortNullable.From_String_Empty: DefaultJob
  ConvertTo_ShortNullable.From_String_Empty_AsObject: DefaultJob
