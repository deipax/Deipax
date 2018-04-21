
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.60 ns | 0.1145 ns | 0.1015 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.77 ns | 0.0532 ns | 0.0471 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.30 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.76 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.43 ns | 0.0191 ns | 0.0159 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.81 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                                             From_Byte | 13.02 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                                    From_Byte_AsObject | 23.83 ns | 0.0436 ns | 0.0408 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.82 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.76 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.68 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.23 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                                             From_Char | 13.02 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                                    From_Char_AsObject | 23.53 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.81 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 23.52 ns | 0.0182 ns | 0.0152 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.68 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.36 ns | 0.0195 ns | 0.0172 ns |      - |       0 B |
                                         From_DateTime | 13.43 ns | 0.0241 ns | 0.0201 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.31 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.32 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.22 ns | 0.0056 ns | 0.0044 ns |      - |       0 B |
                                          From_Decimal | 25.19 ns | 0.0389 ns | 0.0364 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.13 ns | 0.1971 ns | 0.1844 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 27.90 ns | 0.0272 ns | 0.0227 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 35.22 ns | 0.1715 ns | 0.1605 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.33 ns | 0.0350 ns | 0.0310 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.77 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                           From_Double | 17.11 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                  From_Double_AsObject | 26.62 ns | 0.0530 ns | 0.0495 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.17 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.65 ns | 0.0941 ns | 0.0786 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.32 ns | 0.0132 ns | 0.0110 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.17 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                                            From_Short | 13.51 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                                   From_Short_AsObject | 23.51 ns | 0.0187 ns | 0.0156 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.32 ns | 0.0394 ns | 0.0369 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 23.51 ns | 0.0120 ns | 0.0094 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.71 ns | 0.0238 ns | 0.0199 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.57 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                                              From_Int | 14.46 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                                     From_Int_AsObject | 24.32 ns | 0.0393 ns | 0.0348 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.62 ns | 0.0378 ns | 0.0353 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.29 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.44 ns | 0.0292 ns | 0.0244 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.20 ns | 0.0215 ns | 0.0191 ns |      - |       0 B |
                                             From_Long | 14.46 ns | 0.0381 ns | 0.0357 ns |      - |       0 B |
                                    From_Long_AsObject | 25.50 ns | 0.1096 ns | 0.1025 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.86 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 24.33 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.31 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.25 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                                            From_SByte | 13.49 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.22 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.44 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.65 ns | 0.0354 ns | 0.0276 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.70 ns | 0.0245 ns | 0.0217 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.25 ns | 0.0190 ns | 0.0169 ns |      - |       0 B |
                                            From_Float | 17.13 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
                                   From_Float_AsObject | 28.00 ns | 0.0522 ns | 0.0488 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.40 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 26.90 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.67 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.44 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                           From_String | 87.09 ns | 0.0821 ns | 0.0768 ns |      - |       0 B |
                                  From_String_AsObject | 94.12 ns | 0.0254 ns | 0.0212 ns |      - |       0 B |
                                      From_String_Null | 15.11 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.20 ns | 0.0320 ns | 0.0300 ns |      - |       0 B |
                                     From_String_Empty | 15.16 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.25 ns | 0.0135 ns | 0.0112 ns |      - |       0 B |
                                  From_UShort_AsObject | 16.70 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.83 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 17.52 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.49 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.39 ns | 0.0317 ns | 0.0297 ns |      - |       0 B |
                                             From_UInt | 13.68 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.55 ns | 0.0424 ns | 0.0396 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.50 ns | 0.0356 ns | 0.0333 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 23.52 ns | 0.0156 ns | 0.0139 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.71 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.23 ns | 0.0062 ns | 0.0049 ns |      - |       0 B |
                                            From_ULong | 14.10 ns | 0.0471 ns | 0.0418 ns |      - |       0 B |
                                   From_ULong_AsObject | 25.36 ns | 0.0570 ns | 0.0506 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.90 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.28 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.33 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.24 ns | 0.0334 ns | 0.0296 ns |      - |       0 B |
                                       From_NullObject | 16.24 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
                                           From_DBNull | 14.58 ns | 0.0429 ns | 0.0401 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.35 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.96 ns | 0.0337 ns | 0.0316 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.98 ns | 0.0379 ns | 0.0336 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.25 ns | 0.0161 ns | 0.0126 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.47 ns | 0.0219 ns | 0.0195 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.35 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.17 ns | 0.0383 ns | 0.0358 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.77 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.36 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.24 ns | 0.0150 ns | 0.0141 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.24 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.45 ns | 0.0197 ns | 0.0175 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.26 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.19 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.17 ns | 0.0095 ns | 0.0074 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.06 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.87 ns | 0.0129 ns | 0.0108 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.99 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.29 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.91 ns | 0.0188 ns | 0.0157 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.22 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                                             From_Enum | 14.46 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                                    From_Enum_AsObject | 54.78 ns | 0.0726 ns | 0.0679 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.59 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 54.65 ns | 0.0883 ns | 0.0783 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.41 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.20 ns | 0.0061 ns | 0.0047 ns |      - |       0 B |
                                      From_ParentClass | 14.31 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                             From_ParentClass_AsObject | 18.78 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.31 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.38 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                     From_ParentStruct | 14.86 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 18.68 ns | 0.0276 ns | 0.0259 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.91 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.72 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.93 ns | 0.0381 ns | 0.0356 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.44 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShort.From_String_Empty_AsObject: DefaultJob
