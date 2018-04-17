
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.63 ns | 0.1274 ns | 0.1191 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.86 ns | 0.0307 ns | 0.0257 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.33 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.84 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.41 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.27 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                             From_Byte |  14.53 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                    From_Byte_AsObject |  26.38 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  15.72 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  26.49 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.23 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.31 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                             From_Char |  14.51 ns | 0.0015 ns | 0.0011 ns |      - |       0 B |
                                    From_Char_AsObject |  27.18 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.40 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  27.19 ns | 0.0198 ns | 0.0186 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.21 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.35 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                         From_DateTime |  14.53 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.93 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.94 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.26 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                          From_Decimal |  26.42 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.06 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  29.63 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.01 ns | 0.0207 ns | 0.0184 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.34 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.26 ns | 0.0159 ns | 0.0132 ns |      - |       0 B |
                                           From_Double |  17.97 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                  From_Double_AsObject |  29.35 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.65 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.37 ns | 0.0377 ns | 0.0353 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.96 ns | 0.0175 ns | 0.0146 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.79 ns | 0.0048 ns | 0.0044 ns |      - |       0 B |
                                            From_Short |  15.32 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                   From_Short_AsObject |  27.20 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.75 ns | 0.1554 ns | 0.1297 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.47 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.21 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.81 ns | 0.0094 ns | 0.0074 ns |      - |       0 B |
                                              From_Int |  15.05 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                     From_Int_AsObject |  26.91 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.42 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.91 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.78 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.19 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                             From_Long |  16.38 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                    From_Long_AsObject |  27.18 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  18.02 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.18 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.12 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.33 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                            From_SByte |  14.00 ns | 0.0047 ns | 0.0041 ns |      - |       0 B |
                                   From_SByte_AsObject |  17.77 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.53 ns | 0.0072 ns | 0.0052 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  17.84 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.54 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.82 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                            From_Float |  18.03 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                                   From_Float_AsObject |  29.61 ns | 0.0311 ns | 0.0276 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.39 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.67 ns | 0.0406 ns | 0.0380 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.22 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.27 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                           From_String |  95.68 ns | 0.0480 ns | 0.0449 ns |      - |       0 B |
                                  From_String_AsObject | 106.44 ns | 0.0671 ns | 0.0595 ns |      - |       0 B |
                                      From_String_Null |  16.89 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.27 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                     From_String_Empty |  16.85 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.52 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.38 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.36 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.47 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.40 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.29 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                             From_UInt |  14.52 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.42 ns | 0.0407 ns | 0.0380 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.34 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.37 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.22 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.81 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                            From_ULong |  14.51 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.94 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  15.88 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.37 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.80 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.33 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                                       From_NullObject |  18.00 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.24 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.67 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.11 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.32 ns | 0.0097 ns | 0.0076 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.00 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.64 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.00 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.85 ns | 0.0070 ns | 0.0059 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.87 ns | 0.0126 ns | 0.0118 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.01 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.59 ns | 0.0037 ns | 0.0033 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.01 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.80 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.82 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.00 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  22.34 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.99 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.59 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.00 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.76 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                                             From_Enum |  15.05 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.35 ns | 0.0133 ns | 0.0111 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.52 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.36 ns | 0.0109 ns | 0.0085 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.78 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.27 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                      From_ParentClass |  15.97 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.10 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.00 ns | 0.0136 ns | 0.0121 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.27 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
                                     From_ParentStruct |  17.01 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.13 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.00 ns | 0.0120 ns | 0.0107 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.68 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.00 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByte.From_String_Empty_AsObject: DefaultJob
