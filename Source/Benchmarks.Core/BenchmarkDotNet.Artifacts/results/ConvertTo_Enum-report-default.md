
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  74.55 ns | 1.5116 ns | 2.3084 ns |  74.31 ns | 0.0113 |      48 B |
                                 From_Bool_AsObject |  69.24 ns | 1.3121 ns | 1.2886 ns |  68.70 ns | 0.0056 |      24 B |
                       From_Bool_Nullable_WithValue | 153.21 ns | 3.9287 ns | 4.0345 ns | 152.27 ns | 0.0112 |      48 B |
              From_Bool_Nullable_WithValue_AsObject |  69.30 ns | 1.5485 ns | 2.0672 ns |  68.51 ns | 0.0056 |      24 B |
                         From_Bool_Nullable_NoValue |  45.23 ns | 0.9061 ns | 1.3561 ns |  45.13 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  15.24 ns | 0.2320 ns | 0.2170 ns |  15.15 ns |      - |       0 B |
                                          From_Byte |  72.04 ns | 1.4698 ns | 1.5094 ns |  71.20 ns | 0.0113 |      48 B |
                                 From_Byte_AsObject |  70.73 ns | 0.6848 ns | 0.5718 ns |  70.61 ns | 0.0056 |      24 B |
                       From_Byte_Nullable_WithValue | 151.29 ns | 1.7778 ns | 1.4845 ns | 151.60 ns | 0.0112 |      48 B |
              From_Byte_Nullable_WithValue_AsObject |  68.80 ns | 0.3554 ns | 0.3150 ns |  68.82 ns | 0.0056 |      24 B |
                         From_Byte_Nullable_NoValue |  42.69 ns | 0.7284 ns | 0.6457 ns |  42.85 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.43 ns | 0.0364 ns | 0.0323 ns |  16.42 ns |      - |       0 B |
                                          From_Char |  56.78 ns | 0.2349 ns | 0.2197 ns |  56.84 ns | 0.0114 |      48 B |
                                 From_Char_AsObject |  55.95 ns | 0.1120 ns | 0.1048 ns |  55.96 ns | 0.0057 |      24 B |
                       From_Char_Nullable_WithValue | 135.23 ns | 1.1973 ns | 1.0614 ns | 134.63 ns | 0.0112 |      48 B |
              From_Char_Nullable_WithValue_AsObject |  55.63 ns | 0.1194 ns | 0.1059 ns |  55.64 ns | 0.0057 |      24 B |
                         From_Char_Nullable_NoValue |  42.32 ns | 0.3384 ns | 0.3166 ns |  42.23 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.85 ns | 0.0543 ns | 0.0508 ns |  14.82 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  41.84 ns | 0.2800 ns | 0.2482 ns |  41.95 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  14.96 ns | 0.0124 ns | 0.0097 ns |  14.96 ns |      - |       0 B |
                                       From_Decimal |  83.05 ns | 0.3066 ns | 0.2560 ns |  82.99 ns | 0.0132 |      56 B |
                              From_Decimal_AsObject |  79.28 ns | 0.3073 ns | 0.2874 ns |  79.19 ns | 0.0056 |      24 B |
                    From_Decimal_Nullable_WithValue | 158.49 ns | 1.1370 ns | 1.0635 ns | 158.93 ns | 0.0131 |      56 B |
           From_Decimal_Nullable_WithValue_AsObject |  79.39 ns | 0.2633 ns | 0.2334 ns |  79.36 ns | 0.0056 |      24 B |
                      From_Decimal_Nullable_NoValue |  41.82 ns | 0.2197 ns | 0.2055 ns |  41.75 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.99 ns | 0.0332 ns | 0.0294 ns |  14.97 ns |      - |       0 B |
                                        From_Double |  75.62 ns | 0.2870 ns | 0.2396 ns |  75.49 ns | 0.0113 |      48 B |
                               From_Double_AsObject |  72.27 ns | 0.4255 ns | 0.3980 ns |  72.09 ns | 0.0056 |      24 B |
                     From_Double_Nullable_WithValue | 152.05 ns | 1.5416 ns | 1.4420 ns | 151.50 ns | 0.0112 |      48 B |
            From_Double_Nullable_WithValue_AsObject |  70.41 ns | 0.2068 ns | 0.1833 ns |  70.33 ns | 0.0056 |      24 B |
                       From_Double_Nullable_NoValue |  41.03 ns | 0.0908 ns | 0.0758 ns |  41.01 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.82 ns | 0.0307 ns | 0.0287 ns |  14.80 ns |      - |       0 B |
                                         From_Short |  70.36 ns | 0.1373 ns | 0.1284 ns |  70.33 ns | 0.0113 |      48 B |
                                From_Short_AsObject |  69.63 ns | 1.4636 ns | 3.3629 ns |  67.79 ns | 0.0056 |      24 B |
                      From_Short_Nullable_WithValue | 142.52 ns | 0.2066 ns | 0.1725 ns | 142.46 ns | 0.0112 |      48 B |
             From_Short_Nullable_WithValue_AsObject |  68.05 ns | 0.1857 ns | 0.1646 ns |  67.97 ns | 0.0056 |      24 B |
                        From_Short_Nullable_NoValue |  41.07 ns | 0.0531 ns | 0.0414 ns |  41.07 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  15.02 ns | 0.1259 ns | 0.1178 ns |  15.07 ns |      - |       0 B |
                                           From_Int |  51.90 ns | 0.1334 ns | 0.1183 ns |  51.91 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  51.06 ns | 0.0963 ns | 0.0804 ns |  51.07 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 126.66 ns | 0.2441 ns | 0.2284 ns | 126.66 ns | 0.0055 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  51.24 ns | 0.6383 ns | 0.5970 ns |  51.64 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.44 ns | 0.1232 ns | 0.1029 ns |  41.45 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.00 ns | 0.0486 ns | 0.0406 ns |  14.97 ns |      - |       0 B |
                                          From_Long |  71.36 ns | 0.2707 ns | 0.2532 ns |  71.34 ns | 0.0113 |      48 B |
                                 From_Long_AsObject |  83.84 ns | 0.6440 ns | 0.6024 ns |  83.51 ns | 0.0056 |      24 B |
                       From_Long_Nullable_WithValue | 147.34 ns | 0.6527 ns | 0.6105 ns | 147.37 ns | 0.0112 |      48 B |
              From_Long_Nullable_WithValue_AsObject |  86.36 ns | 0.0641 ns | 0.0568 ns |  86.37 ns | 0.0056 |      24 B |
                         From_Long_Nullable_NoValue |  43.52 ns | 0.2528 ns | 0.2364 ns |  43.42 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.06 ns | 0.0156 ns | 0.0122 ns |  15.06 ns |      - |       0 B |
                                         From_SByte |  70.39 ns | 0.1795 ns | 0.1679 ns |  70.35 ns | 0.0113 |      48 B |
                                From_SByte_AsObject |  67.92 ns | 0.2167 ns | 0.1809 ns |  67.87 ns | 0.0056 |      24 B |
                      From_SByte_Nullable_WithValue | 144.76 ns | 0.5383 ns | 0.5035 ns | 144.71 ns | 0.0112 |      48 B |
             From_SByte_Nullable_WithValue_AsObject |  68.44 ns | 0.2366 ns | 0.1976 ns |  68.36 ns | 0.0056 |      24 B |
                        From_SByte_Nullable_NoValue |  43.22 ns | 0.0775 ns | 0.0725 ns |  43.21 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.80 ns | 0.0163 ns | 0.0136 ns |  14.80 ns |      - |       0 B |
                                         From_Float |  72.41 ns | 0.1705 ns | 0.1594 ns |  72.43 ns | 0.0113 |      48 B |
                                From_Float_AsObject |  71.33 ns | 0.5377 ns | 0.5030 ns |  71.16 ns | 0.0056 |      24 B |
                      From_Float_Nullable_WithValue | 153.27 ns | 0.7924 ns | 0.7412 ns | 152.84 ns | 0.0112 |      48 B |
             From_Float_Nullable_WithValue_AsObject |  71.19 ns | 0.4894 ns | 0.4577 ns |  71.01 ns | 0.0056 |      24 B |
                        From_Float_Nullable_NoValue |  41.16 ns | 0.1296 ns | 0.1149 ns |  41.17 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.82 ns | 0.0593 ns | 0.0495 ns |  14.80 ns |      - |       0 B |
                                        From_String |  59.89 ns | 0.1291 ns | 0.1207 ns |  59.92 ns |      - |       0 B |
                               From_String_AsObject |  63.20 ns | 0.1327 ns | 0.1036 ns |  63.18 ns |      - |       0 B |
                                   From_String_Null |  14.99 ns | 0.0483 ns | 0.0428 ns |  14.97 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.97 ns | 0.0136 ns | 0.0121 ns |  14.97 ns |      - |       0 B |
                                  From_String_Empty |  42.64 ns | 0.1221 ns | 0.1020 ns |  42.62 ns |      - |       0 B |
                         From_String_Empty_AsObject |  45.82 ns | 0.9481 ns | 1.3597 ns |  45.60 ns |      - |       0 B |
                                        From_UShort |  71.03 ns | 0.6389 ns | 0.5976 ns |  70.88 ns | 0.0113 |      48 B |
                               From_UShort_AsObject |  69.21 ns | 0.3133 ns | 0.2777 ns |  69.17 ns | 0.0056 |      24 B |
                     From_UShort_Nullable_WithValue | 145.06 ns | 1.4670 ns | 1.3722 ns | 144.47 ns | 0.0112 |      48 B |
            From_UShort_Nullable_WithValue_AsObject |  68.75 ns | 0.5543 ns | 0.5185 ns |  68.48 ns | 0.0056 |      24 B |
                       From_UShort_Nullable_NoValue |  42.79 ns | 0.5628 ns | 0.4989 ns |  42.79 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.10 ns | 0.1365 ns | 0.1210 ns |  15.06 ns |      - |       0 B |
                                          From_UInt |  70.90 ns | 0.9913 ns | 0.8787 ns |  70.99 ns | 0.0113 |      48 B |
                                 From_UInt_AsObject |  68.42 ns | 0.1889 ns | 0.1577 ns |  68.43 ns | 0.0056 |      24 B |
                       From_UInt_Nullable_WithValue | 147.98 ns | 0.8205 ns | 0.6406 ns | 147.93 ns | 0.0112 |      48 B |
              From_UInt_Nullable_WithValue_AsObject |  68.47 ns | 0.4724 ns | 0.4419 ns |  68.26 ns | 0.0056 |      24 B |
                         From_UInt_Nullable_NoValue |  41.67 ns | 0.3386 ns | 0.3168 ns |  41.73 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.85 ns | 0.0525 ns | 0.0466 ns |  14.84 ns |      - |       0 B |
                                         From_ULong |  71.58 ns | 0.4821 ns | 0.4509 ns |  71.52 ns | 0.0113 |      48 B |
                                From_ULong_AsObject |  69.09 ns | 0.3181 ns | 0.2656 ns |  69.12 ns | 0.0056 |      24 B |
                      From_ULong_Nullable_WithValue | 148.74 ns | 0.8336 ns | 0.7390 ns | 148.75 ns | 0.0112 |      48 B |
             From_ULong_Nullable_WithValue_AsObject |  69.22 ns | 0.2420 ns | 0.2145 ns |  69.16 ns | 0.0056 |      24 B |
                        From_ULong_Nullable_NoValue |  41.98 ns | 0.1780 ns | 0.1578 ns |  41.96 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.95 ns | 0.1860 ns | 0.1740 ns |  14.86 ns |      - |       0 B |
                                    From_NullObject |  14.90 ns | 0.0764 ns | 0.0715 ns |  14.89 ns |      - |       0 B |
                                        From_DBNull |  15.06 ns | 0.1320 ns | 0.1235 ns |  15.03 ns |      - |       0 B |
                              From_ConvertibleClass |  65.73 ns | 0.3669 ns | 0.3253 ns |  65.71 ns | 0.0056 |      24 B |
                     From_ConvertibleClass_AsObject |  65.54 ns | 0.4226 ns | 0.3953 ns |  65.47 ns | 0.0056 |      24 B |
                      From_ConvertibleClass_NoValue |  15.11 ns | 0.1529 ns | 0.1276 ns |  15.06 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.02 ns | 0.0551 ns | 0.0460 ns |  15.02 ns |      - |       0 B |
                             From_ConvertibleStruct |  71.69 ns | 1.4640 ns | 2.3640 ns |  70.68 ns | 0.0113 |      48 B |
                    From_ConvertibleStruct_AsObject |  66.06 ns | 0.4634 ns | 0.4108 ns |  65.94 ns | 0.0056 |      24 B |
          From_ConvertibleStruct_Nullable_WithValue | 152.04 ns | 0.6865 ns | 0.5733 ns | 152.17 ns | 0.0112 |      48 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  69.46 ns | 1.4138 ns | 1.3225 ns |  69.46 ns | 0.0056 |      24 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.91 ns | 0.4060 ns | 0.3798 ns |  41.71 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.22 ns | 0.2965 ns | 0.2774 ns |  15.10 ns |      - |       0 B |
                                          From_Enum |  17.41 ns | 0.0630 ns | 0.0589 ns |  17.40 ns | 0.0057 |      24 B |
                                 From_Enum_AsObject |  16.14 ns | 0.0739 ns | 0.0692 ns |  16.12 ns |      - |       0 B |
                       From_Enum_Nullable_WithValue | 117.28 ns | 0.3238 ns | 0.3029 ns | 117.29 ns | 0.0055 |      24 B |
              From_Enum_Nullable_WithValue_AsObject |  16.06 ns | 0.2393 ns | 0.1998 ns |  16.04 ns |      - |       0 B |
                         From_Enum_Nullable_NoValue |  42.47 ns | 0.9984 ns | 0.8851 ns |  42.03 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.21 ns | 0.3228 ns | 0.2695 ns |  15.09 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Enum.From_DateTime: DefaultJob
  ConvertTo_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo_Enum.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
