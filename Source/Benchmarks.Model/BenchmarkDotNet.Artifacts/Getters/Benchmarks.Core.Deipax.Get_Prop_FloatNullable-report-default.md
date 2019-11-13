
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   1.4772 ns | 0.0024 ns | 0.0023 ns |   1.4774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.7372 ns | 0.0241 ns | 0.0225 ns |   1.7422 ns |  1.18 |    0.02 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.5030 ns | 0.0151 ns | 0.0141 ns |   1.5070 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   1.1375 ns | 0.0174 ns | 0.0146 ns |   1.1367 ns |  0.77 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |   1.4373 ns | 0.0168 ns | 0.0157 ns |   1.4358 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.9684 ns | 0.0316 ns | 0.0280 ns |   4.9531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   5.0954 ns | 0.0062 ns | 0.0058 ns |   5.0957 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.7056 ns | 0.0151 ns | 0.0141 ns |   4.7038 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   5.1392 ns | 0.0136 ns | 0.0127 ns |   5.1406 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   5.0546 ns | 0.0077 ns | 0.0068 ns |   5.0533 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.1920 ns | 0.0024 ns | 0.0021 ns |   1.1924 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.1479 ns | 0.0046 ns | 0.0039 ns |   1.1487 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.0953 ns | 0.0036 ns | 0.0033 ns |   1.0946 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.6670 ns | 0.0211 ns | 0.0187 ns |   0.6584 ns |  0.56 |    0.02 |      - |     - |     - |         - |
             ToChar |        net472 |   0.9741 ns | 0.0167 ns | 0.0148 ns |   0.9765 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.0544 ns | 0.0181 ns | 0.0169 ns |   4.0609 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4516 ns | 0.0273 ns | 0.0255 ns |   4.4507 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.2352 ns | 0.0120 ns | 0.0106 ns |   4.2355 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.5440 ns | 0.1137 ns | 0.1063 ns |   4.5370 ns |  1.12 |    0.03 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.3797 ns | 0.0198 ns | 0.0165 ns |   4.3754 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.6830 ns | 0.0098 ns | 0.0091 ns |   4.6838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.9920 ns | 0.0097 ns | 0.0081 ns |   4.9926 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.9118 ns | 0.0119 ns | 0.0111 ns |   4.9089 ns |  1.05 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.8667 ns | 0.0431 ns | 0.0382 ns |   3.8494 ns |  0.83 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.9654 ns | 0.0050 ns | 0.0047 ns |   3.9636 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   7.5310 ns | 0.0440 ns | 0.0412 ns |   7.5109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.9699 ns | 0.0106 ns | 0.0094 ns |   6.9689 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   7.1795 ns | 0.0123 ns | 0.0109 ns |   7.1782 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   7.2681 ns | 0.0636 ns | 0.0595 ns |   7.2742 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   7.1597 ns | 0.0153 ns | 0.0135 ns |   7.1567 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.6398 ns | 0.0074 ns | 0.0062 ns |   4.6375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   5.0470 ns | 0.0064 ns | 0.0060 ns |   5.0471 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.9215 ns | 0.0090 ns | 0.0080 ns |   4.9217 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.7252 ns | 0.0098 ns | 0.0082 ns |   3.7236 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.8456 ns | 0.0083 ns | 0.0074 ns |   3.8432 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   7.5435 ns | 0.0422 ns | 0.0395 ns |   7.5666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.9407 ns | 0.0139 ns | 0.0123 ns |   6.9418 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   7.2945 ns | 0.0528 ns | 0.0494 ns |   7.2975 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   7.2029 ns | 0.0639 ns | 0.0567 ns |   7.1736 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   7.2147 ns | 0.0756 ns | 0.0707 ns |   7.2105 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   5.2744 ns | 0.0078 ns | 0.0073 ns |   5.2743 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.9941 ns | 0.0082 ns | 0.0077 ns |   4.9922 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.9464 ns | 0.0074 ns | 0.0062 ns |   4.9464 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   3.8271 ns | 0.0170 ns | 0.0151 ns |   3.8208 ns |  0.73 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.9288 ns | 0.0271 ns | 0.0254 ns |   3.9194 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   7.5110 ns | 0.0144 ns | 0.0120 ns |   7.5062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.9405 ns | 0.0099 ns | 0.0088 ns |   6.9431 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   7.2466 ns | 0.0295 ns | 0.0261 ns |   7.2418 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   7.1443 ns | 0.0091 ns | 0.0085 ns |   7.1415 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   7.4934 ns | 0.3004 ns | 0.3085 ns |   7.3426 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.6968 ns | 0.0358 ns | 0.0335 ns |   4.7132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   5.0452 ns | 0.0072 ns | 0.0064 ns |   5.0446 ns |  1.07 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.9872 ns | 0.0154 ns | 0.0144 ns |   4.9897 ns |  1.06 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.9176 ns | 0.0678 ns | 0.0634 ns |   3.8738 ns |  0.83 |    0.02 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.9878 ns | 0.0366 ns | 0.0342 ns |   3.9816 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   7.5039 ns | 0.0147 ns | 0.0137 ns |   7.5013 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.9766 ns | 0.0106 ns | 0.0094 ns |   6.9763 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   7.3140 ns | 0.0409 ns | 0.0383 ns |   7.3127 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   7.3549 ns | 0.0878 ns | 0.0821 ns |   7.3640 ns |  0.98 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   7.1718 ns | 0.0191 ns | 0.0179 ns |   7.1707 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.2345 ns | 0.0112 ns | 0.0099 ns |   3.2337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.6341 ns | 0.0084 ns | 0.0078 ns |   3.6341 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.6800 ns | 0.0054 ns | 0.0048 ns |   3.6805 ns |  1.14 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |   3.4611 ns | 0.0110 ns | 0.0098 ns |   3.4598 ns |  1.07 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   3.4305 ns | 0.0060 ns | 0.0053 ns |   3.4299 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   6.3509 ns | 0.0098 ns | 0.0092 ns |   6.3522 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.2517 ns | 0.0089 ns | 0.0083 ns |   6.2521 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.5425 ns | 0.0130 ns | 0.0122 ns |   6.5437 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.5667 ns | 0.0452 ns | 0.0423 ns |   6.5667 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   6.4514 ns | 0.0087 ns | 0.0081 ns |   6.4524 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   3.1549 ns | 0.0051 ns | 0.0048 ns |   3.1561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.5551 ns | 0.0149 ns | 0.0140 ns |   3.5562 ns |  1.13 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.5305 ns | 0.0056 ns | 0.0050 ns |   3.5311 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   3.5170 ns | 0.0255 ns | 0.0238 ns |   3.5053 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   3.4717 ns | 0.0091 ns | 0.0085 ns |   3.4721 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   6.3630 ns | 0.0354 ns | 0.0331 ns |   6.3477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.2578 ns | 0.0042 ns | 0.0039 ns |   6.2580 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.5541 ns | 0.0177 ns | 0.0138 ns |   6.5543 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.4504 ns | 0.0098 ns | 0.0092 ns |   6.4499 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.4506 ns | 0.0143 ns | 0.0127 ns |   6.4482 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.7922 ns | 0.0065 ns | 0.0061 ns |   3.7932 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.9622 ns | 0.0090 ns | 0.0084 ns |   2.9611 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.9148 ns | 0.0047 ns | 0.0044 ns |   2.9153 ns |  0.77 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.6631 ns | 0.0236 ns | 0.0209 ns |   3.6537 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   3.8291 ns | 0.0089 ns | 0.0079 ns |   3.8319 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.7803 ns | 0.0082 ns | 0.0064 ns |   4.7791 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.5059 ns | 0.0096 ns | 0.0085 ns |   3.5066 ns |  0.73 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.4588 ns | 0.0103 ns | 0.0092 ns |   3.4561 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   5.4871 ns | 0.0460 ns | 0.0407 ns |   5.4898 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.7620 ns | 0.1423 ns | 0.1638 ns |   5.6920 ns |  1.22 |    0.04 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.7513 ns | 0.0168 ns | 0.0149 ns |   3.7485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.8502 ns | 0.0052 ns | 0.0046 ns |   2.8502 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   3.4348 ns | 0.0087 ns | 0.0081 ns |   3.4349 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.3015 ns | 0.0069 ns | 0.0061 ns |   3.3012 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   3.5336 ns | 0.0132 ns | 0.0117 ns |   3.5290 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.5364 ns | 0.0077 ns | 0.0072 ns |   4.5341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.5268 ns | 0.0069 ns | 0.0061 ns |   3.5258 ns |  0.78 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.4074 ns | 0.0080 ns | 0.0071 ns |   3.4068 ns |  0.75 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   5.4005 ns | 0.1278 ns | 0.1367 ns |   5.3402 ns |  1.19 |    0.03 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   5.5835 ns | 0.0820 ns | 0.0767 ns |   5.5588 ns |  1.23 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.4908 ns | 0.0020 ns | 0.0018 ns |   1.4913 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.6913 ns | 0.0059 ns | 0.0049 ns |   1.6917 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.6153 ns | 0.0509 ns | 0.0476 ns |   1.5927 ns |  1.09 |    0.03 |      - |     - |     - |         - |
            ToFloat |        net461 |   1.8751 ns | 0.0386 ns | 0.0361 ns |   1.8669 ns |  1.26 |    0.02 |      - |     - |     - |         - |
            ToFloat |        net472 |   1.8800 ns | 0.0115 ns | 0.0108 ns |   1.8767 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   1.1724 ns | 0.0034 ns | 0.0032 ns |   1.1721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   1.1415 ns | 0.0105 ns | 0.0082 ns |   1.1445 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   1.0959 ns | 0.0154 ns | 0.0136 ns |   1.0952 ns |  0.93 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   0.9304 ns | 0.0117 ns | 0.0098 ns |   0.9310 ns |  0.79 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   1.1310 ns | 0.0090 ns | 0.0080 ns |   1.1310 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.6285 ns | 0.0034 ns | 0.0030 ns |   1.6282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.3551 ns | 0.0034 ns | 0.0030 ns |   1.3552 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.3346 ns | 0.0201 ns | 0.0188 ns |   1.3278 ns |  0.82 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   1.1365 ns | 0.0053 ns | 0.0047 ns |   1.1377 ns |  0.70 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   1.4323 ns | 0.0154 ns | 0.0144 ns |   1.4298 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.9418 ns | 0.0031 ns | 0.0029 ns |   1.9420 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   2.0517 ns | 0.0053 ns | 0.0049 ns |   2.0522 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   2.1401 ns | 0.0222 ns | 0.0185 ns |   2.1372 ns |  1.10 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   2.5649 ns | 0.0344 ns | 0.0322 ns |   2.5507 ns |  1.32 |    0.02 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   2.6019 ns | 0.0109 ns | 0.0097 ns |   2.6015 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  24.1336 ns | 0.0279 ns | 0.0233 ns |  24.1399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  23.8362 ns | 0.0444 ns | 0.0415 ns |  23.8514 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  11.6930 ns | 0.0416 ns | 0.0389 ns |  11.6829 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  23.9304 ns | 0.0908 ns | 0.0758 ns |  23.9067 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  24.1519 ns | 0.1615 ns | 0.1511 ns |  24.1383 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  34.0236 ns | 0.0331 ns | 0.0294 ns |  34.0156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  34.2328 ns | 0.2380 ns | 0.2226 ns |  34.2969 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  17.0087 ns | 0.1165 ns | 0.1090 ns |  16.9485 ns |  0.50 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  35.8428 ns | 0.5314 ns | 0.4971 ns |  35.7420 ns |  1.05 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  34.5210 ns | 0.1702 ns | 0.1592 ns |  34.5114 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3312 ns | 0.0026 ns | 0.0025 ns |   2.3313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.2987 ns | 0.0033 ns | 0.0028 ns |   2.2987 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.1204 ns | 0.0189 ns | 0.0177 ns |   2.1243 ns |  0.91 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1258 ns | 0.0030 ns | 0.0025 ns |   1.1262 ns |  0.48 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.3507 ns | 0.0254 ns | 0.0238 ns |   1.3455 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.0244 ns | 0.0558 ns | 0.0522 ns |   8.0526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.0697 ns | 0.0149 ns | 0.0139 ns |   8.0705 ns |  1.01 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   2.1708 ns | 0.0462 ns | 0.0410 ns |   2.1649 ns |  0.27 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.1651 ns | 0.0781 ns | 0.0693 ns |   8.1512 ns |  1.02 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.2651 ns | 0.1325 ns | 0.1174 ns |   8.2070 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.9317 ns | 0.0086 ns | 0.0080 ns |   3.9302 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.5777 ns | 0.0256 ns | 0.0239 ns |   4.5771 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.7069 ns | 0.0737 ns | 0.0689 ns |   4.6910 ns |  1.20 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.9899 ns | 0.0291 ns | 0.0258 ns |   3.9850 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.7875 ns | 0.0061 ns | 0.0057 ns |   3.7857 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 165.7534 ns | 0.2499 ns | 0.2087 ns | 165.7787 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 105.0098 ns | 0.3251 ns | 0.3041 ns | 104.8933 ns |  0.63 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 111.9904 ns | 0.1326 ns | 0.1107 ns | 112.0097 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 280.3273 ns | 0.8140 ns | 0.6798 ns | 280.0562 ns |  1.69 |    0.00 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 281.7494 ns | 0.3116 ns | 0.2915 ns | 281.7043 ns |  1.70 |    0.00 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  14.5324 ns | 0.0193 ns | 0.0161 ns |  14.5324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  14.8285 ns | 0.0896 ns | 0.0838 ns |  14.8500 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.7575 ns | 0.0369 ns | 0.0308 ns |  10.7572 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  18.0876 ns | 0.3560 ns | 0.3330 ns |  18.0759 ns |  1.24 |    0.02 |      - |     - |     - |         - |
             ToEnum |        net472 |  17.1539 ns | 0.0220 ns | 0.0195 ns |  17.1530 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  18.9157 ns | 0.0191 ns | 0.0169 ns |  18.9214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  18.6627 ns | 0.0326 ns | 0.0272 ns |  18.6602 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  15.1397 ns | 0.0267 ns | 0.0236 ns |  15.1389 ns |  0.80 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  22.0359 ns | 0.0579 ns | 0.0484 ns |  22.0324 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  22.6454 ns | 0.3013 ns | 0.2818 ns |  22.6268 ns |  1.20 |    0.02 |      - |     - |     - |         - |
