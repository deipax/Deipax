
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.91 ns | 0.0723 ns | 0.0676 ns |      - |       0 B |
                                    From_Bool_AsObject |  24.73 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  14.20 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  24.79 ns | 0.0782 ns | 0.0731 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.84 ns | 0.0103 ns | 0.0092 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.77 ns | 0.0070 ns | 0.0055 ns |      - |       0 B |
                                             From_Byte |  13.99 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.88 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.69 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.74 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.98 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.92 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                             From_Char |  14.08 ns | 0.0321 ns | 0.0268 ns |      - |       0 B |
                                    From_Char_AsObject |  26.10 ns | 0.0710 ns | 0.0664 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.73 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.04 ns | 0.0342 ns | 0.0303 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.99 ns | 0.0182 ns | 0.0152 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.96 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                                         From_DateTime |  17.01 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.77 ns | 0.0405 ns | 0.0379 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.94 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.92 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                                          From_Decimal |  29.78 ns | 0.0414 ns | 0.0367 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.18 ns | 0.0220 ns | 0.0184 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  30.17 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.20 ns | 0.0523 ns | 0.0437 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.79 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.55 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                                           From_Double |  18.66 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                                  From_Double_AsObject |  28.12 ns | 0.0502 ns | 0.0470 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.18 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  28.18 ns | 0.0352 ns | 0.0312 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.82 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.68 ns | 0.0176 ns | 0.0164 ns |      - |       0 B |
                                            From_Short |  15.86 ns | 0.0362 ns | 0.0339 ns |      - |       0 B |
                                   From_Short_AsObject |  26.16 ns | 0.0319 ns | 0.0283 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.59 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.09 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.78 ns | 0.0076 ns | 0.0064 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.64 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                                              From_Int |  16.00 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                                     From_Int_AsObject |  25.77 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.54 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.89 ns | 0.0384 ns | 0.0340 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.83 ns | 0.0056 ns | 0.0044 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  16.74 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                                             From_Long |  15.06 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                    From_Long_AsObject |  26.60 ns | 0.0251 ns | 0.0223 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.87 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.53 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.82 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.82 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
                                            From_SByte |  13.94 ns | 0.0214 ns | 0.0201 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.58 ns | 0.0182 ns | 0.0152 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.40 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.27 ns | 0.0407 ns | 0.0380 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.16 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  20.45 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                                            From_Float |  18.37 ns | 0.0387 ns | 0.0343 ns |      - |       0 B |
                                   From_Float_AsObject |  28.38 ns | 0.0511 ns | 0.0453 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  18.40 ns | 0.0090 ns | 0.0079 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.34 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.78 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.85 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                                           From_String |  92.55 ns | 0.1102 ns | 0.1031 ns |      - |       0 B |
                                  From_String_AsObject | 101.55 ns | 0.1570 ns | 0.1469 ns |      - |       0 B |
                                      From_String_Null |  15.64 ns | 0.0180 ns | 0.0150 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.71 ns | 0.0052 ns | 0.0041 ns |      - |       0 B |
                                     From_String_Empty |  15.74 ns | 0.0133 ns | 0.0104 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.89 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.22 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.44 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.22 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.08 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.66 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                                             From_UInt |  14.18 ns | 0.0306 ns | 0.0256 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.41 ns | 0.0694 ns | 0.0649 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  14.57 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.23 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.95 ns | 0.0188 ns | 0.0157 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.48 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                                            From_ULong |  13.99 ns | 0.0096 ns | 0.0089 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.29 ns | 0.0447 ns | 0.0418 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.60 ns | 0.0135 ns | 0.0112 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  25.29 ns | 0.0324 ns | 0.0303 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.82 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.57 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                                       From_NullObject |  17.71 ns | 0.0220 ns | 0.0195 ns |      - |       0 B |
                                           From_DBNull |  15.45 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                  From_DBNull_AsObject |  16.74 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                                 From_ConvertibleClass |  20.30 ns | 0.0437 ns | 0.0409 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.30 ns | 0.0424 ns | 0.0397 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.76 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.73 ns | 0.0091 ns | 0.0071 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.00 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  20.36 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.36 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.74 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.59 ns | 0.0145 ns | 0.0136 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.55 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  22.72 ns | 0.0402 ns | 0.0376 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.98 ns | 0.0328 ns | 0.0306 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.47 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  20.82 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.50 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  19.17 ns | 0.0111 ns | 0.0093 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.55 ns | 0.0363 ns | 0.0339 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  19.23 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.43 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.70 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
                                             From_Enum |  14.65 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
                                    From_Enum_AsObject |  56.07 ns | 0.0350 ns | 0.0292 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  15.19 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  56.64 ns | 0.0211 ns | 0.0164 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  14.02 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.88 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                                      From_ParentClass |  17.50 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                             From_ParentClass_AsObject |  19.68 ns | 0.0276 ns | 0.0245 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.01 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.71 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                     From_ParentStruct |  14.58 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  21.25 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.57 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  21.08 ns | 0.0110 ns | 0.0092 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.58 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.82 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_String_Empty_AsObject: DefaultJob
