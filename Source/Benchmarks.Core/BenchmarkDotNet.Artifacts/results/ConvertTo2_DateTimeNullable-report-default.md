
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  17.24 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                                    From_Bool_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Bool_Nullable_WithValue |  17.26 ns | 0.0357 ns | 0.0298 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Bool_Nullable_NoValue |  17.25 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  18.82 ns | 0.0218 ns | 0.0182 ns |      - |       0 B |
                                             From_Byte |  17.36 ns | 0.0095 ns | 0.0079 ns |      - |       0 B |
                                    From_Byte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Byte_Nullable_WithValue |  17.26 ns | 0.0195 ns | 0.0183 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Byte_Nullable_NoValue |  17.31 ns | 0.0299 ns | 0.0280 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  18.81 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
                                             From_Char |  17.35 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                                    From_Char_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Char_Nullable_WithValue |  21.75 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Char_Nullable_NoValue |  17.25 ns | 0.0189 ns | 0.0176 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  18.86 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
                                         From_DateTime |  16.63 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
                                From_DateTime_AsObject |  30.80 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
                      From_DateTime_Nullable_WithValue |  15.91 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
             From_DateTime_Nullable_WithValue_AsObject |  30.77 ns | 0.0264 ns | 0.0221 ns |      - |       0 B |
                        From_DateTime_Nullable_NoValue |  15.90 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  19.44 ns | 0.0189 ns | 0.0158 ns |      - |       0 B |
                                          From_Decimal |  17.34 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
                                 From_Decimal_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                       From_Decimal_Nullable_WithValue |  18.61 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Decimal_Nullable_NoValue |  18.61 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  19.59 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
                                           From_Double |  17.22 ns | 0.0276 ns | 0.0259 ns |      - |       0 B |
                                  From_Double_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_Double_Nullable_WithValue |  17.36 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Double_Nullable_NoValue |  17.37 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  19.59 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
                                            From_Short |  17.36 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
                                   From_Short_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Short_Nullable_WithValue |  17.26 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Short_Nullable_NoValue |  17.25 ns | 0.0294 ns | 0.0261 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  20.85 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
                                              From_Int |  17.52 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
                                     From_Int_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Int_Nullable_WithValue |  17.25 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                             From_Int_Nullable_NoValue |  17.27 ns | 0.0108 ns | 0.0095 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  18.80 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
                                             From_Long |  17.52 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
                                    From_Long_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Long_Nullable_WithValue |  17.36 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Long_Nullable_NoValue |  17.37 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  19.33 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
                                            From_SByte |  17.36 ns | 0.0195 ns | 0.0163 ns |      - |       0 B |
                                   From_SByte_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_SByte_Nullable_WithValue |  17.25 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_SByte_Nullable_NoValue |  17.23 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  18.80 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
                                            From_Float |  19.82 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
                                   From_Float_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_Float_Nullable_WithValue |  17.27 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_Float_Nullable_NoValue |  17.26 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  18.81 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
                                           From_String | 792.50 ns | 0.9676 ns | 0.9051 ns |      - |       0 B |
                                  From_String_AsObject | 819.25 ns | 1.1140 ns | 1.0421 ns |      - |       0 B |
                                      From_String_Null |  18.67 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
                             From_String_Null_AsObject |  18.82 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
                                     From_String_Empty |  17.55 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  17.35 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                                  From_UShort_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_UShort_Nullable_WithValue |  17.26 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UShort_Nullable_NoValue |  17.26 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  18.81 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
                                             From_UInt |  17.54 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
                                    From_UInt_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_UInt_Nullable_WithValue |  17.25 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_UInt_Nullable_NoValue |  17.27 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  21.55 ns | 0.0082 ns | 0.0076 ns |      - |       0 B |
                                            From_ULong |  17.52 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
                                   From_ULong_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                         From_ULong_Nullable_WithValue |  18.74 ns | 0.0176 ns | 0.0164 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                           From_ULong_Nullable_NoValue |  17.36 ns | 0.0162 ns | 0.0152 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  18.81 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
                                       From_NullObject |  20.32 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
                                           From_DBNull |  17.66 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
                                 From_ConvertibleClass |  28.16 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  30.97 ns | 0.0465 ns | 0.0435 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  18.82 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  18.81 ns | 0.0099 ns | 0.0082 ns |      - |       0 B |
                              From_NonConvertibleClass |  17.25 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  25.91 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  17.25 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.80 ns | 0.0150 ns | 0.0125 ns |      - |       0 B |
                                From_ConvertibleStruct |  26.98 ns | 0.0156 ns | 0.0130 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  30.30 ns | 0.0239 ns | 0.0223 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  31.79 ns | 0.0115 ns | 0.0107 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  30.15 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  18.34 ns | 0.0208 ns | 0.0194 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  18.80 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
                             From_NonConvertibleStruct |  17.25 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  27.05 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  17.24 ns | 0.0153 ns | 0.0135 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  25.22 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  17.25 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  18.80 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
                                             From_Enum |  19.13 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                                    From_Enum_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                          From_Enum_Nullable_WithValue |  18.84 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                            From_Enum_Nullable_NoValue |  18.84 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  18.80 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
                                      From_ParentClass |  17.25 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
                             From_ParentClass_AsObject |  25.68 ns | 0.0284 ns | 0.0266 ns |      - |       0 B |
                              From_ParentClass_NoValue |  19.21 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
                     From_ParentClass_NoValue_AsObject |  18.81 ns | 0.0113 ns | 0.0105 ns |      - |       0 B |
                                     From_ParentStruct |  18.71 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
                            From_ParentStruct_AsObject |  25.67 ns | 0.0133 ns | 0.0118 ns |      - |       0 B |
                  From_ParentStruct_Nullable_WithValue |  18.32 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
         From_ParentStruct_Nullable_WithValue_AsObject |  25.66 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
                    From_ParentStruct_Nullable_NoValue |  17.24 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
           From_ParentStruct_Nullable_NoValue_AsObject |  19.12 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_DateTimeNullable.From_Bool_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Bool_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Byte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Char_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Decimal_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Double_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Short_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Int_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Long_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_SByte_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Float_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_String_Empty_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UShort_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_UInt_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_ULong_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_AsObject: DefaultJob
  ConvertTo2_DateTimeNullable.From_Enum_Nullable_WithValue_AsObject: DefaultJob
