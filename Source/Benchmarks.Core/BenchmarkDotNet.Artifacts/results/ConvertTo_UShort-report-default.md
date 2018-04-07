
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  30.93 ns | 0.0155 ns | 0.0130 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.34 ns | 0.0259 ns | 0.0230 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 103.34 ns | 0.1466 ns | 0.1299 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.33 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.07 ns | 0.1434 ns | 0.1341 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.42 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
                                          From_Byte |  30.91 ns | 0.0073 ns | 0.0064 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.32 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 105.04 ns | 0.0230 ns | 0.0192 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.32 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.07 ns | 0.0350 ns | 0.0328 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.68 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                          From_Char |  31.76 ns | 0.0081 ns | 0.0075 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.09 ns | 0.0302 ns | 0.0268 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.72 ns | 0.0145 ns | 0.0121 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.14 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.05 ns | 0.1369 ns | 0.1280 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.69 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.47 ns | 0.0593 ns | 0.0495 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.42 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                       From_Decimal |  43.71 ns | 0.0046 ns | 0.0041 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  40.94 ns | 0.0736 ns | 0.0653 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 122.88 ns | 0.1430 ns | 0.1194 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  40.92 ns | 0.0483 ns | 0.0428 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  42.90 ns | 0.0296 ns | 0.0277 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.43 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
                                        From_Double |  35.15 ns | 0.0126 ns | 0.0105 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  33.66 ns | 0.0679 ns | 0.0635 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 110.95 ns | 0.0580 ns | 0.0452 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  33.93 ns | 0.0455 ns | 0.0380 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.59 ns | 0.0688 ns | 0.0610 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.69 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                         From_Short |  31.46 ns | 0.0154 ns | 0.0136 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  29.86 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 103.80 ns | 0.0629 ns | 0.0588 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  29.86 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  43.42 ns | 0.0943 ns | 0.0882 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.68 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                           From_Int |  32.51 ns | 0.0067 ns | 0.0056 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  30.94 ns | 0.0128 ns | 0.0107 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 105.36 ns | 0.0755 ns | 0.0669 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  30.88 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.11 ns | 0.0907 ns | 0.0849 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.41 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                          From_Long |  32.26 ns | 0.0200 ns | 0.0177 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  30.66 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 107.22 ns | 0.0621 ns | 0.0581 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  30.67 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  42.97 ns | 0.0708 ns | 0.0662 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.41 ns | 0.0038 ns | 0.0031 ns |      - |       0 B |
                                         From_SByte |  31.44 ns | 0.0170 ns | 0.0151 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  29.86 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 104.74 ns | 0.0099 ns | 0.0083 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.86 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  41.52 ns | 0.0452 ns | 0.0401 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.68 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
                                         From_Float |  35.48 ns | 0.0184 ns | 0.0172 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  33.87 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 110.45 ns | 0.0817 ns | 0.0764 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  33.90 ns | 0.0268 ns | 0.0238 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  43.11 ns | 0.0913 ns | 0.0854 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.68 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
                                        From_String | 105.75 ns | 0.0675 ns | 0.0598 ns |      - |       0 B |
                               From_String_AsObject | 123.81 ns | 0.0964 ns | 0.0902 ns |      - |       0 B |
                                   From_String_Null |  14.44 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.41 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  17.46 ns | 0.0246 ns | 0.0230 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  15.75 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  88.63 ns | 0.0829 ns | 0.0775 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  15.76 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  41.94 ns | 0.0362 ns | 0.0339 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.60 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                                          From_UInt |  31.45 ns | 0.0303 ns | 0.0283 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  29.86 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 105.97 ns | 0.0138 ns | 0.0108 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  29.89 ns | 0.0348 ns | 0.0326 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.13 ns | 0.0363 ns | 0.0340 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.70 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                                         From_ULong |  32.27 ns | 0.0285 ns | 0.0266 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.75 ns | 0.0779 ns | 0.0728 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 107.16 ns | 0.0653 ns | 0.0611 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.71 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.49 ns | 0.0489 ns | 0.0457 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.69 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                    From_NullObject |  14.68 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                                        From_DBNull |  16.04 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                              From_ConvertibleClass |  27.44 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.46 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  14.41 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  14.43 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                             From_ConvertibleStruct |  30.90 ns | 0.0054 ns | 0.0047 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  28.82 ns | 0.0369 ns | 0.0345 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 110.08 ns | 0.0334 ns | 0.0312 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  28.82 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.28 ns | 0.0275 ns | 0.0258 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.42 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
                                          From_Enum |  87.58 ns | 0.1371 ns | 0.1283 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  85.11 ns | 0.0515 ns | 0.0482 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 194.57 ns | 0.3019 ns | 0.2824 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  84.16 ns | 0.0361 ns | 0.0320 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.60 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.68 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_UShort.From_DateTime: DefaultJob
  ConvertTo_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShort.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShort.From_String_Empty: DefaultJob
  ConvertTo_UShort.From_String_Empty_AsObject: DefaultJob
