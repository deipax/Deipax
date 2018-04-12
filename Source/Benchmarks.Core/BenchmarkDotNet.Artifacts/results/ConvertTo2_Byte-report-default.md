
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 14.81 ns | 0.0347 ns | 0.0307 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.33 ns | 0.0422 ns | 0.0352 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.58 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.29 ns | 0.0223 ns | 0.0198 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.91 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.74 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                                          From_Byte | 13.40 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                                 From_Byte_AsObject | 18.51 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 13.91 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 18.23 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 13.67 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 18.88 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                          From_Char | 14.44 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                 From_Char_AsObject | 26.81 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 17.15 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 26.80 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.17 ns | 0.0060 ns | 0.0057 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.81 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                      From_DateTime | 13.86 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.03 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.05 ns | 0.0340 ns | 0.0284 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.11 ns | 0.0144 ns | 0.0121 ns |      - |       0 B |
                                       From_Decimal | 29.17 ns | 0.0059 ns | 0.0056 ns |      - |       0 B |
                              From_Decimal_AsObject | 36.78 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 34.34 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 36.82 ns | 0.0391 ns | 0.0365 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 16.54 ns | 0.0191 ns | 0.0178 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.11 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                                        From_Double | 17.36 ns | 0.0184 ns | 0.0173 ns |      - |       0 B |
                               From_Double_AsObject | 29.14 ns | 0.0422 ns | 0.0395 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 21.18 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 29.14 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.07 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.14 ns | 0.0143 ns | 0.0133 ns |      - |       0 B |
                                         From_Short | 14.35 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
                                From_Short_AsObject | 26.58 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 18.88 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 26.56 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.16 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 19.19 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                                           From_Int | 14.42 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                                  From_Int_AsObject | 26.58 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.60 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 26.59 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.80 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.11 ns | 0.0017 ns | 0.0012 ns |      - |       0 B |
                                          From_Long | 15.42 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
                                 From_Long_AsObject | 26.57 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.36 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 26.57 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 16.75 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.15 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                         From_SByte | 14.43 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                                From_SByte_AsObject | 25.84 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 17.21 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.81 ns | 0.0178 ns | 0.0149 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.18 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.66 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                         From_Float | 17.36 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                                From_Float_AsObject | 30.67 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 20.92 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 29.65 ns | 0.0333 ns | 0.0311 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.17 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 18.31 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                        From_String | 90.41 ns | 0.0563 ns | 0.0526 ns |      - |       0 B |
                               From_String_AsObject | 99.76 ns | 0.0414 ns | 0.0346 ns |      - |       0 B |
                                   From_String_Null | 15.72 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                          From_String_Null_AsObject | 18.72 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                  From_String_Empty | 16.60 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 13.94 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                               From_UShort_AsObject | 26.29 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.28 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 26.66 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.52 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.11 ns | 0.0142 ns | 0.0132 ns |      - |       0 B |
                                          From_UInt | 13.66 ns | 0.0043 ns | 0.0031 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.83 ns | 0.0268 ns | 0.0238 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 17.18 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 25.84 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.17 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.11 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                                         From_ULong | 14.03 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                                From_ULong_AsObject | 26.58 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.37 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.56 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.06 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.10 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                                    From_NullObject | 17.09 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                                        From_DBNull | 16.00 ns | 0.0275 ns | 0.0243 ns |      - |       0 B |
                              From_ConvertibleClass | 22.53 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 23.00 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.16 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.08 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
                             From_ConvertibleStruct | 23.18 ns | 0.0280 ns | 0.0262 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.25 ns | 0.0167 ns | 0.0140 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.23 ns | 0.0132 ns | 0.0124 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.25 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 14.82 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.09 ns | 0.0277 ns | 0.0231 ns |      - |       0 B |
                                          From_Enum | 14.17 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                 From_Enum_AsObject | 59.26 ns | 0.0116 ns | 0.0091 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 17.85 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 58.67 ns | 0.0062 ns | 0.0058 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 14.16 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.13 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Byte.From_String_Empty_AsObject: DefaultJob
