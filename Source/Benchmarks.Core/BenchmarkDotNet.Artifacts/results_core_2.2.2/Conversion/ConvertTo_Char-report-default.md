
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.01 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 13.15 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 12.98 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.17 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
                                             From_Byte | 13.00 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                    From_Byte_AsObject | 22.72 ns | 0.0140 ns | 0.0117 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 13.78 ns | 0.0010 ns | 0.0007 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 22.76 ns | 0.1348 ns | 0.1052 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.65 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.14 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
                                             From_Char | 13.00 ns | 0.0050 ns | 0.0044 ns |      - |       0 B |
                                    From_Char_AsObject | 17.80 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.78 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 16.64 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 13.65 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.45 ns | 0.0027 ns | 0.0020 ns |      - |       0 B |
                                         From_DateTime | 13.40 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.28 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.29 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.51 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                          From_Decimal | 14.29 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 14.29 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 14.29 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 15.91 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                           From_Double | 12.99 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 14.28 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 14.27 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.00 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                                            From_Short | 13.48 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                   From_Short_AsObject | 23.49 ns | 0.0231 ns | 0.0205 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.28 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 23.48 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.67 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.15 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
                                              From_Int | 14.43 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
                                     From_Int_AsObject | 24.24 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 15.56 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.24 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.40 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.94 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                                             From_Long | 14.43 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                                    From_Long_AsObject | 24.24 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.84 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 24.25 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.33 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 15.96 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                            From_SByte | 13.48 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.48 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.42 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 23.49 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.67 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.91 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                                            From_Float | 12.98 ns | 0.0054 ns | 0.0047 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 12.98 ns | 0.0046 ns | 0.0036 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 13.14 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.58 ns | 0.0110 ns | 0.0102 ns |      - |       0 B |
                                           From_String | 17.19 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
                                  From_String_AsObject | 22.71 ns | 0.0052 ns | 0.0047 ns |      - |       0 B |
                                      From_String_Null | 16.23 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                             From_String_Null_AsObject | 15.90 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                                     From_String_Empty | 14.74 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.16 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
                                  From_UShort_AsObject | 24.00 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.78 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 22.98 ns | 0.0208 ns | 0.0195 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.40 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 15.90 ns | 0.0026 ns | 0.0025 ns |      - |       0 B |
                                             From_UInt | 13.65 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.48 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.42 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 23.48 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.80 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 15.90 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                            From_ULong | 13.92 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                                   From_ULong_AsObject | 23.99 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 16.59 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.00 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.29 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.94 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                                       From_NullObject | 17.62 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
                                           From_DBNull | 14.54 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
                                  From_DBNull_AsObject | 16.02 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.90 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.91 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.18 ns | 0.0045 ns | 0.0035 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.58 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.28 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.15 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.29 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 15.90 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.13 ns | 0.0092 ns | 0.0086 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 22.20 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.38 ns | 0.0060 ns | 0.0054 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 22.19 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.15 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 15.92 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.02 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.12 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.94 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.12 ns | 0.0112 ns | 0.0104 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.88 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 15.89 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                                             From_Enum | 14.43 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
                                    From_Enum_AsObject | 54.01 ns | 0.0063 ns | 0.0049 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 15.57 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 53.99 ns | 0.0070 ns | 0.0055 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.40 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.74 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
                                      From_ParentClass | 14.28 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.58 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.27 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.14 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                                     From_ParentStruct | 14.02 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 19.31 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.19 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 21.82 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.89 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 15.90 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Char.From_Bool_AsObject: DefaultJob
  ConvertTo2_Char.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Char.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_AsObject: DefaultJob
  ConvertTo2_Char.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_AsObject: DefaultJob
  ConvertTo2_Char.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_AsObject: DefaultJob
  ConvertTo2_Char.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Char.From_String_Empty_AsObject: DefaultJob
