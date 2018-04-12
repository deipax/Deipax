
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.76 ns | 0.0162 ns | 0.0135 ns |      - |       0 B |
                                 From_Bool_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Bool_Nullable_WithValue | 14.58 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                         From_Bool_Nullable_NoValue | 15.07 ns | 0.0161 ns | 0.0150 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.77 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                                          From_Byte | 16.38 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
                                 From_Byte_AsObject | 28.48 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 16.81 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 28.48 ns | 0.0530 ns | 0.0470 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.30 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.88 ns | 0.0155 ns | 0.0121 ns |      - |       0 B |
                                          From_Char | 13.71 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
                                 From_Char_AsObject | 28.86 ns | 0.0448 ns | 0.0419 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 13.28 ns | 0.0129 ns | 0.0101 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 28.86 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 13.27 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.74 ns | 0.0138 ns | 0.0130 ns |      - |       0 B |
                                      From_DateTime | 14.22 ns | 0.0152 ns | 0.0143 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.30 ns | 0.0257 ns | 0.0215 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 16.43 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.88 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
                                       From_Decimal | 14.14 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                              From_Decimal_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                    From_Decimal_Nullable_WithValue | 14.79 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Decimal_Nullable_NoValue | 15.05 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.75 ns | 0.0009 ns | 0.0005 ns |      - |       0 B |
                                        From_Double | 13.75 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
                               From_Double_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_Double_Nullable_WithValue | 14.25 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                       From_Double_Nullable_NoValue | 15.34 ns | 0.0040 ns | 0.0034 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.77 ns | 0.0035 ns | 0.0028 ns |      - |       0 B |
                                         From_Short | 14.04 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
                                From_Short_AsObject | 28.97 ns | 0.0213 ns | 0.0189 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.84 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 28.96 ns | 0.0040 ns | 0.0029 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.28 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 19.05 ns | 0.0103 ns | 0.0097 ns |      - |       0 B |
                                           From_Int | 15.56 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                                  From_Int_AsObject | 29.92 ns | 0.0761 ns | 0.0712 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 18.01 ns | 0.0484 ns | 0.0404 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 29.71 ns | 0.0154 ns | 0.0137 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.30 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.75 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                                          From_Long | 15.31 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
                                 From_Long_AsObject | 29.89 ns | 0.0327 ns | 0.0290 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.88 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 29.88 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.61 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 18.48 ns | 0.0137 ns | 0.0129 ns |      - |       0 B |
                                         From_SByte | 14.05 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                                From_SByte_AsObject | 29.12 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.85 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 28.99 ns | 0.0464 ns | 0.0434 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.29 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 18.51 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
                                         From_Float | 13.69 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                                From_Float_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                      From_Float_Nullable_WithValue | 13.65 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                        From_Float_Nullable_NoValue | 13.76 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.91 ns | 0.0252 ns | 0.0235 ns |      - |       0 B |
                                        From_String | 18.35 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
                               From_String_AsObject | 28.68 ns | 0.0053 ns | 0.0038 ns |      - |       0 B |
                                   From_String_Null | 17.15 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.73 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
                                  From_String_Empty | 16.61 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 14.59 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
                               From_UShort_AsObject | 28.58 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.78 ns | 0.0410 ns | 0.0384 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 29.46 ns | 0.0112 ns | 0.0081 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.35 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 19.38 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                          From_UInt | 14.28 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                 From_UInt_AsObject | 29.09 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 19.03 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 29.08 ns | 0.0087 ns | 0.0068 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.29 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 18.34 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
                                         From_ULong | 15.04 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                From_ULong_AsObject | 29.84 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.15 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 29.85 ns | 0.0523 ns | 0.0409 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.56 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 20.84 ns | 0.0158 ns | 0.0147 ns |      - |       0 B |
                                    From_NullObject | 17.88 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                                        From_DBNull | 18.05 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                              From_ConvertibleClass | 24.65 ns | 0.0323 ns | 0.0302 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 25.53 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 18.77 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.80 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
                             From_ConvertibleStruct | 23.69 ns | 0.0148 ns | 0.0123 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 26.81 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 24.94 ns | 0.0047 ns | 0.0037 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 26.81 ns | 0.0382 ns | 0.0319 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 14.30 ns | 0.0157 ns | 0.0123 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.84 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
                                          From_Enum | 15.32 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
                                 From_Enum_AsObject | 61.05 ns | 0.0622 ns | 0.0520 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 17.93 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 61.10 ns | 0.0410 ns | 0.0384 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 14.30 ns | 0.0057 ns | 0.0054 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 18.63 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |

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
