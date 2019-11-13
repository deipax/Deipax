
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
             ToBool | .NET Core 2.0 |   0.8598 ns | 0.0031 ns | 0.0027 ns |   0.8597 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   0.8803 ns | 0.0179 ns | 0.0167 ns |   0.8820 ns |  1.02 |    0.02 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   0.9518 ns | 0.0035 ns | 0.0033 ns |   0.9508 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.4263 ns | 0.0014 ns | 0.0013 ns |   0.4264 ns |  0.50 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   0.7204 ns | 0.0021 ns | 0.0018 ns |   0.7203 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   3.9660 ns | 0.0057 ns | 0.0044 ns |   3.9645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.1169 ns | 0.0045 ns | 0.0042 ns |   4.1172 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   3.9906 ns | 0.0068 ns | 0.0063 ns |   3.9891 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.1748 ns | 0.0235 ns | 0.0220 ns |   4.1874 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.1426 ns | 0.0070 ns | 0.0066 ns |   4.1430 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   0.8889 ns | 0.0061 ns | 0.0057 ns |   0.8912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   0.8718 ns | 0.0024 ns | 0.0022 ns |   0.8718 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   0.9525 ns | 0.0029 ns | 0.0027 ns |   0.9520 ns |  1.07 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   0.4265 ns | 0.0018 ns | 0.0016 ns |   0.4267 ns |  0.48 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.7202 ns | 0.0022 ns | 0.0021 ns |   0.7205 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   3.9659 ns | 0.0029 ns | 0.0024 ns |   3.9662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.1093 ns | 0.0062 ns | 0.0058 ns |   4.1105 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   3.9727 ns | 0.0054 ns | 0.0048 ns |   3.9737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.1442 ns | 0.0047 ns | 0.0042 ns |   4.1450 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.1421 ns | 0.0040 ns | 0.0038 ns |   4.1421 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   0.8762 ns | 0.0017 ns | 0.0014 ns |   0.8770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   0.8719 ns | 0.0033 ns | 0.0027 ns |   0.8717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   0.9624 ns | 0.0078 ns | 0.0073 ns |   0.9648 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   0.4283 ns | 0.0018 ns | 0.0017 ns |   0.4288 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   0.7213 ns | 0.0092 ns | 0.0086 ns |   0.7187 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   3.9697 ns | 0.0079 ns | 0.0070 ns |   3.9702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   4.1109 ns | 0.0068 ns | 0.0057 ns |   4.1103 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   3.9940 ns | 0.0048 ns | 0.0045 ns |   3.9951 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   4.1876 ns | 0.0040 ns | 0.0038 ns |   4.1886 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   4.1516 ns | 0.0060 ns | 0.0053 ns |   4.1501 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   0.8509 ns | 0.0094 ns | 0.0087 ns |   0.8554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   0.8720 ns | 0.0031 ns | 0.0029 ns |   0.8723 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   1.1052 ns | 0.0026 ns | 0.0025 ns |   1.1049 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |   0.4140 ns | 0.0022 ns | 0.0021 ns |   0.4143 ns |  0.49 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   0.7455 ns | 0.0022 ns | 0.0018 ns |   0.7459 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   3.9642 ns | 0.0061 ns | 0.0057 ns |   3.9648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   4.1113 ns | 0.0057 ns | 0.0054 ns |   4.1118 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   3.9652 ns | 0.0045 ns | 0.0042 ns |   3.9644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   4.1538 ns | 0.0067 ns | 0.0062 ns |   4.1537 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   4.1389 ns | 0.0049 ns | 0.0046 ns |   4.1400 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   0.8594 ns | 0.0022 ns | 0.0020 ns |   0.8593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   1.4161 ns | 0.0023 ns | 0.0022 ns |   1.4156 ns |  1.65 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   1.1267 ns | 0.0038 ns | 0.0033 ns |   1.1266 ns |  1.31 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   0.4302 ns | 0.0021 ns | 0.0020 ns |   0.4299 ns |  0.50 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   0.7221 ns | 0.0040 ns | 0.0037 ns |   0.7214 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   3.9671 ns | 0.0060 ns | 0.0056 ns |   3.9665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   4.1156 ns | 0.0071 ns | 0.0066 ns |   4.1130 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.0328 ns | 0.0176 ns | 0.0164 ns |   4.0316 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   4.1476 ns | 0.0041 ns | 0.0037 ns |   4.1477 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   4.1357 ns | 0.0042 ns | 0.0037 ns |   4.1347 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   1.0445 ns | 0.0027 ns | 0.0025 ns |   1.0449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   0.8910 ns | 0.0106 ns | 0.0099 ns |   0.8956 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   0.9545 ns | 0.0020 ns | 0.0019 ns |   0.9541 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   0.4446 ns | 0.0062 ns | 0.0058 ns |   0.4454 ns |  0.43 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |   0.7217 ns | 0.0019 ns | 0.0017 ns |   0.7216 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   3.9651 ns | 0.0040 ns | 0.0038 ns |   3.9638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   4.1154 ns | 0.0063 ns | 0.0059 ns |   4.1171 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   3.9660 ns | 0.0066 ns | 0.0061 ns |   3.9650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   4.1579 ns | 0.0094 ns | 0.0088 ns |   4.1574 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   4.1411 ns | 0.0059 ns | 0.0055 ns |   4.1405 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   0.8765 ns | 0.0025 ns | 0.0022 ns |   0.8759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   0.8723 ns | 0.0022 ns | 0.0021 ns |   0.8723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   0.9531 ns | 0.0012 ns | 0.0012 ns |   0.9532 ns |  1.09 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |   0.4282 ns | 0.0025 ns | 0.0024 ns |   0.4275 ns |  0.49 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   0.7213 ns | 0.0089 ns | 0.0084 ns |   0.7168 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   3.9682 ns | 0.0055 ns | 0.0052 ns |   3.9677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   4.1141 ns | 0.0051 ns | 0.0047 ns |   4.1139 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   4.0015 ns | 0.0085 ns | 0.0079 ns |   4.0011 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   4.1509 ns | 0.0045 ns | 0.0042 ns |   4.1498 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   4.1496 ns | 0.0053 ns | 0.0050 ns |   4.1498 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   0.9546 ns | 0.0033 ns | 0.0026 ns |   0.9540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   0.8731 ns | 0.0040 ns | 0.0035 ns |   0.8727 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   0.9613 ns | 0.0081 ns | 0.0076 ns |   0.9639 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |   0.4366 ns | 0.0031 ns | 0.0027 ns |   0.4369 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   0.7439 ns | 0.0038 ns | 0.0029 ns |   0.7449 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   3.9658 ns | 0.0054 ns | 0.0051 ns |   3.9648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   4.1644 ns | 0.0135 ns | 0.0113 ns |   4.1682 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   3.9950 ns | 0.0066 ns | 0.0062 ns |   3.9978 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   4.1779 ns | 0.0220 ns | 0.0206 ns |   4.1898 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   4.1783 ns | 0.0053 ns | 0.0049 ns |   4.1790 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   0.9460 ns | 0.0033 ns | 0.0031 ns |   0.9458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   0.8736 ns | 0.0024 ns | 0.0021 ns |   0.8737 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   0.9541 ns | 0.0027 ns | 0.0025 ns |   0.9549 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   0.4282 ns | 0.0017 ns | 0.0016 ns |   0.4283 ns |  0.45 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   0.7191 ns | 0.0019 ns | 0.0018 ns |   0.7188 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   1.7313 ns | 0.0017 ns | 0.0016 ns |   1.7309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.3711 ns | 0.0037 ns | 0.0033 ns |   1.3718 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   1.6375 ns | 0.0027 ns | 0.0025 ns |   1.6370 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   1.5163 ns | 0.0112 ns | 0.0104 ns |   1.5124 ns |  0.88 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   1.5697 ns | 0.0142 ns | 0.0132 ns |   1.5641 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   1.0304 ns | 0.0028 ns | 0.0025 ns |   1.0311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   0.8731 ns | 0.0021 ns | 0.0018 ns |   0.8731 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   1.1264 ns | 0.0029 ns | 0.0027 ns |   1.1262 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   0.5753 ns | 0.0022 ns | 0.0020 ns |   0.5758 ns |  0.56 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   0.7222 ns | 0.0025 ns | 0.0023 ns |   0.7213 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   1.6875 ns | 0.0018 ns | 0.0017 ns |   1.6872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   1.6114 ns | 0.0034 ns | 0.0032 ns |   1.6109 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   1.8795 ns | 0.0145 ns | 0.0121 ns |   1.8843 ns |  1.11 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   1.6418 ns | 0.0038 ns | 0.0030 ns |   1.6423 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   1.8285 ns | 0.0035 ns | 0.0030 ns |   1.8281 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   0.9164 ns | 0.0033 ns | 0.0028 ns |   0.9165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   0.9097 ns | 0.0037 ns | 0.0035 ns |   0.9096 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   0.9779 ns | 0.0024 ns | 0.0022 ns |   0.9777 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.4237 ns | 0.0022 ns | 0.0021 ns |   0.4234 ns |  0.46 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.7148 ns | 0.0019 ns | 0.0018 ns |   0.7141 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.1769 ns | 0.0043 ns | 0.0040 ns |   4.1780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.3816 ns | 0.0287 ns | 0.0268 ns |   4.3841 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.0322 ns | 0.0097 ns | 0.0081 ns |   4.0330 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.3775 ns | 0.0062 ns | 0.0055 ns |   4.3789 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.3687 ns | 0.0051 ns | 0.0042 ns |   4.3685 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   0.9405 ns | 0.0025 ns | 0.0022 ns |   0.9405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   0.9106 ns | 0.0023 ns | 0.0021 ns |   0.9104 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   0.9798 ns | 0.0021 ns | 0.0019 ns |   0.9799 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.4235 ns | 0.0017 ns | 0.0014 ns |   0.4231 ns |  0.45 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.7460 ns | 0.0036 ns | 0.0032 ns |   0.7460 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.4434 ns | 0.0022 ns | 0.0019 ns |   1.4432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.3707 ns | 0.0042 ns | 0.0039 ns |   1.3707 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6371 ns | 0.0028 ns | 0.0026 ns |   1.6364 ns |  1.13 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.4058 ns | 0.0032 ns | 0.0030 ns |   1.4061 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.5818 ns | 0.0039 ns | 0.0036 ns |   1.5815 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   2.4680 ns | 0.0075 ns | 0.0063 ns |   2.4677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   2.7545 ns | 0.0061 ns | 0.0057 ns |   2.7531 ns |  1.12 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   3.0329 ns | 0.0077 ns | 0.0072 ns |   3.0317 ns |  1.23 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |   5.7603 ns | 0.0129 ns | 0.0114 ns |   5.7575 ns |  2.33 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |   5.7838 ns | 0.0405 ns | 0.0379 ns |   5.7589 ns |  2.34 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |   1.8463 ns | 0.0031 ns | 0.0029 ns |   1.8455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |   1.3806 ns | 0.0037 ns | 0.0034 ns |   1.3814 ns |  0.75 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |   1.6346 ns | 0.0035 ns | 0.0033 ns |   1.6343 ns |  0.89 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |   1.6300 ns | 0.0025 ns | 0.0023 ns |   1.6306 ns |  0.88 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |   1.8317 ns | 0.0038 ns | 0.0033 ns |   1.8320 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   0.9276 ns | 0.0035 ns | 0.0033 ns |   0.9266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   0.9068 ns | 0.0019 ns | 0.0018 ns |   0.9066 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   1.1842 ns | 0.0043 ns | 0.0040 ns |   1.1835 ns |  1.28 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.0024 ns | 0.0019 ns | 0.0015 ns |   1.0020 ns |  1.08 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.1493 ns | 0.0021 ns | 0.0020 ns |   1.1495 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   5.8496 ns | 0.0262 ns | 0.0232 ns |   5.8555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   5.0336 ns | 0.0030 ns | 0.0028 ns |   5.0341 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   5.1463 ns | 0.0207 ns | 0.0194 ns |   5.1494 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   5.8226 ns | 0.0060 ns | 0.0053 ns |   5.8226 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   5.7589 ns | 0.0078 ns | 0.0069 ns |   5.7597 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.1641 ns | 0.0089 ns | 0.0079 ns |   3.1664 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.6247 ns | 0.0087 ns | 0.0073 ns |   3.6255 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   3.7428 ns | 0.0430 ns | 0.0403 ns |   3.7710 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.6611 ns | 0.0073 ns | 0.0068 ns |   2.6619 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.7597 ns | 0.0102 ns | 0.0095 ns |   2.7607 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 308.2063 ns | 0.4275 ns | 0.3999 ns | 308.1778 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 2.2 | 271.8357 ns | 0.2810 ns | 0.2491 ns | 271.8145 ns |  0.88 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 3.0 | 218.6832 ns | 0.2116 ns | 0.1979 ns | 218.7325 ns |  0.71 |    0.00 | 0.0100 |     - |     - |      64 B |
          To_String |        net461 | 320.3530 ns | 0.4266 ns | 0.3991 ns | 320.2862 ns |  1.04 |    0.00 | 0.0300 |     - |     - |     192 B |
          To_String |        net472 | 321.7140 ns | 0.2912 ns | 0.2724 ns | 321.6940 ns |  1.04 |    0.00 | 0.0300 |     - |     - |     192 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |   9.3363 ns | 0.0112 ns | 0.0104 ns |   9.3356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |   9.2817 ns | 0.0121 ns | 0.0114 ns |   9.2789 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   7.0838 ns | 0.0357 ns | 0.0334 ns |   7.0667 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  11.4679 ns | 0.0126 ns | 0.0118 ns |  11.4716 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  11.4496 ns | 0.0364 ns | 0.0341 ns |  11.4558 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |   9.5893 ns | 0.0144 ns | 0.0135 ns |   9.5879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |   9.7906 ns | 0.0392 ns | 0.0306 ns |   9.8003 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   7.3250 ns | 0.0137 ns | 0.0121 ns |   7.3240 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  11.8667 ns | 0.0103 ns | 0.0096 ns |  11.8659 ns |  1.24 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  11.8780 ns | 0.0169 ns | 0.0141 ns |  11.8755 ns |  1.24 |    0.00 |      - |     - |     - |         - |
