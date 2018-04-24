
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.87 ns | 0.0588 ns | 0.0550 ns |      - |       0 B |
                                    From_Bool_AsObject | 25.73 ns | 0.0507 ns | 0.0475 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.28 ns | 0.0346 ns | 0.0323 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 25.73 ns | 0.0346 ns | 0.0324 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.66 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.63 ns | 0.0445 ns | 0.0416 ns |      - |       0 B |
                                             From_Byte | 13.99 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
                                    From_Byte_AsObject | 24.77 ns | 0.0172 ns | 0.0144 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.08 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.74 ns | 0.0491 ns | 0.0435 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.73 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.66 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
                                             From_Char | 15.50 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                                    From_Char_AsObject | 26.10 ns | 0.0838 ns | 0.0784 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.64 ns | 0.0625 ns | 0.0585 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 26.07 ns | 0.0557 ns | 0.0521 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 15.80 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.02 ns | 0.0314 ns | 0.0294 ns |      - |       0 B |
                                         From_DateTime | 14.17 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.59 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.63 ns | 0.0506 ns | 0.0473 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.63 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                          From_Decimal | 27.67 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                                 From_Decimal_AsObject | 37.54 ns | 0.0779 ns | 0.0691 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 31.92 ns | 0.0217 ns | 0.0192 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.61 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.81 ns | 0.0150 ns | 0.0117 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.85 ns | 0.0286 ns | 0.0268 ns |      - |       0 B |
                                           From_Double | 17.92 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                                  From_Double_AsObject | 28.33 ns | 0.0136 ns | 0.0113 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.50 ns | 0.0481 ns | 0.0450 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 29.30 ns | 0.0438 ns | 0.0410 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.84 ns | 0.0176 ns | 0.0147 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 19.12 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                                            From_Short | 13.76 ns | 0.0420 ns | 0.0373 ns |      - |       0 B |
                                   From_Short_AsObject | 29.57 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 13.73 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 29.75 ns | 0.0226 ns | 0.0189 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.06 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.79 ns | 0.0221 ns | 0.0206 ns |      - |       0 B |
                                              From_Int | 15.09 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                     From_Int_AsObject | 26.99 ns | 0.0303 ns | 0.0269 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.61 ns | 0.0368 ns | 0.0326 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.10 ns | 0.0181 ns | 0.0170 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.84 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.82 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                                             From_Long | 15.08 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
                                    From_Long_AsObject | 26.13 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.88 ns | 0.0399 ns | 0.0333 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.01 ns | 0.0283 ns | 0.0251 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.83 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.85 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                                            From_SByte | 13.93 ns | 0.0048 ns | 0.0037 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.81 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.00 ns | 0.0077 ns | 0.0060 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 24.85 ns | 0.0440 ns | 0.0344 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.79 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.91 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                                            From_Float | 18.35 ns | 0.0076 ns | 0.0063 ns |      - |       0 B |
                                   From_Float_AsObject | 28.67 ns | 0.0835 ns | 0.0781 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.77 ns | 0.0270 ns | 0.0239 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 28.65 ns | 0.0284 ns | 0.0251 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.80 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.81 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                                           From_String | 89.77 ns | 0.0240 ns | 0.0201 ns |      - |       0 B |
                                  From_String_AsObject | 98.50 ns | 0.0325 ns | 0.0235 ns |      - |       0 B |
                                      From_String_Null | 15.92 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                             From_String_Null_AsObject | 19.34 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                                     From_String_Empty | 15.43 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.80 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.33 ns | 0.0578 ns | 0.0541 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.57 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.27 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.17 ns | 0.0058 ns | 0.0052 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 20.87 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                                             From_UInt | 14.83 ns | 0.0286 ns | 0.0239 ns |      - |       0 B |
                                    From_UInt_AsObject | 27.04 ns | 0.0312 ns | 0.0276 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.66 ns | 0.0344 ns | 0.0305 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.99 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.82 ns | 0.0454 ns | 0.0424 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.58 ns | 0.0231 ns | 0.0204 ns |      - |       0 B |
                                            From_ULong | 15.99 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                                   From_ULong_AsObject | 27.13 ns | 0.0576 ns | 0.0538 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.87 ns | 0.0251 ns | 0.0223 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.09 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.84 ns | 0.0379 ns | 0.0354 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.95 ns | 0.0276 ns | 0.0230 ns |      - |       0 B |
                                       From_NullObject | 16.86 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                                           From_DBNull | 15.04 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.56 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.32 ns | 0.0261 ns | 0.0204 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.23 ns | 0.0053 ns | 0.0041 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.59 ns | 0.0112 ns | 0.0104 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 19.77 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.10 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.18 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.10 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.85 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.65 ns | 0.0159 ns | 0.0148 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.51 ns | 0.0061 ns | 0.0048 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 23.21 ns | 0.0153 ns | 0.0119 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.51 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.52 ns | 0.0130 ns | 0.0094 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.89 ns | 0.0114 ns | 0.0089 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.52 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.03 ns | 0.0489 ns | 0.0433 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.57 ns | 0.0239 ns | 0.0224 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.09 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.58 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.23 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                                             From_Enum | 15.17 ns | 0.0403 ns | 0.0377 ns |      - |       0 B |
                                    From_Enum_AsObject | 56.32 ns | 0.0835 ns | 0.0781 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.38 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 56.40 ns | 0.0627 ns | 0.0587 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 14.84 ns | 0.0177 ns | 0.0165 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.80 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                                      From_ParentClass | 15.03 ns | 0.0118 ns | 0.0104 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.44 ns | 0.0250 ns | 0.0221 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.14 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.69 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                                     From_ParentStruct | 14.51 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.52 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.94 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 20.47 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.73 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.80 ns | 0.0067 ns | 0.0052 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_String_Empty_AsObject: DefaultJob
