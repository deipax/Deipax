
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.60 ns | 0.0442 ns | 0.0413 ns |      - |       0 B |
                                    From_Bool_AsObject |  26.02 ns | 0.0521 ns | 0.0462 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  15.35 ns | 0.0110 ns | 0.0086 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.83 ns | 0.0066 ns | 0.0056 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.42 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.42 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                             From_Byte |  14.01 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.84 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.81 ns | 0.0063 ns | 0.0053 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.84 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  15.66 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.42 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                             From_Char |  13.99 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                                    From_Char_AsObject |  26.65 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  14.80 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.64 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  14.28 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.42 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
                                         From_DateTime |  14.52 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.93 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.93 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.44 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
                                          From_Decimal |  24.72 ns | 0.0191 ns | 0.0160 ns |      - |       0 B |
                                 From_Decimal_AsObject |  35.86 ns | 0.0255 ns | 0.0226 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  27.10 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  35.62 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  15.36 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.42 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                           From_Double |  16.64 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                                  From_Double_AsObject |  27.73 ns | 0.0214 ns | 0.0178 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  19.68 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  27.72 ns | 0.0137 ns | 0.0129 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.95 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  18.35 ns | 0.0096 ns | 0.0089 ns |      - |       0 B |
                                            From_Short |  13.99 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                                   From_Short_AsObject |  25.83 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  14.80 ns | 0.0033 ns | 0.0025 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.83 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.21 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.50 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                              From_Int |  14.90 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
                                     From_Int_AsObject |  17.84 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  14.66 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  18.80 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  14.53 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.42 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
                                             From_Long |  15.59 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                    From_Long_AsObject |  27.43 ns | 0.0485 ns | 0.0430 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  18.02 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  27.37 ns | 0.0451 ns | 0.0421 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  15.11 ns | 0.0242 ns | 0.0202 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.41 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
                                            From_SByte |  13.99 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.83 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  14.81 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.84 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.23 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.44 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
                                            From_Float |  16.63 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                   From_Float_AsObject |  27.99 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  17.51 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  28.01 ns | 0.0257 ns | 0.0241 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  14.22 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.42 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
                                           From_String |  91.92 ns | 0.1164 ns | 0.1089 ns |      - |       0 B |
                                  From_String_AsObject | 102.14 ns | 0.0442 ns | 0.0414 ns |      - |       0 B |
                                      From_String_Null |  15.62 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.58 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                     From_String_Empty |  15.96 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.00 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.95 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  14.81 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.83 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.41 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.88 ns | 0.0094 ns | 0.0087 ns |      - |       0 B |
                                             From_UInt |  14.68 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.38 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  15.35 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.38 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  15.39 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.29 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                            From_ULong |  15.34 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
                                   From_ULong_AsObject |  27.18 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.78 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  27.18 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.03 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.89 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                                       From_NullObject |  17.46 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                           From_DBNull |  15.34 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.26 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.66 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.31 ns | 0.0184 ns | 0.0144 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.49 ns | 0.0114 ns | 0.0106 ns |      - |       0 B |
                              From_NonConvertibleClass |  16.07 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  22.29 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.05 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  17.42 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.87 ns | 0.0080 ns | 0.0071 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  25.01 ns | 0.0117 ns | 0.0098 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.55 ns | 0.0278 ns | 0.0217 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  25.01 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.82 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.00 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.60 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  14.00 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.55 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  14.00 ns | 0.0250 ns | 0.0195 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.42 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                             From_Enum |  13.97 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
                                    From_Enum_AsObject |  59.19 ns | 0.0146 ns | 0.0130 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  16.40 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  59.20 ns | 0.0315 ns | 0.0280 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.80 ns | 0.0106 ns | 0.0100 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.42 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                      From_ParentClass |  16.66 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.14 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.99 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  17.42 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                     From_ParentStruct |  14.01 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.10 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  14.00 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.31 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  14.01 ns | 0.0142 ns | 0.0125 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.43 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Int.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Int.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Int.From_String_Empty_AsObject: DefaultJob
