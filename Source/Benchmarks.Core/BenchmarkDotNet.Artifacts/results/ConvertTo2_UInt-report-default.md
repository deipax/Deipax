
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.59 ns | 0.1168 ns | 0.1036 ns |      - |       0 B |
                                    From_Bool_AsObject | 23.87 ns | 0.0499 ns | 0.0443 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.29 ns | 0.0230 ns | 0.0192 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 22.79 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.41 ns | 0.0123 ns | 0.0102 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.13 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                             From_Byte | 13.05 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.80 ns | 0.0226 ns | 0.0200 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.82 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.86 ns | 0.0258 ns | 0.0242 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.68 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 15.91 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                                             From_Char | 13.04 ns | 0.0240 ns | 0.0225 ns |      - |       0 B |
                                    From_Char_AsObject | 23.55 ns | 0.0568 ns | 0.0531 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.81 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 24.57 ns | 0.0402 ns | 0.0376 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.66 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.04 ns | 0.0052 ns | 0.0041 ns |      - |       0 B |
                                         From_DateTime | 13.47 ns | 0.0238 ns | 0.0223 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.35 ns | 0.0173 ns | 0.0161 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.33 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.05 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                                          From_Decimal | 23.56 ns | 0.0631 ns | 0.0591 ns |      - |       0 B |
                                 From_Decimal_AsObject | 33.56 ns | 0.0846 ns | 0.0750 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 25.19 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 32.52 ns | 0.1078 ns | 0.0956 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.37 ns | 0.0139 ns | 0.0124 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.94 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
                                           From_Double | 15.42 ns | 0.0177 ns | 0.0165 ns |      - |       0 B |
                                  From_Double_AsObject | 25.96 ns | 0.0379 ns | 0.0355 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 16.93 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 25.17 ns | 0.0439 ns | 0.0389 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.32 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.17 ns | 0.0313 ns | 0.0292 ns |      - |       0 B |
                                            From_Short | 13.53 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                                   From_Short_AsObject | 24.57 ns | 0.0318 ns | 0.0282 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.31 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.59 ns | 0.0720 ns | 0.0673 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.74 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.18 ns | 0.0382 ns | 0.0357 ns |      - |       0 B |
                                              From_Int | 14.03 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                     From_Int_AsObject | 23.54 ns | 0.0376 ns | 0.0351 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.38 ns | 0.0230 ns | 0.0192 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 23.54 ns | 0.0443 ns | 0.0414 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.44 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.17 ns | 0.0376 ns | 0.0351 ns |      - |       0 B |
                                             From_Long | 14.50 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
                                    From_Long_AsObject | 24.30 ns | 0.0321 ns | 0.0300 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.92 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 24.27 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.33 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 20.18 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                            From_SByte | 13.54 ns | 0.0132 ns | 0.0103 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.57 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.46 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.51 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.73 ns | 0.0345 ns | 0.0322 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.96 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                            From_Float | 15.06 ns | 0.0067 ns | 0.0052 ns |      - |       0 B |
                                   From_Float_AsObject | 26.34 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 15.83 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 25.35 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.66 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 16.83 ns | 0.0197 ns | 0.0164 ns |      - |       0 B |
                                           From_String | 85.50 ns | 0.0426 ns | 0.0333 ns |      - |       0 B |
                                  From_String_AsObject | 92.04 ns | 0.0410 ns | 0.0363 ns |      - |       0 B |
                                      From_String_Null | 15.06 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                             From_String_Null_AsObject | 16.12 ns | 0.0122 ns | 0.0096 ns |      - |       0 B |
                                     From_String_Empty | 15.13 ns | 0.0053 ns | 0.0042 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.19 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                  From_UShort_AsObject | 23.11 ns | 0.0423 ns | 0.0395 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.80 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.05 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.42 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.11 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                                             From_UInt | 13.03 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                    From_UInt_AsObject | 16.73 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 13.80 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 16.76 ns | 0.0442 ns | 0.0413 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.69 ns | 0.0273 ns | 0.0255 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 16.84 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                                            From_ULong | 13.55 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                                   From_ULong_AsObject | 24.66 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.57 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 23.57 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.55 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.08 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                                       From_NullObject | 15.95 ns | 0.0406 ns | 0.0380 ns |      - |       0 B |
                                           From_DBNull | 14.58 ns | 0.0079 ns | 0.0062 ns |      - |       0 B |
                                  From_DBNull_AsObject | 15.99 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                 From_ConvertibleClass | 20.01 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.96 ns | 0.0416 ns | 0.0348 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.30 ns | 0.0081 ns | 0.0063 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 15.98 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.74 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 18.22 ns | 0.0429 ns | 0.0402 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.30 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 19.54 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.21 ns | 0.0249 ns | 0.0233 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 23.34 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.43 ns | 0.0368 ns | 0.0344 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.30 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.17 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.03 ns | 0.0281 ns | 0.0235 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.04 ns | 0.0053 ns | 0.0041 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.22 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.91 ns | 0.0242 ns | 0.0215 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 18.17 ns | 0.0317 ns | 0.0296 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.94 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.95 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
                                             From_Enum | 13.94 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                                    From_Enum_AsObject | 53.17 ns | 0.0225 ns | 0.0176 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 14.47 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 53.22 ns | 0.0768 ns | 0.0718 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.51 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.43 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                                      From_ParentClass | 14.33 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                             From_ParentClass_AsObject | 18.69 ns | 0.0521 ns | 0.0487 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.35 ns | 0.0157 ns | 0.0140 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 16.88 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                                     From_ParentStruct | 14.08 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 19.33 ns | 0.0143 ns | 0.0120 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.98 ns | 0.0339 ns | 0.0317 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.69 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.95 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.93 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UInt.From_String_Empty_AsObject: DefaultJob
