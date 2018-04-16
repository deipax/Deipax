
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.82 ns | 0.1041 ns | 0.0974 ns |  14.81 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.67 ns | 0.0976 ns | 0.0865 ns |  25.65 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.47 ns | 0.0099 ns | 0.0077 ns |  17.47 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  27.54 ns | 0.6186 ns | 0.6076 ns |  27.21 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.25 ns | 0.3218 ns | 0.2853 ns |  15.11 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.41 ns | 0.4846 ns | 0.9219 ns |  17.98 ns |      - |       0 B |
                                             From_Byte |  14.39 ns | 0.0101 ns | 0.0090 ns |  14.38 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.21 ns | 0.1249 ns | 0.1107 ns |  26.19 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.16 ns | 0.0139 ns | 0.0123 ns |  17.16 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  26.19 ns | 0.1288 ns | 0.1076 ns |  26.15 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.27 ns | 0.0080 ns | 0.0071 ns |  16.27 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.28 ns | 0.0367 ns | 0.0306 ns |  17.26 ns |      - |       0 B |
                                             From_Char |  14.51 ns | 0.1499 ns | 0.1402 ns |  14.45 ns |      - |       0 B |
                                    From_Char_AsObject |  27.10 ns | 0.1920 ns | 0.1796 ns |  27.02 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  17.27 ns | 0.2132 ns | 0.1995 ns |  17.16 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.12 ns | 0.2680 ns | 0.2507 ns |  27.03 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.02 ns | 0.0780 ns | 0.0691 ns |  14.99 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.26 ns | 0.0083 ns | 0.0070 ns |  17.25 ns |      - |       0 B |
                                         From_DateTime |  14.65 ns | 0.0179 ns | 0.0159 ns |  14.65 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.10 ns | 0.0100 ns | 0.0083 ns |  15.10 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.89 ns | 0.0105 ns | 0.0098 ns |  15.89 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.28 ns | 0.0298 ns | 0.0264 ns |  17.28 ns |      - |       0 B |
                                          From_Decimal |  27.24 ns | 0.0913 ns | 0.0854 ns |  27.29 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.03 ns | 0.1096 ns | 0.1025 ns |  37.01 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  34.66 ns | 0.0263 ns | 0.0220 ns |  34.67 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.91 ns | 0.1187 ns | 0.1110 ns |  36.88 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.22 ns | 0.0483 ns | 0.0452 ns |  16.24 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.72 ns | 0.0188 ns | 0.0157 ns |  17.72 ns |      - |       0 B |
                                           From_Double |  17.96 ns | 0.0144 ns | 0.0127 ns |  17.96 ns |      - |       0 B |
                                  From_Double_AsObject |  29.11 ns | 0.0403 ns | 0.0337 ns |  29.10 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.57 ns | 0.1019 ns | 0.0953 ns |  22.60 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.44 ns | 0.0586 ns | 0.0548 ns |  29.42 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  17.03 ns | 0.0114 ns | 0.0101 ns |  17.03 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.28 ns | 0.0217 ns | 0.0192 ns |  17.28 ns |      - |       0 B |
                                            From_Short |  15.01 ns | 0.0422 ns | 0.0374 ns |  15.03 ns |      - |       0 B |
                                   From_Short_AsObject |  26.94 ns | 0.0216 ns | 0.0191 ns |  26.95 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.88 ns | 0.0111 ns | 0.0099 ns |  18.88 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.94 ns | 0.0338 ns | 0.0300 ns |  26.94 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.00 ns | 0.0585 ns | 0.0548 ns |  15.03 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.35 ns | 0.0258 ns | 0.0215 ns |  17.34 ns |      - |       0 B |
                                              From_Int |  15.26 ns | 0.0136 ns | 0.0127 ns |  15.26 ns |      - |       0 B |
                                     From_Int_AsObject |  26.74 ns | 0.0978 ns | 0.0867 ns |  26.72 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.02 ns | 0.0248 ns | 0.0207 ns |  18.01 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.65 ns | 0.0085 ns | 0.0075 ns |  26.65 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.67 ns | 0.0128 ns | 0.0107 ns |  14.67 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.88 ns | 0.0024 ns | 0.0022 ns |  17.88 ns |      - |       0 B |
                                             From_Long |  15.27 ns | 0.0038 ns | 0.0030 ns |  15.27 ns |      - |       0 B |
                                    From_Long_AsObject |  26.92 ns | 0.0117 ns | 0.0109 ns |  26.91 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.36 ns | 0.0039 ns | 0.0030 ns |  19.36 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.91 ns | 0.0074 ns | 0.0062 ns |  26.91 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.89 ns | 0.0188 ns | 0.0176 ns |  15.89 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.33 ns | 0.0281 ns | 0.0234 ns |  17.33 ns |      - |       0 B |
                                            From_SByte |  14.15 ns | 0.0206 ns | 0.0183 ns |  14.15 ns |      - |       0 B |
                                   From_SByte_AsObject |  17.84 ns | 0.0531 ns | 0.0497 ns |  17.87 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.71 ns | 0.0256 ns | 0.0227 ns |  14.70 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  17.90 ns | 0.0115 ns | 0.0102 ns |  17.90 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.43 ns | 0.0207 ns | 0.0194 ns |  14.43 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  20.20 ns | 0.0616 ns | 0.0576 ns |  20.22 ns |      - |       0 B |
                                            From_Float |  17.79 ns | 0.0412 ns | 0.0385 ns |  17.80 ns |      - |       0 B |
                                   From_Float_AsObject |  29.41 ns | 0.0197 ns | 0.0175 ns |  29.41 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  21.81 ns | 0.0241 ns | 0.0226 ns |  21.81 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.66 ns | 0.0168 ns | 0.0121 ns |  29.66 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.96 ns | 0.0172 ns | 0.0161 ns |  14.95 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.31 ns | 0.0104 ns | 0.0092 ns |  17.31 ns |      - |       0 B |
                                           From_String |  96.39 ns | 0.0673 ns | 0.0629 ns |  96.41 ns |      - |       0 B |
                                  From_String_AsObject | 106.45 ns | 0.4787 ns | 0.3997 ns | 106.24 ns |      - |       0 B |
                                      From_String_Null |  15.50 ns | 0.0050 ns | 0.0036 ns |  15.50 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.86 ns | 0.0206 ns | 0.0183 ns |  17.86 ns |      - |       0 B |
                                     From_String_Empty |  16.01 ns | 0.0536 ns | 0.0501 ns |  16.03 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.70 ns | 0.0061 ns | 0.0044 ns |  14.70 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.14 ns | 0.0432 ns | 0.0383 ns |  26.14 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.24 ns | 0.0564 ns | 0.0500 ns |  17.26 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.14 ns | 0.0569 ns | 0.0505 ns |  26.13 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.08 ns | 0.0152 ns | 0.0110 ns |  15.08 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.12 ns | 0.0276 ns | 0.0244 ns |  18.12 ns |      - |       0 B |
                                             From_UInt |  14.49 ns | 0.0089 ns | 0.0074 ns |  14.49 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.12 ns | 0.0248 ns | 0.0207 ns |  26.12 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.21 ns | 0.0077 ns | 0.0056 ns |  17.21 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.15 ns | 0.0775 ns | 0.0647 ns |  26.12 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.00 ns | 0.0509 ns | 0.0476 ns |  15.02 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.35 ns | 0.0189 ns | 0.0158 ns |  17.35 ns |      - |       0 B |
                                            From_ULong |  14.42 ns | 0.0082 ns | 0.0068 ns |  14.42 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.15 ns | 0.0648 ns | 0.0575 ns |  26.14 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.39 ns | 0.0181 ns | 0.0131 ns |  18.39 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.14 ns | 0.0250 ns | 0.0234 ns |  26.14 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.94 ns | 0.0084 ns | 0.0070 ns |  15.95 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.27 ns | 0.0187 ns | 0.0156 ns |  17.27 ns |      - |       0 B |
                                       From_NullObject |  17.31 ns | 0.0614 ns | 0.0574 ns |  17.35 ns |      - |       0 B |
                                           From_DBNull |  15.48 ns | 0.0181 ns | 0.0169 ns |  15.48 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.17 ns | 0.0073 ns | 0.0061 ns |  24.17 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.42 ns | 0.0285 ns | 0.0267 ns |  23.42 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.59 ns | 0.0743 ns | 0.0695 ns |  18.61 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.33 ns | 0.0187 ns | 0.0175 ns |  17.33 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.88 ns | 0.0226 ns | 0.0176 ns |  15.88 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.92 ns | 0.0034 ns | 0.0030 ns |  21.92 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.99 ns | 0.0097 ns | 0.0086 ns |  15.99 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.27 ns | 0.0023 ns | 0.0018 ns |  17.27 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.71 ns | 0.0782 ns | 0.0731 ns |  23.70 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.77 ns | 0.0245 ns | 0.0217 ns |  24.77 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.92 ns | 0.0087 ns | 0.0082 ns |  26.92 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.77 ns | 0.0302 ns | 0.0268 ns |  24.77 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.00 ns | 0.0543 ns | 0.0508 ns |  15.03 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.35 ns | 0.0215 ns | 0.0201 ns |  17.34 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.19 ns | 0.0032 ns | 0.0027 ns |  14.19 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.64 ns | 0.0636 ns | 0.0531 ns |  21.62 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.88 ns | 0.0025 ns | 0.0019 ns |  13.88 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.57 ns | 0.0027 ns | 0.0025 ns |  21.57 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.87 ns | 0.0022 ns | 0.0018 ns |  13.87 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0025 ns | 0.0020 ns |  17.26 ns |      - |       0 B |
                                             From_Enum |  15.21 ns | 0.0120 ns | 0.0107 ns |  15.21 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.38 ns | 0.0173 ns | 0.0145 ns |  59.39 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.57 ns | 0.0270 ns | 0.0252 ns |  18.55 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.26 ns | 0.0204 ns | 0.0159 ns |  59.27 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.67 ns | 0.0048 ns | 0.0040 ns |  14.67 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.27 ns | 0.0134 ns | 0.0119 ns |  17.26 ns |      - |       0 B |
                                      From_ParentClass |  15.84 ns | 0.0116 ns | 0.0108 ns |  15.84 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.59 ns | 0.0048 ns | 0.0043 ns |  22.59 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.87 ns | 0.0130 ns | 0.0116 ns |  15.87 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.37 ns | 0.0168 ns | 0.0149 ns |  17.36 ns |      - |       0 B |
                                     From_ParentStruct |  14.14 ns | 0.0024 ns | 0.0021 ns |  14.14 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.44 ns | 0.0039 ns | 0.0030 ns |  24.44 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.87 ns | 0.0013 ns | 0.0010 ns |  13.88 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.24 ns | 0.0031 ns | 0.0028 ns |  22.24 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.88 ns | 0.0102 ns | 0.0085 ns |  13.88 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0133 ns | 0.0125 ns |  17.27 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByte.From_String_Empty_AsObject: DefaultJob
