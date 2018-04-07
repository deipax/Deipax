
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  16.95 ns | 0.0396 ns | 0.0351 ns |  16.93 ns |      - |       0 B |
                                 From_Bool_AsObject |  33.21 ns | 0.2028 ns | 0.1798 ns |  33.10 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  21.72 ns | 0.0874 ns | 0.0730 ns |  21.72 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  33.35 ns | 0.3038 ns | 0.2842 ns |  33.34 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.46 ns | 0.0332 ns | 0.0294 ns |  16.45 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.39 ns | 0.0121 ns | 0.0107 ns |  17.38 ns |      - |       0 B |
                                          From_Byte |  16.48 ns | 0.0242 ns | 0.0226 ns |  16.48 ns |      - |       0 B |
                                 From_Byte_AsObject |  33.17 ns | 0.1309 ns | 0.1224 ns |  33.13 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  20.52 ns | 0.1059 ns | 0.0939 ns |  20.50 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  33.15 ns | 0.1185 ns | 0.1109 ns |  33.09 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.42 ns | 0.0146 ns | 0.0129 ns |  16.42 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.42 ns | 0.0891 ns | 0.0834 ns |  17.38 ns |      - |       0 B |
                                          From_Char |  15.49 ns | 0.0165 ns | 0.0138 ns |  15.49 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  15.02 ns | 0.0118 ns | 0.0105 ns |  15.02 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  14.86 ns | 0.0122 ns | 0.0108 ns |  14.86 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.38 ns | 0.0129 ns | 0.0101 ns |  17.38 ns |      - |       0 B |
                                      From_DateTime |  15.79 ns | 0.0300 ns | 0.0250 ns |  15.78 ns |      - |       0 B |
                             From_DateTime_AsObject |  25.19 ns | 0.0946 ns | 0.0885 ns |  25.17 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  16.37 ns | 0.0314 ns | 0.0294 ns |  16.37 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  23.11 ns | 0.0822 ns | 0.0729 ns |  23.07 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  16.35 ns | 0.0224 ns | 0.0210 ns |  16.34 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.62 ns | 0.0634 ns | 0.0593 ns |  17.59 ns |      - |       0 B |
                                       From_Decimal |  15.87 ns | 0.0014 ns | 0.0012 ns |  15.87 ns |      - |       0 B |
                              From_Decimal_AsObject |  19.17 ns | 0.0895 ns | 0.0837 ns |  19.18 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  27.39 ns | 0.0180 ns | 0.0169 ns |  27.38 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  18.04 ns | 0.0893 ns | 0.0835 ns |  18.01 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  27.69 ns | 0.0121 ns | 0.0113 ns |  27.69 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.39 ns | 0.0949 ns | 0.0841 ns |  17.35 ns |      - |       0 B |
                                        From_Double |  78.47 ns | 0.0470 ns | 0.0440 ns |  78.47 ns |      - |       0 B |
                               From_Double_AsObject |  93.26 ns | 0.0988 ns | 0.0924 ns |  93.22 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  82.62 ns | 0.0358 ns | 0.0318 ns |  82.60 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  93.27 ns | 0.0478 ns | 0.0373 ns |  93.26 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  17.30 ns | 0.0275 ns | 0.0244 ns |  17.30 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.62 ns | 0.0118 ns | 0.0104 ns |  17.61 ns |      - |       0 B |
                                         From_Short |  16.55 ns | 0.0300 ns | 0.0266 ns |  16.55 ns |      - |       0 B |
                                From_Short_AsObject |  33.36 ns | 0.0484 ns | 0.0404 ns |  33.35 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  20.01 ns | 0.0203 ns | 0.0180 ns |  20.00 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  33.36 ns | 0.0266 ns | 0.0236 ns |  33.35 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  16.16 ns | 0.0321 ns | 0.0285 ns |  16.16 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.06 ns | 0.0161 ns | 0.0134 ns |  18.05 ns |      - |       0 B |
                                           From_Int |  16.30 ns | 0.0165 ns | 0.0154 ns |  16.30 ns |      - |       0 B |
                                  From_Int_AsObject |  33.36 ns | 0.0351 ns | 0.0311 ns |  33.34 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  20.07 ns | 0.0392 ns | 0.0367 ns |  20.07 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  33.48 ns | 0.0378 ns | 0.0316 ns |  33.47 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.02 ns | 0.0136 ns | 0.0127 ns |  16.01 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.47 ns | 0.0806 ns | 0.0754 ns |  17.52 ns |      - |       0 B |
                                          From_Long |  15.87 ns | 0.0164 ns | 0.0154 ns |  15.87 ns |      - |       0 B |
                                 From_Long_AsObject |  33.71 ns | 0.0682 ns | 0.0638 ns |  33.73 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  22.33 ns | 0.0177 ns | 0.0157 ns |  22.33 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  33.98 ns | 0.1795 ns | 0.1499 ns |  33.95 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  17.26 ns | 0.0272 ns | 0.0254 ns |  17.25 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.96 ns | 0.1151 ns | 0.1077 ns |  17.92 ns |      - |       0 B |
                                         From_SByte |  16.40 ns | 0.0140 ns | 0.0117 ns |  16.40 ns |      - |       0 B |
                                From_SByte_AsObject |  33.66 ns | 0.1959 ns | 0.1833 ns |  33.66 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  20.76 ns | 0.0376 ns | 0.0314 ns |  20.76 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  33.36 ns | 0.0198 ns | 0.0176 ns |  33.35 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.77 ns | 0.3698 ns | 0.3797 ns |  16.63 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.77 ns | 0.0767 ns | 0.0680 ns |  17.75 ns |      - |       0 B |
                                         From_Float |  37.30 ns | 0.1488 ns | 0.1392 ns |  37.24 ns |      - |       0 B |
                                From_Float_AsObject |  51.69 ns | 0.2931 ns | 0.2598 ns |  51.62 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  41.71 ns | 0.1685 ns | 0.1493 ns |  41.66 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  51.84 ns | 0.9935 ns | 0.9293 ns |  51.41 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  16.42 ns | 0.3595 ns | 0.5596 ns |  16.09 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.39 ns | 0.0105 ns | 0.0082 ns |  17.38 ns |      - |       0 B |
                                        From_String | 129.36 ns | 0.4192 ns | 0.3716 ns | 129.33 ns |      - |       0 B |
                               From_String_AsObject | 144.53 ns | 0.1285 ns | 0.1139 ns | 144.47 ns |      - |       0 B |
                                   From_String_Null |  16.24 ns | 0.0139 ns | 0.0130 ns |  16.24 ns |      - |       0 B |
                          From_String_Null_AsObject |  23.47 ns | 0.0184 ns | 0.0154 ns |  23.46 ns |      - |       0 B |
                                  From_String_Empty |  16.11 ns | 0.0128 ns | 0.0120 ns |  16.11 ns |      - |       0 B |
                         From_String_Empty_AsObject |  25.13 ns | 0.0198 ns | 0.0165 ns |  25.12 ns |      - |       0 B |
                                        From_UShort |  16.35 ns | 0.0366 ns | 0.0325 ns |  16.35 ns |      - |       0 B |
                               From_UShort_AsObject |  33.50 ns | 0.2156 ns | 0.2016 ns |  33.40 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  19.91 ns | 0.0212 ns | 0.0198 ns |  19.91 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  33.41 ns | 0.0563 ns | 0.0526 ns |  33.42 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.95 ns | 0.0102 ns | 0.0091 ns |  15.95 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.34 ns | 0.0310 ns | 0.0275 ns |  17.34 ns |      - |       0 B |
                                          From_UInt |  15.23 ns | 0.0052 ns | 0.0043 ns |  15.23 ns |      - |       0 B |
                                 From_UInt_AsObject |  33.17 ns | 0.0547 ns | 0.0512 ns |  33.18 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  19.64 ns | 0.0085 ns | 0.0066 ns |  19.64 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  33.13 ns | 0.0576 ns | 0.0481 ns |  33.12 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  16.53 ns | 0.0119 ns | 0.0111 ns |  16.53 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.34 ns | 0.0115 ns | 0.0107 ns |  17.34 ns |      - |       0 B |
                                         From_ULong |  15.24 ns | 0.0130 ns | 0.0116 ns |  15.24 ns |      - |       0 B |
                                From_ULong_AsObject |  32.82 ns | 0.0284 ns | 0.0266 ns |  32.80 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  21.56 ns | 0.0214 ns | 0.0200 ns |  21.55 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  32.81 ns | 0.0187 ns | 0.0175 ns |  32.80 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  17.26 ns | 0.0150 ns | 0.0133 ns |  17.26 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.38 ns | 0.0157 ns | 0.0147 ns |  17.38 ns |      - |       0 B |
                                    From_NullObject |  17.35 ns | 0.0174 ns | 0.0163 ns |  17.34 ns |      - |       0 B |
                                        From_DBNull |  15.86 ns | 0.0135 ns | 0.0120 ns |  15.86 ns |      - |       0 B |
                              From_ConvertibleClass |  27.13 ns | 0.5208 ns | 0.4872 ns |  26.94 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  30.13 ns | 0.0030 ns | 0.0025 ns |  30.13 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.32 ns | 0.0081 ns | 0.0063 ns |  18.32 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.61 ns | 0.0160 ns | 0.0142 ns |  17.61 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.45 ns | 0.0134 ns | 0.0119 ns |  24.45 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  31.57 ns | 0.0272 ns | 0.0254 ns |  31.56 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.77 ns | 0.0237 ns | 0.0210 ns |  28.76 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  31.56 ns | 0.1072 ns | 0.0950 ns |  31.53 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  15.61 ns | 0.0111 ns | 0.0098 ns |  15.60 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.23 ns | 0.0043 ns | 0.0029 ns |  18.23 ns |      - |       0 B |
                                          From_Enum |  16.39 ns | 0.0075 ns | 0.0062 ns |  16.39 ns |      - |       0 B |
                                 From_Enum_AsObject |  65.71 ns | 0.0499 ns | 0.0467 ns |  65.69 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.84 ns | 0.0114 ns | 0.0107 ns |  18.83 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  65.71 ns | 0.1206 ns | 0.0941 ns |  65.70 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.98 ns | 0.0116 ns | 0.0102 ns |  14.99 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.18 ns | 0.0114 ns | 0.0101 ns |  18.17 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo2_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
