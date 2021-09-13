
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.6315 ns |  0.0158 ns | 0.0009 ns |  1.6317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.6882 ns |  0.1384 ns | 0.0076 ns |  1.6849 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.4738 ns |  0.1175 ns | 0.0064 ns |  4.4749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.0287 ns |  0.1615 ns | 0.0089 ns |  4.0334 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.6430 ns |  0.3069 ns | 0.0168 ns |  2.6417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.8101 ns |  0.5486 ns | 0.0301 ns |  1.8162 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.7068 ns |  0.4393 ns | 0.0241 ns |  4.6962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.2731 ns |  0.4723 ns | 0.0259 ns |  4.2758 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.6852 ns |  0.0560 ns | 0.0031 ns |  2.6860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  3.5382 ns |  0.1104 ns | 0.0061 ns |  3.5391 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.7537 ns |  3.2547 ns | 0.1784 ns |  4.6537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.7215 ns |  0.5672 ns | 0.0311 ns |  4.7074 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.6622 ns |  0.3388 ns | 0.0186 ns |  2.6634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.5504 ns |  0.2668 ns | 0.0146 ns |  1.5445 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.6822 ns |  0.4882 ns | 0.0268 ns |  4.6862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.2969 ns |  1.5620 ns | 0.0856 ns |  4.2571 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.6896 ns |  0.0768 ns | 0.0042 ns |  2.6882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.9620 ns |  0.5347 ns | 0.0293 ns |  2.9580 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.7072 ns |  0.4010 ns | 0.0220 ns |  4.7118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.7391 ns |  0.1555 ns | 0.0085 ns |  4.7431 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.6434 ns |  0.3843 ns | 0.0211 ns |  2.6393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.7185 ns |  0.2467 ns | 0.0135 ns |  1.7217 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.7388 ns |  0.2348 ns | 0.0129 ns |  4.7452 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.0975 ns |  0.5294 ns | 0.0290 ns |  4.1060 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.6124 ns |  0.4975 ns | 0.0273 ns |  1.6173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.2538 ns |  0.4494 ns | 0.0246 ns |  1.2453 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  0.9491 ns |  0.1702 ns | 0.0093 ns |  0.9543 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  1.2351 ns |  0.4150 ns | 0.0227 ns |  1.2482 ns |  1.30 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.2882 ns |  0.2084 ns | 0.0114 ns |  1.2847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.7980 ns |  0.1956 ns | 0.0107 ns |  1.7963 ns |  1.40 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.0456 ns |  0.1400 ns | 0.0077 ns |  4.0427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.0443 ns |  0.4435 ns | 0.0243 ns |  4.0576 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.5634 ns |  0.2508 ns | 0.0137 ns |  1.5623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.7793 ns |  1.2177 ns | 0.0667 ns |  1.7476 ns |  1.14 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.4592 ns |  0.2265 ns | 0.0124 ns |  2.4611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.2039 ns |  0.4050 ns | 0.0222 ns |  2.2136 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.6882 ns |  1.7566 ns | 0.0963 ns |  1.6341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.6984 ns |  0.1731 ns | 0.0095 ns |  1.6931 ns |  1.01 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.2623 ns |  0.1483 ns | 0.0081 ns |  2.2598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.1657 ns |  0.0539 ns | 0.0030 ns |  2.1641 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.4225 ns |  0.4343 ns | 0.0238 ns |  1.4341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.8544 ns |  1.0078 ns | 0.0552 ns |  1.8496 ns |  1.30 |    0.04 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.7119 ns |  0.1640 ns | 0.0090 ns |  4.7070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.2738 ns |  0.1587 ns | 0.0087 ns |  4.2689 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.4325 ns |  0.1457 ns | 0.0080 ns |  1.4315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.7793 ns |  0.1821 ns | 0.0100 ns |  1.7767 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.1368 ns |  0.1257 ns | 0.0069 ns |  2.1343 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.2673 ns |  0.9257 ns | 0.0507 ns |  2.2662 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.0887 ns |  0.3793 ns | 0.0208 ns |  6.0781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.4309 ns |  0.4373 ns | 0.0240 ns |  2.4193 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.8690 ns |  1.0371 ns | 0.0568 ns | 12.8392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.1624 ns |  2.0412 ns | 0.1119 ns |  8.1719 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.1610 ns |  1.1794 ns | 0.0646 ns |  2.1287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.3434 ns |  1.0925 ns | 0.0599 ns |  2.3098 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0183 ns |  0.1934 ns | 0.0106 ns |  2.0187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  2.1680 ns |  3.9239 ns | 0.2151 ns |  2.2469 ns |  1.07 |    0.11 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.8877 ns |  0.1386 ns | 0.0076 ns |  4.8860 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.8928 ns |  0.5957 ns | 0.0327 ns |  3.8889 ns |  0.80 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.8473 ns |  1.7768 ns | 0.0974 ns | 13.8039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.8575 ns |  0.2447 ns | 0.0134 ns |  3.8604 ns |  0.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.3656 ns |  0.6988 ns | 0.0383 ns |  8.3507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.7718 ns |  0.3687 ns | 0.0202 ns |  7.7705 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.9804 ns |  0.3328 ns | 0.0182 ns | 12.9704 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 13.3976 ns | 15.2748 ns | 0.8373 ns | 13.6560 ns |  1.03 |    0.07 |      - |     - |     - |         - |
