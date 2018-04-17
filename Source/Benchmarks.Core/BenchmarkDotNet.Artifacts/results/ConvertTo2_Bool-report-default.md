
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 14.19 ns | 0.0568 ns | 0.0474 ns | 14.17 ns |      - |       0 B |
                                    From_Bool_AsObject | 17.83 ns | 0.0185 ns | 0.0155 ns | 17.82 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.51 ns | 0.0018 ns | 0.0014 ns | 14.51 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 17.81 ns | 0.0106 ns | 0.0094 ns | 17.81 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.55 ns | 0.0153 ns | 0.0136 ns | 14.55 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.30 ns | 0.0174 ns | 0.0145 ns | 17.29 ns |      - |       0 B |
                                             From_Byte | 14.04 ns | 0.0764 ns | 0.0638 ns | 14.01 ns |      - |       0 B |
                                    From_Byte_AsObject | 27.20 ns | 0.2214 ns | 0.1849 ns | 27.13 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.94 ns | 0.1647 ns | 0.1375 ns | 14.86 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 27.61 ns | 0.5075 ns | 0.4499 ns | 27.39 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.50 ns | 0.1538 ns | 0.1439 ns | 14.44 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.22 ns | 0.0030 ns | 0.0025 ns | 17.22 ns |      - |       0 B |
                                             From_Char | 14.00 ns | 0.0183 ns | 0.0143 ns | 14.01 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 13.99 ns | 0.0071 ns | 0.0047 ns | 13.99 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 14.00 ns | 0.0125 ns | 0.0097 ns | 14.00 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.90 ns | 0.0079 ns | 0.0074 ns | 17.89 ns |      - |       0 B |
                                         From_DateTime | 14.55 ns | 0.0299 ns | 0.0265 ns | 14.54 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.85 ns | 0.0106 ns | 0.0099 ns | 14.85 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.86 ns | 0.0287 ns | 0.0239 ns | 14.85 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.27 ns | 0.0110 ns | 0.0092 ns | 17.26 ns |      - |       0 B |
                                          From_Decimal | 24.51 ns | 0.0330 ns | 0.0275 ns | 24.51 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.66 ns | 0.0309 ns | 0.0289 ns | 36.65 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 26.15 ns | 0.0461 ns | 0.0385 ns | 26.15 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.65 ns | 0.0048 ns | 0.0038 ns | 36.65 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 15.34 ns | 0.0106 ns | 0.0088 ns | 15.34 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.28 ns | 0.0101 ns | 0.0095 ns | 17.27 ns |      - |       0 B |
                                           From_Double | 14.22 ns | 0.0178 ns | 0.0158 ns | 14.21 ns |      - |       0 B |
                                  From_Double_AsObject | 25.83 ns | 0.0096 ns | 0.0085 ns | 25.83 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 15.83 ns | 0.0136 ns | 0.0127 ns | 15.83 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 26.17 ns | 0.0149 ns | 0.0132 ns | 26.16 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.10 ns | 0.0042 ns | 0.0035 ns | 15.10 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.90 ns | 0.0103 ns | 0.0096 ns | 18.90 ns |      - |       0 B |
                                            From_Short | 14.00 ns | 0.0131 ns | 0.0116 ns | 13.99 ns |      - |       0 B |
                                   From_Short_AsObject | 25.56 ns | 0.0032 ns | 0.0028 ns | 25.56 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.80 ns | 0.0030 ns | 0.0025 ns | 14.80 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 25.56 ns | 0.0077 ns | 0.0068 ns | 25.56 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.40 ns | 0.0133 ns | 0.0118 ns | 14.40 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.41 ns | 0.0167 ns | 0.0156 ns | 17.40 ns |      - |       0 B |
                                              From_Int | 14.14 ns | 0.0021 ns | 0.0018 ns | 14.14 ns |      - |       0 B |
                                     From_Int_AsObject | 25.57 ns | 0.0147 ns | 0.0131 ns | 25.56 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.80 ns | 0.0066 ns | 0.0055 ns | 14.80 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 25.59 ns | 0.0319 ns | 0.0298 ns | 25.58 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.21 ns | 0.0112 ns | 0.0105 ns | 14.21 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.76 ns | 0.0060 ns | 0.0053 ns | 17.76 ns |      - |       0 B |
                                             From_Long | 14.15 ns | 0.0139 ns | 0.0130 ns | 14.14 ns |      - |       0 B |
                                    From_Long_AsObject | 25.60 ns | 0.0154 ns | 0.0111 ns | 25.60 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 15.76 ns | 0.0107 ns | 0.0100 ns | 15.76 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 25.58 ns | 0.0078 ns | 0.0069 ns | 25.58 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.96 ns | 0.0095 ns | 0.0089 ns | 14.97 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.27 ns | 0.0108 ns | 0.0101 ns | 17.27 ns |      - |       0 B |
                                            From_SByte | 14.00 ns | 0.0110 ns | 0.0103 ns | 13.99 ns |      - |       0 B |
                                   From_SByte_AsObject | 25.59 ns | 0.0106 ns | 0.0094 ns | 25.59 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.81 ns | 0.0124 ns | 0.0110 ns | 14.81 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.62 ns | 0.0545 ns | 0.0510 ns | 25.63 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.41 ns | 0.0113 ns | 0.0105 ns | 14.41 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.27 ns | 0.0090 ns | 0.0084 ns | 17.28 ns |      - |       0 B |
                                            From_Float | 14.22 ns | 0.0121 ns | 0.0114 ns | 14.23 ns |      - |       0 B |
                                   From_Float_AsObject | 26.66 ns | 0.0228 ns | 0.0213 ns | 26.65 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 16.86 ns | 0.0241 ns | 0.0226 ns | 16.86 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 29.65 ns | 0.0080 ns | 0.0075 ns | 29.65 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.40 ns | 0.0137 ns | 0.0114 ns | 14.40 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.28 ns | 0.0023 ns | 0.0020 ns | 17.28 ns |      - |       0 B |
                                           From_String | 34.54 ns | 0.0641 ns | 0.0600 ns | 34.53 ns |      - |       0 B |
                                  From_String_AsObject | 46.20 ns | 0.1142 ns | 0.1068 ns | 46.20 ns |      - |       0 B |
                                      From_String_Null | 15.49 ns | 0.0020 ns | 0.0015 ns | 15.49 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.25 ns | 0.0078 ns | 0.0065 ns | 17.25 ns |      - |       0 B |
                                     From_String_Empty | 16.77 ns | 0.0324 ns | 0.0304 ns | 16.77 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.14 ns | 0.0028 ns | 0.0023 ns | 14.14 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.56 ns | 0.0036 ns | 0.0028 ns | 25.56 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.81 ns | 0.0102 ns | 0.0096 ns | 14.81 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.58 ns | 0.0199 ns | 0.0186 ns | 25.58 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.21 ns | 0.0097 ns | 0.0091 ns | 14.21 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.25 ns | 0.0021 ns | 0.0018 ns | 17.25 ns |      - |       0 B |
                                             From_UInt | 15.46 ns | 0.0074 ns | 0.0065 ns | 15.46 ns |      - |       0 B |
                                    From_UInt_AsObject | 25.56 ns | 0.0032 ns | 0.0027 ns | 25.56 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.80 ns | 0.0076 ns | 0.0071 ns | 14.80 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.56 ns | 0.0069 ns | 0.0057 ns | 25.56 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.39 ns | 0.0013 ns | 0.0010 ns | 14.39 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.31 ns | 0.0027 ns | 0.0021 ns | 17.31 ns |      - |       0 B |
                                            From_ULong | 13.99 ns | 0.0010 ns | 0.0008 ns | 13.99 ns |      - |       0 B |
                                   From_ULong_AsObject | 26.64 ns | 0.0174 ns | 0.0163 ns | 26.63 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.67 ns | 0.0018 ns | 0.0014 ns | 15.67 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 26.59 ns | 0.0232 ns | 0.0217 ns | 26.58 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 15.10 ns | 0.0018 ns | 0.0016 ns | 15.10 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.28 ns | 0.0141 ns | 0.0132 ns | 17.28 ns |      - |       0 B |
                                       From_NullObject | 17.26 ns | 0.0042 ns | 0.0035 ns | 17.26 ns |      - |       0 B |
                                           From_DBNull | 15.05 ns | 0.0015 ns | 0.0014 ns | 15.05 ns |      - |       0 B |
                                 From_ConvertibleClass | 25.40 ns | 0.0098 ns | 0.0082 ns | 25.39 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 25.29 ns | 0.0115 ns | 0.0096 ns | 25.29 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 19.02 ns | 0.0237 ns | 0.0221 ns | 19.03 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.33 ns | 0.0161 ns | 0.0143 ns | 17.33 ns |      - |       0 B |
                              From_NonConvertibleClass | 15.93 ns | 0.0075 ns | 0.0071 ns | 15.93 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 21.65 ns | 0.0104 ns | 0.0097 ns | 21.64 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.80 ns | 0.0122 ns | 0.0108 ns | 16.79 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.26 ns | 0.0016 ns | 0.0014 ns | 17.26 ns |      - |       0 B |
                                From_ConvertibleStruct | 23.90 ns | 0.0276 ns | 0.0216 ns | 23.89 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 24.81 ns | 0.0388 ns | 0.0363 ns | 24.81 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 26.55 ns | 0.0069 ns | 0.0061 ns | 26.55 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.75 ns | 0.0154 ns | 0.0144 ns | 24.74 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 16.59 ns | 0.0030 ns | 0.0027 ns | 16.59 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.26 ns | 0.0166 ns | 0.0148 ns | 17.26 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.00 ns | 0.0105 ns | 0.0098 ns | 13.99 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 23.95 ns | 0.0095 ns | 0.0089 ns | 23.95 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 13.99 ns | 0.0013 ns | 0.0010 ns | 13.99 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 21.58 ns | 0.0108 ns | 0.0096 ns | 21.58 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 13.99 ns | 0.0089 ns | 0.0083 ns | 13.99 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.26 ns | 0.0167 ns | 0.0156 ns | 17.26 ns |      - |       0 B |
                                             From_Enum | 14.13 ns | 0.0019 ns | 0.0017 ns | 14.13 ns |      - |       0 B |
                                    From_Enum_AsObject | 58.40 ns | 0.0112 ns | 0.0088 ns | 58.40 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 16.93 ns | 0.0027 ns | 0.0021 ns | 16.93 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 58.37 ns | 0.0118 ns | 0.0105 ns | 58.37 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 14.80 ns | 0.0132 ns | 0.0124 ns | 14.80 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.78 ns | 0.0104 ns | 0.0097 ns | 17.78 ns |      - |       0 B |
                                      From_ParentClass | 15.84 ns | 0.0085 ns | 0.0079 ns | 15.83 ns |      - |       0 B |
                             From_ParentClass_AsObject | 23.52 ns | 0.0131 ns | 0.0123 ns | 23.53 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.90 ns | 0.0161 ns | 0.0151 ns | 15.90 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.27 ns | 0.0097 ns | 0.0091 ns | 17.28 ns |      - |       0 B |
                                     From_ParentStruct | 14.00 ns | 0.0105 ns | 0.0093 ns | 14.00 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 23.58 ns | 0.0101 ns | 0.0090 ns | 23.58 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.59 ns | 0.0181 ns | 0.0169 ns | 14.59 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 22.46 ns | 0.0141 ns | 0.0132 ns | 22.46 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.00 ns | 0.0050 ns | 0.0047 ns | 14.00 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.16 ns | 0.0123 ns | 0.0115 ns | 18.16 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_String_Empty_AsObject: DefaultJob
