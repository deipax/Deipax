
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.61 ns | 0.0544 ns | 0.0482 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.88 ns | 0.0441 ns | 0.0368 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.36 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.87 ns | 0.0336 ns | 0.0280 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.45 ns | 0.0487 ns | 0.0456 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.91 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                             From_Byte |  14.01 ns | 0.0215 ns | 0.0191 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.50 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.70 ns | 0.0093 ns | 0.0068 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  26.59 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.22 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.92 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                             From_Char |  14.03 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                                    From_Char_AsObject |  26.66 ns | 0.0209 ns | 0.0196 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.47 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.67 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.25 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.31 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                         From_DateTime |  14.53 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.01 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.98 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.44 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                                          From_Decimal |  25.10 ns | 0.0181 ns | 0.0141 ns |      - |       0 B |
                                 From_Decimal_AsObject |  35.94 ns | 0.0665 ns | 0.0622 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  28.86 ns | 0.0217 ns | 0.0192 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.05 ns | 0.0371 ns | 0.0329 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.34 ns | 0.0083 ns | 0.0070 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.33 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                                           From_Double |  20.45 ns | 0.0287 ns | 0.0254 ns |      - |       0 B |
                                  From_Double_AsObject |  30.29 ns | 0.0662 ns | 0.0586 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  18.58 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.16 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.03 ns | 0.0554 ns | 0.0462 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.30 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                            From_Short |  14.55 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
                                   From_Short_AsObject |  26.39 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.40 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.40 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.27 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.38 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                                              From_Int |  14.55 ns | 0.0206 ns | 0.0172 ns |      - |       0 B |
                                     From_Int_AsObject |  26.39 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  15.44 ns | 0.0331 ns | 0.0276 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.39 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.41 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  20.14 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
                                             From_Long |  14.56 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                                    From_Long_AsObject |  26.40 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.69 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.39 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.58 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.31 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                                            From_SByte |  15.02 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.38 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  15.37 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.61 ns | 0.0169 ns | 0.0159 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.23 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.76 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                            From_Float |  19.03 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                                   From_Float_AsObject |  30.42 ns | 0.0217 ns | 0.0193 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  18.31 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.41 ns | 0.0242 ns | 0.0227 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.22 ns | 0.0148 ns | 0.0132 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.43 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                           From_String |  91.11 ns | 0.0937 ns | 0.0877 ns |      - |       0 B |
                                  From_String_AsObject | 102.71 ns | 0.0613 ns | 0.0543 ns |      - |       0 B |
                                      From_String_Null |  15.62 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.35 ns | 0.0187 ns | 0.0165 ns |      - |       0 B |
                                     From_String_Empty |  15.96 ns | 0.0163 ns | 0.0145 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.01 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.85 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.81 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.85 ns | 0.0160 ns | 0.0141 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.34 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.32 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                             From_UInt |  14.00 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                    From_UInt_AsObject |  25.85 ns | 0.0171 ns | 0.0142 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  14.81 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.85 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.77 ns | 0.0089 ns | 0.0075 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.36 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                            From_ULong |  14.00 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                   From_ULong_AsObject |  17.87 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.35 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  18.45 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.98 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.35 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                                       From_NullObject |  17.75 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                           From_DBNull |  15.33 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.53 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.79 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.97 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.23 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.96 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  22.40 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.05 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.30 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.87 ns | 0.0109 ns | 0.0096 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.03 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.58 ns | 0.0129 ns | 0.0114 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.16 ns | 0.2456 ns | 0.2298 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.09 ns | 0.2752 ns | 0.2574 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.41 ns | 0.1787 ns | 0.1492 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.02 ns | 0.0245 ns | 0.0204 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.71 ns | 0.0112 ns | 0.0094 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.05 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.68 ns | 0.0158 ns | 0.0123 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.04 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.44 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                             From_Enum |  14.56 ns | 0.0091 ns | 0.0071 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.17 ns | 0.0977 ns | 0.0914 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.00 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.43 ns | 0.0433 ns | 0.0384 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.84 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.97 ns | 0.0151 ns | 0.0133 ns |      - |       0 B |
                                      From_ParentClass |  16.11 ns | 0.0210 ns | 0.0187 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.18 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.56 ns | 0.0421 ns | 0.0250 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.35 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                                     From_ParentStruct |  14.54 ns | 0.4003 ns | 0.4610 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.85 ns | 0.5051 ns | 0.5614 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.12 ns | 0.0741 ns | 0.0657 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.36 ns | 0.1417 ns | 0.1256 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.06 ns | 0.0412 ns | 0.0344 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.39 ns | 0.0626 ns | 0.0555 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULong.From_String_Empty_AsObject: DefaultJob
