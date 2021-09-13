
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.0396 ns | 0.0334 ns | 0.0018 ns |  1.0401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.2229 ns | 0.2379 ns | 0.0130 ns |  1.2182 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.0148 ns | 0.1750 ns | 0.0096 ns |  4.0157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7780 ns | 0.2118 ns | 0.0116 ns |  3.7799 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.0753 ns | 0.3953 ns | 0.0217 ns |  1.0771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.2377 ns | 0.5607 ns | 0.0307 ns |  1.2215 ns |  1.15 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.0131 ns | 0.5756 ns | 0.0315 ns |  3.9960 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7706 ns | 0.4945 ns | 0.0271 ns |  3.7698 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.1180 ns | 0.0635 ns | 0.0035 ns |  2.1186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.3373 ns | 0.7665 ns | 0.0420 ns |  2.3592 ns |  1.10 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.7125 ns | 0.2653 ns | 0.0145 ns |  4.7119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.4739 ns | 0.3360 ns | 0.0184 ns |  4.4747 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.9921 ns | 0.4961 ns | 0.0272 ns |  1.9863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.4343 ns | 0.3190 ns | 0.0175 ns |  1.4252 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.7331 ns | 0.1280 ns | 0.0070 ns |  4.7329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.7713 ns | 0.2536 ns | 0.0139 ns |  3.7638 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  0.9877 ns | 0.4572 ns | 0.0251 ns |  0.9990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.2149 ns | 0.8017 ns | 0.0439 ns |  1.1912 ns |  1.23 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.2488 ns | 0.5138 ns | 0.0282 ns |  4.2640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.5576 ns | 0.1389 ns | 0.0076 ns |  3.5598 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.1227 ns | 1.5881 ns | 0.0870 ns |  1.1234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.2485 ns | 0.3243 ns | 0.0178 ns |  1.2446 ns |  1.12 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.0486 ns | 0.3402 ns | 0.0186 ns |  4.0435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7919 ns | 0.3590 ns | 0.0197 ns |  3.7857 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  0.9788 ns | 0.4802 ns | 0.0263 ns |  0.9686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.1919 ns | 0.3225 ns | 0.0177 ns |  1.1842 ns |  1.22 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.0187 ns | 0.2484 ns | 0.0136 ns |  4.0241 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.7897 ns | 0.1093 ns | 0.0060 ns |  3.7894 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.0416 ns | 0.3583 ns | 0.0196 ns |  1.0380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.2394 ns | 0.7919 ns | 0.0434 ns |  1.2329 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.7946 ns | 0.2028 ns | 0.0111 ns |  3.7997 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.5629 ns | 0.2553 ns | 0.0140 ns |  3.5611 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  0.9822 ns | 0.1213 ns | 0.0066 ns |  0.9819 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.2052 ns | 0.4149 ns | 0.0227 ns |  1.1938 ns |  1.23 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.9237 ns | 0.8292 ns | 0.0455 ns |  1.8984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.0539 ns | 1.1092 ns | 0.0608 ns |  2.0473 ns |  1.07 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.0622 ns | 0.1941 ns | 0.0106 ns |  1.0599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.4452 ns | 0.0603 ns | 0.0033 ns |  1.4454 ns |  1.36 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.7019 ns | 0.5723 ns | 0.0314 ns |  1.6856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.7430 ns | 0.2960 ns | 0.0162 ns |  1.7390 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.1655 ns | 0.0691 ns | 0.0038 ns |  1.1669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.2319 ns | 0.1857 ns | 0.0102 ns |  1.2296 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.2637 ns | 0.2748 ns | 0.0151 ns |  4.2550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.0833 ns | 2.9226 ns | 0.1602 ns |  3.9971 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.1795 ns | 0.3981 ns | 0.0218 ns |  1.1899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.2334 ns | 0.4977 ns | 0.0273 ns |  1.2265 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.7185 ns | 0.5102 ns | 0.0280 ns |  1.7233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.9845 ns | 0.1225 ns | 0.0067 ns |  1.9864 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.1265 ns | 0.6749 ns | 0.0370 ns |  6.1201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.9908 ns | 0.8724 ns | 0.0478 ns |  1.9713 ns |  0.32 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.6592 ns | 0.4006 ns | 0.0220 ns | 12.6492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.5462 ns | 0.5922 ns | 0.0325 ns |  7.5279 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.0078 ns | 0.7900 ns | 0.0433 ns |  1.9863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.3704 ns | 0.3531 ns | 0.0194 ns |  2.3781 ns |  1.18 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0304 ns | 0.1367 ns | 0.0075 ns |  2.0339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  2.0414 ns | 0.1079 ns | 0.0059 ns |  2.0432 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.6491 ns | 0.4140 ns | 0.0227 ns |  3.6449 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.6815 ns | 1.0291 ns | 0.0564 ns |  3.7005 ns |  1.01 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.5337 ns | 0.7765 ns | 0.0426 ns | 13.5133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.4124 ns | 0.2026 ns | 0.0111 ns |  3.4180 ns |  0.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.2855 ns | 0.1481 ns | 0.0081 ns |  8.2816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.5002 ns | 0.5431 ns | 0.0298 ns |  7.5061 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.6592 ns | 0.5236 ns | 0.0287 ns | 12.6621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.5144 ns | 0.3914 ns | 0.0215 ns | 11.5122 ns |  0.91 |    0.00 |      - |     - |     - |         - |
