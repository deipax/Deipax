
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 13.89 ns | 0.0166 ns | 0.0139 ns |      - |       0 B |
                                 From_Bool_AsObject | 25.31 ns | 0.0547 ns | 0.0485 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 16.81 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 25.32 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 13.92 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.18 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
                                          From_Byte | 13.40 ns | 0.0047 ns | 0.0036 ns |      - |       0 B |
                                 From_Byte_AsObject | 26.33 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 15.96 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 25.31 ns | 0.0314 ns | 0.0293 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.17 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.09 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                          From_Char | 13.38 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
                                 From_Char_AsObject | 27.30 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 16.84 ns | 0.0056 ns | 0.0046 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 26.30 ns | 0.0214 ns | 0.0201 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 14.16 ns | 0.0005 ns | 0.0005 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.13 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                                      From_DateTime | 13.83 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.04 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 16.51 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 18.23 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
                                       From_Decimal | 25.56 ns | 0.0446 ns | 0.0418 ns |      - |       0 B |
                              From_Decimal_AsObject | 37.22 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 31.95 ns | 0.0137 ns | 0.0114 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 36.95 ns | 0.0191 ns | 0.0160 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 15.30 ns | 0.0093 ns | 0.0082 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.08 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                                        From_Double | 17.34 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                               From_Double_AsObject | 29.37 ns | 0.0184 ns | 0.0163 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 21.16 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 29.43 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.04 ns | 0.0011 ns | 0.0008 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.11 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
                                         From_Short | 13.74 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
                                From_Short_AsObject | 25.81 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 16.13 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 25.83 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.16 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 18.75 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                           From_Int | 14.66 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
                                  From_Int_AsObject | 26.56 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.59 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 26.56 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 13.92 ns | 0.0185 ns | 0.0164 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.11 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
                                          From_Long | 14.66 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                 From_Long_AsObject | 26.69 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.37 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 26.59 ns | 0.0176 ns | 0.0165 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.09 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.17 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                                         From_SByte | 13.64 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
                                From_SByte_AsObject | 25.80 ns | 0.0147 ns | 0.0137 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.70 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 25.84 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 15.73 ns | 0.0072 ns | 0.0063 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.11 ns | 0.0026 ns | 0.0019 ns |      - |       0 B |
                                         From_Float | 17.34 ns | 0.0019 ns | 0.0014 ns |      - |       0 B |
                                From_Float_AsObject | 30.51 ns | 0.0408 ns | 0.0382 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 20.91 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 29.40 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.16 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 17.09 ns | 0.0276 ns | 0.0258 ns |      - |       0 B |
                                        From_String | 86.11 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
                               From_String_AsObject | 97.16 ns | 0.0556 ns | 0.0520 ns |      - |       0 B |
                                   From_String_Null | 16.96 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.09 ns | 0.0183 ns | 0.0143 ns |      - |       0 B |
                                  From_String_Empty | 16.10 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 13.65 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                               From_UShort_AsObject | 18.15 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 13.91 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 17.88 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.03 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.14 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
                                          From_UInt | 13.90 ns | 0.0096 ns | 0.0089 ns |      - |       0 B |
                                 From_UInt_AsObject | 25.82 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 16.89 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 25.81 ns | 0.0146 ns | 0.0130 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.16 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 17.10 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
                                         From_ULong | 15.30 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                                From_ULong_AsObject | 26.79 ns | 0.0066 ns | 0.0051 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 18.39 ns | 0.0058 ns | 0.0055 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 26.59 ns | 0.0207 ns | 0.0194 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.07 ns | 0.0330 ns | 0.0292 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 17.16 ns | 0.0182 ns | 0.0171 ns |      - |       0 B |
                                    From_NullObject | 17.46 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                                        From_DBNull | 15.34 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                              From_ConvertibleClass | 22.53 ns | 0.0306 ns | 0.0287 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 22.99 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 17.12 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 17.61 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.12 ns | 0.0134 ns | 0.0126 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 24.25 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.11 ns | 0.0068 ns | 0.0053 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 24.26 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 13.94 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 17.78 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                                          From_Enum | 14.49 ns | 0.0052 ns | 0.0044 ns |      - |       0 B |
                                 From_Enum_AsObject | 59.24 ns | 0.0169 ns | 0.0142 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 19.83 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 58.67 ns | 0.0153 ns | 0.0128 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 14.17 ns | 0.0043 ns | 0.0040 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.13 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UShort.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UShort.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UShort.From_String_Empty_AsObject: DefaultJob
