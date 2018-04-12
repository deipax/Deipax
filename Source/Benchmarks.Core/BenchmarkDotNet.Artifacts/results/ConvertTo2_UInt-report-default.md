
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 13.94 ns | 0.0504 ns | 0.0471 ns | 13.90 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.31 ns | 0.0278 ns | 0.0247 ns | 25.31 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.57 ns | 0.0126 ns | 0.0118 ns | 16.57 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.32 ns | 0.0259 ns | 0.0242 ns | 25.31 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.91 ns | 0.0071 ns | 0.0063 ns | 13.91 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.19 ns | 0.0044 ns | 0.0039 ns | 17.19 ns |      - |       0 B |
                                          From_Byte | 14.20 ns | 0.0107 ns | 0.0100 ns | 14.20 ns |      - |       0 B |
                                 From_Byte_AsObject | 25.32 ns | 0.0518 ns | 0.0485 ns | 25.30 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 15.96 ns | 0.0106 ns | 0.0100 ns | 15.95 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.31 ns | 0.0184 ns | 0.0172 ns | 25.30 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.51 ns | 0.0111 ns | 0.0104 ns | 14.52 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 19.24 ns | 0.0111 ns | 0.0098 ns | 19.24 ns |      - |       0 B |
                                          From_Char | 13.41 ns | 0.0114 ns | 0.0107 ns | 13.40 ns |      - |       0 B |
                                 From_Char_AsObject | 26.30 ns | 0.0176 ns | 0.0147 ns | 26.30 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 16.79 ns | 0.0121 ns | 0.0113 ns | 16.79 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 26.31 ns | 0.0322 ns | 0.0301 ns | 26.30 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.18 ns | 0.0083 ns | 0.0078 ns | 14.18 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.04 ns | 0.0263 ns | 0.0246 ns | 17.03 ns |      - |       0 B |
                                      From_DateTime | 13.86 ns | 0.0240 ns | 0.0213 ns | 13.85 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.05 ns | 0.0049 ns | 0.0045 ns | 14.05 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.05 ns | 0.0138 ns | 0.0116 ns | 14.04 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.08 ns | 0.0214 ns | 0.0190 ns | 17.08 ns |      - |       0 B |
                                       From_Decimal | 25.54 ns | 0.0199 ns | 0.0187 ns | 25.54 ns |      - |       0 B |
                              From_Decimal_AsObject | 35.73 ns | 0.0210 ns | 0.0186 ns | 35.73 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 33.16 ns | 0.0489 ns | 0.0457 ns | 33.14 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 35.27 ns | 0.0275 ns | 0.0257 ns | 35.26 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 15.30 ns | 0.0016 ns | 0.0012 ns | 15.30 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.08 ns | 0.0153 ns | 0.0143 ns | 17.09 ns |      - |       0 B |
                                        From_Double | 16.09 ns | 0.0021 ns | 0.0017 ns | 16.09 ns |      - |       0 B |
                               From_Double_AsObject | 28.06 ns | 0.0235 ns | 0.0208 ns | 28.06 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 18.94 ns | 0.0035 ns | 0.0031 ns | 18.94 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 28.07 ns | 0.0235 ns | 0.0219 ns | 28.06 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.87 ns | 0.0101 ns | 0.0094 ns | 15.87 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.16 ns | 0.0137 ns | 0.0122 ns | 17.16 ns |      - |       0 B |
                                         From_Short | 13.65 ns | 0.0015 ns | 0.0013 ns | 13.65 ns |      - |       0 B |
                                From_Short_AsObject | 25.81 ns | 0.0124 ns | 0.0116 ns | 25.81 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.14 ns | 0.0160 ns | 0.0142 ns | 16.13 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.81 ns | 0.0194 ns | 0.0162 ns | 25.82 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.17 ns | 0.0029 ns | 0.0025 ns | 14.17 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 20.82 ns | 0.0122 ns | 0.0109 ns | 20.82 ns |      - |       0 B |
                                           From_Int | 13.93 ns | 0.0244 ns | 0.0229 ns | 13.92 ns |      - |       0 B |
                                  From_Int_AsObject | 26.30 ns | 0.0172 ns | 0.0161 ns | 26.30 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 16.59 ns | 0.0053 ns | 0.0047 ns | 16.59 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 26.64 ns | 0.0170 ns | 0.0142 ns | 26.64 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.95 ns | 0.0432 ns | 0.0404 ns | 13.93 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.10 ns | 0.0222 ns | 0.0208 ns | 17.10 ns |      - |       0 B |
                                          From_Long | 14.51 ns | 0.0062 ns | 0.0058 ns | 14.51 ns |      - |       0 B |
                                 From_Long_AsObject | 26.58 ns | 0.0201 ns | 0.0188 ns | 26.58 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.41 ns | 0.0182 ns | 0.0170 ns | 18.41 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 26.58 ns | 0.0197 ns | 0.0185 ns | 26.58 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.05 ns | 0.0046 ns | 0.0043 ns | 15.05 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.64 ns | 0.0134 ns | 0.0126 ns | 17.64 ns |      - |       0 B |
                                         From_SByte | 13.68 ns | 0.0344 ns | 0.0322 ns | 13.66 ns |      - |       0 B |
                                From_SByte_AsObject | 25.81 ns | 0.0176 ns | 0.0164 ns | 25.82 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.28 ns | 0.0047 ns | 0.0044 ns | 16.28 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.82 ns | 0.0246 ns | 0.0230 ns | 25.82 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.18 ns | 0.0142 ns | 0.0118 ns | 14.18 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.10 ns | 0.0184 ns | 0.0172 ns | 17.10 ns |      - |       0 B |
                                         From_Float | 15.21 ns | 0.0029 ns | 0.0025 ns | 15.21 ns |      - |       0 B |
                                From_Float_AsObject | 28.51 ns | 0.0247 ns | 0.0193 ns | 28.50 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 19.15 ns | 0.0153 ns | 0.0143 ns | 19.16 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 28.52 ns | 0.0253 ns | 0.0224 ns | 28.52 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.18 ns | 0.0066 ns | 0.0061 ns | 14.18 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.13 ns | 0.0107 ns | 0.0100 ns | 17.14 ns |      - |       0 B |
                                        From_String | 86.04 ns | 0.0356 ns | 0.0297 ns | 86.03 ns |      - |       0 B |
                               From_String_AsObject | 95.63 ns | 0.0493 ns | 0.0437 ns | 95.61 ns |      - |       0 B |
                                   From_String_Null | 15.82 ns | 0.0145 ns | 0.0135 ns | 15.82 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.14 ns | 0.0100 ns | 0.0066 ns | 17.14 ns |      - |       0 B |
                                  From_String_Empty | 16.10 ns | 0.0120 ns | 0.0112 ns | 16.11 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                        From_UShort | 13.65 ns | 0.0006 ns | 0.0005 ns | 13.65 ns |      - |       0 B |
                               From_UShort_AsObject | 25.31 ns | 0.0290 ns | 0.0271 ns | 25.30 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 15.95 ns | 0.0025 ns | 0.0021 ns | 15.95 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 25.29 ns | 0.0213 ns | 0.0189 ns | 25.29 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.91 ns | 0.0101 ns | 0.0094 ns | 13.91 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.11 ns | 0.0105 ns | 0.0099 ns | 17.11 ns |      - |       0 B |
                                          From_UInt | 13.40 ns | 0.0038 ns | 0.0031 ns | 13.40 ns |      - |       0 B |
                                 From_UInt_AsObject | 18.52 ns | 0.0056 ns | 0.0047 ns | 18.52 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 14.70 ns | 0.0029 ns | 0.0024 ns | 14.70 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 17.76 ns | 0.0279 ns | 0.0261 ns | 17.74 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.65 ns | 0.0029 ns | 0.0022 ns | 14.65 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.11 ns | 0.0258 ns | 0.0241 ns | 17.13 ns |      - |       0 B |
                                         From_ULong | 13.67 ns | 0.0005 ns | 0.0005 ns | 13.67 ns |      - |       0 B |
                                From_ULong_AsObject | 25.82 ns | 0.0192 ns | 0.0179 ns | 25.82 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.88 ns | 0.0205 ns | 0.0192 ns | 17.88 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 25.81 ns | 0.0158 ns | 0.0148 ns | 25.81 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.04 ns | 0.0025 ns | 0.0019 ns | 15.04 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 18.06 ns | 0.0104 ns | 0.0098 ns | 18.06 ns |      - |       0 B |
                                    From_NullObject | 17.83 ns | 0.0104 ns | 0.0092 ns | 17.83 ns |      - |       0 B |
                                        From_DBNull | 16.65 ns | 0.0023 ns | 0.0021 ns | 16.65 ns |      - |       0 B |
                              From_ConvertibleClass | 22.50 ns | 0.0370 ns | 0.0328 ns | 22.47 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 24.09 ns | 0.0059 ns | 0.0050 ns | 24.09 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.19 ns | 0.0122 ns | 0.0114 ns | 17.18 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.16 ns | 0.0021 ns | 0.0018 ns | 17.16 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.12 ns | 0.0047 ns | 0.0039 ns | 22.12 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.24 ns | 0.0121 ns | 0.0101 ns | 24.24 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.13 ns | 0.0045 ns | 0.0037 ns | 25.13 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.25 ns | 0.0120 ns | 0.0113 ns | 24.24 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 14.82 ns | 0.0027 ns | 0.0024 ns | 14.82 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.11 ns | 0.0025 ns | 0.0021 ns | 17.11 ns |      - |       0 B |
                                          From_Enum | 13.64 ns | 0.0091 ns | 0.0081 ns | 13.64 ns |      - |       0 B |
                                 From_Enum_AsObject | 56.84 ns | 0.0224 ns | 0.0199 ns | 56.84 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 16.28 ns | 0.0161 ns | 0.0134 ns | 16.27 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 57.01 ns | 0.0236 ns | 0.0221 ns | 57.00 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.16 ns | 0.0015 ns | 0.0012 ns | 14.16 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 18.25 ns | 0.0029 ns | 0.0024 ns | 18.25 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UInt.From_String_Empty_AsObject: DefaultJob
