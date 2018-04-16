
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.66 ns | 0.0486 ns | 0.0454 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.27 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.52 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.47 ns | 0.0494 ns | 0.0412 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.27 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.03 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                                             From_Byte |  14.69 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                                    From_Byte_AsObject |  29.33 ns | 0.0083 ns | 0.0065 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  13.93 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  29.80 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.97 ns | 0.0418 ns | 0.0391 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.04 ns | 0.0235 ns | 0.0208 ns |      - |       0 B |
                                             From_Char |  15.22 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
                                    From_Char_AsObject |  29.65 ns | 0.0490 ns | 0.0458 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  19.11 ns | 0.0712 ns | 0.0666 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  30.97 ns | 0.0364 ns | 0.0341 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.09 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.04 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                                         From_DateTime |  16.00 ns | 0.1974 ns | 0.1750 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.23 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.00 ns | 0.1175 ns | 0.0981 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.02 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                                          From_Decimal |  28.90 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.10 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  37.87 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.16 ns | 0.0411 ns | 0.0344 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.08 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.02 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
                                           From_Double |  19.11 ns | 0.0360 ns | 0.0319 ns |      - |       0 B |
                                  From_Double_AsObject |  32.05 ns | 0.0215 ns | 0.0180 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  32.18 ns | 0.0370 ns | 0.0328 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.05 ns | 0.0227 ns | 0.0213 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.13 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.88 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                                            From_Short |  15.87 ns | 0.0317 ns | 0.0265 ns |      - |       0 B |
                                   From_Short_AsObject |  29.61 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.84 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.61 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.01 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.40 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                                              From_Int |  15.66 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                                     From_Int_AsObject |  29.61 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.49 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.62 ns | 0.0210 ns | 0.0196 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.98 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.90 ns | 0.0597 ns | 0.0558 ns |      - |       0 B |
                                             From_Long |  16.92 ns | 0.0445 ns | 0.0416 ns |      - |       0 B |
                                    From_Long_AsObject |  29.70 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.91 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.74 ns | 0.0917 ns | 0.0858 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.46 ns | 0.0242 ns | 0.0215 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.49 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                                            From_SByte |  14.96 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.92 ns | 0.0962 ns | 0.0899 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  18.72 ns | 0.0362 ns | 0.0338 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.89 ns | 0.0166 ns | 0.0129 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.05 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.93 ns | 0.0528 ns | 0.0494 ns |      - |       0 B |
                                            From_Float |  19.61 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                                   From_Float_AsObject |  36.44 ns | 0.0094 ns | 0.0073 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  23.77 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.55 ns | 0.0284 ns | 0.0237 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.71 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.83 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                                           From_String |  96.82 ns | 0.2309 ns | 0.2160 ns |      - |       0 B |
                                  From_String_AsObject | 107.69 ns | 0.0368 ns | 0.0326 ns |      - |       0 B |
                                      From_String_Null |  16.27 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.84 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
                                     From_String_Empty |  16.57 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.93 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.80 ns | 0.0164 ns | 0.0128 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.77 ns | 0.0137 ns | 0.0107 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.80 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.09 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.04 ns | 0.1482 ns | 0.1386 ns |      - |       0 B |
                                             From_UInt |  15.13 ns | 0.1825 ns | 0.1707 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.08 ns | 0.3723 ns | 0.3483 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.98 ns | 0.2134 ns | 0.1996 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.12 ns | 0.3089 ns | 0.2889 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.36 ns | 0.3287 ns | 0.3913 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.59 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                            From_ULong |  16.68 ns | 0.0349 ns | 0.0327 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.61 ns | 0.0177 ns | 0.0165 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.63 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.62 ns | 0.0203 ns | 0.0180 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.70 ns | 0.0067 ns | 0.0062 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.01 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                       From_NullObject |  18.15 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                           From_DBNull |  16.65 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.19 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.09 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.02 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.59 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.66 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.95 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.20 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.85 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.29 ns | 0.0629 ns | 0.0557 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.47 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.99 ns | 0.0160 ns | 0.0149 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.48 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.41 ns | 0.0396 ns | 0.0351 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.86 ns | 0.0142 ns | 0.0118 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.40 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.36 ns | 0.0315 ns | 0.0279 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.67 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.33 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.08 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.83 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                             From_Enum |  15.76 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                                    From_Enum_AsObject |  63.06 ns | 0.0678 ns | 0.0566 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.46 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  63.09 ns | 0.0737 ns | 0.0690 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.11 ns | 0.0207 ns | 0.0150 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.85 ns | 0.0275 ns | 0.0244 ns |      - |       0 B |
                                      From_ParentClass |  17.91 ns | 0.0071 ns | 0.0056 ns |      - |       0 B |
                             From_ParentClass_AsObject |  24.09 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.05 ns | 0.0159 ns | 0.0124 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.01 ns | 0.0024 ns | 0.0018 ns |      - |       0 B |
                                     From_ParentStruct |  14.41 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.52 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.68 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.92 ns | 0.0229 ns | 0.0191 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.55 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.35 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_String_Empty_AsObject: DefaultJob
