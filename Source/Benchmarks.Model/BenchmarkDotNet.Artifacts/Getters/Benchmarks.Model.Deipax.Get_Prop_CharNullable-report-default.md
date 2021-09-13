
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.148 ns | 0.8294 ns | 0.0455 ns |  1.133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.204 ns | 0.0572 ns | 0.0031 ns |  1.206 ns |  1.05 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.017 ns | 0.4397 ns | 0.0241 ns |  4.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.791 ns | 0.3450 ns | 0.0189 ns |  3.796 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.636 ns | 0.8508 ns | 0.0466 ns |  1.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.460 ns | 0.6576 ns | 0.0360 ns |  1.442 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  1.221 ns | 0.3811 ns | 0.0209 ns |  1.216 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  1.164 ns | 0.1473 ns | 0.0081 ns |  1.162 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.824 ns | 3.0834 ns | 0.1690 ns |  1.837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.550 ns | 0.3673 ns | 0.0201 ns |  1.540 ns |  0.85 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.439 ns | 0.0243 ns | 0.0013 ns |  4.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.000 ns | 0.3186 ns | 0.0175 ns |  4.002 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.545 ns | 0.3973 ns | 0.0218 ns |  1.534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.687 ns | 0.3765 ns | 0.0206 ns |  1.680 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.424 ns | 0.6246 ns | 0.0342 ns |  4.405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.981 ns | 0.3340 ns | 0.0183 ns |  3.987 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.729 ns | 0.0117 ns | 0.0006 ns |  1.729 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.900 ns | 1.4548 ns | 0.0797 ns |  1.862 ns |  1.10 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.549 ns | 1.5483 ns | 0.0849 ns |  4.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.085 ns | 1.5374 ns | 0.0843 ns |  4.058 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.388 ns | 0.5421 ns | 0.0297 ns |  1.373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.542 ns | 0.6457 ns | 0.0354 ns |  1.523 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.022 ns | 0.0937 ns | 0.0051 ns |  4.022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.310 ns | 4.5621 ns | 0.2501 ns |  4.398 ns |  1.07 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.612 ns | 0.9676 ns | 0.0530 ns |  1.605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.531 ns | 0.7901 ns | 0.0433 ns |  1.519 ns |  0.95 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.038 ns | 0.2766 ns | 0.0152 ns |  4.038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.991 ns | 0.2908 ns | 0.0159 ns |  3.983 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.469 ns | 0.1093 ns | 0.0060 ns |  1.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.514 ns | 0.5255 ns | 0.0288 ns |  1.502 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.022 ns | 0.0665 ns | 0.0036 ns |  4.020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.296 ns | 6.1179 ns | 0.3353 ns |  4.232 ns |  1.07 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.336 ns | 0.4695 ns | 0.0257 ns |  1.327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.690 ns | 0.1932 ns | 0.0106 ns |  1.684 ns |  1.27 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.097 ns | 1.8767 ns | 0.1029 ns |  2.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.024 ns | 1.4485 ns | 0.0794 ns |  2.066 ns |  0.97 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.553 ns | 1.6924 ns | 0.0928 ns |  1.508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.781 ns | 0.1133 ns | 0.0062 ns |  1.778 ns |  1.15 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.767 ns | 0.1627 ns | 0.0089 ns |  1.767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.266 ns | 0.5676 ns | 0.0311 ns |  2.249 ns |  1.28 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.581 ns | 0.7292 ns | 0.0400 ns |  1.570 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.448 ns | 0.7341 ns | 0.0402 ns |  1.427 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.241 ns | 0.5871 ns | 0.0322 ns |  4.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.124 ns | 2.3994 ns | 0.1315 ns |  4.062 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.113 ns | 0.3738 ns | 0.0205 ns |  1.113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.219 ns | 0.4003 ns | 0.0219 ns |  1.222 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.761 ns | 0.4845 ns | 0.0266 ns |  1.761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.982 ns | 2.0215 ns | 0.1108 ns |  1.930 ns |  1.13 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  2.009 ns | 0.2224 ns | 0.0122 ns |  2.003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.909 ns | 0.0563 ns | 0.0031 ns |  1.907 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  1.588 ns | 1.1110 ns | 0.0609 ns |  1.580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  2.135 ns | 0.4961 ns | 0.0272 ns |  2.126 ns |  1.35 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.288 ns | 1.5823 ns | 0.0867 ns |  2.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.391 ns | 0.0849 ns | 0.0047 ns |  2.390 ns |  1.05 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.537 ns | 0.4978 ns | 0.0273 ns |  2.551 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.685 ns | 0.5145 ns | 0.0282 ns |  1.673 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.763 ns | 0.2370 ns | 0.0130 ns |  4.770 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.899 ns | 1.0332 ns | 0.0566 ns |  3.910 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 |  4.617 ns | 1.7881 ns | 0.0980 ns |  4.560 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  4.483 ns | 4.1390 ns | 0.2269 ns |  4.368 ns |  0.97 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.485 ns | 1.9423 ns | 0.1065 ns |  8.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  8.001 ns | 0.1142 ns | 0.0063 ns |  8.004 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.235 ns | 0.9647 ns | 0.0529 ns | 13.241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.037 ns | 0.6420 ns | 0.0352 ns | 12.031 ns |  0.91 |    0.00 |      - |     - |     - |         - |
