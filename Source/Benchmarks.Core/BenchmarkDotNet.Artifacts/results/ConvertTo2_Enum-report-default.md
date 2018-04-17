
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 39.51 ns | 0.2167 ns | 0.1692 ns | 39.45 ns | 0.0057 |      24 B |
                                    From_Bool_AsObject | 52.64 ns | 0.1631 ns | 0.1446 ns | 52.60 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 41.70 ns | 0.0260 ns | 0.0243 ns | 41.69 ns | 0.0057 |      24 B |
                 From_Bool_Nullable_WithValue_AsObject | 52.49 ns | 0.0652 ns | 0.0610 ns | 52.48 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.78 ns | 0.0018 ns | 0.0014 ns | 14.78 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.83 ns | 0.0090 ns | 0.0080 ns | 17.83 ns |      - |       0 B |
                                             From_Byte | 38.39 ns | 0.0091 ns | 0.0081 ns | 38.39 ns | 0.0057 |      24 B |
                                    From_Byte_AsObject | 52.95 ns | 0.0579 ns | 0.0542 ns | 52.96 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 41.01 ns | 0.0144 ns | 0.0120 ns | 41.00 ns | 0.0057 |      24 B |
                 From_Byte_Nullable_WithValue_AsObject | 52.81 ns | 0.0758 ns | 0.0709 ns | 52.81 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.78 ns | 0.0017 ns | 0.0013 ns | 14.78 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.35 ns | 0.0145 ns | 0.0135 ns | 17.34 ns |      - |       0 B |
                                             From_Char | 36.53 ns | 0.0186 ns | 0.0155 ns | 36.52 ns | 0.0057 |      24 B |
                                    From_Char_AsObject | 51.90 ns | 1.0508 ns | 1.6359 ns | 50.98 ns |      - |       0 B |
                          From_Char_Nullable_WithValue | 39.79 ns | 0.0320 ns | 0.0300 ns | 39.78 ns | 0.0057 |      24 B |
                 From_Char_Nullable_WithValue_AsObject | 51.07 ns | 0.0903 ns | 0.0800 ns | 51.04 ns |      - |       0 B |
                            From_Char_Nullable_NoValue | 14.78 ns | 0.0056 ns | 0.0046 ns | 14.78 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.33 ns | 0.0160 ns | 0.0150 ns | 17.33 ns |      - |       0 B |
                                         From_DateTime | 36.55 ns | 0.0081 ns | 0.0076 ns | 36.54 ns | 0.0057 |      24 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 40.90 ns | 0.8113 ns | 0.6775 ns | 40.71 ns | 0.0057 |      24 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 15.86 ns | 0.0100 ns | 0.0093 ns | 15.86 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 17.95 ns | 0.0213 ns | 0.0200 ns | 17.94 ns |      - |       0 B |
                                          From_Decimal | 51.88 ns | 0.0242 ns | 0.0214 ns | 51.87 ns | 0.0076 |      32 B |
                                 From_Decimal_AsObject | 65.30 ns | 0.0853 ns | 0.0798 ns | 65.31 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 57.54 ns | 0.0110 ns | 0.0092 ns | 57.55 ns | 0.0076 |      32 B |
              From_Decimal_Nullable_WithValue_AsObject | 65.57 ns | 0.0848 ns | 0.0793 ns | 65.55 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 16.46 ns | 0.0136 ns | 0.0127 ns | 16.46 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 17.43 ns | 0.0117 ns | 0.0110 ns | 17.43 ns |      - |       0 B |
                                           From_Double | 40.98 ns | 0.0349 ns | 0.0326 ns | 40.98 ns | 0.0057 |      24 B |
                                  From_Double_AsObject | 56.37 ns | 0.0661 ns | 0.0618 ns | 56.37 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 44.80 ns | 0.0392 ns | 0.0347 ns | 44.79 ns | 0.0057 |      24 B |
               From_Double_Nullable_WithValue_AsObject | 56.14 ns | 0.0854 ns | 0.0799 ns | 56.11 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.88 ns | 0.0136 ns | 0.0127 ns | 15.88 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 17.33 ns | 0.0119 ns | 0.0112 ns | 17.33 ns |      - |       0 B |
                                            From_Short | 38.61 ns | 0.0176 ns | 0.0156 ns | 38.61 ns | 0.0057 |      24 B |
                                   From_Short_AsObject | 52.88 ns | 0.0712 ns | 0.0666 ns | 52.86 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 41.29 ns | 0.0451 ns | 0.0400 ns | 41.31 ns | 0.0057 |      24 B |
                From_Short_Nullable_WithValue_AsObject | 52.95 ns | 0.0383 ns | 0.0299 ns | 52.95 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 14.80 ns | 0.0122 ns | 0.0114 ns | 14.80 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.72 ns | 0.0109 ns | 0.0102 ns | 17.72 ns |      - |       0 B |
                                              From_Int | 38.50 ns | 0.0216 ns | 0.0202 ns | 38.50 ns | 0.0057 |      24 B |
                                     From_Int_AsObject | 43.84 ns | 0.0339 ns | 0.0317 ns | 43.84 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 41.51 ns | 0.0230 ns | 0.0215 ns | 41.51 ns | 0.0057 |      24 B |
                  From_Int_Nullable_WithValue_AsObject | 44.11 ns | 0.0645 ns | 0.0603 ns | 44.11 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 14.80 ns | 0.0138 ns | 0.0129 ns | 14.81 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.36 ns | 0.0037 ns | 0.0029 ns | 17.36 ns |      - |       0 B |
                                             From_Long | 39.81 ns | 0.0256 ns | 0.0240 ns | 39.81 ns | 0.0057 |      24 B |
                                    From_Long_AsObject | 56.04 ns | 0.0272 ns | 0.0241 ns | 56.04 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 44.94 ns | 0.0721 ns | 0.0639 ns | 44.95 ns | 0.0057 |      24 B |
                 From_Long_Nullable_WithValue_AsObject | 55.85 ns | 0.0431 ns | 0.0382 ns | 55.85 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 15.87 ns | 0.0106 ns | 0.0099 ns | 15.87 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 17.35 ns | 0.0132 ns | 0.0123 ns | 17.35 ns |      - |       0 B |
                                            From_SByte | 38.58 ns | 0.0390 ns | 0.0365 ns | 38.58 ns | 0.0057 |      24 B |
                                   From_SByte_AsObject | 52.75 ns | 0.1142 ns | 0.1068 ns | 52.73 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 41.06 ns | 0.0141 ns | 0.0118 ns | 41.06 ns | 0.0057 |      24 B |
                From_SByte_Nullable_WithValue_AsObject | 54.89 ns | 0.0700 ns | 0.0655 ns | 54.90 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 14.79 ns | 0.0105 ns | 0.0098 ns | 14.78 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.35 ns | 0.0064 ns | 0.0060 ns | 17.34 ns |      - |       0 B |
                                            From_Float | 40.98 ns | 0.0268 ns | 0.0251 ns | 40.98 ns | 0.0057 |      24 B |
                                   From_Float_AsObject | 54.99 ns | 0.0998 ns | 0.0933 ns | 54.97 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 43.79 ns | 0.0338 ns | 0.0300 ns | 43.78 ns | 0.0057 |      24 B |
                From_Float_Nullable_WithValue_AsObject | 54.92 ns | 0.0468 ns | 0.0438 ns | 54.91 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 14.79 ns | 0.0131 ns | 0.0123 ns | 14.80 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.97 ns | 0.0087 ns | 0.0073 ns | 17.97 ns |      - |       0 B |
                                           From_String | 49.91 ns | 0.0616 ns | 0.0576 ns | 49.91 ns |      - |       0 B |
                                  From_String_AsObject | 50.29 ns | 0.0552 ns | 0.0490 ns | 50.30 ns |      - |       0 B |
                                      From_String_Null | 17.24 ns | 0.0113 ns | 0.0106 ns | 17.23 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.87 ns | 0.0081 ns | 0.0076 ns | 17.87 ns |      - |       0 B |
                                     From_String_Empty | 26.31 ns | 0.0218 ns | 0.0193 ns | 26.30 ns |      - |       0 B |
                            From_String_Empty_AsObject | 26.04 ns | 0.0250 ns | 0.0233 ns | 26.04 ns |      - |       0 B |
                                           From_UShort | 38.38 ns | 0.0143 ns | 0.0127 ns | 38.38 ns | 0.0057 |      24 B |
                                  From_UShort_AsObject | 57.52 ns | 0.0202 ns | 0.0189 ns | 57.52 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 40.97 ns | 0.0113 ns | 0.0100 ns | 40.97 ns | 0.0057 |      24 B |
               From_UShort_Nullable_WithValue_AsObject | 52.42 ns | 0.0581 ns | 0.0543 ns | 52.43 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 14.78 ns | 0.0037 ns | 0.0031 ns | 14.78 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 18.00 ns | 0.0079 ns | 0.0073 ns | 17.99 ns |      - |       0 B |
                                             From_UInt | 38.98 ns | 0.0318 ns | 0.0282 ns | 38.97 ns | 0.0057 |      24 B |
                                    From_UInt_AsObject | 53.66 ns | 0.0468 ns | 0.0438 ns | 53.67 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 41.29 ns | 0.0392 ns | 0.0367 ns | 41.28 ns | 0.0057 |      24 B |
                 From_UInt_Nullable_WithValue_AsObject | 53.30 ns | 0.1155 ns | 0.1081 ns | 53.33 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 14.79 ns | 0.0121 ns | 0.0113 ns | 14.80 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.41 ns | 0.0088 ns | 0.0082 ns | 17.41 ns |      - |       0 B |
                                            From_ULong | 39.74 ns | 0.0370 ns | 0.0328 ns | 39.73 ns | 0.0057 |      24 B |
                                   From_ULong_AsObject | 56.95 ns | 0.0233 ns | 0.0206 ns | 56.94 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 45.36 ns | 0.0192 ns | 0.0180 ns | 45.35 ns | 0.0057 |      24 B |
                From_ULong_Nullable_WithValue_AsObject | 56.42 ns | 0.0186 ns | 0.0174 ns | 56.42 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 16.94 ns | 0.0133 ns | 0.0124 ns | 16.94 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.33 ns | 0.0033 ns | 0.0027 ns | 17.33 ns |      - |       0 B |
                                       From_NullObject | 17.87 ns | 0.0086 ns | 0.0081 ns | 17.87 ns |      - |       0 B |
                                           From_DBNull | 17.62 ns | 0.0075 ns | 0.0063 ns | 17.61 ns |      - |       0 B |
                                 From_ConvertibleClass | 49.83 ns | 0.0604 ns | 0.0565 ns | 49.81 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 50.20 ns | 0.0273 ns | 0.0242 ns | 50.19 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 18.30 ns | 0.0104 ns | 0.0098 ns | 18.29 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 17.40 ns | 0.0093 ns | 0.0087 ns | 17.41 ns |      - |       0 B |
                              From_NonConvertibleClass | 40.66 ns | 0.0751 ns | 0.0703 ns | 40.64 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 46.28 ns | 0.0370 ns | 0.0328 ns | 46.27 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 17.27 ns | 0.0102 ns | 0.0091 ns | 17.27 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 17.69 ns | 0.0059 ns | 0.0052 ns | 17.69 ns |      - |       0 B |
                                From_ConvertibleStruct | 51.86 ns | 0.0104 ns | 0.0087 ns | 51.86 ns | 0.0114 |      48 B |
                       From_ConvertibleStruct_AsObject | 51.46 ns | 0.0364 ns | 0.0340 ns | 51.44 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 51.15 ns | 0.0102 ns | 0.0095 ns | 51.14 ns | 0.0114 |      48 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 51.62 ns | 0.0386 ns | 0.0361 ns | 51.60 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.79 ns | 0.0106 ns | 0.0099 ns | 14.78 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.33 ns | 0.0089 ns | 0.0079 ns | 17.33 ns |      - |       0 B |
                             From_NonConvertibleStruct | 36.95 ns | 0.0095 ns | 0.0079 ns | 36.95 ns | 0.0057 |      24 B |
                    From_NonConvertibleStruct_AsObject | 47.03 ns | 0.0562 ns | 0.0526 ns | 47.01 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 38.98 ns | 0.0070 ns | 0.0055 ns | 38.98 ns | 0.0057 |      24 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 46.41 ns | 0.0178 ns | 0.0149 ns | 46.40 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.78 ns | 0.0078 ns | 0.0069 ns | 14.78 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.33 ns | 0.0138 ns | 0.0122 ns | 17.33 ns |      - |       0 B |
                                             From_Enum | 14.00 ns | 0.0090 ns | 0.0084 ns | 13.99 ns |      - |       0 B |
                                    From_Enum_AsObject | 17.77 ns | 0.0024 ns | 0.0018 ns | 17.77 ns |      - |       0 B |
                          From_Enum_Nullable_WithValue | 14.50 ns | 0.0033 ns | 0.0029 ns | 14.50 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 17.70 ns | 0.0026 ns | 0.0023 ns | 17.70 ns |      - |       0 B |
                            From_Enum_Nullable_NoValue | 14.53 ns | 0.0144 ns | 0.0135 ns | 14.53 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 18.07 ns | 0.0082 ns | 0.0077 ns | 18.07 ns |      - |       0 B |
                                      From_ParentClass | 40.86 ns | 0.0318 ns | 0.0297 ns | 40.86 ns |      - |       0 B |
                             From_ParentClass_AsObject | 48.25 ns | 0.0627 ns | 0.0587 ns | 48.24 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.29 ns | 0.0098 ns | 0.0091 ns | 17.30 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.34 ns | 0.0064 ns | 0.0057 ns | 17.34 ns |      - |       0 B |
                                     From_ParentStruct | 36.99 ns | 0.0245 ns | 0.0218 ns | 36.99 ns | 0.0057 |      24 B |
                            From_ParentStruct_AsObject | 46.95 ns | 0.0658 ns | 0.0583 ns | 46.95 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 38.97 ns | 0.0104 ns | 0.0092 ns | 38.97 ns | 0.0057 |      24 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 46.81 ns | 0.0185 ns | 0.0154 ns | 46.81 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.79 ns | 0.0103 ns | 0.0096 ns | 14.78 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 17.33 ns | 0.0021 ns | 0.0018 ns | 17.33 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
