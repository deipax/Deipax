
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.52 ns | 0.0796 ns | 0.0745 ns |  15.51 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.25 ns | 0.0050 ns | 0.0042 ns |  28.25 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.09 ns | 0.0267 ns | 0.0223 ns |  15.09 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.26 ns | 0.0205 ns | 0.0192 ns |  28.25 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.67 ns | 0.0028 ns | 0.0022 ns |  14.67 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.85 ns | 0.0170 ns | 0.0151 ns |  17.84 ns |      - |       0 B |
                                             From_Byte |  14.46 ns | 0.0058 ns | 0.0049 ns |  14.46 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.26 ns | 0.0175 ns | 0.0155 ns |  28.25 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  15.05 ns | 0.0129 ns | 0.0121 ns |  15.05 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.25 ns | 0.0020 ns | 0.0017 ns |  28.25 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.53 ns | 0.0024 ns | 0.0020 ns |  16.53 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.32 ns | 0.0074 ns | 0.0069 ns |  18.32 ns |      - |       0 B |
                                             From_Char |  14.53 ns | 0.0039 ns | 0.0034 ns |  14.53 ns |      - |       0 B |
                                    From_Char_AsObject |  29.07 ns | 0.0308 ns | 0.0288 ns |  29.06 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.95 ns | 0.0028 ns | 0.0023 ns |  14.95 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.08 ns | 0.0350 ns | 0.0310 ns |  29.09 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.57 ns | 0.0090 ns | 0.0080 ns |  14.57 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.00 ns | 0.0145 ns | 0.0135 ns |  18.00 ns |      - |       0 B |
                                         From_DateTime |  14.82 ns | 0.0033 ns | 0.0027 ns |  14.82 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.19 ns | 0.0031 ns | 0.0024 ns |  15.19 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.19 ns | 0.0041 ns | 0.0036 ns |  15.19 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  21.04 ns | 0.0210 ns | 0.0186 ns |  21.03 ns |      - |       0 B |
                                          From_Decimal |  28.17 ns | 0.0126 ns | 0.0112 ns |  28.17 ns |      - |       0 B |
                                 From_Decimal_AsObject |  39.70 ns | 0.0214 ns | 0.0200 ns |  39.69 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  30.86 ns | 0.0105 ns | 0.0088 ns |  30.87 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.62 ns | 0.0207 ns | 0.0194 ns |  39.62 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.62 ns | 0.0062 ns | 0.0055 ns |  15.62 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.83 ns | 0.0128 ns | 0.0120 ns |  17.83 ns |      - |       0 B |
                                           From_Double |  17.23 ns | 0.0086 ns | 0.0076 ns |  17.23 ns |      - |       0 B |
                                  From_Double_AsObject |  30.17 ns | 0.0246 ns | 0.0230 ns |  30.17 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.20 ns | 0.0105 ns | 0.0098 ns |  19.20 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.25 ns | 0.0244 ns | 0.0229 ns |  30.24 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.44 ns | 0.0577 ns | 0.0450 ns |  15.43 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.87 ns | 0.0180 ns | 0.0168 ns |  17.87 ns |      - |       0 B |
                                            From_Short |  14.47 ns | 0.0038 ns | 0.0032 ns |  14.47 ns |      - |       0 B |
                                   From_Short_AsObject |  28.24 ns | 0.0016 ns | 0.0014 ns |  28.24 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.68 ns | 0.0130 ns | 0.0122 ns |  15.68 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.27 ns | 0.0360 ns | 0.0337 ns |  28.25 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.58 ns | 0.0091 ns | 0.0081 ns |  16.58 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.92 ns | 0.0142 ns | 0.0133 ns |  17.92 ns |      - |       0 B |
                                              From_Int |  14.57 ns | 0.0028 ns | 0.0025 ns |  14.57 ns |      - |       0 B |
                                     From_Int_AsObject |  29.38 ns | 0.0298 ns | 0.0279 ns |  29.37 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.15 ns | 0.0017 ns | 0.0013 ns |  14.15 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.96 ns | 0.0244 ns | 0.0228 ns |  29.95 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.99 ns | 0.0021 ns | 0.0017 ns |  13.99 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.69 ns | 0.0026 ns | 0.0021 ns |  18.69 ns |      - |       0 B |
                                             From_Long |  16.39 ns | 0.0011 ns | 0.0009 ns |  16.39 ns |      - |       0 B |
                                    From_Long_AsObject |  29.60 ns | 0.0186 ns | 0.0174 ns |  29.59 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.49 ns | 0.0118 ns | 0.0105 ns |  17.49 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.61 ns | 0.0253 ns | 0.0237 ns |  29.59 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.56 ns | 0.0026 ns | 0.0023 ns |  15.55 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.86 ns | 0.0125 ns | 0.0117 ns |  17.86 ns |      - |       0 B |
                                            From_SByte |  14.46 ns | 0.0115 ns | 0.0107 ns |  14.45 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.26 ns | 0.0193 ns | 0.0180 ns |  28.25 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.83 ns | 0.0004 ns | 0.0003 ns |  14.83 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.25 ns | 0.0132 ns | 0.0110 ns |  28.25 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.66 ns | 0.0065 ns | 0.0061 ns |  14.66 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.87 ns | 0.0123 ns | 0.0115 ns |  18.87 ns |      - |       0 B |
                                            From_Float |  19.10 ns | 0.0217 ns | 0.0192 ns |  19.10 ns |      - |       0 B |
                                   From_Float_AsObject |  30.55 ns | 0.0360 ns | 0.0337 ns |  30.55 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  17.49 ns | 0.0028 ns | 0.0023 ns |  17.49 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  31.04 ns | 0.0081 ns | 0.0076 ns |  31.05 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.48 ns | 0.0099 ns | 0.0093 ns |  16.47 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.00 ns | 0.0101 ns | 0.0090 ns |  18.00 ns |      - |       0 B |
                                           From_String |  94.02 ns | 0.0477 ns | 0.0446 ns |  94.02 ns |      - |       0 B |
                                  From_String_AsObject | 104.43 ns | 0.0486 ns | 0.0454 ns | 104.40 ns |      - |       0 B |
                                      From_String_Null |  17.81 ns | 0.0135 ns | 0.0127 ns |  17.81 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.03 ns | 0.0012 ns | 0.0009 ns |  18.03 ns |      - |       0 B |
                                     From_String_Empty |  16.68 ns | 0.0032 ns | 0.0027 ns |  16.68 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  15.50 ns | 0.0033 ns | 0.0029 ns |  15.50 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.25 ns | 0.0067 ns | 0.0056 ns |  28.25 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.94 ns | 0.0109 ns | 0.0102 ns |  14.94 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.25 ns | 0.0028 ns | 0.0022 ns |  28.25 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.66 ns | 0.0016 ns | 0.0013 ns |  14.66 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.97 ns | 0.0019 ns | 0.0015 ns |  18.97 ns |      - |       0 B |
                                             From_UInt |  15.10 ns | 0.0097 ns | 0.0091 ns |  15.09 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.79 ns | 0.0134 ns | 0.0119 ns |  28.79 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.27 ns | 0.0095 ns | 0.0089 ns |  16.27 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.80 ns | 0.0178 ns | 0.0166 ns |  28.79 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.87 ns | 0.0126 ns | 0.0118 ns |  14.87 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.07 ns | 0.0060 ns | 0.0056 ns |  18.06 ns |      - |       0 B |
                                            From_ULong |  16.13 ns | 0.0106 ns | 0.0100 ns |  16.13 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.64 ns | 0.0283 ns | 0.0265 ns |  29.63 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.50 ns | 0.0127 ns | 0.0113 ns |  17.49 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.62 ns | 0.0146 ns | 0.0137 ns |  29.62 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.41 ns | 0.0105 ns | 0.0099 ns |  15.41 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.05 ns | 0.0130 ns | 0.0122 ns |  18.05 ns |      - |       0 B |
                                       From_NullObject |  18.44 ns | 0.0096 ns | 0.0090 ns |  18.44 ns |      - |       0 B |
                                           From_DBNull |  16.65 ns | 0.0073 ns | 0.0065 ns |  16.65 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.20 ns | 0.0146 ns | 0.0137 ns |  26.21 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.10 ns | 0.0171 ns | 0.0152 ns |  26.10 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.71 ns | 0.0367 ns | 0.0307 ns |  19.72 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.88 ns | 0.0073 ns | 0.0068 ns |  17.88 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.91 ns | 0.0135 ns | 0.0126 ns |  16.91 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.24 ns | 0.0176 ns | 0.0165 ns |  23.25 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.06 ns | 0.0030 ns | 0.0025 ns |  17.06 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.87 ns | 0.0101 ns | 0.0095 ns |  17.86 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.16 ns | 0.0070 ns | 0.0065 ns |  24.15 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.43 ns | 0.0105 ns | 0.0098 ns |  27.44 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.58 ns | 0.0300 ns | 0.0281 ns |  26.58 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.43 ns | 0.0088 ns | 0.0073 ns |  27.43 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.12 ns | 0.0117 ns | 0.0110 ns |  15.12 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.86 ns | 0.0101 ns | 0.0094 ns |  17.85 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.56 ns | 0.0164 ns | 0.0146 ns |  14.56 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.26 ns | 0.0109 ns | 0.0102 ns |  23.27 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.48 ns | 0.0103 ns | 0.0096 ns |  14.47 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.22 ns | 0.0103 ns | 0.0092 ns |  23.22 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.44 ns | 0.0143 ns | 0.0134 ns |  15.44 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.87 ns | 0.0108 ns | 0.0101 ns |  17.87 ns |      - |       0 B |
                                             From_Enum |  14.55 ns | 0.0064 ns | 0.0060 ns |  14.55 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.13 ns | 0.0450 ns | 0.0421 ns |  60.11 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.34 ns | 0.0082 ns | 0.0077 ns |  20.34 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.15 ns | 0.0354 ns | 0.0331 ns |  60.13 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.40 ns | 0.0230 ns | 0.0204 ns |  16.40 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.10 ns | 0.1022 ns | 0.0906 ns |  18.11 ns |      - |       0 B |
                                      From_ParentClass |  18.83 ns | 0.4824 ns | 1.3686 ns |  18.09 ns |      - |       0 B |
                             From_ParentClass_AsObject |  27.22 ns | 0.0339 ns | 0.0265 ns |  27.21 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.97 ns | 0.0193 ns | 0.0171 ns |  16.97 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.78 ns | 0.0121 ns | 0.0113 ns |  18.78 ns |      - |       0 B |
                                     From_ParentStruct |  14.46 ns | 0.0125 ns | 0.0104 ns |  14.46 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.73 ns | 0.0888 ns | 0.0830 ns |  23.74 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.43 ns | 0.0134 ns | 0.0125 ns |  14.43 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.10 ns | 0.0265 ns | 0.0235 ns |  24.09 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.46 ns | 0.0076 ns | 0.0071 ns |  14.46 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.84 ns | 0.0106 ns | 0.0088 ns |  17.83 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_String_Empty_AsObject: DefaultJob
