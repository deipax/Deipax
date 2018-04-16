
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.62 ns | 0.0681 ns | 0.0603 ns | 14.61 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 14.44 ns | 0.0064 ns | 0.0054 ns | 14.44 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 16.58 ns | 0.0052 ns | 0.0046 ns | 16.58 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 22.25 ns | 0.0108 ns | 0.0090 ns | 22.25 ns |      - |       0 B |
                                             From_Byte | 15.20 ns | 0.0045 ns | 0.0042 ns | 15.20 ns |      - |       0 B |
                                    From_Byte_AsObject | 28.26 ns | 0.0162 ns | 0.0152 ns | 28.25 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 17.57 ns | 0.0514 ns | 0.0481 ns | 17.59 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 28.25 ns | 0.0046 ns | 0.0036 ns | 28.25 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 15.93 ns | 0.0120 ns | 0.0107 ns | 15.93 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 18.27 ns | 0.0102 ns | 0.0086 ns | 18.27 ns |      - |       0 B |
                                             From_Char | 14.69 ns | 0.0132 ns | 0.0124 ns | 14.69 ns |      - |       0 B |
                                    From_Char_AsObject | 29.69 ns | 0.0212 ns | 0.0177 ns | 29.68 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 14.15 ns | 0.0093 ns | 0.0082 ns | 14.14 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 29.45 ns | 0.0320 ns | 0.0284 ns | 29.45 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.20 ns | 0.0142 ns | 0.0133 ns | 14.20 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.53 ns | 0.0175 ns | 0.0164 ns | 18.52 ns |      - |       0 B |
                                         From_DateTime | 14.90 ns | 0.0063 ns | 0.0056 ns | 14.90 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 15.19 ns | 0.0145 ns | 0.0128 ns | 15.18 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.97 ns | 0.0028 ns | 0.0022 ns | 14.97 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 18.23 ns | 0.0153 ns | 0.0143 ns | 18.23 ns |      - |       0 B |
                                          From_Decimal | 16.01 ns | 0.0060 ns | 0.0050 ns | 16.01 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 15.41 ns | 0.0069 ns | 0.0058 ns | 15.40 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 17.11 ns | 0.0101 ns | 0.0094 ns | 17.10 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.56 ns | 0.0146 ns | 0.0136 ns | 18.55 ns |      - |       0 B |
                                           From_Double | 14.65 ns | 0.0107 ns | 0.0100 ns | 14.65 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 15.19 ns | 0.0149 ns | 0.0139 ns | 15.19 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 16.28 ns | 0.0055 ns | 0.0049 ns | 16.28 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.70 ns | 0.0104 ns | 0.0092 ns | 18.69 ns |      - |       0 B |
                                            From_Short | 14.95 ns | 0.0148 ns | 0.0131 ns | 14.95 ns |      - |       0 B |
                                   From_Short_AsObject | 28.79 ns | 0.0071 ns | 0.0059 ns | 28.79 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.78 ns | 0.0211 ns | 0.0197 ns | 17.77 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 28.84 ns | 0.0189 ns | 0.0177 ns | 28.84 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.07 ns | 0.0108 ns | 0.0101 ns | 15.07 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 18.08 ns | 0.0200 ns | 0.0187 ns | 18.08 ns |      - |       0 B |
                                              From_Int | 15.94 ns | 0.0119 ns | 0.0111 ns | 15.93 ns |      - |       0 B |
                                     From_Int_AsObject | 29.64 ns | 0.0383 ns | 0.0320 ns | 29.65 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 18.88 ns | 0.0657 ns | 0.0614 ns | 18.88 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 29.63 ns | 0.0137 ns | 0.0121 ns | 29.63 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 15.02 ns | 0.0129 ns | 0.0121 ns | 15.02 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.53 ns | 0.0176 ns | 0.0165 ns | 18.53 ns |      - |       0 B |
                                             From_Long | 15.82 ns | 0.0194 ns | 0.0162 ns | 15.82 ns |      - |       0 B |
                                    From_Long_AsObject | 29.65 ns | 0.0161 ns | 0.0135 ns | 29.64 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 20.19 ns | 0.0129 ns | 0.0121 ns | 20.19 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 29.62 ns | 0.0226 ns | 0.0212 ns | 29.63 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 16.14 ns | 0.0027 ns | 0.0021 ns | 16.14 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.90 ns | 0.0050 ns | 0.0036 ns | 18.90 ns |      - |       0 B |
                                            From_SByte | 14.94 ns | 0.0121 ns | 0.0107 ns | 14.94 ns |      - |       0 B |
                                   From_SByte_AsObject | 28.82 ns | 0.0059 ns | 0.0043 ns | 28.82 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 17.78 ns | 0.0119 ns | 0.0105 ns | 17.79 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 28.82 ns | 0.0159 ns | 0.0141 ns | 28.83 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.06 ns | 0.0131 ns | 0.0122 ns | 15.06 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.86 ns | 0.0036 ns | 0.0028 ns | 17.86 ns |      - |       0 B |
                                            From_Float | 14.66 ns | 0.0120 ns | 0.0112 ns | 14.66 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 15.43 ns | 0.0131 ns | 0.0122 ns | 15.43 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.52 ns | 0.0124 ns | 0.0110 ns | 14.51 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 18.46 ns | 0.0130 ns | 0.0115 ns | 18.46 ns |      - |       0 B |
                                           From_String | 18.21 ns | 0.0135 ns | 0.0127 ns | 18.21 ns |      - |       0 B |
                                  From_String_AsObject | 28.01 ns | 0.0288 ns | 0.0255 ns | 28.01 ns |      - |       0 B |
                                      From_String_Null | 17.15 ns | 0.0090 ns | 0.0084 ns | 17.16 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.92 ns | 0.0059 ns | 0.0046 ns | 17.92 ns |      - |       0 B |
                                     From_String_Empty | 18.44 ns | 0.0094 ns | 0.0088 ns | 18.44 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.44 ns | 0.0114 ns | 0.0107 ns | 14.44 ns |      - |       0 B |
                                  From_UShort_AsObject | 28.30 ns | 0.0165 ns | 0.0138 ns | 28.30 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 17.64 ns | 0.0224 ns | 0.0198 ns | 17.64 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 28.28 ns | 0.0105 ns | 0.0098 ns | 28.27 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 15.06 ns | 0.0163 ns | 0.0152 ns | 15.05 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 18.02 ns | 0.0115 ns | 0.0102 ns | 18.02 ns |      - |       0 B |
                                             From_UInt | 15.21 ns | 0.0154 ns | 0.0144 ns | 15.21 ns |      - |       0 B |
                                    From_UInt_AsObject | 28.81 ns | 0.0224 ns | 0.0209 ns | 28.83 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.83 ns | 0.0129 ns | 0.0101 ns | 17.83 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 28.81 ns | 0.0252 ns | 0.0235 ns | 28.80 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 15.08 ns | 0.0114 ns | 0.0095 ns | 15.08 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.90 ns | 0.0095 ns | 0.0089 ns | 17.90 ns |      - |       0 B |
                                            From_ULong | 15.75 ns | 0.0109 ns | 0.0096 ns | 15.75 ns |      - |       0 B |
                                   From_ULong_AsObject | 29.34 ns | 0.0205 ns | 0.0192 ns | 29.33 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 19.66 ns | 0.0083 ns | 0.0078 ns | 19.66 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 29.34 ns | 0.0193 ns | 0.0181 ns | 29.33 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 16.17 ns | 0.0068 ns | 0.0060 ns | 16.17 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.84 ns | 0.0103 ns | 0.0096 ns | 17.84 ns |      - |       0 B |
                                       From_NullObject | 17.85 ns | 0.0165 ns | 0.0154 ns | 17.85 ns |      - |       0 B |
                                           From_DBNull | 16.19 ns | 0.0112 ns | 0.0105 ns | 16.19 ns |      - |       0 B |
                                 From_ConvertibleClass | 26.26 ns | 0.0375 ns | 0.0351 ns | 26.27 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 26.09 ns | 0.0133 ns | 0.0124 ns | 26.09 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 20.53 ns | 0.0086 ns | 0.0080 ns | 20.53 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.38 ns | 0.0030 ns | 0.0025 ns | 18.38 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.95 ns | 0.0135 ns | 0.0126 ns | 16.94 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 23.14 ns | 0.0095 ns | 0.0084 ns | 23.14 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.93 ns | 0.0072 ns | 0.0060 ns | 16.93 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.42 ns | 0.0079 ns | 0.0070 ns | 18.42 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.62 ns | 0.0095 ns | 0.0089 ns | 23.62 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 27.44 ns | 0.0110 ns | 0.0103 ns | 27.43 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.82 ns | 0.0071 ns | 0.0059 ns | 26.82 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.45 ns | 0.0204 ns | 0.0191 ns | 27.44 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 15.97 ns | 0.0060 ns | 0.0054 ns | 15.97 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.02 ns | 0.0058 ns | 0.0051 ns | 18.02 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.72 ns | 0.0139 ns | 0.0130 ns | 14.71 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 24.18 ns | 0.0149 ns | 0.0132 ns | 24.17 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.21 ns | 0.0040 ns | 0.0033 ns | 15.21 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 24.07 ns | 0.0200 ns | 0.0187 ns | 24.06 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.70 ns | 0.0123 ns | 0.0109 ns | 14.70 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.38 ns | 0.0131 ns | 0.0122 ns | 18.38 ns |      - |       0 B |
                                             From_Enum | 16.29 ns | 0.0050 ns | 0.0044 ns | 16.29 ns |      - |       0 B |
                                    From_Enum_AsObject | 62.70 ns | 0.0505 ns | 0.0472 ns | 62.72 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 19.54 ns | 0.0147 ns | 0.0131 ns | 19.54 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 62.68 ns | 0.0447 ns | 0.0418 ns | 62.67 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 17.17 ns | 0.0269 ns | 0.0252 ns | 17.17 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.74 ns | 0.0118 ns | 0.0104 ns | 18.74 ns |      - |       0 B |
                                      From_ParentClass | 17.11 ns | 0.1658 ns | 0.1470 ns | 17.08 ns |      - |       0 B |
                             From_ParentClass_AsObject | 23.79 ns | 0.0701 ns | 0.0621 ns | 23.77 ns |      - |       0 B |
                              From_ParentClass_NoValue | 19.04 ns | 0.0078 ns | 0.0069 ns | 19.04 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.02 ns | 0.0219 ns | 0.0194 ns | 18.01 ns |      - |       0 B |
                                     From_ParentStruct | 14.44 ns | 0.0081 ns | 0.0072 ns | 14.43 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 23.69 ns | 0.0224 ns | 0.0209 ns | 23.69 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.67 ns | 0.0036 ns | 0.0030 ns | 14.66 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 24.83 ns | 0.0099 ns | 0.0088 ns | 24.83 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 15.03 ns | 0.3413 ns | 0.5702 ns | 14.75 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 19.01 ns | 0.0221 ns | 0.0185 ns | 19.01 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_CharNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_CharNullable.From_String_Empty_AsObject: DefaultJob
