
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.41 ns | 0.1099 ns | 0.0974 ns |  15.40 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.26 ns | 0.0190 ns | 0.0168 ns |  28.25 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.53 ns | 0.0432 ns | 0.0404 ns |  17.53 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.26 ns | 0.0157 ns | 0.0146 ns |  28.26 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  19.41 ns | 0.0137 ns | 0.0128 ns |  19.41 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.02 ns | 0.0070 ns | 0.0062 ns |  18.01 ns |      - |       0 B |
                                             From_Byte |  15.42 ns | 0.0113 ns | 0.0105 ns |  15.42 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.27 ns | 0.0222 ns | 0.0197 ns |  28.27 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.45 ns | 0.0519 ns | 0.0486 ns |  17.44 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.27 ns | 0.0145 ns | 0.0135 ns |  28.28 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.07 ns | 0.0130 ns | 0.0122 ns |  15.08 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.93 ns | 0.0223 ns | 0.0197 ns |  17.93 ns |      - |       0 B |
                                             From_Char |  14.68 ns | 0.0140 ns | 0.0131 ns |  14.68 ns |      - |       0 B |
                                    From_Char_AsObject |  29.09 ns | 0.0199 ns | 0.0176 ns |  29.09 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.49 ns | 0.0137 ns | 0.0128 ns |  17.49 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.10 ns | 0.0249 ns | 0.0208 ns |  29.10 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.08 ns | 0.0162 ns | 0.0151 ns |  15.08 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.92 ns | 0.0160 ns | 0.0150 ns |  18.92 ns |      - |       0 B |
                                         From_DateTime |  15.02 ns | 0.0037 ns | 0.0031 ns |  15.02 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.01 ns | 0.0091 ns | 0.0080 ns |  15.01 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.01 ns | 0.0147 ns | 0.0123 ns |  15.01 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.85 ns | 0.0194 ns | 0.0182 ns |  17.85 ns |      - |       0 B |
                                          From_Decimal |  28.12 ns | 0.0215 ns | 0.0201 ns |  28.12 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.03 ns | 0.0344 ns | 0.0322 ns |  40.03 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  37.28 ns | 0.0202 ns | 0.0189 ns |  37.28 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.60 ns | 0.0367 ns | 0.0325 ns |  39.60 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.31 ns | 0.0098 ns | 0.0091 ns |  16.30 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.02 ns | 0.0183 ns | 0.0171 ns |  18.02 ns |      - |       0 B |
                                           From_Double |  17.30 ns | 0.0018 ns | 0.0014 ns |  17.30 ns |      - |       0 B |
                                  From_Double_AsObject |  30.17 ns | 0.0169 ns | 0.0132 ns |  30.18 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.91 ns | 0.0117 ns | 0.0109 ns |  21.90 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.19 ns | 0.0403 ns | 0.0377 ns |  30.19 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.13 ns | 0.0090 ns | 0.0084 ns |  16.13 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.72 ns | 0.0179 ns | 0.0159 ns |  18.72 ns |      - |       0 B |
                                            From_Short |  14.68 ns | 0.0113 ns | 0.0106 ns |  14.67 ns |      - |       0 B |
                                   From_Short_AsObject |  28.28 ns | 0.0285 ns | 0.0238 ns |  28.29 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.41 ns | 0.0522 ns | 0.0488 ns |  18.41 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.28 ns | 0.0134 ns | 0.0126 ns |  28.28 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.27 ns | 0.0166 ns | 0.0155 ns |  15.27 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.94 ns | 0.0155 ns | 0.0145 ns |  18.94 ns |      - |       0 B |
                                              From_Int |  14.58 ns | 0.0136 ns | 0.0127 ns |  14.57 ns |      - |       0 B |
                                     From_Int_AsObject |  29.39 ns | 0.0143 ns | 0.0119 ns |  29.38 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.15 ns | 0.0106 ns | 0.0099 ns |  14.15 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.55 ns | 0.0405 ns | 0.0379 ns |  29.55 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.15 ns | 0.0157 ns | 0.0147 ns |  14.14 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.87 ns | 0.0105 ns | 0.0098 ns |  17.88 ns |      - |       0 B |
                                             From_Long |  15.97 ns | 0.0101 ns | 0.0094 ns |  15.98 ns |      - |       0 B |
                                    From_Long_AsObject |  29.64 ns | 0.0300 ns | 0.0281 ns |  29.65 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  20.17 ns | 0.0126 ns | 0.0112 ns |  20.18 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.62 ns | 0.0156 ns | 0.0146 ns |  29.62 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.74 ns | 0.0117 ns | 0.0110 ns |  16.74 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.88 ns | 0.0188 ns | 0.0176 ns |  17.88 ns |      - |       0 B |
                                            From_SByte |  14.68 ns | 0.0050 ns | 0.0039 ns |  14.68 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.28 ns | 0.0135 ns | 0.0127 ns |  28.29 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.61 ns | 0.0226 ns | 0.0200 ns |  17.62 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.30 ns | 0.0619 ns | 0.0579 ns |  28.29 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.14 ns | 0.0094 ns | 0.0088 ns |  15.13 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.86 ns | 0.0120 ns | 0.0112 ns |  17.86 ns |      - |       0 B |
                                            From_Float |  17.85 ns | 0.3836 ns | 0.6194 ns |  17.52 ns |      - |       0 B |
                                   From_Float_AsObject |  30.56 ns | 0.0582 ns | 0.0486 ns |  30.57 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.40 ns | 0.0164 ns | 0.0128 ns |  20.40 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.55 ns | 0.0439 ns | 0.0411 ns |  30.56 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.18 ns | 0.0134 ns | 0.0125 ns |  16.18 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.18 ns | 0.0070 ns | 0.0062 ns |  18.17 ns |      - |       0 B |
                                           From_String |  93.27 ns | 0.0693 ns | 0.0648 ns |  93.26 ns |      - |       0 B |
                                  From_String_AsObject | 104.41 ns | 0.0301 ns | 0.0267 ns | 104.41 ns |      - |       0 B |
                                      From_String_Null |  16.35 ns | 0.0153 ns | 0.0143 ns |  16.34 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.86 ns | 0.0036 ns | 0.0030 ns |  17.86 ns |      - |       0 B |
                                     From_String_Empty |  17.39 ns | 0.0081 ns | 0.0068 ns |  17.39 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.53 ns | 0.0044 ns | 0.0039 ns |  14.53 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.25 ns | 0.0041 ns | 0.0034 ns |  28.25 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.48 ns | 0.0350 ns | 0.0327 ns |  17.49 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.26 ns | 0.0086 ns | 0.0077 ns |  28.25 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.19 ns | 0.0086 ns | 0.0080 ns |  15.19 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.87 ns | 0.0024 ns | 0.0020 ns |  17.87 ns |      - |       0 B |
                                             From_UInt |  15.04 ns | 0.0024 ns | 0.0019 ns |  15.04 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.80 ns | 0.0197 ns | 0.0184 ns |  28.79 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.81 ns | 0.0066 ns | 0.0055 ns |  17.81 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.79 ns | 0.0094 ns | 0.0078 ns |  28.80 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.85 ns | 0.0124 ns | 0.0116 ns |  15.85 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.92 ns | 0.0088 ns | 0.0082 ns |  17.91 ns |      - |       0 B |
                                            From_ULong |  15.60 ns | 0.0112 ns | 0.0105 ns |  15.59 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.65 ns | 0.0200 ns | 0.0177 ns |  29.65 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.63 ns | 0.0108 ns | 0.0096 ns |  19.62 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.62 ns | 0.0189 ns | 0.0177 ns |  29.63 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  19.05 ns | 0.0091 ns | 0.0085 ns |  19.06 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.39 ns | 0.0208 ns | 0.0195 ns |  18.40 ns |      - |       0 B |
                                       From_NullObject |  17.89 ns | 0.0143 ns | 0.0127 ns |  17.88 ns |      - |       0 B |
                                           From_DBNull |  16.03 ns | 0.0072 ns | 0.0067 ns |  16.03 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.19 ns | 0.0149 ns | 0.0132 ns |  26.19 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.11 ns | 0.0069 ns | 0.0061 ns |  26.11 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.85 ns | 0.0283 ns | 0.0265 ns |  18.84 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.92 ns | 0.0164 ns | 0.0153 ns |  17.93 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.94 ns | 0.0196 ns | 0.0184 ns |  16.94 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.92 ns | 0.0095 ns | 0.0080 ns |  23.92 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.74 ns | 0.0032 ns | 0.0027 ns |  17.74 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.50 ns | 0.0030 ns | 0.0023 ns |  18.50 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.64 ns | 0.0092 ns | 0.0077 ns |  23.64 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.43 ns | 0.0041 ns | 0.0032 ns |  27.43 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.84 ns | 0.0097 ns | 0.0090 ns |  26.84 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.43 ns | 0.0053 ns | 0.0047 ns |  27.42 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.12 ns | 0.0070 ns | 0.0062 ns |  15.11 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  22.27 ns | 0.0242 ns | 0.0226 ns |  22.27 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.42 ns | 0.0113 ns | 0.0105 ns |  15.42 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.23 ns | 0.0063 ns | 0.0056 ns |  23.23 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.67 ns | 0.0127 ns | 0.0112 ns |  14.67 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.78 ns | 0.0169 ns | 0.0150 ns |  23.78 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.76 ns | 0.0179 ns | 0.0168 ns |  14.77 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.46 ns | 0.0069 ns | 0.0058 ns |  18.46 ns |      - |       0 B |
                                             From_Enum |  14.73 ns | 0.0105 ns | 0.0098 ns |  14.72 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.10 ns | 0.0351 ns | 0.0329 ns |  60.12 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.42 ns | 0.0094 ns | 0.0083 ns |  17.42 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.57 ns | 0.0408 ns | 0.0381 ns |  60.55 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.22 ns | 0.0152 ns | 0.0142 ns |  15.22 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.84 ns | 0.0030 ns | 0.0023 ns |  17.84 ns |      - |       0 B |
                                      From_ParentClass |  17.71 ns | 0.0073 ns | 0.0068 ns |  17.71 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.66 ns | 0.0116 ns | 0.0103 ns |  23.65 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.01 ns | 0.0124 ns | 0.0110 ns |  17.01 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.01 ns | 0.0125 ns | 0.0117 ns |  18.00 ns |      - |       0 B |
                                     From_ParentStruct |  14.42 ns | 0.0058 ns | 0.0048 ns |  14.42 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.14 ns | 0.0148 ns | 0.0138 ns |  24.13 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.68 ns | 0.0134 ns | 0.0125 ns |  14.69 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.76 ns | 0.0172 ns | 0.0161 ns |  23.76 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.68 ns | 0.0063 ns | 0.0059 ns |  14.68 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.38 ns | 0.0030 ns | 0.0022 ns |  18.38 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_String_Empty_AsObject: DefaultJob
