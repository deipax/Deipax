
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.0130 ns | 0.0097 ns | 0.0005 ns |  1.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  0.9380 ns | 0.0131 ns | 0.0007 ns |  0.9377 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.9978 ns | 0.1392 ns | 0.0076 ns |  4.0014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7884 ns | 0.2971 ns | 0.0163 ns |  3.7886 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.1526 ns | 0.0443 ns | 0.0024 ns |  1.1521 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  0.9931 ns | 0.0300 ns | 0.0016 ns |  0.9923 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.0054 ns | 0.5169 ns | 0.0283 ns |  4.0195 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7808 ns | 0.3218 ns | 0.0176 ns |  3.7716 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.1355 ns | 0.4277 ns | 0.0234 ns |  1.1317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  0.9132 ns | 0.0915 ns | 0.0050 ns |  0.9121 ns |  0.80 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.2465 ns | 0.4243 ns | 0.0233 ns |  4.2592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.5348 ns | 0.2027 ns | 0.0111 ns |  3.5302 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.2727 ns | 1.5176 ns | 0.0832 ns |  1.2636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.0150 ns | 0.8415 ns | 0.0461 ns |  0.9979 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  3.9902 ns | 0.0816 ns | 0.0045 ns |  3.9914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.7822 ns | 0.0976 ns | 0.0053 ns |  3.7822 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.1454 ns | 0.4295 ns | 0.0235 ns |  1.1346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  0.9351 ns | 0.4336 ns | 0.0238 ns |  0.9222 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.0014 ns | 0.1916 ns | 0.0105 ns |  3.9992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.7769 ns | 0.0850 ns | 0.0047 ns |  3.7749 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.1461 ns | 0.5301 ns | 0.0291 ns |  1.1324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.1803 ns | 0.7001 ns | 0.0384 ns |  1.1676 ns |  1.03 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  3.9849 ns | 0.2807 ns | 0.0154 ns |  3.9785 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7549 ns | 0.1314 ns | 0.0072 ns |  3.7529 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.0956 ns | 0.0735 ns | 0.0040 ns |  1.0947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  0.9147 ns | 0.1062 ns | 0.0058 ns |  0.9164 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9807 ns | 0.1491 ns | 0.0082 ns |  3.9799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.7458 ns | 0.2648 ns | 0.0145 ns |  3.7391 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.1747 ns | 0.6963 ns | 0.0382 ns |  1.1601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.0116 ns | 0.0380 ns | 0.0021 ns |  1.0112 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.8415 ns | 0.8214 ns | 0.0450 ns |  3.8474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.5184 ns | 0.1696 ns | 0.0093 ns |  3.5194 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.4477 ns | 4.2458 ns | 0.2327 ns |  1.3538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  0.9841 ns | 0.9785 ns | 0.0536 ns |  0.9552 ns |  0.69 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.8698 ns | 0.9060 ns | 0.0497 ns |  1.8566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.6612 ns | 0.4408 ns | 0.0242 ns |  1.6553 ns |  0.89 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  0.8752 ns | 3.4766 ns | 0.1906 ns |  0.9593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  0.9924 ns | 0.0841 ns | 0.0046 ns |  0.9899 ns |  1.18 |    0.29 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.9567 ns | 0.7178 ns | 0.0393 ns |  1.9681 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.6518 ns | 0.0457 ns | 0.0025 ns |  1.6530 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.1684 ns | 0.1145 ns | 0.0063 ns |  1.1717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.1808 ns | 1.6927 ns | 0.0928 ns |  1.1435 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.2368 ns | 0.1334 ns | 0.0073 ns |  4.2374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.9722 ns | 0.3804 ns | 0.0209 ns |  3.9776 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.1695 ns | 0.1076 ns | 0.0059 ns |  1.1723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.2148 ns | 0.4562 ns | 0.0250 ns |  1.2031 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.9501 ns | 1.1991 ns | 0.0657 ns |  1.9601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.8912 ns | 0.2763 ns | 0.0151 ns |  1.8851 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.0503 ns | 2.6396 ns | 0.1447 ns |  6.1263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.9024 ns | 0.6609 ns | 0.0362 ns |  1.8916 ns |  0.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.3007 ns | 0.4048 ns | 0.0222 ns | 13.2953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.4350 ns | 0.2194 ns | 0.0120 ns |  7.4333 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.3241 ns | 0.9562 ns | 0.0524 ns |  2.3059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1464 ns | 0.8175 ns | 0.0448 ns |  2.1526 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0253 ns | 1.7429 ns | 0.0955 ns |  1.9847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.8368 ns | 0.0194 ns | 0.0011 ns |  1.8367 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.9549 ns | 0.5781 ns | 0.0317 ns |  3.9419 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.7146 ns | 0.5008 ns | 0.0274 ns |  3.7155 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.0434 ns | 2.2194 ns | 0.1217 ns | 13.0727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.2320 ns | 0.6942 ns | 0.0381 ns |  3.2414 ns |  0.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.2470 ns | 0.7979 ns | 0.0437 ns |  8.2383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.6284 ns | 0.8609 ns | 0.0472 ns |  7.6517 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.6481 ns | 0.2459 ns | 0.0135 ns | 12.6463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.6898 ns | 1.4550 ns | 0.0798 ns | 11.6667 ns |  0.92 |    0.01 |      - |     - |     - |         - |
