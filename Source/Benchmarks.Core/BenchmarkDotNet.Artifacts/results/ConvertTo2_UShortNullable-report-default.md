
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.86 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.84 ns | 0.0231 ns | 0.0205 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  17.86 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.84 ns | 0.0222 ns | 0.0196 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.29 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.77 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                                          From_Byte |  13.97 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                                 From_Byte_AsObject |  28.60 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  17.75 ns | 0.0244 ns | 0.0216 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  28.47 ns | 0.0199 ns | 0.0187 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.30 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.92 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                          From_Char |  13.74 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
                                 From_Char_AsObject |  29.26 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  16.60 ns | 0.0517 ns | 0.0483 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  29.45 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  14.29 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.76 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                      From_DateTime |  14.20 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  15.35 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.33 ns | 0.0188 ns | 0.0175 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.91 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                                       From_Decimal |  27.43 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                              From_Decimal_AsObject |  39.91 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  37.90 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  39.93 ns | 0.0364 ns | 0.0323 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.35 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.41 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                                        From_Double |  18.14 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                               From_Double_AsObject |  32.43 ns | 0.0236 ns | 0.0197 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  22.49 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  32.30 ns | 0.0263 ns | 0.0233 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.58 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.76 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                                         From_Short |  14.08 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                From_Short_AsObject |  29.14 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  17.75 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  29.12 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.13 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.76 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                           From_Int |  15.33 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                                  From_Int_AsObject |  29.85 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  17.75 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.73 ns | 0.0251 ns | 0.0222 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.32 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.80 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                          From_Long |  15.33 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
                                 From_Long_AsObject |  29.74 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.95 ns | 0.0132 ns | 0.0110 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.87 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.56 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.76 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                                         From_SByte |  14.96 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                From_SByte_AsObject |  28.94 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.85 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  29.09 ns | 0.0107 ns | 0.0084 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.18 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.90 ns | 0.0110 ns | 0.0102 ns |      - |       0 B |
                                         From_Float |  18.64 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
                                From_Float_AsObject |  33.17 ns | 0.0046 ns | 0.0040 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  21.21 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  33.19 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.28 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.97 ns | 0.0052 ns | 0.0044 ns |      - |       0 B |
                                        From_String |  88.33 ns | 0.0670 ns | 0.0627 ns |      - |       0 B |
                               From_String_AsObject | 100.04 ns | 0.0424 ns | 0.0396 ns |      - |       0 B |
                                   From_String_Null |  17.07 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.81 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                  From_String_Empty |  17.09 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.76 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                               From_UShort_AsObject |  31.03 ns | 0.0390 ns | 0.0365 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  13.27 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  28.98 ns | 0.0495 ns | 0.0414 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  14.07 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.75 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                                          From_UInt |  14.30 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                 From_UInt_AsObject |  29.10 ns | 0.0197 ns | 0.0174 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  16.83 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  28.97 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.29 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.75 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
                                         From_ULong |  15.32 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                                From_ULong_AsObject |  29.74 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  18.87 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  30.73 ns | 0.0010 ns | 0.0007 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.84 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.36 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                                    From_NullObject |  21.33 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                                        From_DBNull |  17.34 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                              From_ConvertibleClass |  24.67 ns | 0.0443 ns | 0.0370 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.62 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.77 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.78 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.73 ns | 0.0069 ns | 0.0054 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.79 ns | 0.0010 ns | 0.0007 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  26.00 ns | 0.0115 ns | 0.0108 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.81 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  15.37 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.76 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                          From_Enum |  15.31 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                 From_Enum_AsObject |  60.26 ns | 0.0361 ns | 0.0320 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.36 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  61.60 ns | 0.0326 ns | 0.0272 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.29 ns | 0.0174 ns | 0.0145 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  19.40 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShortNullable.From_String_Empty_AsObject: DefaultJob
