
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                                          From_Bool |  31.27 ns | 0.0061 ns | 0.0048 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject |  29.75 ns | 0.0487 ns | 0.0432 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 104.92 ns | 0.1967 ns | 0.1840 ns | 0.0056 |      24 B |
              From_Bool_Nullable_WithValue_AsObject |  29.75 ns | 0.0349 ns | 0.0272 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue |  41.16 ns | 0.1018 ns | 0.0952 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject |  14.43 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
                                          From_Byte |  31.20 ns | 0.0190 ns | 0.0158 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject |  29.49 ns | 0.0891 ns | 0.0790 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 103.44 ns | 0.0698 ns | 0.0619 ns | 0.0056 |      24 B |
              From_Byte_Nullable_WithValue_AsObject |  29.72 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue |  41.78 ns | 0.0207 ns | 0.0183 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject |  14.68 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
                                          From_Char |  32.54 ns | 0.0039 ns | 0.0035 ns | 0.0057 |      24 B |
                                 From_Char_AsObject |  30.97 ns | 0.0076 ns | 0.0063 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 104.76 ns | 0.0266 ns | 0.0235 ns | 0.0056 |      24 B |
              From_Char_Nullable_WithValue_AsObject |  30.98 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                         From_Char_Nullable_NoValue |  41.09 ns | 0.0857 ns | 0.0716 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject |  14.68 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
                                      From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                             From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
          From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue |  43.85 ns | 0.0894 ns | 0.0793 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject |  16.11 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                       From_Decimal |  45.58 ns | 0.0542 ns | 0.0507 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject |  43.20 ns | 0.0794 ns | 0.0743 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 119.39 ns | 0.1182 ns | 0.1047 ns | 0.0074 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject |  43.16 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue |  41.48 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject |  14.41 ns | 0.0110 ns | 0.0091 ns |      - |       0 B |
                                        From_Double |  35.62 ns | 0.0612 ns | 0.0572 ns | 0.0057 |      24 B |
                               From_Double_AsObject |  33.94 ns | 0.0535 ns | 0.0501 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 110.42 ns | 0.0838 ns | 0.0784 ns | 0.0056 |      24 B |
            From_Double_Nullable_WithValue_AsObject |  34.37 ns | 0.0409 ns | 0.0382 ns |      - |       0 B |
                       From_Double_Nullable_NoValue |  41.56 ns | 0.0577 ns | 0.0540 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject |  14.70 ns | 0.0230 ns | 0.0215 ns |      - |       0 B |
                                         From_Short |  17.21 ns | 0.0212 ns | 0.0198 ns | 0.0057 |      24 B |
                                From_Short_AsObject |  15.58 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
                      From_Short_Nullable_WithValue |  88.74 ns | 0.0155 ns | 0.0129 ns | 0.0056 |      24 B |
             From_Short_Nullable_WithValue_AsObject |  15.58 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                        From_Short_Nullable_NoValue |  42.10 ns | 0.3127 ns | 0.2925 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject |  14.68 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
                                           From_Int |  32.64 ns | 0.0258 ns | 0.0241 ns | 0.0057 |      24 B |
                                  From_Int_AsObject |  31.08 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 106.86 ns | 0.0139 ns | 0.0116 ns | 0.0056 |      24 B |
               From_Int_Nullable_WithValue_AsObject |  30.99 ns | 0.0334 ns | 0.0279 ns |      - |       0 B |
                          From_Int_Nullable_NoValue |  41.11 ns | 0.1501 ns | 0.1404 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject |  14.43 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
                                          From_Long |  32.63 ns | 0.0222 ns | 0.0197 ns | 0.0057 |      24 B |
                                 From_Long_AsObject |  31.04 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 105.91 ns | 0.0264 ns | 0.0220 ns | 0.0056 |      24 B |
              From_Long_Nullable_WithValue_AsObject |  31.02 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                         From_Long_Nullable_NoValue |  43.56 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject |  14.83 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
                                         From_SByte |  31.42 ns | 0.0230 ns | 0.0180 ns | 0.0057 |      24 B |
                                From_SByte_AsObject |  29.64 ns | 0.0214 ns | 0.0179 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 103.90 ns | 0.0692 ns | 0.0578 ns | 0.0056 |      24 B |
             From_SByte_Nullable_WithValue_AsObject |  29.73 ns | 0.0370 ns | 0.0309 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue |  42.00 ns | 0.0454 ns | 0.0425 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject |  14.68 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                         From_Float |  35.72 ns | 0.0049 ns | 0.0041 ns | 0.0057 |      24 B |
                                From_Float_AsObject |  34.20 ns | 0.0507 ns | 0.0423 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 109.96 ns | 0.0290 ns | 0.0242 ns | 0.0056 |      24 B |
             From_Float_Nullable_WithValue_AsObject |  34.18 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
                        From_Float_Nullable_NoValue |  41.01 ns | 0.0918 ns | 0.0859 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject |  14.93 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
                                        From_String | 108.40 ns | 0.0684 ns | 0.0571 ns |      - |       0 B |
                               From_String_AsObject | 108.34 ns | 0.0518 ns | 0.0460 ns |      - |       0 B |
                                   From_String_Null |  14.41 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
                          From_String_Null_AsObject |  14.41 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
                                  From_String_Empty |        NA |        NA |        NA |    N/A |       N/A |
                         From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                        From_UShort |  31.82 ns | 0.0274 ns | 0.0229 ns | 0.0057 |      24 B |
                               From_UShort_AsObject |  30.26 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 105.10 ns | 0.0681 ns | 0.0637 ns | 0.0056 |      24 B |
            From_UShort_Nullable_WithValue_AsObject |  30.24 ns | 0.0257 ns | 0.0215 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue |  42.09 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject |  14.41 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
                                          From_UInt |  33.55 ns | 0.0307 ns | 0.0272 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject |  30.99 ns | 0.0815 ns | 0.0681 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 105.69 ns | 0.0597 ns | 0.0529 ns | 0.0056 |      24 B |
              From_UInt_Nullable_WithValue_AsObject |  31.04 ns | 0.0135 ns | 0.0113 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue |  41.33 ns | 0.0782 ns | 0.0731 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject |  14.68 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
                                         From_ULong |  32.55 ns | 0.0219 ns | 0.0205 ns | 0.0057 |      24 B |
                                From_ULong_AsObject |  30.97 ns | 0.0170 ns | 0.0142 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 105.41 ns | 0.0537 ns | 0.0476 ns | 0.0056 |      24 B |
             From_ULong_Nullable_WithValue_AsObject |  30.98 ns | 0.0305 ns | 0.0238 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue |  41.18 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject |  14.68 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
                                    From_NullObject |  14.68 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
                                        From_DBNull |  15.22 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
                              From_ConvertibleClass |  27.74 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject |  27.78 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue |  15.81 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject |  15.41 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |
                             From_ConvertibleStruct |  31.24 ns | 0.0028 ns | 0.0021 ns | 0.0057 |      24 B |
                    From_ConvertibleStruct_AsObject |  29.20 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 108.28 ns | 0.0418 ns | 0.0370 ns | 0.0056 |      24 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject |  29.18 ns | 0.0336 ns | 0.0314 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue |  41.59 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject |  14.43 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
                                          From_Enum |  90.01 ns | 0.0418 ns | 0.0371 ns | 0.0113 |      48 B |
                                 From_Enum_AsObject |  86.47 ns | 0.0817 ns | 0.0764 ns | 0.0056 |      24 B |
                       From_Enum_Nullable_WithValue | 190.23 ns | 0.1241 ns | 0.1037 ns | 0.0112 |      48 B |
              From_Enum_Nullable_WithValue_AsObject |  83.72 ns | 0.0113 ns | 0.0094 ns | 0.0056 |      24 B |
                         From_Enum_Nullable_NoValue |  41.86 ns | 0.0648 ns | 0.0606 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject |  14.68 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo_Short.From_DateTime: DefaultJob
  ConvertTo_Short.From_DateTime_AsObject: DefaultJob
  ConvertTo_Short.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo_Short.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo_Short.From_String_Empty: DefaultJob
  ConvertTo_Short.From_String_Empty_AsObject: DefaultJob
