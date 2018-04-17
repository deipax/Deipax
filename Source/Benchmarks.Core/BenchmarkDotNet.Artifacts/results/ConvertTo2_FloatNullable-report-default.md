
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.89 ns | 0.0494 ns | 0.0462 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.02 ns | 0.0414 ns | 0.0346 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.44 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.00 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.71 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.00 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                             From_Byte |  14.69 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                    From_Byte_AsObject |  27.99 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.91 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.00 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.67 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  20.80 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                                             From_Char |  14.44 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.40 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.56 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.39 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                                         From_DateTime |  14.97 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  15.19 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.86 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.06 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                                          From_Decimal |  25.93 ns | 0.0226 ns | 0.0212 ns |      - |       0 B |
                                 From_Decimal_AsObject |  84.67 ns | 0.0525 ns | 0.0466 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  31.88 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  84.65 ns | 0.0271 ns | 0.0226 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.60 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.93 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                                           From_Double |  14.65 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                  From_Double_AsObject |  28.00 ns | 0.0268 ns | 0.0237 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  15.68 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  27.98 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.45 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.99 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                            From_Short |  14.67 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                   From_Short_AsObject |  28.25 ns | 0.0053 ns | 0.0042 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.96 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.25 ns | 0.0077 ns | 0.0065 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.56 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.90 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                                              From_Int |  14.69 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                                     From_Int_AsObject |  27.99 ns | 0.0179 ns | 0.0158 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.98 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.99 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.67 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.87 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                                             From_Long |  14.77 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                                    From_Long_AsObject |  28.25 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  15.88 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  28.26 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.52 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  20.78 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
                                            From_SByte |  15.57 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                   From_SByte_AsObject |  27.98 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.90 ns | 0.0028 ns | 0.0021 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  27.98 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.58 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.06 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                            From_Float |  14.68 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                                   From_Float_AsObject |  29.99 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  13.99 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  30.90 ns | 0.0479 ns | 0.0448 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.99 ns | 0.0043 ns | 0.0040 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.69 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                                           From_String | 115.30 ns | 0.0948 ns | 0.0887 ns |      - |       0 B |
                                  From_String_AsObject | 127.07 ns | 0.1130 ns | 0.1002 ns |      - |       0 B |
                                      From_String_Null |  17.58 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.83 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                     From_String_Empty |  17.03 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  15.59 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                                  From_UShort_AsObject |  27.99 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.25 ns | 0.0999 ns | 0.0834 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  27.99 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  16.48 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.81 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                                             From_UInt |  14.92 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.25 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.07 ns | 0.0097 ns | 0.0090 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.27 ns | 0.0402 ns | 0.0357 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.67 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.36 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
                                            From_ULong |  21.17 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.82 ns | 0.0487 ns | 0.0455 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.50 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.80 ns | 0.0358 ns | 0.0299 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.41 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.89 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
                                       From_NullObject |  17.99 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                                           From_DBNull |  15.75 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.94 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  25.83 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.86 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.36 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.67 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.16 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  19.20 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.03 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.17 ns | 0.0271 ns | 0.0240 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.17 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.93 ns | 0.0081 ns | 0.0068 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.17 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.25 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  20.73 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.54 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  24.05 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.43 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.07 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.45 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.94 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                             From_Enum |  15.66 ns | 0.0107 ns | 0.0090 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.79 ns | 0.0465 ns | 0.0435 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.61 ns | 0.0467 ns | 0.0437 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.75 ns | 0.0063 ns | 0.0059 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.10 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.00 ns | 0.0110 ns | 0.0102 ns |      - |       0 B |
                                      From_ParentClass |  17.18 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                             From_ParentClass_AsObject |  24.22 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.60 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.73 ns | 0.0052 ns | 0.0038 ns |      - |       0 B |
                                     From_ParentStruct |  14.45 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.62 ns | 0.0190 ns | 0.0178 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.49 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  24.72 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.43 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.32 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_String_Empty_AsObject: DefaultJob
