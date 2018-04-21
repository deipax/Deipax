
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 16.25 ns | 0.3080 ns | 0.2881 ns |      - |       0 B |
                                    From_Bool_AsObject | 27.87 ns | 0.0838 ns | 0.0743 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 16.70 ns | 0.0658 ns | 0.0583 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 27.02 ns | 0.3175 ns | 0.2970 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 16.16 ns | 0.3230 ns | 0.3022 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.73 ns | 0.0538 ns | 0.0477 ns |      - |       0 B |
                                             From_Byte | 15.44 ns | 0.0158 ns | 0.0123 ns |      - |       0 B |
                                    From_Byte_AsObject | 27.10 ns | 0.2395 ns | 0.2240 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 15.90 ns | 0.1121 ns | 0.0875 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 26.88 ns | 0.1127 ns | 0.0999 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.84 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.96 ns | 0.2229 ns | 0.2085 ns |      - |       0 B |
                                             From_Char | 15.43 ns | 0.0793 ns | 0.0662 ns |      - |       0 B |
                                    From_Char_AsObject | 28.66 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 15.86 ns | 0.0897 ns | 0.0795 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 29.17 ns | 0.4969 ns | 0.4648 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 15.87 ns | 0.0531 ns | 0.0443 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.19 ns | 0.0204 ns | 0.0159 ns |      - |       0 B |
                                         From_DateTime | 15.33 ns | 0.0161 ns | 0.0135 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 15.62 ns | 0.0386 ns | 0.0342 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.67 ns | 0.0724 ns | 0.0677 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 19.18 ns | 0.2189 ns | 0.1940 ns |      - |       0 B |
                                          From_Decimal | 25.16 ns | 0.1457 ns | 0.1291 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.84 ns | 0.1377 ns | 0.1221 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 27.51 ns | 0.3443 ns | 0.3052 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.96 ns | 0.3789 ns | 0.3359 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 16.16 ns | 0.1120 ns | 0.0935 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.75 ns | 0.0645 ns | 0.0539 ns |      - |       0 B |
                                           From_Double | 19.12 ns | 0.2168 ns | 0.1921 ns |      - |       0 B |
                                  From_Double_AsObject | 32.18 ns | 0.5552 ns | 0.4921 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 20.51 ns | 0.4029 ns | 0.3768 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 32.44 ns | 0.6493 ns | 0.6377 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 16.08 ns | 0.2069 ns | 0.1936 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.92 ns | 0.2514 ns | 0.2229 ns |      - |       0 B |
                                            From_Short | 15.47 ns | 0.0712 ns | 0.0631 ns |      - |       0 B |
                                   From_Short_AsObject | 27.02 ns | 0.1999 ns | 0.1772 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 16.14 ns | 0.0805 ns | 0.0673 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 27.05 ns | 0.2405 ns | 0.2132 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.85 ns | 0.0216 ns | 0.0180 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.91 ns | 0.3790 ns | 0.3722 ns |      - |       0 B |
                                              From_Int | 15.39 ns | 0.0709 ns | 0.0592 ns |      - |       0 B |
                                     From_Int_AsObject | 26.87 ns | 0.0695 ns | 0.0616 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.90 ns | 0.1101 ns | 0.0919 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 27.89 ns | 0.0163 ns | 0.0145 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 15.83 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.83 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
                                             From_Long | 15.33 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                                    From_Long_AsObject | 31.28 ns | 0.0252 ns | 0.0224 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 15.66 ns | 0.0083 ns | 0.0065 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 30.10 ns | 0.0338 ns | 0.0300 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.59 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.93 ns | 0.0252 ns | 0.0210 ns |      - |       0 B |
                                            From_SByte | 15.38 ns | 0.0077 ns | 0.0065 ns |      - |       0 B |
                                   From_SByte_AsObject | 27.06 ns | 0.0353 ns | 0.0295 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 16.10 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.85 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.83 ns | 0.0086 ns | 0.0067 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 19.68 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                                            From_Float | 19.40 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                                   From_Float_AsObject | 32.96 ns | 0.0286 ns | 0.0239 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 20.19 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 33.36 ns | 0.3210 ns | 0.3003 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 15.83 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.66 ns | 0.0223 ns | 0.0197 ns |      - |       0 B |
                                           From_String | 89.22 ns | 0.0613 ns | 0.0544 ns |      - |       0 B |
                                  From_String_AsObject | 99.41 ns | 0.1234 ns | 0.1155 ns |      - |       0 B |
                                      From_String_Null | 16.59 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.70 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                                     From_String_Empty | 16.40 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 15.40 ns | 0.0286 ns | 0.0267 ns |      - |       0 B |
                                  From_UShort_AsObject | 26.76 ns | 0.0164 ns | 0.0146 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 15.83 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 26.80 ns | 0.0343 ns | 0.0321 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 15.82 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.69 ns | 0.0161 ns | 0.0126 ns |      - |       0 B |
                                             From_UInt | 15.31 ns | 0.0043 ns | 0.0033 ns |      - |       0 B |
                                    From_UInt_AsObject | 26.82 ns | 0.0361 ns | 0.0320 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.83 ns | 0.0053 ns | 0.0041 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 26.78 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 15.84 ns | 0.0222 ns | 0.0185 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.66 ns | 0.0116 ns | 0.0097 ns |      - |       0 B |
                                            From_ULong | 16.07 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                                   From_ULong_AsObject | 27.66 ns | 0.0425 ns | 0.0355 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.60 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 27.84 ns | 0.0386 ns | 0.0361 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.83 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 18.27 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                       From_NullObject | 17.69 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
                                           From_DBNull | 16.48 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                                  From_DBNull_AsObject | 18.15 ns | 0.0379 ns | 0.0336 ns |      - |       0 B |
                                 From_ConvertibleClass | 22.32 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 25.31 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.92 ns | 0.0237 ns | 0.0198 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 19.62 ns | 0.0058 ns | 0.0048 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.89 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 20.71 ns | 0.0520 ns | 0.0461 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.98 ns | 0.0260 ns | 0.0230 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.69 ns | 0.0065 ns | 0.0050 ns |      - |       0 B |
                                From_ConvertibleStruct | 24.36 ns | 0.0072 ns | 0.0060 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 26.59 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 24.78 ns | 0.0392 ns | 0.0348 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.55 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 15.72 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 19.51 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                             From_NonConvertibleStruct | 15.89 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 20.68 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.92 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 22.59 ns | 0.0189 ns | 0.0158 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 15.86 ns | 0.0048 ns | 0.0038 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.35 ns | 0.0170 ns | 0.0133 ns |      - |       0 B |
                                             From_Enum | 16.28 ns | 0.0079 ns | 0.0062 ns |      - |       0 B |
                                    From_Enum_AsObject | 57.99 ns | 0.0474 ns | 0.0396 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 15.66 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 58.21 ns | 0.0453 ns | 0.0424 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 15.40 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.68 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
                                      From_ParentClass | 15.83 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.40 ns | 0.0246 ns | 0.0219 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.83 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.69 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                                     From_ParentStruct | 16.57 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 21.26 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 15.86 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 21.20 ns | 0.0219 ns | 0.0182 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.90 ns | 0.0464 ns | 0.0411 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 21.35 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
