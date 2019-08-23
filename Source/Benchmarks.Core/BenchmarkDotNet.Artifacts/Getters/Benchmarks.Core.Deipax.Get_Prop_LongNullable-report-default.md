
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
             ToBool | .NET Core 2.0 |  1.2469 ns | 0.0038 ns | 0.0033 ns |  1.2453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3340 ns | 0.0034 ns | 0.0032 ns |  1.3343 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4134 ns | 0.0047 ns | 0.0041 ns |  1.4126 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9717 ns | 0.0042 ns | 0.0035 ns |  0.9729 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9684 ns | 0.0038 ns | 0.0033 ns |  0.9686 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2293 ns | 0.0057 ns | 0.0047 ns |  4.2293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3620 ns | 0.0190 ns | 0.0159 ns |  4.3558 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4614 ns | 0.0055 ns | 0.0049 ns |  4.4609 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.8739 ns | 0.0100 ns | 0.0094 ns |  4.8736 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.8411 ns | 0.0074 ns | 0.0066 ns |  4.8406 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.6575 ns | 0.0049 ns | 0.0045 ns |  2.6571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.3929 ns | 0.0080 ns | 0.0075 ns |  2.3921 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.7055 ns | 0.0148 ns | 0.0139 ns |  2.7063 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.1694 ns | 0.0027 ns | 0.0025 ns |  2.1692 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.1447 ns | 0.0038 ns | 0.0034 ns |  2.1454 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.1559 ns | 0.0056 ns | 0.0049 ns |  5.1554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.0495 ns | 0.0074 ns | 0.0069 ns |  5.0497 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7516 ns | 0.0228 ns | 0.0213 ns |  4.7521 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3372 ns | 0.0083 ns | 0.0078 ns |  5.3380 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3153 ns | 0.0226 ns | 0.0200 ns |  5.3068 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.6233 ns | 0.0160 ns | 0.0150 ns |  2.6177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.5308 ns | 0.0104 ns | 0.0098 ns |  2.5325 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.3806 ns | 0.0030 ns | 0.0028 ns |  2.3802 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.1746 ns | 0.0041 ns | 0.0037 ns |  2.1742 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.1519 ns | 0.0072 ns | 0.0064 ns |  2.1505 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.2143 ns | 0.0056 ns | 0.0050 ns |  5.2141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.0437 ns | 0.0110 ns | 0.0092 ns |  5.0425 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7025 ns | 0.0055 ns | 0.0052 ns |  4.7023 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3345 ns | 0.0156 ns | 0.0138 ns |  5.3284 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3109 ns | 0.0094 ns | 0.0088 ns |  5.3107 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.6823 ns | 0.0043 ns | 0.0038 ns |  2.6821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.4137 ns | 0.0115 ns | 0.0108 ns |  2.4150 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.8894 ns | 0.0075 ns | 0.0070 ns |  2.8882 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0419 ns | 0.0038 ns | 0.0036 ns |  2.0430 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.0467 ns | 0.0045 ns | 0.0042 ns |  2.0463 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.2242 ns | 0.0072 ns | 0.0067 ns |  5.2254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.0481 ns | 0.0129 ns | 0.0108 ns |  5.0450 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.6969 ns | 0.0085 ns | 0.0071 ns |  4.6945 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3827 ns | 0.0283 ns | 0.0264 ns |  5.3911 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3692 ns | 0.0096 ns | 0.0085 ns |  5.3689 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.4096 ns | 0.0068 ns | 0.0064 ns |  2.4089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.7151 ns | 0.0044 ns | 0.0041 ns |  2.7147 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.3611 ns | 0.0127 ns | 0.0119 ns |  2.3633 ns |  0.98 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.0946 ns | 0.0039 ns | 0.0033 ns |  2.0957 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.1534 ns | 0.0041 ns | 0.0038 ns |  2.1523 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.1586 ns | 0.0067 ns | 0.0059 ns |  5.1598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.0452 ns | 0.0071 ns | 0.0063 ns |  5.0449 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.6989 ns | 0.0120 ns | 0.0106 ns |  4.6979 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3881 ns | 0.0198 ns | 0.0185 ns |  5.3891 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3058 ns | 0.0062 ns | 0.0055 ns |  5.3063 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.6570 ns | 0.0074 ns | 0.0069 ns |  2.6553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.3947 ns | 0.0065 ns | 0.0060 ns |  2.3950 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.9010 ns | 0.0268 ns | 0.0223 ns |  2.9087 ns |  1.09 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.0457 ns | 0.0035 ns | 0.0033 ns |  2.0458 ns |  0.77 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.0431 ns | 0.0040 ns | 0.0034 ns |  2.0442 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.1592 ns | 0.0100 ns | 0.0088 ns |  5.1584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.0453 ns | 0.0061 ns | 0.0057 ns |  5.0462 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.6951 ns | 0.0094 ns | 0.0088 ns |  4.6958 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3230 ns | 0.0052 ns | 0.0046 ns |  5.3212 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3121 ns | 0.0081 ns | 0.0071 ns |  5.3114 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.4287 ns | 0.0068 ns | 0.0061 ns |  2.4282 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.7181 ns | 0.0061 ns | 0.0057 ns |  2.7196 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.6904 ns | 0.0213 ns | 0.0199 ns |  2.6833 ns |  1.11 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  2.0425 ns | 0.0059 ns | 0.0052 ns |  2.0427 ns |  0.84 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  2.0543 ns | 0.0045 ns | 0.0037 ns |  2.0549 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  5.3623 ns | 0.0060 ns | 0.0057 ns |  5.3607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  5.0475 ns | 0.0063 ns | 0.0059 ns |  5.0466 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.7165 ns | 0.0085 ns | 0.0080 ns |  4.7148 ns |  0.88 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.3404 ns | 0.0070 ns | 0.0065 ns |  5.3402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.2984 ns | 0.0076 ns | 0.0067 ns |  5.3000 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.9157 ns | 0.0054 ns | 0.0048 ns |  2.9141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  2.5509 ns | 0.0073 ns | 0.0064 ns |  2.5510 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  2.2134 ns | 0.0143 ns | 0.0134 ns |  2.2067 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0440 ns | 0.0043 ns | 0.0040 ns |  2.0442 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.0592 ns | 0.0049 ns | 0.0044 ns |  2.0588 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  5.1564 ns | 0.0067 ns | 0.0063 ns |  5.1553 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  5.0473 ns | 0.0078 ns | 0.0065 ns |  5.0479 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.7057 ns | 0.0087 ns | 0.0082 ns |  4.7039 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.3707 ns | 0.0407 ns | 0.0380 ns |  5.3460 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.3088 ns | 0.0083 ns | 0.0078 ns |  5.3082 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4330 ns | 0.0021 ns | 0.0019 ns |  1.4328 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6178 ns | 0.0092 ns | 0.0086 ns |  1.6199 ns |  1.13 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5591 ns | 0.0024 ns | 0.0023 ns |  1.5593 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.8494 ns | 0.0037 ns | 0.0034 ns |  1.8499 ns |  1.29 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.8372 ns | 0.0038 ns | 0.0036 ns |  1.8362 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6424 ns | 0.0040 ns | 0.0033 ns |  1.6421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.3776 ns | 0.0044 ns | 0.0039 ns |  1.3774 ns |  0.84 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6606 ns | 0.0037 ns | 0.0034 ns |  1.6598 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9357 ns | 0.0655 ns | 0.0580 ns |  1.9201 ns |  1.17 |    0.03 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.4020 ns | 0.0032 ns | 0.0028 ns |  1.4019 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6440 ns | 0.0031 ns | 0.0028 ns |  1.6436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5796 ns | 0.0531 ns | 0.0470 ns |  1.5920 ns |  0.96 |    0.03 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4190 ns | 0.0038 ns | 0.0034 ns |  1.4192 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.0479 ns | 0.0036 ns | 0.0034 ns |  2.0473 ns |  1.25 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  2.0882 ns | 0.0041 ns | 0.0036 ns |  2.0877 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.5295 ns | 0.0048 ns | 0.0045 ns |  2.5281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0466 ns | 0.0046 ns | 0.0038 ns |  2.0481 ns |  0.81 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1100 ns | 0.0068 ns | 0.0064 ns |  2.1089 ns |  0.83 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.0399 ns | 0.0072 ns | 0.0067 ns |  3.0391 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.9470 ns | 0.0060 ns | 0.0056 ns |  2.9459 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6945 ns | 0.0037 ns | 0.0033 ns |  1.6930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2934 ns | 0.0027 ns | 0.0025 ns |  1.2937 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4862 ns | 0.0025 ns | 0.0022 ns |  1.4858 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1503 ns | 0.0032 ns | 0.0028 ns |  1.1501 ns |  0.68 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1219 ns | 0.0044 ns | 0.0037 ns |  1.1214 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4695 ns | 0.0077 ns | 0.0072 ns |  4.4693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6374 ns | 0.0170 ns | 0.0159 ns |  4.6414 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.5280 ns | 0.0262 ns | 0.0246 ns |  4.5342 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8825 ns | 0.0134 ns | 0.0125 ns |  4.8753 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8474 ns | 0.0071 ns | 0.0066 ns |  4.8485 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6534 ns | 0.0022 ns | 0.0019 ns |  1.6538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4054 ns | 0.0038 ns | 0.0033 ns |  1.4040 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3474 ns | 0.0025 ns | 0.0022 ns |  1.3473 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.9552 ns | 0.0025 ns | 0.0022 ns |  0.9547 ns |  0.58 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.9449 ns | 0.0039 ns | 0.0035 ns |  0.9447 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8716 ns | 0.0038 ns | 0.0034 ns |  1.8708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.7774 ns | 0.0171 ns | 0.0160 ns |  1.7839 ns |  0.95 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1054 ns | 0.0054 ns | 0.0045 ns |  2.1055 ns |  1.12 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5803 ns | 0.0064 ns | 0.0060 ns |  2.5794 ns |  1.38 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5377 ns | 0.0059 ns | 0.0055 ns |  2.5387 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0666 ns | 0.0095 ns | 0.0084 ns |  6.0662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.9711 ns | 0.0174 ns | 0.0155 ns |  5.9719 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0697 ns | 0.0132 ns | 0.0110 ns |  6.0673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.5355 ns | 0.0148 ns | 0.0132 ns |  6.5347 ns |  1.08 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.7127 ns | 0.0129 ns | 0.0120 ns |  6.7104 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.3463 ns | 0.0352 ns | 0.0329 ns | 18.3341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.4715 ns | 0.0190 ns | 0.0169 ns | 18.4738 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.4620 ns | 0.1492 ns | 0.1395 ns | 13.3722 ns |  0.73 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.8232 ns | 0.0206 ns | 0.0193 ns | 18.8160 ns |  1.03 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.4594 ns | 0.0256 ns | 0.0227 ns | 18.4550 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3298 ns | 0.0047 ns | 0.0044 ns |  2.3297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.4523 ns | 0.0082 ns | 0.0077 ns |  2.4508 ns |  1.05 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3278 ns | 0.0031 ns | 0.0028 ns |  2.3278 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1846 ns | 0.0033 ns | 0.0031 ns |  1.1853 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  0.9867 ns | 0.0025 ns | 0.0022 ns |  0.9871 ns |  0.42 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1643 ns | 0.0135 ns | 0.0126 ns |  8.1628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4457 ns | 0.0118 ns | 0.0110 ns |  8.4480 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9602 ns | 0.0013 ns | 0.0011 ns |  1.9607 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2301 ns | 0.0115 ns | 0.0102 ns |  8.2311 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1391 ns | 0.0100 ns | 0.0089 ns |  8.1382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8117 ns | 0.0068 ns | 0.0063 ns |  3.8116 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.4767 ns | 0.0104 ns | 0.0092 ns |  4.4771 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5073 ns | 0.0365 ns | 0.0342 ns |  4.5236 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7534 ns | 0.0091 ns | 0.0086 ns |  3.7523 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7322 ns | 0.0097 ns | 0.0086 ns |  3.7325 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 31.9865 ns | 0.0902 ns | 0.0753 ns | 31.9780 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 18.7476 ns | 0.0313 ns | 0.0278 ns | 18.7498 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.8015 ns | 0.0115 ns | 0.0102 ns | 12.8028 ns |  0.40 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 32.1224 ns | 0.0668 ns | 0.0625 ns | 32.1028 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.4123 ns | 0.0836 ns | 0.0741 ns | 32.3849 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 13.3449 ns | 0.0180 ns | 0.0159 ns | 13.3404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.9005 ns | 0.0125 ns | 0.0111 ns | 12.8972 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.7731 ns | 0.0143 ns | 0.0134 ns |  8.7700 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.7649 ns | 0.0752 ns | 0.0703 ns | 15.7960 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.6173 ns | 0.0373 ns | 0.0311 ns | 15.6192 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 17.4493 ns | 0.0198 ns | 0.0185 ns | 17.4448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.0131 ns | 0.0287 ns | 0.0268 ns | 17.0142 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.3434 ns | 0.0288 ns | 0.0240 ns | 13.3381 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.4527 ns | 0.0249 ns | 0.0221 ns | 20.4531 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.1974 ns | 0.0264 ns | 0.0234 ns | 20.1962 ns |  1.16 |    0.00 |      - |     - |     - |         - |
