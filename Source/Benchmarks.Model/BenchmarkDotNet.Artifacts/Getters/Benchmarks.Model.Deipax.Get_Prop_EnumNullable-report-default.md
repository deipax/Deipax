
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.4770 ns | 0.4543 ns | 0.0249 ns |  1.4851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.4902 ns | 0.0379 ns | 0.0021 ns |  1.4893 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.4922 ns | 0.4261 ns | 0.0234 ns |  4.4894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.9736 ns | 0.2395 ns | 0.0131 ns |  3.9793 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.7451 ns | 0.1741 ns | 0.0095 ns |  2.7457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.4937 ns | 0.0525 ns | 0.0029 ns |  1.4926 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.7840 ns | 2.8922 ns | 0.1585 ns |  4.7053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.2304 ns | 0.4725 ns | 0.0259 ns |  4.2427 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.5026 ns | 0.9582 ns | 0.0525 ns |  2.4979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.8485 ns | 1.0482 ns | 0.0575 ns |  2.8469 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.6613 ns | 0.3141 ns | 0.0172 ns |  4.6532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.6725 ns | 0.4382 ns | 0.0240 ns |  4.6665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.9632 ns | 2.2820 ns | 0.1251 ns |  2.9473 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.3615 ns | 0.6001 ns | 0.0329 ns |  1.3674 ns |  0.46 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.7120 ns | 0.1013 ns | 0.0056 ns |  4.7100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.2352 ns | 0.1395 ns | 0.0076 ns |  4.2374 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.5019 ns | 0.1649 ns | 0.0090 ns |  2.5025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.5440 ns | 0.3730 ns | 0.0204 ns |  2.5483 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  5.0958 ns | 7.1636 ns | 0.3927 ns |  5.1766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.6997 ns | 0.2682 ns | 0.0147 ns |  4.7050 ns |  0.93 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.4243 ns | 0.1188 ns | 0.0065 ns |  2.4264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.5009 ns | 0.6810 ns | 0.0373 ns |  1.4835 ns |  0.62 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.6944 ns | 0.3532 ns | 0.0194 ns |  4.7005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.2653 ns | 0.5509 ns | 0.0302 ns |  4.2617 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.5720 ns | 0.7397 ns | 0.0405 ns |  1.5880 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.5859 ns | 4.1970 ns | 0.2301 ns |  1.5871 ns |  1.01 |    0.13 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9670 ns | 0.2084 ns | 0.0114 ns |  3.9611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.7616 ns | 0.3718 ns | 0.0204 ns |  3.7653 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.4705 ns | 0.1507 ns | 0.0083 ns |  1.4693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.3353 ns | 0.7610 ns | 0.0417 ns |  1.3122 ns |  0.91 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.0887 ns | 3.4601 ns | 0.1897 ns |  3.9936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.0047 ns | 0.2668 ns | 0.0146 ns |  4.0103 ns |  0.98 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.7644 ns | 0.7285 ns | 0.0399 ns |  1.7735 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.5371 ns | 0.1001 ns | 0.0055 ns |  1.5369 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.1580 ns | 0.3576 ns | 0.0196 ns |  2.1502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.8468 ns | 0.6277 ns | 0.0344 ns |  1.8305 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.7521 ns | 4.2337 ns | 0.2321 ns |  1.6625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.5822 ns | 0.1427 ns | 0.0078 ns |  1.5863 ns |  0.91 |    0.12 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.1706 ns | 0.9523 ns | 0.0522 ns |  2.1808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.0597 ns | 1.0045 ns | 0.0551 ns |  2.0327 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.3944 ns | 0.6076 ns | 0.0333 ns |  1.3930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.4352 ns | 1.0293 ns | 0.0564 ns |  1.4068 ns |  1.03 |    0.06 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.7161 ns | 0.2850 ns | 0.0156 ns |  4.7198 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.2452 ns | 0.2179 ns | 0.0119 ns |  4.2401 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.4438 ns | 0.3354 ns | 0.0184 ns |  1.4351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.4626 ns | 0.1744 ns | 0.0096 ns |  1.4676 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.1825 ns | 0.1521 ns | 0.0083 ns |  2.1837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.9142 ns | 0.5133 ns | 0.0281 ns |  1.9278 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.0508 ns | 0.2308 ns | 0.0126 ns |  6.0536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.2242 ns | 0.9204 ns | 0.0504 ns |  2.2140 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.5970 ns | 1.1443 ns | 0.0627 ns | 12.5814 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.9580 ns | 0.2004 ns | 0.0110 ns |  7.9635 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.1981 ns | 0.4768 ns | 0.0261 ns |  2.2049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1398 ns | 0.2999 ns | 0.0164 ns |  2.1379 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.1708 ns | 0.0409 ns | 0.0022 ns |  2.1721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.5536 ns | 0.7617 ns | 0.0418 ns |  1.5365 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.3919 ns | 1.8669 ns | 0.1023 ns |  4.4222 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.9338 ns | 0.5868 ns | 0.0322 ns |  3.9402 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 23.1577 ns | 0.1566 ns | 0.0086 ns | 23.1566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 | 18.8612 ns | 1.4087 ns | 0.0772 ns | 18.8712 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  1.6039 ns | 0.6790 ns | 0.0372 ns |  1.6187 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  1.2650 ns | 0.4113 ns | 0.0225 ns |  1.2584 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  1.2099 ns | 0.3283 ns | 0.0180 ns |  1.2197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  0.9693 ns | 0.3633 ns | 0.0199 ns |  0.9791 ns |  0.80 |    0.02 |      - |     - |     - |         - |
