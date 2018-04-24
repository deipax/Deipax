
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  42.70 ns | 0.4851 ns | 0.4051 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  40.29 ns | 0.1437 ns | 0.1273 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 116.96 ns | 0.1057 ns | 0.0989 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  40.24 ns | 0.0767 ns | 0.0640 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  42.86 ns | 0.0723 ns | 0.0677 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.35 ns | 0.0360 ns | 0.0336 ns |      - |       0 B |
                                          From_Byte |  41.95 ns | 0.0672 ns | 0.0629 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  40.23 ns | 0.0985 ns | 0.0922 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 118.50 ns | 0.2399 ns | 0.2244 ns | 0.0055 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  40.16 ns | 0.0194 ns | 0.0151 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  42.51 ns | 0.0239 ns | 0.0200 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.06 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
                                          From_Char |  42.71 ns | 0.0398 ns | 0.0372 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  40.99 ns | 0.0518 ns | 0.0459 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 118.39 ns | 0.1112 ns | 0.0986 ns | 0.0055 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  40.96 ns | 0.0684 ns | 0.0571 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  42.02 ns | 0.0471 ns | 0.0418 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.09 ns | 0.0465 ns | 0.0435 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  42.73 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.38 ns | 0.0480 ns | 0.0449 ns |      - |       0 B |
                                       From_Decimal |  54.28 ns | 0.0940 ns | 0.0879 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  50.85 ns | 0.1189 ns | 0.0928 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 135.61 ns | 0.0405 ns | 0.0338 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  50.20 ns | 0.0749 ns | 0.0664 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  42.66 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.36 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
                                        From_Double |  46.48 ns | 0.0859 ns | 0.0804 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  44.70 ns | 0.1225 ns | 0.1146 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 125.95 ns | 0.1120 ns | 0.0992 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  44.52 ns | 0.0729 ns | 0.0682 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.44 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.08 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                                         From_Short |  42.45 ns | 0.0744 ns | 0.0696 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  40.98 ns | 0.0804 ns | 0.0713 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 117.62 ns | 0.1098 ns | 0.0857 ns | 0.0055 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  40.82 ns | 0.0180 ns | 0.0150 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.63 ns | 0.1205 ns | 0.1068 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.10 ns | 0.0530 ns | 0.0496 ns |      - |       0 B |
                                           From_Int |  43.44 ns | 0.0149 ns | 0.0132 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  41.26 ns | 0.0551 ns | 0.0488 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 119.81 ns | 0.2575 ns | 0.2283 ns | 0.0055 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  40.71 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  42.33 ns | 0.0585 ns | 0.0547 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.34 ns | 0.0249 ns | 0.0220 ns |      - |       0 B |
                                          From_Long |  42.74 ns | 0.0789 ns | 0.0738 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  40.74 ns | 0.0428 ns | 0.0379 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 119.70 ns | 0.1155 ns | 0.0965 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  40.72 ns | 0.0213 ns | 0.0178 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  42.34 ns | 0.0408 ns | 0.0362 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.44 ns | 0.0236 ns | 0.0210 ns |      - |       0 B |
                                         From_SByte |  43.57 ns | 0.0991 ns | 0.0927 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  40.81 ns | 0.1172 ns | 0.1039 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 120.89 ns | 0.0393 ns | 0.0307 ns | 0.0055 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  40.79 ns | 0.0778 ns | 0.0650 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  44.34 ns | 0.0126 ns | 0.0098 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.11 ns | 0.0649 ns | 0.0607 ns |      - |       0 B |
                                         From_Float |  46.69 ns | 0.0281 ns | 0.0219 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  44.82 ns | 0.1249 ns | 0.1168 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 125.33 ns | 0.0927 ns | 0.0822 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  44.77 ns | 0.0456 ns | 0.0427 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  43.92 ns | 0.0204 ns | 0.0160 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.08 ns | 0.0372 ns | 0.0348 ns |      - |       0 B |
                                        From_String | 118.21 ns | 0.0394 ns | 0.0307 ns |      - |       0 B |
                               From_String_AsObject | 118.41 ns | 0.1249 ns | 0.1168 ns |      - |       0 B |
                                   From_String_Null |  16.32 ns | 0.0091 ns | 0.0071 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.33 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  42.64 ns | 0.1139 ns | 0.1065 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  40.22 ns | 0.0864 ns | 0.0808 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 119.17 ns | 0.0772 ns | 0.0645 ns | 0.0055 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  40.25 ns | 0.1444 ns | 0.1280 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  43.30 ns | 0.0518 ns | 0.0485 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.32 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                                          From_UInt |  41.94 ns | 0.0212 ns | 0.0166 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  40.21 ns | 0.0855 ns | 0.0758 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 118.86 ns | 0.1241 ns | 0.0969 ns | 0.0055 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  40.15 ns | 0.0190 ns | 0.0149 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.98 ns | 0.0254 ns | 0.0212 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.06 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                                         From_ULong |  30.73 ns | 0.0141 ns | 0.0110 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  28.85 ns | 0.0328 ns | 0.0291 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 106.12 ns | 0.1486 ns | 0.1390 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  28.97 ns | 0.0254 ns | 0.0237 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  45.79 ns | 0.1237 ns | 0.1157 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.10 ns | 0.0258 ns | 0.0215 ns |      - |       0 B |
                                    From_NullObject |  16.05 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                        From_DBNull |  16.88 ns | 0.0301 ns | 0.0266 ns |      - |       0 B |
                              From_ConvertibleClass |  38.26 ns | 0.0331 ns | 0.0293 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  38.35 ns | 0.0199 ns | 0.0166 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  18.03 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.43 ns | 0.0187 ns | 0.0156 ns |      - |       0 B |
                             From_ConvertibleStruct |  42.15 ns | 0.0178 ns | 0.0139 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  39.70 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 122.43 ns | 0.3444 ns | 0.3221 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  39.96 ns | 0.0420 ns | 0.0351 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  43.72 ns | 0.0758 ns | 0.0709 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  19.10 ns | 0.0129 ns | 0.0115 ns |      - |       0 B |
                                          From_Enum |  95.19 ns | 0.0877 ns | 0.0821 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  96.49 ns | 0.1128 ns | 0.1000 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 203.60 ns | 0.2185 ns | 0.1825 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  95.34 ns | 0.0330 ns | 0.0275 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  43.92 ns | 0.0851 ns | 0.0796 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.07 ns | 0.0287 ns | 0.0255 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_ULongNullable.From_DateTime: DefaultJob
  ConvertTo_ULongNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_ULongNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_ULongNullable.From_String_Empty: DefaultJob
  ConvertTo_ULongNullable.From_String_Empty_AsObject: DefaultJob
