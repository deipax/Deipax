
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  15.56 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
                                 From_Bool_AsObject |  30.68 ns | 0.0265 ns | 0.0234 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  19.64 ns | 0.0137 ns | 0.0115 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  30.64 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.59 ns | 0.0302 ns | 0.0252 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.85 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                                          From_Byte |  15.33 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
                                 From_Byte_AsObject |  30.64 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  19.16 ns | 0.0537 ns | 0.0476 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  30.65 ns | 0.0154 ns | 0.0129 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.62 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.72 ns | 0.0209 ns | 0.0196 ns |      - |       0 B |
                                          From_Char |  15.31 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                                 From_Char_AsObject |  31.81 ns | 0.0511 ns | 0.0453 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  18.63 ns | 0.0340 ns | 0.0302 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  31.81 ns | 0.0549 ns | 0.0513 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  15.81 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  20.16 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
                                      From_DateTime |  15.81 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  15.20 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.18 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  19.04 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                                       From_Decimal |  24.57 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                              From_Decimal_AsObject |  42.42 ns | 0.0440 ns | 0.0390 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  32.68 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  42.30 ns | 0.0476 ns | 0.0446 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  16.20 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.68 ns | 0.0074 ns | 0.0061 ns |      - |       0 B |
                                        From_Double |  18.62 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                               From_Double_AsObject |  34.71 ns | 0.0259 ns | 0.0203 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  22.64 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  34.74 ns | 0.0560 ns | 0.0496 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.32 ns | 0.0112 ns | 0.0093 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  20.79 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
                                         From_Short |  16.07 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                From_Short_AsObject |  31.29 ns | 0.0908 ns | 0.0849 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.26 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  31.20 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.83 ns | 0.0024 ns | 0.0017 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.76 ns | 0.0469 ns | 0.0439 ns |      - |       0 B |
                                           From_Int |  15.56 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                  From_Int_AsObject |  32.11 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  19.62 ns | 0.0464 ns | 0.0434 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  32.13 ns | 0.0962 ns | 0.0900 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  15.82 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.72 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                                          From_Long |  15.56 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                                 From_Long_AsObject |  31.24 ns | 0.0754 ns | 0.0705 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  20.19 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  31.21 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  16.32 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  19.29 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                         From_SByte |  16.06 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                                From_SByte_AsObject |  31.16 ns | 0.0479 ns | 0.0400 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  19.38 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  32.14 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.58 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  19.06 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                                         From_Float |  19.15 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                From_Float_AsObject |  36.60 ns | 0.0572 ns | 0.0535 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  23.50 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  36.60 ns | 0.0444 ns | 0.0415 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  15.81 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.70 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                        From_String |  90.46 ns | 0.0452 ns | 0.0401 ns |      - |       0 B |
                               From_String_AsObject | 103.68 ns | 0.0372 ns | 0.0310 ns |      - |       0 B |
                                   From_String_Null |  17.87 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                          From_String_Null_AsObject |  20.90 ns | 0.0014 ns | 0.0010 ns |      - |       0 B |
                                  From_String_Empty |  17.91 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  15.30 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                               From_UShort_AsObject |  30.62 ns | 0.0062 ns | 0.0049 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  18.61 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  30.63 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.82 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.66 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
                                          From_UInt |  15.17 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                                 From_UInt_AsObject |  30.61 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.64 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  31.65 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  15.85 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.73 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                                         From_ULong |  15.21 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                                From_ULong_AsObject |  30.96 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  15.10 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  32.15 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.07 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  19.05 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                    From_NullObject |  18.71 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                        From_DBNull |  17.95 ns | 0.0213 ns | 0.0200 ns |      - |       0 B |
                              From_ConvertibleClass |  26.55 ns | 0.0093 ns | 0.0067 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.35 ns | 0.0317 ns | 0.0297 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.68 ns | 0.0165 ns | 0.0138 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.72 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.41 ns | 0.0281 ns | 0.0263 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.80 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.00 ns | 0.0068 ns | 0.0056 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.73 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.59 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.67 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                          From_Enum |  15.91 ns | 0.0308 ns | 0.0273 ns |      - |       0 B |
                                 From_Enum_AsObject |  63.03 ns | 0.0295 ns | 0.0261 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  19.15 ns | 0.0407 ns | 0.0381 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  63.19 ns | 0.0140 ns | 0.0117 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  16.26 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.71 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_String_Empty_AsObject: DefaultJob
