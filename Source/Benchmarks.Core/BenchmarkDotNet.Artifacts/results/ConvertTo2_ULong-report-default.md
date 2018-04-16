
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.75 ns | 0.0786 ns | 0.0656 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.59 ns | 0.0343 ns | 0.0287 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.48 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.58 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.67 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.23 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                                             From_Byte |  14.11 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.57 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.82 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.58 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.94 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.33 ns | 0.0125 ns | 0.0116 ns |      - |       0 B |
                                             From_Char |  14.12 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                    From_Char_AsObject |  26.38 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.64 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.40 ns | 0.0353 ns | 0.0313 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.94 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.33 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                                         From_DateTime |  14.58 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.80 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.81 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.34 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                                          From_Decimal |  24.99 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                                 From_Decimal_AsObject |  35.69 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  33.02 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.97 ns | 0.0490 ns | 0.0434 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.14 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.34 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
                                           From_Double |  17.49 ns | 0.0171 ns | 0.0152 ns |      - |       0 B |
                                  From_Double_AsObject |  29.91 ns | 0.0229 ns | 0.0191 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.01 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.88 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.94 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.30 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                            From_Short |  14.39 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
                                   From_Short_AsObject |  26.29 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.02 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.11 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.95 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.47 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                              From_Int |  14.68 ns | 0.0107 ns | 0.0084 ns |      - |       0 B |
                                     From_Int_AsObject |  26.11 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  17.49 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.12 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  16.95 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.43 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
                                             From_Long |  14.65 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
                                    From_Long_AsObject |  26.27 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  18.29 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.11 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.35 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.31 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                                            From_SByte |  14.38 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.11 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.17 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.65 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.95 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.23 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
                                            From_Float |  17.48 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                                   From_Float_AsObject |  30.14 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.95 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.38 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.94 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.44 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                           From_String |  91.96 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
                                  From_String_AsObject | 103.00 ns | 0.0498 ns | 0.0442 ns |      - |       0 B |
                                      From_String_Null |  15.42 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.31 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                     From_String_Empty |  16.07 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.39 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.60 ns | 0.0287 ns | 0.0254 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.83 ns | 0.0127 ns | 0.0112 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.58 ns | 0.0124 ns | 0.0104 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.67 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.32 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                             From_UInt |  14.12 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                    From_UInt_AsObject |  25.72 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.83 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.57 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.95 ns | 0.0049 ns | 0.0045 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.79 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                            From_ULong |  14.15 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
                                   From_ULong_AsObject |  19.27 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  14.96 ns | 0.0046 ns | 0.0039 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  18.66 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.09 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.31 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                       From_NullObject |  17.31 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                           From_DBNull |  15.68 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.07 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.27 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.87 ns | 0.0114 ns | 0.0089 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.37 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.87 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.73 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.86 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.30 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.60 ns | 0.0115 ns | 0.0107 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.74 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.68 ns | 0.0073 ns | 0.0068 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.74 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.29 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.29 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.15 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.98 ns | 0.0034 ns | 0.0026 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.87 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.56 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.87 ns | 0.0135 ns | 0.0119 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.30 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                                             From_Enum |  14.65 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.03 ns | 0.0151 ns | 0.0134 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.15 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.95 ns | 0.0542 ns | 0.0507 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.67 ns | 0.0118 ns | 0.0098 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.29 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                                      From_ParentClass |  15.95 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.17 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.89 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.11 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                     From_ParentStruct |  14.15 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.27 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.88 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.16 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.88 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.29 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ULong.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ULong.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ULong.From_String_Empty_AsObject: DefaultJob
