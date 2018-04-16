
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.86 ns | 0.0768 ns | 0.0641 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.97 ns | 0.0334 ns | 0.0279 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  20.72 ns | 0.0210 ns | 0.0197 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.96 ns | 0.0347 ns | 0.0325 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.23 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.69 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                                             From_Byte |  16.15 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.96 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  20.19 ns | 0.0252 ns | 0.0224 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  31.01 ns | 0.0349 ns | 0.0292 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.21 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.82 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                                             From_Char |  16.14 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
                                    From_Char_AsObject |  31.76 ns | 0.0211 ns | 0.0198 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  20.16 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  31.78 ns | 0.0307 ns | 0.0272 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  16.67 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.68 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
                                         From_DateTime |  15.57 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.05 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.03 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.87 ns | 0.0261 ns | 0.0231 ns |      - |       0 B |
                                          From_Decimal |  26.55 ns | 0.0262 ns | 0.0219 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.74 ns | 0.0591 ns | 0.0524 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  36.73 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.69 ns | 0.0484 ns | 0.0453 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.09 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.12 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                                           From_Double |  19.90 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                  From_Double_AsObject |  36.01 ns | 0.0378 ns | 0.0354 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  24.85 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.96 ns | 0.0396 ns | 0.0370 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  18.86 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  19.70 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                                            From_Short |  16.15 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                                   From_Short_AsObject |  30.97 ns | 0.0350 ns | 0.0327 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  20.19 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  30.96 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.70 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.68 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                              From_Int |  15.74 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                                     From_Int_AsObject |  30.98 ns | 0.0236 ns | 0.0197 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  20.19 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.97 ns | 0.0324 ns | 0.0287 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.68 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.69 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                             From_Long |  17.16 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                                    From_Long_AsObject |  31.07 ns | 0.0271 ns | 0.0253 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.43 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.06 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.43 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.04 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                                            From_SByte |  16.13 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.96 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  20.18 ns | 0.0200 ns | 0.0178 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.95 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.23 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.69 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
                                            From_Float |  20.20 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                                   From_Float_AsObject |  36.08 ns | 0.0250 ns | 0.0233 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  23.97 ns | 0.0165 ns | 0.0147 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.07 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.68 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.68 ns | 0.0155 ns | 0.0130 ns |      - |       0 B |
                                           From_String |  93.59 ns | 0.0588 ns | 0.0521 ns |      - |       0 B |
                                  From_String_AsObject | 108.22 ns | 0.0638 ns | 0.0597 ns |      - |       0 B |
                                      From_String_Null |  18.21 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.11 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                                     From_String_Empty |  17.48 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.14 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.95 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  20.18 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  31.32 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.67 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.73 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
                                             From_UInt |  16.00 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.94 ns | 0.0057 ns | 0.0044 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  20.17 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.94 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  18.23 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.87 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                            From_ULong |  16.82 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                   From_ULong_AsObject |  31.75 ns | 0.0094 ns | 0.0073 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  21.43 ns | 0.0157 ns | 0.0131 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  31.77 ns | 0.0226 ns | 0.0212 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.22 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.68 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                       From_NullObject |  18.67 ns | 0.0116 ns | 0.0102 ns |      - |       0 B |
                                           From_DBNull |  17.74 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.29 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.78 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  26.11 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.69 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.82 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.75 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.83 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.67 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.83 ns | 0.0116 ns | 0.0109 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.12 ns | 0.0110 ns | 0.0086 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.51 ns | 0.0100 ns | 0.0088 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.12 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.23 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.68 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.22 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.40 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.86 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.35 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.86 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.71 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                                             From_Enum |  15.73 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.71 ns | 0.0302 ns | 0.0252 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.63 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  62.75 ns | 0.0427 ns | 0.0400 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.68 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.19 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                                      From_ParentClass |  17.83 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.87 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.84 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.68 ns | 0.0110 ns | 0.0102 ns |      - |       0 B |
                                     From_ParentStruct |  15.89 ns | 0.0178 ns | 0.0139 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  26.38 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.88 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.12 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.88 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.11 ns | 0.0112 ns | 0.0104 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
