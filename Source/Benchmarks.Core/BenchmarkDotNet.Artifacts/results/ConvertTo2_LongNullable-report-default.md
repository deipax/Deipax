
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  16.73 ns | 0.0708 ns | 0.0627 ns |  16.73 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.97 ns | 0.0244 ns | 0.0204 ns |  30.97 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.23 ns | 0.0153 ns | 0.0143 ns |  17.24 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.97 ns | 0.0165 ns | 0.0147 ns |  30.97 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.43 ns | 0.0167 ns | 0.0157 ns |  16.42 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.71 ns | 0.0167 ns | 0.0157 ns |  18.71 ns |      - |       0 B |
                                             From_Byte |  16.14 ns | 0.0116 ns | 0.0109 ns |  16.14 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.96 ns | 0.0155 ns | 0.0137 ns |  30.96 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.70 ns | 0.0102 ns | 0.0095 ns |  16.70 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.99 ns | 0.0313 ns | 0.0293 ns |  31.00 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.43 ns | 0.0124 ns | 0.0110 ns |  16.43 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.69 ns | 0.0105 ns | 0.0099 ns |  18.69 ns |      - |       0 B |
                                             From_Char |  16.14 ns | 0.0098 ns | 0.0087 ns |  16.13 ns |      - |       0 B |
                                    From_Char_AsObject |  31.76 ns | 0.0193 ns | 0.0181 ns |  31.75 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.30 ns | 0.0101 ns | 0.0090 ns |  16.30 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  31.75 ns | 0.0036 ns | 0.0028 ns |  31.75 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.94 ns | 0.0016 ns | 0.0013 ns |  15.94 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.73 ns | 0.0085 ns | 0.0071 ns |  18.73 ns |      - |       0 B |
                                         From_DateTime |  15.75 ns | 0.0097 ns | 0.0091 ns |  15.74 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.88 ns | 0.0088 ns | 0.0078 ns |  15.88 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.89 ns | 0.0099 ns | 0.0088 ns |  15.88 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.69 ns | 0.0082 ns | 0.0073 ns |  18.69 ns |      - |       0 B |
                                          From_Decimal |  26.30 ns | 0.0470 ns | 0.0440 ns |  26.31 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.66 ns | 0.0276 ns | 0.0245 ns |  40.65 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  29.73 ns | 0.0064 ns | 0.0053 ns |  29.73 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.68 ns | 0.0752 ns | 0.0703 ns |  40.66 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.92 ns | 0.0187 ns | 0.0175 ns |  16.92 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.69 ns | 0.0134 ns | 0.0126 ns |  18.68 ns |      - |       0 B |
                                           From_Double |  20.35 ns | 0.2759 ns | 0.2304 ns |  20.22 ns |      - |       0 B |
                                  From_Double_AsObject |  36.12 ns | 0.4033 ns | 0.3773 ns |  35.97 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.46 ns | 0.0144 ns | 0.0135 ns |  20.45 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  35.83 ns | 0.0974 ns | 0.0761 ns |  35.81 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.40 ns | 0.0139 ns | 0.0109 ns |  16.40 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.68 ns | 0.0117 ns | 0.0104 ns |  18.67 ns |      - |       0 B |
                                            From_Short |  16.14 ns | 0.0160 ns | 0.0142 ns |  16.13 ns |      - |       0 B |
                                   From_Short_AsObject |  31.85 ns | 0.7136 ns | 1.1523 ns |  31.19 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.13 ns | 0.2881 ns | 0.2695 ns |  17.03 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.29 ns | 0.0424 ns | 0.0354 ns |  31.29 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.03 ns | 0.0581 ns | 0.0454 ns |  16.01 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.93 ns | 0.2416 ns | 0.2260 ns |  18.80 ns |      - |       0 B |
                                              From_Int |  15.80 ns | 0.0465 ns | 0.0363 ns |  15.79 ns |      - |       0 B |
                                     From_Int_AsObject |  31.01 ns | 0.0303 ns | 0.0253 ns |  31.00 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.76 ns | 0.0766 ns | 0.0679 ns |  17.73 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.02 ns | 0.0663 ns | 0.0620 ns |  31.01 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.11 ns | 0.0104 ns | 0.0092 ns |  16.11 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  19.17 ns | 0.0307 ns | 0.0256 ns |  19.18 ns |      - |       0 B |
                                             From_Long |  15.99 ns | 0.3141 ns | 0.2784 ns |  15.89 ns |      - |       0 B |
                                    From_Long_AsObject |  32.22 ns | 0.6608 ns | 0.8115 ns |  31.98 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  16.70 ns | 0.0404 ns | 0.0292 ns |  16.71 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  32.00 ns | 0.0464 ns | 0.0411 ns |  32.00 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.67 ns | 0.1508 ns | 0.1411 ns |  16.61 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.77 ns | 0.1092 ns | 0.1022 ns |  18.72 ns |      - |       0 B |
                                            From_SByte |  16.14 ns | 0.0139 ns | 0.0124 ns |  16.14 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.98 ns | 0.0211 ns | 0.0164 ns |  30.99 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.89 ns | 0.1276 ns | 0.1131 ns |  17.84 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  31.55 ns | 0.7390 ns | 0.7907 ns |  31.14 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  16.49 ns | 0.0396 ns | 0.0331 ns |  16.48 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.51 ns | 0.0290 ns | 0.0242 ns |  19.50 ns |      - |       0 B |
                                            From_Float |  21.15 ns | 0.4378 ns | 0.4300 ns |  20.94 ns |      - |       0 B |
                                   From_Float_AsObject |  36.38 ns | 0.5633 ns | 0.4994 ns |  36.13 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.76 ns | 0.0482 ns | 0.0403 ns |  20.75 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.08 ns | 0.0214 ns | 0.0190 ns |  36.07 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.17 ns | 0.0163 ns | 0.0118 ns |  16.17 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.70 ns | 0.0226 ns | 0.0211 ns |  18.69 ns |      - |       0 B |
                                           From_String |  94.02 ns | 0.0670 ns | 0.0627 ns |  94.02 ns |      - |       0 B |
                                  From_String_AsObject | 108.59 ns | 0.0655 ns | 0.0511 ns | 108.59 ns |      - |       0 B |
                                      From_String_Null |  19.86 ns | 0.0221 ns | 0.0206 ns |  19.86 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.43 ns | 0.0457 ns | 0.0381 ns |  19.42 ns |      - |       0 B |
                                     From_String_Empty |  17.53 ns | 0.0168 ns | 0.0149 ns |  17.52 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.14 ns | 0.0109 ns | 0.0102 ns |  16.13 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.97 ns | 0.0239 ns | 0.0212 ns |  30.97 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.16 ns | 0.0124 ns | 0.0116 ns |  16.15 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.97 ns | 0.0283 ns | 0.0265 ns |  30.97 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.12 ns | 0.0238 ns | 0.0199 ns |  16.11 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.73 ns | 0.0328 ns | 0.0307 ns |  18.73 ns |      - |       0 B |
                                             From_UInt |  16.03 ns | 0.0321 ns | 0.0300 ns |  16.03 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.98 ns | 0.0245 ns | 0.0229 ns |  30.99 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.18 ns | 0.0306 ns | 0.0286 ns |  16.17 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.97 ns | 0.0235 ns | 0.0220 ns |  30.96 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.44 ns | 0.0279 ns | 0.0261 ns |  16.45 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.72 ns | 0.0115 ns | 0.0102 ns |  18.72 ns |      - |       0 B |
                                            From_ULong |  16.57 ns | 0.0318 ns | 0.0282 ns |  16.56 ns |      - |       0 B |
                                   From_ULong_AsObject |  31.87 ns | 0.0326 ns | 0.0272 ns |  31.87 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.20 ns | 0.0173 ns | 0.0144 ns |  17.20 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  31.82 ns | 0.0817 ns | 0.0725 ns |  31.79 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.42 ns | 0.0222 ns | 0.0197 ns |  16.41 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.10 ns | 0.0130 ns | 0.0122 ns |  19.10 ns |      - |       0 B |
                                       From_NullObject |  18.72 ns | 0.0373 ns | 0.0349 ns |  18.70 ns |      - |       0 B |
                                           From_DBNull |  17.75 ns | 0.0140 ns | 0.0131 ns |  17.75 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.62 ns | 0.0587 ns | 0.0521 ns |  28.63 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.81 ns | 0.0361 ns | 0.0338 ns |  28.81 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  21.43 ns | 0.0069 ns | 0.0058 ns |  21.43 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.70 ns | 0.0108 ns | 0.0096 ns |  18.70 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.76 ns | 0.0131 ns | 0.0123 ns |  18.75 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  26.35 ns | 0.0129 ns | 0.0114 ns |  26.35 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.32 ns | 0.0199 ns | 0.0166 ns |  18.31 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.69 ns | 0.0178 ns | 0.0166 ns |  18.68 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.70 ns | 0.0160 ns | 0.0150 ns |  26.70 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.14 ns | 0.0241 ns | 0.0214 ns |  30.13 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  29.81 ns | 0.0159 ns | 0.0141 ns |  29.81 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.14 ns | 0.0246 ns | 0.0230 ns |  30.13 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.50 ns | 0.0149 ns | 0.0140 ns |  17.50 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.69 ns | 0.0169 ns | 0.0158 ns |  18.69 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.14 ns | 0.0088 ns | 0.0082 ns |  16.14 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.72 ns | 0.0641 ns | 0.0500 ns |  25.71 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.13 ns | 0.0085 ns | 0.0079 ns |  16.14 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.37 ns | 0.0152 ns | 0.0142 ns |  25.36 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.13 ns | 0.0048 ns | 0.0042 ns |  16.13 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  19.53 ns | 0.0133 ns | 0.0118 ns |  19.53 ns |      - |       0 B |
                                             From_Enum |  15.56 ns | 0.0308 ns | 0.0288 ns |  15.55 ns |      - |       0 B |
                                    From_Enum_AsObject |  63.74 ns | 0.0677 ns | 0.0601 ns |  63.73 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.63 ns | 0.0129 ns | 0.0115 ns |  19.63 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  63.82 ns | 0.1665 ns | 0.1558 ns |  63.75 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.81 ns | 0.0221 ns | 0.0184 ns |  16.80 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.16 ns | 0.0156 ns | 0.0122 ns |  19.16 ns |      - |       0 B |
                                      From_ParentClass |  17.85 ns | 0.0200 ns | 0.0177 ns |  17.85 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.93 ns | 0.0153 ns | 0.0143 ns |  25.93 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.92 ns | 0.0174 ns | 0.0154 ns |  17.92 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.69 ns | 0.0147 ns | 0.0137 ns |  18.69 ns |      - |       0 B |
                                     From_ParentStruct |  16.13 ns | 0.0067 ns | 0.0063 ns |  16.13 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.91 ns | 0.0222 ns | 0.0207 ns |  25.89 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.13 ns | 0.0074 ns | 0.0070 ns |  16.13 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.36 ns | 0.0138 ns | 0.0129 ns |  26.36 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.13 ns | 0.0067 ns | 0.0056 ns |  16.13 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.99 ns | 0.0096 ns | 0.0089 ns |  20.00 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
