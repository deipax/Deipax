
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.73 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.30 ns | 0.0507 ns | 0.0423 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  18.77 ns | 0.1346 ns | 0.1124 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.30 ns | 0.0580 ns | 0.0514 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.54 ns | 0.3277 ns | 0.3218 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.61 ns | 0.0228 ns | 0.0203 ns |      - |       0 B |
                                             From_Byte |  14.93 ns | 0.0185 ns | 0.0145 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.28 ns | 0.0259 ns | 0.0216 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.65 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.43 ns | 0.2170 ns | 0.1923 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.04 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.87 ns | 0.0270 ns | 0.0225 ns |      - |       0 B |
                                             From_Char |  14.68 ns | 0.0136 ns | 0.0114 ns |      - |       0 B |
                                    From_Char_AsObject |  29.20 ns | 0.1910 ns | 0.1786 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.65 ns | 0.0632 ns | 0.0493 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.10 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  16.40 ns | 0.1497 ns | 0.1327 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.92 ns | 0.2110 ns | 0.1762 ns |      - |       0 B |
                                         From_DateTime |  15.10 ns | 0.1980 ns | 0.1653 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.07 ns | 0.0846 ns | 0.0707 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.42 ns | 0.1362 ns | 0.1208 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.27 ns | 0.2384 ns | 0.2113 ns |      - |       0 B |
                                          From_Decimal |  29.07 ns | 0.1098 ns | 0.1027 ns |      - |       0 B |
                                 From_Decimal_AsObject |  41.00 ns | 1.0833 ns | 0.9046 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  38.43 ns | 0.0892 ns | 0.0745 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.48 ns | 0.4629 ns | 0.4330 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.50 ns | 0.3485 ns | 0.3260 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.01 ns | 0.0886 ns | 0.0829 ns |      - |       0 B |
                                           From_Double |  19.19 ns | 0.0383 ns | 0.0299 ns |      - |       0 B |
                                  From_Double_AsObject |  32.55 ns | 0.1005 ns | 0.0784 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.86 ns | 0.1980 ns | 0.1852 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.55 ns | 0.1462 ns | 0.1296 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.25 ns | 0.0824 ns | 0.0688 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.02 ns | 0.1348 ns | 0.1195 ns |      - |       0 B |
                                            From_Short |  17.55 ns | 0.0475 ns | 0.0396 ns |      - |       0 B |
                                   From_Short_AsObject |  28.96 ns | 0.0556 ns | 0.0493 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  19.14 ns | 0.1427 ns | 0.1192 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.22 ns | 0.5192 ns | 0.4602 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.09 ns | 0.0147 ns | 0.0114 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.41 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
                                              From_Int |  16.00 ns | 0.0131 ns | 0.0102 ns |      - |       0 B |
                                     From_Int_AsObject |  29.65 ns | 0.0560 ns | 0.0524 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.90 ns | 0.0595 ns | 0.0556 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.65 ns | 0.0519 ns | 0.0486 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.03 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.92 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
                                             From_Long |  16.03 ns | 0.0292 ns | 0.0243 ns |      - |       0 B |
                                    From_Long_AsObject |  29.65 ns | 0.0605 ns | 0.0566 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  21.42 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.62 ns | 0.0312 ns | 0.0276 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.24 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.87 ns | 0.0313 ns | 0.0262 ns |      - |       0 B |
                                            From_SByte |  14.95 ns | 0.0203 ns | 0.0158 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.98 ns | 0.0346 ns | 0.0270 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  19.00 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.88 ns | 0.0250 ns | 0.0222 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.05 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.55 ns | 0.0290 ns | 0.0242 ns |      - |       0 B |
                                            From_Float |  19.64 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                                   From_Float_AsObject |  32.39 ns | 0.0257 ns | 0.0201 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.59 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.44 ns | 0.1212 ns | 0.1134 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.32 ns | 0.0205 ns | 0.0191 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.55 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                           From_String |  92.03 ns | 0.0799 ns | 0.0748 ns |      - |       0 B |
                                  From_String_AsObject | 105.37 ns | 0.0534 ns | 0.0446 ns |      - |       0 B |
                                      From_String_Null |  16.60 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.89 ns | 0.0089 ns | 0.0064 ns |      - |       0 B |
                                     From_String_Empty |  16.76 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  15.67 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                  From_UShort_AsObject |  29.48 ns | 0.0237 ns | 0.0185 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  13.90 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  29.82 ns | 0.0434 ns | 0.0362 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.17 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.88 ns | 0.0090 ns | 0.0065 ns |      - |       0 B |
                                             From_UInt |  15.22 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.88 ns | 0.0101 ns | 0.0078 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  18.89 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.97 ns | 0.0556 ns | 0.0493 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.19 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.93 ns | 0.0118 ns | 0.0092 ns |      - |       0 B |
                                            From_ULong |  16.68 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.72 ns | 0.0962 ns | 0.0900 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  20.02 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.69 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.26 ns | 0.0269 ns | 0.0251 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.95 ns | 0.0363 ns | 0.0283 ns |      - |       0 B |
                                       From_NullObject |  17.85 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                           From_DBNull |  16.67 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.30 ns | 0.0869 ns | 0.0813 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.52 ns | 0.0333 ns | 0.0278 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.89 ns | 0.0390 ns | 0.0346 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.43 ns | 0.0406 ns | 0.0380 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.05 ns | 0.0518 ns | 0.0485 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.51 ns | 0.0297 ns | 0.0232 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.99 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.63 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.79 ns | 0.0568 ns | 0.0503 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.46 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.95 ns | 0.0062 ns | 0.0048 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.43 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.11 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  22.21 ns | 0.0285 ns | 0.0253 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.49 ns | 0.0109 ns | 0.0079 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.12 ns | 0.0179 ns | 0.0158 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.71 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.18 ns | 0.0398 ns | 0.0353 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.75 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.47 ns | 0.0250 ns | 0.0208 ns |      - |       0 B |
                                             From_Enum |  15.98 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.49 ns | 0.1319 ns | 0.1234 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.98 ns | 0.0656 ns | 0.0613 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  62.41 ns | 0.0281 ns | 0.0234 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.04 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.86 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                                      From_ParentClass |  17.05 ns | 0.0422 ns | 0.0374 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.68 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                              From_ParentClass_NoValue |  27.96 ns | 0.0086 ns | 0.0077 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.72 ns | 0.0252 ns | 0.0224 ns |      - |       0 B |
                                     From_ParentStruct |  14.54 ns | 0.0179 ns | 0.0130 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.69 ns | 0.0461 ns | 0.0385 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.28 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.69 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.75 ns | 0.0278 ns | 0.0247 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.64 ns | 0.0353 ns | 0.0313 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_String_Empty_AsObject: DefaultJob
