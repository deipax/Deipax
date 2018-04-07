
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  40.43 ns | 0.0448 ns | 0.0374 ns |  40.42 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  38.29 ns | 0.0847 ns | 0.0750 ns |  38.29 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 114.31 ns | 0.0168 ns | 0.0157 ns | 114.30 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  38.24 ns | 0.0470 ns | 0.0440 ns |  38.21 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.61 ns | 0.0132 ns | 0.0117 ns |  41.60 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.48 ns | 0.0116 ns | 0.0108 ns |  15.48 ns |      - |       0 B |
                                          From_Byte |  39.28 ns | 0.0263 ns | 0.0246 ns |  39.27 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  38.26 ns | 0.0416 ns | 0.0369 ns |  38.27 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 113.39 ns | 0.0437 ns | 0.0409 ns | 113.37 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  38.22 ns | 0.0314 ns | 0.0293 ns |  38.21 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  44.94 ns | 0.0237 ns | 0.0222 ns |  44.94 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  15.81 ns | 0.0115 ns | 0.0108 ns |  15.81 ns |      - |       0 B |
                                          From_Char |  41.12 ns | 0.0065 ns | 0.0060 ns |  41.13 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  39.04 ns | 0.0316 ns | 0.0296 ns |  39.04 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 114.19 ns | 0.0084 ns | 0.0066 ns | 114.19 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  39.03 ns | 0.0257 ns | 0.0228 ns |  39.02 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  42.11 ns | 0.0162 ns | 0.0152 ns |  42.10 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  15.40 ns | 0.0289 ns | 0.0256 ns |  15.40 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.82 ns | 0.0275 ns | 0.0257 ns |  41.81 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  15.57 ns | 0.0094 ns | 0.0088 ns |  15.57 ns |      - |       0 B |
                                       From_Decimal |  51.50 ns | 0.1236 ns | 0.1095 ns |  51.51 ns | 0.0075 |      32 B |
                              From_Decimal_AsObject |  48.40 ns | 0.1075 ns | 0.0898 ns |  48.37 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 131.66 ns | 0.0255 ns | 0.0238 ns | 131.66 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  49.34 ns | 0.0668 ns | 0.0625 ns |  49.30 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  42.79 ns | 0.0983 ns | 0.0920 ns |  42.78 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.49 ns | 0.0185 ns | 0.0173 ns |  15.49 ns |      - |       0 B |
                                        From_Double |  41.69 ns | 0.0174 ns | 0.0155 ns |  41.68 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  40.34 ns | 0.0105 ns | 0.0082 ns |  40.34 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 118.88 ns | 0.0256 ns | 0.0214 ns | 118.87 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  40.35 ns | 0.0342 ns | 0.0304 ns |  40.35 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.56 ns | 0.0204 ns | 0.0171 ns |  41.56 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.30 ns | 0.0141 ns | 0.0132 ns |  15.29 ns |      - |       0 B |
                                         From_Short |  40.31 ns | 0.0045 ns | 0.0038 ns |  40.31 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  38.27 ns | 0.0117 ns | 0.0104 ns |  38.27 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 114.55 ns | 0.1138 ns | 0.1065 ns | 114.56 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  38.29 ns | 0.0546 ns | 0.0511 ns |  38.29 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  43.76 ns | 0.0048 ns | 0.0043 ns |  43.76 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  15.22 ns | 0.0117 ns | 0.0109 ns |  15.22 ns |      - |       0 B |
                                           From_Int |  28.56 ns | 0.0041 ns | 0.0035 ns |  28.56 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  27.44 ns | 0.0127 ns | 0.0106 ns |  27.44 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 102.88 ns | 0.0437 ns | 0.0408 ns | 102.86 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  27.48 ns | 0.0043 ns | 0.0031 ns |  27.48 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  43.14 ns | 0.0300 ns | 0.0281 ns |  43.14 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.74 ns | 0.0173 ns | 0.0153 ns |  15.73 ns |      - |       0 B |
                                          From_Long |  40.85 ns | 0.0085 ns | 0.0071 ns |  40.85 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  39.56 ns | 0.0208 ns | 0.0185 ns |  39.55 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 116.23 ns | 0.0099 ns | 0.0077 ns | 116.24 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  39.59 ns | 0.0141 ns | 0.0110 ns |  39.59 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  42.41 ns | 0.0374 ns | 0.0332 ns |  42.40 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.48 ns | 0.0126 ns | 0.0118 ns |  15.48 ns |      - |       0 B |
                                         From_SByte |  39.31 ns | 0.0507 ns | 0.0474 ns |  39.28 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  38.29 ns | 0.0456 ns | 0.0404 ns |  38.28 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 114.15 ns | 0.0402 ns | 0.0335 ns | 114.14 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  38.22 ns | 0.0270 ns | 0.0240 ns |  38.21 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  43.23 ns | 0.0578 ns | 0.0541 ns |  43.25 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  15.22 ns | 0.0050 ns | 0.0039 ns |  15.22 ns |      - |       0 B |
                                         From_Float |  42.96 ns | 0.0123 ns | 0.0102 ns |  42.96 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  40.64 ns | 0.0289 ns | 0.0256 ns |  40.64 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 118.32 ns | 0.0848 ns | 0.0793 ns | 118.29 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  40.61 ns | 0.0105 ns | 0.0093 ns |  40.61 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.63 ns | 0.0366 ns | 0.0343 ns |  41.62 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  15.20 ns | 0.0096 ns | 0.0085 ns |  15.20 ns |      - |       0 B |
                                        From_String | 116.33 ns | 0.0364 ns | 0.0322 ns | 116.32 ns |      - |       0 B |
                               From_String_AsObject | 116.16 ns | 0.0652 ns | 0.0610 ns | 116.15 ns |      - |       0 B |
                                   From_String_Null |  15.84 ns | 0.0135 ns | 0.0126 ns |  15.84 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.97 ns | 0.0106 ns | 0.0099 ns |  15.97 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  39.27 ns | 0.0301 ns | 0.0267 ns |  39.26 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  38.21 ns | 0.0241 ns | 0.0226 ns |  38.20 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 113.45 ns | 0.0897 ns | 0.0839 ns | 113.42 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  38.21 ns | 0.0136 ns | 0.0114 ns |  38.20 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.82 ns | 0.0863 ns | 0.0807 ns |  42.81 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.47 ns | 0.0028 ns | 0.0023 ns |  15.47 ns |      - |       0 B |
                                          From_UInt |  39.82 ns | 0.0241 ns | 0.0226 ns |  39.81 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  38.73 ns | 0.0020 ns | 0.0017 ns |  38.73 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 113.70 ns | 0.0233 ns | 0.0206 ns | 113.69 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  38.73 ns | 0.0047 ns | 0.0037 ns |  38.73 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.57 ns | 0.0066 ns | 0.0055 ns |  41.57 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.84 ns | 0.0105 ns | 0.0093 ns |  15.84 ns |      - |       0 B |
                                         From_ULong |  40.88 ns | 0.0097 ns | 0.0081 ns |  40.87 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  39.60 ns | 0.0195 ns | 0.0182 ns |  39.59 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 118.06 ns | 0.0252 ns | 0.0236 ns | 118.05 ns | 0.0055 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  39.56 ns | 0.0257 ns | 0.0215 ns |  39.56 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  43.52 ns | 0.0161 ns | 0.0143 ns |  43.52 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.22 ns | 0.0105 ns | 0.0093 ns |  15.22 ns |      - |       0 B |
                                    From_NullObject |  15.90 ns | 0.0089 ns | 0.0084 ns |  15.90 ns |      - |       0 B |
                                        From_DBNull |  15.49 ns | 0.0328 ns | 0.0307 ns |  15.48 ns |      - |       0 B |
                              From_ConvertibleClass |  36.32 ns | 0.0070 ns | 0.0055 ns |  36.31 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  38.37 ns | 0.0101 ns | 0.0089 ns |  38.37 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.78 ns | 0.0020 ns | 0.0017 ns |  15.78 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.48 ns | 0.0214 ns | 0.0178 ns |  15.47 ns |      - |       0 B |
                             From_ConvertibleStruct |  39.30 ns | 0.0118 ns | 0.0104 ns |  39.30 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  37.71 ns | 0.0726 ns | 0.0679 ns |  37.66 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 119.64 ns | 0.0934 ns | 0.0874 ns | 119.61 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  37.67 ns | 0.0268 ns | 0.0209 ns |  37.66 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.62 ns | 0.0488 ns | 0.0456 ns |  42.61 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.47 ns | 0.0011 ns | 0.0009 ns |  15.47 ns |      - |       0 B |
                                          From_Enum |  96.72 ns | 0.0491 ns | 0.0460 ns |  96.69 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  93.12 ns | 0.0094 ns | 0.0078 ns |  93.12 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 204.58 ns | 0.1923 ns | 0.1799 ns | 204.50 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  93.23 ns | 0.0141 ns | 0.0118 ns |  93.23 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  42.65 ns | 0.0605 ns | 0.0565 ns |  42.65 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.20 ns | 0.0015 ns | 0.0013 ns |  15.20 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_IntNullable.From_DateTime: DefaultJob
  ConvertTo_IntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_IntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_IntNullable.From_String_Empty: DefaultJob
  ConvertTo_IntNullable.From_String_Empty_AsObject: DefaultJob
