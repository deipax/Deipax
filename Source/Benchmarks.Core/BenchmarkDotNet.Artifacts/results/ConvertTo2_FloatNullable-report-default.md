
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.02 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.72 ns | 0.0483 ns | 0.0428 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  16.80 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.69 ns | 0.0244 ns | 0.0216 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.96 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.86 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                                          From_Byte |  13.91 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                 From_Byte_AsObject |  28.08 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  17.60 ns | 0.0062 ns | 0.0045 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  28.10 ns | 0.0294 ns | 0.0260 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  14.30 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.58 ns | 0.0082 ns | 0.0072 ns |      - |       0 B |
                                          From_Char |  13.69 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  14.54 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  13.69 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  19.59 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                                      From_DateTime |  14.70 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  15.22 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.21 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.71 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                       From_Decimal |  24.54 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
                              From_Decimal_AsObject |  36.33 ns | 0.0445 ns | 0.0394 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  36.47 ns | 0.0167 ns | 0.0157 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  37.08 ns | 0.0481 ns | 0.0450 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.31 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.19 ns | 0.0357 ns | 0.0316 ns |      - |       0 B |
                                        From_Double |  13.90 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
                               From_Double_AsObject |  28.14 ns | 0.0120 ns | 0.0107 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  17.16 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  28.07 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  15.57 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  18.45 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                         From_Short |  13.92 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                From_Short_AsObject |  28.33 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  16.78 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  28.36 ns | 0.0428 ns | 0.0380 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  14.32 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.74 ns | 0.0030 ns | 0.0022 ns |      - |       0 B |
                                           From_Int |  13.93 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                  From_Int_AsObject |  28.12 ns | 0.0571 ns | 0.0506 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  16.83 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  28.14 ns | 0.0080 ns | 0.0058 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.31 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.90 ns | 0.0541 ns | 0.0506 ns |      - |       0 B |
                                          From_Long |  14.02 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                                 From_Long_AsObject |  28.38 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  17.18 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  28.41 ns | 0.1018 ns | 0.0952 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  16.01 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.43 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                         From_SByte |  14.50 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                                From_SByte_AsObject |  28.07 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  17.58 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  28.25 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.29 ns | 0.0021 ns | 0.0014 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.71 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                                         From_Float |  13.91 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                                From_Float_AsObject |  30.52 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  13.27 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  30.32 ns | 0.0118 ns | 0.0098 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  13.27 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.84 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                        From_String | 109.77 ns | 0.0672 ns | 0.0629 ns |      - |       0 B |
                               From_String_AsObject | 121.72 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                                   From_String_Null |  16.91 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                          From_String_Null_AsObject |  20.18 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                  From_String_Empty |  18.03 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.78 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                               From_UShort_AsObject |  28.07 ns | 0.0124 ns | 0.0104 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  17.78 ns | 0.0294 ns | 0.0261 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  28.08 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  14.30 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.69 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                                          From_UInt |  14.15 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                 From_UInt_AsObject |  28.32 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  18.53 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  28.31 ns | 0.0137 ns | 0.0114 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  16.20 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.32 ns | 0.0288 ns | 0.0240 ns |      - |       0 B |
                                         From_ULong |  14.28 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                                From_ULong_AsObject |  28.81 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  17.60 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  28.82 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.55 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.39 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                    From_NullObject |  17.73 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
                                        From_DBNull |  16.26 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                              From_ConvertibleClass |  24.23 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.31 ns | 0.0289 ns | 0.0256 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.69 ns | 0.0090 ns | 0.0085 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.70 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.70 ns | 0.0055 ns | 0.0046 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.55 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  25.94 ns | 0.0242 ns | 0.0226 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.62 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  14.49 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.37 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
                                          From_Enum |  13.90 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                 From_Enum_AsObject |  58.65 ns | 0.0183 ns | 0.0153 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  16.62 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  58.80 ns | 0.0135 ns | 0.0105 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  16.31 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.70 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_String_Empty_AsObject: DefaultJob
