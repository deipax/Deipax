
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
                         From_Bool_Nullable_NoValue |  45.68 ns | 0.3892 ns | 0.3450 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  16.73 ns | 0.0128 ns | 0.0100 ns |      - |       0 B |
                                          From_Byte |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Byte_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Byte_Nullable_NoValue |  43.49 ns | 0.1352 ns | 0.1199 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  16.61 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
                                          From_Char |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  43.01 ns | 0.1278 ns | 0.1133 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  16.62 ns | 0.0314 ns | 0.0262 ns |      - |       0 B |
                                      From_DateTime |  33.00 ns | 0.0116 ns | 0.0091 ns | 0.0057 |      24 B |
                             From_DateTime_AsObject |  29.35 ns | 0.0820 ns | 0.0640 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue | 106.03 ns | 0.2264 ns | 0.2117 ns | 0.0056 |      24 B |
          From_DateTime_Nullable_WithValue_AsObject |  29.28 ns | 0.2187 ns | 0.2046 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  45.03 ns | 0.0398 ns | 0.0352 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.33 ns | 0.0159 ns | 0.0124 ns |      - |       0 B |
                                       From_Decimal |        NA |        NA |        NA |    N/A |       N/A |
                              From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
           From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue |  42.69 ns | 0.0629 ns | 0.0525 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  16.35 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
                                        From_Double |        NA |        NA |        NA |    N/A |       N/A |
                               From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
            From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue |  42.11 ns | 0.0552 ns | 0.0461 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  16.94 ns | 0.0270 ns | 0.0210 ns |      - |       0 B |
                                         From_Short |        NA |        NA |        NA |    N/A |       N/A |
                                From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Short_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Short_Nullable_NoValue |  42.82 ns | 0.1341 ns | 0.1254 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  22.42 ns | 0.0281 ns | 0.0262 ns |      - |       0 B |
                                           From_Int |        NA |        NA |        NA |    N/A |       N/A |
                                  From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Int_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
               From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Int_Nullable_NoValue |  43.55 ns | 0.1189 ns | 0.1112 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  16.46 ns | 0.2225 ns | 0.2081 ns |      - |       0 B |
                                          From_Long |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Long_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Long_Nullable_NoValue |  42.56 ns | 0.1438 ns | 0.1345 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  16.34 ns | 0.0258 ns | 0.0215 ns |      - |       0 B |
                                         From_SByte |        NA |        NA |        NA |    N/A |       N/A |
                                From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_SByte_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_SByte_Nullable_NoValue |  44.42 ns | 0.1068 ns | 0.0946 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  16.60 ns | 0.0103 ns | 0.0075 ns |      - |       0 B |
                                         From_Float |        NA |        NA |        NA |    N/A |       N/A |
                                From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue |  42.82 ns | 0.0823 ns | 0.0729 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  16.60 ns | 0.0219 ns | 0.0194 ns |      - |       0 B |
                                        From_String | 866.74 ns | 2.2437 ns | 2.0988 ns |      - |       0 B |
                               From_String_AsObject | 879.46 ns | 1.7621 ns | 1.4715 ns |      - |       0 B |
                                   From_String_Null |  16.33 ns | 0.0191 ns | 0.0159 ns |      - |       0 B |
                          From_String_Null_AsObject |  16.33 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |        NA |        NA |        NA |    N/A |       N/A |
                               From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_UShort_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
            From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UShort_Nullable_NoValue |  43.58 ns | 0.1130 ns | 0.1002 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  16.79 ns | 0.0260 ns | 0.0217 ns |      - |       0 B |
                                          From_UInt |        NA |        NA |        NA |    N/A |       N/A |
                                 From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UInt_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_UInt_Nullable_NoValue |  44.17 ns | 0.0186 ns | 0.0156 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  16.60 ns | 0.0215 ns | 0.0191 ns |      - |       0 B |
                                         From_ULong |        NA |        NA |        NA |    N/A |       N/A |
                                From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_ULong_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_ULong_Nullable_NoValue |  44.15 ns | 0.1115 ns | 0.1043 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  16.60 ns | 0.0108 ns | 0.0091 ns |      - |       0 B |
                                    From_NullObject |  16.61 ns | 0.0202 ns | 0.0168 ns |      - |       0 B |
                                        From_DBNull |  16.98 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                              From_ConvertibleClass |  39.94 ns | 0.0515 ns | 0.0402 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  40.22 ns | 0.0888 ns | 0.0830 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  16.32 ns | 0.0134 ns | 0.0118 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  16.32 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                             From_ConvertibleStruct |  43.22 ns | 0.0611 ns | 0.0541 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  41.58 ns | 0.0583 ns | 0.0545 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 125.75 ns | 0.2270 ns | 0.2012 ns | 0.0055 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  41.64 ns | 0.0560 ns | 0.0497 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  43.60 ns | 0.0282 ns | 0.0220 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.35 ns | 0.0392 ns | 0.0367 ns |      - |       0 B |
                                          From_Enum |        NA |        NA |        NA |    N/A |       N/A |
                                 From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Enum_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
              From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Enum_Nullable_NoValue |  43.34 ns | 0.0333 ns | 0.0278 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  16.99 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_DateTimeNullable.From_Bool: DefaultJob
  ConvertTo_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Char: DefaultJob
  ConvertTo_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Double: DefaultJob
  ConvertTo_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Short: DefaultJob
  ConvertTo_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Int: DefaultJob
  ConvertTo_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Long: DefaultJob
  ConvertTo_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Float: DefaultJob
  ConvertTo_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_String_Empty: DefaultJob
  ConvertTo_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue: DefaultJob
  ConvertTo_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
