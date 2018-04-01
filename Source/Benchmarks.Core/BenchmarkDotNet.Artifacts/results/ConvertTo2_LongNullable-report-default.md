
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.76 ns | 0.0997 ns | 0.0932 ns |  14.73 ns |      - |       0 B |
                                    From_Bool_AsObject |  31.96 ns | 0.0639 ns | 0.0567 ns |  31.94 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  19.67 ns | 0.0411 ns | 0.0384 ns |  19.66 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  32.05 ns | 0.2104 ns | 0.1969 ns |  32.12 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  15.94 ns | 0.0457 ns | 0.0427 ns |  15.92 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.55 ns | 0.0171 ns | 0.0133 ns |  18.55 ns |      - |       0 B |
                                             From_Byte |  14.40 ns | 0.0091 ns | 0.0081 ns |  14.40 ns |      - |       0 B |
                                    From_Byte_AsObject |  32.13 ns | 0.2069 ns | 0.1935 ns |  32.08 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  19.11 ns | 0.0090 ns | 0.0070 ns |  19.11 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  32.24 ns | 0.0886 ns | 0.0829 ns |  32.25 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.34 ns | 0.0054 ns | 0.0042 ns |  15.34 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.38 ns | 0.1487 ns | 0.1391 ns |  17.41 ns |      - |       0 B |
                                             From_Char |  14.00 ns | 0.0475 ns | 0.0371 ns |  13.99 ns |      - |       0 B |
                                    From_Char_AsObject |  33.20 ns | 0.6801 ns | 0.6362 ns |  32.79 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  19.20 ns | 0.0983 ns | 0.0768 ns |  19.18 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  32.75 ns | 0.1089 ns | 0.0966 ns |  32.78 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.17 ns | 0.0966 ns | 0.0807 ns |  15.20 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.55 ns | 0.0533 ns | 0.0473 ns |  18.53 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  15.98 ns | 0.1073 ns | 0.0951 ns |  15.96 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.40 ns | 0.1190 ns | 0.1055 ns |  17.38 ns |      - |       0 B |
                                          From_Decimal |  25.75 ns | 0.0355 ns | 0.0315 ns |  25.74 ns |      - |       0 B |
                                 From_Decimal_AsObject |  41.81 ns | 0.1139 ns | 0.1066 ns |  41.74 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  36.69 ns | 0.0861 ns | 0.0672 ns |  36.70 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  44.93 ns | 0.1912 ns | 0.1788 ns |  44.86 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.50 ns | 0.0564 ns | 0.0528 ns |  15.47 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  18.46 ns | 0.0178 ns | 0.0158 ns |  18.45 ns |      - |       0 B |
                                           From_Double |  18.35 ns | 0.0799 ns | 0.0624 ns |  18.32 ns |      - |       0 B |
                                  From_Double_AsObject |  37.38 ns | 0.0291 ns | 0.0243 ns |  37.37 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  24.37 ns | 0.0541 ns | 0.0452 ns |  24.36 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  36.42 ns | 0.0719 ns | 0.0601 ns |  36.38 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  15.89 ns | 0.0285 ns | 0.0238 ns |  15.89 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.38 ns | 0.1198 ns | 0.1120 ns |  17.32 ns |      - |       0 B |
                                            From_Short |  15.22 ns | 0.0281 ns | 0.0220 ns |  15.21 ns |      - |       0 B |
                                   From_Short_AsObject |  31.84 ns | 0.0882 ns | 0.0825 ns |  31.81 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  19.14 ns | 0.0334 ns | 0.0313 ns |  19.13 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  32.85 ns | 0.0913 ns | 0.0854 ns |  32.82 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  15.10 ns | 0.1002 ns | 0.0837 ns |  15.07 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.32 ns | 0.0221 ns | 0.0207 ns |  17.32 ns |      - |       0 B |
                                              From_Int |  14.45 ns | 0.0416 ns | 0.0390 ns |  14.43 ns |      - |       0 B |
                                     From_Int_AsObject |  32.89 ns | 0.0773 ns | 0.0723 ns |  32.88 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  19.12 ns | 0.0102 ns | 0.0080 ns |  19.11 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  31.77 ns | 0.0596 ns | 0.0528 ns |  31.75 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.91 ns | 0.0062 ns | 0.0058 ns |  14.91 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.52 ns | 0.0070 ns | 0.0059 ns |  17.52 ns |      - |       0 B |
                                             From_Long |  14.67 ns | 0.0095 ns | 0.0089 ns |  14.67 ns |      - |       0 B |
                                    From_Long_AsObject |  29.13 ns | 0.0402 ns | 0.0376 ns |  29.12 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  14.82 ns | 0.0245 ns | 0.0229 ns |  14.81 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  30.29 ns | 0.0184 ns | 0.0144 ns |  30.29 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.81 ns | 0.0165 ns | 0.0138 ns |  14.80 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  18.45 ns | 0.0107 ns | 0.0095 ns |  18.44 ns |      - |       0 B |
                                            From_SByte |  13.99 ns | 0.0205 ns | 0.0171 ns |  13.99 ns |      - |       0 B |
                                   From_SByte_AsObject |  31.98 ns | 0.0566 ns | 0.0530 ns |  31.96 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  19.12 ns | 0.0148 ns | 0.0131 ns |  19.12 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  32.22 ns | 0.0842 ns | 0.0788 ns |  32.20 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  15.36 ns | 0.0198 ns | 0.0176 ns |  15.35 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.33 ns | 0.0258 ns | 0.0241 ns |  17.32 ns |      - |       0 B |
                                            From_Float |  18.47 ns | 0.0417 ns | 0.0390 ns |  18.45 ns |      - |       0 B |
                                   From_Float_AsObject |  36.69 ns | 0.0592 ns | 0.0554 ns |  36.68 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.90 ns | 0.0090 ns | 0.0070 ns |  22.90 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  36.62 ns | 0.0345 ns | 0.0323 ns |  36.61 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.08 ns | 0.0269 ns | 0.0238 ns |  15.06 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.41 ns | 0.0129 ns | 0.0108 ns |  17.41 ns |      - |       0 B |
                                           From_String | 104.81 ns | 0.1377 ns | 0.1288 ns | 104.75 ns |      - |       0 B |
                                  From_String_AsObject | 110.01 ns | 0.0441 ns | 0.0391 ns | 110.01 ns |      - |       0 B |
                                      From_String_Null |  17.20 ns | 0.0589 ns | 0.0492 ns |  17.18 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.58 ns | 0.4054 ns | 0.3792 ns |  17.39 ns |      - |       0 B |
                                     From_String_Empty |  25.20 ns | 0.0374 ns | 0.0313 ns |  25.18 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.14 ns | 0.0063 ns | 0.0049 ns |  14.14 ns |      - |       0 B |
                                  From_UShort_AsObject |  31.96 ns | 0.0506 ns | 0.0423 ns |  31.96 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  19.14 ns | 0.0252 ns | 0.0223 ns |  19.14 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  31.97 ns | 0.0175 ns | 0.0146 ns |  31.96 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.92 ns | 0.0256 ns | 0.0239 ns |  14.91 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.38 ns | 0.0426 ns | 0.0399 ns |  17.39 ns |      - |       0 B |
                                             From_UInt |  16.03 ns | 0.0397 ns | 0.0352 ns |  16.01 ns |      - |       0 B |
                                    From_UInt_AsObject |  31.89 ns | 0.0901 ns | 0.0842 ns |  31.86 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  19.14 ns | 0.0230 ns | 0.0215 ns |  19.12 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  32.05 ns | 0.0712 ns | 0.0631 ns |  32.03 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.60 ns | 0.3418 ns | 0.6904 ns |  15.25 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.59 ns | 0.0732 ns | 0.0685 ns |  17.62 ns |      - |       0 B |
                                            From_ULong |  15.71 ns | 0.4417 ns | 0.4536 ns |  15.59 ns |      - |       0 B |
                                   From_ULong_AsObject |  32.35 ns | 0.0228 ns | 0.0178 ns |  32.36 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  21.20 ns | 0.1869 ns | 0.1748 ns |  21.10 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  32.52 ns | 0.1547 ns | 0.1447 ns |  32.46 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.96 ns | 0.0516 ns | 0.0431 ns |  15.96 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.91 ns | 0.3775 ns | 0.4909 ns |  17.81 ns |      - |       0 B |
                                       From_NullObject |  19.84 ns | 0.0357 ns | 0.0298 ns |  19.83 ns |      - |       0 B |
                                           From_DBNull |  17.31 ns | 0.0760 ns | 0.0673 ns |  17.28 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.14 ns | 0.1209 ns | 0.1072 ns |  28.12 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  30.35 ns | 0.0176 ns | 0.0147 ns |  30.35 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.46 ns | 0.0182 ns | 0.0162 ns |  18.47 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.43 ns | 0.0390 ns | 0.0364 ns |  17.42 ns |      - |       0 B |
                              From_NonConvertibleClass |  20.55 ns | 0.0128 ns | 0.0085 ns |  20.55 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.96 ns | 0.0440 ns | 0.0390 ns |  25.94 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.24 ns | 0.0353 ns | 0.0330 ns |  17.24 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.36 ns | 0.0431 ns | 0.0403 ns |  17.34 ns |      - |       0 B |
                                From_ConvertibleStruct |  24.49 ns | 0.1302 ns | 0.1218 ns |  24.55 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  31.22 ns | 0.0135 ns | 0.0113 ns |  31.21 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  28.63 ns | 0.0755 ns | 0.0707 ns |  28.65 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.80 ns | 0.0218 ns | 0.0193 ns |  30.81 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  15.44 ns | 0.0819 ns | 0.0766 ns |  15.48 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0330 ns | 0.0308 ns |  17.41 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.15 ns | 0.0130 ns | 0.0109 ns |  14.15 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  27.08 ns | 0.0239 ns | 0.0186 ns |  27.08 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  18.87 ns | 0.0228 ns | 0.0202 ns |  18.87 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  24.80 ns | 0.0515 ns | 0.0481 ns |  24.82 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  15.36 ns | 0.0202 ns | 0.0179 ns |  15.36 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.40 ns | 0.0748 ns | 0.0700 ns |  17.42 ns |      - |       0 B |
                                             From_Enum |  15.28 ns | 0.0256 ns | 0.0227 ns |  15.27 ns |      - |       0 B |
                                    From_Enum_AsObject |  64.59 ns | 0.2058 ns | 0.1824 ns |  64.62 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  19.09 ns | 0.0186 ns | 0.0174 ns |  19.08 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  64.42 ns | 0.0425 ns | 0.0355 ns |  64.41 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  15.12 ns | 0.0320 ns | 0.0299 ns |  15.10 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.54 ns | 0.0372 ns | 0.0311 ns |  17.54 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_LongNullable.From_DateTime: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_LongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_LongNullable.From_String_Empty_AsObject: DefaultJob
