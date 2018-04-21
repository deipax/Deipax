
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.60 ns | 0.1104 ns | 0.1033 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  13.97 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  13.32 ns | 0.0430 ns | 0.0381 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.34 ns | 0.0350 ns | 0.0328 ns |      - |       0 B |
                                             From_Byte |  13.32 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  13.47 ns | 0.0274 ns | 0.0256 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  13.45 ns | 0.0064 ns | 0.0054 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.38 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
                                             From_Char |  13.38 ns | 0.0238 ns | 0.0223 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  13.55 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  13.62 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.40 ns | 0.0520 ns | 0.0461 ns |      - |       0 B |
                                         From_DateTime |  14.19 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                From_DateTime_AsObject |  17.83 ns | 0.0262 ns | 0.0246 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  14.33 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  17.82 ns | 0.0371 ns | 0.0329 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  14.22 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.30 ns | 0.0138 ns | 0.0115 ns |      - |       0 B |
                                          From_Decimal |  14.22 ns | 0.0070 ns | 0.0059 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  14.49 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  14.33 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.90 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                                           From_Double |  13.31 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  14.20 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  14.20 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.96 ns | 0.0054 ns | 0.0042 ns |      - |       0 B |
                                            From_Short |  13.32 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  13.55 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  13.65 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.38 ns | 0.0298 ns | 0.0279 ns |      - |       0 B |
                                              From_Int |  13.64 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  13.30 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  13.29 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.25 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                                             From_Long |  13.47 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  14.23 ns | 0.0342 ns | 0.0320 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  14.38 ns | 0.0260 ns | 0.0244 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.34 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
                                            From_SByte |  13.34 ns | 0.0397 ns | 0.0372 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  13.45 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  13.45 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  19.90 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                                            From_Float |  13.31 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  13.32 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  13.47 ns | 0.0308 ns | 0.0288 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.32 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
                                           From_String | 797.65 ns | 0.5665 ns | 0.4730 ns |      - |       0 B |
                                  From_String_AsObject | 871.32 ns | 1.0318 ns | 0.9147 ns |      - |       0 B |
                                      From_String_Null |  16.92 ns | 0.0067 ns | 0.0053 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.32 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
                                     From_String_Empty |  16.15 ns | 0.0105 ns | 0.0088 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.47 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  13.63 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  13.57 ns | 0.0683 ns | 0.0533 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.25 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                                             From_UInt |  13.56 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  13.47 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  13.45 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.89 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                                            From_ULong |  13.35 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  13.98 ns | 0.0421 ns | 0.0394 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  14.20 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.34 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
                                       From_NullObject |  17.39 ns | 0.0322 ns | 0.0301 ns |      - |       0 B |
                                           From_DBNull |  14.42 ns | 0.0288 ns | 0.0256 ns |      - |       0 B |
                                  From_DBNull_AsObject |  17.89 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
                                 From_ConvertibleClass |  20.05 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  21.77 ns | 0.0417 ns | 0.0390 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.04 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.39 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.68 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  19.92 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  14.23 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.33 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.72 ns | 0.0488 ns | 0.0456 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  23.04 ns | 0.0305 ns | 0.0270 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  22.93 ns | 0.0140 ns | 0.0131 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  23.03 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.45 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.94 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                             From_NonConvertibleStruct |  13.47 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  20.39 ns | 0.0270 ns | 0.0252 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.47 ns | 0.0350 ns | 0.0310 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  19.07 ns | 0.0067 ns | 0.0053 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.31 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.45 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
                                             From_Enum |  13.64 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  13.47 ns | 0.0168 ns | 0.0158 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  13.31 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.85 ns | 0.0048 ns | 0.0038 ns |      - |       0 B |
                                      From_ParentClass |  14.38 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
                             From_ParentClass_AsObject |  19.53 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
                              From_ParentClass_NoValue |  14.23 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.32 ns | 0.0266 ns | 0.0249 ns |      - |       0 B |
                                     From_ParentStruct |  13.48 ns | 0.0367 ns | 0.0326 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  19.83 ns | 0.0272 ns | 0.0254 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.31 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  19.54 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.30 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.96 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |

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
