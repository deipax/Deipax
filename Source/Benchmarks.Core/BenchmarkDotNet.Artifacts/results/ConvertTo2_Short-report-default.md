
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.64 ns | 0.1021 ns | 0.0955 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.85 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.35 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.84 ns | 0.0156 ns | 0.0145 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.41 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.29 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
                                             From_Byte |  13.98 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.58 ns | 0.0198 ns | 0.0165 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.82 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.84 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.22 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.31 ns | 0.0112 ns | 0.0100 ns |      - |       0 B |
                                             From_Char |  14.60 ns | 0.0135 ns | 0.0119 ns |      - |       0 B |
                                    From_Char_AsObject |  27.18 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.39 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.27 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.24 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.27 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                         From_DateTime |  14.54 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.97 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.97 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.75 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                                          From_Decimal |  26.15 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.17 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.70 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.30 ns | 0.0279 ns | 0.0247 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.36 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.26 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                           From_Double |  18.25 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                                  From_Double_AsObject |  30.08 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.20 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.98 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.97 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.26 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                            From_Short |  14.00 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                                   From_Short_AsObject |  17.84 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.67 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  17.86 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.55 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.36 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                              From_Int |  15.34 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                     From_Int_AsObject |  27.18 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.69 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.17 ns | 0.0038 ns | 0.0031 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.39 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.28 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                             From_Long |  15.32 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                                    From_Long_AsObject |  27.17 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.49 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.17 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.17 ns | 0.1216 ns | 0.1078 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.25 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                                            From_SByte |  13.98 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.83 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.80 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.83 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.40 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.27 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                            From_Float |  18.27 ns | 0.0028 ns | 0.0020 ns |      - |       0 B |
                                   From_Float_AsObject |  30.29 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.64 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.88 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.21 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.25 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                                           From_String |  93.77 ns | 0.0897 ns | 0.0839 ns |      - |       0 B |
                                  From_String_AsObject | 104.10 ns | 0.0261 ns | 0.0232 ns |      - |       0 B |
                                      From_String_Null |  16.27 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.29 ns | 0.0111 ns | 0.0087 ns |      - |       0 B |
                                     From_String_Empty |  16.03 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.52 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.40 ns | 0.0408 ns | 0.0341 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.37 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.38 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  18.00 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.85 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                             From_UInt |  15.33 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                    From_UInt_AsObject |  27.19 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.69 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  27.21 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.22 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.33 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
                                            From_ULong |  15.33 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.20 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.77 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.20 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.96 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.28 ns | 0.0121 ns | 0.0114 ns |      - |       0 B |
                                       From_NullObject |  17.27 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                           From_DBNull |  15.33 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.54 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.69 ns | 0.0095 ns | 0.0085 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.34 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.33 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.00 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  22.84 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.98 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.77 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.96 ns | 0.0326 ns | 0.0305 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.02 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.62 ns | 0.0216 ns | 0.0192 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.02 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.82 ns | 0.0196 ns | 0.0173 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.01 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.72 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.11 ns | 0.0224 ns | 0.0175 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  22.27 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.00 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                             From_Enum |  15.30 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.65 ns | 0.0478 ns | 0.0447 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.83 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.55 ns | 0.0489 ns | 0.0457 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.80 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.26 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                      From_ParentClass |  15.99 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.14 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.00 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.76 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                     From_ParentStruct |  14.00 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.13 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.00 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.18 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.00 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.28 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Short.From_String_Empty_AsObject: DefaultJob
