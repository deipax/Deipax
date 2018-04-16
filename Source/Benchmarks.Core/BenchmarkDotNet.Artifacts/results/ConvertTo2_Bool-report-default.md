
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|---------:|-------:|----------:|
                                             From_Bool | 13.96 ns | 0.0943 ns | 0.0836 ns | 13.93 ns |      - |       0 B |
                                    From_Bool_AsObject | 18.96 ns | 0.0912 ns | 0.0808 ns | 18.93 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.68 ns | 0.0109 ns | 0.0102 ns | 14.68 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 18.56 ns | 0.0125 ns | 0.0105 ns | 18.56 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 14.68 ns | 0.0134 ns | 0.0112 ns | 14.68 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 17.38 ns | 0.0575 ns | 0.0538 ns | 17.40 ns |      - |       0 B |
                                             From_Byte | 14.39 ns | 0.0025 ns | 0.0018 ns | 14.39 ns |      - |       0 B |
                                    From_Byte_AsObject | 28.44 ns | 0.0595 ns | 0.0556 ns | 28.41 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 17.09 ns | 0.0641 ns | 0.0599 ns | 17.10 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 28.37 ns | 0.0844 ns | 0.0705 ns | 28.37 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 14.66 ns | 0.0011 ns | 0.0009 ns | 14.66 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.30 ns | 0.0149 ns | 0.0124 ns | 17.30 ns |      - |       0 B |
                                             From_Char | 14.14 ns | 0.0076 ns | 0.0063 ns | 14.14 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 14.13 ns | 0.0039 ns | 0.0031 ns | 14.13 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 13.87 ns | 0.0127 ns | 0.0119 ns | 13.86 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 17.29 ns | 0.0067 ns | 0.0052 ns | 17.29 ns |      - |       0 B |
                                         From_DateTime | 14.46 ns | 0.0235 ns | 0.0196 ns | 14.45 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.79 ns | 0.0162 ns | 0.0144 ns | 14.78 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.79 ns | 0.0199 ns | 0.0186 ns | 14.78 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 19.39 ns | 0.0188 ns | 0.0176 ns | 19.38 ns |      - |       0 B |
                                          From_Decimal | 25.57 ns | 0.0031 ns | 0.0026 ns | 25.57 ns |      - |       0 B |
                                 From_Decimal_AsObject | 36.78 ns | 0.0341 ns | 0.0302 ns | 36.76 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 28.36 ns | 0.0026 ns | 0.0023 ns | 28.36 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 36.86 ns | 0.0089 ns | 0.0074 ns | 36.86 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 17.61 ns | 0.3842 ns | 0.8672 ns | 17.45 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 19.48 ns | 0.5186 ns | 0.6173 ns | 19.43 ns |      - |       0 B |
                                           From_Double | 15.83 ns | 0.3519 ns | 0.7109 ns | 15.75 ns |      - |       0 B |
                                  From_Double_AsObject | 27.59 ns | 0.5687 ns | 0.7394 ns | 27.43 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 19.71 ns | 0.4292 ns | 1.1963 ns | 19.62 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 28.64 ns | 0.6040 ns | 1.3756 ns | 28.64 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 17.00 ns | 0.3752 ns | 0.6372 ns | 16.97 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 18.95 ns | 0.4096 ns | 0.9892 ns | 19.00 ns |      - |       0 B |
                                            From_Short | 15.30 ns | 0.3377 ns | 0.5157 ns | 15.26 ns |      - |       0 B |
                                   From_Short_AsObject | 28.20 ns | 0.5989 ns | 1.2762 ns | 27.98 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 17.16 ns | 0.0100 ns | 0.0094 ns | 17.16 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 25.95 ns | 0.0957 ns | 0.0896 ns | 25.99 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 15.05 ns | 0.0093 ns | 0.0083 ns | 15.05 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 17.86 ns | 0.0205 ns | 0.0192 ns | 17.86 ns |      - |       0 B |
                                              From_Int | 14.12 ns | 0.0033 ns | 0.0024 ns | 14.13 ns |      - |       0 B |
                                     From_Int_AsObject | 25.95 ns | 0.1011 ns | 0.0946 ns | 25.99 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 17.17 ns | 0.0040 ns | 0.0027 ns | 17.17 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 25.89 ns | 0.0476 ns | 0.0445 ns | 25.91 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 16.04 ns | 0.0023 ns | 0.0019 ns | 16.04 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.73 ns | 0.0489 ns | 0.0434 ns | 17.74 ns |      - |       0 B |
                                             From_Long | 14.13 ns | 0.0176 ns | 0.0165 ns | 14.13 ns |      - |       0 B |
                                    From_Long_AsObject | 27.00 ns | 0.0352 ns | 0.0329 ns | 27.00 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 18.99 ns | 0.0116 ns | 0.0109 ns | 18.99 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 25.93 ns | 0.0883 ns | 0.0783 ns | 25.93 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 17.91 ns | 0.3928 ns | 0.8540 ns | 18.04 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 20.20 ns | 0.3483 ns | 0.3088 ns | 20.27 ns |      - |       0 B |
                                            From_SByte | 16.17 ns | 0.3576 ns | 0.6975 ns | 16.16 ns |      - |       0 B |
                                   From_SByte_AsObject | 26.84 ns | 0.5506 ns | 0.5150 ns | 26.75 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 19.36 ns | 0.4133 ns | 0.7239 ns | 19.38 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 27.78 ns | 0.5889 ns | 1.1625 ns | 27.65 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 15.48 ns | 0.3485 ns | 1.0111 ns | 15.11 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 17.29 ns | 0.0164 ns | 0.0137 ns | 17.29 ns |      - |       0 B |
                                            From_Float | 14.64 ns | 0.0024 ns | 0.0022 ns | 14.64 ns |      - |       0 B |
                                   From_Float_AsObject | 27.36 ns | 0.0305 ns | 0.0286 ns | 27.35 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 17.18 ns | 0.0153 ns | 0.0143 ns | 17.17 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 27.34 ns | 0.0189 ns | 0.0168 ns | 27.35 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 16.00 ns | 0.0158 ns | 0.0148 ns | 16.00 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 17.95 ns | 0.0030 ns | 0.0028 ns | 17.95 ns |      - |       0 B |
                                           From_String | 35.54 ns | 0.0557 ns | 0.0521 ns | 35.54 ns |      - |       0 B |
                                  From_String_AsObject | 46.32 ns | 0.0285 ns | 0.0253 ns | 46.32 ns |      - |       0 B |
                                      From_String_Null | 15.74 ns | 0.0107 ns | 0.0100 ns | 15.73 ns |      - |       0 B |
                             From_String_Null_AsObject | 17.29 ns | 0.0013 ns | 0.0010 ns | 17.29 ns |      - |       0 B |
                                     From_String_Empty | 15.70 ns | 0.0114 ns | 0.0101 ns | 15.70 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                                           From_UShort | 14.12 ns | 0.0011 ns | 0.0009 ns | 14.12 ns |      - |       0 B |
                                  From_UShort_AsObject | 25.83 ns | 0.0133 ns | 0.0125 ns | 25.83 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 17.00 ns | 0.0018 ns | 0.0014 ns | 17.00 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 25.84 ns | 0.0115 ns | 0.0108 ns | 25.83 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 15.03 ns | 0.0255 ns | 0.0199 ns | 15.03 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 17.29 ns | 0.0120 ns | 0.0112 ns | 17.30 ns |      - |       0 B |
                                             From_UInt | 14.42 ns | 0.0093 ns | 0.0087 ns | 14.42 ns |      - |       0 B |
                                    From_UInt_AsObject | 25.85 ns | 0.0274 ns | 0.0243 ns | 25.85 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 17.10 ns | 0.0379 ns | 0.0316 ns | 17.10 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 25.84 ns | 0.0122 ns | 0.0114 ns | 25.85 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 16.26 ns | 0.3490 ns | 0.2725 ns | 16.28 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 18.95 ns | 0.4557 ns | 1.3438 ns | 17.94 ns |      - |       0 B |
                                            From_ULong | 14.39 ns | 0.0094 ns | 0.0088 ns | 14.39 ns |      - |       0 B |
                                   From_ULong_AsObject | 27.35 ns | 0.0205 ns | 0.0182 ns | 27.36 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 18.93 ns | 0.0117 ns | 0.0109 ns | 18.94 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 27.24 ns | 0.0496 ns | 0.0464 ns | 27.24 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 16.95 ns | 0.0038 ns | 0.0031 ns | 16.95 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.63 ns | 0.0098 ns | 0.0092 ns | 17.63 ns |      - |       0 B |
                                       From_NullObject | 17.29 ns | 0.0017 ns | 0.0015 ns | 17.29 ns |      - |       0 B |
                                           From_DBNull | 15.32 ns | 0.0089 ns | 0.0074 ns | 15.32 ns |      - |       0 B |
                                 From_ConvertibleClass | 24.23 ns | 0.0082 ns | 0.0073 ns | 24.23 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 23.67 ns | 0.0174 ns | 0.0154 ns | 23.66 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 20.76 ns | 0.4444 ns | 0.8772 ns | 20.89 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 19.63 ns | 0.4279 ns | 1.0734 ns | 19.83 ns |      - |       0 B |
                              From_NonConvertibleClass | 16.89 ns | 0.4101 ns | 0.5882 ns | 16.86 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 25.46 ns | 0.5350 ns | 0.8329 ns | 25.55 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 16.77 ns | 0.3589 ns | 0.5796 ns | 16.68 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 19.63 ns | 0.4201 ns | 0.4669 ns | 19.46 ns |      - |       0 B |
                                From_ConvertibleStruct | 26.25 ns | 0.5482 ns | 0.7504 ns | 26.06 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 25.98 ns | 0.4994 ns | 0.4671 ns | 25.73 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 29.53 ns | 0.6320 ns | 1.8636 ns | 29.51 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 26.73 ns | 0.5617 ns | 0.7875 ns | 26.35 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 14.68 ns | 0.0026 ns | 0.0022 ns | 14.68 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 20.33 ns | 0.6968 ns | 0.7155 ns | 20.20 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.08 ns | 0.2241 ns | 0.2096 ns | 13.96 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 26.55 ns | 0.5349 ns | 0.5945 ns | 26.58 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 19.37 ns | 0.4730 ns | 0.8528 ns | 19.53 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 30.24 ns | 0.4874 ns | 0.4559 ns | 30.13 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 19.60 ns | 0.4014 ns | 0.4295 ns | 19.65 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.86 ns | 0.4874 ns | 0.8408 ns | 17.49 ns |      - |       0 B |
                                             From_Enum | 14.35 ns | 0.2077 ns | 0.1943 ns | 14.42 ns |      - |       0 B |
                                    From_Enum_AsObject | 59.67 ns | 0.0540 ns | 0.0479 ns | 59.67 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue | 17.12 ns | 0.0073 ns | 0.0061 ns | 17.12 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 59.83 ns | 0.0619 ns | 0.0517 ns | 59.83 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue | 15.08 ns | 0.0741 ns | 0.0693 ns | 15.11 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 17.34 ns | 0.0073 ns | 0.0061 ns | 17.34 ns |      - |       0 B |
                                      From_ParentClass | 16.10 ns | 0.0745 ns | 0.0697 ns | 16.05 ns |      - |       0 B |
                             From_ParentClass_AsObject | 23.26 ns | 0.4721 ns | 0.4185 ns | 22.99 ns |      - |       0 B |
                              From_ParentClass_NoValue | 17.51 ns | 0.4254 ns | 0.6367 ns | 17.22 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 22.02 ns | 0.7117 ns | 2.0986 ns | 21.99 ns |      - |       0 B |
                                     From_ParentStruct | 19.58 ns | 0.4228 ns | 0.4699 ns | 19.68 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 31.65 ns | 0.6639 ns | 0.8397 ns | 31.65 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 19.40 ns | 0.4248 ns | 0.5955 ns | 19.41 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 30.96 ns | 0.6447 ns | 0.8153 ns | 31.07 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 20.21 ns | 0.4194 ns | 0.3718 ns | 20.17 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 18.41 ns | 0.4069 ns | 0.7742 ns | 18.24 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Bool.From_Char_AsObject: DefaultJob
  ConvertTo2_Bool.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Bool.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Bool.From_String_Empty_AsObject: DefaultJob
