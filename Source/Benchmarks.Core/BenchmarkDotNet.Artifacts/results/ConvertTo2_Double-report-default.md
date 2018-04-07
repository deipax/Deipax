
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  13.60 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
                                 From_Bool_AsObject |  29.67 ns | 0.0848 ns | 0.0793 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.95 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  29.74 ns | 0.0697 ns | 0.0652 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  13.79 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.82 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                                          From_Byte |  13.05 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                 From_Byte_AsObject |  29.60 ns | 0.0435 ns | 0.0386 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  16.58 ns | 0.0072 ns | 0.0056 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  29.60 ns | 0.0437 ns | 0.0409 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  13.15 ns | 0.0049 ns | 0.0045 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.15 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
                                          From_Char |  13.77 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.85 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  12.78 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.11 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                                      From_DateTime |  13.40 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                             From_DateTime_AsObject |  21.28 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  13.50 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  22.36 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  13.51 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.14 ns | 0.0021 ns | 0.0014 ns |      - |       0 B |
                                       From_Decimal |  19.30 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                              From_Decimal_AsObject |  35.24 ns | 0.0234 ns | 0.0183 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  30.55 ns | 0.0119 ns | 0.0100 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  41.01 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  14.24 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.75 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                        From_Double |  12.63 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                               From_Double_AsObject |  16.89 ns | 0.0171 ns | 0.0143 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  14.00 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  16.86 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  13.99 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.76 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                         From_Short |  13.05 ns | 0.0097 ns | 0.0090 ns |      - |       0 B |
                                From_Short_AsObject |  29.84 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  16.59 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  29.85 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  13.15 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.84 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
                                           From_Int |  13.31 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                                  From_Int_AsObject |  29.57 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  16.34 ns | 0.0118 ns | 0.0104 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.57 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  12.98 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.18 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                          From_Long |  13.07 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                 From_Long_AsObject |  29.85 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  17.53 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.85 ns | 0.0323 ns | 0.0270 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.72 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.30 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
                                         From_SByte |  13.06 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                From_SByte_AsObject |  29.57 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.58 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  29.57 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  13.16 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.77 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                         From_Float |  12.65 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                                From_Float_AsObject |  29.57 ns | 0.0056 ns | 0.0044 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  16.32 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  29.58 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  13.16 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.11 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                        From_String | 116.52 ns | 0.0787 ns | 0.0697 ns |      - |       0 B |
                               From_String_AsObject | 127.82 ns | 0.0563 ns | 0.0499 ns |      - |       0 B |
                                   From_String_Null |  16.27 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.09 ns | 0.0086 ns | 0.0077 ns |      - |       0 B |
                                  From_String_Empty |  20.00 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                         From_String_Empty_AsObject |  23.00 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                        From_UShort |  13.32 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                               From_UShort_AsObject |  29.58 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.81 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  29.57 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  12.98 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.15 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                                          From_UInt |  13.07 ns | 0.0050 ns | 0.0044 ns |      - |       0 B |
                                 From_UInt_AsObject |  29.84 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.58 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  29.84 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  13.15 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.14 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                         From_ULong |  13.39 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                From_ULong_AsObject |  30.38 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  17.48 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  30.38 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  14.26 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.15 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                    From_NullObject |  16.10 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
                                        From_DBNull |  14.71 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                              From_ConvertibleClass |  22.92 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.17 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.70 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.18 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.33 ns | 0.0143 ns | 0.0134 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.51 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  26.41 ns | 0.0091 ns | 0.0071 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.51 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  12.97 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.10 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                                          From_Enum |  13.07 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                 From_Enum_AsObject |  64.65 ns | 0.0088 ns | 0.0078 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  17.02 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  64.64 ns | 0.0099 ns | 0.0093 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  13.13 ns | 0.0049 ns | 0.0045 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.20 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Double.From_Char_AsObject: DefaultJob
  ConvertTo2_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
