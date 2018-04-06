
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 14.12 ns | 0.0102 ns | 0.0090 ns | 14.12 ns |      - |       0 B |
                                 From_Bool_AsObject | 28.09 ns | 0.0336 ns | 0.0298 ns | 28.09 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 13.71 ns | 0.0098 ns | 0.0092 ns | 13.71 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 28.13 ns | 0.0103 ns | 0.0086 ns | 28.13 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 12.62 ns | 0.0126 ns | 0.0118 ns | 12.61 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 16.67 ns | 0.0113 ns | 0.0106 ns | 16.67 ns |      - |       0 B |
                                          From_Byte | 14.52 ns | 0.0065 ns | 0.0054 ns | 14.52 ns |      - |       0 B |
                                 From_Byte_AsObject | 31.77 ns | 0.0230 ns | 0.0215 ns | 31.76 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 18.18 ns | 0.0044 ns | 0.0041 ns | 18.18 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 31.75 ns | 0.0272 ns | 0.0241 ns | 31.74 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 13.59 ns | 0.0019 ns | 0.0016 ns | 13.59 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.16 ns | 0.0149 ns | 0.0125 ns | 17.15 ns |      - |       0 B |
                                          From_Char | 13.38 ns | 0.0098 ns | 0.0092 ns | 13.38 ns |      - |       0 B |
                                 From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue | 14.22 ns | 0.0059 ns | 0.0052 ns | 14.22 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue | 20.04 ns | 0.0015 ns | 0.0012 ns | 20.04 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 16.62 ns | 0.0120 ns | 0.0113 ns | 16.62 ns |      - |       0 B |
                                      From_DateTime | 13.87 ns | 0.0047 ns | 0.0042 ns | 13.87 ns |      - |       0 B |
                             From_DateTime_AsObject | 23.56 ns | 0.0129 ns | 0.0121 ns | 23.56 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue | 15.14 ns | 0.0070 ns | 0.0062 ns | 15.13 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject | 24.05 ns | 0.0136 ns | 0.0127 ns | 24.06 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue | 14.08 ns | 0.0051 ns | 0.0042 ns | 14.08 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.21 ns | 0.0109 ns | 0.0102 ns | 17.21 ns |      - |       0 B |
                                       From_Decimal | 23.41 ns | 0.0144 ns | 0.0135 ns | 23.41 ns |      - |       0 B |
                              From_Decimal_AsObject | 42.89 ns | 0.2533 ns | 0.2369 ns | 42.85 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 28.68 ns | 0.0458 ns | 0.0383 ns | 28.67 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 43.26 ns | 1.2499 ns | 1.2276 ns | 42.91 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 16.27 ns | 0.4053 ns | 1.0168 ns | 15.86 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 16.76 ns | 0.0504 ns | 0.0421 ns | 16.74 ns |      - |       0 B |
                                        From_Double | 14.56 ns | 0.0822 ns | 0.0769 ns | 14.59 ns |      - |       0 B |
                               From_Double_AsObject | 31.77 ns | 0.0177 ns | 0.0138 ns | 31.76 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 19.80 ns | 0.0393 ns | 0.0367 ns | 19.82 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 31.78 ns | 0.0231 ns | 0.0193 ns | 31.78 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 14.72 ns | 0.0178 ns | 0.0158 ns | 14.72 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.38 ns | 0.0262 ns | 0.0219 ns | 17.37 ns |      - |       0 B |
                                         From_Short | 14.11 ns | 0.0095 ns | 0.0079 ns | 14.11 ns |      - |       0 B |
                                From_Short_AsObject | 31.51 ns | 0.0205 ns | 0.0160 ns | 31.50 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 17.32 ns | 0.0174 ns | 0.0135 ns | 17.32 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 31.57 ns | 0.1008 ns | 0.0943 ns | 31.50 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 13.62 ns | 0.0038 ns | 0.0029 ns | 13.62 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 16.65 ns | 0.0244 ns | 0.0204 ns | 16.64 ns |      - |       0 B |
                                           From_Int | 14.00 ns | 0.0172 ns | 0.0134 ns | 14.00 ns |      - |       0 B |
                                  From_Int_AsObject | 31.51 ns | 0.0217 ns | 0.0169 ns | 31.50 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.14 ns | 0.0080 ns | 0.0063 ns | 17.14 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 31.53 ns | 0.0647 ns | 0.0540 ns | 31.50 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.72 ns | 0.0105 ns | 0.0093 ns | 13.72 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 16.71 ns | 0.0259 ns | 0.0230 ns | 16.70 ns |      - |       0 B |
                                          From_Long | 14.40 ns | 0.0317 ns | 0.0297 ns | 14.41 ns |      - |       0 B |
                                 From_Long_AsObject | 31.56 ns | 0.1158 ns | 0.1083 ns | 31.50 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.41 ns | 0.0140 ns | 0.0101 ns | 18.40 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 31.59 ns | 0.1351 ns | 0.1264 ns | 31.51 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 14.50 ns | 0.0166 ns | 0.0147 ns | 14.50 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 16.68 ns | 0.0025 ns | 0.0020 ns | 16.68 ns |      - |       0 B |
                                         From_SByte | 15.11 ns | 0.0637 ns | 0.0596 ns | 15.14 ns |      - |       0 B |
                                From_SByte_AsObject | 31.56 ns | 0.1078 ns | 0.0955 ns | 31.50 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 17.15 ns | 0.0133 ns | 0.0125 ns | 17.15 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 31.55 ns | 0.0618 ns | 0.0548 ns | 31.54 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 13.68 ns | 0.0088 ns | 0.0074 ns | 13.68 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.53 ns | 0.0082 ns | 0.0064 ns | 17.53 ns |      - |       0 B |
                                         From_Float | 14.87 ns | 0.0101 ns | 0.0089 ns | 14.86 ns |      - |       0 B |
                                From_Float_AsObject | 31.53 ns | 0.0537 ns | 0.0502 ns | 31.50 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 18.73 ns | 0.0176 ns | 0.0137 ns | 18.73 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 31.55 ns | 0.0739 ns | 0.0691 ns | 31.50 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 13.87 ns | 0.0450 ns | 0.0421 ns | 13.86 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.47 ns | 0.0066 ns | 0.0052 ns | 17.47 ns |      - |       0 B |
                                        From_String | 39.04 ns | 0.0551 ns | 0.0515 ns | 39.04 ns |      - |       0 B |
                               From_String_AsObject | 51.21 ns | 0.0168 ns | 0.0149 ns | 51.21 ns |      - |       0 B |
                                   From_String_Null | 16.87 ns | 0.0205 ns | 0.0171 ns | 16.86 ns |      - |       0 B |
                          From_String_Null_AsObject | 16.64 ns | 0.0037 ns | 0.0029 ns | 16.64 ns |      - |       0 B |
                                  From_String_Empty | 20.57 ns | 0.0382 ns | 0.0357 ns | 20.56 ns |      - |       0 B |
                         From_String_Empty_AsObject | 24.83 ns | 0.0498 ns | 0.0466 ns | 24.80 ns |      - |       0 B |
                                        From_UShort | 13.97 ns | 0.0182 ns | 0.0161 ns | 13.96 ns |      - |       0 B |
                               From_UShort_AsObject | 31.51 ns | 0.0133 ns | 0.0111 ns | 31.51 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 19.19 ns | 0.0224 ns | 0.0175 ns | 19.19 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 31.57 ns | 0.0720 ns | 0.0674 ns | 31.58 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.60 ns | 0.0112 ns | 0.0093 ns | 13.60 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.23 ns | 0.0364 ns | 0.0340 ns | 17.21 ns |      - |       0 B |
                                          From_UInt | 13.68 ns | 0.0307 ns | 0.0272 ns | 13.67 ns |      - |       0 B |
                                 From_UInt_AsObject | 31.50 ns | 0.0082 ns | 0.0064 ns | 31.50 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 17.07 ns | 0.0213 ns | 0.0189 ns | 17.07 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 31.49 ns | 0.0080 ns | 0.0067 ns | 31.49 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 13.73 ns | 0.0205 ns | 0.0160 ns | 13.73 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.06 ns | 0.0077 ns | 0.0060 ns | 17.06 ns |      - |       0 B |
                                         From_ULong | 14.40 ns | 0.0280 ns | 0.0248 ns | 14.38 ns |      - |       0 B |
                                From_ULong_AsObject | 31.54 ns | 0.0696 ns | 0.0651 ns | 31.51 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 19.48 ns | 0.0242 ns | 0.0215 ns | 19.48 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 31.51 ns | 0.0219 ns | 0.0171 ns | 31.51 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 14.50 ns | 0.0257 ns | 0.0228 ns | 14.49 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 16.65 ns | 0.0056 ns | 0.0044 ns | 16.65 ns |      - |       0 B |
                                    From_NullObject | 16.68 ns | 0.0408 ns | 0.0381 ns | 16.66 ns |      - |       0 B |
                                        From_DBNull | 17.32 ns | 0.0034 ns | 0.0030 ns | 17.32 ns |      - |       0 B |
                              From_ConvertibleClass | 25.48 ns | 0.0307 ns | 0.0272 ns | 25.47 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 29.08 ns | 0.0180 ns | 0.0160 ns | 29.08 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.42 ns | 0.0545 ns | 0.0509 ns | 17.41 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 16.66 ns | 0.0641 ns | 0.0568 ns | 16.63 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.84 ns | 0.0324 ns | 0.0287 ns | 22.84 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 30.56 ns | 0.0110 ns | 0.0097 ns | 30.56 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 26.20 ns | 0.1081 ns | 0.0958 ns | 26.15 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 30.55 ns | 0.1689 ns | 0.1580 ns | 30.44 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.73 ns | 0.0106 ns | 0.0094 ns | 13.73 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.63 ns | 0.0403 ns | 0.0377 ns | 17.60 ns |      - |       0 B |
                                          From_Enum | 13.68 ns | 0.0434 ns | 0.0385 ns | 13.66 ns |      - |       0 B |
                                 From_Enum_AsObject | 65.58 ns | 0.0216 ns | 0.0180 ns | 65.59 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 17.28 ns | 0.0340 ns | 0.0284 ns | 17.27 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 65.69 ns | 0.1486 ns | 0.1317 ns | 65.73 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 13.64 ns | 0.0086 ns | 0.0080 ns | 13.64 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.40 ns | 0.0254 ns | 0.0237 ns | 17.39 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
