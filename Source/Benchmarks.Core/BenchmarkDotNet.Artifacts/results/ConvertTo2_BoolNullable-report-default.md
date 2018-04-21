
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |---------:|----------:|----------:|-------:|----------:|
                                             From_Bool | 13.85 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
                                    From_Bool_AsObject | 34.15 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue | 14.05 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject | 28.47 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue | 13.40 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject | 16.74 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                                             From_Byte | 13.92 ns | 0.0147 ns | 0.0115 ns |      - |       0 B |
                                    From_Byte_AsObject | 24.76 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue | 14.22 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject | 24.76 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue | 13.86 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject | 17.70 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                             From_Char | 13.74 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                                    From_Char_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue | 13.66 ns | 0.0042 ns | 0.0040 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue | 13.82 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject | 18.71 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                         From_DateTime | 14.10 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
                                From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue | 14.53 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue | 14.53 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject | 16.80 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                          From_Decimal | 23.98 ns | 0.0192 ns | 0.0180 ns |      - |       0 B |
                                 From_Decimal_AsObject | 34.18 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue | 25.01 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject | 34.19 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue | 14.75 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject | 16.75 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
                                           From_Double | 14.15 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                  From_Double_AsObject | 25.78 ns | 0.0193 ns | 0.0180 ns |      - |       0 B |
                        From_Double_Nullable_WithValue | 15.09 ns | 0.0107 ns | 0.0089 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject | 24.74 ns | 0.0050 ns | 0.0045 ns |      - |       0 B |
                          From_Double_Nullable_NoValue | 15.42 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject | 19.31 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
                                            From_Short | 14.77 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
                                   From_Short_AsObject | 25.50 ns | 0.0554 ns | 0.0518 ns |      - |       0 B |
                         From_Short_Nullable_WithValue | 14.27 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject | 24.49 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                           From_Short_Nullable_NoValue | 13.86 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject | 16.68 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
                                              From_Int | 13.97 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
                                     From_Int_AsObject | 24.48 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
                           From_Int_Nullable_WithValue | 14.32 ns | 0.0030 ns | 0.0023 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject | 24.48 ns | 0.0063 ns | 0.0049 ns |      - |       0 B |
                             From_Int_Nullable_NoValue | 13.81 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject | 17.73 ns | 0.0005 ns | 0.0003 ns |      - |       0 B |
                                             From_Long | 15.62 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                    From_Long_AsObject | 24.49 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                          From_Long_Nullable_WithValue | 16.13 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject | 25.81 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
                            From_Long_Nullable_NoValue | 14.80 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject | 16.80 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                                            From_SByte | 14.47 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                   From_SByte_AsObject | 24.49 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue | 14.60 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject | 25.54 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue | 13.81 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject | 16.69 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                                            From_Float | 14.90 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
                                   From_Float_AsObject | 24.50 ns | 0.0336 ns | 0.0315 ns |      - |       0 B |
                         From_Float_Nullable_WithValue | 15.59 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject | 24.53 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
                           From_Float_Nullable_NoValue | 13.80 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject | 19.45 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                           From_String | 33.73 ns | 0.0754 ns | 0.0669 ns |      - |       0 B |
                                  From_String_AsObject | 41.91 ns | 0.0268 ns | 0.0224 ns |      - |       0 B |
                                      From_String_Null | 15.33 ns | 0.0034 ns | 0.0031 ns |      - |       0 B |
                             From_String_Null_AsObject | 18.69 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
                                     From_String_Empty | 15.49 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                            From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort | 13.79 ns | 0.0029 ns | 0.0027 ns |      - |       0 B |
                                  From_UShort_AsObject | 24.49 ns | 0.0090 ns | 0.0079 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue | 14.20 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject | 24.50 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue | 13.81 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject | 16.68 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
                                             From_UInt | 13.91 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
                                    From_UInt_AsObject | 24.48 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue | 14.21 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject | 24.48 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue | 13.84 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject | 17.69 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                            From_ULong | 13.90 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                   From_ULong_AsObject | 24.49 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue | 15.06 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject | 24.49 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue | 14.81 ns | 0.0207 ns | 0.0193 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject | 17.98 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
                                       From_NullObject | 17.62 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
                                           From_DBNull | 15.59 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                  From_DBNull_AsObject | 18.43 ns | 0.0081 ns | 0.0075 ns |      - |       0 B |
                                 From_ConvertibleClass | 21.15 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject | 22.20 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue | 16.97 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject | 16.75 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
                              From_NonConvertibleClass | 14.87 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject | 19.17 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue | 14.97 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject | 18.75 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                                From_ConvertibleStruct | 22.60 ns | 0.0139 ns | 0.0123 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject | 24.51 ns | 0.0087 ns | 0.0068 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue | 22.66 ns | 0.0099 ns | 0.0083 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject | 23.48 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue | 16.05 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.51 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                             From_NonConvertibleStruct | 14.46 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject | 19.16 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue | 15.26 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject | 20.49 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue | 14.50 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject | 17.86 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
                                             From_Enum | 13.86 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
                                    From_Enum_AsObject | 54.65 ns | 0.0181 ns | 0.0161 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue | 14.21 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject | 54.56 ns | 0.0216 ns | 0.0192 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue | 13.81 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject | 16.71 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
                                      From_ParentClass | 15.06 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                             From_ParentClass_AsObject | 19.64 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
                              From_ParentClass_NoValue | 15.88 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject | 17.72 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
                                     From_ParentStruct | 14.56 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                            From_ParentStruct_AsObject | 19.64 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue | 14.55 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject | 19.64 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue | 14.49 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject | 16.70 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_BoolNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_BoolNullable.From_String_Empty_AsObject: DefaultJob
