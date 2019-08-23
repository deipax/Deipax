
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4651 ns | 0.0017 ns | 0.0013 ns |  1.4649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2847 ns | 0.0020 ns | 0.0017 ns |  1.2846 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4401 ns | 0.0029 ns | 0.0027 ns |  1.4410 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.0146 ns | 0.0076 ns | 0.0067 ns |  1.0125 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0629 ns | 0.0198 ns | 0.0185 ns |  1.0613 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4706 ns | 0.0065 ns | 0.0054 ns |  4.4684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4304 ns | 0.0142 ns | 0.0133 ns |  4.4271 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2518 ns | 0.0161 ns | 0.0142 ns |  4.2475 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6654 ns | 0.0161 ns | 0.0150 ns |  4.6584 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6766 ns | 0.0193 ns | 0.0180 ns |  4.6759 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7561 ns | 0.0034 ns | 0.0032 ns |  1.7565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4033 ns | 0.0041 ns | 0.0038 ns |  1.4026 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6367 ns | 0.0077 ns | 0.0068 ns |  1.6354 ns |  0.93 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.9628 ns | 0.0076 ns | 0.0063 ns |  0.9630 ns |  0.55 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.9661 ns | 0.0170 ns | 0.0151 ns |  0.9690 ns |  0.55 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4722 ns | 0.0075 ns | 0.0070 ns |  4.4719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.6572 ns | 0.0269 ns | 0.0225 ns |  4.6467 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2201 ns | 0.0470 ns | 0.0440 ns |  4.2069 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6411 ns | 0.0334 ns | 0.0296 ns |  4.6294 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.7331 ns | 0.0515 ns | 0.0456 ns |  4.7388 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.7185 ns | 0.0169 ns | 0.0158 ns |  1.7251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.8101 ns | 0.0164 ns | 0.0145 ns |  1.8029 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.7797 ns | 0.0230 ns | 0.0192 ns |  1.7769 ns |  1.04 |    0.02 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.1861 ns | 0.0102 ns | 0.0096 ns |  2.1856 ns |  1.27 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.2048 ns | 0.0173 ns | 0.0162 ns |  2.2057 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4750 ns | 0.0075 ns | 0.0070 ns |  4.4732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.6426 ns | 0.0083 ns | 0.0078 ns |  4.6410 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4796 ns | 0.0166 ns | 0.0147 ns |  4.4758 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3476 ns | 0.0208 ns | 0.0184 ns |  5.3455 ns |  1.20 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.2337 ns | 0.0358 ns | 0.0335 ns |  5.2384 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.4109 ns | 0.0042 ns | 0.0035 ns |  1.4100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6591 ns | 0.0042 ns | 0.0037 ns |  1.6591 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5009 ns | 0.0133 ns | 0.0125 ns |  1.4961 ns |  1.06 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.8865 ns | 0.0101 ns | 0.0090 ns |  1.8864 ns |  1.34 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.8524 ns | 0.0086 ns | 0.0072 ns |  1.8540 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  1.1642 ns | 0.0033 ns | 0.0031 ns |  1.1647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  1.3264 ns | 0.0037 ns | 0.0035 ns |  1.3261 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  1.1823 ns | 0.0110 ns | 0.0092 ns |  1.1794 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  0.9425 ns | 0.0115 ns | 0.0108 ns |  0.9387 ns |  0.81 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  0.9691 ns | 0.0100 ns | 0.0089 ns |  0.9658 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4679 ns | 0.0037 ns | 0.0031 ns |  1.4678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4089 ns | 0.0027 ns | 0.0025 ns |  1.4088 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6509 ns | 0.0147 ns | 0.0138 ns |  1.6463 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  1.1610 ns | 0.0133 ns | 0.0125 ns |  1.1598 ns |  0.79 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  1.1433 ns | 0.0129 ns | 0.0121 ns |  1.1391 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4723 ns | 0.0039 ns | 0.0037 ns |  4.4719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.6395 ns | 0.0050 ns | 0.0044 ns |  4.6386 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2137 ns | 0.0222 ns | 0.0197 ns |  4.2104 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6295 ns | 0.0185 ns | 0.0164 ns |  4.6254 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6567 ns | 0.0298 ns | 0.0279 ns |  4.6466 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6523 ns | 0.0107 ns | 0.0100 ns |  1.6576 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2713 ns | 0.0087 ns | 0.0081 ns |  1.2693 ns |  0.77 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4833 ns | 0.0165 ns | 0.0154 ns |  1.4766 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.1378 ns | 0.0067 ns | 0.0053 ns |  1.1367 ns |  0.69 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.1556 ns | 0.0199 ns | 0.0176 ns |  1.1490 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4734 ns | 0.0046 ns | 0.0041 ns |  4.4732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.6460 ns | 0.0083 ns | 0.0074 ns |  4.6448 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2355 ns | 0.0401 ns | 0.0375 ns |  4.2219 ns |  0.95 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6980 ns | 0.0188 ns | 0.0175 ns |  4.6961 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6874 ns | 0.0203 ns | 0.0189 ns |  4.6834 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4772 ns | 0.0132 ns | 0.0123 ns |  1.4697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4202 ns | 0.0026 ns | 0.0024 ns |  1.4210 ns |  0.96 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6644 ns | 0.0074 ns | 0.0065 ns |  1.6646 ns |  1.13 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.9679 ns | 0.0075 ns | 0.0063 ns |  0.9673 ns |  0.66 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.9635 ns | 0.0059 ns | 0.0046 ns |  0.9646 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2536 ns | 0.0121 ns | 0.0114 ns |  4.2512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4133 ns | 0.0080 ns | 0.0074 ns |  4.4140 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0499 ns | 0.0213 ns | 0.0199 ns |  4.0438 ns |  0.95 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4588 ns | 0.0312 ns | 0.0292 ns |  4.4653 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4953 ns | 0.0412 ns | 0.0386 ns |  4.4960 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6394 ns | 0.0188 ns | 0.0176 ns |  1.6451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2577 ns | 0.0035 ns | 0.0033 ns |  1.2576 ns |  0.77 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4145 ns | 0.0062 ns | 0.0058 ns |  1.4145 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.1367 ns | 0.0089 ns | 0.0083 ns |  1.1335 ns |  0.69 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.1308 ns | 0.0137 ns | 0.0122 ns |  1.1252 ns |  0.69 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2414 ns | 0.0070 ns | 0.0062 ns |  4.2414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4444 ns | 0.0202 ns | 0.0179 ns |  4.4509 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0176 ns | 0.0129 ns | 0.0121 ns |  4.0132 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4207 ns | 0.0317 ns | 0.0296 ns |  4.4155 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4558 ns | 0.0263 ns | 0.0233 ns |  4.4441 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4865 ns | 0.0188 ns | 0.0176 ns |  1.4897 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2758 ns | 0.0043 ns | 0.0040 ns |  1.2747 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4155 ns | 0.0095 ns | 0.0089 ns |  1.4128 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1768 ns | 0.0151 ns | 0.0134 ns |  1.1765 ns |  0.79 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1289 ns | 0.0122 ns | 0.0114 ns |  1.1264 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0137 ns | 0.0030 ns | 0.0027 ns |  2.0146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1483 ns | 0.0019 ns | 0.0016 ns |  2.1485 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1155 ns | 0.0175 ns | 0.0163 ns |  2.1154 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3513 ns | 0.0233 ns | 0.0218 ns |  2.3374 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.6658 ns | 0.0211 ns | 0.0197 ns |  2.6644 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6230 ns | 0.0032 ns | 0.0030 ns |  1.6227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2767 ns | 0.0037 ns | 0.0034 ns |  1.2769 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.3913 ns | 0.0065 ns | 0.0057 ns |  1.3902 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.9768 ns | 0.0199 ns | 0.0186 ns |  0.9724 ns |  0.60 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  0.9583 ns | 0.0106 ns | 0.0099 ns |  0.9549 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9038 ns | 0.0045 ns | 0.0040 ns |  1.9047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1219 ns | 0.0025 ns | 0.0022 ns |  2.1220 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.2008 ns | 0.0253 ns | 0.0225 ns |  2.2041 ns |  1.16 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.1264 ns | 0.0241 ns | 0.0225 ns |  2.1175 ns |  1.12 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.3185 ns | 0.0146 ns | 0.0136 ns |  2.3153 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7354 ns | 0.0167 ns | 0.0156 ns |  1.7387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4531 ns | 0.0027 ns | 0.0023 ns |  1.4528 ns |  0.84 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4457 ns | 0.0309 ns | 0.0289 ns |  1.4371 ns |  0.83 |    0.02 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1350 ns | 0.0103 ns | 0.0096 ns |  1.1312 ns |  0.65 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.7933 ns | 0.0182 ns | 0.0170 ns |  1.7993 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4711 ns | 0.0073 ns | 0.0068 ns |  4.4733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8696 ns | 0.0053 ns | 0.0050 ns |  4.8685 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4829 ns | 0.0332 ns | 0.0311 ns |  4.4738 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.9211 ns | 0.0462 ns | 0.0410 ns |  4.9085 ns |  1.10 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8954 ns | 0.0239 ns | 0.0224 ns |  4.8920 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6349 ns | 0.0041 ns | 0.0038 ns |  1.6342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6584 ns | 0.0039 ns | 0.0035 ns |  1.6576 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6366 ns | 0.0137 ns | 0.0129 ns |  1.6328 ns |  1.00 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.0167 ns | 0.0125 ns | 0.0117 ns |  1.0147 ns |  0.62 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.0125 ns | 0.0130 ns | 0.0121 ns |  1.0089 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0083 ns | 0.0047 ns | 0.0042 ns |  2.0069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3400 ns | 0.0053 ns | 0.0047 ns |  2.3396 ns |  1.17 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1466 ns | 0.0134 ns | 0.0126 ns |  2.1459 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5503 ns | 0.0061 ns | 0.0048 ns |  2.5507 ns |  1.27 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.6222 ns | 0.0171 ns | 0.0160 ns |  2.6235 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0749 ns | 0.0097 ns | 0.0091 ns |  6.0742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0249 ns | 0.0080 ns | 0.0071 ns |  6.0249 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9482 ns | 0.0850 ns | 0.0795 ns |  5.9090 ns |  0.98 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.2844 ns | 0.0413 ns | 0.0386 ns |  6.2848 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2958 ns | 0.0251 ns | 0.0234 ns |  6.3037 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.7971 ns | 0.0236 ns | 0.0209 ns | 18.7971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.3549 ns | 0.0306 ns | 0.0272 ns | 18.3545 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.9690 ns | 0.2217 ns | 0.2073 ns | 12.8508 ns |  0.69 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.3761 ns | 0.0928 ns | 0.0868 ns | 18.3877 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.4606 ns | 0.1010 ns | 0.0944 ns | 18.4494 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3224 ns | 0.0034 ns | 0.0028 ns |  2.3225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3247 ns | 0.0030 ns | 0.0027 ns |  2.3248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3347 ns | 0.0236 ns | 0.0221 ns |  2.3241 ns |  1.00 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1586 ns | 0.0053 ns | 0.0047 ns |  1.1604 ns |  0.50 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.4189 ns | 0.0092 ns | 0.0077 ns |  1.4209 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9376 ns | 0.0149 ns | 0.0132 ns |  7.9341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4404 ns | 0.0072 ns | 0.0064 ns |  8.4389 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9671 ns | 0.0220 ns | 0.0206 ns |  1.9650 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2541 ns | 0.0381 ns | 0.0338 ns |  8.2579 ns |  1.04 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2763 ns | 0.0724 ns | 0.0642 ns |  8.2590 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8747 ns | 0.0113 ns | 0.0106 ns |  3.8712 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.4771 ns | 0.0088 ns | 0.0068 ns |  4.4774 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.7465 ns | 0.1113 ns | 0.1041 ns |  4.7489 ns |  1.23 |    0.03 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.9093 ns | 0.0421 ns | 0.0394 ns |  3.9207 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8523 ns | 0.0728 ns | 0.0681 ns |  3.8234 ns |  0.99 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 31.0396 ns | 0.1600 ns | 0.1496 ns | 31.0114 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.5115 ns | 0.0237 ns | 0.0210 ns | 17.5061 ns |  0.56 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.1589 ns | 0.0671 ns | 0.0595 ns | 12.1313 ns |  0.39 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.7683 ns | 0.3801 ns | 0.3555 ns | 31.5977 ns |  1.02 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 33.0711 ns | 0.3085 ns | 0.2886 ns | 33.0772 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.4037 ns | 0.0193 ns | 0.0171 ns | 12.4024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.3575 ns | 0.0134 ns | 0.0112 ns | 12.3577 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5269 ns | 0.0463 ns | 0.0433 ns |  8.5028 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.3804 ns | 0.0793 ns | 0.0703 ns | 15.3994 ns |  1.24 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.2541 ns | 0.1651 ns | 0.1464 ns | 15.1924 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.5926 ns | 0.0175 ns | 0.0156 ns | 16.5936 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.6847 ns | 0.0820 ns | 0.0767 ns | 16.6601 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2019 ns | 0.0941 ns | 0.0786 ns | 13.2160 ns |  0.80 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.7493 ns | 0.0579 ns | 0.0484 ns | 19.7490 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.2369 ns | 0.0939 ns | 0.0878 ns | 20.2377 ns |  1.22 |    0.00 |      - |     - |     - |         - |
