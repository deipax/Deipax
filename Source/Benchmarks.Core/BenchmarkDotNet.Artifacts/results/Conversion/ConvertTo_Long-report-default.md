
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 13.63 ns | 0.1175 ns | 0.1099 ns | 13.62 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.76 ns | 0.0513 ns | 0.0455 ns | 22.74 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.32 ns | 0.0545 ns | 0.0510 ns | 14.32 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 23.78 ns | 0.0069 ns | 0.0058 ns | 23.78 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.89 ns | 0.0202 ns | 0.0189 ns | 14.90 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.06 ns | 0.0282 ns | 0.0264 ns | 16.05 ns |      - |       0 B |
                                             From_Byte | 13.03 ns | 0.0287 ns | 0.0269 ns | 13.04 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.78 ns | 0.0430 ns | 0.0402 ns | 22.76 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.20 ns | 0.0215 ns | 0.0179 ns | 14.20 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.77 ns | 0.0556 ns | 0.0520 ns | 22.74 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.70 ns | 0.0306 ns | 0.0287 ns | 13.70 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.78 ns | 0.0277 ns | 0.0259 ns | 16.77 ns |      - |       0 B |
                                             From_Char | 13.25 ns | 0.0192 ns | 0.0179 ns | 13.24 ns |      - |       0 B |
                                    From_Char_AsObject | 23.56 ns | 0.0116 ns | 0.0103 ns | 23.56 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.79 ns | 0.0132 ns | 0.0117 ns | 13.79 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 24.63 ns | 0.0571 ns | 0.0534 ns | 24.64 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.88 ns | 0.0050 ns | 0.0039 ns | 13.88 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.09 ns | 0.0140 ns | 0.0124 ns | 18.09 ns |      - |       0 B |
                                         From_DateTime | 13.42 ns | 0.0099 ns | 0.0077 ns | 13.42 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.34 ns | 0.0377 ns | 0.0353 ns | 14.31 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.31 ns | 0.0388 ns | 0.0363 ns | 14.30 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.00 ns | 0.0162 ns | 0.0143 ns | 15.99 ns |      - |       0 B |
                                          From_Decimal | 25.82 ns | 0.1003 ns | 0.0938 ns | 25.76 ns |      - |       0 B |
                                 From_Decimal_AsObject | 33.51 ns | 0.0491 ns | 0.0459 ns | 33.49 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 25.69 ns | 0.0650 ns | 0.0608 ns | 25.68 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 33.77 ns | 0.2457 ns | 0.2298 ns | 33.65 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.32 ns | 0.0342 ns | 0.0320 ns | 14.30 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.15 ns | 0.0454 ns | 0.0425 ns | 16.12 ns |      - |       0 B |
                                           From_Double | 16.88 ns | 0.0412 ns | 0.0365 ns | 16.86 ns |      - |       0 B |
                                  From_Double_AsObject | 27.80 ns | 0.2802 ns | 0.2484 ns | 27.65 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 18.39 ns | 0.0162 ns | 0.0144 ns | 18.38 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 27.81 ns | 0.4757 ns | 0.3972 ns | 27.62 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.30 ns | 0.0180 ns | 0.0159 ns | 14.30 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.00 ns | 0.0133 ns | 0.0111 ns | 15.99 ns |      - |       0 B |
                                            From_Short | 14.47 ns | 0.0182 ns | 0.0171 ns | 14.47 ns |      - |       0 B |
                                   From_Short_AsObject | 23.02 ns | 0.0318 ns | 0.0298 ns | 23.01 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.66 ns | 0.0070 ns | 0.0059 ns | 15.66 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.06 ns | 0.0390 ns | 0.0365 ns | 24.04 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.08 ns | 0.0472 ns | 0.0441 ns | 14.06 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.73 ns | 0.0240 ns | 0.0225 ns | 18.72 ns |      - |       0 B |
                                              From_Int | 13.17 ns | 0.0021 ns | 0.0017 ns | 13.16 ns |      - |       0 B |
                                     From_Int_AsObject | 23.02 ns | 0.0388 ns | 0.0363 ns | 23.01 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 13.80 ns | 0.0347 ns | 0.0308 ns | 13.79 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 23.02 ns | 0.0235 ns | 0.0220 ns | 23.01 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 15.49 ns | 0.0174 ns | 0.0146 ns | 15.49 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.99 ns | 0.0059 ns | 0.0049 ns | 15.99 ns |      - |       0 B |
                                             From_Long | 13.86 ns | 0.0081 ns | 0.0072 ns | 13.86 ns |      - |       0 B |
                                    From_Long_AsObject | 16.64 ns | 0.0121 ns | 0.0101 ns | 16.64 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 14.83 ns | 0.0188 ns | 0.0166 ns | 14.83 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 17.85 ns | 0.0321 ns | 0.0300 ns | 17.83 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.32 ns | 0.0130 ns | 0.0109 ns | 14.31 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.07 ns | 0.0073 ns | 0.0057 ns | 18.07 ns |      - |       0 B |
                                            From_SByte | 13.01 ns | 0.0117 ns | 0.0104 ns | 13.01 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.00 ns | 0.0110 ns | 0.0092 ns | 23.00 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 13.87 ns | 0.0338 ns | 0.0316 ns | 13.87 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 24.06 ns | 0.0364 ns | 0.0340 ns | 24.04 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.69 ns | 0.0140 ns | 0.0131 ns | 13.68 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.62 ns | 0.0057 ns | 0.0051 ns | 17.62 ns |      - |       0 B |
                                            From_Float | 17.37 ns | 0.2037 ns | 0.1905 ns | 17.28 ns |      - |       0 B |
                                   From_Float_AsObject | 28.35 ns | 0.0187 ns | 0.0156 ns | 28.35 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 17.40 ns | 0.0229 ns | 0.0214 ns | 17.39 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 28.38 ns | 0.0421 ns | 0.0393 ns | 28.36 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.72 ns | 0.0479 ns | 0.0448 ns | 13.72 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 15.99 ns | 0.0058 ns | 0.0045 ns | 15.99 ns |      - |       0 B |
                                           From_String | 87.57 ns | 0.0837 ns | 0.0699 ns | 87.57 ns |      - |       0 B |
                                  From_String_AsObject | 95.93 ns | 0.1495 ns | 0.1325 ns | 95.87 ns |      - |       0 B |
                                      From_String_Null | 16.26 ns | 0.0154 ns | 0.0137 ns | 16.26 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.43 ns | 0.0177 ns | 0.0157 ns | 16.43 ns |      - |       0 B |
                                     From_String_Empty | 15.04 ns | 0.0129 ns | 0.0108 ns | 15.04 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 13.18 ns | 0.0133 ns | 0.0118 ns | 13.18 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.02 ns | 0.0354 ns | 0.0331 ns | 23.00 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.00 ns | 0.4637 ns | 0.4111 ns | 13.85 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.44 ns | 0.3449 ns | 0.2880 ns | 23.33 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.47 ns | 0.0584 ns | 0.0488 ns | 13.48 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.03 ns | 0.0917 ns | 0.0813 ns | 16.00 ns |      - |       0 B |
                                             From_UInt | 13.01 ns | 0.0064 ns | 0.0050 ns | 13.00 ns |      - |       0 B |
                                    From_UInt_AsObject | 24.28 ns | 0.0418 ns | 0.0326 ns | 24.29 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 13.89 ns | 0.1550 ns | 0.1294 ns | 13.83 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 23.05 ns | 0.0531 ns | 0.0443 ns | 23.04 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.80 ns | 0.0472 ns | 0.0419 ns | 13.80 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.98 ns | 0.0577 ns | 0.0540 ns | 16.97 ns |      - |       0 B |
                                            From_ULong | 14.00 ns | 0.0387 ns | 0.0343 ns | 13.99 ns |      - |       0 B |
                                   From_ULong_AsObject | 23.83 ns | 0.0702 ns | 0.0656 ns | 23.82 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.76 ns | 0.1618 ns | 0.1514 ns | 15.73 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.09 ns | 0.3668 ns | 0.3251 ns | 24.07 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.72 ns | 0.1364 ns | 0.1209 ns | 14.70 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.25 ns | 0.1953 ns | 0.1827 ns | 16.19 ns |      - |       0 B |
                                       From_NullObject | 16.17 ns | 0.1720 ns | 0.1609 ns | 16.09 ns |      - |       0 B |
                                           From_DBNull | 14.75 ns | 0.1059 ns | 0.0884 ns | 14.72 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.34 ns | 0.0646 ns | 0.0504 ns | 17.33 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.04 ns | 0.0725 ns | 0.0606 ns | 20.02 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 21.02 ns | 0.0801 ns | 0.0710 ns | 21.01 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.18 ns | 0.0500 ns | 0.0468 ns | 16.17 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.13 ns | 0.0329 ns | 0.0291 ns | 16.13 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.35 ns | 0.0293 ns | 0.0274 ns | 14.36 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.45 ns | 0.0815 ns | 0.0762 ns | 19.45 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.35 ns | 0.0398 ns | 0.0373 ns | 14.34 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.94 ns | 0.0678 ns | 0.0634 ns | 16.94 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.37 ns | 0.0525 ns | 0.0491 ns | 22.36 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.56 ns | 0.0630 ns | 0.0589 ns | 22.56 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.66 ns | 0.0307 ns | 0.0287 ns | 22.67 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.42 ns | 0.0711 ns | 0.0665 ns | 22.42 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.25 ns | 0.0765 ns | 0.0678 ns | 14.24 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 19.45 ns | 0.0592 ns | 0.0554 ns | 19.45 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.09 ns | 0.0364 ns | 0.0341 ns | 14.09 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.31 ns | 0.0816 ns | 0.0723 ns | 18.30 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.96 ns | 0.0456 ns | 0.0381 ns | 13.96 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.28 ns | 0.0900 ns | 0.0842 ns | 19.26 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.23 ns | 0.0253 ns | 0.0237 ns | 14.24 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.27 ns | 0.0780 ns | 0.0730 ns | 16.26 ns |      - |       0 B |
                                             From_Enum | 13.23 ns | 0.0348 ns | 0.0325 ns | 13.22 ns |      - |       0 B |
                                    From_Enum_AsObject | 53.73 ns | 0.1653 ns | 0.1465 ns | 53.71 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 13.88 ns | 0.1112 ns | 0.0929 ns | 13.86 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 53.25 ns | 0.1407 ns | 0.1317 ns | 53.26 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.46 ns | 0.0379 ns | 0.0336 ns | 13.44 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.30 ns | 0.0574 ns | 0.0537 ns | 17.30 ns |      - |       0 B |
                                      From_ParentClass | 14.36 ns | 0.0420 ns | 0.0373 ns | 14.36 ns |      - |       0 B |
                             From_ParentClass_AsObject | 18.80 ns | 0.1743 ns | 0.1630 ns | 18.75 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.35 ns | 0.0349 ns | 0.0326 ns | 14.35 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.05 ns | 0.0348 ns | 0.0308 ns | 16.05 ns |      - |       0 B |
                                     From_ParentStruct | 14.11 ns | 0.0522 ns | 0.0462 ns | 14.10 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 21.39 ns | 0.1989 ns | 0.1661 ns | 21.32 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.14 ns | 0.1850 ns | 0.1640 ns | 14.10 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.30 ns | 0.4115 ns | 0.4899 ns | 18.97 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.95 ns | 0.0220 ns | 0.0184 ns | 13.95 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.20 ns | 0.1507 ns | 0.1409 ns | 16.26 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
