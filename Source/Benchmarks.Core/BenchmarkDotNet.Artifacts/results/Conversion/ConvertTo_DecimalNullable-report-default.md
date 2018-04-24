
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  47.27 ns | 0.3085 ns | 0.2885 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  47.30 ns | 0.7210 ns | 0.6744 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 125.81 ns | 0.9035 ns | 0.8010 ns | 0.0055 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  45.89 ns | 0.2708 ns | 0.2533 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  43.80 ns | 0.4564 ns | 0.4270 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.52 ns | 0.1394 ns | 0.1164 ns |      - |       0 B |
                                          From_Byte |  48.86 ns | 1.0455 ns | 1.1621 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  47.62 ns | 0.3772 ns | 0.3344 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 123.92 ns | 0.8730 ns | 0.7739 ns | 0.0055 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  47.22 ns | 0.9013 ns | 0.7990 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  44.06 ns | 0.0913 ns | 0.0854 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.15 ns | 0.0921 ns | 0.0862 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  44.86 ns | 0.0582 ns | 0.0486 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.15 ns | 0.1103 ns | 0.1032 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  44.57 ns | 0.0775 ns | 0.0725 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  18.95 ns | 0.0436 ns | 0.0408 ns |      - |       0 B |
                                       From_Decimal |  33.86 ns | 0.0671 ns | 0.0561 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  31.78 ns | 0.0317 ns | 0.0296 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 107.83 ns | 0.1666 ns | 0.1391 ns | 0.0075 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  32.20 ns | 0.1469 ns | 0.1374 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  43.24 ns | 0.0408 ns | 0.0318 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.36 ns | 0.0361 ns | 0.0302 ns |      - |       0 B |
                                        From_Double | 115.69 ns | 0.0847 ns | 0.0750 ns | 0.0056 |      24 B |
                               From_Double_AsObject | 112.11 ns | 0.0229 ns | 0.0179 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 192.53 ns | 0.2596 ns | 0.2168 ns | 0.0055 |      24 B |
            From_Double_Nullable_WithValue_AsObject | 112.88 ns | 0.1278 ns | 0.1196 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  42.59 ns | 0.0532 ns | 0.0471 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.99 ns | 0.0221 ns | 0.0184 ns |      - |       0 B |
                                         From_Short |  48.45 ns | 0.0429 ns | 0.0381 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  47.73 ns | 0.0359 ns | 0.0336 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 123.51 ns | 0.2894 ns | 0.2566 ns | 0.0055 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  47.80 ns | 0.1731 ns | 0.1534 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.39 ns | 0.0203 ns | 0.0169 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  16.18 ns | 0.2326 ns | 0.2062 ns |      - |       0 B |
                                           From_Int |  47.72 ns | 0.0391 ns | 0.0326 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  45.91 ns | 0.0546 ns | 0.0456 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 125.68 ns | 0.3132 ns | 0.2615 ns | 0.0055 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  46.11 ns | 0.0570 ns | 0.0505 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  42.39 ns | 0.0783 ns | 0.0732 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.97 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                                          From_Long |  46.81 ns | 0.0542 ns | 0.0481 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  47.43 ns | 0.0362 ns | 0.0302 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 127.61 ns | 0.1026 ns | 0.0801 ns | 0.0055 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  47.39 ns | 0.1083 ns | 0.0904 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  43.64 ns | 0.0749 ns | 0.0700 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.33 ns | 0.0231 ns | 0.0180 ns |      - |       0 B |
                                         From_SByte |  50.02 ns | 0.1458 ns | 0.1364 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  46.63 ns | 0.0700 ns | 0.0585 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 126.33 ns | 0.1916 ns | 0.1496 ns | 0.0055 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  46.49 ns | 0.0789 ns | 0.0616 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  43.76 ns | 0.1337 ns | 0.1251 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.06 ns | 0.0128 ns | 0.0100 ns |      - |       0 B |
                                         From_Float |  73.84 ns | 0.1060 ns | 0.0940 ns | 0.0056 |      24 B |
                                From_Float_AsObject |  72.99 ns | 0.1413 ns | 0.1322 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 152.68 ns | 0.5908 ns | 0.5526 ns | 0.0055 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  73.15 ns | 0.2609 ns | 0.2441 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  43.26 ns | 0.1011 ns | 0.0844 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.06 ns | 0.0233 ns | 0.0206 ns |      - |       0 B |
                                        From_String | 159.74 ns | 0.2647 ns | 0.2210 ns |      - |       0 B |
                               From_String_AsObject | 161.56 ns | 0.6118 ns | 0.5423 ns |      - |       0 B |
                                   From_String_Null |  16.33 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.32 ns | 0.0290 ns | 0.0242 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  46.95 ns | 0.0736 ns | 0.0689 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  45.93 ns | 0.0653 ns | 0.0611 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 124.83 ns | 0.4382 ns | 0.4099 ns | 0.0055 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  46.00 ns | 0.0840 ns | 0.0744 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.56 ns | 0.1215 ns | 0.1077 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.33 ns | 0.0181 ns | 0.0161 ns |      - |       0 B |
                                          From_UInt |  46.22 ns | 0.1348 ns | 0.1195 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  46.77 ns | 0.0679 ns | 0.0602 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 122.77 ns | 0.0546 ns | 0.0456 ns | 0.0055 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  46.64 ns | 0.1107 ns | 0.1035 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  42.48 ns | 0.0814 ns | 0.0762 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.07 ns | 0.0432 ns | 0.0383 ns |      - |       0 B |
                                         From_ULong |  46.62 ns | 0.0239 ns | 0.0199 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  45.79 ns | 0.0398 ns | 0.0352 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 125.90 ns | 0.0660 ns | 0.0617 ns | 0.0055 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  46.75 ns | 0.0601 ns | 0.0533 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  43.73 ns | 0.0380 ns | 0.0356 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.05 ns | 0.0084 ns | 0.0066 ns |      - |       0 B |
                                    From_NullObject |  16.89 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
                                        From_DBNull |  17.86 ns | 0.0348 ns | 0.0326 ns |      - |       0 B |
                              From_ConvertibleClass |  44.35 ns | 0.1170 ns | 0.0914 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  44.87 ns | 0.0601 ns | 0.0532 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.33 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.32 ns | 0.0121 ns | 0.0094 ns |      - |       0 B |
                             From_ConvertibleStruct |  46.22 ns | 0.3447 ns | 0.3056 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  45.35 ns | 0.1412 ns | 0.1321 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 127.94 ns | 0.5886 ns | 0.5506 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  46.36 ns | 0.2132 ns | 0.1995 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  42.54 ns | 0.0632 ns | 0.0591 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.34 ns | 0.0287 ns | 0.0239 ns |      - |       0 B |
                                          From_Enum | 116.66 ns | 0.5154 ns | 0.4821 ns | 0.0112 |      48 B |
                                 From_Enum_AsObject | 105.00 ns | 0.1621 ns | 0.1437 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 211.37 ns | 0.1236 ns | 0.0965 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject | 106.74 ns | 0.1127 ns | 0.0941 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  43.97 ns | 0.2004 ns | 0.1875 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.11 ns | 0.0585 ns | 0.0489 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_DecimalNullable.From_Char: DefaultJob
  ConvertTo_DecimalNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_DecimalNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_DecimalNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DecimalNullable.From_String_Empty: DefaultJob
  ConvertTo_DecimalNullable.From_String_Empty_AsObject: DefaultJob
