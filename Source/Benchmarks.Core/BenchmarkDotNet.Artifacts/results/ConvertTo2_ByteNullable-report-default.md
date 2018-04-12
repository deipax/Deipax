
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.02 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.88 ns | 0.0241 ns | 0.0201 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  18.82 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.88 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  15.33 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.90 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                          From_Byte |  14.93 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                 From_Byte_AsObject |  28.90 ns | 0.0679 ns | 0.0635 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  14.05 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  29.13 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  13.28 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.00 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                                          From_Char |  15.60 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                 From_Char_AsObject |  29.51 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  16.86 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  29.55 ns | 0.0533 ns | 0.0498 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  16.11 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.37 ns | 0.0165 ns | 0.0138 ns |      - |       0 B |
                                      From_DateTime |  14.29 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.28 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.28 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.87 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                       From_Decimal |  27.56 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                              From_Decimal_AsObject |  39.85 ns | 0.0254 ns | 0.0237 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  36.03 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  39.83 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.34 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.88 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                        From_Double |  18.35 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                               From_Double_AsObject |  32.37 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  21.43 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  32.38 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.55 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  20.28 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
                                         From_Short |  15.30 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
                                From_Short_AsObject |  29.63 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  19.39 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  29.51 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.33 ns | 0.0156 ns | 0.0139 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.88 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                           From_Int |  15.30 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                  From_Int_AsObject |  29.57 ns | 0.0208 ns | 0.0185 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  18.83 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  30.50 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  15.41 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.88 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                                          From_Long |  15.32 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                 From_Long_AsObject |  29.50 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  19.92 ns | 0.0119 ns | 0.0093 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.55 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  16.59 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.99 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                         From_SByte |  14.05 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                                From_SByte_AsObject |  28.95 ns | 0.0650 ns | 0.0608 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.84 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  28.75 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.31 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.97 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                                         From_Float |  18.86 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                From_Float_AsObject |  32.91 ns | 0.0253 ns | 0.0197 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  21.19 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  32.92 ns | 0.0345 ns | 0.0322 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.28 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.99 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                        From_String |  90.53 ns | 0.0612 ns | 0.0572 ns |      - |       0 B |
                               From_String_AsObject | 102.66 ns | 0.0404 ns | 0.0378 ns |      - |       0 B |
                                   From_String_Null |  16.52 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.88 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                  From_String_Empty |  16.68 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  14.11 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                               From_UShort_AsObject |  28.86 ns | 0.0179 ns | 0.0158 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  17.92 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  28.73 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.34 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.36 ns | 0.0082 ns | 0.0072 ns |      - |       0 B |
                                          From_UInt |  14.75 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                                 From_UInt_AsObject |  28.85 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  16.84 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  28.74 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.28 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.04 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                         From_ULong |  16.45 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                From_ULong_AsObject |  29.50 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  19.98 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  29.50 ns | 0.0175 ns | 0.0146 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.57 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.03 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                    From_NullObject |  17.99 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                        From_DBNull |  17.95 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                              From_ConvertibleClass |  24.65 ns | 0.0358 ns | 0.0335 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.53 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.68 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.00 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.62 ns | 0.0011 ns | 0.0008 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.80 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  24.95 ns | 0.0032 ns | 0.0028 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.79 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  14.31 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.91 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                          From_Enum |  15.30 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                 From_Enum_AsObject |  60.73 ns | 0.0245 ns | 0.0229 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.12 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  60.84 ns | 0.0052 ns | 0.0040 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.28 ns | 0.0107 ns | 0.0101 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.89 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_String_Empty_AsObject: DefaultJob
