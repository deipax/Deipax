
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.85 ns | 0.0685 ns | 0.0572 ns |  13.85 ns |      - |       0 B |
                                    From_Bool_AsObject |  24.62 ns | 0.0583 ns | 0.0517 ns |  24.61 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  14.52 ns | 0.0229 ns | 0.0191 ns |  14.52 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  24.57 ns | 0.0308 ns | 0.0257 ns |  24.58 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.95 ns | 0.0115 ns | 0.0096 ns |  13.94 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.63 ns | 0.0370 ns | 0.0346 ns |  17.63 ns |      - |       0 B |
                                             From_Byte |  15.74 ns | 0.0095 ns | 0.0079 ns |  15.73 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.60 ns | 0.0385 ns | 0.0360 ns |  25.60 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.15 ns | 0.0066 ns | 0.0055 ns |  14.15 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  24.59 ns | 0.0677 ns | 0.0633 ns |  24.59 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.82 ns | 0.0033 ns | 0.0028 ns |  13.82 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.23 ns | 0.0189 ns | 0.0177 ns |  18.23 ns |      - |       0 B |
                                             From_Char |  13.71 ns | 0.0176 ns | 0.0156 ns |  13.70 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  13.76 ns | 0.0082 ns | 0.0069 ns |  13.76 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.74 ns | 0.0326 ns | 0.0305 ns |  13.74 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.67 ns | 0.0156 ns | 0.0146 ns |  17.67 ns |      - |       0 B |
                                         From_DateTime |  14.08 ns | 0.0138 ns | 0.0129 ns |  14.08 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.59 ns | 0.0329 ns | 0.0307 ns |  14.57 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.59 ns | 0.0442 ns | 0.0392 ns |  14.58 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.89 ns | 0.0156 ns | 0.0146 ns |  18.90 ns |      - |       0 B |
                                          From_Decimal |  24.61 ns | 0.0470 ns | 0.0439 ns |  24.58 ns |      - |       0 B |
                                 From_Decimal_AsObject |  32.81 ns | 0.1129 ns | 0.1056 ns |  32.79 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  30.28 ns | 0.0067 ns | 0.0056 ns |  30.28 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  32.73 ns | 0.0606 ns | 0.0567 ns |  32.75 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.17 ns | 0.0257 ns | 0.0240 ns |  17.16 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.72 ns | 0.0105 ns | 0.0098 ns |  17.72 ns |      - |       0 B |
                                           From_Double |  13.92 ns | 0.0214 ns | 0.0178 ns |  13.92 ns |      - |       0 B |
                                  From_Double_AsObject |  24.58 ns | 0.0152 ns | 0.0135 ns |  24.57 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.09 ns | 0.0207 ns | 0.0173 ns |  15.08 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  25.67 ns | 0.0577 ns | 0.0511 ns |  25.66 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.59 ns | 0.0337 ns | 0.0281 ns |  16.58 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.14 ns | 0.0367 ns | 0.0343 ns |  17.12 ns |      - |       0 B |
                                            From_Short |  13.96 ns | 0.0314 ns | 0.0294 ns |  13.95 ns |      - |       0 B |
                                   From_Short_AsObject |  25.07 ns | 0.0525 ns | 0.0465 ns |  25.05 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.21 ns | 0.0077 ns | 0.0068 ns |  14.21 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.02 ns | 0.0195 ns | 0.0173 ns |  26.01 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.93 ns | 0.0052 ns | 0.0046 ns |  13.93 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.01 ns | 0.0330 ns | 0.0308 ns |  18.03 ns |      - |       0 B |
                                              From_Int |  14.75 ns | 0.0058 ns | 0.0046 ns |  14.75 ns |      - |       0 B |
                                     From_Int_AsObject |  24.58 ns | 0.0121 ns | 0.0108 ns |  24.58 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.08 ns | 0.0041 ns | 0.0032 ns |  17.08 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.65 ns | 0.0594 ns | 0.0527 ns |  25.66 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.94 ns | 0.0032 ns | 0.0030 ns |  14.94 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.59 ns | 0.0153 ns | 0.0128 ns |  17.59 ns |      - |       0 B |
                                             From_Long |  13.81 ns | 0.0068 ns | 0.0053 ns |  13.81 ns |      - |       0 B |
                                    From_Long_AsObject |  24.91 ns | 0.0389 ns | 0.0345 ns |  24.90 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.09 ns | 0.0234 ns | 0.0219 ns |  15.08 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  24.84 ns | 0.0150 ns | 0.0133 ns |  24.83 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.08 ns | 0.0061 ns | 0.0051 ns |  16.08 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.82 ns | 0.0188 ns | 0.0147 ns |  16.81 ns |      - |       0 B |
                                            From_SByte |  14.86 ns | 0.0049 ns | 0.0041 ns |  14.86 ns |      - |       0 B |
                                   From_SByte_AsObject |  24.57 ns | 0.0118 ns | 0.0111 ns |  24.57 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.30 ns | 0.0061 ns | 0.0051 ns |  14.30 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  24.66 ns | 0.0377 ns | 0.0353 ns |  24.67 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.81 ns | 0.0056 ns | 0.0047 ns |  13.81 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.87 ns | 0.0167 ns | 0.0148 ns |  19.87 ns |      - |       0 B |
                                            From_Float |  13.95 ns | 0.0374 ns | 0.0331 ns |  13.93 ns |      - |       0 B |
                                   From_Float_AsObject |  28.60 ns | 0.0771 ns | 0.0683 ns |  28.60 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  13.42 ns | 0.0069 ns | 0.0054 ns |  13.41 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  28.80 ns | 0.0559 ns | 0.0496 ns |  28.80 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.29 ns | 0.0043 ns | 0.0033 ns |  13.29 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  19.55 ns | 0.0137 ns | 0.0121 ns |  19.56 ns |      - |       0 B |
                                           From_String | 109.00 ns | 0.1079 ns | 0.1009 ns | 108.95 ns |      - |       0 B |
                                  From_String_AsObject | 119.72 ns | 0.1662 ns | 0.1555 ns | 119.74 ns |      - |       0 B |
                                      From_String_Null |  15.42 ns | 0.0329 ns | 0.0308 ns |  15.41 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.74 ns | 0.0265 ns | 0.0221 ns |  17.75 ns |      - |       0 B |
                                     From_String_Empty |  16.71 ns | 0.0076 ns | 0.0059 ns |  16.70 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.80 ns | 0.0045 ns | 0.0035 ns |  13.80 ns |      - |       0 B |
                                  From_UShort_AsObject |  24.61 ns | 0.0517 ns | 0.0484 ns |  24.63 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.61 ns | 0.0070 ns | 0.0059 ns |  15.61 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  24.57 ns | 0.0100 ns | 0.0089 ns |  24.58 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.94 ns | 0.0042 ns | 0.0037 ns |  13.94 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.22 ns | 0.0095 ns | 0.0084 ns |  18.22 ns |      - |       0 B |
                                             From_UInt |  13.99 ns | 0.0106 ns | 0.0094 ns |  13.99 ns |      - |       0 B |
                                    From_UInt_AsObject |  24.83 ns | 0.0164 ns | 0.0145 ns |  24.83 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.53 ns | 0.0308 ns | 0.0288 ns |  15.52 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  24.93 ns | 0.0348 ns | 0.0291 ns |  24.94 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.86 ns | 0.0038 ns | 0.0030 ns |  13.86 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  19.84 ns | 0.0258 ns | 0.0229 ns |  19.84 ns |      - |       0 B |
                                            From_ULong |  14.17 ns | 0.0052 ns | 0.0043 ns |  14.16 ns |      - |       0 B |
                                   From_ULong_AsObject |  25.42 ns | 0.0395 ns | 0.0330 ns |  25.41 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.60 ns | 0.0259 ns | 0.0243 ns |  15.59 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  25.35 ns | 0.0201 ns | 0.0168 ns |  25.35 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.83 ns | 0.0040 ns | 0.0032 ns |  14.83 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.21 ns | 0.0094 ns | 0.0083 ns |  18.21 ns |      - |       0 B |
                                       From_NullObject |  16.76 ns | 0.0256 ns | 0.0240 ns |  16.75 ns |      - |       0 B |
                                           From_DBNull |  14.97 ns | 0.0219 ns | 0.0194 ns |  14.97 ns |      - |       0 B |
                                  From_DBNull_AsObject |  16.71 ns | 0.0398 ns | 0.0372 ns |  16.68 ns |      - |       0 B |
                                 From_ConvertibleClass |  20.25 ns | 0.0192 ns | 0.0170 ns |  20.24 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  22.27 ns | 0.0651 ns | 0.0544 ns |  22.23 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.34 ns | 0.4065 ns | 0.5141 ns |  19.14 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.73 ns | 0.0746 ns | 0.0582 ns |  17.71 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.52 ns | 0.3519 ns | 0.3456 ns |  16.35 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  20.14 ns | 0.1620 ns | 0.1353 ns |  20.15 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.06 ns | 0.0205 ns | 0.0182 ns |  15.06 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  16.99 ns | 0.1817 ns | 0.1517 ns |  16.94 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.82 ns | 0.1271 ns | 0.0992 ns |  22.86 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  23.62 ns | 0.1268 ns | 0.1124 ns |  23.59 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  23.14 ns | 0.1682 ns | 0.1491 ns |  23.07 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  23.73 ns | 0.1956 ns | 0.1830 ns |  23.67 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.88 ns | 0.0948 ns | 0.0887 ns |  15.86 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.00 ns | 0.0548 ns | 0.0457 ns |  17.98 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.66 ns | 0.0611 ns | 0.0571 ns |  14.64 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.40 ns | 0.0776 ns | 0.0726 ns |  23.38 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.85 ns | 0.1835 ns | 0.1626 ns |  14.85 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  19.35 ns | 0.1214 ns | 0.1014 ns |  19.32 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  20.91 ns | 0.2517 ns | 0.2354 ns |  20.75 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.90 ns | 0.1808 ns | 0.1603 ns |  16.85 ns |      - |       0 B |
                                             From_Enum |  14.16 ns | 0.3110 ns | 0.3457 ns |  13.99 ns |      - |       0 B |
                                    From_Enum_AsObject |  55.99 ns | 0.5657 ns | 0.5015 ns |  56.06 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  15.94 ns | 0.0811 ns | 0.0678 ns |  15.93 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  55.36 ns | 0.1875 ns | 0.1662 ns |  55.31 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  14.16 ns | 0.0039 ns | 0.0030 ns |  14.16 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.57 ns | 0.3069 ns | 0.2721 ns |  18.45 ns |      - |       0 B |
                                      From_ParentClass |  15.09 ns | 0.1289 ns | 0.1143 ns |  15.04 ns |      - |       0 B |
                             From_ParentClass_AsObject |  20.52 ns | 0.2043 ns | 0.1911 ns |  20.52 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.43 ns | 0.3351 ns | 0.5315 ns |  15.13 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.11 ns | 0.4994 ns | 0.7001 ns |  16.78 ns |      - |       0 B |
                                     From_ParentStruct |  15.51 ns | 0.0273 ns | 0.0255 ns |  15.50 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  19.71 ns | 0.0279 ns | 0.0261 ns |  19.69 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.62 ns | 0.0208 ns | 0.0194 ns |  14.62 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.21 ns | 0.0225 ns | 0.0188 ns |  22.21 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.60 ns | 0.0296 ns | 0.0277 ns |  14.58 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  16.73 ns | 0.0194 ns | 0.0162 ns |  16.73 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_String_Empty_AsObject: DefaultJob
