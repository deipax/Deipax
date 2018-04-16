
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.84 ns | 0.0694 ns | 0.0650 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.58 ns | 0.0239 ns | 0.0200 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.52 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.60 ns | 0.0339 ns | 0.0317 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.70 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.28 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                                             From_Byte |  14.15 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.57 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.86 ns | 0.0268 ns | 0.0251 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.58 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.06 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.26 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                             From_Char |  14.14 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                                    From_Char_AsObject |  26.38 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.69 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.39 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.07 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.29 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                         From_DateTime |  14.61 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.82 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.17 ns | 0.0202 ns | 0.0188 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.14 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                          From_Decimal |  26.31 ns | 0.0205 ns | 0.0191 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.74 ns | 0.0324 ns | 0.0287 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.94 ns | 0.0222 ns | 0.0207 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.35 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.16 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.76 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                                           From_Double |  18.30 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                  From_Double_AsObject |  29.79 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.34 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.72 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.89 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.29 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                                            From_Short |  14.40 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                                   From_Short_AsObject |  26.13 ns | 0.0285 ns | 0.0266 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.05 ns | 0.0306 ns | 0.0287 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.11 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.96 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.35 ns | 0.0105 ns | 0.0082 ns |      - |       0 B |
                                              From_Int |  15.48 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                     From_Int_AsObject |  26.93 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.58 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.96 ns | 0.0096 ns | 0.0069 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.69 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.96 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                                             From_Long |  15.48 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                                    From_Long_AsObject |  26.94 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.38 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.93 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.89 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.28 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                            From_SByte |  14.40 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.12 ns | 0.0258 ns | 0.0229 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.19 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.12 ns | 0.0241 ns | 0.0225 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  16.89 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.27 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                                            From_Float |  18.31 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                                   From_Float_AsObject |  29.64 ns | 0.0251 ns | 0.0209 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.08 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.62 ns | 0.0223 ns | 0.0209 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.97 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.74 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                           From_String |  91.62 ns | 0.0450 ns | 0.0399 ns |      - |       0 B |
                                  From_String_AsObject | 102.39 ns | 0.0721 ns | 0.0674 ns |      - |       0 B |
                                      From_String_Null |  15.36 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.28 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
                                     From_String_Empty |  16.15 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.39 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                  From_UShort_AsObject |  17.81 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.68 ns | 0.0082 ns | 0.0069 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  17.78 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.24 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.75 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                             From_UInt |  14.67 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.12 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.17 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.10 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.95 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.34 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                            From_ULong |  14.95 ns | 0.0033 ns | 0.0025 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.91 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.42 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.99 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.89 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.27 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                       From_NullObject |  17.30 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                                           From_DBNull |  15.07 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.01 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.41 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.32 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.91 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.88 ns | 0.1034 ns | 0.0863 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.38 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.82 ns | 0.0059 ns | 0.0053 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.99 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.64 ns | 0.0253 ns | 0.0237 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.76 ns | 0.0131 ns | 0.0110 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.75 ns | 0.0126 ns | 0.0105 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.75 ns | 0.0133 ns | 0.0111 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.97 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.25 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.83 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  24.19 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.90 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.64 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.88 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                             From_Enum |  15.46 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.47 ns | 0.0117 ns | 0.0104 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.09 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.48 ns | 0.0075 ns | 0.0070 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.67 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.91 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                      From_ParentClass |  15.82 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.79 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.94 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.82 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                     From_ParentStruct |  14.15 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.26 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.88 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.27 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.89 ns | 0.0268 ns | 0.0209 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.35 ns | 0.0804 ns | 0.0753 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShort.From_String_Empty_AsObject: DefaultJob
