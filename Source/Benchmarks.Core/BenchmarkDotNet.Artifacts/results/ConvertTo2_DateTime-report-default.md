
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.88 ns | 0.0516 ns | 0.0431 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  14.82 ns | 0.0179 ns | 0.0149 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  15.27 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.34 ns | 0.0183 ns | 0.0153 ns |      - |       0 B |
                                             From_Byte |  14.99 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  14.83 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  14.82 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.20 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                                             From_Char |  14.99 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.29 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.21 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.32 ns | 0.0193 ns | 0.0161 ns |      - |       0 B |
                                         From_DateTime |  14.49 ns | 0.3103 ns | 0.3320 ns |      - |       0 B |
                                From_DateTime_AsObject |  17.79 ns | 0.0107 ns | 0.0089 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  15.68 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  17.80 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  16.14 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.10 ns | 0.0110 ns | 0.0091 ns |      - |       0 B |
                                          From_Decimal |  15.89 ns | 0.0178 ns | 0.0148 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  18.29 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  16.17 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.24 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                                           From_Double |  14.99 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  16.47 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  15.89 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.05 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                            From_Short |  14.98 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  15.28 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  15.19 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.33 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                              From_Int |  15.19 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  15.23 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  14.99 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.33 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                                             From_Long |  14.83 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  15.90 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  15.89 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.21 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                            From_SByte |  14.98 ns | 0.0080 ns | 0.0074 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  15.25 ns | 0.0336 ns | 0.0315 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  14.82 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.84 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                            From_Float |  14.99 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  14.98 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  14.83 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  20.14 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                                           From_String | 811.60 ns | 0.9718 ns | 0.9090 ns |      - |       0 B |
                                  From_String_AsObject | 819.51 ns | 1.3517 ns | 1.2644 ns |      - |       0 B |
                                      From_String_Null |  15.66 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.33 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                                     From_String_Empty |  16.44 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.83 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  15.21 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  15.29 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.35 ns | 0.0599 ns | 0.0500 ns |      - |       0 B |
                                             From_UInt |  15.27 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  14.81 ns | 0.0077 ns | 0.0060 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  14.91 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.53 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                                            From_ULong |  14.98 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  16.14 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  15.89 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.52 ns | 0.0019 ns | 0.0014 ns |      - |       0 B |
                                       From_NullObject |  17.33 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                                           From_DBNull |  17.15 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.82 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  24.61 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.30 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.52 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.25 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.80 ns | 0.0103 ns | 0.0080 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.32 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.32 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.06 ns | 0.0048 ns | 0.0037 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.94 ns | 0.0289 ns | 0.0256 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.42 ns | 0.0041 ns | 0.0035 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.85 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.99 ns | 0.0029 ns | 0.0021 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.52 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.84 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.78 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.16 ns | 0.0065 ns | 0.0051 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.85 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.00 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.44 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                                             From_Enum |  16.41 ns | 0.0049 ns | 0.0038 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  16.03 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  16.17 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.31 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                                      From_ParentClass |  15.19 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.89 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.22 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.06 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                     From_ParentStruct |  14.83 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.35 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.02 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.37 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  15.00 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.45 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTime.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTime.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTime.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Enum_Nullable_WithValue_AsObject: DefaultJob
