
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  31.48 ns | 0.3486 ns | 0.2911 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.42 ns | 0.0740 ns | 0.0692 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 104.96 ns | 0.1668 ns | 0.1560 ns | 0.0055 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.38 ns | 0.0345 ns | 0.0270 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.13 ns | 0.0805 ns | 0.0753 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.52 ns | 0.0139 ns | 0.0100 ns |      - |       0 B |
                                          From_Byte |  30.99 ns | 0.0365 ns | 0.0342 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.50 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 104.21 ns | 0.1955 ns | 0.1829 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.58 ns | 0.0419 ns | 0.0372 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.70 ns | 0.0328 ns | 0.0274 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.73 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  41.18 ns | 0.0964 ns | 0.0902 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.78 ns | 0.0194 ns | 0.0181 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  40.94 ns | 0.0138 ns | 0.0116 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.44 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                                       From_Decimal |  39.77 ns | 0.0749 ns | 0.0664 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  37.19 ns | 0.0191 ns | 0.0170 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 117.66 ns | 0.0998 ns | 0.0885 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  50.35 ns | 0.0166 ns | 0.0130 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.06 ns | 0.0864 ns | 0.0766 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.97 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                                        From_Double |  30.97 ns | 0.0168 ns | 0.0140 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  29.38 ns | 0.0966 ns | 0.0904 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 105.98 ns | 0.1783 ns | 0.1667 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  29.41 ns | 0.0376 ns | 0.0314 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.28 ns | 0.0762 ns | 0.0675 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.41 ns | 0.0533 ns | 0.0445 ns |      - |       0 B |
                                         From_Short |  31.38 ns | 0.1336 ns | 0.1250 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  29.71 ns | 0.1051 ns | 0.0984 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 103.74 ns | 0.1768 ns | 0.1568 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  29.65 ns | 0.0161 ns | 0.0134 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  41.10 ns | 0.0470 ns | 0.0416 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.70 ns | 0.0098 ns | 0.0076 ns |      - |       0 B |
                                           From_Int |  30.99 ns | 0.0209 ns | 0.0174 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  29.49 ns | 0.1097 ns | 0.0973 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 103.79 ns | 0.2390 ns | 0.2236 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  29.40 ns | 0.0660 ns | 0.0617 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.19 ns | 0.0730 ns | 0.0683 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.43 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
                                          From_Long |  31.28 ns | 0.0200 ns | 0.0167 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  29.64 ns | 0.0350 ns | 0.0310 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 106.48 ns | 0.0892 ns | 0.0834 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  29.71 ns | 0.1236 ns | 0.1156 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  40.91 ns | 0.0254 ns | 0.0212 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.45 ns | 0.0443 ns | 0.0370 ns |      - |       0 B |
                                         From_SByte |  31.10 ns | 0.0228 ns | 0.0202 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  29.37 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 104.53 ns | 0.0603 ns | 0.0503 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.39 ns | 0.0322 ns | 0.0285 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.27 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.70 ns | 0.0088 ns | 0.0073 ns |      - |       0 B |
                                         From_Float |  17.32 ns | 0.0042 ns | 0.0039 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  15.61 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  90.48 ns | 0.0395 ns | 0.0330 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  15.64 ns | 0.0331 ns | 0.0310 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  42.58 ns | 0.0227 ns | 0.0190 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.71 ns | 0.0251 ns | 0.0235 ns |      - |       0 B |
                                        From_String | 128.79 ns | 0.2399 ns | 0.2004 ns |      - |       0 B |
                               From_String_AsObject | 128.78 ns | 0.1190 ns | 0.1055 ns |      - |       0 B |
                                   From_String_Null |  14.45 ns | 0.0260 ns | 0.0244 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.43 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  31.04 ns | 0.0349 ns | 0.0291 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  29.40 ns | 0.0398 ns | 0.0352 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 104.17 ns | 0.2665 ns | 0.2493 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  29.43 ns | 0.0929 ns | 0.0869 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.74 ns | 0.0569 ns | 0.0475 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.44 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                                          From_UInt |  31.63 ns | 0.0216 ns | 0.0180 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.64 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 104.44 ns | 0.0570 ns | 0.0505 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.86 ns | 0.0622 ns | 0.0582 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.93 ns | 0.0451 ns | 0.0421 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.02 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                         From_ULong |  31.89 ns | 0.0403 ns | 0.0357 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.40 ns | 0.0384 ns | 0.0341 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 105.64 ns | 0.1026 ns | 0.0959 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.24 ns | 0.0180 ns | 0.0150 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.02 ns | 0.0355 ns | 0.0296 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.41 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
                                    From_NullObject |  14.71 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
                                        From_DBNull |  15.07 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
                              From_ConvertibleClass |  27.47 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.52 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.45 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  14.51 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                             From_ConvertibleStruct |  30.97 ns | 0.0184 ns | 0.0154 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.87 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 111.14 ns | 0.0578 ns | 0.0483 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.01 ns | 0.0986 ns | 0.0874 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.18 ns | 0.0761 ns | 0.0712 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.47 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                                          From_Enum |  92.42 ns | 0.1188 ns | 0.1053 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  86.99 ns | 0.1565 ns | 0.1387 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 192.53 ns | 0.1095 ns | 0.0971 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  85.28 ns | 0.0490 ns | 0.0382 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.88 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.73 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Float.From_Char: DefaultJob
  ConvertTo_Float.From_Char_AsObject: DefaultJob
  ConvertTo_Float.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_Float.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime: DefaultJob
  ConvertTo_Float.From_DateTime_AsObject: DefaultJob
  ConvertTo_Float.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Float.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Float.From_String_Empty: DefaultJob
  ConvertTo_Float.From_String_Empty_AsObject: DefaultJob
