
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 12.81 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                                 From_Bool_AsObject | 16.93 ns | 0.0270 ns | 0.0240 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 13.34 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 16.94 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.69 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 16.43 ns | 0.0318 ns | 0.0298 ns |      - |       0 B |
                                          From_Byte | 12.63 ns | 0.0152 ns | 0.0143 ns |      - |       0 B |
                                 From_Byte_AsObject | 29.65 ns | 0.0852 ns | 0.0797 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 17.87 ns | 0.0347 ns | 0.0307 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 29.68 ns | 0.0567 ns | 0.0531 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 13.15 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 16.37 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                                          From_Char | 12.71 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                 From_Char_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue | 12.63 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue | 12.80 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 16.22 ns | 0.0439 ns | 0.0411 ns |      - |       0 B |
                                      From_DateTime | 13.06 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                             From_DateTime_AsObject | 20.97 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue | 13.62 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject | 21.93 ns | 0.0130 ns | 0.0116 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue | 13.61 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 16.88 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                       From_Decimal | 23.27 ns | 0.1087 ns | 0.0908 ns |      - |       0 B |
                              From_Decimal_AsObject | 39.55 ns | 0.0334 ns | 0.0279 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 29.01 ns | 0.0381 ns | 0.0356 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 39.55 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 14.54 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 16.14 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                        From_Double | 14.08 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                               From_Double_AsObject | 29.63 ns | 0.0537 ns | 0.0476 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 17.82 ns | 0.0331 ns | 0.0310 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 29.59 ns | 0.0384 ns | 0.0340 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 14.19 ns | 0.0081 ns | 0.0063 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 16.11 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                                         From_Short | 12.85 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                                From_Short_AsObject | 29.31 ns | 0.0056 ns | 0.0043 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 17.16 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 29.32 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.31 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 16.40 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                           From_Int | 13.05 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                                  From_Int_AsObject | 29.33 ns | 0.0399 ns | 0.0373 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 16.61 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 29.32 ns | 0.0372 ns | 0.0311 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.25 ns | 0.0120 ns | 0.0101 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 16.47 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                          From_Long | 12.86 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                 From_Long_AsObject | 29.33 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 17.53 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 29.32 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.15 ns | 0.0707 ns | 0.0661 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 16.19 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                         From_SByte | 12.82 ns | 0.0052 ns | 0.0038 ns |      - |       0 B |
                                From_SByte_AsObject | 29.32 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.55 ns | 0.0305 ns | 0.0271 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 29.32 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 13.20 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 16.23 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                         From_Float | 13.06 ns | 0.0266 ns | 0.0235 ns |      - |       0 B |
                                From_Float_AsObject | 29.33 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 18.73 ns | 0.0079 ns | 0.0066 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 29.35 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 13.16 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 16.58 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                                        From_String | 37.51 ns | 0.0660 ns | 0.0617 ns |      - |       0 B |
                               From_String_AsObject | 48.09 ns | 0.0713 ns | 0.0667 ns |      - |       0 B |
                                   From_String_Null | 16.14 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                          From_String_Null_AsObject | 16.13 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                  From_String_Empty | 19.44 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                         From_String_Empty_AsObject | 22.76 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                        From_UShort | 13.98 ns | 0.0384 ns | 0.0359 ns |      - |       0 B |
                               From_UShort_AsObject | 29.31 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 17.89 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 29.33 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 12.98 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 16.13 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
                                          From_UInt | 12.90 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                                 From_UInt_AsObject | 29.32 ns | 0.0271 ns | 0.0226 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 16.54 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 29.38 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 13.15 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 16.11 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                         From_ULong | 12.63 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                From_ULong_AsObject | 30.34 ns | 0.0281 ns | 0.0262 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.50 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 29.36 ns | 0.0703 ns | 0.0658 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.19 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 16.11 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                    From_NullObject | 16.52 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                        From_DBNull | 14.58 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                              From_ConvertibleClass | 23.72 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 26.90 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.36 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 16.13 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.69 ns | 0.0108 ns | 0.0096 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 28.23 ns | 0.0195 ns | 0.0153 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.89 ns | 0.0090 ns | 0.0075 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 28.23 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 12.97 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.12 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                          From_Enum | 12.91 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                                 From_Enum_AsObject | 63.23 ns | 0.0108 ns | 0.0096 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 16.59 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 63.24 ns | 0.0173 ns | 0.0153 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 13.15 ns | 0.0081 ns | 0.0075 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 16.39 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
