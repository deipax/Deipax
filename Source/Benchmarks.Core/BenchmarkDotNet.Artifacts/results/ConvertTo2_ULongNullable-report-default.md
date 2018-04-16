
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  17.32 ns | 0.1202 ns | 0.1066 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.01 ns | 0.0718 ns | 0.0636 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  20.43 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.98 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.22 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  19.33 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                             From_Byte |  16.14 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.95 ns | 0.0075 ns | 0.0062 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  19.91 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.95 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.22 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.39 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
                                             From_Char |  16.15 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                                    From_Char_AsObject |  31.81 ns | 0.0657 ns | 0.0549 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  19.80 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  31.79 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  16.68 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.70 ns | 0.0067 ns | 0.0060 ns |      - |       0 B |
                                         From_DateTime |  15.59 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.41 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  20.54 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  20.19 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
                                          From_Decimal |  26.83 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.99 ns | 0.0375 ns | 0.0313 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  34.65 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.99 ns | 0.0556 ns | 0.0520 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.15 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.70 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                           From_Double |  19.38 ns | 0.0344 ns | 0.0305 ns |      - |       0 B |
                                  From_Double_AsObject |  35.26 ns | 0.0246 ns | 0.0205 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  24.93 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.25 ns | 0.0121 ns | 0.0094 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  17.23 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.68 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                                            From_Short |  16.94 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                                   From_Short_AsObject |  31.48 ns | 0.0055 ns | 0.0048 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  19.91 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.49 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  18.26 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.70 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
                                              From_Int |  16.40 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                     From_Int_AsObject |  32.65 ns | 0.0371 ns | 0.0309 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.90 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.48 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.67 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.68 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                             From_Long |  17.38 ns | 0.0107 ns | 0.0101 ns |      - |       0 B |
                                    From_Long_AsObject |  31.48 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  21.00 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.42 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.21 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.81 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                            From_SByte |  16.94 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                                   From_SByte_AsObject |  31.48 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  20.17 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  31.72 ns | 0.0364 ns | 0.0341 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.22 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.29 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                            From_Float |  19.92 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
                                   From_Float_AsObject |  36.09 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  24.16 ns | 0.0385 ns | 0.0360 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.09 ns | 0.0238 ns | 0.0186 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.77 ns | 0.0258 ns | 0.0201 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.66 ns | 0.0199 ns | 0.0166 ns |      - |       0 B |
                                           From_String |  93.69 ns | 0.0775 ns | 0.0687 ns |      - |       0 B |
                                  From_String_AsObject | 108.49 ns | 0.3444 ns | 0.3222 ns |      - |       0 B |
                                      From_String_Null |  17.82 ns | 0.0474 ns | 0.0443 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.29 ns | 0.0244 ns | 0.0204 ns |      - |       0 B |
                                     From_String_Empty |  18.66 ns | 0.0428 ns | 0.0400 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.13 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.94 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  19.63 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.94 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.67 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.69 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                                             From_UInt |  15.99 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.95 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  19.64 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.95 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.95 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.68 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                            From_ULong |  16.01 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                                   From_ULong_AsObject |  31.69 ns | 0.0670 ns | 0.0594 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.51 ns | 0.0195 ns | 0.0152 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  31.83 ns | 0.0594 ns | 0.0496 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.46 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.71 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                                       From_NullObject |  18.75 ns | 0.0617 ns | 0.0577 ns |      - |       0 B |
                                           From_DBNull |  17.76 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.43 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.81 ns | 0.0383 ns | 0.0339 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.96 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.74 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.82 ns | 0.0142 ns | 0.0118 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.49 ns | 0.0872 ns | 0.0815 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.85 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.74 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.81 ns | 0.0116 ns | 0.0109 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.28 ns | 0.0588 ns | 0.0491 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.56 ns | 0.0353 ns | 0.0330 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.20 ns | 0.0161 ns | 0.0116 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.26 ns | 0.0407 ns | 0.0360 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.71 ns | 0.0647 ns | 0.0605 ns |      - |       0 B |
                             From_NonConvertibleStruct |  15.87 ns | 0.0181 ns | 0.0161 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.93 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.87 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.45 ns | 0.0812 ns | 0.0760 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.88 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.75 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                                             From_Enum |  17.48 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                    From_Enum_AsObject |  65.14 ns | 0.1029 ns | 0.0962 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.44 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  65.16 ns | 0.1148 ns | 0.1018 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.82 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.70 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
                                      From_ParentClass |  18.58 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.87 ns | 0.0304 ns | 0.0237 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.81 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.68 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                     From_ParentStruct |  15.86 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.89 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.87 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.86 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.86 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.20 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULongNullable.From_String_Empty_AsObject: DefaultJob
