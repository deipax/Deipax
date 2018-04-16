
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.57 ns | 0.0893 ns | 0.0835 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.49 ns | 0.0214 ns | 0.0178 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.49 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.49 ns | 0.0170 ns | 0.0151 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.95 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.40 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                             From_Byte |  14.42 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.84 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.02 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.85 ns | 0.0226 ns | 0.0212 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.68 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.43 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                             From_Char |  14.15 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.14 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.87 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.42 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                                         From_DateTime |  14.45 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.79 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.80 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.84 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                          From_Decimal |  22.61 ns | 0.0122 ns | 0.0102 ns |      - |       0 B |
                                 From_Decimal_AsObject |  34.21 ns | 0.0387 ns | 0.0362 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  37.50 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  33.78 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.14 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  20.16 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                           From_Double |  14.13 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                  From_Double_AsObject |  25.84 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  17.76 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  26.63 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.87 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.40 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                                            From_Short |  14.40 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                   From_Short_AsObject |  26.10 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.15 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  27.02 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.67 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.46 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                                              From_Int |  14.11 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
                                     From_Int_AsObject |  25.83 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.82 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.84 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.93 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.68 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                                             From_Long |  14.13 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                    From_Long_AsObject |  26.10 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.74 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.10 ns | 0.0039 ns | 0.0037 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.86 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.86 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                            From_SByte |  14.40 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.83 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  17.00 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.98 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.66 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.40 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                                            From_Float |  14.15 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                                   From_Float_AsObject |  17.91 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  14.95 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  17.91 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.40 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.41 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                           From_String | 113.97 ns | 0.0320 ns | 0.0284 ns |      - |       0 B |
                                  From_String_AsObject | 124.57 ns | 0.0511 ns | 0.0453 ns |      - |       0 B |
                                      From_String_Null |  16.05 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.20 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                     From_String_Empty |  15.94 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.13 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.83 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.03 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.86 ns | 0.0223 ns | 0.0198 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.93 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.40 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
                                             From_UInt |  14.66 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.10 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.00 ns | 0.0033 ns | 0.0025 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.10 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.66 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.52 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                            From_ULong |  14.40 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.64 ns | 0.0100 ns | 0.0078 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.01 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.64 ns | 0.0110 ns | 0.0086 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.86 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.52 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
                                       From_NullObject |  20.66 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                           From_DBNull |  15.32 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.03 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.67 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.76 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.46 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.90 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.79 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  15.99 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.35 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.60 ns | 0.0071 ns | 0.0066 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.01 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.68 ns | 0.0067 ns | 0.0063 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.01 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.69 ns | 0.0114 ns | 0.0089 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.47 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.88 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.74 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.16 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.73 ns | 0.0055 ns | 0.0043 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.15 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.43 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                             From_Enum |  14.12 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                    From_Enum_AsObject |  58.79 ns | 0.0113 ns | 0.0095 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.01 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  58.55 ns | 0.0467 ns | 0.0437 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.94 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.41 ns | 0.0090 ns | 0.0076 ns |      - |       0 B |
                                      From_ParentClass |  16.04 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.51 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.01 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.33 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                                     From_ParentStruct |  13.87 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.38 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.14 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.45 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.15 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.40 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Float.From_Char_AsObject: DefaultJob
  ConvertTo2_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Float.From_String_Empty_AsObject: DefaultJob
