
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.56 ns | 0.1064 ns | 0.0944 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.77 ns | 0.0377 ns | 0.0334 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.31 ns | 0.0188 ns | 0.0157 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.79 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.42 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 18.59 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                                             From_Byte | 13.03 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                    From_Byte_AsObject | 17.67 ns | 0.0269 ns | 0.0252 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.93 ns | 0.0343 ns | 0.0320 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 16.74 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.68 ns | 0.0164 ns | 0.0137 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.17 ns | 0.0393 ns | 0.0349 ns |      - |       0 B |
                                             From_Char | 13.51 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                                    From_Char_AsObject | 24.05 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.30 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 24.05 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.73 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.03 ns | 0.0117 ns | 0.0097 ns |      - |       0 B |
                                         From_DateTime | 14.34 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.33 ns | 0.0359 ns | 0.0335 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.32 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.98 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
                                          From_Decimal | 25.51 ns | 0.0366 ns | 0.0342 ns |      - |       0 B |
                                 From_Decimal_AsObject | 33.77 ns | 0.0495 ns | 0.0438 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 27.89 ns | 0.0302 ns | 0.0283 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 33.82 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.81 ns | 0.0266 ns | 0.0248 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 15.92 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                           From_Double | 17.13 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                                  From_Double_AsObject | 26.61 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.17 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.59 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.36 ns | 0.0429 ns | 0.0335 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 15.96 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                                            From_Short | 14.31 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                   From_Short_AsObject | 25.43 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.59 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.33 ns | 0.0099 ns | 0.0087 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.70 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.11 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
                                              From_Int | 14.23 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                                     From_Int_AsObject | 25.33 ns | 0.0250 ns | 0.0233 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.67 ns | 0.0371 ns | 0.0347 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.37 ns | 0.1613 ns | 0.1430 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.45 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.93 ns | 0.0332 ns | 0.0310 ns |      - |       0 B |
                                             From_Long | 14.37 ns | 0.0374 ns | 0.0350 ns |      - |       0 B |
                                    From_Long_AsObject | 25.35 ns | 0.0390 ns | 0.0365 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.89 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 24.29 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.39 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.00 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                                            From_SByte | 13.53 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.53 ns | 0.0318 ns | 0.0298 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.44 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.56 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.60 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.99 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                            From_Float | 17.13 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                                   From_Float_AsObject | 27.15 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 19.38 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 27.17 ns | 0.0536 ns | 0.0501 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.67 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 15.96 ns | 0.0240 ns | 0.0224 ns |      - |       0 B |
                                           From_String | 88.80 ns | 0.0357 ns | 0.0298 ns |      - |       0 B |
                                  From_String_AsObject | 98.54 ns | 0.4158 ns | 0.3889 ns |      - |       0 B |
                                      From_String_Null | 16.23 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.17 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                     From_String_Empty | 15.77 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.24 ns | 0.0136 ns | 0.0113 ns |      - |       0 B |
                                  From_UShort_AsObject | 24.60 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 15.74 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 24.65 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.44 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 15.96 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                             From_UInt | 13.51 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.63 ns | 0.0399 ns | 0.0373 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.44 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 23.56 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.69 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 18.09 ns | 0.0140 ns | 0.0109 ns |      - |       0 B |
                                            From_ULong | 14.05 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                   From_ULong_AsObject | 24.33 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.88 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 25.37 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.31 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.97 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                       From_NullObject | 17.46 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                                           From_DBNull | 14.56 ns | 0.0179 ns | 0.0150 ns |      - |       0 B |
                                  From_DBNull_AsObject | 18.14 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.98 ns | 0.0127 ns | 0.0112 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.06 ns | 0.0489 ns | 0.0457 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.35 ns | 0.0447 ns | 0.0396 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.91 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.32 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.16 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.96 ns | 0.0089 ns | 0.0069 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 15.93 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.38 ns | 0.0074 ns | 0.0062 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.27 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.48 ns | 0.0130 ns | 0.0122 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.22 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.19 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.67 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.11 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.16 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.94 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.16 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.96 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.93 ns | 0.0303 ns | 0.0284 ns |      - |       0 B |
                                             From_Enum | 14.24 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                                    From_Enum_AsObject | 56.22 ns | 0.0810 ns | 0.0758 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.68 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 56.09 ns | 0.0794 ns | 0.0743 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.45 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 20.31 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
                                      From_ParentClass | 14.36 ns | 0.0381 ns | 0.0356 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.84 ns | 0.0210 ns | 0.0197 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.33 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.17 ns | 0.0301 ns | 0.0266 ns |      - |       0 B |
                                     From_ParentStruct | 14.11 ns | 0.0212 ns | 0.0199 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 22.66 ns | 0.0240 ns | 0.0213 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.94 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 20.17 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.05 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.03 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Byte.From_String_Empty_AsObject: DefaultJob
