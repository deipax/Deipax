
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.98 ns | 0.1360 ns | 0.1272 ns |      - |       0 B |
                                    From_Bool_AsObject | 24.77 ns | 0.1052 ns | 0.0932 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.22 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 24.73 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.94 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 19.48 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                                             From_Byte | 13.88 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                    From_Byte_AsObject | 25.77 ns | 0.0325 ns | 0.0271 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.10 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 24.73 ns | 0.0438 ns | 0.0410 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.80 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.96 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                                             From_Char | 13.76 ns | 0.0042 ns | 0.0038 ns |      - |       0 B |
                                    From_Char_AsObject | 25.56 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.19 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 25.60 ns | 0.0627 ns | 0.0587 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.62 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.98 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
                                         From_DateTime | 14.05 ns | 0.0060 ns | 0.0046 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.57 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.58 ns | 0.0199 ns | 0.0166 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 22.06 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
                                          From_Decimal | 26.46 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                                 From_Decimal_AsObject | 34.54 ns | 0.2318 ns | 0.1936 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 29.11 ns | 0.0553 ns | 0.0518 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 35.35 ns | 0.0435 ns | 0.0385 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.45 ns | 0.0559 ns | 0.0523 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.71 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                           From_Double | 16.09 ns | 0.0359 ns | 0.0319 ns |      - |       0 B |
                                  From_Double_AsObject | 26.37 ns | 0.0043 ns | 0.0034 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.16 ns | 0.0609 ns | 0.0509 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.32 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.81 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.76 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                                            From_Short | 14.01 ns | 0.0305 ns | 0.0270 ns |      - |       0 B |
                                   From_Short_AsObject | 25.29 ns | 0.0309 ns | 0.0290 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.45 ns | 0.0260 ns | 0.0231 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.27 ns | 0.0198 ns | 0.0175 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.06 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.60 ns | 0.0251 ns | 0.0210 ns |      - |       0 B |
                                              From_Int | 14.51 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                                     From_Int_AsObject | 25.22 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.49 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 25.29 ns | 0.0103 ns | 0.0080 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.24 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.69 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                                             From_Long | 15.11 ns | 0.0487 ns | 0.0455 ns |      - |       0 B |
                                    From_Long_AsObject | 25.98 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 18.04 ns | 0.0311 ns | 0.0276 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.01 ns | 0.0321 ns | 0.0301 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.81 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 19.52 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                                            From_SByte | 13.99 ns | 0.0337 ns | 0.0263 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.32 ns | 0.0500 ns | 0.0468 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 15.49 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.23 ns | 0.0432 ns | 0.0404 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.20 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.76 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                                            From_Float | 16.51 ns | 0.0234 ns | 0.0208 ns |      - |       0 B |
                                   From_Float_AsObject | 28.57 ns | 0.0817 ns | 0.0764 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.48 ns | 0.0113 ns | 0.0095 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 28.53 ns | 0.0283 ns | 0.0237 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 15.49 ns | 0.0313 ns | 0.0277 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.65 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                                           From_String | 85.22 ns | 0.0936 ns | 0.0876 ns |      - |       0 B |
                                  From_String_AsObject | 94.35 ns | 0.1793 ns | 0.1677 ns |      - |       0 B |
                                      From_String_Null | 15.55 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.74 ns | 0.0132 ns | 0.0111 ns |      - |       0 B |
                                     From_String_Empty | 17.90 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.73 ns | 0.0054 ns | 0.0042 ns |      - |       0 B |
                                  From_UShort_AsObject | 24.73 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.03 ns | 0.0366 ns | 0.0343 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 24.73 ns | 0.0380 ns | 0.0355 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.93 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.76 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                             From_UInt | 13.73 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                                    From_UInt_AsObject | 28.70 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 13.18 ns | 0.0251 ns | 0.0234 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 28.58 ns | 0.0317 ns | 0.0265 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.48 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.69 ns | 0.0096 ns | 0.0075 ns |      - |       0 B |
                                            From_ULong | 13.98 ns | 0.0214 ns | 0.0201 ns |      - |       0 B |
                                   From_ULong_AsObject | 25.27 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.63 ns | 0.0130 ns | 0.0109 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.28 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.81 ns | 0.0131 ns | 0.0102 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.71 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                                       From_NullObject | 16.76 ns | 0.0075 ns | 0.0062 ns |      - |       0 B |
                                           From_DBNull | 14.86 ns | 0.0226 ns | 0.0188 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.68 ns | 0.0268 ns | 0.0251 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.22 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.25 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.29 ns | 0.0096 ns | 0.0081 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.99 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.97 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.16 ns | 0.0053 ns | 0.0049 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.98 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.63 ns | 0.0351 ns | 0.0328 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.60 ns | 0.0268 ns | 0.0251 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.91 ns | 0.0390 ns | 0.0346 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.53 ns | 0.0132 ns | 0.0103 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.55 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.57 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.60 ns | 0.0302 ns | 0.0283 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.59 ns | 0.0230 ns | 0.0216 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 21.39 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 16.18 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.93 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.61 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.72 ns | 0.0233 ns | 0.0206 ns |      - |       0 B |
                                             From_Enum | 13.88 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
                                    From_Enum_AsObject | 55.59 ns | 0.0638 ns | 0.0597 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 14.35 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 55.17 ns | 0.0282 ns | 0.0250 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 14.25 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.62 ns | 0.0318 ns | 0.0297 ns |      - |       0 B |
                                      From_ParentClass | 14.97 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.76 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.00 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.61 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                                     From_ParentStruct | 15.51 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.80 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.62 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 21.78 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.60 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.68 ns | 0.0299 ns | 0.0280 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_String_Empty_AsObject: DefaultJob
