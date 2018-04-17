
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.82 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.27 ns | 0.0472 ns | 0.0418 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.07 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.25 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.69 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.40 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                             From_Byte |  14.67 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.25 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.82 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.28 ns | 0.0221 ns | 0.0206 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.57 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.83 ns | 0.0165 ns | 0.0155 ns |      - |       0 B |
                                             From_Char |  14.46 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                                    From_Char_AsObject |  29.07 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.32 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.05 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.60 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.35 ns | 0.0127 ns | 0.0112 ns |      - |       0 B |
                                         From_DateTime |  14.87 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.18 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.28 ns | 0.3305 ns | 0.3674 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.04 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                          From_Decimal |  28.87 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.24 ns | 0.0283 ns | 0.0251 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.27 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  44.79 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.62 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.58 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                                           From_Double |  19.12 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                                  From_Double_AsObject |  32.33 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.46 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.26 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.72 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.03 ns | 0.0076 ns | 0.0063 ns |      - |       0 B |
                                            From_Short |  14.84 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
                                   From_Short_AsObject |  28.81 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.23 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.84 ns | 0.0278 ns | 0.0246 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.03 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.07 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                                              From_Int |  16.57 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                     From_Int_AsObject |  29.61 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.70 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.60 ns | 0.0183 ns | 0.0162 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.68 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.86 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
                                             From_Long |  16.16 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                                    From_Long_AsObject |  29.61 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.51 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.62 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.50 ns | 0.0040 ns | 0.0038 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.87 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                                            From_SByte |  14.84 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.80 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.67 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.96 ns | 0.2082 ns | 0.1947 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.78 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.02 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                            From_Float |  19.62 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                   From_Float_AsObject |  32.37 ns | 0.0363 ns | 0.0340 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.64 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.40 ns | 0.0198 ns | 0.0175 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.66 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.03 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
                                           From_String |  91.91 ns | 0.0513 ns | 0.0454 ns |      - |       0 B |
                                  From_String_AsObject | 105.03 ns | 0.0559 ns | 0.0522 ns |      - |       0 B |
                                      From_String_Null |  19.59 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.93 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                                     From_String_Empty |  16.67 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.47 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.98 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.00 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  29.38 ns | 0.0212 ns | 0.0199 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.00 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.59 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                                             From_UInt |  16.42 ns | 0.0097 ns | 0.0090 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.80 ns | 0.0206 ns | 0.0192 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.66 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.80 ns | 0.0222 ns | 0.0208 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.69 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.46 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                            From_ULong |  16.16 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.64 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.49 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.61 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.41 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.46 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
                                       From_NullObject |  18.03 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                           From_DBNull |  15.89 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.21 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.11 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  20.48 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.46 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.99 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.23 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.97 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.84 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.51 ns | 0.0058 ns | 0.0048 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.44 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.55 ns | 0.0049 ns | 0.0041 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.52 ns | 0.1979 ns | 0.1755 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.12 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.37 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.42 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.12 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.41 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.61 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.47 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.84 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                                             From_Enum |  16.14 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.26 ns | 0.0647 ns | 0.0605 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.88 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  62.26 ns | 0.0212 ns | 0.0165 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.07 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.85 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                                      From_ParentClass |  17.01 ns | 0.0840 ns | 0.0744 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.70 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.72 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  19.53 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                                     From_ParentStruct |  14.52 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.83 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.41 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.30 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.73 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.05 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_String_Empty_AsObject: DefaultJob
