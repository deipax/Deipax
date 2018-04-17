
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.52 ns | 0.0212 ns | 0.0177 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 17.60 ns | 0.0131 ns | 0.0110 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 14.44 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.83 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
                                             From_Byte | 14.68 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                                    From_Byte_AsObject | 28.25 ns | 0.0175 ns | 0.0146 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.87 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 28.25 ns | 0.0059 ns | 0.0050 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.62 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 19.19 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                             From_Char | 14.62 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                                    From_Char_AsObject | 29.88 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 13.99 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 29.44 ns | 0.0294 ns | 0.0260 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.85 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 19.20 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                         From_DateTime | 14.92 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 16.18 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.09 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.85 ns | 0.0142 ns | 0.0132 ns |      - |       0 B |
                                          From_Decimal | 15.09 ns | 0.1348 ns | 0.1261 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 16.17 ns | 0.0238 ns | 0.0186 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 16.60 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.03 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                                           From_Double | 14.39 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 16.14 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 15.15 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.84 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                                            From_Short | 14.86 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
                                   From_Short_AsObject | 28.81 ns | 0.0194 ns | 0.0182 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.23 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 28.80 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.86 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.88 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                                              From_Int | 16.33 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                                     From_Int_AsObject | 29.61 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 16.71 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 29.61 ns | 0.0247 ns | 0.0231 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.69 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.72 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                             From_Long | 16.35 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                                    From_Long_AsObject | 29.61 ns | 0.0229 ns | 0.0203 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 17.50 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 29.61 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.51 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.38 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                            From_SByte | 14.82 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
                                   From_SByte_AsObject | 28.81 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 15.11 ns | 0.0117 ns | 0.0091 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 28.80 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.06 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.83 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                            From_Float | 14.42 ns | 0.0153 ns | 0.0144 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 16.59 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.42 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.85 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                           From_String | 18.15 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                                  From_String_AsObject | 27.99 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                                      From_String_Null | 19.58 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.34 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
                                     From_String_Empty | 16.60 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.45 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
                                  From_UShort_AsObject | 28.25 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.80 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 28.25 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 16.51 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.85 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                             From_UInt | 15.07 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
                                    From_UInt_AsObject | 28.79 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.22 ns | 0.0015 ns | 0.0011 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 28.80 ns | 0.0293 ns | 0.0274 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.93 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.86 ns | 0.0066 ns | 0.0061 ns |      - |       0 B |
                                            From_ULong | 15.90 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
                                   From_ULong_AsObject | 29.32 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 17.22 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 29.33 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.41 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.83 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                       From_NullObject | 17.82 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                                           From_DBNull | 15.88 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
                                 From_ConvertibleClass | 27.47 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 26.08 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.96 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.56 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.97 ns | 0.0029 ns | 0.0019 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 23.11 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.94 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.48 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                From_ConvertibleStruct | 24.15 ns | 0.0040 ns | 0.0031 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 27.42 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 27.04 ns | 0.0043 ns | 0.0038 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.42 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 16.13 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.44 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.39 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 23.09 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.41 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.12 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 16.18 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.46 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
                                             From_Enum | 16.13 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                                    From_Enum_AsObject | 62.64 ns | 0.0509 ns | 0.0476 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 18.89 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 62.40 ns | 0.0438 ns | 0.0410 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 15.10 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.96 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                                      From_ParentClass | 17.03 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                             From_ParentClass_AsObject | 23.70 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                              From_ParentClass_NoValue | 16.94 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.02 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                     From_ParentStruct | 15.62 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 24.78 ns | 0.0256 ns | 0.0239 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.81 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 29.57 ns | 0.0031 ns | 0.0025 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.48 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.82 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |

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
