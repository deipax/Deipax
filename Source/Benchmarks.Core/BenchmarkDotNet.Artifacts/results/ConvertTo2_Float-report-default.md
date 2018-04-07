
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  13.61 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                                 From_Bool_AsObject |  29.35 ns | 0.0446 ns | 0.0395 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  18.24 ns | 0.0222 ns | 0.0207 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  29.31 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.65 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.02 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                          From_Byte |  14.08 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                 From_Byte_AsObject |  29.31 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  17.13 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  29.30 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  13.15 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.16 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                          From_Char |  12.89 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  12.64 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  12.80 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.10 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                                      From_DateTime |  13.40 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                             From_DateTime_AsObject |  21.27 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  13.52 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  21.24 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  13.53 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.83 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
                                       From_Decimal |  21.32 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
                              From_Decimal_AsObject |  37.11 ns | 0.0073 ns | 0.0057 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  35.43 ns | 0.0529 ns | 0.0495 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  37.13 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  14.27 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.15 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                                        From_Double |  12.64 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                               From_Double_AsObject |  29.45 ns | 0.0221 ns | 0.0196 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  17.25 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  29.63 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  14.02 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.57 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                         From_Short |  13.05 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                From_Short_AsObject |  29.58 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  18.03 ns | 0.0106 ns | 0.0082 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  29.58 ns | 0.0172 ns | 0.0144 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  13.17 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.10 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                           From_Int |  13.33 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                  From_Int_AsObject |  29.32 ns | 0.0320 ns | 0.0284 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  16.77 ns | 0.0228 ns | 0.0214 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.41 ns | 0.0107 ns | 0.0089 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.26 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.62 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                                          From_Long |  13.33 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                                 From_Long_AsObject |  30.12 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.46 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  30.11 ns | 0.0162 ns | 0.0127 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.09 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.73 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                         From_SByte |  13.05 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                                From_SByte_AsObject |  29.31 ns | 0.0072 ns | 0.0056 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.58 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  29.32 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  13.16 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.12 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                                         From_Float |  12.63 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                From_Float_AsObject |  19.09 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  13.18 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  18.37 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  13.28 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.85 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                                        From_String | 118.84 ns | 0.1070 ns | 0.0948 ns |      - |       0 B |
                               From_String_AsObject | 131.34 ns | 0.0972 ns | 0.0909 ns |      - |       0 B |
                                   From_String_Null |  16.92 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.15 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                                  From_String_Empty |  20.04 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                         From_String_Empty_AsObject |  23.35 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                                        From_UShort |  13.33 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                               From_UShort_AsObject |  29.31 ns | 0.0241 ns | 0.0213 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  18.05 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  29.30 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  13.00 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.11 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                                          From_UInt |  13.33 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
                                 From_UInt_AsObject |  29.57 ns | 0.0067 ns | 0.0053 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.03 ns | 0.0272 ns | 0.0254 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  29.57 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  13.17 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.62 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                         From_ULong |  13.17 ns | 0.0146 ns | 0.0122 ns |      - |       0 B |
                                From_ULong_AsObject |  30.12 ns | 0.0175 ns | 0.0163 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  18.64 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  30.11 ns | 0.0172 ns | 0.0144 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  14.01 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.15 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                    From_NullObject |  17.01 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                        From_DBNull |  14.39 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                              From_ConvertibleClass |  25.31 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.28 ns | 0.0107 ns | 0.0090 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.55 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.95 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.30 ns | 0.0081 ns | 0.0072 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.24 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  25.87 ns | 0.0090 ns | 0.0075 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.24 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  12.97 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.87 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                          From_Enum |  13.05 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                                 From_Enum_AsObject |  62.89 ns | 0.0113 ns | 0.0095 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.77 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  62.90 ns | 0.0527 ns | 0.0493 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  13.13 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.50 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Float.From_Char_AsObject: DefaultJob
  ConvertTo2_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
