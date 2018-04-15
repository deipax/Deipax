
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.371)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435891 Hz, Resolution=291.0453 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Allocated |
--------------------------------------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
                                          From_Bool | 43.32 ns | 0.8985 ns | 1.1364 ns | 43.07 ns | 0.0057 |      24 B |
                                 From_Bool_AsObject | 55.41 ns | 1.1387 ns | 2.4511 ns | 54.52 ns |      - |       0 B |
                       From_Bool_Nullable_WithValue | 44.85 ns | 0.8753 ns | 0.8188 ns | 44.48 ns | 0.0057 |      24 B |
              From_Bool_Nullable_WithValue_AsObject | 55.18 ns | 1.0911 ns | 1.4935 ns | 55.04 ns |      - |       0 B |
                         From_Bool_Nullable_NoValue | 15.52 ns | 0.2993 ns | 0.2654 ns | 15.52 ns |      - |       0 B |
                From_Bool_Nullable_NoValue_AsObject | 17.57 ns | 0.4203 ns | 0.4672 ns | 17.44 ns |      - |       0 B |
                                          From_Byte | 40.43 ns | 0.7766 ns | 0.6884 ns | 40.21 ns | 0.0057 |      24 B |
                                 From_Byte_AsObject | 52.30 ns | 0.3924 ns | 0.3064 ns | 52.18 ns |      - |       0 B |
                       From_Byte_Nullable_WithValue | 44.29 ns | 0.7041 ns | 0.6241 ns | 44.11 ns | 0.0057 |      24 B |
              From_Byte_Nullable_WithValue_AsObject | 53.25 ns | 1.1526 ns | 1.3720 ns | 52.63 ns |      - |       0 B |
                         From_Byte_Nullable_NoValue | 15.12 ns | 0.0667 ns | 0.0521 ns | 15.12 ns |      - |       0 B |
                From_Byte_Nullable_NoValue_AsObject | 17.12 ns | 0.2034 ns | 0.1699 ns | 17.08 ns |      - |       0 B |
                                          From_Char | 38.08 ns | 0.4007 ns | 0.3748 ns | 38.00 ns | 0.0057 |      24 B |
                                 From_Char_AsObject | 51.27 ns | 0.1701 ns | 0.1328 ns | 51.34 ns |      - |       0 B |
                       From_Char_Nullable_WithValue | 43.21 ns | 1.0238 ns | 1.3668 ns | 42.65 ns | 0.0057 |      24 B |
              From_Char_Nullable_WithValue_AsObject | 51.16 ns | 0.2300 ns | 0.2039 ns | 51.12 ns |      - |       0 B |
                         From_Char_Nullable_NoValue | 15.08 ns | 0.0247 ns | 0.0207 ns | 15.08 ns |      - |       0 B |
                From_Char_Nullable_NoValue_AsObject | 17.96 ns | 0.0403 ns | 0.0314 ns | 17.95 ns |      - |       0 B |
                                      From_DateTime | 38.41 ns | 0.0765 ns | 0.0678 ns | 38.39 ns | 0.0057 |      24 B |
                             From_DateTime_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                   From_DateTime_Nullable_WithValue | 43.95 ns | 0.3042 ns | 0.2697 ns | 43.86 ns | 0.0057 |      24 B |
          From_DateTime_Nullable_WithValue_AsObject |       NA |        NA |        NA |       NA |    N/A |       N/A |
                     From_DateTime_Nullable_NoValue | 15.93 ns | 0.0586 ns | 0.0520 ns | 15.93 ns |      - |       0 B |
            From_DateTime_Nullable_NoValue_AsObject | 17.31 ns | 0.0135 ns | 0.0098 ns | 17.31 ns |      - |       0 B |
                                       From_Decimal | 54.47 ns | 0.0570 ns | 0.0505 ns | 54.45 ns | 0.0076 |      32 B |
                              From_Decimal_AsObject | 67.51 ns | 0.8216 ns | 0.7283 ns | 67.00 ns |      - |       0 B |
                    From_Decimal_Nullable_WithValue | 59.62 ns | 0.5473 ns | 0.5119 ns | 59.28 ns | 0.0075 |      32 B |
           From_Decimal_Nullable_WithValue_AsObject | 63.92 ns | 0.2828 ns | 0.2645 ns | 64.04 ns |      - |       0 B |
                      From_Decimal_Nullable_NoValue | 16.45 ns | 0.0551 ns | 0.0460 ns | 16.43 ns |      - |       0 B |
             From_Decimal_Nullable_NoValue_AsObject | 17.11 ns | 0.0152 ns | 0.0142 ns | 17.11 ns |      - |       0 B |
                                        From_Double | 42.57 ns | 0.0745 ns | 0.0622 ns | 42.53 ns | 0.0057 |      24 B |
                               From_Double_AsObject | 55.20 ns | 0.2784 ns | 0.2174 ns | 55.30 ns |      - |       0 B |
                     From_Double_Nullable_WithValue | 46.17 ns | 0.1817 ns | 0.1611 ns | 46.08 ns | 0.0057 |      24 B |
            From_Double_Nullable_WithValue_AsObject | 54.30 ns | 0.1433 ns | 0.1270 ns | 54.27 ns |      - |       0 B |
                       From_Double_Nullable_NoValue | 15.92 ns | 0.0416 ns | 0.0389 ns | 15.90 ns |      - |       0 B |
              From_Double_Nullable_NoValue_AsObject | 16.86 ns | 0.0300 ns | 0.0281 ns | 16.86 ns |      - |       0 B |
                                         From_Short | 39.65 ns | 0.1709 ns | 0.1598 ns | 39.57 ns | 0.0057 |      24 B |
                                From_Short_AsObject | 52.16 ns | 0.1906 ns | 0.1783 ns | 52.11 ns |      - |       0 B |
                      From_Short_Nullable_WithValue | 43.12 ns | 0.2612 ns | 0.2444 ns | 43.02 ns | 0.0057 |      24 B |
             From_Short_Nullable_WithValue_AsObject | 52.04 ns | 0.0784 ns | 0.0734 ns | 52.07 ns |      - |       0 B |
                        From_Short_Nullable_NoValue | 14.82 ns | 0.0161 ns | 0.0143 ns | 14.81 ns |      - |       0 B |
               From_Short_Nullable_NoValue_AsObject | 17.84 ns | 0.0359 ns | 0.0336 ns | 17.81 ns |      - |       0 B |
                                           From_Int | 38.82 ns | 0.0531 ns | 0.0496 ns | 38.79 ns | 0.0057 |      24 B |
                                  From_Int_AsObject | 45.00 ns | 0.0958 ns | 0.0849 ns | 44.96 ns |      - |       0 B |
                        From_Int_Nullable_WithValue | 41.77 ns | 0.0151 ns | 0.0134 ns | 41.77 ns | 0.0057 |      24 B |
               From_Int_Nullable_WithValue_AsObject | 43.13 ns | 0.1682 ns | 0.1405 ns | 43.07 ns |      - |       0 B |
                          From_Int_Nullable_NoValue | 14.92 ns | 0.0062 ns | 0.0055 ns | 14.92 ns |      - |       0 B |
                 From_Int_Nullable_NoValue_AsObject | 17.58 ns | 0.0121 ns | 0.0107 ns | 17.58 ns |      - |       0 B |
                                          From_Long | 42.78 ns | 0.3869 ns | 0.3619 ns | 43.02 ns | 0.0057 |      24 B |
                                 From_Long_AsObject | 53.61 ns | 0.0416 ns | 0.0368 ns | 53.62 ns |      - |       0 B |
                       From_Long_Nullable_WithValue | 45.49 ns | 0.0505 ns | 0.0422 ns | 45.47 ns | 0.0057 |      24 B |
              From_Long_Nullable_WithValue_AsObject | 54.53 ns | 0.8654 ns | 0.8095 ns | 55.03 ns |      - |       0 B |
                         From_Long_Nullable_NoValue | 15.89 ns | 0.0119 ns | 0.0099 ns | 15.88 ns |      - |       0 B |
                From_Long_Nullable_NoValue_AsObject | 17.05 ns | 0.0214 ns | 0.0190 ns | 17.06 ns |      - |       0 B |
                                         From_SByte | 39.54 ns | 0.0579 ns | 0.0513 ns | 39.52 ns | 0.0057 |      24 B |
                                From_SByte_AsObject | 53.94 ns | 0.1230 ns | 0.0961 ns | 53.94 ns |      - |       0 B |
                      From_SByte_Nullable_WithValue | 42.41 ns | 0.0684 ns | 0.0571 ns | 42.38 ns | 0.0057 |      24 B |
             From_SByte_Nullable_WithValue_AsObject | 53.65 ns | 0.0440 ns | 0.0390 ns | 53.65 ns |      - |       0 B |
                        From_SByte_Nullable_NoValue | 14.82 ns | 0.0248 ns | 0.0208 ns | 14.81 ns |      - |       0 B |
               From_SByte_Nullable_NoValue_AsObject | 17.24 ns | 0.0123 ns | 0.0115 ns | 17.24 ns |      - |       0 B |
                                         From_Float | 42.60 ns | 0.0884 ns | 0.0738 ns | 42.56 ns | 0.0057 |      24 B |
                                From_Float_AsObject | 55.91 ns | 0.0316 ns | 0.0247 ns | 55.91 ns |      - |       0 B |
                      From_Float_Nullable_WithValue | 45.26 ns | 0.2289 ns | 0.2141 ns | 45.32 ns | 0.0057 |      24 B |
             From_Float_Nullable_WithValue_AsObject | 56.18 ns | 1.1552 ns | 2.5356 ns | 54.95 ns |      - |       0 B |
                        From_Float_Nullable_NoValue | 14.88 ns | 0.0627 ns | 0.0587 ns | 14.87 ns |      - |       0 B |
               From_Float_Nullable_NoValue_AsObject | 16.82 ns | 0.0306 ns | 0.0287 ns | 16.80 ns |      - |       0 B |
                                        From_String | 47.02 ns | 0.0808 ns | 0.0756 ns | 47.00 ns |      - |       0 B |
                               From_String_AsObject | 47.21 ns | 0.0870 ns | 0.0814 ns | 47.16 ns |      - |       0 B |
                                   From_String_Null | 18.17 ns | 0.0433 ns | 0.0405 ns | 18.18 ns |      - |       0 B |
                          From_String_Null_AsObject | 16.81 ns | 0.0258 ns | 0.0229 ns | 16.80 ns |      - |       0 B |
                                  From_String_Empty | 24.81 ns | 0.0358 ns | 0.0317 ns | 24.81 ns |      - |       0 B |
                         From_String_Empty_AsObject | 25.38 ns | 0.0421 ns | 0.0351 ns | 25.37 ns |      - |       0 B |
                                        From_UShort | 40.52 ns | 0.2839 ns | 0.2655 ns | 40.37 ns | 0.0057 |      24 B |
                               From_UShort_AsObject | 52.56 ns | 0.0839 ns | 0.0785 ns | 52.52 ns |      - |       0 B |
                     From_UShort_Nullable_WithValue | 43.50 ns | 0.5052 ns | 0.4725 ns | 43.22 ns | 0.0057 |      24 B |
            From_UShort_Nullable_WithValue_AsObject | 52.42 ns | 0.2041 ns | 0.1909 ns | 52.41 ns |      - |       0 B |
                       From_UShort_Nullable_NoValue | 14.81 ns | 0.0092 ns | 0.0072 ns | 14.81 ns |      - |       0 B |
              From_UShort_Nullable_NoValue_AsObject | 17.23 ns | 0.0242 ns | 0.0189 ns | 17.23 ns |      - |       0 B |
                                          From_UInt | 40.74 ns | 0.3468 ns | 0.3244 ns | 40.62 ns | 0.0057 |      24 B |
                                 From_UInt_AsObject | 52.86 ns | 0.2219 ns | 0.2076 ns | 52.96 ns |      - |       0 B |
                       From_UInt_Nullable_WithValue | 43.53 ns | 0.1745 ns | 0.1633 ns | 43.48 ns | 0.0057 |      24 B |
              From_UInt_Nullable_WithValue_AsObject | 53.94 ns | 0.4006 ns | 0.3747 ns | 54.14 ns |      - |       0 B |
                         From_UInt_Nullable_NoValue | 14.83 ns | 0.0346 ns | 0.0324 ns | 14.81 ns |      - |       0 B |
                From_UInt_Nullable_NoValue_AsObject | 16.93 ns | 0.0095 ns | 0.0074 ns | 16.93 ns |      - |       0 B |
                                         From_ULong | 41.84 ns | 0.0276 ns | 0.0245 ns | 41.85 ns | 0.0057 |      24 B |
                                From_ULong_AsObject | 54.56 ns | 0.9794 ns | 0.9162 ns | 55.10 ns |      - |       0 B |
                      From_ULong_Nullable_WithValue | 45.19 ns | 0.1040 ns | 0.0922 ns | 45.14 ns | 0.0057 |      24 B |
             From_ULong_Nullable_WithValue_AsObject | 53.68 ns | 0.2201 ns | 0.1951 ns | 53.81 ns |      - |       0 B |
                        From_ULong_Nullable_NoValue | 15.90 ns | 0.0266 ns | 0.0249 ns | 15.89 ns |      - |       0 B |
               From_ULong_Nullable_NoValue_AsObject | 18.16 ns | 0.0102 ns | 0.0080 ns | 18.16 ns |      - |       0 B |
                                    From_NullObject | 16.82 ns | 0.0112 ns | 0.0094 ns | 16.82 ns |      - |       0 B |
                                        From_DBNull | 16.81 ns | 0.0363 ns | 0.0322 ns | 16.80 ns |      - |       0 B |
                              From_ConvertibleClass | 50.41 ns | 0.1771 ns | 0.1570 ns | 50.36 ns |      - |       0 B |
                     From_ConvertibleClass_AsObject | 50.66 ns | 0.0689 ns | 0.0575 ns | 50.65 ns |      - |       0 B |
                      From_ConvertibleClass_NoValue | 16.98 ns | 0.0081 ns | 0.0063 ns | 16.98 ns |      - |       0 B |
             From_ConvertibleClass_NoValue_AsObject | 16.82 ns | 0.0241 ns | 0.0225 ns | 16.80 ns |      - |       0 B |
                             From_ConvertibleStruct | 48.61 ns | 0.1085 ns | 0.1015 ns | 48.58 ns | 0.0114 |      48 B |
                    From_ConvertibleStruct_AsObject | 51.55 ns | 0.1387 ns | 0.1298 ns | 51.55 ns |      - |       0 B |
          From_ConvertibleStruct_Nullable_WithValue | 55.02 ns | 0.0541 ns | 0.0480 ns | 55.00 ns | 0.0114 |      48 B |
 From_ConvertibleStruct_Nullable_WithValue_AsObject | 51.35 ns | 0.0988 ns | 0.0924 ns | 51.29 ns |      - |       0 B |
            From_ConvertibleStruct_Nullable_NoValue | 14.81 ns | 0.0063 ns | 0.0059 ns | 14.81 ns |      - |       0 B |
   From_ConvertibleStruct_Nullable_NoValue_AsObject | 16.83 ns | 0.0440 ns | 0.0411 ns | 16.80 ns |      - |       0 B |
                                          From_Enum | 14.06 ns | 0.0539 ns | 0.0478 ns | 14.05 ns |      - |       0 B |
                                 From_Enum_AsObject | 17.89 ns | 0.0137 ns | 0.0121 ns | 17.89 ns |      - |       0 B |
                       From_Enum_Nullable_WithValue | 15.11 ns | 0.0064 ns | 0.0054 ns | 15.11 ns |      - |       0 B |
              From_Enum_Nullable_WithValue_AsObject | 18.44 ns | 0.0159 ns | 0.0115 ns | 18.43 ns |      - |       0 B |
                         From_Enum_Nullable_NoValue | 14.54 ns | 0.0125 ns | 0.0098 ns | 14.54 ns |      - |       0 B |
                From_Enum_Nullable_NoValue_AsObject | 17.58 ns | 0.0355 ns | 0.0332 ns | 17.56 ns |      - |       0 B |

Benchmarks with issues:
  ConvertTo2_Enum.From_DateTime_AsObject: DefaultJob
  ConvertTo2_Enum.From_DateTime_Nullable_WithValue_AsObject: DefaultJob
