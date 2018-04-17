
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  23.86 ns | 0.0569 ns | 0.0475 ns |      - |       0 B |
                                    From_Bool_AsObject |  32.49 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  23.82 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  32.49 ns | 0.0223 ns | 0.0186 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  16.49 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.75 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                                             From_Byte |  23.28 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                                    From_Byte_AsObject |  32.48 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  23.81 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  33.21 ns | 0.0267 ns | 0.0250 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  16.49 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.75 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                             From_Char |  16.40 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  15.60 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  15.61 ns | 0.0154 ns | 0.0145 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  19.46 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                         From_DateTime |  16.77 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  16.04 ns | 0.0238 ns | 0.0223 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  16.02 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.27 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                                          From_Decimal |  20.96 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                 From_Decimal_AsObject |  32.91 ns | 0.0259 ns | 0.0230 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  16.70 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  32.75 ns | 0.0203 ns | 0.0180 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.71 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.30 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                                           From_Double |  87.71 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
                                  From_Double_AsObject | 100.03 ns | 0.0694 ns | 0.0615 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  87.90 ns | 0.0324 ns | 0.0303 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 100.21 ns | 0.0429 ns | 0.0358 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  17.66 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.83 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                                            From_Short |  23.54 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                                   From_Short_AsObject |  32.55 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  24.09 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  32.53 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.88 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  18.73 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                              From_Int |  23.27 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                                     From_Int_AsObject |  32.52 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  24.08 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  32.50 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.87 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.73 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                             From_Long |  23.81 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                                    From_Long_AsObject |  32.83 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  24.11 ns | 0.0098 ns | 0.0077 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  32.80 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  16.49 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.76 ns | 0.0260 ns | 0.0231 ns |      - |       0 B |
                                            From_SByte |  23.27 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
                                   From_SByte_AsObject |  32.52 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  23.82 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.54 ns | 0.0164 ns | 0.0119 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  16.50 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.74 ns | 0.0092 ns | 0.0081 ns |      - |       0 B |
                                            From_Float |  45.01 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
                                   From_Float_AsObject |  63.92 ns | 0.0710 ns | 0.0664 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  58.30 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  59.32 ns | 0.0350 ns | 0.0311 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.89 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.75 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                                           From_String | 131.89 ns | 0.0776 ns | 0.0726 ns |      - |       0 B |
                                  From_String_AsObject | 145.50 ns | 0.0514 ns | 0.0481 ns |      - |       0 B |
                                      From_String_Null |  17.76 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.75 ns | 0.0257 ns | 0.0240 ns |      - |       0 B |
                                     From_String_Empty |  17.48 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  23.28 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                  From_UShort_AsObject |  32.84 ns | 0.0287 ns | 0.0269 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  23.82 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  32.79 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  15.89 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.76 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
                                             From_UInt |  23.82 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                                    From_UInt_AsObject |  32.93 ns | 0.0582 ns | 0.0516 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  23.83 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.77 ns | 0.0538 ns | 0.0503 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  16.87 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  20.04 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                                            From_ULong |  23.27 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.94 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  23.83 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  33.20 ns | 0.0268 ns | 0.0250 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  16.51 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.74 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                       From_NullObject |  18.74 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                           From_DBNull |  17.75 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                 From_ConvertibleClass |  31.24 ns | 0.0270 ns | 0.0252 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  30.67 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  21.87 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  19.11 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.86 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.32 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.82 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  21.81 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.65 ns | 0.0096 ns | 0.0085 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  31.25 ns | 0.0449 ns | 0.0420 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  30.44 ns | 0.0135 ns | 0.0126 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  31.50 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  17.52 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.74 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                             From_NonConvertibleStruct |  16.97 ns | 0.0104 ns | 0.0098 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  25.31 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.16 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.69 ns | 0.0179 ns | 0.0158 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  16.14 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  19.40 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                                             From_Enum |  23.30 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                                    From_Enum_AsObject |  66.07 ns | 0.0635 ns | 0.0594 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  26.51 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  66.54 ns | 0.0748 ns | 0.0699 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  16.67 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  19.47 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                      From_ParentClass |  17.83 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.87 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                              From_ParentClass_NoValue |  17.84 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.72 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                     From_ParentStruct |  16.14 ns | 0.0157 ns | 0.0146 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.88 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  16.14 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  26.10 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  16.14 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  18.76 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_String_Empty_AsObject: DefaultJob
