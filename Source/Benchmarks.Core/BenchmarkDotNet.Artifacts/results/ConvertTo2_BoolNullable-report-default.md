
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.49 ns | 0.0520 ns | 0.0486 ns | 14.48 ns |      - |       0 B |
                                    From_Bool_AsObject | 29.64 ns | 0.0568 ns | 0.0474 ns | 29.65 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 13.88 ns | 0.0286 ns | 0.0253 ns | 13.87 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 29.81 ns | 0.0343 ns | 0.0304 ns | 29.80 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.21 ns | 0.0339 ns | 0.0317 ns | 14.21 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 19.85 ns | 0.0231 ns | 0.0216 ns | 19.84 ns |      - |       0 B |
                                             From_Byte | 15.73 ns | 0.0656 ns | 0.0614 ns | 15.75 ns |      - |       0 B |
                                    From_Byte_AsObject | 28.58 ns | 0.0351 ns | 0.0293 ns | 28.58 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 18.10 ns | 0.0115 ns | 0.0096 ns | 18.10 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 28.63 ns | 0.0893 ns | 0.0792 ns | 28.61 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.23 ns | 0.0438 ns | 0.0410 ns | 15.24 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.84 ns | 0.0213 ns | 0.0189 ns | 17.84 ns |      - |       0 B |
                                             From_Char | 14.72 ns | 0.0156 ns | 0.0146 ns | 14.72 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 14.72 ns | 0.0634 ns | 0.0593 ns | 14.73 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 15.31 ns | 0.0168 ns | 0.0158 ns | 15.31 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.47 ns | 0.0222 ns | 0.0197 ns | 18.47 ns |      - |       0 B |
                                         From_DateTime | 15.65 ns | 0.0660 ns | 0.0552 ns | 15.66 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 16.16 ns | 0.0225 ns | 0.0210 ns | 16.15 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.04 ns | 0.0463 ns | 0.0433 ns | 15.05 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.87 ns | 0.0204 ns | 0.0191 ns | 17.86 ns |      - |       0 B |
                                          From_Decimal | 24.78 ns | 0.0353 ns | 0.0330 ns | 24.77 ns |      - |       0 B |
                                 From_Decimal_AsObject | 38.53 ns | 0.0414 ns | 0.0367 ns | 38.53 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 29.16 ns | 0.1010 ns | 0.0895 ns | 29.17 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 38.53 ns | 0.0542 ns | 0.0453 ns | 38.52 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.96 ns | 0.0237 ns | 0.0210 ns | 15.95 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.36 ns | 0.0181 ns | 0.0160 ns | 18.36 ns |      - |       0 B |
                                           From_Double | 15.03 ns | 0.0383 ns | 0.0320 ns | 15.04 ns |      - |       0 B |
                                  From_Double_AsObject | 28.62 ns | 0.0491 ns | 0.0459 ns | 28.61 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 18.64 ns | 0.0255 ns | 0.0239 ns | 18.64 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 28.66 ns | 0.0846 ns | 0.0792 ns | 28.70 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 16.15 ns | 0.0192 ns | 0.0180 ns | 16.16 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 19.12 ns | 0.0180 ns | 0.0151 ns | 19.12 ns |      - |       0 B |
                                            From_Short | 14.98 ns | 0.0184 ns | 0.0172 ns | 14.98 ns |      - |       0 B |
                                   From_Short_AsObject | 28.38 ns | 0.0972 ns | 0.0909 ns | 28.39 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.97 ns | 0.0342 ns | 0.0320 ns | 17.96 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 28.36 ns | 0.0324 ns | 0.0288 ns | 28.37 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.08 ns | 0.0137 ns | 0.0128 ns | 15.07 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.97 ns | 0.0307 ns | 0.0287 ns | 17.98 ns |      - |       0 B |
                                              From_Int | 15.86 ns | 0.0218 ns | 0.0170 ns | 15.87 ns |      - |       0 B |
                                     From_Int_AsObject | 29.43 ns | 0.6092 ns | 0.9663 ns | 29.21 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 19.40 ns | 0.5536 ns | 1.6322 ns | 18.46 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 28.31 ns | 0.0358 ns | 0.0335 ns | 28.31 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 15.02 ns | 0.0272 ns | 0.0254 ns | 15.03 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.86 ns | 0.0027 ns | 0.0021 ns | 17.86 ns |      - |       0 B |
                                             From_Long | 14.69 ns | 0.0074 ns | 0.0058 ns | 14.68 ns |      - |       0 B |
                                    From_Long_AsObject | 28.28 ns | 0.0240 ns | 0.0224 ns | 28.28 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 18.18 ns | 0.0169 ns | 0.0158 ns | 18.17 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 28.28 ns | 0.0186 ns | 0.0165 ns | 28.28 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 16.64 ns | 0.0172 ns | 0.0152 ns | 16.64 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.03 ns | 0.0099 ns | 0.0083 ns | 18.03 ns |      - |       0 B |
                                            From_SByte | 14.95 ns | 0.0018 ns | 0.0014 ns | 14.95 ns |      - |       0 B |
                                   From_SByte_AsObject | 28.28 ns | 0.0181 ns | 0.0152 ns | 28.28 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 18.02 ns | 0.0351 ns | 0.0311 ns | 18.02 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 28.29 ns | 0.0289 ns | 0.0270 ns | 28.28 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 16.38 ns | 0.3735 ns | 0.9301 ns | 16.14 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 19.17 ns | 0.4101 ns | 0.7703 ns | 19.13 ns |      - |       0 B |
                                            From_Float | 16.41 ns | 0.3610 ns | 0.9447 ns | 16.37 ns |      - |       0 B |
                                   From_Float_AsObject | 30.58 ns | 0.6412 ns | 1.2354 ns | 30.57 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 19.88 ns | 0.4289 ns | 1.0680 ns | 19.95 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 30.19 ns | 0.6283 ns | 1.3115 ns | 30.10 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 16.47 ns | 0.3604 ns | 0.8703 ns | 16.23 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 19.21 ns | 0.4116 ns | 0.7731 ns | 19.07 ns |      - |       0 B |
                                           From_String | 36.84 ns | 0.8028 ns | 2.3672 ns | 35.34 ns |      - |       0 B |
                                  From_String_AsObject | 47.32 ns | 0.0806 ns | 0.0714 ns | 47.30 ns |      - |       0 B |
                                      From_String_Null | 16.22 ns | 0.0108 ns | 0.0101 ns | 16.22 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.05 ns | 0.0322 ns | 0.0269 ns | 18.05 ns |      - |       0 B |
                                     From_String_Empty | 16.80 ns | 0.0123 ns | 0.0115 ns | 16.80 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 15.73 ns | 0.0156 ns | 0.0130 ns | 15.73 ns |      - |       0 B |
                                  From_UShort_AsObject | 28.38 ns | 0.1300 ns | 0.1152 ns | 28.34 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 17.90 ns | 0.0199 ns | 0.0186 ns | 17.91 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 28.32 ns | 0.0433 ns | 0.0405 ns | 28.32 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 15.05 ns | 0.0275 ns | 0.0244 ns | 15.06 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.90 ns | 0.0458 ns | 0.0428 ns | 17.90 ns |      - |       0 B |
                                             From_UInt | 15.00 ns | 0.0589 ns | 0.0551 ns | 15.02 ns |      - |       0 B |
                                    From_UInt_AsObject | 28.35 ns | 0.0460 ns | 0.0430 ns | 28.34 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 18.27 ns | 0.0101 ns | 0.0085 ns | 18.27 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 28.33 ns | 0.0355 ns | 0.0315 ns | 28.32 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 16.59 ns | 0.3664 ns | 0.8271 ns | 16.67 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 19.06 ns | 0.4737 ns | 1.3967 ns | 18.13 ns |      - |       0 B |
                                            From_ULong | 14.96 ns | 0.0226 ns | 0.0200 ns | 14.96 ns |      - |       0 B |
                                   From_ULong_AsObject | 28.48 ns | 0.0711 ns | 0.0630 ns | 28.47 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 18.56 ns | 0.0645 ns | 0.0572 ns | 18.54 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 28.47 ns | 0.1879 ns | 0.1758 ns | 28.40 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 16.83 ns | 0.0190 ns | 0.0178 ns | 16.84 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 18.68 ns | 0.0223 ns | 0.0198 ns | 18.68 ns |      - |       0 B |
                                       From_NullObject | 17.87 ns | 0.0326 ns | 0.0305 ns | 17.86 ns |      - |       0 B |
                                           From_DBNull | 16.08 ns | 0.0267 ns | 0.0237 ns | 16.08 ns |      - |       0 B |
                                 From_ConvertibleClass | 26.24 ns | 0.0294 ns | 0.0260 ns | 26.25 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 26.53 ns | 0.0785 ns | 0.0734 ns | 26.56 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 19.43 ns | 0.4167 ns | 0.4279 ns | 19.40 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 19.12 ns | 0.4167 ns | 0.3694 ns | 19.06 ns |      - |       0 B |
                              From_NonConvertibleClass | 19.44 ns | 0.4186 ns | 0.6640 ns | 19.50 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 24.96 ns | 0.4847 ns | 0.5387 ns | 24.92 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 21.59 ns | 0.4390 ns | 0.4106 ns | 21.69 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.53 ns | 0.3903 ns | 0.4495 ns | 18.32 ns |      - |       0 B |
                                From_ConvertibleStruct | 26.31 ns | 0.5586 ns | 1.4117 ns | 26.45 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 29.19 ns | 0.6181 ns | 0.9623 ns | 29.16 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 28.39 ns | 0.6027 ns | 0.8644 ns | 28.32 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 29.70 ns | 0.6242 ns | 1.0429 ns | 29.77 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 18.54 ns | 0.3990 ns | 0.8589 ns | 18.45 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.88 ns | 0.4111 ns | 0.5763 ns | 18.84 ns |      - |       0 B |
                             From_NonConvertibleStruct | 15.48 ns | 0.3410 ns | 0.7412 ns | 15.36 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 27.72 ns | 0.5736 ns | 0.8760 ns | 27.55 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 16.59 ns | 0.3657 ns | 0.6501 ns | 16.52 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 25.02 ns | 0.5631 ns | 0.5783 ns | 25.00 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 16.64 ns | 0.3680 ns | 0.8747 ns | 16.87 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.72 ns | 0.4049 ns | 0.5808 ns | 18.64 ns |      - |       0 B |
                                             From_Enum | 18.89 ns | 0.4120 ns | 1.0708 ns | 18.90 ns |      - |       0 B |
                                    From_Enum_AsObject | 66.56 ns | 1.3573 ns | 2.8031 ns | 66.56 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 21.03 ns | 0.4499 ns | 0.7879 ns | 20.41 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 62.14 ns | 0.0226 ns | 0.0200 ns | 62.14 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 15.03 ns | 0.0091 ns | 0.0076 ns | 15.03 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.86 ns | 0.0053 ns | 0.0047 ns | 17.86 ns |      - |       0 B |
                                      From_ParentClass | 16.97 ns | 0.0047 ns | 0.0042 ns | 16.97 ns |      - |       0 B |
                             From_ParentClass_AsObject | 24.59 ns | 0.0131 ns | 0.0116 ns | 24.58 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.03 ns | 0.0040 ns | 0.0037 ns | 17.03 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.85 ns | 0.0058 ns | 0.0052 ns | 17.85 ns |      - |       0 B |
                                     From_ParentStruct | 14.40 ns | 0.0052 ns | 0.0041 ns | 14.40 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 23.88 ns | 0.0115 ns | 0.0102 ns | 23.88 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 15.06 ns | 0.3377 ns | 0.5734 ns | 14.73 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 24.69 ns | 0.0592 ns | 0.0525 ns | 24.66 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.22 ns | 0.0110 ns | 0.0097 ns | 15.22 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.91 ns | 0.0024 ns | 0.0021 ns | 17.91 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_String_Empty_AsObject: DefaultJob
