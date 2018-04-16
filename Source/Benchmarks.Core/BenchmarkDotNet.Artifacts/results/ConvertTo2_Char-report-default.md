
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.50 ns | 0.0707 ns | 0.0661 ns | 14.49 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 14.18 ns | 0.0530 ns | 0.0470 ns | 14.17 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 14.54 ns | 0.0197 ns | 0.0154 ns | 14.54 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.34 ns | 0.0086 ns | 0.0076 ns | 17.34 ns |      - |       0 B |
                                             From_Byte | 14.66 ns | 0.8078 ns | 0.8295 ns | 14.27 ns |      - |       0 B |
                                    From_Byte_AsObject | 25.92 ns | 0.3543 ns | 0.3314 ns | 25.77 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 17.09 ns | 0.2041 ns | 0.1909 ns | 17.03 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.72 ns | 0.1715 ns | 0.1432 ns | 25.66 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.01 ns | 0.0939 ns | 0.0878 ns | 14.96 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.36 ns | 0.0177 ns | 0.0148 ns | 17.37 ns |      - |       0 B |
                                             From_Char | 14.27 ns | 0.1109 ns | 0.0984 ns | 14.23 ns |      - |       0 B |
                                    From_Char_AsObject | 17.84 ns | 0.0263 ns | 0.0205 ns | 17.84 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.57 ns | 0.1013 ns | 0.0846 ns | 14.56 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 17.93 ns | 0.1409 ns | 0.1318 ns | 17.94 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.44 ns | 0.0218 ns | 0.0182 ns | 14.44 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.02 ns | 0.0585 ns | 0.0488 ns | 18.03 ns |      - |       0 B |
                                         From_DateTime | 14.64 ns | 0.0213 ns | 0.0188 ns | 14.64 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.85 ns | 0.0671 ns | 0.0560 ns | 14.83 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.84 ns | 0.0157 ns | 0.0147 ns | 14.85 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.50 ns | 0.1508 ns | 0.1410 ns | 17.49 ns |      - |       0 B |
                                          From_Decimal | 14.84 ns | 0.0289 ns | 0.0270 ns | 14.84 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 15.13 ns | 0.0590 ns | 0.0493 ns | 15.11 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 16.47 ns | 0.0238 ns | 0.0222 ns | 16.47 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.94 ns | 0.1467 ns | 0.1301 ns | 17.91 ns |      - |       0 B |
                                           From_Double | 13.89 ns | 0.0691 ns | 0.0612 ns | 13.86 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 14.92 ns | 0.0942 ns | 0.0835 ns | 14.90 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 15.36 ns | 0.0773 ns | 0.0645 ns | 15.35 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.38 ns | 0.0489 ns | 0.0457 ns | 17.37 ns |      - |       0 B |
                                            From_Short | 14.41 ns | 0.0383 ns | 0.0358 ns | 14.40 ns |      - |       0 B |
                                   From_Short_AsObject | 26.28 ns | 0.0197 ns | 0.0154 ns | 26.28 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.02 ns | 0.0216 ns | 0.0191 ns | 17.02 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.20 ns | 0.0175 ns | 0.0155 ns | 26.19 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.26 ns | 0.0178 ns | 0.0158 ns | 15.26 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.11 ns | 0.0650 ns | 0.0576 ns | 18.13 ns |      - |       0 B |
                                              From_Int | 15.48 ns | 0.0193 ns | 0.0171 ns | 15.47 ns |      - |       0 B |
                                     From_Int_AsObject | 26.99 ns | 0.0196 ns | 0.0153 ns | 26.99 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 18.70 ns | 0.0239 ns | 0.0223 ns | 18.69 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 27.14 ns | 0.0823 ns | 0.0770 ns | 27.16 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.68 ns | 0.0168 ns | 0.0157 ns | 14.68 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.62 ns | 0.4967 ns | 1.3928 ns | 17.98 ns |      - |       0 B |
                                             From_Long | 15.46 ns | 0.0091 ns | 0.0085 ns | 15.45 ns |      - |       0 B |
                                    From_Long_AsObject | 26.91 ns | 0.0068 ns | 0.0057 ns | 26.91 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 19.38 ns | 0.0284 ns | 0.0252 ns | 19.37 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.92 ns | 0.0268 ns | 0.0238 ns | 26.91 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.88 ns | 0.0101 ns | 0.0090 ns | 15.88 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.34 ns | 0.0151 ns | 0.0134 ns | 17.34 ns |      - |       0 B |
                                            From_SByte | 14.38 ns | 0.0026 ns | 0.0021 ns | 14.38 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.12 ns | 0.0117 ns | 0.0110 ns | 26.12 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 17.15 ns | 0.0021 ns | 0.0016 ns | 17.15 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.28 ns | 0.0107 ns | 0.0100 ns | 26.27 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 20.47 ns | 0.0258 ns | 0.0202 ns | 20.46 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.54 ns | 0.1606 ns | 0.1502 ns | 17.49 ns |      - |       0 B |
                                            From_Float | 15.41 ns | 0.2310 ns | 0.2160 ns | 15.42 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 14.20 ns | 0.3332 ns | 0.2953 ns | 14.04 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.19 ns | 0.0472 ns | 0.0394 ns | 14.17 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.48 ns | 0.3026 ns | 0.2527 ns | 17.38 ns |      - |       0 B |
                                           From_String | 16.95 ns | 0.1558 ns | 0.1382 ns | 16.88 ns |      - |       0 B |
                                  From_String_AsObject | 25.74 ns | 0.3187 ns | 0.2662 ns | 25.71 ns |      - |       0 B |
                                      From_String_Null | 15.47 ns | 0.0068 ns | 0.0057 ns | 15.47 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.36 ns | 0.0058 ns | 0.0049 ns | 17.36 ns |      - |       0 B |
                                     From_String_Empty | 15.78 ns | 0.0131 ns | 0.0116 ns | 15.77 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.43 ns | 0.0953 ns | 0.0796 ns | 14.39 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.64 ns | 0.0130 ns | 0.0102 ns | 25.65 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 16.83 ns | 0.0109 ns | 0.0102 ns | 16.83 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.73 ns | 0.0208 ns | 0.0163 ns | 25.73 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.68 ns | 0.0020 ns | 0.0014 ns | 14.68 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.38 ns | 0.0286 ns | 0.0268 ns | 17.39 ns |      - |       0 B |
                                             From_UInt | 14.69 ns | 0.0424 ns | 0.0397 ns | 14.67 ns |      - |       0 B |
                                    From_UInt_AsObject | 26.20 ns | 0.0975 ns | 0.0912 ns | 26.22 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.17 ns | 0.0208 ns | 0.0194 ns | 17.17 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 26.18 ns | 0.0178 ns | 0.0149 ns | 26.18 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.95 ns | 0.0162 ns | 0.0151 ns | 14.95 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.42 ns | 0.0295 ns | 0.0276 ns | 17.44 ns |      - |       0 B |
                                            From_ULong | 14.93 ns | 0.0160 ns | 0.0142 ns | 14.94 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.78 ns | 0.0567 ns | 0.0531 ns | 26.81 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 19.12 ns | 0.0267 ns | 0.0250 ns | 19.13 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.72 ns | 0.0186 ns | 0.0164 ns | 26.72 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.88 ns | 0.0151 ns | 0.0141 ns | 15.88 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 20.52 ns | 0.0505 ns | 0.0472 ns | 20.54 ns |      - |       0 B |
                                       From_NullObject | 18.01 ns | 0.0213 ns | 0.0189 ns | 18.01 ns |      - |       0 B |
                                           From_DBNull | 15.10 ns | 0.0084 ns | 0.0074 ns | 15.11 ns |      - |       0 B |
                                 From_ConvertibleClass | 23.96 ns | 0.0270 ns | 0.0253 ns | 23.96 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 23.50 ns | 0.0760 ns | 0.0711 ns | 23.54 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.88 ns | 0.0136 ns | 0.0114 ns | 18.88 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.93 ns | 0.0306 ns | 0.0286 ns | 18.94 ns |      - |       0 B |
                              From_NonConvertibleClass | 17.95 ns | 0.0139 ns | 0.0130 ns | 17.95 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 21.68 ns | 0.0773 ns | 0.0685 ns | 21.70 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.78 ns | 0.0077 ns | 0.0065 ns | 16.78 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.36 ns | 0.0227 ns | 0.0201 ns | 17.35 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.92 ns | 0.0825 ns | 0.0732 ns | 23.95 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 24.82 ns | 0.0147 ns | 0.0130 ns | 24.82 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.92 ns | 0.0083 ns | 0.0078 ns | 26.92 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.77 ns | 0.0190 ns | 0.0169 ns | 24.77 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 15.04 ns | 0.0349 ns | 0.0310 ns | 15.05 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.92 ns | 0.0146 ns | 0.0130 ns | 17.91 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.19 ns | 0.0052 ns | 0.0041 ns | 14.19 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 21.64 ns | 0.0188 ns | 0.0176 ns | 21.64 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.94 ns | 0.0482 ns | 0.0451 ns | 13.96 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.60 ns | 0.0225 ns | 0.0210 ns | 21.60 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.91 ns | 0.0235 ns | 0.0220 ns | 13.91 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.34 ns | 0.0125 ns | 0.0110 ns | 17.35 ns |      - |       0 B |
                                             From_Enum | 15.51 ns | 0.0481 ns | 0.0449 ns | 15.50 ns |      - |       0 B |
                                    From_Enum_AsObject | 60.02 ns | 0.0244 ns | 0.0216 ns | 60.02 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 19.09 ns | 0.0036 ns | 0.0030 ns | 19.08 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 60.03 ns | 0.0201 ns | 0.0168 ns | 60.02 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.66 ns | 0.0026 ns | 0.0020 ns | 14.66 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.53 ns | 0.0068 ns | 0.0056 ns | 17.53 ns |      - |       0 B |
                                      From_ParentClass | 15.83 ns | 0.0035 ns | 0.0033 ns | 15.83 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.23 ns | 0.0018 ns | 0.0016 ns | 22.23 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.82 ns | 0.0061 ns | 0.0054 ns | 15.82 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.82 ns | 0.0023 ns | 0.0020 ns | 17.82 ns |      - |       0 B |
                                     From_ParentStruct | 14.14 ns | 0.0020 ns | 0.0019 ns | 14.14 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 23.04 ns | 0.0024 ns | 0.0019 ns | 23.04 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.87 ns | 0.0018 ns | 0.0014 ns | 13.87 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.20 ns | 0.0364 ns | 0.0341 ns | 22.18 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.87 ns | 0.0021 ns | 0.0019 ns | 13.87 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.33 ns | 0.0104 ns | 0.0087 ns | 17.32 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Char.From_Bool_AsObject: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_String_Empty_AsObject: DefaultJob
