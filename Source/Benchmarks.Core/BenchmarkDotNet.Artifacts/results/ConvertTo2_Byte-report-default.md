
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  14.79 ns | 0.0548 ns | 0.0513 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.61 ns | 0.0257 ns | 0.0215 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.48 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  25.60 ns | 0.0382 ns | 0.0319 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  14.67 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  17.37 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                             From_Byte |  14.14 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                    From_Byte_AsObject |  18.66 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  14.69 ns | 0.0121 ns | 0.0114 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  18.52 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  14.43 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  17.28 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
                                             From_Char |  14.39 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
                                    From_Char_AsObject |  26.93 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  19.00 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  26.93 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  15.01 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  17.27 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
                                         From_DateTime |  14.58 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |  14.79 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.78 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  17.28 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
                                          From_Decimal |  26.16 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.40 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  35.97 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  37.49 ns | 0.0413 ns | 0.0366 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  16.13 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  17.26 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
                                           From_Double |  18.32 ns | 0.1334 ns | 0.1041 ns |      - |       0 B |
                                  From_Double_AsObject |  29.34 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  22.32 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  29.41 ns | 0.0319 ns | 0.0266 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  16.35 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  17.29 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                                            From_Short |  15.14 ns | 0.0214 ns | 0.0190 ns |      - |       0 B |
                                   From_Short_AsObject |  26.92 ns | 0.0154 ns | 0.0128 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  18.84 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  27.00 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  14.96 ns | 0.0151 ns | 0.0134 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  17.35 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
                                              From_Int |  15.22 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
                                     From_Int_AsObject |  26.91 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  18.56 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  26.91 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  15.87 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.27 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
                                             From_Long |  15.46 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
                                    From_Long_AsObject |  26.91 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  19.35 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  26.91 ns | 0.0040 ns | 0.0031 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  17.07 ns | 0.0051 ns | 0.0042 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  17.28 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                                            From_SByte |  14.38 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                                   From_SByte_AsObject |  26.10 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  18.13 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  26.13 ns | 0.0324 ns | 0.0287 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  14.95 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  17.25 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
                                            From_Float |  18.30 ns | 0.0078 ns | 0.0070 ns |      - |       0 B |
                                   From_Float_AsObject |  29.87 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  22.07 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  29.91 ns | 0.0213 ns | 0.0188 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  15.03 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  17.26 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
                                           From_String |  94.25 ns | 0.0395 ns | 0.0350 ns |      - |       0 B |
                                  From_String_AsObject | 104.52 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
                                      From_String_Null |  16.43 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.26 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
                                     From_String_Empty |  15.95 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  14.65 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
                                  From_UShort_AsObject |  26.26 ns | 0.0207 ns | 0.0183 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  17.16 ns | 0.0091 ns | 0.0086 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  26.11 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  14.66 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  17.26 ns | 0.0130 ns | 0.0121 ns |      - |       0 B |
                                             From_UInt |  14.38 ns | 0.0096 ns | 0.0089 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.11 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  17.15 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.38 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  14.95 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  17.34 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
                                            From_ULong |  14.80 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.92 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  19.58 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.92 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  15.89 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  17.76 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
                                       From_NullObject |  17.84 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
                                           From_DBNull |  15.07 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
                                 From_ConvertibleClass |  24.04 ns | 0.0390 ns | 0.0364 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.41 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.30 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  17.32 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                              From_NonConvertibleClass |  15.93 ns | 0.0181 ns | 0.0169 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  21.60 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.07 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.09 ns | 0.0162 ns | 0.0151 ns |      - |       0 B |
                                From_ConvertibleStruct |  23.67 ns | 0.0194 ns | 0.0182 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  24.77 ns | 0.0347 ns | 0.0290 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  26.78 ns | 0.0206 ns | 0.0193 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.76 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  14.95 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  17.27 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
                             From_NonConvertibleStruct |  14.15 ns | 0.0082 ns | 0.0068 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.66 ns | 0.0190 ns | 0.0158 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  13.88 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  21.58 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.88 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  17.26 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
                                             From_Enum |  15.20 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
                                    From_Enum_AsObject |  60.31 ns | 0.0116 ns | 0.0090 ns | 0.0056 |      24 B |
                          From_Enum_Nullable_WithValue |  18.82 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  60.54 ns | 0.0280 ns | 0.0248 ns | 0.0056 |      24 B |
                            From_Enum_Nullable_NoValue |  14.67 ns | 0.0024 ns | 0.0018 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  17.26 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
                                      From_ParentClass |  15.91 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
                             From_ParentClass_AsObject |  22.89 ns | 0.0129 ns | 0.0114 ns |      - |       0 B |
                              From_ParentClass_NoValue |  15.82 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.22 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
                                     From_ParentStruct |  14.17 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  22.24 ns | 0.0155 ns | 0.0137 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  13.89 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  22.21 ns | 0.0792 ns | 0.0740 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  13.90 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  17.33 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Byte.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Byte.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Byte.From_String_Empty_AsObject: DefaultJob
