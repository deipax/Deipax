
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  15.35 ns | 0.0985 ns | 0.0873 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.33 ns | 0.0197 ns | 0.0154 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  16.26 ns | 0.0574 ns | 0.0537 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  28.29 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.73 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.36 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
                                             From_Byte |  14.82 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.83 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  15.47 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.82 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.68 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  19.22 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                             From_Char |  14.84 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                    From_Char_AsObject |  29.64 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  15.23 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.63 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.71 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.84 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
                                         From_DateTime |  15.86 ns | 0.0081 ns | 0.0071 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  17.79 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.08 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  18.97 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                          From_Decimal |  29.16 ns | 0.0210 ns | 0.0196 ns |      - |       0 B |
                                 From_Decimal_AsObject |  39.90 ns | 0.0189 ns | 0.0148 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  31.66 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  39.31 ns | 0.0244 ns | 0.0229 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.61 ns | 0.0141 ns | 0.0118 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.02 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                           From_Double |  18.84 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                  From_Double_AsObject |  31.81 ns | 0.0453 ns | 0.0424 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  20.18 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  31.79 ns | 0.0411 ns | 0.0385 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.40 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.08 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                                            From_Short |  16.14 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
                                   From_Short_AsObject |  29.61 ns | 0.0111 ns | 0.0087 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  16.77 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  29.62 ns | 0.0334 ns | 0.0313 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.80 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.39 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                              From_Int |  15.89 ns | 0.0208 ns | 0.0184 ns |      - |       0 B |
                                     From_Int_AsObject |  29.35 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.99 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  29.36 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.67 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.36 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                             From_Long |  16.16 ns | 0.0090 ns | 0.0085 ns |      - |       0 B |
                                    From_Long_AsObject |  30.01 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  17.52 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  30.01 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.50 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.98 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                            From_SByte |  15.64 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                   From_SByte_AsObject |  29.27 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.00 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  30.32 ns | 0.0218 ns | 0.0193 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.01 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.86 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                            From_Float |  19.53 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                   From_Float_AsObject |  32.05 ns | 0.0235 ns | 0.0208 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  19.39 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  32.05 ns | 0.0246 ns | 0.0218 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.58 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  19.05 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                           From_String |  97.75 ns | 0.0913 ns | 0.0854 ns |      - |       0 B |
                                  From_String_AsObject | 108.73 ns | 0.0436 ns | 0.0408 ns |      - |       0 B |
                                      From_String_Null |  18.51 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.91 ns | 0.0081 ns | 0.0075 ns |      - |       0 B |
                                     From_String_Empty |  16.66 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.84 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                                  From_UShort_AsObject |  28.80 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  15.09 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.79 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.38 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.01 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
                                             From_UInt |  15.07 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.81 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.61 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.81 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.82 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.85 ns | 0.0038 ns | 0.0031 ns |      - |       0 B |
                                            From_ULong |  14.83 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.82 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  16.14 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.81 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.42 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.51 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                       From_NullObject |  18.05 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                           From_DBNull |  17.46 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                                 From_ConvertibleClass |  26.19 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  26.09 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.84 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.06 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                              From_NonConvertibleClass |  23.50 ns | 0.0037 ns | 0.0034 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  23.44 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.94 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.49 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.35 ns | 0.0109 ns | 0.0085 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  28.38 ns | 0.9599 ns | 1.2814 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.96 ns | 0.3756 ns | 0.3136 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.75 ns | 0.3846 ns | 0.3598 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.28 ns | 0.2717 ns | 0.2408 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.66 ns | 0.1508 ns | 0.1336 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.47 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  24.88 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.42 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.34 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.42 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.61 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                             From_Enum |  15.87 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                    From_Enum_AsObject |  61.30 ns | 0.0094 ns | 0.0078 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.74 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  61.29 ns | 0.0192 ns | 0.0170 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.06 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.42 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
                                      From_ParentClass |  17.18 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.92 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.07 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.86 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                                     From_ParentStruct |  14.40 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  24.00 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.45 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.92 ns | 0.0259 ns | 0.0243 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.41 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.89 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_SByteNullable.From_String_Empty_AsObject: DefaultJob
