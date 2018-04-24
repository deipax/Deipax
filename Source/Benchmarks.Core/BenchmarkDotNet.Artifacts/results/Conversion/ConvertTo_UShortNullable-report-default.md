
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  40.65 ns | 0.0114 ns | 0.0095 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  38.51 ns | 0.0401 ns | 0.0334 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 117.15 ns | 0.0759 ns | 0.0710 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.50 ns | 0.0334 ns | 0.0313 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.75 ns | 0.0386 ns | 0.0342 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.22 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                          From_Byte |  40.25 ns | 0.0185 ns | 0.0164 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  39.32 ns | 0.0290 ns | 0.0257 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 115.68 ns | 0.1580 ns | 0.1478 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  38.51 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  43.52 ns | 0.0307 ns | 0.0287 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.10 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
                                          From_Char |  40.38 ns | 0.0338 ns | 0.0316 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  39.28 ns | 0.0072 ns | 0.0056 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 117.05 ns | 0.0291 ns | 0.0258 ns | 0.0055 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  39.28 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  44.78 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.01 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  46.63 ns | 0.0186 ns | 0.0155 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.23 ns | 0.0145 ns | 0.0128 ns |      - |       0 B |
                                       From_Decimal |  54.34 ns | 0.0091 ns | 0.0076 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  51.44 ns | 0.0795 ns | 0.0705 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 131.15 ns | 0.0253 ns | 0.0197 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  51.39 ns | 0.0236 ns | 0.0209 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.56 ns | 0.0634 ns | 0.0593 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.92 ns | 0.0255 ns | 0.0226 ns |      - |       0 B |
                                        From_Double |  45.21 ns | 0.0085 ns | 0.0071 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  42.98 ns | 0.0377 ns | 0.0334 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 125.15 ns | 0.0705 ns | 0.0660 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  42.83 ns | 0.0261 ns | 0.0232 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  44.41 ns | 0.0304 ns | 0.0284 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.01 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                                         From_Short |  44.36 ns | 0.0105 ns | 0.0082 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  39.02 ns | 0.0239 ns | 0.0199 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 114.68 ns | 0.0685 ns | 0.0640 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  39.01 ns | 0.0057 ns | 0.0045 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.28 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.84 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
                                           From_Int |  42.26 ns | 0.0226 ns | 0.0212 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  40.19 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 115.80 ns | 0.0237 ns | 0.0198 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  40.40 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  42.72 ns | 0.0335 ns | 0.0297 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.22 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                                          From_Long |  41.46 ns | 0.0065 ns | 0.0054 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  39.86 ns | 0.0324 ns | 0.0287 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 118.04 ns | 0.0920 ns | 0.0861 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  39.81 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  43.19 ns | 0.0345 ns | 0.0288 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.22 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                         From_SByte |  40.12 ns | 0.0266 ns | 0.0249 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  39.03 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 115.60 ns | 0.0480 ns | 0.0426 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  39.01 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.47 ns | 0.0805 ns | 0.0753 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.99 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                         From_Float |  45.57 ns | 0.0202 ns | 0.0189 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  43.24 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 121.06 ns | 0.0188 ns | 0.0157 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  43.23 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  42.05 ns | 0.0510 ns | 0.0477 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.97 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                        From_String | 116.30 ns | 0.1010 ns | 0.0945 ns |      - |       0 B |
                               From_String_AsObject | 116.23 ns | 0.0543 ns | 0.0481 ns |      - |       0 B |
                                   From_String_Null |  15.56 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
                          From_String_Null_AsObject |  19.64 ns | 0.0344 ns | 0.0269 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  28.70 ns | 0.0246 ns | 0.0230 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  27.44 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 101.36 ns | 0.0193 ns | 0.0161 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  27.44 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.31 ns | 0.0419 ns | 0.0371 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.57 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                          From_UInt |  40.12 ns | 0.0319 ns | 0.0283 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  39.03 ns | 0.0584 ns | 0.0547 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 116.81 ns | 0.0182 ns | 0.0142 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  39.01 ns | 0.0260 ns | 0.0231 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.68 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.00 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                         From_ULong |  41.20 ns | 0.0261 ns | 0.0232 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  39.82 ns | 0.0189 ns | 0.0176 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 117.95 ns | 0.0944 ns | 0.0837 ns | 0.0055 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  39.82 ns | 0.0157 ns | 0.0140 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.90 ns | 0.0525 ns | 0.0465 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.74 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
                                    From_NullObject |  15.03 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
                                        From_DBNull |  16.11 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
                              From_ConvertibleClass |  36.59 ns | 0.0141 ns | 0.0118 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  36.58 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.23 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.22 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                             From_ConvertibleStruct |  40.91 ns | 0.0202 ns | 0.0179 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  37.94 ns | 0.0241 ns | 0.0188 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 120.67 ns | 0.0750 ns | 0.0665 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  38.10 ns | 0.0984 ns | 0.0921 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.07 ns | 0.0235 ns | 0.0208 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.24 ns | 0.0064 ns | 0.0056 ns |      - |       0 B |
                                          From_Enum | 100.38 ns | 0.0187 ns | 0.0146 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  96.98 ns | 0.0124 ns | 0.0110 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 206.43 ns | 0.1217 ns | 0.1139 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  94.11 ns | 0.0419 ns | 0.0392 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.21 ns | 0.0416 ns | 0.0389 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.00 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_UShortNullable.From_DateTime: DefaultJob
  ConvertTo_UShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_UShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_UShortNullable.From_String_Empty: DefaultJob
  ConvertTo_UShortNullable.From_String_Empty_AsObject: DefaultJob
