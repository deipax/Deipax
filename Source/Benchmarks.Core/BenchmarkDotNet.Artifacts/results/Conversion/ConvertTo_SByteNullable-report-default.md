
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  39.57 ns | 0.0251 ns | 0.0222 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  38.54 ns | 0.0875 ns | 0.0776 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 113.58 ns | 0.0138 ns | 0.0115 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.53 ns | 0.0693 ns | 0.0648 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.74 ns | 0.0584 ns | 0.0546 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.23 ns | 0.0164 ns | 0.0145 ns |      - |       0 B |
                                          From_Byte |  40.12 ns | 0.0145 ns | 0.0121 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  39.04 ns | 0.0329 ns | 0.0292 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 114.34 ns | 0.0414 ns | 0.0367 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  39.07 ns | 0.0588 ns | 0.0521 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.95 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.11 ns | 0.0360 ns | 0.0319 ns |      - |       0 B |
                                          From_Char |  41.95 ns | 0.0085 ns | 0.0075 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  39.84 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 115.02 ns | 0.0660 ns | 0.0617 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  39.83 ns | 0.0357 ns | 0.0298 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  42.71 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.01 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.48 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.24 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                                       From_Decimal |  53.93 ns | 0.0154 ns | 0.0136 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  51.14 ns | 0.0812 ns | 0.0760 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 131.53 ns | 0.0234 ns | 0.0207 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  51.14 ns | 0.0688 ns | 0.0643 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.96 ns | 0.0278 ns | 0.0247 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.22 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                                        From_Double |  44.66 ns | 0.0125 ns | 0.0104 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  42.27 ns | 0.0814 ns | 0.0761 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 120.95 ns | 0.0900 ns | 0.0798 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  42.18 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.25 ns | 0.0061 ns | 0.0048 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.00 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
                                         From_Short |  40.91 ns | 0.0093 ns | 0.0083 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  39.82 ns | 0.0053 ns | 0.0041 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 121.57 ns | 0.1602 ns | 0.1499 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  39.83 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.71 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.98 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
                                           From_Int |  40.61 ns | 0.0075 ns | 0.0067 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  39.55 ns | 0.0211 ns | 0.0198 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 117.08 ns | 0.0351 ns | 0.0329 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  39.54 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.83 ns | 0.0360 ns | 0.0337 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.23 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                          From_Long |  41.17 ns | 0.0040 ns | 0.0031 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  39.81 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 117.91 ns | 0.0206 ns | 0.0192 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  39.81 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  42.41 ns | 0.0297 ns | 0.0263 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.23 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                                         From_SByte |  29.58 ns | 0.0252 ns | 0.0236 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  27.18 ns | 0.0160 ns | 0.0141 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 101.45 ns | 0.0091 ns | 0.0071 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  27.17 ns | 0.0034 ns | 0.0026 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  43.44 ns | 0.0887 ns | 0.0830 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  15.00 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
                                         From_Float |  45.49 ns | 0.0070 ns | 0.0059 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  44.15 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 121.10 ns | 0.0206 ns | 0.0161 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  44.19 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  42.52 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  15.72 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
                                        From_String | 120.66 ns | 0.6102 ns | 0.5708 ns |      - |       0 B |
                               From_String_AsObject | 132.79 ns | 0.0592 ns | 0.0462 ns |      - |       0 B |
                                   From_String_Null |  15.22 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.67 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  40.11 ns | 0.0316 ns | 0.0280 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  39.03 ns | 0.0278 ns | 0.0246 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 116.06 ns | 0.0703 ns | 0.0587 ns | 0.0055 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  39.11 ns | 0.0339 ns | 0.0300 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.71 ns | 0.0414 ns | 0.0367 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.23 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                                          From_UInt |  42.48 ns | 0.0060 ns | 0.0050 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  40.47 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 113.90 ns | 0.0152 ns | 0.0127 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  40.38 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.67 ns | 0.0378 ns | 0.0295 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.05 ns | 0.0172 ns | 0.0160 ns |      - |       0 B |
                                         From_ULong |  42.13 ns | 0.0097 ns | 0.0086 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  39.06 ns | 0.0292 ns | 0.0273 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 116.72 ns | 0.0516 ns | 0.0457 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  39.03 ns | 0.0394 ns | 0.0329 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  46.90 ns | 0.0100 ns | 0.0078 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.03 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
                                    From_NullObject |  15.01 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                                        From_DBNull |  15.90 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
                              From_ConvertibleClass |  36.58 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  37.78 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.22 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.92 ns | 0.0278 ns | 0.0247 ns |      - |       0 B |
                             From_ConvertibleStruct |  39.61 ns | 0.0060 ns | 0.0050 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  37.99 ns | 0.0298 ns | 0.0279 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 120.36 ns | 0.1187 ns | 0.1110 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  37.95 ns | 0.0308 ns | 0.0257 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  43.28 ns | 0.0343 ns | 0.0321 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.22 ns | 0.0010 ns | 0.0007 ns |      - |       0 B |
                                          From_Enum | 105.70 ns | 0.0308 ns | 0.0288 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject | 102.51 ns | 0.0222 ns | 0.0186 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 206.95 ns | 1.1945 ns | 1.1174 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject | 101.74 ns | 0.0378 ns | 0.0353 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.42 ns | 0.0824 ns | 0.0771 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.08 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_SByteNullable.From_DateTime: DefaultJob
  ConvertTo_SByteNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_SByteNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_SByteNullable.From_String_Empty: DefaultJob
  ConvertTo_SByteNullable.From_String_Empty_AsObject: DefaultJob
