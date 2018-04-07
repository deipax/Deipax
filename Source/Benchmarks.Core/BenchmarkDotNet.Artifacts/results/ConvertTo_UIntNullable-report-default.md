
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  40.32 ns | 0.0131 ns | 0.0109 ns |  40.32 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  38.28 ns | 0.0690 ns | 0.0538 ns |  38.27 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 114.10 ns | 0.0172 ns | 0.0153 ns | 114.10 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.26 ns | 0.0713 ns | 0.0632 ns |  38.23 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  42.73 ns | 0.0447 ns | 0.0419 ns |  42.72 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.47 ns | 0.0132 ns | 0.0117 ns |  15.47 ns |      - |       0 B |
                                          From_Byte |  39.32 ns | 0.0200 ns | 0.0177 ns |  39.32 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  38.23 ns | 0.0262 ns | 0.0219 ns |  38.21 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 112.84 ns | 0.0517 ns | 0.0483 ns | 112.81 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  38.23 ns | 0.0349 ns | 0.0272 ns |  38.22 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  43.66 ns | 0.0483 ns | 0.0451 ns |  43.65 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  15.22 ns | 0.0217 ns | 0.0203 ns |  15.21 ns |      - |       0 B |
                                          From_Char |  42.89 ns | 0.0284 ns | 0.0252 ns |  42.88 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  40.56 ns | 0.0335 ns | 0.0314 ns |  40.55 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 117.00 ns | 0.0477 ns | 0.0446 ns | 117.02 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  40.68 ns | 0.0323 ns | 0.0286 ns |  40.69 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.68 ns | 0.0235 ns | 0.0208 ns |  41.68 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.21 ns | 0.0151 ns | 0.0134 ns |  15.21 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  42.15 ns | 0.0262 ns | 0.0232 ns |  42.15 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.92 ns | 0.0196 ns | 0.0183 ns |  15.92 ns |      - |       0 B |
                                       From_Decimal |  51.73 ns | 0.0219 ns | 0.0171 ns |  51.73 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  48.44 ns | 0.0266 ns | 0.0222 ns |  48.43 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 128.92 ns | 0.0926 ns | 0.0866 ns | 128.87 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  49.02 ns | 0.0339 ns | 0.0301 ns |  49.02 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.52 ns | 0.0489 ns | 0.0458 ns |  41.52 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.47 ns | 0.0020 ns | 0.0016 ns |  15.47 ns |      - |       0 B |
                                        From_Double |  41.14 ns | 0.0111 ns | 0.0099 ns |  41.14 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  39.83 ns | 0.0183 ns | 0.0163 ns |  39.83 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 118.87 ns | 0.0200 ns | 0.0177 ns | 118.87 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  39.81 ns | 0.0040 ns | 0.0032 ns |  39.81 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.86 ns | 0.0485 ns | 0.0454 ns |  42.85 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.21 ns | 0.0207 ns | 0.0184 ns |  15.20 ns |      - |       0 B |
                                         From_Short |  39.85 ns | 0.0196 ns | 0.0183 ns |  39.85 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  38.73 ns | 0.0058 ns | 0.0045 ns |  38.73 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 114.03 ns | 0.2874 ns | 0.2688 ns | 113.99 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  38.75 ns | 0.0229 ns | 0.0203 ns |  38.74 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.30 ns | 0.0224 ns | 0.0199 ns |  42.29 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  15.20 ns | 0.0107 ns | 0.0089 ns |  15.20 ns |      - |       0 B |
                                           From_Int |  39.81 ns | 0.0118 ns | 0.0110 ns |  39.80 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  38.78 ns | 0.0472 ns | 0.0441 ns |  38.76 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 114.53 ns | 0.0162 ns | 0.0126 ns | 114.53 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  38.78 ns | 0.0066 ns | 0.0059 ns |  38.78 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  43.12 ns | 0.0343 ns | 0.0321 ns |  43.12 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.48 ns | 0.0176 ns | 0.0165 ns |  15.48 ns |      - |       0 B |
                                          From_Long |  40.94 ns | 0.1389 ns | 0.1085 ns |  40.90 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  39.62 ns | 0.0915 ns | 0.0764 ns |  39.60 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 121.61 ns | 2.4289 ns | 3.9908 ns | 119.85 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  40.32 ns | 0.8773 ns | 0.8206 ns |  40.13 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  43.63 ns | 1.0821 ns | 1.7474 ns |  42.79 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.54 ns | 0.0740 ns | 0.0656 ns |  15.50 ns |      - |       0 B |
                                         From_SByte |  41.68 ns | 0.9091 ns | 0.8503 ns |  41.30 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  39.90 ns | 0.0806 ns | 0.0715 ns |  39.88 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 114.49 ns | 0.5228 ns | 0.4634 ns | 114.30 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  39.69 ns | 0.1101 ns | 0.1030 ns |  39.67 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  43.31 ns | 0.0655 ns | 0.0612 ns |  43.28 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.22 ns | 0.0344 ns | 0.0305 ns |  16.22 ns |      - |       0 B |
                                         From_Float |  41.98 ns | 0.0334 ns | 0.0312 ns |  41.98 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  40.44 ns | 0.1785 ns | 0.1490 ns |  40.37 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 120.44 ns | 1.7225 ns | 1.6112 ns | 119.81 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  40.20 ns | 0.0577 ns | 0.0540 ns |  40.18 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  45.25 ns | 0.0761 ns | 0.0711 ns |  45.21 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  15.26 ns | 0.0368 ns | 0.0287 ns |  15.24 ns |      - |       0 B |
                                        From_String | 115.15 ns | 0.1025 ns | 0.0909 ns | 115.14 ns |      - |       0 B |
                               From_String_AsObject | 114.72 ns | 0.5485 ns | 0.4862 ns | 114.55 ns |      - |       0 B |
                                   From_String_Null |  15.58 ns | 0.0040 ns | 0.0029 ns |  15.58 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.53 ns | 0.0515 ns | 0.0482 ns |  15.50 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  39.98 ns | 0.0413 ns | 0.0386 ns |  39.99 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  38.32 ns | 0.0731 ns | 0.0684 ns |  38.28 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 116.06 ns | 0.1477 ns | 0.1233 ns | 115.99 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  38.28 ns | 0.0146 ns | 0.0130 ns |  38.28 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  43.22 ns | 0.0327 ns | 0.0255 ns |  43.21 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.49 ns | 0.0109 ns | 0.0085 ns |  15.49 ns |      - |       0 B |
                                          From_UInt |  29.51 ns | 0.0272 ns | 0.0227 ns |  29.51 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  27.51 ns | 0.0483 ns | 0.0451 ns |  27.49 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 102.52 ns | 0.5700 ns | 0.5332 ns | 102.59 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  27.51 ns | 0.0405 ns | 0.0338 ns |  27.50 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  43.20 ns | 0.0194 ns | 0.0152 ns |  43.20 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.52 ns | 0.0182 ns | 0.0142 ns |  15.51 ns |      - |       0 B |
                                         From_ULong |  40.90 ns | 0.2367 ns | 0.2214 ns |  40.75 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  39.45 ns | 0.0284 ns | 0.0252 ns |  39.45 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 115.57 ns | 0.4517 ns | 0.4225 ns | 115.35 ns | 0.0055 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  39.73 ns | 0.0375 ns | 0.0293 ns |  39.73 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.92 ns | 0.0742 ns | 0.0658 ns |  41.89 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.31 ns | 0.0140 ns | 0.0109 ns |  15.31 ns |      - |       0 B |
                                    From_NullObject |  15.31 ns | 0.0311 ns | 0.0291 ns |  15.29 ns |      - |       0 B |
                                        From_DBNull |  15.67 ns | 0.0183 ns | 0.0143 ns |  15.67 ns |      - |       0 B |
                              From_ConvertibleClass |  38.30 ns | 0.0584 ns | 0.0546 ns |  38.27 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  37.68 ns | 0.0254 ns | 0.0237 ns |  37.69 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.50 ns | 0.0185 ns | 0.0155 ns |  15.49 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.14 ns | 0.0365 ns | 0.0324 ns |  16.13 ns |      - |       0 B |
                             From_ConvertibleStruct |  39.56 ns | 0.0543 ns | 0.0481 ns |  39.55 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  37.92 ns | 0.0338 ns | 0.0299 ns |  37.91 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 120.19 ns | 0.2895 ns | 0.2566 ns | 120.07 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  38.23 ns | 0.0472 ns | 0.0418 ns |  38.22 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.34 ns | 0.0187 ns | 0.0146 ns |  42.33 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.54 ns | 0.0560 ns | 0.0524 ns |  15.52 ns |      - |       0 B |
                                          From_Enum | 100.11 ns | 0.0460 ns | 0.0384 ns | 100.10 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  99.34 ns | 0.2585 ns | 0.2418 ns |  99.25 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 205.16 ns | 0.5668 ns | 0.5025 ns | 204.97 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  97.03 ns | 0.1636 ns | 0.1450 ns |  96.99 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.73 ns | 0.0164 ns | 0.0145 ns |  42.73 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.26 ns | 0.0470 ns | 0.0440 ns |  15.24 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_UIntNullable.From_DateTime: DefaultJob
  ConvertTo_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UIntNullable.From_String_Empty: DefaultJob
  ConvertTo_UIntNullable.From_String_Empty_AsObject: DefaultJob
