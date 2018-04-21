
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 13.86 ns | 0.0813 ns | 0.0721 ns | 13.84 ns |      - |       0 B |
                                    From_Bool_AsObject | 25.78 ns | 0.0755 ns | 0.0669 ns | 25.77 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.19 ns | 0.0051 ns | 0.0045 ns | 14.19 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 24.77 ns | 0.0361 ns | 0.0302 ns | 24.76 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.89 ns | 0.0228 ns | 0.0213 ns | 13.88 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.80 ns | 0.0172 ns | 0.0161 ns | 16.80 ns |      - |       0 B |
                                             From_Byte | 13.83 ns | 0.0140 ns | 0.0117 ns | 13.82 ns |      - |       0 B |
                                    From_Byte_AsObject | 28.21 ns | 0.0594 ns | 0.0556 ns | 28.22 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.17 ns | 0.0140 ns | 0.0131 ns | 13.17 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 28.18 ns | 0.0363 ns | 0.0340 ns | 28.17 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.63 ns | 0.0104 ns | 0.0087 ns | 14.63 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 18.67 ns | 0.0369 ns | 0.0327 ns | 18.68 ns |      - |       0 B |
                                             From_Char | 14.18 ns | 0.0050 ns | 0.0041 ns | 14.18 ns |      - |       0 B |
                                    From_Char_AsObject | 27.08 ns | 0.0265 ns | 0.0222 ns | 27.08 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 15.24 ns | 0.0229 ns | 0.0214 ns | 15.23 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 26.09 ns | 0.0608 ns | 0.0568 ns | 26.08 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.96 ns | 0.0297 ns | 0.0278 ns | 13.94 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.76 ns | 0.0202 ns | 0.0189 ns | 16.76 ns |      - |       0 B |
                                         From_DateTime | 14.95 ns | 0.0061 ns | 0.0051 ns | 14.95 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.58 ns | 0.0360 ns | 0.0337 ns | 14.57 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.64 ns | 0.0354 ns | 0.0331 ns | 14.64 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.88 ns | 0.0257 ns | 0.0227 ns | 17.87 ns |      - |       0 B |
                                          From_Decimal | 28.36 ns | 0.0646 ns | 0.0604 ns | 28.38 ns |      - |       0 B |
                                 From_Decimal_AsObject | 35.76 ns | 0.0526 ns | 0.0466 ns | 35.74 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 29.89 ns | 0.0241 ns | 0.0201 ns | 29.89 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 35.72 ns | 0.0424 ns | 0.0376 ns | 35.70 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.82 ns | 0.0275 ns | 0.0258 ns | 14.82 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.72 ns | 0.0056 ns | 0.0044 ns | 16.72 ns |      - |       0 B |
                                           From_Double | 17.96 ns | 0.0235 ns | 0.0196 ns | 17.96 ns |      - |       0 B |
                                  From_Double_AsObject | 28.39 ns | 0.0874 ns | 0.0817 ns | 28.35 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.68 ns | 0.0493 ns | 0.0461 ns | 19.70 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 28.30 ns | 0.0455 ns | 0.0403 ns | 28.28 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.93 ns | 0.0216 ns | 0.0191 ns | 14.93 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.76 ns | 0.0293 ns | 0.0260 ns | 16.76 ns |      - |       0 B |
                                            From_Short | 15.09 ns | 0.0119 ns | 0.0100 ns | 15.10 ns |      - |       0 B |
                                   From_Short_AsObject | 26.08 ns | 0.0529 ns | 0.0495 ns | 26.06 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.56 ns | 0.0173 ns | 0.0125 ns | 15.56 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.07 ns | 0.0540 ns | 0.0505 ns | 26.04 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.82 ns | 0.0186 ns | 0.0174 ns | 13.81 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.82 ns | 0.0250 ns | 0.0234 ns | 16.81 ns |      - |       0 B |
                                              From_Int | 14.90 ns | 0.0248 ns | 0.0220 ns | 14.90 ns |      - |       0 B |
                                     From_Int_AsObject | 26.99 ns | 0.0244 ns | 0.0216 ns | 26.98 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.63 ns | 0.0153 ns | 0.0143 ns | 15.63 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.06 ns | 0.0428 ns | 0.0357 ns | 26.05 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.91 ns | 0.0240 ns | 0.0224 ns | 13.91 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.72 ns | 0.0062 ns | 0.0055 ns | 16.72 ns |      - |       0 B |
                                             From_Long | 15.09 ns | 0.0141 ns | 0.0102 ns | 15.09 ns |      - |       0 B |
                                    From_Long_AsObject | 25.99 ns | 0.0106 ns | 0.0088 ns | 25.99 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.93 ns | 0.0423 ns | 0.0396 ns | 16.94 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.01 ns | 0.0474 ns | 0.0443 ns | 25.99 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.86 ns | 0.0238 ns | 0.0211 ns | 15.86 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.96 ns | 0.0286 ns | 0.0267 ns | 18.94 ns |      - |       0 B |
                                            From_SByte | 14.05 ns | 0.0362 ns | 0.0321 ns | 14.06 ns |      - |       0 B |
                                   From_SByte_AsObject | 25.29 ns | 0.0459 ns | 0.0429 ns | 25.27 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.96 ns | 0.0386 ns | 0.0361 ns | 14.96 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.24 ns | 0.0447 ns | 0.0396 ns | 25.23 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 17.91 ns | 0.0135 ns | 0.0126 ns | 17.91 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 18.61 ns | 0.0218 ns | 0.0204 ns | 18.60 ns |      - |       0 B |
                                            From_Float | 18.54 ns | 0.0196 ns | 0.0153 ns | 18.54 ns |      - |       0 B |
                                   From_Float_AsObject | 28.84 ns | 0.0092 ns | 0.0072 ns | 28.84 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.69 ns | 0.0160 ns | 0.0142 ns | 18.70 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 29.86 ns | 0.0541 ns | 0.0480 ns | 29.84 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.87 ns | 0.0248 ns | 0.0232 ns | 13.87 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 19.84 ns | 0.0226 ns | 0.0211 ns | 19.83 ns |      - |       0 B |
                                           From_String | 89.85 ns | 0.0273 ns | 0.0255 ns | 89.84 ns |      - |       0 B |
                                  From_String_AsObject | 99.49 ns | 0.2139 ns | 0.1896 ns | 99.46 ns |      - |       0 B |
                                      From_String_Null | 16.67 ns | 0.0131 ns | 0.0116 ns | 16.67 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.83 ns | 0.0293 ns | 0.0275 ns | 16.81 ns |      - |       0 B |
                                     From_String_Empty | 16.27 ns | 0.0138 ns | 0.0122 ns | 16.27 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.04 ns | 0.0181 ns | 0.0151 ns | 14.05 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.23 ns | 0.0226 ns | 0.0200 ns | 25.23 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.60 ns | 0.0126 ns | 0.0105 ns | 14.60 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 26.23 ns | 0.0357 ns | 0.0298 ns | 26.21 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.02 ns | 0.0217 ns | 0.0181 ns | 14.02 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.74 ns | 0.0255 ns | 0.0239 ns | 16.73 ns |      - |       0 B |
                                             From_UInt | 13.98 ns | 0.0161 ns | 0.0150 ns | 13.99 ns |      - |       0 B |
                                    From_UInt_AsObject | 25.29 ns | 0.0477 ns | 0.0423 ns | 25.27 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.65 ns | 0.0216 ns | 0.0202 ns | 14.66 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.23 ns | 0.0335 ns | 0.0297 ns | 25.22 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.98 ns | 0.0197 ns | 0.0184 ns | 13.98 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.82 ns | 0.0223 ns | 0.0198 ns | 16.81 ns |      - |       0 B |
                                            From_ULong | 14.90 ns | 0.0259 ns | 0.0230 ns | 14.91 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.03 ns | 0.0106 ns | 0.0083 ns | 26.03 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.90 ns | 0.0090 ns | 0.0075 ns | 16.90 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 27.07 ns | 0.0506 ns | 0.0449 ns | 27.07 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.91 ns | 0.0332 ns | 0.0278 ns | 14.90 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.78 ns | 0.0633 ns | 0.0592 ns | 16.75 ns |      - |       0 B |
                                       From_NullObject | 16.77 ns | 0.0154 ns | 0.0144 ns | 16.77 ns |      - |       0 B |
                                           From_DBNull | 15.03 ns | 0.0067 ns | 0.0053 ns | 15.03 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.92 ns | 0.0154 ns | 0.0111 ns | 16.92 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.22 ns | 0.0403 ns | 0.0357 ns | 20.20 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.29 ns | 0.0110 ns | 0.0103 ns | 22.29 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.84 ns | 0.0097 ns | 0.0081 ns | 16.84 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.95 ns | 0.0171 ns | 0.0152 ns | 17.95 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.29 ns | 0.0089 ns | 0.0074 ns | 15.29 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 20.43 ns | 0.0122 ns | 0.0114 ns | 20.43 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.07 ns | 0.0061 ns | 0.0057 ns | 15.07 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.71 ns | 0.0132 ns | 0.0110 ns | 17.71 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.71 ns | 0.0095 ns | 0.0074 ns | 22.71 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.62 ns | 0.0662 ns | 0.0619 ns | 23.62 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.73 ns | 0.0348 ns | 0.0308 ns | 22.72 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.55 ns | 0.0295 ns | 0.0261 ns | 23.54 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.49 ns | 0.0352 ns | 0.0329 ns | 14.50 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.83 ns | 0.0337 ns | 0.0315 ns | 16.81 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.52 ns | 0.0229 ns | 0.0214 ns | 14.51 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.19 ns | 0.0097 ns | 0.0086 ns | 19.18 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.59 ns | 0.0256 ns | 0.0227 ns | 14.58 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 19.20 ns | 0.0253 ns | 0.0224 ns | 19.19 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.53 ns | 0.0100 ns | 0.0088 ns | 14.52 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.74 ns | 0.0101 ns | 0.0085 ns | 16.73 ns |      - |       0 B |
                                             From_Enum | 15.62 ns | 0.0238 ns | 0.0223 ns | 15.62 ns |      - |       0 B |
                                    From_Enum_AsObject | 57.64 ns | 0.0793 ns | 0.0703 ns | 57.61 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.61 ns | 0.0323 ns | 0.0302 ns | 15.59 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 57.58 ns | 0.0360 ns | 0.0281 ns | 57.58 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.84 ns | 0.0221 ns | 0.0196 ns | 13.83 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 22.09 ns | 0.0049 ns | 0.0043 ns | 22.09 ns |      - |       0 B |
                                      From_ParentClass | 15.00 ns | 0.0203 ns | 0.0190 ns | 15.00 ns |      - |       0 B |
                             From_ParentClass_AsObject | 20.58 ns | 0.0299 ns | 0.0279 ns | 20.56 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.03 ns | 0.0073 ns | 0.0057 ns | 15.02 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 20.99 ns | 0.0304 ns | 0.0284 ns | 20.97 ns |      - |       0 B |
                                     From_ParentStruct | 14.47 ns | 0.0178 ns | 0.0167 ns | 14.47 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.71 ns | 0.0043 ns | 0.0034 ns | 20.71 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.52 ns | 0.0166 ns | 0.0139 ns | 14.51 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 20.47 ns | 0.0081 ns | 0.0068 ns | 20.47 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.21 ns | 0.0273 ns | 0.0255 ns | 15.21 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.83 ns | 0.0243 ns | 0.0228 ns | 16.82 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ByteNullable.From_String_Empty_AsObject: DefaultJob
