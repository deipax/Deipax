
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.63 ns | 0.0366 ns | 0.0306 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.86 ns | 0.0279 ns | 0.0233 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.34 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.85 ns | 0.0288 ns | 0.0241 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.40 ns | 0.0084 ns | 0.0074 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.26 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                             From_Byte |  14.00 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.85 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.80 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.85 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.23 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.28 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
                                             From_Char |  14.01 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                    From_Char_AsObject |  26.66 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.82 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.66 ns | 0.0305 ns | 0.0271 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.21 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.39 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                                         From_DateTime |  14.53 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.95 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.96 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.31 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                                          From_Decimal |  25.32 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                                 From_Decimal_AsObject |  36.27 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  26.93 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  36.84 ns | 0.0166 ns | 0.0129 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.35 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.11 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                           From_Double |  18.04 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                                  From_Double_AsObject |  30.89 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.11 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.92 ns | 0.0321 ns | 0.0284 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.97 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.88 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                            From_Short |  14.01 ns | 0.0188 ns | 0.0175 ns |      - |       0 B |
                                   From_Short_AsObject |  25.84 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  15.56 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.84 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.24 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.32 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                              From_Int |  14.01 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                     From_Int_AsObject |  25.89 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.83 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.85 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.45 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.29 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                             From_Long |  14.03 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
                                    From_Long_AsObject |  17.83 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.08 ns | 0.0116 ns | 0.0097 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  17.77 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.22 ns | 0.0035 ns | 0.0028 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.76 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
                                            From_SByte |  13.99 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.83 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.81 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.83 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.84 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.69 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
                                            From_Float |  18.04 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                   From_Float_AsObject |  30.95 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.65 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.95 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.21 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.27 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                                           From_String |  90.93 ns | 0.0319 ns | 0.0282 ns |      - |       0 B |
                                  From_String_AsObject | 103.36 ns | 0.0191 ns | 0.0149 ns |      - |       0 B |
                                      From_String_Null |  15.59 ns | 0.0067 ns | 0.0052 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.26 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                     From_String_Empty |  15.94 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.98 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.83 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.83 ns | 0.0385 ns | 0.0360 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.83 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.40 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.34 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                                             From_UInt |  13.99 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                                    From_UInt_AsObject |  25.83 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  14.80 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  25.83 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.21 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.78 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                            From_ULong |  14.95 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.64 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.15 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.64 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.06 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.26 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |
                                       From_NullObject |  17.27 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                           From_DBNull |  15.33 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.50 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.82 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.49 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.82 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.00 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.56 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.03 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.25 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.12 ns | 0.0035 ns | 0.0027 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.02 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.61 ns | 0.0184 ns | 0.0154 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.02 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.82 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.29 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.01 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.58 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.01 ns | 0.0125 ns | 0.0116 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.68 ns | 0.0152 ns | 0.0143 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.01 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                                             From_Enum |  13.98 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                                    From_Enum_AsObject |  57.65 ns | 0.0085 ns | 0.0075 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  16.40 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  57.41 ns | 0.0130 ns | 0.0115 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  14.78 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.76 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                      From_ParentClass |  16.71 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.74 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
                              From_ParentClass_NoValue |  16.01 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.28 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                     From_ParentStruct |  13.99 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.11 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.99 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.33 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.53 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  20.11 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
