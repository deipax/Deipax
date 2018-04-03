
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.67 ns | 0.1715 ns | 0.1604 ns | 14.66 ns |      - |       0 B |
                                    From_Bool_AsObject | 31.80 ns | 0.0155 ns | 0.0130 ns | 31.80 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 12.82 ns | 0.0096 ns | 0.0085 ns | 12.81 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 29.23 ns | 0.0412 ns | 0.0365 ns | 29.24 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 12.67 ns | 0.0110 ns | 0.0103 ns | 12.66 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.37 ns | 0.0208 ns | 0.0194 ns | 17.37 ns |      - |       0 B |
                                             From_Byte | 14.57 ns | 0.0081 ns | 0.0068 ns | 14.56 ns |      - |       0 B |
                                    From_Byte_AsObject | 31.83 ns | 0.0546 ns | 0.0456 ns | 31.83 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 17.86 ns | 0.0417 ns | 0.0390 ns | 17.84 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 34.05 ns | 0.0895 ns | 0.0793 ns | 34.02 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.73 ns | 0.0041 ns | 0.0038 ns | 13.74 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.69 ns | 0.0347 ns | 0.0307 ns | 16.69 ns |      - |       0 B |
                                             From_Char |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                    From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 14.37 ns | 0.1580 ns | 0.1477 ns | 14.28 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.54 ns | 0.0256 ns | 0.0227 ns | 16.53 ns |      - |       0 B |
                                         From_DateTime | 13.95 ns | 0.0043 ns | 0.0036 ns | 13.95 ns |      - |       0 B |
                                From_DateTime_AsObject | 24.13 ns | 0.0510 ns | 0.0477 ns | 24.12 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue | 17.43 ns | 0.0047 ns | 0.0044 ns | 17.42 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject | 23.29 ns | 0.0225 ns | 0.0210 ns | 23.30 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue | 14.54 ns | 0.0316 ns | 0.0247 ns | 14.53 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.53 ns | 0.0201 ns | 0.0188 ns | 16.54 ns |      - |       0 B |
                                          From_Decimal | 24.73 ns | 0.0079 ns | 0.0070 ns | 24.73 ns |      - |       0 B |
                                 From_Decimal_AsObject | 42.62 ns | 0.0701 ns | 0.0622 ns | 42.64 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 30.75 ns | 0.0195 ns | 0.0182 ns | 30.75 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 44.63 ns | 0.0521 ns | 0.0406 ns | 44.61 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.79 ns | 0.0039 ns | 0.0033 ns | 14.79 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.53 ns | 0.0080 ns | 0.0071 ns | 16.53 ns |      - |       0 B |
                                           From_Double | 14.83 ns | 0.0234 ns | 0.0195 ns | 14.83 ns |      - |       0 B |
                                  From_Double_AsObject | 37.78 ns | 0.0172 ns | 0.0144 ns | 37.77 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 18.75 ns | 0.0050 ns | 0.0039 ns | 18.75 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 31.55 ns | 0.0633 ns | 0.0494 ns | 31.54 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.87 ns | 0.0423 ns | 0.0375 ns | 14.87 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.62 ns | 0.0350 ns | 0.0327 ns | 16.61 ns |      - |       0 B |
                                            From_Short | 14.00 ns | 0.0035 ns | 0.0031 ns | 14.00 ns |      - |       0 B |
                                   From_Short_AsObject | 31.26 ns | 0.0208 ns | 0.0174 ns | 31.25 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 18.10 ns | 0.0187 ns | 0.0146 ns | 18.10 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 33.44 ns | 0.0211 ns | 0.0176 ns | 33.44 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.30 ns | 0.0044 ns | 0.0034 ns | 14.30 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.52 ns | 0.0148 ns | 0.0124 ns | 16.51 ns |      - |       0 B |
                                              From_Int | 14.06 ns | 0.1482 ns | 0.1386 ns | 14.15 ns |      - |       0 B |
                                     From_Int_AsObject | 31.26 ns | 0.0138 ns | 0.0122 ns | 31.25 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 17.06 ns | 0.0222 ns | 0.0208 ns | 17.07 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 31.26 ns | 0.0408 ns | 0.0362 ns | 31.25 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.75 ns | 0.0149 ns | 0.0124 ns | 13.74 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.73 ns | 0.0042 ns | 0.0033 ns | 18.73 ns |      - |       0 B |
                                             From_Long | 14.25 ns | 0.0190 ns | 0.0159 ns | 14.25 ns |      - |       0 B |
                                    From_Long_AsObject | 33.43 ns | 0.0137 ns | 0.0114 ns | 33.43 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 19.44 ns | 0.0242 ns | 0.0215 ns | 19.44 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 33.44 ns | 0.0363 ns | 0.0303 ns | 33.43 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.41 ns | 0.0160 ns | 0.0142 ns | 15.41 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.81 ns | 0.0095 ns | 0.0080 ns | 17.81 ns |      - |       0 B |
                                            From_SByte | 14.00 ns | 0.0205 ns | 0.0171 ns | 13.99 ns |      - |       0 B |
                                   From_SByte_AsObject | 33.47 ns | 0.0219 ns | 0.0194 ns | 33.46 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 17.88 ns | 0.0156 ns | 0.0138 ns | 17.88 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 31.46 ns | 0.3574 ns | 0.3343 ns | 31.27 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.05 ns | 0.0298 ns | 0.0264 ns | 14.05 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.58 ns | 0.0027 ns | 0.0024 ns | 16.58 ns |      - |       0 B |
                                            From_Float | 13.96 ns | 0.0188 ns | 0.0166 ns | 13.96 ns |      - |       0 B |
                                   From_Float_AsObject | 31.29 ns | 0.0602 ns | 0.0503 ns | 31.26 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.28 ns | 0.0019 ns | 0.0015 ns | 18.28 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 33.53 ns | 0.0595 ns | 0.0528 ns | 33.51 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.87 ns | 0.0408 ns | 0.0318 ns | 13.87 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.56 ns | 0.0237 ns | 0.0221 ns | 16.55 ns |      - |       0 B |
                                           From_String | 38.90 ns | 0.0207 ns | 0.0173 ns | 38.90 ns |      - |       0 B |
                                  From_String_AsObject | 50.70 ns | 0.0594 ns | 0.0496 ns | 50.69 ns |      - |       0 B |
                                      From_String_Null | 16.56 ns | 0.0104 ns | 0.0093 ns | 16.56 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.65 ns | 0.0228 ns | 0.0202 ns | 16.64 ns |      - |       0 B |
                                     From_String_Empty | 21.26 ns | 0.0117 ns | 0.0091 ns | 21.26 ns |      - |       0 B |
                            From_String_Empty_AsObject | 23.98 ns | 0.0166 ns | 0.0130 ns | 23.98 ns |      - |       0 B |
                                           From_UShort | 13.99 ns | 0.0078 ns | 0.0056 ns | 13.99 ns |      - |       0 B |
                                  From_UShort_AsObject | 33.45 ns | 0.0414 ns | 0.0346 ns | 33.43 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 21.14 ns | 0.0129 ns | 0.0093 ns | 21.14 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 33.45 ns | 0.0280 ns | 0.0248 ns | 33.44 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.59 ns | 0.0317 ns | 0.0297 ns | 14.59 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.82 ns | 0.0054 ns | 0.0042 ns | 17.82 ns |      - |       0 B |
                                             From_UInt | 13.71 ns | 0.0292 ns | 0.0258 ns | 13.70 ns |      - |       0 B |
                                    From_UInt_AsObject | 31.28 ns | 0.0429 ns | 0.0335 ns | 31.26 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.12 ns | 0.0303 ns | 0.0283 ns | 17.11 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 31.26 ns | 0.0268 ns | 0.0224 ns | 31.25 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.98 ns | 0.0103 ns | 0.0086 ns | 14.98 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 19.72 ns | 0.0092 ns | 0.0077 ns | 19.71 ns |      - |       0 B |
                                            From_ULong | 13.67 ns | 0.0243 ns | 0.0215 ns | 13.66 ns |      - |       0 B |
                                   From_ULong_AsObject | 33.45 ns | 0.0201 ns | 0.0178 ns | 33.45 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 18.07 ns | 0.0289 ns | 0.0241 ns | 18.07 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 33.51 ns | 0.0059 ns | 0.0052 ns | 33.51 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.27 ns | 0.0275 ns | 0.0215 ns | 15.26 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.81 ns | 0.0037 ns | 0.0029 ns | 17.81 ns |      - |       0 B |
                                       From_NullObject | 16.56 ns | 0.0251 ns | 0.0235 ns | 16.56 ns |      - |       0 B |
                                           From_DBNull | 15.29 ns | 0.0038 ns | 0.0034 ns | 15.29 ns |      - |       0 B |
                                 From_ConvertibleClass | 25.53 ns | 0.0308 ns | 0.0273 ns | 25.52 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 29.35 ns | 0.0861 ns | 0.0764 ns | 29.37 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.45 ns | 0.3939 ns | 0.5523 ns | 18.09 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.56 ns | 0.0030 ns | 0.0027 ns | 16.56 ns |      - |       0 B |
                              From_NonConvertibleClass | 21.96 ns | 0.0267 ns | 0.0250 ns | 21.95 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 25.75 ns | 0.0270 ns | 0.0252 ns | 25.77 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 17.49 ns | 0.0039 ns | 0.0035 ns | 17.49 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.24 ns | 0.0070 ns | 0.0055 ns | 17.25 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.02 ns | 0.0084 ns | 0.0065 ns | 23.02 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 30.22 ns | 0.0324 ns | 0.0303 ns | 30.22 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.10 ns | 0.0208 ns | 0.0185 ns | 26.09 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 30.56 ns | 0.3060 ns | 0.2862 ns | 30.72 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 13.74 ns | 0.0030 ns | 0.0023 ns | 13.74 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.57 ns | 0.0052 ns | 0.0041 ns | 16.57 ns |      - |       0 B |
                             From_NonConvertibleStruct | 13.32 ns | 0.0055 ns | 0.0046 ns | 13.32 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 25.38 ns | 0.0262 ns | 0.0219 ns | 25.39 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 18.43 ns | 0.0030 ns | 0.0025 ns | 18.43 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 26.35 ns | 0.0344 ns | 0.0305 ns | 26.34 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.74 ns | 0.0047 ns | 0.0037 ns | 13.74 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 19.65 ns | 0.0191 ns | 0.0179 ns | 19.65 ns |      - |       0 B |
                                             From_Enum | 13.91 ns | 0.0044 ns | 0.0037 ns | 13.91 ns |      - |       0 B |
                                    From_Enum_AsObject | 64.70 ns | 0.1461 ns | 0.1366 ns | 64.65 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 17.84 ns | 0.0254 ns | 0.0212 ns | 17.83 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 64.17 ns | 0.1158 ns | 0.1026 ns | 64.13 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 13.74 ns | 0.0084 ns | 0.0074 ns | 13.74 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 19.67 ns | 0.0397 ns | 0.0372 ns | 19.65 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char: DefaultJob
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
