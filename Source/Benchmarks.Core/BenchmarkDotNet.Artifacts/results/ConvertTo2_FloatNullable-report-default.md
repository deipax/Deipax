
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.82 ns | 0.0470 ns | 0.0392 ns |      - |       0 B |
                                    From_Bool_AsObject |  28.02 ns | 0.0460 ns | 0.0407 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.68 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  27.98 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.47 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.82 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                             From_Byte |  14.97 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                    From_Byte_AsObject |  28.00 ns | 0.0195 ns | 0.0173 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  17.62 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  28.00 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.05 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.01 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                             From_Char |  16.65 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  14.65 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  14.41 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.02 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
                                         From_DateTime |  15.10 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.82 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.92 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.82 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                                          From_Decimal |  25.86 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                                 From_Decimal_AsObject |  35.90 ns | 0.0319 ns | 0.0267 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  45.51 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.85 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  17.63 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  21.19 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                                           From_Double |  14.94 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
                                  From_Double_AsObject |  28.01 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  18.13 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  28.00 ns | 0.0240 ns | 0.0225 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.14 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.40 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                            From_Short |  15.76 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                   From_Short_AsObject |  28.30 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.66 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  28.25 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.13 ns | 0.0037 ns | 0.0032 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.83 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                              From_Int |  14.67 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                     From_Int_AsObject |  27.99 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.91 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  27.98 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.20 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.73 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                                             From_Long |  14.94 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                    From_Long_AsObject |  28.25 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  18.97 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  28.25 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.56 ns | 0.1022 ns | 0.0956 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.85 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                            From_SByte |  14.96 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                                   From_SByte_AsObject |  27.98 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  18.08 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  27.98 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.22 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.10 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                            From_Float |  14.94 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                                   From_Float_AsObject |  30.28 ns | 0.0201 ns | 0.0168 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  14.14 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.62 ns | 0.0113 ns | 0.0095 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.88 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.71 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
                                           From_String | 116.05 ns | 0.0458 ns | 0.0428 ns |      - |       0 B |
                                  From_String_AsObject | 126.80 ns | 0.0334 ns | 0.0296 ns |      - |       0 B |
                                      From_String_Null |  16.33 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                             From_String_Null_AsObject |  19.12 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                     From_String_Empty |  16.71 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.76 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
                                  From_UShort_AsObject |  27.99 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  19.59 ns | 0.0210 ns | 0.0197 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  28.39 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  26.76 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.81 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                                             From_UInt |  15.21 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                                    From_UInt_AsObject |  28.26 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.81 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  28.25 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.30 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.38 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                                            From_ULong |  15.20 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                                   From_ULong_AsObject |  28.79 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  18.82 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  28.80 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.13 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  19.08 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                                       From_NullObject |  17.82 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                           From_DBNull |  15.76 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
                                 From_ConvertibleClass |  25.84 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  27.30 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  19.05 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.90 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.97 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  24.73 ns | 0.0087 ns | 0.0078 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.97 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.00 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.63 ns | 0.0048 ns | 0.0045 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  27.16 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.88 ns | 0.0170 ns | 0.0151 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  27.16 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  16.23 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.69 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.41 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  26.44 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  15.19 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  23.20 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.66 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.55 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                             From_Enum |  14.84 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.81 ns | 0.0108 ns | 0.0101 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  17.61 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.76 ns | 0.0302 ns | 0.0268 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.22 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.99 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                                      From_ParentClass |  17.78 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                             From_ParentClass_AsObject |  23.60 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                              From_ParentClass_NoValue |  18.36 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.81 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                                     From_ParentStruct |  14.48 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  23.89 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.67 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  23.67 ns | 0.0075 ns | 0.0062 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.65 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.84 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_FloatNullable.From_String_Empty_AsObject: DefaultJob
