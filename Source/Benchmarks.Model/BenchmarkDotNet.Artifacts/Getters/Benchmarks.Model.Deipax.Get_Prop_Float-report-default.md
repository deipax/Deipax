
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   1.374 ns |  2.8348 ns | 0.1554 ns |   1.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   1.537 ns |  3.0991 ns | 0.1699 ns |   1.634 ns |  1.13 |    0.22 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   4.396 ns |  0.0441 ns | 0.0024 ns |   4.396 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   4.275 ns |  0.5654 ns | 0.0310 ns |   4.292 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   1.076 ns |  0.3311 ns | 0.0182 ns |   1.084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.257 ns |  0.7039 ns | 0.0386 ns |   1.269 ns |  1.17 |    0.05 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.033 ns |  0.2837 ns | 0.0156 ns |   4.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   3.763 ns |  0.6124 ns | 0.0336 ns |   3.748 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   5.026 ns |  0.4006 ns | 0.0220 ns |   5.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   4.994 ns |  0.8571 ns | 0.0470 ns |   5.013 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   7.571 ns |  2.0930 ns | 0.1147 ns |   7.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   7.251 ns | 11.1885 ns | 0.6133 ns |   6.960 ns |  0.96 |    0.07 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   5.873 ns | 11.8003 ns | 0.6468 ns |   5.542 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   3.486 ns |  0.2661 ns | 0.0146 ns |   3.483 ns |  0.60 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   7.271 ns |  2.3409 ns | 0.1283 ns |   7.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   6.689 ns | 11.1669 ns | 0.6121 ns |   6.498 ns |  0.92 |    0.07 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   5.103 ns |  0.5466 ns | 0.0300 ns |   5.107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   5.313 ns |  0.6492 ns | 0.0356 ns |   5.310 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   7.224 ns |  1.1682 ns | 0.0640 ns |   7.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   7.024 ns |  0.1939 ns | 0.0106 ns |   7.024 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   5.262 ns |  0.0615 ns | 0.0034 ns |   5.260 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   3.492 ns |  0.6386 ns | 0.0350 ns |   3.497 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   7.649 ns |  8.5458 ns | 0.4684 ns |   7.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   6.034 ns |  1.0752 ns | 0.0589 ns |   6.007 ns |  0.79 |    0.05 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   3.412 ns |  0.0361 ns | 0.0020 ns |   3.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   3.407 ns |  0.5342 ns | 0.0293 ns |   3.397 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   6.352 ns |  1.4825 ns | 0.0813 ns |   6.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   6.075 ns |  0.5102 ns | 0.0280 ns |   6.085 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   3.529 ns |  0.2190 ns | 0.0120 ns |   3.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   3.593 ns |  0.9810 ns | 0.0538 ns |   3.590 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   6.287 ns |  0.4932 ns | 0.0270 ns |   6.292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   6.145 ns |  0.2782 ns | 0.0152 ns |   6.152 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   2.969 ns |  1.5771 ns | 0.0864 ns |   2.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   2.880 ns |  0.0514 ns | 0.0028 ns |   2.881 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   3.446 ns |  0.9643 ns | 0.0529 ns |   3.417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   3.441 ns |  0.1675 ns | 0.0092 ns |   3.443 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   2.868 ns |  0.6306 ns | 0.0346 ns |   2.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   2.995 ns |  2.4569 ns | 0.1347 ns |   2.932 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   3.426 ns |  0.9686 ns | 0.0531 ns |   3.416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   3.975 ns |  7.0762 ns | 0.3879 ns |   3.941 ns |  1.16 |    0.10 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   1.632 ns |  0.3596 ns | 0.0197 ns |   1.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.231 ns |  0.1425 ns | 0.0078 ns |   1.234 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   4.278 ns |  0.4127 ns | 0.0226 ns |   4.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   3.533 ns |  0.1960 ns | 0.0107 ns |   3.531 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   1.291 ns |  2.1112 ns | 0.1157 ns |   1.342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   1.216 ns |  0.1861 ns | 0.0102 ns |   1.215 ns |  0.95 |    0.10 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   1.554 ns |  0.5481 ns | 0.0300 ns |   1.541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   1.711 ns |  0.2131 ns | 0.0117 ns |   1.715 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  11.871 ns |  2.5175 ns | 0.1380 ns |  11.793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |   9.816 ns |  0.0070 ns | 0.0004 ns |   9.816 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  16.930 ns |  0.8202 ns | 0.0450 ns |  16.926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  14.665 ns |  1.6135 ns | 0.0884 ns |  14.663 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   2.206 ns |  0.5381 ns | 0.0295 ns |   2.192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   2.343 ns |  0.1312 ns | 0.0072 ns |   2.345 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   2.012 ns |  0.0917 ns | 0.0050 ns |   2.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   1.725 ns |  0.1101 ns | 0.0060 ns |   1.727 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   4.287 ns | 11.0449 ns | 0.6054 ns |   4.116 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   4.035 ns |  2.0338 ns | 0.1115 ns |   4.073 ns |  0.96 |    0.15 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 115.702 ns | 13.9481 ns | 0.7645 ns | 115.934 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  90.073 ns |  5.8785 ns | 0.3222 ns |  90.196 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  10.366 ns |  0.8610 ns | 0.0472 ns |  10.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  10.321 ns |  0.1355 ns | 0.0074 ns |  10.321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  15.068 ns |  0.7116 ns | 0.0390 ns |  15.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  14.012 ns |  2.4686 ns | 0.1353 ns |  13.982 ns |  0.93 |    0.01 |      - |     - |     - |         - |
