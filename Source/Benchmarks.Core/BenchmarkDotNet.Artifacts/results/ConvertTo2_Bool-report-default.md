
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.15 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
                                    From_Bool_AsObject | 16.47 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 13.79 ns | 0.0100 ns | 0.0088 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 17.69 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.67 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 15.96 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                                             From_Byte | 13.40 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                    From_Byte_AsObject | 23.75 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.39 ns | 0.3185 ns | 0.4028 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 23.39 ns | 0.3902 ns | 0.3650 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.35 ns | 0.3175 ns | 0.4347 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 16.36 ns | 0.2909 ns | 0.2579 ns |      - |       0 B |
                                             From_Char | 14.16 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 13.39 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 13.13 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 16.02 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                         From_DateTime | 13.27 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.27 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.27 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 15.99 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                          From_Decimal | 23.74 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
                                 From_Decimal_AsObject | 32.88 ns | 0.0135 ns | 0.0105 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 24.50 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 32.17 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.29 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 15.88 ns | 0.0086 ns | 0.0076 ns |      - |       0 B |
                                           From_Double | 13.71 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                                  From_Double_AsObject | 22.99 ns | 0.0284 ns | 0.0252 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 15.07 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 22.97 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 14.31 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 16.00 ns | 0.0098 ns | 0.0091 ns |      - |       0 B |
                                            From_Short | 13.43 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                                   From_Short_AsObject | 22.72 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 13.82 ns | 0.0050 ns | 0.0044 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 23.76 ns | 0.0263 ns | 0.0234 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.40 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.06 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                              From_Int | 13.14 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                     From_Int_AsObject | 22.74 ns | 0.0298 ns | 0.0279 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 13.82 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 23.77 ns | 0.0262 ns | 0.0245 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.01 ns | 0.0190 ns | 0.0169 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 15.86 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                                             From_Long | 13.17 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
                                    From_Long_AsObject | 22.72 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 15.08 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 22.72 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.33 ns | 0.0086 ns | 0.0067 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 18.15 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
                                            From_SByte | 13.41 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                                   From_SByte_AsObject | 23.73 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 13.78 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 22.73 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.40 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 15.87 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                            From_Float | 13.68 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
                                   From_Float_AsObject | 23.78 ns | 0.0632 ns | 0.0528 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 13.92 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 22.73 ns | 0.0239 ns | 0.0212 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.40 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.01 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
                                           From_String | 32.79 ns | 0.0672 ns | 0.0628 ns |      - |       0 B |
                                  From_String_AsObject | 39.37 ns | 0.0958 ns | 0.0800 ns |      - |       0 B |
                                      From_String_Null | 14.54 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.12 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                     From_String_Empty | 15.35 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.17 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                  From_UShort_AsObject | 22.71 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 13.79 ns | 0.0203 ns | 0.0170 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 23.75 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.65 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.01 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                                             From_UInt | 13.40 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                                    From_UInt_AsObject | 23.74 ns | 0.0116 ns | 0.0090 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 13.78 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 22.72 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.40 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 15.99 ns | 0.0056 ns | 0.0046 ns |      - |       0 B |
                                            From_ULong | 13.40 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                   From_ULong_AsObject | 23.75 ns | 0.0057 ns | 0.0045 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.38 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 22.72 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.31 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 15.86 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                                       From_NullObject | 17.02 ns | 0.0270 ns | 0.0252 ns |      - |       0 B |
                                           From_DBNull | 15.83 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                  From_DBNull_AsObject | 17.06 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
                                 From_ConvertibleClass | 19.81 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 20.66 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 17.17 ns | 0.0085 ns | 0.0071 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.16 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.88 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 17.87 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.02 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 15.86 ns | 0.0089 ns | 0.0084 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.12 ns | 0.0086 ns | 0.0081 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 21.93 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.38 ns | 0.0039 ns | 0.0036 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 21.93 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 13.75 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.10 ns | 0.0057 ns | 0.0054 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.02 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 18.50 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.16 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 17.89 ns | 0.0261 ns | 0.0231 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.17 ns | 0.0075 ns | 0.0062 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 16.74 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                                             From_Enum | 13.14 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
                                    From_Enum_AsObject | 52.30 ns | 0.0040 ns | 0.0035 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 13.78 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 52.34 ns | 0.0060 ns | 0.0053 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.66 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.03 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                                      From_ParentClass | 14.02 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                             From_ParentClass_AsObject | 20.65 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
                              From_ParentClass_NoValue | 14.29 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.00 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                                     From_ParentStruct | 15.26 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 18.38 ns | 0.0093 ns | 0.0077 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.22 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 18.39 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.16 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.08 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_String_Empty_AsObject: DefaultJob
