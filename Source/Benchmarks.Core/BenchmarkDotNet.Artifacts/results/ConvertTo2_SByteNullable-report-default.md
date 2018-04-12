
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.04 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.89 ns | 0.0532 ns | 0.0472 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.55 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.87 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  15.37 ns | 0.0187 ns | 0.0165 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.89 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                          From_Byte |  14.05 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                 From_Byte_AsObject |  29.36 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.84 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  28.97 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.30 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  19.38 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                          From_Char |  14.06 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                 From_Char_AsObject |  29.83 ns | 0.0758 ns | 0.0709 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  17.97 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  29.84 ns | 0.0176 ns | 0.0138 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  14.89 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  19.30 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                                      From_DateTime |  14.80 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.33 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.30 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.74 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
                                       From_Decimal |  27.55 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                              From_Decimal_AsObject |  40.23 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  38.17 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  38.97 ns | 0.0398 ns | 0.0311 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.33 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.32 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                        From_Double |  17.86 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                               From_Double_AsObject |  31.92 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  21.89 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  31.79 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.12 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  20.70 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                         From_Short |  15.30 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
                                From_Short_AsObject |  29.63 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.64 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  29.48 ns | 0.0180 ns | 0.0150 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  14.28 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.78 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
                                           From_Int |  15.05 ns | 0.0113 ns | 0.0095 ns |      - |       0 B |
                                  From_Int_AsObject |  29.24 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  17.88 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.36 ns | 0.0260 ns | 0.0244 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.31 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.75 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                                          From_Long |  15.30 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                 From_Long_AsObject |  29.78 ns | 0.0393 ns | 0.0367 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.88 ns | 0.0209 ns | 0.0185 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.68 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.55 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.77 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                         From_SByte |  14.94 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                From_SByte_AsObject |  28.78 ns | 0.0206 ns | 0.0192 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  13.35 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  28.73 ns | 0.0386 ns | 0.0361 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.19 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  19.58 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                                         From_Float |  18.52 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                                From_Float_AsObject |  32.03 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  20.98 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  32.33 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.30 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.87 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                                        From_String |  93.09 ns | 0.0343 ns | 0.0321 ns |      - |       0 B |
                               From_String_AsObject | 104.77 ns | 0.0354 ns | 0.0332 ns |      - |       0 B |
                                   From_String_Null |  16.41 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.75 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                  From_String_Empty |  16.69 ns | 0.0104 ns | 0.0093 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  14.16 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                               From_UShort_AsObject |  28.76 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.93 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  28.86 ns | 0.0235 ns | 0.0208 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.33 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.46 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                                          From_UInt |  14.29 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                                 From_UInt_AsObject |  28.86 ns | 0.0199 ns | 0.0177 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  17.88 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  28.86 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.94 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.90 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                         From_ULong |  14.04 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                                From_ULong_AsObject |  29.06 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  18.60 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  29.18 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.55 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.74 ns | 0.0058 ns | 0.0045 ns |      - |       0 B |
                                    From_NullObject |  17.85 ns | 0.0043 ns | 0.0033 ns |      - |       0 B |
                                        From_DBNull |  19.36 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                              From_ConvertibleClass |  24.66 ns | 0.0394 ns | 0.0369 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.52 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.77 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.42 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                             From_ConvertibleStruct |  23.67 ns | 0.0366 ns | 0.0342 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.80 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  24.95 ns | 0.0050 ns | 0.0047 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.80 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  14.47 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  19.57 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                                          From_Enum |  15.05 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                 From_Enum_AsObject |  60.27 ns | 0.0084 ns | 0.0075 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  20.12 ns | 0.1031 ns | 0.0964 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  60.05 ns | 0.0110 ns | 0.0103 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.32 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.74 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_String_Empty_AsObject: DefaultJob
