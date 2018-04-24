
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 20.94 ns | 0.0118 ns | 0.0105 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject | 17.37 ns | 0.0275 ns | 0.0244 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 21.80 ns | 0.0156 ns | 0.0146 ns | 0.0057 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject | 16.64 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 18.70 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.90 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                                             From_Byte | 20.92 ns | 0.0112 ns | 0.0099 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject | 17.43 ns | 0.0396 ns | 0.0370 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 22.62 ns | 0.0138 ns | 0.0129 ns | 0.0057 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject | 17.25 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 18.73 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.64 ns | 0.0424 ns | 0.0396 ns |      - |       0 B |
                                             From_Char | 22.93 ns | 0.0216 ns | 0.0202 ns | 0.0057 |      24 B |
                                    From_Char_AsObject | 17.43 ns | 0.0393 ns | 0.0367 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 21.71 ns | 0.0292 ns | 0.0273 ns | 0.0057 |      24 B |
                 From_Char_Nullable_WithValue_AsObject | 17.24 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 19.55 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.64 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                                         From_DateTime | 22.36 ns | 0.0077 ns | 0.0064 ns | 0.0057 |      24 B |
                                From_DateTime_AsObject | 19.15 ns | 0.0317 ns | 0.0281 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue | 21.83 ns | 0.0224 ns | 0.0210 ns | 0.0057 |      24 B |
             From_DateTime_Nullable_WithValue_AsObject | 16.87 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue | 20.40 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.49 ns | 0.0252 ns | 0.0235 ns |      - |       0 B |
                                          From_Decimal | 21.73 ns | 0.0196 ns | 0.0174 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject | 16.65 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 22.50 ns | 0.0298 ns | 0.0279 ns | 0.0076 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | 19.16 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 18.86 ns | 0.0415 ns | 0.0389 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.63 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
                                           From_Double | 21.25 ns | 0.0058 ns | 0.0049 ns | 0.0057 |      24 B |
                                  From_Double_AsObject | 16.67 ns | 0.0242 ns | 0.0227 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 21.45 ns | 0.0088 ns | 0.0073 ns | 0.0057 |      24 B |
               From_Double_Nullable_WithValue_AsObject | 18.19 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 19.46 ns | 0.0163 ns | 0.0136 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.72 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                                            From_Short | 22.05 ns | 0.0213 ns | 0.0199 ns | 0.0057 |      24 B |
                                   From_Short_AsObject | 17.51 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 20.99 ns | 0.0363 ns | 0.0340 ns | 0.0057 |      24 B |
                From_Short_Nullable_WithValue_AsObject | 17.47 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 20.13 ns | 0.0214 ns | 0.0201 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.88 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                              From_Int | 20.96 ns | 0.0309 ns | 0.0289 ns | 0.0057 |      24 B |
                                     From_Int_AsObject | 16.93 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 21.56 ns | 0.0291 ns | 0.0272 ns | 0.0057 |      24 B |
                  From_Int_Nullable_WithValue_AsObject | 17.35 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 20.03 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 16.62 ns | 0.0269 ns | 0.0252 ns |      - |       0 B |
                                             From_Long | 20.91 ns | 0.0039 ns | 0.0030 ns | 0.0057 |      24 B |
                                    From_Long_AsObject | 17.30 ns | 0.0269 ns | 0.0252 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 21.79 ns | 0.0258 ns | 0.0242 ns | 0.0057 |      24 B |
                 From_Long_Nullable_WithValue_AsObject | 16.64 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 19.03 ns | 0.0315 ns | 0.0294 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.31 ns | 0.0164 ns | 0.0137 ns |      - |       0 B |
                                            From_SByte | 20.87 ns | 0.0289 ns | 0.0256 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject | 17.31 ns | 0.0215 ns | 0.0190 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 20.54 ns | 0.0134 ns | 0.0112 ns | 0.0057 |      24 B |
                From_SByte_Nullable_WithValue_AsObject | 16.78 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 18.73 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.27 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                                            From_Float | 20.36 ns | 0.0149 ns | 0.0132 ns | 0.0057 |      24 B |
                                   From_Float_AsObject | 16.63 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 21.75 ns | 0.0328 ns | 0.0307 ns | 0.0057 |      24 B |
                From_Float_Nullable_WithValue_AsObject | 17.40 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 19.67 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.86 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                                           From_String | 18.91 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                                  From_String_AsObject | 17.08 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                                      From_String_Null | 18.88 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.87 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                     From_String_Empty | 18.93 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |
                            From_String_Empty_AsObject | 17.71 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                                           From_UShort | 20.89 ns | 0.0234 ns | 0.0219 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject | 17.64 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 20.76 ns | 0.0049 ns | 0.0038 ns | 0.0057 |      24 B |
               From_UShort_Nullable_WithValue_AsObject | 17.85 ns | 0.0077 ns | 0.0060 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 18.59 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.62 ns | 0.0250 ns | 0.0221 ns |      - |       0 B |
                                             From_UInt | 20.93 ns | 0.0125 ns | 0.0111 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject | 16.88 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 21.13 ns | 0.0285 ns | 0.0267 ns | 0.0057 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject | 17.89 ns | 0.0089 ns | 0.0075 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 19.50 ns | 0.0301 ns | 0.0282 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.18 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                                            From_ULong | 20.83 ns | 0.0135 ns | 0.0119 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject | 16.72 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 21.79 ns | 0.0233 ns | 0.0207 ns | 0.0057 |      24 B |
                From_ULong_Nullable_WithValue_AsObject | 16.83 ns | 0.0074 ns | 0.0058 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 19.05 ns | 0.0157 ns | 0.0131 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.28 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
                                       From_NullObject | 16.75 ns | 0.0351 ns | 0.0329 ns |      - |       0 B |
                                           From_DBNull | 19.01 ns | 0.0291 ns | 0.0273 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.98 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.38 ns | 0.0444 ns | 0.0415 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 16.62 ns | 0.0257 ns | 0.0227 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.31 ns | 0.0056 ns | 0.0046 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.19 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
                              From_NonConvertibleClass | 19.09 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 16.62 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 18.14 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.39 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                From_ConvertibleStruct | 20.50 ns | 0.0337 ns | 0.0315 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 16.61 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 21.51 ns | 0.0187 ns | 0.0165 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 16.83 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 21.33 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.24 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
                             From_NonConvertibleStruct | 20.67 ns | 0.0259 ns | 0.0242 ns | 0.0057 |      24 B |
                    From_NonConvertibleStruct_AsObject | 16.61 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 21.76 ns | 0.0105 ns | 0.0093 ns | 0.0057 |      24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 16.62 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 18.99 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.53 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
                                             From_Enum | 20.91 ns | 0.0098 ns | 0.0087 ns | 0.0057 |      24 B |
                                    From_Enum_AsObject | 16.88 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue | 21.71 ns | 0.0232 ns | 0.0206 ns | 0.0057 |      24 B |
                 From_Enum_Nullable_WithValue_AsObject | 16.82 ns | 0.0257 ns | 0.0241 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue | 19.08 ns | 0.0157 ns | 0.0131 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.23 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                                      From_ParentClass | 20.34 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
                             From_ParentClass_AsObject | 17.41 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                              From_ParentClass_NoValue | 18.13 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.82 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                                     From_ParentStruct | 20.68 ns | 0.0152 ns | 0.0135 ns | 0.0057 |      24 B |
                            From_ParentStruct_AsObject | 16.61 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 21.47 ns | 0.0226 ns | 0.0189 ns | 0.0057 |      24 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 17.22 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 19.70 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.61 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |