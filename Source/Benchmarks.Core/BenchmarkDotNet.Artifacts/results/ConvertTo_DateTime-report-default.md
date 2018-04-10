
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue |  43.57 ns | 0.3361 ns | 0.2980 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.05 ns | 0.2143 ns | 0.1900 ns |      - |       0 B |
                                          From_Byte |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Byte_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Byte_Nullable_NoValue |  42.83 ns | 0.1072 ns | 0.1002 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  22.80 ns | 0.0309 ns | 0.0274 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  42.55 ns | 0.1360 ns | 0.1273 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.10 ns | 0.0287 ns | 0.0224 ns |      - |       0 B |
                                      From_DateTime |  18.59 ns | 0.0420 ns | 0.0393 ns | 0.0057 |      24 B |
                             From_DateTime_AsObject |  17.13 ns | 0.2101 ns | 0.1965 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  89.88 ns | 0.1566 ns | 0.1388 ns | 0.0056 |      24 B |
          From_DateTime_Nullable_WithValue_AsObject |  17.04 ns | 0.0435 ns | 0.0385 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  42.17 ns | 0.0656 ns | 0.0614 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.04 ns | 0.1546 ns | 0.1447 ns |      - |       0 B |
                                       From_Decimal |        NA |        NA |        NA |    N/A |       N/A |
                              From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
           From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue |  42.29 ns | 0.0557 ns | 0.0521 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  15.96 ns | 0.0436 ns | 0.0386 ns |      - |       0 B |
                                        From_Double |        NA |        NA |        NA |    N/A |       N/A |
                               From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
            From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue |  44.50 ns | 0.0558 ns | 0.0404 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  15.95 ns | 0.1522 ns | 0.1424 ns |      - |       0 B |
                                         From_Short |        NA |        NA |        NA |    N/A |       N/A |
                                From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Short_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Short_Nullable_NoValue |  43.19 ns | 0.0573 ns | 0.0536 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  15.86 ns | 0.0399 ns | 0.0373 ns |      - |       0 B |
                                           From_Int |        NA |        NA |        NA |    N/A |       N/A |
                                  From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Int_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
               From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Int_Nullable_NoValue |  44.21 ns | 0.0981 ns | 0.0918 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  15.63 ns | 0.0157 ns | 0.0131 ns |      - |       0 B |
                                          From_Long |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Long_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Long_Nullable_NoValue |  43.97 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  15.79 ns | 0.2074 ns | 0.1839 ns |      - |       0 B |
                                         From_SByte |        NA |        NA |        NA |    N/A |       N/A |
                                From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_SByte_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_SByte_Nullable_NoValue |  45.21 ns | 0.0666 ns | 0.0623 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  15.85 ns | 0.0273 ns | 0.0228 ns |      - |       0 B |
                                         From_Float |        NA |        NA |        NA |    N/A |       N/A |
                                From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue |  44.14 ns | 0.0609 ns | 0.0570 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  15.97 ns | 0.1170 ns | 0.1094 ns |      - |       0 B |
                                        From_String | 798.23 ns | 1.6676 ns | 1.5599 ns |      - |       0 B |
                               From_String_AsObject | 840.87 ns | 1.1682 ns | 1.0928 ns |      - |       0 B |
                                   From_String_Null |  15.64 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                          From_String_Null_AsObject |  15.88 ns | 0.0723 ns | 0.0604 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |        NA |        NA |        NA |    N/A |       N/A |
                               From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_UShort_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
            From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UShort_Nullable_NoValue |  45.09 ns | 0.0569 ns | 0.0505 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  15.71 ns | 0.1071 ns | 0.1002 ns |      - |       0 B |
                                          From_UInt |        NA |        NA |        NA |    N/A |       N/A |
                                 From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UInt_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_UInt_Nullable_NoValue |  43.29 ns | 0.0768 ns | 0.0718 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  15.94 ns | 0.1958 ns | 0.1831 ns |      - |       0 B |
                                         From_ULong |        NA |        NA |        NA |    N/A |       N/A |
                                From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_ULong_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_ULong_Nullable_NoValue |  43.21 ns | 0.0499 ns | 0.0442 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  15.97 ns | 0.2145 ns | 0.2006 ns |      - |       0 B |
                                    From_NullObject |  15.86 ns | 0.0243 ns | 0.0228 ns |      - |       0 B |
                                        From_DBNull |  16.36 ns | 0.0694 ns | 0.0615 ns |      - |       0 B |
                              From_ConvertibleClass |  28.60 ns | 0.0493 ns | 0.0437 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  28.77 ns | 0.1167 ns | 0.1092 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.62 ns | 0.0063 ns | 0.0052 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.73 ns | 0.2106 ns | 0.1970 ns |      - |       0 B |
                             From_ConvertibleStruct |  31.07 ns | 0.0425 ns | 0.0377 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  30.26 ns | 0.0684 ns | 0.0571 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 112.36 ns | 0.2158 ns | 0.2019 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.27 ns | 0.4821 ns | 0.4509 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  44.30 ns | 0.1137 ns | 0.1008 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  15.62 ns | 0.0266 ns | 0.0207 ns |      - |       0 B |
                                          From_Enum |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Enum_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Enum_Nullable_NoValue |  44.43 ns | 0.1073 ns | 0.1003 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  15.83 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_DateTime.From_Bool: DefaultJob
  ConvertTo_DateTime.From_Bool_AsObject: DefaultJob
  ConvertTo_DateTime.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte: DefaultJob
  ConvertTo_DateTime.From_Byte_AsObject: DefaultJob
  ConvertTo_DateTime.From_Byte_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char: DefaultJob
  ConvertTo_DateTime.From_Char_AsObject: DefaultJob
  ConvertTo_DateTime.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal: DefaultJob
  ConvertTo_DateTime.From_Decimal_AsObject: DefaultJob
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double: DefaultJob
  ConvertTo_DateTime.From_Double_AsObject: DefaultJob
  ConvertTo_DateTime.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short: DefaultJob
  ConvertTo_DateTime.From_Short_AsObject: DefaultJob
  ConvertTo_DateTime.From_Short_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int: DefaultJob
  ConvertTo_DateTime.From_Int_AsObject: DefaultJob
  ConvertTo_DateTime.From_Int_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long: DefaultJob
  ConvertTo_DateTime.From_Long_AsObject: DefaultJob
  ConvertTo_DateTime.From_Long_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte: DefaultJob
  ConvertTo_DateTime.From_SByte_AsObject: DefaultJob
  ConvertTo_DateTime.From_SByte_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float: DefaultJob
  ConvertTo_DateTime.From_Float_AsObject: DefaultJob
  ConvertTo_DateTime.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_String_Empty: DefaultJob
  ConvertTo_DateTime.From_String_Empty_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort: DefaultJob
  ConvertTo_DateTime.From_UShort_AsObject: DefaultJob
  ConvertTo_DateTime.From_UShort_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt: DefaultJob
  ConvertTo_DateTime.From_UInt_AsObject: DefaultJob
  ConvertTo_DateTime.From_UInt_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong: DefaultJob
  ConvertTo_DateTime.From_ULong_AsObject: DefaultJob
  ConvertTo_DateTime.From_ULong_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum: DefaultJob
  ConvertTo_DateTime.From_Enum_AsObject: DefaultJob
  ConvertTo_DateTime.From_Enum_Nullable_WithValue: DefaultJob
  ConvertTo_DateTime.From_Enum_Nullable_WithValue_AsObject: DefaultJob
