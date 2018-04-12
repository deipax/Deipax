
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  13.94 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                                 From_Bool_AsObject |  25.32 ns | 0.0564 ns | 0.0500 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.57 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  25.29 ns | 0.0242 ns | 0.0227 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  13.95 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.19 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                                          From_Byte |  13.46 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
                                 From_Byte_AsObject |  25.45 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.31 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  25.29 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  15.20 ns | 0.0216 ns | 0.0168 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.14 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                                          From_Char |  13.43 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.17 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  14.16 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.15 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                                      From_DateTime |  13.85 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.04 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.10 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  18.88 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
                                       From_Decimal |  19.69 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                              From_Decimal_AsObject |  31.69 ns | 0.0309 ns | 0.0289 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  29.79 ns | 0.0197 ns | 0.0174 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  32.78 ns | 0.0525 ns | 0.0465 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  16.55 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.13 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                                        From_Double |  13.18 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
                               From_Double_AsObject |  17.99 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  15.21 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  17.95 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  14.30 ns | 0.0358 ns | 0.0317 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.15 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                                         From_Short |  13.41 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                From_Short_AsObject |  26.60 ns | 0.0113 ns | 0.0088 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  17.19 ns | 0.0287 ns | 0.0254 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  26.27 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  14.17 ns | 0.0054 ns | 0.0051 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.15 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                           From_Int |  14.42 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                                  From_Int_AsObject |  25.28 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  17.67 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  25.27 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  13.91 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.73 ns | 0.0057 ns | 0.0044 ns |      - |       0 B |
                                          From_Long |  13.64 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                 From_Long_AsObject |  25.53 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  16.83 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  25.52 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.04 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.77 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
                                         From_SByte |  13.40 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                From_SByte_AsObject |  25.26 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.98 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  25.27 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.17 ns | 0.0111 ns | 0.0092 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.64 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                                         From_Float |  13.15 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
                                From_Float_AsObject |  25.27 ns | 0.0141 ns | 0.0117 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  15.80 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  25.34 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.95 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.13 ns | 0.0156 ns | 0.0139 ns |      - |       0 B |
                                        From_String | 108.20 ns | 0.0427 ns | 0.0400 ns |      - |       0 B |
                               From_String_AsObject | 117.58 ns | 0.0499 ns | 0.0417 ns |      - |       0 B |
                                   From_String_Null |  15.81 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.39 ns | 0.3895 ns | 0.4330 ns |      - |       0 B |
                                  From_String_Empty |  16.11 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.64 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                               From_UShort_AsObject |  25.28 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  17.22 ns | 0.0653 ns | 0.0611 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  25.31 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  13.95 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.12 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                          From_UInt |  14.07 ns | 0.0361 ns | 0.0338 ns |      - |       0 B |
                                 From_UInt_AsObject |  25.54 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  16.31 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  25.54 ns | 0.0124 ns | 0.0104 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.21 ns | 0.0303 ns | 0.0283 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.11 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                         From_ULong |  13.68 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                                From_ULong_AsObject |  27.11 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  17.13 ns | 0.0616 ns | 0.0576 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  26.05 ns | 0.0208 ns | 0.0185 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.08 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.15 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                    From_NullObject |  18.74 ns | 0.0288 ns | 0.0255 ns |      - |       0 B |
                                        From_DBNull |  16.05 ns | 0.0121 ns | 0.0114 ns |      - |       0 B |
                              From_ConvertibleClass |  22.51 ns | 0.0091 ns | 0.0060 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  23.04 ns | 0.0664 ns | 0.0554 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.15 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.13 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.13 ns | 0.0223 ns | 0.0209 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  24.30 ns | 0.0408 ns | 0.0381 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  25.84 ns | 0.0174 ns | 0.0145 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.34 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  13.94 ns | 0.0031 ns | 0.0023 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.16 ns | 0.0561 ns | 0.0525 ns |      - |       0 B |
                                          From_Enum |  13.40 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                                 From_Enum_AsObject |  56.05 ns | 0.0136 ns | 0.0099 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue |  16.29 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  55.92 ns | 0.1278 ns | 0.1196 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue |  14.18 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.82 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Double.From_Char_AsObject: DefaultJob
  ConvertTo2_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_String_Empty_AsObject: DefaultJob
