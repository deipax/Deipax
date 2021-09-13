
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.0097 ns | 0.2907 ns | 0.0159 ns |  1.0017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  0.9632 ns | 0.6549 ns | 0.0359 ns |  0.9622 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.0471 ns | 0.6532 ns | 0.0358 ns |  4.0599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7640 ns | 0.2991 ns | 0.0164 ns |  3.7717 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.1994 ns | 0.2917 ns | 0.0160 ns |  1.1913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.1909 ns | 0.1710 ns | 0.0094 ns |  1.1943 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.0299 ns | 0.5322 ns | 0.0292 ns |  4.0134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7642 ns | 0.1659 ns | 0.0091 ns |  3.7609 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.0438 ns | 0.4356 ns | 0.0239 ns |  1.0309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.0209 ns | 0.1484 ns | 0.0081 ns |  1.0184 ns |  0.98 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.0210 ns | 0.7033 ns | 0.0386 ns |  4.0329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.7562 ns | 0.2631 ns | 0.0144 ns |  3.7513 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.0330 ns | 0.0297 ns | 0.0016 ns |  1.0336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.0027 ns | 0.3549 ns | 0.0195 ns |  0.9952 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.0467 ns | 0.1470 ns | 0.0081 ns |  4.0438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.7568 ns | 0.0406 ns | 0.0022 ns |  3.7557 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.2965 ns | 0.2696 ns | 0.0148 ns |  2.2892 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.0549 ns | 0.4675 ns | 0.0256 ns |  1.0506 ns |  0.46 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.5014 ns | 0.3606 ns | 0.0198 ns |  4.5069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.7491 ns | 0.0885 ns | 0.0049 ns |  3.7519 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.1358 ns | 0.2190 ns | 0.0120 ns |  1.1311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.3473 ns | 0.6003 ns | 0.0329 ns |  1.3652 ns |  1.19 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.0356 ns | 0.2776 ns | 0.0152 ns |  4.0301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7596 ns | 0.1210 ns | 0.0066 ns |  3.7626 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.0774 ns | 0.6557 ns | 0.0359 ns |  1.0939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.0424 ns | 0.8627 ns | 0.0473 ns |  1.0499 ns |  0.97 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.7952 ns | 0.4323 ns | 0.0237 ns |  3.8052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.5156 ns | 0.4566 ns | 0.0250 ns |  3.5205 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.0305 ns | 0.1768 ns | 0.0097 ns |  1.0257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  0.9338 ns | 0.1049 ns | 0.0058 ns |  0.9347 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.2517 ns | 0.4899 ns | 0.0269 ns |  4.2586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.5210 ns | 0.1830 ns | 0.0100 ns |  3.5234 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  0.9640 ns | 0.1101 ns | 0.0060 ns |  0.9652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  0.9420 ns | 0.6134 ns | 0.0336 ns |  0.9456 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.7701 ns | 0.9883 ns | 0.0542 ns |  1.7998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.6655 ns | 1.0978 ns | 0.0602 ns |  1.6383 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  0.9737 ns | 0.2566 ns | 0.0141 ns |  0.9816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  0.9722 ns | 0.4816 ns | 0.0264 ns |  0.9578 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.7065 ns | 0.1419 ns | 0.0078 ns |  1.7049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.6201 ns | 0.6159 ns | 0.0338 ns |  1.6024 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.4676 ns | 0.1642 ns | 0.0090 ns |  1.4651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.2698 ns | 0.0400 ns | 0.0022 ns |  1.2706 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.4128 ns | 3.8822 ns | 0.2128 ns |  4.3495 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.9926 ns | 0.1729 ns | 0.0095 ns |  3.9964 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.2802 ns | 0.8706 ns | 0.0477 ns |  1.2906 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.1224 ns | 0.9698 ns | 0.0532 ns |  1.0941 ns |  0.88 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.9586 ns | 1.2106 ns | 0.0664 ns |  1.9652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.7006 ns | 0.1841 ns | 0.0101 ns |  1.7037 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.8878 ns | 0.2294 ns | 0.0126 ns |  5.8862 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.6502 ns | 0.3163 ns | 0.0173 ns |  1.6453 ns |  0.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.2857 ns | 0.7931 ns | 0.0435 ns | 13.2645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.0850 ns | 1.6161 ns | 0.0886 ns |  7.0747 ns |  0.53 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.1749 ns | 0.4151 ns | 0.0228 ns |  2.1808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.0290 ns | 1.1222 ns | 0.0615 ns |  2.0142 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0055 ns | 0.1489 ns | 0.0082 ns |  2.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.6871 ns | 0.6827 ns | 0.0374 ns |  1.6658 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.5949 ns | 0.2273 ns | 0.0125 ns |  3.5943 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.6169 ns | 0.7012 ns | 0.0384 ns |  3.6348 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 12.6935 ns | 2.8536 ns | 0.1564 ns | 12.7623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.0463 ns | 0.5912 ns | 0.0324 ns |  3.0316 ns |  0.24 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.0894 ns | 2.3719 ns | 0.1300 ns |  8.1367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.4169 ns | 1.8337 ns | 0.1005 ns |  7.3661 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.5218 ns | 2.5215 ns | 0.1382 ns | 12.5706 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.2429 ns | 1.0742 ns | 0.0589 ns | 11.2570 ns |  0.90 |    0.01 |      - |     - |     - |         - |
