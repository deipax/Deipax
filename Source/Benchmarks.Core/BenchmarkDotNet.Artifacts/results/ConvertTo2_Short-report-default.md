
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.60 ns | 0.0726 ns | 0.0644 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.77 ns | 0.0458 ns | 0.0382 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.69 ns | 0.0109 ns | 0.0079 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.79 ns | 0.0659 ns | 0.0616 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.50 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.25 ns | 0.0354 ns | 0.0314 ns |      - |       0 B |
                                             From_Byte | 13.94 ns | 0.0076 ns | 0.0059 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.75 ns | 0.0132 ns | 0.0110 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.87 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.78 ns | 0.0366 ns | 0.0343 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.70 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.25 ns | 0.0294 ns | 0.0245 ns |      - |       0 B |
                                             From_Char | 13.52 ns | 0.0363 ns | 0.0339 ns |      - |       0 B |
                                    From_Char_AsObject | 24.06 ns | 0.0562 ns | 0.0525 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.30 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 25.11 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.77 ns | 0.0242 ns | 0.0189 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.03 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                                         From_DateTime | 13.48 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 15.39 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.37 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.04 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
                                          From_Decimal | 25.17 ns | 0.2575 ns | 0.2408 ns |      - |       0 B |
                                 From_Decimal_AsObject | 33.89 ns | 0.0523 ns | 0.0408 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 28.26 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 33.82 ns | 0.0756 ns | 0.0670 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.09 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.30 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                                           From_Double | 17.14 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                                  From_Double_AsObject | 26.61 ns | 0.0445 ns | 0.0394 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.19 ns | 0.0479 ns | 0.0448 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 27.63 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.33 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.04 ns | 0.0242 ns | 0.0227 ns |      - |       0 B |
                                            From_Short | 13.06 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                                   From_Short_AsObject | 17.85 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 13.83 ns | 0.0165 ns | 0.0129 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 16.68 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.74 ns | 0.0362 ns | 0.0320 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.21 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                                              From_Int | 14.47 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                                     From_Int_AsObject | 25.35 ns | 0.0451 ns | 0.0400 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.66 ns | 0.0556 ns | 0.0521 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.28 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.45 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.40 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                                             From_Long | 14.36 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                                    From_Long_AsObject | 24.30 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.90 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 25.35 ns | 0.0597 ns | 0.0559 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.14 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.83 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                                            From_SByte | 13.03 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.00 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.92 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.01 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.71 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 20.73 ns | 0.0303 ns | 0.0283 ns |      - |       0 B |
                                            From_Float | 17.53 ns | 0.0413 ns | 0.0367 ns |      - |       0 B |
                                   From_Float_AsObject | 26.87 ns | 0.0562 ns | 0.0525 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.44 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 26.89 ns | 0.0653 ns | 0.0611 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.75 ns | 0.0347 ns | 0.0324 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.81 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
                                           From_String | 88.74 ns | 0.0485 ns | 0.0405 ns |      - |       0 B |
                                  From_String_AsObject | 95.42 ns | 0.1303 ns | 0.1219 ns |      - |       0 B |
                                      From_String_Null | 15.09 ns | 0.0096 ns | 0.0081 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.02 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                                     From_String_Empty | 15.40 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.68 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.52 ns | 0.0307 ns | 0.0272 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.51 ns | 0.0466 ns | 0.0435 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.56 ns | 0.0636 ns | 0.0595 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.48 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.22 ns | 0.0330 ns | 0.0309 ns |      - |       0 B |
                                             From_UInt | 14.09 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                                    From_UInt_AsObject | 24.28 ns | 0.0063 ns | 0.0050 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.62 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 24.29 ns | 0.0250 ns | 0.0222 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.68 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.24 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                                            From_ULong | 14.04 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                                   From_ULong_AsObject | 24.38 ns | 0.0417 ns | 0.0369 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.86 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.33 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.31 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 19.58 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                       From_NullObject | 17.29 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                                           From_DBNull | 14.58 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.04 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.03 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.95 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.45 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.25 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.36 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.18 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.33 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.14 ns | 0.0199 ns | 0.0176 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.25 ns | 0.0152 ns | 0.0135 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.25 ns | 0.0456 ns | 0.0426 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.46 ns | 0.0148 ns | 0.0139 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.24 ns | 0.0551 ns | 0.0516 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.24 ns | 0.0446 ns | 0.0418 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.14 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.08 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.21 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.98 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.15 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.94 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.04 ns | 0.0386 ns | 0.0361 ns |      - |       0 B |
                                             From_Enum | 14.53 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
                                    From_Enum_AsObject | 54.24 ns | 0.0712 ns | 0.0666 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.63 ns | 0.0384 ns | 0.0300 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 54.34 ns | 0.0633 ns | 0.0592 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 14.62 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.21 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                      From_ParentClass | 16.36 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                             From_ParentClass_AsObject | 20.56 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.94 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.09 ns | 0.0322 ns | 0.0302 ns |      - |       0 B |
                                     From_ParentStruct | 14.04 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 18.69 ns | 0.0173 ns | 0.0144 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.90 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.75 ns | 0.0346 ns | 0.0323 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.92 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.06 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Short.From_String_Empty_AsObject: DefaultJob
