
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   1.492 ns |  0.5656 ns | 0.0310 ns |   1.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   1.558 ns |  0.5068 ns | 0.0278 ns |   1.547 ns |  1.04 |    0.04 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   4.650 ns |  0.5536 ns | 0.0303 ns |   4.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   4.669 ns |  0.6976 ns | 0.0382 ns |   4.669 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   1.251 ns |  1.0950 ns | 0.0600 ns |   1.224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.187 ns |  0.0767 ns | 0.0042 ns |   1.190 ns |  0.95 |    0.04 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.200 ns |  0.3811 ns | 0.0209 ns |   4.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   3.827 ns |  1.7804 ns | 0.0976 ns |   3.799 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   4.796 ns |  1.6363 ns | 0.0897 ns |   4.843 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   4.808 ns |  1.8942 ns | 0.1038 ns |   4.756 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   6.969 ns |  0.6573 ns | 0.0360 ns |   6.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   6.965 ns |  0.7822 ns | 0.0429 ns |   6.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   4.792 ns |  0.8727 ns | 0.0478 ns |   4.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   3.567 ns |  0.7593 ns | 0.0416 ns |   3.575 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   7.006 ns |  0.1105 ns | 0.0061 ns |   7.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   6.219 ns |  0.7307 ns | 0.0401 ns |   6.200 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   4.999 ns |  1.2589 ns | 0.0690 ns |   4.971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   5.067 ns |  0.4279 ns | 0.0235 ns |   5.070 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   6.991 ns |  0.4021 ns | 0.0220 ns |   7.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   6.987 ns |  0.5487 ns | 0.0301 ns |   7.000 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   4.760 ns |  0.6266 ns | 0.0343 ns |   4.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   3.486 ns |  0.6051 ns | 0.0332 ns |   3.485 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   7.020 ns |  0.4518 ns | 0.0248 ns |   7.026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   6.257 ns |  0.1888 ns | 0.0103 ns |   6.257 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   3.411 ns |  0.5753 ns | 0.0315 ns |   3.395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   3.530 ns |  1.1440 ns | 0.0627 ns |   3.556 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   6.443 ns |  1.6398 ns | 0.0899 ns |   6.490 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   6.454 ns |  0.9466 ns | 0.0519 ns |   6.475 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   3.416 ns |  0.4200 ns | 0.0230 ns |   3.410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   3.432 ns |  0.2706 ns | 0.0148 ns |   3.428 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   6.242 ns |  0.4288 ns | 0.0235 ns |   6.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   6.277 ns |  0.2878 ns | 0.0158 ns |   6.279 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   2.860 ns |  1.1112 ns | 0.0609 ns |   2.861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   2.824 ns |  0.6155 ns | 0.0337 ns |   2.842 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   3.441 ns |  0.1923 ns | 0.0105 ns |   3.436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   3.733 ns |  1.0332 ns | 0.0566 ns |   3.748 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   2.801 ns |  1.1601 ns | 0.0636 ns |   2.827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   2.820 ns |  0.8823 ns | 0.0484 ns |   2.815 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   3.607 ns |  0.9591 ns | 0.0526 ns |   3.584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   3.504 ns |  0.4086 ns | 0.0224 ns |   3.501 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   1.533 ns |  0.9108 ns | 0.0499 ns |   1.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.785 ns |  0.6213 ns | 0.0341 ns |   1.782 ns |  1.17 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   4.450 ns |  0.2018 ns | 0.0111 ns |   4.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   4.442 ns |  0.5586 ns | 0.0306 ns |   4.455 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   1.642 ns |  0.1202 ns | 0.0066 ns |   1.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   1.261 ns |  0.6527 ns | 0.0358 ns |   1.244 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   1.953 ns |  1.6106 ns | 0.0883 ns |   1.987 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   1.873 ns |  0.4238 ns | 0.0232 ns |   1.862 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  12.433 ns |  0.9485 ns | 0.0520 ns |  12.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  11.881 ns |  1.2734 ns | 0.0698 ns |  11.880 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  18.568 ns | 17.8507 ns | 0.9785 ns |  18.124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  16.058 ns |  0.6341 ns | 0.0348 ns |  16.050 ns |  0.87 |    0.05 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   2.388 ns |  0.7751 ns | 0.0425 ns |   2.382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   2.356 ns |  0.7018 ns | 0.0385 ns |   2.366 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   2.011 ns |  0.3046 ns | 0.0167 ns |   2.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   1.719 ns |  0.6593 ns | 0.0361 ns |   1.733 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   4.235 ns |  1.2198 ns | 0.0669 ns |   4.234 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   3.848 ns |  0.7192 ns | 0.0394 ns |   3.868 ns |  0.91 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 114.473 ns | 14.0861 ns | 0.7721 ns | 114.285 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  89.627 ns |  8.0587 ns | 0.4417 ns |  89.524 ns |  0.78 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  10.481 ns |  0.3615 ns | 0.0198 ns |  10.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  10.029 ns |  1.0080 ns | 0.0553 ns |  10.003 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  14.964 ns |  1.4863 ns | 0.0815 ns |  14.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  14.017 ns |  0.7032 ns | 0.0385 ns |  14.014 ns |  0.94 |    0.01 |      - |     - |     - |         - |
