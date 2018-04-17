
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  18.41 ns | 0.1646 ns | 0.1540 ns |      - |       0 B |
                                    From_Bool_AsObject |  30.44 ns | 0.0374 ns | 0.0331 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  18.58 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  30.43 ns | 0.0231 ns | 0.0205 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.96 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  19.30 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                             From_Byte |  16.94 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                                    From_Byte_AsObject |  30.41 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  18.05 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  30.42 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.96 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.35 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                             From_Char |  16.21 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.60 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.75 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  19.36 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                                         From_DateTime |  17.21 ns | 0.0243 ns | 0.0215 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.11 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.13 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.64 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
                                          From_Decimal |  15.87 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                                 From_Decimal_AsObject |  20.07 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.12 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  19.20 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  26.67 ns | 0.0281 ns | 0.0250 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.97 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                           From_Double |  79.25 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                                  From_Double_AsObject |  89.48 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  79.55 ns | 0.0688 ns | 0.0643 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  89.55 ns | 0.0241 ns | 0.0225 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.97 ns | 0.0190 ns | 0.0169 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.86 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                            From_Short |  18.03 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                                   From_Short_AsObject |  30.67 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.76 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  31.12 ns | 0.0303 ns | 0.0269 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  16.42 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  19.33 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                              From_Int |  18.62 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                     From_Int_AsObject |  30.67 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.49 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  30.67 ns | 0.0052 ns | 0.0041 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.41 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.86 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                                             From_Long |  16.54 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
                                    From_Long_AsObject |  30.97 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.77 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  30.95 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.97 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.92 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                                            From_SByte |  16.94 ns | 0.0056 ns | 0.0043 ns |      - |       0 B |
                                   From_SByte_AsObject |  30.69 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  18.05 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.73 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  18.09 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.41 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                            From_Float |  38.23 ns | 0.0267 ns | 0.0236 ns |      - |       0 B |
                                   From_Float_AsObject |  49.14 ns | 0.0290 ns | 0.0242 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  38.78 ns | 0.0570 ns | 0.0505 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  49.19 ns | 0.0708 ns | 0.0662 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  16.43 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.87 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                           From_String | 130.60 ns | 0.0695 ns | 0.0616 ns |      - |       0 B |
                                  From_String_AsObject | 142.50 ns | 0.1165 ns | 0.1033 ns |      - |       0 B |
                                      From_String_Null |  17.50 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                             From_String_Null_AsObject |  25.59 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                     From_String_Empty |  17.44 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  16.93 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                                  From_UShort_AsObject |  31.23 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.77 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  30.69 ns | 0.0269 ns | 0.0239 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.46 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.91 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                                             From_UInt |  16.00 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                    From_UInt_AsObject |  30.14 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.96 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  30.18 ns | 0.0505 ns | 0.0472 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.42 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  20.78 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                            From_ULong |  16.00 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                   From_ULong_AsObject |  30.13 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.23 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  30.14 ns | 0.0198 ns | 0.0165 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.95 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.86 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                       From_NullObject |  18.86 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                                           From_DBNull |  17.20 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.27 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  28.01 ns | 0.0269 ns | 0.0251 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.88 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.88 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.30 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.44 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  18.30 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  19.13 ns | 0.0110 ns | 0.0092 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.07 ns | 0.0143 ns | 0.0134 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  29.08 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  30.51 ns | 0.0164 ns | 0.0153 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.09 ns | 0.0229 ns | 0.0203 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.52 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.86 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.68 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  24.85 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.69 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.89 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.68 ns | 0.0076 ns | 0.0063 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.87 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                                             From_Enum |  16.43 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                    From_Enum_AsObject |  64.98 ns | 0.0500 ns | 0.0444 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  20.06 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.96 ns | 0.0426 ns | 0.0399 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  17.11 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.59 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                                      From_ParentClass |  18.30 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.85 ns | 0.0231 ns | 0.0205 ns |      - |       0 B |
                              From_ParentClass_NoValue |  18.30 ns | 0.0058 ns | 0.0055 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.86 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                     From_ParentStruct |  16.66 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  26.10 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  17.24 ns | 0.0278 ns | 0.0246 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.42 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.67 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.44 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Decimal.From_Char_AsObject: DefaultJob
  ConvertTo2_Decimal.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Decimal.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Decimal.From_String_Empty_AsObject: DefaultJob
