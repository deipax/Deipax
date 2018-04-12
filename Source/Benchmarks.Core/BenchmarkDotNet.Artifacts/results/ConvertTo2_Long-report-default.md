
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.92 ns | 0.0300 ns | 0.0280 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.31 ns | 0.0352 ns | 0.0294 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.59 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.29 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.94 ns | 0.0278 ns | 0.0246 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.73 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                          From_Byte | 13.41 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
                                 From_Byte_AsObject | 25.30 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 15.97 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.30 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 17.14 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.71 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                                          From_Char | 13.40 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                                 From_Char_AsObject | 27.30 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 15.80 ns | 0.0136 ns | 0.0113 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 26.30 ns | 0.0213 ns | 0.0188 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.17 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.24 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                                      From_DateTime | 13.85 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.04 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.05 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.20 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                                       From_Decimal | 24.04 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                              From_Decimal_AsObject | 37.47 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 43.07 ns | 0.0270 ns | 0.0252 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 36.23 ns | 0.0348 ns | 0.0308 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 15.31 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.22 ns | 0.0106 ns | 0.0100 ns |      - |       0 B |
                                        From_Double | 17.11 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                               From_Double_AsObject | 30.11 ns | 0.0320 ns | 0.0283 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 20.41 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 30.08 ns | 0.0216 ns | 0.0180 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.05 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 19.09 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                         From_Short | 13.40 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                From_Short_AsObject | 25.31 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 15.81 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.47 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.18 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 18.91 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
                                           From_Int | 13.66 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                  From_Int_AsObject | 25.30 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 18.05 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 25.29 ns | 0.0240 ns | 0.0225 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.93 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.13 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                                          From_Long | 13.66 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                                 From_Long_AsObject | 18.07 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 15.20 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 17.85 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 14.27 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.25 ns | 0.0056 ns | 0.0046 ns |      - |       0 B |
                                         From_SByte | 13.40 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                From_SByte_AsObject | 25.28 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 15.96 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.29 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.16 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.18 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                         From_Float | 17.10 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
                                From_Float_AsObject | 31.12 ns | 0.0176 ns | 0.0147 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 19.89 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 31.08 ns | 0.0052 ns | 0.0037 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.17 ns | 0.0090 ns | 0.0085 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 18.25 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                        From_String | 88.71 ns | 0.0699 ns | 0.0654 ns |      - |       0 B |
                               From_String_AsObject | 98.68 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                                   From_String_Null | 15.77 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.16 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                                  From_String_Empty | 16.10 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 13.65 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                               From_UShort_AsObject | 25.30 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 15.95 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 25.34 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.91 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.17 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                          From_UInt | 13.40 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.28 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 15.95 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 25.32 ns | 0.0452 ns | 0.0423 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.16 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.21 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                         From_ULong | 13.92 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
                                From_ULong_AsObject | 26.10 ns | 0.0208 ns | 0.0185 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.08 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.06 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.04 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 18.84 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
                                    From_NullObject | 17.22 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                                        From_DBNull | 15.33 ns | 0.0097 ns | 0.0076 ns |      - |       0 B |
                              From_ConvertibleClass | 22.95 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 23.01 ns | 0.0440 ns | 0.0412 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.19 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 18.40 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
                             From_ConvertibleStruct | 23.23 ns | 0.0149 ns | 0.0132 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.27 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.26 ns | 0.0150 ns | 0.0133 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.26 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.95 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.52 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                          From_Enum | 13.39 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                 From_Enum_AsObject | 56.67 ns | 0.0337 ns | 0.0315 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 15.97 ns | 0.0200 ns | 0.0177 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 56.96 ns | 0.0270 ns | 0.0252 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.18 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 19.71 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
