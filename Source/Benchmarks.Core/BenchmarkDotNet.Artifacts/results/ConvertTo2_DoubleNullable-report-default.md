
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  15.20 ns | 0.0466 ns | 0.0436 ns |      - |       0 B |
                                 From_Bool_AsObject |  35.56 ns | 0.0621 ns | 0.0551 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  21.54 ns | 0.0376 ns | 0.0351 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  35.55 ns | 0.0397 ns | 0.0372 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  15.60 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.27 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                          From_Byte |  14.68 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                                 From_Byte_AsObject |  35.53 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  19.38 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  35.54 ns | 0.0659 ns | 0.0584 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  15.61 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.49 ns | 0.0083 ns | 0.0060 ns |      - |       0 B |
                                          From_Char |  15.88 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.87 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  13.81 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.27 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                                      From_DateTime |  14.46 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                             From_DateTime_AsObject |  24.51 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  15.34 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  24.57 ns | 0.0124 ns | 0.0103 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  15.33 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.79 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                       From_Decimal |  20.95 ns | 0.0344 ns | 0.0249 ns |      - |       0 B |
                              From_Decimal_AsObject |  41.18 ns | 0.0460 ns | 0.0430 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  32.54 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  41.14 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  16.35 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.05 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                                        From_Double |  14.80 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                               From_Double_AsObject |  29.50 ns | 0.0578 ns | 0.0541 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  14.82 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  29.10 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  14.80 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.34 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                                         From_Short |  14.67 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                From_Short_AsObject |  35.76 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  18.84 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  35.76 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.39 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.34 ns | 0.0165 ns | 0.0138 ns |      - |       0 B |
                                           From_Int |  15.63 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                  From_Int_AsObject |  35.50 ns | 0.0226 ns | 0.0200 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  18.92 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  35.53 ns | 0.0425 ns | 0.0398 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.79 ns | 0.0132 ns | 0.0110 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.26 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                                          From_Long |  13.98 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                                 From_Long_AsObject |  35.77 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  20.75 ns | 0.0250 ns | 0.0222 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  35.76 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.93 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.26 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                                         From_SByte |  15.52 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                                From_SByte_AsObject |  35.50 ns | 0.0171 ns | 0.0151 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  19.37 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  35.49 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  15.66 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.70 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
                                         From_Float |  14.66 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                From_Float_AsObject |  35.50 ns | 0.0236 ns | 0.0197 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  19.30 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  35.50 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.65 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.49 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                                        From_String | 122.98 ns | 0.1488 ns | 0.1392 ns |      - |       0 B |
                               From_String_AsObject | 132.63 ns | 0.0765 ns | 0.0715 ns |      - |       0 B |
                                   From_String_Null |  19.24 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.17 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                                  From_String_Empty |  23.15 ns | 0.0153 ns | 0.0119 ns |      - |       0 B |
                         From_String_Empty_AsObject |  26.91 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                                        From_UShort |  14.41 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                               From_UShort_AsObject |  35.50 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  18.83 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  35.50 ns | 0.0162 ns | 0.0135 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  14.78 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.84 ns | 0.0165 ns | 0.0155 ns |      - |       0 B |
                                          From_UInt |  14.15 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                                 From_UInt_AsObject |  35.76 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  21.07 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  35.78 ns | 0.0276 ns | 0.0259 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.65 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.32 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                         From_ULong |  14.54 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                                From_ULong_AsObject |  36.29 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  21.01 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  36.32 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.92 ns | 0.0433 ns | 0.0362 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.26 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
                                    From_NullObject |  17.79 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                                        From_DBNull |  15.87 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                              From_ConvertibleClass |  27.65 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  33.08 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.35 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.30 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.74 ns | 0.0181 ns | 0.0169 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  34.44 ns | 0.0205 ns | 0.0181 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.87 ns | 0.0365 ns | 0.0341 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  34.43 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  15.60 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.25 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                          From_Enum |  14.41 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                 From_Enum_AsObject |  70.94 ns | 0.0320 ns | 0.0300 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  19.10 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  71.50 ns | 0.0062 ns | 0.0048 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  15.05 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.27 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
