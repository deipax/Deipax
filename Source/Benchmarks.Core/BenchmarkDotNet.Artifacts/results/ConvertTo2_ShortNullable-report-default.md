
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  14.02 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
                                 From_Bool_AsObject |  27.84 ns | 0.0247 ns | 0.0219 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue |  17.76 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject |  27.83 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  14.32 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  19.68 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                          From_Byte |  15.00 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
                                 From_Byte_AsObject |  28.45 ns | 0.0019 ns | 0.0014 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue |  17.82 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject |  28.46 ns | 0.0214 ns | 0.0189 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  15.37 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  18.44 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                                          From_Char |  14.24 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                                 From_Char_AsObject |  30.02 ns | 0.0449 ns | 0.0398 ns |      - |       0 B |
                       From_Char_Nullable_WithValue |  16.87 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject |  29.70 ns | 0.0435 ns | 0.0407 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  14.29 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  17.88 ns | 0.0015 ns | 0.0011 ns |      - |       0 B |
                                      From_DateTime |  14.34 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |  14.30 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  14.31 ns | 0.0211 ns | 0.0176 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  17.84 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
                                       From_Decimal |  27.76 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                              From_Decimal_AsObject |  40.36 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue |  36.38 ns | 0.0297 ns | 0.0278 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject |  40.37 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  16.96 ns | 0.0167 ns | 0.0140 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  18.26 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                        From_Double |  18.11 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                               From_Double_AsObject |  32.65 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                     From_Double_Nullable_WithValue |  21.50 ns | 0.0248 ns | 0.0207 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject |  32.27 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  16.41 ns | 0.0290 ns | 0.0272 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  17.77 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
                                         From_Short |  13.71 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
                                From_Short_AsObject |  29.23 ns | 0.0274 ns | 0.0256 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  13.27 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject |  28.89 ns | 0.0337 ns | 0.0315 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  13.27 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  19.03 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                           From_Int |  15.30 ns | 0.0068 ns | 0.0056 ns |      - |       0 B |
                                  From_Int_AsObject |  29.85 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
                        From_Int_Nullable_WithValue |  17.85 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject |  29.86 ns | 0.0172 ns | 0.0160 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  14.29 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  17.74 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                          From_Long |  15.90 ns | 0.0150 ns | 0.0141 ns |      - |       0 B |
                                 From_Long_AsObject |  29.73 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
                       From_Long_Nullable_WithValue |  18.87 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject |  29.85 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  15.56 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  17.75 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
                                         From_SByte |  13.90 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
                                From_SByte_AsObject |  28.45 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue |  16.70 ns | 0.0167 ns | 0.0130 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject |  28.59 ns | 0.0292 ns | 0.0244 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  14.91 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  17.87 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                                         From_Float |  18.59 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                From_Float_AsObject |  32.54 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
                      From_Float_Nullable_WithValue |  21.21 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject |  32.53 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  14.28 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  17.87 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
                                        From_String |  90.82 ns | 0.0539 ns | 0.0478 ns |      - |       0 B |
                               From_String_AsObject | 102.84 ns | 0.0613 ns | 0.0574 ns |      - |       0 B |
                                   From_String_Null |  16.45 ns | 0.0087 ns | 0.0068 ns |      - |       0 B |
                          From_String_Null_AsObject |  20.28 ns | 0.1407 ns | 0.1316 ns |      - |       0 B |
                                  From_String_Empty |  17.60 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  14.11 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                               From_UShort_AsObject |  29.10 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue |  16.85 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject |  28.96 ns | 0.0069 ns | 0.0046 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  14.30 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  18.18 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                          From_UInt |  15.30 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
                                 From_UInt_AsObject |  29.74 ns | 0.0408 ns | 0.0382 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue |  20.15 ns | 0.0330 ns | 0.0308 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject |  29.87 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  15.37 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  17.78 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                         From_ULong |  15.68 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
                                From_ULong_AsObject |  29.87 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue |  19.93 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject |  29.88 ns | 0.0260 ns | 0.0230 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  15.94 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  17.75 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
                                    From_NullObject |  18.30 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                                        From_DBNull |  17.28 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
                              From_ConvertibleClass |  24.63 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  25.53 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  17.75 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  17.80 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
                             From_ConvertibleStruct |  22.78 ns | 0.0179 ns | 0.0168 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  26.82 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue |  25.01 ns | 0.0187 ns | 0.0175 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  26.82 ns | 0.0310 ns | 0.0275 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  15.37 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.93 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                          From_Enum |  15.31 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
                                 From_Enum_AsObject |  60.07 ns | 0.0572 ns | 0.0507 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue |  18.88 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject |  60.24 ns | 0.0324 ns | 0.0287 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  14.29 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  20.19 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_ShortNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_ShortNullable.From_String_Empty_AsObject: DefaultJob
