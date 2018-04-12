
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  22.33 ns | 0.0057 ns | 0.0048 ns |  22.32 ns |      - |       0 B |
                                 From_Bool_AsObject |  31.83 ns | 0.0251 ns | 0.0209 ns |  31.83 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  25.64 ns | 0.0145 ns | 0.0136 ns |  25.64 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  35.67 ns | 0.0245 ns | 0.0217 ns |  35.67 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  16.59 ns | 0.0129 ns | 0.0121 ns |  16.59 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  18.58 ns | 0.0133 ns | 0.0125 ns |  18.58 ns |      - |       0 B |
                                          From_Byte |  23.11 ns | 0.0106 ns | 0.0099 ns |  23.11 ns |      - |       0 B |
                                 From_Byte_AsObject |  31.88 ns | 0.0243 ns | 0.0227 ns |  31.88 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  25.18 ns | 0.0116 ns | 0.0109 ns |  25.18 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  32.68 ns | 0.0214 ns | 0.0200 ns |  32.68 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  16.58 ns | 0.0117 ns | 0.0104 ns |  16.58 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  19.88 ns | 0.0124 ns | 0.0116 ns |  19.88 ns |      - |       0 B |
                                          From_Char |  15.30 ns | 0.0013 ns | 0.0011 ns |  15.30 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  14.79 ns | 0.0130 ns | 0.0115 ns |  14.79 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  14.80 ns | 0.0043 ns | 0.0038 ns |  14.80 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  18.64 ns | 0.0145 ns | 0.0136 ns |  18.64 ns |      - |       0 B |
                                      From_DateTime |  15.20 ns | 0.0171 ns | 0.0160 ns |  15.19 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  16.43 ns | 0.0076 ns | 0.0071 ns |  16.43 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  15.06 ns | 0.0133 ns | 0.0111 ns |  15.06 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  19.20 ns | 0.0125 ns | 0.0116 ns |  19.20 ns |      - |       0 B |
                                       From_Decimal |  16.79 ns | 0.0043 ns | 0.0038 ns |  16.79 ns |      - |       0 B |
                              From_Decimal_AsObject |  31.86 ns | 0.0262 ns | 0.0245 ns |  31.86 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  15.60 ns | 0.0108 ns | 0.0095 ns |  15.60 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  32.34 ns | 0.0256 ns | 0.0240 ns |  32.35 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  15.32 ns | 0.0047 ns | 0.0044 ns |  15.33 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  19.47 ns | 0.0172 ns | 0.0161 ns |  19.47 ns |      - |       0 B |
                                        From_Double |  81.53 ns | 0.0309 ns | 0.0258 ns |  81.53 ns |      - |       0 B |
                               From_Double_AsObject |  95.64 ns | 0.0372 ns | 0.0348 ns |  95.64 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  86.67 ns | 0.0265 ns | 0.0248 ns |  86.67 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  94.51 ns | 0.0578 ns | 0.0541 ns |  94.49 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  17.39 ns | 0.0300 ns | 0.0281 ns |  17.38 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  18.52 ns | 0.0124 ns | 0.0116 ns |  18.52 ns |      - |       0 B |
                                         From_Short |  22.09 ns | 0.0045 ns | 0.0042 ns |  22.09 ns |      - |       0 B |
                                From_Short_AsObject |  31.94 ns | 0.0125 ns | 0.0104 ns |  31.95 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  25.13 ns | 0.0125 ns | 0.0117 ns |  25.13 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  31.92 ns | 0.0204 ns | 0.0191 ns |  31.94 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  15.96 ns | 0.0046 ns | 0.0043 ns |  15.96 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  20.87 ns | 0.0103 ns | 0.0096 ns |  20.87 ns |      - |       0 B |
                                           From_Int |  22.09 ns | 0.0120 ns | 0.0113 ns |  22.09 ns |      - |       0 B |
                                  From_Int_AsObject |  31.92 ns | 0.0243 ns | 0.0216 ns |  31.92 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  25.13 ns | 0.0114 ns | 0.0106 ns |  25.12 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  31.90 ns | 0.0011 ns | 0.0009 ns |  31.90 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  16.86 ns | 0.0255 ns | 0.0238 ns |  16.85 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  18.57 ns | 0.0110 ns | 0.0103 ns |  18.56 ns |      - |       0 B |
                                          From_Long |  22.33 ns | 0.0049 ns | 0.0041 ns |  22.33 ns |      - |       0 B |
                                 From_Long_AsObject |  33.13 ns | 0.0401 ns | 0.0356 ns |  33.12 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  25.67 ns | 0.0123 ns | 0.0115 ns |  25.67 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  33.80 ns | 0.0246 ns | 0.0230 ns |  33.79 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  16.33 ns | 0.0130 ns | 0.0121 ns |  16.33 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  19.47 ns | 0.0050 ns | 0.0042 ns |  19.47 ns |      - |       0 B |
                                         From_SByte |  22.35 ns | 0.0032 ns | 0.0025 ns |  22.35 ns |      - |       0 B |
                                From_SByte_AsObject |  31.95 ns | 0.0321 ns | 0.0300 ns |  31.94 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  25.13 ns | 0.0126 ns | 0.0117 ns |  25.13 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  32.31 ns | 0.0133 ns | 0.0125 ns |  32.31 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  16.58 ns | 0.0109 ns | 0.0097 ns |  16.57 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  18.52 ns | 0.0133 ns | 0.0124 ns |  18.52 ns |      - |       0 B |
                                         From_Float |  44.23 ns | 0.0195 ns | 0.0182 ns |  44.24 ns |      - |       0 B |
                                From_Float_AsObject |  56.35 ns | 0.0339 ns | 0.0283 ns |  56.35 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  47.92 ns | 0.0198 ns | 0.0186 ns |  47.93 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  56.23 ns | 0.0634 ns | 0.0593 ns |  56.22 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  15.96 ns | 0.0114 ns | 0.0107 ns |  15.95 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  18.53 ns | 0.0105 ns | 0.0093 ns |  18.52 ns |      - |       0 B |
                                        From_String | 124.21 ns | 0.0982 ns | 0.0919 ns | 124.23 ns |      - |       0 B |
                               From_String_AsObject | 137.20 ns | 0.5131 ns | 0.4285 ns | 137.02 ns |      - |       0 B |
                                   From_String_Null |  17.64 ns | 0.0106 ns | 0.0094 ns |  17.64 ns |      - |       0 B |
                          From_String_Null_AsObject |  18.58 ns | 0.0034 ns | 0.0028 ns |  18.58 ns |      - |       0 B |
                                  From_String_Empty |  17.72 ns | 0.0106 ns | 0.0099 ns |  17.71 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  22.34 ns | 0.0081 ns | 0.0076 ns |  22.34 ns |      - |       0 B |
                               From_UShort_AsObject |  31.91 ns | 0.0182 ns | 0.0170 ns |  31.91 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  25.14 ns | 0.0045 ns | 0.0035 ns |  25.14 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  31.92 ns | 0.0336 ns | 0.0297 ns |  31.91 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  15.84 ns | 0.0160 ns | 0.0150 ns |  15.84 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  19.36 ns | 0.0038 ns | 0.0036 ns |  19.36 ns |      - |       0 B |
                                          From_UInt |  22.08 ns | 0.0105 ns | 0.0098 ns |  22.07 ns |      - |       0 B |
                                 From_UInt_AsObject |  31.51 ns | 0.0567 ns | 0.0530 ns |  31.51 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  25.13 ns | 0.0079 ns | 0.0074 ns |  25.13 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  31.42 ns | 0.0090 ns | 0.0084 ns |  31.42 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  16.88 ns | 0.0243 ns | 0.0227 ns |  16.88 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  20.67 ns | 0.0127 ns | 0.0106 ns |  20.67 ns |      - |       0 B |
                                         From_ULong |  22.34 ns | 0.0150 ns | 0.0141 ns |  22.34 ns |      - |       0 B |
                                From_ULong_AsObject |  31.43 ns | 0.0156 ns | 0.0146 ns |  31.43 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  25.41 ns | 0.0130 ns | 0.0121 ns |  25.41 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  31.46 ns | 0.0269 ns | 0.0251 ns |  31.46 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  16.34 ns | 0.0182 ns | 0.0170 ns |  16.33 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  18.53 ns | 0.0053 ns | 0.0050 ns |  18.54 ns |      - |       0 B |
                                    From_NullObject |  20.06 ns | 0.0042 ns | 0.0035 ns |  20.06 ns |      - |       0 B |
                                        From_DBNull |  18.06 ns | 0.0310 ns | 0.0290 ns |  18.06 ns |      - |       0 B |
                              From_ConvertibleClass |  27.36 ns | 0.0214 ns | 0.0200 ns |  27.36 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  29.15 ns | 0.0131 ns | 0.0102 ns |  29.15 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  19.62 ns | 0.0084 ns | 0.0079 ns |  19.62 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.55 ns | 0.0129 ns | 0.0120 ns |  18.55 ns |      - |       0 B |
                             From_ConvertibleStruct |  26.16 ns | 0.0148 ns | 0.0107 ns |  26.17 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  30.27 ns | 0.0070 ns | 0.0058 ns |  30.27 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  28.80 ns | 0.0147 ns | 0.0130 ns |  28.79 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.33 ns | 0.0042 ns | 0.0035 ns |  30.33 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  16.59 ns | 0.0019 ns | 0.0015 ns |  16.59 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  20.31 ns | 0.0128 ns | 0.0120 ns |  20.31 ns |      - |       0 B |
                                          From_Enum |  26.66 ns | 0.0024 ns | 0.0019 ns |  26.66 ns |      - |       0 B |
                                 From_Enum_AsObject |  64.67 ns | 0.0115 ns | 0.0096 ns |  64.67 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  29.71 ns | 0.0092 ns | 0.0086 ns |  29.71 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  64.43 ns | 0.0115 ns | 0.0102 ns |  64.43 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  15.95 ns | 0.0005 ns | 0.0004 ns |  15.95 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  19.33 ns | 0.0028 ns | 0.0023 ns |  19.33 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DecimalNullable.From_String_Empty_AsObject: DefaultJob
