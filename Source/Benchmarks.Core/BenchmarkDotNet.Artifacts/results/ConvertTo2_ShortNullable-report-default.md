
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.75 ns | 0.1011 ns | 0.0844 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.28 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.80 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.29 ns | 0.0246 ns | 0.0218 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.98 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.03 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                             From_Byte |  14.94 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.32 ns | 0.0436 ns | 0.0408 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  18.74 ns | 0.0572 ns | 0.0535 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.28 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.88 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.03 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                             From_Char |  15.40 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
                                    From_Char_AsObject |  29.63 ns | 0.0244 ns | 0.0217 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  18.85 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.64 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  16.11 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  21.14 ns | 0.0144 ns | 0.0112 ns |      - |       0 B |
                                         From_DateTime |  16.46 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.97 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.12 ns | 0.0320 ns | 0.0300 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.85 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                          From_Decimal |  29.16 ns | 0.0347 ns | 0.0325 ns |      - |       0 B |
                                 From_Decimal_AsObject |  40.75 ns | 0.0587 ns | 0.0549 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  38.24 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  40.53 ns | 0.0172 ns | 0.0135 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.21 ns | 0.0396 ns | 0.0330 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.85 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                           From_Double |  20.22 ns | 0.0245 ns | 0.0217 ns |      - |       0 B |
                                  From_Double_AsObject |  32.50 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.63 ns | 0.0315 ns | 0.0295 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  32.41 ns | 0.0379 ns | 0.0355 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.53 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.44 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                            From_Short |  14.68 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                   From_Short_AsObject |  29.95 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.16 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.47 ns | 0.0269 ns | 0.0238 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.89 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.54 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
                                              From_Int |  15.89 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                                     From_Int_AsObject |  29.66 ns | 0.0249 ns | 0.0208 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.72 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.64 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.07 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.87 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                                             From_Long |  15.88 ns | 0.0124 ns | 0.0104 ns |      - |       0 B |
                                    From_Long_AsObject |  29.64 ns | 0.0258 ns | 0.0242 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.89 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  29.60 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.13 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.22 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                            From_SByte |  14.93 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                                   From_SByte_AsObject |  28.25 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.57 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  28.25 ns | 0.0043 ns | 0.0034 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.09 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.85 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
                                            From_Float |  20.62 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                                   From_Float_AsObject |  32.29 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.58 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.29 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.04 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.73 ns | 0.0089 ns | 0.0084 ns |      - |       0 B |
                                           From_String |  95.25 ns | 0.0368 ns | 0.0307 ns |      - |       0 B |
                                  From_String_AsObject | 106.74 ns | 0.0780 ns | 0.0730 ns |      - |       0 B |
                                      From_String_Null |  16.23 ns | 0.0034 ns | 0.0026 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.26 ns | 0.0048 ns | 0.0042 ns |      - |       0 B |
                                     From_String_Empty |  16.91 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.94 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.79 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  19.73 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.79 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  17.23 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.87 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                                             From_UInt |  16.71 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                                    From_UInt_AsObject |  29.62 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  20.41 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  29.64 ns | 0.0437 ns | 0.0387 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.06 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.89 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                                            From_ULong |  16.53 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                                   From_ULong_AsObject |  29.64 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.64 ns | 0.0155 ns | 0.0121 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  29.64 ns | 0.0301 ns | 0.0267 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.14 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.48 ns | 0.0148 ns | 0.0123 ns |      - |       0 B |
                                       From_NullObject |  17.85 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
                                           From_DBNull |  15.90 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.21 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  27.10 ns | 0.0320 ns | 0.0299 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.48 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.88 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.95 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.16 ns | 0.0252 ns | 0.0223 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.00 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  19.33 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.67 ns | 0.0305 ns | 0.0254 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.46 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.87 ns | 0.0179 ns | 0.0168 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.45 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.73 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.85 ns | 0.0199 ns | 0.0176 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.48 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  23.64 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.67 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.59 ns | 0.0208 ns | 0.0162 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.68 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.04 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                                             From_Enum |  15.87 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                                    From_Enum_AsObject |  62.09 ns | 0.0777 ns | 0.0689 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.92 ns | 0.0292 ns | 0.0273 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.88 ns | 0.0404 ns | 0.0378 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.06 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.04 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                                      From_ParentClass |  16.94 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.01 ns | 0.0070 ns | 0.0051 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.95 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.99 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                                     From_ParentStruct |  16.11 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.28 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.68 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.67 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.67 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.83 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_String_Empty_AsObject: DefaultJob
