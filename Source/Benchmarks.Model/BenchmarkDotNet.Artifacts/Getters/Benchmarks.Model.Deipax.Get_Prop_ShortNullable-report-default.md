
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.5501 ns | 0.2467 ns | 0.0135 ns |  1.5470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.3100 ns | 0.8689 ns | 0.0476 ns |  1.2930 ns |  0.85 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.1781 ns | 0.2279 ns | 0.0125 ns |  4.1763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.0109 ns | 0.2020 ns | 0.0111 ns |  4.0096 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.5062 ns | 0.0831 ns | 0.0046 ns |  1.5045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.5640 ns | 0.6684 ns | 0.0366 ns |  1.5452 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.4683 ns | 0.3335 ns | 0.0183 ns |  4.4711 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.9983 ns | 0.0692 ns | 0.0038 ns |  3.9993 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.9934 ns | 1.0625 ns | 0.0582 ns |  3.0092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.7293 ns | 1.7803 ns | 0.0976 ns |  2.6733 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.9008 ns | 0.7086 ns | 0.0388 ns |  4.9069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.9066 ns | 0.6743 ns | 0.0370 ns |  4.8888 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.9029 ns | 0.4607 ns | 0.0253 ns |  2.9025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.5966 ns | 0.2246 ns | 0.0123 ns |  1.5963 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.8933 ns | 0.1632 ns | 0.0089 ns |  4.8967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.9663 ns | 0.1527 ns | 0.0084 ns |  3.9667 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.5934 ns | 0.4936 ns | 0.0271 ns |  1.6022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.2232 ns | 0.7963 ns | 0.0436 ns |  1.2037 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  1.1660 ns | 0.0784 ns | 0.0043 ns |  1.1673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  0.9995 ns | 1.0954 ns | 0.0600 ns |  0.9810 ns |  0.86 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.7220 ns | 0.4814 ns | 0.0264 ns |  1.7127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.5542 ns | 0.0676 ns | 0.0037 ns |  1.5539 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.4345 ns | 0.3890 ns | 0.0213 ns |  4.4361 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.0490 ns | 0.8749 ns | 0.0480 ns |  4.0383 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.5031 ns | 0.0205 ns | 0.0011 ns |  1.5028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.5329 ns | 0.5354 ns | 0.0293 ns |  1.5472 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9904 ns | 0.0158 ns | 0.0009 ns |  3.9901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.0090 ns | 0.2426 ns | 0.0133 ns |  4.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.6871 ns | 0.2976 ns | 0.0163 ns |  1.6781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.7457 ns | 0.3806 ns | 0.0209 ns |  1.7383 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.2166 ns | 0.1304 ns | 0.0071 ns |  4.2160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.2432 ns | 0.4113 ns | 0.0225 ns |  4.2328 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.6512 ns | 0.1765 ns | 0.0097 ns |  1.6488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.6659 ns | 0.1177 ns | 0.0065 ns |  1.6649 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.1358 ns | 0.5780 ns | 0.0317 ns |  2.1190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.1807 ns | 0.3163 ns | 0.0173 ns |  2.1846 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.5325 ns | 0.7525 ns | 0.0412 ns |  1.5528 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.5077 ns | 0.3709 ns | 0.0203 ns |  1.4963 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.1318 ns | 0.1587 ns | 0.0087 ns |  2.1312 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.9295 ns | 1.1260 ns | 0.0617 ns |  1.9066 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.6095 ns | 0.6084 ns | 0.0333 ns |  1.5929 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.5256 ns | 0.1078 ns | 0.0059 ns |  1.5242 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.4494 ns | 0.7579 ns | 0.0415 ns |  4.4632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.2208 ns | 0.1181 ns | 0.0065 ns |  4.2225 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.7295 ns | 0.1521 ns | 0.0083 ns |  1.7263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.4204 ns | 0.1271 ns | 0.0070 ns |  1.4190 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.2417 ns | 0.8142 ns | 0.0446 ns |  2.2355 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.1243 ns | 0.6058 ns | 0.0332 ns |  2.1105 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.1785 ns | 1.8213 ns | 0.0998 ns |  6.2318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.4690 ns | 0.9910 ns | 0.0543 ns |  2.4597 ns |  0.40 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.5792 ns | 0.4297 ns | 0.0236 ns | 13.5746 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.5295 ns | 0.8639 ns | 0.0474 ns |  8.5444 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.4320 ns | 1.5700 ns | 0.0861 ns |  2.4319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.4013 ns | 0.8322 ns | 0.0456 ns |  2.3912 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  1.9818 ns | 0.0936 ns | 0.0051 ns |  1.9791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.7248 ns | 0.2928 ns | 0.0160 ns |  1.7192 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.3126 ns | 0.2480 ns | 0.0136 ns |  4.3105 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.8890 ns | 0.7409 ns | 0.0406 ns |  3.8690 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.3819 ns | 3.3742 ns | 0.1850 ns | 13.2864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.2245 ns | 0.3202 ns | 0.0176 ns |  4.2183 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.5173 ns | 0.7883 ns | 0.0432 ns |  8.5175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.7338 ns | 0.2851 ns | 0.0156 ns |  7.7401 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.2231 ns | 0.3652 ns | 0.0200 ns | 13.2142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.9854 ns | 0.7576 ns | 0.0415 ns | 12.0076 ns |  0.91 |    0.00 |      - |     - |     - |         - |
