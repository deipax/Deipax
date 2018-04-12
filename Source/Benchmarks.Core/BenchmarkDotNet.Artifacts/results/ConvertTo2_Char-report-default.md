
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 13.68 ns | 0.0478 ns | 0.0424 ns | 13.67 ns |      - |       0 B |
                                 From_Bool_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue | 13.42 ns | 0.0102 ns | 0.0095 ns | 13.41 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue | 13.17 ns | 0.0147 ns | 0.0130 ns | 13.17 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 18.26 ns | 0.0080 ns | 0.0071 ns | 18.26 ns |      - |       0 B |
                                          From_Byte | 13.38 ns | 0.0028 ns | 0.0023 ns | 13.38 ns |      - |       0 B |
                                 From_Byte_AsObject | 26.17 ns | 0.0155 ns | 0.0145 ns | 26.16 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 15.96 ns | 0.0242 ns | 0.0215 ns | 15.95 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 26.29 ns | 0.0020 ns | 0.0012 ns | 26.29 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.19 ns | 0.0302 ns | 0.0267 ns | 14.18 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 18.76 ns | 0.0102 ns | 0.0096 ns | 18.76 ns |      - |       0 B |
                                          From_Char | 13.40 ns | 0.0115 ns | 0.0102 ns | 13.40 ns |      - |       0 B |
                                 From_Char_AsObject | 18.11 ns | 0.0012 ns | 0.0010 ns | 18.11 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 14.58 ns | 0.0114 ns | 0.0095 ns | 14.58 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 18.95 ns | 0.0026 ns | 0.0020 ns | 18.95 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 13.65 ns | 0.0015 ns | 0.0012 ns | 13.65 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.11 ns | 0.0123 ns | 0.0115 ns | 17.11 ns |      - |       0 B |
                                      From_DateTime | 13.83 ns | 0.0045 ns | 0.0035 ns | 13.83 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.04 ns | 0.0094 ns | 0.0088 ns | 14.03 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.03 ns | 0.0022 ns | 0.0017 ns | 14.03 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.12 ns | 0.0017 ns | 0.0013 ns | 17.12 ns |      - |       0 B |
                                       From_Decimal | 14.02 ns | 0.0083 ns | 0.0070 ns | 14.02 ns |      - |       0 B |
                              From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue | 14.29 ns | 0.0020 ns | 0.0017 ns | 14.29 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue | 14.29 ns | 0.0028 ns | 0.0022 ns | 14.29 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 18.22 ns | 0.0159 ns | 0.0149 ns | 18.22 ns |      - |       0 B |
                                        From_Double | 13.15 ns | 0.0081 ns | 0.0076 ns | 13.14 ns |      - |       0 B |
                               From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue | 14.06 ns | 0.0046 ns | 0.0036 ns | 14.06 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue | 14.04 ns | 0.0034 ns | 0.0027 ns | 14.03 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.15 ns | 0.0207 ns | 0.0172 ns | 17.15 ns |      - |       0 B |
                                         From_Short | 13.64 ns | 0.0029 ns | 0.0024 ns | 13.64 ns |      - |       0 B |
                                From_Short_AsObject | 25.80 ns | 0.0186 ns | 0.0155 ns | 25.80 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.13 ns | 0.0032 ns | 0.0025 ns | 16.12 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.83 ns | 0.0223 ns | 0.0208 ns | 25.83 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.17 ns | 0.0091 ns | 0.0081 ns | 14.16 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.14 ns | 0.0124 ns | 0.0104 ns | 17.14 ns |      - |       0 B |
                                           From_Int | 14.66 ns | 0.0069 ns | 0.0065 ns | 14.66 ns |      - |       0 B |
                                  From_Int_AsObject | 26.57 ns | 0.0121 ns | 0.0113 ns | 26.57 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.61 ns | 0.0141 ns | 0.0132 ns | 17.61 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 26.60 ns | 0.0294 ns | 0.0275 ns | 26.59 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.92 ns | 0.0105 ns | 0.0098 ns | 13.93 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 18.19 ns | 0.0119 ns | 0.0111 ns | 18.19 ns |      - |       0 B |
                                          From_Long | 14.67 ns | 0.0111 ns | 0.0104 ns | 14.66 ns |      - |       0 B |
                                 From_Long_AsObject | 27.30 ns | 0.0225 ns | 0.0211 ns | 27.30 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.38 ns | 0.0059 ns | 0.0052 ns | 18.38 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 27.33 ns | 0.0248 ns | 0.0232 ns | 27.33 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.08 ns | 0.0338 ns | 0.0316 ns | 15.08 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.18 ns | 0.0141 ns | 0.0131 ns | 17.18 ns |      - |       0 B |
                                         From_SByte | 14.44 ns | 0.0031 ns | 0.0029 ns | 14.44 ns |      - |       0 B |
                                From_SByte_AsObject | 25.81 ns | 0.0180 ns | 0.0168 ns | 25.81 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.30 ns | 0.0232 ns | 0.0206 ns | 16.29 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 26.18 ns | 0.0172 ns | 0.0161 ns | 26.17 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.20 ns | 0.0029 ns | 0.0027 ns | 14.20 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.14 ns | 0.0116 ns | 0.0103 ns | 17.14 ns |      - |       0 B |
                                         From_Float | 13.16 ns | 0.0187 ns | 0.0175 ns | 13.15 ns |      - |       0 B |
                                From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue | 13.17 ns | 0.0034 ns | 0.0027 ns | 13.17 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue | 13.48 ns | 0.0240 ns | 0.0213 ns | 13.48 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 18.11 ns | 0.0118 ns | 0.0105 ns | 18.11 ns |      - |       0 B |
                                        From_String | 17.74 ns | 0.0041 ns | 0.0036 ns | 17.74 ns |      - |       0 B |
                               From_String_AsObject | 25.11 ns | 0.0127 ns | 0.0112 ns | 25.11 ns |      - |       0 B |
                                   From_String_Null | 15.51 ns | 0.0098 ns | 0.0082 ns | 15.51 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.12 ns | 0.0022 ns | 0.0015 ns | 17.12 ns |      - |       0 B |
                                  From_String_Empty | 15.74 ns | 0.0092 ns | 0.0082 ns | 15.74 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                        From_UShort | 13.65 ns | 0.0147 ns | 0.0138 ns | 13.64 ns |      - |       0 B |
                               From_UShort_AsObject | 25.38 ns | 0.0071 ns | 0.0063 ns | 25.38 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 15.95 ns | 0.0020 ns | 0.0018 ns | 15.95 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 25.28 ns | 0.0217 ns | 0.0203 ns | 25.28 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.31 ns | 0.0099 ns | 0.0092 ns | 14.31 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 18.35 ns | 0.0080 ns | 0.0075 ns | 18.35 ns |      - |       0 B |
                                          From_UInt | 13.89 ns | 0.0022 ns | 0.0018 ns | 13.89 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.81 ns | 0.0172 ns | 0.0134 ns | 25.81 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 17.45 ns | 0.0110 ns | 0.0103 ns | 17.44 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 25.81 ns | 0.0210 ns | 0.0197 ns | 25.81 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.16 ns | 0.0024 ns | 0.0020 ns | 14.16 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.15 ns | 0.0020 ns | 0.0013 ns | 17.15 ns |      - |       0 B |
                                         From_ULong | 14.15 ns | 0.0015 ns | 0.0013 ns | 14.15 ns |      - |       0 B |
                                From_ULong_AsObject | 26.32 ns | 0.0148 ns | 0.0116 ns | 26.32 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.11 ns | 0.0091 ns | 0.0085 ns | 18.10 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.65 ns | 0.0125 ns | 0.0104 ns | 26.65 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.05 ns | 0.0020 ns | 0.0015 ns | 15.05 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.15 ns | 0.0093 ns | 0.0072 ns | 17.15 ns |      - |       0 B |
                                    From_NullObject | 17.13 ns | 0.0022 ns | 0.0019 ns | 17.13 ns |      - |       0 B |
                                        From_DBNull | 15.33 ns | 0.0018 ns | 0.0015 ns | 15.33 ns |      - |       0 B |
                              From_ConvertibleClass | 22.48 ns | 0.0133 ns | 0.0118 ns | 22.47 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 22.97 ns | 0.0175 ns | 0.0137 ns | 22.97 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.18 ns | 0.0134 ns | 0.0119 ns | 17.19 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 18.78 ns | 0.0177 ns | 0.0166 ns | 18.78 ns |      - |       0 B |
                             From_ConvertibleStruct | 23.18 ns | 0.0208 ns | 0.0195 ns | 23.18 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.27 ns | 0.0084 ns | 0.0070 ns | 24.27 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.19 ns | 0.0166 ns | 0.0155 ns | 25.19 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.25 ns | 0.0146 ns | 0.0137 ns | 24.26 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.94 ns | 0.0043 ns | 0.0038 ns | 13.94 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.14 ns | 0.0077 ns | 0.0068 ns | 17.14 ns |      - |       0 B |
                                          From_Enum | 14.50 ns | 0.0088 ns | 0.0073 ns | 14.50 ns |      - |       0 B |
                                 From_Enum_AsObject | 57.15 ns | 0.0280 ns | 0.0262 ns | 57.15 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 18.12 ns | 0.0055 ns | 0.0049 ns | 18.12 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 57.22 ns | 0.0289 ns | 0.0270 ns | 57.23 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.19 ns | 0.0256 ns | 0.0240 ns | 14.18 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 18.15 ns | 0.0118 ns | 0.0110 ns | 18.15 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Char.From_Bool_AsObject: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_String_Empty_AsObject: DefaultJob
