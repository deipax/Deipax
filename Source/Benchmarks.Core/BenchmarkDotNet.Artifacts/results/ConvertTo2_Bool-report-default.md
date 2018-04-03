
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 13.43 ns | 0.1454 ns | 0.1289 ns | 13.42 ns |      - |       0 B |
                                    From_Bool_AsObject | 19.26 ns | 0.0678 ns | 0.0566 ns | 19.25 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 13.67 ns | 0.2646 ns | 0.2475 ns | 13.56 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 16.89 ns | 0.0712 ns | 0.0666 ns | 16.87 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.79 ns | 0.2560 ns | 0.2394 ns | 13.73 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 18.12 ns | 0.0480 ns | 0.0375 ns | 18.12 ns |      - |       0 B |
                                             From_Byte | 14.17 ns | 0.2560 ns | 0.2395 ns | 14.04 ns |      - |       0 B |
                                    From_Byte_AsObject | 29.73 ns | 0.0536 ns | 0.0502 ns | 29.73 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 23.01 ns | 0.2721 ns | 0.2272 ns | 22.85 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 29.71 ns | 0.0495 ns | 0.0463 ns | 29.69 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.23 ns | 0.0063 ns | 0.0049 ns | 13.23 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.50 ns | 0.0322 ns | 0.0233 ns | 17.49 ns |      - |       0 B |
                                             From_Char |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                    From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |       NA |        NA |        NA |       NA |    N/A |       N/A |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 13.51 ns | 0.0216 ns | 0.0191 ns | 13.50 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.37 ns | 0.1642 ns | 0.1536 ns | 16.28 ns |      - |       0 B |
                                         From_DateTime | 13.39 ns | 0.0250 ns | 0.0221 ns | 13.38 ns |      - |       0 B |
                                From_DateTime_AsObject | 24.55 ns | 0.2922 ns | 0.2733 ns | 24.71 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue | 17.29 ns | 0.0337 ns | 0.0299 ns | 17.28 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject | 22.16 ns | 0.3104 ns | 0.2752 ns | 22.05 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue | 14.47 ns | 0.0291 ns | 0.0272 ns | 14.48 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.04 ns | 0.0377 ns | 0.0315 ns | 16.01 ns |      - |       0 B |
                                          From_Decimal | 23.64 ns | 0.0656 ns | 0.0582 ns | 23.66 ns |      - |       0 B |
                                 From_Decimal_AsObject | 39.69 ns | 0.0507 ns | 0.0450 ns | 39.68 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 30.33 ns | 0.3000 ns | 0.2806 ns | 30.55 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 39.68 ns | 0.0568 ns | 0.0503 ns | 39.67 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.08 ns | 0.0184 ns | 0.0154 ns | 14.08 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.16 ns | 0.1334 ns | 0.1248 ns | 18.09 ns |      - |       0 B |
                                           From_Double | 13.17 ns | 0.0521 ns | 0.0487 ns | 13.19 ns |      - |       0 B |
                                  From_Double_AsObject | 31.73 ns | 0.0780 ns | 0.0730 ns | 31.69 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.85 ns | 0.2976 ns | 0.2784 ns | 17.66 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 32.41 ns | 0.0979 ns | 0.0817 ns | 32.38 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 21.59 ns | 0.1839 ns | 0.1631 ns | 21.50 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.43 ns | 0.0087 ns | 0.0063 ns | 17.43 ns |      - |       0 B |
                                            From_Short | 13.15 ns | 0.0798 ns | 0.0666 ns | 13.11 ns |      - |       0 B |
                                   From_Short_AsObject | 29.93 ns | 0.6270 ns | 0.6439 ns | 30.38 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.47 ns | 0.1292 ns | 0.1208 ns | 17.43 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 32.36 ns | 0.5164 ns | 0.4830 ns | 32.69 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.51 ns | 0.0332 ns | 0.0294 ns | 13.50 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.14 ns | 0.0778 ns | 0.0728 ns | 16.18 ns |      - |       0 B |
                                              From_Int | 13.36 ns | 0.0366 ns | 0.0286 ns | 13.35 ns |      - |       0 B |
                                     From_Int_AsObject | 29.23 ns | 0.1000 ns | 0.0936 ns | 29.18 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 16.83 ns | 0.0220 ns | 0.0195 ns | 16.82 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 31.52 ns | 0.1321 ns | 0.1235 ns | 31.52 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.26 ns | 0.0262 ns | 0.0245 ns | 13.24 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 20.41 ns | 0.0548 ns | 0.0513 ns | 20.40 ns |      - |       0 B |
                                             From_Long | 13.34 ns | 0.0230 ns | 0.0204 ns | 13.33 ns |      - |       0 B |
                                    From_Long_AsObject | 29.22 ns | 0.0980 ns | 0.0869 ns | 29.20 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 17.65 ns | 0.0557 ns | 0.0465 ns | 17.64 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 29.18 ns | 0.0923 ns | 0.0771 ns | 29.15 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.08 ns | 0.0368 ns | 0.0327 ns | 14.08 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.03 ns | 0.0341 ns | 0.0302 ns | 16.02 ns |      - |       0 B |
                                            From_SByte | 13.12 ns | 0.0573 ns | 0.0479 ns | 13.11 ns |      - |       0 B |
                                   From_SByte_AsObject | 29.15 ns | 0.0162 ns | 0.0127 ns | 29.15 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 16.84 ns | 0.0354 ns | 0.0314 ns | 16.84 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 31.41 ns | 0.0626 ns | 0.0585 ns | 31.39 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.27 ns | 0.0533 ns | 0.0498 ns | 13.25 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 18.09 ns | 0.0076 ns | 0.0059 ns | 18.09 ns |      - |       0 B |
                                            From_Float | 13.11 ns | 0.0487 ns | 0.0456 ns | 13.12 ns |      - |       0 B |
                                   From_Float_AsObject | 29.15 ns | 0.0526 ns | 0.0411 ns | 29.14 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.86 ns | 0.0454 ns | 0.0425 ns | 16.86 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 29.22 ns | 0.0935 ns | 0.0829 ns | 29.20 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.29 ns | 0.0533 ns | 0.0498 ns | 13.29 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.37 ns | 0.0222 ns | 0.0197 ns | 16.36 ns |      - |       0 B |
                                           From_String | 37.57 ns | 0.0812 ns | 0.0720 ns | 37.57 ns |      - |       0 B |
                                  From_String_AsObject | 49.35 ns | 0.0982 ns | 0.0871 ns | 49.33 ns |      - |       0 B |
                                      From_String_Null | 16.19 ns | 0.0225 ns | 0.0199 ns | 16.18 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.10 ns | 0.0303 ns | 0.0284 ns | 16.09 ns |      - |       0 B |
                                     From_String_Empty | 20.84 ns | 0.0047 ns | 0.0042 ns | 20.84 ns |      - |       0 B |
                            From_String_Empty_AsObject | 22.76 ns | 0.0127 ns | 0.0106 ns | 22.76 ns |      - |       0 B |
                                           From_UShort | 13.35 ns | 0.0295 ns | 0.0246 ns | 13.34 ns |      - |       0 B |
                                  From_UShort_AsObject | 29.16 ns | 0.0509 ns | 0.0425 ns | 29.16 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 16.99 ns | 0.0051 ns | 0.0045 ns | 16.99 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 29.15 ns | 0.0539 ns | 0.0504 ns | 29.13 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.49 ns | 0.0063 ns | 0.0049 ns | 13.49 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 18.05 ns | 0.0193 ns | 0.0171 ns | 18.05 ns |      - |       0 B |
                                             From_UInt | 14.02 ns | 0.0358 ns | 0.0299 ns | 14.00 ns |      - |       0 B |
                                    From_UInt_AsObject | 29.15 ns | 0.0425 ns | 0.0377 ns | 29.14 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 16.77 ns | 0.0071 ns | 0.0059 ns | 16.78 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 29.14 ns | 0.0503 ns | 0.0446 ns | 29.12 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.24 ns | 0.0431 ns | 0.0382 ns | 13.22 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.01 ns | 0.0295 ns | 0.0246 ns | 16.00 ns |      - |       0 B |
                                            From_ULong | 13.07 ns | 0.0071 ns | 0.0059 ns | 13.06 ns |      - |       0 B |
                                   From_ULong_AsObject | 29.16 ns | 0.0448 ns | 0.0374 ns | 29.16 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 17.32 ns | 0.0088 ns | 0.0069 ns | 17.32 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 29.14 ns | 0.0393 ns | 0.0328 ns | 29.14 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.16 ns | 0.0071 ns | 0.0059 ns | 14.16 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.06 ns | 0.0246 ns | 0.0230 ns | 16.05 ns |      - |       0 B |
                                       From_NullObject | 16.68 ns | 0.0153 ns | 0.0128 ns | 16.67 ns |      - |       0 B |
                                           From_DBNull | 13.75 ns | 0.0085 ns | 0.0075 ns | 13.75 ns |      - |       0 B |
                                 From_ConvertibleClass | 23.75 ns | 0.0121 ns | 0.0101 ns | 23.75 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 28.95 ns | 0.0649 ns | 0.0542 ns | 28.92 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.88 ns | 0.0218 ns | 0.0170 ns | 16.88 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.09 ns | 0.0348 ns | 0.0325 ns | 18.10 ns |      - |       0 B |
                              From_NonConvertibleClass | 19.71 ns | 0.0306 ns | 0.0286 ns | 19.70 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 23.77 ns | 0.0299 ns | 0.0265 ns | 23.77 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 17.79 ns | 0.0059 ns | 0.0046 ns | 17.79 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 16.71 ns | 0.0320 ns | 0.0300 ns | 16.71 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.08 ns | 0.0147 ns | 0.0123 ns | 22.08 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 28.12 ns | 0.1047 ns | 0.0928 ns | 28.07 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.14 ns | 0.0405 ns | 0.0379 ns | 26.13 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 28.05 ns | 0.0239 ns | 0.0187 ns | 28.04 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 13.24 ns | 0.0155 ns | 0.0145 ns | 13.24 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.16 ns | 0.0086 ns | 0.0067 ns | 16.16 ns |      - |       0 B |
                             From_NonConvertibleStruct | 12.84 ns | 0.0095 ns | 0.0085 ns | 12.84 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 23.75 ns | 0.0098 ns | 0.0077 ns | 23.75 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 16.46 ns | 0.0125 ns | 0.0111 ns | 16.46 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 25.70 ns | 0.2100 ns | 0.1862 ns | 25.61 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.24 ns | 0.0361 ns | 0.0338 ns | 13.23 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.01 ns | 0.0188 ns | 0.0167 ns | 16.00 ns |      - |       0 B |
                                             From_Enum | 16.48 ns | 0.0146 ns | 0.0122 ns | 16.47 ns |      - |       0 B |
                                    From_Enum_AsObject | 64.73 ns | 0.0247 ns | 0.0206 ns | 64.72 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 17.78 ns | 0.0602 ns | 0.0563 ns | 17.75 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 62.67 ns | 0.0200 ns | 0.0187 ns | 62.67 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 13.89 ns | 0.0126 ns | 0.0112 ns | 13.89 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.10 ns | 0.0296 ns | 0.0262 ns | 16.09 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char: DefaultJob
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
