
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.60 ns | 0.0774 ns | 0.0724 ns |      - |       0 B |
                                    From_Bool_AsObject | 22.78 ns | 0.0329 ns | 0.0275 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.35 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.74 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 15.03 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.99 ns | 0.0335 ns | 0.0314 ns |      - |       0 B |
                                             From_Byte | 13.06 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.80 ns | 0.0890 ns | 0.0789 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.82 ns | 0.0287 ns | 0.0255 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.79 ns | 0.0474 ns | 0.0443 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.75 ns | 0.0652 ns | 0.0578 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 18.05 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                                             From_Char | 13.02 ns | 0.0099 ns | 0.0077 ns |      - |       0 B |
                                    From_Char_AsObject | 23.56 ns | 0.0511 ns | 0.0478 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.81 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 24.59 ns | 0.0408 ns | 0.0381 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.85 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 19.52 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                                         From_DateTime | 13.44 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.31 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.32 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.40 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
                                          From_Decimal | 23.78 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                                 From_Decimal_AsObject | 32.51 ns | 0.0635 ns | 0.0496 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 25.49 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 33.61 ns | 0.1926 ns | 0.1608 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.32 ns | 0.0177 ns | 0.0166 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.12 ns | 0.0268 ns | 0.0251 ns |      - |       0 B |
                                           From_Double | 16.36 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                  From_Double_AsObject | 27.15 ns | 0.0644 ns | 0.0602 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 17.89 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 27.14 ns | 0.0627 ns | 0.0556 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.31 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 15.90 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                                            From_Short | 13.51 ns | 0.0259 ns | 0.0243 ns |      - |       0 B |
                                   From_Short_AsObject | 24.55 ns | 0.0154 ns | 0.0129 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.31 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 23.54 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.69 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 15.94 ns | 0.0324 ns | 0.0303 ns |      - |       0 B |
                                              From_Int | 13.68 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                                     From_Int_AsObject | 24.60 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.29 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 23.62 ns | 0.0216 ns | 0.0191 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.44 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.88 ns | 0.0075 ns | 0.0062 ns |      - |       0 B |
                                             From_Long | 13.68 ns | 0.0124 ns | 0.0103 ns |      - |       0 B |
                                    From_Long_AsObject | 23.52 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 15.35 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 23.52 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.57 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 15.99 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                                            From_SByte | 13.50 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.53 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.45 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.52 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.70 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.53 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                                            From_Float | 16.64 ns | 0.0381 ns | 0.0356 ns |      - |       0 B |
                                   From_Float_AsObject | 27.87 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.86 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 27.87 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.22 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.69 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
                                           From_String | 85.91 ns | 0.1112 ns | 0.1040 ns |      - |       0 B |
                                  From_String_AsObject | 94.66 ns | 0.1070 ns | 0.1001 ns |      - |       0 B |
                                      From_String_Null | 15.23 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.30 ns | 0.0309 ns | 0.0289 ns |      - |       0 B |
                                     From_String_Empty | 15.28 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.18 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.01 ns | 0.0099 ns | 0.0077 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.80 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.02 ns | 0.0207 ns | 0.0184 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.42 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.13 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                             From_UInt | 13.89 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.01 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 13.81 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 24.07 ns | 0.0379 ns | 0.0336 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.67 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 15.88 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                                            From_ULong | 13.02 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                                   From_ULong_AsObject | 19.00 ns | 0.0232 ns | 0.0205 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 14.84 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 17.89 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.33 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 16.03 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                                       From_NullObject | 17.13 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                                           From_DBNull | 14.56 ns | 0.0087 ns | 0.0068 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.75 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.95 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.94 ns | 0.0102 ns | 0.0086 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.99 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.91 ns | 0.0427 ns | 0.0400 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.35 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.15 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.30 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 15.92 ns | 0.0462 ns | 0.0432 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.18 ns | 0.0056 ns | 0.0047 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.24 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.51 ns | 0.0060 ns | 0.0050 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.21 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.17 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.85 ns | 0.0190 ns | 0.0159 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.06 ns | 0.0274 ns | 0.0256 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.40 ns | 0.0202 ns | 0.0169 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.91 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.33 ns | 0.2028 ns | 0.1694 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 15.33 ns | 0.0340 ns | 0.0284 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.81 ns | 0.0189 ns | 0.0168 ns |      - |       0 B |
                                             From_Enum | 13.68 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                                    From_Enum_AsObject | 53.58 ns | 0.0303 ns | 0.0269 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 14.45 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 54.48 ns | 0.0721 ns | 0.0674 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.47 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 15.96 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                                      From_ParentClass | 14.32 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.06 ns | 0.0227 ns | 0.0213 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.31 ns | 0.0290 ns | 0.0242 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.47 ns | 0.0142 ns | 0.0118 ns |      - |       0 B |
                                     From_ParentStruct | 14.07 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 19.99 ns | 0.0210 ns | 0.0196 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.93 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.67 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.92 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.63 ns | 0.0136 ns | 0.0106 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULong.From_String_Empty_AsObject: DefaultJob
