
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.66 ns | 0.0534 ns | 0.0474 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.84 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.36 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.83 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.43 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.86 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                             From_Byte |  14.15 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.84 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.82 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.84 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.22 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.29 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                                             From_Char |  13.99 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.00 ns | 0.0082 ns | 0.0076 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  19.87 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.40 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
                                         From_DateTime |  14.56 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.96 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.96 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.40 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                          From_Decimal |  20.18 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                                 From_Decimal_AsObject |  31.48 ns | 0.0071 ns | 0.0060 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  26.04 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  31.50 ns | 0.0217 ns | 0.0192 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.35 ns | 0.0177 ns | 0.0166 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.39 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                           From_Double |  14.00 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                                  From_Double_AsObject |  18.30 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.08 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  17.92 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.15 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.41 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                            From_Short |  14.16 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
                                   From_Short_AsObject |  26.11 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.83 ns | 0.0445 ns | 0.0372 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  26.26 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.24 ns | 0.0177 ns | 0.0166 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.48 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                                              From_Int |  13.99 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                     From_Int_AsObject |  25.83 ns | 0.0073 ns | 0.0057 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.81 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.14 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.40 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.83 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                             From_Long |  14.00 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                    From_Long_AsObject |  26.10 ns | 0.0112 ns | 0.0100 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.70 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.12 ns | 0.0100 ns | 0.0078 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.12 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.40 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                            From_SByte |  14.17 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.84 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.82 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.84 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.24 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.40 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                                            From_Float |  14.00 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
                                   From_Float_AsObject |  25.84 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  14.83 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  25.84 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.23 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.40 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                           From_String | 112.04 ns | 0.0952 ns | 0.0844 ns |      - |       0 B |
                                  From_String_AsObject | 122.45 ns | 0.0979 ns | 0.0916 ns |      - |       0 B |
                                      From_String_Null |  15.61 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.41 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
                                     From_String_Empty |  15.96 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.01 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.84 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.82 ns | 0.0117 ns | 0.0103 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.86 ns | 0.0160 ns | 0.0142 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.41 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.41 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                             From_UInt |  14.16 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.21 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  14.80 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.11 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.21 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.47 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                                            From_ULong |  14.54 ns | 0.0163 ns | 0.0144 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.75 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.14 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.65 ns | 0.0124 ns | 0.0103 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.95 ns | 0.0076 ns | 0.0064 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.84 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                                       From_NullObject |  17.40 ns | 0.0118 ns | 0.0104 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.40 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.70 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.93 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.47 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.69 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.84 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.00 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.40 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.88 ns | 0.0027 ns | 0.0023 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.03 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.28 ns | 0.0084 ns | 0.0079 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.02 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.81 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.52 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.99 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.80 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.99 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.85 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.00 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.84 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                                             From_Enum |  13.98 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                    From_Enum_AsObject |  57.42 ns | 0.0087 ns | 0.0077 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  16.93 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  57.59 ns | 0.0148 ns | 0.0123 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  16.96 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.51 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                                      From_ParentClass |  16.76 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.01 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.79 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.40 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                                     From_ParentStruct |  13.99 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.27 ns | 0.0213 ns | 0.0200 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.01 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.30 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  21.26 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.40 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Double.From_Char_AsObject: DefaultJob
  ConvertTo2_Double.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Double.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Double.From_String_Empty_AsObject: DefaultJob
