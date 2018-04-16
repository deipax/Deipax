
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  17.32 ns | 0.0853 ns | 0.0798 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.69 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  21.26 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.69 ns | 0.0234 ns | 0.0208 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  17.22 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  19.47 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                             From_Byte |  16.95 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.72 ns | 0.0362 ns | 0.0338 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  20.18 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.71 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  17.21 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.13 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
                                             From_Char |  17.31 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  16.02 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.76 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.87 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                         From_DateTime |  17.02 ns | 0.0161 ns | 0.0142 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.12 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.12 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.88 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                          From_Decimal |  15.87 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                 From_Decimal_AsObject |  19.95 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.45 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  20.42 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  26.50 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.28 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
                                           From_Double |  79.25 ns | 0.0390 ns | 0.0365 ns |      - |       0 B |
                                  From_Double_AsObject |  90.00 ns | 0.0538 ns | 0.0503 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  82.66 ns | 0.0337 ns | 0.0316 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  89.88 ns | 0.1284 ns | 0.1201 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  17.74 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.95 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                            From_Short |  16.94 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
                                   From_Short_AsObject |  30.94 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  20.16 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  30.95 ns | 0.0250 ns | 0.0208 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.92 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.86 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                              From_Int |  16.40 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                     From_Int_AsObject |  30.95 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  20.18 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.99 ns | 0.0147 ns | 0.0115 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  17.10 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.88 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                                             From_Long |  16.41 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                    From_Long_AsObject |  31.26 ns | 0.0194 ns | 0.0162 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  21.24 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  31.24 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.75 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.37 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                            From_SByte |  16.94 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.97 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  20.18 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.98 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  17.21 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.13 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                                            From_Float |  38.24 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                                   From_Float_AsObject |  49.34 ns | 0.0630 ns | 0.0590 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  41.88 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  49.90 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.93 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.89 ns | 0.0065 ns | 0.0047 ns |      - |       0 B |
                                           From_String | 131.40 ns | 0.0856 ns | 0.0800 ns |      - |       0 B |
                                  From_String_AsObject | 143.47 ns | 0.0542 ns | 0.0507 ns |      - |       0 B |
                                      From_String_Null |  17.79 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.88 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                                     From_String_Empty |  17.58 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  17.36 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
                                  From_UShort_AsObject |  30.96 ns | 0.0300 ns | 0.0266 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  20.26 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.97 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  17.10 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.88 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                             From_UInt |  16.27 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.42 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  19.92 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.43 ns | 0.0322 ns | 0.0302 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.93 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.87 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                            From_ULong |  23.01 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                                   From_ULong_AsObject |  30.43 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  20.53 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  30.41 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  17.74 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.48 ns | 0.0133 ns | 0.0117 ns |      - |       0 B |
                                       From_NullObject |  18.87 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
                                           From_DBNull |  17.48 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.53 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.25 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  20.80 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.87 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.30 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.08 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.30 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.86 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.80 ns | 0.0098 ns | 0.0087 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.33 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  30.67 ns | 0.0144 ns | 0.0128 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.33 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.86 ns | 0.0260 ns | 0.0244 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  19.47 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.40 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  26.80 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.40 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.86 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.39 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.86 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                                             From_Enum |  16.40 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
                                    From_Enum_AsObject |  64.79 ns | 0.0117 ns | 0.0109 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.17 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.75 ns | 0.0341 ns | 0.0319 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.83 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  21.16 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
                                      From_ParentClass |  18.29 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.60 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                              From_ParentClass_NoValue |  18.31 ns | 0.0075 ns | 0.0059 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.89 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                     From_ParentStruct |  16.40 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.63 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.41 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.64 ns | 0.0264 ns | 0.0234 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.40 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  21.99 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo2_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_String_Empty_AsObject: DefaultJob
