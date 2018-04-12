
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 13.90 ns | 0.0233 ns | 0.0194 ns | 13.89 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.30 ns | 0.0392 ns | 0.0327 ns | 25.30 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.58 ns | 0.0123 ns | 0.0115 ns | 16.59 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.30 ns | 0.0191 ns | 0.0169 ns | 25.29 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.92 ns | 0.0137 ns | 0.0129 ns | 13.91 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.14 ns | 0.0232 ns | 0.0205 ns | 17.14 ns |      - |       0 B |
                                          From_Byte | 13.42 ns | 0.0107 ns | 0.0100 ns | 13.42 ns |      - |       0 B |
                                 From_Byte_AsObject | 25.34 ns | 0.0218 ns | 0.0204 ns | 25.34 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 15.96 ns | 0.0121 ns | 0.0113 ns | 15.97 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.30 ns | 0.0264 ns | 0.0221 ns | 25.30 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.17 ns | 0.0113 ns | 0.0106 ns | 14.16 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.10 ns | 0.0107 ns | 0.0100 ns | 17.10 ns |      - |       0 B |
                                          From_Char | 13.39 ns | 0.0109 ns | 0.0102 ns | 13.38 ns |      - |       0 B |
                                 From_Char_AsObject | 26.30 ns | 0.0215 ns | 0.0190 ns | 26.29 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 15.80 ns | 0.0105 ns | 0.0098 ns | 15.81 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 26.29 ns | 0.0082 ns | 0.0077 ns | 26.30 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.17 ns | 0.0120 ns | 0.0112 ns | 14.16 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.13 ns | 0.0328 ns | 0.0307 ns | 17.13 ns |      - |       0 B |
                                      From_DateTime | 13.86 ns | 0.0028 ns | 0.0022 ns | 13.86 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.03 ns | 0.0133 ns | 0.0111 ns | 14.03 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.03 ns | 0.0095 ns | 0.0089 ns | 14.03 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.09 ns | 0.0201 ns | 0.0188 ns | 17.09 ns |      - |       0 B |
                                       From_Decimal | 23.04 ns | 0.0108 ns | 0.0096 ns | 23.03 ns |      - |       0 B |
                              From_Decimal_AsObject | 35.69 ns | 0.0578 ns | 0.0512 ns | 35.67 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 31.25 ns | 0.0207 ns | 0.0194 ns | 31.26 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 34.55 ns | 0.0130 ns | 0.0109 ns | 34.55 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 15.94 ns | 0.0143 ns | 0.0134 ns | 15.94 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.12 ns | 0.0200 ns | 0.0187 ns | 17.12 ns |      - |       0 B |
                                        From_Double | 15.69 ns | 0.0117 ns | 0.0109 ns | 15.70 ns |      - |       0 B |
                               From_Double_AsObject | 27.36 ns | 0.0255 ns | 0.0239 ns | 27.36 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 19.39 ns | 0.0091 ns | 0.0085 ns | 19.39 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 27.42 ns | 0.0377 ns | 0.0334 ns | 27.40 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.06 ns | 0.0123 ns | 0.0115 ns | 15.06 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 18.77 ns | 0.0097 ns | 0.0091 ns | 18.77 ns |      - |       0 B |
                                         From_Short | 13.40 ns | 0.0129 ns | 0.0121 ns | 13.40 ns |      - |       0 B |
                                From_Short_AsObject | 25.47 ns | 0.0207 ns | 0.0193 ns | 25.48 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 15.80 ns | 0.0094 ns | 0.0088 ns | 15.79 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.32 ns | 0.0154 ns | 0.0136 ns | 25.31 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.18 ns | 0.0178 ns | 0.0149 ns | 14.18 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.13 ns | 0.0017 ns | 0.0014 ns | 17.13 ns |      - |       0 B |
                                           From_Int | 13.66 ns | 0.0098 ns | 0.0091 ns | 13.65 ns |      - |       0 B |
                                  From_Int_AsObject | 17.95 ns | 0.0181 ns | 0.0161 ns | 17.95 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 15.80 ns | 0.0061 ns | 0.0054 ns | 15.81 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 19.25 ns | 0.0111 ns | 0.0104 ns | 19.25 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.68 ns | 0.0104 ns | 0.0097 ns | 14.68 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.16 ns | 0.0164 ns | 0.0145 ns | 17.17 ns |      - |       0 B |
                                          From_Long | 14.67 ns | 0.0112 ns | 0.0105 ns | 14.66 ns |      - |       0 B |
                                 From_Long_AsObject | 27.53 ns | 0.0035 ns | 0.0032 ns | 27.53 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.62 ns | 0.0101 ns | 0.0094 ns | 18.61 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 29.21 ns | 0.0209 ns | 0.0196 ns | 29.20 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.04 ns | 0.0027 ns | 0.0023 ns | 15.04 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.13 ns | 0.0146 ns | 0.0137 ns | 17.13 ns |      - |       0 B |
                                         From_SByte | 13.38 ns | 0.0006 ns | 0.0005 ns | 13.38 ns |      - |       0 B |
                                From_SByte_AsObject | 25.30 ns | 0.0182 ns | 0.0161 ns | 25.30 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.51 ns | 0.0025 ns | 0.0022 ns | 16.51 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.29 ns | 0.0189 ns | 0.0168 ns | 25.29 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.17 ns | 0.0096 ns | 0.0085 ns | 14.16 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.46 ns | 0.0138 ns | 0.0122 ns | 17.46 ns |      - |       0 B |
                                         From_Float | 15.69 ns | 0.0147 ns | 0.0130 ns | 15.68 ns |      - |       0 B |
                                From_Float_AsObject | 27.39 ns | 0.0259 ns | 0.0243 ns | 27.38 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 19.38 ns | 0.0089 ns | 0.0083 ns | 19.38 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 27.40 ns | 0.0167 ns | 0.0156 ns | 27.40 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.18 ns | 0.0111 ns | 0.0099 ns | 14.18 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.57 ns | 0.0198 ns | 0.0185 ns | 17.57 ns |      - |       0 B |
                                        From_String | 88.27 ns | 0.0557 ns | 0.0521 ns | 88.28 ns |      - |       0 B |
                               From_String_AsObject | 98.03 ns | 0.0305 ns | 0.0271 ns | 98.03 ns |      - |       0 B |
                                   From_String_Null | 16.33 ns | 0.0149 ns | 0.0124 ns | 16.33 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.10 ns | 0.0222 ns | 0.0208 ns | 17.10 ns |      - |       0 B |
                                  From_String_Empty | 16.86 ns | 0.0109 ns | 0.0102 ns | 16.86 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                        From_UShort | 13.66 ns | 0.0064 ns | 0.0056 ns | 13.66 ns |      - |       0 B |
                               From_UShort_AsObject | 26.34 ns | 0.0200 ns | 0.0187 ns | 26.35 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 15.96 ns | 0.0111 ns | 0.0104 ns | 15.95 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 25.31 ns | 0.0076 ns | 0.0071 ns | 25.31 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 13.92 ns | 0.0124 ns | 0.0116 ns | 13.93 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.12 ns | 0.0118 ns | 0.0110 ns | 17.12 ns |      - |       0 B |
                                          From_UInt | 13.91 ns | 0.0117 ns | 0.0109 ns | 13.91 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.82 ns | 0.0184 ns | 0.0172 ns | 25.83 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 16.28 ns | 0.0111 ns | 0.0104 ns | 16.28 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 25.83 ns | 0.0321 ns | 0.0300 ns | 25.83 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.17 ns | 0.0112 ns | 0.0104 ns | 14.16 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.11 ns | 0.0146 ns | 0.0137 ns | 17.11 ns |      - |       0 B |
                                         From_ULong | 14.17 ns | 0.0105 ns | 0.0093 ns | 14.18 ns |      - |       0 B |
                                From_ULong_AsObject | 26.56 ns | 0.0199 ns | 0.0166 ns | 26.56 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.37 ns | 0.0100 ns | 0.0094 ns | 18.38 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.57 ns | 0.0102 ns | 0.0095 ns | 26.57 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.06 ns | 0.0146 ns | 0.0137 ns | 15.06 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.58 ns | 0.0158 ns | 0.0140 ns | 17.58 ns |      - |       0 B |
                                    From_NullObject | 17.12 ns | 0.0119 ns | 0.0111 ns | 17.12 ns |      - |       0 B |
                                        From_DBNull | 15.34 ns | 0.0053 ns | 0.0045 ns | 15.35 ns |      - |       0 B |
                              From_ConvertibleClass | 22.50 ns | 0.0385 ns | 0.0360 ns | 22.51 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 22.97 ns | 0.0152 ns | 0.0142 ns | 22.97 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.11 ns | 0.0141 ns | 0.0132 ns | 17.11 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.12 ns | 0.0116 ns | 0.0109 ns | 17.11 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.12 ns | 0.0204 ns | 0.0191 ns | 22.12 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.24 ns | 0.0032 ns | 0.0026 ns | 24.24 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.22 ns | 0.0219 ns | 0.0205 ns | 25.21 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.24 ns | 0.0058 ns | 0.0045 ns | 24.24 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.94 ns | 0.0027 ns | 0.0021 ns | 13.94 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.10 ns | 0.0179 ns | 0.0167 ns | 17.10 ns |      - |       0 B |
                                          From_Enum | 13.38 ns | 0.0070 ns | 0.0058 ns | 13.38 ns |      - |       0 B |
                                 From_Enum_AsObject | 56.99 ns | 0.0259 ns | 0.0230 ns | 56.98 ns | 0.0057 |      24 B |
                       From_Enum_Nullable_WithValue | 16.67 ns | 0.0128 ns | 0.0119 ns | 16.66 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 57.18 ns | 0.0096 ns | 0.0075 ns | 57.18 ns | 0.0057 |      24 B |
                         From_Enum_Nullable_NoValue | 14.25 ns | 0.0012 ns | 0.0011 ns | 14.25 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.19 ns | 0.0110 ns | 0.0103 ns | 17.18 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Int.From_String_Empty_AsObject: DefaultJob
