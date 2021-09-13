
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.466 ns |  2.2585 ns | 0.1238 ns |  1.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.546 ns |  0.4542 ns | 0.0249 ns |  1.545 ns |  1.06 |    0.10 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.973 ns |  0.1787 ns | 0.0098 ns |  3.975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.784 ns |  0.7295 ns | 0.0400 ns |  3.797 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.478 ns |  0.5088 ns | 0.0279 ns |  2.485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  2.218 ns |  0.1800 ns | 0.0099 ns |  2.213 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.500 ns |  0.1560 ns | 0.0086 ns |  4.496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.197 ns |  0.3220 ns | 0.0176 ns |  4.188 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.226 ns |  0.2963 ns | 0.0162 ns |  1.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.209 ns |  0.2132 ns | 0.0117 ns |  1.209 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.596 ns |  4.2783 ns | 0.2345 ns |  4.502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.860 ns |  0.7417 ns | 0.0407 ns |  3.858 ns |  0.84 |    0.04 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.556 ns |  0.0839 ns | 0.0046 ns |  2.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  2.254 ns |  0.2076 ns | 0.0114 ns |  2.255 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.529 ns |  0.5278 ns | 0.0289 ns |  4.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.197 ns |  0.1877 ns | 0.0103 ns |  4.199 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.504 ns |  0.6252 ns | 0.0343 ns |  2.495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.564 ns |  0.5852 ns | 0.0321 ns |  2.548 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.468 ns |  0.2778 ns | 0.0152 ns |  4.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.432 ns |  2.1953 ns | 0.1203 ns |  4.461 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.493 ns |  0.9429 ns | 0.0517 ns |  2.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  2.702 ns |  2.0154 ns | 0.1105 ns |  2.736 ns |  1.08 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.390 ns |  0.5152 ns | 0.0282 ns |  4.399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.295 ns |  0.7811 ns | 0.0428 ns |  4.289 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  2.607 ns |  4.5866 ns | 0.2514 ns |  2.489 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  2.457 ns |  0.4771 ns | 0.0261 ns |  2.450 ns |  0.95 |    0.08 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.439 ns |  0.3086 ns | 0.0169 ns |  4.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.182 ns |  0.2858 ns | 0.0157 ns |  4.183 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.247 ns |  0.7247 ns | 0.0397 ns |  1.226 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.233 ns |  0.2687 ns | 0.0147 ns |  1.232 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.951 ns |  0.3045 ns | 0.0167 ns |  3.942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.796 ns |  0.1887 ns | 0.0103 ns |  3.796 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.455 ns |  0.1517 ns | 0.0083 ns |  1.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.357 ns |  2.2563 ns | 0.1237 ns |  1.374 ns |  0.93 |    0.09 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.709 ns |  0.2177 ns | 0.0119 ns |  1.715 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.845 ns |  1.4313 ns | 0.0785 ns |  1.855 ns |  1.08 |    0.04 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.186 ns |  0.4134 ns | 0.0227 ns |  1.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.245 ns |  0.0195 ns | 0.0011 ns |  1.245 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.746 ns |  2.2590 ns | 0.1238 ns |  1.691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.695 ns |  0.3329 ns | 0.0182 ns |  1.689 ns |  0.97 |    0.08 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.532 ns |  0.0477 ns | 0.0026 ns |  1.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.776 ns |  4.1738 ns | 0.2288 ns |  1.741 ns |  1.16 |    0.15 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.433 ns |  0.2049 ns | 0.0112 ns |  4.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.361 ns |  3.6383 ns | 0.1994 ns |  4.264 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.716 ns |  0.0450 ns | 0.0025 ns |  1.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.534 ns |  0.0929 ns | 0.0051 ns |  1.537 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.076 ns |  2.5505 ns | 0.1398 ns |  2.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.997 ns |  0.4001 ns | 0.0219 ns |  1.990 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.303 ns |  7.4219 ns | 0.4068 ns |  6.169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.798 ns |  1.1051 ns | 0.0606 ns |  1.780 ns |  0.29 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.916 ns |  0.3396 ns | 0.0186 ns | 12.915 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.089 ns |  2.3457 ns | 0.1286 ns |  7.082 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.143 ns |  0.1143 ns | 0.0063 ns |  2.143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.336 ns |  2.9440 ns | 0.1614 ns |  2.244 ns |  1.09 |    0.08 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.065 ns |  0.8905 ns | 0.0488 ns |  2.085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.861 ns |  2.8318 ns | 0.1552 ns |  1.859 ns |  0.90 |    0.08 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.635 ns |  0.5888 ns | 0.0323 ns |  3.621 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.698 ns |  0.6102 ns | 0.0334 ns |  3.708 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |           |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.567 ns | 11.5699 ns | 0.6342 ns | 13.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.289 ns |  4.3158 ns | 0.2366 ns |  4.384 ns |  0.32 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.650 ns |  0.9504 ns | 0.0521 ns |  8.650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  8.361 ns |  5.3341 ns | 0.2924 ns |  8.201 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.143 ns |  0.7264 ns | 0.0398 ns | 13.161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.150 ns |  0.7062 ns | 0.0387 ns | 12.165 ns |  0.92 |    0.00 |      - |     - |     - |         - |
