
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  16.31 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                 From_Bool_AsObject |  30.94 ns | 0.0434 ns | 0.0384 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  20.68 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  30.94 ns | 0.1384 ns | 0.1156 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  17.38 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  19.49 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                          From_Byte |  16.45 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                                 From_Byte_AsObject |  30.97 ns | 0.0728 ns | 0.0681 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  19.14 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  30.92 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.57 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  25.29 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                          From_Char |  16.31 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  14.81 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  14.81 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.98 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                                      From_DateTime |  14.78 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  15.21 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.35 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  18.73 ns | 0.0557 ns | 0.0521 ns |      - |       0 B |
                                       From_Decimal |  21.76 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                              From_Decimal_AsObject |  40.13 ns | 0.0150 ns | 0.0125 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  32.17 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  38.36 ns | 0.0563 ns | 0.0499 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  17.11 ns | 0.0188 ns | 0.0147 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  19.45 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                                        From_Double |  15.07 ns | 0.0193 ns | 0.0172 ns |      - |       0 B |
                               From_Double_AsObject |  30.89 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  15.07 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  34.23 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.05 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  20.01 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                         From_Short |  15.30 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                From_Short_AsObject |  32.23 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  18.61 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  32.81 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.84 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.72 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                           From_Int |  15.81 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                  From_Int_AsObject |  31.03 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  19.65 ns | 0.0102 ns | 0.0080 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  31.06 ns | 0.0236 ns | 0.0197 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.85 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.66 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                          From_Long |  14.94 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
                                 From_Long_AsObject |  31.13 ns | 0.0078 ns | 0.0061 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  21.83 ns | 0.0170 ns | 0.0150 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  32.15 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  17.35 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.95 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                         From_SByte |  15.29 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                                From_SByte_AsObject |  30.87 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  19.12 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  30.88 ns | 0.0110 ns | 0.0092 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  19.06 ns | 0.0092 ns | 0.0087 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  20.98 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                         From_Float |  15.14 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                From_Float_AsObject |  31.39 ns | 0.0240 ns | 0.0213 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  18.62 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  31.42 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  15.88 ns | 0.0947 ns | 0.0885 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.74 ns | 0.0280 ns | 0.0234 ns |      - |       0 B |
                                        From_String | 109.29 ns | 0.0683 ns | 0.0606 ns |      - |       0 B |
                               From_String_AsObject | 123.42 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                                   From_String_Null |  17.88 ns | 0.0052 ns | 0.0038 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.66 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                  From_String_Empty |  18.00 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  15.29 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                               From_UShort_AsObject |  30.87 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  19.65 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  30.87 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.80 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.68 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                          From_UInt |  16.21 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                 From_UInt_AsObject |  31.15 ns | 0.0226 ns | 0.0212 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.77 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  31.13 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  16.84 ns | 0.0024 ns | 0.0023 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.70 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                         From_ULong |  16.59 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
                                From_ULong_AsObject |  31.66 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  20.70 ns | 0.0143 ns | 0.0133 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  32.65 ns | 0.0043 ns | 0.0034 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  17.37 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  19.04 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                    From_NullObject |  18.90 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
                                        From_DBNull |  18.11 ns | 0.0091 ns | 0.0086 ns |      - |       0 B |
                              From_ConvertibleClass |  26.79 ns | 0.0099 ns | 0.0078 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.59 ns | 0.0095 ns | 0.0074 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.79 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.68 ns | 0.0289 ns | 0.0242 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.57 ns | 0.0059 ns | 0.0046 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.88 ns | 0.0281 ns | 0.0263 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.06 ns | 0.0197 ns | 0.0184 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.88 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.61 ns | 0.0066 ns | 0.0061 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.67 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                          From_Enum |  15.22 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                                 From_Enum_AsObject |  62.24 ns | 0.0446 ns | 0.0417 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.63 ns | 0.0104 ns | 0.0093 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  61.79 ns | 0.0523 ns | 0.0464 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  15.82 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  18.72 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DoubleNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DoubleNullable.From_String_Empty_AsObject: DefaultJob
