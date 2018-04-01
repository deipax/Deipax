
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------------------------------------------ |----------:|----------:|----------:|-------:|----------:|
                                             From_Bool |  13.84 ns | 0.2671 ns | 0.2498 ns |      - |       0 B |
                                    From_Bool_AsObject |  25.98 ns | 0.5742 ns | 0.5639 ns |      - |       0 B |
                          From_Bool_Nullable_WithValue |  17.00 ns | 0.0370 ns | 0.0328 ns |      - |       0 B |
                 From_Bool_Nullable_WithValue_AsObject |  26.75 ns | 0.0351 ns | 0.0293 ns |      - |       0 B |
                            From_Bool_Nullable_NoValue |  13.06 ns | 0.0789 ns | 0.0738 ns |      - |       0 B |
                   From_Bool_Nullable_NoValue_AsObject |  16.83 ns | 0.3685 ns | 0.8088 ns |      - |       0 B |
                                             From_Byte |  12.96 ns | 0.0776 ns | 0.0726 ns |      - |       0 B |
                                    From_Byte_AsObject |  25.63 ns | 0.0567 ns | 0.0503 ns |      - |       0 B |
                          From_Byte_Nullable_WithValue |  16.51 ns | 0.0395 ns | 0.0308 ns |      - |       0 B |
                 From_Byte_Nullable_WithValue_AsObject |  25.72 ns | 0.1417 ns | 0.1325 ns |      - |       0 B |
                            From_Byte_Nullable_NoValue |  13.19 ns | 0.0485 ns | 0.0430 ns |      - |       0 B |
                   From_Byte_Nullable_NoValue_AsObject |  16.16 ns | 0.0240 ns | 0.0225 ns |      - |       0 B |
                                             From_Char |  12.93 ns | 0.0303 ns | 0.0268 ns |      - |       0 B |
                                    From_Char_AsObject |  26.44 ns | 0.0588 ns | 0.0550 ns |      - |       0 B |
                          From_Char_Nullable_WithValue |  16.86 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
                 From_Char_Nullable_WithValue_AsObject |  29.08 ns | 0.0346 ns | 0.0307 ns |      - |       0 B |
                            From_Char_Nullable_NoValue |  13.29 ns | 0.0189 ns | 0.0148 ns |      - |       0 B |
                   From_Char_Nullable_NoValue_AsObject |  16.15 ns | 0.0431 ns | 0.0382 ns |      - |       0 B |
                                         From_DateTime |        NA |        NA |        NA |    N/A |       N/A |
                                From_DateTime_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                      From_DateTime_Nullable_WithValue |        NA |        NA |        NA |    N/A |       N/A |
             From_DateTime_Nullable_WithValue_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                        From_DateTime_Nullable_NoValue |  14.07 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
               From_DateTime_Nullable_NoValue_AsObject |  16.46 ns | 0.2086 ns | 0.1628 ns |      - |       0 B |
                                          From_Decimal |  24.75 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
                                 From_Decimal_AsObject |  37.74 ns | 0.0960 ns | 0.0801 ns |      - |       0 B |
                       From_Decimal_Nullable_WithValue |  32.96 ns | 0.0721 ns | 0.0674 ns |      - |       0 B |
              From_Decimal_Nullable_WithValue_AsObject |  38.12 ns | 0.0696 ns | 0.0651 ns |      - |       0 B |
                         From_Decimal_Nullable_NoValue |  14.60 ns | 0.0217 ns | 0.0193 ns |      - |       0 B |
                From_Decimal_Nullable_NoValue_AsObject |  16.20 ns | 0.0788 ns | 0.0737 ns |      - |       0 B |
                                           From_Double |  16.69 ns | 0.0161 ns | 0.0134 ns |      - |       0 B |
                                  From_Double_AsObject |  30.44 ns | 0.0737 ns | 0.0653 ns |      - |       0 B |
                        From_Double_Nullable_WithValue |  21.05 ns | 0.0422 ns | 0.0374 ns |      - |       0 B |
               From_Double_Nullable_WithValue_AsObject |  30.51 ns | 0.0625 ns | 0.0584 ns |      - |       0 B |
                          From_Double_Nullable_NoValue |  14.00 ns | 0.0071 ns | 0.0055 ns |      - |       0 B |
                 From_Double_Nullable_NoValue_AsObject |  16.12 ns | 0.0233 ns | 0.0194 ns |      - |       0 B |
                                            From_Short |  12.93 ns | 0.0330 ns | 0.0309 ns |      - |       0 B |
                                   From_Short_AsObject |  25.60 ns | 0.0433 ns | 0.0383 ns |      - |       0 B |
                         From_Short_Nullable_WithValue |  17.32 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
                From_Short_Nullable_WithValue_AsObject |  25.57 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
                           From_Short_Nullable_NoValue |  13.85 ns | 0.0570 ns | 0.0506 ns |      - |       0 B |
                  From_Short_Nullable_NoValue_AsObject |  16.13 ns | 0.0424 ns | 0.0376 ns |      - |       0 B |
                                              From_Int |  13.07 ns | 0.0121 ns | 0.0114 ns |      - |       0 B |
                                     From_Int_AsObject |  26.90 ns | 0.0382 ns | 0.0357 ns |      - |       0 B |
                           From_Int_Nullable_WithValue |  16.36 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
                  From_Int_Nullable_WithValue_AsObject |  25.57 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                             From_Int_Nullable_NoValue |  13.34 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
                    From_Int_Nullable_NoValue_AsObject |  17.05 ns | 0.0072 ns | 0.0056 ns |      - |       0 B |
                                             From_Long |  13.07 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
                                    From_Long_AsObject |  16.92 ns | 0.0062 ns | 0.0048 ns |      - |       0 B |
                          From_Long_Nullable_WithValue |  13.99 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
                 From_Long_Nullable_WithValue_AsObject |  16.89 ns | 0.0173 ns | 0.0144 ns |      - |       0 B |
                            From_Long_Nullable_NoValue |  14.32 ns | 0.0114 ns | 0.0089 ns |      - |       0 B |
                   From_Long_Nullable_NoValue_AsObject |  16.30 ns | 0.0174 ns | 0.0145 ns |      - |       0 B |
                                            From_SByte |  12.91 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
                                   From_SByte_AsObject |  25.63 ns | 0.0291 ns | 0.0272 ns |      - |       0 B |
                         From_SByte_Nullable_WithValue |  16.53 ns | 0.0191 ns | 0.0160 ns |      - |       0 B |
                From_SByte_Nullable_WithValue_AsObject |  25.63 ns | 0.0294 ns | 0.0275 ns |      - |       0 B |
                           From_SByte_Nullable_NoValue |  13.17 ns | 0.0226 ns | 0.0211 ns |      - |       0 B |
                  From_SByte_Nullable_NoValue_AsObject |  16.13 ns | 0.0068 ns | 0.0053 ns |      - |       0 B |
                                            From_Float |  16.95 ns | 0.0324 ns | 0.0253 ns |      - |       0 B |
                                   From_Float_AsObject |  31.17 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
                         From_Float_Nullable_WithValue |  20.58 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
                From_Float_Nullable_WithValue_AsObject |  31.07 ns | 0.0207 ns | 0.0173 ns |      - |       0 B |
                           From_Float_Nullable_NoValue |  13.25 ns | 0.0315 ns | 0.0263 ns |      - |       0 B |
                  From_Float_Nullable_NoValue_AsObject |  16.29 ns | 0.0048 ns | 0.0038 ns |      - |       0 B |
                                           From_String |  96.99 ns | 0.0772 ns | 0.0722 ns |      - |       0 B |
                                  From_String_AsObject | 102.30 ns | 0.0186 ns | 0.0145 ns |      - |       0 B |
                                      From_String_Null |  17.66 ns | 0.0226 ns | 0.0200 ns |      - |       0 B |
                             From_String_Null_AsObject |  17.06 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
                                     From_String_Empty |  19.91 ns | 0.0342 ns | 0.0320 ns |      - |       0 B |
                            From_String_Empty_AsObject |        NA |        NA |        NA |    N/A |       N/A |
                                           From_UShort |  13.08 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
                                  From_UShort_AsObject |  25.67 ns | 0.0240 ns | 0.0200 ns |      - |       0 B |
                        From_UShort_Nullable_WithValue |  16.52 ns | 0.0331 ns | 0.0309 ns |      - |       0 B |
               From_UShort_Nullable_WithValue_AsObject |  25.62 ns | 0.0229 ns | 0.0203 ns |      - |       0 B |
                          From_UShort_Nullable_NoValue |  13.79 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
                 From_UShort_Nullable_NoValue_AsObject |  16.29 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
                                             From_UInt |  12.90 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
                                    From_UInt_AsObject |  26.25 ns | 0.0268 ns | 0.0224 ns |      - |       0 B |
                          From_UInt_Nullable_WithValue |  16.59 ns | 0.0287 ns | 0.0239 ns |      - |       0 B |
                 From_UInt_Nullable_WithValue_AsObject |  26.10 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
                            From_UInt_Nullable_NoValue |  13.20 ns | 0.0248 ns | 0.0232 ns |      - |       0 B |
                   From_UInt_Nullable_NoValue_AsObject |  18.31 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
                                            From_ULong |  13.93 ns | 0.0197 ns | 0.0175 ns |      - |       0 B |
                                   From_ULong_AsObject |  26.35 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
                         From_ULong_Nullable_WithValue |  17.56 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
                From_ULong_Nullable_WithValue_AsObject |  26.68 ns | 0.0095 ns | 0.0085 ns |      - |       0 B |
                           From_ULong_Nullable_NoValue |  14.07 ns | 0.0437 ns | 0.0409 ns |      - |       0 B |
                  From_ULong_Nullable_NoValue_AsObject |  16.11 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
                                       From_NullObject |  16.13 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
                                           From_DBNull |  15.81 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
                                 From_ConvertibleClass |  22.59 ns | 0.0266 ns | 0.0236 ns |      - |       0 B |
                        From_ConvertibleClass_AsObject |  23.01 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
                         From_ConvertibleClass_NoValue |  17.95 ns | 0.0149 ns | 0.0089 ns |      - |       0 B |
                From_ConvertibleClass_NoValue_AsObject |  16.42 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
                              From_NonConvertibleClass |  18.68 ns | 0.0260 ns | 0.0203 ns |      - |       0 B |
                     From_NonConvertibleClass_AsObject |  20.94 ns | 0.0255 ns | 0.0238 ns |      - |       0 B |
                      From_NonConvertibleClass_NoValue |  16.10 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
             From_NonConvertibleClass_NoValue_AsObject |  18.45 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
                                From_ConvertibleStruct |  22.35 ns | 0.0193 ns | 0.0181 ns | 0.0057 |      24 B |
                       From_ConvertibleStruct_AsObject |  26.41 ns | 0.0306 ns | 0.0287 ns |      - |       0 B |
             From_ConvertibleStruct_Nullable_WithValue |  27.59 ns | 0.0318 ns | 0.0298 ns | 0.0057 |      24 B |
    From_ConvertibleStruct_Nullable_WithValue_AsObject |  24.25 ns | 0.0131 ns | 0.0102 ns |      - |       0 B |
               From_ConvertibleStruct_Nullable_NoValue |  13.16 ns | 0.0310 ns | 0.0290 ns |      - |       0 B |
      From_ConvertibleStruct_Nullable_NoValue_AsObject |  16.12 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
                             From_NonConvertibleStruct |  12.82 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
                    From_NonConvertibleStruct_AsObject |  21.02 ns | 0.0086 ns | 0.0067 ns |      - |       0 B |
          From_NonConvertibleStruct_Nullable_WithValue |  16.17 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
 From_NonConvertibleStruct_Nullable_WithValue_AsObject |  22.14 ns | 0.0053 ns | 0.0042 ns |      - |       0 B |
            From_NonConvertibleStruct_Nullable_NoValue |  13.01 ns | 0.0225 ns | 0.0211 ns |      - |       0 B |
   From_NonConvertibleStruct_Nullable_NoValue_AsObject |  16.14 ns | 0.0410 ns | 0.0383 ns |      - |       0 B |
                                             From_Enum |  14.00 ns | 0.0030 ns | 0.0022 ns |      - |       0 B |
                                    From_Enum_AsObject |  57.46 ns | 0.0986 ns | 0.0922 ns | 0.0057 |      24 B |
                          From_Enum_Nullable_WithValue |  17.81 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
                 From_Enum_Nullable_WithValue_AsObject |  57.72 ns | 0.0597 ns | 0.0529 ns | 0.0057 |      24 B |
                            From_Enum_Nullable_NoValue |  15.39 ns | 0.0178 ns | 0.0166 ns |      - |       0 B |
                   From_Enum_Nullable_NoValue_AsObject |  16.12 ns | 0.0224 ns | 0.0210 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Long.From_DateTime: DefaultJob
  ConvertTo2_Long.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue: DefaultJob
  ConvertTo2_Long.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
  ConvertTo2_Long.From_String_Empty_AsObject: DefaultJob
