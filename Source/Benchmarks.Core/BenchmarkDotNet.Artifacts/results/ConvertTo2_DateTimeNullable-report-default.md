
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  15.82 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                                 From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue |  15.57 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue |  15.57 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.92 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                                          From_Byte |  16.86 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
                                 From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Byte_Nullable_WithValue |  15.57 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Byte_Nullable_NoValue |  15.56 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.90 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                          From_Char |  16.27 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  15.06 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  15.06 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.89 ns | 0.0086 ns | 0.0067 ns |      - |       0 B |
                                      From_DateTime |  15.95 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
                             From_DateTime_AsObject |  31.28 ns | 0.0318 ns | 0.0298 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  15.58 ns | 0.0103 ns | 0.0092 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  31.33 ns | 0.0074 ns | 0.0053 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  15.62 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  21.46 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                                       From_Decimal |  19.13 ns | 0.0153 ns | 0.0144 ns |      - |       0 B |
                              From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue |  15.77 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue |  16.65 ns | 0.0149 ns | 0.0116 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  20.54 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                        From_Double |  15.57 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                               From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue |  15.56 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue |  15.55 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  18.90 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                         From_Short |  15.82 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Short_Nullable_WithValue |  16.04 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Short_Nullable_NoValue |  16.07 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  18.91 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                                           From_Int |  16.31 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                                  From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Int_Nullable_WithValue |  16.80 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Int_Nullable_NoValue |  15.04 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.94 ns | 0.0259 ns | 0.0242 ns |      - |       0 B |
                                          From_Long |  16.32 ns | 0.0245 ns | 0.0205 ns |      - |       0 B |
                                 From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Long_Nullable_WithValue |  17.10 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Long_Nullable_NoValue |  15.55 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  18.95 ns | 0.0210 ns | 0.0196 ns |      - |       0 B |
                                         From_SByte |  16.86 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
                                From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_SByte_Nullable_WithValue |  15.55 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_SByte_Nullable_NoValue |  15.55 ns | 0.0015 ns | 0.0011 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  19.75 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                         From_Float |  15.58 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                                From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue |  15.05 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue |  15.55 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  19.73 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                        From_String | 760.04 ns | 0.4280 ns | 0.3794 ns |      - |       0 B |
                               From_String_AsObject | 750.53 ns | 0.6790 ns | 0.6019 ns |      - |       0 B |
                                   From_String_Null |  17.91 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.94 ns | 0.0235 ns | 0.0196 ns |      - |       0 B |
                                  From_String_Empty |  18.11 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  15.87 ns | 0.0382 ns | 0.0357 ns |      - |       0 B |
                               From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_UShort_Nullable_WithValue |  16.07 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UShort_Nullable_NoValue |  16.08 ns | 0.0485 ns | 0.0454 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.97 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
                                          From_UInt |  15.30 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                                 From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UInt_Nullable_WithValue |  15.10 ns | 0.0476 ns | 0.0445 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_UInt_Nullable_NoValue |  15.21 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.99 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                                         From_ULong |  15.28 ns | 0.0274 ns | 0.0243 ns |      - |       0 B |
                                From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_ULong_Nullable_WithValue |  15.59 ns | 0.0054 ns | 0.0050 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_ULong_Nullable_NoValue |  15.59 ns | 0.0422 ns | 0.0395 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  22.88 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                                    From_NullObject |  18.96 ns | 0.0088 ns | 0.0068 ns |      - |       0 B |
                                        From_DBNull |  16.84 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                              From_ConvertibleClass |  27.70 ns | 0.0306 ns | 0.0286 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.68 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.96 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  19.77 ns | 0.0107 ns | 0.0094 ns |      - |       0 B |
                             From_ConvertibleStruct |  24.82 ns | 0.0336 ns | 0.0298 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.88 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.87 ns | 0.0080 ns | 0.0058 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.89 ns | 0.0306 ns | 0.0271 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.63 ns | 0.0390 ns | 0.0364 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.90 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                                          From_Enum |  15.15 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                 From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Enum_Nullable_WithValue |  16.31 ns | 0.0385 ns | 0.0360 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Enum_Nullable_NoValue |  15.08 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  19.90 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
