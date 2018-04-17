
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 14.07 ns | 0.0627 ns | 0.0556 ns |      - |       0 B |
                                    From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue | 14.00 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue | 14.00 ns | 0.0135 ns | 0.0113 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.34 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                                             From_Byte | 14.00 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                    From_Byte_AsObject | 26.06 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.80 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 25.85 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.21 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.32 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                             From_Char | 13.99 ns | 0.0081 ns | 0.0071 ns |      - |       0 B |
                                    From_Char_AsObject | 17.78 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 15.24 ns | 0.0151 ns | 0.0142 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject | 17.82 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.54 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.34 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                                         From_DateTime | 14.54 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.96 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.97 ns | 0.0138 ns | 0.0115 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.33 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
                                          From_Decimal | 14.88 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                                 From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue | 15.36 ns | 0.0152 ns | 0.0135 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue | 15.35 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.34 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                           From_Double | 14.01 ns | 0.0061 ns | 0.0048 ns |      - |       0 B |
                                  From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue | 14.88 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue | 15.72 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.40 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                            From_Short | 14.54 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
                                   From_Short_AsObject | 26.38 ns | 0.0192 ns | 0.0170 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 15.39 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 26.60 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.22 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.38 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                                              From_Int | 15.34 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
                                     From_Int_AsObject | 27.18 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 16.68 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 27.19 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.40 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.34 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                             From_Long | 15.73 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                                    From_Long_AsObject | 27.18 ns | 0.0145 ns | 0.0135 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 17.76 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 27.19 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.10 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.33 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
                                            From_SByte | 14.70 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.37 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 15.35 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 26.37 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.39 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.33 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                                            From_Float | 14.00 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                                   From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue | 14.01 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue | 14.00 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.34 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                           From_String | 16.87 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                  From_String_AsObject | 25.63 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
                                      From_String_Null | 15.71 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.34 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
                                     From_String_Empty | 15.74 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 14.00 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.84 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.82 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.83 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.41 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.34 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                             From_UInt | 14.71 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
                                    From_UInt_AsObject | 26.38 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 16.55 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 26.38 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.23 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.39 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                                            From_ULong | 15.08 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.92 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 17.24 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.91 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.96 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.34 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                                       From_NullObject | 17.33 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                                           From_DBNull | 20.78 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
                                 From_ConvertibleClass | 24.22 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 23.66 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 19.28 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.38 ns | 0.0094 ns | 0.0087 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.96 ns | 0.0084 ns | 0.0065 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 23.45 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.52 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.04 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.92 ns | 0.0180 ns | 0.0159 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.04 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.59 ns | 0.0144 ns | 0.0135 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 25.03 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.81 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.35 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.00 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 21.65 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 14.00 ns | 0.0102 ns | 0.0096 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.62 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.00 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.36 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
                                             From_Enum | 15.33 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                    From_Enum_AsObject | 59.28 ns | 0.0600 ns | 0.0562 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 18.83 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 59.69 ns | 0.0337 ns | 0.0299 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.80 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 20.14 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                                      From_ParentClass | 16.02 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
                             From_ParentClass_AsObject | 22.15 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
                              From_ParentClass_NoValue | 16.01 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.54 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
                                     From_ParentStruct | 14.76 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 22.16 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.01 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.21 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.00 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.34 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |

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
