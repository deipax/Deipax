
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.83 ns | 0.1530 ns | 0.1431 ns |      - |       0 B |
                                    From_Bool_AsObject | 25.60 ns | 0.0505 ns | 0.0422 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 19.03 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 25.58 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.67 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.36 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                                             From_Byte | 14.12 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                                    From_Byte_AsObject | 25.58 ns | 0.0247 ns | 0.0207 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 16.82 ns | 0.0042 ns | 0.0033 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.58 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.94 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.35 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                             From_Char | 14.12 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                                    From_Char_AsObject | 26.41 ns | 0.0447 ns | 0.0397 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 18.72 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 26.39 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 15.87 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.84 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                         From_DateTime | 14.60 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 16.02 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.86 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.36 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
                                          From_Decimal | 25.68 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
                                 From_Decimal_AsObject | 35.88 ns | 0.0368 ns | 0.0344 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 34.85 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.11 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 16.14 ns | 0.0134 ns | 0.0126 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.35 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                                           From_Double | 16.02 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
                                  From_Double_AsObject | 27.24 ns | 0.0289 ns | 0.0270 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.94 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 27.21 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 16.17 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.42 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                                            From_Short | 14.38 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
                                   From_Short_AsObject | 26.11 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.00 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.10 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.95 ns | 0.0286 ns | 0.0268 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.85 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                                              From_Int | 14.66 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                                     From_Int_AsObject | 26.12 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 17.49 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 26.12 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.68 ns | 0.0205 ns | 0.0171 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.88 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                                             From_Long | 15.28 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                    From_Long_AsObject | 26.93 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 19.64 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 26.94 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.91 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.35 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
                                            From_SByte | 14.39 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.11 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 17.15 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.10 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 17.28 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.37 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                            From_Float | 16.01 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
                                   From_Float_AsObject | 27.47 ns | 0.0054 ns | 0.0043 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 19.52 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 27.46 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.93 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.35 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
                                           From_String | 88.91 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                                  From_String_AsObject | 99.29 ns | 0.0355 ns | 0.0332 ns |      - |       0 B |
                                      From_String_Null | 15.59 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.34 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
                                     From_String_Empty | 16.15 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.38 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.56 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 16.82 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.72 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.67 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.38 ns | 0.0079 ns | 0.0062 ns |      - |       0 B |
                                             From_UInt | 14.14 ns | 0.0076 ns | 0.0064 ns |      - |       0 B |
                                    From_UInt_AsObject | 17.84 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.70 ns | 0.0081 ns | 0.0071 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 17.82 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.44 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.84 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
                                            From_ULong | 14.42 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.30 ns | 0.0198 ns | 0.0175 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 18.57 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.29 ns | 0.0134 ns | 0.0105 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 16.17 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.35 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                       From_NullObject | 17.34 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                           From_DBNull | 15.06 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                 From_ConvertibleClass | 23.97 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 23.40 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.84 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.41 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.84 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 22.70 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 15.82 ns | 0.0050 ns | 0.0041 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.34 ns | 0.0029 ns | 0.0027 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.58 ns | 0.0033 ns | 0.0029 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 24.75 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.72 ns | 0.0101 ns | 0.0090 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.74 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.95 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.35 ns | 0.0051 ns | 0.0046 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.15 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 21.63 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.87 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.56 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.87 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.34 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
                                             From_Enum | 14.65 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
                                    From_Enum_AsObject | 58.25 ns | 0.0232 ns | 0.0194 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 17.42 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 58.25 ns | 0.0088 ns | 0.0082 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.67 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.35 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
                                      From_ParentClass | 15.90 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.11 ns | 0.0033 ns | 0.0025 ns |      - |       0 B |
                              From_ParentClass_NoValue | 16.02 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 20.92 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                                     From_ParentStruct | 14.16 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 22.35 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 13.89 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.18 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 13.89 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.48 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UInt.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UInt.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UInt.From_String_Empty_AsObject: DefaultJob
