
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|-------:|----------:|
                                          From_Bool | 14.04 ns | 0.0297 ns | 0.0263 ns |      - |       0 B |
                                 From_Bool_AsObject | 27.83 ns | 0.0328 ns | 0.0290 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 20.32 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
              From_Bool_Nullable_WithValue_AsObject | 27.85 ns | 0.0470 ns | 0.0440 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 15.24 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.96 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
                                          From_Byte | 14.59 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                                 From_Byte_AsObject | 28.09 ns | 0.0270 ns | 0.0211 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 16.85 ns | 0.0299 ns | 0.0250 ns |      - |       0 B |
              From_Byte_Nullable_WithValue_AsObject | 28.20 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 14.31 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.86 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
                                          From_Char | 15.21 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                                 From_Char_AsObject | 29.06 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 17.69 ns | 0.0665 ns | 0.0622 ns |      - |       0 B |
              From_Char_Nullable_WithValue_AsObject | 29.13 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 16.31 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 18.71 ns | 0.0087 ns | 0.0078 ns |      - |       0 B |
                                      From_DateTime | 16.65 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 14.43 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 14.44 ns | 0.0120 ns | 0.0107 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.87 ns | 0.0182 ns | 0.0171 ns |      - |       0 B |
                                       From_Decimal | 26.80 ns | 0.0272 ns | 0.0241 ns |      - |       0 B |
                              From_Decimal_AsObject | 38.06 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 35.10 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
           From_Decimal_Nullable_WithValue_AsObject | 38.25 ns | 0.0542 ns | 0.0507 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 16.85 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 18.31 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
                                        From_Double | 16.88 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
                               From_Double_AsObject | 29.72 ns | 0.0464 ns | 0.0434 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 19.52 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
            From_Double_Nullable_WithValue_AsObject | 29.66 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.56 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 17.92 ns | 0.0142 ns | 0.0133 ns |      - |       0 B |
                                         From_Short | 14.05 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                From_Short_AsObject | 28.72 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 17.52 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
             From_Short_Nullable_WithValue_AsObject | 28.60 ns | 0.0232 ns | 0.0205 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.33 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.87 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
                                           From_Int | 15.02 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
                                  From_Int_AsObject | 28.65 ns | 0.0711 ns | 0.0665 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 17.67 ns | 0.0144 ns | 0.0134 ns |      - |       0 B |
               From_Int_Nullable_WithValue_AsObject | 28.60 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.45 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.91 ns | 0.0159 ns | 0.0132 ns |      - |       0 B |
                                          From_Long | 15.31 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                                 From_Long_AsObject | 29.48 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 18.88 ns | 0.0175 ns | 0.0156 ns |      - |       0 B |
              From_Long_Nullable_WithValue_AsObject | 29.74 ns | 0.0521 ns | 0.0487 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.56 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.97 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
                                         From_SByte | 14.04 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
                                From_SByte_AsObject | 28.72 ns | 0.0241 ns | 0.0225 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 16.84 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
             From_SByte_Nullable_WithValue_AsObject | 28.71 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 16.31 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.98 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
                                         From_Float | 16.06 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
                                From_Float_AsObject | 29.98 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 19.45 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
             From_Float_Nullable_WithValue_AsObject | 29.99 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.30 ns | 0.0026 ns | 0.0025 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 18.97 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                                        From_String | 87.53 ns | 0.0703 ns | 0.0658 ns |      - |       0 B |
                               From_String_AsObject | 97.94 ns | 0.0197 ns | 0.0164 ns |      - |       0 B |
                                   From_String_Null | 17.04 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                          From_String_Null_AsObject | 17.89 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
                                  From_String_Empty | 16.70 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
                         From_String_Empty_AsObject |       NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort | 13.69 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
                               From_UShort_AsObject | 28.06 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 16.81 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
            From_UShort_Nullable_WithValue_AsObject | 28.07 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 15.21 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.86 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
                                          From_UInt | 13.71 ns | 0.0041 ns | 0.0032 ns |      - |       0 B |
                                 From_UInt_AsObject | 29.12 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 13.27 ns | 0.0090 ns | 0.0075 ns |      - |       0 B |
              From_UInt_Nullable_WithValue_AsObject | 28.95 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 13.27 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 18.46 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
                                         From_ULong | 15.54 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
                                From_ULong_AsObject | 28.59 ns | 0.0302 ns | 0.0268 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 17.43 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
             From_ULong_Nullable_WithValue_AsObject | 28.71 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.71 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 18.72 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
                                    From_NullObject | 17.86 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                        From_DBNull | 26.58 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                              From_ConvertibleClass | 24.65 ns | 0.0163 ns | 0.0145 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 25.52 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 18.27 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 18.97 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
                             From_ConvertibleStruct | 22.65 ns | 0.0022 ns | 0.0017 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject | 26.79 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 25.96 ns | 0.0230 ns | 0.0216 ns | 0.0057 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 26.80 ns | 0.0220 ns | 0.0195 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 15.60 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 18.60 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
                                          From_Enum | 14.05 ns | 0.0193 ns | 0.0171 ns |      - |       0 B |
                                 From_Enum_AsObject | 59.58 ns | 0.4396 ns | 0.3671 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 17.08 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 59.83 ns | 0.0479 ns | 0.0448 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue | 14.31 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.88 ns | 0.0161 ns | 0.0142 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_UIntNullable.From_DateTime_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_UIntNullable.From_String_Empty_AsObject: DefaultJob
