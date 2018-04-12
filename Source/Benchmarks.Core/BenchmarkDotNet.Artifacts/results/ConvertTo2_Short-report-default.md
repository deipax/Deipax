
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.88 ns | 0.0006 ns | 0.0006 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.31 ns | 0.0606 ns | 0.0538 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.57 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.29 ns | 0.0241 ns | 0.0188 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.91 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.86 ns | 0.0041 ns | 0.0030 ns |      - |       0 B |
                                          From_Byte | 13.38 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
                                 From_Byte_AsObject | 25.29 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 17.87 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.32 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.16 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.40 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                                          From_Char | 13.64 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                                 From_Char_AsObject | 26.81 ns | 0.0203 ns | 0.0189 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 17.14 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 27.81 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.17 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 18.89 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                      From_DateTime | 15.01 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.04 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.04 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.44 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |
                                       From_Decimal | 25.65 ns | 0.0100 ns | 0.0083 ns |      - |       0 B |
                              From_Decimal_AsObject | 37.22 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 34.19 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 41.46 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 15.29 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.40 ns | 0.0311 ns | 0.0275 ns |      - |       0 B |
                                        From_Double | 17.34 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                               From_Double_AsObject | 29.13 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 21.16 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 29.13 ns | 0.0461 ns | 0.0409 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.05 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.45 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
                                         From_Short | 13.40 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                From_Short_AsObject | 17.77 ns | 0.0032 ns | 0.0023 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 13.67 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 18.50 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 13.99 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 22.18 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                                           From_Int | 14.49 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                                  From_Int_AsObject | 26.61 ns | 0.0514 ns | 0.0481 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.60 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 26.92 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.91 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.41 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                          From_Long | 14.66 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                 From_Long_AsObject | 26.57 ns | 0.0201 ns | 0.0179 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.36 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 26.57 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.05 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.42 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                                         From_SByte | 13.40 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                                From_SByte_AsObject | 25.29 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.84 ns | 0.0064 ns | 0.0059 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.34 ns | 0.0324 ns | 0.0303 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.22 ns | 0.0519 ns | 0.0485 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.38 ns | 0.0189 ns | 0.0147 ns |      - |       0 B |
                                         From_Float | 17.36 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                                From_Float_AsObject | 29.36 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 21.96 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 29.36 ns | 0.0256 ns | 0.0200 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.19 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 18.42 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                        From_String | 91.94 ns | 0.0424 ns | 0.0376 ns |      - |       0 B |
                               From_String_AsObject | 99.04 ns | 0.0349 ns | 0.0326 ns |      - |       0 B |
                                   From_String_Null | 15.71 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.41 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                                  From_String_Empty | 17.55 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 13.89 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                               From_UShort_AsObject | 27.51 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.27 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 26.85 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.81 ns | 0.0033 ns | 0.0024 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.64 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                          From_UInt | 14.02 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                 From_UInt_AsObject | 28.99 ns | 0.0047 ns | 0.0036 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 19.20 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 26.58 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.17 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.63 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                         From_ULong | 14.03 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                From_ULong_AsObject | 26.70 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.36 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.58 ns | 0.0294 ns | 0.0245 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.05 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.37 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
                                    From_NullObject | 17.81 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                        From_DBNull | 15.80 ns | 0.0215 ns | 0.0202 ns |      - |       0 B |
                              From_ConvertibleClass | 22.48 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 22.98 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.66 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.52 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.11 ns | 0.0037 ns | 0.0029 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.24 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 26.18 ns | 0.0021 ns | 0.0016 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.25 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.93 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.40 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                                          From_Enum | 14.34 ns | 0.0081 ns | 0.0075 ns |      - |       0 B |
                                 From_Enum_AsObject | 57.00 ns | 0.0272 ns | 0.0255 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 18.11 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 58.18 ns | 0.0201 ns | 0.0188 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.19 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.42 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Short.From_String_Empty_AsObject: DefaultJob
