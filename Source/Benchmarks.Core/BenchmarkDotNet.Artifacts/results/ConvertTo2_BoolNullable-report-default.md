
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.50 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                                    From_Bool_AsObject | 29.34 ns | 0.0833 ns | 0.0779 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 13.99 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 29.52 ns | 0.0347 ns | 0.0271 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.00 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.89 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                                             From_Byte | 14.80 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                                    From_Byte_AsObject | 29.47 ns | 0.0338 ns | 0.0300 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 15.00 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 29.47 ns | 0.0254 ns | 0.0225 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.61 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.88 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                             From_Char | 15.35 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 18.09 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 14.39 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.85 ns | 0.0168 ns | 0.0131 ns |      - |       0 B |
                                         From_DateTime | 15.02 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 15.07 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.07 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.89 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
                                          From_Decimal | 24.75 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
                                 From_Decimal_AsObject | 44.04 ns | 0.0205 ns | 0.0181 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 26.65 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 38.91 ns | 0.0320 ns | 0.0283 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.68 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 18.04 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                           From_Double | 14.68 ns | 0.0051 ns | 0.0043 ns |      - |       0 B |
                                  From_Double_AsObject | 29.23 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 16.10 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 29.48 ns | 0.0088 ns | 0.0069 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.50 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.87 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
                                            From_Short | 14.57 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                                   From_Short_AsObject | 29.21 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.03 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 29.23 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.61 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.91 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
                                              From_Int | 14.71 ns | 0.0106 ns | 0.0100 ns |      - |       0 B |
                                     From_Int_AsObject | 28.91 ns | 0.0284 ns | 0.0252 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 18.09 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 28.72 ns | 0.0365 ns | 0.0341 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.61 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 18.27 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                             From_Long | 24.45 ns | 0.0018 ns | 0.0013 ns |      - |       0 B |
                                    From_Long_AsObject | 29.21 ns | 0.0246 ns | 0.0218 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 15.98 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 29.21 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.42 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.87 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                            From_SByte | 14.57 ns | 0.0160 ns | 0.0133 ns |      - |       0 B |
                                   From_SByte_AsObject | 29.20 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.98 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 28.93 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.58 ns | 0.0039 ns | 0.0031 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 18.57 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                            From_Float | 14.81 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                                   From_Float_AsObject | 28.95 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 15.32 ns | 0.0253 ns | 0.0224 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 28.95 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.56 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.89 ns | 0.0112 ns | 0.0104 ns |      - |       0 B |
                                           From_String | 35.33 ns | 0.0791 ns | 0.0701 ns |      - |       0 B |
                                  From_String_AsObject | 48.08 ns | 0.0233 ns | 0.0206 ns |      - |       0 B |
                                      From_String_Null | 16.21 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.86 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                     From_String_Empty | 16.70 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.67 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
                                  From_UShort_AsObject | 29.19 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.98 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 29.21 ns | 0.0417 ns | 0.0348 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.56 ns | 0.0165 ns | 0.0155 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.87 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                                             From_UInt | 15.64 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                                    From_UInt_AsObject | 28.95 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 15.78 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 29.21 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.58 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 18.90 ns | 0.0152 ns | 0.0127 ns |      - |       0 B |
                                            From_ULong | 14.74 ns | 0.1980 ns | 0.1852 ns |      - |       0 B |
                                   From_ULong_AsObject | 29.22 ns | 0.0267 ns | 0.0223 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.87 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 28.94 ns | 0.0286 ns | 0.0268 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.50 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 18.48 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
                                       From_NullObject | 17.85 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                           From_DBNull | 16.02 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                                 From_ConvertibleClass | 25.94 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 25.81 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.81 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 18.07 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                              From_NonConvertibleClass | 17.60 ns | 0.0151 ns | 0.0142 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 26.38 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.88 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.03 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
                                From_ConvertibleStruct | 24.13 ns | 0.0145 ns | 0.0129 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 27.16 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.58 ns | 0.0169 ns | 0.0158 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 27.16 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 16.10 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.39 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.42 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 23.39 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.40 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 23.83 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.43 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 18.42 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                                             From_Enum | 14.66 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                    From_Enum_AsObject | 61.96 ns | 0.0098 ns | 0.0087 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 19.01 ns | 0.0319 ns | 0.0283 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 62.47 ns | 0.0452 ns | 0.0400 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 15.08 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.05 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
                                      From_ParentClass | 17.48 ns | 0.0162 ns | 0.0127 ns |      - |       0 B |
                             From_ParentClass_AsObject | 23.90 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.86 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 18.36 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
                                     From_ParentStruct | 14.41 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 23.92 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 16.13 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 24.13 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.40 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.50 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_String_Empty_AsObject: DefaultJob
