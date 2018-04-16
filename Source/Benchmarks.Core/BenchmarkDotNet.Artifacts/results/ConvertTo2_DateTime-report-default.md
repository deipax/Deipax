
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.94 ns | 0.0844 ns | 0.0659 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  15.93 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  14.99 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.44 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                             From_Byte |  16.29 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  14.82 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  14.81 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.49 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                                             From_Char |  14.99 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  16.04 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.20 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.53 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                                         From_DateTime |  14.03 ns | 0.0129 ns | 0.0108 ns |      - |       0 B |
                                From_DateTime_AsObject |  18.96 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  15.63 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  19.20 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  16.18 ns | 0.0250 ns | 0.0233 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.54 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                          From_Decimal |  15.91 ns | 0.0136 ns | 0.0113 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  16.12 ns | 0.0336 ns | 0.0281 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  16.17 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.43 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                           From_Double |  15.00 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  15.90 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  15.91 ns | 0.0167 ns | 0.0140 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.41 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                            From_Short |  15.96 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  15.30 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  15.21 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.40 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                              From_Int |  15.21 ns | 0.0187 ns | 0.0165 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  14.99 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  15.00 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.34 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                             From_Long |  14.83 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  16.88 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  15.90 ns | 0.0148 ns | 0.0116 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.38 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                            From_SByte |  14.98 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  14.82 ns | 0.0047 ns | 0.0036 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  14.82 ns | 0.0022 ns | 0.0016 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.39 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                            From_Float |  14.98 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  14.99 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  14.82 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.54 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                           From_String | 795.22 ns | 0.6606 ns | 0.6179 ns |      - |       0 B |
                                  From_String_AsObject | 805.62 ns | 3.3082 ns | 2.7625 ns |      - |       0 B |
                                      From_String_Null |  16.71 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.50 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
                                     From_String_Empty |  15.96 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.82 ns | 0.0055 ns | 0.0040 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  15.19 ns | 0.0071 ns | 0.0056 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  15.28 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.35 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                                             From_UInt |  15.27 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  14.81 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  14.82 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.20 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
                                            From_ULong |  16.30 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  15.89 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  15.90 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.86 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                       From_NullObject |  17.34 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                           From_DBNull |  16.65 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
                                 From_ConvertibleClass |  23.80 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  25.27 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.22 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.34 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.26 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.81 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.29 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.37 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                From_ConvertibleStruct |  25.02 ns | 0.0145 ns | 0.0136 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  26.43 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.45 ns | 0.0044 ns | 0.0035 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.32 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.00 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.37 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.83 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.76 ns | 0.0125 ns | 0.0104 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.00 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.77 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.00 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.18 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
                                             From_Enum |  16.45 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  16.08 ns | 0.0165 ns | 0.0138 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  16.92 ns | 0.0045 ns | 0.0036 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.24 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                                      From_ParentClass |  16.42 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.31 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.55 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.83 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                     From_ParentStruct |  14.84 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.38 ns | 0.0118 ns | 0.0098 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  15.00 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.34 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.99 ns | 0.0048 ns | 0.0042 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.41 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |

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
