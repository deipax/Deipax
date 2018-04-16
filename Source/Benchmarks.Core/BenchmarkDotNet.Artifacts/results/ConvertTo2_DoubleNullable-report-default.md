
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  18.39 ns | 0.1360 ns | 0.1205 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.25 ns | 0.0407 ns | 0.0360 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  20.46 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  31.23 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.24 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.68 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                             From_Byte |  16.14 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                    From_Byte_AsObject |  31.23 ns | 0.0335 ns | 0.0313 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  20.14 ns | 0.0105 ns | 0.0082 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  31.25 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.24 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.68 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                             From_Char |  16.16 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.76 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.56 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  19.05 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
                                         From_DateTime |  15.59 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.88 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.88 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  20.05 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                          From_Decimal |  21.84 ns | 0.0255 ns | 0.0213 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.88 ns | 0.0223 ns | 0.0197 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.71 ns | 0.0239 ns | 0.0224 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.87 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.12 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.29 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                                           From_Double |  16.16 ns | 0.0208 ns | 0.0185 ns |      - |       0 B |
                                  From_Double_AsObject |  31.65 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  16.41 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.57 ns | 0.0107 ns | 0.0083 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.42 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.68 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                            From_Short |  16.13 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                                   From_Short_AsObject |  31.48 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  21.60 ns | 0.0396 ns | 0.0370 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.48 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.68 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.68 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                              From_Int |  15.75 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
                                     From_Int_AsObject |  31.22 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.91 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.21 ns | 0.0052 ns | 0.0041 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.84 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.70 ns | 0.0041 ns | 0.0035 ns |      - |       0 B |
                                             From_Long |  15.74 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                                    From_Long_AsObject |  31.48 ns | 0.0041 ns | 0.0035 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  20.57 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.48 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.30 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.67 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                            From_SByte |  17.24 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                   From_SByte_AsObject |  31.24 ns | 0.0402 ns | 0.0376 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  19.92 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  31.23 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.22 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.35 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                                            From_Float |  15.69 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                   From_Float_AsObject |  31.22 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.91 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  31.21 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  18.56 ns | 0.0255 ns | 0.0199 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.69 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                           From_String | 114.62 ns | 0.0410 ns | 0.0364 ns |      - |       0 B |
                                  From_String_AsObject | 128.17 ns | 0.0894 ns | 0.0837 ns |      - |       0 B |
                                      From_String_Null |  18.27 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.54 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                     From_String_Empty |  17.76 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.13 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
                                  From_UShort_AsObject |  31.22 ns | 0.0111 ns | 0.0087 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  20.09 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  31.21 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.90 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.68 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                             From_UInt |  16.27 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                    From_UInt_AsObject |  31.48 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  20.19 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  31.48 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.68 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  19.29 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                                            From_ULong |  16.40 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.03 ns | 0.0258 ns | 0.0242 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  20.79 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  32.02 ns | 0.0035 ns | 0.0030 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.22 ns | 0.0053 ns | 0.0045 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.81 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                       From_NullObject |  19.39 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                                           From_DBNull |  17.74 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                 From_ConvertibleClass |  31.39 ns | 0.0196 ns | 0.0184 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  29.06 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.82 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.68 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.30 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.73 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.30 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  19.27 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.96 ns | 0.0096 ns | 0.0080 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.43 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.58 ns | 0.0359 ns | 0.0336 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.42 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.23 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  20.14 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.88 ns | 0.0199 ns | 0.0177 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.34 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.88 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.55 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.89 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  19.17 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                             From_Enum |  15.58 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.94 ns | 0.0536 ns | 0.0501 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.92 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  63.04 ns | 0.0734 ns | 0.0573 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.67 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.61 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
                                      From_ParentClass |  17.94 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.91 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.88 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.70 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
                                     From_ParentStruct |  16.39 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.92 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.87 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.16 ns | 0.0141 ns | 0.0118 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.87 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.70 ns | 0.0149 ns | 0.0116 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_String_Empty_AsObject: DefaultJob
