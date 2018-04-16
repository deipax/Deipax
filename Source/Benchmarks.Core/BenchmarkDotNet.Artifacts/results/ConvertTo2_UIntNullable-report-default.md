
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.79 ns | 0.0749 ns | 0.0701 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.28 ns | 0.0209 ns | 0.0186 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  19.04 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.27 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.23 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.39 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                             From_Byte |  14.68 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.25 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.63 ns | 0.0235 ns | 0.0196 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.27 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.08 ns | 0.0104 ns | 0.0093 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.83 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                                             From_Char |  15.19 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                    From_Char_AsObject |  29.07 ns | 0.0224 ns | 0.0175 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.56 ns | 0.0177 ns | 0.0138 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.06 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.07 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.03 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                         From_DateTime |  14.91 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.14 ns | 0.2430 ns | 0.2029 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  17.57 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.01 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                                          From_Decimal |  27.88 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                                 From_Decimal_AsObject |  38.51 ns | 0.0360 ns | 0.0301 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  37.01 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.51 ns | 0.0254 ns | 0.0238 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.04 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.41 ns | 0.0142 ns | 0.0119 ns |      - |       0 B |
                                           From_Double |  16.90 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                  From_Double_AsObject |  29.87 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.67 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.98 ns | 0.0220 ns | 0.0184 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.86 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.01 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                                            From_Short |  15.59 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
                                   From_Short_AsObject |  28.81 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.63 ns | 0.0330 ns | 0.0309 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.81 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.08 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.36 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                              From_Int |  14.72 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                     From_Int_AsObject |  28.81 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.71 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  28.82 ns | 0.0268 ns | 0.0250 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.21 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.22 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                             From_Long |  15.89 ns | 0.0181 ns | 0.0161 ns |      - |       0 B |
                                    From_Long_AsObject |  29.62 ns | 0.0250 ns | 0.0221 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.91 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.62 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.15 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.36 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |
                                            From_SByte |  14.96 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.81 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.64 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.81 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.11 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.14 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                            From_Float |  17.69 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                   From_Float_AsObject |  30.15 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.45 ns | 0.0782 ns | 0.0653 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.14 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.13 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.85 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                           From_String |  89.66 ns | 0.0389 ns | 0.0364 ns |      - |       0 B |
                                  From_String_AsObject | 102.28 ns | 0.0423 ns | 0.0353 ns |      - |       0 B |
                                      From_String_Null |  16.33 ns | 0.0125 ns | 0.0110 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.22 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
                                     From_String_Empty |  16.92 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.43 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.28 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.60 ns | 0.0398 ns | 0.0353 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.28 ns | 0.0314 ns | 0.0293 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.20 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.84 ns | 0.0056 ns | 0.0043 ns |      - |       0 B |
                                             From_UInt |  14.69 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.56 ns | 0.0487 ns | 0.0455 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  13.89 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.04 ns | 0.0430 ns | 0.0381 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.05 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.82 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                                            From_ULong |  15.05 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.82 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.29 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.84 ns | 0.0392 ns | 0.0366 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.89 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.40 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
                                       From_NullObject |  18.02 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                           From_DBNull |  16.02 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.20 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.11 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.72 ns | 0.0222 ns | 0.0208 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.87 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.00 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.24 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.99 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.01 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.65 ns | 0.0071 ns | 0.0063 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.43 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.88 ns | 0.0277 ns | 0.0259 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.44 ns | 0.0123 ns | 0.0116 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.29 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.88 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.43 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.14 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.66 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.08 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.66 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.52 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                             From_Enum |  15.51 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.30 ns | 0.0245 ns | 0.0217 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.75 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.88 ns | 0.0116 ns | 0.0097 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.20 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.27 ns | 0.0885 ns | 0.0784 ns |      - |       0 B |
                                      From_ParentClass |  17.31 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.69 ns | 0.1878 ns | 0.1665 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.92 ns | 0.0139 ns | 0.0124 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.91 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
                                     From_ParentStruct |  16.80 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.75 ns | 0.0279 ns | 0.0248 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.62 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.08 ns | 0.0834 ns | 0.0780 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.68 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.54 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_String_Empty_AsObject: DefaultJob
