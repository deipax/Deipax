
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.23 ns | 0.0121 ns | 0.0095 ns |      - |       0 B |
                                 From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue |  13.42 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue |  13.18 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  17.48 ns | 0.0031 ns | 0.0022 ns |      - |       0 B |
                                          From_Byte |  13.20 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                                 From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Byte_Nullable_WithValue |  14.22 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Byte_Nullable_NoValue |  13.41 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  17.56 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
                                          From_Char |  13.19 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
                                 From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue |  13.46 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue |  13.61 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.47 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
                                      From_DateTime |  13.45 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
                             From_DateTime_AsObject |  18.20 ns | 0.0169 ns | 0.0149 ns |      - |       0 B |
                   From_DateTime_Nullable_WithValue |  16.41 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |  18.19 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                     From_DateTime_Nullable_NoValue |  15.32 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.45 ns | 0.0046 ns | 0.0034 ns |      - |       0 B |
                                       From_Decimal |  15.09 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                              From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue |  15.33 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue |  14.29 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  17.46 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                                        From_Double |  13.19 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                               From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue |  14.05 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue |  14.03 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.47 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                                         From_Short |  15.37 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                                From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Short_Nullable_WithValue |  15.60 ns | 0.0138 ns | 0.0115 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Short_Nullable_NoValue |  13.61 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  17.85 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                           From_Int |  13.63 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                  From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Int_Nullable_WithValue |  13.19 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Int_Nullable_NoValue |  13.18 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.51 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                                          From_Long |  13.43 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                 From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Long_Nullable_WithValue |  15.20 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Long_Nullable_NoValue |  14.06 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.43 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                                         From_SByte |  13.19 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_SByte_Nullable_WithValue |  13.42 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_SByte_Nullable_NoValue |  13.65 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  18.44 ns | 0.0018 ns | 0.0013 ns |      - |       0 B |
                                         From_Float |  13.20 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
                                From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue |  14.44 ns | 0.0210 ns | 0.0186 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue |  13.41 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.45 ns | 0.0015 ns | 0.0011 ns |      - |       0 B |
                                        From_String | 737.69 ns | 0.8420 ns | 0.7464 ns |      - |       0 B |
                               From_String_AsObject | 775.37 ns | 0.5741 ns | 0.5089 ns |      - |       0 B |
                                   From_String_Null |  17.28 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                          From_String_Null_AsObject |  17.47 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                  From_String_Empty |  16.33 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  13.43 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                               From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_UShort_Nullable_WithValue |  13.61 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UShort_Nullable_NoValue |  15.61 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  17.41 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                          From_UInt |  13.46 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
                                 From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_UInt_Nullable_WithValue |  13.42 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_UInt_Nullable_NoValue |  13.41 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  18.38 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                                         From_ULong |  13.19 ns | 0.0053 ns | 0.0049 ns |      - |       0 B |
                                From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_ULong_Nullable_WithValue |  15.07 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_ULong_Nullable_NoValue |  14.04 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  19.09 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                                    From_NullObject |  17.48 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                        From_DBNull |  14.56 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                              From_ConvertibleClass |  21.60 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  24.00 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.47 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  18.75 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.98 ns | 0.0039 ns | 0.0033 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  25.29 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  24.75 ns | 0.0033 ns | 0.0028 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.28 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  14.13 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.74 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                                          From_Enum |  13.45 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                 From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Enum_Nullable_WithValue |  13.42 ns | 0.0118 ns | 0.0092 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Enum_Nullable_NoValue |  13.42 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  17.46 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTime.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTime.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTime.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTime.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTime.From_Enum_Nullable_WithValue_AsObject: DefaultJob
