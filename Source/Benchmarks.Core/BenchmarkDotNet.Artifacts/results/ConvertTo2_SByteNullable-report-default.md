
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.79 ns | 0.0800 ns | 0.0749 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.30 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.50 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.32 ns | 0.0236 ns | 0.0210 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.14 ns | 0.0107 ns | 0.0101 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.04 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                                             From_Byte |  14.95 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.85 ns | 0.0309 ns | 0.0289 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  18.84 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.83 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.53 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.85 ns | 0.0245 ns | 0.0230 ns |      - |       0 B |
                                             From_Char |  14.96 ns | 0.0176 ns | 0.0164 ns |      - |       0 B |
                                    From_Char_AsObject |  29.65 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.78 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.61 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.73 ns | 0.0027 ns | 0.0026 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.70 ns | 0.0227 ns | 0.0190 ns |      - |       0 B |
                                         From_DateTime |  16.09 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.33 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  18.08 ns | 0.0117 ns | 0.0103 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.04 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                          From_Decimal |  29.23 ns | 0.0414 ns | 0.0387 ns |      - |       0 B |
                                 From_Decimal_AsObject |  39.36 ns | 0.0464 ns | 0.0411 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  38.34 ns | 0.0311 ns | 0.0259 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.34 ns | 0.0306 ns | 0.0271 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.99 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.86 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                                           From_Double |  18.82 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                  From_Double_AsObject |  31.82 ns | 0.0361 ns | 0.0338 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.39 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.93 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.15 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.94 ns | 0.0749 ns | 0.0664 ns |      - |       0 B |
                                            From_Short |  16.46 ns | 0.0386 ns | 0.0343 ns |      - |       0 B |
                                   From_Short_AsObject |  29.63 ns | 0.0244 ns | 0.0216 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.95 ns | 0.0154 ns | 0.0111 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.61 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.08 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.86 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                              From_Int |  15.57 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                                     From_Int_AsObject |  29.34 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.08 ns | 0.0112 ns | 0.0093 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.38 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.04 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.45 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                             From_Long |  16.09 ns | 0.0107 ns | 0.0089 ns |      - |       0 B |
                                    From_Long_AsObject |  30.01 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  20.08 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  30.01 ns | 0.0271 ns | 0.0253 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.16 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.84 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                            From_SByte |  14.96 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                                   From_SByte_AsObject |  29.42 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  13.88 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  29.27 ns | 0.0391 ns | 0.0327 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.89 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.36 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                                            From_Float |  19.52 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                   From_Float_AsObject |  32.04 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.77 ns | 0.0177 ns | 0.0166 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.03 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.04 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.85 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                           From_String |  97.21 ns | 0.0424 ns | 0.0397 ns |      - |       0 B |
                                  From_String_AsObject | 108.57 ns | 0.1489 ns | 0.1393 ns |      - |       0 B |
                                      From_String_Null |  16.32 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.85 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                                     From_String_Empty |  16.86 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.73 ns | 0.0240 ns | 0.0224 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.83 ns | 0.0347 ns | 0.0324 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.79 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.85 ns | 0.0461 ns | 0.0408 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.08 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.83 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                             From_UInt |  15.19 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.84 ns | 0.0463 ns | 0.0433 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.77 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.82 ns | 0.0225 ns | 0.0199 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.01 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.07 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                            From_ULong |  14.95 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.82 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.31 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.82 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.15 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.01 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                       From_NullObject |  17.85 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                                           From_DBNull |  15.92 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.20 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.09 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  20.21 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.86 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.96 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.36 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.13 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.98 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.67 ns | 0.0046 ns | 0.0038 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.45 ns | 0.0210 ns | 0.0197 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.94 ns | 0.0396 ns | 0.0330 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.45 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.64 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.59 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.41 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.46 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.68 ns | 0.0137 ns | 0.0114 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.45 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.68 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.85 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                                             From_Enum |  16.12 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.39 ns | 0.0943 ns | 0.0882 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.69 ns | 0.0489 ns | 0.0458 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.38 ns | 0.0455 ns | 0.0425 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.28 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.45 ns | 0.0188 ns | 0.0175 ns |      - |       0 B |
                                      From_ParentClass |  17.62 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                             From_ParentClass_AsObject |  24.57 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.94 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.84 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                     From_ParentStruct |  14.97 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.99 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.44 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.04 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.22 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.34 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_String_Empty_AsObject: DefaultJob
