
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.91 ns | 0.0892 ns | 0.0834 ns |      - |       0 B |
                                    From_Bool_AsObject | 24.80 ns | 0.0897 ns | 0.0795 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.39 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 24.80 ns | 0.0774 ns | 0.0646 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 15.59 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 21.06 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                             From_Byte | 14.88 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                                    From_Byte_AsObject | 24.84 ns | 0.0803 ns | 0.0751 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.06 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.74 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.78 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.72 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                                             From_Char | 13.73 ns | 0.0183 ns | 0.0162 ns |      - |       0 B |
                                    From_Char_AsObject | 25.59 ns | 0.0451 ns | 0.0422 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 15.09 ns | 0.0380 ns | 0.0317 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 25.57 ns | 0.0447 ns | 0.0419 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.81 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.47 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
                                         From_DateTime | 14.12 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 16.74 ns | 0.0227 ns | 0.0201 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.80 ns | 0.0122 ns | 0.0109 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 18.46 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                                          From_Decimal | 27.68 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.06 ns | 0.5548 ns | 0.4918 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 40.39 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.79 ns | 0.0579 ns | 0.0513 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.43 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.80 ns | 0.0286 ns | 0.0268 ns |      - |       0 B |
                                           From_Double | 17.91 ns | 0.0283 ns | 0.0264 ns |      - |       0 B |
                                  From_Double_AsObject | 28.40 ns | 0.0601 ns | 0.0562 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.42 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 29.32 ns | 0.0550 ns | 0.0515 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.25 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.72 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                            From_Short | 13.99 ns | 0.0087 ns | 0.0068 ns |      - |       0 B |
                                   From_Short_AsObject | 25.32 ns | 0.0430 ns | 0.0403 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.38 ns | 0.0184 ns | 0.0153 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 25.27 ns | 0.0058 ns | 0.0045 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.69 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.71 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
                                              From_Int | 15.07 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                                     From_Int_AsObject | 26.33 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.40 ns | 0.0123 ns | 0.0102 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.06 ns | 0.0351 ns | 0.0328 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.87 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.62 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
                                             From_Long | 15.09 ns | 0.0254 ns | 0.0237 ns |      - |       0 B |
                                    From_Long_AsObject | 26.03 ns | 0.0448 ns | 0.0397 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.88 ns | 0.0268 ns | 0.0251 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.02 ns | 0.0299 ns | 0.0279 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.82 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 22.35 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
                                            From_SByte | 14.89 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                                   From_SByte_AsObject | 25.30 ns | 0.0347 ns | 0.0324 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.44 ns | 0.0108 ns | 0.0084 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.34 ns | 0.0392 ns | 0.0366 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.49 ns | 0.0171 ns | 0.0152 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 20.12 ns | 0.0287 ns | 0.0268 ns |      - |       0 B |
                                            From_Float | 18.41 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
                                   From_Float_AsObject | 28.60 ns | 0.0180 ns | 0.0150 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 18.65 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 29.59 ns | 0.0104 ns | 0.0081 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.79 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 19.84 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                           From_String | 86.52 ns | 0.1311 ns | 0.1163 ns |      - |       0 B |
                                  From_String_AsObject | 95.38 ns | 0.0954 ns | 0.0892 ns |      - |       0 B |
                                      From_String_Null | 15.31 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.79 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                                     From_String_Empty | 15.41 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.92 ns | 0.0451 ns | 0.0422 ns |      - |       0 B |
                                  From_UShort_AsObject | 29.39 ns | 0.0591 ns | 0.0524 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.17 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 28.23 ns | 0.0168 ns | 0.0131 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.42 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.77 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                                             From_UInt | 14.20 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                                    From_UInt_AsObject | 25.29 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.07 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.23 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.95 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 19.77 ns | 0.0335 ns | 0.0314 ns |      - |       0 B |
                                            From_ULong | 14.85 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.04 ns | 0.0178 ns | 0.0149 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.90 ns | 0.0398 ns | 0.0373 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.06 ns | 0.0467 ns | 0.0437 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.85 ns | 0.0268 ns | 0.0250 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.71 ns | 0.0255 ns | 0.0213 ns |      - |       0 B |
                                       From_NullObject | 16.75 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                                           From_DBNull | 16.82 ns | 0.0366 ns | 0.0342 ns |      - |       0 B |
                                  From_DBNull_AsObject | 21.35 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                                 From_ConvertibleClass | 22.10 ns | 0.0234 ns | 0.0195 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.25 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.87 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.71 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.99 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.98 ns | 0.0370 ns | 0.0346 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.09 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.62 ns | 0.0401 ns | 0.0355 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.60 ns | 0.0179 ns | 0.0158 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.54 ns | 0.0320 ns | 0.0284 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.76 ns | 0.0351 ns | 0.0329 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.53 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.47 ns | 0.0224 ns | 0.0198 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 20.94 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.53 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.03 ns | 0.0321 ns | 0.0284 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.32 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 20.71 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.51 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.17 ns | 0.0263 ns | 0.0233 ns |      - |       0 B |
                                             From_Enum | 16.12 ns | 0.0153 ns | 0.0135 ns |      - |       0 B |
                                    From_Enum_AsObject | 58.03 ns | 0.0319 ns | 0.0267 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 15.59 ns | 0.0525 ns | 0.0465 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 57.40 ns | 0.0648 ns | 0.0575 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.84 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.52 ns | 0.0255 ns | 0.0226 ns |      - |       0 B |
                                      From_ParentClass | 14.99 ns | 0.0082 ns | 0.0072 ns |      - |       0 B |
                             From_ParentClass_AsObject | 20.51 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.08 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.16 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                                     From_ParentStruct | 14.80 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 20.48 ns | 0.0243 ns | 0.0228 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.58 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.47 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.59 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.96 ns | 0.0119 ns | 0.0093 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_String_Empty_AsObject: DefaultJob
