
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  40.73 ns | 0.4259 ns | 0.3775 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  38.42 ns | 0.1513 ns | 0.1341 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 114.32 ns | 0.1111 ns | 0.0985 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.36 ns | 0.0928 ns | 0.0775 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.33 ns | 0.0298 ns | 0.0278 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.93 ns | 0.0421 ns | 0.0373 ns |      - |       0 B |
                                          From_Byte |  39.59 ns | 0.0327 ns | 0.0290 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  38.33 ns | 0.0858 ns | 0.0803 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 115.91 ns | 0.1439 ns | 0.1346 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  38.39 ns | 0.1088 ns | 0.0965 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  43.44 ns | 0.0596 ns | 0.0557 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  15.26 ns | 0.0323 ns | 0.0303 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  42.10 ns | 0.1323 ns | 0.1238 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.27 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  42.90 ns | 0.0162 ns | 0.0126 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.53 ns | 0.0468 ns | 0.0438 ns |      - |       0 B |
                                       From_Decimal |  50.32 ns | 0.0624 ns | 0.0553 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  47.79 ns | 0.1606 ns | 0.1502 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 129.44 ns | 0.0857 ns | 0.0669 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  47.93 ns | 0.1537 ns | 0.1362 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  44.45 ns | 0.0430 ns | 0.0381 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.85 ns | 0.0340 ns | 0.0301 ns |      - |       0 B |
                                        From_Double |  40.82 ns | 0.0550 ns | 0.0514 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  38.43 ns | 0.0961 ns | 0.0899 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 114.80 ns | 0.2261 ns | 0.2115 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  38.37 ns | 0.1572 ns | 0.1470 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.41 ns | 0.0189 ns | 0.0158 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.30 ns | 0.0122 ns | 0.0088 ns |      - |       0 B |
                                         From_Short |  40.85 ns | 0.0866 ns | 0.0810 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  38.65 ns | 0.1080 ns | 0.1010 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 114.68 ns | 0.1425 ns | 0.1264 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  38.78 ns | 0.0502 ns | 0.0392 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  43.19 ns | 0.0226 ns | 0.0189 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  15.26 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
                                           From_Int |  40.55 ns | 0.0168 ns | 0.0131 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  38.65 ns | 0.0462 ns | 0.0334 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 114.43 ns | 0.1066 ns | 0.0997 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  38.35 ns | 0.0259 ns | 0.0230 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.85 ns | 0.0210 ns | 0.0164 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.58 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
                                          From_Long |  39.93 ns | 0.0127 ns | 0.0106 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  38.62 ns | 0.0174 ns | 0.0126 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 116.37 ns | 0.0428 ns | 0.0357 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  38.79 ns | 0.0579 ns | 0.0513 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  41.22 ns | 0.0148 ns | 0.0115 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.50 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
                                         From_SByte |  39.56 ns | 0.0159 ns | 0.0124 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  38.34 ns | 0.0726 ns | 0.0643 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 114.71 ns | 0.2710 ns | 0.2535 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  38.35 ns | 0.0755 ns | 0.0669 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  45.45 ns | 0.0230 ns | 0.0179 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  19.75 ns | 0.0303 ns | 0.0284 ns |      - |       0 B |
                                         From_Float |  29.04 ns | 0.1058 ns | 0.0989 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  27.80 ns | 0.0415 ns | 0.0389 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 103.33 ns | 0.0346 ns | 0.0289 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  27.81 ns | 0.0483 ns | 0.0451 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.62 ns | 0.0187 ns | 0.0174 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  15.22 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
                                        From_String | 139.39 ns | 0.2103 ns | 0.1967 ns |      - |       0 B |
                               From_String_AsObject | 153.14 ns | 0.3926 ns | 0.3481 ns |      - |       0 B |
                                   From_String_Null |  15.51 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.49 ns | 0.0060 ns | 0.0047 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  39.50 ns | 0.0781 ns | 0.0692 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  38.73 ns | 0.1115 ns | 0.1043 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 114.03 ns | 0.2069 ns | 0.1935 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  38.42 ns | 0.1880 ns | 0.1759 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.97 ns | 0.0713 ns | 0.0667 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.87 ns | 0.0403 ns | 0.0377 ns |      - |       0 B |
                                          From_UInt |  39.80 ns | 0.0767 ns | 0.0717 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  38.53 ns | 0.0199 ns | 0.0155 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 113.97 ns | 0.1391 ns | 0.1301 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  38.53 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.42 ns | 0.0807 ns | 0.0754 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.24 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
                                         From_ULong |  41.02 ns | 0.0354 ns | 0.0332 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  39.07 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 115.87 ns | 0.1857 ns | 0.1737 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  39.11 ns | 0.0671 ns | 0.0560 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  42.12 ns | 0.0220 ns | 0.0172 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.22 ns | 0.0080 ns | 0.0062 ns |      - |       0 B |
                                    From_NullObject |  16.13 ns | 0.0341 ns | 0.0319 ns |      - |       0 B |
                                        From_DBNull |  15.49 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                              From_ConvertibleClass |  36.42 ns | 0.0969 ns | 0.0906 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  36.37 ns | 0.0299 ns | 0.0250 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.62 ns | 0.0117 ns | 0.0103 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.20 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
                             From_ConvertibleStruct |  40.71 ns | 0.0547 ns | 0.0457 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  37.85 ns | 0.1647 ns | 0.1460 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 120.18 ns | 0.1156 ns | 0.1081 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  37.71 ns | 0.0159 ns | 0.0133 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.94 ns | 0.0570 ns | 0.0533 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.49 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                                          From_Enum | 102.42 ns | 0.1013 ns | 0.0846 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  97.24 ns | 0.0398 ns | 0.0333 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 202.32 ns | 0.4003 ns | 0.3744 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  96.43 ns | 0.2079 ns | 0.1945 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.58 ns | 0.0160 ns | 0.0125 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  19.75 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_FloatNullable.From_Char: DefaultJob
  ConvertTo_FloatNullable.From_Char_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_FloatNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_FloatNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_FloatNullable.From_String_Empty: DefaultJob
  ConvertTo_FloatNullable.From_String_Empty_AsObject: DefaultJob
