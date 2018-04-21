
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.89 ns | 0.0964 ns | 0.0854 ns |      - |       0 B |
                                    From_Bool_AsObject | 24.74 ns | 0.0377 ns | 0.0352 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.24 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 25.71 ns | 0.0206 ns | 0.0172 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.52 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 20.34 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
                                             From_Byte | 13.77 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                                    From_Byte_AsObject | 24.79 ns | 0.0529 ns | 0.0494 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.02 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.76 ns | 0.0772 ns | 0.0722 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.87 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.76 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                                             From_Char | 13.72 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                                    From_Char_AsObject | 25.56 ns | 0.0655 ns | 0.0612 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.99 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 25.55 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.82 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.98 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                         From_DateTime | 14.09 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.55 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.56 ns | 0.0167 ns | 0.0140 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 18.57 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                                          From_Decimal | 27.19 ns | 0.0459 ns | 0.0429 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.93 ns | 0.3959 ns | 0.3703 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 29.26 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 35.97 ns | 0.0559 ns | 0.0496 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.76 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.68 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                           From_Double | 16.86 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                  From_Double_AsObject | 26.57 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.65 ns | 0.0105 ns | 0.0087 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.62 ns | 0.0526 ns | 0.0492 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.92 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.45 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
                                            From_Short | 13.74 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                   From_Short_AsObject | 24.81 ns | 0.0539 ns | 0.0504 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.26 ns | 0.0027 ns | 0.0018 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.85 ns | 0.0595 ns | 0.0557 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.80 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.88 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                              From_Int | 13.85 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                     From_Int_AsObject | 29.69 ns | 0.0699 ns | 0.0654 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 13.41 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 28.51 ns | 0.0446 ns | 0.0417 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.41 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.59 ns | 0.0179 ns | 0.0149 ns |      - |       0 B |
                                             From_Long | 15.34 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                                    From_Long_AsObject | 26.83 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.94 ns | 0.0448 ns | 0.0420 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.94 ns | 0.0380 ns | 0.0356 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.84 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.41 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                                            From_SByte | 13.88 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.77 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.05 ns | 0.0329 ns | 0.0308 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.13 ns | 0.0139 ns | 0.0109 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.84 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 18.78 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                                            From_Float | 16.35 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
                                   From_Float_AsObject | 26.83 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.60 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 26.81 ns | 0.0099 ns | 0.0078 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.93 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.70 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                                           From_String | 88.06 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
                                  From_String_AsObject | 96.41 ns | 0.0733 ns | 0.0650 ns |      - |       0 B |
                                      From_String_Null | 15.65 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.88 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                                     From_String_Empty | 15.60 ns | 0.0056 ns | 0.0044 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.06 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.71 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.04 ns | 0.0348 ns | 0.0325 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.71 ns | 0.0188 ns | 0.0175 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.96 ns | 0.0350 ns | 0.0310 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.71 ns | 0.0124 ns | 0.0097 ns |      - |       0 B |
                                             From_UInt | 14.00 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                                    From_UInt_AsObject | 26.26 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.47 ns | 0.0480 ns | 0.0401 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.22 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 15.50 ns | 0.0211 ns | 0.0198 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.76 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                                            From_ULong | 14.84 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.22 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.85 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.15 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.70 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.77 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                       From_NullObject | 16.72 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
                                           From_DBNull | 14.94 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.71 ns | 0.0380 ns | 0.0355 ns |      - |       0 B |
                                 From_ConvertibleClass | 21.28 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.23 ns | 0.0101 ns | 0.0084 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.81 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.26 ns | 0.0070 ns | 0.0058 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.99 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.17 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.95 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 22.38 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.58 ns | 0.0118 ns | 0.0105 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 24.55 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.66 ns | 0.0123 ns | 0.0109 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.54 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.55 ns | 0.0107 ns | 0.0094 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.93 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.60 ns | 0.0108 ns | 0.0091 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.30 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.61 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.91 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 16.19 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.69 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
                                             From_Enum | 13.75 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                    From_Enum_AsObject | 56.14 ns | 0.0635 ns | 0.0594 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 16.05 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 55.92 ns | 0.0853 ns | 0.0798 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 14.58 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.13 ns | 0.0287 ns | 0.0268 ns |      - |       0 B |
                                      From_ParentClass | 15.23 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.68 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
                              From_ParentClass_NoValue | 16.22 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.80 ns | 0.0112 ns | 0.0094 ns |      - |       0 B |
                                     From_ParentStruct | 15.62 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.77 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 15.21 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.76 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.59 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.73 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_String_Empty_AsObject: DefaultJob
