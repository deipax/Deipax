
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |        Mean |      Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|-----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   1.7705 ns |  0.0874 ns | 0.0048 ns |   1.7728 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   1.9458 ns |  0.6423 ns | 0.0352 ns |   1.9320 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   4.6906 ns |  0.0667 ns | 0.0037 ns |   4.6912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   4.7472 ns |  0.1281 ns | 0.0070 ns |   4.7476 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   1.2133 ns |  0.1994 ns | 0.0109 ns |   1.2141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.1715 ns |  0.3165 ns | 0.0173 ns |   1.1630 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.2715 ns |  0.5027 ns | 0.0276 ns |   4.2591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   4.0529 ns |  6.4994 ns | 0.3563 ns |   3.8974 ns |  0.95 |    0.09 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   5.1463 ns |  0.2930 ns | 0.0161 ns |   5.1440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   5.5151 ns |  9.2803 ns | 0.5087 ns |   5.2404 ns |  1.07 |    0.10 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   7.4292 ns |  0.7306 ns | 0.0400 ns |   7.4151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   7.4137 ns |  3.2626 ns | 0.1788 ns |   7.4308 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   5.2852 ns |  0.7640 ns | 0.0419 ns |   5.2703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   3.8925 ns |  2.7781 ns | 0.1523 ns |   3.8116 ns |  0.74 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   7.4665 ns |  1.3038 ns | 0.0715 ns |   7.4585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   6.4939 ns |  0.6067 ns | 0.0333 ns |   6.5085 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   5.2317 ns |  2.7091 ns | 0.1485 ns |   5.1666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   5.0624 ns |  0.4968 ns | 0.0272 ns |   5.0585 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   7.3812 ns |  0.4668 ns | 0.0256 ns |   7.3693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   7.0518 ns |  0.8746 ns | 0.0479 ns |   7.0780 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   5.0002 ns |  0.1526 ns | 0.0084 ns |   5.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   3.7769 ns |  0.8305 ns | 0.0455 ns |   3.7685 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   7.3059 ns |  0.9915 ns | 0.0543 ns |   7.3224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   6.3600 ns |  1.5816 ns | 0.0867 ns |   6.3361 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   3.7893 ns |  0.7470 ns | 0.0409 ns |   3.7869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   3.6450 ns |  0.3384 ns | 0.0185 ns |   3.6343 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   6.5343 ns |  0.2898 ns | 0.0159 ns |   6.5321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   6.2775 ns |  0.1896 ns | 0.0104 ns |   6.2728 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   3.6840 ns |  0.2479 ns | 0.0136 ns |   3.6896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   3.9748 ns |  9.8527 ns | 0.5401 ns |   3.7636 ns |  1.08 |    0.15 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   6.5921 ns |  0.1340 ns | 0.0073 ns |   6.5910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   6.3041 ns |  0.4901 ns | 0.0269 ns |   6.2906 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   3.1043 ns |  0.4254 ns | 0.0233 ns |   3.1143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   3.0938 ns |  0.5348 ns | 0.0293 ns |   3.0846 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   3.6955 ns |  0.9355 ns | 0.0513 ns |   3.6681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   3.7056 ns |  1.0071 ns | 0.0552 ns |   3.6864 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   3.0976 ns |  1.0084 ns | 0.0553 ns |   3.0735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   3.0819 ns |  0.7179 ns | 0.0394 ns |   3.0717 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   3.6977 ns |  0.5385 ns | 0.0295 ns |   3.6957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   3.7561 ns |  0.1423 ns | 0.0078 ns |   3.7602 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   1.6461 ns |  0.2936 ns | 0.0161 ns |   1.6406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.2482 ns |  0.0462 ns | 0.0025 ns |   1.2474 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   0.9808 ns |  0.1620 ns | 0.0089 ns |   0.9804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   1.2510 ns |  0.3203 ns | 0.0176 ns |   1.2490 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   1.4484 ns |  0.4722 ns | 0.0259 ns |   1.4632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   1.5513 ns |  0.4365 ns | 0.0239 ns |   1.5551 ns |  1.07 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   2.3023 ns |  4.4998 ns | 0.2467 ns |   2.1762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   2.1935 ns |  0.4915 ns | 0.0269 ns |   2.1805 ns |  0.96 |    0.10 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  11.6293 ns |  1.0594 ns | 0.0581 ns |  11.6202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  10.9818 ns |  1.2216 ns | 0.0670 ns |  10.9486 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  17.3896 ns | 24.7489 ns | 1.3566 ns |  16.6136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  15.2516 ns |  1.0594 ns | 0.0581 ns |  15.2473 ns |  0.88 |    0.07 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   2.2686 ns |  0.6029 ns | 0.0330 ns |   2.2834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   2.4210 ns |  0.6266 ns | 0.0343 ns |   2.4288 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   2.3831 ns |  1.3930 ns | 0.0764 ns |   2.4103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   1.8068 ns |  0.2985 ns | 0.0164 ns |   1.7985 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   4.6620 ns |  0.8631 ns | 0.0473 ns |   4.6488 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   4.2105 ns |  1.6579 ns | 0.0909 ns |   4.2270 ns |  0.90 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 116.5404 ns | 30.5412 ns | 1.6741 ns | 115.5864 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  96.3943 ns | 94.8065 ns | 5.1967 ns |  93.5208 ns |  0.83 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  11.0391 ns |  9.7309 ns | 0.5334 ns |  10.7738 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  10.5248 ns |  0.3905 ns | 0.0214 ns |  10.5334 ns |  0.95 |    0.05 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  14.8367 ns |  1.0063 ns | 0.0552 ns |  14.8069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  14.2234 ns |  2.0488 ns | 0.1123 ns |  14.1726 ns |  0.96 |    0.00 |      - |     - |     - |         - |
