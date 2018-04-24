
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  41.05 ns | 0.5948 ns | 0.5273 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject |  37.95 ns | 0.1822 ns | 0.1521 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 112.22 ns | 0.1931 ns | 0.1806 ns | 0.0056 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject |  37.90 ns | 0.0443 ns | 0.0370 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  41.07 ns | 0.0286 ns | 0.0254 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  15.30 ns | 0.0847 ns | 0.0792 ns |      - |       0 B |
                                             From_Byte |  40.36 ns | 0.1086 ns | 0.0963 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject |  37.99 ns | 0.0719 ns | 0.0637 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 112.01 ns | 0.2074 ns | 0.1940 ns | 0.0056 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject |  38.15 ns | 0.5850 ns | 0.5186 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  41.38 ns | 0.0126 ns | 0.0099 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  15.52 ns | 0.0367 ns | 0.0325 ns |      - |       0 B |
                                             From_Char |  41.96 ns | 0.0490 ns | 0.0434 ns | 0.0057 |      24 B |
                                    From_Char_AsObject |  38.65 ns | 0.0506 ns | 0.0423 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 112.07 ns | 0.2044 ns | 0.1812 ns | 0.0056 |      24 B |
                 From_Char_Nullable_WithValue_AsObject |  39.11 ns | 0.6846 ns | 0.6404 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  41.22 ns | 0.0284 ns | 0.0252 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  15.63 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  41.43 ns | 0.0530 ns | 0.0470 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  15.25 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
                                          From_Decimal |  52.39 ns | 0.0440 ns | 0.0390 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject |  47.25 ns | 0.0755 ns | 0.0630 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 127.40 ns | 0.0859 ns | 0.0804 ns | 0.0074 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject |  47.21 ns | 0.0920 ns | 0.0815 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  41.52 ns | 0.1016 ns | 0.0950 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  15.27 ns | 0.0259 ns | 0.0216 ns |      - |       0 B |
                                           From_Double |  46.78 ns | 0.0333 ns | 0.0295 ns | 0.0057 |      24 B |
                                  From_Double_AsObject |  44.61 ns | 0.6767 ns | 0.5999 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 122.92 ns | 0.0634 ns | 0.0530 ns | 0.0055 |      24 B |
               From_Double_Nullable_WithValue_AsObject |  44.38 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  41.88 ns | 0.0404 ns | 0.0337 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  15.52 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
                                            From_Short |  41.20 ns | 0.0354 ns | 0.0314 ns | 0.0057 |      24 B |
                                   From_Short_AsObject |  38.72 ns | 0.6877 ns | 0.6433 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 110.03 ns | 0.1140 ns | 0.1066 ns | 0.0056 |      24 B |
                From_Short_Nullable_WithValue_AsObject |  37.97 ns | 0.0670 ns | 0.0627 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  41.54 ns | 0.0430 ns | 0.0381 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  15.53 ns | 0.0596 ns | 0.0557 ns |      - |       0 B |
                                              From_Int |  39.64 ns | 0.0126 ns | 0.0105 ns | 0.0057 |      24 B |
                                     From_Int_AsObject |  37.89 ns | 0.0485 ns | 0.0430 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 111.86 ns | 0.0829 ns | 0.0692 ns | 0.0056 |      24 B |
                  From_Int_Nullable_WithValue_AsObject |  38.78 ns | 0.7280 ns | 0.6809 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  40.20 ns | 0.0193 ns | 0.0161 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  15.42 ns | 0.0703 ns | 0.0658 ns |      - |       0 B |
                                             From_Long |  31.40 ns | 0.0641 ns | 0.0600 ns | 0.0057 |      24 B |
                                    From_Long_AsObject |  27.12 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  98.05 ns | 0.0462 ns | 0.0410 ns | 0.0056 |      24 B |
                 From_Long_Nullable_WithValue_AsObject |  27.14 ns | 0.0369 ns | 0.0346 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  41.12 ns | 0.0643 ns | 0.0601 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  15.23 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                                            From_SByte |  40.39 ns | 0.0366 ns | 0.0324 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject |  37.87 ns | 0.0136 ns | 0.0114 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 112.78 ns | 0.1849 ns | 0.1730 ns | 0.0056 |      24 B |
                From_SByte_Nullable_WithValue_AsObject |  37.90 ns | 0.0949 ns | 0.0841 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  41.60 ns | 0.0344 ns | 0.0287 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  15.50 ns | 0.0089 ns | 0.0084 ns |      - |       0 B |
                                            From_Float |  45.56 ns | 0.1086 ns | 0.1016 ns | 0.0057 |      24 B |
                                   From_Float_AsObject |  42.92 ns | 0.0322 ns | 0.0301 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 117.77 ns | 0.2174 ns | 0.1928 ns | 0.0055 |      24 B |
                From_Float_Nullable_WithValue_AsObject |  42.90 ns | 0.0194 ns | 0.0162 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  39.90 ns | 0.0817 ns | 0.0764 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  15.48 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
                                           From_String | 112.77 ns | 0.1188 ns | 0.1111 ns |      - |       0 B |
                                  From_String_AsObject | 113.79 ns | 0.1513 ns | 0.1181 ns |      - |       0 B |
                                      From_String_Null |  15.23 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                             From_String_Null_AsObject |  15.28 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                                     From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  40.40 ns | 0.0827 ns | 0.0733 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject |  37.97 ns | 0.0866 ns | 0.0768 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 111.33 ns | 0.0844 ns | 0.0704 ns | 0.0056 |      24 B |
               From_UShort_Nullable_WithValue_AsObject |  39.05 ns | 0.1667 ns | 0.1478 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  41.65 ns | 0.0730 ns | 0.0683 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  15.23 ns | 0.0101 ns | 0.0084 ns |      - |       0 B |
                                             From_UInt |  39.72 ns | 0.0740 ns | 0.0693 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject |  37.83 ns | 0.0237 ns | 0.0198 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 110.61 ns | 0.0657 ns | 0.0513 ns | 0.0056 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject |  37.84 ns | 0.0232 ns | 0.0194 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  40.16 ns | 0.1077 ns | 0.1008 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  21.68 ns | 0.0122 ns | 0.0108 ns |      - |       0 B |
                                            From_ULong |  40.44 ns | 0.0669 ns | 0.0626 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject |  38.61 ns | 0.0274 ns | 0.0214 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 113.54 ns | 0.5057 ns | 0.4730 ns | 0.0056 |      24 B |
                From_ULong_Nullable_WithValue_AsObject |  38.66 ns | 0.0835 ns | 0.0740 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  41.58 ns | 0.0585 ns | 0.0547 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  15.51 ns | 0.0321 ns | 0.0301 ns |      - |       0 B |
                                       From_NullObject |  15.52 ns | 0.0287 ns | 0.0239 ns |      - |       0 B |
                                           From_DBNull |  15.89 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
                                 From_ConvertibleClass |  36.50 ns | 0.0515 ns | 0.0456 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  36.09 ns | 0.0679 ns | 0.0602 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  15.27 ns | 0.0284 ns | 0.0265 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  15.24 ns | 0.0345 ns | 0.0288 ns |      - |       0 B |
                              From_NonConvertibleClass |        NA |        NA |        NA |    N/A |       N/A |
                     From_NonConvertibleClass_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_NonConvertibleClass_NoValue |  15.52 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  15.51 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
                                From_ConvertibleStruct |  41.03 ns | 0.0474 ns | 0.0396 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  37.36 ns | 0.0603 ns | 0.0535 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 116.30 ns | 0.1890 ns | 0.1578 ns | 0.0056 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  37.43 ns | 0.0929 ns | 0.0824 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  42.34 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.51 ns | 0.0304 ns | 0.0285 ns |      - |       0 B |
                             From_NonConvertibleStruct |        NA |        NA |        NA |    N/A |       N/A |
                    From_NonConvertibleStruct_AsObject |        NA |        NA |        NA |    N/A |       N/A |
          From_NonConvertibleStruct_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
            From_NonConvertibleStruct_Nullable_NoValue |  41.53 ns | 0.0529 ns | 0.0469 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  15.24 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                                             From_Enum |  98.78 ns | 0.1429 ns | 0.1337 ns | 0.0113 |      48 B |
                                    From_Enum_AsObject |  90.81 ns | 0.0757 ns | 0.0672 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 195.66 ns | 0.0819 ns | 0.0684 ns | 0.0112 |      48 B |
                 From_Enum_Nullable_WithValue_AsObject |  92.33 ns | 0.1696 ns | 0.1586 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  40.23 ns | 0.0491 ns | 0.0459 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  15.25 ns | 0.0263 ns | 0.0246 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_LongNullable.From_DateTime: DefaultJob
  ConvertTo_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_LongNullable.From_String_Empty: DefaultJob
  ConvertTo_LongNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleClass: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleClass_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_AsObject: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_Nullable_WithValue: DefaultJob
  ConvertTo_LongNullable.From_NonConvertibleStruct_Nullable_WithValue_AsObject: DefaultJob
