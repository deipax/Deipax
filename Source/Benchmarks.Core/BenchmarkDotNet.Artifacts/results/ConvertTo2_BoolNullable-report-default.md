
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.95 ns | 0.0239 ns | 0.0187 ns |      - |       0 B |
                                 From_Bool_AsObject | 28.69 ns | 0.0544 ns | 0.0482 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 13.42 ns | 0.0207 ns | 0.0162 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 28.86 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.17 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 18.41 ns | 0.0320 ns | 0.0300 ns |      - |       0 B |
                                          From_Byte | 13.98 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                 From_Byte_AsObject | 27.89 ns | 0.0094 ns | 0.0087 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 18.12 ns | 0.0262 ns | 0.0232 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 27.86 ns | 0.0401 ns | 0.0375 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 15.30 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 18.36 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                                          From_Char | 13.84 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                                 From_Char_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Char_Nullable_WithValue | 15.42 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Char_Nullable_NoValue | 13.92 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.89 ns | 0.0457 ns | 0.0405 ns |      - |       0 B |
                                      From_DateTime | 14.21 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.21 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 15.09 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 18.05 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                       From_Decimal | 23.48 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                              From_Decimal_AsObject | 39.71 ns | 0.0689 ns | 0.0645 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 27.86 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 39.22 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 17.27 ns | 0.0227 ns | 0.0189 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.72 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                        From_Double | 14.06 ns | 0.0058 ns | 0.0038 ns |      - |       0 B |
                               From_Double_AsObject | 27.83 ns | 0.0111 ns | 0.0093 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 19.23 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 27.85 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 16.35 ns | 0.0098 ns | 0.0077 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.81 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
                                         From_Short | 13.93 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                                From_Short_AsObject | 28.61 ns | 0.0143 ns | 0.0119 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 18.64 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 27.60 ns | 0.0287 ns | 0.0269 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.31 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 18.64 ns | 0.0049 ns | 0.0038 ns |      - |       0 B |
                                           From_Int | 14.87 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                  From_Int_AsObject | 27.96 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.98 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 27.88 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 15.33 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.87 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
                                          From_Long | 14.16 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                 From_Long_AsObject | 27.65 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 17.43 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 27.57 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.30 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.78 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                                         From_SByte | 15.07 ns | 0.0120 ns | 0.0113 ns |      - |       0 B |
                                From_SByte_AsObject | 27.57 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 17.98 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 27.56 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.27 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.88 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
                                         From_Float | 16.20 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
                                From_Float_AsObject | 27.60 ns | 0.0435 ns | 0.0385 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 18.24 ns | 0.0258 ns | 0.0242 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 27.61 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 15.24 ns | 0.0112 ns | 0.0100 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.88 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                                        From_String | 34.42 ns | 0.0799 ns | 0.0747 ns |      - |       0 B |
                               From_String_AsObject | 46.32 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
                                   From_String_Null | 16.31 ns | 0.0129 ns | 0.0107 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.88 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
                                  From_String_Empty | 16.52 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 14.97 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
                               From_UShort_AsObject | 28.63 ns | 0.0423 ns | 0.0396 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.96 ns | 0.0118 ns | 0.0105 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 27.57 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.25 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.72 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                          From_UInt | 14.96 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                 From_UInt_AsObject | 27.60 ns | 0.0494 ns | 0.0412 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 18.24 ns | 0.0369 ns | 0.0327 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 27.57 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 15.23 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.75 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
                                         From_ULong | 13.90 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                From_ULong_AsObject | 27.57 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.24 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 27.57 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 17.92 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.76 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                                    From_NullObject | 17.86 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                                        From_DBNull | 16.92 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                              From_ConvertibleClass | 24.29 ns | 0.0089 ns | 0.0069 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 25.26 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.88 ns | 0.0105 ns | 0.0093 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 19.22 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                             From_ConvertibleStruct | 23.22 ns | 0.0125 ns | 0.0117 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 26.60 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 26.27 ns | 0.0395 ns | 0.0369 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 26.61 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 15.25 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.02 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                                          From_Enum | 13.93 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
                                 From_Enum_AsObject | 59.65 ns | 0.0686 ns | 0.0642 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 18.26 ns | 0.0365 ns | 0.0323 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 59.91 ns | 0.0120 ns | 0.0094 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 14.27 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 18.00 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_String_Empty_AsObject: DefaultJob
