
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.02 ns | 0.0095 ns | 0.0075 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.87 ns | 0.0656 ns | 0.0548 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  17.80 ns | 0.0615 ns | 0.0576 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.84 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.57 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.71 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                                          From_Byte |  15.05 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                 From_Byte_AsObject |  28.08 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  17.70 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  28.26 ns | 0.0524 ns | 0.0491 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  15.98 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.89 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                          From_Char |  14.35 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                 From_Char_AsObject |  29.26 ns | 0.0934 ns | 0.0828 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  17.60 ns | 0.0204 ns | 0.0181 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  29.11 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  14.40 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  20.36 ns | 0.0082 ns | 0.0076 ns |      - |       0 B |
                                      From_DateTime |  14.76 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.44 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.43 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  21.39 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
                                       From_Decimal |  26.68 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                              From_Decimal_AsObject |  37.96 ns | 0.1981 ns | 0.1756 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  35.37 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  37.96 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.72 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.70 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                        From_Double |  16.32 ns | 0.0013 ns | 0.0008 ns |      - |       0 B |
                               From_Double_AsObject |  30.13 ns | 0.0210 ns | 0.0196 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  19.92 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  30.13 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.57 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  18.45 ns | 0.0156 ns | 0.0130 ns |      - |       0 B |
                                         From_Short |  13.70 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                From_Short_AsObject |  29.08 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  17.91 ns | 0.1066 ns | 0.0997 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  28.08 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.11 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.25 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                           From_Int |  14.79 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                                  From_Int_AsObject |  29.03 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  13.27 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.05 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  13.27 ns | 0.0044 ns | 0.0036 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.69 ns | 0.0051 ns | 0.0042 ns |      - |       0 B |
                                          From_Long |  15.55 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                                 From_Long_AsObject |  30.53 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.92 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.43 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.57 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.70 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                                         From_SByte |  13.77 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                From_SByte_AsObject |  28.19 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  17.67 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  28.22 ns | 0.3300 ns | 0.2926 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.64 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  19.25 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                         From_Float |  16.83 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                From_Float_AsObject |  30.74 ns | 0.0245 ns | 0.0229 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  19.43 ns | 0.0260 ns | 0.0217 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  31.26 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  15.43 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.85 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                        From_String |  89.25 ns | 0.0965 ns | 0.0903 ns |      - |       0 B |
                               From_String_AsObject | 100.84 ns | 0.0377 ns | 0.0334 ns |      - |       0 B |
                                   From_String_Null |  17.21 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.73 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
                                  From_String_Empty |  16.69 ns | 0.0121 ns | 0.0114 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.69 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                               From_UShort_AsObject |  28.07 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.81 ns | 0.0287 ns | 0.0239 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  29.08 ns | 0.0113 ns | 0.0089 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  14.31 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.70 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                          From_UInt |  14.30 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                                 From_UInt_AsObject |  28.72 ns | 0.0102 ns | 0.0079 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.14 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  28.72 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  14.98 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.87 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                         From_ULong |  15.29 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                From_ULong_AsObject |  29.32 ns | 0.0443 ns | 0.0414 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  18.89 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  29.37 ns | 0.0098 ns | 0.0077 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  19.29 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.32 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                    From_NullObject |  17.70 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                                        From_DBNull |  17.25 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                              From_ConvertibleClass |  24.63 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.53 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  21.63 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.92 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.69 ns | 0.0028 ns | 0.0022 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.82 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  24.95 ns | 0.0131 ns | 0.0116 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.80 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.32 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.70 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                          From_Enum |  13.69 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                 From_Enum_AsObject |  59.15 ns | 0.0093 ns | 0.0082 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  16.69 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  59.02 ns | 0.0087 ns | 0.0073 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.32 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.70 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_IntNullable.From_String_Empty_AsObject: DefaultJob
